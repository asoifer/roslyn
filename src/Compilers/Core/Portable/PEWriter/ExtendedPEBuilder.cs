// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis;

namespace Microsoft.Cci
{
    internal sealed class ExtendedPEBuilder
            : ManagedPEBuilder
    {
        private const string
        MvidSectionName = ".mvid"
        ;

        public const int
        SizeOfGuid = 16
        ;

        private Blob _mvidSectionFixup;

        private readonly bool _withMvidSection;

        public ExtendedPEBuilder(
                    PEHeaderBuilder header,
                    MetadataRootBuilder metadataRootBuilder,
                    BlobBuilder ilStream,
                    BlobBuilder mappedFieldData,
                    BlobBuilder managedResources,
                    ResourceSectionBuilder nativeResources,
                    DebugDirectoryBuilder debugDirectoryBuilder,
                    int strongNameSignatureSize,
                    MethodDefinitionHandle entryPoint,
                    CorFlags flags,
                    Func<IEnumerable<Blob>, BlobContentId> deterministicIdProvider,
                    bool withMvidSection)
        : base(f_486_1706_1712_C(header), metadataRootBuilder, ilStream, mappedFieldData, managedResources, nativeResources, debugDirectoryBuilder, strongNameSignatureSize, entryPoint, flags, deterministicIdProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(486, 1107, 1978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(486, 949, 982);
                this._mvidSectionFixup = default(Blob); DynAbs.Tracing.TraceSender.TraceSimpleStatement(486, 1078, 1094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(486, 1932, 1967);

                _withMvidSection = withMvidSection;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(486, 1107, 1978);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(486, 1107, 1978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(486, 1107, 1978);
            }
        }

        protected override ImmutableArray<Section> CreateSections()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(486, 1990, 2700);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(486, 2074, 2115);

                var
                baseSections = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.CreateSections(), 486, 2093, 2114)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(486, 2131, 2689) || true) && (_withMvidSection)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(486, 2131, 2689);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(486, 2185, 2258);

                    var
                    builder = f_486_2199_2257(baseSections.Length + 1)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(486, 2278, 2483);

                    f_486_2278_2482(
                                    builder, f_486_2290_2481(MvidSectionName, SectionCharacteristics.MemRead |
                                        SectionCharacteristics.ContainsInitializedData |
                                        SectionCharacteristics.MemDiscardable));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(486, 2503, 2534);

                    f_486_2503_2533(
                                    builder, baseSections);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(486, 2552, 2588);

                    return f_486_2559_2587(builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(486, 2131, 2689);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(486, 2131, 2689);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(486, 2654, 2674);

                    return baseSections;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(486, 2131, 2689);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(486, 1990, 2700);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.PortableExecutable.PEBuilder.Section>
                f_486_2199_2257(int
                capacity)
                {
                    var return_v = ArrayBuilder<Section>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(486, 2199, 2257);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEBuilder.Section
                f_486_2290_2481(string
                name, System.Reflection.PortableExecutable.SectionCharacteristics
                characteristics)
                {
                    var return_v = new System.Reflection.PortableExecutable.PEBuilder.Section(name, characteristics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(486, 2290, 2481);
                    return return_v;
                }


                int
                f_486_2278_2482(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.PortableExecutable.PEBuilder.Section>
                this_param, System.Reflection.PortableExecutable.PEBuilder.Section
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(486, 2278, 2482);
                    return 0;
                }


                int
                f_486_2503_2533(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.PortableExecutable.PEBuilder.Section>
                this_param, System.Collections.Immutable.ImmutableArray<System.Reflection.PortableExecutable.PEBuilder.Section>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(486, 2503, 2533);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<System.Reflection.PortableExecutable.PEBuilder.Section>
                f_486_2559_2587(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.PortableExecutable.PEBuilder.Section>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(486, 2559, 2587);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(486, 1990, 2700);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(486, 1990, 2700);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override BlobBuilder SerializeSection(string name, SectionLocation location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(486, 2712, 3089);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(486, 2823, 3017) || true) && (f_486_2827_2881(name, MvidSectionName, StringComparison.Ordinal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(486, 2823, 3017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(486, 2915, 2946);

                    f_486_2915_2945(_withMvidSection);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(486, 2964, 3002);

                    return f_486_2971_3001(this, location);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(486, 2823, 3017);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(486, 3033, 3078);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SerializeSection(name, location), 486, 3040, 3077);
                DynAbs.Tracing.TraceSender.TraceExitMethod(486, 2712, 3089);

                bool
                f_486_2827_2881(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(486, 2827, 2881);
                    return return_v;
                }


                int
                f_486_2915_2945(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(486, 2915, 2945);
                    return 0;
                }


                System.Reflection.Metadata.BlobBuilder
                f_486_2971_3001(Microsoft.Cci.ExtendedPEBuilder
                this_param, System.Reflection.PortableExecutable.SectionLocation
                location)
                {
                    var return_v = this_param.SerializeMvidSection(location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(486, 2971, 3001);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(486, 2712, 3089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(486, 2712, 3089);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BlobContentId Serialize(BlobBuilder peBlob, out Blob mvidSectionFixup)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(486, 3101, 3331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(486, 3205, 3241);

                var
                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Serialize(peBlob), 486, 3218, 3240)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(486, 3255, 3292);

                mvidSectionFixup = _mvidSectionFixup;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(486, 3306, 3320);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(486, 3101, 3331);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(486, 3101, 3331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(486, 3101, 3331);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BlobBuilder SerializeMvidSection(SectionLocation location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(486, 3343, 3837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(486, 3434, 3473);

                var
                sectionBuilder = f_486_3455_3472()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(486, 3539, 3599);

                _mvidSectionFixup = f_486_3559_3598(sectionBuilder, SizeOfGuid);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(486, 3613, 3664);

                var
                mvidWriter = f_486_3630_3663(_mvidSectionFixup)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(486, 3678, 3729);

                mvidWriter.WriteBytes(0, _mvidSectionFixup.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(486, 3743, 3788);

                f_486_3743_3787(mvidWriter.RemainingBytes == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(486, 3804, 3826);

                return sectionBuilder;
                DynAbs.Tracing.TraceSender.TraceExitMethod(486, 3343, 3837);

                System.Reflection.Metadata.BlobBuilder
                f_486_3455_3472()
                {
                    var return_v = new System.Reflection.Metadata.BlobBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(486, 3455, 3472);
                    return return_v;
                }


                System.Reflection.Metadata.Blob
                f_486_3559_3598(System.Reflection.Metadata.BlobBuilder
                this_param, int
                byteCount)
                {
                    var return_v = this_param.ReserveBytes(byteCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(486, 3559, 3598);
                    return return_v;
                }


                System.Reflection.Metadata.BlobWriter
                f_486_3630_3663(System.Reflection.Metadata.Blob
                blob)
                {
                    var return_v = new System.Reflection.Metadata.BlobWriter(blob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(486, 3630, 3663);
                    return return_v;
                }


                int
                f_486_3743_3787(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(486, 3743, 3787);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(486, 3343, 3837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(486, 3343, 3837);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ExtendedPEBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(486, 641, 3844);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(486, 746, 771);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(486, 799, 814);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(486, 641, 3844);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(486, 641, 3844);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(486, 641, 3844);

        static System.Reflection.PortableExecutable.PEHeaderBuilder
        f_486_1706_1712_C(System.Reflection.PortableExecutable.PEHeaderBuilder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(486, 1107, 1978);
            return return_v;
        }

    }
}
