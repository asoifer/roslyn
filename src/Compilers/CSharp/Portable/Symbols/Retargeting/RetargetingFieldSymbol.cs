// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Roslyn.Utilities;
using Microsoft.CodeAnalysis.CSharp.Emit;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting
{
    internal sealed class RetargetingFieldSymbol : WrappedFieldSymbol
    {
        private readonly RetargetingModuleSymbol _retargetingModule;

        private ImmutableArray<CSharpAttributeData> _lazyCustomAttributes;

        private DiagnosticInfo _lazyUseSiteDiagnostic;

        public RetargetingFieldSymbol(RetargetingModuleSymbol retargetingModule, FieldSymbol underlyingField)
        : base(f_10596_1451_1466_C(underlyingField))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10596, 1329, 1679);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10596, 1010, 1028);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10596, 1231, 1287);
                this._lazyUseSiteDiagnostic = CSDiagnosticInfo.EmptyErrorInfo; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10596, 1492, 1540);

                f_10596_1492_1539((object)retargetingModule != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10596, 1554, 1613);

                f_10596_1554_1612(!(underlyingField is RetargetingFieldSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10596, 1629, 1668);

                _retargetingModule = retargetingModule;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10596, 1329, 1679);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10596, 1329, 1679);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10596, 1329, 1679);
            }
        }

        private RetargetingModuleSymbol.RetargetingSymbolTranslator RetargetingTranslator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10596, 1797, 1896);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10596, 1833, 1881);

                    return _retargetingModule.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10596, 1797, 1896);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10596, 1691, 1907);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10596, 1691, 1907);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public RetargetingModuleSymbol RetargetingModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10596, 1992, 2069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10596, 2028, 2054);

                    return _retargetingModule;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10596, 1992, 2069);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10596, 1919, 2080);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10596, 1919, 2080);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TypeWithAnnotations GetFieldType(ConsList<FieldSymbol> fieldsBeingBound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10596, 2092, 2360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10596, 2207, 2349);

                return f_10596_2214_2348(f_10596_2214_2240(this), f_10596_2250_2297(_underlyingField, fieldsBeingBound), RetargetOptions.RetargetPrimitiveTypesByTypeCode);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10596, 2092, 2360);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10596_2214_2240(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingFieldSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10596, 2214, 2240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10596_2250_2297(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                fieldsBeingBound)
                {
                    var return_v = this_param.GetFieldType(fieldsBeingBound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10596, 2250, 2297);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10596_2214_2348(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                underlyingType, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                options)
                {
                    var return_v = this_param.Retarget(underlyingType, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10596, 2214, 2348);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10596, 2092, 2360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10596, 2092, 2360);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10596, 2436, 2565);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10596, 2472, 2550);

                    return f_10596_2479_2549(f_10596_2479_2505(this), f_10596_2515_2548(_underlyingField));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10596, 2436, 2565);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    f_10596_2479_2505(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingFieldSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingTranslator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10596, 2479, 2505);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10596_2515_2548(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10596, 2515, 2548);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10596_2479_2549(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    symbol)
                    {
                        var return_v = this_param.Retarget(symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10596, 2479, 2549);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10596, 2372, 2576);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10596, 2372, 2576);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10596, 2588, 2810);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10596, 2680, 2799);

                return f_10596_2687_2798(f_10596_2687_2713(this), f_10596_2738_2770(_underlyingField), ref _lazyCustomAttributes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10596, 2588, 2810);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10596_2687_2713(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingFieldSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10596, 2687, 2713);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10596_2738_2770(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10596, 2738, 2770);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10596_2687_2798(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                underlyingAttributes, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                lazyCustomAttributes)
                {
                    var return_v = this_param.GetRetargetedAttributes(underlyingAttributes, ref lazyCustomAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10596, 2687, 2798);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10596, 2588, 2810);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10596, 2588, 2810);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<CSharpAttributeData> GetCustomAttributesToEmit(PEModuleBuilder moduleBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10596, 2822, 3077);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10596, 2954, 3066);

                return f_10596_2961_3065(f_10596_2961_2987(this), f_10596_3007_3064(_underlyingField, moduleBuilder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10596, 2822, 3077);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10596_2961_2987(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingFieldSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10596, 2961, 2987);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10596_3007_3064(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder)
                {
                    var return_v = this_param.GetCustomAttributesToEmit(moduleBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10596, 3007, 3064);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10596_2961_3065(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                attributes)
                {
                    var return_v = this_param.RetargetAttributes(attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10596, 2961, 3065);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10596, 2822, 3077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10596, 2822, 3077);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AssemblySymbol ContainingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10596, 3163, 3259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10596, 3199, 3244);

                    return f_10596_3206_3243(_retargetingModule);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10596, 3163, 3259);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10596_3206_3243(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10596, 3206, 3243);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10596, 3089, 3270);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10596, 3089, 3270);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10596, 3354, 3431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10596, 3390, 3416);

                    return _retargetingModule;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10596, 3354, 3431);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10596, 3282, 3442);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10596, 3282, 3442);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10596, 3552, 3687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10596, 3588, 3672);

                    return f_10596_3595_3671(f_10596_3595_3621(this), f_10596_3631_3670(_underlyingField));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10596, 3552, 3687);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    f_10596_3595_3621(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingFieldSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingTranslator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10596, 3595, 3621);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    f_10596_3631_3670(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.MarshallingInformation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10596, 3631, 3670);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    f_10596_3595_3671(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    marshallingInfo)
                    {
                        var return_v = this_param.Retarget(marshallingInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10596, 3595, 3671);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10596, 3454, 3698);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10596, 3454, 3698);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10596, 3774, 3985);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10596, 3810, 3861);

                    var
                    associated = f_10596_3827_3860(_underlyingField)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10596, 3879, 3970);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10596, 3886, 3912) || (((object)associated == null && DynAbs.Tracing.TraceSender.Conditional_F2(10596, 3915, 3919)) || DynAbs.Tracing.TraceSender.Conditional_F3(10596, 3922, 3969))) ? null : f_10596_3922_3969(f_10596_3922_3948(this), associated);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10596, 3774, 3985);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10596_3827_3860(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.AssociatedSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10596, 3827, 3860);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    f_10596_3922_3948(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingFieldSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingTranslator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10596, 3922, 3948);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10596_3922_3969(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    symbol)
                    {
                        var return_v = this_param.Retarget(symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10596, 3922, 3969);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10596, 3710, 3996);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10596, 3710, 3996);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int TupleElementIndex
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10596, 4046, 4083);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10596, 4049, 4083);
                    return f_10596_4049_4083(_underlyingField); DynAbs.Tracing.TraceSender.TraceExitMethod(10596, 4046, 4083);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10596, 4046, 4083);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10596, 4046, 4083);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override DiagnosticInfo GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10596, 4096, 4494);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10596, 4176, 4437) || true) && (f_10596_4180_4252(_lazyUseSiteDiagnostic, CSDiagnosticInfo.EmptyErrorInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10596, 4176, 4437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10596, 4286, 4315);

                    DiagnosticInfo
                    result = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10596, 4333, 4372);

                    f_10596_4333_4371(this, ref result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10596, 4390, 4422);

                    _lazyUseSiteDiagnostic = result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10596, 4176, 4437);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10596, 4453, 4483);

                return _lazyUseSiteDiagnostic;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10596, 4096, 4494);

                bool
                f_10596_4180_4252(Microsoft.CodeAnalysis.DiagnosticInfo
                objA, Microsoft.CodeAnalysis.DiagnosticInfo
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10596, 4180, 4252);
                    return return_v;
                }


                bool
                f_10596_4333_4371(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingFieldSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo?
                result)
                {
                    var return_v = this_param.CalculateUseSiteDiagnostic(ref result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10596, 4333, 4371);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10596, 4096, 4494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10596, 4096, 4494);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override CSharpCompilation DeclaringCompilation // perf, not correctness
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10596, 4619, 4639);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10596, 4625, 4637);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10596, 4619, 4639);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10596, 4506, 4650);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10596, 4506, 4650);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static RetargetingFieldSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10596, 795, 4657);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10596, 795, 4657);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10596, 795, 4657);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10596, 795, 4657);

        int
        f_10596_1492_1539(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10596, 1492, 1539);
            return 0;
        }


        int
        f_10596_1554_1612(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10596, 1554, 1612);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
        f_10596_1451_1466_C(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10596, 1329, 1679);
            return return_v;
        }


        int
        f_10596_4049_4083(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
        this_param)
        {
            var return_v = this_param.TupleElementIndex;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10596, 4049, 4083);
            return return_v;
        }

    }
}
