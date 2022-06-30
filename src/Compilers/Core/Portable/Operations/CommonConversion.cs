// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CodeAnalysis.Operations
{

    public struct CommonConversion
    {
        [Flags]
        private enum ConversionKind
        {
            None = 0,
            Exists = 1 << 0,
            IsIdentity = 1 << 1,
            IsNumeric = 1 << 2,
            IsReference = 1 << 3,
            IsImplicit = 1 << 4,
            IsNullable = 1 << 5,
        }

        private readonly ConversionKind _conversionKind;

        internal CommonConversion(bool exists, bool isIdentity, bool isNumeric, bool isReference, bool isImplicit, bool isNullable, IMethodSymbol? methodSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(447, 946, 1729);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(447, 1123, 1676);

                _conversionKind = ((DynAbs.Tracing.TraceSender.Conditional_F1(447, 1142, 1148) || ((exists && DynAbs.Tracing.TraceSender.Conditional_F2(447, 1151, 1172)) || DynAbs.Tracing.TraceSender.Conditional_F3(447, 1175, 1194))) ? ConversionKind.Exists : ConversionKind.None) |
                                              ((DynAbs.Tracing.TraceSender.Conditional_F1(447, 1230, 1240) || ((isIdentity && DynAbs.Tracing.TraceSender.Conditional_F2(447, 1243, 1268)) || DynAbs.Tracing.TraceSender.Conditional_F3(447, 1271, 1290))) ? ConversionKind.IsIdentity : ConversionKind.None) |
                                              ((DynAbs.Tracing.TraceSender.Conditional_F1(447, 1326, 1335) || ((isNumeric && DynAbs.Tracing.TraceSender.Conditional_F2(447, 1338, 1362)) || DynAbs.Tracing.TraceSender.Conditional_F3(447, 1365, 1384))) ? ConversionKind.IsNumeric : ConversionKind.None) |
                                              ((DynAbs.Tracing.TraceSender.Conditional_F1(447, 1420, 1431) || ((isReference && DynAbs.Tracing.TraceSender.Conditional_F2(447, 1434, 1460)) || DynAbs.Tracing.TraceSender.Conditional_F3(447, 1463, 1482))) ? ConversionKind.IsReference : ConversionKind.None) |
                                              ((DynAbs.Tracing.TraceSender.Conditional_F1(447, 1518, 1528) || ((isImplicit && DynAbs.Tracing.TraceSender.Conditional_F2(447, 1531, 1556)) || DynAbs.Tracing.TraceSender.Conditional_F3(447, 1559, 1578))) ? ConversionKind.IsImplicit : ConversionKind.None) |
                                              ((DynAbs.Tracing.TraceSender.Conditional_F1(447, 1614, 1624) || ((isNullable && DynAbs.Tracing.TraceSender.Conditional_F2(447, 1627, 1652)) || DynAbs.Tracing.TraceSender.Conditional_F3(447, 1655, 1674))) ? ConversionKind.IsNullable : ConversionKind.None);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(447, 1690, 1718);

                MethodSymbol = methodSymbol;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(447, 946, 1729);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(447, 946, 1729);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(447, 946, 1729);
            }
        }

        public bool Exists
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(447, 2136, 2205);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(447, 2139, 2205);
                    return (_conversionKind & ConversionKind.Exists) == ConversionKind.Exists; DynAbs.Tracing.TraceSender.TraceExitMethod(447, 2136, 2205);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(447, 2136, 2205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(447, 2136, 2205);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsIdentity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(447, 2357, 2434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(447, 2360, 2434);
                    return (_conversionKind & ConversionKind.IsIdentity) == ConversionKind.IsIdentity; DynAbs.Tracing.TraceSender.TraceExitMethod(447, 2357, 2434);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(447, 2357, 2434);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(447, 2357, 2434);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsNullable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(447, 2586, 2663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(447, 2589, 2663);
                    return (_conversionKind & ConversionKind.IsNullable) == ConversionKind.IsNullable; DynAbs.Tracing.TraceSender.TraceExitMethod(447, 2586, 2663);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(447, 2586, 2663);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(447, 2586, 2663);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsNumeric
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(447, 2812, 2887);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(447, 2815, 2887);
                    return (_conversionKind & ConversionKind.IsNumeric) == ConversionKind.IsNumeric; DynAbs.Tracing.TraceSender.TraceExitMethod(447, 2812, 2887);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(447, 2812, 2887);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(447, 2812, 2887);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(447, 3040, 3119);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(447, 3043, 3119);
                    return (_conversionKind & ConversionKind.IsReference) == ConversionKind.IsReference; DynAbs.Tracing.TraceSender.TraceExitMethod(447, 3040, 3119);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(447, 3040, 3119);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(447, 3040, 3119);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsImplicit
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(447, 3293, 3370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(447, 3296, 3370);
                    return (_conversionKind & ConversionKind.IsImplicit) == ConversionKind.IsImplicit; DynAbs.Tracing.TraceSender.TraceExitMethod(447, 3293, 3370);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(447, 3293, 3370);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(447, 3293, 3370);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [MemberNotNullWhen(true, nameof(MethodSymbol))]
        public bool IsUserDefined
        {        /// <summary>
                 /// Returns true if the conversion is a user-defined conversion.
                 /// </summary>
            [MemberNotNullWhen(true, nameof(MethodSymbol))]
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(447, 3585, 3608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(447, 3588, 3608);
                    return MethodSymbol != null; DynAbs.Tracing.TraceSender.TraceExitMethod(447, 3585, 3608);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(447, 3585, 3608);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(447, 3585, 3608);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IMethodSymbol? MethodSymbol { get; }
        static CommonConversion()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(447, 538, 3887);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(447, 538, 3887);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(447, 538, 3887);
        }
    }
}
