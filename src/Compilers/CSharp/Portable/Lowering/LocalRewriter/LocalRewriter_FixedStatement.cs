// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitFixedStatement(BoundFixedStatement node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10497,578,3869);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,674,761);

ImmutableArray<BoundLocalDeclaration> 
localDecls = f_10497_725_760(f_10497_725_742(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,775,814);

int 
numFixedLocals = localDecls.Length
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,830,907);

var 
localBuilder = f_10497_849_906(node.Locals.Length)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,921,956);

f_10497_921_955(            localBuilder, f_10497_943_954(node));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,972,1060);

var 
statementBuilder = f_10497_995_1059(numFixedLocals + 1 + 1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,1113,1162);

var 
cleanup = new BoundStatement[numFixedLocals]
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,1187,1192);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,1178,2420) || true) && (i < numFixedLocals)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,1214,1217)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(10497,1178,2420))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10497,1178,2420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,1251,1299);

BoundLocalDeclaration 
localDecl = localDecls[i]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,1317,1340);

LocalSymbol 
pinnedTemp
=default(LocalSymbol);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,1358,1447);

f_10497_1358_1446(                statementBuilder, f_10497_1379_1445(this, localDecl, _factory, out pinnedTemp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,1465,1494);

f_10497_1465_1493(                localBuilder, pinnedTemp);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,1637,2405) || true) && (f_10497_1641_1659(pinnedTemp)== RefKind.None)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10497,1637,2405);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,1754,1847);

cleanup[i] = f_10497_1767_1846(_factory, f_10497_1787_1813(_factory, pinnedTemp), f_10497_1815_1845(_factory, f_10497_1829_1844(pinnedTemp)));
DynAbs.Tracing.TraceSender.TraceExitCondition(10497,1637,2405);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10497,1637,2405);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,1929,1994);

f_10497_1929_1993(f_10497_1942_1992_M(!f_10497_1943_1958(pinnedTemp).IsManagedTypeNoUseSiteDiagnostics));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,2067,2386);

cleanup[i] = f_10497_2080_2385(_factory, f_10497_2100_2126(_factory, pinnedTemp), f_10497_2128_2346(f_10497_2190_2205(_factory), f_10497_2232_2303(                        _factory, f_10497_2249_2302(f_10497_2271_2301(pinnedTemp))), f_10497_2330_2345(pinnedTemp)), isRef: true);
DynAbs.Tracing.TraceSender.TraceExitCondition(10497,1637,2405);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10497,1,1243);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10497,1,1243);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,2436,2494);

BoundStatement? 
rewrittenBody = f_10497_2468_2493(this, f_10497_2483_2492(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,2508,2543);

f_10497_2508_2542(rewrittenBody is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,2557,2593);

f_10497_2557_2592(            statementBuilder, rewrittenBody);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,2607,2660);

f_10497_2607_2659(            statementBuilder, f_10497_2628_2658(_factory));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,2676,2739);

f_10497_2676_2738(f_10497_2689_2711(statementBuilder)== numFixedLocals + 1 + 1);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,3183,3858) || true) && (f_10497_3187_3205(node)||(DynAbs.Tracing.TraceSender.Expression_False(10497, 3187, 3234)||f_10497_3209_3234(this, rewrittenBody)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10497,3183,3858);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,3268,3628);

return f_10497_3275_3627(_factory, f_10497_3312_3345(                    localBuilder), f_10497_3368_3626(f_10497_3416_3431(_factory), f_10497_3458_3511(                        _factory, f_10497_3473_3510(statementBuilder)), ImmutableArray<BoundCatchBlock>.Empty, f_10497_3602_3625(                        _factory, cleanup)));
DynAbs.Tracing.TraceSender.TraceExitCondition(10497,3183,3858);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10497,3183,3858);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,3694,3729);

f_10497_3694_3728(                statementBuilder, cleanup);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,3747,3843);

return f_10497_3754_3842(_factory, f_10497_3769_3802(localBuilder), f_10497_3804_3841(statementBuilder));
DynAbs.Tracing.TraceSender.TraceExitCondition(10497,3183,3858);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10497,578,3869);

Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarations
f_10497_725_742(Microsoft.CodeAnalysis.CSharp.BoundFixedStatement
this_param)
{
var return_v = this_param.Declarations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 725, 742);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration>
f_10497_725_760(Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarations
this_param)
{
var return_v = this_param.LocalDeclarations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 725, 760);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10497_849_906(int
capacity)
{
var return_v = ArrayBuilder<LocalSymbol>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 849, 906);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10497_943_954(Microsoft.CodeAnalysis.CSharp.BoundFixedStatement
this_param)
{
var return_v = this_param.Locals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 943, 954);
return return_v;
}


int
f_10497_921_955(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
items)
{
this_param.AddRange( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 921, 955);
return 0;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10497_995_1059(int
capacity)
{
var return_v = ArrayBuilder<BoundStatement>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 995, 1059);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10497_1379_1445(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
localDecl,Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
factory,out Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
pinnedTemp)
{
var return_v = this_param.InitializeFixedStatementLocal( localDecl, factory, out pinnedTemp);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 1379, 1445);
return return_v;
}


int
f_10497_1358_1446(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 1358, 1446);
return 0;
}


int
f_10497_1465_1493(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 1465, 1493);
return 0;
}


Microsoft.CodeAnalysis.RefKind
f_10497_1641_1659(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
this_param)
{
var return_v = this_param.RefKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 1641, 1659);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10497_1787_1813(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local)
{
var return_v = this_param.Local( local);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 1787, 1813);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10497_1829_1844(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 1829, 1844);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10497_1815_1845(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Null( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 1815, 1845);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
f_10497_1767_1846(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right)
{
var return_v = this_param.Assignment( (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 1767, 1846);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10497_1943_1958(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 1943, 1958);
return return_v;
}


bool
f_10497_1942_1992_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 1942, 1992);
return return_v;
}


