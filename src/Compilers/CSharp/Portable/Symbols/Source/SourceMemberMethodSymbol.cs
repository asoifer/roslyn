// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SourceMemberMethodSymbol : SourceMethodSymbolWithAttributes, IAttributeTargetSymbol
    {
        protected struct Flags
        {

            private int _flags;

            private const int
            MethodKindOffset = 0
            ;

            private const int
            MethodKindSize = 5
            ;

            private const int
            IsExtensionMethodOffset = MethodKindOffset + MethodKindSize
            ;

            private const int
            IsExtensionMethodSize = 1
            ;

            private const int
            IsMetadataVirtualIgnoringInterfaceChangesOffset = IsExtensionMethodOffset + IsExtensionMethodSize
            ;

            private const int
            IsMetadataVirtualIgnoringInterfaceChangesSize = 1
            ;

            private const int
            IsMetadataVirtualOffset = IsMetadataVirtualIgnoringInterfaceChangesOffset + IsMetadataVirtualIgnoringInterfaceChangesSize
            ;

            private const int
            IsMetadataVirtualSize = 1
            ;

            private const int
            IsMetadataVirtualLockedOffset = IsMetadataVirtualOffset + IsMetadataVirtualSize
            ;

            private const int
            IsMetadataVirtualLockedSize = 1
            ;

            private const int
            ReturnsVoidOffset = IsMetadataVirtualLockedOffset + IsMetadataVirtualLockedSize
            ;

            private const int
            ReturnsVoidSize = 2
            ;

            private const int
            NullableContextOffset = ReturnsVoidOffset + ReturnsVoidSize
            ;

            private const int
            NullableContextSize = 3
            ;

            private const int
            IsNullableAnalysisEnabledOffset = NullableContextOffset + NullableContextSize
            ;

            private const int
            IsNullableAnalysisEnabledSize = 1
            ;

            private const int
            MethodKindMask = (1 << MethodKindSize) - 1
            ;

            private const int
            IsExtensionMethodBit = 1 << IsExtensionMethodOffset
            ;

            private const int
            IsMetadataVirtualIgnoringInterfaceChangesBit = 1 << IsMetadataVirtualIgnoringInterfaceChangesOffset
            ;

            private const int
            IsMetadataVirtualBit = 1 << IsMetadataVirtualIgnoringInterfaceChangesOffset
            ;

            private const int
            IsMetadataVirtualLockedBit = 1 << IsMetadataVirtualLockedOffset
            ;

            private const int
            ReturnsVoidBit = 1 << ReturnsVoidOffset
            ;

            private const int
            ReturnsVoidIsSetBit = 1 << ReturnsVoidOffset + 1
            ;

            private const int
            NullableContextMask = (1 << NullableContextSize) - 1
            ;

            private const int
            IsNullableAnalysisEnabledBit = 1 << IsNullableAnalysisEnabledOffset
            ;

            public bool TryGetReturnsVoid(out bool value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 3742, 3967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 3820, 3838);

                    int
                    bits = _flags
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 3856, 3893);

                    value = (bits & ReturnsVoidBit) != 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 3911, 3952);

                    return (bits & ReturnsVoidIsSetBit) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 3742, 3967);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 3742, 3967);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 3742, 3967);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void SetReturnsVoid(bool value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 3983, 4169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 4054, 4154);

                    f_10259_4054_4153(ref _flags, (ReturnsVoidIsSetBit | ((DynAbs.Tracing.TraceSender.Conditional_F1(10259, 4124, 4129) || ((value && DynAbs.Tracing.TraceSender.Conditional_F2(10259, 4132, 4146)) || DynAbs.Tracing.TraceSender.Conditional_F3(10259, 4149, 4150))) ? ReturnsVoidBit : 0)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 3983, 4169);

                    bool
                    f_10259_4054_4153(ref int
                    flags, int
                    toSet)
                    {
                        var return_v = ThreadSafeFlagOperations.Set(ref flags, toSet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 4054, 4153);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 3983, 4169);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 3983, 4169);
                }
            }

            public MethodKind MethodKind
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 4246, 4321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 4252, 4319);

                        return (MethodKind)((_flags >> MethodKindOffset) & MethodKindMask);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 4246, 4321);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 4185, 4336);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 4185, 4336);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsExtensionMethod
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 4414, 4466);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 4420, 4464);

                        return (_flags & IsExtensionMethodBit) != 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 4414, 4466);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 4352, 4481);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 4352, 4481);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsNullableAnalysisEnabled
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 4567, 4627);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 4573, 4625);

                        return (_flags & IsNullableAnalysisEnabledBit) != 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 4567, 4627);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 4497, 4642);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 4497, 4642);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsMetadataVirtualLocked
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 4726, 4784);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 4732, 4782);

                        return (_flags & IsMetadataVirtualLockedBit) != 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 4726, 4784);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 4658, 4799);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 4658, 4799);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static Flags()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10259, 4826, 5128);

                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 1559, 1579);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 1612, 1630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 1665, 1724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 1757, 1782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 1817, 1914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 1947, 1996);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 2031, 2152);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 2185, 2210);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 2245, 2324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 2357, 2388);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 2423, 2502);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 2535, 2554);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 2589, 2648);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 2681, 2704);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 2739, 2816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 2849, 2882);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 2917, 2959);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 2994, 3045);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 3078, 3177);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 3210, 3285);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 3318, 3381);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 3416, 3455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 3488, 3536);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 3571, 3623);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 3658, 3725);

                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 4933, 5007);

                    f_10259_4933_5006(f_10259_4946_5005(MethodKindMask));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 5025, 5113);

                    f_10259_5025_5112(f_10259_5038_5111(NullableContextMask));
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10259, 4826, 5128);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 4826, 5128);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 4826, 5128);
                }
            }

            private static bool ModifiersRequireMetadataVirtual(DeclarationModifiers modifiers)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10259, 5152, 5404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 5268, 5389);

                    return (modifiers & (DeclarationModifiers.Abstract | DeclarationModifiers.Virtual | DeclarationModifiers.Override)) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10259, 5152, 5404);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 5152, 5404);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 5152, 5404);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public Flags(
                            MethodKind methodKind,
                            DeclarationModifiers declarationModifiers,
                            bool returnsVoid,
                            bool isExtensionMethod,
                            bool isNullableAnalysisEnabled,
                            bool isMetadataVirtualIgnoringModifiers = false)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10259, 5420, 6796);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 5757, 5874);

                    bool
                    isMetadataVirtual = isMetadataVirtualIgnoringModifiers || (DynAbs.Tracing.TraceSender.Expression_False(10259, 5782, 5873) || ModifiersRequireMetadataVirtual(declarationModifiers))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 5894, 5969);

                    int
                    methodKindInt = ((int)methodKind & MethodKindMask) << MethodKindOffset
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 5987, 6059);

                    int
                    isExtensionMethodInt = (DynAbs.Tracing.TraceSender.Conditional_F1(10259, 6014, 6031) || ((isExtensionMethod && DynAbs.Tracing.TraceSender.Conditional_F2(10259, 6034, 6054)) || DynAbs.Tracing.TraceSender.Conditional_F3(10259, 6057, 6058))) ? IsExtensionMethodBit : 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 6077, 6173);

                    int
                    isNullableAnalysisEnabledInt = (DynAbs.Tracing.TraceSender.Conditional_F1(10259, 6112, 6137) || ((isNullableAnalysisEnabled && DynAbs.Tracing.TraceSender.Conditional_F2(10259, 6140, 6168)) || DynAbs.Tracing.TraceSender.Conditional_F3(10259, 6171, 6172))) ? IsNullableAnalysisEnabledBit : 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 6191, 6325);

                    int
                    isMetadataVirtualIgnoringInterfaceImplementationChangesInt = (DynAbs.Tracing.TraceSender.Conditional_F1(10259, 6256, 6273) || ((isMetadataVirtual && DynAbs.Tracing.TraceSender.Conditional_F2(10259, 6276, 6320)) || DynAbs.Tracing.TraceSender.Conditional_F3(10259, 6323, 6324))) ? IsMetadataVirtualIgnoringInterfaceChangesBit : 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 6343, 6415);

                    int
                    isMetadataVirtualInt = (DynAbs.Tracing.TraceSender.Conditional_F1(10259, 6370, 6387) || ((isMetadataVirtual && DynAbs.Tracing.TraceSender.Conditional_F2(10259, 6390, 6410)) || DynAbs.Tracing.TraceSender.Conditional_F3(10259, 6413, 6414))) ? IsMetadataVirtualBit : 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 6435, 6781);

                    _flags = methodKindInt
                                        | isExtensionMethodInt
                                        | isNullableAnalysisEnabledInt
                                        | isMetadataVirtualIgnoringInterfaceImplementationChangesInt
                                        | isMetadataVirtualInt
                                        | ((DynAbs.Tracing.TraceSender.Conditional_F1(10259, 6704, 6715) || ((returnsVoid && DynAbs.Tracing.TraceSender.Conditional_F2(10259, 6718, 6732)) || DynAbs.Tracing.TraceSender.Conditional_F3(10259, 6735, 6736))) ? ReturnsVoidBit : 0)
                                        | ReturnsVoidIsSetBit;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10259, 5420, 6796);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 5420, 6796);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 5420, 6796);
                }
            }

            public bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 6812, 7451);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 7025, 7194) || true) && (ignoreInterfaceImplementationChanges)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 7025, 7194);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 7107, 7175);

                        return (_flags & IsMetadataVirtualIgnoringInterfaceChangesBit) != 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 7025, 7194);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 7214, 7372) || true) && (f_10259_7218_7242_M(!IsMetadataVirtualLocked))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 7214, 7372);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 7284, 7353);

                        f_10259_7284_7352(ref _flags, IsMetadataVirtualLockedBit);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 7214, 7372);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 7392, 7436);

                    return (_flags & IsMetadataVirtualBit) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 6812, 7451);

                    bool
                    f_10259_7218_7242_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 7218, 7242);
                        return return_v;
                    }


                    bool
                    f_10259_7284_7352(ref int
                    flags, int
                    toSet)
                    {
                        var return_v = ThreadSafeFlagOperations.Set(ref flags, toSet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 7284, 7352);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 6812, 7451);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 6812, 7451);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void EnsureMetadataVirtual()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 7467, 8299);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 8063, 8102);

                    f_10259_8063_8101(f_10259_8076_8100_M(!IsMetadataVirtualLocked));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 8120, 8284) || true) && ((_flags & IsMetadataVirtualBit) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 8120, 8284);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 8202, 8265);

                        f_10259_8202_8264(ref _flags, IsMetadataVirtualBit);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 8120, 8284);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 7467, 8299);

                    bool
                    f_10259_8076_8100_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 8076, 8100);
                        return return_v;
                    }


                    int
                    f_10259_8063_8101(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 8063, 8101);
                        return 0;
                    }


                    bool
                    f_10259_8202_8264(ref int
                    flags, int
                    toSet)
                    {
                        var return_v = ThreadSafeFlagOperations.Set(ref flags, toSet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 8202, 8264);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 7467, 8299);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 7467, 8299);
                }
            }

            public bool TryGetNullableContext(out byte? value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 8315, 8523);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 8398, 8508);

                    return f_10259_8405_8507(((NullableContextKind)((_flags >> NullableContextOffset) & NullableContextMask)), out value);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 8315, 8523);

                    bool
                    f_10259_8405_8507(NullableContextKind
                    kind, out byte?
                    value)
                    {
                        var return_v = kind.TryGetByte(out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 8405, 8507);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 8315, 8523);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 8315, 8523);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool SetNullableContext(byte? value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 8539, 8766);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 8615, 8751);

                    return f_10259_8622_8750(ref _flags, (((int)f_10259_8670_8700(value) & NullableContextMask) << NullableContextOffset));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 8539, 8766);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NullableContextKind
                    f_10259_8670_8700(byte?
                    value)
                    {
                        var return_v = value.ToNullableContextFlags();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 8670, 8700);
                        return return_v;
                    }


                    bool
                    f_10259_8622_8750(ref int
                    flags, int
                    toSet)
                    {
                        var return_v = ThreadSafeFlagOperations.Set(ref flags, toSet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 8622, 8750);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 8539, 8766);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 8539, 8766);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static bool
            f_10259_4946_5005(int
            mask)
            {
                var return_v = EnumUtilities.ContainsAllValues<MethodKind>(mask);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 4946, 5005);
                return return_v;
            }


            static int
            f_10259_4933_5006(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 4933, 5006);
                return 0;
            }


            static bool
            f_10259_5038_5111(int
            mask)
            {
                var return_v = EnumUtilities.ContainsAllValues<NullableContextKind>(mask);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 5038, 5111);
                return return_v;
            }


            static int
            f_10259_5025_5112(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 5025, 5112);
                return 0;
            }

        }

        protected SymbolCompletionState state;

        protected DeclarationModifiers DeclarationModifiers;

        protected Flags flags;

        private readonly NamedTypeSymbol _containingType;

        private ParameterSymbol _lazyThisParameter;

        private TypeWithAnnotations.Boxed _lazyIteratorElementType;

        private OverriddenOrHiddenMembersResult _lazyOverriddenOrHiddenMembers;

        protected ImmutableArray<Location> locations;

        protected string lazyDocComment;

        protected string lazyExpandedDocComment;

        private ImmutableArray<Diagnostic> _cachedDiagnostics;

        internal ImmutableArray<Diagnostic> Diagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 9690, 9724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 9696, 9722);

                    return _cachedDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 9690, 9724);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 9618, 9735);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 9618, 9735);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<Diagnostic> SetDiagnostics(ImmutableArray<Diagnostic> newSet, out bool diagsWritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 9747, 10134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 9993, 10083);

                diagsWritten = f_10259_10008_10082(ref _cachedDiagnostics, newSet);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 10097, 10123);

                return _cachedDiagnostics;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 9747, 10134);

                bool
                f_10259_10008_10082(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 10008, 10082);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 9747, 10134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 9747, 10134);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected SourceMemberMethodSymbol(NamedTypeSymbol containingType, SyntaxReference syntaxReferenceOpt, Location location, bool isIterator)
        : this(f_10259_10305_10319_C(containingType), syntaxReferenceOpt, f_10259_10341_10372(location), isIterator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10259, 10146, 10407);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10259, 10146, 10407);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 10146, 10407);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 10146, 10407);
            }
        }

        protected SourceMemberMethodSymbol(
                    NamedTypeSymbol containingType,
                    SyntaxReference syntaxReferenceOpt,
                    ImmutableArray<Location> locations,
                    bool isIterator)
        : base(f_10259_10648_10666_C(syntaxReferenceOpt))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10259, 10419, 11026);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 8870, 8890);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 8968, 8983);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 9018, 9036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 9081, 9105);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 9158, 9188);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 9273, 9287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 9315, 9337);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 10692, 10737);

                f_10259_10692_10736((object)containingType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 10751, 10784);

                f_10259_10751_10783(f_10259_10764_10782_M(!locations.IsEmpty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 10800, 10833);

                _containingType = containingType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 10847, 10874);

                this.locations = locations;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 10890, 11015) || true) && (isIterator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 10890, 11015);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 10938, 11000);

                    _lazyIteratorElementType = TypeWithAnnotations.Boxed.Sentinel;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 10890, 11015);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10259, 10419, 11026);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 10419, 11026);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 10419, 11026);
            }
        }

        protected void CheckEffectiveAccessibility(TypeWithAnnotations returnType, ImmutableArray<ParameterSymbol> parameters, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 11038, 12669);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 11208, 11379) || true) && (f_10259_11212_11238(this) <= Accessibility.Private || (DynAbs.Tracing.TraceSender.Expression_False(10259, 11212, 11323) || f_10259_11267_11277() == MethodKind.ExplicitInterfaceImplementation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 11208, 11379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 11357, 11364);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 11208, 11379);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 11395, 11606);

                ErrorCode
                code = (DynAbs.Tracing.TraceSender.Conditional_F1(10259, 11412, 11507) || (((f_10259_11413_11428(this) == MethodKind.Conversion || (DynAbs.Tracing.TraceSender.Expression_False(10259, 11413, 11506) || f_10259_11457_11472(this) == MethodKind.UserDefinedOperator)) && DynAbs.Tracing.TraceSender.Conditional_F2(10259, 11527, 11555)) || DynAbs.Tracing.TraceSender.Conditional_F3(10259, 11575, 11605))) ? ErrorCode.ERR_BadVisOpReturn : ErrorCode.ERR_BadVisReturnType
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 11622, 11672);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;

                // LAFHIS
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 11686, 11962);
                var temp = this.IsNoMoreVisibleThan(returnType, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 11691, 11751);
                if (!temp)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 11686, 11962);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 11888, 11947);

                    f_10259_11888_11946(                // Inconsistent accessibility: return type '{1}' is less accessible than method '{0}'
                                    diagnostics, code, f_10259_11910_11919()[0], this, returnType.Type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 11686, 11962);
                }

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 11978, 12177);

                code = (DynAbs.Tracing.TraceSender.Conditional_F1(10259, 11985, 12080) || (((f_10259_11986_12001(this) == MethodKind.Conversion || (DynAbs.Tracing.TraceSender.Expression_False(10259, 11986, 12079) || f_10259_12030_12045(this) == MethodKind.UserDefinedOperator)) && DynAbs.Tracing.TraceSender.Conditional_F2(10259, 12100, 12127)) || DynAbs.Tracing.TraceSender.Conditional_F3(10259, 12147, 12176))) ? ErrorCode.ERR_BadVisOpParam : ErrorCode.ERR_BadVisParamType;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 12193, 12592);
                    foreach (var parameter in f_10259_12219_12229_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 12193, 12592);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 12263, 12577) || true) && (!parameter.TypeWithAnnotations.IsAtLeastAsVisibleAs(this, ref useSiteDiagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 12263, 12577);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 12500, 12558);

                            f_10259_12500_12557(                    // Inconsistent accessibility: parameter type '{1}' is less accessible than method '{0}'
                                                diagnostics, code, f_10259_12522_12531()[0], this, f_10259_12542_12556(parameter));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 12263, 12577);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 12193, 12592);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10259, 1, 400);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10259, 1, 400);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 12608, 12658);

                f_10259_12608_12657(
                            diagnostics, f_10259_12624_12633()[0], useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 11038, 12669);

                Microsoft.CodeAnalysis.Accessibility
                f_10259_11212_11238(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 11212, 11238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10259_11267_11277()
                {
                    var return_v = MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 11267, 11277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10259_11413_11428(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 11413, 11428);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10259_11457_11472(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 11457, 11472);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10259_11910_11919()
                {
                    var return_v = Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 11910, 11919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10259_11888_11946(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 11888, 11946);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10259_11986_12001(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 11986, 12001);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10259_12030_12045(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 12030, 12045);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10259_12522_12531()
                {
                    var return_v = Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 12522, 12531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10259_12542_12556(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 12542, 12556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10259_12500_12557(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 12500, 12557);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10259_12219_12229_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 12219, 12229);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10259_12624_12633()
                {
                    var return_v = Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 12624, 12633);
                    return return_v;
                }


                bool
                f_10259_12608_12657(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 12608, 12657);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 11038, 12669);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 11038, 12669);
            }
        }

        protected void MakeFlags(
                    MethodKind methodKind,
                    DeclarationModifiers declarationModifiers,
                    bool returnsVoid,
                    bool isExtensionMethod,
                    bool isNullableAnalysisEnabled,
                    bool isMetadataVirtualIgnoringModifiers = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 12681, 13219);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 12998, 13042);

                DeclarationModifiers = declarationModifiers;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 13056, 13208);

                this.flags = f_10259_13069_13207(methodKind, declarationModifiers, returnsVoid, isExtensionMethod, isNullableAnalysisEnabled, isMetadataVirtualIgnoringModifiers);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 12681, 13219);

                Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol.Flags
                f_10259_13069_13207(Microsoft.CodeAnalysis.MethodKind
                methodKind, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                declarationModifiers, bool
                returnsVoid, bool
                isExtensionMethod, bool
                isNullableAnalysisEnabled, bool
                isMetadataVirtualIgnoringModifiers)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol.Flags(methodKind, declarationModifiers, returnsVoid, isExtensionMethod, isNullableAnalysisEnabled, isMetadataVirtualIgnoringModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 13069, 13207);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 12681, 13219);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 12681, 13219);
            }
        }

        protected void SetReturnsVoid(bool returnsVoid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 13231, 13353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 13303, 13342);

                this.flags.SetReturnsVoid(returnsVoid);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 13231, 13353);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 13231, 13353);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 13231, 13353);
            }
        }

        protected abstract void MethodChecks(DiagnosticBag diagnostics);

        protected virtual object MethodChecksLockObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 14214, 14253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 14220, 14251);

                    return this.syntaxReferenceOpt;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 14214, 14253);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 14142, 14264);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 14142, 14264);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected void LazyMethodChecks()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 14276, 17463);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 14334, 17452) || true) && (!state.HasComplete(CompletionPart.FinishMethodChecks))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 14334, 17452);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 14683, 14726);

                    object
                    lockObject = f_10259_14703_14725()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 14744, 14777);

                    f_10259_14744_14776(lockObject != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 14801, 14811);
                    lock (lockObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 14853, 17418) || true) && (state.NotePartComplete(CompletionPart.StartMethodChecks))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 14853, 17418);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 15183, 15229);

                            var
                            diagnostics = f_10259_15201_15228()
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 15315, 15341);

                                f_10259_15315_15340(this, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 15371, 15410);

                                f_10259_15371_15409(this, diagnostics);
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinally(10259, 15463, 15661);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 15527, 15585);

                                state.NotePartComplete(CompletionPart.FinishMethodChecks);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 15615, 15634);

                                f_10259_15615_15633(diagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitFinally(10259, 15463, 15661);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 14853, 17418);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 14853, 17418);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 14853, 17418);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 14334, 17452);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 14276, 17463);

                object
                f_10259_14703_14725()
                {
                    var return_v = MethodChecksLockObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 14703, 14725);
                    return return_v;
                }


                int
                f_10259_14744_14776(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 14744, 14776);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10259_15201_15228()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 15201, 15228);
                    return return_v;
                }


                int
                f_10259_15315_15340(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.MethodChecks(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 15315, 15340);
                    return 0;
                }


                int
                f_10259_15371_15409(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.AddDeclarationDiagnostics(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 15371, 15409);
                    return 0;
                }


                int
                f_10259_15615_15633(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 15615, 15633);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 14276, 17463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 14276, 17463);
            }
        }

        protected virtual void LazyAsyncMethodChecks(CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 17475, 17731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 17581, 17643);

                state.NotePartComplete(CompletionPart.StartAsyncMethodChecks);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 17657, 17720);

                state.NotePartComplete(CompletionPart.FinishAsyncMethodChecks);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 17475, 17731);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 17475, 17731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 17475, 17731);
            }
        }

        public sealed override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 17814, 17888);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 17850, 17873);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 17814, 17888);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 17743, 17899);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 17743, 17899);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override NamedTypeSymbol ContainingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 17982, 18056);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 18018, 18041);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 17982, 18056);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 17911, 18067);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 17911, 18067);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 18143, 18206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 18179, 18191);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 18143, 18206);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 18079, 18217);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 18079, 18217);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool ReturnsVoid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 18311, 18433);
                    bool value = default(bool);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 18347, 18387);

                    flags.TryGetReturnsVoid(out value
                    );
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 18405, 18418);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 18311, 18433);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 18254, 18444);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 18254, 18444);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override MethodKind MethodKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 18525, 18605);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 18561, 18590);

                    return this.flags.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 18525, 18605);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 18456, 18616);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 18456, 18616);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsExtensionMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 18691, 18778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 18727, 18763);

                    return this.flags.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 18691, 18778);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 18628, 18789);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 18628, 18789);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataNewSlot(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 18834, 19680);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 18950, 19223) || true) && (f_10259_18954_18987() && (DynAbs.Tracing.TraceSender.Expression_True(10259, 18954, 19018) && f_10259_18991_19018(_containingType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 18950, 19223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 19195, 19208);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 18950, 19223);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 19510, 19669);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10259, 19517, 19532) || ((f_10259_19517_19532(this) && DynAbs.Tracing.TraceSender.Conditional_F2(10259, 19552, 19588)) || DynAbs.Tracing.TraceSender.Conditional_F3(10259, 19608, 19668))) ? f_10259_19552_19588(this, out _) : f_10259_19608_19668(this, ignoreInterfaceImplementationChanges);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 18834, 19680);

                bool
                f_10259_18954_18987()
                {
                    var return_v = IsExplicitInterfaceImplementation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 18954, 18987);
                    return return_v;
                }


                bool
                f_10259_18991_19018(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 18991, 19018);
                    return return_v;
                }


                bool
                f_10259_19517_19532(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 19517, 19532);
                    return return_v;
                }


                bool
                f_10259_19552_19588(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                method, out bool
                warnAmbiguous)
                {
                    var return_v = method.RequiresExplicitOverride(out warnAmbiguous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 19552, 19588);
                    return return_v;
                }


                bool
                f_10259_19608_19668(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param, bool
                ignoreInterfaceImplementationChanges)
                {
                    var return_v = this_param.IsMetadataVirtual(ignoreInterfaceImplementationChanges);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 19608, 19668);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 18834, 19680);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 18834, 19680);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 19726, 19927);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 19842, 19916);

                return this.flags.IsMetadataVirtual(ignoreInterfaceImplementationChanges);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 19726, 19927);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 19726, 19927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 19726, 19927);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void EnsureMetadataVirtual()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 19939, 20047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 20001, 20036);

                this.flags.EnsureMetadataVirtual();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 19939, 20047);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 19939, 20047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 19939, 20047);
            }
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 20135, 20257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 20171, 20242);

                    return f_10259_20178_20241(this.DeclarationModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 20135, 20257);

                    Microsoft.CodeAnalysis.Accessibility
                    f_10259_20178_20241(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                    modifiers)
                    {
                        var return_v = ModifierUtils.EffectiveAccessibility(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 20178, 20241);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 20059, 20268);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 20059, 20268);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasExternModifier
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 20336, 20457);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 20372, 20442);

                    return (this.DeclarationModifiers & DeclarationModifiers.Extern) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 20336, 20457);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 20280, 20468);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 20280, 20468);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsExtern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 20534, 20610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 20570, 20595);

                    return f_10259_20577_20594();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 20534, 20610);

                    bool
                    f_10259_20577_20594()
                    {
                        var return_v = HasExternModifier;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 20577, 20594);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 20480, 20621);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 20480, 20621);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 20694, 20815);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 20730, 20800);

                    return (this.DeclarationModifiers & DeclarationModifiers.Sealed) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 20694, 20815);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 20633, 20826);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 20633, 20826);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 20901, 21024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 20937, 21009);

                    return (this.DeclarationModifiers & DeclarationModifiers.Abstract) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 20901, 21024);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 20838, 21035);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 20838, 21035);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 21110, 21233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 21146, 21218);

                    return (this.DeclarationModifiers & DeclarationModifiers.Override) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 21110, 21233);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 21047, 21244);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 21047, 21244);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsPartial
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 21304, 21426);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 21340, 21411);

                    return (this.DeclarationModifiers & DeclarationModifiers.Partial) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 21304, 21426);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 21256, 21437);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 21256, 21437);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 21511, 21633);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 21547, 21618);

                    return (this.DeclarationModifiers & DeclarationModifiers.Virtual) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 21511, 21633);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 21449, 21644);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 21449, 21644);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsNew
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 21700, 21818);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 21736, 21803);

                    return (this.DeclarationModifiers & DeclarationModifiers.New) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 21700, 21818);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 21656, 21829);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 21656, 21829);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 21902, 22023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 21938, 22008);

                    return (this.DeclarationModifiers & DeclarationModifiers.Static) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 21902, 22023);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 21841, 22034);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 21841, 22034);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsUnsafe
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 22093, 22214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 22129, 22199);

                    return (this.DeclarationModifiers & DeclarationModifiers.Unsafe) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 22093, 22214);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 22046, 22225);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 22046, 22225);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsAsync
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 22297, 22417);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 22333, 22402);

                    return (this.DeclarationModifiers & DeclarationModifiers.Async) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 22297, 22417);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 22237, 22428);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 22237, 22428);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsDeclaredReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 22506, 22629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 22542, 22614);

                    return (this.DeclarationModifiers & DeclarationModifiers.ReadOnly) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 22506, 22629);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 22440, 22640);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 22440, 22640);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsInitOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 22686, 22694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 22689, 22694);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 22686, 22694);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 22686, 22694);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 22686, 22694);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override Cci.CallingConvention CallingConvention
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 22796, 23232);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 22832, 22921);

                    var
                    cc = (DynAbs.Tracing.TraceSender.Conditional_F1(10259, 22841, 22849) || ((f_10259_22841_22849() && DynAbs.Tracing.TraceSender.Conditional_F2(10259, 22852, 22888)) || DynAbs.Tracing.TraceSender.Conditional_F3(10259, 22891, 22920))) ? Cci.CallingConvention.ExtraArguments : Cci.CallingConvention.Default
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 22941, 23057) || true) && (f_10259_22945_22960())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 22941, 23057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 23002, 23038);

                        cc |= Cci.CallingConvention.Generic;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 22941, 23057);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 23077, 23187) || true) && (f_10259_23081_23090_M(!IsStatic))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 23077, 23187);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 23132, 23168);

                        cc |= Cci.CallingConvention.HasThis;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 23077, 23187);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 23207, 23217);

                    return cc;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 22796, 23232);

                    bool
                    f_10259_22841_22849()
                    {
                        var return_v = IsVararg;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 22841, 22849);
                        return return_v;
                    }


                    bool
                    f_10259_22945_22960()
                    {
                        var return_v = IsGenericMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 22945, 22960);
                        return return_v;
                    }


                    bool
                    f_10259_23081_23090_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 23081, 23090);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 22707, 23243);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 22707, 23243);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal (BlockSyntax blockBody, ArrowExpressionClauseSyntax arrowBody) Bodies
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 23406, 24441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 23442, 24426);

                    switch (f_10259_23450_23460())
                    {

                        case BaseMethodDeclarationSyntax method:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 23442, 24426);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 23568, 23612);

                            return (f_10259_23576_23587(method), f_10259_23589_23610(method));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 23442, 24426);

                        case AccessorDeclarationSyntax accessor:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 23442, 24426);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 23702, 23750);

                            return (f_10259_23710_23723(accessor), f_10259_23725_23748(accessor));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 23442, 24426);

                        case ArrowExpressionClauseSyntax arrowExpression:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 23442, 24426);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 23849, 24105);

                            f_10259_23849_24104(f_10259_23862_23891(f_10259_23862_23884(arrowExpression)) == SyntaxKind.PropertyDeclaration || (DynAbs.Tracing.TraceSender.Expression_False(10259, 23862, 24029) || f_10259_23967_23996(f_10259_23967_23989(arrowExpression)) == SyntaxKind.IndexerDeclaration) || (DynAbs.Tracing.TraceSender.Expression_False(10259, 23862, 24103) || this is SynthesizedClosureMethod));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 24131, 24162);

                            return (null, arrowExpression);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 23442, 24426);

                        case BlockSyntax block:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 23442, 24426);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 24235, 24282);

                            f_10259_24235_24281(this is SynthesizedClosureMethod);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 24308, 24329);

                            return (block, null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 23442, 24426);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 23442, 24426);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 24387, 24407);

                            return (null, null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 23442, 24426);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 23406, 24441);

                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    f_10259_23450_23460()
                    {
                        var return_v = SyntaxNode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 23450, 23460);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                    f_10259_23576_23587(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Body;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 23576, 23587);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                    f_10259_23589_23610(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.ExpressionBody;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 23589, 23610);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                    f_10259_23710_23723(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Body;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 23710, 23723);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                    f_10259_23725_23748(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.ExpressionBody;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 23725, 23748);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10259_23862_23884(Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 23862, 23884);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10259_23862_23891(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 23862, 23891);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    f_10259_23967_23989(Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 23967, 23989);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10259_23967_23996(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 23967, 23996);
                        return return_v;
                    }


                    int
                    f_10259_23849_24104(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 23849, 24104);
                        return 0;
                    }


                    int
                    f_10259_24235_24281(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 24235, 24281);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 23303, 24452);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 23303, 24452);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Binder TryGetInMethodBinder(BinderFactory binderFactoryOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 24464, 25253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 24563, 24618);

                CSharpSyntaxNode
                contextNode = f_10259_24594_24617(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 24632, 24716) || true) && (contextNode == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 24632, 24716);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 24689, 24701);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 24632, 24716);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 24732, 24860);

                Binder
                result = f_10259_24748_24859((binderFactoryOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BinderFactory?>(10259, 24749, 24835) ?? f_10259_24769_24835(f_10259_24769_24794(this), f_10259_24812_24834(contextNode)))), contextNode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 24885, 24909);

                Binder
                current = result
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 24923, 25150);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 24958, 25054) || true) && (current is InMethodBinder)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 24958, 25054);
                                DynAbs.Tracing.TraceSender.TraceBreak(10259, 25029, 25035);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 24958, 25054);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 25074, 25097);

                            current = f_10259_25084_25096(current);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 24923, 25150);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 24923, 25150) || true) && (current != null)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10259, 24923, 25150);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10259, 24923, 25150);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 25166, 25206);

                f_10259_25166_25205(current is InMethodBinder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 25228, 25242);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 24464, 25253);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10259_24594_24617(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetInMethodSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 24594, 24617);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10259_24769_24794(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 24769, 24794);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10259_24812_24834(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 24812, 24834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory
                f_10259_24769_24835(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetBinderFactory(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 24769, 24835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10259_24748_24859(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 24748, 24859);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10259_25084_25096(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 25084, 25096);
                    return return_v;
                }


                int
                f_10259_25166_25205(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 25166, 25205);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 24464, 25253);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 24464, 25253);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual ExecutableCodeBinder TryGetBodyBinder(BinderFactory binderFactoryOpt = null, bool ignoreAccessibility = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 25265, 25679);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 25417, 25474);

                Binder
                inMethod = f_10259_25435_25473(this, binderFactoryOpt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 25488, 25668);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10259, 25495, 25511) || ((inMethod == null && DynAbs.Tracing.TraceSender.Conditional_F2(10259, 25514, 25518)) || DynAbs.Tracing.TraceSender.Conditional_F3(10259, 25521, 25667))) ? null : f_10259_25521_25667(f_10259_25546_25556(), this, f_10259_25564_25666(inMethod, (DynAbs.Tracing.TraceSender.Conditional_F1(10259, 25593, 25612) || ((ignoreAccessibility && DynAbs.Tracing.TraceSender.Conditional_F2(10259, 25615, 25646)) || DynAbs.Tracing.TraceSender.Conditional_F3(10259, 25649, 25665))) ? BinderFlags.IgnoreAccessibility : BinderFlags.None));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 25265, 25679);

                Microsoft.CodeAnalysis.CSharp.Binder
                f_10259_25435_25473(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory?
                binderFactoryOpt)
                {
                    var return_v = this_param.TryGetInMethodBinder(binderFactoryOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 25435, 25473);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10259_25546_25556()
                {
                    var return_v = SyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 25546, 25556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10259_25564_25666(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 25564, 25666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                f_10259_25521_25667(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                root, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                memberSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder((Microsoft.CodeAnalysis.SyntaxNode)root, (Microsoft.CodeAnalysis.CSharp.Symbol)memberSymbol, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 25521, 25667);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 25265, 25679);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 25265, 25679);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 25945, 26018);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 25981, 26003);

                    return this.locations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 25945, 26018);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 25870, 26029);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 25870, 26029);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 26041, 26489);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 26247, 26351);

                ref var
                lazyDocComment = ref (DynAbs.Tracing.TraceSender.Conditional_F1(10259, 26276, 26290) || ((expandIncludes && DynAbs.Tracing.TraceSender.Conditional_F2(10259, 26293, 26324)) || DynAbs.Tracing.TraceSender.Conditional_F3(10259, 26327, 26350))) ? ref this.lazyExpandedDocComment : ref this.lazyDocComment
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 26365, 26478);

                return f_10259_26372_26477(this, expandIncludes, ref lazyDocComment);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 26041, 26489);

                string
                f_10259_26372_26477(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                symbol, bool
                expandIncludes, ref string
                lazyXmlText)
                {
                    var return_v = SourceDocumentationCommentUtils.GetAndCacheDocumentationComment((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, expandIncludes, ref lazyXmlText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 26372, 26477);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 26041, 26489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 26041, 26489);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<CustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 26613, 26708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 26649, 26693);

                    return ImmutableArray<CustomModifier>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 26613, 26708);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 26523, 26719);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 26523, 26719);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 26843, 26936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 26879, 26921);

                    return f_10259_26886_26920(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 26843, 26936);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10259_26886_26920(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.GetTypeParametersAsTypeArguments();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 26886, 26920);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 26731, 26947);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 26731, 26947);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override int Arity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 27016, 27096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 27052, 27081);

                    return f_10259_27059_27073().Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 27016, 27096);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10259_27059_27073()
                    {
                        var return_v = TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 27059, 27073);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 26959, 27107);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 26959, 27107);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool TryGetThisParameter(out ParameterSymbol thisParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 27119, 27574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 27228, 27263);

                thisParameter = _lazyThisParameter;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 27277, 27383) || true) && ((object)thisParameter != null || (DynAbs.Tracing.TraceSender.Expression_False(10259, 27281, 27322) || f_10259_27314_27322()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 27277, 27383);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 27356, 27368);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 27277, 27383);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 27399, 27488);

                f_10259_27399_27487(ref _lazyThisParameter, f_10259_27451_27480(this), null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 27502, 27537);

                thisParameter = _lazyThisParameter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 27551, 27563);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 27119, 27574);

                bool
                f_10259_27314_27322()
                {
                    var return_v = IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 27314, 27322);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol
                f_10259_27451_27480(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                forMethod)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)forMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 27451, 27480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10259_27399_27487(ref Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol
                value, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, (Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 27399, 27487);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 27119, 27574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 27119, 27574);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeWithAnnotations IteratorElementTypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 27683, 27784);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 27719, 27769);

                    return DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_lazyIteratorElementType, 10259, 27726, 27757)?.Value ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations?>(10259, 27726, 27768) ?? default);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 27683, 27784);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 27586, 28194);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 27586, 28194);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 27798, 28183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 27834, 28018);

                    f_10259_27834_28017(_lazyIteratorElementType == TypeWithAnnotations.Boxed.Sentinel || (DynAbs.Tracing.TraceSender.Expression_False(10259, 27847, 28016) || f_10259_27913_28016(_lazyIteratorElementType.Value.Type, value.Type, TypeCompareKind.ConsiderEverything2)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 28036, 28168);

                    f_10259_28036_28167(ref _lazyIteratorElementType, f_10259_28094_28130(value), TypeWithAnnotations.Boxed.Sentinel);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 27798, 28183);

                    bool
                    f_10259_27913_28016(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    right, Microsoft.CodeAnalysis.TypeCompareKind
                    comparison)
                    {
                        var return_v = TypeSymbol.Equals(left, right, comparison);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 27913, 28016);
                        return return_v;
                    }


                    int
                    f_10259_27834_28017(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 27834, 28017);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                    f_10259_28094_28130(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    value)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 28094, 28130);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                    f_10259_28036_28167(ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 28036, 28167);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 27586, 28194);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 27586, 28194);
                }
            }
        }

        internal override bool IsIterator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 28240, 28277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 28243, 28277);
                    return _lazyIteratorElementType is object; DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 28240, 28277);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 28240, 28277);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 28240, 28277);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 28456, 28549);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 28492, 28534);

                    return ImmutableArray<MethodSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 28456, 28549);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 28354, 28560);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 28354, 28560);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override OverriddenOrHiddenMembersResult OverriddenOrHiddenMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 28679, 29041);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 28715, 28739);

                    f_10259_28715_28738(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 28757, 28968) || true) && (_lazyOverriddenOrHiddenMembers == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 28757, 28968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 28841, 28949);

                        f_10259_28841_28948(ref _lazyOverriddenOrHiddenMembers, f_10259_28905_28941(this), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 28757, 28968);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 28988, 29026);

                    return _lazyOverriddenOrHiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 28679, 29041);

                    int
                    f_10259_28715_28738(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                    this_param)
                    {
                        this_param.LazyMethodChecks();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 28715, 28738);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                    f_10259_28905_28941(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                    member)
                    {
                        var return_v = member.MakeOverriddenOrHiddenMembers();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 28905, 28941);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult?
                    f_10259_28841_28948(ref Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult?
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 28841, 28948);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 28572, 29052);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 28572, 29052);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool RequiresCompletion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 29137, 29157);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 29143, 29155);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 29137, 29157);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 29064, 29168);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 29064, 29168);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool HasComplete(CompletionPart part)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 29180, 29309);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 29267, 29298);

                return state.HasComplete(part);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 29180, 29309);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 29180, 29309);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 29180, 29309);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void ForceComplete(SourceLocation locationOpt, CancellationToken cancellationToken)
        {
            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();
                var incompletePart = state.NextIncompletePart;
                switch (incompletePart)
                {
                    case CompletionPart.Attributes:
                        GetAttributes();
                        break;

                    case CompletionPart.ReturnTypeAttributes:
                        this.GetReturnTypeAttributes();
                        break;

                    case CompletionPart.Type:
                        var unusedType = this.ReturnTypeWithAnnotations;
                        state.NotePartComplete(CompletionPart.Type);
                        break;

                    case CompletionPart.Parameters:
                        foreach (var parameter in this.Parameters)
                        {
                            parameter.ForceComplete(locationOpt, cancellationToken);
                        }

                        state.NotePartComplete(CompletionPart.Parameters);
                        break;

                    case CompletionPart.TypeParameters:
                        foreach (var typeParameter in this.TypeParameters)
                        {
                            typeParameter.ForceComplete(locationOpt, cancellationToken);
                        }

                        state.NotePartComplete(CompletionPart.TypeParameters);
                        break;

                    case CompletionPart.StartAsyncMethodChecks:
                    case CompletionPart.FinishAsyncMethodChecks:
                        LazyAsyncMethodChecks(cancellationToken);
                        break;

                    case CompletionPart.StartMethodChecks:
                    case CompletionPart.FinishMethodChecks:
                        LazyMethodChecks();
                        goto done;

                    case CompletionPart.None:
                        return;

                    default:
                        // any other values are completion parts intended for other kinds of symbols
                        state.NotePartComplete(CompletionPart.All & ~CompletionPart.MethodSymbolAll);
                        break;
                }

                state.SpinWaitComplete(incompletePart, cancellationToken);
            }

