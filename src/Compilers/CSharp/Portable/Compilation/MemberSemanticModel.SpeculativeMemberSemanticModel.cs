// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
internal abstract partial class MemberSemanticModel
{private sealed class SpeculativeMemberSemanticModel : MemberSemanticModel
{
public SpeculativeMemberSemanticModel(SyntaxTreeSemanticModel parentSemanticModel, Symbol owner, TypeSyntax root, Binder rootBinder, NullableWalker.SnapshotManager snapshotManagerOpt, ImmutableDictionary<Symbol, Symbol> parentRemappedSymbolsOpt, int position)
:base(f_10925_1400_1404_C(root) ,owner,rootBinder,containingSemanticModelOpt: null,parentSemanticModelOpt: parentSemanticModel,snapshotManagerOpt,parentRemappedSymbolsOpt,speculatedPosition: position)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(10925,1116,1673);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10925,1612,1658);

f_10925_1612_1657(parentSemanticModel is not null);
DynAbs.Tracing.TraceSender.TraceExitConstructor(10925,1116,1673);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10925,1116,1673);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10925,1116,1673);
}
		}

protected override NullableWalker.SnapshotManager GetSnapshotManager()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10925,1689,1966);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10925,1918,1951);

return _parentSnapshotManagerOpt;
DynAbs.Tracing.TraceSender.TraceExitMethod(10925,1689,1966);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10925,1689,1966);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10925,1689,1966);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override BoundNode RewriteNullableBoundNodesWithSnapshots(
                BoundNode boundRoot,
                Binder binder,
                DiagnosticBag diagnostics,
                bool createSnapshots,
                out NullableWalker.SnapshotManager snapshotManager,
                ref ImmutableDictionary<Symbol, Symbol> remappedSymbols)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10925,1982,2658);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10925,2379,2424);

f_10925_2379_2423(boundRoot.Syntax is TypeSyntax);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10925,2442,2643);

return f_10925_2449_2642(f_10925_2482_2493(), f_10925_2495_2507()as MethodSymbol, boundRoot, binder, initialState: null, diagnostics, createSnapshots: false, out snapshotManager, ref remappedSymbols);
DynAbs.Tracing.TraceSender.TraceExitMethod(10925,1982,2658);

int
f_10925_2379_2423(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10925, 2379, 2423);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_10925_2482_2493()
{
var return_v = Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10925, 2482, 2493);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10925_2495_2507()
{
var return_v = MemberSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10925, 2495, 2507);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNode
f_10925_2449_2642(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
symbol,Microsoft.CodeAnalysis.CSharp.BoundNode
node,Microsoft.CodeAnalysis.CSharp.Binder
binder,Microsoft.CodeAnalysis.CSharp.NullableWalker.VariableState?
initialState,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,bool
createSnapshots,out Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager
snapshotManager,ref System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
remappedSymbols)
{
var return_v = NullableWalker.AnalyzeAndRewrite( compilation, (Microsoft.CodeAnalysis.CSharp.Symbol?)symbol, node, binder, initialState: initialState, diagnostics, createSnapshots: createSnapshots, out snapshotManager, ref remappedSymbols);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10925, 2449, 2642);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10925,1982,2658);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10925,1982,2658);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override void AnalyzeBoundNodeNullability(BoundNode boundRoot, Binder binder, DiagnosticBag diagnostics, bool createSnapshots)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10925,2674,2987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10925,2843,2972);

f_10925_2843_2971(f_10925_2880_2891(), f_10925_2893_2905()as MethodSymbol, boundRoot, binder, diagnostics, createSnapshots);
DynAbs.Tracing.TraceSender.TraceExitMethod(10925,2674,2987);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_10925_2880_2891()
{
var return_v = Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10925, 2880, 2891);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10925_2893_2905()
{
var return_v = MemberSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10925, 2893, 2905);
return return_v;
}


int
f_10925_2843_2971(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
symbol,Microsoft.CodeAnalysis.CSharp.BoundNode
node,Microsoft.CodeAnalysis.CSharp.Binder
binder,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,bool
createSnapshots)
{
NullableWalker.AnalyzeWithoutRewrite( compilation, (Microsoft.CodeAnalysis.CSharp.Symbol?)symbol, node, binder, diagnostics, createSnapshots);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10925, 2843, 2971);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10925,2674,2987);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10925,2674,2987);
}
		}

