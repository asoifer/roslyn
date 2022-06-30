// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.Cci;
using Roslyn.Utilities;
using System.Collections.Generic;
using System.Diagnostics;
using System;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis.Emit
{
internal abstract class SymbolChanges
{
private readonly DefinitionMap _definitionMap;

private readonly IReadOnlyDictionary<ISymbol, SymbolChange> _changes;

private readonly Func<ISymbol, bool> _isAddedSymbol;

protected SymbolChanges(DefinitionMap definitionMap, IEnumerable<SemanticEdit> edits, Func<ISymbol, bool> isAddedSymbol)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(768,1056,1481);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,706,720);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,971,979);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,1029,1043);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,1201,1237);

f_768_1201_1236(definitionMap != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,1251,1279);

f_768_1251_1278(edits != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,1293,1329);

f_768_1293_1328(isAddedSymbol != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,1345,1376);

_definitionMap = definitionMap;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,1390,1421);

_isAddedSymbol = isAddedSymbol;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,1435,1470);

_changes = f_768_1446_1469(edits);
DynAbs.Tracing.TraceSender.TraceExitConstructor(768,1056,1481);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(768,1056,1481);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(768,1056,1481);
}
		}

public bool IsAdded(ISymbol symbol)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(768,1709,1810);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,1769,1799);

return f_768_1776_1798(this, symbol);
DynAbs.Tracing.TraceSender.TraceExitMethod(768,1709,1810);

bool
f_768_1776_1798(Microsoft.CodeAnalysis.Emit.SymbolChanges
this_param,Microsoft.CodeAnalysis.ISymbol
arg)
{
var return_v = this_param._isAddedSymbol( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 1776, 1798);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(768,1709,1810);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(768,1709,1810);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public bool RequiresCompilation(ISymbol symbol)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(768,1968,2102);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,2040,2091);

return f_768_2047_2069(this, symbol)!= SymbolChange.None;
DynAbs.Tracing.TraceSender.TraceExitMethod(768,1968,2102);

Microsoft.CodeAnalysis.Emit.SymbolChange
f_768_2047_2069(Microsoft.CodeAnalysis.Emit.SymbolChanges
this_param,Microsoft.CodeAnalysis.ISymbol
symbol)
{
var return_v = this_param.GetChange( symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 2047, 2069);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(768,1968,2102);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(768,1968,2102);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public SymbolChange GetChange(IDefinition def)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(768,2114,7213);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,2185,2234);

ISymbolInternal 
symbol = f_768_2210_2233(def)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,2248,2322);

var 
synthesizedDef = symbol as ISynthesizedMethodBodyImplementationSymbol
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,2336,6684) || true) && (synthesizedDef != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,2336,6684);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,2396,2440);

f_768_2396_2439(f_768_2409_2430(synthesizedDef)!= null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,2460,2498);

var 
generator = f_768_2476_2497(synthesizedDef)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,2516,2567);

ISymbolInternal 
synthesizedSymbol = synthesizedDef
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,2587,2650);

var 
change = f_768_2600_2649(this, f_768_2623_2648(generator))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,2668,6669);

switch (change)
                {

case SymbolChange.Updated:
DynAbs.Tracing.TraceSender.TraceEnterCondition(768,2668,6669);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,3155,3365) || true) && (!f_768_3160_3254(_definitionMap, f_768_3205_3253(f_768_3205_3237(synthesizedSymbol))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,3155,3365);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,3312,3338);

return SymbolChange.Added;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,3155,3365);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,3393,3753) || true) && (!f_768_3398_3434(_definitionMap, def))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,3393,3753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,3700,3726);

return SymbolChange.Added;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,3393,3753);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,4162,4315) || true) && (f_768_4166_4205_M(!synthesizedDef.HasMethodBodyDependency))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,4162,4315);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,4263,4288);

