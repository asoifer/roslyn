// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Reflection.Metadata;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.DocumentationComments;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE
{
    internal sealed class PEMethodSymbol : MethodSymbol
    {
        internal class SignatureData
        {
            public readonly SignatureHeader Header;

            public readonly ImmutableArray<ParameterSymbol> Parameters;

            public readonly PEParameterSymbol ReturnParam;

            public SignatureData(SignatureHeader header, ImmutableArray<ParameterSymbol> parameters, PEParameterSymbol returnParam)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10707, 1209, 1493);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 1181, 1192);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 1361, 1382);

                    this.Header = header;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 1400, 1429);

                    this.Parameters = parameters;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 1447, 1478);

                    this.ReturnParam = returnParam;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10707, 1209, 1493);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 1209, 1493);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 1209, 1493);
                }
            }

            static SignatureData()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10707, 968, 1504);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10707, 968, 1504);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 968, 1504);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10707, 968, 1504);
        }

        private struct PackedFlags
        {

            private const int
            MethodKindOffset = 0
            ;

            private const int
            MethodKindMask = 0x1F
            ;

            private const int
            MethodKindIsPopulatedBit = 0x1 << 5
            ;

            private const int
            IsExtensionMethodBit = 0x1 << 6
            ;

            private const int
            IsExtensionMethodIsPopulatedBit = 0x1 << 7
            ;

            private const int
            IsExplicitFinalizerOverrideBit = 0x1 << 8
            ;

            private const int
            IsExplicitClassOverrideBit = 0x1 << 9
            ;

            private const int
            IsExplicitOverrideIsPopulatedBit = 0x1 << 10
            ;

            private const int
            IsObsoleteAttributePopulatedBit = 0x1 << 11
            ;

            private const int
            IsCustomAttributesPopulatedBit = 0x1 << 12
            ;

            private const int
            IsUseSiteDiagnosticPopulatedBit = 0x1 << 13
            ;

            private const int
            IsConditionalPopulatedBit = 0x1 << 14
            ;

            private const int
            IsOverriddenOrHiddenMembersPopulatedBit = 0x1 << 15
            ;

            private const int
            IsReadOnlyBit = 0x1 << 16
            ;

            private const int
            IsReadOnlyPopulatedBit = 0x1 << 17
            ;

            private const int
            NullableContextOffset = 18
            ;

            private const int
            NullableContextMask = 0x7
            ;

            private const int
            DoesNotReturnBit = 0x1 << 21
            ;

            private const int
            IsDoesNotReturnPopulatedBit = 0x1 << 22
            ;

            private const int
            IsMemberNotNullPopulatedBit = 0x1 << 23
            ;

            private const int
            IsInitOnlyBit = 0x1 << 24
            ;

            private const int
            IsInitOnlyPopulatedBit = 0x1 << 25
            ;

            private const int
            IsUnmanagedCallersOnlyAttributePopulatedBit = 0x1 << 26
            ;

            private int _bits;

            public MethodKind MethodKind
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 4723, 4852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 4767, 4833);

                        return (MethodKind)((_bits >> MethodKindOffset) & MethodKindMask);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 4723, 4852);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 4662, 5167);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 4662, 5167);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                set
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 4872, 5152);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 4916, 4974);

                        f_10707_4916_4973((int)value == ((int)value & MethodKindMask));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 4996, 5133);

                        _bits = (_bits & ~(MethodKindMask << MethodKindOffset)) | (((int)value & MethodKindMask) << MethodKindOffset) | MethodKindIsPopulatedBit;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 4872, 5152);

                        int
                        f_10707_4916_4973(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 4916, 4973);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 4662, 5167);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 4662, 5167);
                    }
                }
            }

            public bool MethodKindIsPopulated
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 5217, 5259);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 5220, 5259);
                        return (_bits & MethodKindIsPopulatedBit) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 5217, 5259);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 5217, 5259);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 5217, 5259);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 5304, 5342);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 5307, 5342);
                        return (_bits & IsExtensionMethodBit) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 5304, 5342);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 5304, 5342);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 5304, 5342);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsExtensionMethodIsPopulated
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 5398, 5447);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 5401, 5447);
                        return (_bits & IsExtensionMethodIsPopulatedBit) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 5398, 5447);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 5398, 5447);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 5398, 5447);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsExplicitFinalizerOverride
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 5502, 5550);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 5505, 5550);
                        return (_bits & IsExplicitFinalizerOverrideBit) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 5502, 5550);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 5502, 5550);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 5502, 5550);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsExplicitClassOverride
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 5601, 5645);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 5604, 5645);
                        return (_bits & IsExplicitClassOverrideBit) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 5601, 5645);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 5601, 5645);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 5601, 5645);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsExplicitOverrideIsPopulated
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 5702, 5752);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 5705, 5752);
                        return (_bits & IsExplicitOverrideIsPopulatedBit) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 5702, 5752);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 5702, 5752);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 5702, 5752);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsObsoleteAttributePopulated
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 5808, 5857);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 5811, 5857);
                        return (_bits & IsObsoleteAttributePopulatedBit) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 5808, 5857);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 5808, 5857);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 5808, 5857);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsCustomAttributesPopulated
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 5912, 5960);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 5915, 5960);
                        return (_bits & IsCustomAttributesPopulatedBit) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 5912, 5960);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 5912, 5960);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 5912, 5960);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsUseSiteDiagnosticPopulated
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 6016, 6065);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 6019, 6065);
                        return (_bits & IsUseSiteDiagnosticPopulatedBit) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 6016, 6065);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 6016, 6065);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 6016, 6065);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsConditionalPopulated
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 6115, 6158);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 6118, 6158);
                        return (_bits & IsConditionalPopulatedBit) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 6115, 6158);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 6115, 6158);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 6115, 6158);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsOverriddenOrHiddenMembersPopulated
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 6222, 6279);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 6225, 6279);
                        return (_bits & IsOverriddenOrHiddenMembersPopulatedBit) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 6222, 6279);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 6222, 6279);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 6222, 6279);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsReadOnly
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 6317, 6348);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 6320, 6348);
                        return (_bits & IsReadOnlyBit) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 6317, 6348);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 6317, 6348);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 6317, 6348);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsReadOnlyPopulated
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 6395, 6435);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 6398, 6435);
                        return (_bits & IsReadOnlyPopulatedBit) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 6395, 6435);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 6395, 6435);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 6395, 6435);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool DoesNotReturn
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 6476, 6510);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 6479, 6510);
                        return (_bits & DoesNotReturnBit) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 6476, 6510);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 6476, 6510);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 6476, 6510);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsDoesNotReturnPopulated
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 6562, 6607);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 6565, 6607);
                        return (_bits & IsDoesNotReturnPopulatedBit) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 6562, 6607);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 6562, 6607);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 6562, 6607);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsMemberNotNullPopulated
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 6659, 6704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 6662, 6704);
                        return (_bits & IsMemberNotNullPopulatedBit) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 6659, 6704);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 6659, 6704);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 6659, 6704);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsInitOnly
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 6742, 6773);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 6745, 6773);
                        return (_bits & IsInitOnlyBit) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 6742, 6773);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 6742, 6773);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 6742, 6773);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsInitOnlyPopulated
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 6820, 6860);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 6823, 6860);
                        return (_bits & IsInitOnlyPopulatedBit) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 6820, 6860);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 6820, 6860);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 6820, 6860);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsUnmanagedCallersOnlyAttributePopulated
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 6928, 6989);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 6931, 6989);
                        return (_bits & IsUnmanagedCallersOnlyAttributePopulatedBit) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 6928, 6989);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 6928, 6989);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 6928, 6989);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static PackedFlags()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10707, 7017, 7325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 3066, 3086);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 3119, 3140);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 3175, 3210);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 3243, 3274);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 3307, 3349);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 3382, 3423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 3456, 3493);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 3526, 3570);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 3603, 3646);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 3679, 3721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 3754, 3797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 3830, 3867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 3900, 3951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 3984, 4009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 4042, 4076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 4109, 4135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 4168, 4193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 4226, 4254);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 4287, 4326);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 4359, 4398);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 4431, 4456);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 4489, 4523);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 4556, 4611);

                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 7130, 7204);

                    f_10707_7130_7203(f_10707_7143_7202(MethodKindMask));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 7222, 7310);

                    f_10707_7222_7309(f_10707_7235_7308(NullableContextMask));
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10707, 7017, 7325);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 7017, 7325);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 7017, 7325);
                }
            }

            private static bool BitsAreUnsetOrSame(int bits, int mask)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10707, 7349, 7506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 7440, 7491);

                    return (bits & mask) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10707, 7447, 7490) || (bits & mask) == mask);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10707, 7349, 7506);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 7349, 7506);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 7349, 7506);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void InitializeIsExtensionMethod(bool isExtensionMethod)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 7522, 7868);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 7618, 7715);

                    int
                    bitsToSet = ((DynAbs.Tracing.TraceSender.Conditional_F1(10707, 7635, 7652) || ((isExtensionMethod && DynAbs.Tracing.TraceSender.Conditional_F2(10707, 7655, 7675)) || DynAbs.Tracing.TraceSender.Conditional_F3(10707, 7678, 7679))) ? IsExtensionMethodBit : 0) | IsExtensionMethodIsPopulatedBit
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 7733, 7784);

                    f_10707_7733_7783(BitsAreUnsetOrSame(_bits, bitsToSet));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 7802, 7853);

                    f_10707_7802_7852(ref _bits, bitsToSet);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 7522, 7868);

                    int
                    f_10707_7733_7783(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 7733, 7783);
                        return 0;
                    }


                    bool
                    f_10707_7802_7852(ref int
                    flags, int
                    toSet)
                    {
                        var return_v = ThreadSafeFlagOperations.Set(ref flags, toSet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 7802, 7852);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 7522, 7868);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 7522, 7868);
                }
            }

            public void InitializeIsReadOnly(bool isReadOnly)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 7884, 8193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 7966, 8040);

                    int
                    bitsToSet = ((DynAbs.Tracing.TraceSender.Conditional_F1(10707, 7983, 7993) || ((isReadOnly && DynAbs.Tracing.TraceSender.Conditional_F2(10707, 7996, 8009)) || DynAbs.Tracing.TraceSender.Conditional_F3(10707, 8012, 8013))) ? IsReadOnlyBit : 0) | IsReadOnlyPopulatedBit
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 8058, 8109);

                    f_10707_8058_8108(BitsAreUnsetOrSame(_bits, bitsToSet));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 8127, 8178);

                    f_10707_8127_8177(ref _bits, bitsToSet);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 7884, 8193);

                    int
                    f_10707_8058_8108(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 8058, 8108);
                        return 0;
                    }


                    bool
                    f_10707_8127_8177(ref int
                    flags, int
                    toSet)
                    {
                        var return_v = ThreadSafeFlagOperations.Set(ref flags, toSet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 8127, 8177);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 7884, 8193);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 7884, 8193);
                }
            }

            public void InitializeMethodKind(MethodKind methodKind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 8209, 8636);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 8297, 8365);

                    f_10707_8297_8364((int)methodKind == ((int)methodKind & MethodKindMask));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 8383, 8483);

                    int
                    bitsToSet = (((int)methodKind & MethodKindMask) << MethodKindOffset) | MethodKindIsPopulatedBit
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 8501, 8552);

                    f_10707_8501_8551(BitsAreUnsetOrSame(_bits, bitsToSet));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 8570, 8621);

                    f_10707_8570_8620(ref _bits, bitsToSet);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 8209, 8636);

                    int
                    f_10707_8297_8364(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 8297, 8364);
                        return 0;
                    }


                    int
                    f_10707_8501_8551(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 8501, 8551);
                        return 0;
                    }


                    bool
                    f_10707_8570_8620(ref int
                    flags, int
                    toSet)
                    {
                        var return_v = ThreadSafeFlagOperations.Set(ref flags, toSet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 8570, 8620);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 8209, 8636);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 8209, 8636);
                }
            }

            public void InitializeIsExplicitOverride(bool isExplicitFinalizerOverride, bool isExplicitClassOverride)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 8652, 9184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 8789, 9031);

                    int
                    bitsToSet =
                                        ((DynAbs.Tracing.TraceSender.Conditional_F1(10707, 8827, 8854) || ((isExplicitFinalizerOverride && DynAbs.Tracing.TraceSender.Conditional_F2(10707, 8857, 8887)) || DynAbs.Tracing.TraceSender.Conditional_F3(10707, 8890, 8891))) ? IsExplicitFinalizerOverrideBit : 0) |
                                        ((DynAbs.Tracing.TraceSender.Conditional_F1(10707, 8917, 8940) || ((isExplicitClassOverride && DynAbs.Tracing.TraceSender.Conditional_F2(10707, 8943, 8969)) || DynAbs.Tracing.TraceSender.Conditional_F3(10707, 8972, 8973))) ? IsExplicitClassOverrideBit : 0) |
                                        IsExplicitOverrideIsPopulatedBit
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 9049, 9100);

                    f_10707_9049_9099(BitsAreUnsetOrSame(_bits, bitsToSet));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 9118, 9169);

                    f_10707_9118_9168(ref _bits, bitsToSet);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 8652, 9184);

                    int
                    f_10707_9049_9099(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 9049, 9099);
                        return 0;
                    }


                    bool
                    f_10707_9118_9168(ref int
                    flags, int
                    toSet)
                    {
                        var return_v = ThreadSafeFlagOperations.Set(ref flags, toSet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 9118, 9168);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 8652, 9184);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 8652, 9184);
                }
            }

            public void SetIsObsoleteAttributePopulated()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 9200, 9366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 9278, 9351);

                    f_10707_9278_9350(ref _bits, IsObsoleteAttributePopulatedBit);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 9200, 9366);

                    bool
                    f_10707_9278_9350(ref int
                    flags, int
                    toSet)
                    {
                        var return_v = ThreadSafeFlagOperations.Set(ref flags, toSet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 9278, 9350);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 9200, 9366);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 9200, 9366);
                }
            }

            public void SetIsCustomAttributesPopulated()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 9382, 9546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 9459, 9531);

                    f_10707_9459_9530(ref _bits, IsCustomAttributesPopulatedBit);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 9382, 9546);

                    bool
                    f_10707_9459_9530(ref int
                    flags, int
                    toSet)
                    {
                        var return_v = ThreadSafeFlagOperations.Set(ref flags, toSet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 9459, 9530);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 9382, 9546);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 9382, 9546);
                }
            }

            public void SetIsUseSiteDiagnosticPopulated()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 9562, 9728);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 9640, 9713);

                    f_10707_9640_9712(ref _bits, IsUseSiteDiagnosticPopulatedBit);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 9562, 9728);

                    bool
                    f_10707_9640_9712(ref int
                    flags, int
                    toSet)
                    {
                        var return_v = ThreadSafeFlagOperations.Set(ref flags, toSet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 9640, 9712);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 9562, 9728);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 9562, 9728);
                }
            }

            public void SetIsConditionalAttributePopulated()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 9744, 9907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 9825, 9892);

                    f_10707_9825_9891(ref _bits, IsConditionalPopulatedBit);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 9744, 9907);

                    bool
                    f_10707_9825_9891(ref int
                    flags, int
                    toSet)
                    {
                        var return_v = ThreadSafeFlagOperations.Set(ref flags, toSet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 9825, 9891);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 9744, 9907);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 9744, 9907);
                }
            }

            public void SetIsOverriddenOrHiddenMembersPopulated()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 9923, 10105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 10009, 10090);

                    f_10707_10009_10089(ref _bits, IsOverriddenOrHiddenMembersPopulatedBit);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 9923, 10105);

                    bool
                    f_10707_10009_10089(ref int
                    flags, int
                    toSet)
                    {
                        var return_v = ThreadSafeFlagOperations.Set(ref flags, toSet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 10009, 10089);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 9923, 10105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 9923, 10105);
                }
            }

            public bool TryGetNullableContext(out byte? value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 10121, 10328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 10204, 10313);

                    return f_10707_10211_10312((NullableContextKind)((_bits >> NullableContextOffset) & NullableContextMask), out value);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 10121, 10328);

                    bool
                    f_10707_10211_10312(NullableContextKind
                    kind, out byte?
                    value)
                    {
                        var return_v = kind.TryGetByte(out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 10211, 10312);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 10121, 10328);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 10121, 10328);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool SetNullableContext(byte? value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 10344, 10570);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 10420, 10555);

                    return f_10707_10427_10554(ref _bits, (((int)f_10707_10474_10504(value) & NullableContextMask) << NullableContextOffset));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 10344, 10570);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NullableContextKind
                    f_10707_10474_10504(byte?
                    value)
                    {
                        var return_v = value.ToNullableContextFlags();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 10474, 10504);
                        return return_v;
                    }


                    bool
                    f_10707_10427_10554(ref int
                    flags, int
                    toSet)
                    {
                        var return_v = ThreadSafeFlagOperations.Set(ref flags, toSet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 10427, 10554);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 10344, 10570);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 10344, 10570);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool InitializeDoesNotReturn(bool value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 10586, 10862);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 10666, 10710);

                    int
                    bitsToSet = IsDoesNotReturnPopulatedBit
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 10728, 10769) || true) && (value)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 10728, 10769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 10739, 10769);

                        bitsToSet |= DoesNotReturnBit;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 10728, 10769);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 10789, 10847);

                    return f_10707_10796_10846(ref _bits, bitsToSet);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 10586, 10862);

                    bool
                    f_10707_10796_10846(ref int
                    flags, int
                    toSet)
                    {
                        var return_v = ThreadSafeFlagOperations.Set(ref flags, toSet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 10796, 10846);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 10586, 10862);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 10586, 10862);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void SetIsMemberNotNullPopulated()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 10878, 11036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 10952, 11021);

                    f_10707_10952_11020(ref _bits, IsMemberNotNullPopulatedBit);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 10878, 11036);

                    bool
                    f_10707_10952_11020(ref int
                    flags, int
                    toSet)
                    {
                        var return_v = ThreadSafeFlagOperations.Set(ref flags, toSet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 10952, 11020);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 10878, 11036);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 10878, 11036);
                }
            }

            public void InitializeIsInitOnly(bool isInitOnly)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 11052, 11361);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 11134, 11208);

                    int
                    bitsToSet = ((DynAbs.Tracing.TraceSender.Conditional_F1(10707, 11151, 11161) || ((isInitOnly && DynAbs.Tracing.TraceSender.Conditional_F2(10707, 11164, 11177)) || DynAbs.Tracing.TraceSender.Conditional_F3(10707, 11180, 11181))) ? IsInitOnlyBit : 0) | IsInitOnlyPopulatedBit
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 11226, 11277);

                    f_10707_11226_11276(BitsAreUnsetOrSame(_bits, bitsToSet));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 11295, 11346);

                    f_10707_11295_11345(ref _bits, bitsToSet);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 11052, 11361);

                    int
                    f_10707_11226_11276(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 11226, 11276);
                        return 0;
                    }


                    bool
                    f_10707_11295_11345(ref int
                    flags, int
                    toSet)
                    {
                        var return_v = ThreadSafeFlagOperations.Set(ref flags, toSet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 11295, 11345);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 11052, 11361);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 11052, 11361);
                }
            }

            public void SetIsUnmanagedCallersOnlyAttributePopulated()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 11377, 11567);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 11467, 11552);

                    f_10707_11467_11551(ref _bits, IsUnmanagedCallersOnlyAttributePopulatedBit);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 11377, 11567);

                    bool
                    f_10707_11467_11551(ref int
                    flags, int
                    toSet)
                    {
                        var return_v = ThreadSafeFlagOperations.Set(ref flags, toSet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 11467, 11551);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 11377, 11567);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 11377, 11567);
                }
            }

            static bool
            f_10707_7143_7202(int
            mask)
            {
                var return_v = EnumUtilities.ContainsAllValues<MethodKind>(mask);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 7143, 7202);
                return return_v;
            }


            static int
            f_10707_7130_7203(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 7130, 7203);
                return 0;
            }


            static bool
            f_10707_7235_7308(int
            mask)
            {
                var return_v = EnumUtilities.ContainsAllValues<NullableContextKind>(mask);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 7235, 7308);
                return return_v;
            }


            static int
            f_10707_7222_7309(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 7222, 7309);
                return 0;
            }

        }
        private sealed class UncommonFields
        {
            public ParameterSymbol _lazyThisParameter;

            public Tuple<CultureInfo, string> _lazyDocComment;

            public OverriddenOrHiddenMembersResult _lazyOverriddenOrHiddenMembersResult;

            public ImmutableArray<CSharpAttributeData> _lazyCustomAttributes;

            public ImmutableArray<string> _lazyConditionalAttributeSymbols;

            public ObsoleteAttributeData _lazyObsoleteAttributeData;

            public UnmanagedCallersOnlyAttributeData _lazyUnmanagedCallersOnlyAttributeData;

            public DiagnosticInfo _lazyUseSiteDiagnostic;

            public ImmutableArray<string> _lazyNotNullMembers;

            public ImmutableArray<string> _lazyNotNullMembersWhenTrue;

            public ImmutableArray<string> _lazyNotNullMembersWhenFalse;

            public MethodSymbol _lazyExplicitClassOverride;

            public UncommonFields()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10707, 11744, 12660);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 11827, 11845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 11894, 11909);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 11963, 11999);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 12199, 12225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 12281, 12319);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 12356, 12378);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 12622, 12648);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10707, 11744, 12660);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 11744, 12660);
            }


            static UncommonFields()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10707, 11744, 12660);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10707, 11744, 12660);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 11744, 12660);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10707, 11744, 12660);
        }

        private UncommonFields CreateUncommonFields()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 12672, 14871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 12742, 12776);

                var
                retVal = f_10707_12755_12775()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 12790, 12957) || true) && (f_10707_12794_12836_M(!_packedFlags.IsObsoleteAttributePopulated))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 12790, 12957);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 12870, 12942);

                    retVal._lazyObsoleteAttributeData = ObsoleteAttributeData.Uninitialized;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 12790, 12957);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 12973, 13176) || true) && (f_10707_12977_13031_M(!_packedFlags.IsUnmanagedCallersOnlyAttributePopulated))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 12973, 13176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 13065, 13161);

                    retVal._lazyUnmanagedCallersOnlyAttributeData = UnmanagedCallersOnlyAttributeData.Uninitialized;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 12973, 13176);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 13802, 13968) || true) && (_packedFlags.IsCustomAttributesPopulated)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 13802, 13968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 13880, 13953);

                    retVal._lazyCustomAttributes = ImmutableArray<CSharpAttributeData>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 13802, 13968);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 13984, 14143) || true) && (_packedFlags.IsConditionalPopulated)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 13984, 14143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 14057, 14128);

                    retVal._lazyConditionalAttributeSymbols = ImmutableArray<string>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 13984, 14143);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 14159, 14345) || true) && (_packedFlags.IsOverriddenOrHiddenMembersPopulated)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 14159, 14345);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 14246, 14330);

                    retVal._lazyOverriddenOrHiddenMembersResult = OverriddenOrHiddenMembersResult.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 14159, 14345);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 14361, 14678) || true) && (_packedFlags.IsMemberNotNullPopulated)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 14361, 14678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 14436, 14494);

                    retVal._lazyNotNullMembers = ImmutableArray<string>.Empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 14512, 14578);

                    retVal._lazyNotNullMembersWhenTrue = ImmutableArray<string>.Empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 14596, 14663);

                    retVal._lazyNotNullMembersWhenFalse = ImmutableArray<string>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 14361, 14678);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 14694, 14830) || true) && (_packedFlags.IsExplicitOverrideIsPopulated)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 14694, 14830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 14774, 14815);

                    retVal._lazyExplicitClassOverride = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 14694, 14830);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 14846, 14860);

                return retVal;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 12672, 14871);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.UncommonFields
                f_10707_12755_12775()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.UncommonFields();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 12755, 12775);
                    return return_v;
                }


                bool
                f_10707_12794_12836_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 12794, 12836);
                    return return_v;
                }


                bool
                f_10707_12977_13031_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 12977, 13031);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 12672, 14871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 12672, 14871);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private UncommonFields AccessUncommonFields()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 14883, 15102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 14953, 14982);

                var
                retVal = _uncommonFields
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 14996, 15091);

                return retVal ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.UncommonFields>(10707, 15003, 15090) ?? f_10707_15013_15090(ref _uncommonFields, f_10707_15067_15089(this)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 14883, 15102);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.UncommonFields
                f_10707_15067_15089(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.CreateUncommonFields();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 15067, 15089);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.UncommonFields
                f_10707_15013_15090(ref Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.UncommonFields
                target, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.UncommonFields
                value)
                {
                    var return_v = InterlockedOperations.Initialize(ref target, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 15013, 15090);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 14883, 15102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 14883, 15102);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private readonly MethodDefinitionHandle _handle;

        private readonly string _name;

        private readonly PENamedTypeSymbol _containingType;

        private Symbol _associatedPropertyOrEventOpt;

        private PackedFlags _packedFlags;

        private readonly ushort _flags;

        private readonly ushort _implFlags;

        private ImmutableArray<TypeParameterSymbol> _lazyTypeParameters;

        private SignatureData _lazySignature;

        private ImmutableArray<MethodSymbol> _lazyExplicitMethodImplementations;

        private UncommonFields _uncommonFields;

        internal PEMethodSymbol(
                    PEModuleSymbol moduleSymbol,
                    PENamedTypeSymbol containingType,
                    MethodDefinitionHandle methodDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10707, 16405, 17655);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 15196, 15201);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 15247, 15262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 15288, 15317);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 15395, 15401);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 15460, 15470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 15601, 15615);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 16377, 16392);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 16590, 16633);

                f_10707_16590_16632((object)moduleSymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 16647, 16692);

                f_10707_16647_16691((object)containingType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 16706, 16737);

                f_10707_16706_16736(f_10707_16719_16735_M(!methodDef.IsNil));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 16753, 16773);

                _handle = methodDef;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 16787, 16820);

                _containingType = containingType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 16836, 16868);

                MethodAttributes
                localflags = 0
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 16920, 16928);

                    int
                    rva
                    = default(int);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 16946, 16977);

                    MethodImplAttributes
                    implFlags
                    = default(MethodImplAttributes);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 16995, 17102);

                    f_10707_16995_17101(f_10707_16995_17014(moduleSymbol), methodDef, out _name, out implFlags, out localflags, out rva);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 17120, 17169);

                    f_10707_17120_17168((uint)implFlags <= ushort.MaxValue);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 17187, 17218);

                    _implFlags = (ushort)implFlags;
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10707, 17247, 17536);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 17311, 17418) || true) && ((object)_name == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 17311, 17418);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 17378, 17399);

                        _name = string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 17311, 17418);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 17438, 17521);

                    f_10707_17438_17520(this, f_10707_17466_17519(ErrorCode.ERR_BindToBogus, this));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10707, 17247, 17536);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 17552, 17602);

                f_10707_17552_17601((uint)localflags <= ushort.MaxValue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 17616, 17644);

                _flags = (ushort)localflags;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10707, 16405, 17655);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 16405, 17655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 16405, 17655);
            }
        }

        internal override bool TryGetThisParameter(out ParameterSymbol thisParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 17667, 18018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 17769, 17981);

                thisParameter = (DynAbs.Tracing.TraceSender.Conditional_F1(10707, 17785, 17793) || ((f_10707_17785_17793() && DynAbs.Tracing.TraceSender.Conditional_F2(10707, 17796, 17800)) || DynAbs.Tracing.TraceSender.Conditional_F3(10707, 17831, 17980))) ? null : DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_uncommonFields, 10707, 17831, 17866)?._lazyThisParameter ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol?>(10707, 17831, 17980) ?? f_10707_17870_17980(ref f_10707_17907_17929(this)._lazyThisParameter, f_10707_17950_17979(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 17995, 18007);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 17667, 18018);

                bool
                f_10707_17785_17793()
                {
                    var return_v = IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 17785, 17793);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.UncommonFields
                f_10707_17907_17929(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.AccessUncommonFields();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 17907, 17929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol
                f_10707_17950_17979(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                forMethod)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)forMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 17950, 17979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10707_17870_17980(ref Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                target, Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol
                value)
                {
                    var return_v = InterlockedOperations.Initialize(ref target, (Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 17870, 17980);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 17667, 18018);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 17667, 18018);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 18070, 18088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 18073, 18088);
                    return _containingType; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 18070, 18088);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 18070, 18088);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 18070, 18088);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 18148, 18166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 18151, 18166);
                    return _containingType; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 18148, 18166);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 18148, 18166);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 18148, 18166);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 18207, 18215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 18210, 18215);
                    return _name; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 18207, 18215);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 18207, 18215);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 18207, 18215);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool HasFlag(MethodAttributes flag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 18228, 18470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 18341, 18409);

                f_10707_18341_18408(flag != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10707, 18354, 18407) && ((ushort)flag & ((ushort)flag - 1)) == 0));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 18423, 18459);

                return ((ushort)flag & _flags) != 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 18228, 18470);

                int
                f_10707_18341_18408(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 18341, 18408);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 18228, 18470);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 18228, 18470);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal MethodAttributes Flags
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 18560, 18587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 18563, 18587);
                    return (MethodAttributes)_flags; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 18560, 18587);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 18560, 18587);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 18560, 18587);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 18638, 18678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 18641, 18678);
                    return f_10707_18641_18678(this, MethodAttributes.SpecialName); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 18638, 18678);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 18638, 18678);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 18638, 18678);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasRuntimeSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 18736, 18778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 18739, 18778);
                    return f_10707_18739_18778(this, MethodAttributes.RTSpecialName); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 18736, 18778);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 18736, 18778);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 18736, 18778);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override MethodImplAttributes ImplementationAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 18855, 18890);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 18858, 18890);
                    return (MethodImplAttributes)_implFlags; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 18855, 18890);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 18855, 18890);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 18855, 18890);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool RequiresSecurityObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 18949, 18994);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 18952, 18994);
                    return f_10707_18952_18994(this, MethodAttributes.RequireSecObject); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 18949, 18994);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 18949, 18994);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 18949, 18994);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override DllImportData GetDllImportData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 19163, 19306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 19166, 19306);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10707, 19166, 19203) || ((f_10707_19166_19203(this, MethodAttributes.PinvokeImpl) && DynAbs.Tracing.TraceSender.Conditional_F2(10707, 19219, 19286)) || DynAbs.Tracing.TraceSender.Conditional_F3(10707, 19302, 19306))) ? f_10707_19219_19286(f_10707_19219_19260(f_10707_19219_19253(_containingType)), _handle) : null; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 19163, 19306);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 19163, 19306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 19163, 19306);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10707_19166_19203(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
            this_param, System.Reflection.MethodAttributes
            flag)
            {
                var return_v = this_param.HasFlag(flag);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 19166, 19203);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
            f_10707_19219_19253(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
            this_param)
            {
                var return_v = this_param.ContainingPEModule;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 19219, 19253);
                return return_v;
            }


            Microsoft.CodeAnalysis.PEModule
            f_10707_19219_19260(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
            this_param)
            {
                var return_v = this_param.Module;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 19219, 19260);
                return return_v;
            }


            Microsoft.CodeAnalysis.DllImportData
            f_10707_19219_19286(Microsoft.CodeAnalysis.PEModule
            this_param, System.Reflection.Metadata.MethodDefinitionHandle
            methodDef)
            {
                var return_v = this_param.GetDllImportData(methodDef);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 19219, 19286);
                return return_v;
            }

        }

        internal override bool ReturnValueIsMarshalledExplicitly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 19376, 19421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 19379, 19421);
                    return f_10707_19379_19421(f_10707_19379_19398()); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 19376, 19421);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 19376, 19421);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 19376, 19421);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override MarshalPseudoCustomAttributeData ReturnValueMarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 19519, 19564);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 19522, 19564);
                    return f_10707_19522_19564(f_10707_19522_19541()); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 19519, 19564);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 19519, 19564);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 19519, 19564);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<byte> ReturnValueMarshallingDescriptor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 19649, 19693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 19652, 19693);
                    return f_10707_19652_19693(f_10707_19652_19671()); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 19649, 19693);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 19649, 19693);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 19649, 19693);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsAccessCheckedOnOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 19755, 19805);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 19758, 19805);
                    return f_10707_19758_19805(this, MethodAttributes.CheckAccessOnOverride); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 19755, 19805);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 19755, 19805);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 19755, 19805);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasDeclarativeSecurity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 19864, 19904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 19867, 19904);
                    return f_10707_19867_19904(this, MethodAttributes.HasSecurity); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 19864, 19904);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 19864, 19904);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 19864, 19904);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override IEnumerable<Cci.SecurityAttribute> GetSecurityInformation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 19917, 20067);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 20019, 20056);

                throw f_10707_20025_20055();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 19917, 20067);

                System.Exception
                f_10707_20025_20055()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 20025, 20055);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 19917, 20067);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 19917, 20067);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 20155, 21123);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 20191, 21108);

                    switch (f_10707_20199_20204() & MethodAttributes.MemberAccessMask)
                    {

                        case MethodAttributes.Assembly:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 20191, 21108);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 20339, 20369);

                            return Accessibility.Internal;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 20191, 21108);

                        case MethodAttributes.FamORAssem:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 20191, 21108);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 20452, 20493);

                            return Accessibility.ProtectedOrInternal;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 20191, 21108);

                        case MethodAttributes.FamANDAssem:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 20191, 21108);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 20577, 20619);

                            return Accessibility.ProtectedAndInternal;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 20191, 21108);

                        case MethodAttributes.Private:
                        case MethodAttributes.PrivateScope:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 20191, 21108);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 20756, 20785);

                            return Accessibility.Private;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 20191, 21108);

                        case MethodAttributes.Public:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 20191, 21108);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 20864, 20892);

                            return Accessibility.Public;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 20191, 21108);

                        case MethodAttributes.Family:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 20191, 21108);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 20971, 21002);

                            return Accessibility.Protected;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 20191, 21108);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 20191, 21108);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 21060, 21089);

                            return Accessibility.Private;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 20191, 21108);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 20155, 21123);

                    System.Reflection.MethodAttributes
                    f_10707_20199_20204()
                    {
                        var return_v = Flags;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 20199, 20204);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 20079, 21134);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 20079, 21134);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 21176, 21216);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 21179, 21216);
                    return f_10707_21179_21216(this, MethodAttributes.PinvokeImpl); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 21176, 21216);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 21176, 21216);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 21176, 21216);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsExternal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 21263, 21340);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 21266, 21340);
                    return f_10707_21266_21274() || (DynAbs.Tracing.TraceSender.Expression_False(10707, 21266, 21340) || (f_10707_21279_21303() & MethodImplAttributes.Runtime) != 0); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 21263, 21340);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 21263, 21340);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 21263, 21340);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsVararg
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 21383, 21458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 21386, 21458);
                    return f_10707_21386_21395().Header.CallingConvention == SignatureCallingConvention.VarArgs; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 21383, 21458);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 21383, 21458);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 21383, 21458);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsGenericMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 21508, 21520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 21511, 21520);
                    return f_10707_21511_21516() > 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 21508, 21520);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 21508, 21520);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 21508, 21520);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsAsync
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 21562, 21570);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 21565, 21570);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 21562, 21570);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 21562, 21570);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 21562, 21570);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Arity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 21633, 22306);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 21669, 21798) || true) && (f_10707_21673_21703_M(!_lazyTypeParameters.IsDefault))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 21669, 21798);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 21745, 21779);

                        return _lazyTypeParameters.Length;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 21669, 21798);
                    }

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 21862, 21881);

                        int
                        parameterCount
                        = default(int);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 21903, 21926);

                        int
                        typeParameterCount
                        = default(int);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 21948, 22086);

                        f_10707_21948_22085(f_10707_21990_22031(f_10707_21990_22024(_containingType)), _handle, out parameterCount, out typeParameterCount);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 22108, 22134);

                        return typeParameterCount;
                    }
                    catch (BadImageFormatException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(10707, 22171, 22291);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 22243, 22272);

                        return f_10707_22250_22264().Length;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(10707, 22171, 22291);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 21633, 22306);

                    bool
                    f_10707_21673_21703_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 21673, 21703);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10707_21990_22024(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 21990, 22024);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PEModule
                    f_10707_21990_22031(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 21990, 22031);
                        return return_v;
                    }


                    int
                    f_10707_21948_22085(Microsoft.CodeAnalysis.PEModule
                    module, System.Reflection.Metadata.MethodDefinitionHandle
                    methodDef, out int
                    parameterCount, out int
                    typeParameterCount)
                    {
                        MetadataDecoder.GetSignatureCountsOrThrow(module, methodDef, out parameterCount, out typeParameterCount);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 21948, 22085);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10707_22250_22264()
                    {
                        var return_v = TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 22250, 22264);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 21583, 22317);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 21583, 22317);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal MethodDefinitionHandle Handle
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 22368, 22378);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 22371, 22378);
                    return _handle; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 22368, 22378);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 22368, 22378);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 22368, 22378);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 22594, 22631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 22597, 22631);
                    return f_10707_22597_22631(this, MethodAttributes.Abstract); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 22594, 22631);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 22594, 22631);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 22594, 22631);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 23280, 23586);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 23283, 23586);
                    return f_10707_23283_23303(this) && (DynAbs.Tracing.TraceSender.Expression_True(10707, 23283, 23586) && ((DynAbs.Tracing.TraceSender.Conditional_F1(10707, 23350, 23382) || ((f_10707_23350_23382(this._containingType) && DynAbs.Tracing.TraceSender.Conditional_F2(10707, 23430, 23502)) || DynAbs.Tracing.TraceSender.Conditional_F3(10707, 23550, 23585))) ? f_10707_23430_23445(this) && (DynAbs.Tracing.TraceSender.Expression_True(10707, 23430, 23473) && f_10707_23449_23473(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10707, 23430, 23502) && !f_10707_23478_23502(this)) : f_10707_23550_23566_M(!this.IsAbstract) && (DynAbs.Tracing.TraceSender.Expression_True(10707, 23550, 23585) && f_10707_23570_23585(this)))); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 23280, 23586);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 23280, 23586);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 23280, 23586);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HidesBaseMethodsByName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 23664, 23703);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 23667, 23703);
                    return !f_10707_23668_23703(this, MethodAttributes.HideBySig); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 23664, 23703);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 23664, 23703);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 23664, 23703);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 24042, 24263);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 24045, 24263);
                    return f_10707_24045_24069(this) && (DynAbs.Tracing.TraceSender.Expression_True(10707, 24045, 24091) && f_10707_24073_24091_M(!this.IsDestructor)) && (DynAbs.Tracing.TraceSender.Expression_True(10707, 24045, 24116) && f_10707_24095_24116_M(!this.IsMetadataFinal)) && (DynAbs.Tracing.TraceSender.Expression_True(10707, 24045, 24136) && f_10707_24120_24136_M(!this.IsAbstract)) && (DynAbs.Tracing.TraceSender.Expression_True(10707, 24045, 24263) && ((DynAbs.Tracing.TraceSender.Conditional_F1(10707, 24184, 24216) || ((f_10707_24184_24216(this._containingType) && DynAbs.Tracing.TraceSender.Conditional_F2(10707, 24219, 24243)) || DynAbs.Tracing.TraceSender.Conditional_F3(10707, 24246, 24262))) ? f_10707_24219_24243(this) : f_10707_24246_24262_M(!this.IsOverride))); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 24042, 24263);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 24042, 24263);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 24042, 24263);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 25074, 25328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 25090, 25328);
                    return f_10707_25090_25123_M(!this._containingType.IsInterface) && (DynAbs.Tracing.TraceSender.Expression_True(10707, 25090, 25164) && f_10707_25140_25164(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10707, 25090, 25186) && f_10707_25168_25186_M(!this.IsDestructor)) && (DynAbs.Tracing.TraceSender.Expression_True(10707, 25090, 25328) && ((!f_10707_25206_25230(this) && (DynAbs.Tracing.TraceSender.Expression_True(10707, 25205, 25294) && (object)f_10707_25242_25286(_containingType) != null)) || (DynAbs.Tracing.TraceSender.Expression_False(10707, 25204, 25327) || f_10707_25299_25327(this)))); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 25074, 25328);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 25074, 25328);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 25074, 25328);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 25371, 25406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 25374, 25406);
                    return f_10707_25374_25406(this, MethodAttributes.Static); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 25371, 25406);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 25371, 25406);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 25371, 25406);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 25511, 25547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 25514, 25547);
                return f_10707_25514_25547(this, MethodAttributes.Virtual); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 25511, 25547);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 25511, 25547);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 25511, 25547);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10707_25514_25547(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
            this_param, System.Reflection.MethodAttributes
            flag)
            {
                var return_v = this_param.HasFlag(flag);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 25514, 25547);
                return return_v;
            }

        }

        internal override bool IsMetadataNewSlot(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 25652, 25688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 25655, 25688);
                return f_10707_25655_25688(this, MethodAttributes.NewSlot); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 25652, 25688);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 25652, 25688);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 25652, 25688);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10707_25655_25688(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
            this_param, System.Reflection.MethodAttributes
            flag)
            {
                var return_v = this_param.HasFlag(flag);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 25655, 25688);
                return return_v;
            }

        }

        internal override bool IsMetadataFinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 25740, 25774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 25743, 25774);
                    return f_10707_25743_25774(this, MethodAttributes.Final); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 25740, 25774);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 25740, 25774);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 25740, 25774);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool IsExplicitFinalizerOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 25852, 26207);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 25888, 26126) || true) && (f_10707_25892_25935_M(!_packedFlags.IsExplicitOverrideIsPopulated))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 25888, 26126);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 25977, 26028);

                        var
                        unused = f_10707_25990_26027(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 26050, 26107);

                        f_10707_26050_26106(_packedFlags.IsExplicitOverrideIsPopulated);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 25888, 26126);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 26144, 26192);

                    return _packedFlags.IsExplicitFinalizerOverride;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 25852, 26207);

                    bool
                    f_10707_25892_25935_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 25892, 25935);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    f_10707_25990_26027(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ExplicitInterfaceImplementations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 25990, 26027);
                        return return_v;
                    }


                    int
                    f_10707_26050_26106(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 26050, 26106);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 25787, 26218);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 25787, 26218);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool IsExplicitClassOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 26291, 26642);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 26327, 26565) || true) && (f_10707_26331_26374_M(!_packedFlags.IsExplicitOverrideIsPopulated))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 26327, 26565);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 26416, 26467);

                        var
                        unused = f_10707_26429_26466(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 26489, 26546);

                        f_10707_26489_26545(_packedFlags.IsExplicitOverrideIsPopulated);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 26327, 26565);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 26583, 26627);

                    return _packedFlags.IsExplicitClassOverride;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 26291, 26642);

                    bool
                    f_10707_26331_26374_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 26331, 26374);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    f_10707_26429_26466(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ExplicitInterfaceImplementations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 26429, 26466);
                        return return_v;
                    }


                    int
                    f_10707_26489_26545(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 26489, 26545);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 26230, 26653);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 26230, 26653);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool IsDestructor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 26691, 26734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 26694, 26734);
                    return f_10707_26694_26709(this) == MethodKind.Destructor; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 26691, 26734);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 26691, 26734);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 26691, 26734);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 26780, 26811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 26783, 26811);
                    return f_10707_26783_26811(f_10707_26783_26798(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 26780, 26811);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 26780, 26811);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 26780, 26811);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int ParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 26885, 27573);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 26921, 27048) || true) && (_lazySignature != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 26921, 27048);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 26989, 27029);

                        return _lazySignature.Parameters.Length;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 26921, 27048);
                    }

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 27112, 27131);

                        int
                        parameterCount
                        = default(int);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 27153, 27176);

                        int
                        typeParameterCount
                        = default(int);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 27198, 27361);

                        f_10707_27198_27360(f_10707_27240_27281(f_10707_27240_27274(_containingType)), _handle, out parameterCount, out typeParameterCount);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 27383, 27405);

                        return parameterCount;
                    }
                    catch (BadImageFormatException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(10707, 27442, 27558);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 27514, 27539);

                        return f_10707_27521_27531().Length;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(10707, 27442, 27558);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 26885, 27573);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10707_27240_27274(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 27240, 27274);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PEModule
                    f_10707_27240_27281(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 27240, 27281);
                        return return_v;
                    }


                    int
                    f_10707_27198_27360(Microsoft.CodeAnalysis.PEModule
                    module, System.Reflection.Metadata.MethodDefinitionHandle
                    methodDef, out int
                    parameterCount, out int
                    typeParameterCount)
                    {
                        MetadataDecoder.GetSignatureCountsOrThrow(module, methodDef, out parameterCount, out typeParameterCount);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 27198, 27360);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10707_27521_27531()
                    {
                        var return_v = Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 27521, 27531);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 26824, 27584);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 26824, 27584);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ParameterSymbol> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 27655, 27678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 27658, 27678);
                    return f_10707_27658_27667().Parameters; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 27655, 27678);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 27655, 27678);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 27655, 27678);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PEParameterSymbol ReturnTypeParameter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 27738, 27762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 27741, 27762);
                    return f_10707_27741_27750().ReturnParam; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 27738, 27762);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 27738, 27762);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 27738, 27762);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 27807, 27839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 27810, 27839);
                    return f_10707_27810_27839(f_10707_27810_27819().ReturnParam); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 27807, 27839);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 27807, 27839);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 27807, 27839);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeWithAnnotations ReturnTypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 27914, 27958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 27917, 27958);
                    return f_10707_27917_27958(f_10707_27917_27926().ReturnParam); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 27914, 27958);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 27914, 27958);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 27914, 27958);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override FlowAnalysisAnnotations ReturnTypeFlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 28045, 28093);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 28048, 28093);
                    return f_10707_28048_28093(f_10707_28048_28057().ReturnParam); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 28045, 28093);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 28045, 28093);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 28045, 28093);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableHashSet<string> ReturnNotNullIfParameterNotNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 28179, 28229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 28182, 28229);
                    return f_10707_28182_28229(f_10707_28182_28191().ReturnParam); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 28179, 28229);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 28179, 28229);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 28179, 28229);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override FlowAnalysisAnnotations FlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 28330, 28835);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 28366, 28695) || true) && (f_10707_28370_28408_M(!_packedFlags.IsDoesNotReturnPopulated))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 28366, 28695);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 28450, 28504);

                        var
                        moduleSymbol = f_10707_28469_28503(_containingType)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 28526, 28602);

                        bool
                        doesNotReturn = f_10707_28547_28601(f_10707_28547_28566(moduleSymbol), _handle)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 28624, 28676);

                        _packedFlags.InitializeDoesNotReturn(doesNotReturn);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 28366, 28695);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 28715, 28820);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10707, 28722, 28748) || ((_packedFlags.DoesNotReturn && DynAbs.Tracing.TraceSender.Conditional_F2(10707, 28751, 28788)) || DynAbs.Tracing.TraceSender.Conditional_F3(10707, 28791, 28819))) ? FlowAnalysisAnnotations.DoesNotReturn : FlowAnalysisAnnotations.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 28330, 28835);

                    bool
                    f_10707_28370_28408_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 28370, 28408);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10707_28469_28503(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 28469, 28503);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PEModule
                    f_10707_28547_28566(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 28547, 28566);
                        return return_v;
                    }


                    bool
                    f_10707_28547_28601(Microsoft.CodeAnalysis.PEModule
                    this_param, System.Reflection.Metadata.MethodDefinitionHandle
                    token)
                    {
                        var return_v = this_param.HasDoesNotReturnAttribute((System.Reflection.Metadata.EntityHandle)token);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 28547, 28601);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 28242, 28846);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 28242, 28846);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<string> NotNullMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 28938, 29534);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 28974, 29105) || true) && (f_10707_28978_29016_M(!_packedFlags.IsMemberNotNullPopulated))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 28974, 29105);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 29058, 29086);

                        f_10707_29058_29085(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 28974, 29105);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 29125, 29162);

                    var
                    uncommonFields = _uncommonFields
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 29180, 29519) || true) && (uncommonFields == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 29180, 29519);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 29248, 29284);

                        return ImmutableArray<string>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 29180, 29519);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 29180, 29519);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 29366, 29414);

                        var
                        result = uncommonFields._lazyNotNullMembers
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 29436, 29500);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10707, 29443, 29459) || ((result.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10707, 29462, 29490)) || DynAbs.Tracing.TraceSender.Conditional_F3(10707, 29493, 29499))) ? ImmutableArray<string>.Empty : result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 29180, 29519);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 28938, 29534);

                    bool
                    f_10707_28978_29016_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 28978, 29016);
                        return return_v;
                    }


                    int
                    f_10707_29058_29085(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        this_param.PopulateMemberNotNullData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 29058, 29085);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 28858, 29545);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 28858, 29545);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void PopulateMemberNotNullData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 29557, 30737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 29622, 29677);

                var
                module = f_10707_29635_29676(f_10707_29635_29669(_containingType))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 29691, 29759);

                var
                memberNotNull = f_10707_29711_29758(module, _handle)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 29773, 29812);

                f_10707_29773_29811(f_10707_29786_29810_M(!memberNotNull.IsDefault));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 29826, 29997) || true) && (f_10707_29830_29852_M(!memberNotNull.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 29826, 29997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 29886, 29982);

                    f_10707_29886_29981(ref f_10707_29923_29945(this)._lazyNotNullMembers, memberNotNull);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 29826, 29997);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 30013, 30119);

                var (memberNotNullWhenTrue, memberNotNullWhenFalse) = f_10707_30067_30118(module, _handle);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 30135, 30182);

                f_10707_30135_30181(f_10707_30148_30180_M(!memberNotNullWhenTrue.IsDefault));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 30196, 30391) || true) && (f_10707_30200_30230_M(!memberNotNullWhenTrue.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 30196, 30391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 30264, 30376);

                    f_10707_30264_30375(ref f_10707_30301_30323(this)._lazyNotNullMembersWhenTrue, memberNotNullWhenTrue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 30196, 30391);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 30407, 30455);

                f_10707_30407_30454(f_10707_30420_30453_M(!memberNotNullWhenFalse.IsDefault));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 30469, 30667) || true) && (f_10707_30473_30504_M(!memberNotNullWhenFalse.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 30469, 30667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 30538, 30652);

                    f_10707_30538_30651(ref f_10707_30575_30597(this)._lazyNotNullMembersWhenFalse, memberNotNullWhenFalse);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 30469, 30667);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 30683, 30726);

                _packedFlags.SetIsMemberNotNullPopulated();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 29557, 30737);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10707_29635_29669(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 29635, 29669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10707_29635_29676(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 29635, 29676);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10707_29711_29758(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                token)
                {
                    var return_v = this_param.GetMemberNotNullAttributeValues((System.Reflection.Metadata.EntityHandle)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 29711, 29758);
                    return return_v;
                }


                bool
                f_10707_29786_29810_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 29786, 29810);
                    return return_v;
                }


                int
                f_10707_29773_29811(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 29773, 29811);
                    return 0;
                }


                bool
                f_10707_29830_29852_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 29830, 29852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.UncommonFields
                f_10707_29923_29945(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.AccessUncommonFields();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 29923, 29945);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10707_29886_29981(ref System.Collections.Immutable.ImmutableArray<string>
                target, System.Collections.Immutable.ImmutableArray<string>
                initializedValue)
                {
                    var return_v = InterlockedOperations.Initialize(ref target, initializedValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 29886, 29981);
                    return return_v;
                }


                (System.Collections.Immutable.ImmutableArray<string> whenTrue, System.Collections.Immutable.ImmutableArray<string> whenFalse)
                f_10707_30067_30118(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                token)
                {
                    var return_v = this_param.GetMemberNotNullWhenAttributeValues((System.Reflection.Metadata.EntityHandle)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 30067, 30118);
                    return return_v;
                }


                bool
                f_10707_30148_30180_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 30148, 30180);
                    return return_v;
                }


                int
                f_10707_30135_30181(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 30135, 30181);
                    return 0;
                }


                bool
                f_10707_30200_30230_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 30200, 30230);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.UncommonFields
                f_10707_30301_30323(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.AccessUncommonFields();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 30301, 30323);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10707_30264_30375(ref System.Collections.Immutable.ImmutableArray<string>
                target, System.Collections.Immutable.ImmutableArray<string>
                initializedValue)
                {
                    var return_v = InterlockedOperations.Initialize(ref target, initializedValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 30264, 30375);
                    return return_v;
                }


                bool
                f_10707_30420_30453_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 30420, 30453);
                    return return_v;
                }


                int
                f_10707_30407_30454(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 30407, 30454);
                    return 0;
                }


                bool
                f_10707_30473_30504_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 30473, 30504);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.UncommonFields
                f_10707_30575_30597(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.AccessUncommonFields();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 30575, 30597);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10707_30538_30651(ref System.Collections.Immutable.ImmutableArray<string>
                target, System.Collections.Immutable.ImmutableArray<string>
                initializedValue)
                {
                    var return_v = InterlockedOperations.Initialize(ref target, initializedValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 30538, 30651);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 29557, 30737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 29557, 30737);
            }
        }

        internal override ImmutableArray<string> NotNullWhenTrueMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 30837, 31441);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 30873, 31004) || true) && (f_10707_30877_30915_M(!_packedFlags.IsMemberNotNullPopulated))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 30873, 31004);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 30957, 30985);

                        f_10707_30957_30984(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 30873, 31004);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 31024, 31061);

                    var
                    uncommonFields = _uncommonFields
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 31079, 31426) || true) && (uncommonFields is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 31079, 31426);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 31147, 31183);

                        return ImmutableArray<string>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 31079, 31426);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 31079, 31426);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 31265, 31321);

                        var
                        result = uncommonFields._lazyNotNullMembersWhenTrue
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 31343, 31407);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10707, 31350, 31366) || ((result.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10707, 31369, 31397)) || DynAbs.Tracing.TraceSender.Conditional_F3(10707, 31400, 31406))) ? ImmutableArray<string>.Empty : result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 31079, 31426);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 30837, 31441);

                    bool
                    f_10707_30877_30915_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 30877, 30915);
                        return return_v;
                    }


                    int
                    f_10707_30957_30984(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        this_param.PopulateMemberNotNullData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 30957, 30984);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 30749, 31452);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 30749, 31452);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<string> NotNullWhenFalseMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 31553, 32158);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 31589, 31720) || true) && (f_10707_31593_31631_M(!_packedFlags.IsMemberNotNullPopulated))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 31589, 31720);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 31673, 31701);

                        f_10707_31673_31700(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 31589, 31720);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 31740, 31777);

                    var
                    uncommonFields = _uncommonFields
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 31795, 32143) || true) && (uncommonFields is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 31795, 32143);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 31863, 31899);

                        return ImmutableArray<string>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 31795, 32143);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 31795, 32143);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 31981, 32038);

                        var
                        result = uncommonFields._lazyNotNullMembersWhenFalse
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 32060, 32124);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10707, 32067, 32083) || ((result.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10707, 32086, 32114)) || DynAbs.Tracing.TraceSender.Conditional_F3(10707, 32117, 32123))) ? ImmutableArray<string>.Empty : result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 31795, 32143);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 31553, 32158);

                    bool
                    f_10707_31593_31631_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 31593, 31631);
                        return return_v;
                    }


                    int
                    f_10707_31673_31700(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        this_param.PopulateMemberNotNullData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 31673, 31700);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 31464, 32169);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 31464, 32169);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 32247, 32290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 32250, 32290);
                    return f_10707_32250_32290(f_10707_32250_32259().ReturnParam); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 32247, 32290);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 32247, 32290);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 32247, 32290);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool SetAssociatedProperty(PEPropertySymbol propertySymbol, MethodKind methodKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 32501, 32806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 32617, 32712);

                f_10707_32617_32711((methodKind == MethodKind.PropertyGet) || (DynAbs.Tracing.TraceSender.Expression_False(10707, 32630, 32710) || (methodKind == MethodKind.PropertySet)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 32726, 32795);

                return f_10707_32733_32794(this, propertySymbol, methodKind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 32501, 32806);

                int
                f_10707_32617_32711(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 32617, 32711);
                    return 0;
                }


                bool
                f_10707_32733_32794(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                propertyOrEventSymbol, Microsoft.CodeAnalysis.MethodKind
                methodKind)
                {
                    var return_v = this_param.SetAssociatedPropertyOrEvent((Microsoft.CodeAnalysis.CSharp.Symbol)propertyOrEventSymbol, methodKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 32733, 32794);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 32501, 32806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 32501, 32806);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool SetAssociatedEvent(PEEventSymbol eventSymbol, MethodKind methodKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 33013, 33303);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 33120, 33212);

                f_10707_33120_33211((methodKind == MethodKind.EventAdd) || (DynAbs.Tracing.TraceSender.Expression_False(10707, 33133, 33210) || (methodKind == MethodKind.EventRemove)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 33226, 33292);

                return f_10707_33233_33291(this, eventSymbol, methodKind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 33013, 33303);

                int
                f_10707_33120_33211(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 33120, 33211);
                    return 0;
                }


                bool
                f_10707_33233_33291(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEEventSymbol
                propertyOrEventSymbol, Microsoft.CodeAnalysis.MethodKind
                methodKind)
                {
                    var return_v = this_param.SetAssociatedPropertyOrEvent((Microsoft.CodeAnalysis.CSharp.Symbol)propertyOrEventSymbol, methodKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 33233, 33291);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 33013, 33303);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 33013, 33303);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool SetAssociatedPropertyOrEvent(Symbol propertyOrEventSymbol, MethodKind methodKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 33315, 34499);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 33434, 34459) || true) && ((object)_associatedPropertyOrEventOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 33434, 34459);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 33517, 33641);

                    f_10707_33517_33640(f_10707_33530_33639(f_10707_33548_33584(propertyOrEventSymbol), _containingType, TypeCompareKind.ConsiderEverything2));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 33971, 34025);

                    _associatedPropertyOrEventOpt = propertyOrEventSymbol;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 34109, 34357);

                    f_10707_34109_34356(_packedFlags.MethodKind == default(MethodKind) || (DynAbs.Tracing.TraceSender.Expression_False(10707, 34144, 34261) || _packedFlags.MethodKind == MethodKind.Ordinary) || (DynAbs.Tracing.TraceSender.Expression_False(10707, 34144, 34355) || _packedFlags.MethodKind == MethodKind.ExplicitInterfaceImplementation));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 34377, 34414);

                    _packedFlags.MethodKind = methodKind;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 34432, 34444);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 33434, 34459);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 34475, 34488);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 33315, 34499);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10707_33548_33584(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 33548, 33584);
                    return return_v;
                }


                bool
                f_10707_33530_33639(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 33530, 33639);
                    return return_v;
                }


                int
                f_10707_33517_33640(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 33517, 33640);
                    return 0;
                }


                int
                f_10707_34109_34356(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 34109, 34356);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 33315, 34499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 33315, 34499);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SignatureData Signature
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 34633, 34669);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 34636, 34669);
                    return _lazySignature ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.SignatureData>(10707, 34636, 34669) ?? f_10707_34654_34669(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 34633, 34669);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 34633, 34669);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 34633, 34669);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private SignatureData LoadSignature()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 34682, 37113);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 34744, 34798);

                var
                moduleSymbol = f_10707_34763_34797(_containingType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 34814, 34846);

                SignatureHeader
                signatureHeader
                = default(SignatureHeader);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 34860, 34889);

                BadImageFormatException
                mrEx
                = default(BadImageFormatException);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 34903, 35041);

                ParamInfo<TypeSymbol>[]
                paramInfo = f_10707_34939_35040(f_10707_34939_34978(moduleSymbol, this), _handle, out signatureHeader, out mrEx)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 35055, 35085);

                bool
                makeBad = (mrEx != null)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 35187, 35448) || true) && (f_10707_35191_35217_M(!signatureHeader.IsGeneric) && (DynAbs.Tracing.TraceSender.Expression_True(10707, 35191, 35267) && _lazyTypeParameters.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 35187, 35448);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 35301, 35433);

                    f_10707_35301_35432(ref _lazyTypeParameters, ImmutableArray<TypeParameterSymbol>.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 35187, 35448);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 35464, 35497);

                int
                count = f_10707_35476_35492(paramInfo) - 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 35511, 35551);

                ImmutableArray<ParameterSymbol>
                @params
                = default(ImmutableArray<ParameterSymbol>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 35565, 35585);

                bool
                isBadParameter
                = default(bool);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 35601, 36351) || true) && (count > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 35601, 36351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 35648, 35715);

                    var
                    builder = f_10707_35662_35714(count)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 35742, 35747);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 35733, 36170) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 35760, 35763)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 35733, 36170))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 35733, 36170);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 35805, 36021);

                            f_10707_35805_36020(builder, f_10707_35817_36019(moduleSymbol, this, f_10707_35888_35912(this), i, paramInfo[i + 1], nullableContext: this, isReturn: false, out isBadParameter));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 36045, 36151) || true) && (isBadParameter)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 36045, 36151);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 36113, 36128);

                                makeBad = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 36045, 36151);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10707, 1, 438);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10707, 1, 438);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 36190, 36222);

                    @params = f_10707_36200_36221(builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 35601, 36351);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 35601, 36351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 36288, 36336);

                    @params = ImmutableArray<ParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 35601, 36351);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 36417, 36486);

                var
                returnType = f_10707_36434_36485(paramInfo[0].Type, _containingType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 36502, 36533);

                paramInfo[0].Type = returnType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 36549, 36749);

                var
                returnParam = f_10707_36567_36748(moduleSymbol, this, f_10707_36630_36654(this), 0, paramInfo[0], nullableContext: this, isReturn: true, out isBadParameter)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 36765, 36926) || true) && (makeBad || (DynAbs.Tracing.TraceSender.Expression_False(10707, 36769, 36794) || isBadParameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 36765, 36926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 36828, 36911);

                    f_10707_36828_36910(this, f_10707_36856_36909(ErrorCode.ERR_BindToBogus, this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 36765, 36926);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 36942, 37015);

                var
                signature = f_10707_36958_37014(signatureHeader, @params, returnParam)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 37031, 37102);

                return f_10707_37038_37101(ref _lazySignature, signature);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 34682, 37113);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10707_34763_34797(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 34763, 34797);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                f_10707_34939_34978(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                context)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder(moduleSymbol, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 34939, 34978);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
                f_10707_34939_35040(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                methodDef, out System.Reflection.Metadata.SignatureHeader
                signatureHeader, out System.BadImageFormatException
                metadataException)
                {
                    var return_v = this_param.GetSignatureForMethod(methodDef, out signatureHeader, out metadataException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 34939, 35040);
                    return return_v;
                }


                bool
                f_10707_35191_35217_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 35191, 35217);
                    return return_v;
                }


                bool
                f_10707_35301_35432(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 35301, 35432);
                    return return_v;
                }


                int
                f_10707_35476_35492(Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 35476, 35492);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>.Builder
                f_10707_35662_35714(int
                initialCapacity)
                {
                    var return_v = ImmutableArray.CreateBuilder<ParameterSymbol>(initialCapacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 35662, 35714);
                    return return_v;
                }


                bool
                f_10707_35888_35912(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsMetadataVirtual();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 35888, 35912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
                f_10707_35817_36019(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                containingSymbol, bool
                isContainingSymbolVirtual, int
                ordinal, Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                parameterInfo, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                nullableContext, bool
                isReturn, out bool
                isBad)
                {
                    var return_v = PEParameterSymbol.Create(moduleSymbol, containingSymbol, isContainingSymbolVirtual, ordinal, parameterInfo, nullableContext: (Microsoft.CodeAnalysis.CSharp.Symbol)nullableContext, isReturn: isReturn, out isBad);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 35817, 36019);
                    return return_v;
                }


                int
                f_10707_35805_36020(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>.Builder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 35805, 36020);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10707_36200_36221(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 36200, 36221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10707_36434_36485(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                containingType)
                {
                    var return_v = type.AsDynamicIfNoPia((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)containingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 36434, 36485);
                    return return_v;
                }


                bool
                f_10707_36630_36654(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsMetadataVirtual();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 36630, 36654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
                f_10707_36567_36748(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                containingSymbol, bool
                isContainingSymbolVirtual, int
                ordinal, Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                parameterInfo, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                nullableContext, bool
                isReturn, out bool
                isBad)
                {
                    var return_v = PEParameterSymbol.Create(moduleSymbol, containingSymbol, isContainingSymbolVirtual, ordinal, parameterInfo, nullableContext: (Microsoft.CodeAnalysis.CSharp.Symbol)nullableContext, isReturn: isReturn, out isBad);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 36567, 36748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10707_36856_36909(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 36856, 36909);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10707_36828_36910(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                diagnostic)
                {
                    var return_v = this_param.InitializeUseSiteDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 36828, 36910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.SignatureData
                f_10707_36958_37014(System.Reflection.Metadata.SignatureHeader
                header, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
                returnParam)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.SignatureData(header, parameters, returnParam);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 36958, 37014);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.SignatureData
                f_10707_37038_37101(ref Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.SignatureData
                target, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.SignatureData
                value)
                {
                    var return_v = InterlockedOperations.Initialize(ref target, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 37038, 37101);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 34682, 37113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 34682, 37113);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 37216, 37576);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 37252, 37289);

                    DiagnosticInfo
                    diagnosticInfo = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 37307, 37374);

                    var
                    typeParams = f_10707_37324_37373(this, ref diagnosticInfo)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 37392, 37523) || true) && (diagnosticInfo != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 37392, 37523);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 37460, 37504);

                        f_10707_37460_37503(this, diagnosticInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 37392, 37523);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 37543, 37561);

                    return typeParams;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 37216, 37576);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10707_37324_37373(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo?
                    diagnosticInfo)
                    {
                        var return_v = this_param.EnsureTypeParametersAreLoaded(ref diagnosticInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 37324, 37373);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticInfo
                    f_10707_37460_37503(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param, Microsoft.CodeAnalysis.DiagnosticInfo
                    diagnostic)
                    {
                        var return_v = this_param.InitializeUseSiteDiagnostic(diagnostic);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 37460, 37503);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 37125, 37587);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 37125, 37587);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ImmutableArray<TypeParameterSymbol> EnsureTypeParametersAreLoaded(ref DiagnosticInfo diagnosticInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 37599, 38007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 37732, 37769);

                var
                typeParams = _lazyTypeParameters
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 37783, 37875) || true) && (f_10707_37787_37808_M(!typeParams.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 37783, 37875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 37842, 37860);

                    return typeParams;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 37783, 37875);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 37891, 37996);

                return f_10707_37898_37995(ref _lazyTypeParameters, f_10707_37956_37994(this, ref diagnosticInfo));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 37599, 38007);

                bool
                f_10707_37787_37808_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 37787, 37808);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10707_37956_37994(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                diagnosticInfo)
                {
                    var return_v = this_param.LoadTypeParameters(ref diagnosticInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 37956, 37994);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10707_37898_37995(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                target, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                initializedValue)
                {
                    var return_v = InterlockedOperations.Initialize(ref target, initializedValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 37898, 37995);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 37599, 38007);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 37599, 38007);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<TypeParameterSymbol> LoadTypeParameters(ref DiagnosticInfo diagnosticInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 38019, 39189);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 38177, 38231);

                    var
                    moduleSymbol = f_10707_38196_38230(_containingType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 38249, 38331);

                    var
                    gpHandles = f_10707_38265_38330(f_10707_38265_38284(moduleSymbol), _handle)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 38351, 38932) || true) && (gpHandles.Count == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 38351, 38932);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 38417, 38466);

                        return ImmutableArray<TypeParameterSymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 38351, 38932);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 38351, 38932);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 38548, 38633);

                        var
                        ownedParams = f_10707_38566_38632(gpHandles.Count)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 38664, 38669);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 38655, 38856) || true) && (i < gpHandles.Count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 38692, 38695)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 38655, 38856))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 38655, 38856);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 38745, 38833);

                                f_10707_38745_38832(ownedParams, f_10707_38761_38831(moduleSymbol, this, (ushort)i, gpHandles[i]));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10707, 1, 202);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10707, 1, 202);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 38880, 38913);

                        return f_10707_38887_38912(ownedParams);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 38351, 38932);
                    }
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10707, 38961, 39178);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 39025, 39096);

                    diagnosticInfo = f_10707_39042_39095(ErrorCode.ERR_BindToBogus, this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 39114, 39163);

                    return ImmutableArray<TypeParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10707, 38961, 39178);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 38019, 39189);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10707_38196_38230(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 38196, 38230);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10707_38265_38284(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 38265, 38284);
                    return return_v;
                }


                System.Reflection.Metadata.GenericParameterHandleCollection
                f_10707_38265_38330(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                methodDef)
                {
                    var return_v = this_param.GetGenericParametersForMethodOrThrow(methodDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 38265, 38330);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>.Builder
                f_10707_38566_38632(int
                initialCapacity)
                {
                    var return_v = ImmutableArray.CreateBuilder<TypeParameterSymbol>(initialCapacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 38566, 38632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                f_10707_38761_38831(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                definingMethod, int
                ordinal, System.Reflection.Metadata.GenericParameterHandle
                handle)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol(moduleSymbol, definingMethod, (ushort)ordinal, handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 38761, 38831);
                    return return_v;
                }


                int
                f_10707_38745_38832(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>.Builder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 38745, 38832);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10707_38887_38912(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 38887, 38912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10707_39042_39095(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 39042, 39095);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 38019, 39189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 38019, 39189);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 39282, 39381);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 39285, 39381);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10707, 39285, 39300) || ((f_10707_39285_39300() && DynAbs.Tracing.TraceSender.Conditional_F2(10707, 39303, 39337)) || DynAbs.Tracing.TraceSender.Conditional_F3(10707, 39340, 39381))) ? f_10707_39303_39337(this) : ImmutableArray<TypeWithAnnotations>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 39282, 39381);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 39282, 39381);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 39282, 39381);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 39434, 39466);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 39437, 39466);
                    return _associatedPropertyOrEventOpt; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 39434, 39466);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 39434, 39466);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 39434, 39466);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 39542, 40491);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 39779, 40420) || true) && (f_10707_39783_39825_M(!_packedFlags.IsExtensionMethodIsPopulated))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 39779, 40420);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 39867, 39898);

                        bool
                        isExtensionMethod = false
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 39920, 40319) || true) && (f_10707_39924_39939(this) == MethodKind.Ordinary && (DynAbs.Tracing.TraceSender.Expression_True(10707, 39924, 39999) && f_10707_39966_39999(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10707, 39924, 40076) && f_10707_40028_40076(f_10707_40028_40047(this))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 39920, 40319);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 40126, 40180);

                            var
                            moduleSymbol = f_10707_40145_40179(_containingType)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 40206, 40296);

                            isExtensionMethod = f_10707_40226_40295(f_10707_40226_40245(moduleSymbol), _handle, ignoreCase: false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 39920, 40319);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 40341, 40401);

                        _packedFlags.InitializeIsExtensionMethod(isExtensionMethod);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 39779, 40420);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 40438, 40476);

                    return _packedFlags.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 39542, 40491);

                    bool
                    f_10707_39783_39825_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 39783, 39825);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MethodKind
                    f_10707_39924_39939(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 39924, 39939);
                        return return_v;
                    }


                    bool
                    f_10707_39966_39999(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsValidExtensionMethodSignature();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 39966, 39999);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10707_40028_40047(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 40028, 40047);
                        return return_v;
                    }


                    bool
                    f_10707_40028_40076(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.MightContainExtensionMethods;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 40028, 40076);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10707_40145_40179(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 40145, 40179);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PEModule
                    f_10707_40226_40245(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 40226, 40245);
                        return return_v;
                    }


                    bool
                    f_10707_40226_40295(Microsoft.CodeAnalysis.PEModule
                    this_param, System.Reflection.Metadata.MethodDefinitionHandle
                    token, bool
                    ignoreCase)
                    {
                        var return_v = this_param.HasExtensionAttribute((System.Reflection.Metadata.EntityHandle)token, ignoreCase: ignoreCase);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 40226, 40295);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 39479, 40502);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 39479, 40502);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 40565, 40654);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 40568, 40654);
                    return f_10707_40568_40602(_containingType).MetadataLocation.Cast<MetadataLocation, Location>(); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 40565, 40654);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 40565, 40654);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 40565, 40654);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 40741, 40781);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 40744, 40781);
                    return ImmutableArray<SyntaxReference>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 40741, 40781);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 40741, 40781);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 40741, 40781);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 40794, 43871);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 40886, 43268) || true) && (f_10707_40890_40931_M(!_packedFlags.IsCustomAttributesPopulated))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 40886, 43268);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 41003, 41068);

                    var
                    attributeData = default(ImmutableArray<CSharpAttributeData>)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 41086, 41152);

                    var
                    containingPEModuleSymbol = f_10707_41117_41151(_containingType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 41236, 41307);

                    bool
                    isExtensionAlreadySet = _packedFlags.IsExtensionMethodIsPopulated
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 41325, 41623);

                    bool
                    checkForExtension = (DynAbs.Tracing.TraceSender.Conditional_F1(10707, 41350, 41371) || ((isExtensionAlreadySet
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10707, 41395, 41425)) || DynAbs.Tracing.TraceSender.Conditional_F3(10707, 41449, 41622))) ? _packedFlags.IsExtensionMethod
                    : f_10707_41449_41464(this) == MethodKind.Ordinary
                    && (DynAbs.Tracing.TraceSender.Expression_True(10707, 41449, 41549) && f_10707_41516_41549(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10707, 41449, 41622) && f_10707_41578_41622(_containingType))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 41643, 41704);

                    bool
                    isReadOnlyAlreadySet = _packedFlags.IsReadOnlyPopulated
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 41722, 41863);

                    bool
                    checkForIsReadOnly = (DynAbs.Tracing.TraceSender.Conditional_F1(10707, 41748, 41768) || ((isReadOnlyAlreadySet
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10707, 41793, 41816)) || DynAbs.Tracing.TraceSender.Conditional_F3(10707, 41841, 41862))) ? _packedFlags.IsReadOnly
                    : f_10707_41841_41862()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 41883, 41914);

                    bool
                    isExtensionMethod = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 41932, 41956);

                    bool
                    isReadOnly = false
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 41974, 42471) || true) && (checkForExtension || (DynAbs.Tracing.TraceSender.Expression_False(10707, 41978, 42017) || checkForIsReadOnly))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 41974, 42471);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 42059, 42271);

                        f_10707_42059_42270(containingPEModuleSymbol, _handle, ref attributeData, out isExtensionMethod, out isReadOnly);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 41974, 42471);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 41974, 42471);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 42353, 42452);

                        f_10707_42353_42451(containingPEModuleSymbol, _handle, ref attributeData);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 41974, 42471);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 42491, 42638) || true) && (!isExtensionAlreadySet)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 42491, 42638);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 42559, 42619);

                        _packedFlags.InitializeIsExtensionMethod(isExtensionMethod);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 42491, 42638);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 42658, 42790) || true) && (!isReadOnlyAlreadySet)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 42658, 42790);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 42725, 42771);

                        _packedFlags.InitializeIsReadOnly(isReadOnly);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 42658, 42790);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 42890, 42929);

                    f_10707_42890_42928(f_10707_42903_42927_M(!attributeData.IsDefault));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 42947, 43148) || true) && (f_10707_42951_42973_M(!attributeData.IsEmpty))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 42947, 43148);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 43015, 43129);

                        attributeData = f_10707_43031_43128(ref f_10707_43068_43090(this)._lazyCustomAttributes, attributeData);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 42947, 43148);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 43168, 43214);

                    _packedFlags.SetIsCustomAttributesPopulated();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 43232, 43253);

                    return attributeData;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 40886, 43268);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 43335, 43372);

                var
                uncommonFields = _uncommonFields
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 43386, 43860) || true) && (uncommonFields == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 43386, 43860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 43446, 43495);

                    return ImmutableArray<CSharpAttributeData>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 43386, 43860);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 43386, 43860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 43561, 43618);

                    var
                    attributeData = uncommonFields._lazyCustomAttributes
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 43636, 43845);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10707, 43643, 43666) || ((attributeData.IsDefault
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10707, 43690, 43807)) || DynAbs.Tracing.TraceSender.Conditional_F3(10707, 43831, 43844))) ? f_10707_43690_43807(ref uncommonFields._lazyCustomAttributes, ImmutableArray<CSharpAttributeData>.Empty) : attributeData;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 43386, 43860);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 40794, 43871);

                bool
                f_10707_40890_40931_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 40890, 40931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10707_41117_41151(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 41117, 41151);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10707_41449_41464(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 41449, 41464);
                    return return_v;
                }


                bool
                f_10707_41516_41549(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsValidExtensionMethodSignature();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 41516, 41549);
                    return return_v;
                }


                bool
                f_10707_41578_41622(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.MightContainExtensionMethods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 41578, 41622);
                    return return_v;
                }


                bool
                f_10707_41841_41862()
                {
                    var return_v = IsValidReadOnlyTarget;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 41841, 41862);
                    return return_v;
                }


                int
                f_10707_42059_42270(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                token, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                customAttributes, out bool
                foundExtension, out bool
                foundReadOnly)
                {
                    this_param.LoadCustomAttributesFilterCompilerAttributes((System.Reflection.Metadata.EntityHandle)token, ref customAttributes, out foundExtension, out foundReadOnly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 42059, 42270);
                    return 0;
                }


                int
                f_10707_42353_42451(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                token, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                customAttributes)
                {
                    this_param.LoadCustomAttributes((System.Reflection.Metadata.EntityHandle)token, ref customAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 42353, 42451);
                    return 0;
                }


                bool
                f_10707_42903_42927_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 42903, 42927);
                    return return_v;
                }


                int
                f_10707_42890_42928(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 42890, 42928);
                    return 0;
                }


                bool
                f_10707_42951_42973_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 42951, 42973);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.UncommonFields
                f_10707_43068_43090(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.AccessUncommonFields();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 43068, 43090);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10707_43031_43128(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                target, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                initializedValue)
                {
                    var return_v = InterlockedOperations.Initialize(ref target, initializedValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 43031, 43128);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10707_43690_43807(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                target, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                initializedValue)
                {
                    var return_v = InterlockedOperations.Initialize(ref target, initializedValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 43690, 43807);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 40794, 43871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 40794, 43871);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<CSharpAttributeData> GetCustomAttributesToEmit(PEModuleBuilder moduleBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 43991, 44009);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 43994, 44009);
                return f_10707_43994_44009(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 43991, 44009);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 43991, 44009);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 43991, 44009);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
            f_10707_43994_44009(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
            this_param)
            {
                var return_v = this_param.GetAttributes();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 43994, 44009);
                return return_v;
            }

        }

        public override ImmutableArray<CSharpAttributeData> GetReturnTypeAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 44100, 44140);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 44103, 44140);
                return f_10707_44103_44140(f_10707_44103_44112().ReturnParam); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 44100, 44140);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 44100, 44140);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 44100, 44140);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.SignatureData
            f_10707_44103_44112()
            {
                var return_v = Signature;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 44103, 44112);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
            f_10707_44103_44140(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
            this_param)
            {
                var return_v = this_param.GetAttributes();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 44103, 44140);
                return return_v;
            }

        }

        internal override byte? GetNullableContextValue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 44153, 44640);
                byte arg = default(byte);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 44227, 44239);

                byte?
                value
                = default(byte?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 44253, 44602) || true) && (!_packedFlags.TryGetNullableContext(out value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 44253, 44602);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 44337, 44530);

                    value = (DynAbs.Tracing.TraceSender.Conditional_F1(10707, 44345, 44437) || ((f_10707_44345_44437(f_10707_44345_44386(f_10707_44345_44379(_containingType)), _handle, out arg) && DynAbs.Tracing.TraceSender.Conditional_F2(10707, 44461, 44464)) || DynAbs.Tracing.TraceSender.Conditional_F3(10707, 44488, 44529))) ? arg : f_10707_44488_44529(_containingType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 44548, 44587);

                    _packedFlags.SetNullableContext(value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 44253, 44602);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 44616, 44629);

                return value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 44153, 44640);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10707_44345_44379(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 44345, 44379);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10707_44345_44386(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 44345, 44386);
                    return return_v;
                }


                bool
                f_10707_44345_44437(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                token, out byte
                value)
                {
                    var return_v = this_param.HasNullableContextAttribute((System.Reflection.Metadata.EntityHandle)token, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 44345, 44437);
                    return return_v;
                }


                byte?
                f_10707_44488_44529(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetNullableContextValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 44488, 44529);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 44153, 44640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 44153, 44640);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override byte? GetLocalNullableContextValue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 44652, 44779);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 44731, 44768);

                throw f_10707_44737_44767();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 44652, 44779);

                System.Exception
                f_10707_44737_44767()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 44737, 44767);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 44652, 44779);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 44652, 44779);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override MethodKind MethodKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 44853, 45113);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 44889, 45049) || true) && (f_10707_44893_44928_M(!_packedFlags.MethodKindIsPopulated))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 44889, 45049);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 44970, 45030);

                        _packedFlags.InitializeMethodKind(f_10707_45004_45028(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 44889, 45049);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 45067, 45098);

                    return _packedFlags.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 44853, 45113);

                    bool
                    f_10707_44893_44928_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 44893, 44928);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MethodKind
                    f_10707_45004_45028(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ComputeMethodKind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 45004, 45028);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 44791, 45124);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 44791, 45124);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool IsValidExtensionMethodSignature()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 45136, 45780);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 45207, 45287) || true) && (f_10707_45211_45225_M(!this.IsStatic))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 45207, 45287);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 45259, 45272);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 45207, 45287);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 45303, 45336);

                var
                parameters = f_10707_45320_45335(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 45350, 45438) || true) && (parameters.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 45350, 45438);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 45410, 45423);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 45350, 45438);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 45454, 45484);

                var
                parameter = parameters[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 45498, 45769);

                switch (f_10707_45506_45523(parameter))
                {

                    case RefKind.None:
                    case RefKind.Ref:
                    case RefKind.In:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 45498, 45769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 45666, 45693);

                        return f_10707_45673_45692_M(!parameter.IsParams);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 45498, 45769);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 45498, 45769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 45741, 45754);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 45498, 45769);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 45136, 45780);

                bool
                f_10707_45211_45225_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 45211, 45225);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10707_45320_45335(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 45320, 45335);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10707_45506_45523(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 45506, 45523);
                    return return_v;
                }


                bool
                f_10707_45673_45692_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 45673, 45692);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 45136, 45780);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 45136, 45780);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsValidUserDefinedOperatorSignature(int parameterCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 45792, 46712);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 45885, 46068) || true) && (f_10707_45889_45905(this) || (DynAbs.Tracing.TraceSender.Expression_False(10707, 45889, 45929) || f_10707_45909_45929(this)) || (DynAbs.Tracing.TraceSender.Expression_False(10707, 45889, 45946) || f_10707_45933_45946(this)) || (DynAbs.Tracing.TraceSender.Expression_False(10707, 45889, 45987) || f_10707_45950_45969(this) != parameterCount) || (DynAbs.Tracing.TraceSender.Expression_False(10707, 45889, 46006) || f_10707_45991_46006(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 45885, 46068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 46040, 46053);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 45885, 46068);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 46084, 46181) || true) && (this.ParameterRefKinds.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 46084, 46181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 46154, 46166);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 46084, 46181);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 46197, 46673);
                    foreach (var kind in f_10707_46218_46240_I(f_10707_46218_46240(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 46197, 46673);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 46274, 46658);

                        switch (kind)
                        {

                            case RefKind.None:
                            case RefKind.In:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 46274, 46658);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 46410, 46419);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 46274, 46658);

                            case RefKind.Out:
                            case RefKind.Ref:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 46274, 46658);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 46523, 46536);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 46274, 46658);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 46274, 46658);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 46592, 46639);

                                throw f_10707_46598_46638(kind);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 46274, 46658);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 46197, 46673);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10707, 1, 477);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10707, 1, 477);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 46689, 46701);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 45792, 46712);

                bool
                f_10707_45889_45905(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnsVoid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 45889, 45905);
                    return return_v;
                }


                bool
                f_10707_45909_45929(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 45909, 45929);
                    return return_v;
                }


                bool
                f_10707_45933_45946(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsVararg;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 45933, 45946);
                    return return_v;
                }


                int
                f_10707_45950_45969(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 45950, 45969);
                    return return_v;
                }


                bool
                f_10707_45991_46006(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                method)
                {
                    var return_v = method.IsParams();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 45991, 46006);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10707_46218_46240(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterRefKinds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 46218, 46240);
                    return return_v;
                }


                System.Exception
                f_10707_46598_46638(Microsoft.CodeAnalysis.RefKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 46598, 46638);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10707_46218_46240_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 46218, 46240);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 45792, 46712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 45792, 46712);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MethodKind ComputeMethodKind()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 46724, 53094);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 46787, 51591) || true) && (f_10707_46791_46810(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 46787, 51591);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 46844, 48500) || true) && (f_10707_46848_46895(_name, ".", StringComparison.Ordinal))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 46844, 48500);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 47633, 48430) || true) && ((f_10707_47638_47643() & (MethodAttributes.RTSpecialName | MethodAttributes.Virtual)) == MethodAttributes.RTSpecialName && (DynAbs.Tracing.TraceSender.Expression_True(10707, 47637, 47888) && f_10707_47769_47888(_name, (DynAbs.Tracing.TraceSender.Conditional_F1(10707, 47782, 47795) || ((f_10707_47782_47795(this) && DynAbs.Tracing.TraceSender.Conditional_F2(10707, 47798, 47840)) || DynAbs.Tracing.TraceSender.Conditional_F3(10707, 47843, 47887))) ? WellKnownMemberNames.StaticConstructorName : WellKnownMemberNames.InstanceConstructorName)) && (DynAbs.Tracing.TraceSender.Expression_True(10707, 47637, 47933) && f_10707_47917_47933(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10707, 47637, 47952) && f_10707_47937_47947(this) == 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 47633, 48430);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 48002, 48407) || true) && (f_10707_48006_48019(this))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 48002, 48407);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 48077, 48236) || true) && (f_10707_48081_48091().Length == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 48077, 48236);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 48169, 48205);

                                    return MethodKind.StaticConstructor;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 48077, 48236);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 48002, 48407);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 48002, 48407);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 48350, 48380);

                                return MethodKind.Constructor;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 48002, 48407);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 47633, 48430);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 48454, 48481);

                        return MethodKind.Ordinary;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 46844, 48500);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 48520, 51576) || true) && (f_10707_48524_48551_M(!this.HasRuntimeSpecialName) && (DynAbs.Tracing.TraceSender.Expression_True(10707, 48524, 48568) && f_10707_48555_48568(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10707, 48524, 48622) && f_10707_48572_48598(this) == Accessibility.Public))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 48520, 51576);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 48664, 51506);

                        switch (_name)
                        {

                            case WellKnownMemberNames.AdditionOperatorName:
                            case WellKnownMemberNames.BitwiseAndOperatorName:
                            case WellKnownMemberNames.BitwiseOrOperatorName:
                            case WellKnownMemberNames.DivisionOperatorName:
                            case WellKnownMemberNames.EqualityOperatorName:
                            case WellKnownMemberNames.ExclusiveOrOperatorName:
                            case WellKnownMemberNames.GreaterThanOperatorName:
                            case WellKnownMemberNames.GreaterThanOrEqualOperatorName:
                            case WellKnownMemberNames.InequalityOperatorName:
                            case WellKnownMemberNames.LeftShiftOperatorName:
                            case WellKnownMemberNames.LessThanOperatorName:
                            case WellKnownMemberNames.LessThanOrEqualOperatorName:
                            case WellKnownMemberNames.ModulusOperatorName:
                            case WellKnownMemberNames.MultiplyOperatorName:
                            case WellKnownMemberNames.RightShiftOperatorName:
                            case WellKnownMemberNames.SubtractionOperatorName:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 48664, 51506);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 49932, 50033);

                                return (DynAbs.Tracing.TraceSender.Conditional_F1(10707, 49939, 49977) || ((f_10707_49939_49977(this, 2) && DynAbs.Tracing.TraceSender.Conditional_F2(10707, 49980, 50010)) || DynAbs.Tracing.TraceSender.Conditional_F3(10707, 50013, 50032))) ? MethodKind.UserDefinedOperator : MethodKind.Ordinary;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 48664, 51506);

                            case WellKnownMemberNames.DecrementOperatorName:
                            case WellKnownMemberNames.FalseOperatorName:
                            case WellKnownMemberNames.IncrementOperatorName:
                            case WellKnownMemberNames.LogicalNotOperatorName:
                            case WellKnownMemberNames.OnesComplementOperatorName:
                            case WellKnownMemberNames.TrueOperatorName:
                            case WellKnownMemberNames.UnaryNegationOperatorName:
                            case WellKnownMemberNames.UnaryPlusOperatorName:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 48664, 51506);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 50656, 50757);

                                return (DynAbs.Tracing.TraceSender.Conditional_F1(10707, 50663, 50701) || ((f_10707_50663_50701(this, 1) && DynAbs.Tracing.TraceSender.Conditional_F2(10707, 50704, 50734)) || DynAbs.Tracing.TraceSender.Conditional_F3(10707, 50737, 50756))) ? MethodKind.UserDefinedOperator : MethodKind.Ordinary;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 48664, 51506);

                            case WellKnownMemberNames.ImplicitConversionName:
                            case WellKnownMemberNames.ExplicitConversionName:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 48664, 51506);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 50937, 51029);

                                return (DynAbs.Tracing.TraceSender.Conditional_F1(10707, 50944, 50982) || ((f_10707_50944_50982(this, 1) && DynAbs.Tracing.TraceSender.Conditional_F2(10707, 50985, 51006)) || DynAbs.Tracing.TraceSender.Conditional_F3(10707, 51009, 51028))) ? MethodKind.Conversion : MethodKind.Ordinary;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 48664, 51506);

                                //case WellKnownMemberNames.ConcatenateOperatorName:
                                //case WellKnownMemberNames.ExponentOperatorName:
                                //case WellKnownMemberNames.IntegerDivisionOperatorName:
                                //case WellKnownMemberNames.LikeOperatorName:
                                //// Non-C#-supported overloaded operator
                                //return MethodKind.Ordinary;
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 51530, 51557);

                        return MethodKind.Ordinary;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 48520, 51576);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 46787, 51591);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 51607, 53040) || true) && (f_10707_51611_51625_M(!this.IsStatic))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 51607, 53040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 51659, 53025);

                    switch (_name)
                    {

                        case WellKnownMemberNames.DestructorName:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 51659, 53025);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 51781, 52071) || true) && ((f_10707_51786_51814(f_10707_51786_51805(this)) == TypeKind.Class && (DynAbs.Tracing.TraceSender.Expression_True(10707, 51786, 51891) && f_10707_51836_51891(this, skipFirstMethodKindCheck: true))) || (DynAbs.Tracing.TraceSender.Expression_False(10707, 51785, 51957) || f_10707_51925_51957(this)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 51781, 52071);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 52015, 52044);

                                return MethodKind.Destructor;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 51781, 52071);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10707, 52097, 52103);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 51659, 53025);

                        case WellKnownMemberNames.DelegateInvokeName:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 51659, 53025);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 52196, 52363) || true) && (f_10707_52200_52224(_containingType) == TypeKind.Delegate)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 52196, 52363);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 52303, 52336);

                                return MethodKind.DelegateInvoke;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 52196, 52363);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10707, 52389, 52395);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 51659, 53025);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 51659, 53025);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 52744, 52974) || true) && (!f_10707_52749_52789(f_10707_52779_52788(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10707, 52748, 52839) && f_10707_52793_52839_M(!this.ExplicitInterfaceImplementations.IsEmpty)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 52744, 52974);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 52897, 52947);

                                return MethodKind.ExplicitInterfaceImplementation;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 52744, 52974);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10707, 53000, 53006);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 51659, 53025);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 51607, 53040);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 53056, 53083);

                return MethodKind.Ordinary;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 46724, 53094);

                bool
                f_10707_46791_46810(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.HasSpecialName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 46791, 46810);
                    return return_v;
                }


                bool
                f_10707_46848_46895(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 46848, 46895);
                    return return_v;
                }


                System.Reflection.MethodAttributes
                f_10707_47638_47643()
                {
                    var return_v = Flags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 47638, 47643);
                    return return_v;
                }


                bool
                f_10707_47782_47795(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 47782, 47795);
                    return return_v;
                }


                bool
                f_10707_47769_47888(string
                this_param, string
                value)
                {
                    var return_v = this_param.Equals(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 47769, 47888);
                    return return_v;
                }


                bool
                f_10707_47917_47933(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnsVoid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 47917, 47933);
                    return return_v;
                }


                int
                f_10707_47937_47947(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 47937, 47947);
                    return return_v;
                }


                bool
                f_10707_48006_48019(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 48006, 48019);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10707_48081_48091()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 48081, 48091);
                    return return_v;
                }


                bool
                f_10707_48524_48551_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 48524, 48551);
                    return return_v;
                }


                bool
                f_10707_48555_48568(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 48555, 48568);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10707_48572_48598(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 48572, 48598);
                    return return_v;
                }


                bool
                f_10707_49939_49977(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param, int
                parameterCount)
                {
                    var return_v = this_param.IsValidUserDefinedOperatorSignature(parameterCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 49939, 49977);
                    return return_v;
                }


                bool
                f_10707_50663_50701(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param, int
                parameterCount)
                {
                    var return_v = this_param.IsValidUserDefinedOperatorSignature(parameterCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 50663, 50701);
                    return return_v;
                }


                bool
                f_10707_50944_50982(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param, int
                parameterCount)
                {
                    var return_v = this_param.IsValidUserDefinedOperatorSignature(parameterCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 50944, 50982);
                    return return_v;
                }


                bool
                f_10707_51611_51625_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 51611, 51625);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10707_51786_51805(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 51786, 51805);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10707_51786_51814(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 51786, 51814);
                    return return_v;
                }


                bool
                f_10707_51836_51891(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                method, bool
                skipFirstMethodKindCheck)
                {
                    var return_v = method.IsRuntimeFinalizer(skipFirstMethodKindCheck: skipFirstMethodKindCheck);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 51836, 51891);
                    return return_v;
                }


                bool
                f_10707_51925_51957(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitFinalizerOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 51925, 51957);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10707_52200_52224(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 52200, 52224);
                    return return_v;
                }


                string
                f_10707_52779_52788(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 52779, 52788);
                    return return_v;
                }


                bool
                f_10707_52749_52789(string
                name)
                {
                    var return_v = SyntaxFacts.IsValidIdentifier(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 52749, 52789);
                    return return_v;
                }


                bool
                f_10707_52793_52839_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 52793, 52839);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 46724, 53094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 46724, 53094);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Cci.CallingConvention CallingConvention
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 53164, 53215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 53167, 53215);
                    return (Cci.CallingConvention)f_10707_53190_53199().Header.RawValue; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 53164, 53215);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 53164, 53215);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 53164, 53215);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 53330, 57515);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 53366, 53440);

                    var
                    explicitInterfaceImplementations = _lazyExplicitMethodImplementations
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 53458, 53606) || true) && (f_10707_53462_53505_M(!explicitInterfaceImplementations.IsDefault))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 53458, 53606);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 53547, 53587);

                        return explicitInterfaceImplementations;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 53458, 53606);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 53626, 53680);

                    var
                    moduleSymbol = f_10707_53645_53679(_containingType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 54130, 54300);

                    var
                    explicitlyOverriddenMethods = f_10707_54164_54299(f_10707_54164_54214(moduleSymbol, _containingType), f_10707_54246_54268(_containingType), _handle, f_10707_54279_54298(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 54385, 54409);

                    var
                    anyToRemove = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 54427, 54457);

                    var
                    sawObjectFinalize = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 54475, 55180);
                        foreach (var method in f_10707_54498_54525_I(explicitlyOverriddenMethods))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 54475, 55180);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 54567, 55022) || true) && (f_10707_54571_54605_M(!f_10707_54572_54593(method).IsInterface))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 54567, 55022);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 54655, 54674);

                                anyToRemove = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 54700, 54999);

                                sawObjectFinalize =
                                                           (f_10707_54749_54782(f_10707_54749_54770(method)) == SpecialType.System_Object && (DynAbs.Tracing.TraceSender.Expression_True(10707, 54749, 54894) && f_10707_54844_54855(method) == WellKnownMemberNames.DestructorName) && (DynAbs.Tracing.TraceSender.Expression_True(10707, 54749, 54997) && f_10707_54955_54972(method) == MethodKind.Destructor));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 54567, 55022);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 55046, 55161) || true) && (anyToRemove && (DynAbs.Tracing.TraceSender.Expression_True(10707, 55050, 55082) && sawObjectFinalize))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 55046, 55161);
                                DynAbs.Tracing.TraceSender.TraceBreak(10707, 55132, 55138);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 55046, 55161);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 54475, 55180);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10707, 1, 706);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10707, 1, 706);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 55200, 55263);

                    explicitInterfaceImplementations = explicitlyOverriddenMethods;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 55283, 56766) || true) && (anyToRemove)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 55283, 56766);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 55340, 55427);

                        var
                        explicitInterfaceImplementationsBuilder = f_10707_55386_55426()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 55449, 55746);
                            foreach (var method in f_10707_55472_55499_I(explicitlyOverriddenMethods))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 55449, 55746);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 55549, 55723) || true) && (f_10707_55553_55586(f_10707_55553_55574(method)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 55549, 55723);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 55644, 55696);

                                    f_10707_55644_55695(explicitInterfaceImplementationsBuilder, method);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 55549, 55723);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 55449, 55746);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10707, 1, 298);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10707, 1, 298);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 55770, 55866);

                        explicitInterfaceImplementations = f_10707_55805_55865(explicitInterfaceImplementationsBuilder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 55890, 55930);

                        MethodSymbol
                        uniqueClassOverride = null
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 55952, 56510);
                            foreach (MethodSymbol method in f_10707_55984_56011_I(explicitlyOverriddenMethods))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 55952, 56510);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 56061, 56487) || true) && (f_10707_56065_56100(f_10707_56065_56086(method)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 56061, 56487);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 56158, 56399) || true) && (uniqueClassOverride is { })
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 56158, 56399);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 56301, 56328);

                                        uniqueClassOverride = null;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10707, 56362, 56368);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 56158, 56399);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 56431, 56460);

                                    uniqueClassOverride = method;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 56061, 56487);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 55952, 56510);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10707, 1, 559);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10707, 1, 559);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 56534, 56747) || true) && (uniqueClassOverride is { })
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 56534, 56747);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 56614, 56724);

                            f_10707_56614_56723(ref f_10707_56646_56668(this)._lazyExplicitClassOverride, uniqueClassOverride, null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 56534, 56747);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 55283, 56766);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 57238, 57366);

                    _packedFlags.InitializeIsExplicitOverride(isExplicitFinalizerOverride: sawObjectFinalize, isExplicitClassOverride: anyToRemove);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 57386, 57500);

                    return f_10707_57393_57499(ref _lazyExplicitMethodImplementations, explicitInterfaceImplementations);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 53330, 57515);

                    bool
                    f_10707_53462_53505_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 53462, 53505);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10707_53645_53679(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 53645, 53679);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                    f_10707_54164_54214(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    context)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder(moduleSymbol, context);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 54164, 54214);
                        return return_v;
                    }


                    System.Reflection.Metadata.TypeDefinitionHandle
                    f_10707_54246_54268(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Handle;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 54246, 54268);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10707_54279_54298(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 54279, 54298);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    f_10707_54164_54299(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                    this_param, System.Reflection.Metadata.TypeDefinitionHandle
                    implementingTypeDef, System.Reflection.Metadata.MethodDefinitionHandle
                    implementingMethodDef, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    implementingTypeSymbol)
                    {
                        var return_v = this_param.GetExplicitlyOverriddenMethods(implementingTypeDef, implementingMethodDef, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)implementingTypeSymbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 54164, 54299);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10707_54572_54593(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 54572, 54593);
                        return return_v;
                    }


                    bool
                    f_10707_54571_54605_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 54571, 54605);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10707_54749_54770(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 54749, 54770);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SpecialType
                    f_10707_54749_54782(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 54749, 54782);
                        return return_v;
                    }


                    string
                    f_10707_54844_54855(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 54844, 54855);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MethodKind
                    f_10707_54955_54972(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 54955, 54972);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    f_10707_54498_54525_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 54498, 54525);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    f_10707_55386_55426()
                    {
                        var return_v = ArrayBuilder<MethodSymbol>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 55386, 55426);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10707_55553_55574(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 55553, 55574);
                        return return_v;
                    }


                    bool
                    f_10707_55553_55586(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsInterface;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 55553, 55586);
                        return return_v;
                    }


                    int
                    f_10707_55644_55695(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 55644, 55695);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    f_10707_55472_55499_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 55472, 55499);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    f_10707_55805_55865(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 55805, 55865);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10707_56065_56086(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 56065, 56086);
                        return return_v;
                    }


                    bool
                    f_10707_56065_56100(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = type.IsClassType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 56065, 56100);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    f_10707_55984_56011_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 55984, 56011);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.UncommonFields
                    f_10707_56646_56668(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.AccessUncommonFields();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 56646, 56668);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10707_56614_56723(ref Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 56614, 56723);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    f_10707_57393_57499(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    target, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    initializedValue)
                    {
                        var return_v = InterlockedOperations.Initialize(ref target, initializedValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 57393, 57499);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 53228, 57526);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 53228, 57526);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal MethodSymbol ExplicitlyOverriddenClassMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 57766, 57907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 57802, 57892);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10707, 57809, 57832) || ((f_10707_57809_57832() && DynAbs.Tracing.TraceSender.Conditional_F2(10707, 57835, 57884)) || DynAbs.Tracing.TraceSender.Conditional_F3(10707, 57887, 57891))) ? f_10707_57835_57857(this)._lazyExplicitClassOverride : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 57766, 57907);

                    bool
                    f_10707_57809_57832()
                    {
                        var return_v = IsExplicitClassOverride;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 57809, 57832);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.UncommonFields
                    f_10707_57835_57857(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.AccessUncommonFields();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 57835, 57857);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 57688, 57918);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 57688, 57918);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 57996, 58551);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 58032, 58487) || true) && (f_10707_58036_58069_M(!_packedFlags.IsReadOnlyPopulated))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 58032, 58487);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 58111, 58135);

                        bool
                        isReadOnly = false
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 58157, 58400) || true) && (f_10707_58161_58182())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 58157, 58400);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 58232, 58286);

                            var
                            moduleSymbol = f_10707_58251_58285(_containingType)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 58312, 58377);

                            isReadOnly = f_10707_58325_58376(f_10707_58325_58344(moduleSymbol), _handle);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 58157, 58400);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 58422, 58468);

                        _packedFlags.InitializeIsReadOnly(isReadOnly);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 58032, 58487);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 58505, 58536);

                    return _packedFlags.IsReadOnly;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 57996, 58551);

                    bool
                    f_10707_58036_58069_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 58036, 58069);
                        return return_v;
                    }


                    bool
                    f_10707_58161_58182()
                    {
                        var return_v = IsValidReadOnlyTarget;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 58161, 58182);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10707_58251_58285(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 58251, 58285);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PEModule
                    f_10707_58325_58344(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 58325, 58344);
                        return return_v;
                    }


                    bool
                    f_10707_58325_58376(Microsoft.CodeAnalysis.PEModule
                    this_param, System.Reflection.Metadata.MethodDefinitionHandle
                    token)
                    {
                        var return_v = this_param.HasIsReadOnlyAttribute((System.Reflection.Metadata.EntityHandle)token);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 58325, 58376);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 57930, 58562);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 57930, 58562);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 58632, 59099);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 58668, 59035) || true) && (f_10707_58672_58705_M(!_packedFlags.IsInitOnlyPopulated))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 58668, 59035);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 58747, 58948);

                        bool
                        isInitOnly = f_10707_58765_58779_M(!this.IsStatic) && (DynAbs.Tracing.TraceSender.Expression_True(10707, 58765, 58849) && f_10707_58808_58823(this) == MethodKind.PropertySet) && (DynAbs.Tracing.TraceSender.Expression_True(10707, 58765, 58947) && f_10707_58878_58903().CustomModifiers.HasIsExternalInitModifier())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 58970, 59016);

                        _packedFlags.InitializeIsInitOnly(isInitOnly);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 58668, 59035);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 59053, 59084);

                    return _packedFlags.IsInitOnly;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 58632, 59099);

                    bool
                    f_10707_58672_58705_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 58672, 58705);
                        return return_v;
                    }


                    bool
                    f_10707_58765_58779_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 58765, 58779);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MethodKind
                    f_10707_58808_58823(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 58808, 58823);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10707_58878_58903()
                    {
                        var return_v = ReturnTypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 58878, 58903);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 58574, 59110);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 58574, 59110);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 59122, 59521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 59328, 59510);

                return f_10707_59335_59509(this, f_10707_59393_59427(_containingType), preferredCulture, cancellationToken, ref f_10707_59470_59492(this)._lazyDocComment);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 59122, 59521);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10707_59393_59427(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 59393, 59427);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.UncommonFields
                f_10707_59470_59492(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.AccessUncommonFields();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 59470, 59492);
                    return return_v;
                }


                string
                f_10707_59335_59509(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                containingPEModule, System.Globalization.CultureInfo?
                preferredCulture, System.Threading.CancellationToken
                cancellationToken, ref System.Tuple<System.Globalization.CultureInfo, string>
                lazyDocComment)
                {
                    var return_v = PEDocumentationCommentUtils.GetDocumentationComment((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, containingPEModule, preferredCulture, cancellationToken, ref lazyDocComment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 59335, 59509);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 59122, 59521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 59122, 59521);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override DiagnosticInfo GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 59533, 60642);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 59613, 60568) || true) && (f_10707_59617_59659_M(!_packedFlags.IsUseSiteDiagnosticPopulated))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 59613, 60568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 59693, 59722);

                    DiagnosticInfo
                    result = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 59740, 59779);

                    f_10707_59740_59778(this, ref result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 59797, 59839);

                    f_10707_59797_59838(this, ref result);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 59857, 60490) || true) && (result == null && (DynAbs.Tracing.TraceSender.Expression_True(10707, 59861, 59978) && f_10707_59879_59936(this, forceComplete: true) is UnmanagedCallersOnlyAttributeData data))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 59857, 60490);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 60020, 60106);

                        f_10707_60020_60105(!f_10707_60034_60104(data, UnmanagedCallersOnlyAttributeData.Uninitialized));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 60128, 60229);

                        f_10707_60128_60228(!f_10707_60142_60227(data, UnmanagedCallersOnlyAttributeData.AttributePresentDataNotBound));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 60251, 60471) || true) && (f_10707_60255_60335(this, location: null, diagnostics: null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 60251, 60471);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 60385, 60448);

                            result = f_10707_60394_60447(ErrorCode.ERR_BindToBogus, this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 60251, 60471);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 59857, 60490);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 60510, 60553);

                    return f_10707_60517_60552(this, result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 59613, 60568);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 60584, 60631);

                return DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_uncommonFields, 10707, 60591, 60630)?._lazyUseSiteDiagnostic;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 59533, 60642);

                bool
                f_10707_59617_59659_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 59617, 59659);
                    return return_v;
                }


                bool
                f_10707_59740_59778(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo?
                result)
                {
                    var return_v = this_param.CalculateUseSiteDiagnostic(ref result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 59740, 59778);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10707_59797_59838(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                diagnosticInfo)
                {
                    var return_v = this_param.EnsureTypeParametersAreLoaded(ref diagnosticInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 59797, 59838);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData?
                f_10707_59879_59936(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param, bool
                forceComplete)
                {
                    var return_v = this_param.GetUnmanagedCallersOnlyAttributeData(forceComplete: forceComplete);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 59879, 59936);
                    return return_v;
                }


                bool
                f_10707_60034_60104(Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData
                objA, Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 60034, 60104);
                    return return_v;
                }


                int
                f_10707_60020_60105(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 60020, 60105);
                    return 0;
                }


                bool
                f_10707_60142_60227(Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData
                objA, Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 60142, 60227);
                    return return_v;
                }


                int
                f_10707_60128_60228(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 60128, 60228);
                    return 0;
                }


                bool
                f_10707_60255_60335(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param, Microsoft.CodeAnalysis.Location?
                location, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnostics)
                {
                    var return_v = this_param.CheckAndReportValidUnmanagedCallersOnlyTarget(location: location, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 60255, 60335);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10707_60394_60447(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 60394, 60447);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10707_60517_60552(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo?
                diagnostic)
                {
                    var return_v = this_param.InitializeUseSiteDiagnostic(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 60517, 60552);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 59533, 60642);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 59533, 60642);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DiagnosticInfo InitializeUseSiteDiagnostic(DiagnosticInfo diagnostic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 60654, 61269);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 60756, 60897) || true) && (_packedFlags.IsUseSiteDiagnosticPopulated)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 60756, 60897);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 60835, 60882);

                    return DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_uncommonFields, 10707, 60842, 60881)?._lazyUseSiteDiagnostic;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 60756, 60897);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 60913, 61163) || true) && (diagnostic != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 60913, 61163);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 60969, 61021);

                    f_10707_60969_61020(!f_10707_60983_61019(diagnostic));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 61039, 61148);

                    diagnostic = f_10707_61052_61147(ref f_10707_61089_61111(this)._lazyUseSiteDiagnostic, diagnostic);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 60913, 61163);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 61179, 61226);

                _packedFlags.SetIsUseSiteDiagnosticPopulated();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 61240, 61258);

                return diagnostic;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 60654, 61269);

                bool
                f_10707_60983_61019(Microsoft.CodeAnalysis.DiagnosticInfo
                info)
                {
                    var return_v = CSDiagnosticInfo.IsEmpty(info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 60983, 61019);
                    return return_v;
                }


                int
                f_10707_60969_61020(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 60969, 61020);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.UncommonFields
                f_10707_61089_61111(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.AccessUncommonFields();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 61089, 61111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10707_61052_61147(ref Microsoft.CodeAnalysis.DiagnosticInfo
                target, Microsoft.CodeAnalysis.DiagnosticInfo
                value)
                {
                    var return_v = InterlockedOperations.Initialize(ref target, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 61052, 61147);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 60654, 61269);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 60654, 61269);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<string> GetAppliedConditionalSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 61281, 62448);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 61377, 61921) || true) && (f_10707_61381_61417_M(!_packedFlags.IsConditionalPopulated))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 61377, 61921);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 61451, 61545);

                    var
                    result = f_10707_61464_61544(f_10707_61464_61505(f_10707_61464_61498(_containingType)), _handle)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 61563, 61595);

                    f_10707_61563_61594(f_10707_61576_61593_M(!result.IsDefault));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 61613, 61804) || true) && (f_10707_61617_61632_M(!result.IsEmpty))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 61613, 61804);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 61674, 61785);

                        result = f_10707_61683_61784(ref f_10707_61720_61742(this)._lazyConditionalAttributeSymbols, result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 61613, 61804);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 61824, 61874);

                    _packedFlags.SetIsConditionalAttributePopulated();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 61892, 61906);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 61377, 61921);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 61937, 61974);

                var
                uncommonFields = _uncommonFields
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 61988, 62437) || true) && (uncommonFields == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 61988, 62437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 62048, 62084);

                    return ImmutableArray<string>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 61988, 62437);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 61988, 62437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 62150, 62211);

                    var
                    result = uncommonFields._lazyConditionalAttributeSymbols
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 62229, 62422);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10707, 62236, 62252) || ((result.IsDefault
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10707, 62276, 62391)) || DynAbs.Tracing.TraceSender.Conditional_F3(10707, 62415, 62421))) ? f_10707_62276_62391(ref uncommonFields._lazyConditionalAttributeSymbols, ImmutableArray<string>.Empty) : result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 61988, 62437);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 61281, 62448);

                bool
                f_10707_61381_61417_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 61381, 61417);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10707_61464_61498(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 61464, 61498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10707_61464_61505(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 61464, 61505);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10707_61464_61544(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                token)
                {
                    var return_v = this_param.GetConditionalAttributeValues((System.Reflection.Metadata.EntityHandle)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 61464, 61544);
                    return return_v;
                }


                bool
                f_10707_61576_61593_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 61576, 61593);
                    return return_v;
                }


                int
                f_10707_61563_61594(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 61563, 61594);
                    return 0;
                }


                bool
                f_10707_61617_61632_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 61617, 61632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.UncommonFields
                f_10707_61720_61742(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.AccessUncommonFields();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 61720, 61742);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10707_61683_61784(ref System.Collections.Immutable.ImmutableArray<string>
                target, System.Collections.Immutable.ImmutableArray<string>
                initializedValue)
                {
                    var return_v = InterlockedOperations.Initialize(ref target, initializedValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 61683, 61784);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10707_62276_62391(ref System.Collections.Immutable.ImmutableArray<string>
                target, System.Collections.Immutable.ImmutableArray<string>
                initializedValue)
                {
                    var return_v = InterlockedOperations.Initialize(ref target, initializedValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 62276, 62391);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 61281, 62448);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 61281, 62448);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override int CalculateLocalSyntaxOffset(int localPosition, SyntaxTree localTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 62460, 62622);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 62574, 62611);

                throw f_10707_62580_62610();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 62460, 62622);

                System.Exception
                f_10707_62580_62610()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 62580, 62610);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 62460, 62622);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 62460, 62622);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 62720, 63964);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 62756, 63364) || true) && (f_10707_62760_62802_M(!_packedFlags.IsObsoleteAttributePopulated))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 62756, 63364);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 62844, 62983);

                        var
                        result = f_10707_62857_62982(_handle, f_10707_62935_62951(), ignoreByRefLikeMarker: false)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 63005, 63238) || true) && (result != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 63005, 63238);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 63073, 63215);

                            result = f_10707_63082_63214(ref f_10707_63119_63141(this)._lazyObsoleteAttributeData, result, ObsoleteAttributeData.Uninitialized);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 63005, 63238);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 63262, 63309);

                        _packedFlags.SetIsObsoleteAttributePopulated();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 63331, 63345);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 62756, 63364);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 63384, 63421);

                    var
                    uncommonFields = _uncommonFields
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 63439, 63949) || true) && (uncommonFields == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 63439, 63949);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 63507, 63519);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 63439, 63949);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 63439, 63949);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 63601, 63656);

                        var
                        result = uncommonFields._lazyObsoleteAttributeData
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 63678, 63930);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10707, 63685, 63745) || ((f_10707_63685_63745(result, ObsoleteAttributeData.Uninitialized) && DynAbs.Tracing.TraceSender.Conditional_F2(10707, 63773, 63895)) || DynAbs.Tracing.TraceSender.Conditional_F3(10707, 63923, 63929))) ? f_10707_63773_63895(ref uncommonFields._lazyObsoleteAttributeData, null, ObsoleteAttributeData.Uninitialized) : result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 63439, 63949);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 62720, 63964);

                    bool
                    f_10707_62760_62802_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 62760, 62802);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    f_10707_62935_62951()
                    {
                        var return_v = ContainingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 62935, 62951);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ObsoleteAttributeData
                    f_10707_62857_62982(System.Reflection.Metadata.MethodDefinitionHandle
                    token, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    containingModule, bool
                    ignoreByRefLikeMarker)
                    {
                        var return_v = ObsoleteAttributeHelpers.GetObsoleteDataFromMetadata((System.Reflection.Metadata.EntityHandle)token, (Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol)containingModule, ignoreByRefLikeMarker: ignoreByRefLikeMarker);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 62857, 62982);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.UncommonFields
                    f_10707_63119_63141(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.AccessUncommonFields();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 63119, 63141);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ObsoleteAttributeData
                    f_10707_63082_63214(ref Microsoft.CodeAnalysis.ObsoleteAttributeData
                    target, Microsoft.CodeAnalysis.ObsoleteAttributeData
                    initializedValue, Microsoft.CodeAnalysis.ObsoleteAttributeData
                    uninitializedValue)
                    {
                        var return_v = InterlockedOperations.Initialize(ref target, initializedValue, uninitializedValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 63082, 63214);
                        return return_v;
                    }


                    bool
                    f_10707_63685_63745(Microsoft.CodeAnalysis.ObsoleteAttributeData
                    objA, Microsoft.CodeAnalysis.ObsoleteAttributeData
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 63685, 63745);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ObsoleteAttributeData
                    f_10707_63773_63895(ref Microsoft.CodeAnalysis.ObsoleteAttributeData
                    target, Microsoft.CodeAnalysis.ObsoleteAttributeData
                    initializedValue, Microsoft.CodeAnalysis.ObsoleteAttributeData
                    uninitializedValue)
                    {
                        var return_v = InterlockedOperations.Initialize(ref target, initializedValue, uninitializedValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 63773, 63895);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 62634, 63975);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 62634, 63975);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override UnmanagedCallersOnlyAttributeData? GetUnmanagedCallersOnlyAttributeData(bool forceComplete)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 64005, 65429);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 64139, 65339) || true) && (f_10707_64143_64197_M(!_packedFlags.IsUnmanagedCallersOnlyAttributePopulated))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 64139, 65339);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 64231, 64287);

                    var
                    containingModule = (PEModuleSymbol)f_10707_64270_64286()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 64305, 64613);

                    var
                    unmanagedCallersOnlyData = f_10707_64336_64612(f_10707_64336_64359(containingModule), _handle, f_10707_64405_64442(containingModule), static (name, value, isField) => MethodSymbol.TryDecodeUnmanagedCallersOnlyCallConvsField(name, value, isField, location: null, diagnostics: null))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 64633, 64879);

                    f_10707_64633_64878(!f_10707_64647_64737(unmanagedCallersOnlyData, UnmanagedCallersOnlyAttributeData.Uninitialized) && (DynAbs.Tracing.TraceSender.Expression_True(10707, 64646, 64877) && !f_10707_64772_64877(unmanagedCallersOnlyData, UnmanagedCallersOnlyAttributeData.AttributePresentDataNotBound)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 64899, 65213);

                    var
                    result = f_10707_64912_65212(ref f_10707_64949_64971(this)._lazyUnmanagedCallersOnlyAttributeData, unmanagedCallersOnlyData, UnmanagedCallersOnlyAttributeData.Uninitialized)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 65233, 65292);

                    _packedFlags.SetIsUnmanagedCallersOnlyAttributePopulated();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 65310, 65324);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 64139, 65339);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 65355, 65418);

                return DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_uncommonFields, 10707, 65362, 65417)?._lazyUnmanagedCallersOnlyAttributeData;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 64005, 65429);

                bool
                f_10707_64143_64197_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 64143, 64197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10707_64270_64286()
                {
                    var return_v = ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 64270, 64286);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10707_64336_64359(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 64336, 64359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                f_10707_64405_64442(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder(moduleSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 64405, 64442);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData?
                f_10707_64336_64612(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                token, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                attributeArgumentDecoder, System.Func<string, Microsoft.CodeAnalysis.TypedConstant, bool, (bool IsCallConvs, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal>? CallConvs)>
                unmanagedCallersOnlyDecoder)
                {
                    var return_v = this_param.TryGetUnmanagedCallersOnlyAttribute((System.Reflection.Metadata.EntityHandle)token, (Microsoft.CodeAnalysis.IAttributeNamedArgumentDecoder)attributeArgumentDecoder, unmanagedCallersOnlyDecoder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 64336, 64612);
                    return return_v;
                }


                bool
                f_10707_64647_64737(Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData?
                objA, Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 64647, 64737);
                    return return_v;
                }


                bool
                f_10707_64772_64877(Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData?
                objA, Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 64772, 64877);
                    return return_v;
                }


                int
                f_10707_64633_64878(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 64633, 64878);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.UncommonFields
                f_10707_64949_64971(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.AccessUncommonFields();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 64949, 64971);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData?
                f_10707_64912_65212(ref Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData
                target, Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData?
                initializedValue, Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData
                uninitializedValue)
                {
                    var return_v = InterlockedOperations.Initialize(ref target, initializedValue, uninitializedValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 64912, 65212);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 64005, 65429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 64005, 65429);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool GenerateDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 65501, 65509);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 65504, 65509);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 65501, 65509);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 65501, 65509);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 65501, 65509);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override OverriddenOrHiddenMembersResult OverriddenOrHiddenMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 65622, 66677);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 65658, 66244) || true) && (f_10707_65662_65712_M(!_packedFlags.IsOverriddenOrHiddenMembersPopulated))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 65658, 66244);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 65754, 65798);

                        var
                        result = DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.OverriddenOrHiddenMembers, 10707, 65767, 65797)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 65820, 65849);

                        f_10707_65820_65848(result != null);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 65871, 66110) || true) && (result != OverriddenOrHiddenMembersResult.Empty)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 65871, 66110);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 65972, 66087);

                            result = f_10707_65981_66086(ref f_10707_66018_66040(this)._lazyOverriddenOrHiddenMembersResult, result);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 65871, 66110);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 66134, 66189);

                        _packedFlags.SetIsOverriddenOrHiddenMembersPopulated();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 66211, 66225);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 65658, 66244);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 66264, 66301);

                    var
                    uncommonFields = _uncommonFields
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 66319, 66451) || true) && (uncommonFields == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10707, 66319, 66451);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 66387, 66432);

                        return OverriddenOrHiddenMembersResult.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10707, 66319, 66451);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 66471, 66662);

                    return uncommonFields._lazyOverriddenOrHiddenMembersResult ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult>(10707, 66478, 66661) ?? f_10707_66533_66661(ref uncommonFields._lazyOverriddenOrHiddenMembersResult, OverriddenOrHiddenMembersResult.Empty));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 65622, 66677);

                    bool
                    f_10707_65662_65712_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 65662, 65712);
                        return return_v;
                    }


                    int
                    f_10707_65820_65848(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 65820, 65848);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.UncommonFields
                    f_10707_66018_66040(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.AccessUncommonFields();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 66018, 66040);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                    f_10707_65981_66086(ref Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                    target, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                    value)
                    {
                        var return_v = InterlockedOperations.Initialize(ref target, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 65981, 66086);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                    f_10707_66533_66661(ref Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult?
                    target, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                    value)
                    {
                        var return_v = InterlockedOperations.Initialize(ref target, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 66533, 66661);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 65522, 66688);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 65522, 66688);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 66700, 66906);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 66858, 66895);

                throw f_10707_66864_66894();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 66700, 66906);

                System.Exception
                f_10707_66864_66894()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 66864, 66894);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 66700, 66906);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 66700, 66906);
            }
        }

        internal override void AddSynthesizedReturnTypeAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 66918, 67134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 67086, 67123);

                throw f_10707_67092_67122();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 66918, 67134);

                System.Exception
                f_10707_67092_67122()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 67092, 67122);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 66918, 67134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 66918, 67134);
            }
        }

        public override bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 67207, 67252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 67213, 67250);

                    throw f_10707_67219_67249();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 67207, 67252);

                    System.Exception
                    f_10707_67219_67249()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 67219, 67249);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 67146, 67263);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 67146, 67263);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override CSharpCompilation DeclaringCompilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 67366, 67373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 67369, 67373);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 67366, 67373);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 67366, 67373);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 67366, 67373);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool TestIsExtensionBitSet
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 67457, 67501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 67460, 67501);
                    return _packedFlags.IsExtensionMethodIsPopulated; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 67457, 67501);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 67457, 67501);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 67457, 67501);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool TestIsExtensionBitTrue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 67586, 67619);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 67589, 67619);
                    return _packedFlags.IsExtensionMethod; DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 67586, 67619);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 67586, 67619);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 67586, 67619);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsNullableAnalysisEnabled()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10707, 67690, 67729);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10707, 67693, 67729);
                throw f_10707_67699_67729(); DynAbs.Tracing.TraceSender.TraceExitMethod(10707, 67690, 67729);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10707, 67690, 67729);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 67690, 67729);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10707_67699_67729()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 67699, 67729);
                return return_v;
            }

        }

        static PEMethodSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10707, 811, 67737);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10707, 811, 67737);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10707, 811, 67737);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10707, 811, 67737);

        int
        f_10707_16590_16632(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 16590, 16632);
            return 0;
        }


        int
        f_10707_16647_16691(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 16647, 16691);
            return 0;
        }


        bool
        f_10707_16719_16735_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 16719, 16735);
            return return_v;
        }


        int
        f_10707_16706_16736(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 16706, 16736);
            return 0;
        }


        Microsoft.CodeAnalysis.PEModule
        f_10707_16995_17014(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        this_param)
        {
            var return_v = this_param.Module;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 16995, 17014);
            return return_v;
        }


        int
        f_10707_16995_17101(Microsoft.CodeAnalysis.PEModule
        this_param, System.Reflection.Metadata.MethodDefinitionHandle
        methodDef, out string
        name, out System.Reflection.MethodImplAttributes
        implFlags, out System.Reflection.MethodAttributes
        flags, out int
        rva)
        {
            this_param.GetMethodDefPropsOrThrow(methodDef, out name, out implFlags, out flags, out rva);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 16995, 17101);
            return 0;
        }


        int
        f_10707_17120_17168(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 17120, 17168);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10707_17466_17519(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, params object[]
        args)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 17466, 17519);
            return return_v;
        }


        Microsoft.CodeAnalysis.DiagnosticInfo
        f_10707_17438_17520(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        diagnostic)
        {
            var return_v = this_param.InitializeUseSiteDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)diagnostic);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 17438, 17520);
            return return_v;
        }


        int
        f_10707_17552_17601(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 17552, 17601);
            return 0;
        }


        bool
        f_10707_18641_18678(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param, System.Reflection.MethodAttributes
        flag)
        {
            var return_v = this_param.HasFlag(flag);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 18641, 18678);
            return return_v;
        }


        bool
        f_10707_18739_18778(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param, System.Reflection.MethodAttributes
        flag)
        {
            var return_v = this_param.HasFlag(flag);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 18739, 18778);
            return return_v;
        }


        bool
        f_10707_18952_18994(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param, System.Reflection.MethodAttributes
        flag)
        {
            var return_v = this_param.HasFlag(flag);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 18952, 18994);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
        f_10707_19379_19398()
        {
            var return_v = ReturnTypeParameter;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 19379, 19398);
            return return_v;
        }


        bool
        f_10707_19379_19421(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
        this_param)
        {
            var return_v = this_param.IsMarshalledExplicitly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 19379, 19421);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
        f_10707_19522_19541()
        {
            var return_v = ReturnTypeParameter;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 19522, 19541);
            return return_v;
        }


        Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
        f_10707_19522_19564(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
        this_param)
        {
            var return_v = this_param.MarshallingInformation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 19522, 19564);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
        f_10707_19652_19671()
        {
            var return_v = ReturnTypeParameter;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 19652, 19671);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<byte>
        f_10707_19652_19693(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
        this_param)
        {
            var return_v = this_param.MarshallingDescriptor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 19652, 19693);
            return return_v;
        }


        bool
        f_10707_19758_19805(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param, System.Reflection.MethodAttributes
        flag)
        {
            var return_v = this_param.HasFlag(flag);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 19758, 19805);
            return return_v;
        }


        bool
        f_10707_19867_19904(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param, System.Reflection.MethodAttributes
        flag)
        {
            var return_v = this_param.HasFlag(flag);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 19867, 19904);
            return return_v;
        }


        bool
        f_10707_21179_21216(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param, System.Reflection.MethodAttributes
        flag)
        {
            var return_v = this_param.HasFlag(flag);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 21179, 21216);
            return return_v;
        }


        bool
        f_10707_21266_21274()
        {
            var return_v = IsExtern;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 21266, 21274);
            return return_v;
        }


        System.Reflection.MethodImplAttributes
        f_10707_21279_21303()
        {
            var return_v = ImplementationAttributes;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 21279, 21303);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.SignatureData
        f_10707_21386_21395()
        {
            var return_v = Signature;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 21386, 21395);
            return return_v;
        }


        int
        f_10707_21511_21516()
        {
            var return_v = Arity;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 21511, 21516);
            return return_v;
        }


        bool
        f_10707_22597_22631(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param, System.Reflection.MethodAttributes
        flag)
        {
            var return_v = this_param.HasFlag(flag);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 22597, 22631);
            return return_v;
        }


        bool
        f_10707_23283_23303(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param)
        {
            var return_v = this_param.IsMetadataFinal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 23283, 23303);
            return return_v;
        }


        bool
        f_10707_23350_23382(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsInterface;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 23350, 23382);
            return return_v;
        }


        bool
        f_10707_23430_23445(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param)
        {
            var return_v = this_param.IsAbstract;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 23430, 23445);
            return return_v;
        }


        bool
        f_10707_23449_23473(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param)
        {
            var return_v = this_param.IsMetadataVirtual();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 23449, 23473);
            return return_v;
        }


        bool
        f_10707_23478_23502(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param)
        {
            var return_v = this_param.IsMetadataNewSlot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 23478, 23502);
            return return_v;
        }


        bool
        f_10707_23550_23566_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 23550, 23566);
            return return_v;
        }


        bool
        f_10707_23570_23585(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param)
        {
            var return_v = this_param.IsOverride;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 23570, 23585);
            return return_v;
        }


        bool
        f_10707_23668_23703(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param, System.Reflection.MethodAttributes
        flag)
        {
            var return_v = this_param.HasFlag(flag);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 23668, 23703);
            return return_v;
        }


        bool
        f_10707_24045_24069(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param)
        {
            var return_v = this_param.IsMetadataVirtual();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 24045, 24069);
            return return_v;
        }


        bool
        f_10707_24073_24091_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 24073, 24091);
            return return_v;
        }


        bool
        f_10707_24095_24116_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 24095, 24116);
            return return_v;
        }


        bool
        f_10707_24120_24136_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 24120, 24136);
            return return_v;
        }


        bool
        f_10707_24184_24216(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsInterface;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 24184, 24216);
            return return_v;
        }


        bool
        f_10707_24219_24243(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param)
        {
            var return_v = this_param.IsMetadataNewSlot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 24219, 24243);
            return return_v;
        }


        bool
        f_10707_24246_24262_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 24246, 24262);
            return return_v;
        }


        bool
        f_10707_25090_25123_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 25090, 25123);
            return return_v;
        }


        bool
        f_10707_25140_25164(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param)
        {
            var return_v = this_param.IsMetadataVirtual();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 25140, 25164);
            return return_v;
        }


        bool
        f_10707_25168_25186_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 25168, 25186);
            return return_v;
        }


        bool
        f_10707_25206_25230(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param)
        {
            var return_v = this_param.IsMetadataNewSlot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 25206, 25230);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10707_25242_25286(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
        this_param)
        {
            var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 25242, 25286);
            return return_v;
        }


        bool
        f_10707_25299_25327(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param)
        {
            var return_v = this_param.IsExplicitClassOverride;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 25299, 25327);
            return return_v;
        }


        bool
        f_10707_25374_25406(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param, System.Reflection.MethodAttributes
        flag)
        {
            var return_v = this_param.HasFlag(flag);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 25374, 25406);
            return return_v;
        }


        bool
        f_10707_25743_25774(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param, System.Reflection.MethodAttributes
        flag)
        {
            var return_v = this_param.HasFlag(flag);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 25743, 25774);
            return return_v;
        }


        Microsoft.CodeAnalysis.MethodKind
        f_10707_26694_26709(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param)
        {
            var return_v = this_param.MethodKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 26694, 26709);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        f_10707_26783_26798(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param)
        {
            var return_v = this_param.ReturnType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 26783, 26798);
            return return_v;
        }


        bool
        f_10707_26783_26811(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        type)
        {
            var return_v = type.IsVoidType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 26783, 26811);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.SignatureData
        f_10707_27658_27667()
        {
            var return_v = Signature;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 27658, 27667);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.SignatureData
        f_10707_27741_27750()
        {
            var return_v = Signature;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 27741, 27750);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.SignatureData
        f_10707_27810_27819()
        {
            var return_v = Signature;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 27810, 27819);
            return return_v;
        }


        Microsoft.CodeAnalysis.RefKind
        f_10707_27810_27839(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
        this_param)
        {
            var return_v = this_param.RefKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 27810, 27839);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.SignatureData
        f_10707_27917_27926()
        {
            var return_v = Signature;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 27917, 27926);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        f_10707_27917_27958(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
        this_param)
        {
            var return_v = this_param.TypeWithAnnotations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 27917, 27958);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.SignatureData
        f_10707_28048_28057()
        {
            var return_v = Signature;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 28048, 28057);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
        f_10707_28048_28093(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
        this_param)
        {
            var return_v = this_param.FlowAnalysisAnnotations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 28048, 28093);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.SignatureData
        f_10707_28182_28191()
        {
            var return_v = Signature;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 28182, 28191);
            return return_v;
        }


        System.Collections.Immutable.ImmutableHashSet<string>
        f_10707_28182_28229(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
        this_param)
        {
            var return_v = this_param.NotNullIfParameterNotNull;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 28182, 28229);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.SignatureData
        f_10707_32250_32259()
        {
            var return_v = Signature;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 32250, 32259);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
        f_10707_32250_32290(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
        this_param)
        {
            var return_v = this_param.RefCustomModifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 32250, 32290);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.SignatureData
        f_10707_34654_34669(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param)
        {
            var return_v = this_param.LoadSignature();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 34654, 34669);
            return return_v;
        }


        bool
        f_10707_39285_39300()
        {
            var return_v = IsGenericMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 39285, 39300);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        f_10707_39303_39337(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param)
        {
            var return_v = this_param.GetTypeParametersAsTypeArguments();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10707, 39303, 39337);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        f_10707_40568_40602(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
        this_param)
        {
            var return_v = this_param.ContainingPEModule;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 40568, 40602);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol.SignatureData
        f_10707_53190_53199()
        {
            var return_v = Signature;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10707, 53190, 53199);
            return return_v;
        }

    }
}
