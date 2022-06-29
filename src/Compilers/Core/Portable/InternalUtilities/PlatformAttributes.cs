// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable enable

#if !NET5_0

namespace System.Runtime.Versioning
{
    internal abstract class OSPlatformAttribute : Attribute
    {
        private protected OSPlatformAttribute(string platformName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(354, 459, 581);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(354, 593, 628);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(354, 542, 570);

                PlatformName = platformName;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(354, 459, 581);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(354, 459, 581);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(354, 459, 581);
            }
        }

        public string PlatformName { get; }

        static OSPlatformAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(354, 387, 635);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(354, 387, 635);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(354, 387, 635);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(354, 387, 635);
    }
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
    internal sealed class TargetPlatformAttribute : OSPlatformAttribute
    {
        public TargetPlatformAttribute(string platformName)
        : base(f_354_986_998_C(platformName))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(354, 914, 1021);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(354, 914, 1021);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(354, 914, 1021);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(354, 914, 1021);
            }
        }

        static TargetPlatformAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(354, 739, 1028);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(354, 739, 1028);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(354, 739, 1028);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(354, 739, 1028);

        static string
        f_354_986_998_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(354, 914, 1021);
            return return_v;
        }

    }
    [AttributeUsage(
            AttributeTargets.Assembly
            | AttributeTargets.Class
            | AttributeTargets.Constructor
            | AttributeTargets.Enum
            | AttributeTargets.Event
            | AttributeTargets.Field
            | AttributeTargets.Method
            | AttributeTargets.Module
            | AttributeTargets.Property
            | AttributeTargets.Struct,
            AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : OSPlatformAttribute
    {
        public SupportedOSPlatformAttribute(string platformName)
        : base(f_354_2130_2142_C(platformName))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(354, 2053, 2165);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(354, 2053, 2165);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(354, 2053, 2165);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(354, 2053, 2165);
            }
        }

        static SupportedOSPlatformAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(354, 1538, 2172);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(354, 1538, 2172);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(354, 1538, 2172);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(354, 1538, 2172);

        static string
        f_354_2130_2142_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(354, 2053, 2165);
            return return_v;
        }

    }
    [AttributeUsage(
            AttributeTargets.Assembly
            | AttributeTargets.Class
            | AttributeTargets.Constructor
            | AttributeTargets.Enum
            | AttributeTargets.Event
            | AttributeTargets.Field
            | AttributeTargets.Method
            | AttributeTargets.Module
            | AttributeTargets.Property
            | AttributeTargets.Struct,
            AllowMultiple = true, Inherited = false)]
    internal sealed class UnsupportedOSPlatformAttribute : OSPlatformAttribute
    {
        public UnsupportedOSPlatformAttribute(string platformName)
        : base(f_354_3039_3051_C(platformName))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(354, 2960, 3074);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(354, 2960, 3074);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(354, 2960, 3074);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(354, 2960, 3074);
            }
        }

        static UnsupportedOSPlatformAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(354, 2443, 3081);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(354, 2443, 3081);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(354, 2443, 3081);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(354, 2443, 3081);

        static string
        f_354_3039_3051_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(354, 2960, 3074);
            return return_v;
        }

    }
}

#endif
