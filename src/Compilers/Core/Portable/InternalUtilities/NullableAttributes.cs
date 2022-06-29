// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// This was copied from https://github.com/dotnet/runtime/blob/39b9607807f29e48cae4652cd74735182b31182e/src/libraries/System.Private.CoreLib/src/System/Diagnostics/CodeAnalysis/NullableAttributes.cs
// and updated to have the scope of the attributes be internal.
namespace System.Diagnostics.CodeAnalysis
{
#if !NETCOREAPP

    /// <summary>Specifies that null is allowed as an input even if the corresponding type disallows it.</summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property, Inherited = false)]
    internal sealed class AllowNullAttribute : Attribute { }

    /// <summary>Specifies that null is disallowed as an input even if the corresponding type allows it.</summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property, Inherited = false)]
    internal sealed class DisallowNullAttribute : Attribute { }

    /// <summary>Specifies that an output may be null even if the corresponding type disallows it.</summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.ReturnValue, Inherited = false)]
    internal sealed class MaybeNullAttribute : Attribute { }

    /// <summary>Specifies that an output will not be null even if the corresponding type allows it.</summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.ReturnValue, Inherited = false)]
    internal sealed class NotNullAttribute : Attribute { }

    /// <summary>Specifies that when a method returns <see cref="ReturnValue"/>, the parameter may be null even if the corresponding type disallows it.</summary>
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
    internal sealed class MaybeNullWhenAttribute : Attribute
    {
        /// <summary>Initializes the attribute with the specified return value condition.</summary>
        /// <param name="returnValue">
        /// The return value condition. If the method returns this value, the associated parameter may be null.
        /// </param>
        public MaybeNullWhenAttribute(bool returnValue) => ReturnValue = returnValue;

        /// <summary>Gets the return value condition.</summary>
        public bool ReturnValue { get; }
    }

    /// <summary>Specifies that when a method returns <see cref="ReturnValue"/>, the parameter will not be null even if the corresponding type allows it.</summary>
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
    internal sealed class NotNullWhenAttribute : Attribute
    {
        /// <summary>Initializes the attribute with the specified return value condition.</summary>
        /// <param name="returnValue">
        /// The return value condition. If the method returns this value, the associated parameter will not be null.
        /// </param>
        public NotNullWhenAttribute(bool returnValue) => ReturnValue = returnValue;

        /// <summary>Gets the return value condition.</summary>
        public bool ReturnValue { get; }
    }

    /// <summary>Specifies that the output will be non-null if the named parameter is non-null.</summary>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.ReturnValue, AllowMultiple = true, Inherited = false)]
    internal sealed class NotNullIfNotNullAttribute : Attribute
    {
        /// <summary>Initializes the attribute with the associated parameter name.</summary>
        /// <param name="parameterName">
        /// The associated parameter name.  The output will be non-null if the argument to the parameter specified is non-null.
        /// </param>
        public NotNullIfNotNullAttribute(string parameterName) => ParameterName = parameterName;

        /// <summary>Gets the associated parameter name.</summary>
        public string ParameterName { get; }
    }

    /// <summary>Applied to a method that will never return under any circumstance.</summary>
    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    internal sealed class DoesNotReturnAttribute : Attribute { }

    /// <summary>Specifies that the method will not return if the associated Boolean parameter is passed the specified value.</summary>
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
    internal sealed class DoesNotReturnIfAttribute : Attribute
    {
        /// <summary>Initializes the attribute with the specified parameter value.</summary>
        /// <param name="parameterValue">
        /// The condition parameter value. Code after the method will be considered unreachable by diagnostics if the argument to
        /// the associated parameter matches this value.
        /// </param>
        public DoesNotReturnIfAttribute(bool parameterValue) => ParameterValue = parameterValue;

        /// <summary>Gets the condition parameter value.</summary>
        public bool ParameterValue { get; }
    }

#endif

#if !NETCOREAPP || NETCOREAPP3_1

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    internal sealed class MemberNotNullAttribute : Attribute
    {
        public MemberNotNullAttribute(string member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(350, 5886, 5961);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(350, 6377, 6409);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(350, 5934, 5960);
                Members = new[] { member }; DynAbs.Tracing.TraceSender.TraceExitConstructor(350, 5886, 5961);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(350, 5886, 5961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(350, 5886, 5961);
            }
        }

        public MemberNotNullAttribute(params string[] members)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(350, 6220, 6296);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(350, 6377, 6409);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(350, 6278, 6295);
                Members = members; DynAbs.Tracing.TraceSender.TraceExitConstructor(350, 6220, 6296);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(350, 6220, 6296);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(350, 6220, 6296);
            }
        }

        public string[] Members { get; }

        static MemberNotNullAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(350, 5474, 6416);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(350, 5474, 6416);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(350, 5474, 6416);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(350, 5474, 6416);
    }
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    internal sealed class MemberNotNullWhenAttribute : Attribute
    {
        public MemberNotNullWhenAttribute(bool returnValue, string member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(350, 7261, 7430);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(350, 8153, 8185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(350, 8266, 8298);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(350, 7352, 7378);

                ReturnValue = returnValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(350, 7392, 7419);

                Members = new[] { member };
                DynAbs.Tracing.TraceSender.TraceExitConstructor(350, 7261, 7430);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(350, 7261, 7430);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(350, 7261, 7430);
            }
        }

        public MemberNotNullWhenAttribute(bool returnValue, params string[] members)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(350, 7906, 8076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(350, 8153, 8185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(350, 8266, 8298);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(350, 8007, 8033);

                ReturnValue = returnValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(350, 8047, 8065);

                Members = members;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(350, 7906, 8076);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(350, 7906, 8076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(350, 7906, 8076);
            }
        }

        public bool ReturnValue { get; }

        public string[] Members { get; }

        static MemberNotNullWhenAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(350, 6624, 8305);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(350, 6624, 8305);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(350, 6624, 8305);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(350, 6624, 8305);
    }
#endif
}