protected override bool IsNullableAnalysisEnabled()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10925,3003,3218);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10925,3087,3203);

return f_10925_3094_3202(_parentSemanticModelOpt, f_10925_3165_3195(), f_10925_3197_3201());
DynAbs.Tracing.TraceSender.TraceExitMethod(10925,3003,3218);

int
f_10925_3165_3195()
{
var return_v = OriginalPositionForSpeculation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10925, 3165, 3195);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
f_10925_3197_3201()
{
var return_v = Root;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10925, 3197, 3201);
return return_v;
}


bool
f_10925_3094_3202(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
this_param,int
position,Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
speculativeSyntax)
{
var return_v = this_param.IsNullableAnalysisEnabledAtSpeculativePosition( position, (Microsoft.CodeAnalysis.SyntaxNode)speculativeSyntax);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10925, 3094, 3202);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10925,3003,3218);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10925,3003,3218);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, ConstructorInitializerSyntax constructorInitializer, out SemanticModel speculativeModel)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10925,3234,3516);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10925,3464,3501);

throw f_10925_3470_3500();
DynAbs.Tracing.TraceSender.TraceExitMethod(10925,3234,3516);

System.Exception
f_10925_3470_3500()
{
var return_v = ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10925, 3470, 3500);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10925,3234,3516);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10925,3234,3516);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, PrimaryConstructorBaseTypeSyntax constructorInitializer, out SemanticModel speculativeModel)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10925,3532,3818);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10925,3766,3803);

throw f_10925_3772_3802();
DynAbs.Tracing.TraceSender.TraceExitMethod(10925,3532,3818);

System.Exception
f_10925_3772_3802()
{
var return_v = ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10925, 3772, 3802);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10925,3532,3818);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10925,3532,3818);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, EqualsValueClauseSyntax initializer, out SemanticModel speculativeModel)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10925,3834,4100);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10925,4048,4085);

throw f_10925_4054_4084();
DynAbs.Tracing.TraceSender.TraceExitMethod(10925,3834,4100);

System.Exception
f_10925_4054_4084()
{
var return_v = ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10925, 4054, 4084);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10925,3834,4100);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10925,3834,4100);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, ArrowExpressionClauseSyntax expressionBody, out SemanticModel speculativeModel)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10925,4116,4389);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10925,4337,4374);

throw f_10925_4343_4373();
DynAbs.Tracing.TraceSender.TraceExitMethod(10925,4116,4389);

System.Exception
f_10925_4343_4373()
{
var return_v = ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10925, 4343, 4373);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10925,4116,4389);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10925,4116,4389);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, StatementSyntax statement, out SemanticModel speculativeModel)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10925,4405,4661);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10925,4609,4646);

throw f_10925_4615_4645();
DynAbs.Tracing.TraceSender.TraceExitMethod(10925,4405,4661);

System.Exception
f_10925_4615_4645()
{
var return_v = ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10925, 4615, 4645);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10925,4405,4661);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10925,4405,4661);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool TryGetSpeculativeSemanticModelForMethodBodyCore(SyntaxTreeSemanticModel parentModel, int position, BaseMethodDeclarationSyntax method, out SemanticModel speculativeModel)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10925,4677,4955);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10925,4903,4940);

throw f_10925_4909_4939();
DynAbs.Tracing.TraceSender.TraceExitMethod(10925,4677,4955);

System.Exception
f_10925_4909_4939()
{
var return_v = ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10925, 4909, 4939);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10925,4677,4955);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10925,4677,4955);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool TryGetSpeculativeSemanticModelForMethodBodyCore(SyntaxTreeSemanticModel parentModel, int position, AccessorDeclarationSyntax accessor, out SemanticModel speculativeModel)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10925,4971,5249);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10925,5197,5234);

throw f_10925_5203_5233();
DynAbs.Tracing.TraceSender.TraceExitMethod(10925,4971,5249);

System.Exception
f_10925_5203_5233()
{
var return_v = ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10925, 5203, 5233);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10925,4971,5249);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10925,4971,5249);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static SpeculativeMemberSemanticModel()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10925,834,5260);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10925,834,5260);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10925,834,5260);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10925,834,5260);

int
f_10925_1612_1657(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10925, 1612, 1657);
return 0;
}


static Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
f_10925_1400_1404_C(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(10925, 1116, 1673);
return return_v;
}

}
}
}
