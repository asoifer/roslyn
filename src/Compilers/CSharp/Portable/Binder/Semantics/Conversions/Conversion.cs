// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.Operations;

namespace Microsoft.CodeAnalysis.CSharp
{

    public struct Conversion : IEquatable<Conversion>, IConvertibleConversion
    {

        private readonly ConversionKind _kind;

        private readonly UncommonData? _uncommonData;
        private class UncommonData
        {
            public UncommonData(
                            bool isExtensionMethod,
                            bool isArrayIndex,
                            UserDefinedConversionResult conversionResult,
                            MethodSymbol? conversionMethod,
                            ImmutableArray<Conversion> nestedConversions)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10838, 1098, 1773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 1821, 1838);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 2208, 2214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 1403, 1440);

                    _conversionMethod = conversionMethod;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 1458, 1495);

                    _conversionResult = conversionResult;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 1513, 1555);

                    _nestedConversionsOpt = nestedConversions;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 1575, 1636);

                    _flags = (DynAbs.Tracing.TraceSender.Conditional_F1(10838, 1584, 1601) || ((isExtensionMethod && DynAbs.Tracing.TraceSender.Conditional_F2(10838, 1604, 1625)) || DynAbs.Tracing.TraceSender.Conditional_F3(10838, 1628, 1635))) ? IsExtensionMethodMask : (byte)0;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 1654, 1758) || true) && (isArrayIndex)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 1654, 1758);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 1712, 1739);

                        _flags |= IsArrayIndexMask;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 1654, 1758);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10838, 1098, 1773);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 1098, 1773);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 1098, 1773);
                }
            }

            internal readonly MethodSymbol? _conversionMethod;

            internal readonly ImmutableArray<Conversion> _nestedConversionsOpt;

            internal readonly UserDefinedConversionResult _conversionResult;

            private const byte
            IsExtensionMethodMask = 1 << 0
            ;

            private const byte
            IsArrayIndexMask = 1 << 1
            ;

            private readonly byte _flags;

            internal bool IsExtensionMethod
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 2295, 2403);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 2339, 2384);

                        return (_flags & IsExtensionMethodMask) != 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 2295, 2403);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 2231, 2418);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 2231, 2418);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal bool IsArrayIndex
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 2592, 2695);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 2636, 2676);

                        return (_flags & IsArrayIndexMask) != 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 2592, 2695);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 2533, 2710);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 2533, 2710);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static UncommonData()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10838, 1047, 2721);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 2082, 2112);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 2146, 2171);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10838, 1047, 2721);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 1047, 2721);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10838, 1047, 2721);
        }
        private class DeconstructionUncommonData : UncommonData
        {
            internal DeconstructionUncommonData(DeconstructMethodInfo deconstructMethodInfoOpt, ImmutableArray<Conversion> nestedConversions)
            : base(isExtensionMethod: f_10838_2967_2991_C(false), isArrayIndex: false, conversionResult: default, conversionMethod: null, nestedConversions)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10838, 2813, 3248);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 3116, 3166);

                    f_10838_3116_3165(f_10838_3129_3164_M(!nestedConversions.IsDefaultOrEmpty));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 3184, 3233);

                    DeconstructMethodInfo = deconstructMethodInfoOpt;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10838, 2813, 3248);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 2813, 3248);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 2813, 3248);
                }
            }

            internal readonly DeconstructMethodInfo DeconstructMethodInfo;

            static DeconstructionUncommonData()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10838, 2733, 3337);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10838, 2733, 3337);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 2733, 3337);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10838, 2733, 3337);

            bool
            f_10838_3129_3164_M(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10838, 3129, 3164);
                return return_v;
            }


            int
            f_10838_3116_3165(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 3116, 3165);
                return 0;
            }


            static bool
            f_10838_2967_2991_C(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10838, 2813, 3248);
                return return_v;
            }

        }

        private Conversion(
                    ConversionKind kind,
                    UncommonData? uncommonData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10838, 3349, 3535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 3468, 3481);

                _kind = kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 3495, 3524);

                _uncommonData = uncommonData;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10838, 3349, 3535);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 3349, 3535);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 3349, 3535);
            }
        }

        private Conversion(ConversionKind kind)
        : this(f_10838_3607_3611_C(kind), null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10838, 3547, 3640);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10838, 3547, 3640);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 3547, 3640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 3547, 3640);
            }
        }

        internal Conversion(UserDefinedConversionResult conversionResult, bool isImplicit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10838, 3652, 4278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 3759, 3997);

                _kind = (DynAbs.Tracing.TraceSender.Conditional_F1(10838, 3767, 3845) || ((conversionResult.Kind == UserDefinedConversionResultKind.NoApplicableOperators
                && DynAbs.Tracing.TraceSender.Conditional_F2(10838, 3865, 3892)) || DynAbs.Tracing.TraceSender.Conditional_F3(10838, 3912, 3996))) ? ConversionKind.NoConversion
                : (DynAbs.Tracing.TraceSender.Conditional_F1(10838, 3912, 3922) || ((isImplicit && DynAbs.Tracing.TraceSender.Conditional_F2(10838, 3925, 3959)) || DynAbs.Tracing.TraceSender.Conditional_F3(10838, 3962, 3996))) ? ConversionKind.ImplicitUserDefined : ConversionKind.ExplicitUserDefined;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 4013, 4267);

                _uncommonData = f_10838_4029_4266(isExtensionMethod: false, isArrayIndex: false, conversionResult: conversionResult, conversionMethod: null, nestedConversions: default);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10838, 3652, 4278);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 3652, 4278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 3652, 4278);
            }
        }

        internal Conversion(ConversionKind kind, MethodSymbol conversionMethod, bool isExtensionMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10838, 4364, 4796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 4484, 4502);

                this._kind = kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 4516, 4785);

                _uncommonData = f_10838_4532_4784(isExtensionMethod: isExtensionMethod, isArrayIndex: false, conversionResult: default, conversionMethod: conversionMethod, nestedConversions: default);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10838, 4364, 4796);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 4364, 4796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 4364, 4796);
            }
        }

        internal Conversion(ConversionKind kind, ImmutableArray<Conversion> nestedConversions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10838, 4808, 5217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 4919, 4937);

                this._kind = kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 4951, 5206);

                _uncommonData = f_10838_4967_5205(isExtensionMethod: false, isArrayIndex: false, conversionResult: default, conversionMethod: null, nestedConversions: nestedConversions);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10838, 4808, 5217);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 4808, 5217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 4808, 5217);
            }
        }

        internal Conversion(ConversionKind kind, DeconstructMethodInfo deconstructMethodInfo, ImmutableArray<Conversion> nestedConversions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10838, 5229, 5585);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 5385, 5437);

                f_10838_5385_5436(kind == ConversionKind.Deconstruction);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 5453, 5471);

                this._kind = kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 5485, 5574);

                _uncommonData = f_10838_5501_5573(deconstructMethodInfo, nestedConversions);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10838, 5229, 5585);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 5229, 5585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 5229, 5585);
            }
        }

        internal Conversion SetConversionMethod(MethodSymbol conversionMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 5597, 6278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 6078, 6162);

                f_10838_6078_6161(_kind == ConversionKind.MethodGroup || (DynAbs.Tracing.TraceSender.Expression_False(10838, 6091, 6160) || _kind == ConversionKind.IntPtr));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 6178, 6267);

                return f_10838_6185_6266(this.Kind, conversionMethod, isExtensionMethod: IsExtensionMethod);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 5597, 6278);

                int
                f_10838_6078_6161(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 6078, 6161);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10838_6185_6266(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                conversionMethod, bool
                isExtensionMethod)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, conversionMethod, isExtensionMethod: isExtensionMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 6185, 6266);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 5597, 6278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 5597, 6278);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Conversion SetArrayIndexConversionForDynamic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 6290, 6792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 6370, 6402);

                f_10838_6370_6401(f_10838_6383_6400(_kind));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 6416, 6452);

                f_10838_6416_6451(_uncommonData == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 6468, 6781);

                return f_10838_6475_6780(_kind, f_10838_6532_6779(isExtensionMethod: false, isArrayIndex: true, conversionResult: default, conversionMethod: null, nestedConversions: default));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 6290, 6792);

                bool
                f_10838_6383_6400(Microsoft.CodeAnalysis.CSharp.ConversionKind
                conversionKind)
                {
                    var return_v = conversionKind.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 6383, 6400);
                    return return_v;
                }


                int
                f_10838_6370_6401(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 6370, 6401);
                    return 0;
                }


                int
                f_10838_6416_6451(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 6416, 6451);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion.UncommonData
                f_10838_6532_6779(bool
                isExtensionMethod, bool
                isArrayIndex, Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResult
                conversionResult, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                conversionMethod, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                nestedConversions)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion.UncommonData(isExtensionMethod: isExtensionMethod, isArrayIndex: isArrayIndex, conversionResult: conversionResult, conversionMethod: conversionMethod, nestedConversions: nestedConversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 6532, 6779);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10838_6475_6780(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, Microsoft.CodeAnalysis.CSharp.Conversion.UncommonData
                uncommonData)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, uncommonData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 6475, 6780);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 6290, 6792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 6290, 6792);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Conditional("DEBUG")]
        private static void AssertTrivialConversion(ConversionKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10838, 6804, 8574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 6925, 6940);

                bool
                isTrivial
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 6956, 8473);

                switch (kind)
                {

                    case ConversionKind.NoConversion:
                    case ConversionKind.Identity:
                    case ConversionKind.ImplicitConstant:
                    case ConversionKind.ImplicitNumeric:
                    case ConversionKind.ImplicitReference:
                    case ConversionKind.ImplicitEnumeration:
                    case ConversionKind.ImplicitThrow:
                    case ConversionKind.AnonymousFunction:
                    case ConversionKind.Boxing:
                    case ConversionKind.NullLiteral:
                    case ConversionKind.DefaultLiteral:
                    case ConversionKind.ImplicitNullToPointer:
                    case ConversionKind.ImplicitPointerToVoid:
                    case ConversionKind.ExplicitPointerToPointer:
                    case ConversionKind.ExplicitPointerToInteger:
                    case ConversionKind.ExplicitIntegerToPointer:
                    case ConversionKind.Unboxing:
                    case ConversionKind.ExplicitReference:
                    case ConversionKind.IntPtr:
                    case ConversionKind.ExplicitEnumeration:
                    case ConversionKind.ExplicitNumeric:
                    case ConversionKind.ImplicitDynamic:
                    case ConversionKind.ExplicitDynamic:
                    case ConversionKind.InterpolatedString:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 6956, 8473);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 8317, 8334);

                        isTrivial = true;
                        DynAbs.Tracing.TraceSender.TraceBreak(10838, 8356, 8362);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 6956, 8473);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 6956, 8473);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 8412, 8430);

                        isTrivial = false;
                        DynAbs.Tracing.TraceSender.TraceBreak(10838, 8452, 8458);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 6956, 8473);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 8489, 8563);

                f_10838_8489_8562(isTrivial, "this conversion needs additional data: " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (kind).ToString(), 10838, 8557, 8561));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10838, 6804, 8574);

                int
                f_10838_8489_8562(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 8489, 8562);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 6804, 8574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 6804, 8574);
            }
        }

        internal static Conversion GetTrivialConversion(ConversionKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10838, 8586, 8762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 8679, 8709);

                AssertTrivialConversion(kind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 8723, 8751);

                return f_10838_8730_8750(kind);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10838, 8586, 8762);

                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10838_8730_8750(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 8730, 8750);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 8586, 8762);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 8586, 8762);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Conversion UnsetConversion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 8817, 8870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 8820, 8870);
                    return f_10838_8820_8870(ConversionKind.UnsetConversionKind); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 8817, 8870);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 8817, 8870);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 8817, 8870);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion NoConversion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 8921, 8967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 8924, 8967);
                    return f_10838_8924_8967(ConversionKind.NoConversion); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 8921, 8967);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 8921, 8967);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 8921, 8967);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion Identity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 9014, 9056);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 9017, 9056);
                    return f_10838_9017_9056(ConversionKind.Identity); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 9014, 9056);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 9014, 9056);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 9014, 9056);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion ImplicitConstant
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 9111, 9161);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 9114, 9161);
                    return f_10838_9114_9161(ConversionKind.ImplicitConstant); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 9111, 9161);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 9111, 9161);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 9111, 9161);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion ImplicitNumeric
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 9215, 9264);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 9218, 9264);
                    return f_10838_9218_9264(ConversionKind.ImplicitNumeric); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 9215, 9264);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 9215, 9264);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 9215, 9264);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion ImplicitReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 9320, 9371);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 9323, 9371);
                    return f_10838_9323_9371(ConversionKind.ImplicitReference); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 9320, 9371);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 9320, 9371);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 9320, 9371);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion ImplicitEnumeration
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 9429, 9482);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 9432, 9482);
                    return f_10838_9432_9482(ConversionKind.ImplicitEnumeration); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 9429, 9482);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 9429, 9482);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 9429, 9482);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion ImplicitThrow
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 9534, 9581);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 9537, 9581);
                    return f_10838_9537_9581(ConversionKind.ImplicitThrow); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 9534, 9581);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 9534, 9581);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 9534, 9581);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion ObjectCreation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 9634, 9682);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 9637, 9682);
                    return f_10838_9637_9682(ConversionKind.ObjectCreation); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 9634, 9682);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 9634, 9682);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 9634, 9682);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion AnonymousFunction
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 9738, 9789);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 9741, 9789);
                    return f_10838_9741_9789(ConversionKind.AnonymousFunction); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 9738, 9789);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 9738, 9789);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 9738, 9789);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion Boxing
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 9834, 9874);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 9837, 9874);
                    return f_10838_9837_9874(ConversionKind.Boxing); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 9834, 9874);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 9834, 9874);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 9834, 9874);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion NullLiteral
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 9924, 9969);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 9927, 9969);
                    return f_10838_9927_9969(ConversionKind.NullLiteral); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 9924, 9969);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 9924, 9969);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 9924, 9969);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion DefaultLiteral
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 10022, 10070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 10025, 10070);
                    return f_10838_10025_10070(ConversionKind.DefaultLiteral); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 10022, 10070);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 10022, 10070);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 10022, 10070);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion NullToPointer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 10122, 10177);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 10125, 10177);
                    return f_10838_10125_10177(ConversionKind.ImplicitNullToPointer); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 10122, 10177);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 10122, 10177);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 10122, 10177);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion PointerToVoid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 10229, 10284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 10232, 10284);
                    return f_10838_10232_10284(ConversionKind.ImplicitPointerToVoid); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 10229, 10284);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 10229, 10284);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 10229, 10284);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion PointerToPointer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 10339, 10397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 10342, 10397);
                    return f_10838_10342_10397(ConversionKind.ExplicitPointerToPointer); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 10339, 10397);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 10339, 10397);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 10339, 10397);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion PointerToInteger
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 10452, 10510);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 10455, 10510);
                    return f_10838_10455_10510(ConversionKind.ExplicitPointerToInteger); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 10452, 10510);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 10452, 10510);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 10452, 10510);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion IntegerToPointer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 10565, 10623);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 10568, 10623);
                    return f_10838_10568_10623(ConversionKind.ExplicitIntegerToPointer); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 10565, 10623);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 10565, 10623);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 10565, 10623);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion Unboxing
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 10670, 10712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 10673, 10712);
                    return f_10838_10673_10712(ConversionKind.Unboxing); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 10670, 10712);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 10670, 10712);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 10670, 10712);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion ExplicitReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 10768, 10819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 10771, 10819);
                    return f_10838_10771_10819(ConversionKind.ExplicitReference); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 10768, 10819);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 10768, 10819);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 10768, 10819);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion IntPtr
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 10864, 10904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 10867, 10904);
                    return f_10838_10867_10904(ConversionKind.IntPtr); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 10864, 10904);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 10864, 10904);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 10864, 10904);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion ExplicitEnumeration
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 10962, 11015);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 10965, 11015);
                    return f_10838_10965_11015(ConversionKind.ExplicitEnumeration); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 10962, 11015);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 10962, 11015);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 10962, 11015);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion ExplicitNumeric
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 11069, 11118);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 11072, 11118);
                    return f_10838_11072_11118(ConversionKind.ExplicitNumeric); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 11069, 11118);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 11069, 11118);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 11069, 11118);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion ImplicitDynamic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 11172, 11221);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 11175, 11221);
                    return f_10838_11175_11221(ConversionKind.ImplicitDynamic); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 11172, 11221);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 11172, 11221);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 11172, 11221);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion ExplicitDynamic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 11275, 11324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 11278, 11324);
                    return f_10838_11278_11324(ConversionKind.ExplicitDynamic); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 11275, 11324);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 11275, 11324);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 11275, 11324);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion InterpolatedString
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 11381, 11433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 11384, 11433);
                    return f_10838_11384_11433(ConversionKind.InterpolatedString); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 11381, 11433);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 11381, 11433);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 11381, 11433);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion Deconstruction
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 11486, 11534);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 11489, 11534);
                    return f_10838_11489_11534(ConversionKind.Deconstruction); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 11486, 11534);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 11486, 11534);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 11486, 11534);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion PinnedObjectToPointer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 11594, 11649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 11597, 11649);
                    return f_10838_11597_11649(ConversionKind.PinnedObjectToPointer); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 11594, 11649);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 11594, 11649);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 11594, 11649);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Conversion ImplicitPointer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 11703, 11752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 11706, 11752);
                    return f_10838_11706_11752(ConversionKind.ImplicitPointer); DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 11703, 11752);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 11703, 11752);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 11703, 11752);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static ImmutableArray<Conversion> IdentityUnderlying
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 11996, 12038);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 11999, 12038);
                    return ConversionSingletons.IdentityUnderlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 11996, 12038);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 11996, 12038);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 11996, 12038);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static ImmutableArray<Conversion> ImplicitConstantUnderlying
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 12119, 12169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 12122, 12169);
                    return ConversionSingletons.ImplicitConstantUnderlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 12119, 12169);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 12119, 12169);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 12119, 12169);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static ImmutableArray<Conversion> ImplicitNumericUnderlying
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 12249, 12298);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 12252, 12298);
                    return ConversionSingletons.ImplicitNumericUnderlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 12249, 12298);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 12249, 12298);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 12249, 12298);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static ImmutableArray<Conversion> ExplicitNumericUnderlying
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 12378, 12427);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 12381, 12427);
                    return ConversionSingletons.ExplicitNumericUnderlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 12378, 12427);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 12378, 12427);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 12378, 12427);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static ImmutableArray<Conversion> ExplicitEnumerationUnderlying
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 12511, 12564);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 12514, 12564);
                    return ConversionSingletons.ExplicitEnumerationUnderlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 12511, 12564);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 12511, 12564);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 12511, 12564);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static ImmutableArray<Conversion> PointerToIntegerUnderlying
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 12645, 12695);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 12648, 12695);
                    return ConversionSingletons.PointerToIntegerUnderlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 12645, 12695);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 12645, 12695);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 12645, 12695);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
        private static class ConversionSingletons
        {
            internal static ImmutableArray<Conversion> IdentityUnderlying;

            internal static ImmutableArray<Conversion> ImplicitConstantUnderlying;

            internal static ImmutableArray<Conversion> ImplicitNumericUnderlying;

            internal static ImmutableArray<Conversion> ExplicitNumericUnderlying;

            internal static ImmutableArray<Conversion> ExplicitEnumerationUnderlying;

            internal static ImmutableArray<Conversion> PointerToIntegerUnderlying;

            static ConversionSingletons()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10838, 12831, 13636);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 12940, 12992);
                IdentityUnderlying = f_10838_12961_12992(Identity); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 13050, 13118);
                ImplicitConstantUnderlying = f_10838_13079_13118(ImplicitConstant); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 13176, 13242);
                ImplicitNumericUnderlying = f_10838_13204_13242(ImplicitNumeric); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 13300, 13366);
                ExplicitNumericUnderlying = f_10838_13328_13366(ExplicitNumeric); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 13424, 13498);
                ExplicitEnumerationUnderlying = f_10838_13456_13498(ExplicitEnumeration); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 13556, 13624);
                PointerToIntegerUnderlying = f_10838_13585_13624(PointerToInteger); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10838, 12831, 13636);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 12831, 13636);
            }


            static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
            f_10838_12961_12992(Microsoft.CodeAnalysis.CSharp.Conversion
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 12961, 12992);
                return return_v;
            }


            static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
            f_10838_13079_13118(Microsoft.CodeAnalysis.CSharp.Conversion
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 13079, 13118);
                return return_v;
            }


            static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
            f_10838_13204_13242(Microsoft.CodeAnalysis.CSharp.Conversion
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 13204, 13242);
                return return_v;
            }


            static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
            f_10838_13328_13366(Microsoft.CodeAnalysis.CSharp.Conversion
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 13328, 13366);
                return return_v;
            }


            static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
            f_10838_13456_13498(Microsoft.CodeAnalysis.CSharp.Conversion
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 13456, 13498);
                return return_v;
            }


            static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
            f_10838_13585_13624(Microsoft.CodeAnalysis.CSharp.Conversion
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 13585, 13624);
                return return_v;
            }

        }

        internal static Conversion MakeStackAllocToPointerType(Conversion underlyingConversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10838, 13648, 13878);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 13760, 13867);

                return f_10838_13767_13866(ConversionKind.StackAllocToPointerType, f_10838_13822_13865(underlyingConversion));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10838, 13648, 13878);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                f_10838_13822_13865(Microsoft.CodeAnalysis.CSharp.Conversion
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 13822, 13865);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10838_13767_13866(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                nestedConversions)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, nestedConversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 13767, 13866);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 13648, 13878);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 13648, 13878);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Conversion MakeStackAllocToSpanType(Conversion underlyingConversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10838, 13890, 14114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 13999, 14103);

                return f_10838_14006_14102(ConversionKind.StackAllocToSpanType, f_10838_14058_14101(underlyingConversion));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10838, 13890, 14114);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                f_10838_14058_14101(Microsoft.CodeAnalysis.CSharp.Conversion
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 14058, 14101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10838_14006_14102(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                nestedConversions)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, nestedConversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 14006, 14102);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 13890, 14114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 13890, 14114);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Conversion MakeNullableConversion(ConversionKind kind, Conversion nestedConversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10838, 14126, 15499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 14250, 14347);

                f_10838_14250_14346(kind == ConversionKind.ImplicitNullable || (DynAbs.Tracing.TraceSender.Expression_False(10838, 14263, 14345) || kind == ConversionKind.ExplicitNullable));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 14363, 14397);

                ImmutableArray<Conversion>
                nested
                = default(ImmutableArray<Conversion>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 14411, 15436);

                switch (nestedConversion.Kind)
                {

                    case ConversionKind.Identity:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 14411, 15436);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 14525, 14553);

                        nested = IdentityUnderlying;
                        DynAbs.Tracing.TraceSender.TraceBreak(10838, 14575, 14581);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 14411, 15436);

                    case ConversionKind.ImplicitConstant:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 14411, 15436);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 14658, 14694);

                        nested = ImplicitConstantUnderlying;
                        DynAbs.Tracing.TraceSender.TraceBreak(10838, 14716, 14722);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 14411, 15436);

                    case ConversionKind.ImplicitNumeric:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 14411, 15436);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 14798, 14833);

                        nested = ImplicitNumericUnderlying;
                        DynAbs.Tracing.TraceSender.TraceBreak(10838, 14855, 14861);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 14411, 15436);

                    case ConversionKind.ExplicitNumeric:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 14411, 15436);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 14937, 14972);

                        nested = ExplicitNumericUnderlying;
                        DynAbs.Tracing.TraceSender.TraceBreak(10838, 14994, 15000);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 14411, 15436);

                    case ConversionKind.ExplicitEnumeration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 14411, 15436);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 15080, 15119);

                        nested = ExplicitEnumerationUnderlying;
                        DynAbs.Tracing.TraceSender.TraceBreak(10838, 15141, 15147);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 14411, 15436);

                    case ConversionKind.ExplicitPointerToInteger:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 14411, 15436);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 15232, 15268);

                        nested = PointerToIntegerUnderlying;
                        DynAbs.Tracing.TraceSender.TraceBreak(10838, 15290, 15296);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 14411, 15436);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 14411, 15436);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 15344, 15393);

                        nested = f_10838_15353_15392(nestedConversion);
                        DynAbs.Tracing.TraceSender.TraceBreak(10838, 15415, 15421);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 14411, 15436);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 15452, 15488);

                return f_10838_15459_15487(kind, nested);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10838, 14126, 15499);

                int
                f_10838_14250_14346(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 14250, 14346);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                f_10838_15353_15392(Microsoft.CodeAnalysis.CSharp.Conversion
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 15353, 15392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10838_15459_15487(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                nestedConversions)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, nestedConversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 15459, 15487);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 14126, 15499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 14126, 15499);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Conversion MakeSwitchExpression(ImmutableArray<Conversion> innerConversions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10838, 15511, 15712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 15628, 15701);

                return f_10838_15635_15700(ConversionKind.SwitchExpression, innerConversions);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10838, 15511, 15712);

                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10838_15635_15700(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                nestedConversions)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, nestedConversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 15635, 15700);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 15511, 15712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 15511, 15712);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Conversion MakeConditionalExpression(ImmutableArray<Conversion> innerConversions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10838, 15724, 15935);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 15846, 15924);

                return f_10838_15853_15923(ConversionKind.ConditionalExpression, innerConversions);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10838, 15724, 15935);

                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10838_15853_15923(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                nestedConversions)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, nestedConversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 15853, 15923);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 15724, 15935);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 15724, 15935);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ConversionKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 16000, 16064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 16036, 16049);

                    return _kind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 16000, 16064);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 15947, 16075);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 15947, 16075);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsExtensionMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 16143, 16242);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 16179, 16227);

                    return f_10838_16186_16218_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_uncommonData, 10838, 16186, 16218)?.IsExtensionMethod) == true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 16143, 16242);

                    bool?
                    f_10838_16186_16218_M(bool?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10838, 16186, 16218);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 16087, 16253);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 16087, 16253);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsArrayIndex
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 16316, 16410);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 16352, 16395);

                    return f_10838_16359_16386_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_uncommonData, 10838, 16359, 16386)?.IsArrayIndex) == true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 16316, 16410);

                    bool?
                    f_10838_16359_16386_M(bool?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10838, 16359, 16386);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 16265, 16421);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 16265, 16421);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<Conversion> UnderlyingConversions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 16515, 16649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 16551, 16634);

                    return DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_uncommonData, 10838, 16558, 16594)?._nestedConversionsOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>?>(10838, 16558, 16633) ?? default(ImmutableArray<Conversion>));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 16515, 16649);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 16433, 16660);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 16433, 16660);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal MethodSymbol? Method
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 16726, 17750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 16762, 16795);

                    var
                    uncommonData = _uncommonData
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 16813, 17703) || true) && (uncommonData != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 16813, 17703);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 16879, 17034) || true) && (uncommonData._conversionMethod is object)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 16879, 17034);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 16973, 17011);

                            return uncommonData._conversionMethod;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 16879, 17034);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 17058, 17112);

                        var
                        conversionResult = uncommonData._conversionResult
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 17134, 17413) || true) && (conversionResult.Kind == UserDefinedConversionResultKind.Valid)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 17134, 17413);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 17250, 17339);

                            UserDefinedConversionAnalysis
                            analysis = conversionResult.Results[conversionResult.Best]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 17365, 17390);

                            return analysis.Operator;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 17134, 17413);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 17437, 17684) || true) && (uncommonData is DeconstructionUncommonData deconstruction
                        && (DynAbs.Tracing.TraceSender.Expression_True(10838, 17441, 17592) && deconstruction.DeconstructMethodInfo.Invocation is BoundCall call))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 17437, 17684);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 17642, 17661);

                            return f_10838_17649_17660(call);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 17437, 17684);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 16813, 17703);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 17723, 17735);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 16726, 17750);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10838_17649_17660(Microsoft.CodeAnalysis.CSharp.BoundCall
                    this_param)
                    {
                        var return_v = this_param.Method;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10838, 17649, 17660);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 16672, 17761);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 16672, 17761);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal DeconstructMethodInfo DeconstructionInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 17847, 18053);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 17883, 17945);

                    var
                    uncommonData = (DeconstructionUncommonData?)_uncommonData
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 17963, 18038);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10838, 17970, 17990) || ((uncommonData == null && DynAbs.Tracing.TraceSender.Conditional_F2(10838, 17993, 18000)) || DynAbs.Tracing.TraceSender.Conditional_F3(10838, 18003, 18037))) ? default : uncommonData.DeconstructMethodInfo;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 17847, 18053);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 17773, 18064);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 17773, 18064);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsValid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 18152, 19007);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 18188, 18278) || true) && (f_10838_18192_18204_M(!this.Exists))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 18188, 18278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 18246, 18259);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 18188, 18278);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 18300, 18364);

                    var
                    nestedConversionsOpt = DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_uncommonData, 10838, 18327, 18363)?._nestedConversionsOpt
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 18382, 18796) || true) && (nestedConversionsOpt != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 18382, 18796);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 18456, 18685);
                            foreach (var conv in f_10838_18477_18497_I(nestedConversionsOpt))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 18456, 18685);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 18547, 18662) || true) && (f_10838_18551_18564_M(!conv.IsValid))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 18547, 18662);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 18622, 18635);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 18547, 18662);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 18456, 18685);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10838, 1, 230);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10838, 1, 230);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 18709, 18743);

                        f_10838_18709_18742(f_10838_18722_18741_M(!this.IsUserDefined));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 18765, 18777);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 18382, 18796);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 18816, 18992);

                    return f_10838_18823_18842_M(!this.IsUserDefined) || (DynAbs.Tracing.TraceSender.Expression_False(10838, 18823, 18888) || this.Method is object) || (DynAbs.Tracing.TraceSender.Expression_False(10838, 18823, 18991) || DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_uncommonData, 10838, 18913, 18950)?._conversionResult.Kind == UserDefinedConversionResultKind.Valid);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 18152, 19007);

                    bool
                    f_10838_18192_18204_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10838, 18192, 18204);
                        return return_v;
                    }


                    bool
                    f_10838_18551_18564_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10838, 18551, 18564);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>?
                    f_10838_18477_18497_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 18477, 18497);
                        return return_v;
                    }


                    bool
                    f_10838_18722_18741_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10838, 18722, 18741);
                        return return_v;
                    }


                    int
                    f_10838_18709_18742(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 18709, 18742);
                        return 0;
                    }


                    bool
                    f_10838_18823_18842_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10838, 18823, 18842);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 18106, 19018);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 18106, 19018);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool Exists
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 19460, 19554);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 19496, 19539);

                    return Kind != ConversionKind.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 19460, 19554);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 19417, 19565);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 19417, 19565);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 19872, 19958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 19908, 19943);

                    return f_10838_19915_19942(Kind);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 19872, 19958);

                    bool
                    f_10838_19915_19942(Microsoft.CodeAnalysis.CSharp.ConversionKind
                    conversionKind)
                    {
                        var return_v = conversionKind.IsImplicitConversion();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 19915, 19942);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 19825, 19969);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 19825, 19969);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsExplicit
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 20276, 20425);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 20381, 20410);

                    return Exists && (DynAbs.Tracing.TraceSender.Expression_True(10838, 20388, 20409) && f_10838_20398_20409_M(!IsImplicit));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 20276, 20425);

                    bool
                    f_10838_20398_20409_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10838, 20398, 20409);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 20229, 20436);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 20229, 20436);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 20759, 20849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 20795, 20834);

                    return Kind == ConversionKind.Identity;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 20759, 20849);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 20712, 20860);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 20712, 20860);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsStackAlloc
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 21040, 21192);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 21076, 21177);

                    return Kind == ConversionKind.StackAllocToPointerType || (DynAbs.Tracing.TraceSender.Expression_False(10838, 21083, 21176) || Kind == ConversionKind.StackAllocToSpanType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 21040, 21192);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 20991, 21203);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 20991, 21203);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 21597, 21736);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 21633, 21721);

                    return Kind == ConversionKind.ImplicitNumeric || (DynAbs.Tracing.TraceSender.Expression_False(10838, 21640, 21720) || Kind == ConversionKind.ExplicitNumeric);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 21597, 21736);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 21551, 21747);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 21551, 21747);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsEnumeration
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 22156, 22303);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 22192, 22288);

                    return Kind == ConversionKind.ImplicitEnumeration || (DynAbs.Tracing.TraceSender.Expression_False(10838, 22199, 22287) || Kind == ConversionKind.ExplicitEnumeration);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 22156, 22303);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 22106, 22314);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 22106, 22314);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsThrow
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 22494, 22589);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 22530, 22574);

                    return Kind == ConversionKind.ImplicitThrow;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 22494, 22589);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 22450, 22600);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 22450, 22600);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsObjectCreation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 22812, 22908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 22848, 22893);

                    return Kind == ConversionKind.ObjectCreation;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 22812, 22908);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 22757, 22919);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 22757, 22919);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsSwitchExpression
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 23122, 23220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 23158, 23205);

                    return Kind == ConversionKind.SwitchExpression;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 23122, 23220);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 23067, 23231);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 23067, 23231);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsConditionalExpression
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 23444, 23547);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 23480, 23532);

                    return Kind == ConversionKind.ConditionalExpression;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 23444, 23547);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 23384, 23558);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 23384, 23558);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsInterpolatedString
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 23982, 24082);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 24018, 24067);

                    return Kind == ConversionKind.InterpolatedString;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 23982, 24082);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 23925, 24093);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 23925, 24093);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 24490, 24631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 24526, 24616);

                    return Kind == ConversionKind.ImplicitNullable || (DynAbs.Tracing.TraceSender.Expression_False(10838, 24533, 24615) || Kind == ConversionKind.ExplicitNullable);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 24490, 24631);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 24443, 24642);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 24443, 24642);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsTupleLiteralConversion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 24884, 25033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 24920, 25018);

                    return Kind == ConversionKind.ImplicitTupleLiteral || (DynAbs.Tracing.TraceSender.Expression_False(10838, 24927, 25017) || Kind == ConversionKind.ExplicitTupleLiteral);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 24884, 25033);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 24823, 25044);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 24823, 25044);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsTupleConversion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 25263, 25398);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 25299, 25383);

                    return Kind == ConversionKind.ImplicitTuple || (DynAbs.Tracing.TraceSender.Expression_False(10838, 25306, 25382) || Kind == ConversionKind.ExplicitTuple);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 25263, 25398);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 25209, 25409);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 25209, 25409);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 25810, 25953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 25846, 25938);

                    return Kind == ConversionKind.ImplicitReference || (DynAbs.Tracing.TraceSender.Expression_False(10838, 25853, 25937) || Kind == ConversionKind.ExplicitReference);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 25810, 25953);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 25762, 25964);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 25762, 25964);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsUserDefined
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 26363, 26452);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 26399, 26437);

                    return f_10838_26406_26436(Kind);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 26363, 26452);

                    bool
                    f_10838_26406_26436(Microsoft.CodeAnalysis.CSharp.ConversionKind
                    conversionKind)
                    {
                        var return_v = conversionKind.IsUserDefinedConversion();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 26406, 26436);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 26313, 26463);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 26313, 26463);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsBoxing
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 26798, 26886);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 26834, 26871);

                    return Kind == ConversionKind.Boxing;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 26798, 26886);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 26753, 26897);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 26753, 26897);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsUnboxing
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 27237, 27327);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 27273, 27312);

                    return Kind == ConversionKind.Unboxing;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 27237, 27327);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 27190, 27338);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 27190, 27338);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsNullLiteral
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 27681, 27774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 27717, 27759);

                    return Kind == ConversionKind.NullLiteral;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 27681, 27774);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 27631, 27785);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 27631, 27785);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsDefaultLiteral
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 27984, 28080);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 28020, 28065);

                    return Kind == ConversionKind.DefaultLiteral;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 27984, 28080);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 27931, 28091);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 27931, 28091);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsDynamic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 28430, 28505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 28466, 28490);

                    return f_10838_28473_28489(Kind);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 28430, 28505);

                    bool
                    f_10838_28473_28489(Microsoft.CodeAnalysis.CSharp.ConversionKind
                    conversionKind)
                    {
                        var return_v = conversionKind.IsDynamic();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 28473, 28489);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 28384, 28516);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 28384, 28516);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsConstantExpression
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 28889, 28987);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 28925, 28972);

                    return Kind == ConversionKind.ImplicitConstant;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 28889, 28987);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 28832, 28998);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 28832, 28998);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsAnonymousFunction
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 29366, 29465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 29402, 29450);

                    return Kind == ConversionKind.AnonymousFunction;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 29366, 29465);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 29310, 29476);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 29310, 29476);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsMethodGroup
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 29826, 29919);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 29862, 29904);

                    return Kind == ConversionKind.MethodGroup;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 29826, 29919);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 29776, 29930);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 29776, 29930);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsPointer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 30911, 31001);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 30947, 30986);

                    return f_10838_30954_30985(this.Kind);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 30911, 31001);

                    bool
                    f_10838_30954_30985(Microsoft.CodeAnalysis.CSharp.ConversionKind
                    kind)
                    {
                        var return_v = kind.IsPointerConversion();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 30954, 30985);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 30865, 31012);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 30865, 31012);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsIntPtr
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 31584, 31672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 31620, 31657);

                    return Kind == ConversionKind.IntPtr;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 31584, 31672);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 31539, 31683);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 31539, 31683);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IMethodSymbol? MethodSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 32346, 32434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 32382, 32419);

                    return f_10838_32389_32418(this.Method);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 32346, 32434);

                    Microsoft.CodeAnalysis.IMethodSymbol?
                    f_10838_32389_32418(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 32389, 32418);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 32287, 32445);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 32287, 32445);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal LookupResultKind ResultKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 32878, 34397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 32914, 33010);

                    var
                    conversionResult = DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_uncommonData, 10838, 32937, 32969)?._conversionResult ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResult?>(10838, 32937, 33009) ?? default(UserDefinedConversionResult))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 33030, 34382);

                    switch (conversionResult.Kind)
                    {

                        case UserDefinedConversionResultKind.Valid:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 33030, 34382);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 33170, 33201);

                            return LookupResultKind.Viable;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 33030, 34382);

                        case UserDefinedConversionResultKind.Ambiguous:
                        case UserDefinedConversionResultKind.NoBestSourceType:
                        case UserDefinedConversionResultKind.NoBestTargetType:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 33030, 34382);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 33448, 33498);

                            return LookupResultKind.OverloadResolutionFailure;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 33030, 34382);

                        case UserDefinedConversionResultKind.NoApplicableOperators:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 33030, 34382);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 33605, 34243) || true) && (conversionResult.Results.IsDefaultOrEmpty)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 33605, 34243);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 33708, 33807);

                                return (DynAbs.Tracing.TraceSender.Conditional_F1(10838, 33715, 33755) || ((this.Kind == ConversionKind.NoConversion && DynAbs.Tracing.TraceSender.Conditional_F2(10838, 33758, 33780)) || DynAbs.Tracing.TraceSender.Conditional_F3(10838, 33783, 33806))) ? LookupResultKind.Empty : LookupResultKind.Viable;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 33605, 34243);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 33605, 34243);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 34166, 34216);

                                return LookupResultKind.OverloadResolutionFailure;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 33605, 34243);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 33030, 34382);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 33030, 34382);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 34299, 34363);

                            throw f_10838_34305_34362(conversionResult.Kind);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 33030, 34382);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 32878, 34397);

                    System.Exception
                    f_10838_34305_34362(Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResultKind
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 34305, 34362);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 32817, 34408);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 32817, 34408);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Conversion UserDefinedFromConversion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 34612, 34823);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 34648, 34720);

                    UserDefinedConversionAnalysis?
                    best = BestUserDefinedConversionAnalysis
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 34738, 34808);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10838, 34745, 34757) || ((best == null && DynAbs.Tracing.TraceSender.Conditional_F2(10838, 34760, 34783)) || DynAbs.Tracing.TraceSender.Conditional_F3(10838, 34786, 34807))) ? Conversion.NoConversion : best.SourceConversion;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 34612, 34823);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 34542, 34834);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 34542, 34834);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Conversion UserDefinedToConversion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 35039, 35250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 35075, 35147);

                    UserDefinedConversionAnalysis?
                    best = BestUserDefinedConversionAnalysis
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 35165, 35235);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10838, 35172, 35184) || ((best == null && DynAbs.Tracing.TraceSender.Conditional_F2(10838, 35187, 35210)) || DynAbs.Tracing.TraceSender.Conditional_F3(10838, 35213, 35234))) ? Conversion.NoConversion : best.TargetConversion;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 35039, 35250);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 34971, 35261);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 34971, 35261);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<MethodSymbol> OriginalUserDefinedConversions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 35564, 36767);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 36058, 36186) || true) && (_uncommonData == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 36058, 36186);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 36125, 36167);

                        return ImmutableArray<MethodSymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 36058, 36186);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 36206, 36261);

                    var
                    conversionResult = _uncommonData._conversionResult
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 36279, 36464) || true) && (conversionResult.Kind == UserDefinedConversionResultKind.NoApplicableOperators)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 36279, 36464);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 36403, 36445);

                        return ImmutableArray<MethodSymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 36279, 36464);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 36484, 36539);

                    var
                    builder = f_10838_36498_36538()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 36557, 36698);
                        foreach (var analysis in f_10838_36582_36606_I(conversionResult.Results))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 36557, 36698);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 36648, 36679);

                            f_10838_36648_36678(builder, analysis.Operator);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 36557, 36698);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10838, 1, 142);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10838, 1, 142);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 36716, 36752);

                    return f_10838_36723_36751(builder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 35564, 36767);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    f_10838_36498_36538()
                    {
                        var return_v = ArrayBuilder<MethodSymbol>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 36498, 36538);
                        return return_v;
                    }


                    int
                    f_10838_36648_36678(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 36648, 36678);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                    f_10838_36582_36606_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 36582, 36606);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    f_10838_36723_36751(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 36723, 36751);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 35471, 36778);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 35471, 36778);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal UserDefinedConversionAnalysis? BestUserDefinedConversionAnalysis
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 36888, 37418);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 36924, 37022) || true) && (_uncommonData == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 36924, 37022);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 36991, 37003);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 36924, 37022);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 37042, 37097);

                    var
                    conversionResult = _uncommonData._conversionResult
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 37117, 37371) || true) && (conversionResult.Kind == UserDefinedConversionResultKind.Valid)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 37117, 37371);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 37225, 37314);

                        UserDefinedConversionAnalysis
                        analysis = conversionResult.Results[conversionResult.Best]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 37336, 37352);

                        return analysis;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 37117, 37371);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 37391, 37403);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 36888, 37418);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 36790, 37429);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 36790, 37429);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CommonConversion ToCommonConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 37888, 38258);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 38068, 38123);

                var
                methodSymbol = (DynAbs.Tracing.TraceSender.Conditional_F1(10838, 38087, 38100) || ((IsUserDefined && DynAbs.Tracing.TraceSender.Conditional_F2(10838, 38103, 38115)) || DynAbs.Tracing.TraceSender.Conditional_F3(10838, 38118, 38122))) ? MethodSymbol : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 38137, 38247);

                return f_10838_38144_38246(Exists, IsIdentity, IsNumeric, IsReference, IsImplicit, IsNullable, methodSymbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 37888, 38258);

                Microsoft.CodeAnalysis.Operations.CommonConversion
                f_10838_38144_38246(bool
                exists, bool
                isIdentity, bool
                isNumeric, bool
                isReference, bool
                isImplicit, bool
                isNullable, Microsoft.CodeAnalysis.IMethodSymbol?
                methodSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.Operations.CommonConversion(exists, isIdentity, isNumeric, isReference, isImplicit, isNullable, methodSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 38144, 38246);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 37888, 38258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 37888, 38258);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 38504, 38601);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 38562, 38590);

                return f_10838_38569_38589(this.Kind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 38504, 38601);

                string
                f_10838_38569_38589(Microsoft.CodeAnalysis.CSharp.ConversionKind
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 38569, 38589);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 38504, 38601);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 38504, 38601);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 39092, 39225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 39157, 39214);

                return obj is Conversion && (DynAbs.Tracing.TraceSender.Expression_True(10838, 39164, 39213) && this.Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 39092, 39225);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 39092, 39225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 39092, 39225);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(Conversion other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 39718, 39852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 39779, 39841);

                return this.Kind == other.Kind && (DynAbs.Tracing.TraceSender.Expression_True(10838, 39786, 39840) && this.Method == other.Method);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 39718, 39852);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 39718, 39852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 39718, 39852);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 40086, 40204);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 40144, 40193);

                return f_10838_40151_40192(this.Method, this.Kind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 40086, 40204);

                int
                f_10838_40151_40192(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                newKeyPart, Microsoft.CodeAnalysis.CSharp.ConversionKind
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, (int)currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 40151, 40192);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 40086, 40204);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 40086, 40204);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(Conversion left, Conversion right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10838, 40571, 40698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 40661, 40687);

                return left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10838, 40571, 40698);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 40571, 40698);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 40571, 40698);
            }
        }

        public static bool operator !=(Conversion left, Conversion right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10838, 41065, 41190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 41155, 41179);

                return !(left == right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10838, 41065, 41190);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 41065, 41190);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 41065, 41190);
            }
        }

        internal string Dump()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 41213, 42383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 41260, 41302);

                return f_10838_41267_41301(Dump(this));

                TreeDumperNode Dump(Conversion self)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 41318, 42372);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 41387, 41451);

                        var
                        sub = f_10838_41397_41450()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 41471, 41632) || true) && (self.Method is object)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 41471, 41632);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 41538, 41613);

                            f_10838_41538_41612(sub, f_10838_41546_41611("method", f_10838_41575_41604(self.Method), null));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 41471, 41632);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 41652, 41916) || true) && (f_10838_41656_41690_M(!self.DeconstructionInfo.IsDefault))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 41652, 41916);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 41732, 41897);

                            f_10838_41732_41896(sub, f_10838_41740_41895("deconstructionInfo", null, new[] { f_10838_41820_41892(self.DeconstructionInfo.Invocation) }));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 41652, 41916);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 41936, 41991);

                        var
                        underlyingConversions = self.UnderlyingConversions
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 42009, 42281) || true) && (f_10838_42013_42052_M(!underlyingConversions.IsDefaultOrEmpty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10838, 42009, 42281);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 42094, 42262);

                            f_10838_42094_42261(sub, f_10838_42102_42260($"underlyingConversions[{underlyingConversions.Length}]", null, underlyingConversions.SelectAsArray(c => Dump(c))));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10838, 42009, 42281);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 42301, 42357);

                        return f_10838_42308_42356("conversion", self.Kind, sub);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 41318, 42372);

                        System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>
                        f_10838_41397_41450()
                        {
                            var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 41397, 41450);
                            return return_v;
                        }


                        string
                        f_10838_41575_41604(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ToDisplayString();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 41575, 41604);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.TreeDumperNode
                        f_10838_41546_41611(string
                        text, string
                        value, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>?
                        children)
                        {
                            var return_v = new Microsoft.CodeAnalysis.TreeDumperNode(text, (object)value, children);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 41546, 41611);
                            return return_v;
                        }


                        int
                        f_10838_41538_41612(System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>
                        this_param, Microsoft.CodeAnalysis.TreeDumperNode
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 41538, 41612);
                            return 0;
                        }


                        bool
                        f_10838_41656_41690_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10838, 41656, 41690);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.TreeDumperNode
                        f_10838_41820_41892(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        node)
                        {
                            var return_v = BoundTreeDumperNodeProducer.MakeTree((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 41820, 41892);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.TreeDumperNode
                        f_10838_41740_41895(string
                        text, object?
                        value, Microsoft.CodeAnalysis.TreeDumperNode[]
                        children)
                        {
                            var return_v = new Microsoft.CodeAnalysis.TreeDumperNode(text, value, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>)children);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 41740, 41895);
                            return return_v;
                        }


                        int
                        f_10838_41732_41896(System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>
                        this_param, Microsoft.CodeAnalysis.TreeDumperNode
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 41732, 41896);
                            return 0;
                        }


                        bool
                        f_10838_42013_42052_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10838, 42013, 42052);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.TreeDumperNode
                        f_10838_42102_42260(string
                        text, object?
                        value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TreeDumperNode>
                        children)
                        {
                            var return_v = new Microsoft.CodeAnalysis.TreeDumperNode(text, value, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>)children);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 42102, 42260);
                            return return_v;
                        }


                        int
                        f_10838_42094_42261(System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>
                        this_param, Microsoft.CodeAnalysis.TreeDumperNode
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 42094, 42261);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.TreeDumperNode
                        f_10838_42308_42356(string
                        text, Microsoft.CodeAnalysis.CSharp.ConversionKind
                        value, System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>
                        children)
                        {
                            var return_v = new Microsoft.CodeAnalysis.TreeDumperNode(text, (object)value, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>)children);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 42308, 42356);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 41318, 42372);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 41318, 42372);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 41213, 42383);

                string
                f_10838_41267_41301(Microsoft.CodeAnalysis.TreeDumperNode
                root)
                {
                    var return_v = TreeDumper.DumpCompact(root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 41267, 41301);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 41213, 42383);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 41213, 42383);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static Conversion()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10838, 676, 42398);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10838, 676, 42398);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 676, 42398);
        }

        static Microsoft.CodeAnalysis.CSharp.ConversionKind
        f_10838_3607_3611_C(Microsoft.CodeAnalysis.CSharp.ConversionKind
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10838, 3547, 3640);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion.UncommonData
        f_10838_4029_4266(bool
        isExtensionMethod, bool
        isArrayIndex, Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResult
        conversionResult, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
        conversionMethod, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
        nestedConversions)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion.UncommonData(isExtensionMethod: isExtensionMethod, isArrayIndex: isArrayIndex, conversionResult: conversionResult, conversionMethod: conversionMethod, nestedConversions: nestedConversions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 4029, 4266);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion.UncommonData
        f_10838_4532_4784(bool
        isExtensionMethod, bool
        isArrayIndex, Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResult
        conversionResult, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        conversionMethod, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
        nestedConversions)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion.UncommonData(isExtensionMethod: isExtensionMethod, isArrayIndex: isArrayIndex, conversionResult: conversionResult, conversionMethod: conversionMethod, nestedConversions: nestedConversions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 4532, 4784);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion.UncommonData
        f_10838_4967_5205(bool
        isExtensionMethod, bool
        isArrayIndex, Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResult
        conversionResult, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
        conversionMethod, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
        nestedConversions)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion.UncommonData(isExtensionMethod: isExtensionMethod, isArrayIndex: isArrayIndex, conversionResult: conversionResult, conversionMethod: conversionMethod, nestedConversions: nestedConversions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 4967, 5205);
            return return_v;
        }


        static int
        f_10838_5385_5436(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 5385, 5436);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion.DeconstructionUncommonData
        f_10838_5501_5573(Microsoft.CodeAnalysis.CSharp.DeconstructMethodInfo
        deconstructMethodInfoOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
        nestedConversions)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion.DeconstructionUncommonData(deconstructMethodInfoOpt, nestedConversions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 5501, 5573);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_8820_8870(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 8820, 8870);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_8924_8967(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 8924, 8967);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_9017_9056(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 9017, 9056);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_9114_9161(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 9114, 9161);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_9218_9264(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 9218, 9264);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_9323_9371(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 9323, 9371);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_9432_9482(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 9432, 9482);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_9537_9581(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 9537, 9581);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_9637_9682(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 9637, 9682);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_9741_9789(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 9741, 9789);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_9837_9874(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 9837, 9874);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_9927_9969(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 9927, 9969);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_10025_10070(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 10025, 10070);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_10125_10177(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 10125, 10177);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_10232_10284(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 10232, 10284);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_10342_10397(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 10342, 10397);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_10455_10510(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 10455, 10510);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_10568_10623(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 10568, 10623);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_10673_10712(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 10673, 10712);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_10771_10819(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 10771, 10819);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_10867_10904(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 10867, 10904);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_10965_11015(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 10965, 11015);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_11072_11118(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 11072, 11118);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_11175_11221(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 11175, 11221);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_11278_11324(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 11278, 11324);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_11384_11433(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 11384, 11433);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_11489_11534(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 11489, 11534);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_11597_11649(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 11597, 11649);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Conversion
        f_10838_11706_11752(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10838, 11706, 11752);
            return return_v;
        }

    }

    internal struct DeconstructMethodInfo
    {

        internal DeconstructMethodInfo(BoundExpression invocation, BoundDeconstructValuePlaceholder inputPlaceholder,
                    ImmutableArray<BoundDeconstructValuePlaceholder> outputPlaceholders)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10838, 42562, 42893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 42778, 42882);

                (Invocation, InputPlaceholder, OutputPlaceholders) = (invocation, inputPlaceholder, outputPlaceholders);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10838, 42562, 42893);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 42562, 42893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 42562, 42893);
            }
        }

        internal readonly BoundExpression Invocation;

        internal readonly BoundDeconstructValuePlaceholder InputPlaceholder;

        internal readonly ImmutableArray<BoundDeconstructValuePlaceholder> OutputPlaceholders;

        internal bool IsDefault
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10838, 43158, 43179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10838, 43161, 43179);
                    return Invocation is null; DynAbs.Tracing.TraceSender.TraceExitMethod(10838, 43158, 43179);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10838, 43158, 43179);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 43158, 43179);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
        static DeconstructMethodInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10838, 42508, 43187);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10838, 42508, 43187);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10838, 42508, 43187);
        }
    }
}
