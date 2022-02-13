// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using System;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{

    internal readonly struct CSharpTypeInfo : IEquatable<CSharpTypeInfo>
    {

        internal static readonly CSharpTypeInfo None;

        public readonly TypeSymbol Type;

        public readonly NullabilityInfo Nullability;

        public readonly TypeSymbol ConvertedType;

        public readonly NullabilityInfo ConvertedNullability;

        public readonly Conversion ImplicitConversion;

        internal CSharpTypeInfo(TypeSymbol type, TypeSymbol convertedType, NullabilityInfo nullability, NullabilityInfo convertedNullability, Conversion implicitConversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10932, 1733, 2525);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10932, 2218, 2262);

                this.Type = f_10932_2230_2253(type) ?? 
                    (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10932, 2230, 2261) ?? type);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10932, 2276, 2347);

                this.ConvertedType = f_10932_2297_2329(convertedType) ?? 
                    (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10932, 2297, 2346) ?? convertedType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10932, 2361, 2392);

                this.Nullability = nullability;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10932, 2406, 2455);

                this.ConvertedNullability = convertedNullability;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10932, 2469, 2514);

                this.ImplicitConversion = implicitConversion;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10932, 1733, 2525);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10932, 1733, 2525);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10932, 1733, 2525);
            }
        }

        public static implicit operator TypeInfo(CSharpTypeInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10932, 2537, 2890);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10932, 2623, 2879);

                return f_10932_2630_2878(
                    f_10932_2643_2711_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(info.Type, 10932, 2643, 2711)
                    .GetITypeSymbol(f_10932_2669_2710(info.Nullability.FlowState))), 
                    f_10932_2713_2799_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(info.ConvertedType, 10932, 2713, 2799)
                    .GetITypeSymbol(f_10932_2748_2798(info.ConvertedNullability.FlowState))), info.Nullability, info.ConvertedNullability);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10932, 2537, 2890);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10932_2669_2710(Microsoft.CodeAnalysis.NullableFlowState
                nullableFlowState)
                {
                    var return_v = nullableFlowState.ToAnnotation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10932, 2669, 2710);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_10932_2643_2711_I(Microsoft.CodeAnalysis.ITypeSymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10932, 2643, 2711);
                    return return_v;
                }


                Microsoft.CodeAnalysis.NullableAnnotation
                f_10932_2748_2798(Microsoft.CodeAnalysis.NullableFlowState
                nullableFlowState)
                {
                    var return_v = nullableFlowState.ToAnnotation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10932, 2748, 2798);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_10932_2713_2799_I(Microsoft.CodeAnalysis.ITypeSymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10932, 2713, 2799);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeInfo
                f_10932_2630_2878(Microsoft.CodeAnalysis.ITypeSymbol?
                type, Microsoft.CodeAnalysis.ITypeSymbol?
                convertedType, Microsoft.CodeAnalysis.NullabilityInfo
                nullability, Microsoft.CodeAnalysis.NullabilityInfo
                convertedNullability)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypeInfo(type, convertedType, nullability, convertedNullability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10932, 2630, 2878);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10932, 2537, 2890);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10932, 2537, 2890);
            }
        }
        public override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10932, 2902, 3037);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10932, 2966, 3026);

                return obj is CSharpTypeInfo && (DynAbs.Tracing.TraceSender.Expression_True(10932, 2973, 3025) && Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10932, 2902, 3037);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10932, 2902, 3037);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10932, 2902, 3037);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(CSharpTypeInfo other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10932, 3049, 3547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10932, 3114, 3536);

                return this.ImplicitConversion.Equals(other.ImplicitConversion) && (DynAbs.Tracing.TraceSender.Expression_True(10932, 3121, 3275) && f_10932_3198_3275(this.Type, other.Type, TypeCompareKind.ConsiderEverything2)) && (DynAbs.Tracing.TraceSender.Expression_True(10932, 3121, 3391) && f_10932_3296_3391(this.ConvertedType, other.ConvertedType, TypeCompareKind.ConsiderEverything2)) && (DynAbs.Tracing.TraceSender.Expression_True(10932, 3121, 3454) && this.Nullability.Equals(other.Nullability)) && (DynAbs.Tracing.TraceSender.Expression_True(10932, 3121, 3535) && this.ConvertedNullability.Equals(other.ConvertedNullability));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10932, 3049, 3547);

                bool
                f_10932_3198_3275(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10932, 3198, 3275);
                    return return_v;
                }


                bool
                f_10932_3296_3391(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10932, 3296, 3391);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10932, 3049, 3547);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10932, 3049, 3547);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10932, 3559, 4043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10932, 3617, 4032);

                return f_10932_3624_4031(this.ConvertedType, f_10932_3690_4030(this.Type, f_10932_3760_4029(this.Nullability.GetHashCode(), f_10932_3864_4028(this.ConvertedNullability.GetHashCode(), this.ImplicitConversion.GetHashCode()))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10932, 3559, 4043);

                int
                f_10932_3864_4028(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10932, 3864, 4028);
                    return return_v;
                }


                int
                f_10932_3760_4029(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10932, 3760, 4029);
                    return return_v;
                }


                int
                f_10932_3690_4030(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10932, 3690, 4030);
                    return return_v;
                }


                int
                f_10932_3624_4031(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10932, 3624, 4031);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10932, 3559, 4043);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10932, 3559, 4043);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static CSharpTypeInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10932, 365, 4050);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10932, 490, 622);
            None = f_10932_497_622(type: null, convertedType: null, nullability: default, convertedNullability: default, Conversion.Identity); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10932, 365, 4050);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10932, 365, 4050);
        }

        static Microsoft.CodeAnalysis.CSharp.CSharpTypeInfo
        f_10932_497_622(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        type, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        convertedType, Microsoft.CodeAnalysis.NullabilityInfo
        nullability, Microsoft.CodeAnalysis.NullabilityInfo
        convertedNullability, Microsoft.CodeAnalysis.CSharp.Conversion
        implicitConversion)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpTypeInfo(type: type, convertedType: convertedType, nullability: nullability, convertedNullability: convertedNullability, implicitConversion);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10932, 497, 622);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
        f_10932_2230_2253(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        type)
        {
            var return_v = type.GetNonErrorGuess();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10932, 2230, 2253);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
        f_10932_2297_2329(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        type)
        {
            var return_v = type.GetNonErrorGuess();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10932, 2297, 2329);
            return return_v;
        }

    }
}
