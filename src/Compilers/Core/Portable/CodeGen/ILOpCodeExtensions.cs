// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Reflection.Metadata;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CodeGen
{
    internal static partial class ILOpCodeExtensions
    {
        public static int Size(this ILOpCode opcode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(60, 426, 794);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 495, 518);

                int
                code = (int)opcode
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 532, 783) || true) && (code <= 0xff)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 532, 783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 582, 608);

                    f_60_582_607(code < 0xf0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 626, 635);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(60, 532, 783);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 532, 783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 701, 741);

                    f_60_701_740((code & 0xff00) == 0xfe00);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 759, 768);

                    return 2;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(60, 532, 783);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(60, 426, 794);

                int
                f_60_582_607(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(60, 582, 607);
                    return 0;
                }


                int
                f_60_701_740(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(60, 701, 740);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(60, 426, 794);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(60, 426, 794);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ILOpCode GetLeaveOpcode(this ILOpCode opcode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(60, 806, 1175);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 890, 1099);

                switch (opcode)
                {

                    case ILOpCode.Br:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 890, 1099);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 977, 999);

                        return ILOpCode.Leave;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 890, 1099);

                    case ILOpCode.Br_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 890, 1099);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 1060, 1084);

                        return ILOpCode.Leave_s;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 890, 1099);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 1115, 1164);

                throw f_60_1121_1163(opcode);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(60, 806, 1175);

                System.Exception
                f_60_1121_1163(System.Reflection.Metadata.ILOpCode
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(60, 1121, 1163);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(60, 806, 1175);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(60, 806, 1175);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool HasVariableStackBehavior(this ILOpCode opcode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(60, 1187, 1585);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 1277, 1547);

                switch (opcode)
                {

                    case ILOpCode.Call:
                    case ILOpCode.Calli:
                    case ILOpCode.Callvirt:
                    case ILOpCode.Newobj:
                    case ILOpCode.Ret:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 1277, 1547);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 1520, 1532);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 1277, 1547);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 1561, 1574);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(60, 1187, 1585);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(60, 1187, 1585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(60, 1187, 1585);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsControlTransfer(this ILOpCode opcode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(60, 1756, 2328);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 1839, 1921) || true) && (f_60_1843_1860(opcode))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 1839, 1921);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 1894, 1906);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(60, 1839, 1921);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 1937, 2290);

                switch (opcode)
                {

                    case ILOpCode.Ret:
                    case ILOpCode.Throw:
                    case ILOpCode.Rethrow:
                    case ILOpCode.Endfilter:
                    case ILOpCode.Endfinally:
                    case ILOpCode.Switch:
                    case ILOpCode.Jmp:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 1937, 2290);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 2263, 2275);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 1937, 2290);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 2304, 2317);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(60, 1756, 2328);

                bool
                f_60_1843_1860(System.Reflection.Metadata.ILOpCode
                opCode)
                {
                    var return_v = opCode.IsBranch();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(60, 1843, 1860);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(60, 1756, 2328);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(60, 1756, 2328);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsConditionalBranch(this ILOpCode opcode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(60, 2340, 3836);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 2425, 3796);

                switch (opcode)
                {

                    case ILOpCode.Brtrue:
                    case ILOpCode.Brtrue_s:
                    case ILOpCode.Brfalse:
                    case ILOpCode.Brfalse_s:
                    case ILOpCode.Beq:
                    case ILOpCode.Beq_s:
                    case ILOpCode.Bne_un:
                    case ILOpCode.Bne_un_s:
                    case ILOpCode.Bge:
                    case ILOpCode.Bge_s:
                    case ILOpCode.Bge_un:
                    case ILOpCode.Bge_un_s:
                    case ILOpCode.Bgt:
                    case ILOpCode.Bgt_s:
                    case ILOpCode.Bgt_un:
                    case ILOpCode.Bgt_un_s:
                    case ILOpCode.Ble:
                    case ILOpCode.Ble_s:
                    case ILOpCode.Ble_un:
                    case ILOpCode.Ble_un_s:
                    case ILOpCode.Blt:
                    case ILOpCode.Blt_s:
                    case ILOpCode.Blt_un:
                    case ILOpCode.Blt_un_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 2425, 3796);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 3409, 3421);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 2425, 3796);
                        // these are not conditional

                        //case ILOpCode.Br:
                        //case ILOpCode.Br_s:
                        //case ILOpCode.Leave:
                        //case ILOpCode.Leave_s:

                        // this is treated specially. It will not use regular single label
                        //case ILOpCode.Switch
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 3812, 3825);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(60, 2340, 3836);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(60, 2340, 3836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(60, 2340, 3836);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsRelationalBranch(this ILOpCode opcode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(60, 3848, 4821);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 3932, 4781);

                switch (opcode)
                {

                    case ILOpCode.Beq:
                    case ILOpCode.Beq_s:
                    case ILOpCode.Bne_un:
                    case ILOpCode.Bne_un_s:
                    case ILOpCode.Bge:
                    case ILOpCode.Bge_s:
                    case ILOpCode.Bge_un:
                    case ILOpCode.Bge_un_s:
                    case ILOpCode.Bgt:
                    case ILOpCode.Bgt_s:
                    case ILOpCode.Bgt_un:
                    case ILOpCode.Bgt_un_s:
                    case ILOpCode.Ble:
                    case ILOpCode.Ble_s:
                    case ILOpCode.Ble_un:
                    case ILOpCode.Ble_un_s:
                    case ILOpCode.Blt:
                    case ILOpCode.Blt_s:
                    case ILOpCode.Blt_un:
                    case ILOpCode.Blt_un_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 3932, 4781);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 4754, 4766);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 3932, 4781);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 4797, 4810);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(60, 3848, 4821);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(60, 3848, 4821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(60, 3848, 4821);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool CanFallThrough(this ILOpCode opcode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(60, 4938, 6058);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 5244, 6019);

                switch (opcode)
                {

                    case ILOpCode.Br:
                    case ILOpCode.Br_s:
                    case ILOpCode.Ret:
                    case ILOpCode.Jmp:
                    case ILOpCode.Throw:
                    //NOTE: from the codegen view endfilter is a logical  "brfalse <continueHandlerSearch>" 
                    //      endfilter must be used once at the end of the filter and must be lexically followed by the handler
                    //      to which the control returns if filter result was 1.
                    //case ILOpCode.Endfilter:
                    case ILOpCode.Endfinally:
                    case ILOpCode.Leave:
                    case ILOpCode.Leave_s:
                    case ILOpCode.Rethrow:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 5244, 6019);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 5991, 6004);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 5244, 6019);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 6035, 6047);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(60, 4938, 6058);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(60, 4938, 6058);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(60, 4938, 6058);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int NetStackBehavior(this ILOpCode opcode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(60, 6070, 6281);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 6151, 6200);

                f_60_6151_6199(!f_60_6165_6198(opcode));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 6214, 6270);

                return f_60_6221_6244(opcode) - f_60_6247_6269(opcode);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(60, 6070, 6281);

                bool
                f_60_6165_6198(System.Reflection.Metadata.ILOpCode
                opcode)
                {
                    var return_v = opcode.HasVariableStackBehavior();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(60, 6165, 6198);
                    return return_v;
                }


                int
                f_60_6151_6199(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(60, 6151, 6199);
                    return 0;
                }


                int
                f_60_6221_6244(System.Reflection.Metadata.ILOpCode
                opcode)
                {
                    var return_v = opcode.StackPushCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(60, 6221, 6244);
                    return return_v;
                }


                int
                f_60_6247_6269(System.Reflection.Metadata.ILOpCode
                opcode)
                {
                    var return_v = opcode.StackPopCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(60, 6247, 6269);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(60, 6070, 6281);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(60, 6070, 6281);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int StackPopCount(this ILOpCode opcode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(60, 6293, 17016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 6371, 16940);

                switch (opcode)
                {

                    case ILOpCode.Nop:
                    case ILOpCode.Break:
                    case ILOpCode.Ldarg_0:
                    case ILOpCode.Ldarg_1:
                    case ILOpCode.Ldarg_2:
                    case ILOpCode.Ldarg_3:
                    case ILOpCode.Ldloc_0:
                    case ILOpCode.Ldloc_1:
                    case ILOpCode.Ldloc_2:
                    case ILOpCode.Ldloc_3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 6817, 6826);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Stloc_0:
                    case ILOpCode.Stloc_1:
                    case ILOpCode.Stloc_2:
                    case ILOpCode.Stloc_3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 7008, 7017);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Ldarg_s:
                    case ILOpCode.Ldarga_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 7120, 7129);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Starg_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 7191, 7200);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Ldloc_s:
                    case ILOpCode.Ldloca_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 7303, 7312);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Stloc_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 7374, 7383);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Ldnull:
                    case ILOpCode.Ldc_i4_m1:
                    case ILOpCode.Ldc_i4_0:
                    case ILOpCode.Ldc_i4_1:
                    case ILOpCode.Ldc_i4_2:
                    case ILOpCode.Ldc_i4_3:
                    case ILOpCode.Ldc_i4_4:
                    case ILOpCode.Ldc_i4_5:
                    case ILOpCode.Ldc_i4_6:
                    case ILOpCode.Ldc_i4_7:
                    case ILOpCode.Ldc_i4_8:
                    case ILOpCode.Ldc_i4_s:
                    case ILOpCode.Ldc_i4:
                    case ILOpCode.Ldc_i8:
                    case ILOpCode.Ldc_r4:
                    case ILOpCode.Ldc_r8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 8052, 8061);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Dup:
                    case ILOpCode.Pop:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 8155, 8164);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Jmp:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 8222, 8231);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Call:
                    case ILOpCode.Calli:
                    case ILOpCode.Ret:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 8364, 8374);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Br_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 8445, 8454);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Brfalse_s:
                    case ILOpCode.Brtrue_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 8559, 8568);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Beq_s:
                    case ILOpCode.Bge_s:
                    case ILOpCode.Bgt_s:
                    case ILOpCode.Ble_s:
                    case ILOpCode.Blt_s:
                    case ILOpCode.Bne_un_s:
                    case ILOpCode.Bge_un_s:
                    case ILOpCode.Bgt_un_s:
                    case ILOpCode.Ble_un_s:
                    case ILOpCode.Blt_un_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 8985, 8994);

                        return 2;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Br:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 9051, 9060);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Brfalse:
                    case ILOpCode.Brtrue:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 9161, 9170);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Beq:
                    case ILOpCode.Bge:
                    case ILOpCode.Bgt:
                    case ILOpCode.Ble:
                    case ILOpCode.Blt:
                    case ILOpCode.Bne_un:
                    case ILOpCode.Bge_un:
                    case ILOpCode.Bgt_un:
                    case ILOpCode.Ble_un:
                    case ILOpCode.Blt_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 9567, 9576);

                        return 2;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Switch:
                    case ILOpCode.Ldind_i1:
                    case ILOpCode.Ldind_u1:
                    case ILOpCode.Ldind_i2:
                    case ILOpCode.Ldind_u2:
                    case ILOpCode.Ldind_i4:
                    case ILOpCode.Ldind_u4:
                    case ILOpCode.Ldind_i8:
                    case ILOpCode.Ldind_i:
                    case ILOpCode.Ldind_r4:
                    case ILOpCode.Ldind_r8:
                    case ILOpCode.Ldind_ref:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 10088, 10097);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Stind_ref:
                    case ILOpCode.Stind_i1:
                    case ILOpCode.Stind_i2:
                    case ILOpCode.Stind_i4:
                    case ILOpCode.Stind_i8:
                    case ILOpCode.Stind_r4:
                    case ILOpCode.Stind_r8:
                    case ILOpCode.Add:
                    case ILOpCode.Sub:
                    case ILOpCode.Mul:
                    case ILOpCode.Div:
                    case ILOpCode.Div_un:
                    case ILOpCode.Rem:
                    case ILOpCode.Rem_un:
                    case ILOpCode.And:
                    case ILOpCode.Or:
                    case ILOpCode.Xor:
                    case ILOpCode.Shl:
                    case ILOpCode.Shr:
                    case ILOpCode.Shr_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 10883, 10892);

                        return 2;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Neg:
                    case ILOpCode.Not:
                    case ILOpCode.Conv_i1:
                    case ILOpCode.Conv_i2:
                    case ILOpCode.Conv_i4:
                    case ILOpCode.Conv_i8:
                    case ILOpCode.Conv_r4:
                    case ILOpCode.Conv_r8:
                    case ILOpCode.Conv_u4:
                    case ILOpCode.Conv_u8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 11306, 11315);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Callvirt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 11378, 11388);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Cpobj:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 11460, 11469);

                        return 2;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Ldobj:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 11529, 11538);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Ldstr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 11598, 11607);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Newobj:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 11668, 11678);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Castclass:
                    case ILOpCode.Isinst:
                    case ILOpCode.Conv_r_un:
                    case ILOpCode.Unbox:
                    case ILOpCode.Throw:
                    case ILOpCode.Ldfld:
                    case ILOpCode.Ldflda:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 11988, 11997);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Stfld:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 12057, 12066);

                        return 2;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Ldsfld:
                    case ILOpCode.Ldsflda:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 12167, 12176);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Stsfld:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 12237, 12246);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Stobj:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 12306, 12315);

                        return 2;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Conv_ovf_i1_un:
                    case ILOpCode.Conv_ovf_i2_un:
                    case ILOpCode.Conv_ovf_i4_un:
                    case ILOpCode.Conv_ovf_i8_un:
                    case ILOpCode.Conv_ovf_u1_un:
                    case ILOpCode.Conv_ovf_u2_un:
                    case ILOpCode.Conv_ovf_u4_un:
                    case ILOpCode.Conv_ovf_u8_un:
                    case ILOpCode.Conv_ovf_i_un:
                    case ILOpCode.Conv_ovf_u_un:
                    case ILOpCode.Box:
                    case ILOpCode.Newarr:
                    case ILOpCode.Ldlen:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 12918, 12927);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Ldelema:
                    case ILOpCode.Ldelem_i1:
                    case ILOpCode.Ldelem_u1:
                    case ILOpCode.Ldelem_i2:
                    case ILOpCode.Ldelem_u2:
                    case ILOpCode.Ldelem_i4:
                    case ILOpCode.Ldelem_u4:
                    case ILOpCode.Ldelem_i8:
                    case ILOpCode.Ldelem_i:
                    case ILOpCode.Ldelem_r4:
                    case ILOpCode.Ldelem_r8:
                    case ILOpCode.Ldelem_ref:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 13451, 13460);

                        return 2;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Stelem_i:
                    case ILOpCode.Stelem_i1:
                    case ILOpCode.Stelem_i2:
                    case ILOpCode.Stelem_i4:
                    case ILOpCode.Stelem_i8:
                    case ILOpCode.Stelem_r4:
                    case ILOpCode.Stelem_r8:
                    case ILOpCode.Stelem_ref:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 13818, 13827);

                        return 3;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Ldelem:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 13888, 13897);

                        return 2;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Stelem:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 13958, 13967);

                        return 3;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Unbox_any:
                    case ILOpCode.Conv_ovf_i1:
                    case ILOpCode.Conv_ovf_u1:
                    case ILOpCode.Conv_ovf_i2:
                    case ILOpCode.Conv_ovf_u2:
                    case ILOpCode.Conv_ovf_i4:
                    case ILOpCode.Conv_ovf_u4:
                    case ILOpCode.Conv_ovf_i8:
                    case ILOpCode.Conv_ovf_u8:
                    case ILOpCode.Refanyval:
                    case ILOpCode.Ckfinite:
                    case ILOpCode.Mkrefany:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 14507, 14516);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Ldtoken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 14578, 14587);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Conv_u2:
                    case ILOpCode.Conv_u1:
                    case ILOpCode.Conv_i:
                    case ILOpCode.Conv_ovf_i:
                    case ILOpCode.Conv_ovf_u:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 14814, 14823);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Add_ovf:
                    case ILOpCode.Add_ovf_un:
                    case ILOpCode.Mul_ovf:
                    case ILOpCode.Mul_ovf_un:
                    case ILOpCode.Sub_ovf:
                    case ILOpCode.Sub_ovf_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 15094, 15103);

                        return 2;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Endfinally:
                    case ILOpCode.Leave:
                    case ILOpCode.Leave_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 15246, 15255);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Stind_i:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 15317, 15326);

                        return 2;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Conv_u:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 15387, 15396);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Arglist:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 15458, 15467);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Ceq:
                    case ILOpCode.Cgt:
                    case ILOpCode.Cgt_un:
                    case ILOpCode.Clt:
                    case ILOpCode.Clt_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 15675, 15684);

                        return 2;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Ldftn:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 15744, 15753);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Ldvirtftn:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 15817, 15826);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Ldarg:
                    case ILOpCode.Ldarga:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 15925, 15934);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Starg:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 15994, 16003);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Ldloc:
                    case ILOpCode.Ldloca:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 16102, 16111);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Stloc:
                    case ILOpCode.Localloc:
                    case ILOpCode.Endfilter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 16254, 16263);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Unaligned:
                    case ILOpCode.Volatile:
                    case ILOpCode.Tail:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 16405, 16414);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Initobj:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 16476, 16485);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Constrained:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 16551, 16560);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Cpblk:
                    case ILOpCode.Initblk:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 16660, 16669);

                        return 3;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Rethrow:
                    case ILOpCode.Sizeof:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 16770, 16779);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Refanytype:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 16844, 16853);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);

                    case ILOpCode.Readonly:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 6371, 16940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 16916, 16925);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 6371, 16940);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 16956, 17005);

                throw f_60_16962_17004(opcode);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(60, 6293, 17016);

                System.Exception
                f_60_16962_17004(System.Reflection.Metadata.ILOpCode
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(60, 16962, 17004);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(60, 6293, 17016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(60, 6293, 17016);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int StackPushCount(this ILOpCode opcode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(60, 17028, 27150);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 17107, 27074);

                switch (opcode)
                {

                    case ILOpCode.Nop:
                    case ILOpCode.Break:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 17233, 17242);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Ldarg_0:
                    case ILOpCode.Ldarg_1:
                    case ILOpCode.Ldarg_2:
                    case ILOpCode.Ldarg_3:
                    case ILOpCode.Ldloc_0:
                    case ILOpCode.Ldloc_1:
                    case ILOpCode.Ldloc_2:
                    case ILOpCode.Ldloc_3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 17584, 17593);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Stloc_0:
                    case ILOpCode.Stloc_1:
                    case ILOpCode.Stloc_2:
                    case ILOpCode.Stloc_3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 17775, 17784);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Ldarg_s:
                    case ILOpCode.Ldarga_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 17887, 17896);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Starg_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 17958, 17967);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Ldloc_s:
                    case ILOpCode.Ldloca_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 18070, 18079);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Stloc_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 18141, 18150);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Ldnull:
                    case ILOpCode.Ldc_i4_m1:
                    case ILOpCode.Ldc_i4_0:
                    case ILOpCode.Ldc_i4_1:
                    case ILOpCode.Ldc_i4_2:
                    case ILOpCode.Ldc_i4_3:
                    case ILOpCode.Ldc_i4_4:
                    case ILOpCode.Ldc_i4_5:
                    case ILOpCode.Ldc_i4_6:
                    case ILOpCode.Ldc_i4_7:
                    case ILOpCode.Ldc_i4_8:
                    case ILOpCode.Ldc_i4_s:
                    case ILOpCode.Ldc_i4:
                    case ILOpCode.Ldc_i8:
                    case ILOpCode.Ldc_r4:
                    case ILOpCode.Ldc_r8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 18819, 18828);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Dup:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 18886, 18895);

                        return 2;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Pop:
                    case ILOpCode.Jmp:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 18989, 18998);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Call:
                    case ILOpCode.Calli:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 19095, 19105);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Ret:
                    case ILOpCode.Br_s:
                    case ILOpCode.Brfalse_s:
                    case ILOpCode.Brtrue_s:
                    case ILOpCode.Beq_s:
                    case ILOpCode.Bge_s:
                    case ILOpCode.Bgt_s:
                    case ILOpCode.Ble_s:
                    case ILOpCode.Blt_s:
                    case ILOpCode.Bne_un_s:
                    case ILOpCode.Bge_un_s:
                    case ILOpCode.Bgt_un_s:
                    case ILOpCode.Ble_un_s:
                    case ILOpCode.Blt_un_s:
                    case ILOpCode.Br:
                    case ILOpCode.Brfalse:
                    case ILOpCode.Brtrue:
                    case ILOpCode.Beq:
                    case ILOpCode.Bge:
                    case ILOpCode.Bgt:
                    case ILOpCode.Ble:
                    case ILOpCode.Blt:
                    case ILOpCode.Bne_un:
                    case ILOpCode.Bge_un:
                    case ILOpCode.Bgt_un:
                    case ILOpCode.Ble_un:
                    case ILOpCode.Blt_un:
                    case ILOpCode.Switch:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 20218, 20227);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Ldind_i1:
                    case ILOpCode.Ldind_u1:
                    case ILOpCode.Ldind_i2:
                    case ILOpCode.Ldind_u2:
                    case ILOpCode.Ldind_i4:
                    case ILOpCode.Ldind_u4:
                    case ILOpCode.Ldind_i8:
                    case ILOpCode.Ldind_i:
                    case ILOpCode.Ldind_r4:
                    case ILOpCode.Ldind_r8:
                    case ILOpCode.Ldind_ref:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 20700, 20709);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Stind_ref:
                    case ILOpCode.Stind_i1:
                    case ILOpCode.Stind_i2:
                    case ILOpCode.Stind_i4:
                    case ILOpCode.Stind_i8:
                    case ILOpCode.Stind_r4:
                    case ILOpCode.Stind_r8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 21019, 21028);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Add:
                    case ILOpCode.Sub:
                    case ILOpCode.Mul:
                    case ILOpCode.Div:
                    case ILOpCode.Div_un:
                    case ILOpCode.Rem:
                    case ILOpCode.Rem_un:
                    case ILOpCode.And:
                    case ILOpCode.Or:
                    case ILOpCode.Xor:
                    case ILOpCode.Shl:
                    case ILOpCode.Shr:
                    case ILOpCode.Shr_un:
                    case ILOpCode.Neg:
                    case ILOpCode.Not:
                    case ILOpCode.Conv_i1:
                    case ILOpCode.Conv_i2:
                    case ILOpCode.Conv_i4:
                    case ILOpCode.Conv_i8:
                    case ILOpCode.Conv_r4:
                    case ILOpCode.Conv_r8:
                    case ILOpCode.Conv_u4:
                    case ILOpCode.Conv_u8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 21918, 21927);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Callvirt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 21990, 22000);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Cpobj:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 22072, 22081);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Ldobj:
                    case ILOpCode.Ldstr:
                    case ILOpCode.Newobj:
                    case ILOpCode.Castclass:
                    case ILOpCode.Isinst:
                    case ILOpCode.Conv_r_un:
                    case ILOpCode.Unbox:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 22379, 22388);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Throw:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 22448, 22457);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Ldfld:
                    case ILOpCode.Ldflda:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 22556, 22565);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Stfld:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 22625, 22634);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Ldsfld:
                    case ILOpCode.Ldsflda:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 22735, 22744);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Stsfld:
                    case ILOpCode.Stobj:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 22843, 22852);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Conv_ovf_i1_un:
                    case ILOpCode.Conv_ovf_i2_un:
                    case ILOpCode.Conv_ovf_i4_un:
                    case ILOpCode.Conv_ovf_i8_un:
                    case ILOpCode.Conv_ovf_u1_un:
                    case ILOpCode.Conv_ovf_u2_un:
                    case ILOpCode.Conv_ovf_u4_un:
                    case ILOpCode.Conv_ovf_u8_un:
                    case ILOpCode.Conv_ovf_i_un:
                    case ILOpCode.Conv_ovf_u_un:
                    case ILOpCode.Box:
                    case ILOpCode.Newarr:
                    case ILOpCode.Ldlen:
                    case ILOpCode.Ldelema:
                    case ILOpCode.Ldelem_i1:
                    case ILOpCode.Ldelem_u1:
                    case ILOpCode.Ldelem_i2:
                    case ILOpCode.Ldelem_u2:
                    case ILOpCode.Ldelem_i4:
                    case ILOpCode.Ldelem_u4:
                    case ILOpCode.Ldelem_i8:
                    case ILOpCode.Ldelem_i:
                    case ILOpCode.Ldelem_r4:
                    case ILOpCode.Ldelem_r8:
                    case ILOpCode.Ldelem_ref:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 23957, 23966);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Stelem_i:
                    case ILOpCode.Stelem_i1:
                    case ILOpCode.Stelem_i2:
                    case ILOpCode.Stelem_i4:
                    case ILOpCode.Stelem_i8:
                    case ILOpCode.Stelem_r4:
                    case ILOpCode.Stelem_r8:
                    case ILOpCode.Stelem_ref:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 24324, 24333);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Ldelem:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 24394, 24403);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Stelem:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 24464, 24473);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Unbox_any:
                    case ILOpCode.Conv_ovf_i1:
                    case ILOpCode.Conv_ovf_u1:
                    case ILOpCode.Conv_ovf_i2:
                    case ILOpCode.Conv_ovf_u2:
                    case ILOpCode.Conv_ovf_i4:
                    case ILOpCode.Conv_ovf_u4:
                    case ILOpCode.Conv_ovf_i8:
                    case ILOpCode.Conv_ovf_u8:
                    case ILOpCode.Refanyval:
                    case ILOpCode.Ckfinite:
                    case ILOpCode.Mkrefany:
                    case ILOpCode.Ldtoken:
                    case ILOpCode.Conv_u2:
                    case ILOpCode.Conv_u1:
                    case ILOpCode.Conv_i:
                    case ILOpCode.Conv_ovf_i:
                    case ILOpCode.Conv_ovf_u:
                    case ILOpCode.Add_ovf:
                    case ILOpCode.Add_ovf_un:
                    case ILOpCode.Mul_ovf:
                    case ILOpCode.Mul_ovf_un:
                    case ILOpCode.Sub_ovf:
                    case ILOpCode.Sub_ovf_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 25507, 25516);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Endfinally:
                    case ILOpCode.Leave:
                    case ILOpCode.Leave_s:
                    case ILOpCode.Stind_i:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 25699, 25708);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Conv_u:
                    case ILOpCode.Arglist:
                    case ILOpCode.Ceq:
                    case ILOpCode.Cgt:
                    case ILOpCode.Cgt_un:
                    case ILOpCode.Clt:
                    case ILOpCode.Clt_un:
                    case ILOpCode.Ldftn:
                    case ILOpCode.Ldvirtftn:
                    case ILOpCode.Ldarg:
                    case ILOpCode.Ldarga:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 26152, 26161);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Starg:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 26221, 26230);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Ldloc:
                    case ILOpCode.Ldloca:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 26329, 26338);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Stloc:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 26398, 26407);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Localloc:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 26470, 26479);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Endfilter:
                    case ILOpCode.Unaligned:
                    case ILOpCode.Volatile:
                    case ILOpCode.Tail:
                    case ILOpCode.Initobj:
                    case ILOpCode.Constrained:
                    case ILOpCode.Cpblk:
                    case ILOpCode.Initblk:
                    case ILOpCode.Rethrow:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 26865, 26874);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Sizeof:
                    case ILOpCode.Refanytype:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 26978, 26987);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);

                    case ILOpCode.Readonly:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(60, 17107, 27074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 27050, 27059);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(60, 17107, 27074);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(60, 27090, 27139);

                throw f_60_27096_27138(opcode);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(60, 17028, 27150);

                System.Exception
                f_60_27096_27138(System.Reflection.Metadata.ILOpCode
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(60, 27096, 27138);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(60, 17028, 27150);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(60, 17028, 27150);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ILOpCodeExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(60, 361, 27157);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(60, 361, 27157);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(60, 361, 27157);
        }

    }
}
