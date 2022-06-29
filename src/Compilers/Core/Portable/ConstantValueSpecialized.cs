// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal partial class ConstantValue
    {
        private static readonly double _s_IEEE_canonical_NaN;
        private sealed class ConstantValueBad : ConstantValue
        {
            private ConstantValueBad()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(9, 1477, 1507);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(9, 1477, 1507);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 1477, 1507);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 1477, 1507);
                }
            }

            public static readonly ConstantValueBad Instance;

            public override ConstantValueTypeDiscriminator Discriminator
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 1706, 1811);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 1750, 1792);

                        return ConstantValueTypeDiscriminator.Bad;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 1706, 1811);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 1613, 1826);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 1613, 1826);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override SpecialType SpecialType
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 1916, 1948);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 1922, 1946);

                        return SpecialType.None;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 1916, 1948);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 1842, 1963);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 1842, 1963);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool Equals(ConstantValue? other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 2038, 2171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 2120, 2156);

                    return f_9_2127_2155(this, other);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 2038, 2171);

                    bool
                    f_9_2127_2155(Microsoft.CodeAnalysis.ConstantValue.ConstantValueBad
                    objA, Microsoft.CodeAnalysis.ConstantValue?
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object?)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 2127, 2155);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 2038, 2171);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 2038, 2171);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 2187, 2340);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 2253, 2325);

                    return f_9_2260_2324(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 2187, 2340);

                    int
                    f_9_2260_2324(Microsoft.CodeAnalysis.ConstantValue.ConstantValueBad
                    o)
                    {
                        var return_v = System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 2260, 2324);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 2187, 2340);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 2187, 2340);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override string GetValueToDisplay()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 2356, 2461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 2433, 2446);

                    return "bad";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 2356, 2461);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 2356, 2461);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 2356, 2461);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ConstantValueBad()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(9, 1399, 2472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 1563, 1596);
                Instance = f_9_1574_1596(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(9, 1399, 2472);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 1399, 2472);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(9, 1399, 2472);

            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueBad
            f_9_1574_1596()
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueBad();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 1574, 1596);
                return return_v;
            }

        }
        private sealed class ConstantValueNull : ConstantValue
        {
            private ConstantValueNull()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(9, 2563, 2594);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(9, 2563, 2594);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 2563, 2594);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 2563, 2594);
                }
            }

            public static readonly ConstantValueNull Instance;

            public static readonly ConstantValueNull Uninitialized;

            public override ConstantValueTypeDiscriminator Discriminator
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 2890, 2996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 2934, 2977);

                        return ConstantValueTypeDiscriminator.Null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 2890, 2996);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 2797, 3011);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 2797, 3011);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override SpecialType SpecialType
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 3101, 3133);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 3107, 3131);

                        return SpecialType.None;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 3101, 3133);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 3027, 3148);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 3027, 3148);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override string? StringValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 3232, 3307);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 3276, 3288);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 3232, 3307);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 3164, 3322);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 3164, 3322);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override Rope? RopeValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 3404, 3479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 3448, 3460);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 3404, 3479);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 3338, 3494);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 3338, 3494);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool Equals(ConstantValue? other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 3569, 3702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 3651, 3687);

                    return f_9_3658_3686(this, other);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 3569, 3702);

                    bool
                    f_9_3658_3686(Microsoft.CodeAnalysis.ConstantValue.ConstantValueNull
                    objA, Microsoft.CodeAnalysis.ConstantValue?
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object?)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 3658, 3686);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 3569, 3702);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 3569, 3702);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 3718, 3871);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 3784, 3856);

                    return f_9_3791_3855(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 3718, 3871);

                    int
                    f_9_3791_3855(Microsoft.CodeAnalysis.ConstantValue.ConstantValueNull
                    o)
                    {
                        var return_v = System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 3791, 3855);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 3718, 3871);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 3718, 3871);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool IsDefaultValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 3955, 4030);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 3999, 4011);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 3955, 4030);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 3887, 4045);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 3887, 4045);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override string GetValueToDisplay()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 4061, 4219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 4138, 4204);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(9, 4145, 4184) || ((((object)this == (object)Uninitialized) && DynAbs.Tracing.TraceSender.Conditional_F2(9, 4187, 4194)) || DynAbs.Tracing.TraceSender.Conditional_F3(9, 4197, 4203))) ? "unset" : "null";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 4061, 4219);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 4061, 4219);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 4061, 4219);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ConstantValueNull()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(9, 2484, 4230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 2651, 2685);
                Instance = f_9_2662_2685(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 2741, 2780);
                Uninitialized = f_9_2757_2780(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(9, 2484, 4230);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 2484, 4230);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(9, 2484, 4230);

            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueNull
            f_9_2662_2685()
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueNull();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 2662, 2685);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueNull
            f_9_2757_2780()
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueNull();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 2757, 2780);
                return return_v;
            }

        }
        private sealed class ConstantValueString : ConstantValue
        {
            private readonly Rope _value;

            private WeakReference<string>? _constantValueReference;

            public ConstantValueString(string value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(9, 4884, 5189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 4345, 4351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 4844, 4867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 5035, 5125);

                    f_9_5035_5124(value != null, "null strings should be represented as Null constant.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 5143, 5174);

                    _value = f_9_5152_5173(value);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(9, 4884, 5189);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 4884, 5189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 4884, 5189);
                }
            }

            public ConstantValueString(Rope value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(9, 5205, 5492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 4345, 4351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 4844, 4867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 5354, 5444);

                    f_9_5354_5443(value != null, "null strings should be represented as Null constant.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 5462, 5477);

                    _value = value;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(9, 5205, 5492);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 5205, 5492);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 5205, 5492);
                }
            }

            public override ConstantValueTypeDiscriminator Discriminator
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 5601, 5709);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 5645, 5690);

                        return ConstantValueTypeDiscriminator.String;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 5601, 5709);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 5508, 5724);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 5508, 5724);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override SpecialType SpecialType
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 5814, 5855);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 5820, 5853);

                        return SpecialType.System_String;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 5814, 5855);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 5740, 5870);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 5740, 5870);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override string StringValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 5953, 6827);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 5997, 6026);

                        string?
                        constantValue = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 6048, 6705) || true) && (f_9_6052_6108_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_constantValueReference, 9, 6052, 6108)?.TryGetTarget(out constantValue)) != true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(9, 6048, 6705);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 6555, 6589);

                            constantValue = f_9_6571_6588(_value);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 6615, 6682);

                            _constantValueReference = f_9_6641_6681(constantValue);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(9, 6048, 6705);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 6729, 6765);

                        f_9_6729_6764(constantValue != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 6787, 6808);

                        return constantValue;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 5953, 6827);

                        bool?
                        f_9_6052_6108_I(bool?
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 6052, 6108);
                            return return_v;
                        }


                        string
                        f_9_6571_6588(Microsoft.CodeAnalysis.Rope
                        this_param)
                        {
                            var return_v = this_param.ToString();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 6571, 6588);
                            return return_v;
                        }


                        System.WeakReference<string>
                        f_9_6641_6681(string
                        target)
                        {
                            var return_v = new System.WeakReference<string>(target);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 6641, 6681);
                            return return_v;
                        }


                        int
                        f_9_6729_6764(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 6729, 6764);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 5886, 6842);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 5886, 6842);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override Rope RopeValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 6923, 7000);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 6967, 6981);

                        return _value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 6923, 7000);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 6858, 7015);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 6858, 7015);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 7031, 7174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 7097, 7159);

                    return f_9_7104_7158(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetHashCode(), 9, 7117, 7135), f_9_7137_7157(_value));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 7031, 7174);

                    int
                    f_9_7137_7157(Microsoft.CodeAnalysis.Rope
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 7137, 7157);
                        return return_v;
                    }


                    int
                    f_9_7104_7158(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 7104, 7158);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 7031, 7174);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 7031, 7174);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(ConstantValue? other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 7190, 7347);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 7272, 7332);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Equals(other), 9, 7279, 7297) && (DynAbs.Tracing.TraceSender.Expression_True(9, 7279, 7331) && f_9_7301_7331(_value, f_9_7315_7330(other)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 7190, 7347);

                    Microsoft.CodeAnalysis.Rope?
                    f_9_7315_7330(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.RopeValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(9, 7315, 7330);
                        return return_v;
                    }


                    bool
                    f_9_7301_7331(Microsoft.CodeAnalysis.Rope
                    this_param, Microsoft.CodeAnalysis.Rope?
                    obj)
                    {
                        var return_v = this_param.Equals((object?)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 7301, 7331);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 7190, 7347);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 7190, 7347);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override string GetValueToDisplay()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 7363, 7523);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 7440, 7508);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(9, 7447, 7463) || (((_value == null) && DynAbs.Tracing.TraceSender.Conditional_F2(9, 7466, 7472)) || DynAbs.Tracing.TraceSender.Conditional_F3(9, 7475, 7507))) ? "null" : f_9_7475_7507("\"{0}\"", _value);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 7363, 7523);

                    string
                    f_9_7475_7507(string
                    format, Microsoft.CodeAnalysis.Rope
                    arg0)
                    {
                        var return_v = string.Format(format, (object)arg0);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 7475, 7507);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 7363, 7523);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 7363, 7523);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ConstantValueString()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(9, 4242, 7534);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(9, 4242, 7534);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 4242, 7534);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(9, 4242, 7534);

            static int
            f_9_5035_5124(bool
            b, string
            message)
            {
                RoslynDebug.Assert(b, message);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 5035, 5124);
                return 0;
            }


            static Microsoft.CodeAnalysis.Rope
            f_9_5152_5173(string
            s)
            {
                var return_v = Rope.ForString(s);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 5152, 5173);
                return return_v;
            }


            static int
            f_9_5354_5443(bool
            b, string
            message)
            {
                RoslynDebug.Assert(b, message);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 5354, 5443);
                return 0;
            }

        }
        private sealed class ConstantValueDecimal : ConstantValue
        {
            private readonly decimal _value;

            public ConstantValueDecimal(decimal value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(9, 7676, 7781);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 7653, 7659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 7751, 7766);

                    _value = value;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(9, 7676, 7781);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 7676, 7781);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 7676, 7781);
                }
            }

            public override ConstantValueTypeDiscriminator Discriminator
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 7890, 7999);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 7934, 7980);

                        return ConstantValueTypeDiscriminator.Decimal;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 7890, 7999);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 7797, 8014);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 7797, 8014);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override SpecialType SpecialType
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 8104, 8146);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 8110, 8144);

                        return SpecialType.System_Decimal;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 8104, 8146);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 8030, 8161);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 8030, 8161);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override decimal DecimalValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 8246, 8323);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 8290, 8304);

                        return _value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 8246, 8323);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 8177, 8338);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 8177, 8338);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 8354, 8497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 8420, 8482);

                    return f_9_8427_8481(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetHashCode(), 9, 8440, 8458), f_9_8460_8480(_value));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 8354, 8497);

                    int
                    f_9_8460_8480(decimal
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 8460, 8480);
                        return return_v;
                    }


                    int
                    f_9_8427_8481(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 8427, 8481);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 8354, 8497);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 8354, 8497);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(ConstantValue? other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 8513, 8668);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 8595, 8653);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Equals(other), 9, 8602, 8620) && (DynAbs.Tracing.TraceSender.Expression_True(9, 8602, 8652) && _value == f_9_8634_8652(other));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 8513, 8668);

                    decimal
                    f_9_8634_8652(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.DecimalValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(9, 8634, 8652);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 8513, 8668);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 8513, 8668);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ConstantValueDecimal()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(9, 7546, 8679);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(9, 7546, 8679);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 7546, 8679);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(9, 7546, 8679);
        }
        private sealed class ConstantValueDateTime : ConstantValue
        {
            private readonly DateTime _value;

            public ConstantValueDateTime(DateTime value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(9, 8823, 8930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 8900, 8915);

                    _value = value;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(9, 8823, 8930);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 8823, 8930);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 8823, 8930);
                }
            }

            public override ConstantValueTypeDiscriminator Discriminator
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 9039, 9149);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 9083, 9130);

                        return ConstantValueTypeDiscriminator.DateTime;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 9039, 9149);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 8946, 9164);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 8946, 9164);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override SpecialType SpecialType
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 9254, 9297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 9260, 9295);

                        return SpecialType.System_DateTime;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 9254, 9297);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 9180, 9312);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 9180, 9312);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override DateTime DateTimeValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 9399, 9476);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 9443, 9457);

                        return _value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 9399, 9476);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 9328, 9491);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 9328, 9491);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 9507, 9650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 9573, 9635);

                    return f_9_9580_9634(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetHashCode(), 9, 9593, 9611), _value.GetHashCode());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 9507, 9650);

                    int
                    f_9_9580_9634(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 9580, 9634);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 9507, 9650);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 9507, 9650);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(ConstantValue? other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 9666, 9822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 9748, 9807);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Equals(other), 9, 9755, 9773) && (DynAbs.Tracing.TraceSender.Expression_True(9, 9755, 9806) && _value == f_9_9787_9806(other));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 9666, 9822);

                    System.DateTime
                    f_9_9787_9806(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.DateTimeValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(9, 9787, 9806);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 9666, 9822);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 9666, 9822);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ConstantValueDateTime()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(9, 8691, 9833);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(9, 8691, 9833);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 8691, 9833);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(9, 8691, 9833);
        }
        private abstract class ConstantValueDiscriminated : ConstantValue
        {
            private readonly ConstantValueTypeDiscriminator _discriminator;

            public ConstantValueDiscriminated(ConstantValueTypeDiscriminator discriminator)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(9, 10112, 10270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 10081, 10095);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 10224, 10255);

                    _discriminator = discriminator;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(9, 10112, 10270);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 10112, 10270);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 10112, 10270);
                }
            }

            public override ConstantValueTypeDiscriminator Discriminator
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 10379, 10464);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 10423, 10445);

                        return _discriminator;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 10379, 10464);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 10286, 10479);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 10286, 10479);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override SpecialType SpecialType
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 10569, 10615);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 10575, 10613);

                        return f_9_10582_10612(_discriminator);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 10569, 10615);

                        Microsoft.CodeAnalysis.SpecialType
                        f_9_10582_10612(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                        discriminator)
                        {
                            var return_v = GetSpecialType(discriminator);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 10582, 10612);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 10495, 10630);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 10495, 10630);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static ConstantValueDiscriminated()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(9, 9943, 10641);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(9, 9943, 10641);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 9943, 10641);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(9, 9943, 10641);
        }
        private class ConstantValueDefault : ConstantValueDiscriminated
        {
            public static readonly ConstantValueDefault SByte;

            public static readonly ConstantValueDefault Byte;

            public static readonly ConstantValueDefault Int16;

            public static readonly ConstantValueDefault UInt16;

            public static readonly ConstantValueDefault Int32;

            public static readonly ConstantValueDefault UInt32;

            public static readonly ConstantValueDefault Int64;

            public static readonly ConstantValueDefault UInt64;

            public static readonly ConstantValueDefault NInt;

            public static readonly ConstantValueDefault NUInt;

            public static readonly ConstantValueDefault Char;

            public static readonly ConstantValueDefault Single;

            public static readonly ConstantValueDefault Double;

            public static readonly ConstantValueDefault Decimal;

            public static readonly ConstantValueDefault DateTime;

            public static readonly ConstantValueDefault Boolean;

            protected ConstantValueDefault(ConstantValueTypeDiscriminator discriminator)
            : base(f_9_12923_12936_C(discriminator))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(9, 12822, 12967);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(9, 12822, 12967);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 12822, 12967);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 12822, 12967);
                }
            }

            public override byte ByteValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 13046, 13118);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 13090, 13099);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 13046, 13118);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 12983, 13133);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 12983, 13133);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override sbyte SByteValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 13214, 13286);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 13258, 13267);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 13214, 13286);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 13149, 13301);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 13149, 13301);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool BooleanValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 13383, 13459);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 13427, 13440);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 13383, 13459);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 13317, 13474);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 13317, 13474);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override double DoubleValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 13557, 13629);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 13601, 13610);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 13557, 13629);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 13490, 13644);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 13490, 13644);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override float SingleValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 13726, 13798);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 13770, 13779);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 13726, 13798);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 13660, 13813);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 13660, 13813);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override decimal DecimalValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 13898, 13970);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 13942, 13951);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 13898, 13970);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 13829, 13985);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 13829, 13985);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override char CharValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 14064, 14148);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 14108, 14129);

                        return default(char);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 14064, 14148);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 14001, 14163);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 14001, 14163);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override DateTime DateTimeValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 14250, 14338);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 14294, 14319);

                        return default(DateTime);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 14250, 14338);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 14179, 14353);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 14179, 14353);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool Equals(ConstantValue? other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 14428, 14561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 14510, 14546);

                    return f_9_14517_14545(this, other);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 14428, 14561);

                    bool
                    f_9_14517_14545(Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault
                    objA, Microsoft.CodeAnalysis.ConstantValue?
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object?)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 14517, 14545);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 14428, 14561);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 14428, 14561);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 14577, 14730);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 14643, 14715);

                    return f_9_14650_14714(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 14577, 14730);

                    int
                    f_9_14650_14714(Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault
                    o)
                    {
                        var return_v = System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 14650, 14714);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 14577, 14730);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 14577, 14730);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool IsDefaultValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 14814, 14834);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 14820, 14832);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 14814, 14834);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 14746, 14849);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 14746, 14849);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static ConstantValueDefault()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(9, 10752, 14860);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 10884, 10954);
                SByte = f_9_10892_10954(ConstantValueTypeDiscriminator.SByte); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 11013, 11081);
                Byte = f_9_11020_11081(ConstantValueTypeDiscriminator.Byte); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 11140, 11210);
                Int16 = f_9_11148_11210(ConstantValueTypeDiscriminator.Int16); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 11269, 11341);
                UInt16 = f_9_11278_11341(ConstantValueTypeDiscriminator.UInt16); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 11400, 11470);
                Int32 = f_9_11408_11470(ConstantValueTypeDiscriminator.Int32); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 11529, 11601);
                UInt32 = f_9_11538_11601(ConstantValueTypeDiscriminator.UInt32); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 11660, 11730);
                Int64 = f_9_11668_11730(ConstantValueTypeDiscriminator.Int64); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 11789, 11861);
                UInt64 = f_9_11798_11861(ConstantValueTypeDiscriminator.UInt64); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 11920, 11988);
                NInt = f_9_11927_11988(ConstantValueTypeDiscriminator.NInt); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 12047, 12117);
                NUInt = f_9_12055_12117(ConstantValueTypeDiscriminator.NUInt); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 12176, 12244);
                Char = f_9_12183_12244(ConstantValueTypeDiscriminator.Char); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 12303, 12341);
                Single = f_9_12312_12341(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 12400, 12438);
                Double = f_9_12409_12438(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 12497, 12537);
                Decimal = f_9_12507_12537(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 12596, 12672);
                DateTime = f_9_12607_12672(ConstantValueTypeDiscriminator.DateTime); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 12731, 12805);
                Boolean = f_9_12741_12805(ConstantValueTypeDiscriminator.Boolean); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(9, 10752, 14860);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 10752, 14860);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(9, 10752, 14860);

            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault
            f_9_10892_10954(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            discriminator)
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault(discriminator);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 10892, 10954);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault
            f_9_11020_11081(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            discriminator)
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault(discriminator);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 11020, 11081);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault
            f_9_11148_11210(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            discriminator)
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault(discriminator);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 11148, 11210);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault
            f_9_11278_11341(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            discriminator)
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault(discriminator);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 11278, 11341);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault
            f_9_11408_11470(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            discriminator)
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault(discriminator);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 11408, 11470);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault
            f_9_11538_11601(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            discriminator)
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault(discriminator);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 11538, 11601);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault
            f_9_11668_11730(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            discriminator)
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault(discriminator);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 11668, 11730);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault
            f_9_11798_11861(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            discriminator)
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault(discriminator);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 11798, 11861);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault
            f_9_11927_11988(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            discriminator)
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault(discriminator);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 11927, 11988);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault
            f_9_12055_12117(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            discriminator)
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault(discriminator);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 12055, 12117);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault
            f_9_12183_12244(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            discriminator)
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault(discriminator);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 12183, 12244);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueSingleZero
            f_9_12312_12341()
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueSingleZero();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 12312, 12341);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueDoubleZero
            f_9_12409_12438()
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueDoubleZero();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 12409, 12438);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueDecimalZero
            f_9_12507_12537()
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueDecimalZero();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 12507, 12537);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault
            f_9_12607_12672(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            discriminator)
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault(discriminator);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 12607, 12672);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault
            f_9_12741_12805(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            discriminator)
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueDefault(discriminator);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 12741, 12805);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            f_9_12923_12936_C(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(9, 12822, 12967);
                return return_v;
            }

        }
        private sealed class ConstantValueDecimalZero : ConstantValueDefault
        {
            internal ConstantValueDecimalZero()
            : base(f_9_15025_15063_C(ConstantValueTypeDiscriminator.Decimal))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(9, 14965, 15094);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(9, 14965, 15094);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 14965, 15094);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 14965, 15094);
                }
            }

            public override bool Equals(ConstantValue? other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 15110, 15535);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 15192, 15297) || true) && (f_9_15196_15224(other, this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(9, 15192, 15297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 15266, 15278);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(9, 15192, 15297);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 15317, 15423) || true) && (f_9_15321_15349(other, null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(9, 15317, 15423);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 15391, 15404);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(9, 15317, 15423);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 15443, 15520);

                    return f_9_15450_15468(this) == f_9_15472_15491(other) && (DynAbs.Tracing.TraceSender.Expression_True(9, 15450, 15519) && f_9_15495_15513(other) == 0m);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 15110, 15535);

                    bool
                    f_9_15196_15224(Microsoft.CodeAnalysis.ConstantValue?
                    objA, Microsoft.CodeAnalysis.ConstantValue.ConstantValueDecimalZero
                    objB)
                    {
                        var return_v = ReferenceEquals((object?)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 15196, 15224);
                        return return_v;
                    }


                    bool
                    f_9_15321_15349(Microsoft.CodeAnalysis.ConstantValue?
                    objA, object?
                    objB)
                    {
                        var return_v = ReferenceEquals((object?)objA, objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 15321, 15349);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                    f_9_15450_15468(Microsoft.CodeAnalysis.ConstantValue.ConstantValueDecimalZero
                    this_param)
                    {
                        var return_v = this_param.Discriminator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(9, 15450, 15468);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                    f_9_15472_15491(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Discriminator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(9, 15472, 15491);
                        return return_v;
                    }


                    decimal
                    f_9_15495_15513(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.DecimalValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(9, 15495, 15513);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 15110, 15535);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 15110, 15535);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ConstantValueDecimalZero()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(9, 14872, 15546);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(9, 14872, 15546);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 14872, 15546);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(9, 14872, 15546);

            static Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            f_9_15025_15063_C(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(9, 14965, 15094);
                return return_v;
            }

        }
        private sealed class ConstantValueDoubleZero : ConstantValueDefault
        {
            internal ConstantValueDoubleZero()
            : base(f_9_15709_15746_C(ConstantValueTypeDiscriminator.Double))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(9, 15650, 15777);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(9, 15650, 15777);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 15650, 15777);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 15650, 15777);
                }
            }

            public override bool Equals(ConstantValue? other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 15793, 16216);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 15875, 15980) || true) && (f_9_15879_15907(other, this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(9, 15875, 15980);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 15949, 15961);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(9, 15875, 15980);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 16000, 16106) || true) && (f_9_16004_16032(other, null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(9, 16000, 16106);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 16074, 16087);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(9, 16000, 16106);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 16126, 16201);

                    return f_9_16133_16151(this) == f_9_16155_16174(other) && (DynAbs.Tracing.TraceSender.Expression_True(9, 16133, 16200) && f_9_16178_16195(other) == 0);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 15793, 16216);

                    bool
                    f_9_15879_15907(Microsoft.CodeAnalysis.ConstantValue?
                    objA, Microsoft.CodeAnalysis.ConstantValue.ConstantValueDoubleZero
                    objB)
                    {
                        var return_v = ReferenceEquals((object?)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 15879, 15907);
                        return return_v;
                    }


                    bool
                    f_9_16004_16032(Microsoft.CodeAnalysis.ConstantValue?
                    objA, object?
                    objB)
                    {
                        var return_v = ReferenceEquals((object?)objA, objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 16004, 16032);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                    f_9_16133_16151(Microsoft.CodeAnalysis.ConstantValue.ConstantValueDoubleZero
                    this_param)
                    {
                        var return_v = this_param.Discriminator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(9, 16133, 16151);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                    f_9_16155_16174(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Discriminator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(9, 16155, 16174);
                        return return_v;
                    }


                    double
                    f_9_16178_16195(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.DoubleValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(9, 16178, 16195);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 15793, 16216);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 15793, 16216);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ConstantValueDoubleZero()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(9, 15558, 16227);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(9, 15558, 16227);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 15558, 16227);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(9, 15558, 16227);

            static Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            f_9_15709_15746_C(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(9, 15650, 15777);
                return return_v;
            }

        }
        private sealed class ConstantValueSingleZero : ConstantValueDefault
        {
            internal ConstantValueSingleZero()
            : base(f_9_16390_16427_C(ConstantValueTypeDiscriminator.Single))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(9, 16331, 16458);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(9, 16331, 16458);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 16331, 16458);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 16331, 16458);
                }
            }

            public override bool Equals(ConstantValue? other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 16474, 16897);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 16556, 16661) || true) && (f_9_16560_16588(other, this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(9, 16556, 16661);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 16630, 16642);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(9, 16556, 16661);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 16681, 16787) || true) && (f_9_16685_16713(other, null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(9, 16681, 16787);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 16755, 16768);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(9, 16681, 16787);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 16807, 16882);

                    return f_9_16814_16832(this) == f_9_16836_16855(other) && (DynAbs.Tracing.TraceSender.Expression_True(9, 16814, 16881) && f_9_16859_16876(other) == 0);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 16474, 16897);

                    bool
                    f_9_16560_16588(Microsoft.CodeAnalysis.ConstantValue?
                    objA, Microsoft.CodeAnalysis.ConstantValue.ConstantValueSingleZero
                    objB)
                    {
                        var return_v = ReferenceEquals((object?)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 16560, 16588);
                        return return_v;
                    }


                    bool
                    f_9_16685_16713(Microsoft.CodeAnalysis.ConstantValue?
                    objA, object?
                    objB)
                    {
                        var return_v = ReferenceEquals((object?)objA, objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 16685, 16713);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                    f_9_16814_16832(Microsoft.CodeAnalysis.ConstantValue.ConstantValueSingleZero
                    this_param)
                    {
                        var return_v = this_param.Discriminator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(9, 16814, 16832);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                    f_9_16836_16855(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Discriminator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(9, 16836, 16855);
                        return return_v;
                    }


                    float
                    f_9_16859_16876(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.SingleValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(9, 16859, 16876);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 16474, 16897);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 16474, 16897);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ConstantValueSingleZero()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(9, 16239, 16908);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(9, 16239, 16908);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 16239, 16908);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(9, 16239, 16908);

            static Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            f_9_16390_16427_C(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(9, 16331, 16458);
                return return_v;
            }

        }
        private class ConstantValueOne : ConstantValueDiscriminated
        {
            public static readonly ConstantValueOne SByte;

            public static readonly ConstantValueOne Byte;

            public static readonly ConstantValueOne Int16;

            public static readonly ConstantValueOne UInt16;

            public static readonly ConstantValueOne Int32;

            public static readonly ConstantValueOne UInt32;

            public static readonly ConstantValueOne Int64;

            public static readonly ConstantValueOne UInt64;

            public static readonly ConstantValueOne NInt;

            public static readonly ConstantValueOne NUInt;

            public static readonly ConstantValueOne Single;

            public static readonly ConstantValueOne Double;

            public static readonly ConstantValueOne Decimal;

            public static readonly ConstantValueOne Boolean;

            protected ConstantValueOne(ConstantValueTypeDiscriminator discriminator)
            : base(f_9_18780_18793_C(discriminator))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(9, 18683, 18824);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(9, 18683, 18824);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 18683, 18824);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 18683, 18824);
                }
            }

            public override byte ByteValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 18903, 18975);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 18947, 18956);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 18903, 18975);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 18840, 18990);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 18840, 18990);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override sbyte SByteValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 19071, 19143);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 19115, 19124);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 19071, 19143);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 19006, 19158);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 19006, 19158);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool BooleanValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 19240, 19315);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 19284, 19296);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 19240, 19315);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 19174, 19330);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 19174, 19330);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override double DoubleValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 19413, 19485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 19457, 19466);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 19413, 19485);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 19346, 19500);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 19346, 19500);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override float SingleValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 19582, 19654);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 19626, 19635);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 19582, 19654);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 19516, 19669);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 19516, 19669);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override decimal DecimalValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 19754, 19826);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 19798, 19807);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 19754, 19826);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 19685, 19841);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 19685, 19841);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool Equals(ConstantValue? other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 19916, 20049);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 19998, 20034);

                    return f_9_20005_20033(this, other);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 19916, 20049);

                    bool
                    f_9_20005_20033(Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne
                    objA, Microsoft.CodeAnalysis.ConstantValue?
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object?)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 20005, 20033);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 19916, 20049);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 19916, 20049);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 20065, 20218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 20131, 20203);

                    return f_9_20138_20202(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 20065, 20218);

                    int
                    f_9_20138_20202(Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne
                    o)
                    {
                        var return_v = System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 20138, 20202);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 20065, 20218);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 20065, 20218);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ConstantValueOne()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(9, 16920, 20229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 17044, 17110);
                SByte = f_9_17052_17110(ConstantValueTypeDiscriminator.SByte); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 17165, 17229);
                Byte = f_9_17172_17229(ConstantValueTypeDiscriminator.Byte); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 17284, 17350);
                Int16 = f_9_17292_17350(ConstantValueTypeDiscriminator.Int16); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 17405, 17473);
                UInt16 = f_9_17414_17473(ConstantValueTypeDiscriminator.UInt16); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 17528, 17594);
                Int32 = f_9_17536_17594(ConstantValueTypeDiscriminator.Int32); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 17649, 17717);
                UInt32 = f_9_17658_17717(ConstantValueTypeDiscriminator.UInt32); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 17772, 17838);
                Int64 = f_9_17780_17838(ConstantValueTypeDiscriminator.Int64); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 17893, 17961);
                UInt64 = f_9_17902_17961(ConstantValueTypeDiscriminator.UInt64); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 18016, 18080);
                NInt = f_9_18023_18080(ConstantValueTypeDiscriminator.NInt); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 18135, 18201);
                NUInt = f_9_18143_18201(ConstantValueTypeDiscriminator.NUInt); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 18256, 18324);
                Single = f_9_18265_18324(ConstantValueTypeDiscriminator.Single); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 18379, 18447);
                Double = f_9_18388_18447(ConstantValueTypeDiscriminator.Double); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 18502, 18541);
                Decimal = f_9_18512_18541(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 18596, 18666);
                Boolean = f_9_18606_18666(ConstantValueTypeDiscriminator.Boolean); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(9, 16920, 20229);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 16920, 20229);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(9, 16920, 20229);

            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne
            f_9_17052_17110(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            discriminator)
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne(discriminator);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 17052, 17110);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne
            f_9_17172_17229(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            discriminator)
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne(discriminator);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 17172, 17229);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne
            f_9_17292_17350(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            discriminator)
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne(discriminator);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 17292, 17350);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne
            f_9_17414_17473(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            discriminator)
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne(discriminator);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 17414, 17473);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne
            f_9_17536_17594(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            discriminator)
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne(discriminator);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 17536, 17594);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne
            f_9_17658_17717(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            discriminator)
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne(discriminator);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 17658, 17717);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne
            f_9_17780_17838(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            discriminator)
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne(discriminator);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 17780, 17838);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne
            f_9_17902_17961(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            discriminator)
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne(discriminator);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 17902, 17961);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne
            f_9_18023_18080(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            discriminator)
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne(discriminator);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 18023, 18080);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne
            f_9_18143_18201(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            discriminator)
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne(discriminator);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 18143, 18201);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne
            f_9_18265_18324(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            discriminator)
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne(discriminator);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 18265, 18324);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne
            f_9_18388_18447(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            discriminator)
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne(discriminator);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 18388, 18447);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueDecimalOne
            f_9_18512_18541()
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueDecimalOne();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 18512, 18541);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne
            f_9_18606_18666(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            discriminator)
            {
                var return_v = new Microsoft.CodeAnalysis.ConstantValue.ConstantValueOne(discriminator);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 18606, 18666);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            f_9_18780_18793_C(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(9, 18683, 18824);
                return return_v;
            }

        }
        private sealed class ConstantValueDecimalOne : ConstantValueOne
        {
            internal ConstantValueDecimalOne()
            : base(f_9_20388_20426_C(ConstantValueTypeDiscriminator.Decimal))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(9, 20329, 20457);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(9, 20329, 20457);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 20329, 20457);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 20329, 20457);
                }
            }

            public override bool Equals(ConstantValue? other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 20473, 20898);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 20555, 20660) || true) && (f_9_20559_20587(other, this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(9, 20555, 20660);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 20629, 20641);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(9, 20555, 20660);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 20680, 20786) || true) && (f_9_20684_20712(other, null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(9, 20680, 20786);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 20754, 20767);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(9, 20680, 20786);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 20806, 20883);

                    return f_9_20813_20831(this) == f_9_20835_20854(other) && (DynAbs.Tracing.TraceSender.Expression_True(9, 20813, 20882) && f_9_20858_20876(other) == 1m);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 20473, 20898);

                    bool
                    f_9_20559_20587(Microsoft.CodeAnalysis.ConstantValue?
                    objA, Microsoft.CodeAnalysis.ConstantValue.ConstantValueDecimalOne
                    objB)
                    {
                        var return_v = ReferenceEquals((object?)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 20559, 20587);
                        return return_v;
                    }


                    bool
                    f_9_20684_20712(Microsoft.CodeAnalysis.ConstantValue?
                    objA, object?
                    objB)
                    {
                        var return_v = ReferenceEquals((object?)objA, objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 20684, 20712);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                    f_9_20813_20831(Microsoft.CodeAnalysis.ConstantValue.ConstantValueDecimalOne
                    this_param)
                    {
                        var return_v = this_param.Discriminator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(9, 20813, 20831);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                    f_9_20835_20854(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Discriminator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(9, 20835, 20854);
                        return return_v;
                    }


                    decimal
                    f_9_20858_20876(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.DecimalValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(9, 20858, 20876);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 20473, 20898);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 20473, 20898);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ConstantValueDecimalOne()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(9, 20241, 20909);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(9, 20241, 20909);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 20241, 20909);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(9, 20241, 20909);

            static Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            f_9_20388_20426_C(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(9, 20329, 20457);
                return return_v;
            }

        }
        private sealed class ConstantValueI8 : ConstantValueDiscriminated
        {
            private readonly byte _value;

            public ConstantValueI8(sbyte value)
            : base(f_9_21116_21152_C(ConstantValueTypeDiscriminator.SByte))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(9, 21056, 21233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 21033, 21039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 21186, 21218);

                    _value = unchecked((byte)value);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(9, 21056, 21233);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 21056, 21233);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 21056, 21233);
                }
            }

            public ConstantValueI8(byte value)
            : base(f_9_21308_21343_C(ConstantValueTypeDiscriminator.Byte))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(9, 21249, 21407);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 21033, 21039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 21377, 21392);

                    _value = value;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(9, 21249, 21407);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 21249, 21407);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 21249, 21407);
                }
            }

            public override byte ByteValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 21486, 21563);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 21530, 21544);

                        return _value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 21486, 21563);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 21423, 21578);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 21423, 21578);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override sbyte SByteValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 21659, 21756);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 21703, 21737);

                        return unchecked((sbyte)(_value));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 21659, 21756);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 21594, 21771);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 21594, 21771);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 21787, 21930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 21853, 21915);

                    return f_9_21860_21914(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetHashCode(), 9, 21873, 21891), f_9_21893_21913(_value));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 21787, 21930);

                    int
                    f_9_21893_21913(byte
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 21893, 21913);
                        return return_v;
                    }


                    int
                    f_9_21860_21914(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 21860, 21914);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 21787, 21930);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 21787, 21930);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(ConstantValue? other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 21946, 22098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 22028, 22083);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Equals(other), 9, 22035, 22053) && (DynAbs.Tracing.TraceSender.Expression_True(9, 22035, 22082) && _value == f_9_22067_22082(other));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 21946, 22098);

                    byte
                    f_9_22067_22082(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.ByteValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(9, 22067, 22082);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 21946, 22098);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 21946, 22098);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ConstantValueI8()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(9, 20921, 22109);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(9, 20921, 22109);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 20921, 22109);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(9, 20921, 22109);

            static Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            f_9_21116_21152_C(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(9, 21056, 21233);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            f_9_21308_21343_C(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(9, 21249, 21407);
                return return_v;
            }

        }
        private sealed class ConstantValueI16 : ConstantValueDiscriminated
        {
            private readonly short _value;

            public ConstantValueI16(short value)
            : base(f_9_22319_22355_C(ConstantValueTypeDiscriminator.Int16))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(9, 22258, 22419);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 22235, 22241);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 22389, 22404);

                    _value = value;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(9, 22258, 22419);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 22258, 22419);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 22258, 22419);
                }
            }

            public ConstantValueI16(ushort value)
            : base(f_9_22497_22534_C(ConstantValueTypeDiscriminator.UInt16))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(9, 22435, 22616);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 22235, 22241);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 22568, 22601);

                    _value = unchecked((short)value);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(9, 22435, 22616);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 22435, 22616);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 22435, 22616);
                }
            }

            public ConstantValueI16(char value)
            : base(f_9_22692_22727_C(ConstantValueTypeDiscriminator.Char))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(9, 22632, 22809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 22235, 22241);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 22761, 22794);

                    _value = unchecked((short)value);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(9, 22632, 22809);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 22632, 22809);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 22632, 22809);
                }
            }

            public override short Int16Value
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 22890, 22967);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 22934, 22948);

                        return _value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 22890, 22967);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 22825, 22982);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 22825, 22982);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ushort UInt16Value
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 23065, 23161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 23109, 23142);

                        return unchecked((ushort)_value);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 23065, 23161);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 22998, 23176);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 22998, 23176);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override char CharValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 23255, 23349);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 23299, 23330);

                        return unchecked((char)_value);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 23255, 23349);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 23192, 23364);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 23192, 23364);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 23380, 23523);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 23446, 23508);

                    return f_9_23453_23507(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetHashCode(), 9, 23466, 23484), f_9_23486_23506(_value));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 23380, 23523);

                    int
                    f_9_23486_23506(short
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 23486, 23506);
                        return return_v;
                    }


                    int
                    f_9_23453_23507(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 23453, 23507);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 23380, 23523);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 23380, 23523);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(ConstantValue? other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 23539, 23692);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 23621, 23677);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Equals(other), 9, 23628, 23646) && (DynAbs.Tracing.TraceSender.Expression_True(9, 23628, 23676) && _value == f_9_23660_23676(other));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 23539, 23692);

                    short
                    f_9_23660_23676(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Int16Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(9, 23660, 23676);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 23539, 23692);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 23539, 23692);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ConstantValueI16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(9, 22121, 23703);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(9, 22121, 23703);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 22121, 23703);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(9, 22121, 23703);

            static Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            f_9_22319_22355_C(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(9, 22258, 22419);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            f_9_22497_22534_C(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(9, 22435, 22616);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            f_9_22692_22727_C(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(9, 22632, 22809);
                return return_v;
            }

        }
        private sealed class ConstantValueI32 : ConstantValueDiscriminated
        {
            private readonly int _value;

            public ConstantValueI32(int value)
            : base(f_9_23909_23945_C(ConstantValueTypeDiscriminator.Int32))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(9, 23850, 24009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 23827, 23833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 23979, 23994);

                    _value = value;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(9, 23850, 24009);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 23850, 24009);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 23850, 24009);
                }
            }

            public ConstantValueI32(uint value)
            : base(f_9_24085_24122_C(ConstantValueTypeDiscriminator.UInt32))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(9, 24025, 24202);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 23827, 23833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 24156, 24187);

                    _value = unchecked((int)value);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(9, 24025, 24202);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 24025, 24202);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 24025, 24202);
                }
            }

            public override int Int32Value
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 24281, 24358);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 24325, 24339);

                        return _value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 24281, 24358);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 24218, 24373);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 24218, 24373);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override uint UInt32Value
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 24454, 24548);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 24498, 24529);

                        return unchecked((uint)_value);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 24454, 24548);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 24389, 24563);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 24389, 24563);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 24579, 24722);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 24645, 24707);

                    return f_9_24652_24706(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetHashCode(), 9, 24665, 24683), f_9_24685_24705(_value));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 24579, 24722);

                    int
                    f_9_24685_24705(int
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 24685, 24705);
                        return return_v;
                    }


                    int
                    f_9_24652_24706(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 24652, 24706);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 24579, 24722);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 24579, 24722);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(ConstantValue? other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 24738, 24891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 24820, 24876);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Equals(other), 9, 24827, 24845) && (DynAbs.Tracing.TraceSender.Expression_True(9, 24827, 24875) && _value == f_9_24859_24875(other));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 24738, 24891);

                    int
                    f_9_24859_24875(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Int32Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(9, 24859, 24875);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 24738, 24891);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 24738, 24891);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ConstantValueI32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(9, 23715, 24902);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(9, 23715, 24902);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 23715, 24902);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(9, 23715, 24902);

            static Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            f_9_23909_23945_C(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(9, 23850, 24009);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            f_9_24085_24122_C(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(9, 24025, 24202);
                return return_v;
            }

        }
        private sealed class ConstantValueI64 : ConstantValueDiscriminated
        {
            private readonly long _value;

            public ConstantValueI64(long value)
            : base(f_9_25110_25146_C(ConstantValueTypeDiscriminator.Int64))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(9, 25050, 25210);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 25027, 25033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 25180, 25195);

                    _value = value;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(9, 25050, 25210);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 25050, 25210);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 25050, 25210);
                }
            }

            public ConstantValueI64(ulong value)
            : base(f_9_25287_25324_C(ConstantValueTypeDiscriminator.UInt64))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(9, 25226, 25405);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 25027, 25033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 25358, 25390);

                    _value = unchecked((long)value);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(9, 25226, 25405);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 25226, 25405);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 25226, 25405);
                }
            }

            public override long Int64Value
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 25485, 25562);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 25529, 25543);

                        return _value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 25485, 25562);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 25421, 25577);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 25421, 25577);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ulong UInt64Value
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 25659, 25754);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 25703, 25735);

                        return unchecked((ulong)_value);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 25659, 25754);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 25593, 25769);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 25593, 25769);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 25785, 25928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 25851, 25913);

                    return f_9_25858_25912(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetHashCode(), 9, 25871, 25889), f_9_25891_25911(_value));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 25785, 25928);

                    int
                    f_9_25891_25911(long
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 25891, 25911);
                        return return_v;
                    }


                    int
                    f_9_25858_25912(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 25858, 25912);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 25785, 25928);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 25785, 25928);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(ConstantValue? other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 25944, 26097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 26026, 26082);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Equals(other), 9, 26033, 26051) && (DynAbs.Tracing.TraceSender.Expression_True(9, 26033, 26081) && _value == f_9_26065_26081(other));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 25944, 26097);

                    long
                    f_9_26065_26081(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Int64Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(9, 26065, 26081);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 25944, 26097);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 25944, 26097);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ConstantValueI64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(9, 24914, 26108);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(9, 24914, 26108);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 24914, 26108);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(9, 24914, 26108);

            static Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            f_9_25110_25146_C(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(9, 25050, 25210);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            f_9_25287_25324_C(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(9, 25226, 25405);
                return return_v;
            }

        }
        private sealed class ConstantValueNativeInt : ConstantValueDiscriminated
        {
            private readonly int _value;

            public ConstantValueNativeInt(int value)
            : base(f_9_26391_26426_C(ConstantValueTypeDiscriminator.NInt))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(9, 26326, 26490);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 26303, 26309);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 26460, 26475);

                    _value = value;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(9, 26326, 26490);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 26326, 26490);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 26326, 26490);
                }
            }

            public ConstantValueNativeInt(uint value)
            : base(f_9_26572_26608_C(ConstantValueTypeDiscriminator.NUInt))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(9, 26506, 26688);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 26303, 26309);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 26642, 26673);

                    _value = unchecked((int)value);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(9, 26506, 26688);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 26506, 26688);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 26506, 26688);
                }
            }

            public override int Int32Value
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 26767, 26844);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 26811, 26825);

                        return _value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 26767, 26844);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 26704, 26859);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 26704, 26859);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override uint UInt32Value
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 26940, 27034);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 26984, 27015);

                        return unchecked((uint)_value);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 26940, 27034);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 26875, 27049);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 26875, 27049);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 27065, 27208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 27131, 27193);

                    return f_9_27138_27192(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetHashCode(), 9, 27151, 27169), f_9_27171_27191(_value));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 27065, 27208);

                    int
                    f_9_27171_27191(int
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 27171, 27191);
                        return return_v;
                    }


                    int
                    f_9_27138_27192(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 27138, 27192);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 27065, 27208);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 27065, 27208);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(ConstantValue? other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 27224, 27377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 27306, 27362);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Equals(other), 9, 27313, 27331) && (DynAbs.Tracing.TraceSender.Expression_True(9, 27313, 27361) && _value == f_9_27345_27361(other));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 27224, 27377);

                    int
                    f_9_27345_27361(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Int32Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(9, 27345, 27361);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 27224, 27377);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 27224, 27377);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ConstantValueNativeInt()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(9, 26120, 27388);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(9, 26120, 27388);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 26120, 27388);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(9, 26120, 27388);

            static Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            f_9_26391_26426_C(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(9, 26326, 26490);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            f_9_26572_26608_C(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(9, 26506, 26688);
                return return_v;
            }

        }
        private sealed class ConstantValueDouble : ConstantValueDiscriminated
        {
            private readonly double _value;

            public ConstantValueDouble(double value)
            : base(f_9_27606_27643_C(ConstantValueTypeDiscriminator.Double))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(9, 27541, 27841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 27518, 27524);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 27677, 27791) || true) && (f_9_27681_27700(value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(9, 27677, 27791);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 27742, 27772);

                        value = _s_IEEE_canonical_NaN;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(9, 27677, 27791);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 27811, 27826);

                    _value = value;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(9, 27541, 27841);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 27541, 27841);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 27541, 27841);
                }
            }

            public override double DoubleValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 27924, 28001);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 27968, 27982);

                        return _value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 27924, 28001);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 27857, 28016);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 27857, 28016);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 28032, 28175);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 28098, 28160);

                    return f_9_28105_28159(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetHashCode(), 9, 28118, 28136), f_9_28138_28158(_value));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 28032, 28175);

                    int
                    f_9_28138_28158(double
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 28138, 28158);
                        return return_v;
                    }


                    int
                    f_9_28105_28159(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 28105, 28159);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 28032, 28175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 28032, 28175);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(ConstantValue? other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 28191, 28350);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 28273, 28335);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Equals(other), 9, 28280, 28298) && (DynAbs.Tracing.TraceSender.Expression_True(9, 28280, 28334) && f_9_28302_28334(_value, f_9_28316_28333(other)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 28191, 28350);

                    double
                    f_9_28316_28333(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.DoubleValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(9, 28316, 28333);
                        return return_v;
                    }


                    bool
                    f_9_28302_28334(double
                    this_param, double
                    obj)
                    {
                        var return_v = this_param.Equals(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 28302, 28334);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 28191, 28350);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 28191, 28350);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ConstantValueDouble()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(9, 27400, 28361);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(9, 27400, 28361);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 27400, 28361);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(9, 27400, 28361);

            static bool
            f_9_27681_27700(double
            d)
            {
                var return_v = double.IsNaN(d);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 27681, 27700);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            f_9_27606_27643_C(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(9, 27541, 27841);
                return return_v;
            }

        }
        private sealed class ConstantValueSingle : ConstantValueDiscriminated
        {
            private readonly double _value;

            public ConstantValueSingle(double value)
            : base(f_9_28794_28831_C(ConstantValueTypeDiscriminator.Single))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(9, 28729, 29029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 28706, 28712);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 28865, 28979) || true) && (f_9_28869_28888(value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(9, 28865, 28979);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 28930, 28960);

                        value = _s_IEEE_canonical_NaN;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(9, 28865, 28979);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 28999, 29014);

                    _value = value;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(9, 28729, 29029);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 28729, 29029);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 28729, 29029);
                }
            }

            public override double DoubleValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 29112, 29189);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 29156, 29170);

                        return _value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 29112, 29189);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 29045, 29204);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 29045, 29204);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override float SingleValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 29286, 29370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 29330, 29351);

                        return (float)_value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(9, 29286, 29370);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 29220, 29385);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 29220, 29385);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 29401, 29544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 29467, 29529);

                    return f_9_29474_29528(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetHashCode(), 9, 29487, 29505), f_9_29507_29527(_value));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 29401, 29544);

                    int
                    f_9_29507_29527(double
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 29507, 29527);
                        return return_v;
                    }


                    int
                    f_9_29474_29528(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 29474, 29528);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 29401, 29544);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 29401, 29544);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(ConstantValue? other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(9, 29560, 29719);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(9, 29642, 29704);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Equals(other), 9, 29649, 29667) && (DynAbs.Tracing.TraceSender.Expression_True(9, 29649, 29703) && f_9_29671_29703(_value, f_9_29685_29702(other)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(9, 29560, 29719);

                    double
                    f_9_29685_29702(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.DoubleValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(9, 29685, 29702);
                        return return_v;
                    }


                    bool
                    f_9_29671_29703(double
                    this_param, double
                    obj)
                    {
                        var return_v = this_param.Equals(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 29671, 29703);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(9, 29560, 29719);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 29560, 29719);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ConstantValueSingle()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(9, 28373, 29730);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(9, 28373, 29730);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(9, 28373, 29730);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(9, 28373, 29730);

            static bool
            f_9_28869_28888(double
            d)
            {
                var return_v = double.IsNaN(d);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(9, 28869, 28888);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            f_9_28794_28831_C(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(9, 28729, 29029);
                return return_v;
            }

        }
    }
}
