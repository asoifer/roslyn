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
internal sealed class InitializerSemanticModel : MemberSemanticModel
{
private InitializerSemanticModel(CSharpSyntaxNode syntax,
                                     Symbol symbol,
                                     Binder rootBinder,
                                     SyntaxTreeSemanticModel containingSemanticModelOpt = null,
                                     SyntaxTreeSemanticModel parentSemanticModelOpt = null,
                                     ImmutableDictionary<Symbol, Symbol> parentRemappedSymbolsOpt = null,
                                     int speculatedPosition = 0) :base(f_10922_1583_1589_C(syntax) ,symbol,rootBinder,containingSemanticModelOpt,parentSemanticModelOpt,snapshotManagerOpt: null,parentRemappedSymbolsOpt,speculatedPosition)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(10922,1032,1872);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,1759,1861);

f_10922_1759_1860(!(syntax is ConstructorInitializerSyntax ||(DynAbs.Tracing.TraceSender.Expression_False(10922, 1774, 1858)||syntax is PrimaryConstructorBaseTypeSyntax)));
DynAbs.Tracing.TraceSender.TraceExitConstructor(10922,1032,1872);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10922,1032,1872);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10922,1032,1872);
}
		}

internal static InitializerSemanticModel Create(SyntaxTreeSemanticModel containingSemanticModel, CSharpSyntaxNode syntax, FieldSymbol fieldSymbol, Binder rootBinder)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10922,2044,2523);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,2234,2280);

f_10922_2234_2279(containingSemanticModel != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,2294,2404);

f_10922_2294_2403(f_10922_2307_2351(syntax, SyntaxKind.VariableDeclarator)||(DynAbs.Tracing.TraceSender.Expression_False(10922, 2307, 2402)||f_10922_2355_2402(syntax, SyntaxKind.EnumMemberDeclaration)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,2418,2512);

return f_10922_2425_2511(syntax, fieldSymbol, rootBinder, containingSemanticModel);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10922,2044,2523);

int
f_10922_2234_2279(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 2234, 2279);
return 0;
}


bool
f_10922_2307_2351(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 2307, 2351);
return return_v;
}


bool
f_10922_2355_2402(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 2355, 2402);
return return_v;
}


int
f_10922_2294_2403(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 2294, 2403);
return 0;
}


Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel
f_10922_2425_2511(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
symbol,Microsoft.CodeAnalysis.CSharp.Binder
rootBinder,Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
containingSemanticModelOpt)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel( syntax, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, rootBinder, containingSemanticModelOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 2425, 2511);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10922,2044,2523);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10922,2044,2523);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static InitializerSemanticModel Create(SyntaxTreeSemanticModel containingSemanticModel, CSharpSyntaxNode syntax, PropertySymbol propertySymbol, Binder rootBinder)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10922,2663,3101);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,2859,2905);

f_10922_2859_2904(containingSemanticModel != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,2919,2979);

f_10922_2919_2978(f_10922_2932_2977(syntax, SyntaxKind.PropertyDeclaration));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,2993,3090);

return f_10922_3000_3089(syntax, propertySymbol, rootBinder, containingSemanticModel);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10922,2663,3101);

int
f_10922_2859_2904(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 2859, 2904);
return 0;
}


bool
f_10922_2932_2977(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 2932, 2977);
return return_v;
}


int
f_10922_2919_2978(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 2919, 2978);
return 0;
}


Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel
f_10922_3000_3089(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
symbol,Microsoft.CodeAnalysis.CSharp.Binder
rootBinder,Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
containingSemanticModelOpt)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel( syntax, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, rootBinder, containingSemanticModelOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 3000, 3089);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10922,2663,3101);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10922,2663,3101);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static InitializerSemanticModel Create(SyntaxTreeSemanticModel containingSemanticModel, ParameterSyntax syntax, ParameterSymbol parameterSymbol, Binder rootBinder, ImmutableDictionary<Symbol, Symbol> parentRemappedSymbolsOpt)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10922,3228,3708);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,3487,3533);

f_10922_3487_3532(containingSemanticModel != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,3547,3697);

return f_10922_3554_3696(syntax, parameterSymbol, rootBinder, containingSemanticModel, parentRemappedSymbolsOpt: parentRemappedSymbolsOpt);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10922,3228,3708);

