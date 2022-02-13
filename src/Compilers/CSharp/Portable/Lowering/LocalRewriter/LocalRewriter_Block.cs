// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitBlock(BoundBlock node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10483,569,1914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,647,704);

var 
builder = f_10483_661_703()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,718,766);

f_10483_718_765(this, builder, f_10483_749_764(node));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,782,1035) || true) && (f_10483_786_802_M(!this.Instrument)||(DynAbs.Tracing.TraceSender.Expression_False(10483, 786, 903)||(node != _rootStatement &&(DynAbs.Tracing.TraceSender.Expression_True(10483, 807, 902)&&(f_10483_834_859(node)||(DynAbs.Tracing.TraceSender.Expression_False(10483, 834, 901)||f_10483_863_881(node.Syntax)!= SyntaxKind.Block))))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10483,782,1035);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,937,1020);

return f_10483_944_1019(node, f_10483_956_967(node), f_10483_969_988(node), f_10483_990_1018(builder));
DynAbs.Tracing.TraceSender.TraceExitCondition(10483,782,1035);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,1051,1081);

LocalSymbol? 
synthesizedLocal
=default(LocalSymbol?);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,1095,1184);

BoundStatement? 
prologue = f_10483_1122_1183(_instrumenter, node, out synthesizedLocal)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,1198,1521) || true) && (prologue != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10483,1198,1521);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,1252,1280);

f_10483_1252_1279(                builder, 0, prologue);
DynAbs.Tracing.TraceSender.TraceExitCondition(10483,1198,1521);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10483,1198,1521);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,1314,1521) || true) && (node == _rootStatement &&(DynAbs.Tracing.TraceSender.Expression_True(10483, 1318, 1422)&&f_10483_1344_1367(_factory)is SynthesizedSimpleProgramEntryPointSymbol entryPoint))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10483,1314,1521);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,1456,1506);

f_10483_1456_1505(                builder, 0, f_10483_1474_1504(_factory));
DynAbs.Tracing.TraceSender.TraceExitCondition(10483,1314,1521);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10483,1198,1521);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,1537,1604);

BoundStatement? 
epilogue = f_10483_1564_1603(_instrumenter, node)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,1618,1709) || true) && (epilogue != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10483,1618,1709);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,1672,1694);

f_10483_1672_1693(                builder, epilogue);
DynAbs.Tracing.TraceSender.TraceExitCondition(10483,1618,1709);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,1725,1903);

return f_10483_1732_1902(node.Syntax, (DynAbs.Tracing.TraceSender.Conditional_F1(10483, 1760, 1784)||((synthesizedLocal == null &&DynAbs.Tracing.TraceSender.Conditional_F2(10483, 1787, 1798))||DynAbs.Tracing.TraceSender.Conditional_F3(10483, 1801, 1834)))?f_10483_1787_1798(node):node.Locals.Add(synthesizedLocal), f_10483_1836_1855(node), f_10483_1857_1885(builder), f_10483_1887_1901(node));
DynAbs.Tracing.TraceSender.TraceExitMethod(10483,569,1914);

Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10483_661_703()
{
var return_v = ArrayBuilder<BoundStatement>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10483, 661, 703);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10483_749_764(Microsoft.CodeAnalysis.CSharp.BoundBlock
this_param)
{
var return_v = this_param.Statements;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10483, 749, 764);
return return_v;
}


int
f_10483_718_765(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
builder,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
this_param.VisitStatementSubList( builder, statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10483, 718, 765);
return 0;
}


bool
f_10483_786_802_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10483, 786, 802);
return return_v;
}


bool
f_10483_834_859(Microsoft.CodeAnalysis.CSharp.BoundBlock
this_param)
{
var return_v = this_param.WasCompilerGenerated ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10483, 834, 859);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10483_863_881(Microsoft.CodeAnalysis.SyntaxNode
node)
{
var return_v = node.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10483, 863, 881);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10483_956_967(Microsoft.CodeAnalysis.CSharp.BoundBlock
this_param)
{
var return_v = this_param.Locals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10483, 956, 967);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
f_10483_969_988(Microsoft.CodeAnalysis.CSharp.BoundBlock
this_param)
{
var return_v = this_param.LocalFunctions;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10483, 969, 988);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10483_990_1018(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10483, 990, 1018);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10483_944_1019(Microsoft.CodeAnalysis.CSharp.BoundBlock
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
localFunctions,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
var return_v = this_param.Update( locals, localFunctions, statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10483, 944, 1019);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10483_1122_1183(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundBlock
original,out Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol?
synthesizedLocal)
{
var return_v = this_param.CreateBlockPrologue( original, out synthesizedLocal);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10483, 1122, 1183);
return return_v;
}


