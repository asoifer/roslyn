// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.Text;
using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.CodeGen
{

internal partial struct SwitchIntegralJumpTableEmitter
    {

private struct SwitchBucket
        {

private readonly ImmutableArray<KeyValuePair<ConstantValue, object>> _allLabels;

private readonly int _startLabelIndex;

private readonly int _endLabelIndex;

private readonly bool _isKnownDegenerate;

internal bool IsDegenerate
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(85,1704,1793);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,1748,1774);

return _isKnownDegenerate;
DynAbs.Tracing.TraceSender.TraceExitMethod(85,1704,1793);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(85,1645,1808);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(85,1645,1808);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal SwitchBucket(ImmutableArray<KeyValuePair<ConstantValue, object>> allLabels, int index)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(85,1824,2118);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,1952,1977);

_startLabelIndex = index;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,1995,2018);

_endLabelIndex = index;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,2036,2059);

_allLabels = allLabels;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,2077,2103);

_isKnownDegenerate = true;
DynAbs.Tracing.TraceSender.TraceExitConstructor(85,1824,2118);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(85,1824,2118);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(85,1824,2118);
}
		}

private SwitchBucket(ImmutableArray<KeyValuePair<ConstantValue, object>> allLabels, int startIndex, int endIndex)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(85,2134,2523);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,2280,2328);

f_85_2280_2327((uint)startIndex < (uint)endIndex);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,2348,2378);

_startLabelIndex = startIndex;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,2396,2422);

_endLabelIndex = endIndex;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,2440,2463);

_allLabels = allLabels;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,2481,2508);

_isKnownDegenerate = false;
DynAbs.Tracing.TraceSender.TraceExitConstructor(85,2134,2523);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(85,2134,2523);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(85,2134,2523);
}
		}

internal SwitchBucket(ImmutableArray<KeyValuePair<ConstantValue, object>> allLabels, int startIndex, int endIndex, bool isDegenerate)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(85,2539,3039);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,2705,2754);

f_85_2705_2753((uint)startIndex <= (uint)endIndex);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,2772,2837);

f_85_2772_2836((uint)startIndex != (uint)endIndex ||(DynAbs.Tracing.TraceSender.Expression_False(85, 2785, 2835)||isDegenerate));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,2857,2887);

_startLabelIndex = startIndex;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,2905,2931);

_endLabelIndex = endIndex;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,2949,2972);

_allLabels = allLabels;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,2990,3024);

_isKnownDegenerate = isDegenerate;
DynAbs.Tracing.TraceSender.TraceExitConstructor(85,2539,3039);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(85,2539,3039);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(85,2539,3039);
}
		}

internal uint LabelsCount
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(85,3113,3229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,3157,3210);

return (uint)(_endLabelIndex - _startLabelIndex + 1);
DynAbs.Tracing.TraceSender.TraceExitMethod(85,3113,3229);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(85,3055,3244);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(85,3055,3244);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

            internal KeyValuePair<ConstantValue, object> this[int i]
            {

get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(85,3349,3526);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,3393,3445);

f_85_3393_3444(i < LabelsCount, "index out of range");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,3467,3507);

return _allLabels[i + _startLabelIndex];
DynAbs.Tracing.TraceSender.TraceExitMethod(85,3349,3526);

int
f_85_3393_3444(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(85, 3393, 3444);
return 0;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(85,3349,3526);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(85,3349,3526);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
            }

internal ulong BucketSize
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(85,3615,3737);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,3659,3718);

return GetBucketSize(this.StartConstant,this.EndConstant);
DynAbs.Tracing.TraceSender.TraceExitMethod(85,3615,3737);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(85,3557,3752);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(85,3557,3752);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal int DegenerateBucketSplit
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(85,5386,6717);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,5430,5528) || true) && (IsDegenerate)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(85,5430,5528);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,5496,5505);

return 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(85,5430,5528);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,5552,5659);

f_85_5552_5658(_startLabelIndex != _endLabelIndex, "1-sized buckets should be already known as degenerate.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,5683,5715);

var 
allLabels = this._allLabels
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,5737,5751);

var 
split = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,5773,5808);

var 
lastConst = this.StartConstant
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,5830,5880);

