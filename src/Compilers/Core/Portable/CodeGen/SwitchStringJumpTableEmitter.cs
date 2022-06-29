// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.Emit;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CodeGen
{
    // HashBucket used when emitting hash table based string switch.
    // Each hash bucket contains the list of "<string constant, label>" key-value pairs
    // having identical hash value.
    using HashBucket = List<KeyValuePair<ConstantValue, object>>;

    internal struct SwitchStringJumpTableEmitter
    {

        private readonly ILBuilder _builder;

        private readonly LocalOrParameter _key;

        private readonly KeyValuePair<ConstantValue, object>[] _caseLabels;

        private readonly object _fallThroughLabel;

        /// <summary>
        /// Delegate to emit string compare call and conditional branch based on the compare result.
        /// </summary>
        /// <param name="key">Key to compare</param>
        /// <param name="stringConstant">Case constant to compare the key against</param>
        /// <param name="targetLabel">Target label to branch to if key = stringConstant</param>
        public delegate void EmitStringCompareAndBranch(LocalOrParameter key, ConstantValue stringConstant, object targetLabel);

        /// <summary>
        /// Delegate to compute string hash code.
        /// This piece is language-specific because VB treats "" and null as equal while C# does not.
        /// </summary>
        public delegate uint GetStringHashCode(string? key);

        private readonly EmitStringCompareAndBranch _emitStringCondBranchDelegate;

        private readonly GetStringHashCode _computeStringHashcodeDelegate;

        private readonly LocalDefinition? _keyHash;

        internal SwitchStringJumpTableEmitter(
                    ILBuilder builder,
                    LocalOrParameter key,
                    KeyValuePair<ConstantValue, object>[] caseLabels,
                    object fallThroughLabel,
                    LocalDefinition? keyHash,
                    EmitStringCompareAndBranch emitStringCondBranchDelegate,
                    GetStringHashCode computeStringHashcodeDelegate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(86, 2579, 3434);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 2981, 3017);

                f_86_2981_3016(f_86_2994_3011(caseLabels) > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 3031, 3088);

                f_86_3031_3087(emitStringCondBranchDelegate != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 3104, 3123);

                _builder = builder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 3137, 3148);

                _key = key;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 3162, 3187);

                _caseLabels = caseLabels;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 3201, 3238);

                _fallThroughLabel = fallThroughLabel;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 3252, 3271);

                _keyHash = keyHash;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 3285, 3346);

                _emitStringCondBranchDelegate = emitStringCondBranchDelegate;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 3360, 3423);

                _computeStringHashcodeDelegate = computeStringHashcodeDelegate;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(86, 2579, 3434);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(86, 2579, 3434);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(86, 2579, 3434);
            }
        }

        internal void EmitJumpTable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(86, 3446, 3804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 3500, 3584);

                f_86_3500_3583(_keyHash == null || (DynAbs.Tracing.TraceSender.Expression_False(86, 3513, 3582) || ShouldGenerateHashTableSwitch(f_86_3563_3581(_caseLabels))));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 3600, 3793) || true) && (_keyHash != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(86, 3600, 3793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 3654, 3676);

                    EmitHashTableSwitch();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(86, 3600, 3793);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(86, 3600, 3793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 3742, 3778);

                    EmitNonHashTableSwitch(_caseLabels);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(86, 3600, 3793);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(86, 3446, 3804);

                int
                f_86_3563_3581(System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(86, 3563, 3581);
                    return return_v;
                }


                int
                f_86_3500_3583(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 3500, 3583);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(86, 3446, 3804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(86, 3446, 3804);
            }
        }

        private void EmitHashTableSwitch()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(86, 3816, 5097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 3970, 4001);

                f_86_3970_4000(_keyHash != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 4165, 4399);

                Dictionary<uint, HashBucket>
                stringHashMap = ComputeStringHashMap(_caseLabels, _computeStringHashcodeDelegate)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 4562, 4648);

                Dictionary<uint, object>
                hashBucketLabelsMap = EmitHashBucketJumpTable(stringHashMap)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 4698, 5086);
                    foreach (var kvPair in f_86_4721_4734_I(stringHashMap))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(86, 4698, 5086);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 4894, 4946);

                        f_86_4894_4945(                // hashBucketLabel:
                                                       //  Emit direct string comparisons for each case label in hash bucket

                                        _builder, f_86_4913_4944(hashBucketLabelsMap, kvPair.Key));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 4966, 5003);

                        HashBucket
                        hashBucket = kvPair.Value
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 5021, 5071);

                        this.EmitNonHashTableSwitch(f_86_5049_5069(hashBucket));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(86, 4698, 5086);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(86, 1, 389);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(86, 1, 389);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(86, 3816, 5097);

                int
                f_86_3970_4000(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 3970, 4000);
                    return 0;
                }


                object
                f_86_4913_4944(System.Collections.Generic.Dictionary<uint, object>
                this_param, uint
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(86, 4913, 4944);
                    return return_v;
                }


                int
                f_86_4894_4945(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, object
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 4894, 4945);
                    return 0;
                }


                System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>[]
                f_86_5049_5069(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 5049, 5069);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<uint, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>>
                f_86_4721_4734_I(System.Collections.Generic.Dictionary<uint, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 4721, 4734);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(86, 3816, 5097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(86, 3816, 5097);
            }
        }

        private Dictionary<uint, object> EmitHashBucketJumpTable(Dictionary<uint, HashBucket> stringHashMap)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(86, 5215, 6523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 5340, 5372);

                int
                count = f_86_5352_5371(stringHashMap)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 5386, 5448);

                var
                hashBucketLabelsMap = f_86_5412_5447(count)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 5462, 5531);

                var
                jumpTableLabels = new KeyValuePair<ConstantValue, object>[count]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 5545, 5555);

                int
                i = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 5571, 5985);
                    foreach (uint hashValue in f_86_5598_5616_I(f_86_5598_5616(stringHashMap)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(86, 5571, 5985);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 5650, 5711);

                        ConstantValue
                        hashConstant = f_86_5679_5710(hashValue)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 5729, 5767);

                        object
                        hashBucketLabel = f_86_5754_5766()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 5787, 5879);

                        jumpTableLabels[i] = f_86_5808_5878(hashConstant, hashBucketLabel);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 5897, 5946);

                        hashBucketLabelsMap[hashValue] = hashBucketLabel;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 5966, 5970);

                        i++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(86, 5571, 5985);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(86, 1, 415);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(86, 1, 415);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 6113, 6410);

                var
                hashBucketJumpTableEmitter = f_86_6146_6409(builder: _builder, caseLabels: jumpTableLabels, fallThroughLabel: _fallThroughLabel, keyTypeCode: Cci.PrimitiveTypeCode.UInt32, key: _keyHash)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 6426, 6469);

                hashBucketJumpTableEmitter.EmitJumpTable();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 6485, 6512);

                return hashBucketLabelsMap;
                DynAbs.Tracing.TraceSender.TraceExitMethod(86, 5215, 6523);

                int
                f_86_5352_5371(System.Collections.Generic.Dictionary<uint, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(86, 5352, 5371);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<uint, object>
                f_86_5412_5447(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.Dictionary<uint, object>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 5412, 5447);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<uint, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>>.KeyCollection
                f_86_5598_5616(System.Collections.Generic.Dictionary<uint, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(86, 5598, 5616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_86_5679_5710(uint
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 5679, 5710);
                    return return_v;
                }


                object
                f_86_5754_5766()
                {
                    var return_v = new object();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 5754, 5766);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>
                f_86_5808_5878(Microsoft.CodeAnalysis.ConstantValue
                key, object
                value)
                {
                    var return_v = new System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 5808, 5878);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<uint, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>>.KeyCollection
                f_86_5598_5616_I(System.Collections.Generic.Dictionary<uint, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>>.KeyCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 5598, 5616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter
                f_86_6146_6409(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                builder, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>[]
                caseLabels, object
                fallThroughLabel, Microsoft.Cci.PrimitiveTypeCode
                keyTypeCode, Microsoft.CodeAnalysis.CodeGen.LocalDefinition?
                key)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter(builder: builder, caseLabels: caseLabels, fallThroughLabel: fallThroughLabel, keyTypeCode: keyTypeCode, key: (Microsoft.CodeAnalysis.CodeGen.LocalOrParameter)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 6146, 6409);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(86, 5215, 6523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(86, 5215, 6523);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EmitNonHashTableSwitch(KeyValuePair<ConstantValue, object>[] labels)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(86, 6535, 6920);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 6702, 6841);
                    foreach (var kvPair in f_86_6725_6731_I(labels))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(86, 6702, 6841);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 6765, 6826);

                        this.EmitCondBranchForStringSwitch(kvPair.Key, kvPair.Value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(86, 6702, 6841);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(86, 1, 140);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(86, 1, 140);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 6857, 6909);

                f_86_6857_6908(
                            _builder, ILOpCode.Br, _fallThroughLabel);
                DynAbs.Tracing.TraceSender.TraceExitMethod(86, 6535, 6920);

                System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>[]
                f_86_6725_6731_I(System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 6725, 6731);
                    return return_v;
                }


                int
                f_86_6857_6908(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, object
                label)
                {
                    this_param.EmitBranch(code, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 6857, 6908);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(86, 6535, 6920);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(86, 6535, 6920);
            }
        }

        private void EmitCondBranchForStringSwitch(ConstantValue stringConstant, object targetLabel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(86, 6932, 7309);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 7049, 7163);

                f_86_7049_7162(stringConstant != null && (DynAbs.Tracing.TraceSender.Expression_True(86, 7068, 7161) && (f_86_7112_7135(stringConstant) || (DynAbs.Tracing.TraceSender.Expression_False(86, 7112, 7160) || f_86_7139_7160(stringConstant)))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 7177, 7217);

                f_86_7177_7216(targetLabel != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 7233, 7298);

                //f_86_7233_7297(this, _key, stringConstant, targetLabel);
                // LAFHIS
                this._emitStringCondBranchDelegate(_key, stringConstant, targetLabel);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 7233, 7297);

                DynAbs.Tracing.TraceSender.TraceExitMethod(86, 6932, 7309);

                bool
                f_86_7112_7135(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(86, 7112, 7135);
                    return return_v;
                }


                bool
                f_86_7139_7160(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(86, 7139, 7160);
                    return return_v;
                }


                int
                f_86_7049_7162(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 7049, 7162);
                    return 0;
                }


                int
                f_86_7177_7216(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 7177, 7216);
                    return 0;
                }


                int
                f_86_7233_7297(ref Microsoft.CodeAnalysis.CodeGen.SwitchStringJumpTableEmitter
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalOrParameter
                key, Microsoft.CodeAnalysis.ConstantValue
                stringConstant, object
                targetLabel)
                {
                    this_param._emitStringCondBranchDelegate(key, stringConstant, targetLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 7233, 7297);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(86, 6932, 7309);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(86, 6932, 7309);
            }
        }

        private static Dictionary<uint, HashBucket> ComputeStringHashMap(
                    KeyValuePair<ConstantValue, object>[] caseLabels,
                    GetStringHashCode computeStringHashcodeDelegate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(86, 7461, 8505);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 7676, 7715);

                f_86_7676_7714(caseLabels != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 7729, 7801);

                var
                stringHashMap = f_86_7749_7800(f_86_7782_7799(caseLabels))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 7817, 8457);
                    foreach (var kvPair in f_86_7840_7850_I(caseLabels))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(86, 7817, 8457);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 7884, 7926);

                        ConstantValue
                        stringConstant = kvPair.Key
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 7944, 8007);

                        f_86_7944_8006(f_86_7957_7978(stringConstant) || (DynAbs.Tracing.TraceSender.Expression_False(86, 7957, 8005) || f_86_7982_8005(stringConstant)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 8027, 8100);

                        uint
                        hash = f_86_8039_8099(computeStringHashcodeDelegate, f_86_8078_8098(stringConstant))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 8120, 8139);

                        HashBucket?
                        bucket
                        = default(HashBucket?);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 8157, 8346) || true) && (!f_86_8162_8205(stringHashMap, hash, out bucket))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(86, 8157, 8346);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 8247, 8273);

                            bucket = f_86_8256_8272();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 8295, 8327);

                            f_86_8295_8326(stringHashMap, hash, bucket);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(86, 8157, 8346);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 8366, 8405);

                        f_86_8366_8404(!f_86_8380_8403(bucket, kvPair));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 8423, 8442);

                        f_86_8423_8441(bucket, kvPair);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(86, 7817, 8457);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(86, 1, 641);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(86, 1, 641);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 8473, 8494);

                return stringHashMap;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(86, 7461, 8505);

                int
                f_86_7676_7714(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 7676, 7714);
                    return 0;
                }


                int
                f_86_7782_7799(System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(86, 7782, 7799);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<uint, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>>
                f_86_7749_7800(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.Dictionary<uint, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 7749, 7800);
                    return return_v;
                }


                bool
                f_86_7957_7978(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(86, 7957, 7978);
                    return return_v;
                }


                bool
                f_86_7982_8005(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(86, 7982, 8005);
                    return return_v;
                }


                int
                f_86_7944_8006(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 7944, 8006);
                    return 0;
                }


                object?
                f_86_8078_8098(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(86, 8078, 8098);
                    return return_v;
                }


                uint
                f_86_8039_8099(Microsoft.CodeAnalysis.CodeGen.SwitchStringJumpTableEmitter.GetStringHashCode
                this_param, object?
                key)
                {
                    var return_v = this_param.Invoke((string?)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 8039, 8099);
                    return return_v;
                }


                bool
                f_86_8162_8205(System.Collections.Generic.Dictionary<uint, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>>
                this_param, uint
                key, out System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 8162, 8205);
                    return return_v;
                }


                System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>
                f_86_8256_8272()
                {
                    var return_v = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 8256, 8272);
                    return return_v;
                }


                int
                f_86_8295_8326(System.Collections.Generic.Dictionary<uint, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>>
                this_param, uint
                key, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 8295, 8326);
                    return 0;
                }


                bool
                f_86_8380_8403(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>
                this_param, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 8380, 8403);
                    return return_v;
                }


                int
                f_86_8366_8404(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 8366, 8404);
                    return 0;
                }


                int
                f_86_8423_8441(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>
                this_param, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 8423, 8441);
                    return 0;
                }


                System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>[]
                f_86_7840_7850_I(System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 7840, 7850);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(86, 7461, 8505);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(86, 7461, 8505);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ShouldGenerateHashTableSwitch(CommonPEModuleBuilder module, int labelsCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(86, 8517, 8735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 8639, 8724);

                return f_86_8646_8677(module) && (DynAbs.Tracing.TraceSender.Expression_True(86, 8646, 8723) && ShouldGenerateHashTableSwitch(labelsCount));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(86, 8517, 8735);

                bool
                f_86_8646_8677(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.SupportsPrivateImplClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(86, 8646, 8677);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(86, 8517, 8735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(86, 8517, 8735);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ShouldGenerateHashTableSwitch(int labelsCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(86, 8747, 9161);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(86, 9126, 9150);

                return labelsCount >= 7;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(86, 8747, 9161);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(86, 8747, 9161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(86, 8747, 9161);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static SwitchStringJumpTableEmitter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(86, 682, 9168);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(86, 682, 9168);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(86, 682, 9168);
        }

        static int
        f_86_2994_3011(System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(86, 2994, 3011);
            return return_v;
        }


        static int
        f_86_2981_3016(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 2981, 3016);
            return 0;
        }


        static int
        f_86_3031_3087(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(86, 3031, 3087);
            return 0;
        }

    }
}
