// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed class AttributeSemanticModel : MemberSemanticModel
{
private readonly AliasSymbol _aliasOpt;

private AttributeSemanticModel(
            AttributeSyntax syntax,
            NamedTypeSymbol attributeType,
            AliasSymbol aliasOpt,
            Binder rootBinder,
            SyntaxTreeSemanticModel? containingSemanticModelOpt = null,
            SyntaxTreeSemanticModel? parentSemanticModelOpt = null,
            ImmutableDictionary<Symbol, Symbol>? parentRemappedSymbolsOpt = null,
            int speculatedPosition = 0)
:base(f_10911_1197_1203_C(syntax) ,attributeType,f_10911_1220_1295(syntax, f_10911_1253_1282(rootBinder), rootBinder),containingSemanticModelOpt,parentSemanticModelOpt,snapshotManagerOpt: null,parentRemappedSymbolsOpt: parentRemappedSymbolsOpt,speculatedPosition)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(10911,731,1546);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,709,718);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,1471,1500);

f_10911_1471_1499(syntax != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,1514,1535);

_aliasOpt = aliasOpt;
DynAbs.Tracing.TraceSender.TraceExitConstructor(10911,731,1546);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10911,731,1546);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10911,731,1546);
}
		}

public static AttributeSemanticModel Create(SyntaxTreeSemanticModel containingSemanticModel, AttributeSyntax syntax, NamedTypeSymbol attributeType, AliasSymbol aliasOpt, Binder rootBinder, ImmutableDictionary<Symbol, Symbol> parentRemappedSymbolsOpt)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10911,1715,2157);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,1990,2146);

return f_10911_1997_2145(syntax, attributeType, aliasOpt, rootBinder, containingSemanticModel, parentRemappedSymbolsOpt: parentRemappedSymbolsOpt);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10911,1715,2157);

Microsoft.CodeAnalysis.CSharp.AttributeSemanticModel
f_10911_1997_2145(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
attributeType,Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
aliasOpt,Microsoft.CodeAnalysis.CSharp.Binder
rootBinder,Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
containingSemanticModelOpt,System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
parentRemappedSymbolsOpt)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.AttributeSemanticModel( syntax, attributeType, aliasOpt, rootBinder, containingSemanticModelOpt, parentRemappedSymbolsOpt: parentRemappedSymbolsOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10911, 1997, 2145);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10911,1715,2157);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10911,1715,2157);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static AttributeSemanticModel CreateSpeculative(SyntaxTreeSemanticModel parentSemanticModel, AttributeSyntax syntax, NamedTypeSymbol attributeType, AliasSymbol aliasOpt, Binder rootBinder, ImmutableDictionary<Symbol, Symbol> parentRemappedSymbolsOpt, int position)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10911,2385,3064);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,2681,2723);

f_10911_2681_2722(parentSemanticModel != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,2737,2770);

f_10911_2737_2769(rootBinder != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,2784,2831);

f_10911_2784_2830(f_10911_2797_2829(rootBinder));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,2847,3053);

return f_10911_2854_3052(syntax, attributeType, aliasOpt, rootBinder, parentSemanticModelOpt: parentSemanticModel, parentRemappedSymbolsOpt: parentRemappedSymbolsOpt, speculatedPosition: position);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10911,2385,3064);

int
f_10911_2681_2722(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10911, 2681, 2722);
return 0;
}


int
f_10911_2737_2769(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10911, 2737, 2769);
return 0;
}


bool
f_10911_2797_2829(Microsoft.CodeAnalysis.CSharp.Binder
this_param)
{
var return_v = this_param.IsSemanticModelBinder;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10911, 2797, 2829);
return return_v;
}


int
f_10911_2784_2830(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10911, 2784, 2830);
return 0;
}


Microsoft.CodeAnalysis.CSharp.AttributeSemanticModel
f_10911_2854_3052(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
attributeType,Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
aliasOpt,Microsoft.CodeAnalysis.CSharp.Binder
rootBinder,Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
parentSemanticModelOpt,System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
parentRemappedSymbolsOpt,int
speculatedPosition)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.AttributeSemanticModel( syntax, attributeType, aliasOpt, rootBinder, parentSemanticModelOpt: parentSemanticModelOpt, parentRemappedSymbolsOpt: parentRemappedSymbolsOpt, speculatedPosition: speculatedPosition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10911, 2854, 3052);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10911,2385,3064);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10911,2385,3064);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private NamedTypeSymbol AttributeType
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10911,3138,3226);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,3174,3211);

return (NamedTypeSymbol)f_10911_3198_3210();
DynAbs.Tracing.TraceSender.TraceExitMethod(10911,3138,3226);

Microsoft.CodeAnalysis.CSharp.Symbol
f_10911_3198_3210()
{
var return_v = MemberSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10911, 3198, 3210);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10911,3076,3237);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10911,3076,3237);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected internal override CSharpSyntaxNode GetBindableSyntaxNode(CSharpSyntaxNode node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10911,3249,4028);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,3363,3961);

