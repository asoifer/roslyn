// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

// We use a struct rather than a class to represent the state for efficiency
// for data flow analysis, with 32 bits of data inline. Merely copying the state
// variable causes the first 32 bits to be cloned, as they are inline. This can
// hide a plethora of errors that would only be exhibited in programs with more
// than 32 variables to be tracked. However, few of our tests have that many
// variables.
//
// To help diagnose these problems, we use the preprocessor symbol REFERENCE_STATE
// to cause the data flow state be a class rather than a struct. When it is a class,
// this category of problems would be exhibited in programs with a small number of
// tracked variables. But it is slower, so we only do it in DEBUG mode.
#define REFERENCE_STATE

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class DefiniteAssignmentPass : LocalDataFlowPass<
            DefiniteAssignmentPass.LocalState,
            DefiniteAssignmentPass.LocalFunctionState>
    {
        private readonly PooledDictionary<VariableIdentifier, int> _variableSlot;

        protected readonly ArrayBuilder<VariableIdentifier> variableBySlot;

        private readonly HashSet<Symbol> initiallyAssignedVariables;

        private readonly PooledHashSet<LocalSymbol> _usedVariables;

        private PooledHashSet<ParameterSymbol>? _readParameters;

        private readonly PooledHashSet<LocalFunctionSymbol> _usedLocalFunctions;

        private readonly PooledHashSet<Symbol> _writtenVariables;

        private readonly PooledDictionary<Symbol, Location> _unsafeAddressTakenVariables;

        private readonly PooledHashSet<Symbol> _capturedVariables;

        private readonly PooledHashSet<Symbol> _capturedInside;

        private readonly PooledHashSet<Symbol> _capturedOutside;

        private readonly SourceAssemblySymbol _sourceAssembly;

        private readonly HashSet<PrefixUnaryExpressionSyntax> _unassignedVariableAddressOfSyntaxes;

        private BitVector _alreadyReported;

        private readonly bool _requireOutParamsAssigned;

        private readonly bool _trackClassFields;

        private readonly bool _trackStaticMembers;

        protected MethodSymbol topLevelMethod;

        protected bool _convertInsufficientExecutionStackExceptionToCancelledByStackGuardException;

        private readonly bool _shouldCheckConverted;

        internal DefiniteAssignmentPass(
                    CSharpCompilation compilation,
                    Symbol member,
                    BoundNode node,
                    bool strictAnalysis,
                    bool trackUnassignments = false,
                    HashSet<PrefixUnaryExpressionSyntax> unassignedVariableAddressOfSyntaxes = null,
                    bool requireOutParamsAssigned = true,
                    bool trackClassFields = false,
                    bool trackStaticMembers = false)
        : base(f_10889_7182_7193_C(compilation), member, node, (DynAbs.Tracing.TraceSender.Conditional_F1(10889, 7229, 7243) || ((strictAnalysis && DynAbs.Tracing.TraceSender.Conditional_F2(10889, 7246, 7282)) || DynAbs.Tracing.TraceSender.Conditional_F3(10889, 7285, 7346))) ? f_10889_7246_7282() : f_10889_7285_7346(compilation), trackUnassignments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10889, 6713, 7984);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 1856, 1927);
                this._variableSlot = f_10889_1872_1927(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 2707, 2780);
                this.variableBySlot = f_10889_2724_2780(1, default); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 2974, 3000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 3232, 3289);
                this._usedVariables = f_10889_3249_3289(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 3487, 3502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 3761, 3831);
                this._usedLocalFunctions = f_10889_3783_3831(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 3996, 4051);
                this._writtenVariables = f_10889_4016_4051(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 4419, 4498);
                this._unsafeAddressTakenVariables = f_10889_4450_4498(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 4663, 4719);
                this._capturedVariables = f_10889_4684_4719(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 4771, 4824);
                this._capturedInside = f_10889_4789_4824(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 4874, 4928);
                this._capturedOutside = f_10889_4893_4928(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 5068, 5083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 5292, 5328);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 5775, 5800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 5943, 5960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 6129, 6148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 6281, 6295);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 6323, 6406);
                this._convertInsufficientExecutionStackExceptionToCancelledByStackGuardException = false; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 6679, 6700);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 7412, 7451);

                this.initiallyAssignedVariables = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 7465, 7565);

                _sourceAssembly = (DynAbs.Tracing.TraceSender.Conditional_F1(10889, 7483, 7507) || ((((object)member == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10889, 7510, 7514)) || DynAbs.Tracing.TraceSender.Conditional_F3(10889, 7517, 7564))) ? null : (SourceAssemblySymbol)f_10889_7539_7564(member);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 7579, 7654);

                _unassignedVariableAddressOfSyntaxes = unassignedVariableAddressOfSyntaxes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 7668, 7721);

                _requireOutParamsAssigned = requireOutParamsAssigned;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 7735, 7772);

                _trackClassFields = trackClassFields;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 7786, 7827);

                _trackStaticMembers = trackStaticMembers;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 7841, 7886);

                this.topLevelMethod = member as MethodSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 7900, 7973);

                _shouldCheckConverted = f_10889_7924_7938(this) == typeof(DefiniteAssignmentPass);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10889, 6713, 7984);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 6713, 7984);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 6713, 7984);
            }
        }

        internal DefiniteAssignmentPass(
                    CSharpCompilation compilation,
                    Symbol member,
                    BoundNode node,
                    EmptyStructTypeCache emptyStructs,
                    bool trackUnassignments = false,
                    HashSet<Symbol> initiallyAssignedVariables = null)
        : base(f_10889_8308_8319_C(compilation), member, node, emptyStructs, trackUnassignments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10889, 7996, 8872);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 1856, 1927);
                this._variableSlot = f_10889_1872_1927(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 2707, 2780);
                this.variableBySlot = f_10889_2724_2780(1, default); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 2974, 3000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 3232, 3289);
                this._usedVariables = f_10889_3249_3289(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 3487, 3502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 3761, 3831);
                this._usedLocalFunctions = f_10889_3783_3831(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 3996, 4051);
                this._writtenVariables = f_10889_4016_4051(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 4419, 4498);
                this._unsafeAddressTakenVariables = f_10889_4450_4498(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 4663, 4719);
                this._capturedVariables = f_10889_4684_4719(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 4771, 4824);
                this._capturedInside = f_10889_4789_4824(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 4874, 4928);
                this._capturedOutside = f_10889_4893_4928(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 5068, 5083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 5292, 5328);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 5775, 5800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 5943, 5960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 6129, 6148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 6281, 6295);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 6323, 6406);
                this._convertInsufficientExecutionStackExceptionToCancelledByStackGuardException = false; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 6679, 6700);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 8393, 8454);

                this.initiallyAssignedVariables = initiallyAssignedVariables;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 8468, 8568);

                _sourceAssembly = (DynAbs.Tracing.TraceSender.Conditional_F1(10889, 8486, 8510) || ((((object)member == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10889, 8513, 8517)) || DynAbs.Tracing.TraceSender.Conditional_F3(10889, 8520, 8567))) ? null : (SourceAssemblySymbol)f_10889_8542_8567(member);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 8582, 8610);

                this.CurrentSymbol = member;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 8624, 8668);

                _unassignedVariableAddressOfSyntaxes = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 8682, 8715);

                _requireOutParamsAssigned = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 8729, 8774);

                this.topLevelMethod = member as MethodSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 8788, 8861);

                _shouldCheckConverted = f_10889_8812_8826(this) == typeof(DefiniteAssignmentPass);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10889, 7996, 8872);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 7996, 8872);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 7996, 8872);
            }
        }

        internal DefiniteAssignmentPass(
                    CSharpCompilation compilation,
                    Symbol member,
                    BoundNode node,
                    BoundNode firstInRegion,
                    BoundNode lastInRegion,
                    HashSet<Symbol> initiallyAssignedVariables,
                    HashSet<PrefixUnaryExpressionSyntax> unassignedVariableAddressOfSyntaxes,
                    bool trackUnassignments)
        : base(f_10889_9457_9468_C(compilation), member, node, f_10889_9484_9523(), firstInRegion, lastInRegion, trackRegions: true, trackUnassignments: trackUnassignments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10889, 9046, 9965);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 1856, 1927);
                this._variableSlot = f_10889_1872_1927(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 2707, 2780);
                this.variableBySlot = f_10889_2724_2780(1, default); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 2974, 3000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 3232, 3289);
                this._usedVariables = f_10889_3249_3289(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 3487, 3502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 3761, 3831);
                this._usedLocalFunctions = f_10889_3783_3831(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 3996, 4051);
                this._writtenVariables = f_10889_4016_4051(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 4419, 4498);
                this._unsafeAddressTakenVariables = f_10889_4450_4498(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 4663, 4719);
                this._capturedVariables = f_10889_4684_4719(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 4771, 4824);
                this._capturedInside = f_10889_4789_4824(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 4874, 4928);
                this._capturedOutside = f_10889_4893_4928(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 5068, 5083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 5292, 5328);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 5775, 5800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 5943, 5960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 6129, 6148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 6281, 6295);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 6323, 6406);
                this._convertInsufficientExecutionStackExceptionToCancelledByStackGuardException = false; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 6679, 6700);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 9638, 9699);

                this.initiallyAssignedVariables = initiallyAssignedVariables;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 9713, 9736);

                _sourceAssembly = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 9750, 9778);

                this.CurrentSymbol = member;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 9792, 9867);

                _unassignedVariableAddressOfSyntaxes = unassignedVariableAddressOfSyntaxes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 9881, 9954);

                _shouldCheckConverted = f_10889_9905_9919(this) == typeof(DefiniteAssignmentPass);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10889, 9046, 9965);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 9046, 9965);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 9046, 9965);
            }
        }

        protected override void Free()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 9977, 10447);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 10032, 10054);

                f_10889_10032_10053(variableBySlot);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 10068, 10089);

                f_10889_10068_10088(_variableSlot);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 10103, 10125);

                f_10889_10103_10124(_usedVariables);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 10139, 10163);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_readParameters, 10889, 10139, 10162)?.Free(), 10889, 10155, 10162);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 10177, 10204);

                f_10889_10177_10203(_usedLocalFunctions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 10218, 10243);

                f_10889_10218_10242(_writtenVariables);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 10257, 10283);

                f_10889_10257_10282(_capturedVariables);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 10297, 10320);

                f_10889_10297_10319(_capturedInside);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 10334, 10358);

                f_10889_10334_10357(_capturedOutside);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 10372, 10408);

                f_10889_10372_10407(_unsafeAddressTakenVariables);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 10424, 10436);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Free(), 10889, 10424, 10435);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 9977, 10447);

                int
                f_10889_10032_10053(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 10032, 10053);
                    return 0;
                }


                int
                f_10889_10068_10088(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier, int>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 10068, 10088);
                    return 0;
                }


                int
                f_10889_10103_10124(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 10103, 10124);
                    return 0;
                }


                int
                f_10889_10177_10203(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 10177, 10203);
                    return 0;
                }


                int
                f_10889_10218_10242(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 10218, 10242);
                    return 0;
                }


                int
                f_10889_10257_10282(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 10257, 10282);
                    return 0;
                }


                int
                f_10889_10297_10319(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 10297, 10319);
                    return 0;
                }


                int
                f_10889_10334_10357(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 10334, 10357);
                    return 0;
                }


                int
                f_10889_10372_10407(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.Location>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 10372, 10407);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 9977, 10447);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 9977, 10447);
            }
        }

        protected override bool TryGetVariable(VariableIdentifier identifier, out int slot)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 10459, 10633);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 10567, 10622);

                return f_10889_10574_10621(_variableSlot, identifier, out slot);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 10459, 10633);

                bool
                f_10889_10574_10621(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier, int>
                this_param, Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier
                key, out int
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 10574, 10621);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 10459, 10633);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 10459, 10633);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override int AddVariable(VariableIdentifier identifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 10645, 10899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 10735, 10767);

                int
                slot = f_10889_10746_10766(variableBySlot)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 10781, 10817);

                f_10889_10781_10816(_variableSlot, identifier, slot);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 10831, 10862);

                f_10889_10831_10861(variableBySlot, identifier);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 10876, 10888);

                return slot;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 10645, 10899);

                int
                f_10889_10746_10766(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 10746, 10766);
                    return return_v;
                }


                int
                f_10889_10781_10816(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier, int>
                this_param, Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier
                key, int
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 10781, 10816);
                    return 0;
                }


                int
                f_10889_10831_10861(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier>
                this_param, Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 10831, 10861);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 10645, 10899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 10645, 10899);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected Symbol GetNonMemberSymbol(int slot)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 10911, 11467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 10981, 11034);

                VariableIdentifier
                variableId = f_10889_11013_11033(variableBySlot, slot)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 11048, 11417) || true) && (variableId.ContainingSlot > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 11048, 11417);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 11118, 11329);

                        f_10889_11118_11328(f_10889_11131_11153(variableId.Symbol) == SymbolKind.Field || (DynAbs.Tracing.TraceSender.Expression_False(10889, 11131, 11222) || f_10889_11177_11199(variableId.Symbol) == SymbolKind.Property) || (DynAbs.Tracing.TraceSender.Expression_False(10889, 11131, 11268) || f_10889_11226_11248(variableId.Symbol) == SymbolKind.Event), "inconsistent property symbol owner");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 11347, 11402);

                        variableId = f_10889_11360_11401(variableBySlot, variableId.ContainingSlot);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 11048, 11417);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 11048, 11417);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 11048, 11417);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 11431, 11456);

                return variableId.Symbol;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 10911, 11467);

                Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier
                f_10889_11013_11033(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 11013, 11033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10889_11131_11153(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 11131, 11153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10889_11177_11199(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 11177, 11199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10889_11226_11248(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 11226, 11248);
                    return return_v;
                }


                int
                f_10889_11118_11328(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 11118, 11328);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier
                f_10889_11360_11401(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 11360, 11401);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 10911, 11467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 10911, 11467);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int RootSlot(int slot)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 11479, 11880);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 11534, 11869) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 11534, 11869);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 11579, 11636);

                        int
                        containingSlot = variableBySlot[slot].ContainingSlot
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 11654, 11854) || true) && (containingSlot == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 11654, 11854);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 11719, 11731);

                            return slot;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 11654, 11854);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 11654, 11854);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 11813, 11835);

                            slot = containingSlot;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 11654, 11854);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 11534, 11869);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 11534, 11869);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 11534, 11869);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 11479, 11880);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 11479, 11880);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 11479, 11880);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void VisitRvalue(BoundExpression node, bool isKnownToBeAnLvalue = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 11903, 12351);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 12019, 12282);

                f_10889_12019_12281(node is null || (DynAbs.Tracing.TraceSender.Expression_False(10889, 12050, 12105) || !_shouldCheckConverted) || (DynAbs.Tracing.TraceSender.Expression_False(10889, 12050, 12145) || isKnownToBeAnLvalue) || (DynAbs.Tracing.TraceSender.Expression_False(10889, 12050, 12192) || !f_10889_12167_12192(node)) || (DynAbs.Tracing.TraceSender.Expression_False(10889, 12050, 12238) || f_10889_12213_12238(node)), "expressions should have been converted");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 12296, 12340);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitRvalue(node, isKnownToBeAnLvalue), 10889, 12296, 12339);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 11903, 12351);

                bool
                f_10889_12167_12192(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.NeedsToBeConverted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 12167, 12192);
                    return return_v;
                }


                bool
                f_10889_12213_12238(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 12213, 12238);
                    return return_v;
                }


                int
                f_10889_12019_12281(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 12019, 12281);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 11903, 12351);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 11903, 12351);
            }
        }

        protected override bool ConvertInsufficientExecutionStackExceptionToCancelledByStackGuardException()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 12371, 12590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 12496, 12579);

                return _convertInsufficientExecutionStackExceptionToCancelledByStackGuardException;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 12371, 12590);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 12371, 12590);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 12371, 12590);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ImmutableArray<PendingBranch> Scan(ref bool badRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 12602, 14725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 12700, 12725);

                f_10889_12700_12724(f_10889_12700_12716(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 12739, 12807);

                ImmutableArray<ParameterSymbol>
                methodParameters = f_10889_12790_12806()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 12821, 12879);

                ParameterSymbol
                methodThisParameter = f_10889_12859_12878()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 12893, 12928);

                _alreadyReported = BitVector.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 12992, 13030);

                this.regionPlace = RegionPlace.Before;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 13044, 13078);

                f_10889_13044_13077(this, methodParameters);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 13134, 13492) || true) && ((object)methodThisParameter != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 13134, 13492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 13207, 13243);

                    f_10889_13207_13242(this, methodThisParameter);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 13261, 13477) || true) && (f_10889_13265_13301(f_10889_13265_13289(methodThisParameter)) != SpecialType.None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 13261, 13477);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 13363, 13411);

                        int
                        slot = f_10889_13374_13410(this, methodThisParameter)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 13433, 13458);

                        f_10889_13433_13457(this, slot, true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 13261, 13477);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 13134, 13492);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 13508, 13580);

                // LAFHIS
                //ImmutableArray<PendingBranch> pendingReturns = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Scan(ref badRegion), 10889, 13555, 13579);
                ImmutableArray<PendingBranch> pendingReturns = base.Scan(ref badRegion);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 13555, 13579);

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 13852, 13870);

                Location
                location
                = default(Location);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 13884, 14676) || true) && (f_10889_13888_13928(this, out location))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 13884, 14676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 13962, 14012);

                    f_10889_13962_14011(this, methodParameters, null, location);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 14030, 14123) || true) && ((object)methodThisParameter != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 14030, 14123);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 14071, 14123);

                        f_10889_14071_14122(this, methodThisParameter, null, location);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 14030, 14123);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 14143, 14171);

                    var
                    savedState = this.State
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 14189, 14617);
                        foreach (PendingBranch returnBranch in f_10889_14228_14242_I(pendingReturns))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 14189, 14617);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 14284, 14316);

                            this.State = returnBranch.State;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 14338, 14406);

                            f_10889_14338_14405(this, methodParameters, returnBranch.Branch.Syntax, null);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 14428, 14539) || true) && ((object)methodThisParameter != null)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 14428, 14539);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 14469, 14539);

                                f_10889_14469_14538(this, methodThisParameter, returnBranch.Branch.Syntax, null);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 14428, 14539);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 14561, 14598);

                            f_10889_14561_14597(this, ref savedState, ref this.State);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 14189, 14617);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 429);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 429);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 14637, 14661);

                    this.State = savedState;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 13884, 14676);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 14692, 14714);

                return pendingReturns;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 12602, 14725);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10889_12700_12716(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 12700, 12716);
                    return return_v;
                }


                int
                f_10889_12700_12724(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 12700, 12724);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10889_12790_12806()
                {
                    var return_v = MethodParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 12790, 12806);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10889_12859_12878()
                {
                    var return_v = MethodThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 12859, 12878);
                    return return_v;
                }


                int
                f_10889_13044_13077(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters)
                {
                    this_param.EnterParameters(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 13044, 13077);
                    return 0;
                }


                int
                f_10889_13207_13242(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter)
                {
                    this_param.EnterParameter(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 13207, 13242);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10889_13265_13289(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 13265, 13289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10889_13265_13301(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 13265, 13301);
                    return return_v;
                }


                int
                f_10889_13374_13410(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol)
                {
                    var return_v = this_param.GetOrCreateSlot((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 13374, 13410);
                    return return_v;
                }


                int
                f_10889_13433_13457(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                slot, bool
                assigned)
                {
                    this_param.SetSlotState(slot, assigned);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 13433, 13457);
                    return 0;
                }


                bool
                f_10889_13888_13928(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, out Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = this_param.ShouldAnalyzeOutParameters(out location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 13888, 13928);
                    return return_v;
                }


                int
                f_10889_13962_14011(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.Location
                location)
                {
                    this_param.LeaveParameters(parameters, syntax, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 13962, 14011);
                    return 0;
                }


                int
                f_10889_14071_14122(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.Location
                location)
                {
                    this_param.LeaveParameter(parameter, syntax, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 14071, 14122);
                    return 0;
                }


                int
                f_10889_14338_14405(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.Location
                location)
                {
                    this_param.LeaveParameters(parameters, syntax, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 14338, 14405);
                    return 0;
                }


                int
                f_10889_14469_14538(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.Location
                location)
                {
                    this_param.LeaveParameter(parameter, syntax, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 14469, 14538);
                    return 0;
                }


                bool
                f_10889_14561_14597(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, ref Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                self, ref Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 14561, 14597);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.PendingBranch>
                f_10889_14228_14242_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.PendingBranch>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 14228, 14242);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 12602, 14725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 12602, 14725);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ImmutableArray<PendingBranch> RemoveReturns()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 14737, 15706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 14826, 14860);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.RemoveReturns(), 10889, 14839, 14859)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 14876, 15665) || true) && (CurrentSymbol is MethodSymbol currentMethod && (DynAbs.Tracing.TraceSender.Expression_True(10889, 14880, 14948) && f_10889_14927_14948(currentMethod)) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 14880, 14987) && f_10889_14952_14987_M(!currentMethod.IsImplicitlyDeclared)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 14876, 15665);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 15021, 15079);

                    var
                    foundAwait = result.Any(pending => HasAwait(pending))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 15097, 15650) || true) && (!foundAwait)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 15097, 15650);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 15359, 15539);

                        var
                        diagnosticLocation = (DynAbs.Tracing.TraceSender.Conditional_F1(10889, 15384, 15420) || ((CurrentSymbol is LambdaSymbol lambda
                        && DynAbs.Tracing.TraceSender.Conditional_F2(10889, 15448, 15473)) || DynAbs.Tracing.TraceSender.Conditional_F3(10889, 15501, 15538))) ? f_10889_15448_15473((LambdaSymbol)CurrentSymbol) : CurrentSymbol.Locations.FirstOrNone()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 15563, 15631);

                        f_10889_15563_15630(f_10889_15563_15574(), ErrorCode.WRN_AsyncLacksAwaits, diagnosticLocation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 15097, 15650);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 14876, 15665);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 15681, 15695);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 14737, 15706);

                bool
                f_10889_14927_14948(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 14927, 14948);
                    return return_v;
                }


                bool
                f_10889_14952_14987_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 14952, 14987);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10889_15448_15473(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.DiagnosticLocation
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 15448, 15473);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10889_15563_15574()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 15563, 15574);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10889_15563_15630(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 15563, 15630);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 14737, 15706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 14737, 15706);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HasAwait(PendingBranch pending)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10889, 15718, 16783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 15794, 15829);

                var
                pendingBranch = pending.Branch
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 15843, 15930) || true) && (pendingBranch is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 15843, 15930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 15902, 15915);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 15843, 15930);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 15946, 15982);

                BoundKind
                kind = f_10889_15963_15981(pendingBranch)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 15996, 16772);

                switch (kind)
                {

                    case BoundKind.AwaitExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 15996, 16772);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 16095, 16107);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 15996, 16772);

                    case BoundKind.UsingStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 15996, 16772);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 16177, 16233);

                        var
                        usingStatement = (BoundUsingStatement)pendingBranch
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 16255, 16294);

                        return f_10889_16262_16285(usingStatement) != null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 15996, 16772);

                    case BoundKind.ForEachStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 15996, 16772);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 16366, 16426);

                        var
                        foreachStatement = (BoundForEachStatement)pendingBranch
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 16448, 16489);

                        return f_10889_16455_16480(foreachStatement) != null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 15996, 16772);

                    case BoundKind.UsingLocalDeclarations:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 15996, 16772);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 16567, 16633);

                        var
                        localDeclaration = (BoundUsingLocalDeclarations)pendingBranch
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 16655, 16696);

                        return f_10889_16662_16687(localDeclaration) != null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 15996, 16772);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 15996, 16772);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 16744, 16757);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 15996, 16772);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10889, 15718, 16783);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10889_15963_15981(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 15963, 15981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
                f_10889_16262_16285(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
                this_param)
                {
                    var return_v = this_param.AwaitOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 16262, 16285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
                f_10889_16455_16480(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                this_param)
                {
                    var return_v = this_param.AwaitOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 16455, 16480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
                f_10889_16662_16687(Microsoft.CodeAnalysis.CSharp.BoundUsingLocalDeclarations
                this_param)
                {
                    var return_v = this_param.AwaitOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 16662, 16687);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 15718, 16783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 15718, 16783);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool AwaitUsingAndForeachAddsPendingBranch
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 16986, 16993);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 16989, 16993);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 16986, 16993);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 16986, 16993);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 16986, 16993);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected virtual void ReportUnassignedOutParameter(ParameterSymbol parameter, SyntaxNode node, Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 17006, 19591);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 17145, 17281) || true) && (!_requireOutParamsAssigned && (DynAbs.Tracing.TraceSender.Expression_True(10889, 17149, 17225) && f_10889_17179_17225(topLevelMethod, CurrentSymbol)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 17145, 17281);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 17259, 17266);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 17145, 17281);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 17407, 17454);

                f_10889_17407_17453(node != null || (DynAbs.Tracing.TraceSender.Expression_False(10889, 17420, 17452) || location != null));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 17470, 19580) || true) && (f_10889_17474_17485() != null && (DynAbs.Tracing.TraceSender.Expression_True(10889, 17474, 17517) && f_10889_17497_17517(this.State)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 17470, 19580);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 17551, 17668) || true) && (location == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 17551, 17668);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 17613, 17649);

                        location = f_10889_17624_17648(node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 17551, 17668);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 17688, 17710);

                    bool
                    reported = false
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 17728, 19344) || true) && (f_10889_17732_17748(parameter))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 17728, 19344);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 17938, 17977);

                        int
                        thisSlot = f_10889_17953_17976(this, parameter)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 17999, 18026);

                        f_10889_17999_18025(thisSlot > 0);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 18048, 19325) || true) && (!f_10889_18053_18084(this.State, thisSlot))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 18048, 19325);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 18134, 19260);
                                foreach (var field in f_10889_18156_18217_I(f_10889_18156_18217(_emptyStructTypeCache, f_10889_18202_18216(parameter))))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 18134, 19260);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 18275, 18341) || true) && (f_10889_18279_18330(_emptyStructTypeCache, f_10889_18319_18329(field)))
                                    )
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 18275, 18341);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 18332, 18341);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 18275, 18341);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 18373, 18409) || true) && (f_10889_18377_18398(field))
                                    )
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 18373, 18409);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 18400, 18409);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 18373, 18409);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 18441, 18487);

                                    int
                                    fieldSlot = f_10889_18457_18486(this, field, thisSlot)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 18517, 19233) || true) && (fieldSlot == -1 || (DynAbs.Tracing.TraceSender.Expression_False(10889, 18521, 18573) || !f_10889_18541_18573(this.State, fieldSlot)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 18517, 19233);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 18639, 18697);

                                        Symbol
                                        associatedPropertyOrEvent = f_10889_18674_18696(field)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 18731, 19202) || true) && (f_10889_18735_18766_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(associatedPropertyOrEvent, 10889, 18735, 18766)?.Kind) == SymbolKind.Property)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 18731, 19202);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 18863, 18958);

                                            f_10889_18863_18957(f_10889_18863_18874(), ErrorCode.ERR_UnassignedThisAutoProperty, location, associatedPropertyOrEvent);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 18731, 19202);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 18731, 19202);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 19104, 19167);

                                            f_10889_19104_19166(f_10889_19104_19115(), ErrorCode.ERR_UnassignedThis, location, field);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 18731, 19202);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 18517, 19233);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 18134, 19260);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 1127);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 1127);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 19286, 19302);

                            reported = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 18048, 19325);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 17728, 19344);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 19364, 19565) || true) && (!reported)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 19364, 19565);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 19419, 19451);

                        f_10889_19419_19450(f_10889_19432_19449_M(!parameter.IsThis));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 19473, 19546);

                        f_10889_19473_19545(f_10889_19473_19484(), ErrorCode.ERR_ParamUnassigned, location, f_10889_19530_19544(parameter));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 19364, 19565);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 17470, 19580);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 17006, 19591);

                bool
                f_10889_17179_17225(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 17179, 17225);
                    return return_v;
                }


                int
                f_10889_17407_17453(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 17407, 17453);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10889_17474_17485()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 17474, 17485);
                    return return_v;
                }


                bool
                f_10889_17497_17517(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param)
                {
                    var return_v = this_param.Reachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 17497, 17517);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10889_17624_17648(Microsoft.CodeAnalysis.SyntaxNode?
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 17624, 17648);
                    return return_v;
                }


                bool
                f_10889_17732_17748(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsThis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 17732, 17748);
                    return return_v;
                }


                int
                f_10889_17953_17976(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol)
                {
                    var return_v = this_param.VariableSlot((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 17953, 17976);
                    return return_v;
                }


                int
                f_10889_17999_18025(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 17999, 18025);
                    return 0;
                }


                bool
                f_10889_18053_18084(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param, int
                slot)
                {
                    var return_v = this_param.IsAssigned(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 18053, 18084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10889_18202_18216(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 18202, 18216);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10889_18156_18217(Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.GetStructInstanceFields(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 18156, 18217);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10889_18319_18329(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 18319, 18329);
                    return return_v;
                }


                bool
                f_10889_18279_18330(Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.IsEmptyStructType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 18279, 18330);
                    return return_v;
                }


                bool
                f_10889_18377_18398(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                field)
                {
                    var return_v = HasInitializer((Microsoft.CodeAnalysis.CSharp.Symbol)field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 18377, 18398);
                    return return_v;
                }


                int
                f_10889_18457_18486(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, int
                containingSlot)
                {
                    var return_v = this_param.VariableSlot((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, containingSlot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 18457, 18486);
                    return return_v;
                }


                bool
                f_10889_18541_18573(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param, int
                slot)
                {
                    var return_v = this_param.IsAssigned(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 18541, 18573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10889_18674_18696(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 18674, 18696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind?
                f_10889_18735_18766_M(Microsoft.CodeAnalysis.SymbolKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 18735, 18766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10889_18863_18874()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 18863, 18874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10889_18863_18957(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 18863, 18957);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10889_19104_19115()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 19104, 19115);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10889_19104_19166(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 19104, 19166);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10889_18156_18217_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 18156, 18217);
                    return return_v;
                }


                bool
                f_10889_19432_19449_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 19432, 19449);
                    return return_v;
                }


                int
                f_10889_19419_19450(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 19419, 19450);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10889_19473_19484()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 19473, 19484);
                    return return_v;
                }


                string
                f_10889_19530_19544(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 19530, 19544);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10889_19473_19545(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 19473, 19545);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 17006, 19591);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 17006, 19591);
            }
        }

        public static void Analyze(
                    CSharpCompilation compilation,
                    MethodSymbol member,
                    BoundNode node,
                    DiagnosticBag diagnostics,
                    bool requireOutParamsAssigned = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10889, 19728, 25265);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 19978, 20012);

                f_10889_19978_20011(diagnostics != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 20082, 20146);

                DiagnosticBag
                strictDiagnostics = f_10889_20116_20145(strictAnalysis: true)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 20160, 20392) || true) && (f_10889_20164_20206(strictDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 20160, 20392);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 20327, 20352);

                    f_10889_20327_20351(                // If it reports nothing, there is nothing to report and we are done.
                                    strictDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 20370, 20377);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 20160, 20392);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 20621, 20686);

                DiagnosticBag
                compatDiagnostics = f_10889_20655_20685(strictAnalysis: false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 20908, 21171) || true) && (f_10889_20912_21007(f_10889_20912_20944(compatDiagnostics), d => (ErrorCode)d.Code == ErrorCode.ERR_InsufficientStack))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 20908, 21171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 21041, 21088);

                    f_10889_21041_21087(diagnostics, compatDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 21106, 21131);

                    f_10889_21106_21130(strictDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 21149, 21156);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 20908, 21171);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 21515, 21733) || true) && (f_10889_21519_21542(strictDiagnostics) == f_10889_21546_21569(compatDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 21515, 21733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 21603, 21650);

                    f_10889_21603_21649(diagnostics, strictDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 21668, 21693);

                    f_10889_21668_21692(compatDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 21711, 21718);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 21515, 21733);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 21749, 21882);

                HashSet<Diagnostic>
                compatDiagnosticSet = f_10889_21791_21881(f_10889_21815_21847(compatDiagnostics), SameDiagnosticComparer.Instance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 21896, 21921);

                f_10889_21896_21920(compatDiagnostics);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 21935, 24121);
                    foreach (var diagnostic in f_10889_21962_21994_I(f_10889_21962_21994(strictDiagnostics)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 21935, 24121);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 22175, 22390) || true) && (f_10889_22179_22198(diagnostic) != DiagnosticSeverity.Error || (DynAbs.Tracing.TraceSender.Expression_False(10889, 22179, 22270) || f_10889_22230_22270(compatDiagnosticSet, diagnostic)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 22175, 22390);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 22312, 22340);

                            f_10889_22312_22339(diagnostics, diagnostic);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 22362, 22371);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 22175, 22390);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 22474, 22521);

                        ErrorCode
                        oldCode = (ErrorCode)f_10889_22505_22520(diagnostic)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 22539, 23626);

                        ErrorCode
                        newCode = oldCode switch
                        {
#pragma warning disable format
                    ErrorCode.ERR_UnassignedThisAutoProperty when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889,22646,22730) && DynAbs.Tracing.TraceSender.Expression_True(10889,22646,22730))
