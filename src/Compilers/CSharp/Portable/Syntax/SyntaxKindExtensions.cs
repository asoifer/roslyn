// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
internal static partial class SyntaxKindExtensions
{
internal static SpecialType GetSpecialType(this SyntaxKind kind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10807,350,2312);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10807,439,2301);

switch (kind)
            {

case SyntaxKind.VoidKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10807,439,2301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10807,535,566);

return SpecialType.System_Void;
DynAbs.Tracing.TraceSender.TraceExitCondition(10807,439,2301);

case SyntaxKind.BoolKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10807,439,2301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10807,634,668);

return SpecialType.System_Boolean;
DynAbs.Tracing.TraceSender.TraceExitCondition(10807,439,2301);

case SyntaxKind.ByteKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10807,439,2301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10807,736,767);

return SpecialType.System_Byte;
DynAbs.Tracing.TraceSender.TraceExitCondition(10807,439,2301);

case SyntaxKind.SByteKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10807,439,2301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10807,836,868);

return SpecialType.System_SByte;
DynAbs.Tracing.TraceSender.TraceExitCondition(10807,439,2301);

case SyntaxKind.ShortKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10807,439,2301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10807,937,969);

return SpecialType.System_Int16;
DynAbs.Tracing.TraceSender.TraceExitCondition(10807,439,2301);

case SyntaxKind.UShortKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10807,439,2301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10807,1039,1072);

return SpecialType.System_UInt16;
DynAbs.Tracing.TraceSender.TraceExitCondition(10807,439,2301);

case SyntaxKind.IntKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10807,439,2301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10807,1139,1171);

return SpecialType.System_Int32;
DynAbs.Tracing.TraceSender.TraceExitCondition(10807,439,2301);

case SyntaxKind.UIntKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10807,439,2301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10807,1239,1272);

return SpecialType.System_UInt32;
DynAbs.Tracing.TraceSender.TraceExitCondition(10807,439,2301);

case SyntaxKind.LongKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10807,439,2301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10807,1340,1372);

return SpecialType.System_Int64;
DynAbs.Tracing.TraceSender.TraceExitCondition(10807,439,2301);

case SyntaxKind.ULongKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10807,439,2301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10807,1441,1474);

return SpecialType.System_UInt64;
DynAbs.Tracing.TraceSender.TraceExitCondition(10807,439,2301);

case SyntaxKind.DoubleKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10807,439,2301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10807,1544,1577);

return SpecialType.System_Double;
DynAbs.Tracing.TraceSender.TraceExitCondition(10807,439,2301);

case SyntaxKind.FloatKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10807,439,2301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10807,1646,1679);

return SpecialType.System_Single;
DynAbs.Tracing.TraceSender.TraceExitCondition(10807,439,2301);

case SyntaxKind.DecimalKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10807,439,2301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10807,1750,1784);

return SpecialType.System_Decimal;
DynAbs.Tracing.TraceSender.TraceExitCondition(10807,439,2301);

case SyntaxKind.StringKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10807,439,2301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10807,1854,1887);

return SpecialType.System_String;
DynAbs.Tracing.TraceSender.TraceExitCondition(10807,439,2301);

case SyntaxKind.CharKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10807,439,2301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10807,1955,1986);

return SpecialType.System_Char;
DynAbs.Tracing.TraceSender.TraceExitCondition(10807,439,2301);

case SyntaxKind.ObjectKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10807,439,2301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10807,2056,2089);

return SpecialType.System_Object;
DynAbs.Tracing.TraceSender.TraceExitCondition(10807,439,2301);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10807,439,2301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10807,2239,2286);

throw f_10807_2245_2285(kind);
DynAbs.Tracing.TraceSender.TraceExitCondition(10807,439,2301);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10807,350,2312);

System.Exception
f_10807_2245_2285(Microsoft.CodeAnalysis.CSharp.SyntaxKind
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10807, 2245, 2285);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10807,350,2312);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10807,350,2312);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static SyntaxKindExtensions()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10807,283,2319);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10807,283,2319);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10807,283,2319);
}

}
}
