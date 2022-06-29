// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    internal class DiagnosticWithInfo : Diagnostic
    {
        private readonly DiagnosticInfo _info;

        private readonly Location _location;

        private readonly bool _isSuppressed;

        internal DiagnosticWithInfo(DiagnosticInfo info, Location location, bool isSuppressed = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(187, 776, 1095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 666, 671);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 708, 717);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 750, 763);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 895, 928);

                f_187_895_927(info != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 942, 979);

                f_187_942_978(location != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 993, 1006);

                _info = info;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 1020, 1041);

                _location = location;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 1055, 1084);

                _isSuppressed = isSuppressed;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(187, 776, 1095);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(187, 776, 1095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(187, 776, 1095);
            }
        }

        public override Location Location
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(187, 1165, 1190);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 1171, 1188);

                    return _location;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(187, 1165, 1190);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(187, 1107, 1201);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(187, 1107, 1201);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override IReadOnlyList<Location> AdditionalLocations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(187, 1297, 1342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 1303, 1340);

                    return f_187_1310_1339(f_187_1310_1319(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(187, 1297, 1342);

                    Microsoft.CodeAnalysis.DiagnosticInfo
                    f_187_1310_1319(Microsoft.CodeAnalysis.DiagnosticWithInfo
                    this_param)
                    {
                        var return_v = this_param.Info;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 1310, 1319);
                        return return_v;
                    }


                    System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                    f_187_1310_1339(Microsoft.CodeAnalysis.DiagnosticInfo
                    this_param)
                    {
                        var return_v = this_param.AdditionalLocations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 1310, 1339);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(187, 1213, 1353);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(187, 1213, 1353);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override IReadOnlyList<string> CustomTags
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(187, 1440, 1519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 1476, 1504);

                    return f_187_1483_1503(f_187_1483_1492(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(187, 1440, 1519);

                    Microsoft.CodeAnalysis.DiagnosticInfo
                    f_187_1483_1492(Microsoft.CodeAnalysis.DiagnosticWithInfo
                    this_param)
                    {
                        var return_v = this_param.Info;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 1483, 1492);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<string>
                    f_187_1483_1503(Microsoft.CodeAnalysis.DiagnosticInfo
                    this_param)
                    {
                        var return_v = this_param.CustomTags;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 1483, 1503);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(187, 1365, 1530);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(187, 1365, 1530);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override DiagnosticDescriptor Descriptor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(187, 1614, 1693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 1650, 1678);

                    return f_187_1657_1677(f_187_1657_1666(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(187, 1614, 1693);

                    Microsoft.CodeAnalysis.DiagnosticInfo
                    f_187_1657_1666(Microsoft.CodeAnalysis.DiagnosticWithInfo
                    this_param)
                    {
                        var return_v = this_param.Info;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 1657, 1666);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticDescriptor
                    f_187_1657_1677(Microsoft.CodeAnalysis.DiagnosticInfo
                    this_param)
                    {
                        var return_v = this_param.Descriptor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 1657, 1677);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(187, 1542, 1704);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(187, 1542, 1704);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Id
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(187, 1766, 1809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 1772, 1807);

                    return f_187_1779_1806(f_187_1779_1788(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(187, 1766, 1809);

                    Microsoft.CodeAnalysis.DiagnosticInfo
                    f_187_1779_1788(Microsoft.CodeAnalysis.DiagnosticWithInfo
                    this_param)
                    {
                        var return_v = this_param.Info;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 1779, 1788);
                        return return_v;
                    }


                    string
                    f_187_1779_1806(Microsoft.CodeAnalysis.DiagnosticInfo
                    this_param)
                    {
                        var return_v = this_param.MessageIdentifier;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 1779, 1806);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(187, 1716, 1820);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(187, 1716, 1820);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override string Category
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(187, 1890, 1924);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 1896, 1922);

                    return f_187_1903_1921(f_187_1903_1912(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(187, 1890, 1924);

                    Microsoft.CodeAnalysis.DiagnosticInfo
                    f_187_1903_1912(Microsoft.CodeAnalysis.DiagnosticWithInfo
                    this_param)
                    {
                        var return_v = this_param.Info;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 1903, 1912);
                        return return_v;
                    }


                    string
                    f_187_1903_1921(Microsoft.CodeAnalysis.DiagnosticInfo
                    this_param)
                    {
                        var return_v = this_param.Category;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 1903, 1921);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(187, 1832, 1935);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(187, 1832, 1935);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override int Code
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(187, 2007, 2037);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 2013, 2035);

                    return f_187_2020_2034(f_187_2020_2029(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(187, 2007, 2037);

                    Microsoft.CodeAnalysis.DiagnosticInfo
                    f_187_2020_2029(Microsoft.CodeAnalysis.DiagnosticWithInfo
                    this_param)
                    {
                        var return_v = this_param.Info;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 2020, 2029);
                        return return_v;
                    }


                    int
                    f_187_2020_2034(Microsoft.CodeAnalysis.DiagnosticInfo
                    this_param)
                    {
                        var return_v = this_param.Code;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 2020, 2034);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(187, 1949, 2048);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(187, 1949, 2048);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override DiagnosticSeverity Severity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(187, 2135, 2169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 2141, 2167);

                    return f_187_2148_2166(f_187_2148_2157(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(187, 2135, 2169);

                    Microsoft.CodeAnalysis.DiagnosticInfo
                    f_187_2148_2157(Microsoft.CodeAnalysis.DiagnosticWithInfo
                    this_param)
                    {
                        var return_v = this_param.Info;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 2148, 2157);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_187_2148_2166(Microsoft.CodeAnalysis.DiagnosticInfo
                    this_param)
                    {
                        var return_v = this_param.Severity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 2148, 2166);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(187, 2060, 2180);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(187, 2060, 2180);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override DiagnosticSeverity DefaultSeverity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(187, 2274, 2315);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 2280, 2313);

                    return f_187_2287_2312(f_187_2287_2296(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(187, 2274, 2315);

                    Microsoft.CodeAnalysis.DiagnosticInfo
                    f_187_2287_2296(Microsoft.CodeAnalysis.DiagnosticWithInfo
                    this_param)
                    {
                        var return_v = this_param.Info;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 2287, 2296);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_187_2287_2312(Microsoft.CodeAnalysis.DiagnosticInfo
                    this_param)
                    {
                        var return_v = this_param.DefaultSeverity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 2287, 2312);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(187, 2192, 2326);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(187, 2192, 2326);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsEnabledByDefault
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(187, 2484, 2504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 2490, 2502);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(187, 2484, 2504);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(187, 2338, 2515);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(187, 2338, 2515);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsSuppressed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(187, 2585, 2614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 2591, 2612);

                    return _isSuppressed;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(187, 2585, 2614);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(187, 2527, 2625);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(187, 2527, 2625);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override int WarningLevel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(187, 2701, 2739);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 2707, 2737);

                    return f_187_2714_2736(f_187_2714_2723(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(187, 2701, 2739);

                    Microsoft.CodeAnalysis.DiagnosticInfo
                    f_187_2714_2723(Microsoft.CodeAnalysis.DiagnosticWithInfo
                    this_param)
                    {
                        var return_v = this_param.Info;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 2714, 2723);
                        return return_v;
                    }


                    int
                    f_187_2714_2736(Microsoft.CodeAnalysis.DiagnosticInfo
                    this_param)
                    {
                        var return_v = this_param.WarningLevel;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 2714, 2736);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(187, 2637, 2750);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(187, 2637, 2750);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string GetMessage(IFormatProvider? formatProvider = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(187, 2762, 2915);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 2860, 2904);

                return f_187_2867_2903(f_187_2867_2876(this), formatProvider);
                DynAbs.Tracing.TraceSender.TraceExitMethod(187, 2762, 2915);

                Microsoft.CodeAnalysis.DiagnosticInfo
                f_187_2867_2876(Microsoft.CodeAnalysis.DiagnosticWithInfo
                this_param)
                {
                    var return_v = this_param.Info;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 2867, 2876);
                    return return_v;
                }


                string
                f_187_2867_2903(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param, System.IFormatProvider?
                formatProvider)
                {
                    var return_v = this_param.GetMessage(formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(187, 2867, 2903);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(187, 2762, 2915);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(187, 2762, 2915);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IReadOnlyList<object?> Arguments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(187, 3002, 3037);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 3008, 3035);

                    return f_187_3015_3034(f_187_3015_3024(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(187, 3002, 3037);

                    Microsoft.CodeAnalysis.DiagnosticInfo
                    f_187_3015_3024(Microsoft.CodeAnalysis.DiagnosticWithInfo
                    this_param)
                    {
                        var return_v = this_param.Info;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 3015, 3024);
                        return return_v;
                    }


                    object[]
                    f_187_3015_3034(Microsoft.CodeAnalysis.DiagnosticInfo
                    this_param)
                    {
                        var return_v = this_param.Arguments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 3015, 3034);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(187, 2927, 3048);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(187, 2927, 3048);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public DiagnosticInfo Info
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(187, 3247, 3479);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 3283, 3431) || true) && (f_187_3287_3301(_info) == InternalDiagnosticSeverity.Unknown)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(187, 3283, 3431);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 3381, 3412);

                        return f_187_3388_3411(_info);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(187, 3283, 3431);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 3451, 3464);

                    return _info;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(187, 3247, 3479);

                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_187_3287_3301(Microsoft.CodeAnalysis.DiagnosticInfo
                    this_param)
                    {
                        var return_v = this_param.Severity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 3287, 3301);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticInfo
                    f_187_3388_3411(Microsoft.CodeAnalysis.DiagnosticInfo
                    this_param)
                    {
                        var return_v = this_param.GetResolvedInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(187, 3388, 3411);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(187, 3196, 3490);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(187, 3196, 3490);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasLazyInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(187, 3736, 3921);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 3772, 3906);

                    return f_187_3779_3793(_info) == InternalDiagnosticSeverity.Unknown || (DynAbs.Tracing.TraceSender.Expression_False(187, 3779, 3905) || f_187_3856_3870(_info) == InternalDiagnosticSeverity.Void);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(187, 3736, 3921);

                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_187_3779_3793(Microsoft.CodeAnalysis.DiagnosticInfo
                    this_param)
                    {
                        var return_v = this_param.Severity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 3779, 3793);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_187_3856_3870(Microsoft.CodeAnalysis.DiagnosticInfo
                    this_param)
                    {
                        var return_v = this_param.Severity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 3856, 3870);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(187, 3686, 3932);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(187, 3686, 3932);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(187, 3944, 4087);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 4002, 4076);

                return f_187_4009_4075(f_187_4022_4049(f_187_4022_4035(this)), f_187_4051_4074(f_187_4051_4060(this)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(187, 3944, 4087);

                Microsoft.CodeAnalysis.Location
                f_187_4022_4035(Microsoft.CodeAnalysis.DiagnosticWithInfo
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 4022, 4035);
                    return return_v;
                }


                int
                f_187_4022_4049(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(187, 4022, 4049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_187_4051_4060(Microsoft.CodeAnalysis.DiagnosticWithInfo
                this_param)
                {
                    var return_v = this_param.Info;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 4051, 4060);
                    return return_v;
                }


                int
                f_187_4051_4074(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(187, 4051, 4074);
                    return return_v;
                }


                int
                f_187_4009_4075(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(187, 4009, 4075);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(187, 3944, 4087);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(187, 3944, 4087);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(187, 4099, 4208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 4164, 4197);

                return f_187_4171_4196(this, obj as Diagnostic);
                DynAbs.Tracing.TraceSender.TraceExitMethod(187, 4099, 4208);

                bool
                f_187_4171_4196(Microsoft.CodeAnalysis.DiagnosticWithInfo
                this_param, object?
                obj)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.Diagnostic?)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(187, 4171, 4196);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(187, 4099, 4208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(187, 4099, 4208);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(Diagnostic? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(187, 4220, 4790);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 4289, 4380) || true) && (f_187_4293_4319(this, obj))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(187, 4289, 4380);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 4353, 4365);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(187, 4289, 4380);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 4396, 4434);

                var
                other = obj as DiagnosticWithInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 4450, 4566) || true) && (other == null || (DynAbs.Tracing.TraceSender.Expression_False(187, 4454, 4504) || f_187_4471_4485(this) != f_187_4489_4504(other)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(187, 4450, 4566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 4538, 4551);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(187, 4450, 4566);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 4582, 4779);

                return
                f_187_4606_4643(f_187_4606_4619(this), other._location) && (DynAbs.Tracing.TraceSender.Expression_True(187, 4606, 4692) && f_187_4664_4692(f_187_4664_4673(this), f_187_4681_4691(other))) && (DynAbs.Tracing.TraceSender.Expression_True(187, 4606, 4778) && f_187_4713_4778(f_187_4713_4737(this), f_187_4752_4777(other)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(187, 4220, 4790);

                bool
                f_187_4293_4319(Microsoft.CodeAnalysis.DiagnosticWithInfo
                objA, Microsoft.CodeAnalysis.Diagnostic?
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(187, 4293, 4319);
                    return return_v;
                }


                System.Type
                f_187_4471_4485(Microsoft.CodeAnalysis.DiagnosticWithInfo
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(187, 4471, 4485);
                    return return_v;
                }


                System.Type
                f_187_4489_4504(Microsoft.CodeAnalysis.DiagnosticWithInfo
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(187, 4489, 4504);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_187_4606_4619(Microsoft.CodeAnalysis.DiagnosticWithInfo
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 4606, 4619);
                    return return_v;
                }


                bool
                f_187_4606_4643(Microsoft.CodeAnalysis.Location
                this_param, Microsoft.CodeAnalysis.Location
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(187, 4606, 4643);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_187_4664_4673(Microsoft.CodeAnalysis.DiagnosticWithInfo
                this_param)
                {
                    var return_v = this_param.Info;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 4664, 4673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_187_4681_4691(Microsoft.CodeAnalysis.DiagnosticWithInfo
                this_param)
                {
                    var return_v = this_param.Info;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 4681, 4691);
                    return return_v;
                }


                bool
                f_187_4664_4692(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(187, 4664, 4692);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                f_187_4713_4737(Microsoft.CodeAnalysis.DiagnosticWithInfo
                this_param)
                {
                    var return_v = this_param.AdditionalLocations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 4713, 4737);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                f_187_4752_4777(Microsoft.CodeAnalysis.DiagnosticWithInfo
                this_param)
                {
                    var return_v = this_param.AdditionalLocations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 4752, 4777);
                    return return_v;
                }


                bool
                f_187_4713_4778(System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                first, System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                second)
                {
                    var return_v = first.SequenceEqual<Microsoft.CodeAnalysis.Location>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Location>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(187, 4713, 4778);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(187, 4220, 4790);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(187, 4220, 4790);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(187, 4802, 5603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 4862, 5592);

                switch (f_187_4870_4884(_info))
                {

                    case InternalDiagnosticSeverity.Unknown:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(187, 4862, 5592);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 5191, 5242);

                        return "Unresolved diagnostic at " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_187_5228_5241(this)).ToString(), 187, 5228, 5241);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(187, 4862, 5592);

                    case InternalDiagnosticSeverity.Void:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(187, 4862, 5592);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 5464, 5509);

                        return "Void diagnostic at " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_187_5495_5508(this)).ToString(), 187, 5495, 5508);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(187, 4862, 5592);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(187, 4862, 5592);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 5559, 5577);

                        return f_187_5566_5576(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(187, 4862, 5592);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(187, 4802, 5603);

                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_187_4870_4884(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 4870, 4884);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_187_5228_5241(Microsoft.CodeAnalysis.DiagnosticWithInfo
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 5228, 5241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_187_5495_5508(Microsoft.CodeAnalysis.DiagnosticWithInfo
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 5495, 5508);
                    return return_v;
                }


                string
                f_187_5566_5576(Microsoft.CodeAnalysis.DiagnosticWithInfo
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(187, 5566, 5576);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(187, 4802, 5603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(187, 4802, 5603);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Diagnostic WithLocation(Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(187, 5615, 6010);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 5700, 5819) || true) && (location == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(187, 5700, 5819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 5754, 5804);

                    throw f_187_5760_5803(nameof(location));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(187, 5700, 5819);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 5835, 5971) || true) && (location != _location)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(187, 5835, 5971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 5894, 5956);

                    return f_187_5901_5955(_info, location, _isSuppressed);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(187, 5835, 5971);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 5987, 5999);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(187, 5615, 6010);

                System.ArgumentNullException
                f_187_5760_5803(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(187, 5760, 5803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticWithInfo
                f_187_5901_5955(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location, bool
                isSuppressed)
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticWithInfo(info, location, isSuppressed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(187, 5901, 5955);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(187, 5615, 6010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(187, 5615, 6010);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Diagnostic WithSeverity(DiagnosticSeverity severity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(187, 6022, 6335);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 6117, 6296) || true) && (f_187_6121_6134(this) != severity)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(187, 6117, 6296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 6180, 6281);

                    return f_187_6187_6280(f_187_6210_6253(f_187_6210_6219(this), severity), _location, _isSuppressed);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(187, 6117, 6296);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 6312, 6324);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(187, 6022, 6335);

                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_187_6121_6134(Microsoft.CodeAnalysis.DiagnosticWithInfo
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 6121, 6134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_187_6210_6219(Microsoft.CodeAnalysis.DiagnosticWithInfo
                this_param)
                {
                    var return_v = this_param.Info;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 6210, 6219);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_187_6210_6253(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param, Microsoft.CodeAnalysis.DiagnosticSeverity
                severity)
                {
                    var return_v = this_param.GetInstanceWithSeverity(severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(187, 6210, 6253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticWithInfo
                f_187_6187_6280(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location, bool
                isSuppressed)
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticWithInfo(info, location, isSuppressed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(187, 6187, 6280);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(187, 6022, 6335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(187, 6022, 6335);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Diagnostic WithIsSuppressed(bool isSuppressed)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(187, 6347, 6627);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 6436, 6588) || true) && (f_187_6440_6457(this) != isSuppressed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(187, 6436, 6588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 6507, 6573);

                    return f_187_6514_6572(f_187_6537_6546(this), _location, isSuppressed);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(187, 6436, 6588);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 6604, 6616);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(187, 6347, 6627);

                bool
                f_187_6440_6457(Microsoft.CodeAnalysis.DiagnosticWithInfo
                this_param)
                {
                    var return_v = this_param.IsSuppressed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 6440, 6457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_187_6537_6546(Microsoft.CodeAnalysis.DiagnosticWithInfo
                this_param)
                {
                    var return_v = this_param.Info;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 6537, 6546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticWithInfo
                f_187_6514_6572(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location, bool
                isSuppressed)
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticWithInfo(info, location, isSuppressed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(187, 6514, 6572);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(187, 6347, 6627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(187, 6347, 6627);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool IsNotConfigurable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(187, 6639, 6761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(187, 6713, 6750);

                return f_187_6720_6749(f_187_6720_6729(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(187, 6639, 6761);

                Microsoft.CodeAnalysis.DiagnosticInfo
                f_187_6720_6729(Microsoft.CodeAnalysis.DiagnosticWithInfo
                this_param)
                {
                    var return_v = this_param.Info;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(187, 6720, 6729);
                    return return_v;
                }


                bool
                f_187_6720_6749(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.IsNotConfigurable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(187, 6720, 6749);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(187, 6639, 6761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(187, 6639, 6761);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DiagnosticWithInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(187, 518, 6768);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(187, 518, 6768);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(187, 518, 6768);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(187, 518, 6768);

        static int
        f_187_895_927(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(187, 895, 927);
            return 0;
        }


        static int
        f_187_942_978(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(187, 942, 978);
            return 0;
        }

    }
}
