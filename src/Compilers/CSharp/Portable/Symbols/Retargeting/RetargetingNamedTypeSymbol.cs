// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting
{
    internal sealed class RetargetingNamedTypeSymbol : WrappedNamedTypeSymbol
    {
        private readonly RetargetingModuleSymbol _retargetingModule;

        private ImmutableArray<TypeParameterSymbol> _lazyTypeParameters;

        private NamedTypeSymbol _lazyBaseType;

        private ImmutableArray<NamedTypeSymbol> _lazyInterfaces;

        private NamedTypeSymbol _lazyDeclaredBaseType;

        private ImmutableArray<NamedTypeSymbol> _lazyDeclaredInterfaces;

        private ImmutableArray<CSharpAttributeData> _lazyCustomAttributes;

        private DiagnosticInfo _lazyUseSiteDiagnostic;

        public RetargetingNamedTypeSymbol(RetargetingModuleSymbol retargetingModule, NamedTypeSymbol underlyingType, TupleExtraData tupleData = null)
        : base(f_10599_2083_2097_C(underlyingType), tupleData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10599, 1921, 2324);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 1252, 1270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 1383, 1432);
                this._lazyBaseType = ErrorTypeSymbol.UnknownResultType; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 1483, 1541);
                this._lazyInterfaces = default(ImmutableArray<NamedTypeSymbol>); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 1578, 1635);
                this._lazyDeclaredBaseType = ErrorTypeSymbol.UnknownResultType; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 1823, 1879);
                this._lazyUseSiteDiagnostic = CSDiagnosticInfo.EmptyErrorInfo; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 2134, 2182);

                f_10599_2134_2181((object)retargetingModule != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 2196, 2258);

                f_10599_2196_2257(!(underlyingType is RetargetingNamedTypeSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 2274, 2313);

                _retargetingModule = retargetingModule;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10599, 1921, 2324);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 1921, 2324);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 1921, 2324);
            }
        }

        protected override NamedTypeSymbol WithTupleDataCore(TupleExtraData newData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 2336, 2532);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 2437, 2521);

                return f_10599_2444_2520(_retargetingModule, _underlyingType, newData);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 2336, 2532);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                f_10599_2444_2520(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                retargetingModule, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                underlyingType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
                tupleData)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol(retargetingModule, underlyingType, tupleData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 2444, 2520);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 2336, 2532);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 2336, 2532);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private RetargetingModuleSymbol.RetargetingSymbolTranslator RetargetingTranslator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 2650, 2749);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 2686, 2734);

                    return _retargetingModule.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 2650, 2749);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 2544, 2760);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 2544, 2760);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 2863, 3526);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 2899, 3464) || true) && (_lazyTypeParameters.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10599, 2899, 3464);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 2974, 3445) || true) && (f_10599_2978_2988(this) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10599, 2974, 3445);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 3043, 3107);

                            _lazyTypeParameters = ImmutableArray<TypeParameterSymbol>.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10599, 2974, 3445);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10599, 2974, 3445);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 3205, 3422);

                            f_10599_3205_3421(ref _lazyTypeParameters, f_10599_3307_3374(f_10599_3307_3333(this), f_10599_3343_3373(_underlyingType)), default(ImmutableArray<TypeParameterSymbol>));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10599, 2974, 3445);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10599, 2899, 3464);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 3484, 3511);

                    return _lazyTypeParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 2863, 3526);

                    int
                    f_10599_2978_2988(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 2978, 2988);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    f_10599_3307_3333(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingTranslator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 3307, 3333);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10599_3343_3373(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 3343, 3373);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10599_3307_3374(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    list)
                    {
                        var return_v = this_param.Retarget(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 3307, 3374);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10599_3205_3421(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    comparand)
                    {
                        var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 3205, 3421);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 2772, 3537);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 2772, 3537);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotationsNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 3676, 3882);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 3825, 3867);

                    return f_10599_3832_3866(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 3676, 3882);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10599_3832_3866(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetTypeParametersAsTypeArguments();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 3832, 3866);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 3549, 3893);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 3549, 3893);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override NamedTypeSymbol ConstructedFrom
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 3977, 4040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 4013, 4025);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 3977, 4040);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 3905, 4051);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 3905, 4051);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override NamedTypeSymbol EnumUnderlyingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 4138, 4433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 4174, 4226);

                    var
                    underlying = f_10599_4191_4225(_underlyingType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 4244, 4385);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10599, 4251, 4277) || (((object)underlying == null && DynAbs.Tracing.TraceSender.Conditional_F2(10599, 4280, 4284)) || DynAbs.Tracing.TraceSender.Conditional_F3(10599, 4287, 4384))) ? null : f_10599_4287_4384(f_10599_4287_4313(this), underlying, RetargetOptions.RetargetPrimitiveTypesByTypeCode);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 4138, 4433);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10599_4191_4225(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.EnumUnderlyingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 4191, 4225);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    f_10599_4287_4313(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingTranslator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 4287, 4313);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10599_4287_4384(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.Retarget(type, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 4287, 4384);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 4063, 4444);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 4063, 4444);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override IEnumerable<string> MemberNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 4528, 4614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 4564, 4599);

                    return f_10599_4571_4598(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 4528, 4614);

                    System.Collections.Generic.IEnumerable<string>
                    f_10599_4571_4598(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.MemberNames;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 4571, 4598);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 4456, 4625);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 4456, 4625);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Symbol> GetMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 4637, 4797);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 4713, 4786);

                return f_10599_4720_4785(f_10599_4720_4746(this), f_10599_4756_4784(_underlyingType));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 4637, 4797);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10599_4720_4746(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 4720, 4746);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10599_4756_4784(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 4756, 4784);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10599_4720_4785(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                arr)
                {
                    var return_v = this_param.Retarget(arr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 4720, 4785);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 4637, 4797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 4637, 4797);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<Symbol> GetMembersUnordered()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 4809, 4989);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 4896, 4978);

                return f_10599_4903_4977(f_10599_4903_4929(this), f_10599_4939_4976(_underlyingType));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 4809, 4989);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10599_4903_4929(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 4903, 4929);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10599_4939_4976(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 4939, 4976);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10599_4903_4977(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                arr)
                {
                    var return_v = this_param.Retarget(arr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 4903, 4977);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 4809, 4989);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 4809, 4989);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Symbol> GetMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 5001, 5176);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 5088, 5165);

                return f_10599_5095_5164(f_10599_5095_5121(this), f_10599_5131_5163(_underlyingType, name));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 5001, 5176);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10599_5095_5121(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 5095, 5121);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10599_5131_5163(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 5131, 5163);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10599_5095_5164(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                arr)
                {
                    var return_v = this_param.Retarget(arr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 5095, 5164);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 5001, 5176);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 5001, 5176);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<FieldSymbol> GetFieldsToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 5188, 5444);

                var listYield = new List<FieldSymbol>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 5273, 5433);
                    foreach (FieldSymbol f in f_10599_5299_5332_I(f_10599_5299_5332(_underlyingType)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10599, 5273, 5433);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 5366, 5418);

                        listYield.Add(f_10599_5379_5417(f_10599_5379_5405(this), f));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10599, 5273, 5433);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10599, 1, 161);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10599, 1, 161);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 5188, 5444);

                return listYield;

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10599_5299_5332(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetFieldsToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 5299, 5332);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10599_5379_5405(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 5379, 5405);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10599_5379_5417(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                field)
                {
                    var return_v = this_param.Retarget(field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 5379, 5417);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10599_5299_5332_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 5299, 5332);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 5188, 5444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 5188, 5444);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<MethodSymbol> GetMethodsToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 5456, 6308);

                var listYield = new List<MethodSymbol>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 5543, 5596);

                bool
                isInterface = f_10599_5562_5595(_underlyingType)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 5612, 6297);
                    foreach (MethodSymbol method in f_10599_5644_5678_I(f_10599_5644_5678(_underlyingType)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10599, 5612, 6297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 5712, 5749);

                        f_10599_5712_5748((object)method != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 5769, 5879);

                        int
                        gapSize = (DynAbs.Tracing.TraceSender.Conditional_F1(10599, 5783, 5794) || ((isInterface && DynAbs.Tracing.TraceSender.Conditional_F2(10599, 5797, 5874)) || DynAbs.Tracing.TraceSender.Conditional_F3(10599, 5877, 5878))) ? f_10599_5797_5874(f_10599_5854_5873(method)) : 0
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 5897, 6282) || true) && (gapSize > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10599, 5897, 6282);
                            {
                                try
                                {
                                    do

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10599, 5954, 6124);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 6005, 6023);

                                        listYield.Add(null);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 6049, 6059);

                                        gapSize--;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10599, 5954, 6124);
                                    }
                                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 5954, 6124) || true) && (gapSize > 0)
                                    );
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10599, 5954, 6124);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10599, 5954, 6124);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10599, 5897, 6282);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10599, 5897, 6282);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 6206, 6263);

                            listYield.Add(f_10599_6219_6262(f_10599_6219_6245(this), method));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10599, 5897, 6282);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10599, 5612, 6297);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10599, 1, 686);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10599, 1, 686);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 5456, 6308);

                return listYield;

                bool
                f_10599_5562_5595(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 5562, 5595);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10599_5644_5678(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMethodsToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 5644, 5678);
                    return return_v;
                }


                int
                f_10599_5712_5748(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 5712, 5748);
                    return 0;
                }


                string
                f_10599_5854_5873(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MetadataName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 5854, 5873);
                    return return_v;
                }


                int
                f_10599_5797_5874(string
                emittedMethodName)
                {
                    var return_v = Microsoft.CodeAnalysis.ModuleExtensions.GetVTableGapSize(emittedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 5797, 5874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10599_6219_6245(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 6219, 6245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10599_6219_6262(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.Retarget(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 6219, 6262);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10599_5644_5678_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 5644, 5678);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 5456, 6308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 5456, 6308);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<PropertySymbol> GetPropertiesToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 6320, 6590);

                var listYield = new List<PropertySymbol>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 6412, 6579);
                    foreach (PropertySymbol p in f_10599_6441_6478_I(f_10599_6441_6478(_underlyingType)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10599, 6412, 6579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 6512, 6564);

                        listYield.Add(f_10599_6525_6563(f_10599_6525_6551(this), p));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10599, 6412, 6579);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10599, 1, 168);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10599, 1, 168);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 6320, 6590);

                return listYield;

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                f_10599_6441_6478(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetPropertiesToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 6441, 6478);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10599_6525_6551(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 6525, 6551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10599_6525_6563(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = this_param.Retarget(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 6525, 6563);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                f_10599_6441_6478_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 6441, 6478);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 6320, 6590);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 6320, 6590);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<EventSymbol> GetEventsToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 6602, 6858);

                var listYield = new List<EventSymbol>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 6687, 6847);
                    foreach (EventSymbol e in f_10599_6713_6746_I(f_10599_6713_6746(_underlyingType)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10599, 6687, 6847);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 6780, 6832);

                        listYield.Add(f_10599_6793_6831(f_10599_6793_6819(this), e));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10599, 6687, 6847);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10599, 1, 161);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10599, 1, 161);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 6602, 6858);

                return listYield;

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                f_10599_6713_6746(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetEventsToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 6713, 6746);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10599_6793_6819(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 6793, 6819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10599_6793_6831(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                @event)
                {
                    var return_v = this_param.Retarget(@event);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 6793, 6831);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                f_10599_6713_6746_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 6713, 6746);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 6602, 6858);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 6602, 6858);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<Symbol> GetEarlyAttributeDecodingMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 6870, 7076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 6970, 7065);

                return f_10599_6977_7064(f_10599_6977_7003(this), f_10599_7013_7063(_underlyingType));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 6870, 7076);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10599_6977_7003(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 6977, 7003);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10599_7013_7063(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetEarlyAttributeDecodingMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 7013, 7063);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10599_6977_7064(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                arr)
                {
                    var return_v = this_param.Retarget(arr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 6977, 7064);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 6870, 7076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 6870, 7076);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<Symbol> GetEarlyAttributeDecodingMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 7088, 7309);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 7199, 7298);

                return f_10599_7206_7297(f_10599_7206_7232(this), f_10599_7242_7296(_underlyingType, name));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 7088, 7309);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10599_7206_7232(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 7206, 7232);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10599_7242_7296(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetEarlyAttributeDecodingMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 7242, 7296);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10599_7206_7297(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                arr)
                {
                    var return_v = this_param.Retarget(arr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 7206, 7297);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 7088, 7309);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 7088, 7309);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<NamedTypeSymbol> GetTypeMembersUnordered()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 7321, 7518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 7421, 7507);

                return f_10599_7428_7506(f_10599_7428_7454(this), f_10599_7464_7505(_underlyingType));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 7321, 7518);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10599_7428_7454(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 7428, 7454);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10599_7464_7505(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 7464, 7505);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10599_7428_7506(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                sequence)
                {
                    var return_v = this_param.Retarget(sequence);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 7428, 7506);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 7321, 7518);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 7321, 7518);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 7530, 7707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 7619, 7696);

                return f_10599_7626_7695(f_10599_7626_7652(this), f_10599_7662_7694(_underlyingType));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 7530, 7707);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10599_7626_7652(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 7626, 7652);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10599_7662_7694(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 7662, 7694);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10599_7626_7695(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                sequence)
                {
                    var return_v = this_param.Retarget(sequence);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 7626, 7695);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 7530, 7707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 7530, 7707);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 7719, 7911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 7819, 7900);

                return f_10599_7826_7899(f_10599_7826_7852(this), f_10599_7862_7898(_underlyingType, name));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 7719, 7911);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10599_7826_7852(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 7826, 7852);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10599_7862_7898(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 7862, 7898);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10599_7826_7899(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                sequence)
                {
                    var return_v = this_param.Retarget(sequence);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 7826, 7899);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 7719, 7911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 7719, 7911);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name, int arity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 7923, 8133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 8034, 8122);

                return f_10599_8041_8121(f_10599_8041_8067(this), f_10599_8077_8120(_underlyingType, name, arity));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 7923, 8133);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10599_8041_8067(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 8041, 8067);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10599_8077_8120(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 8077, 8120);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10599_8041_8121(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                sequence)
                {
                    var return_v = this_param.Retarget(sequence);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 8041, 8121);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 7923, 8133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 7923, 8133);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 8209, 8337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 8245, 8322);

                    return f_10599_8252_8321(f_10599_8252_8278(this), f_10599_8288_8320(_underlyingType));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 8209, 8337);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    f_10599_8252_8278(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingTranslator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 8252, 8278);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10599_8288_8320(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 8288, 8320);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10599_8252_8321(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    symbol)
                    {
                        var return_v = this_param.Retarget(symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 8252, 8321);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 8145, 8348);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 8145, 8348);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 8360, 8581);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 8452, 8570);

                return f_10599_8459_8569(f_10599_8459_8485(this), f_10599_8510_8541(_underlyingType), ref _lazyCustomAttributes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 8360, 8581);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10599_8459_8485(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 8459, 8485);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10599_8510_8541(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 8510, 8541);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10599_8459_8569(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                underlyingAttributes, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                lazyCustomAttributes)
                {
                    var return_v = this_param.GetRetargetedAttributes(underlyingAttributes, ref lazyCustomAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 8459, 8569);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 8360, 8581);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 8360, 8581);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<CSharpAttributeData> GetCustomAttributesToEmit(PEModuleBuilder moduleBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 8593, 8847);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 8725, 8836);

                return f_10599_8732_8835(f_10599_8732_8758(this), f_10599_8778_8834(_underlyingType, moduleBuilder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 8593, 8847);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10599_8732_8758(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 8732, 8758);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10599_8778_8834(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder)
                {
                    var return_v = this_param.GetCustomAttributesToEmit(moduleBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 8778, 8834);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10599_8732_8835(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                attributes)
                {
                    var return_v = this_param.RetargetAttributes(attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 8732, 8835);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 8593, 8847);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 8593, 8847);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AssemblySymbol ContainingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 8933, 9029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 8969, 9014);

                    return f_10599_8976_9013(_retargetingModule);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 8933, 9029);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10599_8976_9013(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 8976, 9013);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 8859, 9040);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 8859, 9040);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 9124, 9201);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 9160, 9186);

                    return _retargetingModule;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 9124, 9201);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 9052, 9212);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 9052, 9212);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override NamedTypeSymbol LookupMetadataType(ref MetadataTypeName typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 9224, 9482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 9332, 9471);

                return f_10599_9339_9470(f_10599_9339_9365(this), f_10599_9375_9423(_underlyingType, ref typeName), RetargetOptions.RetargetPrimitiveTypesByName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 9224, 9482);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10599_9339_9365(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 9339, 9365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10599_9375_9423(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedTypeName)
                {
                    var return_v = this_param.LookupMetadataType(ref emittedTypeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 9375, 9423);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10599_9339_9470(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                options)
                {
                    var return_v = this_param.Retarget(type, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 9339, 9470);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 9224, 9482);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 9224, 9482);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ExtendedErrorTypeSymbol CyclicInheritanceError(RetargetingNamedTypeSymbol type, TypeSymbol declaredBase)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10599, 9494, 9846);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 9638, 9726);

                var
                info = f_10599_9649_9725(ErrorCode.ERR_ImportedCircularBase, declaredBase, type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 9740, 9835);

                return f_10599_9747_9834(declaredBase, LookupResultKind.NotReferencable, info, true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10599, 9494, 9846);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10599_9649_9725(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 9649, 9725);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10599_9747_9834(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                guessSymbol, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                errorInfo, bool
                unreported)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)guessSymbol, resultKind, (Microsoft.CodeAnalysis.DiagnosticInfo)errorInfo, unreported);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 9747, 9834);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 9494, 9846);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 9494, 9846);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol BaseTypeNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 9945, 11133);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 9981, 11077) || true) && (f_10599_9985_10050(_lazyBaseType, ErrorTypeSymbol.UnknownResultType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10599, 9981, 11077);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 10092, 10148);

                        NamedTypeSymbol
                        acyclicBase = f_10599_10122_10147(this, null)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 10172, 10709) || true) && ((object)acyclicBase == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10599, 10172, 10709);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 10363, 10429);

                            var
                            underlyingBase = f_10599_10384_10428(_underlyingType)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 10455, 10686) || true) && ((object)underlyingBase != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10599, 10455, 10686);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 10547, 10659);

                                acyclicBase = f_10599_10561_10658(f_10599_10561_10587(this), underlyingBase, RetargetOptions.RetargetPrimitiveTypesByName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10599, 10455, 10686);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10599, 10172, 10709);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 10733, 10939) || true) && ((object)acyclicBase != null && (DynAbs.Tracing.TraceSender.Expression_True(10599, 10737, 10817) && f_10599_10768_10817(acyclicBase, this)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10599, 10733, 10939);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 10867, 10916);

                            return f_10599_10874_10915(this, acyclicBase);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10599, 10733, 10939);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 10963, 11058);

                        f_10599_10963_11057(ref _lazyBaseType, acyclicBase, ErrorTypeSymbol.UnknownResultType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10599, 9981, 11077);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 11097, 11118);

                    return _lazyBaseType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 9945, 11133);

                    bool
                    f_10599_9985_10050(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 9985, 10050);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10599_10122_10147(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                    this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                    basesBeingResolved)
                    {
                        var return_v = this_param.GetDeclaredBaseType(basesBeingResolved);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 10122, 10147);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10599_10384_10428(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 10384, 10428);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    f_10599_10561_10587(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingTranslator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 10561, 10587);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10599_10561_10658(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.Retarget(type, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 10561, 10658);
                        return return_v;
                    }


                    bool
                    f_10599_10768_10817(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    depends, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                    on)
                    {
                        var return_v = BaseTypeAnalysis.TypeDependsOn(depends, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)on);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 10768, 10817);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                    f_10599_10874_10915(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    declaredBase)
                    {
                        var return_v = CyclicInheritanceError(type, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)declaredBase);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 10874, 10915);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    f_10599_10963_11057(ref Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 10963, 11057);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 9858, 11144);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 9858, 11144);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<NamedTypeSymbol> InterfacesNoUseSiteDiagnostics(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 11156, 12051);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 11302, 12001) || true) && (_lazyInterfaces.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10599, 11302, 12001);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 11365, 11432);

                    var
                    declaredInterfaces = f_10599_11390_11431(this, basesBeingResolved)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 11450, 11647) || true) && (f_10599_11454_11466_M(!IsInterface))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10599, 11450, 11647);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 11602, 11628);

                        return declaredInterfaces;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10599, 11450, 11647);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 11667, 11847);

                    ImmutableArray<NamedTypeSymbol>
                    result = declaredInterfaces
                                        .SelectAsArray(t => BaseTypeAnalysis.TypeDependsOn(t, this) ? CyclicInheritanceError(this, t) : t)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 11867, 11986);

                    f_10599_11867_11985(ref _lazyInterfaces, result, default(ImmutableArray<NamedTypeSymbol>));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10599, 11302, 12001);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 12017, 12040);

                return _lazyInterfaces;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 11156, 12051);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10599_11390_11431(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.GetDeclaredInterfaces(basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 11390, 11431);
                    return return_v;
                }


                bool
                f_10599_11454_11466_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 11454, 11466);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10599_11867_11985(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                comparand)
                {
                    var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 11867, 11985);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 11156, 12051);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 11156, 12051);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<NamedTypeSymbol> GetInterfacesToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 12063, 12252);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 12159, 12241);

                return f_10599_12166_12240(f_10599_12166_12192(this), f_10599_12202_12239(_underlyingType));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 12063, 12252);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10599_12166_12192(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 12166, 12192);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10599_12202_12239(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetInterfacesToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 12202, 12239);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10599_12166_12240(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                sequence)
                {
                    var return_v = this_param.Retarget(sequence);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 12166, 12240);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 12063, 12252);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 12063, 12252);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol GetDeclaredBaseType(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 12264, 12939);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 12383, 12883) || true) && (f_10599_12387_12460(_lazyDeclaredBaseType, ErrorTypeSymbol.UnknownResultType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10599, 12383, 12883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 12494, 12571);

                    var
                    underlyingBase = f_10599_12515_12570(_underlyingType, basesBeingResolved)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 12589, 12746);

                    var
                    declaredBase = (DynAbs.Tracing.TraceSender.Conditional_F1(10599, 12608, 12638) || (((object)underlyingBase != null && DynAbs.Tracing.TraceSender.Conditional_F2(10599, 12641, 12738)) || DynAbs.Tracing.TraceSender.Conditional_F3(10599, 12741, 12745))) ? f_10599_12641_12738(f_10599_12641_12667(this), underlyingBase, RetargetOptions.RetargetPrimitiveTypesByName) : null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 12764, 12868);

                    f_10599_12764_12867(ref _lazyDeclaredBaseType, declaredBase, ErrorTypeSymbol.UnknownResultType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10599, 12383, 12883);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 12899, 12928);

                return _lazyDeclaredBaseType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 12264, 12939);

                bool
                f_10599_12387_12460(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 12387, 12460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10599_12515_12570(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.GetDeclaredBaseType(basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 12515, 12570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10599_12641_12667(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 12641, 12667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10599_12641_12738(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                options)
                {
                    var return_v = this_param.Retarget(type, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 12641, 12738);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10599_12764_12867(ref Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                value, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 12764, 12867);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 12264, 12939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 12264, 12939);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<NamedTypeSymbol> GetDeclaredInterfaces(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 12951, 13559);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 13088, 13501) || true) && (_lazyDeclaredInterfaces.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10599, 13088, 13501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 13159, 13248);

                    var
                    underlyingBaseInterfaces = f_10599_13190_13247(_underlyingType, basesBeingResolved)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 13266, 13341);

                    var
                    result = f_10599_13279_13340(f_10599_13279_13305(this), underlyingBaseInterfaces)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 13359, 13486);

                    f_10599_13359_13485(ref _lazyDeclaredInterfaces, result, default(ImmutableArray<NamedTypeSymbol>));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10599, 13088, 13501);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 13517, 13548);

                return _lazyDeclaredInterfaces;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 12951, 13559);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10599_13190_13247(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.GetDeclaredInterfaces(basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 13190, 13247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10599_13279_13305(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 13279, 13305);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10599_13279_13340(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                sequence)
                {
                    var return_v = this_param.Retarget(sequence);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 13279, 13340);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10599_13359_13485(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                comparand)
                {
                    var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 13359, 13485);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 12951, 13559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 12951, 13559);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override DiagnosticInfo GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 13571, 13887);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 13651, 13830) || true) && (f_10599_13655_13727(_lazyUseSiteDiagnostic, CSDiagnosticInfo.EmptyErrorInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10599, 13651, 13830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 13761, 13815);

                    _lazyUseSiteDiagnostic = f_10599_13786_13814(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10599, 13651, 13830);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 13846, 13876);

                return _lazyUseSiteDiagnostic;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 13571, 13887);

                bool
                f_10599_13655_13727(Microsoft.CodeAnalysis.DiagnosticInfo
                objA, Microsoft.CodeAnalysis.DiagnosticInfo
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 13655, 13727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10599_13786_13814(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.CalculateUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 13786, 13814);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 13571, 13887);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 13571, 13887);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol ComImportCoClass
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 13974, 14233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 14010, 14069);

                    NamedTypeSymbol
                    coClass = f_10599_14036_14068(_underlyingType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 14087, 14218);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10599, 14094, 14117) || (((object)coClass == null && DynAbs.Tracing.TraceSender.Conditional_F2(10599, 14120, 14124)) || DynAbs.Tracing.TraceSender.Conditional_F3(10599, 14127, 14217))) ? null : f_10599_14127_14217(f_10599_14127_14153(this), coClass, RetargetOptions.RetargetPrimitiveTypesByName);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 13974, 14233);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10599_14036_14068(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ComImportCoClass;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 14036, 14068);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    f_10599_14127_14153(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingTranslator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 14127, 14153);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10599_14127_14217(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.Retarget(type, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 14127, 14217);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 13899, 14244);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 13899, 14244);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsComImport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 14315, 14358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 14321, 14356);

                    return f_10599_14328_14355(_underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 14315, 14358);

                    bool
                    f_10599_14328_14355(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsComImport;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 14328, 14355);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 14256, 14369);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 14256, 14369);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override CSharpCompilation DeclaringCompilation // perf, not correctness
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 14494, 14514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 14500, 14512);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 14494, 14514);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 14381, 14525);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 14381, 14525);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 14605, 14650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 14611, 14648);

                    throw f_10599_14617_14647();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 14605, 14650);

                    System.Exception
                    f_10599_14617_14647()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 14617, 14647);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 14537, 14661);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 14537, 14661);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override NamedTypeSymbol AsNativeInteger()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 14732, 14771);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 14735, 14771);
                throw f_10599_14741_14771(); DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 14732, 14771);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 14732, 14771);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 14732, 14771);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10599_14741_14771()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 14741, 14771);
                return return_v;
            }

        }

        internal sealed override NamedTypeSymbol NativeIntegerUnderlyingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 14853, 14860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 14856, 14860);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 14853, 14860);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 14853, 14860);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 14853, 14860);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 14912, 14939);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 14915, 14939);
                    return f_10599_14915_14939(_underlyingType); DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 14912, 14939);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 14912, 14939);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 14912, 14939);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool HasPossibleWellKnownCloneMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10599, 15014, 15066);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10599, 15017, 15066);
                return f_10599_15017_15066(_underlyingType); DynAbs.Tracing.TraceSender.TraceExitMethod(10599, 15014, 15066);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10599, 15014, 15066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 15014, 15066);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10599_15017_15066(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            this_param)
            {
                var return_v = this_param.HasPossibleWellKnownCloneMethod();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 15017, 15066);
                return return_v;
            }

        }

        static RetargetingNamedTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10599, 1029, 15074);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10599, 1029, 15074);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10599, 1029, 15074);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10599, 1029, 15074);

        int
        f_10599_2134_2181(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 2134, 2181);
            return 0;
        }


        int
        f_10599_2196_2257(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10599, 2196, 2257);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10599_2083_2097_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10599, 1921, 2324);
            return return_v;
        }


        bool
        f_10599_14915_14939(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsRecord;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10599, 14915, 14939);
            return return_v;
        }

    }
}
