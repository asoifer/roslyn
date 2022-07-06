// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis.FlowAnalysis;
using Microsoft.CodeAnalysis.Operations;
using Roslyn.Test.Utilities;
using Roslyn.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
public class OperationTreeVerifier : OperationWalker
{
protected readonly Compilation _compilation;

protected readonly IOperation _root;

protected readonly StringBuilder _builder;

private readonly Dictionary<SyntaxNode, IOperation> _explicitNodeMap;

private readonly Dictionary<ILabelSymbol, uint> _labelIdMap;

private const string 
indent = "  "
;

protected string _currentIndent;

private bool _pendingIndent;

private uint _currentLabelId ;

public OperationTreeVerifier(Compilation compilation, IOperation root, int initialIndent)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25060,1206,1671);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,764,776);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,817,822);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,866,874);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,937,953);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,1012,1023);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,1098,1112);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,1136,1150);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,1174,1193);
this._currentLabelId = 0;DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,1320,1347);

_compilation = compilation;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,1361,1374);

_root = root;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,1388,1419);

_builder = f_25060_1399_1418();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,1435,1483);

_currentIndent = f_25060_1452_1482(' ', initialIndent);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,1497,1519);

_pendingIndent = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,1535,1595);

_explicitNodeMap = f_25060_1554_1594();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,1609,1660);

_labelIdMap = f_25060_1623_1659();
DynAbs.Tracing.TraceSender.TraceExitConstructor(25060,1206,1671);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,1206,1671);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,1206,1671);
}
		}

public static string GetOperationTree(Compilation compilation, IOperation operation, int initialIndent = 0)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25060,1683,1990);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,1815,1893);

var 
walker = f_25060_1828_1892(compilation, operation, initialIndent)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,1907,1931);

f_25060_1907_1930(            walker, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,1945,1979);

return f_25060_1952_1978(walker._builder);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25060,1683,1990);

Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
f_25060_1828_1892(Microsoft.CodeAnalysis.Compilation
compilation,Microsoft.CodeAnalysis.IOperation
root,int
initialIndent)
{
var return_v = new Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier( compilation, root, initialIndent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 1828, 1892);
return return_v;
}


int
f_25060_1907_1930(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation)
{
this_param.Visit( operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 1907, 1930);
return 0;
}


string
f_25060_1952_1978(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 1952, 1978);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,1683,1990);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,1683,1990);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static bool Verify(string expectedOperationTree, string actualOperationTree)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25060,2002,2787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,2110,2166);

char[] 
newLineChars = f_25060_2132_2165(f_25060_2132_2151())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,2180,2235);

string 
actual = f_25060_2196_2234(actualOperationTree, newLineChars)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,2249,2287);

actual = f_25060_2258_2286(actual, "\"", "\"\"");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,2301,2366);

expectedOperationTree = f_25060_2325_2365(expectedOperationTree, newLineChars);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,2380,2483);

expectedOperationTree = f_25060_2404_2482(f_25060_2404_2447(expectedOperationTree, "\r\n", "\n"), "\n", f_25060_2462_2481());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,2497,2565);

expectedOperationTree = f_25060_2521_2564(expectedOperationTree, "\"", "\"\"");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,2648,2746);

var 
toReturn = f_25060_2663_2745(expectedOperationTree, actual)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,2760,2776);

return toReturn;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25060,2002,2787);

string
f_25060_2132_2151()
{
var return_v = Environment.NewLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 2132, 2151);
return return_v;
}


char[]
f_25060_2132_2165(string
this_param)
{
var return_v = this_param.ToCharArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 2132, 2165);
return return_v;
}


string
f_25060_2196_2234(string
this_param,params char[]
trimChars)
{
var return_v = this_param.Trim( trimChars);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 2196, 2234);
return return_v;
}


string
f_25060_2258_2286(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 2258, 2286);
return return_v;
}


string
f_25060_2325_2365(string
this_param,params char[]
trimChars)
{
var return_v = this_param.Trim( trimChars);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 2325, 2365);
return return_v;
}


string
f_25060_2404_2447(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 2404, 2447);
return return_v;
}


string
f_25060_2462_2481()
{
var return_v = Environment.NewLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 2462, 2481);
return return_v;
}


string
f_25060_2404_2482(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 2404, 2482);
return return_v;
}


string
f_25060_2521_2564(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 2521, 2564);
return return_v;
}


bool
f_25060_2663_2745(string
expected,string
actual)
{
var return_v = AssertEx.AssertEqualToleratingWhitespaceDifferences( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 2663, 2745);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,2002,2787);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,2002,2787);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void LogPatternPropertiesAndNewLine(IPatternOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,2834,3030);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,2931,2963);

f_25060_2931_2962(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,2977,2992);

f_25060_2977_2991(this, ")");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,3006,3019);

f_25060_3006_3018(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,2834,3030);

int
f_25060_2931_2962(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IPatternOperation
operation)
{
this_param.LogPatternProperties( operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 2931, 2962);
return 0;
}


int
f_25060_2977_2991(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 2977, 2991);
return 0;
}


int
f_25060_3006_3018(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 3006, 3018);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,2834,3030);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,2834,3030);
}
		}

private void LogPatternProperties(IPatternOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,3042,3391);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,3129,3160);

f_25060_3129_3159(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,3174,3190);

f_25060_3174_3189(this, " (");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,3204,3267);

f_25060_3204_3266(this, f_25060_3212_3231(operation), $"{nameof(operation.InputType)}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,3281,3297);

f_25060_3281_3296(this, ", ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,3311,3380);

f_25060_3311_3379(this, f_25060_3319_3341(operation), $"{nameof(operation.NarrowedType)}");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,3042,3391);

int
f_25060_3129_3159(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IPatternOperation
operation)
{
this_param.LogCommonProperties( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 3129, 3159);
return 0;
}


int
f_25060_3174_3189(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 3174, 3189);
return 0;
}


Microsoft.CodeAnalysis.ITypeSymbol
f_25060_3212_3231(Microsoft.CodeAnalysis.Operations.IPatternOperation
this_param)
{
var return_v = this_param.InputType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 3212, 3231);
return return_v;
}


int
f_25060_3204_3266(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.ITypeSymbol
type,string
header)
{
this_param.LogType( type, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 3204, 3266);
return 0;
}


int
f_25060_3281_3296(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 3281, 3296);
return 0;
}


Microsoft.CodeAnalysis.ITypeSymbol
f_25060_3319_3341(Microsoft.CodeAnalysis.Operations.IPatternOperation
this_param)
{
var return_v = this_param.NarrowedType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 3319, 3341);
return return_v;
}


int
f_25060_3311_3379(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.ITypeSymbol
type,string
header)
{
this_param.LogType( type, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 3311, 3379);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,3042,3391);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,3042,3391);
}
		}

private void LogCommonPropertiesAndNewLine(IOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,3403,3561);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,3492,3523);

f_25060_3492_3522(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,3537,3550);

f_25060_3537_3549(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,3403,3561);

int
f_25060_3492_3522(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation)
{
this_param.LogCommonProperties( operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 3492, 3522);
return 0;
}


int
f_25060_3537_3549(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 3537, 3549);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,3403,3561);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,3403,3561);
}
		}

private void LogCommonProperties(IOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,3573,5473);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,3652,3668);

f_25060_3652_3667(this, " (");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,3705,3773);

f_25060_3705_3772(this, $"{nameof(OperationKind)}.{f_25060_3742_3769(f_25060_3754_3768(operation))}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,3810,3826);

f_25060_3810_3825(this, ", ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,3840,3864);

f_25060_3840_3863(this, f_25060_3848_3862(operation));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,3910,4066) || true) && (operation.ConstantValue.HasValue)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,3910,4066);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,3980,3996);

f_25060_3980_3995(this, ", ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,4014,4051);

f_25060_4014_4050(this, f_25060_4026_4049(operation));
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,3910,4066);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,4108,4219) || true) && (f_25060_4112_4145(operation, _compilation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,4108,4219);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,4179,4204);

f_25060_4179_4203(this, ", IsInvalid");
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,4108,4219);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,4262,4361) || true) && (f_25060_4266_4286(operation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,4262,4361);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,4320,4346);

f_25060_4320_4345(this, ", IsImplicit");
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,4262,4361);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,4377,4392);

f_25060_4377_4391(this, ")");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,4431,4464);

f_25060_4431_4463(f_25060_4446_4462(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,4478,4544);

f_25060_4478_4543(this, $" (Syntax: {f_25060_4501_4539(f_25060_4522_4538(operation))})");

string GetKindText(OperationKind kind)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,4762,5462);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,4833,5447);

switch (kind)
                {

case OperationKind.Unary:
DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,4833,5447);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,4938,4953);

return "Unary";
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,4833,5447);

case OperationKind.Binary:
DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,4833,5447);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,5027,5043);

return "Binary";
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,4833,5447);

case OperationKind.TupleBinary:
DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,4833,5447);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,5122,5143);

return "TupleBinary";
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,4833,5447);

case OperationKind.MethodBody:
DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,4833,5447);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,5221,5241);

return "MethodBody";
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,4833,5447);

case OperationKind.ConstructorBody:
DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,4833,5447);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,5324,5349);

return "ConstructorBody";
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,4833,5447);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,4833,5447);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,5405,5428);

return f_25060_5412_5427(kind);
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,4833,5447);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,4762,5462);

string
f_25060_5412_5427(Microsoft.CodeAnalysis.OperationKind
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 5412, 5427);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,4762,5462);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,4762,5462);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,3573,5473);

int
f_25060_3652_3667(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 3652, 3667);
return 0;
}


Microsoft.CodeAnalysis.OperationKind
f_25060_3754_3768(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 3754, 3768);
return return_v;
}


string
f_25060_3742_3769(Microsoft.CodeAnalysis.OperationKind
kind)
{
var return_v = GetKindText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 3742, 3769);
return return_v;
}


int
f_25060_3705_3772(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 3705, 3772);
return 0;
}


int
f_25060_3810_3825(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 3810, 3825);
return 0;
}


Microsoft.CodeAnalysis.ITypeSymbol?
f_25060_3848_3862(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 3848, 3862);
return return_v;
}


int
f_25060_3840_3863(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.ITypeSymbol?
type)
{
this_param.LogType( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 3840, 3863);
return 0;
}


int
f_25060_3980_3995(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 3980, 3995);
return 0;
}


Microsoft.CodeAnalysis.Optional<object?>
f_25060_4026_4049(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 4026, 4049);
return return_v;
}


int
f_25060_4014_4050(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Optional<object?>
constant)
{
this_param.LogConstant( constant);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 4014, 4050);
return 0;
}


bool
f_25060_4112_4145(Microsoft.CodeAnalysis.IOperation
operation,Microsoft.CodeAnalysis.Compilation
compilation)
{
var return_v = operation.HasErrors( compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 4112, 4145);
return return_v;
}


int
f_25060_4179_4203(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 4179, 4203);
return 0;
}


bool
f_25060_4266_4286(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.IsImplicit;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 4266, 4286);
return return_v;
}


int
f_25060_4320_4345(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 4320, 4345);
return 0;
}


int
f_25060_4377_4391(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 4377, 4391);
return 0;
}


Microsoft.CodeAnalysis.SyntaxNode
f_25060_4446_4462(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Syntax;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 4446, 4462);
return return_v;
}


int
f_25060_4431_4463(Microsoft.CodeAnalysis.SyntaxNode
@object)
{
Assert.NotNull( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 4431, 4463);
return 0;
}


Microsoft.CodeAnalysis.SyntaxNode
f_25060_4522_4538(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Syntax;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 4522, 4538);
return return_v;
}


string
f_25060_4501_4539(Microsoft.CodeAnalysis.SyntaxNode
syntax)
{
var return_v = GetSnippetFromSyntax( syntax);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 4501, 4539);
return return_v;
}


int
f_25060_4478_4543(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 4478, 4543);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,3573,5473);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,3573,5473);
}
		}

private static string GetSnippetFromSyntax(SyntaxNode syntax)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25060,5485,6466);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,5571,5652) || true) && (syntax == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,5571,5652);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,5623,5637);

return "null";
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,5571,5652);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,5668,5737);

var 
text = f_25060_5679_5736(f_25060_5679_5696(syntax), f_25060_5702_5735(f_25060_5702_5721()))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,5751,5888);

var 
lines = f_25060_5763_5887(f_25060_5763_5877(f_25060_5763_5855(text, new[] { f_25060_5782_5801(), "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries), l => l.Trim()))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,5902,6011) || true) && (f_25060_5906_5918(lines)<= 1 &&(DynAbs.Tracing.TraceSender.Expression_True(25060, 5906, 5943)&&f_25060_5927_5938(text)< 25))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,5902,6011);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,5977,5996);

return $"'{text}'";
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,5902,6011);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,6027,6057);

const int 
maxTokenLength = 11
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,6071,6096);

var 
firstLine = lines[0]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,6110,6149);

var 
lastLine = lines[f_25060_6131_6143(lines)- 1]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,6163,6264);

var 
prefix = (DynAbs.Tracing.TraceSender.Conditional_F1(25060, 6176, 6210)||((f_25060_6176_6192(firstLine)<= maxTokenLength &&DynAbs.Tracing.TraceSender.Conditional_F2(25060, 6213, 6222))||DynAbs.Tracing.TraceSender.Conditional_F3(25060, 6225, 6263)))?firstLine :f_25060_6225_6263(firstLine, 0, maxTokenLength)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,6278,6407);

var 
suffix = (DynAbs.Tracing.TraceSender.Conditional_F1(25060, 6291, 6324)||((f_25060_6291_6306(lastLine)<= maxTokenLength &&DynAbs.Tracing.TraceSender.Conditional_F2(25060, 6327, 6335))||DynAbs.Tracing.TraceSender.Conditional_F3(25060, 6338, 6406)))?lastLine :f_25060_6338_6406(lastLine, f_25060_6357_6372(lastLine)- maxTokenLength, maxTokenLength)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,6421,6455);

return $"'{prefix} ... {suffix}'";
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25060,5485,6466);

string
f_25060_5679_5696(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 5679, 5696);
return return_v;
}


string
f_25060_5702_5721()
{
var return_v = Environment.NewLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 5702, 5721);
return return_v;
}


char[]
f_25060_5702_5735(string
this_param)
{
var return_v = this_param.ToCharArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 5702, 5735);
return return_v;
}


string
f_25060_5679_5736(string
this_param,params char[]
trimChars)
{
var return_v = this_param.Trim( trimChars);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 5679, 5736);
return return_v;
}


string
f_25060_5782_5801()
{
var return_v = Environment.NewLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 5782, 5801);
return return_v;
}


string[]
f_25060_5763_5855(string
this_param,string[]
separator,System.StringSplitOptions
options)
{
var return_v = this_param.Split( separator, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 5763, 5855);
return return_v;
}


System.Collections.Generic.IEnumerable<string>
f_25060_5763_5877(string[]
source,System.Func<string, string>
selector)
{
var return_v = source.Select<string,string>( selector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 5763, 5877);
return return_v;
}


string[]
f_25060_5763_5887(System.Collections.Generic.IEnumerable<string>
source)
{
var return_v = source.ToArray<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 5763, 5887);
return return_v;
}


int
f_25060_5906_5918(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 5906, 5918);
return return_v;
}


int
f_25060_5927_5938(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 5927, 5938);
return return_v;
}


int
f_25060_6131_6143(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 6131, 6143);
return return_v;
}


int
f_25060_6176_6192(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 6176, 6192);
return return_v;
}


string
f_25060_6225_6263(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 6225, 6263);
return return_v;
}


int
f_25060_6291_6306(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 6291, 6306);
return return_v;
}


int
f_25060_6357_6372(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 6357, 6372);
return return_v;
}


string
f_25060_6338_6406(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 6338, 6406);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,5485,6466);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,5485,6466);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool ShouldLogType(IOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25060,6478,6794);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,6558,6598);

var 
operationKind = (int)f_25060_6583_6597(operation)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,6642,6754) || true) && (operationKind >= 0x100 &&(DynAbs.Tracing.TraceSender.Expression_True(25060, 6646, 6693)&&operationKind < 0x400))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,6642,6754);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,6727,6739);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,6642,6754);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,6770,6783);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25060,6478,6794);

Microsoft.CodeAnalysis.OperationKind
f_25060_6583_6597(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 6583, 6597);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,6478,6794);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,6478,6794);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected void LogString(string str)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,6806,7050);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,6867,7002) || true) && (_pendingIndent)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,6867,7002);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,6919,6946);

str = _currentIndent + str;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,6964,6987);

_pendingIndent = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,6867,7002);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,7018,7039);

f_25060_7018_7038(
            _builder, str);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,6806,7050);

System.Text.StringBuilder
f_25060_7018_7038(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 7018, 7038);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,6806,7050);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,6806,7050);
}
		}

protected void LogNewLine()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,7062,7192);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,7114,7145);

f_25060_7114_7144(this, f_25060_7124_7143());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,7159,7181);

_pendingIndent = true;
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,7062,7192);

string
f_25060_7124_7143()
{
var return_v = Environment.NewLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 7124, 7143);
return return_v;
}


int
f_25060_7114_7144(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 7114, 7144);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,7062,7192);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,7062,7192);
}
		}

private void Indent()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,7204,7286);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,7250,7275);

_currentIndent += indent;
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,7204,7286);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,7204,7286);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,7204,7286);
}
		}

private void Unindent()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,7298,7414);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,7346,7403);

_currentIndent = f_25060_7363_7402(_currentIndent, f_25060_7388_7401(indent));
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,7298,7414);

int
f_25060_7388_7401(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 7388, 7401);
return return_v;
}


string
f_25060_7363_7402(string
this_param,int
startIndex)
{
var return_v = this_param.Substring( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 7363, 7402);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,7298,7414);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,7298,7414);
}
		}

private void LogConstant(Optional<object> constant, string header = "Constant")
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,7426,7647);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,7530,7636) || true) && (constant.HasValue)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,7530,7636);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,7585,7621);

f_25060_7585_7620(this, constant.Value, header);
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,7530,7636);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,7426,7647);

int
f_25060_7585_7620(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,object
constant,string
header)
{
this_param.LogConstant( constant, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 7585, 7620);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,7426,7647);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,7426,7647);
}
		}

private static string ConstantToString(object constant, bool quoteString = true)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25060,7659,8293);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,7764,8282);

switch (constant)
            {

case null:
DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,7764,8282);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,7846,7860);

return "null";
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,7764,8282);

case string s:
DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,7764,8282);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,7914,8027) || true) && (quoteString)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,7914,8027);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,7979,8004);

return @"""" + s + @"""";
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,7914,8027);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,8049,8058);

return s;
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,7764,8282);

case IFormattable formattable:
DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,7764,8282);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,8128,8192);

return f_25060_8135_8191(formattable, null, f_25060_8162_8190());
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,7764,8282);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,7764,8282);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,8240,8267);

return f_25060_8247_8266(constant);
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,7764,8282);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25060,7659,8293);

System.Globalization.CultureInfo
f_25060_8162_8190()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 8162, 8190);
return return_v;
}


string
f_25060_8135_8191(System.IFormattable
this_param,string?
format,System.Globalization.CultureInfo
formatProvider)
{
var return_v = this_param.ToString( format, (System.IFormatProvider)formatProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 8135, 8191);
return return_v;
}


string?
f_25060_8247_8266(object
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 8247, 8266);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,7659,8293);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,7659,8293);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void LogConstant(object constant, string header = "Constant")
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,8305,8506);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,8399,8444);

string 
valueStr = f_25060_8417_8443(constant)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,8460,8495);

f_25060_8460_8494(this, $"{header}: {valueStr}");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,8305,8506);

string
f_25060_8417_8443(object
constant)
{
var return_v = ConstantToString( constant);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 8417, 8443);
return return_v;
}


int
f_25060_8460_8494(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 8460, 8494);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,8305,8506);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,8305,8506);
}
		}

private void LogConversion(CommonConversion conversion, string header = "Conversion")
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,8518,9394);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,8628,8706);

var 
exists = f_25060_8641_8705(nameof(conversion.Exists), conversion.Exists)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,8722,8812);

var 
isIdentity = f_25060_8739_8811(nameof(conversion.IsIdentity), conversion.IsIdentity)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,8826,8913);

var 
isNumeric = f_25060_8842_8912(nameof(conversion.IsNumeric), conversion.IsNumeric)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,8927,9020);

var 
isReference = f_25060_8945_9019(nameof(conversion.IsReference), conversion.IsReference)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,9034,9133);

var 
isUserDefined = f_25060_9054_9132(nameof(conversion.IsUserDefined), conversion.IsUserDefined)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,9149,9272);

f_25060_9149_9271(this, $"{header}: {nameof(CommonConversion)} ({exists}, {isIdentity}, {isNumeric}, {isReference}, {isUserDefined}) (");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,9286,9354);

f_25060_9286_9353(this, conversion.MethodSymbol, nameof(conversion.MethodSymbol));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,9368,9383);

f_25060_9368_9382(this, ")");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,8518,9394);

string
f_25060_8641_8705(string
propertyName,bool
value)
{
var return_v = FormatBoolProperty( propertyName, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 8641, 8705);
return return_v;
}


string
f_25060_8739_8811(string
propertyName,bool
value)
{
var return_v = FormatBoolProperty( propertyName, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 8739, 8811);
return return_v;
}


string
f_25060_8842_8912(string
propertyName,bool
value)
{
var return_v = FormatBoolProperty( propertyName, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 8842, 8912);
return return_v;
}


string
f_25060_8945_9019(string
propertyName,bool
value)
{
var return_v = FormatBoolProperty( propertyName, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 8945, 9019);
return return_v;
}


string
f_25060_9054_9132(string
propertyName,bool
value)
{
var return_v = FormatBoolProperty( propertyName, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 9054, 9132);
return return_v;
}


int
f_25060_9149_9271(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 9149, 9271);
return 0;
}


int
f_25060_9286_9353(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IMethodSymbol?
symbol,string
header)
{
this_param.LogSymbol( (Microsoft.CodeAnalysis.ISymbol?)symbol, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 9286, 9353);
return 0;
}


int
f_25060_9368_9382(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 9368, 9382);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,8518,9394);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,8518,9394);
}
		}

private void LogSymbol(ISymbol symbol, string header, bool logDisplayString = true)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,9406,9794);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,9514,9621) || true) && (!f_25060_9519_9547(header))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,9514,9621);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,9581,9606);

f_25060_9581_9605(this, $"{header}: ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,9514,9621);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,9637,9743);

var 
symbolStr = (DynAbs.Tracing.TraceSender.Conditional_F1(25060, 9653, 9667)||((symbol != null &&DynAbs.Tracing.TraceSender.Conditional_F2(25060, 9670, 9733))||DynAbs.Tracing.TraceSender.Conditional_F3(25060, 9736, 9742)))?((DynAbs.Tracing.TraceSender.Conditional_F1(25060, 9671, 9687)||((logDisplayString &&DynAbs.Tracing.TraceSender.Conditional_F2(25060, 9690, 9718))||DynAbs.Tracing.TraceSender.Conditional_F3(25060, 9721, 9732)))?f_25060_9690_9718(symbol):f_25060_9721_9732(symbol)) :"null"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,9757,9783);

f_25060_9757_9782(this, $"{symbolStr}");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,9406,9794);

bool
f_25060_9519_9547(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 9519, 9547);
return return_v;
}


int
f_25060_9581_9605(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 9581, 9605);
return 0;
}


string
f_25060_9690_9718(Microsoft.CodeAnalysis.ISymbol
symbol)
{
var return_v = symbol.ToTestDisplayString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 9690, 9718);
return return_v;
}


string
f_25060_9721_9732(Microsoft.CodeAnalysis.ISymbol
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 9721, 9732);
return return_v;
}


int
f_25060_9757_9782(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 9757, 9782);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,9406,9794);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,9406,9794);
}
		}

private void LogType(ITypeSymbol type, string header = "Type")
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,9806,10017);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,9893,9958);

var 
typeStr = (DynAbs.Tracing.TraceSender.Conditional_F1(25060, 9907, 9919)||((type != null &&DynAbs.Tracing.TraceSender.Conditional_F2(25060, 9922, 9948))||DynAbs.Tracing.TraceSender.Conditional_F3(25060, 9951, 9957)))?f_25060_9922_9948(type):"null"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,9972,10006);

f_25060_9972_10005(this, $"{header}: {typeStr}");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,9806,10017);

string
f_25060_9922_9948(Microsoft.CodeAnalysis.ITypeSymbol
symbol)
{
var return_v = symbol.ToTestDisplayString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 9922, 9948);
return return_v;
}


int
f_25060_9972_10005(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 9972, 10005);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,9806,10017);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,9806,10017);
}
		}

private uint GetLabelId(ILabelSymbol symbol)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,10029,10326);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,10098,10209) || true) && (f_25060_10102_10133(_labelIdMap, symbol))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,10098,10209);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,10167,10194);

return f_25060_10174_10193(_labelIdMap, symbol);
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,10098,10209);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,10225,10252);

var 
id = _currentLabelId++
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,10266,10291);

_labelIdMap[symbol] = id;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,10305,10315);

return id;
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,10029,10326);

bool
f_25060_10102_10133(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ILabelSymbol, uint>
this_param,Microsoft.CodeAnalysis.ILabelSymbol
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 10102, 10133);
return return_v;
}


uint
f_25060_10174_10193(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ILabelSymbol, uint>
this_param,Microsoft.CodeAnalysis.ILabelSymbol
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 10174, 10193);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,10029,10326);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,10029,10326);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static string FormatBoolProperty(string propertyName, bool value) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,10412,10462);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,10415,10462);
return $"{propertyName}: {((DynAbs.Tracing.TraceSender.Conditional_F1(25060, 10435, 10440)||((value &&DynAbs.Tracing.TraceSender.Conditional_F2(25060, 10443, 10449))||DynAbs.Tracing.TraceSender.Conditional_F3(25060, 10452, 10459)))?"True" :"False")}";DynAbs.Tracing.TraceSender.TraceExitMethod(25060,10412,10462);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,10412,10462);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,10412,10462);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override void Visit(IOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,10530,11677);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,10603,10803) || true) && (operation == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,10603,10803);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,10658,10667);

f_25060_10658_10666(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,10685,10703);

f_25060_10685_10702(this, "null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,10721,10734);

f_25060_10721_10733(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,10752,10763);

f_25060_10752_10762(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,10781,10788);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,10603,10803);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,10819,11227) || true) && (f_25060_10823_10844_M(!operation.IsImplicit))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,10819,11227);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,10922,10972);

f_25060_10922_10971(                    _explicitNodeMap, f_25060_10943_10959(operation), operation);
                }
                catch (ArgumentException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(25060,11009,11212);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,11075,11193);

f_25060_11075_11192(true, $"Duplicate explicit node for syntax ({f_25060_11133_11157(f_25060_11133_11149(operation))}): {f_25060_11162_11189(f_25060_11162_11178(operation))}");
DynAbs.Tracing.TraceSender.TraceExitCatch(25060,11009,11212);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,10819,11227);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,11243,11359);

f_25060_11243_11358(f_25060_11255_11269(operation)== null ||(DynAbs.Tracing.TraceSender.Expression_False(25060, 11255, 11310)||!f_25060_11282_11310(operation)), $"Unexpected non-null type: {f_25060_11341_11355(operation)}");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,11375,11455) || true) && (operation != _root)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,11375,11455);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,11431,11440);

f_25060_11431_11439(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,11375,11455);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,11471,11493);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(operation),25060,11471,11492);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,11509,11591) || true) && (operation != _root)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,11509,11591);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,11565,11576);

f_25060_11565_11575(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,11509,11591);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,11605,11666);

f_25060_11605_11665(f_25060_11617_11642(f_25060_11617_11633(operation))== f_25060_11646_11664(operation));
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,10530,11677);

int
f_25060_10658_10666(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Indent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 10658, 10666);
return 0;
}


int
f_25060_10685_10702(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 10685, 10702);
return 0;
}


int
f_25060_10721_10733(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 10721, 10733);
return 0;
}


int
f_25060_10752_10762(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Unindent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 10752, 10762);
return 0;
}


bool
f_25060_10823_10844_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 10823, 10844);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_25060_10943_10959(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Syntax;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 10943, 10959);
return return_v;
}


int
f_25060_10922_10971(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.IOperation>
this_param,Microsoft.CodeAnalysis.SyntaxNode
key,Microsoft.CodeAnalysis.IOperation
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 10922, 10971);
return 0;
}


Microsoft.CodeAnalysis.SyntaxNode
f_25060_11133_11149(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Syntax;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 11133, 11149);
return return_v;
}


int
f_25060_11133_11157(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.RawKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 11133, 11157);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_25060_11162_11178(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Syntax;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 11162, 11178);
return return_v;
}


string
f_25060_11162_11189(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 11162, 11189);
return return_v;
}


int
f_25060_11075_11192(bool
condition,string
userMessage)
{
Assert.False( condition, userMessage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 11075, 11192);
return 0;
}


Microsoft.CodeAnalysis.ITypeSymbol?
f_25060_11255_11269(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 11255, 11269);
return return_v;
}


bool
f_25060_11282_11310(Microsoft.CodeAnalysis.IOperation
operation)
{
var return_v = operation.MustHaveNullType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 11282, 11310);
return return_v;
}


Microsoft.CodeAnalysis.ITypeSymbol?
f_25060_11341_11355(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 11341, 11355);
return return_v;
}


int
f_25060_11243_11358(bool
condition,string
userMessage)
{
Assert.True( condition, userMessage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 11243, 11358);
return 0;
}


int
f_25060_11431_11439(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Indent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 11431, 11439);
return 0;
}


int
f_25060_11565_11575(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Unindent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 11565, 11575);
return 0;
}


Microsoft.CodeAnalysis.SyntaxNode
f_25060_11617_11633(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Syntax;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 11617, 11633);
return return_v;
}


string
f_25060_11617_11642(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Language ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 11617, 11642);
return return_v;
}


string
f_25060_11646_11664(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Language;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 11646, 11664);
return return_v;
}


int
f_25060_11605_11665(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 11605, 11665);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,10530,11677);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,10530,11677);
}
		}

private void Visit(IOperation operation, string header)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,11689,11971);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,11769,11813);

f_25060_11769_11812(!f_25060_11783_11811(header));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,11829,11838);

f_25060_11829_11837(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,11852,11877);

f_25060_11852_11876(this, $"{header}: ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,11891,11904);

f_25060_11891_11903(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,11918,11935);

f_25060_11918_11934(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,11949,11960);

f_25060_11949_11959(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,11689,11971);

bool
f_25060_11783_11811(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 11783, 11811);
return return_v;
}


int
f_25060_11769_11812(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 11769, 11812);
return 0;
}


int
f_25060_11829_11837(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Indent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 11829, 11837);
return 0;
}


int
f_25060_11852_11876(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 11852, 11876);
return 0;
}


int
f_25060_11891_11903(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 11891, 11903);
return 0;
}


int
f_25060_11918_11934(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation)
{
this_param.Visit( operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 11918, 11934);
return 0;
}


int
f_25060_11949_11959(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Unindent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 11949, 11959);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,11689,11971);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,11689,11971);
}
		}

private void VisitArrayCommon<T>(ImmutableArray<T> list, string header, bool logElementCount, bool logNullForDefault, Action<T> arrayElementVisitor)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,11983,12917);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,12156,12200);

f_25060_12156_12199(!f_25060_12170_12198(header));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,12216,12225);

f_25060_12216_12224(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,12239,12879) || true) && (f_25060_12243_12265_M(!list.IsDefaultOrEmpty))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,12239,12879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,12299,12371);

var 
elementCount = (DynAbs.Tracing.TraceSender.Conditional_F1(25060, 12318, 12333)||((logElementCount &&DynAbs.Tracing.TraceSender.Conditional_F2(25060, 12336, 12355))||DynAbs.Tracing.TraceSender.Conditional_F3(25060, 12358, 12370)))?$"({f_25060_12340_12352(ref list)})" :string.Empty
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,12389,12427);

f_25060_12389_12426(this, $"{header}{elementCount}:");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,12445,12458);

f_25060_12445_12457(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,12476,12485);

f_25060_12476_12484(this);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,12503,12621);
foreach(var element in f_25060_12527_12531_I(list) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,12503,12621);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,12573,12602);

f_25060_12573_12601(arrayElementVisitor, element);
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,12503,12621);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25060,1,119);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25060,1,119);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,12639,12650);

f_25060_12639_12649(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,12239,12879);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,12239,12879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,12716,12784);

var 
suffix = (DynAbs.Tracing.TraceSender.Conditional_F1(25060, 12729, 12764)||((logNullForDefault &&(DynAbs.Tracing.TraceSender.Expression_True(25060, 12729, 12764)&&list.IsDefault )&&DynAbs.Tracing.TraceSender.Conditional_F2(25060, 12767, 12775))||DynAbs.Tracing.TraceSender.Conditional_F3(25060, 12778, 12783)))?": null" :"(0)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,12802,12833);

f_25060_12802_12832(this, $"{header}{suffix}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,12851,12864);

f_25060_12851_12863(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,12239,12879);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,12895,12906);

f_25060_12895_12905(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,11983,12917);

bool
f_25060_12170_12198(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 12170, 12198);
return return_v;
}


