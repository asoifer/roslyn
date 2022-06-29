// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CodeGen
{

    internal struct LocalSlotDebugInfo : IEquatable<LocalSlotDebugInfo>
    {

        public readonly SynthesizedLocalKind SynthesizedKind;

        public readonly LocalDebugId Id;

        public LocalSlotDebugInfo(SynthesizedLocalKind synthesizedKind, LocalDebugId id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(70, 490, 672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(70, 595, 634);

                this.SynthesizedKind = synthesizedKind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(70, 648, 661);

                this.Id = id;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(70, 490, 672);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(70, 490, 672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(70, 490, 672);
            }
        }

        public bool Equals(LocalSlotDebugInfo other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(70, 684, 862);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(70, 753, 851);

                return this.SynthesizedKind == other.SynthesizedKind
                && (DynAbs.Tracing.TraceSender.Expression_True(70, 760, 850) && this.Id.Equals(other.Id));
                DynAbs.Tracing.TraceSender.TraceExitMethod(70, 684, 862);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(70, 684, 862);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(70, 684, 862);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(70, 874, 1018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(70, 939, 1007);

                return obj is LocalSlotDebugInfo && (DynAbs.Tracing.TraceSender.Expression_True(70, 946, 1006) && Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(70, 874, 1018);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(70, 874, 1018);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(70, 874, 1018);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(70, 1030, 1159);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(70, 1088, 1148);

                return f_70_1095_1147(SynthesizedKind, Id.GetHashCode());
                DynAbs.Tracing.TraceSender.TraceExitMethod(70, 1030, 1159);

                int
                f_70_1095_1147(Microsoft.CodeAnalysis.SynthesizedLocalKind
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine((int)newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(70, 1095, 1147);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(70, 1030, 1159);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(70, 1030, 1159);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(70, 1171, 1296);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(70, 1229, 1285);

                return f_70_1236_1262(SynthesizedKind) + " " + Id.ToString();
                DynAbs.Tracing.TraceSender.TraceExitMethod(70, 1171, 1296);

                string
                f_70_1236_1262(Microsoft.CodeAnalysis.SynthesizedLocalKind
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(70, 1236, 1262);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(70, 1171, 1296);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(70, 1171, 1296);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static LocalSlotDebugInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(70, 299, 1303);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(70, 299, 1303);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(70, 299, 1303);
        }
    }
}
