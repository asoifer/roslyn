// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// This was copied from https://github.com/dotnet/runtime/blob/39b9607807f29e48cae4652cd74735182b31182e/src/libraries/System.Private.CoreLib/src/System/Diagnostics/CodeAnalysis/NullableAttributes.cs
// and updated to have the scope of the attributes be internal.
namespace System.Diagnostics.CodeAnalysis
{
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

}