int
f_10922_3487_3532(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 3487, 3532);
return 0;
}


Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel
f_10922_3554_3696(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
symbol,Microsoft.CodeAnalysis.CSharp.Binder
rootBinder,Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
containingSemanticModelOpt,System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
parentRemappedSymbolsOpt)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, rootBinder, containingSemanticModelOpt, parentRemappedSymbolsOpt: parentRemappedSymbolsOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 3554, 3696);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10922,3228,3708);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10922,3228,3708);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static InitializerSemanticModel CreateSpeculative(SyntaxTreeSemanticModel parentSemanticModel, Symbol owner, CSharpSyntaxNode syntax, Binder rootBinder, ImmutableDictionary<Symbol, Symbol> parentRemappedSymbolsOpt, int position)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10922,3975,4719);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,4237,4279);

f_10922_4237_4278(parentSemanticModel != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,4293,4322);

f_10922_4293_4321(syntax != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,4336,4394);

f_10922_4336_4393(f_10922_4349_4392(syntax, SyntaxKind.EqualsValueClause));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,4408,4441);

f_10922_4408_4440(rootBinder != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,4455,4502);

f_10922_4455_4501(f_10922_4468_4500(rootBinder));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,4518,4708);

return f_10922_4525_4707(syntax, owner, rootBinder, parentSemanticModelOpt: parentSemanticModel, parentRemappedSymbolsOpt: parentRemappedSymbolsOpt, speculatedPosition: position);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10922,3975,4719);

int
f_10922_4237_4278(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 4237, 4278);
return 0;
}


int
f_10922_4293_4321(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 4293, 4321);
return 0;
}


bool
f_10922_4349_4392(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
node,Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = node.IsKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 4349, 4392);
return return_v;
}


int
f_10922_4336_4393(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 4336, 4393);
return 0;
}


int
f_10922_4408_4440(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 4408, 4440);
return 0;
}


bool
f_10922_4468_4500(Microsoft.CodeAnalysis.CSharp.Binder
this_param)
{
var return_v = this_param.IsSemanticModelBinder;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 4468, 4500);
return return_v;
}


int
f_10922_4455_4501(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 4455, 4501);
return 0;
}


Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel
f_10922_4525_4707(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbol
symbol,Microsoft.CodeAnalysis.CSharp.Binder
rootBinder,Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
parentSemanticModelOpt,System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
parentRemappedSymbolsOpt,int
speculatedPosition)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel( syntax, symbol, rootBinder, parentSemanticModelOpt: parentSemanticModelOpt, parentRemappedSymbolsOpt: parentRemappedSymbolsOpt, speculatedPosition: speculatedPosition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 4525, 4707);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10922,3975,4719);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10922,3975,4719);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected internal override CSharpSyntaxNode GetBindableSyntaxNode(CSharpSyntaxNode node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10922,4731,4933);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,4845,4922);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10922, 4852, 4879)||((f_10922_4852_4879(this, node)&&DynAbs.Tracing.TraceSender.Conditional_F2(10922, 4882, 4886))||DynAbs.Tracing.TraceSender.Conditional_F3(10922, 4889, 4921)))?node :DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetBindableSyntaxNode(node),10922,4889,4921);
DynAbs.Tracing.TraceSender.TraceExitMethod(10922,4731,4933);

bool
f_10922_4852_4879(Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel
this_param,Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
node)
{
var return_v = this_param.IsBindableInitializer( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 4852, 4879);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10922,4731,4933);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10922,4731,4933);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override BoundNode GetBoundRoot()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10922,4945,6134);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,5012,5052);

CSharpSyntaxNode 
rootSyntax = f_10922_5042_5051(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,5066,6047);

switch (f_10922_5074_5091(rootSyntax))
            {

case SyntaxKind.VariableDeclarator:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10922,5066,6047);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,5182,5246);

rootSyntax = f_10922_5195_5245(((VariableDeclaratorSyntax)rootSyntax));
DynAbs.Tracing.TraceSender.TraceBreak(10922,5268,5274);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10922,5066,6047);

case SyntaxKind.Parameter:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10922,5066,6047);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,5342,5393);

rootSyntax = f_10922_5355_5392(((ParameterSyntax)rootSyntax));
DynAbs.Tracing.TraceSender.TraceBreak(10922,5415,5421);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10922,5066,6047);

case SyntaxKind.EqualsValueClause:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10922,5066,6047);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,5497,5548);

