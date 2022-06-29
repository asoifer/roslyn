// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.Debugging;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CodeGen
{
    internal partial class ILBuilder
    {
        internal enum BlockType
        {
            Normal,
            Try,
            Catch,
            Filter,
            Finally,
            Fault,
            Switch
        }

        internal enum Reachability : byte
        {
            /// <summary>
            /// Block is not reachable or reachability analysis
            /// has not been performed.
            /// </summary>
            NotReachable = 0,

            /// <summary>
            /// Block can be reached either falling through
            /// from previous block or from branch.
            /// </summary>
            Reachable,

            /// <summary>
            /// Block is reachable from try or catch but
            /// finally prevents falling through.
            /// </summary>
            BlockedByFinally,
        }
        [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
        internal class BasicBlock
        {
            public static readonly ObjectPool<BasicBlock> Pool;

            private static ObjectPool<BasicBlock> CreatePool(int size)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(49, 1635, 1811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 1726, 1796);

                    return f_49_1733_1795(() => new PooledBasicBlock(), size);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(49, 1635, 1811);

                    Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                    f_49_1733_1795(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>.Factory
                    factory, int
                    size)
                    {
                        var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>(factory, size);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 1733, 1795);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 1635, 1811);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 1635, 1811);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected BasicBlock()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(49, 1827, 1879);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 2339, 2346);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 2393, 2417);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 2889, 2935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 3017, 3062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 4573, 4582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 4696, 4708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 4792, 4797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 4884, 4898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 5031, 5042);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 5174, 5186);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(49, 1827, 1879);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 1827, 1879);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 1827, 1879);
                }
            }

            internal BasicBlock(ILBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(49, 1895, 2061);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 2339, 2346);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 2393, 2417);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 2889, 2935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 3017, 3062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 4573, 4582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 4696, 4708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 4792, 4797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 4884, 4898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 5031, 5042);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 5174, 5186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 1966, 2008);

                    f_49_1966_2007(BitConverter.IsLittleEndian);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 2026, 2046);

                    f_49_2026_2045(this, builder);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(49, 1895, 2061);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 1895, 2061);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 1895, 2061);
                }
            }

            internal void Initialize(ILBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 2077, 2274);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 2153, 2176);

                    this.builder = builder;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 2194, 2218);

                    this.FirstILMarker = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 2236, 2259);

                    this.LastILMarker = -1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(49, 2077, 2274);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 2077, 2274);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 2077, 2274);
                }
            }

            internal ILBuilder builder;

            private Cci.PooledBlobBuilder _lazyRegularInstructions;

            public Cci.PooledBlobBuilder Writer
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 2500, 2791);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 2544, 2716) || true) && (_lazyRegularInstructions == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 2544, 2716);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 2630, 2693);

                            _lazyRegularInstructions = f_49_2657_2692();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(49, 2544, 2716);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 2740, 2772);

                        return _lazyRegularInstructions;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(49, 2500, 2791);

                        Microsoft.Cci.PooledBlobBuilder
                        f_49_2657_2692()
                        {
                            var return_v = Cci.PooledBlobBuilder.GetInstance();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 2657, 2692);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 2432, 2806);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 2432, 2806);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public int FirstILMarker { get; private set; }

            public int LastILMarker { get; private set; }

            public void AddILMarker(int marker)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 3078, 3687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 3333, 3399);

                    f_49_3333_3398((f_49_3347_3365(this) < 0) == (f_49_3375_3392(this) < 0));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 3417, 3492);

                    f_49_3417_3491((f_49_3431_3448(this) < 0) || (DynAbs.Tracing.TraceSender.Expression_False(49, 3430, 3490) || (f_49_3458_3475(this) + 1 == marker)));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 3512, 3627) || true) && (f_49_3516_3534(this) < 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 3512, 3627);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 3580, 3608);

                        this.FirstILMarker = marker;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(49, 3512, 3627);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 3645, 3672);

                    this.LastILMarker = marker;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(49, 3078, 3687);

                    int
                    f_49_3347_3365(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.FirstILMarker;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 3347, 3365);
                        return return_v;
                    }


                    int
                    f_49_3375_3392(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.LastILMarker;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 3375, 3392);
                        return return_v;
                    }


                    int
                    f_49_3333_3398(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 3333, 3398);
                        return 0;
                    }


                    int
                    f_49_3431_3448(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.LastILMarker;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 3431, 3448);
                        return return_v;
                    }


                    int
                    f_49_3458_3475(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.LastILMarker;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 3458, 3475);
                        return return_v;
                    }


                    int
                    f_49_3417_3491(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 3417, 3491);
                        return 0;
                    }


                    int
                    f_49_3516_3534(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.FirstILMarker;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 3516, 3534);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 3078, 3687);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 3078, 3687);
                }
            }

            public void RemoveTailILMarker(int marker)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 3703, 4428);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 3965, 4003);

                    f_49_3965_4002(f_49_3978_3996(this) >= 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 4021, 4058);

                    f_49_4021_4057(f_49_4034_4051(this) >= 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 4076, 4118);

                    f_49_4076_4117(f_49_4089_4106(this) == marker);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 4138, 4413) || true) && (f_49_4142_4160(this) == f_49_4164_4181(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 4138, 4413);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 4223, 4247);

                        this.FirstILMarker = -1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 4269, 4292);

                        this.LastILMarker = -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(49, 4138, 4413);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 4138, 4413);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 4374, 4394);

                        f_49_4374_4393_M(this.LastILMarker--);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(49, 4138, 4413);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(49, 3703, 4428);

                    int
                    f_49_3978_3996(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.FirstILMarker;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 3978, 3996);
                        return return_v;
                    }


                    int
                    f_49_3965_4002(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 3965, 4002);
                        return 0;
                    }


                    int
                    f_49_4034_4051(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.LastILMarker;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 4034, 4051);
                        return return_v;
                    }


                    int
                    f_49_4021_4057(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 4021, 4057);
                        return 0;
                    }


                    int
                    f_49_4089_4106(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.LastILMarker;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 4089, 4106);
                        return return_v;
                    }


                    int
                    f_49_4076_4117(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 4076, 4117);
                        return 0;
                    }


                    int
                    f_49_4142_4160(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.FirstILMarker;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 4142, 4160);
                        return return_v;
                    }


                    int
                    f_49_4164_4181(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.LastILMarker;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 4164, 4181);
                        return return_v;
                    }


                    int
                    f_49_4374_4393_M(int
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 4374, 4393);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 3703, 4428);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 3703, 4428);
                }
            }

            public BasicBlock NextBlock;

            private object _branchLabel;

            public int Start;

            private byte _revBranchCode;

            private ILOpCode _branchCode;

            internal Reachability Reachability;

            public virtual ExceptionHandlerScope EnclosingHandler
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 5317, 5324);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 5320, 5324);
                        return null; DynAbs.Tracing.TraceSender.TraceExitMethod(49, 5317, 5324);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 5317, 5324);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 5317, 5324);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal virtual void Free()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 5341, 5600);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 5402, 5585) || true) && (_lazyRegularInstructions != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 5402, 5585);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 5480, 5512);

                        f_49_5480_5511(_lazyRegularInstructions);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 5534, 5566);

                        _lazyRegularInstructions = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(49, 5402, 5585);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(49, 5341, 5600);

                    int
                    f_49_5480_5511(Microsoft.Cci.PooledBlobBuilder
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 5480, 5511);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 5341, 5600);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 5341, 5600);
                }
            }

            public object BranchLabel
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 5642, 5657);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 5645, 5657);
                        return _branchLabel; DynAbs.Tracing.TraceSender.TraceExitMethod(49, 5642, 5657);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 5642, 5657);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 5642, 5657);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public ILOpCode BranchCode
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 5733, 5815);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 5777, 5796);

                        return _branchCode;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(49, 5733, 5815);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 5674, 5931);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 5674, 5931);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                set
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 5833, 5916);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 5877, 5897);

                        _branchCode = value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(49, 5833, 5916);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 5674, 5931);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 5674, 5931);
                    }
                }
            }

            public ILOpCode RevBranchCode
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 6009, 6104);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 6053, 6085);

                        return (ILOpCode)_revBranchCode;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(49, 6009, 6104);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 5947, 6330);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 5947, 6330);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                set
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 6122, 6315);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 6166, 6245);

                        f_49_6166_6244((ILOpCode)(byte)value == value, "rev opcodes must fit in a byte");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 6267, 6296);

                        _revBranchCode = (byte)value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(49, 6122, 6315);

                        int
                        f_49_6166_6244(bool
                        condition, string
                        message)
                        {
                            Debug.Assert(condition, message);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 6166, 6244);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 5947, 6330);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 5947, 6330);
                    }
                }
            }

            public BasicBlock BranchBlock
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 6531, 6822);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 6575, 6600);

                        BasicBlock
                        result = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 6624, 6765) || true) && (f_49_6628_6639() != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 6624, 6765);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 6697, 6742);

                            result = builder._labelInfos[f_49_6726_6737()].bb;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(49, 6624, 6765);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 6789, 6803);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(49, 6531, 6822);

                        object
                        f_49_6628_6639()
                        {
                            var return_v = BranchLabel;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 6628, 6639);
                            return return_v;
                        }


                        object
                        f_49_6726_6737()
                        {
                            var return_v = BranchLabel;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 6726, 6737);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 6469, 6837);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 6469, 6837);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public void SetBranchCode(ILOpCode newBranchCode)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 6853, 7176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 6935, 7026);

                    f_49_6935_7025(f_49_6948_6985(f_49_6948_6963(this)) == f_49_6989_7024(newBranchCode));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 7044, 7109);

                    f_49_7044_7108(f_49_7057_7081(newBranchCode) == (_branchLabel != null));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 7129, 7161);

                    this.BranchCode = newBranchCode;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(49, 6853, 7176);

                    System.Reflection.Metadata.ILOpCode
                    f_49_6948_6963(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.BranchCode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 6948, 6963);
                        return return_v;
                    }


                    bool
                    f_49_6948_6985(System.Reflection.Metadata.ILOpCode
                    opcode)
                    {
                        var return_v = opcode.IsConditionalBranch();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 6948, 6985);
                        return return_v;
                    }


                    bool
                    f_49_6989_7024(System.Reflection.Metadata.ILOpCode
                    opcode)
                    {
                        var return_v = opcode.IsConditionalBranch();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 6989, 7024);
                        return return_v;
                    }


                    int
                    f_49_6935_7025(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 6935, 7025);
                        return 0;
                    }


                    bool
                    f_49_7057_7081(System.Reflection.Metadata.ILOpCode
                    opCode)
                    {
                        var return_v = opCode.IsBranch();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 7057, 7081);
                        return return_v;
                    }


                    int
                    f_49_7044_7108(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 7044, 7108);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 6853, 7176);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 6853, 7176);
                }
            }

            public void SetBranch(object newLabel, ILOpCode branchCode, ILOpCode revBranchCode)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 7192, 7413);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 7308, 7345);

                    f_49_7308_7344(this, newLabel, branchCode);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 7363, 7398);

                    this.RevBranchCode = revBranchCode;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(49, 7192, 7413);

                    int
                    f_49_7308_7344(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param, object
                    newLabel, System.Reflection.Metadata.ILOpCode
                    branchCode)
                    {
                        this_param.SetBranch(newLabel, branchCode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 7308, 7344);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 7192, 7413);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 7192, 7413);
                }
            }

            public void SetBranch(object newLabel, ILOpCode branchCode)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 7429, 8179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 7521, 7550);

                    this.BranchCode = branchCode;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 7570, 8164) || true) && (_branchLabel != newLabel)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 7570, 8164);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 7640, 7664);

                        _branchLabel = newLabel;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 7688, 8145) || true) && (f_49_7692_7729(f_49_7692_7707(this)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 7688, 8145);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 7779, 7810);

                            f_49_7779_7809(newLabel != null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 7838, 7889);

                            var
                            labelInfo = f_49_7854_7888(this.builder._labelInfos, newLabel)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 7915, 8122) || true) && (!labelInfo.targetOfConditionalBranches)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 7915, 8122);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 8015, 8095);

                                this.builder._labelInfos[newLabel] = labelInfo.SetTargetOfConditionalBranches();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(49, 7915, 8122);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(49, 7688, 8145);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(49, 7570, 8164);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(49, 7429, 8179);

                    System.Reflection.Metadata.ILOpCode
                    f_49_7692_7707(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.BranchCode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 7692, 7707);
                        return return_v;
                    }


                    bool
                    f_49_7692_7729(System.Reflection.Metadata.ILOpCode
                    opcode)
                    {
                        var return_v = opcode.IsConditionalBranch();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 7692, 7729);
                        return return_v;
                    }


                    int
                    f_49_7779_7809(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 7779, 7809);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo
                    f_49_7854_7888(Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo>
                    this_param, object
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 7854, 7888);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 7429, 8179);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 7429, 8179);
                }
            }

            private bool IsBranchToLabel
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 8403, 8469);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 8406, 8469);
                        return (f_49_8407_8423(this) != null) && (DynAbs.Tracing.TraceSender.Expression_True(49, 8406, 8469) && (f_49_8437_8452(this) != ILOpCode.Nop)); DynAbs.Tracing.TraceSender.TraceExitMethod(49, 8403, 8469);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 8403, 8469);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 8403, 8469);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public virtual BlockType Type
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 8516, 8535);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 8519, 8535);
                        return BlockType.Normal; DynAbs.Tracing.TraceSender.TraceExitMethod(49, 8516, 8535);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 8516, 8535);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 8516, 8535);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public BlobBuilder RegularInstructions
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 8699, 8726);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 8702, 8726);
                        return _lazyRegularInstructions; DynAbs.Tracing.TraceSender.TraceExitMethod(49, 8699, 8726);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 8699, 8726);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 8699, 8726);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool HasNoRegularInstructions
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 8911, 8946);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 8914, 8946);
                        return _lazyRegularInstructions == null; DynAbs.Tracing.TraceSender.TraceExitMethod(49, 8911, 8946);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 8911, 8946);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 8911, 8946);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public int RegularInstructionsLength
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 9000, 9039);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 9003, 9039);
                        return f_49_9003_9034_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_lazyRegularInstructions, 49, 9003, 9034)?.Count) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(49, 9003, 9039) ?? 0); DynAbs.Tracing.TraceSender.TraceExitMethod(49, 9000, 9039);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 9000, 9039);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 9000, 9039);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal void AdjustForDelta(int delta)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 9261, 9536);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 9381, 9406);

                    f_49_9381_9405(delta <= 0);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 9426, 9521) || true) && (delta != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 9426, 9521);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 9482, 9502);

                        this.Start += delta;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(49, 9426, 9521);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(49, 9261, 9536);

                    int
                    f_49_9381_9405(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 9381, 9405);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 9261, 9536);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 9261, 9536);
                }
            }

            internal void RewriteBranchesAcrossExceptionHandlers()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 9552, 10273);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 9639, 9839) || true) && (f_49_9643_9664(this) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 9639, 9839);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 9768, 9820);

                        f_49_9768_9819(f_49_9781_9810_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_49_9781_9792(), 49, 9781, 9810)?.EnclosingHandler) == null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(49, 9639, 9839);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 9859, 9889);

                    var
                    branchBlock = f_49_9877_9888()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 9907, 9998) || true) && (branchBlock == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 9907, 9998);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 9972, 9979);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(49, 9907, 9998);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 10018, 10258) || true) && (f_49_10022_10050(branchBlock) != f_49_10054_10075(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 10018, 10258);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 10186, 10239);

                        f_49_10186_10238(                    // Only unconditional branches can be replaced.
                                            this, f_49_10205_10237(f_49_10205_10220(this)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(49, 10018, 10258);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(49, 9552, 10273);

                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    f_49_9643_9664(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.EnclosingHandler;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 9643, 9664);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    f_49_9781_9792()
                    {
                        var return_v = BranchBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 9781, 9792);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope?
                    f_49_9781_9810_M(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 9781, 9810);
                        return return_v;
                    }


                    int
                    f_49_9768_9819(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 9768, 9819);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock?
                    f_49_9877_9888()
                    {
                        var return_v = BranchBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 9877, 9888);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    f_49_10022_10050(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.EnclosingHandler;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 10022, 10050);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope?
                    f_49_10054_10075(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.EnclosingHandler;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 10054, 10075);
                        return return_v;
                    }


                    System.Reflection.Metadata.ILOpCode
                    f_49_10205_10220(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.BranchCode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 10205, 10220);
                        return return_v;
                    }


                    System.Reflection.Metadata.ILOpCode
                    f_49_10205_10237(System.Reflection.Metadata.ILOpCode
                    opcode)
                    {
                        var return_v = opcode.GetLeaveOpcode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 10205, 10237);
                        return return_v;
                    }


                    int
                    f_49_10186_10238(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param, System.Reflection.Metadata.ILOpCode
                    newBranchCode)
                    {
                        this_param.SetBranchCode(newBranchCode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 10186, 10238);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 9552, 10273);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 9552, 10273);
                }
            }

            internal void ShortenBranches(ref int delta)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 10600, 12306);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 10754, 10863) || true) && (f_49_10758_10779_M(!this.IsBranchToLabel))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 10754, 10863);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 10821, 10828);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(49, 10754, 10863);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 10883, 10919);

                    var
                    curBranchCode = f_49_10903_10918(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 10937, 11067) || true) && (f_49_10941_10977(curBranchCode) == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 10937, 11067);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 11024, 11031);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(49, 10937, 11067);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 11268, 11293);

                    const int
                    reduction = -3
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 11313, 11324);

                    int
                    offset
                    = default(int);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 11342, 11383);

                    var
                    branchBlockStart = f_49_11365_11376().Start
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 11401, 12048) || true) && (branchBlockStart > Start)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 11401, 12048);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 11678, 11722);

                        offset = branchBlockStart - NextBlock.Start;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(49, 11401, 12048);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 11401, 12048);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 11959, 12029);

                        offset = branchBlockStart - (this.Start + f_49_12001_12015(this) + reduction);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(49, 11401, 12048);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 12068, 12291) || true) && (unchecked((sbyte)offset == offset))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 12068, 12291);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 12180, 12231);

                        f_49_12180_12230(                    //it fits!
                                            this, f_49_12199_12229(curBranchCode));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 12253, 12272);

                        delta += reduction;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(49, 12068, 12291);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(49, 10600, 12306);

                    bool
                    f_49_10758_10779_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 10758, 10779);
                        return return_v;
                    }


                    System.Reflection.Metadata.ILOpCode
                    f_49_10903_10918(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.BranchCode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 10903, 10918);
                        return return_v;
                    }


                    int
                    f_49_10941_10977(System.Reflection.Metadata.ILOpCode
                    opCode)
                    {
                        var return_v = opCode.GetBranchOperandSize();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 10941, 10977);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    f_49_11365_11376()
                    {
                        var return_v = BranchBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 11365, 11376);
                        return return_v;
                    }


                    int
                    f_49_12001_12015(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.TotalSize;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 12001, 12015);
                        return return_v;
                    }


                    System.Reflection.Metadata.ILOpCode
                    f_49_12199_12229(System.Reflection.Metadata.ILOpCode
                    opCode)
                    {
                        var return_v = opCode.GetShortBranch();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 12199, 12229);
                        return return_v;
                    }


                    int
                    f_49_12180_12230(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param, System.Reflection.Metadata.ILOpCode
                    newBranchCode)
                    {
                        this_param.SetBranchCode(newBranchCode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 12180, 12230);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 10600, 12306);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 10600, 12306);
                }
            }

            internal bool OptimizeBranches(ref int delta)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 12782, 14245);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 13018, 14197) || true) && (f_49_13022_13042(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 13018, 14197);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 13084, 13164);

                        f_49_13084_13163(f_49_13097_13107() != ILOpCode.Nop, "Nop branches should not have labels");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 13188, 13219);

                        var
                        next = f_49_13199_13218(this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 13243, 14178) || true) && (next != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 13243, 14178);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 13491, 13547) || true) && (f_49_13495_13533(this, next, ref delta))
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 13491, 13547);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 13535, 13547);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(49, 13491, 13547);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 13665, 13728) || true) && (f_49_13669_13714(this, next, ref delta))
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 13665, 13728);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 13716, 13728);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(49, 13665, 13728);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 13820, 13888) || true) && (f_49_13824_13874(this, next, ref delta))
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 13820, 13888);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 13876, 13888);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(49, 13820, 13888);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 14091, 14155) || true) && (f_49_14095_14141(this, next, ref delta))
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 14091, 14155);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 14143, 14155);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(49, 14091, 14155);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(49, 13243, 14178);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(49, 13018, 14197);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 14217, 14230);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(49, 12782, 14245);

                    bool
                    f_49_13022_13042(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.IsBranchToLabel;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 13022, 13042);
                        return return_v;
                    }


                    System.Reflection.Metadata.ILOpCode
                    f_49_13097_13107()
                    {
                        var return_v = BranchCode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 13097, 13107);
                        return return_v;
                    }


                    int
                    f_49_13084_13163(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 13084, 13163);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    f_49_13199_13218(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.NextNontrivial;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 13199, 13218);
                        return return_v;
                    }


                    bool
                    f_49_13495_13533(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    next, ref int
                    delta)
                    {
                        var return_v = this_param.TryOptimizeSameAsNext(next, ref delta);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 13495, 13533);
                        return return_v;
                    }


                    bool
                    f_49_13669_13714(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    next, ref int
                    delta)
                    {
                        var return_v = this_param.TryOptimizeBranchToNextOrRet(next, ref delta);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 13669, 13714);
                        return return_v;
                    }


                    bool
                    f_49_13824_13874(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    next, ref int
                    delta)
                    {
                        var return_v = this_param.TryOptimizeBranchOverUncondBranch(next, ref delta);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 13824, 13874);
                        return return_v;
                    }


                    bool
                    f_49_14095_14141(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    next, ref int
                    delta)
                    {
                        var return_v = this_param.TryOptimizeBranchToEquivalent(next, ref delta);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 14095, 14141);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 12782, 14245);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 12782, 14245);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private BasicBlock NextNontrivial
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 14327, 14706);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 14371, 14397);

                        var
                        next = this.NextBlock
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 14419, 14651) || true) && (next != null && (DynAbs.Tracing.TraceSender.Expression_True(49, 14426, 14498) && f_49_14467_14482(next) == ILOpCode.Nop) && (DynAbs.Tracing.TraceSender.Expression_True(49, 14426, 14556) && f_49_14527_14556(next)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 14419, 14651);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 14606, 14628);

                                next = next.NextBlock;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(49, 14419, 14651);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(49, 14419, 14651);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(49, 14419, 14651);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 14675, 14687);

                        return next;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(49, 14327, 14706);

                        System.Reflection.Metadata.ILOpCode
                        f_49_14467_14482(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.BranchCode;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 14467, 14482);
                            return return_v;
                        }


                        bool
                        f_49_14527_14556(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                        this_param)
                        {
                            var return_v = this_param.HasNoRegularInstructions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 14527, 14556);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 14261, 14721);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 14261, 14721);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private bool TryOptimizeSameAsNext(BasicBlock next, ref int delta)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 14737, 16508);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 14836, 16460) || true) && (f_49_14840_14869(next) && (DynAbs.Tracing.TraceSender.Expression_True(49, 14840, 14928) && f_49_14894_14909(next) == f_49_14913_14928(this)) && (DynAbs.Tracing.TraceSender.Expression_True(49, 14840, 15001) && f_49_14953_14969(next).Start == f_49_14979_14995(this).Start))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 14836, 16460);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 15043, 16441) || true) && (f_49_15047_15068(next) == f_49_15072_15093(this))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 15043, 16441);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 15143, 15218);

                            var
                            diff = f_49_15154_15176(f_49_15154_15169(this)) + f_49_15179_15217(f_49_15179_15194(this))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 15244, 15258);

                            delta -= diff;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 15284, 15319);

                            f_49_15284_15318(this, null, ILOpCode.Nop);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 15696, 16378) || true) && (f_49_15700_15729(this))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 15696, 16378);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 15787, 15824);

                                var
                                labelInfos = builder._labelInfos
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 15854, 15883);

                                var
                                labels = f_49_15867_15882(labelInfos)
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 15913, 16351);
                                    foreach (var label in f_49_15935_15941_I(labels))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 15913, 16351);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 16007, 16036);

                                        var
                                        info = f_49_16018_16035(labelInfos, label)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 16070, 16320) || true) && (info.bb == this)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 16070, 16320);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 16240, 16285);

                                            labelInfos[label] = info.WithNewTarget(next);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(49, 16070, 16320);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(49, 15913, 16351);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(49, 1, 439);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(49, 1, 439);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(49, 15696, 16378);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 16406, 16418);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(49, 15043, 16441);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(49, 14836, 16460);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 16480, 16493);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(49, 14737, 16508);

                    bool
                    f_49_14840_14869(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.HasNoRegularInstructions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 14840, 14869);
                        return return_v;
                    }


                    System.Reflection.Metadata.ILOpCode
                    f_49_14894_14909(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.BranchCode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 14894, 14909);
                        return return_v;
                    }


                    System.Reflection.Metadata.ILOpCode
                    f_49_14913_14928(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.BranchCode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 14913, 14928);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    f_49_14953_14969(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.BranchBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 14953, 14969);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    f_49_14979_14995(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.BranchBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 14979, 14995);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    f_49_15047_15068(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.EnclosingHandler;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 15047, 15068);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    f_49_15072_15093(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.EnclosingHandler;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 15072, 15093);
                        return return_v;
                    }


                    System.Reflection.Metadata.ILOpCode
                    f_49_15154_15169(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.BranchCode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 15154, 15169);
                        return return_v;
                    }


                    int
                    f_49_15154_15176(System.Reflection.Metadata.ILOpCode
                    opcode)
                    {
                        var return_v = opcode.Size();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 15154, 15176);
                        return return_v;
                    }


                    System.Reflection.Metadata.ILOpCode
                    f_49_15179_15194(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.BranchCode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 15179, 15194);
                        return return_v;
                    }


                    int
                    f_49_15179_15217(System.Reflection.Metadata.ILOpCode
                    opCode)
                    {
                        var return_v = opCode.GetBranchOperandSize();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 15179, 15217);
                        return return_v;
                    }


                    int
                    f_49_15284_15318(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param, object
                    newLabel, System.Reflection.Metadata.ILOpCode
                    branchCode)
                    {
                        this_param.SetBranch(newLabel, branchCode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 15284, 15318);
                        return 0;
                    }


                    bool
                    f_49_15700_15729(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.HasNoRegularInstructions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 15700, 15729);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo>.KeyCollection
                    f_49_15867_15882(Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo>
                    this_param)
                    {
                        var return_v = this_param.Keys;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 15867, 15882);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo
                    f_49_16018_16035(Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo>
                    this_param, object
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 16018, 16035);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo>.KeyCollection
                    f_49_15935_15941_I(Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo>.KeyCollection
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 15935, 15941);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 14737, 16508);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 14737, 16508);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool TryOptimizeBranchOverUncondBranch(BasicBlock next, ref int delta)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 16524, 18960);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 16635, 18912) || true) && (f_49_16639_16668(next) && (DynAbs.Tracing.TraceSender.Expression_True(49, 16639, 16715) && next.NextBlock != null) && (DynAbs.Tracing.TraceSender.Expression_True(49, 16639, 16781) && next.NextBlock.Start == f_49_16764_16775().Start) && (DynAbs.Tracing.TraceSender.Expression_True(49, 16639, 16874) && (f_49_16807_16822(next) == ILOpCode.Br || (DynAbs.Tracing.TraceSender.Expression_False(49, 16807, 16873) || f_49_16841_16856(next) == ILOpCode.Br_s))) && (DynAbs.Tracing.TraceSender.Expression_True(49, 16639, 16923) && f_49_16899_16915(next) != next))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 16635, 18912);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 16965, 17011);

                        ILOpCode
                        revBrOp = f_49_16984_17010(this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 17035, 18893) || true) && (revBrOp != ILOpCode.Nop)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 17035, 18893);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 17484, 17514);

                            var
                            toRemove = this.NextBlock
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 17540, 17575);

                            var
                            branchBlock = f_49_17558_17574(this)
                            ;
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 17601, 18116) || true) && (toRemove != branchBlock)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 17601, 18116);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 17689, 17747);

                                    f_49_17689_17746(toRemove == next || (DynAbs.Tracing.TraceSender.Expression_False(49, 17702, 17745) || f_49_17722_17740(toRemove) == 0));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 17777, 17939);

                                    // LAFHIS
                                    var temp = builder._labelInfos.Values.Any<Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo>(li => li.bb == toRemove);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 17791, 17846);

                                    //f_49_17777_17938(!f_49_17791_17846(builder._labelInfos.Values, li => li.bb == toRemove), "nothing should branch to a trivial block at this point");
                                    f_49_17777_17938(!temp, "nothing should branch to a trivial block at this point");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 17969, 18029);

                                    toRemove.Reachability = ILBuilder.Reachability.NotReachable;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 18059, 18089);

                                    toRemove = toRemove.NextBlock;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(49, 17601, 18116);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(49, 17601, 18116);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(49, 17601, 18116);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 18144, 18190);

                            next.Reachability = Reachability.NotReachable;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 18216, 18240);

                            delta -= f_49_18225_18239(next);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 18268, 18424) || true) && (f_49_18272_18287(next) == ILOpCode.Br_s)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 18268, 18424);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 18362, 18397);

                                revBrOp = f_49_18372_18396(revBrOp);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(49, 18268, 18424);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 18526, 18555);

                            this.NextBlock = f_49_18543_18554();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 18721, 18752);

                            var
                            origBrOp = f_49_18736_18751(this)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 18778, 18830);

                            f_49_18778_18829(this, f_49_18793_18809(next), revBrOp, origBrOp);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 18858, 18870);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(49, 17035, 18893);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(49, 16635, 18912);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 18932, 18945);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(49, 16524, 18960);

                    bool
                    f_49_16639_16668(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.HasNoRegularInstructions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 16639, 16668);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    f_49_16764_16775()
                    {
                        var return_v = BranchBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 16764, 16775);
                        return return_v;
                    }


                    System.Reflection.Metadata.ILOpCode
                    f_49_16807_16822(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.BranchCode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 16807, 16822);
                        return return_v;
                    }


                    System.Reflection.Metadata.ILOpCode
                    f_49_16841_16856(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.BranchCode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 16841, 16856);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    f_49_16899_16915(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.BranchBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 16899, 16915);
                        return return_v;
                    }


                    System.Reflection.Metadata.ILOpCode
                    f_49_16984_17010(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.GetReversedBranchOp();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 16984, 17010);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    f_49_17558_17574(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.BranchBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 17558, 17574);
                        return return_v;
                    }


                    int
                    f_49_17722_17740(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.TotalSize;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 17722, 17740);
                        return return_v;
                    }


                    int
                    f_49_17689_17746(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 17689, 17746);
                        return 0;
                    }


                    bool
                    f_49_17791_17846(ref Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo>.ValueCollection
                    source, System.Func<Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo, bool>
                    predicate)
                    {
                        var return_v = source.Any<Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo>(predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 17791, 17846);
                        return return_v;
                    }


                    int
                    f_49_17777_17938(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 17777, 17938);
                        return 0;
                    }


                    int
                    f_49_18225_18239(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.TotalSize;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 18225, 18239);
                        return return_v;
                    }


                    System.Reflection.Metadata.ILOpCode
                    f_49_18272_18287(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.BranchCode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 18272, 18287);
                        return return_v;
                    }


                    System.Reflection.Metadata.ILOpCode
                    f_49_18372_18396(System.Reflection.Metadata.ILOpCode
                    opCode)
                    {
                        var return_v = opCode.GetShortBranch();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 18372, 18396);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    f_49_18543_18554()
                    {
                        var return_v = BranchBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 18543, 18554);
                        return return_v;
                    }


                    System.Reflection.Metadata.ILOpCode
                    f_49_18736_18751(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.BranchCode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 18736, 18751);
                        return return_v;
                    }


                    object
                    f_49_18793_18809(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.BranchLabel;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 18793, 18809);
                        return return_v;
                    }


                    int
                    f_49_18778_18829(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param, object
                    newLabel, System.Reflection.Metadata.ILOpCode
                    branchCode, System.Reflection.Metadata.ILOpCode
                    revBranchCode)
                    {
                        this_param.SetBranch(newLabel, branchCode, revBranchCode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 18778, 18829);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 16524, 18960);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 16524, 18960);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool TryOptimizeBranchToNextOrRet(BasicBlock next, ref int delta)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 18976, 20195);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 19082, 19118);

                    var
                    curBranchCode = f_49_19102_19117(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 19136, 20147) || true) && (curBranchCode == ILOpCode.Br || (DynAbs.Tracing.TraceSender.Expression_False(49, 19140, 19202) || curBranchCode == ILOpCode.Br_s))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 19136, 20147);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 19294, 19626) || true) && (f_49_19298_19309().Start - next.Start == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 19294, 19626);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 19431, 19466);

                            f_49_19431_19465(                        // becomes a nop block
                                                    this, null, ILOpCode.Nop);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 19494, 19565);

                            delta -= (f_49_19504_19524(curBranchCode) + f_49_19527_19563(curBranchCode));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 19591, 19603);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(49, 19294, 19626);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 19699, 20128) || true) && (f_49_19703_19739(f_49_19703_19714()) && (DynAbs.Tracing.TraceSender.Expression_True(49, 19703, 19781) && f_49_19743_19765(f_49_19743_19754()) == ILOpCode.Ret))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 19699, 20128);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 19831, 19866);

                            f_49_19831_19865(this, null, ILOpCode.Ret);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 19992, 20067);

                            delta -= (f_49_20002_20022(curBranchCode) + f_49_20025_20061(curBranchCode) - 1);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 20093, 20105);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(49, 19699, 20128);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(49, 19136, 20147);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 20167, 20180);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(49, 18976, 20195);

                    System.Reflection.Metadata.ILOpCode
                    f_49_19102_19117(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.BranchCode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 19102, 19117);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    f_49_19298_19309()
                    {
                        var return_v = BranchBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 19298, 19309);
                        return return_v;
                    }


                    int
                    f_49_19431_19465(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param, object
                    newLabel, System.Reflection.Metadata.ILOpCode
                    branchCode)
                    {
                        this_param.SetBranch(newLabel, branchCode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 19431, 19465);
                        return 0;
                    }


                    int
                    f_49_19504_19524(System.Reflection.Metadata.ILOpCode
                    opcode)
                    {
                        var return_v = opcode.Size();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 19504, 19524);
                        return return_v;
                    }


                    int
                    f_49_19527_19563(System.Reflection.Metadata.ILOpCode
                    opCode)
                    {
                        var return_v = opCode.GetBranchOperandSize();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 19527, 19563);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    f_49_19703_19714()
                    {
                        var return_v = BranchBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 19703, 19714);
                        return return_v;
                    }


                    bool
                    f_49_19703_19739(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.HasNoRegularInstructions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 19703, 19739);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    f_49_19743_19754()
                    {
                        var return_v = BranchBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 19743, 19754);
                        return return_v;
                    }


                    System.Reflection.Metadata.ILOpCode
                    f_49_19743_19765(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.BranchCode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 19743, 19765);
                        return return_v;
                    }


                    int
                    f_49_19831_19865(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param, object
                    newLabel, System.Reflection.Metadata.ILOpCode
                    branchCode)
                    {
                        this_param.SetBranch(newLabel, branchCode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 19831, 19865);
                        return 0;
                    }


                    int
                    f_49_20002_20022(System.Reflection.Metadata.ILOpCode
                    opcode)
                    {
                        var return_v = opcode.Size();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 20002, 20022);
                        return return_v;
                    }


                    int
                    f_49_20025_20061(System.Reflection.Metadata.ILOpCode
                    opCode)
                    {
                        var return_v = opCode.GetBranchOperandSize();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 20025, 20061);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 18976, 20195);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 18976, 20195);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool TryOptimizeBranchToEquivalent(BasicBlock next, ref int delta)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 20211, 21505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 20318, 20354);

                    var
                    curBranchCode = f_49_20338_20353(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 20372, 21457) || true) && (f_49_20376_20411(curBranchCode) && (DynAbs.Tracing.TraceSender.Expression_True(49, 20376, 20482) && f_49_20436_20457(next) == f_49_20461_20482(this)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 20372, 21457);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 20631, 21438) || true) && (f_49_20635_20646().Start - next.Start == 0 || (DynAbs.Tracing.TraceSender.Expression_False(49, 20635, 20730) || f_49_20699_20730(f_49_20712_20723(), next)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 20631, 21438);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 20828, 20863);

                            f_49_20828_20862(                        // becomes a pop block
                                                    this, null, ILOpCode.Nop);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 20889, 20931);

                            f_49_20889_20930(f_49_20889_20900(this), ILOpCode.Pop);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 21066, 21141);

                            delta -= (f_49_21076_21096(curBranchCode) + f_49_21099_21135(curBranchCode) - 1);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 21169, 21375) || true) && (f_49_21173_21207(curBranchCode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 21169, 21375);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 21265, 21307);

                                f_49_21265_21306(f_49_21265_21276(this), ILOpCode.Pop);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 21337, 21348);

                                delta += 1;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(49, 21169, 21375);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 21403, 21415);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(49, 20631, 21438);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(49, 20372, 21457);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 21477, 21490);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(49, 20211, 21505);

                    System.Reflection.Metadata.ILOpCode
                    f_49_20338_20353(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.BranchCode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 20338, 20353);
                        return return_v;
                    }


                    bool
                    f_49_20376_20411(System.Reflection.Metadata.ILOpCode
                    opcode)
                    {
                        var return_v = opcode.IsConditionalBranch();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 20376, 20411);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    f_49_20436_20457(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.EnclosingHandler;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 20436, 20457);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    f_49_20461_20482(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.EnclosingHandler;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 20461, 20482);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    f_49_20635_20646()
                    {
                        var return_v = BranchBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 20635, 20646);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    f_49_20712_20723()
                    {
                        var return_v = BranchBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 20712, 20723);
                        return return_v;
                    }


                    bool
                    f_49_20699_20730(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    one, Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    another)
                    {
                        var return_v = AreIdentical(one, another);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 20699, 20730);
                        return return_v;
                    }


                    int
                    f_49_20828_20862(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param, object
                    newLabel, System.Reflection.Metadata.ILOpCode
                    branchCode)
                    {
                        this_param.SetBranch(newLabel, branchCode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 20828, 20862);
                        return 0;
                    }


                    Microsoft.Cci.PooledBlobBuilder
                    f_49_20889_20900(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.Writer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 20889, 20900);
                        return return_v;
                    }


                    int
                    f_49_20889_20930(Microsoft.Cci.PooledBlobBuilder
                    this_param, System.Reflection.Metadata.ILOpCode
                    value)
                    {
                        this_param.WriteByte((byte)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 20889, 20930);
                        return 0;
                    }


                    int
                    f_49_21076_21096(System.Reflection.Metadata.ILOpCode
                    opcode)
                    {
                        var return_v = opcode.Size();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 21076, 21096);
                        return return_v;
                    }


                    int
                    f_49_21099_21135(System.Reflection.Metadata.ILOpCode
                    opCode)
                    {
                        var return_v = opCode.GetBranchOperandSize();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 21099, 21135);
                        return return_v;
                    }


                    bool
                    f_49_21173_21207(System.Reflection.Metadata.ILOpCode
                    opcode)
                    {
                        var return_v = opcode.IsRelationalBranch();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 21173, 21207);
                        return return_v;
                    }


                    Microsoft.Cci.PooledBlobBuilder
                    f_49_21265_21276(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.Writer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 21265, 21276);
                        return return_v;
                    }


                    int
                    f_49_21265_21306(Microsoft.Cci.PooledBlobBuilder
                    this_param, System.Reflection.Metadata.ILOpCode
                    value)
                    {
                        this_param.WriteByte((byte)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 21265, 21306);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 20211, 21505);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 20211, 21505);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static bool AreIdentical(BasicBlock one, BasicBlock another)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(49, 21817, 22379);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 21918, 22331) || true) && (one._branchCode == another._branchCode && (DynAbs.Tracing.TraceSender.Expression_True(49, 21922, 22018) && !f_49_21986_22018(one._branchCode)) && (DynAbs.Tracing.TraceSender.Expression_True(49, 21922, 22083) && one._branchLabel == another._branchLabel))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 21918, 22331);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 22125, 22162);

                        var
                        instr1 = f_49_22138_22161(one)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 22184, 22225);

                        var
                        instr2 = f_49_22197_22224(another)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 22247, 22312);

                        return instr1 == instr2 || (DynAbs.Tracing.TraceSender.Expression_False(49, 22254, 22311) || f_49_22274_22303_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(instr1, 49, 22274, 22303)?.ContentEquals(instr2)) == true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(49, 21918, 22331);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 22351, 22364);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(49, 21817, 22379);

                    bool
                    f_49_21986_22018(System.Reflection.Metadata.ILOpCode
                    opcode)
                    {
                        var return_v = opcode.CanFallThrough();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 21986, 22018);
                        return return_v;
                    }


                    System.Reflection.Metadata.BlobBuilder
                    f_49_22138_22161(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.RegularInstructions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 22138, 22161);
                        return return_v;
                    }


                    System.Reflection.Metadata.BlobBuilder
                    f_49_22197_22224(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.RegularInstructions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 22197, 22224);
                        return return_v;
                    }


                    bool?
                    f_49_22274_22303_I(bool?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 22274, 22303);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 21817, 22379);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 21817, 22379);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private ILOpCode GetReversedBranchOp()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 22595, 23883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 22666, 22693);

                    var
                    result = f_49_22679_22692()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 22713, 22814) || true) && (result != ILOpCode.Nop)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 22713, 22814);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 22781, 22795);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(49, 22713, 22814);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 23094, 23834);

                    switch (f_49_23102_23117(this))
                    {

                        case ILOpCode.Brfalse:
                        case ILOpCode.Brfalse_s:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 23094, 23834);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 23253, 23278);

                            result = ILOpCode.Brtrue;
                            DynAbs.Tracing.TraceSender.TraceBreak(49, 23304, 23310);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(49, 23094, 23834);

                        case ILOpCode.Brtrue:
                        case ILOpCode.Brtrue_s:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 23094, 23834);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 23424, 23450);

                            result = ILOpCode.Brfalse;
                            DynAbs.Tracing.TraceSender.TraceBreak(49, 23476, 23482);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(49, 23094, 23834);

                        case ILOpCode.Beq:
                        case ILOpCode.Beq_s:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 23094, 23834);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 23590, 23615);

                            result = ILOpCode.Bne_un;
                            DynAbs.Tracing.TraceSender.TraceBreak(49, 23641, 23647);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(49, 23094, 23834);

                        case ILOpCode.Bne_un:
                        case ILOpCode.Bne_un_s:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 23094, 23834);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 23761, 23783);

                            result = ILOpCode.Beq;
                            DynAbs.Tracing.TraceSender.TraceBreak(49, 23809, 23815);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(49, 23094, 23834);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 23854, 23868);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(49, 22595, 23883);

                    System.Reflection.Metadata.ILOpCode
                    f_49_22679_22692()
                    {
                        var return_v = RevBranchCode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 22679, 22692);
                        return return_v;
                    }


                    System.Reflection.Metadata.ILOpCode
                    f_49_23102_23117(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.BranchCode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 23102, 23117);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 22595, 23883);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 22595, 23883);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public virtual int TotalSize
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 23960, 25009);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 24004, 24019);

                        int
                        branchSize
                        = default(int);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 24041, 24915);

                        switch (f_49_24049_24059())
                        {

                            case ILOpCode.Nop:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 24041, 24915);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 24157, 24172);

                                branchSize = 0;
                                DynAbs.Tracing.TraceSender.TraceBreak(49, 24261, 24267);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(49, 24041, 24915);

                            case ILOpCode.Ret:
                            case ILOpCode.Throw:
                            case ILOpCode.Endfinally:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 24041, 24915);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 24440, 24455);

                                branchSize = 1;
                                DynAbs.Tracing.TraceSender.TraceBreak(49, 24485, 24491);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(49, 24041, 24915);

                            case ILOpCode.Rethrow:
                            case ILOpCode.Endfilter:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 24041, 24915);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 24621, 24636);

                                branchSize = 2;
                                DynAbs.Tracing.TraceSender.TraceBreak(49, 24666, 24672);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(49, 24041, 24915);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 24041, 24915);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 24738, 24775);

                                f_49_24738_24774(f_49_24751_24768(f_49_24751_24761()) == 1);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 24805, 24856);

                                branchSize = 1 + f_49_24822_24855(f_49_24822_24832());
                                DynAbs.Tracing.TraceSender.TraceBreak(49, 24886, 24892);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(49, 24041, 24915);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 24939, 24990);

                        return (int)f_49_24951_24976() + branchSize;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(49, 23960, 25009);

                        System.Reflection.Metadata.ILOpCode
                        f_49_24049_24059()
                        {
                            var return_v = BranchCode;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 24049, 24059);
                            return return_v;
                        }


                        System.Reflection.Metadata.ILOpCode
                        f_49_24751_24761()
                        {
                            var return_v = BranchCode;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 24751, 24761);
                            return return_v;
                        }


                        int
                        f_49_24751_24768(System.Reflection.Metadata.ILOpCode
                        opcode)
                        {
                            var return_v = opcode.Size();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 24751, 24768);
                            return return_v;
                        }


                        int
                        f_49_24738_24774(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 24738, 24774);
                            return 0;
                        }


                        System.Reflection.Metadata.ILOpCode
                        f_49_24822_24832()
                        {
                            var return_v = BranchCode;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 24822, 24832);
                            return return_v;
                        }


                        int
                        f_49_24822_24855(System.Reflection.Metadata.ILOpCode
                        opCode)
                        {
                            var return_v = opCode.GetBranchOperandSize();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 24822, 24855);
                            return return_v;
                        }


                        int
                        f_49_24951_24976()
                        {
                            var return_v = RegularInstructionsLength;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 24951, 24976);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 23899, 25024);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 23899, 25024);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private string GetDebuggerDisplay()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 25040, 25534);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 25119, 25228);

                    var
                    visType = f_49_25133_25227("Roslyn.Test.Utilities.ILBuilderVisualizer, Roslyn.Test.Utilities", false)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 25246, 25481) || true) && (visType != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 25246, 25481);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 25307, 25382);

                        var
                        method = f_49_25320_25381(f_49_25320_25341(visType), "BasicBlockToString")
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 25404, 25462);

                        return (string)f_49_25419_25461(method, null, new object[] { this });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(49, 25246, 25481);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 25509, 25519);

                    return "";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(49, 25040, 25534);

                    System.Type?
                    f_49_25133_25227(string
                    typeName, bool
                    throwOnError)
                    {
                        var return_v = System.Type.GetType(typeName, throwOnError);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 25133, 25227);
                        return return_v;
                    }


                    System.Reflection.TypeInfo
                    f_49_25320_25341(System.Type
                    type)
                    {
                        var return_v = type.GetTypeInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 25320, 25341);
                        return return_v;
                    }


                    System.Reflection.MethodInfo?
                    f_49_25320_25381(System.Reflection.TypeInfo
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetDeclaredMethod(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 25320, 25381);
                        return return_v;
                    }


                    object?
                    f_49_25419_25461(System.Reflection.MethodInfo?
                    this_param, object?
                    obj, object[]
                    parameters)
                    {
                        var return_v = this_param.Invoke(obj, parameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 25419, 25461);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 25040, 25534);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 25040, 25534);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            private class PooledBasicBlock : BasicBlock
            {
                internal override void Free()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 25626, 26107);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 25696, 25708);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Free(), 49, 25696, 25707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 25732, 25752);

                        _branchLabel = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 25774, 25805);

                        this.BranchCode = ILOpCode.Nop;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 25827, 25846);

                        _revBranchCode = 0;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 25868, 25890);

                        this.NextBlock = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 25912, 25932);

                        this.builder = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 25954, 26000);

                        this.Reachability = Reachability.NotReachable;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 26022, 26037);

                        this.Start = 0;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 26061, 26088);

                        f_49_26061_26087(
                                            BasicBlock.Pool, this);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(49, 25626, 26107);

                        int
                        f_49_26061_26087(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                        this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock.PooledBasicBlock
                        obj)
                        {
                            this_param.Free((Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock)obj);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 26061, 26087);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 25626, 26107);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 25626, 26107);
                    }
                }

                public PooledBasicBlock()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(49, 25550, 26122);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(49, 25550, 26122);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 25550, 26122);
                }


                static PooledBasicBlock()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(49, 25550, 26122);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(49, 25550, 26122);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 25550, 26122);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(49, 25550, 26122);
            }

            static BasicBlock()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(49, 1446, 26133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 1599, 1620);
                Pool = f_49_1606_1620(32); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(49, 1446, 26133);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 1446, 26133);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(49, 1446, 26133);

            static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
            f_49_1606_1620(int
            size)
            {
                var return_v = CreatePool(size);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 1606, 1620);
                return return_v;
            }


            static int
            f_49_1966_2007(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 1966, 2007);
                return 0;
            }


            static int
            f_49_2026_2045(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
            this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder
            builder)
            {
                this_param.Initialize(builder);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 2026, 2045);
                return 0;
            }


            object
            f_49_8407_8423(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
            this_param)
            {
                var return_v = this_param.BranchLabel;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 8407, 8423);
                return return_v;
            }


            System.Reflection.Metadata.ILOpCode
            f_49_8437_8452(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
            this_param)
            {
                var return_v = this_param.BranchCode;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 8437, 8452);
                return return_v;
            }


            int?
            f_49_9003_9034_M(int?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 9003, 9034);
                return return_v;
            }

        }
        internal class BasicBlockWithHandlerScope : BasicBlock
        {
            public readonly ExceptionHandlerScope enclosingHandler;

            public BasicBlockWithHandlerScope(ILBuilder builder, ExceptionHandlerScope enclosingHandler)
            : base(f_49_26470_26477_C(builder))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(49, 26353, 26567);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 26320, 26336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 26511, 26552);

                    this.enclosingHandler = enclosingHandler;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(49, 26353, 26567);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 26353, 26567);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 26353, 26567);
                }
            }

            public override ExceptionHandlerScope EnclosingHandler
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 26638, 26657);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 26641, 26657);
                        return enclosingHandler; DynAbs.Tracing.TraceSender.TraceExitMethod(49, 26638, 26657);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 26638, 26657);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 26638, 26657);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static BasicBlockWithHandlerScope()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(49, 26145, 26669);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(49, 26145, 26669);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 26145, 26669);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(49, 26145, 26669);

            static Microsoft.CodeAnalysis.CodeGen.ILBuilder
            f_49_26470_26477_C(Microsoft.CodeAnalysis.CodeGen.ILBuilder
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(49, 26353, 26567);
                return return_v;
            }

        }
        internal sealed class ExceptionHandlerLeaderBlock : BasicBlockWithHandlerScope
        {
            private readonly BlockType _type;

            public ExceptionHandlerLeaderBlock(ILBuilder builder, ExceptionHandlerScope enclosingHandler, BlockType type) : base(f_49_26967_26974_C(builder), enclosingHandler)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(49, 26833, 27054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 26811, 26816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 27221, 27241);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 27026, 27039);

                    _type = type;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(49, 26833, 27054);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 26833, 27054);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 26833, 27054);
                }
            }

            public ExceptionHandlerLeaderBlock NextExceptionHandler;

            public override BlockType Type
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 27289, 27297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 27292, 27297);
                        return _type; DynAbs.Tracing.TraceSender.TraceExitMethod(49, 27289, 27297);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 27289, 27297);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 27289, 27297);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override string ToString()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 27365, 27398);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 27368, 27398);
                    return $"[{_type}] {DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ToString(), 49, 27381, 27396)}"; DynAbs.Tracing.TraceSender.TraceExitMethod(49, 27365, 27398);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 27365, 27398);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 27365, 27398);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ExceptionHandlerLeaderBlock()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(49, 26681, 27410);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(49, 26681, 27410);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 26681, 27410);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(49, 26681, 27410);

            static Microsoft.CodeAnalysis.CodeGen.ILBuilder
            f_49_26967_26974_C(Microsoft.CodeAnalysis.CodeGen.ILBuilder
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(49, 26833, 27054);
                return return_v;
            }

        }
        internal sealed class SwitchBlock : BasicBlockWithHandlerScope
        {
            public SwitchBlock(ILBuilder builder, ExceptionHandlerScope enclosingHandler) : base(f_49_27822_27829_C(builder), enclosingHandler)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(49, 27720, 27932);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 28083, 28095);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 27881, 27917);

                    f_49_27881_27916(this, ILOpCode.Switch);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(49, 27720, 27932);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 27720, 27932);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 27720, 27932);
                }
            }

            public override BlockType Type
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 27979, 27998);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 27982, 27998);
                        return BlockType.Switch; DynAbs.Tracing.TraceSender.TraceExitMethod(49, 27979, 27998);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 27979, 27998);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 27979, 27998);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public object[] BranchLabels;

            public uint BranchesCount
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 28170, 28323);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 28214, 28249);

                        f_49_28214_28248(BranchLabels != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 28271, 28304);

                        return (uint)f_49_28284_28303(BranchLabels);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(49, 28170, 28323);

                        int
                        f_49_28214_28248(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 28214, 28248);
                            return 0;
                        }


                        int
                        f_49_28284_28303(object[]
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 28284, 28303);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 28112, 28338);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 28112, 28338);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public void GetBranchBlocks(ArrayBuilder<BasicBlock> branchBlocksBuilder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 28405, 28953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 28659, 28691);

                    f_49_28659_28690(f_49_28672_28685() > 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 28709, 28751);

                    f_49_28709_28750(branchBlocksBuilder != null);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 28771, 28938);
                        foreach (var branchLabel in f_49_28799_28816_I(this.BranchLabels))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(49, 28771, 28938);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 28858, 28919);

                            f_49_28858_28918(branchBlocksBuilder, builder._labelInfos[branchLabel].bb);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(49, 28771, 28938);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(49, 1, 168);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(49, 1, 168);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(49, 28405, 28953);

                    uint
                    f_49_28672_28685()
                    {
                        var return_v = BranchesCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 28672, 28685);
                        return return_v;
                    }


                    int
                    f_49_28659_28690(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 28659, 28690);
                        return 0;
                    }


                    int
                    f_49_28709_28750(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 28709, 28750);
                        return 0;
                    }


                    int
                    f_49_28858_28918(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                    this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock?
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 28858, 28918);
                        return 0;
                    }


                    object[]
                    f_49_28799_28816_I(object[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 28799, 28816);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 28405, 28953);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 28405, 28953);
                }
            }

            public override int TotalSize
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(49, 29031, 29494);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 29355, 29400);

                        uint
                        branchSize = 5 + 4 * f_49_29381_29399(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(49, 29422, 29475);

                        return (int)(f_49_29435_29460() + branchSize);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(49, 29031, 29494);

                        uint
                        f_49_29381_29399(Microsoft.CodeAnalysis.CodeGen.ILBuilder.SwitchBlock
                        this_param)
                        {
                            var return_v = this_param.BranchesCount;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 29381, 29399);
                            return return_v;
                        }


                        int
                        f_49_29435_29460()
                        {
                            var return_v = RegularInstructionsLength;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(49, 29435, 29460);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(49, 28969, 29509);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 28969, 29509);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static SwitchBlock()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(49, 27633, 29520);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(49, 27633, 29520);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 27633, 29520);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(49, 27633, 29520);

            static int
            f_49_27881_27916(Microsoft.CodeAnalysis.CodeGen.ILBuilder.SwitchBlock
            this_param, System.Reflection.Metadata.ILOpCode
            newBranchCode)
            {
                this_param.SetBranchCode(newBranchCode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(49, 27881, 27916);
                return 0;
            }


            static Microsoft.CodeAnalysis.CodeGen.ILBuilder
            f_49_27822_27829_C(Microsoft.CodeAnalysis.CodeGen.ILBuilder
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(49, 27720, 27932);
                return return_v;
            }

        }

        static ILBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(49, 514, 29527);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(49, 514, 29527);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(49, 514, 29527);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(49, 514, 29527);
    }
}
