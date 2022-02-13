// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitAssignmentOperator(BoundAssignmentOperator node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10479,508,724);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,664,713);

return f_10479_671_712(this, node, used: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(10479,508,724);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10479_671_712(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
node,bool
used)
{
var return_v = this_param.VisitAssignmentOperator( node, used: used);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 671, 712);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10479,508,724);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10479,508,724);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

        private BoundExpression VisitAssignmentOperator(BoundAssignmentOperator node, bool used)
        {
            var loweredRight = VisitExpression(node.Right);

            BoundExpression left = node.Left;
            BoundExpression loweredLeft;
            switch (left.Kind)
            {
                case BoundKind.PropertyAccess:
                    loweredLeft = VisitPropertyAccess((BoundPropertyAccess)left, isLeftOfAssignment: true);
                    break;

                case BoundKind.IndexerAccess:
                    loweredLeft = VisitIndexerAccess((BoundIndexerAccess)left, isLeftOfAssignment: true);
                    break;

                case BoundKind.IndexOrRangePatternIndexerAccess:
                    loweredLeft = VisitIndexOrRangePatternIndexerAccess(
                        (BoundIndexOrRangePatternIndexerAccess)left,
                        isLeftOfAssignment: true);
                    break;

                case BoundKind.EventAccess:
                    {
                        BoundEventAccess eventAccess = (BoundEventAccess)left;
                        if (eventAccess.EventSymbol.IsWindowsRuntimeEvent)
                        {
                            Debug.Assert(!node.IsRef);
                            return VisitWindowsRuntimeEventFieldAssignmentOperator(node.Syntax, eventAccess, loweredRight);
                        }
                        goto default;
                    }

                case BoundKind.DynamicMemberAccess:
                    {
                        // dyn.m = expr
                        var memberAccess = (BoundDynamicMemberAccess)left;
                        var loweredReceiver = VisitExpression(memberAccess.Receiver);
                        return _dynamicFactory.MakeDynamicSetMember(loweredReceiver, memberAccess.Name, loweredRight).ToExpression();
                    }

                case BoundKind.DynamicIndexerAccess:
                    {
                        // dyn[args] = expr
                        var indexerAccess = (BoundDynamicIndexerAccess)left;
                        var loweredReceiver = VisitExpression(indexerAccess.Receiver);
                        var loweredArguments = VisitList(indexerAccess.Arguments);
                        return MakeDynamicSetIndex(
                            indexerAccess,
                            loweredReceiver,
                            loweredArguments,
                            indexerAccess.ArgumentNamesOpt,
                            indexerAccess.ArgumentRefKindsOpt,
                            loweredRight);
                    }

                default:
                    loweredLeft = VisitExpression(left);
                    break;
            }

            return MakeStaticAssignmentOperator(node.Syntax, loweredLeft, loweredRight, node.IsRef, node.Type, used);
        }

private BoundExpression MakeAssignmentOperator(SyntaxNode syntax, BoundExpression rewrittenLeft, BoundExpression rewrittenRight, TypeSymbol type,
            bool used, bool isChecked, bool isCompoundAssignment)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10479,3914,6714);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,4151,6703);

switch (f_10479_4159_4177(rewrittenLeft))
            {

case BoundKind.DynamicIndexerAccess:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10479,4151,6703);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,4269,4330);

var 
indexerAccess = (BoundDynamicIndexerAccess)rewrittenLeft
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,4352,4735);

return f_10479_4359_4734(this, indexerAccess, f_10479_4445_4467(indexerAccess), f_10479_4494_4517(indexerAccess), f_10479_4544_4574(indexerAccess), f_10479_4601_4634(indexerAccess), rewrittenRight, isCompoundAssignment, isChecked);
DynAbs.Tracing.TraceSender.TraceExitCondition(10479,4151,6703);

case BoundKind.DynamicMemberAccess:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10479,4151,6703);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,4812,4871);

var 
memberAccess = (BoundDynamicMemberAccess)rewrittenLeft
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,4893,5169);

return f_10479_4900_5153(_dynamicFactory, f_10479_4963_4984(memberAccess), f_10479_5011_5028(memberAccess), rewrittenRight, isCompoundAssignment, isChecked).ToExpression();
DynAbs.Tracing.TraceSender.TraceExitCondition(10479,4151,6703);

