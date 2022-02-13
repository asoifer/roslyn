// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.DocumentationComments;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE
{
    internal sealed class PEFieldSymbol : FieldSymbol
    {
        private struct PackedFlags
        {

            private const int
            HasDisallowNullAttribute = 0x1 << 0
            ;

            private const int
            HasAllowNullAttribute = 0x1 << 1
            ;

            private const int
            HasMaybeNullAttribute = 0x1 << 2
            ;

            private const int
            HasNotNullAttribute = 0x1 << 3
            ;

            private const int
            FlowAnalysisAnnotationsCompletionBit = 0x1 << 4
            ;

            private int _bits;

            public bool SetFlowAnalysisAnnotations(FlowAnalysisAnnotations value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 1502, 2423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 1604, 1779);

                    f_10705_1604_1778((value & ~(FlowAnalysisAnnotations.DisallowNull | FlowAnalysisAnnotations.AllowNull | FlowAnalysisAnnotations.MaybeNull | FlowAnalysisAnnotations.NotNull)) == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 1799, 1852);

                    int
                    bitsToSet = FlowAnalysisAnnotationsCompletionBit
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 1870, 1977) || true) && ((value & FlowAnalysisAnnotations.DisallowNull) != 0)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 1870, 1977);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 1927, 1977);

                        bitsToSet |= PackedFlags.HasDisallowNullAttribute;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 1870, 1977);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 1995, 2096) || true) && ((value & FlowAnalysisAnnotations.AllowNull) != 0)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 1995, 2096);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 2049, 2096);

                        bitsToSet |= PackedFlags.HasAllowNullAttribute;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 1995, 2096);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 2114, 2215) || true) && ((value & FlowAnalysisAnnotations.MaybeNull) != 0)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 2114, 2215);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 2168, 2215);

                        bitsToSet |= PackedFlags.HasMaybeNullAttribute;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 2114, 2215);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 2233, 2330) || true) && ((value & FlowAnalysisAnnotations.NotNull) != 0)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 2233, 2330);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 2285, 2330);

                        bitsToSet |= PackedFlags.HasNotNullAttribute;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 2233, 2330);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 2350, 2408);

                    return f_10705_2357_2407(ref _bits, bitsToSet);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 1502, 2423);

                    int
                    f_10705_1604_1778(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 1604, 1778);
                        return 0;
                    }


                    bool
                    f_10705_2357_2407(ref int
                    flags, int
                    toSet)
                    {
                        var return_v = ThreadSafeFlagOperations.Set(ref flags, toSet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 2357, 2407);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 1502, 2423);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 1502, 2423);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool TryGetFlowAnalysisAnnotations(out FlowAnalysisAnnotations value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 2439, 3364);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 2548, 2568);

                    int
                    theBits = _bits
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 2670, 2707);

                    value = FlowAnalysisAnnotations.None;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 2725, 2830) || true) && ((theBits & PackedFlags.HasDisallowNullAttribute) != 0)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 2725, 2830);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 2784, 2830);

                        value |= FlowAnalysisAnnotations.DisallowNull;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 2725, 2830);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 2848, 2947) || true) && ((theBits & PackedFlags.HasAllowNullAttribute) != 0)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 2848, 2947);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 2904, 2947);

                        value |= FlowAnalysisAnnotations.AllowNull;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 2848, 2947);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 2965, 3064) || true) && ((theBits & PackedFlags.HasMaybeNullAttribute) != 0)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 2965, 3064);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 3021, 3064);

                        value |= FlowAnalysisAnnotations.MaybeNull;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 2965, 3064);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 3082, 3177) || true) && ((theBits & PackedFlags.HasNotNullAttribute) != 0)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 3082, 3177);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 3136, 3177);

                        value |= FlowAnalysisAnnotations.NotNull;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 3082, 3177);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 3197, 3264);

                    var
                    result = (theBits & FlowAnalysisAnnotationsCompletionBit) != 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 3282, 3317);

                    f_10705_3282_3316(value == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10705, 3295, 3315) || result));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 3335, 3349);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 2439, 3364);

                    int
                    f_10705_3282_3316(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 3282, 3316);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 2439, 3364);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 2439, 3364);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static PackedFlags()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10705, 890, 3375);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 1143, 1178);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 1211, 1243);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 1276, 1308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 1341, 1371);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 1404, 1451);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10705, 890, 3375);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 890, 3375);
            }
        }

        private readonly FieldDefinitionHandle _handle;

        private readonly string _name;

        private readonly FieldAttributes _flags;

        private readonly PENamedTypeSymbol _containingType;

        private bool _lazyIsVolatile;

        private ImmutableArray<CSharpAttributeData> _lazyCustomAttributes;

        private ConstantValue _lazyConstantValue;

        private Tuple<CultureInfo, string> _lazyDocComment;

        private DiagnosticInfo _lazyUseSiteDiagnostic;

        private ObsoleteAttributeData _lazyObsoleteAttributeData;

        private TypeWithAnnotations.Boxed _lazyType;

        private int _lazyFixedSize;

        private NamedTypeSymbol _lazyFixedImplementationType;

        private PEEventSymbol _associatedEventOpt;

        private PackedFlags _packedFlags;

        internal PEFieldSymbol(
                    PEModuleSymbol moduleSymbol,
                    PENamedTypeSymbol containingType,
                    FieldDefinitionHandle fieldDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10705, 4390, 5301);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 3468, 3473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 3517, 3523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 3569, 3584);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 3608, 3623);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 3732, 3795);
                this._lazyConstantValue = f_10705_3753_3795(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 3885, 3900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 3934, 3990);
                this._lazyUseSiteDiagnostic = CSDiagnosticInfo.EmptyErrorInfo; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 4062, 4126);
                this._lazyObsoleteAttributeData = ObsoleteAttributeData.Uninitialized; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 4173, 4182);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 4205, 4219);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 4254, 4282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 4315, 4334);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 4572, 4615);

                f_10705_4572_4614((object)moduleSymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 4629, 4674);

                f_10705_4629_4673((object)containingType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 4688, 4718);

                f_10705_4688_4717(f_10705_4701_4716_M(!fieldDef.IsNil));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 4734, 4753);

                _handle = fieldDef;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 4767, 4800);

                _containingType = containingType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 4814, 4847);

                _packedFlags = f_10705_4829_4846();

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 4899, 4976);

                    f_10705_4899_4975(f_10705_4899_4918(moduleSymbol), fieldDef, out _name, out _flags);
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10705, 5005, 5290);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 5069, 5176) || true) && ((object)_name == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 5069, 5176);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 5136, 5157);

                        _name = String.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 5069, 5176);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 5196, 5275);

                    _lazyUseSiteDiagnostic = f_10705_5221_5274(ErrorCode.ERR_BindToBogus, this);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10705, 5005, 5290);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10705, 4390, 5301);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 4390, 5301);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 4390, 5301);
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 5377, 5451);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 5413, 5436);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 5377, 5451);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 5313, 5462);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 5313, 5462);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 5545, 5619);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 5581, 5604);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 5545, 5619);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 5474, 5630);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 5474, 5630);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 5694, 5758);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 5730, 5743);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 5694, 5758);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 5642, 5769);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 5642, 5769);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal FieldAttributes Flags
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 5836, 5901);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 5872, 5886);

                    return _flags;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 5836, 5901);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 5781, 5912);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 5781, 5912);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 5986, 6088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 6022, 6073);

                    return (_flags & FieldAttributes.SpecialName) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 5986, 6088);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 5924, 6099);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 5924, 6099);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 6180, 6284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 6216, 6269);

                    return (_flags & FieldAttributes.RTSpecialName) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 6180, 6284);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 6111, 6295);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 6111, 6295);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsNotSerialized
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 6370, 6474);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 6406, 6459);

                    return (_flags & FieldAttributes.NotSerialized) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 6370, 6474);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 6307, 6485);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 6307, 6485);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 6595, 6772);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 6745, 6757);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 6595, 6772);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 6497, 6783);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 6497, 6783);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMarshalledExplicitly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 6865, 6973);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 6901, 6958);

                    return ((_flags & FieldAttributes.HasFieldMarshal) != 0);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 6865, 6973);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 6795, 6984);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 6795, 6984);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override UnmanagedType MarshallingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 7068, 7337);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 7104, 7225) || true) && ((_flags & FieldAttributes.HasFieldMarshal) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 7104, 7225);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 7197, 7206);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 7104, 7225);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 7245, 7322);

                    return f_10705_7252_7321(f_10705_7252_7293(f_10705_7252_7286(_containingType)), _handle);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 7068, 7337);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10705_7252_7286(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 7252, 7286);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PEModule
                    f_10705_7252_7293(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 7252, 7293);
                        return return_v;
                    }


                    System.Runtime.InteropServices.UnmanagedType
                    f_10705_7252_7321(Microsoft.CodeAnalysis.PEModule
                    this_param, System.Reflection.Metadata.FieldDefinitionHandle
                    fieldOrParameterToken)
                    {
                        var return_v = this_param.GetMarshallingType((System.Reflection.Metadata.EntityHandle)fieldOrParameterToken);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 7252, 7321);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 6996, 7348);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 6996, 7348);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<byte> MarshallingDescriptor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 7445, 7748);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 7481, 7630) || true) && ((_flags & FieldAttributes.HasFieldMarshal) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 7481, 7630);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 7574, 7611);

                        return default(ImmutableArray<byte>);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 7481, 7630);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 7650, 7733);

                    return f_10705_7657_7732(f_10705_7657_7698(f_10705_7657_7691(_containingType)), _handle);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 7445, 7748);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10705_7657_7691(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 7657, 7691);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PEModule
                    f_10705_7657_7698(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 7657, 7698);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<byte>
                    f_10705_7657_7732(Microsoft.CodeAnalysis.PEModule
                    this_param, System.Reflection.Metadata.FieldDefinitionHandle
                    fieldOrParameterToken)
                    {
                        var return_v = this_param.GetMarshallingDescriptor((System.Reflection.Metadata.EntityHandle)fieldOrParameterToken);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 7657, 7732);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 7360, 7759);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 7360, 7759);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int? TypeLayoutOffset
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 7835, 7959);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 7871, 7944);

                    return f_10705_7878_7943(f_10705_7878_7919(f_10705_7878_7912(_containingType)), _handle);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 7835, 7959);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10705_7878_7912(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 7878, 7912);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PEModule
                    f_10705_7878_7919(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 7878, 7919);
                        return return_v;
                    }


                    int?
                    f_10705_7878_7943(Microsoft.CodeAnalysis.PEModule
                    this_param, System.Reflection.Metadata.FieldDefinitionHandle
                    fieldDef)
                    {
                        var return_v = this_param.GetFieldOffset(fieldDef);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 7878, 7943);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 7771, 7970);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 7771, 7970);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal FieldDefinitionHandle Handle
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 8044, 8110);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 8080, 8095);

                    return _handle;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 8044, 8110);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 7982, 8121);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 7982, 8121);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void SetAssociatedEvent(PEEventSymbol eventSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 8399, 9227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 8483, 8525);

                f_10705_8483_8524((object)eventSymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 8539, 8653);

                f_10705_8539_8652(f_10705_8552_8651(f_10705_8570_8596(eventSymbol), _containingType, TypeCompareKind.ConsiderEverything2));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 8814, 9216) || true) && ((object)_associatedEventOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 8814, 9216);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 9167, 9201);

                    _associatedEventOpt = eventSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 8814, 9216);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 8399, 9227);

                int
                f_10705_8483_8524(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 8483, 8524);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10705_8570_8596(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEEventSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 8570, 8596);
                    return return_v;
                }


                bool
                f_10705_8552_8651(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 8552, 8651);
                    return return_v;
                }


                int
                f_10705_8539_8652(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 8539, 8652);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 8399, 9227);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 8399, 9227);
            }
        }

        private void EnsureSignatureIsLoaded()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 9239, 11319);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 9302, 11308) || true) && (_lazyType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 9302, 11308);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 9357, 9411);

                    var
                    moduleSymbol = f_10705_9376_9410(_containingType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 9429, 9486);

                    ImmutableArray<ModifierInfo<TypeSymbol>>
                    customModifiers
                    = default(ImmutableArray<ModifierInfo<TypeSymbol>>);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 9504, 9632);

                    TypeSymbol
                    typeSymbol = f_10705_9528_9631((f_10705_9529_9579(moduleSymbol, _containingType)), _handle, out customModifiers)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 9650, 9750);

                    ImmutableArray<CustomModifier>
                    customModifiersArray = f_10705_9704_9749(customModifiers)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 9770, 9880);

                    typeSymbol = DynamicTypeDecoder.TransformType(typeSymbol, customModifiersArray.Length, _handle, moduleSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 9898, 9985);

                    typeSymbol = NativeIntegerTypeDecoder.TransformType(typeSymbol, _handle, moduleSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 10054, 10143);

                    var
                    type = TypeWithAnnotations.Create(typeSymbol, customModifiers: customModifiersArray)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 10317, 10441);

                    type = f_10705_10324_10440(type, _handle, moduleSymbol, accessSymbol: this, nullableContext: _containingType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 10459, 10541);

                    type = TupleTypeDecoder.DecodeTupleTypesIfApplicable(type, _handle, moduleSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 10561, 10708);

                    _lazyIsVolatile = customModifiersArray.Any(m => !m.IsOptional && m.Modifier.SpecialType == SpecialType.System_Runtime_CompilerServices_IsVolatile);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 10728, 10756);

                    TypeSymbol
                    fixedElementType
                    = default(TypeSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 10774, 10788);

                    int
                    fixedSize
                    = default(int);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 10806, 11187) || true) && (customModifiersArray.IsEmpty && (DynAbs.Tracing.TraceSender.Expression_True(10705, 10810, 10892) && f_10705_10842_10892(this, out fixedSize, out fixedElementType)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 10806, 11187);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 10934, 10961);

                        _lazyFixedSize = fixedSize;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 10983, 11043);

                        _lazyFixedImplementationType = type.Type as NamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 11065, 11168);

                        type = TypeWithAnnotations.Create(f_10705_11099_11166(TypeWithAnnotations.Create(fixedElementType)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 10806, 11187);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 11207, 11293);

                    f_10705_11207_11292(ref _lazyType, f_10705_11250_11285(type), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 9302, 11308);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 9239, 11319);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10705_9376_9410(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 9376, 9410);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                f_10705_9529_9579(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                context)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder(moduleSymbol, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 9529, 9579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10705_9528_9631(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                fieldHandle, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                customModifiers)
                {
                    var return_v = this_param.DecodeFieldSignature(fieldHandle, out customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 9528, 9631);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10705_9704_9749(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                customModifiers)
                {
                    var return_v = CSharpCustomModifier.Convert(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 9704, 9749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10705_10324_10440(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                metadataType, System.Reflection.Metadata.FieldDefinitionHandle
                targetSymbolToken, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                containingModule, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                accessSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                nullableContext)
                {
                    var return_v = NullableTypeDecoder.TransformType(metadataType, (System.Reflection.Metadata.EntityHandle)targetSymbolToken, containingModule, accessSymbol: (Microsoft.CodeAnalysis.CSharp.Symbol)accessSymbol, nullableContext: (Microsoft.CodeAnalysis.CSharp.Symbol)nullableContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 10324, 10440);
                    return return_v;
                }


                bool
                f_10705_10842_10892(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                this_param, out int
                fixedSize, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                fixedElementType)
                {
                    var return_v = this_param.IsFixedBuffer(out fixedSize, out fixedElementType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 10842, 10892);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                f_10705_11099_11166(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                pointedAtType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol(pointedAtType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 11099, 11166);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                f_10705_11250_11285(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 11250, 11285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                f_10705_11207_11292(ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 11207, 11292);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 9239, 11319);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 9239, 11319);
            }
        }

        private bool IsFixedBuffer(out int fixedSize, out TypeSymbol fixedElementType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 11331, 12217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 11434, 11448);

                fixedSize = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 11462, 11486);

                fixedElementType = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 11502, 11525);

                string
                elementTypeName
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 11539, 11554);

                int
                bufferSize
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 11568, 11628);

                PEModuleSymbol
                containingPEModule = f_10705_11604_11627(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 11642, 12177) || true) && (f_10705_11646_11741(f_10705_11646_11671(containingPEModule), _handle, out elementTypeName, out bufferSize))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 11642, 12177);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 11775, 11829);

                    var
                    decoder = f_10705_11789_11828(containingPEModule)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 11847, 11921);

                    var
                    elementType = f_10705_11865_11920(decoder, elementTypeName)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 11939, 12162) || true) && (f_10705_11943_11986(elementType) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 11939, 12162);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 12033, 12056);

                        fixedSize = bufferSize;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 12078, 12109);

                        fixedElementType = elementType;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 12131, 12143);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 11939, 12162);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 11642, 12177);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 12193, 12206);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 11331, 12217);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10705_11604_11627(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 11604, 11627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10705_11646_11671(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 11646, 11671);
                    return return_v;
                }


                bool
                f_10705_11646_11741(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                token, out string
                elementTypeName, out int
                bufferSize)
                {
                    var return_v = this_param.HasFixedBufferAttribute((System.Reflection.Metadata.EntityHandle)token, out elementTypeName, out bufferSize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 11646, 11741);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                f_10705_11789_11828(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder(moduleSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 11789, 11828);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10705_11865_11920(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, string
                s)
                {
                    var return_v = this_param.GetTypeSymbolForSerializedType(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 11865, 11920);
                    return return_v;
                }


                int
                f_10705_11943_11986(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.FixedBufferElementSizeInBytes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 11943, 11986);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 11331, 12217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 11331, 12217);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PEModuleSymbol ContainingPEModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 12295, 12413);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 12331, 12398);

                    return f_10705_12338_12397(((PENamespaceSymbol)f_10705_12358_12377()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 12295, 12413);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10705_12358_12377()
                    {
                        var return_v = ContainingNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 12358, 12377);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10705_12338_12397(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 12338, 12397);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 12229, 12424);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 12229, 12424);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TypeWithAnnotations GetFieldType(ConsList<FieldSymbol> fieldsBeingBound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 12436, 12625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 12551, 12577);

                f_10705_12551_12576(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 12591, 12614);

                return _lazyType.Value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 12436, 12625);

                int
                f_10705_12551_12576(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                this_param)
                {
                    this_param.EnsureSignatureIsLoaded();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 12551, 12576);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 12436, 12625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 12436, 12625);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override FlowAnalysisAnnotations FlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 12725, 13132);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 12761, 12791);

                    FlowAnalysisAnnotations
                    value
                    = default(FlowAnalysisAnnotations);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 12809, 13086) || true) && (!_packedFlags.TryGetFlowAnalysisAnnotations(out value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 12809, 13086);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 12909, 12998);

                        value = f_10705_12917_12997(f_10705_12946_12987(f_10705_12946_12980(_containingType)), _handle);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 13020, 13067);

                        _packedFlags.SetFlowAnalysisAnnotations(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 12809, 13086);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 13104, 13117);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 12725, 13132);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10705_12946_12980(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 12946, 12980);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PEModule
                    f_10705_12946_12987(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 12946, 12987);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
                    f_10705_12917_12997(Microsoft.CodeAnalysis.PEModule
                    module, System.Reflection.Metadata.FieldDefinitionHandle
                    handle)
                    {
                        var return_v = DecodeFlowAnalysisAttributes(module, handle);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 12917, 12997);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 12637, 13143);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 12637, 13143);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static FlowAnalysisAnnotations DecodeFlowAnalysisAttributes(PEModule module, FieldDefinitionHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10705, 13155, 13955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 13294, 13361);

                FlowAnalysisAnnotations
                annotations = FlowAnalysisAnnotations.None
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 13375, 13498) || true) && (f_10705_13379_13447(module, handle, AttributeDescription.AllowNullAttribute))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 13375, 13498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 13449, 13498);

                    annotations |= FlowAnalysisAnnotations.AllowNull;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 13375, 13498);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 13512, 13641) || true) && (f_10705_13516_13587(module, handle, AttributeDescription.DisallowNullAttribute))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 13512, 13641);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 13589, 13641);

                    annotations |= FlowAnalysisAnnotations.DisallowNull;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 13512, 13641);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 13655, 13778) || true) && (f_10705_13659_13727(module, handle, AttributeDescription.MaybeNullAttribute))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 13655, 13778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 13729, 13778);

                    annotations |= FlowAnalysisAnnotations.MaybeNull;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 13655, 13778);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 13792, 13911) || true) && (f_10705_13796_13862(module, handle, AttributeDescription.NotNullAttribute))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 13792, 13911);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 13864, 13911);

                    annotations |= FlowAnalysisAnnotations.NotNull;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 13792, 13911);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 13925, 13944);

                return annotations;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10705, 13155, 13955);

                bool
                f_10705_13379_13447(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                token, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.HasAttribute((System.Reflection.Metadata.EntityHandle)token, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 13379, 13447);
                    return return_v;
                }


                bool
                f_10705_13516_13587(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                token, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.HasAttribute((System.Reflection.Metadata.EntityHandle)token, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 13516, 13587);
                    return return_v;
                }


                bool
                f_10705_13659_13727(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                token, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.HasAttribute((System.Reflection.Metadata.EntityHandle)token, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 13659, 13727);
                    return return_v;
                }


                bool
                f_10705_13796_13862(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                token, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.HasAttribute((System.Reflection.Metadata.EntityHandle)token, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 13796, 13862);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 13155, 13955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 13155, 13955);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool IsFixedSizeBuffer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 14030, 14177);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 14066, 14092);

                    f_10705_14066_14091(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 14110, 14162);

                    return (object)_lazyFixedImplementationType != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 14030, 14177);

                    int
                    f_10705_14066_14091(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                    this_param)
                    {
                        this_param.EnsureSignatureIsLoaded();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 14066, 14091);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 13967, 14188);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 13967, 14188);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int FixedSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 14254, 14371);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 14290, 14316);

                    f_10705_14290_14315(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 14334, 14356);

                    return _lazyFixedSize;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 14254, 14371);

                    int
                    f_10705_14290_14315(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                    this_param)
                    {
                        this_param.EnsureSignatureIsLoaded();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 14290, 14315);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 14200, 14382);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 14200, 14382);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override NamedTypeSymbol FixedImplementationType(PEModuleBuilder emitModule)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 14394, 14591);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 14504, 14530);

                f_10705_14504_14529(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 14544, 14580);

                return _lazyFixedImplementationType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 14394, 14591);

                int
                f_10705_14504_14529(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                this_param)
                {
                    this_param.EnsureSignatureIsLoaded();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 14504, 14529);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 14394, 14591);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 14394, 14591);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Symbol AssociatedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 14667, 14745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 14703, 14730);

                    return _associatedEventOpt;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 14667, 14745);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 14603, 14756);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 14603, 14756);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 14824, 14923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 14860, 14908);

                    return (_flags & FieldAttributes.InitOnly) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 14824, 14923);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 14768, 14934);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 14768, 14934);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsVolatile
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 15002, 15120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 15038, 15064);

                    f_10705_15038_15063(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 15082, 15105);

                    return _lazyIsVolatile;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 15002, 15120);

                    int
                    f_10705_15038_15063(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                    this_param)
                    {
                        this_param.EnsureSignatureIsLoaded();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 15038, 15063);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 14946, 15131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 14946, 15131);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsConst
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 15196, 15395);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 15232, 15380);

                    return (_flags & FieldAttributes.Literal) != 0 || (DynAbs.Tracing.TraceSender.Expression_False(10705, 15239, 15379) || f_10705_15282_15371(this, ConstantFieldsInProgress.Empty, earlyDecodingWellKnownAttributes: false) != null);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 15196, 15395);

                    Microsoft.CodeAnalysis.ConstantValue
                    f_10705_15282_15371(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgress
                    inProgress, bool
                    earlyDecodingWellKnownAttributes)
                    {
                        var return_v = this_param.GetConstantValue(inProgress, earlyDecodingWellKnownAttributes: earlyDecodingWellKnownAttributes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 15282, 15371);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 15143, 15406);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 15143, 15406);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ConstantValue GetConstantValue(ConstantFieldsInProgress inProgress, bool earlyDecodingWellKnownAttributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 15418, 16638);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 15567, 16585) || true) && (_lazyConstantValue == f_10705_15593_15635())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 15567, 16585);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 15669, 15696);

                    ConstantValue
                    value = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 15716, 15901) || true) && ((_flags & FieldAttributes.Literal) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 15716, 15901);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 15801, 15882);

                        value = f_10705_15809_15881(f_10705_15809_15850(f_10705_15809_15843(_containingType)), _handle);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 15716, 15901);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 16023, 16383) || true) && (f_10705_16027_16048(f_10705_16027_16036(this)) == SpecialType.System_Decimal)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 16023, 16383);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 16120, 16147);

                        ConstantValue
                        defaultValue
                        = default(ConstantValue);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 16171, 16364) || true) && (f_10705_16175_16270(f_10705_16175_16216(f_10705_16175_16209(_containingType)), f_10705_16245_16251(), out defaultValue))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 16171, 16364);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 16320, 16341);

                            value = defaultValue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 16171, 16364);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 16023, 16383);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 16403, 16570);

                    f_10705_16403_16569(ref _lazyConstantValue, value, f_10705_16526_16568());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 15567, 16585);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 16601, 16627);

                return _lazyConstantValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 15418, 16638);

                Microsoft.CodeAnalysis.ConstantValue
                f_10705_15593_15635()
                {
                    var return_v = Microsoft.CodeAnalysis.ConstantValue.Unset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 15593, 15635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10705_15809_15843(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 15809, 15843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10705_15809_15850(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 15809, 15850);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10705_15809_15881(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                fieldDef)
                {
                    var return_v = this_param.GetConstantFieldValue(fieldDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 15809, 15881);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10705_16027_16036(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 16027, 16036);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10705_16027_16048(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 16027, 16048);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10705_16175_16209(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 16175, 16209);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10705_16175_16216(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 16175, 16216);
                    return return_v;
                }


                System.Reflection.Metadata.FieldDefinitionHandle
                f_10705_16245_16251()
                {
                    var return_v = Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 16245, 16251);
                    return return_v;
                }


                bool
                f_10705_16175_16270(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                token, out Microsoft.CodeAnalysis.ConstantValue
                defaultValue)
                {
                    var return_v = this_param.HasDecimalConstantAttribute((System.Reflection.Metadata.EntityHandle)token, out defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 16175, 16270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10705_16526_16568()
                {
                    var return_v = Microsoft.CodeAnalysis.ConstantValue.Unset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 16526, 16568);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10705_16403_16569(ref Microsoft.CodeAnalysis.ConstantValue
                location1, Microsoft.CodeAnalysis.ConstantValue?
                value, Microsoft.CodeAnalysis.ConstantValue
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 16403, 16569);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 15418, 16638);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 15418, 16638);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 16725, 16870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 16761, 16855);

                    return f_10705_16768_16802(_containingType).MetadataLocation.Cast<MetadataLocation, Location>();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 16725, 16870);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10705_16768_16802(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 16768, 16802);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 16650, 16881);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 16650, 16881);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 16991, 17087);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 17027, 17072);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 16991, 17087);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 16893, 17098);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 16893, 17098);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 17186, 18473);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 17222, 17257);

                    var
                    access = Accessibility.Private
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 17277, 18424);

                    switch (_flags & FieldAttributes.FieldAccessMask)
                    {

                        case FieldAttributes.Assembly:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 17277, 18424);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 17423, 17455);

                            access = Accessibility.Internal;
                            DynAbs.Tracing.TraceSender.TraceBreak(10705, 17481, 17487);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 17277, 18424);

                        case FieldAttributes.FamORAssem:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 17277, 18424);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 17569, 17612);

                            access = Accessibility.ProtectedOrInternal;
                            DynAbs.Tracing.TraceSender.TraceBreak(10705, 17638, 17644);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 17277, 18424);

                        case FieldAttributes.FamANDAssem:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 17277, 18424);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 17727, 17771);

                            access = Accessibility.ProtectedAndInternal;
                            DynAbs.Tracing.TraceSender.TraceBreak(10705, 17797, 17803);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 17277, 18424);

                        case FieldAttributes.Private:
                        case FieldAttributes.PrivateScope:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 17277, 18424);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 17938, 17969);

                            access = Accessibility.Private;
                            DynAbs.Tracing.TraceSender.TraceBreak(10705, 17995, 18001);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 17277, 18424);

                        case FieldAttributes.Public:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 17277, 18424);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 18079, 18109);

                            access = Accessibility.Public;
                            DynAbs.Tracing.TraceSender.TraceBreak(10705, 18135, 18141);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 17277, 18424);

                        case FieldAttributes.Family:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 17277, 18424);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 18219, 18252);

                            access = Accessibility.Protected;
                            DynAbs.Tracing.TraceSender.TraceBreak(10705, 18278, 18284);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 17277, 18424);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 17277, 18424);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 18342, 18373);

                            access = Accessibility.Private;
                            DynAbs.Tracing.TraceSender.TraceBreak(10705, 18399, 18405);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 17277, 18424);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 18444, 18458);

                    return access;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 17186, 18473);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 17110, 18484);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 17110, 18484);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 18550, 18647);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 18586, 18632);

                    return (_flags & FieldAttributes.Static) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 18550, 18647);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 18496, 18658);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 18496, 18658);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 18670, 19628);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 18762, 19574) || true) && (_lazyCustomAttributes.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 18762, 19574);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 18831, 18900);

                    var
                    containingPEModuleSymbol = (PEModuleSymbol)f_10705_18878_18899(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 18920, 19559) || true) && (f_10705_18924_18959(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 18920, 19559);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 19061, 19270);

                        var
                        attributes = f_10705_19078_19269(containingPEModuleSymbol, _handle, out _, AttributeDescription.DecimalConstantAttribute)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 19294, 19376);

                        f_10705_19294_19375(ref _lazyCustomAttributes, attributes);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 18920, 19559);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 18920, 19559);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 19458, 19540);

                        f_10705_19458_19539(containingPEModuleSymbol, _handle, ref _lazyCustomAttributes);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 18920, 19559);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 18762, 19574);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 19588, 19617);

                return _lazyCustomAttributes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 18670, 19628);

                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10705_18878_18899(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 18878, 18899);
                    return return_v;
                }


                bool
                f_10705_18924_18959(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                this_param)
                {
                    var return_v = this_param.FilterOutDecimalConstantAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 18924, 18959);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10705_19078_19269(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                token, out System.Reflection.Metadata.CustomAttributeHandle
                filteredOutAttribute1, Microsoft.CodeAnalysis.AttributeDescription
                filterOut1)
                {
                    var return_v = this_param.GetCustomAttributesForToken((System.Reflection.Metadata.EntityHandle)token, out filteredOutAttribute1, filterOut1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 19078, 19269);
                    return return_v;
                }


                bool
                f_10705_19294_19375(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 19294, 19375);
                    return return_v;
                }


                int
                f_10705_19458_19539(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                token, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                customAttributes)
                {
                    this_param.LoadCustomAttributes((System.Reflection.Metadata.EntityHandle)token, ref customAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 19458, 19539);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 18670, 19628);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 18670, 19628);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool FilterOutDecimalConstantAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 19640, 20041);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 19713, 19733);

                ConstantValue
                value
                = default(ConstantValue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 19747, 20030);

                return f_10705_19754_19775(f_10705_19754_19763(this)) == SpecialType.System_Decimal && (DynAbs.Tracing.TraceSender.Expression_True(10705, 19754, 19944) && (object)(value = f_10705_19846_19935(this, ConstantFieldsInProgress.Empty, earlyDecodingWellKnownAttributes: false)) != null) && (DynAbs.Tracing.TraceSender.Expression_True(10705, 19754, 20029) && f_10705_19968_19987(value) == ConstantValueTypeDiscriminator.Decimal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 19640, 20041);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10705_19754_19763(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 19754, 19763);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10705_19754_19775(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 19754, 19775);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10705_19846_19935(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgress
                inProgress, bool
                earlyDecodingWellKnownAttributes)
                {
                    var return_v = this_param.GetConstantValue(inProgress, earlyDecodingWellKnownAttributes: earlyDecodingWellKnownAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 19846, 19935);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                f_10705_19968_19987(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Discriminator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 19968, 19987);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 19640, 20041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 19640, 20041);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<CSharpAttributeData> GetCustomAttributesToEmit(PEModuleBuilder moduleBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 20053, 20807);

                var listYield = new List<CSharpAttributeData>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 20185, 20314);
                    foreach (CSharpAttributeData attribute in f_10705_20227_20242_I(f_10705_20227_20242(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 20185, 20314);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 20276, 20299);

                        listYield.Add(attribute);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 20185, 20314);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10705, 1, 130);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10705, 1, 130);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 20402, 20796) || true) && (f_10705_20406_20441(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 20402, 20796);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 20475, 20541);

                    var
                    containingPEModuleSymbol = f_10705_20506_20540(_containingType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 20559, 20781);

                    listYield.Add(f_10705_20572_20780(containingPEModuleSymbol, f_10705_20661_20772(f_10705_20661_20692(containingPEModuleSymbol), _handle, AttributeDescription.DecimalConstantAttribute).Handle));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 20402, 20796);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 20053, 20807);

                return listYield;

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10705_20227_20242(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 20227, 20242);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10705_20227_20242_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 20227, 20242);
                    return return_v;
                }


                bool
                f_10705_20406_20441(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                this_param)
                {
                    var return_v = this_param.FilterOutDecimalConstantAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 20406, 20441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10705_20506_20540(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 20506, 20540);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10705_20661_20692(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 20661, 20692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule.AttributeInfo
                f_10705_20661_20772(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                hasAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.FindLastTargetAttribute((System.Reflection.Metadata.EntityHandle)hasAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 20661, 20772);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAttributeData
                f_10705_20572_20780(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, System.Reflection.Metadata.CustomAttributeHandle
                handle)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAttributeData(moduleSymbol, handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 20572, 20780);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 20053, 20807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 20053, 20807);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 20819, 21195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 21025, 21184);

                return f_10705_21032_21183(this, f_10705_21090_21124(_containingType), preferredCulture, cancellationToken, ref _lazyDocComment);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 20819, 21195);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10705_21090_21124(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 21090, 21124);
                    return return_v;
                }


                string
                f_10705_21032_21183(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                containingPEModule, System.Globalization.CultureInfo?
                preferredCulture, System.Threading.CancellationToken
                cancellationToken, ref System.Tuple<System.Globalization.CultureInfo, string>
                lazyDocComment)
                {
                    var return_v = PEDocumentationCommentUtils.GetDocumentationComment((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, containingPEModule, preferredCulture, cancellationToken, ref lazyDocComment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 21032, 21183);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 20819, 21195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 20819, 21195);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override DiagnosticInfo GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 21207, 21605);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 21287, 21548) || true) && (f_10705_21291_21363(_lazyUseSiteDiagnostic, CSDiagnosticInfo.EmptyErrorInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10705, 21287, 21548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 21397, 21426);

                    DiagnosticInfo
                    result = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 21444, 21483);

                    f_10705_21444_21482(this, ref result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 21501, 21533);

                    _lazyUseSiteDiagnostic = result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10705, 21287, 21548);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 21564, 21594);

                return _lazyUseSiteDiagnostic;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 21207, 21605);

                bool
                f_10705_21291_21363(Microsoft.CodeAnalysis.DiagnosticInfo
                objA, Microsoft.CodeAnalysis.DiagnosticInfo
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 21291, 21363);
                    return return_v;
                }


                bool
                f_10705_21444_21482(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo?
                result)
                {
                    var return_v = this_param.CalculateUseSiteDiagnostic(ref result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 21444, 21482);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 21207, 21605);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 21207, 21605);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 21703, 21978);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 21739, 21911);

                    f_10705_21739_21910(ref _lazyObsoleteAttributeData, _handle, (f_10705_21857_21878(this)), ignoreByRefLikeMarker: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 21929, 21963);

                    return _lazyObsoleteAttributeData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 21703, 21978);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    f_10705_21857_21878(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 21857, 21878);
                        return return_v;
                    }


                    int
                    f_10705_21739_21910(ref Microsoft.CodeAnalysis.ObsoleteAttributeData
                    data, System.Reflection.Metadata.FieldDefinitionHandle
                    token, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    containingModule, bool
                    ignoreByRefLikeMarker)
                    {
                        ObsoleteAttributeHelpers.InitializeObsoleteDataFromMetadata(ref data, (System.Reflection.Metadata.EntityHandle)token, (Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol)containingModule, ignoreByRefLikeMarker: ignoreByRefLikeMarker);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 21739, 21910);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 21617, 21989);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 21617, 21989);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override CSharpCompilation DeclaringCompilation // perf, not correctness
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10705, 22114, 22134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10705, 22120, 22132);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10705, 22114, 22134);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10705, 22001, 22145);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 22001, 22145);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PEFieldSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10705, 824, 22152);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10705, 824, 22152);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10705, 824, 22152);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10705, 824, 22152);

        Microsoft.CodeAnalysis.ConstantValue
        f_10705_3753_3795()
        {
            var return_v = Microsoft.CodeAnalysis.ConstantValue.Unset;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 3753, 3795);
            return return_v;
        }


        int
        f_10705_4572_4614(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 4572, 4614);
            return 0;
        }


        int
        f_10705_4629_4673(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 4629, 4673);
            return 0;
        }


        bool
        f_10705_4701_4716_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 4701, 4716);
            return return_v;
        }


        int
        f_10705_4688_4717(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 4688, 4717);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol.PackedFlags
        f_10705_4829_4846()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol.PackedFlags();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 4829, 4846);
            return return_v;
        }


        Microsoft.CodeAnalysis.PEModule
        f_10705_4899_4918(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        this_param)
        {
            var return_v = this_param.Module;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10705, 4899, 4918);
            return return_v;
        }


        int
        f_10705_4899_4975(Microsoft.CodeAnalysis.PEModule
        this_param, System.Reflection.Metadata.FieldDefinitionHandle
        fieldDef, out string
        name, out System.Reflection.FieldAttributes
        flags)
        {
            this_param.GetFieldDefPropsOrThrow(fieldDef, out name, out flags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 4899, 4975);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10705_5221_5274(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, params object[]
        args)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10705, 5221, 5274);
            return return_v;
        }

    }
}
