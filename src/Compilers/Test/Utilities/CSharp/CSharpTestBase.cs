// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.FlowAnalysis;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Microsoft.CodeAnalysis.Test.Utilities;
using Microsoft.CodeAnalysis.Text;
using Microsoft.Metadata.Tools;
using Roslyn.Test.Utilities;
using Roslyn.Utilities;
using Xunit;
using static Roslyn.Test.Utilities.TestMetadata;

namespace Microsoft.CodeAnalysis.CSharp.Test.Utilities
{
    public abstract class CSharpTestBase : CommonTestBase
    {
        protected const string
        NullableAttributeDefinition = @"
namespace System.Runtime.CompilerServices
{
    [System.AttributeUsage(AttributeTargets.Event | // The type of the event is nullable, or has a nullable reference type as one of its constituents
                    AttributeTargets.Field | // The type of the field is a nullable reference type, or has a nullable reference type as one of its constituents
                    AttributeTargets.GenericParameter | // The generic parameter is a nullable reference type
                    AttributeTargets.Module | // Nullable reference types in this module are annotated by means of NullableAttribute applied to other targets in it
                    AttributeTargets.Parameter | // The type of the parameter is a nullable reference type, or has a nullable reference type as one of its constituents
                    AttributeTargets.ReturnValue | // The return type is a nullable reference type, or has a nullable reference type as one of its constituents
                    AttributeTargets.Property | // The type of the property is a nullable reference type, or has a nullable reference type as one of its constituents
                    AttributeTargets.Class, // Base type has a nullable reference type as one of its constituents
                   AllowMultiple = false)]
    public class NullableAttribute : Attribute
    {
        public NullableAttribute(byte transformFlag) { }
        public NullableAttribute(byte[] transformFlags)
        {
        }
    }
}
"
        ;

        protected const string
        NullableContextAttributeDefinition = @"
namespace System.Runtime.CompilerServices
{
    [System.AttributeUsage(
        AttributeTargets.Class |
        AttributeTargets.Delegate |
        AttributeTargets.Interface |
        AttributeTargets.Method |
        AttributeTargets.Struct,
        AllowMultiple = false,
        Inherited = false)]
    public sealed class NullableContextAttribute : Attribute
    {
        public readonly byte Flag;
        public NullableContextAttribute(byte flag)
        {
            Flag = flag;
        }
    }
}"
        ;

        protected const string
        NullablePublicOnlyAttributeDefinition = @"
namespace System.Runtime.CompilerServices
{
    [System.AttributeUsage(AttributeTargets.Module, AllowMultiple = false)]
    public sealed class NullablePublicOnlyAttribute : Attribute
    {
        public readonly bool IncludesInternals;
        public NullablePublicOnlyAttribute(bool includesInternals)
        {
            IncludesInternals = includesInternals;
        }
    }
}"
        ;

        protected const string
        AllowNullAttributeDefinition = @"
namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property)]
    public sealed class AllowNullAttribute : Attribute
    {
    }
}"
        ;

        protected const string
        DisallowNullAttributeDefinition = @"
namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property)]
    public sealed class DisallowNullAttribute : Attribute
    {
    }
}"
        ;

        protected const string
        MaybeNullAttributeDefinition = @"
namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.ReturnValue)]
    public sealed class MaybeNullAttribute : Attribute
    {
    }
}
"
        ;

        protected const string
        MaybeNullWhenAttributeDefinition = @"
namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    public sealed class MaybeNullWhenAttribute : Attribute
    {
        public MaybeNullWhenAttribute(bool when) { }
    }
}
"
        ;

        protected const string
        NotNullAttributeDefinition = @"
namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.ReturnValue)]
    public sealed class NotNullAttribute : Attribute
    {
    }
}
"
        ;

        protected const string
        NotNullWhenAttributeDefinition = @"
namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    public sealed class NotNullWhenAttribute : Attribute
    {
        public NotNullWhenAttribute(bool when) { }
    }
}
"
        ;

        protected const string
        MemberNotNullAttributeDefinition = @"
namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true)]
    public sealed class MemberNotNullAttribute : Attribute
    {
        public MemberNotNullAttribute(params string[] members) { }
        public MemberNotNullAttribute(string member) { }
    }
}
"
        ;

        protected const string
        MemberNotNullWhenAttributeDefinition = @"
namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true)]
    public sealed class MemberNotNullWhenAttribute : Attribute
    {
        public MemberNotNullWhenAttribute(bool when, params string[] members) { }
        public MemberNotNullWhenAttribute(bool when, string member) { }
    }
}
"
        ;

        protected const string
        DoesNotReturnIfAttributeDefinition = @"
namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    public class DoesNotReturnIfAttribute : Attribute
    {
        public DoesNotReturnIfAttribute(bool condition) { }
    }
}
"
        ;

        protected const string
        DoesNotReturnAttributeDefinition = @"
namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class DoesNotReturnAttribute : Attribute
    {
        public DoesNotReturnAttribute() { }
    }
}
"
        ;

        protected const string
        NotNullIfNotNullAttributeDefinition = @"
namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.ReturnValue, AllowMultiple = true, Inherited = false)]
    public sealed class NotNullIfNotNullAttribute : Attribute
    {
        public NotNullIfNotNullAttribute(string parameterName) { }
    }
}
"
        ;

        protected const string
        IsExternalInitTypeDefinition = @"
namespace System.Runtime.CompilerServices
{
    public static class IsExternalInit
    {
    }
}
"
        ;

        protected const string
        IAsyncDisposableDefinition = @"
namespace System
{
    public interface IAsyncDisposable
    {
       System.Threading.Tasks.ValueTask DisposeAsync();
    }
}
"
        ;

        protected const string
        AsyncStreamsTypes = @"
namespace System.Collections.Generic
{
    public interface IAsyncEnumerable<out T>
    {
        IAsyncEnumerator<T> GetAsyncEnumerator(System.Threading.CancellationToken token = default);
    }

    public interface IAsyncEnumerator<out T> : System.IAsyncDisposable
    {
        System.Threading.Tasks.ValueTask<bool> MoveNextAsync();
        T Current { get; }
    }
}
namespace System
{
    public interface IAsyncDisposable
    {
        System.Threading.Tasks.ValueTask DisposeAsync();
    }
}

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public sealed class AsyncIteratorStateMachineAttribute : StateMachineAttribute
    {
        public AsyncIteratorStateMachineAttribute(Type stateMachineType) : base(stateMachineType)
        {
        }
    }
}

#nullable disable

namespace System.Threading.Tasks.Sources
{
    using System.Diagnostics;
    using System.Runtime.ExceptionServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Auto)]
    public struct ManualResetValueTaskSourceCore<TResult>
    {
        private Action<object> _continuation;
        private object _continuationState;
        private ExecutionContext _executionContext;
        private object _capturedContext;
        private bool _completed;
        private TResult _result;
        private ExceptionDispatchInfo _error;
        private short _version;

        /// <summary>Gets or sets whether to force continuations to run asynchronously.</summary>
        /// <remarks>Continuations may run asynchronously if this is false, but they'll never run synchronously if this is true.</remarks>
        public bool RunContinuationsAsynchronously { get; set; }

        /// <summary>Resets to prepare for the next operation.</summary>
        public void Reset()
        {
            // Reset/update state for the next use/await of this instance.
            _version++;
            _completed = false;
            _result = default;
            _error = null;
            _executionContext = null;
            _capturedContext = null;
            _continuation = null;
            _continuationState = null;
        }

        public void SetResult(TResult result)
        {
            _result = result;
            SignalCompletion();
        }

        public void SetException(Exception error)
        {
            _error = ExceptionDispatchInfo.Capture(error);
            SignalCompletion();
        }

        public short Version => _version;

        public ValueTaskSourceStatus GetStatus(short token)
        {
            ValidateToken(token);
            return
                !_completed ? ValueTaskSourceStatus.Pending :
                _error == null ? ValueTaskSourceStatus.Succeeded :
                _error.SourceException is OperationCanceledException ? ValueTaskSourceStatus.Canceled :
                ValueTaskSourceStatus.Faulted;
        }

        public TResult GetResult(short token)
        {
            ValidateToken(token);
            if (!_completed)
            {
                ManualResetValueTaskSourceCoreShared.ThrowInvalidOperationException();
            }

            _error?.Throw();
            return _result;
        }

        public void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags)
        {
            if (continuation == null)
            {
                throw new ArgumentNullException(nameof(continuation));
            }
            ValidateToken(token);

            if ((flags & ValueTaskSourceOnCompletedFlags.FlowExecutionContext) != 0)
            {
                _executionContext = ExecutionContext.Capture();
            }

            if ((flags & ValueTaskSourceOnCompletedFlags.UseSchedulingContext) != 0)
            {
                SynchronizationContext sc = SynchronizationContext.Current;
                if (sc != null && sc.GetType() != typeof(SynchronizationContext))
                {
                    _capturedContext = sc;
                }
                else
                {
                    TaskScheduler ts = TaskScheduler.Current;
                    if (ts != TaskScheduler.Default)
                    {
                        _capturedContext = ts;
                    }
                }
            }

            // We need to set the continuation state before we swap in the delegate, so that
            // if there's a race between this and SetResult/Exception and SetResult/Exception
            // sees the _continuation as non-null, it'll be able to invoke it with the state
            // stored here.  However, this also means that if this is used incorrectly (e.g.
            // awaited twice concurrently), _continuationState might get erroneously overwritten.
            // To minimize the chances of that, we check preemptively whether _continuation
            // is already set to something other than the completion sentinel.

            object oldContinuation = _continuation;
            if (oldContinuation == null)
            {
                _continuationState = state;
                oldContinuation = Interlocked.CompareExchange(ref _continuation, continuation, null);
            }

            if (oldContinuation != null)
            {
                // Operation already completed, so we need to queue the supplied callback.
                if (!ReferenceEquals(oldContinuation, ManualResetValueTaskSourceCoreShared.s_sentinel))
                {
                    ManualResetValueTaskSourceCoreShared.ThrowInvalidOperationException();
                }

                switch (_capturedContext)
                {
                    case null:
                        Task.Factory.StartNew(continuation, state, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
                        break;

                    case SynchronizationContext sc:
                        sc.Post(s =>
                        {
                            var tuple = (Tuple<Action<object>, object>)s;
                            tuple.Item1(tuple.Item2);
                        }, Tuple.Create(continuation, state));
                        break;

                    case TaskScheduler ts:
                        Task.Factory.StartNew(continuation, state, CancellationToken.None, TaskCreationOptions.DenyChildAttach, ts);
                        break;
                }
            }
        }

        private void ValidateToken(short token)
        {
            if (token != _version)
            {
                ManualResetValueTaskSourceCoreShared.ThrowInvalidOperationException();
            }
        }

        private void SignalCompletion()
        {
            if (_completed)
            {
                ManualResetValueTaskSourceCoreShared.ThrowInvalidOperationException();
            }
            _completed = true;

            if (_continuation != null || Interlocked.CompareExchange(ref _continuation, ManualResetValueTaskSourceCoreShared.s_sentinel, null) != null)
            {
                if (_executionContext != null)
                {
                    ExecutionContext.Run(
                        _executionContext,
                        s => ((ManualResetValueTaskSourceCore<TResult>)s).InvokeContinuation(),
                        this);
                }
                else
                {
                    InvokeContinuation();
                }
            }
        }

        private void InvokeContinuation()
        {
            switch (_capturedContext)
            {
                case null:
                    if (RunContinuationsAsynchronously)
                    {
                        Task.Factory.StartNew(_continuation, _continuationState, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
                    }
                    else
                    {
                        _continuation(_continuationState);
                    }
                    break;

                case SynchronizationContext sc:
                    sc.Post(s =>
                    {
                        var state = (Tuple<Action<object>, object>)s;
                        state.Item1(state.Item2);
                    }, Tuple.Create(_continuation, _continuationState));
                    break;

                case TaskScheduler ts:
                    Task.Factory.StartNew(_continuation, _continuationState, CancellationToken.None, TaskCreationOptions.DenyChildAttach, ts);
                    break;
            }
        }
    }

    internal static class ManualResetValueTaskSourceCoreShared // separated out of generic to avoid unnecessary duplication
    {
        internal static void ThrowInvalidOperationException() => throw new InvalidOperationException();

        internal static readonly Action<object> s_sentinel = CompletionSentinel;
        private static void CompletionSentinel(object _) // named method to aid debugging
        {
            Debug.Fail(""The sentinel delegate should never be invoked."");
            ThrowInvalidOperationException();
        }
    }
}

namespace System.Runtime.CompilerServices
{
    using System.Runtime.InteropServices;

    /// <summary>Represents a builder for asynchronous iterators.</summary>
    [StructLayout(LayoutKind.Auto)]
    public struct AsyncIteratorMethodBuilder
    {
        // AsyncIteratorMethodBuilder is used by the language compiler as part of generating
        // async iterators. For now, the implementation just wraps AsyncTaskMethodBuilder, as
        // most of the logic is shared.  However, in the future this could be changed and
        // optimized.  For example, we do need to allocate an object (once) to flow state like
        // ExecutionContext, which AsyncTaskMethodBuilder handles, but it handles it by
        // allocating a Task-derived object.  We could optimize this further by removing
        // the Task from the hierarchy, but in doing so we'd also lose a variety of optimizations
        // related to it, so we'd need to replicate all of those optimizations (e.g. storing
        // that box object directly into a Task's continuation field).

        private AsyncTaskMethodBuilder _methodBuilder; // mutable struct; do not make it readonly

        public static AsyncIteratorMethodBuilder Create() =>
            new AsyncIteratorMethodBuilder() { _methodBuilder = AsyncTaskMethodBuilder.Create() };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void MoveNext<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine =>
            _methodBuilder.Start(ref stateMachine);

        public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
            where TAwaiter : INotifyCompletion
            where TStateMachine : IAsyncStateMachine =>
            _methodBuilder.AwaitOnCompleted(ref awaiter, ref stateMachine);

        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
            where TAwaiter : ICriticalNotifyCompletion
            where TStateMachine : IAsyncStateMachine =>
            _methodBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);

        /// <summary>Marks iteration as being completed, whether successfully or otherwise.</summary>
        public void Complete() => _methodBuilder.SetResult();
    }
}
"
        ;

        protected const string
        EnumeratorCancellationAttributeType = @"
namespace System.Runtime.CompilerServices
{
    [System.AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    public class EnumeratorCancellationAttribute : Attribute
    {
        public EnumeratorCancellationAttribute() { }
    }
}
"
        ;

        protected const string
        NativeIntegerAttributeDefinition =
        @"using System.Collections.Generic;
namespace System.Runtime.CompilerServices
{
    [System.AttributeUsage(
        AttributeTargets.Class |
        AttributeTargets.Event |
        AttributeTargets.Field |
        AttributeTargets.GenericParameter |
        AttributeTargets.Parameter |
        AttributeTargets.Property |
        AttributeTargets.ReturnValue,
        AllowMultiple = false,
        Inherited = false)]
    public sealed class NativeIntegerAttribute : Attribute
    {
        public NativeIntegerAttribute()
        {
            TransformFlags = new[] { true };
        }
        public NativeIntegerAttribute(bool[] flags)
        {
            TransformFlags = flags;
        }
        public readonly IList<bool> TransformFlags;
    }
}"
        ;

        protected static CSharpCompilationOptions WithNullableEnable(CSharpCompilationOptions options = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 21486, 21683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 21612, 21672);

