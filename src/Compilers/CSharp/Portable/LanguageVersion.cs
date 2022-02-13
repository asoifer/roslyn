// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    /// <summary>
    /// Specifies the language version.
    /// </summary>
    public enum LanguageVersion
    {
        /// <summary>
        /// C# language version 1
        /// </summary>
        CSharp1 = 1,

        /// <summary>
        /// C# language version 2
        /// </summary>
        CSharp2 = 2,

        /// <summary>
        /// C# language version 3
        /// </summary>
        /// <remarks> 
        /// Features: LINQ.
        /// </remarks>
        CSharp3 = 3,

        /// <summary>
        /// C# language version 4
        /// </summary>
        /// <remarks> 
        /// Features: dynamic.
        /// </remarks>
        CSharp4 = 4,

        /// <summary>
        /// C# language version 5
        /// </summary>
        /// <remarks> 
        /// Features: async, caller info attributes.
        /// </remarks>
        CSharp5 = 5,

        /// <summary>
        /// C# language version 6
        /// </summary>
        /// <remarks>
        /// <para>Features:</para>
        /// <list type="bullet">
        /// <item><description>Using of a static class</description></item>
        /// <item><description>Exception filters</description></item>
        /// <item><description>Await in catch/finally blocks</description></item>
        /// <item><description>Auto-property initializers</description></item>
        /// <item><description>Expression-bodied methods and properties</description></item>
        /// <item><description>Null-propagating operator ?.</description></item>
        /// <item><description>String interpolation</description></item>
        /// <item><description>nameof operator</description></item>
        /// <item><description>Dictionary initializer</description></item>
        /// </list>
        /// </remarks>
        CSharp6 = 6,

        /// <summary>
        /// C# language version 7.0
        /// </summary>
        /// <remarks>
        /// <para>Features:</para>
        /// <list type="bullet">
        /// <item><description>Out variables</description></item>
        /// <item><description>Pattern-matching</description></item>
        /// <item><description>Tuples</description></item>
        /// <item><description>Deconstruction</description></item>
        /// <item><description>Discards</description></item>
        /// <item><description>Local functions</description></item>
        /// <item><description>Digit separators</description></item>
        /// <item><description>Ref returns and locals</description></item>
        /// <item><description>Generalized async return types</description></item>
        /// <item><description>More expression-bodied members</description></item>
        /// <item><description>Throw expressions</description></item>
        /// </list>
        /// </remarks>
        CSharp7 = 7,

        /// <summary>
        /// C# language version 7.1
        /// </summary>
        /// <remarks>
        /// <para>Features:</para>
        /// <list type="bullet">
        /// <item><description>Async Main</description></item>
        /// <item><description>Default literal</description></item>
        /// <item><description>Inferred tuple element names</description></item>
        /// <item><description>Pattern-matching with generics</description></item>
        /// </list>
        /// </remarks>
        CSharp7_1 = 701,

        /// <summary>
        /// C# language version 7.2
        /// </summary>
        /// <remarks>
        /// <para>Features:</para>
        /// <list type="bullet">
        /// <item><description>Ref readonly</description></item>
        /// <item><description>Ref and readonly structs</description></item>
        /// <item><description>Ref extensions</description></item>
        /// <item><description>Conditional ref operator</description></item>
        /// <item><description>Private protected</description></item>
        /// <item><description>Digit separators after base specifier</description></item>
        /// <item><description>Non-trailing named arguments</description></item>
        /// </list>
        /// </remarks>
        CSharp7_2 = 702,

        /// <summary>
        /// C# language version 7.3
        /// </summary>
        CSharp7_3 = 703,

        /// <summary>
        /// C# language version 8.0
        /// </summary>
        CSharp8 = 800,

        // When this value is available in the released NuGet package, update LanguageVersionExtensions in the IDE layer to point to it.
        // https://github.com/dotnet/roslyn/issues/43348
        //
        /// <summary>
        /// C# language version 9.0
        /// </summary>
        CSharp9 = 900,

        /// <summary>
        /// The latest major supported version.
        /// </summary>
        LatestMajor = int.MaxValue - 2,

        /// <summary>
        /// Preview of the next language version.
        /// </summary>
        Preview = int.MaxValue - 1,

        /// <summary>
        /// The latest supported version of the language.
        /// </summary>
        Latest = int.MaxValue,

        /// <summary>
        /// The default language version, which is the latest supported version.
        /// </summary>
        Default = 0,
    }
internal static class LanguageVersionExtensionsInternal
{
internal static bool IsValid(this LanguageVersion value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10036,5690,6506);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,5771,6466);