return SymbolChange.None;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,4162,4315);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,4458,4629) || true) && (f_768_4462_4484(synthesizedSymbol)== SymbolKind.NamedType)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,4458,4629);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,4566,4602);

return SymbolChange.ContainsChanges;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,4458,4629);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,4657,4890) || true) && (f_768_4661_4683(synthesizedSymbol)== SymbolKind.Method)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,4657,4890);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,4835,4863);

return SymbolChange.Updated;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,4657,4890);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,4918,4943);

return SymbolChange.None;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,2668,6669);

case SymbolChange.Added:
DynAbs.Tracing.TraceSender.TraceEnterCondition(768,2668,6669);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,5136,5288) || true) && (!f_768_5141_5177(_definitionMap, def))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,5136,5288);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,5235,5261);

return SymbolChange.Added;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,5136,5288);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,5625,5796) || true) && (f_768_5629_5651(synthesizedSymbol)== SymbolKind.NamedType)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,5625,5796);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,5733,5769);

return SymbolChange.ContainsChanges;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,5625,5796);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,6074,6234) || true) && (f_768_6078_6100(synthesizedSymbol)== SymbolKind.Method)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,6074,6234);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,6179,6207);

return SymbolChange.Updated;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,6074,6234);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,6409,6434);

return SymbolChange.None;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,2668,6669);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(768,2668,6669);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,6601,6650);

throw f_768_6607_6649(change);
DynAbs.Tracing.TraceSender.TraceExitCondition(768,2668,6669);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(768,2336,6684);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,6700,6807) || true) && (symbol is object)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,6700,6807);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,6754,6792);

return f_768_6761_6791(this, f_768_6771_6790(symbol));
DynAbs.Tracing.TraceSender.TraceExitCondition(768,6700,6807);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,6988,7160) || true) && (f_768_6992_7028(_definitionMap, def))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,6988,7160);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,7062,7145);

return (DynAbs.Tracing.TraceSender.Conditional_F1(768, 7069, 7093)||(((def is ITypeDefinition) &&DynAbs.Tracing.TraceSender.Conditional_F2(768, 7096, 7124))||DynAbs.Tracing.TraceSender.Conditional_F3(768, 7127, 7144)))?SymbolChange.ContainsChanges :SymbolChange.None;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,6988,7160);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,7176,7202);

return SymbolChange.Added;
DynAbs.Tracing.TraceSender.TraceExitMethod(768,2114,7213);

Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
f_768_2210_2233(Microsoft.Cci.IDefinition
this_param)
{
var return_v = this_param.GetInternalSymbol();
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 2210, 2233);
return return_v;
}


Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal?
f_768_2409_2430(Microsoft.CodeAnalysis.Symbols.ISynthesizedMethodBodyImplementationSymbol
this_param)
{
var return_v = this_param.Method ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(768, 2409, 2430);
return return_v;
}


int
f_768_2396_2439(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 2396, 2439);
return 0;
}


Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
f_768_2476_2497(Microsoft.CodeAnalysis.Symbols.ISynthesizedMethodBodyImplementationSymbol
this_param)
{
var return_v = this_param.Method;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(768, 2476, 2497);
return return_v;
}


Microsoft.Cci.IReference
f_768_2623_2648(Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
this_param)
{
var return_v = this_param.GetCciAdapter();
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 2623, 2648);
return return_v;
}


Microsoft.CodeAnalysis.Emit.SymbolChange
f_768_2600_2649(Microsoft.CodeAnalysis.Emit.SymbolChanges
this_param,Microsoft.Cci.IReference
def)
{
var return_v = this_param.GetChange( (Microsoft.Cci.IDefinition)def);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 2600, 2649);
return return_v;
}


Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal
f_768_3205_3237(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(768, 3205, 3237);
return return_v;
}


Microsoft.Cci.IReference
f_768_3205_3253(Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal
this_param)
{
var return_v = this_param.GetCciAdapter();
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 3205, 3253);
return return_v;
}