int
f_10497_1929_1993(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 1929, 1993);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10497_2100_2126(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local)
{
var return_v = this_param.Local( local);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 2100, 2126);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_10497_2190_2205(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.Syntax;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 2190, 2205);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
f_10497_2271_2301(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
this_param)
{
var return_v = this_param.TypeWithAnnotations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 2271, 2301);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
f_10497_2249_2302(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
pointedAtType)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol( pointedAtType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 2249, 2302);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10497_2232_2303(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
type)
{
var return_v = this_param.Default( (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 2232, 2303);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10497_2330_2345(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 2330, 2345);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundPointerIndirectionOperator
f_10497_2128_2346(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
operand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundPointerIndirectionOperator( syntax, operand, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 2128, 2346);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
f_10497_2080_2385(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
left,Microsoft.CodeAnalysis.CSharp.BoundPointerIndirectionOperator
right,bool
isRef)
{
var return_v = this_param.Assignment( (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right, isRef: isRef);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 2080, 2385);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10497_2483_2492(Microsoft.CodeAnalysis.CSharp.BoundFixedStatement
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 2483, 2492);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10497_2468_2493(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
node)
{
var return_v = this_param.VisitStatement( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 2468, 2493);
return return_v;
}


int
f_10497_2508_2542(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 2508, 2542);
return 0;
}


int
f_10497_2557_2592(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 2557, 2592);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10497_2628_2658(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.HiddenSequencePoint();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 2628, 2658);
return return_v;
}


int
f_10497_2607_2659(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 2607, 2659);
return 0;
}


int
f_10497_2689_2711(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 2689, 2711);
return return_v;
}


int
f_10497_2676_2738(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 2676, 2738);
return 0;
}


bool
f_10497_3187_3205(Microsoft.CodeAnalysis.CSharp.BoundFixedStatement
boundFixed)
{
var return_v = IsInTryBlock( boundFixed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 3187, 3205);
return return_v;
}


bool
f_10497_3209_3234(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
node)
{
var return_v = this_param.HasGotoOut( (Microsoft.CodeAnalysis.CSharp.BoundNode)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 3209, 3234);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10497_3312_3345(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 3312, 3345);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_10497_3416_3431(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.Syntax;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 3416, 3431);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10497_3473_3510(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 3473, 3510);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10497_3458_3511(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
var return_v = this_param.Block( statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 3458, 3511);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10497_3602_3625(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
statements)
{
var return_v = this_param.Block( statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 3602, 3625);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundTryStatement
f_10497_3368_3626(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundBlock
tryBlock,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
catchBlocks,Microsoft.CodeAnalysis.CSharp.BoundBlock
finallyBlockOpt)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTryStatement( syntax, tryBlock, catchBlocks, finallyBlockOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 3368, 3626);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10497_3275_3627(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
statements)
{
var return_v = this_param.Block( locals, statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 3275, 3627);
return return_v;
}


int
f_10497_3694_3728(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
items)
{
this_param.AddRange( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 3694, 3728);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10497_3769_3802(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 3769, 3802);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10497_3804_3841(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 3804, 3841);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10497_3754_3842(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
var return_v = this_param.Block( locals, statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 3754, 3842);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10497,578,3869);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10497,578,3869);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

        /// <summary>
        /// Basically, what we need to know is, if an exception occurred within the fixed statement, would
        /// additional code in the current method be executed before its stack frame was popped?
        /// </summary>
        private static bool IsInTryBlock(BoundFixedStatement boundFixed)
        {
            SyntaxNode? node = boundFixed.Syntax.Parent;
            Debug.Assert(node is { });
            while (node != null)
            {
                switch (node.Kind())
                {
                    case SyntaxKind.TryStatement:
                        // NOTE: if we started in the catch or finally of this try statement,
                        // we will have bypassed this node.
                        return true;
                    case SyntaxKind.UsingStatement:
                        // ACASEY: In treating using statements as try-finally's, we're following
                        // Dev11.  The practical explanation for Dev11's behavior is that using 
                        // statements have already been lowered by the time the check is performed.
                        // A more thoughtful explanation is that user code could run between the 
                        // raising of an exception and the unwinding of the stack (via Dispose())
                        // and that user code would likely appreciate the reduced memory pressure 
                        // of having the fixed local unpinned.

                        // NOTE: As in Dev11, we're not emitting a try-finally if the fixed
                        // statement is nested within a lock statement.  Practically, dev11
                        // probably lowers locks after fixed statement, and so, does not see
                        // the try-finally.  More thoughtfully, no user code will run in the
                        // finally statement, so it's not necessary.

                        // BREAK: Takes into account whether an outer fixed statement will be
                        // lowered into a try-finally block and responds accordingly.  This is
                        // unnecessary since nothing will ever be allocated in the finally
                        // block of a lowered fixed statement, so memory pressure is not an
                        // issue.  Note that only nested fixed statements where the outer (but
                        // not the inner) fixed statement has an unmatched goto, but is not
                        // contained in a try-finally, will be affected.  e.g.
                        // fixed (...) { 
                        //   fixed (...) { }
                        //   goto L1: ; 
                        // }
                        return true;
                    case SyntaxKind.ForEachStatement:
                    case SyntaxKind.ForEachVariableStatement:
                        // We're being conservative here - there's actually only
                        // a try block if the enumerator is disposable, but we
                        // can't tell that from the syntax.  Dev11 checks in the
                        // lowered tree, so it is more precise.
                        return true;
                    case SyntaxKind.SimpleLambdaExpression:
                    case SyntaxKind.ParenthesizedLambdaExpression:
                    case SyntaxKind.AnonymousMethodExpression:
                        // Stop looking.
                        return false;
                    case SyntaxKind.CatchClause:
                        // If we're in the catch of a try-catch-finally, then
                        // we're still in the scope of the try-finally handler.
                        Debug.Assert(node.Parent is TryStatementSyntax);
                        if (((TryStatementSyntax)node.Parent).Finally != null)
                        {
                            return true;
                        }
                        goto case SyntaxKind.FinallyClause;
                    case SyntaxKind.FinallyClause:
                        // Skip past the enclosing try to avoid a false positive.
                        node = node.Parent;
                        Debug.Assert(node is { } && node.Kind() == SyntaxKind.TryStatement);
                        node = node.Parent;
                        break;
                    default:
                        if (node is MemberDeclarationSyntax)
                        {
                            // Stop looking.
                            return false;
                        }
                        node = node.Parent;
                        break;
                }
            }

            return false;
        }

private Dictionary<BoundNode, HashSet<LabelSymbol>>? _lazyUnmatchedLabelCache;

private bool HasGotoOut(BoundNode node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10497,9425,9910);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,9489,9651) || true) && (_lazyUnmatchedLabelCache == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10497,9489,9651);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,9559,9636);

_lazyUnmatchedLabelCache = f_10497_9586_9635();
DynAbs.Tracing.TraceSender.TraceExitCondition(10497,9489,9651);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,9667,9773);

HashSet<LabelSymbol> 
unmatched = f_10497_9700_9772(node, _lazyUnmatchedLabelCache, f_10497_9757_9771())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,9789,9835);

f_10497_9789_9834(
            _lazyUnmatchedLabelCache, node, unmatched);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,9851,9899);

return unmatched != null &&(DynAbs.Tracing.TraceSender.Expression_True(10497, 9858, 9898)&&f_10497_9879_9894(unmatched)> 0);
DynAbs.Tracing.TraceSender.TraceExitMethod(10497,9425,9910);

