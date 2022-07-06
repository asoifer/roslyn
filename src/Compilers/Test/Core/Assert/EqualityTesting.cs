// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using Xunit;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
public static class EqualityTesting
{
public static void AssertEqual<T>(IEquatable<T> x, IEquatable<T> y)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25047,511,749);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25047,603,628);

f_25047_603_627(f_25047_615_626(x, y));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25047,642,677);

f_25047_642_676(f_25047_654_675(((object)x), y));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25047,691,738);

f_25047_691_737(f_25047_704_719(x), f_25047_721_736(y));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25047,511,749);

bool
f_25047_615_626(System.IEquatable<T>
this_param,System.IEquatable<T>
obj)
{
var return_v = this_param.Equals( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25047, 615, 626);
return return_v;
}


int
f_25047_603_627(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25047, 603, 627);
return 0;
}


bool
f_25047_654_675(object
this_param,System.IEquatable<T>
obj)
{
var return_v = this_param.Equals( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25047, 654, 675);
return return_v;
}


int
f_25047_642_676(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25047, 642, 676);
return 0;
}


int
f_25047_704_719(System.IEquatable<T>
this_param)
{
var return_v = this_param.GetHashCode();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25047, 704, 719);
return return_v;
}


int
f_25047_721_736(System.IEquatable<T>
this_param)
{
var return_v = this_param.GetHashCode();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25047, 721, 736);
return return_v;
}


int
f_25047_691_737(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25047, 691, 737);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25047,511,749);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25047,511,749);
}
		}

public static void AssertNotEqual<T>(IEquatable<T> x, IEquatable<T> y)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25047,761,943);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25047,856,882);

f_25047_856_881(f_25047_869_880(x, y));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25047,896,932);

f_25047_896_931(f_25047_909_930(((object)x), y));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25047,761,943);

bool
f_25047_869_880(System.IEquatable<T>
this_param,System.IEquatable<T>
obj)
{
var return_v = this_param.Equals( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25047, 869, 880);
return return_v;
}


int
f_25047_856_881(bool
condition)
{
Assert.False( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25047, 856, 881);
return 0;
}


bool
f_25047_909_930(object
this_param,System.IEquatable<T>
obj)
{
var return_v = this_param.Equals( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25047, 909, 930);
return return_v;
}


int
f_25047_896_931(bool
condition)
{
Assert.False( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25047, 896, 931);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25047,761,943);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25047,761,943);
}
		}

static EqualityTesting()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25047,459,950);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25047,459,950);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25047,459,950);
}

}
}
