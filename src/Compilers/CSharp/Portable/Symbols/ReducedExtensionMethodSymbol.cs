// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class ReducedExtensionMethodSymbol : MethodSymbol
    {
        private readonly MethodSymbol _reducedFrom;

        private readonly TypeMap _typeMap;

        private readonly ImmutableArray<TypeParameterSymbol> _typeParameters;

        private readonly ImmutableArray<TypeWithAnnotations> _typeArguments;

        private ImmutableArray<ParameterSymbol> _lazyParameters;

        public static MethodSymbol Create(MethodSymbol method, TypeSymbol receiverType, CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10150, 1531, 2854);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 1666, 1757);

                f_10150_1666_1756(f_10150_1679_1703(method) && (DynAbs.Tracing.TraceSender.Expression_True(10150, 1679, 1755) && f_10150_1707_1724(method) != MethodKind.ReducedExtension));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 1771, 1811);

                f_10150_1771_1810(f_10150_1784_1805(method) > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 1825, 1868);

                f_10150_1825_1867((object)receiverType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 1884, 1934);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 1950, 2052);

                method = f_10150_1959_2051(method, receiverType, compilation, ref useSiteDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 2066, 2153) || true) && ((object)method == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 2066, 2153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 2126, 2138);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 2066, 2153);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 2169, 2245);

                var
                conversions = f_10150_2187_2244(f_10150_2207_2243(f_10150_2207_2232(method)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 2259, 2383);

                var
                conversion = f_10150_2276_2382(conversions, f_10150_2318_2343(f_10150_2318_2335(method)[0]), receiverType, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 2397, 2480) || true) && (f_10150_2401_2419_M(!conversion.Exists))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 2397, 2480);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 2453, 2465);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 2397, 2480);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 2496, 2805) || true) && (useSiteDiagnostics != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 2496, 2805);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 2560, 2790);
                        foreach (var diag in f_10150_2581_2599_I(useSiteDiagnostics))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 2560, 2790);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 2641, 2771) || true) && (f_10150_2645_2658(diag) == DiagnosticSeverity.Error)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 2641, 2771);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 2736, 2748);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 2641, 2771);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 2560, 2790);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10150, 1, 231);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10150, 1, 231);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 2496, 2805);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 2821, 2843);

                return f_10150_2828_2842(method);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10150, 1531, 2854);

                bool
                f_10150_1679_1703(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 1679, 1703);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10150_1707_1724(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 1707, 1724);
                    return return_v;
                }


                int
                f_10150_1666_1756(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 1666, 1756);
                    return 0;
                }


                int
                f_10150_1784_1805(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 1784, 1805);
                    return return_v;
                }


                int
                f_10150_1771_1810(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 1771, 1810);
                    return 0;
                }


                int
                f_10150_1825_1867(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 1825, 1867);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10150_1959_2051(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                thisType, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = InferExtensionMethodTypeArguments(method, thisType, compilation, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 1959, 2051);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10150_2207_2232(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 2207, 2232);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10150_2207_2243(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.CorLibrary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 2207, 2243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TypeConversions
                f_10150_2187_2244(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                corLibrary)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.TypeConversions(corLibrary);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 2187, 2244);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10150_2318_2335(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 2318, 2335);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10150_2318_2343(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 2318, 2343);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10150_2276_2382(Microsoft.CodeAnalysis.CSharp.TypeConversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                parameterType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                thisType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ConvertExtensionMethodThisArg(parameterType, thisType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 2276, 2382);
                    return return_v;
                }


                bool
                f_10150_2401_2419_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 2401, 2419);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10150_2645_2658(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 2645, 2658);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                f_10150_2581_2599_I(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 2581, 2599);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10150_2828_2842(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = Create(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 2828, 2842);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 1531, 2854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 1531, 2854);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MethodSymbol Create(MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10150, 2866, 3713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 2945, 3036);

                f_10150_2945_3035(f_10150_2958_2982(method) && (DynAbs.Tracing.TraceSender.Expression_True(10150, 2958, 3034) && f_10150_2986_3003(method) != MethodKind.ReducedExtension));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 3141, 3186);

                var
                constructedFrom = f_10150_3163_3185(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 3200, 3270);

                var
                reducedMethod = f_10150_3220_3269(constructedFrom)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 3286, 3385) || true) && (constructedFrom == method)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 3286, 3385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 3349, 3370);

                    return reducedMethod;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 3286, 3385);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 3561, 3620);

                f_10150_3561_3619(f_10150_3574_3618_M(!method.TypeArgumentsWithAnnotations.IsEmpty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 3634, 3702);

                return f_10150_3641_3701(reducedMethod, f_10150_3665_3700(method));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10150, 2866, 3713);

                bool
                f_10150_2958_2982(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 2958, 2982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10150_2986_3003(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 2986, 3003);
                    return return_v;
                }


                int
                f_10150_2945_3035(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 2945, 3035);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10150_3163_3185(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 3163, 3185);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ReducedExtensionMethodSymbol
                f_10150_3220_3269(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                reducedFrom)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ReducedExtensionMethodSymbol(reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 3220, 3269);
                    return return_v;
                }


                bool
                f_10150_3574_3618_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 3574, 3618);
                    return return_v;
                }


                int
                f_10150_3561_3619(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 3561, 3619);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10150_3665_3700(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 3665, 3700);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10150_3641_3701(Microsoft.CodeAnalysis.CSharp.Symbols.ReducedExtensionMethodSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 3641, 3701);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 2866, 3713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 2866, 3713);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ReducedExtensionMethodSymbol(MethodSymbol reducedFrom)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10150, 3725, 4357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 813, 825);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 861, 869);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 3812, 3854);

                f_10150_3812_3853((object)reducedFrom != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 3868, 3912);

                f_10150_3868_3911(f_10150_3881_3910(reducedFrom));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 3926, 3980);

                f_10150_3926_3979((object)f_10150_3947_3970(reducedFrom) == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 3994, 4051);

                f_10150_3994_4050(f_10150_4007_4034(reducedFrom) == reducedFrom);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 4065, 4110);

                f_10150_4065_4109(f_10150_4078_4104(reducedFrom) > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 4126, 4153);

                _reducedFrom = reducedFrom;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 4167, 4248);

                _typeMap = f_10150_4178_4247(f_10150_4178_4191(), reducedFrom, this, out _typeParameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 4262, 4346);

                _typeArguments = f_10150_4279_4345(_typeMap, f_10150_4304_4344(reducedFrom));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10150, 3725, 4357);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 3725, 4357);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 3725, 4357);
            }
        }

        private static MethodSymbol InferExtensionMethodTypeArguments(MethodSymbol method, TypeSymbol thisType, CSharpCompilation compilation, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10150, 4990, 10924);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 5197, 5236);

                f_10150_5197_5235(f_10150_5210_5234(method));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 5250, 5289);

                f_10150_5250_5288((object)thisType != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 5305, 5431) || true) && (f_10150_5309_5332_M(!method.IsGenericMethod) || (DynAbs.Tracing.TraceSender.Expression_False(10150, 5309, 5368) || method != f_10150_5346_5368(method)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 5305, 5431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 5402, 5416);

                    return method;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 5305, 5431);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 5521, 5606) || true) && (f_10150_5525_5545(thisType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 5521, 5606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 5579, 5591);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 5521, 5606);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 5622, 5673);

                var
                containingAssembly = f_10150_5647_5672(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 5687, 5743);

                var
                errorNamespace = f_10150_5708_5742(containingAssembly)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 5757, 5826);

                var
                conversions = f_10150_5775_5825(f_10150_5795_5824(containingAssembly))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 6027, 6067);

                var
                syntaxTree = CSharpSyntaxTree.Dummy
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 6081, 6133);

                var
                syntax = (CSharpSyntaxNode)f_10150_6112_6132(syntaxTree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 6310, 6420);

                var
                thisArgumentValue = new BoundLiteral(syntax, f_10150_6359_6376(), thisType) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10150, 6334, 6419) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 6434, 6568);

                var
                otherArgumentType = f_10150_6458_6567(errorNamespace, name: string.Empty, arity: 0, errorInfo: null, unreported: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 6582, 6702);

                var
                otherArgumentValue = new BoundLiteral(syntax, f_10150_6632_6649(), otherArgumentType) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10150, 6607, 6701) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 6718, 6757);

                var
                paramCount = f_10150_6735_6756(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 6771, 6819);

                var
                arguments = new BoundExpression[paramCount]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 6844, 6849);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 6835, 7026) || true) && (i < paramCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 6867, 6870)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 6835, 7026))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 6835, 7026);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 6904, 6969);

                        var
                        argument = (DynAbs.Tracing.TraceSender.Conditional_F1(10150, 6919, 6927) || (((i == 0) && DynAbs.Tracing.TraceSender.Conditional_F2(10150, 6930, 6947)) || DynAbs.Tracing.TraceSender.Conditional_F3(10150, 6950, 6968))) ? thisArgumentValue : otherArgumentValue
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 6987, 7011);

                        arguments[i] = argument;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10150, 1, 192);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10150, 1, 192);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 7042, 7271);

                var
                typeArgs = f_10150_7057_7270(conversions, method, f_10150_7185_7208(arguments), useSiteDiagnostics: ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 7287, 7370) || true) && (typeArgs.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 7287, 7370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 7343, 7355);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 7287, 7370);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 7637, 7666);

                int
                firstNullInTypeArgs = -1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 7680, 7761);

                var
                notInferredTypeParameters = f_10150_7712_7760()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 7775, 7814);

                var
                typeParams = f_10150_7792_7813(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 7828, 7871);

                var
                typeArgsForConstraintsCheck = typeArgs
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 7894, 7899);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 7885, 9013) || true) && (i < typeArgsForConstraintsCheck.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 7941, 7944)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 7885, 9013))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 7885, 9013);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 7978, 8998) || true) && (f_10150_7982_8021_M(!typeArgsForConstraintsCheck[i].HasType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 7978, 8998);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 8063, 8087);

                            firstNullInTypeArgs = i;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 8109, 8171);

                            var
                            builder = f_10150_8123_8170()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 8193, 8260);

                            f_10150_8193_8259(builder, typeArgsForConstraintsCheck, firstNullInTypeArgs);
                            try
                            {
                                for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 8284, 8868) || true) && (i < typeArgsForConstraintsCheck.Length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 8331, 8334)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 8284, 8868))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 8284, 8868);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 8384, 8429);

                                    var
                                    typeArg = typeArgsForConstraintsCheck[i]
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 8455, 8845) || true) && (f_10150_8459_8475_M(!typeArg.HasType))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 8455, 8845);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 8533, 8578);

                                        f_10150_8533_8577(notInferredTypeParameters, typeParams[i]);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 8608, 8683);

                                        f_10150_8608_8682(builder, TypeWithAnnotations.Create(ErrorTypeSymbol.UnknownResultType));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 8455, 8845);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 8455, 8845);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 8797, 8818);

                                        f_10150_8797_8817(builder, typeArg);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 8455, 8845);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10150, 1, 585);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10150, 1, 585);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 8892, 8951);

                            typeArgsForConstraintsCheck = f_10150_8922_8950(builder);
                            DynAbs.Tracing.TraceSender.TraceBreak(10150, 8973, 8979);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 7978, 8998);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10150, 1, 1129);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10150, 1, 1129);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 9064, 9145);

                var
                diagnosticsBuilder = f_10150_9089_9144()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 9159, 9231);

                var
                substitution = f_10150_9178_9230(typeParams, typeArgsForConstraintsCheck)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 9245, 9320);

                ArrayBuilder<TypeParameterDiagnosticInfo>
                useSiteDiagnosticsBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 9334, 9718);

                var
                success = f_10150_9348_9717(method, conversions, substitution, typeParams, typeArgsForConstraintsCheck, compilation, diagnosticsBuilder, nullabilityDiagnosticsBuilderOpt: null, ref useSiteDiagnosticsBuilder, ignoreTypeConstraintsDependentOnTypeParametersOpt: (DynAbs.Tracing.TraceSender.Conditional_F1(10150, 9646, 9681) || ((f_10150_9646_9677(notInferredTypeParameters) > 0 && DynAbs.Tracing.TraceSender.Conditional_F2(10150, 9684, 9709)) || DynAbs.Tracing.TraceSender.Conditional_F3(10150, 9712, 9716))) ? notInferredTypeParameters : null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 9732, 9758);

                f_10150_9732_9757(diagnosticsBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 9772, 9805);

                f_10150_9772_9804(notInferredTypeParameters);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 9821, 10259) || true) && (useSiteDiagnosticsBuilder != null && (DynAbs.Tracing.TraceSender.Expression_True(10150, 9825, 9897) && f_10150_9862_9893(useSiteDiagnosticsBuilder) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 9821, 10259);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 9931, 10073) || true) && (useSiteDiagnostics == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 9931, 10073);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 10003, 10054);

                        useSiteDiagnostics = f_10150_10024_10053();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 9931, 10073);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 10093, 10244);
                        foreach (var diag in f_10150_10114_10139_I(useSiteDiagnosticsBuilder))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 10093, 10244);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 10181, 10225);

                            f_10150_10181_10224(useSiteDiagnostics, diag.DiagnosticInfo);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 10093, 10244);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10150, 1, 152);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10150, 1, 152);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 9821, 10259);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 10275, 10348) || true) && (!success)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 10275, 10348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 10321, 10333);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 10275, 10348);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 10519, 10587);

                ImmutableArray<TypeWithAnnotations>
                typeArgsForConstruct = typeArgs
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 10601, 10851) || true) && (typeArgs.Any(t => !t.HasType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 10601, 10851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 10668, 10836);

                    typeArgsForConstruct = typeArgs.ZipAsArray(f_10150_10733_10754(method), (t, tp) => t.HasType ? t : TypeWithAnnotations.Create(tp));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 10601, 10851);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 10867, 10913);

                return f_10150_10874_10912(method, typeArgsForConstruct);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10150, 4990, 10924);

                bool
                f_10150_5210_5234(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 5210, 5234);
                    return return_v;
                }


                int
                f_10150_5197_5235(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 5197, 5235);
                    return 0;
                }


                int
                f_10150_5250_5288(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 5250, 5288);
                    return 0;
                }


                bool
                f_10150_5309_5332_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 5309, 5332);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10150_5346_5368(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 5346, 5368);
                    return return_v;
                }


                bool
                f_10150_5525_5545(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 5525, 5545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10150_5647_5672(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 5647, 5672);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10150_5708_5742(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 5708, 5742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10150_5795_5824(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.CorLibrary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 5795, 5824);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TypeConversions
                f_10150_5775_5825(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                corLibrary)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.TypeConversions(corLibrary);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 5775, 5825);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10150_6112_6132(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 6112, 6132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10150_6359_6376()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 6359, 6376);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10150_6458_6567(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                containingSymbol, string
                name, int
                arity, Microsoft.CodeAnalysis.DiagnosticInfo?
                errorInfo, bool
                unreported)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)containingSymbol, name: name, arity: arity, errorInfo: errorInfo, unreported: unreported);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 6458, 6567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10150_6632_6649()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 6632, 6649);
                    return return_v;
                }


                int
                f_10150_6735_6756(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 6735, 6756);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10150_7185_7208(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                items)
                {
                    var return_v = items.AsImmutable<Microsoft.CodeAnalysis.CSharp.BoundExpression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 7185, 7208);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10150_7057_7270(Microsoft.CodeAnalysis.CSharp.TypeConversions
                conversions, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = MethodTypeInferrer.InferTypeArgumentsFromFirstArgument((Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions, method, arguments, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 7057, 7270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10150_7712_7760()
                {
                    var return_v = PooledHashSet<TypeParameterSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 7712, 7760);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10150_7792_7813(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 7792, 7813);
                    return return_v;
                }


                bool
                f_10150_7982_8021_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 7982, 8021);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10150_8123_8170()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 8123, 8170);
                    return return_v;
                }


                int
                f_10150_8193_8259(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                items, int
                length)
                {
                    this_param.AddRange(items, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 8193, 8259);
                    return 0;
                }


                bool
                f_10150_8459_8475_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 8459, 8475);
                    return return_v;
                }


                bool
                f_10150_8533_8577(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 8533, 8577);
                    return return_v;
                }


                int
                f_10150_8608_8682(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 8608, 8682);
                    return 0;
                }


                int
                f_10150_8797_8817(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 8797, 8817);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10150_8922_8950(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 8922, 8950);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                f_10150_9089_9144()
                {
                    var return_v = ArrayBuilder<TypeParameterDiagnosticInfo>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 9089, 9144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10150_9178_9230(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                from, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                to)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap(from, to);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 9178, 9230);
                    return return_v;
                }


                int
                f_10150_9646_9677(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 9646, 9677);
                    return return_v;
                }


                bool
                f_10150_9348_9717(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.TypeConversions
                conversions, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                substitution, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                diagnosticsBuilder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                nullabilityDiagnosticsBuilderOpt, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>?
                useSiteDiagnosticsBuilder, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>?
                ignoreTypeConstraintsDependentOnTypeParametersOpt)
                {
                    var return_v = containingSymbol.CheckConstraints((Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions, substitution, typeParameters, typeArguments, currentCompilation, diagnosticsBuilder, nullabilityDiagnosticsBuilderOpt: nullabilityDiagnosticsBuilderOpt, ref useSiteDiagnosticsBuilder, ignoreTypeConstraintsDependentOnTypeParametersOpt: (System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>?)ignoreTypeConstraintsDependentOnTypeParametersOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 9348, 9717);
                    return return_v;
                }


                int
                f_10150_9732_9757(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 9732, 9757);
                    return 0;
                }


                int
                f_10150_9772_9804(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 9772, 9804);
                    return 0;
                }


                int
                f_10150_9862_9893(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 9862, 9893);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                f_10150_10024_10053()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 10024, 10053);
                    return return_v;
                }


                bool
                f_10150_10181_10224(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 10181, 10224);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                f_10150_10114_10139_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 10114, 10139);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10150_10733_10754(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 10733, 10754);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10150_10874_10912(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 10874, 10912);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 4990, 10924);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 4990, 10924);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override MethodSymbol CallsiteReducedFromMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 11019, 11082);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 11025, 11080);

                    return _reducedFrom.ConstructIfGeneric(_typeArguments);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 11019, 11082);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 10938, 11093);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 10938, 11093);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeSymbol ReceiverType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 11169, 11259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 11205, 11244);

                    return f_10150_11212_11243(f_10150_11212_11235(_reducedFrom)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 11169, 11259);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10150_11212_11235(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 11212, 11235);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10150_11212_11243(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 11212, 11243);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 11105, 11270);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 11105, 11270);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override CodeAnalysis.NullableAnnotation ReceiverNullableAnnotation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 11359, 11442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 11375, 11442);
                    return f_10150_11375_11398(_reducedFrom)[0].TypeWithAnnotations.ToPublicAnnotation(); DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 11359, 11442);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 11359, 11442);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 11359, 11442);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeSymbol GetTypeInferredDuringReduction(TypeParameterSymbol reducedFromTypeParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 11455, 11919);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 11583, 11717) || true) && ((object)reducedFromTypeParameter == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 11583, 11717);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 11661, 11702);

                    throw f_10150_11667_11701();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 11583, 11717);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 11733, 11880) || true) && (f_10150_11737_11778(reducedFromTypeParameter) != _reducedFrom)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 11733, 11880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 11828, 11865);

                    throw f_10150_11834_11864();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 11733, 11880);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 11896, 11908);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 11455, 11919);

                System.ArgumentNullException
                f_10150_11667_11701()
                {
                    var return_v = new System.ArgumentNullException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 11667, 11701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10150_11737_11778(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 11737, 11778);
                    return return_v;
                }


                System.ArgumentException
                f_10150_11834_11864()
                {
                    var return_v = new System.ArgumentException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 11834, 11864);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 11455, 11919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 11455, 11919);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override MethodSymbol ReducedFrom
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 11996, 12024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 12002, 12022);

                    return _reducedFrom;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 11996, 12024);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 11931, 12035);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 11931, 12035);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodSymbol ConstructedFrom
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 12116, 12256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 12152, 12211);

                    f_10150_12152_12210(f_10150_12165_12193(_reducedFrom) == _reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 12229, 12241);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 12116, 12256);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10150_12165_12193(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ConstructedFrom;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 12165, 12193);
                        return return_v;
                    }


                    int
                    f_10150_12152_12210(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 12152, 12210);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 12047, 12267);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 12047, 12267);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 12370, 12401);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 12376, 12399);

                    return _typeParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 12370, 12401);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 12279, 12412);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 12279, 12412);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 12529, 12559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 12535, 12557);

                    return _typeArguments;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 12529, 12559);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 12424, 12570);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 12424, 12570);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Microsoft.Cci.CallingConvention CallingConvention
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 12674, 12720);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 12680, 12718);

                    return f_10150_12687_12717(_reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 12674, 12720);

                    Microsoft.Cci.CallingConvention
                    f_10150_12687_12717(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.CallingConvention;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 12687, 12717);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 12582, 12731);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 12582, 12731);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Arity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 12793, 12827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 12799, 12825);

                    return f_10150_12806_12824(_reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 12793, 12827);

                    int
                    f_10150_12806_12824(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 12806, 12824);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 12743, 12838);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 12743, 12838);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 12902, 12935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 12908, 12933);

                    return f_10150_12915_12932(_reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 12902, 12935);

                    string
                    f_10150_12915_12932(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 12915, 12932);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 12850, 12946);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 12850, 12946);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 13020, 13063);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 13026, 13061);

                    return f_10150_13033_13060(_reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 13020, 13063);

                    bool
                    f_10150_13033_13060(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.HasSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 13033, 13060);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 12958, 13074);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 12958, 13074);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override System.Reflection.MethodImplAttributes ImplementationAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 13192, 13245);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 13198, 13243);

                    return f_10150_13205_13242(_reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 13192, 13245);

                    System.Reflection.MethodImplAttributes
                    f_10150_13205_13242(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ImplementationAttributes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 13205, 13242);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 13086, 13256);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 13086, 13256);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool RequiresSecurityObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 13338, 13389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 13344, 13387);

                    return f_10150_13351_13386(_reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 13338, 13389);

                    bool
                    f_10150_13351_13386(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RequiresSecurityObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 13351, 13386);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 13268, 13400);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 13268, 13400);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override DllImportData GetDllImportData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 13412, 13535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 13485, 13524);

                return f_10150_13492_13523(_reducedFrom);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 13412, 13535);

                Microsoft.CodeAnalysis.DllImportData?
                f_10150_13492_13523(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetDllImportData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 13492, 13523);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 13412, 13535);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 13412, 13535);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 13608, 13653);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 13614, 13651);

                    throw f_10150_13620_13650();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 13608, 13653);

                    System.Exception
                    f_10150_13620_13650()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 13620, 13650);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 13547, 13664);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 13547, 13664);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override MarshalPseudoCustomAttributeData ReturnValueMarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 13785, 13847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 13791, 13845);

                    return f_10150_13798_13844(_reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 13785, 13847);

                    Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    f_10150_13798_13844(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnValueMarshallingInformation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 13798, 13844);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 13676, 13858);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 13676, 13858);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasDeclarativeSecurity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 13940, 13991);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 13946, 13989);

                    return f_10150_13953_13988(_reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 13940, 13991);

                    bool
                    f_10150_13953_13988(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.HasDeclarativeSecurity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 13953, 13988);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 13870, 14002);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 13870, 14002);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override IEnumerable<Microsoft.Cci.SecurityAttribute> GetSecurityInformation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 14014, 14182);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 14126, 14171);

                return f_10150_14133_14170(_reducedFrom);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 14014, 14182);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                f_10150_14133_14170(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetSecurityInformation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 14133, 14170);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 14014, 14182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 14014, 14182);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<string> GetAppliedConditionalSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 14194, 14352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 14290, 14341);

                return f_10150_14297_14340(_reducedFrom);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 14194, 14352);

                System.Collections.Immutable.ImmutableArray<string>
                f_10150_14297_14340(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetAppliedConditionalSymbols();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 14297, 14340);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 14194, 14352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 14194, 14352);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AssemblySymbol ContainingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 14438, 14485);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 14444, 14483);

                    return f_10150_14451_14482(_reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 14438, 14485);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10150_14451_14482(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 14451, 14482);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 14364, 14496);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 14364, 14496);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 14583, 14621);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 14589, 14619);

                    return f_10150_14596_14618(_reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 14583, 14621);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10150_14596_14618(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 14596, 14618);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 14508, 14632);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 14508, 14632);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 14742, 14796);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 14748, 14794);

                    return f_10150_14755_14793(_reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 14742, 14796);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10150_14755_14793(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaringSyntaxReferences;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 14755, 14793);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 14644, 14807);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 14644, 14807);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 14819, 15136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 15025, 15125);

                return f_10150_15032_15124(_reducedFrom, preferredCulture, expandIncludes, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 14819, 15136);

                string
                f_10150_15032_15124(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, System.Globalization.CultureInfo?
                preferredCulture, bool
                expandIncludes, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 15032, 15124);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 14819, 15136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 14819, 15136);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override MethodSymbol OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 15220, 15240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 15226, 15238);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 15220, 15240);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 15148, 15251);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 15148, 15251);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsExtern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 15317, 15354);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 15323, 15352);

                    return f_10150_15330_15351(_reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 15317, 15354);

                    bool
                    f_10150_15330_15351(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsExtern;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 15330, 15351);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 15263, 15365);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 15263, 15365);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 15431, 15468);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 15437, 15466);

                    return f_10150_15444_15465(_reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 15431, 15468);

                    bool
                    f_10150_15444_15465(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsSealed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 15444, 15465);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 15377, 15479);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 15377, 15479);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 15546, 15584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 15552, 15582);

                    return f_10150_15559_15581(_reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 15546, 15584);

                    bool
                    f_10150_15559_15581(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsVirtual;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 15559, 15581);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 15491, 15595);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 15491, 15595);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 15663, 15702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 15669, 15700);

                    return f_10150_15676_15699(_reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 15663, 15702);

                    bool
                    f_10150_15676_15699(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsAbstract;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 15676, 15699);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 15607, 15713);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 15607, 15713);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 15781, 15820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 15787, 15818);

                    return f_10150_15794_15817(_reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 15781, 15820);

                    bool
                    f_10150_15794_15817(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsOverride;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 15794, 15817);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 15725, 15831);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 15725, 15831);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 15897, 15918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 15903, 15916);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 15897, 15918);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 15843, 15929);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 15843, 15929);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsAsync
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 15994, 16030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 16000, 16028);

                    return f_10150_16007_16027(_reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 15994, 16030);

                    bool
                    f_10150_16007_16027(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsAsync;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 16007, 16027);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 15941, 16041);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 15941, 16041);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsExtensionMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 16116, 16136);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 16122, 16134);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 16116, 16136);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 16053, 16147);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 16053, 16147);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsMetadataNewSlot(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 16159, 16306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 16282, 16295);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 16159, 16306);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 16159, 16306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 16159, 16306);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 16318, 16465);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 16441, 16454);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 16318, 16465);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 16318, 16465);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 16318, 16465);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsMetadataFinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 16540, 16604);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 16576, 16589);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 16540, 16604);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 16477, 16615);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 16477, 16615);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 16720, 16770);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 16726, 16768);

                    return f_10150_16733_16767(_reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 16720, 16770);

                    Microsoft.CodeAnalysis.ObsoleteAttributeData
                    f_10150_16733_16767(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ObsoleteAttributeData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 16733, 16767);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 16627, 16781);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 16627, 16781);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override UnmanagedCallersOnlyAttributeData GetUnmanagedCallersOnlyAttributeData(bool forceComplete)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 16922, 16989);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 16925, 16989);
                return f_10150_16925_16989(_reducedFrom, forceComplete); DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 16922, 16989);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 16922, 16989);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 16922, 16989);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData?
            f_10150_16925_16989(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            this_param, bool
            forceComplete)
            {
                var return_v = this_param.GetUnmanagedCallersOnlyAttributeData(forceComplete);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 16925, 16989);
                return return_v;
            }

        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 17078, 17128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 17084, 17126);

                    return f_10150_17091_17125(_reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 17078, 17128);

                    Microsoft.CodeAnalysis.Accessibility
                    f_10150_17091_17125(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaredAccessibility;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 17091, 17125);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 17002, 17139);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 17002, 17139);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 17215, 17260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 17221, 17258);

                    return f_10150_17228_17257(_reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 17215, 17260);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10150_17228_17257(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 17228, 17257);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 17151, 17271);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 17151, 17271);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 17283, 17422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 17375, 17411);

                return f_10150_17382_17410(_reducedFrom);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 17283, 17422);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10150_17382_17410(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 17382, 17410);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 17283, 17422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 17283, 17422);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Symbol AssociatedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 17498, 17518);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 17504, 17516);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 17498, 17518);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 17434, 17529);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 17434, 17529);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodKind MethodKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 17603, 17646);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 17609, 17644);

                    return MethodKind.ReducedExtension;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 17603, 17646);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 17541, 17657);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 17541, 17657);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool ReturnsVoid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 17726, 17766);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 17732, 17764);

                    return f_10150_17739_17763(_reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 17726, 17766);

                    bool
                    f_10150_17739_17763(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnsVoid;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 17739, 17763);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 17669, 17777);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 17669, 17777);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsGenericMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 17850, 17894);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 17856, 17892);

                    return f_10150_17863_17891(_reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 17850, 17894);

                    bool
                    f_10150_17863_17891(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsGenericMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 17863, 17891);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 17789, 17905);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 17789, 17905);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsVararg
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 17971, 18008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 17977, 18006);

                    return f_10150_17984_18005(_reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 17971, 18008);

                    bool
                    f_10150_17984_18005(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsVararg;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 17984, 18005);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 17917, 18019);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 17917, 18019);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 18087, 18123);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 18093, 18121);

                    return f_10150_18100_18120(_reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 18087, 18123);

                    Microsoft.CodeAnalysis.RefKind
                    f_10150_18100_18120(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 18100, 18120);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 18031, 18134);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 18031, 18134);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeWithAnnotations ReturnTypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 18232, 18311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 18238, 18309);

                    return f_10150_18245_18308(_typeMap, f_10150_18269_18307(_reducedFrom));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 18232, 18311);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10150_18269_18307(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnTypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 18269, 18307);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10150_18245_18308(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    previous)
                    {
                        var return_v = this_param.SubstituteType(previous);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 18245, 18308);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 18146, 18322);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 18146, 18322);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override FlowAnalysisAnnotations ReturnTypeFlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 18408, 18457);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 18411, 18457);
                    return f_10150_18411_18457(_reducedFrom); DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 18408, 18457);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 18408, 18457);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 18408, 18457);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableHashSet<string> ReturnNotNullIfParameterNotNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 18543, 18590);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 18546, 18590);
                    return f_10150_18546_18590(_reducedFrom); DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 18543, 18590);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 18543, 18590);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 18543, 18590);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override FlowAnalysisAnnotations FlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 18667, 18706);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 18670, 18706);
                    return f_10150_18670_18706(_reducedFrom); DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 18667, 18706);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 18667, 18706);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 18667, 18706);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 18809, 18892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 18815, 18890);

                    return f_10150_18822_18889(_typeMap, f_10150_18857_18888(_reducedFrom));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 18809, 18892);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10150_18857_18888(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 18857, 18888);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10150_18822_18889(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    customModifiers)
                    {
                        var return_v = this_param.SubstituteCustomModifiers(customModifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 18822, 18889);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 18719, 18903);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 18719, 18903);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int ParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 18976, 19023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 18982, 19021);

                    return f_10150_18989_19016(_reducedFrom) - 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 18976, 19023);

                    int
                    f_10150_18989_19016(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 18989, 19016);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 18915, 19034);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 18915, 19034);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool GenerateDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 19111, 19157);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 19117, 19155);

                    return f_10150_19124_19154(_reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 19111, 19157);

                    bool
                    f_10150_19124_19154(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.GenerateDebugInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 19124, 19154);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 19046, 19168);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 19046, 19168);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ParameterSymbol> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 19263, 19579);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 19299, 19523) || true) && (_lazyParameters.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 19299, 19523);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 19370, 19504);

                        f_10150_19370_19503(ref _lazyParameters, f_10150_19439_19460(this), default(ImmutableArray<ParameterSymbol>));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 19299, 19523);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 19541, 19564);

                    return _lazyParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 19263, 19579);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10150_19439_19460(Microsoft.CodeAnalysis.CSharp.Symbols.ReducedExtensionMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.MakeParameters();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 19439, 19460);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10150_19370_19503(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    comparand)
                    {
                        var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 19370, 19503);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 19180, 19590);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 19180, 19590);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsExplicitInterfaceImplementation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 19683, 19704);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 19689, 19702);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 19683, 19704);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 19602, 19715);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 19602, 19715);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsDeclaredReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 19769, 19777);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 19772, 19777);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 19769, 19777);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 19769, 19777);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 19769, 19777);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsInitOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 19824, 19832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 19827, 19832);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 19824, 19832);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 19824, 19832);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 19824, 19832);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsEffectivelyReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 19890, 19941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 19893, 19941);
                    return f_10150_19893_19927(f_10150_19893_19916(_reducedFrom)[0]) == RefKind.In; DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 19890, 19941);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 19890, 19941);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 19890, 19941);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<MethodSymbol> ExplicitInterfaceImplementations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 20056, 20106);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 20062, 20104);

                    return ImmutableArray<MethodSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 20056, 20106);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 19954, 20117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 19954, 20117);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HidesBaseMethodsByName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 20197, 20218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 20203, 20216);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 20197, 20218);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 20129, 20229);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 20129, 20229);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool CallsAreOmitted(SyntaxTree syntaxTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 20241, 20386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 20327, 20375);

                return f_10150_20334_20374(_reducedFrom, syntaxTree);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 20241, 20386);

                bool
                f_10150_20334_20374(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.CallsAreOmitted(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 20334, 20374);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 20241, 20386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 20241, 20386);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<ParameterSymbol> MakeParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 20398, 21143);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 20479, 20531);

                var
                reducedFromParameters = f_10150_20507_20530(_reducedFrom)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 20545, 20586);

                int
                count = reducedFromParameters.Length
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 20602, 21132) || true) && (count <= 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 20602, 21132);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 20650, 20675);

                    f_10150_20650_20674(count == 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 20693, 20738);

                    return ImmutableArray<ParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 20602, 21132);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 20602, 21132);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 20804, 20852);

                    var
                    parameters = new ParameterSymbol[count - 1]
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 20879, 20884);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 20870, 21059) || true) && (i < count - 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 20901, 20904)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 20870, 21059))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 20870, 21059);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 20946, 21040);

                            parameters[i] = f_10150_20962_21039(this, reducedFromParameters[i + 1]);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10150, 1, 190);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10150, 1, 190);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 21079, 21117);

                    return f_10150_21086_21116(parameters);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 20602, 21132);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 20398, 21143);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10150_20507_20530(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 20507, 20530);
                    return return_v;
                }


                int
                f_10150_20650_20674(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 20650, 20674);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ReducedExtensionMethodSymbol.ReducedExtensionMethodParameterSymbol
                f_10150_20962_21039(Microsoft.CodeAnalysis.CSharp.Symbols.ReducedExtensionMethodSymbol
                containingMethod, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                underlyingParameter)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ReducedExtensionMethodSymbol.ReducedExtensionMethodParameterSymbol(containingMethod, underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 20962, 21039);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10150_21086_21116(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 21086, 21116);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 20398, 21143);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 20398, 21143);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override int CalculateLocalSyntaxOffset(int localPosition, SyntaxTree localTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 21155, 21317);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 21269, 21306);

                throw f_10150_21275_21305();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 21155, 21317);

                System.Exception
                f_10150_21275_21305()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 21275, 21305);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 21155, 21317);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 21155, 21317);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsNullableAnalysisEnabled()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 21380, 21419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 21383, 21419);
                throw f_10150_21389_21419(); DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 21380, 21419);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 21380, 21419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 21380, 21419);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10150_21389_21419()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 21389, 21419);
                return return_v;
            }

        }

        public override bool Equals(Symbol obj, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 21432, 21761);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 21525, 21562) || true) && ((object)this == obj)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 21525, 21562);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 21550, 21562);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 21525, 21562);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 21578, 21651);

                ReducedExtensionMethodSymbol
                other = obj as ReducedExtensionMethodSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 21665, 21750);

                return (object)other != null && (DynAbs.Tracing.TraceSender.Expression_True(10150, 21672, 21749) && f_10150_21697_21749(_reducedFrom, other._reducedFrom, compareKind));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 21432, 21761);

                bool
                f_10150_21697_21749(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbol)other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 21697, 21749);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 21432, 21761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 21432, 21761);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 21773, 21876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 21831, 21865);

                return f_10150_21838_21864(_reducedFrom);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 21773, 21876);

                int
                f_10150_21838_21864(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 21838, 21864);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 21773, 21876);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 21773, 21876);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class ReducedExtensionMethodParameterSymbol : WrappedParameterSymbol
        {
            private readonly ReducedExtensionMethodSymbol _containingMethod;

            public ReducedExtensionMethodParameterSymbol(ReducedExtensionMethodSymbol containingMethod, ParameterSymbol underlyingParameter) : base(f_10150_22229_22248_C(underlyingParameter))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10150, 22076, 22398);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 22042, 22059);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 22282, 22328);

                    f_10150_22282_22327(f_10150_22295_22322(underlyingParameter) > 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 22346, 22383);

                    _containingMethod = containingMethod;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10150, 22076, 22398);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 22076, 22398);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 22076, 22398);
                }
            }

            public override Symbol ContainingSymbol
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 22486, 22519);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 22492, 22517);

                        return _containingMethod;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 22486, 22519);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 22414, 22534);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 22414, 22534);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int Ordinal
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 22610, 22663);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 22616, 22661);

                        return f_10150_22623_22656(this._underlyingParameter) - 1;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 22610, 22663);

                        int
                        f_10150_22623_22656(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.Ordinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 22623, 22656);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 22550, 22678);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 22550, 22678);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override TypeWithAnnotations TypeWithAnnotations
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 22782, 22886);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 22788, 22884);

                        return f_10150_22795_22883(_containingMethod._typeMap, f_10150_22837_22882(this._underlyingParameter));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 22782, 22886);

                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        f_10150_22837_22882(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.TypeWithAnnotations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 22837, 22882);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        f_10150_22795_22883(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        previous)
                        {
                            var return_v = this_param.SubstituteType(previous);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 22795, 22883);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 22694, 22901);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 22694, 22901);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ImmutableArray<CustomModifier> RefCustomModifiers
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 23015, 23184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 23059, 23165);

                        return f_10150_23066_23164(_containingMethod._typeMap, f_10150_23119_23163(this._underlyingParameter));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 23015, 23184);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                        f_10150_23119_23163(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.RefCustomModifiers;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 23119, 23163);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                        f_10150_23066_23164(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                        customModifiers)
                        {
                            var return_v = this_param.SubstituteCustomModifiers(customModifiers);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 23066, 23164);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 22917, 23199);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 22917, 23199);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public sealed override bool Equals(Symbol obj, TypeCompareKind compareKind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 23215, 23966);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 23323, 23419) || true) && ((object)this == obj)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10150, 23323, 23419);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 23388, 23400);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10150, 23323, 23419);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 23703, 23760);

                    var
                    other = obj as ReducedExtensionMethodParameterSymbol
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 23778, 23951);

                    return (object)other != null && (DynAbs.Tracing.TraceSender.Expression_True(10150, 23785, 23860) && f_10150_23831_23843(this) == f_10150_23847_23860(other)) && (DynAbs.Tracing.TraceSender.Expression_True(10150, 23785, 23950) && f_10150_23885_23950(f_10150_23885_23906(this), f_10150_23914_23936(other), compareKind));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 23215, 23966);

                    int
                    f_10150_23831_23843(Microsoft.CodeAnalysis.CSharp.Symbols.ReducedExtensionMethodSymbol.ReducedExtensionMethodParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 23831, 23843);
                        return return_v;
                    }


                    int
                    f_10150_23847_23860(Microsoft.CodeAnalysis.CSharp.Symbols.ReducedExtensionMethodSymbol.ReducedExtensionMethodParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 23847, 23860);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10150_23885_23906(Microsoft.CodeAnalysis.CSharp.Symbols.ReducedExtensionMethodSymbol.ReducedExtensionMethodParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 23885, 23906);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10150_23914_23936(Microsoft.CodeAnalysis.CSharp.Symbols.ReducedExtensionMethodSymbol.ReducedExtensionMethodParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 23914, 23936);
                        return return_v;
                    }


                    bool
                    f_10150_23885_23950(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    other, Microsoft.CodeAnalysis.TypeCompareKind
                    compareKind)
                    {
                        var return_v = this_param.Equals(other, compareKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 23885, 23950);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 23215, 23966);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 23215, 23966);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public sealed override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10150, 23982, 24138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10150, 24055, 24123);

                    return f_10150_24062_24122(f_10150_24075_24091(), f_10150_24093_24121(_underlyingParameter));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10150, 23982, 24138);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10150_24075_24091()
                    {
                        var return_v = ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 24075, 24091);
                        return return_v;
                    }


                    int
                    f_10150_24093_24121(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 24093, 24121);
                        return return_v;
                    }


                    int
                    f_10150_24062_24122(Microsoft.CodeAnalysis.CSharp.Symbol
                    newKeyPart, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKeyPart, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 24062, 24122);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10150, 23982, 24138);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 23982, 24138);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ReducedExtensionMethodParameterSymbol()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10150, 21888, 24149);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10150, 21888, 24149);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 21888, 24149);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10150, 21888, 24149);

            int
            f_10150_22295_22322(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
            this_param)
            {
                var return_v = this_param.Ordinal;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 22295, 22322);
                return return_v;
            }


            int
            f_10150_22282_22327(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 22282, 22327);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
            f_10150_22229_22248_C(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10150, 22076, 22398);
                return return_v;
            }

        }

        static ReducedExtensionMethodSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10150, 701, 24156);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10150, 701, 24156);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10150, 701, 24156);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10150, 701, 24156);

        int
        f_10150_3812_3853(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 3812, 3853);
            return 0;
        }


        bool
        f_10150_3881_3910(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.IsExtensionMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 3881, 3910);
            return return_v;
        }


        int
        f_10150_3868_3911(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 3868, 3911);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10150_3947_3970(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ReducedFrom;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 3947, 3970);
            return return_v;
        }


        int
        f_10150_3926_3979(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 3926, 3979);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10150_4007_4034(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ConstructedFrom;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 4007, 4034);
            return return_v;
        }


        int
        f_10150_3994_4050(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 3994, 4050);
            return 0;
        }


        int
        f_10150_4078_4104(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ParameterCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 4078, 4104);
            return return_v;
        }


        int
        f_10150_4065_4109(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 4065, 4109);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10150_4178_4191()
        {
            var return_v = TypeMap.Empty;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 4178, 4191);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10150_4178_4247(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        oldOwner, Microsoft.CodeAnalysis.CSharp.Symbols.ReducedExtensionMethodSymbol
        newOwner, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        newTypeParameters)
        {
            var return_v = this_param.WithAlphaRename(oldOwner, (Microsoft.CodeAnalysis.CSharp.Symbol)newOwner, out newTypeParameters);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 4178, 4247);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        f_10150_4304_4344(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.TypeArgumentsWithAnnotations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 4304, 4344);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        f_10150_4279_4345(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        original)
        {
            var return_v = this_param.SubstituteTypes(original);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10150, 4279, 4345);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_10150_11375_11398(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.Parameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 11375, 11398);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
        f_10150_18411_18457(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ReturnTypeFlowAnalysisAnnotations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 18411, 18457);
            return return_v;
        }


        System.Collections.Immutable.ImmutableHashSet<string>
        f_10150_18546_18590(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ReturnNotNullIfParameterNotNull;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 18546, 18590);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
        f_10150_18670_18706(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.FlowAnalysisAnnotations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 18670, 18706);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_10150_19893_19916(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.Parameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 19893, 19916);
            return return_v;
        }


        Microsoft.CodeAnalysis.RefKind
        f_10150_19893_19927(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.RefKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10150, 19893, 19927);
            return return_v;
        }

    }
}
