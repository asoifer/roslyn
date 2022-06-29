// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Reflection.PortableExecutable;

namespace Microsoft.Cci
{
    internal sealed class ModulePropertiesForSerialization
    {
        public readonly int FileAlignment;

        public readonly int SectionAlignment;

        public readonly string TargetRuntimeVersion;

        public readonly Machine Machine;

        public readonly Guid PersistentIdentifier;

        public readonly ulong BaseAddress;

        public readonly ulong SizeOfHeapReserve;

        public readonly ulong SizeOfHeapCommit;

        public readonly ulong SizeOfStackReserve;

        public readonly ulong SizeOfStackCommit;

        public readonly ushort MajorSubsystemVersion;

        public readonly ushort MinorSubsystemVersion;

        public readonly byte LinkerMajorVersion;

        public readonly byte LinkerMinorVersion;

        public DllCharacteristics DllCharacteristics { get; }

        public Characteristics ImageCharacteristics { get; }

        public Subsystem Subsystem { get; }

        public CorFlags CorFlags { get; }

        public const ulong
        DefaultExeBaseAddress32Bit = 0x00400000
        ;

        public const ulong
        DefaultExeBaseAddress64Bit = 0x0000000140000000
        ;

        public const ulong
        DefaultDllBaseAddress32Bit = 0x10000000
        ;

        public const ulong
        DefaultDllBaseAddress64Bit = 0x0000000180000000
        ;

        public const ulong
        DefaultSizeOfHeapReserve32Bit = 0x00100000
        ;

        public const ulong
        DefaultSizeOfHeapReserve64Bit = 0x00400000
        ;

        public const ulong
        DefaultSizeOfHeapCommit32Bit = 0x1000
        ;

        public const ulong
        DefaultSizeOfHeapCommit64Bit = 0x2000
        ;

        public const ulong
        DefaultSizeOfStackReserve32Bit = 0x00100000
        ;

        public const ulong
        DefaultSizeOfStackReserve64Bit = 0x00400000
        ;

        public const ulong
        DefaultSizeOfStackCommit32Bit = 0x1000
        ;

        public const ulong
        DefaultSizeOfStackCommit64Bit = 0x4000
        ;

        public const ushort
        DefaultFileAlignment32Bit = 0x200
        ;

        public const ushort
        DefaultFileAlignment64Bit = 0x200
        ;

        public const ushort
        DefaultSectionAlignment = 0x2000
        ;

        internal ModulePropertiesForSerialization(
                    Guid persistentIdentifier,
                    CorFlags corFlags,
                    int fileAlignment,
                    int sectionAlignment,
                    string targetRuntimeVersion,
                    Machine machine,
                    ulong baseAddress,
                    ulong sizeOfHeapReserve,
                    ulong sizeOfHeapCommit,
                    ulong sizeOfStackReserve,
                    ulong sizeOfStackCommit,
                    DllCharacteristics dllCharacteristics,
                    Characteristics imageCharacteristics,
                    Subsystem subsystem,
                    ushort majorSubsystemVersion,
                    ushort minorSubsystemVersion,
                    byte linkerMajorVersion,
                    byte linkerMinorVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(295, 4867, 6617);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 802, 815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 1123, 1139);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 1319, 1339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 1506, 1513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 1856, 1867);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 2103, 2120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 2365, 2381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 2619, 2637);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 2672, 2689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 2723, 2744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 2778, 2799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 3028, 3046);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 3275, 3293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 3520, 3573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 3585, 3637);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 3649, 3684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 3696, 3729);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 5628, 5677);

                this.PersistentIdentifier = persistentIdentifier;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 5691, 5726);

                this.FileAlignment = fileAlignment;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 5740, 5781);

                this.SectionAlignment = sectionAlignment;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 5795, 5844);

                this.TargetRuntimeVersion = targetRuntimeVersion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 5858, 5881);

                this.Machine = machine;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 5895, 5926);

                this.BaseAddress = baseAddress;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 5940, 5983);

                this.SizeOfHeapReserve = sizeOfHeapReserve;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 5997, 6038);

                this.SizeOfHeapCommit = sizeOfHeapCommit;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 6052, 6097);

                this.SizeOfStackReserve = sizeOfStackReserve;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 6111, 6154);

                this.SizeOfStackCommit = sizeOfStackCommit;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 6168, 6213);

                this.LinkerMajorVersion = linkerMajorVersion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 6227, 6272);

                this.LinkerMinorVersion = linkerMinorVersion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 6286, 6337);

                this.MajorSubsystemVersion = majorSubsystemVersion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 6351, 6402);

                this.MinorSubsystemVersion = minorSubsystemVersion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 6416, 6465);

                this.ImageCharacteristics = imageCharacteristics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 6479, 6506);

                this.Subsystem = subsystem;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 6522, 6567);

                this.DllCharacteristics = dllCharacteristics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 6581, 6606);

                this.CorFlags = corFlags;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(295, 4867, 6617);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(295, 4867, 6617);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(295, 4867, 6617);
            }
        }

        static ModulePropertiesForSerialization()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(295, 454, 6624);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 3760, 3799);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 3829, 3876);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 3908, 3947);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 3977, 4024);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 4056, 4098);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 4128, 4170);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 4202, 4239);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 4269, 4306);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 4338, 4381);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 4411, 4454);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 4486, 4524);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 4554, 4592);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 4625, 4658);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 4689, 4722);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(295, 4822, 4854);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(295, 454, 6624);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(295, 454, 6624);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(295, 454, 6624);
    }
}
