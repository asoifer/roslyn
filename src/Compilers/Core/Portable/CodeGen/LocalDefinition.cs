// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CodeGen
{
    [DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
    internal sealed class LocalDefinition : Cci.ILocalDefinition
    {
        private readonly ILocalSymbolInternal? _symbolOpt;

        private readonly string? _nameOpt;

        private readonly Cci.ITypeReference _type;

        private readonly LocalSlotConstraints _constraints;

        private readonly int _slot;

        private readonly LocalSlotDebugInfo _slotInfo;

        private readonly LocalVariableAttributes _pdbAttributes;

        private readonly ImmutableArray<bool> _dynamicTransformFlags;

        private readonly ImmutableArray<string> _tupleElementNames;

        public LocalDefinition(
                    ILocalSymbolInternal? symbolOpt,
                    string? nameOpt,
                    Cci.ITypeReference type,
                    int slot,
                    SynthesizedLocalKind synthesizedKind,
                    LocalDebugId id,
                    LocalVariableAttributes pdbAttributes,
                    LocalSlotConstraints constraints,
                    ImmutableArray<bool> dynamicTransformFlags,
                    ImmutableArray<string> tupleElementNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(67, 3113, 4009);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 956, 966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 1004, 1012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 1124, 1129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 1608, 1620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 1718, 1723);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 1898, 1912);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 3590, 3613);

                _symbolOpt = symbolOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 3627, 3646);

                _nameOpt = nameOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 3660, 3673);

                _type = type;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 3687, 3700);

                _slot = slot;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 3714, 3770);

                _slotInfo = f_67_3726_3769(synthesizedKind, id);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 3784, 3815);

                _pdbAttributes = pdbAttributes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 3829, 3890);

                _dynamicTransformFlags = dynamicTransformFlags.NullToEmpty();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 3904, 3957);

                _tupleElementNames = tupleElementNames.NullToEmpty();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 3971, 3998);

                _constraints = constraints;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(67, 3113, 4009);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(67, 3113, 4009);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(67, 3113, 4009);
            }
        }

        internal string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(67, 4071, 4121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 4074, 4121);
                return $"{_slot}: {_nameOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(67, 4086, 4109) ?? "<unnamed>")} ({_type})"; DynAbs.Tracing.TraceSender.TraceExitMethod(67, 4071, 4121);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(67, 4071, 4121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(67, 4071, 4121);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ILocalSymbolInternal? SymbolOpt
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(67, 4173, 4186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 4176, 4186);
                    return _symbolOpt; DynAbs.Tracing.TraceSender.TraceExitMethod(67, 4173, 4186);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(67, 4173, 4186);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(67, 4173, 4186);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Location Location
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(67, 4248, 4625);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 4284, 4571) || true) && (_symbolOpt != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(67, 4284, 4571);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 4348, 4406);

                        ImmutableArray<Location>
                        locations = f_67_4385_4405(_symbolOpt)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 4428, 4552) || true) && (f_67_4432_4459_M(!locations.IsDefaultOrEmpty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(67, 4428, 4552);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 4509, 4529);

                            return locations[0];
                            DynAbs.Tracing.TraceSender.TraceExitCondition(67, 4428, 4552);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(67, 4284, 4571);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 4589, 4610);

                    return f_67_4596_4609();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(67, 4248, 4625);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_67_4385_4405(Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(67, 4385, 4405);
                        return return_v;
                    }


                    bool
                    f_67_4432_4459_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(67, 4432, 4459);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_67_4596_4609()
                    {
                        var return_v = Location.None;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(67, 4596, 4609);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(67, 4199, 4636);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(67, 4199, 4636);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int SlotIndex
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(67, 4669, 4677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 4672, 4677);
                    return _slot; DynAbs.Tracing.TraceSender.TraceExitMethod(67, 4669, 4677);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(67, 4669, 4677);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(67, 4669, 4677);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public MetadataConstant CompileTimeValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(67, 4755, 4800);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 4761, 4798);

                    throw f_67_4767_4797();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(67, 4755, 4800);

                    System.Exception
                    f_67_4767_4797()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(67, 4767, 4797);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(67, 4690, 4811);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(67, 4690, 4811);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<Cci.ICustomModifier> CustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(67, 4895, 4939);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 4898, 4939);
                    return ImmutableArray<Cci.ICustomModifier>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(67, 4895, 4939);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(67, 4895, 4939);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(67, 4895, 4939);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsConstant
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(67, 4999, 5044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 5005, 5042);

                    throw f_67_5011_5041();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(67, 4999, 5044);

                    System.Exception
                    f_67_5011_5041()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(67, 5011, 5041);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(67, 4952, 5055);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(67, 4952, 5055);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsModified
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(67, 5090, 5098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 5093, 5098);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(67, 5090, 5098);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(67, 5090, 5098);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(67, 5090, 5098);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public LocalSlotConstraints Constraints
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(67, 5151, 5166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 5154, 5166);
                    return _constraints; DynAbs.Tracing.TraceSender.TraceExitMethod(67, 5151, 5166);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(67, 5151, 5166);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(67, 5151, 5166);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsPinned
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(67, 5213, 5265);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 5216, 5265);
                    return (_constraints & LocalSlotConstraints.Pinned) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(67, 5213, 5265);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(67, 5213, 5265);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(67, 5213, 5265);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(67, 5315, 5366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 5318, 5366);
                    return (_constraints & LocalSlotConstraints.ByRef) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(67, 5315, 5366);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(67, 5315, 5366);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(67, 5315, 5366);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public LocalVariableAttributes PdbAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(67, 5424, 5441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 5427, 5441);
                    return _pdbAttributes; DynAbs.Tracing.TraceSender.TraceExitMethod(67, 5424, 5441);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(67, 5424, 5441);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(67, 5424, 5441);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<bool> DynamicTransformFlags
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(67, 5504, 5529);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 5507, 5529);
                    return _dynamicTransformFlags; DynAbs.Tracing.TraceSender.TraceExitMethod(67, 5504, 5529);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(67, 5504, 5529);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(67, 5504, 5529);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<string> TupleElementNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(67, 5590, 5611);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 5593, 5611);
                    return _tupleElementNames; DynAbs.Tracing.TraceSender.TraceExitMethod(67, 5590, 5611);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(67, 5590, 5611);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(67, 5590, 5611);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Cci.ITypeReference Type
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(67, 5655, 5663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 5658, 5663);
                    return _type; DynAbs.Tracing.TraceSender.TraceExitMethod(67, 5655, 5663);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(67, 5655, 5663);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(67, 5655, 5663);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string? Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(67, 5696, 5707);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 5699, 5707);
                    return _nameOpt; DynAbs.Tracing.TraceSender.TraceExitMethod(67, 5696, 5707);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(67, 5696, 5707);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(67, 5696, 5707);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public byte[]? Signature
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(67, 5745, 5752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 5748, 5752);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(67, 5745, 5752);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(67, 5745, 5752);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(67, 5745, 5752);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public LocalSlotDebugInfo SlotInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(67, 5800, 5812);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(67, 5803, 5812);
                    return _slotInfo; DynAbs.Tracing.TraceSender.TraceExitMethod(67, 5800, 5812);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(67, 5800, 5812);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(67, 5800, 5812);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static LocalDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(67, 422, 5820);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(67, 422, 5820);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(67, 422, 5820);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(67, 422, 5820);

        static Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo
        f_67_3726_3769(Microsoft.CodeAnalysis.SynthesizedLocalKind
        synthesizedKind, Microsoft.CodeAnalysis.CodeGen.LocalDebugId
        id)
        {
            var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo(synthesizedKind, id);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(67, 3726, 3769);
            return return_v;
        }

    }
}