switch (value)
            {

case LanguageVersion.CSharp1:
                case LanguageVersion.CSharp2:
                case LanguageVersion.CSharp3:
                case LanguageVersion.CSharp4:
                case LanguageVersion.CSharp5:
                case LanguageVersion.CSharp6:
                case LanguageVersion.CSharp7:
                case LanguageVersion.CSharp7_1:
                case LanguageVersion.CSharp7_2:
                case LanguageVersion.CSharp7_3:
                case LanguageVersion.CSharp8:
                case LanguageVersion.CSharp9:
                case LanguageVersion.Preview:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,5771,6466);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,6439,6451);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,5771,6466);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,6482,6495);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10036,5690,6506);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10036,5690,6506);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10036,5690,6506);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static ErrorCode GetErrorCode(this LanguageVersion version)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10036,6518,8218);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,6611,8207);

switch (version)
            {

case LanguageVersion.CSharp1:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,6611,8207);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,6711,6762);

return ErrorCode.ERR_FeatureNotAvailableInVersion1;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,6611,8207);

case LanguageVersion.CSharp2:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,6611,8207);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,6831,6882);

return ErrorCode.ERR_FeatureNotAvailableInVersion2;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,6611,8207);

case LanguageVersion.CSharp3:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,6611,8207);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,6951,7002);

return ErrorCode.ERR_FeatureNotAvailableInVersion3;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,6611,8207);

case LanguageVersion.CSharp4:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,6611,8207);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,7071,7122);

return ErrorCode.ERR_FeatureNotAvailableInVersion4;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,6611,8207);

case LanguageVersion.CSharp5:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,6611,8207);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,7191,7242);

return ErrorCode.ERR_FeatureNotAvailableInVersion5;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,6611,8207);

case LanguageVersion.CSharp6:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,6611,8207);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,7311,7362);

return ErrorCode.ERR_FeatureNotAvailableInVersion6;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,6611,8207);

case LanguageVersion.CSharp7:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,6611,8207);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,7431,7482);

return ErrorCode.ERR_FeatureNotAvailableInVersion7;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,6611,8207);

case LanguageVersion.CSharp7_1:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,6611,8207);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,7553,7606);

return ErrorCode.ERR_FeatureNotAvailableInVersion7_1;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,6611,8207);

case LanguageVersion.CSharp7_2:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,6611,8207);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,7677,7730);

return ErrorCode.ERR_FeatureNotAvailableInVersion7_2;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,6611,8207);

case LanguageVersion.CSharp7_3:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,6611,8207);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,7801,7854);

return ErrorCode.ERR_FeatureNotAvailableInVersion7_3;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,6611,8207);

case LanguageVersion.CSharp8:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,6611,8207);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,7923,7974);

return ErrorCode.ERR_FeatureNotAvailableInVersion8;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,6611,8207);

case LanguageVersion.CSharp9:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,6611,8207);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,8043,8094);

return ErrorCode.ERR_FeatureNotAvailableInVersion9;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,6611,8207);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,6611,8207);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,8142,8192);

throw f_10036_8148_8191(version);
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,6611,8207);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10036,6518,8218);

System.Exception
f_10036_8148_8191(Microsoft.CodeAnalysis.CSharp.LanguageVersion
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10036, 8148, 8191);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10036,6518,8218);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10036,6518,8218);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static LanguageVersionExtensionsInternal()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10036,5618,8225);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10036,5618,8225);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10036,5618,8225);
}

}
internal class CSharpRequiredLanguageVersion : RequiredLanguageVersion
{
internal LanguageVersion Version {get; }

internal CSharpRequiredLanguageVersion(LanguageVersion version)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(10036,8373,8588);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,8320,8361);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,8461,8577);

Version = (DynAbs.Tracing.TraceSender.Conditional_F1(10036, 8471, 8540)||(((version == f_10036_8483_8539(LanguageVersion.Preview)) &&DynAbs.Tracing.TraceSender.Conditional_F2(10036, 8543, 8566))||DynAbs.Tracing.TraceSender.Conditional_F3(10036, 8569, 8576)))?LanguageVersion.Preview :version;
DynAbs.Tracing.TraceSender.TraceExitConstructor(10036,8373,8588);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10036,8373,8588);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10036,8373,8588);
}
		}

public override string ToString() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10036,8634,8662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,8637,8662);
return f_10036_8637_8662(f_10036_8637_8644());DynAbs.Tracing.TraceSender.TraceExitMethod(10036,8634,8662);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10036,8634,8662);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10036,8634,8662);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static CSharpRequiredLanguageVersion()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10036,8233,8670);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10036,8233,8670);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10036,8233,8670);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10036,8233,8670);