int
f_25060_12156_12199(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 12156, 12199);
return 0;
}


int
f_25060_12216_12224(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Indent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 12216, 12224);
return 0;
}


bool
f_25060_12243_12265_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 12243, 12265);
return return_v;
}


int
f_25060_12340_12352(ref System.Collections.Immutable.ImmutableArray<T>
source)
{
var return_v = source.Count<T>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 12340, 12352);
return return_v;
}


int
f_25060_12389_12426(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 12389, 12426);
return 0;
}


int
f_25060_12445_12457(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 12445, 12457);
return 0;
}


int
f_25060_12476_12484(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Indent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 12476, 12484);
return 0;
}


int
f_25060_12573_12601(System.Action<T>
this_param,T
obj)
{
this_param.Invoke( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 12573, 12601);
return 0;
}


System.Collections.Immutable.ImmutableArray<T>
f_25060_12527_12531_I(System.Collections.Immutable.ImmutableArray<T>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 12527, 12531);
return return_v;
}


int
f_25060_12639_12649(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Unindent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 12639, 12649);
return 0;
}


int
f_25060_12802_12832(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 12802, 12832);
return 0;
}


int
f_25060_12851_12863(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 12851, 12863);
return 0;
}


int
f_25060_12895_12905(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Unindent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 12895, 12905);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,11983,12917);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,11983,12917);
}
		}

internal void VisitSymbolArrayElement(ISymbol element)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,12929,13083);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,13008,13045);

f_25060_13008_13044(this, element, header: "Symbol");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,13059,13072);

f_25060_13059_13071(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,12929,13083);

int
f_25060_13008_13044(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.ISymbol
symbol,string
header)
{
this_param.LogSymbol( symbol, header: header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 13008, 13044);
return 0;
}


int
f_25060_13059_13071(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 13059, 13071);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,12929,13083);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,12929,13083);
}
		}

internal void VisitStringArrayElement(string element)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,13095,13356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,13173,13234);

var 
valueStr = (DynAbs.Tracing.TraceSender.Conditional_F1(25060, 13188, 13203)||((element != null &&DynAbs.Tracing.TraceSender.Conditional_F2(25060, 13206, 13224))||DynAbs.Tracing.TraceSender.Conditional_F3(25060, 13227, 13233)))?f_25060_13206_13224(element):"null"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,13248,13284);

valueStr = @"""" + valueStr + @"""";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,13298,13318);

f_25060_13298_13317(this, valueStr);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,13332,13345);

f_25060_13332_13344(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,13095,13356);

string
f_25060_13206_13224(string
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 13206, 13224);
return return_v;
}


int
f_25060_13298_13317(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 13298, 13317);
return 0;
}


int
f_25060_13332_13344(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 13332, 13344);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,13095,13356);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,13095,13356);
}
		}

internal void VisitRefKindArrayElement(RefKind element)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,13368,13516);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,13448,13478);

f_25060_13448_13477(this, f_25060_13458_13476(element));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,13492,13505);

f_25060_13492_13504(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,13368,13516);

string
f_25060_13458_13476(Microsoft.CodeAnalysis.RefKind
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 13458, 13476);
return return_v;
}


int
f_25060_13448_13477(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 13448, 13477);
return 0;
}


int
f_25060_13492_13504(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 13492, 13504);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,13368,13516);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,13368,13516);
}
		}

private void VisitChildren(IOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,13528,13914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,13601,13654);

f_25060_13601_13653(f_25060_13614_13652(f_25060_13614_13632(operation), o => o != null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,13670,13723);

var 
children = f_25060_13685_13722(f_25060_13685_13703(operation))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,13737,13903) || true) && (f_25060_13741_13758_M(!children.IsEmpty)||(DynAbs.Tracing.TraceSender.Expression_False(25060, 13741, 13798)||f_25060_13762_13776(operation)!= OperationKind.None))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,13737,13903);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,13832,13888);

f_25060_13832_13887(this, children, "Children", logElementCount: true);
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,13737,13903);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,13528,13914);

System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
f_25060_13614_13632(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Children;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 13614, 13632);
return return_v;
}


bool
f_25060_13614_13652(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
source,System.Func<Microsoft.CodeAnalysis.IOperation, bool>
predicate)
{
var return_v = source.All<Microsoft.CodeAnalysis.IOperation>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 13614, 13652);
return return_v;
}


int
f_25060_13601_13653(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 13601, 13653);
return 0;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
f_25060_13685_13703(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Children;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 13685, 13703);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
f_25060_13685_13722(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
items)
{
var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.IOperation>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 13685, 13722);
return return_v;
}


bool
f_25060_13741_13758_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 13741, 13758);
return return_v;
}


Microsoft.CodeAnalysis.OperationKind
f_25060_13762_13776(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 13762, 13776);
return return_v;
}


int
f_25060_13832_13887(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
list,string
header,bool
logElementCount)
{
this_param.VisitArray<Microsoft.CodeAnalysis.IOperation>( list, header, logElementCount: logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 13832, 13887);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,13528,13914);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,13528,13914);
}
		}

private void VisitArray<T>(ImmutableArray<T> list, string header, bool logElementCount, bool logNullForDefault = false)
            where T : IOperation
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,13926,14197);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,14104,14186);

f_25060_14104_14185(this, list, header, logElementCount, logNullForDefault, o => Visit(o));
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,13926,14197);

int
f_25060_14104_14185(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<T>
list,string
header,bool
logElementCount,bool
logNullForDefault,System.Action<T>
arrayElementVisitor)
{
this_param.VisitArrayCommon<T>( list, header, logElementCount, logNullForDefault, arrayElementVisitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 14104, 14185);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,13926,14197);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,13926,14197);
}
		}

private void VisitArray(ImmutableArray<ISymbol> list, string header, bool logElementCount, bool logNullForDefault = false)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,14209,14459);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,14356,14448);

f_25060_14356_14447(this, list, header, logElementCount, logNullForDefault, VisitSymbolArrayElement);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,14209,14459);

int
f_25060_14356_14447(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
list,string
header,bool
logElementCount,bool
logNullForDefault,System.Action<Microsoft.CodeAnalysis.ISymbol>
arrayElementVisitor)
{
this_param.VisitArrayCommon<Microsoft.CodeAnalysis.ISymbol>( list, header, logElementCount, logNullForDefault, arrayElementVisitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 14356, 14447);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,14209,14459);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,14209,14459);
}
		}

private void VisitArray(ImmutableArray<string> list, string header, bool logElementCount, bool logNullForDefault = false)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,14471,14720);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,14617,14709);

f_25060_14617_14708(this, list, header, logElementCount, logNullForDefault, VisitStringArrayElement);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,14471,14720);

int
f_25060_14617_14708(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<string>
list,string
header,bool
logElementCount,bool
logNullForDefault,System.Action<string>
arrayElementVisitor)
{
this_param.VisitArrayCommon<string>( list, header, logElementCount, logNullForDefault, arrayElementVisitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 14617, 14708);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,14471,14720);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,14471,14720);
}
		}

private void VisitArray(ImmutableArray<RefKind> list, string header, bool logElementCount, bool logNullForDefault = false)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,14732,14983);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,14879,14972);

f_25060_14879_14971(this, list, header, logElementCount, logNullForDefault, VisitRefKindArrayElement);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,14732,14983);

int
f_25060_14879_14971(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
list,string
header,bool
logElementCount,bool
logNullForDefault,System.Action<Microsoft.CodeAnalysis.RefKind>
arrayElementVisitor)
{
this_param.VisitArrayCommon<Microsoft.CodeAnalysis.RefKind>( list, header, logElementCount, logNullForDefault, arrayElementVisitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 14879, 14971);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,14732,14983);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,14732,14983);
}
		}

private void VisitInstance(IOperation instance)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,14995,15123);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,15067,15112);

f_25060_15067_15111(this, instance, header: "Instance Receiver");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,14995,15123);

int
f_25060_15067_15111(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header: header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 15067, 15111);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,14995,15123);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,14995,15123);
}
		}

internal override void VisitNoneOperation(IOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,15135,15356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,15223,15249);

f_25060_15223_15248(this, "IOperation: ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,15263,15304);

f_25060_15263_15303(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,15320,15345);

f_25060_15320_15344(this, operation);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,15135,15356);

int
f_25060_15223_15248(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 15223, 15248);
return 0;
}


int
f_25060_15263_15303(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 15263, 15303);
return 0;
}


int
f_25060_15320_15344(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation)
{
this_param.VisitChildren( operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 15320, 15344);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,15135,15356);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,15135,15356);
}
		}

public override void VisitBlock(IBlockOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,15368,15988);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,15451,15486);

f_25060_15451_15485(this, nameof(IBlockOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,15502,15566);

var 
statementsStr = $"{operation.Operations.Length} statements"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,15580,15676);

var 
localStr = (DynAbs.Tracing.TraceSender.Conditional_F1(25060, 15595, 15620)||((f_25060_15595_15620_M(!operation.Locals.IsEmpty)&&DynAbs.Tracing.TraceSender.Conditional_F2(25060, 15623, 15660))||DynAbs.Tracing.TraceSender.Conditional_F3(25060, 15663, 15675)))?$", {operation.Locals.Length} locals" :string.Empty
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,15690,15733);

f_25060_15690_15732(this, $" ({statementsStr}{localStr})");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,15747,15788);

f_25060_15747_15787(this, operation);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,15804,15892) || true) && (operation.Operations.IsEmpty)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,15804,15892);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,15870,15877);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,15804,15892);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,15908,15936);

f_25060_15908_15935(this, f_25060_15918_15934(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,15950,15977);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitBlock(operation),25060,15950,15976);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,15368,15988);

int
f_25060_15451_15485(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 15451, 15485);
return 0;
}


bool
f_25060_15595_15620_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 15595, 15620);
return return_v;
}


int
f_25060_15690_15732(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 15690, 15732);
return 0;
}


int
f_25060_15747_15787(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IBlockOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 15747, 15787);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
f_25060_15918_15934(Microsoft.CodeAnalysis.Operations.IBlockOperation
this_param)
{
var return_v = this_param.Locals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 15918, 15934);
return return_v;
}


int
f_25060_15908_15935(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
locals)
{
this_param.LogLocals( (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ILocalSymbol>)locals);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 15908, 15935);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,15368,15988);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,15368,15988);
}
		}

public override void VisitVariableDeclarationGroup(IVariableDeclarationGroupOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,16000,16416);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,16121,16193);

var 
variablesCountStr = $"{operation.Declarations.Length} declarations"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,16207,16288);

f_25060_16207_16287(this, $"{nameof(IVariableDeclarationGroupOperation)} ({variablesCountStr})");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,16302,16343);

f_25060_16302_16342(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,16359,16405);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitVariableDeclarationGroup(operation),25060,16359,16404);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,16000,16416);

int
f_25060_16207_16287(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 16207, 16287);
return 0;
}


int
f_25060_16302_16342(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IVariableDeclarationGroupOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 16302, 16342);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,16000,16416);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,16000,16416);
}
		}

public override void VisitUsingDeclaration(IUsingDeclarationOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,16428,17319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,16533,16584);

f_25060_16533_16583(this, $"{nameof(IUsingDeclarationOperation)}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,16598,16656);

f_25060_16598_16655(this, $"(IsAsynchronous: {f_25060_16628_16652(operation)}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,16672,16757);

var 
disposeMethod = ((UsingDeclarationOperation)operation).DisposeInfo.DisposeMethod
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,16771,16891) || true) && (disposeMethod is object)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,16771,16891);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,16832,16876);

f_25060_16832_16875(this, disposeMethod, ", DisposeMethod");
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,16771,16891);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,16905,16920);

f_25060_16905_16919(this, ")");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,16934,16975);

f_25060_16934_16974(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,16991,17045);

f_25060_16991_17044(this, f_25060_16997_17023(operation), "DeclarationGroup");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,17059,17145);

var 
disposeArgs = ((UsingDeclarationOperation)operation).DisposeInfo.DisposeArguments
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,17159,17308) || true) && (f_25060_17163_17192_M(!disposeArgs.IsDefaultOrEmpty))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,17159,17308);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,17226,17293);

f_25060_17226_17292(this, disposeArgs, "DisposeArguments", logElementCount: true);
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,17159,17308);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,16428,17319);

int
f_25060_16533_16583(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 16533, 16583);
return 0;
}


bool
f_25060_16628_16652(Microsoft.CodeAnalysis.Operations.IUsingDeclarationOperation
this_param)
{
var return_v = this_param.IsAsynchronous;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 16628, 16652);
return return_v;
}


int
f_25060_16598_16655(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 16598, 16655);
return 0;
}


int
f_25060_16832_16875(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IMethodSymbol
symbol,string
header)
{
this_param.LogSymbol( (Microsoft.CodeAnalysis.ISymbol)symbol, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 16832, 16875);
return 0;
}


int
f_25060_16905_16919(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 16905, 16919);
return 0;
}


int
f_25060_16934_16974(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IUsingDeclarationOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 16934, 16974);
return 0;
}


Microsoft.CodeAnalysis.Operations.IVariableDeclarationGroupOperation
f_25060_16997_17023(Microsoft.CodeAnalysis.Operations.IUsingDeclarationOperation
this_param)
{
var return_v = this_param.DeclarationGroup;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 16997, 17023);
return return_v;
}


int
f_25060_16991_17044(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IVariableDeclarationGroupOperation
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 16991, 17044);
return 0;
}


bool
f_25060_17163_17192_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 17163, 17192);
return return_v;
}


int
f_25060_17226_17292(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
list,string
header,bool
logElementCount)
{
this_param.VisitArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>( list, header, logElementCount: logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 17226, 17292);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,16428,17319);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,16428,17319);
}
		}

public override void VisitVariableDeclarator(IVariableDeclaratorOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,17331,17886);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,17440,17495);

f_25060_17440_17494(this, $"{nameof(IVariableDeclaratorOperation)} (");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,17509,17547);

f_25060_17509_17546(this, f_25060_17519_17535(operation), "Symbol");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,17561,17576);

f_25060_17561_17575(this, ")");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,17590,17631);

f_25060_17590_17630(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,17647,17691);

f_25060_17647_17690(this, f_25060_17653_17674(operation), "Initializer");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,17705,17875) || true) && (f_25060_17709_17744_M(!operation.IgnoredArguments.IsEmpty))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,17705,17875);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,17778,17860);

f_25060_17778_17859(this, f_25060_17789_17815(operation), "IgnoredArguments", logElementCount: true);
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,17705,17875);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,17331,17886);

int
f_25060_17440_17494(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 17440, 17494);
return 0;
}


Microsoft.CodeAnalysis.ILocalSymbol
f_25060_17519_17535(Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation
this_param)
{
var return_v = this_param.Symbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 17519, 17535);
return return_v;
}


int
f_25060_17509_17546(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.ILocalSymbol
symbol,string
header)
{
this_param.LogSymbol( (Microsoft.CodeAnalysis.ISymbol)symbol, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 17509, 17546);
return 0;
}


int
f_25060_17561_17575(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 17561, 17575);
return 0;
}


int
f_25060_17590_17630(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 17590, 17630);
return 0;
}


Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation?
f_25060_17653_17674(Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation
this_param)
{
var return_v = this_param.Initializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 17653, 17674);
return return_v;
}


int
f_25060_17647_17690(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation?
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation?)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 17647, 17690);
return 0;
}


bool
f_25060_17709_17744_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 17709, 17744);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
f_25060_17789_17815(Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation
this_param)
{
var return_v = this_param.IgnoredArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 17789, 17815);
return return_v;
}


int
f_25060_17778_17859(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
list,string
header,bool
logElementCount)
{
this_param.VisitArray<Microsoft.CodeAnalysis.IOperation>( list, header, logElementCount: logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 17778, 17859);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,17331,17886);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,17331,17886);
}
		}

public override void VisitVariableDeclaration(IVariableDeclarationOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,17898,18523);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,18009,18058);

var 
variableCount = operation.Declarators.Length
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,18072,18156);

f_25060_18072_18155(this, $"{nameof(IVariableDeclarationOperation)} ({variableCount} declarators)");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,18170,18211);

f_25060_18170_18210(this, operation);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,18227,18384) || true) && (f_25060_18231_18267_M(!operation.IgnoredDimensions.IsEmpty))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,18227,18384);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,18301,18369);

f_25060_18301_18368(this, f_25060_18312_18339(operation), "Ignored Dimensions", true);
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,18227,18384);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,18398,18454);

f_25060_18398_18453(this, f_25060_18409_18430(operation), "Declarators", false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,18468,18512);

f_25060_18468_18511(this, f_25060_18474_18495(operation), "Initializer");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,17898,18523);

int
f_25060_18072_18155(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 18072, 18155);
return 0;
}


int
f_25060_18170_18210(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 18170, 18210);
return 0;
}


bool
f_25060_18231_18267_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 18231, 18267);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
f_25060_18312_18339(Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation
this_param)
{
var return_v = this_param.IgnoredDimensions;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 18312, 18339);
return return_v;
}


int
f_25060_18301_18368(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
list,string
header,bool
logElementCount)
{
this_param.VisitArray<Microsoft.CodeAnalysis.IOperation>( list, header, logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 18301, 18368);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation>
f_25060_18409_18430(Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation
this_param)
{
var return_v = this_param.Declarators;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 18409, 18430);
return return_v;
}


int
f_25060_18398_18453(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation>
list,string
header,bool
logElementCount)
{
this_param.VisitArray<Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation>( list, header, logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 18398, 18453);
return 0;
}


Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation?
f_25060_18474_18495(Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation
this_param)
{
var return_v = this_param.Initializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 18474, 18495);
return return_v;
}


int
f_25060_18468_18511(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation?
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation?)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 18468, 18511);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,17898,18523);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,17898,18523);
}
		}

public override void VisitSwitch(ISwitchOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,18535,19446);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,18620,18673);

var 
caseCountStr = $"{operation.Cases.Length} cases"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,18687,18760);

var 
exitLabelStr = $", Exit Label Id: {f_25060_18726_18757(this, f_25060_18737_18756(operation))}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,18774,18846);

f_25060_18774_18845(this, $"{nameof(ISwitchOperation)} ({caseCountStr}{exitLabelStr})");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,18860,18901);

f_25060_18860_18900(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,18917,18969);

f_25060_18917_18968(this, f_25060_18923_18938(operation), header: "Switch expression");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,18983,19011);

f_25060_18983_19010(this, f_25060_18993_19009(operation));
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,19027,19355);
foreach(ISwitchCaseOperation section in f_25060_19068_19083_I(f_25060_19068_19083(operation)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,19027,19355);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,19117,19340);
foreach(ICaseClauseOperation c in f_25060_19152_19167_I(f_25060_19152_19167(section)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,19117,19340);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,19209,19321) || true) && (f_25060_19213_19220(c)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,19209,19321);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,19278,19298);

f_25060_19278_19297(this, f_25060_19289_19296(c));
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,19209,19321);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,19117,19340);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25060,1,224);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25060,1,224);
}DynAbs.Tracing.TraceSender.TraceExitCondition(25060,19027,19355);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25060,1,329);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25060,1,329);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,19371,19435);

f_25060_19371_19434(this, f_25060_19382_19397(operation), "Sections", logElementCount: false);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,18535,19446);

Microsoft.CodeAnalysis.ILabelSymbol
f_25060_18737_18756(Microsoft.CodeAnalysis.Operations.ISwitchOperation
this_param)
{
var return_v = this_param.ExitLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 18737, 18756);
return return_v;
}


uint
f_25060_18726_18757(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.ILabelSymbol
symbol)
{
var return_v = this_param.GetLabelId( symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 18726, 18757);
return return_v;
}


int
f_25060_18774_18845(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 18774, 18845);
return 0;
}


int
f_25060_18860_18900(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.ISwitchOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 18860, 18900);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_18923_18938(Microsoft.CodeAnalysis.Operations.ISwitchOperation
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 18923, 18938);
return return_v;
}


int
f_25060_18917_18968(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header: header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 18917, 18968);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
f_25060_18993_19009(Microsoft.CodeAnalysis.Operations.ISwitchOperation
this_param)
{
var return_v = this_param.Locals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 18993, 19009);
return return_v;
}


int
f_25060_18983_19010(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
locals)
{
this_param.LogLocals( (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ILocalSymbol>)locals);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 18983, 19010);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.ISwitchCaseOperation>
f_25060_19068_19083(Microsoft.CodeAnalysis.Operations.ISwitchOperation
this_param)
{
var return_v = this_param.Cases;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 19068, 19083);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.ICaseClauseOperation>
f_25060_19152_19167(Microsoft.CodeAnalysis.Operations.ISwitchCaseOperation
this_param)
{
var return_v = this_param.Clauses;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 19152, 19167);
return return_v;
}


Microsoft.CodeAnalysis.ILabelSymbol?
f_25060_19213_19220(Microsoft.CodeAnalysis.Operations.ICaseClauseOperation
this_param)
{
var return_v = this_param.Label ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 19213, 19220);
return return_v;
}


Microsoft.CodeAnalysis.ILabelSymbol
f_25060_19289_19296(Microsoft.CodeAnalysis.Operations.ICaseClauseOperation
this_param)
{
var return_v = this_param.Label;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 19289, 19296);
return return_v;
}


uint
f_25060_19278_19297(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.ILabelSymbol
symbol)
{
var return_v = this_param.GetLabelId( symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 19278, 19297);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.ICaseClauseOperation>
f_25060_19152_19167_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.ICaseClauseOperation>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 19152, 19167);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.ISwitchCaseOperation>
f_25060_19068_19083_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.ISwitchCaseOperation>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 19068, 19083);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.ISwitchCaseOperation>
f_25060_19382_19397(Microsoft.CodeAnalysis.Operations.ISwitchOperation
this_param)
{
var return_v = this_param.Cases;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 19382, 19397);
return return_v;
}


int
f_25060_19371_19434(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.ISwitchCaseOperation>
list,string
header,bool
logElementCount)
{
this_param.VisitArray<Microsoft.CodeAnalysis.Operations.ISwitchCaseOperation>( list, header, logElementCount: logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 19371, 19434);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,18535,19446);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,18535,19446);
}
		}

public override void VisitSwitchCase(ISwitchCaseOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,19458,20169);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,19551,19619);

var 
caseClauseCountStr = $"{operation.Clauses.Length} case clauses"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,19633,19695);

var 
statementCountStr = $"{operation.Body.Length} statements"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,19709,19798);

f_25060_19709_19797(this, $"{nameof(ISwitchCaseOperation)} ({caseClauseCountStr}, {statementCountStr})");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,19812,19853);

f_25060_19812_19852(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,19867,19895);

f_25060_19867_19894(this, f_25060_19877_19893(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,19911,19920);

f_25060_19911_19919(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,19934,19999);

f_25060_19934_19998(this, f_25060_19945_19962(operation), "Clauses", logElementCount: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,20013,20072);

f_25060_20013_20071(this, f_25060_20024_20038(operation), "Body", logElementCount: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,20086,20097);

f_25060_20086_20096(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,20111,20158);

_ = f_25060_20115_20157(((SwitchCaseOperation)operation));
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,19458,20169);

int
f_25060_19709_19797(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 19709, 19797);
return 0;
}


int
f_25060_19812_19852(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.ISwitchCaseOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 19812, 19852);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
f_25060_19877_19893(Microsoft.CodeAnalysis.Operations.ISwitchCaseOperation
this_param)
{
var return_v = this_param.Locals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 19877, 19893);
return return_v;
}


int
f_25060_19867_19894(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
locals)
{
this_param.LogLocals( (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ILocalSymbol>)locals);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 19867, 19894);
return 0;
}


int
f_25060_19911_19919(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Indent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 19911, 19919);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.ICaseClauseOperation>
f_25060_19945_19962(Microsoft.CodeAnalysis.Operations.ISwitchCaseOperation
this_param)
{
var return_v = this_param.Clauses;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 19945, 19962);
return return_v;
}


int
f_25060_19934_19998(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.ICaseClauseOperation>
list,string
header,bool
logElementCount)
{
this_param.VisitArray<Microsoft.CodeAnalysis.Operations.ICaseClauseOperation>( list, header, logElementCount: logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 19934, 19998);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
f_25060_20024_20038(Microsoft.CodeAnalysis.Operations.ISwitchCaseOperation
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 20024, 20038);
return return_v;
}


int
f_25060_20013_20071(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
list,string
header,bool
logElementCount)
{
this_param.VisitArray<Microsoft.CodeAnalysis.IOperation>( list, header, logElementCount: logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 20013, 20071);
return 0;
}


int
f_25060_20086_20096(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Unindent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 20086, 20096);
return 0;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_20115_20157(Microsoft.CodeAnalysis.Operations.SwitchCaseOperation
this_param)
{
var return_v = this_param.Condition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 20115, 20157);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,19458,20169);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,19458,20169);
}
		}

public override void VisitWhileLoop(IWhileLoopOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,20181,20660);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,20272,20311);

f_25060_20272_20310(this, nameof(IWhileLoopOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,20325,20433);

f_25060_20325_20432(this, $" (ConditionIsTop: {f_25060_20356_20380(operation)}, ConditionIsUntil: {f_25060_20402_20428(operation)})");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,20447,20481);

f_25060_20447_20480(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,20497,20537);

f_25060_20497_20536(this, f_25060_20503_20522(operation), "Condition");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,20551,20581);

f_25060_20551_20580(this, f_25060_20557_20571(operation), "Body");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,20595,20649);

f_25060_20595_20648(this, f_25060_20601_20627(operation), "IgnoredCondition");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,20181,20660);

int
f_25060_20272_20310(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 20272, 20310);
return 0;
}


bool
f_25060_20356_20380(Microsoft.CodeAnalysis.Operations.IWhileLoopOperation
this_param)
{
var return_v = this_param.ConditionIsTop;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 20356, 20380);
return return_v;
}


bool
f_25060_20402_20428(Microsoft.CodeAnalysis.Operations.IWhileLoopOperation
this_param)
{
var return_v = this_param.ConditionIsUntil;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 20402, 20428);
return return_v;
}


int
f_25060_20325_20432(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 20325, 20432);
return 0;
}


int
f_25060_20447_20480(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IWhileLoopOperation
operation)
{
this_param.LogLoopStatementHeader( (Microsoft.CodeAnalysis.Operations.ILoopOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 20447, 20480);
return 0;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_20503_20522(Microsoft.CodeAnalysis.Operations.IWhileLoopOperation
this_param)
{
var return_v = this_param.Condition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 20503, 20522);
return return_v;
}


int
f_25060_20497_20536(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation?
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 20497, 20536);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_20557_20571(Microsoft.CodeAnalysis.Operations.IWhileLoopOperation
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 20557, 20571);
return return_v;
}


int
f_25060_20551_20580(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 20551, 20580);
return 0;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_20601_20627(Microsoft.CodeAnalysis.Operations.IWhileLoopOperation
this_param)
{
var return_v = this_param.IgnoredCondition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 20601, 20627);
return return_v;
}


int
f_25060_20595_20648(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation?
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 20595, 20648);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,20181,20660);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,20181,20660);
}
		}

public override void VisitForLoop(IForLoopOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,20672,21217);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,20759,20796);

f_25060_20759_20795(this, nameof(IForLoopOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,20810,20844);

f_25060_20810_20843(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,20860,20940);

f_25060_20860_20939(this, f_25060_20870_20895(operation), header: nameof(operation.ConditionLocals));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,20956,20996);

f_25060_20956_20995(this, f_25060_20962_20981(operation), "Condition");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,21010,21073);

f_25060_21010_21072(this, f_25060_21021_21037(operation), "Before", logElementCount: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,21087,21162);

f_25060_21087_21161(this, f_25060_21098_21120(operation), "AtLoopBottom", logElementCount: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,21176,21206);

f_25060_21176_21205(this, f_25060_21182_21196(operation), "Body");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,20672,21217);

int
f_25060_20759_20795(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 20759, 20795);
return 0;
}


int
f_25060_20810_20843(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IForLoopOperation
operation)
{
this_param.LogLoopStatementHeader( (Microsoft.CodeAnalysis.Operations.ILoopOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 20810, 20843);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
f_25060_20870_20895(Microsoft.CodeAnalysis.Operations.IForLoopOperation
this_param)
{
var return_v = this_param.ConditionLocals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 20870, 20895);
return return_v;
}


int
f_25060_20860_20939(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
locals,string
header)
{
this_param.LogLocals( (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ILocalSymbol>)locals, header: header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 20860, 20939);
return 0;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_20962_20981(Microsoft.CodeAnalysis.Operations.IForLoopOperation
this_param)
{
var return_v = this_param.Condition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 20962, 20981);
return return_v;
}


int
f_25060_20956_20995(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation?
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 20956, 20995);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
f_25060_21021_21037(Microsoft.CodeAnalysis.Operations.IForLoopOperation
this_param)
{
var return_v = this_param.Before;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 21021, 21037);
return return_v;
}


int
f_25060_21010_21072(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
list,string
header,bool
logElementCount)
{
this_param.VisitArray<Microsoft.CodeAnalysis.IOperation>( list, header, logElementCount: logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 21010, 21072);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
f_25060_21098_21120(Microsoft.CodeAnalysis.Operations.IForLoopOperation
this_param)
{
var return_v = this_param.AtLoopBottom;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 21098, 21120);
return return_v;
}


int
f_25060_21087_21161(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
list,string
header,bool
logElementCount)
{
this_param.VisitArray<Microsoft.CodeAnalysis.IOperation>( list, header, logElementCount: logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 21087, 21161);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_21182_21196(Microsoft.CodeAnalysis.Operations.IForLoopOperation
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 21182, 21196);
return return_v;
}


int
f_25060_21176_21205(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 21176, 21205);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,20672,21217);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,20672,21217);
}
		}

public override void VisitForToLoop(IForToLoopOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,21229,22233);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,21320,21359);

f_25060_21320_21358(this, nameof(IForToLoopOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,21373,21428);

f_25060_21373_21427(this, operation, f_25060_21407_21426(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,21444,21504);

f_25060_21444_21503(this, f_25060_21450_21479(operation), "LoopControlVariable");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,21518,21564);

f_25060_21518_21563(this, f_25060_21524_21546(operation), "InitialValue");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,21578,21620);

f_25060_21578_21619(this, f_25060_21584_21604(operation), "LimitValue");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,21634,21674);

f_25060_21634_21673(this, f_25060_21640_21659(operation), "StepValue");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,21688,21718);

f_25060_21688_21717(this, f_25060_21694_21708(operation), "Body");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,21732,21808);

f_25060_21732_21807(this, f_25060_21743_21766(operation), "NextVariables", logElementCount: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,21824,21940);

(ILocalSymbol loopObject, ForToLoopOperationUserDefinedInfo userDefinedInfo) = f_25060_21903_21939(((ForToLoopOperation)operation));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,21956,22222) || true) && (userDefinedInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,21956,22222);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,22017,22046);

_ = userDefinedInfo.Addition;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,22064,22096);

_ = userDefinedInfo.Subtraction;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,22114,22150);

_ = userDefinedInfo.LessThanOrEqual;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,22168,22207);

_ = userDefinedInfo.GreaterThanOrEqual;
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,21956,22222);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,21229,22233);

int
f_25060_21320_21358(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 21320, 21358);
return 0;
}


bool
f_25060_21407_21426(Microsoft.CodeAnalysis.Operations.IForToLoopOperation
this_param)
{
var return_v = this_param.IsChecked;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 21407, 21426);
return return_v;
}


int
f_25060_21373_21427(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IForToLoopOperation
operation,bool
isChecked)
{
this_param.LogLoopStatementHeader( (Microsoft.CodeAnalysis.Operations.ILoopOperation)operation, (bool?)isChecked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 21373, 21427);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_21450_21479(Microsoft.CodeAnalysis.Operations.IForToLoopOperation
this_param)
{
var return_v = this_param.LoopControlVariable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 21450, 21479);
return return_v;
}


int
f_25060_21444_21503(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 21444, 21503);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_21524_21546(Microsoft.CodeAnalysis.Operations.IForToLoopOperation
this_param)
{
var return_v = this_param.InitialValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 21524, 21546);
return return_v;
}


int
f_25060_21518_21563(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 21518, 21563);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_21584_21604(Microsoft.CodeAnalysis.Operations.IForToLoopOperation
this_param)
{
var return_v = this_param.LimitValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 21584, 21604);
return return_v;
}


int
f_25060_21578_21619(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 21578, 21619);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_21640_21659(Microsoft.CodeAnalysis.Operations.IForToLoopOperation
this_param)
{
var return_v = this_param.StepValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 21640, 21659);
return return_v;
}


int
f_25060_21634_21673(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 21634, 21673);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_21694_21708(Microsoft.CodeAnalysis.Operations.IForToLoopOperation
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 21694, 21708);
return return_v;
}


int
f_25060_21688_21717(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 21688, 21717);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
f_25060_21743_21766(Microsoft.CodeAnalysis.Operations.IForToLoopOperation
this_param)
{
var return_v = this_param.NextVariables;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 21743, 21766);
return return_v;
}


int
f_25060_21732_21807(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
list,string
header,bool
logElementCount)
{
this_param.VisitArray<Microsoft.CodeAnalysis.IOperation>( list, header, logElementCount: logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 21732, 21807);
return 0;
}


