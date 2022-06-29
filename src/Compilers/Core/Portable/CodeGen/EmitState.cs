// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CodeGen
{
    internal partial class ILBuilder
    {
        private struct EmitState
        {

            private int _maxStack;

            private int _curStack;

            private int _instructionsEmitted;

            internal int InstructionsEmitted
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(55, 786, 877);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(55, 830, 858);

                        return _instructionsEmitted;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(55, 786, 877);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(55, 721, 892);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(55, 721, 892);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal void InstructionAdded()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(55, 908, 1014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(55, 973, 999);

                    _instructionsEmitted += 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(55, 908, 1014);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(55, 908, 1014);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(55, 908, 1014);
                }
            }

            internal int MaxStack
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(55, 1185, 1265);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(55, 1229, 1246);

                        return _maxStack;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(55, 1185, 1265);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(55, 1131, 1462);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(55, 1131, 1462);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                private set
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(55, 1283, 1447);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(55, 1335, 1388);

                        f_55_1335_1387(value >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(55, 1348, 1386) && value <= ushort.MaxValue));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(55, 1410, 1428);

                        _maxStack = value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(55, 1283, 1447);

                        int
                        f_55_1335_1387(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(55, 1335, 1387);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(55, 1131, 1462);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(55, 1131, 1462);
                    }
                }
            }

            internal int CurStack
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(55, 1636, 1716);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(55, 1680, 1697);

                        return _curStack;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(55, 1636, 1716);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(55, 1582, 1913);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(55, 1582, 1913);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                private set
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(55, 1734, 1898);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(55, 1786, 1839);

                        f_55_1786_1838(value >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(55, 1799, 1837) && value <= ushort.MaxValue));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(55, 1861, 1879);

                        _curStack = value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(55, 1734, 1898);

                        int
                        f_55_1786_1838(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(55, 1786, 1838);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(55, 1582, 1913);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(55, 1582, 1913);
                    }
                }
            }

            internal void AdjustStack(int count)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(55, 2175, 2335);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(55, 2244, 2262);

                    CurStack += DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => count, 55, 2244, 2252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(55, 2280, 2320);

                    MaxStack = f_55_2291_2319(MaxStack, CurStack);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(55, 2175, 2335);

                    int
                    f_55_2291_2319(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Max(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(55, 2291, 2319);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(55, 2175, 2335);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(55, 2175, 2335);
                }
            }
            static EmitState()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(55, 551, 2346);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(55, 551, 2346);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(55, 551, 2346);
            }
        }
    }
}
