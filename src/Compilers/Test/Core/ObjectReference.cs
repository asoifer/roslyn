// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Runtime.CompilerServices;
using Xunit;

namespace Roslyn.Test.Utilities
{
public static class ObjectReference
{
[MethodImpl(MethodImplOptions.NoInlining)]
        public static ObjectReference<T> CreateFromFactory<T>(Func<T> targetFactory) where T : class
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25039,650,877);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25039,819,866);

return f_25039_826_865(f_25039_849_864(targetFactory));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25039,650,877);

T
f_25039_849_864(System.Func<T>
this_param)
{
var return_v = this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25039, 849, 864);
return return_v;
}


Roslyn.Test.Utilities.ObjectReference<T>
f_25039_826_865(T
target)
{
var return_v = new Roslyn.Test.Utilities.ObjectReference<T>( target);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25039, 826, 865);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25039,650,877);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25039,650,877);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static ObjectReference<T> Create<T>(T target) where T : class
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25039,889,1031);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25039,982,1020);

return f_25039_989_1019(target);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25039,889,1031);

Roslyn.Test.Utilities.ObjectReference<T>
f_25039_989_1019(T
target)
{
var return_v = new Roslyn.Test.Utilities.ObjectReference<T>( target);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25039, 989, 1019);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25039,889,1031);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25039,889,1031);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static ObjectReference()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25039,340,1038);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25039,340,1038);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25039,340,1038);
}

}
public sealed class ObjectReference<T> where T : class
{
private T _strongReference;

private bool _strongReferenceRetrievedOutsideScopedCall;

private readonly WeakReference _weakReference;

public ObjectReference(T target)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25039,2779,3061);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25039,2456,2472);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25039,2666,2708);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25039,2752,2766);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25039,2836,2951) || true) && (target == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25039,2836,2951);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25039,2888,2936);

throw f_25039_2894_2935(nameof(target));
DynAbs.Tracing.TraceSender.TraceExitCondition(25039,2836,2951);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25039,2967,2993);

_strongReference = target;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25039,3007,3050);

_weakReference = f_25039_3024_3049<T>(target);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25039,2779,3061);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25039,2779,3061);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25039,2779,3061);
}
		}

        /// <summary>
        /// Asserts that the underlying object has been released.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void AssertReleased()
        {
            ReleaseAndGarbageCollect(expectReleased: true);

            Assert.False(_weakReference.IsAlive, "Reference should have been released but was not.");
        }

        /// <summary>
        /// Asserts that the underlying object is still being held.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void AssertHeld()
        {
            ReleaseAndGarbageCollect(expectReleased: false);

            // Since we are asserting it's still held, if it is held we can just recover our strong reference again
            _strongReference = (T)_weakReference.Target;
            Assert.True(_strongReference != null, "Reference should still be held.");
        }

        /// <summary>
        /// Releases the strong reference without making any assertions.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void ReleaseStrongReference()
        {
            ReleaseAndGarbageCollect(expectReleased: false);
        }

[MethodImpl(MethodImplOptions.NoInlining)]
        private void ReleaseAndGarbageCollect(bool expectReleased)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25039,4436,6226);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25039,4571,4963) || true) && (_strongReferenceRetrievedOutsideScopedCall)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25039,4571,4963);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25039,4651,4948);

throw f_25039_4657_4947($"The strong reference being held by the {nameof(ObjectReference<T>)} was retrieved via a call to {nameof(GetReference)}. Since the CLR might have cached a temporary somewhere in your stack, assertions can no longer be made about the correctness of lifetime.");
DynAbs.Tracing.TraceSender.TraceExitCondition(25039,4571,4963);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25039,4979,5003);

_strongReference = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25039,5485,5528);

var 
loopCount = (DynAbs.Tracing.TraceSender.Conditional_F1(25039, 5501, 5515)||((expectReleased &&DynAbs.Tracing.TraceSender.Conditional_F2(25039, 5518, 5522))||DynAbs.Tracing.TraceSender.Conditional_F3(25039, 5525, 5527)))?1000 :10
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25039,5979,5984);

            // We'll loop until the iteration count is reached, or until the weak reference disappears. When we're
            // trying to assert that the object is released, once the weak reference goes away, we know we're good. But
            // if we're trying to assert that the object is held, our only real option is to know to do it "enough"
            // times; but if it goes away then we are definitely done.
            for (var 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25039,5970,6215) || true) && (i < loopCount &&(DynAbs.Tracing.TraceSender.Expression_True(25039, 5986, 6025)&&f_25039_6003_6025(_weakReference)))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25039,6027,6030)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(25039,5970,6215))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25039,5970,6215);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25039,6064,6152);