rootSyntax = ((EqualsValueClauseSyntax)rootSyntax);
DynAbs.Tracing.TraceSender.TraceBreak(10922,5570,5576);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10922,5066,6047);

case SyntaxKind.EnumMemberDeclaration:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10922,5066,6047);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,5656,5723);

rootSyntax = f_10922_5669_5722(((EnumMemberDeclarationSyntax)rootSyntax));
DynAbs.Tracing.TraceSender.TraceBreak(10922,5745,5751);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10922,5066,6047);

case SyntaxKind.PropertyDeclaration:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10922,5066,6047);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,5829,5894);

rootSyntax = f_10922_5842_5893(((PropertyDeclarationSyntax)rootSyntax));
DynAbs.Tracing.TraceSender.TraceBreak(10922,5916,5922);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10922,5066,6047);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10922,5066,6047);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,5972,6032);

throw f_10922_5978_6031(f_10922_6013_6030(rootSyntax));
DynAbs.Tracing.TraceSender.TraceExitCondition(10922,5066,6047);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,6063,6123);

return f_10922_6070_6122(this, f_10922_6088_6121(this, rootSyntax));
DynAbs.Tracing.TraceSender.TraceExitMethod(10922,4945,6134);

Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
f_10922_5042_5051(Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel
this_param)
{
var return_v = this_param.Root;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 5042, 5051);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10922_5074_5091(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
this_param)
{
var return_v = this_param.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 5074, 5091);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
f_10922_5195_5245(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
this_param)
{
var return_v = this_param.Initializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 5195, 5245);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
f_10922_5355_5392(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
this_param)
{
var return_v = this_param.Default;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 5355, 5392);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
f_10922_5669_5722(Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax
this_param)
{
var return_v = this_param.EqualsValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 5669, 5722);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
f_10922_5842_5893(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
this_param)
{
var return_v = this_param.Initializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 5842, 5893);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10922_6013_6030(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
this_param)
{
var return_v = this_param.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 6013, 6030);
return return_v;
}


System.Exception
f_10922_5978_6031(Microsoft.CodeAnalysis.CSharp.SyntaxKind
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 5978, 6031);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
f_10922_6088_6121(Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel
this_param,Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
node)
{
var return_v = this_param.GetBindableSyntaxNode( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 6088, 6121);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNode
f_10922_6070_6122(Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel
this_param,Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
node)
{
var return_v = this_param.GetUpperBoundNode( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 6070, 6122);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10922,4945,6134);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10922,4945,6134);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override BoundNode Bind(Binder binder, CSharpSyntaxNode node, DiagnosticBag diagnostics)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10922,6146,7381);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,6268,6311);

EqualsValueClauseSyntax 
equalsValue = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,6327,7165);

switch (f_10922_6335_6346(node))
            {

case SyntaxKind.EqualsValueClause:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10922,6327,7165);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,6436,6480);

equalsValue = (EqualsValueClauseSyntax)node;
DynAbs.Tracing.TraceSender.TraceBreak(10922,6502,6508);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10922,6327,7165);

case SyntaxKind.VariableDeclarator:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10922,6327,7165);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,6585,6644);

equalsValue = f_10922_6599_6643(((VariableDeclaratorSyntax)node));
DynAbs.Tracing.TraceSender.TraceBreak(10922,6666,6672);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10922,6327,7165);

case SyntaxKind.PropertyDeclaration:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10922,6327,7165);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,6750,6810);

equalsValue = f_10922_6764_6809(((PropertyDeclarationSyntax)node));
DynAbs.Tracing.TraceSender.TraceBreak(10922,6832,6838);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10922,6327,7165);

case SyntaxKind.Parameter:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10922,6327,7165);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,6906,6952);

equalsValue = f_10922_6920_6951(((ParameterSyntax)node));
DynAbs.Tracing.TraceSender.TraceBreak(10922,6974,6980);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10922,6327,7165);

case SyntaxKind.EnumMemberDeclaration:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10922,6327,7165);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,7060,7122);

equalsValue = f_10922_7074_7121(((EnumMemberDeclarationSyntax)node));
DynAbs.Tracing.TraceSender.TraceBreak(10922,7144,7150);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10922,6327,7165);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,7181,7310) || true) && (equalsValue != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10922,7181,7310);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,7238,7295);

return f_10922_7245_7294(this, binder, equalsValue, diagnostics);
DynAbs.Tracing.TraceSender.TraceExitCondition(10922,7181,7310);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,7326,7370);