(Microsoft.CodeAnalysis.ILocalSymbol LoopObject, Microsoft.CodeAnalysis.Operations.ForToLoopOperationUserDefinedInfo UserDefinedInfo)
f_25060_21903_21939(Microsoft.CodeAnalysis.Operations.ForToLoopOperation
this_param)
{
var return_v = this_param.Info;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 21903, 21939);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,21229,22233);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,21229,22233);
}
		}

private void LogLocals(IEnumerable<ILocalSymbol> locals, string header = "Locals")
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,22245,22784);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,22352,22425) || true) && (!f_25060_22357_22369(locals))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,22352,22425);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,22403,22410);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,22352,22425);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,22441,22450);

f_25060_22441_22449(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,22466,22491);

f_25060_22466_22490(this, $"{header}: ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,22505,22514);

f_25060_22505_22513(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,22530,22549);

int 
localIndex = 1
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,22563,22721);
foreach(var local in f_25060_22585_22591_I(locals) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,22563,22721);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,22625,22675);

f_25060_22625_22674(this, local, header: $"Local_{localIndex++}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,22693,22706);

f_25060_22693_22705(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,22563,22721);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25060,1,159);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25060,1,159);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,22737,22748);

f_25060_22737_22747(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,22762,22773);

f_25060_22762_22772(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,22245,22784);

bool
f_25060_22357_22369(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ILocalSymbol>
source)
{
var return_v = source.Any<Microsoft.CodeAnalysis.ILocalSymbol>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 22357, 22369);
return return_v;
}


int
f_25060_22441_22449(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Indent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 22441, 22449);
return 0;
}


int
f_25060_22466_22490(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 22466, 22490);
return 0;
}


int
f_25060_22505_22513(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Indent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 22505, 22513);
return 0;
}


int
f_25060_22625_22674(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.ILocalSymbol
symbol,string
header)
{
this_param.LogSymbol( (Microsoft.CodeAnalysis.ISymbol)symbol, header: header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 22625, 22674);
return 0;
}


int
f_25060_22693_22705(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 22693, 22705);
return 0;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ILocalSymbol>
f_25060_22585_22591_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ILocalSymbol>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 22585, 22591);
return return_v;
}


int
f_25060_22737_22747(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Unindent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 22737, 22747);
return 0;
}


int
f_25060_22762_22772(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Unindent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 22762, 22772);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,22245,22784);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,22245,22784);
}
		}

private void LogLoopStatementHeader(ILoopOperation operation, bool? isChecked = null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,22796,23888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,22906,22955);

f_25060_22906_22954(OperationKind.Loop, f_25060_22939_22953(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,22969,23017);

var 
propertyStringBuilder = f_25060_22997_23016()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,23031,23066);

f_25060_23031_23065(            propertyStringBuilder, " (");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,23080,23153);

f_25060_23080_23152(            propertyStringBuilder, $"{nameof(LoopKind)}.{f_25060_23131_23149(operation)}");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,23167,23329) || true) && (operation is IForEachLoopOperation { IsAsynchronous: true })
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,23167,23329);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,23264,23314);

f_25060_23264_23313(                propertyStringBuilder, $", IsAsynchronous");
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,23167,23329);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,23343,23435);

f_25060_23343_23434(            propertyStringBuilder, $", Continue Label Id: {f_25060_23396_23431(this, f_25060_23407_23430(operation))}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,23449,23533);

f_25060_23449_23532(            propertyStringBuilder, $", Exit Label Id: {f_25060_23498_23529(this, f_25060_23509_23528(operation))}");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,23547,23672) || true) && (f_25060_23551_23580(isChecked))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,23547,23672);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,23614,23657);

f_25060_23614_23656(                propertyStringBuilder, $", Checked");
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,23547,23672);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,23686,23720);

f_25060_23686_23719(            propertyStringBuilder, ")");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,23734,23778);

f_25060_23734_23777(this, f_25060_23744_23776(propertyStringBuilder));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,23792,23833);

f_25060_23792_23832(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,23849,23877);

f_25060_23849_23876(this, f_25060_23859_23875(operation));
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,22796,23888);

Microsoft.CodeAnalysis.OperationKind
f_25060_22939_22953(Microsoft.CodeAnalysis.Operations.ILoopOperation
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 22939, 22953);
return return_v;
}


int
f_25060_22906_22954(Microsoft.CodeAnalysis.OperationKind
expected,Microsoft.CodeAnalysis.OperationKind
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 22906, 22954);
return 0;
}


System.Text.StringBuilder
f_25060_22997_23016()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 22997, 23016);
return return_v;
}


System.Text.StringBuilder
f_25060_23031_23065(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 23031, 23065);
return return_v;
}


Microsoft.CodeAnalysis.Operations.LoopKind
f_25060_23131_23149(Microsoft.CodeAnalysis.Operations.ILoopOperation
this_param)
{
var return_v = this_param.LoopKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 23131, 23149);
return return_v;
}


System.Text.StringBuilder
f_25060_23080_23152(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 23080, 23152);
return return_v;
}


System.Text.StringBuilder
f_25060_23264_23313(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 23264, 23313);
return return_v;
}


Microsoft.CodeAnalysis.ILabelSymbol
f_25060_23407_23430(Microsoft.CodeAnalysis.Operations.ILoopOperation
this_param)
{
var return_v = this_param.ContinueLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 23407, 23430);
return return_v;
}


uint
f_25060_23396_23431(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.ILabelSymbol
symbol)
{
var return_v = this_param.GetLabelId( symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 23396, 23431);
return return_v;
}


System.Text.StringBuilder
f_25060_23343_23434(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 23343, 23434);
return return_v;
}


Microsoft.CodeAnalysis.ILabelSymbol
f_25060_23509_23528(Microsoft.CodeAnalysis.Operations.ILoopOperation
this_param)
{
var return_v = this_param.ExitLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 23509, 23528);
return return_v;
}


uint
f_25060_23498_23529(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.ILabelSymbol
symbol)
{
var return_v = this_param.GetLabelId( symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 23498, 23529);
return return_v;
}


System.Text.StringBuilder
f_25060_23449_23532(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 23449, 23532);
return return_v;
}


bool
f_25060_23551_23580(bool?
this_param)
{
var return_v = this_param.GetValueOrDefault();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 23551, 23580);
return return_v;
}


System.Text.StringBuilder
f_25060_23614_23656(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 23614, 23656);
return return_v;
}


System.Text.StringBuilder
f_25060_23686_23719(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 23686, 23719);
return return_v;
}


string
f_25060_23744_23776(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 23744, 23776);
return return_v;
}


int
f_25060_23734_23777(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 23734, 23777);
return 0;
}


int
f_25060_23792_23832(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.ILoopOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 23792, 23832);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
f_25060_23859_23875(Microsoft.CodeAnalysis.Operations.ILoopOperation
this_param)
{
var return_v = this_param.Locals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 23859, 23875);
return return_v;
}


int
f_25060_23849_23876(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
locals)
{
this_param.LogLocals( (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ILocalSymbol>)locals);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 23849, 23876);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,22796,23888);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,22796,23888);
}
		}

public override void VisitForEachLoop(IForEachLoopOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,23900,24506);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,23995,24036);

f_25060_23995_24035(this, nameof(IForEachLoopOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,24050,24084);

f_25060_24050_24083(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,24100,24146);

f_25060_24100_24145(f_25060_24115_24144(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,24160,24220);

f_25060_24160_24219(this, f_25060_24166_24195(operation), "LoopControlVariable");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,24234,24276);

f_25060_24234_24275(this, f_25060_24240_24260(operation), "Collection");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,24290,24320);

f_25060_24290_24319(this, f_25060_24296_24310(operation), "Body");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,24334,24410);

f_25060_24334_24409(this, f_25060_24345_24368(operation), "NextVariables", logElementCount: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,24424,24495);

ForEachLoopOperationInfo 
info = f_25060_24456_24494(((ForEachLoopOperation)operation))
;
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,23900,24506);

int
f_25060_23995_24035(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 23995, 24035);
return 0;
}


int
f_25060_24050_24083(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IForEachLoopOperation
operation)
{
this_param.LogLoopStatementHeader( (Microsoft.CodeAnalysis.Operations.ILoopOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 24050, 24083);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_24115_24144(Microsoft.CodeAnalysis.Operations.IForEachLoopOperation
this_param)
{
var return_v = this_param.LoopControlVariable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 24115, 24144);
return return_v;
}


int
f_25060_24100_24145(Microsoft.CodeAnalysis.IOperation
@object)
{
Assert.NotNull( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 24100, 24145);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_24166_24195(Microsoft.CodeAnalysis.Operations.IForEachLoopOperation
this_param)
{
var return_v = this_param.LoopControlVariable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 24166, 24195);
return return_v;
}


int
f_25060_24160_24219(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 24160, 24219);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_24240_24260(Microsoft.CodeAnalysis.Operations.IForEachLoopOperation
this_param)
{
var return_v = this_param.Collection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 24240, 24260);
return return_v;
}


int
f_25060_24234_24275(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 24234, 24275);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_24296_24310(Microsoft.CodeAnalysis.Operations.IForEachLoopOperation
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 24296, 24310);
return return_v;
}


int
f_25060_24290_24319(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 24290, 24319);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
f_25060_24345_24368(Microsoft.CodeAnalysis.Operations.IForEachLoopOperation
this_param)
{
var return_v = this_param.NextVariables;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 24345, 24368);
return return_v;
}


int
f_25060_24334_24409(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
list,string
header,bool
logElementCount)
{
this_param.VisitArray<Microsoft.CodeAnalysis.IOperation>( list, header, logElementCount: logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 24334, 24409);
return 0;
}


Microsoft.CodeAnalysis.Operations.ForEachLoopOperationInfo?
f_25060_24456_24494(Microsoft.CodeAnalysis.Operations.ForEachLoopOperation
this_param)
{
var return_v = this_param.Info;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 24456, 24494);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,23900,24506);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,23900,24506);
}
		}

public override void VisitLabeled(ILabeledOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,24518,25042);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,24605,24642);

f_25060_24605_24641(this, nameof(ILabeledOperation));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,24658,24918) || true) && (f_25060_24662_24699_M(!f_25060_24663_24678(operation).IsImplicitlyDeclared))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,24658,24918);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,24733,24780);

f_25060_24733_24779(this, $" (Label: {f_25060_24755_24775(f_25060_24755_24770(operation))})");
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,24658,24918);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,24658,24918);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,24846,24903);

f_25060_24846_24902(this, $" (Label Id: {f_25060_24871_24898(this, f_25060_24882_24897(operation))})");
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,24658,24918);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,24934,24975);

f_25060_24934_24974(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,24991,25031);

f_25060_24991_25030(this, f_25060_24997_25016(operation), "Statement");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,24518,25042);

int
f_25060_24605_24641(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 24605, 24641);
return 0;
}


Microsoft.CodeAnalysis.ILabelSymbol
f_25060_24663_24678(Microsoft.CodeAnalysis.Operations.ILabeledOperation
this_param)
{
var return_v = this_param.Label;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 24663, 24678);
return return_v;
}


bool
f_25060_24662_24699_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 24662, 24699);
return return_v;
}


Microsoft.CodeAnalysis.ILabelSymbol
f_25060_24755_24770(Microsoft.CodeAnalysis.Operations.ILabeledOperation
this_param)
{
var return_v = this_param.Label;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 24755, 24770);
return return_v;
}


string
f_25060_24755_24775(Microsoft.CodeAnalysis.ILabelSymbol
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 24755, 24775);
return return_v;
}


int
f_25060_24733_24779(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 24733, 24779);
return 0;
}


Microsoft.CodeAnalysis.ILabelSymbol
f_25060_24882_24897(Microsoft.CodeAnalysis.Operations.ILabeledOperation
this_param)
{
var return_v = this_param.Label;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 24882, 24897);
return return_v;
}


uint
f_25060_24871_24898(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.ILabelSymbol
symbol)
{
var return_v = this_param.GetLabelId( symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 24871, 24898);
return return_v;
}


int
f_25060_24846_24902(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 24846, 24902);
return 0;
}


int
f_25060_24934_24974(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.ILabeledOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 24934, 24974);
return 0;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_24997_25016(Microsoft.CodeAnalysis.Operations.ILabeledOperation
this_param)
{
var return_v = this_param.Operation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 24997, 25016);
return return_v;
}


int
f_25060_24991_25030(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation?
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 24991, 25030);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,24518,25042);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,24518,25042);
}
		}

public override void VisitBranch(IBranchOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,25054,25768);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,25139,25175);

f_25060_25139_25174(this, nameof(IBranchOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,25189,25250);

var 
kindStr = $"{nameof(BranchKind)}.{f_25060_25227_25247(operation)}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,25420,25607);

var 
labelStr = (DynAbs.Tracing.TraceSender.Conditional_F1(25060, 25435, 25520)||((!(f_25060_25437_25474(f_25060_25437_25453(operation))||(DynAbs.Tracing.TraceSender.Expression_False(25060, 25437, 25519)||f_25060_25478_25519(_labelIdMap, f_25060_25502_25518(operation)))) &&DynAbs.Tracing.TraceSender.Conditional_F2(25060, 25523, 25558))||DynAbs.Tracing.TraceSender.Conditional_F3(25060, 25561, 25606)))?$", Label: {f_25060_25535_25556(f_25060_25535_25551(operation))}" :$", Label Id: {f_25060_25576_25604(this, f_25060_25587_25603(operation))}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,25621,25658);

f_25060_25621_25657(this, $" ({kindStr}{labelStr})");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,25672,25713);

f_25060_25672_25712(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,25729,25757);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitBranch(operation),25060,25729,25756);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,25054,25768);

int
f_25060_25139_25174(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 25139, 25174);
return 0;
}


Microsoft.CodeAnalysis.Operations.BranchKind
f_25060_25227_25247(Microsoft.CodeAnalysis.Operations.IBranchOperation
this_param)
{
var return_v = this_param.BranchKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 25227, 25247);
return return_v;
}


Microsoft.CodeAnalysis.ILabelSymbol
f_25060_25437_25453(Microsoft.CodeAnalysis.Operations.IBranchOperation
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 25437, 25453);
return return_v;
}


bool
f_25060_25437_25474(Microsoft.CodeAnalysis.ILabelSymbol
this_param)
{
var return_v = this_param.IsImplicitlyDeclared ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 25437, 25474);
return return_v;
}


Microsoft.CodeAnalysis.ILabelSymbol
f_25060_25502_25518(Microsoft.CodeAnalysis.Operations.IBranchOperation
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 25502, 25518);
return return_v;
}


bool
f_25060_25478_25519(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ILabelSymbol, uint>
this_param,Microsoft.CodeAnalysis.ILabelSymbol
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 25478, 25519);
return return_v;
}


Microsoft.CodeAnalysis.ILabelSymbol
f_25060_25535_25551(Microsoft.CodeAnalysis.Operations.IBranchOperation
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 25535, 25551);
return return_v;
}


string
f_25060_25535_25556(Microsoft.CodeAnalysis.ILabelSymbol
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 25535, 25556);
return return_v;
}


Microsoft.CodeAnalysis.ILabelSymbol
f_25060_25587_25603(Microsoft.CodeAnalysis.Operations.IBranchOperation
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 25587, 25603);
return return_v;
}


uint
f_25060_25576_25604(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.ILabelSymbol
symbol)
{
var return_v = this_param.GetLabelId( symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 25576, 25604);
return return_v;
}


int
f_25060_25621_25657(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 25621, 25657);
return 0;
}


int
f_25060_25672_25712(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IBranchOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 25672, 25712);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,25054,25768);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,25054,25768);
}
		}

public override void VisitEmpty(IEmptyOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,25780,25964);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,25863,25898);

f_25060_25863_25897(this, nameof(IEmptyOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,25912,25953);

f_25060_25912_25952(this, operation);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,25780,25964);

int
f_25060_25863_25897(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 25863, 25897);
return 0;
}


int
f_25060_25912_25952(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IEmptyOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 25912, 25952);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,25780,25964);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,25780,25964);
}
		}

public override void VisitReturn(IReturnOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,25976,26227);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,26061,26097);

f_25060_26061_26096(this, nameof(IReturnOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,26111,26152);

f_25060_26111_26151(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,26168,26216);

f_25060_26168_26215(this, f_25060_26174_26197(operation), "ReturnedValue");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,25976,26227);

int
f_25060_26061_26096(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 26061, 26096);
return 0;
}


int
f_25060_26111_26151(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IReturnOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 26111, 26151);
return 0;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_26174_26197(Microsoft.CodeAnalysis.Operations.IReturnOperation
this_param)
{
var return_v = this_param.ReturnedValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 26174, 26197);
return return_v;
}


int
f_25060_26168_26215(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation?
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 26168, 26215);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,25976,26227);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,25976,26227);
}
		}

public override void VisitLock(ILockOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,26239,26523);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,26320,26354);

f_25060_26320_26353(this, nameof(ILockOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,26368,26409);

f_25060_26368_26408(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,26425,26468);

f_25060_26425_26467(this, f_25060_26431_26452(operation), "Expression");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,26482,26512);

f_25060_26482_26511(this, f_25060_26488_26502(operation), "Body");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,26239,26523);

int
f_25060_26320_26353(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 26320, 26353);
return 0;
}


int
f_25060_26368_26408(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.ILockOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 26368, 26408);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_26431_26452(Microsoft.CodeAnalysis.Operations.ILockOperation
this_param)
{
var return_v = this_param.LockedValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 26431, 26452);
return return_v;
}


int
f_25060_26425_26467(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 26425, 26467);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_26488_26502(Microsoft.CodeAnalysis.Operations.ILockOperation
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 26488, 26502);
return return_v;
}


int
f_25060_26482_26511(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 26482, 26511);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,26239,26523);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,26239,26523);
}
		}

public override void VisitTry(ITryOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,26535,27053);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,26614,26647);

f_25060_26614_26646(this, nameof(ITryOperation));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,26661,26807) || true) && (f_25060_26665_26684(operation)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,26661,26807);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,26726,26792);

f_25060_26726_26791(this, $" (Exit Label Id: {f_25060_26756_26787(this, f_25060_26767_26786(operation))})");
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,26661,26807);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,26821,26862);

f_25060_26821_26861(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,26878,26908);

f_25060_26878_26907(this, f_25060_26884_26898(operation), "Body");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,26922,26992);

f_25060_26922_26991(this, f_25060_26933_26950(operation), "Catch clauses", logElementCount: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,27006,27042);

f_25060_27006_27041(this, f_25060_27012_27029(operation), "Finally");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,26535,27053);

int
f_25060_26614_26646(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 26614, 26646);
return 0;
}


Microsoft.CodeAnalysis.ILabelSymbol?
f_25060_26665_26684(Microsoft.CodeAnalysis.Operations.ITryOperation
this_param)
{
var return_v = this_param.ExitLabel ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 26665, 26684);
return return_v;
}


Microsoft.CodeAnalysis.ILabelSymbol
f_25060_26767_26786(Microsoft.CodeAnalysis.Operations.ITryOperation
this_param)
{
var return_v = this_param.ExitLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 26767, 26786);
return return_v;
}


uint
f_25060_26756_26787(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.ILabelSymbol
symbol)
{
var return_v = this_param.GetLabelId( symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 26756, 26787);
return return_v;
}


int
f_25060_26726_26791(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 26726, 26791);
return 0;
}


int
f_25060_26821_26861(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.ITryOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 26821, 26861);
return 0;
}


Microsoft.CodeAnalysis.Operations.IBlockOperation
f_25060_26884_26898(Microsoft.CodeAnalysis.Operations.ITryOperation
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 26884, 26898);
return return_v;
}


int
f_25060_26878_26907(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IBlockOperation
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 26878, 26907);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.ICatchClauseOperation>
f_25060_26933_26950(Microsoft.CodeAnalysis.Operations.ITryOperation
this_param)
{
var return_v = this_param.Catches;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 26933, 26950);
return return_v;
}


int
f_25060_26922_26991(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.ICatchClauseOperation>
list,string
header,bool
logElementCount)
{
this_param.VisitArray<Microsoft.CodeAnalysis.Operations.ICatchClauseOperation>( list, header, logElementCount: logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 26922, 26991);
return 0;
}


Microsoft.CodeAnalysis.Operations.IBlockOperation?
f_25060_27012_27029(Microsoft.CodeAnalysis.Operations.ITryOperation
this_param)
{
var return_v = this_param.Finally;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 27012, 27029);
return return_v;
}


int
f_25060_27006_27041(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IBlockOperation?
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation?)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 27006, 27041);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,26535,27053);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,26535,27053);
}
		}

public override void VisitCatchClause(ICatchClauseOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,27065,27701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,27160,27201);

f_25060_27160_27200(this, nameof(ICatchClauseOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,27215,27327);

var 
exceptionTypeStr = (DynAbs.Tracing.TraceSender.Conditional_F1(25060, 27238, 27269)||((f_25060_27238_27261(operation)!= null &&DynAbs.Tracing.TraceSender.Conditional_F2(25060, 27272, 27317))||DynAbs.Tracing.TraceSender.Conditional_F3(25060, 27320, 27326)))?f_25060_27272_27317(f_25060_27272_27295(operation)):"null"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,27341,27393);

f_25060_27341_27392(this, $" (Exception type: {exceptionTypeStr})");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,27407,27448);

f_25060_27407_27447(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,27464,27492);

f_25060_27464_27491(this, f_25060_27474_27490(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,27506,27592);

f_25060_27506_27591(this, f_25060_27512_27554(operation), "ExceptionDeclarationOrExpression");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,27606,27640);

f_25060_27606_27639(this, f_25060_27612_27628(operation), "Filter");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,27654,27690);

f_25060_27654_27689(this, f_25060_27660_27677(operation), "Handler");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,27065,27701);

int
f_25060_27160_27200(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 27160, 27200);
return 0;
}


Microsoft.CodeAnalysis.ITypeSymbol
f_25060_27238_27261(Microsoft.CodeAnalysis.Operations.ICatchClauseOperation
this_param)
{
var return_v = this_param.ExceptionType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 27238, 27261);
return return_v;
}


Microsoft.CodeAnalysis.ITypeSymbol
f_25060_27272_27295(Microsoft.CodeAnalysis.Operations.ICatchClauseOperation
this_param)
{
var return_v = this_param.ExceptionType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 27272, 27295);
return return_v;
}


string
f_25060_27272_27317(Microsoft.CodeAnalysis.ITypeSymbol
symbol)
{
var return_v = symbol.ToTestDisplayString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 27272, 27317);
return return_v;
}


int
f_25060_27341_27392(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 27341, 27392);
return 0;
}


int
f_25060_27407_27447(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.ICatchClauseOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 27407, 27447);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
f_25060_27474_27490(Microsoft.CodeAnalysis.Operations.ICatchClauseOperation
this_param)
{
var return_v = this_param.Locals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 27474, 27490);
return return_v;
}


int
f_25060_27464_27491(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
locals)
{
this_param.LogLocals( (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ILocalSymbol>)locals);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 27464, 27491);
return 0;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_27512_27554(Microsoft.CodeAnalysis.Operations.ICatchClauseOperation
this_param)
{
var return_v = this_param.ExceptionDeclarationOrExpression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 27512, 27554);
return return_v;
}


int
f_25060_27506_27591(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation?
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 27506, 27591);
return 0;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_27612_27628(Microsoft.CodeAnalysis.Operations.ICatchClauseOperation
this_param)
{
var return_v = this_param.Filter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 27612, 27628);
return return_v;
}


int
f_25060_27606_27639(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation?
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 27606, 27639);
return 0;
}


Microsoft.CodeAnalysis.Operations.IBlockOperation
f_25060_27660_27677(Microsoft.CodeAnalysis.Operations.ICatchClauseOperation
this_param)
{
var return_v = this_param.Handler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 27660, 27677);
return return_v;
}


int
f_25060_27654_27689(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IBlockOperation
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 27654, 27689);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,27065,27701);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,27065,27701);
}
		}

public override void VisitUsing(IUsingOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,27713,28854);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,27796,27831);

f_25060_27796_27830(this, nameof(IUsingOperation));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,27845,27954) || true) && (f_25060_27849_27873(operation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,27845,27954);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,27907,27939);

f_25060_27907_27938(this, $" (IsAsynchronous)");
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,27845,27954);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,27968,28042);

var 
disposeMethod = ((UsingOperation)operation).DisposeInfo.DisposeMethod
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,28056,28209) || true) && (disposeMethod is object)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,28056,28209);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,28117,28161);

f_25060_28117_28160(this, disposeMethod, " (DisposeMethod");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,28179,28194);

f_25060_28179_28193(this, ")");
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,28056,28209);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,28223,28264);

f_25060_28223_28263(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,28280,28308);

f_25060_28280_28307(this, f_25060_28290_28306(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,28322,28362);

f_25060_28322_28361(this, f_25060_28328_28347(operation), "Resources");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,28376,28406);

f_25060_28376_28405(this, f_25060_28382_28396(operation), "Body");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,28422,28499);

f_25060_28422_28498(OperationKind.VariableDeclaration, f_25060_28473_28497(f_25060_28473_28492(operation)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,28513,28589);

f_25060_28513_28588(OperationKind.VariableDeclarator, f_25060_28563_28587(f_25060_28563_28582(operation)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,28605,28680);

var 
disposeArgs = ((UsingOperation)operation).DisposeInfo.DisposeArguments
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,28694,28843) || true) && (f_25060_28698_28727_M(!disposeArgs.IsDefaultOrEmpty))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,28694,28843);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,28761,28828);

f_25060_28761_28827(this, disposeArgs, "DisposeArguments", logElementCount: true);
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,28694,28843);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,27713,28854);

int
f_25060_27796_27830(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 27796, 27830);
return 0;
}


bool
f_25060_27849_27873(Microsoft.CodeAnalysis.Operations.IUsingOperation
this_param)
{
var return_v = this_param.IsAsynchronous;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 27849, 27873);
return return_v;
}


int
f_25060_27907_27938(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 27907, 27938);
return 0;
}


int
f_25060_28117_28160(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IMethodSymbol
symbol,string
header)
{
this_param.LogSymbol( (Microsoft.CodeAnalysis.ISymbol)symbol, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 28117, 28160);
return 0;
}


int
f_25060_28179_28193(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 28179, 28193);
return 0;
}


int
f_25060_28223_28263(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IUsingOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 28223, 28263);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
f_25060_28290_28306(Microsoft.CodeAnalysis.Operations.IUsingOperation
this_param)
{
var return_v = this_param.Locals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 28290, 28306);
return return_v;
}


int
f_25060_28280_28307(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
locals)
{
this_param.LogLocals( (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ILocalSymbol>)locals);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 28280, 28307);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_28328_28347(Microsoft.CodeAnalysis.Operations.IUsingOperation
this_param)
{
var return_v = this_param.Resources;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 28328, 28347);
return return_v;
}


int
f_25060_28322_28361(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 28322, 28361);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_28382_28396(Microsoft.CodeAnalysis.Operations.IUsingOperation
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 28382, 28396);
return return_v;
}


int
f_25060_28376_28405(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 28376, 28405);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_28473_28492(Microsoft.CodeAnalysis.Operations.IUsingOperation
this_param)
{
var return_v = this_param.Resources;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 28473, 28492);
return return_v;
}


Microsoft.CodeAnalysis.OperationKind
f_25060_28473_28497(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 28473, 28497);
return return_v;
}


int
f_25060_28422_28498(Microsoft.CodeAnalysis.OperationKind
expected,Microsoft.CodeAnalysis.OperationKind
actual)
{
Assert.NotEqual( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 28422, 28498);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_28563_28582(Microsoft.CodeAnalysis.Operations.IUsingOperation
this_param)
{
var return_v = this_param.Resources;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 28563, 28582);
return return_v;
}


Microsoft.CodeAnalysis.OperationKind
f_25060_28563_28587(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 28563, 28587);
return return_v;
}


int
f_25060_28513_28588(Microsoft.CodeAnalysis.OperationKind
expected,Microsoft.CodeAnalysis.OperationKind
actual)
{
Assert.NotEqual( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 28513, 28588);
return 0;
}


bool
f_25060_28698_28727_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 28698, 28727);
return return_v;
}


int
f_25060_28761_28827(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
list,string
header,bool
logElementCount)
{
this_param.VisitArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>( list, header, logElementCount: logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 28761, 28827);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,27713,28854);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,27713,28854);
}
		}

internal override void VisitFixed(IFixedOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,28924,29254);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,29009,29044);

f_25060_29009_29043(this, nameof(IFixedOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,29058,29099);

f_25060_29058_29098(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,29115,29143);

f_25060_29115_29142(this, f_25060_29125_29141(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,29157,29199);

f_25060_29157_29198(this, f_25060_29163_29182(operation), "Declaration");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,29213,29243);

f_25060_29213_29242(this, f_25060_29219_29233(operation), "Body");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,28924,29254);

int
f_25060_29009_29043(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 29009, 29043);
return 0;
}


int
f_25060_29058_29098(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IFixedOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 29058, 29098);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
f_25060_29125_29141(Microsoft.CodeAnalysis.Operations.IFixedOperation
this_param)
{
var return_v = this_param.Locals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 29125, 29141);
return return_v;
}


int
f_25060_29115_29142(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
locals)
{
this_param.LogLocals( (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ILocalSymbol>)locals);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 29115, 29142);
return 0;
}


Microsoft.CodeAnalysis.Operations.IVariableDeclarationGroupOperation
f_25060_29163_29182(Microsoft.CodeAnalysis.Operations.IFixedOperation
this_param)
{
var return_v = this_param.Variables;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 29163, 29182);
return return_v;
}


int
f_25060_29157_29198(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IVariableDeclarationGroupOperation
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 29157, 29198);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_29219_29233(Microsoft.CodeAnalysis.Operations.IFixedOperation
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 29219, 29233);
return return_v;
}


int
f_25060_29213_29242(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 29213, 29242);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,28924,29254);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,28924,29254);
}
		}

internal override void VisitAggregateQuery(IAggregateQueryOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,29266,29585);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,29369,29413);

f_25060_29369_29412(this, nameof(IAggregateQueryOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,29427,29468);

f_25060_29427_29467(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,29484,29516);

f_25060_29484_29515(this, f_25060_29490_29505(operation), "Group");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,29530,29574);

f_25060_29530_29573(this, f_25060_29536_29557(operation), "Aggregation");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,29266,29585);

int
f_25060_29369_29412(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 29369, 29412);
return 0;
}


int
f_25060_29427_29467(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IAggregateQueryOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 29427, 29467);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_29490_29505(Microsoft.CodeAnalysis.Operations.IAggregateQueryOperation
this_param)
{
var return_v = this_param.Group;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 29490, 29505);
return return_v;
}


int
f_25060_29484_29515(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 29484, 29515);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_29536_29557(Microsoft.CodeAnalysis.Operations.IAggregateQueryOperation
this_param)
{
var return_v = this_param.Aggregation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 29536, 29557);
return return_v;
}


int
f_25060_29530_29573(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 29530, 29573);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,29266,29585);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,29266,29585);
}
		}

public override void VisitExpressionStatement(IExpressionStatementOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,29597,29880);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,29708,29757);

f_25060_29708_29756(this, nameof(IExpressionStatementOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,29771,29812);

f_25060_29771_29811(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,29828,29869);

f_25060_29828_29868(this, f_25060_29834_29853(operation), "Expression");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,29597,29880);

int
f_25060_29708_29756(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 29708, 29756);
return 0;
}


int
f_25060_29771_29811(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IExpressionStatementOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 29771, 29811);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_29834_29853(Microsoft.CodeAnalysis.Operations.IExpressionStatementOperation
this_param)
{
var return_v = this_param.Operation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 29834, 29853);
return return_v;
}


int
f_25060_29828_29868(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 29828, 29868);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,29597,29880);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,29597,29880);
}
		}

internal override void VisitWithStatement(IWithStatementOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,29892,30194);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,29993,30036);

f_25060_29993_30035(this, nameof(IWithStatementOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,30050,30091);

f_25060_30050_30090(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,30107,30139);

f_25060_30107_30138(this, f_25060_30113_30128(operation), "Value");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,30153,30183);

f_25060_30153_30182(this, f_25060_30159_30173(operation), "Body");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,29892,30194);

int
f_25060_29993_30035(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 29993, 30035);
return 0;
}


int
f_25060_30050_30090(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IWithStatementOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 30050, 30090);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_30113_30128(Microsoft.CodeAnalysis.Operations.IWithStatementOperation
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 30113, 30128);
return return_v;
}


int
f_25060_30107_30138(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 30107, 30138);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_30159_30173(Microsoft.CodeAnalysis.Operations.IWithStatementOperation
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 30159, 30173);
return return_v;
}


int
f_25060_30153_30182(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 30153, 30182);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,29892,30194);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,29892,30194);
}
		}

public override void VisitStop(IStopOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,30206,30387);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,30287,30321);

f_25060_30287_30320(this, nameof(IStopOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,30335,30376);

f_25060_30335_30375(this, operation);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,30206,30387);

int
f_25060_30287_30320(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 30287, 30320);
return 0;
}


int
f_25060_30335_30375(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IStopOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 30335, 30375);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,30206,30387);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,30206,30387);
}
		}