int
f_10483_1252_1279(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,int
index,Microsoft.CodeAnalysis.CSharp.BoundStatement
item)
{
this_param.Insert( index, item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10483, 1252, 1279);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10483_1344_1367(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.TopLevelMethod ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10483, 1344, 1367);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10483_1474_1504(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.HiddenSequencePoint();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10483, 1474, 1504);
return return_v;
}


int
f_10483_1456_1505(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,int
index,Microsoft.CodeAnalysis.CSharp.BoundStatement
item)
{
this_param.Insert( index, item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10483, 1456, 1505);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10483_1564_1603(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundBlock
original)
{
var return_v = this_param.CreateBlockEpilogue( original);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10483, 1564, 1603);
return return_v;
}


int
f_10483_1672_1693(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10483, 1672, 1693);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10483_1787_1798(Microsoft.CodeAnalysis.CSharp.BoundBlock
this_param)
{
var return_v = this_param.Locals ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10483, 1787, 1798);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
f_10483_1836_1855(Microsoft.CodeAnalysis.CSharp.BoundBlock
this_param)
{
var return_v = this_param.LocalFunctions;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10483, 1836, 1855);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10483_1857_1885(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10483, 1857, 1885);
return return_v;
}


bool
f_10483_1887_1901(Microsoft.CodeAnalysis.CSharp.BoundBlock
this_param)
{
var return_v = this_param.HasErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10483, 1887, 1901);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10483_1732_1902(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
localFunctions,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements,bool
hasErrors)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBlock( syntax, locals, localFunctions, statements, hasErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10483, 1732, 1902);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10483,569,1914);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10483,569,1914);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public void VisitStatementSubList(ArrayBuilder<BoundStatement> builder, ImmutableArray<BoundStatement> statements, int startIndex = 0)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10483,2440,3072);
bool replacedUsingDeclarations = default(bool);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,2608,2622);
            for (int 
i = startIndex
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,2599,3061) || true) && (i < statements.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,2647,2650)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(10483,2599,3061))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10483,2599,3061);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,2684,2807);

BoundStatement? 
statement = f_10483_2712_2806(this, statements[i], statements, i, out replacedUsingDeclarations)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,2825,2930) || true) && (statement != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10483,2825,2930);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,2888,2911);

f_10483_2888_2910(                    builder, statement);
DynAbs.Tracing.TraceSender.TraceExitCondition(10483,2825,2930);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,2950,3046) || true) && (replacedUsingDeclarations)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10483,2950,3046);
DynAbs.Tracing.TraceSender.TraceBreak(10483,3021,3027);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10483,2950,3046);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10483,1,463);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10483,1,463);
}DynAbs.Tracing.TraceSender.TraceExitMethod(10483,2440,3072);

Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10483_2712_2806(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
node,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements,int
statementIndex,out bool
replacedLocalDeclarations)
{
var return_v = this_param.VisitPossibleUsingDeclaration( node, statements, statementIndex, out replacedLocalDeclarations);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10483, 2712, 2806);
return return_v;
}


int
f_10483_2888_2910(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10483, 2888, 2910);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10483,2440,3072);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10483,2440,3072);
}
		}

public BoundStatement? VisitPossibleUsingDeclaration(BoundStatement node, ImmutableArray<BoundStatement> statements, int statementIndex, out bool replacedLocalDeclarations)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10483,4067,5329);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,4264,5318);

switch (f_10483_4272_4281(node))
            {

case BoundKind.LabeledStatement:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10483,4264,5318);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,4369,4418);

var 
labelStatement = (BoundLabeledStatement)node
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,4440,4595);

