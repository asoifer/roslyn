// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public abstract partial class Diagnostic
    {
        private sealed class DiagnosticWithProgrammaticSuppression : Diagnostic
        {
            private readonly Diagnostic _originalUnsuppressedDiagnostic;

            private readonly ProgrammaticSuppressionInfo _programmaticSuppressionInfo;

            public DiagnosticWithProgrammaticSuppression(
                            Diagnostic originalUnsuppressedDiagnostic,
                            ProgrammaticSuppressionInfo programmaticSuppressionInfo)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(181, 750, 1383);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 614, 645);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 705, 733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 962, 1027);

                    f_181_962_1026(f_181_981_1025_M(!originalUnsuppressedDiagnostic.IsSuppressed));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 1045, 1132);

                    f_181_1045_1131(f_181_1064_1122(originalUnsuppressedDiagnostic) == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 1150, 1206);

                    f_181_1150_1205(programmaticSuppressionInfo != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 1226, 1291);

                    _originalUnsuppressedDiagnostic = originalUnsuppressedDiagnostic;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 1309, 1368);

                    _programmaticSuppressionInfo = programmaticSuppressionInfo;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(181, 750, 1383);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(181, 750, 1383);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(181, 750, 1383);
                }
            }

            public override DiagnosticDescriptor Descriptor
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(181, 1479, 1537);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 1485, 1535);

                        return f_181_1492_1534(_originalUnsuppressedDiagnostic);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(181, 1479, 1537);

                        Microsoft.CodeAnalysis.DiagnosticDescriptor
                        f_181_1492_1534(Microsoft.CodeAnalysis.Diagnostic
                        this_param)
                        {
                            var return_v = this_param.Descriptor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(181, 1492, 1534);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(181, 1399, 1552);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(181, 1399, 1552);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(181, 1626, 1655);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 1632, 1653);

                        return f_181_1639_1652(f_181_1639_1649());
                        DynAbs.Tracing.TraceSender.TraceExitMethod(181, 1626, 1655);

                        Microsoft.CodeAnalysis.DiagnosticDescriptor
                        f_181_1639_1649()
                        {
                            var return_v = Descriptor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(181, 1639, 1649);
                            return return_v;
                        }


                        string
                        f_181_1639_1652(Microsoft.CodeAnalysis.DiagnosticDescriptor
                        this_param)
                        {
                            var return_v = this_param.Id;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(181, 1639, 1652);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(181, 1568, 1670);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(181, 1568, 1670);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override string GetMessage(IFormatProvider? formatProvider = null)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(181, 1777, 1838);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 1780, 1838);
                    return f_181_1780_1838(_originalUnsuppressedDiagnostic, formatProvider); DynAbs.Tracing.TraceSender.TraceExitMethod(181, 1777, 1838);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(181, 1777, 1838);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(181, 1777, 1838);
                }
                throw new System.Exception("Slicer error: unreachable code");

                string
                f_181_1780_1838(Microsoft.CodeAnalysis.Diagnostic
                this_param, System.IFormatProvider?
                formatProvider)
                {
                    var return_v = this_param.GetMessage(formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(181, 1780, 1838);
                    return return_v;
                }

            }

            internal override IReadOnlyList<object?> Arguments
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(181, 1938, 1995);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 1944, 1993);

                        return f_181_1951_1992(_originalUnsuppressedDiagnostic);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(181, 1938, 1995);

                        System.Collections.Generic.IReadOnlyList<object?>
                        f_181_1951_1992(Microsoft.CodeAnalysis.Diagnostic
                        this_param)
                        {
                            var return_v = this_param.Arguments;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(181, 1951, 1992);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(181, 1855, 2010);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(181, 1855, 2010);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override DiagnosticSeverity Severity
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(181, 2102, 2158);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 2108, 2156);

                        return f_181_2115_2155(_originalUnsuppressedDiagnostic);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(181, 2102, 2158);

                        Microsoft.CodeAnalysis.DiagnosticSeverity
                        f_181_2115_2155(Microsoft.CodeAnalysis.Diagnostic
                        this_param)
                        {
                            var return_v = this_param.Severity;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(181, 2115, 2155);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(181, 2026, 2173);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(181, 2026, 2173);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(181, 2255, 2275);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 2261, 2273);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(181, 2255, 2275);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(181, 2189, 2290);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(181, 2189, 2290);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override ProgrammaticSuppressionInfo ProgrammaticSuppressionInfo
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(181, 2412, 2456);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 2418, 2454);

                        return _programmaticSuppressionInfo;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(181, 2412, 2456);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(181, 2306, 2471);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(181, 2306, 2471);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int WarningLevel
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(181, 2552, 2612);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 2558, 2610);

                        return f_181_2565_2609(_originalUnsuppressedDiagnostic);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(181, 2552, 2612);

                        int
                        f_181_2565_2609(Microsoft.CodeAnalysis.Diagnostic
                        this_param)
                        {
                            var return_v = this_param.WarningLevel;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(181, 2565, 2609);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(181, 2487, 2627);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(181, 2487, 2627);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override Location Location
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(181, 2709, 2765);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 2715, 2763);

                        return f_181_2722_2762(_originalUnsuppressedDiagnostic);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(181, 2709, 2765);

                        Microsoft.CodeAnalysis.Location
                        f_181_2722_2762(Microsoft.CodeAnalysis.Diagnostic
                        this_param)
                        {
                            var return_v = this_param.Location;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(181, 2722, 2762);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(181, 2643, 2780);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(181, 2643, 2780);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(181, 2888, 2955);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 2894, 2953);

                        return f_181_2901_2952(_originalUnsuppressedDiagnostic);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(181, 2888, 2955);

                        System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                        f_181_2901_2952(Microsoft.CodeAnalysis.Diagnostic
                        this_param)
                        {
                            var return_v = this_param.AdditionalLocations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(181, 2901, 2952);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(181, 2796, 2970);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(181, 2796, 2970);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ImmutableDictionary<string, string?> Properties
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(181, 3082, 3140);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 3088, 3138);

                        return f_181_3095_3137(_originalUnsuppressedDiagnostic);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(181, 3082, 3140);

                        System.Collections.Immutable.ImmutableDictionary<string, string?>
                        f_181_3095_3137(Microsoft.CodeAnalysis.Diagnostic
                        this_param)
                        {
                            var return_v = this_param.Properties;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(181, 3095, 3137);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(181, 2986, 3155);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(181, 2986, 3155);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool Equals(Diagnostic? obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(181, 3171, 3755);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 3248, 3351) || true) && (f_181_3252_3278(this, obj))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(181, 3248, 3351);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 3320, 3332);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(181, 3248, 3351);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 3371, 3428);

                    var
                    other = obj as DiagnosticWithProgrammaticSuppression
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 3446, 3537) || true) && (other == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(181, 3446, 3537);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 3505, 3518);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(181, 3446, 3537);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 3557, 3740);

                    return f_181_3564_3642(_originalUnsuppressedDiagnostic, other._originalUnsuppressedDiagnostic) && (DynAbs.Tracing.TraceSender.Expression_True(181, 3564, 3739) && f_181_3667_3739(_programmaticSuppressionInfo, other._programmaticSuppressionInfo));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(181, 3171, 3755);

                    bool
                    f_181_3252_3278(Microsoft.CodeAnalysis.Diagnostic.DiagnosticWithProgrammaticSuppression
                    objA, Microsoft.CodeAnalysis.Diagnostic?
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object?)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(181, 3252, 3278);
                        return return_v;
                    }


                    bool
                    f_181_3564_3642(Microsoft.CodeAnalysis.Diagnostic
                    objA, Microsoft.CodeAnalysis.Diagnostic
                    objB)
                    {
                        var return_v = Equals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(181, 3564, 3642);
                        return return_v;
                    }


                    bool
                    f_181_3667_3739(Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo
                    objA, Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo
                    objB)
                    {
                        var return_v = Equals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(181, 3667, 3739);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(181, 3171, 3755);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(181, 3171, 3755);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(object? obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(181, 3771, 3897);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 3844, 3882);

                    return f_181_3851_3881(this, obj as Diagnostic);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(181, 3771, 3897);

                    bool
                    f_181_3851_3881(Microsoft.CodeAnalysis.Diagnostic.DiagnosticWithProgrammaticSuppression
                    this_param, object?
                    obj)
                    {
                        var return_v = this_param.Equals((Microsoft.CodeAnalysis.Diagnostic?)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(181, 3851, 3881);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(181, 3771, 3897);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(181, 3771, 3897);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(181, 3913, 4105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 3979, 4090);

                    return f_181_3986_4089(f_181_3999_4044(_originalUnsuppressedDiagnostic), f_181_4046_4088(_programmaticSuppressionInfo));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(181, 3913, 4105);

                    int
                    f_181_3999_4044(Microsoft.CodeAnalysis.Diagnostic
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(181, 3999, 4044);
                        return return_v;
                    }


                    int
                    f_181_4046_4088(Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(181, 4046, 4088);
                        return return_v;
                    }


                    int
                    f_181_3986_4089(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(181, 3986, 4089);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(181, 3913, 4105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(181, 3913, 4105);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override Diagnostic WithLocation(Location location)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(181, 4121, 4637);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 4214, 4345) || true) && (location == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(181, 4214, 4345);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 4276, 4326);

                        throw f_181_4282_4325(nameof(location));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(181, 4214, 4345);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 4365, 4590) || true) && (f_181_4369_4382(this) != location)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(181, 4365, 4590);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 4436, 4571);

                        return f_181_4443_4570(f_181_4485_4539(_originalUnsuppressedDiagnostic, location), _programmaticSuppressionInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(181, 4365, 4590);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 4610, 4622);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(181, 4121, 4637);

                    System.ArgumentNullException
                    f_181_4282_4325(string
                    paramName)
                    {
                        var return_v = new System.ArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(181, 4282, 4325);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_181_4369_4382(Microsoft.CodeAnalysis.Diagnostic.DiagnosticWithProgrammaticSuppression
                    this_param)
                    {
                        var return_v = this_param.Location;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(181, 4369, 4382);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostic
                    f_181_4485_4539(Microsoft.CodeAnalysis.Diagnostic
                    this_param, Microsoft.CodeAnalysis.Location
                    location)
                    {
                        var return_v = this_param.WithLocation(location);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(181, 4485, 4539);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostic.DiagnosticWithProgrammaticSuppression
                    f_181_4443_4570(Microsoft.CodeAnalysis.Diagnostic
                    originalUnsuppressedDiagnostic, Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo
                    programmaticSuppressionInfo)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Diagnostic.DiagnosticWithProgrammaticSuppression(originalUnsuppressedDiagnostic, programmaticSuppressionInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(181, 4443, 4570);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(181, 4121, 4637);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(181, 4121, 4637);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override Diagnostic WithSeverity(DiagnosticSeverity severity)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(181, 4653, 5028);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 4756, 4981) || true) && (f_181_4760_4773(this) != severity)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(181, 4756, 4981);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 4827, 4962);

                        return f_181_4834_4961(f_181_4876_4930(_originalUnsuppressedDiagnostic, severity), _programmaticSuppressionInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(181, 4756, 4981);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 5001, 5013);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(181, 4653, 5028);

                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_181_4760_4773(Microsoft.CodeAnalysis.Diagnostic.DiagnosticWithProgrammaticSuppression
                    this_param)
                    {
                        var return_v = this_param.Severity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(181, 4760, 4773);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostic
                    f_181_4876_4930(Microsoft.CodeAnalysis.Diagnostic
                    this_param, Microsoft.CodeAnalysis.DiagnosticSeverity
                    severity)
                    {
                        var return_v = this_param.WithSeverity(severity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(181, 4876, 4930);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostic.DiagnosticWithProgrammaticSuppression
                    f_181_4834_4961(Microsoft.CodeAnalysis.Diagnostic
                    originalUnsuppressedDiagnostic, Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo
                    programmaticSuppressionInfo)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Diagnostic.DiagnosticWithProgrammaticSuppression(originalUnsuppressedDiagnostic, programmaticSuppressionInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(181, 4834, 4961);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(181, 4653, 5028);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(181, 4653, 5028);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override Diagnostic WithIsSuppressed(bool isSuppressed)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(181, 5044, 5402);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 5227, 5355) || true) && (!isSuppressed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(181, 5227, 5355);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 5286, 5336);

                        throw f_181_5292_5335(nameof(isSuppressed));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(181, 5227, 5355);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(181, 5375, 5387);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(181, 5044, 5402);

                    System.ArgumentException
                    f_181_5292_5335(string
                    message)
                    {
                        var return_v = new System.ArgumentException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(181, 5292, 5335);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(181, 5044, 5402);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(181, 5044, 5402);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static DiagnosticWithProgrammaticSuppression()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(181, 490, 5413);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(181, 490, 5413);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(181, 490, 5413);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(181, 490, 5413);

            bool
            f_181_981_1025_M(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(181, 981, 1025);
                return return_v;
            }


            static int
            f_181_962_1026(bool
            b)
            {
                RoslynDebug.Assert(b);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(181, 962, 1026);
                return 0;
            }


            static Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo?
            f_181_1064_1122(Microsoft.CodeAnalysis.Diagnostic
            this_param)
            {
                var return_v = this_param.ProgrammaticSuppressionInfo;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(181, 1064, 1122);
                return return_v;
            }


            static int
            f_181_1045_1131(bool
            b)
            {
                RoslynDebug.Assert(b);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(181, 1045, 1131);
                return 0;
            }


            static int
            f_181_1150_1205(bool
            b)
            {
                RoslynDebug.Assert(b);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(181, 1150, 1205);
                return 0;
            }

        }
    }
}