case BoundKind.EventAccess:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10479,4151,6703);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,5238,5288);

var 
eventAccess = (BoundEventAccess)rewrittenLeft
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,5310,5352);

f_10479_5310_5351(f_10479_5323_5350(eventAccess));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,5374,6117) || true) && (f_10479_5378_5423(f_10479_5378_5401(eventAccess)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10479,5374,6117);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,5473,5502);

const bool 
isDynamic = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,5528,6094);

return f_10479_5535_6093(this, eventAccess.Syntax, f_10479_5677_5700(eventAccess), EventAssignmentKind.Assignment, isDynamic, f_10479_5976_5999(eventAccess), rewrittenRight);
DynAbs.Tracing.TraceSender.TraceExitCondition(10479,5374,6117);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,6488,6525);

throw f_10479_6494_6524();
DynAbs.Tracing.TraceSender.TraceExitCondition(10479,4151,6703);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10479,4151,6703);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,6575,6688);

return f_10479_6582_6687(this, syntax, rewrittenLeft, rewrittenRight, isRef: false, type: type, used: used);
DynAbs.Tracing.TraceSender.TraceExitCondition(10479,4151,6703);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(10479,3914,6714);

Microsoft.CodeAnalysis.CSharp.BoundKind
f_10479_4159_4177(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10479, 4159, 4177);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10479_4445_4467(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
this_param)
{
var return_v = this_param.Receiver;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10479, 4445, 4467);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10479_4494_4517(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10479, 4494, 4517);
return return_v;
}


System.Collections.Immutable.ImmutableArray<string>
f_10479_4544_4574(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
this_param)
{
var return_v = this_param.ArgumentNamesOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10479, 4544, 4574);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
f_10479_4601_4634(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
this_param)
{
var return_v = this_param.ArgumentRefKindsOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10479, 4601, 4634);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10479_4359_4734(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
indexerAccess,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredReceiver,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
loweredArguments,System.Collections.Immutable.ImmutableArray<string>
argumentNames,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
refKinds,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,bool
isCompoundAssignment,bool
isChecked)
{
var return_v = this_param.MakeDynamicSetIndex( indexerAccess, loweredReceiver, loweredArguments, argumentNames, refKinds, loweredRight, isCompoundAssignment, isChecked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 4359, 4734);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10479_4963_4984(Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
this_param)
{
var return_v = this_param.Receiver;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10479, 4963, 4984);
return return_v;
}


string
f_10479_5011_5028(Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10479, 5011, 5028);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
f_10479_4900_5153(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredReceiver,string
name,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,bool
isCompoundAssignment,bool
isChecked)
{
var return_v = this_param.MakeDynamicSetMember( loweredReceiver, name, loweredRight, isCompoundAssignment, isChecked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 4900, 5153);
return return_v;
}


bool
f_10479_5323_5350(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.IsUsableAsField;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10479, 5323, 5350);
return return_v;
}


int
f_10479_5310_5351(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 5310, 5351);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
f_10479_5378_5401(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.EventSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10479, 5378, 5401);
return return_v;
}


bool
f_10479_5378_5423(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
this_param)
{
var return_v = this_param.IsWindowsRuntimeEvent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10479, 5378, 5423);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
f_10479_5677_5700(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.EventSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10479, 5677, 5700);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10479_5976_5999(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.ReceiverOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10479, 5976, 5999);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10479_5535_6093(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
eventSymbol,Microsoft.CodeAnalysis.CSharp.LocalRewriter.EventAssignmentKind
kind,bool
isDynamic,Microsoft.CodeAnalysis.CSharp.BoundExpression?
rewrittenReceiverOpt,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenArgument)
{
var return_v = this_param.RewriteWindowsRuntimeEventAssignmentOperator( syntax, eventSymbol, kind, isDynamic, rewrittenReceiverOpt, rewrittenArgument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 5535, 6093);
return return_v;
}


