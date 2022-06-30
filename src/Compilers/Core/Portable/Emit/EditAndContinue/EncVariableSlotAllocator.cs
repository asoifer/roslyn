// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Emit
{
    internal sealed class EncVariableSlotAllocator : VariableSlotAllocator
    {
        private readonly SymbolMatcher _symbolMap;

        private readonly Func<SyntaxNode, SyntaxNode>? _syntaxMap;

        private readonly IMethodSymbolInternal _previousTopLevelMethod;

        private readonly DebugId _methodId;

        private readonly IReadOnlyDictionary<EncLocalInfo, int> _previousLocalSlots;

        private readonly ImmutableArray<EncLocalInfo> _previousLocals;

        private readonly string? _stateMachineTypeName;

        private readonly int _hoistedLocalSlotCount;

        private readonly IReadOnlyDictionary<EncHoistedLocalInfo, int>? _hoistedLocalSlots;

        private readonly int _awaiterCount;

        private readonly IReadOnlyDictionary<Cci.ITypeReference, int>? _awaiterMap;

        private readonly IReadOnlyDictionary<int, KeyValuePair<DebugId, int>>? _lambdaMap;

        private readonly IReadOnlyDictionary<int, DebugId>? _closureMap;

        private readonly LambdaSyntaxFacts _lambdaSyntaxFacts;

        public EncVariableSlotAllocator(
                    SymbolMatcher symbolMap,
                    Func<SyntaxNode, SyntaxNode>? syntaxMap,
                    IMethodSymbolInternal previousTopLevelMethod,
                    DebugId methodId,
                    ImmutableArray<EncLocalInfo> previousLocals,
                    IReadOnlyDictionary<int, KeyValuePair<DebugId, int>>? lambdaMap,
                    IReadOnlyDictionary<int, DebugId>? closureMap,
                    string? stateMachineTypeName,
                    int hoistedLocalSlotCount,
                    IReadOnlyDictionary<EncHoistedLocalInfo, int>? hoistedLocalSlots,
                    int awaiterCount,
                    IReadOnlyDictionary<Cci.ITypeReference, int>? awaiterMap,
                    LambdaSyntaxFacts lambdaSyntaxFacts)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(764, 1821, 3977);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 712, 722);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 802, 812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 862, 885);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 1019, 1038);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 1184, 1205);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 1237, 1259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 1334, 1352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 1384, 1397);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 1471, 1482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 1588, 1598);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 1709, 1720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 1790, 1808);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 2570, 2607);

                f_764_2570_2606(symbolMap);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 2621, 2671);

                f_764_2621_2670(previousTopLevelMethod);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 2685, 2725);

                f_764_2685_2724(f_764_2698_2723_M(!previousLocals.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 2741, 2764);

                _symbolMap = symbolMap;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 2778, 2801);

                _syntaxMap = syntaxMap;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 2815, 2848);

                _previousLocals = previousLocals;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 2862, 2911);

                _previousTopLevelMethod = previousTopLevelMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 2925, 2946);

                _methodId = methodId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 2960, 2999);

                _hoistedLocalSlots = hoistedLocalSlots;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 3013, 3060);

                _hoistedLocalSlotCount = hoistedLocalSlotCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 3074, 3119);

                _stateMachineTypeName = stateMachineTypeName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 3133, 3162);

                _awaiterCount = awaiterCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 3176, 3201);

                _awaiterMap = awaiterMap;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 3215, 3238);

                _lambdaMap = lambdaMap;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 3252, 3277);

                _closureMap = closureMap;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 3291, 3330);

                _lambdaSyntaxFacts = lambdaSyntaxFacts;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 3400, 3466);

                var
                previousLocalInfoToSlot = f_764_3430_3465()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 3489, 3497);
                    for (int
        slot = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 3480, 3904) || true) && (slot < previousLocals.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 3529, 3535)
        , slot++, DynAbs.Tracing.TraceSender.TraceExitCondition(764, 3480, 3904))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(764, 3480, 3904);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 3569, 3606);

                        var
                        localInfo = previousLocals[slot]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 3624, 3659);

                        f_764_3624_3658(f_764_3637_3657_M(!localInfo.IsDefault));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 3677, 3824) || true) && (localInfo.IsUnused)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(764, 3677, 3824);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 3796, 3805);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(764, 3677, 3824);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 3844, 3889);

                        f_764_3844_3888(
                                        previousLocalInfoToSlot, localInfo, slot);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(764, 1, 425);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(764, 1, 425);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 3920, 3966);

                _previousLocalSlots = previousLocalInfoToSlot;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(764, 1821, 3977);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(764, 1821, 3977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(764, 1821, 3977);
            }
        }

        public override DebugId? MethodId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(764, 4023, 4035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 4026, 4035);
                    return _methodId; DynAbs.Tracing.TraceSender.TraceExitMethod(764, 4023, 4035);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(764, 4023, 4035);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(764, 4023, 4035);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private int CalculateSyntaxOffsetInPreviousMethod(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(764, 4048, 4666);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 4532, 4655);

                return f_764_4539_4654(_previousTopLevelMethod, f_764_4590_4636(_lambdaSyntaxFacts, node), f_764_4638_4653(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(764, 4048, 4666);

                int
                f_764_4590_4636(Microsoft.CodeAnalysis.Emit.LambdaSyntaxFacts
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetDeclaratorPosition(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 4590, 4636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_764_4638_4653(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(764, 4638, 4653);
                    return return_v;
                }


                int
                f_764_4539_4654(Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
                this_param, int
                declaratorPosition, Microsoft.CodeAnalysis.SyntaxTree
                declaratorTree)
                {
                    var return_v = this_param.CalculateLocalSyntaxOffset(declaratorPosition, declaratorTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 4539, 4654);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(764, 4048, 4666);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(764, 4048, 4666);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void AddPreviousLocals(ArrayBuilder<Cci.ILocalDefinition> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(764, 4678, 4911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 4785, 4900);

                // LAFHIS
                var temp = _previousLocals.Select<Microsoft.CodeAnalysis.Emit.EncLocalInfo, Microsoft.CodeAnalysis.CodeGen.SignatureOnlyLocalDefinition>((info, index) => new SignatureOnlyLocalDefinition(info.Signature, index));
                DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 4802, 4898);

                f_764_4785_4899(builder, temp);
                DynAbs.Tracing.TraceSender.TraceExitMethod(764, 4678, 4911);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CodeGen.SignatureOnlyLocalDefinition>
                f_764_4802_4898(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.EncLocalInfo>
                source, System.Func<Microsoft.CodeAnalysis.Emit.EncLocalInfo, int, Microsoft.CodeAnalysis.CodeGen.SignatureOnlyLocalDefinition>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.Emit.EncLocalInfo, Microsoft.CodeAnalysis.CodeGen.SignatureOnlyLocalDefinition>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 4802, 4898);
                    return return_v;
                }


                int
                f_764_4785_4899(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ILocalDefinition>
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CodeGen.SignatureOnlyLocalDefinition>
                items)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<Microsoft.Cci.ILocalDefinition>)items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 4785, 4899);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(764, 4678, 4911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(764, 4678, 4911);
            }
        }

        private bool TryGetPreviousLocalId(SyntaxNode currentDeclarator, LocalDebugId currentId, out LocalDebugId previousId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(764, 4923, 5868);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 5065, 5438) || true) && (_syntaxMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(764, 5065, 5438);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 5370, 5393);

                    previousId = currentId;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 5411, 5423);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(764, 5065, 5438);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 5454, 5516);

                SyntaxNode
                previousDeclarator = f_764_5486_5515(this, currentDeclarator)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 5530, 5661) || true) && (previousDeclarator == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(764, 5530, 5661);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 5594, 5615);

                    previousId = default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 5633, 5646);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(764, 5530, 5661);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 5677, 5754);

                int
                syntaxOffset = f_764_5696_5753(this, previousDeclarator)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 5768, 5831);

                previousId = f_764_5781_5830(syntaxOffset, currentId.Ordinal);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 5845, 5857);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(764, 4923, 5868);

                Microsoft.CodeAnalysis.SyntaxNode
                f_764_5486_5515(Microsoft.CodeAnalysis.Emit.EncVariableSlotAllocator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                arg)
                {
                    var return_v = this_param._syntaxMap(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 5486, 5515);
                    return return_v;
                }


                int
                f_764_5696_5753(Microsoft.CodeAnalysis.Emit.EncVariableSlotAllocator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.CalculateSyntaxOffsetInPreviousMethod(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 5696, 5753);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDebugId
                f_764_5781_5830(int
                syntaxOffset, int
                ordinal)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalDebugId(syntaxOffset, ordinal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 5781, 5830);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(764, 4923, 5868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(764, 4923, 5868);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override LocalDefinition? GetPreviousLocal(
                    Cci.ITypeReference currentType,
                    ILocalSymbolInternal currentLocalSymbol,
                    string? name,
                    SynthesizedLocalKind kind,
                    LocalDebugId id,
                    LocalVariableAttributes pdbAttributes,
                    LocalSlotConstraints constraints,
                    ImmutableArray<bool> dynamicTransformFlags,
                    ImmutableArray<string> tupleElementNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(764, 5880, 7559);
                Microsoft.CodeAnalysis.CodeGen.LocalDebugId previousId = default(Microsoft.CodeAnalysis.CodeGen.LocalDebugId);
                int slot = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 6362, 6436) || true) && (id.IsNone)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(764, 6362, 6436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 6409, 6421);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(764, 6362, 6436);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 6452, 6614) || true) && (!f_764_6457_6553(this, f_764_6479_6519(currentLocalSymbol), id, out previousId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(764, 6452, 6614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 6587, 6599);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(764, 6452, 6614);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 6630, 6686);

                var
                previousType = f_764_6649_6685(_symbolMap, currentType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 6700, 6785) || true) && (previousType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(764, 6700, 6785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 6758, 6770);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(764, 6700, 6785);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 6954, 7072);

                var
                localKey = f_764_6969_7071(f_764_6986_7026(kind, previousId), previousType, constraints, signature: null)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 7088, 7209) || true) && (!f_764_7093_7148(_previousLocalSlots, localKey, out slot))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(764, 7088, 7209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 7182, 7194);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(764, 7088, 7209);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 7225, 7548);

                return f_764_7232_7547(currentLocalSymbol, name, currentType, slot, kind, id, pdbAttributes, constraints, dynamicTransformFlags, tupleElementNames);
                DynAbs.Tracing.TraceSender.TraceExitMethod(764, 5880, 7559);

                Microsoft.CodeAnalysis.SyntaxNode
                f_764_6479_6519(Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal
                this_param)
                {
                    var return_v = this_param.GetDeclaratorSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 6479, 6519);
                    return return_v;
                }


                bool
                f_764_6457_6553(Microsoft.CodeAnalysis.Emit.EncVariableSlotAllocator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                currentDeclarator, Microsoft.CodeAnalysis.CodeGen.LocalDebugId
                currentId, out Microsoft.CodeAnalysis.CodeGen.LocalDebugId
                previousId)
                {
                    var return_v = this_param.TryGetPreviousLocalId(currentDeclarator, currentId, out previousId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 6457, 6553);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_764_6649_6685(Microsoft.CodeAnalysis.Emit.SymbolMatcher
                this_param, Microsoft.Cci.ITypeReference
                reference)
                {
                    var return_v = this_param.MapReference(reference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 6649, 6685);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo
                f_764_6986_7026(Microsoft.CodeAnalysis.SynthesizedLocalKind
                synthesizedKind, Microsoft.CodeAnalysis.CodeGen.LocalDebugId
                id)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo(synthesizedKind, id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 6986, 7026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EncLocalInfo
                f_764_6969_7071(Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo
                slotInfo, Microsoft.Cci.ITypeReference
                type, Microsoft.CodeAnalysis.LocalSlotConstraints
                constraints, byte[]
                signature)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EncLocalInfo(slotInfo, type, constraints, signature: signature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 6969, 7071);
                    return return_v;
                }


                bool
                f_764_7093_7148(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.EncLocalInfo, int>
                this_param, Microsoft.CodeAnalysis.Emit.EncLocalInfo
                key, out int
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 7093, 7148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_764_7232_7547(Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal
                symbolOpt, string?
                nameOpt, Microsoft.Cci.ITypeReference
                type, int
                slot, Microsoft.CodeAnalysis.SynthesizedLocalKind
                synthesizedKind, Microsoft.CodeAnalysis.CodeGen.LocalDebugId
                id, System.Reflection.Metadata.LocalVariableAttributes
                pdbAttributes, Microsoft.CodeAnalysis.LocalSlotConstraints
                constraints, System.Collections.Immutable.ImmutableArray<bool>
                dynamicTransformFlags, System.Collections.Immutable.ImmutableArray<string>
                tupleElementNames)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalDefinition(symbolOpt, nameOpt, type, slot, synthesizedKind, id, pdbAttributes, constraints, dynamicTransformFlags, tupleElementNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 7232, 7547);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(764, 5880, 7559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(764, 5880, 7559);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string? PreviousStateMachineTypeName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(764, 7624, 7648);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 7627, 7648);
                    return _stateMachineTypeName; DynAbs.Tracing.TraceSender.TraceExitMethod(764, 7624, 7648);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(764, 7624, 7648);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(764, 7624, 7648);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool TryGetPreviousHoistedLocalSlotIndex(
                    SyntaxNode currentDeclarator,
                    Cci.ITypeReference currentType,
                    SynthesizedLocalKind synthesizedKind,
                    LocalDebugId currentId,
                    DiagnosticBag diagnostics,
                    out int slotIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(764, 7661, 9006);
                Microsoft.CodeAnalysis.CodeGen.LocalDebugId previousId = default(Microsoft.CodeAnalysis.CodeGen.LocalDebugId);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 8115, 8240) || true) && (_hoistedLocalSlots == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(764, 8115, 8240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 8179, 8194);

                    slotIndex = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 8212, 8225);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(764, 8115, 8240);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 8256, 8436) || true) && (!f_764_8261_8341(this, currentDeclarator, currentId, out previousId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(764, 8256, 8436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 8375, 8390);

                    slotIndex = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 8408, 8421);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(764, 8256, 8436);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 8452, 8508);

                var
                previousType = f_764_8471_8507(_symbolMap, currentType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 8522, 8641) || true) && (previousType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(764, 8522, 8641);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 8580, 8595);

                    slotIndex = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 8613, 8626);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(764, 8522, 8641);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 8810, 8916);

                var
                localKey = f_764_8825_8915(f_764_8849_8900(synthesizedKind, previousId), previousType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 8932, 8995);

                return f_764_8939_8994(_hoistedLocalSlots, localKey, out slotIndex);
                DynAbs.Tracing.TraceSender.TraceExitMethod(764, 7661, 9006);

                bool
                f_764_8261_8341(Microsoft.CodeAnalysis.Emit.EncVariableSlotAllocator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                currentDeclarator, Microsoft.CodeAnalysis.CodeGen.LocalDebugId
                currentId, out Microsoft.CodeAnalysis.CodeGen.LocalDebugId
                previousId)
                {
                    var return_v = this_param.TryGetPreviousLocalId(currentDeclarator, currentId, out previousId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 8261, 8341);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_764_8471_8507(Microsoft.CodeAnalysis.Emit.SymbolMatcher
                this_param, Microsoft.Cci.ITypeReference
                reference)
                {
                    var return_v = this_param.MapReference(reference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 8471, 8507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo
                f_764_8849_8900(Microsoft.CodeAnalysis.SynthesizedLocalKind
                synthesizedKind, Microsoft.CodeAnalysis.CodeGen.LocalDebugId
                id)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo(synthesizedKind, id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 8849, 8900);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo
                f_764_8825_8915(Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo
                slotInfo, Microsoft.Cci.ITypeReference
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo(slotInfo, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 8825, 8915);
                    return return_v;
                }


                bool
                f_764_8939_8994(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo, int>
                this_param, Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo
                key, out int
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 8939, 8994);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(764, 7661, 9006);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(764, 7661, 9006);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int PreviousHoistedLocalSlotCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(764, 9068, 9093);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 9071, 9093);
                    return _hoistedLocalSlotCount; DynAbs.Tracing.TraceSender.TraceExitMethod(764, 9068, 9093);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(764, 9068, 9093);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(764, 9068, 9093);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int PreviousAwaiterSlotCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(764, 9149, 9165);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 9152, 9165);
                    return _awaiterCount; DynAbs.Tracing.TraceSender.TraceExitMethod(764, 9149, 9165);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(764, 9149, 9165);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(764, 9149, 9165);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool TryGetPreviousAwaiterSlotIndex(Cci.ITypeReference currentType, DiagnosticBag diagnostics, out int slotIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(764, 9178, 9685);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 9456, 9574) || true) && (_awaiterMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(764, 9456, 9574);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 9513, 9528);

                    slotIndex = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 9546, 9559);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(764, 9456, 9574);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 9590, 9674);

                return f_764_9597_9673(_awaiterMap, f_764_9621_9657(_symbolMap, currentType), out slotIndex);
                DynAbs.Tracing.TraceSender.TraceExitMethod(764, 9178, 9685);

                Microsoft.Cci.ITypeReference
                f_764_9621_9657(Microsoft.CodeAnalysis.Emit.SymbolMatcher
                this_param, Microsoft.Cci.ITypeReference
                reference)
                {
                    var return_v = this_param.MapReference(reference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 9621, 9657);
                    return return_v;
                }


                bool
                f_764_9597_9673(System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.ITypeReference, int>
                this_param, Microsoft.Cci.ITypeReference
                key, out int
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 9597, 9673);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(764, 9178, 9685);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(764, 9178, 9685);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryGetPreviousSyntaxOffset(SyntaxNode currentSyntax, out int previousSyntaxOffset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(764, 9697, 10376);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 10038, 10101);

                SyntaxNode?
                previousSyntax = f_764_10067_10100_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_syntaxMap, 764, 10067, 10100)?.Invoke(currentSyntax))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 10115, 10246) || true) && (previousSyntax == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(764, 10115, 10246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 10175, 10200);

                    previousSyntaxOffset = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 10218, 10231);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(764, 10115, 10246);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 10262, 10339);

                previousSyntaxOffset = f_764_10285_10338(this, previousSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 10353, 10365);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(764, 9697, 10376);

                Microsoft.CodeAnalysis.SyntaxNode?
                f_764_10067_10100_I(Microsoft.CodeAnalysis.SyntaxNode?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 10067, 10100);
                    return return_v;
                }


                int
                f_764_10285_10338(Microsoft.CodeAnalysis.Emit.EncVariableSlotAllocator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.CalculateSyntaxOffsetInPreviousMethod(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 10285, 10338);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(764, 9697, 10376);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(764, 9697, 10376);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryGetPreviousLambdaSyntaxOffset(SyntaxNode lambdaOrLambdaBodySyntax, bool isLambdaBody, out int previousSyntaxOffset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(764, 10388, 11958);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 10704, 10861);

                var
                currentLambdaSyntax = (DynAbs.Tracing.TraceSender.Conditional_F1(764, 10730, 10742) || ((isLambdaBody
                && DynAbs.Tracing.TraceSender.Conditional_F2(764, 10762, 10816)) || DynAbs.Tracing.TraceSender.Conditional_F3(764, 10836, 10860))) ? f_764_10762_10816(_lambdaSyntaxFacts, lambdaOrLambdaBodySyntax) : lambdaOrLambdaBodySyntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 11098, 11173);

                SyntaxNode?
                previousLambdaSyntax = f_764_11133_11172_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_syntaxMap, 764, 11133, 11172)?.Invoke(currentLambdaSyntax))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 11187, 11324) || true) && (previousLambdaSyntax == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(764, 11187, 11324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 11253, 11278);

                    previousSyntaxOffset = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 11296, 11309);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(764, 11187, 11324);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 11340, 11366);

                SyntaxNode
                previousSyntax
                = default(SyntaxNode);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 11380, 11828) || true) && (isLambdaBody)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(764, 11380, 11828);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 11430, 11544);

                    previousSyntax = f_764_11447_11543(_lambdaSyntaxFacts, previousLambdaSyntax, lambdaOrLambdaBodySyntax);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 11562, 11709) || true) && (previousSyntax == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(764, 11562, 11709);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 11630, 11655);

                        previousSyntaxOffset = 0;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 11677, 11690);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(764, 11562, 11709);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(764, 11380, 11828);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(764, 11380, 11828);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 11775, 11813);

                    previousSyntax = previousLambdaSyntax;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(764, 11380, 11828);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 11844, 11921);

                previousSyntaxOffset = f_764_11867_11920(this, previousSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 11935, 11947);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(764, 10388, 11958);

                Microsoft.CodeAnalysis.SyntaxNode
                f_764_10762_10816(Microsoft.CodeAnalysis.Emit.LambdaSyntaxFacts
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                lambdaOrLambdaBodySyntax)
                {
                    var return_v = this_param.GetLambda(lambdaOrLambdaBodySyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 10762, 10816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_764_11133_11172_I(Microsoft.CodeAnalysis.SyntaxNode?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 11133, 11172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_764_11447_11543(Microsoft.CodeAnalysis.Emit.LambdaSyntaxFacts
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                previousLambdaSyntax, Microsoft.CodeAnalysis.SyntaxNode
                lambdaOrLambdaBodySyntax)
                {
                    var return_v = this_param.TryGetCorrespondingLambdaBody(previousLambdaSyntax, lambdaOrLambdaBodySyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 11447, 11543);
                    return return_v;
                }


                int
                f_764_11867_11920(Microsoft.CodeAnalysis.Emit.EncVariableSlotAllocator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.CalculateSyntaxOffsetInPreviousMethod(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 11867, 11920);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(764, 10388, 11958);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(764, 10388, 11958);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool TryGetPreviousClosure(SyntaxNode scopeSyntax, out DebugId closureId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(764, 11970, 12397);
                int syntaxOffset = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 12084, 12323) || true) && (_closureMap != null && (DynAbs.Tracing.TraceSender.Expression_True(764, 12088, 12189) && f_764_12128_12189(this, scopeSyntax, out syntaxOffset)) && (DynAbs.Tracing.TraceSender.Expression_True(764, 12088, 12262) && f_764_12210_12262(_closureMap, syntaxOffset, out closureId)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(764, 12084, 12323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 12296, 12308);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(764, 12084, 12323);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 12339, 12359);

                closureId = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 12373, 12386);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(764, 11970, 12397);

                bool
                f_764_12128_12189(Microsoft.CodeAnalysis.Emit.EncVariableSlotAllocator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                currentSyntax, out int
                previousSyntaxOffset)
                {
                    var return_v = this_param.TryGetPreviousSyntaxOffset(currentSyntax, out previousSyntaxOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 12128, 12189);
                    return return_v;
                }


                bool
                f_764_12210_12262(System.Collections.Generic.IReadOnlyDictionary<int, Microsoft.CodeAnalysis.CodeGen.DebugId>
                this_param, int
                key, out Microsoft.CodeAnalysis.CodeGen.DebugId
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 12210, 12262);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(764, 11970, 12397);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(764, 11970, 12397);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool TryGetPreviousLambda(SyntaxNode lambdaOrLambdaBodySyntax, bool isLambdaBody, out DebugId lambdaId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(764, 12409, 12963);
                int syntaxOffset = default(int);
                System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CodeGen.DebugId, int> idAndClosureOrdinal = default(System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CodeGen.DebugId, int>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 12553, 12890) || true) && (_lambdaMap != null && (DynAbs.Tracing.TraceSender.Expression_True(764, 12557, 12690) && f_764_12596_12690(this, lambdaOrLambdaBodySyntax, isLambdaBody, out syntaxOffset)) && (DynAbs.Tracing.TraceSender.Expression_True(764, 12557, 12776) && f_764_12711_12776(_lambdaMap, syntaxOffset, out idAndClosureOrdinal)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(764, 12553, 12890);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 12810, 12845);

                    lambdaId = idAndClosureOrdinal.Key;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 12863, 12875);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(764, 12553, 12890);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 12906, 12925);

                lambdaId = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(764, 12939, 12952);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(764, 12409, 12963);

                bool
                f_764_12596_12690(Microsoft.CodeAnalysis.Emit.EncVariableSlotAllocator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                lambdaOrLambdaBodySyntax, bool
                isLambdaBody, out int
                previousSyntaxOffset)
                {
                    var return_v = this_param.TryGetPreviousLambdaSyntaxOffset(lambdaOrLambdaBodySyntax, isLambdaBody, out previousSyntaxOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 12596, 12690);
                    return return_v;
                }


                bool
                f_764_12711_12776(System.Collections.Generic.IReadOnlyDictionary<int, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CodeGen.DebugId, int>>
                this_param, int
                key, out System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CodeGen.DebugId, int>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 12711, 12776);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(764, 12409, 12963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(764, 12409, 12963);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EncVariableSlotAllocator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(764, 573, 12970);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(764, 573, 12970);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(764, 573, 12970);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(764, 573, 12970);

        static int
        f_764_2570_2606(Microsoft.CodeAnalysis.Emit.SymbolMatcher
        value)
        {
            RoslynDebug.AssertNotNull(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 2570, 2606);
            return 0;
        }


        static int
        f_764_2621_2670(Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
        value)
        {
            RoslynDebug.AssertNotNull(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 2621, 2670);
            return 0;
        }


        bool
        f_764_2698_2723_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(764, 2698, 2723);
            return return_v;
        }


        static int
        f_764_2685_2724(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 2685, 2724);
            return 0;
        }


        static System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.EncLocalInfo, int>
        f_764_3430_3465()
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.EncLocalInfo, int>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 3430, 3465);
            return return_v;
        }


        bool
        f_764_3637_3657_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(764, 3637, 3657);
            return return_v;
        }


        static int
        f_764_3624_3658(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 3624, 3658);
            return 0;
        }


        static int
        f_764_3844_3888(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.EncLocalInfo, int>
        this_param, Microsoft.CodeAnalysis.Emit.EncLocalInfo
        key, int
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(764, 3844, 3888);
            return 0;
        }

    }
}
