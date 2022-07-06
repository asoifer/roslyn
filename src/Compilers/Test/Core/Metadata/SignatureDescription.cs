// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis.Test.Utilities
{
public class SignatureDescription
{
public string FullyQualifiedTypeName {get; set; }

public string MemberName {get; set; }

public string ExpectedSignature {get; set; }

public SignatureDescription()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25109,285,495);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25109,335,385);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25109,395,433);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25109,443,488);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25109,285,495);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25109,285,495);
}


static SignatureDescription()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25109,285,495);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25109,285,495);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25109,285,495);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25109,285,495);
}
}
