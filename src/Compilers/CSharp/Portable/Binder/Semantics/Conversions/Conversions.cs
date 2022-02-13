// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class Conversions : ConversionsBase
    {
        private readonly Binder _binder;

        public Conversions(Binder binder)
        : this(f_10842_605_611_C(binder), currentRecursionDepth: 0, includeNullability: false, otherNullabilityOpt: null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10842, 551, 714);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10842, 551, 714);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10842, 551, 714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10842, 551, 714);
            }
        }

        private Conversions(Binder binder, int currentRecursionDepth, bool includeNullability, Conversions otherNullabilityOpt)
        : base(f_10842_866_904_C(f_10842_866_904(f_10842_866_893(f_10842_866_884(binder)))), currentRecursionDepth, includeNullability, otherNullabilityOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10842, 726, 1022);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 531, 538);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 994, 1011);

                _binder = binder;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10842, 726, 1022);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10842, 726, 1022);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10842, 726, 1022);
            }
        }

        protected override ConversionsBase CreateInstance(int currentRecursionDepth)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10842, 1034, 1248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 1135, 1237);

                return f_10842_1142_1236(_binder, currentRecursionDepth, IncludeNullability, otherNullabilityOpt: null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10842, 1034, 1248);

                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10842_1142_1236(Microsoft.CodeAnalysis.CSharp.Binder
                binder, int
                currentRecursionDepth, bool
                includeNullability, Microsoft.CodeAnalysis.CSharp.Conversions
                otherNullabilityOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversions(binder, currentRecursionDepth, includeNullability, otherNullabilityOpt: otherNullabilityOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 1142, 1236);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10842, 1034, 1248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10842, 1034, 1248);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CSharpCompilation Compilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10842, 1300, 1335);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 1306, 1333);

                    return f_10842_1313_1332(_binder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10842, 1300, 1335);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10842_1313_1332(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 1313, 1332);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10842, 1260, 1337);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10842, 1260, 1337);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ConversionsBase WithNullabilityCore(bool includeNullability)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10842, 1349, 1614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 1453, 1508);

                f_10842_1453_1507(IncludeNullability != includeNullability);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 1522, 1603);

                return f_10842_1529_1602(_binder, currentRecursionDepth, includeNullability, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10842, 1349, 1614);

                int
                f_10842_1453_1507(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 1453, 1507);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10842_1529_1602(Microsoft.CodeAnalysis.CSharp.Binder
                binder, int
                currentRecursionDepth, bool
                includeNullability, Microsoft.CodeAnalysis.CSharp.Conversions
                otherNullabilityOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversions(binder, currentRecursionDepth, includeNullability, otherNullabilityOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 1529, 1602);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10842, 1349, 1614);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10842, 1349, 1614);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Conversion GetMethodGroupDelegateConversion(BoundMethodGroup source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10842, 1626, 2802);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 1887, 2000) || true) && (!f_10842_1892_1920(destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 1887, 2000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 1954, 1985);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 1887, 2000);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 2016, 2144);

                var (methodSymbol, isFunctionPointer, callingConventionInfo) = f_10842_2079_2143(destination);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 2158, 2270) || true) && ((object)methodSymbol == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 2158, 2270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 2224, 2255);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 2158, 2270);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 2286, 2444);

                var
                resolution = f_10842_2303_2443(_binder, source, methodSymbol, isFunctionPointer, callingConventionInfo, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 2458, 2727);

                var
                conversion = (DynAbs.Tracing.TraceSender.Conditional_F1(10842, 2475, 2522) || (((resolution.IsEmpty || (DynAbs.Tracing.TraceSender.Expression_False(10842, 2476, 2521) || resolution.HasAnyErrors)) && DynAbs.Tracing.TraceSender.Conditional_F2(10842, 2542, 2565)) || DynAbs.Tracing.TraceSender.Conditional_F3(10842, 2585, 2726))) ? Conversion.NoConversion : f_10842_2585_2726(resolution.OverloadResolutionResult, resolution.MethodGroup, f_10842_2659_2725(f_10842_2659_2710(((NamedTypeSymbol)destination))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 2741, 2759);

                resolution.Free();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 2773, 2791);

                return conversion;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10842, 1626, 2802);

                bool
                f_10842_1892_1920(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 1892, 1920);
                    return return_v;
                }


                (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, bool isFunctionPointer, Microsoft.CodeAnalysis.CSharp.CallingConventionInfo callingConventionInfo)
                f_10842_2079_2143(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = GetDelegateInvokeOrFunctionPointerMethodIfAvailable(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 2079, 2143);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodGroupResolution
                f_10842_2303_2443(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                source, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                delegateInvokeMethodOpt, bool
                isFunctionPointer, Microsoft.CodeAnalysis.CSharp.CallingConventionInfo
                callingConventionInfo, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = ResolveDelegateOrFunctionPointerMethodGroup(binder, source, delegateInvokeMethodOpt, isFunctionPointer, callingConventionInfo, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 2303, 2443);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10842_2659_2710(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 2659, 2710);
                    return return_v;
                }


                int
                f_10842_2659_2725(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 2659, 2725);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10842_2585_2726(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                result, Microsoft.CodeAnalysis.CSharp.MethodGroup
                methodGroup, int
                parameterCount)
                {
                    var return_v = ToConversion(result, methodGroup, parameterCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 2585, 2726);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10842, 1626, 2802);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10842, 1626, 2802);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Conversion GetMethodGroupFunctionPointerConversion(BoundMethodGroup source, FunctionPointerTypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10842, 2814, 3721);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 3017, 3393);

                var
                resolution = f_10842_3034_3392(_binder, source, f_10842_3147_3168(destination), isFunctionPointer: true, f_10842_3229_3350(f_10842_3255_3294(f_10842_3255_3276(destination)), f_10842_3296_3349(f_10842_3296_3317(destination))), ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 3407, 3646);

                var
                conversion = (DynAbs.Tracing.TraceSender.Conditional_F1(10842, 3424, 3471) || (((resolution.IsEmpty || (DynAbs.Tracing.TraceSender.Expression_False(10842, 3425, 3470) || resolution.HasAnyErrors)) && DynAbs.Tracing.TraceSender.Conditional_F2(10842, 3491, 3514)) || DynAbs.Tracing.TraceSender.Conditional_F3(10842, 3534, 3645))) ? Conversion.NoConversion : f_10842_3534_3645(resolution.OverloadResolutionResult, resolution.MethodGroup, f_10842_3608_3644(f_10842_3608_3629(destination)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 3660, 3678);

                resolution.Free();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 3692, 3710);

                return conversion;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10842, 2814, 3721);

                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10842_3147_3168(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 3147, 3168);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10842_3255_3276(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 3255, 3276);
                    return return_v;
                }


                Microsoft.Cci.CallingConvention
                f_10842_3255_3294(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.CallingConvention;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 3255, 3294);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10842_3296_3317(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 3296, 3317);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CustomModifier>
                f_10842_3296_3349(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCallingConventionModifiers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 3296, 3349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CallingConventionInfo
                f_10842_3229_3350(Microsoft.Cci.CallingConvention
                callKind, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CustomModifier>
                unmanagedCallingConventionTypes)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CallingConventionInfo(callKind, unmanagedCallingConventionTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 3229, 3350);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodGroupResolution
                f_10842_3034_3392(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                source, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                delegateInvokeMethodOpt, bool
                isFunctionPointer, Microsoft.CodeAnalysis.CSharp.CallingConventionInfo
                callingConventionInfo, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = ResolveDelegateOrFunctionPointerMethodGroup(binder, source, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)delegateInvokeMethodOpt, isFunctionPointer: isFunctionPointer, callingConventionInfo, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 3034, 3392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10842_3608_3629(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 3608, 3629);
                    return return_v;
                }


                int
                f_10842_3608_3644(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 3608, 3644);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10842_3534_3645(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                result, Microsoft.CodeAnalysis.CSharp.MethodGroup
                methodGroup, int
                parameterCount)
                {
                    var return_v = ToConversion(result, methodGroup, parameterCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 3534, 3645);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10842, 2814, 3721);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10842, 2814, 3721);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Conversion GetInterpolatedStringConversion(BoundInterpolatedString source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10842, 3733, 4458);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 4068, 4447);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10842, 4075, 4371) || (((f_10842_4076_4208(destination, f_10842_4107_4170(f_10842_4107_4118(), WellKnownType.System_IFormattable), TypeCompareKind.ConsiderEverything2) || (DynAbs.Tracing.TraceSender.Expression_False(10842, 4076, 4370) || f_10842_4233_4370(destination, f_10842_4264_4332(f_10842_4264_4275(), WellKnownType.System_FormattableString), TypeCompareKind.ConsiderEverything2)))
                && DynAbs.Tracing.TraceSender.Conditional_F2(10842, 4391, 4420)) || DynAbs.Tracing.TraceSender.Conditional_F3(10842, 4423, 4446))) ? Conversion.InterpolatedString : Conversion.NoConversion;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10842, 3733, 4458);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10842_4107_4118()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 4107, 4118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10842_4107_4170(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 4107, 4170);
                    return return_v;
                }


                bool
                f_10842_4076_4208(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 4076, 4208);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10842_4264_4275()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 4264, 4275);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10842_4264_4332(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 4264, 4332);
                    return return_v;
                }


                bool
                f_10842_4233_4370(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 4233, 4370);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10842, 3733, 4458);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10842, 3733, 4458);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static MethodGroupResolution ResolveDelegateOrFunctionPointerMethodGroup(Binder binder, BoundMethodGroup source, MethodSymbol delegateInvokeMethodOpt, bool isFunctionPointer, in CallingConventionInfo callingConventionInfo, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10842, 4672, 5965);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 4975, 5954) || true) && ((object)delegateInvokeMethodOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 4975, 5954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 5052, 5108);

                    var
                    analyzedArguments = f_10842_5076_5107()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 5126, 5254);

                    f_10842_5126_5253(source.Syntax, analyzedArguments, f_10842_5198_5232(delegateInvokeMethodOpt), f_10842_5234_5252(binder));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 5272, 5673);

                    var
                    resolution = f_10842_5289_5672(binder, source, analyzedArguments, useSiteDiagnostics: ref useSiteDiagnostics, inferWithDynamic: true, isMethodGroupConversion: true, returnRefKind: f_10842_5477_5508(delegateInvokeMethodOpt), returnType: f_10842_5522_5556(delegateInvokeMethodOpt), isFunctionPointerResolution: isFunctionPointer, callingConventionInfo: callingConventionInfo)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 5691, 5716);

                    f_10842_5691_5715(analyzedArguments);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 5734, 5752);

                    return resolution;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 4975, 5954);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 4975, 5954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 5818, 5939);

                    return f_10842_5825_5938(binder, source, analyzedArguments: null, isMethodGroupConversion: true, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 4975, 5954);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10842, 4672, 5965);

                Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                f_10842_5076_5107()
                {
                    var return_v = AnalyzedArguments.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 5076, 5107);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10842_5198_5232(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 5198, 5232);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10842_5234_5252(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 5234, 5252);
                    return return_v;
                }


                int
                f_10842_5126_5253(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                delegateParameters, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    GetDelegateOrFunctionPointerArguments(syntax, analyzedArguments, delegateParameters, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 5126, 5253);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10842_5477_5508(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 5477, 5508);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10842_5522_5556(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 5522, 5556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodGroupResolution
                f_10842_5289_5672(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                node, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                inferWithDynamic, bool
                isMethodGroupConversion, Microsoft.CodeAnalysis.RefKind
                returnRefKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                returnType, bool
                isFunctionPointerResolution, Microsoft.CodeAnalysis.CSharp.CallingConventionInfo
                callingConventionInfo)
                {
                    var return_v = this_param.ResolveMethodGroup(node, analyzedArguments, useSiteDiagnostics: ref useSiteDiagnostics, inferWithDynamic: inferWithDynamic, isMethodGroupConversion: isMethodGroupConversion, returnRefKind: returnRefKind, returnType: returnType, isFunctionPointerResolution: isFunctionPointerResolution, callingConventionInfo: callingConventionInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 5289, 5672);
                    return return_v;
                }


                int
                f_10842_5691_5715(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 5691, 5715);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MethodGroupResolution
                f_10842_5825_5938(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                node, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, bool
                isMethodGroupConversion, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ResolveMethodGroup(node, analyzedArguments: analyzedArguments, isMethodGroupConversion: isMethodGroupConversion, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 5825, 5938);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10842, 4672, 5965);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10842, 4672, 5965);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static (MethodSymbol, bool isFunctionPointer, CallingConventionInfo callingConventionInfo) GetDelegateInvokeOrFunctionPointerMethodIfAvailable(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10842, 6165, 7079);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 6357, 6596) || true) && (type is FunctionPointerTypeSymbol { Signature: { } signature })
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 6357, 6596);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 6457, 6581);

                    return (signature, true, f_10842_6482_6579(f_10842_6508_6535(signature), f_10842_6537_6578(signature)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 6357, 6596);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 6612, 6654);

                var
                delegateType = f_10842_6631_6653(type)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 6668, 6779) || true) && ((object)delegateType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 6668, 6779);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 6734, 6764);

                    return (null, false, default);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 6668, 6779);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 6795, 6857);

                MethodSymbol
                methodSymbol = f_10842_6823_6856(delegateType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 6871, 7014) || true) && ((object)methodSymbol == null || (DynAbs.Tracing.TraceSender.Expression_False(10842, 6875, 6935) || f_10842_6907_6935(methodSymbol)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 6871, 7014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 6969, 6999);

                    return (null, false, default);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 6871, 7014);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 7030, 7068);

                return (methodSymbol, false, default);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10842, 6165, 7079);

                Microsoft.Cci.CallingConvention
                f_10842_6508_6535(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.CallingConvention;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 6508, 6535);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CustomModifier>
                f_10842_6537_6578(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCallingConventionModifiers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 6537, 6578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CallingConventionInfo
                f_10842_6482_6579(Microsoft.Cci.CallingConvention
                callKind, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CustomModifier>
                unmanagedCallingConventionTypes)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CallingConventionInfo(callKind, unmanagedCallingConventionTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 6482, 6579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10842_6631_6653(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 6631, 6653);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10842_6823_6856(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 6823, 6856);
                    return return_v;
                }


                bool
                f_10842_6907_6935(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.HasUseSiteError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 6907, 6935);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10842, 6165, 7079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10842, 6165, 7079);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool ReportDelegateOrFunctionPointerMethodGroupDiagnostics(Binder binder, BoundMethodGroup expr, TypeSymbol targetType, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10842, 7091, 11787);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 7276, 7406);

                var (invokeMethodOpt, isFunctionPointer, callingConventionInfo) = f_10842_7342_7405(targetType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 7420, 7470);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 7484, 7642);

                var
                resolution = f_10842_7501_7641(binder, expr, invokeMethodOpt, isFunctionPointer, callingConventionInfo, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 7656, 7705);

                f_10842_7656_7704(diagnostics, expr.Syntax, useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 7721, 7762);

                bool
                hasErrors = resolution.HasAnyErrors
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 7778, 7823);

                f_10842_7778_7822(
                            diagnostics, resolution.Diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 8561, 11711) || true) && (resolution.MethodGroup != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 8561, 11711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 8629, 8678);

                    var
                    result = resolution.OverloadResolutionResult
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 8696, 11696) || true) && (result != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 8696, 11696);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 8756, 11677) || true) && (f_10842_8760_8776(result))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 8756, 11677);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 8826, 8864);

                            var
                            method = result.BestResult.Member
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 8890, 8927);

                            f_10842_8890_8926((object)method != null);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 8953, 10313) || true) && (f_10842_8957_9002(resolution.MethodGroup))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 8953, 10313);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 9060, 9099);

                                f_10842_9060_9098(f_10842_9073_9097(method));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 9131, 9172);

                                var
                                thisParameter = f_10842_9151_9168(method)[0]
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 9202, 9762) || true) && (f_10842_9206_9241_M(!f_10842_9207_9225(thisParameter).IsReferenceType))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 9202, 9762);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 9429, 9680);

                                    f_10842_9429_9679(                                // Extension method '{0}' defined on value type '{1}' cannot be used to create delegates
                                                                    diagnostics, ErrorCode.ERR_ValueTypeExtDelegate, f_10842_9556_9576(expr.Syntax), method, f_10842_9660_9678(thisParameter));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 9714, 9731);

                                    hasErrors = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 9202, 9762);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 8953, 10313);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 8953, 10313);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 9820, 10313) || true) && (f_10842_9824_9862(f_10842_9824_9845(method)) && (DynAbs.Tracing.TraceSender.Expression_True(10842, 9824, 9884) && f_10842_9866_9884_M(!method.IsOverride)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 9820, 10313);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 10059, 10239);

                                    f_10842_10059_10238(                            // CS1728: Cannot bind delegate to '{0}' because it is a member of 'System.Nullable<T>'
                                                                diagnostics, ErrorCode.ERR_DelegateOnNullable, f_10842_10176_10196(expr.Syntax), method);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 10269, 10286);

                                    hasErrors = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 9820, 10313);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 8953, 10313);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 8756, 11677);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 8756, 11677);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 10363, 11677) || true) && (!hasErrors && (DynAbs.Tracing.TraceSender.Expression_True(10842, 10367, 10429) && f_10842_10410_10429_M(!resolution.IsEmpty)) && (DynAbs.Tracing.TraceSender.Expression_True(10842, 10367, 10510) && resolution.ResultKind == LookupResultKind.Viable))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 10363, 11677);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 10560, 10614);

                                var
                                overloadDiagnostics = f_10842_10586_10613()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 10642, 11318);

                                f_10842_10642_11317(
                                                        result, binder: binder, location: f_10842_10723_10743(expr.Syntax), nodeOpt: expr.Syntax, diagnostics: overloadDiagnostics, name: f_10842_10836_10845(expr), receiver: f_10842_10886_10917(resolution.MethodGroup), invokedExpression: expr.Syntax, arguments: resolution.AnalyzedArguments, memberGroup: f_10842_11034_11078(f_10842_11034_11064(resolution.MethodGroup)), typeContainingConstructor: null, delegateTypeBeingInvoked: null, isMethodGroupConversion: true, returnRefKind: f_10842_11249_11273_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(invokeMethodOpt, 10842, 11249, 11273)?.RefKind), delegateOrFunctionPointerType: targetType);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 11346, 11599) || true) && (f_10842_11350_11395_M(!overloadDiagnostics.IsEmptyWithoutResolution))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 11346, 11599);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 11453, 11500);

                                    hasErrors = f_10842_11465_11499(overloadDiagnostics);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 11530, 11572);

                                    f_10842_11530_11571(diagnostics, overloadDiagnostics);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 11346, 11599);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 11627, 11654);

                                f_10842_11627_11653(
                                                        overloadDiagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 10363, 11677);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 8756, 11677);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 8696, 11696);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 8561, 11711);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 11727, 11745);

                resolution.Free();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 11759, 11776);

                return hasErrors;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10842, 7091, 11787);

                (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, bool isFunctionPointer, Microsoft.CodeAnalysis.CSharp.CallingConventionInfo callingConventionInfo)
                f_10842_7342_7405(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = GetDelegateInvokeOrFunctionPointerMethodIfAvailable(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 7342, 7405);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodGroupResolution
                f_10842_7501_7641(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                source, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                delegateInvokeMethodOpt, bool
                isFunctionPointer, Microsoft.CodeAnalysis.CSharp.CallingConventionInfo
                callingConventionInfo, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = ResolveDelegateOrFunctionPointerMethodGroup(binder, source, delegateInvokeMethodOpt, isFunctionPointer, callingConventionInfo, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 7501, 7641);
                    return return_v;
                }


                bool
                f_10842_7656_7704(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 7656, 7704);
                    return return_v;
                }


                int
                f_10842_7778_7822(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 7778, 7822);
                    return 0;
                }


                bool
                f_10842_8760_8776(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.Succeeded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 8760, 8776);
                    return return_v;
                }


                int
                f_10842_8890_8926(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 8890, 8926);
                    return 0;
                }


                bool
                f_10842_8957_9002(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.IsExtensionMethodGroup;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 8957, 9002);
                    return return_v;
                }


                bool
                f_10842_9073_9097(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 9073, 9097);
                    return return_v;
                }


                int
                f_10842_9060_9098(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 9060, 9098);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10842_9151_9168(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 9151, 9168);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10842_9207_9225(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 9207, 9225);
                    return return_v;
                }


                bool
                f_10842_9206_9241_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 9206, 9241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10842_9556_9576(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 9556, 9576);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10842_9660_9678(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 9660, 9678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10842_9429_9679(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 9429, 9679);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10842_9824_9845(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 9824, 9845);
                    return return_v;
                }


                bool
                f_10842_9824_9862(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 9824, 9862);
                    return return_v;
                }


                bool
                f_10842_9866_9884_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 9866, 9884);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10842_10176_10196(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 10176, 10196);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10842_10059_10238(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 10059, 10238);
                    return return_v;
                }


                bool
                f_10842_10410_10429_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 10410, 10429);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10842_10586_10613()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 10586, 10613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10842_10723_10743(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 10723, 10743);
                    return return_v;
                }


                string
                f_10842_10836_10845(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 10836, 10845);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10842_10886_10917(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 10886, 10917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10842_11034_11064(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.Methods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 11034, 11064);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10842_11034_11078(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 11034, 11078);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind?
                f_10842_11249_11273_M(Microsoft.CodeAnalysis.RefKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 11249, 11273);
                    return return_v;
                }


                int
                f_10842_10642_11317(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.SyntaxNode
                nodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, string
                name, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.SyntaxNode
                invokedExpression, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                memberGroup, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeContainingConstructor, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateTypeBeingInvoked, bool
                isMethodGroupConversion, Microsoft.CodeAnalysis.RefKind?
                returnRefKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                delegateOrFunctionPointerType)
                {
                    this_param.ReportDiagnostics<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(binder: binder, location: location, nodeOpt: nodeOpt, diagnostics: diagnostics, name: name, receiver: receiver, invokedExpression: invokedExpression, arguments: arguments, memberGroup: memberGroup, typeContainingConstructor: typeContainingConstructor, delegateTypeBeingInvoked: delegateTypeBeingInvoked, isMethodGroupConversion: isMethodGroupConversion, returnRefKind: returnRefKind, delegateOrFunctionPointerType: delegateOrFunctionPointerType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 10642, 11317);
                    return 0;
                }


                bool
                f_10842_11350_11395_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 11350, 11395);
                    return return_v;
                }


                bool
                f_10842_11465_11499(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 11465, 11499);
                    return return_v;
                }


                int
                f_10842_11530_11571(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 11530, 11571);
                    return 0;
                }


                int
                f_10842_11627_11653(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 11627, 11653);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10842, 7091, 11787);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10842, 7091, 11787);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Conversion MethodGroupConversion(SyntaxNode syntax, MethodGroup methodGroup, NamedTypeSymbol delegateType, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10842, 11799, 13289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 11985, 12041);

                var
                analyzedArguments = f_10842_12009_12040()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 12055, 12121);

                var
                result = f_10842_12068_12120()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 12135, 12196);

                var
                delegateInvokeMethod = f_10842_12162_12195(delegateType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 12212, 12392);

                f_10842_12212_12391((object)delegateInvokeMethod != null && (DynAbs.Tracing.TraceSender.Expression_True(10842, 12225, 12302) && f_10842_12265_12302_M(!delegateInvokeMethod.HasUseSiteError)), "This method should only be called for valid delegate types");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 12406, 12517);

                f_10842_12406_12516(syntax, analyzedArguments, f_10842_12471_12502(delegateInvokeMethod), f_10842_12504_12515());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 12531, 13062);

                f_10842_12531_13061(f_10842_12531_12557(_binder), methods: f_10842_12620_12639(methodGroup), typeArguments: f_10842_12673_12698(methodGroup), receiver: f_10842_12727_12747(methodGroup), arguments: analyzedArguments, result: result, useSiteDiagnostics: ref useSiteDiagnostics, isMethodGroupConversion: true, returnRefKind: f_10842_12970_12998(delegateInvokeMethod), returnType: f_10842_13029_13060(delegateInvokeMethod));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 13076, 13177);

                var
                conversion = f_10842_13093_13176(result, methodGroup, f_10842_13127_13175(f_10842_13127_13160(delegateType)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 13193, 13218);

                f_10842_13193_13217(
                            analyzedArguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 13232, 13246);

                f_10842_13232_13245(result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 13260, 13278);

                return conversion;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10842, 11799, 13289);

                Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                f_10842_12009_12040()
                {
                    var return_v = AnalyzedArguments.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 12009, 12040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10842_12068_12120()
                {
                    var return_v = OverloadResolutionResult<MethodSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 12068, 12120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10842_12162_12195(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 12162, 12195);
                    return return_v;
                }


                bool
                f_10842_12265_12302_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 12265, 12302);
                    return return_v;
                }


                int
                f_10842_12212_12391(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 12212, 12391);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10842_12471_12502(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 12471, 12502);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10842_12504_12515()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 12504, 12515);
                    return return_v;
                }


                int
                f_10842_12406_12516(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                delegateParameters, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    GetDelegateOrFunctionPointerArguments(syntax, analyzedArguments, delegateParameters, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 12406, 12516);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.OverloadResolution
                f_10842_12531_12557(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.OverloadResolution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 12531, 12557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10842_12620_12639(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.Methods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 12620, 12639);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10842_12673_12698(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.TypeArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 12673, 12698);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10842_12727_12747(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 12727, 12747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10842_12970_12998(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 12970, 12998);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10842_13029_13060(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 13029, 13060);
                    return return_v;
                }


                int
                f_10842_12531_13061(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                methods, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                result, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                isMethodGroupConversion, Microsoft.CodeAnalysis.RefKind
                returnRefKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                returnType)
                {
                    this_param.MethodInvocationOverloadResolution(methods: methods, typeArguments: typeArguments, receiver: receiver, arguments: arguments, result: result, useSiteDiagnostics: ref useSiteDiagnostics, isMethodGroupConversion: isMethodGroupConversion, returnRefKind: returnRefKind, returnType: returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 12531, 13061);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10842_13127_13160(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 13127, 13160);
                    return return_v;
                }


                int
                f_10842_13127_13175(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 13127, 13175);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10842_13093_13176(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                result, Microsoft.CodeAnalysis.CSharp.MethodGroup
                methodGroup, int
                parameterCount)
                {
                    var return_v = ToConversion(result, methodGroup, parameterCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 13093, 13176);
                    return return_v;
                }


                int
                f_10842_13193_13217(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 13193, 13217);
                    return 0;
                }


                int
                f_10842_13232_13245(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 13232, 13245);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10842, 11799, 13289);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10842, 11799, 13289);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void GetDelegateOrFunctionPointerArguments(SyntaxNode syntax, AnalyzedArguments analyzedArguments, ImmutableArray<ParameterSymbol> delegateParameters, CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10842, 13301, 15112);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 13521, 15101);
                    foreach (var p in f_10842_13539_13557_I(delegateParameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 13521, 15101);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 13591, 13621);

                        ParameterSymbol
                        parameter = p
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 14241, 14895) || true) && (f_10842_14245_14271(f_10842_14245_14259(parameter)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 14241, 14895);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 14589, 14876);

                            parameter = f_10842_14601_14875(TypeWithAnnotations.Create(f_10842_14687_14740(compilation, SpecialType.System_Object), customModifiers: parameter.TypeWithAnnotations.CustomModifiers), f_10842_14807_14835(parameter), f_10842_14837_14855(parameter), f_10842_14857_14874(parameter));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 14241, 14895);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 14915, 15018);

                        f_10842_14915_15017(
                                        analyzedArguments.Arguments, new BoundParameter(syntax, parameter) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10842, 14947, 15016) });
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 15036, 15086);

                        f_10842_15036_15085(analyzedArguments.RefKinds, f_10842_15067_15084(parameter));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 13521, 15101);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10842, 1, 1581);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10842, 1, 1581);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10842, 13301, 15112);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10842_14245_14259(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 14245, 14259);
                    return return_v;
                }


                bool
                f_10842_14245_14271(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 14245, 14271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10842_14687_14740(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 14687, 14740);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10842_14807_14835(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 14807, 14835);
                    return return_v;
                }


                bool
                f_10842_14837_14855(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsParams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 14837, 14855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10842_14857_14874(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 14857, 14874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SignatureOnlyParameterSymbol
                f_10842_14601_14875(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                refCustomModifiers, bool
                isParams, Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SignatureOnlyParameterSymbol(type, refCustomModifiers, isParams, refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 14601, 14875);
                    return return_v;
                }


                int
                f_10842_14915_15017(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundParameter
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 14915, 15017);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10842_15067_15084(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 15067, 15084);
                    return return_v;
                }


                int
                f_10842_15036_15085(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param, Microsoft.CodeAnalysis.RefKind
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 15036, 15085);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10842_13539_13557_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 13539, 13557);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10842, 13301, 15112);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10842, 13301, 15112);
            }
        }

        private static Conversion ToConversion(OverloadResolutionResult<MethodSymbol> result, MethodGroup methodGroup, int parameterCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10842, 15124, 18261);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 16474, 16575) || true) && (f_10842_16478_16495_M(!result.Succeeded))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 16474, 16575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 16529, 16560);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 16474, 16575);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 16591, 16638);

                MethodSymbol
                method = result.BestResult.Member
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 16654, 16818) || true) && (f_10842_16658_16692(methodGroup) && (DynAbs.Tracing.TraceSender.Expression_True(10842, 16658, 16738) && f_10842_16696_16738_M(!f_10842_16697_16722(f_10842_16697_16714(method)[0]).IsReferenceType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 16654, 16818);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 16772, 16803);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 16654, 16818);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 16905, 17141) || true) && (f_10842_16909_16940(method) && (DynAbs.Tracing.TraceSender.Expression_True(10842, 16909, 16972) && f_10842_16944_16964(methodGroup) != null) && (DynAbs.Tracing.TraceSender.Expression_True(10842, 16909, 17013) && f_10842_16976_17001(f_10842_16976_16996(methodGroup)) is not null) && (DynAbs.Tracing.TraceSender.Expression_True(10842, 16909, 17061) && f_10842_17017_17061(f_10842_17017_17042(f_10842_17017_17037(methodGroup)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 16905, 17141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 17095, 17126);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 16905, 17141);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 17157, 17301) || true) && (f_10842_17161_17199(f_10842_17161_17182(method)) && (DynAbs.Tracing.TraceSender.Expression_True(10842, 17161, 17221) && f_10842_17203_17221_M(!method.IsOverride)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 17157, 17301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 17255, 17286);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 17157, 17301);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 18039, 18140);

                f_10842_18039_18139(f_10842_18052_18073(method) == parameterCount + ((DynAbs.Tracing.TraceSender.Conditional_F1(10842, 18095, 18129) || ((f_10842_18095_18129(methodGroup) && DynAbs.Tracing.TraceSender.Conditional_F2(10842, 18132, 18133)) || DynAbs.Tracing.TraceSender.Conditional_F3(10842, 18136, 18137))) ? 1 : 0));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 18156, 18250);

                return f_10842_18163_18249(ConversionKind.MethodGroup, method, f_10842_18214_18248(methodGroup));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10842, 15124, 18261);

                bool
                f_10842_16478_16495_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 16478, 16495);
                    return return_v;
                }


                bool
                f_10842_16658_16692(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.IsExtensionMethodGroup;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 16658, 16692);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10842_16697_16714(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 16697, 16714);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10842_16697_16722(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 16697, 16722);
                    return return_v;
                }


                bool
                f_10842_16696_16738_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 16696, 16738);
                    return return_v;
                }


                bool
                f_10842_16909_16940(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RequiresInstanceReceiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 16909, 16940);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10842_16944_16964(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 16944, 16964);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10842_16976_16996(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 16976, 16996);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10842_16976_17001(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 16976, 17001);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10842_17017_17037(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 17017, 17037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10842_17017_17042(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 17017, 17042);
                    return return_v;
                }


                bool
                f_10842_17017_17061(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsRestrictedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 17017, 17061);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10842_17161_17182(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 17161, 17182);
                    return return_v;
                }


                bool
                f_10842_17161_17199(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 17161, 17199);
                    return return_v;
                }


                bool
                f_10842_17203_17221_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 17203, 17221);
                    return return_v;
                }


                int
                f_10842_18052_18073(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 18052, 18073);
                    return return_v;
                }


                bool
                f_10842_18095_18129(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.IsExtensionMethodGroup;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 18095, 18129);
                    return return_v;
                }


                int
                f_10842_18039_18139(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 18039, 18139);
                    return 0;
                }


                bool
                f_10842_18214_18248(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.IsExtensionMethodGroup;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 18214, 18248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10842_18163_18249(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                conversionMethod, bool
                isExtensionMethod)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, conversionMethod, isExtensionMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 18163, 18249);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10842, 15124, 18261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10842, 15124, 18261);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Conversion GetStackAllocConversion(BoundStackAllocArrayCreation sourceExpression, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10842, 18273, 19902);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 18467, 19844) || true) && (f_10842_18471_18508(sourceExpression))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 18467, 19844);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 18542, 18594);

                    f_10842_18542_18593((object)f_10842_18563_18584(sourceExpression) == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 18612, 18671);

                    f_10842_18612_18670((object)f_10842_18633_18661(sourceExpression) != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 18691, 18793);

                    var
                    sourceAsPointer = f_10842_18713_18792(TypeWithAnnotations.Create(f_10842_18762_18790(sourceExpression)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 18811, 18924);

                    var
                    pointerConversion = f_10842_18835_18923(this, sourceAsPointer, destination, ref useSiteDiagnostics)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 18944, 19829) || true) && (pointerConversion.IsValid)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 18944, 19829);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 19015, 19080);

                        return Conversion.MakeStackAllocToPointerType(pointerConversion);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 18944, 19829);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 18944, 19829);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 19162, 19255);

                        var
                        spanType = f_10842_19177_19254(_binder, WellKnownType.System_Span_T, ref useSiteDiagnostics)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 19277, 19810) || true) && (f_10842_19281_19298(spanType) == TypeKind.Struct && (DynAbs.Tracing.TraceSender.Expression_True(10842, 19281, 19343) && f_10842_19321_19343(spanType)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 19277, 19810);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 19393, 19459);

                            var
                            spanType_T = f_10842_19410_19458(spanType, f_10842_19429_19457(sourceExpression))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 19485, 19590);

                            var
                            spanConversion = f_10842_19506_19589(this, spanType_T, destination, ref useSiteDiagnostics)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 19618, 19787) || true) && (spanConversion.Exists)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10842, 19618, 19787);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 19701, 19760);

                                return Conversion.MakeStackAllocToSpanType(spanConversion);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 19618, 19787);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 19277, 19810);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 18944, 19829);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10842, 18467, 19844);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10842, 19860, 19891);

                return Conversion.NoConversion;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10842, 18273, 19902);

                bool
                f_10842_18471_18508(Microsoft.CodeAnalysis.CSharp.BoundStackAllocArrayCreation
                this_param)
                {
                    var return_v = this_param.NeedsToBeConverted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 18471, 18508);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10842_18563_18584(Microsoft.CodeAnalysis.CSharp.BoundStackAllocArrayCreation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 18563, 18584);
                    return return_v;
                }


                int
                f_10842_18542_18593(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 18542, 18593);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10842_18633_18661(Microsoft.CodeAnalysis.CSharp.BoundStackAllocArrayCreation
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 18633, 18661);
                    return return_v;
                }


                int
                f_10842_18612_18670(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 18612, 18670);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10842_18762_18790(Microsoft.CodeAnalysis.CSharp.BoundStackAllocArrayCreation
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 18762, 18790);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                f_10842_18713_18792(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                pointedAtType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol(pointedAtType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 18713, 18792);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10842_18835_18923(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitConversionFromType((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 18835, 18923);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10842_19177_19254(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.GetWellKnownType(type, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 19177, 19254);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10842_19281_19298(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 19281, 19298);
                    return return_v;
                }


                bool
                f_10842_19321_19343(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsRefLikeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 19321, 19343);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10842_19429_19457(Microsoft.CodeAnalysis.CSharp.BoundStackAllocArrayCreation
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 19429, 19457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10842_19410_19458(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 19410, 19458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10842_19506_19589(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitConversionFromType((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10842, 19506, 19589);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10842, 18273, 19902);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10842, 18273, 19902);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static Conversions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10842, 439, 19909);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10842, 439, 19909);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10842, 439, 19909);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10842, 439, 19909);

        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10842_605_611_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10842, 551, 714);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10842_866_884(Microsoft.CodeAnalysis.CSharp.Binder
        this_param)
        {
            var return_v = this_param.Compilation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 866, 884);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10842_866_893(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.Assembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 866, 893);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10842_866_904(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        this_param)
        {
            var return_v = this_param.CorLibrary;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10842, 866, 904);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10842_866_904_C(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10842, 726, 1022);
            return return_v;
        }

    }
}