System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundNode, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>
f_10497_9586_9635()
{
var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundNode, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 9586, 9635);
return return_v;
}


int
f_10497_9757_9771()
{
var return_v = RecursionDepth;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 9757, 9771);
return return_v;
}


System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
f_10497_9700_9772(Microsoft.CodeAnalysis.CSharp.BoundNode
node,System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundNode, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>
unmatchedLabelsCache,int
recursionDepth)
{
var return_v = UnmatchedGotoFinder.Find( node, unmatchedLabelsCache, recursionDepth);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 9700, 9772);
return return_v;
}


int
f_10497_9789_9834(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundNode, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>
this_param,Microsoft.CodeAnalysis.CSharp.BoundNode
key,System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 9789, 9834);
return 0;
}


int
f_10497_9879_9894(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 9879, 9894);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10497,9425,9910);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10497,9425,9910);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override BoundNode VisitFixedLocalCollectionInitializer(BoundFixedLocalCollectionInitializer node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10497,9922,10143);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,10052,10089);

throw f_10497_10058_10088();
DynAbs.Tracing.TraceSender.TraceExitMethod(10497,9922,10143);

System.Exception
f_10497_10058_10088()
{
var return_v = ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 10058, 10088);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10497,9922,10143);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10497,9922,10143);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundStatement InitializeFixedStatementLocal(
            BoundLocalDeclaration localDecl,
            SyntheticBoundNodeFactory factory,
            out LocalSymbol pinnedTemp)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10497,10155,11629);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,10368,10424);

BoundExpression? 
initializer = f_10497_10399_10423(localDecl)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,10438,10488);

f_10497_10438_10487(!f_10497_10452_10486(initializer, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,10504,10552);

LocalSymbol 
localSymbol = f_10497_10530_10551(localDecl)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,10566,10649);

var 
fixedCollectionInitializer = (BoundFixedLocalCollectionInitializer)initializer
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,10665,11618) || true) && (f_10497_10669_10710(fixedCollectionInitializer)is { })
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10497,10665,11618);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,10751,10871);

return f_10497_10758_10870(this, localDecl, localSymbol, fixedCollectionInitializer, factory, out pinnedTemp);
DynAbs.Tracing.TraceSender.TraceExitCondition(10497,10665,11618);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10497,10665,11618);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,10905,11618) || true) && (f_10497_10909_10951(f_10497_10909_10946(fixedCollectionInitializer))is { SpecialType: SpecialType.System_String })
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10497,10905,11618);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,11031,11151);

return f_10497_11038_11150(this, localDecl, localSymbol, fixedCollectionInitializer, factory, out pinnedTemp);
DynAbs.Tracing.TraceSender.TraceExitCondition(10497,10905,11618);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10497,10905,11618);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,11185,11618) || true) && (f_10497_11189_11231(f_10497_11189_11226(fixedCollectionInitializer))is { TypeKind: TypeKind.Array })
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10497,11185,11618);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,11297,11416);

return f_10497_11304_11415(this, localDecl, localSymbol, fixedCollectionInitializer, factory, out pinnedTemp);
DynAbs.Tracing.TraceSender.TraceExitCondition(10497,11185,11618);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10497,11185,11618);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,11482,11603);

return f_10497_11489_11602(this, localDecl, localSymbol, fixedCollectionInitializer, factory, out pinnedTemp);
DynAbs.Tracing.TraceSender.TraceExitCondition(10497,11185,11618);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10497,10905,11618);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10497,10665,11618);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10497,10155,11629);

Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10497_10399_10423(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
this_param)
{
var return_v = this_param.InitializerOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 10399, 10423);
return return_v;
}


bool
f_10497_10452_10486(Microsoft.CodeAnalysis.CSharp.BoundExpression?
objA,object?
objB)
{
var return_v = ReferenceEquals( (object?)objA, objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 10452, 10486);
return return_v;
}


int
f_10497_10438_10487(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 10438, 10487);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10497_10530_10551(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 10530, 10551);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10497_10669_10710(Microsoft.CodeAnalysis.CSharp.BoundFixedLocalCollectionInitializer
this_param)
{
var return_v = this_param.GetPinnableOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 10669, 10710);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10497_10758_10870(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
localDecl,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
localSymbol,Microsoft.CodeAnalysis.CSharp.BoundFixedLocalCollectionInitializer
fixedInitializer,Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
factory,out Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
pinnedTemp)
{
var return_v = this_param.InitializeFixedStatementGetPinnable( localDecl, localSymbol, fixedInitializer, factory, out pinnedTemp);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 10758, 10870);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10497_10909_10946(Microsoft.CodeAnalysis.CSharp.BoundFixedLocalCollectionInitializer
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 10909, 10946);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10497_10909_10951(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 10909, 10951);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10497_11038_11150(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
localDecl,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
localSymbol,Microsoft.CodeAnalysis.CSharp.BoundFixedLocalCollectionInitializer
fixedInitializer,Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
factory,out Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
pinnedTemp)
{
var return_v = this_param.InitializeFixedStatementStringLocal( localDecl, localSymbol, fixedInitializer, factory, out pinnedTemp);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 11038, 11150);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10497_11189_11226(Microsoft.CodeAnalysis.CSharp.BoundFixedLocalCollectionInitializer
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 11189, 11226);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10497_11189_11231(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 11189, 11231);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10497_11304_11415(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
localDecl,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
localSymbol,Microsoft.CodeAnalysis.CSharp.BoundFixedLocalCollectionInitializer
fixedInitializer,Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
factory,out Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
pinnedTemp)
{
var return_v = this_param.InitializeFixedStatementArrayLocal( localDecl, localSymbol, fixedInitializer, factory, out pinnedTemp);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 11304, 11415);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10497_11489_11602(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
localDecl,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
localSymbol,Microsoft.CodeAnalysis.CSharp.BoundFixedLocalCollectionInitializer
fixedInitializer,Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
factory,out Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
pinnedTemp)
{
var return_v = this_param.InitializeFixedStatementRegularLocal( localDecl, localSymbol, fixedInitializer, factory, out pinnedTemp);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 11489, 11602);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10497,10155,11629);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10497,10155,11629);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundStatement InitializeFixedStatementRegularLocal(
            BoundLocalDeclaration localDecl,
            LocalSymbol localSymbol,
            BoundFixedLocalCollectionInitializer fixedInitializer,
            SyntheticBoundNodeFactory factory,
            out LocalSymbol pinnedTemp)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10497,11981,14936);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,12307,12347);

TypeSymbol 
localType = f_10497_12330_12346(localSymbol)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,12361,12440);

