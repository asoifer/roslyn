// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp
{
internal class SpeculativeSyntaxTreeSemanticModel : SyntaxTreeSemanticModel
{
private readonly SyntaxTreeSemanticModel _parentSemanticModel;

private readonly CSharpSyntaxNode _root;

private readonly Binder _rootBinder;

private readonly int _position;

private readonly SpeculativeBindingOption _bindingOption;

public static SpeculativeSyntaxTreeSemanticModel Create(SyntaxTreeSemanticModel parentSemanticModel, TypeSyntax root, Binder rootBinder, int position, SpeculativeBindingOption bindingOption)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10928,1092,1400);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,1307,1389);

return f_10928_1314_1388(parentSemanticModel, root, rootBinder, position, bindingOption);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10928,1092,1400);

Microsoft.CodeAnalysis.CSharp.SpeculativeSyntaxTreeSemanticModel
f_10928_1314_1388(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
parentSemanticModel,Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
root,Microsoft.CodeAnalysis.CSharp.Binder
rootBinder,int
position,Microsoft.CodeAnalysis.SpeculativeBindingOption
bindingOption)
{
var return_v = CreateCore( parentSemanticModel, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)root, rootBinder, position, bindingOption);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10928, 1314, 1388);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10928,1092,1400);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10928,1092,1400);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static SpeculativeSyntaxTreeSemanticModel Create(SyntaxTreeSemanticModel parentSemanticModel, CrefSyntax root, Binder rootBinder, int position)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10928,1412,1728);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,1587,1717);

return f_10928_1594_1716(parentSemanticModel, root, rootBinder, position, bindingOption: SpeculativeBindingOption.BindAsTypeOrNamespace);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10928,1412,1728);

Microsoft.CodeAnalysis.CSharp.SpeculativeSyntaxTreeSemanticModel
f_10928_1594_1716(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
parentSemanticModel,Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
root,Microsoft.CodeAnalysis.CSharp.Binder
rootBinder,int
position,Microsoft.CodeAnalysis.SpeculativeBindingOption
bindingOption)
{
var return_v = CreateCore( parentSemanticModel, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)root, rootBinder, position, bindingOption: bindingOption);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10928, 1594, 1716);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10928,1412,1728);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10928,1412,1728);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static SpeculativeSyntaxTreeSemanticModel CreateCore(SyntaxTreeSemanticModel parentSemanticModel, CSharpSyntaxNode root, Binder rootBinder, int position, SpeculativeBindingOption bindingOption)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10928,1740,2436);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,1966,2027);

f_10928_1966_2026(parentSemanticModel is SyntaxTreeSemanticModel);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,2041,2068);

f_10928_2041_2067(root != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,2082,2137);

f_10928_2082_2136(root is TypeSyntax ||(DynAbs.Tracing.TraceSender.Expression_False(10928, 2095, 2135)||root is CrefSyntax));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,2151,2184);

f_10928_2151_2183(rootBinder != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,2198,2245);

f_10928_2198_2244(f_10928_2211_2243(rootBinder));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,2261,2387);

var 
speculativeModel = f_10928_2284_2386(parentSemanticModel, root, rootBinder, position, bindingOption)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,2401,2425);

return speculativeModel;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10928,1740,2436);

int
f_10928_1966_2026(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10928, 1966, 2026);
return 0;
}


int
f_10928_2041_2067(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10928, 2041, 2067);
return 0;
}


int
f_10928_2082_2136(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10928, 2082, 2136);
return 0;
}


int
f_10928_2151_2183(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10928, 2151, 2183);
return 0;
}


bool
f_10928_2211_2243(Microsoft.CodeAnalysis.CSharp.Binder
this_param)
{
var return_v = this_param.IsSemanticModelBinder;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10928, 2211, 2243);
return return_v;
}


int
f_10928_2198_2244(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10928, 2198, 2244);
return 0;
}


Microsoft.CodeAnalysis.CSharp.SpeculativeSyntaxTreeSemanticModel
f_10928_2284_2386(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
parentSemanticModel,Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
root,Microsoft.CodeAnalysis.CSharp.Binder
rootBinder,int
position,Microsoft.CodeAnalysis.SpeculativeBindingOption
bindingOption)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.SpeculativeSyntaxTreeSemanticModel( parentSemanticModel, root, rootBinder, position, bindingOption);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10928, 2284, 2386);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10928,1740,2436);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10928,1740,2436);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private SpeculativeSyntaxTreeSemanticModel(SyntaxTreeSemanticModel parentSemanticModel, CSharpSyntaxNode root, Binder rootBinder, int position, SpeculativeBindingOption bindingOption)
:base(f_10928_2652_2683_C(f_10928_2652_2683(parentSemanticModel)) ,f_10928_2685_2715(parentSemanticModel),f_10928_2717_2732(root))
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(10928,2448,2958);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,855,875);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,920,925);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,960,971);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,1003,1012);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,1065,1079);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,2758,2801);

