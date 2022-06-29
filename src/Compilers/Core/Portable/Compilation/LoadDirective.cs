// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    internal readonly struct LoadDirective : IEquatable<LoadDirective>
    {

        public readonly string? ResolvedPath;

        public readonly ImmutableArray<Diagnostic> Diagnostics;

        public LoadDirective(string? resolvedPath, ImmutableArray<Diagnostic> diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(154, 572, 1016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(154, 679, 746);

                f_154_679_745((resolvedPath != null) || (DynAbs.Tracing.TraceSender.Expression_False(154, 698, 744) || 
                    f_154_724_744_M(!diagnostics.IsEmpty)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(154, 760, 803);

                f_154_760_802(f_154_779_801_M(!diagnostics.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(154, 817, 921);

                f_154_817_920(diagnostics.IsEmpty || (DynAbs.Tracing.TraceSender.Expression_False(154, 836, 919) || diagnostics.All(d => d.Severity == DiagnosticSeverity.Error)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(154, 937, 965);

                ResolvedPath = resolvedPath;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(154, 979, 1005);

                Diagnostics = diagnostics;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(154, 572, 1016);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(154, 572, 1016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(154, 572, 1016);
            }
        }

        public bool Equals(LoadDirective other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(154, 1028, 1220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(154, 1092, 1209);

                return this.ResolvedPath == other.ResolvedPath && (DynAbs.Tracing.TraceSender.Expression_True(154, 1099, 1208) && this.Diagnostics.SequenceEqual(other.Diagnostics));
                DynAbs.Tracing.TraceSender.TraceExitMethod(154, 1028, 1220);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(154, 1028, 1220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(154, 1028, 1220);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(154, 1232, 1366);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(154, 1297, 1355);

                return obj is LoadDirective && (DynAbs.Tracing.TraceSender.Expression_True(154, 1304, 1354) && Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(154, 1232, 1366);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(154, 1232, 1366);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(154, 1232, 1366);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(154, 1378, 1538);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(154, 1436, 1527);

                return f_154_1443_1526(this.Diagnostics.GetHashCode(), f_154_1488_1520_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(this.ResolvedPath, 154, 1488, 1520).GetHashCode()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(154, 1488, 1525) ?? 0));
                DynAbs.Tracing.TraceSender.TraceExitMethod(154, 1378, 1538);

                int?
                f_154_1488_1520_I(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(154, 1488, 1520);
                    return return_v;
                }


                int
                f_154_1443_1526(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(154, 1443, 1526);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(154, 1378, 1538);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(154, 1378, 1538);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static LoadDirective()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(154, 375, 1545);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(154, 375, 1545);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(154, 375, 1545);
        }

        static bool
        f_154_724_744_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(154, 724, 744);
            return return_v;
        }


        static int
        f_154_679_745(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(154, 679, 745);
            return 0;
        }


        static bool
        f_154_779_801_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(154, 779, 801);
            return return_v;
        }


        static int
        f_154_760_802(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(154, 760, 802);
            return 0;
        }


        static int
        f_154_817_920(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(154, 817, 920);
            return 0;
        }

    }
}
