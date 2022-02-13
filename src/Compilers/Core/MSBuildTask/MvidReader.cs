// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace Microsoft.CodeAnalysis.BuildTasks
{
    public static class MvidReader
    {
        private static readonly Guid s_empty;

        public static Guid ReadAssemblyMvidOrEmpty(Stream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23128, 444, 594);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 526, 583);

                return f_23128_533_582(f_23128_557_581(stream));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23128, 444, 594);

                System.IO.BinaryReader
                f_23128_557_581(System.IO.Stream
                input)
                {
                    var return_v = new System.IO.BinaryReader(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 557, 581);
                    return return_v;
                }


                System.Guid
                f_23128_533_582(System.IO.BinaryReader
                reader)
                {
                    var return_v = ReadAssemblyMvidOrEmpty(reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 533, 582);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23128, 444, 594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23128, 444, 594);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Guid ReadAssemblyMvidOrEmpty(BinaryReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23128, 606, 2654);
                ushort magicNumber = default(ushort);
                uint pointerToPeSignature = default(uint);
                uint peSig = default(uint);
                ushort sections = default(ushort);
                ushort optionalHeaderSize = default(ushort);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 740, 884) || true) && (!f_23128_745_787(reader, out magicNumber) || (DynAbs.Tracing.TraceSender.Expression_False(23128, 744, 812) || magicNumber != 0x5a4d))
                ) // "MZ"

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23128, 740, 884);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 854, 869);

                    return s_empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23128, 740, 884);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 962, 1051) || true) && (!f_23128_967_987(0x3C, reader))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23128, 962, 1051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 1021, 1036);

                    return s_empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23128, 962, 1051);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 1065, 1183) || true) && (!f_23128_1070_1119(reader, out pointerToPeSignature))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23128, 1065, 1183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 1153, 1168);

                    return s_empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23128, 1065, 1183);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 1261, 1366) || true) && (!f_23128_1266_1302(pointerToPeSignature, reader))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23128, 1261, 1366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 1336, 1351);

                    return s_empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23128, 1261, 1366);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 1431, 1557) || true) && (!f_23128_1436_1470(reader, out peSig) || (DynAbs.Tracing.TraceSender.Expression_False(23128, 1435, 1493) || peSig != 0x00004550))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23128, 1431, 1557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 1527, 1542);

                    return s_empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23128, 1431, 1557);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 1614, 1698) || true) && (!f_23128_1619_1634(2, reader))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23128, 1614, 1698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 1668, 1683);

                    return s_empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23128, 1614, 1698);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 1764, 1872) || true) && (!f_23128_1769_1808(reader, out sections))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23128, 1764, 1872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 1842, 1857);

                    return s_empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23128, 1764, 1872);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 1982, 2067) || true) && (!f_23128_1987_2003(12, reader))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23128, 1982, 2067);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 2037, 2052);

                    return s_empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23128, 1982, 2067);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 2135, 2253) || true) && (!f_23128_2140_2189(reader, out optionalHeaderSize))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23128, 2135, 2253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 2223, 2238);

                    return s_empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23128, 2135, 2253);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 2318, 2402) || true) && (!f_23128_2323_2338(2, reader))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23128, 2318, 2402);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 2372, 2387);

                    return s_empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23128, 2318, 2402);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 2450, 2551) || true) && (!f_23128_2455_2487(optionalHeaderSize, reader))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23128, 2450, 2551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 2521, 2536);

                    return s_empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23128, 2450, 2551);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 2599, 2643);

                return f_23128_2606_2642(sections, reader);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23128, 606, 2654);

                bool
                f_23128_745_787(System.IO.BinaryReader
                reader, out ushort
                output)
                {
                    var return_v = ReadUInt16(reader, out output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 745, 787);
                    return return_v;
                }


                bool
                f_23128_967_987(int
                position, System.IO.BinaryReader
                reader)
                {
                    var return_v = MoveTo((uint)position, reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 967, 987);
                    return return_v;
                }


                bool
                f_23128_1070_1119(System.IO.BinaryReader
                reader, out uint
                output)
                {
                    var return_v = ReadUInt32(reader, out output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 1070, 1119);
                    return return_v;
                }


                bool
                f_23128_1266_1302(uint
                position, System.IO.BinaryReader
                reader)
                {
                    var return_v = MoveTo(position, reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 1266, 1302);
                    return return_v;
                }


                bool
                f_23128_1436_1470(System.IO.BinaryReader
                reader, out uint
                output)
                {
                    var return_v = ReadUInt32(reader, out output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 1436, 1470);
                    return return_v;
                }


                bool
                f_23128_1619_1634(int
                bytes, System.IO.BinaryReader
                reader)
                {
                    var return_v = Skip(bytes, reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 1619, 1634);
                    return return_v;
                }


                bool
                f_23128_1769_1808(System.IO.BinaryReader
                reader, out ushort
                output)
                {
                    var return_v = ReadUInt16(reader, out output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 1769, 1808);
                    return return_v;
                }


                bool
                f_23128_1987_2003(int
                bytes, System.IO.BinaryReader
                reader)
                {
                    var return_v = Skip(bytes, reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 1987, 2003);
                    return return_v;
                }


                bool
                f_23128_2140_2189(System.IO.BinaryReader
                reader, out ushort
                output)
                {
                    var return_v = ReadUInt16(reader, out output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 2140, 2189);
                    return return_v;
                }


                bool
                f_23128_2323_2338(int
                bytes, System.IO.BinaryReader
                reader)
                {
                    var return_v = Skip(bytes, reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 2323, 2338);
                    return return_v;
                }


                bool
                f_23128_2455_2487(ushort
                bytes, System.IO.BinaryReader
                reader)
                {
                    var return_v = Skip((int)bytes, reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 2455, 2487);
                    return return_v;
                }


                System.Guid
                f_23128_2606_2642(ushort
                count, System.IO.BinaryReader
                reader)
                {
                    var return_v = FindMvidInSections(count, reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 2606, 2642);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23128, 606, 2654);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23128, 606, 2654);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Guid FindMvidInSections(ushort count, BinaryReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23128, 2666, 4537);
                byte[]? name = default(byte[]?);
                uint virtualSize = default(uint);
                uint pointerToRawData = default(uint);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 2773, 2778);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 2764, 4495) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 2791, 2794)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(23128, 2764, 4495))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(23128, 2764, 4495);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 2866, 2985) || true) && (!f_23128_2871_2909(reader, 8, out name))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(23128, 2866, 2985);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 2951, 2966);

                            return s_empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(23128, 2866, 2985);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 3005, 4480) || true) && (f_23128_3009_3021(name!) == 8 && (DynAbs.Tracing.TraceSender.Expression_True(23128, 3009, 3044) && name[0] == '.') && (DynAbs.Tracing.TraceSender.Expression_True(23128, 3009, 3083) && name[1] == 'm') && (DynAbs.Tracing.TraceSender.Expression_True(23128, 3009, 3101) && name[2] == 'v') && (DynAbs.Tracing.TraceSender.Expression_True(23128, 3009, 3119) && name[3] == 'i') && (DynAbs.Tracing.TraceSender.Expression_True(23128, 3009, 3137) && name[4] == 'd') && (DynAbs.Tracing.TraceSender.Expression_True(23128, 3009, 3156) && name[5] == '\0'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(23128, 3005, 4480);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 3247, 3466) || true) && (!f_23128_3252_3292(reader, out virtualSize) || (DynAbs.Tracing.TraceSender.Expression_False(23128, 3251, 3313) || virtualSize != 16))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(23128, 3247, 3466);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 3428, 3443);

                                return s_empty;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(23128, 3247, 3466);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 3561, 3669) || true) && (!f_23128_3566_3581(8, reader))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(23128, 3561, 3669);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 3631, 3646);

                                return s_empty;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(23128, 3561, 3669);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 3747, 3885) || true) && (!f_23128_3752_3797(reader, out pointerToRawData))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(23128, 3747, 3885);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 3847, 3862);

                                return s_empty;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(23128, 3747, 3885);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 3909, 3958);

                            return f_23128_3916_3957(reader, pointerToRawData);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(23128, 3005, 4480);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(23128, 3005, 4480);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 4321, 4461) || true) && (!f_23128_4326_4373(4 + 4 + 4 + 4 + 4 + 4 + 2 + 2 + 4, reader))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(23128, 4321, 4461);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 4423, 4438);

                                return s_empty;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(23128, 4321, 4461);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(23128, 3005, 4480);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(23128, 1, 1732);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(23128, 1, 1732);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 4511, 4526);

                return s_empty;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23128, 2666, 4537);

                bool
                f_23128_2871_2909(System.IO.BinaryReader
                reader, int
                count, out byte[]?
                output)
                {
                    var return_v = ReadBytes(reader, count, out output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 2871, 2909);
                    return return_v;
                }


                int
                f_23128_3009_3021(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23128, 3009, 3021);
                    return return_v;
                }


                bool
                f_23128_3252_3292(System.IO.BinaryReader
                reader, out uint
                output)
                {
                    var return_v = ReadUInt32(reader, out output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 3252, 3292);
                    return return_v;
                }


                bool
                f_23128_3566_3581(int
                bytes, System.IO.BinaryReader
                reader)
                {
                    var return_v = Skip(bytes, reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 3566, 3581);
                    return return_v;
                }


                bool
                f_23128_3752_3797(System.IO.BinaryReader
                reader, out uint
                output)
                {
                    var return_v = ReadUInt32(reader, out output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 3752, 3797);
                    return return_v;
                }


                System.Guid
                f_23128_3916_3957(System.IO.BinaryReader
                reader, uint
                pointerToMvidSection)
                {
                    var return_v = ReadMvidSection(reader, pointerToMvidSection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 3916, 3957);
                    return return_v;
                }


                bool
                f_23128_4326_4373(int
                bytes, System.IO.BinaryReader
                reader)
                {
                    var return_v = Skip(bytes, reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 4326, 4373);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23128, 2666, 4537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23128, 2666, 4537);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Guid ReadMvidSection(BinaryReader reader, uint pointerToMvidSection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23128, 4549, 4946);
                byte[]? guidBytes = default(byte[]?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 4657, 4762) || true) && (!f_23128_4662_4698(pointerToMvidSection, reader))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23128, 4657, 4762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 4732, 4747);

                    return s_empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23128, 4657, 4762);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 4778, 4891) || true) && (!f_23128_4783_4827(reader, 16, out guidBytes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23128, 4778, 4891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 4861, 4876);

                    return s_empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23128, 4778, 4891);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 4907, 4935);

                return f_23128_4914_4934(guidBytes!);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23128, 4549, 4946);

                bool
                f_23128_4662_4698(uint
                position, System.IO.BinaryReader
                reader)
                {
                    var return_v = MoveTo(position, reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 4662, 4698);
                    return return_v;
                }


                bool
                f_23128_4783_4827(System.IO.BinaryReader
                reader, int
                count, out byte[]?
                output)
                {
                    var return_v = ReadBytes(reader, count, out output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 4783, 4827);
                    return return_v;
                }


                System.Guid
                f_23128_4914_4934(byte[]
                b)
                {
                    var return_v = new System.Guid(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 4914, 4934);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23128, 4549, 4946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23128, 4549, 4946);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ReadUInt16(BinaryReader reader, out ushort output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23128, 4958, 5288);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 5053, 5206) || true) && (f_23128_5057_5083(f_23128_5057_5074(reader)) + 2 >= f_23128_5091_5115(f_23128_5091_5108(reader)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23128, 5053, 5206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 5149, 5160);

                    output = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 5178, 5191);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23128, 5053, 5206);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 5222, 5251);

                output = f_23128_5231_5250(reader);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 5265, 5277);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23128, 4958, 5288);

                System.IO.Stream
                f_23128_5057_5074(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.BaseStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23128, 5057, 5074);
                    return return_v;
                }


                long
                f_23128_5057_5083(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23128, 5057, 5083);
                    return return_v;
                }


                System.IO.Stream
                f_23128_5091_5108(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.BaseStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23128, 5091, 5108);
                    return return_v;
                }


                long
                f_23128_5091_5115(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23128, 5091, 5115);
                    return return_v;
                }


                ushort
                f_23128_5231_5250(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 5231, 5250);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23128, 4958, 5288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23128, 4958, 5288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ReadUInt32(BinaryReader reader, out uint output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23128, 5300, 5628);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 5393, 5546) || true) && (f_23128_5397_5423(f_23128_5397_5414(reader)) + 4 >= f_23128_5431_5455(f_23128_5431_5448(reader)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23128, 5393, 5546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 5489, 5500);

                    output = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 5518, 5531);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23128, 5393, 5546);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 5562, 5591);

                output = f_23128_5571_5590(reader);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 5605, 5617);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23128, 5300, 5628);

                System.IO.Stream
                f_23128_5397_5414(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.BaseStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23128, 5397, 5414);
                    return return_v;
                }


                long
                f_23128_5397_5423(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23128, 5397, 5423);
                    return return_v;
                }


                System.IO.Stream
                f_23128_5431_5448(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.BaseStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23128, 5431, 5448);
                    return return_v;
                }


                long
                f_23128_5431_5455(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23128, 5431, 5455);
                    return return_v;
                }


                uint
                f_23128_5571_5590(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 5571, 5590);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23128, 5300, 5628);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23128, 5300, 5628);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ReadBytes(BinaryReader reader, int count, out byte[]? output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23128, 5640, 5992);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 5746, 5906) || true) && (f_23128_5750_5776(f_23128_5750_5767(reader)) + count >= f_23128_5788_5812(f_23128_5788_5805(reader)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23128, 5746, 5906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 5846, 5860);

                    output = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 5878, 5891);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23128, 5746, 5906);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 5922, 5955);

                output = f_23128_5931_5954(reader, count);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 5969, 5981);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23128, 5640, 5992);

                System.IO.Stream
                f_23128_5750_5767(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.BaseStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23128, 5750, 5767);
                    return return_v;
                }


                long
                f_23128_5750_5776(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23128, 5750, 5776);
                    return return_v;
                }


                System.IO.Stream
                f_23128_5788_5805(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.BaseStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23128, 5788, 5805);
                    return return_v;
                }


                long
                f_23128_5788_5812(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23128, 5788, 5812);
                    return return_v;
                }


                byte[]
                f_23128_5931_5954(System.IO.BinaryReader
                this_param, int
                count)
                {
                    var return_v = this_param.ReadBytes(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 5931, 5954);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23128, 5640, 5992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23128, 5640, 5992);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool Skip(int bytes, BinaryReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23128, 6004, 6316);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 6085, 6213) || true) && (f_23128_6089_6115(f_23128_6089_6106(reader)) + bytes >= f_23128_6127_6151(f_23128_6127_6144(reader)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23128, 6085, 6213);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 6185, 6198);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23128, 6085, 6213);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 6229, 6279);

                f_23128_6229_6278(f_23128_6229_6246(reader), bytes, SeekOrigin.Current);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 6293, 6305);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23128, 6004, 6316);

                System.IO.Stream
                f_23128_6089_6106(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.BaseStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23128, 6089, 6106);
                    return return_v;
                }


                long
                f_23128_6089_6115(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23128, 6089, 6115);
                    return return_v;
                }


                System.IO.Stream
                f_23128_6127_6144(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.BaseStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23128, 6127, 6144);
                    return return_v;
                }


                long
                f_23128_6127_6151(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23128, 6127, 6151);
                    return return_v;
                }


                System.IO.Stream
                f_23128_6229_6246(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.BaseStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23128, 6229, 6246);
                    return return_v;
                }


                long
                f_23128_6229_6278(System.IO.Stream
                this_param, int
                offset, System.IO.SeekOrigin
                origin)
                {
                    var return_v = this_param.Seek((long)offset, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 6229, 6278);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23128, 6004, 6316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23128, 6004, 6316);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool MoveTo(uint position, BinaryReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23128, 6328, 6621);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 6415, 6517) || true) && (position >= f_23128_6431_6455(f_23128_6431_6448(reader)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23128, 6415, 6517);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 6489, 6502);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23128, 6415, 6517);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 6533, 6584);

                f_23128_6533_6583(f_23128_6533_6550(reader), position, SeekOrigin.Begin);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 6598, 6610);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23128, 6328, 6621);

                System.IO.Stream
                f_23128_6431_6448(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.BaseStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23128, 6431, 6448);
                    return return_v;
                }


                long
                f_23128_6431_6455(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23128, 6431, 6455);
                    return return_v;
                }


                System.IO.Stream
                f_23128_6533_6550(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.BaseStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23128, 6533, 6550);
                    return return_v;
                }


                long
                f_23128_6533_6583(System.IO.Stream
                this_param, uint
                offset, System.IO.SeekOrigin
                origin)
                {
                    var return_v = this_param.Seek((long)offset, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23128, 6533, 6583);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23128, 6328, 6621);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23128, 6328, 6621);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MvidReader()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23128, 335, 6628);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(23128, 411, 431);
            s_empty = Guid.Empty; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23128, 335, 6628);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23128, 335, 6628);
        }

    }
}