done:
// Don't return until we've seen all of the CompletionParts. This ensures all
// diagnostics have been reported (not necessarily on this thread).
            CompletionPart allParts = CompletionPart.MethodSymbolAll;
            state.SpinWaitComplete(allParts, cancellationToken);
        }

        protected sealed override void NoteAttributesComplete(bool forReturnType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 32153, 32396);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 32251, 32342);

                var
                part = (DynAbs.Tracing.TraceSender.Conditional_F1(10259, 32262, 32275) || ((forReturnType && DynAbs.Tracing.TraceSender.Conditional_F2(10259, 32278, 32313)) || DynAbs.Tracing.TraceSender.Conditional_F3(10259, 32316, 32341))) ? CompletionPart.ReturnTypeAttributes : CompletionPart.Attributes
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 32356, 32385);

                state.NotePartComplete(part);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 32153, 32396);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 32153, 32396);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 32153, 32396);
            }
        }

        internal override void AfterAddingTypeMembersChecks(ConversionsBase conversions, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 32408, 33192);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 32540, 32600);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AfterAddingTypeMembersChecks(conversions, diagnostics), 10259, 32540, 32599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 32616, 32660);

                var
                compilation = f_10259_32634_32659(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 32674, 32702);

                var
                location = locations[0]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 32718, 32911) || true) && (f_10259_32722_32740() && (DynAbs.Tracing.TraceSender.Expression_True(10259, 32722, 32770) && f_10259_32744_32770_M(!f_10259_32745_32759().IsReadOnly)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 32718, 32911);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 32804, 32896);

                    f_10259_32804_32895(compilation, diagnostics, location, modifyCompilation: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 32718, 32911);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 32927, 33181) || true) && (f_10259_32931_32977(compilation, this) && (DynAbs.Tracing.TraceSender.Expression_True(10259, 32931, 33035) && f_10259_32998_33035(this, out _)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 32927, 33181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 33069, 33166);

                    f_10259_33069_33165(compilation, diagnostics, location, modifyCompilation: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 32927, 33181);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 32408, 33192);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10259_32634_32659(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 32634, 32659);
                    return return_v;
                }


                bool
                f_10259_32722_32740()
                {
                    var return_v = IsDeclaredReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 32722, 32740);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10259_32745_32759()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 32745, 32759);
                    return return_v;
                }


                bool
                f_10259_32744_32770_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 32744, 32770);
                    return return_v;
                }


                int
                f_10259_32804_32895(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureIsReadOnlyAttributeExists(diagnostics, location, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 32804, 32895);
                    return 0;
                }


                bool
                f_10259_32931_32977(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                symbol)
                {
                    var return_v = this_param.ShouldEmitNullableAttributes((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 32931, 32977);
                    return return_v;
                }


                bool
                f_10259_32998_33035(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param, out byte
                value)
                {
                    var return_v = this_param.ShouldEmitNullableContextValue(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 32998, 33035);
                    return return_v;
                }


                int
                f_10259_33069_33165(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureNullableContextAttributeExists(diagnostics, location, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 33069, 33165);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 32408, 33192);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 32408, 33192);
            }
        }

        internal override byte? GetLocalNullableContextValue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 33395, 33718);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 33474, 33486);

                byte?
                value
                = default(byte?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 33500, 33680) || true) && (!flags.TryGetNullableContext(out value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 33500, 33680);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 33577, 33615);

                    value = f_10259_33585_33614(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 33633, 33665);

                    flags.SetNullableContext(value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 33500, 33680);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 33694, 33707);

                return value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 33395, 33718);

                byte?
                f_10259_33585_33614(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.ComputeNullableContextValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 33585, 33614);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 33395, 33718);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 33395, 33718);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private byte? ComputeNullableContextValue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 33730, 34474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 33798, 33837);

                var
                compilation = f_10259_33816_33836()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 33851, 33963) || true) && (!f_10259_33856_33902(compilation, this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 33851, 33963);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 33936, 33948);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 33851, 33963);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 33979, 34030);

                var
                builder = f_10259_33993_34029()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 34044, 34201);
                    foreach (var typeParameter in f_10259_34074_34088_I(f_10259_34074_34088()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 34044, 34201);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 34122, 34186);

                        f_10259_34122_34185(typeParameter, compilation, ref builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 34044, 34201);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10259, 1, 158);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10259, 1, 158);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 34215, 34259);

                builder.AddValue(f_10259_34232_34257());
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 34273, 34418);
                    foreach (var parameter in f_10259_34299_34309_I(f_10259_34299_34309()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 34273, 34418);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 34343, 34403);

                        f_10259_34343_34402(parameter, compilation, ref builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 34273, 34418);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10259, 1, 146);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10259, 1, 146);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 34432, 34463);

                return builder.MostCommonValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 33730, 34474);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10259_33816_33836()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 33816, 33836);
                    return return_v;
                }


                bool
                f_10259_33856_33902(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                symbol)
                {
                    var return_v = this_param.ShouldEmitNullableAttributes((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 33856, 33902);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MostCommonNullableValueBuilder
                f_10259_33993_34029()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MostCommonNullableValueBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 33993, 34029);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10259_34074_34088()
                {
                    var return_v = TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 34074, 34088);
                    return return_v;
                }


                int
                f_10259_34122_34185(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.CSharp.MostCommonNullableValueBuilder
                builder)
                {
                    this_param.GetCommonNullableValues(compilation, ref builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 34122, 34185);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10259_34074_34088_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 34074, 34088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10259_34232_34257()
                {
                    var return_v = ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 34232, 34257);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10259_34299_34309()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 34299, 34309);
                    return return_v;
                }


                int
                f_10259_34343_34402(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.CSharp.MostCommonNullableValueBuilder
                builder)
                {
                    this_param.GetCommonNullableValues(compilation, ref builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 34343, 34402);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10259_34299_34309_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 34299, 34309);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 33730, 34474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 33730, 34474);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsNullableAnalysisEnabled()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 34486, 34747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 34561, 34597);

                f_10259_34561_34596(!f_10259_34575_34595(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 34697, 34736);

                return flags.IsNullableAnalysisEnabled;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 34486, 34747);

                bool
                f_10259_34575_34595(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                method)
                {
                    var return_v = method.IsConstructor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 34575, 34595);
                    return return_v;
                }


                int
                f_10259_34561_34596(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 34561, 34596);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 34486, 34747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 34486, 34747);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 34759, 38250);
                byte nullableContextValue = default(byte);
                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol? stateMachineType = default(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 34917, 34978);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10259, 34917, 34977);

                base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 34917, 34977);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 34994, 35186) || true) && (f_10259_34998_35016() && (DynAbs.Tracing.TraceSender.Expression_True(10259, 34998, 35046) && f_10259_35020_35046_M(!f_10259_35021_35035().IsReadOnly)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 34994, 35186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 35080, 35171);

                    f_10259_35080_35170(ref attributes, f_10259_35120_35169(moduleBuilder, this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 34994, 35186);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 35202, 35246);

                var
                compilation = f_10259_35220_35245(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 35262, 35561) || true) && (f_10259_35266_35312(compilation, this) && (DynAbs.Tracing.TraceSender.Expression_True(10259, 35266, 35394) && f_10259_35333_35394(this, out nullableContextValue)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 35262, 35561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 35428, 35546);

                    f_10259_35428_35545(ref attributes, f_10259_35468_35544(moduleBuilder, this, nullableContextValue));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 35262, 35561);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 35577, 35907) || true) && (f_10259_35581_35617(this, out _))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 35577, 35907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 35794, 35892);

                    f_10259_35794_35891(ref attributes, f_10259_35834_35890(moduleBuilder));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 35577, 35907);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 35923, 35951);

                bool
                isAsync = f_10259_35938_35950(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 35965, 35999);

                bool
                isIterator = f_10259_35983_35998(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 36015, 36098) || true) && (!isAsync && (DynAbs.Tracing.TraceSender.Expression_True(10259, 36019, 36042) && !isIterator))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 36015, 36098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 36076, 36083);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 36015, 36098);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 36426, 37784) || true) && (f_10259_36430_36527(moduleBuilder.CompilationState, this, out stateMachineType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 36426, 37784);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 36561, 36739);

                    var
                    arg = f_10259_36571_36738(f_10259_36589_36644(compilation, WellKnownType.System_Type), TypedConstantKind.Type, f_10259_36691_36737(stateMachineType))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 36759, 37769) || true) && (isAsync && (DynAbs.Tracing.TraceSender.Expression_True(10259, 36763, 36784) && isIterator))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 36759, 37769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 36826, 37074);

                        f_10259_36826_37073(ref attributes, f_10259_36891_37072(compilation, WellKnownMember.System_Runtime_CompilerServices_AsyncIteratorStateMachineAttribute__ctor, f_10259_37045_37071(arg)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 36759, 37769);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 36759, 37769);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 37116, 37769) || true) && (isAsync)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 37116, 37769);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 37169, 37409);

                            f_10259_37169_37408(ref attributes, f_10259_37234_37407(compilation, WellKnownMember.System_Runtime_CompilerServices_AsyncStateMachineAttribute__ctor, f_10259_37380_37406(arg)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 37116, 37769);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 37116, 37769);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 37451, 37769) || true) && (isIterator)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 37451, 37769);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 37507, 37750);

                                f_10259_37507_37749(ref attributes, f_10259_37572_37748(compilation, WellKnownMember.System_Runtime_CompilerServices_IteratorStateMachineAttribute__ctor, f_10259_37721_37747(arg)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 37451, 37769);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 37116, 37769);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 36759, 37769);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 36426, 37784);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 37800, 38239) || true) && (isAsync && (DynAbs.Tracing.TraceSender.Expression_True(10259, 37804, 37826) && !isIterator))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 37800, 38239);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 38130, 38224);

                    f_10259_38130_38223(ref attributes, f_10259_38170_38222(compilation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 37800, 38239);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 34759, 38250);

                bool
                f_10259_34998_35016()
                {
                    var return_v = IsDeclaredReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 34998, 35016);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10259_35021_35035()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 35021, 35035);
                    return return_v;
                }


                bool
                f_10259_35020_35046_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 35020, 35046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10259_35120_35169(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                symbol)
                {
                    var return_v = this_param.SynthesizeIsReadOnlyAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 35120, 35169);
                    return return_v;
                }


                int
                f_10259_35080_35170(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 35080, 35170);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10259_35220_35245(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 35220, 35245);
                    return return_v;
                }


                bool
                f_10259_35266_35312(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                symbol)
                {
                    var return_v = this_param.ShouldEmitNullableAttributes((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 35266, 35312);
                    return return_v;
                }


                bool
                f_10259_35333_35394(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param, out byte
                value)
                {
                    var return_v = this_param.ShouldEmitNullableContextValue(out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 35333, 35394);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10259_35468_35544(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                symbol, byte
                value)
                {
                    var return_v = this_param.SynthesizeNullableContextAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 35468, 35544);
                    return return_v;
                }


                int
                f_10259_35428_35545(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 35428, 35545);
                    return 0;
                }


                bool
                f_10259_35581_35617(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                method, out bool
                warnAmbiguous)
                {
                    var return_v = method.RequiresExplicitOverride(out warnAmbiguous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 35581, 35617);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10259_35834_35890(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param)
                {
                    var return_v = this_param.SynthesizePreserveBaseOverridesAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 35834, 35890);
                    return return_v;
                }


                int
                f_10259_35794_35891(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 35794, 35891);
                    return 0;
                }


                bool
                f_10259_35938_35950(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 35938, 35950);
                    return return_v;
                }


                bool
                f_10259_35983_35998(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsIterator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 35983, 35998);
                    return return_v;
                }


                bool
                f_10259_36430_36527(Microsoft.CodeAnalysis.CSharp.ModuleCompilationState
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                method, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                stateMachineType)
                {
                    var return_v = this_param.TryGetStateMachineType((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)method, out stateMachineType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 36430, 36527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10259_36589_36644(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 36589, 36644);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10259_36691_36737(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUnboundGenericTypeOrSelf();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 36691, 36737);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10259_36571_36738(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 36571, 36738);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10259_37045_37071(Microsoft.CodeAnalysis.TypedConstant
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 37045, 37071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10259_36891_37072(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 36891, 37072);
                    return return_v;
                }


                int
                f_10259_36826_37073(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 36826, 37073);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10259_37380_37406(Microsoft.CodeAnalysis.TypedConstant
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 37380, 37406);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10259_37234_37407(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 37234, 37407);
                    return return_v;
                }


                int
                f_10259_37169_37408(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 37169, 37408);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10259_37721_37747(Microsoft.CodeAnalysis.TypedConstant
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 37721, 37747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10259_37572_37748(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 37572, 37748);
                    return return_v;
                }


                int
                f_10259_37507_37749(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 37507, 37749);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10259_38170_38222(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SynthesizeDebuggerStepThroughAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 38170, 38222);
                    return return_v;
                }


                int
                f_10259_38130_38223(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 38130, 38223);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 34759, 38250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 34759, 38250);
            }
        }

        protected void CheckModifiersForBody(Location location, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 38456, 39035);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 38563, 38858) || true) && (f_10259_38567_38575() && (DynAbs.Tracing.TraceSender.Expression_True(10259, 38567, 38590) && f_10259_38579_38590_M(!IsAbstract)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 38563, 38858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 38624, 38685);

                    f_10259_38624_38684(diagnostics, ErrorCode.ERR_ExternHasBody, location, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 38563, 38858);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 38563, 38858);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 38719, 38858) || true) && (f_10259_38723_38733() && (DynAbs.Tracing.TraceSender.Expression_True(10259, 38723, 38746) && f_10259_38737_38746_M(!IsExtern)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 38719, 38858);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 38780, 38843);

                        f_10259_38780_38842(diagnostics, ErrorCode.ERR_AbstractHasBody, location, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 38719, 38858);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 38563, 38858);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 38456, 39035);

                bool
                f_10259_38567_38575()
                {
                    var return_v = IsExtern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 38567, 38575);
                    return return_v;
                }


                bool
                f_10259_38579_38590_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 38579, 38590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10259_38624_38684(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 38624, 38684);
                    return return_v;
                }


                bool
                f_10259_38723_38733()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 38723, 38733);
                    return return_v;
                }


                bool
                f_10259_38737_38746_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 38737, 38746);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10259_38780_38842(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 38780, 38842);
                    return return_v;
                }

                // Do not report error for IsAbstract && IsExtern. Dev10 reports CS0180 only
                // in that case ("member cannot be both extern and abstract").
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 38456, 39035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 38456, 39035);
            }
        }

        protected void CheckFeatureAvailabilityAndRuntimeSupport(SyntaxNode declarationSyntax, Location location, bool hasBody, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 39047, 39843);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 39218, 39832) || true) && (f_10259_39222_39249(_containingType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 39218, 39832);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 39283, 39512) || true) && (hasBody || (DynAbs.Tracing.TraceSender.Expression_False(10259, 39287, 39331) || f_10259_39298_39331()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 39283, 39512);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 39373, 39493);

                        f_10259_39373_39492(declarationSyntax, MessageID.IDS_DefaultInterfaceImplementation, diagnostics, location);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 39283, 39512);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 39532, 39817) || true) && ((hasBody || (DynAbs.Tracing.TraceSender.Expression_False(10259, 39537, 39581) || f_10259_39548_39581()) || (DynAbs.Tracing.TraceSender.Expression_False(10259, 39537, 39593) || f_10259_39585_39593())) && (DynAbs.Tracing.TraceSender.Expression_True(10259, 39536, 39663) && f_10259_39598_39663_M(!f_10259_39599_39617().RuntimeSupportsDefaultInterfaceImplementation)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 39532, 39817);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 39705, 39798);

                        f_10259_39705_39797(diagnostics, ErrorCode.ERR_RuntimeDoesNotSupportDefaultInterfaceImplementation, location);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 39532, 39817);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 39218, 39832);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 39047, 39843);

                bool
                f_10259_39222_39249(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 39222, 39249);
                    return return_v;
                }


                bool
                f_10259_39298_39331()
                {
                    var return_v = IsExplicitInterfaceImplementation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 39298, 39331);
                    return return_v;
                }


                bool
                f_10259_39373_39492(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Binder.CheckFeatureAvailability(syntax, feature, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 39373, 39492);
                    return return_v;
                }


                bool
                f_10259_39548_39581()
                {
                    var return_v = IsExplicitInterfaceImplementation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 39548, 39581);
                    return return_v;
                }


                bool
                f_10259_39585_39593()
                {
                    var return_v = IsExtern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 39585, 39593);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10259_39599_39617()
                {
                    var return_v = ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 39599, 39617);
                    return return_v;
                }


                bool
                f_10259_39598_39663_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 39598, 39663);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10259_39705_39797(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 39705, 39797);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 39047, 39843);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 39047, 39843);
            }
        }

        internal abstract bool IsExpressionBodied { get; }

        internal override int CalculateLocalSyntaxOffset(int localPosition, SyntaxTree localTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10259, 40321, 41346);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 40435, 40489);

                f_10259_40435_40488(f_10259_40448_40474(f_10259_40448_40463(this)) == localTree);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 40505, 40582);

                (BlockSyntax blockBody, ArrowExpressionClauseSyntax expressionBody) = f_10259_40575_40581();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 40596, 40631);

                CSharpSyntaxNode
                bodySyntax = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 40741, 41275) || true) && (blockBody != null && (DynAbs.Tracing.TraceSender.Expression_True(10259, 40745, 40812) && blockBody.Span.Contains(localPosition) == true))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 40741, 41275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 40846, 40869);

                    bodySyntax = blockBody;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 40741, 41275);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 40741, 41275);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 40926, 41275) || true) && (expressionBody != null && (DynAbs.Tracing.TraceSender.Expression_True(10259, 40930, 41007) && expressionBody.Span.Contains(localPosition) == true))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 40926, 41275);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 41041, 41069);

                        bodySyntax = expressionBody;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 40926, 41275);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10259, 40926, 41275);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 41199, 41232);

                        f_10259_41199_41231(bodySyntax != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 41250, 41260);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 40926, 41275);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10259, 40741, 41275);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10259, 41291, 41335);

                return localPosition - f_10259_41314_41334(bodySyntax);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10259, 40321, 41346);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10259_40448_40463(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.SyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 40448, 40463);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10259_40448_40474(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 40448, 40474);
                    return return_v;
                }


                int
                f_10259_40435_40488(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 40435, 40488);
                    return 0;
                }


                (Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax blockBody, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax arrowBody)
                f_10259_40575_40581()
                {
                    var return_v = Bodies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 40575, 40581);
                    return return_v;
                }


                int
                f_10259_41199_41231(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 41199, 41231);
                    return 0;
                }


                int
                f_10259_41314_41334(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 41314, 41334);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10259, 40321, 41346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 40321, 41346);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SourceMemberMethodSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10259, 613, 41353);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10259, 613, 41353);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10259, 613, 41353);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10259, 613, 41353);

        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10259_10341_10372(Microsoft.CodeAnalysis.Location
        item)
        {
            var return_v = ImmutableArray.Create(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 10341, 10372);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10259_10305_10319_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10259, 10146, 10407);
            return return_v;
        }


        int
        f_10259_10692_10736(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 10692, 10736);
            return 0;
        }


        bool
        f_10259_10764_10782_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10259, 10764, 10782);
            return return_v;
        }


        int
        f_10259_10751_10783(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10259, 10751, 10783);
            return 0;
        }


        static Microsoft.CodeAnalysis.SyntaxReference
        f_10259_10648_10666_C(Microsoft.CodeAnalysis.SyntaxReference
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10259, 10419, 11026);
            return return_v;
        }

    }
}
