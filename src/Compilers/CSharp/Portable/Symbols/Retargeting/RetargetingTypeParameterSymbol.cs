// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using System.Diagnostics;
using System.Globalization;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting
{
    internal sealed class RetargetingTypeParameterSymbol
            : WrappedTypeParameterSymbol
    {
        private readonly RetargetingModuleSymbol _retargetingModule;

        private ImmutableArray<CSharpAttributeData> _lazyCustomAttributes;

        public RetargetingTypeParameterSymbol(RetargetingModuleSymbol retargetingModule, TypeParameterSymbol underlyingTypeParameter)
        : base(f_10604_1534_1557_C(underlyingTypeParameter))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10604, 1388, 1786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10604, 1190, 1208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10604, 1583, 1631);

                f_10604_1583_1630((object)retargetingModule != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10604, 1645, 1720);

                f_10604_1645_1719(!(underlyingTypeParameter is RetargetingTypeParameterSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10604, 1736, 1775);

                _retargetingModule = retargetingModule;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10604, 1388, 1786);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10604, 1388, 1786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10604, 1388, 1786);
            }
        }

        private RetargetingModuleSymbol.RetargetingSymbolTranslator RetargetingTranslator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10604, 1904, 2003);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10604, 1940, 1988);

                    return _retargetingModule.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10604, 1904, 2003);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10604, 1798, 2014);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10604, 1798, 2014);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10604, 2090, 2227);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10604, 2126, 2212);

                    return f_10604_2133_2211(f_10604_2133_2159(this), f_10604_2169_2210(_underlyingTypeParameter));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10604, 2090, 2227);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    f_10604_2133_2159(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingTranslator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10604, 2133, 2159);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10604_2169_2210(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10604, 2169, 2210);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10604_2133_2211(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    symbol)
                    {
                        var return_v = this_param.Retarget(symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10604, 2133, 2211);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10604, 2026, 2238);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10604, 2026, 2238);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10604, 2250, 2480);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10604, 2342, 2469);

                return f_10604_2349_2468(f_10604_2349_2375(this), f_10604_2400_2440(_underlyingTypeParameter), ref _lazyCustomAttributes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10604, 2250, 2480);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10604_2349_2375(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingTypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10604, 2349, 2375);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10604_2400_2440(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10604, 2400, 2440);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10604_2349_2468(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                underlyingAttributes, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                lazyCustomAttributes)
                {
                    var return_v = this_param.GetRetargetedAttributes(underlyingAttributes, ref lazyCustomAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10604, 2349, 2468);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10604, 2250, 2480);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10604, 2250, 2480);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AssemblySymbol ContainingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10604, 2566, 2662);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10604, 2602, 2647);

                    return f_10604_2609_2646(_retargetingModule);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10604, 2566, 2662);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10604_2609_2646(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10604, 2609, 2646);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10604, 2492, 2673);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10604, 2492, 2673);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ModuleSymbol ContainingModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10604, 2757, 2834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10604, 2793, 2819);

                    return _retargetingModule;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10604, 2757, 2834);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10604, 2685, 2845);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10604, 2685, 2845);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<TypeWithAnnotations> GetConstraintTypes(ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10604, 2857, 3107);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10604, 2996, 3096);

                return f_10604_3003_3095(f_10604_3003_3029(this), f_10604_3039_3094(_underlyingTypeParameter, inProgress));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10604, 2857, 3107);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10604_3003_3029(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingTypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10604, 3003, 3029);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10604_3039_3094(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.GetConstraintTypes(inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10604, 3039, 3094);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10604_3003_3095(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                sequence)
                {
                    var return_v = this_param.Retarget(sequence);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10604, 3003, 3095);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10604, 2857, 3107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10604, 2857, 3107);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool? IsNotNullable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10604, 3181, 3278);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10604, 3217, 3263);

                    return f_10604_3224_3262(_underlyingTypeParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10604, 3181, 3278);

                    bool?
                    f_10604_3224_3262(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsNotNullable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10604, 3224, 3262);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10604, 3119, 3289);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10604, 3119, 3289);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<NamedTypeSymbol> GetInterfaces(ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10604, 3301, 3537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10604, 3431, 3526);

                return f_10604_3438_3525(f_10604_3438_3464(this), f_10604_3474_3524(_underlyingTypeParameter, inProgress));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10604, 3301, 3537);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10604_3438_3464(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingTypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10604, 3438, 3464);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10604_3474_3524(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.GetInterfaces(inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10604, 3474, 3524);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10604_3438_3525(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                sequence)
                {
                    var return_v = this_param.Retarget(sequence);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10604, 3438, 3525);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10604, 3301, 3537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10604, 3301, 3537);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol GetEffectiveBaseClass(ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10604, 3549, 3835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10604, 3671, 3824);

                return f_10604_3678_3823(f_10604_3678_3704(this), f_10604_3714_3772(_underlyingTypeParameter, inProgress), RetargetOptions.RetargetPrimitiveTypesByTypeCode);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10604, 3549, 3835);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10604_3678_3704(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingTypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10604, 3678, 3704);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10604_3714_3772(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.GetEffectiveBaseClass(inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10604, 3714, 3772);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10604_3678_3823(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                options)
                {
                    var return_v = this_param.Retarget(type, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10604, 3678, 3823);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10604, 3549, 3835);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10604, 3549, 3835);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol GetDeducedBaseType(ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10604, 3847, 4122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10604, 3961, 4111);

                return f_10604_3968_4110(f_10604_3968_3994(this), f_10604_4004_4059(_underlyingTypeParameter, inProgress), RetargetOptions.RetargetPrimitiveTypesByTypeCode);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10604, 3847, 4122);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10604_3968_3994(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingTypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10604, 3968, 3994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10604_4004_4059(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.GetDeducedBaseType(inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10604, 4004, 4059);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10604_3968_4110(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                options)
                {
                    var return_v = this_param.Retarget(symbol, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10604, 3968, 4110);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10604, 3847, 4122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10604, 3847, 4122);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override CSharpCompilation DeclaringCompilation // perf, not correctness
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10604, 4247, 4267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10604, 4253, 4265);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10604, 4247, 4267);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10604, 4134, 4278);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10604, 4134, 4278);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static RetargetingTypeParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10604, 950, 4285);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10604, 950, 4285);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10604, 950, 4285);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10604, 950, 4285);

        int
        f_10604_1583_1630(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10604, 1583, 1630);
            return 0;
        }


        int
        f_10604_1645_1719(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10604, 1645, 1719);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
        f_10604_1534_1557_C(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10604, 1388, 1786);
            return return_v;
        }

    }
}