BoundExpression 
initializerExpr = f_10497_12395_12439(this, f_10497_12411_12438(fixedInitializer))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,12454,12523);

f_10497_12454_12522(f_10497_12467_12487(initializerExpr)is { TypeKind: TypeKind.Pointer });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,12692,12758);

f_10497_12692_12757(f_10497_12705_12725(initializerExpr)== BoundKind.AddressOfOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,12774,12859);

TypeSymbol 
initializerType = f_10497_12803_12858(((PointerTypeSymbol)f_10497_12823_12843(initializerExpr)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,13092,13160);

initializerExpr = f_10497_13110_13159(((BoundAddressOfOperator)initializerExpr));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,13268,13379);

VariableDeclaratorSyntax? 
declarator = f_10497_13307_13378(fixedInitializer.Syntax)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,13393,13426);

f_10497_13393_13425(declarator != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,13442,13892);

pinnedTemp = f_10497_13455_13891(factory, initializerType, syntax: declarator, isPinned: true, refKind: RefKind.RefReadOnly, kind: SynthesizedLocalKind.FixedReference);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,13969,14003);

f_10497_13969_14002(f_10497_13982_14001(pinnedTemp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,14017,14053);

f_10497_14017_14052(f_10497_14030_14051_M(!localSymbol.IsPinned));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,14105,14213);

BoundStatement 
pinnedTempInit = f_10497_14137_14212(factory, f_10497_14156_14181(factory, pinnedTemp), initializerExpr, isRef: true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,14257,14435);

var 
addr = f_10497_14268_14434(f_10497_14313_14327(factory), f_10497_14347_14372(                 factory, pinnedTemp), type: f_10497_14398_14433(fixedInitializer))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,14485,14636);

var 
pointerValue = f_10497_14504_14635(factory, localType, addr, f_10497_14589_14634(fixedInitializer))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,14693,14861);

BoundStatement 
localInit = f_10497_14720_14860(this, localDecl, localSymbol, f_10497_14799_14859(                factory, f_10497_14818_14844(factory, localSymbol), pointerValue))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,14877,14925);

return f_10497_14884_14924(factory, pinnedTempInit, localInit);
DynAbs.Tracing.TraceSender.TraceExitMethod(10497,11981,14936);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10497_12330_12346(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 12330, 12346);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10497_12411_12438(Microsoft.CodeAnalysis.CSharp.BoundFixedLocalCollectionInitializer
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 12411, 12438);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10497_12395_12439(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 12395, 12439);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10497_12467_12487(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 12467, 12487);
return return_v;
}


int
f_10497_12454_12522(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 12454, 12522);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10497_12705_12725(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 12705, 12725);
return return_v;
}


int
f_10497_12692_12757(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 12692, 12757);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10497_12823_12843(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 12823, 12843);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10497_12803_12858(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
this_param)
{
var return_v = this_param.PointedAtType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 12803, 12858);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10497_13110_13159(Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
this_param)
{
var return_v = this_param.Operand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 13110, 13159);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax?
f_10497_13307_13378(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.FirstAncestorOrSelf<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 13307, 13378);
return return_v;
}


int
f_10497_13393_13425(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 13393, 13425);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10497_13455_13891(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
syntax,bool
isPinned,Microsoft.CodeAnalysis.RefKind
refKind,Microsoft.CodeAnalysis.SynthesizedLocalKind
kind)
{
var return_v = this_param.SynthesizedLocal( type, syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, isPinned: isPinned, refKind: refKind, kind: kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 13455, 13891);
return return_v;
}


bool
f_10497_13982_14001(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
this_param)
{
var return_v = this_param.IsPinned;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 13982, 14001);
return return_v;
}


int
f_10497_13969_14002(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 13969, 14002);
return 0;
}


bool
f_10497_14030_14051_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 14030, 14051);
return return_v;
}


int
f_10497_14017_14052(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 14017, 14052);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10497_14156_14181(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local)
{
var return_v = this_param.Local( local);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 14156, 14181);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
f_10497_14137_14212(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,bool
isRef)
{
var return_v = this_param.Assignment( (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right, isRef: isRef);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 14137, 14212);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_10497_14313_14327(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.Syntax;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 14313, 14327);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10497_14347_14372(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local)
{
var return_v = this_param.Local( local);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 14347, 14372);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10497_14398_14433(Microsoft.CodeAnalysis.CSharp.BoundFixedLocalCollectionInitializer
this_param)
{
var return_v = this_param.ElementPointerType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 14398, 14433);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
f_10497_14268_14434(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
operand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)operand, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 14268, 14434);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10497_14589_14634(Microsoft.CodeAnalysis.CSharp.BoundFixedLocalCollectionInitializer
this_param)
{
var return_v = this_param.ElementPointerTypeConversion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 14589, 14634);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10497_14504_14635(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
arg,Microsoft.CodeAnalysis.CSharp.Conversion
conversion)
{
var return_v = this_param.Convert( type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg, conversion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 14504, 14635);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10497_14818_14844(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local)
{
var return_v = this_param.Local( local);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 14818, 14844);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
f_10497_14799_14859(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right)
{
var return_v = this_param.Assignment( (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 14799, 14859);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10497_14720_14860(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
originalOpt,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
localSymbol,Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
rewrittenLocalDeclaration)
{
var return_v = this_param.InstrumentLocalDeclarationIfNecessary( originalOpt, localSymbol, (Microsoft.CodeAnalysis.CSharp.BoundStatement)rewrittenLocalDeclaration);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 14720, 14860);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10497_14884_14924(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
statements)
{
var return_v = this_param.Block( statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 14884, 14924);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10497,11981,14936);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10497,11981,14936);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundStatement InitializeFixedStatementGetPinnable(
            BoundLocalDeclaration localDecl,
            LocalSymbol localSymbol,
            BoundFixedLocalCollectionInitializer fixedInitializer,
            SyntheticBoundNodeFactory factory,
            out LocalSymbol pinnedTemp)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10497,15288,19454);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,15613,15653);

TypeSymbol 
localType = f_10497_15636_15652(localSymbol)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,15667,15746);

BoundExpression 
initializerExpr = f_10497_15701_15745(this, f_10497_15717_15744(fixedInitializer))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,15760,15802);

f_10497_15760_15801(f_10497_15773_15793(initializerExpr)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,15818,15861);

var 
initializerType = f_10497_15840_15860(initializerExpr)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,15875,15922);

var 
initializerSyntax = initializerExpr.Syntax
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,15936,15992);

var 
getPinnableMethod = f_10497_15960_15991(fixedInitializer)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,16006,16045);

