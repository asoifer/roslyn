// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitPropertyAccess(BoundPropertyAccess node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10520,509,676);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10520,605,665);

return f_10520_612_664(this, node, isLeftOfAssignment: false);
DynAbs.Tracing.TraceSender.TraceExitMethod(10520,509,676);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10520_612_664(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
node,bool
isLeftOfAssignment)
{
var return_v = this_param.VisitPropertyAccess( node, isLeftOfAssignment: isLeftOfAssignment);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10520, 612, 664);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10520,509,676);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10520,509,676);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression VisitPropertyAccess(BoundPropertyAccess node, bool isLeftOfAssignment)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10520,688,1029);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10520,807,868);

var 
rewrittenReceiverOpt = f_10520_834_867(this, f_10520_850_866(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10520,882,1018);

return f_10520_889_1017(this, node.Syntax, rewrittenReceiverOpt, f_10520_943_962(node), f_10520_964_979(node), f_10520_981_990(node), isLeftOfAssignment, node);
DynAbs.Tracing.TraceSender.TraceExitMethod(10520,688,1029);

Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10520_850_866(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
this_param)
{
var return_v = this_param.ReceiverOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10520, 850, 866);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10520_834_867(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression?
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10520, 834, 867);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
f_10520_943_962(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
this_param)
{
var return_v = this_param.PropertySymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10520, 943, 962);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LookupResultKind
f_10520_964_979(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
this_param)
{
var return_v = this_param.ResultKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10520, 964, 979);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10520_981_990(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10520, 981, 990);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10520_889_1017(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
rewrittenReceiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
propertySymbol,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,bool
isLeftOfAssignment,Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
oldNodeOpt)
{
var return_v = this_param.MakePropertyAccess( syntax, rewrittenReceiverOpt, propertySymbol, resultKind, type, isLeftOfAssignment, oldNodeOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10520, 889, 1017);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10520,688,1029);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10520,688,1029);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakePropertyAccess(
            SyntaxNode syntax,
            BoundExpression? rewrittenReceiverOpt,
            PropertySymbol propertySymbol,
            LookupResultKind resultKind,
            TypeSymbol type,
            bool isLeftOfAssignment,
            BoundPropertyAccess? oldNodeOpt = null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10520,1041,3225);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10520,1545,2422) || true) && (rewrittenReceiverOpt is { Type: { TypeKind: TypeKind.Array } } &&(DynAbs.Tracing.TraceSender.Expression_True(10520, 1549, 1634)&&!isLeftOfAssignment))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10520,1545,2422);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10520,1668,1729);

var 
asArrayType = (ArrayTypeSymbol)f_10520_1703_1728(rewrittenReceiverOpt)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10520,1747,2407) || true) && (f_10520_1751_1772(asArrayType))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10520,1747,2407);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10520,1986,2388) || true) && (f_10520_1990_2092(propertySymbol, f_10520_2022_2091(_compilation, SpecialMember.System_Array__Length))||(DynAbs.Tracing.TraceSender.Expression_False(10520, 1990, 2251)||                        !_inExpressionLambda &&(DynAbs.Tracing.TraceSender.Expression_True(10520, 2121, 2251)&&f_10520_2145_2251(propertySymbol, f_10520_2177_2250(_compilation, SpecialMember.System_Array__LongLength)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10520,1986,2388);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10520,2301,2365);

return f_10520_2308_2364(syntax, rewrittenReceiverOpt, type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10520,1986,2388);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10520,1747,2407);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10520,1545,2422);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10520,2438,3214) || true) && (isLeftOfAssignment &&(DynAbs.Tracing.TraceSender.Expression_True(10520, 2442, 2502)&&f_10520_2464_2486(propertySymbol)== RefKind.None))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10520,2438,3214);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10520,2762,2996);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10520, 2769, 2787)||((oldNodeOpt != null &&DynAbs.Tracing.TraceSender.Conditional_F2(10520, 2811, 2884))||DynAbs.Tracing.TraceSender.Conditional_F3(10520, 2908, 2995)))?f_10520_2811_2884(                    oldNodeOpt, rewrittenReceiverOpt, propertySymbol, resultKind, type):f_10520_2908_2995(syntax, rewrittenReceiverOpt, propertySymbol, resultKind, type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10520,2438,3214);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10520,2438,3214);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10520,3112,3199);

return f_10520_3119_3198(this, syntax, rewrittenReceiverOpt, propertySymbol, oldNodeOpt);
DynAbs.Tracing.TraceSender.TraceExitCondition(10520,2438,3214);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10520,1041,3225);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10520_1703_1728(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10520, 1703, 1728);
return return_v;
}


bool
f_10520_1751_1772(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
this_param)
{
var return_v = this_param.IsSZArray;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10520, 1751, 1772);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10520_2022_2091(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.GetSpecialTypeMember( specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10520, 2022, 2091);
return return_v;
}


