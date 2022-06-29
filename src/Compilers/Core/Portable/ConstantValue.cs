// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal enum ConstantValueTypeDiscriminator : byte
    {
        Nothing,
        Null = Nothing,
        Bad,
        SByte,
        Byte,
        Int16,
        UInt16,
        Int32,
        UInt32,
        Int64,
        UInt64,
        NInt,
        NUInt,
        Char,
        Boolean,
        Single,
        Double,
        String,
        Decimal,
        DateTime,
    }
    internal abstract partial class ConstantValue : IEquatable<ConstantValue?>
    {
        public abstract ConstantValueTypeDiscriminator Discriminator { get; }

        internal abstract SpecialType SpecialType { get; }

        public virtual string? StringValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 1074, 1120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 1080, 1118);

                    throw f_8_1086_1117();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 1074, 1120);

                    System.InvalidOperationException
                    f_8_1086_1117()
                    {
                        var return_v = new System.InvalidOperationException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 1086, 1117);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 1037, 1122);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 1037, 1122);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual Rope? RopeValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 1167, 1213);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 1173, 1211);

                    throw f_8_1179_1210();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 1167, 1213);

                    System.InvalidOperationException
                    f_8_1179_1210()
                    {
                        var return_v = new System.InvalidOperationException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 1179, 1210);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 1132, 1215);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 1132, 1215);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual bool BooleanValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 1262, 1308);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 1268, 1306);

                    throw f_8_1274_1305();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 1262, 1308);

                    System.InvalidOperationException
                    f_8_1274_1305()
                    {
                        var return_v = new System.InvalidOperationException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 1274, 1305);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 1227, 1310);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 1227, 1310);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual sbyte SByteValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 1356, 1402);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 1362, 1400);

                    throw f_8_1368_1399();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 1356, 1402);

                    System.InvalidOperationException
                    f_8_1368_1399()
                    {
                        var return_v = new System.InvalidOperationException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 1368, 1399);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 1322, 1404);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 1322, 1404);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual byte ByteValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 1446, 1492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 1452, 1490);

                    throw f_8_1458_1489();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 1446, 1492);

                    System.InvalidOperationException
                    f_8_1458_1489()
                    {
                        var return_v = new System.InvalidOperationException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 1458, 1489);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 1414, 1494);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 1414, 1494);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual short Int16Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 2327, 2353);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 2333, 2351);

                    return f_8_2340_2350();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 2327, 2353);

                    sbyte
                    f_8_2340_2350()
                    {
                        var return_v = SByteValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 2340, 2350);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 2293, 2355);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 2293, 2355);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual ushort UInt16Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 2401, 2426);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 2407, 2424);

                    return f_8_2414_2423();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 2401, 2426);

                    byte
                    f_8_2414_2423()
                    {
                        var return_v = ByteValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 2414, 2423);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 2365, 2428);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 2365, 2428);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual int Int32Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 2472, 2498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 2478, 2496);

                    return f_8_2485_2495();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 2472, 2498);

                    short
                    f_8_2485_2495()
                    {
                        var return_v = Int16Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 2485, 2495);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 2440, 2500);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 2440, 2500);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual uint UInt32Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 2544, 2571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 2550, 2569);

                    return f_8_2557_2568();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 2544, 2571);

                    ushort
                    f_8_2557_2568()
                    {
                        var return_v = UInt16Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 2557, 2568);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 2510, 2573);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 2510, 2573);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual long Int64Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 2618, 2644);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 2624, 2642);

                    return f_8_2631_2641();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 2618, 2644);

                    int
                    f_8_2631_2641()
                    {
                        var return_v = Int32Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 2631, 2641);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 2585, 2646);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 2585, 2646);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual ulong UInt64Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 2691, 2718);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 2697, 2716);

                    return f_8_2704_2715();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 2691, 2718);

                    uint
                    f_8_2704_2715()
                    {
                        var return_v = UInt32Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 2704, 2715);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 2656, 2720);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 2656, 2720);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual char CharValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 2764, 2810);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 2770, 2808);

                    throw f_8_2776_2807();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 2764, 2810);

                    System.InvalidOperationException
                    f_8_2776_2807()
                    {
                        var return_v = new System.InvalidOperationException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 2776, 2807);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 2732, 2812);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 2732, 2812);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual decimal DecimalValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 2860, 2906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 2866, 2904);

                    throw f_8_2872_2903();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 2860, 2906);

                    System.InvalidOperationException
                    f_8_2872_2903()
                    {
                        var return_v = new System.InvalidOperationException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 2872, 2903);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 2822, 2908);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 2822, 2908);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual DateTime DateTimeValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 2958, 3004);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 2964, 3002);

                    throw f_8_2970_3001();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 2958, 3004);

                    System.InvalidOperationException
                    f_8_2970_3001()
                    {
                        var return_v = new System.InvalidOperationException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 2970, 3001);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 2918, 3006);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 2918, 3006);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual double DoubleValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 3054, 3100);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 3060, 3098);

                    throw f_8_3066_3097();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 3054, 3100);

                    System.InvalidOperationException
                    f_8_3066_3097()
                    {
                        var return_v = new System.InvalidOperationException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 3066, 3097);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 3018, 3102);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 3018, 3102);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual float SingleValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 3147, 3193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 3153, 3191);

                    throw f_8_3159_3190();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 3147, 3193);

                    System.InvalidOperationException
                    f_8_3159_3190()
                    {
                        var return_v = new System.InvalidOperationException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 3159, 3190);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 3112, 3195);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 3112, 3195);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual bool IsDefaultValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 3316, 3337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 3322, 3335);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 3316, 3337);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 3279, 3339);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 3279, 3339);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public const ConstantValue
        NotAvailable = null
        ;

        public static ConstantValue Bad
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 3842, 3883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 3848, 3881);

                    return ConstantValueBad.Instance;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 3842, 3883);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 3808, 3885);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 3808, 3885);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ConstantValue Null
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 3930, 3972);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 3936, 3970);

                    return ConstantValueNull.Instance;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 3930, 3972);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 3895, 3974);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 3895, 3974);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ConstantValue Nothing
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 4022, 4042);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 4028, 4040);

                    return f_8_4035_4039();
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 4022, 4042);

                    Microsoft.CodeAnalysis.ConstantValue
                    f_8_4035_4039()
                    {
                        var return_v = Null;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 4035, 4039);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 3984, 4044);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 3984, 4044);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ConstantValue Unset
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 4305, 4352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 4311, 4350);

                    return ConstantValueNull.Uninitialized;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 4305, 4352);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 4269, 4354);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 4269, 4354);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ConstantValue True
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 4401, 4441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 4407, 4439);

                    return ConstantValueOne.Boolean;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 4401, 4441);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 4366, 4443);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 4366, 4443);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ConstantValue False
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 4489, 4533);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 4495, 4531);

                    return ConstantValueDefault.Boolean;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 4489, 4533);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 4453, 4535);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 4453, 4535);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ConstantValue Create(string? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 4547, 4764);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 4621, 4699) || true) && (value == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 4621, 4699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 4672, 4684);

                    return f_8_4679_4683();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 4621, 4699);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 4715, 4753);

                return f_8_4722_4752(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 4547, 4764);

                Microsoft.CodeAnalysis.ConstantValue
                f_8_4679_4683()
                {
                    var return_v = Null;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 4679, 4683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue.ConstantValueString
                f_8_4722_4752(string
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueString(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 4722, 4752);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 4547, 4764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 4547, 4764);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ConstantValue CreateFromRope(Rope value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 4776, 4954);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 4857, 4891);

                f_8_4857_4890(value != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 4905, 4943);

                return f_8_4912_4942(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 4776, 4954);

                int
                f_8_4857_4890(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 4857, 4890);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue.ConstantValueString
                f_8_4912_4942(Microsoft.CodeAnalysis.Rope
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueString(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 4912, 4942);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 4776, 4954);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 4776, 4954);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ConstantValue Create(char value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 4966, 5207);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 5037, 5145) || true) && (value == default(char))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 5037, 5145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 5097, 5130);

                    return ConstantValueDefault.Char;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 5037, 5145);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 5161, 5196);

                return f_8_5168_5195(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 4966, 5207);

                Microsoft.CodeAnalysis.ConstantValue.ConstantValueI16
                f_8_5168_5195(char
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueI16(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 5168, 5195);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 4966, 5207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 4966, 5207);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ConstantValue Create(sbyte value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 5219, 5561);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 5291, 5500) || true) && (value == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 5291, 5500);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 5339, 5373);

                    return ConstantValueDefault.SByte;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 5291, 5500);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 5291, 5500);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 5407, 5500) || true) && (value == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 5407, 5500);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 5455, 5485);

                        return ConstantValueOne.SByte;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 5407, 5500);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 5291, 5500);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 5516, 5550);

                return f_8_5523_5549(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 5219, 5561);

                Microsoft.CodeAnalysis.ConstantValue.ConstantValueI8
                f_8_5523_5549(sbyte
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueI8(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 5523, 5549);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 5219, 5561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 5219, 5561);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ConstantValue Create(byte value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 5573, 5912);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 5644, 5851) || true) && (value == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 5644, 5851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 5692, 5725);

                    return ConstantValueDefault.Byte;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 5644, 5851);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 5644, 5851);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 5759, 5851) || true) && (value == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 5759, 5851);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 5807, 5836);

                        return ConstantValueOne.Byte;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 5759, 5851);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 5644, 5851);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 5867, 5901);

                return f_8_5874_5900(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 5573, 5912);

                Microsoft.CodeAnalysis.ConstantValue.ConstantValueI8
                f_8_5874_5900(byte
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueI8(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 5874, 5900);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 5573, 5912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 5573, 5912);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ConstantValue Create(Int16 value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 5924, 6267);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 5996, 6205) || true) && (value == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 5996, 6205);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 6044, 6078);

                    return ConstantValueDefault.Int16;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 5996, 6205);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 5996, 6205);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 6112, 6205) || true) && (value == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 6112, 6205);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 6160, 6190);

                        return ConstantValueOne.Int16;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 6112, 6205);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 5996, 6205);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 6221, 6256);

                return f_8_6228_6255(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 5924, 6267);

                Microsoft.CodeAnalysis.ConstantValue.ConstantValueI16
                f_8_6228_6255(short
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueI16(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 6228, 6255);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 5924, 6267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 5924, 6267);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ConstantValue Create(UInt16 value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 6279, 6625);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 6352, 6563) || true) && (value == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 6352, 6563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 6400, 6435);

                    return ConstantValueDefault.UInt16;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 6352, 6563);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 6352, 6563);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 6469, 6563) || true) && (value == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 6469, 6563);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 6517, 6548);

                        return ConstantValueOne.UInt16;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 6469, 6563);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 6352, 6563);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 6579, 6614);

                return f_8_6586_6613(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 6279, 6625);

                Microsoft.CodeAnalysis.ConstantValue.ConstantValueI16
                f_8_6586_6613(ushort
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueI16(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 6586, 6613);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 6279, 6625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 6279, 6625);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ConstantValue Create(Int32 value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 6637, 6980);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 6709, 6918) || true) && (value == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 6709, 6918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 6757, 6791);

                    return ConstantValueDefault.Int32;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 6709, 6918);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 6709, 6918);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 6825, 6918) || true) && (value == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 6825, 6918);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 6873, 6903);

                        return ConstantValueOne.Int32;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 6825, 6918);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 6709, 6918);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 6934, 6969);

                return f_8_6941_6968(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 6637, 6980);

                Microsoft.CodeAnalysis.ConstantValue.ConstantValueI32
                f_8_6941_6968(int
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueI32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 6941, 6968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 6637, 6980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 6637, 6980);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ConstantValue Create(UInt32 value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 6992, 7338);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 7065, 7276) || true) && (value == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 7065, 7276);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 7113, 7148);

                    return ConstantValueDefault.UInt32;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 7065, 7276);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 7065, 7276);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 7182, 7276) || true) && (value == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 7182, 7276);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 7230, 7261);

                        return ConstantValueOne.UInt32;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 7182, 7276);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 7065, 7276);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 7292, 7327);

                return f_8_7299_7326(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 6992, 7338);

                Microsoft.CodeAnalysis.ConstantValue.ConstantValueI32
                f_8_7299_7326(uint
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueI32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 7299, 7326);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 6992, 7338);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 6992, 7338);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ConstantValue Create(Int64 value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 7350, 7693);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 7422, 7631) || true) && (value == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 7422, 7631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 7470, 7504);

                    return ConstantValueDefault.Int64;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 7422, 7631);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 7422, 7631);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 7538, 7631) || true) && (value == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 7538, 7631);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 7586, 7616);

                        return ConstantValueOne.Int64;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 7538, 7631);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 7422, 7631);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 7647, 7682);

                return f_8_7654_7681(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 7350, 7693);

                Microsoft.CodeAnalysis.ConstantValue.ConstantValueI64
                f_8_7654_7681(long
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueI64(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 7654, 7681);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 7350, 7693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 7350, 7693);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ConstantValue Create(UInt64 value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 7705, 8051);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 7778, 7989) || true) && (value == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 7778, 7989);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 7826, 7861);

                    return ConstantValueDefault.UInt64;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 7778, 7989);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 7778, 7989);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 7895, 7989) || true) && (value == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 7895, 7989);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 7943, 7974);

                        return ConstantValueOne.UInt64;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 7895, 7989);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 7778, 7989);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 8005, 8040);

                return f_8_8012_8039(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 7705, 8051);

                Microsoft.CodeAnalysis.ConstantValue.ConstantValueI64
                f_8_8012_8039(ulong
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueI64(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 8012, 8039);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 7705, 8051);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 7705, 8051);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ConstantValue CreateNativeInt(Int32 value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 8063, 8419);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 8144, 8351) || true) && (value == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 8144, 8351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 8192, 8225);

                    return ConstantValueDefault.NInt;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 8144, 8351);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 8144, 8351);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 8259, 8351) || true) && (value == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 8259, 8351);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 8307, 8336);

                        return ConstantValueOne.NInt;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 8259, 8351);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 8144, 8351);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 8367, 8408);

                return f_8_8374_8407(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 8063, 8419);

                Microsoft.CodeAnalysis.ConstantValue.ConstantValueNativeInt
                f_8_8374_8407(int
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueNativeInt(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 8374, 8407);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 8063, 8419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 8063, 8419);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ConstantValue CreateNativeUInt(UInt32 value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 8431, 8791);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 8514, 8723) || true) && (value == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 8514, 8723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 8562, 8596);

                    return ConstantValueDefault.NUInt;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 8514, 8723);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 8514, 8723);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 8630, 8723) || true) && (value == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 8630, 8723);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 8678, 8708);

                        return ConstantValueOne.NUInt;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 8630, 8723);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 8514, 8723);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 8739, 8780);

                return f_8_8746_8779(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 8431, 8791);

                Microsoft.CodeAnalysis.ConstantValue.ConstantValueNativeInt
                f_8_8746_8779(uint
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueNativeInt(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 8746, 8779);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 8431, 8791);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 8431, 8791);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ConstantValue Create(bool value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 8803, 9077);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 8874, 9066) || true) && (value)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 8874, 9066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 8917, 8949);

                    return ConstantValueOne.Boolean;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 8874, 9066);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 8874, 9066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 9015, 9051);

                    return ConstantValueDefault.Boolean;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 8874, 9066);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 8803, 9077);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 8803, 9077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 8803, 9077);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ConstantValue Create(float value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 9089, 9469);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 9161, 9404) || true) && (f_8_9165_9202(value) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 9161, 9404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 9241, 9276);

                    return ConstantValueDefault.Single;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 9161, 9404);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 9161, 9404);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 9310, 9404) || true) && (value == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 9310, 9404);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 9358, 9389);

                        return ConstantValueOne.Single;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 9310, 9404);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 9161, 9404);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 9420, 9458);

                return f_8_9427_9457(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 9089, 9469);

                long
                f_8_9165_9202(float
                value)
                {
                    var return_v = BitConverter.DoubleToInt64Bits((double)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 9165, 9202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue.ConstantValueSingle
                f_8_9427_9457(float
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueSingle((double)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 9427, 9457);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 9089, 9469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 9089, 9469);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ConstantValue CreateSingle(double value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 9481, 9868);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 9560, 9803) || true) && (f_8_9564_9601(value) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 9560, 9803);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 9640, 9675);

                    return ConstantValueDefault.Single;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 9560, 9803);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 9560, 9803);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 9709, 9803) || true) && (value == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 9709, 9803);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 9757, 9788);

                        return ConstantValueOne.Single;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 9709, 9803);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 9560, 9803);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 9819, 9857);

                return f_8_9826_9856(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 9481, 9868);

                long
                f_8_9564_9601(double
                value)
                {
                    var return_v = BitConverter.DoubleToInt64Bits(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 9564, 9601);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue.ConstantValueSingle
                f_8_9826_9856(double
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueSingle(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 9826, 9856);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 9481, 9868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 9481, 9868);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ConstantValue Create(double value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 9880, 10261);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 9953, 10196) || true) && (f_8_9957_9994(value) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 9953, 10196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 10033, 10068);

                    return ConstantValueDefault.Double;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 9953, 10196);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 9953, 10196);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 10102, 10196) || true) && (value == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 10102, 10196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 10150, 10181);

                        return ConstantValueOne.Double;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 10102, 10196);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 9953, 10196);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 10212, 10250);

                return f_8_10219_10249(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 9880, 10261);

                long
                f_8_9957_9994(double
                value)
                {
                    var return_v = BitConverter.DoubleToInt64Bits(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 9957, 9994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue.ConstantValueDouble
                f_8_10219_10249(double
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueDouble(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 10219, 10249);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 9880, 10261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 9880, 10261);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ConstantValue Create(decimal value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 10273, 10962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 10519, 10569);

                int[]
                decimalBits = f_8_10539_10568(value)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 10583, 10896) || true) && (decimalBits[3] == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 10583, 10896);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 10640, 10881) || true) && (value == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 10640, 10881);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 10696, 10732);

                        return ConstantValueDefault.Decimal;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 10640, 10881);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 10640, 10881);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 10774, 10881) || true) && (value == 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 10774, 10881);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 10830, 10862);

                            return ConstantValueOne.Decimal;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 10774, 10881);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 10640, 10881);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 10583, 10896);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 10912, 10951);

                return f_8_10919_10950(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 10273, 10962);

                int[]
                f_8_10539_10568(decimal
                d)
                {
                    var return_v = System.Decimal.GetBits(d);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 10539, 10568);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue.ConstantValueDecimal
                f_8_10919_10950(decimal
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueDecimal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 10919, 10950);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 10273, 10962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 10273, 10962);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ConstantValue Create(DateTime value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 10974, 11232);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 11049, 11165) || true) && (value == default(DateTime))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 11049, 11165);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 11113, 11150);

                    return ConstantValueDefault.DateTime;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 11049, 11165);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 11181, 11221);

                return f_8_11188_11220(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 10974, 11232);

                Microsoft.CodeAnalysis.ConstantValue.ConstantValueDateTime
                f_8_11188_11220(System.DateTime
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueDateTime(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 11188, 11220);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 10974, 11232);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 10974, 11232);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ConstantValue Create(object value, SpecialType st)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 11244, 11515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 11333, 11374);

                var
                discriminator = f_8_11353_11373(st)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 11388, 11454);

                f_8_11388_11453(discriminator != ConstantValueTypeDiscriminator.Bad);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 11468, 11504);

                return f_8_11475_11503(value, discriminator);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 11244, 11515);

                Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                f_8_11353_11373(Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = GetDiscriminator(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 11353, 11373);
                    return return_v;
                }


                int
                f_8_11388_11453(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 11388, 11453);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_8_11475_11503(object
                value, Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                discriminator)
                {
                    var return_v = Create(value, discriminator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 11475, 11503);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 11244, 11515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 11244, 11515);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ConstantValue CreateSizeOf(SpecialType st)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 11527, 11738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 11608, 11636);

                int
                size = f_8_11619_11635(st)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 11650, 11727);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(8, 11657, 11668) || (((size == 0) && DynAbs.Tracing.TraceSender.Conditional_F2(8, 11671, 11697)) || DynAbs.Tracing.TraceSender.Conditional_F3(8, 11700, 11726))) ? ConstantValue.NotAvailable : f_8_11700_11726(size);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 11527, 11738);

                int
                f_8_11619_11635(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.SizeInBytes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 11619, 11635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_8_11700_11726(int
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 11700, 11726);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 11527, 11738);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 11527, 11738);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ConstantValue Create(object value, ConstantValueTypeDiscriminator discriminator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 11750, 13972);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 11869, 11911);

                f_8_11869_11910(BitConverter.IsLittleEndian);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 11927, 13961);

                switch (discriminator)
                {

                    case ConstantValueTypeDiscriminator.Null:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 11927, 13961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 12024, 12036);

                        return f_8_12031_12035();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 11927, 13961);

                    case ConstantValueTypeDiscriminator.SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 11927, 13961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 12097, 12125);

                        return f_8_12104_12124(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 11927, 13961);

                    case ConstantValueTypeDiscriminator.Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 11927, 13961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 12185, 12212);

                        return f_8_12192_12211(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 11927, 13961);

                    case ConstantValueTypeDiscriminator.Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 11927, 13961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 12273, 12301);

                        return f_8_12280_12300(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 11927, 13961);

                    case ConstantValueTypeDiscriminator.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 11927, 13961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 12363, 12392);

                        return f_8_12370_12391(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 11927, 13961);

                    case ConstantValueTypeDiscriminator.Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 11927, 13961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 12453, 12479);

                        return f_8_12460_12478(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 11927, 13961);

                    case ConstantValueTypeDiscriminator.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 11927, 13961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 12541, 12568);

                        return f_8_12548_12567(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 11927, 13961);

                    case ConstantValueTypeDiscriminator.Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 11927, 13961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 12629, 12656);

                        return f_8_12636_12655(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 11927, 13961);

                    case ConstantValueTypeDiscriminator.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 11927, 13961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 12718, 12746);

                        return f_8_12725_12745(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 11927, 13961);

                    case ConstantValueTypeDiscriminator.NInt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 11927, 13961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 12806, 12841);

                        return f_8_12813_12840(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 11927, 13961);

                    case ConstantValueTypeDiscriminator.NUInt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 11927, 13961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 12902, 12939);

                        return f_8_12909_12938(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 11927, 13961);

                    case ConstantValueTypeDiscriminator.Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 11927, 13961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 12999, 13026);

                        return f_8_13006_13025(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 11927, 13961);

                    case ConstantValueTypeDiscriminator.Boolean:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 11927, 13961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 13089, 13116);

                        return f_8_13096_13115(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 11927, 13961);

                    case ConstantValueTypeDiscriminator.Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 11927, 13961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 13277, 13403);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(8, 13284, 13299) || ((value is double && DynAbs.Tracing.TraceSender.Conditional_F2(8, 13327, 13354)) || DynAbs.Tracing.TraceSender.Conditional_F3(8, 13382, 13402))) ? f_8_13327_13354(value) : f_8_13382_13402(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 11927, 13961);

                    case ConstantValueTypeDiscriminator.Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 11927, 13961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 13465, 13494);

                        return f_8_13472_13493(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 11927, 13961);

                    case ConstantValueTypeDiscriminator.Decimal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 11927, 13961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 13557, 13587);

                        return f_8_13564_13586(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 11927, 13961);

                    case ConstantValueTypeDiscriminator.DateTime:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 11927, 13961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 13651, 13682);

                        return f_8_13658_13681(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 11927, 13961);

                    case ConstantValueTypeDiscriminator.String:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 11927, 13961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 13744, 13773);

                        return f_8_13751_13772(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 11927, 13961);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 11927, 13961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 13821, 13859);

                        throw f_8_13827_13858();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 11927, 13961);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 11750, 13972);

                int
                f_8_11869_11910(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 11869, 11910);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_8_12031_12035()
                {
                    var return_v = Null;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 12031, 12035);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_8_12104_12124(object
                value)
                {
                    var return_v = Create((sbyte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 12104, 12124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_8_12192_12211(object
                value)
                {
                    var return_v = Create((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 12192, 12211);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_8_12280_12300(object
                value)
                {
                    var return_v = Create((short)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 12280, 12300);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_8_12370_12391(object
                value)
                {
                    var return_v = Create((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 12370, 12391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_8_12460_12478(object
                value)
                {
                    var return_v = Create((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 12460, 12478);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_8_12548_12567(object
                value)
                {
                    var return_v = Create((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 12548, 12567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_8_12636_12655(object
                value)
                {
                    var return_v = Create((long)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 12636, 12655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_8_12725_12745(object
                value)
                {
                    var return_v = Create((ulong)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 12725, 12745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_8_12813_12840(object
                value)
                {
                    var return_v = CreateNativeInt((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 12813, 12840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_8_12909_12938(object
                value)
                {
                    var return_v = CreateNativeUInt((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 12909, 12938);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_8_13006_13025(object
                value)
                {
                    var return_v = Create((char)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 13006, 13025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_8_13096_13115(object
                value)
                {
                    var return_v = Create((bool)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 13096, 13115);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_8_13327_13354(object
                value)
                {
                    var return_v = CreateSingle((double)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 13327, 13354);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_8_13382_13402(object
                value)
                {
                    var return_v = Create((float)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 13382, 13402);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_8_13472_13493(object
                value)
                {
                    var return_v = Create((double)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 13472, 13493);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_8_13564_13586(object
                value)
                {
                    var return_v = Create((decimal)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 13564, 13586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_8_13658_13681(object
                value)
                {
                    var return_v = Create((System.DateTime)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 13658, 13681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_8_13751_13772(object
                value)
                {
                    var return_v = Create((string)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 13751, 13772);
                    return return_v;
                }


                System.InvalidOperationException
                f_8_13827_13858()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 13827, 13858);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 11750, 13972);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 11750, 13972);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ConstantValue Default(SpecialType st)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 13984, 14236);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 14060, 14101);

                var
                discriminator = f_8_14080_14100(st)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 14115, 14181);

                f_8_14115_14180(discriminator != ConstantValueTypeDiscriminator.Bad);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 14195, 14225);

                return f_8_14202_14224(discriminator);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 13984, 14236);

                Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                f_8_14080_14100(Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = GetDiscriminator(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 14080, 14100);
                    return return_v;
                }


                int
                f_8_14115_14180(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 14115, 14180);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_8_14202_14224(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                discriminator)
                {
                    var return_v = Default(discriminator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 14202, 14224);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 13984, 14236);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 13984, 14236);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ConstantValue Default(ConstantValueTypeDiscriminator discriminator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 14248, 16234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 14354, 16151);

                switch (discriminator)
                {

                    case ConstantValueTypeDiscriminator.Bad:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 14354, 16151);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 14450, 14461);

                        return f_8_14457_14460();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 14354, 16151);

                    case ConstantValueTypeDiscriminator.SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 14354, 16151);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 14524, 14558);

                        return ConstantValueDefault.SByte;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 14354, 16151);

                    case ConstantValueTypeDiscriminator.Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 14354, 16151);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 14618, 14651);

                        return ConstantValueDefault.Byte;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 14354, 16151);

                    case ConstantValueTypeDiscriminator.Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 14354, 16151);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 14712, 14746);

                        return ConstantValueDefault.Int16;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 14354, 16151);

                    case ConstantValueTypeDiscriminator.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 14354, 16151);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 14808, 14843);

                        return ConstantValueDefault.UInt16;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 14354, 16151);

                    case ConstantValueTypeDiscriminator.Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 14354, 16151);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 14904, 14938);

                        return ConstantValueDefault.Int32;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 14354, 16151);

                    case ConstantValueTypeDiscriminator.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 14354, 16151);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 15000, 15035);

                        return ConstantValueDefault.UInt32;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 14354, 16151);

                    case ConstantValueTypeDiscriminator.Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 14354, 16151);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 15096, 15130);

                        return ConstantValueDefault.Int64;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 14354, 16151);

                    case ConstantValueTypeDiscriminator.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 14354, 16151);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 15192, 15227);

                        return ConstantValueDefault.UInt64;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 14354, 16151);

                    case ConstantValueTypeDiscriminator.NInt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 14354, 16151);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 15287, 15320);

                        return ConstantValueDefault.NInt;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 14354, 16151);

                    case ConstantValueTypeDiscriminator.NUInt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 14354, 16151);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 15381, 15415);

                        return ConstantValueDefault.NUInt;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 14354, 16151);

                    case ConstantValueTypeDiscriminator.Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 14354, 16151);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 15475, 15508);

                        return ConstantValueDefault.Char;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 14354, 16151);

                    case ConstantValueTypeDiscriminator.Boolean:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 14354, 16151);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 15571, 15607);

                        return ConstantValueDefault.Boolean;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 14354, 16151);

                    case ConstantValueTypeDiscriminator.Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 14354, 16151);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 15669, 15704);

                        return ConstantValueDefault.Single;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 14354, 16151);

                    case ConstantValueTypeDiscriminator.Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 14354, 16151);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 15766, 15801);

                        return ConstantValueDefault.Double;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 14354, 16151);

                    case ConstantValueTypeDiscriminator.Decimal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 14354, 16151);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 15864, 15900);

                        return ConstantValueDefault.Decimal;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 14354, 16151);

                    case ConstantValueTypeDiscriminator.DateTime:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 14354, 16151);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 15964, 16001);

                        return ConstantValueDefault.DateTime;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 14354, 16151);

                    case ConstantValueTypeDiscriminator.Null:
                    case ConstantValueTypeDiscriminator.String:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 14354, 16151);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 16124, 16136);

                        return f_8_16131_16135();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 14354, 16151);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 16167, 16223);

                throw f_8_16173_16222(discriminator);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 14248, 16234);

                Microsoft.CodeAnalysis.ConstantValue
                f_8_14457_14460()
                {
                    var return_v = Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 14457, 14460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_8_16131_16135()
                {
                    var return_v = Null;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 16131, 16135);
                    return return_v;
                }


                System.Exception
                f_8_16173_16222(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 16173, 16222);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 14248, 16234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 14248, 16234);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ConstantValueTypeDiscriminator GetDiscriminator(SpecialType st)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 16246, 18065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 16350, 17996);

                switch (st)
                {

                    case SpecialType.System_SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 16350, 17996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 16425, 16469);

                        return ConstantValueTypeDiscriminator.SByte;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 16350, 17996);

                    case SpecialType.System_Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 16350, 17996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 16517, 16560);

                        return ConstantValueTypeDiscriminator.Byte;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 16350, 17996);

                    case SpecialType.System_Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 16350, 17996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 16609, 16653);

                        return ConstantValueTypeDiscriminator.Int16;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 16350, 17996);

                    case SpecialType.System_UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 16350, 17996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 16703, 16748);

                        return ConstantValueTypeDiscriminator.UInt16;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 16350, 17996);

                    case SpecialType.System_Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 16350, 17996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 16797, 16841);

                        return ConstantValueTypeDiscriminator.Int32;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 16350, 17996);

                    case SpecialType.System_UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 16350, 17996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 16891, 16936);

                        return ConstantValueTypeDiscriminator.UInt32;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 16350, 17996);

                    case SpecialType.System_Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 16350, 17996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 16985, 17029);

                        return ConstantValueTypeDiscriminator.Int64;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 16350, 17996);

                    case SpecialType.System_UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 16350, 17996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 17079, 17124);

                        return ConstantValueTypeDiscriminator.UInt64;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 16350, 17996);

                    case SpecialType.System_IntPtr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 16350, 17996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 17174, 17217);

                        return ConstantValueTypeDiscriminator.NInt;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 16350, 17996);

                    case SpecialType.System_UIntPtr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 16350, 17996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 17268, 17312);

                        return ConstantValueTypeDiscriminator.NUInt;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 16350, 17996);

                    case SpecialType.System_Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 16350, 17996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 17360, 17403);

                        return ConstantValueTypeDiscriminator.Char;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 16350, 17996);

                    case SpecialType.System_Boolean:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 16350, 17996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 17454, 17500);

                        return ConstantValueTypeDiscriminator.Boolean;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 16350, 17996);

                    case SpecialType.System_Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 16350, 17996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 17550, 17595);

                        return ConstantValueTypeDiscriminator.Single;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 16350, 17996);

                    case SpecialType.System_Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 16350, 17996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 17645, 17690);

                        return ConstantValueTypeDiscriminator.Double;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 16350, 17996);

                    case SpecialType.System_Decimal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 16350, 17996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 17741, 17787);

                        return ConstantValueTypeDiscriminator.Decimal;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 16350, 17996);

                    case SpecialType.System_DateTime:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 16350, 17996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 17839, 17886);

                        return ConstantValueTypeDiscriminator.DateTime;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 16350, 17996);

                    case SpecialType.System_String:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 16350, 17996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 17936, 17981);

                        return ConstantValueTypeDiscriminator.String;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 16350, 17996);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 18012, 18054);

                return ConstantValueTypeDiscriminator.Bad;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 16246, 18065);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 16246, 18065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 16246, 18065);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SpecialType GetSpecialType(ConstantValueTypeDiscriminator discriminator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 18077, 19908);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 18189, 19897);

                switch (discriminator)
                {

                    case ConstantValueTypeDiscriminator.SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 18189, 19897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 18287, 18319);

                        return SpecialType.System_SByte;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 18189, 19897);

                    case ConstantValueTypeDiscriminator.Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 18189, 19897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 18379, 18410);

                        return SpecialType.System_Byte;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 18189, 19897);

                    case ConstantValueTypeDiscriminator.Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 18189, 19897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 18471, 18503);

                        return SpecialType.System_Int16;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 18189, 19897);

                    case ConstantValueTypeDiscriminator.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 18189, 19897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 18565, 18598);

                        return SpecialType.System_UInt16;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 18189, 19897);

                    case ConstantValueTypeDiscriminator.Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 18189, 19897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 18659, 18691);

                        return SpecialType.System_Int32;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 18189, 19897);

                    case ConstantValueTypeDiscriminator.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 18189, 19897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 18753, 18786);

                        return SpecialType.System_UInt32;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 18189, 19897);

                    case ConstantValueTypeDiscriminator.Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 18189, 19897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 18847, 18879);

                        return SpecialType.System_Int64;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 18189, 19897);

                    case ConstantValueTypeDiscriminator.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 18189, 19897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 18941, 18974);

                        return SpecialType.System_UInt64;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 18189, 19897);

                    case ConstantValueTypeDiscriminator.NInt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 18189, 19897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 19034, 19067);

                        return SpecialType.System_IntPtr;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 18189, 19897);

                    case ConstantValueTypeDiscriminator.NUInt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 18189, 19897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 19128, 19162);

                        return SpecialType.System_UIntPtr;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 18189, 19897);

                    case ConstantValueTypeDiscriminator.Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 18189, 19897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 19222, 19253);

                        return SpecialType.System_Char;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 18189, 19897);

                    case ConstantValueTypeDiscriminator.Boolean:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 18189, 19897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 19316, 19350);

                        return SpecialType.System_Boolean;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 18189, 19897);

                    case ConstantValueTypeDiscriminator.Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 18189, 19897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 19412, 19445);

                        return SpecialType.System_Single;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 18189, 19897);

                    case ConstantValueTypeDiscriminator.Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 18189, 19897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 19507, 19540);

                        return SpecialType.System_Double;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 18189, 19897);

                    case ConstantValueTypeDiscriminator.Decimal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 18189, 19897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 19603, 19637);

                        return SpecialType.System_Decimal;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 18189, 19897);

                    case ConstantValueTypeDiscriminator.DateTime:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 18189, 19897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 19701, 19736);

                        return SpecialType.System_DateTime;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 18189, 19897);

                    case ConstantValueTypeDiscriminator.String:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 18189, 19897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 19798, 19831);

                        return SpecialType.System_String;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 18189, 19897);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 18189, 19897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 19858, 19882);

                        return SpecialType.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 18189, 19897);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 18077, 19908);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 18077, 19908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 18077, 19908);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object? Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 19965, 21922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 20001, 21907);

                    switch (f_8_20009_20027(this))
                    {

                        case ConstantValueTypeDiscriminator.Bad:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 20001, 21907);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 20110, 20122);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 20001, 21907);

                        case ConstantValueTypeDiscriminator.Null:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 20001, 21907);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 20186, 20198);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 20001, 21907);

                        case ConstantValueTypeDiscriminator.SByte:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 20001, 21907);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 20263, 20292);

                            return f_8_20270_20291(f_8_20280_20290());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 20001, 21907);

                        case ConstantValueTypeDiscriminator.Byte:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 20001, 21907);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 20356, 20384);

                            return f_8_20363_20383(f_8_20373_20382());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 20001, 21907);

                        case ConstantValueTypeDiscriminator.Int16:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 20001, 21907);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 20449, 20478);

                            return f_8_20456_20477(f_8_20466_20476());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 20001, 21907);

                        case ConstantValueTypeDiscriminator.UInt16:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 20001, 21907);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 20544, 20574);

                            return f_8_20551_20573(f_8_20561_20572());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 20001, 21907);

                        case ConstantValueTypeDiscriminator.Int32:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 20001, 21907);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 20639, 20668);

                            return f_8_20646_20667(f_8_20656_20666());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 20001, 21907);

                        case ConstantValueTypeDiscriminator.UInt32:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 20001, 21907);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 20734, 20764);

                            return f_8_20741_20763(f_8_20751_20762());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 20001, 21907);

                        case ConstantValueTypeDiscriminator.Int64:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 20001, 21907);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 20829, 20858);

                            return f_8_20836_20857(f_8_20846_20856());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 20001, 21907);

                        case ConstantValueTypeDiscriminator.UInt64:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 20001, 21907);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 20924, 20954);

                            return f_8_20931_20953(f_8_20941_20952());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 20001, 21907);

                        case ConstantValueTypeDiscriminator.NInt:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 20001, 21907);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 21018, 21047);

                            return f_8_21025_21046(f_8_21035_21045());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 20001, 21907);

                        case ConstantValueTypeDiscriminator.NUInt:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 20001, 21907);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 21112, 21142);

                            return f_8_21119_21141(f_8_21129_21140());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 20001, 21907);

                        case ConstantValueTypeDiscriminator.Char:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 20001, 21907);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 21206, 21234);

                            return f_8_21213_21233(f_8_21223_21232());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 20001, 21907);

                        case ConstantValueTypeDiscriminator.Boolean:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 20001, 21907);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 21301, 21332);

                            return f_8_21308_21331(f_8_21318_21330());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 20001, 21907);

                        case ConstantValueTypeDiscriminator.Single:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 20001, 21907);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 21398, 21428);

                            return f_8_21405_21427(f_8_21415_21426());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 20001, 21907);

                        case ConstantValueTypeDiscriminator.Double:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 20001, 21907);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 21494, 21524);

                            return f_8_21501_21523(f_8_21511_21522());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 20001, 21907);

                        case ConstantValueTypeDiscriminator.Decimal:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 20001, 21907);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 21591, 21622);

                            return f_8_21598_21621(f_8_21608_21620());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 20001, 21907);

                        case ConstantValueTypeDiscriminator.DateTime:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 20001, 21907);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 21690, 21711);

                            return f_8_21697_21710();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 20001, 21907);

                        case ConstantValueTypeDiscriminator.String:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 20001, 21907);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 21777, 21796);

                            return f_8_21784_21795();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 20001, 21907);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 20001, 21907);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 21827, 21888);

                            throw f_8_21833_21887(f_8_21868_21886(this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 20001, 21907);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 19965, 21922);

                    Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                    f_8_20009_20027(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Discriminator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 20009, 20027);
                        return return_v;
                    }


                    sbyte
                    f_8_20280_20290()
                    {
                        var return_v = SByteValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 20280, 20290);
                        return return_v;
                    }


                    object
                    f_8_20270_20291(sbyte
                    sb)
                    {
                        var return_v = Boxes.Box(sb);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 20270, 20291);
                        return return_v;
                    }


                    byte
                    f_8_20373_20382()
                    {
                        var return_v = ByteValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 20373, 20382);
                        return return_v;
                    }


                    object
                    f_8_20363_20383(byte
                    b)
                    {
                        var return_v = Boxes.Box(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 20363, 20383);
                        return return_v;
                    }


                    short
                    f_8_20466_20476()
                    {
                        var return_v = Int16Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 20466, 20476);
                        return return_v;
                    }


                    object
                    f_8_20456_20477(short
                    s)
                    {
                        var return_v = Boxes.Box(s);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 20456, 20477);
                        return return_v;
                    }


                    ushort
                    f_8_20561_20572()
                    {
                        var return_v = UInt16Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 20561, 20572);
                        return return_v;
                    }


                    object
                    f_8_20551_20573(ushort
                    us)
                    {
                        var return_v = Boxes.Box(us);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 20551, 20573);
                        return return_v;
                    }


                    int
                    f_8_20656_20666()
                    {
                        var return_v = Int32Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 20656, 20666);
                        return return_v;
                    }


                    object
                    f_8_20646_20667(int
                    i)
                    {
                        var return_v = Boxes.Box(i);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 20646, 20667);
                        return return_v;
                    }


                    uint
                    f_8_20751_20762()
                    {
                        var return_v = UInt32Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 20751, 20762);
                        return return_v;
                    }


                    object
                    f_8_20741_20763(uint
                    u)
                    {
                        var return_v = Boxes.Box(u);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 20741, 20763);
                        return return_v;
                    }


                    long
                    f_8_20846_20856()
                    {
                        var return_v = Int64Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 20846, 20856);
                        return return_v;
                    }


                    object
                    f_8_20836_20857(long
                    l)
                    {
                        var return_v = Boxes.Box(l);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 20836, 20857);
                        return return_v;
                    }


                    ulong
                    f_8_20941_20952()
                    {
                        var return_v = UInt64Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 20941, 20952);
                        return return_v;
                    }


                    object
                    f_8_20931_20953(ulong
                    ul)
                    {
                        var return_v = Boxes.Box(ul);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 20931, 20953);
                        return return_v;
                    }


                    int
                    f_8_21035_21045()
                    {
                        var return_v = Int32Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 21035, 21045);
                        return return_v;
                    }


                    object
                    f_8_21025_21046(int
                    i)
                    {
                        var return_v = Boxes.Box(i);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 21025, 21046);
                        return return_v;
                    }


                    uint
                    f_8_21129_21140()
                    {
                        var return_v = UInt32Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 21129, 21140);
                        return return_v;
                    }


                    object
                    f_8_21119_21141(uint
                    u)
                    {
                        var return_v = Boxes.Box(u);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 21119, 21141);
                        return return_v;
                    }


                    char
                    f_8_21223_21232()
                    {
                        var return_v = CharValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 21223, 21232);
                        return return_v;
                    }


                    object
                    f_8_21213_21233(char
                    c)
                    {
                        var return_v = Boxes.Box(c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 21213, 21233);
                        return return_v;
                    }


                    bool
                    f_8_21318_21330()
                    {
                        var return_v = BooleanValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 21318, 21330);
                        return return_v;
                    }


                    object
                    f_8_21308_21331(bool
                    b)
                    {
                        var return_v = Boxes.Box(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 21308, 21331);
                        return return_v;
                    }


                    float
                    f_8_21415_21426()
                    {
                        var return_v = SingleValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 21415, 21426);
                        return return_v;
                    }


                    object
                    f_8_21405_21427(float
                    f)
                    {
                        var return_v = Boxes.Box(f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 21405, 21427);
                        return return_v;
                    }


                    double
                    f_8_21511_21522()
                    {
                        var return_v = DoubleValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 21511, 21522);
                        return return_v;
                    }


                    object
                    f_8_21501_21523(double
                    d)
                    {
                        var return_v = Boxes.Box(d);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 21501, 21523);
                        return return_v;
                    }


                    decimal
                    f_8_21608_21620()
                    {
                        var return_v = DecimalValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 21608, 21620);
                        return return_v;
                    }


                    object
                    f_8_21598_21621(decimal
                    d)
                    {
                        var return_v = Boxes.Box(d);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 21598, 21621);
                        return return_v;
                    }


                    System.DateTime
                    f_8_21697_21710()
                    {
                        var return_v = DateTimeValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 21697, 21710);
                        return return_v;
                    }


                    string?
                    f_8_21784_21795()
                    {
                        var return_v = StringValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 21784, 21795);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                    f_8_21868_21886(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Discriminator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 21868, 21886);
                        return return_v;
                    }


                    System.Exception
                    f_8_21833_21887(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 21833, 21887);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 19920, 21933);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 19920, 21933);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsIntegralType(ConstantValueTypeDiscriminator discriminator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 21945, 22810);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 22049, 22799);

                switch (discriminator)
                {

                    case ConstantValueTypeDiscriminator.SByte:
                    case ConstantValueTypeDiscriminator.Byte:
                    case ConstantValueTypeDiscriminator.Int16:
                    case ConstantValueTypeDiscriminator.UInt16:
                    case ConstantValueTypeDiscriminator.Int32:
                    case ConstantValueTypeDiscriminator.UInt32:
                    case ConstantValueTypeDiscriminator.Int64:
                    case ConstantValueTypeDiscriminator.UInt64:
                    case ConstantValueTypeDiscriminator.NInt:
                    case ConstantValueTypeDiscriminator.NUInt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 22049, 22799);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 22709, 22721);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 22049, 22799);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 22049, 22799);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 22771, 22784);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 22049, 22799);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 21945, 22810);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 21945, 22810);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 21945, 22810);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsIntegral
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 22869, 22962);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 22905, 22947);

                    return f_8_22912_22946(f_8_22927_22945(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 22869, 22962);

                    Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                    f_8_22927_22945(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Discriminator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 22927, 22945);
                        return return_v;
                    }


                    bool
                    f_8_22912_22946(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                    discriminator)
                    {
                        var return_v = IsIntegralType(discriminator);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 22912, 22946);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 22822, 22973);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 22822, 22973);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsNegativeNumeric
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 23039, 24081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 23075, 24066);

                    switch (f_8_23083_23101(this))
                    {

                        case ConstantValueTypeDiscriminator.SByte:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 23075, 24066);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 23211, 23233);

                            return f_8_23218_23228() < 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 23075, 24066);

                        case ConstantValueTypeDiscriminator.Int16:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 23075, 24066);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 23323, 23345);

                            return f_8_23330_23340() < 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 23075, 24066);

                        case ConstantValueTypeDiscriminator.Int32:
                        case ConstantValueTypeDiscriminator.NInt:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 23075, 24066);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 23498, 23520);

                            return f_8_23505_23515() < 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 23075, 24066);

                        case ConstantValueTypeDiscriminator.Int64:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 23075, 24066);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 23610, 23632);

                            return f_8_23617_23627() < 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 23075, 24066);

                        case ConstantValueTypeDiscriminator.Single:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 23075, 24066);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 23723, 23746);

                            return f_8_23730_23741() < 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 23075, 24066);

                        case ConstantValueTypeDiscriminator.Double:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 23075, 24066);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 23837, 23860);

                            return f_8_23844_23855() < 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 23075, 24066);

                        case ConstantValueTypeDiscriminator.Decimal:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 23075, 24066);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 23952, 23976);

                            return f_8_23959_23971() < 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 23075, 24066);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 23075, 24066);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 24034, 24047);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 23075, 24066);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 23039, 24081);

                    Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                    f_8_23083_23101(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Discriminator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 23083, 23101);
                        return return_v;
                    }


                    sbyte
                    f_8_23218_23228()
                    {
                        var return_v = SByteValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 23218, 23228);
                        return return_v;
                    }


                    short
                    f_8_23330_23340()
                    {
                        var return_v = Int16Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 23330, 23340);
                        return return_v;
                    }


                    int
                    f_8_23505_23515()
                    {
                        var return_v = Int32Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 23505, 23515);
                        return return_v;
                    }


                    long
                    f_8_23617_23627()
                    {
                        var return_v = Int64Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 23617, 23627);
                        return return_v;
                    }


                    float
                    f_8_23730_23741()
                    {
                        var return_v = SingleValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 23730, 23741);
                        return return_v;
                    }


                    double
                    f_8_23844_23855()
                    {
                        var return_v = DoubleValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 23844, 23855);
                        return return_v;
                    }


                    decimal
                    f_8_23959_23971()
                    {
                        var return_v = DecimalValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 23959, 23971);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 22985, 24092);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 22985, 24092);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsNumeric
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 24150, 25212);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 24186, 25197);

                    switch (f_8_24194_24212(this))
                    {

                        case ConstantValueTypeDiscriminator.SByte:
                        case ConstantValueTypeDiscriminator.Int16:
                        case ConstantValueTypeDiscriminator.Int32:
                        case ConstantValueTypeDiscriminator.Int64:
                        case ConstantValueTypeDiscriminator.Single:
                        case ConstantValueTypeDiscriminator.Double:
                        case ConstantValueTypeDiscriminator.Decimal:
                        case ConstantValueTypeDiscriminator.Byte:
                        case ConstantValueTypeDiscriminator.UInt16:
                        case ConstantValueTypeDiscriminator.UInt32:
                        case ConstantValueTypeDiscriminator.UInt64:
                        case ConstantValueTypeDiscriminator.NInt:
                        case ConstantValueTypeDiscriminator.NUInt:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 24186, 25197);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 25095, 25107);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 24186, 25197);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 24186, 25197);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 25165, 25178);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(8, 24186, 25197);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 24150, 25212);

                    Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                    f_8_24194_24212(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Discriminator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 24194, 24212);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 24104, 25223);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 24104, 25223);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsUnsignedIntegralType(ConstantValueTypeDiscriminator discriminator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 25235, 25809);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 25347, 25798);

                switch (discriminator)
                {

                    case ConstantValueTypeDiscriminator.Byte:
                    case ConstantValueTypeDiscriminator.UInt16:
                    case ConstantValueTypeDiscriminator.UInt32:
                    case ConstantValueTypeDiscriminator.UInt64:
                    case ConstantValueTypeDiscriminator.NUInt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 25347, 25798);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 25708, 25720);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 25347, 25798);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 25347, 25798);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 25770, 25783);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 25347, 25798);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 25235, 25809);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 25235, 25809);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 25235, 25809);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsUnsigned
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 25868, 25969);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 25904, 25954);

                    return f_8_25911_25953(f_8_25934_25952(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 25868, 25969);

                    Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                    f_8_25934_25952(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Discriminator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 25934, 25952);
                        return return_v;
                    }


                    bool
                    f_8_25911_25953(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                    discriminator)
                    {
                        var return_v = IsUnsignedIntegralType(discriminator);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 25911, 25953);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 25821, 25980);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 25821, 25980);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsBooleanType(ConstantValueTypeDiscriminator discriminator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 25992, 26169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 26095, 26158);

                return discriminator == ConstantValueTypeDiscriminator.Boolean;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 25992, 26169);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 25992, 26169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 25992, 26169);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsBoolean
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 26227, 26346);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 26263, 26331);

                    return f_8_26270_26288(this) == ConstantValueTypeDiscriminator.Boolean;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 26227, 26346);

                    Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                    f_8_26270_26288(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Discriminator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 26270, 26288);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 26181, 26357);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 26181, 26357);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsCharType(ConstantValueTypeDiscriminator discriminator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 26369, 26540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 26469, 26529);

                return discriminator == ConstantValueTypeDiscriminator.Char;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 26369, 26540);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 26369, 26540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 26369, 26540);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsChar
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 26595, 26711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 26631, 26696);

                    return f_8_26638_26656(this) == ConstantValueTypeDiscriminator.Char;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 26595, 26711);

                    Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                    f_8_26638_26656(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Discriminator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 26638, 26656);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 26552, 26722);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 26552, 26722);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsStringType(ConstantValueTypeDiscriminator discriminator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 26734, 26909);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 26836, 26898);

                return discriminator == ConstantValueTypeDiscriminator.String;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 26734, 26909);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 26734, 26909);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 26734, 26909);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [MemberNotNullWhen(true, nameof(StringValue))]
        public bool IsString
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 27022, 27140);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 27058, 27125);

                    return f_8_27065_27083(this) == ConstantValueTypeDiscriminator.String;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 27022, 27140);

                    Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                    f_8_27065_27083(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Discriminator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 27065, 27083);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 26921, 27151);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 26921, 27151);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsDecimalType(ConstantValueTypeDiscriminator discriminator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 27163, 27340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 27266, 27329);

                return discriminator == ConstantValueTypeDiscriminator.Decimal;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 27163, 27340);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 27163, 27340);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 27163, 27340);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsDecimal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 27398, 27517);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 27434, 27502);

                    return f_8_27441_27459(this) == ConstantValueTypeDiscriminator.Decimal;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 27398, 27517);

                    Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                    f_8_27441_27459(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Discriminator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 27441, 27459);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 27352, 27528);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 27352, 27528);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsDateTimeType(ConstantValueTypeDiscriminator discriminator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 27540, 27719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 27644, 27708);

                return discriminator == ConstantValueTypeDiscriminator.DateTime;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 27540, 27719);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 27540, 27719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 27540, 27719);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsDateTime
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 27778, 27898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 27814, 27883);

                    return f_8_27821_27839(this) == ConstantValueTypeDiscriminator.DateTime;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 27778, 27898);

                    Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                    f_8_27821_27839(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Discriminator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 27821, 27839);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 27731, 27909);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 27731, 27909);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsFloatingType(ConstantValueTypeDiscriminator discriminator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 27921, 28173);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 28025, 28162);

                return discriminator == ConstantValueTypeDiscriminator.Double || (DynAbs.Tracing.TraceSender.Expression_False(8, 28032, 28161) || discriminator == ConstantValueTypeDiscriminator.Single);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 27921, 28173);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 27921, 28173);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 27921, 28173);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsFloating
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 28232, 28434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 28268, 28419);

                    return f_8_28275_28293(this) == ConstantValueTypeDiscriminator.Double || (DynAbs.Tracing.TraceSender.Expression_False(8, 28275, 28418) || f_8_28359_28377(this) == ConstantValueTypeDiscriminator.Single);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 28232, 28434);

                    Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                    f_8_28275_28293(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Discriminator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 28275, 28293);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                    f_8_28359_28377(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Discriminator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 28359, 28377);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 28185, 28445);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 28185, 28445);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsBad
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 28499, 28614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 28535, 28599);

                    return f_8_28542_28560(this) == ConstantValueTypeDiscriminator.Bad;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 28499, 28614);

                    Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                    f_8_28542_28560(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Discriminator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 28542, 28560);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 28457, 28625);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 28457, 28625);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 28680, 28766);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 28716, 28751);

                    return f_8_28723_28750(this, f_8_28745_28749());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 28680, 28766);

                    Microsoft.CodeAnalysis.ConstantValue
                    f_8_28745_28749()
                    {
                        var return_v = Null;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 28745, 28749);
                        return return_v;
                    }


                    bool
                    f_8_28723_28750(Microsoft.CodeAnalysis.ConstantValue
                    objA, Microsoft.CodeAnalysis.ConstantValue
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 28723, 28750);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 28637, 28777);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 28637, 28777);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsNothing
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 28835, 28924);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 28871, 28909);

                    return f_8_28878_28908(this, f_8_28900_28907());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(8, 28835, 28924);

                    Microsoft.CodeAnalysis.ConstantValue
                    f_8_28900_28907()
                    {
                        var return_v = Nothing;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 28900, 28907);
                        return return_v;
                    }


                    bool
                    f_8_28878_28908(Microsoft.CodeAnalysis.ConstantValue
                    objA, Microsoft.CodeAnalysis.ConstantValue
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 28878, 28908);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 28789, 28935);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 28789, 28935);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void Serialize(BlobBuilder writer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 28947, 30863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 29013, 30852);

                switch (f_8_29021_29039(this))
                {

                    case ConstantValueTypeDiscriminator.Boolean:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 29013, 30852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 29139, 29178);

                        f_8_29139_29177(writer, f_8_29159_29176(this));
                        DynAbs.Tracing.TraceSender.TraceBreak(8, 29200, 29206);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 29013, 30852);

                    case ConstantValueTypeDiscriminator.SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 29013, 30852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 29290, 29325);

                        f_8_29290_29324(writer, f_8_29308_29323(this));
                        DynAbs.Tracing.TraceSender.TraceBreak(8, 29347, 29353);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 29013, 30852);

                    case ConstantValueTypeDiscriminator.Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 29013, 30852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 29436, 29469);

                        f_8_29436_29468(writer, f_8_29453_29467(this));
                        DynAbs.Tracing.TraceSender.TraceBreak(8, 29491, 29497);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 29013, 30852);

                    case ConstantValueTypeDiscriminator.Char:
                    case ConstantValueTypeDiscriminator.Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 29013, 30852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 29640, 29675);

                        f_8_29640_29674(writer, f_8_29658_29673(this));
                        DynAbs.Tracing.TraceSender.TraceBreak(8, 29697, 29703);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 29013, 30852);

                    case ConstantValueTypeDiscriminator.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 29013, 30852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 29788, 29825);

                        f_8_29788_29824(writer, f_8_29807_29823(this));
                        DynAbs.Tracing.TraceSender.TraceBreak(8, 29847, 29853);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 29013, 30852);

                    case ConstantValueTypeDiscriminator.Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 29013, 30852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 29938, 29975);

                        f_8_29938_29974(writer, f_8_29957_29973(this));
                        DynAbs.Tracing.TraceSender.TraceBreak(8, 29997, 30003);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 29013, 30852);

                    case ConstantValueTypeDiscriminator.Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 29013, 30852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 30087, 30122);

                        f_8_30087_30121(writer, f_8_30105_30120(this));
                        DynAbs.Tracing.TraceSender.TraceBreak(8, 30144, 30150);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 29013, 30852);

                    case ConstantValueTypeDiscriminator.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 29013, 30852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 30235, 30272);

                        f_8_30235_30271(writer, f_8_30254_30270(this));
                        DynAbs.Tracing.TraceSender.TraceBreak(8, 30294, 30300);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 29013, 30852);

                    case ConstantValueTypeDiscriminator.Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 29013, 30852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 30385, 30422);

                        f_8_30385_30421(writer, f_8_30404_30420(this));
                        DynAbs.Tracing.TraceSender.TraceBreak(8, 30444, 30450);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 29013, 30852);

                    case ConstantValueTypeDiscriminator.Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 29013, 30852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 30534, 30569);

                        f_8_30534_30568(writer, f_8_30552_30567(this));
                        DynAbs.Tracing.TraceSender.TraceBreak(8, 30591, 30597);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 29013, 30852);

                    case ConstantValueTypeDiscriminator.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 29013, 30852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 30682, 30719);

                        f_8_30682_30718(writer, f_8_30701_30717(this));
                        DynAbs.Tracing.TraceSender.TraceBreak(8, 30741, 30747);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 29013, 30852);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 29013, 30852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 30776, 30837);

                        throw f_8_30782_30836(f_8_30817_30835(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(8, 29013, 30852);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(8, 28947, 30863);

                Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                f_8_29021_29039(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Discriminator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 29021, 29039);
                    return return_v;
                }


                bool
                f_8_29159_29176(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.BooleanValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 29159, 29176);
                    return return_v;
                }


                int
                f_8_29139_29177(System.Reflection.Metadata.BlobBuilder
                this_param, bool
                value)
                {
                    this_param.WriteBoolean(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 29139, 29177);
                    return 0;
                }


                sbyte
                f_8_29308_29323(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.SByteValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 29308, 29323);
                    return return_v;
                }


                int
                f_8_29290_29324(System.Reflection.Metadata.BlobBuilder
                this_param, sbyte
                value)
                {
                    this_param.WriteSByte(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 29290, 29324);
                    return 0;
                }


                byte
                f_8_29453_29467(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.ByteValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 29453, 29467);
                    return return_v;
                }


                int
                f_8_29436_29468(System.Reflection.Metadata.BlobBuilder
                this_param, byte
                value)
                {
                    this_param.WriteByte(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 29436, 29468);
                    return 0;
                }


                short
                f_8_29658_29673(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int16Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 29658, 29673);
                    return return_v;
                }


                int
                f_8_29640_29674(System.Reflection.Metadata.BlobBuilder
                this_param, short
                value)
                {
                    this_param.WriteInt16(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 29640, 29674);
                    return 0;
                }


                ushort
                f_8_29807_29823(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt16Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 29807, 29823);
                    return return_v;
                }


                int
                f_8_29788_29824(System.Reflection.Metadata.BlobBuilder
                this_param, ushort
                value)
                {
                    this_param.WriteUInt16(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 29788, 29824);
                    return 0;
                }


                float
                f_8_29957_29973(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.SingleValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 29957, 29973);
                    return return_v;
                }


                int
                f_8_29938_29974(System.Reflection.Metadata.BlobBuilder
                this_param, float
                value)
                {
                    this_param.WriteSingle(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 29938, 29974);
                    return 0;
                }


                int
                f_8_30105_30120(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int32Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 30105, 30120);
                    return return_v;
                }


                int
                f_8_30087_30121(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 30087, 30121);
                    return 0;
                }


                uint
                f_8_30254_30270(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt32Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 30254, 30270);
                    return return_v;
                }


                int
                f_8_30235_30271(System.Reflection.Metadata.BlobBuilder
                this_param, uint
                value)
                {
                    this_param.WriteUInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 30235, 30271);
                    return 0;
                }


                double
                f_8_30404_30420(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.DoubleValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 30404, 30420);
                    return return_v;
                }


                int
                f_8_30385_30421(System.Reflection.Metadata.BlobBuilder
                this_param, double
                value)
                {
                    this_param.WriteDouble(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 30385, 30421);
                    return 0;
                }


                long
                f_8_30552_30567(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 30552, 30567);
                    return return_v;
                }


                int
                f_8_30534_30568(System.Reflection.Metadata.BlobBuilder
                this_param, long
                value)
                {
                    this_param.WriteInt64(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 30534, 30568);
                    return 0;
                }


                ulong
                f_8_30701_30717(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 30701, 30717);
                    return return_v;
                }


                int
                f_8_30682_30718(System.Reflection.Metadata.BlobBuilder
                this_param, ulong
                value)
                {
                    this_param.WriteUInt64(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 30682, 30718);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                f_8_30817_30835(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Discriminator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 30817, 30835);
                    return return_v;
                }


                System.Exception
                f_8_30782_30836(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 30782, 30836);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 28947, 30863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 28947, 30863);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 30875, 31103);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 30933, 30983);

                string?
                valueToDisplay = f_8_30958_30982(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 30997, 31092);

                return f_8_31004_31091("{0}({1}: {2})", f_8_31035_31054(f_8_31035_31049(this)), valueToDisplay, f_8_31072_31090(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(8, 30875, 31103);

                string?
                f_8_30958_30982(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.GetValueToDisplay();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 30958, 30982);
                    return return_v;
                }


                System.Type
                f_8_31035_31049(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 31035, 31049);
                    return return_v;
                }


                string
                f_8_31035_31054(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 31035, 31054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                f_8_31072_31090(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Discriminator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 31072, 31090);
                    return return_v;
                }


                string
                f_8_31004_31091(string
                format, string
                arg0, string?
                arg1, Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                arg2)
                {
                    var return_v = String.Format(format, (object)arg0, (object?)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 31004, 31091);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 30875, 31103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 30875, 31103);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual string? GetValueToDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 31115, 31225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 31184, 31214);

                return f_8_31191_31213_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_8_31191_31201(this), 8, 31191, 31213).ToString());
                DynAbs.Tracing.TraceSender.TraceExitMethod(8, 31115, 31225);

                object?
                f_8_31191_31201(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 31191, 31201);
                    return return_v;
                }


                string?
                f_8_31191_31213_I(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 31191, 31213);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 31115, 31225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 31115, 31225);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual bool Equals(ConstantValue? other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 31479, 31831);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 31552, 31645) || true) && (f_8_31556_31584(other, this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 31552, 31645);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 31618, 31630);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 31552, 31645);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 31661, 31755) || true) && (f_8_31665_31693(other, null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 31661, 31755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 31727, 31740);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 31661, 31755);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 31771, 31820);

                return f_8_31778_31796(this) == f_8_31800_31819(other);
                DynAbs.Tracing.TraceSender.TraceExitMethod(8, 31479, 31831);

                bool
                f_8_31556_31584(Microsoft.CodeAnalysis.ConstantValue?
                objA, Microsoft.CodeAnalysis.ConstantValue
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 31556, 31584);
                    return return_v;
                }


                bool
                f_8_31665_31693(Microsoft.CodeAnalysis.ConstantValue?
                objA, object?
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 31665, 31693);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                f_8_31778_31796(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Discriminator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 31778, 31796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                f_8_31800_31819(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Discriminator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 31800, 31819);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 31479, 31831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 31479, 31831);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(ConstantValue? left, ConstantValue? right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 31843, 32196);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 31941, 32034) || true) && (f_8_31945_31973(right, left))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 31941, 32034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 32007, 32019);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 31941, 32034);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 32050, 32143) || true) && (f_8_32054_32081(left, null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(8, 32050, 32143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 32115, 32128);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(8, 32050, 32143);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 32159, 32185);

                return f_8_32166_32184(left, right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 31843, 32196);

                bool
                f_8_31945_31973(Microsoft.CodeAnalysis.ConstantValue?
                objA, Microsoft.CodeAnalysis.ConstantValue?
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 31945, 31973);
                    return return_v;
                }


                bool
                f_8_32054_32081(Microsoft.CodeAnalysis.ConstantValue?
                objA, object?
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 32054, 32081);
                    return return_v;
                }


                bool
                f_8_32166_32184(Microsoft.CodeAnalysis.ConstantValue
                this_param, Microsoft.CodeAnalysis.ConstantValue?
                other)
                {
                    var return_v = this_param.Equals(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 32166, 32184);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 31843, 32196);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 31843, 32196);
            }
        }

        public static bool operator !=(ConstantValue? left, ConstantValue? right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(8, 32208, 32341);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 32306, 32330);

                return !(left == right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(8, 32208, 32341);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 32208, 32341);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 32208, 32341);
            }
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 32353, 32462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 32411, 32451);

                return f_8_32418_32450(f_8_32418_32436(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(8, 32353, 32462);

                Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                f_8_32418_32436(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Discriminator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(8, 32418, 32436);
                    return return_v;
                }


                int
                f_8_32418_32450(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 32418, 32450);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 32353, 32462);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 32353, 32462);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(8, 32474, 32591);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 32539, 32580);

                return f_8_32546_32579(this, obj as ConstantValue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(8, 32474, 32591);

                bool
                f_8_32546_32579(Microsoft.CodeAnalysis.ConstantValue
                this_param, object?
                other)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.ConstantValue?)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(8, 32546, 32579);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(8, 32474, 32591);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 32474, 32591);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ConstantValue()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(8, 805, 32598);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(8, 805, 32598);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 805, 32598);
        }


        static ConstantValue()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(8, 805, 32598);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(8, 3776, 3795);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 1293, 1386);
            _s_IEEE_canonical_NaN = f_9_1317_1386(unchecked((long)0xFFF8000000000000UL)); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(8, 805, 32598);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(8, 805, 32598);
        }

        // LAFHIS (hand written)
        // BitConverter.Int64BitsToDouble(unchecked((long)0xFFF8000000000000UL))
        static double f_9_1317_1386(long a)
        {
            var temp = BitConverter.Int64BitsToDouble(a);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 1317, 1386);
            return temp;
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(8, 805, 32598);
    }
}