f_10497_16006_16044(getPinnableMethod is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,16153,16264);

VariableDeclaratorSyntax? 
declarator = f_10497_16192_16263(fixedInitializer.Syntax)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,16278,16311);

f_10497_16278_16310(declarator != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,16369,16832);

pinnedTemp = f_10497_16382_16831(factory, f_10497_16425_16453(getPinnableMethod), syntax: declarator, isPinned: true, refKind: RefKind.RefReadOnly, kind: SynthesizedLocalKind.FixedReference);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,16848,16877);

BoundExpression 
callReceiver
=default(BoundExpression);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,16891,16926);

int 
currentConditionalAccessID = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,16942,16992);

bool 
needNullCheck = f_10497_16963_16991_M(!initializerType.IsValueType)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,17008,17420) || true) && (needNullCheck)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10497,17008,17420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,17059,17118);

currentConditionalAccessID = ++_currentConditionalAccessID;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,17136,17308);

callReceiver = f_10497_17151_17307(initializerSyntax, currentConditionalAccessID, initializerType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10497,17008,17420);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10497,17008,17420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,17374,17405);

callReceiver = initializerExpr;
DynAbs.Tracing.TraceSender.TraceExitCondition(10497,17008,17420);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,17467,17652);

var 
getPinnableCall = (DynAbs.Tracing.TraceSender.Conditional_F1(10497, 17489, 17515)||((f_10497_17489_17515(getPinnableMethod)&&DynAbs.Tracing.TraceSender.Conditional_F2(10497, 17535, 17586))||DynAbs.Tracing.TraceSender.Conditional_F3(10497, 17606, 17651)))?f_10497_17535_17586(                factory, null, getPinnableMethod, callReceiver):f_10497_17606_17651(                factory, callReceiver, getPinnableMethod)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,17709,17868);

var 
tempAssignment = f_10497_17730_17867(factory, f_10497_17777_17802(                factory, pinnedTemp), getPinnableCall, isRef: true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,17912,18088);

var 
addr = f_10497_17923_18087(f_10497_17968_17982(factory), f_10497_18001_18026(                factory, pinnedTemp), type: f_10497_18051_18086(fixedInitializer))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,18138,18289);

var 
pointerValue = f_10497_18157_18288(factory, localType, addr, f_10497_18242_18287(fixedInitializer))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,18373,18607);

BoundExpression 
pinAndGetPtr = f_10497_18404_18606(factory, locals: ImmutableArray<LocalSymbol>.Empty, sideEffects: f_10497_18512_18566(tempAssignment), result: pointerValue)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,18623,19150) || true) && (needNullCheck)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10497,18623,19150);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,18765,19135);

pinAndGetPtr = f_10497_18780_19134(initializerSyntax, initializerExpr, hasValueMethodOpt: null, whenNotNull: pinAndGetPtr, whenNullOpt: null, currentConditionalAccessID, localType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10497,18623,19150);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,19259,19410);

BoundStatement 
localInit = f_10497_19286_19409(this, localDecl, localSymbol, f_10497_19348_19408(factory, f_10497_19367_19393(factory, localSymbol), pinAndGetPtr))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,19426,19443);

return localInit;
DynAbs.Tracing.TraceSender.TraceExitMethod(10497,15288,19454);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10497_15636_15652(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 15636, 15652);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10497_15717_15744(Microsoft.CodeAnalysis.CSharp.BoundFixedLocalCollectionInitializer
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 15717, 15744);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10497_15701_15745(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 15701, 15745);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10497_15773_15793(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 15773, 15793);
return return_v;
}


int
f_10497_15760_15801(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 15760, 15801);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10497_15840_15860(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 15840, 15860);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10497_15960_15991(Microsoft.CodeAnalysis.CSharp.BoundFixedLocalCollectionInitializer
this_param)
{
var return_v = this_param.GetPinnableOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 15960, 15991);
return return_v;
}


int
f_10497_16006_16044(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 16006, 16044);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax?
f_10497_16192_16263(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.FirstAncestorOrSelf<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 16192, 16263);
return return_v;
}


int
f_10497_16278_16310(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 16278, 16310);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10497_16425_16453(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ReturnType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 16425, 16453);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10497_16382_16831(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
syntax,bool
isPinned,Microsoft.CodeAnalysis.RefKind
refKind,Microsoft.CodeAnalysis.SynthesizedLocalKind
kind)
{
var return_v = this_param.SynthesizedLocal( type, syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, isPinned: isPinned, refKind: refKind, kind: kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 16382, 16831);
return return_v;
}


bool
f_10497_16963_16991_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 16963, 16991);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundConditionalReceiver
f_10497_17151_17307(Microsoft.CodeAnalysis.SyntaxNode
syntax,int
id,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConditionalReceiver( syntax, id, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 17151, 17307);
return return_v;
}


bool
f_10497_17489_17515(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.IsStatic ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 17489, 17515);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10497_17535_17586(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg0)
{
var return_v = this_param.Call( receiver, method, arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 17535, 17586);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10497_17606_17651(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = this_param.Call( receiver, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 17606, 17651);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10497_17777_17802(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local)
{
var return_v = this_param.Local( local);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 17777, 17802);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
f_10497_17730_17867(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
left,Microsoft.CodeAnalysis.CSharp.BoundCall
right,bool
isRef)
{
var return_v = this_param.AssignmentExpression( (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right, isRef: isRef);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 17730, 17867);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_10497_17968_17982(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.Syntax;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 17968, 17982);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10497_18001_18026(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local)
{
var return_v = this_param.Local( local);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 18001, 18026);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10497_18051_18086(Microsoft.CodeAnalysis.CSharp.BoundFixedLocalCollectionInitializer
this_param)
{
var return_v = this_param.ElementPointerType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 18051, 18086);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
f_10497_17923_18087(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
operand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)operand, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 17923, 18087);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10497_18242_18287(Microsoft.CodeAnalysis.CSharp.BoundFixedLocalCollectionInitializer
this_param)
{
var return_v = this_param.ElementPointerTypeConversion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 18242, 18287);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10497_18157_18288(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
arg,Microsoft.CodeAnalysis.CSharp.Conversion
conversion)
{
var return_v = this_param.Convert( type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg, conversion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 18157, 18288);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10497_18512_18566(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
var return_v = ImmutableArray.Create<BoundExpression>( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 18512, 18566);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10497_18404_18606(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
result)
{
var return_v = this_param.Sequence( locals: locals, sideEffects: sideEffects, result: result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 18404, 18606);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
f_10497_18780_19134(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
hasValueMethodOpt,Microsoft.CodeAnalysis.CSharp.BoundExpression
whenNotNull,Microsoft.CodeAnalysis.CSharp.BoundExpression?
whenNullOpt,int
id,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess( syntax, receiver, hasValueMethodOpt: hasValueMethodOpt, whenNotNull: whenNotNull, whenNullOpt: whenNullOpt, id, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 18780, 19134);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10497_19367_19393(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local)
{
var return_v = this_param.Local( local);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 19367, 19393);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
f_10497_19348_19408(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right)
{
var return_v = this_param.Assignment( (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 19348, 19408);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10497_19286_19409(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
originalOpt,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
localSymbol,Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
rewrittenLocalDeclaration)
{
var return_v = this_param.InstrumentLocalDeclarationIfNecessary( originalOpt, localSymbol, (Microsoft.CodeAnalysis.CSharp.BoundStatement)rewrittenLocalDeclaration);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 19286, 19409);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10497,15288,19454);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10497,15288,19454);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundStatement InitializeFixedStatementStringLocal(
            BoundLocalDeclaration localDecl,
            LocalSymbol localSymbol,
            BoundFixedLocalCollectionInitializer fixedInitializer,
            SyntheticBoundNodeFactory factory,
            out LocalSymbol pinnedTemp)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10497,19846,22908);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,20171,20211);

TypeSymbol 
localType = f_10497_20194_20210(localSymbol)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,20225,20304);

BoundExpression 
initializerExpr = f_10497_20259_20303(this, f_10497_20275_20302(fixedInitializer))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,20318,20369);

TypeSymbol? 
initializerType = f_10497_20348_20368(initializerExpr)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,20383,20420);

f_10497_20383_20419(initializerType is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,20528,20639);

VariableDeclaratorSyntax? 
declarator = f_10497_20567_20638(fixedInitializer.Syntax)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,20653,20686);