System.Exception
f_10479_6494_6524()
{
var return_v = ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10479, 6494, 6524);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10479_6582_6687(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenRight,bool
isRef,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,bool
used)
{
var return_v = this_param.MakeStaticAssignmentOperator( syntax, rewrittenLeft, rewrittenRight, isRef: isRef, type: type, used: used);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 6582, 6687);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10479,3914,6714);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10479,3914,6714);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeDynamicSetIndex(
            BoundDynamicIndexerAccess indexerAccess,
            BoundExpression loweredReceiver,
            ImmutableArray<BoundExpression> loweredArguments,
            ImmutableArray<string> argumentNames,
            ImmutableArray<RefKind> refKinds,
            BoundExpression loweredRight,
            bool isCompoundAssignment = false,
            bool isChecked = false)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10479,6726,7782);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,7351,7438);

f_10479_7351_7437(this, loweredReceiver, f_10479_7382_7414(indexerAccess), indexerAccess.Syntax);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,7454,7771);

return f_10479_7461_7755(_dynamicFactory, f_10479_7515_7579(this, indexerAccess, loweredReceiver), loweredArguments, argumentNames, refKinds, loweredRight, isCompoundAssignment, isChecked).ToExpression();
DynAbs.Tracing.TraceSender.TraceExitMethod(10479,6726,7782);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
f_10479_7382_7414(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
this_param)
{
var return_v = this_param.ApplicableIndexers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10479, 7382, 7414);
return return_v;
}


int
f_10479_7351_7437(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiver,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
properties,Microsoft.CodeAnalysis.SyntaxNode
syntaxNode)
{
this_param.EmbedIfNeedTo( receiver, properties, syntaxNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 7351, 7437);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10479_7515_7579(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
indexerAccess,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredReceiver)
{
var return_v = this_param.MakeDynamicIndexerAccessReceiver( indexerAccess, loweredReceiver);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 7515, 7579);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
f_10479_7461_7755(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredReceiver,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
loweredArguments,System.Collections.Immutable.ImmutableArray<string>
argumentNames,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
refKinds,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,bool
isCompoundAssignment,bool
isChecked)
{
var return_v = this_param.MakeDynamicSetIndex( loweredReceiver, loweredArguments, argumentNames, refKinds, loweredRight, isCompoundAssignment, isChecked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 7461, 7755);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10479,6726,7782);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10479,6726,7782);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

        /// <summary>
        /// Generates a lowered form of the assignment operator for the given left and right sub-expressions.
        /// Left and right sub-expressions must be in lowered form.
        /// </summary>
        private BoundExpression MakeStaticAssignmentOperator(
            SyntaxNode syntax,
            BoundExpression rewrittenLeft,
            BoundExpression rewrittenRight,
            bool isRef,
            TypeSymbol type,
            bool used)
        {
            switch (rewrittenLeft.Kind)
            {
                case BoundKind.DynamicIndexerAccess:
                case BoundKind.DynamicMemberAccess:
                    throw ExceptionUtilities.UnexpectedValue(rewrittenLeft.Kind);

                case BoundKind.PropertyAccess:
                    {
                        Debug.Assert(!isRef);
                        BoundPropertyAccess propertyAccess = (BoundPropertyAccess)rewrittenLeft;
                        BoundExpression? rewrittenReceiver = propertyAccess.ReceiverOpt;
                        PropertySymbol property = propertyAccess.PropertySymbol;
                        Debug.Assert(!property.IsIndexer);
                        return MakePropertyAssignment(
                            syntax,
                            rewrittenReceiver,
                            property,
                            ImmutableArray<BoundExpression>.Empty,
                            default(ImmutableArray<RefKind>),
                            false,
                            default(ImmutableArray<int>),
                            rewrittenRight,
                            type,
                            used);
                    }

                case BoundKind.IndexerAccess:
                    {
                        Debug.Assert(!isRef);
                        BoundIndexerAccess indexerAccess = (BoundIndexerAccess)rewrittenLeft;
                        BoundExpression? rewrittenReceiver = indexerAccess.ReceiverOpt;
                        ImmutableArray<BoundExpression> rewrittenArguments = indexerAccess.Arguments;
                        PropertySymbol indexer = indexerAccess.Indexer;
                        Debug.Assert(indexer.IsIndexer || indexer.IsIndexedProperty);
                        return MakePropertyAssignment(
                            syntax,
                            rewrittenReceiver,
                            indexer,
                            rewrittenArguments,
                            indexerAccess.ArgumentRefKindsOpt,
                            indexerAccess.Expanded,
                            indexerAccess.ArgsToParamsOpt,
                            rewrittenRight,
                            type,
                            used);
                    }

                case BoundKind.Local:
                    {
                        Debug.Assert(!isRef || ((BoundLocal)rewrittenLeft).LocalSymbol.RefKind != RefKind.None);
                        return new BoundAssignmentOperator(
                            syntax,
                            rewrittenLeft,
                            rewrittenRight,
                            type,
                            isRef: isRef);
                    }

                case BoundKind.Parameter:
                    {
                        Debug.Assert(!isRef || rewrittenLeft.GetRefKind() != RefKind.None);
                        return new BoundAssignmentOperator(
                            syntax,
                            rewrittenLeft,
                            rewrittenRight,
                            isRef,
                            type);
                    }

                case BoundKind.DiscardExpression:
                    {
                        return rewrittenRight;
                    }

                case BoundKind.Sequence:
                    // An Index or Range pattern-based indexer produces a sequence with a nested
                    // BoundIndexerAccess. We need to lower the final expression and produce an
                    // update sequence
                    var sequence = (BoundSequence)rewrittenLeft;
                    if (sequence.Value.Kind == BoundKind.IndexerAccess)
                    {
                        return sequence.Update(
                            sequence.Locals,
                            sequence.SideEffects,
                            MakeStaticAssignmentOperator(
                                syntax,
                                sequence.Value,
                                rewrittenRight,
                                isRef,
                                type,
                                used),
                            type);
                    }
                    goto default;

                default:
                    {
                        Debug.Assert(!isRef);
                        return new BoundAssignmentOperator(
                            syntax,
                            rewrittenLeft,
                            rewrittenRight,
                            type);
                    }
            }
        }