var 
lastLabel = allLabels[_startLabelIndex].Value
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,5913,5939);

                    for (int 
idx = _startLabelIndex + 1
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,5904,6661) || true) && (idx <= _endLabelIndex)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,5964,5969)
,idx++,DynAbs.Tracing.TraceSender.TraceExitCondition(85,5904,6661))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(85,5904,6661);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,6019,6052);

var 
switchLabel = allLabels[idx]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,6080,6582) || true) && (lastLabel != switchLabel.Value ||(DynAbs.Tracing.TraceSender.Expression_False(85, 6084, 6188)||                            !IsContiguous(lastConst,switchLabel.Key)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(85,6080,6582);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,6246,6451) || true) && (split != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(85,6246,6451);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,6410,6420);

return -1;
DynAbs.Tracing.TraceSender.TraceExitCondition(85,6246,6451);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,6483,6495);

split = idx;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,6525,6555);

lastLabel = switchLabel.Value;
DynAbs.Tracing.TraceSender.TraceExitCondition(85,6080,6582);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,6610,6638);

lastConst = switchLabel.Key;
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(85,1,758);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(85,1,758);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,6685,6698);

return split;
DynAbs.Tracing.TraceSender.TraceExitMethod(85,5386,6717);

int
f_85_5552_5658(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(85, 5552, 5658);
return 0;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(85,5319,6732);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(85,5319,6732);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private bool IsContiguous(ConstantValue lastConst, ConstantValue nextConst)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(85,6748,7061);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,6856,6978) || true) && (f_85_6860_6880_M(!lastConst.IsNumeric)||(DynAbs.Tracing.TraceSender.Expression_False(85, 6860, 6904)||f_85_6884_6904_M(!nextConst.IsNumeric)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(85,6856,6978);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,6946,6959);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(85,6856,6978);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,6998,7046);

return GetBucketSize(lastConst,nextConst)== 2;
DynAbs.Tracing.TraceSender.TraceExitMethod(85,6748,7061);

bool
f_85_6860_6880_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(85, 6860, 6880);
return return_v;
}


bool
f_85_6884_6904_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(85, 6884, 6904);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(85,6748,7061);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(85,6748,7061);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static ulong GetBucketSize(ConstantValue startConstant, ConstantValue endConstant)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(85,7077,8011);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,7200,7269);

f_85_7200_7268(!BucketOverflowUInt64Limit(startConstant,endConstant));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,7287,7358);

f_85_7287_7357(f_85_7300_7325(endConstant)== f_85_7329_7356(startConstant));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,7378,7395);

ulong 
bucketSize
=default(ulong);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,7415,7958) || true) && (f_85_7419_7450(startConstant)||(DynAbs.Tracing.TraceSender.Expression_False(85, 7419, 7483)||f_85_7454_7483(endConstant)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(85,7415,7958);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,7525,7590);

f_85_7525_7589(f_85_7538_7560(endConstant)>= f_85_7564_7588(startConstant));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,7612,7699);

bucketSize = unchecked((ulong)(f_85_7643_7665(endConstant)- f_85_7668_7692(startConstant)+ 1));
DynAbs.Tracing.TraceSender.TraceExitCondition(85,7415,7958);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(85,7415,7958);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,7781,7848);

f_85_7781_7847(f_85_7794_7817(endConstant)>= f_85_7821_7846(startConstant));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,7870,7939);

bucketSize = f_85_7883_7906(endConstant)- f_85_7909_7934(startConstant)+ 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(85,7415,7958);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,7978,7996);

return bucketSize;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(85,7077,8011);

