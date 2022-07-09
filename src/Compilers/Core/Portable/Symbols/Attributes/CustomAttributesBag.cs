// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using System;

namespace Microsoft.CodeAnalysis
{
    internal sealed class CustomAttributesBag<T>
            where T : AttributeData
    {
        private ImmutableArray<T> _customAttributes;

        private WellKnownAttributeData _decodedWellKnownAttributeData;

        private EarlyWellKnownAttributeData _earlyDecodedWellKnownAttributeData;

        private int _state;

        public static readonly CustomAttributesBag<T> Empty;

        private CustomAttributesBag(CustomAttributeBagCompletionPart part, ImmutableArray<T> customAttributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(803, 1196, 1413);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 756, 786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 833, 868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 891, 897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 1323, 1360);

                _customAttributes = customAttributes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 1374, 1402);

                f_803_1374_1401(this, part);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(803, 1196, 1413);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(803, 1196, 1413);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(803, 1196, 1413);
            }
        }

        public CustomAttributesBag()
        : this(f_803_1474_1511_C(CustomAttributeBagCompletionPart.None), default(ImmutableArray<T>))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(803, 1425, 1562);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(803, 1425, 1562);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(803, 1425, 1562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(803, 1425, 1562);
            }
        }

        /// <summary>
        /// Returns a non-sealed custom attribute bag with null initialized <see cref="_earlyDecodedWellKnownAttributeData"/>, null initialized <see cref="_decodedWellKnownAttributeData"/> and uninitialized <see cref="_customAttributes"/>.
        /// </summary>
        public static CustomAttributesBag<T> WithEmptyData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(803, 1862, 2146);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 1939, 2135);

                return f_803_1946_2134(CustomAttributeBagCompletionPart.EarlyDecodedWellKnownAttributeData | CustomAttributeBagCompletionPart.DecodedWellKnownAttributeData, default(ImmutableArray<T>));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(803, 1862, 2146);

                Microsoft.CodeAnalysis.CustomAttributesBag<T>
                f_803_1946_2134(Microsoft.CodeAnalysis.CustomAttributesBag<T>.CustomAttributeBagCompletionPart
                part, System.Collections.Immutable.ImmutableArray<T>
                customAttributes)
                {
                    var return_v = new Microsoft.CodeAnalysis.CustomAttributesBag<T>(part, customAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 1946, 2134);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(803, 1862, 2146);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(803, 1862, 2146);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsEmpty
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(803, 2202, 2476);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 2238, 2461);

                    return
                    f_803_2266_2279(this) && (DynAbs.Tracing.TraceSender.Expression_True(803, 2266, 2329) && _customAttributes.IsEmpty) && (DynAbs.Tracing.TraceSender.Expression_True(803, 2266, 2392) && _decodedWellKnownAttributeData == null) && (DynAbs.Tracing.TraceSender.Expression_True(803, 2266, 2460) && _earlyDecodedWellKnownAttributeData == null);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(803, 2202, 2476);

                    bool
                    f_803_2266_2279(Microsoft.CodeAnalysis.CustomAttributesBag<T>
                    this_param)
                    {
                        var return_v = this_param.IsSealed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(803, 2266, 2279);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(803, 2158, 2487);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(803, 2158, 2487);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        /// <summary>
        /// Sets the early decoded well-known attribute data on the bag in a thread safe manner.
        /// Stored early decoded data is immutable and cannot be updated further.
        /// </summary>
        /// <returns>Returns true if early decoded data were stored into the bag on this thread.</returns>
        public bool SetEarlyDecodedWellKnownAttributeData(EarlyWellKnownAttributeData data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(803, 2835, 3248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 2943, 2977);

                f_803_2943_2976(data);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 2991, 3101);

                var
                setOnOurThread = f_803_3012_3092(ref _earlyDecodedWellKnownAttributeData, data, null) == null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 3115, 3201);

                f_803_3115_3200(this, CustomAttributeBagCompletionPart.EarlyDecodedWellKnownAttributeData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 3215, 3237);

                return setOnOurThread;
                DynAbs.Tracing.TraceSender.TraceExitMethod(803, 2835, 3248);

                int
                f_803_2943_2976(Microsoft.CodeAnalysis.EarlyWellKnownAttributeData
                data)
                {
                    WellKnownAttributeData.Seal((Microsoft.CodeAnalysis.WellKnownAttributeData)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 2943, 2976);
                    return 0;
                }


                Microsoft.CodeAnalysis.EarlyWellKnownAttributeData
                f_803_3012_3092(ref Microsoft.CodeAnalysis.EarlyWellKnownAttributeData
                location1, Microsoft.CodeAnalysis.EarlyWellKnownAttributeData
                value, Microsoft.CodeAnalysis.EarlyWellKnownAttributeData
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 3012, 3092);
                    return return_v;
                }


                int
                f_803_3115_3200(Microsoft.CodeAnalysis.CustomAttributesBag<T>
                this_param, Microsoft.CodeAnalysis.CustomAttributesBag<T>.CustomAttributeBagCompletionPart
                part)
                {
                    this_param.NotePartComplete(part);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 3115, 3200);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(803, 2835, 3248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(803, 2835, 3248);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Sets the decoded well-known attribute data (except the early data) on the bag in a thread safe manner. 
        /// Stored decoded data is immutable and cannot be updated further.
        /// </summary>
        /// <returns>Returns true if decoded data were stored into the bag on this thread.</returns>
        public bool SetDecodedWellKnownAttributeData(WellKnownAttributeData data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(803, 3603, 3996);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 3701, 3735);

                f_803_3701_3734(data);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 3749, 3854);

                var
                setOnOurThread = f_803_3770_3845(ref _decodedWellKnownAttributeData, data, null) == null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 3868, 3949);

                f_803_3868_3948(this, CustomAttributeBagCompletionPart.DecodedWellKnownAttributeData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 3963, 3985);

                return setOnOurThread;
                DynAbs.Tracing.TraceSender.TraceExitMethod(803, 3603, 3996);

                int
                f_803_3701_3734(Microsoft.CodeAnalysis.WellKnownAttributeData
                data)
                {
                    WellKnownAttributeData.Seal(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 3701, 3734);
                    return 0;
                }


                Microsoft.CodeAnalysis.WellKnownAttributeData
                f_803_3770_3845(ref Microsoft.CodeAnalysis.WellKnownAttributeData
                location1, Microsoft.CodeAnalysis.WellKnownAttributeData
                value, Microsoft.CodeAnalysis.WellKnownAttributeData
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 3770, 3845);
                    return return_v;
                }


                int
                f_803_3868_3948(Microsoft.CodeAnalysis.CustomAttributesBag<T>
                this_param, Microsoft.CodeAnalysis.CustomAttributesBag<T>.CustomAttributeBagCompletionPart
                part)
                {
                    this_param.NotePartComplete(part);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 3868, 3948);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(803, 3603, 3996);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(803, 3603, 3996);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Sets the bound attributes on the bag in a thread safe manner.
        /// If store succeeds, it seals the bag and makes the bag immutable.
        /// </summary>
        /// <returns>Returns true if bound attributes were stored into the bag on this thread.</returns>
        public bool SetAttributes(ImmutableArray<T> newCustomAttributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(803, 4314, 4756);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 4403, 4448);

                f_803_4403_4447(f_803_4416_4446_M(!newCustomAttributes.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 4462, 4633);

                var
                setOnOurThread = f_803_4483_4602(ref _customAttributes, newCustomAttributes, default(ImmutableArray<T>)) == default(ImmutableArray<T>)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 4647, 4709);

                f_803_4647_4708(this, CustomAttributeBagCompletionPart.Attributes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 4723, 4745);

                return setOnOurThread;
                DynAbs.Tracing.TraceSender.TraceExitMethod(803, 4314, 4756);

                bool
                f_803_4416_4446_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(803, 4416, 4446);
                    return return_v;
                }


                int
                f_803_4403_4447(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 4403, 4447);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_803_4483_4602(ref System.Collections.Immutable.ImmutableArray<T>
                location, System.Collections.Immutable.ImmutableArray<T>
                value, System.Collections.Immutable.ImmutableArray<T>
                comparand)
                {
                    var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 4483, 4602);
                    return return_v;
                }


                int
                f_803_4647_4708(Microsoft.CodeAnalysis.CustomAttributesBag<T>
                this_param, Microsoft.CodeAnalysis.CustomAttributesBag<T>.CustomAttributeBagCompletionPart
                part)
                {
                    this_param.NotePartComplete(part);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 4647, 4708);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(803, 4314, 4756);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(803, 4314, 4756);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<T> Attributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(803, 5017, 5246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 5053, 5127);

                    f_803_5053_5126(f_803_5066_5125(this, CustomAttributeBagCompletionPart.Attributes));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 5145, 5188);

                    f_803_5145_5187(f_803_5158_5186_M(!_customAttributes.IsDefault));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 5206, 5231);

                    return _customAttributes;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(803, 5017, 5246);

                    bool
                    f_803_5066_5125(Microsoft.CodeAnalysis.CustomAttributesBag<T>
                    this_param, Microsoft.CodeAnalysis.CustomAttributesBag<T>.CustomAttributeBagCompletionPart
                    part)
                    {
                        var return_v = this_param.IsPartComplete(part);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 5066, 5125);
                        return return_v;
                    }


                    int
                    f_803_5053_5126(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 5053, 5126);
                        return 0;
                    }


                    bool
                    f_803_5158_5186_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(803, 5158, 5186);
                        return return_v;
                    }


                    int
                    f_803_5145_5187(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 5145, 5187);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(803, 4957, 5257);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(803, 4957, 5257);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public WellKnownAttributeData DecodedWellKnownAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(803, 5642, 5842);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 5678, 5771);

                    f_803_5678_5770(f_803_5691_5769(this, CustomAttributeBagCompletionPart.DecodedWellKnownAttributeData));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 5789, 5827);

                    return _decodedWellKnownAttributeData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(803, 5642, 5842);

                    bool
                    f_803_5691_5769(Microsoft.CodeAnalysis.CustomAttributesBag<T>
                    this_param, Microsoft.CodeAnalysis.CustomAttributesBag<T>.CustomAttributeBagCompletionPart
                    part)
                    {
                        var return_v = this_param.IsPartComplete(part);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 5691, 5769);
                        return return_v;
                    }


                    int
                    f_803_5678_5770(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 5678, 5770);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(803, 5558, 5853);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(803, 5558, 5853);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public EarlyWellKnownAttributeData EarlyDecodedWellKnownAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(803, 6235, 6445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 6271, 6369);

                    f_803_6271_6368(f_803_6284_6367(this, CustomAttributeBagCompletionPart.EarlyDecodedWellKnownAttributeData));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 6387, 6430);

                    return _earlyDecodedWellKnownAttributeData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(803, 6235, 6445);

                    bool
                    f_803_6284_6367(Microsoft.CodeAnalysis.CustomAttributesBag<T>
                    this_param, Microsoft.CodeAnalysis.CustomAttributesBag<T>.CustomAttributeBagCompletionPart
                    part)
                    {
                        var return_v = this_param.IsPartComplete(part);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 6284, 6367);
                        return return_v;
                    }


                    int
                    f_803_6271_6368(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 6271, 6368);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(803, 6141, 6456);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(803, 6141, 6456);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private CustomAttributeBagCompletionPart State
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(803, 6539, 6638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 6575, 6623);

                    return (CustomAttributeBagCompletionPart)_state;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(803, 6539, 6638);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(803, 6468, 6734);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(803, 6468, 6734);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(803, 6652, 6723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 6688, 6708);

                    _state = (int)value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(803, 6652, 6723);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(803, 6468, 6734);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(803, 6468, 6734);
                }
            }
        }

        private void NotePartComplete(CustomAttributeBagCompletionPart part)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(803, 6746, 6917);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 6839, 6906);

                f_803_6839_6905(ref _state, (f_803_6886_6896(this) | part));
                DynAbs.Tracing.TraceSender.TraceExitMethod(803, 6746, 6917);

                Microsoft.CodeAnalysis.CustomAttributesBag<T>.CustomAttributeBagCompletionPart
                f_803_6886_6896(Microsoft.CodeAnalysis.CustomAttributesBag<T>
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(803, 6886, 6896);
                    return return_v;
                }


                bool
                f_803_6839_6905(ref int
                flags, Microsoft.CodeAnalysis.CustomAttributesBag<T>.CustomAttributeBagCompletionPart
                toSet)
                {
                    var return_v = ThreadSafeFlagOperations.Set(ref flags, (int)toSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 6839, 6905);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(803, 6746, 6917);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(803, 6746, 6917);
            }
        }

        internal bool IsPartComplete(CustomAttributeBagCompletionPart part)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(803, 6929, 7067);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 7021, 7056);

                return (f_803_7029_7039(this) & part) == part;
                DynAbs.Tracing.TraceSender.TraceExitMethod(803, 6929, 7067);

                Microsoft.CodeAnalysis.CustomAttributesBag<T>.CustomAttributeBagCompletionPart
                f_803_7029_7039(Microsoft.CodeAnalysis.CustomAttributesBag<T>
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(803, 7029, 7039);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(803, 6929, 7067);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(803, 6929, 7067);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(803, 7126, 7194);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 7132, 7192);

                    return f_803_7139_7191(this, CustomAttributeBagCompletionPart.All);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(803, 7126, 7194);

                    bool
                    f_803_7139_7191(Microsoft.CodeAnalysis.CustomAttributesBag<T>
                    this_param, Microsoft.CodeAnalysis.CustomAttributesBag<T>.CustomAttributeBagCompletionPart
                    part)
                    {
                        var return_v = this_param.IsPartComplete(part);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 7139, 7191);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(803, 7079, 7205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(803, 7079, 7205);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsEarlyDecodedWellKnownAttributeDataComputed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(803, 7670, 8086);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 7706, 7811);

                    bool
                    earlyComplete = f_803_7727_7810(this, CustomAttributeBagCompletionPart.EarlyDecodedWellKnownAttributeData)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 7921, 8032);

                    f_803_7921_8031(!f_803_7935_8013(this, CustomAttributeBagCompletionPart.DecodedWellKnownAttributeData) || (DynAbs.Tracing.TraceSender.Expression_False(803, 7934, 8030) || earlyComplete));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 8050, 8071);

                    return earlyComplete;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(803, 7670, 8086);

                    bool
                    f_803_7727_7810(Microsoft.CodeAnalysis.CustomAttributesBag<T>
                    this_param, Microsoft.CodeAnalysis.CustomAttributesBag<T>.CustomAttributeBagCompletionPart
                    part)
                    {
                        var return_v = this_param.IsPartComplete(part);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 7727, 7810);
                        return return_v;
                    }


                    bool
                    f_803_7935_8013(Microsoft.CodeAnalysis.CustomAttributesBag<T>
                    this_param, Microsoft.CodeAnalysis.CustomAttributesBag<T>.CustomAttributeBagCompletionPart
                    part)
                    {
                        var return_v = this_param.IsPartComplete(part);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 7935, 8013);
                        return return_v;
                    }


                    int
                    f_803_7921_8031(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 7921, 8031);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(803, 7587, 8097);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(803, 7587, 8097);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsDecodedWellKnownAttributeDataComputed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(803, 8515, 8946);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 8551, 8656);

                    bool
                    attributesComplete = f_803_8577_8655(this, CustomAttributeBagCompletionPart.DecodedWellKnownAttributeData)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 8766, 8887);

                    f_803_8766_8886(!attributesComplete || (DynAbs.Tracing.TraceSender.Expression_False(803, 8779, 8885) || f_803_8802_8885(this, CustomAttributeBagCompletionPart.EarlyDecodedWellKnownAttributeData)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 8905, 8931);

                    return attributesComplete;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(803, 8515, 8946);

                    bool
                    f_803_8577_8655(Microsoft.CodeAnalysis.CustomAttributesBag<T>
                    this_param, Microsoft.CodeAnalysis.CustomAttributesBag<T>.CustomAttributeBagCompletionPart
                    part)
                    {
                        var return_v = this_param.IsPartComplete(part);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 8577, 8655);
                        return return_v;
                    }


                    bool
                    f_803_8802_8885(Microsoft.CodeAnalysis.CustomAttributesBag<T>
                    this_param, Microsoft.CodeAnalysis.CustomAttributesBag<T>.CustomAttributeBagCompletionPart
                    part)
                    {
                        var return_v = this_param.IsPartComplete(part);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 8802, 8885);
                        return return_v;
                    }


                    int
                    f_803_8766_8886(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 8766, 8886);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(803, 8437, 8957);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(803, 8437, 8957);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        /// <summary>
        /// Enum representing the current state of attribute binding/decoding for a corresponding CustomAttributeBag.
        /// </summary>
        [Flags]
        internal enum CustomAttributeBagCompletionPart : byte
        {
            /// <summary>
            /// Bag has been created, but no decoded data or attributes have been stored.
            /// CustomAttributeBag is in this state during early decoding phase.
            /// </summary>
            None = 0,

            /// <summary>
            /// Early decoded attribute data has been computed and stored on the bag, but bound attributes or remaining decoded attribute data is not stored.
            /// Only <see cref="EarlyDecodedWellKnownAttributeData"/> can be accessed from this bag.
            /// </summary>
            EarlyDecodedWellKnownAttributeData = 1 << 0,

            /// <summary>
            /// All decoded attribute data has been computed and stored on the bag, but bound attributes are not yet stored.
            /// Both <see cref="EarlyDecodedWellKnownAttributeData"/> and <see cref="DecodedWellKnownAttributeData"/> can be accessed from this bag.
            /// </summary>
            DecodedWellKnownAttributeData = 1 << 1,

            /// <summary>
            /// Bound attributes have been computed and stored on this bag.
            /// </summary>
            Attributes = 1 << 2,

            /// <summary>
            /// CustomAttributeBag is completely initialized and immutable.
            /// </summary>
            All = EarlyDecodedWellKnownAttributeData | DecodedWellKnownAttributeData | Attributes,
        }

        static CustomAttributesBag()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(803, 577, 10649);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(803, 1086, 1183);
            Empty = f_803_1094_1183(CustomAttributeBagCompletionPart.All, ImmutableArray<T>.Empty); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(803, 577, 10649);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(803, 577, 10649);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(803, 577, 10649);

        static Microsoft.CodeAnalysis.CustomAttributesBag<T>
        f_803_1094_1183(Microsoft.CodeAnalysis.CustomAttributesBag<T>.CustomAttributeBagCompletionPart
        part, System.Collections.Immutable.ImmutableArray<T>
        customAttributes)
        {
            var return_v = new Microsoft.CodeAnalysis.CustomAttributesBag<T>(part, customAttributes);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 1094, 1183);
            return return_v;
        }


        static int
        f_803_1374_1401<T>(Microsoft.CodeAnalysis.CustomAttributesBag<T>
        this_param, Microsoft.CodeAnalysis.CustomAttributesBag<T>.CustomAttributeBagCompletionPart
        part) where T : AttributeData

        {
            this_param.NotePartComplete(part);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(803, 1374, 1401);
            return 0;
        }


        static Microsoft.CodeAnalysis.CustomAttributesBag<T>.CustomAttributeBagCompletionPart
        f_803_1474_1511_C(Microsoft.CodeAnalysis.CustomAttributesBag<T>.CustomAttributeBagCompletionPart
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(803, 1425, 1562);
            return return_v;
        }

    }
}