return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Bind(binder,node,diagnostics),10922,7333,7369);
DynAbs.Tracing.TraceSender.TraceExitMethod(10922,6146,7381);

Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10922_6335_6346(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
this_param)
{
var return_v = this_param.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 6335, 6346);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
f_10922_6599_6643(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
this_param)
{
var return_v = this_param.Initializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 6599, 6643);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
f_10922_6764_6809(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
this_param)
{
var return_v = this_param.Initializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 6764, 6809);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
f_10922_6920_6951(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
this_param)
{
var return_v = this_param.Default;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 6920, 6951);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
f_10922_7074_7121(Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax
this_param)
{
var return_v = this_param.EqualsValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 7074, 7121);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundEqualsValue
f_10922_7245_7294(Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel
this_param,Microsoft.CodeAnalysis.CSharp.Binder
binder,Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
equalsValue,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics)
{
var return_v = this_param.BindEqualsValue( binder, equalsValue, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 7245, 7294);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10922,6146,7381);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10922,6146,7381);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundEqualsValue BindEqualsValue(Binder binder, EqualsValueClauseSyntax equalsValue, DiagnosticBag diagnostics)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10922,7393,9174);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,7537,9163);

switch (f_10922_7545_7567(f_10922_7545_7562(this)))
            {

case SymbolKind.Field:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10922,7537,9163);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,7672,7715);

var 
field = (FieldSymbol)f_10922_7697_7714(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,7741,7791);

var 
enumField = field as SourceEnumConstantSymbol
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,7817,8192) || true) && ((object)enumField != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10922,7817,8192);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,7904,7983);

return f_10922_7911_7982(binder, enumField, equalsValue, diagnostics);
DynAbs.Tracing.TraceSender.TraceExitCondition(10922,7817,8192);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10922,7817,8192);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,8097,8165);

return f_10922_8104_8164(binder, field, equalsValue, diagnostics);
DynAbs.Tracing.TraceSender.TraceExitCondition(10922,7817,8192);
}
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(10922,7537,9163);

case SymbolKind.Property:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10922,7537,9163);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,8309,8364);

var 
property = (SourcePropertySymbol)f_10922_8346_8363(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,8390,8498);

BoundFieldEqualsValue 
result = f_10922_8421_8497(binder, f_10922_8449_8470(property), equalsValue, diagnostics)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,8524,8614);

return f_10922_8531_8613(result.Syntax, property, f_10922_8585_8598(result), f_10922_8600_8612(result));
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(10922,7537,9163);

case SymbolKind.Parameter:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10922,7537,9163);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,8732,8783);

var 
parameter = (ParameterSymbol)f_10922_8765_8782(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,8809,9010);

return f_10922_8816_9009(binder, equalsValue, parameter, diagnostics, out _);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(10922,7537,9163);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10922,7537,9163);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,9083,9148);

throw f_10922_9089_9147(f_10922_9124_9146(f_10922_9124_9141(this)));
DynAbs.Tracing.TraceSender.TraceExitCondition(10922,7537,9163);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(10922,7393,9174);

Microsoft.CodeAnalysis.CSharp.Symbol
f_10922_7545_7562(Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel
this_param)
{
var return_v = this_param.MemberSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 7545, 7562);
return return_v;
}