Microsoft.CodeAnalysis.CSharp.LanguageVersion
f_10036_8483_8539(Microsoft.CodeAnalysis.CSharp.LanguageVersion
version)
{
var return_v = version.MapSpecifiedToEffectiveVersion();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10036, 8483, 8539);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LanguageVersion
f_10036_8637_8644()
{
var return_v = Version;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10036, 8637, 8644);
return return_v;
}


string
f_10036_8637_8662(Microsoft.CodeAnalysis.CSharp.LanguageVersion
version)
{
var return_v = version.ToDisplayString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10036, 8637, 8662);
return return_v;
}

}
public static class LanguageVersionFacts
{
public static string ToDisplayString(this LanguageVersion version)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10036,8939,10513);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,9030,10502);

switch (version)
            {

case LanguageVersion.CSharp1:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,9030,10502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,9130,9141);

return "1";
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,9030,10502);

case LanguageVersion.CSharp2:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,9030,10502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,9210,9221);

return "2";
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,9030,10502);

case LanguageVersion.CSharp3:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,9030,10502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,9290,9301);

return "3";
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,9030,10502);

case LanguageVersion.CSharp4:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,9030,10502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,9370,9381);

return "4";
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,9030,10502);

case LanguageVersion.CSharp5:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,9030,10502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,9450,9461);

return "5";
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,9030,10502);

case LanguageVersion.CSharp6:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,9030,10502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,9530,9541);

return "6";
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,9030,10502);

case LanguageVersion.CSharp7:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,9030,10502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,9610,9623);

return "7.0";
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,9030,10502);

case LanguageVersion.CSharp7_1:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,9030,10502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,9694,9707);

return "7.1";
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,9030,10502);

case LanguageVersion.CSharp7_2:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,9030,10502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,9778,9791);

return "7.2";
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,9030,10502);

case LanguageVersion.CSharp7_3:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,9030,10502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,9862,9875);

return "7.3";
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,9030,10502);

case LanguageVersion.CSharp8:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,9030,10502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,9944,9957);

return "8.0";
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,9030,10502);

case LanguageVersion.CSharp9:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,9030,10502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,10026,10039);

return "9.0";
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,9030,10502);

case LanguageVersion.Default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,9030,10502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,10108,10125);

return "default";
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,9030,10502);

case LanguageVersion.Latest:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,9030,10502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,10193,10209);

return "latest";
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,9030,10502);

case LanguageVersion.LatestMajor:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,9030,10502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,10282,10303);

return "latestmajor";
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,9030,10502);

case LanguageVersion.Preview:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,9030,10502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,10372,10389);

return "preview";
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,9030,10502);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,9030,10502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,10437,10487);

throw f_10036_10443_10486(version);
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,9030,10502);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10036,8939,10513);

System.Exception
f_10036_10443_10486(Microsoft.CodeAnalysis.CSharp.LanguageVersion
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10036, 10443, 10486);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10036,8939,10513);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10036,8939,10513);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static bool TryParse(string? version, out LanguageVersion result)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10036,10685,13390);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,10782,10913) || true) && (version == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,10782,10913);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,10835,10868);

result = LanguageVersion.Default;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,10886,10898);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,10782,10913);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,10929,13379);

switch (f_10036_10937_10979(version))
            {

case "default":
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,10929,13379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,11050,11083);

result = LanguageVersion.Default;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,11105,11117);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,10929,13379);

case "latest":
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,10929,13379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,11173,11205);

result = LanguageVersion.Latest;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,11227,11239);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,10929,13379);

case "latestmajor":
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,10929,13379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,11300,11337);

result = LanguageVersion.LatestMajor;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,11359,11371);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,10929,13379);

case "preview":
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,10929,13379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,11428,11461);

result = LanguageVersion.Preview;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,11483,11495);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,10929,13379);

case "1":
                case "1.0":
                case "iso-1":
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,10929,13379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,11606,11639);

result = LanguageVersion.CSharp1;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,11661,11673);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,10929,13379);

case "2":
                case "2.0":
                case "iso-2":
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,10929,13379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,11784,11817);

result = LanguageVersion.CSharp2;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,11839,11851);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,10929,13379);

case "3":
                case "3.0":
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,10929,13379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,11931,11964);

result = LanguageVersion.CSharp3;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,11986,11998);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,10929,13379);

case "4":
                case "4.0":
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,10929,13379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,12078,12111);

result = LanguageVersion.CSharp4;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,12133,12145);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,10929,13379);

case "5":
                case "5.0":
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,10929,13379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,12225,12258);