public override void VisitEnd(IEndOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,30399,30577);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,30478,30511);

f_25060_30478_30510(this, nameof(IEndOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,30525,30566);

f_25060_30525_30565(this, operation);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,30399,30577);

int
f_25060_30478_30510(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 30478, 30510);
return 0;
}


int
f_25060_30525_30565(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IEndOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 30525, 30565);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,30399,30577);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,30399,30577);
}
		}

public override void VisitInvocation(IInvocationOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,30589,31224);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,30682,30722);

f_25060_30682_30721(this, nameof(IInvocationOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,30738,30805);

var 
isVirtualStr = (DynAbs.Tracing.TraceSender.Conditional_F1(25060, 30757, 30776)||((f_25060_30757_30776(operation)&&DynAbs.Tracing.TraceSender.Conditional_F2(25060, 30779, 30789))||DynAbs.Tracing.TraceSender.Conditional_F3(25060, 30792, 30804)))?"virtual " :string.Empty
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,30819,30905);

var 
spacing = (DynAbs.Tracing.TraceSender.Conditional_F1(25060, 30833, 30883)||((f_25060_30833_30853_M(!operation.IsVirtual)&&(DynAbs.Tracing.TraceSender.Expression_True(25060, 30833, 30883)&&f_25060_30857_30875(operation)!= null )&&DynAbs.Tracing.TraceSender.Conditional_F2(25060, 30886, 30889))||DynAbs.Tracing.TraceSender.Conditional_F3(25060, 30892, 30904)))?" " :string.Empty
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,30919,30959);

f_25060_30919_30958(this, $" ({isVirtualStr}{spacing}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,30973,31029);

f_25060_30973_31028(this, f_25060_30983_31005(operation), header: string.Empty);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,31043,31058);

f_25060_31043_31057(this, ")");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,31072,31113);

f_25060_31072_31112(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,31129,31163);

f_25060_31129_31162(this, f_25060_31143_31161(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,31177,31213);

f_25060_31177_31212(this, f_25060_31192_31211(operation));
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,30589,31224);

int
f_25060_30682_30721(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 30682, 30721);
return 0;
}


bool
f_25060_30757_30776(Microsoft.CodeAnalysis.Operations.IInvocationOperation
this_param)
{
var return_v = this_param.IsVirtual ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 30757, 30776);
return return_v;
}


bool
f_25060_30833_30853_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 30833, 30853);
return return_v;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_30857_30875(Microsoft.CodeAnalysis.Operations.IInvocationOperation
this_param)
{
var return_v = this_param.Instance ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 30857, 30875);
return return_v;
}


int
f_25060_30919_30958(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 30919, 30958);
return 0;
}


Microsoft.CodeAnalysis.IMethodSymbol
f_25060_30983_31005(Microsoft.CodeAnalysis.Operations.IInvocationOperation
this_param)
{
var return_v = this_param.TargetMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 30983, 31005);
return return_v;
}


int
f_25060_30973_31028(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IMethodSymbol
symbol,string
header)
{
this_param.LogSymbol( (Microsoft.CodeAnalysis.ISymbol)symbol, header: header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 30973, 31028);
return 0;
}


int
f_25060_31043_31057(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 31043, 31057);
return 0;
}


int
f_25060_31072_31112(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IInvocationOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 31072, 31112);
return 0;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_31143_31161(Microsoft.CodeAnalysis.Operations.IInvocationOperation
this_param)
{
var return_v = this_param.Instance;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 31143, 31161);
return return_v;
}


int
f_25060_31129_31162(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation?
instance)
{
this_param.VisitInstance( instance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 31129, 31162);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
f_25060_31192_31211(Microsoft.CodeAnalysis.Operations.IInvocationOperation
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 31192, 31211);
return return_v;
}


int
f_25060_31177_31212(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
arguments)
{
this_param.VisitArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 31177, 31212);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,30589,31224);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,30589,31224);
}
		}

private void VisitArguments(ImmutableArray<IArgumentOperation> arguments)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,31236,31403);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,31334,31392);

f_25060_31334_31391(this, arguments, "Arguments", logElementCount: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,31236,31403);

int
f_25060_31334_31391(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
list,string
header,bool
logElementCount)
{
this_param.VisitArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>( list, header, logElementCount: logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 31334, 31391);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,31236,31403);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,31236,31403);
}
		}

private void VisitDynamicArguments(HasDynamicArgumentsExpression operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,31415,31975);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,31515,31583);

f_25060_31515_31582(this, f_25060_31526_31545(operation), "Arguments", logElementCount: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,31597,31673);

f_25060_31597_31672(this, f_25060_31608_31631(operation), "ArgumentNames", logElementCount: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,31687,31794);

f_25060_31687_31793(this, f_25060_31698_31724(operation), "ArgumentRefKinds", logElementCount: true, logNullForDefault: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,31810,31877);

f_25060_31810_31876(operation, f_25060_31852_31875(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,31891,31964);

f_25060_31891_31963(operation, f_25060_31936_31962(operation));
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,31415,31975);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
f_25060_31526_31545(Microsoft.CodeAnalysis.Operations.HasDynamicArgumentsExpression
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 31526, 31545);
return return_v;
}


int
f_25060_31515_31582(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
list,string
header,bool
logElementCount)
{
this_param.VisitArray<Microsoft.CodeAnalysis.IOperation>( list, header, logElementCount: logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 31515, 31582);
return 0;
}


System.Collections.Immutable.ImmutableArray<string>
f_25060_31608_31631(Microsoft.CodeAnalysis.Operations.HasDynamicArgumentsExpression
this_param)
{
var return_v = this_param.ArgumentNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 31608, 31631);
return return_v;
}


int
f_25060_31597_31672(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<string>
list,string
header,bool
logElementCount)
{
this_param.VisitArray( list, header, logElementCount: logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 31597, 31672);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
f_25060_31698_31724(Microsoft.CodeAnalysis.Operations.HasDynamicArgumentsExpression
this_param)
{
var return_v = this_param.ArgumentRefKinds;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 31698, 31724);
return return_v;
}


int
f_25060_31687_31793(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
list,string
header,bool
logElementCount,bool
logNullForDefault)
{
this_param.VisitArray( list, header, logElementCount: logElementCount, logNullForDefault: logNullForDefault);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 31687, 31793);
return 0;
}


System.Collections.Immutable.ImmutableArray<string>
f_25060_31852_31875(Microsoft.CodeAnalysis.Operations.HasDynamicArgumentsExpression
this_param)
{
var return_v = this_param.ArgumentNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 31852, 31875);
return return_v;
}


int
f_25060_31810_31876(Microsoft.CodeAnalysis.Operations.HasDynamicArgumentsExpression
operation,System.Collections.Immutable.ImmutableArray<string>
argumentNames)
{
VerifyGetArgumentNamePublicApi( operation, argumentNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 31810, 31876);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
f_25060_31936_31962(Microsoft.CodeAnalysis.Operations.HasDynamicArgumentsExpression
this_param)
{
var return_v = this_param.ArgumentRefKinds;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 31936, 31962);
return return_v;
}


int
f_25060_31891_31963(Microsoft.CodeAnalysis.Operations.HasDynamicArgumentsExpression
operation,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
argumentRefKinds)
{
VerifyGetArgumentRefKindPublicApi( operation, argumentRefKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 31891, 31963);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,31415,31975);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,31415,31975);
}
		}

private static void VerifyGetArgumentNamePublicApi(HasDynamicArgumentsExpression operation, ImmutableArray<string> argumentNames)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25060,31987,32703);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,32141,32181);

var 
length = operation.Arguments.Length
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,32195,32692) || true) && (argumentNames.IsDefaultOrEmpty)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,32195,32692);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,32272,32277);
                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,32263,32397) || true) && (i < length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,32291,32294)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(25060,32263,32397))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,32263,32397);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,32336,32378);

f_25060_32336_32377(f_25060_32348_32376(operation, i));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25060,1,135);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25060,1,135);
}DynAbs.Tracing.TraceSender.TraceExitCondition(25060,32195,32692);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,32195,32692);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,32463,32506);

f_25060_32463_32505(length, argumentNames.Length);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,32533,32538);
                for (var 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,32524,32677) || true) && (i < length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,32552,32555)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(25060,32524,32677))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,32524,32677);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,32597,32658);

f_25060_32597_32657(argumentNames[i], f_25060_32628_32656(operation, i));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25060,1,154);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25060,1,154);
}DynAbs.Tracing.TraceSender.TraceExitCondition(25060,32195,32692);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25060,31987,32703);

string?
f_25060_32348_32376(Microsoft.CodeAnalysis.Operations.HasDynamicArgumentsExpression
dynamicOperation,int
index)
{
var return_v = dynamicOperation.GetArgumentName( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 32348, 32376);
return return_v;
}


int
f_25060_32336_32377(string?
@object)
{
Assert.Null( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 32336, 32377);
return 0;
}


int
f_25060_32463_32505(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 32463, 32505);
return 0;
}


string?
f_25060_32628_32656(Microsoft.CodeAnalysis.Operations.HasDynamicArgumentsExpression
dynamicOperation,int
index)
{
var return_v = dynamicOperation.GetArgumentName( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 32628, 32656);
return return_v;
}


int
f_25060_32597_32657(string
expected,string?
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 32597, 32657);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,31987,32703);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,31987,32703);
}
		}

private static void VerifyGetArgumentRefKindPublicApi(HasDynamicArgumentsExpression operation, ImmutableArray<RefKind> argumentRefKinds)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25060,32715,33694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,32876,32916);

var 
length = operation.Arguments.Length
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,32930,33683) || true) && (argumentRefKinds.IsDefault)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,32930,33683);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,33003,33008);
                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,32994,33131) || true) && (i < length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,33022,33025)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(25060,32994,33131))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,32994,33131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,33067,33112);

f_25060_33067_33111(f_25060_33079_33110(operation, i));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25060,1,138);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25060,1,138);
}DynAbs.Tracing.TraceSender.TraceExitCondition(25060,32930,33683);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,32930,33683);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,33165,33683) || true) && (argumentRefKinds.IsEmpty)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,33165,33683);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,33236,33241);
                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,33227,33379) || true) && (i < length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,33255,33258)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(25060,33227,33379))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,33227,33379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,33300,33360);

f_25060_33300_33359(RefKind.None, f_25060_33327_33358(operation, i));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25060,1,153);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25060,1,153);
}DynAbs.Tracing.TraceSender.TraceExitCondition(25060,33165,33683);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,33165,33683);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,33445,33491);

f_25060_33445_33490(length, argumentRefKinds.Length);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,33518,33523);
                for (var 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,33509,33668) || true) && (i < length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,33537,33540)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(25060,33509,33668))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,33509,33668);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,33582,33649);

f_25060_33582_33648(argumentRefKinds[i], f_25060_33616_33647(operation, i));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25060,1,160);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25060,1,160);
}DynAbs.Tracing.TraceSender.TraceExitCondition(25060,33165,33683);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,32930,33683);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25060,32715,33694);

Microsoft.CodeAnalysis.RefKind?
f_25060_33079_33110(Microsoft.CodeAnalysis.Operations.HasDynamicArgumentsExpression
dynamicOperation,int
index)
{
var return_v = dynamicOperation.GetArgumentRefKind( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 33079, 33110);
return return_v;
}


int
f_25060_33067_33111(Microsoft.CodeAnalysis.RefKind?
@object)
{
Assert.Null( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 33067, 33111);
return 0;
}


Microsoft.CodeAnalysis.RefKind?
f_25060_33327_33358(Microsoft.CodeAnalysis.Operations.HasDynamicArgumentsExpression
dynamicOperation,int
index)
{
var return_v = dynamicOperation.GetArgumentRefKind( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 33327, 33358);
return return_v;
}


int
f_25060_33300_33359(Microsoft.CodeAnalysis.RefKind
expected,Microsoft.CodeAnalysis.RefKind?
actual)
{
Assert.Equal( (Microsoft.CodeAnalysis.RefKind?)expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 33300, 33359);
return 0;
}


int
f_25060_33445_33490(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 33445, 33490);
return 0;
}


Microsoft.CodeAnalysis.RefKind?
f_25060_33616_33647(Microsoft.CodeAnalysis.Operations.HasDynamicArgumentsExpression
dynamicOperation,int
index)
{
var return_v = dynamicOperation.GetArgumentRefKind( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 33616, 33647);
return return_v;
}


int
f_25060_33582_33648(Microsoft.CodeAnalysis.RefKind
expected,Microsoft.CodeAnalysis.RefKind?
actual)
{
Assert.Equal( (Microsoft.CodeAnalysis.RefKind?)expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 33582, 33648);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,32715,33694);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,32715,33694);
}
		}

public override void VisitArgument(IArgumentOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,33706,34394);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,33795,33840);

f_25060_33795_33839(this, $"{nameof(IArgumentOperation)} (");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,33854,33918);

f_25060_33854_33917(this, $"{nameof(ArgumentKind)}.{f_25060_33890_33912(operation)}, ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,33932,34018);

f_25060_33932_34017(this, f_25060_33942_33961(operation), header: "Matching Parameter", logDisplayString: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,34032,34047);

f_25060_34032_34046(this, ")");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,34061,34102);

f_25060_34061_34101(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,34118,34141);

f_25060_34118_34140(this, f_25060_34124_34139(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,34157,34166);

f_25060_34157_34165(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,34180,34234);

f_25060_34180_34233(this, f_25060_34194_34216(operation), "InConversion");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,34248,34261);

f_25060_34248_34260(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,34275,34331);

f_25060_34275_34330(this, f_25060_34289_34312(operation), "OutConversion");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,34345,34358);

f_25060_34345_34357(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,34372,34383);

f_25060_34372_34382(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,33706,34394);

int
f_25060_33795_33839(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 33795, 33839);
return 0;
}


Microsoft.CodeAnalysis.Operations.ArgumentKind
f_25060_33890_33912(Microsoft.CodeAnalysis.Operations.IArgumentOperation
this_param)
{
var return_v = this_param.ArgumentKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 33890, 33912);
return return_v;
}


int
f_25060_33854_33917(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 33854, 33917);
return 0;
}


Microsoft.CodeAnalysis.IParameterSymbol?
f_25060_33942_33961(Microsoft.CodeAnalysis.Operations.IArgumentOperation
this_param)
{
var return_v = this_param.Parameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 33942, 33961);
return return_v;
}


int
f_25060_33932_34017(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IParameterSymbol?
symbol,string
header,bool
logDisplayString)
{
this_param.LogSymbol( (Microsoft.CodeAnalysis.ISymbol?)symbol, header: header, logDisplayString: logDisplayString);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 33932, 34017);
return 0;
}


int
f_25060_34032_34046(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 34032, 34046);
return 0;
}


int
f_25060_34061_34101(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IArgumentOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 34061, 34101);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_34124_34139(Microsoft.CodeAnalysis.Operations.IArgumentOperation
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 34124, 34139);
return return_v;
}


int
f_25060_34118_34140(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation)
{
this_param.Visit( operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 34118, 34140);
return 0;
}


int
f_25060_34157_34165(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Indent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 34157, 34165);
return 0;
}


Microsoft.CodeAnalysis.Operations.CommonConversion
f_25060_34194_34216(Microsoft.CodeAnalysis.Operations.IArgumentOperation
this_param)
{
var return_v = this_param.InConversion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 34194, 34216);
return return_v;
}


int
f_25060_34180_34233(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.CommonConversion
conversion,string
header)
{
this_param.LogConversion( conversion, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 34180, 34233);
return 0;
}


int
f_25060_34248_34260(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 34248, 34260);
return 0;
}


Microsoft.CodeAnalysis.Operations.CommonConversion
f_25060_34289_34312(Microsoft.CodeAnalysis.Operations.IArgumentOperation
this_param)
{
var return_v = this_param.OutConversion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 34289, 34312);
return return_v;
}


int
f_25060_34275_34330(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.CommonConversion
conversion,string
header)
{
this_param.LogConversion( conversion, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 34275, 34330);
return 0;
}


int
f_25060_34345_34357(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 34345, 34357);
return 0;
}


int
f_25060_34372_34382(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Unindent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 34372, 34382);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,33706,34394);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,33706,34394);
}
		}

public override void VisitOmittedArgument(IOmittedArgumentOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,34406,34620);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,34509,34554);

f_25060_34509_34553(this, nameof(IOmittedArgumentOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,34568,34609);

f_25060_34568_34608(this, operation);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,34406,34620);

int
f_25060_34509_34553(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 34509, 34553);
return 0;
}


int
f_25060_34568_34608(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IOmittedArgumentOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 34568, 34608);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,34406,34620);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,34406,34620);
}
		}

public override void VisitArrayElementReference(IArrayElementReferenceOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,34632,35009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,34747,34798);

f_25060_34747_34797(this, nameof(IArrayElementReferenceOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,34812,34853);

f_25060_34812_34852(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,34869,34920);

f_25060_34869_34919(this, f_25060_34875_34899(operation), "Array reference");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,34934,34998);

f_25060_34934_34997(this, f_25060_34945_34962(operation), "Indices", logElementCount: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,34632,35009);

int
f_25060_34747_34797(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 34747, 34797);
return 0;
}


int
f_25060_34812_34852(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IArrayElementReferenceOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 34812, 34852);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_34875_34899(Microsoft.CodeAnalysis.Operations.IArrayElementReferenceOperation
this_param)
{
var return_v = this_param.ArrayReference;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 34875, 34899);
return return_v;
}


int
f_25060_34869_34919(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 34869, 34919);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
f_25060_34945_34962(Microsoft.CodeAnalysis.Operations.IArrayElementReferenceOperation
this_param)
{
var return_v = this_param.Indices;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 34945, 34962);
return return_v;
}


int
f_25060_34934_34997(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
list,string
header,bool
logElementCount)
{
this_param.VisitArray<Microsoft.CodeAnalysis.IOperation>( list, header, logElementCount: logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 34934, 34997);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,34632,35009);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,34632,35009);
}
		}

internal override void VisitPointerIndirectionReference(IPointerIndirectionReferenceOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,35021,35325);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,35150,35207);

f_25060_35150_35206(this, nameof(IPointerIndirectionReferenceOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,35221,35262);

f_25060_35221_35261(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,35278,35314);

f_25060_35278_35313(this, f_25060_35284_35301(operation), "Pointer");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,35021,35325);

int
f_25060_35150_35206(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 35150, 35206);
return 0;
}


int
f_25060_35221_35261(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IPointerIndirectionReferenceOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 35221, 35261);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_35284_35301(Microsoft.CodeAnalysis.Operations.IPointerIndirectionReferenceOperation
this_param)
{
var return_v = this_param.Pointer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 35284, 35301);
return return_v;
}


int
f_25060_35278_35313(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 35278, 35313);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,35021,35325);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,35021,35325);
}
		}

public override void VisitLocalReference(ILocalReferenceOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,35337,35749);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,35438,35482);

f_25060_35438_35481(this, nameof(ILocalReferenceOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,35496,35535);

f_25060_35496_35534(this, $": {f_25060_35511_35531(f_25060_35511_35526(operation))}");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,35549,35683) || true) && (f_25060_35553_35576(operation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,35549,35683);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,35610,35668);

f_25060_35610_35667(this, $" (IsDeclaration: {f_25060_35640_35663(operation)})");
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,35549,35683);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,35697,35738);

f_25060_35697_35737(this, operation);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,35337,35749);

int
f_25060_35438_35481(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 35438, 35481);
return 0;
}


Microsoft.CodeAnalysis.ILocalSymbol
f_25060_35511_35526(Microsoft.CodeAnalysis.Operations.ILocalReferenceOperation
this_param)
{
var return_v = this_param.Local;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 35511, 35526);
return return_v;
}


string
f_25060_35511_35531(Microsoft.CodeAnalysis.ILocalSymbol
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 35511, 35531);
return return_v;
}


int
f_25060_35496_35534(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 35496, 35534);
return 0;
}


bool
f_25060_35553_35576(Microsoft.CodeAnalysis.Operations.ILocalReferenceOperation
this_param)
{
var return_v = this_param.IsDeclaration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 35553, 35576);
return return_v;
}


bool
f_25060_35640_35663(Microsoft.CodeAnalysis.Operations.ILocalReferenceOperation
this_param)
{
var return_v = this_param.IsDeclaration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 35640, 35663);
return return_v;
}


int
f_25060_35610_35667(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 35610, 35667);
return 0;
}


int
f_25060_35697_35737(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.ILocalReferenceOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 35697, 35737);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,35337,35749);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,35337,35749);
}
		}

public override void VisitFlowCapture(IFlowCaptureOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,35761,36137);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,35856,35897);

f_25060_35856_35896(this, nameof(IFlowCaptureOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,35911,35948);

f_25060_35911_35947(this, $": {operation.Id.Value}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,35962,36003);

f_25060_35962_36002(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,36019,36051);

f_25060_36019_36050(this, f_25060_36025_36040(operation), "Value");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,36067,36126);

f_25060_36067_36125(
            TestOperationVisitor.Singleton, operation);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,35761,36137);

int
f_25060_35856_35896(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 35856, 35896);
return 0;
}


int
f_25060_35911_35947(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 35911, 35947);
return 0;
}


int
f_25060_35962_36002(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 35962, 36002);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_36025_36040(Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 36025, 36040);
return return_v;
}


int
f_25060_36019_36050(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 36019, 36050);
return 0;
}


int
f_25060_36067_36125(Microsoft.CodeAnalysis.Test.Utilities.TestOperationVisitor
this_param,Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureOperation
operation)
{
this_param.VisitFlowCapture( operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 36067, 36125);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,35761,36137);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,35761,36137);
}
		}

public override void VisitFlowCaptureReference(IFlowCaptureReferenceOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,36149,36429);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,36262,36312);

f_25060_36262_36311(this, nameof(IFlowCaptureReferenceOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,36326,36363);

f_25060_36326_36362(this, $": {operation.Id.Value}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,36377,36418);

f_25060_36377_36417(this, operation);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,36149,36429);

int
f_25060_36262_36311(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 36262, 36311);
return 0;
}


int
f_25060_36326_36362(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 36326, 36362);
return 0;
}


int
f_25060_36377_36417(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.FlowAnalysis.IFlowCaptureReferenceOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 36377, 36417);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,36149,36429);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,36149,36429);
}
		}

public override void VisitIsNull(IIsNullOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,36441,36680);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,36526,36562);

f_25060_36526_36561(this, nameof(IIsNullOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,36576,36617);

f_25060_36576_36616(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,36633,36669);

f_25060_36633_36668(this, f_25060_36639_36656(operation), "Operand");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,36441,36680);

int
f_25060_36526_36561(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 36526, 36561);
return 0;
}


int
f_25060_36576_36616(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.FlowAnalysis.IIsNullOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 36576, 36616);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_36639_36656(Microsoft.CodeAnalysis.FlowAnalysis.IIsNullOperation
this_param)
{
var return_v = this_param.Operand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 36639, 36656);
return return_v;
}


int
f_25060_36633_36668(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 36633, 36668);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,36441,36680);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,36441,36680);
}
		}

public override void VisitCaughtException(ICaughtExceptionOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,36692,36906);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,36795,36840);

f_25060_36795_36839(this, nameof(ICaughtExceptionOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,36854,36895);

f_25060_36854_36894(this, operation);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,36692,36906);

int
f_25060_36795_36839(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 36795, 36839);
return 0;
}


int
f_25060_36854_36894(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.FlowAnalysis.ICaughtExceptionOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 36854, 36894);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,36692,36906);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,36692,36906);
}
		}

public override void VisitParameterReference(IParameterReferenceOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,36918,37198);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,37027,37075);

f_25060_37027_37074(this, nameof(IParameterReferenceOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,37089,37132);

f_25060_37089_37131(this, $": {f_25060_37104_37128(f_25060_37104_37123(operation))}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,37146,37187);

f_25060_37146_37186(this, operation);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,36918,37198);

int
f_25060_37027_37074(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 37027, 37074);
return 0;
}


Microsoft.CodeAnalysis.IParameterSymbol
f_25060_37104_37123(Microsoft.CodeAnalysis.Operations.IParameterReferenceOperation
this_param)
{
var return_v = this_param.Parameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 37104, 37123);
return return_v;
}


string
f_25060_37104_37128(Microsoft.CodeAnalysis.IParameterSymbol
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 37104, 37128);
return return_v;
}


int
f_25060_37089_37131(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 37089, 37131);
return 0;
}


int
f_25060_37146_37186(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IParameterReferenceOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 37146, 37186);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,36918,37198);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,36918,37198);
}
		}

public override void VisitInstanceReference(IInstanceReferenceOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,37210,38069);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,37317,37364);

f_25060_37317_37363(this, nameof(IInstanceReferenceOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,37378,37436);

f_25060_37378_37435(this, $" (ReferenceKind: {f_25060_37408_37431(operation)})");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,37450,37491);

f_25060_37450_37490(this, operation);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,37507,38058) || true) && (f_25060_37511_37531(operation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,37507,38058);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,37565,38043) || true) && (f_25060_37569_37585(operation)is IMemberReferenceOperation memberReference &&(DynAbs.Tracing.TraceSender.Expression_True(25060, 37569, 37671)&&f_25060_37634_37658(memberReference)== operation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,37565,38043);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,37713,37802);

f_25060_37713_37801(f_25060_37726_37757(f_25060_37726_37748(memberReference))&&(DynAbs.Tracing.TraceSender.Expression_True(25060, 37726, 37800)&&!f_25060_37762_37800(operation, this._compilation)));
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,37565,38043);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,37565,38043);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,37844,38043) || true) && (f_25060_37848_37864(operation)is IInvocationOperation invocation &&(DynAbs.Tracing.TraceSender.Expression_True(25060, 37848, 37935)&&f_25060_37903_37922(invocation)== operation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,37844,38043);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,37977,38024);

f_25060_37977_38023(f_25060_37990_38022(f_25060_37990_38013(invocation)));
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,37844,38043);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,37565,38043);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,37507,38058);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,37210,38069);

int
f_25060_37317_37363(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 37317, 37363);
return 0;
}


Microsoft.CodeAnalysis.Operations.InstanceReferenceKind
f_25060_37408_37431(Microsoft.CodeAnalysis.Operations.IInstanceReferenceOperation
this_param)
{
var return_v = this_param.ReferenceKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 37408, 37431);
return return_v;
}


int
f_25060_37378_37435(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 37378, 37435);
return 0;
}


int
f_25060_37450_37490(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IInstanceReferenceOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 37450, 37490);
return 0;
}


bool
f_25060_37511_37531(Microsoft.CodeAnalysis.Operations.IInstanceReferenceOperation
this_param)
{
var return_v = this_param.IsImplicit;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 37511, 37531);
return return_v;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_37569_37585(Microsoft.CodeAnalysis.Operations.IInstanceReferenceOperation
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 37569, 37585);
return return_v;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_37634_37658(Microsoft.CodeAnalysis.Operations.IMemberReferenceOperation
this_param)
{
var return_v = this_param.Instance ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 37634, 37658);
return return_v;
}


Microsoft.CodeAnalysis.ISymbol
f_25060_37726_37748(Microsoft.CodeAnalysis.Operations.IMemberReferenceOperation
this_param)
{
var return_v = this_param.Member;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 37726, 37748);
return return_v;
}


bool
f_25060_37726_37757(Microsoft.CodeAnalysis.ISymbol
this_param)
{
var return_v = this_param.IsStatic ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 37726, 37757);
return return_v;
}


bool
f_25060_37762_37800(Microsoft.CodeAnalysis.Operations.IInstanceReferenceOperation
operation,Microsoft.CodeAnalysis.Compilation
compilation)
{
var return_v = operation.HasErrors( compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 37762, 37800);
return return_v;
}


int
f_25060_37713_37801(bool
condition)
{
Assert.False( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 37713, 37801);
return 0;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_37848_37864(Microsoft.CodeAnalysis.Operations.IInstanceReferenceOperation
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 37848, 37864);
return return_v;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_37903_37922(Microsoft.CodeAnalysis.Operations.IInvocationOperation
this_param)
{
var return_v = this_param.Instance ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 37903, 37922);
return return_v;
}


Microsoft.CodeAnalysis.IMethodSymbol
f_25060_37990_38013(Microsoft.CodeAnalysis.Operations.IInvocationOperation
this_param)
{
var return_v = this_param.TargetMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 37990, 38013);
return return_v;
}


bool
f_25060_37990_38022(Microsoft.CodeAnalysis.IMethodSymbol
this_param)
{
var return_v = this_param.IsStatic;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 37990, 38022);
return return_v;
}


int
f_25060_37977_38023(bool
condition)
{
Assert.False( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 37977, 38023);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,37210,38069);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,37210,38069);
}
		}

private void VisitMemberReferenceExpressionCommon(IMemberReferenceOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,38081,38409);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,38192,38293) || true) && (f_25060_38196_38221(f_25060_38196_38212(operation)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,38192,38293);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,38255,38278);

f_25060_38255_38277(this, " (Static)");
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,38192,38293);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,38309,38350);

f_25060_38309_38349(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,38364,38398);

f_25060_38364_38397(this, f_25060_38378_38396(operation));
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,38081,38409);

Microsoft.CodeAnalysis.ISymbol
f_25060_38196_38212(Microsoft.CodeAnalysis.Operations.IMemberReferenceOperation
this_param)
{
var return_v = this_param.Member;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 38196, 38212);
return return_v;
}


bool
f_25060_38196_38221(Microsoft.CodeAnalysis.ISymbol
this_param)
{
var return_v = this_param.IsStatic;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 38196, 38221);
return return_v;
}


int
f_25060_38255_38277(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 38255, 38277);
return 0;
}


int
f_25060_38309_38349(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IMemberReferenceOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 38309, 38349);
return 0;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_38378_38396(Microsoft.CodeAnalysis.Operations.IMemberReferenceOperation
this_param)
{
var return_v = this_param.Instance;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 38378, 38396);
return return_v;
}


int
f_25060_38364_38397(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation?
instance)
{
this_param.VisitInstance( instance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 38364, 38397);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,38081,38409);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,38081,38409);
}
		}

public override void VisitFieldReference(IFieldReferenceOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,38421,38859);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,38522,38566);

f_25060_38522_38565(this, nameof(IFieldReferenceOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,38580,38636);

f_25060_38580_38635(this, $": {f_25060_38595_38632(f_25060_38595_38610(operation))}");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,38650,38784) || true) && (f_25060_38654_38677(operation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,38650,38784);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,38711,38769);

f_25060_38711_38768(this, $" (IsDeclaration: {f_25060_38741_38764(operation)})");
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,38650,38784);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,38800,38848);

f_25060_38800_38847(this, operation);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,38421,38859);

int
f_25060_38522_38565(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 38522, 38565);
return 0;
}


Microsoft.CodeAnalysis.IFieldSymbol
f_25060_38595_38610(Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation
this_param)
{
var return_v = this_param.Field;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 38595, 38610);
return return_v;
}


string
f_25060_38595_38632(Microsoft.CodeAnalysis.IFieldSymbol
symbol)
{
var return_v = symbol.ToTestDisplayString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 38595, 38632);
return return_v;
}


int
f_25060_38580_38635(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 38580, 38635);
return 0;
}


bool
f_25060_38654_38677(Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation
this_param)
{
var return_v = this_param.IsDeclaration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 38654, 38677);
return return_v;
}


bool
f_25060_38741_38764(Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation
this_param)
{
var return_v = this_param.IsDeclaration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 38741, 38764);
return return_v;
}


int
f_25060_38711_38768(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 38711, 38768);
return 0;
}


int
f_25060_38800_38847(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation
operation)
{
this_param.VisitMemberReferenceExpressionCommon( (Microsoft.CodeAnalysis.Operations.IMemberReferenceOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 38800, 38847);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,38421,38859);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,38421,38859);
}
		}

public override void VisitMethodReference(IMethodReferenceOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,38871,39323);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,38974,39019);

f_25060_38974_39018(this, nameof(IMethodReferenceOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,39033,39090);

f_25060_39033_39089(this, $": {f_25060_39048_39086(f_25060_39048_39064(operation))}");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,39106,39204) || true) && (f_25060_39110_39129(operation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,39106,39204);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,39163,39189);

f_25060_39163_39188(this, " (IsVirtual)");
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,39106,39204);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,39220,39248);

f_25060_39220_39247(f_25060_39232_39246(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,39264,39312);

f_25060_39264_39311(this, operation);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,38871,39323);

int
f_25060_38974_39018(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 38974, 39018);
return 0;
}


Microsoft.CodeAnalysis.IMethodSymbol
f_25060_39048_39064(Microsoft.CodeAnalysis.Operations.IMethodReferenceOperation
this_param)
{
var return_v = this_param.Method;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 39048, 39064);
return return_v;
}


string
f_25060_39048_39086(Microsoft.CodeAnalysis.IMethodSymbol
symbol)
{
var return_v = symbol.ToTestDisplayString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 39048, 39086);
return return_v;
}


int
f_25060_39033_39089(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 39033, 39089);
return 0;
}


bool
f_25060_39110_39129(Microsoft.CodeAnalysis.Operations.IMethodReferenceOperation
this_param)
{
var return_v = this_param.IsVirtual;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 39110, 39129);
return return_v;
}


int
f_25060_39163_39188(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 39163, 39188);
return 0;
}