f_25039_6064_6151(f_25039_6075_6091(), GCCollectionMode.Forced, blocking: true, compacting: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25039,6170,6200);

f_25039_6170_6199();
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25039,1,246);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25039,1,246);
}DynAbs.Tracing.TraceSender.TraceExitMethod(25039,4436,6226);

System.InvalidOperationException
f_25039_4657_4947(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25039, 4657, 4947);
return return_v;
}


bool
f_25039_6003_6025(System.WeakReference
this_param)
{
var return_v = this_param.IsAlive;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25039, 6003, 6025);
return return_v;
}


int
f_25039_6075_6091()
{
var return_v = GC.MaxGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25039, 6075, 6091);
return return_v;
}


int
f_25039_6064_6151(int
generation,System.GCCollectionMode
mode,bool
blocking,bool
compacting)
{
GC.Collect( generation, mode, blocking: blocking, compacting: compacting);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25039, 6064, 6151);
return 0;
}


int
f_25039_6170_6199()
{
GC.WaitForPendingFinalizers();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25039, 6170, 6199);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25039,4436,6226);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25039,4436,6226);
}
		}

        /// <summary>
        /// Provides the underlying strong reference to the given action. This method is marked not be inlined, to ensure that no temporaries are left
        /// on the stack that might still root the strong reference. The caller must not "leak" the object out of the given action for any lifetime
        /// assertions to be safe.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void UseReference(Action<T> action)
        {
            action(GetReferenceWithChecks());
        }

[MethodImpl(MethodImplOptions.NoInlining)]
        public U UseReference<U>(Func<T, U> function)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25039,7183,7358);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25039,7305,7347);

return f_25039_7312_7346(function, f_25039_7321_7345(this));
DynAbs.Tracing.TraceSender.TraceExitMethod(25039,7183,7358);

T
f_25039_7321_7345(Roslyn.Test.Utilities.ObjectReference<T>
this_param)
{
var return_v = this_param.GetReferenceWithChecks();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25039, 7321, 7345);
return return_v;
}


U
f_25039_7312_7346(System.Func<T, U>
this_param,T
arg)
{
var return_v = this_param.Invoke( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25039, 7312, 7346);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25039,7183,7358);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25039,7183,7358);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[MethodImpl(MethodImplOptions.NoInlining)]
        public ObjectReference<U> GetObjectReference<U>(Func<T, U> function) where U : class
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25039,7832,8108);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25039,7993,8043);

var 
newValue = f_25039_8008_8042(function, f_25039_8017_8041(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25039,8057,8097);

return f_25039_8064_8096(newValue);
DynAbs.Tracing.TraceSender.TraceExitMethod(25039,7832,8108);

T
f_25039_8017_8041(Roslyn.Test.Utilities.ObjectReference<T>
this_param)
{
var return_v = this_param.GetReferenceWithChecks();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25039, 8017, 8041);
return return_v;
}


U
f_25039_8008_8042(System.Func<T, U>
this_param,T
arg)
{
var return_v = this_param.Invoke( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25039, 8008, 8042);
return return_v;
}


Roslyn.Test.Utilities.ObjectReference<U>
f_25039_8064_8096(U
target)
{
var return_v = ObjectReference.Create( target);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25039, 8064, 8096);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25039,7832,8108);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25039,7832,8108);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

        /// <summary>
        /// Fetches the object strongly being held from this. Because the value returned might be cached in a local temporary from
        /// the caller of this function, no further calls to <see cref="AssertHeld"/> or <see cref="AssertReleased"/> may be called
        /// on this object as the test is not valid either way. If you need to operate with the object without invalidating
        /// the ability to reference the object, see <see cref="UseReference"/>.
        /// </summary>
        public T GetReference()
        {
            _strongReferenceRetrievedOutsideScopedCall = true;
            return GetReferenceWithChecks();
        }

private T GetReferenceWithChecks()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25039,8806,9111);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25039,8865,9060) || true) && (_strongReference == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25039,8865,9060);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25039,8927,9045);

throw f_25039_8933_9044($"The type has already been released due to a call to {nameof(AssertReleased)}.");
DynAbs.Tracing.TraceSender.TraceExitCondition(25039,8865,9060);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25039,9076,9100);

return _strongReference;
DynAbs.Tracing.TraceSender.TraceExitMethod(25039,8806,9111);

System.InvalidOperationException
f_25039_8933_9044(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25039, 8933, 9044);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25039,8806,9111);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25039,8806,9111);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static System.ArgumentNullException
f_25039_2894_2935(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25039, 2894, 2935);
return return_v;
}


static System.WeakReference
f_25039_3024_3049<T>(T
target)where T : class

{
var return_v = new System.WeakReference( (object)target);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25039, 3024, 3049);
return return_v;
}

}
}