bool
f_768_3160_3254(Microsoft.CodeAnalysis.Emit.DefinitionMap
this_param,Microsoft.Cci.IReference
definition)
{
var return_v = this_param.DefinitionExists( (Microsoft.Cci.IDefinition)definition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 3160, 3254);
return return_v;
}


bool
f_768_3398_3434(Microsoft.CodeAnalysis.Emit.DefinitionMap
this_param,Microsoft.Cci.IDefinition
definition)
{
var return_v = this_param.DefinitionExists( definition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 3398, 3434);
return return_v;
}


bool
f_768_4166_4205_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(768, 4166, 4205);
return return_v;
}


Microsoft.CodeAnalysis.SymbolKind
f_768_4462_4484(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(768, 4462, 4484);
return return_v;
}


Microsoft.CodeAnalysis.SymbolKind
f_768_4661_4683(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(768, 4661, 4683);
return return_v;
}


bool
f_768_5141_5177(Microsoft.CodeAnalysis.Emit.DefinitionMap
this_param,Microsoft.Cci.IDefinition
definition)
{
var return_v = this_param.DefinitionExists( definition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 5141, 5177);
return return_v;
}


Microsoft.CodeAnalysis.SymbolKind
f_768_5629_5651(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(768, 5629, 5651);
return return_v;
}


Microsoft.CodeAnalysis.SymbolKind
f_768_6078_6100(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(768, 6078, 6100);
return return_v;
}


System.Exception
f_768_6607_6649(Microsoft.CodeAnalysis.Emit.SymbolChange
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 6607, 6649);
return return_v;
}


Microsoft.CodeAnalysis.ISymbol
f_768_6771_6790(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
this_param)
{
var return_v = this_param.GetISymbol();
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 6771, 6790);
return return_v;
}


Microsoft.CodeAnalysis.Emit.SymbolChange
f_768_6761_6791(Microsoft.CodeAnalysis.Emit.SymbolChanges
this_param,Microsoft.CodeAnalysis.ISymbol
symbol)
{
var return_v = this_param.GetChange( symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 6761, 6791);
return return_v;
}


bool
f_768_6992_7028(Microsoft.CodeAnalysis.Emit.DefinitionMap
this_param,Microsoft.Cci.IDefinition
definition)
{
var return_v = this_param.DefinitionExists( definition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 6992, 7028);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(768,2114,7213);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(768,2114,7213);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private SymbolChange GetChange(ISymbol symbol)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(768,7225,9214);
Microsoft.CodeAnalysis.Emit.SymbolChange change = default(Microsoft.CodeAnalysis.Emit.SymbolChange);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,7296,7407) || true) && (f_768_7300_7344(_changes, symbol, out change))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,7296,7407);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,7378,7392);

return change;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,7296,7407);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,7486,7530);

var 
container = f_768_7502_7529(symbol)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,7544,7639) || true) && (container == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,7544,7639);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,7599,7624);

return SymbolChange.None;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,7544,7639);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,7655,7698);

var 
containerChange = f_768_7677_7697(this, container)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,7712,9203);

switch (containerChange)
            {

case SymbolChange.Added:
DynAbs.Tracing.TraceSender.TraceEnterCondition(768,7712,9203);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,7899,7925);

return SymbolChange.Added;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,7712,9203);

case SymbolChange.None:
DynAbs.Tracing.TraceSender.TraceEnterCondition(768,7712,9203);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,8085,8110);

return SymbolChange.None;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,7712,9203);

case SymbolChange.Updated:
                case SymbolChange.ContainsChanges:
DynAbs.Tracing.TraceSender.TraceEnterCondition(768,7712,9203);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,8230,8294);

var 
adapter = f_768_8244_8293_I(f_768_8244_8276(this, symbol).GetCciAdapter())
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,8318,8622) || true) && (adapter is IDefinition definition)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,8318,8622);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,8507,8599);