return f_10483_4447_4594(this, labelStatement, f_10483_4484_4593(this, f_10483_4514_4533(labelStatement), statements, statementIndex, out replacedLocalDeclarations));
DynAbs.Tracing.TraceSender.TraceExitCondition(10483,4264,5318);

case BoundKind.UsingLocalDeclarations:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10483,4264,5318);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,4731,4813);

ArrayBuilder<BoundStatement> 
builder = f_10483_4770_4812()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,4835,4898);

f_10483_4835_4897(this, builder, statements, statementIndex + 1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,5009,5042);

replacedLocalDeclarations = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,5064,5171);

return f_10483_5071_5170(this, node, f_10483_5141_5169(builder));
DynAbs.Tracing.TraceSender.TraceExitCondition(10483,4264,5318);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10483,4264,5318);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,5219,5253);

replacedLocalDeclarations = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,5275,5303);

return f_10483_5282_5302(this, node);
DynAbs.Tracing.TraceSender.TraceExitCondition(10483,4264,5318);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(10483,4067,5329);

Microsoft.CodeAnalysis.CSharp.BoundKind
f_10483_4272_4281(Microsoft.CodeAnalysis.CSharp.BoundStatement
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10483, 4272, 4281);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10483_4514_4533(Microsoft.CodeAnalysis.CSharp.BoundLabeledStatement
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10483, 4514, 4533);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10483_4484_4593(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
node,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements,int
statementIndex,out bool
replacedLocalDeclarations)
{
var return_v = this_param.VisitPossibleUsingDeclaration( node, statements, statementIndex, out replacedLocalDeclarations);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10483, 4484, 4593);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10483_4447_4594(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLabeledStatement
node,Microsoft.CodeAnalysis.CSharp.BoundStatement?
rewrittenBody)
{
var return_v = this_param.MakeLabeledStatement( node, rewrittenBody);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10483, 4447, 4594);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10483_4770_4812()
{
var return_v = ArrayBuilder<BoundStatement>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10483, 4770, 4812);
return return_v;
}


int
f_10483_4835_4897(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
builder,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements,int
startIndex)
{
this_param.VisitStatementSubList( builder, statements, startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10483, 4835, 4897);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10483_5141_5169(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10483, 5141, 5169);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10483_5071_5170(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
usingDeclarations,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
var return_v = this_param.MakeLocalUsingDeclarationStatement( (Microsoft.CodeAnalysis.CSharp.BoundUsingLocalDeclarations)usingDeclarations, statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10483, 5071, 5170);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10483_5282_5302(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
node)
{
var return_v = this_param.VisitStatement( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10483, 5282, 5302);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10483,4067,5329);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10483,4067,5329);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override BoundNode VisitNoOpStatement(BoundNoOpStatement node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10483,5343,5692);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10483,5437,5681);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10483, 5444, 5491)||(((f_10483_5445_5470(node)||(DynAbs.Tracing.TraceSender.Expression_False(10483, 5445, 5490)||f_10483_5474_5490_M(!this.Instrument)))
&&DynAbs.Tracing.TraceSender.Conditional_F2(10483, 5511, 5611))||DynAbs.Tracing.TraceSender.Conditional_F3(10483, 5631, 5680)))?f_10483_5511_5611(node.Syntax, ImmutableArray<LocalSymbol>.Empty, ImmutableArray<BoundStatement>.Empty):f_10483_5631_5680(_instrumenter, node, node);
DynAbs.Tracing.TraceSender.TraceExitMethod(10483,5343,5692);

bool
f_10483_5445_5470(Microsoft.CodeAnalysis.CSharp.BoundNoOpStatement
this_param)
{
var return_v = this_param.WasCompilerGenerated ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10483, 5445, 5470);
return return_v;
}


bool
f_10483_5474_5490_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10483, 5474, 5490);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10483_5511_5611(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBlock( syntax, locals, statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10483, 5511, 5611);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10483_5631_5680(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundNoOpStatement
original,Microsoft.CodeAnalysis.CSharp.BoundNoOpStatement
rewritten)
{
var return_v = this_param.InstrumentNoOpStatement( original, (Microsoft.CodeAnalysis.CSharp.BoundStatement)rewritten);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10483, 5631, 5680);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10483,5343,5692);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10483,5343,5692);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
