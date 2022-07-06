// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Xunit;

namespace Roslyn.Test.Utilities.PDB
{

internal readonly struct MetadataReferenceInfo
    {

public readonly int Timestamp;

public readonly int ImageSize;

public readonly string Name;

public readonly Guid Mvid;

public readonly ImmutableArray<string> ExternAliases;

public readonly MetadataImageKind Kind;

public readonly bool EmbedInteropTypes;

public MetadataReferenceInfo(
            int timestamp,
            int imageSize,
            string name,
            Guid mvid,
            ImmutableArray<string> externAliases,
            MetadataImageKind kind,
            bool embedInteropTypes)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25125,752,1280);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25125,1037,1059);

Timestamp = timestamp;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25125,1073,1095);

ImageSize = imageSize;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25125,1109,1121);

Name = name;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25125,1135,1147);

Mvid = mvid;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25125,1161,1191);

ExternAliases = externAliases;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25125,1205,1217);

Kind = kind;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25125,1231,1269);

EmbedInteropTypes = embedInteropTypes;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25125,752,1280);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25125,752,1280);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25125,752,1280);
}
		}

internal void AssertEqual(MetadataReferenceInfo other)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25125,1292,1747);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25125,1371,1402);

f_25125_1371_1401(Name, other.Name);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25125,1416,1457);

f_25125_1416_1456(Timestamp, other.Timestamp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25125,1471,1512);

f_25125_1471_1511(ImageSize, other.ImageSize);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25125,1526,1557);

f_25125_1526_1556(Mvid, other.Mvid);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25125,1571,1620);

f_25125_1571_1619(ExternAliases, other.ExternAliases);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25125,1634,1665);

f_25125_1634_1664(Kind, other.Kind);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25125,1679,1736);

f_25125_1679_1735(EmbedInteropTypes, other.EmbedInteropTypes);
DynAbs.Tracing.TraceSender.TraceExitMethod(25125,1292,1747);

int
f_25125_1371_1401(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25125, 1371, 1401);
return 0;
}


int
f_25125_1416_1456(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25125, 1416, 1456);
return 0;
}


int
f_25125_1471_1511(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25125, 1471, 1511);
return 0;
}


int
f_25125_1526_1556(System.Guid
expected,System.Guid
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25125, 1526, 1556);
return 0;
}


int
f_25125_1571_1619(System.Collections.Immutable.ImmutableArray<string>
expected,System.Collections.Immutable.ImmutableArray<string>
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25125, 1571, 1619);
return 0;
}


int
f_25125_1634_1664(Microsoft.CodeAnalysis.MetadataImageKind
expected,Microsoft.CodeAnalysis.MetadataImageKind
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25125, 1634, 1664);
return 0;
}


int
f_25125_1679_1735(bool
expected,bool
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25125, 1679, 1735);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25125,1292,1747);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25125,1292,1747);
}
		}
static MetadataReferenceInfo(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25125,372,1754);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25125,372,1754);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25125,372,1754);
}
    }
}