switch (f_10911_3371_3382(node))
            {

case SyntaxKind.Attribute:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10911,3363,3961);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,3464,3476);

return node;
DynAbs.Tracing.TraceSender.TraceExitCondition(10911,3363,3961);

case SyntaxKind.AttributeArgument:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10911,3363,3961);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,3614,3639);

var 
parent = f_10911_3627_3638(node)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,3661,3918) || true) && (parent != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10911,3661,3918);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,3729,3752);

parent = f_10911_3738_3751(parent);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,3778,3895) || true) && (parent != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10911,3778,3895);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,3854,3868);

return parent;
DynAbs.Tracing.TraceSender.TraceExitCondition(10911,3778,3895);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10911,3661,3918);
}
DynAbs.Tracing.TraceSender.TraceBreak(10911,3940,3946);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10911,3363,3961);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,3977,4017);

return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetBindableSyntaxNode(node),10911,3984,4016);
DynAbs.Tracing.TraceSender.TraceExitMethod(10911,3249,4028);

Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10911_3371_3382(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
this_param)
{
var return_v = this_param.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10911, 3371, 3382);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
f_10911_3627_3638(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10911, 3627, 3638);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
f_10911_3738_3751(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10911, 3738, 3751);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10911,3249,4028);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10911,3249,4028);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override BoundNode Bind(Binder binder, CSharpSyntaxNode node, DiagnosticBag diagnostics)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10911,4040,4680);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,4162,4669) || true) && (f_10911_4166_4177(node)== SyntaxKind.Attribute)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10911,4162,4669);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,4235,4273);

var 
attribute = (AttributeSyntax)node
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,4291,4358);

return f_10911_4298_4357(binder, attribute, f_10911_4330_4343(), diagnostics);
DynAbs.Tracing.TraceSender.TraceExitCondition(10911,4162,4669);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10911,4162,4669);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,4392,4669) || true) && (f_10911_4396_4429(node))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10911,4392,4669);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,4463,4544);

return f_10911_4470_4543((NameSyntax)node, _aliasOpt, type: f_10911_4529_4542());
DynAbs.Tracing.TraceSender.TraceExitCondition(10911,4392,4669);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10911,4392,4669);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,4610,4654);

return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Bind(binder,node,diagnostics),10911,4617,4653);
DynAbs.Tracing.TraceSender.TraceExitCondition(10911,4392,4669);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10911,4162,4669);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10911,4040,4680);

Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10911_4166_4177(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
this_param)
{
var return_v = this_param.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10911, 4166, 4177);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10911_4330_4343()
{
var return_v = AttributeType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10911, 4330, 4343);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAttribute
f_10911_4298_4357(Microsoft.CodeAnalysis.CSharp.Binder
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
node,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
attributeType,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics)
{
var return_v = this_param.BindAttribute( node, attributeType, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10911, 4298, 4357);
return return_v;
}


bool
f_10911_4396_4429(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
node)
{
var return_v = SyntaxFacts.IsAttributeName( (Microsoft.CodeAnalysis.SyntaxNode)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10911, 4396, 4429);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10911_4529_4542()
{
var return_v = AttributeType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10911, 4529, 4542);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
f_10911_4470_4543(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
aliasOpt,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTypeExpression( (Microsoft.CodeAnalysis.SyntaxNode)syntax, aliasOpt, type: (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10911, 4470, 4543);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10911,4040,4680);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10911,4040,4680);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override BoundNode RewriteNullableBoundNodesWithSnapshots(
            BoundNode boundRoot,
            Binder binder,
            DiagnosticBag diagnostics,
            bool createSnapshots,
            out NullableWalker.SnapshotManager? snapshotManager,
            ref ImmutableDictionary<Symbol, Symbol>? remappedSymbols)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10911,4692,5248);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,5059,5237);

return f_10911_5066_5236(f_10911_5099_5110(), symbol: null, boundRoot, binder, initialState: null, diagnostics, createSnapshots, out snapshotManager, ref remappedSymbols);
DynAbs.Tracing.TraceSender.TraceExitMethod(10911,4692,5248);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_10911_5099_5110()
{
var return_v = Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10911, 5099, 5110);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNode
f_10911_5066_5236(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Symbol?
symbol,Microsoft.CodeAnalysis.CSharp.BoundNode
node,Microsoft.CodeAnalysis.CSharp.Binder
binder,Microsoft.CodeAnalysis.CSharp.NullableWalker.VariableState?
initialState,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,bool
createSnapshots,out Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager?
snapshotManager,ref System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>?
remappedSymbols)
{
var return_v = NullableWalker.AnalyzeAndRewrite( compilation, symbol: symbol, node, binder, initialState: initialState, diagnostics, createSnapshots, out snapshotManager, ref remappedSymbols);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10911, 5066, 5236);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10911,4692,5248);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10911,4692,5248);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override void AnalyzeBoundNodeNullability(BoundNode boundRoot, Binder binder, DiagnosticBag diagnostics, bool createSnapshots)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10911,5260,5545);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,5421,5534);

