// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class FieldWellKnownAttributeData : CommonFieldWellKnownAttributeData
    {
        private bool _hasAllowNullAttribute;

        public bool HasAllowNullAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10406, 613, 741);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 649, 678);

                    f_10406_649_677(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 696, 726);

                    return _hasAllowNullAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10406, 613, 741);

                    int
                    f_10406_649_677(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10406, 649, 677);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10406, 555, 930);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10406, 555, 930);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10406, 755, 919);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 791, 821);

                    f_10406_791_820(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 839, 870);

                    _hasAllowNullAttribute = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 888, 904);

                    f_10406_888_903(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10406, 755, 919);

                    int
                    f_10406_791_820(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10406, 791, 820);
                        return 0;
                    }


                    int
                    f_10406_888_903(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10406, 888, 903);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10406, 555, 930);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10406, 555, 930);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10406, 1052, 1183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 1088, 1117);

                    f_10406_1088_1116(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 1135, 1168);

                    return _hasDisallowNullAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10406, 1052, 1183);

                    int
                    f_10406_1088_1116(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10406, 1088, 1116);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10406, 991, 1375);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10406, 991, 1375);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10406, 1197, 1364);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 1233, 1263);

                    f_10406_1233_1262(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 1281, 1315);

                    _hasDisallowNullAttribute = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 1333, 1349);

                    f_10406_1333_1348(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10406, 1197, 1364);

                    int
                    f_10406_1233_1262(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10406, 1233, 1262);
                        return 0;
                    }


                    int
                    f_10406_1333_1348(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10406, 1333, 1348);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10406, 991, 1375);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10406, 991, 1375);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10406, 1491, 1619);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 1527, 1556);

                    f_10406_1527_1555(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 1574, 1604);

                    return _hasMaybeNullAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10406, 1491, 1619);

                    int
                    f_10406_1527_1555(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10406, 1527, 1555);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10406, 1433, 1808);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10406, 1433, 1808);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10406, 1633, 1797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 1669, 1699);

                    f_10406_1669_1698(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 1717, 1748);

                    _hasMaybeNullAttribute = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 1766, 1782);

                    f_10406_1766_1781(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10406, 1633, 1797);

                    int
                    f_10406_1669_1698(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10406, 1669, 1698);
                        return 0;
                    }


                    int
                    f_10406_1766_1781(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10406, 1766, 1781);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10406, 1433, 1808);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10406, 1433, 1808);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10406, 1928, 2057);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 1964, 1993);

                    f_10406_1964_1992(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 2011, 2042);

                    return _maybeNullWhenAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10406, 1928, 2057);

                    int
                    f_10406_1964_1992(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10406, 1964, 1992);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10406, 1868, 2247);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10406, 1868, 2247);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10406, 2071, 2236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 2107, 2137);

                    f_10406_2107_2136(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 2155, 2187);

                    _maybeNullWhenAttribute = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 2205, 2221);

                    f_10406_2205_2220(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10406, 2071, 2236);

                    int
                    f_10406_2107_2136(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10406, 2107, 2136);
                        return 0;
                    }


                    int
                    f_10406_2205_2220(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10406, 2205, 2220);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10406, 1868, 2247);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10406, 1868, 2247);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10406, 2359, 2485);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 2395, 2424);

                    f_10406_2395_2423(this, expected: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 2442, 2470);

                    return _hasNotNullAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10406, 2359, 2485);

                    int
                    f_10406_2395_2423(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10406, 2395, 2423);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10406, 2303, 2672);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10406, 2303, 2672);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10406, 2499, 2661);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 2535, 2565);

                    f_10406_2535_2564(this, expected: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 2583, 2612);

                    _hasNotNullAttribute = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 2630, 2646);

                    f_10406_2630_2645(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10406, 2499, 2661);

                    int
                    f_10406_2535_2564(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                    this_param, bool
                    expected)
                    {
                        this_param.VerifySealed(expected: expected);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10406, 2535, 2564);
                        return 0;
                    }


                    int
                    f_10406_2630_2645(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                    this_param)
                    {
                        this_param.SetDataStored();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10406, 2630, 2645);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10406, 2303, 2672);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10406, 2303, 2672);
                }
            }
        }

        public FieldWellKnownAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10406, 407, 2679);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 522, 544);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 955, 980);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 1400, 1422);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 1834, 1857);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10406, 2272, 2292);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10406, 407, 2679);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10406, 407, 2679);
        }


        static FieldWellKnownAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10406, 407, 2679);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10406, 407, 2679);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10406, 407, 2679);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10406, 407, 2679);
    }
}
