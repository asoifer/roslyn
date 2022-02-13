// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class MethodWellKnownAttributeData : CommonMethodWellKnownAttributeData, ISkipLocalsInitAttributeTarget, IMemberNotNullAttributeTarget
    {
        private bool _hasDoesNotReturnAttribute;

        public bool HasDoesNotReturnAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10408, 750, 882);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 786, 815);

                    f_10408_786_814(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 833, 867);

                    return _hasDoesNotReturnAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10408, 750, 882);

                    int
                    f_10408_786_814(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10408, 786, 814);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10408, 688, 1075);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10408, 688, 1075);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10408, 896, 1064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 932, 962);

                    f_10408_932_961(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 980, 1015);

                    _hasDoesNotReturnAttribute = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 1033, 1049);

                    f_10408_1033_1048(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10408, 896, 1064);

                    int
                    f_10408_932_961(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10408, 932, 961);
                        return 0;
                    }


                    int
                    f_10408_1033_1048(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10408, 1033, 1048);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10408, 688, 1075);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10408, 688, 1075);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10408, 1201, 1334);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 1237, 1266);

                    f_10408_1237_1265(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 1284, 1319);

                    return _hasSkipLocalsInitAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10408, 1201, 1334);

                    int
                    f_10408_1237_1265(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10408, 1237, 1265);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10408, 1138, 1528);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10408, 1138, 1528);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10408, 1348, 1517);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 1384, 1414);

                    f_10408_1384_1413(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 1432, 1468);

                    _hasSkipLocalsInitAttribute = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 1486, 1502);

                    f_10408_1486_1501(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10408, 1348, 1517);

                    int
                    f_10408_1384_1413(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10408, 1384, 1413);
                        return 0;
                    }


                    int
                    f_10408_1486_1501(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10408, 1486, 1501);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10408, 1138, 1528);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10408, 1138, 1528);
                }
            }
        }

        private ImmutableArray<string> _memberNotNullAttributeData;

        public void AddNotNullMember(string memberName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10408, 1642, 1873);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 1714, 1744);

                f_10408_1714_1743(this, expected: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 1758, 1832);

                _memberNotNullAttributeData = _memberNotNullAttributeData.Add(memberName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 1846, 1862);

                f_10408_1846_1861(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10408, 1642, 1873);

                int
                f_10408_1714_1743(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                this_param, bool
                expected)
                {
                    this_param.VerifySealed(expected: expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10408, 1714, 1743);
                    return 0;
                }


                int
                f_10408_1846_1861(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                this_param)
                {
                    this_param.SetDataStored();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10408, 1846, 1861);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10408, 1642, 1873);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10408, 1642, 1873);
            }
        }

        public void AddNotNullMember(ArrayBuilder<string> memberNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10408, 1885, 2137);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 1972, 2002);

                f_10408_1972_2001(this, expected: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 2016, 2096);

                _memberNotNullAttributeData = _memberNotNullAttributeData.AddRange(memberNames);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 2110, 2126);

                f_10408_2110_2125(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10408, 1885, 2137);

                int
                f_10408_1972_2001(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                this_param, bool
                expected)
                {
                    this_param.VerifySealed(expected: expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10408, 1972, 2001);
                    return 0;
                }


                int
                f_10408_2110_2125(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                this_param)
                {
                    this_param.SetDataStored();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10408, 2110, 2125);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10408, 1885, 2137);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10408, 1885, 2137);
            }
        }

        public ImmutableArray<string> NotNullMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10408, 2218, 2351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 2254, 2283);

                    f_10408_2254_2282(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 2301, 2336);

                    return _memberNotNullAttributeData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10408, 2218, 2351);

                    int
                    f_10408_2254_2282(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10408, 2254, 2282);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10408, 2149, 2362);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10408, 2149, 2362);
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
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10408, 2593, 3072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 2681, 2711);

                f_10408_2681_2710(this, expected: false);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 2725, 3031) || true) && (sense)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10408, 2725, 3031);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 2768, 2858);

                    _memberNotNullWhenTrueAttributeData = _memberNotNullWhenTrueAttributeData.Add(memberName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10408, 2725, 3031);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10408, 2725, 3031);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 2924, 3016);

                    _memberNotNullWhenFalseAttributeData = _memberNotNullWhenFalseAttributeData.Add(memberName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10408, 2725, 3031);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 3045, 3061);

                f_10408_3045_3060(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10408, 2593, 3072);

                int
                f_10408_2681_2710(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                this_param, bool
                expected)
                {
                    this_param.VerifySealed(expected: expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10408, 2681, 2710);
                    return 0;
                }


                int
                f_10408_3045_3060(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                this_param)
                {
                    this_param.SetDataStored();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10408, 3045, 3060);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10408, 2593, 3072);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10408, 2593, 3072);
            }
        }

        public void AddNotNullWhenMember(bool sense, ArrayBuilder<string> memberNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10408, 3084, 3590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 3187, 3217);

                f_10408_3187_3216(this, expected: false);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 3231, 3549) || true) && (sense)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10408, 3231, 3549);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 3274, 3370);

                    _memberNotNullWhenTrueAttributeData = _memberNotNullWhenTrueAttributeData.AddRange(memberNames);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10408, 3231, 3549);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10408, 3231, 3549);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 3436, 3534);

                    _memberNotNullWhenFalseAttributeData = _memberNotNullWhenFalseAttributeData.AddRange(memberNames);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10408, 3231, 3549);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 3563, 3579);

                f_10408_3563_3578(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10408, 3084, 3590);

                int
                f_10408_3187_3216(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                this_param, bool
                expected)
                {
                    this_param.VerifySealed(expected: expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10408, 3187, 3216);
                    return 0;
                }


                int
                f_10408_3563_3578(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                this_param)
                {
                    this_param.SetDataStored();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10408, 3563, 3578);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10408, 3084, 3590);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10408, 3084, 3590);
            }
        }

        public ImmutableArray<string> NotNullWhenTrueMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10408, 3679, 3820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 3715, 3744);

                    f_10408_3715_3743(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 3762, 3805);

                    return _memberNotNullWhenTrueAttributeData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10408, 3679, 3820);

                    int
                    f_10408_3715_3743(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10408, 3715, 3743);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10408, 3602, 3831);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10408, 3602, 3831);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10408, 3921, 4063);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 3957, 3986);

                    f_10408_3957_3985(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 4004, 4048);

                    return _memberNotNullWhenFalseAttributeData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10408, 3921, 4063);

                    int
                    f_10408_3957_3985(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10408, 3957, 3985);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10408, 3843, 4074);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10408, 3843, 4074);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private UnmanagedCallersOnlyAttributeData? _unmanagedCallersOnlyAttributeData;

        public UnmanagedCallersOnlyAttributeData? UnmanagedCallersOnlyAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10408, 4274, 4414);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 4310, 4339);

                    f_10408_4310_4338(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 4357, 4399);

                    return _unmanagedCallersOnlyAttributeData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10408, 4274, 4414);

                    int
                    f_10408_4310_4338(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10408, 4310, 4338);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10408, 4174, 4615);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10408, 4174, 4615);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10408, 4428, 4604);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 4464, 4494);

                    f_10408_4464_4493(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 4512, 4555);

                    _unmanagedCallersOnlyAttributeData = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 4573, 4589);

                    f_10408_4573_4588(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10408, 4428, 4604);

                    int
                    f_10408_4464_4493(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10408, 4464, 4493);
                        return 0;
                    }


                    int
                    f_10408_4573_4588(Microsoft.CodeAnalysis.CSharp.Symbols.MethodWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10408, 4573, 4588);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10408, 4174, 4615);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10408, 4174, 4615);
                }
            }
        }

        public MethodWellKnownAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10408, 471, 4622);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 651, 677);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 1100, 1127);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 1571, 1629);
            this._memberNotNullAttributeData = ImmutableArray<string>.Empty; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 2405, 2471);
            this._memberNotNullWhenTrueAttributeData = ImmutableArray<string>.Empty; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 2513, 2580);
            this._memberNotNullWhenFalseAttributeData = ImmutableArray<string>.Empty; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10408, 4129, 4163);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10408, 471, 4622);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10408, 471, 4622);
        }


        static MethodWellKnownAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10408, 471, 4622);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10408, 471, 4622);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10408, 471, 4622);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10408, 471, 4622);
    }
}
