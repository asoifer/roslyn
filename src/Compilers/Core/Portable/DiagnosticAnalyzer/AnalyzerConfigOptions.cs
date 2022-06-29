// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    public abstract class AnalyzerConfigOptions
    {
        public static StringComparer KeyComparer { get; }

        internal static ImmutableDictionary<string, string> EmptyDictionary;

        public abstract bool TryGetValue(string key, [NotNullWhen(true)] out string? value);

        public AnalyzerConfigOptions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(219, 355, 1125);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(219, 355, 1125);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(219, 355, 1125);
        }


        static AnalyzerConfigOptions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(219, 355, 1125);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(219, 642, 739);
            KeyComparer = f_219_694_738(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(219, 803, 876);
            EmptyDictionary = f_219_821_876(f_219_864_875()); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(219, 355, 1125);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(219, 355, 1125);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(219, 355, 1125);

        static System.StringComparer
        f_219_694_738()
        {
            var return_v = AnalyzerConfig.Section.PropertiesKeyComparer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(219, 694, 738);
            return return_v;
        }


        static System.StringComparer
        f_219_864_875()
        {
            var return_v = KeyComparer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(219, 864, 875);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableDictionary<string, string>
        f_219_821_876(System.StringComparer
        keyComparer)
        {
            var return_v = ImmutableDictionary.Create<string, string>((System.Collections.Generic.IEqualityComparer<string>)keyComparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(219, 821, 876);
            return return_v;
        }

    }
    internal sealed class CompilerAnalyzerConfigOptions : AnalyzerConfigOptions
    {
        public static CompilerAnalyzerConfigOptions Empty { get; }

        private readonly ImmutableDictionary<string, string> _backing;

        public CompilerAnalyzerConfigOptions(ImmutableDictionary<string, string> properties)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(219, 1423, 1565);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(219, 1402, 1410);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(219, 1532, 1554);

                _backing = properties;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(219, 1423, 1565);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(219, 1423, 1565);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(219, 1423, 1565);
            }
        }

        public override bool TryGetValue(string key, [NotNullWhen(true)] out string? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(219, 1661, 1700);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(219, 1664, 1700);
                return f_219_1664_1700(_backing, key, out value); DynAbs.Tracing.TraceSender.TraceExitMethod(219, 1661, 1700);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(219, 1661, 1700);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(219, 1661, 1700);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_219_1664_1700(System.Collections.Immutable.ImmutableDictionary<string, string>
            this_param, string
            key, out string?
            value)
            {
                var return_v = this_param.TryGetValue(key, out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(219, 1664, 1700);
                return return_v;
            }

        }

        static CompilerAnalyzerConfigOptions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(219, 1133, 1708);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(219, 1225, 1337);
            Empty = f_219_1286_1336(EmptyDictionary); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(219, 1133, 1708);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(219, 1133, 1708);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(219, 1133, 1708);

        static Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions
        f_219_1286_1336(System.Collections.Immutable.ImmutableDictionary<string, string>
        properties)
        {
            var return_v = new Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions(properties);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(219, 1286, 1336);
            return return_v;
        }

    }
}
