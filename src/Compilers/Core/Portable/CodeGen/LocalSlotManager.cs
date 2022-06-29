// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CodeGen
{
    internal sealed class LocalSlotManager
    {
        private readonly struct LocalSignature : IEquatable<LocalSignature>
        {

            private readonly Cci.ITypeReference _type;

            private readonly LocalSlotConstraints _constraints;

            internal LocalSignature(Cci.ITypeReference valType, LocalSlotConstraints constraints)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(71, 1722, 1916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 1840, 1867);

                    _constraints = constraints;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 1885, 1901);

                    _type = valType;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(71, 1722, 1916);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(71, 1722, 1916);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(71, 1722, 1916);
                }
            }

            public bool Equals(LocalSignature other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(71, 1932, 2355);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 2199, 2340);

                    return _constraints == other._constraints && (DynAbs.Tracing.TraceSender.Expression_True(71, 2206, 2339) && (f_71_2266_2338(Cci.SymbolEquivalentEqualityComparer.Instance, _type, other._type)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(71, 1932, 2355);

                    bool
                    f_71_2266_2338(Microsoft.Cci.SymbolEquivalentEqualityComparer
                    this_param, Microsoft.Cci.ITypeReference
                    x, Microsoft.Cci.ITypeReference
                    y)
                    {
                        var return_v = this_param.Equals((Microsoft.Cci.IReference)x, (Microsoft.Cci.IReference)y);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(71, 2266, 2338);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(71, 1932, 2355);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(71, 1932, 2355);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(71, 2422, 2522);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 2425, 2522);
                    return f_71_2425_2522(f_71_2438_2502(Cci.SymbolEquivalentEqualityComparer.Instance, _type), _constraints); DynAbs.Tracing.TraceSender.TraceExitMethod(71, 2422, 2522);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(71, 2422, 2522);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(71, 2422, 2522);
                }
                throw new System.Exception("Slicer error: unreachable code");

                int
                f_71_2438_2502(Microsoft.Cci.SymbolEquivalentEqualityComparer
                this_param, Microsoft.Cci.ITypeReference
                obj)
                {
                    var return_v = this_param.GetHashCode((Microsoft.Cci.IReference)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(71, 2438, 2502);
                    return return_v;
                }


                int
                f_71_2425_2522(int
                newKey, Microsoft.CodeAnalysis.LocalSlotConstraints
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, (int)currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(71, 2425, 2522);
                    return return_v;
                }

            }

            public override bool Equals(object? obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(71, 2597, 2638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 2600, 2638);
                    return obj is LocalSignature ls && (DynAbs.Tracing.TraceSender.Expression_True(71, 2600, 2638) && Equals(ls)); DynAbs.Tracing.TraceSender.TraceExitMethod(71, 2597, 2638);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(71, 2597, 2638);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(71, 2597, 2638);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static LocalSignature()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(71, 1507, 2650);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(71, 1507, 2650);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(71, 1507, 2650);
            }
        }

        private Dictionary<ILocalSymbolInternal, LocalDefinition>? _localMap;

        private KeyedStack<LocalSignature, LocalDefinition>? _freeSlots;

        private ArrayBuilder<Cci.ILocalDefinition>? _lazyAllLocals;

        private readonly VariableSlotAllocator? _slotAllocator;

        public LocalSlotManager(VariableSlotAllocator? slotAllocator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(71, 3233, 3718);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 2766, 2775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 2904, 2914);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 3003, 3017);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 3206, 3220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 3319, 3350);

                _slotAllocator = slotAllocator;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 3509, 3707) || true) && (slotAllocator != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(71, 3509, 3707);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 3568, 3626);

                    _lazyAllLocals = f_71_3585_3625();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 3644, 3692);

                    f_71_3644_3691(slotAllocator, _lazyAllLocals);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(71, 3509, 3707);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(71, 3233, 3718);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(71, 3233, 3718);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(71, 3233, 3718);
            }
        }

        private Dictionary<ILocalSymbolInternal, LocalDefinition> LocalMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(71, 3821, 4151);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 3857, 3877);

                    var
                    map = _localMap
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 3895, 4105) || true) && (map == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(71, 3895, 4105);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 3952, 4048);

                        map = f_71_3958_4047(ReferenceEqualityComparer.Instance);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 4070, 4086);

                        _localMap = map;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(71, 3895, 4105);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 4125, 4136);

                    return map;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(71, 3821, 4151);

                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal, Microsoft.CodeAnalysis.CodeGen.LocalDefinition>
                    f_71_3958_4047(Roslyn.Utilities.ReferenceEqualityComparer
                    comparer)
                    {
                        var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal, Microsoft.CodeAnalysis.CodeGen.LocalDefinition>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal>)comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(71, 3958, 4047);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(71, 3730, 4162);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(71, 3730, 4162);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private KeyedStack<LocalSignature, LocalDefinition> FreeSlots
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(71, 4260, 4562);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 4296, 4319);

                    var
                    slots = _freeSlots
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 4337, 4514) || true) && (slots == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(71, 4337, 4514);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 4396, 4454);

                        slots = f_71_4404_4453();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 4476, 4495);

                        _freeSlots = slots;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(71, 4337, 4514);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 4534, 4547);

                    return slots;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(71, 4260, 4562);

                    Microsoft.CodeAnalysis.Collections.KeyedStack<Microsoft.CodeAnalysis.CodeGen.LocalSlotManager.LocalSignature, Microsoft.CodeAnalysis.CodeGen.LocalDefinition>
                    f_71_4404_4453()
                    {
                        var return_v = new Microsoft.CodeAnalysis.Collections.KeyedStack<Microsoft.CodeAnalysis.CodeGen.LocalSlotManager.LocalSignature, Microsoft.CodeAnalysis.CodeGen.LocalDefinition>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(71, 4404, 4453);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(71, 4174, 4573);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(71, 4174, 4573);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal LocalDefinition DeclareLocal(
                    Cci.ITypeReference type,
                    ILocalSymbolInternal symbol,
                    string name,
                    SynthesizedLocalKind kind,
                    LocalDebugId id,
                    LocalVariableAttributes pdbAttributes,
                    LocalSlotConstraints constraints,
                    ImmutableArray<bool> dynamicTransformFlags,
                    ImmutableArray<string> tupleElementNames,
                    bool isSlotReusable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(71, 4585, 5459);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 5069, 5092);

                LocalDefinition?
                local
                = default(LocalDefinition?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 5108, 5377) || true) && (!isSlotReusable || (DynAbs.Tracing.TraceSender.Expression_False(71, 5112, 5198) || !f_71_5132_5198(f_71_5132_5141(), f_71_5149_5186(type, constraints), out local)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(71, 5108, 5377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 5232, 5362);

                    local = f_71_5240_5361(this, type, symbol, name, kind, id, pdbAttributes, constraints, dynamicTransformFlags, tupleElementNames);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(71, 5108, 5377);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 5393, 5421);

                f_71_5393_5420(f_71_5393_5401(), symbol, local);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 5435, 5448);

                return local;
                DynAbs.Tracing.TraceSender.TraceExitMethod(71, 4585, 5459);

                Microsoft.CodeAnalysis.Collections.KeyedStack<Microsoft.CodeAnalysis.CodeGen.LocalSlotManager.LocalSignature, Microsoft.CodeAnalysis.CodeGen.LocalDefinition>
                f_71_5132_5141()
                {
                    var return_v = FreeSlots;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(71, 5132, 5141);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalSlotManager.LocalSignature
                f_71_5149_5186(Microsoft.Cci.ITypeReference
                valType, Microsoft.CodeAnalysis.LocalSlotConstraints
                constraints)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalSlotManager.LocalSignature(valType, constraints);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(71, 5149, 5186);
                    return return_v;
                }


                bool
                f_71_5132_5198(Microsoft.CodeAnalysis.Collections.KeyedStack<Microsoft.CodeAnalysis.CodeGen.LocalSlotManager.LocalSignature, Microsoft.CodeAnalysis.CodeGen.LocalDefinition>
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalSlotManager.LocalSignature
                key, out Microsoft.CodeAnalysis.CodeGen.LocalDefinition?
                value)
                {
                    var return_v = this_param.TryPop(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(71, 5132, 5198);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_71_5240_5361(Microsoft.CodeAnalysis.CodeGen.LocalSlotManager
                this_param, Microsoft.Cci.ITypeReference
                type, Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal
                symbol, string
                name, Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind, Microsoft.CodeAnalysis.CodeGen.LocalDebugId
                id, System.Reflection.Metadata.LocalVariableAttributes
                pdbAttributes, Microsoft.CodeAnalysis.LocalSlotConstraints
                constraints, System.Collections.Immutable.ImmutableArray<bool>
                dynamicTransformFlags, System.Collections.Immutable.ImmutableArray<string>
                tupleElementNames)
                {
                    var return_v = this_param.DeclareLocalImpl(type, symbol, name, kind, id, pdbAttributes, constraints, dynamicTransformFlags, tupleElementNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(71, 5240, 5361);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal, Microsoft.CodeAnalysis.CodeGen.LocalDefinition>
                f_71_5393_5401()
                {
                    var return_v = LocalMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(71, 5393, 5401);
                    return return_v;
                }


                int
                f_71_5393_5420(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal, Microsoft.CodeAnalysis.CodeGen.LocalDefinition>
                this_param, Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal
                key, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(71, 5393, 5420);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(71, 4585, 5459);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(71, 4585, 5459);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal LocalDefinition GetLocal(ILocalSymbolInternal symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(71, 5568, 5690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 5655, 5679);

                return f_71_5662_5678(f_71_5662_5670(), symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(71, 5568, 5690);

                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal, Microsoft.CodeAnalysis.CodeGen.LocalDefinition>
                f_71_5662_5670()
                {
                    var return_v = LocalMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(71, 5662, 5670);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_71_5662_5678(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal, Microsoft.CodeAnalysis.CodeGen.LocalDefinition>
                this_param, Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(71, 5662, 5678);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(71, 5568, 5690);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(71, 5568, 5690);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void FreeLocal(ILocalSymbolInternal symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(71, 5858, 6041);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 5935, 5963);

                var
                slot = f_71_5946_5962(this, symbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 5977, 6001);

                f_71_5977_6000(f_71_5977_5985(), symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 6015, 6030);

                f_71_6015_6029(this, slot);
                DynAbs.Tracing.TraceSender.TraceExitMethod(71, 5858, 6041);

                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_71_5946_5962(Microsoft.CodeAnalysis.CodeGen.LocalSlotManager
                this_param, Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal
                symbol)
                {
                    var return_v = this_param.GetLocal(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(71, 5946, 5962);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal, Microsoft.CodeAnalysis.CodeGen.LocalDefinition>
                f_71_5977_5985()
                {
                    var return_v = LocalMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(71, 5977, 5985);
                    return return_v;
                }


                bool
                f_71_5977_6000(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal, Microsoft.CodeAnalysis.CodeGen.LocalDefinition>
                this_param, Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(71, 5977, 6000);
                    return return_v;
                }


                int
                f_71_6015_6029(Microsoft.CodeAnalysis.CodeGen.LocalSlotManager
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                slot)
                {
                    this_param.FreeSlot(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(71, 6015, 6029);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(71, 5858, 6041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(71, 5858, 6041);
            }
        }

        internal LocalDefinition AllocateSlot(
                    Cci.ITypeReference type,
                    LocalSlotConstraints constraints,
                    ImmutableArray<bool> dynamicTransformFlags = default,
                    ImmutableArray<string> tupleElementNames = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(71, 6132, 7070);
                Microsoft.CodeAnalysis.CodeGen.LocalDefinition local = default(Microsoft.CodeAnalysis.CodeGen.LocalDefinition);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 6412, 7030) || true) && (!f_71_6417_6500(f_71_6417_6426(), f_71_6434_6471(type, constraints), out local))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(71, 6412, 7030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 6534, 7015);

                    local = f_71_6542_7014(this, type: type, symbol: null, name: null, kind: SynthesizedLocalKind.EmitterTemp, id: LocalDebugId.None, pdbAttributes: LocalVariableAttributes.DebuggerHidden, constraints: constraints, dynamicTransformFlags: dynamicTransformFlags, tupleElementNames: tupleElementNames);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(71, 6412, 7030);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 7046, 7059);

                return local;
                DynAbs.Tracing.TraceSender.TraceExitMethod(71, 6132, 7070);

                Microsoft.CodeAnalysis.Collections.KeyedStack<Microsoft.CodeAnalysis.CodeGen.LocalSlotManager.LocalSignature, Microsoft.CodeAnalysis.CodeGen.LocalDefinition>
                f_71_6417_6426()
                {
                    var return_v = FreeSlots;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(71, 6417, 6426);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalSlotManager.LocalSignature
                f_71_6434_6471(Microsoft.Cci.ITypeReference
                valType, Microsoft.CodeAnalysis.LocalSlotConstraints
                constraints)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalSlotManager.LocalSignature(valType, constraints);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(71, 6434, 6471);
                    return return_v;
                }


                bool
                f_71_6417_6500(Microsoft.CodeAnalysis.Collections.KeyedStack<Microsoft.CodeAnalysis.CodeGen.LocalSlotManager.LocalSignature, Microsoft.CodeAnalysis.CodeGen.LocalDefinition>
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalSlotManager.LocalSignature
                key, out Microsoft.CodeAnalysis.CodeGen.LocalDefinition?
                value)
                {
                    var return_v = this_param.TryPop(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(71, 6417, 6500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_71_6542_7014(Microsoft.CodeAnalysis.CodeGen.LocalSlotManager
                this_param, Microsoft.Cci.ITypeReference
                type, Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal?
                symbol, string?
                name, Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind, Microsoft.CodeAnalysis.CodeGen.LocalDebugId
                id, System.Reflection.Metadata.LocalVariableAttributes
                pdbAttributes, Microsoft.CodeAnalysis.LocalSlotConstraints
                constraints, System.Collections.Immutable.ImmutableArray<bool>
                dynamicTransformFlags, System.Collections.Immutable.ImmutableArray<string>
                tupleElementNames)
                {
                    var return_v = this_param.DeclareLocalImpl(type: type, symbol: symbol, name: name, kind: kind, id: id, pdbAttributes: pdbAttributes, constraints: constraints, dynamicTransformFlags: dynamicTransformFlags, tupleElementNames: tupleElementNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(71, 6542, 7014);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(71, 6132, 7070);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(71, 6132, 7070);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private LocalDefinition DeclareLocalImpl(
                    Cci.ITypeReference type,
                    ILocalSymbolInternal? symbol,
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
                DynAbs.Tracing.TraceSender.TraceEnterMethod(71, 7082, 8942);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 7537, 7671) || true) && (_lazyAllLocals == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(71, 7537, 7671);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 7597, 7656);

                    _lazyAllLocals = f_71_7614_7655(1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(71, 7537, 7671);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 7687, 7710);

                LocalDefinition?
                local
                = default(LocalDefinition?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 7726, 8402) || true) && (symbol != null && (DynAbs.Tracing.TraceSender.Expression_True(71, 7730, 7770) && _slotAllocator != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(71, 7726, 8402);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 7804, 8176);

                    local = f_71_7812_8175(_slotAllocator, type, symbol, name, kind, id, pdbAttributes, constraints, dynamicTransformFlags: dynamicTransformFlags, tupleElementNames: tupleElementNames);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 8196, 8387) || true) && (local != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(71, 8196, 8387);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 8255, 8282);

                        int
                        slot = f_71_8266_8281(local)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 8304, 8333);

                        _lazyAllLocals[slot] = local;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 8355, 8368);

                        return local;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(71, 8196, 8387);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(71, 7726, 8402);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 8418, 8862);

                local = f_71_8426_8861(symbolOpt: symbol, nameOpt: name, type: type, slot: f_71_8567_8587(_lazyAllLocals), synthesizedKind: kind, id: id, pdbAttributes: pdbAttributes, constraints: constraints, dynamicTransformFlags: dynamicTransformFlags, tupleElementNames: tupleElementNames);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 8878, 8904);

                f_71_8878_8903(
                            _lazyAllLocals, local);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 8918, 8931);

                return local;
                DynAbs.Tracing.TraceSender.TraceExitMethod(71, 7082, 8942);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ILocalDefinition>
                f_71_7614_7655(int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ILocalDefinition>(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(71, 7614, 7655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition?
                f_71_7812_8175(Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                this_param, Microsoft.Cci.ITypeReference
                type, Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal
                symbol, string?
                name, Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind, Microsoft.CodeAnalysis.CodeGen.LocalDebugId
                id, System.Reflection.Metadata.LocalVariableAttributes
                pdbAttributes, Microsoft.CodeAnalysis.LocalSlotConstraints
                constraints, System.Collections.Immutable.ImmutableArray<bool>
                dynamicTransformFlags, System.Collections.Immutable.ImmutableArray<string>
                tupleElementNames)
                {
                    var return_v = this_param.GetPreviousLocal(type, symbol, name, kind, id, pdbAttributes, constraints, dynamicTransformFlags: dynamicTransformFlags, tupleElementNames: tupleElementNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(71, 7812, 8175);
                    return return_v;
                }


                int
                f_71_8266_8281(Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                this_param)
                {
                    var return_v = this_param.SlotIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(71, 8266, 8281);
                    return return_v;
                }


                int
                f_71_8567_8587(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ILocalDefinition>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(71, 8567, 8587);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_71_8426_8861(Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal?
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
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalDefinition(symbolOpt: symbolOpt, nameOpt: nameOpt, type: type, slot: slot, synthesizedKind: synthesizedKind, id: id, pdbAttributes: pdbAttributes, constraints: constraints, dynamicTransformFlags: dynamicTransformFlags, tupleElementNames: tupleElementNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(71, 8426, 8861);
                    return return_v;
                }


                int
                f_71_8878_8903(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ILocalDefinition>
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                item)
                {
                    this_param.Add((Microsoft.Cci.ILocalDefinition)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(71, 8878, 8903);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(71, 7082, 8942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(71, 7082, 8942);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void FreeSlot(LocalDefinition slot)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(71, 9034, 9230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 9103, 9135);

                f_71_9103_9134(f_71_9116_9125(slot) == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 9149, 9219);

                f_71_9149_9218(f_71_9149_9158(), f_71_9164_9211(f_71_9183_9192(slot), f_71_9194_9210(slot)), slot);
                DynAbs.Tracing.TraceSender.TraceExitMethod(71, 9034, 9230);

                string?
                f_71_9116_9125(Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(71, 9116, 9125);
                    return return_v;
                }


                int
                f_71_9103_9134(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(71, 9103, 9134);
                    return 0;
                }


                Microsoft.CodeAnalysis.Collections.KeyedStack<Microsoft.CodeAnalysis.CodeGen.LocalSlotManager.LocalSignature, Microsoft.CodeAnalysis.CodeGen.LocalDefinition>
                f_71_9149_9158()
                {
                    var return_v = FreeSlots;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(71, 9149, 9158);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_71_9183_9192(Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(71, 9183, 9192);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalSlotConstraints
                f_71_9194_9210(Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                this_param)
                {
                    var return_v = this_param.Constraints;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(71, 9194, 9210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalSlotManager.LocalSignature
                f_71_9164_9211(Microsoft.Cci.ITypeReference
                valType, Microsoft.CodeAnalysis.LocalSlotConstraints
                constraints)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalSlotManager.LocalSignature(valType, constraints);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(71, 9164, 9211);
                    return return_v;
                }


                int
                f_71_9149_9218(Microsoft.CodeAnalysis.Collections.KeyedStack<Microsoft.CodeAnalysis.CodeGen.LocalSlotManager.LocalSignature, Microsoft.CodeAnalysis.CodeGen.LocalDefinition>
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalSlotManager.LocalSignature
                key, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                value)
                {
                    this_param.Push(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(71, 9149, 9218);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(71, 9034, 9230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(71, 9034, 9230);
            }
        }

        public ImmutableArray<Cci.ILocalDefinition> LocalsInOrder()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(71, 9242, 9564);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 9326, 9553) || true) && (_lazyAllLocals == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(71, 9326, 9553);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 9386, 9436);

                    return ImmutableArray<Cci.ILocalDefinition>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(71, 9326, 9553);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(71, 9326, 9553);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(71, 9502, 9538);

                    return f_71_9509_9537(_lazyAllLocals);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(71, 9326, 9553);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(71, 9242, 9564);

                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                f_71_9509_9537(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ILocalDefinition>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(71, 9509, 9537);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(71, 9242, 9564);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(71, 9242, 9564);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LocalSlotManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(71, 1202, 9571);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(71, 1202, 9571);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(71, 1202, 9571);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(71, 1202, 9571);

        static Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ILocalDefinition>
        f_71_3585_3625()
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ILocalDefinition>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(71, 3585, 3625);
            return return_v;
        }


        static int
        f_71_3644_3691(Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
        this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ILocalDefinition>
        builder)
        {
            this_param.AddPreviousLocals(builder);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(71, 3644, 3691);
            return 0;
        }

    }
}
