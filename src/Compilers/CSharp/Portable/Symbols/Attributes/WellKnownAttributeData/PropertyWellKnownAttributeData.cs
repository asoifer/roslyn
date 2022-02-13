// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class PropertyWellKnownAttributeData : CommonPropertyWellKnownAttributeData, ISkipLocalsInitAttributeTarget, IMemberNotNullAttributeTarget
    {
        private bool _hasDisallowNullAttribute;

        public bool HasDisallowNullAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10413, 775, 906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 811, 840);

                    f_10413_811_839(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 858, 891);

                    return _hasDisallowNullAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10413, 775, 906);

                    int
                    f_10413_811_839(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10413, 811, 839);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10413, 714, 1098);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10413, 714, 1098);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10413, 920, 1087);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 956, 986);

                    f_10413_956_985(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 1004, 1038);

                    _hasDisallowNullAttribute = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 1056, 1072);

                    f_10413_1056_1071(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10413, 920, 1087);

                    int
                    f_10413_956_985(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10413, 956, 985);
                        return 0;
                    }


                    int
                    f_10413_1056_1071(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10413, 1056, 1071);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10413, 714, 1098);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10413, 714, 1098);
                }
            }
        }

        private bool _hasAllowNullAttribute;

        public bool HasAllowNullAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10413, 1214, 1342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 1250, 1279);

                    f_10413_1250_1278(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 1297, 1327);

                    return _hasAllowNullAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10413, 1214, 1342);

                    int
                    f_10413_1250_1278(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10413, 1250, 1278);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10413, 1156, 1531);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10413, 1156, 1531);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10413, 1356, 1520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 1392, 1422);

                    f_10413_1392_1421(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 1440, 1471);

                    _hasAllowNullAttribute = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 1489, 1505);

                    f_10413_1489_1504(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10413, 1356, 1520);

                    int
                    f_10413_1392_1421(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10413, 1392, 1421);
                        return 0;
                    }


                    int
                    f_10413_1489_1504(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10413, 1489, 1504);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10413, 1156, 1531);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10413, 1156, 1531);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10413, 1647, 1775);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 1683, 1712);

                    f_10413_1683_1711(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 1730, 1760);

                    return _hasMaybeNullAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10413, 1647, 1775);

                    int
                    f_10413_1683_1711(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10413, 1683, 1711);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10413, 1589, 1964);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10413, 1589, 1964);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10413, 1789, 1953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 1825, 1855);

                    f_10413_1825_1854(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 1873, 1904);

                    _hasMaybeNullAttribute = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 1922, 1938);

                    f_10413_1922_1937(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10413, 1789, 1953);

                    int
                    f_10413_1825_1854(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10413, 1825, 1854);
                        return 0;
                    }


                    int
                    f_10413_1922_1937(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10413, 1922, 1937);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10413, 1589, 1964);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10413, 1589, 1964);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10413, 2076, 2202);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 2112, 2141);

                    f_10413_2112_2140(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 2159, 2187);

                    return _hasNotNullAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10413, 2076, 2202);

                    int
                    f_10413_2112_2140(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10413, 2112, 2140);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10413, 2020, 2389);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10413, 2020, 2389);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10413, 2216, 2378);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 2252, 2282);

                    f_10413_2252_2281(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 2300, 2329);

                    _hasNotNullAttribute = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 2347, 2363);

                    f_10413_2347_2362(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10413, 2216, 2378);

                    int
                    f_10413_2252_2281(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10413, 2252, 2281);
                        return 0;
                    }


                    int
                    f_10413_2347_2362(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10413, 2347, 2362);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10413, 2020, 2389);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10413, 2020, 2389);
                }
            }
        }

        private bool _hasSkipLocalsInitAttribute;

        public bool HasSkipLocalsInitAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10413, 2515, 2648);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 2551, 2580);

                    f_10413_2551_2579(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 2598, 2633);

                    return _hasSkipLocalsInitAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10413, 2515, 2648);

                    int
                    f_10413_2551_2579(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10413, 2551, 2579);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10413, 2452, 2842);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10413, 2452, 2842);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10413, 2662, 2831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 2698, 2728);

                    f_10413_2698_2727(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 2746, 2782);

                    _hasSkipLocalsInitAttribute = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 2800, 2816);

                    f_10413_2800_2815(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10413, 2662, 2831);

                    int
                    f_10413_2698_2727(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10413, 2698, 2727);
                        return 0;
                    }


                    int
                    f_10413_2800_2815(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10413, 2800, 2815);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10413, 2452, 2842);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10413, 2452, 2842);
                }
            }
        }

        private ImmutableArray<string> _memberNotNullAttributeData;

        public void AddNotNullMember(string memberName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10413, 2956, 3187);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 3028, 3058);

                f_10413_3028_3057(this, expected: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 3072, 3146);

                _memberNotNullAttributeData = _memberNotNullAttributeData.Add(memberName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 3160, 3176);

                f_10413_3160_3175(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10413, 2956, 3187);

                int
                f_10413_3028_3057(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                this_param, bool
                expected)
                {
                    this_param.VerifySealed(expected: expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10413, 3028, 3057);
                    return 0;
                }


                int
                f_10413_3160_3175(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                this_param)
                {
                    this_param.SetDataStored();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10413, 3160, 3175);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10413, 2956, 3187);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10413, 2956, 3187);
            }
        }

        public void AddNotNullMember(ArrayBuilder<string> memberNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10413, 3199, 3451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 3286, 3316);

                f_10413_3286_3315(this, expected: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 3330, 3410);

                _memberNotNullAttributeData = _memberNotNullAttributeData.AddRange(memberNames);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 3424, 3440);

                f_10413_3424_3439(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10413, 3199, 3451);

                int
                f_10413_3286_3315(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                this_param, bool
                expected)
                {
                    this_param.VerifySealed(expected: expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10413, 3286, 3315);
                    return 0;
                }


                int
                f_10413_3424_3439(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                this_param)
                {
                    this_param.SetDataStored();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10413, 3424, 3439);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10413, 3199, 3451);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10413, 3199, 3451);
            }
        }

        public ImmutableArray<string> NotNullMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10413, 3532, 3665);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 3568, 3597);

                    f_10413_3568_3596(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 3615, 3650);

                    return _memberNotNullAttributeData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10413, 3532, 3665);

                    int
                    f_10413_3568_3596(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10413, 3568, 3596);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10413, 3463, 3676);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10413, 3463, 3676);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ImmutableArray<string> _memberNotNullWhenTrueAttributeData;

        private ImmutableArray<string> _memberNotNullWhenFalseAttributeData;

        public void AddNotNullWhenMember(bool sense, string memberName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10413, 3907, 4386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 3995, 4025);

                f_10413_3995_4024(this, expected: false);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 4039, 4345) || true) && (sense)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10413, 4039, 4345);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 4082, 4172);

                    _memberNotNullWhenTrueAttributeData = _memberNotNullWhenTrueAttributeData.Add(memberName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10413, 4039, 4345);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10413, 4039, 4345);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 4238, 4330);

                    _memberNotNullWhenFalseAttributeData = _memberNotNullWhenFalseAttributeData.Add(memberName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10413, 4039, 4345);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 4359, 4375);

                f_10413_4359_4374(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10413, 3907, 4386);

                int
                f_10413_3995_4024(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                this_param, bool
                expected)
                {
                    this_param.VerifySealed(expected: expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10413, 3995, 4024);
                    return 0;
                }


                int
                f_10413_4359_4374(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                this_param)
                {
                    this_param.SetDataStored();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10413, 4359, 4374);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10413, 3907, 4386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10413, 3907, 4386);
            }
        }

        public void AddNotNullWhenMember(bool sense, ArrayBuilder<string> memberNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10413, 4398, 4904);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 4501, 4531);

                f_10413_4501_4530(this, expected: false);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 4545, 4863) || true) && (sense)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10413, 4545, 4863);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 4588, 4684);

                    _memberNotNullWhenTrueAttributeData = _memberNotNullWhenTrueAttributeData.AddRange(memberNames);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10413, 4545, 4863);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10413, 4545, 4863);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 4750, 4848);

                    _memberNotNullWhenFalseAttributeData = _memberNotNullWhenFalseAttributeData.AddRange(memberNames);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10413, 4545, 4863);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 4877, 4893);

                f_10413_4877_4892(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10413, 4398, 4904);

                int
                f_10413_4501_4530(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                this_param, bool
                expected)
                {
                    this_param.VerifySealed(expected: expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10413, 4501, 4530);
                    return 0;
                }


                int
                f_10413_4877_4892(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                this_param)
                {
                    this_param.SetDataStored();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10413, 4877, 4892);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10413, 4398, 4904);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10413, 4398, 4904);
            }
        }

        public ImmutableArray<string> NotNullWhenTrueMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10413, 4993, 5134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 5029, 5058);

                    f_10413_5029_5057(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 5076, 5119);

                    return _memberNotNullWhenTrueAttributeData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10413, 4993, 5134);

                    int
                    f_10413_5029_5057(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10413, 5029, 5057);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10413, 4916, 5145);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10413, 4916, 5145);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<string> NotNullWhenFalseMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10413, 5235, 5377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 5271, 5300);

                    f_10413_5271_5299(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 5318, 5362);

                    return _memberNotNullWhenFalseAttributeData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10413, 5235, 5377);

                    int
                    f_10413_5271_5299(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10413, 5271, 5299);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10413, 5157, 5388);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10413, 5157, 5388);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PropertyWellKnownAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10413, 494, 5395);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 678, 703);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 1123, 1145);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 1556, 1578);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 1989, 2009);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 2414, 2441);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 2885, 2943);
            this._memberNotNullAttributeData = ImmutableArray<string>.Empty; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 3719, 3785);
            this._memberNotNullWhenTrueAttributeData = ImmutableArray<string>.Empty; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10413, 3827, 3894);
            this._memberNotNullWhenFalseAttributeData = ImmutableArray<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitConstructor(10413, 494, 5395);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10413, 494, 5395);
        }


        static PropertyWellKnownAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10413, 494, 5395);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10413, 494, 5395);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10413, 494, 5395);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10413, 494, 5395);
    }
}
