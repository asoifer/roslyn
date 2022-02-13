// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SynthesizedRecordObjectMethod : SynthesizedRecordOrdinaryMethod
    {
        protected SynthesizedRecordObjectMethod(SourceMemberContainerTypeSymbol containingType, string name, int memberOffset, DiagnosticBag diagnostics)
        : base(f_10728_712_726_C(containingType), name, hasBody: true, memberOffset, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10728, 546, 797);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10728, 546, 797);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10728, 546, 797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10728, 546, 797);
            }
        }

        protected sealed override DeclarationModifiers MakeDeclarationModifiers(DeclarationModifiers allowedModifiers, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10728, 809, 1168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10728, 971, 1067);

                const DeclarationModifiers
                result = DeclarationModifiers.Public | DeclarationModifiers.Override
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10728, 1081, 1129);

                f_10728_1081_1128((result & ~allowedModifiers) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10728, 1143, 1157);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10728, 809, 1168);

                int
                f_10728_1081_1128(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10728, 1081, 1128);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10728, 809, 1168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10728, 809, 1168);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected sealed override void MethodChecks(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10728, 1180, 1406);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10728, 1275, 1306);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.MethodChecks(diagnostics), 10728, 1275, 1305);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10728, 1320, 1395);

                f_10728_1320_1394(this, f_10728_1358_1380(f_10728_1358_1368()), diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10728, 1180, 1406);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10728_1358_1368()
                {
                    var return_v = ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10728, 1358, 1368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10728_1358_1380(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10728, 1358, 1380);
                    return return_v;
                }


                bool
                f_10728_1320_1394(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordObjectMethod
                overriding, Microsoft.CodeAnalysis.SpecialType
                returnSpecialType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = VerifyOverridesMethodFromObject((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)overriding, returnSpecialType, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10728, 1320, 1394);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10728, 1180, 1406);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10728, 1180, 1406);
            }
        }

        internal static bool VerifyOverridesMethodFromObject(MethodSymbol overriding, SpecialType returnSpecialType, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10728, 1512, 2824);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10728, 1672, 1699);

                bool
                reportAnError = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10728, 1715, 2594) || true) && (f_10728_1719_1741_M(!overriding.IsOverride))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10728, 1715, 2594);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10728, 1775, 1796);

                    reportAnError = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10728, 1715, 2594);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10728, 1715, 2594);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10728, 1862, 1927);

                    var
                    overridden = f_10728_1879_1926_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10728_1879_1906(overriding), 10728, 1879, 1926)?.OriginalDefinition)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10728, 1947, 2579) || true) && (overridden is object && (DynAbs.Tracing.TraceSender.Expression_True(10728, 1951, 2119) && !(f_10728_1977_2002(overridden) is SourceMemberContainerTypeSymbol { IsRecord: true } && (DynAbs.Tracing.TraceSender.Expression_True(10728, 1977, 2118) && f_10728_2060_2087(overridden) == f_10728_2091_2118(overriding)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10728, 1947, 2579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10728, 2161, 2252);

                        MethodSymbol
                        leastOverridden = f_10728_2192_2251(overriding, accessingTypeOpt: null)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10728, 2276, 2560);

                        reportAnError = f_10728_2292_2382(f_10728_2292_2318(leastOverridden), f_10728_2326_2347(overriding), TypeCompareKind.AllIgnoreOptions) && (DynAbs.Tracing.TraceSender.Expression_True(10728, 2292, 2559) && (f_10728_2424_2466(f_10728_2424_2454(leastOverridden)) != SpecialType.System_Object || (DynAbs.Tracing.TraceSender.Expression_False(10728, 2424, 2558) || returnSpecialType != f_10728_2520_2558(f_10728_2520_2546(leastOverridden)))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10728, 1947, 2579);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10728, 1715, 2594);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10728, 2610, 2776) || true) && (reportAnError)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10728, 2610, 2776);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10728, 2661, 2761);

                    f_10728_2661_2760(diagnostics, ErrorCode.ERR_DoesNotOverrideMethodFromObject, f_10728_2724_2744(overriding)[0], overriding);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10728, 2610, 2776);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10728, 2792, 2813);

                return reportAnError;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10728, 1512, 2824);

                bool
                f_10728_1719_1741_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10728, 1719, 1741);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10728_1879_1906(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10728, 1879, 1906);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10728_1879_1926_M(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10728, 1879, 1926);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10728_1977_2002(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10728, 1977, 2002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10728_2060_2087(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10728, 2060, 2087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10728_2091_2118(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10728, 2091, 2118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10728_2192_2251(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                accessingTypeOpt)
                {
                    var return_v = this_param.GetLeastOverriddenMethod(accessingTypeOpt: accessingTypeOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10728, 2192, 2251);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10728_2292_2318(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10728, 2292, 2318);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10728_2326_2347(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10728, 2326, 2347);
                    return return_v;
                }


                bool
                f_10728_2292_2382(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10728, 2292, 2382);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10728_2424_2454(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10728, 2424, 2454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10728_2424_2466(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10728, 2424, 2466);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10728_2520_2546(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10728, 2520, 2546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10728_2520_2558(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10728, 2520, 2558);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10728_2724_2744(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10728, 2724, 2744);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10728_2661_2760(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10728, 2661, 2760);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10728, 1512, 2824);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10728, 1512, 2824);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SynthesizedRecordObjectMethod()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10728, 442, 2831);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10728, 442, 2831);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10728, 442, 2831);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10728, 442, 2831);

        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        f_10728_712_726_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10728, 546, 797);
            return return_v;
        }

    }
}