f_10497_20653_20685(declarator != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,20702,20905);

pinnedTemp = f_10497_20715_20904(factory, initializerType, syntax: declarator, isPinned: true, kind: SynthesizedLocalKind.FixedReference);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,20979,21013);

f_10497_20979_21012(f_10497_20992_21011(pinnedTemp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,21027,21063);

f_10497_21027_21062(f_10497_21040_21061_M(!localSymbol.IsPinned));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,21079,21174);

BoundStatement 
stringTempInit = f_10497_21111_21173(factory, f_10497_21130_21155(factory, pinnedTemp), initializerExpr)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,21225,21405);

var 
addr = f_10497_21236_21404(factory, f_10497_21271_21306(fixedInitializer), f_10497_21326_21351(                 factory, pinnedTemp), Conversion.PinnedObjectToPointer)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,21421,21579);

var 
convertedStringTemp = f_10497_21447_21578(factory, localType, addr, f_10497_21532_21577(fixedInitializer))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,21595,21770);

BoundStatement 
localInit = f_10497_21622_21769(this, localDecl, localSymbol, f_10497_21701_21768(                factory, f_10497_21720_21746(factory, localSymbol), convertedStringTemp))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,21786,21904);

BoundExpression 
notNullCheck = f_10497_21817_21903(this, f_10497_21831_21845(factory), f_10497_21847_21873(factory, localSymbol), BinaryOperatorKind.NotEqual)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,21918,21945);

BoundExpression 
helperCall
=default(BoundExpression);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,21961,21987);

MethodSymbol 
offsetMethod
=default(MethodSymbol);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,22001,22537) || true) && (f_10497_22005_22161(this, fixedInitializer.Syntax, WellKnownMember.System_Runtime_CompilerServices_RuntimeHelpers__get_OffsetToStringData, out offsetMethod))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10497,22001,22537);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,22195,22259);

helperCall = f_10497_22208_22258(factory, receiver: null, method: offsetMethod);
DynAbs.Tracing.TraceSender.TraceExitCondition(10497,22001,22537);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10497,22001,22537);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,22325,22522);

helperCall = f_10497_22338_22521(fixedInitializer.Syntax, LookupResultKind.NotInvocable, ImmutableArray<Symbol?>.Empty, ImmutableArray<BoundExpression>.Empty, ErrorTypeSymbol.UnknownResultType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10497,22001,22537);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,22553,22688);

BoundExpression 
addition = f_10497_22580_22687(factory, BinaryOperatorKind.PointerAndIntAddition, localType, f_10497_22648_22674(factory, localSymbol), helperCall)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,22702,22817);

BoundStatement 
conditionalAdd = f_10497_22734_22816(factory, notNullCheck, f_10497_22759_22815(factory, f_10497_22778_22804(factory, localSymbol), addition))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,22833,22897);

return f_10497_22840_22896(factory, stringTempInit, localInit, conditionalAdd);
DynAbs.Tracing.TraceSender.TraceExitMethod(10497,19846,22908);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10497_20194_20210(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 20194, 20210);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10497_20275_20302(Microsoft.CodeAnalysis.CSharp.BoundFixedLocalCollectionInitializer
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 20275, 20302);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10497_20259_20303(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 20259, 20303);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10497_20348_20368(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 20348, 20368);
return return_v;
}


int
f_10497_20383_20419(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 20383, 20419);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax?
f_10497_20567_20638(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.FirstAncestorOrSelf<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 20567, 20638);
return return_v;
}


int
f_10497_20653_20685(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 20653, 20685);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10497_20715_20904(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
syntax,bool
isPinned,Microsoft.CodeAnalysis.SynthesizedLocalKind
kind)
{
var return_v = this_param.SynthesizedLocal( type, syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, isPinned: isPinned, kind: kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 20715, 20904);
return return_v;
}


bool
f_10497_20992_21011(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
this_param)
{
var return_v = this_param.IsPinned;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 20992, 21011);
return return_v;
}


int
f_10497_20979_21012(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 20979, 21012);
return 0;
}


bool
f_10497_21040_21061_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 21040, 21061);
return return_v;
}


