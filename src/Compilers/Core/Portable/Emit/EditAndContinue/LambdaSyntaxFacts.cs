// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis.Emit
{
internal abstract class LambdaSyntaxFacts
{
public abstract SyntaxNode GetLambda(SyntaxNode lambdaOrLambdaBodySyntax);

public abstract SyntaxNode TryGetCorrespondingLambdaBody(SyntaxNode previousLambdaSyntax, SyntaxNode lambdaOrLambdaBodySyntax);

public abstract int GetDeclaratorPosition(SyntaxNode node);

public LambdaSyntaxFacts()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(766,275,1551);
DynAbs.Tracing.TraceSender.TraceExitConstructor(766,275,1551);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(766,275,1551);
}


static LambdaSyntaxFacts()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(766,275,1551);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(766,275,1551);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(766,275,1551);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(766,275,1551);
}
}