return (DynAbs.Tracing.TraceSender.Conditional_F1(768, 8514, 8557)||((f_768_8514_8557(_definitionMap, definition)&&DynAbs.Tracing.TraceSender.Conditional_F2(768, 8560, 8577))||DynAbs.Tracing.TraceSender.Conditional_F3(768, 8580, 8598)))?SymbolChange.None :SymbolChange.Added;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,8318,8622);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,8646,9031) || true) && (adapter is INamespace @namespace)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,8646,9031);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,8906,9008);

return (DynAbs.Tracing.TraceSender.Conditional_F1(768, 8913, 8955)||((f_768_8913_8955(_definitionMap, @namespace)&&DynAbs.Tracing.TraceSender.Conditional_F2(768, 8958, 8986))||DynAbs.Tracing.TraceSender.Conditional_F3(768, 8989, 9007)))?SymbolChange.ContainsChanges :SymbolChange.Added;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,8646,9031);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,9055,9080);

return SymbolChange.None;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,7712,9203);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(768,7712,9203);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,9130,9188);

throw f_768_9136_9187(containerChange);
DynAbs.Tracing.TraceSender.TraceExitCondition(768,7712,9203);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(768,7225,9214);

bool
f_768_7300_7344(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Emit.SymbolChange>
this_param,Microsoft.CodeAnalysis.ISymbol
key,out Microsoft.CodeAnalysis.Emit.SymbolChange
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 7300, 7344);
return return_v;
}


Microsoft.CodeAnalysis.ISymbol
f_768_7502_7529(Microsoft.CodeAnalysis.ISymbol
symbol)
{
var return_v = GetContainingSymbol( symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 7502, 7529);
return return_v;
}


Microsoft.CodeAnalysis.Emit.SymbolChange
f_768_7677_7697(Microsoft.CodeAnalysis.Emit.SymbolChanges
this_param,Microsoft.CodeAnalysis.ISymbol
symbol)
{
var return_v = this_param.GetChange( symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 7677, 7697);
return return_v;
}


Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
f_768_8244_8276(Microsoft.CodeAnalysis.Emit.SymbolChanges
this_param,Microsoft.CodeAnalysis.ISymbol
symbol)
{
var return_v = this_param?.GetISymbolInternalOrNull( symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 8244, 8276);
return return_v;
}


Microsoft.Cci.IReference?
f_768_8244_8293_I(Microsoft.Cci.IReference?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 8244, 8293);
return return_v;
}


bool
f_768_8514_8557(Microsoft.CodeAnalysis.Emit.DefinitionMap
this_param,Microsoft.Cci.IDefinition
definition)
{
var return_v = this_param.DefinitionExists( definition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 8514, 8557);
return return_v;
}


bool
f_768_8913_8955(Microsoft.CodeAnalysis.Emit.DefinitionMap
this_param,Microsoft.Cci.INamespace
@namespace)
{
var return_v = this_param.NamespaceExists( @namespace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 8913, 8955);
return return_v;
}


System.Exception
f_768_9136_9187(Microsoft.CodeAnalysis.Emit.SymbolChange
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 9136, 9187);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(768,7225,9214);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(768,7225,9214);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected abstract ISymbolInternal GetISymbolInternalOrNull(ISymbol symbol);

public IEnumerable<INamespaceTypeDefinition> GetTopLevelSourceTypeDefinitions(EmitContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(768,9314,10094);

var listYield= new List<INamespaceTypeDefinition>();
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,9437,10083);
foreach(var symbol in f_768_9460_9473_I(f_768_9460_9473(_changes)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,9437,10083);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,9534,9583);

INamespaceTypeDefinition 
namespaceTypeDef = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,9601,9645);

var 
temp = f_768_9612_9644(this, symbol)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,9663,9929) || true) && (temp != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,9663,9929);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,9721,9754);

var 
temp2 = f_768_9733_9753(temp)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,9776,9910) || true) && (temp2 is ITypeDefinition)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,9776,9910);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,9831,9910);

