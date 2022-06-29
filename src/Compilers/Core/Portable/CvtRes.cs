// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis.Text;
using System.Diagnostics;
using BYTE = System.Byte;
using DWORD = System.UInt32;
using WCHAR = System.Char;
using WORD = System.UInt16;
using System.Reflection.PortableExecutable;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal class RESOURCE
    {
        internal RESOURCE_STRING? pstringType;

        internal RESOURCE_STRING? pstringName;

        internal DWORD DataSize;

        internal DWORD HeaderSize;

        internal DWORD DataVersion;

        internal WORD MemoryFlags;

        internal WORD LanguageId;

        internal DWORD Version;

        internal DWORD Characteristics;

        internal byte[]? data;

        public RESOURCE()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(11, 606, 1347);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 672, 683);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 720, 731);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 759, 767);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 838, 848);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 972, 983);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 1037, 1048);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 1101, 1111);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 1168, 1175);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 1240, 1255);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 1321, 1325);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(11, 606, 1347);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 606, 1347);
        }


        static RESOURCE()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(11, 606, 1347);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(11, 606, 1347);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 606, 1347);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(11, 606, 1347);
    }
    ; internal class RESOURCE_STRING
    {
        internal WORD Ordinal;

        internal string? theString;

        public RESOURCE_STRING()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(11, 1355, 1469);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 1416, 1423);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 1451, 1460);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(11, 1355, 1469);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 1355, 1469);
        }


        static RESOURCE_STRING()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(11, 1355, 1469);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(11, 1355, 1469);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 1355, 1469);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(11, 1355, 1469);
    }
     ; internal class CvtResFile
    {
        private const WORD
        RT_DLGINCLUDE = 17
        ;

        internal static List<RESOURCE> ReadResFile(Stream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(11, 1720, 4486);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 1802, 1858);

                var
                reader = f_11_1815_1857(stream, f_11_1840_1856())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 1872, 1913);

                var
                resourceNames = f_11_1892_1912()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 1929, 1960);

                var
                startPos = f_11_1944_1959(stream)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 1976, 2016);

                var
                initial32Bits = f_11_1996_2015(reader)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 2107, 2249) || true) && (initial32Bits != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 2107, 2249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 2148, 2249);

                    throw f_11_2154_2248("Stream does not begin with a null resource and is not in .RES format.");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(11, 2107, 2249);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 2265, 2292);

                stream.Position = startPos;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 2361, 4438) || true) && (f_11_2368_2383(stream) < f_11_2386_2399(stream))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 2361, 4438);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 2483, 2516);

                        var
                        cbData = f_11_2496_2515(reader)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 2534, 2566);

                        var
                        cbHdr = f_11_2546_2565(reader)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 2586, 2865) || true) && (cbHdr < 2 * sizeof(DWORD))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 2586, 2865);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 2657, 2782);

                            throw f_11_2663_2781(f_11_2685_2780("Resource header beginning at offset 0x{0:x} is malformed.", f_11_2760_2775(stream) - 8));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(11, 2586, 2865);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 2929, 3081) || true) && (cbData == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 2929, 3081);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 2986, 3031);

                            stream.Position += DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => cbHdr - 2 * sizeof(DWORD), 11, 2986, 3001);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 3053, 3062);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(11, 2929, 3081);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 3101, 3252);

                        var
                        pAdditional = new RESOURCE()
                        {
                            HeaderSize = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => cbHdr, 11, 3119, 3251),
                            DataSize = cbData
                        }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 3317, 3366);

                        pAdditional.pstringType = f_11_3343_3365(reader);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 3384, 3433);

                        pAdditional.pstringName = f_11_3410_3432(reader);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 3500, 3545);

                        stream.Position = (f_11_3519_3534(stream) + 3) & ~3;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 3613, 3659);

                        pAdditional.DataVersion = f_11_3639_3658(reader);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 3677, 3723);

                        pAdditional.MemoryFlags = f_11_3703_3722(reader);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 3741, 3786);

                        pAdditional.LanguageId = f_11_3766_3785(reader);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 3804, 3846);

                        pAdditional.Version = f_11_3826_3845(reader);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 3864, 3914);

                        pAdditional.Characteristics = f_11_3894_3913(reader);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 3934, 3984);

                        pAdditional.data = new byte[pAdditional.DataSize];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 4002, 4060);

                        f_11_4002_4059(reader, pAdditional.data, 0, f_11_4035_4058(pAdditional.data));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 4080, 4125);

                        stream.Position = (f_11_4099_4114(stream) + 3) & ~3;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 4145, 4372) || true) && (pAdditional.pstringType.theString == null && (DynAbs.Tracing.TraceSender.Expression_True(11, 4149, 4250) && (pAdditional.pstringType.Ordinal == (WORD)RT_DLGINCLUDE)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 4145, 4372);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 4344, 4353);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(11, 4145, 4372);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 4392, 4423);

                        f_11_4392_4422(
                                        resourceNames, pAdditional);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(11, 2361, 4438);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(11, 2361, 4438);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(11, 2361, 4438);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 4454, 4475);

                return resourceNames;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(11, 1720, 4486);

                System.Text.Encoding
                f_11_1840_1856()
                {
                    var return_v = Encoding.Unicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 1840, 1856);
                    return return_v;
                }


                System.IO.BinaryReader
                f_11_1815_1857(System.IO.Stream
                input, System.Text.Encoding
                encoding)
                {
                    var return_v = new System.IO.BinaryReader(input, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 1815, 1857);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.RESOURCE>
                f_11_1892_1912()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.RESOURCE>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 1892, 1912);
                    return return_v;
                }


                long
                f_11_1944_1959(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 1944, 1959);
                    return return_v;
                }


                uint
                f_11_1996_2015(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 1996, 2015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ResourceException
                f_11_2154_2248(string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.ResourceException(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 2154, 2248);
                    return return_v;
                }


                long
                f_11_2368_2383(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 2368, 2383);
                    return return_v;
                }


                long
                f_11_2386_2399(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 2386, 2399);
                    return return_v;
                }


                uint
                f_11_2496_2515(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 2496, 2515);
                    return return_v;
                }


                uint
                f_11_2546_2565(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 2546, 2565);
                    return return_v;
                }


                long
                f_11_2760_2775(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 2760, 2775);
                    return return_v;
                }


                string
                f_11_2685_2780(string
                format, long
                arg0)
                {
                    var return_v = String.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 2685, 2780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ResourceException
                f_11_2663_2781(string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.ResourceException(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 2663, 2781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RESOURCE_STRING
                f_11_3343_3365(System.IO.BinaryReader
                fhIn)
                {
                    var return_v = ReadStringOrID(fhIn);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 3343, 3365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RESOURCE_STRING
                f_11_3410_3432(System.IO.BinaryReader
                fhIn)
                {
                    var return_v = ReadStringOrID(fhIn);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 3410, 3432);
                    return return_v;
                }


                long
                f_11_3519_3534(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 3519, 3534);
                    return return_v;
                }


                uint
                f_11_3639_3658(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 3639, 3658);
                    return return_v;
                }


                ushort
                f_11_3703_3722(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 3703, 3722);
                    return return_v;
                }


                ushort
                f_11_3766_3785(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 3766, 3785);
                    return return_v;
                }


                uint
                f_11_3826_3845(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 3826, 3845);
                    return return_v;
                }


                uint
                f_11_3894_3913(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 3894, 3913);
                    return return_v;
                }


                int
                f_11_4035_4058(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 4035, 4058);
                    return return_v;
                }


                int
                f_11_4002_4059(System.IO.BinaryReader
                this_param, byte[]
                buffer, int
                index, int
                count)
                {
                    var return_v = this_param.Read(buffer, index, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 4002, 4059);
                    return return_v;
                }


                long
                f_11_4099_4114(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 4099, 4114);
                    return return_v;
                }


                int
                f_11_4392_4422(System.Collections.Generic.List<Microsoft.CodeAnalysis.RESOURCE>
                this_param, Microsoft.CodeAnalysis.RESOURCE
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 4392, 4422);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(11, 1720, 4486);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 1720, 4486);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static RESOURCE_STRING ReadStringOrID(BinaryReader fhIn)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(11, 4498, 5558);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 4741, 4789);

                RESOURCE_STRING
                pstring = f_11_4767_4788()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 4805, 4839);

                WCHAR
                firstWord = f_11_4823_4838(fhIn)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 4855, 5514) || true) && (firstWord == 0xFFFF)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 4855, 5514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 4940, 4976);

                    pstring.Ordinal = f_11_4958_4975(fhIn);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(11, 4855, 5514);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 4855, 5514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 5071, 5096);

                    pstring.Ordinal = 0xFFFF;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 5170, 5209);

                    StringBuilder
                    sb = f_11_5189_5208()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 5229, 5255);

                    WCHAR
                    curChar = firstWord
                    ;
                    {
                        try
                        {
                            do

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 5275, 5443);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 5318, 5337);

                                f_11_5318_5336(sb, curChar);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 5359, 5385);

                                curChar = f_11_5369_5384(fhIn);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(11, 5275, 5443);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 5275, 5443) || true) && (curChar != 0)
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(11, 5275, 5443);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(11, 5275, 5443);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 5465, 5499);

                    pstring.theString = f_11_5485_5498(sb);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(11, 4855, 5514);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 5530, 5547);

                return (pstring);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(11, 4498, 5558);

                Microsoft.CodeAnalysis.RESOURCE_STRING
                f_11_4767_4788()
                {
                    var return_v = new Microsoft.CodeAnalysis.RESOURCE_STRING();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 4767, 4788);
                    return return_v;
                }


                char
                f_11_4823_4838(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 4823, 4838);
                    return return_v;
                }


                ushort
                f_11_4958_4975(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 4958, 4975);
                    return return_v;
                }


                System.Text.StringBuilder
                f_11_5189_5208()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 5189, 5208);
                    return return_v;
                }


                System.Text.StringBuilder
                f_11_5318_5336(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 5318, 5336);
                    return return_v;
                }


                char
                f_11_5369_5384(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 5369, 5384);
                    return return_v;
                }


                string
                f_11_5485_5498(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 5485, 5498);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(11, 4498, 5558);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 4498, 5558);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CvtResFile()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(11, 1628, 5565);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(11, 1628, 5565);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 1628, 5565);
        }


        static CvtResFile()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(11, 1628, 5565);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 1689, 1707);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(11, 1628, 5565);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 1628, 5565);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(11, 1628, 5565);
    }
    internal static class COFFResourceReader
    {
        private static void ConfirmSectionValues(SectionHeader hdr, long fileSize)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(11, 5630, 5902);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 5729, 5891) || true) && ((long)hdr.PointerToRawData + hdr.SizeOfRawData > fileSize)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 5729, 5891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 5809, 5891);

                    throw f_11_5815_5890(f_11_5837_5889());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(11, 5729, 5891);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(11, 5630, 5902);

                string
                f_11_5837_5889()
                {
                    var return_v = CodeAnalysisResources.CoffResourceInvalidSectionSize;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 5837, 5889);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ResourceException
                f_11_5815_5890(string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.ResourceException(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 5815, 5890);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(11, 5630, 5902);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 5630, 5902);
            }
        }

        internal static Microsoft.Cci.ResourceSection ReadWin32ResourcesFromCOFF(Stream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(11, 5914, 12163);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 6026, 6064);

                var
                peHeaders = f_11_6042_6063(stream)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 6078, 6110);

                var
                rsrc1 = f_11_6090_6109()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 6124, 6156);

                var
                rsrc2 = f_11_6136_6155()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 6172, 6191);

                int
                foundCount = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 6205, 6639);
                    foreach (var sectionHeader in f_11_6235_6259_I(f_11_6235_6259(peHeaders)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 6205, 6639);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 6293, 6624) || true) && (sectionHeader.Name == ".rsrc$01")
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 6293, 6624);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 6371, 6393);

                            rsrc1 = sectionHeader;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 6415, 6428);

                            foundCount++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(11, 6293, 6624);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 6293, 6624);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 6470, 6624) || true) && (sectionHeader.Name == ".rsrc$02")
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 6470, 6624);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 6548, 6570);

                                rsrc2 = sectionHeader;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 6592, 6605);

                                foundCount++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(11, 6470, 6624);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(11, 6293, 6624);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(11, 6205, 6639);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(11, 1, 435);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(11, 1, 435);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 6655, 6771) || true) && (foundCount != 2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 6655, 6771);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 6693, 6771);

                    throw f_11_6699_6770(f_11_6721_6769());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(11, 6655, 6771);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 6787, 6830);

                f_11_6787_6829(rsrc1, f_11_6815_6828(stream));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 6844, 6887);

                f_11_6844_6886(rsrc2, f_11_6872_6885(stream));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 7066, 7159);

                var
                imageResourceSectionBytes = new byte[checked(rsrc1.SizeOfRawData + rsrc2.SizeOfRawData)]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 7175, 7229);

                f_11_7175_7228(
                            stream, rsrc1.PointerToRawData, SeekOrigin.Begin);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 7243, 7312);

                f_11_7243_7311(stream, imageResourceSectionBytes, 0, rsrc1.SizeOfRawData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 7382, 7436);

                f_11_7382_7435(stream, rsrc2.PointerToRawData, SeekOrigin.Begin);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 7450, 7537);

                f_11_7450_7536(stream, imageResourceSectionBytes, rsrc1.SizeOfRawData, rsrc2.SizeOfRawData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 7609, 7646);

                const int
                SizeOfRelocationEntry = 10
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 7698, 7811);

                    var
                    relocLastAddress = checked(rsrc1.PointerToRelocations + (rsrc1.NumberOfRelocations * SizeOfRelocationEntry))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 7831, 7971) || true) && (relocLastAddress > f_11_7854_7867(stream))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 7831, 7971);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 7890, 7971);

                        throw f_11_7896_7970(f_11_7918_7969());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(11, 7831, 7971);
                    }
                }
                catch (OverflowException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(11, 8000, 8154);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 8058, 8139);

                    throw f_11_8064_8138(f_11_8086_8137());
                    DynAbs.Tracing.TraceSender.TraceExitCatch(11, 8000, 8154);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 8476, 8536);

                var
                relocationOffsets = new uint[rsrc1.NumberOfRelocations]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 8579, 8645);

                var
                relocationSymbolIndices = new uint[rsrc1.NumberOfRelocations]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 8661, 8717);

                var
                reader = f_11_8674_8716(stream, f_11_8699_8715())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 8731, 8776);

                stream.Position = rsrc1.PointerToRelocations;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 8801, 8806);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 8792, 9190) || true) && (i < rsrc1.NumberOfRelocations)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 8839, 8842)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(11, 8792, 9190))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 8792, 9190);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 8876, 8919);

                        relocationOffsets[i] = f_11_8899_8918(reader);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 9056, 9105);

                        relocationSymbolIndices[i] = f_11_9085_9104(reader);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 9123, 9143);

                        f_11_9123_9142(reader);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(11, 1, 399);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(11, 1, 399);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 9286, 9346);

                stream.Position = f_11_9304_9345(f_11_9304_9324(peHeaders));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 9360, 9394);

                const uint
                ImageSizeOfSymbol = 18
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 9446, 9577);

                    var
                    lastSymAddress = checked(f_11_9475_9516(f_11_9475_9495(peHeaders)) + f_11_9519_9555(f_11_9519_9539(peHeaders)) * ImageSizeOfSymbol)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 9597, 9731) || true) && (lastSymAddress > f_11_9618_9631(stream))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 9597, 9731);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 9654, 9731);

                        throw f_11_9660_9730(f_11_9682_9729());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(11, 9597, 9731);
                    }
                }
                catch (OverflowException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(11, 9760, 9910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 9818, 9895);

                    throw f_11_9824_9894(f_11_9846_9893());
                    DynAbs.Tracing.TraceSender.TraceExitCatch(11, 9760, 9910);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 9926, 9989);

                var
                outputStream = f_11_9945_9988(imageResourceSectionBytes)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 10003, 10047);

                var
                writer = f_11_10016_10046(outputStream)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 10138, 10143);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 10129, 12059) || true) && (i < f_11_10149_10179(relocationSymbolIndices))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 10181, 10184)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(11, 10129, 12059))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 10129, 12059);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 10218, 10391) || true) && (relocationSymbolIndices[i] > f_11_10251_10287(f_11_10251_10271(peHeaders)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 10218, 10391);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 10310, 10391);

                            throw f_11_10316_10390(f_11_10338_10389());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(11, 10218, 10391);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 10411, 10523);

                        var
                        offsetOfSymbol = f_11_10432_10473(f_11_10432_10452(peHeaders)) + relocationSymbolIndices[i] * ImageSizeOfSymbol
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 10543, 10576);

                        stream.Position = offsetOfSymbol;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 10594, 10615);

                        stream.Position += DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => 8, 11, 10594, 10609);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 10657, 10692);

                        var
                        symValue = f_11_10672_10691(reader)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 10710, 10746);

                        var
                        symSection = f_11_10727_10745(reader)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 10764, 10798);

                        var
                        symType = f_11_10778_10797(reader)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 10868, 10910);

                        const ushort
                        IMAGE_SYM_TYPE_NULL = 0x0000
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 10930, 11131) || true) && (symType != IMAGE_SYM_TYPE_NULL || (DynAbs.Tracing.TraceSender.Expression_False(11, 10934, 11004) || symSection != 3))
                        )  //3rd section is .rsrc$02

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 10930, 11131);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 11054, 11131);

                            throw f_11_11060_11130(f_11_11082_11129());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(11, 10930, 11131);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 11928, 11973);

                        outputStream.Position = relocationOffsets[i];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 11991, 12044);

                        f_11_11991_12043(writer, (symValue + rsrc1.SizeOfRawData));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(11, 1, 1931);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(11, 1, 1931);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 12075, 12152);

                return f_11_12082_12151(imageResourceSectionBytes, relocationOffsets);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(11, 5914, 12163);

                System.Reflection.PortableExecutable.PEHeaders
                f_11_6042_6063(System.IO.Stream
                peStream)
                {
                    var return_v = new System.Reflection.PortableExecutable.PEHeaders(peStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 6042, 6063);
                    return return_v;
                }


                System.Reflection.PortableExecutable.SectionHeader
                f_11_6090_6109()
                {
                    var return_v = new System.Reflection.PortableExecutable.SectionHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 6090, 6109);
                    return return_v;
                }


                System.Reflection.PortableExecutable.SectionHeader
                f_11_6136_6155()
                {
                    var return_v = new System.Reflection.PortableExecutable.SectionHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 6136, 6155);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Reflection.PortableExecutable.SectionHeader>
                f_11_6235_6259(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.SectionHeaders;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 6235, 6259);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Reflection.PortableExecutable.SectionHeader>
                f_11_6235_6259_I(System.Collections.Immutable.ImmutableArray<System.Reflection.PortableExecutable.SectionHeader>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 6235, 6259);
                    return return_v;
                }


                string
                f_11_6721_6769()
                {
                    var return_v = CodeAnalysisResources.CoffResourceMissingSection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 6721, 6769);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ResourceException
                f_11_6699_6770(string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.ResourceException(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 6699, 6770);
                    return return_v;
                }


                long
                f_11_6815_6828(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 6815, 6828);
                    return return_v;
                }


                int
                f_11_6787_6829(System.Reflection.PortableExecutable.SectionHeader
                hdr, long
                fileSize)
                {
                    ConfirmSectionValues(hdr, fileSize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 6787, 6829);
                    return 0;
                }


                long
                f_11_6872_6885(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 6872, 6885);
                    return return_v;
                }


                int
                f_11_6844_6886(System.Reflection.PortableExecutable.SectionHeader
                hdr, long
                fileSize)
                {
                    ConfirmSectionValues(hdr, fileSize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 6844, 6886);
                    return 0;
                }


                long
                f_11_7175_7228(System.IO.Stream
                this_param, int
                offset, System.IO.SeekOrigin
                origin)
                {
                    var return_v = this_param.Seek((long)offset, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 7175, 7228);
                    return return_v;
                }


                int
                f_11_7243_7311(System.IO.Stream
                stream, byte[]
                buffer, int
                offset, int
                count)
                {
                    var return_v = stream.TryReadAll(buffer, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 7243, 7311);
                    return return_v;
                }


                long
                f_11_7382_7435(System.IO.Stream
                this_param, int
                offset, System.IO.SeekOrigin
                origin)
                {
                    var return_v = this_param.Seek((long)offset, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 7382, 7435);
                    return return_v;
                }


                int
                f_11_7450_7536(System.IO.Stream
                stream, byte[]
                buffer, int
                offset, int
                count)
                {
                    var return_v = stream.TryReadAll(buffer, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 7450, 7536);
                    return return_v;
                }


                long
                f_11_7854_7867(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 7854, 7867);
                    return return_v;
                }


                string
                f_11_7918_7969()
                {
                    var return_v = CodeAnalysisResources.CoffResourceInvalidRelocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 7918, 7969);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ResourceException
                f_11_7896_7970(string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.ResourceException(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 7896, 7970);
                    return return_v;
                }


                string
                f_11_8086_8137()
                {
                    var return_v = CodeAnalysisResources.CoffResourceInvalidRelocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 8086, 8137);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ResourceException
                f_11_8064_8138(string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.ResourceException(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 8064, 8138);
                    return return_v;
                }


                System.Text.Encoding
                f_11_8699_8715()
                {
                    var return_v = Encoding.Unicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 8699, 8715);
                    return return_v;
                }


                System.IO.BinaryReader
                f_11_8674_8716(System.IO.Stream
                input, System.Text.Encoding
                encoding)
                {
                    var return_v = new System.IO.BinaryReader(input, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 8674, 8716);
                    return return_v;
                }


                uint
                f_11_8899_8918(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 8899, 8918);
                    return return_v;
                }


                uint
                f_11_9085_9104(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 9085, 9104);
                    return return_v;
                }


                ushort
                f_11_9123_9142(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 9123, 9142);
                    return return_v;
                }


                System.Reflection.PortableExecutable.CoffHeader
                f_11_9304_9324(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.CoffHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 9304, 9324);
                    return return_v;
                }


                int
                f_11_9304_9345(System.Reflection.PortableExecutable.CoffHeader
                this_param)
                {
                    var return_v = this_param.PointerToSymbolTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 9304, 9345);
                    return return_v;
                }


                System.Reflection.PortableExecutable.CoffHeader
                f_11_9475_9495(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.CoffHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 9475, 9495);
                    return return_v;
                }


                int
                f_11_9475_9516(System.Reflection.PortableExecutable.CoffHeader
                this_param)
                {
                    var return_v = this_param.PointerToSymbolTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 9475, 9516);
                    return return_v;
                }


                System.Reflection.PortableExecutable.CoffHeader
                f_11_9519_9539(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.CoffHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 9519, 9539);
                    return return_v;
                }


                int
                f_11_9519_9555(System.Reflection.PortableExecutable.CoffHeader
                this_param)
                {
                    var return_v = this_param.NumberOfSymbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 9519, 9555);
                    return return_v;
                }


                long
                f_11_9618_9631(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 9618, 9631);
                    return return_v;
                }


                string
                f_11_9682_9729()
                {
                    var return_v = CodeAnalysisResources.CoffResourceInvalidSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 9682, 9729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ResourceException
                f_11_9660_9730(string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.ResourceException(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 9660, 9730);
                    return return_v;
                }


                string
                f_11_9846_9893()
                {
                    var return_v = CodeAnalysisResources.CoffResourceInvalidSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 9846, 9893);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ResourceException
                f_11_9824_9894(string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.ResourceException(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 9824, 9894);
                    return return_v;
                }


                System.IO.MemoryStream
                f_11_9945_9988(byte[]
                buffer)
                {
                    var return_v = new System.IO.MemoryStream(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 9945, 9988);
                    return return_v;
                }


                System.IO.BinaryWriter
                f_11_10016_10046(System.IO.MemoryStream
                output)
                {
                    var return_v = new System.IO.BinaryWriter((System.IO.Stream)output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 10016, 10046);
                    return return_v;
                }


                int
                f_11_10149_10179(uint[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 10149, 10179);
                    return return_v;
                }


                System.Reflection.PortableExecutable.CoffHeader
                f_11_10251_10271(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.CoffHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 10251, 10271);
                    return return_v;
                }


                int
                f_11_10251_10287(System.Reflection.PortableExecutable.CoffHeader
                this_param)
                {
                    var return_v = this_param.NumberOfSymbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 10251, 10287);
                    return return_v;
                }


                string
                f_11_10338_10389()
                {
                    var return_v = CodeAnalysisResources.CoffResourceInvalidRelocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 10338, 10389);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ResourceException
                f_11_10316_10390(string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.ResourceException(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 10316, 10390);
                    return return_v;
                }


                System.Reflection.PortableExecutable.CoffHeader
                f_11_10432_10452(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.CoffHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 10432, 10452);
                    return return_v;
                }


                int
                f_11_10432_10473(System.Reflection.PortableExecutable.CoffHeader
                this_param)
                {
                    var return_v = this_param.PointerToSymbolTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 10432, 10473);
                    return return_v;
                }


                uint
                f_11_10672_10691(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 10672, 10691);
                    return return_v;
                }


                short
                f_11_10727_10745(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 10727, 10745);
                    return return_v;
                }


                ushort
                f_11_10778_10797(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 10778, 10797);
                    return return_v;
                }


                string
                f_11_11082_11129()
                {
                    var return_v = CodeAnalysisResources.CoffResourceInvalidSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 11082, 11129);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ResourceException
                f_11_11060_11130(string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.ResourceException(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 11060, 11130);
                    return return_v;
                }


                int
                f_11_11991_12043(System.IO.BinaryWriter
                this_param, long
                value)
                {
                    this_param.Write((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 11991, 12043);
                    return 0;
                }


                Microsoft.Cci.ResourceSection
                f_11_12082_12151(byte[]
                sectionBytes, uint[]
                relocations)
                {
                    var return_v = new Microsoft.Cci.ResourceSection(sectionBytes, relocations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 12082, 12151);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(11, 5914, 12163);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 5914, 12163);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static COFFResourceReader()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(11, 5573, 12170);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(11, 5573, 12170);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 5573, 12170);
        }

    }
    internal static class Win32ResourceConversions
    {
        private struct ICONDIRENTRY
        {

            internal BYTE bWidth;

            internal BYTE bHeight;

            internal BYTE bColorCount;

            internal BYTE bReserved;

            internal WORD wPlanes;

            internal WORD wBitCount;

            internal DWORD dwBytesInRes;

            internal DWORD dwImageOffset;
            static ICONDIRENTRY()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(11, 12241, 12599);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(11, 12241, 12599);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 12241, 12599);
            }
        };

        internal static void AppendIconToResourceStream(Stream resStream, Stream iconStream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(11, 12611, 20019);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 12720, 12766);

                var
                iconReader = f_11_12737_12765(iconStream)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 12822, 12861);

                var
                reserved = f_11_12837_12860(iconReader)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 12875, 12989) || true) && (reserved != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 12875, 12989);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 12911, 12989);

                    throw f_11_12917_12988(f_11_12939_12987());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(11, 12875, 12989);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 13005, 13040);

                var
                type = f_11_13016_13039(iconReader)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 13054, 13164) || true) && (type != 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 13054, 13164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 13086, 13164);

                    throw f_11_13092_13163(f_11_13114_13162());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(11, 13054, 13164);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 13180, 13216);

                var
                count = f_11_13192_13215(iconReader)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 13230, 13341) || true) && (count == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 13230, 13341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 13263, 13341);

                    throw f_11_13269_13340(f_11_13291_13339());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(11, 13230, 13341);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 13357, 13402);

                var
                iconDirEntries = new ICONDIRENTRY[count]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 13428, 13433);
                    for (ushort
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 13416, 14091) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 13446, 13449)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(11, 13416, 14091))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 13416, 14091);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 13524, 13573);

                        iconDirEntries[i].bWidth = f_11_13551_13572(iconReader);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 13591, 13641);

                        iconDirEntries[i].bHeight = f_11_13619_13640(iconReader);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 13659, 13713);

                        iconDirEntries[i].bColorCount = f_11_13691_13712(iconReader);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 13731, 13783);

                        iconDirEntries[i].bReserved = f_11_13761_13782(iconReader);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 13801, 13853);

                        iconDirEntries[i].wPlanes = f_11_13829_13852(iconReader);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 13871, 13925);

                        iconDirEntries[i].wBitCount = f_11_13901_13924(iconReader);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 13943, 14000);

                        iconDirEntries[i].dwBytesInRes = f_11_13976_13999(iconReader);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 14018, 14076);

                        iconDirEntries[i].dwImageOffset = f_11_14052_14075(iconReader);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(11, 1, 676);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(11, 1, 676);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 14819, 14824);

                    // Because Icon files don't seem to record the actual w and BitCount in
                    // the ICONDIRENTRY, get the info from the BITMAPINFOHEADER at the beginning
                    // of the data here:
                    //EDMAURER: PNG compressed icons must be treated differently. Do what has always
                    //been done for uncompressed icons. Assume modern, compressed icons set the 
                    //ICONDIRENTRY fields correctly.
                    //if (*(DWORD*)icoBuffer == sizeof(BITMAPINFOHEADER))
                    //{
                    //    grp[i].Planes = ((BITMAPINFOHEADER*)icoBuffer)->biPlanes;
                    //    grp[i].BitCount = ((BITMAPINFOHEADER*)icoBuffer)->biBitCount;
                    //}

                    for (ushort
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 14807, 15230) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 14837, 14840)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(11, 14807, 15230))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 14807, 15230);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 14874, 14928);

                        iconStream.Position = iconDirEntries[i].dwImageOffset;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 14946, 15215) || true) && (f_11_14950_14973(iconReader) == 40)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 14946, 15215);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 15021, 15046);

                            iconStream.Position += DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => 8, 11, 15021, 15040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 15068, 15120);

                            iconDirEntries[i].wPlanes = f_11_15096_15119(iconReader);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 15142, 15196);

                            iconDirEntries[i].wBitCount = f_11_15172_15195(iconReader);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(11, 14946, 15215);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(11, 1, 424);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(11, 1, 424);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 15311, 15355);

                var
                resWriter = f_11_15327_15354(resStream)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 15504, 15527);

                const WORD
                RT_ICON = 3
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 15555, 15560);

                    for (ushort
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 15543, 17417) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 15573, 15576)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(11, 15543, 17417))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 15543, 17417);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 16158, 16209);

                        resStream.Position = (f_11_16180_16198(resStream) + 3) & ~3;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 16265, 16320);

                        f_11_16265_16319(resWriter, iconDirEntries[i].dwBytesInRes);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 16338, 16373);

                        f_11_16338_16372(resWriter, 0x00000020);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 16391, 16421);

                        f_11_16391_16420(resWriter, 0xFFFF);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 16439, 16470);

                        f_11_16439_16469(resWriter, RT_ICON);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 16488, 16518);

                        f_11_16488_16517(resWriter, 0xFFFF);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 16536, 16567);

                        f_11_16536_16566(resWriter, (i + 1));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 16954, 16989);

                        f_11_16954_16988(                                                      //This icon ID would seem to be global among all of the icons not just this group.
                                                                                               //Zero appears to not be an acceptable ID. Note that this ID is referred to below.
                                        resWriter, 0x00000000);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 17007, 17037);

                        f_11_17007_17036(resWriter, 0x1010);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 17055, 17085);

                        f_11_17055_17084(resWriter, 0x0000);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 17103, 17138);

                        f_11_17103_17137(resWriter, 0x00000000);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 17156, 17191);

                        f_11_17156_17190(resWriter, 0x00000000);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 17246, 17300);

                        iconStream.Position = iconDirEntries[i].dwImageOffset;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 17318, 17402);

                        f_11_17318_17401(resWriter, f_11_17334_17400(iconReader, checked(iconDirEntries[i].dwBytesInRes)));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(11, 1, 1875);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(11, 1, 1875);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 18435, 18475);

                const WORD
                RT_GROUP_ICON = RT_ICON + 11
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 18491, 18542);

                resStream.Position = (f_11_18513_18531(resStream) + 3) & ~3;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 18665, 18744);

                f_11_18665_18743(            //write the icon group. first a RESOURCEHEADER. the data is the ICONDIR
                            resWriter, (3 * sizeof(WORD) + count * /*sizeof(ICONRESDIR)*/ 14));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 18758, 18793);

                f_11_18758_18792(resWriter, 0x00000020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 18807, 18837);

                f_11_18807_18836(resWriter, 0xFFFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 18851, 18888);

                f_11_18851_18887(resWriter, RT_GROUP_ICON);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 18902, 18932);

                f_11_18902_18931(resWriter, 0xFFFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 18946, 18976);

                f_11_18946_18975(resWriter, 0x7F00);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 19009, 19044);

                f_11_19009_19043(resWriter, 0x00000000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 19058, 19088);

                f_11_19058_19087(resWriter, 0x1030);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 19102, 19132);

                f_11_19102_19131(resWriter, 0x0000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 19146, 19181);

                f_11_19146_19180(resWriter, 0x00000000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 19195, 19230);

                f_11_19195_19229(resWriter, 0x00000000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 19273, 19303);

                f_11_19273_19302(
                            //the ICONDIR
                            resWriter, 0x0000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 19317, 19347);

                f_11_19317_19346(resWriter, 0x0001);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 19361, 19390);

                f_11_19361_19389(resWriter, count);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 19418, 19423);

                    for (ushort
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 19406, 20008) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 19436, 19439)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(11, 19406, 20008))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 19406, 20008);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 19473, 19521);

                        f_11_19473_19520(resWriter, iconDirEntries[i].bWidth);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 19539, 19588);

                        f_11_19539_19587(resWriter, iconDirEntries[i].bHeight);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 19606, 19659);

                        f_11_19606_19658(resWriter, iconDirEntries[i].bColorCount);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 19677, 19728);

                        f_11_19677_19727(resWriter, iconDirEntries[i].bReserved);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 19746, 19795);

                        f_11_19746_19794(resWriter, iconDirEntries[i].wPlanes);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 19813, 19864);

                        f_11_19813_19863(resWriter, iconDirEntries[i].wBitCount);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 19882, 19937);

                        f_11_19882_19936(resWriter, iconDirEntries[i].dwBytesInRes);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 19955, 19986);

                        f_11_19955_19985(resWriter, (i + 1));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(11, 1, 603);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(11, 1, 603);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(11, 12611, 20019);

                System.IO.BinaryReader
                f_11_12737_12765(System.IO.Stream
                input)
                {
                    var return_v = new System.IO.BinaryReader(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 12737, 12765);
                    return return_v;
                }


                ushort
                f_11_12837_12860(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 12837, 12860);
                    return return_v;
                }


                string
                f_11_12939_12987()
                {
                    var return_v = CodeAnalysisResources.IconStreamUnexpectedFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 12939, 12987);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ResourceException
                f_11_12917_12988(string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.ResourceException(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 12917, 12988);
                    return return_v;
                }


                ushort
                f_11_13016_13039(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 13016, 13039);
                    return return_v;
                }


                string
                f_11_13114_13162()
                {
                    var return_v = CodeAnalysisResources.IconStreamUnexpectedFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 13114, 13162);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ResourceException
                f_11_13092_13163(string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.ResourceException(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 13092, 13163);
                    return return_v;
                }


                ushort
                f_11_13192_13215(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 13192, 13215);
                    return return_v;
                }


                string
                f_11_13291_13339()
                {
                    var return_v = CodeAnalysisResources.IconStreamUnexpectedFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 13291, 13339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ResourceException
                f_11_13269_13340(string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.ResourceException(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 13269, 13340);
                    return return_v;
                }


                byte
                f_11_13551_13572(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 13551, 13572);
                    return return_v;
                }


                byte
                f_11_13619_13640(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 13619, 13640);
                    return return_v;
                }


                byte
                f_11_13691_13712(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 13691, 13712);
                    return return_v;
                }


                byte
                f_11_13761_13782(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 13761, 13782);
                    return return_v;
                }


                ushort
                f_11_13829_13852(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 13829, 13852);
                    return return_v;
                }


                ushort
                f_11_13901_13924(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 13901, 13924);
                    return return_v;
                }


                uint
                f_11_13976_13999(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 13976, 13999);
                    return return_v;
                }


                uint
                f_11_14052_14075(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 14052, 14075);
                    return return_v;
                }


                uint
                f_11_14950_14973(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 14950, 14973);
                    return return_v;
                }


                ushort
                f_11_15096_15119(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 15096, 15119);
                    return return_v;
                }


                ushort
                f_11_15172_15195(System.IO.BinaryReader
                this_param)
                {
                    var return_v = this_param.ReadUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 15172, 15195);
                    return return_v;
                }


                System.IO.BinaryWriter
                f_11_15327_15354(System.IO.Stream
                output)
                {
                    var return_v = new System.IO.BinaryWriter(output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 15327, 15354);
                    return return_v;
                }


                long
                f_11_16180_16198(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 16180, 16198);
                    return return_v;
                }


                int
                f_11_16265_16319(System.IO.BinaryWriter
                this_param, uint
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 16265, 16319);
                    return 0;
                }


                int
                f_11_16338_16372(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 16338, 16372);
                    return 0;
                }


                int
                f_11_16391_16420(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 16391, 16420);
                    return 0;
                }


                int
                f_11_16439_16469(System.IO.BinaryWriter
                this_param, ushort
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 16439, 16469);
                    return 0;
                }


                int
                f_11_16488_16517(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 16488, 16517);
                    return 0;
                }


                int
                f_11_16536_16566(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 16536, 16566);
                    return 0;
                }


                int
                f_11_16954_16988(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 16954, 16988);
                    return 0;
                }


                int
                f_11_17007_17036(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 17007, 17036);
                    return 0;
                }


                int
                f_11_17055_17084(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 17055, 17084);
                    return 0;
                }


                int
                f_11_17103_17137(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 17103, 17137);
                    return 0;
                }


                int
                f_11_17156_17190(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 17156, 17190);
                    return 0;
                }


                byte[]
                f_11_17334_17400(System.IO.BinaryReader
                this_param, uint
                count)
                {
                    var return_v = this_param.ReadBytes((int)count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 17334, 17400);
                    return return_v;
                }


                int
                f_11_17318_17401(System.IO.BinaryWriter
                this_param, byte[]
                buffer)
                {
                    this_param.Write(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 17318, 17401);
                    return 0;
                }


                long
                f_11_18513_18531(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 18513, 18531);
                    return return_v;
                }


                int
                f_11_18665_18743(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 18665, 18743);
                    return 0;
                }


                int
                f_11_18758_18792(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 18758, 18792);
                    return 0;
                }


                int
                f_11_18807_18836(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 18807, 18836);
                    return 0;
                }


                int
                f_11_18851_18887(System.IO.BinaryWriter
                this_param, ushort
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 18851, 18887);
                    return 0;
                }


                int
                f_11_18902_18931(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 18902, 18931);
                    return 0;
                }


                int
                f_11_18946_18975(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 18946, 18975);
                    return 0;
                }


                int
                f_11_19009_19043(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 19009, 19043);
                    return 0;
                }


                int
                f_11_19058_19087(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 19058, 19087);
                    return 0;
                }


                int
                f_11_19102_19131(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 19102, 19131);
                    return 0;
                }


                int
                f_11_19146_19180(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 19146, 19180);
                    return 0;
                }


                int
                f_11_19195_19229(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 19195, 19229);
                    return 0;
                }


                int
                f_11_19273_19302(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 19273, 19302);
                    return 0;
                }


                int
                f_11_19317_19346(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 19317, 19346);
                    return 0;
                }


                int
                f_11_19361_19389(System.IO.BinaryWriter
                this_param, ushort
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 19361, 19389);
                    return 0;
                }


                int
                f_11_19473_19520(System.IO.BinaryWriter
                this_param, byte
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 19473, 19520);
                    return 0;
                }


                int
                f_11_19539_19587(System.IO.BinaryWriter
                this_param, byte
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 19539, 19587);
                    return 0;
                }


                int
                f_11_19606_19658(System.IO.BinaryWriter
                this_param, byte
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 19606, 19658);
                    return 0;
                }


                int
                f_11_19677_19727(System.IO.BinaryWriter
                this_param, byte
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 19677, 19727);
                    return 0;
                }


                int
                f_11_19746_19794(System.IO.BinaryWriter
                this_param, ushort
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 19746, 19794);
                    return 0;
                }


                int
                f_11_19813_19863(System.IO.BinaryWriter
                this_param, ushort
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 19813, 19863);
                    return 0;
                }


                int
                f_11_19882_19936(System.IO.BinaryWriter
                this_param, uint
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 19882, 19936);
                    return 0;
                }


                int
                f_11_19955_19985(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 19955, 19985);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(11, 12611, 20019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 12611, 20019);
            }
        }

        internal static void AppendVersionToResourceStream(Stream resStream, bool isDll,
                    string fileVersion, //should be [major.minor.build.rev] but doesn't have to be
                    string originalFileName,
                    string internalName,
                    string productVersion,  //4 ints
                    Version assemblyVersion, //individual values must be smaller than 65535
                    string fileDescription = " ",   //the old compiler put blank here if nothing was user-supplied
                    string legalCopyright = " ",    //the old compiler put blank here if nothing was user-supplied
                    string? legalTrademarks = null,
                    string? productName = null,
                    string? comments = null,
                    string? companyName = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(11, 20997, 23614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 21778, 21840);

                var
                resWriter = f_11_21794_21839(resStream, f_11_21822_21838())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 21854, 21905);

                resStream.Position = (f_11_21876_21894(resStream) + 3) & ~3;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 21921, 21949);

                const DWORD
                RT_VERSION = 16
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 21965, 22363);

                var
                ver = f_11_21975_22362(isDll, comments, companyName, fileDescription, fileVersion, internalName, legalCopyright, legalTrademarks, originalFileName, productName, productVersion, assemblyVersion)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 22379, 22413);

                var
                startPos = f_11_22394_22412(resStream)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 22427, 22460);

                var
                dataSize = f_11_22442_22459(ver)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 22474, 22502);

                const int
                headerSize = 0x20
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 22518, 22551);

                f_11_22518_22550(
                            resWriter, dataSize);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 22580, 22615);

                f_11_22580_22614(resWriter, headerSize);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 22659, 22689);

                f_11_22659_22688(resWriter, 0xFFFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 22754, 22788);

                f_11_22754_22787(resWriter, RT_VERSION);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 22825, 22855);

                f_11_22825_22854(resWriter, 0xFFFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 22920, 22950);

                f_11_22920_22949(resWriter, 0x0001);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 23030, 23065);

                f_11_23030_23064(resWriter, 0x00000000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 23110, 23140);

                f_11_23110_23139(resWriter, 0x0030);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 23229, 23259);

                f_11_23229_23258(resWriter, 0x0000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 23307, 23342);

                f_11_23307_23341(resWriter, 0x00000000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 23382, 23417);

                f_11_23382_23416(resWriter, 0x00000000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 23467, 23499);

                f_11_23467_23498(
                            ver, resWriter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 23515, 23603);

                f_11_23515_23602(f_11_23547_23565(resStream) - startPos == dataSize + headerSize);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(11, 20997, 23614);

                System.Text.Encoding
                f_11_21822_21838()
                {
                    var return_v = Encoding.Unicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 21822, 21838);
                    return return_v;
                }


                System.IO.BinaryWriter
                f_11_21794_21839(System.IO.Stream
                output, System.Text.Encoding
                encoding)
                {
                    var return_v = new System.IO.BinaryWriter(output, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 21794, 21839);
                    return return_v;
                }


                long
                f_11_21876_21894(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 21876, 21894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Win32ResourceConversions.VersionResourceSerializer
                f_11_21975_22362(bool
                isDll, string?
                comments, string?
                companyName, string
                fileDescription, string
                fileVersion, string
                internalName, string
                legalCopyright, string?
                legalTrademark, string
                originalFileName, string?
                productName, string
                productVersion, System.Version
                assemblyVersion)
                {
                    var return_v = new Microsoft.CodeAnalysis.Win32ResourceConversions.VersionResourceSerializer(isDll, comments, companyName, fileDescription, fileVersion, internalName, legalCopyright, legalTrademark, originalFileName, productName, productVersion, assemblyVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 21975, 22362);
                    return return_v;
                }


                long
                f_11_22394_22412(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 22394, 22412);
                    return return_v;
                }


                int
                f_11_22442_22459(Microsoft.CodeAnalysis.Win32ResourceConversions.VersionResourceSerializer
                this_param)
                {
                    var return_v = this_param.GetDataSize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 22442, 22459);
                    return return_v;
                }


                int
                f_11_22518_22550(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 22518, 22550);
                    return 0;
                }


                int
                f_11_22580_22614(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 22580, 22614);
                    return 0;
                }


                int
                f_11_22659_22688(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 22659, 22688);
                    return 0;
                }


                int
                f_11_22754_22787(System.IO.BinaryWriter
                this_param, uint
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 22754, 22787);
                    return 0;
                }


                int
                f_11_22825_22854(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 22825, 22854);
                    return 0;
                }


                int
                f_11_22920_22949(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 22920, 22949);
                    return 0;
                }


                int
                f_11_23030_23064(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 23030, 23064);
                    return 0;
                }


                int
                f_11_23110_23139(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 23110, 23139);
                    return 0;
                }


                int
                f_11_23229_23258(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 23229, 23258);
                    return 0;
                }


                int
                f_11_23307_23341(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 23307, 23341);
                    return 0;
                }


                int
                f_11_23382_23416(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 23382, 23416);
                    return 0;
                }


                int
                f_11_23467_23498(Microsoft.CodeAnalysis.Win32ResourceConversions.VersionResourceSerializer
                this_param, System.IO.BinaryWriter
                writer)
                {
                    this_param.WriteVerResource(writer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 23467, 23498);
                    return 0;
                }


                long
                f_11_23547_23565(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 23547, 23565);
                    return return_v;
                }


                int
                f_11_23515_23602(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 23515, 23602);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(11, 20997, 23614);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 20997, 23614);
            }
        }

        internal static void AppendManifestToResourceStream(Stream resStream, Stream manifestStream, bool isDll)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(11, 23626, 24895);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 23755, 23806);

                resStream.Position = (f_11_23777_23795(resStream) + 3) & ~3;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 23820, 23848);

                const WORD
                RT_MANIFEST = 24
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 23864, 23908);

                var
                resWriter = f_11_23880_23907(resStream)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 23922, 23970);

                f_11_23922_23969(resWriter, (f_11_23946_23967(manifestStream)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 23999, 24034);

                f_11_23999_24033(resWriter, 0x00000020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 24078, 24108);

                f_11_24078_24107(resWriter, 0xFFFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 24173, 24208);

                f_11_24173_24207(resWriter, RT_MANIFEST);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 24245, 24275);

                f_11_24245_24274(resWriter, 0xFFFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 24340, 24391);

                f_11_24340_24390(resWriter, ((DynAbs.Tracing.TraceSender.Conditional_F1(11, 24363, 24370) || (((isDll) && DynAbs.Tracing.TraceSender.Conditional_F2(11, 24373, 24379)) || DynAbs.Tracing.TraceSender.Conditional_F3(11, 24382, 24388))) ? 0x0002 : 0x0001));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 24453, 24488);

                f_11_24453_24487(resWriter, 0x00000000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 24533, 24563);

                f_11_24533_24562(resWriter, 0x1030);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 24613, 24643);

                f_11_24613_24642(resWriter, 0x0000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 24691, 24726);

                f_11_24691_24725(resWriter, 0x00000000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 24766, 24801);

                f_11_24766_24800(resWriter, 0x00000000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 24851, 24884);

                f_11_24851_24883(
                            manifestStream, resStream);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(11, 23626, 24895);

                long
                f_11_23777_23795(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 23777, 23795);
                    return return_v;
                }


                System.IO.BinaryWriter
                f_11_23880_23907(System.IO.Stream
                output)
                {
                    var return_v = new System.IO.BinaryWriter(output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 23880, 23907);
                    return return_v;
                }


                long
                f_11_23946_23967(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 23946, 23967);
                    return return_v;
                }


                int
                f_11_23922_23969(System.IO.BinaryWriter
                this_param, long
                value)
                {
                    this_param.Write((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 23922, 23969);
                    return 0;
                }


                int
                f_11_23999_24033(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 23999, 24033);
                    return 0;
                }


                int
                f_11_24078_24107(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 24078, 24107);
                    return 0;
                }


                int
                f_11_24173_24207(System.IO.BinaryWriter
                this_param, ushort
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 24173, 24207);
                    return 0;
                }


                int
                f_11_24245_24274(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 24245, 24274);
                    return 0;
                }


                int
                f_11_24340_24390(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 24340, 24390);
                    return 0;
                }


                int
                f_11_24453_24487(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 24453, 24487);
                    return 0;
                }


                int
                f_11_24533_24562(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 24533, 24562);
                    return 0;
                }


                int
                f_11_24613_24642(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 24613, 24642);
                    return 0;
                }


                int
                f_11_24691_24725(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 24691, 24725);
                    return 0;
                }


                int
                f_11_24766_24800(System.IO.BinaryWriter
                this_param, int
                value)
                {
                    this_param.Write((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 24766, 24800);
                    return 0;
                }


                int
                f_11_24851_24883(System.IO.Stream
                this_param, System.IO.Stream
                destination)
                {
                    this_param.CopyTo(destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 24851, 24883);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(11, 23626, 24895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 23626, 24895);
            }
        }
        private class VersionResourceSerializer
        {
            private readonly string? _commentsContents;

            private readonly string? _companyNameContents;

            private readonly string _fileDescriptionContents;

            private readonly string _fileVersionContents;

            private readonly string _internalNameContents;

            private readonly string _legalCopyrightContents;

            private readonly string? _legalTrademarksContents;

            private readonly string _originalFileNameContents;

            private readonly string? _productNameContents;

            private readonly string _productVersionContents;

            private readonly Version _assemblyVersionContents;

            private const string
            vsVersionInfoKey = "VS_VERSION_INFO"
            ;

            private const string
            varFileInfoKey = "VarFileInfo"
            ;

            private const string
            translationKey = "Translation"
            ;

            private const string
            stringFileInfoKey = "StringFileInfo"
            ;

            private readonly string _langIdAndCodePageKey;

            private const DWORD
            CP_WINUNICODE = 1200
            ;

            private const ushort
            sizeVS_FIXEDFILEINFO = sizeof(DWORD) * 13
            ;

            private readonly bool _isDll;

            internal VersionResourceSerializer(bool isDll, string? comments, string? companyName, string fileDescription, string fileVersion,
                            string internalName, string legalCopyright, string? legalTrademark, string originalFileName, string? productName, string productVersion,
                            Version assemblyVersion)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(11, 26188, 27321);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 24996, 25013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 25053, 25073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 25112, 25136);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 25175, 25195);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 25234, 25255);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 25294, 25317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 25357, 25381);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 25420, 25445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 25485, 25505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 25544, 25567);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 25607, 25631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 25948, 25969);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 26165, 26171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 26546, 26561);

                    _isDll = isDll;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 26579, 26608);

                    _commentsContents = comments;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 26626, 26661);

                    _companyNameContents = companyName;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 26679, 26722);

                    _fileDescriptionContents = fileDescription;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 26740, 26775);

                    _fileVersionContents = fileVersion;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 26793, 26830);

                    _internalNameContents = internalName;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 26848, 26889);

                    _legalCopyrightContents = legalCopyright;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 26907, 26949);

                    _legalTrademarksContents = legalTrademark;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 26967, 27012);

                    _originalFileNameContents = originalFileName;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 27030, 27065);

                    _productNameContents = productName;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 27083, 27124);

                    _productVersionContents = productVersion;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 27142, 27185);

                    _assemblyVersionContents = assemblyVersion;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 27203, 27306);

                    _langIdAndCodePageKey = f_11_27227_27305("{0:x4}{1:x4}", 0, CP_WINUNICODE);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(11, 26188, 27321);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(11, 26188, 27321);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 26188, 27321);
                }
            }

            private const uint
            VFT_APP = 0x00000001
            ;

            private const uint
            VFT_DLL = 0x00000002
            ;

            private IEnumerable<KeyValuePair<string, string>> GetVerStrings()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(11, 27447, 29039);

                    var listYield = new List<KeyValuePair<String, String>>();

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 27545, 27653) || true) && (_commentsContents != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 27545, 27653);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 27576, 27653);

                        listYield.Add(f_11_27589_27652("Comments", _commentsContents));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(11, 27545, 27653);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 27671, 27788) || true) && (_companyNameContents != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 27671, 27788);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 27705, 27788);

                        listYield.Add(f_11_27718_27787("CompanyName", _companyNameContents));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(11, 27671, 27788);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 27806, 27935) || true) && (_fileDescriptionContents != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 27806, 27935);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 27844, 27935);

                        listYield.Add(f_11_27857_27934("FileDescription", _fileDescriptionContents));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(11, 27806, 27935);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 27955, 28038);

                    listYield.Add(f_11_27968_28037("FileVersion", _fileVersionContents));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 28058, 28178) || true) && (_internalNameContents != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 28058, 28178);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 28093, 28178);

                        listYield.Add(f_11_28106_28177("InternalName", _internalNameContents));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(11, 28058, 28178);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 28196, 28322) || true) && (_legalCopyrightContents != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 28196, 28322);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 28233, 28322);

                        listYield.Add(f_11_28246_28321("LegalCopyright", _legalCopyrightContents));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(11, 28196, 28322);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 28340, 28469) || true) && (_legalTrademarksContents != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 28340, 28469);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 28378, 28469);

                        listYield.Add(f_11_28391_28468("LegalTrademarks", _legalTrademarksContents));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(11, 28340, 28469);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 28487, 28619) || true) && (_originalFileNameContents != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 28487, 28619);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 28526, 28619);

                        listYield.Add(f_11_28539_28618("OriginalFilename", _originalFileNameContents));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(11, 28487, 28619);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 28637, 28754) || true) && (_productNameContents != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 28637, 28754);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 28671, 28754);

                        listYield.Add(f_11_28684_28753("ProductName", _productNameContents));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(11, 28637, 28754);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 28774, 28863);

                    listYield.Add(f_11_28787_28862("ProductVersion", _productVersionContents));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 28883, 29024) || true) && (_assemblyVersionContents != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 28883, 29024);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 28921, 29024);

                        listYield.Add(f_11_28934_29023("Assembly Version", f_11_28987_29022(_assemblyVersionContents)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(11, 28883, 29024);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(11, 27447, 29039);

                    return listYield;

                    System.Collections.Generic.KeyValuePair<string, string>
                    f_11_27589_27652(string
                    key, string
                    value)
                    {
                        var return_v = new System.Collections.Generic.KeyValuePair<string, string>(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 27589, 27652);
                        return return_v;
                    }


                    System.Collections.Generic.KeyValuePair<string, string>
                    f_11_27718_27787(string
                    key, string
                    value)
                    {
                        var return_v = new System.Collections.Generic.KeyValuePair<string, string>(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 27718, 27787);
                        return return_v;
                    }


                    System.Collections.Generic.KeyValuePair<string, string>
                    f_11_27857_27934(string
                    key, string
                    value)
                    {
                        var return_v = new System.Collections.Generic.KeyValuePair<string, string>(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 27857, 27934);
                        return return_v;
                    }


                    System.Collections.Generic.KeyValuePair<string, string>
                    f_11_27968_28037(string
                    key, string
                    value)
                    {
                        var return_v = new System.Collections.Generic.KeyValuePair<string, string>(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 27968, 28037);
                        return return_v;
                    }


                    System.Collections.Generic.KeyValuePair<string, string>
                    f_11_28106_28177(string
                    key, string
                    value)
                    {
                        var return_v = new System.Collections.Generic.KeyValuePair<string, string>(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 28106, 28177);
                        return return_v;
                    }


                    System.Collections.Generic.KeyValuePair<string, string>
                    f_11_28246_28321(string
                    key, string
                    value)
                    {
                        var return_v = new System.Collections.Generic.KeyValuePair<string, string>(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 28246, 28321);
                        return return_v;
                    }


                    System.Collections.Generic.KeyValuePair<string, string>
                    f_11_28391_28468(string
                    key, string
                    value)
                    {
                        var return_v = new System.Collections.Generic.KeyValuePair<string, string>(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 28391, 28468);
                        return return_v;
                    }


                    System.Collections.Generic.KeyValuePair<string, string>
                    f_11_28539_28618(string
                    key, string
                    value)
                    {
                        var return_v = new System.Collections.Generic.KeyValuePair<string, string>(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 28539, 28618);
                        return return_v;
                    }


                    System.Collections.Generic.KeyValuePair<string, string>
                    f_11_28684_28753(string
                    key, string
                    value)
                    {
                        var return_v = new System.Collections.Generic.KeyValuePair<string, string>(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 28684, 28753);
                        return return_v;
                    }


                    System.Collections.Generic.KeyValuePair<string, string>
                    f_11_28787_28862(string
                    key, string
                    value)
                    {
                        var return_v = new System.Collections.Generic.KeyValuePair<string, string>(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 28787, 28862);
                        return return_v;
                    }


                    string
                    f_11_28987_29022(System.Version
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 28987, 29022);
                        return return_v;
                    }


                    System.Collections.Generic.KeyValuePair<string, string>
                    f_11_28934_29023(string
                    key, string
                    value)
                    {
                        var return_v = new System.Collections.Generic.KeyValuePair<string, string>(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 28934, 29023);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(11, 27447, 29039);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 27447, 29039);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private uint FileType
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(11, 29079, 29123);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 29085, 29121);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(11, 29092, 29100) || (((_isDll) && DynAbs.Tracing.TraceSender.Conditional_F2(11, 29103, 29110)) || DynAbs.Tracing.TraceSender.Conditional_F3(11, 29113, 29120))) ? VFT_DLL : VFT_APP;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(11, 29079, 29123);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(11, 29055, 29125);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 29055, 29125);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private void WriteVSFixedFileInfo(BinaryWriter writer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(11, 29141, 30660);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 29408, 29428);

                    Version
                    fileVersion
                    = default(Version);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 29446, 29517);

                    f_11_29446_29516(_fileVersionContents, version: out fileVersion);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 29539, 29562);

                    Version
                    productVersion
                    = default(Version);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 29580, 29657);

                    f_11_29580_29656(_productVersionContents, version: out productVersion);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 29677, 29709);

                    f_11_29677_29708(
                                    writer, 0xFEEF04BD);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 29727, 29759);

                    f_11_29727_29758(writer, 0x00010000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 29777, 29856);

                    f_11_29777_29855(writer, (DWORD)((uint)f_11_29804_29821(fileVersion) << 16) | (uint)f_11_29837_29854(fileVersion));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 29874, 29956);

                    f_11_29874_29955(writer, (DWORD)((uint)f_11_29901_29918(fileVersion) << 16) | (uint)f_11_29934_29954(fileVersion));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 29974, 30059);

                    f_11_29974_30058(writer, (DWORD)((uint)f_11_30001_30021(productVersion) << 16) | (uint)f_11_30037_30057(productVersion));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 30077, 30165);

                    f_11_30077_30164(writer, (DWORD)((uint)f_11_30104_30124(productVersion) << 16) | (uint)f_11_30140_30163(productVersion));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 30183, 30215);

                    f_11_30183_30214(writer, 0x0000003F);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 30304, 30327);

                    f_11_30304_30326(writer, 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 30361, 30393);

                    f_11_30361_30392(writer, 0x00000004);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 30430, 30465);

                    f_11_30430_30464(writer, f_11_30450_30463(this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 30483, 30506);

                    f_11_30483_30505(writer, 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 30542, 30565);

                    f_11_30542_30564(writer, 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 30602, 30625);

                    f_11_30602_30624(writer, 0);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(11, 29141, 30660);

                    bool
                    f_11_29446_29516(string
                    s, out System.Version
                    version)
                    {
                        var return_v = VersionHelper.TryParse(s, out version);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 29446, 29516);
                        return return_v;
                    }


                    bool
                    f_11_29580_29656(string
                    s, out System.Version
                    version)
                    {
                        var return_v = VersionHelper.TryParse(s, out version);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 29580, 29656);
                        return return_v;
                    }


                    int
                    f_11_29677_29708(System.IO.BinaryWriter
                    this_param, uint
                    value)
                    {
                        this_param.Write(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 29677, 29708);
                        return 0;
                    }


                    int
                    f_11_29727_29758(System.IO.BinaryWriter
                    this_param, int
                    value)
                    {
                        this_param.Write((uint)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 29727, 29758);
                        return 0;
                    }


                    int
                    f_11_29804_29821(System.Version
                    this_param)
                    {
                        var return_v = this_param.Major;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 29804, 29821);
                        return return_v;
                    }


                    int
                    f_11_29837_29854(System.Version
                    this_param)
                    {
                        var return_v = this_param.Minor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 29837, 29854);
                        return return_v;
                    }


                    int
                    f_11_29777_29855(System.IO.BinaryWriter
                    this_param, uint
                    value)
                    {
                        this_param.Write(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 29777, 29855);
                        return 0;
                    }


                    int
                    f_11_29901_29918(System.Version
                    this_param)
                    {
                        var return_v = this_param.Build;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 29901, 29918);
                        return return_v;
                    }


                    int
                    f_11_29934_29954(System.Version
                    this_param)
                    {
                        var return_v = this_param.Revision;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 29934, 29954);
                        return return_v;
                    }


                    int
                    f_11_29874_29955(System.IO.BinaryWriter
                    this_param, uint
                    value)
                    {
                        this_param.Write(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 29874, 29955);
                        return 0;
                    }


                    int
                    f_11_30001_30021(System.Version
                    this_param)
                    {
                        var return_v = this_param.Major;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 30001, 30021);
                        return return_v;
                    }


                    int
                    f_11_30037_30057(System.Version
                    this_param)
                    {
                        var return_v = this_param.Minor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 30037, 30057);
                        return return_v;
                    }


                    int
                    f_11_29974_30058(System.IO.BinaryWriter
                    this_param, uint
                    value)
                    {
                        this_param.Write(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 29974, 30058);
                        return 0;
                    }


                    int
                    f_11_30104_30124(System.Version
                    this_param)
                    {
                        var return_v = this_param.Build;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 30104, 30124);
                        return return_v;
                    }


                    int
                    f_11_30140_30163(System.Version
                    this_param)
                    {
                        var return_v = this_param.Revision;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 30140, 30163);
                        return return_v;
                    }


                    int
                    f_11_30077_30164(System.IO.BinaryWriter
                    this_param, uint
                    value)
                    {
                        this_param.Write(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 30077, 30164);
                        return 0;
                    }


                    int
                    f_11_30183_30214(System.IO.BinaryWriter
                    this_param, int
                    value)
                    {
                        this_param.Write((uint)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 30183, 30214);
                        return 0;
                    }


                    int
                    f_11_30304_30326(System.IO.BinaryWriter
                    this_param, int
                    value)
                    {
                        this_param.Write((uint)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 30304, 30326);
                        return 0;
                    }


                    int
                    f_11_30361_30392(System.IO.BinaryWriter
                    this_param, int
                    value)
                    {
                        this_param.Write((uint)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 30361, 30392);
                        return 0;
                    }


                    uint
                    f_11_30450_30463(Microsoft.CodeAnalysis.Win32ResourceConversions.VersionResourceSerializer
                    this_param)
                    {
                        var return_v = this_param.FileType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 30450, 30463);
                        return return_v;
                    }


                    int
                    f_11_30430_30464(System.IO.BinaryWriter
                    this_param, uint
                    value)
                    {
                        this_param.Write(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 30430, 30464);
                        return 0;
                    }


                    int
                    f_11_30483_30505(System.IO.BinaryWriter
                    this_param, int
                    value)
                    {
                        this_param.Write((uint)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 30483, 30505);
                        return 0;
                    }


                    int
                    f_11_30542_30564(System.IO.BinaryWriter
                    this_param, int
                    value)
                    {
                        this_param.Write((uint)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 30542, 30564);
                        return 0;
                    }


                    int
                    f_11_30602_30624(System.IO.BinaryWriter
                    this_param, int
                    value)
                    {
                        this_param.Write((uint)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 30602, 30624);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(11, 29141, 30660);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 29141, 30660);
                }
            }

            private static int PadKeyLen(int cb)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(11, 31035, 31267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 31192, 31252);

                    return f_11_31199_31232(cb + 3 * sizeof(WORD)) - 3 * sizeof(WORD);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(11, 31035, 31267);

                    int
                    f_11_31199_31232(int
                    cb)
                    {
                        var return_v = PadToDword(cb);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 31199, 31232);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(11, 31035, 31267);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 31035, 31267);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static int PadToDword(int cb)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(11, 31589, 31695);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 31659, 31680);

                    return (cb + 3) & ~3;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(11, 31589, 31695);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(11, 31589, 31695);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 31589, 31695);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private const int
            HDRSIZE = 3 * sizeof(ushort)
            ;

            private static ushort SizeofVerString(string lpszKey, string lpszValue)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(11, 31774, 32286);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 31878, 31897);

                    int
                    cbKey
                    = default(int),
                    cbValue
                    = default(int);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 31917, 31950);

                    cbKey = (f_11_31926_31940(lpszKey) + 1) * 2;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 31995, 32032);

                    cbValue = (f_11_32006_32022(lpszValue) + 1) * 2;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 32052, 32242);

                    return checked((ushort)(f_11_32076_32092(cbKey) +    // key, 0 padded to DWORD boundary
                                                    cbValue +               // value
                                                    HDRSIZE));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(11, 31774, 32286);

                    int
                    f_11_31926_31940(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 31926, 31940);
                        return return_v;
                    }


                    int
                    f_11_32006_32022(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 32006, 32022);
                        return return_v;
                    }


                    int
                    f_11_32076_32092(int
                    cb)
                    {
                        var return_v = PadKeyLen(cb);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 32076, 32092);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(11, 31774, 32286);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 31774, 32286);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static void WriteVersionString(KeyValuePair<string, string> keyValuePair, BinaryWriter writer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(11, 32302, 33595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 32437, 32484);

                    f_11_32437_32483(keyValuePair.Value != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 32504, 32575);

                    ushort
                    cbBlock = f_11_32521_32574(keyValuePair.Key, keyValuePair.Value)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 32593, 32639);

                    int
                    cbKey = (f_11_32606_32629(keyValuePair.Key) + 1) * 2
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 32689, 32737);

                    int
                    cbVal = (f_11_32702_32727(keyValuePair.Value) + 1) * 2
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 32789, 32831);

                    var
                    startPos = f_11_32804_32830(f_11_32804_32821(writer))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 32849, 32883);

                    f_11_32849_32882((startPos & 3) == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 32903, 32931);

                    f_11_32903_32930(
                                    writer, cbBlock);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 32949, 33001);

                    f_11_32949_33000(writer, (f_11_32969_32994(keyValuePair.Value) + 1));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 33035, 33057);

                    f_11_33035_33056(writer, 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 33075, 33120);

                    f_11_33075_33119(writer, f_11_33088_33118(keyValuePair.Key));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 33138, 33163);

                    f_11_33138_33162(writer, '\0');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 33181, 33230);

                    f_11_33181_33229(writer, new byte[f_11_33203_33219(cbKey) - cbKey]);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 33248, 33300);

                    f_11_33248_33299((f_11_33262_33288(f_11_33262_33279(writer)) & 3) == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 33318, 33365);

                    f_11_33318_33364(writer, f_11_33331_33363(keyValuePair.Value));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 33383, 33408);

                    f_11_33383_33407(writer, '\0');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 33498, 33580);

                    f_11_33498_33579(cbBlock == f_11_33541_33567(f_11_33541_33558(writer)) - startPos);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(11, 32302, 33595);

                    int
                    f_11_32437_32483(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 32437, 32483);
                        return 0;
                    }


                    ushort
                    f_11_32521_32574(string
                    lpszKey, string
                    lpszValue)
                    {
                        var return_v = SizeofVerString(lpszKey, lpszValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 32521, 32574);
                        return return_v;
                    }


                    int
                    f_11_32606_32629(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 32606, 32629);
                        return return_v;
                    }


                    int
                    f_11_32702_32727(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 32702, 32727);
                        return return_v;
                    }


                    System.IO.Stream
                    f_11_32804_32821(System.IO.BinaryWriter
                    this_param)
                    {
                        var return_v = this_param.BaseStream;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 32804, 32821);
                        return return_v;
                    }


                    long
                    f_11_32804_32830(System.IO.Stream
                    this_param)
                    {
                        var return_v = this_param.Position;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 32804, 32830);
                        return return_v;
                    }


                    int
                    f_11_32849_32882(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 32849, 32882);
                        return 0;
                    }


                    int
                    f_11_32903_32930(System.IO.BinaryWriter
                    this_param, ushort
                    value)
                    {
                        this_param.Write(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 32903, 32930);
                        return 0;
                    }


                    int
                    f_11_32969_32994(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 32969, 32994);
                        return return_v;
                    }


                    int
                    f_11_32949_33000(System.IO.BinaryWriter
                    this_param, int
                    value)
                    {
                        this_param.Write((ushort)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 32949, 33000);
                        return 0;
                    }


                    int
                    f_11_33035_33056(System.IO.BinaryWriter
                    this_param, int
                    value)
                    {
                        this_param.Write((ushort)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 33035, 33056);
                        return 0;
                    }


                    char[]
                    f_11_33088_33118(string
                    this_param)
                    {
                        var return_v = this_param.ToCharArray();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 33088, 33118);
                        return return_v;
                    }


                    int
                    f_11_33075_33119(System.IO.BinaryWriter
                    this_param, char[]
                    chars)
                    {
                        this_param.Write(chars);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 33075, 33119);
                        return 0;
                    }


                    int
                    f_11_33138_33162(System.IO.BinaryWriter
                    this_param, char
                    value)
                    {
                        this_param.Write((ushort)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 33138, 33162);
                        return 0;
                    }


                    int
                    f_11_33203_33219(int
                    cb)
                    {
                        var return_v = PadKeyLen(cb);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 33203, 33219);
                        return return_v;
                    }


                    int
                    f_11_33181_33229(System.IO.BinaryWriter
                    this_param, byte[]
                    buffer)
                    {
                        this_param.Write(buffer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 33181, 33229);
                        return 0;
                    }


                    System.IO.Stream
                    f_11_33262_33279(System.IO.BinaryWriter
                    this_param)
                    {
                        var return_v = this_param.BaseStream;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 33262, 33279);
                        return return_v;
                    }


                    long
                    f_11_33262_33288(System.IO.Stream
                    this_param)
                    {
                        var return_v = this_param.Position;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 33262, 33288);
                        return return_v;
                    }


                    int
                    f_11_33248_33299(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 33248, 33299);
                        return 0;
                    }


                    char[]
                    f_11_33331_33363(string
                    this_param)
                    {
                        var return_v = this_param.ToCharArray();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 33331, 33363);
                        return return_v;
                    }


                    int
                    f_11_33318_33364(System.IO.BinaryWriter
                    this_param, char[]
                    chars)
                    {
                        this_param.Write(chars);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 33318, 33364);
                        return 0;
                    }


                    int
                    f_11_33383_33407(System.IO.BinaryWriter
                    this_param, char
                    value)
                    {
                        this_param.Write((ushort)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 33383, 33407);
                        return 0;
                    }


                    System.IO.Stream
                    f_11_33541_33558(System.IO.BinaryWriter
                    this_param)
                    {
                        var return_v = this_param.BaseStream;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 33541, 33558);
                        return return_v;
                    }


                    long
                    f_11_33541_33567(System.IO.Stream
                    this_param)
                    {
                        var return_v = this_param.Position;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 33541, 33567);
                        return return_v;
                    }


                    int
                    f_11_33498_33579(bool
                    condition)
                    {
                        System.Diagnostics.Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 33498, 33579);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(11, 32302, 33595);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 32302, 33595);
                }
            }

            private static int KEYSIZE(string sz)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(11, 33890, 34041);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 33960, 34026);

                    return f_11_33967_34009((f_11_33978_33987(sz) + 1) * sizeof(WCHAR)) / sizeof(WCHAR);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(11, 33890, 34041);

                    int
                    f_11_33978_33987(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 33978, 33987);
                        return return_v;
                    }


                    int
                    f_11_33967_34009(int
                    cb)
                    {
                        var return_v = PadKeyLen(cb);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 33967, 34009);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(11, 33890, 34041);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 33890, 34041);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static int KEYBYTES(string sz)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(11, 34055, 34176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 34126, 34161);

                    return f_11_34133_34144(sz) * sizeof(WCHAR);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(11, 34055, 34176);

                    int
                    f_11_34133_34144(string
                    sz)
                    {
                        var return_v = KEYSIZE(sz);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 34133, 34144);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(11, 34055, 34176);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 34055, 34176);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private int GetStringsSize()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(11, 34192, 34602);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 34253, 34265);

                    int
                    sum = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 34285, 34556);
                        foreach (var verString in f_11_34311_34326_I(f_11_34311_34326(this)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 34285, 34556);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 34368, 34389);

                            sum = (sum + 3) & ~3;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 34482, 34537);

                            sum += f_11_34489_34536(verString.Key, verString.Value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(11, 34285, 34556);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(11, 1, 272);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(11, 1, 272);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 34576, 34587);

                    return sum;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(11, 34192, 34602);

                    System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>
                    f_11_34311_34326(Microsoft.CodeAnalysis.Win32ResourceConversions.VersionResourceSerializer
                    this_param)
                    {
                        var return_v = this_param.GetVerStrings();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 34311, 34326);
                        return return_v;
                    }


                    ushort
                    f_11_34489_34536(string
                    lpszKey, string
                    lpszValue)
                    {
                        var return_v = SizeofVerString(lpszKey, lpszValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 34489, 34536);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>
                    f_11_34311_34326_I(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 34311, 34326);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(11, 34192, 34602);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 34192, 34602);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal int GetDataSize()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(11, 34618, 35161);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 34677, 35081);

                    int
                    sizeEXEVERRESOURCE = sizeof(WORD) * 3 * 5 + 2 * sizeof(WORD) + //five headers + two words for CP and lang
                    f_11_34808_34834(vsVersionInfoKey) +
                    f_11_34858_34882(varFileInfoKey) +
                    f_11_34906_34930(translationKey) +
                    f_11_34954_34981(stringFileInfoKey) +
                    f_11_35005_35036(_langIdAndCodePageKey) +
                                        sizeVS_FIXEDFILEINFO
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 35101, 35146);

                    return f_11_35108_35124(this) + sizeEXEVERRESOURCE;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(11, 34618, 35161);

                    int
                    f_11_34808_34834(string
                    sz)
                    {
                        var return_v = KEYBYTES(sz);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 34808, 34834);
                        return return_v;
                    }


                    int
                    f_11_34858_34882(string
                    sz)
                    {
                        var return_v = KEYBYTES(sz);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 34858, 34882);
                        return return_v;
                    }


                    int
                    f_11_34906_34930(string
                    sz)
                    {
                        var return_v = KEYBYTES(sz);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 34906, 34930);
                        return return_v;
                    }


                    int
                    f_11_34954_34981(string
                    sz)
                    {
                        var return_v = KEYBYTES(sz);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 34954, 34981);
                        return return_v;
                    }


                    int
                    f_11_35005_35036(string
                    sz)
                    {
                        var return_v = KEYBYTES(sz);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 35005, 35036);
                        return return_v;
                    }


                    int
                    f_11_35108_35124(Microsoft.CodeAnalysis.Win32ResourceConversions.VersionResourceSerializer
                    this_param)
                    {
                        var return_v = this_param.GetStringsSize();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 35108, 35124);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(11, 34618, 35161);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 34618, 35161);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal void WriteVerResource(BinaryWriter writer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(11, 35177, 41845);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 38228, 38270);

                    var
                    debugPos = f_11_38243_38269(f_11_38243_38260(writer))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 38288, 38317);

                    var
                    dataSize = f_11_38303_38316(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 38337, 38366);

                    f_11_38337_38365(
                                    writer, dataSize);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 38384, 38425);

                    f_11_38384_38424(writer, sizeVS_FIXEDFILEINFO);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 38443, 38465);

                    f_11_38443_38464(writer, 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 38483, 38528);

                    f_11_38483_38527(writer, f_11_38496_38526(vsVersionInfoKey));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 38546, 38627);

                    f_11_38546_38626(writer, new byte[f_11_38568_38594(vsVersionInfoKey) - f_11_38597_38620(vsVersionInfoKey) * 2]);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 38645, 38716);

                    f_11_38645_38715((f_11_38678_38704(f_11_38678_38695(writer)) & 3) == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 38734, 38763);

                    f_11_38734_38762(this, writer);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 38781, 38888);

                    f_11_38781_38887(writer, (sizeof(WORD) * 2 + 2 * HDRSIZE + f_11_38834_38858(varFileInfoKey) + f_11_38861_38885(translationKey)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 38906, 38928);

                    f_11_38906_38927(writer, 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 38946, 38968);

                    f_11_38946_38967(writer, 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 38986, 39029);

                    f_11_38986_39028(writer, f_11_38999_39027(varFileInfoKey));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 39047, 39124);

                    f_11_39047_39123(writer, new byte[f_11_39069_39093(varFileInfoKey) - f_11_39096_39117(varFileInfoKey) * 2]);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 39154, 39225);

                    f_11_39154_39224((f_11_39187_39213(f_11_39187_39204(writer)) & 3) == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 39243, 39319);

                    f_11_39243_39318(writer, (sizeof(WORD) * 2 + HDRSIZE + f_11_39292_39316(translationKey)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 39337, 39376);

                    f_11_39337_39375(writer, (sizeof(WORD) * 2));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 39394, 39416);

                    f_11_39394_39415(writer, 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 39434, 39477);

                    f_11_39434_39476(writer, f_11_39447_39475(translationKey));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 39495, 39572);

                    f_11_39495_39571(writer, new byte[f_11_39517_39541(translationKey) - f_11_39544_39565(translationKey) * 2]);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 39602, 39673);

                    f_11_39602_39672((f_11_39635_39661(f_11_39635_39652(writer)) & 3) == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 39691, 39713);

                    f_11_39691_39712(writer, 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 39793, 39827);

                    f_11_39793_39826(writer, CP_WINUNICODE);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 39880, 39951);

                    f_11_39880_39950((f_11_39913_39939(f_11_39913_39930(writer)) & 3) == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 39969, 40086);

                    f_11_39969_40085(writer, (2 * HDRSIZE + f_11_40003_40030(stringFileInfoKey) + f_11_40033_40064(_langIdAndCodePageKey) + f_11_40067_40083(this)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 40104, 40126);

                    f_11_40104_40125(writer, 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 40144, 40166);

                    f_11_40144_40165(writer, 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 40184, 40230);

                    f_11_40184_40229(writer, f_11_40197_40228(stringFileInfoKey));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 40423, 40506);

                    f_11_40423_40505(                                                                    //assumptions of KEYBYTES, but equivalent.
                                    writer, new byte[f_11_40445_40472(stringFileInfoKey) - f_11_40475_40499(stringFileInfoKey) * 2]);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 40536, 40607);

                    f_11_40536_40606((f_11_40569_40595(f_11_40569_40586(writer)) & 3) == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 40625, 40708);

                    f_11_40625_40707(writer, (HDRSIZE + f_11_40655_40686(_langIdAndCodePageKey) + f_11_40689_40705(this)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 40726, 40748);

                    f_11_40726_40747(writer, 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 40766, 40788);

                    f_11_40766_40787(writer, 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 40806, 40856);

                    f_11_40806_40855(writer, f_11_40819_40854(_langIdAndCodePageKey));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 40874, 40965);

                    f_11_40874_40964(writer, new byte[f_11_40896_40927(_langIdAndCodePageKey) - f_11_40930_40958(_langIdAndCodePageKey) * 2]);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 40993, 41064);

                    f_11_40993_41063((f_11_41026_41052(f_11_41026_41043(writer)) & 3) == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 41084, 41186);

                    f_11_41084_41185(f_11_41116_41142(f_11_41116_41133(writer)) - debugPos == dataSize - f_11_41168_41184(this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 41204, 41242);

                    debugPos = f_11_41215_41241(f_11_41215_41232(writer));
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 41262, 41719);
                        foreach (var entry in f_11_41284_41299_I(f_11_41284_41299(this)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(11, 41262, 41719);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 41341, 41384);

                            var
                            writerPos = f_11_41357_41383(f_11_41357_41374(writer))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 41508, 41567);

                            f_11_41508_41566(
                                                //write any padding necessary to align the String struct on a 32 bit boundary.
                                                writer, new byte[((writerPos + 3) & ~3) - writerPos]);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 41591, 41644);

                            f_11_41591_41643(entry.Value != null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 41666, 41700);

                            f_11_41666_41699(entry, writer);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(11, 41262, 41719);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(11, 1, 458);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(11, 1, 458);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 41739, 41830);

                    f_11_41739_41829(f_11_41771_41797(f_11_41771_41788(writer)) - debugPos == f_11_41812_41828(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(11, 35177, 41845);

                    System.IO.Stream
                    f_11_38243_38260(System.IO.BinaryWriter
                    this_param)
                    {
                        var return_v = this_param.BaseStream;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 38243, 38260);
                        return return_v;
                    }


                    long
                    f_11_38243_38269(System.IO.Stream
                    this_param)
                    {
                        var return_v = this_param.Position;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 38243, 38269);
                        return return_v;
                    }


                    int
                    f_11_38303_38316(Microsoft.CodeAnalysis.Win32ResourceConversions.VersionResourceSerializer
                    this_param)
                    {
                        var return_v = this_param.GetDataSize();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 38303, 38316);
                        return return_v;
                    }


                    int
                    f_11_38337_38365(System.IO.BinaryWriter
                    this_param, int
                    value)
                    {
                        this_param.Write((ushort)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 38337, 38365);
                        return 0;
                    }


                    int
                    f_11_38384_38424(System.IO.BinaryWriter
                    this_param, ushort
                    value)
                    {
                        this_param.Write(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 38384, 38424);
                        return 0;
                    }


                    int
                    f_11_38443_38464(System.IO.BinaryWriter
                    this_param, int
                    value)
                    {
                        this_param.Write((ushort)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 38443, 38464);
                        return 0;
                    }


                    char[]
                    f_11_38496_38526(string
                    this_param)
                    {
                        var return_v = this_param.ToCharArray();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 38496, 38526);
                        return return_v;
                    }


                    int
                    f_11_38483_38527(System.IO.BinaryWriter
                    this_param, char[]
                    chars)
                    {
                        this_param.Write(chars);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 38483, 38527);
                        return 0;
                    }


                    int
                    f_11_38568_38594(string
                    sz)
                    {
                        var return_v = KEYBYTES(sz);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 38568, 38594);
                        return return_v;
                    }


                    int
                    f_11_38597_38620(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 38597, 38620);
                        return return_v;
                    }


                    int
                    f_11_38546_38626(System.IO.BinaryWriter
                    this_param, byte[]
                    buffer)
                    {
                        this_param.Write(buffer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 38546, 38626);
                        return 0;
                    }


                    System.IO.Stream
                    f_11_38678_38695(System.IO.BinaryWriter
                    this_param)
                    {
                        var return_v = this_param.BaseStream;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 38678, 38695);
                        return return_v;
                    }


                    long
                    f_11_38678_38704(System.IO.Stream
                    this_param)
                    {
                        var return_v = this_param.Position;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 38678, 38704);
                        return return_v;
                    }


                    int
                    f_11_38645_38715(bool
                    condition)
                    {
                        System.Diagnostics.Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 38645, 38715);
                        return 0;
                    }


                    int
                    f_11_38734_38762(Microsoft.CodeAnalysis.Win32ResourceConversions.VersionResourceSerializer
                    this_param, System.IO.BinaryWriter
                    writer)
                    {
                        this_param.WriteVSFixedFileInfo(writer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 38734, 38762);
                        return 0;
                    }


                    int
                    f_11_38834_38858(string
                    sz)
                    {
                        var return_v = KEYBYTES(sz);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 38834, 38858);
                        return return_v;
                    }


                    int
                    f_11_38861_38885(string
                    sz)
                    {
                        var return_v = KEYBYTES(sz);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 38861, 38885);
                        return return_v;
                    }


                    int
                    f_11_38781_38887(System.IO.BinaryWriter
                    this_param, int
                    value)
                    {
                        this_param.Write((ushort)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 38781, 38887);
                        return 0;
                    }


                    int
                    f_11_38906_38927(System.IO.BinaryWriter
                    this_param, int
                    value)
                    {
                        this_param.Write((ushort)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 38906, 38927);
                        return 0;
                    }


                    int
                    f_11_38946_38967(System.IO.BinaryWriter
                    this_param, int
                    value)
                    {
                        this_param.Write((ushort)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 38946, 38967);
                        return 0;
                    }


                    char[]
                    f_11_38999_39027(string
                    this_param)
                    {
                        var return_v = this_param.ToCharArray();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 38999, 39027);
                        return return_v;
                    }


                    int
                    f_11_38986_39028(System.IO.BinaryWriter
                    this_param, char[]
                    chars)
                    {
                        this_param.Write(chars);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 38986, 39028);
                        return 0;
                    }


                    int
                    f_11_39069_39093(string
                    sz)
                    {
                        var return_v = KEYBYTES(sz);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 39069, 39093);
                        return return_v;
                    }


                    int
                    f_11_39096_39117(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 39096, 39117);
                        return return_v;
                    }


                    int
                    f_11_39047_39123(System.IO.BinaryWriter
                    this_param, byte[]
                    buffer)
                    {
                        this_param.Write(buffer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 39047, 39123);
                        return 0;
                    }


                    System.IO.Stream
                    f_11_39187_39204(System.IO.BinaryWriter
                    this_param)
                    {
                        var return_v = this_param.BaseStream;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 39187, 39204);
                        return return_v;
                    }


                    long
                    f_11_39187_39213(System.IO.Stream
                    this_param)
                    {
                        var return_v = this_param.Position;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 39187, 39213);
                        return return_v;
                    }


                    int
                    f_11_39154_39224(bool
                    condition)
                    {
                        System.Diagnostics.Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 39154, 39224);
                        return 0;
                    }


                    int
                    f_11_39292_39316(string
                    sz)
                    {
                        var return_v = KEYBYTES(sz);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 39292, 39316);
                        return return_v;
                    }


                    int
                    f_11_39243_39318(System.IO.BinaryWriter
                    this_param, int
                    value)
                    {
                        this_param.Write((ushort)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 39243, 39318);
                        return 0;
                    }


                    int
                    f_11_39337_39375(System.IO.BinaryWriter
                    this_param, int
                    value)
                    {
                        this_param.Write((ushort)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 39337, 39375);
                        return 0;
                    }


                    int
                    f_11_39394_39415(System.IO.BinaryWriter
                    this_param, int
                    value)
                    {
                        this_param.Write((ushort)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 39394, 39415);
                        return 0;
                    }


                    char[]
                    f_11_39447_39475(string
                    this_param)
                    {
                        var return_v = this_param.ToCharArray();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 39447, 39475);
                        return return_v;
                    }


                    int
                    f_11_39434_39476(System.IO.BinaryWriter
                    this_param, char[]
                    chars)
                    {
                        this_param.Write(chars);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 39434, 39476);
                        return 0;
                    }


                    int
                    f_11_39517_39541(string
                    sz)
                    {
                        var return_v = KEYBYTES(sz);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 39517, 39541);
                        return return_v;
                    }


                    int
                    f_11_39544_39565(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 39544, 39565);
                        return return_v;
                    }


                    int
                    f_11_39495_39571(System.IO.BinaryWriter
                    this_param, byte[]
                    buffer)
                    {
                        this_param.Write(buffer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 39495, 39571);
                        return 0;
                    }


                    System.IO.Stream
                    f_11_39635_39652(System.IO.BinaryWriter
                    this_param)
                    {
                        var return_v = this_param.BaseStream;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 39635, 39652);
                        return return_v;
                    }


                    long
                    f_11_39635_39661(System.IO.Stream
                    this_param)
                    {
                        var return_v = this_param.Position;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 39635, 39661);
                        return return_v;
                    }


                    int
                    f_11_39602_39672(bool
                    condition)
                    {
                        System.Diagnostics.Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 39602, 39672);
                        return 0;
                    }


                    int
                    f_11_39691_39712(System.IO.BinaryWriter
                    this_param, int
                    value)
                    {
                        this_param.Write((ushort)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 39691, 39712);
                        return 0;
                    }


                    int
                    f_11_39793_39826(System.IO.BinaryWriter
                    this_param, uint
                    value)
                    {
                        this_param.Write((ushort)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 39793, 39826);
                        return 0;
                    }


                    System.IO.Stream
                    f_11_39913_39930(System.IO.BinaryWriter
                    this_param)
                    {
                        var return_v = this_param.BaseStream;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 39913, 39930);
                        return return_v;
                    }


                    long
                    f_11_39913_39939(System.IO.Stream
                    this_param)
                    {
                        var return_v = this_param.Position;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 39913, 39939);
                        return return_v;
                    }


                    int
                    f_11_39880_39950(bool
                    condition)
                    {
                        System.Diagnostics.Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 39880, 39950);
                        return 0;
                    }


                    int
                    f_11_40003_40030(string
                    sz)
                    {
                        var return_v = KEYBYTES(sz);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 40003, 40030);
                        return return_v;
                    }


                    int
                    f_11_40033_40064(string
                    sz)
                    {
                        var return_v = KEYBYTES(sz);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 40033, 40064);
                        return return_v;
                    }


                    int
                    f_11_40067_40083(Microsoft.CodeAnalysis.Win32ResourceConversions.VersionResourceSerializer
                    this_param)
                    {
                        var return_v = this_param.GetStringsSize();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 40067, 40083);
                        return return_v;
                    }


                    int
                    f_11_39969_40085(System.IO.BinaryWriter
                    this_param, int
                    value)
                    {
                        this_param.Write((ushort)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 39969, 40085);
                        return 0;
                    }


                    int
                    f_11_40104_40125(System.IO.BinaryWriter
                    this_param, int
                    value)
                    {
                        this_param.Write((ushort)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 40104, 40125);
                        return 0;
                    }


                    int
                    f_11_40144_40165(System.IO.BinaryWriter
                    this_param, int
                    value)
                    {
                        this_param.Write((ushort)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 40144, 40165);
                        return 0;
                    }


                    char[]
                    f_11_40197_40228(string
                    this_param)
                    {
                        var return_v = this_param.ToCharArray();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 40197, 40228);
                        return return_v;
                    }


                    int
                    f_11_40184_40229(System.IO.BinaryWriter
                    this_param, char[]
                    chars)
                    {
                        this_param.Write(chars);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 40184, 40229);
                        return 0;
                    }


                    int
                    f_11_40445_40472(string
                    sz)
                    {
                        var return_v = KEYBYTES(sz);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 40445, 40472);
                        return return_v;
                    }


                    int
                    f_11_40475_40499(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 40475, 40499);
                        return return_v;
                    }


                    int
                    f_11_40423_40505(System.IO.BinaryWriter
                    this_param, byte[]
                    buffer)
                    {
                        this_param.Write(buffer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 40423, 40505);
                        return 0;
                    }


                    System.IO.Stream
                    f_11_40569_40586(System.IO.BinaryWriter
                    this_param)
                    {
                        var return_v = this_param.BaseStream;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 40569, 40586);
                        return return_v;
                    }


                    long
                    f_11_40569_40595(System.IO.Stream
                    this_param)
                    {
                        var return_v = this_param.Position;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 40569, 40595);
                        return return_v;
                    }


                    int
                    f_11_40536_40606(bool
                    condition)
                    {
                        System.Diagnostics.Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 40536, 40606);
                        return 0;
                    }


                    int
                    f_11_40655_40686(string
                    sz)
                    {
                        var return_v = KEYBYTES(sz);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 40655, 40686);
                        return return_v;
                    }


                    int
                    f_11_40689_40705(Microsoft.CodeAnalysis.Win32ResourceConversions.VersionResourceSerializer
                    this_param)
                    {
                        var return_v = this_param.GetStringsSize();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 40689, 40705);
                        return return_v;
                    }


                    int
                    f_11_40625_40707(System.IO.BinaryWriter
                    this_param, int
                    value)
                    {
                        this_param.Write((ushort)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 40625, 40707);
                        return 0;
                    }


                    int
                    f_11_40726_40747(System.IO.BinaryWriter
                    this_param, int
                    value)
                    {
                        this_param.Write((ushort)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 40726, 40747);
                        return 0;
                    }


                    int
                    f_11_40766_40787(System.IO.BinaryWriter
                    this_param, int
                    value)
                    {
                        this_param.Write((ushort)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 40766, 40787);
                        return 0;
                    }


                    char[]
                    f_11_40819_40854(string
                    this_param)
                    {
                        var return_v = this_param.ToCharArray();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 40819, 40854);
                        return return_v;
                    }


                    int
                    f_11_40806_40855(System.IO.BinaryWriter
                    this_param, char[]
                    chars)
                    {
                        this_param.Write(chars);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 40806, 40855);
                        return 0;
                    }


                    int
                    f_11_40896_40927(string
                    sz)
                    {
                        var return_v = KEYBYTES(sz);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 40896, 40927);
                        return return_v;
                    }


                    int
                    f_11_40930_40958(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 40930, 40958);
                        return return_v;
                    }


                    int
                    f_11_40874_40964(System.IO.BinaryWriter
                    this_param, byte[]
                    buffer)
                    {
                        this_param.Write(buffer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 40874, 40964);
                        return 0;
                    }


                    System.IO.Stream
                    f_11_41026_41043(System.IO.BinaryWriter
                    this_param)
                    {
                        var return_v = this_param.BaseStream;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 41026, 41043);
                        return return_v;
                    }


                    long
                    f_11_41026_41052(System.IO.Stream
                    this_param)
                    {
                        var return_v = this_param.Position;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 41026, 41052);
                        return return_v;
                    }


                    int
                    f_11_40993_41063(bool
                    condition)
                    {
                        System.Diagnostics.Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 40993, 41063);
                        return 0;
                    }


                    System.IO.Stream
                    f_11_41116_41133(System.IO.BinaryWriter
                    this_param)
                    {
                        var return_v = this_param.BaseStream;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 41116, 41133);
                        return return_v;
                    }


                    long
                    f_11_41116_41142(System.IO.Stream
                    this_param)
                    {
                        var return_v = this_param.Position;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 41116, 41142);
                        return return_v;
                    }


                    int
                    f_11_41168_41184(Microsoft.CodeAnalysis.Win32ResourceConversions.VersionResourceSerializer
                    this_param)
                    {
                        var return_v = this_param.GetStringsSize();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 41168, 41184);
                        return return_v;
                    }


                    int
                    f_11_41084_41185(bool
                    condition)
                    {
                        System.Diagnostics.Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 41084, 41185);
                        return 0;
                    }


                    System.IO.Stream
                    f_11_41215_41232(System.IO.BinaryWriter
                    this_param)
                    {
                        var return_v = this_param.BaseStream;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 41215, 41232);
                        return return_v;
                    }


                    long
                    f_11_41215_41241(System.IO.Stream
                    this_param)
                    {
                        var return_v = this_param.Position;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 41215, 41241);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>
                    f_11_41284_41299(Microsoft.CodeAnalysis.Win32ResourceConversions.VersionResourceSerializer
                    this_param)
                    {
                        var return_v = this_param.GetVerStrings();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 41284, 41299);
                        return return_v;
                    }


                    System.IO.Stream
                    f_11_41357_41374(System.IO.BinaryWriter
                    this_param)
                    {
                        var return_v = this_param.BaseStream;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 41357, 41374);
                        return return_v;
                    }


                    long
                    f_11_41357_41383(System.IO.Stream
                    this_param)
                    {
                        var return_v = this_param.Position;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 41357, 41383);
                        return return_v;
                    }


                    int
                    f_11_41508_41566(System.IO.BinaryWriter
                    this_param, byte[]
                    buffer)
                    {
                        this_param.Write(buffer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 41508, 41566);
                        return 0;
                    }


                    int
                    f_11_41591_41643(bool
                    condition)
                    {
                        System.Diagnostics.Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 41591, 41643);
                        return 0;
                    }


                    int
                    f_11_41666_41699(System.Collections.Generic.KeyValuePair<string, string>
                    keyValuePair, System.IO.BinaryWriter
                    writer)
                    {
                        WriteVersionString(keyValuePair, writer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 41666, 41699);
                        return 0;
                    }


                    System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>
                    f_11_41284_41299_I(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 41284, 41299);
                        return return_v;
                    }


                    System.IO.Stream
                    f_11_41771_41788(System.IO.BinaryWriter
                    this_param)
                    {
                        var return_v = this_param.BaseStream;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 41771, 41788);
                        return return_v;
                    }


                    long
                    f_11_41771_41797(System.IO.Stream
                    this_param)
                    {
                        var return_v = this_param.Position;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(11, 41771, 41797);
                        return return_v;
                    }


                    int
                    f_11_41812_41828(Microsoft.CodeAnalysis.Win32ResourceConversions.VersionResourceSerializer
                    this_param)
                    {
                        var return_v = this_param.GetStringsSize();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 41812, 41828);
                        return return_v;
                    }


                    int
                    f_11_41739_41829(bool
                    condition)
                    {
                        System.Diagnostics.Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 41739, 41829);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(11, 35177, 41845);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 35177, 41845);
                }
            }

            static VersionResourceSerializer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(11, 24907, 41856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 25669, 25705);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 25741, 25771);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 25807, 25837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 25873, 25909);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 26029, 26049);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 26087, 26128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 27356, 27376);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 27410, 27430);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(11, 31729, 31757);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(11, 24907, 41856);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 24907, 41856);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(11, 24907, 41856);

            static string
            f_11_27227_27305(string
            format, int
            arg0, uint
            arg1)
            {
                var return_v = System.String.Format(format, (object)arg0, (object)arg1);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(11, 27227, 27305);
                return return_v;
            }

        }

        static Win32ResourceConversions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(11, 12178, 41863);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(11, 12178, 41863);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(11, 12178, 41863);
        }

    }
}