                return f_21003_21619_21671(options, NullableContextOptions.Enable);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 21486, 21683);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_21003_21619_21671(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
                options, Microsoft.CodeAnalysis.NullableContextOptions
                nullableContextOptions)
                {
                    var return_v = WithNullable(options, nullableContextOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 21619, 21671);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 21486, 21683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 21486, 21683);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static CSharpCompilationOptions WithNullableDisable(CSharpCompilationOptions options = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 21695, 21894);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 21822, 21883);

                return f_21003_21829_21882(options, NullableContextOptions.Disable);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 21695, 21894);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_21003_21829_21882(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
                options, Microsoft.CodeAnalysis.NullableContextOptions
                nullableContextOptions)
                {
                    var return_v = WithNullable(options, nullableContextOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 21829, 21882);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 21695, 21894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 21695, 21894);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static CSharpCompilationOptions WithNullable(NullableContextOptions nullableContextOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 21906, 22093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 22032, 22082);

                return f_21003_22039_22081(null, nullableContextOptions);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 21906, 22093);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_21003_22039_22081(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.NullableContextOptions
                nullableContextOptions)
                {
                    var return_v = WithNullable(options, nullableContextOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 22039, 22081);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 21906, 22093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 21906, 22093);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static CSharpCompilationOptions WithNullable(CSharpCompilationOptions options, NullableContextOptions nullableContextOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 22105, 22370);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 22265, 22359);

                return f_21003_22272_22358((options ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions>(21003, 22273, 22306) ?? TestOptions.ReleaseDll)), nullableContextOptions);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 22105, 22370);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_21003_22272_22358(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.NullableContextOptions
                options)
                {
                    var return_v = this_param.WithNullableContextOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 22272, 22358);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 22105, 22370);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 22105, 22370);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CompilationVerifier CompileAndVerifyWithMscorlib40(
                    CSharpTestSource source,
                    IEnumerable<MetadataReference> references = null,
                    IEnumerable<ResourceDescription> manifestResources = null,
                    IEnumerable<ModuleData> dependencies = null,
                    Action<ModuleSymbol> sourceSymbolValidator = null,
                    Action<PEAssembly> assemblyValidator = null,
                    Action<ModuleSymbol> symbolValidator = null,
                    SignatureDescription[] expectedSignatures = null,
                    string expectedOutput = null,
                    int? expectedReturnCode = null,
                    string[] args = null,
                    CSharpCompilationOptions options = null,
                    CSharpParseOptions parseOptions = null,
                    EmitOptions emitOptions = null,
                    Verification verify = Verification.Passes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 23248, 23799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 23264, 23799);
                return f_21003_23264_23799(this, source, references, manifestResources, dependencies, sourceSymbolValidator, assemblyValidator, symbolValidator, expectedSignatures, expectedOutput, expectedReturnCode, args, options, parseOptions, emitOptions, TargetFramework.Mscorlib40, verify); DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 23248, 23799);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 23248, 23799);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 23248, 23799);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CompilationVerifier CompileAndVerifyWithMscorlib46(
                    CSharpTestSource source,
                    IEnumerable<MetadataReference> references = null,
                    IEnumerable<ResourceDescription> manifestResources = null,
                    IEnumerable<ModuleData> dependencies = null,
                    Action<ModuleSymbol> sourceSymbolValidator = null,
                    Action<PEAssembly> assemblyValidator = null,
                    Action<ModuleSymbol> symbolValidator = null,
                    SignatureDescription[] expectedSignatures = null,
                    string expectedOutput = null,
                    int? expectedReturnCode = null,
                    string[] args = null,
                    CSharpCompilationOptions options = null,
                    CSharpParseOptions parseOptions = null,
                    EmitOptions emitOptions = null,
                    Verification verify = Verification.Passes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 24678, 25229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 24694, 25229);
                return f_21003_24694_25229(this, source, references, manifestResources, dependencies, sourceSymbolValidator, assemblyValidator, symbolValidator, expectedSignatures, expectedOutput, expectedReturnCode, args, options, parseOptions, emitOptions, TargetFramework.Mscorlib46, verify); DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 24678, 25229);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 24678, 25229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 24678, 25229);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CompilationVerifier CompileAndVerifyExperimental(
                    CSharpTestSource source,
                    MessageID feature,
                    IEnumerable<MetadataReference> references = null,
                    IEnumerable<ResourceDescription> manifestResources = null,
                    IEnumerable<ModuleData> dependencies = null,
                    Action<ModuleSymbol> sourceSymbolValidator = null,
                    Action<PEAssembly> assemblyValidator = null,
                    Action<ModuleSymbol> symbolValidator = null,
                    SignatureDescription[] expectedSignatures = null,
                    string expectedOutput = null,
                    int? expectedReturnCode = null,
                    string[] args = null,
                    CSharpCompilationOptions options = null,
                    CSharpParseOptions parseOptions = null,
                    EmitOptions emitOptions = null,
                    Verification verify = Verification.Passes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 25242, 27046);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 26162, 26317);

                options = options ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?>(21003, 26172, 26316) ?? f_21003_26183_26316(TestOptions.ReleaseDll, (DynAbs.Tracing.TraceSender.Conditional_F1(21003, 26221, 26245) || (((expectedOutput != null) && DynAbs.Tracing.TraceSender.Conditional_F2(21003, 26248, 26277)) || DynAbs.Tracing.TraceSender.Conditional_F3(21003, 26280, 26315))) ? OutputKind.ConsoleApplication : OutputKind.DynamicallyLinkedLibrary));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 26331, 26476);

                var
                compilation = f_21003_26349_26475(source, feature, references, options, parseOptions, assemblyName: f_21003_26459_26474())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 26492, 27035);

                return f_21003_26499_27034(this, source, references, manifestResources, dependencies, sourceSymbolValidator, assemblyValidator, symbolValidator, expectedSignatures, expectedOutput, expectedReturnCode, args, options, parseOptions, emitOptions, TargetFramework.Mscorlib46, verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 25242, 27046);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_21003_26183_26316(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = this_param.WithOutputKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 26183, 26316);
                    return return_v;
                }


                string
                f_21003_26459_26474()
                {
                    var return_v = GetUniqueName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 26459, 26474);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_26349_26475(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
                source, Microsoft.CodeAnalysis.CSharp.MessageID
                feature, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                parseOptions, string
                assemblyName)
                {
                    var return_v = CreateExperimentalCompilationWithMscorlib45(source, feature, references, options, parseOptions, assemblyName: assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 26349, 26475);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_21003_26499_27034(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestBase
                this_param, Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
                source, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
                references, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>?
                manifestResources, System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.ModuleData>?
                dependencies, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>?
                sourceSymbolValidator, System.Action<Microsoft.CodeAnalysis.PEAssembly>?
                assemblyValidator, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>?
                symbolValidator, Microsoft.CodeAnalysis.Test.Utilities.SignatureDescription[]?
                expectedSignatures, string?
                expectedOutput, int?
                expectedReturnCode, string[]?
                args, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                parseOptions, Microsoft.CodeAnalysis.Emit.EmitOptions?
                emitOptions, Roslyn.Test.Utilities.TargetFramework
                targetFramework, Microsoft.CodeAnalysis.Test.Utilities.Verification
                verify)
                {
                    var return_v = this_param.CompileAndVerify(source, references, manifestResources, dependencies, sourceSymbolValidator, assemblyValidator, symbolValidator, expectedSignatures, expectedOutput, expectedReturnCode, args, options, parseOptions, emitOptions, targetFramework, verify);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 26499, 27034);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 25242, 27046);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 25242, 27046);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CompilationVerifier CompileAndVerifyWithWinRt(
                    CSharpTestSource source,
                    IEnumerable<MetadataReference> references = null,
                    IEnumerable<ResourceDescription> manifestResources = null,
                    IEnumerable<ModuleData> dependencies = null,
                    Action<ModuleSymbol> sourceSymbolValidator = null,
                    Action<PEAssembly> assemblyValidator = null,
                    Action<ModuleSymbol> symbolValidator = null,
                    SignatureDescription[] expectedSignatures = null,
                    string expectedOutput = null,
                    int? expectedReturnCode = null,
                    string[] args = null,
                    CSharpCompilationOptions options = null,
                    CSharpParseOptions parseOptions = null,
                    EmitOptions emitOptions = null,
                    Verification verify = Verification.Passes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 27919, 28465);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 27935, 28465);
                return f_21003_27935_28465(this, source, references, manifestResources, dependencies, sourceSymbolValidator, assemblyValidator, symbolValidator, expectedSignatures, expectedOutput, expectedReturnCode, args, options, parseOptions, emitOptions, TargetFramework.WinRT, verify); DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 27919, 28465);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 27919, 28465);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 27919, 28465);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CompilationVerifier CompileAndVerifyWithCSharp(
                    CSharpTestSource source,
                    IEnumerable<MetadataReference> references = null,
                    IEnumerable<ResourceDescription> manifestResources = null,
                    IEnumerable<ModuleData> dependencies = null,
                    Action<ModuleSymbol> sourceSymbolValidator = null,
                    Action<PEAssembly> assemblyValidator = null,
                    Action<ModuleSymbol> symbolValidator = null,
                    SignatureDescription[] expectedSignatures = null,
                    string expectedOutput = null,
                    int? expectedReturnCode = null,
                    string[] args = null,
                    CSharpCompilationOptions options = null,
                    CSharpParseOptions parseOptions = null,
                    EmitOptions emitOptions = null,
                    Verification verify = Verification.Passes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 29340, 29898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 29356, 29898);
                return f_21003_29356_29898(this, source, references, manifestResources, dependencies, sourceSymbolValidator, assemblyValidator, symbolValidator, expectedSignatures, expectedOutput, expectedReturnCode, args, options, parseOptions, emitOptions, TargetFramework.StandardAndCSharp, verify); DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 29340, 29898);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 29340, 29898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 29340, 29898);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CompilationVerifier CompileAndVerify(
                    CSharpTestSource source,
                    IEnumerable<MetadataReference> references = null,
                    IEnumerable<ResourceDescription> manifestResources = null,
                    IEnumerable<ModuleData> dependencies = null,
                    Action<ModuleSymbol> sourceSymbolValidator = null,
                    Action<PEAssembly> assemblyValidator = null,
                    Action<ModuleSymbol> symbolValidator = null,
                    SignatureDescription[] expectedSignatures = null,
                    string expectedOutput = null,
                    int? expectedReturnCode = null,
                    string[] args = null,
                    CSharpCompilationOptions options = null,
                    CSharpParseOptions parseOptions = null,
                    EmitOptions emitOptions = null,
                    TargetFramework targetFramework = TargetFramework.Standard,
                    Verification verify = Verification.Passes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 29911, 31598);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 30860, 31015);

                options = options ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?>(21003, 30870, 31014) ?? f_21003_30881_31014(TestOptions.ReleaseDll, (DynAbs.Tracing.TraceSender.Conditional_F1(21003, 30919, 30943) || (((expectedOutput != null) && DynAbs.Tracing.TraceSender.Conditional_F2(21003, 30946, 30975)) || DynAbs.Tracing.TraceSender.Conditional_F3(21003, 30978, 31013))) ? OutputKind.ConsoleApplication : OutputKind.DynamicallyLinkedLibrary));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 31029, 31156);

                var
                compilation = f_21003_31047_31155(source, references, options, parseOptions, targetFramework, assemblyName: f_21003_31139_31154())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 31170, 31587);

                return f_21003_31177_31586(this, compilation, manifestResources, dependencies, sourceSymbolValidator, assemblyValidator, symbolValidator, expectedSignatures, expectedOutput, expectedReturnCode, args, emitOptions, verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 29911, 31598);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_21003_30881_31014(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = this_param.WithOutputKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 30881, 31014);
                    return return_v;
                }


                string
                f_21003_31139_31154()
                {
                    var return_v = GetUniqueName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 31139, 31154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_31047_31155(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
                source, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                parseOptions, Roslyn.Test.Utilities.TargetFramework
                targetFramework, string
                assemblyName)
                {
                    var return_v = CreateCompilation(source, references, options, parseOptions, targetFramework, assemblyName: assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 31047, 31155);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_21003_31177_31586(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestBase
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>?
                manifestResources, System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.ModuleData>?
                dependencies, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>?
                sourceSymbolValidator, System.Action<Microsoft.CodeAnalysis.PEAssembly>?
                validator, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>?
                symbolValidator, Microsoft.CodeAnalysis.Test.Utilities.SignatureDescription[]?
                expectedSignatures, string?
                expectedOutput, int?
                expectedReturnCode, string[]?
                args, Microsoft.CodeAnalysis.Emit.EmitOptions?
                emitOptions, Microsoft.CodeAnalysis.Test.Utilities.Verification
                verify)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation, manifestResources, dependencies, sourceSymbolValidator, validator, symbolValidator, expectedSignatures, expectedOutput, expectedReturnCode, args, emitOptions, verify);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 31177, 31586);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 29911, 31598);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 29911, 31598);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CompilationVerifier CompileAndVerify(
                    Compilation compilation,
                    IEnumerable<ResourceDescription> manifestResources = null,
                    IEnumerable<ModuleData> dependencies = null,
                    Action<ModuleSymbol> sourceSymbolValidator = null,
                    Action<PEAssembly> validator = null,
                    Action<ModuleSymbol> symbolValidator = null,
                    SignatureDescription[] expectedSignatures = null,
                    string expectedOutput = null,
                    int? expectedReturnCode = null,
                    string[] args = null,
                    EmitOptions emitOptions = null,
                    Verification verify = Verification.Passes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 31610, 33103);

                Action<IModuleSymbol> translate(Action<ModuleSymbol> action)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 32308, 32639);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 32401, 32624) || true) && (action != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 32401, 32624);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 32461, 32511);

                            return (m) => action(m.GetSymbol<ModuleSymbol>());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 32401, 32624);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 32401, 32624);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 32593, 32605);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 32401, 32624);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 32308, 32639);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 32308, 32639);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 32308, 32639);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 32655, 33092);

                return f_21003_32662_33091(this, compilation, manifestResources, dependencies, f_21003_32800_32832(sourceSymbolValidator), validator, f_21003_32879_32905(symbolValidator), expectedSignatures, expectedOutput, expectedReturnCode, args, emitOptions, verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 31610, 33103);

                System.Action<Microsoft.CodeAnalysis.IModuleSymbol>
                f_21003_32800_32832(System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>?
                action)
                {
                    var return_v = translate(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 32800, 32832);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.IModuleSymbol>
                f_21003_32879_32905(System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>?
                action)
                {
                    var return_v = translate(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 32879, 32905);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_21003_32662_33091(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestBase
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>?
                manifestResources, System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.ModuleData>?
                dependencies, System.Action<Microsoft.CodeAnalysis.IModuleSymbol>
                sourceSymbolValidator, System.Action<Microsoft.CodeAnalysis.PEAssembly>?
                assemblyValidator, System.Action<Microsoft.CodeAnalysis.IModuleSymbol>
                symbolValidator, Microsoft.CodeAnalysis.Test.Utilities.SignatureDescription[]?
                expectedSignatures, string?
                expectedOutput, int?
                expectedReturnCode, string[]?
                args, Microsoft.CodeAnalysis.Emit.EmitOptions?
                emitOptions, Microsoft.CodeAnalysis.Test.Utilities.Verification
                verify)
                {
                    var return_v = this_param.CompileAndVerifyCommon(compilation, manifestResources, dependencies, sourceSymbolValidator, assemblyValidator, symbolValidator, expectedSignatures, expectedOutput, expectedReturnCode, args, emitOptions, verify);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 32662, 33091);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 31610, 33103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 31610, 33103);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CompilationVerifier CompileAndVerifyFieldMarshal(CSharpTestSource source, Dictionary<string, byte[]> expectedBlobs, bool isField = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 33261, 33616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 33277, 33616);
                return f_21003_33277_33616(this, source, (s, _) =>
                                {
                                    CustomAssert.True(expectedBlobs.ContainsKey(s), "Expecting marshalling blob for " + (isField ? "field " : "parameter ") + s);
                                    return expectedBlobs[s];
                                }, isField); DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 33261, 33616);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 33261, 33616);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 33261, 33616);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CompilationVerifier CompileAndVerifyFieldMarshal(CSharpTestSource source, Func<string, PEAssembly, byte[]> getExpectedBlob, bool isField = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 33783, 33994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 33799, 33994);
                return f_21003_33799_33994(this, f_21003_33852_33933(source, parseOptions: TestOptions.RegularPreview), getExpectedBlob, isField); DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 33783, 33994);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 33783, 33994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 33783, 33994);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTree Parse(string text, string filename = "", CSharpParseOptions options = null, Encoding encoding = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 34047, 34498);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 34198, 34304) || true) && ((object)options == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 34198, 34304);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 34259, 34289);

                    options = TestOptions.Regular;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 34198, 34304);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 34320, 34386);

                var
                stringText = f_21003_34337_34385(text, encoding ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Text.Encoding?>(21003, 34359, 34384) ?? f_21003_34371_34384()))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 34400, 34487);

                return f_21003_34407_34486(f_21003_34425_34485(stringText, options, filename));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 34047, 34498);

                System.Text.Encoding
                f_21003_34371_34384()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 34371, 34384);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_21003_34337_34385(string
                text, System.Text.Encoding
                encoding)
                {
                    var return_v = StringText.From(text, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 34337, 34385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_21003_34425_34485(Microsoft.CodeAnalysis.Text.SourceText
                text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options, string
                path)
                {
                    var return_v = SyntaxFactory.ParseSyntaxTree(text, (Microsoft.CodeAnalysis.ParseOptions)options, path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 34425, 34485);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_21003_34407_34486(Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = CheckSerializable(tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 34407, 34486);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 34047, 34498);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 34047, 34498);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SyntaxTree CheckSerializable(SyntaxTree tree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 34510, 34855);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 34595, 34627);

                var
                stream = f_21003_34608_34626()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 34641, 34667);

                var
                root = f_21003_34652_34666(tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 34681, 34706);

                f_21003_34681_34705(root, stream);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 34720, 34740);

                stream.Position = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 34754, 34818);

                var
                deserializedRoot = f_21003_34777_34817(stream)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 34832, 34844);

                return tree;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 34510, 34855);

                System.IO.MemoryStream
                f_21003_34608_34626()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 34608, 34626);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_21003_34652_34666(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 34652, 34666);
                    return return_v;
                }


                int
                f_21003_34681_34705(Microsoft.CodeAnalysis.SyntaxNode
                this_param, System.IO.MemoryStream
                stream)
                {
                    this_param.SerializeTo((System.IO.Stream)stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 34681, 34705);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_21003_34777_34817(System.IO.MemoryStream
                stream)
                {
                    var return_v = CSharpSyntaxNode.DeserializeFrom((System.IO.Stream)stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 34777, 34817);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 34510, 34855);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 34510, 34855);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTree[] Parse(IEnumerable<string> sources, CSharpParseOptions options = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 34867, 35170);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 34988, 35102) || true) && (sources == null || (DynAbs.Tracing.TraceSender.Expression_False(21003, 34992, 35025) || !f_21003_35012_35025(sources)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 34988, 35102);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 35059, 35087);

                    return new SyntaxTree[] { };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 34988, 35102);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 35118, 35159);

                return f_21003_35125_35158(options, f_21003_35140_35157(sources));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 34867, 35170);

                bool
                f_21003_35012_35025(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.Any<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 35012, 35025);
                    return return_v;
                }


                string[]
                f_21003_35140_35157(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.ToArray<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 35140, 35157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree[]
                f_21003_35125_35158(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                options, params string[]
                sources)
                {
                    var return_v = Parse(options, sources);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 35125, 35158);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 34867, 35170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 34867, 35170);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTree[] Parse(CSharpParseOptions options = null, params string[] sources)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 35182, 35538);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 35299, 35442) || true) && (sources == null || (DynAbs.Tracing.TraceSender.Expression_False(21003, 35303, 35365) || (f_21003_35323_35337(sources) == 1 && (DynAbs.Tracing.TraceSender.Expression_True(21003, 35323, 35364) && null == sources[0]))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 35299, 35442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 35399, 35427);

                    return new SyntaxTree[] { };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 35299, 35442);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 35458, 35527);

                return f_21003_35465_35526(f_21003_35465_35516(sources, src => Parse(src, options: options)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 35182, 35538);

                int
                f_21003_35323_35337(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 35323, 35337);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_21003_35465_35516(string[]
                source, System.Func<string, Microsoft.CodeAnalysis.SyntaxTree>
                selector)
                {
                    var return_v = source.Select<string, Microsoft.CodeAnalysis.SyntaxTree>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 35465, 35516);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree[]
                f_21003_35465_35526(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                source)
                {
                    var return_v = source.ToArray<Microsoft.CodeAnalysis.SyntaxTree>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 35465, 35526);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 35182, 35538);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 35182, 35538);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTree ParseWithRoundTripCheck(string text, CSharpParseOptions options = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 35550, 35939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 35671, 35742);

                var
                tree = f_21003_35682_35741(text, options: options ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?>(21003, 35703, 35740) ?? TestOptions.RegularPreview))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 35756, 35788);

                var
                parsedText = f_21003_35773_35787(tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 35850, 35902);

                f_21003_35850_35901(text, f_21003_35875_35900(parsedText));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 35916, 35928);

                return tree;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 35550, 35939);

                Microsoft.CodeAnalysis.SyntaxTree
                f_21003_35682_35741(string
                text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options)
                {
                    var return_v = Parse(text, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 35682, 35741);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_21003_35773_35787(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 35773, 35787);
                    return return_v;
                }


                string
                f_21003_35875_35900(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ToFullString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 35875, 35900);
                    return return_v;
                }


                bool
                f_21003_35850_35901(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 35850, 35901);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 35550, 35939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 35550, 35939);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpCompilation CreateCompilationWithIL(
                    CSharpTestSource source,
                    string ilSource,
                    TargetFramework targetFramework = TargetFramework.Standard,
                    IEnumerable<MetadataReference> references = null,
                    CSharpCompilationOptions options = null,
                    CSharpParseOptions parseOptions = null,
                    bool appendDefaultHeader = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 36428, 36558);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 36431, 36558);
                return f_21003_36431_36558(source, ilSource, targetFramework, references, options, parseOptions, appendDefaultHeader); DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 36428, 36558);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 36428, 36558);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 36428, 36558);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpCompilation CreateCompilationWithILAndMscorlib40(
                    CSharpTestSource source,
                    string ilSource,
                    TargetFramework targetFramework = TargetFramework.Mscorlib40,
                    IEnumerable<MetadataReference> references = null,
                    CSharpCompilationOptions options = null,
                    CSharpParseOptions parseOptions = null,
                    bool appendDefaultHeader = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 36571, 37312);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 37024, 37097);

                MetadataReference
                ilReference = f_21003_37056_37096(ilSource, appendDefaultHeader)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 37111, 37211);

                var
                allReferences = f_21003_37131_37193(targetFramework, references).Add(ilReference)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 37225, 37301);

                return f_21003_37232_37300(source, allReferences, options, parseOptions);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 36571, 37312);

                Microsoft.CodeAnalysis.MetadataReference
                f_21003_37056_37096(string
                ilSource, bool
                prependDefaultHeader)
                {
                    var return_v = CompileIL(ilSource, prependDefaultHeader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 37056, 37096);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                f_21003_37131_37193(Roslyn.Test.Utilities.TargetFramework
                tf, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
                additionalReferences)
                {
                    var return_v = TargetFrameworkUtil.GetReferences(tf, additionalReferences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 37131, 37193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_37232_37300(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
                source, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
                options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                parseOptions)
                {
                    var return_v = CreateEmptyCompilation(source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options, parseOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 37232, 37300);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 36571, 37312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 36571, 37312);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpCompilation CreateCompilationWithMscorlib40(
                    CSharpTestSource source,
                    IEnumerable<MetadataReference> references = null,
                    CSharpCompilationOptions options = null,
                    CSharpParseOptions parseOptions = null,
                    string assemblyName = "",
                    string sourceFileName = "")
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 37677, 37798);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 37680, 37798);
                return f_21003_37680_37798(source, references, options, parseOptions, TargetFramework.Mscorlib40, assemblyName, sourceFileName); DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 37677, 37798);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 37677, 37798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 37677, 37798);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpCompilation CreateCompilationWithMscorlib45(
                    CSharpTestSource source,
                    IEnumerable<MetadataReference> references = null,
                    CSharpCompilationOptions options = null,
                    CSharpParseOptions parseOptions = null,
                    string assemblyName = "",
                    string sourceFileName = "",
                    bool skipUsesIsNullable = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 38210, 38351);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 38213, 38351);
                return f_21003_38213_38351(source, references, options, parseOptions, TargetFramework.Mscorlib45, assemblyName, sourceFileName, skipUsesIsNullable); DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 38210, 38351);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 38210, 38351);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 38210, 38351);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpCompilation CreateCompilationWithMscorlib45(
                    string[] source,
                    IEnumerable<MetadataReference> references = null,
                    CSharpCompilationOptions options = null,
                    CSharpParseOptions parseOptions = null,
                    string assemblyName = "",
                    string sourceFileName = "",
                    bool skipUsesIsNullable = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 38755, 38896);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 38758, 38896);
                return f_21003_38758_38896(source, references, options, parseOptions, TargetFramework.Mscorlib45, assemblyName, sourceFileName, skipUsesIsNullable); DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 38755, 38896);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 38755, 38896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 38755, 38896);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpCompilation CreateCompilationWithMscorlib46(
                    CSharpTestSource source,
                    IEnumerable<MetadataReference> references = null,
                    CSharpCompilationOptions options = null,
                    CSharpParseOptions parseOptions = null,
                    string assemblyName = "",
                    string sourceFileName = "")
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 39262, 39383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 39265, 39383);
                return f_21003_39265_39383(source, references, options, parseOptions, TargetFramework.Mscorlib46, assemblyName, sourceFileName); DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 39262, 39383);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 39262, 39383);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 39262, 39383);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CSharpCompilation CreateExperimentalCompilationWithMscorlib45(
                    CSharpTestSource source,
                    MessageID feature,
                    IEnumerable<MetadataReference> references = null,
                    CSharpCompilationOptions options = null,
                    CSharpParseOptions parseOptions = null,
                    string assemblyName = "",
                    string sourceFileName = "",
                    bool skipUsesIsNullable = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 39841, 40051);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 39844, 40051);
                return f_21003_39844_40051(source, f_21003_39874_39947(TargetFramework.Mscorlib45, references), options, parseOptions, assemblyName, sourceFileName, skipUsesIsNullable, experimentalFeature: feature); DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 39841, 40051);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 39841, 40051);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 39841, 40051);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpCompilation CreateCompilationWithWinRT(
                    CSharpTestSource source,
                    IEnumerable<MetadataReference> references = null,
                    CSharpCompilationOptions options = null,
                    CSharpParseOptions parseOptions = null,
                    string assemblyName = "",
                    string sourceFileName = "")
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 40412, 40528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 40415, 40528);
                return f_21003_40415_40528(source, references, options, parseOptions, TargetFramework.WinRT, assemblyName, sourceFileName); DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 40412, 40528);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 40412, 40528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 40412, 40528);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpCompilation CreateCompilationWithMscorlib45AndCSharp(
                    CSharpTestSource source,
                    IEnumerable<MetadataReference> references = null,
                    CSharpCompilationOptions options = null,
                    CSharpParseOptions parseOptions = null,
                    string assemblyName = "",
                    string sourceFileName = "")
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 40903, 41033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 40906, 41033);
                return f_21003_40906_41033(source, references, options, parseOptions, TargetFramework.Mscorlib45AndCSharp, assemblyName, sourceFileName); DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 40903, 41033);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 40903, 41033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 40903, 41033);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpCompilation CreateCompilationWithMscorlib40AndSystemCore(
                    CSharpTestSource source,
                    IEnumerable<MetadataReference> references = null,
                    CSharpCompilationOptions options = null,
                    CSharpParseOptions parseOptions = null,
                    string assemblyName = "",
                    string sourceFileName = "")
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 41412, 41546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 41415, 41546);
                return f_21003_41415_41546(source, references, options, parseOptions, TargetFramework.Mscorlib40AndSystemCore, assemblyName, sourceFileName); DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 41412, 41546);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 41412, 41546);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 41412, 41546);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpCompilation CreateCompilationWithMscorlib40AndSystemCore(
                    string[] source,
                    IEnumerable<MetadataReference> references = null,
                    CSharpCompilationOptions options = null,
                    CSharpParseOptions parseOptions = null,
                    string assemblyName = "",
                    string sourceFileName = "")
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 41917, 42051);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 41920, 42051);
                return f_21003_41920_42051(source, references, options, parseOptions, TargetFramework.Mscorlib40AndSystemCore, assemblyName, sourceFileName); DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 41917, 42051);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 41917, 42051);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 41917, 42051);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpCompilation CreateCompilationWithCSharp(
                    CSharpTestSource source,
                    IEnumerable<MetadataReference> references = null,
                    CSharpCompilationOptions options = null,
                    CSharpParseOptions parseOptions = null,
                    string assemblyName = "",
                    string sourceFileName = "")
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 42413, 42541);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 42416, 42541);
                return f_21003_42416_42541(source, references, options, parseOptions, TargetFramework.StandardAndCSharp, assemblyName, sourceFileName); DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 42413, 42541);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 42413, 42541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 42413, 42541);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpCompilation CreateCompilationWithMscorlib40AndDocumentationComments(
                    CSharpTestSource source,
                    IEnumerable<MetadataReference> references = null,
                    CSharpCompilationOptions options = null,
                    CSharpParseOptions parseOptions = null,
                    string assemblyName = "",
                    string sourceFileName = "")
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 42554, 43364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 42955, 43103);

                parseOptions = (DynAbs.Tracing.TraceSender.Conditional_F1(21003, 42970, 42990) || ((parseOptions != null && DynAbs.Tracing.TraceSender.Conditional_F2(21003, 42993, 43055)) || DynAbs.Tracing.TraceSender.Conditional_F3(21003, 43058, 43102))) ? f_21003_42993_43055(parseOptions, DocumentationMode.Diagnose) : TestOptions.RegularWithDocumentationComments;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 43117, 43213);

                options = f_21003_43127_43212((options ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?>(21003, 43128, 43161) ?? TestOptions.ReleaseDll)), f_21003_43188_43211());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 43227, 43353);

                return f_21003_43234_43352(source, references, options, parseOptions, TargetFramework.Mscorlib40, assemblyName, sourceFileName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 42554, 43364);

                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_21003_42993_43055(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param, Microsoft.CodeAnalysis.DocumentationMode
                documentationMode)
                {
                    var return_v = this_param.WithDocumentationMode(documentationMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 42993, 43055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.XmlFileResolver
                f_21003_43188_43211()
                {
                    var return_v = XmlFileResolver.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 43188, 43211);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_21003_43127_43212(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.XmlFileResolver
                resolver)
                {
                    var return_v = this_param.WithXmlReferenceResolver((Microsoft.CodeAnalysis.XmlReferenceResolver)resolver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 43127, 43212);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_43234_43352(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
                source, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                parseOptions, Roslyn.Test.Utilities.TargetFramework
                targetFramework, string
                assemblyName, string
                sourceFileName)
                {
                    var return_v = CreateCompilation(source, references, options, parseOptions, targetFramework, assemblyName, sourceFileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 43234, 43352);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 42554, 43364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 42554, 43364);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpCompilation CreateCompilationWithTasksExtensions(
                        CSharpTestSource source,
                        IEnumerable<MetadataReference> references = null,
                        CSharpCompilationOptions options = null,
                        CSharpParseOptions parseOptions = null,
                        string assemblyName = "",
                        string sourceFileName = "")
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 43376, 44660);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 43782, 43827);

                IEnumerable<MetadataReference>
                allReferences
                = default(IEnumerable<MetadataReference>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 43843, 44373) || true) && (f_21003_43847_43880())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 43843, 44373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 43914, 43974);

                    allReferences = f_21003_43930_43973();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 43992, 44088);

                    allReferences = f_21003_44008_44087(allReferences, new[] { f_21003_44037_44084() });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 43843, 44373);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 43843, 44373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 44154, 44220);

                    allReferences = f_21003_44170_44219();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 44238, 44358);

                    allReferences = f_21003_44254_44357(allReferences, new[] { f_21003_44283_44310(), f_21003_44312_44354() });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 43843, 44373);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 44389, 44509) || true) && (references != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 44389, 44509);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 44445, 44494);

                    allReferences = f_21003_44461_44493(allReferences, references);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 44389, 44509);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 44525, 44649);

                return f_21003_44532_44648(source, allReferences, options, parseOptions, TargetFramework.Empty, assemblyName, sourceFileName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 43376, 44660);

                bool
                f_21003_43847_43880()
                {
                    var return_v = RuntimeUtilities.IsCoreClrRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 43847, 43880);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                f_21003_43930_43973()
                {
                    var return_v = TargetFrameworkUtil.NetStandard20References;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 43930, 43973);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_21003_44037_44084()
                {
                    var return_v = SystemThreadingTasksExtensions.NetStandard20Lib;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 44037, 44084);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                f_21003_44008_44087(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                first, Microsoft.CodeAnalysis.PortableExecutableReference[]
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.MetadataReference>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 44008, 44087);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                f_21003_44170_44219()
                {
                    var return_v = TargetFrameworkUtil.Mscorlib461ExtendedReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 44170, 44219);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_21003_44283_44310()
                {
                    var return_v = Net461.SystemThreadingTasks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 44283, 44310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_21003_44312_44354()
                {
                    var return_v = SystemThreadingTasksExtensions.PortableLib;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 44312, 44354);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                f_21003_44254_44357(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                first, Microsoft.CodeAnalysis.PortableExecutableReference[]
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.MetadataReference>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 44254, 44357);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                f_21003_44461_44493(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                first, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.MetadataReference>(second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 44461, 44493);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_44532_44648(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
                source, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
                options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                parseOptions, Roslyn.Test.Utilities.TargetFramework
                targetFramework, string
                assemblyName, string
                sourceFileName)
                {
                    var return_v = CreateCompilation(source, references, options, parseOptions, targetFramework, assemblyName, sourceFileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 44532, 44648);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 43376, 44660);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 43376, 44660);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpCompilation CreateCompilation(
                    CSharpTestSource source,
                    IEnumerable<MetadataReference> references = null,
                    CSharpCompilationOptions options = null,
                    CSharpParseOptions parseOptions = null,
                    TargetFramework targetFramework = TargetFramework.Standard,
                    string assemblyName = "",
                    string sourceFileName = "",
                    bool skipUsesIsNullable = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 45130, 45300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 45133, 45300);
                return f_21003_45133_45300(source, f_21003_45164_45226(targetFramework, references), options, parseOptions, assemblyName, sourceFileName, skipUsesIsNullable); DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 45130, 45300);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 45130, 45300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 45130, 45300);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpCompilation CreateEmptyCompilation(
                    CSharpTestSource source,
                    IEnumerable<MetadataReference> references = null,
                    CSharpCompilationOptions options = null,
                    CSharpParseOptions parseOptions = null,
                    string assemblyName = "",
                    string sourceFileName = "",
                    bool skipUsesIsNullable = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 45703, 45847);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 45706, 45847);
                return f_21003_45706_45847(source, references, options, parseOptions, assemblyName, sourceFileName, skipUsesIsNullable, experimentalFeature: null); DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 45703, 45847);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 45703, 45847);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 45703, 45847);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CSharpCompilation CreateCompilationCore(
                    CSharpTestSource source,
                    IEnumerable<MetadataReference> references,
                    CSharpCompilationOptions options,
                    CSharpParseOptions parseOptions,
                    string assemblyName,
                    string sourceFileName,
                    bool skipUsesIsNullable,
                    MessageID? experimentalFeature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 45860, 47974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 46280, 46350);

                var
                syntaxTrees = source.GetSyntaxTrees(parseOptions, sourceFileName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 46366, 46650) || true) && (options == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 46366, 46650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 46419, 46533);

                    bool
                    hasTopLevelStatements = f_21003_46448_46532(syntaxTrees, s => s.GetRoot().ChildNodes().OfType<GlobalStatementSyntax>().Any())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 46553, 46635);

                    options = (DynAbs.Tracing.TraceSender.Conditional_F1(21003, 46563, 46584) || ((hasTopLevelStatements && DynAbs.Tracing.TraceSender.Conditional_F2(21003, 46587, 46609)) || DynAbs.Tracing.TraceSender.Conditional_F3(21003, 46612, 46634))) ? TestOptions.ReleaseExe : TestOptions.ReleaseDll;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 46366, 46650);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 46755, 46872) || true) && (f_21003_46759_46778())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 46755, 46872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 46812, 46857);

                    options = f_21003_46822_46856(options, false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 46755, 46872);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 46888, 47066) || true) && (f_21003_46892_46920(experimentalFeature))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 46888, 47066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 46954, 47051);

                    parseOptions = f_21003_46969_47050((parseOptions ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpParseOptions>(21003, 46970, 47005) ?? TestOptions.Regular)), f_21003_47024_47049(experimentalFeature));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 46888, 47066);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 47082, 47319);

                Func<CSharpCompilation>
                createCompilationLambda = () => CSharpCompilation.Create(
                                assemblyName == "" ? GetUniqueName() : assemblyName,
                                syntaxTrees,
                                references,
                                options)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 47333, 47400);

                f_21003_47333_47399(createCompilationLambda);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 47414, 47458);

                var
                compilation = f_21003_47432_47457(createCompilationLambda)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 47689, 47930) || true) && (!skipUsesIsNullable && (DynAbs.Tracing.TraceSender.Expression_True(21003, 47693, 47747) && !f_21003_47717_47747(compilation)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 47689, 47930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 47781, 47915);

                    f_21003_47781_47914(f_21003_47805_47859(f_21003_47805_47843(f_21003_47805_47830(createCompilationLambda))), expectedUsesOfNullable: ImmutableArray<string>.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 47689, 47930);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 47944, 47963);

                return compilation;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 45860, 47974);

                bool
                f_21003_46448_46532(Microsoft.CodeAnalysis.SyntaxTree[]
                source, System.Func<Microsoft.CodeAnalysis.SyntaxTree, bool>
                predicate)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.SyntaxTree>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 46448, 46532);
                    return return_v;
                }


                bool
                f_21003_46759_46778()
                {
                    var return_v = Debugger.IsAttached;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 46759, 46778);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_21003_46822_46856(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, bool
                concurrentBuild)
                {
                    var return_v = this_param.WithConcurrentBuild(concurrentBuild);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 46822, 46856);
                    return return_v;
                }


                bool
                f_21003_46892_46920(Microsoft.CodeAnalysis.CSharp.MessageID?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 46892, 46920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MessageID
                f_21003_47024_47049(Microsoft.CodeAnalysis.CSharp.MessageID?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 47024, 47049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_21003_46969_47050(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options, params Microsoft.CodeAnalysis.CSharp.MessageID[]
                features)
                {
                    var return_v = options.WithExperimental(features);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 46969, 47050);
                    return return_v;
                }


                int
                f_21003_47333_47399(System.Func<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>
                createCompilation)
                {
                    CompilationExtensions.ValidateIOperations((System.Func<Microsoft.CodeAnalysis.Compilation>)createCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 47333, 47399);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_47432_47457(System.Func<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 47432, 47457);
                    return return_v;
                }


                bool
                f_21003_47717_47747(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = IsNullableEnabled(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 47717, 47747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_47805_47830(System.Func<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 47805, 47830);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_21003_47805_47843(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 47805, 47843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_21003_47805_47859(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 47805, 47859);
                    return return_v;
                }


                int
                f_21003_47781_47914(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol, System.Collections.Immutable.ImmutableArray<string>
                expectedUsesOfNullable)
                {
                    VerifyUsesOfNullability((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, expectedUsesOfNullable: expectedUsesOfNullable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 47781, 47914);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 45860, 47974);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 45860, 47974);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsNullableEnabled(CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 47986, 48480);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 48175, 48211);

                var
                trees = f_21003_48187_48210(compilation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 48225, 48313) || true) && (trees.IsDefaultOrEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 48225, 48313);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 48285, 48298);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 48225, 48313);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 48327, 48378);

                var
                options = (CSharpParseOptions)f_21003_48361_48377(trees[0])
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 48392, 48469);

                return f_21003_48399_48468(options, MessageID.IDS_FeatureNullableReferenceTypes);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 47986, 48480);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_21003_48187_48210(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 48187, 48210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParseOptions
                f_21003_48361_48377(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 48361, 48377);
                    return return_v;
                }


                bool
                f_21003_48399_48468(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param, Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = this_param.IsFeatureEnabled(feature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 48399, 48468);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 47986, 48480);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 47986, 48480);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void VerifyUsesOfNullability(Symbol symbol, ImmutableArray<string> expectedUsesOfNullable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 48492, 49287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 48623, 48672);

                var
                builder = f_21003_48637_48671()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 48686, 48733);

                f_21003_48686_48732(builder, symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 48749, 49067);

                var
                format = f_21003_48762_49066(f_21003_48762_48982(SymbolDisplayFormat.TestFormat
                , SymbolDisplayMiscellaneousOptions.IncludeNullableReferenceTypeModifier | SymbolDisplayMiscellaneousOptions.IncludeNotNullableReferenceTypeModifier), SymbolDisplayParameterOptions.IncludeName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 49083, 49151);

                var
                symbols = f_21003_49097_49150(builder, s => s.ToDisplayString(format))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 49165, 49180);

                f_21003_49165_49179(builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 49196, 49276);

                f_21003_49196_49275(expectedUsesOfNullable, symbols, itemInspector: s => $"\"{s}\"");
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 48492, 49287);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_21003_48637_48671()
                {
                    var return_v = ArrayBuilder<Symbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 48637, 48671);
                    return return_v;
                }


                int
                f_21003_48686_48732(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                builder, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    UsesIsNullableVisitor.GetUses(builder, symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 48686, 48732);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_21003_48762_48982(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                options)
                {
                    var return_v = this_param.AddMiscellaneousOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 48762, 48982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_21003_48762_49066(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
                options)
                {
                    var return_v = this_param.RemoveParameterOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 48762, 49066);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_21003_49097_49150(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                items, System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, string>
                map)
                {
                    var return_v = items.SelectAsArray<Microsoft.CodeAnalysis.CSharp.Symbol, string>(map);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 49097, 49150);
                    return return_v;
                }


                int
                f_21003_49165_49179(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 49165, 49179);
                    return 0;
                }


                bool
                f_21003_49196_49275(System.Collections.Immutable.ImmutableArray<string>
                expected, System.Collections.Immutable.ImmutableArray<string>
                actual, System.Func<string, string>
                itemInspector)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<string>)expected, (System.Collections.Generic.IEnumerable<string>)actual, itemInspector: itemInspector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 49196, 49275);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 48492, 49287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 48492, 49287);
            }
        }

        public static CSharpCompilation CreateCompilation(
                    AssemblyIdentity identity,
                    string[] source,
                    MetadataReference[] references,
                    CSharpCompilationOptions options = null,
                    CSharpParseOptions parseOptions = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 49299, 50231);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 49596, 49696);

                var
                trees = (DynAbs.Tracing.TraceSender.Conditional_F1(21003, 49608, 49624) || (((source == null) && DynAbs.Tracing.TraceSender.Conditional_F2(21003, 49627, 49631)) || DynAbs.Tracing.TraceSender.Conditional_F3(21003, 49634, 49695))) ? null : f_21003_49634_49695(f_21003_49634_49685(source, s => Parse(s, options: parseOptions)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 49710, 49894);

                Func<CSharpCompilation>
                createCompilationLambda = () => CSharpCompilation.Create(identity.Name, options: options ?? TestOptions.ReleaseDll, references: references, syntaxTrees: trees)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 49910, 49977);

                f_21003_49910_49976(createCompilationLambda);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 49991, 50025);

                var
                c = f_21003_49999_50024(createCompilationLambda)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 50039, 50072);

                f_21003_50039_50071(f_21003_50060_50070(c));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 50130, 50197);

                ((SourceAssemblySymbol)f_21003_50153_50163(c)).lazyAssemblyIdentity = identity;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 50211, 50220);

                return c;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 49299, 50231);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_21003_49634_49685(string[]
                source, System.Func<string, Microsoft.CodeAnalysis.SyntaxTree>
                selector)
                {
                    var return_v = source.Select<string, Microsoft.CodeAnalysis.SyntaxTree>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 49634, 49685);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree[]
                f_21003_49634_49695(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                source)
                {
                    var return_v = source.ToArray<Microsoft.CodeAnalysis.SyntaxTree>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 49634, 49695);
                    return return_v;
                }


                int
                f_21003_49910_49976(System.Func<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>
                createCompilation)
                {
                    CompilationExtensions.ValidateIOperations((System.Func<Microsoft.CodeAnalysis.Compilation>)createCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 49910, 49976);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_49999_50024(System.Func<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 49999, 50024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_21003_50060_50070(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 50060, 50070);
                    return return_v;
                }


                bool
                f_21003_50039_50071(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 50039, 50071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_21003_50153_50163(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 50153, 50163);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 49299, 50231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 49299, 50231);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpCompilation CreateSubmissionWithExactReferences(
                   string source,
                   IEnumerable<MetadataReference> references = null,
                   CSharpCompilationOptions options = null,
                   CSharpParseOptions parseOptions = null,
                   CSharpCompilation previous = null,
                   Type returnType = null,
                   Type hostObjectType = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 50243, 51231);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 50653, 51092);

                Func<CSharpCompilation>
                createCompilationLambda = () => CSharpCompilation.CreateScriptCompilation(
                                GetUniqueName(),
                                references: references,
                                options: options,
                                syntaxTree: Parse(source, options: parseOptions ?? TestOptions.Script),
                                previousScriptCompilation: previous,
                                returnType: returnType,
                                globalsType: hostObjectType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 51106, 51173);

                f_21003_51106_51172(createCompilationLambda);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 51187, 51220);

                return f_21003_51194_51219(createCompilationLambda);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 50243, 51231);

                int
                f_21003_51106_51172(System.Func<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>
                createCompilation)
                {
                    CompilationExtensions.ValidateIOperations((System.Func<Microsoft.CodeAnalysis.Compilation>)createCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 51106, 51172);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_51194_51219(System.Func<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 51194, 51219);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 50243, 51231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 50243, 51231);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<MetadataReference> s_scriptRefs;

        public static CSharpCompilation CreateSubmission(
                   string code,
                   IEnumerable<MetadataReference> references = null,
                   CSharpCompilationOptions options = null,
                   CSharpParseOptions parseOptions = null,
                   CSharpCompilation previous = null,
                   Type returnType = null,
                   Type hostObjectType = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 51371, 52395);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 51760, 52256);

                Func<CSharpCompilation>
                createCompilationLambda = () => CSharpCompilation.CreateScriptCompilation(
                                GetUniqueName(),
                                references: (references != null) ? s_scriptRefs.Concat(references) : s_scriptRefs,
                                options: options,
                                syntaxTree: Parse(code, options: parseOptions ?? TestOptions.Script),
                                previousScriptCompilation: previous,
                                returnType: returnType,
                                globalsType: hostObjectType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 52270, 52337);

                f_21003_52270_52336(createCompilationLambda);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 52351, 52384);

                return f_21003_52358_52383(createCompilationLambda);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 51371, 52395);

                int
                f_21003_52270_52336(System.Func<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>
                createCompilation)
                {
                    CompilationExtensions.ValidateIOperations((System.Func<Microsoft.CodeAnalysis.Compilation>)createCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 52270, 52336);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_52358_52383(System.Func<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 52358, 52383);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 51371, 52395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 51371, 52395);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationVerifier CompileWithCustomILSource(string cSharpSource, string ilSource, Action<CSharpCompilation> compilationVerifier = null, bool importInternals = true, string expectedOutput = null, TargetFramework targetFramework = TargetFramework.Standard)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 52407, 53626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 52695, 52795);

                var
                compilationOptions = (DynAbs.Tracing.TraceSender.Conditional_F1(21003, 52720, 52744) || (((expectedOutput != null) && DynAbs.Tracing.TraceSender.Conditional_F2(21003, 52747, 52769)) || DynAbs.Tracing.TraceSender.Conditional_F3(21003, 52772, 52794))) ? TestOptions.ReleaseExe : TestOptions.ReleaseDll
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 52811, 52977) || true) && (importInternals)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 52811, 52977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 52864, 52962);

                    compilationOptions = f_21003_52885_52961(compilationOptions, MetadataImportOptions.Internal);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 52811, 52977);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 52993, 53242) || true) && (ilSource == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 52993, 53242);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 53047, 53150);

                    var
                    c = f_21003_53055_53149(cSharpSource, options: compilationOptions, targetFramework: targetFramework)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 53168, 53227);

                    return f_21003_53175_53226(this, c, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 52993, 53242);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 53258, 53334);

                MetadataReference
                reference = f_21003_53288_53333(ilSource)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 53350, 53475);

                var
                compilation = f_21003_53368_53474(cSharpSource, new[] { reference }, compilationOptions, targetFramework: targetFramework)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 53489, 53530);

                f_21003_53509_53529(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(compilationVerifier, 21003, 53489, 53529), compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 53546, 53615);

                return f_21003_53553_53614(this, compilation, expectedOutput: expectedOutput);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 52407, 53626);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_21003_52885_52961(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.MetadataImportOptions
                value)
                {
                    var return_v = this_param.WithMetadataImportOptions(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 52885, 52961);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_53055_53149(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Roslyn.Test.Utilities.TargetFramework
                targetFramework)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, targetFramework: targetFramework);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 53055, 53149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_21003_53175_53226(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestBase
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string?
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 53175, 53226);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_21003_53288_53333(string
                ilSource)
                {
                    var return_v = CreateMetadataReferenceFromIlSource(ilSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 53288, 53333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_53368_53474(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Roslyn.Test.Utilities.TargetFramework
                targetFramework)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options, targetFramework: targetFramework);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 53368, 53474);
                    return return_v;
                }


                int
                f_21003_53509_53529(System.Action<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                obj)
                {
                    this_param?.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 53509, 53529);
                    return 0;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_21003_53553_53614(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestBase
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string?
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 53553, 53614);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 52407, 53626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 52407, 53626);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MetadataReference CreateMetadataReferenceFromIlSource(string ilSource, bool prependDefaultHeader = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 53638, 54006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 53781, 53995);
                using (var
                tempAssembly = f_21003_53807_53872(ilSource, prependDefaultHeader)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 53906, 53980);

                    return f_21003_53913_53979(f_21003_53947_53978(f_21003_53960_53977(tempAssembly)));
                    DynAbs.Tracing.TraceSender.TraceExitUsing(21003, 53781, 53995);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 53638, 54006);

                Microsoft.CodeAnalysis.Test.Utilities.DisposableFile
                f_21003_53807_53872(string
                declarations, bool
                prependDefaultHeader)
                {
                    var return_v = IlasmUtilities.CreateTempAssembly(declarations, prependDefaultHeader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 53807, 53872);
                    return return_v;
                }


                string
                f_21003_53960_53977(Microsoft.CodeAnalysis.Test.Utilities.DisposableFile
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 53960, 53977);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_21003_53947_53978(string
                path)
                {
                    var return_v = ReadFromFile(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 53947, 53978);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_21003_53913_53979(System.Collections.Immutable.ImmutableArray<byte>
                peImage)
                {
                    var return_v = MetadataReference.CreateFromImage(peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 53913, 53979);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 53638, 54006);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 53638, 54006);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CompilationVerifier CompileAndVerifyException<T>(string source, string expectedMessage = null, bool allowUnsafe = false, Verification verify = Verification.Passes) where T : Exception
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 54369, 54777);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 54586, 54685);

                var
                comp = f_21003_54597_54684<T>(source, options: f_21003_54632_54683<T>(TestOptions.ReleaseExe, allowUnsafe))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 54699, 54766);

                return f_21003_54706_54765<T>(this, comp, expectedMessage, verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 54369, 54777);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_21003_54632_54683<T>(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, bool
                enabled) where T : Exception

                {
                    var return_v = this_param.WithAllowUnsafe(enabled);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 54632, 54683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_54597_54684<T>(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options) where T : Exception

                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 54597, 54684);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_21003_54706_54765<T>(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestBase
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp, string?
                expectedMessage, Microsoft.CodeAnalysis.Test.Utilities.Verification
                verify) where T : Exception

                {
                    var return_v = this_param.CompileAndVerifyException<T>(comp, expectedMessage, verify);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 54706, 54765);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 54369, 54777);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 54369, 54777);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CompilationVerifier CompileAndVerifyException<T>(CSharpCompilation comp, string expectedMessage = null, Verification verify = Verification.Passes) where T : Exception
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 54789, 55648);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 55025, 55084);

                    f_21003_55025_55083<T>(this, comp, expectedOutput: "", verify: verify);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 55144, 55248);

                    f_21003_55144_55247<T>(true, f_21003_55169_55246<T>("Expected exception {0}({1})", f_21003_55214_55228<T>(typeof(T)), expectedMessage));
                }
                catch (ExecutionException x)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(21003, 55277, 55575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 55338, 55363);

                    var
                    e = f_21003_55346_55362<T>(x)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 55381, 55407);

                    f_21003_55381_55406<T>(e);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 55425, 55560) || true) && (expectedMessage != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 55425, 55560);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 55494, 55541);

                        f_21003_55494_55540<T>(expectedMessage, f_21003_55530_55539<T>(e));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 55425, 55560);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(21003, 55277, 55575);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 55591, 55637);

                return f_21003_55598_55636<T>(this, comp, verify: verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 54789, 55648);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_21003_55025_55083<T>(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestBase
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedOutput, Microsoft.CodeAnalysis.Test.Utilities.Verification
                verify) where T : Exception

                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput: expectedOutput, verify: verify);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 55025, 55083);
                    return return_v;
                }


                string
                f_21003_55214_55228<T>(System.Type
                this_param) where T : Exception

                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 55214, 55228);
                    return return_v;
                }


                string
                f_21003_55169_55246<T>(string
                format, string
                arg0, string?
                arg1) where T : Exception

                {
                    var return_v = string.Format(format, (object)arg0, (object?)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 55169, 55246);
                    return return_v;
                }


                bool
                f_21003_55144_55247<T>(bool
                condition, string
                userMessage) where T : Exception

                {
                    var return_v = CustomAssert.False(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 55144, 55247);
                    return return_v;
                }


                System.Exception?
                f_21003_55346_55362<T>(Roslyn.Test.Utilities.ExecutionException
                this_param) where T : Exception

                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 55346, 55362);
                    return return_v;
                }


                T
                f_21003_55381_55406<T>(System.Exception?
                @object) where T : Exception

                {
                    var return_v = CustomAssert.IsType<T>((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 55381, 55406);
                    return return_v;
                }


                string
                f_21003_55530_55539<T>(System.Exception
                this_param) where T : Exception

                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 55530, 55539);
                    return return_v;
                }


                bool
                f_21003_55494_55540<T>(string
                expected, string
                actual) where T : Exception

                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 55494, 55540);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_21003_55598_55636<T>(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestBase
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.Test.Utilities.Verification
                verify) where T : Exception

                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation, verify: verify);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 55598, 55636);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 54789, 55648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 54789, 55648);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static List<SyntaxNode> GetSyntaxNodeList(SyntaxTree syntaxTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 55660, 55823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 55759, 55812);

                return f_21003_55766_55811(f_21003_55784_55804(syntaxTree), null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 55660, 55823);

                Microsoft.CodeAnalysis.SyntaxNode
                f_21003_55784_55804(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 55784, 55804);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>
                f_21003_55766_55811(Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>
                synList)
                {
                    var return_v = GetSyntaxNodeList(node, synList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 55766, 55811);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 55660, 55823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 55660, 55823);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static List<SyntaxNode> GetSyntaxNodeList(SyntaxNode node, List<SyntaxNode> synList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 55835, 56306);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 55954, 56025) || true) && (synList == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 55954, 56025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 55992, 56025);

                    synList = f_21003_56002_56024();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 55954, 56025);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 56041, 56059);

                f_21003_56041_56058(
                            synList, node);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 56075, 56264);
                    foreach (var child in f_21003_56097_56123_I(f_21003_56097_56123(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 56075, 56264);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 56157, 56249) || true) && (child.IsNode)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 56157, 56249);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 56196, 56249);

                            synList = f_21003_56206_56248(child.AsNode(), synList);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 56157, 56249);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 56075, 56264);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21003, 1, 190);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21003, 1, 190);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 56280, 56295);

                return synList;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 55835, 56306);

                System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>
                f_21003_56002_56024()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 56002, 56024);
                    return return_v;
                }


                int
                f_21003_56041_56058(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 56041, 56058);
                    return 0;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList
                f_21003_56097_56123(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ChildNodesAndTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 56097, 56123);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>
                f_21003_56206_56248(Microsoft.CodeAnalysis.SyntaxNode?
                node, System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>
                synList)
                {
                    var return_v = GetSyntaxNodeList(node, synList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 56206, 56248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList
                f_21003_56097_56123_I(Microsoft.CodeAnalysis.ChildSyntaxList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 56097, 56123);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 55835, 56306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 55835, 56306);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static SyntaxNode GetSyntaxNodeForBinding(List<SyntaxNode> synList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 56318, 56489);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 56420, 56478);

                return f_21003_56427_56477(synList);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 56318, 56489);

                Microsoft.CodeAnalysis.SyntaxNode
                f_21003_56427_56477(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>
                synList)
                {
                    var return_v = GetSyntaxNodeOfTypeForBinding<SyntaxNode>(synList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 56427, 56477);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 56318, 56489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 56318, 56489);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected const string
        StartString = "/*<bind>*/"
        ;

        protected const string
        EndString = "/*</bind>*/"
        ;

        protected static TNode GetSyntaxNodeOfTypeForBinding<TNode>(List<SyntaxNode> synList) where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 56622, 58282);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 56757, 58243);
                    foreach (var node in f_21003_56778_56801_I<TNode>(f_21003_56778_56801<TNode>(synList)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 56757, 58243);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 56835, 56877);

                        string
                        exprFullText = f_21003_56857_56876<TNode>(node)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 56895, 56930);

                        exprFullText = f_21003_56910_56929<TNode>(exprFullText);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 56950, 57578) || true) && (f_21003_56954_57016<TNode>(exprFullText, StartString, StringComparison.Ordinal))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 56950, 57578);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 57058, 57559) || true) && (f_21003_57062_57094<TNode>(exprFullText, EndString))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 57058, 57559);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 57144, 57426) || true) && (f_21003_57148_57206<TNode>(exprFullText, EndString, StringComparison.Ordinal))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 57144, 57426);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 57264, 57276);

                                    return node;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 57144, 57426);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 57144, 57426);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 57390, 57399);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 57144, 57426);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 57058, 57559);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 57058, 57559);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 57524, 57536);

                                return node;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 57058, 57559);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 56950, 57578);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 57598, 58228) || true) && (f_21003_57602_57660<TNode>(exprFullText, EndString, StringComparison.Ordinal))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 57598, 58228);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 57702, 58209) || true) && (f_21003_57706_57740<TNode>(exprFullText, StartString))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 57702, 58209);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 57790, 58076) || true) && (f_21003_57794_57856<TNode>(exprFullText, StartString, StringComparison.Ordinal))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 57790, 58076);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 57914, 57926);

                                    return node;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 57790, 58076);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 57790, 58076);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 58040, 58049);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 57790, 58076);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 57702, 58209);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 57702, 58209);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 58174, 58186);

                                return node;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 57702, 58209);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 57598, 58228);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 56757, 58243);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21003, 1, 1487);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21003, 1, 1487);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 58259, 58271);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 56622, 58282);

                System.Collections.Generic.IEnumerable<TNode>
                f_21003_56778_56801<TNode>(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>
                source) where TNode : SyntaxNode

                {
                    var return_v = source.OfType<TNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 56778, 56801);
                    return return_v;
                }


                string
                f_21003_56857_56876<TNode>(TNode
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.ToFullString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 56857, 56876);
                    return return_v;
                }


                string
                f_21003_56910_56929<TNode>(string
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 56910, 56929);
                    return return_v;
                }


                bool
                f_21003_56954_57016<TNode>(string
                this_param, string
                value, System.StringComparison
                comparisonType) where TNode : SyntaxNode

                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 56954, 57016);
                    return return_v;
                }


                bool
                f_21003_57062_57094<TNode>(string
                this_param, string
                value) where TNode : SyntaxNode

                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 57062, 57094);
                    return return_v;
                }


                bool
                f_21003_57148_57206<TNode>(string
                this_param, string
                value, System.StringComparison
                comparisonType) where TNode : SyntaxNode

                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 57148, 57206);
                    return return_v;
                }


                bool
                f_21003_57602_57660<TNode>(string
                this_param, string
                value, System.StringComparison
                comparisonType) where TNode : SyntaxNode

                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 57602, 57660);
                    return return_v;
                }


                bool
                f_21003_57706_57740<TNode>(string
                this_param, string
                value) where TNode : SyntaxNode

                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 57706, 57740);
                    return return_v;
                }


                bool
                f_21003_57794_57856<TNode>(string
                this_param, string
                value, System.StringComparison
                comparisonType) where TNode : SyntaxNode

                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 57794, 57856);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<TNode>
                f_21003_56778_56801_I<TNode>(System.Collections.Generic.IEnumerable<TNode>
                i) where TNode : SyntaxNode

                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 56778, 56801);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 56622, 58282);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 56622, 58282);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Tuple<TNode, SemanticModel> GetBindingNodeAndModel<TNode>(CSharpCompilation compilation, int treeIndex = 0) where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 58358, 58715);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 58522, 58579);

                var
                node = f_21003_58533_58578<TNode>(this, compilation, treeIndex)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 58593, 58704);

                return f_21003_58600_58703<TNode>(node, f_21003_58638_58702<TNode>(compilation, f_21003_58667_58690<TNode>(compilation)[treeIndex]));
                DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 58358, 58715);

                TNode
                f_21003_58533_58578<TNode>(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestBase
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, int
                treeIndex) where TNode : SyntaxNode

                {
                    var return_v = this_param.GetBindingNode<TNode>(compilation, treeIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 58533, 58578);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_21003_58667_58690<TNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 58667, 58690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_21003_58638_58702<TNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree) where TNode : SyntaxNode

                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 58638, 58702);
                    return return_v;
                }


                System.Tuple<TNode, Microsoft.CodeAnalysis.SemanticModel>
                f_21003_58600_58703<TNode>(TNode
                item1, Microsoft.CodeAnalysis.SemanticModel
                item2) where TNode : SyntaxNode

                {
                    var return_v = new System.Tuple<TNode, Microsoft.CodeAnalysis.SemanticModel>(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 58600, 58703);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 58358, 58715);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 58358, 58715);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Tuple<TNode, SemanticModel> GetBindingNodeAndModel<TNode>(Compilation compilation, int treeIndex = 0) where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 58727, 58976);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 58885, 58965);

                return f_21003_58892_58964<TNode>(this, compilation, treeIndex);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 58727, 58976);

                System.Tuple<TNode, Microsoft.CodeAnalysis.SemanticModel>
                f_21003_58892_58964<TNode>(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestBase
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, int
                treeIndex) where TNode : SyntaxNode

                {
                    var return_v = this_param.GetBindingNodeAndModel<TNode>((Microsoft.CodeAnalysis.CSharp.CSharpCompilation)compilation, treeIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 58892, 58964);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 58727, 58976);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 58727, 58976);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Tuple<IList<TNode>, SemanticModel> GetBindingNodesAndModel<TNode>(CSharpCompilation compilation, int treeIndex = 0, int which = -1) where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 58988, 59386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 59176, 59242);

                var
                nodes = f_21003_59188_59241<TNode>(this, compilation, treeIndex, which)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 59256, 59375);

                return f_21003_59263_59374<TNode>(nodes, f_21003_59309_59373<TNode>(compilation, f_21003_59338_59361<TNode>(compilation)[treeIndex]));
                DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 58988, 59386);

                System.Collections.Generic.IList<TNode>
                f_21003_59188_59241<TNode>(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestBase
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, int
                treeIndex, int
                which) where TNode : SyntaxNode

                {
                    var return_v = this_param.GetBindingNodes<TNode>(compilation, treeIndex, which);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 59188, 59241);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_21003_59338_59361<TNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 59338, 59361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_21003_59309_59373<TNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree) where TNode : SyntaxNode

                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 59309, 59373);
                    return return_v;
                }


                System.Tuple<System.Collections.Generic.IList<TNode>, Microsoft.CodeAnalysis.SemanticModel>
                f_21003_59263_59374<TNode>(System.Collections.Generic.IList<TNode>
                item1, Microsoft.CodeAnalysis.SemanticModel
                item2) where TNode : SyntaxNode

                {
                    var return_v = new System.Tuple<System.Collections.Generic.IList<TNode>, Microsoft.CodeAnalysis.SemanticModel>(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 59263, 59374);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 58988, 59386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 58988, 59386);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TNode GetBindingNode<TNode>(CSharpCompilation compilation, int treeIndex = 0) where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 59523, 59997);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 59657, 59751);

                f_21003_59657_59750<TNode>(compilation.SyntaxTrees.Length > treeIndex, "Compilation has enough trees");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 59765, 59811);

                var
                tree = f_21003_59776_59799<TNode>(compilation)[treeIndex]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 59827, 59865);

                const string
                bindStart = "/*<bind>*/"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 59879, 59916);

                const string
                bindEnd = "/*</bind>*/"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 59930, 59986);

                return f_21003_59937_59985<TNode>(tree, bindStart, bindEnd);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 59523, 59997);

                bool
                f_21003_59657_59750<TNode>(bool
                condition, string
                userMessage) where TNode : SyntaxNode

                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 59657, 59750);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_21003_59776_59799<TNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 59776, 59799);
                    return return_v;
                }


                TNode
                f_21003_59937_59985<TNode>(Microsoft.CodeAnalysis.SyntaxTree
                tree, string
                startTag, string
                endTag) where TNode : SyntaxNode

                {
                    var return_v = FindBindingNode<TNode>(tree, startTag, endTag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 59937, 59985);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 59523, 59997);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 59523, 59997);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IList<TNode> GetBindingNodes<TNode>(CSharpCompilation compilation, int treeIndex = 0, int which = -1) where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 60648, 62193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 60806, 60900);

                f_21003_60806_60899<TNode>(compilation.SyntaxTrees.Length > treeIndex, "Compilation has enough trees");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 60914, 60960);

                var
                tree = f_21003_60925_60948<TNode>(compilation)[treeIndex]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 60976, 61009);

                var
                nodeList = f_21003_60991_61008<TNode>()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 61023, 61067);

                string
                text = f_21003_61037_61066<TNode>(f_21003_61037_61051<TNode>(tree))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 61083, 61127);

                const string
                bindStartFmt = "/*<bind{0}>*/"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 61141, 61184);

                const string
                bindEndFmt = "/*</bind{0}>*/"
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 61223, 62150) || true) && (which < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 61223, 62150);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 61357, 61362);
                        // assume tags with number are in increasing order, no jump
                        for (byte
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 61347, 61772) || true) && (i < 255)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 61373, 61376)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 61347, 61772))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 61347, 61772);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 61418, 61461);

                            var
                            start = f_21003_61430_61460<TNode>(bindStartFmt, i)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 61483, 61522);

                            var
                            end = f_21003_61493_61521<TNode>(bindEndFmt, i)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 61546, 61602);

                            var
                            bindNode = f_21003_61561_61601<TNode>(tree, start, end)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 61653, 61706) || true) && (bindNode == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 61653, 61706);
                                DynAbs.Tracing.TraceSender.TraceBreak(21003, 61700, 61706);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 61653, 61706);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 61730, 61753);

                            f_21003_61730_61752<TNode>(
                                                nodeList, bindNode);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(21003, 1, 426);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(21003, 1, 426);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 61223, 62150);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 61223, 62150);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 61838, 61886);

                    var
                    start2 = f_21003_61851_61885<TNode>(bindStartFmt, which)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 61904, 61948);

                    var
                    end2 = f_21003_61915_61947<TNode>(bindEndFmt, which)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 61968, 62026);

                    var
                    bindNode = f_21003_61983_62025<TNode>(tree, start2, end2)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 62069, 62135) || true) && (bindNode != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 62069, 62135);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 62112, 62135);

                        f_21003_62112_62134<TNode>(nodeList, bindNode);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 62069, 62135);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 61223, 62150);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 62166, 62182);

                return nodeList;
                DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 60648, 62193);

                bool
                f_21003_60806_60899<TNode>(bool
                condition, string
                userMessage) where TNode : SyntaxNode

                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 60806, 60899);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_21003_60925_60948<TNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 60925, 60948);
                    return return_v;
                }


                System.Collections.Generic.List<TNode>
                f_21003_60991_61008<TNode>() where TNode : SyntaxNode

                {
                    var return_v = new System.Collections.Generic.List<TNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 60991, 61008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_21003_61037_61051<TNode>(Microsoft.CodeAnalysis.SyntaxTree
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 61037, 61051);
                    return return_v;
                }


                string
                f_21003_61037_61066<TNode>(Microsoft.CodeAnalysis.SyntaxNode
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.ToFullString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 61037, 61066);
                    return return_v;
                }


                string
                f_21003_61430_61460<TNode>(string
                format, byte
                arg0) where TNode : SyntaxNode

                {
                    var return_v = String.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 61430, 61460);
                    return return_v;
                }


                string
                f_21003_61493_61521<TNode>(string
                format, byte
                arg0) where TNode : SyntaxNode

                {
                    var return_v = String.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 61493, 61521);
                    return return_v;
                }


                TNode
                f_21003_61561_61601<TNode>(Microsoft.CodeAnalysis.SyntaxTree
                tree, string
                startTag, string
                endTag) where TNode : SyntaxNode

                {
                    var return_v = FindBindingNode<TNode>(tree, startTag, endTag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 61561, 61601);
                    return return_v;
                }


                int
                f_21003_61730_61752<TNode>(System.Collections.Generic.List<TNode>
                this_param, TNode
                item) where TNode : SyntaxNode

                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 61730, 61752);
                    return 0;
                }


                string
                f_21003_61851_61885<TNode>(string
                format, int
                arg0) where TNode : SyntaxNode

                {
                    var return_v = String.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 61851, 61885);
                    return return_v;
                }


                string
                f_21003_61915_61947<TNode>(string
                format, int
                arg0) where TNode : SyntaxNode

                {
                    var return_v = String.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 61915, 61947);
                    return return_v;
                }


                TNode
                f_21003_61983_62025<TNode>(Microsoft.CodeAnalysis.SyntaxTree
                tree, string
                startTag, string
                endTag) where TNode : SyntaxNode

                {
                    var return_v = FindBindingNode<TNode>(tree, startTag, endTag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 61983, 62025);
                    return return_v;
                }


                int
                f_21003_62112_62134<TNode>(System.Collections.Generic.List<TNode>
                this_param, TNode
                item) where TNode : SyntaxNode

                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 62112, 62134);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 60648, 62193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 60648, 62193);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IList<TNode> GetBindingNodes<TNode>(Compilation compilation, int treeIndex = 0, int which = -1) where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 62205, 62448);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 62357, 62437);

                return f_21003_62364_62436<TNode>(this, compilation, treeIndex, which);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 62205, 62448);

                System.Collections.Generic.IList<TNode>
                f_21003_62364_62436<TNode>(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestBase
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, int
                treeIndex, int
                which) where TNode : SyntaxNode

                {
                    var return_v = this_param.GetBindingNodes<TNode>((Microsoft.CodeAnalysis.CSharp.CSharpCompilation)compilation, treeIndex, which);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 62364, 62436);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 62205, 62448);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 62205, 62448);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TNode FindBindingNode<TNode>(SyntaxTree tree, string startTag, string endTag) where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 62460, 64268);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 62669, 62713);

                string
                text = f_21003_62683_62712<TNode>(f_21003_62683_62697<TNode>(tree))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 62727, 62788);

                int
                start = f_21003_62739_62787<TNode>(text, startTag, StringComparison.Ordinal)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 62802, 62846) || true) && (start < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 62802, 62846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 62834, 62846);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 62802, 62846);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 62862, 62887);

                start += f_21003_62871_62886<TNode>(startTag);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 62901, 62958);

                int
                end = f_21003_62911_62957<TNode>(text, endTag, StringComparison.Ordinal)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 62972, 63028);

                f_21003_62972_63027<TNode>(end > start, "Bind Pos: end > start");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 63089, 63146);

                var
                bindText = f_21003_63104_63145<TNode>(f_21003_63104_63138<TNode>(text, start, end - start))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 63160, 63230) || true) && (f_21003_63164_63199<TNode>(bindText))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 63160, 63230);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 63218, 63230);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 63160, 63230);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 63313, 63363);

                var
                node = f_21003_63324_63355<TNode>(f_21003_63324_63338<TNode>(tree), start).Parent
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 63377, 63497) || true) && ((node != null && (DynAbs.Tracing.TraceSender.Expression_True(21003, 63385, 63428) && f_21003_63401_63416<TNode>(node) != bindText)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 63377, 63497);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 63463, 63482);

                        node = f_21003_63470_63481<TNode>(node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 63377, 63497);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21003, 63377, 63497);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21003, 63377, 63497);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 63599, 64012) || true) && (node != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 63599, 64012);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 63649, 63997) || true) && ((node as TNode) == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 63649, 63997);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 63721, 63978) || true) && (f_21003_63725_63736<TNode>(node) != null && (DynAbs.Tracing.TraceSender.Expression_True(21003, 63725, 63782) && f_21003_63748_63770<TNode>(f_21003_63748_63759<TNode>(node)) == bindText))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 63721, 63978);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 63832, 63851);

                                node = f_21003_63839_63850<TNode>(node);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 63721, 63978);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 63721, 63978);
                                DynAbs.Tracing.TraceSender.TraceBreak(21003, 63949, 63955);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 63721, 63978);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 63649, 63997);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(21003, 63649, 63997);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(21003, 63649, 63997);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 63599, 64012);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 64028, 64055);

                f_21003_64028_64054<TNode>(node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 64111, 64162);

                f_21003_64111_64161<TNode>(typeof(TNode), node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 64176, 64222);

                f_21003_64176_64221<TNode>(bindText, f_21003_64205_64220<TNode>(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 64236, 64257);

                return ((TNode)node);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 62460, 64268);

                Microsoft.CodeAnalysis.SyntaxNode
                f_21003_62683_62697<TNode>(Microsoft.CodeAnalysis.SyntaxTree
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 62683, 62697);
                    return return_v;
                }


                string
                f_21003_62683_62712<TNode>(Microsoft.CodeAnalysis.SyntaxNode
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.ToFullString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 62683, 62712);
                    return return_v;
                }


                int
                f_21003_62739_62787<TNode>(string
                this_param, string
                value, System.StringComparison
                comparisonType) where TNode : SyntaxNode

                {
                    var return_v = this_param.IndexOf(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 62739, 62787);
                    return return_v;
                }


                int
                f_21003_62871_62886<TNode>(string
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 62871, 62886);
                    return return_v;
                }


                int
                f_21003_62911_62957<TNode>(string
                this_param, string
                value, System.StringComparison
                comparisonType) where TNode : SyntaxNode

                {
                    var return_v = this_param.IndexOf(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 62911, 62957);
                    return return_v;
                }


                bool
                f_21003_62972_63027<TNode>(bool
                condition, string
                userMessage) where TNode : SyntaxNode

                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 62972, 63027);
                    return return_v;
                }


                string
                f_21003_63104_63138<TNode>(string
                this_param, int
                startIndex, int
                length) where TNode : SyntaxNode

                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 63104, 63138);
                    return return_v;
                }


                string
                f_21003_63104_63145<TNode>(string
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 63104, 63145);
                    return return_v;
                }


                bool
                f_21003_63164_63199<TNode>(string
                value) where TNode : SyntaxNode

                {
                    var return_v = String.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 63164, 63199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_21003_63324_63338<TNode>(Microsoft.CodeAnalysis.SyntaxTree
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 63324, 63338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_21003_63324_63355<TNode>(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                position) where TNode : SyntaxNode

                {
                    var return_v = this_param.FindToken(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 63324, 63355);
                    return return_v;
                }


                string
                f_21003_63401_63416<TNode>(Microsoft.CodeAnalysis.SyntaxNode
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 63401, 63416);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_21003_63470_63481<TNode>(Microsoft.CodeAnalysis.SyntaxNode
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 63470, 63481);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_21003_63725_63736<TNode>(Microsoft.CodeAnalysis.SyntaxNode
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 63725, 63736);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_21003_63748_63759<TNode>(Microsoft.CodeAnalysis.SyntaxNode
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 63748, 63759);
                    return return_v;
                }


                string
                f_21003_63748_63770<TNode>(Microsoft.CodeAnalysis.SyntaxNode
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 63748, 63770);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_21003_63839_63850<TNode>(Microsoft.CodeAnalysis.SyntaxNode
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 63839, 63850);
                    return return_v;
                }


                bool
                f_21003_64028_64054<TNode>(Microsoft.CodeAnalysis.SyntaxNode?
                @object) where TNode : SyntaxNode

                {
                    var return_v = CustomAssert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 64028, 64054);
                    return return_v;
                }


                bool
                f_21003_64111_64161<TNode>(System.Type
                expectedType, Microsoft.CodeAnalysis.SyntaxNode
                @object) where TNode : SyntaxNode

                {
                    var return_v = CustomAssert.IsAssignableFrom(expectedType, (object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 64111, 64161);
                    return return_v;
                }


                string
                f_21003_64205_64220<TNode>(Microsoft.CodeAnalysis.SyntaxNode
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 64205, 64220);
                    return return_v;
                }


                bool
                f_21003_64176_64221<TNode>(string
                expected, string
                actual) where TNode : SyntaxNode

                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 64176, 64221);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 62460, 64268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 62460, 64268);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<string> GetAttributeNames(ImmutableArray<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 64330, 64525);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 64461, 64514);

                return attributes.Select(a => a.AttributeClass.Name);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 64330, 64525);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 64330, 64525);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 64330, 64525);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<string> GetAttributeNames(ImmutableArray<CSharpAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 64537, 64727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 64663, 64716);

                return attributes.Select(a => a.AttributeClass.Name);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 64537, 64727);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 64537, 64727);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 64537, 64727);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<string> GetAttributeStrings(ImmutableArray<CSharpAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 64739, 64922);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 64867, 64911);

                return attributes.Select(a => a.ToString());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 64739, 64922);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 64739, 64922);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 64739, 64922);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<string> GetAttributeStrings(IEnumerable<CSharpAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 64934, 65114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 65059, 65103);

                return f_21003_65066_65102(attributes, a => a.ToString());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 64934, 65114);

                System.Collections.Generic.IEnumerable<string?>
                f_21003_65066_65102(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, string>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, string?>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 65066, 65102);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 64934, 65114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 64934, 65114);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetDocumentationCommentText(CSharpCompilation compilation, params DiagnosticDescription[] expectedDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 65190, 65515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 65348, 65504);

                return f_21003_65355_65503(compilation, outputName: null, filterTree: null, ensureEnglishUICulture: true, expectedDiagnostics: expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 65190, 65515);

                string
                f_21003_65355_65503(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                outputName, Microsoft.CodeAnalysis.SyntaxTree
                filterTree, bool
                ensureEnglishUICulture, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expectedDiagnostics)
                {
                    var return_v = GetDocumentationCommentText(compilation, outputName: outputName, filterTree: filterTree, ensureEnglishUICulture: ensureEnglishUICulture, expectedDiagnostics: expectedDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 65355, 65503);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 65190, 65515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 65190, 65515);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetDocumentationCommentText(CSharpCompilation compilation, bool ensureEnglishUICulture, params DiagnosticDescription[] expectedDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 65527, 65899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 65714, 65888);

                return f_21003_65721_65887(compilation, outputName: null, filterTree: null, ensureEnglishUICulture: ensureEnglishUICulture, expectedDiagnostics: expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 65527, 65899);

                string
                f_21003_65721_65887(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                outputName, Microsoft.CodeAnalysis.SyntaxTree
                filterTree, bool
                ensureEnglishUICulture, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expectedDiagnostics)
                {
                    var return_v = GetDocumentationCommentText(compilation, outputName: outputName, filterTree: filterTree, ensureEnglishUICulture: ensureEnglishUICulture, expectedDiagnostics: expectedDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 65721, 65887);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 65527, 65899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 65527, 65899);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetDocumentationCommentText(CSharpCompilation compilation, string outputName = null, SyntaxTree filterTree = null, TextSpan? filterSpanWithinTree = null, bool ensureEnglishUICulture = false, params DiagnosticDescription[] expectedDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 65911, 67893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 66201, 67882);
                using (MemoryStream
                stream = f_21003_66230_66248()
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 66282, 66338);

                    DiagnosticBag
                    diagnostics = f_21003_66310_66337()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 66356, 66389);

                    CultureInfo
                    saveUICulture = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 66409, 66910) || true) && (ensureEnglishUICulture)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 66409, 66910);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 66477, 66532);

                        var
                        preferred = f_21003_66493_66531()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 66556, 66891) || true) && (preferred == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 66556, 66891);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 66627, 66658);

                            ensureEnglishUICulture = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 66556, 66891);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 66556, 66891);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 66756, 66801);

                            saveUICulture = f_21003_66772_66800();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 66827, 66868);

                            CultureInfo.CurrentUICulture = preferred;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 66556, 66891);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 66409, 66910);
                    }

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 66974, 67140);

                        f_21003_66974_67139(compilation, outputName, stream, diagnostics, default(CancellationToken), filterTree, filterSpanWithinTree);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(21003, 67177, 67388);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 67225, 67369) || true) && (ensureEnglishUICulture)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 67225, 67369);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 67301, 67346);

                            CultureInfo.CurrentUICulture = saveUICulture;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 67225, 67369);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitFinally(21003, 67177, 67388);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 67408, 67540) || true) && (expectedDiagnostics != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 67408, 67540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 67481, 67521);

                        f_21003_67481_67520(diagnostics, expectedDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 67408, 67540);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 67558, 67577);

                    f_21003_67558_67576(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 67597, 67653);

                    string
                    text = f_21003_67611_67652(f_21003_67611_67624(), f_21003_67635_67651(stream))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 67671, 67703);

                    int
                    length = f_21003_67684_67702(text, '\0')
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 67721, 67830) || true) && (length >= 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 67721, 67830);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 67778, 67811);

                        text = f_21003_67785_67810(text, 0, length);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 67721, 67830);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 67848, 67867);

                    return f_21003_67855_67866(text);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(21003, 66201, 67882);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 65911, 67893);

                System.IO.MemoryStream
                f_21003_66230_66248()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 66230, 66248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_21003_66310_66337()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 66310, 66337);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_21003_66493_66531()
                {
                    var return_v = EnsureEnglishUICulture.PreferredOrNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 66493, 66531);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_21003_66772_66800()
                {
                    var return_v = CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 66772, 66800);
                    return return_v;
                }


                int
                f_21003_66974_67139(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string?
                assemblyName, System.IO.MemoryStream
                xmlDocStream, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Threading.CancellationToken
                cancellationToken, Microsoft.CodeAnalysis.SyntaxTree?
                filterTree, Microsoft.CodeAnalysis.Text.TextSpan?
                filterSpanWithinTree)
                {
                    DocumentationCommentCompiler.WriteDocumentationCommentXml(compilation, assemblyName, (System.IO.Stream)xmlDocStream, diagnostics, cancellationToken, filterTree, filterSpanWithinTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 66974, 67139);
                    return 0;
                }


                int
                f_21003_67481_67520(Microsoft.CodeAnalysis.DiagnosticBag
                actual, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    actual.Verify(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 67481, 67520);
                    return 0;
                }


                int
                f_21003_67558_67576(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 67558, 67576);
                    return 0;
                }


                System.Text.Encoding
                f_21003_67611_67624()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 67611, 67624);
                    return return_v;
                }


                byte[]
                f_21003_67635_67651(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 67635, 67651);
                    return return_v;
                }


                string
                f_21003_67611_67652(System.Text.Encoding
                this_param, byte[]
                bytes)
                {
                    var return_v = this_param.GetString(bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 67611, 67652);
                    return return_v;
                }


                int
                f_21003_67684_67702(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 67684, 67702);
                    return return_v;
                }


                string
                f_21003_67785_67810(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 67785, 67810);
                    return return_v;
                }


                string
                f_21003_67855_67866(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 67855, 67866);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 65911, 67893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 65911, 67893);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override string VisualizeRealIL(IModuleSymbol peModule, CompilationTestData.MethodData methodData, IReadOnlyDictionary<int, string> markers, bool areLocalsZeroed)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 67960, 68266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 68156, 68255);

                return f_21003_68163_68254(f_21003_68195_68215(peModule), methodData, markers, areLocalsZeroed);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 67960, 68266);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_21003_68195_68215(Microsoft.CodeAnalysis.IModuleSymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 68195, 68215);
                    return return_v;
                }


                string
                f_21003_68163_68254(Microsoft.CodeAnalysis.CSharp.Symbol
                peModule, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
                methodData, System.Collections.Generic.IReadOnlyDictionary<int, string>
                markers, bool
                areLocalsZeroed)
                {
                    var return_v = VisualizeRealIL((Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol)peModule, methodData, markers, areLocalsZeroed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 68163, 68254);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 67960, 68266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 67960, 68266);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static unsafe string VisualizeRealIL(PEModuleSymbol peModule, CompilationTestData.MethodData methodData, IReadOnlyDictionary<int, string> markers, bool areLocalsZeroed)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 68609, 70949);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 68811, 68875);

                var
                typeName = f_21003_68826_68874(methodData.Method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 68955, 69026);

                var
                type = f_21003_68966_69025(f_21003_68966_68993(peModule), typeName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 69091, 69177);

                var
                method = (PEMethodSymbol)f_21003_69120_69167(type, f_21003_69136_69166(methodData.Method)).Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 69193, 69261);

                var
                bodyBlock = f_21003_69209_69260(f_21003_69209_69224(peModule), f_21003_69246_69259(method))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 69275, 69307);

                f_21003_69275_69306(bodyBlock);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 69323, 69373);

                var
                moduleDecoder = f_21003_69343_69372(peModule)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 69387, 69467);

                var
                peMethod = (PEMethodSymbol)f_21003_69418_69466(moduleDecoder, f_21003_69452_69465(method))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 69483, 69522);

                StringBuilder
                sb = f_21003_69502_69521()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 69536, 69575);

                var
                ilBytes = f_21003_69550_69574(bodyBlock)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 69591, 69671);

                var
                ehHandlerRegions = f_21003_69614_69670(f_21003_69643_69669(bodyBlock))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 69687, 69747);

                var
                methodDecoder = f_21003_69707_69746(peModule, peMethod)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 69763, 69819);

                ImmutableArray<ILVisualizer.LocalInfo>
                localDefinitions
                = default(ImmutableArray<ILVisualizer.LocalInfo>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 69833, 70434) || true) && (f_21003_69837_69868_M(!bodyBlock.LocalSignature.IsNil))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 69833, 70434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 69902, 70008);

                    var
                    signature = f_21003_69918_69997(f_21003_69918_69948(f_21003_69918_69933(peModule)), f_21003_69972_69996(bodyBlock)).Signature
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 70026, 70098);

                    var
                    signatureReader = f_21003_70048_70097(f_21003_70048_70063(peModule), signature)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 70116, 70196);

                    var
                    localInfos = f_21003_70133_70195(methodDecoder, ref signatureReader)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 70214, 70286);

                    localDefinitions = f_21003_70233_70285(localInfos, methodData.ILBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 69833, 70434);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 69833, 70434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 70352, 70419);

                    localDefinitions = f_21003_70371_70418();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 69833, 70434);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 70558, 70689);

                int
                maxStack = (DynAbs.Tracing.TraceSender.Conditional_F1(21003, 70573, 70635) || (((f_21003_70574_70592(bodyBlock) == 8 && (DynAbs.Tracing.TraceSender.Expression_True(21003, 70574, 70634) && f_21003_70601_70630(methodData.ILBuilder) < 8)) && DynAbs.Tracing.TraceSender.Conditional_F2(21003, 70638, 70667)) || DynAbs.Tracing.TraceSender.Conditional_F3(21003, 70670, 70688))) ? f_21003_70638_70667(methodData.ILBuilder) : f_21003_70670_70688(bodyBlock)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 70705, 70778);

                var
                visualizer = f_21003_70722_70777(f_21003_70737_70776(peModule, peMethod))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 70794, 70901);

                f_21003_70794_70900(
                            visualizer, sb, maxStack, ilBytes, localDefinitions, ehHandlerRegions, markers, areLocalsZeroed);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 70917, 70938);

                return f_21003_70924_70937(sb);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 68609, 70949);

                string
                f_21003_68826_68874(Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
                method)
                {
                    var return_v = GetContainingTypeMetadataName(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 68826, 68874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_21003_68966_68993(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 68966, 68993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_21003_68966_69025(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 68966, 69025);
                    return return_v;
                }


                string
                f_21003_69136_69166(Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
                this_param)
                {
                    var return_v = this_param.MetadataName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 69136, 69166);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_21003_69120_69167(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 69120, 69167);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_21003_69209_69224(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 69209, 69224);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinitionHandle
                f_21003_69246_69259(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 69246, 69259);
                    return return_v;
                }


                System.Reflection.Metadata.MethodBodyBlock
                f_21003_69209_69260(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                methodHandle)
                {
                    var return_v = this_param.GetMethodBodyOrThrow(methodHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 69209, 69260);
                    return return_v;
                }


                bool
                f_21003_69275_69306(System.Reflection.Metadata.MethodBodyBlock
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 69275, 69306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                f_21003_69343_69372(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder(moduleSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 69343, 69372);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinitionHandle
                f_21003_69452_69465(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 69452, 69465);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_21003_69418_69466(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                token)
                {
                    var return_v = this_param.GetSymbolForILToken((System.Reflection.Metadata.EntityHandle)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 69418, 69466);
                    return return_v;
                }


                System.Text.StringBuilder
                f_21003_69502_69521()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 69502, 69521);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_21003_69550_69574(System.Reflection.Metadata.MethodBodyBlock
                this_param)
                {
                    var return_v = this_param.GetILContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 69550, 69574);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Reflection.Metadata.ExceptionRegion>
                f_21003_69643_69669(System.Reflection.Metadata.MethodBodyBlock
                this_param)
                {
                    var return_v = this_param.ExceptionRegions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 69643, 69669);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan>
                f_21003_69614_69670(System.Collections.Immutable.ImmutableArray<System.Reflection.Metadata.ExceptionRegion>
                entries)
                {
                    var return_v = ILVisualizer.GetHandlerSpans(entries);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 69614, 69670);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                f_21003_69707_69746(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                context)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder(moduleSymbol, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 69707, 69746);
                    return return_v;
                }


                bool
                f_21003_69837_69868_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 69837, 69868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_21003_69918_69933(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 69918, 69933);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_21003_69918_69948(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 69918, 69948);
                    return return_v;
                }


                System.Reflection.Metadata.StandaloneSignatureHandle
                f_21003_69972_69996(System.Reflection.Metadata.MethodBodyBlock
                this_param)
                {
                    var return_v = this_param.LocalSignature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 69972, 69996);
                    return return_v;
                }


                System.Reflection.Metadata.StandaloneSignature
                f_21003_69918_69997(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StandaloneSignatureHandle
                handle)
                {
                    var return_v = this_param.GetStandaloneSignature(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 69918, 69997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_21003_70048_70063(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 70048, 70063);
                    return return_v;
                }


                System.Reflection.Metadata.BlobReader
                f_21003_70048_70097(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.BlobHandle
                blob)
                {
                    var return_v = this_param.GetMemoryReaderOrThrow(blob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 70048, 70097);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LocalInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                f_21003_70133_70195(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, ref System.Reflection.Metadata.BlobReader
                signatureReader)
                {
                    var return_v = this_param.DecodeLocalSignatureOrThrow(ref signatureReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 70133, 70195);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Metadata.Tools.ILVisualizer.LocalInfo>
                f_21003_70233_70285(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LocalInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                localInfos, Microsoft.CodeAnalysis.CodeGen.ILBuilder
                builder)
                {
                    var return_v = ToLocalDefinitions(localInfos, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 70233, 70285);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Metadata.Tools.ILVisualizer.LocalInfo>
                f_21003_70371_70418()
                {
                    var return_v = ImmutableArray.Create<ILVisualizer.LocalInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 70371, 70418);
                    return return_v;
                }


                int
                f_21003_70574_70592(System.Reflection.Metadata.MethodBodyBlock
                this_param)
                {
                    var return_v = this_param.MaxStack;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 70574, 70592);
                    return return_v;
                }


                ushort
                f_21003_70601_70630(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.MaxStack;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 70601, 70630);
                    return return_v;
                }


                ushort
                f_21003_70638_70667(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.MaxStack;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 70638, 70667);
                    return return_v;
                }


                int
                f_21003_70670_70688(System.Reflection.Metadata.MethodBodyBlock
                this_param)
                {
                    var return_v = this_param.MaxStack;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 70670, 70688);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                f_21003_70737_70776(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                context)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder(moduleSymbol, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 70737, 70776);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestBase.Visualizer
                f_21003_70722_70777(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                decoder)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestBase.Visualizer(decoder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 70722, 70777);
                    return return_v;
                }


                int
                f_21003_70794_70900(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestBase.Visualizer
                this_param, System.Text.StringBuilder
                sb, int
                maxStack, System.Collections.Immutable.ImmutableArray<byte>
                ilBytes, System.Collections.Immutable.ImmutableArray<Microsoft.Metadata.Tools.ILVisualizer.LocalInfo>
                locals, System.Collections.Generic.IReadOnlyList<Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan>
                exceptionHandlers, System.Collections.Generic.IReadOnlyDictionary<int, string>
                markers, bool
                localsAreZeroed)
                {
                    this_param.DumpMethod(sb, maxStack, ilBytes, locals, exceptionHandlers, markers, localsAreZeroed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 70794, 70900);
                    return 0;
                }


                string
                f_21003_70924_70937(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 70924, 70937);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 68609, 70949);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 68609, 70949);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetContainingTypeMetadataName(IMethodSymbolInternal method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 70961, 71531);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 71067, 71100);

                var
                type = f_21003_71078_71099(method)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 71114, 71191) || true) && (type == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 71114, 71191);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 71164, 71176);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 71114, 71191);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 71207, 71257);

                string
                ns = f_21003_71219_71256(f_21003_71219_71243(type))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 71271, 71302);

                var
                result = f_21003_71284_71301(type)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 71318, 71452) || true) && ((type = f_21003_71333_71352(type)) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 71318, 71452);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 71395, 71437);

                        result = f_21003_71404_71421(type) + "+" + result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 71318, 71452);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21003, 71318, 71452);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21003, 71318, 71452);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 71468, 71520);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(21003, 71475, 71490) || (((f_21003_71476_71485(ns) > 0) && DynAbs.Tracing.TraceSender.Conditional_F2(21003, 71493, 71510)) || DynAbs.Tracing.TraceSender.Conditional_F3(21003, 71513, 71519))) ? ns + "." + result : result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 70961, 71531);

                Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal
                f_21003_71078_71099(Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 71078, 71099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal
                f_21003_71219_71243(Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 71219, 71243);
                    return return_v;
                }


                string
                f_21003_71219_71256(Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal
                this_param)
                {
                    var return_v = this_param.MetadataName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 71219, 71256);
                    return return_v;
                }


                string
                f_21003_71284_71301(Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal
                this_param)
                {
                    var return_v = this_param.MetadataName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 71284, 71301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal
                f_21003_71333_71352(Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 71333, 71352);
                    return return_v;
                }


                string
                f_21003_71404_71421(Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal
                this_param)
                {
                    var return_v = this_param.MetadataName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 71404, 71421);
                    return return_v;
                }


                int
                f_21003_71476_71485(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 71476, 71485);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 70961, 71531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 70961, 71531);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<ILVisualizer.LocalInfo> ToLocalDefinitions(ImmutableArray<LocalInfo<TypeSymbol>> localInfos, ILBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 71543, 72318);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 71709, 71835) || true) && (localInfos.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 71709, 71835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 71765, 71820);

                    return f_21003_71772_71819();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 71709, 71835);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 71851, 71910);

                var
                result = new ILVisualizer.LocalInfo[localInfos.Length]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 71933, 71938);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 71924, 72257) || true) && (i < f_21003_71944_71957(result))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 71959, 71962)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 71924, 72257))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 71924, 72257);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 71996, 72029);

                        var
                        typeRef = localInfos[i].Type
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 72047, 72110);

                        var
                        builderLocal = f_21003_72066_72106(builder.LocalSlotManager)[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 72128, 72242);

                        result[i] = f_21003_72140_72241(f_21003_72167_72184(builderLocal), typeRef, localInfos[i].IsPinned, localInfos[i].IsByRef);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21003, 1, 334);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21003, 1, 334);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 72273, 72307);

                return f_21003_72280_72306(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 71543, 72318);

                System.Collections.Immutable.ImmutableArray<Microsoft.Metadata.Tools.ILVisualizer.LocalInfo>
                f_21003_71772_71819()
                {
                    var return_v = ImmutableArray.Create<ILVisualizer.LocalInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 71772, 71819);
                    return return_v;
                }


                int
                f_21003_71944_71957(Microsoft.Metadata.Tools.ILVisualizer.LocalInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 71944, 71957);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                f_21003_72066_72106(Microsoft.CodeAnalysis.CodeGen.LocalSlotManager
                this_param)
                {
                    var return_v = this_param.LocalsInOrder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 72066, 72106);
                    return return_v;
                }


                string?
                f_21003_72167_72184(Microsoft.Cci.ILocalDefinition
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 72167, 72184);
                    return return_v;
                }


                Microsoft.Metadata.Tools.ILVisualizer.LocalInfo
                f_21003_72140_72241(string?
                name, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                isPinned, bool
                isByRef)
                {
                    var return_v = new Microsoft.Metadata.Tools.ILVisualizer.LocalInfo(name, (object)type, isPinned, isByRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 72140, 72241);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Metadata.Tools.ILVisualizer.LocalInfo>
                f_21003_72280_72306(Microsoft.Metadata.Tools.ILVisualizer.LocalInfo[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.Metadata.Tools.ILVisualizer.LocalInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 72280, 72306);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 71543, 72318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 71543, 72318);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class Visualizer : ILVisualizer
        {
            private readonly MetadataDecoder _decoder;

            public Visualizer(MetadataDecoder decoder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(21003, 72459, 72568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 72434, 72442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 72534, 72553);

                    _decoder = decoder;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(21003, 72459, 72568);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 72459, 72568);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 72459, 72568);
                }
            }

            public override string VisualizeUserString(uint token)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 72584, 72848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 72671, 72720);

                    var
                    reader = f_21003_72684_72719(_decoder.Module)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 72738, 72833);

                    return "\"" + f_21003_72752_72825(reader, f_21003_72791_72824(token)) + "\"";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 72584, 72848);

                    System.Reflection.Metadata.MetadataReader
                    f_21003_72684_72719(Microsoft.CodeAnalysis.PEModule
                    module)
                    {
                        var return_v = module.GetMetadataReader();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 72684, 72719);
                        return return_v;
                    }


                    System.Reflection.Metadata.Handle
                    f_21003_72791_72824(uint
                    token)
                    {
                        var return_v = MetadataTokens.Handle((int)token);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 72791, 72824);
                        return return_v;
                    }


                    string
                    f_21003_72752_72825(System.Reflection.Metadata.MetadataReader
                    this_param, System.Reflection.Metadata.Handle
                    handle)
                    {
                        var return_v = this_param.GetUserString((System.Reflection.Metadata.UserStringHandle)handle);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 72752, 72825);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 72584, 72848);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 72584, 72848);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override string VisualizeSymbol(uint token, OperandType operandType)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 72864, 73421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 72972, 73061);

                    Symbol
                    reference = f_21003_72991_73060(_decoder, f_21003_73020_73059(token))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 73252, 73406);

                    return f_21003_73259_73405("\"{0}\"", (DynAbs.Tracing.TraceSender.Conditional_F1(21003, 73284, 73303) || ((reference is Symbol && DynAbs.Tracing.TraceSender.Conditional_F2(21003, 73306, 73384)) || DynAbs.Tracing.TraceSender.Conditional_F3(21003, 73387, 73404))) ? f_21003_73306_73384(((Symbol)reference), SymbolDisplayFormat.ILVisualizationFormat) : (object)reference);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 72864, 73421);

                    System.Reflection.Metadata.EntityHandle
                    f_21003_73020_73059(uint
                    token)
                    {
                        var return_v = MetadataTokens.EntityHandle((int)token);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 73020, 73059);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_21003_72991_73060(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                    this_param, System.Reflection.Metadata.EntityHandle
                    token)
                    {
                        var return_v = this_param.GetSymbolForILToken(token);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 72991, 73060);
                        return return_v;
                    }


                    string
                    f_21003_73306_73384(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                    format)
                    {
                        var return_v = this_param.ToDisplayString(format);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 73306, 73384);
                        return return_v;
                    }


                    string
                    f_21003_73259_73405(string
                    format, object
                    arg0)
                    {
                        var return_v = string.Format(format, arg0);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 73259, 73405);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 72864, 73421);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 72864, 73421);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override string VisualizeLocalType(object type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 73437, 74240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 73524, 73538);

                    Symbol
                    symbol
                    = default(Symbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 73558, 74112) || true) && (type is int)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 73558, 74112);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 73615, 73693);

                        symbol = f_21003_73624_73692(_decoder, f_21003_73653_73691(type));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 73558, 74112);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 73558, 74112);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 73775, 73799);

                        symbol = type as Symbol;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 73823, 74093) || true) && (symbol is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 73823, 74093);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 73983, 74017);

                            var
                            temp = type as Cci.IReference
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 74025, 74070);

                            symbol = f_21003_74039_74059(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(temp, 21003, 74034, 74059)) as Symbol;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 73823, 74093);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 73558, 74112);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 74132, 74225);

                    return f_21003_74146_74205(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(symbol, 21003, 74139, 74205), SymbolDisplayFormat.ILVisualizationFormat) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(21003, 74139, 74224) ?? f_21003_74209_74224(type));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 73437, 74240);

                    System.Reflection.Metadata.EntityHandle
                    f_21003_73653_73691(object
                    token)
                    {
                        var return_v = MetadataTokens.EntityHandle((int)token);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 73653, 73691);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_21003_73624_73692(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                    this_param, System.Reflection.Metadata.EntityHandle
                    token)
                    {
                        var return_v = this_param.GetSymbolForILToken(token);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 73624, 73692);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                    f_21003_74039_74059(Microsoft.Cci.IReference
                    this_param)
                    {
                        var return_v = this_param?.GetInternalSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 74039, 74059);
                        return return_v;
                    }


                    string?
                    f_21003_74146_74205(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                    format)
                    {
                        var return_v = this_param?.ToDisplayString(format);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 74146, 74205);
                        return return_v;
                    }


                    string?
                    f_21003_74209_74224(object
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 74209, 74224);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 73437, 74240);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 73437, 74240);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static Visualizer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21003, 72330, 74251);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21003, 72330, 74251);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 72330, 74251);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(21003, 72330, 74251);
        }

        protected static (IOperation operation, SyntaxNode node) GetOperationAndSyntaxForTest<TSyntaxNode>(CSharpCompilation compilation)
                    where TSyntaxNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 74331, 75092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 74529, 74567);

                var
                tree = f_21003_74540_74563<TSyntaxNode>(compilation)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 74581, 74628);

                var
                model = f_21003_74593_74627<TSyntaxNode>(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 74642, 74734);

                SyntaxNode
                syntaxNode = f_21003_74666_74733<TSyntaxNode>(f_21003_74709_74732<TSyntaxNode>(tree))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 74748, 74839) || true) && (syntaxNode == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 74748, 74839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 74804, 74824);

                    return (null, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 74748, 74839);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 74855, 74902);

                var
                operation = f_21003_74871_74901<TSyntaxNode>(model, syntaxNode)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 74916, 75036) || true) && (operation != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21003, 74916, 75036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 74971, 75021);

                    f_21003_74971_75020<TSyntaxNode>(model, f_21003_74996_75019<TSyntaxNode>(operation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21003, 74916, 75036);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 75050, 75081);

                return (operation, syntaxNode);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 74331, 75092);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_21003_74540_74563<TSyntaxNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param) where TSyntaxNode : SyntaxNode

                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 74540, 74563);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_21003_74593_74627<TSyntaxNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree) where TSyntaxNode : SyntaxNode

                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 74593, 74627);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>
                f_21003_74709_74732<TSyntaxNode>(Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree) where TSyntaxNode : SyntaxNode

                {
                    var return_v = GetSyntaxNodeList(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 74709, 74732);
                    return return_v;
                }


                TSyntaxNode
                f_21003_74666_74733<TSyntaxNode>(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>
                synList) where TSyntaxNode : SyntaxNode

                {
                    var return_v = GetSyntaxNodeOfTypeForBinding<TSyntaxNode>(synList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 74666, 74733);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_21003_74871_74901<TSyntaxNode>(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node) where TSyntaxNode : SyntaxNode

                {
                    var return_v = this_param.GetOperation(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 74871, 74901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel?
                f_21003_74996_75019<TSyntaxNode>(Microsoft.CodeAnalysis.IOperation
                this_param) where TSyntaxNode : SyntaxNode

                {
                    var return_v = this_param.SemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 74996, 75019);
                    return return_v;
                }


                bool
                f_21003_74971_75020<TSyntaxNode>(Microsoft.CodeAnalysis.SemanticModel
                expected, Microsoft.CodeAnalysis.SemanticModel?
                actual) where TSyntaxNode : SyntaxNode

                {
                    var return_v = CustomAssert.Same((object)expected, (object?)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 74971, 75020);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 74331, 75092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 74331, 75092);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static string GetOperationTreeForTest<TSyntaxNode>(CSharpCompilation compilation)
                    where TSyntaxNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 75104, 75467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 75264, 75345);

                var (operation, syntax) = f_21003_75290_75344<TSyntaxNode>(compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 75359, 75456);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(21003, 75366, 75383) || ((operation != null && DynAbs.Tracing.TraceSender.Conditional_F2(21003, 75386, 75448)) || DynAbs.Tracing.TraceSender.Conditional_F3(21003, 75451, 75455))) ? f_21003_75386_75448<TSyntaxNode>(compilation, operation) : null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 75104, 75467);

                (Microsoft.CodeAnalysis.IOperation operation, Microsoft.CodeAnalysis.SyntaxNode node)
                f_21003_75290_75344<TSyntaxNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation) where TSyntaxNode : SyntaxNode

                {
                    var return_v = GetOperationAndSyntaxForTest<TSyntaxNode>(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 75290, 75344);
                    return return_v;
                }


                string
                f_21003_75386_75448<TSyntaxNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.IOperation
                operation) where TSyntaxNode : SyntaxNode

                {
                    var return_v = OperationTreeVerifier.GetOperationTree((Microsoft.CodeAnalysis.Compilation)compilation, operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 75386, 75448);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 75104, 75467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 75104, 75467);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static string GetOperationTreeForTest(CSharpCompilation compilation, IOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 75479, 75712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 75604, 75701);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(21003, 75611, 75628) || ((operation != null && DynAbs.Tracing.TraceSender.Conditional_F2(21003, 75631, 75693)) || DynAbs.Tracing.TraceSender.Conditional_F3(21003, 75696, 75700))) ? f_21003_75631_75693(compilation, operation) : null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 75479, 75712);

                string
                f_21003_75631_75693(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    var return_v = OperationTreeVerifier.GetOperationTree((Microsoft.CodeAnalysis.Compilation)compilation, operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 75631, 75693);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 75479, 75712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 75479, 75712);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static string GetOperationTreeForTest<TSyntaxNode>(
                    string testSrc,
                    CSharpCompilationOptions compilationOptions = null,
                    CSharpParseOptions parseOptions = null,
                    bool useLatestFrameworkReferences = false)
                    where TSyntaxNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 75724, 76430);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 76057, 76172);

                var
                targetFramework = (DynAbs.Tracing.TraceSender.Conditional_F1(21003, 76079, 76107) || ((useLatestFrameworkReferences && DynAbs.Tracing.TraceSender.Conditional_F2(21003, 76110, 76144)) || DynAbs.Tracing.TraceSender.Conditional_F3(21003, 76147, 76171))) ? TargetFramework.Mscorlib46Extended : TargetFramework.Standard
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 76186, 76348);

                var
                compilation = f_21003_76204_76347<TSyntaxNode>(testSrc, targetFramework: targetFramework, options: compilationOptions ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?>(21003, 76274, 76318) ?? TestOptions.ReleaseDll), parseOptions: parseOptions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 76362, 76419);

                return f_21003_76369_76418<TSyntaxNode>(compilation);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 75724, 76430);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_76204_76347<TSyntaxNode>(string
                source, Roslyn.Test.Utilities.TargetFramework
                targetFramework, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                parseOptions) where TSyntaxNode : SyntaxNode

                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, targetFramework: targetFramework, options: options, parseOptions: parseOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 76204, 76347);
                    return return_v;
                }


                string
                f_21003_76369_76418<TSyntaxNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation) where TSyntaxNode : SyntaxNode

                {
                    var return_v = GetOperationTreeForTest<TSyntaxNode>(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 76369, 76418);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 75724, 76430);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 75724, 76430);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static IOperation VerifyOperationTreeForTest<TSyntaxNode>(CSharpCompilation compilation, string expectedOperationTree, Action<IOperation, Compilation, SyntaxNode> additionalOperationTreeVerifier = null)
                    where TSyntaxNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 76442, 77141);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 76723, 76814);

                var (actualOperation, syntaxNode) = f_21003_76759_76813<TSyntaxNode>(compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 76828, 76908);

                var
                actualOperationTree = f_21003_76854_76907<TSyntaxNode>(compilation, actualOperation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 76922, 76995);

                f_21003_76922_76994<TSyntaxNode>(expectedOperationTree, actualOperationTree);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 77009, 77091);

                f_21003_77041_77090<TSyntaxNode>(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(additionalOperationTreeVerifier, 21003, 77009, 77090), actualOperation, compilation, syntaxNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 77107, 77130);

                return actualOperation;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 76442, 77141);

                (Microsoft.CodeAnalysis.IOperation operation, Microsoft.CodeAnalysis.SyntaxNode node)
                f_21003_76759_76813<TSyntaxNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation) where TSyntaxNode : SyntaxNode

                {
                    var return_v = GetOperationAndSyntaxForTest<TSyntaxNode>(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 76759, 76813);
                    return return_v;
                }


                string
                f_21003_76854_76907<TSyntaxNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.IOperation
                operation) where TSyntaxNode : SyntaxNode

                {
                    var return_v = GetOperationTreeForTest(compilation, operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 76854, 76907);
                    return return_v;
                }


                bool
                f_21003_76922_76994<TSyntaxNode>(string
                expectedOperationTree, string
                actualOperationTree) where TSyntaxNode : SyntaxNode

                {
                    var return_v = OperationTreeVerifier.Verify(expectedOperationTree, actualOperationTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 76922, 76994);
                    return return_v;
                }


                int
                f_21003_77041_77090<TSyntaxNode>(System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
                this_param, Microsoft.CodeAnalysis.IOperation
                arg1, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                arg2, Microsoft.CodeAnalysis.SyntaxNode
                arg3) where TSyntaxNode : SyntaxNode

                {
                    this_param?.Invoke(arg1, (Microsoft.CodeAnalysis.Compilation)arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 77041, 77090);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 76442, 77141);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 76442, 77141);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static bool VerifyOperationTreeForTest_B<TSyntaxNode>(CSharpCompilation compilation, string expectedOperationTree, Action<IOperation, Compilation, SyntaxNode> additionalOperationTreeVerifier = null)
                    where TSyntaxNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 77220, 77923);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 77497, 77588);

                var (actualOperation, syntaxNode) = f_21003_77533_77587<TSyntaxNode>(compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 77602, 77682);

                var
                actualOperationTree = f_21003_77628_77681<TSyntaxNode>(compilation, actualOperation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 77696, 77784);

                var
                toReturn = f_21003_77711_77783<TSyntaxNode>(expectedOperationTree, actualOperationTree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 77798, 77880);

                f_21003_77830_77879<TSyntaxNode>(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(additionalOperationTreeVerifier, 21003, 77798, 77879), actualOperation, compilation, syntaxNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 77896, 77912);

                return toReturn;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 77220, 77923);

                (Microsoft.CodeAnalysis.IOperation operation, Microsoft.CodeAnalysis.SyntaxNode node)
                f_21003_77533_77587<TSyntaxNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation) where TSyntaxNode : SyntaxNode

                {
                    var return_v = GetOperationAndSyntaxForTest<TSyntaxNode>(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 77533, 77587);
                    return return_v;
                }


                string
                f_21003_77628_77681<TSyntaxNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.IOperation
                operation) where TSyntaxNode : SyntaxNode

                {
                    var return_v = GetOperationTreeForTest(compilation, operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 77628, 77681);
                    return return_v;
                }


                bool
                f_21003_77711_77783<TSyntaxNode>(string
                expectedOperationTree, string
                actualOperationTree) where TSyntaxNode : SyntaxNode

                {
                    var return_v = OperationTreeVerifier.Verify(expectedOperationTree, actualOperationTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 77711, 77783);
                    return return_v;
                }


                int
                f_21003_77830_77879<TSyntaxNode>(System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
                this_param, Microsoft.CodeAnalysis.IOperation
                arg1, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                arg2, Microsoft.CodeAnalysis.SyntaxNode
                arg3) where TSyntaxNode : SyntaxNode

                {
                    this_param?.Invoke(arg1, (Microsoft.CodeAnalysis.Compilation)arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 77830, 77879);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 77220, 77923);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 77220, 77923);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static void VerifyOperationTreeForNode(CSharpCompilation compilation, SemanticModel model, SyntaxNode syntaxNode, string expectedOperationTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 77935, 78212);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 78113, 78201);

                f_21003_78113_78200(compilation, f_21003_78146_78176(model, syntaxNode), expectedOperationTree);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 77935, 78212);

                Microsoft.CodeAnalysis.IOperation?
                f_21003_78146_78176(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetOperation(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 78146, 78176);
                    return return_v;
                }


                int
                f_21003_78113_78200(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.IOperation?
                operation, string
                expectedOperationTree)
                {
                    VerifyOperationTree(compilation, operation, expectedOperationTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 78113, 78200);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 77935, 78212);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 77935, 78212);
            }
        }

        protected static void VerifyOperationTree(CSharpCompilation compilation, IOperation operation, string expectedOperationTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 78224, 78591);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 78373, 78405);

                f_21003_78373_78404(operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 78419, 78493);

                var
                actualOperationTree = f_21003_78445_78492(compilation, operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 78507, 78580);

                f_21003_78507_78579(expectedOperationTree, actualOperationTree);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 78224, 78591);

                bool
                f_21003_78373_78404(Microsoft.CodeAnalysis.IOperation
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 78373, 78404);
                    return return_v;
                }


                string
                f_21003_78445_78492(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    var return_v = GetOperationTreeForTest(compilation, operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 78445, 78492);
                    return return_v;
                }


                bool
                f_21003_78507_78579(string
                expectedOperationTree, string
                actualOperationTree)
                {
                    var return_v = OperationTreeVerifier.Verify(expectedOperationTree, actualOperationTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 78507, 78579);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 78224, 78591);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 78224, 78591);
            }
        }

        protected static void VerifyFlowGraphForTest<TSyntaxNode>(CSharpCompilation compilation, string expectedFlowGraph)
                    where TSyntaxNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 78603, 79015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 78786, 78824);

                var
                tree = f_21003_78797_78820<TSyntaxNode>(compilation)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 78838, 78930);

                SyntaxNode
                syntaxNode = f_21003_78862_78929<TSyntaxNode>(f_21003_78905_78928<TSyntaxNode>(tree))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 78944, 79004);

                f_21003_78944_79003<TSyntaxNode>(compilation, syntaxNode, expectedFlowGraph);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 78603, 79015);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_21003_78797_78820<TSyntaxNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param) where TSyntaxNode : SyntaxNode

                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 78797, 78820);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>
                f_21003_78905_78928<TSyntaxNode>(Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree) where TSyntaxNode : SyntaxNode

                {
                    var return_v = GetSyntaxNodeList(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 78905, 78928);
                    return return_v;
                }


                TSyntaxNode
                f_21003_78862_78929<TSyntaxNode>(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>
                synList) where TSyntaxNode : SyntaxNode

                {
                    var return_v = GetSyntaxNodeOfTypeForBinding<TSyntaxNode>(synList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 78862, 78929);
                    return return_v;
                }


                int
                f_21003_78944_79003<TSyntaxNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, string
                expectedFlowGraph) where TSyntaxNode : SyntaxNode

                {
                    VerifyFlowGraph(compilation, syntaxNode, expectedFlowGraph);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 78944, 79003);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 78603, 79015);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 78603, 79015);
            }
        }

        protected static void VerifyFlowGraph(CSharpCompilation compilation, SyntaxNode syntaxNode, string expectedFlowGraph)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 79027, 79483);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 79169, 79233);

                var
                model = f_21003_79181_79232(compilation, f_21003_79210_79231(syntaxNode))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 79247, 79364);

                (ControlFlowGraph graph, ISymbol associatedSymbol) = f_21003_79300_79363(syntaxNode, model);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 79378, 79472);

                f_21003_79378_79471(compilation, expectedFlowGraph, graph, associatedSymbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 79027, 79483);

                Microsoft.CodeAnalysis.SyntaxTree
                f_21003_79210_79231(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 79210, 79231);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_21003_79181_79232(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 79181, 79232);
                    return return_v;
                }


                (Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph graph, Microsoft.CodeAnalysis.ISymbol associatedSymbol)
                f_21003_79300_79363(Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.SemanticModel
                model)
                {
                    var return_v = ControlFlowGraphVerifier.GetControlFlowGraph(syntaxNode, model);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 79300, 79363);
                    return return_v;
                }


                int
                f_21003_79378_79471(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedFlowGraph, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                graph, Microsoft.CodeAnalysis.ISymbol
                associatedSymbol)
                {
                    ControlFlowGraphVerifier.VerifyGraph((Microsoft.CodeAnalysis.Compilation)compilation, expectedFlowGraph, graph, associatedSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 79378, 79471);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 79027, 79483);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 79027, 79483);
            }
        }

        protected static void VerifyOperationTreeForTest<TSyntaxNode>(
                    string testSrc,
                    string expectedOperationTree,
                    CSharpCompilationOptions compilationOptions = null,
                    CSharpParseOptions parseOptions = null,
                    bool useLatestFrameworkReferences = false)
                    where TSyntaxNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 79495, 80106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 79872, 80008);

                var
                actualOperationTree = f_21003_79898_80007<TSyntaxNode>(testSrc, compilationOptions, parseOptions, useLatestFrameworkReferences)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 80022, 80095);

                f_21003_80022_80094<TSyntaxNode>(expectedOperationTree, actualOperationTree);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 79495, 80106);

                string
                f_21003_79898_80007<TSyntaxNode>(string
                testSrc, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
                compilationOptions, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                parseOptions, bool
                useLatestFrameworkReferences) where TSyntaxNode : SyntaxNode

                {
                    var return_v = GetOperationTreeForTest<TSyntaxNode>(testSrc, compilationOptions, parseOptions, useLatestFrameworkReferences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 79898, 80007);
                    return return_v;
                }


                bool
                f_21003_80022_80094<TSyntaxNode>(string
                expectedOperationTree, string
                actualOperationTree) where TSyntaxNode : SyntaxNode

                {
                    var return_v = OperationTreeVerifier.Verify(expectedOperationTree, actualOperationTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 80022, 80094);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 79495, 80106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 79495, 80106);
            }
        }

        protected static void VerifyOperationTreeAndDiagnosticsForTest<TSyntaxNode>(
                    CSharpCompilation compilation,
                    string expectedOperationTree,
                    DiagnosticDescription[] expectedDiagnostics,
                    Action<IOperation, Compilation, SyntaxNode> additionalOperationTreeVerifier = null)
                    where TSyntaxNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 80118, 80804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 80505, 80610);

                var
                actualDiagnostics = f_21003_80529_80557<TSyntaxNode>(compilation).Where(d => d.Severity != DiagnosticSeverity.Hidden)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 80624, 80670);

                f_21003_80624_80669<TSyntaxNode>(actualDiagnostics, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 80684, 80793);

                f_21003_80684_80792<TSyntaxNode>(compilation, expectedOperationTree, additionalOperationTreeVerifier);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 80118, 80804);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_21003_80529_80557<TSyntaxNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param) where TSyntaxNode : SyntaxNode

                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 80529, 80557);
                    return return_v;
                }


                int
                f_21003_80624_80669<TSyntaxNode>(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                actual, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected) where TSyntaxNode : SyntaxNode

                {
                    actual.Verify(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 80624, 80669);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_21003_80684_80792<TSyntaxNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedOperationTree, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>?
                additionalOperationTreeVerifier) where TSyntaxNode : SyntaxNode

                {
                    var return_v = VerifyOperationTreeForTest<TSyntaxNode>(compilation, expectedOperationTree, additionalOperationTreeVerifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 80684, 80792);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 80118, 80804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 80118, 80804);
            }
        }

        protected static bool VerifyOperationTreeAndDiagnosticsForTest_B<TSyntaxNode>(
                    CSharpCompilation compilation,
                    string expectedOperationTree,
                    DiagnosticDescription[] expectedDiagnostics,
                    Action<IOperation, Compilation, SyntaxNode> additionalOperationTreeVerifier = null)
                    where TSyntaxNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 80816, 81513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 81205, 81310);

                var
                actualDiagnostics = f_21003_81229_81257<TSyntaxNode>(compilation).Where(d => d.Severity != DiagnosticSeverity.Hidden)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 81324, 81370);

                f_21003_81324_81369<TSyntaxNode>(actualDiagnostics, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 81384, 81502);

                return f_21003_81391_81501<TSyntaxNode>(compilation, expectedOperationTree, additionalOperationTreeVerifier);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 80816, 81513);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_21003_81229_81257<TSyntaxNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param) where TSyntaxNode : SyntaxNode

                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 81229, 81257);
                    return return_v;
                }


                int
                f_21003_81324_81369<TSyntaxNode>(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                actual, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected) where TSyntaxNode : SyntaxNode

                {
                    actual.Verify(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 81324, 81369);
                    return 0;
                }


                bool
                f_21003_81391_81501<TSyntaxNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedOperationTree, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>?
                additionalOperationTreeVerifier) where TSyntaxNode : SyntaxNode

                {
                    var return_v = VerifyOperationTreeForTest_B<TSyntaxNode>(compilation, expectedOperationTree, additionalOperationTreeVerifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 81391, 81501);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 80816, 81513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 80816, 81513);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static void VerifyFlowGraphAndDiagnosticsForTest<TSyntaxNode>(
                    CSharpCompilation compilation,
                    string expectedFlowGraph,
                    DiagnosticDescription[] expectedDiagnostics)
                    where TSyntaxNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 81525, 82065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 81807, 81912);

                var
                actualDiagnostics = f_21003_81831_81859<TSyntaxNode>(compilation).Where(d => d.Severity != DiagnosticSeverity.Hidden)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 81926, 81972);

                f_21003_81926_81971<TSyntaxNode>(actualDiagnostics, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 81986, 82054);

                f_21003_81986_82053<TSyntaxNode>(compilation, expectedFlowGraph);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 81525, 82065);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_21003_81831_81859<TSyntaxNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param) where TSyntaxNode : SyntaxNode

                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 81831, 81859);
                    return return_v;
                }


                int
                f_21003_81926_81971<TSyntaxNode>(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                actual, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected) where TSyntaxNode : SyntaxNode

                {
                    actual.Verify(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 81926, 81971);
                    return 0;
                }


                int
                f_21003_81986_82053<TSyntaxNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedFlowGraph) where TSyntaxNode : SyntaxNode

                {
                    VerifyFlowGraphForTest<TSyntaxNode>(compilation, expectedFlowGraph);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 81986, 82053);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 81525, 82065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 81525, 82065);
            }
        }

        protected static void VerifyOperationTreeAndDiagnosticsForTest<TSyntaxNode>(
                    string testSrc,
                    string expectedOperationTree,
                    DiagnosticDescription[] expectedDiagnostics,
                    CSharpCompilationOptions compilationOptions = null,
                    CSharpParseOptions parseOptions = null,
                    MetadataReference[] references = null,
                    Action<IOperation, Compilation, SyntaxNode> additionalOperationTreeVerifier = null,
                    bool useLatestFrameworkReferences = false)
                    where TSyntaxNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 82651, 83083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 82667, 83083);
                f_21003_82667_83083<TSyntaxNode>(testSrc, expectedOperationTree, (DynAbs.Tracing.TraceSender.Conditional_F1(21003, 82805, 82833) || ((useLatestFrameworkReferences && DynAbs.Tracing.TraceSender.Conditional_F2(21003, 82836, 82870)) || DynAbs.Tracing.TraceSender.Conditional_F3(21003, 82873, 82897))) ? TargetFramework.Mscorlib46Extended : TargetFramework.Standard, expectedDiagnostics, compilationOptions, parseOptions, references, additionalOperationTreeVerifier); DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 82651, 83083);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 82651, 83083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 82651, 83083);
            }
        }

        protected static bool VerifyOperationTreeAndDiagnosticsForTest_B<TSyntaxNode>(
                    string testSrc,
                    string expectedOperationTree,
                    DiagnosticDescription[] expectedDiagnostics,
                    CSharpCompilationOptions compilationOptions = null,
                    CSharpParseOptions parseOptions = null,
                    MetadataReference[] references = null,
                    Action<IOperation, Compilation, SyntaxNode> additionalOperationTreeVerifier = null,
                    bool useLatestFrameworkReferences = false)
                    where TSyntaxNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 83672, 84106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 83688, 84106);
                return f_21003_83688_84106<TSyntaxNode>(testSrc, expectedOperationTree, (DynAbs.Tracing.TraceSender.Conditional_F1(21003, 83828, 83856) || ((useLatestFrameworkReferences && DynAbs.Tracing.TraceSender.Conditional_F2(21003, 83859, 83893)) || DynAbs.Tracing.TraceSender.Conditional_F3(21003, 83896, 83920))) ? TargetFramework.Mscorlib46Extended : TargetFramework.Standard, expectedDiagnostics, compilationOptions, parseOptions, references, additionalOperationTreeVerifier); DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 83672, 84106);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 83672, 84106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 83672, 84106);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static void VerifyOperationTreeAndDiagnosticsForTest<TSyntaxNode>(
                    string testSrc,
                    string expectedOperationTree,
                    TargetFramework targetFramework,
                    DiagnosticDescription[] expectedDiagnostics,
                    CSharpCompilationOptions compilationOptions = null,
                    CSharpParseOptions parseOptions = null,
                    MetadataReference[] references = null,
                    Action<IOperation, Compilation, SyntaxNode> additionalOperationTreeVerifier = null)
                    where TSyntaxNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 84119, 85152);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 84707, 84983);

                var
                compilation = f_21003_84725_84982<TSyntaxNode>(new[] { f_21003_84769_84827<TSyntaxNode>(testSrc, filename: "file.cs", options: parseOptions) }, references, options: compilationOptions ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?>(21003, 84886, 84930) ?? TestOptions.ReleaseDll), targetFramework: targetFramework)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 84997, 85141);

                f_21003_84997_85140<TSyntaxNode>(compilation, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 84119, 85152);

                Microsoft.CodeAnalysis.SyntaxTree
                f_21003_84769_84827<TSyntaxNode>(string
                text, string
                filename, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                options) where TSyntaxNode : SyntaxNode

                {
                    var return_v = Parse(text, filename: filename, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 84769, 84827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_84725_84982<TSyntaxNode>(Microsoft.CodeAnalysis.SyntaxTree[]
                source, Microsoft.CodeAnalysis.MetadataReference[]?
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Roslyn.Test.Utilities.TargetFramework
                targetFramework) where TSyntaxNode : SyntaxNode

                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?)references, options: options, targetFramework: targetFramework);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 84725, 84982);
                    return return_v;
                }


                int
                f_21003_84997_85140<TSyntaxNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>?
                additionalOperationTreeVerifier) where TSyntaxNode : SyntaxNode

                {
                    VerifyOperationTreeAndDiagnosticsForTest<TSyntaxNode>(compilation, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 84997, 85140);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 84119, 85152);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 84119, 85152);
            }
        }

        protected static bool VerifyOperationTreeAndDiagnosticsForTest_B<TSyntaxNode>(
                    string testSrc,
                    string expectedOperationTree,
                    TargetFramework targetFramework,
                    DiagnosticDescription[] expectedDiagnostics,
                    CSharpCompilationOptions compilationOptions = null,
                    CSharpParseOptions parseOptions = null,
                    MetadataReference[] references = null,
                    Action<IOperation, Compilation, SyntaxNode> additionalOperationTreeVerifier = null)
                    where TSyntaxNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 85164, 86208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 85754, 86030);

                var
                compilation = f_21003_85772_86029<TSyntaxNode>(new[] { f_21003_85816_85874<TSyntaxNode>(testSrc, filename: "file.cs", options: parseOptions) }, references, options: compilationOptions ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?>(21003, 85933, 85977) ?? TestOptions.ReleaseDll), targetFramework: targetFramework)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 86044, 86197);

                return f_21003_86051_86196<TSyntaxNode>(compilation, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 85164, 86208);

                Microsoft.CodeAnalysis.SyntaxTree
                f_21003_85816_85874<TSyntaxNode>(string
                text, string
                filename, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                options) where TSyntaxNode : SyntaxNode

                {
                    var return_v = Parse(text, filename: filename, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 85816, 85874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_85772_86029<TSyntaxNode>(Microsoft.CodeAnalysis.SyntaxTree[]
                source, Microsoft.CodeAnalysis.MetadataReference[]?
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Roslyn.Test.Utilities.TargetFramework
                targetFramework) where TSyntaxNode : SyntaxNode

                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?)references, options: options, targetFramework: targetFramework);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 85772, 86029);
                    return return_v;
                }


                bool
                f_21003_86051_86196<TSyntaxNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>?
                additionalOperationTreeVerifier) where TSyntaxNode : SyntaxNode

                {
                    var return_v = VerifyOperationTreeAndDiagnosticsForTest_B<TSyntaxNode>(compilation, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 86051, 86196);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 85164, 86208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 85164, 86208);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static void VerifyOperationTreeAndDiagnosticsForTest<TSyntaxNode>(
                    SyntaxTree[] testSyntaxes,
                    string expectedOperationTree,
                    DiagnosticDescription[] expectedDiagnostics,
                    CSharpCompilationOptions compilationOptions = null,
                    MetadataReference[] references = null,
                    Action<IOperation, Compilation, SyntaxNode> additionalOperationTreeVerifier = null,
                    bool useLatestFrameworkReferences = false)
                    where TSyntaxNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 86220, 87242);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 86776, 87073);

                var
                compilation = f_21003_86794_87072<TSyntaxNode>(testSyntaxes, references, options: compilationOptions ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?>(21003, 86899, 86943) ?? TestOptions.ReleaseDll), targetFramework: (DynAbs.Tracing.TraceSender.Conditional_F1(21003, 86979, 87007) || ((useLatestFrameworkReferences && DynAbs.Tracing.TraceSender.Conditional_F2(21003, 87010, 87044)) || DynAbs.Tracing.TraceSender.Conditional_F3(21003, 87047, 87071))) ? TargetFramework.Mscorlib46Extended : TargetFramework.Standard)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 87087, 87231);

                f_21003_87087_87230<TSyntaxNode>(compilation, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 86220, 87242);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_86794_87072<TSyntaxNode>(Microsoft.CodeAnalysis.SyntaxTree[]
                source, Microsoft.CodeAnalysis.MetadataReference[]?
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Roslyn.Test.Utilities.TargetFramework
                targetFramework) where TSyntaxNode : SyntaxNode

                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?)references, options: options, targetFramework: targetFramework);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 86794, 87072);
                    return return_v;
                }


                int
                f_21003_87087_87230<TSyntaxNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>?
                additionalOperationTreeVerifier) where TSyntaxNode : SyntaxNode

                {
                    VerifyOperationTreeAndDiagnosticsForTest<TSyntaxNode>(compilation, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 87087, 87230);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 86220, 87242);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 86220, 87242);
            }
        }

        protected static void VerifyFlowGraphAndDiagnosticsForTest<TSyntaxNode>(
                    string testSrc,
                    string expectedFlowGraph,
                    DiagnosticDescription[] expectedDiagnostics,
                    CSharpCompilationOptions compilationOptions = null,
                    CSharpParseOptions parseOptions = null,
                    MetadataReference[] references = null,
                    bool useLatestFrameworkReferences = false)
                    where TSyntaxNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 87254, 88134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 87747, 88123);

                f_21003_87747_88122<TSyntaxNode>(testSrc, expectedFlowGraph, expectedDiagnostics, targetFramework: (DynAbs.Tracing.TraceSender.Conditional_F1(21003, 87932, 87960) || ((useLatestFrameworkReferences && DynAbs.Tracing.TraceSender.Conditional_F2(21003, 87963, 87997)) || DynAbs.Tracing.TraceSender.Conditional_F3(21003, 88000, 88024))) ? TargetFramework.Mscorlib46Extended : TargetFramework.Standard, compilationOptions, parseOptions, references);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 87254, 88134);

                int
                f_21003_87747_88122<TSyntaxNode>(string
                testSrc, string
                expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expectedDiagnostics, Roslyn.Test.Utilities.TargetFramework
                targetFramework, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
                compilationOptions, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                parseOptions, Microsoft.CodeAnalysis.MetadataReference[]?
                references) where TSyntaxNode : SyntaxNode

                {
                    VerifyFlowGraphAndDiagnosticsForTest<TSyntaxNode>(testSrc, expectedFlowGraph, expectedDiagnostics, targetFramework: targetFramework, compilationOptions, parseOptions, references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 87747, 88122);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 87254, 88134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 87254, 88134);
            }
        }

        protected static void VerifyFlowGraphAndDiagnosticsForTest<TSyntaxNode>(
                    string testSrc,
                    string expectedFlowGraph,
                    DiagnosticDescription[] expectedDiagnostics,
                    TargetFramework targetFramework,
                    CSharpCompilationOptions compilationOptions = null,
                    CSharpParseOptions parseOptions = null,
                    MetadataReference[] references = null)
                    where TSyntaxNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 88146, 89033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 88629, 88905);

                var
                compilation = f_21003_88647_88904<TSyntaxNode>(new[] { f_21003_88691_88749<TSyntaxNode>(testSrc, filename: "file.cs", options: parseOptions) }, references, options: compilationOptions ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?>(21003, 88808, 88852) ?? TestOptions.ReleaseDll), targetFramework: targetFramework)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 88919, 89022);

                f_21003_88919_89021<TSyntaxNode>(compilation, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 88146, 89033);

                Microsoft.CodeAnalysis.SyntaxTree
                f_21003_88691_88749<TSyntaxNode>(string
                text, string
                filename, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                options) where TSyntaxNode : SyntaxNode

                {
                    var return_v = Parse(text, filename: filename, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 88691, 88749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_88647_88904<TSyntaxNode>(Microsoft.CodeAnalysis.SyntaxTree[]
                source, Microsoft.CodeAnalysis.MetadataReference[]?
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Roslyn.Test.Utilities.TargetFramework
                targetFramework) where TSyntaxNode : SyntaxNode

                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?)references, options: options, targetFramework: targetFramework);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 88647, 88904);
                    return return_v;
                }


                int
                f_21003_88919_89021<TSyntaxNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expectedDiagnostics) where TSyntaxNode : SyntaxNode

                {
                    VerifyFlowGraphAndDiagnosticsForTest<TSyntaxNode>(compilation, expectedFlowGraph, expectedDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 88919, 89021);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 88146, 89033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 88146, 89033);
            }
        }

        protected static MetadataReference VerifyOperationTreeAndDiagnosticsForTestWithIL<TSyntaxNode>(string testSrc,
                    string ilSource,
                    string expectedOperationTree,
                    DiagnosticDescription[] expectedDiagnostics,
                    CSharpCompilationOptions compilationOptions = null,
                    CSharpParseOptions parseOptions = null,
                    MetadataReference[] references = null,
                    Action<IOperation, Compilation, SyntaxNode> additionalOperationTreeVerifier = null,
                    bool useLatestFrameworkReferences = false)
                    where TSyntaxNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 89045, 90027);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 89678, 89742);

                var
                ilReference = f_21003_89696_89741<TSyntaxNode>(ilSource)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 89756, 89983);

                f_21003_89756_89982<TSyntaxNode>(testSrc, expectedOperationTree, expectedDiagnostics, compilationOptions, parseOptions, new[] { ilReference }, additionalOperationTreeVerifier, useLatestFrameworkReferences);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 89997, 90016);

                return ilReference;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 89045, 90027);

                Microsoft.CodeAnalysis.MetadataReference
                f_21003_89696_89741<TSyntaxNode>(string
                ilSource) where TSyntaxNode : SyntaxNode

                {
                    var return_v = CreateMetadataReferenceFromIlSource(ilSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 89696, 89741);
                    return return_v;
                }


                int
                f_21003_89756_89982<TSyntaxNode>(string
                testSrc, string
                expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expectedDiagnostics, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
                compilationOptions, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                parseOptions, Microsoft.CodeAnalysis.MetadataReference[]
                references, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>?
                additionalOperationTreeVerifier, bool
                useLatestFrameworkReferences) where TSyntaxNode : SyntaxNode

                {
                    VerifyOperationTreeAndDiagnosticsForTest<TSyntaxNode>(testSrc, expectedOperationTree, expectedDiagnostics, compilationOptions, parseOptions, references, additionalOperationTreeVerifier, useLatestFrameworkReferences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 89756, 89982);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 89045, 90027);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 89045, 90027);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static CSharpCompilation CreateCompilationWithSpan(SyntaxTree tree, CSharpCompilationOptions options = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 90085, 90610);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 90228, 90348);

                var
                reference = f_21003_90244_90347(SpanSource, options: TestOptions.UnsafeReleaseDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 90364, 90394);

                f_21003_90364_90393(
                            reference);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 90410, 90571);

                var
                comp = f_21003_90421_90570(tree, references: new[] { f_21003_90500_90532(reference) }, options: options)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 90587, 90599);

                return comp;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 90085, 90610);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_90244_90347(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 90244, 90347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_90364_90393(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 90364, 90393);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_21003_90500_90532(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 90500, 90532);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_90421_90570(Microsoft.CodeAnalysis.SyntaxTree
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 90421, 90570);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 90085, 90610);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 90085, 90610);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static CSharpCompilation CreateCompilationWithSpan(string s, CSharpCompilationOptions options = null, CSharpParseOptions parseOptions = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21003, 90787, 90881);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 90790, 90881);
                return f_21003_90790_90881(f_21003_90816_90871(s, options: parseOptions), options); DynAbs.Tracing.TraceSender.TraceExitMethod(21003, 90787, 90881);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 90787, 90881);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 90787, 90881);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static CSharpCompilation CreateCompilationWithMscorlibAndSpan(string text, CSharpCompilationOptions options = null, CSharpParseOptions parseOptions = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 90894, 91730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 91084, 91332);

                var
                reference = f_21003_91100_91331(SpanSource, references: new List<MetadataReference>() { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_21003_91214_91229(), 21003, 91182, 91274), f_21003_91231_91248(), f_21003_91250_91272() }, options: TestOptions.UnsafeReleaseDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 91348, 91378);

                f_21003_91348_91377(
                            reference);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 91394, 91689);

                var
                comp = f_21003_91405_91688(text, references: new List<MetadataReference>() { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_21003_91513_91528(), 21003, 91481, 91607), f_21003_91530_91547(), f_21003_91549_91571(), f_21003_91573_91605(reference) }, options: options, parseOptions: parseOptions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 91707, 91719);

                return comp;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 90894, 91730);

                Microsoft.CodeAnalysis.PortableExecutableReference
                f_21003_91214_91229()
                {
                    var return_v = Net451.mscorlib;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 91214, 91229);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_21003_91231_91248()
                {
                    var return_v = Net451.SystemCore;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 91231, 91248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_21003_91250_91272()
                {
                    var return_v = Net451.MicrosoftCSharp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 91250, 91272);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_91100_91331(string
                source, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateEmptyCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 91100, 91331);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_91348_91377(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 91348, 91377);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_21003_91513_91528()
                {
                    var return_v = Net451.mscorlib;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 91513, 91528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_21003_91530_91547()
                {
                    var return_v = Net451.SystemCore;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 91530, 91547);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_21003_91549_91571()
                {
                    var return_v = Net451.MicrosoftCSharp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 91549, 91571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_21003_91573_91605(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 91573, 91605);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_91405_91688(string
                source, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
                options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                parseOptions)
                {
                    var return_v = CreateEmptyCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options: options, parseOptions: parseOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 91405, 91688);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 90894, 91730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 90894, 91730);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static CSharpCompilation CreateCompilationWithMscorlibAndSpanSrc(string text, CSharpCompilationOptions options = null, CSharpParseOptions parseOptions = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 91742, 92336);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 91935, 91987);

                var
                textWitSpan = new string[] { text, SpanSource }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 92001, 92297);

                var
                comp = f_21003_92012_92296(textWitSpan, references: new List<MetadataReference>() { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_21003_92127_92155(), 21003, 92095, 92183), f_21003_92157_92170(), f_21003_92172_92181() }, options: options ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?>(21003, 92211, 92250) ?? TestOptions.UnsafeReleaseDll), parseOptions: parseOptions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 92313, 92325);

                return comp;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 91742, 92336);

                Microsoft.CodeAnalysis.MetadataReference
                f_21003_92127_92155()
                {
                    var return_v = MscorlibRef_v4_0_30316_17626;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 92127, 92155);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_21003_92157_92170()
                {
                    var return_v = SystemCoreRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 92157, 92170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_21003_92172_92181()
                {
                    var return_v = CSharpRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 92172, 92181);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_92012_92296(string[]
                source, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                parseOptions)
                {
                    var return_v = CreateEmptyCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options: options, parseOptions: parseOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 92012, 92296);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 91742, 92336);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 91742, 92336);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static readonly string SpanSource;

        protected static CSharpCompilation CreateCompilationWithIndex(CSharpTestSource text, CSharpCompilationOptions options = null, CSharpParseOptions parseOptions = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 99122, 99638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 99312, 99385);

                var
                reference = f_21003_99328_99384(f_21003_99328_99364(TestSources.Index))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 99401, 99627);

                return f_21003_99408_99626(text, references: new List<MetadataReference>() { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_21003_99511_99543(reference), 21003, 99479, 99545) }, options: options, parseOptions: parseOptions);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 99122, 99638);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_99328_99364(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 99328, 99364);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_99328_99384(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 99328, 99384);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_21003_99511_99543(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 99511, 99543);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_99408_99626(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
                source, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
                options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                parseOptions)
                {
                    var return_v = CreateCompilation(source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options: options, parseOptions: parseOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 99408, 99626);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 99122, 99638);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 99122, 99638);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static CSharpCompilation CreateCompilationWithIndexAndRange(CSharpTestSource text, CSharpCompilationOptions options = null, CSharpParseOptions parseOptions = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 99650, 100203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 99848, 99950);

                var
                reference = f_21003_99864_99949(f_21003_99864_99929(new[] { TestSources.Index, TestSources.Range }))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 99966, 100192);

                return f_21003_99973_100191(text, references: new List<MetadataReference>() { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_21003_100076_100108(reference), 21003, 100044, 100110) }, options: options, parseOptions: parseOptions);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 99650, 100203);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_99864_99929(string[]
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 99864, 99929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_99864_99949(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 99864, 99949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_21003_100076_100108(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 100076, 100108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_99973_100191(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
                source, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
                options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                parseOptions)
                {
                    var return_v = CreateCompilation(source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options: options, parseOptions: parseOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 99973, 100191);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 99650, 100203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 99650, 100203);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static CSharpCompilation CreateCompilationWithIndexAndRangeAndSpan(CSharpTestSource text, CSharpCompilationOptions options = null, CSharpParseOptions parseOptions = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 100215, 100832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 100420, 100579);

                var
                reference = f_21003_100436_100578(f_21003_100436_100558(new[] { TestSources.Index, TestSources.Range, TestSources.Span }, options: TestOptions.UnsafeReleaseDll))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 100595, 100821);

                return f_21003_100602_100820(text, references: new List<MetadataReference>() { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_21003_100705_100737(reference), 21003, 100673, 100739) }, options: options, parseOptions: parseOptions);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 100215, 100832);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_100436_100558(string[]
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 100436, 100558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_100436_100578(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 100436, 100578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_21003_100705_100737(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 100705, 100737);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_21003_100602_100820(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
                source, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
                options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                parseOptions)
                {
                    var return_v = CreateCompilation(source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options: options, parseOptions: parseOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 100602, 100820);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 100215, 100832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 100215, 100832);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<object[]> NonNullTypesTrueAndFalseDebugDll
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 100991, 101268);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 101027, 101253);

                    return new List<object[]>()
                {
                    DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => new object[] { f_21003_101110_101150(TestOptions.DebugDll)},21003,101034,101252),                    new object[] { f_21003_101190_101231(TestOptions.DebugDll)}
                };
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 100991, 101268);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    f_21003_101110_101150(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    options)
                    {
                        var return_v = WithNullableEnable(options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 101110, 101150);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    f_21003_101190_101231(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    options)
                    {
                        var return_v = WithNullableDisable(options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 101190, 101231);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 100898, 101279);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 100898, 101279);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static IEnumerable<object[]> NonNullTypesTrueAndFalseReleaseDll
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21003, 101386, 101667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 101422, 101652);

                    return new List<object[]>()
                {
                    DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => new object[] { f_21003_101505_101547(TestOptions.ReleaseDll)},21003,101429,101651),                    new object[] { f_21003_101587_101630(TestOptions.ReleaseDll)}
                };
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21003, 101386, 101667);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    f_21003_101505_101547(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    options)
                    {
                        var return_v = WithNullableEnable(options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 101505, 101547);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    f_21003_101587_101630(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    options)
                    {
                        var return_v = WithNullableDisable(options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 101587, 101630);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21003, 101291, 101678);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 101291, 101678);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected static readonly string s_IAsyncEnumerable;

        public CSharpTestBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(21003, 1215, 102298);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(21003, 1215, 102298);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 1215, 102298);
        }


        static CSharpTestBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21003, 1215, 102298);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 1308, 2835);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 2871, 3440);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 3476, 3915);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 4192, 4448);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 4484, 4746);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 4782, 5071);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 5107, 5397);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 5433, 5718);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 5754, 6038);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 6074, 6460);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 6496, 6920);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 6956, 7250);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 7286, 7557);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 7593, 7980);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 8016, 8155);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 8191, 8359);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 8395, 20279);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 20315, 20617);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 20653, 21473);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 51292, 51358);
            s_scriptRefs = f_21003_51307_51358(f_21003_51329_51357()); 
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 56524, 56550);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 56584, 56609);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 92381, 99056);
            SpanSource = @"
