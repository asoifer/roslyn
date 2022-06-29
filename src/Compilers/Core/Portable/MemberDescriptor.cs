// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Roslyn.Utilities;
using System;
using System.Collections.Immutable;
using System.IO;
using System.Reflection.Metadata;

namespace Microsoft.CodeAnalysis.RuntimeMembers
{
    [Flags()]
    internal enum MemberFlags : byte
    {
        // BEGIN Mutually exclusive Member kinds:
        Method = 0x01,
        Field = 0x02,
        Constructor = 0x04,
        PropertyGet = 0x08,
        Property = 0x10,
        // END Mutually exclusive Member kinds

        KindMask = 0x1F,

        Static = 0x20,
        Virtual = 0x40, // Virtual in CLR terms, i.e. sealed should be accepted.
    }

    internal readonly struct MemberDescriptor
    {

        public readonly MemberFlags Flags;

        public readonly short DeclaringTypeId;

        public string? DeclaringTypeMetadataName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(23, 1696, 1956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 1732, 1941);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(23, 1739, 1780) || ((DeclaringTypeId <= (int)SpecialType.Count
                    && DynAbs.Tracing.TraceSender.Conditional_F2(23, 1811, 1859)) || DynAbs.Tracing.TraceSender.Conditional_F3(23, 1890, 1940))) ? f_23_1811_1859(((SpecialType)DeclaringTypeId)) : f_23_1890_1940(((WellKnownType)DeclaringTypeId));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(23, 1696, 1956);

                    string?
                    f_23_1811_1859(SpecialType
                    id)
                    {
                        var return_v = id.GetMetadataName();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(23, 1811, 1859);
                        return return_v;
                    }


