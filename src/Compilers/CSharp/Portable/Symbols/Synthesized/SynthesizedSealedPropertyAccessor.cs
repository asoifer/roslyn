// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using Cci = Microsoft.Cci;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed partial class SynthesizedSealedPropertyAccessor : SynthesizedInstanceMethodSymbol
    {
        private readonly PropertySymbol _property;

        private readonly MethodSymbol _overriddenAccessor;

        private readonly ImmutableArray<ParameterSymbol> _parameters;

        public SynthesizedSealedPropertyAccessor(PropertySymbol property, MethodSymbol overriddenAccessor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10688, 1129, 1601);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 976, 985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 1026, 1045);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 1252, 1291);

                f_10688_1252_1290((object)property != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 1305, 1337);

                f_10688_1305_1336(f_10688_1318_1335(property));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 1351, 1400);

                f_10688_1351_1399((object)overriddenAccessor != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 1416, 1437);

                _property = property;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 1451, 1492);

                _overriddenAccessor = overriddenAccessor;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 1506, 1590);

                _parameters = f_10688_1520_1589(overriddenAccessor, this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10688, 1129, 1601);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 1129, 1601);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 1129, 1601);
            }
        }

        internal MethodSymbol OverriddenAccessor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 1678, 1756);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 1714, 1741);

                    return _overriddenAccessor;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 1678, 1756);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 1613, 1767);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 1613, 1767);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 1843, 1926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 1879, 1911);

                    return f_10688_1886_1910(_property);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 1843, 1926);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10688_1886_1910(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10688, 1886, 1910);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 1779, 1937);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 1779, 1937);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 2024, 2113);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 2060, 2098);

                    return ImmutableArray<Location>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 2024, 2113);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 1949, 2124);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 1949, 2124);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 2212, 3906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 2248, 2330);

                    Accessibility
                    overriddenAccessibility = f_10688_2288_2329(_overriddenAccessor)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 2348, 3643);

                    switch (overriddenAccessibility)
                    {

                        case Accessibility.ProtectedOrInternal:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10688, 2348, 3643);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 2486, 3087) || true) && (!f_10688_2491_2574(f_10688_2491_2514(this), f_10688_2535_2573(_overriddenAccessor)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10688, 2486, 3087);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 3029, 3060);

                                return Accessibility.Protected;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10688, 2486, 3087);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10688, 3113, 3119);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10688, 2348, 3643);

                        case Accessibility.ProtectedAndInternal:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10688, 2348, 3643);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 3209, 3592) || true) && (!f_10688_3214_3297(f_10688_3214_3237(this), f_10688_3258_3296(_overriddenAccessor)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10688, 3209, 3592);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 3536, 3565);

                                return Accessibility.Private;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10688, 3209, 3592);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10688, 3618, 3624);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10688, 2348, 3643);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 3663, 3713);

                    HashSet<DiagnosticInfo>
                    useSiteDiagnostics = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 3731, 3842);

                    f_10688_3731_3841(f_10688_3744_3840(_overriddenAccessor, f_10688_3796_3815(this), ref useSiteDiagnostics));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 3860, 3891);

                    return overriddenAccessibility;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 2212, 3906);

                    Microsoft.CodeAnalysis.Accessibility
                    f_10688_2288_2329(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaredAccessibility;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10688, 2288, 2329);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10688_2491_2514(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10688, 2491, 2514);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10688_2535_2573(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10688, 2535, 2573);
                        return return_v;
                    }


                    bool
                    f_10688_2491_2574(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    fromAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    toAssembly)
                    {
                        var return_v = fromAssembly.HasInternalAccessTo(toAssembly);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10688, 2491, 2574);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10688_3214_3237(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10688, 3214, 3237);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10688_3258_3296(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10688, 3258, 3296);
                        return return_v;
                    }


                    bool
                    f_10688_3214_3297(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    fromAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    toAssembly)
                    {
                        var return_v = fromAssembly.HasInternalAccessTo(toAssembly);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10688, 3214, 3297);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10688_3796_3815(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10688, 3796, 3815);
                        return return_v;
                    }


                    bool
                    f_10688_3744_3840(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    symbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    within, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                    useSiteDiagnostics)
                    {
                        var return_v = AccessCheck.IsSymbolAccessible((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, within, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10688, 3744, 3840);
                        return return_v;
                    }


                    int
                    f_10688_3731_3841(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10688, 3731, 3841);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 2136, 3917);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 2136, 3917);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 3983, 4069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 4019, 4032);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 3983, 4069);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 3929, 4080);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 3929, 4080);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 4145, 4209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 4181, 4194);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 4145, 4209);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 4092, 4220);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 4092, 4220);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 4287, 4373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 4323, 4336);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 4287, 4373);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 4232, 4384);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 4232, 4384);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Cci.CallingConvention CallingConvention
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 4478, 4574);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 4514, 4559);

                    return f_10688_4521_4558(_overriddenAccessor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 4478, 4574);

                    Microsoft.Cci.CallingConvention
                    f_10688_4521_4558(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.CallingConvention;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10688, 4521, 4558);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 4396, 4585);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 4396, 4585);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 4659, 4748);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 4695, 4733);

                    return f_10688_4702_4732(_overriddenAccessor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 4659, 4748);

                    Microsoft.CodeAnalysis.MethodKind
                    f_10688_4702_4732(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10688, 4702, 4732);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 4597, 4759);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 4597, 4759);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 4821, 4881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 4857, 4866);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 4821, 4881);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 4771, 4892);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 4771, 4892);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 4967, 5031);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 5003, 5016);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 4967, 5031);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 4904, 5042);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 4904, 5042);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 5122, 5186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 5158, 5171);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 5122, 5186);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 5054, 5197);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 5054, 5197);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 5263, 5350);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 5299, 5335);

                    return f_10688_5306_5334(_overriddenAccessor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 5263, 5350);

                    bool
                    f_10688_5306_5334(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsVararg;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10688, 5306, 5334);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 5209, 5361);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 5209, 5361);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 5430, 5520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 5466, 5505);

                    return f_10688_5473_5504(_overriddenAccessor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 5430, 5520);

                    bool
                    f_10688_5473_5504(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnsVoid;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10688, 5473, 5504);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 5373, 5531);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 5373, 5531);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 5599, 5685);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 5635, 5670);

                    return f_10688_5642_5669(_overriddenAccessor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 5599, 5685);

                    Microsoft.CodeAnalysis.RefKind
                    f_10688_5642_5669(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10688, 5642, 5669);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 5543, 5696);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 5543, 5696);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 5794, 5898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 5830, 5883);

                    return f_10688_5837_5882(_overriddenAccessor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 5794, 5898);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10688_5837_5882(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnTypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10688, 5837, 5882);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 5708, 5909);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 5708, 5909);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 5995, 6026);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 5998, 6026);
                    return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 5995, 6026);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 5995, 6026);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 5995, 6026);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 6112, 6145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 6115, 6145);
                    return ImmutableHashSet<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 6112, 6145);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 6112, 6145);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 6112, 6145);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 6263, 6363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 6299, 6348);

                    return ImmutableArray<TypeWithAnnotations>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 6263, 6363);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 6158, 6374);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 6158, 6374);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 6477, 6577);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 6513, 6562);

                    return ImmutableArray<TypeParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 6477, 6577);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 6386, 6588);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 6386, 6588);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 6683, 6753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 6719, 6738);

                    return _parameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 6683, 6753);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 6600, 6764);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 6600, 6764);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 6857, 6878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 6863, 6876);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 6857, 6878);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 6776, 6889);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 6776, 6889);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 7003, 7096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 7039, 7081);

                    return ImmutableArray<MethodSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 7003, 7096);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 6901, 7107);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 6901, 7107);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 7209, 7306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 7245, 7291);

                    return f_10688_7252_7290(_overriddenAccessor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 7209, 7306);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10688_7252_7290(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10688, 7252, 7290);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 7119, 7317);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 7119, 7317);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol AssociatedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 7393, 7461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 7429, 7446);

                    return _property;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 7393, 7461);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 7329, 7472);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 7329, 7472);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 7540, 7603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 7576, 7588);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 7540, 7603);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 7484, 7614);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 7484, 7614);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 7682, 7746);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 7718, 7731);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 7682, 7746);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 7626, 7757);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 7626, 7757);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 7823, 7886);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 7859, 7871);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 7823, 7886);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 7769, 7897);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 7769, 7897);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 7963, 8027);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 7999, 8012);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 7963, 8027);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 7909, 8038);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 7909, 8038);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 8102, 8185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 8138, 8170);

                    return f_10688_8145_8169(_overriddenAccessor);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 8102, 8185);

                    string
                    f_10688_8145_8169(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10688, 8145, 8169);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 8050, 8196);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 8050, 8196);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 8270, 8333);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 8306, 8318);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 8270, 8333);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 8208, 8344);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 8208, 8344);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 8462, 8568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 8498, 8553);

                    return default(System.Reflection.MethodImplAttributes);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 8462, 8568);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 8356, 8579);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 8356, 8579);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 8591, 8737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 8714, 8726);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 8591, 8737);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 8591, 8737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 8591, 8737);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsMetadataFinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 8812, 8875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 8848, 8860);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 8812, 8875);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 8749, 8886);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 8749, 8886);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsMetadataNewSlot(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 8898, 9045);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 9021, 9034);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 8898, 9045);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 8898, 9045);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 8898, 9045);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool RequiresSecurityObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 9127, 9191);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 9163, 9176);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 9127, 9191);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 9057, 9202);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 9057, 9202);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override DllImportData GetDllImportData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 9214, 9310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 9287, 9299);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 9214, 9310);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 9214, 9310);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 9214, 9310);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override MarshalPseudoCustomAttributeData ReturnValueMarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 9431, 9451);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 9437, 9449);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 9431, 9451);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 9322, 9462);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 9322, 9462);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 9544, 9565);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 9550, 9563);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 9544, 9565);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 9474, 9576);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 9474, 9576);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override IEnumerable<Microsoft.Cci.SecurityAttribute> GetSecurityInformation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 9588, 9748);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 9700, 9737);

                throw f_10688_9706_9736();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 9588, 9748);

                System.Exception
                f_10688_9706_9736()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10688, 9706, 9736);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 9588, 9748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 9588, 9748);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<string> GetAppliedConditionalSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10688, 9760, 9903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10688, 9856, 9892);

                return ImmutableArray<string>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10688, 9760, 9903);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10688, 9760, 9903);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10688, 9760, 9903);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int
        f_10688_1252_1290(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10688, 1252, 1290);
            return 0;
        }


        bool
        f_10688_1318_1335(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        this_param)
        {
            var return_v = this_param.IsSealed;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10688, 1318, 1335);
            return return_v;
        }


        int
        f_10688_1305_1336(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10688, 1305, 1336);
            return 0;
        }


        int
        f_10688_1351_1399(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10688, 1351, 1399);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_10688_1520_1589(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        sourceMethod, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor
        destinationMethod)
        {
            var return_v = SynthesizedParameterSymbol.DeriveParameters(sourceMethod, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)destinationMethod);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10688, 1520, 1589);
            return return_v;
        }

    }
}