Microsoft.CodeAnalysis.SymbolKind
f_10922_7545_7567(Microsoft.CodeAnalysis.CSharp.Symbol
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 7545, 7567);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10922_7697_7714(Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel
this_param)
{
var return_v = this_param.MemberSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 7697, 7714);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue
f_10922_7911_7982(Microsoft.CodeAnalysis.CSharp.Binder
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.SourceEnumConstantSymbol
symbol,Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
equalsValueSyntax,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics)
{
var return_v = this_param.BindEnumConstantInitializer( symbol, equalsValueSyntax, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 7911, 7982);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue
f_10922_8104_8164(Microsoft.CodeAnalysis.CSharp.Binder
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
field,Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
initializerOpt,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics)
{
var return_v = this_param.BindFieldInitializer( field, initializerOpt, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 8104, 8164);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10922_8346_8363(Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel
this_param)
{
var return_v = this_param.MemberSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 8346, 8363);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedBackingFieldSymbol
f_10922_8449_8470(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
this_param)
{
var return_v = this_param.BackingField;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 8449, 8470);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue
f_10922_8421_8497(Microsoft.CodeAnalysis.CSharp.Binder
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedBackingFieldSymbol
field,Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
initializerOpt,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics)
{
var return_v = this_param.BindFieldInitializer( (Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)field, initializerOpt, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 8421, 8497);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10922_8585_8598(Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue
this_param)
{
var return_v = this_param.Locals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 8585, 8598);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10922_8600_8612(Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 8600, 8612);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundPropertyEqualsValue
f_10922_8531_8613(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
property,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,Microsoft.CodeAnalysis.CSharp.BoundExpression
value)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundPropertyEqualsValue( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol)property, locals, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 8531, 8613);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10922_8765_8782(Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel
this_param)
{
var return_v = this_param.MemberSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 8765, 8782);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundParameterEqualsValue
f_10922_8816_9009(Microsoft.CodeAnalysis.CSharp.Binder
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
defaultValueSyntax,Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
parameter,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,out Microsoft.CodeAnalysis.CSharp.BoundExpression
valueBeforeConversion)
{
var return_v = this_param.BindParameterDefaultValue( defaultValueSyntax, parameter, diagnostics, out valueBeforeConversion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 8816, 9009);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10922_9124_9141(Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel
this_param)
{
var return_v = this_param.MemberSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 9124, 9141);
return return_v;
}


Microsoft.CodeAnalysis.SymbolKind
f_10922_9124_9146(Microsoft.CodeAnalysis.CSharp.Symbol
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 9124, 9146);
return return_v;
}


System.Exception
f_10922_9089_9147(Microsoft.CodeAnalysis.SymbolKind
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 9089, 9147);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10922,7393,9174);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10922,7393,9174);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool IsBindableInitializer(CSharpSyntaxNode node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10922,9186,9843);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,9504,9832);

switch (f_10922_9512_9523(node))
            {

case SyntaxKind.EqualsValueClause:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10922,9504,9832);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,9613,9754);

return f_10922_9620_9629(this)== node ||(DynAbs.Tracing.TraceSender.Expression_False(10922, 9620, 9731)||f_10922_9707_9716(this)== f_10922_9720_9731(node));
DynAbs.Tracing.TraceSender.TraceExitCondition(10922,9504,9832);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10922,9504,9832);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,9804,9817);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10922,9504,9832);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(10922,9186,9843);

Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10922_9512_9523(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
this_param)
{
var return_v = this_param.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 9512, 9523);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
f_10922_9620_9629(Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel
this_param)
{
var return_v = this_param.Root ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 9620, 9629);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
f_10922_9707_9716(Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel
this_param)
{
var return_v = this_param.Root ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 9707, 9716);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
f_10922_9720_9731(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
this_param)
{
var return_v = this_param.Parent /*field initializer*/;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 9720, 9731);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10922,9186,9843);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10922,9186,9843);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, EqualsValueClauseSyntax initializer, out SemanticModel speculativeModel)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10922,9855,10521);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,10061,10108);

var 
binder = f_10922_10074_10107(this, position)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,10122,10244) || true) && (binder == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10922,10122,10244);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,10174,10198);

speculativeModel = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,10216,10229);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10922,10122,10244);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,10260,10348);

binder = f_10922_10269_10347(initializer, f_10922_10307_10338(binder), binder);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,10362,10484);

speculativeModel = f_10922_10381_10483(parentModel, f_10922_10412_10429(this), initializer, binder, f_10922_10452_10472(this), position);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,10498,10510);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(10922,9855,10521);

Microsoft.CodeAnalysis.CSharp.Binder
f_10922_10074_10107(Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel
this_param,int
position)
{
var return_v = this_param.GetEnclosingBinder( position);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 10074, 10107);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol?
f_10922_10307_10338(Microsoft.CodeAnalysis.CSharp.Binder
this_param)
{
var return_v = this_param.ContainingMemberOrLambda;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 10307, 10338);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
f_10922_10269_10347(Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
root,Microsoft.CodeAnalysis.CSharp.Symbol?
memberSymbol,Microsoft.CodeAnalysis.CSharp.Binder
next)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder( (Microsoft.CodeAnalysis.SyntaxNode)root, memberSymbol, next);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 10269, 10347);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10922_10412_10429(Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel
this_param)
{
var return_v = this_param.MemberSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 10412, 10429);
return return_v;
}


