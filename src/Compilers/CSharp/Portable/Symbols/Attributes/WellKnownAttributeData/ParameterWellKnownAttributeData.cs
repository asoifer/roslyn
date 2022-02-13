// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class ParameterWellKnownAttributeData : CommonParameterWellKnownAttributeData
    {
        private bool _hasAllowNullAttribute;

        public bool HasAllowNullAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10411, 699, 827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 735, 764);

                    f_10411_735_763(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 782, 812);

                    return _hasAllowNullAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10411, 699, 827);

                    int
                    f_10411_735_763(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 735, 763);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10411, 641, 1016);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10411, 641, 1016);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10411, 841, 1005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 877, 907);

                    f_10411_877_906(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 925, 956);

                    _hasAllowNullAttribute = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 974, 990);

                    f_10411_974_989(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10411, 841, 1005);

                    int
                    f_10411_877_906(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 877, 906);
                        return 0;
                    }


                    int
                    f_10411_974_989(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 974, 989);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10411, 641, 1016);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10411, 641, 1016);
                }
            }
        }

        private bool _hasDisallowNullAttribute;

        public bool HasDisallowNullAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10411, 1138, 1269);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 1174, 1203);

                    f_10411_1174_1202(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 1221, 1254);

                    return _hasDisallowNullAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10411, 1138, 1269);

                    int
                    f_10411_1174_1202(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 1174, 1202);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10411, 1077, 1461);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10411, 1077, 1461);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10411, 1283, 1450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 1319, 1349);

                    f_10411_1319_1348(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 1367, 1401);

                    _hasDisallowNullAttribute = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 1419, 1435);

                    f_10411_1419_1434(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10411, 1283, 1450);

                    int
                    f_10411_1319_1348(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 1319, 1348);
                        return 0;
                    }


                    int
                    f_10411_1419_1434(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 1419, 1434);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10411, 1077, 1461);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10411, 1077, 1461);
                }
            }
        }

        private bool _hasMaybeNullAttribute;

        public bool HasMaybeNullAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10411, 1577, 1705);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 1613, 1642);

                    f_10411_1613_1641(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 1660, 1690);

                    return _hasMaybeNullAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10411, 1577, 1705);

                    int
                    f_10411_1613_1641(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 1613, 1641);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10411, 1519, 1894);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10411, 1519, 1894);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10411, 1719, 1883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 1755, 1785);

                    f_10411_1755_1784(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 1803, 1834);

                    _hasMaybeNullAttribute = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 1852, 1868);

                    f_10411_1852_1867(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10411, 1719, 1883);

                    int
                    f_10411_1755_1784(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 1755, 1784);
                        return 0;
                    }


                    int
                    f_10411_1852_1867(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 1852, 1867);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10411, 1519, 1894);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10411, 1519, 1894);
                }
            }
        }

        private bool? _maybeNullWhenAttribute;

        public bool? MaybeNullWhenAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10411, 2014, 2143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 2050, 2079);

                    f_10411_2050_2078(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 2097, 2128);

                    return _maybeNullWhenAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10411, 2014, 2143);

                    int
                    f_10411_2050_2078(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 2050, 2078);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10411, 1954, 2333);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10411, 1954, 2333);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10411, 2157, 2322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 2193, 2223);

                    f_10411_2193_2222(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 2241, 2273);

                    _maybeNullWhenAttribute = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 2291, 2307);

                    f_10411_2291_2306(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10411, 2157, 2322);

                    int
                    f_10411_2193_2222(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 2193, 2222);
                        return 0;
                    }


                    int
                    f_10411_2291_2306(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 2291, 2306);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10411, 1954, 2333);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10411, 1954, 2333);
                }
            }
        }

        private bool _hasNotNullAttribute;

        public bool HasNotNullAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10411, 2445, 2571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 2481, 2510);

                    f_10411_2481_2509(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 2528, 2556);

                    return _hasNotNullAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10411, 2445, 2571);

                    int
                    f_10411_2481_2509(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 2481, 2509);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10411, 2389, 2758);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10411, 2389, 2758);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10411, 2585, 2747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 2621, 2651);

                    f_10411_2621_2650(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 2669, 2698);

                    _hasNotNullAttribute = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 2716, 2732);

                    f_10411_2716_2731(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10411, 2585, 2747);

                    int
                    f_10411_2621_2650(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 2621, 2650);
                        return 0;
                    }


                    int
                    f_10411_2716_2731(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 2716, 2731);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10411, 2389, 2758);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10411, 2389, 2758);
                }
            }
        }

        private bool? _notNullWhenAttribute;

        public bool? NotNullWhenAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10411, 2874, 3001);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 2910, 2939);

                    f_10411_2910_2938(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 2957, 2986);

                    return _notNullWhenAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10411, 2874, 3001);

                    int
                    f_10411_2910_2938(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 2910, 2938);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10411, 2816, 3189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10411, 2816, 3189);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10411, 3015, 3178);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 3051, 3081);

                    f_10411_3051_3080(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 3099, 3129);

                    _notNullWhenAttribute = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 3147, 3163);

                    f_10411_3147_3162(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10411, 3015, 3178);

                    int
                    f_10411_3051_3080(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 3051, 3080);
                        return 0;
                    }


                    int
                    f_10411_3147_3162(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 3147, 3162);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10411, 2816, 3189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10411, 2816, 3189);
                }
            }
        }

        private bool? _doesNotReturnIfAttribute;

        public bool? DoesNotReturnIfAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10411, 3313, 3444);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 3349, 3378);

                    f_10411_3349_3377(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 3396, 3429);

                    return _doesNotReturnIfAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10411, 3313, 3444);

                    int
                    f_10411_3349_3377(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 3349, 3377);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10411, 3251, 3636);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10411, 3251, 3636);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10411, 3458, 3625);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 3494, 3524);

                    f_10411_3494_3523(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 3542, 3576);

                    _doesNotReturnIfAttribute = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 3594, 3610);

                    f_10411_3594_3609(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10411, 3458, 3625);

                    int
                    f_10411_3494_3523(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 3494, 3523);
                        return 0;
                    }


                    int
                    f_10411_3594_3609(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 3594, 3609);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10411, 3251, 3636);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10411, 3251, 3636);
                }
            }
        }

        private bool _hasEnumeratorCancellationAttribute;

        public bool HasEnumeratorCancellationAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10411, 3778, 3919);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 3814, 3843);

                    f_10411_3814_3842(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 3861, 3904);

                    return _hasEnumeratorCancellationAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10411, 3778, 3919);

                    int
                    f_10411_3814_3842(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 3814, 3842);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10411, 3707, 4121);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10411, 3707, 4121);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10411, 3933, 4110);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 3969, 3999);

                    f_10411_3969_3998(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 4017, 4061);

                    _hasEnumeratorCancellationAttribute = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 4079, 4095);

                    f_10411_4079_4094(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10411, 3933, 4110);

                    int
                    f_10411_3969_3998(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 3969, 3998);
                        return 0;
                    }


                    int
                    f_10411_4079_4094(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 4079, 4094);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10411, 3707, 4121);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10411, 3707, 4121);
                }
            }
        }

        private ImmutableHashSet<string> _notNullIfParameterNotNull;

        public ImmutableHashSet<string> NotNullIfParameterNotNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10411, 4318, 4450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 4354, 4383);

                    f_10411_4354_4382(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 4401, 4435);

                    return _notNullIfParameterNotNull;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10411, 4318, 4450);

                    int
                    f_10411_4354_4382(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 4354, 4382);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10411, 4236, 4461);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10411, 4236, 4461);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void AddNotNullIfParameterNotNull(string parameterName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10411, 4471, 4775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 4558, 4588);

                f_10411_4558_4587(this, expected: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 4659, 4734);

                _notNullIfParameterNotNull = f_10411_4688_4733(_notNullIfParameterNotNull, parameterName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 4748, 4764);

                f_10411_4748_4763(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10411, 4471, 4775);

                int
                f_10411_4558_4587(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                this_param, bool
                expected)
                {
                    this_param.VerifySealed(expected: expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 4558, 4587);
                    return 0;
                }


                System.Collections.Immutable.ImmutableHashSet<string>
                f_10411_4688_4733(System.Collections.Immutable.ImmutableHashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 4688, 4733);
                    return return_v;
                }


                int
                f_10411_4748_4763(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterWellKnownAttributeData
                this_param)
                {
                    this_param.SetDataStored();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10411, 4748, 4763);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10411, 4471, 4775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10411, 4471, 4775);
            }
        }

        public ParameterWellKnownAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10411, 485, 4782);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 608, 630);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 1041, 1066);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 1486, 1508);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 1920, 1943);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 2358, 2378);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 2784, 2805);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 3215, 3240);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 3661, 3696);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10411, 4166, 4225);
            this._notNullIfParameterNotNull = ImmutableHashSet<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitConstructor(10411, 485, 4782);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10411, 485, 4782);
        }


        static ParameterWellKnownAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10411, 485, 4782);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10411, 485, 4782);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10411, 485, 4782);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10411, 485, 4782);
    }
}