Microsoft.CodeAnalysis.ITypeSymbol?
f_25060_39232_39246(Microsoft.CodeAnalysis.Operations.IMethodReferenceOperation
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 39232, 39246);
return return_v;
}


int
f_25060_39220_39247(Microsoft.CodeAnalysis.ITypeSymbol?
@object)
{
Assert.Null( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 39220, 39247);
return 0;
}


int
f_25060_39264_39311(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IMethodReferenceOperation
operation)
{
this_param.VisitMemberReferenceExpressionCommon( (Microsoft.CodeAnalysis.Operations.IMemberReferenceOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 39264, 39311);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,38871,39323);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,38871,39323);
}
		}

public override void VisitPropertyReference(IPropertyReferenceOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,39335,39772);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,39442,39489);

f_25060_39442_39488(this, nameof(IPropertyReferenceOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,39503,39562);

f_25060_39503_39561(this, $": {f_25060_39518_39558(f_25060_39518_39536(operation))}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,39578,39626);

f_25060_39578_39625(this, operation);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,39642,39761) || true) && (operation.Arguments.Length > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,39642,39761);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,39710,39746);

f_25060_39710_39745(this, f_25060_39725_39744(operation));
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,39642,39761);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,39335,39772);

int
f_25060_39442_39488(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 39442, 39488);
return 0;
}


Microsoft.CodeAnalysis.IPropertySymbol
f_25060_39518_39536(Microsoft.CodeAnalysis.Operations.IPropertyReferenceOperation
this_param)
{
var return_v = this_param.Property;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 39518, 39536);
return return_v;
}


string
f_25060_39518_39558(Microsoft.CodeAnalysis.IPropertySymbol
symbol)
{
var return_v = symbol.ToTestDisplayString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 39518, 39558);
return return_v;
}


int
f_25060_39503_39561(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 39503, 39561);
return 0;
}


int
f_25060_39578_39625(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IPropertyReferenceOperation
operation)
{
this_param.VisitMemberReferenceExpressionCommon( (Microsoft.CodeAnalysis.Operations.IMemberReferenceOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 39578, 39625);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
f_25060_39725_39744(Microsoft.CodeAnalysis.Operations.IPropertyReferenceOperation
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 39725, 39744);
return return_v;
}


int
f_25060_39710_39745(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
arguments)
{
this_param.VisitArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 39710, 39745);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,39335,39772);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,39335,39772);
}
		}

public override void VisitEventReference(IEventReferenceOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,39784,40074);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,39885,39929);

f_25060_39885_39928(this, nameof(IEventReferenceOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,39943,39999);

f_25060_39943_39998(this, $": {f_25060_39958_39995(f_25060_39958_39973(operation))}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,40015,40063);

f_25060_40015_40062(this, operation);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,39784,40074);

int
f_25060_39885_39928(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 39885, 39928);
return 0;
}


Microsoft.CodeAnalysis.IEventSymbol
f_25060_39958_39973(Microsoft.CodeAnalysis.Operations.IEventReferenceOperation
this_param)
{
var return_v = this_param.Event;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 39958, 39973);
return return_v;
}


string
f_25060_39958_39995(Microsoft.CodeAnalysis.IEventSymbol
symbol)
{
var return_v = symbol.ToTestDisplayString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 39958, 39995);
return return_v;
}


int
f_25060_39943_39998(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 39943, 39998);
return 0;
}


int
f_25060_40015_40062(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IEventReferenceOperation
operation)
{
this_param.VisitMemberReferenceExpressionCommon( (Microsoft.CodeAnalysis.Operations.IMemberReferenceOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 40015, 40062);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,39784,40074);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,39784,40074);
}
		}

public override void VisitEventAssignment(IEventAssignmentOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,40086,40582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,40189,40247);

var 
kindStr = (DynAbs.Tracing.TraceSender.Conditional_F1(25060, 40203, 40217)||((f_25060_40203_40217(operation)&&DynAbs.Tracing.TraceSender.Conditional_F2(25060, 40220, 40230))||DynAbs.Tracing.TraceSender.Conditional_F3(25060, 40233, 40246)))?"EventAdd" :"EventRemove"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,40261,40323);

f_25060_40261_40322(this, $"{nameof(IEventAssignmentOperation)} ({kindStr})");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,40337,40378);

f_25060_40337_40377(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,40394,40435);

f_25060_40394_40434(f_25060_40409_40433(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,40449,40508);

f_25060_40449_40507(this, f_25060_40455_40479(operation), header: "Event Reference");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,40522,40571);

f_25060_40522_40570(this, f_25060_40528_40550(operation), header: "Handler");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,40086,40582);

bool
f_25060_40203_40217(Microsoft.CodeAnalysis.Operations.IEventAssignmentOperation
this_param)
{
var return_v = this_param.Adds ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 40203, 40217);
return return_v;
}


int
f_25060_40261_40322(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 40261, 40322);
return 0;
}


int
f_25060_40337_40377(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IEventAssignmentOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 40337, 40377);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_40409_40433(Microsoft.CodeAnalysis.Operations.IEventAssignmentOperation
this_param)
{
var return_v = this_param.EventReference;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 40409, 40433);
return return_v;
}


int
f_25060_40394_40434(Microsoft.CodeAnalysis.IOperation
@object)
{
Assert.NotNull( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 40394, 40434);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_40455_40479(Microsoft.CodeAnalysis.Operations.IEventAssignmentOperation
this_param)
{
var return_v = this_param.EventReference;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 40455, 40479);
return return_v;
}


int
f_25060_40449_40507(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header: header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 40449, 40507);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_40528_40550(Microsoft.CodeAnalysis.Operations.IEventAssignmentOperation
this_param)
{
var return_v = this_param.HandlerValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 40528, 40550);
return return_v;
}


int
f_25060_40522_40570(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header: header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 40522, 40570);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,40086,40582);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,40086,40582);
}
		}

public override void VisitConditionalAccess(IConditionalAccessOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,40594,41021);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,40701,40748);

f_25060_40701_40747(this, nameof(IConditionalAccessOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,40762,40803);

f_25060_40762_40802(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,40819,40883);

f_25060_40819_40882(this, f_25060_40825_40844(operation), header: nameof(operation.Operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,40897,40965);

f_25060_40897_40964(this, f_25060_40903_40924(operation), header: nameof(operation.WhenNotNull));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,40979,41010);

f_25060_40979_41009(f_25060_40994_41008(operation));
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,40594,41021);

int
f_25060_40701_40747(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 40701, 40747);
return 0;
}


int
f_25060_40762_40802(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IConditionalAccessOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 40762, 40802);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_40825_40844(Microsoft.CodeAnalysis.Operations.IConditionalAccessOperation
this_param)
{
var return_v = this_param.Operation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 40825, 40844);
return return_v;
}


int
f_25060_40819_40882(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header: header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 40819, 40882);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_40903_40924(Microsoft.CodeAnalysis.Operations.IConditionalAccessOperation
this_param)
{
var return_v = this_param.WhenNotNull;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 40903, 40924);
return return_v;
}


int
f_25060_40897_40964(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header: header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 40897, 40964);
return 0;
}


Microsoft.CodeAnalysis.ITypeSymbol?
f_25060_40994_41008(Microsoft.CodeAnalysis.Operations.IConditionalAccessOperation
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 40994, 41008);
return return_v;
}


int
f_25060_40979_41009(Microsoft.CodeAnalysis.ITypeSymbol?
@object)
{
Assert.NotNull( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 40979, 41009);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,40594,41021);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,40594,41021);
}
		}

public override void VisitConditionalAccessInstance(IConditionalAccessInstanceOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,41033,41277);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,41156,41211);

f_25060_41156_41210(this, nameof(IConditionalAccessInstanceOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,41225,41266);

f_25060_41225_41265(this, operation);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,41033,41277);

int
f_25060_41156_41210(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 41156, 41210);
return 0;
}


int
f_25060_41225_41265(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IConditionalAccessInstanceOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 41225, 41265);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,41033,41277);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,41033,41277);
}
		}

internal override void VisitPlaceholder(IPlaceholderOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,41289,41581);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,41386,41427);

f_25060_41386_41426(this, nameof(IPlaceholderOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,41441,41482);

f_25060_41441_41481(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,41496,41570);

f_25060_41496_41569(PlaceholderKind.AggregationGroup, f_25060_41543_41568(operation));
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,41289,41581);

int
f_25060_41386_41426(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 41386, 41426);
return 0;
}


int
f_25060_41441_41481(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IPlaceholderOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 41441, 41481);
return 0;
}


Microsoft.CodeAnalysis.Operations.PlaceholderKind
f_25060_41543_41568(Microsoft.CodeAnalysis.Operations.IPlaceholderOperation
this_param)
{
var return_v = this_param.PlaceholderKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 41543, 41568);
return return_v;
}


int
f_25060_41496_41569(Microsoft.CodeAnalysis.Operations.PlaceholderKind
expected,Microsoft.CodeAnalysis.Operations.PlaceholderKind
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 41496, 41569);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,41289,41581);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,41289,41581);
}
		}

public override void VisitUnaryOperator(IUnaryOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,41593,42263);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,41684,41719);

f_25060_41684_41718(this, nameof(IUnaryOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,41735,41805);

var 
kindStr = $"{nameof(UnaryOperatorKind)}.{f_25060_41780_41802(operation)}"
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,41819,41914) || true) && (f_25060_41823_41841(operation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,41819,41914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,41875,41899);

kindStr += ", IsLifted";
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,41819,41914);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,41930,42025) || true) && (f_25060_41934_41953(operation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,41930,42025);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,41987,42010);

kindStr += ", Checked";
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,41930,42025);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,42041,42068);

f_25060_42041_42067(this, $" ({kindStr})");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,42082,42145);

f_25060_42082_42144(this, f_25060_42119_42143(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,42159,42200);

f_25060_42159_42199(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,42216,42252);

f_25060_42216_42251(this, f_25060_42222_42239(operation), "Operand");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,41593,42263);

int
f_25060_41684_41718(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 41684, 41718);
return 0;
}


Microsoft.CodeAnalysis.Operations.UnaryOperatorKind
f_25060_41780_41802(Microsoft.CodeAnalysis.Operations.IUnaryOperation
this_param)
{
var return_v = this_param.OperatorKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 41780, 41802);
return return_v;
}


bool
f_25060_41823_41841(Microsoft.CodeAnalysis.Operations.IUnaryOperation
this_param)
{
var return_v = this_param.IsLifted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 41823, 41841);
return return_v;
}


bool
f_25060_41934_41953(Microsoft.CodeAnalysis.Operations.IUnaryOperation
this_param)
{
var return_v = this_param.IsChecked;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 41934, 41953);
return return_v;
}


int
f_25060_42041_42067(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 42041, 42067);
return 0;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_25060_42119_42143(Microsoft.CodeAnalysis.Operations.IUnaryOperation
this_param)
{
var return_v = this_param.OperatorMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 42119, 42143);
return return_v;
}


int
f_25060_42082_42144(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IMethodSymbol?
operatorMethodOpt)
{
this_param.LogHasOperatorMethodExpressionCommon( operatorMethodOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 42082, 42144);
return 0;
}


int
f_25060_42159_42199(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IUnaryOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 42159, 42199);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_42222_42239(Microsoft.CodeAnalysis.Operations.IUnaryOperation
this_param)
{
var return_v = this_param.Operand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 42222, 42239);
return return_v;
}


int
f_25060_42216_42251(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 42216, 42251);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,41593,42263);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,41593,42263);
}
		}

public override void VisitBinaryOperator(IBinaryOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,42275,43211);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,42368,42404);

f_25060_42368_42403(this, nameof(IBinaryOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,42420,42491);

var 
kindStr = $"{nameof(BinaryOperatorKind)}.{f_25060_42466_42488(operation)}"
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,42505,42600) || true) && (f_25060_42509_42527(operation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,42505,42600);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,42561,42585);

kindStr += ", IsLifted";
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,42505,42600);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,42616,42711) || true) && (f_25060_42620_42639(operation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,42616,42711);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,42673,42696);

kindStr += ", Checked";
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,42616,42711);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,42727,42830) || true) && (f_25060_42731_42754(operation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,42727,42830);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,42788,42815);

kindStr += ", CompareText";
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,42727,42830);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,42846,42873);

f_25060_42846_42872(this, $" ({kindStr})");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,42887,42950);

f_25060_42887_42949(this, f_25060_42924_42948(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,42964,43039);

var 
unaryOperatorMethod = f_25060_42990_43038(((BinaryOperation)operation))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,43053,43094);

f_25060_43053_43093(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,43110,43147);

f_25060_43110_43146(this, f_25060_43116_43137(operation), "Left");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,43161,43200);

f_25060_43161_43199(this, f_25060_43167_43189(operation), "Right");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,42275,43211);

int
f_25060_42368_42403(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 42368, 42403);
return 0;
}


Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
f_25060_42466_42488(Microsoft.CodeAnalysis.Operations.IBinaryOperation
this_param)
{
var return_v = this_param.OperatorKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 42466, 42488);
return return_v;
}


bool
f_25060_42509_42527(Microsoft.CodeAnalysis.Operations.IBinaryOperation
this_param)
{
var return_v = this_param.IsLifted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 42509, 42527);
return return_v;
}


bool
f_25060_42620_42639(Microsoft.CodeAnalysis.Operations.IBinaryOperation
this_param)
{
var return_v = this_param.IsChecked;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 42620, 42639);
return return_v;
}


bool
f_25060_42731_42754(Microsoft.CodeAnalysis.Operations.IBinaryOperation
this_param)
{
var return_v = this_param.IsCompareText;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 42731, 42754);
return return_v;
}


int
f_25060_42846_42872(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 42846, 42872);
return 0;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_25060_42924_42948(Microsoft.CodeAnalysis.Operations.IBinaryOperation
this_param)
{
var return_v = this_param.OperatorMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 42924, 42948);
return return_v;
}


int
f_25060_42887_42949(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IMethodSymbol?
operatorMethodOpt)
{
this_param.LogHasOperatorMethodExpressionCommon( operatorMethodOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 42887, 42949);
return 0;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_25060_42990_43038(Microsoft.CodeAnalysis.Operations.BinaryOperation
this_param)
{
var return_v = this_param.UnaryOperatorMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 42990, 43038);
return return_v;
}


int
f_25060_43053_43093(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IBinaryOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 43053, 43093);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_43116_43137(Microsoft.CodeAnalysis.Operations.IBinaryOperation
this_param)
{
var return_v = this_param.LeftOperand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 43116, 43137);
return return_v;
}


int
f_25060_43110_43146(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 43110, 43146);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_43167_43189(Microsoft.CodeAnalysis.Operations.IBinaryOperation
this_param)
{
var return_v = this_param.RightOperand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 43167, 43189);
return return_v;
}


int
f_25060_43161_43199(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 43161, 43199);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,42275,43211);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,42275,43211);
}
		}

public override void VisitTupleBinaryOperator(ITupleBinaryOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,43223,43667);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,43326,43367);

f_25060_43326_43366(this, nameof(ITupleBinaryOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,43381,43452);

var 
kindStr = $"{nameof(BinaryOperatorKind)}.{f_25060_43427_43449(operation)}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,43468,43495);

f_25060_43468_43494(this, $" ({kindStr})");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,43509,43550);

f_25060_43509_43549(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,43566,43603);

f_25060_43566_43602(this, f_25060_43572_43593(operation), "Left");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,43617,43656);

f_25060_43617_43655(this, f_25060_43623_43645(operation), "Right");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,43223,43667);

int
f_25060_43326_43366(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 43326, 43366);
return 0;
}


Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
f_25060_43427_43449(Microsoft.CodeAnalysis.Operations.ITupleBinaryOperation
this_param)
{
var return_v = this_param.OperatorKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 43427, 43449);
return return_v;
}


int
f_25060_43468_43494(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 43468, 43494);
return 0;
}


int
f_25060_43509_43549(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.ITupleBinaryOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 43509, 43549);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_43572_43593(Microsoft.CodeAnalysis.Operations.ITupleBinaryOperation
this_param)
{
var return_v = this_param.LeftOperand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 43572, 43593);
return return_v;
}


int
f_25060_43566_43602(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 43566, 43602);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_43623_43645(Microsoft.CodeAnalysis.Operations.ITupleBinaryOperation
this_param)
{
var return_v = this_param.RightOperand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 43623, 43645);
return return_v;
}


int
f_25060_43617_43655(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 43617, 43655);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,43223,43667);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,43223,43667);
}
		}

private void LogHasOperatorMethodExpressionCommon(IMethodSymbol operatorMethodOpt)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,43679,43965);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,43786,43954) || true) && (operatorMethodOpt != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,43786,43954);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,43849,43906);

f_25060_43849_43905(this, operatorMethodOpt, header: " (OperatorMethod");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,43924,43939);

f_25060_43924_43938(this, ")");
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,43786,43954);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,43679,43965);

int
f_25060_43849_43905(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IMethodSymbol
symbol,string
header)
{
this_param.LogSymbol( (Microsoft.CodeAnalysis.ISymbol)symbol, header: header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 43849, 43905);
return 0;
}


int
f_25060_43924_43938(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 43924, 43938);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,43679,43965);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,43679,43965);
}
		}

public override void VisitConversion(IConversionOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,43977,44932);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,44070,44110);

f_25060_44070_44109(this, nameof(IConversionOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,44126,44197);

var 
isTryCast = $"TryCast: {((DynAbs.Tracing.TraceSender.Conditional_F1(25060, 44155, 44174)||((f_25060_44155_44174(operation)&&DynAbs.Tracing.TraceSender.Conditional_F2(25060, 44177, 44183))||DynAbs.Tracing.TraceSender.Conditional_F3(25060, 44186, 44193)))?"True" :"False")}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,44211,44273);

var 
isChecked = (DynAbs.Tracing.TraceSender.Conditional_F1(25060, 44227, 44246)||((f_25060_44227_44246(operation)&&DynAbs.Tracing.TraceSender.Conditional_F2(25060, 44249, 44258))||DynAbs.Tracing.TraceSender.Conditional_F3(25060, 44261, 44272)))?"Checked" :"Unchecked"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,44287,44329);

f_25060_44287_44328(this, $" ({isTryCast}, {isChecked})");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,44345,44408);

f_25060_44345_44407(this, f_25060_44382_44406(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,44422,44463);

f_25060_44422_44462(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,44477,44486);

f_25060_44477_44485(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,44500,44536);

f_25060_44500_44535(this, f_25060_44514_44534(operation));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,44552,44815) || true) && (f_25060_44556_44598(((Operation)operation))== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,44552,44815);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,44640,44653);

f_25060_44640_44652(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,44671,44680);

f_25060_44671_44679(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,44698,44771);

f_25060_44698_44770(this, $"({f_25060_44712_44766(((ConversionOperation)operation))})");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,44789,44800);

f_25060_44789_44799(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,44552,44815);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,44831,44842);

f_25060_44831_44841(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,44856,44869);

f_25060_44856_44868(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,44885,44921);

f_25060_44885_44920(this, f_25060_44891_44908(operation), "Operand");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,43977,44932);

int
f_25060_44070_44109(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 44070, 44109);
return 0;
}


bool
f_25060_44155_44174(Microsoft.CodeAnalysis.Operations.IConversionOperation
this_param)
{
var return_v = this_param.IsTryCast ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 44155, 44174);
return return_v;
}


bool
f_25060_44227_44246(Microsoft.CodeAnalysis.Operations.IConversionOperation
this_param)
{
var return_v = this_param.IsChecked ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 44227, 44246);
return return_v;
}


int
f_25060_44287_44328(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 44287, 44328);
return 0;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_25060_44382_44406(Microsoft.CodeAnalysis.Operations.IConversionOperation
this_param)
{
var return_v = this_param.OperatorMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 44382, 44406);
return return_v;
}


int
f_25060_44345_44407(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IMethodSymbol?
operatorMethodOpt)
{
this_param.LogHasOperatorMethodExpressionCommon( operatorMethodOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 44345, 44407);
return 0;
}


int
f_25060_44422_44462(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IConversionOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 44422, 44462);
return 0;
}


int
f_25060_44477_44485(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Indent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 44477, 44485);
return 0;
}


Microsoft.CodeAnalysis.Operations.CommonConversion
f_25060_44514_44534(Microsoft.CodeAnalysis.Operations.IConversionOperation
this_param)
{
var return_v = this_param.Conversion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 44514, 44534);
return return_v;
}


int
f_25060_44500_44535(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.CommonConversion
conversion)
{
this_param.LogConversion( conversion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 44500, 44535);
return 0;
}


Microsoft.CodeAnalysis.SemanticModel?
f_25060_44556_44598(Microsoft.CodeAnalysis.Operation
this_param)
{
var return_v = this_param.OwningSemanticModel ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 44556, 44598);
return return_v;
}


int
f_25060_44640_44652(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 44640, 44652);
return 0;
}


int
f_25060_44671_44679(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Indent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 44671, 44679);
return 0;
}


Microsoft.CodeAnalysis.Operations.IConvertibleConversion
f_25060_44712_44766(Microsoft.CodeAnalysis.Operations.ConversionOperation
this_param)
{
var return_v = this_param.ConversionConvertible;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 44712, 44766);
return return_v;
}


int
f_25060_44698_44770(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 44698, 44770);
return 0;
}


int
f_25060_44789_44799(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Unindent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 44789, 44799);
return 0;
}


int
f_25060_44831_44841(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Unindent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 44831, 44841);
return 0;
}


int
f_25060_44856_44868(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 44856, 44868);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_44891_44908(Microsoft.CodeAnalysis.Operations.IConversionOperation
this_param)
{
var return_v = this_param.Operand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 44891, 44908);
return return_v;
}


int
f_25060_44885_44920(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 44885, 44920);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,43977,44932);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,43977,44932);
}
		}

public override void VisitConditional(IConditionalOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,44944,45416);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,45039,45080);

f_25060_45039_45079(this, nameof(IConditionalOperation));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,45096,45186) || true) && (f_25060_45100_45115(operation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,45096,45186);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,45149,45171);

f_25060_45149_45170(this, " (IsRef)");
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,45096,45186);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,45202,45243);

f_25060_45202_45242(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,45259,45299);

f_25060_45259_45298(this, f_25060_45265_45284(operation), "Condition");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,45313,45351);

f_25060_45313_45350(this, f_25060_45319_45337(operation), "WhenTrue");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,45365,45405);

f_25060_45365_45404(this, f_25060_45371_45390(operation), "WhenFalse");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,44944,45416);

int
f_25060_45039_45079(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 45039, 45079);
return 0;
}


bool
f_25060_45100_45115(Microsoft.CodeAnalysis.Operations.IConditionalOperation
this_param)
{
var return_v = this_param.IsRef;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 45100, 45115);
return return_v;
}


int
f_25060_45149_45170(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 45149, 45170);
return 0;
}


int
f_25060_45202_45242(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IConditionalOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 45202, 45242);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_45265_45284(Microsoft.CodeAnalysis.Operations.IConditionalOperation
this_param)
{
var return_v = this_param.Condition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 45265, 45284);
return return_v;
}


int
f_25060_45259_45298(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 45259, 45298);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_45319_45337(Microsoft.CodeAnalysis.Operations.IConditionalOperation
this_param)
{
var return_v = this_param.WhenTrue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 45319, 45337);
return return_v;
}


int
f_25060_45313_45350(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 45313, 45350);
return 0;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_45371_45390(Microsoft.CodeAnalysis.Operations.IConditionalOperation
this_param)
{
var return_v = this_param.WhenFalse;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 45371, 45390);
return return_v;
}


int
f_25060_45365_45404(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation?
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 45365, 45404);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,44944,45416);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,44944,45416);
}
		}

public override void VisitCoalesce(ICoalesceOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,45428,46042);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,45517,45555);

f_25060_45517_45554(this, nameof(ICoalesceOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,45569,45610);

f_25060_45569_45609(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,45626,45663);

f_25060_45626_45662(this, f_25060_45632_45647(operation), "Expression");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,45677,45686);

f_25060_45677_45685(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,45700,45760);

f_25060_45700_45759(this, f_25060_45714_45739(operation), "ValueConversion");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,45774,45787);

f_25060_45774_45786(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,45801,45810);

f_25060_45801_45809(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,45824,45900);

f_25060_45824_45899(this, $"({f_25060_45838_45895(((CoalesceOperation)operation))})");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,45914,45925);

f_25060_45914_45924(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,45939,45952);

f_25060_45939_45951(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,45966,45977);

f_25060_45966_45976(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,45993,46031);

f_25060_45993_46030(this, f_25060_45999_46017(operation), "WhenNull");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,45428,46042);

int
f_25060_45517_45554(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 45517, 45554);
return 0;
}


int
f_25060_45569_45609(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.ICoalesceOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 45569, 45609);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_45632_45647(Microsoft.CodeAnalysis.Operations.ICoalesceOperation
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 45632, 45647);
return return_v;
}


int
f_25060_45626_45662(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 45626, 45662);
return 0;
}


int
f_25060_45677_45685(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Indent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 45677, 45685);
return 0;
}


Microsoft.CodeAnalysis.Operations.CommonConversion
f_25060_45714_45739(Microsoft.CodeAnalysis.Operations.ICoalesceOperation
this_param)
{
var return_v = this_param.ValueConversion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 45714, 45739);
return return_v;
}


int
f_25060_45700_45759(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.CommonConversion
conversion,string
header)
{
this_param.LogConversion( conversion, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 45700, 45759);
return 0;
}


int
f_25060_45774_45786(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 45774, 45786);
return 0;
}


int
f_25060_45801_45809(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Indent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 45801, 45809);
return 0;
}


Microsoft.CodeAnalysis.Operations.IConvertibleConversion
f_25060_45838_45895(Microsoft.CodeAnalysis.Operations.CoalesceOperation
this_param)
{
var return_v = this_param.ValueConversionConvertible;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 45838, 45895);
return return_v;
}


int
f_25060_45824_45899(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 45824, 45899);
return 0;
}


int
f_25060_45914_45924(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Unindent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 45914, 45924);
return 0;
}


int
f_25060_45939_45951(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 45939, 45951);
return 0;
}


int
f_25060_45966_45976(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Unindent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 45966, 45976);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_45999_46017(Microsoft.CodeAnalysis.Operations.ICoalesceOperation
this_param)
{
var return_v = this_param.WhenNull;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 45999, 46017);
return return_v;
}


int
f_25060_45993_46030(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 45993, 46030);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,45428,46042);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,45428,46042);
}
		}

public override void VisitCoalesceAssignment(ICoalesceAssignmentOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,46054,46405);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,46163,46211);

f_25060_46163_46210(this, nameof(ICoalesceAssignmentOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,46225,46266);

f_25060_46225_46265(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,46282,46332);

f_25060_46282_46331(this, f_25060_46288_46304(operation), nameof(operation.Target));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,46346,46394);

f_25060_46346_46393(this, f_25060_46352_46367(operation), nameof(operation.Value));
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,46054,46405);

int
f_25060_46163_46210(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 46163, 46210);
return 0;
}


int
f_25060_46225_46265(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.ICoalesceAssignmentOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 46225, 46265);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_46288_46304(Microsoft.CodeAnalysis.Operations.ICoalesceAssignmentOperation
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 46288, 46304);
return return_v;
}


int
f_25060_46282_46331(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 46282, 46331);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_46352_46367(Microsoft.CodeAnalysis.Operations.ICoalesceAssignmentOperation
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 46352, 46367);
return return_v;
}


int
f_25060_46346_46393(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 46346, 46393);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,46054,46405);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,46054,46405);
}
		}

public override void VisitIsType(IIsTypeOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,46417,46913);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,46502,46538);

f_25060_46502_46537(this, nameof(IIsTypeOperation));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,46552,46656) || true) && (f_25060_46556_46575(operation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,46552,46656);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,46609,46641);

f_25060_46609_46640(this, " (IsNotExpression)");
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,46552,46656);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,46672,46713);

f_25060_46672_46712(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,46729,46770);

f_25060_46729_46769(this, f_25060_46735_46757(operation), "Operand");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,46786,46795);

f_25060_46786_46794(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,46809,46850);

f_25060_46809_46849(this, f_25060_46817_46838(operation), "IsType");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,46864,46877);

f_25060_46864_46876(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,46891,46902);

f_25060_46891_46901(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,46417,46913);

int
f_25060_46502_46537(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 46502, 46537);
return 0;
}


bool
f_25060_46556_46575(Microsoft.CodeAnalysis.Operations.IIsTypeOperation
this_param)
{
var return_v = this_param.IsNegated;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 46556, 46575);
return return_v;
}


int
f_25060_46609_46640(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 46609, 46640);
return 0;
}


int
f_25060_46672_46712(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IIsTypeOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 46672, 46712);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_46735_46757(Microsoft.CodeAnalysis.Operations.IIsTypeOperation
this_param)
{
var return_v = this_param.ValueOperand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 46735, 46757);
return return_v;
}


int
f_25060_46729_46769(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 46729, 46769);
return 0;
}


int
f_25060_46786_46794(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Indent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 46786, 46794);
return 0;
}


Microsoft.CodeAnalysis.ITypeSymbol
f_25060_46817_46838(Microsoft.CodeAnalysis.Operations.IIsTypeOperation
this_param)
{
var return_v = this_param.TypeOperand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 46817, 46838);
return return_v;
}


int
f_25060_46809_46849(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.ITypeSymbol
type,string
header)
{
this_param.LogType( type, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 46809, 46849);
return 0;
}


int
f_25060_46864_46876(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 46864, 46876);
return 0;
}


int
f_25060_46891_46901(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Unindent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 46891, 46901);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,46417,46913);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,46417,46913);
}
		}

public override void VisitSizeOf(ISizeOfOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,46925,47249);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,47010,47046);

f_25060_47010_47045(this, nameof(ISizeOfOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,47060,47101);

f_25060_47060_47100(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,47117,47126);

f_25060_47117_47125(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,47140,47186);

f_25060_47140_47185(this, f_25060_47148_47169(operation), "TypeOperand");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,47200,47213);

f_25060_47200_47212(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,47227,47238);

f_25060_47227_47237(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,46925,47249);

int
f_25060_47010_47045(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 47010, 47045);
return 0;
}


int
f_25060_47060_47100(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.ISizeOfOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 47060, 47100);
return 0;
}


int
f_25060_47117_47125(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Indent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 47117, 47125);
return 0;
}


Microsoft.CodeAnalysis.ITypeSymbol
f_25060_47148_47169(Microsoft.CodeAnalysis.Operations.ISizeOfOperation
this_param)
{
var return_v = this_param.TypeOperand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 47148, 47169);
return return_v;
}


int
f_25060_47140_47185(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.ITypeSymbol
type,string
header)
{
this_param.LogType( type, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 47140, 47185);
return 0;
}


int
f_25060_47200_47212(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 47200, 47212);
return 0;
}


int
f_25060_47227_47237(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Unindent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 47227, 47237);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,46925,47249);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,46925,47249);
}
		}

public override void VisitTypeOf(ITypeOfOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,47261,47585);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,47346,47382);

f_25060_47346_47381(this, nameof(ITypeOfOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,47396,47437);

f_25060_47396_47436(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,47453,47462);

f_25060_47453_47461(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,47476,47522);

f_25060_47476_47521(this, f_25060_47484_47505(operation), "TypeOperand");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,47536,47549);

f_25060_47536_47548(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,47563,47574);

f_25060_47563_47573(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,47261,47585);

int
f_25060_47346_47381(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 47346, 47381);
return 0;
}


int
f_25060_47396_47436(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.ITypeOfOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 47396, 47436);
return 0;
}


int
f_25060_47453_47461(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Indent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 47453, 47461);
return 0;
}


Microsoft.CodeAnalysis.ITypeSymbol
f_25060_47484_47505(Microsoft.CodeAnalysis.Operations.ITypeOfOperation
this_param)
{
var return_v = this_param.TypeOperand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 47484, 47505);
return return_v;
}


int
f_25060_47476_47521(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.ITypeSymbol
type,string
header)
{
this_param.LogType( type, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 47476, 47521);
return 0;
}


int
f_25060_47536_47548(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 47536, 47548);
return 0;
}


int
f_25060_47563_47573(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Unindent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 47563, 47573);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,47261,47585);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,47261,47585);
}
		}

public override void VisitAnonymousFunction(IAnonymousFunctionOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,47597,48261);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,47704,47751);

f_25060_47704_47750(this, nameof(IAnonymousFunctionOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,48063,48111);

f_25060_48063_48110(this, f_25060_48073_48089(operation), header: " (Symbol");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,48125,48140);

f_25060_48125_48139(this, ")");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,48154,48195);

f_25060_48154_48194(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,48211,48250);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitAnonymousFunction(operation),25060,48211,48249);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,47597,48261);

int
f_25060_47704_47750(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 47704, 47750);
return 0;
}


Microsoft.CodeAnalysis.IMethodSymbol
f_25060_48073_48089(Microsoft.CodeAnalysis.Operations.IAnonymousFunctionOperation
this_param)
{
var return_v = this_param.Symbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 48073, 48089);
return return_v;
}


int
f_25060_48063_48110(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IMethodSymbol
symbol,string
header)
{
this_param.LogSymbol( (Microsoft.CodeAnalysis.ISymbol)symbol, header: header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 48063, 48110);
return 0;
}