int
f_10497_21027_21062(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 21027, 21062);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10497_21130_21155(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local)
{
var return_v = this_param.Local( local);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 21130, 21155);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
f_10497_21111_21173(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right)
{
var return_v = this_param.Assignment( (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 21111, 21173);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10497_21271_21306(Microsoft.CodeAnalysis.CSharp.BoundFixedLocalCollectionInitializer
this_param)
{
var return_v = this_param.ElementPointerType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 21271, 21306);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10497_21326_21351(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local)
{
var return_v = this_param.Local( local);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 21326, 21351);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10497_21236_21404(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundLocal
arg,Microsoft.CodeAnalysis.CSharp.Conversion
conversion)
{
var return_v = this_param.Convert( type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg, conversion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 21236, 21404);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10497_21532_21577(Microsoft.CodeAnalysis.CSharp.BoundFixedLocalCollectionInitializer
this_param)
{
var return_v = this_param.ElementPointerTypeConversion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 21532, 21577);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10497_21447_21578(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg,Microsoft.CodeAnalysis.CSharp.Conversion
conversion)
{
var return_v = this_param.Convert( type, arg, conversion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 21447, 21578);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10497_21720_21746(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local)
{
var return_v = this_param.Local( local);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 21720, 21746);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
f_10497_21701_21768(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right)
{
var return_v = this_param.Assignment( (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 21701, 21768);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10497_21622_21769(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
originalOpt,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
localSymbol,Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
rewrittenLocalDeclaration)
{
var return_v = this_param.InstrumentLocalDeclarationIfNecessary( originalOpt, localSymbol, (Microsoft.CodeAnalysis.CSharp.BoundStatement)rewrittenLocalDeclaration);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 21622, 21769);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_10497_21831_21845(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.Syntax;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 21831, 21845);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10497_21847_21873(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local)
{
var return_v = this_param.Local( local);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 21847, 21873);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10497_21817_21903(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
rewrittenExpr,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind)
{
var return_v = this_param.MakeNullCheck( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)rewrittenExpr, operatorKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 21817, 21903);
return return_v;
}


bool
f_10497_22005_22161(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.WellKnownMember
member,out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
symbol)
{
var return_v = this_param.TryGetWellKnownTypeMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( syntax, member, out symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 22005, 22161);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10497_22208_22258(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = this_param.Call( receiver: receiver, method: method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 22208, 22258);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBadExpression
f_10497_22338_22521(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol?>
symbols,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
childBoundNodes,Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression( syntax, resultKind, symbols, childBoundNodes, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 22338, 22521);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10497_22648_22674(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local)
{
var return_v = this_param.Local( local);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 22648, 22674);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10497_22580_22687(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundLocal
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right)
{
var return_v = this_param.Binary( kind, type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 22580, 22687);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10497_22778_22804(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local)
{
var return_v = this_param.Local( local);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 22778, 22804);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
f_10497_22759_22815(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right)
{
var return_v = this_param.Assignment( (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 22759, 22815);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10497_22734_22816(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
condition,Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
thenClause)
{
var return_v = this_param.If( condition, (Microsoft.CodeAnalysis.CSharp.BoundStatement)thenClause);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 22734, 22816);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10497_22840_22896(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
statements)
{
var return_v = this_param.Block( statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 22840, 22896);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10497,19846,22908);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10497,19846,22908);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundStatement InitializeFixedStatementArrayLocal(
            BoundLocalDeclaration localDecl,
            LocalSymbol localSymbol,
            BoundFixedLocalCollectionInitializer fixedInitializer,
            SyntheticBoundNodeFactory factory,
            out LocalSymbol pinnedTemp)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10497,23368,27467);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,23692,23732);

TypeSymbol 
localType = f_10497_23715_23731(localSymbol)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,23746,23825);

BoundExpression 
initializerExpr = f_10497_23780_23824(this, f_10497_23796_23823(fixedInitializer))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,23839,23890);

TypeSymbol? 
initializerType = f_10497_23869_23889(initializerExpr)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,23904,23941);

f_10497_23904_23940(initializerType is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,23957,24028);

pinnedTemp = f_10497_23970_24027(factory, initializerType, isPinned: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,24042,24103);

ArrayTypeSymbol 
arrayType = (ArrayTypeSymbol)f_10497_24087_24102(pinnedTemp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,24117,24193);

TypeWithAnnotations 
arrayElementType = f_10497_24156_24192(arrayType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,24266,24300);

f_10497_24266_24299(f_10497_24279_24298(pinnedTemp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,24314,24350);

f_10497_24314_24349(f_10497_24327_24348_M(!localSymbol.IsPinned));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,24402,24507);

BoundExpression 
arrayTempInit = f_10497_24434_24506(factory, f_10497_24463_24488(factory, pinnedTemp), initializerExpr)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,24567,24672);

BoundExpression 
notNullCheck = f_10497_24598_24671(this, f_10497_24612_24626(factory), arrayTempInit, BinaryOperatorKind.NotEqual)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,24688,24715);

BoundExpression 
lengthCall
=default(BoundExpression);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,24731,25522) || true) && (f_10497_24735_24754(arrayType))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10497,24731,25522);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,24788,24848);

lengthCall = f_10497_24801_24847(factory, f_10497_24821_24846(factory, pinnedTemp));
DynAbs.Tracing.TraceSender.TraceExitCondition(10497,24731,25522);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10497,24731,25522);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,24914,24940);

MethodSymbol 
lengthMethod
=default(MethodSymbol);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,24958,25507) || true) && (f_10497_24962_25072(this, fixedInitializer.Syntax, WellKnownMember.System_Array__get_Length, out lengthMethod))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10497,24958,25507);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,25114,25181);

lengthCall = f_10497_25127_25180(factory, f_10497_25140_25165(factory, pinnedTemp), lengthMethod);
DynAbs.Tracing.TraceSender.TraceExitCondition(10497,24958,25507);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10497,24958,25507);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,25263,25488);

lengthCall = f_10497_25276_25487(fixedInitializer.Syntax, LookupResultKind.NotInvocable, ImmutableArray<Symbol?>.Empty, f_10497_25386_25451(f_10497_25425_25450(factory, pinnedTemp)), ErrorTypeSymbol.UnknownResultType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10497,24958,25507);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10497,24731,25522);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,25646,25804);

BoundExpression 
lengthCheck = f_10497_25676_25803(factory, BinaryOperatorKind.IntNotEqual, f_10497_25723_25770(factory, SpecialType.System_Boolean), lengthCall, f_10497_25784_25802(factory, 0))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,25880,26034);

BoundExpression 
condition = f_10497_25908_26033(factory, BinaryOperatorKind.LogicalBoolAnd, f_10497_25958_26005(factory, SpecialType.System_Boolean), notNullCheck, lengthCheck)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,26073,26163);

BoundExpression 
firstElement = f_10497_26104_26162(factory, f_10497_26136_26161(factory, pinnedTemp))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,26309,26451);

BoundExpression 
firstElementAddress = f_10497_26347_26450(f_10497_26374_26388(factory), firstElement, type: f_10497_26410_26449(arrayElementType))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,26465,26659);

BoundExpression 
convertedFirstElementAddress = f_10497_26512_26658(factory, localType, firstElementAddress, f_10497_26612_26657(fixedInitializer))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,26705,26832);

BoundExpression 
consequenceAssignment = f_10497_26745_26831(factory, f_10497_26774_26800(factory, localSymbol), convertedFirstElementAddress)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,26874,26996);

