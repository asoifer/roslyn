// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using System.Text;
using Microsoft.CodeAnalysis.Collections;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{

    internal struct SymbolCompletionState
    {

        private volatile int _completeParts;

        internal int IncompleteParts
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10163, 1397, 1497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 1433, 1482);

                    return ~_completeParts & (int)CompletionPart.All;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10163, 1397, 1497);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10163, 1344, 1508);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10163, 1344, 1508);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void DefaultForceComplete(Symbol symbol, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10163, 2106, 3858);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 2217, 2257);

                f_10163_2217_2256(f_10163_2230_2255(symbol));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 2271, 3704) || true) && (!HasComplete(CompletionPart.Attributes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10163, 2271, 3704);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 2348, 2375);

                    _ = f_10163_2352_2374(symbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 3626, 3689);

                    SpinWaitComplete(CompletionPart.Attributes, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10163, 2271, 3704);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 3810, 3847);

                NotePartComplete(CompletionPart.All);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10163, 2106, 3858);

                bool
                f_10163_2230_2255(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.RequiresCompletion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10163, 2230, 2255);
                    return return_v;
                }


                int
                f_10163_2217_2256(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10163, 2217, 2256);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10163_2352_2374(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10163, 2352, 2374);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10163, 2106, 3858);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10163, 2106, 3858);
            }
        }

        internal bool HasComplete(CompletionPart part)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10163, 3870, 4223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 4163, 4212);

                return (_completeParts & (int)part) == (int)part;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10163, 3870, 4223);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10163, 3870, 4223);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10163, 3870, 4223);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool NotePartComplete(CompletionPart part)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10163, 4235, 4592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 4484, 4551);

                return f_10163_4491_4550(ref _completeParts, part);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10163, 4235, 4592);

                bool
                f_10163_4491_4550(ref int
                flags, Microsoft.CodeAnalysis.CSharp.Symbols.CompletionPart
                toSet)
                {
                    var return_v = ThreadSafeFlagOperations.Set(ref flags, (int)toSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10163, 4491, 4550);
                    return return_v;
                }

#pragma warning restore 0420
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10163, 4235, 4592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10163, 4235, 4592);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CompletionPart NextIncompletePart
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10163, 4800, 5429);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 5138, 5171);

                    int
                    incomplete = IncompleteParts
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 5189, 5231);

                    int
                    next = incomplete & ~(incomplete - 1)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 5249, 5368);

                    f_10163_5249_5367(HasAtMostOneBitSet(next), "ForceComplete won't handle the result correctly if more than one bit is set.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 5386, 5414);

                    return (CompletionPart)next;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10163, 4800, 5429);

                    int
                    f_10163_5249_5367(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10163, 5249, 5367);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10163, 4733, 5440);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10163, 4733, 5440);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static bool HasAtMostOneBitSet(int bits)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10163, 5686, 5803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 5760, 5792);

                return (bits & (bits - 1)) == 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10163, 5686, 5803);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10163, 5686, 5803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10163, 5686, 5803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void SpinWaitComplete(CompletionPart part, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10163, 5815, 6419);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 5928, 6005) || true) && (HasComplete(part))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10163, 5928, 6005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 5983, 5990);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10163, 5928, 6005);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 6203, 6233);

                var
                spinWait = f_10163_6218_6232()
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 6247, 6408) || true) && (!HasComplete(part))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10163, 6247, 6408);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 6306, 6355);

                        cancellationToken.ThrowIfCancellationRequested();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 6373, 6393);

                        spinWait.SpinOnce();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10163, 6247, 6408);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10163, 6247, 6408);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10163, 6247, 6408);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10163, 5815, 6419);

                System.Threading.SpinWait
                f_10163_6218_6232()
                {
                    var return_v = new System.Threading.SpinWait();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10163, 6218, 6232);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10163, 5815, 6419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10163, 5815, 6419);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10163, 6431, 7074);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 6489, 6532);

                StringBuilder
                result = f_10163_6512_6531()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 6546, 6580);

                f_10163_6546_6579(result, "CompletionParts(");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 6594, 6611);

                bool
                any = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 6634, 6639);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 6625, 6991) || true) && (true)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 6643, 6646)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10163, 6625, 6991))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10163, 6625, 6991);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 6680, 6699);

                        int
                        bit = (1 << i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 6717, 6765) || true) && ((bit & (int)CompletionPart.All) == 0)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10163, 6717, 6765);
                            DynAbs.Tracing.TraceSender.TraceBreak(10163, 6759, 6765);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10163, 6717, 6765);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 6783, 6976) || true) && ((bit & _completeParts) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10163, 6783, 6976);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 6856, 6885) || true) && (any)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10163, 6856, 6885);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 6865, 6885);

                                f_10163_6865_6884(result, ", ");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10163, 6856, 6885);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 6907, 6924);

                            f_10163_6907_6923(result, i);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 6946, 6957);

                            any = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10163, 6783, 6976);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10163, 1, 367);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10163, 1, 367);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 7005, 7024);

                f_10163_7005_7023(result, ")");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10163, 7038, 7063);

                return f_10163_7045_7062(result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10163, 6431, 7074);

                System.Text.StringBuilder
                f_10163_6512_6531()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10163, 6512, 6531);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10163_6546_6579(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10163, 6546, 6579);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10163_6865_6884(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10163, 6865, 6884);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10163_6907_6923(System.Text.StringBuilder
                this_param, int
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10163, 6907, 6923);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10163_7005_7023(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10163, 7005, 7023);
                    return return_v;
                }


                string
                f_10163_7045_7062(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10163, 7045, 7062);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10163, 6431, 7074);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10163, 6431, 7074);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static SymbolCompletionState()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10163, 554, 7081);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10163, 554, 7081);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10163, 554, 7081);
        }
    }
}