int
f_25060_48125_48139(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 48125, 48139);
return 0;
}


int
f_25060_48154_48194(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IAnonymousFunctionOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 48154, 48194);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,47597,48261);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,47597,48261);
}
		}

public override void VisitFlowAnonymousFunction(IFlowAnonymousFunctionOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,48273,48953);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,48388,48439);

f_25060_48388_48438(this, nameof(IFlowAnonymousFunctionOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,48751,48799);

f_25060_48751_48798(this, f_25060_48761_48777(operation), header: " (Symbol");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,48813,48828);

f_25060_48813_48827(this, ")");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,48842,48883);

f_25060_48842_48882(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,48899,48942);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitFlowAnonymousFunction(operation),25060,48899,48941);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,48273,48953);

int
f_25060_48388_48438(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 48388, 48438);
return 0;
}


Microsoft.CodeAnalysis.IMethodSymbol
f_25060_48761_48777(Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
this_param)
{
var return_v = this_param.Symbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 48761, 48777);
return return_v;
}


int
f_25060_48751_48798(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IMethodSymbol
symbol,string
header)
{
this_param.LogSymbol( (Microsoft.CodeAnalysis.ISymbol)symbol, header: header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 48751, 48798);
return 0;
}


int
f_25060_48813_48827(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 48813, 48827);
return 0;
}


int
f_25060_48842_48882(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 48842, 48882);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,48273,48953);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,48273,48953);
}
		}

public override void VisitDelegateCreation(IDelegateCreationOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,48965,49248);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,49070,49116);

f_25060_49070_49115(this, nameof(IDelegateCreationOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,49130,49171);

f_25060_49130_49170(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,49187,49237);

f_25060_49187_49236(this, f_25060_49193_49209(operation), nameof(operation.Target));
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,48965,49248);

int
f_25060_49070_49115(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 49070, 49115);
return 0;
}


int
f_25060_49130_49170(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IDelegateCreationOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 49130, 49170);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_49193_49209(Microsoft.CodeAnalysis.Operations.IDelegateCreationOperation
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 49193, 49209);
return return_v;
}


int
f_25060_49187_49236(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 49187, 49236);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,48965,49248);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,48965,49248);
}
		}

public override void VisitLiteral(ILiteralOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,49260,49450);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,49347,49384);

f_25060_49347_49383(this, nameof(ILiteralOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,49398,49439);

f_25060_49398_49438(this, operation);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,49260,49450);

int
f_25060_49347_49383(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 49347, 49383);
return 0;
}


int
f_25060_49398_49438(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.ILiteralOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 49398, 49438);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,49260,49450);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,49260,49450);
}
		}

public override void VisitAwait(IAwaitOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,49462,49703);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,49545,49580);

f_25060_49545_49579(this, nameof(IAwaitOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,49594,49635);

f_25060_49594_49634(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,49651,49692);

f_25060_49651_49691(this, f_25060_49657_49676(operation), "Expression");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,49462,49703);

int
f_25060_49545_49579(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 49545, 49579);
return 0;
}


int
f_25060_49594_49634(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IAwaitOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 49594, 49634);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_49657_49676(Microsoft.CodeAnalysis.Operations.IAwaitOperation
this_param)
{
var return_v = this_param.Operation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 49657, 49676);
return return_v;
}


int
f_25060_49651_49691(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 49651, 49691);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,49462,49703);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,49462,49703);
}
		}

public override void VisitNameOf(INameOfOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,49715,49944);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,49800,49836);

f_25060_49800_49835(this, nameof(INameOfOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,49850,49891);

f_25060_49850_49890(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,49907,49933);

f_25060_49907_49932(this, f_25060_49913_49931(operation));
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,49715,49944);

int
f_25060_49800_49835(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 49800, 49835);
return 0;
}


int
f_25060_49850_49890(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.INameOfOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 49850, 49890);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_49913_49931(Microsoft.CodeAnalysis.Operations.INameOfOperation
this_param)
{
var return_v = this_param.Argument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 49913, 49931);
return return_v;
}


int
f_25060_49907_49932(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation)
{
this_param.Visit( operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 49907, 49932);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,49715,49944);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,49715,49944);
}
		}

public override void VisitThrow(IThrowOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,49956,50183);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,50039,50074);

f_25060_50039_50073(this, nameof(IThrowOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,50088,50129);

f_25060_50088_50128(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,50145,50172);

f_25060_50145_50171(this, f_25060_50151_50170(operation));
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,49956,50183);

int
f_25060_50039_50073(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 50039, 50073);
return 0;
}


int
f_25060_50088_50128(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IThrowOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 50088, 50128);
return 0;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_50151_50170(Microsoft.CodeAnalysis.Operations.IThrowOperation
this_param)
{
var return_v = this_param.Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 50151, 50170);
return return_v;
}


int
f_25060_50145_50171(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation?
operation)
{
this_param.Visit( operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 50145, 50171);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,49956,50183);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,49956,50183);
}
		}

public override void VisitAddressOf(IAddressOfOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,50195,50447);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,50286,50325);

f_25060_50286_50324(this, nameof(IAddressOfOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,50339,50380);

f_25060_50339_50379(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,50396,50436);

f_25060_50396_50435(this, f_25060_50402_50421(operation), "Reference");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,50195,50447);

int
f_25060_50286_50324(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 50286, 50324);
return 0;
}


int
f_25060_50339_50379(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IAddressOfOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 50339, 50379);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_50402_50421(Microsoft.CodeAnalysis.Operations.IAddressOfOperation
this_param)
{
var return_v = this_param.Reference;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 50402, 50421);
return return_v;
}


int
f_25060_50396_50435(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 50396, 50435);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,50195,50447);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,50195,50447);
}
		}

public override void VisitObjectCreation(IObjectCreationOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,50459,50887);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,50560,50604);

f_25060_50560_50603(this, nameof(IObjectCreationOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,50620,50709);

f_25060_50620_50708(this, $" (Constructor: {f_25060_50670_50692(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_25060_50648_50669(operation), 25060, 50648, 50692))??(DynAbs.Tracing.TraceSender.Expression_Null<string?>(25060, 50648, 50704)??"<null>")})");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,50725,50766);

f_25060_50725_50765(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,50782,50818);

f_25060_50782_50817(this, f_25060_50797_50816(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,50832,50876);

f_25060_50832_50875(this, f_25060_50838_50859(operation), "Initializer");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,50459,50887);

int
f_25060_50560_50603(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 50560, 50603);
return 0;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_25060_50648_50669(Microsoft.CodeAnalysis.Operations.IObjectCreationOperation
this_param)
{
var return_v = this_param.Constructor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 50648, 50669);
return return_v;
}


string
f_25060_50670_50692(Microsoft.CodeAnalysis.IMethodSymbol
symbol)
{
var return_v = symbol?.ToTestDisplayString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 50670, 50692);
return return_v;
}


int
f_25060_50620_50708(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 50620, 50708);
return 0;
}


int
f_25060_50725_50765(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IObjectCreationOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 50725, 50765);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
f_25060_50797_50816(Microsoft.CodeAnalysis.Operations.IObjectCreationOperation
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 50797, 50816);
return return_v;
}


int
f_25060_50782_50817(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
arguments)
{
this_param.VisitArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 50782, 50817);
return 0;
}


Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation?
f_25060_50838_50859(Microsoft.CodeAnalysis.Operations.IObjectCreationOperation
this_param)
{
var return_v = this_param.Initializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 50838, 50859);
return return_v;
}


int
f_25060_50832_50875(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation?
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation?)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 50832, 50875);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,50459,50887);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,50459,50887);
}
		}

public override void VisitAnonymousObjectCreation(IAnonymousObjectCreationOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,50899,51801);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,51018,51071);

f_25060_51018_51070(this, nameof(IAnonymousObjectCreationOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,51085,51126);

f_25060_51085_51125(this, operation);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,51142,51700);
foreach(var initializer in f_25060_51170_51192_I(f_25060_51170_51192(operation)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,51142,51700);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,51226,51289);

var 
simpleAssignment = (ISimpleAssignmentOperation)initializer
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,51307,51384);

var 
propertyReference = (IPropertyReferenceOperation)f_25060_51360_51383(simpleAssignment)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,51402,51444);

f_25060_51402_51443(f_25060_51415_51442(propertyReference));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,51462,51541);

f_25060_51462_51540(OperationKind.InstanceReference, f_25060_51508_51539(f_25060_51508_51534(propertyReference)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,51559,51685);

f_25060_51559_51684(InstanceReferenceKind.ImplicitReceiver, f_25060_51612_51683(((IInstanceReferenceOperation)f_25060_51642_51668(propertyReference))));
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,51142,51700);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25060,1,559);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25060,1,559);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,51716,51790);

f_25060_51716_51789(this, f_25060_51727_51749(operation), "Initializers", logElementCount: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,50899,51801);

int
f_25060_51018_51070(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 51018, 51070);
return 0;
}


int
f_25060_51085_51125(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IAnonymousObjectCreationOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 51085, 51125);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
f_25060_51170_51192(Microsoft.CodeAnalysis.Operations.IAnonymousObjectCreationOperation
this_param)
{
var return_v = this_param.Initializers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 51170, 51192);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_25060_51360_51383(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 51360, 51383);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
f_25060_51415_51442(Microsoft.CodeAnalysis.Operations.IPropertyReferenceOperation
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 51415, 51442);
return return_v;
}


int
f_25060_51402_51443(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
collection)
{
Assert.Empty( (System.Collections.IEnumerable)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 51402, 51443);
return 0;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_51508_51534(Microsoft.CodeAnalysis.Operations.IPropertyReferenceOperation
this_param)
{
var return_v = this_param.Instance;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 51508, 51534);
return return_v;
}


Microsoft.CodeAnalysis.OperationKind
f_25060_51508_51539(Microsoft.CodeAnalysis.IOperation?
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 51508, 51539);
return return_v;
}


int
f_25060_51462_51540(Microsoft.CodeAnalysis.OperationKind
expected,Microsoft.CodeAnalysis.OperationKind
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 51462, 51540);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_51642_51668(Microsoft.CodeAnalysis.Operations.IPropertyReferenceOperation
this_param)
{
var return_v = this_param.Instance;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 51642, 51668);
return return_v;
}


Microsoft.CodeAnalysis.Operations.InstanceReferenceKind
f_25060_51612_51683(Microsoft.CodeAnalysis.Operations.IInstanceReferenceOperation
this_param)
{
var return_v = this_param.ReferenceKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 51612, 51683);
return return_v;
}


int
f_25060_51559_51684(Microsoft.CodeAnalysis.Operations.InstanceReferenceKind
expected,Microsoft.CodeAnalysis.Operations.InstanceReferenceKind
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 51559, 51684);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
f_25060_51170_51192_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 51170, 51192);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
f_25060_51727_51749(Microsoft.CodeAnalysis.Operations.IAnonymousObjectCreationOperation
this_param)
{
var return_v = this_param.Initializers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 51727, 51749);
return return_v;
}


int
f_25060_51716_51789(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
list,string
header,bool
logElementCount)
{
this_param.VisitArray<Microsoft.CodeAnalysis.IOperation>( list, header, logElementCount: logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 51716, 51789);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,50899,51801);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,50899,51801);
}
		}

public override void VisitDynamicObjectCreation(IDynamicObjectCreationOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,51813,52183);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,51928,51979);

f_25060_51928_51978(this, nameof(IDynamicObjectCreationOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,51993,52034);

f_25060_51993_52033(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,52050,52114);

f_25060_52050_52113(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,52128,52172);

f_25060_52128_52171(this, f_25060_52134_52155(operation), "Initializer");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,51813,52183);

int
f_25060_51928_51978(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 51928, 51978);
return 0;
}


int
f_25060_51993_52033(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IDynamicObjectCreationOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 51993, 52033);
return 0;
}


int
f_25060_52050_52113(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IDynamicObjectCreationOperation
operation)
{
this_param.VisitDynamicArguments( (Microsoft.CodeAnalysis.Operations.HasDynamicArgumentsExpression)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 52050, 52113);
return 0;
}


Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation?
f_25060_52134_52155(Microsoft.CodeAnalysis.Operations.IDynamicObjectCreationOperation
this_param)
{
var return_v = this_param.Initializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 52134, 52155);
return return_v;
}


int
f_25060_52128_52171(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation?
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation?)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 52128, 52171);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,51813,52183);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,51813,52183);
}
		}

public override void VisitDynamicInvocation(IDynamicInvocationOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,52195,52550);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,52302,52349);

f_25060_52302_52348(this, nameof(IDynamicInvocationOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,52363,52404);

f_25060_52363_52403(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,52420,52461);

f_25060_52420_52460(this, f_25060_52426_52445(operation), "Expression");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,52475,52539);

f_25060_52475_52538(this, operation);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,52195,52550);

int
f_25060_52302_52348(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 52302, 52348);
return 0;
}


int
f_25060_52363_52403(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IDynamicInvocationOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 52363, 52403);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_52426_52445(Microsoft.CodeAnalysis.Operations.IDynamicInvocationOperation
this_param)
{
var return_v = this_param.Operation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 52426, 52445);
return return_v;
}


int
f_25060_52420_52460(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 52420, 52460);
return 0;
}


int
f_25060_52475_52538(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IDynamicInvocationOperation
operation)
{
this_param.VisitDynamicArguments( (Microsoft.CodeAnalysis.Operations.HasDynamicArgumentsExpression)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 52475, 52538);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,52195,52550);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,52195,52550);
}
		}

public override void VisitDynamicIndexerAccess(IDynamicIndexerAccessOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,52562,52926);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,52675,52725);

f_25060_52675_52724(this, nameof(IDynamicIndexerAccessOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,52739,52780);

f_25060_52739_52779(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,52796,52837);

f_25060_52796_52836(this, f_25060_52802_52821(operation), "Expression");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,52851,52915);

f_25060_52851_52914(this, operation);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,52562,52926);

int
f_25060_52675_52724(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 52675, 52724);
return 0;
}


int
f_25060_52739_52779(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IDynamicIndexerAccessOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 52739, 52779);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_52802_52821(Microsoft.CodeAnalysis.Operations.IDynamicIndexerAccessOperation
this_param)
{
var return_v = this_param.Operation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 52802, 52821);
return return_v;
}


int
f_25060_52796_52836(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 52796, 52836);
return 0;
}


int
f_25060_52851_52914(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IDynamicIndexerAccessOperation
operation)
{
this_param.VisitDynamicArguments( (Microsoft.CodeAnalysis.Operations.HasDynamicArgumentsExpression)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 52851, 52914);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,52562,52926);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,52562,52926);
}
		}

public override void VisitObjectOrCollectionInitializer(IObjectOrCollectionInitializerOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,52938,53284);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,53069,53128);

f_25060_53069_53127(this, nameof(IObjectOrCollectionInitializerOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,53142,53183);

f_25060_53142_53182(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,53199,53273);

f_25060_53199_53272(this, f_25060_53210_53232(operation), "Initializers", logElementCount: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,52938,53284);

int
f_25060_53069_53127(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 53069, 53127);
return 0;
}


int
f_25060_53142_53182(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 53142, 53182);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
f_25060_53210_53232(Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation
this_param)
{
var return_v = this_param.Initializers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 53210, 53232);
return return_v;
}


int
f_25060_53199_53272(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
list,string
header,bool
logElementCount)
{
this_param.VisitArray<Microsoft.CodeAnalysis.IOperation>( list, header, logElementCount: logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 53199, 53272);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,52938,53284);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,52938,53284);
}
		}

public override void VisitMemberInitializer(IMemberInitializerOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,53296,53646);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,53403,53450);

f_25060_53403_53449(this, nameof(IMemberInitializerOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,53464,53505);

f_25060_53464_53504(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,53521,53577);

f_25060_53521_53576(this, f_25060_53527_53554(operation), "InitializedMember");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,53591,53635);

f_25060_53591_53634(this, f_25060_53597_53618(operation), "Initializer");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,53296,53646);

int
f_25060_53403_53449(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 53403, 53449);
return 0;
}


int
f_25060_53464_53504(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IMemberInitializerOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 53464, 53504);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_53527_53554(Microsoft.CodeAnalysis.Operations.IMemberInitializerOperation
this_param)
{
var return_v = this_param.InitializedMember;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 53527, 53554);
return return_v;
}


int
f_25060_53521_53576(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 53521, 53576);
return 0;
}


Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation
f_25060_53597_53618(Microsoft.CodeAnalysis.Operations.IMemberInitializerOperation
this_param)
{
var return_v = this_param.Initializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 53597, 53618);
return return_v;
}


int
f_25060_53591_53634(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 53591, 53634);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,53296,53646);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,53296,53646);
}
		}

[Obsolete("ICollectionElementInitializerOperation has been replaced with IInvocationOperation and IDynamicInvocationOperation", error: true)]
        public override void VisitCollectionElementInitializer(ICollectionElementInitializerOperation operation)
		{
			try

        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,53658,54093);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,54045,54082);

throw f_25060_54051_54081();
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,53658,54093);

System.Exception
f_25060_54051_54081()
{
var return_v = ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 54051, 54081);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,53658,54093);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,53658,54093);
}
		}

public override void VisitFieldInitializer(IFieldInitializerOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,54105,55234);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,54210,54256);

f_25060_54210_54255(this, nameof(IFieldInitializerOperation));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,54272,55127) || true) && (operation.InitializedFields.Length <= 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,54272,55127);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,54349,54551) || true) && (operation.InitializedFields.Length == 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,54349,54551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,54434,54495);

f_25060_54434_54494(this, f_25060_54444_54471(operation)[0], header: " (Field");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,54517,54532);

f_25060_54517_54531(this, ")");
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,54349,54551);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,54571,54612);

f_25060_54571_54611(this, operation);
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,54272,55127);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,54272,55127);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,54678,54751);

f_25060_54678_54750(this, $" ({operation.InitializedFields.Length} initialized fields)");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,54769,54810);

f_25060_54769_54809(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,54830,54839);

f_25060_54830_54838(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,54859,54873);

int 
index = 1
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,54891,55081);
foreach(var local in f_25060_54913_54940_I(f_25060_54913_54940(operation)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,54891,55081);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,54982,55027);

f_25060_54982_55026(this, local, header: $"Field_{index++}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,55049,55062);

f_25060_55049_55061(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,54891,55081);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25060,1,191);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25060,1,191);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,55101,55112);

f_25060_55101_55111(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,54272,55127);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,55143,55171);

f_25060_55143_55170(this, f_25060_55153_55169(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,55185,55223);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitFieldInitializer(operation),25060,55185,55222);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,54105,55234);

int
f_25060_54210_54255(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 54210, 54255);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IFieldSymbol>
f_25060_54444_54471(Microsoft.CodeAnalysis.Operations.IFieldInitializerOperation
this_param)
{
var return_v = this_param.InitializedFields;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 54444, 54471);
return return_v;
}


int
f_25060_54434_54494(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IFieldSymbol
symbol,string
header)
{
this_param.LogSymbol( (Microsoft.CodeAnalysis.ISymbol)symbol, header: header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 54434, 54494);
return 0;
}


int
f_25060_54517_54531(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 54517, 54531);
return 0;
}


int
f_25060_54571_54611(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IFieldInitializerOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 54571, 54611);
return 0;
}


int
f_25060_54678_54750(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 54678, 54750);
return 0;
}


int
f_25060_54769_54809(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IFieldInitializerOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 54769, 54809);
return 0;
}


int
f_25060_54830_54838(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Indent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 54830, 54838);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IFieldSymbol>
f_25060_54913_54940(Microsoft.CodeAnalysis.Operations.IFieldInitializerOperation
this_param)
{
var return_v = this_param.InitializedFields;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 54913, 54940);
return return_v;
}


int
f_25060_54982_55026(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IFieldSymbol
symbol,string
header)
{
this_param.LogSymbol( (Microsoft.CodeAnalysis.ISymbol)symbol, header: header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 54982, 55026);
return 0;
}


int
f_25060_55049_55061(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 55049, 55061);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IFieldSymbol>
f_25060_54913_54940_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IFieldSymbol>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 54913, 54940);
return return_v;
}


int
f_25060_55101_55111(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Unindent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 55101, 55111);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
f_25060_55153_55169(Microsoft.CodeAnalysis.Operations.IFieldInitializerOperation
this_param)
{
var return_v = this_param.Locals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 55153, 55169);
return return_v;
}


int
f_25060_55143_55170(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
locals)
{
this_param.LogLocals( (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ILocalSymbol>)locals);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 55143, 55170);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,54105,55234);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,54105,55234);
}
		}

public override void VisitVariableInitializer(IVariableInitializerOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,55246,55572);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,55357,55406);

f_25060_55357_55405(this, nameof(IVariableInitializerOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,55420,55461);

f_25060_55420_55460(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,55475,55506);

f_25060_55475_55505(f_25060_55488_55504(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,55520,55561);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitVariableInitializer(operation),25060,55520,55560);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,55246,55572);

int
f_25060_55357_55405(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 55357, 55405);
return 0;
}


int
f_25060_55420_55460(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 55420, 55460);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
f_25060_55488_55504(Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation
this_param)
{
var return_v = this_param.Locals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 55488, 55504);
return return_v;
}


int
f_25060_55475_55505(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
collection)
{
Assert.Empty( (System.Collections.IEnumerable)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 55475, 55505);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,55246,55572);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,55246,55572);
}
		}

public override void VisitPropertyInitializer(IPropertyInitializerOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,55584,56761);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,55695,55744);

f_25060_55695_55743(this, nameof(IPropertyInitializerOperation));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,55760,56651) || true) && (operation.InitializedProperties.Length <= 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,55760,56651);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,55841,56054) || true) && (operation.InitializedProperties.Length == 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,55841,56054);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,55930,55998);

f_25060_55930_55997(this, f_25060_55940_55971(operation)[0], header: " (Property");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,56020,56035);

f_25060_56020_56034(this, ")");
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,55841,56054);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,56074,56115);

f_25060_56074_56114(this, operation);
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,55760,56651);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,55760,56651);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,56181,56262);

f_25060_56181_56261(this, $" ({operation.InitializedProperties.Length} initialized properties)");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,56280,56321);

f_25060_56280_56320(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,56341,56350);

f_25060_56341_56349(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,56370,56384);

int 
index = 1
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,56402,56605);
foreach(var property in f_25060_56427_56458_I(f_25060_56427_56458(operation)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,56402,56605);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,56500,56551);

f_25060_56500_56550(this, property, header: $"Property_{index++}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,56573,56586);

f_25060_56573_56585(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,56402,56605);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25060,1,204);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25060,1,204);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,56625,56636);

f_25060_56625_56635(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,55760,56651);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,56667,56695);

f_25060_56667_56694(this, f_25060_56677_56693(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,56709,56750);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitPropertyInitializer(operation),25060,56709,56749);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,55584,56761);

int
f_25060_55695_55743(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 55695, 55743);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IPropertySymbol>
f_25060_55940_55971(Microsoft.CodeAnalysis.Operations.IPropertyInitializerOperation
this_param)
{
var return_v = this_param.InitializedProperties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 55940, 55971);
return return_v;
}


int
f_25060_55930_55997(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IPropertySymbol
symbol,string
header)
{
this_param.LogSymbol( (Microsoft.CodeAnalysis.ISymbol)symbol, header: header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 55930, 55997);
return 0;
}


int
f_25060_56020_56034(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 56020, 56034);
return 0;
}


int
f_25060_56074_56114(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IPropertyInitializerOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 56074, 56114);
return 0;
}


int
f_25060_56181_56261(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 56181, 56261);
return 0;
}


int
f_25060_56280_56320(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IPropertyInitializerOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 56280, 56320);
return 0;
}


int
f_25060_56341_56349(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Indent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 56341, 56349);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IPropertySymbol>
f_25060_56427_56458(Microsoft.CodeAnalysis.Operations.IPropertyInitializerOperation
this_param)
{
var return_v = this_param.InitializedProperties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 56427, 56458);
return return_v;
}


int
f_25060_56500_56550(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IPropertySymbol
symbol,string
header)
{
this_param.LogSymbol( (Microsoft.CodeAnalysis.ISymbol)symbol, header: header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 56500, 56550);
return 0;
}


int
f_25060_56573_56585(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 56573, 56585);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IPropertySymbol>
f_25060_56427_56458_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IPropertySymbol>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 56427, 56458);
return return_v;
}


int
f_25060_56625_56635(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Unindent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 56625, 56635);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
f_25060_56677_56693(Microsoft.CodeAnalysis.Operations.IPropertyInitializerOperation
this_param)
{
var return_v = this_param.Locals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 56677, 56693);
return return_v;
}


int
f_25060_56667_56694(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
locals)
{
this_param.LogLocals( (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ILocalSymbol>)locals);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 56667, 56694);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,55584,56761);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,55584,56761);
}
		}

public override void VisitParameterInitializer(IParameterInitializerOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,56773,57199);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,56886,56936);

f_25060_56886_56935(this, nameof(IParameterInitializerOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,56950,57004);

f_25060_56950_57003(this, f_25060_56960_56979(operation), header: " (Parameter");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,57018,57033);

f_25060_57018_57032(this, ")");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,57047,57088);

f_25060_57047_57087(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,57104,57132);

f_25060_57104_57131(this, f_25060_57114_57130(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,57146,57188);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitParameterInitializer(operation),25060,57146,57187);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,56773,57199);

int
f_25060_56886_56935(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 56886, 56935);
return 0;
}


Microsoft.CodeAnalysis.IParameterSymbol
f_25060_56960_56979(Microsoft.CodeAnalysis.Operations.IParameterInitializerOperation
this_param)
{
var return_v = this_param.Parameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 56960, 56979);
return return_v;
}


int
f_25060_56950_57003(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IParameterSymbol
symbol,string
header)
{
this_param.LogSymbol( (Microsoft.CodeAnalysis.ISymbol)symbol, header: header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 56950, 57003);
return 0;
}


int
f_25060_57018_57032(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 57018, 57032);
return 0;
}


int
f_25060_57047_57087(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IParameterInitializerOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 57047, 57087);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
f_25060_57114_57130(Microsoft.CodeAnalysis.Operations.IParameterInitializerOperation
this_param)
{
var return_v = this_param.Locals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 57114, 57130);
return return_v;
}


int
f_25060_57104_57131(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
locals)
{
this_param.LogLocals( (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ILocalSymbol>)locals);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 57104, 57131);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,56773,57199);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,56773,57199);
}
		}

public override void VisitArrayCreation(IArrayCreationOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,57211,57572);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,57310,57353);

f_25060_57310_57352(this, nameof(IArrayCreationOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,57367,57408);

f_25060_57367_57407(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,57424,57503);

f_25060_57424_57502(this, f_25060_57435_57459(operation), "Dimension Sizes", logElementCount: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,57517,57561);

f_25060_57517_57560(this, f_25060_57523_57544(operation), "Initializer");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,57211,57572);

int
f_25060_57310_57352(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 57310, 57352);
return 0;
}


int
f_25060_57367_57407(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IArrayCreationOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 57367, 57407);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
f_25060_57435_57459(Microsoft.CodeAnalysis.Operations.IArrayCreationOperation
this_param)
{
var return_v = this_param.DimensionSizes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 57435, 57459);
return return_v;
}


int
f_25060_57424_57502(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
list,string
header,bool
logElementCount)
{
this_param.VisitArray<Microsoft.CodeAnalysis.IOperation>( list, header, logElementCount: logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 57424, 57502);
return 0;
}


Microsoft.CodeAnalysis.Operations.IArrayInitializerOperation?
f_25060_57523_57544(Microsoft.CodeAnalysis.Operations.IArrayCreationOperation
this_param)
{
var return_v = this_param.Initializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 57523, 57544);
return return_v;
}


int
f_25060_57517_57560(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IArrayInitializerOperation?
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation?)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 57517, 57560);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,57211,57572);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,57211,57572);
}
		}

public override void VisitArrayInitializer(IArrayInitializerOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,57584,58009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,57689,57735);

f_25060_57689_57734(this, nameof(IArrayInitializerOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,57749,57808);

f_25060_57749_57807(this, $" ({operation.ElementValues.Length} elements)");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,57822,57863);

f_25060_57822_57862(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,57879,57907);

f_25060_57879_57906(f_25060_57891_57905(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,57921,57998);

f_25060_57921_57997(this, f_25060_57932_57955(operation), "Element Values", logElementCount: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,57584,58009);

int
f_25060_57689_57734(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 57689, 57734);
return 0;
}


int
f_25060_57749_57807(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 57749, 57807);
return 0;
}


int
f_25060_57822_57862(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IArrayInitializerOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 57822, 57862);
return 0;
}


Microsoft.CodeAnalysis.ITypeSymbol?
f_25060_57891_57905(Microsoft.CodeAnalysis.Operations.IArrayInitializerOperation
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 57891, 57905);
return return_v;
}


int
f_25060_57879_57906(Microsoft.CodeAnalysis.ITypeSymbol?
@object)
{
Assert.Null( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 57879, 57906);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
f_25060_57932_57955(Microsoft.CodeAnalysis.Operations.IArrayInitializerOperation
this_param)
{
var return_v = this_param.ElementValues;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 57932, 57955);
return return_v;
}


int
f_25060_57921_57997(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
list,string
header,bool
logElementCount)
{
this_param.VisitArray<Microsoft.CodeAnalysis.IOperation>( list, header, logElementCount: logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 57921, 57997);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,57584,58009);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,57584,58009);
}
		}

public override void VisitSimpleAssignment(ISimpleAssignmentOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,58021,58440);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,58126,58172);

f_25060_58126_58171(this, nameof(ISimpleAssignmentOperation));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,58188,58278) || true) && (f_25060_58192_58207(operation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,58188,58278);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,58241,58263);

f_25060_58241_58262(this, " (IsRef)");
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,58188,58278);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,58294,58335);

f_25060_58294_58334(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,58351,58383);

f_25060_58351_58382(this, f_25060_58357_58373(operation), "Left");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,58397,58429);

f_25060_58397_58428(this, f_25060_58403_58418(operation), "Right");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,58021,58440);

int
f_25060_58126_58171(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 58126, 58171);
return 0;
}


bool
f_25060_58192_58207(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
this_param)
{
var return_v = this_param.IsRef;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 58192, 58207);
return return_v;
}


int
f_25060_58241_58262(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 58241, 58262);
return 0;
}


int
f_25060_58294_58334(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 58294, 58334);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_58357_58373(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 58357, 58373);
return return_v;
}


int
f_25060_58351_58382(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 58351, 58382);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_58403_58418(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 58403, 58418);
return return_v;
}


int
f_25060_58397_58428(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 58397, 58428);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,58021,58440);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,58021,58440);
}
		}

public override void VisitDeconstructionAssignment(IDeconstructionAssignmentOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,58452,58787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,58573,58627);

f_25060_58573_58626(this, nameof(IDeconstructionAssignmentOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,58641,58682);

f_25060_58641_58681(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,58698,58730);

f_25060_58698_58729(this, f_25060_58704_58720(operation), "Left");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,58744,58776);

f_25060_58744_58775(this, f_25060_58750_58765(operation), "Right");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,58452,58787);

int
f_25060_58573_58626(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 58573, 58626);
return 0;
}


int
f_25060_58641_58681(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IDeconstructionAssignmentOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 58641, 58681);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_58704_58720(Microsoft.CodeAnalysis.Operations.IDeconstructionAssignmentOperation
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 58704, 58720);
return return_v;
}


int
f_25060_58698_58729(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 58698, 58729);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_58750_58765(Microsoft.CodeAnalysis.Operations.IDeconstructionAssignmentOperation
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 58750, 58765);
return return_v;
}


int
f_25060_58744_58775(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 58744, 58775);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,58452,58787);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,58452,58787);
}
		}

public override void VisitDeclarationExpression(IDeclarationExpressionOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,58799,59075);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,58914,58965);

f_25060_58914_58964(this, nameof(IDeclarationExpressionOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,58979,59020);

f_25060_58979_59019(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,59036,59064);

f_25060_59036_59063(this, f_25060_59042_59062(operation));
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,58799,59075);

int
f_25060_58914_58964(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 58914, 58964);
return 0;
}


int
f_25060_58979_59019(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IDeclarationExpressionOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 58979, 59019);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_59042_59062(Microsoft.CodeAnalysis.Operations.IDeclarationExpressionOperation
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 59042, 59062);
return return_v;
}


int
f_25060_59036_59063(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation)
{
this_param.Visit( operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 59036, 59063);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,58799,59075);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,58799,59075);
}
		}

public override void VisitCompoundAssignment(ICompoundAssignmentOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,59087,60071);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,59196,59244);

f_25060_59196_59243(this, nameof(ICompoundAssignmentOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,59260,59331);

var 
kindStr = $"{nameof(BinaryOperatorKind)}.{f_25060_59306_59328(operation)}"
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,59345,59440) || true) && (f_25060_59349_59367(operation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,59345,59440);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,59401,59425);

kindStr += ", IsLifted";
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,59345,59440);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,59456,59551) || true) && (f_25060_59460_59479(operation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,59456,59551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,59513,59536);

kindStr += ", Checked";
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,59456,59551);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,59567,59594);

f_25060_59567_59593(this, $" ({kindStr})");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,59608,59671);