System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
f_10922_10452_10472(Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel
this_param)
{
var return_v = this_param.GetRemappedSymbols();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 10452, 10472);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel
f_10922_10381_10483(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
parentSemanticModel,Microsoft.CodeAnalysis.CSharp.Symbol
owner,Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
syntax,Microsoft.CodeAnalysis.CSharp.Binder
rootBinder,System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
parentRemappedSymbolsOpt,int
position)
{
var return_v = CreateSpeculative( parentSemanticModel, owner, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, rootBinder, parentRemappedSymbolsOpt, position);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 10381, 10483);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10922,9855,10521);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10922,9855,10521);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, ConstructorInitializerSyntax constructorInitializer, out SemanticModel speculativeModel)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10922,10533,10817);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,10755,10779);

speculativeModel = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,10793,10806);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(10922,10533,10817);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10922,10533,10817);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10922,10533,10817);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, PrimaryConstructorBaseTypeSyntax constructorInitializer, out SemanticModel speculativeModel)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10922,10829,11117);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,11055,11079);

speculativeModel = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,11093,11106);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(10922,10829,11117);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10922,10829,11117);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10922,10829,11117);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, ArrowExpressionClauseSyntax expressionBody, out SemanticModel speculativeModel)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10922,11129,11404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,11342,11366);

speculativeModel = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,11380,11393);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(10922,11129,11404);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10922,11129,11404);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10922,11129,11404);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, StatementSyntax statement, out SemanticModel speculativeModel)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10922,11416,11674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,11612,11636);

speculativeModel = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,11650,11663);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(10922,11416,11674);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10922,11416,11674);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10922,11416,11674);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool TryGetSpeculativeSemanticModelForMethodBodyCore(SyntaxTreeSemanticModel parentModel, int position, BaseMethodDeclarationSyntax method, out SemanticModel speculativeModel)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10922,11686,11966);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,11904,11928);

speculativeModel = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,11942,11955);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(10922,11686,11966);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10922,11686,11966);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10922,11686,11966);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool TryGetSpeculativeSemanticModelForMethodBodyCore(SyntaxTreeSemanticModel parentModel, int position, AccessorDeclarationSyntax accessor, out SemanticModel speculativeModel)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10922,11978,12258);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,12196,12220);

speculativeModel = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,12234,12247);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(10922,11978,12258);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10922,11978,12258);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10922,11978,12258);
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
DynAbs.Tracing.TraceSender.TraceEnterMethod(10922,12270,13001);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,12812,12990);

return f_10922_12819_12989(f_10922_12852_12863(), f_10922_12865_12877(), boundRoot, binder, initialState: null, diagnostics, createSnapshots, out snapshotManager, ref remappedSymbols);
DynAbs.Tracing.TraceSender.TraceExitMethod(10922,12270,13001);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_10922_12852_12863()
{
var return_v = Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 12852, 12863);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10922_12865_12877()
{
var return_v = MemberSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 12865, 12877);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNode
f_10922_12819_12989(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Symbol
symbol,Microsoft.CodeAnalysis.CSharp.BoundNode
node,Microsoft.CodeAnalysis.CSharp.Binder
binder,Microsoft.CodeAnalysis.CSharp.NullableWalker.VariableState?
initialState,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,bool
createSnapshots,out Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager
snapshotManager,ref System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
remappedSymbols)
{
var return_v = NullableWalker.AnalyzeAndRewrite( compilation, symbol, node, binder, initialState: initialState, diagnostics, createSnapshots, out snapshotManager, ref remappedSymbols);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 12819, 12989);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10922,12270,13001);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10922,12270,13001);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override void AnalyzeBoundNodeNullability(BoundNode boundRoot, Binder binder, DiagnosticBag diagnostics, bool createSnapshots)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10922,13013,13298);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,13174,13287);

f_10922_13174_13286(f_10922_13211_13222(), f_10922_13224_13236(), boundRoot, binder, diagnostics, createSnapshots);
DynAbs.Tracing.TraceSender.TraceExitMethod(10922,13013,13298);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_10922_13211_13222()
{
var return_v = Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 13211, 13222);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10922_13224_13236()
{
var return_v = MemberSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 13224, 13236);
return return_v;
}


int
f_10922_13174_13286(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Symbol
symbol,Microsoft.CodeAnalysis.CSharp.BoundNode
node,Microsoft.CodeAnalysis.CSharp.Binder
binder,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,bool
createSnapshots)
{
NullableWalker.AnalyzeWithoutRewrite( compilation, symbol, node, binder, diagnostics, createSnapshots);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 13174, 13286);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10922,13013,13298);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10922,13013,13298);
}
		}