int
f_85_7200_7268(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(85, 7200, 7268);
return 0;
}


Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
f_85_7300_7325(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.Discriminator ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(85, 7300, 7325);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
f_85_7329_7356(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.Discriminator;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(85, 7329, 7356);
return return_v;
}


int
f_85_7287_7357(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(85, 7287, 7357);
return 0;
}


bool
f_85_7419_7450(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.IsNegativeNumeric ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(85, 7419, 7450);
return return_v;
}


bool
f_85_7454_7483(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.IsNegativeNumeric;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(85, 7454, 7483);
return return_v;
}


long
f_85_7538_7560(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.Int64Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(85, 7538, 7560);
return return_v;
}


long
f_85_7564_7588(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.Int64Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(85, 7564, 7588);
return return_v;
}


int
f_85_7525_7589(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(85, 7525, 7589);
return 0;
}


long
f_85_7643_7665(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.Int64Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(85, 7643, 7665);
return return_v;
}


long
f_85_7668_7692(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.Int64Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(85, 7668, 7692);
return return_v;
}


ulong
f_85_7794_7817(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.UInt64Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(85, 7794, 7817);
return return_v;
}


ulong
f_85_7821_7846(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.UInt64Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(85, 7821, 7846);
return return_v;
}


int
f_85_7781_7847(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(85, 7781, 7847);
return 0;
}


ulong
f_85_7883_7906(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.UInt64Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(85, 7883, 7906);
return return_v;
}


ulong
f_85_7909_7934(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.UInt64Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(85, 7909, 7934);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(85,7077,8011);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(85,7077,8011);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool BucketOverflowUInt64Limit(ConstantValue startConstant, ConstantValue endConstant)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(85,8088,8894);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,8222,8296);

f_85_8222_8295(IsValidSwitchBucketConstantPair(startConstant,endConstant));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,8316,8846) || true) && (f_85_8320_8347(startConstant)== ConstantValueTypeDiscriminator.Int64)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(85,8316,8846);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,8429,8548);

return f_85_8436_8460(startConstant)== Int64.MinValue
&&(DynAbs.Tracing.TraceSender.Expression_True(85, 8436, 8547)&&f_85_8507_8529(endConstant)== Int64.MaxValue);
DynAbs.Tracing.TraceSender.TraceExitCondition(85,8316,8846);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(85,8316,8846);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,8590,8846) || true) && (f_85_8594_8621(startConstant)== ConstantValueTypeDiscriminator.UInt64)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(85,8590,8846);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,8704,8827);

return f_85_8711_8736(startConstant)== UInt64.MinValue
&&(DynAbs.Tracing.TraceSender.Expression_True(85, 8711, 8826)&&f_85_8784_8807(endConstant)== UInt64.MaxValue);
DynAbs.Tracing.TraceSender.TraceExitCondition(85,8590,8846);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(85,8316,8846);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,8866,8879);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(85,8088,8894);

int
f_85_8222_8295(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(85, 8222, 8295);
return 0;
}


Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
f_85_8320_8347(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.Discriminator ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(85, 8320, 8347);
return return_v;
}


long
f_85_8436_8460(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.Int64Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(85, 8436, 8460);
return return_v;
}


long
f_85_8507_8529(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.Int64Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(85, 8507, 8529);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
f_85_8594_8621(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.Discriminator ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(85, 8594, 8621);
return return_v;
}


ulong
f_85_8711_8736(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.UInt64Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(85, 8711, 8736);
return return_v;
}


ulong
f_85_8784_8807(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.UInt64Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(85, 8784, 8807);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(85,8088,8894);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(85,8088,8894);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool BucketOverflow(ConstantValue startConstant, ConstantValue endConstant)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(85,9054,9336);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,9177,9321);

return BucketOverflowUInt64Limit(startConstant,endConstant)||(DynAbs.Tracing.TraceSender.Expression_False(85, 9184, 9320)||GetBucketSize(startConstant,endConstant)> Int32.MaxValue);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(85,9054,9336);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(85,9054,9336);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(85,9054,9336);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal int StartLabelIndex
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(85,9413,9500);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,9457,9481);

return _startLabelIndex;
DynAbs.Tracing.TraceSender.TraceExitMethod(85,9413,9500);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(85,9352,9515);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(85,9352,9515);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal int EndLabelIndex
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(85,9590,9675);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,9634,9656);

return _endLabelIndex;
DynAbs.Tracing.TraceSender.TraceExitMethod(85,9590,9675);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(85,9531,9690);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(85,9531,9690);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal ConstantValue StartConstant
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(85,9775,9878);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,9819,9859);

return _allLabels[_startLabelIndex].Key;
DynAbs.Tracing.TraceSender.TraceExitMethod(85,9775,9878);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(85,9706,9893);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(85,9706,9893);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal ConstantValue EndConstant
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(85,9976,10077);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,10020,10058);