=> ErrorCode.WRN_UnassignedThisAutoProperty,
                    ErrorCode.ERR_UnassignedThis             when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889,22753,22825) && DynAbs.Tracing.TraceSender.Expression_True(10889,22753,22825))
=> ErrorCode.WRN_UnassignedThis,
                    ErrorCode.ERR_ParamUnassigned            when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889,22848,22921) && DynAbs.Tracing.TraceSender.Expression_True(10889,22848,22921))
=> ErrorCode.WRN_ParamUnassigned,
                    ErrorCode.ERR_UseDefViolationProperty    when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889,22944,23025) && DynAbs.Tracing.TraceSender.Expression_True(10889,22944,23025))
=> ErrorCode.WRN_UseDefViolationProperty,
                    ErrorCode.ERR_UseDefViolationField       when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889,23048,23126) && DynAbs.Tracing.TraceSender.Expression_True(10889,23048,23126))
=> ErrorCode.WRN_UseDefViolationField,
                    ErrorCode.ERR_UseDefViolationThis        when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889,23149,23226) && DynAbs.Tracing.TraceSender.Expression_True(10889,23149,23226))
=> ErrorCode.WRN_UseDefViolationThis,
                    ErrorCode.ERR_UseDefViolationOut         when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889,23249,23325) && DynAbs.Tracing.TraceSender.Expression_True(10889,23249,23325))
=> ErrorCode.WRN_UseDefViolationOut,
                    ErrorCode.ERR_UseDefViolation            when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889,23348,23421) && DynAbs.Tracing.TraceSender.Expression_True(10889,23348,23421))
=> ErrorCode.WRN_UseDefViolation,
                    _ when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889,23444,23456) && DynAbs.Tracing.TraceSender.Expression_True(10889,23444,23456))