f_10911_5421_5533(f_10911_5458_5469(), symbol: null, boundRoot, binder, diagnostics, createSnapshots);
DynAbs.Tracing.TraceSender.TraceExitMethod(10911,5260,5545);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_10911_5458_5469()
{
var return_v = Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10911, 5458, 5469);
return return_v;
}


int
f_10911_5421_5533(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Symbol?
symbol,Microsoft.CodeAnalysis.CSharp.BoundNode
node,Microsoft.CodeAnalysis.CSharp.Binder
binder,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,bool
createSnapshots)
{
NullableWalker.AnalyzeWithoutRewrite( compilation, symbol: symbol, node, binder, diagnostics, createSnapshots);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10911, 5421, 5533);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10911,5260,5545);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10911,5260,5545);
}
		}

protected override bool IsNullableAnalysisEnabled()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10911,5557,5715);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,5633,5704);

return f_10911_5640_5703(f_10911_5668_5679(), f_10911_5698_5702());
DynAbs.Tracing.TraceSender.TraceExitMethod(10911,5557,5715);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_10911_5668_5679()
{
var return_v = Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10911, 5668, 5679);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
f_10911_5698_5702()
{
var return_v = Root;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10911, 5698, 5702);
return return_v;
}


bool
f_10911_5640_5703(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
syntax)
{
var return_v = IsNullableAnalysisEnabledIn( compilation, (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax)syntax);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10911, 5640, 5703);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10911,5557,5715);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10911,5557,5715);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool IsNullableAnalysisEnabledIn(CSharpCompilation compilation, AttributeSyntax syntax)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10911,5727,5921);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,5855,5910);

return f_10911_5862_5909(compilation, syntax);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10911,5727,5921);

bool
f_10911_5862_5909(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
syntax)
{
var return_v = this_param.IsNullableAnalysisEnabledIn( (Microsoft.CodeAnalysis.SyntaxNode)syntax);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10911, 5862, 5909);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10911,5727,5921);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10911,5727,5921);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, ConstructorInitializerSyntax constructorInitializer, out SemanticModel? speculativeModel)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10911,5933,6218);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,6156,6180);

speculativeModel = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,6194,6207);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(10911,5933,6218);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10911,5933,6218);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10911,5933,6218);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, PrimaryConstructorBaseTypeSyntax constructorInitializer, out SemanticModel? speculativeModel)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10911,6230,6519);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,6457,6481);

speculativeModel = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,6495,6508);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(10911,6230,6519);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10911,6230,6519);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10911,6230,6519);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, EqualsValueClauseSyntax initializer, out SemanticModel? speculativeModel)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10911,6531,6800);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,6738,6762);

speculativeModel = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,6776,6789);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(10911,6531,6800);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10911,6531,6800);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10911,6531,6800);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, ArrowExpressionClauseSyntax expressionBody, out SemanticModel? speculativeModel)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10911,6812,7088);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,7026,7050);

speculativeModel = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,7064,7077);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(10911,6812,7088);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10911,6812,7088);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10911,6812,7088);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, StatementSyntax statement, out SemanticModel? speculativeModel)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10911,7100,7359);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,7297,7321);

speculativeModel = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,7335,7348);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(10911,7100,7359);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10911,7100,7359);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10911,7100,7359);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool TryGetSpeculativeSemanticModelForMethodBodyCore(SyntaxTreeSemanticModel parentModel, int position, BaseMethodDeclarationSyntax method, out SemanticModel? speculativeModel)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10911,7371,7652);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,7590,7614);

speculativeModel = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,7628,7641);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(10911,7371,7652);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10911,7371,7652);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10911,7371,7652);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool TryGetSpeculativeSemanticModelForMethodBodyCore(SyntaxTreeSemanticModel parentModel, int position, AccessorDeclarationSyntax accessor, out SemanticModel? speculativeModel)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10911,7664,7945);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,7883,7907);

speculativeModel = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10911,7921,7934);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(10911,7664,7945);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10911,7664,7945);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10911,7664,7945);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static AttributeSemanticModel()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10911,597,7952);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10911,597,7952);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10911,597,7952);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10911,597,7952);

static Microsoft.CodeAnalysis.CSharp.Symbol
f_10911_1253_1282(Microsoft.CodeAnalysis.CSharp.Binder
this_param)
{
var return_v = this_param.ContainingMember();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10911, 1253, 1282);
return return_v;
}


static Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
f_10911_1220_1295(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
root,Microsoft.CodeAnalysis.CSharp.Symbol
memberSymbol,Microsoft.CodeAnalysis.CSharp.Binder
next)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder( (Microsoft.CodeAnalysis.SyntaxNode)root, memberSymbol, next);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10911, 1220, 1295);
return return_v;
}


int
f_10911_1471_1499(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10911, 1471, 1499);
return 0;
}


static Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
f_10911_1197_1203_C(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(10911, 731, 1546);
return return_v;
}

}
}
