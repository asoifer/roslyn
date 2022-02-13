// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.Cci;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal enum BetterResult
    {
        Left,
        Right,
        Neither,
        Equal
    }
    internal sealed partial class OverloadResolution
    {
        private readonly Binder _binder;

        public OverloadResolution(Binder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10874, 796, 889);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 776, 783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 1261, 1268);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 861, 878);

                _binder = binder;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10874, 796, 889);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 796, 889);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 796, 889);
            }
        }

        private CSharpCompilation Compilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 963, 998);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 969, 996);

                    return f_10874_976_995(_binder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 963, 998);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10874_976_995(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 976, 995);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 901, 1009);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 901, 1009);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Conversions Conversions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 1077, 1112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 1083, 1110);

                    return f_10874_1090_1109(_binder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 1077, 1112);

                    Microsoft.CodeAnalysis.CSharp.Conversions
                    f_10874_1090_1109(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.Conversions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 1090, 1109);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 1021, 1123);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 1021, 1123);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool? _strict;

        private bool Strict
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 1323, 1554);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 1359, 1402) || true) && (f_10874_1363_1379(_strict))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 1359, 1402);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 1381, 1402);

                        return f_10874_1388_1401(_strict);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 1359, 1402);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 1420, 1474);

                    bool
                    value = f_10874_1433_1473(f_10874_1433_1452(_binder))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 1492, 1508);

                    _strict = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 1526, 1539);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 1323, 1554);

                    bool
                    f_10874_1363_1379(bool?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 1363, 1379);
                        return return_v;
                    }


                    bool
                    f_10874_1388_1401(bool?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 1388, 1401);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10874_1433_1452(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 1433, 1452);
                        return return_v;
                    }


                    bool
                    f_10874_1433_1473(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.FeatureStrictEnabled;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 1433, 1473);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 1279, 1565);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 1279, 1565);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static bool AnyValidResult<TMember>(ArrayBuilder<MemberResolutionResult<TMember>> results)
                    where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 1923, 2292);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 2082, 2252);
                    foreach (var result in f_10874_2105_2112_I(results))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 2082, 2252);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 2146, 2237) || true) && (result.IsValid)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 2146, 2237);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 2206, 2218);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 2146, 2237);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 2082, 2252);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 171);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 171);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 2268, 2281);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 1923, 2292);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                f_10874_2105_2112_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 2105, 2112);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 1923, 2292);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 1923, 2292);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool SingleValidResult<TMember>(ArrayBuilder<MemberResolutionResult<TMember>> results)
                    where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 2304, 2841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 2466, 2488);

                bool
                oneValid = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 2502, 2798);
                    foreach (var result in f_10874_2525_2532_I(results))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 2502, 2798);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 2566, 2783) || true) && (result.IsValid)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 2566, 2783);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 2626, 2724) || true) && (oneValid)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 2626, 2724);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 2688, 2701);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 2626, 2724);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 2748, 2764);

                            oneValid = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 2566, 2783);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 2502, 2798);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 297);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 297);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 2814, 2830);

                return oneValid;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 2304, 2841);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                f_10874_2525_2532_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 2525, 2532);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 2304, 2841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 2304, 2841);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void ObjectCreationOverloadResolution(ImmutableArray<MethodSymbol> constructors, AnalyzedArguments arguments, OverloadResolutionResult<MethodSymbol> result, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 3034, 3910);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 3270, 3306);

                var
                results = result.ResultsBuilder
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 3403, 3508);

                f_10874_3403_3507(this, results, constructors, arguments, false, ref useSiteDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 3524, 3899) || true) && (!f_10874_3529_3599(results, f_10874_3570_3598(arguments)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 3524, 3899);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 3747, 3762);

                    f_10874_3747_3761(                // We didn't get a single good result. Get full results of overload resolution and return those.
                                    result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 3780, 3884);

                    f_10874_3780_3883(this, results, constructors, arguments, true, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 3524, 3899);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 3034, 3910);

                int
                f_10874_3403_3507(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>>
                results, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                constructors, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, bool
                completeResults, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.PerformObjectCreationOverloadResolution(results, constructors, arguments, completeResults, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 3403, 3507);
                    return 0;
                }


                bool
                f_10874_3570_3598(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param)
                {
                    var return_v = this_param.HasDynamicArgument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 3570, 3598);
                    return return_v;
                }


                bool
                f_10874_3529_3599(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>>
                results, bool
                hasDynamicArgument)
                {
                    var return_v = OverloadResolutionResultIsValid(results, hasDynamicArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 3529, 3599);
                    return return_v;
                }


                int
                f_10874_3747_3761(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 3747, 3761);
                    return 0;
                }


                int
                f_10874_3780_3883(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>>
                results, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                constructors, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, bool
                completeResults, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.PerformObjectCreationOverloadResolution(results, constructors, arguments, completeResults, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 3780, 3883);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 3034, 3910);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 3034, 3910);
            }
        }

        public void MethodInvocationOverloadResolution(
                    ArrayBuilder<MethodSymbol> methods,
                    ArrayBuilder<TypeWithAnnotations> typeArguments,
                    BoundExpression receiver,
                    AnalyzedArguments arguments,
                    OverloadResolutionResult<MethodSymbol> result,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                    bool isMethodGroupConversion = false,
                    bool allowRefOmittedArguments = false,
                    bool inferWithDynamic = false,
                    bool allowUnexpandedForm = true,
                    RefKind returnRefKind = default,
                    TypeSymbol returnType = null,
                    bool isFunctionPointerResolution = false,
                    in CallingConventionInfo callingConventionInfo = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 4103, 5243);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 4896, 5232);

                f_10874_4896_5231(this, methods, typeArguments, receiver, arguments, result, isMethodGroupConversion, allowRefOmittedArguments, ref useSiteDiagnostics, inferWithDynamic, allowUnexpandedForm, returnRefKind, returnType, isFunctionPointerResolution, callingConventionInfo);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 4103, 5243);

                int
                f_10874_4896_5231(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                members, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                result, bool
                isMethodGroupConversion, bool
                allowRefOmittedArguments, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                inferWithDynamic, bool
                allowUnexpandedForm, Microsoft.CodeAnalysis.RefKind
                returnRefKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                returnType, bool
                isFunctionPointerResolution, Microsoft.CodeAnalysis.CSharp.CallingConventionInfo
                callingConventionInfo)
                {
                    this_param.MethodOrPropertyOverloadResolution<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(members, typeArguments, receiver, arguments, result, isMethodGroupConversion, allowRefOmittedArguments, ref useSiteDiagnostics, inferWithDynamic, allowUnexpandedForm, returnRefKind, returnType, isFunctionPointerResolution, callingConventionInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 4896, 5231);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 4103, 5243);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 4103, 5243);
            }
        }

        public void PropertyOverloadResolution(
                    ArrayBuilder<PropertySymbol> indexers,
                    BoundExpression receiverOpt,
                    AnalyzedArguments arguments,
                    OverloadResolutionResult<PropertySymbol> result,
                    bool allowRefOmittedArguments,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 5438, 6267);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 5805, 5903);

                ArrayBuilder<TypeWithAnnotations>
                typeArguments = f_10874_5855_5902()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 5917, 6221);

                f_10874_5917_6220(this, indexers, typeArguments, receiverOpt, arguments, result, isMethodGroupConversion: false, allowRefOmittedArguments: allowRefOmittedArguments, useSiteDiagnostics: ref useSiteDiagnostics, callingConventionInfo: default);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 6235, 6256);

                f_10874_6235_6255(typeArguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 5438, 6267);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10874_5855_5902()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 5855, 5902);
                    return return_v;
                }


                int
                f_10874_5917_6220(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                members, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                result, bool
                isMethodGroupConversion, bool
                allowRefOmittedArguments, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Microsoft.CodeAnalysis.CSharp.CallingConventionInfo
                callingConventionInfo)
                {
                    this_param.MethodOrPropertyOverloadResolution<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>(members, typeArguments, receiver, arguments, result, isMethodGroupConversion: isMethodGroupConversion, allowRefOmittedArguments: allowRefOmittedArguments, useSiteDiagnostics: ref useSiteDiagnostics, callingConventionInfo: callingConventionInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 5917, 6220);
                    return 0;
                }


                int
                f_10874_6235_6255(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 6235, 6255);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 5438, 6267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 5438, 6267);
            }
        }

        internal void MethodOrPropertyOverloadResolution<TMember>(
                    ArrayBuilder<TMember> members,
                    ArrayBuilder<TypeWithAnnotations> typeArguments,
                    BoundExpression receiver,
                    AnalyzedArguments arguments,
                    OverloadResolutionResult<TMember> result,
                    bool isMethodGroupConversion,
                    bool allowRefOmittedArguments,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                    bool inferWithDynamic = false,
                    bool allowUnexpandedForm = true,
                    RefKind returnRefKind = default,
                    TypeSymbol returnType = null,
                    bool isFunctionPointerResolution = false,
                    in CallingConventionInfo callingConventionInfo = default)
                    where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 6279, 8269);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 7093, 7129);

                var
                results = result.ResultsBuilder
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 7226, 7581);

                f_10874_7226_7580<TMember>(this, results, members, typeArguments, receiver, arguments, completeResults: false, isMethodGroupConversion, returnRefKind, returnType, allowRefOmittedArguments, isFunctionPointerResolution, callingConventionInfo, ref useSiteDiagnostics, inferWithDynamic, allowUnexpandedForm);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 7597, 8258) || true) && (!f_10874_7602_7672<TMember>(results, f_10874_7643_7671<TMember>(arguments)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 7597, 8258);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 7820, 7835);

                    f_10874_7820_7834<TMember>(                // We didn't get a single good result. Get full results of overload resolution and return those.
                                    result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 7853, 8243);

                    f_10874_7853_8242<TMember>(this, results, members, typeArguments, receiver, arguments, completeResults: true, isMethodGroupConversion, returnRefKind, returnType, allowRefOmittedArguments, isFunctionPointerResolution, callingConventionInfo, ref useSiteDiagnostics, allowUnexpandedForm: allowUnexpandedForm);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 7597, 8258);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 6279, 8269);

                int
                f_10874_7226_7580<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                results, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>
                members, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, bool
                completeResults, bool
                isMethodGroupConversion, Microsoft.CodeAnalysis.RefKind
                returnRefKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                returnType, bool
                allowRefOmittedArguments, bool
                isFunctionPointerResolution, Microsoft.CodeAnalysis.CSharp.CallingConventionInfo
                callingConventionInfo, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                inferWithDynamic, bool
                allowUnexpandedForm) where TMember : Symbol

                {
                    this_param.PerformMemberOverloadResolution<TMember>(results, members, typeArguments, receiver, arguments, completeResults: completeResults, isMethodGroupConversion, returnRefKind, returnType, allowRefOmittedArguments, isFunctionPointerResolution, callingConventionInfo, ref useSiteDiagnostics, inferWithDynamic, allowUnexpandedForm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 7226, 7580);
                    return 0;
                }


                bool
                f_10874_7643_7671<TMember>(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.HasDynamicArgument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 7643, 7671);
                    return return_v;
                }


                bool
                f_10874_7602_7672<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                results, bool
                hasDynamicArgument) where TMember : Symbol

                {
                    var return_v = OverloadResolutionResultIsValid(results, hasDynamicArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 7602, 7672);
                    return return_v;
                }


                int
                f_10874_7820_7834<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<TMember>
                this_param) where TMember : Symbol

                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 7820, 7834);
                    return 0;
                }


                int
                f_10874_7853_8242<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                results, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>
                members, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, bool
                completeResults, bool
                isMethodGroupConversion, Microsoft.CodeAnalysis.RefKind
                returnRefKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                returnType, bool
                allowRefOmittedArguments, bool
                isFunctionPointerResolution, Microsoft.CodeAnalysis.CSharp.CallingConventionInfo
                callingConventionInfo, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                allowUnexpandedForm) where TMember : Symbol

                {
                    this_param.PerformMemberOverloadResolution<TMember>(results, members, typeArguments, receiver, arguments, completeResults: completeResults, isMethodGroupConversion, returnRefKind, returnType, allowRefOmittedArguments, isFunctionPointerResolution, callingConventionInfo, ref useSiteDiagnostics, allowUnexpandedForm: allowUnexpandedForm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 7853, 8242);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 6279, 8269);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 6279, 8269);
            }
        }

        private static bool OverloadResolutionResultIsValid<TMember>(ArrayBuilder<MemberResolutionResult<TMember>> results, bool hasDynamicArgument)
                    where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 8281, 9889);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 9512, 9828) || true) && (hasDynamicArgument)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 9512, 9828);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 9568, 9780);
                        foreach (var curResult in f_10874_9594_9601_I(results))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 9568, 9780);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 9643, 9761) || true) && (curResult.Result.IsApplicable)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 9643, 9761);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 9726, 9738);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 9643, 9761);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 9568, 9780);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 213);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 213);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 9800, 9813);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 9512, 9828);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 9844, 9878);

                return f_10874_9851_9877<TMember>(results);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 8281, 9889);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                f_10874_9594_9601_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 9594, 9601);
                    return return_v;
                }


                bool
                f_10874_9851_9877<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                results) where TMember : Symbol

                {
                    var return_v = SingleValidResult(results);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 9851, 9877);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 8281, 9889);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 8281, 9889);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void PerformMemberOverloadResolution<TMember>(
                    ArrayBuilder<MemberResolutionResult<TMember>> results,
                    ArrayBuilder<TMember> members,
                    ArrayBuilder<TypeWithAnnotations> typeArguments,
                    BoundExpression receiver,
                    AnalyzedArguments arguments,
                    bool completeResults,
                    bool isMethodGroupConversion,
                    RefKind returnRefKind,
                    TypeSymbol returnType,
                    bool allowRefOmittedArguments,
                    bool isFunctionPointerResolution,
                    in CallingConventionInfo callingConventionInfo,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                    bool inferWithDynamic = false,
                    bool allowUnexpandedForm = true)
                    where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 10159, 15270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 11963, 12042);

                Dictionary<NamedTypeSymbol, ArrayBuilder<TMember>>
                containingTypeMapOpt = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 12056, 12222) || true) && (f_10874_12060_12073<TMember>(members) > 50)
                ) // TODO: fine-tune this value

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 12056, 12222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 12142, 12207);

                    containingTypeMapOpt = f_10874_12165_12206<TMember>(members);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 12056, 12222);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 12340, 12345);

                    // SPEC: The set of candidate methods for the method invocation is constructed.
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 12331, 12784) || true) && (i < f_10874_12351_12364<TMember>(members))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 12366, 12369)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 12331, 12784))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 12331, 12784);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 12403, 12769);

                        f_10874_12403_12768<TMember>(this, f_10874_12449_12459<TMember>(members, i), results, members, typeArguments, receiver, arguments, completeResults, isMethodGroupConversion, allowRefOmittedArguments, containingTypeMapOpt, inferWithDynamic: inferWithDynamic, useSiteDiagnostics: ref useSiteDiagnostics, allowUnexpandedForm: allowUnexpandedForm);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 454);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 454);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 12883, 12932);

                f_10874_12883_12931<TMember>(ref containingTypeMapOpt);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 13143, 13208);

                f_10874_13143_13207<TMember>(this, results, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 13339, 13397);

                f_10874_13339_13396<TMember>(results, ref useSiteDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 13413, 13886) || true) && (f_10874_13417_13478<TMember>(f_10874_13417_13444<TMember>(f_10874_13417_13428<TMember>())))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 13413, 13886);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 13512, 13573);

                    f_10874_13512_13572<TMember>(this, results, arguments, receiver);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 13593, 13629);

                    f_10874_13593_13628<TMember>(this, results);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 13649, 13871) || true) && (isMethodGroupConversion)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 13649, 13871);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 13718, 13852);

                        f_10874_13718_13851<TMember>(this, results, ref useSiteDiagnostics, returnRefKind, returnType, isFunctionPointerResolution);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 13649, 13871);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 13413, 13886);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 13902, 14106) || true) && (isFunctionPointerResolution)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 13902, 14106);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 13967, 14033);

                    f_10874_13967_14032<TMember>(this, results, callingConventionInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 14051, 14091);

                    f_10874_14051_14090<TMember>(results);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 13902, 14106);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 14307, 14365);

                f_10874_14307_14364<TMember>(results, ref useSiteDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 14738, 14822) || true) && (!f_10874_14743_14766<TMember>(results))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 14738, 14822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 14800, 14807);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 14738, 14822);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 15062, 15125);

                f_10874_15062_15124<TMember>(this, results, arguments, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 10159, 15270);

                int
                f_10874_12060_12073<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 12060, 12073);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>>
                f_10874_12165_12206<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>
                members) where TMember : Symbol

                {
                    var return_v = PartitionMembersByContainingType(members);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 12165, 12206);
                    return return_v;
                }


                int
                f_10874_12351_12364<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 12351, 12364);
                    return return_v;
                }


                TMember
                f_10874_12449_12459<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 12449, 12459);
                    return return_v;
                }


                int
                f_10874_12403_12768<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, TMember
                member, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                results, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>
                members, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, bool
                completeResults, bool
                isMethodGroupConversion, bool
                allowRefOmittedArguments, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>>?
                containingTypeMapOpt, bool
                inferWithDynamic, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                allowUnexpandedForm) where TMember : Symbol

                {
                    this_param.AddMemberToCandidateSet<TMember>(member, results, members, typeArguments, receiverOpt, arguments, completeResults, isMethodGroupConversion, allowRefOmittedArguments, containingTypeMapOpt, inferWithDynamic: inferWithDynamic, useSiteDiagnostics: ref useSiteDiagnostics, allowUnexpandedForm: allowUnexpandedForm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 12403, 12768);
                    return 0;
                }


                int
                f_10874_12883_12931<TMember>(ref System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>>?
                containingTypeMapOpt) where TMember : Symbol

                {
                    ClearContainingTypeMap(ref containingTypeMapOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 12883, 12931);
                    return 0;
                }


                int
                f_10874_13143_13207<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                results, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    this_param.RemoveInaccessibleTypeArguments<TMember>(results, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 13143, 13207);
                    return 0;
                }


                int
                f_10874_13339_13396<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                results, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    RemoveLessDerivedMembers(results, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 13339, 13396);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10874_13417_13428<TMember>() where TMember : Symbol

                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 13417, 13428);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10874_13417_13444<TMember>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 13417, 13444);
                    return return_v;
                }


                bool
                f_10874_13417_13478<TMember>(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                self) where TMember : Symbol

                {
                    var return_v = self.AllowImprovedOverloadCandidates();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 13417, 13478);
                    return return_v;
                }


                int
                f_10874_13512_13572<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                results, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt) where TMember : Symbol

                {
                    this_param.RemoveStaticInstanceMismatches<TMember>(results, arguments, receiverOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 13512, 13572);
                    return 0;
                }


                int
                f_10874_13593_13628<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                results) where TMember : Symbol

                {
                    this_param.RemoveConstraintViolations<TMember>(results);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 13593, 13628);
                    return 0;
                }


                int
                f_10874_13718_13851<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                results, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Microsoft.CodeAnalysis.RefKind
                returnRefKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                returnType, bool
                isFunctionPointerConversion) where TMember : Symbol

                {
                    this_param.RemoveDelegateConversionsWithWrongReturnType<TMember>(results, ref useSiteDiagnostics, (Microsoft.CodeAnalysis.RefKind?)returnRefKind, returnType, isFunctionPointerConversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 13718, 13851);
                    return 0;
                }


                int
                f_10874_13967_14032<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                results, Microsoft.CodeAnalysis.CSharp.CallingConventionInfo
                expectedConvention) where TMember : Symbol

                {
                    this_param.RemoveCallingConventionMismatches<TMember>(results, expectedConvention);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 13967, 14032);
                    return 0;
                }


                int
                f_10874_14051_14090<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                results) where TMember : Symbol

                {
                    RemoveMethodsNotDeclaredStatic(results);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 14051, 14090);
                    return 0;
                }


                int
                f_10874_14307_14364<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                results, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    ReportUseSiteDiagnostics(results, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 14307, 14364);
                    return 0;
                }


                bool
                f_10874_14743_14766<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                results) where TMember : Symbol

                {
                    var return_v = AnyValidResult(results);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 14743, 14766);
                    return return_v;
                }


                int
                f_10874_15062_15124<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                results, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    this_param.RemoveWorseMembers<TMember>(results, arguments, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 15062, 15124);
                    return 0;
                }


                // Note, the caller is responsible for "final validation",
                // as that is not part of overload resolution.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 10159, 15270);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 10159, 15270);
            }
        }

        internal void FunctionPointerOverloadResolution(
                    ArrayBuilder<FunctionPointerMethodSymbol> funcPtrBuilder,
                    AnalyzedArguments analyzedArguments,
                    OverloadResolutionResult<FunctionPointerMethodSymbol> overloadResolutionResult,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 15282, 16523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 15630, 15670);

                f_10874_15630_15669(f_10874_15643_15663(funcPtrBuilder) == 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 15684, 15727);

                f_10874_15684_15726(f_10874_15697_15720(f_10874_15697_15714(funcPtrBuilder, 0)) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 15741, 15816);

                var
                typeArgumentsBuilder = f_10874_15768_15815()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 15832, 16406);

                f_10874_15832_16405(this, f_10874_15874_15891(funcPtrBuilder, 0), overloadResolutionResult.ResultsBuilder, funcPtrBuilder, typeArgumentsBuilder, receiverOpt: null, analyzedArguments, completeResults: true, isMethodGroupConversion: false, allowRefOmittedArguments: false, containingTypeMapOpt: null, inferWithDynamic: false, ref useSiteDiagnostics, allowUnexpandedForm: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 16422, 16512);

                f_10874_16422_16511(overloadResolutionResult.ResultsBuilder, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 15282, 16523);

                int
                f_10874_15643_15663(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 15643, 15663);
                    return return_v;
                }


                int
                f_10874_15630_15669(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 15630, 15669);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10874_15697_15714(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 15697, 15714);
                    return return_v;
                }


                int
                f_10874_15697_15720(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 15697, 15720);
                    return return_v;
                }


                int
                f_10874_15684_15726(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 15684, 15726);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10874_15768_15815()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 15768, 15815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10874_15874_15891(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 15874, 15891);
                    return return_v;
                }


                int
                f_10874_15832_16405(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                member, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol>>
                results, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol>
                members, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, bool
                completeResults, bool
                isMethodGroupConversion, bool
                allowRefOmittedArguments, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol>>
                containingTypeMapOpt, bool
                inferWithDynamic, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                allowUnexpandedForm)
                {
                    this_param.AddMemberToCandidateSet<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol>(member, results, members, typeArguments, receiverOpt: receiverOpt, arguments, completeResults: completeResults, isMethodGroupConversion: isMethodGroupConversion, allowRefOmittedArguments: allowRefOmittedArguments, containingTypeMapOpt: containingTypeMapOpt, inferWithDynamic: inferWithDynamic, ref useSiteDiagnostics, allowUnexpandedForm: allowUnexpandedForm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 15832, 16405);
                    return 0;
                }


                int
                f_10874_16422_16511(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol>>
                results, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    ReportUseSiteDiagnostics(results, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 16422, 16511);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 15282, 16523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 15282, 16523);
            }
        }

        private void RemoveStaticInstanceMismatches<TMember>(
                    ArrayBuilder<MemberResolutionResult<TMember>> results,
                    AnalyzedArguments arguments,
                    BoundExpression receiverOpt) where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 16535, 18342);
                bool inStaticContext = default(bool);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 17374, 17518) || true) && (arguments.IsExtensionMethodInvocation || (DynAbs.Tracing.TraceSender.Expression_False(10874, 17378, 17462) || f_10874_17419_17462<TMember>(receiverOpt)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 17374, 17518);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 17496, 17503);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 17374, 17518);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 17534, 17600);

                bool
                isImplicitReceiver = f_10874_17560_17599<TMember>(receiverOpt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 17804, 17910);

                bool
                isStaticContext = !f_10874_17828_17890<TMember>(_binder, !isImplicitReceiver, out inStaticContext) || (DynAbs.Tracing.TraceSender.Expression_False(10874, 17827, 17909) || inStaticContext)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 17924, 18022) || true) && (isImplicitReceiver && (DynAbs.Tracing.TraceSender.Expression_True(10874, 17928, 17966) && !isStaticContext))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 17924, 18022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 18000, 18007);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 17924, 18022);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 18156, 18263);

                bool
                keepStatic = isImplicitReceiver && (DynAbs.Tracing.TraceSender.Expression_True(10874, 18174, 18211) && isStaticContext) || (DynAbs.Tracing.TraceSender.Expression_False(10874, 18174, 18262) || f_10874_18215_18262<TMember>(receiverOpt))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 18279, 18331);

                f_10874_18279_18330<TMember>(results, keepStatic);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 16535, 18342);

                bool
                f_10874_17419_17462<TMember>(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression) where TMember : Symbol

                {
                    var return_v = Binder.IsTypeOrValueExpression(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 17419, 17462);
                    return return_v;
                }


                bool
                f_10874_17560_17599<TMember>(Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt) where TMember : Symbol

                {
                    var return_v = Binder.WasImplicitReceiver(receiverOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 17560, 17599);
                    return return_v;
                }


                bool
                f_10874_17828_17890<TMember>(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, bool
                isExplicit, out bool
                inStaticContext) where TMember : Symbol

                {
                    var return_v = this_param.HasThis(isExplicit, out inStaticContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 17828, 17890);
                    return return_v;
                }


                bool
                f_10874_18215_18262<TMember>(Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt) where TMember : Symbol

                {
                    var return_v = Binder.IsMemberAccessedThroughType(receiverOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 18215, 18262);
                    return return_v;
                }


                int
                f_10874_18279_18330<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                results, bool
                requireStatic) where TMember : Symbol

                {
                    RemoveStaticInstanceMismatches(results, requireStatic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 18279, 18330);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 16535, 18342);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 16535, 18342);
            }
        }

        private static void RemoveStaticInstanceMismatches<TMember>(ArrayBuilder<MemberResolutionResult<TMember>> results, bool requireStatic) where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 18354, 18999);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 18545, 18550);
                    for (int
        f = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 18536, 18988) || true) && (f < f_10874_18556_18569<TMember>(results))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 18571, 18574)
        , ++f, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 18536, 18988))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 18536, 18988);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 18608, 18632);

                        var
                        result = f_10874_18621_18631<TMember>(results, f)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 18650, 18681);

                        TMember
                        member = result.Member
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 18699, 18973) || true) && (result.Result.IsValid && (DynAbs.Tracing.TraceSender.Expression_True(10874, 18703, 18778) && f_10874_18728_18761<TMember>(member) == requireStatic))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 18699, 18973);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 18820, 18954);

                            results[f] = f_10874_18833_18953<TMember>(member, result.LeastOverriddenMember, MemberAnalysisResult.StaticInstanceMismatch());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 18699, 18973);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 453);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 453);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 18354, 18999);

                int
                f_10874_18556_18569<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 18556, 18569);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_18621_18631<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 18621, 18631);
                    return return_v;
                }


                bool
                f_10874_18728_18761<TMember>(TMember
                symbol) where TMember : Symbol

                {
                    var return_v = symbol.RequiresInstanceReceiver();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 18728, 18761);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_18833_18953<TMember>(TMember
                member, TMember
                leastOverriddenMember, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result) where TMember : Symbol

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>(member, leastOverriddenMember, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 18833, 18953);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 18354, 18999);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 18354, 18999);
            }
        }

        private static void RemoveMethodsNotDeclaredStatic<TMember>(ArrayBuilder<MemberResolutionResult<TMember>> results) where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 19011, 19872);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 19452, 19457);
                    // RemoveStaticInstanceMismatches allows methods that do not need a receiver but are not declared static,
                    // such as a local function that is not declared static. This eliminates methods that are not actually
                    // declared as static
                    for (int
        f = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 19443, 19861) || true) && (f < f_10874_19463_19476<TMember>(results))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 19478, 19481)
        , f++, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 19443, 19861))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 19443, 19861);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 19515, 19539);

                        var
                        result = f_10874_19528_19538<TMember>(results, f)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 19557, 19588);

                        TMember
                        member = result.Member
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 19606, 19846) || true) && (result.Result.IsValid && (DynAbs.Tracing.TraceSender.Expression_True(10874, 19610, 19651) && f_10874_19635_19651_M(!member.IsStatic)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 19606, 19846);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 19693, 19827);

                            results[f] = f_10874_19706_19826<TMember>(member, result.LeastOverriddenMember, MemberAnalysisResult.StaticInstanceMismatch());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 19606, 19846);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 419);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 419);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 19011, 19872);

                int
                f_10874_19463_19476<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 19463, 19476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_19528_19538<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 19528, 19538);
                    return return_v;
                }


                bool
                f_10874_19635_19651_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 19635, 19651);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_19706_19826<TMember>(TMember
                member, TMember
                leastOverriddenMember, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result) where TMember : Symbol

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>(member, leastOverriddenMember, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 19706, 19826);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 19011, 19872);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 19011, 19872);
            }
        }

        private void RemoveConstraintViolations<TMember>(ArrayBuilder<MemberResolutionResult<TMember>> results) where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 19884, 21410);
                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo> constraintFailureDiagnosticsOpt = default(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 20353, 20452) || true) && (typeof(TMember) != typeof(MethodSymbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 20353, 20452);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 20430, 20437);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 20353, 20452);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 20477, 20482);

                    for (int
        f = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 20468, 21399) || true) && (f < f_10874_20488_20501<TMember>(results))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 20503, 20506)
        , ++f, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 20468, 21399))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 20468, 21399);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 20540, 20564);

                        var
                        result = f_10874_20553_20563<TMember>(results, f)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 20582, 20631);

                        var
                        member = (MethodSymbol)(Symbol)result.Member
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 20836, 21384) || true) && ((result.Result.IsValid || (DynAbs.Tracing.TraceSender.Expression_False(10874, 20841, 20950) || result.Result.Kind == MemberResolutionKind.ConstructedParameterFailedConstraintCheck)) && (DynAbs.Tracing.TraceSender.Expression_True(10874, 20840, 21084) && f_10874_20976_21084<TMember>(this, member, out constraintFailureDiagnosticsOpt)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 20836, 21384);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 21126, 21365);

                            results[f] = f_10874_21139_21364<TMember>(result.Member, result.LeastOverriddenMember, MemberAnalysisResult.ConstraintFailure(f_10874_21310_21362<TMember>(constraintFailureDiagnosticsOpt)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 20836, 21384);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 932);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 932);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 19884, 21410);

                int
                f_10874_20488_20501<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 20488, 20501);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_20553_20563<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 20553, 20563);
                    return return_v;
                }


                bool
                f_10874_20976_21084<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, out Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                constraintFailureDiagnosticsOpt) where TMember : Symbol

                {
                    var return_v = this_param.FailsConstraintChecks(method, out constraintFailureDiagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 20976, 21084);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                f_10874_21310_21362<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 21310, 21362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_21139_21364<TMember>(TMember
                member, TMember
                leastOverriddenMember, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result) where TMember : Symbol

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>(member, leastOverriddenMember, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 21139, 21364);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 19884, 21410);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 19884, 21410);
            }
        }