bool
f_10520_1990_2092(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
objA,Microsoft.CodeAnalysis.CSharp.Symbol
objB)
{
var return_v = ReferenceEquals( (object)objA, (object)objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10520, 1990, 2092);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10520_2177_2250(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.GetSpecialTypeMember( specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10520, 2177, 2250);
return return_v;
}


bool
f_10520_2145_2251(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
objA,Microsoft.CodeAnalysis.CSharp.Symbol
objB)
{
var return_v = ReferenceEquals( (object)objA, (object)objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10520, 2145, 2251);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundArrayLength
f_10520_2308_2364(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundArrayLength( syntax, expression, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10520, 2308, 2364);
return return_v;
}


Microsoft.CodeAnalysis.RefKind
f_10520_2464_2486(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
this_param)
{
var return_v = this_param.RefKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10520, 2464, 2486);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
f_10520_2811_2884(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
propertySymbol,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Update( receiverOpt, propertySymbol, resultKind, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10520, 2811, 2884);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
f_10520_2908_2995(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
propertySymbol,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess( syntax, receiverOpt, propertySymbol, resultKind, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10520, 2908, 2995);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10520_3119_3198(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
rewrittenReceiver,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
property,Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess?
oldNodeOpt)
{
var return_v = this_param.MakePropertyGetAccess( syntax, rewrittenReceiver, property, oldNodeOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10520, 3119, 3198);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10520,1041,3225);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10520,1041,3225);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakePropertyGetAccess(SyntaxNode syntax, BoundExpression? rewrittenReceiver, PropertySymbol property, BoundPropertyAccess? oldNodeOpt)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10520,3237,3554);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10520,3420,3543);

return f_10520_3427_3542(this, syntax, rewrittenReceiver, property, ImmutableArray<BoundExpression>.Empty, null, oldNodeOpt);
DynAbs.Tracing.TraceSender.TraceExitMethod(10520,3237,3554);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10520_3427_3542(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
rewrittenReceiver,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
property,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
rewrittenArguments,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
getMethodOpt,Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess?
oldNodeOpt)
{
var return_v = this_param.MakePropertyGetAccess( syntax, rewrittenReceiver, property, rewrittenArguments, getMethodOpt, oldNodeOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10520, 3427, 3542);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10520,3237,3554);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10520,3237,3554);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakePropertyGetAccess(
            SyntaxNode syntax,
            BoundExpression? rewrittenReceiver,
            PropertySymbol property,
            ImmutableArray<BoundExpression> rewrittenArguments,
            MethodSymbol? getMethodOpt = null,
            BoundPropertyAccess? oldNodeOpt = null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10520,3566,4857);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10520,3922,4846) || true) && (_inExpressionLambda &&(DynAbs.Tracing.TraceSender.Expression_True(10520, 3926, 3975)&&rewrittenArguments.IsEmpty))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10520,3922,4846);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10520,4009,4269);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10520, 4016, 4034)||((oldNodeOpt != null &&DynAbs.Tracing.TraceSender.Conditional_F2(10520, 4058, 4144))||DynAbs.Tracing.TraceSender.Conditional_F3(10520, 4168, 4268)))?f_10520_4058_4144(                    oldNodeOpt, rewrittenReceiver, property, LookupResultKind.Viable, f_10520_4130_4143(property)):f_10520_4168_4268(syntax, rewrittenReceiver, property, LookupResultKind.Viable, f_10520_4254_4267(property));
DynAbs.Tracing.TraceSender.TraceExitCondition(10520,3922,4846);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10520,3922,4846);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10520,4335,4405);

var 
getMethod = getMethodOpt ??(DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?>(10520, 4351, 4404)??f_10520_4367_4404(property))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10520,4425,4456);

f_10520_4425_4455(getMethod is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10520,4474,4542);

f_10520_4474_4541(f_10520_4487_4511(getMethod)== rewrittenArguments.Length);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10520,4560,4639);

f_10520_4560_4638(getMethodOpt is null ||(DynAbs.Tracing.TraceSender.Expression_False(10520, 4573, 4637)||f_10520_4597_4637(getMethod, getMethodOpt)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10520,4659,4831);

return f_10520_4666_4830(syntax, rewrittenReceiver, getMethod, rewrittenArguments);
DynAbs.Tracing.TraceSender.TraceExitCondition(10520,3922,4846);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10520,3566,4857);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10520_4130_4143(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10520, 4130, 4143);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
f_10520_4058_4144(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
propertySymbol,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Update( receiverOpt, propertySymbol, resultKind, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10520, 4058, 4144);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10520_4254_4267(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10520, 4254, 4267);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
f_10520_4168_4268(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
propertySymbol,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess( syntax, receiverOpt, propertySymbol, resultKind, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10520, 4168, 4268);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10520_4367_4404(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
property)
{
var return_v = property.GetOwnOrInheritedGetMethod();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10520, 4367, 4404);
return return_v;
}


int
f_10520_4425_4455(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10520, 4425, 4455);
return 0;
}


int
f_10520_4487_4511(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ParameterCount ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10520, 4487, 4511);
return return_v;
}


int
f_10520_4474_4541(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10520, 4474, 4541);
return 0;
}


bool
f_10520_4597_4637(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
objA,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
objB)
{
var return_v = ReferenceEquals( (object)objA, (object)objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10520, 4597, 4637);
return return_v;
}


int
f_10520_4560_4638(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10520, 4560, 4638);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10520_4666_4830(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt, method, arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10520, 4666, 4830);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10520,3566,4857);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10520,3566,4857);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