f_25060_59608_59670(this, f_25060_59645_59669(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,59685,59726);

f_25060_59685_59725(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,59740,59749);

f_25060_59740_59748(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,59763,59817);

f_25060_59763_59816(this, f_25060_59777_59799(operation), "InConversion");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,59831,59844);

f_25060_59831_59843(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,59858,59914);

f_25060_59858_59913(this, f_25060_59872_59895(operation), "OutConversion");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,59928,59941);

f_25060_59928_59940(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,59955,59966);

f_25060_59955_59965(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,59982,60014);

f_25060_59982_60013(this, f_25060_59988_60004(operation), "Left");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,60028,60060);

f_25060_60028_60059(this, f_25060_60034_60049(operation), "Right");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,59087,60071);

int
f_25060_59196_59243(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 59196, 59243);
return 0;
}


Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
f_25060_59306_59328(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
this_param)
{
var return_v = this_param.OperatorKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 59306, 59328);
return return_v;
}


bool
f_25060_59349_59367(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
this_param)
{
var return_v = this_param.IsLifted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 59349, 59367);
return return_v;
}


bool
f_25060_59460_59479(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
this_param)
{
var return_v = this_param.IsChecked;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 59460, 59479);
return return_v;
}


int
f_25060_59567_59593(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 59567, 59593);
return 0;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_25060_59645_59669(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
this_param)
{
var return_v = this_param.OperatorMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 59645, 59669);
return return_v;
}


int
f_25060_59608_59670(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IMethodSymbol?
operatorMethodOpt)
{
this_param.LogHasOperatorMethodExpressionCommon( operatorMethodOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 59608, 59670);
return 0;
}


int
f_25060_59685_59725(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 59685, 59725);
return 0;
}


int
f_25060_59740_59748(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Indent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 59740, 59748);
return 0;
}


Microsoft.CodeAnalysis.Operations.CommonConversion
f_25060_59777_59799(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
this_param)
{
var return_v = this_param.InConversion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 59777, 59799);
return return_v;
}


int
f_25060_59763_59816(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.CommonConversion
conversion,string
header)
{
this_param.LogConversion( conversion, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 59763, 59816);
return 0;
}


int
f_25060_59831_59843(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 59831, 59843);
return 0;
}


Microsoft.CodeAnalysis.Operations.CommonConversion
f_25060_59872_59895(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
this_param)
{
var return_v = this_param.OutConversion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 59872, 59895);
return return_v;
}


int
f_25060_59858_59913(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.CommonConversion
conversion,string
header)
{
this_param.LogConversion( conversion, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 59858, 59913);
return 0;
}


int
f_25060_59928_59940(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 59928, 59940);
return 0;
}


int
f_25060_59955_59965(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Unindent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 59955, 59965);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_59988_60004(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 59988, 60004);
return return_v;
}


int
f_25060_59982_60013(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 59982, 60013);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_60034_60049(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 60034, 60049);
return return_v;
}


int
f_25060_60028_60059(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 60028, 60059);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,59087,60071);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,59087,60071);
}
		}

public override void VisitIncrementOrDecrement(IIncrementOrDecrementOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,60083,60775);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,60196,60246);

f_25060_60196_60245(this, nameof(IIncrementOrDecrementOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,60262,60319);

var 
kindStr = (DynAbs.Tracing.TraceSender.Conditional_F1(25060, 60276, 60295)||((f_25060_60276_60295(operation)&&DynAbs.Tracing.TraceSender.Conditional_F2(25060, 60298, 60307))||DynAbs.Tracing.TraceSender.Conditional_F3(25060, 60310, 60318)))?"Postfix" :"Prefix"
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,60333,60428) || true) && (f_25060_60337_60355(operation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,60333,60428);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,60389,60413);

kindStr += ", IsLifted";
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,60333,60428);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,60444,60539) || true) && (f_25060_60448_60467(operation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,60444,60539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,60501,60524);

kindStr += ", Checked";
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,60444,60539);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,60555,60582);

f_25060_60555_60581(this, $" ({kindStr})");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,60596,60659);

f_25060_60596_60658(this, f_25060_60633_60657(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,60673,60714);

f_25060_60673_60713(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,60730,60764);

f_25060_60730_60763(this, f_25060_60736_60752(operation), "Target");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,60083,60775);

int
f_25060_60196_60245(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 60196, 60245);
return 0;
}


bool
f_25060_60276_60295(Microsoft.CodeAnalysis.Operations.IIncrementOrDecrementOperation
this_param)
{
var return_v = this_param.IsPostfix ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 60276, 60295);
return return_v;
}


bool
f_25060_60337_60355(Microsoft.CodeAnalysis.Operations.IIncrementOrDecrementOperation
this_param)
{
var return_v = this_param.IsLifted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 60337, 60355);
return return_v;
}


bool
f_25060_60448_60467(Microsoft.CodeAnalysis.Operations.IIncrementOrDecrementOperation
this_param)
{
var return_v = this_param.IsChecked;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 60448, 60467);
return return_v;
}


int
f_25060_60555_60581(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 60555, 60581);
return 0;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_25060_60633_60657(Microsoft.CodeAnalysis.Operations.IIncrementOrDecrementOperation
this_param)
{
var return_v = this_param.OperatorMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 60633, 60657);
return return_v;
}


int
f_25060_60596_60658(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IMethodSymbol?
operatorMethodOpt)
{
this_param.LogHasOperatorMethodExpressionCommon( operatorMethodOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 60596, 60658);
return 0;
}


int
f_25060_60673_60713(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IIncrementOrDecrementOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 60673, 60713);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_60736_60752(Microsoft.CodeAnalysis.Operations.IIncrementOrDecrementOperation
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 60736, 60752);
return return_v;
}


int
f_25060_60730_60763(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 60730, 60763);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,60083,60775);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,60083,60775);
}
		}

public override void VisitParenthesized(IParenthesizedOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,60787,61047);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,60886,60929);

f_25060_60886_60928(this, nameof(IParenthesizedOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,60943,60984);

f_25060_60943_60983(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,61000,61036);

f_25060_61000_61035(this, f_25060_61006_61023(operation), "Operand");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,60787,61047);

int
f_25060_60886_60928(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 60886, 60928);
return 0;
}


int
f_25060_60943_60983(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IParenthesizedOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 60943, 60983);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_61006_61023(Microsoft.CodeAnalysis.Operations.IParenthesizedOperation
this_param)
{
var return_v = this_param.Operand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 61006, 61023);
return return_v;
}


int
f_25060_61000_61035(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 61000, 61035);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,60787,61047);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,60787,61047);
}
		}

public override void VisitDynamicMemberReference(IDynamicMemberReferenceOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,61059,61810);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,61176,61228);

f_25060_61176_61227(this, nameof(IDynamicMemberReferenceOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,61310,61326);

f_25060_61310_61325(this, " (");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,61340,61397);

f_25060_61340_61396(this, f_25060_61360_61380(operation), "Member Name");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,61411,61427);

f_25060_61411_61426(this, ", ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,61441,61494);

f_25060_61441_61493(this, f_25060_61449_61473(operation), "Containing Type");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,61508,61523);

f_25060_61508_61522(this, ")");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,61537,61578);

f_25060_61537_61577(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,61594,61749);

f_25060_61594_61748(this, f_25060_61611_61634(operation), "Type Arguments", logElementCount: true, logNullForDefault: false, arrayElementVisitor: VisitSymbolArrayElement);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,61765,61799);

f_25060_61765_61798(this, f_25060_61779_61797(operation));
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,61059,61810);

int
f_25060_61176_61227(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 61176, 61227);
return 0;
}


int
f_25060_61310_61325(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 61310, 61325);
return 0;
}


string
f_25060_61360_61380(Microsoft.CodeAnalysis.Operations.IDynamicMemberReferenceOperation
this_param)
{
var return_v = this_param.MemberName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 61360, 61380);
return return_v;
}


int
f_25060_61340_61396(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
constant,string
header)
{
this_param.LogConstant( (object)constant, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 61340, 61396);
return 0;
}


int
f_25060_61411_61426(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 61411, 61426);
return 0;
}


Microsoft.CodeAnalysis.ITypeSymbol?
f_25060_61449_61473(Microsoft.CodeAnalysis.Operations.IDynamicMemberReferenceOperation
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 61449, 61473);
return return_v;
}


int
f_25060_61441_61493(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.ITypeSymbol?
type,string
header)
{
this_param.LogType( type, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 61441, 61493);
return 0;
}


int
f_25060_61508_61522(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 61508, 61522);
return 0;
}


int
f_25060_61537_61577(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IDynamicMemberReferenceOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 61537, 61577);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
f_25060_61611_61634(Microsoft.CodeAnalysis.Operations.IDynamicMemberReferenceOperation
this_param)
{
var return_v = this_param.TypeArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 61611, 61634);
return return_v;
}


int
f_25060_61594_61748(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
list,string
header,bool
logElementCount,bool
logNullForDefault,System.Action<Microsoft.CodeAnalysis.ITypeSymbol>
arrayElementVisitor)
{
this_param.VisitArrayCommon<Microsoft.CodeAnalysis.ITypeSymbol>( list, header, logElementCount: logElementCount, logNullForDefault: logNullForDefault, arrayElementVisitor: arrayElementVisitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 61594, 61748);
return 0;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_61779_61797(Microsoft.CodeAnalysis.Operations.IDynamicMemberReferenceOperation
this_param)
{
var return_v = this_param.Instance;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 61779, 61797);
return return_v;
}


int
f_25060_61765_61798(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation?
instance)
{
this_param.VisitInstance( instance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 61765, 61798);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,61059,61810);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,61059,61810);
}
		}

public override void VisitDefaultValue(IDefaultValueOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,61822,62027);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,61919,61961);

f_25060_61919_61960(this, nameof(IDefaultValueOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,61975,62016);

f_25060_61975_62015(this, operation);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,61822,62027);

int
f_25060_61919_61960(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 61919, 61960);
return 0;
}


int
f_25060_61975_62015(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IDefaultValueOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 61975, 62015);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,61822,62027);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,61822,62027);
}
		}

public override void VisitTypeParameterObjectCreation(ITypeParameterObjectCreationOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,62039,62349);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,62166,62223);

f_25060_62166_62222(this, nameof(ITypeParameterObjectCreationOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,62237,62278);

f_25060_62237_62277(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,62294,62338);

f_25060_62294_62337(this, f_25060_62300_62321(operation), "Initializer");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,62039,62349);

int
f_25060_62166_62222(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 62166, 62222);
return 0;
}


int
f_25060_62237_62277(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.ITypeParameterObjectCreationOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 62237, 62277);
return 0;
}


Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation?
f_25060_62300_62321(Microsoft.CodeAnalysis.Operations.ITypeParameterObjectCreationOperation
this_param)
{
var return_v = this_param.Initializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 62300, 62321);
return return_v;
}


int
f_25060_62294_62337(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation?
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation?)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 62294, 62337);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,62039,62349);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,62039,62349);
}
		}

internal override void VisitNoPiaObjectCreation(INoPiaObjectCreationOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,62361,62649);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,62474,62523);

f_25060_62474_62522(this, nameof(INoPiaObjectCreationOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,62537,62578);

f_25060_62537_62577(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,62594,62638);

f_25060_62594_62637(this, f_25060_62600_62621(operation), "Initializer");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,62361,62649);

int
f_25060_62474_62522(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 62474, 62522);
return 0;
}


int
f_25060_62537_62577(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.INoPiaObjectCreationOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 62537, 62577);
return 0;
}


Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation?
f_25060_62600_62621(Microsoft.CodeAnalysis.Operations.INoPiaObjectCreationOperation
this_param)
{
var return_v = this_param.Initializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 62600, 62621);
return return_v;
}


int
f_25060_62594_62637(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation?
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation?)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 62594, 62637);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,62361,62649);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,62361,62649);
}
		}

public override void VisitInvalid(IInvalidOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,62661,62892);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,62748,62785);

f_25060_62748_62784(this, nameof(IInvalidOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,62799,62840);

f_25060_62799_62839(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,62856,62881);

f_25060_62856_62880(this, operation);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,62661,62892);

int
f_25060_62748_62784(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 62748, 62784);
return 0;
}


int
f_25060_62799_62839(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IInvalidOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 62799, 62839);
return 0;
}


int
f_25060_62856_62880(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IInvalidOperation
operation)
{
this_param.VisitChildren( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 62856, 62880);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,62661,62892);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,62661,62892);
}
		}

public override void VisitLocalFunction(ILocalFunctionOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,62904,63693);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,63003,63046);

f_25060_63003_63045(this, nameof(ILocalFunctionOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,63062,63110);

f_25060_63062_63109(this, f_25060_63072_63088(operation), header: " (Symbol");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,63124,63139);

f_25060_63124_63138(this, ")");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,63153,63194);

f_25060_63153_63193(this, operation);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,63210,63682) || true) && (f_25060_63214_63228(operation)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,63210,63682);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,63270,63566) || true) && (f_25060_63274_63295(operation)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,63270,63566);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,63345,63375);

f_25060_63345_63374(this, f_25060_63351_63365(operation), "Body");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,63397,63441);

f_25060_63397_63440(this, f_25060_63403_63424(operation), "IgnoredBody");
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,63270,63566);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,63270,63566);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,63525,63547);

f_25060_63525_63546(this, f_25060_63531_63545(operation));
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,63270,63566);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,63210,63682);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,63210,63682);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,63632,63667);

f_25060_63632_63666(f_25060_63644_63665(operation));
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,63210,63682);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,62904,63693);

int
f_25060_63003_63045(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 63003, 63045);
return 0;
}


Microsoft.CodeAnalysis.IMethodSymbol
f_25060_63072_63088(Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation
this_param)
{
var return_v = this_param.Symbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 63072, 63088);
return return_v;
}


int
f_25060_63062_63109(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IMethodSymbol
symbol,string
header)
{
this_param.LogSymbol( (Microsoft.CodeAnalysis.ISymbol)symbol, header: header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 63062, 63109);
return 0;
}


int
f_25060_63124_63138(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 63124, 63138);
return 0;
}


int
f_25060_63153_63193(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 63153, 63193);
return 0;
}


Microsoft.CodeAnalysis.Operations.IBlockOperation?
f_25060_63214_63228(Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation
this_param)
{
var return_v = this_param.Body ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 63214, 63228);
return return_v;
}


Microsoft.CodeAnalysis.Operations.IBlockOperation?
f_25060_63274_63295(Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation
this_param)
{
var return_v = this_param.IgnoredBody ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 63274, 63295);
return return_v;
}


Microsoft.CodeAnalysis.Operations.IBlockOperation
f_25060_63351_63365(Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 63351, 63365);
return return_v;
}


int
f_25060_63345_63374(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IBlockOperation
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 63345, 63374);
return 0;
}


Microsoft.CodeAnalysis.Operations.IBlockOperation
f_25060_63403_63424(Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation
this_param)
{
var return_v = this_param.IgnoredBody;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 63403, 63424);
return return_v;
}


int
f_25060_63397_63440(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IBlockOperation
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 63397, 63440);
return 0;
}


Microsoft.CodeAnalysis.Operations.IBlockOperation
f_25060_63531_63545(Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 63531, 63545);
return return_v;
}


int
f_25060_63525_63546(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IBlockOperation
operation)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 63525, 63546);
return 0;
}


Microsoft.CodeAnalysis.Operations.IBlockOperation?
f_25060_63644_63665(Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation
this_param)
{
var return_v = this_param.IgnoredBody;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 63644, 63665);
return return_v;
}


int
f_25060_63632_63666(Microsoft.CodeAnalysis.Operations.IBlockOperation?
@object)
{
Assert.Null( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 63632, 63666);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,62904,63693);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,62904,63693);
}
		}

private void LogCaseClauseCommon(ICaseClauseOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,63705,64178);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,63794,63849);

f_25060_63794_63848(OperationKind.CaseClause, f_25060_63833_63847(operation));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,63865,63998) || true) && (f_25060_63869_63884(operation)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,63865,63998);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,63926,63983);

f_25060_63926_63982(this, $" (Label Id: {f_25060_63951_63978(this, f_25060_63962_63977(operation))})");
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,63865,63998);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,64014,64071);

var 
kindStr = $"{nameof(CaseKind)}.{f_25060_64050_64068(operation)}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,64085,64112);

f_25060_64085_64111(this, $" ({kindStr})");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,64126,64167);

f_25060_64126_64166(this, operation);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,63705,64178);

Microsoft.CodeAnalysis.OperationKind
f_25060_63833_63847(Microsoft.CodeAnalysis.Operations.ICaseClauseOperation
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 63833, 63847);
return return_v;
}


int
f_25060_63794_63848(Microsoft.CodeAnalysis.OperationKind
expected,Microsoft.CodeAnalysis.OperationKind
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 63794, 63848);
return 0;
}


Microsoft.CodeAnalysis.ILabelSymbol?
f_25060_63869_63884(Microsoft.CodeAnalysis.Operations.ICaseClauseOperation
this_param)
{
var return_v = this_param.Label ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 63869, 63884);
return return_v;
}


Microsoft.CodeAnalysis.ILabelSymbol
f_25060_63962_63977(Microsoft.CodeAnalysis.Operations.ICaseClauseOperation
this_param)
{
var return_v = this_param.Label;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 63962, 63977);
return return_v;
}


uint
f_25060_63951_63978(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.ILabelSymbol
symbol)
{
var return_v = this_param.GetLabelId( symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 63951, 63978);
return return_v;
}


int
f_25060_63926_63982(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 63926, 63982);
return 0;
}


Microsoft.CodeAnalysis.Operations.CaseKind
f_25060_64050_64068(Microsoft.CodeAnalysis.Operations.ICaseClauseOperation
this_param)
{
var return_v = this_param.CaseKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 64050, 64068);
return return_v;
}


int
f_25060_64085_64111(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 64085, 64111);
return 0;
}


int
f_25060_64126_64166(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.ICaseClauseOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 64126, 64166);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,63705,64178);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,63705,64178);
}
		}

public override void VisitSingleValueCaseClause(ISingleValueCaseClauseOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,64190,64460);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,64305,64356);

f_25060_64305_64355(this, nameof(ISingleValueCaseClauseOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,64370,64401);

f_25060_64370_64400(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,64417,64449);

f_25060_64417_64448(this, f_25060_64423_64438(operation), "Value");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,64190,64460);

int
f_25060_64305_64355(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 64305, 64355);
return 0;
}


int
f_25060_64370_64400(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.ISingleValueCaseClauseOperation
operation)
{
this_param.LogCaseClauseCommon( (Microsoft.CodeAnalysis.Operations.ICaseClauseOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 64370, 64400);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_64423_64438(Microsoft.CodeAnalysis.Operations.ISingleValueCaseClauseOperation
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 64423, 64438);
return return_v;
}


int
f_25060_64417_64448(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 64417, 64448);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,64190,64460);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,64190,64460);
}
		}

public override void VisitRelationalCaseClause(IRelationalCaseClauseOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,64472,64887);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,64585,64635);

f_25060_64585_64634(this, nameof(IRelationalCaseClauseOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,64649,64716);

var 
kindStr = $"{nameof(BinaryOperatorKind)}.{f_25060_64695_64713(operation)}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,64730,64783);

f_25060_64730_64782(this, $" (Relational operator kind: {kindStr})");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,64797,64828);

f_25060_64797_64827(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,64844,64876);

f_25060_64844_64875(this, f_25060_64850_64865(operation), "Value");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,64472,64887);

int
f_25060_64585_64634(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 64585, 64634);
return 0;
}


Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
f_25060_64695_64713(Microsoft.CodeAnalysis.Operations.IRelationalCaseClauseOperation
this_param)
{
var return_v = this_param.Relation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 64695, 64713);
return return_v;
}


int
f_25060_64730_64782(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 64730, 64782);
return 0;
}


int
f_25060_64797_64827(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IRelationalCaseClauseOperation
operation)
{
this_param.LogCaseClauseCommon( (Microsoft.CodeAnalysis.Operations.ICaseClauseOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 64797, 64827);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_64850_64865(Microsoft.CodeAnalysis.Operations.IRelationalCaseClauseOperation
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 64850, 64865);
return return_v;
}


int
f_25060_64844_64875(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 64844, 64875);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,64472,64887);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,64472,64887);
}
		}

public override void VisitRangeCaseClause(IRangeCaseClauseOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,64899,65207);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,65002,65047);

f_25060_65002_65046(this, nameof(IRangeCaseClauseOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,65061,65092);

f_25060_65061_65091(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,65108,65145);

f_25060_65108_65144(this, f_25060_65114_65136(operation), "Min");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,65159,65196);

f_25060_65159_65195(this, f_25060_65165_65187(operation), "Max");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,64899,65207);

int
f_25060_65002_65046(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 65002, 65046);
return 0;
}


int
f_25060_65061_65091(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IRangeCaseClauseOperation
operation)
{
this_param.LogCaseClauseCommon( (Microsoft.CodeAnalysis.Operations.ICaseClauseOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 65061, 65091);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_65114_65136(Microsoft.CodeAnalysis.Operations.IRangeCaseClauseOperation
this_param)
{
var return_v = this_param.MinimumValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 65114, 65136);
return return_v;
}


int
f_25060_65108_65144(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 65108, 65144);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_65165_65187(Microsoft.CodeAnalysis.Operations.IRangeCaseClauseOperation
this_param)
{
var return_v = this_param.MaximumValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 65165, 65187);
return return_v;
}


int
f_25060_65159_65195(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 65159, 65195);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,64899,65207);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,64899,65207);
}
		}

public override void VisitDefaultCaseClause(IDefaultCaseClauseOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,65219,65429);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,65326,65373);

f_25060_65326_65372(this, nameof(IDefaultCaseClauseOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,65387,65418);

f_25060_65387_65417(this, operation);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,65219,65429);

int
f_25060_65326_65372(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 65326, 65372);
return 0;
}


int
f_25060_65387_65417(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IDefaultCaseClauseOperation
operation)
{
this_param.LogCaseClauseCommon( (Microsoft.CodeAnalysis.Operations.ICaseClauseOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 65387, 65417);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,65219,65429);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,65219,65429);
}
		}

public override void VisitTuple(ITupleOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,65441,65858);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,65524,65559);

f_25060_65524_65558(this, nameof(ITupleOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,65573,65614);

f_25060_65573_65613(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,65628,65637);

f_25060_65628_65636(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,65651,65713);

f_25060_65651_65712(this, f_25060_65659_65680(operation), nameof(operation.NaturalType));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,65727,65740);

f_25060_65727_65739(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,65754,65765);

f_25060_65754_65764(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,65781,65847);

f_25060_65781_65846(this, f_25060_65792_65810(operation), "Elements", logElementCount: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,65441,65858);

int
f_25060_65524_65558(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 65524, 65558);
return 0;
}


int
f_25060_65573_65613(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.ITupleOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 65573, 65613);
return 0;
}


int
f_25060_65628_65636(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Indent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 65628, 65636);
return 0;
}


Microsoft.CodeAnalysis.ITypeSymbol?
f_25060_65659_65680(Microsoft.CodeAnalysis.Operations.ITupleOperation
this_param)
{
var return_v = this_param.NaturalType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 65659, 65680);
return return_v;
}


int
f_25060_65651_65712(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.ITypeSymbol?
type,string
header)
{
this_param.LogType( type, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 65651, 65712);
return 0;
}


int
f_25060_65727_65739(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 65727, 65739);
return 0;
}


int
f_25060_65754_65764(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Unindent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 65754, 65764);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
f_25060_65792_65810(Microsoft.CodeAnalysis.Operations.ITupleOperation
this_param)
{
var return_v = this_param.Elements;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 65792, 65810);
return return_v;
}


int
f_25060_65781_65846(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
list,string
header,bool
logElementCount)
{
this_param.VisitArray<Microsoft.CodeAnalysis.IOperation>( list, header, logElementCount: logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 65781, 65846);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,65441,65858);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,65441,65858);
}
		}

public override void VisitInterpolatedString(IInterpolatedStringOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,65870,66169);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,65979,66027);

f_25060_65979_66026(this, nameof(IInterpolatedStringOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,66041,66082);

f_25060_66041_66081(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,66098,66158);

f_25060_66098_66157(this, f_25060_66109_66124(operation), "Parts", logElementCount: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,65870,66169);

int
f_25060_65979_66026(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 65979, 66026);
return 0;
}


int
f_25060_66041_66081(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IInterpolatedStringOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 66041, 66081);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IInterpolatedStringContentOperation>
f_25060_66109_66124(Microsoft.CodeAnalysis.Operations.IInterpolatedStringOperation
this_param)
{
var return_v = this_param.Parts;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 66109, 66124);
return return_v;
}


int
f_25060_66098_66157(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IInterpolatedStringContentOperation>
list,string
header,bool
logElementCount)
{
this_param.VisitArray<Microsoft.CodeAnalysis.Operations.IInterpolatedStringContentOperation>( list, header, logElementCount: logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 66098, 66157);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,65870,66169);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,65870,66169);
}
		}

public override void VisitInterpolatedStringText(IInterpolatedStringTextOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,66181,66533);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,66298,66350);

f_25060_66298_66349(this, nameof(IInterpolatedStringTextOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,66364,66405);

f_25060_66364_66404(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,66421,66478);

f_25060_66421_66477(OperationKind.Literal, f_25060_66457_66476(f_25060_66457_66471(operation)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,66492,66522);

f_25060_66492_66521(this, f_25060_66498_66512(operation), "Text");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,66181,66533);

int
f_25060_66298_66349(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 66298, 66349);
return 0;
}


int
f_25060_66364_66404(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IInterpolatedStringTextOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 66364, 66404);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_66457_66471(Microsoft.CodeAnalysis.Operations.IInterpolatedStringTextOperation
this_param)
{
var return_v = this_param.Text;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 66457, 66471);
return return_v;
}


Microsoft.CodeAnalysis.OperationKind
f_25060_66457_66476(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 66457, 66476);
return return_v;
}


int
f_25060_66421_66477(Microsoft.CodeAnalysis.OperationKind
expected,Microsoft.CodeAnalysis.OperationKind
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 66421, 66477);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_66498_66512(Microsoft.CodeAnalysis.Operations.IInterpolatedStringTextOperation
this_param)
{
var return_v = this_param.Text;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 66498, 66512);
return return_v;
}


int
f_25060_66492_66521(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 66492, 66521);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,66181,66533);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,66181,66533);
}
		}

public override void VisitInterpolation(IInterpolationOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,66545,67089);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,66644,66687);

f_25060_66644_66686(this, nameof(IInterpolationOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,66701,66742);

f_25060_66701_66741(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,66758,66800);

f_25060_66758_66799(this, f_25060_66764_66784(operation), "Expression");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,66814,66854);

f_25060_66814_66853(this, f_25060_66820_66839(operation), "Alignment");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,66868,66914);

f_25060_66868_66913(this, f_25060_66874_66896(operation), "FormatString");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,66930,67078) || true) && (f_25060_66934_66956(operation)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,66930,67078);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,66998,67063);

f_25060_66998_67062(OperationKind.Literal, f_25060_67034_67061(f_25060_67034_67056(operation)));
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,66930,67078);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,66545,67089);

int
f_25060_66644_66686(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 66644, 66686);
return 0;
}


int
f_25060_66701_66741(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IInterpolationOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 66701, 66741);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_66764_66784(Microsoft.CodeAnalysis.Operations.IInterpolationOperation
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 66764, 66784);
return return_v;
}


int
f_25060_66758_66799(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 66758, 66799);
return 0;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_66820_66839(Microsoft.CodeAnalysis.Operations.IInterpolationOperation
this_param)
{
var return_v = this_param.Alignment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 66820, 66839);
return return_v;
}


int
f_25060_66814_66853(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation?
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 66814, 66853);
return 0;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_66874_66896(Microsoft.CodeAnalysis.Operations.IInterpolationOperation
this_param)
{
var return_v = this_param.FormatString;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 66874, 66896);
return return_v;
}


int
f_25060_66868_66913(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation?
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 66868, 66913);
return 0;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_66934_66956(Microsoft.CodeAnalysis.Operations.IInterpolationOperation
this_param)
{
var return_v = this_param.FormatString ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 66934, 66956);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_25060_67034_67056(Microsoft.CodeAnalysis.Operations.IInterpolationOperation
this_param)
{
var return_v = this_param.FormatString;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 67034, 67056);
return return_v;
}


Microsoft.CodeAnalysis.OperationKind
f_25060_67034_67061(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 67034, 67061);
return return_v;
}


int
f_25060_66998_67062(Microsoft.CodeAnalysis.OperationKind
expected,Microsoft.CodeAnalysis.OperationKind
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 66998, 67062);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,66545,67089);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,66545,67089);
}
		}

public override void VisitConstantPattern(IConstantPatternOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,67101,67364);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,67204,67249);

f_25060_67204_67248(this, nameof(IConstantPatternOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,67263,67305);

f_25060_67263_67304(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,67321,67353);

f_25060_67321_67352(this, f_25060_67327_67342(operation), "Value");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,67101,67364);

int
f_25060_67204_67248(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 67204, 67248);
return 0;
}


int
f_25060_67263_67304(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IConstantPatternOperation
operation)
{
this_param.LogPatternPropertiesAndNewLine( (Microsoft.CodeAnalysis.Operations.IPatternOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 67263, 67304);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_67327_67342(Microsoft.CodeAnalysis.Operations.IConstantPatternOperation
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 67327, 67342);
return return_v;
}


int
f_25060_67321_67352(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 67321, 67352);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,67101,67364);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,67101,67364);
}
		}

public override void VisitRelationalPattern(IRelationalPatternOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,67376,67728);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,67483,67530);

f_25060_67483_67529(this, nameof(IRelationalPatternOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,67544,67615);

f_25060_67544_67614(this, $" ({nameof(BinaryOperatorKind)}.{f_25060_67588_67610(operation)})");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,67629,67671);

f_25060_67629_67670(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,67685,67717);

f_25060_67685_67716(this, f_25060_67691_67706(operation), "Value");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,67376,67728);

int
f_25060_67483_67529(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 67483, 67529);
return 0;
}


Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
f_25060_67588_67610(Microsoft.CodeAnalysis.Operations.IRelationalPatternOperation
this_param)
{
var return_v = this_param.OperatorKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 67588, 67610);
return return_v;
}


int
f_25060_67544_67614(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 67544, 67614);
return 0;
}


int
f_25060_67629_67670(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IRelationalPatternOperation
operation)
{
this_param.LogPatternPropertiesAndNewLine( (Microsoft.CodeAnalysis.Operations.IPatternOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 67629, 67670);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_67691_67706(Microsoft.CodeAnalysis.Operations.IRelationalPatternOperation
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 67691, 67706);
return return_v;
}


int
f_25060_67685_67716(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 67685, 67716);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,67376,67728);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,67376,67728);
}
		}

public override void VisitNegatedPattern(INegatedPatternOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,67740,68002);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,67841,67885);

f_25060_67841_67884(this, nameof(INegatedPatternOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,67899,67941);

f_25060_67899_67940(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,67955,67991);

f_25060_67955_67990(this, f_25060_67961_67978(operation), "Pattern");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,67740,68002);

int
f_25060_67841_67884(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 67841, 67884);
return 0;
}


int
f_25060_67899_67940(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.INegatedPatternOperation
operation)
{
this_param.LogPatternPropertiesAndNewLine( (Microsoft.CodeAnalysis.Operations.IPatternOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 67899, 67940);
return 0;
}


Microsoft.CodeAnalysis.Operations.IPatternOperation
f_25060_67961_67978(Microsoft.CodeAnalysis.Operations.INegatedPatternOperation
this_param)
{
var return_v = this_param.Pattern;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 67961, 67978);
return return_v;
}


int
f_25060_67955_67990(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IPatternOperation
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 67955, 67990);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,67740,68002);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,67740,68002);
}
		}

public override void VisitBinaryPattern(IBinaryPatternOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,68014,68426);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,68113,68156);

f_25060_68113_68155(this, nameof(IBinaryPatternOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,68170,68241);

f_25060_68170_68240(this, $" ({nameof(BinaryOperatorKind)}.{f_25060_68214_68236(operation)})");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,68255,68297);

f_25060_68255_68296(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,68311,68355);

f_25060_68311_68354(this, f_25060_68317_68338(operation), "LeftPattern");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,68369,68415);

f_25060_68369_68414(this, f_25060_68375_68397(operation), "RightPattern");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,68014,68426);

int
f_25060_68113_68155(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 68113, 68155);
return 0;
}


Microsoft.CodeAnalysis.Operations.BinaryOperatorKind
f_25060_68214_68236(Microsoft.CodeAnalysis.Operations.IBinaryPatternOperation
this_param)
{
var return_v = this_param.OperatorKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 68214, 68236);
return return_v;
}


int
f_25060_68170_68240(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 68170, 68240);
return 0;
}


int
f_25060_68255_68296(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IBinaryPatternOperation
operation)
{
this_param.LogPatternPropertiesAndNewLine( (Microsoft.CodeAnalysis.Operations.IPatternOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 68255, 68296);
return 0;
}


Microsoft.CodeAnalysis.Operations.IPatternOperation
f_25060_68317_68338(Microsoft.CodeAnalysis.Operations.IBinaryPatternOperation
this_param)
{
var return_v = this_param.LeftPattern;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 68317, 68338);
return return_v;
}