namespaceTypeDef = f_768_9850_9909(((ITypeDefinition)temp2), context);
DynAbs.Tracing.TraceSender.TraceExitCondition(768,9776,9910);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(768,9663,9929);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,9949,10068) || true) && (namespaceTypeDef != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,9949,10068);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,10019,10049);

listYield.Add(namespaceTypeDef);
DynAbs.Tracing.TraceSender.TraceExitCondition(768,9949,10068);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(768,9437,10083);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(768,1,647);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(768,1,647);
}DynAbs.Tracing.TraceSender.TraceExitMethod(768,9314,10094);

return listYield;

System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>
f_768_9460_9473(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Emit.SymbolChange>
this_param)
{
var return_v = this_param.Keys;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(768, 9460, 9473);
return return_v;
}


Microsoft.CodeAnalysis.Symbols.ISymbolInternal
f_768_9612_9644(Microsoft.CodeAnalysis.Emit.SymbolChanges
this_param,Microsoft.CodeAnalysis.ISymbol
symbol)
{
var return_v = this_param.GetISymbolInternalOrNull( symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 9612, 9644);
return return_v;
}


Microsoft.Cci.IReference
f_768_9733_9753(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
this_param)
{
var return_v = this_param.GetCciAdapter();
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 9733, 9753);
return return_v;
}


Microsoft.Cci.INamespaceTypeDefinition?
f_768_9850_9909(Microsoft.Cci.ITypeDefinition
this_param,Microsoft.CodeAnalysis.Emit.EmitContext
context)
{
var return_v = this_param.AsNamespaceTypeDefinition( context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 9850, 9909);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>
f_768_9460_9473_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 9460, 9473);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(768,9314,10094);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(768,9314,10094);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static IReadOnlyDictionary<ISymbol, SymbolChange> CalculateChanges(IEnumerable<SemanticEdit> edits)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(768,10509,12435);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,10641,10695);

var 
changes = f_768_10655_10694()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,10711,12393);
foreach(var edit in f_768_10732_10737_I(edits) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,10711,12393);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,10771,10791);

SymbolChange 
change
=default(SymbolChange);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,10811,11386);

switch (edit.Kind)
                {

case SemanticEditKind.Update:
DynAbs.Tracing.TraceSender.TraceEnterCondition(768,10811,11386);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,10925,10955);

change = SymbolChange.Updated;
DynAbs.Tracing.TraceSender.TraceBreak(768,10981,10987);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,10811,11386);

case SemanticEditKind.Insert:
DynAbs.Tracing.TraceSender.TraceEnterCondition(768,10811,11386);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,11066,11094);

change = SymbolChange.Added;
DynAbs.Tracing.TraceSender.TraceBreak(768,11120,11126);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,10811,11386);

case SemanticEditKind.Delete:
DynAbs.Tracing.TraceSender.TraceEnterCondition(768,10811,11386);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,11248,11257);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,10811,11386);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(768,10811,11386);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,11315,11367);

throw f_768_11321_11366(edit.Kind);
DynAbs.Tracing.TraceSender.TraceExitCondition(768,10811,11386);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,11406,11434);

var 
member = edit.NewSymbol
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,11617,12263) || true) && (f_768_11621_11632(member)== SymbolKind.Method)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,11617,12263);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,11695,11730);

var 
method = (IMethodSymbol)member
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,11838,11893);

f_768_11838_11892(f_768_11851_11883(method)== null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,11915,12025);

f_768_11915_12024((edit.OldSymbol == null) ||(DynAbs.Tracing.TraceSender.Expression_False(768, 11928, 12023)||(f_768_11957_12014(((IMethodSymbol)edit.OldSymbol))== null)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,12049,12099);

var 
definitionPart = f_768_12070_12098(method)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,12121,12244) || true) && (definitionPart != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,12121,12244);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,12197,12221);

member = definitionPart;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,12121,12244);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(768,11617,12263);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,12283,12332);