private BoundExpression MakePropertyAssignment(
            SyntaxNode syntax,
            BoundExpression? rewrittenReceiver,
            PropertySymbol property,
            ImmutableArray<BoundExpression> rewrittenArguments,
            ImmutableArray<RefKind> argumentRefKindsOpt,
            bool expanded,
            ImmutableArray<int> argsToParamsOpt,
            BoundExpression rewrittenRight,
            TypeSymbol type,
            bool used)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10479,13093,16947);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,13649,13703);

var 
setMethod = f_10479_13665_13702(property)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,13719,14219) || true) && (setMethod is null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10479,13719,14219);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,13774,13824);

var 
autoProp = (SourcePropertySymbolBase)property
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,13842,13980);

f_10479_13842_13979(f_10479_13855_13893(autoProp), "only autoproperties can be assignable without having setters");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,14000,14041);

var 
backingField = f_10479_14019_14040(autoProp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,14059,14204);

return f_10479_14066_14203(_factory, f_10479_14118_14165(                    _factory, rewrittenReceiver, backingField), rewrittenRight);
DynAbs.Tracing.TraceSender.TraceExitCondition(10479,13719,14219);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,14504,14541);

ImmutableArray<LocalSymbol> 
argTemps
=default(ImmutableArray<LocalSymbol>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,14555,14916);

rewrittenArguments = f_10479_14576_14915(this, syntax, rewrittenArguments, property, expanded, argsToParamsOpt, ref argumentRefKindsOpt, out argTemps, invokedAsExtensionMethod: false, enableCallerInfo: ThreeState.True);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,14932,16936) || true) && (used)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10479,14932,16936);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,15199,15242);

TypeSymbol? 
exprType = f_10479_15222_15241(rewrittenRight)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,15260,15293);

f_10479_15260_15292(exprType is object);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,15313,15371);

LocalSymbol 
rhsTemp = f_10479_15335_15370(_factory, exprType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,15391,15466);

BoundExpression 
boundRhs = f_10479_15418_15465(syntax, rhsTemp, null, exprType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,15486,15675);

BoundExpression 
rhsAssignment = f_10479_15518_15674(syntax, boundRhs, rewrittenRight, exprType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,15695,15926);

BoundExpression 
setterCall = f_10479_15724_15925(syntax, rewrittenReceiver, setMethod, f_10479_15869_15924(rewrittenArguments, rhsAssignment))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,15946,16177);

return f_10479_15953_16176(syntax, f_10479_16022_16061(argTemps, rhsTemp), f_10479_16084_16117(setterCall), boundRhs, type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10479,14932,16936);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10479,14932,16936);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,16243,16469);