result = LanguageVersion.CSharp5;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,12280,12292);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,10929,13379);

case "6":
                case "6.0":
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,10929,13379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,12372,12405);

result = LanguageVersion.CSharp6;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,12427,12439);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,10929,13379);

case "7":
                case "7.0":
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,10929,13379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,12519,12552);

result = LanguageVersion.CSharp7;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,12574,12586);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,10929,13379);

case "7.1":
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,10929,13379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,12639,12674);

result = LanguageVersion.CSharp7_1;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,12696,12708);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,10929,13379);

case "7.2":
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,10929,13379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,12761,12796);

result = LanguageVersion.CSharp7_2;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,12818,12830);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,10929,13379);

case "7.3":
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,10929,13379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,12883,12918);

result = LanguageVersion.CSharp7_3;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,12940,12952);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,10929,13379);

case "8":
                case "8.0":
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,10929,13379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,13032,13065);

result = LanguageVersion.CSharp8;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,13087,13099);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,10929,13379);

case "9":
                case "9.0":
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,10929,13379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,13179,13212);

result = LanguageVersion.CSharp9;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,13234,13246);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,10929,13379);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,10929,13379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,13296,13329);

result = LanguageVersion.Default;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,13351,13364);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,10929,13379);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10036,10685,13390);

string?
f_10036_10937_10979(string
value)
{
var return_v = CaseInsensitiveComparison.ToLower( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10036, 10937, 10979);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10036,10685,13390);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10036,10685,13390);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static LanguageVersion MapSpecifiedToEffectiveVersion(this LanguageVersion version)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10036,13556,13988);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,13671,13977);

switch (version)
            {

case LanguageVersion.Latest:
                case LanguageVersion.Default:
                case LanguageVersion.LatestMajor:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,13671,13977);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,13868,13899);

return LanguageVersion.CSharp9;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,13671,13977);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10036,13671,13977);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,13947,13962);

return version;
DynAbs.Tracing.TraceSender.TraceExitCondition(10036,13671,13977);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10036,13556,13988);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10036,13556,13988);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10036,13556,13988);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static LanguageVersion CurrentVersion {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10036,14047,14073);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,14050,14073);
return LanguageVersion.CSharp9;DynAbs.Tracing.TraceSender.TraceExitMethod(10036,14047,14073);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10036,14047,14073);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10036,14047,14073);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal static bool DisallowInferredTupleElementNames(this LanguageVersion self)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10036,14171,14360);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,14277,14349);

return self < f_10036_14291_14348(MessageID.IDS_FeatureInferredTupleNames);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10036,14171,14360);

Microsoft.CodeAnalysis.CSharp.LanguageVersion
f_10036_14291_14348(Microsoft.CodeAnalysis.CSharp.MessageID
feature)
{
var return_v = feature.RequiredVersion();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10036, 14291, 14348);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10036,14171,14360);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10036,14171,14360);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool AllowNonTrailingNamedArguments(this LanguageVersion self)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10036,14372,14566);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,14475,14555);

return self >= f_10036_14490_14554(MessageID.IDS_FeatureNonTrailingNamedArguments);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10036,14372,14566);

Microsoft.CodeAnalysis.CSharp.LanguageVersion
f_10036_14490_14554(Microsoft.CodeAnalysis.CSharp.MessageID
feature)
{
var return_v = feature.RequiredVersion();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10036, 14490, 14554);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10036,14372,14566);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10036,14372,14566);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool AllowAttributesOnBackingFields(this LanguageVersion self)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10036,14578,14772);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,14681,14761);

return self >= f_10036_14696_14760(MessageID.IDS_FeatureAttributesOnBackingFields);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10036,14578,14772);

Microsoft.CodeAnalysis.CSharp.LanguageVersion
f_10036_14696_14760(Microsoft.CodeAnalysis.CSharp.MessageID
feature)
{
var return_v = feature.RequiredVersion();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10036, 14696, 14760);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10036,14578,14772);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10036,14578,14772);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool AllowImprovedOverloadCandidates(this LanguageVersion self)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10036,14784,14980);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10036,14888,14969);

return self >= f_10036_14903_14968(MessageID.IDS_FeatureImprovedOverloadCandidates);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10036,14784,14980);

Microsoft.CodeAnalysis.CSharp.LanguageVersion
f_10036_14903_14968(Microsoft.CodeAnalysis.CSharp.MessageID
feature)
{
var return_v = feature.RequiredVersion();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10036, 14903, 14968);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10036,14784,14980);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10036,14784,14980);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static LanguageVersionFacts()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10036,8678,14987);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10036,8678,14987);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10036,8678,14987);
}

}
}