BoundExpression 
alternativeAssignment = f_10497_26914_26995(factory, f_10497_26943_26969(factory, localSymbol), f_10497_26971_26994(factory, localType))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,27104,27360);

BoundStatement 
localInit = f_10497_27131_27359(factory, f_10497_27177_27358(f_10497_27206_27220(factory), false, condition, consequenceAssignment, alternativeAssignment, ConstantValue.NotAvailable, localType, wasTargetTyped: false, localType))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10497,27376,27456);

return f_10497_27383_27455(this, localDecl, localSymbol, localInit);
DynAbs.Tracing.TraceSender.TraceExitMethod(10497,23368,27467);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10497_23715_23731(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 23715, 23731);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10497_23796_23823(Microsoft.CodeAnalysis.CSharp.BoundFixedLocalCollectionInitializer
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 23796, 23823);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10497_23780_23824(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 23780, 23824);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10497_23869_23889(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 23869, 23889);
return return_v;
}


int
f_10497_23904_23940(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 23904, 23940);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10497_23970_24027(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,bool
isPinned)
{
var return_v = this_param.SynthesizedLocal( type, isPinned: isPinned);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 23970, 24027);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10497_24087_24102(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 24087, 24102);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
f_10497_24156_24192(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
this_param)
{
var return_v = this_param.ElementTypeWithAnnotations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 24156, 24192);
return return_v;
}


bool
f_10497_24279_24298(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
this_param)
{
var return_v = this_param.IsPinned;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 24279, 24298);
return return_v;
}


int
f_10497_24266_24299(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 24266, 24299);
return 0;
}


bool
f_10497_24327_24348_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 24327, 24348);
return return_v;
}


int
f_10497_24314_24349(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 24314, 24349);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10497_24463_24488(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local)
{
var return_v = this_param.Local( local);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 24463, 24488);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
f_10497_24434_24506(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right)
{
var return_v = this_param.AssignmentExpression( (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 24434, 24506);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_10497_24612_24626(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.Syntax;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 24612, 24626);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10497_24598_24671(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenExpr,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind)
{
var return_v = this_param.MakeNullCheck( syntax, rewrittenExpr, operatorKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 24598, 24671);
return return_v;
}


bool
f_10497_24735_24754(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
this_param)
{
var return_v = this_param.IsSZArray;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 24735, 24754);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10497_24821_24846(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local)
{
var return_v = this_param.Local( local);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 24821, 24846);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundArrayLength
f_10497_24801_24847(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
array)
{
var return_v = this_param.ArrayLength( (Microsoft.CodeAnalysis.CSharp.BoundExpression)array);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 24801, 24847);
return return_v;
}


bool
f_10497_24962_25072(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.WellKnownMember
member,out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
symbol)
{
var return_v = this_param.TryGetWellKnownTypeMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( syntax, member, out symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 24962, 25072);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10497_25140_25165(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local)
{
var return_v = this_param.Local( local);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 25140, 25165);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10497_25127_25180(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = this_param.Call( (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 25127, 25180);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10497_25425_25450(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local)
{
var return_v = this_param.Local( local);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 25425, 25450);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10497_25386_25451(Microsoft.CodeAnalysis.CSharp.BoundLocal
item)
{
var return_v = ImmutableArray.Create<BoundExpression>( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 25386, 25451);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBadExpression
f_10497_25276_25487(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol?>
symbols,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
childBoundNodes,Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression( syntax, resultKind, symbols, childBoundNodes, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 25276, 25487);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10497_25723_25770(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.SpecialType
st)
{
var return_v = this_param.SpecialType( st);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 25723, 25770);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10497_25784_25802(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,int
value)
{
var return_v = this_param.Literal( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 25784, 25802);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10497_25676_25803(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundLiteral
right)
{
var return_v = this_param.Binary( kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 25676, 25803);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10497_25958_26005(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.SpecialType
st)
{
var return_v = this_param.SpecialType( st);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 25958, 26005);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10497_25908_26033(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right)
{
var return_v = this_param.Binary( kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 25908, 26033);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10497_26136_26161(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local)
{
var return_v = this_param.Local( local);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 26136, 26161);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
f_10497_26104_26162(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
array)
{
var return_v = this_param.ArrayAccessFirstElement( (Microsoft.CodeAnalysis.CSharp.BoundExpression)array);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 26104, 26162);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_10497_26374_26388(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.Syntax;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 26374, 26388);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
f_10497_26410_26449(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
pointedAtType)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol( pointedAtType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 26410, 26449);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
f_10497_26347_26450(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
operand,Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator( syntax, operand, type: (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 26347, 26450);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10497_26612_26657(Microsoft.CodeAnalysis.CSharp.BoundFixedLocalCollectionInitializer
this_param)
{
var return_v = this_param.ElementPointerTypeConversion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 26612, 26657);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10497_26512_26658(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg,Microsoft.CodeAnalysis.CSharp.Conversion
conversion)
{
var return_v = this_param.Convert( type, arg, conversion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 26512, 26658);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10497_26774_26800(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local)
{
var return_v = this_param.Local( local);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 26774, 26800);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
f_10497_26745_26831(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right)
{
var return_v = this_param.AssignmentExpression( (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 26745, 26831);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10497_26943_26969(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local)
{
var return_v = this_param.Local( local);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 26943, 26969);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10497_26971_26994(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Null( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 26971, 26994);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
f_10497_26914_26995(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right)
{
var return_v = this_param.AssignmentExpression( (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 26914, 26995);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_10497_27206_27220(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.Syntax;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10497, 27206, 27220);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
f_10497_27177_27358(Microsoft.CodeAnalysis.SyntaxNode
syntax,bool
isRef,Microsoft.CodeAnalysis.CSharp.BoundExpression
condition,Microsoft.CodeAnalysis.CSharp.BoundExpression
consequence,Microsoft.CodeAnalysis.CSharp.BoundExpression
alternative,Microsoft.CodeAnalysis.ConstantValue
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
naturalTypeOpt,bool
wasTargetTyped,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator( syntax, isRef, condition, consequence, alternative, constantValueOpt, naturalTypeOpt, wasTargetTyped: wasTargetTyped, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 27177, 27358);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
f_10497_27131_27359(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
expr)
{
var return_v = this_param.ExpressionStatement( (Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 27131, 27359);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10497_27383_27455(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
originalOpt,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
localSymbol,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewrittenLocalDeclaration)
{
var return_v = this_param.InstrumentLocalDeclarationIfNecessary( originalOpt, localSymbol, rewrittenLocalDeclaration);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10497, 27383, 27455);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10497,23368,27467);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10497,23368,27467);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
