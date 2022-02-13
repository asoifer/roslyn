// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal delegate void ReportMismatchInReturnType<TArg>(DiagnosticBag bag, MethodSymbol overriddenMethod, MethodSymbol overridingMethod, bool topLevel, TArg arg);
    internal delegate void ReportMismatchInParameterType<TArg>(DiagnosticBag bag, MethodSymbol overriddenMethod, MethodSymbol overridingMethod, ParameterSymbol parameter, bool topLevel, TArg arg);
    internal partial class SourceMemberContainerTypeSymbol
    {
        internal ImmutableArray<SynthesizedExplicitImplementationForwardingMethod> GetSynthesizedExplicitImplementations(
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10217, 1388, 3352);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 1576, 3278) || true) && (_lazySynthesizedExplicitImplementations.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 1576, 3278);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 1663, 1709);

                    var
                    diagnostics = f_10217_1681_1708()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 1771, 1820);

                        cancellationToken.ThrowIfCancellationRequested();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 1842, 1902);

                        f_10217_1842_1901(this, diagnostics, cancellationToken);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 1926, 1975);

                        cancellationToken.ThrowIfCancellationRequested();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 1997, 2044);

                        f_10217_1997_2043(this, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 2068, 2117);

                        cancellationToken.ThrowIfCancellationRequested();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 2139, 2178);

                        f_10217_2139_2177(this, diagnostics);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 2202, 2417) || true) && (f_10217_2206_2222(this))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 2202, 2417);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 2272, 2321);

                            cancellationToken.ThrowIfCancellationRequested();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 2347, 2394);

                            f_10217_2347_2393(this, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 2202, 2417);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 2441, 3140) || true) && (f_10217_2445_2766(ref _lazySynthesizedExplicitImplementations, f_10217_2597_2660(this, diagnostics, cancellationToken), default(ImmutableArray<SynthesizedExplicitImplementationForwardingMethod>)).IsDefault)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 2441, 3140);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 2976, 3015);

                            f_10217_2976_3014(this, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 3043, 3117);

                            state.NotePartComplete(CompletionPart.SynthesizedExplicitImplementations);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 2441, 3140);
                        }
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(10217, 3177, 3263);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 3225, 3244);

                        f_10217_3225_3243(diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(10217, 3177, 3263);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 1576, 3278);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 3294, 3341);

                return _lazySynthesizedExplicitImplementations;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10217, 1388, 3352);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10217_1681_1708()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 1681, 1708);
                    return return_v;
                }


                int
                f_10217_1842_1901(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.CheckMembersAgainstBaseType(diagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 1842, 1901);
                    return 0;
                }


                int
                f_10217_1997_2043(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckAbstractClassImplementations(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 1997, 2043);
                    return 0;
                }


                int
                f_10217_2139_2177(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckInterfaceUnification(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 2139, 2177);
                    return 0;
                }


                bool
                f_10217_2206_2222(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 2206, 2222);
                    return return_v;
                }


                int
                f_10217_2347_2393(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                interfaceType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    interfaceType.CheckInterfaceVarianceSafety(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 2347, 2393);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod>
                f_10217_2597_2660(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.ComputeInterfaceImplementations(diagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 2597, 2660);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod>
                f_10217_2445_2766(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod>
                value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod>
                comparand)
                {
                    var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 2445, 2766);
                    return return_v;
                }


                int
                f_10217_2976_3014(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.AddDeclarationDiagnostics(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 2976, 3014);
                    return 0;
                }


                int
                f_10217_3225_3243(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 3225, 3243);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 1388, 3352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 1388, 3352);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckAbstractClassImplementations(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10217, 3364, 4396);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 3462, 3523);

                NamedTypeSymbol
                baseType = f_10217_3489_3522(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 3539, 3666) || true) && (f_10217_3543_3558(this) || (DynAbs.Tracing.TraceSender.Expression_False(10217, 3543, 3586) || (object)baseType == null) || (DynAbs.Tracing.TraceSender.Expression_False(10217, 3543, 3610) || f_10217_3590_3610_M(!baseType.IsAbstract)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 3539, 3666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 3644, 3651);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 3539, 3666);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 3924, 4385);
                    foreach (var abstractMember in f_10217_3955_3975_I(f_10217_3955_3975(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 3924, 4385);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 4108, 4370) || true) && (f_10217_4112_4131(abstractMember) == SymbolKind.Method && (DynAbs.Tracing.TraceSender.Expression_True(10217, 4112, 4209) && abstractMember is not SynthesizedRecordOrdinaryMethod))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 4108, 4370);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 4251, 4351);

                            f_10217_4251_4350(diagnostics, ErrorCode.ERR_UnimplementedAbstractMethod, f_10217_4310_4324(this)[0], this, abstractMember);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 4108, 4370);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 3924, 4385);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10217, 1, 462);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10217, 1, 462);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10217, 3364, 4396);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10217_3489_3522(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 3489, 3522);
                    return return_v;
                }


                bool
                f_10217_3543_3558(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 3543, 3558);
                    return return_v;
                }


                bool
                f_10217_3590_3610_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 3590, 3610);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10217_3955_3975(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.AbstractMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 3955, 3975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10217_4112_4131(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 4112, 4131);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10217_4310_4324(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 4310, 4324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10217_4251_4350(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 4251, 4350);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10217_3955_3975_I(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 3955, 3975);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 3364, 4396);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 3364, 4396);
            }
        }

        private ImmutableArray<SynthesizedExplicitImplementationForwardingMethod> ComputeInterfaceImplementations(
                    DiagnosticBag diagnostics,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10217, 4408, 19801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 4629, 4740);

                var
                synthesizedImplementations = f_10217_4662_4739()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 5146, 5280);

                MultiDictionary<NamedTypeSymbol, NamedTypeSymbol>
                interfacesAndTheirBases = f_10217_5222_5279(this)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 5296, 19719);
                    foreach (var @interface in f_10217_5323_5361_I(f_10217_5323_5361(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 5296, 19719);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 5395, 5444);

                        cancellationToken.ThrowIfCancellationRequested();

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 5464, 5595) || true) && (!interfacesAndTheirBases[@interface].Contains(@interface))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 5464, 5595);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 5567, 5576);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 5464, 5595);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 5615, 5690);

                        HasBaseTypeDeclaringInterfaceResult?
                        hasBaseClassDeclaringInterface = null
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 5710, 19704);
                            foreach (var interfaceMember in f_10217_5742_5774_I(f_10217_5742_5774(@interface)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 5710, 19704);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 5816, 5865);

                                cancellationToken.ThrowIfCancellationRequested();
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 5985, 6039);

                                SymbolKind
                                interfaceMemberKind = f_10217_6018_6038(interfaceMember)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 6061, 6581);

                                switch (interfaceMemberKind)
                                {

                                    case SymbolKind.Method:
                                    case SymbolKind.Property:
                                    case SymbolKind.Event:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 6061, 6581);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 6290, 6449) || true) && (!f_10217_6295_6343(interfaceMember))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 6290, 6449);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 6409, 6418);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 6290, 6449);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(10217, 6479, 6485);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 6061, 6581);

                                    default:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 6061, 6581);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 6549, 6558);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 6061, 6581);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 6605, 6659);

                                SymbolAndDiagnostics
                                implementingMemberAndDiagnostics
                                = default(SymbolAndDiagnostics);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 6683, 7972) || true) && (f_10217_6687_6703(this))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 6683, 7972);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 6753, 6875);

                                    MultiDictionary<Symbol, Symbol>.ValueSet
                                    explicitImpl = f_10217_6809_6874(this, interfaceMember)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 6903, 7728);

                                    switch (explicitImpl.Count)
                                    {

                                        case 0:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 6903, 7728);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 7028, 7037);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 6903, 7728);

                                        case 1:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 6903, 7728);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 7173, 7290);

                                            implementingMemberAndDiagnostics = f_10217_7208_7289(explicitImpl.Single(), ImmutableArray<Diagnostic>.Empty);
                                            DynAbs.Tracing.TraceSender.TraceBreak(10217, 7324, 7330);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 6903, 7728);

                                        default:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 6903, 7728);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 7402, 7532);

                                            Diagnostic
                                            diag = f_10217_7420_7531(f_10217_7437_7511(ErrorCode.ERR_DuplicateExplicitImpl, interfaceMember), f_10217_7513_7527(this)[0])
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 7566, 7661);

                                            implementingMemberAndDiagnostics = f_10217_7601_7660(null, f_10217_7632_7659(diag));
                                            DynAbs.Tracing.TraceSender.TraceBreak(10217, 7695, 7701);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 6903, 7728);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 6683, 7972);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 6683, 7972);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 7826, 7949);

                                    implementingMemberAndDiagnostics = f_10217_7861_7948(this, interfaceMember);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 6683, 7972);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 7996, 8061);

                                var
                                implementingMember = implementingMemberAndDiagnostics.Symbol
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 8083, 8211);

                                var
                                synthesizedImplementation = f_10217_8115_8210(this, implementingMemberAndDiagnostics, interfaceMember)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 8235, 8304);

                                bool
                                wasImplementingMemberFound = (object)implementingMember != null
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 8328, 9011) || true) && ((object)synthesizedImplementation != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 8328, 9011);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 8423, 8988) || true) && (f_10217_8427_8461(synthesizedImplementation))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 8423, 8988);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 8519, 8789);

                                        f_10217_8519_8788(diagnostics, ErrorCode.ERR_InterfaceImplementedImplicitlyByVariadic, f_10217_8658_8744(interfaceMember, this, implementingMember), implementingMember, interfaceMember, this);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 8423, 8988);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 8423, 8988);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 8903, 8961);

                                        f_10217_8903_8960(synthesizedImplementations, synthesizedImplementation);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 8423, 8988);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 8328, 9011);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 9035, 11075) || true) && (wasImplementingMemberFound && (DynAbs.Tracing.TraceSender.Expression_True(10217, 9039, 9108) && interfaceMemberKind == SymbolKind.Event))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 9035, 11075);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 9502, 9560);

                                    EventSymbol
                                    interfaceEvent = (EventSymbol)interfaceMember
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 9586, 9650);

                                    EventSymbol
                                    implementingEvent = (EventSymbol)implementingMember
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 9676, 9704);

                                    EventSymbol
                                    maybeWinRTEvent
                                    = default(EventSymbol);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 9730, 9760);

                                    EventSymbol
                                    maybeRegularEvent
                                    = default(EventSymbol);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 9788, 10307) || true) && (f_10217_9792_9828(interfaceEvent))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 9788, 10307);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 9886, 9919);

                                        maybeWinRTEvent = interfaceEvent;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 9970, 10008);

                                        maybeRegularEvent = implementingEvent;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 9788, 10307);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 9788, 10307);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 10140, 10176);

                                        maybeWinRTEvent = implementingEvent;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 10222, 10257);

                                        maybeRegularEvent = interfaceEvent;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 9788, 10307);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 10335, 11052) || true) && (f_10217_10339_10375(interfaceEvent) != f_10217_10379_10418(implementingEvent))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 10335, 11052);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 10650, 10748);

                                        var
                                        args = new object[] { implementingEvent, interfaceEvent, maybeWinRTEvent, maybeRegularEvent }
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 10778, 10941);

                                        var
                                        info = f_10217_10789_10940(ErrorCode.ERR_MixingWinRTEventWithRegular, args, ImmutableArray<Symbol>.Empty, f_10217_10889_10939(f_10217_10921_10935(this)[0]))
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 10971, 11025);

                                        f_10217_10971_11024(diagnostics, info, f_10217_10993_11020(implementingEvent)[0]);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 10335, 11052);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 9035, 11075);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 11292, 11423);

                                var
                                associatedPropertyOrEvent = (DynAbs.Tracing.TraceSender.Conditional_F1(10217, 11324, 11364) || ((interfaceMemberKind == SymbolKind.Method && DynAbs.Tracing.TraceSender.Conditional_F2(10217, 11367, 11415)) || DynAbs.Tracing.TraceSender.Conditional_F3(10217, 11418, 11422))) ? f_10217_11367_11415(((MethodSymbol)interfaceMember)) : null
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 11445, 19685) || true) && ((object)associatedPropertyOrEvent == null || (DynAbs.Tracing.TraceSender.Expression_False(10217, 11449, 11586) || f_10217_11519_11586(this, associatedPropertyOrEvent)) || (DynAbs.Tracing.TraceSender.Expression_False(10217, 11449, 11679) || (wasImplementingMemberFound && (DynAbs.Tracing.TraceSender.Expression_True(10217, 11616, 11678) && !f_10217_11647_11678(implementingMember)))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 11445, 19685);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 12090, 12119);

                                    bool
                                    reportedAnError = false
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 12145, 12493) || true) && (implementingMemberAndDiagnostics.Diagnostics.Any())
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 12145, 12493);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 12257, 12324);

                                        f_10217_12257_12323(diagnostics, implementingMemberAndDiagnostics.Diagnostics);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 12354, 12466);

                                        reportedAnError = implementingMemberAndDiagnostics.Diagnostics.Any(d => d.Severity == DiagnosticSeverity.Error);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 12145, 12493);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 12521, 19662) || true) && (!reportedAnError)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 12521, 19662);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 12599, 17041) || true) && (!wasImplementingMemberFound || (DynAbs.Tracing.TraceSender.Expression_False(10217, 12603, 12941) || (!f_10217_12669_12751(f_10217_12669_12702(implementingMember), this, TypeCompareKind.ConsiderEverything) && (DynAbs.Tracing.TraceSender.Expression_True(10217, 12668, 12940) && f_10217_12788_12940(f_10217_12788_12844(implementingMember), interfaceMember, ExplicitInterfaceImplementationTargetMemberEqualityComparer.Instance)))))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 12599, 17041);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 13694, 13804);

                                            hasBaseClassDeclaringInterface = hasBaseClassDeclaringInterface ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol.HasBaseTypeDeclaringInterfaceResult?>(10217, 13727, 13803) ?? f_10217_13761_13803(this, @interface));
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 13840, 13941);

                                            HasBaseTypeDeclaringInterfaceResult
                                            matchResult = f_10217_13890_13940(hasBaseClassDeclaringInterface)
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 13977, 14366) || true) && (matchResult != HasBaseTypeDeclaringInterfaceResult.ExactMatch && (DynAbs.Tracing.TraceSender.Expression_True(10217, 13981, 14109) && wasImplementingMemberFound) && (DynAbs.Tracing.TraceSender.Expression_True(10217, 13981, 14158) && f_10217_14113_14158(f_10217_14113_14146(implementingMember))))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 13977, 14366);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 14232, 14331);

                                                f_10217_14232_14330(this, f_10217_14267_14300(implementingMember), @interface, ref matchResult);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 13977, 14366);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 14641, 17010);

                                            switch (matchResult)
                                            {

                                                case HasBaseTypeDeclaringInterfaceResult.NoMatch:
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 14641, 17010);
                                                    {

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 15234, 16260) || true) && (!f_10217_15239_15280(interfaceMember) && (DynAbs.Tracing.TraceSender.Expression_True(10217, 15238, 15320) && !f_10217_15285_15320(interfaceMember)))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 15234, 16260);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 15418, 15492);

                                                            DiagnosticInfo
                                                            useSiteDiagnostic = f_10217_15453_15491(interfaceMember)
                                                            ;

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 15544, 16213) || true) && (useSiteDiagnostic != null && (DynAbs.Tracing.TraceSender.Expression_True(10217, 15548, 15638) && f_10217_15577_15610(useSiteDiagnostic) == DiagnosticSeverity.Error))
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 15544, 16213);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 15744, 15824);

                                                                f_10217_15744_15823(diagnostics, useSiteDiagnostic, f_10217_15779_15822(this, @interface));
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 15544, 16213);
                                                            }

                                                            else

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 15544, 16213);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 16034, 16162);

                                                                f_10217_16034_16161(diagnostics, ErrorCode.ERR_UnimplementedInterfaceMember, f_10217_16094_16137(this, @interface), this, interfaceMember);
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 15544, 16213);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 15234, 16260);
                                                        }
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceBreak(10217, 16345, 16351);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 14641, 17010);

                                                case HasBaseTypeDeclaringInterfaceResult.ExactMatch:
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 14641, 17010);
                                                    DynAbs.Tracing.TraceSender.TraceBreak(10217, 16485, 16491);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 14641, 17010);

                                                case HasBaseTypeDeclaringInterfaceResult.IgnoringNullableMatch:
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 14641, 17010);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 16636, 16783);

                                                    f_10217_16636_16782(diagnostics, ErrorCode.WRN_NullabilityMismatchInInterfaceImplementedByBase, f_10217_16715_16758(this, @interface), this, interfaceMember);
                                                    DynAbs.Tracing.TraceSender.TraceBreak(10217, 16825, 16831);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 14641, 17010);

                                                default:
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 14641, 17010);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 16921, 16975);

                                                    throw f_10217_16927_16974(matchResult);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 14641, 17010);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 12599, 17041);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 17073, 19635) || true) && (wasImplementingMemberFound && (DynAbs.Tracing.TraceSender.Expression_True(10217, 17077, 17147) && interfaceMemberKind == SymbolKind.Method))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 17073, 19635);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 17643, 19604) || true) && ((object)synthesizedImplementation != null || (DynAbs.Tracing.TraceSender.Expression_False(10217, 17647, 17787) || f_10217_17692_17787(f_10217_17710_17743(implementingMember), this, TypeCompareKind.ConsiderEverything2)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 17643, 19604);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 17861, 17935);

                                                DiagnosticInfo
                                                useSiteDiagnostic = f_10217_17896_17934(interfaceMember)
                                                ;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 18408, 19569) || true) && (useSiteDiagnostic != null && (DynAbs.Tracing.TraceSender.Expression_True(10217, 18412, 18514) && (ErrorCode)f_10217_18452_18474(useSiteDiagnostic) != ErrorCode.ERR_ByRefReturnUnsupported))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 18408, 19569);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 19187, 19415);

                                                    Location
                                                    location = (DynAbs.Tracing.TraceSender.Conditional_F1(10217, 19207, 19270) || ((f_10217_19207_19270(implementingMember, f_10217_19244_19269(this)) && DynAbs.Tracing.TraceSender.Conditional_F2(10217, 19318, 19349)) || DynAbs.Tracing.TraceSender.Conditional_F3(10217, 19397, 19414))) ? f_10217_19318_19346(implementingMember)[0]
                                                    : f_10217_19397_19411(this)[0]
                                                    ;
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 19457, 19530);

                                                    f_10217_19457_19529(useSiteDiagnostic, diagnostics, location);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 18408, 19569);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 17643, 19604);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 17073, 19635);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 12521, 19662);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 11445, 19685);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 5710, 19704);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10217, 1, 13995);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10217, 1, 13995);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 5296, 19719);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10217, 1, 14424);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10217, 1, 14424);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 19735, 19790);

                return f_10217_19742_19789(synthesizedImplementations);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10217, 4408, 19801);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod>
                f_10217_4662_4739()
                {
                    var return_v = ArrayBuilder<SynthesizedExplicitImplementationForwardingMethod>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 4662, 4739);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10217_5222_5279(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.InterfacesAndTheirBaseInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 5222, 5279);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10217_5323_5361(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.AllInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 5323, 5361);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10217_5742_5774(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 5742, 5774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10217_6018_6038(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 6018, 6038);
                    return return_v;
                }


                bool
                f_10217_6295_6343(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsImplementableInterfaceMember();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 6295, 6343);
                    return return_v;
                }


                bool
                f_10217_6687_6703(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 6687, 6703);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                f_10217_6809_6874(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember)
                {
                    var return_v = this_param.GetExplicitImplementationForInterfaceMember(interfaceMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 6809, 6874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.SymbolAndDiagnostics
                f_10217_7208_7289(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.SymbolAndDiagnostics(symbol, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 7208, 7289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10217_7437_7511(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 7437, 7511);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10217_7513_7527(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 7513, 7527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10217_7420_7531(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 7420, 7531);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10217_7632_7659(Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 7632, 7659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.SymbolAndDiagnostics
                f_10217_7601_7660(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.SymbolAndDiagnostics(symbol, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 7601, 7660);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.SymbolAndDiagnostics
                f_10217_7861_7948(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember)
                {
                    var return_v = this_param.FindImplementationForInterfaceMemberInNonInterfaceWithDiagnostics(interfaceMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 7861, 7948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod
                f_10217_8115_8210(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.SymbolAndDiagnostics
                implementingMemberAndDiagnostics, Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember)
                {
                    var return_v = this_param.SynthesizeInterfaceMemberImplementation(implementingMemberAndDiagnostics, interfaceMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 8115, 8210);
                    return return_v;
                }


                bool
                f_10217_8427_8461(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod
                this_param)
                {
                    var return_v = this_param.IsVararg;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 8427, 8461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10217_8658_8744(Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                implementingType, Microsoft.CodeAnalysis.CSharp.Symbol?
                member)
                {
                    var return_v = GetImplicitImplementationDiagnosticLocation(interfaceMember, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)implementingType, member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 8658, 8744);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10217_8519_8788(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 8519, 8788);
                    return return_v;
                }


                int
                f_10217_8903_8960(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 8903, 8960);
                    return 0;
                }


                bool
                f_10217_9792_9828(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.IsWindowsRuntimeEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 9792, 9828);
                    return return_v;
                }


                bool
                f_10217_10339_10375(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.IsWindowsRuntimeEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 10339, 10375);
                    return return_v;
                }


                bool
                f_10217_10379_10418(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol?
                this_param)
                {
                    var return_v = this_param.IsWindowsRuntimeEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 10379, 10418);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10217_10921_10935(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 10921, 10935);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10217_10889_10939(Microsoft.CodeAnalysis.Location
                item)
                {
                    var return_v = ImmutableArray.Create<Location>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 10889, 10939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10217_10789_10940(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, object[]
                args, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                additionalLocations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args, symbols, additionalLocations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 10789, 10940);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10217_10993_11020(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 10993, 11020);
                    return return_v;
                }


                int
                f_10217_10971_11024(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 10971, 11024);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10217_11367_11415(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 11367, 11415);
                    return return_v;
                }


                bool
                f_10217_11519_11586(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                interfacePropertyOrEvent)
                {
                    var return_v = this_param.ReportAccessorOfInterfacePropertyOrEvent(interfacePropertyOrEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 11519, 11586);
                    return return_v;
                }


                bool
                f_10217_11647_11678(Microsoft.CodeAnalysis.CSharp.Symbol?
                symbol)
                {
                    var return_v = symbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 11647, 11678);
                    return return_v;
                }


                int
                f_10217_12257_12323(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 12257, 12323);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10217_12669_12702(Microsoft.CodeAnalysis.CSharp.Symbol?
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 12669, 12702);
                    return return_v;
                }


                bool
                f_10217_12669_12751(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 12669, 12751);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10217_12788_12844(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.GetExplicitInterfaceImplementations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 12788, 12844);
                    return return_v;
                }


                bool
                f_10217_12788_12940(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                list, Microsoft.CodeAnalysis.CSharp.Symbol
                item, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.ExplicitInterfaceImplementationTargetMemberEqualityComparer
                comparer)
                {
                    var return_v = list.Contains<Microsoft.CodeAnalysis.CSharp.Symbol>(item, (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 12788, 12940);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol.HasBaseTypeDeclaringInterfaceResult
                f_10217_13761_13803(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                @interface)
                {
                    var return_v = this_param.HasBaseClassDeclaringInterface(@interface);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 13761, 13803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol.HasBaseTypeDeclaringInterfaceResult
                f_10217_13890_13940(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol.HasBaseTypeDeclaringInterfaceResult?
                this_param)
                {
                    var return_v = this_param.GetValueOrDefault();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 13890, 13940);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10217_14113_14146(Microsoft.CodeAnalysis.CSharp.Symbol?
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 14113, 14146);
                    return return_v;
                }


                bool
                f_10217_14113_14158(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 14113, 14158);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10217_14267_14300(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 14267, 14300);
                    return return_v;
                }


                int
                f_10217_14232_14330(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                baseInterface, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                @interface, ref Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol.HasBaseTypeDeclaringInterfaceResult
                matchResult)
                {
                    this_param.HasBaseInterfaceDeclaringInterface(baseInterface, @interface, ref matchResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 14232, 14330);
                    return 0;
                }


                bool
                f_10217_15239_15280(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.MustCallMethodsDirectly();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 15239, 15280);
                    return return_v;
                }


                bool
                f_10217_15285_15320(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsIndexedProperty();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 15285, 15320);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10217_15453_15491(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 15453, 15491);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10217_15577_15610(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.DefaultSeverity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 15577, 15610);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10217_15779_15822(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                implementedInterface)
                {
                    var return_v = this_param.GetImplementsLocationOrFallback(implementedInterface);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 15779, 15822);
                    return return_v;
                }


                int
                f_10217_15744_15823(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 15744, 15823);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10217_16094_16137(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                implementedInterface)
                {
                    var return_v = this_param.GetImplementsLocationOrFallback(implementedInterface);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 16094, 16137);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10217_16034_16161(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 16034, 16161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10217_16715_16758(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                implementedInterface)
                {
                    var return_v = this_param.GetImplementsLocationOrFallback(implementedInterface);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 16715, 16758);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10217_16636_16782(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 16636, 16782);
                    return return_v;
                }


                System.Exception
                f_10217_16927_16974(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol.HasBaseTypeDeclaringInterfaceResult
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 16927, 16974);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10217_17710_17743(Microsoft.CodeAnalysis.CSharp.Symbol?
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 17710, 17743);
                    return return_v;
                }


                bool
                f_10217_17692_17787(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 17692, 17787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10217_17896_17934(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 17896, 17934);
                    return return_v;
                }


                int
                f_10217_18452_18474(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 18452, 18474);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10217_19244_19269(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 19244, 19269);
                    return return_v;
                }


                bool
                f_10217_19207_19270(Microsoft.CodeAnalysis.CSharp.Symbol?
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.IsFromCompilation(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 19207, 19270);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10217_19318_19346(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 19318, 19346);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10217_19397_19411(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 19397, 19411);
                    return return_v;
                }


                bool
                f_10217_19457_19529(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Symbol.ReportUseSiteDiagnostic(info, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 19457, 19529);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10217_5742_5774_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 5742, 5774);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10217_5323_5361_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 5323, 5361);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod>
                f_10217_19742_19789(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 19742, 19789);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 4408, 19801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 4408, 19801);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract Location GetCorrespondingBaseListLocation(NamedTypeSymbol @base);

        private Location GetImplementsLocationOrFallback(NamedTypeSymbol implementedInterface)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10217, 19927, 20121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 20038, 20110);

                return f_10217_20045_20088(this, implementedInterface) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Location?>(10217, 20045, 20109) ?? f_10217_20092_20106(this)[0]);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10217, 19927, 20121);

                Microsoft.CodeAnalysis.Location?
                f_10217_20045_20088(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                implementedInterface)
                {
                    var return_v = this_param.GetImplementsLocation(implementedInterface);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 20045, 20088);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10217_20092_20106(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 20092, 20106);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 19927, 20121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 19927, 20121);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Location? GetImplementsLocation(NamedTypeSymbol implementedInterface)
        {
            try
#nullable disable
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10217, 20133, 21459);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 20533, 20658);

                f_10217_20533_20657(f_10217_20546_20603(this)[implementedInterface].Contains(implementedInterface));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 20672, 20721);

                HashSet<DiagnosticInfo>
                unuseddiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 20737, 20776);

                NamedTypeSymbol
                directInterface = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 20790, 21315);
                    foreach (var iface in f_10217_20812_20849_I(f_10217_20812_20849(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 20790, 21315);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 20883, 21300) || true) && (f_10217_20887_20970(iface, implementedInterface, TypeCompareKind.ConsiderEverything2))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 20883, 21300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 21012, 21036);

                            directInterface = iface;
                            DynAbs.Tracing.TraceSender.TraceBreak(10217, 21058, 21064);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 20883, 21300);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 20883, 21300);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 21106, 21300) || true) && ((object)directInterface == null && (DynAbs.Tracing.TraceSender.Expression_True(10217, 21110, 21215) && f_10217_21145_21215(iface, implementedInterface, ref unuseddiagnostics)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 21106, 21300);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 21257, 21281);

                                directInterface = iface;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 21106, 21300);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 20883, 21300);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 20790, 21315);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10217, 1, 526);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10217, 1, 526);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 21331, 21377);

                f_10217_21331_21376((object)directInterface != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 21391, 21448);

                return f_10217_21398_21447(this, directInterface);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10217, 20133, 21459);

                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10217_20546_20603(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.InterfacesAndTheirBaseInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 20546, 20603);
                    return return_v;
                }


                int
                f_10217_20533_20657(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 20533, 20657);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10217_20812_20849(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.InterfacesNoUseSiteDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 20812, 20849);
                    return return_v;
                }


                bool
                f_10217_20887_20970(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 20887, 20970);
                    return return_v;
                }


                bool
                f_10217_21145_21215(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                subType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                superInterface, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = subType.ImplementsInterface((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)superInterface, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 21145, 21215);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10217_20812_20849_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 20812, 20849);
                    return return_v;
                }


                int
                f_10217_21331_21376(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 21331, 21376);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10217_21398_21447(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                @base)
                {
                    var return_v = this_param.GetCorrespondingBaseListLocation(@base);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 21398, 21447);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 20133, 21459);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 20133, 21459);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ReportAccessorOfInterfacePropertyOrEvent(Symbol interfacePropertyOrEvent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10217, 21952, 23962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 22063, 22118);

                f_10217_22063_22117((object)interfacePropertyOrEvent != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 22206, 22315) || true) && (f_10217_22210_22254(interfacePropertyOrEvent))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 22206, 22315);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 22288, 22300);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 22206, 22315);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 22331, 22366);

                Symbol
                implementingPropertyOrEvent
                = default(Symbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 22382, 23174) || true) && (f_10217_22386_22402(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 22382, 23174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 22436, 22567);

                    MultiDictionary<Symbol, Symbol>.ValueSet
                    explicitImpl = f_10217_22492_22566(this, interfacePropertyOrEvent)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 22587, 22981);

                    switch (explicitImpl.Count)
                    {

                        case 0:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 22587, 22981);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 22688, 22700);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 22587, 22981);

                        case 1:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 22587, 22981);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 22755, 22807);

                            implementingPropertyOrEvent = explicitImpl.Single();
                            DynAbs.Tracing.TraceSender.TraceBreak(10217, 22833, 22839);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 22587, 22981);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 22587, 22981);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 22895, 22930);

                            implementingPropertyOrEvent = null;
                            DynAbs.Tracing.TraceSender.TraceBreak(10217, 22956, 22962);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 22587, 22981);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 22382, 23174);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 22382, 23174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 23047, 23159);

                    implementingPropertyOrEvent = f_10217_23077_23158(this, interfacePropertyOrEvent);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 22382, 23174);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 23302, 23411) || true) && ((object)implementingPropertyOrEvent == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 23302, 23411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 23383, 23396);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 23302, 23411);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 23602, 23923) || true) && (f_10217_23606_23635(interfacePropertyOrEvent) == SymbolKind.Event && (DynAbs.Tracing.TraceSender.Expression_True(10217, 23606, 23711) && f_10217_23659_23691(implementingPropertyOrEvent) == SymbolKind.Event) && (DynAbs.Tracing.TraceSender.Expression_True(10217, 23606, 23861) && f_10217_23732_23793(((EventSymbol)interfacePropertyOrEvent)) != f_10217_23797_23861(((EventSymbol)implementingPropertyOrEvent))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 23602, 23923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 23895, 23908);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 23602, 23923);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 23939, 23951);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10217, 21952, 23962);

                int
                f_10217_22063_22117(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 22063, 22117);
                    return 0;
                }


                bool
                f_10217_22210_22254(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsIndexedProperty();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 22210, 22254);
                    return return_v;
                }


                bool
                f_10217_22386_22402(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 22386, 22402);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                f_10217_22492_22566(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember)
                {
                    var return_v = this_param.GetExplicitImplementationForInterfaceMember(interfaceMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 22492, 22566);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10217_23077_23158(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember)
                {
                    var return_v = this_param.FindImplementationForInterfaceMemberInNonInterface(interfaceMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 23077, 23158);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10217_23606_23635(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 23606, 23635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10217_23659_23691(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 23659, 23691);
                    return return_v;
                }


                bool
                f_10217_23732_23793(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.IsWindowsRuntimeEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 23732, 23793);
                    return return_v;
                }


                bool
                f_10217_23797_23861(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.IsWindowsRuntimeEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 23797, 23861);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 21952, 23962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 21952, 23962);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private enum HasBaseTypeDeclaringInterfaceResult
        {
            NoMatch,
            IgnoringNullableMatch,
            ExactMatch,
        }

        private HasBaseTypeDeclaringInterfaceResult HasBaseClassDeclaringInterface(NamedTypeSymbol @interface)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10217, 24139, 24728);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 24266, 24355);

                HasBaseTypeDeclaringInterfaceResult
                result = HasBaseTypeDeclaringInterfaceResult.NoMatch
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 24392, 24436);

                    for (NamedTypeSymbol
        currType = f_10217_24403_24436(this)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 24371, 24687) || true) && ((object)currType != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 24464, 24512)
        , currType = f_10217_24475_24512(currType), DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 24371, 24687))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 24371, 24687);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 24546, 24672) || true) && (f_10217_24550_24605(currType, @interface, ref result))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 24546, 24672);
                            DynAbs.Tracing.TraceSender.TraceBreak(10217, 24647, 24653);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 24546, 24672);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10217, 1, 317);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10217, 1, 317);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 24703, 24717);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10217, 24139, 24728);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10217_24403_24436(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 24403, 24436);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10217_24475_24512(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 24475, 24512);
                    return return_v;
                }


                bool
                f_10217_24550_24605(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                currType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                @interface, ref Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol.HasBaseTypeDeclaringInterfaceResult
                result)
                {
                    var return_v = DeclaresBaseInterface(currType, @interface, ref result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 24550, 24605);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 24139, 24728);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 24139, 24728);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool DeclaresBaseInterface(NamedTypeSymbol currType, NamedTypeSymbol @interface, ref HasBaseTypeDeclaringInterfaceResult result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10217, 24740, 25634);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 24908, 25047);

                MultiDictionary<NamedTypeSymbol, NamedTypeSymbol>.ValueSet
                set = f_10217_24973_25046(f_10217_24973_25034(currType), @interface)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 25063, 25594) || true) && (set.Count != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 25063, 25594);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 25115, 25579) || true) && (set.Contains(@interface))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 25115, 25579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 25185, 25241);

                        result = HasBaseTypeDeclaringInterfaceResult.ExactMatch;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 25263, 25275);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 25115, 25579);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 25115, 25579);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 25317, 25579) || true) && (result == HasBaseTypeDeclaringInterfaceResult.NoMatch && (DynAbs.Tracing.TraceSender.Expression_True(10217, 25321, 25451) && set.Contains(@interface, Symbols.SymbolEqualityComparer.IgnoringNullable)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 25317, 25579);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 25493, 25560);

                            result = HasBaseTypeDeclaringInterfaceResult.IgnoringNullableMatch;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 25317, 25579);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 25115, 25579);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 25063, 25594);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 25610, 25623);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10217, 24740, 25634);

                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10217_24973_25034(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.InterfacesAndTheirBaseInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 24973, 25034);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>.ValueSet
                f_10217_24973_25046(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 24973, 25046);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 24740, 25634);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 24740, 25634);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void HasBaseInterfaceDeclaringInterface(NamedTypeSymbol baseInterface, NamedTypeSymbol @interface, ref HasBaseTypeDeclaringInterfaceResult matchResult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10217, 25646, 26527);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 25885, 26010) || true) && (f_10217_25889_25954(baseInterface, @interface, ref matchResult))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 25885, 26010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 25988, 25995);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 25885, 26010);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 26026, 26516);
                    foreach (var interfaceType in f_10217_26056_26094_I(f_10217_26056_26094(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 26026, 26516);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 26128, 26240) || true) && ((object)interfaceType == baseInterface)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 26128, 26240);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 26212, 26221);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 26128, 26240);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 26260, 26501) || true) && (f_10217_26264_26343(interfaceType, baseInterface, TypeCompareKind.CLRSignatureCompareOptions) && (DynAbs.Tracing.TraceSender.Expression_True(10217, 26264, 26433) && f_10217_26368_26433(interfaceType, @interface, ref matchResult)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 26260, 26501);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 26475, 26482);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 26260, 26501);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 26026, 26516);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10217, 1, 491);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10217, 1, 491);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10217, 25646, 26527);

                bool
                f_10217_25889_25954(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                currType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                @interface, ref Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol.HasBaseTypeDeclaringInterfaceResult
                result)
                {
                    var return_v = DeclaresBaseInterface(currType, @interface, ref result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 25889, 25954);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10217_26056_26094(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.AllInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 26056, 26094);
                    return return_v;
                }


                bool
                f_10217_26264_26343(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 26264, 26343);
                    return return_v;
                }


                bool
                f_10217_26368_26433(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                currType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                @interface, ref Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol.HasBaseTypeDeclaringInterfaceResult
                result)
                {
                    var return_v = DeclaresBaseInterface(currType, @interface, ref result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 26368, 26433);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10217_26056_26094_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 26056, 26094);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 25646, 26527);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 25646, 26527);
            }
        }

        private void CheckMembersAgainstBaseType(
                    DiagnosticBag diagnostics,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10217, 26539, 35656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 26695, 27275);

                switch (f_10217_26703_26716(this))
                {

                    case TypeKind.Enum:
                    case TypeKind.Delegate:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 26695, 27275);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 26907, 26914);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 26695, 27275);

                    case TypeKind.Class:
                    case TypeKind.Struct:
                    case TypeKind.Interface:
                    case TypeKind.Submission: // we have to check that "override" is not used
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 26695, 27275);
                        DynAbs.Tracing.TraceSender.TraceBreak(10217, 27148, 27154);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 26695, 27275);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 26695, 27275);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 27204, 27260);

                        throw f_10217_27210_27259(f_10217_27245_27258(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 26695, 27275);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 27291, 35645);
                    foreach (var member in f_10217_27314_27340_I(f_10217_27314_27340(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 27291, 35645);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 27374, 27423);

                        cancellationToken.ThrowIfCancellationRequested();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 27443, 27466);

                        bool
                        suppressAccessors
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 27484, 35630);

                        switch (f_10217_27492_27503(member))
                        {

                            case SymbolKind.Method:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 27484, 35630);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 27594, 27628);

                                var
                                method = (MethodSymbol)member
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 27654, 29857) || true) && (f_10217_27658_27707(f_10217_27689_27706(method)) && (DynAbs.Tracing.TraceSender.Expression_True(10217, 27658, 27731) && !f_10217_27712_27731(method)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 27654, 29857);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 27789, 28572) || true) && (f_10217_27793_27810(member))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 27789, 28572);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 27876, 27974);

                                        f_10217_27876_27973(this, method, f_10217_27904_27936(method), diagnostics, out suppressAccessors);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 27789, 28572);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 27789, 28572);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 28104, 28158);

                                        var
                                        sourceMethod = method as SourceMemberMethodSymbol
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 28192, 28541) || true) && ((object)sourceMethod != null)
                                        ) // skip submission initializer

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 28192, 28541);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 28329, 28360);

                                            var
                                            isNew = f_10217_28341_28359(sourceMethod)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 28398, 28506);

                                            f_10217_28398_28505(method, isNew, f_10217_28436_28468(method), diagnostics, out suppressAccessors);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 28192, 28541);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 27789, 28572);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 27654, 29857);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 27654, 29857);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 28630, 29857) || true) && (f_10217_28634_28651(method) == MethodKind.Destructor)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 28630, 29857);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 28968, 29055);

                                        MethodSymbol
                                        overridden = f_10217_28994_29054(method, out _)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 29582, 29830) || true) && ((object)overridden != null && (DynAbs.Tracing.TraceSender.Expression_True(10217, 29586, 29642) && f_10217_29616_29642(overridden)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 29582, 29830);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 29708, 29799);

                                            f_10217_29708_29798(diagnostics, ErrorCode.ERR_CantOverrideSealed, f_10217_29758_29774(method)[0], method, overridden);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 29582, 29830);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 28630, 29857);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 27654, 29857);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10217, 29883, 29889);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 27484, 35630);

                            case SymbolKind.Property:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 27484, 35630);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 29962, 30000);

                                var
                                property = (PropertySymbol)member
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 30026, 30061);

                                var
                                getMethod = f_10217_30042_30060(property)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 30087, 30122);

                                var
                                setMethod = f_10217_30103_30121(property)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 30336, 32280) || true) && (f_10217_30340_30357(member))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 30336, 32280);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 30415, 30517);

                                    f_10217_30415_30516(this, property, f_10217_30445_30479(property), diagnostics, out suppressAccessors);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 30549, 31186) || true) && (!suppressAccessors)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 30549, 31186);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 30637, 30879) || true) && ((object)getMethod != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 30637, 30879);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 30740, 30844);

                                            f_10217_30740_30843(this, getMethod, f_10217_30771_30806(getMethod), diagnostics, out suppressAccessors);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 30637, 30879);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 30913, 31155) || true) && ((object)setMethod != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 30913, 31155);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 31016, 31120);

                                            f_10217_31016_31119(this, setMethod, f_10217_31047_31082(setMethod), diagnostics, out suppressAccessors);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 30913, 31155);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 30549, 31186);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 30336, 32280);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 30336, 32280);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 31244, 32280) || true) && (property is SourcePropertySymbolBase sourceProperty)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 31244, 32280);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 31357, 31398);

                                        var
                                        isNewProperty = f_10217_31377_31397(sourceProperty)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 31428, 31548);

                                        f_10217_31428_31547(property, isNewProperty, f_10217_31476_31510(property), diagnostics, out suppressAccessors);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 31580, 32253) || true) && (!suppressAccessors)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 31580, 32253);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 31668, 31928) || true) && ((object)getMethod != null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 31668, 31928);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 31771, 31893);

                                                f_10217_31771_31892(getMethod, isNewProperty, f_10217_31820_31855(getMethod), diagnostics, out suppressAccessors);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 31668, 31928);
                                            }

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 31962, 32222) || true) && ((object)setMethod != null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 31962, 32222);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 32065, 32187);

                                                f_10217_32065_32186(setMethod, isNewProperty, f_10217_32114_32149(setMethod), diagnostics, out suppressAccessors);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 31962, 32222);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 31580, 32253);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 31244, 32280);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 30336, 32280);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10217, 32306, 32312);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 27484, 35630);

                            case SymbolKind.Event:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 27484, 35630);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 32382, 32415);

                                var
                                @event = (EventSymbol)member
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 32441, 32474);

                                var
                                addMethod = f_10217_32457_32473(@event)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 32500, 32539);

                                var
                                removeMethod = f_10217_32519_32538(@event)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 32750, 34648) || true) && (f_10217_32754_32771(member))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 32750, 34648);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 32829, 32927);

                                    f_10217_32829_32926(this, @event, f_10217_32857_32889(@event), diagnostics, out suppressAccessors);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 32959, 33605) || true) && (!suppressAccessors)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 32959, 33605);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 33047, 33289) || true) && ((object)addMethod != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 33047, 33289);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 33150, 33254);

                                            f_10217_33150_33253(this, addMethod, f_10217_33181_33216(addMethod), diagnostics, out suppressAccessors);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 33047, 33289);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 33323, 33574) || true) && ((object)removeMethod != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 33323, 33574);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 33429, 33539);

                                            f_10217_33429_33538(this, removeMethod, f_10217_33463_33501(removeMethod), diagnostics, out suppressAccessors);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 33323, 33574);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 32959, 33605);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 32750, 34648);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 32750, 34648);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 33719, 33770);

                                    var
                                    isNewEvent = f_10217_33736_33769(((SourceEventSymbol)@event))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 33800, 33913);

                                    f_10217_33800_33912(@event, isNewEvent, f_10217_33843_33875(@event), diagnostics, out suppressAccessors);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 33945, 34621) || true) && (!suppressAccessors)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 33945, 34621);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 34033, 34290) || true) && ((object)addMethod != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 34033, 34290);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 34136, 34255);

                                            f_10217_34136_34254(addMethod, isNewEvent, f_10217_34182_34217(addMethod), diagnostics, out suppressAccessors);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 34033, 34290);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 34324, 34590) || true) && ((object)removeMethod != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 34324, 34590);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 34430, 34555);

                                            f_10217_34430_34554(removeMethod, isNewEvent, f_10217_34479_34517(removeMethod), diagnostics, out suppressAccessors);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 34324, 34590);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 33945, 34621);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 32750, 34648);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10217, 34674, 34680);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 27484, 35630);

                            case SymbolKind.Field:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 27484, 35630);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 34750, 34796);

                                var
                                sourceField = member as SourceFieldSymbol
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 34822, 34888);

                                var
                                isNewField = (object)sourceField != null && (DynAbs.Tracing.TraceSender.Expression_True(10217, 34839, 34887) && f_10217_34870_34887(sourceField))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 35132, 35308);

                                f_10217_35132_35307((object)sourceField == null || (DynAbs.Tracing.TraceSender.Expression_False(10217, 35145, 35220) || (object)f_10217_35184_35212(sourceField) == null) || (DynAbs.Tracing.TraceSender.Expression_False(10217, 35145, 35306) || f_10217_35253_35286(f_10217_35253_35281(sourceField)) != SymbolKind.Event));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 35336, 35386);

                                f_10217_35336_35385(this, member, isNewField, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceBreak(10217, 35412, 35418);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 27484, 35630);

                            case SymbolKind.NamedType:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 27484, 35630);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 35492, 35579);

                                f_10217_35492_35578(this, member, f_10217_35517_35564(((SourceMemberContainerTypeSymbol)member)), diagnostics);
                                DynAbs.Tracing.TraceSender.TraceBreak(10217, 35605, 35611);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 27484, 35630);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 27291, 35645);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10217, 1, 8355);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10217, 1, 8355);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10217, 26539, 35656);

                Microsoft.CodeAnalysis.TypeKind
                f_10217_26703_26716(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 26703, 26716);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10217_27245_27258(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 27245, 27258);
                    return return_v;
                }


                System.Exception
                f_10217_27210_27259(Microsoft.CodeAnalysis.TypeKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 27210, 27259);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10217_27314_27340(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 27314, 27340);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10217_27492_27503(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 27492, 27503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10217_27689_27706(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 27689, 27706);
                    return return_v;
                }


                bool
                f_10217_27658_27707(Microsoft.CodeAnalysis.MethodKind
                kind)
                {
                    var return_v = MethodSymbol.CanOverrideOrHide(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 27658, 27707);
                    return return_v;
                }


                bool
                f_10217_27712_27731(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol)
                {
                    var return_v = methodSymbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 27712, 27731);
                    return return_v;
                }


                bool
                f_10217_27793_27810(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 27793, 27810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10217_27904_27936(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenOrHiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 27904, 27936);
                    return return_v;
                }


                int
                f_10217_27876_27973(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                overridingMember, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                overriddenOrHiddenMembers, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                suppressAccessors)
                {
                    this_param.CheckOverrideMember((Microsoft.CodeAnalysis.CSharp.Symbol)overridingMember, overriddenOrHiddenMembers, diagnostics, out suppressAccessors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 27876, 27973);
                    return 0;
                }


                bool
                f_10217_28341_28359(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsNew;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 28341, 28359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10217_28436_28468(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenOrHiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 28436, 28468);
                    return return_v;
                }


                int
                f_10217_28398_28505(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                hidingMember, bool
                hidingMemberIsNew, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                overriddenOrHiddenMembers, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                suppressAccessors)
                {
                    CheckNonOverrideMember((Microsoft.CodeAnalysis.CSharp.Symbol)hidingMember, hidingMemberIsNew, overriddenOrHiddenMembers, diagnostics, out suppressAccessors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 28398, 28505);
                    return 0;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10217_28634_28651(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 28634, 28651);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10217_28994_29054(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, out bool
                wasAmbiguous)
                {
                    var return_v = method.GetFirstRuntimeOverriddenMethodIgnoringNewSlot(out wasAmbiguous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 28994, 29054);
                    return return_v;
                }


                bool
                f_10217_29616_29642(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsMetadataFinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 29616, 29642);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10217_29758_29774(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 29758, 29774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10217_29708_29798(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 29708, 29798);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10217_30042_30060(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 30042, 30060);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10217_30103_30121(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 30103, 30121);
                    return return_v;
                }


                bool
                f_10217_30340_30357(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 30340, 30357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10217_30445_30479(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.OverriddenOrHiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 30445, 30479);
                    return return_v;
                }


                int
                f_10217_30415_30516(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                overridingMember, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                overriddenOrHiddenMembers, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                suppressAccessors)
                {
                    this_param.CheckOverrideMember((Microsoft.CodeAnalysis.CSharp.Symbol)overridingMember, overriddenOrHiddenMembers, diagnostics, out suppressAccessors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 30415, 30516);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10217_30771_30806(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenOrHiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 30771, 30806);
                    return return_v;
                }


                int
                f_10217_30740_30843(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                overridingMember, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                overriddenOrHiddenMembers, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                suppressAccessors)
                {
                    this_param.CheckOverrideMember((Microsoft.CodeAnalysis.CSharp.Symbol)overridingMember, overriddenOrHiddenMembers, diagnostics, out suppressAccessors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 30740, 30843);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10217_31047_31082(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenOrHiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 31047, 31082);
                    return return_v;
                }


                int
                f_10217_31016_31119(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                overridingMember, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                overriddenOrHiddenMembers, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                suppressAccessors)
                {
                    this_param.CheckOverrideMember((Microsoft.CodeAnalysis.CSharp.Symbol)overridingMember, overriddenOrHiddenMembers, diagnostics, out suppressAccessors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 31016, 31119);
                    return 0;
                }


                bool
                f_10217_31377_31397(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.IsNew;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 31377, 31397);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10217_31476_31510(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.OverriddenOrHiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 31476, 31510);
                    return return_v;
                }


                int
                f_10217_31428_31547(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                hidingMember, bool
                hidingMemberIsNew, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                overriddenOrHiddenMembers, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                suppressAccessors)
                {
                    CheckNonOverrideMember((Microsoft.CodeAnalysis.CSharp.Symbol)hidingMember, hidingMemberIsNew, overriddenOrHiddenMembers, diagnostics, out suppressAccessors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 31428, 31547);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10217_31820_31855(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenOrHiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 31820, 31855);
                    return return_v;
                }


                int
                f_10217_31771_31892(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                hidingMember, bool
                hidingMemberIsNew, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                overriddenOrHiddenMembers, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                suppressAccessors)
                {
                    CheckNonOverrideMember((Microsoft.CodeAnalysis.CSharp.Symbol)hidingMember, hidingMemberIsNew, overriddenOrHiddenMembers, diagnostics, out suppressAccessors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 31771, 31892);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10217_32114_32149(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenOrHiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 32114, 32149);
                    return return_v;
                }


                int
                f_10217_32065_32186(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                hidingMember, bool
                hidingMemberIsNew, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                overriddenOrHiddenMembers, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                suppressAccessors)
                {
                    CheckNonOverrideMember((Microsoft.CodeAnalysis.CSharp.Symbol)hidingMember, hidingMemberIsNew, overriddenOrHiddenMembers, diagnostics, out suppressAccessors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 32065, 32186);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10217_32457_32473(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AddMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 32457, 32473);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10217_32519_32538(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.RemoveMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 32519, 32538);
                    return return_v;
                }


                bool
                f_10217_32754_32771(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 32754, 32771);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10217_32857_32889(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenOrHiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 32857, 32889);
                    return return_v;
                }


                int
                f_10217_32829_32926(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                overridingMember, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                overriddenOrHiddenMembers, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                suppressAccessors)
                {
                    this_param.CheckOverrideMember((Microsoft.CodeAnalysis.CSharp.Symbol)overridingMember, overriddenOrHiddenMembers, diagnostics, out suppressAccessors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 32829, 32926);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10217_33181_33216(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenOrHiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 33181, 33216);
                    return return_v;
                }


                int
                f_10217_33150_33253(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                overridingMember, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                overriddenOrHiddenMembers, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                suppressAccessors)
                {
                    this_param.CheckOverrideMember((Microsoft.CodeAnalysis.CSharp.Symbol)overridingMember, overriddenOrHiddenMembers, diagnostics, out suppressAccessors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 33150, 33253);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10217_33463_33501(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenOrHiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 33463, 33501);
                    return return_v;
                }


                int
                f_10217_33429_33538(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                overridingMember, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                overriddenOrHiddenMembers, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                suppressAccessors)
                {
                    this_param.CheckOverrideMember((Microsoft.CodeAnalysis.CSharp.Symbol)overridingMember, overriddenOrHiddenMembers, diagnostics, out suppressAccessors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 33429, 33538);
                    return 0;
                }


                bool
                f_10217_33736_33769(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.IsNew;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 33736, 33769);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10217_33843_33875(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenOrHiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 33843, 33875);
                    return return_v;
                }


                int
                f_10217_33800_33912(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                hidingMember, bool
                hidingMemberIsNew, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                overriddenOrHiddenMembers, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                suppressAccessors)
                {
                    CheckNonOverrideMember((Microsoft.CodeAnalysis.CSharp.Symbol)hidingMember, hidingMemberIsNew, overriddenOrHiddenMembers, diagnostics, out suppressAccessors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 33800, 33912);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10217_34182_34217(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenOrHiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 34182, 34217);
                    return return_v;
                }


                int
                f_10217_34136_34254(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                hidingMember, bool
                hidingMemberIsNew, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                overriddenOrHiddenMembers, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                suppressAccessors)
                {
                    CheckNonOverrideMember((Microsoft.CodeAnalysis.CSharp.Symbol)hidingMember, hidingMemberIsNew, overriddenOrHiddenMembers, diagnostics, out suppressAccessors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 34136, 34254);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10217_34479_34517(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenOrHiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 34479, 34517);
                    return return_v;
                }


                int
                f_10217_34430_34554(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                hidingMember, bool
                hidingMemberIsNew, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                overriddenOrHiddenMembers, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                suppressAccessors)
                {
                    CheckNonOverrideMember((Microsoft.CodeAnalysis.CSharp.Symbol)hidingMember, hidingMemberIsNew, overriddenOrHiddenMembers, diagnostics, out suppressAccessors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 34430, 34554);
                    return 0;
                }


                bool
                f_10217_34870_34887(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbol
                this_param)
                {
                    var return_v = this_param.IsNew;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 34870, 34887);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10217_35184_35212(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 35184, 35212);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10217_35253_35281(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 35253, 35281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10217_35253_35286(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 35253, 35286);
                    return return_v;
                }


                int
                f_10217_35132_35307(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 35132, 35307);
                    return 0;
                }


                int
                f_10217_35336_35385(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, bool
                isNew, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckNewModifier(symbol, isNew, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 35336, 35385);
                    return 0;
                }


                bool
                f_10217_35517_35564(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNew;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 35517, 35564);
                    return return_v;
                }


                int
                f_10217_35492_35578(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, bool
                isNew, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckNewModifier(symbol, isNew, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 35492, 35578);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10217_27314_27340_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 27314, 27340);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 26539, 35656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 26539, 35656);
            }
        }

        private void CheckNewModifier(Symbol symbol, bool isNew, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10217, 35668, 38290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 35776, 35861);

                f_10217_35776_35860(f_10217_35789_35800(symbol) == SymbolKind.Field || (DynAbs.Tracing.TraceSender.Expression_False(10217, 35789, 35859) || f_10217_35824_35835(symbol) == SymbolKind.NamedType));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 36032, 36119) || true) && (f_10217_36036_36063(symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 36032, 36119);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 36097, 36104);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 36032, 36119);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 36135, 36500) || true) && (f_10217_36139_36172(f_10217_36139_36160(symbol)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 36135, 36500);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 36206, 36460);

                    f_10217_36206_36459(symbol, isNew, f_10217_36284_36398(symbol, memberIsFromSomeCompilation: true), diagnostics, out _);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 36478, 36485);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 36135, 36500);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 36548, 36657) || true) && ((object)f_10217_36560_36593(this) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 36548, 36657);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 36635, 36642);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 36548, 36657);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 36673, 36715);

                int
                symbolArity = f_10217_36691_36714(symbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 36729, 36789);

                Location
                symbolLocation = symbol.Locations.FirstOrDefault()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 36803, 36823);

                bool
                unused = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 36839, 36900);

                NamedTypeSymbol
                currType = f_10217_36866_36899(this)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 36914, 38135) || true) && ((object)currType != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 36914, 38135);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 36979, 38051);
                            foreach (var hiddenMember in f_10217_37008_37040_I(f_10217_37008_37040(currType, f_10217_37028_37039(symbol))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 36979, 38051);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 37082, 37276) || true) && (f_10217_37086_37103(hiddenMember) == SymbolKind.Method && (DynAbs.Tracing.TraceSender.Expression_True(10217, 37086, 37194) && !f_10217_37129_37194(((MethodSymbol)hiddenMember), f_10217_37182_37193(symbol))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 37082, 37276);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 37244, 37253);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 37082, 37276);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 37300, 37350);

                                HashSet<DiagnosticInfo>
                                useSiteDiagnostics = null
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 37372, 37467);

                                bool
                                isAccessible = f_10217_37392_37466(hiddenMember, this, ref useSiteDiagnostics)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 37489, 37541);

                                f_10217_37489_37540(diagnostics, symbolLocation, useSiteDiagnostics);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 37565, 38032) || true) && (isAccessible && (DynAbs.Tracing.TraceSender.Expression_True(10217, 37569, 37629) && f_10217_37585_37614(hiddenMember) == symbolArity))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 37565, 38032);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 37679, 37855) || true) && (!isNew)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 37679, 37855);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 37747, 37828);

                                        f_10217_37747_37827(diagnostics, ErrorCode.WRN_NewRequired, symbolLocation, symbol, hiddenMember);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 37679, 37855);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 37883, 37974);

                                    f_10217_37883_37973(symbol, symbolLocation, hiddenMember, diagnostics, ref unused);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 38002, 38009);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 37565, 38032);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 36979, 38051);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10217, 1, 1073);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10217, 1, 1073);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 38071, 38120);

                        currType = f_10217_38082_38119(currType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 36914, 38135);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10217, 36914, 38135);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10217, 36914, 38135);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 38151, 38279) || true) && (isNew)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 38151, 38279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 38194, 38264);

                    f_10217_38194_38263(diagnostics, ErrorCode.WRN_NewNotRequired, symbolLocation, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 38151, 38279);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10217, 35668, 38290);

                Microsoft.CodeAnalysis.SymbolKind
                f_10217_35789_35800(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 35789, 35800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10217_35824_35835(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 35824, 35835);
                    return return_v;
                }


                int
                f_10217_35776_35860(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 35776, 35860);
                    return 0;
                }


                bool
                f_10217_36036_36063(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 36036, 36063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10217_36139_36160(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 36139, 36160);
                    return return_v;
                }


                bool
                f_10217_36139_36172(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 36139, 36172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10217_36284_36398(Microsoft.CodeAnalysis.CSharp.Symbol
                member, bool
                memberIsFromSomeCompilation)
                {
                    var return_v = OverriddenOrHiddenMembersHelpers.MakeInterfaceOverriddenOrHiddenMembers(member, memberIsFromSomeCompilation: memberIsFromSomeCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 36284, 36398);
                    return return_v;
                }


                int
                f_10217_36206_36459(Microsoft.CodeAnalysis.CSharp.Symbol
                hidingMember, bool
                hidingMemberIsNew, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                overriddenOrHiddenMembers, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                suppressAccessors)
                {
                    CheckNonOverrideMember(hidingMember, hidingMemberIsNew, overriddenOrHiddenMembers, diagnostics, out suppressAccessors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 36206, 36459);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10217_36560_36593(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 36560, 36593);
                    return return_v;
                }


                int
                f_10217_36691_36714(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetMemberArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 36691, 36714);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10217_36866_36899(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 36866, 36899);
                    return return_v;
                }


                string
                f_10217_37028_37039(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 37028, 37039);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10217_37008_37040(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 37008, 37040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10217_37086_37103(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 37086, 37103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10217_37182_37193(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 37182, 37193);
                    return return_v;
                }


                bool
                f_10217_37129_37194(Microsoft.CodeAnalysis.CSharp.Symbol
                hiddenMethod, Microsoft.CodeAnalysis.SymbolKind
                hidingMemberKind)
                {
                    var return_v = ((MethodSymbol)hiddenMethod).CanBeHiddenByMemberKind(hidingMemberKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 37129, 37194);
                    return return_v;
                }


                bool
                f_10217_37392_37466(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                within, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = AccessCheck.IsSymbolAccessible(symbol, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)within, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 37392, 37466);
                    return return_v;
                }


                bool
                f_10217_37489_37540(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location?
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 37489, 37540);
                    return return_v;
                }


                int
                f_10217_37585_37614(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetMemberArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 37585, 37614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10217_37747_37827(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location?
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 37747, 37827);
                    return return_v;
                }


                bool
                f_10217_37883_37973(Microsoft.CodeAnalysis.CSharp.Symbol
                hidingMember, Microsoft.CodeAnalysis.Location?
                hidingMemberLocation, Microsoft.CodeAnalysis.CSharp.Symbol
                hiddenMember, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                suppressAccessors)
                {
                    var return_v = AddHidingAbstractDiagnostic(hidingMember, hidingMemberLocation, hiddenMember, diagnostics, ref suppressAccessors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 37883, 37973);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10217_37008_37040_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 37008, 37040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10217_38082_38119(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 38082, 38119);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10217_38194_38263(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location?
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 38194, 38263);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 35668, 38290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 35668, 38290);
            }
        }

        private void CheckOverrideMember(
                    Symbol overridingMember,
                    OverriddenOrHiddenMembersResult overriddenOrHiddenMembers,
                    DiagnosticBag diagnostics,
                    out bool suppressAccessors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10217, 38302, 65684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 38551, 38598);

                f_10217_38551_38597((object)overridingMember != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 38612, 38660);

                f_10217_38612_38659(overriddenOrHiddenMembers != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 38676, 38702);

                suppressAccessors = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 38718, 38792);

                var
                overridingMemberIsMethod = f_10217_38749_38770(overridingMember) == SymbolKind.Method
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 38806, 38884);

                var
                overridingMemberIsProperty = f_10217_38839_38860(overridingMember) == SymbolKind.Property
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 38898, 38970);

                var
                overridingMemberIsEvent = f_10217_38928_38949(overridingMember) == SymbolKind.Event
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 38986, 39080);

                f_10217_38986_39079(overridingMemberIsMethod ^ overridingMemberIsProperty ^ overridingMemberIsEvent);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 39096, 39157);

                var
                overridingMemberLocation = f_10217_39127_39153(overridingMember)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 39173, 39241);

                var
                overriddenMembers = f_10217_39197_39240(overriddenOrHiddenMembers)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 39255, 39298);

                f_10217_39255_39297(f_10217_39268_39296_M(!overriddenMembers.IsDefault));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 39314, 43693) || true) && (overriddenMembers.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 39314, 43693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 39381, 39441);

                    var
                    hiddenMembers = f_10217_39401_39440(overriddenOrHiddenMembers)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 39459, 39498);

                    f_10217_39459_39497(f_10217_39472_39496_M(!hiddenMembers.IsDefault));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 39518, 43009) || true) && (hiddenMembers.Any())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 39518, 43009);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 39583, 39851);

                        ErrorCode
                        errorCode =
                        (DynAbs.Tracing.TraceSender.Conditional_F1(10217, 39630, 39654) || ((overridingMemberIsMethod && DynAbs.Tracing.TraceSender.Conditional_F2(10217, 39657, 39694)) || DynAbs.Tracing.TraceSender.Conditional_F3(10217, 39722, 39850))) ? ErrorCode.ERR_CantOverrideNonFunction : (DynAbs.Tracing.TraceSender.Conditional_F1(10217, 39722, 39748) || ((overridingMemberIsProperty && DynAbs.Tracing.TraceSender.Conditional_F2(10217, 39751, 39788)) || DynAbs.Tracing.TraceSender.Conditional_F3(10217, 39816, 39850))) ? ErrorCode.ERR_CantOverrideNonProperty : ErrorCode.ERR_CantOverrideNonEvent
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 39875, 39964);

                        f_10217_39875_39963(
                                            diagnostics, errorCode, overridingMemberLocation, overridingMember, hiddenMembers[0]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 39518, 43009);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 39518, 43009);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 40046, 40086);

                        Symbol
                        associatedPropertyOrEvent = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 40108, 40287) || true) && (overridingMemberIsMethod)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 40108, 40287);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 40186, 40264);

                            associatedPropertyOrEvent = f_10217_40214_40263(((MethodSymbol)overridingMember));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 40108, 40287);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 40311, 42990) || true) && ((object)associatedPropertyOrEvent == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 40311, 42990);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 40406, 40433);

                            bool
                            suppressError = false
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 40459, 41328) || true) && (overridingMemberIsMethod || (DynAbs.Tracing.TraceSender.Expression_False(10217, 40463, 40519) || f_10217_40491_40519(overridingMember)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 40459, 41328);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 40577, 40821);

                                var
                                parameterTypes = (DynAbs.Tracing.TraceSender.Conditional_F1(10217, 40598, 40622) || ((overridingMemberIsMethod
                                && DynAbs.Tracing.TraceSender.Conditional_F2(10217, 40658, 40720)) || DynAbs.Tracing.TraceSender.Conditional_F3(10217, 40756, 40820))) ? f_10217_40658_40720(((MethodSymbol)overridingMember)) : f_10217_40756_40820(((PropertySymbol)overridingMember))
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 40853, 41301);
                                    foreach (var parameterType in f_10217_40883_40897_I(parameterTypes))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 40853, 41301);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 40963, 41270) || true) && (f_10217_40967_41008(parameterType.Type))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 40963, 41270);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 41082, 41103);

                                            suppressError = true;
                                            DynAbs.Tracing.TraceSender.TraceBreak(10217, 41229, 41235);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 40963, 41270);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 40853, 41301);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10217, 1, 449);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10217, 1, 449);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 40459, 41328);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 41356, 41554) || true) && (!suppressError)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 41356, 41554);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 41432, 41527);

                                f_10217_41432_41526(diagnostics, ErrorCode.ERR_OverrideNotExpected, overridingMemberLocation, overridingMember);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 41356, 41554);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 40311, 42990);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 40311, 42990);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 41604, 42990) || true) && (f_10217_41608_41638(associatedPropertyOrEvent) == SymbolKind.Property)
                            ) //no specific errors for event accessors

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 41604, 42990);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 41752, 41830);

                                PropertySymbol
                                associatedProperty = (PropertySymbol)associatedPropertyOrEvent
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 41856, 41930);

                                PropertySymbol
                                overriddenProperty = f_10217_41892_41929(associatedProperty)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 41958, 42967) || true) && ((object)overriddenProperty == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 41958, 42967);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 41958, 42967);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 41958, 42967);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 42135, 42967) || true) && (f_10217_42139_42167(associatedProperty) == overridingMember && (DynAbs.Tracing.TraceSender.Expression_True(10217, 42139, 42235) && (object)f_10217_42199_42227(overriddenProperty) == null))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 42135, 42967);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 42293, 42404);

                                        f_10217_42293_42403(diagnostics, ErrorCode.ERR_NoGetToOverride, overridingMemberLocation, overridingMember, overriddenProperty);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 42135, 42967);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 42135, 42967);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 42462, 42967) || true) && (f_10217_42466_42494(associatedProperty) == overridingMember && (DynAbs.Tracing.TraceSender.Expression_True(10217, 42466, 42562) && (object)f_10217_42526_42554(overriddenProperty) == null))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 42462, 42967);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 42620, 42731);

                                            f_10217_42620_42730(diagnostics, ErrorCode.ERR_NoSetToOverride, overridingMemberLocation, overridingMember, overriddenProperty);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 42462, 42967);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 42462, 42967);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 42845, 42940);

                                            f_10217_42845_42939(diagnostics, ErrorCode.ERR_OverrideNotExpected, overridingMemberLocation, overridingMember);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 42462, 42967);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 42135, 42967);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 41958, 42967);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 41604, 42990);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 40311, 42990);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 39518, 43009);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 39314, 43693);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 39314, 43693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 43075, 43140);

                    NamedTypeSymbol
                    overridingType = f_10217_43108_43139(overridingMember)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 43158, 43678) || true) && (overriddenMembers.Length > 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 43158, 43678);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 43232, 43426);

                        f_10217_43232_43425(diagnostics, ErrorCode.ERR_AmbigOverride, overridingMemberLocation, f_10217_43328_43367(overriddenMembers[0]), f_10217_43369_43408(overriddenMembers[1]), overridingType);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 43448, 43473);

                        suppressAccessors = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 43158, 43678);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 43158, 43678);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 43555, 43659);

                        f_10217_43555_43658(overridingMember, overriddenMembers[0], diagnostics, ref suppressAccessors);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 43158, 43678);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 39314, 43693);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 44553, 45138) || true) && (f_10217_44557_44622_M(!f_10217_44558_44581(this).RuntimeSupportsCovariantReturnsOfClasses) && (DynAbs.Tracing.TraceSender.Expression_True(10217, 44557, 44675) && overridingMember is MethodSymbol overridingMethod))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 44553, 45138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 44709, 44775);

                    f_10217_44709_44774(overridingMethod, out var warnAmbiguous);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 44793, 45123) || true) && (warnAmbiguous)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 44793, 45123);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 44852, 44908);

                        var
                        ambiguousMethod = f_10217_44874_44907(overridingMethod)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 44930, 45057);

                        f_10217_44930_45056(diagnostics, ErrorCode.WRN_MultipleRuntimeOverrideMatches, f_10217_44992_45017(ambiguousMethod)[0], ambiguousMethod, overridingMember);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 45079, 45104);

                        suppressAccessors = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 44793, 45123);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 44553, 45138);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 45154, 45161);

                return;

                void checkSingleOverriddenMember(Symbol overridingMember, Symbol overriddenMember, DiagnosticBag diagnostics, ref bool suppressAccessors)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10217, 45177, 64910);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 45347, 45408);

                        var
                        overridingMemberLocation = f_10217_45378_45404(overridingMember)[0]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 45426, 45500);

                        var
                        overridingMemberIsMethod = f_10217_45457_45478(overridingMember) == SymbolKind.Method
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 45518, 45596);

                        var
                        overridingMemberIsProperty = f_10217_45551_45572(overridingMember) == SymbolKind.Property
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 45614, 45686);

                        var
                        overridingMemberIsEvent = f_10217_45644_45665(overridingMember) == SymbolKind.Event
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 45704, 45757);

                        var
                        overridingType = f_10217_45725_45756(overridingMember)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 45849, 45906);

                        HashSet<DiagnosticInfo>
                        useSiteDiagnosticsNotUsed = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 45924, 46034);

                        f_10217_45924_46033(f_10217_45937_46032(overriddenMember, overridingType, ref useSiteDiagnosticsNotUsed));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 46054, 46115);

                        f_10217_46054_46114(f_10217_46067_46088(overriddenMember) == f_10217_46092_46113(overridingMember));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 46135, 56836) || true) && (f_10217_46139_46181(overriddenMember))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 46135, 56836);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 46223, 46340);

                            f_10217_46223_46339(diagnostics, ErrorCode.ERR_CantOverrideBogusMethod, overridingMemberLocation, overridingMember, overriddenMember);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 46362, 46387);

                            suppressAccessors = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 46135, 56836);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 46135, 56836);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 46429, 56836) || true) && (f_10217_46433_46460_M(!overriddenMember.IsVirtual) && (DynAbs.Tracing.TraceSender.Expression_True(10217, 46433, 46492) && f_10217_46464_46492_M(!overriddenMember.IsAbstract)) && (DynAbs.Tracing.TraceSender.Expression_True(10217, 46433, 46524) && f_10217_46496_46524_M(!overriddenMember.IsOverride)) && (DynAbs.Tracing.TraceSender.Expression_True(10217, 46433, 46648) && !(overridingMemberIsMethod && (DynAbs.Tracing.TraceSender.Expression_True(10217, 46551, 46647) && f_10217_46579_46622(((MethodSymbol)overriddenMember)) == MethodKind.Destructor))))
                            ) //destructors are metadata virtual

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 46429, 56836);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 46834, 46950);

                                f_10217_46834_46949(                    // CONSIDER: To match Dev10, skip the error for properties, and don't suppressAccessors
                                                    diagnostics, ErrorCode.ERR_CantOverrideNonVirtual, overridingMemberLocation, overridingMember, overriddenMember);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 46972, 46997);

                                suppressAccessors = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 46429, 56836);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 46429, 56836);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 47039, 56836) || true) && (f_10217_47043_47068(overriddenMember))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 47039, 56836);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 47219, 47331);

                                    f_10217_47219_47330(                    // CONSIDER: To match Dev10, skip the error for properties, and don't suppressAccessors
                                                        diagnostics, ErrorCode.ERR_CantOverrideSealed, overridingMemberLocation, overridingMember, overriddenMember);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 47353, 47378);

                                    suppressAccessors = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 47039, 56836);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 47039, 56836);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 47420, 56836) || true) && (!f_10217_47425_47492(overriddenMember, overridingMember))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 47420, 56836);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 47534, 47614);

                                        var
                                        accessibility = f_10217_47554_47613(f_10217_47574_47612(overriddenMember))
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 47636, 47771);

                                        f_10217_47636_47770(diagnostics, ErrorCode.ERR_CantChangeAccessOnOverride, overridingMemberLocation, overridingMember, accessibility, overriddenMember);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 47793, 47818);

                                        suppressAccessors = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 47420, 56836);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 47420, 56836);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 47860, 56836) || true) && (f_10217_47864_47901(overridingMember) && (DynAbs.Tracing.TraceSender.Expression_True(10217, 47864, 48024) && f_10217_47926_48024(overridingMember, overriddenMember)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 47860, 56836);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 48194, 48318);

                                            f_10217_48194_48317(                    // it is ok to override with no tuple names, for compatibility with C# 6, but otherwise names should match
                                                                diagnostics, ErrorCode.ERR_CantChangeTupleNamesOnOverride, overridingMemberLocation, overridingMember, overriddenMember);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 47860, 56836);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 47860, 56836);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 48565, 48668);

                                            var
                                            leastOverriddenMember = f_10217_48593_48667(overriddenMember, f_10217_48635_48666(overriddenMember))
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 48692, 48742);

                                            f_10217_48692_48741(
                                                                overridingMember);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 48764, 48819);

                                            f_10217_48764_48818(leastOverriddenMember);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 48843, 48910);

                                            f_10217_48843_48909(f_10217_48856_48886(overridingMember) != ThreeState.Unknown);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 48932, 49004);

                                            f_10217_48932_49003(f_10217_48945_48980(leastOverriddenMember) != ThreeState.Unknown);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 49028, 49112);

                                            bool
                                            overridingMemberIsObsolete = f_10217_49062_49092(overridingMember) == ThreeState.True
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 49134, 49228);

                                            bool
                                            leastOverriddenMemberIsObsolete = f_10217_49173_49208(leastOverriddenMember) == ThreeState.True
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 49252, 49701) || true) && (overridingMemberIsObsolete != leastOverriddenMemberIsObsolete)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 49252, 49701);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 49367, 49561);

                                                ErrorCode
                                                code = (DynAbs.Tracing.TraceSender.Conditional_F1(10217, 49384, 49410) || ((overridingMemberIsObsolete
                                                && DynAbs.Tracing.TraceSender.Conditional_F2(10217, 49442, 49485)) || DynAbs.Tracing.TraceSender.Conditional_F3(10217, 49517, 49560))) ? ErrorCode.WRN_ObsoleteOverridingNonObsolete
                                                : ErrorCode.WRN_NonObsoleteOverridingObsolete
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 49589, 49678);

                                                f_10217_49589_49677(
                                                                        diagnostics, code, overridingMemberLocation, overridingMember, leastOverriddenMember);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 49252, 49701);
                                            }

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 49725, 56230) || true) && (overridingMemberIsProperty)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 49725, 56230);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 49805, 49933);

                                                f_10217_49805_49932(overridingMember, overriddenMember, diagnostics, ref suppressAccessors);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 49725, 56230);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 49725, 56230);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 49983, 56230) || true) && (overridingMemberIsEvent)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 49983, 56230);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 50060, 50120);

                                                    EventSymbol
                                                    overridingEvent = (EventSymbol)overridingMember
                                                    ;
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 50146, 50206);

                                                    EventSymbol
                                                    overriddenEvent = (EventSymbol)overriddenMember
                                                    ;
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 50234, 50313);

                                                    TypeWithAnnotations
                                                    overridingMemberType = f_10217_50277_50312(overridingEvent)
                                                    ;
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 50339, 50418);

                                                    TypeWithAnnotations
                                                    overriddenMemberType = f_10217_50382_50417(overriddenEvent)
                                                    ;

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 50552, 51880) || true) && (!overridingMemberType.Equals(overriddenMemberType, TypeCompareKind.AllIgnoreOptions))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 50552, 51880);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 50847, 51142) || true) && (!f_10217_50852_50900(overridingMemberType.Type))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 50847, 51142);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 50966, 51111);

                                                            f_10217_50966_51110(diagnostics, ErrorCode.ERR_CantChangeTypeOnOverride, overridingMemberLocation, overridingMember, overriddenMember, overriddenMemberType.Type);
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 50847, 51142);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 51172, 51197);

                                                        suppressAccessors = true;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 50552, 51880);
                                                    }

                                                    else

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 50552, 51880);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 51388, 51853);

                                                        f_10217_51388_51852(f_10217_51420_51456(overridingEvent), overriddenEvent, overridingEvent, diagnostics, (diagnostics, overriddenEvent, overridingEvent, location) => diagnostics.Add(ErrorCode.WRN_NullabilityMismatchInTypeOnOverride, location), overridingMemberLocation);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 50552, 51880);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 49983, 56230);
                                                }

                                                else

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 49983, 56230);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 51978, 52017);

                                                    f_10217_51978_52016(overridingMemberIsMethod);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 52045, 52099);

                                                    var
                                                    overridingMethod = (MethodSymbol)overridingMember
                                                    ;
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 52125, 52179);

                                                    var
                                                    overriddenMethod = (MethodSymbol)overriddenMember
                                                    ;

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 52207, 52466) || true) && (f_10217_52211_52243(overridingMethod))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 52207, 52466);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 52301, 52439);

                                                        overriddenMethod = f_10217_52320_52438(overriddenMethod, f_10217_52347_52437(f_10217_52405_52436(overridingMethod)));
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 52207, 52466);
                                                    }

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 52653, 56207) || true) && (f_10217_52657_52681(overridingMethod) != f_10217_52685_52709(overriddenMethod))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 52653, 56207);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 52767, 52890);

                                                        f_10217_52767_52889(diagnostics, ErrorCode.ERR_CantChangeRefReturnOnOverride, overridingMemberLocation, overridingMember, overriddenMember);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 52653, 56207);
                                                    }

                                                    else
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 52653, 56207);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 52948, 56207) || true) && (!f_10217_52953_53097(this, overridingMethod, f_10217_52997_53039(overridingMethod), f_10217_53041_53083(overriddenMethod), diagnostics))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 52948, 56207);

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 53318, 55357) || true) && (!f_10217_53323_53373(f_10217_53345_53372(overridingMethod)))
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 53318, 55357);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 53569, 53628);

                                                                HashSet<DiagnosticInfo>
                                                                discardedUseSiteDiagnostics = null
                                                                ;

                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 53662, 55326) || true) && (f_10217_53666_53870(f_10217_53666_53698(f_10217_53666_53686()), overridingMethod.ReturnTypeWithAnnotations.Type, overriddenMethod.ReturnTypeWithAnnotations.Type, ref discardedUseSiteDiagnostics))
                                                                )

                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 53662, 55326);

                                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 53944, 54875) || true) && (f_10217_53948_54025_M(!f_10217_53949_53984(overridingMethod).RuntimeSupportsCovariantReturnsOfClasses))
                                                                    )

                                                                    {
                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 53944, 54875);
                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 54107, 54276);

                                                                        f_10217_54107_54275(diagnostics, ErrorCode.ERR_RuntimeDoesNotSupportCovariantReturnsOfClasses, overridingMemberLocation, overridingMember, overriddenMember, f_10217_54247_54274(overriddenMethod));
                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 53944, 54875);
                                                                    }

                                                                    else
                                                                    {
                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 53944, 54875);

                                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 54358, 54875) || true) && (f_10217_54362_54475(MessageID.IDS_FeatureCovariantReturnsForOverrides, f_10217_54449_54474(this)) is { } diagnosticInfo)
                                                                        )

                                                                        {
                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 54358, 54875);
                                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 54579, 54637);

                                                                            f_10217_54579_54636(diagnostics, diagnosticInfo, overridingMemberLocation);
                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 54358, 54875);
                                                                        }

                                                                        else

                                                                        {
                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 54358, 54875);
                                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 54799, 54836);

                                                                            throw f_10217_54805_54835();
                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 54358, 54875);
                                                                        }
                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 53944, 54875);
                                                                    }
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 53662, 55326);
                                                                }

                                                                else

                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 53662, 55326);
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 55138, 55291);

                                                                    f_10217_55138_55290(                                    // error CS0508: return type must be 'C<V>' to match overridden member 'M<T>()'
                                                                                                        diagnostics, ErrorCode.ERR_CantChangeReturnTypeOnOverride, overridingMemberLocation, overridingMember, overriddenMember, f_10217_55262_55289(overriddenMethod));
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 53662, 55326);
                                                                }
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 53318, 55357);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 52948, 56207);
                                                        }

                                                        else
                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 52948, 56207);

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 55415, 56207) || true) && (f_10217_55419_55456(overriddenMethod))
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 55415, 56207);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 55514, 55598);

                                                                f_10217_55514_55597(diagnostics, ErrorCode.ERR_OverrideFinalizeDeprecated, overridingMemberLocation);
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 55415, 56207);
                                                            }

                                                            else
                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 55415, 56207);

                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 55656, 56207) || true) && (!f_10217_55661_55690(overridingMethod))
                                                                )

                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 55656, 56207);
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 55827, 56180);

                                                                    f_10217_55827_56179(overridingMemberLocation, overriddenMethod, overridingMethod, diagnostics, checkReturnType: true, checkParameters: true);
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 55656, 56207);
                                                                }
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 55415, 56207);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 52948, 56207);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 52653, 56207);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 49983, 56230);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 49725, 56230);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 56511, 56586);

                                            DiagnosticInfo
                                            useSiteDiagnostic = f_10217_56546_56585(overriddenMember)
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 56608, 56817) || true) && (useSiteDiagnostic != null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 56608, 56817);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 56687, 56794);

                                                suppressAccessors = f_10217_56707_56793(useSiteDiagnostic, diagnostics, f_10217_56763_56789(overridingMember)[0]);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 56608, 56817);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 47860, 56836);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 47420, 56836);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 47039, 56836);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 46429, 56836);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 46135, 56836);
                        }

                        void checkOverriddenProperty(PropertySymbol overridingProperty, PropertySymbol overriddenProperty, DiagnosticBag diagnostics, ref bool suppressAccessors)
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterMethod(10217, 56856, 64895);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 57050, 57113);

                                var
                                overridingMemberLocation = f_10217_57081_57109(overridingProperty)[0]
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 57135, 57190);

                                var
                                overridingType = f_10217_57156_57189(overridingProperty)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 57214, 57296);

                                TypeWithAnnotations
                                overridingMemberType = f_10217_57257_57295(overridingProperty)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 57318, 57400);

                                TypeWithAnnotations
                                overriddenMemberType = f_10217_57361_57399(overriddenProperty)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 57579, 63214) || true) && (f_10217_57583_57609(overridingProperty) != f_10217_57613_57639(overriddenProperty))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 57579, 63214);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 57689, 57816);

                                    f_10217_57689_57815(diagnostics, ErrorCode.ERR_CantChangeRefReturnOnOverride, overridingMemberLocation, overridingProperty, overriddenProperty);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 57842, 57867);

                                    suppressAccessors = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 57579, 63214);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 57579, 63214);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 57998, 63214) || true) && ((DynAbs.Tracing.TraceSender.Conditional_F1(10217, 58002, 58038) || ((f_10217_58002_58030(overridingProperty) is null && DynAbs.Tracing.TraceSender.Conditional_F2(10217, 58066, 58169)) || DynAbs.Tracing.TraceSender.Conditional_F3(10217, 58197, 58281))) ? !f_10217_58067_58169(this, overridingProperty, overridingMemberType, overriddenMemberType, diagnostics) : !overridingMemberType.Equals(overriddenMemberType, TypeCompareKind.AllIgnoreOptions))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 57998, 63214);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 58476, 60779) || true) && (!f_10217_58481_58529(overridingMemberType.Type))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 58476, 60779);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 58706, 58765);

                                            HashSet<DiagnosticInfo>
                                            discardedUseSiteDiagnostics = null
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 58795, 60752) || true) && (f_10217_58799_58827(overridingProperty) is null && (DynAbs.Tracing.TraceSender.Expression_True(10217, 58799, 59032) && f_10217_58872_59032(f_10217_58872_58904(f_10217_58872_58892()), overridingMemberType.Type, overriddenMemberType.Type, ref discardedUseSiteDiagnostics)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 58795, 60752);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 59098, 59911) || true) && (f_10217_59102_59181_M(!f_10217_59103_59140(overridingProperty).RuntimeSupportsCovariantReturnsOfClasses))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 59098, 59911);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 59255, 59425);

                                                    f_10217_59255_59424(diagnostics, ErrorCode.ERR_RuntimeDoesNotSupportCovariantPropertiesOfClasses, overridingMemberLocation, overridingMember, overriddenMember, overriddenMemberType.Type);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 59098, 59911);
                                                }

                                                else

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 59098, 59911);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 59571, 59706);

                                                    var
                                                    diagnosticInfo = f_10217_59592_59705(MessageID.IDS_FeatureCovariantReturnsForOverrides, f_10217_59679_59704(this))
                                                    ;
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 59744, 59780);

                                                    f_10217_59744_59779(diagnosticInfo is { });
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 59818, 59876);

                                                    f_10217_59818_59875(diagnostics, diagnosticInfo, overridingMemberLocation);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 59098, 59911);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 58795, 60752);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 58795, 60752);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 60162, 60307);

                                                f_10217_60162_60306(                                // error CS1715: 'Derived.M': type must be 'object' to match overridden member 'Base.M'
                                                                                diagnostics, ErrorCode.ERR_CantChangeTypeOnOverride, overridingMemberLocation, overridingMember, overriddenMember, overriddenMemberType.Type);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 58795, 60752);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 58476, 60779);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 60807, 60832);

                                        suppressAccessors = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 57998, 63214);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 57998, 63214);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 61007, 62092) || true) && (f_10217_61011_61039(overridingProperty) is object)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 61007, 62092);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 61107, 61190);

                                            MethodSymbol
                                            overriddenGetMethod = f_10217_61142_61189(overriddenProperty)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 61220, 62065);

                                            f_10217_61220_62064(f_10217_61287_61325(f_10217_61287_61315(overridingProperty))[0], overriddenGetMethod, f_10217_61417_61445(overridingProperty), diagnostics, checkReturnType: true, checkParameters: f_10217_61773_61801(overridingProperty) is null || (DynAbs.Tracing.TraceSender.Expression_False(10217, 61773, 61922) || f_10217_61863_61900_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(overriddenGetMethod, 10217, 61863, 61900)?.AssociatedSymbol) != overriddenProperty) || (DynAbs.Tracing.TraceSender.Expression_False(10217, 61773, 62063) || f_10217_61976_62041_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10217_61976_62023(overriddenProperty), 10217, 61976, 62041)?.AssociatedSymbol) != overriddenProperty));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 61007, 62092);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 62120, 63191) || true) && (f_10217_62124_62152(overridingProperty) is object)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 62120, 63191);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 62220, 62308);

                                            var
                                            ownOrInheritedOverriddenSetMethod = f_10217_62260_62307(overriddenProperty)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 62338, 62738);

                                            f_10217_62338_62737(f_10217_62405_62443(f_10217_62405_62433(overridingProperty))[0], ownOrInheritedOverriddenSetMethod, f_10217_62549_62577(overridingProperty), diagnostics, checkReturnType: false, checkParameters: true);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 62770, 63164) || true) && (ownOrInheritedOverriddenSetMethod is object && (DynAbs.Tracing.TraceSender.Expression_True(10217, 62774, 62941) && f_10217_62854_62893(f_10217_62854_62882(overridingProperty)) != f_10217_62897_62941(ownOrInheritedOverriddenSetMethod)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 62770, 63164);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 63007, 63133);

                                                f_10217_63007_63132(diagnostics, ErrorCode.ERR_CantChangeInitOnlyOnOverride, overridingMemberLocation, overridingProperty, overriddenProperty);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 62770, 63164);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 62120, 63191);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 57998, 63214);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 57579, 63214);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 63638, 64876) || true) && (f_10217_63642_63669(overridingProperty))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 63638, 64876);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 63719, 63806);

                                    MethodSymbol
                                    ownOrInheritedGetMethod = f_10217_63758_63805(overridingProperty)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 63832, 63882);

                                    HashSet<DiagnosticInfo>
                                    useSiteDiagnostics = null
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 63908, 64265) || true) && (f_10217_63912_63940(overridingProperty) != ownOrInheritedGetMethod && (DynAbs.Tracing.TraceSender.Expression_True(10217, 63912, 64067) && !f_10217_63972_64067(ownOrInheritedGetMethod, overridingType, ref useSiteDiagnostics)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 63908, 64265);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 64125, 64238);

                                        f_10217_64125_64237(diagnostics, ErrorCode.ERR_NoGetToOverride, overridingMemberLocation, overridingProperty, overriddenProperty);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 63908, 64265);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 64293, 64380);

                                    MethodSymbol
                                    ownOrInheritedSetMethod = f_10217_64332_64379(overridingProperty)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 64406, 64763) || true) && (f_10217_64410_64438(overridingProperty) != ownOrInheritedSetMethod && (DynAbs.Tracing.TraceSender.Expression_True(10217, 64410, 64565) && !f_10217_64470_64565(ownOrInheritedSetMethod, overridingType, ref useSiteDiagnostics)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 64406, 64763);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 64623, 64736);

                                        f_10217_64623_64735(diagnostics, ErrorCode.ERR_NoSetToOverride, overridingMemberLocation, overridingProperty, overriddenProperty);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 64406, 64763);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 64791, 64853);

                                    f_10217_64791_64852(
                                                            diagnostics, overridingMemberLocation, useSiteDiagnostics);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 63638, 64876);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitMethod(10217, 56856, 64895);

                                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                                f_10217_57081_57109(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                                this_param)
                                {
                                    var return_v = this_param.Locations;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 57081, 57109);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                                f_10217_57156_57189(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                                this_param)
                                {
                                    var return_v = this_param.ContainingType;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 57156, 57189);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                                f_10217_57257_57295(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                                this_param)
                                {
                                    var return_v = this_param.TypeWithAnnotations;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 57257, 57295);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                                f_10217_57361_57399(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                                this_param)
                                {
                                    var return_v = this_param.TypeWithAnnotations;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 57361, 57399);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.RefKind
                                f_10217_57583_57609(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                                this_param)
                                {
                                    var return_v = this_param.RefKind;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 57583, 57609);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.RefKind
                                f_10217_57613_57639(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                                this_param)
                                {
                                    var return_v = this_param.RefKind;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 57613, 57639);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                                f_10217_57689_57815(Microsoft.CodeAnalysis.DiagnosticBag
                                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                                code, Microsoft.CodeAnalysis.Location
                                location, params object[]
                                args)
                                {
                                    var return_v = diagnostics.Add(code, location, args);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 57689, 57815);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                                f_10217_58002_58030(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                                this_param)
                                {
                                    var return_v = this_param.SetMethod;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 58002, 58030);
                                    return return_v;
                                }


                                bool
                                f_10217_58067_58169(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                                overridingSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                                overridingReturnType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                                overriddenReturnType, Microsoft.CodeAnalysis.DiagnosticBag
                                diagnostics)
                                {
                                    var return_v = this_param.IsValidOverrideReturnType((Microsoft.CodeAnalysis.CSharp.Symbol)overridingSymbol, overridingReturnType, overriddenReturnType, diagnostics);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 58067, 58169);
                                    return return_v;
                                }


                                bool
                                f_10217_58481_58529(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                                typeSymbol)
                                {
                                    var return_v = IsOrContainsErrorType(typeSymbol);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 58481, 58529);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                                f_10217_58799_58827(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                                this_param)
                                {
                                    var return_v = this_param.SetMethod;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 58799, 58827);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                                f_10217_58872_58892()
                                {
                                    var return_v = DeclaringCompilation;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 58872, 58892);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Conversions
                                f_10217_58872_58904(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                                this_param)
                                {
                                    var return_v = this_param.Conversions;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 58872, 58904);
                                    return return_v;
                                }


                                bool
                                f_10217_58872_59032(Microsoft.CodeAnalysis.CSharp.Conversions
                                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                                useSiteDiagnostics)
                                {
                                    var return_v = this_param.HasIdentityOrImplicitReferenceConversion(source, destination, ref useSiteDiagnostics);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 58872, 59032);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                                f_10217_59103_59140(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                                this_param)
                                {
                                    var return_v = this_param.ContainingAssembly;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 59103, 59140);
                                    return return_v;
                                }


                                bool
                                f_10217_59102_59181_M(bool
                                i)
                                {
                                    var return_v = i;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 59102, 59181);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                                f_10217_59255_59424(Microsoft.CodeAnalysis.DiagnosticBag
                                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                                code, Microsoft.CodeAnalysis.Location
                                location, params object[]
                                args)
                                {
                                    var return_v = diagnostics.Add(code, location, args);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 59255, 59424);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                                f_10217_59679_59704(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                                this_param)
                                {
                                    var return_v = this_param.DeclaringCompilation;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 59679, 59704);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo?
                                f_10217_59592_59705(Microsoft.CodeAnalysis.CSharp.MessageID
                                feature, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                                compilation)
                                {
                                    var return_v = feature.GetFeatureAvailabilityDiagnosticInfo(compilation);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 59592, 59705);
                                    return return_v;
                                }


                                int
                                f_10217_59744_59779(bool
                                condition)
                                {
                                    Debug.Assert(condition);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 59744, 59779);
                                    return 0;
                                }


                                int
                                f_10217_59818_59875(Microsoft.CodeAnalysis.DiagnosticBag
                                diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                                info, Microsoft.CodeAnalysis.Location
                                location)
                                {
                                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 59818, 59875);
                                    return 0;
                                }


                                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                                f_10217_60162_60306(Microsoft.CodeAnalysis.DiagnosticBag
                                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                                code, Microsoft.CodeAnalysis.Location
                                location, params object[]
                                args)
                                {
                                    var return_v = diagnostics.Add(code, location, args);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 60162, 60306);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                                f_10217_61011_61039(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                                this_param)
                                {
                                    var return_v = this_param.GetMethod;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 61011, 61039);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                                f_10217_61142_61189(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                                property)
                                {
                                    var return_v = property.GetOwnOrInheritedGetMethod();
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 61142, 61189);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                                f_10217_61287_61315(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                                this_param)
                                {
                                    var return_v = this_param.GetMethod;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 61287, 61315);
                                    return return_v;
                                }


                                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                                f_10217_61287_61325(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                                this_param)
                                {
                                    var return_v = this_param.Locations;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 61287, 61325);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                                f_10217_61417_61445(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                                this_param)
                                {
                                    var return_v = this_param.GetMethod;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 61417, 61445);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                                f_10217_61773_61801(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                                this_param)
                                {
                                    var return_v = this_param.SetMethod;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 61773, 61801);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbol?
                                f_10217_61863_61900_M(Microsoft.CodeAnalysis.CSharp.Symbol?
                                i)
                                {
                                    var return_v = i;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 61863, 61900);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                                f_10217_61976_62023(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                                property)
                                {
                                    var return_v = property.GetOwnOrInheritedSetMethod();
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 61976, 62023);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbol?
                                f_10217_61976_62041_M(Microsoft.CodeAnalysis.CSharp.Symbol?
                                i)
                                {
                                    var return_v = i;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 61976, 62041);
                                    return return_v;
                                }


                                int
                                f_10217_61220_62064(Microsoft.CodeAnalysis.Location
                                overridingMemberLocation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                                overriddenMethod, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                                overridingMethod, Microsoft.CodeAnalysis.DiagnosticBag
                                diagnostics, bool
                                checkReturnType, bool
                                checkParameters)
                                {
                                    checkValidNullableMethodOverride(overridingMemberLocation, overriddenMethod, overridingMethod, diagnostics, checkReturnType: checkReturnType, checkParameters: checkParameters);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 61220, 62064);
                                    return 0;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                                f_10217_62124_62152(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                                this_param)
                                {
                                    var return_v = this_param.SetMethod;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 62124, 62152);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                                f_10217_62260_62307(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                                property)
                                {
                                    var return_v = property.GetOwnOrInheritedSetMethod();
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 62260, 62307);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                                f_10217_62405_62433(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                                this_param)
                                {
                                    var return_v = this_param.SetMethod;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 62405, 62433);
                                    return return_v;
                                }


                                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                                f_10217_62405_62443(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                                this_param)
                                {
                                    var return_v = this_param.Locations;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 62405, 62443);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                                f_10217_62549_62577(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                                this_param)
                                {
                                    var return_v = this_param.SetMethod;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 62549, 62577);
                                    return return_v;
                                }


                                int
                                f_10217_62338_62737(Microsoft.CodeAnalysis.Location
                                overridingMemberLocation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                                overriddenMethod, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                                overridingMethod, Microsoft.CodeAnalysis.DiagnosticBag
                                diagnostics, bool
                                checkReturnType, bool
                                checkParameters)
                                {
                                    checkValidNullableMethodOverride(overridingMemberLocation, overriddenMethod, overridingMethod, diagnostics, checkReturnType: checkReturnType, checkParameters: checkParameters);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 62338, 62737);
                                    return 0;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                                f_10217_62854_62882(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                                this_param)
                                {
                                    var return_v = this_param.SetMethod;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 62854, 62882);
                                    return return_v;
                                }


                                bool
                                f_10217_62854_62893(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                                this_param)
                                {
                                    var return_v = this_param.IsInitOnly;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 62854, 62893);
                                    return return_v;
                                }


                                bool
                                f_10217_62897_62941(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                                this_param)
                                {
                                    var return_v = this_param.IsInitOnly;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 62897, 62941);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                                f_10217_63007_63132(Microsoft.CodeAnalysis.DiagnosticBag
                                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                                code, Microsoft.CodeAnalysis.Location
                                location, params object[]
                                args)
                                {
                                    var return_v = diagnostics.Add(code, location, args);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 63007, 63132);
                                    return return_v;
                                }


                                bool
                                f_10217_63642_63669(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                                this_param)
                                {
                                    var return_v = this_param.IsSealed;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 63642, 63669);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                                f_10217_63758_63805(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                                property)
                                {
                                    var return_v = property.GetOwnOrInheritedGetMethod();
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 63758, 63805);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                                f_10217_63912_63940(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                                this_param)
                                {
                                    var return_v = this_param.GetMethod;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 63912, 63940);
                                    return return_v;
                                }


                                bool
                                f_10217_63972_64067(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                                within, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                                useSiteDiagnostics)
                                {
                                    var return_v = AccessCheck.IsSymbolAccessible((Microsoft.CodeAnalysis.CSharp.Symbol?)symbol, within, ref useSiteDiagnostics);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 63972, 64067);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                                f_10217_64125_64237(Microsoft.CodeAnalysis.DiagnosticBag
                                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                                code, Microsoft.CodeAnalysis.Location
                                location, params object[]
                                args)
                                {
                                    var return_v = diagnostics.Add(code, location, args);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 64125, 64237);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                                f_10217_64332_64379(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                                property)
                                {
                                    var return_v = property.GetOwnOrInheritedSetMethod();
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 64332, 64379);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                                f_10217_64410_64438(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                                this_param)
                                {
                                    var return_v = this_param.SetMethod;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 64410, 64438);
                                    return return_v;
                                }


                                bool
                                f_10217_64470_64565(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                                within, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                                useSiteDiagnostics)
                                {
                                    var return_v = AccessCheck.IsSymbolAccessible((Microsoft.CodeAnalysis.CSharp.Symbol?)symbol, within, ref useSiteDiagnostics);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 64470, 64565);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                                f_10217_64623_64735(Microsoft.CodeAnalysis.DiagnosticBag
                                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                                code, Microsoft.CodeAnalysis.Location
                                location, params object[]
                                args)
                                {
                                    var return_v = diagnostics.Add(code, location, args);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 64623, 64735);
                                    return return_v;
                                }


                                bool
                                f_10217_64791_64852(Microsoft.CodeAnalysis.DiagnosticBag
                                diagnostics, Microsoft.CodeAnalysis.Location
                                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                                useSiteDiagnostics)
                                {
                                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 64791, 64852);
                                    return return_v;
                                }

                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 56856, 64895);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 56856, 64895);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10217, 45177, 64910);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                        f_10217_45378_45404(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Locations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 45378, 45404);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10217_45457_45478(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 45457, 45478);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10217_45551_45572(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 45551, 45572);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10217_45644_45665(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 45644, 45665);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10217_45725_45756(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.ContainingType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 45725, 45756);
                            return return_v;
                        }


                        bool
                        f_10217_45937_46032(Microsoft.CodeAnalysis.CSharp.Symbol
                        symbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        within, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                        useSiteDiagnostics)
                        {
                            var return_v = AccessCheck.IsSymbolAccessible(symbol, within, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 45937, 46032);
                            return return_v;
                        }


                        int
                        f_10217_45924_46033(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 45924, 46033);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10217_46067_46088(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 46067, 46088);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10217_46092_46113(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 46092, 46113);
                            return return_v;
                        }


                        int
                        f_10217_46054_46114(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 46054, 46114);
                            return 0;
                        }


                        bool
                        f_10217_46139_46181(Microsoft.CodeAnalysis.CSharp.Symbol
                        symbol)
                        {
                            var return_v = symbol.MustCallMethodsDirectly();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 46139, 46181);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10217_46223_46339(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.Location
                        location, params object[]
                        args)
                        {
                            var return_v = diagnostics.Add(code, location, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 46223, 46339);
                            return return_v;
                        }


                        bool
                        f_10217_46433_46460_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 46433, 46460);
                            return return_v;
                        }


                        bool
                        f_10217_46464_46492_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 46464, 46492);
                            return return_v;
                        }


                        bool
                        f_10217_46496_46524_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 46496, 46524);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.MethodKind
                        f_10217_46579_46622(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.MethodKind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 46579, 46622);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10217_46834_46949(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.Location
                        location, params object[]
                        args)
                        {
                            var return_v = diagnostics.Add(code, location, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 46834, 46949);
                            return return_v;
                        }


                        bool
                        f_10217_47043_47068(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.IsSealed;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 47043, 47068);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10217_47219_47330(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.Location
                        location, params object[]
                        args)
                        {
                            var return_v = diagnostics.Add(code, location, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 47219, 47330);
                            return return_v;
                        }


                        bool
                        f_10217_47425_47492(Microsoft.CodeAnalysis.CSharp.Symbol
                        overridden, Microsoft.CodeAnalysis.CSharp.Symbol
                        overriding)
                        {
                            var return_v = OverrideHasCorrectAccessibility(overridden, overriding);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 47425, 47492);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Accessibility
                        f_10217_47574_47612(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.DeclaredAccessibility;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 47574, 47612);
                            return return_v;
                        }


                        string
                        f_10217_47554_47613(Microsoft.CodeAnalysis.Accessibility
                        accessibility)
                        {
                            var return_v = SyntaxFacts.GetText(accessibility);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 47554, 47613);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10217_47636_47770(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.Location
                        location, params object[]
                        args)
                        {
                            var return_v = diagnostics.Add(code, location, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 47636, 47770);
                            return return_v;
                        }


                        bool
                        f_10217_47864_47901(Microsoft.CodeAnalysis.CSharp.Symbol
                        member)
                        {
                            var return_v = member.ContainsTupleNames();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 47864, 47901);
                            return return_v;
                        }


                        bool
                        f_10217_47926_48024(Microsoft.CodeAnalysis.CSharp.Symbol
                        member1, Microsoft.CodeAnalysis.CSharp.Symbol
                        member2)
                        {
                            var return_v = MemberSignatureComparer.ConsideringTupleNamesCreatesDifference(member1, member2);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 47926, 48024);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10217_48194_48317(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.Location
                        location, params object[]
                        args)
                        {
                            var return_v = diagnostics.Add(code, location, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 48194, 48317);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10217_48635_48666(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.ContainingType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 48635, 48666);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10217_48593_48667(Microsoft.CodeAnalysis.CSharp.Symbol
                        member, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        accessingTypeOpt)
                        {
                            var return_v = member.GetLeastOverriddenMember(accessingTypeOpt);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 48593, 48667);
                            return return_v;
                        }


                        int
                        f_10217_48692_48741(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            this_param.ForceCompleteObsoleteAttribute();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 48692, 48741);
                            return 0;
                        }


                        int
                        f_10217_48764_48818(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            this_param.ForceCompleteObsoleteAttribute();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 48764, 48818);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.ThreeState
                        f_10217_48856_48886(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.ObsoleteState;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 48856, 48886);
                            return return_v;
                        }


                        int
                        f_10217_48843_48909(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 48843, 48909);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.ThreeState
                        f_10217_48945_48980(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.ObsoleteState;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 48945, 48980);
                            return return_v;
                        }


                        int
                        f_10217_48932_49003(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 48932, 49003);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.ThreeState
                        f_10217_49062_49092(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.ObsoleteState;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 49062, 49092);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ThreeState
                        f_10217_49173_49208(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.ObsoleteState;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 49173, 49208);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10217_49589_49677(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.Location
                        location, params object[]
                        args)
                        {
                            var return_v = diagnostics.Add(code, location, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 49589, 49677);
                            return return_v;
                        }


                        int
                        f_10217_49805_49932(Microsoft.CodeAnalysis.CSharp.Symbol
                        overridingProperty, Microsoft.CodeAnalysis.CSharp.Symbol
                        overriddenProperty, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, ref bool
                        suppressAccessors)
                        {
                            checkOverriddenProperty((Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol)overridingProperty, (Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol)overriddenProperty, diagnostics, ref suppressAccessors);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 49805, 49932);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        f_10217_50277_50312(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                        this_param)
                        {
                            var return_v = this_param.TypeWithAnnotations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 50277, 50312);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        f_10217_50382_50417(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                        this_param)
                        {
                            var return_v = this_param.TypeWithAnnotations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 50382, 50417);
                            return return_v;
                        }


                        bool
                        f_10217_50852_50900(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        typeSymbol)
                        {
                            var return_v = IsOrContainsErrorType(typeSymbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 50852, 50900);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10217_50966_51110(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.Location
                        location, params object[]
                        args)
                        {
                            var return_v = diagnostics.Add(code, location, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 50966, 51110);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10217_51420_51456(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                        this_param)
                        {
                            var return_v = this_param.DeclaringCompilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 51420, 51456);
                            return return_v;
                        }


                        int
                        f_10217_51388_51852(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        compilation, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                        overriddenEvent, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                        overridingEvent, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, System.Action<Microsoft.CodeAnalysis.DiagnosticBag, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol, Microsoft.CodeAnalysis.Location>
                        reportMismatch, Microsoft.CodeAnalysis.Location
                        extraArgument)
                        {
                            CheckValidNullableEventOverride(compilation, overriddenEvent, overridingEvent, diagnostics, reportMismatch, extraArgument);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 51388, 51852);
                            return 0;
                        }


                        int
                        f_10217_51978_52016(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 51978, 52016);
                            return 0;
                        }


                        bool
                        f_10217_52211_52243(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.IsGenericMethod;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 52211, 52243);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                        f_10217_52405_52436(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.TypeParameters;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 52405, 52436);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        f_10217_52347_52437(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                        typeParameters)
                        {
                            var return_v = TypeMap.TypeParametersAsTypeSymbolsWithIgnoredAnnotations(typeParameters);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 52347, 52437);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10217_52320_52438(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        typeArguments)
                        {
                            var return_v = this_param.Construct(typeArguments);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 52320, 52438);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.RefKind
                        f_10217_52657_52681(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.RefKind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 52657, 52681);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.RefKind
                        f_10217_52685_52709(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.RefKind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 52685, 52709);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10217_52767_52889(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.Location
                        location, params object[]
                        args)
                        {
                            var return_v = diagnostics.Add(code, location, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 52767, 52889);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        f_10217_52997_53039(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ReturnTypeWithAnnotations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 52997, 53039);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        f_10217_53041_53083(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ReturnTypeWithAnnotations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 53041, 53083);
                            return return_v;
                        }


                        bool
                        f_10217_52953_53097(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        overridingSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        overridingReturnType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        overriddenReturnType, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            var return_v = this_param.IsValidOverrideReturnType((Microsoft.CodeAnalysis.CSharp.Symbol)overridingSymbol, overridingReturnType, overriddenReturnType, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 52953, 53097);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10217_53345_53372(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ReturnType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 53345, 53372);
                            return return_v;
                        }


                        bool
                        f_10217_53323_53373(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        typeSymbol)
                        {
                            var return_v = IsOrContainsErrorType(typeSymbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 53323, 53373);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10217_53666_53686()
                        {
                            var return_v = DeclaringCompilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 53666, 53686);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Conversions
                        f_10217_53666_53698(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param)
                        {
                            var return_v = this_param.Conversions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 53666, 53698);
                            return return_v;
                        }


                        bool
                        f_10217_53666_53870(Microsoft.CodeAnalysis.CSharp.Conversions
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                        useSiteDiagnostics)
                        {
                            var return_v = this_param.HasIdentityOrImplicitReferenceConversion(source, destination, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 53666, 53870);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        f_10217_53949_53984(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingAssembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 53949, 53984);
                            return return_v;
                        }


                        bool
                        f_10217_53948_54025_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 53948, 54025);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10217_54247_54274(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ReturnType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 54247, 54274);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10217_54107_54275(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.Location
                        location, params object[]
                        args)
                        {
                            var return_v = diagnostics.Add(code, location, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 54107, 54275);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10217_54449_54474(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.DeclaringCompilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 54449, 54474);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo?
                        f_10217_54362_54475(Microsoft.CodeAnalysis.CSharp.MessageID
                        feature, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        compilation)
                        {
                            var return_v = feature.GetFeatureAvailabilityDiagnosticInfo(compilation);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 54362, 54475);
                            return return_v;
                        }


                        int
                        f_10217_54579_54636(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        info, Microsoft.CodeAnalysis.Location
                        location)
                        {
                            diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 54579, 54636);
                            return 0;
                        }


                        System.Exception
                        f_10217_54805_54835()
                        {
                            var return_v = ExceptionUtilities.Unreachable;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 54805, 54835);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10217_55262_55289(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ReturnType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 55262, 55289);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10217_55138_55290(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.Location
                        location, params object[]
                        args)
                        {
                            var return_v = diagnostics.Add(code, location, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 55138, 55290);
                            return return_v;
                        }


                        bool
                        f_10217_55419_55456(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        method)
                        {
                            var return_v = method.IsRuntimeFinalizer();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 55419, 55456);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10217_55514_55597(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.Location
                        location)
                        {
                            var return_v = diagnostics.Add(code, location);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 55514, 55597);
                            return return_v;
                        }


                        bool
                        f_10217_55661_55690(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        methodSymbol)
                        {
                            var return_v = methodSymbol.IsAccessor();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 55661, 55690);
                            return return_v;
                        }


                        int
                        f_10217_55827_56179(Microsoft.CodeAnalysis.Location
                        overridingMemberLocation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        overriddenMethod, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        overridingMethod, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, bool
                        checkReturnType, bool
                        checkParameters)
                        {
                            checkValidNullableMethodOverride(overridingMemberLocation, overriddenMethod, overridingMethod, diagnostics, checkReturnType: checkReturnType, checkParameters: checkParameters);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 55827, 56179);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.DiagnosticInfo
                        f_10217_56546_56585(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.GetUseSiteDiagnostic();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 56546, 56585);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                        f_10217_56763_56789(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Locations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 56763, 56789);
                            return return_v;
                        }


                        bool
                        f_10217_56707_56793(Microsoft.CodeAnalysis.DiagnosticInfo
                        info, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.Location
                        location)
                        {
                            var return_v = ReportUseSiteDiagnostic(info, diagnostics, location);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 56707, 56793);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 45177, 64910);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 45177, 64910);
                    }
                }

                static void checkValidNullableMethodOverride(
                                Location overridingMemberLocation,
                                MethodSymbol overriddenMethod,
                                MethodSymbol overridingMethod,
                                DiagnosticBag diagnostics,
                                bool checkReturnType,
                                bool checkParameters)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10217, 64926, 65673);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 65274, 65658);

                        f_10217_65274_65657(f_10217_65307_65344(overridingMethod), overriddenMethod, overridingMethod, diagnostics, (DynAbs.Tracing.TraceSender.Conditional_F1(10217, 65445, 65460) || ((checkReturnType && DynAbs.Tracing.TraceSender.Conditional_F2(10217, 65463, 65478)) || DynAbs.Tracing.TraceSender.Conditional_F3(10217, 65481, 65485))) ? ReportBadReturn : null, (DynAbs.Tracing.TraceSender.Conditional_F1(10217, 65537, 65552) || ((checkParameters && DynAbs.Tracing.TraceSender.Conditional_F2(10217, 65555, 65573)) || DynAbs.Tracing.TraceSender.Conditional_F3(10217, 65576, 65580))) ? ReportBadParameter : null, overridingMemberLocation);
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10217, 64926, 65673);

                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10217_65307_65344(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.DeclaringCompilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 65307, 65344);
                            return return_v;
                        }


                        int
                        f_10217_65274_65657(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        baseMethod, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        overrideMethod, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.ReportMismatchInReturnType<Microsoft.CodeAnalysis.Location>?
                        reportMismatchInReturnType, Microsoft.CodeAnalysis.CSharp.Symbols.ReportMismatchInParameterType<Microsoft.CodeAnalysis.Location>?
                        reportMismatchInParameterType, Microsoft.CodeAnalysis.Location
                        extraArgument)
                        {
                            CheckValidNullableMethodOverride(compilation, baseMethod, overrideMethod, diagnostics, reportMismatchInReturnType, reportMismatchInParameterType, extraArgument);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 65274, 65657);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 64926, 65673);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 64926, 65673);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10217, 38302, 65684);

                int
                f_10217_38551_38597(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 38551, 38597);
                    return 0;
                }


                int
                f_10217_38612_38659(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 38612, 38659);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10217_38749_38770(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 38749, 38770);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10217_38839_38860(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 38839, 38860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10217_38928_38949(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 38928, 38949);
                    return return_v;
                }


                int
                f_10217_38986_39079(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 38986, 39079);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10217_39127_39153(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 39127, 39153);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10217_39197_39240(Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                this_param)
                {
                    var return_v = this_param.OverriddenMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 39197, 39240);
                    return return_v;
                }


                bool
                f_10217_39268_39296_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 39268, 39296);
                    return return_v;
                }


                int
                f_10217_39255_39297(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 39255, 39297);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10217_39401_39440(Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                this_param)
                {
                    var return_v = this_param.HiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 39401, 39440);
                    return return_v;
                }


                bool
                f_10217_39472_39496_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 39472, 39496);
                    return return_v;
                }


                int
                f_10217_39459_39497(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 39459, 39497);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10217_39875_39963(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 39875, 39963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10217_40214_40263(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 40214, 40263);
                    return return_v;
                }


                bool
                f_10217_40491_40519(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsIndexer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 40491, 40519);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10217_40658_40720(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterTypesWithAnnotations
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 40658, 40720);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10217_40756_40820(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ParameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 40756, 40820);
                    return return_v;
                }


                bool
                f_10217_40967_41008(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol)
                {
                    var return_v = IsOrContainsErrorType(typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 40967, 41008);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10217_40883_40897_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 40883, 40897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10217_41432_41526(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 41432, 41526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10217_41608_41638(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 41608, 41638);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10217_41892_41929(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.OverriddenProperty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 41892, 41929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10217_42139_42167(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 42139, 42167);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10217_42199_42227(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 42199, 42227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10217_42293_42403(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 42293, 42403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10217_42466_42494(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 42466, 42494);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10217_42526_42554(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 42526, 42554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10217_42620_42730(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 42620, 42730);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10217_42845_42939(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 42845, 42939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10217_43108_43139(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 43108, 43139);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10217_43328_43367(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 43328, 43367);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10217_43369_43408(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 43369, 43408);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10217_43232_43425(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 43232, 43425);
                    return return_v;
                }


                int
                f_10217_43555_43658(Microsoft.CodeAnalysis.CSharp.Symbol
                overridingMember, Microsoft.CodeAnalysis.CSharp.Symbol
                overriddenMember, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                suppressAccessors)
                {
                    checkSingleOverriddenMember(overridingMember, overriddenMember, diagnostics, ref suppressAccessors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 43555, 43658);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10217_44558_44581(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 44558, 44581);
                    return return_v;
                }


                bool
                f_10217_44557_44622_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 44557, 44622);
                    return return_v;
                }


                bool
                f_10217_44709_44774(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, out bool
                warnAmbiguous)
                {
                    var return_v = method.RequiresExplicitOverride(out warnAmbiguous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 44709, 44774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10217_44874_44907(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 44874, 44907);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10217_44992_45017(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 44992, 45017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10217_44930_45056(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 44930, 45056);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 38302, 65684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 38302, 65684);
            }
        }

        internal static bool IsOrContainsErrorType(TypeSymbol typeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10217, 65696, 65929);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 65786, 65918);

                return (object)f_10217_65801_65909(typeSymbol, (currentTypeSymbol, unused1, unused2) => currentTypeSymbol.IsErrorType(), null) != null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10217, 65696, 65929);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10217_65801_65909(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, object, bool, bool>
                predicate, object?
                arg)
                {
                    var return_v = type.VisitType<object?>(predicate, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 65801, 65909);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 65696, 65929);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 65696, 65929);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsValidOverrideReturnType(Symbol overridingSymbol, TypeWithAnnotations overridingReturnType, TypeWithAnnotations overriddenReturnType, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10217, 66192, 67336);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 66391, 67325) || true) && (f_10217_66395_66471(f_10217_66395_66430(overridingSymbol)) && (DynAbs.Tracing.TraceSender.Expression_True(10217, 66395, 66599) && f_10217_66492_66528(f_10217_66492_66512()) >= f_10217_66532_66599(MessageID.IDS_FeatureCovariantReturnsForOverrides)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 66391, 67325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 66633, 66683);

                    HashSet<DiagnosticInfo>
                    useSiteDiagnostics = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 66701, 66866);

                    var
                    result = f_10217_66714_66865(f_10217_66714_66746(f_10217_66714_66734()), overridingReturnType.Type, overriddenReturnType.Type, ref useSiteDiagnostics)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 66884, 67119) || true) && (useSiteDiagnostics != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 66884, 67119);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 66956, 67026);

                        Location
                        symbolLocation = overridingSymbol.Locations.FirstOrDefault()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 67048, 67100);

                        f_10217_67048_67099(diagnostics, symbolLocation, useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 66884, 67119);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 67139, 67153);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 66391, 67325);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 66391, 67325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 67219, 67310);

                    return overridingReturnType.Equals(overriddenReturnType, TypeCompareKind.AllIgnoreOptions);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 66391, 67325);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10217, 66192, 67336);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10217_66395_66430(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 66395, 66430);
                    return return_v;
                }


                bool
                f_10217_66395_66471(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.RuntimeSupportsCovariantReturnsOfClasses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 66395, 66471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10217_66492_66512()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 66492, 66512);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10217_66492_66528(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 66492, 66528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10217_66532_66599(Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = feature.RequiredVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 66532, 66599);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10217_66714_66734()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 66714, 66734);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10217_66714_66746(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 66714, 66746);
                    return return_v;
                }


                bool
                f_10217_66714_66865(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasIdentityOrImplicitReferenceConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 66714, 66865);
                    return return_v;
                }


                bool
                f_10217_67048_67099(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location?
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 67048, 67099);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 66192, 67336);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 66192, 67336);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static readonly ReportMismatchInReturnType<Location> ReportBadReturn;

        static readonly ReportMismatchInParameterType<Location> ReportBadParameter;

        internal static void CheckValidNullableMethodOverride<TArg>(
                    CSharpCompilation compilation,
                    MethodSymbol baseMethod,
                    MethodSymbol overrideMethod,
                    DiagnosticBag diagnostics,
                    ReportMismatchInReturnType<TArg> reportMismatchInReturnType,
                    ReportMismatchInParameterType<TArg> reportMismatchInParameterType,
                    TArg extraArgument,
                    bool invokedAsExtensionMethod = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10217, 68367, 74952);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 68855, 68990) || true) && (!f_10217_68860_68934<TArg>(compilation, baseMethod, overrideMethod))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 68855, 68990);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 68968, 68975);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 68855, 68990);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 69006, 69483) || true) && ((f_10217_69011_69045<TArg>(baseMethod) & FlowAnalysisAnnotations.DoesNotReturn) == FlowAnalysisAnnotations.DoesNotReturn && (DynAbs.Tracing.TraceSender.Expression_True(10217, 69010, 69269) && (f_10217_69149_69187<TArg>(overrideMethod) & FlowAnalysisAnnotations.DoesNotReturn) != FlowAnalysisAnnotations.DoesNotReturn))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 69006, 69483);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 69303, 69468);

                    f_10217_69303_69467<TArg>(diagnostics, ErrorCode.WRN_DoesNotReturnMismatch, f_10217_69356_69380<TArg>(overrideMethod)[0], f_10217_69385_69466<TArg>(overrideMethod, f_10217_69421_69465<TArg>()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 69006, 69483);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 69499, 69563);

                var
                conversions = f_10217_69517_69562<TArg>(f_10217_69517_69540<TArg>(compilation), true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 69577, 69620);

                var
                baseParameters = f_10217_69598_69619<TArg>(baseMethod)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 69634, 69685);

                var
                overrideParameters = f_10217_69659_69684<TArg>(overrideMethod)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 69699, 69762);

                var
                overrideParameterOffset = (DynAbs.Tracing.TraceSender.Conditional_F1(10217, 69729, 69753) || ((invokedAsExtensionMethod && DynAbs.Tracing.TraceSender.Conditional_F2(10217, 69756, 69757)) || DynAbs.Tracing.TraceSender.Conditional_F3(10217, 69760, 69761))) ? 1 : 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 69776, 69875);

                f_10217_69776_69874<TArg>(f_10217_69789_69814<TArg>(baseMethod) == f_10217_69818_69847<TArg>(overrideMethod) - overrideParameterOffset);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 69889, 71283) || true) && (reportMismatchInReturnType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 69889, 71283);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 69961, 70106);

                    var
                    overrideReturnType = f_10217_69986_70105<TArg>(f_10217_70016_70056<TArg>(overrideMethod), f_10217_70058_70104<TArg>(overrideMethod))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 70169, 70585) || true) && (!f_10217_70174_70405<TArg>(conversions, f_10217_70264_70286<TArg>(overrideMethod), overrideReturnType.Type, baseMethod.ReturnTypeWithAnnotations.Type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 70169, 70585);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 70447, 70537);

                        f_10217_70447_70536<TArg>(reportMismatchInReturnType, diagnostics, baseMethod, overrideMethod, false, extraArgument);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 70559, 70566);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 70169, 70585);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 70689, 71268) || true) && (!f_10217_70694_71089<TArg>((DynAbs.Tracing.TraceSender.Conditional_F1(10217, 70769, 70806) || ((f_10217_70769_70791<TArg>(overrideMethod) == RefKind.Ref && DynAbs.Tracing.TraceSender.Conditional_F2(10217, 70809, 70820)) || DynAbs.Tracing.TraceSender.Conditional_F3(10217, 70823, 70834))) ? RefKind.Ref : RefKind.Out, f_10217_70861_70897<TArg>(baseMethod), f_10217_70924_70968<TArg>(baseMethod), overrideReturnType, f_10217_71040_71088<TArg>(overrideMethod)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 70689, 71268);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 71131, 71220);

                        f_10217_71131_71219<TArg>(reportMismatchInReturnType, diagnostics, baseMethod, overrideMethod, true, extraArgument);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 71242, 71249);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 70689, 71268);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 69889, 71283);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 71299, 71396) || true) && (reportMismatchInParameterType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 71299, 71396);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 71374, 71381);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 71299, 71396);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 71421, 71426);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 71412, 72939) || true) && (i < baseParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 71455, 71458)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 71412, 72939))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 71412, 72939);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 71492, 71530);

                        var
                        baseParameter = baseParameters[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 71548, 71606);

                        var
                        baseParameterType = f_10217_71572_71605<TArg>(baseParameter)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 71624, 71696);

                        var
                        overrideParameter = overrideParameters[i + overrideParameterOffset]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 71714, 71856);

                        var
                        overrideParameterType = f_10217_71742_71855<TArg>(f_10217_71772_71809<TArg>(overrideParameter), f_10217_71811_71854<TArg>(overrideParameter))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 71919, 72924) || true) && (!f_10217_71924_72142<TArg>(conversions, f_10217_72014_72039<TArg>(overrideParameter), baseParameterType.Type, overrideParameterType.Type))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 71919, 72924);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 72184, 72296);

                            f_10217_72184_72295<TArg>(reportMismatchInParameterType, diagnostics, baseMethod, overrideMethod, overrideParameter, false, extraArgument);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 71919, 72924);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 71919, 72924);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 72422, 72924) || true) && (!f_10217_72427_72752<TArg>(f_10217_72502_72527<TArg>(overrideParameter), baseParameterType, f_10217_72598_72635<TArg>(baseParameter), overrideParameterType, f_10217_72710_72751<TArg>(overrideParameter)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 72422, 72924);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 72794, 72905);

                                f_10217_72794_72904<TArg>(reportMismatchInParameterType, diagnostics, baseMethod, overrideMethod, overrideParameter, true, extraArgument);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 72422, 72924);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 71919, 72924);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10217, 1, 1528);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10217, 1, 1528);
                }
                TypeWithAnnotations getNotNullIfNotNullOutputType(TypeWithAnnotations outputType, ImmutableHashSet<string> notNullIfParameterNotNull)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10217, 72955, 73739);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 73121, 73686) || true) && (f_10217_73125_73159_M(!notNullIfParameterNotNull.IsEmpty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 73121, 73686);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 73210, 73215);
                                for (var
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 73201, 73667) || true) && (i < baseParameters.Length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 73244, 73247)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 73201, 73667))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 73201, 73667);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 73297, 73365);

                                    var
                                    overrideParam = overrideParameters[i + overrideParameterOffset]
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 73391, 73644) || true) && (f_10217_73395_73449(notNullIfParameterNotNull, f_10217_73430_73448(overrideParam)) && (DynAbs.Tracing.TraceSender.Expression_True(10217, 73395, 73524) && !f_10217_73454_73524(baseParameters[i].TypeWithAnnotations.NullableAnnotation)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 73391, 73644);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 73582, 73617);

                                        return outputType.AsNotAnnotated();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 73391, 73644);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10217, 1, 467);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10217, 1, 467);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 73121, 73686);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 73706, 73724);

                        return outputType;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10217, 72955, 73739);

                        bool
                        f_10217_73125_73159_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 73125, 73159);
                            return return_v;
                        }


                        string
                        f_10217_73430_73448(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 73430, 73448);
                            return return_v;
                        }


                        bool
                        f_10217_73395_73449(System.Collections.Immutable.ImmutableHashSet<string>
                        this_param, string
                        item)
                        {
                            var return_v = this_param.Contains(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 73395, 73449);
                            return return_v;
                        }


                        bool
                        f_10217_73454_73524(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                        annotation)
                        {
                            var return_v = annotation.IsAnnotated();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 73454, 73524);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 72955, 73739);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 72955, 73739);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static bool isValidNullableConversion(
                                ConversionsBase conversions,
                                RefKind refKind,
                                TypeSymbol sourceType,
                                TypeSymbol targetType)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10217, 73755, 74941);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 73986, 74633);

                        switch (refKind)
                        {

                            case RefKind.Ref:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 73986, 74633);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 74142, 74334);

                                return f_10217_74149_74333(sourceType, targetType, TypeCompareKind.AllIgnoreOptions & ~(TypeCompareKind.IgnoreNullableModifiersForReferenceTypes));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 73986, 74633);

                            case RefKind.Out:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 73986, 74633);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 74466, 74518);

                                (sourceType, targetType) = (targetType, sourceType);
                                DynAbs.Tracing.TraceSender.TraceBreak(10217, 74544, 74550);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 73986, 74633);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 73986, 74633);
                                DynAbs.Tracing.TraceSender.TraceBreak(10217, 74608, 74614);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 73986, 74633);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 74653, 74698);

                        f_10217_74653_74697(conversions.IncludeNullability);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 74716, 74768);

                        HashSet<DiagnosticInfo>
                        discardedDiagnostics = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 74786, 74926);

                        return f_10217_74793_74889(conversions, sourceType, targetType, ref discardedDiagnostics).Kind != ConversionKind.NoConversion;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10217, 73755, 74941);

                        bool
                        f_10217_74149_74333(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        t2, Microsoft.CodeAnalysis.TypeCompareKind
                        compareKind)
                        {
                            var return_v = this_param.Equals(t2, compareKind);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 74149, 74333);
                            return return_v;
                        }


                        int
                        f_10217_74653_74697(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 74653, 74697);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Conversion
                        f_10217_74793_74889(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                        useSiteDiagnostics)
                        {
                            var return_v = this_param.ClassifyImplicitConversionFromType(source, destination, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 74793, 74889);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 73755, 74941);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 73755, 74941);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10217, 68367, 74952);

                bool
                f_10217_68860_68934<TArg>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                overriddenMember, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                overridingMember)
                {
                    var return_v = PerformValidNullableOverrideCheck(compilation, (Microsoft.CodeAnalysis.CSharp.Symbol)overriddenMember, (Microsoft.CodeAnalysis.CSharp.Symbol)overridingMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 68860, 68934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
                f_10217_69011_69045<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.FlowAnalysisAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 69011, 69045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
                f_10217_69149_69187<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.FlowAnalysisAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 69149, 69187);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10217_69356_69380<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 69356, 69380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_10217_69421_69465<TArg>()
                {
                    var return_v = SymbolDisplayFormat.MinimallyQualifiedFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 69421, 69465);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FormattedSymbol
                f_10217_69385_69466<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.SymbolDisplayFormat
                symbolDisplayFormat)
                {
                    var return_v = new Microsoft.CodeAnalysis.FormattedSymbol((Microsoft.CodeAnalysis.Symbols.ISymbolInternal)symbol, symbolDisplayFormat);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 69385, 69466);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10217_69303_69467<TArg>(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 69303, 69467);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10217_69517_69540<TArg>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 69517, 69540);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionsBase
                f_10217_69517_69562<TArg>(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, bool
                includeNullability)
                {
                    var return_v = this_param.WithNullability(includeNullability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 69517, 69562);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10217_69598_69619<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 69598, 69619);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10217_69659_69684<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 69659, 69684);
                    return return_v;
                }


                int
                f_10217_69789_69814<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 69789, 69814);
                    return return_v;
                }


                int
                f_10217_69818_69847<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 69818, 69847);
                    return return_v;
                }


                int
                f_10217_69776_69874<TArg>(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 69776, 69874);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10217_70016_70056<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 70016, 70056);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<string>
                f_10217_70058_70104<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnNotNullIfParameterNotNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 70058, 70104);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10217_69986_70105<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                outputType, System.Collections.Immutable.ImmutableHashSet<string>
                notNullIfParameterNotNull)
                {
                    var return_v = getNotNullIfNotNullOutputType(outputType, notNullIfParameterNotNull);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 69986, 70105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10217_70264_70286<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 70264, 70286);
                    return return_v;
                }


                bool
                f_10217_70174_70405<TArg>(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                sourceType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                targetType)
                {
                    var return_v = isValidNullableConversion(conversions, refKind, sourceType, targetType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 70174, 70405);
                    return return_v;
                }


                int
                f_10217_70447_70536<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.ReportMismatchInReturnType<TArg>
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                overriddenMethod, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                overridingMethod, bool
                topLevel, TArg
                arg)
                {
                    this_param.Invoke(bag, overriddenMethod, overridingMethod, topLevel, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 70447, 70536);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10217_70769_70791<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 70769, 70791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10217_70861_70897<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 70861, 70897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
                f_10217_70924_70968<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeFlowAnalysisAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 70924, 70968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
                f_10217_71040_71088<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeFlowAnalysisAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 71040, 71088);
                    return return_v;
                }


                bool
                f_10217_70694_71089<TArg>(Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                overriddenType, Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
                overriddenAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                overridingType, Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
                overridingAnnotations)
                {
                    var return_v = NullableWalker.AreParameterAnnotationsCompatible(refKind, overriddenType, overriddenAnnotations, overridingType, overridingAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 70694, 71089);
                    return return_v;
                }


                int
                f_10217_71131_71219<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.ReportMismatchInReturnType<TArg>
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                overriddenMethod, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                overridingMethod, bool
                topLevel, TArg
                arg)
                {
                    this_param.Invoke(bag, overriddenMethod, overridingMethod, topLevel, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 71131, 71219);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10217_71572_71605<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 71572, 71605);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10217_71772_71809<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 71772, 71809);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<string>
                f_10217_71811_71854<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.NotNullIfParameterNotNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 71811, 71854);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10217_71742_71855<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                outputType, System.Collections.Immutable.ImmutableHashSet<string>
                notNullIfParameterNotNull)
                {
                    var return_v = getNotNullIfNotNullOutputType(outputType, notNullIfParameterNotNull);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 71742, 71855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10217_72014_72039<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 72014, 72039);
                    return return_v;
                }


                bool
                f_10217_71924_72142<TArg>(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                sourceType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                targetType)
                {
                    var return_v = isValidNullableConversion(conversions, refKind, sourceType, targetType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 71924, 72142);
                    return return_v;
                }


                int
                f_10217_72184_72295<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.ReportMismatchInParameterType<TArg>
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                overriddenMethod, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                overridingMethod, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, bool
                topLevel, TArg
                arg)
                {
                    this_param.Invoke(bag, overriddenMethod, overridingMethod, parameter, topLevel, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 72184, 72295);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10217_72502_72527<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 72502, 72527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
                f_10217_72598_72635<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.FlowAnalysisAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 72598, 72635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
                f_10217_72710_72751<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.FlowAnalysisAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 72710, 72751);
                    return return_v;
                }


                bool
                f_10217_72427_72752<TArg>(Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                overriddenType, Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
                overriddenAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                overridingType, Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
                overridingAnnotations)
                {
                    var return_v = NullableWalker.AreParameterAnnotationsCompatible(refKind, overriddenType, overriddenAnnotations, overridingType, overridingAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 72427, 72752);
                    return return_v;
                }


                int
                f_10217_72794_72904<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.ReportMismatchInParameterType<TArg>
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                overriddenMethod, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                overridingMethod, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, bool
                topLevel, TArg
                arg)
                {
                    this_param.Invoke(bag, overriddenMethod, overridingMethod, parameter, topLevel, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 72794, 72904);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 68367, 74952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 68367, 74952);
            }
        }

        private static bool PerformValidNullableOverrideCheck(
                    CSharpCompilation compilation,
                    Symbol overriddenMember,
                    Symbol overridingMember)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10217, 74964, 75545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 75308, 75534);

                return overriddenMember is object && (DynAbs.Tracing.TraceSender.Expression_True(10217, 75315, 75391) && overridingMember is object) && (DynAbs.Tracing.TraceSender.Expression_True(10217, 75315, 75436) && compilation is object) && (DynAbs.Tracing.TraceSender.Expression_True(10217, 75315, 75533) && f_10217_75460_75533(compilation, MessageID.IDS_FeatureNullableReferenceTypes));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10217, 74964, 75545);

                bool
                f_10217_75460_75533(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = compilation.IsFeatureEnabled(feature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 75460, 75533);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 74964, 75545);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 74964, 75545);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void CheckValidNullableEventOverride<TArg>(
                    CSharpCompilation compilation,
                    EventSymbol overriddenEvent,
                    EventSymbol overridingEvent,
                    DiagnosticBag diagnostics,
                    Action<DiagnosticBag, EventSymbol, EventSymbol, TArg> reportMismatch,
                    TArg extraArgument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10217, 75557, 76423);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 75925, 76066) || true) && (!f_10217_75930_76010<TArg>(compilation, overriddenEvent, overridingEvent))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 75925, 76066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 76044, 76051);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 75925, 76066);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 76082, 76146);

                var
                conversions = f_10217_76100_76145<TArg>(f_10217_76100_76123<TArg>(compilation), true)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 76160, 76412) || true) && (!f_10217_76165_76286<TArg>(conversions, f_10217_76213_76248<TArg>(overriddenEvent), f_10217_76250_76285<TArg>(overridingEvent)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 76160, 76412);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 76320, 76397);

                    f_10217_76320_76396<TArg>(reportMismatch, diagnostics, overriddenEvent, overridingEvent, extraArgument);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 76160, 76412);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10217, 75557, 76423);

                bool
                f_10217_75930_76010<TArg>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                overriddenMember, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                overridingMember)
                {
                    var return_v = PerformValidNullableOverrideCheck(compilation, (Microsoft.CodeAnalysis.CSharp.Symbol)overriddenMember, (Microsoft.CodeAnalysis.CSharp.Symbol)overridingMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 75930, 76010);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10217_76100_76123<TArg>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 76100, 76123);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionsBase
                f_10217_76100_76145<TArg>(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, bool
                includeNullability)
                {
                    var return_v = this_param.WithNullability(includeNullability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 76100, 76145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10217_76213_76248<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 76213, 76248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10217_76250_76285<TArg>(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 76250, 76285);
                    return return_v;
                }


                bool
                f_10217_76165_76286<TArg>(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                destination)
                {
                    var return_v = this_param.HasAnyNullabilityImplicitConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 76165, 76286);
                    return return_v;
                }


                int
                f_10217_76320_76396<TArg>(System.Action<Microsoft.CodeAnalysis.DiagnosticBag, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol, TArg>
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                arg1, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                arg2, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                arg3, TArg
                arg4)
                {
                    this_param.Invoke(arg1, arg2, arg3, arg4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 76320, 76396);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 75557, 76423);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 75557, 76423);
            }
        }

        private static void CheckNonOverrideMember(
                    Symbol hidingMember,
                    bool hidingMemberIsNew,
                    OverriddenOrHiddenMembersResult overriddenOrHiddenMembers,
                    DiagnosticBag diagnostics, out bool suppressAccessors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10217, 76435, 79202);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 76714, 76740);

                suppressAccessors = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 76756, 76809);

                var
                hidingMemberLocation = f_10217_76783_76805(hidingMember)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 76825, 76873);

                f_10217_76825_76872(overriddenOrHiddenMembers != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 76887, 76952);

                f_10217_76887_76951(!overriddenOrHiddenMembers.OverriddenMembers.Any());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 77009, 77069);

                var
                hiddenMembers = f_10217_77029_77068(overriddenOrHiddenMembers)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 77083, 77122);

                f_10217_77083_77121(f_10217_77096_77120_M(!hiddenMembers.IsDefault));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 77138, 79191) || true) && (hiddenMembers.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 77138, 79191);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 77201, 77395) || true) && (hidingMemberIsNew && (DynAbs.Tracing.TraceSender.Expression_True(10217, 77205, 77252) && !f_10217_77227_77252(hidingMember)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 77201, 77395);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 77294, 77376);

                        f_10217_77294_77375(diagnostics, ErrorCode.WRN_NewNotRequired, hidingMemberLocation, hidingMember);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 77201, 77395);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 77138, 79191);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 77138, 79191);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 77461, 77489);

                    var
                    diagnosticAdded = false
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 77696, 78843) || true) && (f_10217_77700_77740_M(!f_10217_77701_77728(hidingMember).IsInterface))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 77696, 78843);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 77782, 78824);
                            foreach (var hiddenMember in f_10217_77811_77824_I(hiddenMembers))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 77782, 78824);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 77874, 78007);

                                diagnosticAdded |= f_10217_77893_78006(hidingMember, hidingMemberLocation, hiddenMember, diagnostics, ref suppressAccessors);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 78106, 78663) || true) && (!hidingMemberIsNew && (DynAbs.Tracing.TraceSender.Expression_True(10217, 78110, 78170) && f_10217_78132_78149(hiddenMember) == f_10217_78153_78170(hidingMember)) && (DynAbs.Tracing.TraceSender.Expression_True(10217, 78110, 78229) && !f_10217_78204_78229(hidingMember)) && (DynAbs.Tracing.TraceSender.Expression_True(10217, 78110, 78340) && (f_10217_78263_78286(hiddenMember) || (DynAbs.Tracing.TraceSender.Expression_False(10217, 78263, 78312) || f_10217_78290_78312(hiddenMember)) || (DynAbs.Tracing.TraceSender.Expression_False(10217, 78263, 78339) || f_10217_78316_78339(hiddenMember)))) && (DynAbs.Tracing.TraceSender.Expression_True(10217, 78110, 78422) && !f_10217_78374_78422(hidingMember)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 78106, 78663);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 78480, 78583);

                                    f_10217_78480_78582(diagnostics, ErrorCode.WRN_NewOrOverrideExpected, hidingMemberLocation, hidingMember, hiddenMember);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 78613, 78636);

                                    diagnosticAdded = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 78106, 78663);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 78691, 78801) || true) && (diagnosticAdded)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 78691, 78801);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10217, 78768, 78774);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 78691, 78801);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 77782, 78824);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10217, 1, 1043);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10217, 1, 1043);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 77696, 78843);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 78863, 79176) || true) && (!hidingMemberIsNew && (DynAbs.Tracing.TraceSender.Expression_True(10217, 78867, 78938) && !f_10217_78890_78938(hidingMember)) && (DynAbs.Tracing.TraceSender.Expression_True(10217, 78867, 78958) && !diagnosticAdded) && (DynAbs.Tracing.TraceSender.Expression_True(10217, 78867, 78988) && !f_10217_78963_78988(hidingMember)) && (DynAbs.Tracing.TraceSender.Expression_True(10217, 78867, 79018) && !f_10217_78993_79018(hidingMember)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 78863, 79176);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 79060, 79157);

                        f_10217_79060_79156(diagnostics, ErrorCode.WRN_NewRequired, hidingMemberLocation, hidingMember, hiddenMembers[0]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 78863, 79176);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 77138, 79191);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10217, 76435, 79202);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10217_76783_76805(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 76783, 76805);
                    return return_v;
                }


                int
                f_10217_76825_76872(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 76825, 76872);
                    return 0;
                }


                int
                f_10217_76887_76951(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 76887, 76951);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10217_77029_77068(Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                this_param)
                {
                    var return_v = this_param.HiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 77029, 77068);
                    return return_v;
                }


                bool
                f_10217_77096_77120_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 77096, 77120);
                    return return_v;
                }


                int
                f_10217_77083_77121(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 77083, 77121);
                    return 0;
                }


                bool
                f_10217_77227_77252(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 77227, 77252);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10217_77294_77375(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 77294, 77375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10217_77701_77728(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 77701, 77728);
                    return return_v;
                }


                bool
                f_10217_77700_77740_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 77700, 77740);
                    return return_v;
                }


                bool
                f_10217_77893_78006(Microsoft.CodeAnalysis.CSharp.Symbol
                hidingMember, Microsoft.CodeAnalysis.Location
                hidingMemberLocation, Microsoft.CodeAnalysis.CSharp.Symbol
                hiddenMember, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                suppressAccessors)
                {
                    var return_v = AddHidingAbstractDiagnostic(hidingMember, hidingMemberLocation, hiddenMember, diagnostics, ref suppressAccessors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 77893, 78006);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10217_78132_78149(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 78132, 78149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10217_78153_78170(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 78153, 78170);
                    return return_v;
                }


                bool
                f_10217_78204_78229(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 78204, 78229);
                    return return_v;
                }


                bool
                f_10217_78263_78286(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 78263, 78286);
                    return return_v;
                }


                bool
                f_10217_78290_78312(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 78290, 78312);
                    return return_v;
                }


                bool
                f_10217_78316_78339(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 78316, 78339);
                    return return_v;
                }


                bool
                f_10217_78374_78422(Microsoft.CodeAnalysis.CSharp.Symbol
                hidingMember)
                {
                    var return_v = IsShadowingSynthesizedRecordMember(hidingMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 78374, 78422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10217_78480_78582(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 78480, 78582);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10217_77811_77824_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 77811, 77824);
                    return return_v;
                }


                bool
                f_10217_78890_78938(Microsoft.CodeAnalysis.CSharp.Symbol
                hidingMember)
                {
                    var return_v = IsShadowingSynthesizedRecordMember(hidingMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 78890, 78938);
                    return return_v;
                }


                bool
                f_10217_78963_78988(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 78963, 78988);
                    return return_v;
                }


                bool
                f_10217_78993_79018(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsOperator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 78993, 79018);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10217_79060_79156(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 79060, 79156);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 76435, 79202);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 76435, 79202);
            }
        }

        private static bool IsShadowingSynthesizedRecordMember(Symbol hidingMember)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10217, 79214, 79462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 79314, 79451);

                return hidingMember is SynthesizedRecordEquals || (DynAbs.Tracing.TraceSender.Expression_False(10217, 79321, 79408) || hidingMember is SynthesizedRecordDeconstruct) || (DynAbs.Tracing.TraceSender.Expression_False(10217, 79321, 79450) || hidingMember is SynthesizedRecordClone);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10217, 79214, 79462);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 79214, 79462);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 79214, 79462);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool AddHidingAbstractDiagnostic(Symbol hidingMember, Location hidingMemberLocation, Symbol hiddenMember, DiagnosticBag diagnostics, ref bool suppressAccessors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10217, 79665, 82995);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 79865, 80193);

                switch (f_10217_79873_79890(hiddenMember))
                {

                    case SymbolKind.Method:
                    case SymbolKind.Property:
                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 79865, 80193);
                        DynAbs.Tracing.TraceSender.TraceBreak(10217, 80052, 80058);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 79865, 80193);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 79865, 80193);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 80134, 80147);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 79865, 80193);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 80392, 80525) || true) && (f_10217_80396_80420_M(!hiddenMember.IsAbstract) || (DynAbs.Tracing.TraceSender.Expression_False(10217, 80396, 80463) || f_10217_80424_80463_M(!f_10217_80425_80452(hidingMember).IsAbstract)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 80392, 80525);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 80497, 80510);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 80392, 80525);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 80541, 82957);

                switch (f_10217_80549_80583(hidingMember))
                {

                    case Accessibility.Internal:
                    case Accessibility.Private:
                    case Accessibility.ProtectedAndInternal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 80541, 82957);
                        DynAbs.Tracing.TraceSender.TraceBreak(10217, 80770, 80776);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 80541, 82957);

                    case Accessibility.Public:
                    case Accessibility.ProtectedOrInternal:
                    case Accessibility.Protected:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 80541, 82957);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 81147, 82754);

                            switch (f_10217_81155_81172(hidingMember))
                            {

                                case SymbolKind.Method:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 81147, 82754);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 81287, 81365);

                                    var
                                    associatedPropertyOrEvent = f_10217_81319_81364(((MethodSymbol)hidingMember))
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 81399, 81851) || true) && ((object)associatedPropertyOrEvent != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 81399, 81851);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 81639, 81772);

                                        f_10217_81639_81771(                                    //Dev10 reports that the property/event is doing the hiding, rather than the method
                                                                            diagnostics, ErrorCode.ERR_HidingAbstractMethod, f_10217_81691_81726(associatedPropertyOrEvent)[0], associatedPropertyOrEvent, hiddenMember);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10217, 81810, 81816);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 81399, 81851);
                                    }

                                    goto default;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 81147, 82754);

                                case SymbolKind.Property:
                                case SymbolKind.Event:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 81147, 82754);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 82439, 82464);

                                    suppressAccessors = true;

                                    goto default;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 81147, 82754);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 81147, 82754);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 82585, 82687);

                                    f_10217_82585_82686(diagnostics, ErrorCode.ERR_HidingAbstractMethod, hidingMemberLocation, hidingMember, hiddenMember);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10217, 82721, 82727);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 81147, 82754);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 82782, 82794);

                            return true;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 80541, 82957);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 80541, 82957);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 82865, 82942);

                        throw f_10217_82871_82941(f_10217_82906_82940(hidingMember));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 80541, 82957);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 82971, 82984);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10217, 79665, 82995);

                Microsoft.CodeAnalysis.SymbolKind
                f_10217_79873_79890(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 79873, 79890);
                    return return_v;
                }


                bool
                f_10217_80396_80420_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 80396, 80420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10217_80425_80452(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 80425, 80452);
                    return return_v;
                }


                bool
                f_10217_80424_80463_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 80424, 80463);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10217_80549_80583(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 80549, 80583);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10217_81155_81172(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 81155, 81172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10217_81319_81364(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 81319, 81364);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10217_81691_81726(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 81691, 81726);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10217_81639_81771(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 81639, 81771);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10217_82585_82686(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 82585, 82686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10217_82906_82940(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 82906, 82940);
                    return return_v;
                }


                System.Exception
                f_10217_82871_82941(Microsoft.CodeAnalysis.Accessibility
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 82871, 82941);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 79665, 82995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 79665, 82995);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool OverrideHasCorrectAccessibility(Symbol overridden, Symbol overriding)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10217, 83007, 83779);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 83335, 83768) || true) && (!f_10217_83340_83420(f_10217_83340_83369(overriding), f_10217_83390_83419(overridden)) && (DynAbs.Tracing.TraceSender.Expression_True(10217, 83339, 83510) && f_10217_83441_83473(overridden) == Accessibility.ProtectedOrInternal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 83335, 83768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 83544, 83611);

                    return f_10217_83551_83583(overriding) == Accessibility.Protected;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 83335, 83768);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 83335, 83768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 83677, 83753);

                    return f_10217_83684_83716(overridden) == f_10217_83720_83752(overriding);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 83335, 83768);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10217, 83007, 83779);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10217_83340_83369(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 83340, 83369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10217_83390_83419(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 83390, 83419);
                    return return_v;
                }


                bool
                f_10217_83340_83420(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                fromAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                toAssembly)
                {
                    var return_v = fromAssembly.HasInternalAccessTo(toAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 83340, 83420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10217_83441_83473(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 83441, 83473);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10217_83551_83583(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 83551, 83583);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10217_83684_83716(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 83684, 83716);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10217_83720_83752(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 83720, 83752);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 83007, 83779);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 83007, 83779);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckInterfaceUnification(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10217, 84219, 86528);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 84309, 84388) || true) && (f_10217_84313_84332_M(!this.IsGenericType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 84309, 84388);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 84366, 84373);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 84309, 84388);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 84504, 84588);

                int
                numInterfaces = f_10217_84524_84587(f_10217_84524_84581(this))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 84604, 84681) || true) && (numInterfaces < 2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 84604, 84681);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 84659, 84666);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 84604, 84681);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 85050, 85154);

                NamedTypeSymbol[]
                interfaces = f_10217_85081_85153(f_10217_85081_85143(f_10217_85081_85138(this)))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 85179, 85185);

                    for (int
        i1 = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 85170, 86517) || true) && (i1 < numInterfaces)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 85207, 85211)
        , i1++, DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 85170, 86517))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 85170, 86517);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 85254, 85265);
                            for (int
            i2 = i1 + 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 85245, 86502) || true) && (i2 < numInterfaces)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 85287, 85291)
            , i2++, DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 85245, 86502))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 85245, 86502);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 85333, 85377);

                                NamedTypeSymbol
                                interface1 = interfaces[i1]
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 85399, 85443);

                                NamedTypeSymbol
                                interface2 = interfaces[i2]
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 85554, 86483) || true) && (f_10217_85558_85582(interface1) && (DynAbs.Tracing.TraceSender.Expression_True(10217, 85558, 85610) && f_10217_85586_85610(interface2)) && (DynAbs.Tracing.TraceSender.Expression_True(10217, 85558, 85755) && f_10217_85639_85755(f_10217_85657_85686(interface1), f_10217_85688_85717(interface2), TypeCompareKind.ConsiderEverything2)) && (DynAbs.Tracing.TraceSender.Expression_True(10217, 85558, 85819) && f_10217_85784_85819(interface1, interface2)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 85554, 86483);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 85869, 86320) || true) && (f_10217_85873_85916(this, interface1).SourceSpan.Start > f_10217_85936_85979(this, interface2).SourceSpan.Start)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 85869, 86320);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 86169, 86191);

                                        var
                                        temp = interface1
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 86221, 86245);

                                        interface1 = interface2;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 86275, 86293);

                                        interface2 = temp;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 85869, 86320);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 86348, 86460);

                                    f_10217_86348_86459(
                                                            diagnostics, ErrorCode.ERR_UnifyingInterfaceInstantiations, f_10217_86411_86425(this)[0], this, interface1, interface2);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 85554, 86483);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10217, 1, 1258);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10217, 1, 1258);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10217, 1, 1348);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10217, 1, 1348);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10217, 84219, 86528);

                bool
                f_10217_84313_84332_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 84313, 84332);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10217_84524_84581(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.InterfacesAndTheirBaseInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 84524, 84581);
                    return return_v;
                }


                int
                f_10217_84524_84587(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 84524, 84587);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10217_85081_85138(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.InterfacesAndTheirBaseInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 85081, 85138);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>.ValueSet>.KeyCollection
                f_10217_85081_85143(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 85081, 85143);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol[]
                f_10217_85081_85153(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>.ValueSet>.KeyCollection
                source)
                {
                    var return_v = source.ToArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 85081, 85153);
                    return return_v;
                }


                bool
                f_10217_85558_85582(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 85558, 85582);
                    return return_v;
                }


                bool
                f_10217_85586_85610(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 85586, 85610);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10217_85657_85686(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 85657, 85686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10217_85688_85717(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 85688, 85717);
                    return return_v;
                }


                bool
                f_10217_85639_85755(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 85639, 85755);
                    return return_v;
                }


                bool
                f_10217_85784_85819(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                thisType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                otherType)
                {
                    var return_v = thisType.CanUnifyWith((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)otherType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 85784, 85819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10217_85873_85916(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                implementedInterface)
                {
                    var return_v = this_param.GetImplementsLocationOrFallback(implementedInterface);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 85873, 85916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10217_85936_85979(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                implementedInterface)
                {
                    var return_v = this_param.GetImplementsLocationOrFallback(implementedInterface);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 85936, 85979);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10217_86411_86425(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 86411, 86425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10217_86348_86459(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 86348, 86459);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 84219, 86528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 84219, 86528);
            }
        }

        private SynthesizedExplicitImplementationForwardingMethod SynthesizeInterfaceMemberImplementation(SymbolAndDiagnostics implementingMemberAndDiagnostics, Symbol interfaceMember)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10217, 87540, 91780);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 87741, 88154) || true) && (f_10217_87745_87782(interfaceMember) != Accessibility.Public)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 87741, 88154);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 88127, 88139);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 87741, 88154);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 88170, 88421);
                    foreach (Diagnostic diagnostic in f_10217_88204_88248_I(implementingMemberAndDiagnostics.Diagnostics))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 88170, 88421);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 88282, 88406) || true) && (f_10217_88286_88305(diagnostic) == DiagnosticSeverity.Error)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 88282, 88406);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 88375, 88387);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 88282, 88406);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 88170, 88421);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10217, 1, 252);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10217, 1, 252);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 88437, 88505);

                Symbol
                implementingMember = implementingMemberAndDiagnostics.Symbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 88618, 88765) || true) && ((object)implementingMember == null || (DynAbs.Tracing.TraceSender.Expression_False(10217, 88622, 88704) || f_10217_88660_88683(implementingMember) != SymbolKind.Method))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 88618, 88765);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 88738, 88750);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 88618, 88765);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 88781, 88842);

                MethodSymbol
                interfaceMethod = (MethodSymbol)interfaceMember
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 88856, 88923);

                MethodSymbol
                implementingMethod = (MethodSymbol)implementingMember
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 89283, 89504) || true) && (f_10217_89287_89319(interfaceMethod) != null && (DynAbs.Tracing.TraceSender.Expression_True(10217, 89287, 89443) && f_10217_89349_89435(f_10217_89349_89381(interfaceMethod)) == true))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 89283, 89504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 89477, 89489);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 89283, 89504);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 89592, 89804) || true) && (f_10217_89596_89743(implementingMethod.ExplicitInterfaceImplementations, interfaceMethod, ExplicitInterfaceImplementationTargetMemberEqualityComparer.Instance))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 89592, 89804);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 89777, 89789);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 89592, 89804);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 89820, 89910);

                MethodSymbol
                implementingMethodOriginalDefinition = f_10217_89872_89909(implementingMethod)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 89926, 89968);

                bool
                needSynthesizedImplementation = true
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 90360, 91538) || true) && (f_10217_90364_90469(MemberSignatureComparer.RuntimeImplicitImplementationComparer, implementingMethod, interfaceMethod) && (DynAbs.Tracing.TraceSender.Expression_True(10217, 90364, 90594) && f_10217_90490_90594(implementingMethod, f_10217_90562_90593(@interfaceMethod))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 90360, 91538);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 90628, 91523) || true) && (f_10217_90632_90725(f_10217_90648_90669(this), f_10217_90671_90724(implementingMethodOriginalDefinition)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 90628, 91523);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 90767, 90899);

                        SourceMemberMethodSymbol
                        sourceImplementMethodOriginalDefinition = implementingMethodOriginalDefinition as SourceMemberMethodSymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 90921, 91181) || true) && ((object)sourceImplementMethodOriginalDefinition != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 90921, 91181);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 91030, 91094);

                            f_10217_91030_91093(sourceImplementMethodOriginalDefinition);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 91120, 91158);

                            needSynthesizedImplementation = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 90921, 91181);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 90628, 91523);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 90628, 91523);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 91223, 91523) || true) && (f_10217_91227_91307(implementingMethod, ignoreInterfaceImplementationChanges: true))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 91223, 91523);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 91466, 91504);

                            needSynthesizedImplementation = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 91223, 91523);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 90628, 91523);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 90360, 91538);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 91554, 91649) || true) && (!needSynthesizedImplementation)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 91554, 91649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 91622, 91634);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 91554, 91649);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 91665, 91769);

                return f_10217_91672_91768(interfaceMethod, implementingMethod, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10217, 87540, 91780);

                Microsoft.CodeAnalysis.Accessibility
                f_10217_87745_87782(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 87745, 87782);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10217_88286_88305(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 88286, 88305);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10217_88204_88248_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 88204, 88248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10217_88660_88683(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 88660, 88683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10217_89287_89319(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 89287, 89319);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10217_89349_89381(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 89349, 89381);
                    return return_v;
                }


                bool
                f_10217_89349_89435(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsEventOrPropertyWithImplementableNonPublicAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 89349, 89435);
                    return return_v;
                }


                bool
                f_10217_89596_89743(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                list, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                item, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.ExplicitInterfaceImplementationTargetMemberEqualityComparer
                comparer)
                {
                    var return_v = list.Contains<Microsoft.CodeAnalysis.CSharp.Symbol>((Microsoft.CodeAnalysis.CSharp.Symbol)item, (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 89596, 89743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10217_89872_89909(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 89872, 89909);
                    return return_v;
                }


                bool
                f_10217_90364_90469(Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member1, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member2)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbol)member1, (Microsoft.CodeAnalysis.CSharp.Symbol)member2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 90364, 90469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10217_90562_90593(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 90562, 90593);
                    return return_v;
                }


                bool
                f_10217_90490_90594(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                implementingMethod, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                @interface)
                {
                    var return_v = IsOverrideOfPossibleImplementationUnderRuntimeRules(implementingMethod, @interface);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 90490, 90594);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10217_90648_90669(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 90648, 90669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10217_90671_90724(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 90671, 90724);
                    return return_v;
                }


                bool
                f_10217_90632_90725(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 90632, 90725);
                    return return_v;
                }


                int
                f_10217_91030_91093(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    this_param.EnsureMetadataVirtual();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 91030, 91093);
                    return 0;
                }


                bool
                f_10217_91227_91307(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, bool
                ignoreInterfaceImplementationChanges)
                {
                    var return_v = this_param.IsMetadataVirtual(ignoreInterfaceImplementationChanges: ignoreInterfaceImplementationChanges);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 91227, 91307);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod
                f_10217_91672_91768(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                interfaceMethod, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                implementingMethod, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                implementingType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod(interfaceMethod, implementingMethod, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)implementingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 91672, 91768);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 87540, 91780);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 87540, 91780);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsPossibleImplementationUnderRuntimeRules(MethodSymbol implementingMethod, NamedTypeSymbol @interface)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10217, 92710, 93276);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 92857, 92914);

                NamedTypeSymbol
                type = f_10217_92880_92913(implementingMethod)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 92928, 93074) || true) && (f_10217_92932_93013(f_10217_92932_92989(type), @interface))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 92928, 93074);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 93047, 93059);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 92928, 93074);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 93090, 93151);

                NamedTypeSymbol
                baseType = f_10217_93117_93150(type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 93165, 93265);

                return (object)baseType == null || (DynAbs.Tracing.TraceSender.Expression_False(10217, 93172, 93264) || !baseType.AllInterfacesNoUseSiteDiagnostics.Contains(@interface));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10217, 92710, 93276);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10217_92880_92913(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 92880, 92913);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10217_92932_92989(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.InterfacesAndTheirBaseInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 92932, 92989);
                    return return_v;
                }


                bool
                f_10217_92932_93013(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                k)
                {
                    var return_v = this_param.ContainsKey(k);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 92932, 93013);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10217_93117_93150(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 93117, 93150);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 92710, 93276);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 92710, 93276);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsOverrideOfPossibleImplementationUnderRuntimeRules(MethodSymbol implementingMethod, NamedTypeSymbol @interface)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10217, 94175, 94684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 94332, 94371);

                MethodSymbol
                curr = implementingMethod
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 94385, 94646) || true) && ((object)curr != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 94385, 94646);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 94446, 94582) || true) && (f_10217_94450_94509(curr, @interface))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10217, 94446, 94582);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 94551, 94563);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 94446, 94582);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 94602, 94631);

                        curr = f_10217_94609_94630(curr);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10217, 94385, 94646);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10217, 94385, 94646);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10217, 94385, 94646);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 94660, 94673);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10217, 94175, 94684);

                bool
                f_10217_94450_94509(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                implementingMethod, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                @interface)
                {
                    var return_v = IsPossibleImplementationUnderRuntimeRules(implementingMethod, @interface);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 94450, 94509);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10217_94609_94630(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10217, 94609, 94630);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 94175, 94684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 94175, 94684);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override ImmutableArray<NamedTypeSymbol> GetInterfacesToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10217, 94696, 94845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10217, 94799, 94834);

                return f_10217_94806_94833(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10217, 94696, 94845);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10217_94806_94833(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.CalculateInterfacesToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10217, 94806, 94833);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10217, 94696, 94845);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10217, 94696, 94845);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