                    string
                    f_23_1890_1940(WellKnownType
                    id)
                    {
                        var return_v = id.GetMetadataName();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(23, 1890, 1940);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23, 1631, 1967);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23, 1631, 1967);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public readonly ushort Arity;

        public readonly string Name;

        public readonly ImmutableArray<byte> Signature;

        public int ParametersCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(23, 2951, 3482);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 2987, 3041);

                    MemberFlags
                    memberKind = Flags & MemberFlags.KindMask
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 3059, 3467);

                    switch (memberKind)
                    {

                        case MemberFlags.Constructor:
                        case MemberFlags.Method:
                        case MemberFlags.PropertyGet:
                        case MemberFlags.Property:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(23, 3059, 3467);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 3319, 3339);

                            return Signature[0];
                            DynAbs.Tracing.TraceSender.TraceExitCondition(23, 3059, 3467);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(23, 3059, 3467);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 3395, 3448);

                            throw f_23_3401_3447(memberKind);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(23, 3059, 3467);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(23, 2951, 3482);

                    System.Exception
                    f_23_3401_3447(Microsoft.CodeAnalysis.RuntimeMembers.MemberFlags
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(23, 3401, 3447);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23, 2900, 3493);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23, 2900, 3493);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public MemberDescriptor(
                    MemberFlags Flags,
                    short DeclaringTypeId,
                    string Name,
                    ImmutableArray<byte> Signature,
                    ushort Arity = 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(23, 3505, 3912);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 3724, 3743);

                this.Flags = Flags;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 3757, 3796);

                this.DeclaringTypeId = DeclaringTypeId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 3810, 3827);

                this.Name = Name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 3841, 3860);

                this.Arity = Arity;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 3874, 3901);

                this.Signature = Signature;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(23, 3505, 3912);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23, 3505, 3912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23, 3505, 3912);
            }
        }

        internal static ImmutableArray<MemberDescriptor> InitializeFromStream(Stream stream, string[] nameTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23, 3924, 5097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 4053, 4082);

                int
                count = f_23_4065_4081(nameTable)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 4098, 4166);

                var
                builder = f_23_4112_4165(count)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 4180, 4240);

                var
                signatureBuilder = f_23_4203_4239()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 4265, 4270);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 4256, 5041) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 4283, 4286)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(23, 4256, 5041))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(23, 4256, 5041);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 4320, 4371);

                        MemberFlags
                        flags = (MemberFlags)f_23_4353_4370(stream)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 4389, 4432);

                        short
                        declaringTypeId = ReadTypeId(stream)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 4450, 4491);

                        ushort
                        arity = (ushort)f_23_4473_4490(stream)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 4511, 4852) || true) && ((flags & MemberFlags.Field) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(23, 4511, 4852);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 4589, 4625);

                            ParseType(signatureBuilder, stream);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(23, 4511, 4852);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(23, 4511, 4852);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 4776, 4833);

                            ParseMethodOrPropertySignature(signatureBuilder, stream);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(23, 4511, 4852);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 4872, 4983);

                        f_23_4872_4982(
                                        builder, f_23_4884_4981(flags, declaringTypeId, nameTable[i], f_23_4943_4973(signatureBuilder), arity));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 5001, 5026);

                        f_23_5001_5025(signatureBuilder);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(23, 1, 786);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(23, 1, 786);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 5057, 5086);

                return f_23_5064_5085(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23, 3924, 5097);

                int
                f_23_4065_4081(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23, 4065, 4081);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor>.Builder
                f_23_4112_4165(int
                initialCapacity)
                {
                    var return_v = ImmutableArray.CreateBuilder<MemberDescriptor>(initialCapacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23, 4112, 4165);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>.Builder
                f_23_4203_4239()
                {
                    var return_v = ImmutableArray.CreateBuilder<byte>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23, 4203, 4239);
                    return return_v;
                }


                int
                f_23_4353_4370(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23, 4353, 4370);
                    return return_v;
                }


                int
                f_23_4473_4490(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23, 4473, 4490);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_23_4943_4973(System.Collections.Immutable.ImmutableArray<byte>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23, 4943, 4973);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor
                f_23_4884_4981(Microsoft.CodeAnalysis.RuntimeMembers.MemberFlags
                Flags, short
                DeclaringTypeId, string
                Name, System.Collections.Immutable.ImmutableArray<byte>
                Signature, ushort
                Arity)
                {
                    var return_v = new Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor(Flags, DeclaringTypeId, Name, Signature, Arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23, 4884, 4981);
                    return return_v;
                }


                int
                f_23_4872_4982(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor>.Builder
                this_param, Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23, 4872, 4982);
                    return 0;
                }


                int
                f_23_5001_5025(System.Collections.Immutable.ImmutableArray<byte>.Builder
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23, 5001, 5025);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor>
                f_23_5064_5085(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23, 5064, 5085);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23, 3924, 5097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23, 3924, 5097);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static short ReadTypeId(Stream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23, 5342, 5722);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 5413, 5453);

                var
                firstByte = (byte)f_23_5435_5452(stream)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 5469, 5711) || true) && (firstByte == (byte)WellKnownType.ExtSentinel)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23, 5469, 5711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 5551, 5613);

                    return (short)(f_23_5566_5583(stream) + WellKnownType.ExtSentinel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23, 5469, 5711);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23, 5469, 5711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 5679, 5696);

                    return firstByte;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23, 5469, 5711);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23, 5342, 5722);

                int
                f_23_5435_5452(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23, 5435, 5452);
                    return return_v;
                }


                int
                f_23_5566_5583(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23, 5566, 5583);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23, 5342, 5722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23, 5342, 5722);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ParseMethodOrPropertySignature(ImmutableArray<byte>.Builder builder, Stream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23, 5734, 6213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 5862, 5897);

                int
                paramCount = f_23_5879_5896(stream)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 5911, 5941);

                f_23_5911_5940(builder, paramCount);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 5985, 6030);

                ParseType(builder, stream, allowByRef: true);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 6082, 6087);

                    // Parameters
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 6073, 6202) || true) && (i < paramCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 6105, 6108)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(23, 6073, 6202))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(23, 6073, 6202);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 6142, 6187);

                        ParseType(builder, stream, allowByRef: true);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(23, 1, 130);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(23, 1, 130);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23, 5734, 6213);

                int
                f_23_5879_5896(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23, 5879, 5896);
                    return return_v;
                }


                int
                f_23_5911_5940(System.Collections.Immutable.ImmutableArray<byte>.Builder
                this_param, int
                item)
                {
                    this_param.Add((byte)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23, 5911, 5940);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23, 5734, 6213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23, 5734, 6213);
            }
        }

        private static void ParseType(ImmutableArray<byte>.Builder builder, Stream stream, bool allowByRef = false)
        {
            while (true)
            {
                var typeCode = (SignatureTypeCode)stream.ReadByte();
                builder.Add((byte)typeCode);

                switch (typeCode)
                {
                    default:
                        throw ExceptionUtilities.UnexpectedValue(typeCode);

                    case SignatureTypeCode.TypeHandle:
                        ParseTypeHandle(builder, stream);
                        return;

                    case SignatureTypeCode.GenericTypeParameter:
                    case SignatureTypeCode.GenericMethodParameter:
                        builder.Add((byte)stream.ReadByte());
                        return;

                    case SignatureTypeCode.ByReference:
                        if (!allowByRef) goto default;
                        break;

                    case SignatureTypeCode.SZArray:
                        break;

                    case SignatureTypeCode.Pointer:
                        break;

                    case SignatureTypeCode.GenericTypeInstance:
                        ParseGenericTypeInstance(builder, stream);
                        return;
                }

                allowByRef = false;
            }
        }

        private static void ParseTypeHandle(ImmutableArray<byte>.Builder builder, Stream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23, 7823, 8220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 7936, 7976);

                var
                firstByte = (byte)f_23_7958_7975(stream)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 7990, 8013);

                f_23_7990_8012(builder, firstByte);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 8029, 8209) || true) && (firstByte == (byte)WellKnownType.ExtSentinel)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23, 8029, 8209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 8111, 8152);

                    var
                    secondByte = (byte)f_23_8134_8151(stream)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 8170, 8194);

                    f_23_8170_8193(builder, secondByte);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23, 8029, 8209);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23, 7823, 8220);

                int
                f_23_7958_7975(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23, 7958, 7975);
                    return return_v;
                }


                int
                f_23_7990_8012(System.Collections.Immutable.ImmutableArray<byte>.Builder
                this_param, byte
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23, 7990, 8012);
                    return 0;
                }


                int
                f_23_8134_8151(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23, 8134, 8151);
                    return return_v;
                }


                int
                f_23_8170_8193(System.Collections.Immutable.ImmutableArray<byte>.Builder
                this_param, byte
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23, 8170, 8193);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23, 7823, 8220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23, 7823, 8220);
            }
        }

        private static void ParseGenericTypeInstance(ImmutableArray<byte>.Builder builder, Stream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23, 8232, 8661);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 8354, 8381);

                ParseType(builder, stream);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 8437, 8475);

                int
                argumentCount = f_23_8457_8474(stream)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 8489, 8522);

                f_23_8489_8521(builder, argumentCount);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 8545, 8550);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 8536, 8650) || true) && (i < argumentCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 8571, 8574)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(23, 8536, 8650))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(23, 8536, 8650);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23, 8608, 8635);

                        ParseType(builder, stream);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(23, 1, 115);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(23, 1, 115);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23, 8232, 8661);

                int
                f_23_8457_8474(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23, 8457, 8474);
                    return return_v;
                }


                int
                f_23_8489_8521(System.Collections.Immutable.ImmutableArray<byte>.Builder
                this_param, int
                item)
                {
                    this_param.Add((byte)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23, 8489, 8521);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23, 8232, 8661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23, 8232, 8661);
            }
        }
        static MemberDescriptor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23, 924, 8668);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23, 924, 8668);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23, 924, 8668);
        }
    }
}
