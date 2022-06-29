// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CodeGen
{

    internal partial struct SwitchIntegralJumpTableEmitter
    {

        private readonly ILBuilder _builder;

        private readonly LocalOrParameter _key;

        private readonly Cci.PrimitiveTypeCode _keyTypeCode;

        private readonly object _fallThroughLabel;

        private readonly ImmutableArray<KeyValuePair<ConstantValue, object>> _sortedCaseLabels;

        private const int
        LinearSearchThreshold = 3
        ;

        internal SwitchIntegralJumpTableEmitter(
                    ILBuilder builder,
                    KeyValuePair<ConstantValue, object>[] caseLabels,
                    object fallThroughLabel,
                    Cci.PrimitiveTypeCode keyTypeCode,
                    LocalOrParameter key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(84, 1796, 2492);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 2077, 2096);

                _builder = builder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 2110, 2121);

                _key = key;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 2135, 2162);

                _keyTypeCode = keyTypeCode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 2176, 2213);

                _fallThroughLabel = fallThroughLabel;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 2311, 2347);

                f_84_2311_2346(f_84_2324_2341(caseLabels) > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 2361, 2413);

                f_84_2361_2412(caseLabels, CompareIntegralSwitchLabels);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 2427, 2481);

                _sortedCaseLabels = f_84_2447_2480(caseLabels);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(84, 1796, 2492);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(84, 1796, 2492);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(84, 1796, 2492);
            }
        }

        internal void EmitJumpTable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(84, 2504, 5641);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 4207, 4248);

                f_84_4207_4247(f_84_4220_4246_M(!_sortedCaseLabels.IsEmpty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 4262, 4303);

                var
                sortedCaseLabels = _sortedCaseLabels
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 4319, 4367);

                int
                endLabelIndex = sortedCaseLabels.Length - 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 4381, 4401);

                int
                startLabelIndex
                = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 4595, 5048) || true) && (sortedCaseLabels[0].Key != f_84_4626_4644())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 4595, 5048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 4678, 4698);

                    startLabelIndex = 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(84, 4595, 5048);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 4595, 5048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 5013, 5033);

                    startLabelIndex = 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(84, 4595, 5048);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 5064, 5630) || true) && (startLabelIndex <= endLabelIndex)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 5064, 5630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 5262, 5366);

                    ImmutableArray<SwitchBucket>
                    switchBuckets = this.GenerateSwitchBuckets(startLabelIndex, endLabelIndex)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 5430, 5497);

                    this.EmitSwitchBuckets(switchBuckets, 0, switchBuckets.Length - 1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(84, 5064, 5630);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 5064, 5630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 5563, 5615);

                    f_84_5563_5614(_builder, ILOpCode.Br, _fallThroughLabel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(84, 5064, 5630);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(84, 2504, 5641);

                bool
                f_84_4220_4246_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(84, 4220, 4246);
                    return return_v;
                }


                int
                f_84_4207_4247(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 4207, 4247);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_84_4626_4644()
                {
                    var return_v = ConstantValue.Null;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(84, 4626, 4644);
                    return return_v;
                }


                int
                f_84_5563_5614(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, object
                label)
                {
                    this_param.EmitBranch(code, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 5563, 5614);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(84, 2504, 5641);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(84, 2504, 5641);
            }
        }

        private static int CompareIntegralSwitchLabels(KeyValuePair<ConstantValue, object> first, KeyValuePair<ConstantValue, object> second)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(84, 5696, 6480);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 5854, 5894);

                ConstantValue
                firstConstant = first.Key
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 5908, 5950);

                ConstantValue
                secondConstant = second.Key
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 5966, 6008);

                f_84_5966_6007(firstConstant != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 6022, 6152);

                f_84_6022_6151(f_84_6035_6106(firstConstant) && (DynAbs.Tracing.TraceSender.Expression_True(84, 6035, 6150) && f_84_6127_6150_M(!firstConstant.IsString)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 6168, 6211);

                f_84_6168_6210(secondConstant != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 6225, 6357);

                f_84_6225_6356(f_84_6238_6310(secondConstant) && (DynAbs.Tracing.TraceSender.Expression_True(84, 6238, 6355) && f_84_6331_6355_M(!secondConstant.IsString)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 6373, 6469);

                return f_84_6380_6468(firstConstant, secondConstant);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(84, 5696, 6480);

                int
                f_84_5966_6007(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 5966, 6007);
                    return 0;
                }


                bool
                f_84_6035_6106(Microsoft.CodeAnalysis.ConstantValue
                constant)
                {
                    var return_v = SwitchConstantValueHelper.IsValidSwitchCaseLabelConstant(constant);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 6035, 6106);
                    return return_v;
                }


                bool
                f_84_6127_6150_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(84, 6127, 6150);
                    return return_v;
                }


                int
                f_84_6022_6151(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 6022, 6151);
                    return 0;
                }


                int
                f_84_6168_6210(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 6168, 6210);
                    return 0;
                }


                bool
                f_84_6238_6310(Microsoft.CodeAnalysis.ConstantValue
                constant)
                {
                    var return_v = SwitchConstantValueHelper.IsValidSwitchCaseLabelConstant(constant);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 6238, 6310);
                    return return_v;
                }


                bool
                f_84_6331_6355_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(84, 6331, 6355);
                    return return_v;
                }


                int
                f_84_6225_6356(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 6225, 6356);
                    return 0;
                }


                int
                f_84_6380_6468(Microsoft.CodeAnalysis.ConstantValue
                first, Microsoft.CodeAnalysis.ConstantValue
                second)
                {
                    var return_v = SwitchConstantValueHelper.CompareSwitchCaseLabelConstants(first, second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 6380, 6468);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(84, 5696, 6480);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(84, 5696, 6480);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<SwitchBucket> GenerateSwitchBuckets(int startLabelIndex, int endLabelIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(84, 7191, 10260);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 7314, 7385);

                f_84_7314_7384(startLabelIndex >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(84, 7327, 7383) && startLabelIndex <= endLabelIndex));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 7399, 7454);

                f_84_7399_7453(_sortedCaseLabels.Length > endLabelIndex);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 7522, 7588);

                var
                switchBucketsStack = f_84_7547_7587()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 7604, 7645);

                int
                curStartLabelIndex = startLabelIndex
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 7707, 8902) || true) && (curStartLabelIndex <= endLabelIndex)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 7707, 8902);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 7783, 7860);

                        SwitchBucket
                        newBucket = CreateNextBucket(curStartLabelIndex, endLabelIndex)
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 8118, 8696) || true) && (!f_84_8126_8154(switchBucketsStack))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 8118, 8696);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 8255, 8307);

                                SwitchBucket
                                prevBucket = f_84_8281_8306(switchBucketsStack)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 8329, 8677) || true) && (newBucket.TryMergeWith(prevBucket))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 8329, 8677);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 8484, 8509);

                                    f_84_8484_8508(                        // pop the previous bucket from the stack
                                                            switchBucketsStack);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(84, 8329, 8677);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 8329, 8677);
                                    DynAbs.Tracing.TraceSender.TraceBreak(84, 8648, 8654);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(84, 8329, 8677);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(84, 8118, 8696);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(84, 8118, 8696);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(84, 8118, 8696);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 8765, 8800);

                        switchBucketsStack.Push(newBucket);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 8866, 8887);

                        curStartLabelIndex++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(84, 7707, 8902);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(84, 7707, 8902);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(84, 7707, 8902);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 8918, 8962);

                f_84_8918_8961(!f_84_8932_8960(switchBucketsStack));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 9054, 9110);

                var
                crumbled = f_84_9069_9109()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 9124, 10156);
                    foreach (var uncrumbled in f_84_9151_9169_I(switchBucketsStack))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 9124, 10156);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 9203, 9258);

                        var
                        degenerateSplit = uncrumbled.DegenerateBucketSplit
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 9276, 10141);

                        switch (degenerateSplit)
                        {

                            case -1:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 9276, 10141);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 9419, 9444);

                                f_84_9419_9443(                        // cannot be split
                                                        crumbled, uncrumbled);
                                DynAbs.Tracing.TraceSender.TraceBreak(84, 9470, 9476);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(84, 9276, 10141);

                            case 0:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 9276, 10141);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 9580, 9704);

                                f_84_9580_9703(                        // already degenerate
                                                        crumbled, f_84_9593_9702(_sortedCaseLabels, uncrumbled.StartLabelIndex, uncrumbled.EndLabelIndex, isDegenerate: true));
                                DynAbs.Tracing.TraceSender.TraceBreak(84, 9730, 9736);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(84, 9276, 10141);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 9276, 10141);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 9832, 9951);

                                f_84_9832_9950(                        // can split
                                                        crumbled, f_84_9845_9949(_sortedCaseLabels, uncrumbled.StartLabelIndex, degenerateSplit - 1, isDegenerate: true));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 9977, 10090);

                                f_84_9977_10089(crumbled, f_84_9990_10088(_sortedCaseLabels, degenerateSplit, uncrumbled.EndLabelIndex, isDegenerate: true));
                                DynAbs.Tracing.TraceSender.TraceBreak(84, 10116, 10122);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(84, 9276, 10141);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(84, 9124, 10156);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(84, 1, 1033);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(84, 1, 1033);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 10172, 10198);

                f_84_10172_10197(
                            switchBucketsStack);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 10212, 10249);

                return f_84_10219_10248(crumbled);
                DynAbs.Tracing.TraceSender.TraceExitMethod(84, 7191, 10260);

                int
                f_84_7314_7384(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 7314, 7384);
                    return 0;
                }


                int
                f_84_7399_7453(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 7399, 7453);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket>
                f_84_7547_7587()
                {
                    var return_v = ArrayBuilder<SwitchBucket>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 7547, 7587);
                    return return_v;
                }


                bool
                f_84_8126_8154(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket>
                source)
                {
                    var return_v = source.IsEmpty<Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 8126, 8154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket
                f_84_8281_8306(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket>
                builder)
                {
                    var return_v = builder.Peek<Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 8281, 8306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket
                f_84_8484_8508(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket>
                builder)
                {
                    var return_v = builder.Pop<Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 8484, 8508);
                    return return_v;
                }


                bool
                f_84_8932_8960(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket>
                source)
                {
                    var return_v = source.IsEmpty<Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 8932, 8960);
                    return return_v;
                }


                int
                f_84_8918_8961(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 8918, 8961);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket>
                f_84_9069_9109()
                {
                    var return_v = ArrayBuilder<SwitchBucket>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 9069, 9109);
                    return return_v;
                }


                int
                f_84_9419_9443(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket>
                this_param, Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 9419, 9443);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket
                f_84_9593_9702(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>
                allLabels, int
                startIndex, int
                endIndex, bool
                isDegenerate)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket(allLabels, startIndex, endIndex, isDegenerate: isDegenerate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 9593, 9702);
                    return return_v;
                }


                int
                f_84_9580_9703(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket>
                this_param, Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 9580, 9703);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket
                f_84_9845_9949(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>
                allLabels, int
                startIndex, int
                endIndex, bool
                isDegenerate)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket(allLabels, startIndex, endIndex, isDegenerate: isDegenerate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 9845, 9949);
                    return return_v;
                }


                int
                f_84_9832_9950(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket>
                this_param, Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 9832, 9950);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket
                f_84_9990_10088(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>
                allLabels, int
                startIndex, int
                endIndex, bool
                isDegenerate)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket(allLabels, startIndex, endIndex, isDegenerate: isDegenerate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 9990, 10088);
                    return return_v;
                }


                int
                f_84_9977_10089(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket>
                this_param, Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 9977, 10089);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket>
                f_84_9151_9169_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 9151, 9169);
                    return return_v;
                }


                int
                f_84_10172_10197(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 10172, 10197);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket>
                f_84_10219_10248(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 10219, 10248);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(84, 7191, 10260);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(84, 7191, 10260);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SwitchBucket CreateNextBucket(int startLabelIndex, int endLabelIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(84, 10272, 10530);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 10374, 10445);

                f_84_10374_10444(startLabelIndex >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(84, 10387, 10443) && startLabelIndex <= endLabelIndex));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 10459, 10519);

                return f_84_10466_10518(_sortedCaseLabels, startLabelIndex);
                DynAbs.Tracing.TraceSender.TraceExitMethod(84, 10272, 10530);

                int
                f_84_10374_10444(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 10374, 10444);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket
                f_84_10466_10518(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>
                allLabels, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter.SwitchBucket(allLabels, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 10466, 10518);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(84, 10272, 10530);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(84, 10272, 10530);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EmitSwitchBucketsLinearLeaf(ImmutableArray<SwitchBucket> switchBuckets, int low, int high)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(84, 10612, 11113);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 10749, 10756);
                    for (int
        i = low
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 10740, 11024) || true) && (i < high)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 10768, 10771)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(84, 10740, 11024))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 10740, 11024);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 10805, 10840);

                        var
                        nextBucketLabel = f_84_10827_10839()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 10858, 10915);

                        this.EmitSwitchBucket(switchBuckets[i], nextBucketLabel);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 10973, 11009);

                        f_84_10973_11008(
                                        //  nextBucketLabel:
                                        _builder, nextBucketLabel);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(84, 1, 285);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(84, 1, 285);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 11040, 11102);

                this.EmitSwitchBucket(switchBuckets[high], _fallThroughLabel);
                DynAbs.Tracing.TraceSender.TraceExitMethod(84, 10612, 11113);

                object
                f_84_10827_10839()
                {
                    var return_v = new object();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 10827, 10839);
                    return return_v;
                }


                int
                f_84_10973_11008(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, object
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 10973, 11008);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(84, 10612, 11113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(84, 10612, 11113);
            }
        }

        private void EmitSwitchBuckets(ImmutableArray<SwitchBucket> switchBuckets, int low, int high)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(84, 11125, 12988);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 11304, 11475) || true) && (high - low < LinearSearchThreshold)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 11304, 11475);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 11376, 11435);

                    this.EmitSwitchBucketsLinearLeaf(switchBuckets, low, high);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 11453, 11460);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(84, 11304, 11475);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 11712, 11743);

                int
                mid = (low + high + 1) / 2
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 11759, 11797);

                object
                secondHalfLabel = f_84_11784_11796()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 11932, 11997);

                ConstantValue
                pivotConstant = switchBuckets[mid - 1].EndConstant
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 12100, 12273);

                this.EmitCondBranchForSwitch((DynAbs.Tracing.TraceSender.Conditional_F1(84, 12147, 12172) || ((f_84_12147_12172(_keyTypeCode) && DynAbs.Tracing.TraceSender.Conditional_F2(84, 12175, 12190)) || DynAbs.Tracing.TraceSender.Conditional_F3(84, 12193, 12205))) ? ILOpCode.Bgt_un : ILOpCode.Bgt, pivotConstant, secondHalfLabel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 12321, 12373);

                this.EmitSwitchBuckets(switchBuckets, low, mid - 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 12843, 12879);

                f_84_12843_12878(
                            // NOTE:    Typically marking a synthetic label needs a hidden sequence point.
                            // NOTE:    Otherwise if you step (F11) to this label debugger may highlight previous (lexically) statement.
                            // NOTE:    We do not need a hidden point in this implementation since we do not interleave jump table
                            // NOTE:    and cases so the "previous" statement will always be "switch".

                            //  secondHalfLabel:
                            _builder, secondHalfLabel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 12928, 12977);

                this.EmitSwitchBuckets(switchBuckets, mid, high);
                DynAbs.Tracing.TraceSender.TraceExitMethod(84, 11125, 12988);

                object
                f_84_11784_11796()
                {
                    var return_v = new object();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 11784, 11796);
                    return return_v;
                }


                bool
                f_84_12147_12172(Microsoft.Cci.PrimitiveTypeCode
                kind)
                {
                    var return_v = kind.IsUnsigned();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 12147, 12172);
                    return return_v;
                }


                int
                f_84_12843_12878(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, object
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 12843, 12878);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(84, 11125, 12988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(84, 11125, 12988);
            }
        }

        private void EmitSwitchBucket(SwitchBucket switchBucket, object bucketFallThroughLabel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(84, 13000, 14461);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 13112, 14337) || true) && (switchBucket.LabelsCount == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 13112, 14337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 13179, 13203);

                    var
                    c = switchBucket[0]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 13303, 13334);

                    ConstantValue
                    constant = c.Key
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 13352, 13379);

                    object
                    caseLabel = c.Value
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 13397, 13445);

                    this.EmitEqBranchForSwitch(constant, caseLabel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(84, 13112, 14337);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 13112, 14337);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 13511, 14322) || true) && (switchBucket.IsDegenerate)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 13511, 14322);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 13582, 13682);

                        EmitRangeCheckedBranch(switchBucket.StartConstant, switchBucket.EndConstant, switchBucket[0].Value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(84, 13511, 14322);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 13511, 14322);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 13853, 13960);

                        this.EmitNormalizedSwitchKey(switchBucket.StartConstant, switchBucket.EndConstant, bucketFallThroughLabel);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 14081, 14137);

                        object[]
                        labels = this.CreateBucketLabels(switchBucket)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 14275, 14303);

                        f_84_14275_14302(
                                            //  switch (N, label1, label2... labelN)
                                            // Emit the switch instruction
                                            _builder, labels);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(84, 13511, 14322);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(84, 13112, 14337);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 14393, 14450);

                f_84_14393_14449(
                            //  goto fallThroughLabel;
                            _builder, ILOpCode.Br, bucketFallThroughLabel);
                DynAbs.Tracing.TraceSender.TraceExitMethod(84, 13000, 14461);

                int
                f_84_14275_14302(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, object[]
                labels)
                {
                    this_param.EmitSwitch(labels);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 14275, 14302);
                    return 0;
                }


                int
                f_84_14393_14449(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, object
                label)
                {
                    this_param.EmitBranch(code, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 14393, 14449);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(84, 13000, 14461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(84, 13000, 14461);
            }
        }

        private object[] CreateBucketLabels(SwitchBucket switchBucket)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(84, 14473, 16743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 14914, 14971);

                ConstantValue
                startConstant = switchBucket.StartConstant
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 14985, 15046);

                bool
                hasNegativeCaseLabels = f_84_15014_15045(startConstant)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 15062, 15084);

                int
                nextCaseIndex = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 15098, 15137);

                ulong
                nextCaseLabelNormalizedValue = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 15153, 15196);

                ulong
                bucketSize = switchBucket.BucketSize
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 15210, 15251);

                object[]
                labels = new object[bucketSize]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 15278, 15283);

                    for (ulong
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 15267, 16632) || true) && (i < bucketSize)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 15301, 15304)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(84, 15267, 16632))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 15267, 16632);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 15338, 16567) || true) && (i == nextCaseLabelNormalizedValue)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 15338, 16567);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 15417, 15463);

                            labels[i] = switchBucket[nextCaseIndex].Value;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 15485, 15501);

                            nextCaseIndex++;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 15525, 15709) || true) && (nextCaseIndex >= switchBucket.LabelsCount)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 15525, 15709);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 15620, 15654);

                                f_84_15620_15653(i == bucketSize - 1);
                                DynAbs.Tracing.TraceSender.TraceBreak(84, 15680, 15686);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(84, 15525, 15709);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 15733, 15799);

                            ConstantValue
                            caseLabelConstant = switchBucket[nextCaseIndex].Key
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 15821, 16515) || true) && (hasNegativeCaseLabels)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 15821, 16515);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 15896, 15950);

                                var
                                nextCaseLabelValue = f_84_15921_15949(caseLabelConstant)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 15976, 16036);

                                f_84_15976_16035(nextCaseLabelValue > f_84_16010_16034(startConstant));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 16062, 16148);

                                nextCaseLabelNormalizedValue = (ulong)(nextCaseLabelValue - f_84_16122_16146(startConstant));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(84, 15821, 16515);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 15821, 16515);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 16246, 16301);

                                var
                                nextCaseLabelValue = f_84_16271_16300(caseLabelConstant)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 16327, 16388);

                                f_84_16327_16387(nextCaseLabelValue > f_84_16361_16386(startConstant));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 16414, 16492);

                                nextCaseLabelNormalizedValue = nextCaseLabelValue - f_84_16466_16491(startConstant);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(84, 15821, 16515);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 16539, 16548);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(84, 15338, 16567);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 16587, 16617);

                        labels[i] = _fallThroughLabel;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(84, 1, 1366);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(84, 1, 1366);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 16648, 16704);

                f_84_16648_16703(nextCaseIndex >= switchBucket.LabelsCount);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 16718, 16732);

                return labels;
                DynAbs.Tracing.TraceSender.TraceExitMethod(84, 14473, 16743);

                bool
                f_84_15014_15045(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsNegativeNumeric;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(84, 15014, 15045);
                    return return_v;
                }


                int
                f_84_15620_15653(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 15620, 15653);
                    return 0;
                }


                long
                f_84_15921_15949(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(84, 15921, 15949);
                    return return_v;
                }


                long
                f_84_16010_16034(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(84, 16010, 16034);
                    return return_v;
                }


                int
                f_84_15976_16035(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 15976, 16035);
                    return 0;
                }


                long
                f_84_16122_16146(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(84, 16122, 16146);
                    return return_v;
                }


                ulong
                f_84_16271_16300(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(84, 16271, 16300);
                    return return_v;
                }


                ulong
                f_84_16361_16386(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(84, 16361, 16386);
                    return return_v;
                }


                int
                f_84_16327_16387(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 16327, 16387);
                    return 0;
                }


                ulong
                f_84_16466_16491(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(84, 16466, 16491);
                    return return_v;
                }


                int
                f_84_16648_16703(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 16648, 16703);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(84, 14473, 16743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(84, 14473, 16743);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EmitCondBranchForSwitch(ILOpCode branchCode, ConstantValue constant, object targetLabel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(84, 16818, 17470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 16944, 16980);

                f_84_16944_16979(f_84_16957_16978(branchCode));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 16994, 17118);

                f_84_16994_17117(constant != null && (DynAbs.Tracing.TraceSender.Expression_True(84, 17013, 17116) && f_84_17050_17116(constant)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 17132, 17172);

                f_84_17132_17171(targetLabel != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 17291, 17315);

                f_84_17291_17314(
                            // ldloc key
                            // ldc constant
                            // branch branchCode targetLabel

                            _builder, _key);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 17329, 17366);

                f_84_17329_17365(_builder, constant);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 17380, 17459);

                f_84_17380_17458(_builder, branchCode, targetLabel, GetReverseBranchCode(branchCode));
                DynAbs.Tracing.TraceSender.TraceExitMethod(84, 16818, 17470);

                bool
                f_84_16957_16978(System.Reflection.Metadata.ILOpCode
                opCode)
                {
                    var return_v = opCode.IsBranch();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 16957, 16978);
                    return return_v;
                }


                int
                f_84_16944_16979(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 16944, 16979);
                    return 0;
                }


                bool
                f_84_17050_17116(Microsoft.CodeAnalysis.ConstantValue
                constant)
                {
                    var return_v = SwitchConstantValueHelper.IsValidSwitchCaseLabelConstant(constant);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 17050, 17116);
                    return return_v;
                }


                int
                f_84_16994_17117(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 16994, 17117);
                    return 0;
                }


                int
                f_84_17132_17171(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 17132, 17171);
                    return 0;
                }


                int
                f_84_17291_17314(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalOrParameter
                localOrParameter)
                {
                    this_param.EmitLoad(localOrParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 17291, 17314);
                    return 0;
                }


                int
                f_84_17329_17365(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.ConstantValue
                value)
                {
                    this_param.EmitConstantValue(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 17329, 17365);
                    return 0;
                }


                int
                f_84_17380_17458(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, object
                label, System.Reflection.Metadata.ILOpCode
                revOpCode)
                {
                    this_param.EmitBranch(code, label, revOpCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 17380, 17458);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(84, 16818, 17470);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(84, 16818, 17470);
            }
        }

        private void EmitEqBranchForSwitch(ConstantValue constant, object targetLabel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(84, 17482, 18195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 17585, 17709);

                f_84_17585_17708(constant != null && (DynAbs.Tracing.TraceSender.Expression_True(84, 17604, 17707) && f_84_17641_17707(constant)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 17723, 17763);

                f_84_17723_17762(targetLabel != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 17779, 17803);

                f_84_17779_17802(
                            _builder, _key);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 17819, 18184) || true) && (f_84_17823_17846(constant))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 17819, 18184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 17950, 18001);

                    f_84_17950_18000(                // ldloc key
                                                     // brfalse targetLabel
                                    _builder, ILOpCode.Brfalse, targetLabel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(84, 17819, 18184);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 17819, 18184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 18067, 18104);

                    f_84_18067_18103(_builder, constant);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 18122, 18169);

                    f_84_18122_18168(_builder, ILOpCode.Beq, targetLabel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(84, 17819, 18184);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(84, 17482, 18195);

                bool
                f_84_17641_17707(Microsoft.CodeAnalysis.ConstantValue
                constant)
                {
                    var return_v = SwitchConstantValueHelper.IsValidSwitchCaseLabelConstant(constant);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 17641, 17707);
                    return return_v;
                }


                int
                f_84_17585_17708(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 17585, 17708);
                    return 0;
                }


                int
                f_84_17723_17762(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 17723, 17762);
                    return 0;
                }


                int
                f_84_17779_17802(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalOrParameter
                localOrParameter)
                {
                    this_param.EmitLoad(localOrParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 17779, 17802);
                    return 0;
                }


                bool
                f_84_17823_17846(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsDefaultValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(84, 17823, 17846);
                    return return_v;
                }


                int
                f_84_17950_18000(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, object
                label)
                {
                    this_param.EmitBranch(code, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 17950, 18000);
                    return 0;
                }


                int
                f_84_18067_18103(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.ConstantValue
                value)
                {
                    this_param.EmitConstantValue(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 18067, 18103);
                    return 0;
                }


                int
                f_84_18122_18168(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, object
                label)
                {
                    this_param.EmitBranch(code, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 18122, 18168);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(84, 17482, 18195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(84, 17482, 18195);
            }
        }

        private void EmitRangeCheckedBranch(ConstantValue startConstant, ConstantValue endConstant, object targetLabel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(84, 18207, 19800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 18343, 18367);

                f_84_18343_18366(_builder, _key);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 18501, 18677) || true) && (f_84_18505_18534_M(!startConstant.IsDefaultValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 18501, 18677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 18568, 18610);

                    f_84_18568_18609(_builder, startConstant);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 18628, 18662);

                    f_84_18628_18661(_builder, ILOpCode.Sub);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(84, 18501, 18677);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 18693, 19706) || true) && (f_84_18697_18727(_keyTypeCode))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 18693, 19706);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 18761, 18838);

                    f_84_18761_18837(_builder, f_84_18787_18809(endConstant) - f_84_18812_18836(startConstant));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(84, 18693, 19706);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 18693, 19706);

                    int Int32Value(ConstantValue value)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(84, 18904, 19593);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 19255, 19574);

                            switch (f_84_19263_19282(value))
                            {

                                case ConstantValueTypeDiscriminator.Byte:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 19255, 19574);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 19374, 19397);

                                    return f_84_19381_19396(value);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(84, 19255, 19574);

                                case ConstantValueTypeDiscriminator.UInt16:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 19255, 19574);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 19467, 19492);

                                    return f_84_19474_19491(value);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(84, 19255, 19574);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 19255, 19574);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 19527, 19551);

                                    return f_84_19534_19550(value);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(84, 19255, 19574);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitMethod(84, 18904, 19593);

                            Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                            f_84_19263_19282(Microsoft.CodeAnalysis.ConstantValue
                            this_param)
                            {
                                var return_v = this_param.Discriminator;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(84, 19263, 19282);
                                return return_v;
                            }


                            byte
                            f_84_19381_19396(Microsoft.CodeAnalysis.ConstantValue
                            this_param)
                            {
                                var return_v = this_param.ByteValue;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(84, 19381, 19396);
                                return return_v;
                            }


                            ushort
                            f_84_19474_19491(Microsoft.CodeAnalysis.ConstantValue
                            this_param)
                            {
                                var return_v = this_param.UInt16Value;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(84, 19474, 19491);
                                return return_v;
                            }


                            int
                            f_84_19534_19550(Microsoft.CodeAnalysis.ConstantValue
                            this_param)
                            {
                                var return_v = this_param.Int32Value;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(84, 19534, 19550);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(84, 18904, 19593);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(84, 18904, 19593);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 19613, 19691);

                    f_84_19613_19690(
                                    _builder, Int32Value(endConstant) - Int32Value(startConstant));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(84, 18693, 19706);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 19722, 19789);

                f_84_19722_19788(
                            _builder, ILOpCode.Ble_un, targetLabel, ILOpCode.Bgt_un);
                DynAbs.Tracing.TraceSender.TraceExitMethod(84, 18207, 19800);

                int
                f_84_18343_18366(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalOrParameter
                localOrParameter)
                {
                    this_param.EmitLoad(localOrParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 18343, 18366);
                    return 0;
                }


                bool
                f_84_18505_18534_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(84, 18505, 18534);
                    return return_v;
                }


                int
                f_84_18568_18609(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.ConstantValue
                value)
                {
                    this_param.EmitConstantValue(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 18568, 18609);
                    return 0;
                }


                int
                f_84_18628_18661(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 18628, 18661);
                    return 0;
                }


                bool
                f_84_18697_18727(Microsoft.Cci.PrimitiveTypeCode
                kind)
                {
                    var return_v = kind.Is64BitIntegral();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 18697, 18727);
                    return return_v;
                }


                long
                f_84_18787_18809(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(84, 18787, 18809);
                    return return_v;
                }


                long
                f_84_18812_18836(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(84, 18812, 18836);
                    return return_v;
                }


                int
                f_84_18761_18837(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, long
                value)
                {
                    this_param.EmitLongConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 18761, 18837);
                    return 0;
                }


                int
                f_84_19613_19690(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                value)
                {
                    this_param.EmitIntConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 19613, 19690);
                    return 0;
                }


                int
                f_84_19722_19788(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, object
                label, System.Reflection.Metadata.ILOpCode
                revOpCode)
                {
                    this_param.EmitBranch(code, label, revOpCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 19722, 19788);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(84, 18207, 19800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(84, 18207, 19800);
            }
        }

        private static ILOpCode GetReverseBranchCode(ILOpCode branchCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(84, 19812, 20478);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 19902, 20467);

                switch (branchCode)
                {

                    case ILOpCode.Beq:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 19902, 20467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 19994, 20017);

                        return ILOpCode.Bne_un;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(84, 19902, 20467);

                    case ILOpCode.Blt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 19902, 20467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 20077, 20097);

                        return ILOpCode.Bge;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(84, 19902, 20467);

                    case ILOpCode.Blt_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 19902, 20467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 20160, 20183);

                        return ILOpCode.Bge_un;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(84, 19902, 20467);

                    case ILOpCode.Bgt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 19902, 20467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 20243, 20263);

                        return ILOpCode.Ble;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(84, 19902, 20467);

                    case ILOpCode.Bgt_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 19902, 20467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 20326, 20349);

                        return ILOpCode.Ble_un;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(84, 19902, 20467);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 19902, 20467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 20399, 20452);

                        throw f_84_20405_20451(branchCode);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(84, 19902, 20467);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(84, 19812, 20478);

                System.Exception
                f_84_20405_20451(System.Reflection.Metadata.ILOpCode
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 20405, 20451);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(84, 19812, 20478);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(84, 19812, 20478);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EmitNormalizedSwitchKey(ConstantValue startConstant, ConstantValue endConstant, object bucketFallThroughLabel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(84, 20490, 21275);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 20638, 20662);

                f_84_20638_20661(_builder, _key);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 20796, 20972) || true) && (f_84_20800_20829_M(!startConstant.IsDefaultValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 20796, 20972);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 20863, 20905);

                    f_84_20863_20904(_builder, startConstant);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 20923, 20957);

                    f_84_20923_20956(_builder, ILOpCode.Sub);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(84, 20796, 20972);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 21043, 21118);

                EmitRangeCheckIfNeeded(startConstant, endConstant, bucketFallThroughLabel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 21172, 21264);

                f_84_21172_21263(
                            // truncate key to 32bit
                            _builder, _keyTypeCode, Microsoft.Cci.PrimitiveTypeCode.UInt32, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(84, 20490, 21275);

                int
                f_84_20638_20661(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalOrParameter
                localOrParameter)
                {
                    this_param.EmitLoad(localOrParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 20638, 20661);
                    return 0;
                }


                bool
                f_84_20800_20829_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(84, 20800, 20829);
                    return return_v;
                }


                int
                f_84_20863_20904(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.ConstantValue
                value)
                {
                    this_param.EmitConstantValue(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 20863, 20904);
                    return 0;
                }


                int
                f_84_20923_20956(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 20923, 20956);
                    return 0;
                }


                int
                f_84_21172_21263(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.PrimitiveTypeCode
                fromPredefTypeKind, Microsoft.Cci.PrimitiveTypeCode
                toPredefTypeKind, bool
                @checked)
                {
                    this_param.EmitNumericConversion(fromPredefTypeKind, toPredefTypeKind, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 21172, 21263);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(84, 20490, 21275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(84, 20490, 21275);
            }
        }

        private void EmitRangeCheckIfNeeded(ConstantValue startConstant, ConstantValue endConstant, object bucketFallThroughLabel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(84, 21287, 22877);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 21695, 22866) || true) && (f_84_21699_21729(_keyTypeCode))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(84, 21695, 22866);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 22089, 22121);

                    var
                    inRangeLabel = f_84_22108_22120()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 22141, 22175);

                    f_84_22141_22174(
                                    _builder, ILOpCode.Dup);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 22193, 22270);

                    f_84_22193_22269(_builder, f_84_22219_22241(endConstant) - f_84_22244_22268(startConstant));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 22288, 22356);

                    f_84_22288_22355(_builder, ILOpCode.Ble_un, inRangeLabel, ILOpCode.Bgt_un);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 22374, 22408);

                    f_84_22374_22407(_builder, ILOpCode.Pop);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 22426, 22483);

                    f_84_22426_22482(_builder, ILOpCode.Br, bucketFallThroughLabel);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 22775, 22800);

                    f_84_22775_22799(                // If we get to inRangeLabel, we should have key on stack, adjust for that.
                                                     // builder cannot infer this since it has not seen all branches, 
                                                     // but it will verify that our Adjustment is valid when more branches are known.
                                    _builder, +1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 22818, 22851);

                    f_84_22818_22850(_builder, inRangeLabel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(84, 21695, 22866);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(84, 21287, 22877);

                bool
                f_84_21699_21729(Microsoft.Cci.PrimitiveTypeCode
                kind)
                {
                    var return_v = kind.Is64BitIntegral();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 21699, 21729);
                    return return_v;
                }


                object
                f_84_22108_22120()
                {
                    var return_v = new object();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 22108, 22120);
                    return return_v;
                }


                int
                f_84_22141_22174(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 22141, 22174);
                    return 0;
                }


                long
                f_84_22219_22241(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(84, 22219, 22241);
                    return return_v;
                }


                long
                f_84_22244_22268(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(84, 22244, 22268);
                    return return_v;
                }


                int
                f_84_22193_22269(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, long
                value)
                {
                    this_param.EmitLongConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 22193, 22269);
                    return 0;
                }


                int
                f_84_22288_22355(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, object
                label, System.Reflection.Metadata.ILOpCode
                revOpCode)
                {
                    this_param.EmitBranch(code, label, revOpCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 22288, 22355);
                    return 0;
                }


                int
                f_84_22374_22407(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 22374, 22407);
                    return 0;
                }


                int
                f_84_22426_22482(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, object
                label)
                {
                    this_param.EmitBranch(code, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 22426, 22482);
                    return 0;
                }


                int
                f_84_22775_22799(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                stackAdjustment)
                {
                    this_param.AdjustStack(stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 22775, 22799);
                    return 0;
                }


                int
                f_84_22818_22850(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, object
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 22818, 22850);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(84, 21287, 22877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(84, 21287, 22877);
            }
        }
        static SwitchIntegralJumpTableEmitter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(84, 618, 22904);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(84, 1758, 1783);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(84, 618, 22904);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(84, 618, 22904);
        }

        static int
        f_84_2324_2341(System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(84, 2324, 2341);
            return return_v;
        }


        static int
        f_84_2311_2346(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 2311, 2346);
            return 0;
        }


        static int
        f_84_2361_2412(System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>[]
        array, System.Comparison<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>
        comparison)
        {
            Array.Sort(array, comparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 2361, 2412);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>
        f_84_2447_2480(params System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>[]
        items)
        {
            var return_v = ImmutableArray.Create(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(84, 2447, 2480);
            return return_v;
        }

    }
}