_parentSemanticModel = parentSemanticModel;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,2815,2828);

_root = root;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,2842,2867);

_rootBinder = rootBinder;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,2881,2902);

_position = position;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,2916,2947);

_bindingOption = bindingOption;
DynAbs.Tracing.TraceSender.TraceExitConstructor(10928,2448,2958);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10928,2448,2958);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10928,2448,2958);
}
		}

public override bool IsSpeculativeSemanticModel
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10928,3042,3105);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,3078,3090);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(10928,3042,3105);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10928,2970,3116);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10928,2970,3116);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override int OriginalPositionForSpeculation
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10928,3203,3271);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,3239,3256);

return _position;
DynAbs.Tracing.TraceSender.TraceExitMethod(10928,3203,3271);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10928,3128,3282);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10928,3128,3282);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override CSharpSemanticModel ParentModel
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10928,3366,3445);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,3402,3430);

return _parentSemanticModel;
DynAbs.Tracing.TraceSender.TraceExitMethod(10928,3366,3445);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10928,3294,3456);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10928,3294,3456);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override CSharpSyntaxNode Root
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10928,3532,3596);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,3568,3581);

return _root;
DynAbs.Tracing.TraceSender.TraceExitMethod(10928,3532,3596);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10928,3468,3607);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10928,3468,3607);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override BoundNode Bind(Binder binder, CSharpSyntaxNode node, DiagnosticBag diagnostics)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10928,3619,3812);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,3741,3801);

return f_10928_3748_3800(_parentSemanticModel, binder, node, diagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(10928,3619,3812);

Microsoft.CodeAnalysis.CSharp.BoundNode
f_10928_3748_3800(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
this_param,Microsoft.CodeAnalysis.CSharp.Binder
binder,Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
node,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics)
{
var return_v = this_param.Bind( binder, node, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10928, 3748, 3800);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10928,3619,3812);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10928,3619,3812);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override Binder GetEnclosingBinderInternal(int position)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10928,3824,3944);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,3914,3933);

return _rootBinder;
DynAbs.Tracing.TraceSender.TraceExitMethod(10928,3824,3944);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10928,3824,3944);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10928,3824,3944);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private SpeculativeBindingOption GetSpeculativeBindingOption(ExpressionSyntax node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10928,3956,4264);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,4064,4215) || true) && (f_10928_4068_4112(node))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10928,4064,4215);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,4146,4200);

return SpeculativeBindingOption.BindAsTypeOrNamespace;
DynAbs.Tracing.TraceSender.TraceExitCondition(10928,4064,4215);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,4231,4253);

return _bindingOption;
DynAbs.Tracing.TraceSender.TraceExitMethod(10928,3956,4264);

bool
f_10928_4068_4112(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
node)
{
var return_v = SyntaxFacts.IsInNamespaceOrTypeContext( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10928, 4068, 4112);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10928,3956,4264);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10928,3956,4264);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override SymbolInfo GetSymbolInfoWorker(CSharpSyntaxNode node, SymbolInfoOptions options, CancellationToken cancellationToken = default(CancellationToken))
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10928,4276,5215);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,4465,4495);

var 
cref = node as CrefSyntax
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,4509,4653) || true) && (cref != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10928,4509,4653);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,4559,4638);

return f_10928_4566_4637(_parentSemanticModel, _position, cref, options);
DynAbs.Tracing.TraceSender.TraceExitCondition(10928,4509,4653);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,4669,4709);

var 
expression = (ExpressionSyntax)node
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,4725,5066) || true) && ((options & SymbolInfoOptions.PreserveAliases) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10928,4725,5066);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,4813,4945);

var 
aliasSymbol = f_10928_4831_4944(_parentSemanticModel, _position, expression, f_10928_4899_4943(this, expression))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,4963,5051);

return f_10928_4970_5050(aliasSymbol, ImmutableArray<ISymbol>.Empty, CandidateReason.None);
DynAbs.Tracing.TraceSender.TraceExitCondition(10928,4725,5066);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,5082,5204);