=> oldCode, // rare but possible, e.g. ErrorCode.ERR_InsufficientStack occurring in strict mode only due to needing extra frames
#pragma warning restore format
                }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 23763, 23862);

                        f_10889_23763_23861(newCode != oldCode || (DynAbs.Tracing.TraceSender.Expression_False(10889, 23776, 23840) || oldCode == ErrorCode.ERR_InsufficientStack), f_10889_23842_23860(oldCode));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 23909, 24036);

                        var
                        args = (DynAbs.Tracing.TraceSender.Conditional_F1(10889, 23920, 23952) || ((diagnostic is DiagnosticWithInfo && DynAbs.Tracing.TraceSender.Conditional_F2(10889, 23955, 24002)) || DynAbs.Tracing.TraceSender.Conditional_F3(10889, 24005, 24035))) ? f_10889_23955_24002(f_10889_23955_23992(((DiagnosticWithInfo)diagnostic))) : f_10889_24005_24035(f_10889_24005_24025(diagnostic))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 24054, 24106);

                        f_10889_24054_24105(diagnostics, newCode, f_10889_24079_24098(diagnostic), args);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 21935, 24121);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 2187);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 2187);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 24137, 24162);

                f_10889_24137_24161(
                            strictDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 24176, 24183);

                return;

                DiagnosticBag analyze(bool strictAnalysis)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 24199, 25254);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 24274, 24325);

                        DiagnosticBag
                        result = f_10889_24297_24324()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 24343, 24600);

                        var
                        walker = f_10889_24356_24599(compilation, member, node, strictAnalysis: strictAnalysis, requireOutParamsAssigned: requireOutParamsAssigned)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 24618, 24708);

                        walker._convertInsufficientExecutionStackExceptionToCancelledByStackGuardException = true;

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 24772, 24795);

                            bool
                            badRegion = false
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 24817, 24855);

                            f_10889_24817_24854(walker, ref badRegion, result);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 24877, 24902);

                            f_10889_24877_24901(!badRegion);
                        }
                        catch (BoundTreeVisitor.CancelledByStackGuardException ex) when (diagnostics != null)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(10889, 24939, 25106);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 25065, 25087);

                            f_10889_25065_25086(ex, result);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(10889, 24939, 25106);
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(10889, 25124, 25205);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 25172, 25186);

                            f_10889_25172_25185(walker);
                            DynAbs.Tracing.TraceSender.TraceExitFinally(10889, 25124, 25205);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 25225, 25239);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 24199, 25254);

                        Microsoft.CodeAnalysis.DiagnosticBag
                        f_10889_24297_24324()
                        {
                            var return_v = DiagnosticBag.GetInstance();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 24297, 24324);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                        f_10889_24356_24599(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        member, Microsoft.CodeAnalysis.CSharp.BoundNode
                        node, bool
                        strictAnalysis, bool
                        requireOutParamsAssigned)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass(compilation, (Microsoft.CodeAnalysis.CSharp.Symbol)member, node, strictAnalysis: strictAnalysis, requireOutParamsAssigned: requireOutParamsAssigned);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 24356, 24599);
                            return return_v;
                        }


                        int
                        f_10889_24817_24854(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                        this_param, ref bool
                        badRegion, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            this_param.Analyze(ref badRegion, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 24817, 24854);
                            return 0;
                        }


                        int
                        f_10889_24877_24901(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 24877, 24901);
                            return 0;
                        }


                        int
                        f_10889_25065_25086(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor.CancelledByStackGuardException
                        this_param, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            this_param.AddAnError(diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 25065, 25086);
                            return 0;
                        }


                        int
                        f_10889_25172_25185(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 25172, 25185);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 24199, 25254);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 24199, 25254);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10889, 19728, 25265);

                int
                f_10889_19978_20011(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 19978, 20011);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10889_20116_20145(bool
                strictAnalysis)
                {
                    var return_v = analyze(strictAnalysis: strictAnalysis);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 20116, 20145);
                    return return_v;
                }


                bool
                f_10889_20164_20206(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.IsEmptyWithoutResolution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 20164, 20206);
                    return return_v;
                }


                int
                f_10889_20327_20351(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 20327, 20351);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10889_20655_20685(bool
                strictAnalysis)
                {
                    var return_v = analyze(strictAnalysis: strictAnalysis);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 20655, 20685);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_10889_20912_20944(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.AsEnumerable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 20912, 20944);
                    return return_v;
                }


                bool
                f_10889_20912_21007(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                source, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                predicate)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.Diagnostic>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 20912, 21007);
                    return return_v;
                }


                int
                f_10889_21041_21087(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRangeAndFree(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 21041, 21087);
                    return 0;
                }


                int
                f_10889_21106_21130(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 21106, 21130);
                    return 0;
                }


                int
                f_10889_21519_21542(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 21519, 21542);
                    return return_v;
                }


                int
                f_10889_21546_21569(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 21546, 21569);
                    return return_v;
                }


                int
                f_10889_21603_21649(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRangeAndFree(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 21603, 21649);
                    return 0;
                }


                int
                f_10889_21668_21692(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 21668, 21692);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_10889_21815_21847(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.AsEnumerable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 21815, 21847);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostic>
                f_10889_21791_21881(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                collection, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.SameDiagnosticComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostic>(collection, (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.Diagnostic>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 21791, 21881);
                    return return_v;
                }


                int
                f_10889_21896_21920(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 21896, 21920);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_10889_21962_21994(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.AsEnumerable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 21962, 21994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10889_22179_22198(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 22179, 22198);
                    return return_v;
                }


                bool
                f_10889_22230_22270(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 22230, 22270);
                    return return_v;
                }


                int
                f_10889_22312_22339(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 22312, 22339);
                    return 0;
                }


                int
                f_10889_22505_22520(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 22505, 22520);
                    return return_v;
                }


                string
                f_10889_23842_23860(Microsoft.CodeAnalysis.CSharp.ErrorCode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 23842, 23860);
                    return return_v;
                }


                int
                f_10889_23763_23861(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 23763, 23861);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10889_23955_23992(Microsoft.CodeAnalysis.DiagnosticWithInfo
                this_param)
                {
                    var return_v = this_param.Info;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 23955, 23992);
                    return return_v;
                }


                object[]
                f_10889_23955_24002(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 23955, 24002);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<object?>
                f_10889_24005_24025(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 24005, 24025);
                    return return_v;
                }


                object?[]
                f_10889_24005_24035(System.Collections.Generic.IReadOnlyList<object?>
                source)
                {
                    var return_v = source.ToArray<object?>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 24005, 24035);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10889_24079_24098(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 24079, 24098);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10889_24054_24105(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object?[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 24054, 24105);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_10889_21962_21994_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 21962, 21994);
                    return return_v;
                }


                int
                f_10889_24137_24161(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 24137, 24161);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 19728, 25265);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 19728, 25265);
            }
        }
        private sealed class SameDiagnosticComparer : EqualityComparer<Diagnostic>
        {
            public static readonly SameDiagnosticComparer Instance;

            public override bool Equals(Diagnostic x, Diagnostic y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 25532, 25546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 25535, 25546);
                    return f_10889_25535_25546(x, y); DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 25532, 25546);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 25532, 25546);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 25532, 25546);
                }
                throw new System.Exception("Slicer error: unreachable code");

                bool
                f_10889_25535_25546(Microsoft.CodeAnalysis.Diagnostic
                this_param, Microsoft.CodeAnalysis.Diagnostic
                obj)
                {
                    var return_v = this_param.Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 25535, 25546);
                    return return_v;
                }

            }

            public override int GetHashCode(Diagnostic obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 25609, 25728);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 25629, 25728);
                    return f_10889_25629_25728(f_10889_25642_25675(f_10889_25661_25674(obj)), f_10889_25677_25727(f_10889_25690_25716(f_10889_25690_25702(obj)), f_10889_25718_25726(obj))); DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 25609, 25728);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 25609, 25728);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 25609, 25728);
                }
                throw new System.Exception("Slicer error: unreachable code");

                System.Collections.Generic.IReadOnlyList<object?>
                f_10889_25661_25674(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 25661, 25674);
                    return return_v;
                }


                int
                f_10889_25642_25675(System.Collections.Generic.IReadOnlyList<object?>
                values)
                {
                    var return_v = Hash.CombineValues((System.Collections.Generic.IEnumerable<object>)values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 25642, 25675);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10889_25690_25702(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 25690, 25702);
                    return return_v;
                }


                int
                f_10889_25690_25716(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 25690, 25716);
                    return return_v;
                }


                int
                f_10889_25718_25726(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 25718, 25726);
                    return return_v;
                }


                int
                f_10889_25677_25727(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 25677, 25727);
                    return return_v;
                }


                int
                f_10889_25629_25728(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 25629, 25728);
                    return return_v;
                }

            }

            public SameDiagnosticComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10889, 25277, 25740);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10889, 25277, 25740);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 25277, 25740);
            }


            static SameDiagnosticComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10889, 25277, 25740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 25422, 25461);
                Instance = f_10889_25433_25461(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10889, 25277, 25740);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 25277, 25740);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10889, 25277, 25740);

            static Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.SameDiagnosticComparer
            f_10889_25433_25461()
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.SameDiagnosticComparer();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 25433, 25461);
                return return_v;
            }

        }

        protected void Analyze(ref bool badRegion, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 25867, 27205);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 25961, 26024);

                ImmutableArray<PendingBranch>
                returns = f_10889_26001_26023(this, ref badRegion)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 26038, 27194) || true) && (diagnostics != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 26038, 27194);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 26095, 26626);
                        foreach (Symbol captured in f_10889_26123_26141_I(_capturedVariables))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 26095, 26626);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 26183, 26201);

                            Location
                            location
                            = default(Location);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 26223, 26607) || true) && (f_10889_26227_26291(_unsafeAddressTakenVariables, captured, out location))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 26223, 26607);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 26341, 26475);

                                f_10889_26341_26474(f_10889_26354_26367(captured) == SymbolKind.Parameter || (DynAbs.Tracing.TraceSender.Expression_False(10889, 26354, 26428) || f_10889_26395_26408(captured) == SymbolKind.Local) || (DynAbs.Tracing.TraceSender.Expression_False(10889, 26354, 26473) || f_10889_26432_26445(captured) == SymbolKind.RangeVariable));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 26501, 26584);

                                f_10889_26501_26583(diagnostics, ErrorCode.ERR_LocalCantBeFixedAndHoisted, location, f_10889_26569_26582(captured));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 26223, 26607);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 26095, 26626);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 532);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 532);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 26646, 26685);

                    f_10889_26646_26684(
                                    diagnostics, f_10889_26667_26683(this));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 26705, 27179) || true) && (CurrentSymbol is SynthesizedRecordConstructor)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 26705, 27179);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 26796, 27160);
                            foreach (ParameterSymbol parameter in f_10889_26834_26850_I(f_10889_26834_26850()))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 26796, 27160);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 26900, 27137) || true) && (f_10889_26904_26940_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_readParameters, 10889, 26904, 26940)?.Contains(parameter)) != true)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 26900, 27137);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 27006, 27110);

                                    f_10889_27006_27109(diagnostics, ErrorCode.WRN_UnreadRecordParameter, parameter.Locations.FirstOrNone(), f_10889_27094_27108(parameter));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 26900, 27137);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 26796, 27160);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 365);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 365);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 26705, 27179);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 26038, 27194);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 25867, 27205);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.PendingBranch>
                f_10889_26001_26023(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, ref bool
                badRegion)
                {
                    var return_v = this_param.Analyze(ref badRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 26001, 26023);
                    return return_v;
                }


                bool
                f_10889_26227_26291(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.Location>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                key, out Microsoft.CodeAnalysis.Location
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 26227, 26291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10889_26354_26367(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 26354, 26367);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10889_26395_26408(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 26395, 26408);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10889_26432_26445(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 26432, 26445);
                    return return_v;
                }


                int
                f_10889_26341_26474(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 26341, 26474);
                    return 0;
                }


                string
                f_10889_26569_26582(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 26569, 26582);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10889_26501_26583(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 26501, 26583);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10889_26123_26141_I(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 26123, 26141);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10889_26667_26683(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 26667, 26683);
                    return return_v;
                }


                int
                f_10889_26646_26684(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 26646, 26684);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10889_26834_26850()
                {
                    var return_v = MethodParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 26834, 26850);
                    return return_v;
                }


                bool?
                f_10889_26904_26940_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 26904, 26940);
                    return return_v;
                }


                string
                f_10889_27094_27108(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 27094, 27108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10889_27006_27109(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 27006, 27109);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10889_26834_26850_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 26834, 26850);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 25867, 27205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 25867, 27205);
            }
        }

        private void CheckCaptured(Symbol variable, ParameterSymbol rangeVariableUnderlyingParameter = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 27576, 27934);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 27701, 27923) || true) && (CurrentSymbol is SourceMethodSymbol sourceMethod && (DynAbs.Tracing.TraceSender.Expression_True(10889, 27705, 27851) && f_10889_27774_27851(rangeVariableUnderlyingParameter ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol?>(10889, 27792, 27836) ?? variable), sourceMethod)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 27701, 27923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 27885, 27908);

                    f_10889_27885_27907(this, variable);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 27701, 27923);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 27576, 27934);

                bool
                f_10889_27774_27851(Microsoft.CodeAnalysis.CSharp.Symbol
                variable, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbol
                containingSymbol)
                {
                    var return_v = Symbol.IsCaptured(variable, containingSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 27774, 27851);
                    return return_v;
                }


                int
                f_10889_27885_27907(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                variable)
                {
                    this_param.NoteCaptured(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 27885, 27907);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 27576, 27934);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 27576, 27934);
            }
        }

        private void NoteCaptured(Symbol variable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 28146, 28591);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 28213, 28580) || true) && (this.regionPlace == RegionPlace.Inside)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 28213, 28580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 28289, 28319);

                    f_10889_28289_28318(_capturedInside, variable);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 28337, 28370);

                    f_10889_28337_28369(_capturedVariables, variable);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 28213, 28580);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 28213, 28580);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 28404, 28580) || true) && (f_10889_28408_28421(variable) != SymbolKind.RangeVariable)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 28404, 28580);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 28483, 28514);

                        f_10889_28483_28513(_capturedOutside, variable);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 28532, 28565);

                        f_10889_28532_28564(_capturedVariables, variable);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 28404, 28580);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 28213, 28580);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 28146, 28591);

                bool
                f_10889_28289_28318(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 28289, 28318);
                    return return_v;
                }


                bool
                f_10889_28337_28369(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 28337, 28369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10889_28408_28421(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 28408, 28421);
                    return return_v;
                }


                bool
                f_10889_28483_28513(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 28483, 28513);
                    return return_v;
                }


                bool
                f_10889_28532_28564(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 28532, 28564);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 28146, 28591);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 28146, 28591);
            }
        }

        protected IEnumerable<Symbol> GetCapturedInside()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 28718, 28746);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 28721, 28746);
                return f_10889_28721_28746(_capturedInside); DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 28718, 28746);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 28718, 28746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 28718, 28746);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbol[]
            f_10889_28721_28746(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
            source)
            {
                var return_v = source.ToArray<Microsoft.CodeAnalysis.CSharp.Symbol>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 28721, 28746);
                return return_v;
            }

        }

        protected IEnumerable<Symbol> GetCapturedOutside()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 28808, 28837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 28811, 28837);
                return f_10889_28811_28837(_capturedOutside); DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 28808, 28837);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 28808, 28837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 28808, 28837);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbol[]
            f_10889_28811_28837(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
            source)
            {
                var return_v = source.ToArray<Microsoft.CodeAnalysis.CSharp.Symbol>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 28811, 28837);
                return return_v;
            }

        }

        protected IEnumerable<Symbol> GetCaptured()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 28892, 28923);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 28895, 28923);
                return f_10889_28895_28923(_capturedVariables); DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 28892, 28923);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 28892, 28923);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 28892, 28923);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbol[]
            f_10889_28895_28923(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
            source)
            {
                var return_v = source.ToArray<Microsoft.CodeAnalysis.CSharp.Symbol>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 28895, 28923);
                return return_v;
            }

        }

        protected IEnumerable<Symbol> GetUnsafeAddressTaken()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 28988, 29034);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 28991, 29034);
                return f_10889_28991_29034(f_10889_28991_29024(_unsafeAddressTakenVariables)); DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 28988, 29034);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 28988, 29034);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 28988, 29034);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.Location>.KeyCollection
            f_10889_28991_29024(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.Location>
            this_param)
            {
                var return_v = this_param.Keys;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 28991, 29024);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbol[]
            f_10889_28991_29034(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.Location>.KeyCollection
            source)
            {
                var return_v = source.ToArray<Microsoft.CodeAnalysis.CSharp.Symbol>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 28991, 29034);
                return return_v;
            }

        }

        protected IEnumerable<MethodSymbol> GetUsedLocalFunctions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 29105, 29137);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 29108, 29137);
                return f_10889_29108_29137(_usedLocalFunctions); DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 29105, 29137);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 29105, 29137);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 29105, 29137);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol[]
            f_10889_29108_29137(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
            source)
            {
                var return_v = source.ToArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 29108, 29137);
                return return_v;
            }

        }

        private void NoteRecordParameterReadIfNeeded(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 29217, 29565);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 29301, 29554) || true) && (symbol is ParameterSymbol { ContainingSymbol: SynthesizedRecordConstructor } parameter)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 29301, 29554);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 29425, 29490);

                    if (_readParameters is null)
                        DynAbs.Tracing.TraceSender.TraceEnterExpression(10889, 29425, 29490);

                    _readParameters ??= f_10889_29445_29489();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 29508, 29539);

                    f_10889_29508_29538(_readParameters, parameter);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 29301, 29554);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 29217, 29565);

                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10889_29445_29489()
                {
                    var return_v = PooledHashSet<ParameterSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 29445, 29489);
                    return return_v;
                }


                bool
                f_10889_29508_29538(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 29508, 29538);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 29217, 29565);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 29217, 29565);
            }
        }

        protected virtual void NoteRead(
                    Symbol variable,
                    ParameterSymbol rangeVariableUnderlyingParameter = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 29575, 30664);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 29732, 29768);

                var
                local = variable as LocalSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 29782, 29882) || true) && ((object)local != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 29782, 29882);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 29841, 29867);

                    f_10889_29841_29866(_usedVariables, local);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 29782, 29882);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 29898, 29940);

                f_10889_29898_29939(this, variable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 29956, 30008);

                var
                localFunction = variable as LocalFunctionSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 30022, 30143) || true) && ((object)localFunction != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 30022, 30143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 30089, 30128);

                    f_10889_30089_30127(_usedLocalFunctions, localFunction);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 30022, 30143);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 30159, 30653) || true) && ((object)variable != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 30159, 30653);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 30221, 30560) || true) && ((object)_sourceAssembly != null && (DynAbs.Tracing.TraceSender.Expression_True(10889, 30225, 30293) && f_10889_30260_30273(variable) == SymbolKind.Field))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 30221, 30560);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 30335, 30541);

                        f_10889_30335_30540(_sourceAssembly, f_10889_30380_30407(variable), read: true, write: false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 30221, 30560);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 30580, 30638);

                    f_10889_30580_30637(this, variable, rangeVariableUnderlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 30159, 30653);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 29575, 30664);

                bool
                f_10889_29841_29866(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 29841, 29866);
                    return return_v;
                }


                int
                f_10889_29898_29939(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    this_param.NoteRecordParameterReadIfNeeded(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 29898, 29939);
                    return 0;
                }


                bool
                f_10889_30089_30127(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 30089, 30127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10889_30260_30273(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 30260, 30273);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10889_30380_30407(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 30380, 30407);
                    return return_v;
                }


                int
                f_10889_30335_30540(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                field, bool
                read, bool
                write)
                {
                    this_param.NoteFieldAccess((Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)field, read: read, write: write);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 30335, 30540);
                    return 0;
                }


                int
                f_10889_30580_30637(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                variable, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol?
                rangeVariableUnderlyingParameter)
                {
                    this_param.CheckCaptured(variable, rangeVariableUnderlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 30580, 30637);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 29575, 30664);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 29575, 30664);
            }
        }

        private void NoteRead(BoundNode fieldOrEventAccess)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 30676, 32986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 30752, 30867);

                f_10889_30752_30866(f_10889_30765_30788(fieldOrEventAccess) == BoundKind.FieldAccess || (DynAbs.Tracing.TraceSender.Expression_False(10889, 30765, 30865) || f_10889_30817_30840(fieldOrEventAccess) == BoundKind.EventAccess));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 30881, 30914);

                BoundNode
                n = fieldOrEventAccess
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 30928, 32975) || true) && (n != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 30928, 32975);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 30978, 32960);

                        switch (f_10889_30986_30992(n))
                        {

                            case BoundKind.FieldAccess:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 30978, 32960);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 31118, 31156);

                                    var
                                    fieldAccess = (BoundFieldAccess)n
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 31186, 31220);

                                    f_10889_31186_31219(this, f_10889_31195_31218(fieldAccess));

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 31252, 31629) || true) && (f_10889_31256_31324(this, f_10889_31275_31298(fieldAccess), f_10889_31300_31323(fieldAccess)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 31252, 31629);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 31390, 31418);

                                        n = f_10889_31394_31417(fieldAccess);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 31452, 31461);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 31252, 31629);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 31252, 31629);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 31591, 31598);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 31252, 31629);
                                    }
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 30978, 32960);

                            case BoundKind.EventAccess:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 30978, 32960);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 31764, 31802);

                                    var
                                    eventAccess = (BoundEventAccess)n
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 31832, 31902);

                                    FieldSymbol
                                    associatedField = f_10889_31862_31901(f_10889_31862_31885(eventAccess))
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 31932, 32374) || true) && ((object)associatedField != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 31932, 32374);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 32033, 32059);

                                        f_10889_32033_32058(this, associatedField);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 32095, 32343) || true) && (f_10889_32099_32159(this, f_10889_32118_32141(eventAccess), associatedField))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 32095, 32343);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 32233, 32261);

                                            n = f_10889_32237_32260(eventAccess);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 32299, 32308);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 32095, 32343);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 31932, 32374);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 32404, 32411);

                                    return;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 30978, 32960);

                            case BoundKind.ThisReference:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 30978, 32960);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 32517, 32547);

                                f_10889_32517_32546(this, f_10889_32526_32545());
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 32573, 32580);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 30978, 32960);

                            case BoundKind.Local:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 30978, 32960);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 32651, 32689);

                                f_10889_32651_32688(this, f_10889_32660_32687(((BoundLocal)n)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 32715, 32722);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 30978, 32960);

                            case BoundKind.Parameter:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 30978, 32960);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 32797, 32843);

                                f_10889_32797_32842(this, f_10889_32806_32841(((BoundParameter)n)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 32869, 32876);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 30978, 32960);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 30978, 32960);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 32934, 32941);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 30978, 32960);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 30928, 32975);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 30928, 32975);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 30928, 32975);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 30676, 32986);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10889_30765_30788(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 30765, 30788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10889_30817_30840(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 30817, 30840);
                    return return_v;
                }


                int
                f_10889_30752_30866(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 30752, 30866);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10889_30986_30992(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 30986, 30992);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10889_31195_31218(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 31195, 31218);
                    return return_v;
                }


                int
                f_10889_31186_31219(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                variable)
                {
                    this_param.NoteRead((Microsoft.CodeAnalysis.CSharp.Symbol)variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 31186, 31219);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10889_31275_31298(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 31275, 31298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10889_31300_31323(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 31300, 31323);
                    return return_v;
                }


                bool
                f_10889_31256_31324(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol)
                {
                    var return_v = this_param.MayRequireTracking(receiverOpt, fieldSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 31256, 31324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10889_31394_31417(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 31394, 31417);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10889_31862_31885(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.EventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 31862, 31885);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                f_10889_31862_31901(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 31862, 31901);
                    return return_v;
                }


                int
                f_10889_32033_32058(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                variable)
                {
                    this_param.NoteRead((Microsoft.CodeAnalysis.CSharp.Symbol)variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 32033, 32058);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10889_32118_32141(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 32118, 32141);
                    return return_v;
                }


                bool
                f_10889_32099_32159(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol)
                {
                    var return_v = this_param.MayRequireTracking(receiverOpt, fieldSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 32099, 32159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10889_32237_32260(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 32237, 32260);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10889_32526_32545()
                {
                    var return_v = MethodThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 32526, 32545);
                    return return_v;
                }


                int
                f_10889_32517_32546(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                variable)
                {
                    this_param.NoteRead((Microsoft.CodeAnalysis.CSharp.Symbol)variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 32517, 32546);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10889_32660_32687(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 32660, 32687);
                    return return_v;
                }


                int
                f_10889_32651_32688(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                variable)
                {
                    this_param.NoteRead((Microsoft.CodeAnalysis.CSharp.Symbol)variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 32651, 32688);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10889_32806_32841(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 32806, 32841);
                    return return_v;
                }


                int
                f_10889_32797_32842(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                variable)
                {
                    this_param.NoteRead((Microsoft.CodeAnalysis.CSharp.Symbol)variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 32797, 32842);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 30676, 32986);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 30676, 32986);
            }
        }

        protected virtual void NoteWrite(Symbol variable, BoundExpression value, bool read)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 32998, 35541);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 33106, 35530) || true) && ((object)variable != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 33106, 35530);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 33168, 33200);

                    f_10889_33168_33199(_writtenVariables, variable);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 33218, 33531) || true) && ((object)_sourceAssembly != null && (DynAbs.Tracing.TraceSender.Expression_True(10889, 33222, 33290) && f_10889_33257_33270(variable) == SymbolKind.Field))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 33218, 33531);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 33332, 33385);

                        var
                        field = (FieldSymbol)f_10889_33357_33384(variable)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 33407, 33512);

                        f_10889_33407_33511(_sourceAssembly, field, read: read && (DynAbs.Tracing.TraceSender.Expression_True(10889, 33452, 33497) && f_10889_33460_33497(f_10889_33479_33489(field), value)), write: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 33218, 33531);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 33551, 33587);

                    var
                    local = variable as LocalSymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 33605, 35471) || true) && ((object)local != null && (DynAbs.Tracing.TraceSender.Expression_True(10889, 33609, 33638) && read) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 33609, 33679) && f_10889_33642_33679(f_10889_33661_33671(local), value)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 33605, 35471);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 35426, 35452);

                        f_10889_35426_35451(                    // A local variable that is written to is considered to also be read,
                                                                // unless the written value is always a constant. The reasons for this
                                                                // unusual behavior are:
                                                                //
                                                                // * The debugger does not make it easy to see the returned value of
                                                                //   a method. Often a call whose returned value would normally be
                                                                //   discarded is written into a local variable so that it can be
                                                                //   easily inspected in the debugger.
                                                                //
                                                                // * An otherwise unread local variable that contains a reference to an
                                                                //   object can keep the object alive longer, particularly if the jitter
                                                                //   is not optimizing the lifetimes of locals. (Because, for example,
                                                                //   the debugger is running.) Again, this can be useful when debugging
                                                                //   because an otherwise unused object might be finalized later, allowing
                                                                //   the developer to more easily examine its state.
                                                                //
                                                                // * A developer who wishes to deliberately discard a value returned by
                                                                //   a method can do so in a self-documenting manner via
                                                                //   "var unread = M();"
                                                                //
                                                                // We suppress the "written but not read" message on locals unless what is
                                                                // written is a constant, a null, a default(T) expression, a default constructor
                                                                // of a value type, or a built-in conversion operating on a constant, etc.

                                            _usedVariables, local);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 33605, 35471);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 35491, 35515);

                    f_10889_35491_35514(this, variable);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 33106, 35530);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 32998, 35541);

                bool
                f_10889_33168_33199(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 33168, 33199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10889_33257_33270(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 33257, 33270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10889_33357_33384(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 33357, 33384);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10889_33479_33489(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 33479, 33489);
                    return return_v;
                }


                bool
                f_10889_33460_33497(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    var return_v = WriteConsideredUse(type, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 33460, 33497);
                    return return_v;
                }


                int
                f_10889_33407_33511(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                field, bool
                read, bool
                write)
                {
                    this_param.NoteFieldAccess(field, read: read, write: write);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 33407, 33511);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10889_33661_33671(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 33661, 33671);
                    return return_v;
                }


                bool
                f_10889_33642_33679(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    var return_v = WriteConsideredUse(type, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 33642, 33679);
                    return return_v;
                }


                bool
                f_10889_35426_35451(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 35426, 35451);
                    return return_v;
                }


                int
                f_10889_35491_35514(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                variable)
                {
                    this_param.CheckCaptured(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 35491, 35514);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 32998, 35541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 32998, 35541);
            }
        }

        internal static bool WriteConsideredUse(TypeSymbol type, BoundExpression value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10889, 35791, 38334);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 35895, 35948) || true) && (value == null || (DynAbs.Tracing.TraceSender.Expression_False(10889, 35899, 35934) || f_10889_35916_35934(value)))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 35895, 35948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 35936, 35948);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 35895, 35948);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 35962, 36157) || true) && ((object)type != null && (DynAbs.Tracing.TraceSender.Expression_True(10889, 35966, 36010) && f_10889_35990_36010(type)) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 35966, 36059) && f_10889_36014_36030(type) != SpecialType.System_String))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 35962, 36157);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 36093, 36142);

                    return f_10889_36100_36119(value) != f_10889_36123_36141();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 35962, 36157);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 36173, 36365) || true) && ((object)type != null && (DynAbs.Tracing.TraceSender.Expression_True(10889, 36177, 36234) && f_10889_36201_36234(type)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 36173, 36365);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 36338, 36350);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 36173, 36365);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 36746, 36841) || true) && (value is { ConstantValue: not null, Kind: not BoundKind.InterpolatedString })
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 36746, 36841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 36828, 36841);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 36746, 36841);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 36855, 38323);

                switch (f_10889_36863_36873(value))
                {

                    case BoundKind.Conversion:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 36855, 38323);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 36982, 37039);

                            BoundConversion
                            boundConversion = (BoundConversion)value
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 37390, 37635) || true) && (f_10889_37394_37450(f_10889_37394_37424(boundConversion)) || (DynAbs.Tracing.TraceSender.Expression_False(10889, 37394, 37538) || f_10889_37483_37513(boundConversion) == ConversionKind.IntPtr))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 37390, 37635);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 37596, 37608);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 37390, 37635);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 37661, 37718);

                            return f_10889_37668_37717(null, f_10889_37693_37716(boundConversion));
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 36855, 38323);

                    case BoundKind.DefaultLiteral:
                    case BoundKind.DefaultExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 36855, 38323);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 37862, 37875);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 36855, 38323);

                    case BoundKind.ObjectCreationExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 36855, 38323);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 37955, 38003);

                        var
                        init = (BoundObjectCreationExpression)value
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 38025, 38112);

                        return f_10889_38032_38070_M(!f_10889_38033_38049(init).IsImplicitlyDeclared) || (DynAbs.Tracing.TraceSender.Expression_False(10889, 38032, 38111) || f_10889_38074_38103(init) != null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 36855, 38323);

                    case BoundKind.TupleLiteral:
                    case BoundKind.ConvertedTupleLiteral:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 36855, 38323);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 38235, 38248);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 36855, 38323);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 36855, 38323);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 38296, 38308);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 36855, 38323);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10889, 35791, 38334);

                bool
                f_10889_35916_35934(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 35916, 35934);
                    return return_v;
                }


                bool
                f_10889_35990_36010(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 35990, 36010);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10889_36014_36030(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 36014, 36030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10889_36100_36119(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 36100, 36119);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10889_36123_36141()
                {
                    var return_v = ConstantValue.Null;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 36123, 36141);
                    return return_v;
                }


                bool
                f_10889_36201_36234(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 36201, 36234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10889_36863_36873(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 36863, 36873);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10889_37394_37424(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 37394, 37424);
                    return return_v;
                }


                bool
                f_10889_37394_37450(Microsoft.CodeAnalysis.CSharp.ConversionKind
                conversionKind)
                {
                    var return_v = conversionKind.IsUserDefinedConversion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 37394, 37450);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10889_37483_37513(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 37483, 37513);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10889_37693_37716(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 37693, 37716);
                    return return_v;
                }


                bool
                f_10889_37668_37717(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    var return_v = WriteConsideredUse(type, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 37668, 37717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10889_38033_38049(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 38033, 38049);
                    return return_v;
                }


                bool
                f_10889_38032_38070_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 38032, 38070);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                f_10889_38074_38103(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.InitializerExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 38074, 38103);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 35791, 38334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 35791, 38334);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void NoteWrite(BoundExpression n, BoundExpression value, bool read)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 38346, 41578);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 38446, 41567) || true) && (n != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 38446, 41567);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 38496, 41552);

                        switch (f_10889_38504_38510(n))
                        {

                            case BoundKind.FieldAccess:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 38496, 41552);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 38636, 38674);

                                    var
                                    fieldAccess = (BoundFieldAccess)n
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 38704, 39057) || true) && ((object)_sourceAssembly != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 38704, 39057);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 38805, 38860);

                                        var
                                        field = f_10889_38817_38859(f_10889_38817_38840(fieldAccess))
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 38894, 39026);

                                        f_10889_38894_39025(_sourceAssembly, field, read: value == null || (DynAbs.Tracing.TraceSender.Expression_False(10889, 38939, 39011) || f_10889_38956_39011(f_10889_38975_39003(f_10889_38975_38998(fieldAccess)), value)), write: true);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 38704, 39057);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 39089, 39686) || true) && (f_10889_39093_39161(this, f_10889_39112_39135(fieldAccess), f_10889_39137_39160(fieldAccess)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 39089, 39686);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 39227, 39255);

                                        n = f_10889_39231_39254(fieldAccess);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 39289, 39475) || true) && (f_10889_39293_39299(n) == BoundKind.Local)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 39289, 39475);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 39392, 39440);

                                            f_10889_39392_39439(_usedVariables, f_10889_39411_39438(((BoundLocal)n)));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 39289, 39475);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 39509, 39518);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 39089, 39686);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 39089, 39686);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 39648, 39655);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 39089, 39686);
                                    }
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 38496, 41552);

                            case BoundKind.EventAccess:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 38496, 41552);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 39821, 39859);

                                    var
                                    eventAccess = (BoundEventAccess)n
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 39889, 39959);

                                    FieldSymbol
                                    associatedField = f_10889_39919_39958(f_10889_39919_39942(eventAccess))
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 39989, 40758) || true) && ((object)associatedField != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 39989, 40758);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 40090, 40443) || true) && ((object)_sourceAssembly != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 40090, 40443);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 40199, 40246);

                                            var
                                            field = f_10889_40211_40245(associatedField)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 40284, 40408);

                                            f_10889_40284_40407(_sourceAssembly, field, read: value == null || (DynAbs.Tracing.TraceSender.Expression_False(10889, 40329, 40393) || f_10889_40346_40393(f_10889_40365_40385(associatedField), value)), write: true);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 40090, 40443);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 40479, 40727) || true) && (f_10889_40483_40543(this, f_10889_40502_40525(eventAccess), associatedField))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 40479, 40727);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 40617, 40645);

                                            n = f_10889_40621_40644(eventAccess);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 40683, 40692);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 40479, 40727);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 39989, 40758);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 40788, 40795);

                                    return;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 38496, 41552);

                            case BoundKind.ThisReference:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 38496, 41552);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 40901, 40945);

                                f_10889_40901_40944(this, f_10889_40911_40930(), value, read);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 40971, 40978);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 38496, 41552);

                            case BoundKind.Local:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 38496, 41552);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 41049, 41101);

                                f_10889_41049_41100(this, f_10889_41059_41086(((BoundLocal)n)), value, read);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 41127, 41134);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 38496, 41552);

                            case BoundKind.Parameter:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 38496, 41552);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 41209, 41269);

                                f_10889_41209_41268(this, f_10889_41219_41254(((BoundParameter)n)), value, read);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 41295, 41302);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 38496, 41552);

                            case BoundKind.RangeVariable:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 38496, 41552);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 41381, 41435);

                                f_10889_41381_41434(this, f_10889_41391_41420(((BoundRangeVariable)n)), value, read);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 41461, 41468);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 38496, 41552);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 38496, 41552);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 41526, 41533);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 38496, 41552);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 38446, 41567);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 38446, 41567);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 38446, 41567);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 38346, 41578);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10889_38504_38510(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 38504, 38510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10889_38817_38840(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 38817, 38840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10889_38817_38859(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 38817, 38859);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10889_38975_38998(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 38975, 38998);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10889_38975_39003(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 38975, 39003);
                    return return_v;
                }


                bool
                f_10889_38956_39011(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    var return_v = WriteConsideredUse(type, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 38956, 39011);
                    return return_v;
                }


                int
                f_10889_38894_39025(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                field, bool
                read, bool
                write)
                {
                    this_param.NoteFieldAccess(field, read: read, write: write);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 38894, 39025);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10889_39112_39135(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 39112, 39135);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10889_39137_39160(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 39137, 39160);
                    return return_v;
                }


                bool
                f_10889_39093_39161(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol)
                {
                    var return_v = this_param.MayRequireTracking(receiverOpt, fieldSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 39093, 39161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10889_39231_39254(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 39231, 39254);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10889_39293_39299(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 39293, 39299);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10889_39411_39438(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 39411, 39438);
                    return return_v;
                }


                bool
                f_10889_39392_39439(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 39392, 39439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10889_39919_39942(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.EventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 39919, 39942);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                f_10889_39919_39958(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 39919, 39958);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10889_40211_40245(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 40211, 40245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10889_40365_40385(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 40365, 40385);
                    return return_v;
                }


                bool
                f_10889_40346_40393(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    var return_v = WriteConsideredUse(type, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 40346, 40393);
                    return return_v;
                }


                int
                f_10889_40284_40407(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                field, bool
                read, bool
                write)
                {
                    this_param.NoteFieldAccess(field, read: read, write: write);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 40284, 40407);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10889_40502_40525(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 40502, 40525);
                    return return_v;
                }


                bool
                f_10889_40483_40543(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol)
                {
                    var return_v = this_param.MayRequireTracking(receiverOpt, fieldSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 40483, 40543);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10889_40621_40644(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 40621, 40644);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10889_40911_40930()
                {
                    var return_v = MethodThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 40911, 40930);
                    return return_v;
                }


                int
                f_10889_40901_40944(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                variable, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                value, bool
                read)
                {
                    this_param.NoteWrite((Microsoft.CodeAnalysis.CSharp.Symbol)variable, value, read);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 40901, 40944);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10889_41059_41086(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 41059, 41086);
                    return return_v;
                }


                int
                f_10889_41049_41100(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                variable, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                value, bool
                read)
                {
                    this_param.NoteWrite((Microsoft.CodeAnalysis.CSharp.Symbol)variable, value, read);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 41049, 41100);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10889_41219_41254(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 41219, 41254);
                    return return_v;
                }


                int
                f_10889_41209_41268(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                variable, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                value, bool
                read)
                {
                    this_param.NoteWrite((Microsoft.CodeAnalysis.CSharp.Symbol)variable, value, read);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 41209, 41268);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10889_41391_41420(Microsoft.CodeAnalysis.CSharp.BoundRangeVariable
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 41391, 41420);
                    return return_v;
                }


                int
                f_10889_41381_41434(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                n, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                value, bool
                read)
                {
                    this_param.NoteWrite(n, value, read);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 41381, 41434);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 38346, 41578);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 38346, 41578);
            }
        }

        protected override void Normalize(ref LocalState state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 41590, 42456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 41670, 41708);

                int
                oldNext = state.Assigned.Capacity
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 41722, 41751);

                int
                n = f_10889_41730_41750(variableBySlot)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 41765, 41798);

                state.Assigned.EnsureCapacity(n);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 41821, 41832);
                    for (int
        i = oldNext
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 41812, 42445) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 41841, 41844)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 41812, 42445))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 41812, 42445);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 41878, 41905);

                        var
                        id = f_10889_41887_41904(variableBySlot, i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 41923, 41952);

                        int
                        slot = id.ContainingSlot
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 41972, 42144);

                        bool
                        assign = (slot > 0) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 41986, 42041) && state.Assigned[slot]) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 41986, 42143) && f_10889_42066_42115(variableBySlot[slot].Symbol).TypeKind == TypeKind.Struct)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 42164, 42383) || true) && (f_10889_42168_42191(state) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 42168, 42204) && slot == 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 42164, 42383);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 42350, 42364);

                            assign = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 42164, 42383);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 42403, 42430);

                        state.Assigned[i] = assign;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 634);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 634);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 41590, 42456);

                int
                f_10889_41730_41750(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 41730, 41750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier
                f_10889_41887_41904(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 41887, 41904);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10889_42066_42115(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetTypeOrReturnType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 42066, 42115);
                    return return_v;
                }


                bool
                f_10889_42168_42191(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param)
                {
                    var return_v = this_param.NormalizeToBottom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 42168, 42191);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 41590, 42456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 41590, 42456);
            }
        }

        protected override bool TryGetReceiverAndMember(BoundExpression expr, out BoundExpression receiver, out Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 42468, 45187);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 42611, 42627);

                receiver = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 42641, 42655);

                member = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 42671, 44957);

                switch (f_10889_42679_42688(expr))
                {

                    case BoundKind.FieldAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 42671, 44957);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 42798, 42839);

                            var
                            fieldAccess = (BoundFieldAccess)expr
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 42865, 42907);

                            var
                            fieldSymbol = f_10889_42883_42906(fieldAccess)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 42933, 42954);

                            member = fieldSymbol;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 42980, 43111) || true) && (f_10889_42984_43013(fieldSymbol))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 42980, 43111);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 43071, 43084);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 42980, 43111);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 43137, 43273) || true) && (f_10889_43141_43161(fieldSymbol))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 43137, 43273);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 43219, 43246);

                                return _trackStaticMembers;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 43137, 43273);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 43299, 43334);

                            receiver = f_10889_43310_43333(fieldAccess);
                            DynAbs.Tracing.TraceSender.TraceBreak(10889, 43360, 43366);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 42671, 44957);

                    case BoundKind.EventAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 42671, 44957);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 43483, 43524);

                            var
                            eventAccess = (BoundEventAccess)expr
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 43550, 43592);

                            var
                            eventSymbol = f_10889_43568_43591(eventAccess)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 43618, 43655);

                            member = f_10889_43627_43654(eventSymbol);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 43681, 43817) || true) && (f_10889_43685_43705(eventSymbol))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 43681, 43817);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 43763, 43790);

                                return _trackStaticMembers;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 43681, 43817);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 43843, 43878);

                            receiver = f_10889_43854_43877(eventAccess);
                            DynAbs.Tracing.TraceSender.TraceBreak(10889, 43904, 43910);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 42671, 44957);

                    case BoundKind.PropertyAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 42671, 44957);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 44030, 44073);

                            var
                            propAccess = (BoundPropertyAccess)expr
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 44101, 44887) || true) && (f_10889_44105_44180(propAccess, this.CurrentSymbol))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 44101, 44887);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 44238, 44281);

                                var
                                propSymbol = f_10889_44255_44280(propAccess)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 44350, 44461);

                                member = (DynAbs.Tracing.TraceSender.Conditional_F1(10889, 44359, 44399) || (((propSymbol is SourcePropertySymbolBase) && DynAbs.Tracing.TraceSender.Conditional_F2(10889, 44402, 44453)) || DynAbs.Tracing.TraceSender.Conditional_F3(10889, 44456, 44460))) ? f_10889_44402_44453(((SourcePropertySymbolBase)propSymbol)) : null;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 44491, 44619) || true) && (member is null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 44491, 44619);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 44575, 44588);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 44491, 44619);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 44649, 44796) || true) && (f_10889_44653_44672(propSymbol))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 44649, 44796);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 44738, 44765);

                                    return _trackStaticMembers;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 44649, 44796);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 44826, 44860);

                                receiver = f_10889_44837_44859(propAccess);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 44101, 44887);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10889, 44913, 44919);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 42671, 44957);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 44973, 45176);

                return (object)member != null && (DynAbs.Tracing.TraceSender.Expression_True(10889, 44980, 45047) && (object)receiver != null) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 44980, 45109) && f_10889_45068_45081(receiver) != BoundKind.TypeExpression) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 44980, 45175) && f_10889_45130_45175(this, f_10889_45161_45174(receiver)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 42468, 45187);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10889_42679_42688(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 42679, 42688);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10889_42883_42906(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 42883, 42906);
                    return return_v;
                }


                bool
                f_10889_42984_43013(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsFixedSizeBuffer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 42984, 43013);
                    return return_v;
                }


                bool
                f_10889_43141_43161(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 43141, 43161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10889_43310_43333(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 43310, 43333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10889_43568_43591(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.EventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 43568, 43591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                f_10889_43627_43654(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 43627, 43654);
                    return return_v;
                }


                bool
                f_10889_43685_43705(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 43685, 43705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10889_43854_43877(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 43854, 43877);
                    return return_v;
                }


                bool
                f_10889_44105_44180(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                propertyAccess, Microsoft.CodeAnalysis.CSharp.Symbol
                fromMember)
                {
                    var return_v = Binder.AccessingAutoPropertyFromConstructor(propertyAccess, fromMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 44105, 44180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10889_44255_44280(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.PropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 44255, 44280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedBackingFieldSymbol
                f_10889_44402_44453(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.BackingField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 44402, 44453);
                    return return_v;
                }


                bool
                f_10889_44653_44672(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 44653, 44672);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10889_44837_44859(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 44837, 44859);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10889_45068_45081(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 45068, 45081);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10889_45161_45174(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 45161, 45174);
                    return return_v;
                }


                bool
                f_10889_45130_45175(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = this_param.MayRequireTrackingReceiverType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 45130, 45175);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 42468, 45187);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 42468, 45187);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool MayRequireTrackingReceiverType(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 45199, 45399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 45284, 45388);

                return (object)type != null && (DynAbs.Tracing.TraceSender.Expression_True(10889, 45291, 45387) && (_trackClassFields || (DynAbs.Tracing.TraceSender.Expression_False(10889, 45333, 45386) || f_10889_45354_45367(type) == TypeKind.Struct)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 45199, 45399);

                Microsoft.CodeAnalysis.TypeKind
                f_10889_45354_45367(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 45354, 45367);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 45199, 45399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 45199, 45399);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected bool MayRequireTracking(BoundExpression receiverOpt, FieldSymbol fieldSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 45411, 45960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 45523, 45949);

                return
                                (object)fieldSymbol != null && (DynAbs.Tracing.TraceSender.Expression_True(10889, 45547, 45654) && receiverOpt != null) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 45547, 45696) && f_10889_45675_45696_M(!fieldSymbol.IsStatic)) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 45547, 45747) && f_10889_45717_45747_M(!fieldSymbol.IsFixedSizeBuffer)) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 45547, 45812) && f_10889_45768_45784(receiverOpt) != BoundKind.TypeExpression) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 45547, 45881) && f_10889_45833_45881(this, f_10889_45864_45880(receiverOpt))) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 45547, 45948) && !f_10889_45903_45948(f_10889_45903_45919(receiverOpt)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 45411, 45960);

                bool
                f_10889_45675_45696_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 45675, 45696);
                    return return_v;
                }


                bool
                f_10889_45717_45747_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 45717, 45747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10889_45768_45784(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 45768, 45784);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10889_45864_45880(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 45864, 45880);
                    return return_v;
                }


                bool
                f_10889_45833_45881(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = this_param.MayRequireTrackingReceiverType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 45833, 45881);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10889_45903_45919(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 45903, 45919);
                    return return_v;
                }


                bool
                f_10889_45903_45948(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                t)
                {
                    var return_v = t.IsPrimitiveRecursiveStruct();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 45903, 45948);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 45411, 45960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 45411, 45960);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected void CheckAssigned(Symbol symbol, SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 46183, 46850);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 46268, 46302);

                f_10889_46268_46301(!IsConditionalState);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 46316, 46839) || true) && ((object)symbol != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 46316, 46839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 46376, 46393);

                    f_10889_46376_46392(this, symbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 46413, 46824) || true) && (f_10889_46417_46437(this.State))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 46413, 46824);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 46479, 46511);

                        int
                        slot = f_10889_46490_46510(this, symbol)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 46533, 46601) || true) && (slot >= this.State.Assigned.Capacity)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 46533, 46601);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 46575, 46601);

                            f_10889_46575_46600(this, ref this.State);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 46533, 46601);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 46623, 46805) || true) && (slot > 0 && (DynAbs.Tracing.TraceSender.Expression_True(10889, 46627, 46667) && !f_10889_46640_46667(this.State, slot)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 46623, 46805);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 46717, 46782);

                            f_10889_46717_46781(this, symbol, node, slot);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 46623, 46805);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 46413, 46824);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 46316, 46839);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 46183, 46850);

                int
                f_10889_46268_46301(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 46268, 46301);
                    return 0;
                }


                int
                f_10889_46376_46392(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                variable)
                {
                    this_param.NoteRead(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 46376, 46392);
                    return 0;
                }


                bool
                f_10889_46417_46437(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param)
                {
                    var return_v = this_param.Reachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 46417, 46437);
                    return return_v;
                }


                int
                f_10889_46490_46510(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.VariableSlot(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 46490, 46510);
                    return return_v;
                }


                int
                f_10889_46575_46600(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, ref Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                state)
                {
                    this_param.Normalize(ref state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 46575, 46600);
                    return 0;
                }


                bool
                f_10889_46640_46667(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param, int
                slot)
                {
                    var return_v = this_param.IsAssigned(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 46640, 46667);
                    return return_v;
                }


                int
                f_10889_46717_46781(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node, int
                slot)
                {
                    this_param.ReportUnassignedIfNotCapturedInLocalFunction(symbol, node, slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 46717, 46781);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 46183, 46850);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 46183, 46850);
            }
        }

        private void ReportUnassignedIfNotCapturedInLocalFunction(Symbol symbol, SyntaxNode node, int slot, bool skipIfUseBeforeDeclaration = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 46862, 47388);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 47155, 47296) || true) && (f_10889_47159_47190(this, slot))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 47155, 47296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 47224, 47256);

                    f_10889_47224_47255(this, slot);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 47274, 47281);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 47155, 47296);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 47312, 47377);

                f_10889_47312_47376(this, symbol, node, slot, skipIfUseBeforeDeclaration);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 46862, 47388);

                bool
                f_10889_47159_47190(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                slot)
                {
                    var return_v = this_param.IsCapturedInLocalFunction(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 47159, 47190);
                    return return_v;
                }


                int
                f_10889_47224_47255(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                slot)
                {
                    this_param.RecordReadInLocalFunction(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 47224, 47255);
                    return 0;
                }


                int
                f_10889_47312_47376(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node, int
                slot, bool
                skipIfUseBeforeDeclaration)
                {
                    this_param.ReportUnassigned(symbol, node, slot, skipIfUseBeforeDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 47312, 47376);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 46862, 47388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 46862, 47388);
            }
        }

        protected virtual void ReportUnassigned(Symbol symbol, SyntaxNode node, int slot, bool skipIfUseBeforeDeclaration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 47610, 50920);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 47749, 47818) || true) && (slot <= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 47749, 47818);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 47796, 47803);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 47749, 47818);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 48335, 48439) || true) && (symbol is LocalSymbol local && (DynAbs.Tracing.TraceSender.Expression_True(10889, 48339, 48383) && f_10889_48370_48383(local)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 48335, 48439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 48417, 48424);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 48335, 48439);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 48455, 48595) || true) && (slot >= _alreadyReported.Capacity)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 48455, 48595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 48526, 48580);

                    _alreadyReported.EnsureCapacity(f_10889_48558_48578(variableBySlot));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 48455, 48595);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 48611, 50771) || true) && (skipIfUseBeforeDeclaration && (DynAbs.Tracing.TraceSender.Expression_True(10889, 48615, 48693) && f_10889_48662_48673(symbol) == SymbolKind.Local) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 48615, 48811) && (symbol.Locations.Length == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10889, 48715, 48810) || node.Span.End < symbol.Locations.FirstOrNone().SourceSpan.Start))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 48611, 50771);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 48611, 50771);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 48611, 50771);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 49023, 50771) || true) && (f_10889_49027_49050_M(!_alreadyReported[slot]) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 49027, 49102) && !f_10889_49055_49102(f_10889_49055_49083(symbol).Type)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 49023, 50771);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 49352, 49372);

                        ErrorCode
                        errorCode
                        = default(ErrorCode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 49390, 49422);

                        string
                        symbolName = f_10889_49410_49421(symbol)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 49442, 50673) || true) && (f_10889_49446_49457(symbol) == SymbolKind.Field)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 49442, 50673);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 49519, 49557);

                            var
                            fieldSymbol = (FieldSymbol)symbol
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 49579, 49631);

                            var
                            associatedSymbol = f_10889_49602_49630(fieldSymbol)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 49653, 50031) || true) && (f_10889_49657_49679_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(associatedSymbol, 10889, 49657, 49679)?.Kind) == SymbolKind.Property)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 49653, 50031);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 49752, 49802);

                                errorCode = ErrorCode.ERR_UseDefViolationProperty;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 49828, 49863);

                                symbolName = f_10889_49841_49862(associatedSymbol);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 49653, 50031);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 49653, 50031);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 49961, 50008);

                                errorCode = ErrorCode.ERR_UseDefViolationField;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 49653, 50031);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 49442, 50673);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 49442, 50673);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 50073, 50673) || true) && (f_10889_50077_50088(symbol) == SymbolKind.Parameter && (DynAbs.Tracing.TraceSender.Expression_True(10889, 50077, 50190) && f_10889_50142_50175(((ParameterSymbol)symbol)) == RefKind.Out))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 50073, 50673);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 50232, 50530) || true) && (f_10889_50236_50268(((ParameterSymbol)symbol)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 50232, 50530);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 50318, 50364);

                                    errorCode = ErrorCode.ERR_UseDefViolationThis;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 50232, 50530);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 50232, 50530);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 50462, 50507);

                                    errorCode = ErrorCode.ERR_UseDefViolationOut;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 50232, 50530);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 50073, 50673);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 50073, 50673);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 50612, 50654);

                                errorCode = ErrorCode.ERR_UseDefViolation;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 50073, 50673);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 49442, 50673);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 50691, 50756);

                        f_10889_50691_50755(f_10889_50691_50702(), errorCode, f_10889_50718_50742(node), symbolName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 49023, 50771);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 48611, 50771);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 50879, 50909);

                _alreadyReported[slot] = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 47610, 50920);

                bool
                f_10889_48370_48383(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.IsConst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 48370, 48383);
                    return return_v;
                }


                int
                f_10889_48558_48578(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 48558, 48578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10889_48662_48673(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 48662, 48673);
                    return return_v;
                }


                bool
                f_10889_49027_49050_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 49027, 49050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10889_49055_49083(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetTypeOrReturnType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 49055, 49083);
                    return return_v;
                }


                bool
                f_10889_49055_49102(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 49055, 49102);
                    return return_v;
                }


                string
                f_10889_49410_49421(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 49410, 49421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10889_49446_49457(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 49446, 49457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10889_49602_49630(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 49602, 49630);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind?
                f_10889_49657_49679_M(Microsoft.CodeAnalysis.SymbolKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 49657, 49679);
                    return return_v;
                }


                string
                f_10889_49841_49862(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 49841, 49862);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10889_50077_50088(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 50077, 50088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10889_50142_50175(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 50142, 50175);
                    return return_v;
                }


                bool
                f_10889_50236_50268(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsThis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 50236, 50268);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10889_50691_50702()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 50691, 50702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10889_50718_50742(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 50718, 50742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10889_50691_50755(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 50691, 50755);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 47610, 50920);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 47610, 50920);
            }
        }

        protected virtual void CheckAssigned(BoundExpression expr, FieldSymbol fieldSymbol, SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 50932, 51297);
                int unassignedSlot = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 51057, 51255) || true) && (f_10889_51061_51081(this.State) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 51061, 51126) && !f_10889_51086_51126(this, expr, out unassignedSlot)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 51057, 51255);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 51160, 51240);

                    f_10889_51160_51239(this, fieldSymbol, node, unassignedSlot);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 51057, 51255);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 51271, 51286);

                f_10889_51271_51285(this, expr);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 50932, 51297);

                bool
                f_10889_51061_51081(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param)
                {
                    var return_v = this_param.Reachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 51061, 51081);
                    return return_v;
                }


                bool
                f_10889_51086_51126(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, out int
                unassignedSlot)
                {
                    var return_v = this_param.IsAssigned(node, out unassignedSlot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 51086, 51126);
                    return return_v;
                }


                int
                f_10889_51160_51239(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node, int
                slot)
                {
                    this_param.ReportUnassignedIfNotCapturedInLocalFunction((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, node, slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 51160, 51239);
                    return 0;
                }


                int
                f_10889_51271_51285(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                fieldOrEventAccess)
                {
                    this_param.NoteRead((Microsoft.CodeAnalysis.CSharp.BoundNode)fieldOrEventAccess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 51271, 51285);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 50932, 51297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 50932, 51297);
            }
        }

        private bool IsAssigned(BoundExpression node, out int unassignedSlot)
        {
            unassignedSlot = -1;
            if (_emptyStructTypeCache.IsEmptyStructType(node.Type)) return true;
            switch (node.Kind)
            {
                case BoundKind.ThisReference:
                    {
                        var self = MethodThisParameter;
                        if ((object)self == null)
                        {
                            unassignedSlot = -1;
                            return true;
                        }

                        unassignedSlot = GetOrCreateSlot(MethodThisParameter);
                        break;
                    }

                case BoundKind.Local:
                    {
                        unassignedSlot = GetOrCreateSlot(((BoundLocal)node).LocalSymbol);
                        break;
                    }

                case BoundKind.FieldAccess:
                    {
                        var fieldAccess = (BoundFieldAccess)node;
                        if (!MayRequireTracking(fieldAccess.ReceiverOpt, fieldAccess.FieldSymbol) || IsAssigned(fieldAccess.ReceiverOpt, out unassignedSlot))
                        {
                            return true;
                        }

                        unassignedSlot = GetOrCreateSlot(fieldAccess.FieldSymbol, unassignedSlot);
                        break;
                    }

                case BoundKind.EventAccess:
                    {
                        var eventAccess = (BoundEventAccess)node;
                        if (!MayRequireTracking(eventAccess.ReceiverOpt, eventAccess.EventSymbol.AssociatedField) || IsAssigned(eventAccess.ReceiverOpt, out unassignedSlot))
                        {
                            return true;
                        }

                        unassignedSlot = GetOrCreateSlot(eventAccess.EventSymbol.AssociatedField, unassignedSlot);
                        break;
                    }

                case BoundKind.PropertyAccess:
                    {
                        var propertyAccess = (BoundPropertyAccess)node;
                        if (Binder.AccessingAutoPropertyFromConstructor(propertyAccess, this.CurrentSymbol))
                        {
                            var property = propertyAccess.PropertySymbol;
                            // LAFHIS
                            var backingField = (property is SourcePropertySymbolBase) ? ((SourcePropertySymbolBase)property).BackingField : null;
                            if (backingField != null)
                            {
                                if (!MayRequireTracking(propertyAccess.ReceiverOpt, backingField) || IsAssigned(propertyAccess.ReceiverOpt, out unassignedSlot))
                                {
                                    return true;
                                }

                                unassignedSlot = GetOrCreateSlot(backingField, unassignedSlot);
                                break;
                            }
                        }

                        goto default;
                    }

                case BoundKind.Parameter:
                    {
                        var parameter = ((BoundParameter)node);
                        unassignedSlot = GetOrCreateSlot(parameter.ParameterSymbol);
                        break;
                    }

                case BoundKind.RangeVariable:
                // range variables are always assigned
                default:
                    {
                        // The value is a method call return value or something else we can assume is assigned.
                        unassignedSlot = -1;
                        return true;
                    }
            }

            Debug.Assert(unassignedSlot > 0);
            if (unassignedSlot > 0)
            {
                return this.State.IsAssigned(unassignedSlot);
            }

            return true;
        }

        private Symbol UseNonFieldSymbolUnsafely(BoundExpression expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 55419, 57043);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 55512, 57004) || true) && (expression != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 55512, 57004);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 55571, 56989);

                        switch (f_10889_55579_55594(expression))
                        {

                            case BoundKind.FieldAccess:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 55571, 56989);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 55720, 55767);

                                    var
                                    fieldAccess = (BoundFieldAccess)expression
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 55797, 55839);

                                    var
                                    fieldSymbol = f_10889_55815_55838(fieldAccess)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 55869, 55963) || true) && ((object)_sourceAssembly != null)
                                    )
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 55869, 55963);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 55906, 55963);

                                        f_10889_55906_55962(_sourceAssembly, fieldSymbol, true, true);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 55869, 55963);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 55993, 56077) || true) && (f_10889_55997_56039(f_10889_55997_56023(fieldSymbol)) || (DynAbs.Tracing.TraceSender.Expression_False(10889, 55997, 56063) || f_10889_56043_56063(fieldSymbol)))
                                    )
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 55993, 56077);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 56065, 56077);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 55993, 56077);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 56107, 56144);

                                    expression = f_10889_56120_56143(fieldAccess);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 56174, 56183);

                                    continue;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 55571, 56989);

                            case BoundKind.Local:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 55571, 56989);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 56279, 56329);

                                var
                                result = f_10889_56292_56328(((BoundLocal)expression))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 56355, 56382);

                                f_10889_56355_56381(_usedVariables, result);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 56408, 56422);

                                return result;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 55571, 56989);

                            case BoundKind.RangeVariable:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 55571, 56989);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 56499, 56559);

                                return f_10889_56506_56558(((BoundRangeVariable)expression));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 55571, 56989);

                            case BoundKind.Parameter:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 55571, 56989);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 56632, 56684);

                                return f_10889_56639_56683(((BoundParameter)expression));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 55571, 56989);

                            case BoundKind.ThisReference:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 55571, 56989);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 56761, 56793);

                                return f_10889_56768_56792(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 55571, 56989);

                            case BoundKind.BaseReference:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 55571, 56989);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 56870, 56902);

                                return f_10889_56877_56901(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 55571, 56989);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 55571, 56989);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 56958, 56970);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 55571, 56989);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 55512, 57004);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 55512, 57004);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 55512, 57004);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 57020, 57032);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 55419, 57043);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10889_55579_55594(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 55579, 55594);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10889_55815_55838(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 55815, 55838);
                    return return_v;
                }


                int
                f_10889_55906_55962(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                field, bool
                read, bool
                write)
                {
                    this_param.NoteFieldAccess(field, read, write);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 55906, 55962);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10889_55997_56023(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 55997, 56023);
                    return return_v;
                }


                bool
                f_10889_55997_56039(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 55997, 56039);
                    return return_v;
                }


                bool
                f_10889_56043_56063(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 56043, 56063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10889_56120_56143(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 56120, 56143);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10889_56292_56328(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 56292, 56328);
                    return return_v;
                }


                bool
                f_10889_56355_56381(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 56355, 56381);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                f_10889_56506_56558(Microsoft.CodeAnalysis.CSharp.BoundRangeVariable
                this_param)
                {
                    var return_v = this_param.RangeVariableSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 56506, 56558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10889_56639_56683(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 56639, 56683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10889_56768_56792(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param)
                {
                    var return_v = this_param.MethodThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 56768, 56792);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10889_56877_56901(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param)
                {
                    var return_v = this_param.MethodThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 56877, 56901);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 55419, 57043);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 55419, 57043);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected void Assign(BoundNode node, BoundExpression value, bool isRef = false, bool read = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 57055, 57254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 57178, 57243);

                f_10889_57178_57242(this, node, value, written: true, isRef: isRef, read: read);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 57055, 57254);

                int
                f_10889_57178_57242(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, bool
                written, bool
                isRef, bool
                read)
                {
                    this_param.AssignImpl(node, value, written: written, isRef: isRef, read: read);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 57178, 57242);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 57055, 57254);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 57055, 57254);
            }
        }

        protected virtual void AssignImpl(BoundNode node, BoundExpression value, bool isRef, bool written, bool read)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 57761, 63596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 57895, 57929);

                f_10889_57895_57928(!IsConditionalState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 57945, 63585);

                switch (f_10889_57953_57962(node))
                {

                    case BoundKind.DeclarationPattern:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 57945, 63585);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 58079, 58123);

                            var
                            pattern = (BoundDeclarationPattern)node
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 58149, 58194);

                            var
                            symbol = f_10889_58162_58178(pattern) as LocalSymbol
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 58220, 58660) || true) && ((object)symbol != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 58220, 58660);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 58505, 58540);

                                int
                                slot = f_10889_58516_58539(this, symbol)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 58570, 58633);

                                f_10889_58570_58632(this, slot, assigned: written || (DynAbs.Tracing.TraceSender.Expression_False(10889, 58599, 58631) || f_10889_58610_58631_M(!this.State.Reachable)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 58220, 58660);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 58688, 58748) || true) && (written)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 58688, 58748);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 58701, 58748);

                                f_10889_58701_58747(this, f_10889_58711_58733(pattern), value, read);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 58688, 58748);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10889, 58774, 58780);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 57945, 63585);

                    case BoundKind.RecursivePattern:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 57945, 63585);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 58904, 58946);

                            var
                            pattern = (BoundRecursivePattern)node
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 58972, 59017);

                            var
                            symbol = f_10889_58985_59001(pattern) as LocalSymbol
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 59043, 59483) || true) && ((object)symbol != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 59043, 59483);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 59328, 59363);

                                int
                                slot = f_10889_59339_59362(this, symbol)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 59393, 59456);

                                f_10889_59393_59455(this, slot, assigned: written || (DynAbs.Tracing.TraceSender.Expression_False(10889, 59422, 59454) || f_10889_59433_59454_M(!this.State.Reachable)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 59043, 59483);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 59511, 59571) || true) && (written)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 59511, 59571);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 59524, 59571);

                                f_10889_59524_59570(this, f_10889_59534_59556(pattern), value, read);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 59511, 59571);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10889, 59597, 59603);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 57945, 63585);

                    case BoundKind.LocalDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 57945, 63585);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 59727, 59767);

                            var
                            local = (BoundLocalDeclaration)node
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 59793, 59854);

                            f_10889_59793_59853(f_10889_59806_59826(local) == value || (DynAbs.Tracing.TraceSender.Expression_False(10889, 59806, 59852) || value == null));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 59880, 59919);

                            LocalSymbol
                            symbol = f_10889_59901_59918(local)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 59945, 59980);

                            int
                            slot = f_10889_59956_59979(this, symbol)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 60006, 60069);

                            f_10889_60006_60068(this, slot, assigned: written || (DynAbs.Tracing.TraceSender.Expression_False(10889, 60035, 60067) || f_10889_60046_60067_M(!this.State.Reachable)));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 60095, 60139) || true) && (written)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 60095, 60139);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 60108, 60139);

                                f_10889_60108_60138(this, symbol, value, read);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 60095, 60139);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10889, 60165, 60171);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 57945, 63585);

                    case BoundKind.Local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 57945, 63585);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 60284, 60313);

                            var
                            local = (BoundLocal)node
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 60339, 60975) || true) && (f_10889_60343_60368(f_10889_60343_60360(local)) != RefKind.None && (DynAbs.Tracing.TraceSender.Expression_True(10889, 60343, 60394) && !isRef))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 60339, 60975);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 60617, 60676) || true) && (written)
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 60617, 60676);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 60630, 60676);

                                    f_10889_60630_60675(this, local, isKnownToBeAnLvalue: true);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 60617, 60676);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 60339, 60975);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 60339, 60975);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 60790, 60817);

                                int
                                slot = f_10889_60801_60816(this, local)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 60847, 60875);

                                f_10889_60847_60874(this, slot, written);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 60905, 60948) || true) && (written)
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 60905, 60948);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 60918, 60948);

                                    f_10889_60918_60947(this, local, value, read);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 60905, 60948);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 60339, 60975);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10889, 61001, 61007);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 57945, 63585);

                    case BoundKind.Parameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 57945, 63585);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 61124, 61161);

                            var
                            paramExpr = (BoundParameter)node
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 61187, 61225);

                            var
                            param = f_10889_61199_61224(paramExpr)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 61388, 61576) || true) && (isRef && (DynAbs.Tracing.TraceSender.Expression_True(10889, 61392, 61429) && f_10889_61401_61414(param) == RefKind.Out))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 61388, 61576);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 61487, 61549);

                                f_10889_61487_61548(this, param, node.Syntax, f_10889_61522_61547(paramExpr.Syntax));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 61388, 61576);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 61604, 61635);

                            int
                            slot = f_10889_61615_61634(this, paramExpr)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 61661, 61689);

                            f_10889_61661_61688(this, slot, written);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 61715, 61762) || true) && (written)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 61715, 61762);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 61728, 61762);

                                f_10889_61728_61761(this, paramExpr, value, read);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 61715, 61762);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10889, 61788, 61794);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 57945, 63585);

                    case BoundKind.ThisReference:
                    case BoundKind.FieldAccess:
                    case BoundKind.EventAccess:
                    case BoundKind.PropertyAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 57945, 63585);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 62053, 62092);

                            var
                            expression = (BoundExpression)node
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 62118, 62150);

                            int
                            slot = f_10889_62129_62149(this, expression)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 62176, 62204);

                            f_10889_62176_62203(this, slot, written);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 62230, 62278) || true) && (written)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 62230, 62278);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 62243, 62278);

                                f_10889_62243_62277(this, expression, value, read);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 62230, 62278);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10889, 62304, 62310);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 57945, 63585);

                    case BoundKind.RangeVariable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 57945, 63585);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 62404, 62478);

                        f_10889_62404_62477(this, f_10889_62415_62447(((BoundRangeVariable)node)), value, isRef, written, read);
                        DynAbs.Tracing.TraceSender.TraceBreak(10889, 62500, 62506);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 57945, 63585);

                    case BoundKind.BadExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 57945, 63585);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 62701, 62736);

                            var
                            bad = (BoundBadExpression)node
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 62762, 62980) || true) && (f_10889_62766_62796_M(!bad.ChildBoundNodes.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 62766, 62831) && bad.ChildBoundNodes.Length == 1))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 62762, 62980);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 62889, 62953);

                                f_10889_62889_62952(this, f_10889_62900_62919(bad)[0], value, isRef, written, read);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 62762, 62980);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10889, 63006, 63012);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 57945, 63585);

                    case BoundKind.TupleLiteral:
                    case BoundKind.ConvertedTupleLiteral:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 57945, 63585);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 63160, 63268);

                        f_10889_63160_63267(((BoundTupleExpression)node), (x, self) => self.Assign(x, value: null, isRef: isRef), this);
                        DynAbs.Tracing.TraceSender.TraceBreak(10889, 63290, 63296);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 57945, 63585);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 57945, 63585);
                        DynAbs.Tracing.TraceSender.TraceBreak(10889, 63564, 63570);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 57945, 63585);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 57761, 63596);

                int
                f_10889_57895_57928(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 57895, 57928);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10889_57953_57962(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 57953, 57962);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10889_58162_58178(Microsoft.CodeAnalysis.CSharp.BoundDeclarationPattern
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 58162, 58178);
                    return return_v;
                }


                int
                f_10889_58516_58539(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol)
                {
                    var return_v = this_param.GetOrCreateSlot((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 58516, 58539);
                    return return_v;
                }


                bool
                f_10889_58610_58631_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 58610, 58631);
                    return return_v;
                }


                int
                f_10889_58570_58632(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                slot, bool
                assigned)
                {
                    this_param.SetSlotState(slot, assigned: assigned);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 58570, 58632);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10889_58711_58733(Microsoft.CodeAnalysis.CSharp.BoundDeclarationPattern
                this_param)
                {
                    var return_v = this_param.VariableAccess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 58711, 58733);
                    return return_v;
                }


                int
                f_10889_58701_58747(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                n, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, bool
                read)
                {
                    this_param.NoteWrite(n, value, read);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 58701, 58747);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10889_58985_59001(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 58985, 59001);
                    return return_v;
                }


                int
                f_10889_59339_59362(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol)
                {
                    var return_v = this_param.GetOrCreateSlot((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 59339, 59362);
                    return return_v;
                }


                bool
                f_10889_59433_59454_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 59433, 59454);
                    return return_v;
                }


                int
                f_10889_59393_59455(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                slot, bool
                assigned)
                {
                    this_param.SetSlotState(slot, assigned: assigned);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 59393, 59455);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10889_59534_59556(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.VariableAccess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 59534, 59556);
                    return return_v;
                }


                int
                f_10889_59524_59570(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                n, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, bool
                read)
                {
                    this_param.NoteWrite(n, value, read);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 59524, 59570);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10889_59806_59826(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                this_param)
                {
                    var return_v = this_param.InitializerOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 59806, 59826);
                    return return_v;
                }


                int
                f_10889_59793_59853(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 59793, 59853);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10889_59901_59918(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 59901, 59918);
                    return return_v;
                }


                int
                f_10889_59956_59979(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol)
                {
                    var return_v = this_param.GetOrCreateSlot((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 59956, 59979);
                    return return_v;
                }


                bool
                f_10889_60046_60067_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 60046, 60067);
                    return return_v;
                }


                int
                f_10889_60006_60068(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                slot, bool
                assigned)
                {
                    this_param.SetSlotState(slot, assigned: assigned);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 60006, 60068);
                    return 0;
                }


                int
                f_10889_60108_60138(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                variable, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                value, bool
                read)
                {
                    this_param.NoteWrite((Microsoft.CodeAnalysis.CSharp.Symbol)variable, value, read);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 60108, 60138);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10889_60343_60360(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 60343, 60360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10889_60343_60368(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 60343, 60368);
                    return return_v;
                }


                int
                f_10889_60630_60675(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                node, bool
                isKnownToBeAnLvalue)
                {
                    this_param.VisitRvalue((Microsoft.CodeAnalysis.CSharp.BoundExpression)node, isKnownToBeAnLvalue: isKnownToBeAnLvalue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 60630, 60675);
                    return 0;
                }


                int
                f_10889_60801_60816(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                node)
                {
                    var return_v = this_param.MakeSlot((Microsoft.CodeAnalysis.CSharp.BoundExpression)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 60801, 60816);
                    return return_v;
                }


                int
                f_10889_60847_60874(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                slot, bool
                assigned)
                {
                    this_param.SetSlotState(slot, assigned);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 60847, 60874);
                    return 0;
                }


                int
                f_10889_60918_60947(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                n, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, bool
                read)
                {
                    this_param.NoteWrite((Microsoft.CodeAnalysis.CSharp.BoundExpression)n, value, read);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 60918, 60947);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10889_61199_61224(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 61199, 61224);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10889_61401_61414(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 61401, 61414);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10889_61522_61547(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 61522, 61547);
                    return return_v;
                }


                int
                f_10889_61487_61548(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.Location
                location)
                {
                    this_param.LeaveParameter(parameter, syntax, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 61487, 61548);
                    return 0;
                }


                int
                f_10889_61615_61634(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundParameter
                node)
                {
                    var return_v = this_param.MakeSlot((Microsoft.CodeAnalysis.CSharp.BoundExpression)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 61615, 61634);
                    return return_v;
                }


                int
                f_10889_61661_61688(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                slot, bool
                assigned)
                {
                    this_param.SetSlotState(slot, assigned);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 61661, 61688);
                    return 0;
                }


                int
                f_10889_61728_61761(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundParameter
                n, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, bool
                read)
                {
                    this_param.NoteWrite((Microsoft.CodeAnalysis.CSharp.BoundExpression)n, value, read);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 61728, 61761);
                    return 0;
                }


                int
                f_10889_62129_62149(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.MakeSlot(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 62129, 62149);
                    return return_v;
                }


                int
                f_10889_62176_62203(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                slot, bool
                assigned)
                {
                    this_param.SetSlotState(slot, assigned);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 62176, 62203);
                    return 0;
                }


                int
                f_10889_62243_62277(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                n, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, bool
                read)
                {
                    this_param.NoteWrite(n, value, read);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 62243, 62277);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10889_62415_62447(Microsoft.CodeAnalysis.CSharp.BoundRangeVariable
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 62415, 62447);
                    return return_v;
                }


                int
                f_10889_62404_62477(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, bool
                isRef, bool
                written, bool
                read)
                {
                    this_param.AssignImpl((Microsoft.CodeAnalysis.CSharp.BoundNode)node, value, isRef, written, read);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 62404, 62477);
                    return 0;
                }


                bool
                f_10889_62766_62796_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 62766, 62796);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10889_62900_62919(Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                this_param)
                {
                    var return_v = this_param.ChildBoundNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 62900, 62919);
                    return return_v;
                }


                int
                f_10889_62889_62952(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, bool
                isRef, bool
                written, bool
                read)
                {
                    this_param.AssignImpl((Microsoft.CodeAnalysis.CSharp.BoundNode)node, value, isRef, written, read);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 62889, 62952);
                    return 0;
                }


                int
                f_10889_63160_63267(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                this_param, System.Action<Microsoft.CodeAnalysis.CSharp.BoundExpression, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass>
                action, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                args)
                {
                    this_param.VisitAllElements<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass>(action, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 63160, 63267);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 57761, 63596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 57761, 63596);
            }
        }

        private bool FieldsAllSet(int containingSlot, LocalState state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 63753, 64543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 63841, 63876);

                f_10889_63841_63875(containingSlot != -1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 63890, 63938);

                f_10889_63890_63937(!f_10889_63904_63936(state, containingSlot));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 63952, 64013);

                VariableIdentifier
                variable = f_10889_63982_64012(variableBySlot, containingSlot)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 64027, 64094);

                TypeSymbol
                structType = f_10889_64051_64088(variable.Symbol).Type
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 64108, 64504);
                    foreach (var field in f_10889_64130_64187_I(f_10889_64130_64187(_emptyStructTypeCache, structType)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 64108, 64504);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 64221, 64287) || true) && (f_10889_64225_64276(_emptyStructTypeCache, f_10889_64265_64275(field)))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 64221, 64287);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 64278, 64287);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 64221, 64287);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 64305, 64350) || true) && (field is TupleErrorFieldSymbol)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 64305, 64350);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 64341, 64350);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 64305, 64350);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 64368, 64415);

                        int
                        slot = f_10889_64379_64414(this, field, containingSlot)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 64433, 64489) || true) && (slot == -1 || (DynAbs.Tracing.TraceSender.Expression_False(10889, 64437, 64474) || !f_10889_64452_64474(state, slot)))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 64433, 64489);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 64476, 64489);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 64433, 64489);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 64108, 64504);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 397);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 397);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 64520, 64532);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 63753, 64543);

                int
                f_10889_63841_63875(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 63841, 63875);
                    return 0;
                }


                bool
                f_10889_63904_63936(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param, int
                slot)
                {
                    var return_v = this_param.IsAssigned(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 63904, 63936);
                    return return_v;
                }


                int
                f_10889_63890_63937(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 63890, 63937);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier
                f_10889_63982_64012(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 63982, 64012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10889_64051_64088(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetTypeOrReturnType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 64051, 64088);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10889_64130_64187(Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.GetStructInstanceFields(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 64130, 64187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10889_64265_64275(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 64265, 64275);
                    return return_v;
                }


                bool
                f_10889_64225_64276(Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.IsEmptyStructType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 64225, 64276);
                    return return_v;
                }


                int
                f_10889_64379_64414(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, int
                containingSlot)
                {
                    var return_v = this_param.VariableSlot((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, containingSlot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 64379, 64414);
                    return return_v;
                }


                bool
                f_10889_64452_64474(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param, int
                slot)
                {
                    var return_v = this_param.IsAssigned(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 64452, 64474);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10889_64130_64187_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 64130, 64187);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 63753, 64543);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 63753, 64543);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected void SetSlotState(int slot, bool assigned)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 64555, 64852);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 64632, 64654) || true) && (slot <= 0)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 64632, 64654);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 64647, 64654);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 64632, 64654);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 64668, 64841) || true) && (assigned)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 64668, 64841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 64714, 64736);

                    f_10889_64714_64735(this, slot);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 64668, 64841);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 64668, 64841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 64802, 64826);

                    f_10889_64802_64825(this, slot);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 64668, 64841);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 64555, 64852);

                int
                f_10889_64714_64735(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                slot)
                {
                    this_param.SetSlotAssigned(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 64714, 64735);
                    return 0;
                }


                int
                f_10889_64802_64825(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                slot)
                {
                    this_param.SetSlotUnassigned(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 64802, 64825);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 64555, 64852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 64555, 64852);
            }
        }

        protected void SetSlotAssigned(int slot, ref LocalState state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 64864, 66216);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 64951, 64972) || true) && (slot < 0)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 64951, 64972);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 64965, 64972);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 64951, 64972);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 64986, 65031);

                VariableIdentifier
                id = f_10889_65010_65030(variableBySlot, slot)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 65045, 65100);

                TypeSymbol
                type = f_10889_65063_65094(id.Symbol).Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 65114, 65175);

                f_10889_65114_65174(!f_10889_65128_65173(_emptyStructTypeCache, type));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 65189, 65247) || true) && (slot >= state.Assigned.Capacity)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 65189, 65247);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 65226, 65247);

                    f_10889_65226_65246(this, ref state);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 65189, 65247);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 65261, 65296) || true) && (f_10889_65265_65287(state, slot))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 65261, 65296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 65289, 65296);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 65261, 65296);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 65341, 65360);

                f_10889_65341_65359(state, slot);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 65374, 65444);

                bool
                fieldsTracked = f_10889_65395_65443(type)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 65515, 65815) || true) && (fieldsTracked)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 65515, 65815);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 65566, 65800);
                        foreach (var field in f_10889_65588_65639_I(f_10889_65588_65639(_emptyStructTypeCache, type)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 65566, 65800);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 65681, 65716);

                            int
                            s2 = f_10889_65690_65715(this, field, slot)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 65738, 65781) || true) && (s2 > 0)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 65738, 65781);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 65750, 65781);

                                f_10889_65750_65780(this, s2, ref state);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 65738, 65781);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 65566, 65800);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 235);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 235);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 65515, 65815);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 65940, 66205) || true) && (id.ContainingSlot > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 65940, 66205);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 66002, 66027);

                        slot = id.ContainingSlot;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 66045, 66109) || true) && (f_10889_66049_66071(state, slot) || (DynAbs.Tracing.TraceSender.Expression_False(10889, 66049, 66101) || !f_10889_66076_66101(this, slot, state)))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 66045, 66109);
                            DynAbs.Tracing.TraceSender.TraceBreak(10889, 66103, 66109);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 66045, 66109);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 66127, 66146);

                        f_10889_66127_66145(state, slot);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 66164, 66190);

                        id = f_10889_66169_66189(variableBySlot, slot);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 65940, 66205);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 65940, 66205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 65940, 66205);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 64864, 66216);

                Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier
                f_10889_65010_65030(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 65010, 65030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10889_65063_65094(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetTypeOrReturnType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 65063, 65094);
                    return return_v;
                }


                bool
                f_10889_65128_65173(Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.IsEmptyStructType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 65128, 65173);
                    return return_v;
                }


                int
                f_10889_65114_65174(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 65114, 65174);
                    return 0;
                }


                int
                f_10889_65226_65246(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, ref Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                state)
                {
                    this_param.Normalize(ref state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 65226, 65246);
                    return 0;
                }


                bool
                f_10889_65265_65287(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param, int
                slot)
                {
                    var return_v = this_param.IsAssigned(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 65265, 65287);
                    return return_v;
                }


                int
                f_10889_65341_65359(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param, int
                slot)
                {
                    this_param.Assign(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 65341, 65359);
                    return 0;
                }


                bool
                f_10889_65395_65443(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = EmptyStructTypeCache.IsTrackableStructType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 65395, 65443);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10889_65588_65639(Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.GetStructInstanceFields(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 65588, 65639);
                    return return_v;
                }


                int
                f_10889_65690_65715(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, int
                containingSlot)
                {
                    var return_v = this_param.VariableSlot((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, containingSlot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 65690, 65715);
                    return return_v;
                }


                int
                f_10889_65750_65780(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                slot, ref Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                state)
                {
                    this_param.SetSlotAssigned(slot, ref state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 65750, 65780);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10889_65588_65639_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 65588, 65639);
                    return return_v;
                }


                bool
                f_10889_66049_66071(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param, int
                slot)
                {
                    var return_v = this_param.IsAssigned(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 66049, 66071);
                    return return_v;
                }


                bool
                f_10889_66076_66101(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                containingSlot, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                state)
                {
                    var return_v = this_param.FieldsAllSet(containingSlot, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 66076, 66101);
                    return return_v;
                }


                int
                f_10889_66127_66145(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param, int
                slot)
                {
                    this_param.Assign(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 66127, 66145);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier
                f_10889_66169_66189(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 66169, 66189);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 64864, 66216);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 64864, 66216);
            }
        }

        private void SetSlotAssigned(int slot)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 66228, 66340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 66291, 66329);

                f_10889_66291_66328(this, slot, ref this.State);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 66228, 66340);

                int
                f_10889_66291_66328(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                slot, ref Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                state)
                {
                    this_param.SetSlotAssigned(slot, ref state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 66291, 66328);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 66228, 66340);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 66228, 66340);
            }
        }

        private void SetSlotUnassigned(int slot, ref LocalState state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 66352, 67511);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 66439, 66460) || true) && (slot < 0)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 66439, 66460);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 66453, 66460);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 66439, 66460);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 66474, 66519);

                VariableIdentifier
                id = f_10889_66498_66518(variableBySlot, slot)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 66533, 66588);

                TypeSymbol
                type = f_10889_66551_66582(id.Symbol).Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 66602, 66663);

                f_10889_66602_66662(!f_10889_66616_66661(_emptyStructTypeCache, type));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 66677, 66713) || true) && (!f_10889_66682_66704(state, slot))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 66677, 66713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 66706, 66713);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 66677, 66713);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 66753, 66774);

                f_10889_66753_66773(state, slot);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 66788, 66858);

                bool
                fieldsTracked = f_10889_66809_66857(type)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 66931, 67233) || true) && (fieldsTracked)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 66931, 67233);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 66982, 67218);
                        foreach (var field in f_10889_67004_67055_I(f_10889_67004_67055(_emptyStructTypeCache, type)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 66982, 67218);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 67097, 67132);

                            int
                            s2 = f_10889_67106_67131(this, field, slot)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 67154, 67199) || true) && (s2 > 0)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 67154, 67199);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 67166, 67199);

                                f_10889_67166_67198(this, s2, ref state);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 67154, 67199);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 66982, 67218);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 237);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 237);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 66931, 67233);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 67315, 67500) || true) && (id.ContainingSlot > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 67315, 67500);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 67377, 67402);

                        slot = id.ContainingSlot;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 67420, 67441);

                        f_10889_67420_67440(state, slot);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 67459, 67485);

                        id = f_10889_67464_67484(variableBySlot, slot);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 67315, 67500);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 67315, 67500);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 67315, 67500);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 66352, 67511);

                Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier
                f_10889_66498_66518(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 66498, 66518);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10889_66551_66582(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetTypeOrReturnType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 66551, 66582);
                    return return_v;
                }


                bool
                f_10889_66616_66661(Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.IsEmptyStructType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 66616, 66661);
                    return return_v;
                }


                int
                f_10889_66602_66662(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 66602, 66662);
                    return 0;
                }


                bool
                f_10889_66682_66704(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param, int
                slot)
                {
                    var return_v = this_param.IsAssigned(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 66682, 66704);
                    return return_v;
                }


                int
                f_10889_66753_66773(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param, int
                slot)
                {
                    this_param.Unassign(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 66753, 66773);
                    return 0;
                }


                bool
                f_10889_66809_66857(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = EmptyStructTypeCache.IsTrackableStructType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 66809, 66857);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10889_67004_67055(Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.GetStructInstanceFields(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 67004, 67055);
                    return return_v;
                }


                int
                f_10889_67106_67131(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, int
                containingSlot)
                {
                    var return_v = this_param.VariableSlot((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, containingSlot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 67106, 67131);
                    return return_v;
                }


                int
                f_10889_67166_67198(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                slot, ref Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                state)
                {
                    this_param.SetSlotUnassigned(slot, ref state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 67166, 67198);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10889_67004_67055_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 67004, 67055);
                    return return_v;
                }


                int
                f_10889_67420_67440(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param, int
                slot)
                {
                    this_param.Unassign(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 67420, 67440);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier
                f_10889_67464_67484(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 67464, 67484);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 66352, 67511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 66352, 67511);
            }
        }

        private void SetSlotUnassigned(int slot)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 67523, 67867);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 67588, 67800) || true) && (NonMonotonicState.HasValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 67588, 67800);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 67652, 67688);

                    var
                    state = NonMonotonicState.Value
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 67706, 67741);

                    f_10889_67706_67740(this, slot, ref state);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 67759, 67785);

                    NonMonotonicState = state;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 67588, 67800);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 67816, 67856);

                f_10889_67816_67855(this, slot, ref this.State);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 67523, 67867);

                int
                f_10889_67706_67740(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                slot, ref Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                state)
                {
                    this_param.SetSlotUnassigned(slot, ref state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 67706, 67740);
                    return 0;
                }


                int
                f_10889_67816_67855(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                slot, ref Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                state)
                {
                    this_param.SetSlotUnassigned(slot, ref state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 67816, 67855);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 67523, 67867);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 67523, 67867);
            }
        }

        protected override LocalState TopState()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 67879, 67994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 67944, 67983);

                return f_10889_67951_67982(BitVector.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 67879, 67994);

                Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                f_10889_67951_67982(Microsoft.CodeAnalysis.BitVector
                assigned)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState(assigned);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 67951, 67982);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 67879, 67994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 67879, 67994);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override LocalState ReachableBottomState()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 68006, 68259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 68083, 68151);

                var
                result = f_10889_68096_68150(BitVector.AllSet(f_10889_68128_68148(variableBySlot)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 68165, 68192);

                result.Assigned[0] = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 68234, 68248);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 68006, 68259);

                int
                f_10889_68128_68148(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 68128, 68148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                f_10889_68096_68150(Microsoft.CodeAnalysis.BitVector
                assigned)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState(assigned);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 68096, 68150);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 68006, 68259);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 68006, 68259);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void EnterParameter(ParameterSymbol parameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 68271, 69008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 68361, 68399);

                int
                slot = f_10889_68372_68398(this, parameter)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 68413, 68997) || true) && (f_10889_68417_68434(parameter) == RefKind.Out && (DynAbs.Tracing.TraceSender.Expression_True(10889, 68417, 68529) && !(this.CurrentSymbol is MethodSymbol currentMethod && (DynAbs.Tracing.TraceSender.Expression_True(10889, 68455, 68528) && f_10889_68507_68528(currentMethod)))))
                ) // out parameters not allowed in async

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 68413, 68997);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 68602, 68692) || true) && (slot > 0)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 68602, 68692);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 68616, 68692);

                        f_10889_68616_68691(this, slot, f_10889_68635_68682_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(initiallyAssignedVariables, 10889, 68635, 68682)?.Contains(parameter)) == true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 68602, 68692);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 68413, 68997);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 68413, 68997);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 68879, 68918) || true) && (slot > 0)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 68879, 68918);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 68893, 68918);

                        f_10889_68893_68917(this, slot, true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 68879, 68918);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 68936, 68982);

                    f_10889_68936_68981(this, parameter, value: null, read: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 68413, 68997);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 68271, 69008);

                int
                f_10889_68372_68398(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol)
                {
                    var return_v = this_param.GetOrCreateSlot((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 68372, 68398);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10889_68417_68434(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 68417, 68434);
                    return return_v;
                }


                bool
                f_10889_68507_68528(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 68507, 68528);
                    return return_v;
                }


                bool?
                f_10889_68635_68682_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 68635, 68682);
                    return return_v;
                }


                int
                f_10889_68616_68691(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                slot, bool
                assigned)
                {
                    this_param.SetSlotState(slot, assigned);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 68616, 68691);
                    return 0;
                }


                int
                f_10889_68893_68917(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                slot, bool
                assigned)
                {
                    this_param.SetSlotState(slot, assigned);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 68893, 68917);
                    return 0;
                }


                int
                f_10889_68936_68981(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                variable, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, bool
                read)
                {
                    this_param.NoteWrite((Microsoft.CodeAnalysis.CSharp.Symbol)variable, value: value, read: read);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 68936, 68981);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 68271, 69008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 68271, 69008);
            }
        }

        protected override void LeaveParameters(ImmutableArray<ParameterSymbol> parameters, SyntaxNode syntax, Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 69020, 69481);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 69166, 69205);

                f_10889_69166_69204(!this.IsConditionalState);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 69219, 69405) || true) && (f_10889_69223_69244_M(!this.State.Reachable))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 69219, 69405);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 69383, 69390);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 69219, 69405);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 69419, 69470);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.LeaveParameters(parameters, syntax, location), 10889, 69419, 69469);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 69020, 69481);

                int
                f_10889_69166_69204(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 69166, 69204);
                    return 0;
                }


                bool
                f_10889_69223_69244_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 69223, 69244);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 69020, 69481);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 69020, 69481);
            }
        }

        protected override void LeaveParameter(ParameterSymbol parameter, SyntaxNode syntax, Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 69493, 69974);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 69621, 69963) || true) && (f_10889_69625_69642(parameter) != RefKind.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 69621, 69963);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 69692, 69727);

                    var
                    slot = f_10889_69703_69726(this, parameter)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 69745, 69908) || true) && (slot > 0 && (DynAbs.Tracing.TraceSender.Expression_True(10889, 69749, 69789) && !f_10889_69762_69789(this.State, slot)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 69745, 69908);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 69831, 69889);

                        f_10889_69831_69888(this, parameter, syntax, location);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 69745, 69908);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 69928, 69948);

                    f_10889_69928_69947(this, parameter);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 69621, 69963);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 69493, 69974);

                Microsoft.CodeAnalysis.RefKind
                f_10889_69625_69642(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 69625, 69642);
                    return return_v;
                }


                int
                f_10889_69703_69726(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol)
                {
                    var return_v = this_param.VariableSlot((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 69703, 69726);
                    return return_v;
                }


                bool
                f_10889_69762_69789(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param, int
                slot)
                {
                    var return_v = this_param.IsAssigned(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 69762, 69789);
                    return return_v;
                }


                int
                f_10889_69831_69888(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.Location
                location)
                {
                    this_param.ReportUnassignedOutParameter(parameter, node, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 69831, 69888);
                    return 0;
                }


                int
                f_10889_69928_69947(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                variable)
                {
                    this_param.NoteRead((Microsoft.CodeAnalysis.CSharp.Symbol)variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 69928, 69947);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 69493, 69974);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 69493, 69974);
            }
        }

        protected override LocalState UnreachableState()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 69986, 70216);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 70059, 70098);

                LocalState
                result = f_10889_70079_70097(this.State)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 70112, 70146);

                result.Assigned.EnsureCapacity(1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 70160, 70177);

                f_10889_70160_70176(result, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 70191, 70205);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 69986, 70216);

                Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                f_10889_70079_70097(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 70079, 70097);
                    return return_v;
                }


                int
                f_10889_70160_70176(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param, int
                slot)
                {
                    this_param.Assign(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 70160, 70176);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 69986, 70216);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 69986, 70216);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void VisitPattern(BoundPattern pattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 70256, 70558);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 70336, 70363);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitPattern(pattern), 10889, 70336, 70362);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 70377, 70407);

                var
                whenFail = StateWhenFalse
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 70421, 70445);

                f_10889_70421_70444(this, StateWhenTrue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 70459, 70491);

                f_10889_70459_70490(this, pattern);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 70505, 70547);

                f_10889_70505_70546(this, this.State, whenFail);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 70256, 70558);

                int
                f_10889_70421_70444(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 70421, 70444);
                    return 0;
                }


                int
                f_10889_70459_70490(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern)
                {
                    this_param.AssignPatternVariables(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 70459, 70490);
                    return 0;
                }


                int
                f_10889_70505_70546(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                whenTrue, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                whenFalse)
                {
                    this_param.SetConditionalState(whenTrue, whenFalse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 70505, 70546);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 70256, 70558);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 70256, 70558);
            }
        }

        private void AssignPatternVariables(BoundPattern pattern, bool definitely = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 70805, 74068);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 70911, 74057);

                switch (f_10889_70919_70931(pattern))
                {

                    case BoundKind.DeclarationPattern:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 70911, 74057);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 71048, 71091);

                            var
                            pat = (BoundDeclarationPattern)pattern
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 71117, 71214) || true) && (definitely)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 71117, 71214);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 71162, 71214);

                                f_10889_71162_71213(this, pat, value: null, isRef: false, read: false);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 71117, 71214);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10889, 71240, 71246);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 70911, 74057);

                    case BoundKind.DiscardPattern:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 70911, 74057);
                        DynAbs.Tracing.TraceSender.TraceBreak(10889, 71339, 71345);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 70911, 74057);

                    case BoundKind.ConstantPattern:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 70911, 74057);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 71443, 71483);

                            var
                            pat = (BoundConstantPattern)pattern
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 71509, 71537);

                            f_10889_71509_71536(this, f_10889_71526_71535(pat));
                            DynAbs.Tracing.TraceSender.TraceBreak(10889, 71563, 71569);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 70911, 74057);

                    case BoundKind.RecursivePattern:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 70911, 74057);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 71691, 71732);

                            var
                            pat = (BoundRecursivePattern)pattern
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 71758, 72072) || true) && (f_10889_71762_71798_M(!pat.Deconstruction.IsDefaultOrEmpty))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 71758, 72072);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 71856, 72045);
                                    foreach (var subpat in f_10889_71879_71897_I(f_10889_71879_71897(pat)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 71856, 72045);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 71963, 72014);

                                        f_10889_71963_72013(this, f_10889_71986_72000(subpat), definitely);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 71856, 72045);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 190);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 190);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 71758, 72072);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 72098, 72410) || true) && (f_10889_72102_72134_M(!pat.Properties.IsDefaultOrEmpty))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 72098, 72410);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 72192, 72383);
                                    foreach (BoundSubpattern sub in f_10889_72224_72238_I(f_10889_72224_72238(pat)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 72192, 72383);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 72304, 72352);

                                        f_10889_72304_72351(this, f_10889_72327_72338(sub), definitely);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 72192, 72383);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 192);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 192);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 72098, 72410);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 72436, 72513) || true) && (definitely)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 72436, 72513);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 72481, 72513);

                                f_10889_72481_72512(this, pat, null, false, false);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 72436, 72513);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10889, 72539, 72545);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 70911, 74057);

                    case BoundKind.ITuplePattern:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 70911, 74057);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 72664, 72702);

                            var
                            pat = (BoundITuplePattern)pattern
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 72728, 72902);
                                foreach (var subpat in f_10889_72751_72766_I(f_10889_72751_72766(pat)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 72728, 72902);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 72824, 72875);

                                    f_10889_72824_72874(this, f_10889_72847_72861(subpat), definitely);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 72728, 72902);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 175);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 175);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10889, 72928, 72934);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 70911, 74057);

                    case BoundKind.TypePattern:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 70911, 74057);
                        DynAbs.Tracing.TraceSender.TraceBreak(10889, 73024, 73030);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 70911, 74057);

                    case BoundKind.RelationalPattern:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 70911, 74057);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 73130, 73172);

                            var
                            pat = (BoundRelationalPattern)pattern
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 73198, 73226);

                            f_10889_73198_73225(this, f_10889_73215_73224(pat));
                            DynAbs.Tracing.TraceSender.TraceBreak(10889, 73252, 73258);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 70911, 74057);

                    case BoundKind.NegatedPattern:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 70911, 74057);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 73378, 73417);

                            var
                            pat = (BoundNegatedPattern)pattern
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 73443, 73498);

                            f_10889_73443_73497(this, f_10889_73466_73477(pat), definitely: false);
                            DynAbs.Tracing.TraceSender.TraceBreak(10889, 73524, 73530);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 70911, 74057);

                    case BoundKind.BinaryPattern:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 70911, 74057);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 73649, 73687);

                            var
                            pat = (BoundBinaryPattern)pattern
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 73713, 73755);

                            bool
                            def = definitely && (DynAbs.Tracing.TraceSender.Expression_True(10889, 73724, 73754) && f_10889_73738_73754_M(!pat.Disjunction))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 73781, 73819);

                            f_10889_73781_73818(this, f_10889_73804_73812(pat), def);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 73845, 73884);

                            f_10889_73845_73883(this, f_10889_73868_73877(pat), def);
                            DynAbs.Tracing.TraceSender.TraceBreak(10889, 73910, 73916);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 70911, 74057);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 70911, 74057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 73987, 74042);

                        throw f_10889_73993_74041(f_10889_74028_74040(pattern));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 70911, 74057);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 70805, 74068);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10889_70919_70931(Microsoft.CodeAnalysis.CSharp.BoundPattern
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 70919, 70931);
                    return return_v;
                }


                int
                f_10889_71162_71213(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDeclarationPattern
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, bool
                isRef, bool
                read)
                {
                    this_param.Assign((Microsoft.CodeAnalysis.CSharp.BoundNode)node, value: value, isRef: isRef, read: read);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 71162, 71213);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10889_71526_71535(Microsoft.CodeAnalysis.CSharp.BoundConstantPattern
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 71526, 71535);
                    return return_v;
                }


                int
                f_10889_71509_71536(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 71509, 71536);
                    return 0;
                }


                bool
                f_10889_71762_71798_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 71762, 71798);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                f_10889_71879_71897(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.Deconstruction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 71879, 71897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10889_71986_72000(Microsoft.CodeAnalysis.CSharp.BoundSubpattern
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 71986, 72000);
                    return return_v;
                }


                int
                f_10889_71963_72013(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, bool
                definitely)
                {
                    this_param.AssignPatternVariables(pattern, definitely);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 71963, 72013);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                f_10889_71879_71897_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 71879, 71897);
                    return return_v;
                }


                bool
                f_10889_72102_72134_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 72102, 72134);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                f_10889_72224_72238(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 72224, 72238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10889_72327_72338(Microsoft.CodeAnalysis.CSharp.BoundSubpattern
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 72327, 72338);
                    return return_v;
                }


                int
                f_10889_72304_72351(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, bool
                definitely)
                {
                    this_param.AssignPatternVariables(pattern, definitely);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 72304, 72351);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                f_10889_72224_72238_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 72224, 72238);
                    return return_v;
                }


                int
                f_10889_72481_72512(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, bool
                isRef, bool
                read)
                {
                    this_param.Assign((Microsoft.CodeAnalysis.CSharp.BoundNode)node, value, isRef, read);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 72481, 72512);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                f_10889_72751_72766(Microsoft.CodeAnalysis.CSharp.BoundITuplePattern
                this_param)
                {
                    var return_v = this_param.Subpatterns;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 72751, 72766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10889_72847_72861(Microsoft.CodeAnalysis.CSharp.BoundSubpattern
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 72847, 72861);
                    return return_v;
                }


                int
                f_10889_72824_72874(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, bool
                definitely)
                {
                    this_param.AssignPatternVariables(pattern, definitely);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 72824, 72874);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                f_10889_72751_72766_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 72751, 72766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10889_73215_73224(Microsoft.CodeAnalysis.CSharp.BoundRelationalPattern
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 73215, 73224);
                    return return_v;
                }


                int
                f_10889_73198_73225(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 73198, 73225);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10889_73466_73477(Microsoft.CodeAnalysis.CSharp.BoundNegatedPattern
                this_param)
                {
                    var return_v = this_param.Negated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 73466, 73477);
                    return return_v;
                }


                int
                f_10889_73443_73497(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, bool
                definitely)
                {
                    this_param.AssignPatternVariables(pattern, definitely: definitely);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 73443, 73497);
                    return 0;
                }


                bool
                f_10889_73738_73754_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 73738, 73754);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10889_73804_73812(Microsoft.CodeAnalysis.CSharp.BoundBinaryPattern
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 73804, 73812);
                    return return_v;
                }


                int
                f_10889_73781_73818(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, bool
                definitely)
                {
                    this_param.AssignPatternVariables(pattern, definitely);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 73781, 73818);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10889_73868_73877(Microsoft.CodeAnalysis.CSharp.BoundBinaryPattern
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 73868, 73877);
                    return return_v;
                }


                int
                f_10889_73845_73883(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, bool
                definitely)
                {
                    this_param.AssignPatternVariables(pattern, definitely);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 73845, 73883);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10889_74028_74040(Microsoft.CodeAnalysis.CSharp.BoundPattern
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 74028, 74040);
                    return return_v;
                }


                System.Exception
                f_10889_73993_74041(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 73993, 74041);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 70805, 74068);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 70805, 74068);
            }
        }

        public override BoundNode VisitBlock(BoundBlock node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 74080, 74690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 74158, 74188);

                f_10889_74158_74187(this, f_10889_74175_74186(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 74204, 74244);

                f_10889_74204_74243(this, node);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 74367, 74543);
                    foreach (var local in f_10889_74389_74400_I(f_10889_74389_74400(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 74367, 74543);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 74434, 74528) || true) && (f_10889_74438_74451(local))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 74434, 74528);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 74493, 74509);

                            f_10889_74493_74508(this, local);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 74434, 74528);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 74367, 74543);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 177);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 177);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 74559, 74594);

                f_10889_74559_74593(this, f_10889_74581_74592(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 74608, 74651);

                f_10889_74608_74650(this, f_10889_74630_74649(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 74667, 74679);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 74080, 74690);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_74175_74186(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 74175, 74186);
                    return return_v;
                }


                int
                f_10889_74158_74187(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    this_param.DeclareVariables(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 74158, 74187);
                    return 0;
                }


                int
                f_10889_74204_74243(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                block)
                {
                    this_param.VisitStatementsWithLocalFunctions(block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 74204, 74243);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_74389_74400(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 74389, 74400);
                    return return_v;
                }


                bool
                f_10889_74438_74451(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.IsUsing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 74438, 74451);
                    return return_v;
                }


                int
                f_10889_74493_74508(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                variable)
                {
                    this_param.NoteRead((Microsoft.CodeAnalysis.CSharp.Symbol)variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 74493, 74508);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_74389_74400_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 74389, 74400);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_74581_74592(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 74581, 74592);
                    return return_v;
                }


                int
                f_10889_74559_74593(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    this_param.ReportUnusedVariables(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 74559, 74593);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10889_74630_74649(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.LocalFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 74630, 74649);
                    return return_v;
                }


                int
                f_10889_74608_74650(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                locals)
                {
                    this_param.ReportUnusedVariables(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 74608, 74650);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 74080, 74690);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 74080, 74690);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void VisitStatementsWithLocalFunctions(BoundBlock block)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 74702, 76467);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 74791, 76456) || true) && (!TrackingRegions && (DynAbs.Tracing.TraceSender.Expression_True(10889, 74795, 74853) && f_10889_74815_74853_M(!block.LocalFunctions.IsDefaultOrEmpty)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 74791, 76456);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 75724, 75962);
                        foreach (var stmt in f_10889_75745_75761_I(f_10889_75745_75761(block)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 75724, 75962);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 75803, 75943) || true) && (f_10889_75807_75816(stmt) == BoundKind.LocalFunctionStatement)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 75803, 75943);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 75902, 75920);

                                f_10889_75902_75919(this, stmt);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 75803, 75943);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 75724, 75962);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 239);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 239);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 76015, 76256);
                        foreach (var stmt in f_10889_76036_76052_I(f_10889_76036_76052(block)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 76015, 76256);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 76094, 76237) || true) && (f_10889_76098_76107(stmt) != BoundKind.LocalFunctionStatement)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 76094, 76237);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 76193, 76214);

                                f_10889_76193_76213(this, stmt);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 76094, 76237);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 76015, 76256);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 242);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 242);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 74791, 76456);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 74791, 76456);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 76322, 76441);
                        foreach (var stmt in f_10889_76343_76359_I(f_10889_76343_76359(block)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 76322, 76441);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 76401, 76422);

                            f_10889_76401_76421(this, stmt);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 76322, 76441);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 120);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 120);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 74791, 76456);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 74702, 76467);

                bool
                f_10889_74815_74853_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 74815, 74853);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10889_75745_75761(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 75745, 75761);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10889_75807_75816(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 75807, 75816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10889_75902_75919(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = this_param.VisitAlways((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 75902, 75919);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10889_75745_75761_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 75745, 75761);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10889_76036_76052(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 76036, 76052);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10889_76098_76107(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 76098, 76107);
                    return return_v;
                }


                int
                f_10889_76193_76213(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.VisitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 76193, 76213);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10889_76036_76052_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 76036, 76052);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10889_76343_76359(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 76343, 76359);
                    return return_v;
                }


                int
                f_10889_76401_76421(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.VisitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 76401, 76421);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10889_76343_76359_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 76343, 76359);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 74702, 76467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 74702, 76467);
            }
        }

        public override BoundNode VisitSwitchStatement(BoundSwitchStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 76479, 76826);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 76577, 76612);

                f_10889_76577_76611(this, f_10889_76594_76610(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 76626, 76671);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitSwitchStatement(node), 10889, 76639, 76670)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 76685, 76725);

                f_10889_76685_76724(this, f_10889_76707_76723(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 76739, 76787);

                f_10889_76739_76786(this, f_10889_76761_76785(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 76801, 76815);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 76479, 76826);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_76594_76610(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.InnerLocals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 76594, 76610);
                    return return_v;
                }


                int
                f_10889_76577_76611(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    this_param.DeclareVariables(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 76577, 76611);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_76707_76723(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.InnerLocals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 76707, 76723);
                    return return_v;
                }


                int
                f_10889_76685_76724(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    this_param.ReportUnusedVariables(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 76685, 76724);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10889_76761_76785(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.InnerLocalFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 76761, 76785);
                    return return_v;
                }


                int
                f_10889_76739_76786(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                locals)
                {
                    this_param.ReportUnusedVariables(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 76739, 76786);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 76479, 76826);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 76479, 76826);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void VisitSwitchSection(BoundSwitchSection node, bool isLastSection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 76838, 77050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 76950, 76980);

                f_10889_76950_76979(this, f_10889_76967_76978(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 76994, 77039);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitSwitchSection(node, isLastSection), 10889, 76994, 77038);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 76838, 77050);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_76967_76978(Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 76967, 76978);
                    return return_v;
                }


                int
                f_10889_76950_76979(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    this_param.DeclareVariables(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 76950, 76979);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 76838, 77050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 76838, 77050);
            }
        }

        public override BoundNode VisitForStatement(BoundForStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 77062, 77441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 77154, 77189);

                f_10889_77154_77188(this, f_10889_77171_77187(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 77203, 77238);

                f_10889_77203_77237(this, f_10889_77220_77236(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 77252, 77294);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitForStatement(node), 10889, 77265, 77293)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 77308, 77348);

                f_10889_77308_77347(this, f_10889_77330_77346(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 77362, 77402);

                f_10889_77362_77401(this, f_10889_77384_77400(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 77416, 77430);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 77062, 77441);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_77171_77187(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                this_param)
                {
                    var return_v = this_param.OuterLocals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 77171, 77187);
                    return return_v;
                }


                int
                f_10889_77154_77188(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    this_param.DeclareVariables(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 77154, 77188);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_77220_77236(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                this_param)
                {
                    var return_v = this_param.InnerLocals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 77220, 77236);
                    return return_v;
                }


                int
                f_10889_77203_77237(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    this_param.DeclareVariables(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 77203, 77237);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_77330_77346(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                this_param)
                {
                    var return_v = this_param.InnerLocals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 77330, 77346);
                    return return_v;
                }


                int
                f_10889_77308_77347(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    this_param.ReportUnusedVariables(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 77308, 77347);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_77384_77400(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                this_param)
                {
                    var return_v = this_param.OuterLocals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 77384, 77400);
                    return return_v;
                }


                int
                f_10889_77362_77401(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    this_param.ReportUnusedVariables(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 77362, 77401);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 77062, 77441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 77062, 77441);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDoStatement(BoundDoStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 77453, 77716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 77543, 77573);

                f_10889_77543_77572(this, f_10889_77560_77571(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 77587, 77628);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitDoStatement(node), 10889, 77600, 77627)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 77642, 77677);

                f_10889_77642_77676(this, f_10889_77664_77675(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 77691, 77705);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 77453, 77716);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_77560_77571(Microsoft.CodeAnalysis.CSharp.BoundDoStatement
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 77560, 77571);
                    return return_v;
                }


                int
                f_10889_77543_77572(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    this_param.DeclareVariables(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 77543, 77572);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_77664_77675(Microsoft.CodeAnalysis.CSharp.BoundDoStatement
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 77664, 77675);
                    return return_v;
                }


                int
                f_10889_77642_77676(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    this_param.ReportUnusedVariables(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 77642, 77676);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 77453, 77716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 77453, 77716);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitWhileStatement(BoundWhileStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 77728, 78000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 77824, 77854);

                f_10889_77824_77853(this, f_10889_77841_77852(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 77868, 77912);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitWhileStatement(node), 10889, 77881, 77911)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 77926, 77961);

                f_10889_77926_77960(this, f_10889_77948_77959(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 77975, 77989);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 77728, 78000);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_77841_77852(Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 77841, 77852);
                    return return_v;
                }


                int
                f_10889_77824_77853(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    this_param.DeclareVariables(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 77824, 77853);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_77948_77959(Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 77948, 77959);
                    return return_v;
                }


                int
                f_10889_77926_77960(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    this_param.ReportUnusedVariables(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 77926, 77960);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 77728, 78000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 77728, 78000);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitUsingStatement(BoundUsingStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 78167, 78957);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 78263, 78291);

                var
                localsOpt = f_10889_78279_78290(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 78305, 78333);

                f_10889_78305_78332(this, localsOpt);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 78347, 78391);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitUsingStatement(node), 10889, 78360, 78390)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 78405, 78916) || true) && (f_10889_78409_78436_M(!localsOpt.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 78405, 78916);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 78470, 78901);
                        foreach (LocalSymbol local in f_10889_78500_78509_I(localsOpt))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 78470, 78901);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 78551, 78882) || true) && (f_10889_78555_78576(local) == LocalDeclarationKind.UsingVariable)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 78551, 78882);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 78772, 78788);

                                f_10889_78772_78787(this, local);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 78814, 78859);

                                f_10889_78814_78858(f_10889_78827_78857(_usedVariables, local));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 78551, 78882);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 78470, 78901);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 432);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 432);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 78405, 78916);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 78932, 78946);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 78167, 78957);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_78279_78290(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 78279, 78290);
                    return return_v;
                }


                int
                f_10889_78305_78332(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    this_param.DeclareVariables(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 78305, 78332);
                    return 0;
                }


                bool
                f_10889_78409_78436_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 78409, 78436);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                f_10889_78555_78576(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.DeclarationKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 78555, 78576);
                    return return_v;
                }


                int
                f_10889_78772_78787(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                variable)
                {
                    this_param.NoteRead((Microsoft.CodeAnalysis.CSharp.Symbol)variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 78772, 78787);
                    return 0;
                }


                bool
                f_10889_78827_78857(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 78827, 78857);
                    return return_v;
                }


                int
                f_10889_78814_78858(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 78814, 78858);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_78500_78509_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 78500, 78509);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 78167, 78957);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 78167, 78957);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitFixedStatement(BoundFixedStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 78969, 79158);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 79065, 79095);

                f_10889_79065_79094(this, f_10889_79082_79093(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 79109, 79147);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitFixedStatement(node), 10889, 79116, 79146);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 78969, 79158);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_79082_79093(Microsoft.CodeAnalysis.CSharp.BoundFixedStatement
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 79082, 79093);
                    return return_v;
                }


                int
                f_10889_79065_79094(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    this_param.DeclareVariables(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 79065, 79094);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 78969, 79158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 78969, 79158);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitSequence(BoundSequence node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 79170, 79424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 79254, 79284);

                f_10889_79254_79283(this, f_10889_79271_79282(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 79298, 79336);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitSequence(node), 10889, 79311, 79335)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 79350, 79385);

                f_10889_79350_79384(this, f_10889_79372_79383(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 79399, 79413);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 79170, 79424);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_79271_79282(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 79271, 79282);
                    return return_v;
                }


                int
                f_10889_79254_79283(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    this_param.DeclareVariables(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 79254, 79283);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_79372_79383(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 79372, 79383);
                    return return_v;
                }


                int
                f_10889_79350_79384(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    this_param.ReportUnusedVariables(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 79350, 79384);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 79170, 79424);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 79170, 79424);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void DeclareVariables(ImmutableArray<LocalSymbol> locals)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 79436, 79639);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 79526, 79628);
                    foreach (var symbol in f_10889_79549_79555_I(locals))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 79526, 79628);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 79589, 79613);

                        f_10889_79589_79612(this, symbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 79526, 79628);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 103);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 79436, 79639);

                int
                f_10889_79589_79612(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol)
                {
                    this_param.DeclareVariable(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 79589, 79612);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_79549_79555_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 79549, 79555);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 79436, 79639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 79436, 79639);
            }
        }

        private void DeclareVariable(LocalSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 79651, 80168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 79724, 80086);

                var
                initiallyAssigned =
                f_10889_79765_79779(symbol) || (DynAbs.Tracing.TraceSender.Expression_False(10889, 79765, 80085) || f_10889_80033_80077_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(initiallyAssignedVariables, 10889, 80033, 80077)?.Contains(symbol)) == true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 80100, 80157);

                f_10889_80100_80156(this, f_10889_80113_80136(this, symbol), initiallyAssigned);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 79651, 80168);

                bool
                f_10889_79765_79779(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.IsConst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 79765, 79779);
                    return return_v;
                }


                bool?
                f_10889_80033_80077_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 80033, 80077);
                    return return_v;
                }


                int
                f_10889_80113_80136(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol)
                {
                    var return_v = this_param.GetOrCreateSlot((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 80113, 80136);
                    return return_v;
                }


                int
                f_10889_80100_80156(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                slot, bool
                assigned)
                {
                    this_param.SetSlotState(slot, assigned);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 80100, 80156);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 79651, 80168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 79651, 80168);
            }
        }

        private void ReportUnusedVariables(ImmutableArray<LocalSymbol> locals)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 80180, 80403);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 80275, 80392);
                    foreach (var symbol in f_10889_80298_80304_I(locals))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 80275, 80392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 80338, 80377);

                        f_10889_80338_80376(this, symbol, assigned: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 80275, 80392);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 118);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 118);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 80180, 80403);

                int
                f_10889_80338_80376(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol, bool
                assigned)
                {
                    this_param.ReportIfUnused(symbol, assigned: assigned);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 80338, 80376);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_80298_80304_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 80298, 80304);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 80180, 80403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 80180, 80403);
            }
        }

        private void ReportIfUnused(LocalSymbol symbol, bool assigned)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 80415, 80987);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 80502, 80976) || true) && (!f_10889_80507_80538(_usedVariables, symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 80502, 80976);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 80572, 80961) || true) && (f_10889_80576_80598(symbol) != LocalDeclarationKind.PatternVariable && (DynAbs.Tracing.TraceSender.Expression_True(10889, 80576, 80676) && !f_10889_80643_80676(f_10889_80664_80675(symbol))))
                    ) // avoid diagnostics for parser-inserted names

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 80572, 80961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 80765, 80942);

                        f_10889_80765_80941(f_10889_80765_80776(), (DynAbs.Tracing.TraceSender.Conditional_F1(10889, 80781, 80827) || ((assigned && (DynAbs.Tracing.TraceSender.Expression_True(10889, 80781, 80827) && f_10889_80793_80827(_writtenVariables, symbol)) && DynAbs.Tracing.TraceSender.Conditional_F2(10889, 80830, 80863)) || DynAbs.Tracing.TraceSender.Conditional_F3(10889, 80866, 80895))) ? ErrorCode.WRN_UnreferencedVarAssg : ErrorCode.WRN_UnreferencedVar, symbol.Locations.FirstOrNone(), f_10889_80929_80940(symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 80572, 80961);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 80502, 80976);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 80415, 80987);

                bool
                f_10889_80507_80538(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 80507, 80538);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                f_10889_80576_80598(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.DeclarationKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 80576, 80598);
                    return return_v;
                }


                string
                f_10889_80664_80675(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 80664, 80675);
                    return return_v;
                }


                bool
                f_10889_80643_80676(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 80643, 80676);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10889_80765_80776()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 80765, 80776);
                    return return_v;
                }


                bool
                f_10889_80793_80827(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = this_param.Contains((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 80793, 80827);
                    return return_v;
                }


                string
                f_10889_80929_80940(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 80929, 80940);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10889_80765_80941(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 80765, 80941);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 80415, 80987);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 80415, 80987);
            }
        }

        private void ReportUnusedVariables(ImmutableArray<LocalFunctionSymbol> locals)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 80999, 81214);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 81102, 81203);
                    foreach (var symbol in f_10889_81125_81131_I(locals))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 81102, 81203);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 81165, 81188);

                        f_10889_81165_81187(this, symbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 81102, 81203);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 102);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 102);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 80999, 81214);

                int
                f_10889_81165_81187(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                symbol)
                {
                    this_param.ReportIfUnused(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 81165, 81187);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10889_81125_81131_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 81125, 81131);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 80999, 81214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 80999, 81214);
            }
        }

        private void ReportIfUnused(LocalFunctionSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 81226, 81655);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 81306, 81644) || true) && (!f_10889_81311_81347(_usedLocalFunctions, symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 81306, 81644);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 81381, 81629) || true) && (!f_10889_81386_81419(f_10889_81407_81418(symbol)))
                    ) // avoid diagnostics for parser-inserted names

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 81381, 81629);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 81508, 81610);

                        f_10889_81508_81609(f_10889_81508_81519(), ErrorCode.WRN_UnreferencedLocalFunction, symbol.Locations.FirstOrNone(), f_10889_81597_81608(symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 81381, 81629);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 81306, 81644);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 81226, 81655);

                bool
                f_10889_81311_81347(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 81311, 81347);
                    return return_v;
                }


                string
                f_10889_81407_81418(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 81407, 81418);
                    return return_v;
                }


                bool
                f_10889_81386_81419(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 81386, 81419);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10889_81508_81519()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 81508, 81519);
                    return return_v;
                }


                string
                f_10889_81597_81608(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 81597, 81608);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10889_81508_81609(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 81508, 81609);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 81226, 81655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 81226, 81655);
            }
        }

        public override BoundNode VisitLocal(BoundLocal node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 81667, 83316);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 81745, 81788);

                LocalSymbol
                localSymbol = f_10889_81771_81787(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 81825, 81880);

                var
                tempLocalSymbol = localSymbol as SourceLocalSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 81894, 82464) || true) && (tempLocalSymbol != null && (DynAbs.Tracing.TraceSender.Expression_True(10889, 81898, 81946) && f_10889_81925_81946(tempLocalSymbol)) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 81898, 82005) && f_10889_81968_81997(tempLocalSymbol) != null) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 81898, 82060) && f_10889_82009_82060(f_10889_82009_82038(tempLocalSymbol), node.Syntax)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 81894, 82464);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 82283, 82328);

                    int
                    slot = f_10889_82294_82327(this, f_10889_82310_82326(node))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 82346, 82449) || true) && (slot > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 82346, 82449);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 82400, 82430);

                        _alreadyReported[slot] = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 82346, 82449);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 81894, 82464);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 82789, 82829);

                f_10889_82789_82828(this, localSymbol, node.Syntax);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 82845, 83279) || true) && (f_10889_82849_82868(localSymbol) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 82849, 82920) && this.CurrentSymbol is MethodSymbol currentMethod) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 82849, 83073) && (f_10889_82942_82966(currentMethod) == MethodKind.AnonymousFunction || (DynAbs.Tracing.TraceSender.Expression_False(10889, 82942, 83072) || f_10889_83020_83044(currentMethod) == MethodKind.LocalFunction))) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 82849, 83134) && f_10889_83094_83134(_capturedVariables, localSymbol)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 82845, 83279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 83168, 83264);

                    f_10889_83168_83263(f_10889_83168_83179(), ErrorCode.ERR_FixedLocalInLambda, f_10889_83218_83249(node.Syntax), localSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 82845, 83279);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 83293, 83305);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 81667, 83316);

                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10889_81771_81787(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 81771, 81787);
                    return return_v;
                }


                bool
                f_10889_81925_81946(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                this_param)
                {
                    var return_v = this_param.IsVar;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 81925, 81946);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10889_81968_81997(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                this_param)
                {
                    var return_v = this_param.ForbiddenZone;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 81968, 81997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10889_82009_82038(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                this_param)
                {
                    var return_v = this_param.ForbiddenZone;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 82009, 82038);
                    return return_v;
                }


                bool
                f_10889_82009_82060(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.Contains(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 82009, 82060);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10889_82310_82326(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 82310, 82326);
                    return return_v;
                }


                int
                f_10889_82294_82327(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol)
                {
                    var return_v = this_param.GetOrCreateSlot((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 82294, 82327);
                    return return_v;
                }


                int
                f_10889_82789_82828(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    this_param.CheckAssigned((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 82789, 82828);
                    return 0;
                }


                bool
                f_10889_82849_82868(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.IsFixed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 82849, 82868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10889_82942_82966(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 82942, 82966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10889_83020_83044(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 83020, 83044);
                    return return_v;
                }


                bool
                f_10889_83094_83134(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = this_param.Contains((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 83094, 83134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10889_83168_83179()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 83168, 83179);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10889_83218_83249(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 83218, 83249);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10889_83168_83263(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 83168, 83263);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 81667, 83316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 81667, 83316);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLocalDeclaration(BoundLocalDeclaration node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 83328, 84134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 83428, 83466);

                _ = f_10889_83432_83465(this, f_10889_83448_83464(node));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 83506, 83905) || true) && (f_10889_83510_83564_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(initiallyAssignedVariables, 10889, 83510, 83564)?.Contains(f_10889_83547_83563(node))) == true)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 83506, 83905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 83864, 83890);

                    f_10889_83864_83889(this, node, value: null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 83506, 83905);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 83921, 83967);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLocalDeclaration(node), 10889, 83934, 83966)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 83981, 84095) || true) && (f_10889_83985_84004(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 83981, 84095);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 84046, 84080);

                    f_10889_84046_84079(this, node, f_10889_84059_84078(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 83981, 84095);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 84109, 84123);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 83328, 84134);

                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10889_83448_83464(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 83448, 83464);
                    return return_v;
                }


                int
                f_10889_83432_83465(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol)
                {
                    var return_v = this_param.GetOrCreateSlot((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 83432, 83465);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10889_83547_83563(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 83547, 83563);
                    return return_v;
                }


                bool?
                f_10889_83510_83564_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 83510, 83564);
                    return return_v;
                }


                int
                f_10889_83864_83889(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    this_param.Assign((Microsoft.CodeAnalysis.CSharp.BoundNode)node, value: value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 83864, 83889);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10889_83985_84004(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                this_param)
                {
                    var return_v = this_param.InitializerOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 83985, 84004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10889_84059_84078(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                this_param)
                {
                    var return_v = this_param.InitializerOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 84059, 84078);
                    return return_v;
                }


                int
                f_10889_84046_84079(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    this_param.Assign((Microsoft.CodeAnalysis.CSharp.BoundNode)node, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 84046, 84079);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 83328, 84134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 83328, 84134);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitMethodGroup(BoundMethodGroup node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 84146, 84543);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 84236, 84483);
                    foreach (var method in f_10889_84259_84271_I(f_10889_84259_84271(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 84236, 84483);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 84305, 84468) || true) && (f_10889_84309_84326(method) == MethodKind.LocalFunction)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 84305, 84468);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 84396, 84449);

                            f_10889_84396_84448(_usedLocalFunctions, method);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 84305, 84468);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 84236, 84483);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 248);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 248);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 84497, 84532);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitMethodGroup(node), 10889, 84504, 84531);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 84146, 84543);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10889_84259_84271(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.Methods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 84259, 84271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10889_84309_84326(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 84309, 84326);
                    return return_v;
                }


                bool
                f_10889_84396_84448(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 84396, 84448);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10889_84259_84271_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 84259, 84271);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 84146, 84543);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 84146, 84543);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLambda(BoundLambda node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 84555, 86401);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 84635, 84670);

                var
                oldSymbol = this.CurrentSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 84684, 84717);

                this.CurrentSymbol = f_10889_84705_84716(node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 84733, 84764);

                var
                oldPending = f_10889_84750_84763(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 84875, 84916);

                LocalState
                stateAfterLambda = this.State
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 84932, 85012);

                this.State = (DynAbs.Tracing.TraceSender.Conditional_F1(10889, 84945, 84965) || ((f_10889_84945_84965(this.State) && DynAbs.Tracing.TraceSender.Conditional_F2(10889, 84968, 84986)) || DynAbs.Tracing.TraceSender.Conditional_F3(10889, 84989, 85011))) ? f_10889_84968_84986(this.State) : f_10889_84989_85011(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 85028, 85100) || true) && (f_10889_85032_85058_M(!node.WasCompilerGenerated))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 85028, 85100);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 85060, 85100);

                    f_10889_85060_85099(this, f_10889_85076_85098(f_10889_85076_85087(node)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 85028, 85100);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 85114, 85146);

                var
                oldPending2 = f_10889_85132_85145(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 85160, 85183);

                f_10889_85160_85182(this, f_10889_85172_85181(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 85197, 85225);

                f_10889_85197_85224(this, oldPending2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 85294, 85357);

                ImmutableArray<PendingBranch>
                pendingReturns = f_10889_85341_85356(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 85371, 85398);

                f_10889_85371_85397(this, oldPending);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 85412, 85471);

                f_10889_85412_85470(this, f_10889_85428_85450(f_10889_85428_85439(node)), node.Syntax, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 85487, 85530);

                f_10889_85487_85529(this, ref stateAfterLambda, ref this.State);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 85581, 86271);
                    foreach (PendingBranch pending in f_10889_85615_85629_I(pendingReturns))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 85581, 86271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 85663, 85690);

                        this.State = pending.State;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 85708, 86156) || true) && (f_10889_85712_85731(pending.Branch) == BoundKind.ReturnStatement)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 85708, 86156);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 85887, 85956);

                            f_10889_85887_85955(this, f_10889_85903_85925(f_10889_85903_85914(node)), pending.Branch.Syntax, null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 85708, 86156);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 85708, 86156);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 85708, 86156);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 86176, 86219);

                        f_10889_86176_86218(this, ref stateAfterLambda, ref this.State);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 85581, 86271);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 691);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 691);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 86287, 86317);

                this.State = stateAfterLambda;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 86333, 86364);

                this.CurrentSymbol = oldSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 86378, 86390);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 84555, 86401);

                Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                f_10889_84705_84716(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 84705, 84716);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.SavedPending
                f_10889_84750_84763(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param)
                {
                    var return_v = this_param.SavePending();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 84750, 84763);
                    return return_v;
                }


                bool
                f_10889_84945_84965(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param)
                {
                    var return_v = this_param.Reachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 84945, 84965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                f_10889_84968_84986(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 84968, 84986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                f_10889_84989_85011(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param)
                {
                    var return_v = this_param.ReachableBottomState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 84989, 85011);
                    return return_v;
                }


                bool
                f_10889_85032_85058_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 85032, 85058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                f_10889_85076_85087(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 85076, 85087);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10889_85076_85098(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 85076, 85098);
                    return return_v;
                }


                int
                f_10889_85060_85099(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters)
                {
                    this_param.EnterParameters(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 85060, 85099);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.SavedPending
                f_10889_85132_85145(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param)
                {
                    var return_v = this_param.SavePending();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 85132, 85145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10889_85172_85181(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 85172, 85181);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10889_85160_85182(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node)
                {
                    var return_v = this_param.VisitAlways((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 85160, 85182);
                    return return_v;
                }


                int
                f_10889_85197_85224(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.SavedPending
                oldPending)
                {
                    this_param.RestorePending(oldPending);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 85197, 85224);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.PendingBranch>
                f_10889_85341_85356(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param)
                {
                    var return_v = this_param.RemoveReturns();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 85341, 85356);
                    return return_v;
                }


                int
                f_10889_85371_85397(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.SavedPending
                oldPending)
                {
                    this_param.RestorePending(oldPending);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 85371, 85397);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                f_10889_85428_85439(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 85428, 85439);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10889_85428_85450(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 85428, 85450);
                    return return_v;
                }


                int
                f_10889_85412_85470(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.Location
                location)
                {
                    this_param.LeaveParameters(parameters, syntax, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 85412, 85470);
                    return 0;
                }


                bool
                f_10889_85487_85529(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, ref Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                self, ref Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 85487, 85529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10889_85712_85731(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 85712, 85731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                f_10889_85903_85914(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 85903, 85914);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10889_85903_85925(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 85903, 85925);
                    return return_v;
                }


                int
                f_10889_85887_85955(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.Location
                location)
                {
                    this_param.LeaveParameters(parameters, syntax, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 85887, 85955);
                    return 0;
                }


                bool
                f_10889_86176_86218(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, ref Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                self, ref Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 86176, 86218);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.PendingBranch>
                f_10889_85615_85629_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.PendingBranch>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 85615, 85629);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 84555, 86401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 84555, 86401);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitThisReference(BoundThisReference node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 86413, 86673);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 86588, 86636);

                f_10889_86588_86635(this, f_10889_86602_86621(), node.Syntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 86650, 86662);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 86413, 86673);

                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10889_86602_86621()
                {
                    var return_v = MethodThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 86602, 86621);
                    return return_v;
                }


                int
                f_10889_86588_86635(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    this_param.CheckAssigned((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 86588, 86635);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 86413, 86673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 86413, 86673);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitParameter(BoundParameter node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 86685, 87058);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 86771, 87019) || true) && (f_10889_86775_86801_M(!node.WasCompilerGenerated))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 86771, 87019);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 86835, 86884);

                    f_10889_86835_86883(this, f_10889_86849_86869(node), node.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 86771, 87019);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 86771, 87019);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 86950, 87004);

                    f_10889_86950_87003(this, f_10889_86982_87002(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 86771, 87019);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 87035, 87047);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 86685, 87058);

                bool
                f_10889_86775_86801_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 86775, 86801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10889_86849_86869(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 86849, 86869);
                    return return_v;
                }


                int
                f_10889_86835_86883(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    this_param.CheckAssigned((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 86835, 86883);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10889_86982_87002(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 86982, 87002);
                    return return_v;
                }


                int
                f_10889_86950_87003(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol)
                {
                    this_param.NoteRecordParameterReadIfNeeded((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 86950, 87003);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 86685, 87058);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 86685, 87058);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitAssignmentOperator(BoundAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 87070, 87309);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 87174, 87209);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitAssignmentOperator(node), 10889, 87174, 87208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 87223, 87272);

                f_10889_87223_87271(this, f_10889_87230_87239(node), f_10889_87241_87251(node), isRef: f_10889_87260_87270(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 87286, 87298);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 87070, 87309);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10889_87230_87239(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 87230, 87239);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10889_87241_87251(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 87241, 87251);
                    return return_v;
                }


                bool
                f_10889_87260_87270(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 87260, 87270);
                    return return_v;
                }


                int
                f_10889_87223_87271(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, bool
                isRef)
                {
                    this_param.Assign((Microsoft.CodeAnalysis.CSharp.BoundNode)node, value, isRef: isRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 87223, 87271);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 87070, 87309);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 87070, 87309);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDeconstructionAssignmentOperator(BoundDeconstructionAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 87321, 87583);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 87453, 87502);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitDeconstructionAssignmentOperator(node), 10889, 87453, 87501);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 87516, 87546);

                f_10889_87516_87545(this, f_10889_87523_87532(node), f_10889_87534_87544(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 87560, 87572);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 87321, 87583);

                Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                f_10889_87523_87532(Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 87523, 87532);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10889_87534_87544(Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 87534, 87544);
                    return return_v;
                }


                int
                f_10889_87516_87545(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                node, Microsoft.CodeAnalysis.CSharp.BoundConversion
                value)
                {
                    this_param.Assign((Microsoft.CodeAnalysis.CSharp.BoundNode)node, (Microsoft.CodeAnalysis.CSharp.BoundExpression)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 87516, 87545);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 87321, 87583);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 87321, 87583);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitIncrementOperator(BoundIncrementOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 87595, 87816);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 87697, 87731);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitIncrementOperator(node), 10889, 87697, 87730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 87745, 87779);

                f_10889_87745_87778(this, f_10889_87752_87764(node), value: node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 87793, 87805);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 87595, 87816);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10889_87752_87764(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 87752, 87764);
                    return return_v;
                }


                int
                f_10889_87745_87778(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
                value)
                {
                    this_param.Assign((Microsoft.CodeAnalysis.CSharp.BoundNode)node, value: (Microsoft.CodeAnalysis.CSharp.BoundExpression)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 87745, 87778);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 87595, 87816);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 87595, 87816);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitCompoundAssignmentOperator(BoundCompoundAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 87828, 88149);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 87948, 87984);

                f_10889_87948_87983(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 87998, 88022);

                f_10889_87998_88021(this, f_10889_88010_88020(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 88036, 88067);

                f_10889_88036_88066(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 88081, 88112);

                f_10889_88081_88111(this, f_10889_88088_88097(node), value: node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 88126, 88138);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 87828, 88149);

                int
                f_10889_87948_87983(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                node)
                {
                    this_param.VisitCompoundAssignmentTarget(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 87948, 87983);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10889_88010_88020(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 88010, 88020);
                    return return_v;
                }


                int
                f_10889_87998_88021(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 87998, 88021);
                    return 0;
                }


                int
                f_10889_88036_88066(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                node)
                {
                    this_param.AfterRightHasBeenVisited(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 88036, 88066);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10889_88088_88097(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 88088, 88097);
                    return return_v;
                }


                int
                f_10889_88081_88111(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                value)
                {
                    this_param.Assign((Microsoft.CodeAnalysis.CSharp.BoundNode)node, value: (Microsoft.CodeAnalysis.CSharp.BoundExpression)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 88081, 88111);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 87828, 88149);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 87828, 88149);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitFixedLocalCollectionInitializer(BoundFixedLocalCollectionInitializer node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 88161, 89073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 88291, 88325);

                var
                initializer = f_10889_88309_88324(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 88341, 88501) || true) && (f_10889_88345_88361(initializer) == BoundKind.AddressOfOperator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 88341, 88501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 88426, 88486);

                    initializer = f_10889_88440_88485(((BoundAddressOfOperator)initializer));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 88341, 88501);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 88975, 89036);

                f_10889_88975_89035(this, initializer, shouldReadOperand: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 89050, 89062);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 88161, 89073);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10889_88309_88324(Microsoft.CodeAnalysis.CSharp.BoundFixedLocalCollectionInitializer
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 88309, 88324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10889_88345_88361(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 88345, 88361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10889_88440_88485(Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 88440, 88485);
                    return return_v;
                }


                int
                f_10889_88975_89035(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, bool
                shouldReadOperand)
                {
                    this_param.VisitAddressOfOperand(operand, shouldReadOperand: shouldReadOperand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 88975, 89035);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 88161, 89073);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 88161, 89073);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitAddressOfOperator(BoundAddressOfOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 89085, 90292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 89187, 89226);

                BoundExpression
                operand = f_10889_89213_89225(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 89240, 89271);

                bool
                shouldReadOperand = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 89287, 89340);

                Symbol
                variable = f_10889_89305_89339(this, operand)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 89354, 90182) || true) && ((object)variable != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 89354, 90182);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 89777, 89966) || true) && (f_10889_89781_89871_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_unassignedVariableAddressOfSyntaxes, 10889, 89781, 89871)?.Contains(node.Syntax as PrefixUnaryExpressionSyntax)) == false)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 89777, 89966);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 89922, 89947);

                        shouldReadOperand = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 89777, 89966);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 89986, 90167) || true) && (!f_10889_89991_90041(_unsafeAddressTakenVariables, variable))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 89986, 90167);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 90083, 90148);

                        f_10889_90083_90147(_unsafeAddressTakenVariables, variable, f_10889_90126_90146(node.Syntax));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 89986, 90167);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 89354, 90182);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 90198, 90253);

                f_10889_90198_90252(this, f_10889_90220_90232(node), shouldReadOperand);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 90269, 90281);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 89085, 90292);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10889_89213_89225(Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 89213, 89225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10889_89305_89339(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.UseNonFieldSymbolUnsafely(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 89305, 89339);
                    return return_v;
                }


                bool?
                f_10889_89781_89871_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 89781, 89871);
                    return return_v;
                }


                bool
                f_10889_89991_90041(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.Location>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 89991, 90041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10889_90126_90146(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 90126, 90146);
                    return return_v;
                }


                int
                f_10889_90083_90147(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.Location>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                key, Microsoft.CodeAnalysis.Location
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 90083, 90147);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10889_90220_90232(Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 90220, 90232);
                    return return_v;
                }


                int
                f_10889_90198_90252(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, bool
                shouldReadOperand)
                {
                    this_param.VisitAddressOfOperand(operand, shouldReadOperand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 90198, 90252);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 89085, 90292);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 89085, 90292);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void WriteArgument(BoundExpression arg, RefKind refKind, MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 90322, 91402);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 90443, 90817) || true) && (refKind == RefKind.Ref)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 90443, 90817);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 90771, 90802);

                    f_10889_90771_90801(this, arg, arg.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 90443, 90817);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 90833, 90858);

                f_10889_90833_90857(this, arg, value: null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 91216, 91391) || true) && (refKind != RefKind.None && (DynAbs.Tracing.TraceSender.Expression_True(10889, 91220, 91290) && ((object)method == null || (DynAbs.Tracing.TraceSender.Expression_False(10889, 91248, 91289) || f_10889_91274_91289(method)))) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 91220, 91321) && f_10889_91294_91302(arg) is TypeSymbol type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 91216, 91391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 91355, 91376);

                    f_10889_91355_91375(this, type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 91216, 91391);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 90322, 91402);

                int
                f_10889_90771_90801(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    this_param.CheckAssigned(expr, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 90771, 90801);
                    return 0;
                }


                int
                f_10889_90833_90857(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    this_param.Assign((Microsoft.CodeAnalysis.CSharp.BoundNode)node, value: value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 90833, 90857);
                    return 0;
                }


                bool
                f_10889_91274_91289(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExtern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 91274, 91289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10889_91294_91302(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 91294, 91302);
                    return return_v;
                }


                int
                f_10889_91355_91375(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    this_param.MarkFieldsUsed(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 91355, 91375);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 90322, 91402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 90322, 91402);
            }
        }

        protected void CheckAssigned(BoundExpression expr, SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 91433, 92993);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 91525, 91559) || true) && (f_10889_91529_91550_M(!this.State.Reachable))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 91525, 91559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 91552, 91559);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 91525, 91559);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 91573, 91599);

                int
                slot = f_10889_91584_91598(this, expr)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 91613, 92982);

                switch (f_10889_91621_91630(expr))
                {

                    case BoundKind.Local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 91613, 92982);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 91707, 91759);

                        f_10889_91707_91758(this, f_10889_91721_91751(((BoundLocal)expr)), node);
                        DynAbs.Tracing.TraceSender.TraceBreak(10889, 91781, 91787);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 91613, 92982);

                    case BoundKind.Parameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 91613, 92982);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 91852, 91912);

                        f_10889_91852_91911(this, f_10889_91866_91904(((BoundParameter)expr)), node);
                        DynAbs.Tracing.TraceSender.TraceBreak(10889, 91934, 91940);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 91613, 92982);

                    case BoundKind.FieldAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 91613, 92982);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 92007, 92042);

                        var
                        field = (BoundFieldAccess)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 92064, 92095);

                        var
                        symbol = f_10889_92077_92094(field)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 92117, 92302) || true) && (f_10889_92121_92146_M(!symbol.IsFixedSizeBuffer) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 92121, 92195) && f_10889_92150_92195(this, f_10889_92169_92186(field), symbol)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 92117, 92302);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 92245, 92279);

                            f_10889_92245_92278(this, expr, symbol, node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 92117, 92302);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10889, 92324, 92330);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 91613, 92982);

                    case BoundKind.EventAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 91613, 92982);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 92397, 92433);

                        var
                        @event = (BoundEventAccess)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 92455, 92520);

                        FieldSymbol
                        associatedField = f_10889_92485_92519(f_10889_92485_92503(@event))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 92542, 92754) || true) && ((object)associatedField != null && (DynAbs.Tracing.TraceSender.Expression_True(10889, 92546, 92636) && f_10889_92581_92636(this, f_10889_92600_92618(@event), associatedField)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 92542, 92754);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 92686, 92731);

                            f_10889_92686_92730(this, @event, associatedField, node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 92542, 92754);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10889, 92776, 92782);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 91613, 92982);

                    case BoundKind.ThisReference:
                    case BoundKind.BaseReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 91613, 92982);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 92898, 92939);

                        f_10889_92898_92938(this, f_10889_92912_92931(), node);
                        DynAbs.Tracing.TraceSender.TraceBreak(10889, 92961, 92967);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 91613, 92982);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 91433, 92993);

                bool
                f_10889_91529_91550_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 91529, 91550);
                    return return_v;
                }


                int
                f_10889_91584_91598(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.MakeSlot(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 91584, 91598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10889_91621_91630(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 91621, 91630);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10889_91721_91751(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 91721, 91751);
                    return return_v;
                }


                int
                f_10889_91707_91758(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    this_param.CheckAssigned((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 91707, 91758);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10889_91866_91904(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 91866, 91904);
                    return return_v;
                }


                int
                f_10889_91852_91911(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    this_param.CheckAssigned((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 91852, 91911);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10889_92077_92094(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 92077, 92094);
                    return return_v;
                }


                bool
                f_10889_92121_92146_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 92121, 92146);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10889_92169_92186(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 92169, 92186);
                    return return_v;
                }


                bool
                f_10889_92150_92195(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol)
                {
                    var return_v = this_param.MayRequireTracking(receiverOpt, fieldSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 92150, 92195);
                    return return_v;
                }


                int
                f_10889_92245_92278(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    this_param.CheckAssigned(expr, fieldSymbol, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 92245, 92278);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10889_92485_92503(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.EventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 92485, 92503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                f_10889_92485_92519(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 92485, 92519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10889_92600_92618(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 92600, 92618);
                    return return_v;
                }


                bool
                f_10889_92581_92636(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol)
                {
                    var return_v = this_param.MayRequireTracking(receiverOpt, fieldSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 92581, 92636);
                    return return_v;
                }


                int
                f_10889_92686_92730(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    this_param.CheckAssigned((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr, fieldSymbol, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 92686, 92730);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10889_92912_92931()
                {
                    var return_v = MethodThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 92912, 92931);
                    return return_v;
                }


                int
                f_10889_92898_92938(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    this_param.CheckAssigned((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 92898, 92938);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 91433, 92993);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 91433, 92993);
            }
        }

        private void MarkFieldsUsed(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 93023, 94501);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 93092, 94490);

                switch (f_10889_93100_93113(type))
                {

                    case TypeKind.Array:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 93092, 94490);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 93189, 93241);

                        f_10889_93189_93240(this, f_10889_93204_93239(((ArrayTypeSymbol)type)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 93263, 93270);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 93092, 94490);

                    case TypeKind.Class:
                    case TypeKind.Struct:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 93092, 94490);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 93371, 93496) || true) && (!f_10889_93376_93416(type, this.compilation))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 93371, 93496);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 93466, 93473);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 93371, 93496);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 93520, 93696) || true) && (!(f_10889_93526_93549(type) is SourceAssemblySymbol assembly))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 93520, 93696);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 93633, 93640);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 93520, 93696);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 93720, 93773);

                        var
                        seen = assembly.TypesReferencedInExternalMethods
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 93795, 94446) || true) && (f_10889_93799_93813(seen, type))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 93795, 94446);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 93863, 93901);

                            var
                            namedType = (NamedTypeSymbol)type
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 93927, 94423);
                                foreach (var symbol in f_10889_93950_93981_I(f_10889_93950_93981(namedType)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 93927, 94423);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 94039, 94180) || true) && (f_10889_94043_94054(symbol) != SymbolKind.Field)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 94039, 94180);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 94140, 94149);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 94039, 94180);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 94212, 94252);

                                    FieldSymbol
                                    field = (FieldSymbol)symbol
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 94282, 94339);

                                    f_10889_94282_94338(assembly, field, read: true, write: true);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 94369, 94396);

                                    f_10889_94369_94395(this, f_10889_94384_94394(field));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 93927, 94423);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 497);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 497);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 93795, 94446);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 94468, 94475);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 93092, 94490);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 93023, 94501);

                Microsoft.CodeAnalysis.TypeKind
                f_10889_93100_93113(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 93100, 93113);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10889_93204_93239(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 93204, 93239);
                    return return_v;
                }


                int
                f_10889_93189_93240(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    this_param.MarkFieldsUsed(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 93189, 93240);
                    return 0;
                }


                bool
                f_10889_93376_93416(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.IsFromCompilation(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 93376, 93416);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10889_93526_93549(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 93526, 93549);
                    return return_v;
                }


                bool
                f_10889_93799_93813(Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 93799, 93813);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10889_93950_93981(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 93950, 93981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10889_94043_94054(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 94043, 94054);
                    return return_v;
                }


                int
                f_10889_94282_94338(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                field, bool
                read, bool
                write)
                {
                    this_param.NoteFieldAccess(field, read: read, write: write);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 94282, 94338);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10889_94384_94394(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 94384, 94394);
                    return return_v;
                }


                int
                f_10889_94369_94395(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    this_param.MarkFieldsUsed(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 94369, 94395);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10889_93950_93981_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 93950, 93981);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 93023, 94501);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 93023, 94501);
            }
        }

        public override BoundNode VisitBaseReference(BoundBaseReference node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 94532, 94711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 94626, 94674);

                f_10889_94626_94673(this, f_10889_94640_94659(), node.Syntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 94688, 94700);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 94532, 94711);

                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10889_94640_94659()
                {
                    var return_v = MethodThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 94640, 94659);
                    return return_v;
                }


                int
                f_10889_94626_94673(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    this_param.CheckAssigned((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 94626, 94673);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 94532, 94711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 94532, 94711);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void VisitCatchBlock(BoundCatchBlock catchBlock, ref LocalState finallyState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 94723, 95363);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 94844, 94880);

                f_10889_94844_94879(this, f_10889_94861_94878(catchBlock));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 94896, 94948);

                var
                exceptionSource = f_10889_94918_94947(catchBlock)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 94962, 95088) || true) && (exceptionSource != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 94962, 95088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 95023, 95073);

                    f_10889_95023_95072(this, exceptionSource, value: null, read: false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 94962, 95088);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 95104, 95155);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitCatchBlock(catchBlock, ref finallyState), 10889, 95104, 95154);
                base.VisitCatchBlock(catchBlock, ref finallyState);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 95104, 95154);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 95171, 95352);
                    foreach (var local in f_10889_95193_95210_I(f_10889_95193_95210(catchBlock)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 95171, 95352);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 95244, 95337);

                        f_10889_95244_95336(this, local, assigned: f_10889_95276_95297(local) != LocalDeclarationKind.CatchVariable);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 95171, 95352);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 182);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 182);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 94723, 95363);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_94861_94878(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 94861, 94878);
                    return return_v;
                }


                int
                f_10889_94844_94879(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    this_param.DeclareVariables(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 94844, 94879);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10889_94918_94947(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionSourceOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 94918, 94947);
                    return return_v;
                }


                int
                f_10889_95023_95072(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, bool
                read)
                {
                    this_param.Assign((Microsoft.CodeAnalysis.CSharp.BoundNode)node, value: value, read: read);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 95023, 95072);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_95193_95210(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 95193, 95210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                f_10889_95276_95297(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.DeclarationKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 95276, 95297);
                    return return_v;
                }


                int
                f_10889_95244_95336(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol, bool
                assigned)
                {
                    this_param.ReportIfUnused(symbol, assigned: assigned);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 95244, 95336);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_95193_95210_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 95193, 95210);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 94723, 95363);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 94723, 95363);
            }
        }

        public override BoundNode VisitFieldAccess(BoundFieldAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 95375, 96450);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 95465, 95506);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitFieldAccess(node), 10889, 95478, 95505)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 95520, 95547);

                f_10889_95520_95546(this, f_10889_95529_95545(node));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 95563, 96409) || true) && (f_10889_95567_95601(f_10889_95567_95583(node)) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 95567, 95624) && node.Syntax != null) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 95567, 95680) && !f_10889_95629_95680(node.Syntax)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 95563, 96409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 95714, 95776);

                    Symbol
                    receiver = f_10889_95732_95775(this, f_10889_95758_95774(node))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 95794, 96122) || true) && ((object)receiver != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 95794, 96122);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 95864, 95888);

                        f_10889_95864_95887(this, receiver);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 95910, 96103) || true) && (!f_10889_95915_95965(_unsafeAddressTakenVariables, receiver))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 95910, 96103);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 96015, 96080);

                            f_10889_96015_96079(_unsafeAddressTakenVariables, receiver, f_10889_96058_96078(node.Syntax));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 95910, 96103);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 95794, 96122);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 95563, 96409);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 95563, 96409);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 96156, 96409) || true) && (f_10889_96160_96214(this, f_10889_96179_96195(node), f_10889_96197_96213(node)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 96156, 96409);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 96343, 96394);

                        f_10889_96343_96393(this, node, f_10889_96363_96379(node), node.Syntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 96156, 96409);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 95563, 96409);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 96425, 96439);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 95375, 96450);

                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10889_95529_95545(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 95529, 95545);
                    return return_v;
                }


                int
                f_10889_95520_95546(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                variable)
                {
                    this_param.NoteRead((Microsoft.CodeAnalysis.CSharp.Symbol)variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 95520, 95546);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10889_95567_95583(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 95567, 95583);
                    return return_v;
                }


                bool
                f_10889_95567_95601(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsFixedSizeBuffer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 95567, 95601);
                    return return_v;
                }


                bool
                f_10889_95629_95680(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = SyntaxFacts.IsFixedStatementExpression(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 95629, 95680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10889_95758_95774(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 95758, 95774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10889_95732_95775(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expression)
                {
                    var return_v = this_param.UseNonFieldSymbolUnsafely(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 95732, 95775);
                    return return_v;
                }


                int
                f_10889_95864_95887(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                variable)
                {
                    this_param.CheckCaptured(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 95864, 95887);
                    return 0;
                }


                bool
                f_10889_95915_95965(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.Location>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 95915, 95965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10889_96058_96078(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 96058, 96078);
                    return return_v;
                }


                int
                f_10889_96015_96079(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.Location>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                key, Microsoft.CodeAnalysis.Location
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 96015, 96079);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10889_96179_96195(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 96179, 96195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10889_96197_96213(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 96197, 96213);
                    return return_v;
                }


                bool
                f_10889_96160_96214(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol)
                {
                    var return_v = this_param.MayRequireTracking(receiverOpt, fieldSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 96160, 96214);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10889_96363_96379(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 96363, 96379);
                    return return_v;
                }


                int
                f_10889_96343_96393(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol, Microsoft.CodeAnalysis.SyntaxNode?
                node)
                {
                    this_param.CheckAssigned((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr, fieldSymbol, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 96343, 96393);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 95375, 96450);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 95375, 96450);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitPropertyAccess(BoundPropertyAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 96462, 97590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 96558, 96602);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitPropertyAccess(node), 10889, 96571, 96601)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 96616, 97551) || true) && (f_10889_96620_96689(node, this.CurrentSymbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 96616, 97551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 96723, 96758);

                    var
                    property = f_10889_96738_96757(node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 96803, 96920);

                    var
                    backingField = (DynAbs.Tracing.TraceSender.Conditional_F1(10889, 96822, 96860) || (((property is SourcePropertySymbolBase) && DynAbs.Tracing.TraceSender.Conditional_F2(10889, 96863, 96912)) || DynAbs.Tracing.TraceSender.Conditional_F3(10889, 96915, 96919))) ? f_10889_96863_96912(((SourcePropertySymbolBase)property)) : null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 96938, 97536) || true) && (backingField != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 96938, 97536);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 97004, 97517) || true) && (f_10889_97008_97058(this, f_10889_97027_97043(node), backingField))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 97004, 97517);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 97211, 97230);

                            int
                            unassignedSlot
                            = default(int);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 97256, 97494) || true) && (f_10889_97260_97280(this.State) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 97260, 97321) && !f_10889_97285_97321(this, node, out unassignedSlot)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 97256, 97494);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 97379, 97467);

                                f_10889_97379_97466(this, backingField, node.Syntax, unassignedSlot);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 97256, 97494);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 97004, 97517);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 96938, 97536);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 96616, 97551);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 97565, 97579);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 96462, 97590);

                bool
                f_10889_96620_96689(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                propertyAccess, Microsoft.CodeAnalysis.CSharp.Symbol
                fromMember)
                {
                    var return_v = Binder.AccessingAutoPropertyFromConstructor(propertyAccess, fromMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 96620, 96689);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10889_96738_96757(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.PropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 96738, 96757);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedBackingFieldSymbol
                f_10889_96863_96912(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.BackingField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 96863, 96912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10889_97027_97043(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 97027, 97043);
                    return return_v;
                }


                bool
                f_10889_97008_97058(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedBackingFieldSymbol
                fieldSymbol)
                {
                    var return_v = this_param.MayRequireTracking(receiverOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)fieldSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 97008, 97058);
                    return return_v;
                }


                bool
                f_10889_97260_97280(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param)
                {
                    var return_v = this_param.Reachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 97260, 97280);
                    return return_v;
                }


                bool
                f_10889_97285_97321(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                node, out int
                unassignedSlot)
                {
                    var return_v = this_param.IsAssigned((Microsoft.CodeAnalysis.CSharp.BoundExpression)node, out unassignedSlot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 97285, 97321);
                    return return_v;
                }


                int
                f_10889_97379_97466(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedBackingFieldSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node, int
                slot)
                {
                    this_param.ReportUnassignedIfNotCapturedInLocalFunction((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, node, slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 97379, 97466);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 96462, 97590);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 96462, 97590);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitEventAccess(BoundEventAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 97602, 98254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 97692, 97733);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitEventAccess(node), 10889, 97705, 97732)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 97840, 97903);

                FieldSymbol
                associatedField = f_10889_97870_97902(f_10889_97870_97886(node))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 97917, 98213) || true) && ((object)associatedField != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 97917, 98213);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 97986, 98012);

                    f_10889_97986_98011(this, associatedField);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 98030, 98198) || true) && (f_10889_98034_98087(this, f_10889_98053_98069(node), associatedField))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 98030, 98198);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 98129, 98179);

                        f_10889_98129_98178(this, node, associatedField, node.Syntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 98030, 98198);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 97917, 98213);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 98229, 98243);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 97602, 98254);

                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10889_97870_97886(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.EventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 97870, 97886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                f_10889_97870_97902(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 97870, 97902);
                    return return_v;
                }


                int
                f_10889_97986_98011(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                variable)
                {
                    this_param.NoteRead((Microsoft.CodeAnalysis.CSharp.Symbol)variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 97986, 98011);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10889_98053_98069(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 98053, 98069);
                    return return_v;
                }


                bool
                f_10889_98034_98087(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol)
                {
                    var return_v = this_param.MayRequireTracking(receiverOpt, fieldSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 98034, 98087);
                    return return_v;
                }


                int
                f_10889_98129_98178(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    this_param.CheckAssigned((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr, fieldSymbol, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 98129, 98178);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 97602, 98254);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 97602, 98254);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void VisitForEachIterationVariables(BoundForEachStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 98266, 98878);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 98429, 98867);
                    foreach (var iterationVariable in f_10889_98463_98486_I(f_10889_98463_98486(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 98429, 98867);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 98520, 98568);

                        f_10889_98520_98567((object)iterationVariable != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 98586, 98632);

                        int
                        slot = f_10889_98597_98631(this, iterationVariable)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 98650, 98686) || true) && (slot > 0)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 98650, 98686);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 98664, 98686);

                            f_10889_98664_98685(this, slot);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 98650, 98686);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 98805, 98852);

                        f_10889_98805_98851(this, iterationVariable, null, read: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 98429, 98867);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 439);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 439);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 98266, 98878);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_98463_98486(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                this_param)
                {
                    var return_v = this_param.IterationVariables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 98463, 98486);
                    return return_v;
                }


                int
                f_10889_98520_98567(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 98520, 98567);
                    return 0;
                }


                int
                f_10889_98597_98631(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol)
                {
                    var return_v = this_param.GetOrCreateSlot((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 98597, 98631);
                    return return_v;
                }


                int
                f_10889_98664_98685(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                slot)
                {
                    this_param.SetSlotAssigned(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 98664, 98685);
                    return 0;
                }


                int
                f_10889_98805_98851(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                variable, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, bool
                read)
                {
                    this_param.NoteWrite((Microsoft.CodeAnalysis.CSharp.Symbol)variable, value, read: read);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 98805, 98851);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10889_98463_98486_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 98463, 98486);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 98266, 98878);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 98266, 98878);
            }
        }

        public override BoundNode VisitObjectInitializerMember(BoundObjectInitializerMember node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 98890, 99382);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 99004, 99057);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitObjectInitializerMember(node), 10889, 99017, 99056)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 99073, 99341) || true) && ((object)_sourceAssembly != null && (DynAbs.Tracing.TraceSender.Expression_True(10889, 99077, 99137) && f_10889_99112_99129(node) != null) && (DynAbs.Tracing.TraceSender.Expression_True(10889, 99077, 99183) && f_10889_99141_99163(f_10889_99141_99158(node)) == SymbolKind.Field))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 99073, 99341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 99217, 99326);

                    f_10889_99217_99325(_sourceAssembly, f_10889_99262_99298(f_10889_99262_99279(node)), read: false, write: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 99073, 99341);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 99357, 99371);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 98890, 99382);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10889_99112_99129(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.MemberSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 99112, 99129);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10889_99141_99158(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.MemberSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 99141, 99158);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10889_99141_99163(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 99141, 99163);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10889_99262_99279(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.MemberSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 99262, 99279);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10889_99262_99298(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 99262, 99298);
                    return return_v;
                }


                int
                f_10889_99217_99325(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                field, bool
                read, bool
                write)
                {
                    this_param.NoteFieldAccess((Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)field, read: read, write: write);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 99217, 99325);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 98890, 99382);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 98890, 99382);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDynamicObjectInitializerMember(BoundDynamicObjectInitializerMember node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 99394, 99545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 99522, 99534);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 99394, 99545);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 99394, 99545);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 99394, 99545);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void VisitAssignmentOfNullCoalescingAssignment(
                    BoundNullCoalescingAssignmentOperator node,
                    BoundPropertyAccess propertyAccessOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 99557, 99898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 99757, 99829);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitAssignmentOfNullCoalescingAssignment(node, propertyAccessOpt), 10889, 99757, 99828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 99843, 99887);

                f_10889_99843_99886(this, f_10889_99850_99866(node), f_10889_99868_99885(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 99557, 99898);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10889_99850_99866(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 99850, 99866);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10889_99868_99885(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
                this_param)
                {
                    var return_v = this_param.RightOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 99868, 99885);
                    return return_v;
                }


                int
                f_10889_99843_99886(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    this_param.Assign((Microsoft.CodeAnalysis.CSharp.BoundNode)node, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 99843, 99886);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 99557, 99898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 99557, 99898);
            }
        }

        protected override void AdjustStateForNullCoalescingAssignmentNonNullCase(BoundNullCoalescingAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 99910, 100411);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 100357, 100400);

                f_10889_100357_100399(this, f_10889_100364_100380(node), f_10889_100382_100398(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 99910, 100411);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10889_100364_100380(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 100364, 100380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10889_100382_100398(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 100382, 100398);
                    return return_v;
                }


                int
                f_10889_100357_100399(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    this_param.Assign((Microsoft.CodeAnalysis.CSharp.BoundNode)node, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 100357, 100399);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 99910, 100411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 99910, 100411);
            }
        }

        protected override string Dump(LocalState state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 100454, 100743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 100527, 100561);

                var
                builder = f_10889_100541_100560()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 100575, 100604);

                f_10889_100575_100603(builder, "[assigned ");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 100618, 100658);

                f_10889_100618_100657(this, state.Assigned, builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 100672, 100692);

                f_10889_100672_100691(builder, "]");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 100706, 100732);

                return f_10889_100713_100731(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 100454, 100743);

                System.Text.StringBuilder
                f_10889_100541_100560()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 100541, 100560);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10889_100575_100603(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 100575, 100603);
                    return return_v;
                }


                int
                f_10889_100618_100657(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, Microsoft.CodeAnalysis.BitVector
                a, System.Text.StringBuilder
                builder)
                {
                    this_param.AppendBitNames(a, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 100618, 100657);
                    return 0;
                }


                System.Text.StringBuilder
                f_10889_100672_100691(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 100672, 100691);
                    return return_v;
                }


                string
                f_10889_100713_100731(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 100713, 100731);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 100454, 100743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 100454, 100743);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected void AppendBitNames(BitVector a, StringBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 100755, 101073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 100845, 100862);

                bool
                any = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 100876, 101062);
                    foreach (int bit in f_10889_100896_100908_I(a.TrueBits()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 100876, 101062);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 100942, 100972) || true) && (any)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 100942, 100972);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 100951, 100972);

                            f_10889_100951_100971(builder, ", ");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 100942, 100972);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 100990, 101001);

                        any = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 101019, 101047);

                        f_10889_101019_101046(this, bit, builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 100876, 101062);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 187);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 187);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 100755, 101073);

                System.Text.StringBuilder
                f_10889_100951_100971(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 100951, 100971);
                    return return_v;
                }


                int
                f_10889_101019_101046(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                bit, System.Text.StringBuilder
                builder)
                {
                    this_param.AppendBitName(bit, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 101019, 101046);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<int>
                f_10889_100896_100908_I(System.Collections.Generic.IEnumerable<int>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 100896, 100908);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 100755, 101073);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 100755, 101073);
            }
        }

        protected void AppendBitName(int bit, StringBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 101085, 101597);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 101170, 101214);

                VariableIdentifier
                id = f_10889_101194_101213(variableBySlot, bit)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 101228, 101382) || true) && (id.ContainingSlot > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 101228, 101382);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 101287, 101329);

                    f_10889_101287_101328(this, id.ContainingSlot, builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 101347, 101367);

                    f_10889_101347_101366(builder, ".");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 101228, 101382);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 101398, 101586);

                f_10889_101398_101585(
                            builder, (DynAbs.Tracing.TraceSender.Conditional_F1(10889, 101431, 101439) || ((bit == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(10889, 101442, 101457)) || DynAbs.Tracing.TraceSender.Conditional_F3(10889, 101477, 101584))) ? "<unreachable>" : (DynAbs.Tracing.TraceSender.Conditional_F1(10889, 101477, 101513) || ((f_10889_101477_101513(f_10889_101498_101512(id.Symbol)) && DynAbs.Tracing.TraceSender.Conditional_F2(10889, 101516, 101550)) || DynAbs.Tracing.TraceSender.Conditional_F3(10889, 101570, 101584))) ? "<anon>" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_10889_101527_101550(id.Symbol)).ToString(), 10889, 101527, 101550) : f_10889_101570_101584(id.Symbol));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 101085, 101597);

                Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier
                f_10889_101194_101213(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 101194, 101213);
                    return return_v;
                }


                int
                f_10889_101287_101328(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                bit, System.Text.StringBuilder
                builder)
                {
                    this_param.AppendBitName(bit, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 101287, 101328);
                    return 0;
                }


                System.Text.StringBuilder
                f_10889_101347_101366(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 101347, 101366);
                    return return_v;
                }


                string
                f_10889_101498_101512(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 101498, 101512);
                    return return_v;
                }


                bool
                f_10889_101477_101513(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 101477, 101513);
                    return return_v;
                }


                int
                f_10889_101527_101550(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 101527, 101550);
                    return return_v;
                }


                string
                f_10889_101570_101584(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 101570, 101584);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10889_101398_101585(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 101398, 101585);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 101085, 101597);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 101085, 101597);
            }
        }

        protected override bool Meet(ref LocalState self, ref LocalState other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 101609, 102379);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 101705, 101866) || true) && (self.Assigned.Capacity != other.Assigned.Capacity)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 101705, 101866);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 101792, 101812);

                    f_10889_101792_101811(this, ref self);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 101830, 101851);

                    f_10889_101830_101850(this, ref other);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 101705, 101866);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 101882, 102005) || true) && (f_10889_101886_101902_M(!other.Reachable))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 101882, 102005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 101936, 101960);

                    self.Assigned[0] = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 101978, 101990);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 101882, 102005);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 102021, 102042);

                bool
                changed = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 102065, 102073);
                    for (int
        slot = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 102056, 102339) || true) && (slot < self.Assigned.Capacity)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 102106, 102112)
        , slot++, DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 102056, 102339))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 102056, 102339);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 102146, 102324) || true) && (other.Assigned[slot] && (DynAbs.Tracing.TraceSender.Expression_True(10889, 102150, 102194) && f_10889_102174_102194_M(!self.Assigned[slot])))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 102146, 102324);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 102236, 102268);

                            f_10889_102236_102267(this, slot, ref self);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 102290, 102305);

                            changed = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 102146, 102324);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10889, 1, 284);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10889, 1, 284);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 102353, 102368);

                return changed;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 101609, 102379);

                int
                f_10889_101792_101811(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, ref Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                state)
                {
                    this_param.Normalize(ref state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 101792, 101811);
                    return 0;
                }


                int
                f_10889_101830_101850(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, ref Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                state)
                {
                    this_param.Normalize(ref state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 101830, 101850);
                    return 0;
                }


                bool
                f_10889_101886_101902_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 101886, 101902);
                    return return_v;
                }


                bool
                f_10889_102174_102194_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 102174, 102194);
                    return return_v;
                }


                int
                f_10889_102236_102267(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, int
                slot, ref Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                state)
                {
                    this_param.SetSlotAssigned(slot, ref state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 102236, 102267);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 101609, 102379);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 101609, 102379);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool Join(ref LocalState self, ref LocalState other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 102391, 103116);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 102487, 103105) || true) && (f_10889_102491_102505(self) == f_10889_102509_102524(other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 102487, 103105);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 102558, 102735) || true) && (self.Assigned.Capacity != other.Assigned.Capacity)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 102558, 102735);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 102653, 102673);

                        f_10889_102653_102672(this, ref self);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 102695, 102716);

                        f_10889_102695_102715(this, ref other);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 102558, 102735);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 102755, 102806);

                    return self.Assigned.IntersectWith(other.Assigned);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 102487, 103105);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 102487, 103105);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 102840, 103105) || true) && (f_10889_102844_102859_M(!self.Reachable))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 102840, 103105);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 102893, 102932);

                        self.Assigned = other.Assigned.Clone();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 102950, 102962);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 102840, 103105);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 102840, 103105);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 103028, 103059);

                        f_10889_103028_103058(f_10889_103041_103057_M(!other.Reachable));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 103077, 103090);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 102840, 103105);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 102487, 103105);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 102391, 103116);

                bool
                f_10889_102491_102505(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param)
                {
                    var return_v = this_param.Reachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 102491, 102505);
                    return return_v;
                }


                bool
                f_10889_102509_102524(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                this_param)
                {
                    var return_v = this_param.Reachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 102509, 102524);
                    return return_v;
                }


                int
                f_10889_102653_102672(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, ref Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                state)
                {
                    this_param.Normalize(ref state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 102653, 102672);
                    return 0;
                }


                int
                f_10889_102695_102715(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
                this_param, ref Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                state)
                {
                    this_param.Normalize(ref state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 102695, 102715);
                    return 0;
                }


                bool
                f_10889_102844_102859_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 102844, 102859);
                    return return_v;
                }


                bool
                f_10889_103041_103057_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 103041, 103057);
                    return return_v;
                }


                int
                f_10889_103028_103058(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 103028, 103058);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 102391, 103116);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 102391, 103116);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        internal class LocalState : ILocalDataFlowState
        {
            internal BitVector Assigned;

            public bool NormalizeToBottom { get; }

            internal LocalState(BitVector assigned, bool normalizeToBottom = false)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10889, 103392, 103641);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 103338, 103376);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 103496, 103521);

                    this.Assigned = assigned;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 103539, 103577);

                    NormalizeToBottom = normalizeToBottom;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 103595, 103626);

                    f_10889_103595_103625(f_10889_103608_103624_M(!assigned.IsNull));
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10889, 103392, 103641);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 103392, 103641);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 103392, 103641);
                }
            }

            public LocalState Clone()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 103815, 103928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 103873, 103913);

                    return f_10889_103880_103912(Assigned.Clone());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 103815, 103928);

                    Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                    f_10889_103880_103912(Microsoft.CodeAnalysis.BitVector
                    assigned)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState(assigned);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 103880, 103912);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 103815, 103928);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 103815, 103928);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool IsAssigned(int slot)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 103944, 104066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 104009, 104051);

                    return /*(slot == -1) || */Assigned[slot];
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 103944, 104066);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 103944, 104066);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 103944, 104066);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void Assign(int slot)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 104082, 104242);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 104143, 104187) || true) && (slot == -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 104143, 104187);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 104180, 104187);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 104143, 104187);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 104205, 104227);

                    Assigned[slot] = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 104082, 104242);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 104082, 104242);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 104082, 104242);
                }
            }

            public void Unassign(int slot)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 104258, 104421);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 104321, 104365) || true) && (slot == -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10889, 104321, 104365);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 104358, 104365);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10889, 104321, 104365);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 104383, 104406);

                    Assigned[slot] = false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 104258, 104421);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 104258, 104421);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 104258, 104421);
                }
            }

            public bool Reachable
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10889, 104491, 104602);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10889, 104535, 104583);

                        return Assigned.Capacity <= 0 || (DynAbs.Tracing.TraceSender.Expression_False(10889, 104542, 104582) || !f_10889_104569_104582(this, 0));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10889, 104491, 104602);

                        bool
                        f_10889_104569_104582(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                        this_param, int
                        slot)
                        {
                            var return_v = this_param.IsAssigned(slot);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 104569, 104582);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10889, 104437, 104617);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 104437, 104617);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static LocalState()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10889, 103149, 104628);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10889, 103149, 104628);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 103149, 104628);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10889, 103149, 104628);

            bool
            f_10889_103608_103624_M(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 103608, 103624);
                return return_v;
            }


            int
            f_10889_103595_103625(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 103595, 103625);
                return 0;
            }

        }

        static DefiniteAssignmentPass()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10889, 1468, 104635);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10889, 1468, 104635);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10889, 1468, 104635);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10889, 1468, 104635);

        Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier, int>
        f_10889_1872_1927()
        {
            var return_v = PooledDictionary<VariableIdentifier, int>.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 1872, 1927);
            return return_v;
        }


        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier>
        f_10889_2724_2780(int
        capacity, Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier
        fillWithValue)
        {
            var return_v = ArrayBuilder<VariableIdentifier>.GetInstance(capacity, fillWithValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 2724, 2780);
            return return_v;
        }


        Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
        f_10889_3249_3289()
        {
            var return_v = PooledHashSet<LocalSymbol>.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 3249, 3289);
            return return_v;
        }


        Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
        f_10889_3783_3831()
        {
            var return_v = PooledHashSet<LocalFunctionSymbol>.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 3783, 3831);
            return return_v;
        }


        Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_10889_4016_4051()
        {
            var return_v = PooledHashSet<Symbol>.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 4016, 4051);
            return return_v;
        }


        Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.Location>
        f_10889_4450_4498()
        {
            var return_v = PooledDictionary<Symbol, Location>.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 4450, 4498);
            return return_v;
        }


        Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_10889_4684_4719()
        {
            var return_v = PooledHashSet<Symbol>.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 4684, 4719);
            return return_v;
        }


        Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_10889_4789_4824()
        {
            var return_v = PooledHashSet<Symbol>.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 4789, 4824);
            return return_v;
        }


        Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_10889_4893_4928()
        {
            var return_v = PooledHashSet<Symbol>.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 4893, 4928);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
        f_10889_7246_7282()
        {
            var return_v = EmptyStructTypeCache.CreatePrecise();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 7246, 7282);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
        f_10889_7285_7346(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation)
        {
            var return_v = EmptyStructTypeCache.CreateForDev12Compatibility(compilation);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 7285, 7346);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10889_7539_7564(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 7539, 7564);
            return return_v;
        }


        System.Type
        f_10889_7924_7938(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
        this_param)
        {
            var return_v = this_param.GetType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 7924, 7938);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10889_7182_7193_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10889, 6713, 7984);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10889_8542_8567(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10889, 8542, 8567);
            return return_v;
        }


        System.Type
        f_10889_8812_8826(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
        this_param)
        {
            var return_v = this_param.GetType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 8812, 8826);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10889_8308_8319_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10889, 7996, 8872);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
        f_10889_9484_9523()
        {
            var return_v = EmptyStructTypeCache.CreateNeverEmpty();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 9484, 9523);
            return return_v;
        }


        System.Type
        f_10889_9905_9919(Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass
        this_param)
        {
            var return_v = this_param.GetType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10889, 9905, 9919);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10889_9457_9468_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10889, 9046, 9965);
            return return_v;
        }

    }
}