namespace System
    {
        public readonly ref struct Span<T>
        {
            private readonly T[] arr;

            public ref T this[int i] => ref arr[i];
            public override int GetHashCode() => 1;
            public int Length { get; }

            unsafe public Span(void* pointer, int length)
            {
                this.arr = Helpers.ToArray<T>(pointer, length);
                this.Length = length;
            }

            public Span(T[] arr)
            {
                this.arr = arr;
                this.Length = arr.Length;
            }

            public void CopyTo(Span<T> other) { }

            /// <summary>Gets an enumerator for this span.</summary>
            public Enumerator GetEnumerator() => new Enumerator(this);

            /// <summary>Enumerates the elements of a <see cref=""Span{T}""/>.</summary>
            public ref struct Enumerator
            {
                /// <summary>The span being enumerated.</summary>
                private readonly Span<T> _span;
                /// <summary>The next index to yield.</summary>
                private int _index;

                /// <summary>Initialize the enumerator.</summary>
                /// <param name=""span"">The span to enumerate.</param>
                internal Enumerator(Span<T> span)
                {
                    _span = span;
                    _index = -1;
                }

                /// <summary>Advances the enumerator to the next element of the span.</summary>
                public bool MoveNext()
                {
                    int index = _index + 1;
                    if (index < _span.Length)
                    {
                        _index = index;
                        return true;
                    }

                    return false;
                }

                /// <summary>Gets the element at the current position of the enumerator.</summary>
                public ref T Current
                {
                    get => ref _span[_index];
                }
            }

            public static implicit operator Span<T>(T[] array) => new Span<T>(array);
        }

        public readonly ref struct ReadOnlySpan<T>
        {
            private readonly T[] arr;

            public ref readonly T this[int i] => ref arr[i];
            public override int GetHashCode() => 2;
            public int Length { get; }

            unsafe public ReadOnlySpan(void* pointer, int length)
            {
                this.arr = Helpers.ToArray<T>(pointer, length);
                this.Length = length;
            }

            public ReadOnlySpan(T[] arr)
            {
                this.arr = arr;
                this.Length = arr.Length;
            }

            public void CopyTo(Span<T> other) { }

            /// <summary>Gets an enumerator for this span.</summary>
            public Enumerator GetEnumerator() => new Enumerator(this);

            /// <summary>Enumerates the elements of a <see cref=""Span{T}""/>.</summary>
            public ref struct Enumerator
            {
                /// <summary>The span being enumerated.</summary>
                private readonly ReadOnlySpan<T> _span;
                /// <summary>The next index to yield.</summary>
                private int _index;

                /// <summary>Initialize the enumerator.</summary>
                /// <param name=""span"">The span to enumerate.</param>
                internal Enumerator(ReadOnlySpan<T> span)
                {
                    _span = span;
                    _index = -1;
                }

                /// <summary>Advances the enumerator to the next element of the span.</summary>
                public bool MoveNext()
                {
                    int index = _index + 1;
                    if (index < _span.Length)
                    {
                        _index = index;
                        return true;
                    }

                    return false;
                }

                /// <summary>Gets the element at the current position of the enumerator.</summary>
                public ref readonly T Current
                {
                    get => ref _span[_index];
                }
            }

            public static implicit operator ReadOnlySpan<T>(T[] array) => array == null ? default : new ReadOnlySpan<T>(array);

            public static implicit operator ReadOnlySpan<T>(string stringValue) => string.IsNullOrEmpty(stringValue) ? default : new ReadOnlySpan<T>((T[])(object)stringValue.ToCharArray());
        }

        public readonly ref struct SpanLike<T>
        {
            public readonly Span<T> field;
        }

        public enum Color: sbyte
        {
            Red,
            Green,
            Blue
        }

        public static unsafe class Helpers
        {
            public static T[] ToArray<T>(void* ptr, int count)
            {
                if (ptr == null)
                {
                    return null;
                }

                if (typeof(T) == typeof(int))
                {
                    var arr = new int[count];
                    for(int i = 0; i < count; i++)
                    {
                        arr[i] = ((int*)ptr)[i];
                    }

                    return (T[])(object)arr;
                }

                if (typeof(T) == typeof(byte))
                {
                    var arr = new byte[count];
                    for(int i = 0; i < count; i++)
                    {
                        arr[i] = ((byte*)ptr)[i];
                    }

                    return (T[])(object)arr;
                }

                if (typeof(T) == typeof(char))
                {
                    var arr = new char[count];
                    for(int i = 0; i < count; i++)
                    {
                        arr[i] = ((char*)ptr)[i];
                    }

                    return (T[])(object)arr;
                }

                if (typeof(T) == typeof(Color))
                {
                    var arr = new Color[count];
                    for(int i = 0; i < count; i++)
                    {
                        arr[i] = ((Color*)ptr)[i];
                    }

                    return (T[])(object)arr;
                }

                throw new Exception(""add a case for: "" + typeof(T));
            }
        }
    }"; DynAbs.Tracing.TraceSender.TraceSimpleStatement(21003, 101743, 102290);
            s_IAsyncEnumerable = @"