return f_10928_5089_5203(_parentSemanticModel, _position, expression, f_10928_5158_5202(this, expression));
DynAbs.Tracing.TraceSender.TraceExitMethod(10928,4276,5215);

Microsoft.CodeAnalysis.SymbolInfo
f_10928_4566_4637(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
this_param,int
position,Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
cref,Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel.SymbolInfoOptions
options)
{
var return_v = this_param.GetSpeculativeSymbolInfo( position, cref, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10928, 4566, 4637);
return return_v;
}


Microsoft.CodeAnalysis.SpeculativeBindingOption
f_10928_4899_4943(Microsoft.CodeAnalysis.CSharp.SpeculativeSyntaxTreeSemanticModel
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
node)
{
var return_v = this_param.GetSpeculativeBindingOption( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10928, 4899, 4943);
return return_v;
}


Microsoft.CodeAnalysis.IAliasSymbol?
f_10928_4831_4944(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
this_param,int
position,Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
nameSyntax,Microsoft.CodeAnalysis.SpeculativeBindingOption
bindingOption)
{
var return_v = this_param.GetSpeculativeAliasInfo( position, (Microsoft.CodeAnalysis.SyntaxNode)nameSyntax, bindingOption);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10928, 4831, 4944);
return return_v;
}


Microsoft.CodeAnalysis.SymbolInfo
f_10928_4970_5050(Microsoft.CodeAnalysis.IAliasSymbol?
symbol,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
candidateSymbols,Microsoft.CodeAnalysis.CandidateReason
candidateReason)
{
var return_v = new Microsoft.CodeAnalysis.SymbolInfo( (Microsoft.CodeAnalysis.ISymbol?)symbol, candidateSymbols, candidateReason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10928, 4970, 5050);
return return_v;
}


Microsoft.CodeAnalysis.SpeculativeBindingOption
f_10928_5158_5202(Microsoft.CodeAnalysis.CSharp.SpeculativeSyntaxTreeSemanticModel
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
node)
{
var return_v = this_param.GetSpeculativeBindingOption( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10928, 5158, 5202);
return return_v;
}


Microsoft.CodeAnalysis.SymbolInfo
f_10928_5089_5203(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
this_param,int
position,Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
expression,Microsoft.CodeAnalysis.SpeculativeBindingOption
bindingOption)
{
var return_v = this_param.GetSpeculativeSymbolInfo( position, expression, bindingOption);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10928, 5089, 5203);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10928,4276,5215);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10928,4276,5215);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override CSharpTypeInfo GetTypeInfoWorker(CSharpSyntaxNode node, CancellationToken cancellationToken = default(CancellationToken))
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10928,5227,5582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,5391,5431);

var 
expression = (ExpressionSyntax)node
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10928,5445,5571);

return f_10928_5452_5570(_parentSemanticModel, _position, expression, f_10928_5525_5569(this, expression));
DynAbs.Tracing.TraceSender.TraceExitMethod(10928,5227,5582);

Microsoft.CodeAnalysis.SpeculativeBindingOption
f_10928_5525_5569(Microsoft.CodeAnalysis.CSharp.SpeculativeSyntaxTreeSemanticModel
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
node)
{
var return_v = this_param.GetSpeculativeBindingOption( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10928, 5525, 5569);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpTypeInfo
f_10928_5452_5570(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
this_param,int
position,Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
expression,Microsoft.CodeAnalysis.SpeculativeBindingOption
bindingOption)
{
var return_v = this_param.GetSpeculativeTypeInfoWorker( position, expression, bindingOption);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10928, 5452, 5570);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10928,5227,5582);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10928,5227,5582);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static SpeculativeSyntaxTreeSemanticModel()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10928,722,5589);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10928,722,5589);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10928,722,5589);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10928,722,5589);

static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_10928_2652_2683(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10928, 2652, 2683);
return return_v;
}


static Microsoft.CodeAnalysis.SyntaxTree
f_10928_2685_2715(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
this_param)
{
var return_v = this_param.SyntaxTree;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10928, 2685, 2715);
return return_v;
}


static Microsoft.CodeAnalysis.SyntaxTree
f_10928_2717_2732(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
this_param)
{
var return_v = this_param.SyntaxTree;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10928, 2717, 2732);
return return_v;
}


static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_10928_2652_2683_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(10928, 2448, 2958);
return return_v;
}

}
}