f_768_12283_12331(changes, member);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,12350,12378);

f_768_12350_12377(                changes, member, change);
DynAbs.Tracing.TraceSender.TraceExitCondition(768,10711,12393);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(768,1,1683);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(768,1,1683);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,12409,12424);

return changes;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(768,10509,12435);

System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Emit.SymbolChange>
f_768_10655_10694()
{
var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Emit.SymbolChange>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 10655, 10694);
return return_v;
}


System.Exception
f_768_11321_11366(Microsoft.CodeAnalysis.Emit.SemanticEditKind
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 11321, 11366);
return return_v;
}


Microsoft.CodeAnalysis.SymbolKind
f_768_11621_11632(Microsoft.CodeAnalysis.ISymbol?
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(768, 11621, 11632);
return return_v;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_768_11851_11883(Microsoft.CodeAnalysis.IMethodSymbol
this_param)
{
var return_v = this_param.PartialImplementationPart ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(768, 11851, 11883);
return return_v;
}


int
f_768_11838_11892(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 11838, 11892);
return 0;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_768_11957_12014(Microsoft.CodeAnalysis.IMethodSymbol
this_param)
{
var return_v = this_param.PartialImplementationPart ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(768, 11957, 12014);
return return_v;
}


int
f_768_11915_12024(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 11915, 12024);
return 0;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_768_12070_12098(Microsoft.CodeAnalysis.IMethodSymbol
this_param)
{
var return_v = this_param.PartialDefinitionPart;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(768, 12070, 12098);
return return_v;
}


int
f_768_12283_12331(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Emit.SymbolChange>
changes,Microsoft.CodeAnalysis.ISymbol
symbol)
{
AddContainingTypesAndNamespaces( changes, symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 12283, 12331);
return 0;
}


int
f_768_12350_12377(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Emit.SymbolChange>
this_param,Microsoft.CodeAnalysis.ISymbol
key,Microsoft.CodeAnalysis.Emit.SymbolChange
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 12350, 12377);
return 0;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_768_10732_10737_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Emit.SemanticEdit>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 10732, 10737);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(768,10509,12435);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(768,10509,12435);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static void AddContainingTypesAndNamespaces(Dictionary<ISymbol, SymbolChange> changes, ISymbol symbol)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(768,12447,13268);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,12582,13257) || true) && (true)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,12582,13257);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,12627,12664);

symbol = f_768_12636_12663(symbol);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,12682,12768) || true) && (symbol == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,12682,12768);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,12742,12749);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,12682,12768);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,12788,12887) || true) && (f_768_12792_12819(changes, symbol))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,12788,12887);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,12861,12868);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,12788,12887);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,12907,12930);

var 
kind = f_768_12918_12929(symbol)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,12948,13242) || true) && (kind == SymbolKind.Property ||(DynAbs.Tracing.TraceSender.Expression_False(768, 12952, 13007)||kind == SymbolKind.Event))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,12948,13242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,13049,13091);

f_768_13049_13090(                    changes, symbol, SymbolChange.Updated);
DynAbs.Tracing.TraceSender.TraceExitCondition(768,12948,13242);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,12948,13242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,13173,13223);

f_768_13173_13222(                    changes, symbol, SymbolChange.ContainsChanges);
DynAbs.Tracing.TraceSender.TraceExitCondition(768,12948,13242);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(768,12582,13257);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(768,12582,13257);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(768,12582,13257);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(768,12447,13268);

Microsoft.CodeAnalysis.ISymbol
f_768_12636_12663(Microsoft.CodeAnalysis.ISymbol
symbol)
{
var return_v = GetContainingSymbol( symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 12636, 12663);
return return_v;
}


bool
f_768_12792_12819(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Emit.SymbolChange>
this_param,Microsoft.CodeAnalysis.ISymbol
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 12792, 12819);
return return_v;
}


