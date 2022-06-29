// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Emit
{
    public sealed class EmitOptions : IEquatable<EmitOptions>
    {
        internal static readonly EmitOptions Default;

        public bool EmitMetadataOnly { get; private set; }

        public bool TolerateErrors { get; private set; }

        public bool IncludePrivateMembers { get; private set; }

        public ImmutableArray<InstrumentationKind> InstrumentationKinds { get; private set; }

        public SubsystemVersion SubsystemVersion { get; private set; }

        public int FileAlignment { get; private set; }

        public bool HighEntropyVirtualAddressSpace { get; private set; }

        public ulong BaseAddress { get; private set; }

        public DebugInformationFormat DebugInformationFormat { get; private set; }

        public string? OutputNameOverride { get; private set; }

        public string? PdbFilePath { get; private set; }

        public HashAlgorithmName PdbChecksumAlgorithm { get; private set; }

        public string? RuntimeMetadataVersion { get; private set; }

        public Encoding? DefaultSourceFileEncoding { get; private set; }

        public Encoding? FallbackSourceFileEncoding { get; private set; }

        public EmitOptions(
                    bool metadataOnly,
                    DebugInformationFormat debugInformationFormat,
                    string pdbFilePath,
                    string outputNameOverride,
                    int fileAlignment,
                    ulong baseAddress,
                    bool highEntropyVirtualAddressSpace,
                    SubsystemVersion subsystemVersion,
                    string runtimeMetadataVersion,
                    bool tolerateErrors,
                    bool includePrivateMembers)
        : this(
        f_291_5843_5855_C(metadataOnly), debugInformationFormat, pdbFilePath, outputNameOverride, fileAlignment, baseAddress, highEntropyVirtualAddressSpace, subsystemVersion, runtimeMetadataVersion, tolerateErrors, includePrivateMembers, instrumentationKinds: ImmutableArray<InstrumentationKind>.Empty)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(291, 5337, 6350);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(291, 5337, 6350);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 5337, 6350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 5337, 6350);
            }
        }

        public EmitOptions(
                    bool metadataOnly,
                    DebugInformationFormat debugInformationFormat,
                    string pdbFilePath,
                    string outputNameOverride,
                    int fileAlignment,
                    ulong baseAddress,
                    bool highEntropyVirtualAddressSpace,
                    SubsystemVersion subsystemVersion,
                    string runtimeMetadataVersion,
                    bool tolerateErrors,
                    bool includePrivateMembers,
                    ImmutableArray<InstrumentationKind> instrumentationKinds)
        : this(
        f_291_6991_7003_C(metadataOnly), debugInformationFormat, pdbFilePath, outputNameOverride, fileAlignment, baseAddress, highEntropyVirtualAddressSpace, subsystemVersion, runtimeMetadataVersion, tolerateErrors, includePrivateMembers, instrumentationKinds, pdbChecksumAlgorithm: null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(291, 6414, 7502);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(291, 6414, 7502);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 6414, 7502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 6414, 7502);
            }
        }

        public EmitOptions(
                   bool metadataOnly,
                   DebugInformationFormat debugInformationFormat,
                   string? pdbFilePath,
                   string? outputNameOverride,
                   int fileAlignment,
                   ulong baseAddress,
                   bool highEntropyVirtualAddressSpace,
                   SubsystemVersion subsystemVersion,
                   string? runtimeMetadataVersion,
                   bool tolerateErrors,
                   bool includePrivateMembers,
                   ImmutableArray<InstrumentationKind> instrumentationKinds,
                   HashAlgorithmName? pdbChecksumAlgorithm)
        : this(
        f_291_8187_8199_C(metadataOnly), debugInformationFormat, pdbFilePath, outputNameOverride, fileAlignment, baseAddress, highEntropyVirtualAddressSpace, subsystemVersion, runtimeMetadataVersion, tolerateErrors, includePrivateMembers, instrumentationKinds, pdbChecksumAlgorithm, defaultSourceFileEncoding: null, fallbackSourceFileEncoding: null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(291, 7566, 8797);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(291, 7566, 8797);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 7566, 8797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 7566, 8797);
            }
        }

        public EmitOptions(
                    bool metadataOnly = false,
                    DebugInformationFormat debugInformationFormat = 0,
                    string? pdbFilePath = null,
                    string? outputNameOverride = null,
                    int fileAlignment = 0,
                    ulong baseAddress = 0,
                    bool highEntropyVirtualAddressSpace = false,
                    SubsystemVersion subsystemVersion = default,
                    string? runtimeMetadataVersion = null,
                    bool tolerateErrors = false,
                    bool includePrivateMembers = true,
                    ImmutableArray<InstrumentationKind> instrumentationKinds = default,
                    HashAlgorithmName? pdbChecksumAlgorithm = null,
                    Encoding? defaultSourceFileEncoding = null,
                    Encoding? fallbackSourceFileEncoding = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(291, 8809, 10569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 921, 971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 1143, 1191);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 1568, 1623);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 2347, 2393);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 2538, 2602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 2744, 2790);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 2888, 2962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 3711, 3766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 4079, 4127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 4559, 4618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 4877, 4941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 5208, 5273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 9633, 9665);

                EmitMetadataOnly = metadataOnly;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 9679, 9788);

                DebugInformationFormat = (DynAbs.Tracing.TraceSender.Conditional_F1(291, 9704, 9733) || (((debugInformationFormat == 0) && DynAbs.Tracing.TraceSender.Conditional_F2(291, 9736, 9762)) || DynAbs.Tracing.TraceSender.Conditional_F3(291, 9765, 9787))) ? DebugInformationFormat.Pdb : debugInformationFormat;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 9802, 9828);

                PdbFilePath = pdbFilePath;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 9842, 9882);

                OutputNameOverride = outputNameOverride;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 9896, 9926);

                FileAlignment = fileAlignment;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 9940, 9966);

                BaseAddress = baseAddress;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 9980, 10044);

                HighEntropyVirtualAddressSpace = highEntropyVirtualAddressSpace;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 10058, 10094);

                SubsystemVersion = subsystemVersion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 10108, 10156);

                RuntimeMetadataVersion = runtimeMetadataVersion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 10170, 10202);

                TolerateErrors = tolerateErrors;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 10216, 10262);

                IncludePrivateMembers = includePrivateMembers;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 10276, 10334);

                InstrumentationKinds = instrumentationKinds.NullToEmpty();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 10348, 10420);

                PdbChecksumAlgorithm = pdbChecksumAlgorithm ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Security.Cryptography.HashAlgorithmName?>(291, 10371, 10419) ?? HashAlgorithmName.SHA256);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 10434, 10488);

                DefaultSourceFileEncoding = defaultSourceFileEncoding;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 10502, 10558);

                FallbackSourceFileEncoding = fallbackSourceFileEncoding;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(291, 8809, 10569);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 8809, 10569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 8809, 10569);
            }
        }

        private EmitOptions(EmitOptions other) : this(
        f_291_10641_10663_C(f_291_10641_10663(other)), f_291_10678_10706(other), f_291_10721_10738(other), f_291_10753_10777(other), f_291_10792_10811(other), f_291_10826_10843(other), f_291_10858_10894(other), f_291_10909_10931(other), f_291_10946_10974(other), f_291_10989_11009(other), f_291_11024_11051(other), f_291_11066_11092(other), f_291_11107_11133(other), f_291_11148_11179(other), f_291_11194_11226(other))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(291, 10581, 11249);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(291, 10581, 11249);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 10581, 11249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 10581, 11249);
            }
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(291, 11261, 11371);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 11326, 11360);

                return f_291_11333_11359(this, obj as EmitOptions);
                DynAbs.Tracing.TraceSender.TraceExitMethod(291, 11261, 11371);

                bool
                f_291_11333_11359(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param, object?
                other)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.Emit.EmitOptions?)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 11333, 11359);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 11261, 11371);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 11261, 11371);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(EmitOptions? other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(291, 11383, 12669);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 11446, 11540) || true) && (f_291_11450_11478(other, null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 11446, 11540);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 11512, 11525);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(291, 11446, 11540);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 11556, 12658);

                return
                f_291_11580_11596() == f_291_11600_11622(other) && (DynAbs.Tracing.TraceSender.Expression_True(291, 11580, 11675) && f_291_11643_11654() == f_291_11658_11675(other)) && (DynAbs.Tracing.TraceSender.Expression_True(291, 11580, 11732) && f_291_11696_11709() == f_291_11713_11732(other)) && (DynAbs.Tracing.TraceSender.Expression_True(291, 11580, 11823) && f_291_11753_11783() == f_291_11787_11823(other)) && (DynAbs.Tracing.TraceSender.Expression_True(291, 11580, 11891) && f_291_11844_11860().Equals(f_291_11868_11890(other))) && (DynAbs.Tracing.TraceSender.Expression_True(291, 11580, 11966) && f_291_11912_11934() == f_291_11938_11966(other)) && (DynAbs.Tracing.TraceSender.Expression_True(291, 11580, 12019) && f_291_11987_11998() == f_291_12002_12019(other)) && (DynAbs.Tracing.TraceSender.Expression_True(291, 11580, 12090) && f_291_12040_12060() == f_291_12064_12090(other)) && (DynAbs.Tracing.TraceSender.Expression_True(291, 11580, 12157) && f_291_12111_12129() == f_291_12133_12157(other)) && (DynAbs.Tracing.TraceSender.Expression_True(291, 11580, 12232) && f_291_12178_12200() == f_291_12204_12232(other)) && (DynAbs.Tracing.TraceSender.Expression_True(291, 11580, 12291) && f_291_12253_12267() == f_291_12271_12291(other)) && (DynAbs.Tracing.TraceSender.Expression_True(291, 11580, 12364) && f_291_12312_12333() == f_291_12337_12364(other)) && (DynAbs.Tracing.TraceSender.Expression_True(291, 11580, 12493) && f_291_12385_12405().NullToEmpty().SequenceEqual(other.InstrumentationKinds.NullToEmpty(), (a, b) => a == b)) && (DynAbs.Tracing.TraceSender.Expression_True(291, 11580, 12574) && f_291_12514_12539() == f_291_12543_12574(other)) && (DynAbs.Tracing.TraceSender.Expression_True(291, 11580, 12657) && f_291_12595_12621() == f_291_12625_12657(other));
                DynAbs.Tracing.TraceSender.TraceExitMethod(291, 11383, 12669);

                bool
                f_291_11450_11478(Microsoft.CodeAnalysis.Emit.EmitOptions?
                objA, object?
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 11450, 11478);
                    return return_v;
                }


                bool
                f_291_11580_11596()
                {
                    var return_v = EmitMetadataOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 11580, 11596);
                    return return_v;
                }


                bool
                f_291_11600_11622(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.EmitMetadataOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 11600, 11622);
                    return return_v;
                }


                ulong
                f_291_11643_11654()
                {
                    var return_v = BaseAddress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 11643, 11654);
                    return return_v;
                }


                ulong
                f_291_11658_11675(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.BaseAddress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 11658, 11675);
                    return return_v;
                }


                int
                f_291_11696_11709()
                {
                    var return_v = FileAlignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 11696, 11709);
                    return return_v;
                }


                int
                f_291_11713_11732(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.FileAlignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 11713, 11732);
                    return return_v;
                }


                bool
                f_291_11753_11783()
                {
                    var return_v = HighEntropyVirtualAddressSpace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 11753, 11783);
                    return return_v;
                }


                bool
                f_291_11787_11823(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.HighEntropyVirtualAddressSpace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 11787, 11823);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SubsystemVersion
                f_291_11844_11860()
                {
                    var return_v = SubsystemVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 11844, 11860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SubsystemVersion
                f_291_11868_11890(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.SubsystemVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 11868, 11890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                f_291_11912_11934()
                {
                    var return_v = DebugInformationFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 11912, 11934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                f_291_11938_11966(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.DebugInformationFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 11938, 11966);
                    return return_v;
                }


                string?
                f_291_11987_11998()
                {
                    var return_v = PdbFilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 11987, 11998);
                    return return_v;
                }


                string?
                f_291_12002_12019(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.PdbFilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 12002, 12019);
                    return return_v;
                }


                System.Security.Cryptography.HashAlgorithmName
                f_291_12040_12060()
                {
                    var return_v = PdbChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 12040, 12060);
                    return return_v;
                }


                System.Security.Cryptography.HashAlgorithmName
                f_291_12064_12090(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.PdbChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 12064, 12090);
                    return return_v;
                }


                string?
                f_291_12111_12129()
                {
                    var return_v = OutputNameOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 12111, 12129);
                    return return_v;
                }


                string?
                f_291_12133_12157(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.OutputNameOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 12133, 12157);
                    return return_v;
                }


                string?
                f_291_12178_12200()
                {
                    var return_v = RuntimeMetadataVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 12178, 12200);
                    return return_v;
                }


                string?
                f_291_12204_12232(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.RuntimeMetadataVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 12204, 12232);
                    return return_v;
                }


                bool
                f_291_12253_12267()
                {
                    var return_v = TolerateErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 12253, 12267);
                    return return_v;
                }


                bool
                f_291_12271_12291(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.TolerateErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 12271, 12291);
                    return return_v;
                }


                bool
                f_291_12312_12333()
                {
                    var return_v = IncludePrivateMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 12312, 12333);
                    return return_v;
                }


                bool
                f_291_12337_12364(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.IncludePrivateMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 12337, 12364);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
                f_291_12385_12405()
                {
                    var return_v = InstrumentationKinds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 12385, 12405);
                    return return_v;
                }


                System.Text.Encoding?
                f_291_12514_12539()
                {
                    var return_v = DefaultSourceFileEncoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 12514, 12539);
                    return return_v;
                }


                System.Text.Encoding?
                f_291_12543_12574(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.DefaultSourceFileEncoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 12543, 12574);
                    return return_v;
                }


                System.Text.Encoding?
                f_291_12595_12621()
                {
                    var return_v = FallbackSourceFileEncoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 12595, 12621);
                    return return_v;
                }


                System.Text.Encoding?
                f_291_12625_12657(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.FallbackSourceFileEncoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 12625, 12657);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 11383, 12669);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 11383, 12669);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(291, 12681, 13631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 12739, 13620);

                return f_291_12746_13619(f_291_12759_12775(), f_291_12797_13618(f_291_12810_12835(f_291_12810_12821()), f_291_12857_13617(f_291_12870_12883(), f_291_12905_13616(f_291_12918_12948(), f_291_12970_13615(f_291_12983_12999().GetHashCode(), f_291_13035_13614(f_291_13053_13075(), f_291_13097_13613(f_291_13110_13121(), f_291_13143_13612(f_291_13156_13176().GetHashCode(), f_291_13212_13611(f_291_13225_13243(), f_291_13265_13610(f_291_13278_13300(), f_291_13322_13609(f_291_13335_13349(), f_291_13371_13608(f_291_13384_13405(), f_291_13427_13607(f_291_13440_13480(f_291_13459_13479()), f_291_13502_13606(f_291_13515_13540(), f_291_13562_13605(f_291_13575_13601(), 0)))))))))))))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(291, 12681, 13631);

                bool
                f_291_12759_12775()
                {
                    var return_v = EmitMetadataOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 12759, 12775);
                    return return_v;
                }


                ulong
                f_291_12810_12821()
                {
                    var return_v = BaseAddress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 12810, 12821);
                    return return_v;
                }


                int
                f_291_12810_12835(ulong
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 12810, 12835);
                    return return_v;
                }


                int
                f_291_12870_12883()
                {
                    var return_v = FileAlignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 12870, 12883);
                    return return_v;
                }


                bool
                f_291_12918_12948()
                {
                    var return_v = HighEntropyVirtualAddressSpace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 12918, 12948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SubsystemVersion
                f_291_12983_12999()
                {
                    var return_v = SubsystemVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 12983, 12999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                f_291_13053_13075()
                {
                    var return_v = DebugInformationFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 13053, 13075);
                    return return_v;
                }


                string?
                f_291_13110_13121()
                {
                    var return_v = PdbFilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 13110, 13121);
                    return return_v;
                }


                System.Security.Cryptography.HashAlgorithmName
                f_291_13156_13176()
                {
                    var return_v = PdbChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 13156, 13176);
                    return return_v;
                }


                string?
                f_291_13225_13243()
                {
                    var return_v = OutputNameOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 13225, 13243);
                    return return_v;
                }


                string?
                f_291_13278_13300()
                {
                    var return_v = RuntimeMetadataVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 13278, 13300);
                    return return_v;
                }


                bool
                f_291_13335_13349()
                {
                    var return_v = TolerateErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 13335, 13349);
                    return return_v;
                }


                bool
                f_291_13384_13405()
                {
                    var return_v = IncludePrivateMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 13384, 13405);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
                f_291_13459_13479()
                {
                    var return_v = InstrumentationKinds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 13459, 13479);
                    return return_v;
                }


                int
                f_291_13440_13480(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
                values)
                {
                    var return_v = Hash.CombineValues(values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 13440, 13480);
                    return return_v;
                }


                System.Text.Encoding?
                f_291_13515_13540()
                {
                    var return_v = DefaultSourceFileEncoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 13515, 13540);
                    return return_v;
                }


                System.Text.Encoding?
                f_291_13575_13601()
                {
                    var return_v = FallbackSourceFileEncoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 13575, 13601);
                    return return_v;
                }


                int
                f_291_13562_13605(System.Text.Encoding?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 13562, 13605);
                    return return_v;
                }


                int
                f_291_13502_13606(System.Text.Encoding?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 13502, 13606);
                    return return_v;
                }


                int
                f_291_13427_13607(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 13427, 13607);
                    return return_v;
                }


                int
                f_291_13371_13608(bool
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 13371, 13608);
                    return return_v;
                }


                int
                f_291_13322_13609(bool
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 13322, 13609);
                    return return_v;
                }


                int
                f_291_13265_13610(string?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 13265, 13610);
                    return return_v;
                }


                int
                f_291_13212_13611(string?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 13212, 13611);
                    return return_v;
                }


                int
                f_291_13143_13612(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 13143, 13612);
                    return return_v;
                }


                int
                f_291_13097_13613(string?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 13097, 13613);
                    return return_v;
                }


                int
                f_291_13035_13614(Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine((int)newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 13035, 13614);
                    return return_v;
                }


                int
                f_291_12970_13615(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 12970, 13615);
                    return return_v;
                }


                int
                f_291_12905_13616(bool
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 12905, 13616);
                    return return_v;
                }


                int
                f_291_12857_13617(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 12857, 13617);
                    return return_v;
                }


                int
                f_291_12797_13618(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 12797, 13618);
                    return return_v;
                }


                int
                f_291_12746_13619(bool
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 12746, 13619);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 12681, 13631);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 12681, 13631);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(EmitOptions? left, EmitOptions? right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(291, 13643, 13782);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 13737, 13771);

                return f_291_13744_13770(left, right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(291, 13643, 13782);

                bool
                f_291_13744_13770(Microsoft.CodeAnalysis.Emit.EmitOptions?
                objA, Microsoft.CodeAnalysis.Emit.EmitOptions?
                objB)
                {
                    var return_v = object.Equals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 13744, 13770);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 13643, 13782);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 13643, 13782);
            }
        }

        public static bool operator !=(EmitOptions? left, EmitOptions? right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(291, 13794, 13934);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 13888, 13923);

                return !f_291_13896_13922(left, right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(291, 13794, 13934);

                bool
                f_291_13896_13922(Microsoft.CodeAnalysis.Emit.EmitOptions?
                objA, Microsoft.CodeAnalysis.Emit.EmitOptions?
                objB)
                {
                    var return_v = object.Equals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 13896, 13922);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 13794, 13934);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 13794, 13934);
            }
        }

        internal void ValidateOptions(DiagnosticBag diagnostics, CommonMessageProvider messageProvider, bool isDeterministic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(291, 13946, 16352);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 14088, 14319) || true) && (!f_291_14093_14125(f_291_14093_14115()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 14088, 14319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 14159, 14304);

                    f_291_14159_14303(diagnostics, f_291_14175_14302(messageProvider, f_291_14208_14257(messageProvider), f_291_14259_14272(), f_291_14279_14301()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(291, 14088, 14319);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 14335, 14674);
                    foreach (var instrumentationKind in f_291_14371_14391_I(f_291_14371_14391()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 14335, 14674);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 14425, 14659) || true) && (!f_291_14430_14459(instrumentationKind))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 14425, 14659);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 14501, 14640);

                            f_291_14501_14639(diagnostics, f_291_14517_14638(messageProvider, f_291_14550_14596(messageProvider), f_291_14598_14611(), instrumentationKind));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(291, 14425, 14659);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(291, 14335, 14674);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(291, 1, 340);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(291, 1, 340);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 14690, 14900) || true) && (f_291_14694_14712() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 14690, 14900);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 14754, 14885);

                    f_291_14754_14884(f_291_14796_14814(), messageProvider, f_291_14833_14870(messageProvider), diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(291, 14690, 14900);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 14916, 15149) || true) && (f_291_14920_14933() != 0 && (DynAbs.Tracing.TraceSender.Expression_True(291, 14920, 14978) && !f_291_14943_14978(f_291_14964_14977())))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 14916, 15149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 15012, 15134);

                    f_291_15012_15133(diagnostics, f_291_15028_15132(messageProvider, f_291_15061_15101(messageProvider), f_291_15103_15116(), f_291_15118_15131()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(291, 14916, 15149);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 15165, 15433) || true) && (!f_291_15170_15186().Equals(SubsystemVersion.None) && (DynAbs.Tracing.TraceSender.Expression_True(291, 15169, 15245) && f_291_15220_15245_M(!f_291_15221_15237().IsValid)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 15165, 15433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 15279, 15418);

                    f_291_15279_15417(diagnostics, f_291_15295_15416(messageProvider, f_291_15328_15371(messageProvider), f_291_15373_15386(), f_291_15388_15404().ToString()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(291, 15165, 15433);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 15449, 16086) || true) && (f_291_15453_15473().Name != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 15449, 16086);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 15564, 15623);

                        f_291_15564_15622(f_291_15564_15612(f_291_15591_15611()));
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(291, 15660, 15869);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 15706, 15850);

                        f_291_15706_15849(diagnostics, f_291_15722_15848(messageProvider, f_291_15755_15799(messageProvider), f_291_15801_15814(), f_291_15816_15836().ToString()));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(291, 15660, 15869);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(291, 15449, 16086);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 15449, 16086);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 15903, 16086) || true) && (isDeterministic)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 15903, 16086);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 15956, 16071);

                        f_291_15956_16070(diagnostics, f_291_15972_16069(messageProvider, f_291_16005_16049(messageProvider), f_291_16051_16064(), ""));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(291, 15903, 16086);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(291, 15449, 16086);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 16102, 16341) || true) && (f_291_16106_16117() != null && (DynAbs.Tracing.TraceSender.Expression_True(291, 16106, 16172) && !f_291_16130_16172(f_291_16160_16171())))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 16102, 16341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 16206, 16326);

                    f_291_16206_16325(diagnostics, f_291_16222_16324(messageProvider, f_291_16255_16295(messageProvider), f_291_16297_16310(), f_291_16312_16323()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(291, 16102, 16341);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(291, 13946, 16352);

                Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                f_291_14093_14115()
                {
                    var return_v = DebugInformationFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 14093, 14115);
                    return return_v;
                }


                bool
                f_291_14093_14125(Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                value)
                {
                    var return_v = value.IsValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 14093, 14125);
                    return return_v;
                }


                int
                f_291_14208_14257(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_InvalidDebugInformationFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 14208, 14257);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_291_14259_14272()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 14259, 14272);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                f_291_14279_14301()
                {
                    var return_v = DebugInformationFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 14279, 14301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_291_14175_14302(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 14175, 14302);
                    return return_v;
                }


                int
                f_291_14159_14303(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 14159, 14303);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
                f_291_14371_14391()
                {
                    var return_v = InstrumentationKinds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 14371, 14391);
                    return return_v;
                }


                bool
                f_291_14430_14459(Microsoft.CodeAnalysis.Emit.InstrumentationKind
                value)
                {
                    var return_v = value.IsValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 14430, 14459);
                    return return_v;
                }


                int
                f_291_14550_14596(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_InvalidInstrumentationKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 14550, 14596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_291_14598_14611()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 14598, 14611);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_291_14517_14638(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 14517, 14638);
                    return return_v;
                }


                int
                f_291_14501_14639(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 14501, 14639);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
                f_291_14371_14391_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 14371, 14391);
                    return return_v;
                }


                string?
                f_291_14694_14712()
                {
                    var return_v = OutputNameOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 14694, 14712);
                    return return_v;
                }


                string
                f_291_14796_14814()
                {
                    var return_v = OutputNameOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 14796, 14814);
                    return return_v;
                }


                int
                f_291_14833_14870(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_InvalidOutputName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 14833, 14870);
                    return return_v;
                }


                int
                f_291_14754_14884(string
                name, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                code, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    MetadataHelpers.CheckAssemblyOrModuleName(name, messageProvider, code, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 14754, 14884);
                    return 0;
                }


                int
                f_291_14920_14933()
                {
                    var return_v = FileAlignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 14920, 14933);
                    return return_v;
                }


                int
                f_291_14964_14977()
                {
                    var return_v = FileAlignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 14964, 14977);
                    return return_v;
                }


                bool
                f_291_14943_14978(int
                value)
                {
                    var return_v = IsValidFileAlignment(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 14943, 14978);
                    return return_v;
                }


                int
                f_291_15061_15101(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_InvalidFileAlignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 15061, 15101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_291_15103_15116()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 15103, 15116);
                    return return_v;
                }


                int
                f_291_15118_15131()
                {
                    var return_v = FileAlignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 15118, 15131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_291_15028_15132(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 15028, 15132);
                    return return_v;
                }


                int
                f_291_15012_15133(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 15012, 15133);
                    return 0;
                }


                Microsoft.CodeAnalysis.SubsystemVersion
                f_291_15170_15186()
                {
                    var return_v = SubsystemVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 15170, 15186);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SubsystemVersion
                f_291_15221_15237()
                {
                    var return_v = SubsystemVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 15221, 15237);
                    return return_v;
                }


                bool
                f_291_15220_15245_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 15220, 15245);
                    return return_v;
                }


                int
                f_291_15328_15371(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_InvalidSubsystemVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 15328, 15371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_291_15373_15386()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 15373, 15386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SubsystemVersion
                f_291_15388_15404()
                {
                    var return_v = SubsystemVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 15388, 15404);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_291_15295_15416(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 15295, 15416);
                    return return_v;
                }


                int
                f_291_15279_15417(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 15279, 15417);
                    return 0;
                }


                System.Security.Cryptography.HashAlgorithmName
                f_291_15453_15473()
                {
                    var return_v = PdbChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 15453, 15473);
                    return return_v;
                }


                System.Security.Cryptography.HashAlgorithmName
                f_291_15591_15611()
                {
                    var return_v = PdbChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 15591, 15611);
                    return return_v;
                }


                System.Security.Cryptography.IncrementalHash
                f_291_15564_15612(System.Security.Cryptography.HashAlgorithmName
                hashAlgorithm)
                {
                    var return_v = IncrementalHash.CreateHash(hashAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 15564, 15612);
                    return return_v;
                }


                int
                f_291_15564_15622(System.Security.Cryptography.IncrementalHash
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 15564, 15622);
                    return 0;
                }


                int
                f_291_15755_15799(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_InvalidHashAlgorithmName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 15755, 15799);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_291_15801_15814()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 15801, 15814);
                    return return_v;
                }


                System.Security.Cryptography.HashAlgorithmName
                f_291_15816_15836()
                {
                    var return_v = PdbChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 15816, 15836);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_291_15722_15848(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 15722, 15848);
                    return return_v;
                }


                int
                f_291_15706_15849(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 15706, 15849);
                    return 0;
                }


                int
                f_291_16005_16049(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_InvalidHashAlgorithmName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 16005, 16049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_291_16051_16064()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 16051, 16064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_291_15972_16069(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 15972, 16069);
                    return return_v;
                }


                int
                f_291_15956_16070(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 15956, 16070);
                    return 0;
                }


                string?
                f_291_16106_16117()
                {
                    var return_v = PdbFilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 16106, 16117);
                    return return_v;
                }


                string
                f_291_16160_16171()
                {
                    var return_v = PdbFilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 16160, 16171);
                    return return_v;
                }


                bool
                f_291_16130_16172(string
                fullPath)
                {
                    var return_v = PathUtilities.IsValidFilePath(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 16130, 16172);
                    return return_v;
                }


                int
                f_291_16255_16295(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.FTL_InvalidInputFileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 16255, 16295);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_291_16297_16310()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 16297, 16310);
                    return return_v;
                }


                string
                f_291_16312_16323()
                {
                    var return_v = PdbFilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 16312, 16323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_291_16222_16324(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 16222, 16324);
                    return return_v;
                }


                int
                f_291_16206_16325(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 16206, 16325);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 13946, 16352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 13946, 16352);
            }
        }

        internal bool EmitTestCoverageData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(291, 16399, 16465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 16402, 16465);
                    return f_291_16402_16422().Contains(InstrumentationKind.TestCoverage); DynAbs.Tracing.TraceSender.TraceExitMethod(291, 16399, 16465);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 16399, 16465);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 16399, 16465);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static bool IsValidFileAlignment(int value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(291, 16478, 16846);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 16555, 16835);

                switch (value)
                {

                    case 512:
                    case 1024:
                    case 2048:
                    case 4096:
                    case 8192:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 16555, 16835);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 16745, 16757);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(291, 16555, 16835);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 16555, 16835);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 16807, 16820);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(291, 16555, 16835);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(291, 16478, 16846);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 16478, 16846);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 16478, 16846);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public EmitOptions WithEmitMetadataOnly(bool value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(291, 16858, 17109);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 16934, 17024) || true) && (f_291_16938_16954() == value)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 16934, 17024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 16997, 17009);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(291, 16934, 17024);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 17040, 17098);

                return new EmitOptions(this) { EmitMetadataOnly = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => value, 291, 17047, 17097) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(291, 16858, 17109);

                bool
                f_291_16938_16954()
                {
                    var return_v = EmitMetadataOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 16938, 16954);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 16858, 17109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 16858, 17109);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public EmitOptions WithPdbFilePath(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(291, 17121, 17356);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 17193, 17277) || true) && (f_291_17197_17208() == path)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 17193, 17277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 17250, 17262);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(291, 17193, 17277);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 17293, 17345);

                return new EmitOptions(this) { PdbFilePath = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => path, 291, 17300, 17344) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(291, 17121, 17356);

                string?
                f_291_17197_17208()
                {
                    var return_v = PdbFilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 17197, 17208);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 17121, 17356);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 17121, 17356);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public EmitOptions WithPdbChecksumAlgorithm(HashAlgorithmName name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(291, 17368, 17641);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 17460, 17553) || true) && (f_291_17464_17484() == name)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 17460, 17553);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 17526, 17538);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(291, 17460, 17553);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 17569, 17630);

                return new EmitOptions(this) { PdbChecksumAlgorithm = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => name, 291, 17576, 17629) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(291, 17368, 17641);

                System.Security.Cryptography.HashAlgorithmName
                f_291_17464_17484()
                {
                    var return_v = PdbChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 17464, 17484);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 17368, 17641);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 17368, 17641);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public EmitOptions WithOutputNameOverride(string outputName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(291, 17653, 17927);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 17738, 17835) || true) && (f_291_17742_17760() == outputName)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 17738, 17835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 17808, 17820);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(291, 17738, 17835);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 17851, 17916);

                return new EmitOptions(this) { OutputNameOverride = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => outputName, 291, 17858, 17915) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(291, 17653, 17927);

                string?
                f_291_17742_17760()
                {
                    var return_v = OutputNameOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 17742, 17760);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 17653, 17927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 17653, 17927);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public EmitOptions WithDebugInformationFormat(DebugInformationFormat format)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(291, 17939, 18229);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 18040, 18137) || true) && (f_291_18044_18066() == format)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 18040, 18137);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 18110, 18122);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(291, 18040, 18137);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 18153, 18218);

                return new EmitOptions(this) { DebugInformationFormat = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => format, 291, 18160, 18217) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(291, 17939, 18229);

                Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                f_291_18044_18066()
                {
                    var return_v = DebugInformationFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 18044, 18066);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 17939, 18229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 17939, 18229);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public EmitOptions WithFileAlignment(int value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(291, 18472, 18713);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 18544, 18631) || true) && (f_291_18548_18561() == value)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 18544, 18631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 18604, 18616);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(291, 18544, 18631);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 18647, 18702);

                return new EmitOptions(this) { FileAlignment = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => value, 291, 18654, 18701) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(291, 18472, 18713);

                int
                f_291_18548_18561()
                {
                    var return_v = FileAlignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 18548, 18561);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 18472, 18713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 18472, 18713);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public EmitOptions WithBaseAddress(ulong value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(291, 18725, 18962);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 18797, 18882) || true) && (f_291_18801_18812() == value)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 18797, 18882);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 18855, 18867);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(291, 18797, 18882);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 18898, 18951);

                return new EmitOptions(this) { BaseAddress = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => value, 291, 18905, 18950) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(291, 18725, 18962);

                ulong
                f_291_18801_18812()
                {
                    var return_v = BaseAddress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 18801, 18812);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 18725, 18962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 18725, 18962);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public EmitOptions WithHighEntropyVirtualAddressSpace(bool value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(291, 18974, 19267);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 19064, 19168) || true) && (f_291_19068_19098() == value)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 19064, 19168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 19141, 19153);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(291, 19064, 19168);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 19184, 19256);

                return new EmitOptions(this) { HighEntropyVirtualAddressSpace = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => value, 291, 19191, 19255) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(291, 18974, 19267);

                bool
                f_291_19068_19098()
                {
                    var return_v = HighEntropyVirtualAddressSpace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 19068, 19098);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 18974, 19267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 18974, 19267);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public EmitOptions WithSubsystemVersion(SubsystemVersion subsystemVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(291, 19279, 19580);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 19378, 19484) || true) && (subsystemVersion.Equals(f_291_19406_19422()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 19378, 19484);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 19457, 19469);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(291, 19378, 19484);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 19500, 19569);

                return new EmitOptions(this) { SubsystemVersion = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => subsystemVersion, 291, 19507, 19568) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(291, 19279, 19580);

                Microsoft.CodeAnalysis.SubsystemVersion
                f_291_19406_19422()
                {
                    var return_v = SubsystemVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 19406, 19422);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 19279, 19580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 19279, 19580);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public EmitOptions WithRuntimeMetadataVersion(string version)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(291, 19592, 19869);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 19678, 19776) || true) && (f_291_19682_19704() == version)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 19678, 19776);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 19749, 19761);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(291, 19678, 19776);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 19792, 19858);

                return new EmitOptions(this) { RuntimeMetadataVersion = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => version, 291, 19799, 19857) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(291, 19592, 19869);

                string?
                f_291_19682_19704()
                {
                    var return_v = RuntimeMetadataVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 19682, 19704);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 19592, 19869);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 19592, 19869);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public EmitOptions WithTolerateErrors(bool value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(291, 19881, 20126);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 19955, 20043) || true) && (f_291_19959_19973() == value)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 19955, 20043);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 20016, 20028);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(291, 19955, 20043);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 20059, 20115);

                return new EmitOptions(this) { TolerateErrors = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => value, 291, 20066, 20114) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(291, 19881, 20126);

                bool
                f_291_19959_19973()
                {
                    var return_v = TolerateErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 19959, 19973);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 19881, 20126);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 19881, 20126);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public EmitOptions WithIncludePrivateMembers(bool value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(291, 20138, 20404);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 20219, 20314) || true) && (f_291_20223_20244() == value)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 20219, 20314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 20287, 20299);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(291, 20219, 20314);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 20330, 20393);

                return new EmitOptions(this) { IncludePrivateMembers = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => value, 291, 20337, 20392) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(291, 20138, 20404);

                bool
                f_291_20223_20244()
                {
                    var return_v = IncludePrivateMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 20223, 20244);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 20138, 20404);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 20138, 20404);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public EmitOptions WithInstrumentationKinds(ImmutableArray<InstrumentationKind> instrumentationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(291, 20416, 20755);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 20542, 20651) || true) && (f_291_20546_20566() == instrumentationKinds)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 20542, 20651);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 20624, 20636);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(291, 20542, 20651);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 20667, 20744);

                return new EmitOptions(this) { InstrumentationKinds = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => instrumentationKinds, 291, 20674, 20743) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(291, 20416, 20755);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
                f_291_20546_20566()
                {
                    var return_v = InstrumentationKinds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 20546, 20566);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 20416, 20755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 20416, 20755);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public EmitOptions WithDefaultSourceFileEncoding(Encoding? defaultSourceFileEncoding)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(291, 20767, 21110);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 20877, 20996) || true) && (f_291_20881_20906() == defaultSourceFileEncoding)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 20877, 20996);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 20969, 20981);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(291, 20877, 20996);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 21012, 21099);

                return new EmitOptions(this) { DefaultSourceFileEncoding = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => defaultSourceFileEncoding, 291, 21019, 21098) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(291, 20767, 21110);

                System.Text.Encoding?
                f_291_20881_20906()
                {
                    var return_v = DefaultSourceFileEncoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 20881, 20906);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 20767, 21110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 20767, 21110);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public EmitOptions WithFallbackSourceFileEncoding(Encoding? fallbackSourceFileEncoding)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(291, 21122, 21471);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 21234, 21355) || true) && (f_291_21238_21264() == fallbackSourceFileEncoding)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(291, 21234, 21355);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 21328, 21340);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(291, 21234, 21355);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 21371, 21460);

                return new EmitOptions(this) { FallbackSourceFileEncoding = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => fallbackSourceFileEncoding, 291, 21378, 21459) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(291, 21122, 21471);

                System.Text.Encoding?
                f_291_21238_21264()
                {
                    var return_v = FallbackSourceFileEncoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 21238, 21264);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(291, 21122, 21471);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 21122, 21471);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EmitOptions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(291, 495, 21478);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(291, 606, 774);
            Default = (DynAbs.Tracing.TraceSender.Conditional_F1(291, 616, 645) || ((f_291_616_645() && DynAbs.Tracing.TraceSender.Conditional_F2(291, 661, 678)) || DynAbs.Tracing.TraceSender.Conditional_F3(291, 694, 774))) ? f_291_661_678() : f_291_694_774(f_291_694_711(), DebugInformationFormat.PortablePdb); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(291, 495, 21478);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(291, 495, 21478);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(291, 495, 21478);

        static bool
        f_291_616_645()
        {
            var return_v = PlatformInformation.IsWindows
            ;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 616, 645);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Emit.EmitOptions
        f_291_661_678()
        {
            var return_v = new Microsoft.CodeAnalysis.Emit.EmitOptions();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 661, 678);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Emit.EmitOptions
        f_291_694_711()
        {
            var return_v = new Microsoft.CodeAnalysis.Emit.EmitOptions();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 694, 711);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Emit.EmitOptions
        f_291_694_774(Microsoft.CodeAnalysis.Emit.EmitOptions
        this_param, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
        format)
        {
            var return_v = this_param.WithDebugInformationFormat(format);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(291, 694, 774);
            return return_v;
        }


        static bool
        f_291_5843_5855_C(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(291, 5337, 6350);
            return return_v;
        }


        static bool
        f_291_6991_7003_C(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(291, 6414, 7502);
            return return_v;
        }


        static bool
        f_291_8187_8199_C(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(291, 7566, 8797);
            return return_v;
        }


        static bool
        f_291_10641_10663(Microsoft.CodeAnalysis.Emit.EmitOptions
        this_param)
        {
            var return_v = this_param.EmitMetadataOnly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 10641, 10663);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Emit.DebugInformationFormat
        f_291_10678_10706(Microsoft.CodeAnalysis.Emit.EmitOptions
        this_param)
        {
            var return_v = this_param.DebugInformationFormat;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 10678, 10706);
            return return_v;
        }


        static string?
        f_291_10721_10738(Microsoft.CodeAnalysis.Emit.EmitOptions
        this_param)
        {
            var return_v = this_param.PdbFilePath;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 10721, 10738);
            return return_v;
        }


        static string?
        f_291_10753_10777(Microsoft.CodeAnalysis.Emit.EmitOptions
        this_param)
        {
            var return_v = this_param.OutputNameOverride;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 10753, 10777);
            return return_v;
        }


        static int
        f_291_10792_10811(Microsoft.CodeAnalysis.Emit.EmitOptions
        this_param)
        {
            var return_v = this_param.FileAlignment;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 10792, 10811);
            return return_v;
        }


        static ulong
        f_291_10826_10843(Microsoft.CodeAnalysis.Emit.EmitOptions
        this_param)
        {
            var return_v = this_param.BaseAddress;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 10826, 10843);
            return return_v;
        }


        static bool
        f_291_10858_10894(Microsoft.CodeAnalysis.Emit.EmitOptions
        this_param)
        {
            var return_v = this_param.HighEntropyVirtualAddressSpace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 10858, 10894);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SubsystemVersion
        f_291_10909_10931(Microsoft.CodeAnalysis.Emit.EmitOptions
        this_param)
        {
            var return_v = this_param.SubsystemVersion;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 10909, 10931);
            return return_v;
        }


        static string?
        f_291_10946_10974(Microsoft.CodeAnalysis.Emit.EmitOptions
        this_param)
        {
            var return_v = this_param.RuntimeMetadataVersion;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 10946, 10974);
            return return_v;
        }


        static bool
        f_291_10989_11009(Microsoft.CodeAnalysis.Emit.EmitOptions
        this_param)
        {
            var return_v = this_param.TolerateErrors;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 10989, 11009);
            return return_v;
        }


        static bool
        f_291_11024_11051(Microsoft.CodeAnalysis.Emit.EmitOptions
        this_param)
        {
            var return_v = this_param.IncludePrivateMembers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 11024, 11051);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
        f_291_11066_11092(Microsoft.CodeAnalysis.Emit.EmitOptions
        this_param)
        {
            var return_v = this_param.InstrumentationKinds;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 11066, 11092);
            return return_v;
        }


        static System.Security.Cryptography.HashAlgorithmName
        f_291_11107_11133(Microsoft.CodeAnalysis.Emit.EmitOptions
        this_param)
        {
            var return_v = this_param.PdbChecksumAlgorithm;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 11107, 11133);
            return return_v;
        }


        static System.Text.Encoding?
        f_291_11148_11179(Microsoft.CodeAnalysis.Emit.EmitOptions
        this_param)
        {
            var return_v = this_param.DefaultSourceFileEncoding;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 11148, 11179);
            return return_v;
        }


        static System.Text.Encoding?
        f_291_11194_11226(Microsoft.CodeAnalysis.Emit.EmitOptions
        this_param)
        {
            var return_v = this_param.FallbackSourceFileEncoding;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 11194, 11226);
            return return_v;
        }


        static bool
        f_291_10641_10663_C(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(291, 10581, 11249);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
        f_291_16402_16422()
        {
            var return_v = InstrumentationKinds;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(291, 16402, 16422);
            return return_v;
        }

    }
}