BoundCall 
setterCall = f_10479_16266_16468(syntax, rewrittenReceiver, setMethod, f_10479_16411_16467(rewrittenArguments, rewrittenRight))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,16489,16921) || true) && (argTemps.IsDefaultOrEmpty)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10479,16489,16921);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,16560,16578);

return setterCall;
DynAbs.Tracing.TraceSender.TraceExitCondition(10479,16489,16921);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10479,16489,16921);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,16660,16902);

return f_10479_16667_16901(syntax, argTemps, ImmutableArray<BoundExpression>.Empty, setterCall, f_10479_16880_16900(setMethod));
DynAbs.Tracing.TraceSender.TraceExitCondition(10479,16489,16921);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10479,14932,16936);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10479,13093,16947);

Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10479_13665_13702(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
property)
{
var return_v = property.GetOwnOrInheritedSetMethod();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 13665, 13702);
return return_v;
}


bool
f_10479_13855_13893(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
this_param)
{
var return_v = this_param.IsAutoPropertyWithGetAccessor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10479, 13855, 13893);
return return_v;
}


int
f_10479_13842_13979(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 13842, 13979);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedBackingFieldSymbol
f_10479_14019_14040(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
this_param)
{
var return_v = this_param.BackingField;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10479, 14019, 14040);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
f_10479_14118_14165(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedBackingFieldSymbol
f)
{
var return_v = this_param.Field( receiver, (Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)f);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 14118, 14165);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
f_10479_14066_14203(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right)
{
var return_v = this_param.AssignmentExpression( (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 14066, 14203);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10479_14576_14915(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
rewrittenArguments,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
methodOrIndexer,bool
expanded,System.Collections.Immutable.ImmutableArray<int>
argsToParamsOpt,ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
argumentRefKindsOpt,out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps,bool
invokedAsExtensionMethod,Microsoft.CodeAnalysis.ThreeState
enableCallerInfo)
{
var return_v = this_param.MakeArguments( syntax, rewrittenArguments, (Microsoft.CodeAnalysis.CSharp.Symbol)methodOrIndexer, expanded, argsToParamsOpt, ref argumentRefKindsOpt, out temps, invokedAsExtensionMethod: invokedAsExtensionMethod, enableCallerInfo: enableCallerInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 14576, 14915);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10479_15222_15241(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10479, 15222, 15241);
return return_v;
}


int
f_10479_15260_15292(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 15260, 15292);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10479_15335_15370(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.SynthesizedLocal( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 15335, 15370);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10479_15418_15465(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
localSymbol,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLocal( syntax, localSymbol, constantValueOpt, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 15418, 15465);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
f_10479_15518_15674(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator( syntax, left, right, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 15518, 15674);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10479_15869_15924(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
possibleNull,Microsoft.CodeAnalysis.CSharp.BoundExpression
newElement)
{
var return_v = AppendToPossibleNull( possibleNull, newElement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 15869, 15924);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10479_15724_15925(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt, method, arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 15724, 15925);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10479_16022_16061(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
possibleNull,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
newElement)
{
var return_v = AppendToPossibleNull( possibleNull, newElement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 16022, 16061);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10479_16084_16117(Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 16084, 16117);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10479_15953_16176(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax, locals, sideEffects, value, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 15953, 16176);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10479_16411_16467(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
possibleNull,Microsoft.CodeAnalysis.CSharp.BoundExpression
newElement)
{
var return_v = AppendToPossibleNull( possibleNull, newElement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 16411, 16467);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10479_16266_16468(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt, method, arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 16266, 16468);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10479_16880_16900(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ReturnType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10479, 16880, 16900);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10479_16667_16901(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundCall
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax, locals, sideEffects, (Microsoft.CodeAnalysis.CSharp.BoundExpression)value, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 16667, 16901);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10479,13093,16947);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10479,13093,16947);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static ImmutableArray<T> AppendToPossibleNull<T>(ImmutableArray<T> possibleNull, T newElement)
            where T : notnull
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10479,16959,17224);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,17117,17149);

f_10479_17117_17148<T>(newElement is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10479,17163,17213);

return possibleNull.NullToEmpty().Add(newElement);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10479,16959,17224);

int
f_10479_17117_17148<T>(bool
condition)            where T : notnull

{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10479, 17117, 17148);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10479,16959,17224);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10479,16959,17224);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
