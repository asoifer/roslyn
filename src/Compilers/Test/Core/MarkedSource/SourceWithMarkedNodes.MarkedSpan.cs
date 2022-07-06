// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.Text;

namespace Roslyn.Test.Utilities
{
internal sealed partial class SourceWithMarkedNodes
{
internal struct MarkedSpan
        {

public readonly TextSpan MarkedSyntax;

public readonly TextSpan MatchedSpan;

public readonly string TagName;

public readonly int SyntaxKind;

public readonly int Id;

public readonly int ParentId;

public MarkedSpan(TextSpan markedSyntax, TextSpan matchedSpan, string tagName, int syntaxKind, int id, int parentId)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25100,701,1079);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25100,850,878);

MarkedSyntax = markedSyntax;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25100,896,922);

MatchedSpan = matchedSpan;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25100,940,958);

TagName = tagName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25100,976,1000);

SyntaxKind = syntaxKind;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25100,1018,1026);

Id = id;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25100,1044,1064);

ParentId = parentId;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25100,701,1079);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25100,701,1079);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25100,701,1079);
}
		}
static MarkedSpan(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25100,375,1090);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25100,375,1090);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25100,375,1090);
}
        }
}
}
