// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CodeGen
{

    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    internal struct ClosureDebugInfo : IEquatable<ClosureDebugInfo>
    {

        public readonly int SyntaxOffset;

        public readonly DebugId ClosureId;

        public ClosureDebugInfo(int syntaxOffset, DebugId closureId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(50, 548, 708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(50, 633, 661);

                SyntaxOffset = syntaxOffset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(50, 675, 697);

                ClosureId = closureId;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(50, 548, 708);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(50, 548, 708);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(50, 548, 708);
            }
        }

        public bool Equals(ClosureDebugInfo other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(50, 720, 897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(50, 787, 886);

                return SyntaxOffset == other.SyntaxOffset && (DynAbs.Tracing.TraceSender.Expression_True(50, 794, 885) && ClosureId.Equals(other.ClosureId));
                DynAbs.Tracing.TraceSender.TraceExitMethod(50, 720, 897);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(50, 720, 897);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(50, 720, 897);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(50, 909, 1049);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(50, 974, 1038);

                return obj is ClosureDebugInfo && (DynAbs.Tracing.TraceSender.Expression_True(50, 981, 1037) && Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(50, 909, 1049);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(50, 909, 1049);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(50, 909, 1049);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(50, 1061, 1189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(50, 1119, 1178);

                return f_50_1126_1177(SyntaxOffset, ClosureId.GetHashCode());
                DynAbs.Tracing.TraceSender.TraceExitMethod(50, 1061, 1189);

                int
                f_50_1126_1177(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(50, 1126, 1177);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(50, 1061, 1189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(50, 1061, 1189);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(50, 1201, 1334);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(50, 1262, 1323);

                return $"({ClosureId.GetDebuggerDisplay()} @{SyntaxOffset})";
                DynAbs.Tracing.TraceSender.TraceExitMethod(50, 1201, 1334);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(50, 1201, 1334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(50, 1201, 1334);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static ClosureDebugInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(50, 326, 1341);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(50, 326, 1341);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(50, 326, 1341);
        }
    }
}
