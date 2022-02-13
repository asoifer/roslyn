// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SourceEventAccessorSymbol : SourceMemberMethodSymbol
    {
        private readonly SourceEventSymbol _event;

        private readonly string _name;

        private readonly ImmutableArray<MethodSymbol> _explicitInterfaceImplementations;

        private ImmutableArray<ParameterSymbol> _lazyParameters;

        private TypeWithAnnotations _lazyReturnType;

        public SourceEventAccessorSymbol(
                    SourceEventSymbol @event,
                    SyntaxReference syntaxReference,
                    ImmutableArray<Location> locations,
                    EventSymbol explicitlyImplementedEventOpt,
                    string aliasQualifierOpt,
                    bool isAdder,
                    bool isIterator,
                    bool isNullableAnalysisEnabled)
        : base(f_10248_1246_1267_C(@event.containingType), syntaxReference, locations, isIterator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10248, 861, 3034);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 590, 596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 631, 636);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 1333, 1349);

                _event = @event;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 1365, 1377);

                string
                name
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 1391, 1453);

                ImmutableArray<MethodSymbol>
                explicitInterfaceImplementations
                = default(ImmutableArray<MethodSymbol>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 1467, 2426) || true) && ((object)explicitlyImplementedEventOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10248, 1467, 2426);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 1550, 1613);

                    name = f_10248_1557_1612(f_10248_1591_1602(@event), isAdder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 1631, 1701);

                    explicitInterfaceImplementations = ImmutableArray<MethodSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10248, 1467, 2426);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10248, 1467, 2426);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 1767, 1897);

                    MethodSymbol
                    implementedAccessor = (DynAbs.Tracing.TraceSender.Conditional_F1(10248, 1802, 1809) || ((isAdder && DynAbs.Tracing.TraceSender.Conditional_F2(10248, 1812, 1851)) || DynAbs.Tracing.TraceSender.Conditional_F3(10248, 1854, 1896))) ? f_10248_1812_1851(explicitlyImplementedEventOpt) : f_10248_1854_1896(explicitlyImplementedEventOpt)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 1915, 2081);

                    string
                    accessorName = (DynAbs.Tracing.TraceSender.Conditional_F1(10248, 1937, 1972) || (((object)implementedAccessor != null && DynAbs.Tracing.TraceSender.Conditional_F2(10248, 1975, 1999)) || DynAbs.Tracing.TraceSender.Conditional_F3(10248, 2002, 2080))) ? f_10248_1975_1999(implementedAccessor) : f_10248_2002_2080(f_10248_2036_2070(explicitlyImplementedEventOpt), isAdder)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 2101, 2226);

                    name = f_10248_2108_2225(accessorName, f_10248_2161_2205(explicitlyImplementedEventOpt), aliasQualifierOpt);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 2244, 2411);

                    explicitInterfaceImplementations = (DynAbs.Tracing.TraceSender.Conditional_F1(10248, 2279, 2314) || (((object)implementedAccessor == null && DynAbs.Tracing.TraceSender.Conditional_F2(10248, 2317, 2351)) || DynAbs.Tracing.TraceSender.Conditional_F3(10248, 2354, 2410))) ? ImmutableArray<MethodSymbol>.Empty : f_10248_2354_2410(implementedAccessor);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10248, 1467, 2426);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 2442, 2511);

                _explicitInterfaceImplementations = explicitInterfaceImplementations;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 2527, 2948);

                f_10248_2527_2947(
                            this, (DynAbs.Tracing.TraceSender.Conditional_F1(10248, 2560, 2567) || ((isAdder && DynAbs.Tracing.TraceSender.Conditional_F2(10248, 2570, 2589)) || DynAbs.Tracing.TraceSender.Conditional_F3(10248, 2592, 2614))) ? MethodKind.EventAdd : MethodKind.EventRemove, f_10248_2633_2649(@event), returnsVoid: false, isExtensionMethod: false, isNullableAnalysisEnabled: isNullableAnalysisEnabled, isMetadataVirtualIgnoringModifiers: f_10248_2906_2946(@event));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 2964, 3023);

                _name = f_10248_2972_3014(this, @event, isAdder) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(10248, 2972, 3022) ?? name);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10248, 861, 3034);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10248, 861, 3034);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10248, 861, 3034);
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10248, 3098, 3119);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 3104, 3117);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10248, 3098, 3119);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10248, 3046, 3130);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10248, 3046, 3130);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10248, 3223, 3279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 3229, 3277);

                    return f_10248_3236_3276(_event);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10248, 3223, 3279);

                    bool
                    f_10248_3236_3276(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                    this_param)
                    {
                        var return_v = this_param.IsExplicitInterfaceImplementation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10248, 3236, 3276);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10248, 3142, 3290);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10248, 3142, 3290);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10248, 3404, 3453);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 3410, 3451);

                    return _explicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10248, 3404, 3453);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10248, 3302, 3464);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10248, 3302, 3464);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10248, 3533, 3594);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 3536, 3594);
                    return f_10248_3536_3570_M(!_event.HasSkipLocalsInitAttribute) && (DynAbs.Tracing.TraceSender.Expression_True(10248, 3536, 3594) && DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.AreLocalsZeroed, 10248, 3574, 3594)); DynAbs.Tracing.TraceSender.TraceExitMethod(10248, 3533, 3594);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10248, 3533, 3594);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10248, 3533, 3594);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SourceEventSymbol AssociatedEvent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10248, 3672, 3694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 3678, 3692);

                    return _event;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10248, 3672, 3694);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10248, 3607, 3705);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10248, 3607, 3705);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override Symbol AssociatedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10248, 3788, 3810);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 3794, 3808);

                    return _event;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10248, 3788, 3810);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10248, 3717, 3821);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10248, 3717, 3821);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected sealed override void MethodChecks(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10248, 3833, 7199);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 3928, 3995);

                f_10248_3928_3994(_lazyParameters.IsDefault != _lazyReturnType.HasType);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 4405, 7188) || true) && (_lazyReturnType.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10248, 4405, 7188);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 4468, 4526);

                    CSharpCompilation
                    compilation = f_10248_4500_4525(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 4544, 4578);

                    f_10248_4544_4577(compilation != null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 4757, 7173) || true) && (f_10248_4761_4789(_event))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10248, 4757, 7173);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 4831, 4972);

                        TypeSymbol
                        eventTokenType = f_10248_4859_4971(compilation, WellKnownType.System_Runtime_InteropServices_WindowsRuntime_EventRegistrationToken)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 4994, 5070);

                        f_10248_4994_5069(eventTokenType, diagnostics, f_10248_5055_5068(this));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 5094, 6446) || true) && (f_10248_5098_5113(this) == MethodKind.EventAdd)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10248, 5094, 6446);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 5339, 5400);

                            _lazyReturnType = TypeWithAnnotations.Create(eventTokenType);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 5428, 5525);

                            var
                            parameter = f_10248_5444_5524(this, f_10248_5494_5520(_event), 0)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 5551, 5619);

                            _lazyParameters = f_10248_5569_5618(parameter);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10248, 5094, 6446);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10248, 5094, 6446);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 5717, 5773);

                            f_10248_5717_5772(f_10248_5730_5745(this) == MethodKind.EventRemove);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 5872, 5946);

                            TypeSymbol
                            voidType = f_10248_5894_5945(compilation, SpecialType.System_Void)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 5972, 6042);

                            f_10248_5972_6041(voidType, diagnostics, f_10248_6027_6040(this));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 6068, 6123);

                            _lazyReturnType = TypeWithAnnotations.Create(voidType);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 6149, 6188);

                            f_10248_6149_6187(this, returnsVoid: true);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 6216, 6329);

                            var
                            parameter = f_10248_6232_6328(this, TypeWithAnnotations.Create(eventTokenType), 0)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 6355, 6423);

                            _lazyParameters = f_10248_6373_6422(parameter);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10248, 5094, 6446);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10248, 4757, 7173);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10248, 4757, 7173);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 6639, 6713);

                        TypeSymbol
                        voidType = f_10248_6661_6712(compilation, SpecialType.System_Void)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 6735, 6805);

                        f_10248_6735_6804(voidType, diagnostics, f_10248_6790_6803(this));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 6827, 6882);

                        _lazyReturnType = TypeWithAnnotations.Create(voidType);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 6904, 6943);

                        f_10248_6904_6942(this, returnsVoid: true);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 6967, 7064);

                        var
                        parameter = f_10248_6983_7063(this, f_10248_7033_7059(_event), 0)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 7086, 7154);

                        _lazyParameters = f_10248_7104_7153(parameter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10248, 4757, 7173);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10248, 4405, 7188);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10248, 3833, 7199);

                int
                f_10248_3928_3994(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 3928, 3994);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10248_4500_4525(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventAccessorSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10248, 4500, 4525);
                    return return_v;
                }


                int
                f_10248_4544_4577(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 4544, 4577);
                    return 0;
                }


                bool
                f_10248_4761_4789(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.IsWindowsRuntimeEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10248, 4761, 4789);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10248_4859_4971(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 4859, 4971);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10248_5055_5068(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventAccessorSymbol
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10248, 5055, 5068);
                    return return_v;
                }


                bool
                f_10248_4994_5069(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Binder.ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 4994, 5069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10248_5098_5113(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventAccessorSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10248, 5098, 5113);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10248_5494_5520(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10248, 5494, 5520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAccessorValueParameterSymbol
                f_10248_5444_5524(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventAccessorSymbol
                accessor, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                paramType, int
                ordinal)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAccessorValueParameterSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol)accessor, paramType, ordinal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 5444, 5524);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10248_5569_5618(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAccessorValueParameterSymbol
                item)
                {
                    var return_v = ImmutableArray.Create<ParameterSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 5569, 5618);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10248_5730_5745(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventAccessorSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10248, 5730, 5745);
                    return return_v;
                }


                int
                f_10248_5717_5772(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 5717, 5772);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10248_5894_5945(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 5894, 5945);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10248_6027_6040(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventAccessorSymbol
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10248, 6027, 6040);
                    return return_v;
                }


                bool
                f_10248_5972_6041(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Binder.ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 5972, 6041);
                    return return_v;
                }


                int
                f_10248_6149_6187(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventAccessorSymbol
                this_param, bool
                returnsVoid)
                {
                    this_param.SetReturnsVoid(returnsVoid: returnsVoid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 6149, 6187);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAccessorValueParameterSymbol
                f_10248_6232_6328(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventAccessorSymbol
                accessor, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                paramType, int
                ordinal)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAccessorValueParameterSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol)accessor, paramType, ordinal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 6232, 6328);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10248_6373_6422(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAccessorValueParameterSymbol
                item)
                {
                    var return_v = ImmutableArray.Create<ParameterSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 6373, 6422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10248_6661_6712(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 6661, 6712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10248_6790_6803(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventAccessorSymbol
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10248, 6790, 6803);
                    return return_v;
                }


                bool
                f_10248_6735_6804(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Binder.ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 6735, 6804);
                    return return_v;
                }


                int
                f_10248_6904_6942(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventAccessorSymbol
                this_param, bool
                returnsVoid)
                {
                    this_param.SetReturnsVoid(returnsVoid: returnsVoid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 6904, 6942);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10248_7033_7059(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10248, 7033, 7059);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAccessorValueParameterSymbol
                f_10248_6983_7063(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventAccessorSymbol
                accessor, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                paramType, int
                ordinal)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAccessorValueParameterSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol)accessor, paramType, ordinal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 6983, 7063);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10248_7104_7153(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAccessorValueParameterSymbol
                item)
                {
                    var return_v = ImmutableArray.Create<ParameterSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 7104, 7153);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10248, 3833, 7199);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10248, 3833, 7199);
            }
        }

        public sealed override bool ReturnsVoid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10248, 7275, 7446);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 7311, 7330);

                    f_10248_7311_7329(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 7348, 7389);

                    f_10248_7348_7388(f_10248_7361_7387_M(!_lazyReturnType.IsDefault));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 7407, 7431);

                    return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.ReturnsVoid, 10248, 7414, 7430);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10248, 7275, 7446);

                    int
                    f_10248_7311_7329(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventAccessorSymbol
                    this_param)
                    {
                        this_param.LazyMethodChecks();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 7311, 7329);
                        return 0;
                    }


                    bool
                    f_10248_7361_7387_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10248, 7361, 7387);
                        return return_v;
                    }


                    int
                    f_10248_7348_7388(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 7348, 7388);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10248, 7211, 7457);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10248, 7211, 7457);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10248, 7525, 7553);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 7531, 7551);

                    return RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10248, 7525, 7553);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10248, 7469, 7564);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10248, 7469, 7564);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override TypeWithAnnotations ReturnTypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10248, 7669, 7839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 7705, 7724);

                    f_10248_7705_7723(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 7742, 7783);

                    f_10248_7742_7782(f_10248_7755_7781_M(!_lazyReturnType.IsDefault));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 7801, 7824);

                    return _lazyReturnType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10248, 7669, 7839);

                    int
                    f_10248_7705_7723(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventAccessorSymbol
                    this_param)
                    {
                        this_param.LazyMethodChecks();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 7705, 7723);
                        return 0;
                    }


                    bool
                    f_10248_7755_7781_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10248, 7755, 7781);
                        return return_v;
                    }


                    int
                    f_10248_7742_7782(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 7742, 7782);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10248, 7576, 7850);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10248, 7576, 7850);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10248, 7959, 8103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 7995, 8039);

                    return ImmutableArray<CustomModifier>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10248, 7959, 8103);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10248, 7862, 8114);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10248, 7862, 8114);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<ParameterSymbol> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10248, 8216, 8386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 8252, 8271);

                    f_10248_8252_8270(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 8289, 8330);

                    f_10248_8289_8329(f_10248_8302_8328_M(!_lazyParameters.IsDefault));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 8348, 8371);

                    return _lazyParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10248, 8216, 8386);

                    int
                    f_10248_8252_8270(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventAccessorSymbol
                    this_param)
                    {
                        this_param.LazyMethodChecks();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 8252, 8270);
                        return 0;
                    }


                    bool
                    f_10248_8302_8328_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10248, 8302, 8328);
                        return return_v;
                    }


                    int
                    f_10248_8289_8329(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 8289, 8329);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10248, 8126, 8397);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10248, 8126, 8397);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsVararg
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10248, 8470, 8491);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 8476, 8489);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10248, 8470, 8491);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10248, 8409, 8502);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10248, 8409, 8502);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10248, 8612, 8669);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 8618, 8667);

                    return ImmutableArray<TypeParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10248, 8612, 8669);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10248, 8514, 8680);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10248, 8514, 8680);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<ImmutableArray<TypeWithAnnotations>> GetTypeParameterConstraintTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10248, 8814, 8874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 8817, 8874);
                return ImmutableArray<ImmutableArray<TypeWithAnnotations>>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10248, 8814, 8874);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10248, 8814, 8874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10248, 8814, 8874);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<TypeParameterConstraintKind> GetTypeParameterConstraintKinds()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10248, 9001, 9053);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 9004, 9053);
                return ImmutableArray<TypeParameterConstraintKind>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10248, 9001, 9053);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10248, 9001, 9053);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10248, 9001, 9053);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Location Location
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10248, 9117, 9252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 9153, 9194);

                    f_10248_9153_9193(this.Locations.Length == 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 9212, 9237);

                    return f_10248_9219_9233(this)[0];
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10248, 9117, 9252);

                    int
                    f_10248_9153_9193(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 9153, 9193);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10248_9219_9233(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventAccessorSymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10248, 9219, 9233);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10248, 9066, 9263);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10248, 9066, 9263);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected string GetOverriddenAccessorName(SourceEventSymbol @event, bool isAdder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10248, 9275, 10875);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 9382, 10836) || true) && (f_10248_9386_9401(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10248, 9382, 10836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 10160, 10213);

                    EventSymbol
                    overriddenEvent = f_10248_10190_10212(@event)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 10231, 10821) || true) && ((object)overriddenEvent != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10248, 10231, 10821);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 10620, 10705);

                        MethodSymbol
                        overriddenAccessor = f_10248_10654_10704(overriddenEvent, isAdder)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 10727, 10802);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10248, 10734, 10768) || (((object)overriddenAccessor == null && DynAbs.Tracing.TraceSender.Conditional_F2(10248, 10771, 10775)) || DynAbs.Tracing.TraceSender.Conditional_F3(10248, 10778, 10801))) ? null : f_10248_10778_10801(overriddenAccessor);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10248, 10231, 10821);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10248, 9382, 10836);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 10852, 10864);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10248, 9275, 10875);

                bool
                f_10248_9386_9401(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventAccessorSymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10248, 9386, 9401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol?
                f_10248_10190_10212(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10248, 10190, 10212);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10248_10654_10704(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                @event, bool
                isAdder)
                {
                    var return_v = @event.GetOwnOrInheritedAccessor(isAdder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 10654, 10704);
                    return return_v;
                }


                string
                f_10248_10778_10801(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10248, 10778, 10801);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10248, 9275, 10875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10248, 9275, 10875);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsExpressionBodied
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10248, 11004, 11025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10248, 11010, 11023);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10248, 11004, 11025);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10248, 10887, 11036);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10248, 10887, 11036);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SourceEventAccessorSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10248, 462, 11043);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10248, 462, 11043);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10248, 462, 11043);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10248, 462, 11043);

        string
        f_10248_1591_1602(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10248, 1591, 1602);
            return return_v;
        }


        string
        f_10248_1557_1612(string
        eventName, bool
        isAdder)
        {
            var return_v = SourceEventSymbol.GetAccessorName(eventName, isAdder);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 1557, 1612);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
        f_10248_1812_1851(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
        this_param)
        {
            var return_v = this_param.AddMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10248, 1812, 1851);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
        f_10248_1854_1896(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
        this_param)
        {
            var return_v = this_param.RemoveMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10248, 1854, 1896);
            return return_v;
        }


        string
        f_10248_1975_1999(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10248, 1975, 1999);
            return return_v;
        }


        string
        f_10248_2036_2070(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10248, 2036, 2070);
            return return_v;
        }


        string
        f_10248_2002_2080(string
        eventName, bool
        isAdder)
        {
            var return_v = SourceEventSymbol.GetAccessorName(eventName, isAdder);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 2002, 2080);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10248_2161_2205(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10248, 2161, 2205);
            return return_v;
        }


        string
        f_10248_2108_2225(string
        name, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        explicitInterfaceTypeOpt, string
        aliasQualifierOpt)
        {
            var return_v = ExplicitInterfaceHelpers.GetMemberName(name, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)explicitInterfaceTypeOpt, aliasQualifierOpt);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 2108, 2225);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
        f_10248_2354_2410(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        item)
        {
            var return_v = ImmutableArray.Create<MethodSymbol>(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 2354, 2410);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        f_10248_2633_2649(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
        this_param)
        {
            var return_v = this_param.Modifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10248, 2633, 2649);
            return return_v;
        }


        bool
        f_10248_2906_2946(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
        this_param)
        {
            var return_v = this_param.IsExplicitInterfaceImplementation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10248, 2906, 2946);
            return return_v;
        }


        int
        f_10248_2527_2947(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventAccessorSymbol
        this_param, Microsoft.CodeAnalysis.MethodKind
        methodKind, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        declarationModifiers, bool
        returnsVoid, bool
        isExtensionMethod, bool
        isNullableAnalysisEnabled, bool
        isMetadataVirtualIgnoringModifiers)
        {
            this_param.MakeFlags(methodKind, declarationModifiers, returnsVoid: returnsVoid, isExtensionMethod: isExtensionMethod, isNullableAnalysisEnabled: isNullableAnalysisEnabled, isMetadataVirtualIgnoringModifiers: isMetadataVirtualIgnoringModifiers);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 2527, 2947);
            return 0;
        }


        string
        f_10248_2972_3014(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventAccessorSymbol
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
        @event, bool
        isAdder)
        {
            var return_v = this_param.GetOverriddenAccessorName(@event, isAdder);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10248, 2972, 3014);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10248_1246_1267_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10248, 861, 3034);
            return return_v;
        }


        bool
        f_10248_3536_3570_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10248, 3536, 3570);
            return return_v;
        }

    }
}
