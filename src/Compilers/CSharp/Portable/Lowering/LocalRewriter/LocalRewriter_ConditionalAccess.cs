// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitConditionalAccess(BoundConditionalAccess node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10487,416,634);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10487,572,623);

return f_10487_579_621(this, node, used: true)!;
DynAbs.Tracing.TraceSender.TraceExitMethod(10487,416,634);

Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10487_579_621(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundConditionalAccess
node,bool
used)
{
var return_v = this_param.RewriteConditionalAccess( node, used: used);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10487, 579, 621);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10487,416,634);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10487,416,634);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override BoundNode VisitLoweredConditionalAccess(BoundLoweredConditionalAccess node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10487,646,810);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10487,762,799);

throw f_10487_768_798();
DynAbs.Tracing.TraceSender.TraceExitMethod(10487,646,810);

System.Exception
f_10487_768_798()
{
var return_v = ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10487, 768, 798);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10487,646,810);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10487,646,810);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression? _currentConditionalAccessTarget;

private int _currentConditionalAccessID;

        private enum ConditionalAccessLoweringKind
        {
            LoweredConditionalAccess,
            Conditional,
            ConditionalCaptureReceiverByVal
        }

        // IL gen can generate more compact code for certain conditional accesses 
        // by utilizing stack dup/pop instructions 
        internal BoundExpression? RewriteConditionalAccess(BoundConditionalAccess node, bool used)
        {
            Debug.Assert(!_inExpressionLambda);
            Debug.Assert(node.AccessExpression.Type is { });

            var loweredReceiver = this.VisitExpression(node.Receiver);
            Debug.Assert(loweredReceiver.Type is { });
            var receiverType = loweredReceiver.Type;

            // Check trivial case
            if (loweredReceiver.IsDefaultValue() && receiverType.IsReferenceType)
            {
                return _factory.Default(node.Type);
            }

            ConditionalAccessLoweringKind loweringKind;
            // dynamic receivers are not directly supported in codegen and need to be lowered to a conditional
            var lowerToConditional = node.AccessExpression.Type.IsDynamic();

            if (!lowerToConditional)
            {
                // trivial cases are directly supported in IL gen
                loweringKind = ConditionalAccessLoweringKind.LoweredConditionalAccess;
            }
            else if (CanChangeValueBetweenReads(loweredReceiver))
            {
                // NOTE: dynamic operations historically do not propagate mutations
                // to the receiver if that happens to be a value type
                // so we can capture receiver by value in dynamic case regardless of 
                // the type of receiver
                // Nullable receivers are immutable so should be captured by value as well.
                loweringKind = ConditionalAccessLoweringKind.ConditionalCaptureReceiverByVal;
            }
            else
            {
                loweringKind = ConditionalAccessLoweringKind.Conditional;
            }


            var previousConditionalAccessTarget = _currentConditionalAccessTarget;
            var currentConditionalAccessID = ++_currentConditionalAccessID;

            LocalSymbol? temp = null;

            switch (loweringKind)
            {
                case ConditionalAccessLoweringKind.LoweredConditionalAccess:
                    _currentConditionalAccessTarget = new BoundConditionalReceiver(
                        loweredReceiver.Syntax,
                        currentConditionalAccessID,
                        receiverType);

                    break;

                case ConditionalAccessLoweringKind.Conditional:
                    _currentConditionalAccessTarget = loweredReceiver;
                    break;

                case ConditionalAccessLoweringKind.ConditionalCaptureReceiverByVal:
                    temp = _factory.SynthesizedLocal(receiverType);
                    _currentConditionalAccessTarget = _factory.Local(temp);
                    break;

                default:
                    throw ExceptionUtilities.UnexpectedValue(loweringKind);
            }

            BoundExpression? loweredAccessExpression;

            if (used)
            {
                loweredAccessExpression = this.VisitExpression(node.AccessExpression);
            }
            else
            {
                loweredAccessExpression = this.VisitUnusedExpression(node.AccessExpression);
                if (loweredAccessExpression == null)
                {
                    return null;
                }
            }

            Debug.Assert(loweredAccessExpression != null);
            Debug.Assert(loweredAccessExpression.Type is { });
            _currentConditionalAccessTarget = previousConditionalAccessTarget;

            TypeSymbol type = this.VisitType(node.Type);

            TypeSymbol nodeType = node.Type;
            TypeSymbol accessExpressionType = loweredAccessExpression.Type;

            if (accessExpressionType.IsVoidType())
            {
                type = nodeType = accessExpressionType;
            }

            if (!TypeSymbol.Equals(accessExpressionType, nodeType, TypeCompareKind.ConsiderEverything2) && nodeType.IsNullableType())
            {
                Debug.Assert(TypeSymbol.Equals(accessExpressionType, nodeType.GetNullableUnderlyingType(), TypeCompareKind.ConsiderEverything2));
                loweredAccessExpression = _factory.New((NamedTypeSymbol)nodeType, loweredAccessExpression);
            }
            else
            {
                Debug.Assert(TypeSymbol.Equals(accessExpressionType, nodeType, TypeCompareKind.ConsiderEverything2) ||
                    (nodeType.IsVoidType() && !used));
            }

            BoundExpression result;
            var objectType = _compilation.GetSpecialType(SpecialType.System_Object);

            switch (loweringKind)
            {
                case ConditionalAccessLoweringKind.LoweredConditionalAccess:
                    Debug.Assert(loweredReceiver.Type is { });
                    result = new BoundLoweredConditionalAccess(
                        node.Syntax,
                        loweredReceiver,
                        receiverType.IsNullableType() ?
                                 UnsafeGetNullableMethod(node.Syntax, loweredReceiver.Type, SpecialMember.System_Nullable_T_get_HasValue) :
                                 null,
                        loweredAccessExpression,
                        null,
                        currentConditionalAccessID,
                        type);

                    break;

                case ConditionalAccessLoweringKind.ConditionalCaptureReceiverByVal:
                    // capture the receiver into a temp
                    Debug.Assert(temp is { });
                    loweredReceiver = _factory.MakeSequence(
                                            _factory.AssignmentExpression(_factory.Local(temp), loweredReceiver),
                                            _factory.Local(temp));

                    goto case ConditionalAccessLoweringKind.Conditional;

                case ConditionalAccessLoweringKind.Conditional:
                    {
                        // (object)r != null ? access : default(T)
                        var condition = _factory.ObjectNotEqual(
                                _factory.Convert(objectType, loweredReceiver),
                                _factory.Null(objectType));

                        var consequence = loweredAccessExpression;

                        result = RewriteConditionalOperator(node.Syntax,
                            condition,
                            consequence,
                            _factory.Default(nodeType),
                            null,
                            nodeType,
                            isRef: false);

                        if (temp != null)
                        {
                            result = _factory.MakeSequence(temp, result);
                        }
                    }
                    break;

                default:
                    throw ExceptionUtilities.UnexpectedValue(loweringKind);
            }

            return result;
        }

public override BoundNode VisitConditionalReceiver(BoundConditionalReceiver node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10487,8503,8923);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10487,8609,8657);

var 
newtarget = _currentConditionalAccessTarget
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10487,8671,8712);

f_10487_8671_8711(newtarget is { Type: { } });

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10487,8728,8879) || true) && (f_10487_8732_8763(f_10487_8732_8746(newtarget)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10487,8728,8879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10487,8797,8864);

newtarget = f_10487_8809_8863(this, node.Syntax, newtarget);
DynAbs.Tracing.TraceSender.TraceExitCondition(10487,8728,8879);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10487,8895,8912);

return newtarget;
DynAbs.Tracing.TraceSender.TraceExitMethod(10487,8503,8923);

int
f_10487_8671_8711(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10487, 8671, 8711);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10487_8732_8746(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10487, 8732, 8746);
return return_v;
}


bool
f_10487_8732_8763(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsNullableType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10487, 8732, 8763);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10487_8809_8863(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = this_param.MakeOptimizedGetValueOrDefault( syntax, expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10487, 8809, 8863);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10487,8503,8923);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10487,8503,8923);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