return _allLabels[_endLabelIndex].Key;
DynAbs.Tracing.TraceSender.TraceExitMethod(85,9976,10077);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(85,9909,10092);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(85,9909,10092);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private static bool IsValidSwitchBucketConstant(ConstantValue constant)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(85,10108,10426);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,10212,10411);

return constant != null
&&(DynAbs.Tracing.TraceSender.Expression_True(85, 10219, 10326)&&f_85_10260_10326(constant))&&(DynAbs.Tracing.TraceSender.Expression_True(85, 10219, 10367)&&f_85_10351_10367_M(!constant.IsNull))&&(DynAbs.Tracing.TraceSender.Expression_True(85, 10219, 10410)&&f_85_10392_10410_M(!constant.IsString));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(85,10108,10426);

bool
f_85_10260_10326(Microsoft.CodeAnalysis.ConstantValue
constant)
{
var return_v = SwitchConstantValueHelper.IsValidSwitchCaseLabelConstant( constant);
DynAbs.Tracing.TraceSender.TraceEndInvocation(85, 10260, 10326);
return return_v;
}


bool
f_85_10351_10367_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(85, 10351, 10367);
return return_v;
}


bool
f_85_10392_10410_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(85, 10392, 10410);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(85,10108,10426);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(85,10108,10426);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsValidSwitchBucketConstantPair(ConstantValue startConstant, ConstantValue endConstant)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(85,10442,10787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,10582,10772);

return IsValidSwitchBucketConstant(startConstant)&&(DynAbs.Tracing.TraceSender.Expression_True(85, 10589, 10696)&&IsValidSwitchBucketConstant(endConstant))&&(DynAbs.Tracing.TraceSender.Expression_True(85, 10589, 10771)&&f_85_10721_10745(startConstant)== f_85_10749_10771(endConstant));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(85,10442,10787);

bool
f_85_10721_10745(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.IsUnsigned ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(85, 10721, 10745);
return return_v;
}


bool
f_85_10749_10771(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.IsUnsigned;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(85, 10749, 10771);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(85,10442,10787);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(85,10442,10787);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsSparse(uint labelsCount, ulong bucketSize)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(85,10803,11028);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,10976,11013);

return bucketSize >= labelsCount * 2;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(85,10803,11028);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(85,10803,11028);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(85,10803,11028);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool MergeIsAdvantageous(SwitchBucket bucket1, SwitchBucket bucket2)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(85,11044,11697);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,11161,11203);

var 
startConstant = bucket1.StartConstant
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,11221,11259);

var 
endConstant = bucket2.EndConstant
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,11279,11452) || true) && (BucketOverflow(startConstant,endConstant))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(85,11279,11452);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,11420,11433);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(85,11279,11452);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,11472,11541);

uint 
labelsCount = (uint)(bucket1.LabelsCount + bucket2.LabelsCount)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,11559,11620);

ulong 
bucketSize = GetBucketSize(startConstant,endConstant)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,11640,11682);

return !IsSparse(labelsCount,bucketSize);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(85,11044,11697);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(85,11044,11697);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(85,11044,11697);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool TryMergeWith(SwitchBucket prevBucket)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(85,11971,12402);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,12055,12119);

f_85_12055_12118(prevBucket._endLabelIndex + 1 == _startLabelIndex);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,12137,12354) || true) && (MergeIsAdvantageous(prevBucket,this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(85,12137,12354);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,12220,12301);

this = f_85_12227_12300(_allLabels, prevBucket._startLabelIndex, _endLabelIndex);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,12323,12335);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(85,12137,12354);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(85,12374,12387);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(85,11971,12402);

int
f_85_12055_12118(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(85, 12055, 12118);
return 0;
}


Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket
f_85_12227_12300(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>
allLabels,int
startIndex,int
endIndex)
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket( allLabels, startIndex, endIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(85, 12227, 12300);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(85,11971,12402);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(85,11971,12402);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
static SwitchBucket(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(85,480,12413);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(85,480,12413);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(85,480,12413);
}

static int
f_85_2280_2327(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(85, 2280, 2327);
return 0;
}


static int
f_85_2705_2753(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(85, 2705, 2753);
return 0;
}


static int
f_85_2772_2836(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(85, 2772, 2836);
return 0;
}

        }
    }
}