Microsoft.CodeAnalysis.SymbolKind
f_768_12918_12929(Microsoft.CodeAnalysis.ISymbol
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(768, 12918, 12929);
return return_v;
}


int
f_768_13049_13090(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Emit.SymbolChange>
this_param,Microsoft.CodeAnalysis.ISymbol
key,Microsoft.CodeAnalysis.Emit.SymbolChange
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 13049, 13090);
return 0;
}


int
f_768_13173_13222(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Emit.SymbolChange>
this_param,Microsoft.CodeAnalysis.ISymbol
key,Microsoft.CodeAnalysis.Emit.SymbolChange
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 13173, 13222);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(768,12447,13268);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(768,12447,13268);
}
		}

private static ISymbol GetContainingSymbol(ISymbol symbol)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(768,13653,15291);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,14095,14845);

switch (f_768_14103_14114(symbol))
            {

case SymbolKind.Field:
DynAbs.Tracing.TraceSender.TraceEnterCondition(768,14095,14845);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,14219,14276);

var 
associated = f_768_14236_14275(((IFieldSymbol)symbol))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,14302,14427) || true) && (associated != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,14302,14427);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,14382,14400);

return associated;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,14302,14427);
}
                    }
DynAbs.Tracing.TraceSender.TraceBreak(768,14472,14478);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,14095,14845);

case SymbolKind.Method:
DynAbs.Tracing.TraceSender.TraceEnterCondition(768,14095,14845);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,14570,14628);

var 
associated = f_768_14587_14627(((IMethodSymbol)symbol))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,14654,14779) || true) && (associated != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,14654,14779);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,14734,14752);

return associated;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,14654,14779);
}
                    }
DynAbs.Tracing.TraceSender.TraceBreak(768,14824,14830);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,14095,14845);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,14861,14894);

symbol = f_768_14870_14893(symbol);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,14908,15250) || true) && (symbol != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(768,14908,15250);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,14960,15235);

switch (f_768_14968_14979(symbol))
                {

case SymbolKind.NetModule:
                    case SymbolKind.Assembly:
DynAbs.Tracing.TraceSender.TraceEnterCondition(768,14960,15235);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,15204,15216);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(768,14960,15235);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(768,14908,15250);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(768,15266,15280);

return symbol;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(768,13653,15291);

Microsoft.CodeAnalysis.SymbolKind
f_768_14103_14114(Microsoft.CodeAnalysis.ISymbol
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(768, 14103, 14114);
return return_v;
}


Microsoft.CodeAnalysis.ISymbol?
f_768_14236_14275(Microsoft.CodeAnalysis.IFieldSymbol
this_param)
{
var return_v = this_param.AssociatedSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(768, 14236, 14275);
return return_v;
}


Microsoft.CodeAnalysis.ISymbol?
f_768_14587_14627(Microsoft.CodeAnalysis.IMethodSymbol
this_param)
{
var return_v = this_param.AssociatedSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(768, 14587, 14627);
return return_v;
}


Microsoft.CodeAnalysis.ISymbol
f_768_14870_14893(Microsoft.CodeAnalysis.ISymbol
this_param)
{
var return_v = this_param.ContainingSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(768, 14870, 14893);
return return_v;
}


Microsoft.CodeAnalysis.SymbolKind
f_768_14968_14979(Microsoft.CodeAnalysis.ISymbol
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(768, 14968, 14979);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(768,13653,15291);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(768,13653,15291);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static SymbolChanges()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(768,440,15298);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(768,440,15298);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(768,440,15298);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(768,440,15298);

static int
f_768_1201_1236(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 1201, 1236);
return 0;
}


static int
f_768_1251_1278(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 1251, 1278);
return 0;
}


static int
f_768_1293_1328(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 1293, 1328);
return 0;
}


static System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Emit.SymbolChange>
f_768_1446_1469(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = CalculateChanges( edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(768, 1446, 1469);
return return_v;
}

}
}