namespace System.Collections.Generic
{
    public interface IAsyncEnumerable<out T>
    {
        IAsyncEnumerator<T> GetAsyncEnumerator(System.Threading.CancellationToken token = default);
    }

    public interface IAsyncEnumerator<out T> : System.IAsyncDisposable
    {
        System.Threading.Tasks.ValueTask<bool> MoveNextAsync();
        T Current { get; }
    }
}
namespace System
{
    public interface IAsyncDisposable
    {
        System.Threading.Tasks.ValueTask DisposeAsync();
    }
}
"; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21003, 1215, 102298);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21003, 1215, 102298);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(21003, 1215, 102298);

        Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
        f_21003_23264_23799(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestBase
        this_param, Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
        source, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
        references, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>?
        manifestResources, System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.ModuleData>?
        dependencies, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>?
        sourceSymbolValidator, System.Action<Microsoft.CodeAnalysis.PEAssembly>?
        assemblyValidator, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>?
        symbolValidator, Microsoft.CodeAnalysis.Test.Utilities.SignatureDescription[]?
        expectedSignatures, string?
        expectedOutput, int?
        expectedReturnCode, string[]?
        args, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
        options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
        parseOptions, Microsoft.CodeAnalysis.Emit.EmitOptions?
        emitOptions, Roslyn.Test.Utilities.TargetFramework
        targetFramework, Microsoft.CodeAnalysis.Test.Utilities.Verification
        verify)
        {
            var return_v = this_param.CompileAndVerify(source, references, manifestResources, dependencies, sourceSymbolValidator, assemblyValidator, symbolValidator, expectedSignatures, expectedOutput, expectedReturnCode, args, options, parseOptions, emitOptions, targetFramework, verify);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 23264, 23799);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
        f_21003_24694_25229(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestBase
        this_param, Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
        source, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
        references, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>?
        manifestResources, System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.ModuleData>?
        dependencies, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>?
        sourceSymbolValidator, System.Action<Microsoft.CodeAnalysis.PEAssembly>?
        assemblyValidator, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>?
        symbolValidator, Microsoft.CodeAnalysis.Test.Utilities.SignatureDescription[]?
        expectedSignatures, string?
        expectedOutput, int?
        expectedReturnCode, string[]?
        args, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
        options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
        parseOptions, Microsoft.CodeAnalysis.Emit.EmitOptions?
        emitOptions, Roslyn.Test.Utilities.TargetFramework
        targetFramework, Microsoft.CodeAnalysis.Test.Utilities.Verification
        verify)
        {
            var return_v = this_param.CompileAndVerify(source, references, manifestResources, dependencies, sourceSymbolValidator, assemblyValidator, symbolValidator, expectedSignatures, expectedOutput, expectedReturnCode, args, options, parseOptions, emitOptions, targetFramework, verify);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 24694, 25229);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
        f_21003_27935_28465(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestBase
        this_param, Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
        source, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
        references, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>?
        manifestResources, System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.ModuleData>?
        dependencies, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>?
        sourceSymbolValidator, System.Action<Microsoft.CodeAnalysis.PEAssembly>?
        assemblyValidator, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>?
        symbolValidator, Microsoft.CodeAnalysis.Test.Utilities.SignatureDescription[]?
        expectedSignatures, string?
        expectedOutput, int?
        expectedReturnCode, string[]?
        args, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
        options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
        parseOptions, Microsoft.CodeAnalysis.Emit.EmitOptions?
        emitOptions, Roslyn.Test.Utilities.TargetFramework
        targetFramework, Microsoft.CodeAnalysis.Test.Utilities.Verification
        verify)
        {
            var return_v = this_param.CompileAndVerify(source, references, manifestResources, dependencies, sourceSymbolValidator, assemblyValidator, symbolValidator, expectedSignatures, expectedOutput, expectedReturnCode, args, options, parseOptions, emitOptions, targetFramework, verify);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 27935, 28465);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
        f_21003_29356_29898(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestBase
        this_param, Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
        source, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
        references, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>?
        manifestResources, System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.ModuleData>?
        dependencies, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>?
        sourceSymbolValidator, System.Action<Microsoft.CodeAnalysis.PEAssembly>?
        assemblyValidator, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>?
        symbolValidator, Microsoft.CodeAnalysis.Test.Utilities.SignatureDescription[]?
        expectedSignatures, string?
        expectedOutput, int?
        expectedReturnCode, string[]?
        args, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
        options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
        parseOptions, Microsoft.CodeAnalysis.Emit.EmitOptions?
        emitOptions, Roslyn.Test.Utilities.TargetFramework
        targetFramework, Microsoft.CodeAnalysis.Test.Utilities.Verification
        verify)
        {
            var return_v = this_param.CompileAndVerify(source, references, manifestResources, dependencies, sourceSymbolValidator, assemblyValidator, symbolValidator, expectedSignatures, expectedOutput, expectedReturnCode, args, options, parseOptions, emitOptions, targetFramework, verify);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 29356, 29898);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
        f_21003_33277_33616(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestBase
        this_param, Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
        source, System.Func<string, Microsoft.CodeAnalysis.PEAssembly, byte[]>
        getExpectedBlob, bool
        isField)
        {
            var return_v = this_param.CompileAndVerifyFieldMarshal(source, getExpectedBlob, isField);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 33277, 33616);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21003_33852_33933(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
        source, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        parseOptions)
        {
            var return_v = CreateCompilationWithMscorlib40(source, parseOptions: parseOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 33852, 33933);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
        f_21003_33799_33994(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestBase
        this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, System.Func<string, Microsoft.CodeAnalysis.PEAssembly, byte[]>
        getExpectedBlob, bool
        isField)
        {
            var return_v = this_param.CompileAndVerifyFieldMarshalCommon((Microsoft.CodeAnalysis.Compilation)compilation, getExpectedBlob, isField);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 33799, 33994);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21003_36431_36558(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
        source, string
        ilSource, Roslyn.Test.Utilities.TargetFramework
        targetFramework, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
        references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
        options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
        parseOptions, bool
        appendDefaultHeader)
        {
            var return_v = CreateCompilationWithILAndMscorlib40(source, ilSource, targetFramework, references, options, parseOptions, appendDefaultHeader);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 36431, 36558);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21003_37680_37798(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
        source, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
        references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
        options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
        parseOptions, Roslyn.Test.Utilities.TargetFramework
        targetFramework, string
        assemblyName, string
        sourceFileName)
        {
            var return_v = CreateCompilation(source, references, options, parseOptions, targetFramework, assemblyName, sourceFileName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 37680, 37798);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21003_38213_38351(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
        source, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
        references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
        options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
        parseOptions, Roslyn.Test.Utilities.TargetFramework
        targetFramework, string
        assemblyName, string
        sourceFileName, bool
        skipUsesIsNullable)
        {
            var return_v = CreateCompilation(source, references, options, parseOptions, targetFramework, assemblyName, sourceFileName, skipUsesIsNullable);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 38213, 38351);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21003_38758_38896(string[]
        source, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
        references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
        options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
        parseOptions, Roslyn.Test.Utilities.TargetFramework
        targetFramework, string
        assemblyName, string
        sourceFileName, bool
        skipUsesIsNullable)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references, options, parseOptions, targetFramework, assemblyName, sourceFileName, skipUsesIsNullable);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 38758, 38896);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21003_39265_39383(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
        source, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
        references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
        options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
        parseOptions, Roslyn.Test.Utilities.TargetFramework
        targetFramework, string
        assemblyName, string
        sourceFileName)
        {
            var return_v = CreateCompilation(source, references, options, parseOptions, targetFramework, assemblyName, sourceFileName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 39265, 39383);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_21003_39874_39947(Roslyn.Test.Utilities.TargetFramework
        tf, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
        additionalReferences)
        {
            var return_v = TargetFrameworkUtil.GetReferences(tf, additionalReferences);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 39874, 39947);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21003_39844_40051(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
        source, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
        options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
        parseOptions, string
        assemblyName, string
        sourceFileName, bool
        skipUsesIsNullable, Microsoft.CodeAnalysis.CSharp.MessageID
        experimentalFeature)
        {
            var return_v = CreateCompilationCore(source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options, parseOptions, assemblyName, sourceFileName, skipUsesIsNullable, experimentalFeature: (Microsoft.CodeAnalysis.CSharp.MessageID?)experimentalFeature);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 39844, 40051);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21003_40415_40528(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
        source, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
        references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
        options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
        parseOptions, Roslyn.Test.Utilities.TargetFramework
        targetFramework, string
        assemblyName, string
        sourceFileName)
        {
            var return_v = CreateCompilation(source, references, options, parseOptions, targetFramework, assemblyName, sourceFileName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 40415, 40528);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21003_40906_41033(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
        source, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
        references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
        options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
        parseOptions, Roslyn.Test.Utilities.TargetFramework
        targetFramework, string
        assemblyName, string
        sourceFileName)
        {
            var return_v = CreateCompilation(source, references, options, parseOptions, targetFramework, assemblyName, sourceFileName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 40906, 41033);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21003_41415_41546(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
        source, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
        references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
        options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
        parseOptions, Roslyn.Test.Utilities.TargetFramework
        targetFramework, string
        assemblyName, string
        sourceFileName)
        {
            var return_v = CreateCompilation(source, references, options, parseOptions, targetFramework, assemblyName, sourceFileName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 41415, 41546);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21003_41920_42051(string[]
        source, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
        references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
        options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
        parseOptions, Roslyn.Test.Utilities.TargetFramework
        targetFramework, string
        assemblyName, string
        sourceFileName)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references, options, parseOptions, targetFramework, assemblyName, sourceFileName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 41920, 42051);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21003_42416_42541(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
        source, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
        references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
        options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
        parseOptions, Roslyn.Test.Utilities.TargetFramework
        targetFramework, string
        assemblyName, string
        sourceFileName)
        {
            var return_v = CreateCompilation(source, references, options, parseOptions, targetFramework, assemblyName, sourceFileName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 42416, 42541);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_21003_45164_45226(Roslyn.Test.Utilities.TargetFramework
        tf, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
        additionalReferences)
        {
            var return_v = TargetFrameworkUtil.GetReferences(tf, additionalReferences);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 45164, 45226);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21003_45133_45300(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
        source, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
        options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
        parseOptions, string
        assemblyName, string
        sourceFileName, bool
        skipUsesIsNullable)
        {
            var return_v = CreateEmptyCompilation(source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options, parseOptions, assemblyName, sourceFileName, skipUsesIsNullable);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 45133, 45300);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21003_45706_45847(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource
        source, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
        references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
        options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
        parseOptions, string
        assemblyName, string
        sourceFileName, bool
        skipUsesIsNullable, Microsoft.CodeAnalysis.CSharp.MessageID?
        experimentalFeature)
        {
            var return_v = CreateCompilationCore(source, references, options, parseOptions, assemblyName, sourceFileName, skipUsesIsNullable, experimentalFeature: experimentalFeature);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 45706, 45847);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_21003_51329_51357()
        {
            var return_v = MscorlibRef_v4_0_30316_17626;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21003, 51329, 51357);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
        f_21003_51307_51358(Microsoft.CodeAnalysis.MetadataReference
        item)
        {
            var return_v = ImmutableArray.Create(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 51307, 51358);
            return return_v;
        }


        static int
        f_21003_82667_83083<TSyntaxNode>(string
        testSrc, string
        expectedOperationTree, Roslyn.Test.Utilities.TargetFramework
        targetFramework, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
        compilationOptions, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
        parseOptions, Microsoft.CodeAnalysis.MetadataReference[]?
        references, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>?
        additionalOperationTreeVerifier) where TSyntaxNode : SyntaxNode
        {
            VerifyOperationTreeAndDiagnosticsForTest<TSyntaxNode>(testSrc, expectedOperationTree, targetFramework, expectedDiagnostics, compilationOptions, parseOptions, references, additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 82667, 83083);
            return 0;
        }


        static bool
        f_21003_83688_84106<TSyntaxNode>(string
        testSrc, string
        expectedOperationTree, Roslyn.Test.Utilities.TargetFramework
        targetFramework, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
        compilationOptions, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
        parseOptions, Microsoft.CodeAnalysis.MetadataReference[]?
        references, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>?
        additionalOperationTreeVerifier) where TSyntaxNode : SyntaxNode
        {
            var return_v = VerifyOperationTreeAndDiagnosticsForTest_B<TSyntaxNode>(testSrc, expectedOperationTree, targetFramework, expectedDiagnostics, compilationOptions, parseOptions, references, additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 83688, 84106);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree
        f_21003_90816_90871(string
        text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
        options)
        {
            var return_v = SyntaxFactory.ParseSyntaxTree(text, options: (Microsoft.CodeAnalysis.ParseOptions?)options);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 90816, 90871);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21003_90790_90881(Microsoft.CodeAnalysis.SyntaxTree
        tree, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
        options)
        {
            var return_v = CreateCompilationWithSpan(tree, options);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21003, 90790, 90881);
            return return_v;
        }

    }
}
