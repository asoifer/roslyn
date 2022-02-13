// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

extern alias DSR;
using System.Collections.Immutable;
using System.Linq;
using DSR::Microsoft.DiaSymReader;
using Microsoft.CodeAnalysis.Debugging;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using Xunit;

namespace Roslyn.Test.Utilities
{
    internal sealed class MethodDebugInfoBytes
    {
        public readonly ImmutableArray<byte> Bytes;

        public readonly ISymUnmanagedMethod Method;

        public MethodDebugInfoBytes(ImmutableArray<byte> bytes, ISymUnmanagedMethod method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(24002, 675, 848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 656, 662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 783, 802);

                this.Bytes = bytes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 816, 837);

                this.Method = method;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(24002, 675, 848);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24002, 675, 848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24002, 675, 848);
            }
        }
        internal sealed class Builder
        {
            private const byte
            Version = 4
            ;

            private const byte
            Padding = 0
            ;

            private readonly ISymUnmanagedMethod _method;

            private ArrayBuilder<byte> _bytesBuilder;

            private int _recordCount;

            public Builder(string[][] importStringGroups = null, bool suppressUsingInfo = false, ISymUnmanagedConstant[] constants = null)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(24002, 1529, 2663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 1409, 1416);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 1460, 1473);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 1500, 1512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 1688, 1737);

                    _bytesBuilder = f_24002_1704_1736();

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 1755, 1990) || true) && (importStringGroups != null && (DynAbs.Tracing.TraceSender.Expression_True(24002, 1759, 1807) && !suppressUsingInfo))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24002, 1755, 1990);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 1849, 1924);

                        var
                        groupSizes = f_24002_1866_1923(f_24002_1866_1913(importStringGroups, g => (short)g.Length))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 1946, 1971);

                        f_24002_1946_1970(this, groupSizes);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24002, 1755, 1990);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 2010, 2289);

                    var
                    namespaces = (DynAbs.Tracing.TraceSender.Conditional_F1(24002, 2027, 2053) || ((importStringGroups == null
                    && DynAbs.Tracing.TraceSender.Conditional_F2(24002, 2077, 2124)) || DynAbs.Tracing.TraceSender.Conditional_F3(24002, 2148, 2288))) ? default(ImmutableArray<ISymUnmanagedNamespace>)
                    : f_24002_2148_2288(f_24002_2148_2269(importStringGroups, names => names.Select(name => (ISymUnmanagedNamespace)new MockSymUnmanagedNamespace(name))))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 2307, 2418);

                    var
                    childScope = f_24002_2324_2417(default(ImmutableArray<ISymUnmanagedScope>), namespaces, constants)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 2436, 2582);

                    var
                    rootScope = f_24002_2452_2581(f_24002_2478_2531(childScope), default(ImmutableArray<ISymUnmanagedNamespace>))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 2600, 2648);

                    _method = f_24002_2610_2647(rootScope);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(24002, 1529, 2663);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24002, 1529, 2663);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24002, 1529, 2663);
                }
            }

            public Builder AddUsingInfo(params short[] groupSizes)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24002, 2679, 3745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 2766, 2804);

                    var
                    numGroupSizes = f_24002_2786_2803(groupSizes)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 2822, 2902);

                    var
                    recordSize = f_24002_2839_2901(4 + 4 + 2 + 2 * numGroupSizes, 4)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 2990, 3017);

                    f_24002_2990_3016(
                                    // Record header
                                    _bytesBuilder, Version);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 3035, 3092);

                    f_24002_3035_3091(_bytesBuilder, CustomDebugInfoKind.UsingGroups);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 3110, 3137);

                    f_24002_3110_3136(_bytesBuilder, Padding);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 3155, 3182);

                    f_24002_3155_3181(_bytesBuilder, Padding);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 3200, 3231);

                    f_24002_3200_3230(_bytesBuilder, recordSize);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 3283, 3324);

                    f_24002_3283_3323(
                                    // Record body
                                    _bytesBuilder, numGroupSizes);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 3342, 3469);
                        foreach (var groupSize in f_24002_3368_3378_I(groupSizes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24002, 3342, 3469);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 3420, 3450);

                            f_24002_3420_3449(_bytesBuilder, groupSize);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(24002, 3342, 3469);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(24002, 1, 128);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(24002, 1, 128);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 3489, 3606) || true) && ((f_24002_3494_3513(_bytesBuilder) % 4) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24002, 3489, 3606);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 3565, 3587);

                        f_24002_3565_3586(_bytesBuilder, 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24002, 3489, 3606);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 3626, 3667);

                    f_24002_3626_3666(0, f_24002_3642_3661(_bytesBuilder) % 4);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 3685, 3700);

                    _recordCount++;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 3718, 3730);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24002, 2679, 3745);

                    int
                    f_24002_2786_2803(short[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24002, 2786, 2803);
                        return return_v;
                    }


                    int
                    f_24002_2839_2901(int
                    position, int
                    alignment)
                    {
                        var return_v = BitArithmeticUtilities.Align(position, alignment);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 2839, 2901);
                        return return_v;
                    }


                    int
                    f_24002_2990_3016(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                    this_param, byte
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 2990, 3016);
                        return 0;
                    }


                    int
                    f_24002_3035_3091(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                    this_param, Microsoft.CodeAnalysis.Debugging.CustomDebugInfoKind
                    item)
                    {
                        this_param.Add((byte)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 3035, 3091);
                        return 0;
                    }


                    int
                    f_24002_3110_3136(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                    this_param, byte
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 3110, 3136);
                        return 0;
                    }


                    int
                    f_24002_3155_3181(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                    this_param, byte
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 3155, 3181);
                        return 0;
                    }


                    int
                    f_24002_3200_3230(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                    bytes, int
                    i)
                    {
                        bytes.Add4(i);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 3200, 3230);
                        return 0;
                    }


                    int
                    f_24002_3283_3323(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                    bytes, int
                    s)
                    {
                        bytes.Add2((short)s);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 3283, 3323);
                        return 0;
                    }


                    int
                    f_24002_3420_3449(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                    bytes, short
                    s)
                    {
                        bytes.Add2(s);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 3420, 3449);
                        return 0;
                    }


                    short[]
                    f_24002_3368_3378_I(short[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 3368, 3378);
                        return return_v;
                    }


                    int
                    f_24002_3494_3513(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24002, 3494, 3513);
                        return return_v;
                    }


                    int
                    f_24002_3565_3586(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                    bytes, int
                    s)
                    {
                        bytes.Add2((short)s);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 3565, 3586);
                        return 0;
                    }


                    int
                    f_24002_3642_3661(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24002, 3642, 3661);
                        return return_v;
                    }


                    int
                    f_24002_3626_3666(int
                    expected, int
                    actual)
                    {
                        Assert.Equal(expected, actual);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 3626, 3666);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24002, 2679, 3745);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24002, 2679, 3745);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public Builder AddForward(int targetToken)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24002, 3761, 3904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 3836, 3889);

                    return f_24002_3843_3888(this, targetToken, isModuleLevel: false);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24002, 3761, 3904);

                    Roslyn.Test.Utilities.MethodDebugInfoBytes.Builder
                    f_24002_3843_3888(Roslyn.Test.Utilities.MethodDebugInfoBytes.Builder
                    this_param, int
                    targetToken, bool
                    isModuleLevel)
                    {
                        var return_v = this_param.AddForward(targetToken, isModuleLevel: isModuleLevel);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 3843, 3888);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24002, 3761, 3904);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24002, 3761, 3904);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public Builder AddModuleForward(int targetToken)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24002, 3920, 4068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 4001, 4053);

                    return f_24002_4008_4052(this, targetToken, isModuleLevel: true);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24002, 3920, 4068);

                    Roslyn.Test.Utilities.MethodDebugInfoBytes.Builder
                    f_24002_4008_4052(Roslyn.Test.Utilities.MethodDebugInfoBytes.Builder
                    this_param, int
                    targetToken, bool
                    isModuleLevel)
                    {
                        var return_v = this_param.AddForward(targetToken, isModuleLevel: isModuleLevel);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 4008, 4052);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24002, 3920, 4068);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24002, 3920, 4068);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private Builder AddForward(int targetToken, bool isModuleLevel)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24002, 4084, 4768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 4214, 4241);

                    f_24002_4214_4240(                // Record header
                                    _bytesBuilder, Version);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 4259, 4380);

                    f_24002_4259_4379(_bytesBuilder, ((DynAbs.Tracing.TraceSender.Conditional_F1(24002, 4284, 4297) || ((isModuleLevel && DynAbs.Tracing.TraceSender.Conditional_F2(24002, 4300, 4337)) || DynAbs.Tracing.TraceSender.Conditional_F3(24002, 4340, 4377))) ? CustomDebugInfoKind.ForwardModuleInfo : CustomDebugInfoKind.ForwardMethodInfo));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 4398, 4425);

                    f_24002_4398_4424(_bytesBuilder, Padding);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 4443, 4470);

                    f_24002_4443_4469(_bytesBuilder, Padding);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 4488, 4511);

                    f_24002_4488_4510(_bytesBuilder, 12);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 4597, 4629);

                    f_24002_4597_4628(
                                    // Record body
                                    _bytesBuilder, targetToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 4649, 4690);

                    f_24002_4649_4689(0, f_24002_4665_4684(_bytesBuilder) % 4);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 4708, 4723);

                    _recordCount++;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 4741, 4753);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24002, 4084, 4768);

                    int
                    f_24002_4214_4240(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                    this_param, byte
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 4214, 4240);
                        return 0;
                    }


                    int
                    f_24002_4259_4379(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                    this_param, Microsoft.CodeAnalysis.Debugging.CustomDebugInfoKind
                    item)
                    {
                        this_param.Add((byte)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 4259, 4379);
                        return 0;
                    }


                    int
                    f_24002_4398_4424(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                    this_param, byte
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 4398, 4424);
                        return 0;
                    }


                    int
                    f_24002_4443_4469(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                    this_param, byte
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 4443, 4469);
                        return 0;
                    }


                    int
                    f_24002_4488_4510(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                    bytes, int
                    i)
                    {
                        bytes.Add4(i);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 4488, 4510);
                        return 0;
                    }


                    int
                    f_24002_4597_4628(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                    bytes, int
                    i)
                    {
                        bytes.Add4(i);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 4597, 4628);
                        return 0;
                    }


                    int
                    f_24002_4665_4684(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24002, 4665, 4684);
                        return return_v;
                    }


                    int
                    f_24002_4649_4689(int
                    expected, int
                    actual)
                    {
                        Assert.Equal(expected, actual);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 4649, 4689);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24002, 4084, 4768);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24002, 4084, 4768);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public MethodDebugInfoBytes Build()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24002, 4784, 5379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 4886, 4919);

                    f_24002_4886_4918(                // Global header
                                    _bytesBuilder, 0, Version);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 4937, 4981);

                    f_24002_4937_4980(_bytesBuilder, 1, _recordCount);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 4999, 5032);

                    f_24002_4999_5031(_bytesBuilder, 2, Padding);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 5050, 5083);

                    f_24002_5050_5082(_bytesBuilder, 3, Padding);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 5103, 5144);

                    f_24002_5103_5143(0, f_24002_5119_5138(_bytesBuilder) % 4);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 5164, 5245);

                    var
                    info = f_24002_5175_5244(f_24002_5200_5234(_bytesBuilder), _method)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 5263, 5284);

                    _bytesBuilder = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 5352, 5364);

                    return info;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24002, 4784, 5379);

                    int
                    f_24002_4886_4918(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                    this_param, int
                    index, byte
                    item)
                    {
                        this_param.Insert(index, item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 4886, 4918);
                        return 0;
                    }


                    int
                    f_24002_4937_4980(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                    this_param, int
                    index, int
                    item)
                    {
                        this_param.Insert(index, (byte)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 4937, 4980);
                        return 0;
                    }


                    int
                    f_24002_4999_5031(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                    this_param, int
                    index, byte
                    item)
                    {
                        this_param.Insert(index, item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 4999, 5031);
                        return 0;
                    }


                    int
                    f_24002_5050_5082(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                    this_param, int
                    index, byte
                    item)
                    {
                        this_param.Insert(index, item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 5050, 5082);
                        return 0;
                    }


                    int
                    f_24002_5119_5138(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24002, 5119, 5138);
                        return return_v;
                    }


                    int
                    f_24002_5103_5143(int
                    expected, int
                    actual)
                    {
                        Assert.Equal(expected, actual);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 5103, 5143);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<byte>
                    f_24002_5200_5234(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 5200, 5234);
                        return return_v;
                    }


                    Roslyn.Test.Utilities.MethodDebugInfoBytes
                    f_24002_5175_5244(System.Collections.Immutable.ImmutableArray<byte>
                    bytes, ISymUnmanagedMethod
                    method)
                    {
                        var return_v = new Roslyn.Test.Utilities.MethodDebugInfoBytes(bytes, method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 5175, 5244);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24002, 4784, 5379);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24002, 4784, 5379);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static Builder()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24002, 1226, 5390);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 1299, 1310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24002, 1344, 1355);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24002, 1226, 5390);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24002, 1226, 5390);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(24002, 1226, 5390);

            Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
            f_24002_1704_1736()
            {
                var return_v = ArrayBuilder<byte>.GetInstance();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 1704, 1736);
                return return_v;
            }


            System.Collections.Generic.IEnumerable<short>
            f_24002_1866_1913(string[][]
            source, System.Func<string[], short>
            selector)
            {
                var return_v = source.Select<string[], short>(selector);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 1866, 1913);
                return return_v;
            }


            short[]
            f_24002_1866_1923(System.Collections.Generic.IEnumerable<short>
            source)
            {
                var return_v = source.ToArray<short>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 1866, 1923);
                return return_v;
            }


            Roslyn.Test.Utilities.MethodDebugInfoBytes.Builder
            f_24002_1946_1970(Roslyn.Test.Utilities.MethodDebugInfoBytes.Builder
            this_param, params short[]
            groupSizes)
            {
                var return_v = this_param.AddUsingInfo(groupSizes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 1946, 1970);
                return return_v;
            }


            System.Collections.Generic.IEnumerable<ISymUnmanagedNamespace>
            f_24002_2148_2269(string[][]
            source, System.Func<string[], System.Collections.Generic.IEnumerable<ISymUnmanagedNamespace>>
            selector)
            {
                var return_v = source.SelectMany<string[], ISymUnmanagedNamespace>(selector);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 2148, 2269);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<ISymUnmanagedNamespace>
            f_24002_2148_2288(System.Collections.Generic.IEnumerable<ISymUnmanagedNamespace>
            items)
            {
                var return_v = items.ToImmutableArray<ISymUnmanagedNamespace>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 2148, 2288);
                return return_v;
            }


            Roslyn.Test.Utilities.MockSymUnmanagedScope
            f_24002_2324_2417(System.Collections.Immutable.ImmutableArray<ISymUnmanagedScope>
            children, System.Collections.Immutable.ImmutableArray<ISymUnmanagedNamespace>
            namespaces, ISymUnmanagedConstant[]?
            constants)
            {
                var return_v = new Roslyn.Test.Utilities.MockSymUnmanagedScope(children, namespaces, constants);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 2324, 2417);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<ISymUnmanagedScope>
            f_24002_2478_2531(Roslyn.Test.Utilities.MockSymUnmanagedScope
            item)
            {
                var return_v = ImmutableArray.Create<ISymUnmanagedScope>((ISymUnmanagedScope)item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 2478, 2531);
                return return_v;
            }


            Roslyn.Test.Utilities.MockSymUnmanagedScope
            f_24002_2452_2581(System.Collections.Immutable.ImmutableArray<ISymUnmanagedScope>
            children, System.Collections.Immutable.ImmutableArray<ISymUnmanagedNamespace>
            namespaces)
            {
                var return_v = new Roslyn.Test.Utilities.MockSymUnmanagedScope(children, namespaces);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 2452, 2581);
                return return_v;
            }


            Roslyn.Test.Utilities.MockSymUnmanagedMethod
            f_24002_2610_2647(Roslyn.Test.Utilities.MockSymUnmanagedScope
            rootScope)
            {
                var return_v = new Roslyn.Test.Utilities.MockSymUnmanagedMethod((ISymUnmanagedScope)rootScope);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(24002, 2610, 2647);
                return return_v;
            }

        }

        static MethodDebugInfoBytes()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24002, 508, 5397);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24002, 508, 5397);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24002, 508, 5397);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(24002, 508, 5397);
    }
}
