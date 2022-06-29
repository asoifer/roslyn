// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Roslyn.Utilities;
using System;

namespace Microsoft.CodeAnalysis
{

    public struct PreprocessingSymbolInfo : IEquatable<PreprocessingSymbolInfo>
    {

        internal static readonly PreprocessingSymbolInfo None;

        public IPreprocessingSymbol? Symbol { get; }

        public bool IsDefined { get; }

        internal PreprocessingSymbolInfo(IPreprocessingSymbol? symbol, bool isDefined)
                    : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(160, 851, 1049);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(160, 976, 997);

                this.Symbol = symbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(160, 1011, 1038);

                this.IsDefined = isDefined;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(160, 851, 1049);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(160, 851, 1049);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(160, 851, 1049);
            }
        }

        public bool Equals(PreprocessingSymbolInfo other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(160, 1061, 1261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(160, 1135, 1250);

                return f_160_1142_1182(this.Symbol, other.Symbol) && (DynAbs.Tracing.TraceSender.Expression_True(160, 1142, 1249) && f_160_1203_1249(this.IsDefined, other.IsDefined));
                DynAbs.Tracing.TraceSender.TraceExitMethod(160, 1061, 1261);

                bool
                f_160_1142_1182(Microsoft.CodeAnalysis.IPreprocessingSymbol?
                objA, Microsoft.CodeAnalysis.IPreprocessingSymbol?
                objB)
                {
                    var return_v = object.Equals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(160, 1142, 1182);
                    return return_v;
                }


                bool
                f_160_1203_1249(bool
                objA, bool
                objB)
                {
                    var return_v = object.Equals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(160, 1203, 1249);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(160, 1061, 1261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(160, 1061, 1261);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(160, 1273, 1407);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(160, 1338, 1396);

                return obj is PreprocessingSymbolInfo p && (DynAbs.Tracing.TraceSender.Expression_True(160, 1345, 1395) && this.Equals(p));
                DynAbs.Tracing.TraceSender.TraceExitMethod(160, 1273, 1407);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(160, 1273, 1407);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(160, 1273, 1407);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(160, 1419, 1554);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(160, 1477, 1543);

                return f_160_1484_1542(this.IsDefined, f_160_1513_1541(this.Symbol, 0));
                DynAbs.Tracing.TraceSender.TraceExitMethod(160, 1419, 1554);

                int
                f_160_1513_1541(Microsoft.CodeAnalysis.IPreprocessingSymbol?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(160, 1513, 1541);
                    return return_v;
                }


                int
                f_160_1484_1542(bool
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(160, 1484, 1542);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(160, 1419, 1554);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(160, 1419, 1554);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static PreprocessingSymbolInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(160, 291, 1561);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(160, 432, 479);
            None = f_160_439_479(null, false); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(160, 291, 1561);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(160, 291, 1561);
        }

        static Microsoft.CodeAnalysis.PreprocessingSymbolInfo
        f_160_439_479(Microsoft.CodeAnalysis.IPreprocessingSymbol?
        symbol, bool
        isDefined)
        {
            var return_v = new Microsoft.CodeAnalysis.PreprocessingSymbolInfo(symbol, isDefined);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(160, 439, 479);
            return return_v;
        }

    }
}
