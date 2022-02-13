// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Emit;
using Roslyn.Utilities;
using Microsoft.CodeAnalysis.Emit.NoPia;


namespace Microsoft.CodeAnalysis.CSharp.Emit.NoPia
{
    internal sealed class EmbeddedTypesManager :
            EmbeddedTypesManager<PEModuleBuilder, ModuleCompilationState, EmbeddedTypesManager, SyntaxNode, CSharpAttributeData,
                SymbolAdapter,
                AssemblySymbol,
                NamedTypeSymbolAdapter, FieldSymbolAdapter, MethodSymbolAdapter, EventSymbolAdapter, PropertySymbolAdapter, ParameterSymbolAdapter, TypeParameterSymbolAdapter,
                EmbeddedType, EmbeddedField, EmbeddedMethod, EmbeddedEvent, EmbeddedProperty, EmbeddedParameter, EmbeddedTypeParameter>
    {
        private readonly ConcurrentDictionary<AssemblySymbol, string> _assemblyGuidMap;

        private readonly ConcurrentDictionary<Symbol, bool> _reportedSymbolsMap;

        private NamedTypeSymbol _lazySystemStringType;

        private readonly MethodSymbol[] _lazyWellKnownTypeMethods;

        public EmbeddedTypesManager(PEModuleBuilder moduleBeingBuilt) : base(f_10950_2421_2437_C(moduleBeingBuilt))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10950, 2339, 2732);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 1904, 2007);
                this._assemblyGuidMap = f_10950_1923_2007(ReferenceEqualityComparer.Instance); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 2070, 2166);
                this._reportedSymbolsMap = f_10950_2092_2166(ReferenceEqualityComparer.Instance); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 2201, 2258);
                this._lazySystemStringType = ErrorTypeSymbol.UnknownResultType; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 2301, 2326);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 2463, 2536);

                _lazyWellKnownTypeMethods = new MethodSymbol[(int)WellKnownMember.Count];
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 2561, 2566);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 2552, 2721) || true) && (i < f_10950_2572_2604(_lazyWellKnownTypeMethods))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 2606, 2609)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 2552, 2721))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 2552, 2721);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 2643, 2706);

                        _lazyWellKnownTypeMethods[i] = ErrorMethodSymbol.UnknownMethod;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10950, 1, 170);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10950, 1, 170);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10950, 2339, 2732);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10950, 2339, 2732);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10950, 2339, 2732);
            }
        }

        public NamedTypeSymbol GetSystemStringType(SyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10950, 2744, 3937);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 2864, 3881) || true) && ((object)_lazySystemStringType == (object)ErrorTypeSymbol.UnknownResultType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 2864, 3881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 2976, 3064);

                    var
                    typeSymbol = f_10950_2993_3063(ModuleBeingBuilt.Compilation, SpecialType.System_String)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 3084, 3140);

                    DiagnosticInfo
                    info = f_10950_3106_3139(typeSymbol)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 3160, 3267) || true) && (f_10950_3164_3188(typeSymbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 3160, 3267);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 3230, 3248);

                        typeSymbol = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 3160, 3267);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 3287, 3866) || true) && (f_10950_3291_3483(f_10950_3309_3410(ref _lazySystemStringType, typeSymbol, ErrorTypeSymbol.UnknownResultType), ErrorTypeSymbol.UnknownResultType, TypeCompareKind.ConsiderEverything2))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 3287, 3866);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 3525, 3847) || true) && (info != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 3525, 3847);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 3591, 3824);

                            f_10950_3591_3823(info, diagnostics, (DynAbs.Tracing.TraceSender.Conditional_F1(10950, 3753, 3774) || ((syntaxNodeOpt != null && DynAbs.Tracing.TraceSender.Conditional_F2(10950, 3777, 3799)) || DynAbs.Tracing.TraceSender.Conditional_F3(10950, 3802, 3822))) ? f_10950_3777_3799(syntaxNodeOpt) : NoLocation.Singleton);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 3525, 3847);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 3287, 3866);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 2864, 3881);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 3897, 3926);

                return _lazySystemStringType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10950, 2744, 3937);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10950_2993_3063(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 2993, 3063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10950_3106_3139(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 3106, 3139);
                    return return_v;
                }


                bool
                f_10950_3164_3188(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 3164, 3188);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10950_3309_3410(ref Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                value, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 3309, 3410);
                    return return_v;
                }


                bool
                f_10950_3291_3483(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                left, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 3291, 3483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10950_3777_3799(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 3777, 3799);
                    return return_v;
                }


                bool
                f_10950_3591_3823(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Symbol.ReportUseSiteDiagnostic(info, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 3591, 3823);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10950, 2744, 3937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10950, 2744, 3937);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public MethodSymbol GetWellKnownMethod(WellKnownMember method, SyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10950, 3949, 4355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 4089, 4344);

                return f_10950_4096_4343(this, ref _lazyWellKnownTypeMethods[(int)method], method, syntaxNodeOpt, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10950, 3949, 4355);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10950_4096_4343(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, ref Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                lazyMethod, Microsoft.CodeAnalysis.WellKnownMember
                member, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.LazyGetWellKnownTypeMethod(ref lazyMethod, member, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 4096, 4343);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10950, 3949, 4355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10950, 3949, 4355);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MethodSymbol LazyGetWellKnownTypeMethod(ref MethodSymbol lazyMethod, WellKnownMember member, SyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10950, 4367, 5770);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 4545, 5725) || true) && ((object)lazyMethod == (object)ErrorMethodSymbol.UnknownMethod)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 4545, 5725);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 4644, 4664);

                    DiagnosticInfo
                    info
                    = default(DiagnosticInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 4682, 5028);

                    var
                    symbol = (MethodSymbol)f_10950_4709_5027(ModuleBeingBuilt.Compilation, member, out info, isOptional: false)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 5048, 5184) || true) && (info != null && (DynAbs.Tracing.TraceSender.Expression_True(10950, 5052, 5109) && f_10950_5068_5081(info) == DiagnosticSeverity.Error))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 5048, 5184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 5151, 5165);

                        symbol = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 5048, 5184);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 5204, 5710) || true) && (f_10950_5208_5292(ref lazyMethod, symbol, ErrorMethodSymbol.UnknownMethod) == ErrorMethodSymbol.UnknownMethod)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 5204, 5710);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 5369, 5691) || true) && (info != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 5369, 5691);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 5435, 5668);

                            f_10950_5435_5667(info, diagnostics, (DynAbs.Tracing.TraceSender.Conditional_F1(10950, 5597, 5618) || ((syntaxNodeOpt != null && DynAbs.Tracing.TraceSender.Conditional_F2(10950, 5621, 5643)) || DynAbs.Tracing.TraceSender.Conditional_F3(10950, 5646, 5666))) ? f_10950_5621_5643(syntaxNodeOpt) : NoLocation.Singleton);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 5369, 5691);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 5204, 5710);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 4545, 5725);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 5741, 5759);

                return lazyMethod;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10950, 4367, 5770);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10950_4709_5027(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                member, out Microsoft.CodeAnalysis.DiagnosticInfo
                diagnosticInfo, bool
                isOptional)
                {
                    var return_v = Binder.GetWellKnownTypeMember(compilation, member, out diagnosticInfo, isOptional: isOptional);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 4709, 5027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10950_5068_5081(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 5068, 5081);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10950_5208_5292(ref Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                value, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorMethodSymbol
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 5208, 5292);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10950_5621_5643(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 5621, 5643);
                    return return_v;
                }


                bool
                f_10950_5435_5667(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Symbol.ReportUseSiteDiagnostic(info, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 5435, 5667);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10950, 4367, 5770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10950, 4367, 5770);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override int GetTargetAttributeSignatureIndex(SymbolAdapter underlyingSymbol, CSharpAttributeData attrData, AttributeDescription description)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10950, 5782, 6062);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 5957, 6051);

                return f_10950_5964_6050(attrData, f_10950_6006_6036(underlyingSymbol), description);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10950, 5782, 6062);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10950_6006_6036(Microsoft.CodeAnalysis.CSharp.SymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 6006, 6036);
                    return return_v;
                }


                int
                f_10950_5964_6050(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.GetTargetAttributeSignatureIndex(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 5964, 6050);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10950, 5782, 6062);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10950, 5782, 6062);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override CSharpAttributeData CreateSynthesizedAttribute(WellKnownMember constructor, CSharpAttributeData attrData, SyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10950, 6074, 8272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 6275, 6346);

                var
                ctor = f_10950_6286_6345(this, constructor, syntaxNodeOpt, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 6360, 6445) || true) && ((object)ctor == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 6360, 6445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 6418, 6430);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 6360, 6445);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 6461, 8261);

                switch (constructor)
                {

                    case WellKnownMember.System_Runtime_InteropServices_ComEventInterfaceAttribute__ctor:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 6461, 8261);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 6928, 7197);

                        return f_10950_6935_7196(ctor, f_10950_6995_7111(f_10950_7032_7067(attrData)[0], f_10950_7072_7107(attrData)[0]), ImmutableArray<KeyValuePair<string, TypedConstant>>.Empty);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 6461, 8261);

                    case WellKnownMember.System_Runtime_InteropServices_CoClassAttribute__ctor:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 6461, 8261);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 7777, 8086);

                        return f_10950_7784_8085(ctor, f_10950_7844_8000(f_10950_7866_7999(f_10950_7884_7907(f_10950_7884_7899(ctor)[0]), TypedConstantKind.Type, f_10950_7933_7998(f_10950_7933_7956(ctor), SpecialType.System_Object))), ImmutableArray<KeyValuePair<string, TypedConstant>>.Empty);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 6461, 8261);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 6461, 8261);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 8136, 8246);

                        return f_10950_8143_8245(ctor, f_10950_8178_8213(attrData), f_10950_8215_8244(attrData));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 6461, 8261);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10950, 6074, 8272);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10950_6286_6345(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                method, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetWellKnownMethod(method, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 6286, 6345);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10950_7032_7067(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 7032, 7067);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10950_7072_7107(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 7072, 7107);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10950_6995_7111(Microsoft.CodeAnalysis.TypedConstant
                item1, Microsoft.CodeAnalysis.TypedConstant
                item2)
                {
                    var return_v = ImmutableArray.Create<TypedConstant>(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 6995, 7111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10950_6935_7196(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                wellKnownMember, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                namedArguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData(wellKnownMember, arguments, namedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 6935, 7196);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10950_7884_7899(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 7884, 7899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10950_7884_7907(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 7884, 7907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10950_7933_7956(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 7933, 7956);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10950_7933_7998(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 7933, 7998);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10950_7866_7999(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 7866, 7999);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10950_7844_8000(Microsoft.CodeAnalysis.TypedConstant
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 7844, 8000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10950_7784_8085(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                wellKnownMember, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                namedArguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData(wellKnownMember, arguments, namedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 7784, 8085);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10950_8178_8213(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 8178, 8213);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                f_10950_8215_8244(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonNamedArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 8215, 8244);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10950_8143_8245(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                wellKnownMember, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                namedArguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData(wellKnownMember, arguments, namedArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 8143, 8245);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10950, 6074, 8272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10950, 6074, 8272);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetAssemblyGuidString(AssemblySymbol assembly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10950, 8284, 8868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 8371, 8395);

                f_10950_8371_8394(f_10950_8384_8393_M(!IsFrozen));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 8525, 8543);

                string
                guidString
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 8559, 8684) || true) && (f_10950_8563_8617(_assemblyGuidMap, assembly, out guidString))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 8559, 8684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 8651, 8669);

                    return guidString;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 8559, 8684);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 8700, 8733);

                f_10950_8700_8732(guidString == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 8749, 8788);

                f_10950_8749_8787(
                            assembly, out guidString);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 8802, 8857);

                return f_10950_8809_8856(_assemblyGuidMap, assembly, guidString);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10950, 8284, 8868);

                bool
                f_10950_8384_8393_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 8384, 8393);
                    return return_v;
                }


                int
                f_10950_8371_8394(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 8371, 8394);
                    return 0;
                }


                bool
                f_10950_8563_8617(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, string>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                key, out string
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 8563, 8617);
                    return return_v;
                }


                int
                f_10950_8700_8732(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 8700, 8732);
                    return 0;
                }


                bool
                f_10950_8749_8787(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, out string
                guidString)
                {
                    var return_v = this_param.GetGuidString(out guidString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 8749, 8787);
                    return return_v;
                }


                string
                f_10950_8809_8856(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, string>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                key, string
                value)
                {
                    var return_v = this_param.GetOrAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 8809, 8856);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10950, 8284, 8868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10950, 8284, 8868);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void OnGetTypesCompleted(ImmutableArray<EmbeddedType> types, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10950, 8880, 9502);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 9011, 9287);
                    foreach (EmbeddedType t in f_10950_9038_9043_I(types))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 9011, 9287);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 9186, 9272);

                        f_10950_9186_9271(                // Note, once we reached this point we are no longer interested in guid values, using null.
                                        _assemblyGuidMap, f_10950_9210_9264(f_10950_9210_9245(t.UnderlyingNamedType)), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 9011, 9287);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10950, 1, 277);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10950, 1, 277);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 9303, 9491);
                    foreach (AssemblySymbol a in f_10950_9332_9383_I(f_10950_9332_9383(ModuleBeingBuilt)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 9303, 9491);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 9417, 9476);

                        f_10950_9417_9475(this, a, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 9303, 9491);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10950, 1, 189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10950, 1, 189);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10950, 8880, 9502);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10950_9210_9245(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 9210, 9245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10950_9210_9264(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 9210, 9264);
                    return return_v;
                }


                bool
                f_10950_9186_9271(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, string>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                key, string
                value)
                {
                    var return_v = this_param.TryAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 9186, 9271);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType>
                f_10950_9038_9043_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 9038, 9043);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10950_9332_9383(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param)
                {
                    var return_v = this_param.GetReferencedAssembliesUsedSoFar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 9332, 9383);
                    return return_v;
                }


                int
                f_10950_9417_9475(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                a, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReportIndirectReferencesToLinkedAssemblies(a, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 9417, 9475);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10950_9332_9383_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 9332, 9383);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10950, 8880, 9502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10950, 8880, 9502);
            }
        }

        protected override void ReportNameCollisionBetweenEmbeddedTypes(EmbeddedType typeA, EmbeddedType typeB, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10950, 9514, 10115);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 9669, 9717);

                var
                underlyingTypeA = typeA.UnderlyingNamedType
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 9731, 9779);

                var
                underlyingTypeB = typeB.UnderlyingNamedType
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 9793, 10104);

                f_10950_9793_10103(diagnostics, ErrorCode.ERR_InteropTypesWithSameNameAndGuid, null, f_10950_9898_9936(underlyingTypeA), f_10950_9971_10019(f_10950_9971_10000(underlyingTypeA)), f_10950_10054_10102(f_10950_10054_10083(underlyingTypeB)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10950, 9514, 10115);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10950_9898_9936(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 9898, 9936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10950_9971_10000(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 9971, 10000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10950_9971_10019(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 9971, 10019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10950_10054_10083(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 10054, 10083);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10950_10054_10102(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 10054, 10102);
                    return return_v;
                }


                int
                f_10950_9793_10103(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntaxOpt, params object[]
                args)
                {
                    Error(diagnostics, code, syntaxOpt, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 9793, 10103);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10950, 9514, 10115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10950, 9514, 10115);
            }
        }

        protected override void ReportNameCollisionWithAlreadyDeclaredType(EmbeddedType type, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10950, 10127, 10540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 10264, 10310);

                var
                underlyingType = type.UnderlyingNamedType
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 10324, 10529);

                f_10950_10324_10528(diagnostics, ErrorCode.ERR_LocalTypeNameClash, null, f_10950_10412_10449(underlyingType), f_10950_10480_10527(f_10950_10480_10508(underlyingType)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10950, 10127, 10540);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10950_10412_10449(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 10412, 10449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10950_10480_10508(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 10480, 10508);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10950_10480_10527(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 10480, 10527);
                    return return_v;
                }


                int
                f_10950_10324_10528(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntaxOpt, params object[]
                args)
                {
                    Error(diagnostics, code, syntaxOpt, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 10324, 10528);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10950, 10127, 10540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10950, 10127, 10540);
            }
        }

        internal override void ReportIndirectReferencesToLinkedAssemblies(AssemblySymbol a, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10950, 10552, 11899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 10687, 10710);

                f_10950_10687_10709(f_10950_10700_10708());
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 11260, 11888);
                    foreach (ModuleSymbol m in f_10950_11287_11296_I(f_10950_11287_11296(a)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 11260, 11888);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 11330, 11873);
                            foreach (AssemblySymbol indirectRef in f_10950_11369_11401_I(f_10950_11369_11401(m)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 11330, 11873);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 11443, 11854) || true) && (f_10950_11447_11469_M(!indirectRef.IsMissing) && (DynAbs.Tracing.TraceSender.Expression_True(10950, 11447, 11493) && f_10950_11473_11493(indirectRef)) && (DynAbs.Tracing.TraceSender.Expression_True(10950, 11447, 11538) && f_10950_11497_11538(_assemblyGuidMap, indirectRef)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 11443, 11854);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 11693, 11831);

                                    f_10950_11693_11830(diagnostics, ErrorCode.WRN_ReferencedAssemblyReferencesLinkedPIA, null, indirectRef, a);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 11443, 11854);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 11330, 11873);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10950, 1, 544);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10950, 1, 544);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 11260, 11888);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10950, 1, 629);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10950, 1, 629);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10950, 10552, 11899);

                bool
                f_10950_10700_10708()
                {
                    var return_v = IsFrozen;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 10700, 10708);
                    return return_v;
                }


                int
                f_10950_10687_10709(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 10687, 10709);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_10950_11287_11296(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 11287, 11296);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10950_11369_11401(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GetReferencedAssemblySymbols();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 11369, 11401);
                    return return_v;
                }


                bool
                f_10950_11447_11469_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 11447, 11469);
                    return return_v;
                }


                bool
                f_10950_11473_11493(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.IsLinked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 11473, 11493);
                    return return_v;
                }


                bool
                f_10950_11497_11538(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, string>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 11497, 11538);
                    return return_v;
                }


                int
                f_10950_11693_11830(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntaxOpt, params object[]
                args)
                {
                    Error(diagnostics, code, syntaxOpt, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 11693, 11830);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10950_11369_11401_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 11369, 11401);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_10950_11287_11296_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 11287, 11296);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10950, 10552, 11899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10950, 10552, 11899);
            }
        }

        /// <summary>
        /// Returns true if the type can be embedded. If the type is defined in a linked (/l-ed)
        /// assembly, but doesn't meet embeddable type requirements, this function returns false
        /// and reports appropriate diagnostics.
        /// </summary>
        internal static bool IsValidEmbeddableType(
            NamedTypeSymbol namedType,
            SyntaxNode syntaxNodeOpt,
            DiagnosticBag diagnostics,
            EmbeddedTypesManager optTypeManager = null)
        {
            // We do not embed SpecialTypes (they must be defined in Core assembly), error types and 
            // types from assemblies that aren't linked.
            if (namedType.SpecialType != SpecialType.None || namedType.IsErrorType() || !namedType.ContainingAssembly.IsLinked)
            {
                // Assuming that we already complained about an error type, no additional diagnostics necessary.
                return false;
            }

            ErrorCode error = ErrorCode.Unknown;

            switch (namedType.TypeKind)
            {
                case TypeKind.Interface:
                    foreach (Symbol member in namedType.GetMembersUnordered())
                    {
                        if (member.Kind != SymbolKind.NamedType)
                        {
                            if (!member.IsAbstract)
                            {
                                error = ErrorCode.ERR_DefaultInterfaceImplementationInNoPIAType;
                                break;
                            }
                            else if (member.IsSealed)
                            {
                                error = ErrorCode.ERR_ReAbstractionInNoPIAType;
                                break;
                            }
                        }
                    }

                    if (error != ErrorCode.Unknown)
                    {
                        break;
                    }

                    goto case TypeKind.Struct;
                case TypeKind.Struct:
                case TypeKind.Delegate:
                case TypeKind.Enum:

                    // We do not support nesting for embedded types.
                    // ERRID.ERR_InvalidInteropType/ERR_NoPIANestedType
                    if ((object)namedType.ContainingType != null)
                    {
                        error = ErrorCode.ERR_NoPIANestedType;
                        break;
                    }

                    // We do not support generic embedded types.
                    // ERRID.ERR_CannotEmbedInterfaceWithGeneric/ERR_GenericsUsedInNoPIAType
                    if (namedType.IsGenericType)
                    {
                        error = ErrorCode.ERR_GenericsUsedInNoPIAType;
                        break;
                    }

                    break;
                default:
                    // ERRID.ERR_CannotLinkClassWithNoPIA1/ERR_NewCoClassOnLink
                    error = ErrorCode.ERR_NewCoClassOnLink;
                    break;
            }

            if (error != ErrorCode.Unknown)
            {
                ReportNotEmbeddableSymbol(error, namedType, syntaxNodeOpt, diagnostics, optTypeManager);
                return false;
            }

            return true;
        }

        private static void ReportNotEmbeddableSymbol(ErrorCode error, Symbol symbol, SyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics, EmbeddedTypesManager optTypeManager)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10950, 15310, 15800);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 15568, 15789) || true) && (optTypeManager == null || (DynAbs.Tracing.TraceSender.Expression_False(10950, 15572, 15672) || f_10950_15598_15672(optTypeManager._reportedSymbolsMap, f_10950_15640_15665(symbol), true)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 15568, 15789);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 15706, 15774);

                    f_10950_15706_15773(diagnostics, error, syntaxNodeOpt, f_10950_15747_15772(symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 15568, 15789);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10950, 15310, 15800);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10950_15640_15665(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 15640, 15665);
                    return return_v;
                }


                bool
                f_10950_15598_15672(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                key, bool
                value)
                {
                    var return_v = this_param.TryAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 15598, 15672);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10950_15747_15772(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 15747, 15772);
                    return return_v;
                }


                int
                f_10950_15706_15773(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntaxOpt, params object[]
                args)
                {
                    Error(diagnostics, code, syntaxOpt, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 15706, 15773);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10950, 15310, 15800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10950, 15310, 15800);
            }
        }

        internal static void Error(DiagnosticBag diagnostics, ErrorCode code, SyntaxNode syntaxOpt, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10950, 15812, 16025);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 15950, 16014);

                f_10950_15950_16013(diagnostics, syntaxOpt, f_10950_15980_16012(code, args));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10950, 15812, 16025);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10950_15980_16012(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 15980, 16012);
                    return return_v;
                }


                int
                f_10950_15950_16013(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                syntaxOpt, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info)
                {
                    Error(diagnostics, syntaxOpt, (Microsoft.CodeAnalysis.DiagnosticInfo)info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 15950, 16013);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10950, 15812, 16025);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10950, 15812, 16025);
            }
        }

        private static void Error(DiagnosticBag diagnostics, SyntaxNode syntaxOpt, DiagnosticInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10950, 16037, 16271);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 16157, 16260);

                f_10950_16157_16259(diagnostics, f_10950_16173_16258(info, (DynAbs.Tracing.TraceSender.Conditional_F1(10950, 16196, 16213) || ((syntaxOpt == null && DynAbs.Tracing.TraceSender.Conditional_F2(10950, 16216, 16236)) || DynAbs.Tracing.TraceSender.Conditional_F3(10950, 16239, 16257))) ? NoLocation.Singleton : f_10950_16239_16257(syntaxOpt)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10950, 16037, 16271);

                Microsoft.CodeAnalysis.Location
                f_10950_16239_16257(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 16239, 16257);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10950_16173_16258(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 16173, 16258);
                    return return_v;
                }


                int
                f_10950_16157_16259(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 16157, 16259);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10950, 16037, 16271);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10950, 16037, 16271);
            }
        }

        internal Cci.INamedTypeReference EmbedTypeIfNeedTo(
                    NamedTypeSymbol namedType,
                    bool fromImplements,
                    SyntaxNode syntaxNodeOpt,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10950, 16283, 16886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 16512, 16549);

                f_10950_16512_16548(f_10950_16525_16547(namedType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 16563, 16640);

                f_10950_16563_16639(f_10950_16576_16638(ModuleBeingBuilt.SourceModule));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 16656, 16847) || true) && (f_10950_16660_16726(namedType, syntaxNodeOpt, diagnostics, this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 16656, 16847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 16760, 16832);

                    return f_10950_16767_16831(this, namedType, fromImplements, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 16656, 16847);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 16863, 16875);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10950, 16283, 16886);

                bool
                f_10950_16525_16547(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 16525, 16547);
                    return return_v;
                }


                int
                f_10950_16512_16548(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 16512, 16548);
                    return 0;
                }


                bool
                f_10950_16576_16638(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.AnyReferencedAssembliesAreLinked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 16576, 16638);
                    return return_v;
                }


                int
                f_10950_16563_16639(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 16563, 16639);
                    return 0;
                }


                bool
                f_10950_16660_16726(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedType, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                optTypeManager)
                {
                    var return_v = IsValidEmbeddableType(namedType, syntaxNodeOpt, diagnostics, optTypeManager);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 16660, 16726);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
                f_10950_16767_16831(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedType, bool
                fromImplements, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.EmbedType(namedType, fromImplements, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 16767, 16831);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10950, 16283, 16886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10950, 16283, 16886);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private EmbeddedType EmbedType(
                    NamedTypeSymbol namedType,
                    bool fromImplements,
                    SyntaxNode syntaxNodeOpt,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10950, 16898, 19863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 17107, 17144);

                f_10950_17107_17143(f_10950_17120_17142(namedType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 17160, 17200);

                var
                adapter = f_10950_17174_17199(namedType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 17214, 17270);

                EmbeddedType
                embedded = f_10950_17238_17269(this, adapter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 17284, 17351);

                EmbeddedType
                cached = f_10950_17306_17350(EmbeddedTypesMap, adapter, embedded)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 17367, 17410);

                bool
                isInterface = (f_10950_17387_17408(namedType))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 17426, 17673) || true) && (isInterface && (DynAbs.Tracing.TraceSender.Expression_True(10950, 17430, 17459) && fromImplements))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 17426, 17673);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 17585, 17658);

                    f_10950_17585_17657(                // Note, we must use 'cached' here because we might drop 'embedded' below.
                                    cached, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 17426, 17673);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 17689, 17774) || true) && (embedded != cached)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 17689, 17774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 17745, 17759);

                    return cached;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 17689, 17774);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 17963, 18023);

                f_10950_17963_18022(f_10950_17976_17985_M(!IsFrozen), "Set of embedded types is frozen.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 18039, 18200);

                var
                noPiaIndexer = f_10950_18058_18199(f_10950_18087_18198(ModuleBeingBuilt, syntaxNodeOpt, diagnostics, metadataOnly: false, includePrivateMembers: true))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 18326, 18378);

                f_10950_18326_18377(
                            // Make sure we embed all types referenced by the type declaration: implemented interfaces, etc.
                            noPiaIndexer, embedded);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 18394, 19820) || true) && (!isInterface)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 18394, 19820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 18444, 18578);

                    f_10950_18444_18577(f_10950_18457_18475(namedType) == TypeKind.Struct || (DynAbs.Tracing.TraceSender.Expression_False(10950, 18457, 18533) || f_10950_18498_18516(namedType) == TypeKind.Enum) || (DynAbs.Tracing.TraceSender.Expression_False(10950, 18457, 18576) || f_10950_18537_18555(namedType) == TypeKind.Delegate));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 18676, 19129) || true) && (f_10950_18680_18698(namedType) == TypeKind.Struct || (DynAbs.Tracing.TraceSender.Expression_False(10950, 18680, 18756) || f_10950_18721_18739(namedType) == TypeKind.Enum))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 18676, 19129);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 18676, 19129);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 19149, 19331);
                        foreach (FieldSymbol f in f_10950_19175_19202_I(f_10950_19175_19202(namedType)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 19149, 19331);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 19244, 19312);

                            f_10950_19244_19311(this, embedded, f_10950_19265_19282(f), syntaxNodeOpt, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 19149, 19331);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10950, 1, 183);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10950, 1, 183);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 19351, 19630);
                        foreach (MethodSymbol m in f_10950_19378_19406_I(f_10950_19378_19406(namedType)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 19351, 19630);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 19448, 19611) || true) && ((object)m != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 19448, 19611);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 19519, 19588);

                                f_10950_19519_19587(this, embedded, f_10950_19541_19558(m), syntaxNodeOpt, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 19448, 19611);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 19351, 19630);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10950, 1, 280);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10950, 1, 280);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 18394, 19820);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 19836, 19852);

                return embedded;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10950, 16898, 19863);

                bool
                f_10950_17120_17142(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 17120, 17142);
                    return return_v;
                }


                int
                f_10950_17107_17143(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 17107, 17143);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                f_10950_17174_17199(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 17174, 17199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
                f_10950_17238_17269(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                typeManager, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                underlyingNamedType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType(typeManager, underlyingNamedType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 17238, 17269);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
                f_10950_17306_17350(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                key, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
                value)
                {
                    var return_v = this_param.GetOrAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 17306, 17350);
                    return return_v;
                }


                bool
                f_10950_17387_17408(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 17387, 17408);
                    return return_v;
                }


                int
                f_10950_17585_17657(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmbedAllMembersOfImplementedInterface(syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 17585, 17657);
                    return 0;
                }


                bool
                f_10950_17976_17985_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 17976, 17985);
                    return return_v;
                }


                int
                f_10950_17963_18022(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 17963, 18022);
                    return 0;
                }


                Microsoft.CodeAnalysis.Emit.EmitContext
                f_10950_18087_18198(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                module, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                metadataOnly, bool
                includePrivateMembers)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EmitContext((Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder)module, syntaxNodeOpt, diagnostics, metadataOnly: metadataOnly, includePrivateMembers: includePrivateMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 18087, 18198);
                    return return_v;
                }


                Microsoft.Cci.TypeReferenceIndexer
                f_10950_18058_18199(Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = new Microsoft.Cci.TypeReferenceIndexer(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 18058, 18199);
                    return return_v;
                }


                int
                f_10950_18326_18377(Microsoft.Cci.TypeReferenceIndexer
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
                typeDefinition)
                {
                    this_param.VisitTypeDefinitionNoMembers((Microsoft.Cci.ITypeDefinition)typeDefinition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 18326, 18377);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10950_18457_18475(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 18457, 18475);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10950_18498_18516(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 18498, 18516);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10950_18537_18555(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 18537, 18555);
                    return return_v;
                }


                int
                f_10950_18444_18577(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 18444, 18577);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10950_18680_18698(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 18680, 18698);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10950_18721_18739(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 18721, 18739);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10950_19175_19202(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetFieldsToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 19175, 19202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                f_10950_19265_19282(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 19265, 19282);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedField
                f_10950_19244_19311(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
                type, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                field, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.EmbedField(type, field, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 19244, 19311);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10950_19175_19202_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 19175, 19202);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10950_19378_19406(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMethodsToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 19378, 19406);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10950_19541_19558(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 19541, 19558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod
                f_10950_19519_19587(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
                type, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                method, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.EmbedMethod(type, method, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 19519, 19587);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10950_19378_19406_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 19378, 19406);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10950, 16898, 19863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10950, 16898, 19863);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override EmbeddedField EmbedField(
                    EmbeddedType type,
                    FieldSymbolAdapter field,
                    SyntaxNode syntaxNodeOpt,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10950, 19875, 21522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 20093, 20140);

                f_10950_20093_20139(f_10950_20106_20138(f_10950_20106_20125(field)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 20156, 20212);

                EmbeddedField
                embedded = f_10950_20181_20211(type, field)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 20226, 20293);

                EmbeddedField
                cached = f_10950_20249_20292(EmbeddedFieldsMap, field, embedded)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 20309, 20394) || true) && (embedded != cached)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 20309, 20394);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 20365, 20379);

                    return cached;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 20309, 20394);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 20583, 20644);

                f_10950_20583_20643(f_10950_20596_20605_M(!IsFrozen), "Set of embedded fields is frozen.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 20726, 20780);

                f_10950_20726_20779(this, embedded, syntaxNodeOpt, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 20796, 20865);

                var
                containerKind = f_10950_20816_20864(f_10950_20816_20855(f_10950_20816_20840(field)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 20950, 21479) || true) && (containerKind == TypeKind.Interface || (DynAbs.Tracing.TraceSender.Expression_False(10950, 20954, 21027) || containerKind == TypeKind.Delegate) || (DynAbs.Tracing.TraceSender.Expression_False(10950, 20954, 21195) || (containerKind == TypeKind.Struct && (DynAbs.Tracing.TraceSender.Expression_True(10950, 21049, 21194) && (f_10950_21086_21119(f_10950_21086_21110(field)) || (DynAbs.Tracing.TraceSender.Expression_False(10950, 21086, 21193) || f_10950_21123_21169(f_10950_21123_21147(field)) != Accessibility.Public))))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 20950, 21479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 21319, 21464);

                    f_10950_21319_21463(ErrorCode.ERR_InteropStructContainsMethods, f_10950_21389_21428(f_10950_21389_21413(field)), syntaxNodeOpt, diagnostics, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 20950, 21479);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 21495, 21511);

                return embedded;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10950, 19875, 21522);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10950_20106_20125(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 20106, 20125);
                    return return_v;
                }


                bool
                f_10950_20106_20138(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 20106, 20138);
                    return return_v;
                }


                int
                f_10950_20093_20139(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 20093, 20139);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedField
                f_10950_20181_20211(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                underlyingField)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedField(containingType, underlyingField);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 20181, 20211);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedField
                f_10950_20249_20292(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedField>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                key, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedField
                value)
                {
                    var return_v = this_param.GetOrAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 20249, 20292);
                    return return_v;
                }


                bool
                f_10950_20596_20605_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 20596, 20605);
                    return return_v;
                }


                int
                f_10950_20583_20643(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 20583, 20643);
                    return 0;
                }


                int
                f_10950_20726_20779(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedField
                embeddedMember, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmbedReferences((Microsoft.Cci.ITypeDefinitionMember)embeddedMember, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 20726, 20779);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10950_20816_20840(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedFieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 20816, 20840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10950_20816_20855(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 20816, 20855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10950_20816_20864(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 20816, 20864);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10950_21086_21110(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedFieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 21086, 21110);
                    return return_v;
                }


                bool
                f_10950_21086_21119(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 21086, 21119);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10950_21123_21147(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedFieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 21123, 21147);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10950_21123_21169(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 21123, 21169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10950_21389_21413(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedFieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 21389, 21413);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10950_21389_21428(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 21389, 21428);
                    return return_v;
                }


                int
                f_10950_21319_21463(Microsoft.CodeAnalysis.CSharp.ErrorCode
                error, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                optTypeManager)
                {
                    ReportNotEmbeddableSymbol(error, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, syntaxNodeOpt, diagnostics, optTypeManager);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 21319, 21463);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10950, 19875, 21522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10950, 19875, 21522);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override EmbeddedMethod EmbedMethod(
                    EmbeddedType type,
                    MethodSymbolAdapter method,
                    SyntaxNode syntaxNodeOpt,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10950, 21534, 24421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 21756, 21804);

                f_10950_21756_21803(f_10950_21769_21802(f_10950_21769_21789(method)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 21818, 21892);

                f_10950_21818_21891(!f_10950_21832_21890(f_10950_21832_21858(method)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 21908, 21967);

                EmbeddedMethod
                embedded = f_10950_21934_21966(type, method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 21981, 22051);

                EmbeddedMethod
                cached = f_10950_22005_22050(EmbeddedMethodsMap, method, embedded)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 22067, 22152) || true) && (embedded != cached)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 22067, 22152);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 22123, 22137);

                    return cached;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 22067, 22152);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 22341, 22403);

                f_10950_22341_22402(f_10950_22354_22363_M(!IsFrozen), "Set of embedded methods is frozen.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 22486, 22540);

                f_10950_22486_22539(this, embedded, syntaxNodeOpt, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 22556, 23458);

                switch (f_10950_22564_22620(f_10950_22564_22611(type.UnderlyingNamedType)))
                {

                    case TypeKind.Struct:
                    case TypeKind.Enum:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 22556, 23458);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 22827, 22980);

                        f_10950_22827_22979(ErrorCode.ERR_InteropStructContainsMethods, f_10950_22897_22944(type.UnderlyingNamedType), syntaxNodeOpt, diagnostics, this);
                        DynAbs.Tracing.TraceSender.TraceBreak(10950, 23002, 23008);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 22556, 23458);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 22556, 23458);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 23058, 23415) || true) && (f_10950_23062_23094(embedded))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 23058, 23415);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 23231, 23392);

                            f_10950_23231_23391(diagnostics, ErrorCode.ERR_InteropMethodWithBody, syntaxNodeOpt, f_10950_23302_23390(f_10950_23302_23328(method), f_10950_23345_23389()));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 23058, 23415);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10950, 23437, 23443);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 22556, 23458);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 23588, 23657);

                Symbol
                propertyOrEvent = f_10950_23613_23656(f_10950_23613_23639(method))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 23671, 24378) || true) && ((object)propertyOrEvent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 23671, 24378);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 23740, 24363);

                    switch (f_10950_23748_23768(propertyOrEvent))
                    {

                        case SymbolKind.Property:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 23740, 24363);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 23861, 23960);

                            f_10950_23861_23959(this, type, f_10950_23881_23930(((PropertySymbol)propertyOrEvent)), syntaxNodeOpt, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceBreak(10950, 23986, 23992);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 23740, 24363);

                        case SymbolKind.Event:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 23740, 24363);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 24062, 24193);

                            f_10950_24062_24192(this, type, f_10950_24079_24125(((EventSymbol)propertyOrEvent)), syntaxNodeOpt, diagnostics, isUsedForComAwareEventBinding: false);
                            DynAbs.Tracing.TraceSender.TraceBreak(10950, 24219, 24225);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 23740, 24363);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 23740, 24363);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 24281, 24344);

                            throw f_10950_24287_24343(f_10950_24322_24342(propertyOrEvent));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 23740, 24363);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 23671, 24378);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 24394, 24410);

                return embedded;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10950, 21534, 24421);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10950_21769_21789(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 21769, 21789);
                    return return_v;
                }


                bool
                f_10950_21769_21802(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 21769, 21802);
                    return return_v;
                }


                int
                f_10950_21756_21803(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 21756, 21803);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10950_21832_21858(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 21832, 21858);
                    return return_v;
                }


                bool
                f_10950_21832_21890(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = method.IsDefaultValueTypeConstructor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 21832, 21890);
                    return return_v;
                }


                int
                f_10950_21818_21891(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 21818, 21891);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod
                f_10950_21934_21966(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                underlyingMethod)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod(containingType, underlyingMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 21934, 21966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod
                f_10950_22005_22050(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                key, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod
                value)
                {
                    var return_v = this_param.GetOrAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 22005, 22050);
                    return return_v;
                }


                bool
                f_10950_22354_22363_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 22354, 22363);
                    return return_v;
                }


                int
                f_10950_22341_22402(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 22341, 22402);
                    return 0;
                }


                int
                f_10950_22486_22539(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod
                embeddedMember, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmbedReferences((Microsoft.Cci.ITypeDefinitionMember)embeddedMember, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 22486, 22539);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10950_22564_22611(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 22564, 22611);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10950_22564_22620(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 22564, 22620);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10950_22897_22944(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 22897, 22944);
                    return return_v;
                }


                int
                f_10950_22827_22979(Microsoft.CodeAnalysis.CSharp.ErrorCode
                error, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                optTypeManager)
                {
                    ReportNotEmbeddableSymbol(error, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, syntaxNodeOpt, diagnostics, optTypeManager);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 22827, 22979);
                    return 0;
                }


                bool
                f_10950_23062_23094(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod
                methodDef)
                {
                    var return_v = Cci.Extensions.HasBody(methodDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 23062, 23094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10950_23302_23328(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 23302, 23328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_10950_23345_23389()
                {
                    var return_v = SymbolDisplayFormat.MinimallyQualifiedFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 23345, 23389);
                    return return_v;
                }


                string
                f_10950_23302_23390(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 23302, 23390);
                    return return_v;
                }


                int
                f_10950_23231_23391(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntaxOpt, params object[]
                args)
                {
                    Error(diagnostics, code, syntaxOpt, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 23231, 23391);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10950_23613_23639(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 23613, 23639);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10950_23613_23656(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 23613, 23656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10950_23748_23768(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 23748, 23768);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                f_10950_23881_23930(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 23881, 23930);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedProperty
                f_10950_23861_23959(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
                type, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                property, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.EmbedProperty(type, property, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 23861, 23959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                f_10950_24079_24125(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 24079, 24125);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedEvent
                f_10950_24062_24192(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
                type, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                @event, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                isUsedForComAwareEventBinding)
                {
                    var return_v = this_param.EmbedEvent(type, @event, syntaxNodeOpt, diagnostics, isUsedForComAwareEventBinding: isUsedForComAwareEventBinding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 24062, 24192);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10950_24322_24342(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 24322, 24342);
                    return return_v;
                }


                System.Exception
                f_10950_24287_24343(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 24287, 24343);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10950, 21534, 24421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10950, 21534, 24421);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override EmbeddedProperty EmbedProperty(
                    EmbeddedType type,
                    PropertySymbolAdapter property,
                    SyntaxNode syntaxNodeOpt,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10950, 24433, 26000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 24663, 24721);

                f_10950_24663_24720(f_10950_24676_24719(f_10950_24676_24706(property)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 24787, 24861);

                var
                getMethod = f_10950_24803_24860_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10950_24803_24843(f_10950_24803_24833(property)), 10950, 24803, 24860).GetCciAdapter())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 24875, 24949);

                var
                setMethod = f_10950_24891_24948_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10950_24891_24931(f_10950_24891_24921(property)), 10950, 24891, 24948).GetCciAdapter())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 24965, 25086);

                EmbeddedMethod
                embeddedGet = (DynAbs.Tracing.TraceSender.Conditional_F1(10950, 24994, 25019) || (((object)getMethod != null && DynAbs.Tracing.TraceSender.Conditional_F2(10950, 25022, 25078)) || DynAbs.Tracing.TraceSender.Conditional_F3(10950, 25081, 25085))) ? f_10950_25022_25078(this, type, getMethod, syntaxNodeOpt, diagnostics) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 25100, 25221);

                EmbeddedMethod
                embeddedSet = (DynAbs.Tracing.TraceSender.Conditional_F1(10950, 25129, 25154) || (((object)setMethod != null && DynAbs.Tracing.TraceSender.Conditional_F2(10950, 25157, 25213)) || DynAbs.Tracing.TraceSender.Conditional_F3(10950, 25216, 25220))) ? f_10950_25157_25213(this, type, setMethod, syntaxNodeOpt, diagnostics) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 25237, 25322);

                EmbeddedProperty
                embedded = f_10950_25265_25321(property, embeddedGet, embeddedSet)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 25336, 25413);

                EmbeddedProperty
                cached = f_10950_25362_25412(EmbeddedPropertiesMap, property, embedded)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 25429, 25514) || true) && (embedded != cached)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 25429, 25514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 25485, 25499);

                    return cached;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 25429, 25514);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 25703, 25768);

                f_10950_25703_25767(f_10950_25716_25725_M(!IsFrozen), "Set of embedded properties is frozen.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 25903, 25957);

                f_10950_25903_25956(this, embedded, syntaxNodeOpt, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 25973, 25989);

                return embedded;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10950, 24433, 26000);

                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10950_24676_24706(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedPropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 24676, 24706);
                    return return_v;
                }


                bool
                f_10950_24676_24719(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 24676, 24719);
                    return return_v;
                }


                int
                f_10950_24663_24720(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 24663, 24720);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10950_24803_24833(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedPropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 24803, 24833);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10950_24803_24843(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 24803, 24843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                f_10950_24803_24860_I(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 24803, 24860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10950_24891_24921(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedPropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 24891, 24921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10950_24891_24931(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 24891, 24931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                f_10950_24891_24948_I(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 24891, 24948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod
                f_10950_25022_25078(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
                type, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                method, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.EmbedMethod(type, method, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 25022, 25078);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod
                f_10950_25157_25213(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
                type, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                method, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.EmbedMethod(type, method, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 25157, 25213);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedProperty
                f_10950_25265_25321(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                underlyingProperty, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod?
                getter, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod?
                setter)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedProperty(underlyingProperty, getter, setter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 25265, 25321);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedProperty
                f_10950_25362_25412(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedProperty>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                key, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedProperty
                value)
                {
                    var return_v = this_param.GetOrAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 25362, 25412);
                    return return_v;
                }


                bool
                f_10950_25716_25725_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 25716, 25725);
                    return return_v;
                }


                int
                f_10950_25703_25767(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 25703, 25767);
                    return 0;
                }


                int
                f_10950_25903_25956(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedProperty
                embeddedMember, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmbedReferences((Microsoft.Cci.ITypeDefinitionMember)embeddedMember, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 25903, 25956);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10950, 24433, 26000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10950, 24433, 26000);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override EmbeddedEvent EmbedEvent(
                    EmbeddedType type,
                    EventSymbolAdapter @event,
                    SyntaxNode syntaxNodeOpt,
                    DiagnosticBag diagnostics,
                    bool isUsedForComAwareEventBinding)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10950, 26012, 27939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 26280, 26328);

                f_10950_26280_26327(f_10950_26293_26326(f_10950_26293_26313(@event)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 26394, 26463);

                var
                addMethod = f_10950_26410_26462_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10950_26410_26445(f_10950_26410_26435(@event)), 10950, 26410, 26462).GetCciAdapter())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 26477, 26552);

                var
                removeMethod = f_10950_26496_26551_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10950_26496_26534(f_10950_26496_26521(@event)), 10950, 26496, 26551).GetCciAdapter())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 26568, 26689);

                EmbeddedMethod
                embeddedAdd = (DynAbs.Tracing.TraceSender.Conditional_F1(10950, 26597, 26622) || (((object)addMethod != null && DynAbs.Tracing.TraceSender.Conditional_F2(10950, 26625, 26681)) || DynAbs.Tracing.TraceSender.Conditional_F3(10950, 26684, 26688))) ? f_10950_26625_26681(this, type, addMethod, syntaxNodeOpt, diagnostics) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 26703, 26833);

                EmbeddedMethod
                embeddedRemove = (DynAbs.Tracing.TraceSender.Conditional_F1(10950, 26735, 26763) || (((object)removeMethod != null && DynAbs.Tracing.TraceSender.Conditional_F2(10950, 26766, 26825)) || DynAbs.Tracing.TraceSender.Conditional_F3(10950, 26828, 26832))) ? f_10950_26766_26825(this, type, removeMethod, syntaxNodeOpt, diagnostics) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 26849, 26929);

                EmbeddedEvent
                embedded = f_10950_26874_26928(@event, embeddedAdd, embeddedRemove)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 26943, 27011);

                EmbeddedEvent
                cached = f_10950_26966_27010(EmbeddedEventsMap, @event, embedded)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 27027, 27334) || true) && (embedded != cached)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 27027, 27334);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 27083, 27285) || true) && (isUsedForComAwareEventBinding)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 27083, 27285);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 27158, 27266);

                        f_10950_27158_27265(cached, syntaxNodeOpt, diagnostics, isUsedForComAwareEventBinding);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 27083, 27285);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 27305, 27319);

                    return cached;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 27027, 27334);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 27523, 27584);

                f_10950_27523_27583(f_10950_27536_27545_M(!IsFrozen), "Set of embedded events is frozen.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 27716, 27770);

                f_10950_27716_27769(this, embedded, syntaxNodeOpt, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 27786, 27896);

                f_10950_27786_27895(
                            embedded, syntaxNodeOpt, diagnostics, isUsedForComAwareEventBinding);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 27912, 27928);

                return embedded;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10950, 26012, 27939);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10950_26293_26313(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 26293, 26313);
                    return return_v;
                }


                bool
                f_10950_26293_26326(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 26293, 26326);
                    return return_v;
                }


                int
                f_10950_26280_26327(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 26280, 26327);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10950_26410_26435(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedEventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 26410, 26435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10950_26410_26445(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AddMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 26410, 26445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                f_10950_26410_26462_I(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 26410, 26462);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10950_26496_26521(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedEventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 26496, 26521);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10950_26496_26534(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.RemoveMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 26496, 26534);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                f_10950_26496_26551_I(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 26496, 26551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod
                f_10950_26625_26681(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
                type, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                method, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.EmbedMethod(type, method, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 26625, 26681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod
                f_10950_26766_26825(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
                type, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                method, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.EmbedMethod(type, method, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 26766, 26825);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedEvent
                f_10950_26874_26928(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                underlyingEvent, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod?
                adder, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod?
                remover)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedEvent(underlyingEvent, adder, remover);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 26874, 26928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedEvent
                f_10950_26966_27010(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedEvent>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                key, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedEvent
                value)
                {
                    var return_v = this_param.GetOrAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 26966, 27010);
                    return return_v;
                }


                int
                f_10950_27158_27265(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedEvent
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                isUsedForComAwareEventBinding)
                {
                    this_param.EmbedCorrespondingComEventInterfaceMethod(syntaxNodeOpt, diagnostics, isUsedForComAwareEventBinding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 27158, 27265);
                    return 0;
                }


                bool
                f_10950_27536_27545_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 27536, 27545);
                    return return_v;
                }


                int
                f_10950_27523_27583(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 27523, 27583);
                    return 0;
                }


                int
                f_10950_27716_27769(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedEvent
                embeddedMember, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmbedReferences((Microsoft.Cci.ITypeDefinitionMember)embeddedMember, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 27716, 27769);
                    return 0;
                }


                int
                f_10950_27786_27895(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedEvent
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                isUsedForComAwareEventBinding)
                {
                    this_param.EmbedCorrespondingComEventInterfaceMethod(syntaxNodeOpt, diagnostics, isUsedForComAwareEventBinding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 27786, 27895);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10950, 26012, 27939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10950, 26012, 27939);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override EmbeddedType GetEmbeddedTypeForMember(SymbolAdapter member, SyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10950, 27951, 28811);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 28107, 28155);

                f_10950_28107_28154(f_10950_28120_28153(f_10950_28120_28140(member)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 28169, 28246);

                f_10950_28169_28245(f_10950_28182_28244(ModuleBeingBuilt.SourceModule));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 28262, 28326);

                NamedTypeSymbol
                namedType = f_10950_28290_28325(f_10950_28290_28310(member))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 28342, 28772) || true) && (f_10950_28346_28412(namedType, syntaxNodeOpt, diagnostics, this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10950, 28342, 28772);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 28633, 28667);

                    const bool
                    fromImplements = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 28685, 28757);

                    return f_10950_28692_28756(this, namedType, fromImplements, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10950, 28342, 28772);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 28788, 28800);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10950, 27951, 28811);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10950_28120_28140(Microsoft.CodeAnalysis.CSharp.SymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 28120, 28140);
                    return return_v;
                }


                bool
                f_10950_28120_28153(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 28120, 28153);
                    return return_v;
                }


                int
                f_10950_28107_28154(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 28107, 28154);
                    return 0;
                }


                bool
                f_10950_28182_28244(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.AnyReferencedAssembliesAreLinked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 28182, 28244);
                    return return_v;
                }


                int
                f_10950_28169_28245(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 28169, 28245);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10950_28290_28310(Microsoft.CodeAnalysis.CSharp.SymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 28290, 28310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10950_28290_28325(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 28290, 28325);
                    return return_v;
                }


                bool
                f_10950_28346_28412(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedType, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                optTypeManager)
                {
                    var return_v = IsValidEmbeddableType(namedType, syntaxNodeOpt, diagnostics, optTypeManager);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 28346, 28412);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
                f_10950_28692_28756(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedType, bool
                fromImplements, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.EmbedType(namedType, fromImplements, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 28692, 28756);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10950, 27951, 28811);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10950, 27951, 28811);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<EmbeddedParameter> EmbedParameters(
                    CommonEmbeddedMember containingPropertyOrMethod,
                    ImmutableArray<ParameterSymbol> underlyingParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10950, 28823, 29179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 29043, 29168);

                return underlyingParameters.SelectAsArray((p, c) => new EmbeddedParameter(c, p.GetCciAdapter()), containingPropertyOrMethod);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10950, 28823, 29179);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10950, 28823, 29179);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10950, 28823, 29179);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CSharpAttributeData CreateCompilerGeneratedAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10950, 29191, 29643);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 29289, 29433);

                f_10950_29289_29432(f_10950_29302_29431(WellKnownMember.System_Runtime_CompilerServices_CompilerGeneratedAttribute__ctor));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 29447, 29494);

                var
                compilation = ModuleBeingBuilt.Compilation
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10950, 29508, 29632);

                return f_10950_29515_29631(compilation, WellKnownMember.System_Runtime_CompilerServices_CompilerGeneratedAttribute__ctor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10950, 29191, 29643);

                bool
                f_10950_29302_29431(Microsoft.CodeAnalysis.WellKnownMember
                attributeMember)
                {
                    var return_v = WellKnownMembers.IsSynthesizedAttributeOptional(attributeMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 29302, 29431);
                    return return_v;
                }


                int
                f_10950_29289_29432(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 29289, 29432);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10950_29515_29631(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 29515, 29631);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10950, 29191, 29643);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10950, 29191, 29643);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EmbeddedTypesManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10950, 1292, 29650);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10950, 1292, 29650);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10950, 1292, 29650);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10950, 1292, 29650);

        System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, string>
        f_10950_1923_2007(Roslyn.Utilities.ReferenceEqualityComparer
        comparer)
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, string>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 1923, 2007);
            return return_v;
        }


        System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, bool>
        f_10950_2092_2166(Roslyn.Utilities.ReferenceEqualityComparer
        comparer)
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, bool>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10950, 2092, 2166);
            return return_v;
        }


        int
        f_10950_2572_2604(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10950, 2572, 2604);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
        f_10950_2421_2437_C(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10950, 2339, 2732);
            return return_v;
        }

    }
}
