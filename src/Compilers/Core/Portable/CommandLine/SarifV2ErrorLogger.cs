// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal sealed class SarifV2ErrorLogger : SarifErrorLogger, IDisposable
    {
        private readonly DiagnosticDescriptorSet _descriptors;

        private readonly string _toolName;

        private readonly string _toolFileVersion;

        private readonly Version _toolAssemblyVersion;

        public SarifV2ErrorLogger(Stream stream, string toolName, string toolFileVersion, Version toolAssemblyVersion, CultureInfo culture)
        : base(f_139_1189_1195_C(stream), culture)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(139, 1037, 1755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 859, 871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 908, 917);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 952, 968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 1004, 1024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 1230, 1275);

                _descriptors = f_139_1245_1274();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 1291, 1312);

                _toolName = toolName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 1326, 1361);

                _toolFileVersion = toolFileVersion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 1375, 1418);

                _toolAssemblyVersion = toolAssemblyVersion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 1434, 1461);

                f_139_1434_1460(f_139_1434_1441());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 1483, 1551);

                f_139_1483_1550(f_139_1483_1490(), "$schema", "http://json.schemastore.org/sarif-2.1.0");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 1565, 1599);

                f_139_1565_1598(f_139_1565_1572(), "version", "2.1.0");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 1613, 1645);

                f_139_1613_1644(f_139_1613_1620(), "runs");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 1659, 1686);

                f_139_1659_1685(f_139_1659_1666());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 1709, 1744);

                f_139_1709_1743(f_139_1709_1716(), "results");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(139, 1037, 1755);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(139, 1037, 1755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(139, 1037, 1755);
            }
        }

        protected override string PrimaryLocationPropertyName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(139, 1821, 1842);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 1824, 1842);
                    return "physicalLocation"; DynAbs.Tracing.TraceSender.TraceExitMethod(139, 1821, 1842);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(139, 1821, 1842);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(139, 1821, 1842);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void LogDiagnostic(Diagnostic diagnostic, SuppressionInfo? suppressionInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(139, 1855, 3832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 1971, 1998);

                f_139_1971_1997(f_139_1971_1978());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 2022, 2061);

                f_139_2022_2060(f_139_2022_2029(), "ruleId", f_139_2046_2059(diagnostic));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 2075, 2131);

                int
                ruleIndex = f_139_2091_2130(_descriptors, f_139_2108_2129(diagnostic))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 2145, 2183);

                f_139_2145_2182(f_139_2145_2152(), "ruleIndex", ruleIndex);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 2199, 2253);

                f_139_2199_2252(f_139_2199_2206(), "level", f_139_2222_2251(f_139_2231_2250(diagnostic)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 2269, 2319);

                string?
                message = f_139_2287_2318(diagnostic, f_139_2309_2317())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 2333, 2550) || true) && (!f_139_2338_2373(message))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(139, 2333, 2550);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 2407, 2443);

                    f_139_2407_2442(f_139_2407_2414(), "message");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 2461, 2492);

                    f_139_2461_2491(f_139_2461_2468(), "text", message);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 2510, 2535);

                    f_139_2510_2534(f_139_2510_2517());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(139, 2333, 2550);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 2566, 3636) || true) && (f_139_2570_2593(diagnostic))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(139, 2566, 3636);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 2627, 2667);

                    f_139_2627_2666(f_139_2627_2634(), "suppressions");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 2685, 2712);

                    f_139_2685_2711(f_139_2685_2692());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 2745, 2779);

                    f_139_2745_2778(f_139_2745_2752(), "kind", "inSource");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 2970, 2999);

                    string?
                    justification = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 3019, 3351) || true) && (suppressionInfo != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(139, 3019, 3351);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 3088, 3126);

                        var
                        temp1 = f_139_3100_3125(suppressionInfo)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 3148, 3332) || true) && (temp1 != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(139, 3148, 3332);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 3215, 3309);

                            justification = f_139_3231_3308(temp1, "Justification", SpecialType.System_String);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(139, 3148, 3332);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(139, 3019, 3351);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 3387, 3519) || true) && (justification != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(139, 3387, 3519);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 3454, 3500);

                        f_139_3454_3499(f_139_3454_3461(), "justification", justification);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(139, 3387, 3519);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 3539, 3564);

                    f_139_3539_3563(f_139_3539_3546());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 3597, 3621);

                    f_139_3597_3620(f_139_3597_3604());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(139, 2566, 3636);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 3652, 3720);

                f_139_3652_3719(this, f_139_3667_3686(diagnostic), f_139_3688_3718(diagnostic));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 3736, 3770);

                f_139_3736_3769(this, diagnostic);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 3786, 3811);

                f_139_3786_3810(f_139_3786_3793());
                DynAbs.Tracing.TraceSender.TraceExitMethod(139, 1855, 3832);

                Roslyn.Utilities.JsonWriter
                f_139_1971_1978()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 1971, 1978);
                    return return_v;
                }


                int
                f_139_1971_1997(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectStart();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 1971, 1997);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_2022_2029()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 2022, 2029);
                    return return_v;
                }


                string
                f_139_2046_2059(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 2046, 2059);
                    return return_v;
                }


                int
                f_139_2022_2060(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 2022, 2060);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticDescriptor
                f_139_2108_2129(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Descriptor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 2108, 2129);
                    return return_v;
                }


                int
                f_139_2091_2130(Microsoft.CodeAnalysis.SarifV2ErrorLogger.DiagnosticDescriptorSet
                this_param, Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor)
                {
                    var return_v = this_param.Add(descriptor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 2091, 2130);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_139_2145_2152()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 2145, 2152);
                    return return_v;
                }


                int
                f_139_2145_2182(Roslyn.Utilities.JsonWriter
                this_param, string
                key, int
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 2145, 2182);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_2199_2206()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 2199, 2206);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_139_2231_2250(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 2231, 2250);
                    return return_v;
                }


                string
                f_139_2222_2251(Microsoft.CodeAnalysis.DiagnosticSeverity
                severity)
                {
                    var return_v = GetLevel(severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 2222, 2251);
                    return return_v;
                }


                int
                f_139_2199_2252(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 2199, 2252);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_139_2309_2317()
                {
                    var return_v = _culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 2309, 2317);
                    return return_v;
                }


                string
                f_139_2287_2318(Microsoft.CodeAnalysis.Diagnostic
                this_param, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = this_param.GetMessage((System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 2287, 2318);
                    return return_v;
                }


                bool
                f_139_2338_2373(string
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 2338, 2373);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_139_2407_2414()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 2407, 2414);
                    return return_v;
                }


                int
                f_139_2407_2442(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteObjectStart(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 2407, 2442);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_2461_2468()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 2461, 2468);
                    return return_v;
                }


                int
                f_139_2461_2491(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 2461, 2491);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_2510_2517()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 2510, 2517);
                    return return_v;
                }


                int
                f_139_2510_2534(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 2510, 2534);
                    return 0;
                }


                bool
                f_139_2570_2593(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.IsSuppressed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 2570, 2593);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_139_2627_2634()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 2627, 2634);
                    return return_v;
                }


                int
                f_139_2627_2666(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteArrayStart(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 2627, 2666);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_2685_2692()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 2685, 2692);
                    return return_v;
                }


                int
                f_139_2685_2711(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectStart();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 2685, 2711);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_2745_2752()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 2745, 2752);
                    return return_v;
                }


                int
                f_139_2745_2778(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 2745, 2778);
                    return 0;
                }


                Microsoft.CodeAnalysis.AttributeData?
                f_139_3100_3125(Microsoft.CodeAnalysis.Diagnostics.SuppressionInfo
                this_param)
                {
                    var return_v = this_param.Attribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 3100, 3125);
                    return return_v;
                }


                string?
                f_139_3231_3308(Microsoft.CodeAnalysis.AttributeData
                this_param, string
                name, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.DecodeNamedArgument<string>(name, specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 3231, 3308);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_139_3454_3461()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 3454, 3461);
                    return return_v;
                }


                int
                f_139_3454_3499(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 3454, 3499);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_3539_3546()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 3539, 3546);
                    return return_v;
                }


                int
                f_139_3539_3563(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 3539, 3563);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_3597_3604()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 3597, 3604);
                    return return_v;
                }


                int
                f_139_3597_3620(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteArrayEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 3597, 3620);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_139_3667_3686(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 3667, 3686);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                f_139_3688_3718(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.AdditionalLocations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 3688, 3718);
                    return return_v;
                }


                int
                f_139_3652_3719(Microsoft.CodeAnalysis.SarifV2ErrorLogger
                this_param, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                additionalLocations)
                {
                    this_param.WriteLocations(location, additionalLocations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 3652, 3719);
                    return 0;
                }


                int
                f_139_3736_3769(Microsoft.CodeAnalysis.SarifV2ErrorLogger
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diagnostic)
                {
                    this_param.WriteResultProperties(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 3736, 3769);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_3786_3793()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 3786, 3793);
                    return return_v;
                }


                int
                f_139_3786_3810(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 3786, 3810);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(139, 1855, 3832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(139, 1855, 3832);
            }
        }

        private void WriteLocations(Location location, IReadOnlyList<Location> additionalLocations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(139, 3844, 5399);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 3960, 4352) || true) && (f_139_3964_3981(location))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(139, 3960, 4352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 4015, 4052);

                    f_139_4015_4051(f_139_4015_4022(), "locations");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 4070, 4097);

                    f_139_4070_4096(f_139_4070_4077());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 4127, 4173);

                    f_139_4127_4172(f_139_4127_4134(), f_139_4144_4171());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 4193, 4225);

                    f_139_4193_4224(this, location);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 4245, 4270);

                    f_139_4245_4269(f_139_4245_4252());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 4300, 4324);

                    f_139_4300_4323(f_139_4300_4307());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(139, 3960, 4352);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 4587, 5388) || true) && (additionalLocations != null && (DynAbs.Tracing.TraceSender.Expression_True(139, 4591, 4668) && f_139_4639_4664(additionalLocations) > 0) && (DynAbs.Tracing.TraceSender.Expression_True(139, 4591, 4729) && f_139_4689_4729(additionalLocations, l => HasPath(l))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(139, 4587, 5388);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 4763, 4807);

                    f_139_4763_4806(f_139_4763_4770(), "relatedLocations");
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 4827, 5309);
                        foreach (var additionalLocation in f_139_4862_4881_I(additionalLocations))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(139, 4827, 5309);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 4923, 5290) || true) && (f_139_4927_4954(additionalLocation))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(139, 4923, 5290);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 5004, 5031);

                                f_139_5004_5030(f_139_5004_5011());
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 5082, 5119);

                                f_139_5082_5118(f_139_5082_5089(), "physicalLocation");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 5147, 5189);

                                f_139_5147_5188(this, additionalLocation);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 5217, 5242);

                                f_139_5217_5241(f_139_5217_5224());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(139, 4923, 5290);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(139, 4827, 5309);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(139, 1, 483);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(139, 1, 483);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 5329, 5353);

                    f_139_5329_5352(f_139_5329_5336());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(139, 4587, 5388);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(139, 3844, 5399);

                bool
                f_139_3964_3981(Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = HasPath(location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 3964, 3981);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_139_4015_4022()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 4015, 4022);
                    return return_v;
                }


                int
                f_139_4015_4051(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteArrayStart(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 4015, 4051);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_4070_4077()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 4070, 4077);
                    return return_v;
                }


                int
                f_139_4070_4096(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectStart();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 4070, 4096);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_4127_4134()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 4127, 4134);
                    return return_v;
                }


                string
                f_139_4144_4171()
                {
                    var return_v = PrimaryLocationPropertyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 4144, 4171);
                    return return_v;
                }


                int
                f_139_4127_4172(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 4127, 4172);
                    return 0;
                }


                int
                f_139_4193_4224(Microsoft.CodeAnalysis.SarifV2ErrorLogger
                this_param, Microsoft.CodeAnalysis.Location
                diagnosticLocation)
                {
                    this_param.WritePhysicalLocation(diagnosticLocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 4193, 4224);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_4245_4252()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 4245, 4252);
                    return return_v;
                }


                int
                f_139_4245_4269(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 4245, 4269);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_4300_4307()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 4300, 4307);
                    return return_v;
                }


                int
                f_139_4300_4323(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteArrayEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 4300, 4323);
                    return 0;
                }


                int
                f_139_4639_4664(System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 4639, 4664);
                    return return_v;
                }


                bool
                f_139_4689_4729(System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                source, System.Func<Microsoft.CodeAnalysis.Location, bool>
                predicate)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.Location>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 4689, 4729);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_139_4763_4770()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 4763, 4770);
                    return return_v;
                }


                int
                f_139_4763_4806(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteArrayStart(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 4763, 4806);
                    return 0;
                }


                bool
                f_139_4927_4954(Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = HasPath(location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 4927, 4954);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_139_5004_5011()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 5004, 5011);
                    return return_v;
                }


                int
                f_139_5004_5030(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectStart();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 5004, 5030);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_5082_5089()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 5082, 5089);
                    return return_v;
                }


                int
                f_139_5082_5118(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 5082, 5118);
                    return 0;
                }


                int
                f_139_5147_5188(Microsoft.CodeAnalysis.SarifV2ErrorLogger
                this_param, Microsoft.CodeAnalysis.Location
                diagnosticLocation)
                {
                    this_param.WritePhysicalLocation(diagnosticLocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 5147, 5188);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_5217_5224()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 5217, 5224);
                    return return_v;
                }


                int
                f_139_5217_5241(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 5217, 5241);
                    return 0;
                }


                System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                f_139_4862_4881_I(System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 4862, 4881);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_139_5329_5336()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 5329, 5336);
                    return return_v;
                }


                int
                f_139_5329_5352(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteArrayEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 5329, 5352);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(139, 3844, 5399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(139, 3844, 5399);
            }
        }

        protected override void WritePhysicalLocation(Location diagnosticLocation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(139, 5411, 5952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 5510, 5552);

                f_139_5510_5551(f_139_5523_5550(diagnosticLocation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 5568, 5629);

                FileLinePositionSpan
                span = f_139_5596_5628(diagnosticLocation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 5645, 5672);

                f_139_5645_5671(f_139_5645_5652());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 5708, 5753);

                f_139_5708_5752(f_139_5708_5715(), "artifactLocation");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 5767, 5807);

                f_139_5767_5806(f_139_5767_5774(), "uri", f_139_5788_5805(span.Path));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 5821, 5846);

                f_139_5821_5845(f_139_5821_5828());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 5882, 5900);

                f_139_5882_5899(this, span);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 5916, 5941);

                f_139_5916_5940(f_139_5916_5923());
                DynAbs.Tracing.TraceSender.TraceExitMethod(139, 5411, 5952);

                bool
                f_139_5523_5550(Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = HasPath(location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 5523, 5550);
                    return return_v;
                }


                int
                f_139_5510_5551(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 5510, 5551);
                    return 0;
                }


                Microsoft.CodeAnalysis.FileLinePositionSpan
                f_139_5596_5628(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.GetLineSpan();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 5596, 5628);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_139_5645_5652()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 5645, 5652);
                    return return_v;
                }


                int
                f_139_5645_5671(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectStart();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 5645, 5671);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_5708_5715()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 5708, 5715);
                    return return_v;
                }


                int
                f_139_5708_5752(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteObjectStart(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 5708, 5752);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_5767_5774()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 5767, 5774);
                    return return_v;
                }


                string
                f_139_5788_5805(string
                path)
                {
                    var return_v = GetUri(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 5788, 5805);
                    return return_v;
                }


                int
                f_139_5767_5806(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 5767, 5806);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_5821_5828()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 5821, 5828);
                    return return_v;
                }


                int
                f_139_5821_5845(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 5821, 5845);
                    return 0;
                }


                int
                f_139_5882_5899(Microsoft.CodeAnalysis.SarifV2ErrorLogger
                this_param, Microsoft.CodeAnalysis.FileLinePositionSpan
                span)
                {
                    this_param.WriteRegion(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 5882, 5899);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_5916_5923()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 5916, 5923);
                    return return_v;
                }


                int
                f_139_5916_5940(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 5916, 5940);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(139, 5411, 5952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(139, 5411, 5952);
            }
        }

        public override void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(139, 5964, 6325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 6019, 6043);

                f_139_6019_6042(f_139_6019_6026());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 6069, 6081);

                f_139_6069_6080(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 6097, 6143);

                f_139_6097_6142(f_139_6097_6104(), "columnKind", "utf16CodeUnits");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 6159, 6184);

                f_139_6159_6183(f_139_6159_6166());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 6205, 6229);

                f_139_6205_6228(f_139_6205_6212());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 6252, 6277);

                f_139_6252_6276(f_139_6252_6259());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 6299, 6314);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(), 139, 6299, 6313);
                DynAbs.Tracing.TraceSender.TraceExitMethod(139, 5964, 6325);

                Roslyn.Utilities.JsonWriter
                f_139_6019_6026()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 6019, 6026);
                    return return_v;
                }


                int
                f_139_6019_6042(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteArrayEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 6019, 6042);
                    return 0;
                }


                int
                f_139_6069_6080(Microsoft.CodeAnalysis.SarifV2ErrorLogger
                this_param)
                {
                    this_param.WriteTool();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 6069, 6080);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_6097_6104()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 6097, 6104);
                    return return_v;
                }


                int
                f_139_6097_6142(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 6097, 6142);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_6159_6166()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 6159, 6166);
                    return return_v;
                }


                int
                f_139_6159_6183(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 6159, 6183);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_6205_6212()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 6205, 6212);
                    return return_v;
                }


                int
                f_139_6205_6228(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteArrayEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 6205, 6228);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_6252_6259()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 6252, 6259);
                    return return_v;
                }


                int
                f_139_6252_6276(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 6252, 6276);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(139, 5964, 6325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(139, 5964, 6325);
            }
        }

        private void WriteTool()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(139, 6337, 6944);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 6386, 6419);

                f_139_6386_6418(f_139_6386_6393(), "tool");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 6433, 6468);

                f_139_6433_6467(f_139_6433_6440(), "driver");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 6482, 6515);

                f_139_6482_6514(f_139_6482_6489(), "name", _toolName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 6529, 6572);

                f_139_6529_6571(f_139_6529_6536(), "version", _toolFileVersion);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 6586, 6658);

                f_139_6586_6657(f_139_6586_6593(), "dottedQuadFileVersion", f_139_6625_6656(_toolAssemblyVersion));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 6672, 6751);

                f_139_6672_6750(f_139_6672_6679(), "semanticVersion", f_139_6705_6749(_toolAssemblyVersion, fieldCount: 3));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 6765, 6806);

                f_139_6765_6805(f_139_6765_6772(), "language", f_139_6791_6804(f_139_6791_6799()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 6822, 6835);

                f_139_6822_6834(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 6851, 6876);

                f_139_6851_6875(f_139_6851_6858());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 6900, 6925);

                f_139_6900_6924(f_139_6900_6907());
                DynAbs.Tracing.TraceSender.TraceExitMethod(139, 6337, 6944);

                Roslyn.Utilities.JsonWriter
                f_139_6386_6393()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 6386, 6393);
                    return return_v;
                }


                int
                f_139_6386_6418(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteObjectStart(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 6386, 6418);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_6433_6440()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 6433, 6440);
                    return return_v;
                }


                int
                f_139_6433_6467(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteObjectStart(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 6433, 6467);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_6482_6489()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 6482, 6489);
                    return return_v;
                }


                int
                f_139_6482_6514(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 6482, 6514);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_6529_6536()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 6529, 6536);
                    return return_v;
                }


                int
                f_139_6529_6571(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 6529, 6571);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_6586_6593()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 6586, 6593);
                    return return_v;
                }


                string
                f_139_6625_6656(System.Version
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 6625, 6656);
                    return return_v;
                }


                int
                f_139_6586_6657(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 6586, 6657);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_6672_6679()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 6672, 6679);
                    return return_v;
                }


                string
                f_139_6705_6749(System.Version
                this_param, int
                fieldCount)
                {
                    var return_v = this_param.ToString(fieldCount: fieldCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 6705, 6749);
                    return return_v;
                }


                int
                f_139_6672_6750(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 6672, 6750);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_6765_6772()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 6765, 6772);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_139_6791_6799()
                {
                    var return_v = _culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 6791, 6799);
                    return return_v;
                }


                string
                f_139_6791_6804(System.Globalization.CultureInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 6791, 6804);
                    return return_v;
                }


                int
                f_139_6765_6805(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 6765, 6805);
                    return 0;
                }


                int
                f_139_6822_6834(Microsoft.CodeAnalysis.SarifV2ErrorLogger
                this_param)
                {
                    this_param.WriteRules();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 6822, 6834);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_6851_6858()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 6851, 6858);
                    return return_v;
                }


                int
                f_139_6851_6875(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 6851, 6875);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_6900_6907()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 6900, 6907);
                    return return_v;
                }


                int
                f_139_6900_6924(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 6900, 6924);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(139, 6337, 6944);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(139, 6337, 6944);
            }
        }

        private void WriteRules()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(139, 6956, 9488);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 7006, 9477) || true) && (f_139_7010_7028(_descriptors) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(139, 7006, 9477);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 7066, 7099);

                    f_139_7066_7098(f_139_7066_7073(), "rules");
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 7119, 9409);
                        foreach (var pair in f_139_7140_7167_I(f_139_7140_7167(_descriptors)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(139, 7119, 9409);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 7209, 7254);

                            DiagnosticDescriptor
                            descriptor = pair.Value
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 7278, 7305);

                            f_139_7278_7304(f_139_7278_7285());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 7335, 7370);

                            f_139_7335_7369(f_139_7335_7342(), "id", f_139_7355_7368(descriptor));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 7394, 7457);

                            string?
                            shortDescription = f_139_7421_7456(f_139_7421_7437(descriptor), f_139_7447_7455())
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 7479, 7763) || true) && (!f_139_7484_7528(shortDescription))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(139, 7479, 7763);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 7578, 7623);

                                f_139_7578_7622(f_139_7578_7585(), "shortDescription");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 7649, 7689);

                                f_139_7649_7688(f_139_7649_7656(), "text", shortDescription);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 7715, 7740);

                                f_139_7715_7739(f_139_7715_7722());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(139, 7479, 7763);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 7787, 7855);

                            string?
                            fullDescription = f_139_7813_7854(f_139_7813_7835(descriptor), f_139_7845_7853())
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 7877, 8158) || true) && (!f_139_7882_7925(fullDescription))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(139, 7877, 8158);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 7975, 8019);

                                f_139_7975_8018(f_139_7975_7982(), "fullDescription");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 8045, 8084);

                                f_139_8045_8083(f_139_8045_8052(), "text", fullDescription);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 8110, 8135);

                                f_139_8110_8134(f_139_8110_8117());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(139, 7877, 8158);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 8182, 8220);

                            f_139_8182_8219(this, descriptor);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 8244, 8415) || true) && (!f_139_8249_8293(f_139_8270_8292(descriptor)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(139, 8244, 8415);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 8343, 8392);

                                f_139_8343_8391(f_139_8343_8350(), "helpUri", f_139_8368_8390(descriptor));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(139, 8244, 8415);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 8439, 9333) || true) && (!f_139_8444_8485(f_139_8465_8484(descriptor)) || (DynAbs.Tracing.TraceSender.Expression_False(139, 8443, 8516) || f_139_8489_8516(f_139_8489_8510(descriptor))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(139, 8439, 9333);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 8566, 8605);

                                f_139_8566_8604(f_139_8566_8573(), "properties");

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 8633, 8811) || true) && (!f_139_8638_8679(f_139_8659_8678(descriptor)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(139, 8633, 8811);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 8737, 8784);

                                    f_139_8737_8783(f_139_8737_8744(), "category", f_139_8763_8782(descriptor));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(139, 8633, 8811);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 8839, 9243) || true) && (f_139_8843_8870(f_139_8843_8864(descriptor)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(139, 8839, 9243);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 8928, 8960);

                                    f_139_8928_8959(f_139_8928_8935(), "tags");
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 8992, 9152);
                                        foreach (string tag in f_139_9015_9036_I(f_139_9015_9036(descriptor)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(139, 8992, 9152);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 9102, 9121);

                                            f_139_9102_9120(f_139_9102_9109(), tag);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(139, 8992, 9152);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(139, 1, 161);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(139, 1, 161);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 9184, 9208);

                                    f_139_9184_9207(f_139_9184_9191());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(139, 8839, 9243);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 9271, 9296);

                                f_139_9271_9295(f_139_9271_9278());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(139, 8439, 9333);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 9357, 9382);

                            f_139_9357_9381(f_139_9357_9364());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(139, 7119, 9409);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(139, 1, 2291);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(139, 1, 2291);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 9429, 9453);

                    f_139_9429_9452(f_139_9429_9436());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(139, 7006, 9477);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(139, 6956, 9488);

                int
                f_139_7010_7028(Microsoft.CodeAnalysis.SarifV2ErrorLogger.DiagnosticDescriptorSet
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 7010, 7028);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_139_7066_7073()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 7066, 7073);
                    return return_v;
                }


                int
                f_139_7066_7098(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteArrayStart(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 7066, 7098);
                    return 0;
                }


                System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<int, Microsoft.CodeAnalysis.DiagnosticDescriptor>>
                f_139_7140_7167(Microsoft.CodeAnalysis.SarifV2ErrorLogger.DiagnosticDescriptorSet
                this_param)
                {
                    var return_v = this_param.ToSortedList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 7140, 7167);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_139_7278_7285()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 7278, 7285);
                    return return_v;
                }


                int
                f_139_7278_7304(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectStart();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 7278, 7304);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_7335_7342()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 7335, 7342);
                    return return_v;
                }


                string
                f_139_7355_7368(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 7355, 7368);
                    return return_v;
                }


                int
                f_139_7335_7369(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 7335, 7369);
                    return 0;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_139_7421_7437(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Title;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 7421, 7437);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_139_7447_7455()
                {
                    var return_v = _culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 7447, 7455);
                    return return_v;
                }


                string
                f_139_7421_7456(Microsoft.CodeAnalysis.LocalizableString
                this_param, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 7421, 7456);
                    return return_v;
                }


                bool
                f_139_7484_7528(string
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 7484, 7528);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_139_7578_7585()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 7578, 7585);
                    return return_v;
                }


                int
                f_139_7578_7622(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteObjectStart(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 7578, 7622);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_7649_7656()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 7649, 7656);
                    return return_v;
                }


                int
                f_139_7649_7688(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 7649, 7688);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_7715_7722()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 7715, 7722);
                    return return_v;
                }


                int
                f_139_7715_7739(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 7715, 7739);
                    return 0;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_139_7813_7835(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Description;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 7813, 7835);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_139_7845_7853()
                {
                    var return_v = _culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 7845, 7853);
                    return return_v;
                }


                string
                f_139_7813_7854(Microsoft.CodeAnalysis.LocalizableString
                this_param, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 7813, 7854);
                    return return_v;
                }


                bool
                f_139_7882_7925(string
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 7882, 7925);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_139_7975_7982()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 7975, 7982);
                    return return_v;
                }


                int
                f_139_7975_8018(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteObjectStart(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 7975, 8018);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_8045_8052()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 8045, 8052);
                    return return_v;
                }


                int
                f_139_8045_8083(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 8045, 8083);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_8110_8117()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 8110, 8117);
                    return return_v;
                }


                int
                f_139_8110_8134(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 8110, 8134);
                    return 0;
                }


                int
                f_139_8182_8219(Microsoft.CodeAnalysis.SarifV2ErrorLogger
                this_param, Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor)
                {
                    this_param.WriteDefaultConfiguration(descriptor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 8182, 8219);
                    return 0;
                }


                string
                f_139_8270_8292(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.HelpLinkUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 8270, 8292);
                    return return_v;
                }


                bool
                f_139_8249_8293(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 8249, 8293);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_139_8343_8350()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 8343, 8350);
                    return return_v;
                }


                string
                f_139_8368_8390(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.HelpLinkUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 8368, 8390);
                    return return_v;
                }


                int
                f_139_8343_8391(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 8343, 8391);
                    return 0;
                }


                string
                f_139_8465_8484(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Category;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 8465, 8484);
                    return return_v;
                }


                bool
                f_139_8444_8485(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 8444, 8485);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_139_8489_8510(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.CustomTags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 8489, 8510);
                    return return_v;
                }


                bool
                f_139_8489_8516(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.Any<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 8489, 8516);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_139_8566_8573()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 8566, 8573);
                    return return_v;
                }


                int
                f_139_8566_8604(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteObjectStart(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 8566, 8604);
                    return 0;
                }


                string
                f_139_8659_8678(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Category;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 8659, 8678);
                    return return_v;
                }


                bool
                f_139_8638_8679(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 8638, 8679);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_139_8737_8744()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 8737, 8744);
                    return return_v;
                }


                string
                f_139_8763_8782(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Category;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 8763, 8782);
                    return return_v;
                }


                int
                f_139_8737_8783(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 8737, 8783);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_139_8843_8864(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.CustomTags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 8843, 8864);
                    return return_v;
                }


                bool
                f_139_8843_8870(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.Any<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 8843, 8870);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_139_8928_8935()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 8928, 8935);
                    return return_v;
                }


                int
                f_139_8928_8959(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteArrayStart(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 8928, 8959);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_139_9015_9036(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.CustomTags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 9015, 9036);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_139_9102_9109()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 9102, 9109);
                    return return_v;
                }


                int
                f_139_9102_9120(Roslyn.Utilities.JsonWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 9102, 9120);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_139_9015_9036_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 9015, 9036);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_139_9184_9191()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 9184, 9191);
                    return return_v;
                }


                int
                f_139_9184_9207(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteArrayEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 9184, 9207);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_9271_9278()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 9271, 9278);
                    return return_v;
                }


                int
                f_139_9271_9295(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 9271, 9295);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_9357_9364()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 9357, 9364);
                    return return_v;
                }


                int
                f_139_9357_9381(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 9357, 9381);
                    return 0;
                }


                System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<int, Microsoft.CodeAnalysis.DiagnosticDescriptor>>
                f_139_7140_7167_I(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<int, Microsoft.CodeAnalysis.DiagnosticDescriptor>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 7140, 7167);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_139_9429_9436()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 9429, 9436);
                    return return_v;
                }


                int
                f_139_9429_9452(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteArrayEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 9429, 9452);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(139, 6956, 9488);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(139, 6956, 9488);
            }
        }

        private void WriteDefaultConfiguration(DiagnosticDescriptor descriptor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(139, 9500, 10397);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 9596, 9655);

                string
                defaultLevel = f_139_9618_9654(f_139_9627_9653(descriptor))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 9724, 9767);

                bool
                emitLevel = defaultLevel != "warning"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 9842, 9892);

                bool
                emitEnabled = f_139_9861_9891_M(!descriptor.IsEnabledByDefault)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 9908, 10386) || true) && (emitLevel || (DynAbs.Tracing.TraceSender.Expression_False(139, 9912, 9936) || emitEnabled))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(139, 9908, 10386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 9970, 10019);

                    f_139_9970_10018(f_139_9970_9977(), "defaultConfiguration");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 10039, 10150) || true) && (emitLevel)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(139, 10039, 10150);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 10094, 10131);

                        f_139_10094_10130(f_139_10094_10101(), "level", defaultLevel);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(139, 10039, 10150);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 10170, 10302) || true) && (emitEnabled)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(139, 10170, 10302);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 10227, 10283);

                        f_139_10227_10282(f_139_10227_10234(), "enabled", f_139_10252_10281(descriptor));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(139, 10170, 10302);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 10322, 10347);

                    f_139_10322_10346(f_139_10322_10329());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(139, 9908, 10386);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(139, 9500, 10397);

                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_139_9627_9653(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.DefaultSeverity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 9627, 9653);
                    return return_v;
                }


                string
                f_139_9618_9654(Microsoft.CodeAnalysis.DiagnosticSeverity
                severity)
                {
                    var return_v = GetLevel(severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 9618, 9654);
                    return return_v;
                }


                bool
                f_139_9861_9891_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 9861, 9891);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_139_9970_9977()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 9970, 9977);
                    return return_v;
                }


                int
                f_139_9970_10018(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteObjectStart(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 9970, 10018);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_10094_10101()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 10094, 10101);
                    return return_v;
                }


                int
                f_139_10094_10130(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 10094, 10130);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_10227_10234()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 10227, 10234);
                    return return_v;
                }


                bool
                f_139_10252_10281(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.IsEnabledByDefault;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 10252, 10281);
                    return return_v;
                }


                int
                f_139_10227_10282(Roslyn.Utilities.JsonWriter
                this_param, string
                key, bool
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 10227, 10282);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_139_10322_10329()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 10322, 10329);
                    return return_v;
                }


                int
                f_139_10322_10346(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 10322, 10346);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(139, 9500, 10397);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(139, 9500, 10397);
            }
        }
        private sealed class DiagnosticDescriptorSet
        {
            private readonly Dictionary<DiagnosticDescriptor, int> _distinctDescriptors;

            public int Count
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(139, 11030, 11059);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 11033, 11059);
                        return f_139_11033_11059(_distinctDescriptors); DynAbs.Tracing.TraceSender.TraceExitMethod(139, 11030, 11059);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(139, 11030, 11059);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(139, 11030, 11059);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public int Add(DiagnosticDescriptor descriptor)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(139, 11322, 11777);
                    int index = default(int);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 11402, 11762) || true) && (f_139_11406_11465(_distinctDescriptors, descriptor, out index))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(139, 11402, 11762);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 11565, 11578);

                        return index;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(139, 11402, 11762);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(139, 11402, 11762);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 11660, 11704);

                        f_139_11660_11703(_distinctDescriptors, descriptor, f_139_11697_11702());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 11726, 11743);

                        return f_139_11733_11738() - 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(139, 11402, 11762);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(139, 11322, 11777);

                    bool
                    f_139_11406_11465(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.DiagnosticDescriptor, int>
                    this_param, Microsoft.CodeAnalysis.DiagnosticDescriptor
                    key, out int
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 11406, 11465);
                        return return_v;
                    }


                    int
                    f_139_11697_11702()
                    {
                        var return_v = Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 11697, 11702);
                        return return_v;
                    }


                    int
                    f_139_11660_11703(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.DiagnosticDescriptor, int>
                    this_param, Microsoft.CodeAnalysis.DiagnosticDescriptor
                    key, int
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 11660, 11703);
                        return 0;
                    }


                    int
                    f_139_11733_11738()
                    {
                        var return_v = Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 11733, 11738);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(139, 11322, 11777);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(139, 11322, 11777);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public List<KeyValuePair<int, DiagnosticDescriptor>> ToSortedList()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(139, 11910, 12552);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 12010, 12034);

                    f_139_12010_12033(f_139_12023_12028() > 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 12054, 12122);

                    var
                    list = f_139_12065_12121(f_139_12115_12120())
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 12142, 12383);
                        foreach (var pair in f_139_12163_12183_I(_distinctDescriptors))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(139, 12142, 12383);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 12225, 12266);

                            f_139_12225_12265(f_139_12238_12251(list) > f_139_12254_12264(list));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 12288, 12364);

                            f_139_12288_12363(list, f_139_12297_12362(pair.Value, pair.Key));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(139, 12142, 12383);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(139, 1, 242);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(139, 1, 242);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 12403, 12445);

                    f_139_12403_12444(f_139_12416_12429(list) == f_139_12433_12443(list));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 12463, 12507);

                    f_139_12463_12506(list, (x, y) => x.Key.CompareTo(y.Key));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 12525, 12537);

                    return list;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(139, 11910, 12552);

                    int
                    f_139_12023_12028()
                    {
                        var return_v = Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 12023, 12028);
                        return return_v;
                    }


                    int
                    f_139_12010_12033(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 12010, 12033);
                        return 0;
                    }


                    int
                    f_139_12115_12120()
                    {
                        var return_v = Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 12115, 12120);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<int, Microsoft.CodeAnalysis.DiagnosticDescriptor>>
                    f_139_12065_12121(int
                    capacity)
                    {
                        var return_v = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<int, Microsoft.CodeAnalysis.DiagnosticDescriptor>>(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 12065, 12121);
                        return return_v;
                    }


                    int
                    f_139_12238_12251(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<int, Microsoft.CodeAnalysis.DiagnosticDescriptor>>
                    this_param)
                    {
                        var return_v = this_param.Capacity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 12238, 12251);
                        return return_v;
                    }


                    int
                    f_139_12254_12264(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<int, Microsoft.CodeAnalysis.DiagnosticDescriptor>>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 12254, 12264);
                        return return_v;
                    }


                    int
                    f_139_12225_12265(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 12225, 12265);
                        return 0;
                    }


                    System.Collections.Generic.KeyValuePair<int, Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_139_12297_12362(int
                    key, Microsoft.CodeAnalysis.DiagnosticDescriptor
                    value)
                    {
                        var return_v = new System.Collections.Generic.KeyValuePair<int, Microsoft.CodeAnalysis.DiagnosticDescriptor>(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 12297, 12362);
                        return return_v;
                    }


                    int
                    f_139_12288_12363(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<int, Microsoft.CodeAnalysis.DiagnosticDescriptor>>
                    this_param, System.Collections.Generic.KeyValuePair<int, Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 12288, 12363);
                        return 0;
                    }


                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.DiagnosticDescriptor, int>
                    f_139_12163_12183_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.DiagnosticDescriptor, int>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 12163, 12183);
                        return return_v;
                    }


                    int
                    f_139_12416_12429(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<int, Microsoft.CodeAnalysis.DiagnosticDescriptor>>
                    this_param)
                    {
                        var return_v = this_param.Capacity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 12416, 12429);
                        return return_v;
                    }


                    int
                    f_139_12433_12443(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<int, Microsoft.CodeAnalysis.DiagnosticDescriptor>>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 12433, 12443);
                        return return_v;
                    }


                    int
                    f_139_12403_12444(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 12403, 12444);
                        return 0;
                    }


                    int
                    f_139_12463_12506(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<int, Microsoft.CodeAnalysis.DiagnosticDescriptor>>
                    this_param, System.Comparison<System.Collections.Generic.KeyValuePair<int, Microsoft.CodeAnalysis.DiagnosticDescriptor>>
                    comparison)
                    {
                        this_param.Sort(comparison);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 12463, 12506);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(139, 11910, 12552);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(139, 11910, 12552);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public DiagnosticDescriptorSet()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(139, 10604, 12563);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(139, 10782, 10880);
                this._distinctDescriptors = f_139_10805_10880(SarifDiagnosticComparer.Instance); DynAbs.Tracing.TraceSender.TraceExitConstructor(139, 10604, 12563);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(139, 10604, 12563);
            }


            static DiagnosticDescriptorSet()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(139, 10604, 12563);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(139, 10604, 12563);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(139, 10604, 12563);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(139, 10604, 12563);

            System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.DiagnosticDescriptor, int>
            f_139_10805_10880(Microsoft.CodeAnalysis.SarifDiagnosticComparer
            comparer)
            {
                var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.DiagnosticDescriptor, int>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.DiagnosticDescriptor>)comparer);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 10805, 10880);
                return return_v;
            }


            int
            f_139_11033_11059(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.DiagnosticDescriptor, int>
            this_param)
            {
                var return_v = this_param.Count;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 11033, 11059);
                return return_v;
            }

        }

        static SarifV2ErrorLogger()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(139, 729, 12570);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(139, 729, 12570);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(139, 729, 12570);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(139, 729, 12570);

        static Microsoft.CodeAnalysis.SarifV2ErrorLogger.DiagnosticDescriptorSet
        f_139_1245_1274()
        {
            var return_v = new Microsoft.CodeAnalysis.SarifV2ErrorLogger.DiagnosticDescriptorSet();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 1245, 1274);
            return return_v;
        }


        Roslyn.Utilities.JsonWriter
        f_139_1434_1441()
        {
            var return_v = _writer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 1434, 1441);
            return return_v;
        }


        static int
        f_139_1434_1460(Roslyn.Utilities.JsonWriter
        this_param)
        {
            this_param.WriteObjectStart();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 1434, 1460);
            return 0;
        }


        Roslyn.Utilities.JsonWriter
        f_139_1483_1490()
        {
            var return_v = _writer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 1483, 1490);
            return return_v;
        }


        static int
        f_139_1483_1550(Roslyn.Utilities.JsonWriter
        this_param, string
        key, string
        value)
        {
            this_param.Write(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 1483, 1550);
            return 0;
        }


        Roslyn.Utilities.JsonWriter
        f_139_1565_1572()
        {
            var return_v = _writer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 1565, 1572);
            return return_v;
        }


        static int
        f_139_1565_1598(Roslyn.Utilities.JsonWriter
        this_param, string
        key, string
        value)
        {
            this_param.Write(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 1565, 1598);
            return 0;
        }


        Roslyn.Utilities.JsonWriter
        f_139_1613_1620()
        {
            var return_v = _writer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 1613, 1620);
            return return_v;
        }


        static int
        f_139_1613_1644(Roslyn.Utilities.JsonWriter
        this_param, string
        key)
        {
            this_param.WriteArrayStart(key);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 1613, 1644);
            return 0;
        }


        Roslyn.Utilities.JsonWriter
        f_139_1659_1666()
        {
            var return_v = _writer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 1659, 1666);
            return return_v;
        }


        static int
        f_139_1659_1685(Roslyn.Utilities.JsonWriter
        this_param)
        {
            this_param.WriteObjectStart();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 1659, 1685);
            return 0;
        }


        Roslyn.Utilities.JsonWriter
        f_139_1709_1716()
        {
            var return_v = _writer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(139, 1709, 1716);
            return return_v;
        }


        static int
        f_139_1709_1743(Roslyn.Utilities.JsonWriter
        this_param, string
        key)
        {
            this_param.WriteArrayStart(key);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(139, 1709, 1743);
            return 0;
        }


        static System.IO.Stream
        f_139_1189_1195_C(System.IO.Stream
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(139, 1037, 1755);
            return return_v;
        }

    }
}
