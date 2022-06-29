// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Roslyn.Utilities
{
    internal sealed class StringOrdinalComparer : IEqualityComparer<string>
    {
        public static readonly StringOrdinalComparer Instance;

        private StringOrdinalComparer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(386, 982, 1035);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(386, 982, 1035);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(386, 982, 1035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(386, 982, 1035);
            }
        }

        bool IEqualityComparer<string>.Equals(string? a, string? b)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(386, 1047, 1184);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(386, 1131, 1173);

                return f_386_1138_1172(a, b);
                DynAbs.Tracing.TraceSender.TraceExitMethod(386, 1047, 1184);

                bool
                f_386_1138_1172(string?
                a, string?
                b)
                {
                    var return_v = StringOrdinalComparer.Equals(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(386, 1138, 1172);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(386, 1047, 1184);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(386, 1047, 1184);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool Equals(string? a, string? b)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(386, 1196, 1342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(386, 1304, 1331);

                return f_386_1311_1330(a, b);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(386, 1196, 1342);

                bool
                f_386_1311_1330(string?
                a, string?
                b)
                {
                    var return_v = string.Equals(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(386, 1311, 1330);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(386, 1196, 1342);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(386, 1196, 1342);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int IEqualityComparer<string>.GetHashCode(string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(386, 1354, 1800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(386, 1759, 1789);

                return f_386_1766_1788(s);
                DynAbs.Tracing.TraceSender.TraceExitMethod(386, 1354, 1800);

                int
                f_386_1766_1788(string
                text)
                {
                    var return_v = Hash.GetFNVHashCode(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(386, 1766, 1788);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(386, 1354, 1800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(386, 1354, 1800);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static StringOrdinalComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(386, 798, 1807);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(386, 931, 969);
            Instance = f_386_942_969(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(386, 798, 1807);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(386, 798, 1807);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(386, 798, 1807);

        static Roslyn.Utilities.StringOrdinalComparer
        f_386_942_969()
        {
            var return_v = new Roslyn.Utilities.StringOrdinalComparer();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(386, 942, 969);
            return return_v;
        }

    }
}
