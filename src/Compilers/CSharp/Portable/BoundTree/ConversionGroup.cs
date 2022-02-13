// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    internal sealed class ConversionGroup
    {
        internal ConversionGroup(Conversion conversion, TypeWithAnnotations explicitType = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10580, 722, 915);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10580, 1682, 1697);
                this._id = _nextId++; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10580, 838, 862);

                Conversion = conversion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10580, 876, 904);

                ExplicitType = explicitType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10580, 722, 915);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10580, 722, 915);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10580, 722, 915);
            }
        }

        internal bool IsExplicitConversion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10580, 1072, 1095);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10580, 1075, 1095);
                    return ExplicitType.HasType; DynAbs.Tracing.TraceSender.TraceExitMethod(10580, 1072, 1095);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10580, 1072, 1095);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10580, 1072, 1095);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal readonly Conversion Conversion;

        internal readonly TypeWithAnnotations ExplicitType;

        private static int _nextId;

        private readonly int _id;

        internal string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10580, 1710, 1955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10580, 1771, 1804);

                var
                str = $"#{_id} {Conversion}"
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10580, 1818, 1919) || true) && (ExplicitType.HasType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10580, 1818, 1919);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10580, 1876, 1904);

                    str += $" ({ExplicitType})";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10580, 1818, 1919);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10580, 1933, 1944);

                return str;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10580, 1710, 1955);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10580, 1710, 1955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10580, 1710, 1955);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ConversionGroup()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10580, 615, 1970);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10580, 1643, 1650);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10580, 615, 1970);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10580, 615, 1970);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10580, 615, 1970);
    }
}
