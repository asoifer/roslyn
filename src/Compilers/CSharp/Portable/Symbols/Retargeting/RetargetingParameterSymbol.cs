// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Emit;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting
{
    internal abstract class RetargetingParameterSymbol : WrappedParameterSymbol
    {
        private ImmutableArray<CustomModifier> _lazyRefCustomModifiers;

        private ImmutableArray<CSharpAttributeData> _lazyCustomAttributes;

        protected RetargetingParameterSymbol(ParameterSymbol underlyingParameter)
        : base(f_10601_1191_1210_C(underlyingParameter))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10601, 1097, 1314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10601, 1236, 1303);

                f_10601_1236_1302(!(underlyingParameter is RetargetingParameterSymbol));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10601, 1097, 1314);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10601, 1097, 1314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10601, 1097, 1314);
            }
        }

        protected abstract RetargetingModuleSymbol RetargetingModule
        {
            get;
        }

        public sealed override TypeWithAnnotations TypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10601, 1525, 1729);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10601, 1561, 1714);

                    return f_10601_1568_1713(f_10601_1568_1590(this).RetargetingTranslator, f_10601_1622_1662(_underlyingParameter), RetargetOptions.RetargetPrimitiveTypesByTypeCode);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10601, 1525, 1729);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                    f_10601_1568_1590(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10601, 1568, 1590);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10601_1622_1662(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10601, 1622, 1662);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10601_1568_1713(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    underlyingType, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.Retarget(underlyingType, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10601, 1568, 1713);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10601, 1438, 1740);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10601, 1438, 1740);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<CustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10601, 1849, 2035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10601, 1885, 2020);

                    return f_10601_1892_2019(f_10601_1892_1909().RetargetingTranslator, f_10601_1950_1989(_underlyingParameter), ref _lazyRefCustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10601, 1849, 2035);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                    f_10601_1892_1909()
                    {
                        var return_v = RetargetingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10601, 1892, 1909);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10601_1950_1989(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10601, 1950, 1989);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10601_1892_2019(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    oldModifiers, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    lazyCustomModifiers)
                    {
                        var return_v = this_param.RetargetModifiers(oldModifiers, ref lazyCustomModifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10601, 1892, 2019);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10601, 1752, 2046);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10601, 1752, 2046);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10601, 2129, 2280);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10601, 2165, 2265);

                    return f_10601_2172_2264(f_10601_2172_2194(this).RetargetingTranslator, f_10601_2226_2263(_underlyingParameter));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10601, 2129, 2280);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                    f_10601_2172_2194(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10601, 2172, 2194);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10601_2226_2263(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10601, 2226, 2263);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10601_2172_2264(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    symbol)
                    {
                        var return_v = this_param.Retarget(symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10601, 2172, 2264);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10601, 2058, 2291);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10601, 2058, 2291);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10601, 2303, 2554);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10601, 2402, 2543);

                return f_10601_2409_2542(f_10601_2409_2431(this).RetargetingTranslator, f_10601_2478_2514(_underlyingParameter), ref _lazyCustomAttributes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10601, 2303, 2554);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                f_10601_2409_2431(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingParameterSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10601, 2409, 2431);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10601_2478_2514(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10601, 2478, 2514);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10601_2409_2542(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                underlyingAttributes, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                lazyCustomAttributes)
                {
                    var return_v = this_param.GetRetargetedAttributes(underlyingAttributes, ref lazyCustomAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10601, 2409, 2542);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10601, 2303, 2554);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10601, 2303, 2554);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override IEnumerable<CSharpAttributeData> GetCustomAttributesToEmit(PEModuleBuilder moduleBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10601, 2566, 2850);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10601, 2705, 2839);

                return f_10601_2712_2838(f_10601_2712_2734(this).RetargetingTranslator, f_10601_2776_2837(_underlyingParameter, moduleBuilder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10601, 2566, 2850);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                f_10601_2712_2734(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingParameterSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10601, 2712, 2734);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10601_2776_2837(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder)
                {
                    var return_v = this_param.GetCustomAttributesToEmit(moduleBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10601, 2776, 2837);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10601_2712_2838(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                attributes)
                {
                    var return_v = this_param.RetargetAttributes(attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10601, 2712, 2838);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10601, 2566, 2850);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10601, 2566, 2850);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override AssemblySymbol ContainingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10601, 2943, 3043);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10601, 2979, 3028);

                    return f_10601_2986_3027(f_10601_2986_3008(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10601, 2943, 3043);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                    f_10601_2986_3008(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10601, 2986, 3008);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10601_2986_3027(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10601, 2986, 3027);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10601, 2862, 3054);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10601, 2862, 3054);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ModuleSymbol ContainingModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10601, 3145, 3226);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10601, 3181, 3211);

                    return f_10601_3188_3210(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10601, 3145, 3226);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                    f_10601_3188_3210(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10601, 3188, 3210);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10601, 3066, 3237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10601, 3066, 3237);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool HasMetadataConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10601, 3328, 3432);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10601, 3364, 3417);

                    return f_10601_3371_3416(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10601, 3328, 3432);

                    bool
                    f_10601_3371_3416(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasMetadataConstantValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10601, 3371, 3416);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10601, 3249, 3443);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10601, 3249, 3443);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsMarshalledExplicitly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10601, 3532, 3634);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10601, 3568, 3619);

                    return f_10601_3575_3618(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10601, 3532, 3634);

                    bool
                    f_10601_3575_3618(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMarshalledExplicitly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10601, 3575, 3618);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10601, 3455, 3645);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10601, 3455, 3645);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override MarshalPseudoCustomAttributeData MarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10601, 3755, 3912);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10601, 3791, 3897);

                    return f_10601_3798_3896(f_10601_3798_3820(this).RetargetingTranslator, f_10601_3852_3895(_underlyingParameter));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10601, 3755, 3912);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                    f_10601_3798_3820(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10601, 3798, 3820);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    f_10601_3852_3895(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.MarshallingInformation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10601, 3852, 3895);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    f_10601_3798_3896(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    marshallingInfo)
                    {
                        var return_v = this_param.Retarget(marshallingInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10601, 3798, 3896);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10601, 3657, 3923);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10601, 3657, 3923);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<byte> MarshallingDescriptor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10601, 4020, 4121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10601, 4056, 4106);

                    return f_10601_4063_4105(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10601, 4020, 4121);

                    System.Collections.Immutable.ImmutableArray<byte>
                    f_10601_4063_4105(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.MarshallingDescriptor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10601, 4063, 4105);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10601, 3935, 4132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10601, 3935, 4132);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10601, 4257, 4277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10601, 4263, 4275);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10601, 4257, 4277);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10601, 4144, 4288);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10601, 4144, 4288);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static RetargetingParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10601, 763, 4295);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10601, 763, 4295);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10601, 763, 4295);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10601, 763, 4295);

        int
        f_10601_1236_1302(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10601, 1236, 1302);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        f_10601_1191_1210_C(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10601, 1097, 1314);
            return return_v;
        }

    }
    internal sealed class RetargetingMethodParameterSymbol : RetargetingParameterSymbol
    {
        private readonly RetargetingMethodSymbol _retargetingMethod;

        public RetargetingMethodParameterSymbol(RetargetingMethodSymbol retargetingMethod, ParameterSymbol underlyingParameter)
        : base(f_10601_4707_4726_C(underlyingParameter))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10601, 4567, 4864);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10601, 4536, 4554);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10601, 4752, 4800);

                f_10601_4752_4799((object)retargetingMethod != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10601, 4814, 4853);

                _retargetingMethod = retargetingMethod;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10601, 4567, 4864);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10601, 4567, 4864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10601, 4567, 4864);
            }
        }

        protected override RetargetingModuleSymbol RetargetingModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10601, 4961, 5013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10601, 4967, 5011);

                    return f_10601_4974_5010(_retargetingMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10601, 4961, 5013);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                    f_10601_4974_5010(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10601, 4974, 5010);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10601, 4876, 5024);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10601, 4876, 5024);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static RetargetingMethodParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10601, 4303, 5031);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10601, 4303, 5031);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10601, 4303, 5031);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10601, 4303, 5031);

        int
        f_10601_4752_4799(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10601, 4752, 4799);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        f_10601_4707_4726_C(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10601, 4567, 4864);
            return return_v;
        }

    }
    internal sealed class RetargetingPropertyParameterSymbol : RetargetingParameterSymbol
    {
        private readonly RetargetingPropertySymbol _retargetingProperty;

        public RetargetingPropertyParameterSymbol(RetargetingPropertySymbol retargetingProperty, ParameterSymbol underlyingParameter)
        : base(f_10601_5457_5476_C(underlyingParameter))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10601, 5311, 5620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10601, 5278, 5298);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10601, 5502, 5552);

                f_10601_5502_5551((object)retargetingProperty != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10601, 5566, 5609);

                _retargetingProperty = retargetingProperty;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10601, 5311, 5620);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10601, 5311, 5620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10601, 5311, 5620);
            }
        }

        protected override RetargetingModuleSymbol RetargetingModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10601, 5717, 5771);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10601, 5723, 5769);

                    return f_10601_5730_5768(_retargetingProperty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10601, 5717, 5771);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                    f_10601_5730_5768(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingPropertySymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10601, 5730, 5768);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10601, 5632, 5782);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10601, 5632, 5782);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static RetargetingPropertyParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10601, 5039, 5789);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10601, 5039, 5789);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10601, 5039, 5789);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10601, 5039, 5789);

        int
        f_10601_5502_5551(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10601, 5502, 5551);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        f_10601_5457_5476_C(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10601, 5311, 5620);
            return return_v;
        }

    }
}