#nullable enable
        private void RemoveCallingConventionMismatches<TMember>(ArrayBuilder<MemberResolutionResult<TMember>> results, in CallingConventionInfo expectedConvention) where TMember : Symbol
        {
            if (typeof(TMember) != typeof(MethodSymbol))
            {
                return;
            }

            Debug.Assert(!expectedConvention.CallKind.HasUnknownCallingConventionAttributeBits());
            Debug.Assert(expectedConvention.UnmanagedCallingConventionTypes is not null);
            Debug.Assert(expectedConvention.UnmanagedCallingConventionTypes.IsEmpty || expectedConvention.CallKind == Cci.CallingConvention.Unmanaged);

            Debug.Assert(!_binder.IsEarlyAttributeBinder);
            if (_binder.InAttributeArgument || (_binder.Flags & BinderFlags.InContextualAttributeBinder) != 0)
            {
                // We're at a location where the unmanaged data might not yet been bound. This cannot be valid code
                // anyway, as attribute arguments can't be method references, so we'll just assume that the conventions
                // match, as there will be other errors that supersede these anyway
                return;
            }

            for (int i = 0; i < results.Count; i++)
            {
                var result = results[i];
                var member = (MethodSymbol)(Symbol)result.Member;
                if (result.Result.IsValid)
                {
                    // We're not in an attribute, so cycles shouldn't be possible
                    var unmanagedCallersOnlyData = member.GetUnmanagedCallersOnlyAttributeData(forceComplete: true);

                    Debug.Assert(!ReferenceEquals(unmanagedCallersOnlyData, UnmanagedCallersOnlyAttributeData.AttributePresentDataNotBound)
                                 && !ReferenceEquals(unmanagedCallersOnlyData, UnmanagedCallersOnlyAttributeData.Uninitialized));

                    Cci.CallingConvention actualCallKind;
                    ImmutableHashSet<INamedTypeSymbolInternal> actualUnmanagedCallingConventionTypes;

                    if (unmanagedCallersOnlyData is null)
                    {
                        actualCallKind = member.CallingConvention;
                        actualUnmanagedCallingConventionTypes = ImmutableHashSet<INamedTypeSymbolInternal>.Empty;
                    }
                    else
                    {
                        // There's data from an UnmanagedCallersOnlyAttribute present, which takes precedence over the
                        // CallKind bit in the method definition. We use the following rules to decode the attribute:
                        // * If no types are specified, the CallKind is treated as Unmanaged, with no unmanaged calling convention types
                        // * If there is one type specified, and that type is named CallConvCdecl, CallConvThiscall, CallConvStdcall, or 
                        //   CallConvFastcall, the CallKind is treated as CDecl, ThisCall, Standard, or FastCall, respectively, with no
                        //   calling types.
                        // * If multiple types are specified or the single type is not named one of the specially called out types above,
                        //   the CallKind is treated as Unmanaged, with the union of the types specified treated as calling convention types.

                        var unmanagedCallingConventionTypes = unmanagedCallersOnlyData.CallingConventionTypes;
                        Debug.Assert(unmanagedCallingConventionTypes.All(u => FunctionPointerTypeSymbol.IsCallingConventionModifier((NamedTypeSymbol)u)));

                        switch (unmanagedCallingConventionTypes.Count)
                        {
                            case 0:
                                actualCallKind = Cci.CallingConvention.Unmanaged;
                                actualUnmanagedCallingConventionTypes = ImmutableHashSet<INamedTypeSymbolInternal>.Empty;
                                break;
                            case 1:
                                switch (unmanagedCallingConventionTypes.Single().Name)
                                {
                                    case "CallConvCdecl":
                                        actualCallKind = Cci.CallingConvention.CDecl;
                                        actualUnmanagedCallingConventionTypes = ImmutableHashSet<INamedTypeSymbolInternal>.Empty;
                                        break;
                                    case "CallConvStdcall":
                                        actualCallKind = Cci.CallingConvention.Standard;
                                        actualUnmanagedCallingConventionTypes = ImmutableHashSet<INamedTypeSymbolInternal>.Empty;
                                        break;
                                    case "CallConvThiscall":
                                        actualCallKind = Cci.CallingConvention.ThisCall;
                                        actualUnmanagedCallingConventionTypes = ImmutableHashSet<INamedTypeSymbolInternal>.Empty;
                                        break;
                                    case "CallConvFastcall":
                                        actualCallKind = Cci.CallingConvention.FastCall;
                                        actualUnmanagedCallingConventionTypes = ImmutableHashSet<INamedTypeSymbolInternal>.Empty;
                                        break;
                                    default:
                                        goto outerDefault;
                                }
                                break;

                            default:
outerDefault:
                                actualCallKind = Cci.CallingConvention.Unmanaged;
                                actualUnmanagedCallingConventionTypes = unmanagedCallingConventionTypes;
                                break;
                        }
                    }

                    // The rules for matching a calling convention are:
                    // 1. The CallKinds must match exactly
                    // 2. If the CallKind is Unmanaged, then the set of calling convention types must match exactly, ignoring order
                    //    and duplicates. We already have both sets in a HashSet, so we can just ensure they're the same length and
                    //    that everything from one set is in the other set.

                    if (actualCallKind.HasUnknownCallingConventionAttributeBits() || !actualCallKind.IsCallingConvention(expectedConvention.CallKind))
                    {
                        results[i] = makeWrongCallingConvention(result);
                        continue;
                    }

                    if (expectedConvention.CallKind.IsCallingConvention(Cci.CallingConvention.Unmanaged))
                    {
                        if (expectedConvention.UnmanagedCallingConventionTypes.Count != actualUnmanagedCallingConventionTypes.Count)
                        {
                            results[i] = makeWrongCallingConvention(result);
                            continue;
                        }

                        foreach (var expectedModifier in expectedConvention.UnmanagedCallingConventionTypes)
                        {
                            if (!actualUnmanagedCallingConventionTypes.Contains(((CSharpCustomModifier)expectedModifier).ModifierSymbol))
                            {
                                results[i] = makeWrongCallingConvention(result);
                                break;
                            }
                        }
                    }
                }
            }

            static MemberResolutionResult<TMember> makeWrongCallingConvention(MemberResolutionResult<TMember> result)
                => new MemberResolutionResult<TMember>(result.Member, result.LeastOverriddenMember, MemberAnalysisResult.WrongCallingConvention());
        }

        private bool FailsConstraintChecks(MethodSymbol method, out ArrayBuilder<TypeParameterDiagnosticInfo> constraintFailureDiagnosticsOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 29568, 31003);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 29727, 29914) || true) && (f_10874_29731_29743(method) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10874, 29731, 29795) || f_10874_29752_29777(method) == (object)method))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 29727, 29914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 29829, 29868);

                    constraintFailureDiagnosticsOpt = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 29886, 29899);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 29727, 29914);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 29930, 30011);

                var
                diagnosticsBuilder = f_10874_29955_30010()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 30025, 30100);

                ArrayBuilder<TypeParameterDiagnosticInfo>
                useSiteDiagnosticsBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 30114, 30421);

                bool
                constraintsSatisfied = f_10874_30142_30420(method, f_10874_30226_30242(this), f_10874_30261_30277(this), diagnosticsBuilder, nullabilityDiagnosticsBuilderOpt: null, ref useSiteDiagnosticsBuilder)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 30437, 30822) || true) && (!constraintsSatisfied)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 30437, 30822);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 30496, 30704) || true) && (useSiteDiagnosticsBuilder != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 30496, 30704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 30575, 30630);

                        f_10874_30575_30629(diagnosticsBuilder, useSiteDiagnosticsBuilder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 30652, 30685);

                        f_10874_30652_30684(useSiteDiagnosticsBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 30496, 30704);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 30724, 30777);

                    constraintFailureDiagnosticsOpt = diagnosticsBuilder;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 30795, 30807);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 30437, 30822);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 30838, 30864);

                f_10874_30838_30863(
                            diagnosticsBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 30878, 30912);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(useSiteDiagnosticsBuilder, 10874, 30878, 30911)?.Free(), 10874, 30904, 30911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 30926, 30965);

                constraintFailureDiagnosticsOpt = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 30979, 30992);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 29568, 31003);

                int
                f_10874_29731_29743(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 29731, 29743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10874_29752_29777(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 29752, 29777);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                f_10874_29955_30010()
                {
                    var return_v = ArrayBuilder<TypeParameterDiagnosticInfo>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 29955, 30010);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10874_30226_30242(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 30226, 30242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10874_30261_30277(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 30261, 30277);
                    return return_v;
                }


                bool
                f_10874_30142_30420(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.Conversions
                conversions, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                diagnosticsBuilder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                nullabilityDiagnosticsBuilderOpt, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>?
                useSiteDiagnosticsBuilder)
                {
                    var return_v = ConstraintsHelper.CheckMethodConstraints(method, (Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions, currentCompilation, diagnosticsBuilder, nullabilityDiagnosticsBuilderOpt: nullabilityDiagnosticsBuilderOpt, ref useSiteDiagnosticsBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 30142, 30420);
                    return return_v;
                }


                int
                f_10874_30575_30629(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 30575, 30629);
                    return 0;
                }


                int
                f_10874_30652_30684(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 30652, 30684);
                    return 0;
                }


                int
                f_10874_30838_30863(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 30838, 30863);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 29568, 31003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 29568, 31003);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void RemoveDelegateConversionsWithWrongReturnType<TMember>(
                    ArrayBuilder<MemberResolutionResult<TMember>> results,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                    RefKind? returnRefKind,
                    TypeSymbol returnType,
                    bool isFunctionPointerConversion) where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 31583, 34134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 32270, 32324);

                f_10874_32270_32323<TMember>(typeof(TMember) == typeof(MethodSymbol));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 32349, 32354);

                    for (int
        f = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 32340, 34123) || true) && (f < f_10874_32360_32373<TMember>(results))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 32375, 32378)
        , ++f, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 32340, 34123))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 32340, 34123);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 32412, 32436);

                        var
                        result = f_10874_32425_32435<TMember>(results, f)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 32454, 32550) || true) && (f_10874_32458_32480_M(!result.Result.IsValid))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 32454, 32550);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 32522, 32531);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 32454, 32550);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 32570, 32619);

                        var
                        method = (MethodSymbol)(Symbol)result.Member
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 32637, 32655);

                        bool
                        returnsMatch
                        = default(bool);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 32675, 33574) || true) && (returnType is null || (DynAbs.Tracing.TraceSender.Expression_False(10874, 32679, 32771) || f_10874_32701_32771<TMember>(f_10874_32701_32718<TMember>(method), returnType, TypeCompareKind.AllIgnoreOptions)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 32675, 33574);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 32813, 32833);

                            returnsMatch = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 32675, 33574);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 32675, 33574);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 32875, 33574) || true) && (returnRefKind == RefKind.None)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 32875, 33574);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 32950, 33073);

                                returnsMatch = f_10874_32965_33072<TMember>(f_10874_32965_32976<TMember>(), f_10874_33018_33035<TMember>(method), returnType, ref useSiteDiagnostics);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 33095, 33452) || true) && (!returnsMatch && (DynAbs.Tracing.TraceSender.Expression_True(10874, 33099, 33143) && isFunctionPointerConversion))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 33095, 33452);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 33193, 33429);

                                    returnsMatch = f_10874_33208_33289<TMember>(f_10874_33259_33276<TMember>(method), returnType) || (DynAbs.Tracing.TraceSender.Expression_False(10874, 33208, 33428) || f_10874_33333_33428<TMember>(f_10874_33333_33344<TMember>(), f_10874_33374_33391<TMember>(method), returnType, ref useSiteDiagnostics));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 33095, 33452);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 32875, 33574);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 32875, 33574);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 33534, 33555);

                                returnsMatch = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 32875, 33574);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 32675, 33574);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 33594, 34108) || true) && (!returnsMatch)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 33594, 34108);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 33653, 33813);

                            results[f] = f_10874_33666_33812<TMember>(result.Member, result.LeastOverriddenMember, MemberAnalysisResult.WrongReturnType());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 33594, 34108);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 33594, 34108);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 33855, 34108) || true) && (f_10874_33859_33873<TMember>(method) != returnRefKind)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 33855, 34108);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 33932, 34089);

                                results[f] = f_10874_33945_34088<TMember>(result.Member, result.LeastOverriddenMember, MemberAnalysisResult.WrongRefKind());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 33855, 34108);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 33594, 34108);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 1784);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 1784);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 31583, 34134);

                int
                f_10874_32270_32323<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 32270, 32323);
                    return 0;
                }


                int
                f_10874_32360_32373<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 32360, 32373);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_32425_32435<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 32425, 32435);
                    return return_v;
                }


                bool
                f_10874_32458_32480_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 32458, 32480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_32701_32718<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 32701, 32718);
                    return return_v;
                }


                bool
                f_10874_32701_32771<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind) where TMember : Symbol

                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 32701, 32771);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10874_32965_32976<TMember>() where TMember : Symbol

                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 32965, 32976);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_33018_33035<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 33018, 33035);
                    return return_v;
                }


                bool
                f_10874_32965_33072<TMember>(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = this_param.HasIdentityOrImplicitReferenceConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 32965, 33072);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_33259_33276<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 33259, 33276);
                    return return_v;
                }


                bool
                f_10874_33208_33289<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination) where TMember : Symbol

                {
                    var return_v = ConversionsBase.HasImplicitPointerToVoidConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 33208, 33289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10874_33333_33344<TMember>() where TMember : Symbol

                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 33333, 33344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_33374_33391<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 33374, 33391);
                    return return_v;
                }


                bool
                f_10874_33333_33428<TMember>(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = this_param.HasImplicitPointerConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 33333, 33428);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_33666_33812<TMember>(TMember
                member, TMember
                leastOverriddenMember, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result) where TMember : Symbol

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>(member, leastOverriddenMember, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 33666, 33812);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10874_33859_33873<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 33859, 33873);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_33945_34088<TMember>(TMember
                member, TMember
                leastOverriddenMember, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result) where TMember : Symbol

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>(member, leastOverriddenMember, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 33945, 34088);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 31583, 34134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 31583, 34134);
            }
        }

        private static Dictionary<NamedTypeSymbol, ArrayBuilder<TMember>> PartitionMembersByContainingType<TMember>(ArrayBuilder<TMember> members) where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 34146, 35052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 34332, 34460);

                Dictionary<NamedTypeSymbol, ArrayBuilder<TMember>>
                containingTypeMap = f_10874_34403_34459<TMember>()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 34483, 34488);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 34474, 35002) || true) && (i < f_10874_34494_34507<TMember>(members))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 34509, 34512)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 34474, 35002))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 34474, 35002);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 34546, 34574);

                        TMember
                        member = f_10874_34563_34573<TMember>(members, i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 34592, 34647);

                        NamedTypeSymbol
                        containingType = f_10874_34625_34646<TMember>(member)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 34665, 34695);

                        ArrayBuilder<TMember>
                        builder
                        = default(ArrayBuilder<TMember>);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 34713, 34949) || true) && (!f_10874_34718_34776<TMember>(containingTypeMap, containingType, out builder))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 34713, 34949);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 34818, 34864);

                            builder = f_10874_34828_34863<TMember>();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 34886, 34930);

                            containingTypeMap[containingType] = builder;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 34713, 34949);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 34967, 34987);

                        f_10874_34967_34986<TMember>(builder, member);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 529);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 529);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 35016, 35041);

                return containingTypeMap;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 34146, 35052);

                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>>
                f_10874_34403_34459<TMember>() where TMember : Symbol

                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 34403, 34459);
                    return return_v;
                }


                int
                f_10874_34494_34507<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 34494, 34507);
                    return return_v;
                }


                TMember
                f_10874_34563_34573<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 34563, 34573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10874_34625_34646<TMember>(TMember
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 34625, 34646);
                    return return_v;
                }


                bool
                f_10874_34718_34776<TMember>(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                key, out Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>
                value) where TMember : Symbol

                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 34718, 34776);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>
                f_10874_34828_34863<TMember>() where TMember : Symbol

                {
                    var return_v = ArrayBuilder<TMember>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 34828, 34863);
                    return return_v;
                }


                int
                f_10874_34967_34986<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>
                this_param, TMember
                item) where TMember : Symbol

                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 34967, 34986);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 34146, 35052);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 34146, 35052);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ClearContainingTypeMap<TMember>(ref Dictionary<NamedTypeSymbol, ArrayBuilder<TMember>> containingTypeMapOpt) where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 35064, 35531);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 35240, 35520) || true) && ((object)containingTypeMapOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 35240, 35520);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 35314, 35459);
                        foreach (ArrayBuilder<TMember> builder in f_10874_35356_35383_I(f_10874_35356_35383<TMember>(containingTypeMapOpt)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 35314, 35459);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 35425, 35440);

                            f_10874_35425_35439<TMember>(builder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 35314, 35459);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 146);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 146);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 35477, 35505);

                    containingTypeMapOpt = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 35240, 35520);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 35064, 35531);

                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>>.ValueCollection
                f_10874_35356_35383<TMember>(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 35356, 35383);
                    return return_v;
                }


                int
                f_10874_35425_35439<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>
                this_param) where TMember : Symbol

                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 35425, 35439);
                    return 0;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>>.ValueCollection
                f_10874_35356_35383_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 35356, 35383);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 35064, 35531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 35064, 35531);
            }
        }

        private void AddConstructorToCandidateSet(MethodSymbol constructor, ArrayBuilder<MemberResolutionResult<MethodSymbol>> results,
                    AnalyzedArguments arguments, bool completeResults, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 35543, 37351);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 35874, 36311) || true) && (f_10874_35878_35912(constructor))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 35874, 36311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 35946, 36049);

                    f_10874_35946_36048(!MemberAnalysisResult.UnsupportedMetadata().HasUseSiteDiagnosticToReportFor(constructor));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 36067, 36271) || true) && (completeResults)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 36067, 36271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 36128, 36252);

                        f_10874_36128_36251(results, f_10874_36140_36250(constructor, constructor, MemberAnalysisResult.UnsupportedMetadata()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 36067, 36271);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 36289, 36296);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 35874, 36311);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 36327, 36447);

                var
                normalResult = f_10874_36346_36446(this, constructor, arguments, completeResults, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 36461, 36487);

                var
                result = normalResult
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 36501, 36954) || true) && (f_10874_36505_36526_M(!normalResult.IsValid))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 36501, 36954);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 36560, 36939) || true) && (f_10874_36564_36590(constructor))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 36560, 36939);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 36632, 36756);

                        var
                        expandedResult = f_10874_36653_36755(this, constructor, arguments, completeResults, ref useSiteDiagnostics)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 36778, 36920) || true) && (expandedResult.IsValid || (DynAbs.Tracing.TraceSender.Expression_False(10874, 36782, 36823) || completeResults))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 36778, 36920);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 36873, 36897);

                            result = expandedResult;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 36778, 36920);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 36560, 36939);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 36501, 36954);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 37111, 37340) || true) && (result.IsValid || (DynAbs.Tracing.TraceSender.Expression_False(10874, 37115, 37148) || completeResults) || (DynAbs.Tracing.TraceSender.Expression_False(10874, 37115, 37203) || result.HasUseSiteDiagnosticToReportFor(constructor)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 37111, 37340);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 37237, 37325);

                    f_10874_37237_37324(results, f_10874_37249_37323(constructor, constructor, result));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 37111, 37340);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 35543, 37351);

                bool
                f_10874_35878_35912(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.HasUnsupportedMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 35878, 35912);
                    return return_v;
                }


                int
                f_10874_35946_36048(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 35946, 36048);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10874_36140_36250(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                leastOverriddenMember, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(member, leastOverriddenMember, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 36140, 36250);
                    return return_v;
                }


                int
                f_10874_36128_36251(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 36128, 36251);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10874_36346_36446(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructor, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, bool
                completeResults, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsConstructorApplicableInNormalForm(constructor, arguments, completeResults, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 36346, 36446);
                    return return_v;
                }


                bool
                f_10874_36505_36526_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 36505, 36526);
                    return return_v;
                }


                bool
                f_10874_36564_36590(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member)
                {
                    var return_v = IsValidParams((Microsoft.CodeAnalysis.CSharp.Symbol)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 36564, 36590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10874_36653_36755(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructor, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, bool
                completeResults, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsConstructorApplicableInExpandedForm(constructor, arguments, completeResults, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 36653, 36755);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10874_37249_37323(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                leastOverriddenMember, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(member, leastOverriddenMember, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 37249, 37323);
                    return return_v;
                }


                int
                f_10874_37237_37324(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 37237, 37324);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 35543, 37351);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 35543, 37351);
            }
        }

        private MemberAnalysisResult IsConstructorApplicableInNormalForm(
                    MethodSymbol constructor,
                    AnalyzedArguments arguments,
                    bool completeResults,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 37363, 39015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 37630, 37743);

                var
                argumentAnalysis = f_10874_37653_37742(constructor, arguments, isMethodGroupConversion: false, expanded: false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 37820, 37970) || true) && (f_10874_37824_37849_M(!argumentAnalysis.IsValid))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 37820, 37970);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 37883, 37955);

                    return MemberAnalysisResult.ArgumentParameterMismatch(argumentAnalysis);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 37820, 37970);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 38106, 38229) || true) && (f_10874_38110_38137(constructor))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 38106, 38229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 38171, 38214);

                    return MemberAnalysisResult.UseSiteError();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 38106, 38229);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 38245, 38568);

                var
                effectiveParameters = f_10874_38271_38567(this, constructor, f_10874_38354_38379(arguments.Arguments), argumentAnalysis.ArgsToParamsOpt, arguments.RefKinds, isMethodGroupConversion: false, allowRefOmittedArguments: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 38584, 39004);

                return f_10874_38591_39003(this, constructor, effectiveParameters, arguments, argumentAnalysis.ArgsToParamsOpt, isVararg: f_10874_38779_38799(constructor), hasAnyRefOmittedArgument: false, ignoreOpenTypes: false, completeResults: completeResults, useSiteDiagnostics: ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 37363, 39015);

                Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResult
                f_10874_37653_37742(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, bool
                isMethodGroupConversion, bool
                expanded)
                {
                    var return_v = AnalyzeArguments((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, arguments, isMethodGroupConversion: isMethodGroupConversion, expanded: expanded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 37653, 37742);
                    return return_v;
                }


                bool
                f_10874_37824_37849_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 37824, 37849);
                    return return_v;
                }


                bool
                f_10874_38110_38137(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.HasUseSiteError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 38110, 38137);
                    return return_v;
                }


                int
                f_10874_38354_38379(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 38354, 38379);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.OverloadResolution.EffectiveParameters
                f_10874_38271_38567(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member, int
                argumentCount, System.Collections.Immutable.ImmutableArray<int>
                argToParamMap, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                argumentRefKinds, bool
                isMethodGroupConversion, bool
                allowRefOmittedArguments)
                {
                    var return_v = this_param.GetEffectiveParametersInNormalForm<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(member, argumentCount, argToParamMap, argumentRefKinds, isMethodGroupConversion: isMethodGroupConversion, allowRefOmittedArguments: allowRefOmittedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 38271, 38567);
                    return return_v;
                }


                bool
                f_10874_38779_38799(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsVararg;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 38779, 38799);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10874_38591_39003(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                candidate, Microsoft.CodeAnalysis.CSharp.OverloadResolution.EffectiveParameters
                parameters, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, System.Collections.Immutable.ImmutableArray<int>
                argsToParameters, bool
                isVararg, bool
                hasAnyRefOmittedArgument, bool
                ignoreOpenTypes, bool
                completeResults, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsApplicable((Microsoft.CodeAnalysis.CSharp.Symbol)candidate, parameters, arguments, argsToParameters, isVararg: isVararg, hasAnyRefOmittedArgument: hasAnyRefOmittedArgument, ignoreOpenTypes: ignoreOpenTypes, completeResults: completeResults, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 38591, 39003);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 37363, 39015);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 37363, 39015);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MemberAnalysisResult IsConstructorApplicableInExpandedForm(
                    MethodSymbol constructor,
                    AnalyzedArguments arguments,
                    bool completeResults,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 39027, 40947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 39296, 39408);

                var
                argumentAnalysis = f_10874_39319_39407(constructor, arguments, isMethodGroupConversion: false, expanded: true)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 39422, 39572) || true) && (f_10874_39426_39451_M(!argumentAnalysis.IsValid))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 39422, 39572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 39485, 39557);

                    return MemberAnalysisResult.ArgumentParameterMismatch(argumentAnalysis);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 39422, 39572);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 39708, 39831) || true) && (f_10874_39712_39739(constructor))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 39708, 39831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 39773, 39816);

                    return MemberAnalysisResult.UseSiteError();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 39708, 39831);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 39847, 40172);

                var
                effectiveParameters = f_10874_39873_40171(this, constructor, f_10874_39958_39983(arguments.Arguments), argumentAnalysis.ArgsToParamsOpt, arguments.RefKinds, isMethodGroupConversion: false, allowRefOmittedArguments: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 40312, 40348);

                f_10874_40312_40347(f_10874_40325_40346_M(!constructor.IsVararg));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 40362, 40773);

                var
                result = f_10874_40375_40772(this, constructor, effectiveParameters, arguments, argumentAnalysis.ArgsToParamsOpt, isVararg: false, hasAnyRefOmittedArgument: false, ignoreOpenTypes: false, completeResults: completeResults, useSiteDiagnostics: ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 40789, 40936);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10874, 40796, 40810) || ((result.IsValid && DynAbs.Tracing.TraceSender.Conditional_F2(10874, 40813, 40926)) || DynAbs.Tracing.TraceSender.Conditional_F3(10874, 40929, 40935))) ? MemberAnalysisResult.ExpandedForm(result.ArgsToParamsOpt, result.ConversionsOpt, hasAnyRefOmittedArgument: false) : result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 39027, 40947);

                Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResult
                f_10874_39319_39407(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, bool
                isMethodGroupConversion, bool
                expanded)
                {
                    var return_v = AnalyzeArguments((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, arguments, isMethodGroupConversion: isMethodGroupConversion, expanded: expanded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 39319, 39407);
                    return return_v;
                }


                bool
                f_10874_39426_39451_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 39426, 39451);
                    return return_v;
                }


                bool
                f_10874_39712_39739(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.HasUseSiteError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 39712, 39739);
                    return return_v;
                }


                int
                f_10874_39958_39983(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 39958, 39983);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.OverloadResolution.EffectiveParameters
                f_10874_39873_40171(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member, int
                argumentCount, System.Collections.Immutable.ImmutableArray<int>
                argToParamMap, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                argumentRefKinds, bool
                isMethodGroupConversion, bool
                allowRefOmittedArguments)
                {
                    var return_v = this_param.GetEffectiveParametersInExpandedForm<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(member, argumentCount, argToParamMap, argumentRefKinds, isMethodGroupConversion: isMethodGroupConversion, allowRefOmittedArguments: allowRefOmittedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 39873, 40171);
                    return return_v;
                }


                bool
                f_10874_40325_40346_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 40325, 40346);
                    return return_v;
                }


                int
                f_10874_40312_40347(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 40312, 40347);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10874_40375_40772(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                candidate, Microsoft.CodeAnalysis.CSharp.OverloadResolution.EffectiveParameters
                parameters, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, System.Collections.Immutable.ImmutableArray<int>
                argsToParameters, bool
                isVararg, bool
                hasAnyRefOmittedArgument, bool
                ignoreOpenTypes, bool
                completeResults, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsApplicable((Microsoft.CodeAnalysis.CSharp.Symbol)candidate, parameters, arguments, argsToParameters, isVararg: isVararg, hasAnyRefOmittedArgument: hasAnyRefOmittedArgument, ignoreOpenTypes: ignoreOpenTypes, completeResults: completeResults, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 40375, 40772);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 39027, 40947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 39027, 40947);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddMemberToCandidateSet<TMember>(
                    TMember member, // method or property
                    ArrayBuilder<MemberResolutionResult<TMember>> results,
                    ArrayBuilder<TMember> members,
                    ArrayBuilder<TypeWithAnnotations> typeArguments,
                    BoundExpression receiverOpt,
                    AnalyzedArguments arguments,
                    bool completeResults,
                    bool isMethodGroupConversion,
                    bool allowRefOmittedArguments,
                    Dictionary<NamedTypeSymbol, ArrayBuilder<TMember>> containingTypeMapOpt,
                    bool inferWithDynamic,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                    bool allowUnexpandedForm)
                    where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 40959, 49354);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 43774, 45776) || true) && (f_10874_43778_43791<TMember>(members) < 2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 43774, 45776);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 43774, 45776);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 43774, 45776);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 43899, 45776) || true) && (containingTypeMapOpt == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 43899, 45776);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 43965, 44257) || true) && (f_10874_43969_44083<TMember>(members, member, checkOverrideContainingType: true, ref useSiteDiagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 43965, 44257);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 44231, 44238);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 43965, 44257);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 44277, 44412) || true) && (f_10874_44281_44344<TMember>(members, member, ref useSiteDiagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 44277, 44412);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 44386, 44393);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 44277, 44412);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 43899, 45776);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 43899, 45776);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 44446, 45776) || true) && (f_10874_44450_44476<TMember>(containingTypeMapOpt) == 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 44446, 45776);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 44446, 45776);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 44446, 45776);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 44739, 44800);

                            NamedTypeSymbol
                            memberContainingType = f_10874_44778_44799<TMember>(member)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 44818, 45761);
                                foreach (var pair in f_10874_44839_44859_I(containingTypeMapOpt))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 44818, 45761);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 44901, 44938);

                                    NamedTypeSymbol
                                    otherType = pair.Key
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 44960, 45742) || true) && (f_10874_44964_45089<TMember>(otherType, memberContainingType, TypeCompareKind.ConsiderEverything, useSiteDiagnostics: ref useSiteDiagnostics))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 44960, 45742);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 45139, 45181);

                                        ArrayBuilder<TMember>
                                        others = pair.Value
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 45209, 45533) || true) && (f_10874_45213_45327<TMember>(others, member, checkOverrideContainingType: false, ref useSiteDiagnostics))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 45209, 45533);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 45499, 45506);

                                            return;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 45209, 45533);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 45561, 45719) || true) && (f_10874_45565_45627<TMember>(others, member, ref useSiteDiagnostics))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 45561, 45719);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 45685, 45692);

                                            return;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 45561, 45719);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 44960, 45742);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 44818, 45761);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 944);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 944);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 44446, 45776);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 43899, 45776);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 43774, 45776);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 45792, 45885);

                var
                leastOverriddenMember = (TMember)f_10874_45829_45884<TMember>(member, f_10874_45861_45883<TMember>(_binder))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 45963, 46390) || true) && (f_10874_45967_45996<TMember>(member))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 45963, 46390);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 46030, 46128);

                    f_10874_46030_46127<TMember>(!MemberAnalysisResult.UnsupportedMetadata().HasUseSiteDiagnosticToReportFor(member));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 46146, 46350) || true) && (completeResults)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 46146, 46350);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 46207, 46331);

                        f_10874_46207_46330<TMember>(results, f_10874_46219_46329<TMember>(member, leastOverriddenMember, MemberAnalysisResult.UnsupportedMetadata()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 46146, 46350);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 46368, 46375);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 45963, 46390);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 46908, 46997);

                f_10874_46908_46996<TMember>(f_10874_46921_46940<TMember>(typeArguments) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10874, 46921, 46995) || f_10874_46949_46968<TMember>(typeArguments) == f_10874_46972_46995<TMember>(member)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 47129, 47784);

                var
                normalResult = (DynAbs.Tracing.TraceSender.Conditional_F1(10874, 47148, 47210) || (((allowUnexpandedForm || (DynAbs.Tracing.TraceSender.Expression_False(10874, 47149, 47209) || !f_10874_47173_47209<TMember>(leastOverriddenMember)))
                && DynAbs.Tracing.TraceSender.Conditional_F2(10874, 47230, 47723)) || DynAbs.Tracing.TraceSender.Conditional_F3(10874, 47743, 47783))) ? f_10874_47230_47723<TMember>(this, member, leastOverriddenMember, typeArguments, arguments, isMethodGroupConversion: isMethodGroupConversion, allowRefOmittedArguments: allowRefOmittedArguments, inferWithDynamic: inferWithDynamic, completeResults: completeResults, useSiteDiagnostics: ref useSiteDiagnostics) : default(MemberResolutionResult<TMember>)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 47800, 47826);

                var
                result = normalResult
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 47840, 49094) || true) && (f_10874_47844_47872_M(!normalResult.Result.IsValid))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 47840, 49094);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 48332, 49079) || true) && (!isMethodGroupConversion && (DynAbs.Tracing.TraceSender.Expression_True(10874, 48336, 48400) && f_10874_48364_48400<TMember>(leastOverriddenMember)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 48332, 49079);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 48442, 48859);

                        var
                        expandedResult = f_10874_48463_48858<TMember>(this, member, leastOverriddenMember, typeArguments, arguments, allowRefOmittedArguments: allowRefOmittedArguments, completeResults: completeResults, useSiteDiagnostics: ref useSiteDiagnostics)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 48883, 49060) || true) && (f_10874_48887_48963<TMember>(normalResult.Result, expandedResult.Result))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 48883, 49060);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 49013, 49037);

                            result = expandedResult;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 48883, 49060);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 48332, 49079);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 47840, 49094);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 49191, 49343) || true) && (result.Result.IsValid || (DynAbs.Tracing.TraceSender.Expression_False(10874, 49195, 49235) || completeResults) || (DynAbs.Tracing.TraceSender.Expression_False(10874, 49195, 49274) || result.HasUseSiteDiagnosticToReport))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 49191, 49343);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 49308, 49328);

                    f_10874_49308_49327<TMember>(results, result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 49191, 49343);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 40959, 49354);

                int
                f_10874_43778_43791<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 43778, 43791);
                    return return_v;
                }


                bool
                f_10874_43969_44083<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>
                members, TMember
                member, bool
                checkOverrideContainingType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = MemberGroupContainsMoreDerivedOverride(members, member, checkOverrideContainingType: checkOverrideContainingType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 43969, 44083);
                    return return_v;
                }


                bool
                f_10874_44281_44344<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>
                members, TMember
                member, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = MemberGroupHidesByName(members, member, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 44281, 44344);
                    return return_v;
                }


                int
                f_10874_44450_44476<TMember>(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 44450, 44476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10874_44778_44799<TMember>(TMember
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 44778, 44799);
                    return return_v;
                }


                bool
                f_10874_44964_45089<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypeCompareKind
                comparison, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = this_param.IsDerivedFrom((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, comparison, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 44964, 45089);
                    return return_v;
                }


                bool
                f_10874_45213_45327<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>
                members, TMember
                member, bool
                checkOverrideContainingType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = MemberGroupContainsMoreDerivedOverride(members, member, checkOverrideContainingType: checkOverrideContainingType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 45213, 45327);
                    return return_v;
                }


                bool
                f_10874_45565_45627<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>
                members, TMember
                member, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = MemberGroupHidesByName(members, member, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 45565, 45627);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>>
                f_10874_44839_44859_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 44839, 44859);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10874_45861_45883<TMember>(Microsoft.CodeAnalysis.CSharp.Binder
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 45861, 45883);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10874_45829_45884<TMember>(TMember
                member, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                accessingTypeOpt) where TMember : Symbol

                {
                    var return_v = member.GetLeastOverriddenMember(accessingTypeOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 45829, 45884);
                    return return_v;
                }


                bool
                f_10874_45967_45996<TMember>(TMember
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.HasUnsupportedMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 45967, 45996);
                    return return_v;
                }


                int
                f_10874_46030_46127<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 46030, 46127);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_46219_46329<TMember>(TMember
                member, TMember
                leastOverriddenMember, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result) where TMember : Symbol

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>(member, leastOverriddenMember, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 46219, 46329);
                    return return_v;
                }


                int
                f_10874_46207_46330<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                item) where TMember : Symbol

                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 46207, 46330);
                    return 0;
                }


                int
                f_10874_46921_46940<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 46921, 46940);
                    return return_v;
                }


                int
                f_10874_46949_46968<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 46949, 46968);
                    return return_v;
                }


                int
                f_10874_46972_46995<TMember>(TMember
                symbol) where TMember : Symbol

                {
                    var return_v = symbol.GetMemberArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 46972, 46995);
                    return return_v;
                }


                int
                f_10874_46908_46996<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 46908, 46996);
                    return 0;
                }


                bool
                f_10874_47173_47209<TMember>(TMember
                member) where TMember : Symbol

                {
                    var return_v = IsValidParams((Microsoft.CodeAnalysis.CSharp.Symbol)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 47173, 47209);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_47230_47723<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, TMember
                member, TMember
                leastOverriddenMember, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, bool
                isMethodGroupConversion, bool
                allowRefOmittedArguments, bool
                inferWithDynamic, bool
                completeResults, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = this_param.IsMemberApplicableInNormalForm<TMember>(member, leastOverriddenMember, typeArguments, arguments, isMethodGroupConversion: isMethodGroupConversion, allowRefOmittedArguments: allowRefOmittedArguments, inferWithDynamic: inferWithDynamic, completeResults: completeResults, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 47230, 47723);
                    return return_v;
                }


                bool
                f_10874_47844_47872_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 47844, 47872);
                    return return_v;
                }


                bool
                f_10874_48364_48400<TMember>(TMember
                member) where TMember : Symbol

                {
                    var return_v = IsValidParams((Microsoft.CodeAnalysis.CSharp.Symbol)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 48364, 48400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_48463_48858<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, TMember
                member, TMember
                leastOverriddenMember, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, bool
                allowRefOmittedArguments, bool
                completeResults, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = this_param.IsMemberApplicableInExpandedForm<TMember>(member, leastOverriddenMember, typeArguments, arguments, allowRefOmittedArguments: allowRefOmittedArguments, completeResults: completeResults, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 48463, 48858);
                    return return_v;
                }


                bool
                f_10874_48887_48963<TMember>(Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                normalResult, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                expandedResult) where TMember : Symbol

                {
                    var return_v = PreferExpandedFormOverNormalForm(normalResult, expandedResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 48887, 48963);
                    return return_v;
                }


                int
                f_10874_49308_49327<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                item) where TMember : Symbol

                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 49308, 49327);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 40959, 49354);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 40959, 49354);
            }
        }

        private static bool PreferExpandedFormOverNormalForm(MemberAnalysisResult normalResult, MemberAnalysisResult expandedResult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 49934, 51339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 50083, 50119);

                f_10874_50083_50118(f_10874_50096_50117_M(!normalResult.IsValid));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 50133, 50220) || true) && (expandedResult.IsValid)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 50133, 50220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 50193, 50205);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 50133, 50220);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 50234, 51301);

                switch (normalResult.Kind)
                {

                    case MemberResolutionKind.RequiredParameterMissing:
                    case MemberResolutionKind.NoCorrespondingParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 50234, 51301);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 50435, 51258);

                        switch (expandedResult.Kind)
                        {

                            case MemberResolutionKind.BadArgumentConversion:
                            case MemberResolutionKind.NameUsedForPositional:
                            case MemberResolutionKind.TypeInferenceFailed:
                            case MemberResolutionKind.TypeInferenceExtensionInstanceArgument:
                            case MemberResolutionKind.ConstructedParameterFailedConstraintCheck:
                            case MemberResolutionKind.NoCorrespondingNamedParameter:
                            case MemberResolutionKind.UseSiteError:
                            case MemberResolutionKind.BadNonTrailingNamedArgument:
                            case MemberResolutionKind.DuplicateNamedArgument:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 50435, 51258);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 51223, 51235);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 50435, 51258);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10874, 51280, 51286);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 50234, 51301);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 51315, 51328);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 49934, 51339);

                bool
                f_10874_50096_50117_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 50096, 50117);
                    return return_v;
                }


                int
                f_10874_50083_50118(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 50083, 50118);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 49934, 51339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 49934, 51339);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsValidParams(Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 51585, 52326);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 51722, 51808) || true) && (f_10874_51726_51746(member))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 51722, 51808);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 51780, 51793);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 51722, 51808);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 51824, 51868);

                int
                paramCount = f_10874_51841_51867(member)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 51882, 51963) || true) && (paramCount == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 51882, 51963);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 51935, 51948);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 51882, 51963);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 52161, 52215);

                ParameterSymbol
                final = f_10874_52185_52207(member).Last()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 52229, 52315);

                return f_10874_52236_52250(final) && (DynAbs.Tracing.TraceSender.Expression_True(10874, 52236, 52314) && f_10874_52254_52314(f_10874_52254_52302(((ParameterSymbol)f_10874_52272_52296(final)))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 51585, 52326);

                bool
                f_10874_51726_51746(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.GetIsVararg();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 51726, 51746);
                    return return_v;
                }


                int
                f_10874_51841_51867(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.GetParameterCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 51841, 51867);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10874_52185_52207(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 52185, 52207);
                    return return_v;
                }


                bool
                f_10874_52236_52250(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsParams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 52236, 52250);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10874_52272_52296(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 52272, 52296);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_52254_52302(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 52254, 52302);
                    return return_v;
                }


                bool
                f_10874_52254_52314(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsSZArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 52254, 52314);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 51585, 52326);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 51585, 52326);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsMoreDerivedOverride(
                    Symbol member,
                    Symbol moreDerivedOverride,
                    bool checkOverrideContainingType,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 52820, 54065);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 53064, 53479) || true) && (f_10874_53068_53099_M(!moreDerivedOverride.IsOverride) || (DynAbs.Tracing.TraceSender.Expression_False(10874, 53068, 53283) || checkOverrideContainingType && (DynAbs.Tracing.TraceSender.Expression_True(10874, 53120, 53283) && !f_10874_53152_53283(f_10874_53152_53186(moreDerivedOverride), f_10874_53201_53222(member), TypeCompareKind.ConsiderEverything, ref useSiteDiagnostics))) || (DynAbs.Tracing.TraceSender.Expression_False(10874, 53068, 53387) || !f_10874_53305_53387(MemberSignatureComparer.SloppyOverrideComparer, member, moreDerivedOverride)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 53064, 53479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 53451, 53464);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 53064, 53479);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 53861, 54054);

                return f_10874_53868_53955(f_10874_53868_53936(moreDerivedOverride, accessingTypeOpt: null)) ==
                f_10874_53979_54053(f_10874_53979_54034(member, accessingTypeOpt: null));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 52820, 54065);

                bool
                f_10874_53068_53099_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 53068, 53099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10874_53152_53186(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 53152, 53186);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10874_53201_53222(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 53201, 53222);
                    return return_v;
                }


                bool
                f_10874_53152_53283(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypeCompareKind
                comparison, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsDerivedFrom((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, comparison, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 53152, 53283);
                    return return_v;
                }


                bool
                f_10874_53305_53387(Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                member1, Microsoft.CodeAnalysis.CSharp.Symbol
                member2)
                {
                    var return_v = this_param.Equals(member1, member2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 53305, 53387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10874_53868_53936(Microsoft.CodeAnalysis.CSharp.Symbol
                member, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                accessingTypeOpt)
                {
                    var return_v = member.GetLeastOverriddenMember(accessingTypeOpt: accessingTypeOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 53868, 53936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10874_53868_53955(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 53868, 53955);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10874_53979_54034(Microsoft.CodeAnalysis.CSharp.Symbol
                member, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                accessingTypeOpt)
                {
                    var return_v = member.GetLeastOverriddenMember(accessingTypeOpt: accessingTypeOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 53979, 54034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10874_53979_54053(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 53979, 54053);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 52820, 54065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 52820, 54065);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool MemberGroupContainsMoreDerivedOverride<TMember>(
                    ArrayBuilder<TMember> members,
                    TMember member,
                    bool checkOverrideContainingType,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
                    where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 54555, 55482);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 54865, 54992) || true) && (f_10874_54869_54886_M(!member.IsVirtual) && (DynAbs.Tracing.TraceSender.Expression_True(10874, 54869, 54908) && f_10874_54890_54908_M(!member.IsAbstract)) && (DynAbs.Tracing.TraceSender.Expression_True(10874, 54869, 54930) && f_10874_54912_54930_M(!member.IsOverride)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 54865, 54992);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 54964, 54977);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 54865, 54992);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 55008, 55110) || true) && (!f_10874_55013_55048<TMember>(f_10874_55013_55034<TMember>(member)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 55008, 55110);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 55082, 55095);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 55008, 55110);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 55135, 55140);

                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 55126, 55442) || true) && (i < f_10874_55146_55159<TMember>(members))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 55161, 55164)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 55126, 55442))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 55126, 55442);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 55198, 55427) || true) && (f_10874_55202_55354<TMember>(member: member, moreDerivedOverride: f_10874_55261_55271<TMember>(members, i), checkOverrideContainingType: checkOverrideContainingType, ref useSiteDiagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 55198, 55427);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 55396, 55408);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 55198, 55427);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 317);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 317);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 55458, 55471);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 54555, 55482);

                bool
                f_10874_54869_54886_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 54869, 54886);
                    return return_v;
                }


                bool
                f_10874_54890_54908_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 54890, 54908);
                    return return_v;
                }


                bool
                f_10874_54912_54930_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 54912, 54930);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10874_55013_55034<TMember>(TMember
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 55013, 55034);
                    return return_v;
                }


                bool
                f_10874_55013_55048<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type) where TMember : Symbol

                {
                    var return_v = type.IsClassType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 55013, 55048);
                    return return_v;
                }


                int
                f_10874_55146_55159<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 55146, 55159);
                    return return_v;
                }


                TMember
                f_10874_55261_55271<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 55261, 55271);
                    return return_v;
                }


                bool
                f_10874_55202_55354<TMember>(TMember
                member, TMember
                moreDerivedOverride, bool
                checkOverrideContainingType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = IsMoreDerivedOverride(member: (Microsoft.CodeAnalysis.CSharp.Symbol)member, moreDerivedOverride: (Microsoft.CodeAnalysis.CSharp.Symbol)moreDerivedOverride, checkOverrideContainingType: checkOverrideContainingType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 55202, 55354);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 54555, 55482);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 54555, 55482);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool MemberGroupHidesByName<TMember>(ArrayBuilder<TMember> members, TMember member, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
                    where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 55494, 56223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 55701, 55762);

                NamedTypeSymbol
                memberContainingType = f_10874_55740_55761<TMember>(member)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 55776, 56183);
                    foreach (var otherMember in f_10874_55804_55811_I<TMember>(members))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 55776, 56183);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 55845, 55910);

                        NamedTypeSymbol
                        otherContainingType = f_10874_55883_55909<TMember>(otherMember)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 55928, 56168) || true) && (f_10874_55932_55956<TMember>(otherMember) && (DynAbs.Tracing.TraceSender.Expression_True(10874, 55932, 56095) && f_10874_55960_56095<TMember>(otherContainingType, memberContainingType, TypeCompareKind.ConsiderEverything, useSiteDiagnostics: ref useSiteDiagnostics)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 55928, 56168);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 56137, 56149);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 55928, 56168);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 55776, 56183);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 408);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 408);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 56199, 56212);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 55494, 56223);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10874_55740_55761<TMember>(TMember
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 55740, 55761);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10874_55883_55909<TMember>(TMember
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 55883, 55909);
                    return return_v;
                }


                bool
                f_10874_55932_55956<TMember>(TMember
                member) where TMember : Symbol

                {
                    var return_v = HidesByName((Microsoft.CodeAnalysis.CSharp.Symbol)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 55932, 55956);
                    return return_v;
                }


                bool
                f_10874_55960_56095<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypeCompareKind
                comparison, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = this_param.IsDerivedFrom((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, comparison, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 55960, 56095);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>
                f_10874_55804_55811_I<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TMember>
                i) where TMember : Symbol

                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 55804, 55811);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 55494, 56223);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 55494, 56223);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HidesByName(Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 56592, 57065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 56663, 57054);

                switch (f_10874_56671_56682(member))
                {

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 56663, 57054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 56761, 56814);

                        return f_10874_56768_56813(((MethodSymbol)member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 56663, 57054);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 56663, 57054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 56879, 56937);

                        return f_10874_56886_56936(((PropertySymbol)member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 56663, 57054);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 56663, 57054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 56985, 57039);

                        throw f_10874_56991_57038(f_10874_57026_57037(member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 56663, 57054);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 56592, 57065);

                Microsoft.CodeAnalysis.SymbolKind
                f_10874_56671_56682(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 56671, 56682);
                    return return_v;
                }


                bool
                f_10874_56768_56813(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.HidesBaseMethodsByName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 56768, 56813);
                    return return_v;
                }


                bool
                f_10874_56886_56936(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.HidesBasePropertiesByName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 56886, 56936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10874_57026_57037(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 57026, 57037);
                    return return_v;
                }


                System.Exception
                f_10874_56991_57038(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 56991, 57038);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 56592, 57065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 56592, 57065);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void RemoveInaccessibleTypeArguments<TMember>(ArrayBuilder<MemberResolutionResult<TMember>> results, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
                    where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 57077, 57775);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 57303, 57308);
                    for (int
        f = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 57294, 57764) || true) && (f < f_10874_57314_57327<TMember>(results))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 57329, 57332)
        , ++f, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 57294, 57764))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 57294, 57764);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 57366, 57390);

                        var
                        result = f_10874_57379_57389<TMember>(results, f)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 57408, 57749) || true) && (result.Result.IsValid && (DynAbs.Tracing.TraceSender.Expression_True(10874, 57412, 57545) && !f_10874_57438_57545<TMember>(this, f_10874_57462_57520<TMember>(result.Member), ref useSiteDiagnostics)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 57408, 57749);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 57587, 57730);

                            results[f] = f_10874_57600_57729<TMember>(result.Member, result.LeastOverriddenMember, MemberAnalysisResult.InaccessibleTypeArgument());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 57408, 57749);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 471);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 471);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 57077, 57775);

                int
                f_10874_57314_57327<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 57314, 57327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_57379_57389<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 57379, 57389);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10874_57462_57520<TMember>(TMember
                symbol) where TMember : Symbol

                {
                    var return_v = symbol.GetMemberTypeArgumentsNoUseSiteDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 57462, 57520);
                    return return_v;
                }


                bool
                f_10874_57438_57545<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                typeArguments, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = this_param.TypeArgumentsAccessible(typeArguments, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 57438, 57545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_57600_57729<TMember>(TMember
                member, TMember
                leastOverriddenMember, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result) where TMember : Symbol

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>(member, leastOverriddenMember, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 57600, 57729);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 57077, 57775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 57077, 57775);
            }
        }

        private bool TypeArgumentsAccessible(ImmutableArray<TypeSymbol> typeArguments, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 57787, 58133);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 57938, 58096);
                    foreach (TypeSymbol arg in f_10874_57965_57978_I(typeArguments))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 57938, 58096);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 58012, 58081) || true) && (!f_10874_58017_58066(_binder, arg, ref useSiteDiagnostics))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 58012, 58081);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 58068, 58081);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 58012, 58081);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 57938, 58096);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 159);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 159);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 58110, 58122);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 57787, 58133);

                bool
                f_10874_58017_58066(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsAccessible((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 58017, 58066);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10874_57965_57978_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 57965, 57978);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 57787, 58133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 57787, 58133);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void RemoveLessDerivedMembers<TMember>(ArrayBuilder<MemberResolutionResult<TMember>> results, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
                    where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 58145, 65709);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 63054, 63089);

                f_10874_63054_63088<TMember>(results);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 63695, 63700);

                    // Second, apply the rule that we eliminate any method whose *original declaring type*
                    // is a base type of the original declaring type of any other method.

                    // Note that this (and several of the other algorithms in overload resolution) is
                    // O(n^2). (We expect that n will be relatively small. Also, we're trying to do these
                    // algorithms without allocating hardly any additional memory, which pushes us towards
                    // walking data structures multiple times rather than caching information about them.)

                    for (int
        f = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 63686, 65698) || true) && (f < f_10874_63706_63719<TMember>(results))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 63721, 63724)
        , ++f, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 63686, 65698))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 63686, 65698);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 63758, 63782);

                        var
                        result = f_10874_63771_63781<TMember>(results, f)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 64285, 64422) || true) && (!(result.Result.IsValid || (DynAbs.Tracing.TraceSender.Expression_False(10874, 64291, 64351) || result.HasUseSiteDiagnosticToReport)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 64285, 64422);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 64394, 64403);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 64285, 64422);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 65390, 65683) || true) && (f_10874_65394_65492<TMember>(f_10874_65415_65458<TMember>(result.LeastOverriddenMember), results, ref useSiteDiagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 65390, 65683);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 65534, 65664);

                            results[f] = f_10874_65547_65663<TMember>(result.Member, result.LeastOverriddenMember, MemberAnalysisResult.LessDerived());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 65390, 65683);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 2013);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 2013);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 58145, 65709);

                int
                f_10874_63054_63088<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                results) where TMember : Symbol

                {
                    RemoveAllInterfaceMembers(results);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 63054, 63088);
                    return 0;
                }


                int
                f_10874_63706_63719<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 63706, 63719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_63771_63781<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 63771, 63781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10874_65415_65458<TMember>(TMember
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 65415, 65458);
                    return return_v;
                }


                bool
                f_10874_65394_65492<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                results, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = IsLessDerivedThanAny((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, results, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 65394, 65492);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_65547_65663<TMember>(TMember
                member, TMember
                leastOverriddenMember, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result) where TMember : Symbol

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>(member, leastOverriddenMember, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 65547, 65663);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 58145, 65709);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 58145, 65709);
            }
        }

        private static bool IsLessDerivedThanAny<TMember>(TypeSymbol type, ArrayBuilder<MemberResolutionResult<TMember>> results, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
                    where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 65791, 67392);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 66030, 66035);
                    for (int
        f = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 66021, 67352) || true) && (f < f_10874_66041_66054<TMember>(results))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 66056, 66059)
        , ++f, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 66021, 67352))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 66021, 67352);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 66093, 66117);

                        var
                        result = f_10874_66106_66116<TMember>(results, f)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 66137, 66233) || true) && (f_10874_66141_66163_M(!result.Result.IsValid))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 66137, 66233);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 66205, 66214);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 66137, 66233);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 66253, 66315);

                        var
                        currentType = f_10874_66271_66314<TMember>(result.LeastOverriddenMember)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 66628, 66806) || true) && (f_10874_66632_66648<TMember>(type) == SpecialType.System_Object && (DynAbs.Tracing.TraceSender.Expression_True(10874, 66632, 66733) && f_10874_66681_66704<TMember>(currentType) != SpecialType.System_Object))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 66628, 66806);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 66775, 66787);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 66628, 66806);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 66826, 67337) || true) && (f_10874_66830_66859<TMember>(currentType) && (DynAbs.Tracing.TraceSender.Expression_True(10874, 66830, 66885) && f_10874_66863_66885<TMember>(type)) && (DynAbs.Tracing.TraceSender.Expression_True(10874, 66830, 67002) && f_10874_66889_66970<TMember>(currentType, ref useSiteDiagnostics).Contains(type)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 66826, 67337);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 67044, 67056);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 66826, 67337);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 66826, 67337);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 67098, 67337) || true) && (f_10874_67102_67127<TMember>(currentType) && (DynAbs.Tracing.TraceSender.Expression_True(10874, 67102, 67149) && f_10874_67131_67149<TMember>(type)) && (DynAbs.Tracing.TraceSender.Expression_True(10874, 67102, 67264) && f_10874_67153_67264<TMember>(currentType, type, TypeCompareKind.ConsiderEverything, useSiteDiagnostics: ref useSiteDiagnostics)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 67098, 67337);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 67306, 67318);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 67098, 67337);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 66826, 67337);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 1332);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 1332);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 67368, 67381);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 65791, 67392);

                int
                f_10874_66041_66054<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 66041, 66054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_66106_66116<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 66106, 66116);
                    return return_v;
                }


                bool
                f_10874_66141_66163_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 66141, 66163);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10874_66271_66314<TMember>(TMember
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 66271, 66314);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10874_66632_66648<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 66632, 66648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10874_66681_66704<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 66681, 66704);
                    return return_v;
                }


                bool
                f_10874_66830_66859<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type) where TMember : Symbol

                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 66830, 66859);
                    return return_v;
                }


                bool
                f_10874_66863_66885<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type) where TMember : Symbol

                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 66863, 66885);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10874_66889_66970<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = this_param.AllInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 66889, 66970);
                    return return_v;
                }


                bool
                f_10874_67102_67127<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type) where TMember : Symbol

                {
                    var return_v = type.IsClassType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 67102, 67127);
                    return return_v;
                }


                bool
                f_10874_67131_67149<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type) where TMember : Symbol

                {
                    var return_v = type.IsClassType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 67131, 67149);
                    return return_v;
                }


                bool
                f_10874_67153_67264<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.TypeCompareKind
                comparison, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = this_param.IsDerivedFrom(type, comparison, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 67153, 67264);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 65791, 67392);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 65791, 67392);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void RemoveAllInterfaceMembers<TMember>(ArrayBuilder<MemberResolutionResult<TMember>> results)
                    where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 67404, 70369);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 69156, 69193);

                bool
                anyClassOtherThanObject = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 69216, 69221);
                    for (int
        f = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 69207, 69725) || true) && (f < f_10874_69227_69240<TMember>(results))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 69242, 69245)
        , f++, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 69207, 69725))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 69207, 69725);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 69279, 69303);

                        var
                        result = f_10874_69292_69302<TMember>(results, f)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 69321, 69417) || true) && (f_10874_69325_69347_M(!result.Result.IsValid))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 69321, 69417);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 69389, 69398);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 69321, 69417);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 69437, 69492);

                        var
                        type = f_10874_69448_69491<TMember>(result.LeastOverriddenMember)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 69510, 69710) || true) && (f_10874_69514_69532<TMember>(type) && (DynAbs.Tracing.TraceSender.Expression_True(10874, 69514, 69590) && f_10874_69536_69561<TMember>(type) != SpecialType.System_Object))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 69510, 69710);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 69632, 69663);

                            anyClassOtherThanObject = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(10874, 69685, 69691);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 69510, 69710);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 519);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 519);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 69741, 69825) || true) && (!anyClassOtherThanObject)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 69741, 69825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 69803, 69810);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 69741, 69825);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 69850, 69855);

                    for (int
        f = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 69841, 70358) || true) && (f < f_10874_69861_69874<TMember>(results))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 69876, 69879)
        , f++, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 69841, 70358))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 69841, 70358);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 69913, 69937);

                        var
                        result = f_10874_69926_69936<TMember>(results, f)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 69955, 70051) || true) && (f_10874_69959_69981_M(!result.Result.IsValid))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 69955, 70051);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 70023, 70032);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 69955, 70051);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 70071, 70098);

                        var
                        member = result.Member
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 70116, 70343) || true) && (f_10874_70120_70159<TMember>(f_10874_70120_70141<TMember>(member)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 70116, 70343);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 70201, 70324);

                            results[f] = f_10874_70214_70323<TMember>(member, result.LeastOverriddenMember, MemberAnalysisResult.LessDerived());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 70116, 70343);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 518);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 518);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 67404, 70369);

                int
                f_10874_69227_69240<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 69227, 69240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_69292_69302<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 69292, 69302);
                    return return_v;
                }


                bool
                f_10874_69325_69347_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 69325, 69347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10874_69448_69491<TMember>(TMember
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 69448, 69491);
                    return return_v;
                }


                bool
                f_10874_69514_69532<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type) where TMember : Symbol

                {
                    var return_v = type.IsClassType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 69514, 69532);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10874_69536_69561<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type) where TMember : Symbol

                {
                    var return_v = type.GetSpecialTypeSafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 69536, 69561);
                    return return_v;
                }


                int
                f_10874_69861_69874<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 69861, 69874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_69926_69936<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 69926, 69936);
                    return return_v;
                }


                bool
                f_10874_69959_69981_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 69959, 69981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10874_70120_70141<TMember>(TMember
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 70120, 70141);
                    return return_v;
                }


                bool
                f_10874_70120_70159<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type) where TMember : Symbol

                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 70120, 70159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_70214_70323<TMember>(TMember
                member, TMember
                leastOverriddenMember, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result) where TMember : Symbol

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>(member, leastOverriddenMember, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 70214, 70323);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 67404, 70369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 67404, 70369);
            }
        }

        private void PerformObjectCreationOverloadResolution(
                    ArrayBuilder<MemberResolutionResult<MethodSymbol>> results,
                    ImmutableArray<MethodSymbol> constructors,
                    AnalyzedArguments arguments,
                    bool completeResults,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 70645, 72120);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 71505, 71706);
                    foreach (MethodSymbol constructor in f_10874_71542_71554_I(constructors))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 71505, 71706);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 71588, 71691);

                        f_10874_71588_71690(this, constructor, results, arguments, completeResults, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 71505, 71706);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 202);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 202);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 71722, 71780);

                f_10874_71722_71779(results, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 72023, 72086);

                f_10874_72023_72085(this, results, arguments, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 72102, 72109);

                return;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 70645, 72120);

                int
                f_10874_71588_71690(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructor, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>>
                results, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, bool
                completeResults, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.AddConstructorToCandidateSet(constructor, results, arguments, completeResults, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 71588, 71690);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10874_71542_71554_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 71542, 71554);
                    return return_v;
                }


                int
                f_10874_71722_71779(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>>
                results, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    ReportUseSiteDiagnostics(results, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 71722, 71779);
                    return 0;
                }


                int
                f_10874_72023_72085(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>>
                results, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.RemoveWorseMembers<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(results, arguments, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 72023, 72085);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 70645, 72120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 70645, 72120);
            }
        }

        private static void ReportUseSiteDiagnostics<TMember>(ArrayBuilder<MemberResolutionResult<TMember>> results, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
                    where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 72132, 72723);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 72349, 72712);
                    foreach (MemberResolutionResult<TMember> result in f_10874_72400_72407_I(results))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 72349, 72712);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 72441, 72697) || true) && (result.HasUseSiteDiagnosticToReport)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 72441, 72697);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 72522, 72595);

                            useSiteDiagnostics = useSiteDiagnostics ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>>(10874, 72543, 72594) ?? f_10874_72565_72594<TMember>());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 72617, 72678);

                            f_10874_72617_72677<TMember>(useSiteDiagnostics, f_10874_72640_72676<TMember>(result.Member));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 72441, 72697);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 72349, 72712);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 364);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 364);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 72132, 72723);

                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                f_10874_72565_72594<TMember>() where TMember : Symbol

                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 72565, 72594);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10874_72640_72676<TMember>(TMember
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 72640, 72676);
                    return return_v;
                }


                bool
                f_10874_72617_72677<TMember>(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo
                item) where TMember : Symbol

                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 72617, 72677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                f_10874_72400_72407_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 72400, 72407);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 72132, 72723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 72132, 72723);
            }
        }

        private int GetTheBestCandidateIndex<TMember>(ArrayBuilder<MemberResolutionResult<TMember>> results, AnalyzedArguments arguments, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
                    where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 72735, 75031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 72973, 72999);

                int
                currentBestIndex = -1
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 73022, 73031);
                    for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 73013, 74217) || true) && (index < f_10874_73041_73054<TMember>(results))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 73056, 73063)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 73013, 74217))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 73013, 74217);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 73097, 73194) || true) && (f_10874_73101_73124_M(!results[index].IsValid))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 73097, 73194);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 73166, 73175);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 73097, 73194);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 73301, 74202) || true) && (currentBestIndex == -1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 73301, 74202);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 73369, 73394);

                            currentBestIndex = index;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 73301, 74202);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 73301, 74202);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 73436, 74202) || true) && (results[currentBestIndex].Member == results[index].Member)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 73436, 74202);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 73539, 73561);

                                currentBestIndex = -1;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 73436, 74202);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 73436, 74202);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 73643, 73765);

                                var
                                better = f_10874_73656_73764<TMember>(this, f_10874_73677_73702<TMember>(results, currentBestIndex), f_10874_73704_73718<TMember>(results, index), arguments.Arguments, ref useSiteDiagnostics)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 73787, 74183) || true) && (better == BetterResult.Right)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 73787, 74183);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 73923, 73948);

                                    currentBestIndex = index;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 73787, 74183);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 73787, 74183);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 73998, 74183) || true) && (better != BetterResult.Left)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 73998, 74183);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 74138, 74160);

                                        currentBestIndex = -1;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 73998, 74183);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 73787, 74183);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 73436, 74202);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 73301, 74202);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 1205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 1205);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 74321, 74330);

                    // Make sure that every candidate up to the current best is worse
                    for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 74312, 74980) || true) && (index < currentBestIndex)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 74358, 74365)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 74312, 74980))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 74312, 74980);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 74399, 74496) || true) && (f_10874_74403_74426_M(!results[index].IsValid))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 74399, 74496);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 74468, 74477);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 74399, 74496);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 74516, 74648) || true) && (results[currentBestIndex].Member == results[index].Member)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 74516, 74648);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 74619, 74629);

                            return -1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 74516, 74648);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 74668, 74790);

                        var
                        better = f_10874_74681_74789<TMember>(this, f_10874_74702_74727<TMember>(results, currentBestIndex), f_10874_74729_74743<TMember>(results, index), arguments.Arguments, ref useSiteDiagnostics)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 74808, 74965) || true) && (better != BetterResult.Left)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 74808, 74965);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 74936, 74946);

                            return -1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 74808, 74965);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 669);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 669);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 74996, 75020);

                return currentBestIndex;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 72735, 75031);

                int
                f_10874_73041_73054<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 73041, 73054);
                    return return_v;
                }


                bool
                f_10874_73101_73124_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 73101, 73124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_73677_73702<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 73677, 73702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_73704_73718<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 73704, 73718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10874_73656_73764<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                m1, Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                m2, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = this_param.BetterFunctionMember<TMember>(m1, m2, arguments, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 73656, 73764);
                    return return_v;
                }


                bool
                f_10874_74403_74426_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 74403, 74426);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_74702_74727<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 74702, 74727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_74729_74743<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 74729, 74743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10874_74681_74789<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                m1, Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                m2, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = this_param.BetterFunctionMember<TMember>(m1, m2, arguments, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 74681, 74789);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 72735, 75031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 72735, 75031);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void RemoveWorseMembers<TMember>(ArrayBuilder<MemberResolutionResult<TMember>> results, AnalyzedArguments arguments, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
                    where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 75043, 81326);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 76505, 76591) || true) && (f_10874_76509_76535<TMember>(results))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 76505, 76591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 76569, 76576);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 76505, 76591);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 76751, 76836);

                int
                bestIndex = f_10874_76767_76835<TMember>(this, results, arguments, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 76850, 77272) || true) && (bestIndex != -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 76850, 77272);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 76967, 76976);
                        // Mark all other candidates as worse
                        for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 76958, 77230) || true) && (index < f_10874_76986_76999<TMember>(results))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 77001, 77008)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 76958, 77230))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 76958, 77230);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 77050, 77211) || true) && (results[index].IsValid && (DynAbs.Tracing.TraceSender.Expression_True(10874, 77054, 77098) && index != bestIndex))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 77050, 77211);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 77148, 77188);

                                results[index] = results[index].Worse();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 77050, 77211);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 273);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 273);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 77250, 77257);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 76850, 77272);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 77288, 77310);

                const int
                unknown = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 77324, 77357);

                const int
                worseThanSomething = 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 77371, 77409);

                const int
                notBetterThanEverything = 2
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 77425, 77491);

                var
                worse = f_10874_77437_77490<TMember>(f_10874_77467_77480<TMember>(results), unknown)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 77507, 77540);

                int
                countOfNotBestCandidates = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 77554, 77574);

                int
                notBestIdx = -1
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 77599, 77608);

                    for (int
        c1Idx = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 77590, 79081) || true) && (c1Idx < f_10874_77618_77631<TMember>(results))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 77633, 77640)
        , c1Idx++, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 77590, 79081))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 77590, 79081);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 77674, 77704);

                        var
                        c1Result = f_10874_77689_77703<TMember>(results, c1Idx)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 77822, 77951) || true) && (f_10874_77826_77843_M(!c1Result.IsValid) || (DynAbs.Tracing.TraceSender.Expression_False(10874, 77826, 77881) || f_10874_77847_77859<TMember>(worse, c1Idx) == worseThanSomething))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 77822, 77951);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 77923, 77932);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 77822, 77951);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 77980, 77989);

                            for (int
            c2Idx = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 77971, 78774) || true) && (c2Idx < f_10874_77999_78012<TMember>(results))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 78014, 78021)
            , c2Idx++, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 77971, 78774))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 77971, 78774);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 78063, 78093);

                                var
                                c2Result = f_10874_78078_78092<TMember>(results, c2Idx)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 78115, 78274) || true) && (f_10874_78119_78136_M(!c2Result.IsValid) || (DynAbs.Tracing.TraceSender.Expression_False(10874, 78119, 78154) || c1Idx == c2Idx) || (DynAbs.Tracing.TraceSender.Expression_False(10874, 78119, 78192) || c1Result.Member == c2Result.Member))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 78115, 78274);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 78242, 78251);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 78115, 78274);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 78298, 78397);

                                var
                                better = f_10874_78311_78396<TMember>(this, c1Result, c2Result, arguments.Arguments, ref useSiteDiagnostics)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 78419, 78755) || true) && (better == BetterResult.Left)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 78419, 78755);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 78500, 78534);

                                    worse[c2Idx] = worseThanSomething;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 78419, 78755);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 78419, 78755);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 78584, 78755) || true) && (better == BetterResult.Right)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 78584, 78755);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 78666, 78700);

                                        worse[c1Idx] = worseThanSomething;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10874, 78726, 78732);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 78584, 78755);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 78419, 78755);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 804);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 804);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 78794, 79066) || true) && (f_10874_78798_78810<TMember>(worse, c1Idx) == unknown)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 78794, 79066);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 78918, 78957);

                            worse[c1Idx] = notBetterThanEverything;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 78979, 79006);

                            countOfNotBestCandidates++;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 79028, 79047);

                            notBestIdx = c1Idx;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 78794, 79066);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 1492);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 1492);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 79097, 81286) || true) && (countOfNotBestCandidates == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 79097, 81286);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 79173, 79178);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 79164, 79479) || true) && (i < f_10874_79184_79195<TMember>(worse))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 79197, 79200)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 79164, 79479))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 79164, 79479);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 79242, 79299);

                            f_10874_79242_79298<TMember>(f_10874_79255_79274_M(!results[i].IsValid) || (DynAbs.Tracing.TraceSender.Expression_False(10874, 79255, 79297) || f_10874_79278_79286<TMember>(worse, i) != unknown));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 79321, 79460) || true) && (f_10874_79325_79333<TMember>(worse, i) == worseThanSomething)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 79321, 79460);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 79405, 79437);

                                results[i] = results[i].Worse();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 79321, 79460);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 316);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 316);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 79097, 81286);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 79097, 81286);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 79513, 81286) || true) && (countOfNotBestCandidates == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 79513, 81286);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 79589, 79594);
                            for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 79580, 80381) || true) && (i < f_10874_79600_79611<TMember>(worse))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 79613, 79616)
            , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 79580, 80381))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 79580, 80381);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 79658, 79715);

                                f_10874_79658_79714<TMember>(f_10874_79671_79690_M(!results[i].IsValid) || (DynAbs.Tracing.TraceSender.Expression_False(10874, 79671, 79713) || f_10874_79694_79702<TMember>(worse, i) != unknown));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 79737, 80362) || true) && (f_10874_79741_79749<TMember>(worse, i) == worseThanSomething)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 79737, 80362);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 79968, 80172);

                                    results[i] = (DynAbs.Tracing.TraceSender.Conditional_F1(10874, 79981, 80100) || ((BetterResult.Left == f_10874_80002_80100<TMember>(this, f_10874_80023_80042<TMember>(results, notBestIdx), f_10874_80044_80054<TMember>(results, i), arguments.Arguments, ref useSiteDiagnostics) && DynAbs.Tracing.TraceSender.Conditional_F2(10874, 80132, 80150)) || DynAbs.Tracing.TraceSender.Conditional_F3(10874, 80153, 80171))) ? results[i].Worst() : results[i].Worse();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 79737, 80362);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 79737, 80362);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 80270, 80339);

                                    f_10874_80270_80338<TMember>(f_10874_80283_80291<TMember>(worse, i) != notBetterThanEverything || (DynAbs.Tracing.TraceSender.Expression_False(10874, 80283, 80337) || i == notBestIdx));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 79737, 80362);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 802);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 802);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 80401, 80460);

                        f_10874_80401_80459<TMember>(f_10874_80414_80431<TMember>(worse, notBestIdx) == notBetterThanEverything);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 80478, 80528);

                        results[notBestIdx] = results[notBestIdx].Worse();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 79513, 81286);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 79513, 81286);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 80594, 80637);

                        f_10874_80594_80636<TMember>(countOfNotBestCandidates > 1);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 80666, 80671);

                            for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 80657, 81271) || true) && (i < f_10874_80677_80688<TMember>(worse))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 80690, 80693)
            , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 80657, 81271))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 80657, 81271);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 80735, 80792);

                                f_10874_80735_80791<TMember>(f_10874_80748_80767_M(!results[i].IsValid) || (DynAbs.Tracing.TraceSender.Expression_False(10874, 80748, 80790) || f_10874_80771_80779<TMember>(worse, i) != unknown));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 80814, 81252) || true) && (f_10874_80818_80826<TMember>(worse, i) == worseThanSomething)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 80814, 81252);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 81026, 81058);

                                    results[i] = results[i].Worst();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 80814, 81252);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 80814, 81252);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 81108, 81252) || true) && (f_10874_81112_81120<TMember>(worse, i) == notBetterThanEverything)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 81108, 81252);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 81197, 81229);

                                        results[i] = results[i].Worse();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 81108, 81252);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 80814, 81252);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 615);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 615);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 79513, 81286);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 79097, 81286);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 81302, 81315);

                f_10874_81302_81314<TMember>(
                            worse);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 75043, 81326);

                bool
                f_10874_76509_76535<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                results) where TMember : Symbol

                {
                    var return_v = SingleValidResult(results);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 76509, 76535);
                    return return_v;
                }


                int
                f_10874_76767_76835<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                results, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = this_param.GetTheBestCandidateIndex<TMember>(results, arguments, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 76767, 76835);
                    return return_v;
                }


                int
                f_10874_76986_76999<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 76986, 76999);
                    return return_v;
                }


                int
                f_10874_77467_77480<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 77467, 77480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                f_10874_77437_77490<TMember>(int
                capacity, int
                fillWithValue) where TMember : Symbol

                {
                    var return_v = ArrayBuilder<int>.GetInstance(capacity, fillWithValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 77437, 77490);
                    return return_v;
                }


                int
                f_10874_77618_77631<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 77618, 77631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_77689_77703<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 77689, 77703);
                    return return_v;
                }


                bool
                f_10874_77826_77843_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 77826, 77843);
                    return return_v;
                }


                int
                f_10874_77847_77859<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 77847, 77859);
                    return return_v;
                }


                int
                f_10874_77999_78012<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 77999, 78012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_78078_78092<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 78078, 78092);
                    return return_v;
                }


                bool
                f_10874_78119_78136_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 78119, 78136);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10874_78311_78396<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                m1, Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                m2, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = this_param.BetterFunctionMember<TMember>(m1, m2, arguments, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 78311, 78396);
                    return return_v;
                }


                int
                f_10874_78798_78810<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 78798, 78810);
                    return return_v;
                }


                int
                f_10874_79184_79195<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 79184, 79195);
                    return return_v;
                }


                bool
                f_10874_79255_79274_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 79255, 79274);
                    return return_v;
                }


                int
                f_10874_79278_79286<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 79278, 79286);
                    return return_v;
                }


                int
                f_10874_79242_79298<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 79242, 79298);
                    return 0;
                }


                int
                f_10874_79325_79333<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 79325, 79333);
                    return return_v;
                }


                int
                f_10874_79600_79611<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 79600, 79611);
                    return return_v;
                }


                bool
                f_10874_79671_79690_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 79671, 79690);
                    return return_v;
                }


                int
                f_10874_79694_79702<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 79694, 79702);
                    return return_v;
                }


                int
                f_10874_79658_79714<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 79658, 79714);
                    return 0;
                }


                int
                f_10874_79741_79749<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 79741, 79749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_80023_80042<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 80023, 80042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_80044_80054<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 80044, 80054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10874_80002_80100<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                m1, Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                m2, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = this_param.BetterFunctionMember<TMember>(m1, m2, arguments, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 80002, 80100);
                    return return_v;
                }


                int
                f_10874_80283_80291<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 80283, 80291);
                    return return_v;
                }


                int
                f_10874_80270_80338<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 80270, 80338);
                    return 0;
                }


                int
                f_10874_80414_80431<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 80414, 80431);
                    return return_v;
                }


                int
                f_10874_80401_80459<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 80401, 80459);
                    return 0;
                }


                int
                f_10874_80594_80636<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 80594, 80636);
                    return 0;
                }


                int
                f_10874_80677_80688<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 80677, 80688);
                    return return_v;
                }


                bool
                f_10874_80748_80767_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 80748, 80767);
                    return return_v;
                }


                int
                f_10874_80771_80779<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 80771, 80779);
                    return return_v;
                }


                int
                f_10874_80735_80791<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 80735, 80791);
                    return 0;
                }


                int
                f_10874_80818_80826<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 80818, 80826);
                    return return_v;
                }


                int
                f_10874_81112_81120<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 81112, 81120);
                    return return_v;
                }


                int
                f_10874_81302_81314<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param) where TMember : Symbol

                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 81302, 81314);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 75043, 81326);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 75043, 81326);
            }
        }

        private TypeSymbol GetParameterType(ParameterSymbol parameter, MemberAnalysisResult result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 82385, 82845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 82501, 82527);

                var
                type = f_10874_82512_82526(parameter)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 82541, 82834) || true) && (result.Kind == MemberResolutionKind.ApplicableInExpandedForm && (DynAbs.Tracing.TraceSender.Expression_True(10874, 82545, 82644) && f_10874_82626_82644(parameter)) && (DynAbs.Tracing.TraceSender.Expression_True(10874, 82545, 82664) && f_10874_82648_82664(type)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 82541, 82834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 82698, 82741);

                    return f_10874_82705_82740(((ArrayTypeSymbol)type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 82541, 82834);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 82541, 82834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 82807, 82819);

                    return type;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 82541, 82834);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 82385, 82845);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_82512_82526(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 82512, 82526);
                    return return_v;
                }


                bool
                f_10874_82626_82644(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsParams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 82626, 82644);
                    return return_v;
                }


                bool
                f_10874_82648_82664(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsSZArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 82648, 82664);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_82705_82740(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 82705, 82740);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 82385, 82845);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 82385, 82845);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ParameterSymbol GetParameter(int argIndex, MemberAnalysisResult result, ImmutableArray<ParameterSymbol> parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 82982, 83248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 83137, 83193);

                int
                paramIndex = result.ParameterFromArgument(argIndex)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 83207, 83237);

                return parameters[paramIndex];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 82982, 83248);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 82982, 83248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 82982, 83248);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BetterResult BetterFunctionMember<TMember>(
                    MemberResolutionResult<TMember> m1,
                    MemberResolutionResult<TMember> m2,
                    ArrayBuilder<BoundExpression> arguments,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
                    where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 83260, 84961);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 83585, 83617);

                f_10874_83585_83616<TMember>(m1.Result.IsValid);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 83631, 83663);

                f_10874_83631_83662<TMember>(m2.Result.IsValid);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 83677, 83709);

                f_10874_83677_83708<TMember>(arguments != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 84403, 84471);

                bool
                hasAnyRefOmittedArgument1 = m1.Result.HasAnyRefOmittedArgument
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 84485, 84553);

                bool
                hasAnyRefOmittedArgument2 = m2.Result.HasAnyRefOmittedArgument
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 84567, 84950) || true) && (hasAnyRefOmittedArgument1 != hasAnyRefOmittedArgument2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 84567, 84950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 84659, 84733);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10874, 84666, 84691) || ((hasAnyRefOmittedArgument1 && DynAbs.Tracing.TraceSender.Conditional_F2(10874, 84694, 84712)) || DynAbs.Tracing.TraceSender.Conditional_F3(10874, 84715, 84732))) ? BetterResult.Right : BetterResult.Left;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 84567, 84950);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 84567, 84950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 84799, 84935);

                    return f_10874_84806_84934<TMember>(this, m1, m2, arguments, considerRefKinds: hasAnyRefOmittedArgument1, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 84567, 84950);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 83260, 84961);

                int
                f_10874_83585_83616<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 83585, 83616);
                    return 0;
                }


                int
                f_10874_83631_83662<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 83631, 83662);
                    return 0;
                }


                int
                f_10874_83677_83708<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 83677, 83708);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10874_84806_84934<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                m1, Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                m2, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, bool
                considerRefKinds, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = this_param.BetterFunctionMember<TMember>(m1, m2, arguments, considerRefKinds: considerRefKinds, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 84806, 84934);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 83260, 84961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 83260, 84961);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BetterResult BetterFunctionMember<TMember>(
                    MemberResolutionResult<TMember> m1,
                    MemberResolutionResult<TMember> m2,
                    ArrayBuilder<BoundExpression> arguments,
                    bool considerRefKinds,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
                    where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 84973, 105962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 85334, 85366);

                f_10874_85334_85365<TMember>(m1.Result.IsValid);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 85380, 85412);

                f_10874_85380_85411<TMember>(m2.Result.IsValid);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 85426, 85458);

                f_10874_85426_85457<TMember>(arguments != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 86135, 86178);

                BetterResult
                result = BetterResult.Neither
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 86192, 86234);

                bool
                okToDowngradeResultToNeither = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 86248, 86289);

                bool
                ignoreDowngradableToNeither = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 86875, 86950);

                var
                m1LeastOverriddenParameters = f_10874_86909_86949<TMember>(m1.LeastOverriddenMember)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 86964, 87039);

                var
                m2LeastOverriddenParameters = f_10874_86998_87038<TMember>(m2.LeastOverriddenMember)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 87055, 87075);

                bool
                allSame = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 87184, 87190);

                int
                i
                = default(int);
                try
                {
                    for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 87209, 87214)
   , i = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 87204, 93112) || true) && (i < f_10874_87220_87235<TMember>(arguments))
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 87237, 87240)
   , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 87204, 93112))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 87204, 93112);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 87274, 87311);

                        var
                        argumentKind = f_10874_87293_87310<TMember>(f_10874_87293_87305<TMember>(arguments, i))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 87529, 87792) || true) && (argumentKind == BoundKind.ArgListOperator)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 87529, 87792);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 87616, 87655);

                            f_10874_87616_87654<TMember>(i == f_10874_87634_87649<TMember>(arguments) - 1);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 87677, 87742);

                            f_10874_87677_87741<TMember>(f_10874_87690_87713<TMember>(m1.Member) && (DynAbs.Tracing.TraceSender.Expression_True(10874, 87690, 87740) && f_10874_87717_87740<TMember>(m2.Member)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 87764, 87773);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 87529, 87792);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 87812, 87885);

                        var
                        parameter1 = f_10874_87829_87884<TMember>(i, m1.Result, m1LeastOverriddenParameters)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 87903, 87955);

                        var
                        type1 = f_10874_87915_87954<TMember>(this, parameter1, m1.Result)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 87975, 88048);

                        var
                        parameter2 = f_10874_87992_88047<TMember>(i, m2.Result, m2LeastOverriddenParameters)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 88066, 88118);

                        var
                        type2 = f_10874_88078_88117<TMember>(this, parameter2, m2.Result)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 88138, 88166);

                        bool
                        okToDowngradeToNeither
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 88184, 88199);

                        BetterResult
                        r
                        = default(BetterResult);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 88219, 88922);

                        r = f_10874_88223_88921<TMember>(this, f_10874_88254_88266<TMember>(arguments, i), type1, m1.Result.ConversionForArg(i), f_10874_88462_88480<TMember>(parameter1), type2, m2.Result.ConversionForArg(i), f_10874_88676_88694<TMember>(parameter2), considerRefKinds, ref useSiteDiagnostics, out okToDowngradeToNeither);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 88942, 88970);

                        var
                        type1Normalized = type1
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 88988, 89016);

                        var
                        type2Normalized = type2
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 89321, 89548) || true) && (f_10874_89325_89353_M(!_binder.InAttributeArgument))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 89321, 89548);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 89395, 89451);

                            type1Normalized = f_10874_89413_89450<TMember>(type1, f_10874_89438_89449<TMember>());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 89473, 89529);

                            type2Normalized = f_10874_89491_89528<TMember>(type2, f_10874_89516_89527<TMember>());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 89321, 89548);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 89568, 90001) || true) && (r == BetterResult.Neither)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 89568, 90001);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 89639, 89879) || true) && (allSame && (DynAbs.Tracing.TraceSender.Expression_True(10874, 89643, 89790) && f_10874_89654_89758<TMember>(f_10874_89654_89665<TMember>(), type1Normalized, type2Normalized, ref useSiteDiagnostics).Kind != ConversionKind.Identity))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 89639, 89879);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 89840, 89856);

                                allSame = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 89639, 89879);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 89973, 89982);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 89568, 90001);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 90021, 90238) || true) && (f_10874_90025_90129<TMember>(f_10874_90025_90036<TMember>(), type1Normalized, type2Normalized, ref useSiteDiagnostics).Kind != ConversionKind.Identity)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 90021, 90238);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 90203, 90219);

                            allSame = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 90021, 90238);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 90399, 93097) || true) && (result == BetterResult.Neither)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 90399, 93097);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 90475, 90811) || true) && (!(ignoreDowngradableToNeither && (DynAbs.Tracing.TraceSender.Expression_True(10874, 90481, 90534) && okToDowngradeToNeither)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 90475, 90811);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 90697, 90708);

                                result = r;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 90734, 90788);

                                okToDowngradeResultToNeither = okToDowngradeToNeither;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 90475, 90811);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 90399, 93097);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 90399, 93097);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 90853, 93097) || true) && (result != r)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 90853, 93097);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 91364, 92680) || true) && (okToDowngradeResultToNeither)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 91364, 92680);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 91446, 92338) || true) && (okToDowngradeToNeither)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 91446, 92338);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 91708, 91738);

                                        result = BetterResult.Neither;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 91768, 91805);

                                        okToDowngradeResultToNeither = false;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 91835, 91870);

                                        ignoreDowngradableToNeither = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 91900, 91909);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 91446, 92338);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 91446, 92338);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 92194, 92205);

                                        result = r;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 92235, 92272);

                                        okToDowngradeResultToNeither = false;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 92302, 92311);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 91446, 92338);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 91364, 92680);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 91364, 92680);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 92388, 92680) || true) && (okToDowngradeToNeither)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 92388, 92680);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 92648, 92657);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 92388, 92680);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 91364, 92680);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 92704, 92734);

                                result = BetterResult.Neither;
                                DynAbs.Tracing.TraceSender.TraceBreak(10874, 92756, 92762);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 90853, 93097);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 90853, 93097);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 92844, 92870);

                                f_10874_92844_92869<TMember>(result == r);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 92892, 92966);

                                f_10874_92892_92965<TMember>(result == BetterResult.Left || (DynAbs.Tracing.TraceSender.Expression_False(10874, 92905, 92964) || result == BetterResult.Right));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 92990, 93078);

                                okToDowngradeResultToNeither = (okToDowngradeResultToNeither && (DynAbs.Tracing.TraceSender.Expression_True(10874, 93022, 93076) && okToDowngradeToNeither));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 90853, 93097);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 90399, 93097);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 5909);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 5909);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 93185, 93282) || true) && (result != BetterResult.Neither)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 93185, 93282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 93253, 93267);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 93185, 93282);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 93648, 93669);

                int
                m1ParameterCount
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 93683, 93704);

                int
                m2ParameterCount
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 93718, 93768);

                int
                m1ParametersUsedIncludingExpansionAndOptional
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 93782, 93832);

                int
                m2ParametersUsedIncludingExpansionAndOptional
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 93848, 93955);

                f_10874_93848_93954<TMember>(m1, arguments, out m1ParameterCount, out m1ParametersUsedIncludingExpansionAndOptional);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 93969, 94076);

                f_10874_93969_94075<TMember>(m2, arguments, out m2ParameterCount, out m2ParametersUsedIncludingExpansionAndOptional);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 94552, 96429) || true) && (allSame && (DynAbs.Tracing.TraceSender.Expression_True(10874, 94556, 94661) && m1ParametersUsedIncludingExpansionAndOptional == m2ParametersUsedIncludingExpansionAndOptional))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 94552, 96429);
                    try
                    {                // Complete comparison for the remaining parameter types
                        for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 94774, 94783)
        , i = i + 1; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 94769, 96414) || true) && (i < f_10874_94789_94804<TMember>(arguments))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 94806, 94809)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 94769, 96414))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 94769, 96414);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 94851, 94888);

                            var
                            argumentKind = f_10874_94870_94887<TMember>(f_10874_94870_94882<TMember>(arguments, i))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 95118, 95401) || true) && (argumentKind == BoundKind.ArgListOperator)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 95118, 95401);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 95213, 95252);

                                f_10874_95213_95251<TMember>(i == f_10874_95231_95246<TMember>(arguments) - 1);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 95278, 95343);

                                f_10874_95278_95342<TMember>(f_10874_95291_95314<TMember>(m1.Member) && (DynAbs.Tracing.TraceSender.Expression_True(10874, 95291, 95341) && f_10874_95318_95341<TMember>(m2.Member)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 95369, 95378);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 95118, 95401);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 95425, 95498);

                            var
                            parameter1 = f_10874_95442_95497<TMember>(i, m1.Result, m1LeastOverriddenParameters)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 95520, 95572);

                            var
                            type1 = f_10874_95532_95571<TMember>(this, parameter1, m1.Result)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 95596, 95669);

                            var
                            parameter2 = f_10874_95613_95668<TMember>(i, m2.Result, m2LeastOverriddenParameters)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 95691, 95743);

                            var
                            type2 = f_10874_95703_95742<TMember>(this, parameter2, m2.Result)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 95767, 95795);

                            var
                            type1Normalized = type1
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 95817, 95845);

                            var
                            type2Normalized = type2
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 95867, 96110) || true) && (f_10874_95871_95899_M(!_binder.InAttributeArgument))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 95867, 96110);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 95949, 96005);

                                type1Normalized = f_10874_95967_96004<TMember>(type1, f_10874_95992_96003<TMember>());
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 96031, 96087);

                                type2Normalized = f_10874_96049_96086<TMember>(type2, f_10874_96074_96085<TMember>());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 95867, 96110);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 96134, 96395) || true) && (f_10874_96138_96242<TMember>(f_10874_96138_96149<TMember>(), type1Normalized, type2Normalized, ref useSiteDiagnostics).Kind != ConversionKind.Identity)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 96134, 96395);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 96324, 96340);

                                allSame = false;
                                DynAbs.Tracing.TraceSender.TraceBreak(10874, 96366, 96372);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 96134, 96395);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 1646);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 1646);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 94552, 96429);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 96865, 99300) || true) && (!allSame || (DynAbs.Tracing.TraceSender.Expression_False(10874, 96869, 96975) || m1ParametersUsedIncludingExpansionAndOptional != m2ParametersUsedIncludingExpansionAndOptional))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 96865, 99300);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 97771, 99155) || true) && (m1ParametersUsedIncludingExpansionAndOptional != m2ParametersUsedIncludingExpansionAndOptional)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 97771, 99155);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 97911, 98525) || true) && (m1.Result.Kind == MemberResolutionKind.ApplicableInExpandedForm)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 97911, 98525);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 98028, 98206) || true) && (m2.Result.Kind != MemberResolutionKind.ApplicableInExpandedForm)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 98028, 98206);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 98153, 98179);

                                return BetterResult.Right;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 98028, 98206);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 97911, 98525);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 97911, 98525);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 98256, 98525) || true) && (m2.Result.Kind == MemberResolutionKind.ApplicableInExpandedForm)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 98256, 98525);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 98373, 98451);

                                f_10874_98373_98450<TMember>(m1.Result.Kind != MemberResolutionKind.ApplicableInExpandedForm);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 98477, 98502);

                                return BetterResult.Left;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 98256, 98525);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 97911, 98525);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 98776, 99136) || true) && (m1ParametersUsedIncludingExpansionAndOptional == f_10874_98829_98844<TMember>(arguments))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 98776, 99136);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 98894, 98919);

                            return BetterResult.Left;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 98776, 99136);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 98776, 99136);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 98969, 99136) || true) && (m2ParametersUsedIncludingExpansionAndOptional == f_10874_99022_99037<TMember>(arguments))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 98969, 99136);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 99087, 99113);

                                return BetterResult.Right;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 98969, 99136);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 98776, 99136);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 97771, 99155);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 99175, 99285);

                    return f_10874_99182_99284<TMember>(arguments, m1, m1LeastOverriddenParameters, m2, m2LeastOverriddenParameters);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 96865, 99300);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 99417, 99750) || true) && (f_10874_99421_99447<TMember>(m1.Member) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 99417, 99750);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 99486, 99606) || true) && (f_10874_99490_99516<TMember>(m2.Member) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 99486, 99606);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 99562, 99587);

                        return BetterResult.Left;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 99486, 99606);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 99417, 99750);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 99417, 99750);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 99640, 99750) || true) && (f_10874_99644_99670<TMember>(m2.Member) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 99640, 99750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 99709, 99735);

                        return BetterResult.Right;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 99640, 99750);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 99417, 99750);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 99948, 100154) || true) && (m1.Result.Kind == MemberResolutionKind.ApplicableInNormalForm && (DynAbs.Tracing.TraceSender.Expression_True(10874, 99952, 100080) && m2.Result.Kind == MemberResolutionKind.ApplicableInExpandedForm))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 99948, 100154);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 100114, 100139);

                    return BetterResult.Left;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 99948, 100154);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 100170, 100377) || true) && (m1.Result.Kind == MemberResolutionKind.ApplicableInExpandedForm && (DynAbs.Tracing.TraceSender.Expression_True(10874, 100174, 100302) && m2.Result.Kind == MemberResolutionKind.ApplicableInNormalForm))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 100170, 100377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 100336, 100362);

                    return BetterResult.Right;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 100170, 100377);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 101039, 101493) || true) && (m1.Result.Kind == MemberResolutionKind.ApplicableInExpandedForm && (DynAbs.Tracing.TraceSender.Expression_True(10874, 101043, 101173) && m2.Result.Kind == MemberResolutionKind.ApplicableInExpandedForm))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 101039, 101493);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 101207, 101332) || true) && (m1ParameterCount > m2ParameterCount)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 101207, 101332);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 101288, 101313);

                        return BetterResult.Left;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 101207, 101332);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 101352, 101478) || true) && (m1ParameterCount < m2ParameterCount)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 101352, 101478);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 101433, 101459);

                        return BetterResult.Right;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 101352, 101478);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 101039, 101493);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 101742, 101860);

                bool
                hasAll1 = m1.Result.Kind == MemberResolutionKind.ApplicableInExpandedForm || (DynAbs.Tracing.TraceSender.Expression_False(10874, 101757, 101859) || m1ParameterCount == f_10874_101844_101859<TMember>(arguments))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 101874, 101992);

                bool
                hasAll2 = m2.Result.Kind == MemberResolutionKind.ApplicableInExpandedForm || (DynAbs.Tracing.TraceSender.Expression_False(10874, 101889, 101991) || m2ParameterCount == f_10874_101976_101991<TMember>(arguments))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 102006, 102103) || true) && (hasAll1 && (DynAbs.Tracing.TraceSender.Expression_True(10874, 102010, 102029) && !hasAll2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 102006, 102103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 102063, 102088);

                    return BetterResult.Left;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 102006, 102103);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 102119, 102217) || true) && (!hasAll1 && (DynAbs.Tracing.TraceSender.Expression_True(10874, 102123, 102142) && hasAll2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 102119, 102217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 102176, 102202);

                    return BetterResult.Right;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 102119, 102217);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 102844, 102897);

                var
                uninst1 = f_10874_102858_102896<TMember>()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 102911, 102964);

                var
                uninst2 = f_10874_102925_102963<TMember>()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 102978, 103055);

                var
                m1Original = f_10874_102995_103054<TMember>(f_10874_102995_103038<TMember>(m1.LeastOverriddenMember))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 103069, 103146);

                var
                m2Original = f_10874_103086_103145<TMember>(f_10874_103086_103129<TMember>(m2.LeastOverriddenMember))
                ;
                try
                {
                    for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 103165, 103170)
   , i = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 103160, 104005) || true) && (i < f_10874_103176_103191<TMember>(arguments))
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 103193, 103196)
   , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 103160, 104005))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 103160, 104005);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 103428, 103696) || true) && (f_10874_103432_103449<TMember>(f_10874_103432_103444<TMember>(arguments, i)) == BoundKind.ArgListOperator)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 103428, 103696);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 103520, 103559);

                            f_10874_103520_103558<TMember>(i == f_10874_103538_103553<TMember>(arguments) - 1);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 103581, 103646);

                            f_10874_103581_103645<TMember>(f_10874_103594_103617<TMember>(m1.Member) && (DynAbs.Tracing.TraceSender.Expression_True(10874, 103594, 103644) && f_10874_103621_103644<TMember>(m2.Member)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 103668, 103677);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 103428, 103696);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 103716, 103772);

                        var
                        parameter1 = f_10874_103733_103771<TMember>(i, m1.Result, m1Original)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 103790, 103843);

                        f_10874_103790_103842<TMember>(uninst1, f_10874_103802_103841<TMember>(this, parameter1, m1.Result));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 103863, 103919);

                        var
                        parameter2 = f_10874_103880_103918<TMember>(i, m2.Result, m2Original)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 103937, 103990);

                        f_10874_103937_103989<TMember>(uninst2, f_10874_103949_103988<TMember>(this, parameter2, m2.Result));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 846);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 846);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 104021, 104089);

                result = f_10874_104030_104088<TMember>(uninst1, uninst2, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 104103, 104118);

                f_10874_104103_104117<TMember>(uninst1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 104132, 104147);

                f_10874_104132_104146<TMember>(uninst2);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 104163, 104260) || true) && (result != BetterResult.Neither)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 104163, 104260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 104231, 104245);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 104163, 104260);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 104529, 105309) || true) && (f_10874_104533_104566<TMember>(f_10874_104533_104557<TMember>(m1.Member)) == TypeKind.Submission && (DynAbs.Tracing.TraceSender.Expression_True(10874, 104533, 104649) && f_10874_104593_104626<TMember>(f_10874_104593_104617<TMember>(m2.Member)) == TypeKind.Submission))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 104529, 105309);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 104745, 104795);

                    var
                    compilation1 = f_10874_104764_104794<TMember>(m1.Member)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 104813, 104863);

                    var
                    compilation2 = f_10874_104832_104862<TMember>(m2.Member)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 104881, 104939);

                    int
                    submissionId1 = f_10874_104901_104938<TMember>(compilation1)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 104957, 105015);

                    int
                    submissionId2 = f_10874_104977_105014<TMember>(compilation2)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 105035, 105154) || true) && (submissionId1 > submissionId2)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 105035, 105154);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 105110, 105135);

                        return BetterResult.Left;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 105035, 105154);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 105174, 105294) || true) && (submissionId1 < submissionId2)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 105174, 105294);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 105249, 105275);

                        return BetterResult.Right;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 105174, 105294);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 104529, 105309);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 105402, 105471);

                int
                m1ModifierCount = f_10874_105424_105470<TMember>(m1.LeastOverriddenMember)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 105485, 105554);

                int
                m2ModifierCount = f_10874_105507_105553<TMember>(m2.LeastOverriddenMember)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 105568, 105739) || true) && (m1ModifierCount != m2ModifierCount)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 105568, 105739);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 105640, 105724);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10874, 105647, 105682) || (((m1ModifierCount < m2ModifierCount) && DynAbs.Tracing.TraceSender.Conditional_F2(10874, 105685, 105702)) || DynAbs.Tracing.TraceSender.Conditional_F3(10874, 105705, 105723))) ? BetterResult.Left : BetterResult.Right;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 105568, 105739);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 105841, 105951);

                return f_10874_105848_105950<TMember>(arguments, m1, m1LeastOverriddenParameters, m2, m2LeastOverriddenParameters);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 84973, 105962);

                int
                f_10874_85334_85365<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 85334, 85365);
                    return 0;
                }


                int
                f_10874_85380_85411<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 85380, 85411);
                    return 0;
                }


                int
                f_10874_85426_85457<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 85426, 85457);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10874_86909_86949<TMember>(TMember
                member) where TMember : Symbol

                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 86909, 86949);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10874_86998_87038<TMember>(TMember
                member) where TMember : Symbol

                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 86998, 87038);
                    return return_v;
                }


                int
                f_10874_87220_87235<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 87220, 87235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10874_87293_87305<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 87293, 87305);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10874_87293_87310<TMember>(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 87293, 87310);
                    return return_v;
                }


                int
                f_10874_87634_87649<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 87634, 87649);
                    return return_v;
                }


                int
                f_10874_87616_87654<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 87616, 87654);
                    return 0;
                }


                bool
                f_10874_87690_87713<TMember>(TMember
                member) where TMember : Symbol

                {
                    var return_v = member.GetIsVararg();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 87690, 87713);
                    return return_v;
                }


                bool
                f_10874_87717_87740<TMember>(TMember
                member) where TMember : Symbol

                {
                    var return_v = member.GetIsVararg();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 87717, 87740);
                    return return_v;
                }


                int
                f_10874_87677_87741<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 87677, 87741);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10874_87829_87884<TMember>(int
                argIndex, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters) where TMember : Symbol

                {
                    var return_v = GetParameter(argIndex, result, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 87829, 87884);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_87915_87954<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result) where TMember : Symbol

                {
                    var return_v = this_param.GetParameterType(parameter, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 87915, 87954);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10874_87992_88047<TMember>(int
                argIndex, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters) where TMember : Symbol

                {
                    var return_v = GetParameter(argIndex, result, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 87992, 88047);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_88078_88117<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result) where TMember : Symbol

                {
                    var return_v = this_param.GetParameterType(parameter, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 88078, 88117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10874_88254_88266<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 88254, 88266);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10874_88462_88480<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 88462, 88480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10874_88676_88694<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 88676, 88694);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10874_88223_88921<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t1, Microsoft.CodeAnalysis.CSharp.Conversion
                conv1, Microsoft.CodeAnalysis.RefKind
                refKind1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.CSharp.Conversion
                conv2, Microsoft.CodeAnalysis.RefKind
                refKind2, bool
                considerRefKinds, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, out bool
                okToDowngradeToNeither) where TMember : Symbol

                {
                    var return_v = this_param.BetterConversionFromExpression(node, t1, conv1, refKind1, t2, conv2, refKind2, considerRefKinds, ref useSiteDiagnostics, out okToDowngradeToNeither);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 88223, 88921);
                    return return_v;
                }


                bool
                f_10874_89325_89353_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 89325, 89353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10874_89438_89449<TMember>() where TMember : Symbol

                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 89438, 89449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_89413_89450<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation) where TMember : Symbol

                {
                    var return_v = type.NormalizeTaskTypes(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 89413, 89450);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10874_89516_89527<TMember>() where TMember : Symbol

                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 89516, 89527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_89491_89528<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation) where TMember : Symbol

                {
                    var return_v = type.NormalizeTaskTypes(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 89491, 89528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10874_89654_89665<TMember>() where TMember : Symbol

                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 89654, 89665);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10874_89654_89758<TMember>(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = this_param.ClassifyImplicitConversionFromType(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 89654, 89758);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10874_90025_90036<TMember>() where TMember : Symbol

                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 90025, 90036);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10874_90025_90129<TMember>(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = this_param.ClassifyImplicitConversionFromType(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 90025, 90129);
                    return return_v;
                }


                int
                f_10874_92844_92869<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 92844, 92869);
                    return 0;
                }


                int
                f_10874_92892_92965<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 92892, 92965);
                    return 0;
                }


                int
                f_10874_93848_93954<TMember>(Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                m, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, out int
                declaredParameterCount, out int
                parametersUsedIncludingExpansionAndOptional) where TMember : Symbol

                {
                    GetParameterCounts(m, arguments, out declaredParameterCount, out parametersUsedIncludingExpansionAndOptional);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 93848, 93954);
                    return 0;
                }


                int
                f_10874_93969_94075<TMember>(Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                m, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, out int
                declaredParameterCount, out int
                parametersUsedIncludingExpansionAndOptional) where TMember : Symbol

                {
                    GetParameterCounts(m, arguments, out declaredParameterCount, out parametersUsedIncludingExpansionAndOptional);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 93969, 94075);
                    return 0;
                }


                int
                f_10874_94789_94804<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 94789, 94804);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10874_94870_94882<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 94870, 94882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10874_94870_94887<TMember>(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 94870, 94887);
                    return return_v;
                }


                int
                f_10874_95231_95246<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 95231, 95246);
                    return return_v;
                }


                int
                f_10874_95213_95251<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 95213, 95251);
                    return 0;
                }


                bool
                f_10874_95291_95314<TMember>(TMember
                member) where TMember : Symbol

                {
                    var return_v = member.GetIsVararg();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 95291, 95314);
                    return return_v;
                }


                bool
                f_10874_95318_95341<TMember>(TMember
                member) where TMember : Symbol

                {
                    var return_v = member.GetIsVararg();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 95318, 95341);
                    return return_v;
                }


                int
                f_10874_95278_95342<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 95278, 95342);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10874_95442_95497<TMember>(int
                argIndex, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters) where TMember : Symbol

                {
                    var return_v = GetParameter(argIndex, result, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 95442, 95497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_95532_95571<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result) where TMember : Symbol

                {
                    var return_v = this_param.GetParameterType(parameter, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 95532, 95571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10874_95613_95668<TMember>(int
                argIndex, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters) where TMember : Symbol

                {
                    var return_v = GetParameter(argIndex, result, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 95613, 95668);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_95703_95742<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result) where TMember : Symbol

                {
                    var return_v = this_param.GetParameterType(parameter, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 95703, 95742);
                    return return_v;
                }


                bool
                f_10874_95871_95899_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 95871, 95899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10874_95992_96003<TMember>() where TMember : Symbol

                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 95992, 96003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_95967_96004<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation) where TMember : Symbol

                {
                    var return_v = type.NormalizeTaskTypes(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 95967, 96004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10874_96074_96085<TMember>() where TMember : Symbol

                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 96074, 96085);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_96049_96086<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation) where TMember : Symbol

                {
                    var return_v = type.NormalizeTaskTypes(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 96049, 96086);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10874_96138_96149<TMember>() where TMember : Symbol

                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 96138, 96149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10874_96138_96242<TMember>(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = this_param.ClassifyImplicitConversionFromType(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 96138, 96242);
                    return return_v;
                }


                int
                f_10874_98373_98450<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 98373, 98450);
                    return 0;
                }


                int
                f_10874_98829_98844<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 98829, 98844);
                    return return_v;
                }


                int
                f_10874_99022_99037<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 99022, 99037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10874_99182_99284<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                m1, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters1, Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                m2, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters2) where TMember : Symbol

                {
                    var return_v = PreferValOverInParameters(arguments, m1, parameters1, m2, parameters2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 99182, 99284);
                    return return_v;
                }


                int
                f_10874_99421_99447<TMember>(TMember
                symbol) where TMember : Symbol

                {
                    var return_v = symbol.GetMemberArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 99421, 99447);
                    return return_v;
                }


                int
                f_10874_99490_99516<TMember>(TMember
                symbol) where TMember : Symbol

                {
                    var return_v = symbol.GetMemberArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 99490, 99516);
                    return return_v;
                }


                int
                f_10874_99644_99670<TMember>(TMember
                symbol) where TMember : Symbol

                {
                    var return_v = symbol.GetMemberArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 99644, 99670);
                    return return_v;
                }


                int
                f_10874_101844_101859<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 101844, 101859);
                    return return_v;
                }


                int
                f_10874_101976_101991<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 101976, 101991);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10874_102858_102896<TMember>() where TMember : Symbol

                {
                    var return_v = ArrayBuilder<TypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 102858, 102896);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10874_102925_102963<TMember>() where TMember : Symbol

                {
                    var return_v = ArrayBuilder<TypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 102925, 102963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10874_102995_103038<TMember>(TMember
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 102995, 103038);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10874_102995_103054<TMember>(Microsoft.CodeAnalysis.CSharp.Symbol
                member) where TMember : Symbol

                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 102995, 103054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10874_103086_103129<TMember>(TMember
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 103086, 103129);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10874_103086_103145<TMember>(Microsoft.CodeAnalysis.CSharp.Symbol
                member) where TMember : Symbol

                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 103086, 103145);
                    return return_v;
                }


                int
                f_10874_103176_103191<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 103176, 103191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10874_103432_103444<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 103432, 103444);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10874_103432_103449<TMember>(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 103432, 103449);
                    return return_v;
                }


                int
                f_10874_103538_103553<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 103538, 103553);
                    return return_v;
                }


                int
                f_10874_103520_103558<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 103520, 103558);
                    return 0;
                }


                bool
                f_10874_103594_103617<TMember>(TMember
                member) where TMember : Symbol

                {
                    var return_v = member.GetIsVararg();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 103594, 103617);
                    return return_v;
                }


                bool
                f_10874_103621_103644<TMember>(TMember
                member) where TMember : Symbol

                {
                    var return_v = member.GetIsVararg();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 103621, 103644);
                    return return_v;
                }


                int
                f_10874_103581_103645<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 103581, 103645);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10874_103733_103771<TMember>(int
                argIndex, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters) where TMember : Symbol

                {
                    var return_v = GetParameter(argIndex, result, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 103733, 103771);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_103802_103841<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result) where TMember : Symbol

                {
                    var return_v = this_param.GetParameterType(parameter, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 103802, 103841);
                    return return_v;
                }


                int
                f_10874_103790_103842<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                item) where TMember : Symbol

                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 103790, 103842);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10874_103880_103918<TMember>(int
                argIndex, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters) where TMember : Symbol

                {
                    var return_v = GetParameter(argIndex, result, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 103880, 103918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_103949_103988<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result) where TMember : Symbol

                {
                    var return_v = this_param.GetParameterType(parameter, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 103949, 103988);
                    return return_v;
                }


                int
                f_10874_103937_103989<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                item) where TMember : Symbol

                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 103937, 103989);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10874_104030_104088<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                t1, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                t2, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = MoreSpecificType(t1, t2, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 104030, 104088);
                    return return_v;
                }


                int
                f_10874_104103_104117<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param) where TMember : Symbol

                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 104103, 104117);
                    return 0;
                }


                int
                f_10874_104132_104146<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param) where TMember : Symbol

                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 104132, 104146);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10874_104533_104557<TMember>(TMember
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 104533, 104557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10874_104533_104566<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 104533, 104566);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10874_104593_104617<TMember>(TMember
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 104593, 104617);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10874_104593_104626<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 104593, 104626);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10874_104764_104794<TMember>(TMember
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 104764, 104794);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10874_104832_104862<TMember>(TMember
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 104832, 104862);
                    return return_v;
                }


                int
                f_10874_104901_104938<TMember>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.GetSubmissionSlotIndex();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 104901, 104938);
                    return return_v;
                }


                int
                f_10874_104977_105014<TMember>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.GetSubmissionSlotIndex();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 104977, 105014);
                    return return_v;
                }


                int
                f_10874_105424_105470<TMember>(TMember
                m) where TMember : Symbol

                {
                    var return_v = m.CustomModifierCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 105424, 105470);
                    return return_v;
                }


                int
                f_10874_105507_105553<TMember>(TMember
                m) where TMember : Symbol

                {
                    var return_v = m.CustomModifierCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 105507, 105553);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10874_105848_105950<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                m1, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters1, Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                m2, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters2) where TMember : Symbol

                {
                    var return_v = PreferValOverInParameters(arguments, m1, parameters1, m2, parameters2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 105848, 105950);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 84973, 105962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 84973, 105962);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BetterResult PreferValOverInParameters<TMember>(
                    ArrayBuilder<BoundExpression> arguments,
                    MemberResolutionResult<TMember> m1,
                    ImmutableArray<ParameterSymbol> parameters1,
                    MemberResolutionResult<TMember> m2,
                    ImmutableArray<ParameterSymbol> parameters2)
                    where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 105974, 107749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 106366, 106422);

                BetterResult
                valOverInPreference = BetterResult.Neither
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 106447, 106452);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 106438, 107695) || true) && (i < f_10874_106458_106473<TMember>(arguments))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 106475, 106478)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 106438, 107695))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 106438, 107695);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 106512, 107680) || true) && (f_10874_106516_106533<TMember>(f_10874_106516_106528<TMember>(arguments, i)) != BoundKind.ArgListOperator)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 106512, 107680);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 106604, 106653);

                            var
                            p1 = f_10874_106613_106652<TMember>(i, m1.Result, parameters1)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 106675, 106724);

                            var
                            p2 = f_10874_106684_106723<TMember>(i, m2.Result, parameters2)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 106748, 107661) || true) && (f_10874_106752_106762<TMember>(p1) == RefKind.None && (DynAbs.Tracing.TraceSender.Expression_True(10874, 106752, 106806) && f_10874_106782_106792<TMember>(p2) == RefKind.In))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 106748, 107661);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 106856, 107168) || true) && (valOverInPreference == BetterResult.Right)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 106856, 107168);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 106959, 106987);

                                    return BetterResult.Neither;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 106856, 107168);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 106856, 107168);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 107101, 107141);

                                    valOverInPreference = BetterResult.Left;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 106856, 107168);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 106748, 107661);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 106748, 107661);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 107218, 107661) || true) && (f_10874_107222_107232<TMember>(p2) == RefKind.None && (DynAbs.Tracing.TraceSender.Expression_True(10874, 107222, 107276) && f_10874_107252_107262<TMember>(p1) == RefKind.In))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 107218, 107661);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 107326, 107638) || true) && (valOverInPreference == BetterResult.Left)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 107326, 107638);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 107428, 107456);

                                        return BetterResult.Neither;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 107326, 107638);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 107326, 107638);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 107570, 107611);

                                        valOverInPreference = BetterResult.Right;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 107326, 107638);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 107218, 107661);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 106748, 107661);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 106512, 107680);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 1258);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 1258);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 107711, 107738);

                return valOverInPreference;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 105974, 107749);

                int
                f_10874_106458_106473<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 106458, 106473);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10874_106516_106528<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 106516, 106528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10874_106516_106533<TMember>(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 106516, 106533);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10874_106613_106652<TMember>(int
                argIndex, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters) where TMember : Symbol

                {
                    var return_v = GetParameter(argIndex, result, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 106613, 106652);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10874_106684_106723<TMember>(int
                argIndex, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters) where TMember : Symbol

                {
                    var return_v = GetParameter(argIndex, result, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 106684, 106723);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10874_106752_106762<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 106752, 106762);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10874_106782_106792<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 106782, 106792);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10874_107222_107232<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 107222, 107232);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10874_107252_107262<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 107252, 107262);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 105974, 107749);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 105974, 107749);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void GetParameterCounts<TMember>(MemberResolutionResult<TMember> m, ArrayBuilder<BoundExpression> arguments, out int declaredParameterCount, out int parametersUsedIncludingExpansionAndOptional) where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 107761, 109287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 108017, 108071);

                declaredParameterCount = f_10874_108042_108070<TMember>(m.Member);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 108087, 109276) || true) && (m.Result.Kind == MemberResolutionKind.ApplicableInExpandedForm)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 108087, 109276);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 108187, 109126) || true) && (f_10874_108191_108206<TMember>(arguments) < declaredParameterCount)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 108187, 109126);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 108273, 108336);

                        ImmutableArray<int>
                        argsToParamsOpt = m.Result.ArgsToParamsOpt
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 108360, 108963) || true) && (argsToParamsOpt.IsDefaultOrEmpty || (DynAbs.Tracing.TraceSender.Expression_False(10874, 108364, 108453) || !argsToParamsOpt.Contains(declaredParameterCount - 1)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 108360, 108963);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 108627, 108700);

                            parametersUsedIncludingExpansionAndOptional = declaredParameterCount - 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 108360, 108963);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 108360, 108963);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 108871, 108940);

                            parametersUsedIncludingExpansionAndOptional = declaredParameterCount;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 108360, 108963);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 108187, 109126);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 108187, 109126);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 109045, 109107);

                        parametersUsedIncludingExpansionAndOptional = f_10874_109091_109106<TMember>(arguments);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 108187, 109126);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 108087, 109276);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 108087, 109276);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 109192, 109261);

                    parametersUsedIncludingExpansionAndOptional = declaredParameterCount;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 108087, 109276);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 107761, 109287);

                int
                f_10874_108042_108070<TMember>(TMember
                member) where TMember : Symbol

                {
                    var return_v = member.GetParameterCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 108042, 108070);
                    return return_v;
                }


                int
                f_10874_108191_108206<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 108191, 108206);
                    return return_v;
                }


                int
                f_10874_109091_109106<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 109091, 109106);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 107761, 109287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 107761, 109287);
            }
        }

        private static BetterResult MoreSpecificType(ArrayBuilder<TypeSymbol> t1, ArrayBuilder<TypeSymbol> t2, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 109299, 110625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 109474, 109509);

                f_10874_109474_109508(f_10874_109487_109495(t1) == f_10874_109499_109507(t2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 109678, 109712);

                var
                result = BetterResult.Neither
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 109735, 109740);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 109726, 110584) || true) && (i < f_10874_109746_109754(t1))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 109756, 109759)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 109726, 110584))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 109726, 110584);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 109793, 109856);

                        var
                        r = f_10874_109801_109855(f_10874_109818_109823(t1, i), f_10874_109825_109830(t2, i), ref useSiteDiagnostics)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 109874, 110569) || true) && (r == BetterResult.Neither)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 109874, 110569);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 109874, 110569);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 109874, 110569);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 110021, 110569) || true) && (result == BetterResult.Neither)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 110021, 110569);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 110245, 110256);

                                result = r;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 110021, 110569);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 110021, 110569);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 110298, 110569) || true) && (result != r)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 110298, 110569);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 110522, 110550);

                                    return BetterResult.Neither;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 110298, 110569);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 110021, 110569);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 109874, 110569);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 859);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 859);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 110600, 110614);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 109299, 110625);

                int
                f_10874_109487_109495(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 109487, 109495);
                    return return_v;
                }


                int
                f_10874_109499_109507(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 109499, 109507);
                    return return_v;
                }


                int
                f_10874_109474_109508(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 109474, 109508);
                    return 0;
                }


                int
                f_10874_109746_109754(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 109746, 109754);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_109818_109823(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 109818, 109823);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_109825_109830(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 109825, 109830);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10874_109801_109855(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = MoreSpecificType(t1, t2, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 109801, 109855);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 109299, 110625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 109299, 110625);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BetterResult MoreSpecificType(TypeSymbol t1, TypeSymbol t2, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 110637, 114315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 110896, 110941);

                var
                t1IsTypeParameter = f_10874_110920_110940(t1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 110955, 111000);

                var
                t2IsTypeParameter = f_10874_110979_110999(t2)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 111016, 111134) || true) && (t1IsTypeParameter && (DynAbs.Tracing.TraceSender.Expression_True(10874, 111020, 111059) && !t2IsTypeParameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 111016, 111134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 111093, 111119);

                    return BetterResult.Right;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 111016, 111134);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 111150, 111267) || true) && (!t1IsTypeParameter && (DynAbs.Tracing.TraceSender.Expression_True(10874, 111154, 111193) && t2IsTypeParameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 111150, 111267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 111227, 111252);

                    return BetterResult.Left;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 111150, 111267);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 111283, 111402) || true) && (t1IsTypeParameter && (DynAbs.Tracing.TraceSender.Expression_True(10874, 111287, 111325) && t2IsTypeParameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 111283, 111402);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 111359, 111387);

                    return BetterResult.Neither;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 111283, 111402);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 111658, 112100) || true) && (f_10874_111662_111674(t1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 111658, 112100);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 111708, 111739);

                    var
                    arr1 = (ArrayTypeSymbol)t1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 111757, 111788);

                    var
                    arr2 = (ArrayTypeSymbol)t2
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 111941, 111981);

                    f_10874_111941_111980(f_10874_111954_111979(arr1, arr2));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 112001, 112085);

                    return f_10874_112008_112084(f_10874_112025_112041(arr1), f_10874_112043_112059(arr2), ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 111658, 112100);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 112192, 112458) || true) && (f_10874_112196_112207(t1) == TypeKind.Pointer)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 112192, 112458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 112261, 112292);

                    var
                    p1 = (PointerTypeSymbol)t1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 112310, 112341);

                    var
                    p2 = (PointerTypeSymbol)t2
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 112359, 112443);

                    return f_10874_112366_112442(f_10874_112383_112399(p1), f_10874_112401_112417(p2), ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 112192, 112458);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 112474, 112844) || true) && (f_10874_112478_112492(t1) || (DynAbs.Tracing.TraceSender.Expression_False(10874, 112478, 112510) || f_10874_112496_112510(t2)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 112474, 112844);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 112544, 112781);

                    f_10874_112544_112780(f_10874_112557_112571(t1) && (DynAbs.Tracing.TraceSender.Expression_True(10874, 112557, 112589) && f_10874_112575_112589(t2)) || (DynAbs.Tracing.TraceSender.Expression_False(10874, 112557, 112684) || f_10874_112623_112637(t1) && (DynAbs.Tracing.TraceSender.Expression_True(10874, 112623, 112684) && f_10874_112641_112655(t2) == SpecialType.System_Object)) || (DynAbs.Tracing.TraceSender.Expression_False(10874, 112557, 112779) || f_10874_112718_112732(t2) && (DynAbs.Tracing.TraceSender.Expression_True(10874, 112718, 112779) && f_10874_112736_112750(t1) == SpecialType.System_Object)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 112801, 112829);

                    return BetterResult.Neither;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 112474, 112844);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 113200, 113231);

                var
                n1 = t1 as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 113245, 113276);

                var
                n2 = t2 as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 113290, 113349);

                f_10874_113290_113348(((object)n1 == null) == ((object)n2 == null));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 113365, 113464) || true) && ((object)n1 == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 113365, 113464);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 113421, 113449);

                    return BetterResult.Neither;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 113365, 113464);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 113828, 113886);

                var
                allTypeArgs1 = f_10874_113847_113885()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 113900, 113958);

                var
                allTypeArgs2 = f_10874_113919_113957()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 113972, 114033);

                f_10874_113972_114032(n1, allTypeArgs1, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 114047, 114108);

                f_10874_114047_114107(n2, allTypeArgs2, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 114124, 114206);

                var
                result = f_10874_114137_114205(allTypeArgs1, allTypeArgs2, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 114222, 114242);

                f_10874_114222_114241(
                            allTypeArgs1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 114256, 114276);

                f_10874_114256_114275(allTypeArgs2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 114290, 114304);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 110637, 114315);

                bool
                f_10874_110920_110940(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 110920, 110940);
                    return return_v;
                }


                bool
                f_10874_110979_110999(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 110979, 110999);
                    return return_v;
                }


                bool
                f_10874_111662_111674(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 111662, 111674);
                    return return_v;
                }


                bool
                f_10874_111954_111979(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                other)
                {
                    var return_v = this_param.HasSameShapeAs(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 111954, 111979);
                    return return_v;
                }


                int
                f_10874_111941_111980(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 111941, 111980);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_112025_112041(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 112025, 112041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_112043_112059(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 112043, 112059);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10874_112008_112084(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = MoreSpecificType(t1, t2, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 112008, 112084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10874_112196_112207(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 112196, 112207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_112383_112399(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 112383, 112399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_112401_112417(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 112401, 112417);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10874_112366_112442(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = MoreSpecificType(t1, t2, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 112366, 112442);
                    return return_v;
                }


                bool
                f_10874_112478_112492(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 112478, 112492);
                    return return_v;
                }


                bool
                f_10874_112496_112510(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 112496, 112510);
                    return return_v;
                }


                bool
                f_10874_112557_112571(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 112557, 112571);
                    return return_v;
                }


                bool
                f_10874_112575_112589(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 112575, 112589);
                    return return_v;
                }


                bool
                f_10874_112623_112637(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 112623, 112637);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10874_112641_112655(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 112641, 112655);
                    return return_v;
                }


                bool
                f_10874_112718_112732(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 112718, 112732);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10874_112736_112750(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 112736, 112750);
                    return return_v;
                }


                int
                f_10874_112544_112780(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 112544, 112780);
                    return 0;
                }


                int
                f_10874_113290_113348(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 113290, 113348);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10874_113847_113885()
                {
                    var return_v = ArrayBuilder<TypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 113847, 113885);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10874_113919_113957()
                {
                    var return_v = ArrayBuilder<TypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 113919, 113957);
                    return return_v;
                }


                int
                f_10874_113972_114032(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                builder, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.GetAllTypeArguments(builder, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 113972, 114032);
                    return 0;
                }


                int
                f_10874_114047_114107(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                builder, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.GetAllTypeArguments(builder, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 114047, 114107);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10874_114137_114205(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                t1, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                t2, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = MoreSpecificType(t1, t2, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 114137, 114205);
                    return return_v;
                }


                int
                f_10874_114222_114241(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 114222, 114241);
                    return 0;
                }


                int
                f_10874_114256_114275(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 114256, 114275);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 110637, 114315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 110637, 114315);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BetterResult BetterConversionFromExpression(BoundExpression node, TypeSymbol t1, TypeSymbol t2, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 114407, 115069);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 114583, 114634);

                f_10874_114583_114633(f_10874_114596_114605(node) != BoundKind.UnboundLambda);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 114648, 114660);

                bool
                ignore
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 114674, 115058);

                return f_10874_114681_115057(this, node, t1, f_10874_114774_114860(f_10874_114774_114785(), node, t1, ref useSiteDiagnostics), t2, f_10874_114900_114986(f_10874_114900_114911(), node, t2, ref useSiteDiagnostics), ref useSiteDiagnostics, out ignore);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 114407, 115069);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10874_114596_114605(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 114596, 114605);
                    return return_v;
                }


                int
                f_10874_114583_114633(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 114583, 114633);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10874_114774_114785()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 114774, 114785);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10874_114774_114860(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 114774, 114860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10874_114900_114911()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 114900, 114911);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10874_114900_114986(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 114900, 114986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10874_114681_115057(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t1, Microsoft.CodeAnalysis.CSharp.Conversion
                conv1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.CSharp.Conversion
                conv2, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, out bool
                okToDowngradeToNeither)
                {
                    var return_v = this_param.BetterConversionFromExpression(node, t1, conv1, t2, conv2, ref useSiteDiagnostics, out okToDowngradeToNeither);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 114681, 115057);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 114407, 115069);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 114407, 115069);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BetterResult BetterConversionFromExpression(
                    BoundExpression node,
                    TypeSymbol t1,
                    Conversion conv1,
                    RefKind refKind1,
                    TypeSymbol t2,
                    Conversion conv2,
                    RefKind refKind2,
                    bool considerRefKinds,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                    out bool okToDowngradeToNeither)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 115203, 118610);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 115638, 115669);

                okToDowngradeToNeither = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 115685, 118465) || true) && (considerRefKinds)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 115685, 118465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 117680, 117746);

                    f_10874_117680_117745(refKind1 == RefKind.None || (DynAbs.Tracing.TraceSender.Expression_False(10874, 117693, 117744) || refKind1 == RefKind.Ref));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 117764, 117830);

                    f_10874_117764_117829(refKind2 == RefKind.None || (DynAbs.Tracing.TraceSender.Expression_False(10874, 117777, 117828) || refKind2 == RefKind.Ref));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 117850, 118450) || true) && (refKind1 != refKind2)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 117850, 118450);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 117916, 118292) || true) && (refKind1 == RefKind.None)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 117916, 118292);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 117994, 118082);

                            return (DynAbs.Tracing.TraceSender.Conditional_F1(10874, 118001, 118038) || ((conv1.Kind == ConversionKind.Identity && DynAbs.Tracing.TraceSender.Conditional_F2(10874, 118041, 118058)) || DynAbs.Tracing.TraceSender.Conditional_F3(10874, 118061, 118081))) ? BetterResult.Left : BetterResult.Neither;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 117916, 118292);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 117916, 118292);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 118180, 118269);

                            return (DynAbs.Tracing.TraceSender.Conditional_F1(10874, 118187, 118224) || ((conv2.Kind == ConversionKind.Identity && DynAbs.Tracing.TraceSender.Conditional_F2(10874, 118227, 118245)) || DynAbs.Tracing.TraceSender.Conditional_F3(10874, 118248, 118268))) ? BetterResult.Right : BetterResult.Neither;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 117916, 118292);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 117850, 118450);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 117850, 118450);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 118334, 118450) || true) && (refKind1 == RefKind.Ref)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 118334, 118450);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 118403, 118431);

                            return BetterResult.Neither;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 118334, 118450);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 117850, 118450);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 115685, 118465);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 118481, 118599);

                return f_10874_118488_118598(this, node, t1, conv1, t2, conv2, ref useSiteDiagnostics, out okToDowngradeToNeither);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 115203, 118610);

                int
                f_10874_117680_117745(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 117680, 117745);
                    return 0;
                }


                int
                f_10874_117764_117829(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 117764, 117829);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10874_118488_118598(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t1, Microsoft.CodeAnalysis.CSharp.Conversion
                conv1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.CSharp.Conversion
                conv2, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, out bool
                okToDowngradeToNeither)
                {
                    var return_v = this_param.BetterConversionFromExpression(node, t1, conv1, t2, conv2, ref useSiteDiagnostics, out okToDowngradeToNeither);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 118488, 118598);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 115203, 118610);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 115203, 118610);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BetterResult BetterConversionFromExpression(BoundExpression node, TypeSymbol t1, Conversion conv1, TypeSymbol t2, Conversion conv2, ref HashSet<DiagnosticInfo> useSiteDiagnostics, out bool okToDowngradeToNeither)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 118702, 121658);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 118947, 118978);

                okToDowngradeToNeither = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 118994, 119172) || true) && (f_10874_118998_119039(t1, t2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 118994, 119172);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 119129, 119157);

                    return BetterResult.Neither;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 118994, 119172);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 119188, 119226);

                var
                lambdaOpt = node as UnboundLambda
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 119242, 119267);

                var
                nodeKind = f_10874_119257_119266(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 119281, 119759) || true) && (nodeKind == BoundKind.OutVariablePendingInference || (DynAbs.Tracing.TraceSender.Expression_False(10874, 119285, 119410) || nodeKind == BoundKind.OutDeconstructVarPendingInference) || (DynAbs.Tracing.TraceSender.Expression_False(10874, 119285, 119501) || (nodeKind == BoundKind.DiscardExpression && (DynAbs.Tracing.TraceSender.Expression_True(10874, 119432, 119500) && !f_10874_119476_119500(node)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 119281, 119759);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 119667, 119698);

                    okToDowngradeToNeither = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 119716, 119744);

                    return BetterResult.Neither;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 119281, 119759);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 120081, 120162);

                bool
                t1MatchesExactly = f_10874_120105_120161(this, node, t1, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 120176, 120257);

                bool
                t2MatchesExactly = f_10874_120200_120256(this, node, t2, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 120273, 120965) || true) && (t1MatchesExactly)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 120273, 120965);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 120327, 120660) || true) && (!t2MatchesExactly)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 120327, 120660);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 120437, 120594);

                        okToDowngradeToNeither = lambdaOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(10874, 120462, 120593) && f_10874_120483_120593(this, BetterResult.Left, lambdaOpt, t1, t2, ref useSiteDiagnostics, false));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 120616, 120641);

                        return BetterResult.Left;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 120327, 120660);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 120273, 120965);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 120273, 120965);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 120694, 120965) || true) && (t2MatchesExactly)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 120694, 120965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 120748, 120906);

                        okToDowngradeToNeither = lambdaOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(10874, 120773, 120905) && f_10874_120794_120905(this, BetterResult.Right, lambdaOpt, t1, t2, ref useSiteDiagnostics, false));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 120924, 120950);

                        return BetterResult.Right;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 120694, 120965);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 120273, 120965);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 121091, 121202) || true) && (f_10874_121095_121125_M(!conv1.IsConditionalExpression) && (DynAbs.Tracing.TraceSender.Expression_True(10874, 121095, 121158) && conv2.IsConditionalExpression))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 121091, 121202);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 121177, 121202);

                    return BetterResult.Left;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 121091, 121202);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 121216, 121328) || true) && (f_10874_121220_121250_M(!conv2.IsConditionalExpression) && (DynAbs.Tracing.TraceSender.Expression_True(10874, 121220, 121283) && conv1.IsConditionalExpression))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 121216, 121328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 121302, 121328);

                    return BetterResult.Right;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 121216, 121328);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 121537, 121647);

                return f_10874_121544_121646(this, node, t1, conv1, t2, conv2, ref useSiteDiagnostics, out okToDowngradeToNeither);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 118702, 121658);

                bool
                f_10874_118998_119039(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = Conversions.HasIdentityConversion(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 118998, 119039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10874_119257_119266(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 119257, 119266);
                    return return_v;
                }


                bool
                f_10874_119476_119500(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.HasExpressionType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 119476, 119500);
                    return return_v;
                }


                bool
                f_10874_120105_120161(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ExpressionMatchExactly(node, t, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 120105, 120161);
                    return return_v;
                }


                bool
                f_10874_120200_120256(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ExpressionMatchExactly(node, t, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 120200, 120256);
                    return return_v;
                }


                bool
                f_10874_120483_120593(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BetterResult
                currentResult, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                lambda, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                fromTypeAnalysis)
                {
                    var return_v = this_param.CanDowngradeConversionFromLambdaToNeither(currentResult, lambda, type1, type2, ref useSiteDiagnostics, fromTypeAnalysis);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 120483, 120593);
                    return return_v;
                }


                bool
                f_10874_120794_120905(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BetterResult
                currentResult, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                lambda, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                fromTypeAnalysis)
                {
                    var return_v = this_param.CanDowngradeConversionFromLambdaToNeither(currentResult, lambda, type1, type2, ref useSiteDiagnostics, fromTypeAnalysis);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 120794, 120905);
                    return return_v;
                }


                bool
                f_10874_121095_121125_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 121095, 121125);
                    return return_v;
                }


                bool
                f_10874_121220_121250_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 121220, 121250);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10874_121544_121646(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Conversion
                conv1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2, Microsoft.CodeAnalysis.CSharp.Conversion
                conv2, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, out bool
                okToDowngradeToNeither)
                {
                    var return_v = this_param.BetterConversionTarget(node, type1, conv1, type2, conv2, ref useSiteDiagnostics, out okToDowngradeToNeither);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 121544, 121646);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 118702, 121658);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 118702, 121658);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ExpressionMatchExactly(BoundExpression node, TypeSymbol t, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            // Given an expression E and a type T, E exactly matches T if one of the following holds:

            // - E has a type S, and an identity conversion exists from S to T 
            if ((object)node.Type != null && Conversions.HasIdentityConversion(node.Type, t))
            {
                return true;
            }

            if (node.Kind == BoundKind.TupleLiteral)
            {
                // Recurse into tuple constituent arguments.
                // Even if the tuple literal has a natural type and conversion 
                // from that type is not identity, we still have to do this 
                // because we might be converting to a tuple type backed by
                // different definition of ValueTuple type.
                return ExpressionMatchExactly((BoundTupleLiteral)node, t, ref useSiteDiagnostics);
            }

            // - E is an anonymous function, T is either a delegate type D or an expression tree 
            //   type Expression<D>, D has a return type Y, and one of the following holds:
            NamedTypeSymbol d;
            MethodSymbol invoke;
            TypeSymbol y;

            if (node.Kind == BoundKind.UnboundLambda &&
                (object)(d = t.GetDelegateType()) != null &&
                (object)(invoke = d.DelegateInvokeMethod) != null &&
                !(y = invoke.ReturnType).IsVoidType())
            {
                BoundLambda lambda = ((UnboundLambda)node).BindForReturnTypeInference(d);

                // - an inferred return type X exists for E in the context of the parameter list of D(§7.5.2.12), and an identity conversion exists from X to Y
                var x = lambda.GetInferredReturnType(ref useSiteDiagnostics);
                if (x.HasType && Conversions.HasIdentityConversion(x.Type, y))
                {
                    return true;
                }

                if (lambda.Symbol.IsAsync)
                {
                    // Dig through Task<...> for an async lambda.
                    if (y.OriginalDefinition.IsGenericTaskType(Compilation))
                    {
                        y = ((NamedTypeSymbol)y).TypeArgumentsWithAnnotationsNoUseSiteDiagnostics[0].Type;
                    }
                    else
                    {
                        y = null;
                    }
                }

                if ((object)y != null)
                {
                    // - The body of E is an expression that exactly matches Y, or
                    //   has a return statement with expression and all return statements have expression that 
                    //   exactly matches Y.

                    // Handle trivial cases first
                    switch (lambda.Body.Statements.Length)
                    {
                        case 0:
                            break;

                        case 1:
                            if (lambda.Body.Statements[0].Kind == BoundKind.ReturnStatement)
                            {
                                var returnStmt = (BoundReturnStatement)lambda.Body.Statements[0];
                                if (returnStmt.ExpressionOpt != null && ExpressionMatchExactly(returnStmt.ExpressionOpt, y, ref useSiteDiagnostics))
                                {
                                    return true;
                                }
                            }
                            else
                            {
                                goto default;
                            }

                            break;

                        default:
                            var returnStatements = ArrayBuilder<BoundReturnStatement>.GetInstance();
                            var walker = new ReturnStatements(returnStatements);

                            walker.Visit(lambda.Body);

                            bool result = false;
                            foreach (BoundReturnStatement r in returnStatements)
                            {
                                if (r.ExpressionOpt == null || !ExpressionMatchExactly(r.ExpressionOpt, y, ref useSiteDiagnostics))
                                {
                                    result = false;
                                    break;
                                }
                                else
                                {
                                    result = true;
                                }
                            }

                            returnStatements.Free();

                            if (result)
                            {
                                return true;
                            }
                            break;
                    }
                }
            }

            return false;
        }

        private bool ExpressionMatchExactly(BoundTupleLiteral tupleSource, TypeSymbol targetType, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 126837, 128030);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 126999, 127209) || true) && (f_10874_127003_127018(targetType) != SymbolKind.NamedType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 126999, 127209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 127181, 127194);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 126999, 127209);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 127225, 127271);

                var
                destination = (NamedTypeSymbol)targetType
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 127285, 127329);

                var
                sourceArguments = f_10874_127307_127328(tupleSource)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 127440, 127567) || true) && (!f_10874_127445_127505(destination, sourceArguments.Length))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 127440, 127567);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 127539, 127552);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 127440, 127567);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 127583, 127644);

                var
                destTypes = f_10874_127599_127643(destination)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 127658, 127715);

                f_10874_127658_127714(sourceArguments.Length == destTypes.Length);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 127740, 127745);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 127731, 127991) || true) && (i < sourceArguments.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 127775, 127778)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 127731, 127991))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 127731, 127991);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 127812, 127976) || true) && (!f_10874_127817_127902(this, sourceArguments[i], destTypes[i].Type, ref useSiteDiagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 127812, 127976);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 127944, 127957);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 127812, 127976);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 261);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 261);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 128007, 128019);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 126837, 128030);

                Microsoft.CodeAnalysis.SymbolKind
                f_10874_127003_127018(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 127003, 127018);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10874_127307_127328(Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 127307, 127328);
                    return return_v;
                }


                bool
                f_10874_127445_127505(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, int
                targetCardinality)
                {
                    var return_v = this_param.IsTupleTypeOfCardinality(targetCardinality);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 127445, 127505);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10874_127599_127643(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElementTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 127599, 127643);
                    return return_v;
                }


                int
                f_10874_127658_127714(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 127658, 127714);
                    return 0;
                }


                bool
                f_10874_127817_127902(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ExpressionMatchExactly(node, t, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 127817, 127902);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 126837, 128030);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 126837, 128030);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private class ReturnStatements : BoundTreeWalker
        {
            private readonly ArrayBuilder<BoundReturnStatement> _returns;

            public ReturnStatements(ArrayBuilder<BoundReturnStatement> returns)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10874, 128192, 128326);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 128167, 128175);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 128292, 128311);

                    _returns = returns;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10874, 128192, 128326);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 128192, 128326);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 128192, 128326);
                }
            }

            public override BoundNode Visit(BoundNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 128342, 128584);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 128422, 128537) || true) && (!(node is BoundExpression))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 128422, 128537);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 128494, 128518);

                        return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 10874, 128501, 128517);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 128422, 128537);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 128557, 128569);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 128342, 128584);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 128342, 128584);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 128342, 128584);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override BoundExpression VisitExpressionWithoutStackGuard(BoundExpression node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 128600, 128774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 128722, 128759);

                    throw f_10874_128728_128758();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 128600, 128774);

                    System.Exception
                    f_10874_128728_128758()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 128728, 128758);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 128600, 128774);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 128600, 128774);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode VisitLocalFunctionStatement(BoundLocalFunctionStatement node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 128790, 129030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 129003, 129015);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 128790, 129030);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 128790, 129030);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 128790, 129030);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode VisitReturnStatement(BoundReturnStatement node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 129046, 129216);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 129152, 129171);

                    f_10874_129152_129170(_returns, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 129189, 129201);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 129046, 129216);

                    int
                    f_10874_129152_129170(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundReturnStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 129152, 129170);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 129046, 129216);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 129046, 129216);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ReturnStatements()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10874, 128042, 129227);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10874, 128042, 129227);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 128042, 129227);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10874, 128042, 129227);
        }

        private const int
        BetterConversionTargetRecursionLimit = 100
        ;

        private BetterResult BetterConversionTarget(
                    TypeSymbol type1,
                    TypeSymbol type2,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 129312, 129743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 129504, 129532);

                bool
                okToDowngradeToNeither
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 129546, 129732);

                return f_10874_129553_129731(this, null, type1, default(Conversion), type2, default(Conversion), ref useSiteDiagnostics, out okToDowngradeToNeither, BetterConversionTargetRecursionLimit);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 129312, 129743);

                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10874_129553_129731(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Conversion
                conv1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2, Microsoft.CodeAnalysis.CSharp.Conversion
                conv2, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, out bool
                okToDowngradeToNeither, int
                betterConversionTargetRecursionLimit)
                {
                    var return_v = this_param.BetterConversionTargetCore(node, type1, conv1, type2, conv2, ref useSiteDiagnostics, out okToDowngradeToNeither, betterConversionTargetRecursionLimit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 129553, 129731);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 129312, 129743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 129312, 129743);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BetterResult BetterConversionTargetCore(
                    TypeSymbol type1,
                    TypeSymbol type2,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                    int betterConversionTargetRecursionLimit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 129755, 130386);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 130006, 130127) || true) && (betterConversionTargetRecursionLimit < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 130006, 130127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 130084, 130112);

                    return BetterResult.Neither;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 130006, 130127);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 130143, 130171);

                bool
                okToDowngradeToNeither
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 130185, 130375);

                return f_10874_130192_130374(this, null, type1, default(Conversion), type2, default(Conversion), ref useSiteDiagnostics, out okToDowngradeToNeither, betterConversionTargetRecursionLimit - 1);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 129755, 130386);

                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10874_130192_130374(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Conversion
                conv1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2, Microsoft.CodeAnalysis.CSharp.Conversion
                conv2, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, out bool
                okToDowngradeToNeither, int
                betterConversionTargetRecursionLimit)
                {
                    var return_v = this_param.BetterConversionTargetCore(node, type1, conv1, type2, conv2, ref useSiteDiagnostics, out okToDowngradeToNeither, betterConversionTargetRecursionLimit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 130192, 130374);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 129755, 130386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 129755, 130386);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BetterResult BetterConversionTarget(
                    BoundExpression node,
                    TypeSymbol type1,
                    Conversion conv1,
                    TypeSymbol type2,
                    Conversion conv2,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                    out bool okToDowngradeToNeither)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 130398, 130902);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 130733, 130891);

                return f_10874_130740_130890(this, node, type1, conv1, type2, conv2, ref useSiteDiagnostics, out okToDowngradeToNeither, BetterConversionTargetRecursionLimit);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 130398, 130902);

                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10874_130740_130890(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Conversion
                conv1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2, Microsoft.CodeAnalysis.CSharp.Conversion
                conv2, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, out bool
                okToDowngradeToNeither, int
                betterConversionTargetRecursionLimit)
                {
                    var return_v = this_param.BetterConversionTargetCore(node, type1, conv1, type2, conv2, ref useSiteDiagnostics, out okToDowngradeToNeither, betterConversionTargetRecursionLimit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 130740, 130890);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 130398, 130902);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 130398, 130902);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BetterResult BetterConversionTargetCore(
                    BoundExpression node,
                    TypeSymbol type1,
                    Conversion conv1,
                    TypeSymbol type2,
                    Conversion conv2,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                    out bool okToDowngradeToNeither,
                    int betterConversionTargetRecursionLimit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 130914, 138442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 131308, 131339);

                okToDowngradeToNeither = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 131355, 131533) || true) && (f_10874_131359_131406(type1, type2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 131355, 131533);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 131490, 131518);

                    return BetterResult.Neither;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 131355, 131533);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 131748, 131864);

                bool
                type1ToType2 = f_10874_131768_131852(f_10874_131768_131779(), type1, type2, ref useSiteDiagnostics).IsImplicit
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 131878, 131994);

                bool
                type2ToType1 = f_10874_131898_131982(f_10874_131898_131909(), type2, type1, ref useSiteDiagnostics).IsImplicit
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 132008, 132056);

                UnboundLambda
                lambdaOpt = node as UnboundLambda
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 132072, 132948) || true) && (type1ToType2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 132072, 132948);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 132122, 132285) || true) && (type2ToType1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 132122, 132285);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 132238, 132266);

                        return BetterResult.Neither;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 132122, 132285);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 132371, 132533);

                    okToDowngradeToNeither = lambdaOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(10874, 132396, 132532) && f_10874_132417_132532(this, BetterResult.Left, lambdaOpt, type1, type2, ref useSiteDiagnostics, true));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 132551, 132576);

                    return BetterResult.Left;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 132072, 132948);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 132072, 132948);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 132610, 132948) || true) && (type2ToType1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 132610, 132948);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 132726, 132889);

                        okToDowngradeToNeither = lambdaOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(10874, 132751, 132888) && f_10874_132772_132888(this, BetterResult.Right, lambdaOpt, type1, type2, ref useSiteDiagnostics, true));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 132907, 132933);

                        return BetterResult.Right;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 132610, 132948);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 132072, 132948);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 132964, 133046);

                bool
                type1IsGenericTask = f_10874_132990_133045(f_10874_132990_133014(type1), f_10874_133033_133044())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 133060, 133142);

                bool
                type2IsGenericTask = f_10874_133086_133141(f_10874_133086_133110(type2), f_10874_133129_133140())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 133158, 134099) || true) && (type1IsGenericTask)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 133158, 134099);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 133214, 133772) || true) && (type2IsGenericTask)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 133214, 133772);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 133381, 133753);

                        return f_10874_133388_133752(this, f_10874_133415_133488(((NamedTypeSymbol)type1))[0].Type, f_10874_133553_133626(((NamedTypeSymbol)type2))[0].Type, ref useSiteDiagnostics, betterConversionTargetRecursionLimit);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 133214, 133772);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 133865, 133893);

                    return BetterResult.Neither;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 133158, 134099);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 133158, 134099);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 133927, 134099) || true) && (type2IsGenericTask)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 133927, 134099);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 134056, 134084);

                        return BetterResult.Neither;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 133927, 134099);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 133158, 134099);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 134115, 134134);

                NamedTypeSymbol
                d1
                = default(NamedTypeSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 134150, 137676) || true) && ((object)(d1 = f_10874_134168_134191(type1)) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 134150, 137676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 134234, 134253);

                    NamedTypeSymbol
                    d2
                    = default(NamedTypeSymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 134273, 137288) || true) && ((object)(d2 = f_10874_134291_134314(type2)) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 134273, 137288);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 134649, 134696);

                        MethodSymbol
                        invoke1 = f_10874_134672_134695(d1)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 134718, 134765);

                        MethodSymbol
                        invoke2 = f_10874_134741_134764(d2)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 134789, 137269) || true) && ((object)invoke1 != null && (DynAbs.Tracing.TraceSender.Expression_True(10874, 134793, 134843) && (object)invoke2 != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 134789, 137269);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 134893, 134928);

                            TypeSymbol
                            r1 = f_10874_134909_134927(invoke1)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 134954, 134989);

                            TypeSymbol
                            r2 = f_10874_134970_134988(invoke2)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 135015, 135066);

                            BetterResult
                            delegateResult = BetterResult.Neither
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 135094, 135636) || true) && (!f_10874_135099_135114(r1))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 135094, 135636);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 135172, 135382) || true) && (f_10874_135176_135191(r2))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 135172, 135382);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 135316, 135351);

                                    delegateResult = BetterResult.Left;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 135172, 135382);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 135094, 135636);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 135094, 135636);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 135440, 135636) || true) && (!f_10874_135445_135460(r2))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 135440, 135636);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 135573, 135609);

                                    delegateResult = BetterResult.Right;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 135440, 135636);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 135094, 135636);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 135664, 136010) || true) && (delegateResult == BetterResult.Neither)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 135664, 136010);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 135869, 135983);

                                delegateResult = f_10874_135886_135982(this, r1, r2, ref useSiteDiagnostics, betterConversionTargetRecursionLimit);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 135664, 136010);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 136394, 137196) || true) && (f_10874_136398_136408_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(node, 10874, 136398, 136408)?.Kind) == BoundKind.MethodGroup)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 136394, 137196);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 136491, 136526);

                                var
                                group = (BoundMethodGroup)node
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 136558, 137169) || true) && (delegateResult == BetterResult.Left)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 136558, 137169);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 136663, 136869) || true) && (f_10874_136667_136732(this, group, d1, conv1))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 136663, 136869);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 136806, 136834);

                                        return BetterResult.Neither;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 136663, 136869);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 136558, 137169);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 136558, 137169);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 136935, 137169) || true) && (delegateResult == BetterResult.Right && (DynAbs.Tracing.TraceSender.Expression_True(10874, 136939, 137044) && f_10874_136979_137044(this, group, d2, conv2)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 136935, 137169);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 137110, 137138);

                                        return BetterResult.Neither;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 136935, 137169);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 136558, 137169);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 136394, 137196);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 137224, 137246);

                            return delegateResult;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 134789, 137269);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 134273, 137288);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 137401, 137429);

                    return BetterResult.Neither;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 134150, 137676);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 134150, 137676);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 137463, 137676) || true) && ((object)f_10874_137475_137498(type2) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 137463, 137676);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 137633, 137661);

                        return BetterResult.Neither;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 137463, 137676);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 134150, 137676);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 138030, 138387) || true) && (f_10874_138034_138061(type1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 138030, 138387);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 138095, 138214) || true) && (f_10874_138099_138128(type2))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 138095, 138214);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 138170, 138195);

                        return BetterResult.Left;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 138095, 138214);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 138030, 138387);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 138030, 138387);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 138248, 138387) || true) && (f_10874_138252_138281(type1) && (DynAbs.Tracing.TraceSender.Expression_True(10874, 138252, 138312) && f_10874_138285_138312(type2)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 138248, 138387);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 138346, 138372);

                        return BetterResult.Right;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 138248, 138387);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 138030, 138387);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 138403, 138431);

                return BetterResult.Neither;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 130914, 138442);

                bool
                f_10874_131359_131406(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = Conversions.HasIdentityConversion(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 131359, 131406);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10874_131768_131779()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 131768, 131779);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10874_131768_131852(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitConversionFromType(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 131768, 131852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10874_131898_131909()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 131898, 131909);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10874_131898_131982(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitConversionFromType(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 131898, 131982);
                    return return_v;
                }


                bool
                f_10874_132417_132532(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BetterResult
                currentResult, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                lambda, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                fromTypeAnalysis)
                {
                    var return_v = this_param.CanDowngradeConversionFromLambdaToNeither(currentResult, lambda, type1, type2, ref useSiteDiagnostics, fromTypeAnalysis);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 132417, 132532);
                    return return_v;
                }


                bool
                f_10874_132772_132888(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BetterResult
                currentResult, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                lambda, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                fromTypeAnalysis)
                {
                    var return_v = this_param.CanDowngradeConversionFromLambdaToNeither(currentResult, lambda, type1, type2, ref useSiteDiagnostics, fromTypeAnalysis);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 132772, 132888);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_132990_133014(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 132990, 133014);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10874_133033_133044()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 133033, 133044);
                    return return_v;
                }


                bool
                f_10874_132990_133045(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = type.IsGenericTaskType(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 132990, 133045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_133086_133110(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 133086, 133110);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10874_133129_133140()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 133129, 133140);
                    return return_v;
                }


                bool
                f_10874_133086_133141(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = type.IsGenericTaskType(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 133086, 133141);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10874_133415_133488(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 133415, 133488);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10874_133553_133626(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 133553, 133626);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10874_133388_133752(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, int
                betterConversionTargetRecursionLimit)
                {
                    var return_v = this_param.BetterConversionTargetCore(type1, type2, ref useSiteDiagnostics, betterConversionTargetRecursionLimit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 133388, 133752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10874_134168_134191(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 134168, 134191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10874_134291_134314(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 134291, 134314);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10874_134672_134695(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 134672, 134695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10874_134741_134764(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 134741, 134764);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_134909_134927(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 134909, 134927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_134970_134988(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 134970, 134988);
                    return return_v;
                }


                bool
                f_10874_135099_135114(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 135099, 135114);
                    return return_v;
                }


                bool
                f_10874_135176_135191(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 135176, 135191);
                    return return_v;
                }


                bool
                f_10874_135445_135460(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 135445, 135460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10874_135886_135982(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, int
                betterConversionTargetRecursionLimit)
                {
                    var return_v = this_param.BetterConversionTargetCore(type1, type2, ref useSiteDiagnostics, betterConversionTargetRecursionLimit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 135886, 135982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind?
                f_10874_136398_136408_M(Microsoft.CodeAnalysis.CSharp.BoundKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 136398, 136408);
                    return return_v;
                }


                bool
                f_10874_136667_136732(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                node, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateType, Microsoft.CodeAnalysis.CSharp.Conversion
                conv)
                {
                    var return_v = this_param.IsMethodGroupConversionIncompatibleWithDelegate(node, delegateType, conv);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 136667, 136732);
                    return return_v;
                }


                bool
                f_10874_136979_137044(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                node, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateType, Microsoft.CodeAnalysis.CSharp.Conversion
                conv)
                {
                    var return_v = this_param.IsMethodGroupConversionIncompatibleWithDelegate(node, delegateType, conv);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 136979, 137044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10874_137475_137498(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 137475, 137498);
                    return return_v;
                }


                bool
                f_10874_138034_138061(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsSignedIntegralType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 138034, 138061);
                    return return_v;
                }


                bool
                f_10874_138099_138128(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsUnsignedIntegralType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 138099, 138128);
                    return return_v;
                }


                bool
                f_10874_138252_138281(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsUnsignedIntegralType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 138252, 138281);
                    return return_v;
                }


                bool
                f_10874_138285_138312(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsSignedIntegralType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 138285, 138312);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 130914, 138442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 130914, 138442);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsMethodGroupConversionIncompatibleWithDelegate(BoundMethodGroup node, NamedTypeSymbol delegateType, Conversion conv)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 138454, 139016);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 138609, 138976) || true) && (conv.IsMethodGroup)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 138609, 138976);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 138665, 138716);

                    DiagnosticBag
                    ignore = f_10874_138688_138715()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 138734, 138897);

                    bool
                    result = !f_10874_138749_138896(_binder, f_10874_138805_138821(node), conv.IsExtensionMethod, conv.Method, delegateType, f_10874_138874_138887(), ignore)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 138915, 138929);

                    f_10874_138915_138928(ignore);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 138947, 138961);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 138609, 138976);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 138992, 139005);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 138454, 139016);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10874_138688_138715()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 138688, 138715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10874_138805_138821(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 138805, 138821);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10874_138874_138887()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 138874, 138887);
                    return return_v;
                }


                bool
                f_10874_138749_138896(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, bool
                isExtensionMethod, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                method, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateType, Microsoft.CodeAnalysis.Location
                errorLocation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MethodIsCompatibleWithDelegateOrFunctionPointer(receiverOpt, isExtensionMethod, method, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)delegateType, errorLocation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 138749, 138896);
                    return return_v;
                }


                int
                f_10874_138915_138928(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 138915, 138928);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 138454, 139016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 138454, 139016);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CanDowngradeConversionFromLambdaToNeither(BetterResult currentResult, UnboundLambda lambda, TypeSymbol type1, TypeSymbol type2, ref HashSet<DiagnosticInfo> useSiteDiagnostics, bool fromTypeAnalysis)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 139028, 143387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 140028, 140047);

                NamedTypeSymbol
                d1
                = default(NamedTypeSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 140063, 143347) || true) && ((object)(d1 = f_10874_140081_140104(type1)) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 140063, 143347);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 140147, 140166);

                    NamedTypeSymbol
                    d2
                    = default(NamedTypeSymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 140186, 143332) || true) && ((object)(d2 = f_10874_140204_140227(type2)) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 140186, 143332);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 140278, 140325);

                        MethodSymbol
                        invoke1 = f_10874_140301_140324(d1)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 140347, 140394);

                        MethodSymbol
                        invoke2 = f_10874_140370_140393(d2)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 140418, 143313) || true) && ((object)invoke1 != null && (DynAbs.Tracing.TraceSender.Expression_True(10874, 140422, 140472) && (object)invoke2 != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 140418, 143313);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 140522, 140683) || true) && (!f_10874_140527_140586(f_10874_140547_140565(invoke1), f_10874_140567_140585(invoke2)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 140522, 140683);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 140644, 140656);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 140522, 140683);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 140711, 140746);

                            TypeSymbol
                            r1 = f_10874_140727_140745(invoke1)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 140772, 140807);

                            TypeSymbol
                            r2 = f_10874_140788_140806(invoke2)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 140846, 141436) || true) && (fromTypeAnalysis)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 140846, 141436);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 140924, 140977);

                                f_10874_140924_140976((f_10874_140938_140953(r1)) == (f_10874_140959_140974(r2)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 141230, 141261);

                                f_10874_141230_141260(!f_10874_141244_141259(r1));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 141291, 141322);

                                f_10874_141291_141321(!f_10874_141305_141320(r2));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 141352, 141409);

                                f_10874_141352_141408(!f_10874_141366_141407(r1, r2));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 140846, 141436);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 141472, 142056) || true) && (f_10874_141476_141491(r1))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 141472, 142056);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 141549, 141677) || true) && (f_10874_141553_141568(r2))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 141549, 141677);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 141634, 141646);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 141549, 141677);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 141709, 141759);

                                f_10874_141709_141758(currentResult == BetterResult.Right);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 141789, 141802);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 141472, 142056);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 141472, 142056);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 141860, 142056) || true) && (f_10874_141864_141879(r2))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 141860, 142056);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 141937, 141986);

                                    f_10874_141937_141985(currentResult == BetterResult.Left);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 142016, 142029);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 141860, 142056);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 141472, 142056);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 142084, 142226) || true) && (f_10874_142088_142129(r1, r2))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 142084, 142226);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 142187, 142199);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 142084, 142226);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 142254, 142326);

                            var
                            x = f_10874_142262_142325(lambda, f_10874_142285_142296(), d1, ref useSiteDiagnostics)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 142352, 142463) || true) && (f_10874_142356_142366_M(!x.HasType))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 142352, 142463);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 142424, 142436);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 142352, 142463);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 142502, 143282) || true) && (fromTypeAnalysis)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 142502, 143282);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 143029, 143255);

                                f_10874_143029_143254(f_10874_143076_143092(r1) || (DynAbs.Tracing.TraceSender.Expression_False(10874, 143076, 143145) || f_10874_143129_143145(r2)) || (DynAbs.Tracing.TraceSender.Expression_False(10874, 143076, 143253) || currentResult == f_10874_143199_143253(this, r1, r2, ref useSiteDiagnostics)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 142502, 143282);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 140418, 143313);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 140186, 143332);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 140063, 143347);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 143363, 143376);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 139028, 143387);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10874_140081_140104(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 140081, 140104);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10874_140204_140227(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 140204, 140227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10874_140301_140324(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 140301, 140324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10874_140370_140393(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 140370, 140393);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10874_140547_140565(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 140547, 140565);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10874_140567_140585(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 140567, 140585);
                    return return_v;
                }


                bool
                f_10874_140527_140586(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                p1, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                p2)
                {
                    var return_v = IdenticalParameters(p1, p2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 140527, 140586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_140727_140745(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 140727, 140745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_140788_140806(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 140788, 140806);
                    return return_v;
                }


                bool
                f_10874_140938_140953(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 140938, 140953);
                    return return_v;
                }


                bool
                f_10874_140959_140974(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 140959, 140974);
                    return return_v;
                }


                int
                f_10874_140924_140976(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 140924, 140976);
                    return 0;
                }


                bool
                f_10874_141244_141259(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 141244, 141259);
                    return return_v;
                }


                int
                f_10874_141230_141260(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 141230, 141260);
                    return 0;
                }


                bool
                f_10874_141305_141320(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 141305, 141320);
                    return return_v;
                }


                int
                f_10874_141291_141321(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 141291, 141321);
                    return 0;
                }


                bool
                f_10874_141366_141407(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = Conversions.HasIdentityConversion(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 141366, 141407);
                    return return_v;
                }


                int
                f_10874_141352_141408(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 141352, 141408);
                    return 0;
                }


                bool
                f_10874_141476_141491(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 141476, 141491);
                    return return_v;
                }


                bool
                f_10874_141553_141568(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 141553, 141568);
                    return return_v;
                }


                int
                f_10874_141709_141758(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 141709, 141758);
                    return 0;
                }


                bool
                f_10874_141864_141879(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 141864, 141879);
                    return return_v;
                }


                int
                f_10874_141937_141985(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 141937, 141985);
                    return 0;
                }


                bool
                f_10874_142088_142129(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = Conversions.HasIdentityConversion(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 142088, 142129);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10874_142285_142296()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 142285, 142296);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10874_142262_142325(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param, Microsoft.CodeAnalysis.CSharp.Conversions
                conversions, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.InferReturnType((Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions, delegateType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 142262, 142325);
                    return return_v;
                }


                bool
                f_10874_142356_142366_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 142356, 142366);
                    return return_v;
                }


                bool
                f_10874_143076_143092(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 143076, 143092);
                    return return_v;
                }


                bool
                f_10874_143129_143145(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 143129, 143145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10874_143199_143253(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BetterConversionTarget(type1, type2, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 143199, 143253);
                    return return_v;
                }


                int
                f_10874_143029_143254(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 143029, 143254);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 139028, 143387);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 139028, 143387);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IdenticalParameters(ImmutableArray<ParameterSymbol> p1, ImmutableArray<ParameterSymbol> p2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 143399, 144273);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 143535, 143687) || true) && (p1.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(10874, 143539, 143567) || p2.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 143535, 143687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 143659, 143672);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 143535, 143687);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 143703, 143791) || true) && (p1.Length != p2.Length)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 143703, 143791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 143763, 143776);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 143703, 143791);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 143816, 143821);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 143807, 144234) || true) && (i < p1.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 143838, 143841)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 143807, 144234))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 143807, 144234);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 143875, 143894);

                        var
                        param1 = p1[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 143912, 143931);

                        var
                        param2 = p2[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 143951, 144061) || true) && (f_10874_143955_143969(param1) != f_10874_143973_143987(param2))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 143951, 144061);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 144029, 144042);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 143951, 144061);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 144081, 144219) || true) && (!f_10874_144086_144145(f_10874_144120_144131(param1), f_10874_144133_144144(param2)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 144081, 144219);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 144187, 144200);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 144081, 144219);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 428);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 428);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 144250, 144262);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 143399, 144273);

                Microsoft.CodeAnalysis.RefKind
                f_10874_143955_143969(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 143955, 143969);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10874_143973_143987(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 143973, 143987);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_144120_144131(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 144120, 144131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_144133_144144(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 144133, 144144);
                    return return_v;
                }


                bool
                f_10874_144086_144145(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = Conversions.HasIdentityConversion(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 144086, 144145);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 143399, 144273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 143399, 144273);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsSignedIntegralType(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 144285, 144934);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 144367, 144505) || true) && ((object)type != null && (DynAbs.Tracing.TraceSender.Expression_True(10874, 144371, 144416) && f_10874_144395_144416(type)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 144367, 144505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 144450, 144490);

                    type = f_10874_144457_144489(type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 144367, 144505);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 144521, 144923);

                switch (f_10874_144529_144554(type))
                {

                    case SpecialType.System_SByte:
                    case SpecialType.System_Int16:
                    case SpecialType.System_Int32:
                    case SpecialType.System_Int64:
                    case SpecialType.System_IntPtr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 144521, 144923);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 144833, 144845);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 144521, 144923);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 144521, 144923);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 144895, 144908);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 144521, 144923);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 144285, 144934);

                bool
                f_10874_144395_144416(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 144395, 144416);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_144457_144489(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 144457, 144489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10874_144529_144554(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.GetSpecialTypeSafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 144529, 144554);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 144285, 144934);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 144285, 144934);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsUnsignedIntegralType(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 144946, 145600);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 145030, 145168) || true) && ((object)type != null && (DynAbs.Tracing.TraceSender.Expression_True(10874, 145034, 145079) && f_10874_145058_145079(type)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 145030, 145168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 145113, 145153);

                    type = f_10874_145120_145152(type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 145030, 145168);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 145184, 145589);

                switch (f_10874_145192_145217(type))
                {

                    case SpecialType.System_Byte:
                    case SpecialType.System_UInt16:
                    case SpecialType.System_UInt32:
                    case SpecialType.System_UInt64:
                    case SpecialType.System_UIntPtr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 145184, 145589);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 145499, 145511);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 145184, 145589);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 145184, 145589);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 145561, 145574);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 145184, 145589);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 144946, 145600);

                bool
                f_10874_145058_145079(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 145058, 145079);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10874_145120_145152(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 145120, 145152);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10874_145192_145217(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.GetSpecialTypeSafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 145192, 145217);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 144946, 145600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 144946, 145600);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void GetEffectiveParameterTypes(
                    MethodSymbol method,
                    int argumentCount,
                    ImmutableArray<int> argToParamMap,
                    ArrayBuilder<RefKind> argumentRefKinds,
                    bool isMethodGroupConversion,
                    bool allowRefOmittedArguments,
                    Binder binder,
                    bool expanded,
                    out ImmutableArray<TypeWithAnnotations> parameterTypes,
                    out ImmutableArray<RefKind> parameterRefKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 145612, 146768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 146124, 146154);

                bool
                hasAnyRefOmittedArgument
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 146168, 146619);

                EffectiveParameters
                effectiveParameters = (DynAbs.Tracing.TraceSender.Conditional_F1(10874, 146210, 146218) || ((expanded && DynAbs.Tracing.TraceSender.Conditional_F2(10874, 146238, 146419)) || DynAbs.Tracing.TraceSender.Conditional_F3(10874, 146439, 146618))) ? f_10874_146238_146419(method, argumentCount, argToParamMap, argumentRefKinds, isMethodGroupConversion, allowRefOmittedArguments, binder, out hasAnyRefOmittedArgument) : f_10874_146439_146618(method, argumentCount, argToParamMap, argumentRefKinds, isMethodGroupConversion, allowRefOmittedArguments, binder, out hasAnyRefOmittedArgument)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 146633, 146685);

                parameterTypes = effectiveParameters.ParameterTypes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 146699, 146757);

                parameterRefKinds = effectiveParameters.ParameterRefKinds;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 145612, 146768);

                Microsoft.CodeAnalysis.CSharp.OverloadResolution.EffectiveParameters
                f_10874_146238_146419(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member, int
                argumentCount, System.Collections.Immutable.ImmutableArray<int>
                argToParamMap, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                argumentRefKinds, bool
                isMethodGroupConversion, bool
                allowRefOmittedArguments, Microsoft.CodeAnalysis.CSharp.Binder
                binder, out bool
                hasAnyRefOmittedArgument)
                {
                    var return_v = GetEffectiveParametersInExpandedForm(member, argumentCount, argToParamMap, argumentRefKinds, isMethodGroupConversion, allowRefOmittedArguments, binder, out hasAnyRefOmittedArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 146238, 146419);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.OverloadResolution.EffectiveParameters
                f_10874_146439_146618(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member, int
                argumentCount, System.Collections.Immutable.ImmutableArray<int>
                argToParamMap, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                argumentRefKinds, bool
                isMethodGroupConversion, bool
                allowRefOmittedArguments, Microsoft.CodeAnalysis.CSharp.Binder
                binder, out bool
                hasAnyRefOmittedArgument)
                {
                    var return_v = GetEffectiveParametersInNormalForm(member, argumentCount, argToParamMap, argumentRefKinds, isMethodGroupConversion, allowRefOmittedArguments, binder, out hasAnyRefOmittedArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 146439, 146618);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 145612, 146768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 145612, 146768);
            }
        }

        private struct EffectiveParameters
        {

            internal readonly ImmutableArray<TypeWithAnnotations> ParameterTypes;

            internal readonly ImmutableArray<RefKind> ParameterRefKinds;

            internal EffectiveParameters(ImmutableArray<TypeWithAnnotations> types, ImmutableArray<RefKind> refKinds)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10874, 146998, 147221);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 147136, 147159);

                    ParameterTypes = types;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 147177, 147206);

                    ParameterRefKinds = refKinds;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10874, 146998, 147221);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 146998, 147221);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 146998, 147221);
                }
            }
            static EffectiveParameters()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10874, 146780, 147232);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10874, 146780, 147232);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 146780, 147232);
            }
        }

        private EffectiveParameters GetEffectiveParametersInNormalForm<TMember>(
                    TMember member,
                    int argumentCount,
                    ImmutableArray<int> argToParamMap,
                    ArrayBuilder<RefKind> argumentRefKinds,
                    bool isMethodGroupConversion,
                    bool allowRefOmittedArguments)
                    where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 147244, 147865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 147626, 147641);

                bool
                discarded
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 147655, 147854);

                return f_10874_147662_147853<TMember>(member, argumentCount, argToParamMap, argumentRefKinds, isMethodGroupConversion, allowRefOmittedArguments, _binder, hasAnyRefOmittedArgument: out discarded);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 147244, 147865);

                Microsoft.CodeAnalysis.CSharp.OverloadResolution.EffectiveParameters
                f_10874_147662_147853<TMember>(TMember
                member, int
                argumentCount, System.Collections.Immutable.ImmutableArray<int>
                argToParamMap, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                argumentRefKinds, bool
                isMethodGroupConversion, bool
                allowRefOmittedArguments, Microsoft.CodeAnalysis.CSharp.Binder
                binder, out bool
                hasAnyRefOmittedArgument) where TMember : Symbol

                {
                    var return_v = GetEffectiveParametersInNormalForm(member, argumentCount, argToParamMap, argumentRefKinds, isMethodGroupConversion, allowRefOmittedArguments, binder, out hasAnyRefOmittedArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 147662, 147853);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 147244, 147865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 147244, 147865);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static EffectiveParameters GetEffectiveParametersInNormalForm<TMember>(
                    TMember member,
                    int argumentCount,
                    ImmutableArray<int> argToParamMap,
                    ArrayBuilder<RefKind> argumentRefKinds,
                    bool isMethodGroupConversion,
                    bool allowRefOmittedArguments,
                    Binder binder,
                    out bool hasAnyRefOmittedArgument) where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 147877, 150648);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 148329, 148368);

                f_10874_148329_148367<TMember>(argumentRefKinds != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 148384, 148417);

                hasAnyRefOmittedArgument = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 148431, 148499);

                ImmutableArray<ParameterSymbol>
                parameters = f_10874_148476_148498<TMember>(member)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 148581, 148662);

                int
                parameterCount = f_10874_148602_148628<TMember>(member) + ((DynAbs.Tracing.TraceSender.Conditional_F1(10874, 148632, 148652) || ((f_10874_148632_148652<TMember>(member) && DynAbs.Tracing.TraceSender.Conditional_F2(10874, 148655, 148656)) || DynAbs.Tracing.TraceSender.Conditional_F3(10874, 148659, 148660))) ? 1 : 0)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 148678, 149065) || true) && (argumentCount == parameterCount && (DynAbs.Tracing.TraceSender.Expression_True(10874, 148682, 148747) && argToParamMap.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 148678, 149065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 148781, 148855);

                    ImmutableArray<RefKind>
                    parameterRefKinds = f_10874_148825_148854<TMember>(member)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 148873, 149050) || true) && (parameterRefKinds.IsDefaultOrEmpty)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 148873, 149050);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 148953, 149031);

                        return f_10874_148960_149030<TMember>(f_10874_148984_149010<TMember>(member), parameterRefKinds);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 148873, 149050);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 148678, 149065);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 149081, 149141);

                var
                types = f_10874_149093_149140<TMember>()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 149155, 149189);

                ArrayBuilder<RefKind>
                refs = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 149203, 149246);

                bool
                hasAnyRefArg = f_10874_149223_149245<TMember>(argumentRefKinds)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 149271, 149278);

                    for (int
        arg = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 149262, 150447) || true) && (arg < argumentCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 149301, 149306)
        , ++arg, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 149262, 150447))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 149262, 150447);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 149340, 149402);

                        int
                        parm = (DynAbs.Tracing.TraceSender.Conditional_F1(10874, 149351, 149374) || ((argToParamMap.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10874, 149377, 149380)) || DynAbs.Tracing.TraceSender.Conditional_F3(10874, 149383, 149401))) ? arg : argToParamMap[arg]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 149532, 149631) || true) && (parm >= parameters.Length)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 149532, 149631);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 149603, 149612);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 149532, 149631);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 149649, 149682);

                        var
                        parameter = parameters[parm]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 149700, 149741);

                        f_10874_149700_149740<TMember>(types, f_10874_149710_149739<TMember>(parameter));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 149761, 149834);

                        RefKind
                        argRefKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10874, 149782, 149794) || ((hasAnyRefArg && DynAbs.Tracing.TraceSender.Conditional_F2(10874, 149797, 149818)) || DynAbs.Tracing.TraceSender.Conditional_F3(10874, 149821, 149833))) ? f_10874_149797_149818<TMember>(argumentRefKinds, arg) : RefKind.None
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 149852, 150016);

                        RefKind
                        paramRefKind = f_10874_149875_150015<TMember>(parameter, argRefKind, isMethodGroupConversion, allowRefOmittedArguments, binder, ref hasAnyRefOmittedArgument)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 150036, 150432) || true) && (refs == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 150036, 150432);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 150094, 150308) || true) && (paramRefKind != RefKind.None)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 150094, 150308);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 150176, 150236);

                                refs = f_10874_150183_150235<TMember>(arg, RefKind.None);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 150262, 150285);

                                f_10874_150262_150284<TMember>(refs, paramRefKind);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 150094, 150308);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 150036, 150432);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 150036, 150432);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 150390, 150413);

                            f_10874_150390_150412<TMember>(refs, paramRefKind);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 150036, 150432);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 1186);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 1186);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 150463, 150554);

                var
                refKinds = (DynAbs.Tracing.TraceSender.Conditional_F1(10874, 150478, 150490) || ((refs != null && DynAbs.Tracing.TraceSender.Conditional_F2(10874, 150493, 150518)) || DynAbs.Tracing.TraceSender.Conditional_F3(10874, 150521, 150553))) ? f_10874_150493_150518<TMember>(refs) : default(ImmutableArray<RefKind>)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 150568, 150637);

                return f_10874_150575_150636<TMember>(f_10874_150599_150625<TMember>(types), refKinds);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 147877, 150648);

                int
                f_10874_148329_148367<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 148329, 148367);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10874_148476_148498<TMember>(TMember
                member) where TMember : Symbol

                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 148476, 148498);
                    return return_v;
                }


                int
                f_10874_148602_148628<TMember>(TMember
                member) where TMember : Symbol

                {
                    var return_v = member.GetParameterCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 148602, 148628);
                    return return_v;
                }


                bool
                f_10874_148632_148652<TMember>(TMember
                member) where TMember : Symbol

                {
                    var return_v = member.GetIsVararg();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 148632, 148652);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10874_148825_148854<TMember>(TMember
                member) where TMember : Symbol

                {
                    var return_v = member.GetParameterRefKinds();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 148825, 148854);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10874_148984_149010<TMember>(TMember
                member) where TMember : Symbol

                {
                    var return_v = member.GetParameterTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 148984, 149010);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.OverloadResolution.EffectiveParameters
                f_10874_148960_149030<TMember>(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                types, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds) where TMember : Symbol

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.OverloadResolution.EffectiveParameters(types, refKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 148960, 149030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10874_149093_149140<TMember>() where TMember : Symbol

                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 149093, 149140);
                    return return_v;
                }


                bool
                f_10874_149223_149245<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Any();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 149223, 149245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10874_149710_149739<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 149710, 149739);
                    return return_v;
                }


                int
                f_10874_149700_149740<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item) where TMember : Symbol

                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 149700, 149740);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10874_149797_149818<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 149797, 149818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10874_149875_150015<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, Microsoft.CodeAnalysis.RefKind
                argRefKind, bool
                isMethodGroupConversion, bool
                allowRefOmittedArguments, Microsoft.CodeAnalysis.CSharp.Binder
                binder, ref bool
                hasAnyRefOmittedArgument) where TMember : Symbol

                {
                    var return_v = GetEffectiveParameterRefKind(parameter, argRefKind, isMethodGroupConversion, allowRefOmittedArguments, binder, ref hasAnyRefOmittedArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 149875, 150015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                f_10874_150183_150235<TMember>(int
                capacity, Microsoft.CodeAnalysis.RefKind
                fillWithValue) where TMember : Symbol

                {
                    var return_v = ArrayBuilder<RefKind>.GetInstance(capacity, fillWithValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 150183, 150235);
                    return return_v;
                }


                int
                f_10874_150262_150284<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param, Microsoft.CodeAnalysis.RefKind
                item) where TMember : Symbol

                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 150262, 150284);
                    return 0;
                }


                int
                f_10874_150390_150412<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param, Microsoft.CodeAnalysis.RefKind
                item) where TMember : Symbol

                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 150390, 150412);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10874_150493_150518<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 150493, 150518);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10874_150599_150625<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 150599, 150625);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.OverloadResolution.EffectiveParameters
                f_10874_150575_150636<TMember>(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                types, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds) where TMember : Symbol

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.OverloadResolution.EffectiveParameters(types, refKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 150575, 150636);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 147877, 150648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 147877, 150648);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static RefKind GetEffectiveParameterRefKind(
                    ParameterSymbol parameter,
                    RefKind argRefKind,
                    bool isMethodGroupConversion,
                    bool allowRefOmittedArguments,
                    Binder binder,
                    ref bool hasAnyRefOmittedArgument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 150660, 152148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 150973, 151010);

                var
                paramRefKind = f_10874_150992_151009(parameter)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 151246, 151403) || true) && (!isMethodGroupConversion && (DynAbs.Tracing.TraceSender.Expression_True(10874, 151250, 151304) && argRefKind == RefKind.None) && (DynAbs.Tracing.TraceSender.Expression_True(10874, 151250, 151334) && paramRefKind == RefKind.In))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 151246, 151403);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 151368, 151388);

                    return RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 151246, 151403);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 151862, 152101) || true) && (allowRefOmittedArguments && (DynAbs.Tracing.TraceSender.Expression_True(10874, 151866, 151921) && paramRefKind == RefKind.Ref) && (DynAbs.Tracing.TraceSender.Expression_True(10874, 151866, 151951) && argRefKind == RefKind.None) && (DynAbs.Tracing.TraceSender.Expression_True(10874, 151866, 151982) && f_10874_151955_151982_M(!binder.InAttributeArgument)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 151862, 152101);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 152016, 152048);

                    hasAnyRefOmittedArgument = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 152066, 152086);

                    return RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 151862, 152101);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 152117, 152137);

                return paramRefKind;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 150660, 152148);

                Microsoft.CodeAnalysis.RefKind
                f_10874_150992_151009(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 150992, 151009);
                    return return_v;
                }


                bool
                f_10874_151955_151982_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 151955, 151982);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 150660, 152148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 150660, 152148);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private EffectiveParameters GetEffectiveParametersInExpandedForm<TMember>(
                    TMember member,
                    int argumentCount,
                    ImmutableArray<int> argToParamMap,
                    ArrayBuilder<RefKind> argumentRefKinds,
                    bool isMethodGroupConversion,
                    bool allowRefOmittedArguments) where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 152160, 152772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 152531, 152546);

                bool
                discarded
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 152560, 152761);

                return f_10874_152567_152760<TMember>(member, argumentCount, argToParamMap, argumentRefKinds, isMethodGroupConversion, allowRefOmittedArguments, _binder, hasAnyRefOmittedArgument: out discarded);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 152160, 152772);

                Microsoft.CodeAnalysis.CSharp.OverloadResolution.EffectiveParameters
                f_10874_152567_152760<TMember>(TMember
                member, int
                argumentCount, System.Collections.Immutable.ImmutableArray<int>
                argToParamMap, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                argumentRefKinds, bool
                isMethodGroupConversion, bool
                allowRefOmittedArguments, Microsoft.CodeAnalysis.CSharp.Binder
                binder, out bool
                hasAnyRefOmittedArgument) where TMember : Symbol

                {
                    var return_v = GetEffectiveParametersInExpandedForm(member, argumentCount, argToParamMap, argumentRefKinds, isMethodGroupConversion, allowRefOmittedArguments, binder, out hasAnyRefOmittedArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 152567, 152760);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 152160, 152772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 152160, 152772);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static EffectiveParameters GetEffectiveParametersInExpandedForm<TMember>(
                    TMember member,
                    int argumentCount,
                    ImmutableArray<int> argToParamMap,
                    ArrayBuilder<RefKind> argumentRefKinds,
                    bool isMethodGroupConversion,
                    bool allowRefOmittedArguments,
                    Binder binder,
                    out bool hasAnyRefOmittedArgument) where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 152784, 154662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 153238, 153277);

                f_10874_153238_153276<TMember>(argumentRefKinds != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 153293, 153353);

                var
                types = f_10874_153305_153352<TMember>()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 153367, 153414);

                var
                refs = f_10874_153378_153413<TMember>()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 153428, 153448);

                bool
                anyRef = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 153462, 153502);

                var
                parameters = f_10874_153479_153501<TMember>(member)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 153516, 153559);

                bool
                hasAnyRefArg = f_10874_153536_153558<TMember>(argumentRefKinds)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 153573, 153606);

                hasAnyRefOmittedArgument = false;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 153631, 153638);

                    for (int
        arg = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 153622, 154448) || true) && (arg < argumentCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 153661, 153666)
        , ++arg, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 153622, 154448))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 153622, 154448);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 153700, 153762);

                        var
                        parm = (DynAbs.Tracing.TraceSender.Conditional_F1(10874, 153711, 153734) || ((argToParamMap.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10874, 153737, 153740)) || DynAbs.Tracing.TraceSender.Conditional_F3(10874, 153743, 153761))) ? arg : argToParamMap[arg]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 153780, 153813);

                        var
                        parameter = parameters[parm]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 153831, 153872);

                        var
                        type = f_10874_153842_153871<TMember>(parameter)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 153892, 153998);

                        f_10874_153892_153997<TMember>(
                                        types, (DynAbs.Tracing.TraceSender.Conditional_F1(10874, 153902, 153931) || ((parm == parameters.Length - 1 && DynAbs.Tracing.TraceSender.Conditional_F2(10874, 153934, 153989)) || DynAbs.Tracing.TraceSender.Conditional_F3(10874, 153992, 153996))) ? f_10874_153934_153989<TMember>(((ArrayTypeSymbol)type.Type)) : type);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 154018, 154087);

                        var
                        argRefKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10874, 154035, 154047) || ((hasAnyRefArg && DynAbs.Tracing.TraceSender.Conditional_F2(10874, 154050, 154071)) || DynAbs.Tracing.TraceSender.Conditional_F3(10874, 154074, 154086))) ? f_10874_154050_154071<TMember>(argumentRefKinds, arg) : RefKind.None
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 154105, 154265);

                        var
                        paramRefKind = f_10874_154124_154264<TMember>(parameter, argRefKind, isMethodGroupConversion, allowRefOmittedArguments, binder, ref hasAnyRefOmittedArgument)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 154285, 154308);

                        f_10874_154285_154307<TMember>(
                                        refs, paramRefKind);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 154326, 154433) || true) && (paramRefKind != RefKind.None)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 154326, 154433);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 154400, 154414);

                            anyRef = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 154326, 154433);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 827);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 827);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 154464, 154542);

                var
                refKinds = (DynAbs.Tracing.TraceSender.Conditional_F1(10874, 154479, 154485) || ((anyRef && DynAbs.Tracing.TraceSender.Conditional_F2(10874, 154488, 154506)) || DynAbs.Tracing.TraceSender.Conditional_F3(10874, 154509, 154541))) ? f_10874_154488_154506<TMember>(refs) : default(ImmutableArray<RefKind>)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 154556, 154568);

                f_10874_154556_154567<TMember>(refs);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 154582, 154651);

                return f_10874_154589_154650<TMember>(f_10874_154613_154639<TMember>(types), refKinds);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 152784, 154662);

                int
                f_10874_153238_153276<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 153238, 153276);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10874_153305_153352<TMember>() where TMember : Symbol

                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 153305, 153352);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                f_10874_153378_153413<TMember>() where TMember : Symbol

                {
                    var return_v = ArrayBuilder<RefKind>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 153378, 153413);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10874_153479_153501<TMember>(TMember
                member) where TMember : Symbol

                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 153479, 153501);
                    return return_v;
                }


                bool
                f_10874_153536_153558<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Any();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 153536, 153558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10874_153842_153871<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 153842, 153871);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10874_153934_153989<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 153934, 153989);
                    return return_v;
                }


                int
                f_10874_153892_153997<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item) where TMember : Symbol

                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 153892, 153997);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10874_154050_154071<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param, int
                i0) where TMember : Symbol

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 154050, 154071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10874_154124_154264<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, Microsoft.CodeAnalysis.RefKind
                argRefKind, bool
                isMethodGroupConversion, bool
                allowRefOmittedArguments, Microsoft.CodeAnalysis.CSharp.Binder
                binder, ref bool
                hasAnyRefOmittedArgument) where TMember : Symbol

                {
                    var return_v = GetEffectiveParameterRefKind(parameter, argRefKind, isMethodGroupConversion, allowRefOmittedArguments, binder, ref hasAnyRefOmittedArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 154124, 154264);
                    return return_v;
                }


                int
                f_10874_154285_154307<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param, Microsoft.CodeAnalysis.RefKind
                item) where TMember : Symbol

                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 154285, 154307);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10874_154488_154506<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 154488, 154506);
                    return return_v;
                }


                int
                f_10874_154556_154567<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param) where TMember : Symbol

                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 154556, 154567);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10874_154613_154639<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 154613, 154639);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.OverloadResolution.EffectiveParameters
                f_10874_154589_154650<TMember>(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                types, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds) where TMember : Symbol

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.OverloadResolution.EffectiveParameters(types, refKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 154589, 154650);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 152784, 154662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 152784, 154662);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MemberResolutionResult<TMember> IsMemberApplicableInNormalForm<TMember>(
            TMember member,                // method or property
            TMember leastOverriddenMember, // method or property
            ArrayBuilder<TypeWithAnnotations> typeArguments,
            AnalyzedArguments arguments,
            bool isMethodGroupConversion,
            bool allowRefOmittedArguments,
            bool inferWithDynamic,
            bool completeResults,
            ref HashSet<DiagnosticInfo> useSiteDiagnostics)
            where TMember : Symbol
        {
            // AnalyzeArguments matches arguments to parameter names and positions. 
            // For that purpose we use the most derived member.
            var argumentAnalysis = AnalyzeArguments(member, arguments, isMethodGroupConversion, expanded: false);
            if (!argumentAnalysis.IsValid)
            {
                switch (argumentAnalysis.Kind)
                {
                    case ArgumentAnalysisResultKind.RequiredParameterMissing:
                    case ArgumentAnalysisResultKind.NoCorrespondingParameter:
                    case ArgumentAnalysisResultKind.DuplicateNamedArgument:
                        if (!completeResults) goto default;
                        // When we are producing more complete results, and we have the wrong number of arguments, we push on
                        // through type inference so that lambda arguments can be bound to their delegate-typed parameters,
                        // thus improving the API and intellisense experience.
                        break;
                    default:
                        return new MemberResolutionResult<TMember>(member, leastOverriddenMember, MemberAnalysisResult.ArgumentParameterMismatch(argumentAnalysis));
                }
            }

            // Check after argument analysis, but before more complicated type inference and argument type validation.
            // NOTE: The diagnostic may not be reported (e.g. if the member is later removed as less-derived).
            if (member.HasUseSiteError)
            {
                return new MemberResolutionResult<TMember>(member, leastOverriddenMember, MemberAnalysisResult.UseSiteError());
            }

            bool hasAnyRefOmittedArgument;

            // To determine parameter types we use the originalMember.
            EffectiveParameters originalEffectiveParameters = GetEffectiveParametersInNormalForm(
                GetConstructedFrom(leastOverriddenMember),
                arguments.Arguments.Count,
                argumentAnalysis.ArgsToParamsOpt,
                arguments.RefKinds,
                isMethodGroupConversion,
                allowRefOmittedArguments,
                _binder,
                out hasAnyRefOmittedArgument);

            Debug.Assert(!hasAnyRefOmittedArgument || allowRefOmittedArguments);

            // To determine parameter types we use the originalMember.
            EffectiveParameters constructedEffectiveParameters = GetEffectiveParametersInNormalForm(
                leastOverriddenMember,
                arguments.Arguments.Count,
                argumentAnalysis.ArgsToParamsOpt,
                arguments.RefKinds,
                isMethodGroupConversion,
                allowRefOmittedArguments);

            // The member passed to the following call is returned in the result (possibly a constructed version of it).
            // The applicability is checked based on effective parameters passed in.
            var applicableResult = IsApplicable(
                member, leastOverriddenMember,
                typeArguments, arguments, originalEffectiveParameters, constructedEffectiveParameters,
                argumentAnalysis.ArgsToParamsOpt,
                hasAnyRefOmittedArgument: hasAnyRefOmittedArgument,
                inferWithDynamic: inferWithDynamic,
                completeResults: completeResults,
                useSiteDiagnostics: ref useSiteDiagnostics);

            // If we were producing complete results and had missing arguments, we pushed on in order to call IsApplicable for
            // type inference and lambda binding. In that case we still need to return the argument mismatch failure here.
            if (completeResults && !argumentAnalysis.IsValid)
            {
                return new MemberResolutionResult<TMember>(member, leastOverriddenMember, MemberAnalysisResult.ArgumentParameterMismatch(argumentAnalysis));
            }

            return applicableResult;
        }

        private MemberResolutionResult<TMember> IsMemberApplicableInExpandedForm<TMember>(
                    TMember member,                // method or property
                    TMember leastOverriddenMember, // method or property
                    ArrayBuilder<TypeWithAnnotations> typeArguments,
                    AnalyzedArguments arguments,
                    bool allowRefOmittedArguments,
                    bool completeResults,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
                    where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 159326, 162932);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 159996, 160103);

                var
                argumentAnalysis = f_10874_160019_160102<TMember>(member, arguments, isMethodGroupConversion: false, expanded: true)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 160117, 160335) || true) && (f_10874_160121_160146_M(!argumentAnalysis.IsValid))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 160117, 160335);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 160180, 160320);

                    return f_10874_160187_160319<TMember>(member, leastOverriddenMember, MemberAnalysisResult.ArgumentParameterMismatch(argumentAnalysis));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 160117, 160335);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 160583, 160769) || true) && (f_10874_160587_160609<TMember>(member))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 160583, 160769);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 160643, 160754);

                    return f_10874_160650_160753<TMember>(member, leastOverriddenMember, MemberAnalysisResult.UseSiteError());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 160583, 160769);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 160785, 160815);

                bool
                hasAnyRefOmittedArgument
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 160909, 161354);

                EffectiveParameters
                originalEffectiveParameters = f_10874_160959_161353<TMember>(f_10874_161014_161055<TMember>(leastOverriddenMember), f_10874_161074_161099<TMember>(arguments.Arguments), argumentAnalysis.ArgsToParamsOpt, arguments.RefKinds, isMethodGroupConversion: false, allowRefOmittedArguments, _binder, out hasAnyRefOmittedArgument)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 161370, 161438);

                f_10874_161370_161437<TMember>(!hasAnyRefOmittedArgument || (DynAbs.Tracing.TraceSender.Expression_False(10874, 161383, 161436) || allowRefOmittedArguments));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 161532, 161887);

                EffectiveParameters
                constructedEffectiveParameters = f_10874_161585_161886<TMember>(this, leastOverriddenMember, f_10874_161680_161705<TMember>(arguments.Arguments), argumentAnalysis.ArgsToParamsOpt, arguments.RefKinds, isMethodGroupConversion: false, allowRefOmittedArguments)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 162111, 162564);

                var
                result = f_10874_162124_162563<TMember>(this, member, leastOverriddenMember, typeArguments, arguments, originalEffectiveParameters, constructedEffectiveParameters, argumentAnalysis.ArgsToParamsOpt, hasAnyRefOmittedArgument: hasAnyRefOmittedArgument, inferWithDynamic: false, completeResults: completeResults, useSiteDiagnostics: ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 162580, 162921);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10874, 162587, 162608) || ((result.Result.IsValid && DynAbs.Tracing.TraceSender.Conditional_F2(10874, 162628, 162894)) || DynAbs.Tracing.TraceSender.Conditional_F3(10874, 162914, 162920))) ? f_10874_162628_162894<TMember>(result.Member, result.LeastOverriddenMember, MemberAnalysisResult.ExpandedForm(result.Result.ArgsToParamsOpt, result.Result.ConversionsOpt, hasAnyRefOmittedArgument)) : result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 159326, 162932);

                Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResult
                f_10874_160019_160102<TMember>(TMember
                symbol, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, bool
                isMethodGroupConversion, bool
                expanded) where TMember : Symbol

                {
                    var return_v = AnalyzeArguments((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, arguments, isMethodGroupConversion: isMethodGroupConversion, expanded: expanded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 160019, 160102);
                    return return_v;
                }


                bool
                f_10874_160121_160146_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 160121, 160146);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_160187_160319<TMember>(TMember
                member, TMember
                leastOverriddenMember, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result) where TMember : Symbol

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>(member, leastOverriddenMember, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 160187, 160319);
                    return return_v;
                }


                bool
                f_10874_160587_160609<TMember>(TMember
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.HasUseSiteError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 160587, 160609);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_160650_160753<TMember>(TMember
                member, TMember
                leastOverriddenMember, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result) where TMember : Symbol

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>(member, leastOverriddenMember, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 160650, 160753);
                    return return_v;
                }


                TMember
                f_10874_161014_161055<TMember>(TMember
                member) where TMember : Symbol

                {
                    var return_v = GetConstructedFrom(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 161014, 161055);
                    return return_v;
                }


                int
                f_10874_161074_161099<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 161074, 161099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.OverloadResolution.EffectiveParameters
                f_10874_160959_161353<TMember>(TMember
                member, int
                argumentCount, System.Collections.Immutable.ImmutableArray<int>
                argToParamMap, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                argumentRefKinds, bool
                isMethodGroupConversion, bool
                allowRefOmittedArguments, Microsoft.CodeAnalysis.CSharp.Binder
                binder, out bool
                hasAnyRefOmittedArgument) where TMember : Symbol

                {
                    var return_v = GetEffectiveParametersInExpandedForm(member, argumentCount, argToParamMap, argumentRefKinds, isMethodGroupConversion: isMethodGroupConversion, allowRefOmittedArguments, binder, out hasAnyRefOmittedArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 160959, 161353);
                    return return_v;
                }


                int
                f_10874_161370_161437<TMember>(bool
                condition) where TMember : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 161370, 161437);
                    return 0;
                }


                int
                f_10874_161680_161705<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 161680, 161705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.OverloadResolution.EffectiveParameters
                f_10874_161585_161886<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, TMember
                member, int
                argumentCount, System.Collections.Immutable.ImmutableArray<int>
                argToParamMap, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                argumentRefKinds, bool
                isMethodGroupConversion, bool
                allowRefOmittedArguments) where TMember : Symbol

                {
                    var return_v = this_param.GetEffectiveParametersInExpandedForm<TMember>(member, argumentCount, argToParamMap, argumentRefKinds, isMethodGroupConversion: isMethodGroupConversion, allowRefOmittedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 161585, 161886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_162124_162563<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, TMember
                member, TMember
                leastOverriddenMember, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgumentsBuilder, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, Microsoft.CodeAnalysis.CSharp.OverloadResolution.EffectiveParameters
                originalEffectiveParameters, Microsoft.CodeAnalysis.CSharp.OverloadResolution.EffectiveParameters
                constructedEffectiveParameters, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsMap, bool
                hasAnyRefOmittedArgument, bool
                inferWithDynamic, bool
                completeResults, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = this_param.IsApplicable<TMember>(member, leastOverriddenMember, typeArgumentsBuilder, arguments, originalEffectiveParameters, constructedEffectiveParameters, argsToParamsMap, hasAnyRefOmittedArgument: hasAnyRefOmittedArgument, inferWithDynamic: inferWithDynamic, completeResults: completeResults, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 162124, 162563);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_162628_162894<TMember>(TMember
                member, TMember
                leastOverriddenMember, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result) where TMember : Symbol

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>(member, leastOverriddenMember, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 162628, 162894);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 159326, 162932);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 159326, 162932);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MemberResolutionResult<TMember> IsApplicable<TMember>(
                    TMember member,                // method or property
                    TMember leastOverriddenMember, // method or property 
                    ArrayBuilder<TypeWithAnnotations> typeArgumentsBuilder,
                    AnalyzedArguments arguments,
                    EffectiveParameters originalEffectiveParameters,
                    EffectiveParameters constructedEffectiveParameters,
                    ImmutableArray<int> argsToParamsMap,
                    bool hasAnyRefOmittedArgument,
                    bool inferWithDynamic,
                    bool completeResults,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
                    where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 162944, 170759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 163664, 163685);

                bool
                ignoreOpenTypes
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 163699, 163719);

                MethodSymbol
                method
                = default(MethodSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 163733, 163773);

                EffectiveParameters
                effectiveParameters
                = default(EffectiveParameters);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 163787, 170183) || true) && (f_10874_163791_163802<TMember>(member) == SymbolKind.Method && (DynAbs.Tracing.TraceSender.Expression_True(10874, 163791, 163876) && f_10874_163827_163872<TMember>((method = (MethodSymbol)(Symbol)member)) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 163787, 170183);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 163910, 170007) || true) && (f_10874_163914_163940<TMember>(typeArgumentsBuilder) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10874, 163914, 163977) && f_10874_163949_163977<TMember>(arguments)) && (DynAbs.Tracing.TraceSender.Expression_True(10874, 163914, 163998) && !inferWithDynamic))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 163910, 170007);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 164798, 164821);

                        ignoreOpenTypes = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 164843, 164896);

                        effectiveParameters = constructedEffectiveParameters;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 163910, 170007);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 163910, 170007);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 164978, 165059);

                        MethodSymbol
                        leastOverriddenMethod = (MethodSymbol)(Symbol)leastOverriddenMember
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 165083, 165133);

                        ImmutableArray<TypeWithAnnotations>
                        typeArguments
                        = default(ImmutableArray<TypeWithAnnotations>);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 165155, 166257) || true) && (f_10874_165159_165185<TMember>(typeArgumentsBuilder) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 165155, 166257);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 165325, 165376);

                            typeArguments = f_10874_165341_165375<TMember>(typeArgumentsBuilder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 165155, 166257);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 165155, 166257);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 165532, 165568);

                            MemberAnalysisResult
                            inferenceError
                            = default(MemberAnalysisResult);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 165594, 166006);

                            typeArguments = f_10874_165610_166005<TMember>(this, method, f_10874_165688_165740<TMember>(f_10874_165688_165725<TMember>(leastOverriddenMethod)), arguments, originalEffectiveParameters, out inferenceError, ref useSiteDiagnostics);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 166032, 166234) || true) && (typeArguments.IsDefault)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 166032, 166234);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 166117, 166207);

                                return f_10874_166124_166206<TMember>(member, leastOverriddenMember, inferenceError);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 166032, 166234);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 165155, 166257);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 166281, 166339);

                        member = (TMember)(Symbol)f_10874_166307_166338<TMember>(method, typeArguments);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 166361, 166465);

                        leastOverriddenMember = (TMember)(Symbol)f_10874_166402_166464<TMember>(f_10874_166402_166439<TMember>(leastOverriddenMethod), typeArguments);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 168678, 168741);

                        var
                        parameterTypes = f_10874_168699_168740<TMember>(leastOverriddenMember)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 168772, 168777);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 168763, 169182) || true) && (i < parameterTypes.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 168806, 168809)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 168763, 169182))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 168763, 169182);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 168859, 169159) || true) && (!f_10874_168864_168932<TMember>(parameterTypes[i].Type, f_10874_168907_168918<TMember>(), f_10874_168920_168931<TMember>()))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 168859, 169159);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 168990, 169132);

                                    return f_10874_168997_169131<TMember>(member, leastOverriddenMember, MemberAnalysisResult.ConstructedParameterFailedConstraintsCheck(i));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 168859, 169159);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 420);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 420);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 169623, 169701);

                        var
                        map = f_10874_169633_169700<TMember>(f_10874_169645_169666<TMember>(method), typeArguments, allowAlpha: true)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 169725, 169940);

                        effectiveParameters = f_10874_169747_169939<TMember>(f_10874_169797_169863<TMember>(map, constructedEffectiveParameters.ParameterTypes), constructedEffectiveParameters.ParameterRefKinds);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 169964, 169988);

                        ignoreOpenTypes = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 163910, 170007);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 163787, 170183);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 163787, 170183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 170073, 170126);

                    effectiveParameters = constructedEffectiveParameters;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 170144, 170168);

                    ignoreOpenTypes = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 163787, 170183);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 170199, 170642);

                var
                applicableResult = f_10874_170222_170641<TMember>(this, member, effectiveParameters, arguments, argsToParamsMap, isVararg: f_10874_170388_170408<TMember>(member), hasAnyRefOmittedArgument: hasAnyRefOmittedArgument, ignoreOpenTypes: ignoreOpenTypes, completeResults: completeResults, useSiteDiagnostics: ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 170656, 170748);

                return f_10874_170663_170747<TMember>(member, leastOverriddenMember, applicableResult);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 162944, 170759);

                Microsoft.CodeAnalysis.SymbolKind
                f_10874_163791_163802<TMember>(TMember
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 163791, 163802);
                    return return_v;
                }


                int
                f_10874_163827_163872<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 163827, 163872);
                    return return_v;
                }


                int
                f_10874_163914_163940<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 163914, 163940);
                    return return_v;
                }


                bool
                f_10874_163949_163977<TMember>(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.HasDynamicArgument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 163949, 163977);
                    return return_v;
                }


                int
                f_10874_165159_165185<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 165159, 165185);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10874_165341_165375<TMember>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 165341, 165375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10874_165688_165725<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 165688, 165725);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10874_165688_165740<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 165688, 165740);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10874_165610_166005<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                originalTypeParameters, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, Microsoft.CodeAnalysis.CSharp.OverloadResolution.EffectiveParameters
                originalEffectiveParameters, out Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                error, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = this_param.InferMethodTypeArguments(method, originalTypeParameters, arguments, originalEffectiveParameters, out error, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 165610, 166005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_166124_166206<TMember>(TMember
                member, TMember
                leastOverriddenMember, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result) where TMember : Symbol

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>(member, leastOverriddenMember, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 166124, 166206);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10874_166307_166338<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments) where TMember : Symbol

                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 166307, 166338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10874_166402_166439<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 166402, 166439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10874_166402_166464<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments) where TMember : Symbol

                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 166402, 166464);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10874_168699_168740<TMember>(TMember
                member) where TMember : Symbol

                {
                    var return_v = member.GetParameterTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 168699, 168740);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10874_168907_168918<TMember>() where TMember : Symbol

                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 168907, 168918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10874_168920_168931<TMember>() where TMember : Symbol

                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 168920, 168931);
                    return return_v;
                }


                bool
                f_10874_168864_168932<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Conversions
                conversions) where TMember : Symbol

                {
                    var return_v = type.CheckAllConstraints(compilation, (Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 168864, 168932);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_168997_169131<TMember>(TMember
                member, TMember
                leastOverriddenMember, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result) where TMember : Symbol

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>(member, leastOverriddenMember, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 168997, 169131);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10874_169645_169666<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 169645, 169666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10874_169633_169700<TMember>(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                from, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                to, bool
                allowAlpha) where TMember : Symbol

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap(from, to, allowAlpha: allowAlpha);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 169633, 169700);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10874_169797_169863<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                original) where TMember : Symbol

                {
                    var return_v = this_param.SubstituteTypes(original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 169797, 169863);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.OverloadResolution.EffectiveParameters
                f_10874_169747_169939<TMember>(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                types, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds) where TMember : Symbol

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.OverloadResolution.EffectiveParameters(types, refKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 169747, 169939);
                    return return_v;
                }


                bool
                f_10874_170388_170408<TMember>(TMember
                member) where TMember : Symbol

                {
                    var return_v = member.GetIsVararg();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 170388, 170408);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10874_170222_170641<TMember>(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, TMember
                candidate, Microsoft.CodeAnalysis.CSharp.OverloadResolution.EffectiveParameters
                parameters, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, System.Collections.Immutable.ImmutableArray<int>
                argsToParameters, bool
                isVararg, bool
                hasAnyRefOmittedArgument, bool
                ignoreOpenTypes, bool
                completeResults, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics) where TMember : Symbol

                {
                    var return_v = this_param.IsApplicable((Microsoft.CodeAnalysis.CSharp.Symbol)candidate, parameters, arguments, argsToParameters, isVararg: isVararg, hasAnyRefOmittedArgument: hasAnyRefOmittedArgument, ignoreOpenTypes: ignoreOpenTypes, completeResults: completeResults, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 170222, 170641);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>
                f_10874_170663_170747<TMember>(TMember
                member, TMember
                leastOverriddenMember, Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                result) where TMember : Symbol

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberResolutionResult<TMember>(member, leastOverriddenMember, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 170663, 170747);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 162944, 170759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 162944, 170759);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<TypeWithAnnotations> InferMethodTypeArguments(
                    MethodSymbol method,
                    ImmutableArray<TypeParameterSymbol> originalTypeParameters,
                    AnalyzedArguments arguments,
                    EffectiveParameters originalEffectiveParameters,
                    out MemberAnalysisResult error,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 170771, 172898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 171182, 171227);

                var
                args = f_10874_171193_171226(arguments.Arguments)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 171554, 171936);

                var
                inferenceResult = f_10874_171576_171935(_binder, f_10874_171645_171664(_binder), originalTypeParameters, f_10874_171724_171745(method), originalEffectiveParameters.ParameterTypes, originalEffectiveParameters.ParameterRefKinds, args, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 171952, 172129) || true) && (inferenceResult.Success)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 171952, 172129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 172013, 172051);

                    error = default(MemberAnalysisResult);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 172069, 172114);

                    return inferenceResult.InferredTypeArguments;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 171952, 172129);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 172145, 172754) || true) && (arguments.IsExtensionMethodInvocation)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 172145, 172754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 172220, 172471);

                    var
                    inferredFromFirstArgument = f_10874_172252_172470(f_10874_172329_172348(_binder), method, args, useSiteDiagnostics: ref useSiteDiagnostics)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 172489, 172739) || true) && (inferredFromFirstArgument.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 172489, 172739);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 172570, 172646);

                        error = MemberAnalysisResult.TypeInferenceExtensionInstanceArgumentFailed();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 172668, 172720);

                        return default(ImmutableArray<TypeWithAnnotations>);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 172489, 172739);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 172145, 172754);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 172770, 172821);

                error = MemberAnalysisResult.TypeInferenceFailed();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 172835, 172887);

                return default(ImmutableArray<TypeWithAnnotations>);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 170771, 172898);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10874_171193_171226(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 171193, 171226);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10874_171645_171664(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 171645, 171664);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10874_171724_171745(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 171724, 171745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodTypeInferenceResult
                f_10874_171576_171935(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Conversions
                conversions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                methodTypeParameters, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                constructedContainingTypeOfMethod, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                formalParameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                formalParameterRefKinds, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = MethodTypeInferrer.Infer(binder, (Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions, methodTypeParameters, constructedContainingTypeOfMethod, formalParameterTypes, formalParameterRefKinds, arguments, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 171576, 171935);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10874_172329_172348(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 172329, 172348);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10874_172252_172470(Microsoft.CodeAnalysis.CSharp.Conversions
                conversions, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = MethodTypeInferrer.InferTypeArgumentsFromFirstArgument((Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions, method, arguments, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 172252, 172470);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 170771, 172898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 170771, 172898);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MemberAnalysisResult IsApplicable(
                    Symbol candidate, // method or property
                    EffectiveParameters parameters,
                    AnalyzedArguments arguments,
                    ImmutableArray<int> argsToParameters,
                    bool isVararg,
                    bool hasAnyRefOmittedArgument,
                    bool ignoreOpenTypes,
                    bool completeResults,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 172910, 180046);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 174054, 174125);

                int
                paramCount = parameters.ParameterTypes.Length + ((DynAbs.Tracing.TraceSender.Conditional_F1(10874, 174107, 174115) || ((isVararg && DynAbs.Tracing.TraceSender.Conditional_F2(10874, 174118, 174119)) || DynAbs.Tracing.TraceSender.Conditional_F3(10874, 174122, 174123))) ? 1 : 0)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 174141, 174525) || true) && (f_10874_174145_174170(arguments.Arguments) < paramCount)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 174141, 174525);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 174471, 174510);

                    paramCount = f_10874_174484_174509(arguments.Arguments);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 174141, 174525);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 175141, 175185);

                ArrayBuilder<Conversion>
                conversions = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 175199, 175237);

                ArrayBuilder<int>
                badArguments = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 175260, 175280);
                    for (int
        argumentPosition = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 175251, 179451) || true) && (argumentPosition < paramCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 175313, 175331)
        , argumentPosition++, DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 175251, 179451))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 175251, 179451);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 175365, 175429);

                        BoundExpression
                        argument = f_10874_175392_175428(arguments, argumentPosition)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 175447, 175469);

                        Conversion
                        conversion
                        = default(Conversion);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 175489, 178869) || true) && (isVararg && (DynAbs.Tracing.TraceSender.Expression_True(10874, 175493, 175539) && argumentPosition == paramCount - 1))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 175489, 178869);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 175652, 176089) || true) && (f_10874_175656_175669(argument) == BoundKind.ArgListOperator)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 175652, 176089);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 175748, 175781);

                                conversion = Conversion.Identity;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 175652, 176089);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 175652, 176089);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 175879, 175942);

                                badArguments = badArguments ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>?>(10874, 175894, 175941) ?? f_10874_175910_175941());
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 175968, 176003);

                                f_10874_175968_176002(badArguments, argumentPosition);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 176029, 176066);

                                conversion = Conversion.NoConversion;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 175652, 176089);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 175489, 178869);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 175489, 178869);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 176171, 176233);

                            RefKind
                            argumentRefKind = f_10874_176197_176232(arguments, argumentPosition)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 176255, 176385);

                            RefKind
                            parameterRefKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10874, 176282, 176320) || ((parameters.ParameterRefKinds.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10874, 176323, 176335)) || DynAbs.Tracing.TraceSender.Conditional_F3(10874, 176338, 176384))) ? RefKind.None : parameters.ParameterRefKinds[argumentPosition]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 176407, 176498);

                            bool
                            forExtensionMethodThisArg = f_10874_176440_176497(arguments, argumentPosition)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 176522, 177161) || true) && (forExtensionMethodThisArg)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 176522, 177161);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 176601, 176647);

                                f_10874_176601_176646(argumentRefKind == RefKind.None);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 176673, 177138) || true) && (parameterRefKind == RefKind.Ref)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 176673, 177138);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 177076, 177111);

                                    argumentRefKind = parameterRefKind;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 176673, 177138);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 176522, 177161);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 177185, 177603);

                            conversion = f_10874_177198_177602(this, candidate, argument, argumentRefKind, parameters.ParameterTypes[argumentPosition].Type, parameterRefKind, ignoreOpenTypes, ref useSiteDiagnostics, forExtensionMethodThisArg);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 177627, 178607) || true) && (forExtensionMethodThisArg && (DynAbs.Tracing.TraceSender.Expression_True(10874, 177631, 177724) && !f_10874_177661_177724(conversion)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 177627, 178607);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 178318, 178353);

                                f_10874_178318_178352(badArguments == null);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 178379, 178413);

                                f_10874_178379_178412(conversions == null);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 178439, 178584);

                                return MemberAnalysisResult.BadArgumentConversions(argsToParameters, f_10874_178508_178547(argumentPosition), f_10874_178549_178582(conversion));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 177627, 178607);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 178631, 178850) || true) && (f_10874_178635_178653_M(!conversion.Exists))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 178631, 178850);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 178703, 178766);

                                badArguments = badArguments ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>?>(10874, 178718, 178765) ?? f_10874_178734_178765());
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 178792, 178827);

                                f_10874_178792_178826(badArguments, argumentPosition);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 178631, 178850);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 175489, 178869);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 178889, 179305) || true) && (conversions != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 178889, 179305);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 178954, 178982);

                            f_10874_178954_178981(conversions, conversion);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 178889, 179305);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 178889, 179305);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 179024, 179305) || true) && (f_10874_179028_179050_M(!conversion.IsIdentity))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 179024, 179305);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 179092, 179155);

                                conversions = f_10874_179106_179154(paramCount);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 179177, 179236);

                                f_10874_179177_179235(conversions, Conversion.Identity, argumentPosition);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 179258, 179286);

                                f_10874_179258_179285(conversions, conversion);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 179024, 179305);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 178889, 179305);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 179325, 179436) || true) && (badArguments != null && (DynAbs.Tracing.TraceSender.Expression_True(10874, 179329, 179369) && !completeResults))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 179325, 179436);
                            DynAbs.Tracing.TraceSender.TraceBreak(10874, 179411, 179417);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 179325, 179436);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10874, 1, 4201);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10874, 1, 4201);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 179467, 179495);

                MemberAnalysisResult
                result
                = default(MemberAnalysisResult);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 179509, 179625);

                var
                conversionsArray = (DynAbs.Tracing.TraceSender.Conditional_F1(10874, 179532, 179551) || ((conversions != null && DynAbs.Tracing.TraceSender.Conditional_F2(10874, 179554, 179586)) || DynAbs.Tracing.TraceSender.Conditional_F3(10874, 179589, 179624))) ? f_10874_179554_179586(conversions) : default(ImmutableArray<Conversion>)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 179639, 180005) || true) && (badArguments != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 179639, 180005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 179697, 179821);

                    result = MemberAnalysisResult.BadArgumentConversions(argsToParameters, f_10874_179768_179801(badArguments), conversionsArray);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 179639, 180005);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 179639, 180005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 179887, 179990);

                    result = MemberAnalysisResult.NormalForm(argsToParameters, conversionsArray, hasAnyRefOmittedArgument);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 179639, 180005);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 180021, 180035);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 172910, 180046);

                int
                f_10874_174145_174170(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 174145, 174170);
                    return return_v;
                }


                int
                f_10874_174484_174509(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 174484, 174509);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10874_175392_175428(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param, int
                i)
                {
                    var return_v = this_param.Argument(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 175392, 175428);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10874_175656_175669(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 175656, 175669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                f_10874_175910_175941()
                {
                    var return_v = ArrayBuilder<int>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 175910, 175941);
                    return return_v;
                }


                int
                f_10874_175968_176002(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 175968, 176002);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10874_176197_176232(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param, int
                i)
                {
                    var return_v = this_param.RefKind(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 176197, 176232);
                    return return_v;
                }


                bool
                f_10874_176440_176497(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param, int
                i)
                {
                    var return_v = this_param.IsExtensionMethodThisArgument(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 176440, 176497);
                    return return_v;
                }


                int
                f_10874_176601_176646(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 176601, 176646);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10874_177198_177602(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                candidate, Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument, Microsoft.CodeAnalysis.RefKind
                argRefKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                parameterType, Microsoft.CodeAnalysis.RefKind
                parRefKind, bool
                ignoreOpenTypes, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                forExtensionMethodThisArg)
                {
                    var return_v = this_param.CheckArgumentForApplicability(candidate, argument, argRefKind, parameterType, parRefKind, ignoreOpenTypes, ref useSiteDiagnostics, forExtensionMethodThisArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 177198, 177602);
                    return return_v;
                }


                bool
                f_10874_177661_177724(Microsoft.CodeAnalysis.CSharp.Conversion
                conversion)
                {
                    var return_v = Conversions.IsValidExtensionMethodThisArgConversion(conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 177661, 177724);
                    return return_v;
                }


                int
                f_10874_178318_178352(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 178318, 178352);
                    return 0;
                }


                int
                f_10874_178379_178412(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 178379, 178412);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10874_178508_178547(int
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 178508, 178547);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                f_10874_178549_178582(Microsoft.CodeAnalysis.CSharp.Conversion
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 178549, 178582);
                    return return_v;
                }


                bool
                f_10874_178635_178653_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 178635, 178653);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                f_10874_178734_178765()
                {
                    var return_v = ArrayBuilder<int>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 178734, 178765);
                    return return_v;
                }


                int
                f_10874_178792_178826(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 178792, 178826);
                    return 0;
                }


                int
                f_10874_178954_178981(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Conversion>
                this_param, Microsoft.CodeAnalysis.CSharp.Conversion
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 178954, 178981);
                    return 0;
                }


                bool
                f_10874_179028_179050_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 179028, 179050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Conversion>
                f_10874_179106_179154(int
                capacity)
                {
                    var return_v = ArrayBuilder<Conversion>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 179106, 179154);
                    return return_v;
                }


                int
                f_10874_179177_179235(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Conversion>
                this_param, Microsoft.CodeAnalysis.CSharp.Conversion
                item, int
                count)
                {
                    this_param.AddMany(item, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 179177, 179235);
                    return 0;
                }


                int
                f_10874_179258_179285(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Conversion>
                this_param, Microsoft.CodeAnalysis.CSharp.Conversion
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 179258, 179285);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                f_10874_179554_179586(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Conversion>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 179554, 179586);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10874_179768_179801(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 179768, 179801);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 172910, 180046);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 172910, 180046);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion CheckArgumentForApplicability(
                    Symbol candidate, // method or property
                    BoundExpression argument,
                    RefKind argRefKind,
                    TypeSymbol parameterType,
                    RefKind parRefKind,
                    bool ignoreOpenTypes,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                    bool forExtensionMethodThisArg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10874, 180058, 183596);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 181307, 181497) || true) && (!(argRefKind == parRefKind || (DynAbs.Tracing.TraceSender.Expression_False(10874, 181313, 181416) || (argRefKind == RefKind.None && (DynAbs.Tracing.TraceSender.Expression_True(10874, 181360, 181415) && f_10874_181390_181415(argument))))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 181307, 181497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 181451, 181482);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 181307, 181497);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 181961, 182205) || true) && (ignoreOpenTypes && (DynAbs.Tracing.TraceSender.Expression_True(10874, 181965, 182064) && f_10874_181984_182064(parameterType, candidate)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 181961, 182205);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 182156, 182190);

                    return Conversion.ImplicitDynamic;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 181961, 182205);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 182221, 182249);

                var
                argType = f_10874_182235_182248(argument)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 182263, 182713) || true) && (f_10874_182267_182280(argument) == BoundKind.OutVariablePendingInference || (DynAbs.Tracing.TraceSender.Expression_False(10874, 182267, 182402) || f_10874_182342_182355(argument) == BoundKind.OutDeconstructVarPendingInference) || (DynAbs.Tracing.TraceSender.Expression_False(10874, 182267, 182496) || (f_10874_182424_182437(argument) == BoundKind.DiscardExpression && (DynAbs.Tracing.TraceSender.Expression_True(10874, 182424, 182495) && (object)argType == null))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 182263, 182713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 182530, 182571);

                    f_10874_182530_182570(argRefKind != RefKind.None);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 182671, 182698);

                    return Conversion.Identity;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 182263, 182713);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 182729, 183308) || true) && (argRefKind == RefKind.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 182729, 183308);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 182793, 183109);

                    var
                    conversion = (DynAbs.Tracing.TraceSender.Conditional_F1(10874, 182810, 182835) || ((forExtensionMethodThisArg && DynAbs.Tracing.TraceSender.Conditional_F2(10874, 182859, 182983)) || DynAbs.Tracing.TraceSender.Conditional_F3(10874, 183007, 183108))) ? f_10874_182859_182983(f_10874_182859_182870(), argument, f_10874_182930_182943(argument), parameterType, ref useSiteDiagnostics) : f_10874_183007_183108(f_10874_183007_183018(), argument, parameterType, ref useSiteDiagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 183127, 183257);

                    f_10874_183127_183256((f_10874_183141_183159_M(!conversion.Exists)) || (DynAbs.Tracing.TraceSender.Expression_False(10874, 183140, 183185) || conversion.IsImplicit), "ClassifyImplicitConversion should only return implicit conversions");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 183275, 183293);

                    return conversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 182729, 183308);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 183324, 183585) || true) && ((object)argType != null && (DynAbs.Tracing.TraceSender.Expression_True(10874, 183328, 183412) && f_10874_183355_183412(argType, parameterType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 183324, 183585);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 183446, 183473);

                    return Conversion.Identity;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 183324, 183585);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 183324, 183585);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 183539, 183570);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 183324, 183585);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10874, 180058, 183596);

                bool
                f_10874_181390_181415(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.HasDynamicType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 181390, 181415);
                    return return_v;
                }


                bool
                f_10874_181984_182064(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbol
                parameterContainer)
                {
                    var return_v = type.ContainsTypeParameter(parameterContainer: (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)parameterContainer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 181984, 182064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10874_182235_182248(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 182235, 182248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10874_182267_182280(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 182267, 182280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10874_182342_182355(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 182342, 182355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10874_182424_182437(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 182424, 182437);
                    return return_v;
                }


                int
                f_10874_182530_182570(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 182530, 182570);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10874_182859_182870()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 182859, 182870);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10874_182930_182943(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 182930, 182943);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10874_182859_182983(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpressionOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                sourceType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitExtensionMethodThisArgConversion(sourceExpressionOpt, sourceType, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 182859, 182983);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10874_183007_183018()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 183007, 183018);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10874_183007_183108(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 183007, 183108);
                    return return_v;
                }


                bool
                f_10874_183141_183159_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 183141, 183159);
                    return return_v;
                }


                int
                f_10874_183127_183256(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 183127, 183256);
                    return 0;
                }


                bool
                f_10874_183355_183412(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = Conversions.HasIdentityConversion(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 183355, 183412);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 180058, 183596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 180058, 183596);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TMember GetConstructedFrom<TMember>(TMember member) where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10874, 183608, 184092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 183722, 184081);

                switch (f_10874_183730_183741<TMember>(member))
                {

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 183722, 184081);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 183822, 183836);

                        return member;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 183722, 184081);

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 183722, 184081);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 183899, 183964);

                        return (TMember)(Symbol)f_10874_183923_183963<TMember>((member as MethodSymbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 183722, 184081);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10874, 183722, 184081);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10874, 184012, 184066);

                        throw f_10874_184018_184065<TMember>(f_10874_184053_184064<TMember>(member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10874, 183722, 184081);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10874, 183608, 184092);

                Microsoft.CodeAnalysis.SymbolKind
                f_10874_183730_183741<TMember>(TMember
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 183730, 183741);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10874_183923_183963<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 183923, 183963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10874_184053_184064<TMember>(TMember
                this_param) where TMember : Symbol

                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10874, 184053, 184064);
                    return return_v;
                }


                System.Exception
                f_10874_184018_184065<TMember>(Microsoft.CodeAnalysis.SymbolKind
                o) where TMember : Symbol

                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10874, 184018, 184065);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10874, 183608, 184092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10874, 183608, 184092);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