int
f_25060_68311_68354(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IPatternOperation
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 68311, 68354);
return 0;
}


Microsoft.CodeAnalysis.Operations.IPatternOperation
f_25060_68375_68397(Microsoft.CodeAnalysis.Operations.IBinaryPatternOperation
this_param)
{
var return_v = this_param.RightPattern;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 68375, 68397);
return return_v;
}


int
f_25060_68369_68414(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IPatternOperation
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 68369, 68414);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,68014,68426);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,68014,68426);
}
		}

public override void VisitTypePattern(ITypePatternOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,68438,68772);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,68533,68574);

f_25060_68533_68573(this, nameof(ITypePatternOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,68588,68620);

f_25060_68588_68619(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,68634,68705);

f_25060_68634_68704(this, f_25060_68644_68665(operation), $", {nameof(operation.MatchedType)}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,68719,68734);

f_25060_68719_68733(this, ")");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,68748,68761);

f_25060_68748_68760(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,68438,68772);

int
f_25060_68533_68573(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 68533, 68573);
return 0;
}


int
f_25060_68588_68619(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.ITypePatternOperation
operation)
{
this_param.LogPatternProperties( (Microsoft.CodeAnalysis.Operations.IPatternOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 68588, 68619);
return 0;
}


Microsoft.CodeAnalysis.ITypeSymbol
f_25060_68644_68665(Microsoft.CodeAnalysis.Operations.ITypePatternOperation
this_param)
{
var return_v = this_param.MatchedType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 68644, 68665);
return return_v;
}


int
f_25060_68634_68704(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.ITypeSymbol
symbol,string
header)
{
this_param.LogSymbol( (Microsoft.CodeAnalysis.ISymbol)symbol, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 68634, 68704);
return 0;
}


int
f_25060_68719_68733(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 68719, 68733);
return 0;
}


int
f_25060_68748_68760(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 68748, 68760);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,68438,68772);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,68438,68772);
}
		}

public override void VisitDeclarationPattern(IDeclarationPatternOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,68784,69240);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,68893,68941);

f_25060_68893_68940(this, nameof(IDeclarationPatternOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,68955,68987);

f_25060_68955_68986(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,69001,69078);

f_25060_69001_69077(this, f_25060_69011_69035(operation), $", {nameof(operation.DeclaredSymbol)}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,69092,69173);

f_25060_69092_69172(this, f_25060_69112_69133(operation), $", {nameof(operation.MatchesNull)}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,69187,69202);

f_25060_69187_69201(this, ")");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,69216,69229);

f_25060_69216_69228(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,68784,69240);

int
f_25060_68893_68940(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 68893, 68940);
return 0;
}


int
f_25060_68955_68986(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IDeclarationPatternOperation
operation)
{
this_param.LogPatternProperties( (Microsoft.CodeAnalysis.Operations.IPatternOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 68955, 68986);
return 0;
}


Microsoft.CodeAnalysis.ISymbol?
f_25060_69011_69035(Microsoft.CodeAnalysis.Operations.IDeclarationPatternOperation
this_param)
{
var return_v = this_param.DeclaredSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 69011, 69035);
return return_v;
}


int
f_25060_69001_69077(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.ISymbol?
symbol,string
header)
{
this_param.LogSymbol( symbol, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 69001, 69077);
return 0;
}


bool
f_25060_69112_69133(Microsoft.CodeAnalysis.Operations.IDeclarationPatternOperation
this_param)
{
var return_v = this_param.MatchesNull;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 69112, 69133);
return return_v;
}


int
f_25060_69092_69172(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,bool
constant,string
header)
{
this_param.LogConstant( (object)constant, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 69092, 69172);
return 0;
}


int
f_25060_69187_69201(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 69187, 69201);
return 0;
}


int
f_25060_69216_69228(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 69216, 69228);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,68784,69240);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,68784,69240);
}
		}

public override void VisitRecursivePattern(IRecursivePatternOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,69252,70027);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,69357,69403);

f_25060_69357_69402(this, nameof(IRecursivePatternOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,69417,69449);

f_25060_69417_69448(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,69463,69540);

f_25060_69463_69539(this, f_25060_69473_69497(operation), $", {nameof(operation.DeclaredSymbol)}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,69554,69623);

f_25060_69554_69622(this, f_25060_69562_69583(operation), $", {nameof(operation.MatchedType)}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,69637,69720);

f_25060_69637_69719(this, f_25060_69647_69674(operation), $", {nameof(operation.DeconstructSymbol)}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,69734,69749);

f_25060_69734_69748(this, ")");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,69763,69776);

f_25060_69763_69775(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,69792,69903);

f_25060_69792_69902(this, f_25060_69803_69838(operation), $"{nameof(operation.DeconstructionSubpatterns)} ", true, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,69917,70016);

f_25060_69917_70015(this, f_25060_69928_69957(operation), $"{nameof(operation.PropertySubpatterns)} ", true, true);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,69252,70027);

int
f_25060_69357_69402(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 69357, 69402);
return 0;
}


int
f_25060_69417_69448(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IRecursivePatternOperation
operation)
{
this_param.LogPatternProperties( (Microsoft.CodeAnalysis.Operations.IPatternOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 69417, 69448);
return 0;
}


Microsoft.CodeAnalysis.ISymbol?
f_25060_69473_69497(Microsoft.CodeAnalysis.Operations.IRecursivePatternOperation
this_param)
{
var return_v = this_param.DeclaredSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 69473, 69497);
return return_v;
}


int
f_25060_69463_69539(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.ISymbol?
symbol,string
header)
{
this_param.LogSymbol( symbol, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 69463, 69539);
return 0;
}


Microsoft.CodeAnalysis.ITypeSymbol
f_25060_69562_69583(Microsoft.CodeAnalysis.Operations.IRecursivePatternOperation
this_param)
{
var return_v = this_param.MatchedType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 69562, 69583);
return return_v;
}


int
f_25060_69554_69622(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.ITypeSymbol
type,string
header)
{
this_param.LogType( type, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 69554, 69622);
return 0;
}


Microsoft.CodeAnalysis.ISymbol?
f_25060_69647_69674(Microsoft.CodeAnalysis.Operations.IRecursivePatternOperation
this_param)
{
var return_v = this_param.DeconstructSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 69647, 69674);
return return_v;
}


int
f_25060_69637_69719(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.ISymbol?
symbol,string
header)
{
this_param.LogSymbol( symbol, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 69637, 69719);
return 0;
}


int
f_25060_69734_69748(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 69734, 69748);
return 0;
}


int
f_25060_69763_69775(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 69763, 69775);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IPatternOperation>
f_25060_69803_69838(Microsoft.CodeAnalysis.Operations.IRecursivePatternOperation
this_param)
{
var return_v = this_param.DeconstructionSubpatterns;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 69803, 69838);
return return_v;
}


int
f_25060_69792_69902(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IPatternOperation>
list,string
header,bool
logElementCount,bool
logNullForDefault)
{
this_param.VisitArray<Microsoft.CodeAnalysis.Operations.IPatternOperation>( list, header, logElementCount, logNullForDefault);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 69792, 69902);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IPropertySubpatternOperation>
f_25060_69928_69957(Microsoft.CodeAnalysis.Operations.IRecursivePatternOperation
this_param)
{
var return_v = this_param.PropertySubpatterns;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 69928, 69957);
return return_v;
}


int
f_25060_69917_70015(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IPropertySubpatternOperation>
list,string
header,bool
logElementCount,bool
logNullForDefault)
{
this_param.VisitArray<Microsoft.CodeAnalysis.Operations.IPropertySubpatternOperation>( list, header, logElementCount, logNullForDefault);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 69917, 70015);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,69252,70027);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,69252,70027);
}
		}

public override void VisitPropertySubpattern(IPropertySubpatternOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,70039,70421);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,70148,70196);

f_25060_70148_70195(this, nameof(IPropertySubpatternOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,70210,70241);

f_25060_70210_70240(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,70255,70268);

f_25060_70255_70267(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,70284,70339);

f_25060_70284_70338(this, f_25060_70290_70306(operation), $"{nameof(operation.Member)}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,70353,70410);

f_25060_70353_70409(this, f_25060_70359_70376(operation), $"{nameof(operation.Pattern)}");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,70039,70421);

int
f_25060_70148_70195(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 70148, 70195);
return 0;
}


int
f_25060_70210_70240(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IPropertySubpatternOperation
operation)
{
this_param.LogCommonProperties( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 70210, 70240);
return 0;
}


int
f_25060_70255_70267(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 70255, 70267);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_70290_70306(Microsoft.CodeAnalysis.Operations.IPropertySubpatternOperation
this_param)
{
var return_v = this_param.Member;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 70290, 70306);
return return_v;
}


int
f_25060_70284_70338(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 70284, 70338);
return 0;
}


Microsoft.CodeAnalysis.Operations.IPatternOperation
f_25060_70359_70376(Microsoft.CodeAnalysis.Operations.IPropertySubpatternOperation
this_param)
{
var return_v = this_param.Pattern;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 70359, 70376);
return return_v;
}


int
f_25060_70353_70409(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IPatternOperation
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 70353, 70409);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,70039,70421);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,70039,70421);
}
		}

public override void VisitIsPattern(IIsPatternOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,70433,70748);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,70524,70563);

f_25060_70524_70562(this, nameof(IIsPatternOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,70577,70618);

f_25060_70577_70617(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,70634,70687);

f_25060_70634_70686(this, f_25060_70640_70655(operation), $"{nameof(operation.Value)}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,70701,70737);

f_25060_70701_70736(this, f_25060_70707_70724(operation), "Pattern");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,70433,70748);

int
f_25060_70524_70562(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 70524, 70562);
return 0;
}


int
f_25060_70577_70617(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IIsPatternOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 70577, 70617);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_70640_70655(Microsoft.CodeAnalysis.Operations.IIsPatternOperation
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 70640, 70655);
return return_v;
}


int
f_25060_70634_70686(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 70634, 70686);
return 0;
}


Microsoft.CodeAnalysis.Operations.IPatternOperation
f_25060_70707_70724(Microsoft.CodeAnalysis.Operations.IIsPatternOperation
this_param)
{
var return_v = this_param.Pattern;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 70707, 70724);
return return_v;
}


int
f_25060_70701_70736(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IPatternOperation
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 70701, 70736);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,70433,70748);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,70433,70748);
}
		}

public override void VisitPatternCaseClause(IPatternCaseClauseOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,70760,71214);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,70867,70914);

f_25060_70867_70913(this, nameof(IPatternCaseClauseOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,70928,70959);

f_25060_70928_70958(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,70973,71043);

f_25060_70973_71042(f_25060_70985_71024(((ICaseClauseOperation)operation)), f_25060_71026_71041(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,71059,71095);

f_25060_71059_71094(this, f_25060_71065_71082(operation), "Pattern");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,71109,71203) || true) && (f_25060_71113_71128(operation)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,71109,71203);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,71155,71203);

f_25060_71155_71202(this, f_25060_71161_71176(operation), nameof(operation.Guard));
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,71109,71203);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,70760,71214);

int
f_25060_70867_70913(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 70867, 70913);
return 0;
}


int
f_25060_70928_70958(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IPatternCaseClauseOperation
operation)
{
this_param.LogCaseClauseCommon( (Microsoft.CodeAnalysis.Operations.ICaseClauseOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 70928, 70958);
return 0;
}


Microsoft.CodeAnalysis.ILabelSymbol?
f_25060_70985_71024(Microsoft.CodeAnalysis.Operations.ICaseClauseOperation
this_param)
{
var return_v = this_param.Label;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 70985, 71024);
return return_v;
}


Microsoft.CodeAnalysis.ILabelSymbol
f_25060_71026_71041(Microsoft.CodeAnalysis.Operations.IPatternCaseClauseOperation
this_param)
{
var return_v = this_param.Label;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 71026, 71041);
return return_v;
}


int
f_25060_70973_71042(Microsoft.CodeAnalysis.ILabelSymbol?
expected,Microsoft.CodeAnalysis.ILabelSymbol
actual)
{
Assert.Same( (object?)expected, (object)actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 70973, 71042);
return 0;
}


Microsoft.CodeAnalysis.Operations.IPatternOperation
f_25060_71065_71082(Microsoft.CodeAnalysis.Operations.IPatternCaseClauseOperation
this_param)
{
var return_v = this_param.Pattern;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 71065, 71082);
return return_v;
}


int
f_25060_71059_71094(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IPatternOperation
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 71059, 71094);
return 0;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_71113_71128(Microsoft.CodeAnalysis.Operations.IPatternCaseClauseOperation
this_param)
{
var return_v = this_param.Guard ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 71113, 71128);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_25060_71161_71176(Microsoft.CodeAnalysis.Operations.IPatternCaseClauseOperation
this_param)
{
var return_v = this_param.Guard;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 71161, 71176);
return return_v;
}


int
f_25060_71155_71202(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 71155, 71202);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,70760,71214);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,70760,71214);
}
		}

public override void VisitTranslatedQuery(ITranslatedQueryOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,71226,71497);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,71329,71374);

f_25060_71329_71373(this, nameof(ITranslatedQueryOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,71388,71429);

f_25060_71388_71428(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,71445,71486);

f_25060_71445_71485(this, f_25060_71451_71470(operation), "Expression");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,71226,71497);

int
f_25060_71329_71373(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 71329, 71373);
return 0;
}


int
f_25060_71388_71428(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.ITranslatedQueryOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 71388, 71428);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_71451_71470(Microsoft.CodeAnalysis.Operations.ITranslatedQueryOperation
this_param)
{
var return_v = this_param.Operation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 71451, 71470);
return return_v;
}


int
f_25060_71445_71485(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 71445, 71485);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,71226,71497);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,71226,71497);
}
		}

public override void VisitRaiseEvent(IRaiseEventOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,71509,71833);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,71602,71642);

f_25060_71602_71641(this, nameof(IRaiseEventOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,71656,71697);

f_25060_71656_71696(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,71713,71772);

f_25060_71713_71771(this, f_25060_71719_71743(operation), header: "Event Reference");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,71786,71822);

f_25060_71786_71821(this, f_25060_71801_71820(operation));
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,71509,71833);

int
f_25060_71602_71641(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 71602, 71641);
return 0;
}


int
f_25060_71656_71696(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IRaiseEventOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 71656, 71696);
return 0;
}


Microsoft.CodeAnalysis.Operations.IEventReferenceOperation
f_25060_71719_71743(Microsoft.CodeAnalysis.Operations.IRaiseEventOperation
this_param)
{
var return_v = this_param.EventReference;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 71719, 71743);
return return_v;
}


int
f_25060_71713_71771(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IEventReferenceOperation
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation)operation, header: header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 71713, 71771);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
f_25060_71801_71820(Microsoft.CodeAnalysis.Operations.IRaiseEventOperation
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 71801, 71820);
return return_v;
}


int
f_25060_71786_71821(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
arguments)
{
this_param.VisitArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 71786, 71821);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,71509,71833);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,71509,71833);
}
		}

public override void VisitConstructorBodyOperation(IConstructorBodyOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,71845,72288);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,71957,72002);

f_25060_71957_72001(this, nameof(IConstructorBodyOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,72016,72057);

f_25060_72016_72056(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,72073,72101);

f_25060_72073_72100(this, f_25060_72083_72099(operation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,72115,72159);

f_25060_72115_72158(this, f_25060_72121_72142(operation), "Initializer");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,72173,72213);

f_25060_72173_72212(this, f_25060_72179_72198(operation), "BlockBody");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,72227,72277);

f_25060_72227_72276(this, f_25060_72233_72257(operation), "ExpressionBody");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,71845,72288);

int
f_25060_71957_72001(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 71957, 72001);
return 0;
}


int
f_25060_72016_72056(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IConstructorBodyOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 72016, 72056);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
f_25060_72083_72099(Microsoft.CodeAnalysis.Operations.IConstructorBodyOperation
this_param)
{
var return_v = this_param.Locals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 72083, 72099);
return return_v;
}


int
f_25060_72073_72100(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
locals)
{
this_param.LogLocals( (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ILocalSymbol>)locals);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 72073, 72100);
return 0;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_72121_72142(Microsoft.CodeAnalysis.Operations.IConstructorBodyOperation
this_param)
{
var return_v = this_param.Initializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 72121, 72142);
return return_v;
}


int
f_25060_72115_72158(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation?
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 72115, 72158);
return 0;
}


Microsoft.CodeAnalysis.Operations.IBlockOperation?
f_25060_72179_72198(Microsoft.CodeAnalysis.Operations.IConstructorBodyOperation
this_param)
{
var return_v = this_param.BlockBody;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 72179, 72198);
return return_v;
}


int
f_25060_72173_72212(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IBlockOperation?
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation?)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 72173, 72212);
return 0;
}


Microsoft.CodeAnalysis.Operations.IBlockOperation?
f_25060_72233_72257(Microsoft.CodeAnalysis.Operations.IConstructorBodyOperation
this_param)
{
var return_v = this_param.ExpressionBody;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 72233, 72257);
return return_v;
}


int
f_25060_72227_72276(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IBlockOperation?
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation?)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 72227, 72276);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,71845,72288);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,71845,72288);
}
		}

public override void VisitMethodBodyOperation(IMethodBodyOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,72300,72626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,72402,72442);

f_25060_72402_72441(this, nameof(IMethodBodyOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,72456,72497);

f_25060_72456_72496(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,72511,72551);

f_25060_72511_72550(this, f_25060_72517_72536(operation), "BlockBody");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,72565,72615);

f_25060_72565_72614(this, f_25060_72571_72595(operation), "ExpressionBody");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,72300,72626);

int
f_25060_72402_72441(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 72402, 72441);
return 0;
}


int
f_25060_72456_72496(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IMethodBodyOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 72456, 72496);
return 0;
}


Microsoft.CodeAnalysis.Operations.IBlockOperation?
f_25060_72517_72536(Microsoft.CodeAnalysis.Operations.IMethodBodyOperation
this_param)
{
var return_v = this_param.BlockBody;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 72517, 72536);
return return_v;
}


int
f_25060_72511_72550(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IBlockOperation?
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation?)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 72511, 72550);
return 0;
}


Microsoft.CodeAnalysis.Operations.IBlockOperation?
f_25060_72571_72595(Microsoft.CodeAnalysis.Operations.IMethodBodyOperation
this_param)
{
var return_v = this_param.ExpressionBody;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 72571, 72595);
return return_v;
}


int
f_25060_72565_72614(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IBlockOperation?
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation?)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 72565, 72614);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,72300,72626);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,72300,72626);
}
		}

public override void VisitDiscardOperation(IDiscardOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,72638,72955);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,72734,72771);

f_25060_72734_72770(this, nameof(IDiscardOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,72785,72801);

f_25060_72785_72800(this, " (");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,72815,72860);

f_25060_72815_72859(this, f_25060_72825_72848(operation), "Symbol");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,72874,72889);

f_25060_72874_72888(this, ")");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,72903,72944);

f_25060_72903_72943(this, operation);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,72638,72955);

int
f_25060_72734_72770(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 72734, 72770);
return 0;
}


int
f_25060_72785_72800(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 72785, 72800);
return 0;
}


Microsoft.CodeAnalysis.IDiscardSymbol
f_25060_72825_72848(Microsoft.CodeAnalysis.Operations.IDiscardOperation
this_param)
{
var return_v = this_param.DiscardSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 72825, 72848);
return return_v;
}


int
f_25060_72815_72859(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IDiscardSymbol
symbol,string
header)
{
this_param.LogSymbol( (Microsoft.CodeAnalysis.ISymbol)symbol, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 72815, 72859);
return 0;
}


int
f_25060_72874_72888(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 72874, 72888);
return 0;
}


int
f_25060_72903_72943(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IDiscardOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 72903, 72943);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,72638,72955);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,72638,72955);
}
		}

public override void VisitDiscardPattern(IDiscardPatternOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,72967,73179);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,73068,73112);

f_25060_73068_73111(this, nameof(IDiscardPatternOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,73126,73168);

f_25060_73126_73167(this, operation);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,72967,73179);

int
f_25060_73068_73111(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 73068, 73111);
return 0;
}


int
f_25060_73126_73167(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IDiscardPatternOperation
operation)
{
this_param.LogPatternPropertiesAndNewLine( (Microsoft.CodeAnalysis.Operations.IPatternOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 73126, 73167);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,72967,73179);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,72967,73179);
}
		}

public override void VisitSwitchExpression(ISwitchExpressionOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,73191,73594);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,73296,73378);

f_25060_73296_73377(this, $"{nameof(ISwitchExpressionOperation)} ({operation.Arms.Length} arms)");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,73392,73433);

f_25060_73392_73432(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,73447,73495);

f_25060_73447_73494(this, f_25060_73453_73468(operation), nameof(operation.Value));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,73509,73583);

f_25060_73509_73582(this, f_25060_73520_73534(operation), nameof(operation.Arms), logElementCount: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,73191,73594);

int
f_25060_73296_73377(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 73296, 73377);
return 0;
}


int
f_25060_73392_73432(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.ISwitchExpressionOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 73392, 73432);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_73453_73468(Microsoft.CodeAnalysis.Operations.ISwitchExpressionOperation
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 73453, 73468);
return return_v;
}


int
f_25060_73447_73494(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 73447, 73494);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.ISwitchExpressionArmOperation>
f_25060_73520_73534(Microsoft.CodeAnalysis.Operations.ISwitchExpressionOperation
this_param)
{
var return_v = this_param.Arms;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 73520, 73534);
return return_v;
}


int
f_25060_73509_73582(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.ISwitchExpressionArmOperation>
list,string
header,bool
logElementCount)
{
this_param.VisitArray<Microsoft.CodeAnalysis.Operations.ISwitchExpressionArmOperation>( list, header, logElementCount: logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 73509, 73582);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,73191,73594);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,73191,73594);
}
		}

public override void VisitSwitchExpressionArm(ISwitchExpressionArmOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,73606,74150);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,73717,73806);

f_25060_73717_73805(this, $"{nameof(ISwitchExpressionArmOperation)} ({operation.Locals.Length} locals)");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,73820,73861);

f_25060_73820_73860(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,73875,73927);

f_25060_73875_73926(this, f_25060_73881_73898(operation), nameof(operation.Pattern));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,73941,74035) || true) && (f_25060_73945_73960(operation)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,73941,74035);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,73987,74035);

f_25060_73987_74034(this, f_25060_73993_74008(operation), nameof(operation.Guard));
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,73941,74035);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,74049,74097);

f_25060_74049_74096(this, f_25060_74055_74070(operation), nameof(operation.Value));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,74111,74139);

f_25060_74111_74138(this, f_25060_74121_74137(operation));
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,73606,74150);

int
f_25060_73717_73805(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 73717, 73805);
return 0;
}


int
f_25060_73820_73860(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.ISwitchExpressionArmOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 73820, 73860);
return 0;
}


Microsoft.CodeAnalysis.Operations.IPatternOperation
f_25060_73881_73898(Microsoft.CodeAnalysis.Operations.ISwitchExpressionArmOperation
this_param)
{
var return_v = this_param.Pattern;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 73881, 73898);
return return_v;
}


int
f_25060_73875_73926(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IPatternOperation
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 73875, 73926);
return 0;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_73945_73960(Microsoft.CodeAnalysis.Operations.ISwitchExpressionArmOperation
this_param)
{
var return_v = this_param.Guard ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 73945, 73960);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_25060_73993_74008(Microsoft.CodeAnalysis.Operations.ISwitchExpressionArmOperation
this_param)
{
var return_v = this_param.Guard;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 73993, 74008);
return return_v;
}


int
f_25060_73987_74034(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 73987, 74034);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_74055_74070(Microsoft.CodeAnalysis.Operations.ISwitchExpressionArmOperation
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 74055, 74070);
return return_v;
}


int
f_25060_74049_74096(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 74049, 74096);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
f_25060_74121_74137(Microsoft.CodeAnalysis.Operations.ISwitchExpressionArmOperation
this_param)
{
var return_v = this_param.Locals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 74121, 74137);
return return_v;
}


int
f_25060_74111_74138(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>
locals)
{
this_param.LogLocals( (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ILocalSymbol>)locals);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 74111, 74138);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,73606,74150);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,73606,74150);
}
		}

public override void VisitStaticLocalInitializationSemaphore(IStaticLocalInitializationSemaphoreOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,74162,74521);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,74303,74367);

f_25060_74303_74366(this, nameof(IStaticLocalInitializationSemaphoreOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,74381,74426);

f_25060_74381_74425(this, f_25060_74391_74406(operation), " (Local Symbol");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,74440,74455);

f_25060_74440_74454(this, ")");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,74469,74510);

f_25060_74469_74509(this, operation);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,74162,74521);

int
f_25060_74303_74366(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 74303, 74366);
return 0;
}


Microsoft.CodeAnalysis.ILocalSymbol
f_25060_74391_74406(Microsoft.CodeAnalysis.FlowAnalysis.IStaticLocalInitializationSemaphoreOperation
this_param)
{
var return_v = this_param.Local;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 74391, 74406);
return return_v;
}


int
f_25060_74381_74425(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.ILocalSymbol
symbol,string
header)
{
this_param.LogSymbol( (Microsoft.CodeAnalysis.ISymbol)symbol, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 74381, 74425);
return 0;
}


int
f_25060_74440_74454(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 74440, 74454);
return 0;
}


int
f_25060_74469_74509(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.FlowAnalysis.IStaticLocalInitializationSemaphoreOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 74469, 74509);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,74162,74521);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,74162,74521);
}
		}

public override void VisitRangeOperation(IRangeOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,74533,74992);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,74625,74660);

f_25060_74625_74659(this, nameof(IRangeOperation));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,74676,74772) || true) && (f_25060_74680_74698(operation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,74676,74772);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,74732,74757);

f_25060_74732_74756(this, " (IsLifted)");
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,74676,74772);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,74788,74829);

f_25060_74788_74828(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,74845,74905);

f_25060_74845_74904(this, f_25060_74851_74872(operation), nameof(operation.LeftOperand));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,74919,74981);

f_25060_74919_74980(this, f_25060_74925_74947(operation), nameof(operation.RightOperand));
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,74533,74992);

int
f_25060_74625_74659(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 74625, 74659);
return 0;
}


bool
f_25060_74680_74698(Microsoft.CodeAnalysis.Operations.IRangeOperation
this_param)
{
var return_v = this_param.IsLifted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 74680, 74698);
return return_v;
}


int
f_25060_74732_74756(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 74732, 74756);
return 0;
}


int
f_25060_74788_74828(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IRangeOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 74788, 74828);
return 0;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_74851_74872(Microsoft.CodeAnalysis.Operations.IRangeOperation
this_param)
{
var return_v = this_param.LeftOperand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 74851, 74872);
return return_v;
}


int
f_25060_74845_74904(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation?
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 74845, 74904);
return 0;
}


Microsoft.CodeAnalysis.IOperation?
f_25060_74925_74947(Microsoft.CodeAnalysis.Operations.IRangeOperation
this_param)
{
var return_v = this_param.RightOperand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 74925, 74947);
return return_v;
}


int
f_25060_74919_74980(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation?
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 74919, 74980);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,74533,74992);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,74533,74992);
}
		}

public override void VisitReDim(IReDimOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,75004,75376);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,75087,75122);

f_25060_75087_75121(this, nameof(IReDimOperation));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,75136,75232) || true) && (f_25060_75140_75158(operation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25060,75136,75232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,75192,75217);

f_25060_75192_75216(this, " (Preserve)");
DynAbs.Tracing.TraceSender.TraceExitCondition(25060,75136,75232);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,75246,75287);

f_25060_75246_75286(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,75301,75365);

f_25060_75301_75364(this, f_25060_75312_75329(operation), "Clauses", logElementCount: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,75004,75376);

int
f_25060_75087_75121(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 75087, 75121);
return 0;
}


bool
f_25060_75140_75158(Microsoft.CodeAnalysis.Operations.IReDimOperation
this_param)
{
var return_v = this_param.Preserve;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 75140, 75158);
return return_v;
}


int
f_25060_75192_75216(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 75192, 75216);
return 0;
}


int
f_25060_75246_75286(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IReDimOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 75246, 75286);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IReDimClauseOperation>
f_25060_75312_75329(Microsoft.CodeAnalysis.Operations.IReDimOperation
this_param)
{
var return_v = this_param.Clauses;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 75312, 75329);
return return_v;
}


int
f_25060_75301_75364(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IReDimClauseOperation>
list,string
header,bool
logElementCount)
{
this_param.VisitArray<Microsoft.CodeAnalysis.Operations.IReDimClauseOperation>( list, header, logElementCount: logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 75301, 75364);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,75004,75376);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,75004,75376);
}
		}

public override void VisitReDimClause(IReDimClauseOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,75388,75732);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,75483,75524);

f_25060_75483_75523(this, nameof(IReDimClauseOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,75538,75579);

f_25060_75538_75578(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,75593,75629);

f_25060_75593_75628(this, f_25060_75599_75616(operation), "Operand");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,75643,75721);

f_25060_75643_75720(this, f_25060_75654_75678(operation), "DimensionSizes", logElementCount: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,75388,75732);

int
f_25060_75483_75523(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 75483, 75523);
return 0;
}


int
f_25060_75538_75578(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IReDimClauseOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 75538, 75578);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_75599_75616(Microsoft.CodeAnalysis.Operations.IReDimClauseOperation
this_param)
{
var return_v = this_param.Operand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 75599, 75616);
return return_v;
}


int
f_25060_75593_75628(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 75593, 75628);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
f_25060_75654_75678(Microsoft.CodeAnalysis.Operations.IReDimClauseOperation
this_param)
{
var return_v = this_param.DimensionSizes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 75654, 75678);
return return_v;
}


int
f_25060_75643_75720(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
list,string
header,bool
logElementCount)
{
this_param.VisitArray<Microsoft.CodeAnalysis.IOperation>( list, header, logElementCount: logElementCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 75643, 75720);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,75388,75732);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,75388,75732);
}
		}

public override void VisitWith(IWithOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25060,75744,76186);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,75825,75859);

f_25060_75825_75858(this, nameof(IWithOperation));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,75873,75914);

f_25060_75873_75913(this, operation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,75928,75964);

f_25060_75928_75963(this, f_25060_75934_75951(operation), "Operand");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,75978,75987);

f_25060_75978_75986(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,76001,76065);

f_25060_76001_76064(this, f_25060_76011_76032(operation), nameof(operation.CloneMethod));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,76079,76092);

f_25060_76079_76091(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,76106,76117);

f_25060_76106_76116(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,76131,76175);

f_25060_76131_76174(this, f_25060_76137_76158(operation), "Initializer");
DynAbs.Tracing.TraceSender.TraceExitMethod(25060,75744,76186);

int
f_25060_75825_75858(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,string
str)
{
this_param.LogString( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 75825, 75858);
return 0;
}


int
f_25060_75873_75913(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IWithOperation
operation)
{
this_param.LogCommonPropertiesAndNewLine( (Microsoft.CodeAnalysis.IOperation)operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 75873, 75913);
return 0;
}


Microsoft.CodeAnalysis.IOperation
f_25060_75934_75951(Microsoft.CodeAnalysis.Operations.IWithOperation
this_param)
{
var return_v = this_param.Operand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 75934, 75951);
return return_v;
}


int
f_25060_75928_75963(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation,string
header)
{
this_param.Visit( operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 75928, 75963);
return 0;
}


int
f_25060_75978_75986(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Indent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 75978, 75986);
return 0;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_25060_76011_76032(Microsoft.CodeAnalysis.Operations.IWithOperation
this_param)
{
var return_v = this_param.CloneMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 76011, 76032);
return return_v;
}


int
f_25060_76001_76064(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.IMethodSymbol?
symbol,string
header)
{
this_param.LogSymbol( (Microsoft.CodeAnalysis.ISymbol?)symbol, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 76001, 76064);
return 0;
}


int
f_25060_76079_76091(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.LogNewLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 76079, 76091);
return 0;
}


int
f_25060_76106_76116(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param)
{
this_param.Unindent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 76106, 76116);
return 0;
}


Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation
f_25060_76137_76158(Microsoft.CodeAnalysis.Operations.IWithOperation
this_param)
{
var return_v = this_param.Initializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25060, 76137, 76158);
return return_v;
}


int
f_25060_76131_76174(Microsoft.CodeAnalysis.Test.Utilities.OperationTreeVerifier
this_param,Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation
operation,string
header)
{
this_param.Visit( (Microsoft.CodeAnalysis.IOperation)operation, header);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 76131, 76174);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25060,75744,76186);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,75744,76186);
}
		}

static OperationTreeVerifier()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25060,664,76215);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25060,1057,1070);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25060,664,76215);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25060,664,76215);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25060,664,76215);

static System.Text.StringBuilder
f_25060_1399_1418()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 1399, 1418);
return return_v;
}


static string
f_25060_1452_1482(char
c,int
count)
{
var return_v = new string( c, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 1452, 1482);
return return_v;
}


static System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.IOperation>
f_25060_1554_1594()
{
var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.IOperation>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 1554, 1594);
return return_v;
}


static System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ILabelSymbol, uint>
f_25060_1623_1659()
{
var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ILabelSymbol, uint>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25060, 1623, 1659);
return return_v;
}

}
}