protected override bool IsNullableAnalysisEnabled()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10922,13330,14240);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,13406,14229);

switch (f_10922_13414_13431(f_10922_13414_13426()))
            {

case SymbolKind.Field:
                case SymbolKind.Property:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10922,13406,14229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,13552,13629);

f_10922_13552_13628(f_10922_13565_13592(f_10922_13565_13577())is SourceMemberContainerTypeSymbol);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,13651,13841);

return f_10922_13658_13685(f_10922_13658_13670())is SourceMemberContainerTypeSymbol type &&(DynAbs.Tracing.TraceSender.Expression_True(10922, 13658, 13840)&&f_10922_13754_13840(                        type, useStatic: f_10922_13818_13839(f_10922_13818_13830())));
DynAbs.Tracing.TraceSender.TraceExitCondition(10922,13406,14229);

case SymbolKind.Parameter:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10922,13406,14229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,13907,14106);

return f_10922_13914_14017(f_10922_13993_13997()as ParameterSyntax)is { } value &&(DynAbs.Tracing.TraceSender.Expression_True(10922, 13914, 14105)&&f_10922_14059_14105(f_10922_14059_14070(), value));
DynAbs.Tracing.TraceSender.TraceExitCondition(10922,13406,14229);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10922,13406,14229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10922,14154,14214);

throw f_10922_14160_14213(f_10922_14195_14212(f_10922_14195_14207()));
DynAbs.Tracing.TraceSender.TraceExitCondition(10922,13406,14229);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(10922,13330,14240);

Microsoft.CodeAnalysis.CSharp.Symbol
f_10922_13414_13426()
{
var return_v = MemberSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 13414, 13426);
return return_v;
}


Microsoft.CodeAnalysis.SymbolKind
f_10922_13414_13431(Microsoft.CodeAnalysis.CSharp.Symbol
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 13414, 13431);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10922_13565_13577()
{
var return_v = MemberSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 13565, 13577);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10922_13565_13592(Microsoft.CodeAnalysis.CSharp.Symbol
this_param)
{
var return_v = this_param.ContainingType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 13565, 13592);
return return_v;
}


int
f_10922_13552_13628(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 13552, 13628);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10922_13658_13670()
{
var return_v = MemberSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 13658, 13670);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10922_13658_13685(Microsoft.CodeAnalysis.CSharp.Symbol
this_param)
{
var return_v = this_param.ContainingType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 13658, 13685);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10922_13818_13830()
{
var return_v = MemberSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 13818, 13830);
return return_v;
}


bool
f_10922_13818_13839(Microsoft.CodeAnalysis.CSharp.Symbol
this_param)
{
var return_v = this_param.IsStatic;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 13818, 13839);
return return_v;
}


bool
f_10922_13754_13840(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
this_param,bool
useStatic)
{
var return_v = this_param.IsNullableEnabledForConstructorsAndInitializers( useStatic: useStatic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 13754, 13840);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
f_10922_13993_13997()
{
var return_v = Root;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 13993, 13997);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode?
f_10922_13914_14017(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
parameterSyntax)
{
var return_v = SourceComplexParameterSymbol.GetDefaultValueSyntaxForIsNullableAnalysisEnabled( (Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax?)parameterSyntax);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 13914, 14017);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_10922_14059_14070()
{
var return_v = Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 14059, 14070);
return return_v;
}


bool
f_10922_14059_14105(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax)
{
var return_v = this_param.IsNullableAnalysisEnabledIn( syntax);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 14059, 14105);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10922_14195_14207()
{
var return_v = MemberSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 14195, 14207);
return return_v;
}


Microsoft.CodeAnalysis.SymbolKind
f_10922_14195_14212(Microsoft.CodeAnalysis.CSharp.Symbol
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10922, 14195, 14212);
return return_v;
}


System.Exception
f_10922_14160_14213(Microsoft.CodeAnalysis.SymbolKind
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 14160, 14213);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10922,13330,14240);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10922,13330,14240);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static InitializerSemanticModel()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10922,775,14247);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10922,775,14247);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10922,775,14247);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10922,775,14247);

int
f_10922_1759_1860(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10922, 1759, 1860);
return 0;
}


static Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
f_10922_1583_1589_C(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(10922, 1032, 1872);
return return_v;
}

}
}
