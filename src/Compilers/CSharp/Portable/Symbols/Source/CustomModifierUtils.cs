// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE;
using Microsoft.CodeAnalysis.PooledObjects;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal static class CustomModifierUtils
    {
        internal static void CopyMethodCustomModifiers(
                    MethodSymbol sourceMethod,
                    MethodSymbol destinationMethod,
                    out TypeWithAnnotations returnType,
                    out ImmutableArray<CustomModifier> customModifiers,
                    out ImmutableArray<ParameterSymbol> parameters,
                    bool alsoCopyParamsModifier) // Last since always named.
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10225, 740, 3432);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 1142, 1185);

                f_10225_1142_1184((object)sourceMethod != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 1284, 1351);

                f_10225_1284_1350((object)sourceMethod == f_10225_1321_1349(sourceMethod));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 1846, 1965);

                MethodSymbol
                constructedSourceMethod = sourceMethod.ConstructIfGeneric(f_10225_1917_1963(destinationMethod))
                ;
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 1885, 1964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 1981, 2142);

                customModifiers =
                (DynAbs.Tracing.TraceSender.Conditional_F1(10225, 2016, 2057) || ((f_10225_2016_2041(destinationMethod) != RefKind.None && DynAbs.Tracing.TraceSender.Conditional_F2(10225, 2060, 2102)) || DynAbs.Tracing.TraceSender.Conditional_F3(10225, 2105, 2141))) ? f_10225_2060_2102(constructedSourceMethod) : ImmutableArray<CustomModifier>.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 2158, 2290);

                parameters = f_10225_2171_2289(f_10225_2200_2234(constructedSourceMethod), f_10225_2236_2264(destinationMethod), alsoCopyParamsModifier);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 2306, 2363);

                returnType = f_10225_2319_2362(destinationMethod);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 2440, 2486);

                TypeSymbol
                returnTypeSymbol = returnType.Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 2502, 2581);

                var
                sourceMethodReturnType = f_10225_2531_2580(constructedSourceMethod)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 2950, 3021);

                TypeSymbol
                returnTypeWithCustomModifiers = sourceMethodReturnType.Type
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 3035, 3421) || true) && (f_10225_3039_3127(returnTypeSymbol, returnTypeWithCustomModifiers, TypeCompareKind.AllIgnoreOptions))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10225, 3035, 3421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 3161, 3406);

                    returnType = returnType.WithTypeAndModifiers(f_10225_3206_3316(returnTypeWithCustomModifiers, returnTypeSymbol, f_10225_3279_3315(destinationMethod)), sourceMethodReturnType.CustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10225, 3035, 3421);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10225, 740, 3432);

                int
                f_10225_1142_1184(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 1142, 1184);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10225_1321_1349(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10225, 1321, 1349);
                    return return_v;
                }


                int
                f_10225_1284_1350(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 1284, 1350);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10225_1917_1963(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10225, 1917, 1963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10225_2016_2041(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10225, 2016, 2041);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10225_2060_2102(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10225, 2060, 2102);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10225_2200_2234(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10225, 2200, 2234);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10225_2236_2264(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10225, 2236, 2264);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10225_2171_2289(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                sourceParameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                destinationParameters, bool
                alsoCopyParamsModifier)
                {
                    var return_v = CopyParameterCustomModifiers(sourceParameters, destinationParameters, alsoCopyParamsModifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 2171, 2289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10225_2319_2362(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10225, 2319, 2362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10225_2531_2580(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10225, 2531, 2580);
                    return return_v;
                }


                bool
                f_10225_3039_3127(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 3039, 3127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10225_3279_3315(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10225, 3279, 3315);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10225_3206_3316(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                sourceType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destinationType, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                containingAssembly)
                {
                    var return_v = CopyTypeCustomModifiers(sourceType, destinationType, containingAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 3206, 3316);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10225, 740, 3432);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10225, 740, 3432);
            }
        }

        internal static TypeSymbol CopyTypeCustomModifiers(TypeSymbol sourceType, TypeSymbol destinationType, AssemblySymbol containingAssembly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10225, 4018, 7140);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 4179, 4262);

                f_10225_4179_4261(f_10225_4192_4260(sourceType, destinationType, TypeCompareKind.AllIgnoreOptions));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 4278, 4315);

                const RefKind
                refKind = RefKind.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 4623, 4754);

                ImmutableArray<bool>
                flags = f_10225_4652_4753(destinationType, refKind)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 4768, 4899);

                TypeSymbol
                resultType = DynamicTypeDecoder.TransformTypeWithoutCustomModifierFlags(sourceType, containingAssembly, refKind, flags)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 4915, 4962);

                var
                builder = f_10225_4929_4961()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 4976, 5058);

                f_10225_4976_5057(builder, destinationType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 5072, 5166);

                resultType = NativeIntegerTypeDecoder.TransformType(resultType, f_10225_5136_5164(builder));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 5182, 5724) || true) && (f_10225_5186_5217(destinationType) && (DynAbs.Tracing.TraceSender.Expression_True(10225, 5186, 5413) && !f_10225_5222_5413(sourceType, destinationType, TypeCompareKind.IgnoreCustomModifiersAndArraySizesAndLowerBounds | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes | TypeCompareKind.IgnoreDynamic)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10225, 5182, 5724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 5522, 5613);

                    ImmutableArray<string>
                    names = f_10225_5553_5612(destinationType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 5631, 5709);

                    resultType = TupleTypeDecoder.DecodeTupleTypesIfApplicable(resultType, names);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10225, 5182, 5724);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 6194, 6246);

                var
                flagsBuilder = f_10225_6213_6245()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 6260, 6312);

                f_10225_6260_6311(destinationType, flagsBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 6326, 6343);

                int
                position = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 6357, 6389);

                int
                length = f_10225_6370_6388(flagsBuilder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 6403, 6551);

                bool
                transformResult = f_10225_6426_6550(resultType, defaultTransformFlag: 0, f_10225_6486_6519(flagsBuilder), ref position, out resultType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 6565, 6617);

                f_10225_6565_6616(transformResult && (DynAbs.Tracing.TraceSender.Expression_True(10225, 6578, 6615) && position == length));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 6633, 6819);

                f_10225_6633_6818(f_10225_6646_6817(resultType, sourceType, TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes | TypeCompareKind.IgnoreNativeIntegers));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 6980, 7095);

                f_10225_6980_7094(f_10225_6993_7093(resultType, destinationType, TypeCompareKind.IgnoreCustomModifiersAndArraySizesAndLowerBounds));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 7111, 7129);

                return resultType;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10225, 4018, 7140);

                bool
                f_10225_4192_4260(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 4192, 4260);
                    return return_v;
                }


                int
                f_10225_4179_4261(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 4179, 4261);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<bool>
                f_10225_4652_4753(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = CSharpCompilation.DynamicTransformsEncoder.EncodeWithoutCustomModifierFlags(type, refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 4652, 4753);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                f_10225_4929_4961()
                {
                    var return_v = ArrayBuilder<bool>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 4929, 4961);
                    return return_v;
                }


                int
                f_10225_4976_5057(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                builder, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    CSharpCompilation.NativeIntegerTransformsEncoder.Encode(builder, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 4976, 5057);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<bool>
                f_10225_5136_5164(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 5136, 5164);
                    return return_v;
                }


                bool
                f_10225_5186_5217(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsTuple();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 5186, 5217);
                    return return_v;
                }


                bool
                f_10225_5222_5413(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 5222, 5413);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string?>
                f_10225_5553_5612(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = CSharpCompilation.TupleNamesEncoder.Encode(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 5553, 5612);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                f_10225_6213_6245()
                {
                    var return_v = ArrayBuilder<byte>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 6213, 6245);
                    return return_v;
                }


                int
                f_10225_6260_6311(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                transforms)
                {
                    this_param.AddNullableTransforms(transforms);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 6260, 6311);
                    return 0;
                }


                int
                f_10225_6370_6388(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10225, 6370, 6388);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_10225_6486_6519(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 6486, 6519);
                    return return_v;
                }


                bool
                f_10225_6426_6550(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, int
                defaultTransformFlag, System.Collections.Immutable.ImmutableArray<byte>
                transforms, ref int
                position, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                result)
                {
                    var return_v = this_param.ApplyNullableTransforms(defaultTransformFlag: (byte)defaultTransformFlag, transforms, ref position, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 6426, 6550);
                    return return_v;
                }


                int
                f_10225_6565_6616(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 6565, 6616);
                    return 0;
                }


                bool
                f_10225_6646_6817(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 6646, 6817);
                    return return_v;
                }


                int
                f_10225_6633_6818(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 6633, 6818);
                    return 0;
                }


                bool
                f_10225_6993_7093(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 6993, 7093);
                    return return_v;
                }


                int
                f_10225_6980_7094(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 6980, 7094);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10225, 4018, 7140);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10225, 4018, 7140);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<ParameterSymbol> CopyParameterCustomModifiers(ImmutableArray<ParameterSymbol> sourceParameters, ImmutableArray<ParameterSymbol> destinationParameters, bool alsoCopyParamsModifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10225, 7152, 10059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 7387, 7434);

                f_10225_7387_7433(f_10225_7400_7432_M(!destinationParameters.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 7448, 7525);

                f_10225_7448_7524(destinationParameters.All(p => p is SourceParameterSymbolBase));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 7539, 7609);

                f_10225_7539_7608(sourceParameters.Length == destinationParameters.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 7785, 7830);

                ArrayBuilder<ParameterSymbol>
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 7846, 7891);

                int
                numParams = destinationParameters.Length
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 7914, 7919);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 7905, 9954) || true) && (i < numParams)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 7936, 7939)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10225, 7905, 9954))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10225, 7905, 9954);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 7973, 8074);

                        SourceParameterSymbolBase
                        destinationParameter = (SourceParameterSymbolBase)destinationParameters[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 8092, 8146);

                        ParameterSymbol
                        sourceParameter = sourceParameters[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 8166, 9939) || true) && (sourceParameter.TypeWithAnnotations.CustomModifiers.Any() || (DynAbs.Tracing.TraceSender.Expression_False(10225, 8170, 8271) || sourceParameter.RefCustomModifiers.Any()) || (DynAbs.Tracing.TraceSender.Expression_False(10225, 8170, 8380) || f_10225_8296_8380(f_10225_8296_8316(sourceParameter), flagNonDefaultArraySizesOrLowerBounds: true)) || (DynAbs.Tracing.TraceSender.Expression_False(10225, 8170, 8467) || destinationParameter.TypeWithAnnotations.CustomModifiers.Any()) || (DynAbs.Tracing.TraceSender.Expression_False(10225, 8170, 8516) || destinationParameter.RefCustomModifiers.Any()) || (DynAbs.Tracing.TraceSender.Expression_False(10225, 8170, 8630) || f_10225_8541_8630(f_10225_8541_8566(destinationParameter), flagNonDefaultArraySizesOrLowerBounds: true)) || (DynAbs.Tracing.TraceSender.Expression_False(10225, 8170, 8807) || (alsoCopyParamsModifier && (DynAbs.Tracing.TraceSender.Expression_True(10225, 8721, 8806) && (f_10225_8748_8772(sourceParameter) != f_10225_8776_8805(destinationParameter))))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10225, 8166, 9939);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 8849, 9118) || true) && (builder == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10225, 8849, 9118);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 8918, 8972);

                                builder = f_10225_8928_8971();
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 8998, 9041);

                                f_10225_8998_9040(builder, destinationParameters, i);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10225, 8849, 9118);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 9142, 9241);

                            bool
                            newParams = (DynAbs.Tracing.TraceSender.Conditional_F1(10225, 9159, 9181) || ((alsoCopyParamsModifier && DynAbs.Tracing.TraceSender.Conditional_F2(10225, 9184, 9208)) || DynAbs.Tracing.TraceSender.Conditional_F3(10225, 9211, 9240))) ? f_10225_9184_9208(sourceParameter) : f_10225_9211_9240(destinationParameter)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 9263, 9783);

                            f_10225_9263_9782(builder, f_10225_9275_9781(destinationParameter, f_10225_9325_9345(sourceParameter), sourceParameter.TypeWithAnnotations.CustomModifiers, (DynAbs.Tracing.TraceSender.Conditional_F1(10225, 9566, 9610) || ((f_10225_9566_9594(destinationParameter) != RefKind.None && DynAbs.Tracing.TraceSender.Conditional_F2(10225, 9613, 9647)) || DynAbs.Tracing.TraceSender.Conditional_F3(10225, 9650, 9686))) ? f_10225_9613_9647(sourceParameter) : ImmutableArray<CustomModifier>.Empty, newParams));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10225, 8166, 9939);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10225, 8166, 9939);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 9825, 9939) || true) && (builder != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10225, 9825, 9939);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 9886, 9920);

                                f_10225_9886_9919(builder, destinationParameter);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10225, 9825, 9939);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10225, 8166, 9939);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10225, 1, 2050);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10225, 1, 2050);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 9970, 10048);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10225, 9977, 9992) || ((builder == null && DynAbs.Tracing.TraceSender.Conditional_F2(10225, 9995, 10016)) || DynAbs.Tracing.TraceSender.Conditional_F3(10225, 10019, 10047))) ? destinationParameters : f_10225_10019_10047(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10225, 7152, 10059);

                bool
                f_10225_7400_7432_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10225, 7400, 7432);
                    return return_v;
                }


                int
                f_10225_7387_7433(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 7387, 7433);
                    return 0;
                }


                int
                f_10225_7448_7524(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 7448, 7524);
                    return 0;
                }


                int
                f_10225_7539_7608(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 7539, 7608);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10225_8296_8316(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10225, 8296, 8316);
                    return return_v;
                }


                bool
                f_10225_8296_8380(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                flagNonDefaultArraySizesOrLowerBounds)
                {
                    var return_v = type.HasCustomModifiers(flagNonDefaultArraySizesOrLowerBounds: flagNonDefaultArraySizesOrLowerBounds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 8296, 8380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10225_8541_8566(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10225, 8541, 8566);
                    return return_v;
                }


                bool
                f_10225_8541_8630(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                flagNonDefaultArraySizesOrLowerBounds)
                {
                    var return_v = type.HasCustomModifiers(flagNonDefaultArraySizesOrLowerBounds: flagNonDefaultArraySizesOrLowerBounds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 8541, 8630);
                    return return_v;
                }


                bool
                f_10225_8748_8772(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsParams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10225, 8748, 8772);
                    return return_v;
                }


                bool
                f_10225_8776_8805(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.IsParams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10225, 8776, 8805);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10225_8928_8971()
                {
                    var return_v = ArrayBuilder<ParameterSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 8928, 8971);
                    return return_v;
                }


                int
                f_10225_8998_9040(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                items, int
                length)
                {
                    this_param.AddRange(items, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 8998, 9040);
                    return 0;
                }


                bool
                f_10225_9184_9208(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsParams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10225, 9184, 9208);
                    return return_v;
                }


                bool
                f_10225_9211_9240(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.IsParams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10225, 9211, 9240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10225_9325_9345(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10225, 9325, 9345);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10225_9566_9594(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbolBase
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10225, 9566, 9594);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10225_9613_9647(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10225, 9613, 9647);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10225_9275_9781(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbolBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                newCustomModifiers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                newRefCustomModifiers, bool
                newIsParams)
                {
                    var return_v = this_param.WithCustomModifiersAndParams(newType, newCustomModifiers, newRefCustomModifiers, newIsParams);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 9275, 9781);
                    return return_v;
                }


                int
                f_10225_9263_9782(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 9263, 9782);
                    return 0;
                }


                int
                f_10225_9886_9919(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbolBase
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 9886, 9919);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10225_10019_10047(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10225, 10019, 10047);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10225, 7152, 10059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10225, 7152, 10059);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasInAttributeModifier(this ImmutableArray<CustomModifier> modifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10225, 10071, 10332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 10186, 10321);

                return modifiers.Any(modifier => !modifier.IsOptional && ((CSharpCustomModifier)modifier).ModifierSymbol.IsWellKnownTypeInAttribute());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10225, 10071, 10332);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10225, 10071, 10332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10225, 10071, 10332);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasIsExternalInitModifier(this ImmutableArray<CustomModifier> modifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10225, 10344, 10611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 10462, 10600);

                return modifiers.Any(modifier => !modifier.IsOptional && ((CSharpCustomModifier)modifier).ModifierSymbol.IsWellKnownTypeIsExternalInit());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10225, 10344, 10611);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10225, 10344, 10611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10225, 10344, 10611);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasOutAttributeModifier(this ImmutableArray<CustomModifier> modifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10225, 10623, 10886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10225, 10739, 10875);

                return modifiers.Any(modifier => !modifier.IsOptional && ((CSharpCustomModifier)modifier).ModifierSymbol.IsWellKnownTypeOutAttribute());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10225, 10623, 10886);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10225, 10623, 10886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10225, 10623, 10886);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CustomModifierUtils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10225, 474, 10893);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10225, 474, 10893);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10225, 474, 10893);
        }

    }
}
