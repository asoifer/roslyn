// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Roslyn.Utilities
{
    internal sealed class EmptyComparer : IEqualityComparer<object>
    {
        public static readonly EmptyComparer Instance;

        private EmptyComparer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(322, 664, 709);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(322, 664, 709);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(322, 664, 709);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(322, 664, 709);
            }
        }

        bool IEqualityComparer<object>.Equals(object? a, object? b)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(322, 721, 920);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(322, 805, 882);

                f_322_805_881(false, "Are we using empty comparer with nonempty dictionary?");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(322, 896, 909);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(322, 721, 920);

                int
                f_322_805_881(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(322, 805, 881);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(322, 721, 920);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(322, 721, 920);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int IEqualityComparer<object>.GetHashCode(object s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(322, 932, 1076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(322, 1056, 1065);

                return 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(322, 932, 1076);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(322, 932, 1076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(322, 932, 1076);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EmptyComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(322, 504, 1083);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(322, 621, 651);
            Instance = f_322_632_651(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(322, 504, 1083);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(322, 504, 1083);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(322, 504, 1083);

        static Roslyn.Utilities.EmptyComparer
        f_322_632_651()
        {
            var return_v = new Roslyn.Utilities.EmptyComparer();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(322, 632, 651);
            return return_v;
        }

    }
}
