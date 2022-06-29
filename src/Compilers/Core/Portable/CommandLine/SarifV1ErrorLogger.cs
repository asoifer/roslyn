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

#pragma warning disable RS0013 // We need to invoke Diagnostic.Descriptor here to log all the metadata properties of the diagnostic.

namespace Microsoft.CodeAnalysis
{
    internal sealed class SarifV1ErrorLogger : SarifErrorLogger, IDisposable
    {
        private readonly DiagnosticDescriptorSet _descriptors;

        public SarifV1ErrorLogger(Stream stream, string toolName, string toolFileVersion, Version toolAssemblyVersion, CultureInfo culture)
        : base(f_138_1416_1422_C(stream), culture)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(138, 1264, 2258);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 1241, 1253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 1457, 1502);

                _descriptors = f_138_1472_1501();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 1518, 1545);

                f_138_1518_1544(f_138_1518_1525());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 1567, 1635);

                f_138_1567_1634(f_138_1567_1574(), "$schema", "http://json.schemastore.org/sarif-1.0.0");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 1649, 1683);

                f_138_1649_1682(f_138_1649_1656(), "version", "1.0.0");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 1697, 1729);

                f_138_1697_1728(f_138_1697_1704(), "runs");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 1743, 1770);

                f_138_1743_1769(f_138_1743_1750());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 1793, 1826);

                f_138_1793_1825(f_138_1793_1800(), "tool");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 1840, 1872);

                f_138_1840_1871(f_138_1840_1847(), "name", toolName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 1886, 1943);

                f_138_1886_1942(f_138_1886_1893(), "version", f_138_1911_1941(toolAssemblyVersion));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 1957, 2003);

                f_138_1957_2002(f_138_1957_1964(), "fileVersion", toolFileVersion);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 2017, 2095);

                f_138_2017_2094(f_138_2017_2024(), "semanticVersion", f_138_2050_2093(toolAssemblyVersion, fieldCount: 3));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 2109, 2149);

                f_138_2109_2148(f_138_2109_2116(), "language", f_138_2135_2147(culture));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 2163, 2188);

                f_138_2163_2187(f_138_2163_2170());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 2212, 2247);

                f_138_2212_2246(f_138_2212_2219(), "results");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(138, 1264, 2258);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(138, 1264, 2258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(138, 1264, 2258);
            }
        }

        protected override string PrimaryLocationPropertyName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(138, 2324, 2339);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 2327, 2339);
                    return "resultFile"; DynAbs.Tracing.TraceSender.TraceExitMethod(138, 2324, 2339);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(138, 2324, 2339);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(138, 2324, 2339);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void LogDiagnostic(Diagnostic diagnostic, SuppressionInfo? suppressionInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(138, 2352, 3456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 2468, 2495);

                f_138_2468_2494(f_138_2468_2475());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 2519, 2558);

                f_138_2519_2557(f_138_2519_2526(), "ruleId", f_138_2543_2556(diagnostic));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 2574, 2631);

                string
                ruleKey = f_138_2591_2630(_descriptors, f_138_2608_2629(diagnostic))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 2645, 2756) || true) && (ruleKey != f_138_2660_2673(diagnostic))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(138, 2645, 2756);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 2707, 2741);

                    f_138_2707_2740(f_138_2707_2714(), "ruleKey", ruleKey);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(138, 2645, 2756);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 2772, 2826);

                f_138_2772_2825(f_138_2772_2779(), "level", f_138_2795_2824(f_138_2804_2823(diagnostic)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 2842, 2892);

                string?
                message = f_138_2860_2891(diagnostic, f_138_2882_2890())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 2906, 3029) || true) && (!f_138_2911_2946(message))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(138, 2906, 3029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 2980, 3014);

                    f_138_2980_3013(f_138_2980_2987(), "message", message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(138, 2906, 3029);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 3045, 3262) || true) && (f_138_3049_3072(diagnostic))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(138, 3045, 3262);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 3106, 3151);

                    f_138_3106_3150(f_138_3106_3113(), "suppressionStates");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 3169, 3205);

                    f_138_3169_3204(f_138_3169_3176(), "suppressedInSource");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 3223, 3247);

                    f_138_3223_3246(f_138_3223_3230());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(138, 3045, 3262);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 3278, 3346);

                f_138_3278_3345(this, f_138_3293_3312(diagnostic), f_138_3314_3344(diagnostic));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 3360, 3394);

                f_138_3360_3393(this, diagnostic);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 3410, 3435);

                f_138_3410_3434(f_138_3410_3417());
                DynAbs.Tracing.TraceSender.TraceExitMethod(138, 2352, 3456);

                Roslyn.Utilities.JsonWriter
                f_138_2468_2475()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 2468, 2475);
                    return return_v;
                }


                int
                f_138_2468_2494(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectStart();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 2468, 2494);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_138_2519_2526()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 2519, 2526);
                    return return_v;
                }


                string
                f_138_2543_2556(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 2543, 2556);
                    return return_v;
                }


                int
                f_138_2519_2557(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 2519, 2557);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticDescriptor
                f_138_2608_2629(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Descriptor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 2608, 2629);
                    return return_v;
                }


                string
                f_138_2591_2630(Microsoft.CodeAnalysis.SarifV1ErrorLogger.DiagnosticDescriptorSet
                this_param, Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor)
                {
                    var return_v = this_param.Add(descriptor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 2591, 2630);
                    return return_v;
                }


                string
                f_138_2660_2673(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 2660, 2673);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_138_2707_2714()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 2707, 2714);
                    return return_v;
                }


                int
                f_138_2707_2740(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 2707, 2740);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_138_2772_2779()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 2772, 2779);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_138_2804_2823(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 2804, 2823);
                    return return_v;
                }


                string
                f_138_2795_2824(Microsoft.CodeAnalysis.DiagnosticSeverity
                severity)
                {
                    var return_v = GetLevel(severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 2795, 2824);
                    return return_v;
                }


                int
                f_138_2772_2825(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 2772, 2825);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_138_2882_2890()
                {
                    var return_v = _culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 2882, 2890);
                    return return_v;
                }


                string
                f_138_2860_2891(Microsoft.CodeAnalysis.Diagnostic
                this_param, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = this_param.GetMessage((System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 2860, 2891);
                    return return_v;
                }


                bool
                f_138_2911_2946(string
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 2911, 2946);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_138_2980_2987()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 2980, 2987);
                    return return_v;
                }


                int
                f_138_2980_3013(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 2980, 3013);
                    return 0;
                }


                bool
                f_138_3049_3072(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.IsSuppressed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 3049, 3072);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_138_3106_3113()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 3106, 3113);
                    return return_v;
                }


                int
                f_138_3106_3150(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteArrayStart(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 3106, 3150);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_138_3169_3176()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 3169, 3176);
                    return return_v;
                }


                int
                f_138_3169_3204(Roslyn.Utilities.JsonWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 3169, 3204);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_138_3223_3230()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 3223, 3230);
                    return return_v;
                }


                int
                f_138_3223_3246(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteArrayEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 3223, 3246);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_138_3293_3312(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 3293, 3312);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                f_138_3314_3344(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.AdditionalLocations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 3314, 3344);
                    return return_v;
                }


                int
                f_138_3278_3345(Microsoft.CodeAnalysis.SarifV1ErrorLogger
                this_param, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                additionalLocations)
                {
                    this_param.WriteLocations(location, additionalLocations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 3278, 3345);
                    return 0;
                }


                int
                f_138_3360_3393(Microsoft.CodeAnalysis.SarifV1ErrorLogger
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diagnostic)
                {
                    this_param.WriteResultProperties(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 3360, 3393);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_138_3410_3417()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 3410, 3417);
                    return return_v;
                }


                int
                f_138_3410_3434(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 3410, 3434);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(138, 2352, 3456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(138, 2352, 3456);
            }
        }

        private void WriteLocations(Location location, IReadOnlyList<Location> additionalLocations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(138, 3468, 5023);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 3584, 3976) || true) && (f_138_3588_3605(location))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(138, 3584, 3976);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 3639, 3676);

                    f_138_3639_3675(f_138_3639_3646(), "locations");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 3694, 3721);

                    f_138_3694_3720(f_138_3694_3701());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 3751, 3797);

                    f_138_3751_3796(f_138_3751_3758(), f_138_3768_3795());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 3817, 3849);

                    f_138_3817_3848(this, location);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 3869, 3894);

                    f_138_3869_3893(f_138_3869_3876());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 3924, 3948);

                    f_138_3924_3947(f_138_3924_3931());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(138, 3584, 3976);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 4211, 5012) || true) && (additionalLocations != null && (DynAbs.Tracing.TraceSender.Expression_True(138, 4215, 4292) && f_138_4263_4288(additionalLocations) > 0) && (DynAbs.Tracing.TraceSender.Expression_True(138, 4215, 4353) && f_138_4313_4353(additionalLocations, l => HasPath(l))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(138, 4211, 5012);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 4387, 4431);

                    f_138_4387_4430(f_138_4387_4394(), "relatedLocations");
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 4451, 4933);
                        foreach (var additionalLocation in f_138_4486_4505_I(additionalLocations))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(138, 4451, 4933);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 4547, 4914) || true) && (f_138_4551_4578(additionalLocation))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(138, 4547, 4914);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 4628, 4655);

                                f_138_4628_4654(f_138_4628_4635());
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 4706, 4743);

                                f_138_4706_4742(f_138_4706_4713(), "physicalLocation");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 4771, 4813);

                                f_138_4771_4812(this, additionalLocation);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 4841, 4866);

                                f_138_4841_4865(f_138_4841_4848());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(138, 4547, 4914);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(138, 4451, 4933);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(138, 1, 483);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(138, 1, 483);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 4953, 4977);

                    f_138_4953_4976(f_138_4953_4960());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(138, 4211, 5012);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(138, 3468, 5023);

                bool
                f_138_3588_3605(Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = HasPath(location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 3588, 3605);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_138_3639_3646()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 3639, 3646);
                    return return_v;
                }


                int
                f_138_3639_3675(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteArrayStart(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 3639, 3675);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_138_3694_3701()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 3694, 3701);
                    return return_v;
                }


                int
                f_138_3694_3720(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectStart();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 3694, 3720);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_138_3751_3758()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 3751, 3758);
                    return return_v;
                }


                string
                f_138_3768_3795()
                {
                    var return_v = PrimaryLocationPropertyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 3768, 3795);
                    return return_v;
                }


                int
                f_138_3751_3796(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 3751, 3796);
                    return 0;
                }


                int
                f_138_3817_3848(Microsoft.CodeAnalysis.SarifV1ErrorLogger
                this_param, Microsoft.CodeAnalysis.Location
                location)
                {
                    this_param.WritePhysicalLocation(location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 3817, 3848);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_138_3869_3876()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 3869, 3876);
                    return return_v;
                }


                int
                f_138_3869_3893(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 3869, 3893);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_138_3924_3931()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 3924, 3931);
                    return return_v;
                }


                int
                f_138_3924_3947(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteArrayEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 3924, 3947);
                    return 0;
                }


                int
                f_138_4263_4288(System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 4263, 4288);
                    return return_v;
                }


                bool
                f_138_4313_4353(System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                source, System.Func<Microsoft.CodeAnalysis.Location, bool>
                predicate)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.Location>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 4313, 4353);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_138_4387_4394()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 4387, 4394);
                    return return_v;
                }


                int
                f_138_4387_4430(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteArrayStart(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 4387, 4430);
                    return 0;
                }


                bool
                f_138_4551_4578(Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = HasPath(location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 4551, 4578);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_138_4628_4635()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 4628, 4635);
                    return return_v;
                }


                int
                f_138_4628_4654(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectStart();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 4628, 4654);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_138_4706_4713()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 4706, 4713);
                    return return_v;
                }


                int
                f_138_4706_4742(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 4706, 4742);
                    return 0;
                }


                int
                f_138_4771_4812(Microsoft.CodeAnalysis.SarifV1ErrorLogger
                this_param, Microsoft.CodeAnalysis.Location
                location)
                {
                    this_param.WritePhysicalLocation(location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 4771, 4812);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_138_4841_4848()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 4841, 4848);
                    return return_v;
                }


                int
                f_138_4841_4865(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 4841, 4865);
                    return 0;
                }


                System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                f_138_4486_4505_I(System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 4486, 4505);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_138_4953_4960()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 4953, 4960);
                    return return_v;
                }


                int
                f_138_4953_4976(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteArrayEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 4953, 4976);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(138, 3468, 5023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(138, 3468, 5023);
            }
        }

        protected override void WritePhysicalLocation(Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(138, 5035, 5406);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 5124, 5156);

                f_138_5124_5155(f_138_5137_5154(location));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 5172, 5223);

                FileLinePositionSpan
                span = f_138_5200_5222(location)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 5239, 5266);

                f_138_5239_5265(f_138_5239_5246());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 5280, 5320);

                f_138_5280_5319(f_138_5280_5287(), "uri", f_138_5301_5318(span.Path));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 5336, 5354);

                f_138_5336_5353(this, span);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 5370, 5395);

                f_138_5370_5394(f_138_5370_5377());
                DynAbs.Tracing.TraceSender.TraceExitMethod(138, 5035, 5406);

                bool
                f_138_5137_5154(Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = HasPath(location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 5137, 5154);
                    return return_v;
                }


                int
                f_138_5124_5155(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 5124, 5155);
                    return 0;
                }


                Microsoft.CodeAnalysis.FileLinePositionSpan
                f_138_5200_5222(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.GetLineSpan();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 5200, 5222);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_138_5239_5246()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 5239, 5246);
                    return return_v;
                }


                int
                f_138_5239_5265(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectStart();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 5239, 5265);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_138_5280_5287()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 5280, 5287);
                    return return_v;
                }


                string
                f_138_5301_5318(string
                path)
                {
                    var return_v = GetUri(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 5301, 5318);
                    return return_v;
                }


                int
                f_138_5280_5319(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 5280, 5319);
                    return 0;
                }


                int
                f_138_5336_5353(Microsoft.CodeAnalysis.SarifV1ErrorLogger
                this_param, Microsoft.CodeAnalysis.FileLinePositionSpan
                span)
                {
                    this_param.WriteRegion(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 5336, 5353);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_138_5370_5377()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 5370, 5377);
                    return return_v;
                }


                int
                f_138_5370_5394(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 5370, 5394);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(138, 5035, 5406);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(138, 5035, 5406);
            }
        }

        private void WriteRules()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(138, 5418, 7653);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 5468, 7642) || true) && (f_138_5472_5490(_descriptors) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(138, 5468, 7642);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 5528, 5562);

                    f_138_5528_5561(f_138_5528_5535(), "rules");
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 5582, 7573);
                        foreach (var pair in f_138_5603_5630_I(f_138_5603_5630(_descriptors)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(138, 5582, 7573);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 5672, 5717);

                            DiagnosticDescriptor
                            descriptor = pair.Value
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 5741, 5776);

                            f_138_5741_5775(f_138_5741_5748(), pair.Key);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 5806, 5841);

                            f_138_5806_5840(f_138_5806_5813(), "id", f_138_5826_5839(descriptor));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 5865, 5928);

                            string?
                            shortDescription = f_138_5892_5927(f_138_5892_5908(descriptor), f_138_5918_5926())
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 5950, 6124) || true) && (!f_138_5955_5999(shortDescription))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(138, 5950, 6124);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 6049, 6101);

                                f_138_6049_6100(f_138_6049_6056(), "shortDescription", shortDescription);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(138, 5950, 6124);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 6148, 6216);

                            string?
                            fullDescription = f_138_6174_6215(f_138_6174_6196(descriptor), f_138_6206_6214())
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 6238, 6409) || true) && (!f_138_6243_6286(fullDescription))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(138, 6238, 6409);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 6336, 6386);

                                f_138_6336_6385(f_138_6336_6343(), "fullDescription", fullDescription);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(138, 6238, 6409);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 6433, 6501);

                            f_138_6433_6500(f_138_6433_6440(), "defaultLevel", f_138_6463_6499(f_138_6472_6498(descriptor)));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 6525, 6696) || true) && (!f_138_6530_6574(f_138_6551_6573(descriptor)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(138, 6525, 6696);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 6624, 6673);

                                f_138_6624_6672(f_138_6624_6631(), "helpUri", f_138_6649_6671(descriptor));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(138, 6525, 6696);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 6720, 6759);

                            f_138_6720_6758(f_138_6720_6727(), "properties");

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 6783, 6949) || true) && (!f_138_6788_6829(f_138_6809_6828(descriptor)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(138, 6783, 6949);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 6879, 6926);

                                f_138_6879_6925(f_138_6879_6886(), "category", f_138_6905_6924(descriptor));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(138, 6783, 6949);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 6973, 7040);

                            f_138_6973_7039(f_138_6973_6980(), "isEnabledByDefault", f_138_7009_7038(descriptor));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 7064, 7436) || true) && (f_138_7068_7095(f_138_7068_7089(descriptor)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(138, 7064, 7436);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 7145, 7177);

                                f_138_7145_7176(f_138_7145_7152(), "tags");
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 7205, 7353);
                                    foreach (string tag in f_138_7228_7249_I(f_138_7228_7249(descriptor)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(138, 7205, 7353);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 7307, 7326);

                                        f_138_7307_7325(f_138_7307_7314(), tag);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(138, 7205, 7353);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(138, 1, 149);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(138, 1, 149);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 7381, 7405);

                                f_138_7381_7404(f_138_7381_7388());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(138, 7064, 7436);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 7460, 7485);

                            f_138_7460_7484(f_138_7460_7467());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 7521, 7546);

                            f_138_7521_7545(f_138_7521_7528());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(138, 5582, 7573);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(138, 1, 1992);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(138, 1, 1992);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 7593, 7618);

                    f_138_7593_7617(f_138_7593_7600());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(138, 5468, 7642);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(138, 5418, 7653);

                int
                f_138_5472_5490(Microsoft.CodeAnalysis.SarifV1ErrorLogger.DiagnosticDescriptorSet
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 5472, 5490);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_138_5528_5535()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 5528, 5535);
                    return return_v;
                }


                int
                f_138_5528_5561(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteObjectStart(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 5528, 5561);
                    return 0;
                }


                System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.DiagnosticDescriptor>>
                f_138_5603_5630(Microsoft.CodeAnalysis.SarifV1ErrorLogger.DiagnosticDescriptorSet
                this_param)
                {
                    var return_v = this_param.ToSortedList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 5603, 5630);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_138_5741_5748()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 5741, 5748);
                    return return_v;
                }


                int
                f_138_5741_5775(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteObjectStart(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 5741, 5775);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_138_5806_5813()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 5806, 5813);
                    return return_v;
                }


                string
                f_138_5826_5839(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 5826, 5839);
                    return return_v;
                }


                int
                f_138_5806_5840(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 5806, 5840);
                    return 0;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_138_5892_5908(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Title;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 5892, 5908);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_138_5918_5926()
                {
                    var return_v = _culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 5918, 5926);
                    return return_v;
                }


                string
                f_138_5892_5927(Microsoft.CodeAnalysis.LocalizableString
                this_param, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 5892, 5927);
                    return return_v;
                }


                bool
                f_138_5955_5999(string
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 5955, 5999);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_138_6049_6056()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 6049, 6056);
                    return return_v;
                }


                int
                f_138_6049_6100(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 6049, 6100);
                    return 0;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_138_6174_6196(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Description;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 6174, 6196);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_138_6206_6214()
                {
                    var return_v = _culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 6206, 6214);
                    return return_v;
                }


                string
                f_138_6174_6215(Microsoft.CodeAnalysis.LocalizableString
                this_param, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 6174, 6215);
                    return return_v;
                }


                bool
                f_138_6243_6286(string
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 6243, 6286);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_138_6336_6343()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 6336, 6343);
                    return return_v;
                }


                int
                f_138_6336_6385(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 6336, 6385);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_138_6433_6440()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 6433, 6440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_138_6472_6498(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.DefaultSeverity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 6472, 6498);
                    return return_v;
                }


                string
                f_138_6463_6499(Microsoft.CodeAnalysis.DiagnosticSeverity
                severity)
                {
                    var return_v = GetLevel(severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 6463, 6499);
                    return return_v;
                }


                int
                f_138_6433_6500(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 6433, 6500);
                    return 0;
                }


                string
                f_138_6551_6573(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.HelpLinkUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 6551, 6573);
                    return return_v;
                }


                bool
                f_138_6530_6574(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 6530, 6574);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_138_6624_6631()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 6624, 6631);
                    return return_v;
                }


                string
                f_138_6649_6671(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.HelpLinkUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 6649, 6671);
                    return return_v;
                }


                int
                f_138_6624_6672(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 6624, 6672);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_138_6720_6727()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 6720, 6727);
                    return return_v;
                }


                int
                f_138_6720_6758(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteObjectStart(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 6720, 6758);
                    return 0;
                }


                string
                f_138_6809_6828(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Category;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 6809, 6828);
                    return return_v;
                }


                bool
                f_138_6788_6829(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 6788, 6829);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_138_6879_6886()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 6879, 6886);
                    return return_v;
                }


                string
                f_138_6905_6924(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Category;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 6905, 6924);
                    return return_v;
                }


                int
                f_138_6879_6925(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 6879, 6925);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_138_6973_6980()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 6973, 6980);
                    return return_v;
                }


                bool
                f_138_7009_7038(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.IsEnabledByDefault;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 7009, 7038);
                    return return_v;
                }


                int
                f_138_6973_7039(Roslyn.Utilities.JsonWriter
                this_param, string
                key, bool
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 6973, 7039);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_138_7068_7089(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.CustomTags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 7068, 7089);
                    return return_v;
                }


                bool
                f_138_7068_7095(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.Any<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 7068, 7095);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_138_7145_7152()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 7145, 7152);
                    return return_v;
                }


                int
                f_138_7145_7176(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteArrayStart(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 7145, 7176);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_138_7228_7249(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.CustomTags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 7228, 7249);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_138_7307_7314()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 7307, 7314);
                    return return_v;
                }


                int
                f_138_7307_7325(Roslyn.Utilities.JsonWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 7307, 7325);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_138_7228_7249_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 7228, 7249);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_138_7381_7388()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 7381, 7388);
                    return return_v;
                }


                int
                f_138_7381_7404(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteArrayEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 7381, 7404);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_138_7460_7467()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 7460, 7467);
                    return return_v;
                }


                int
                f_138_7460_7484(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 7460, 7484);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_138_7521_7528()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 7521, 7528);
                    return return_v;
                }


                int
                f_138_7521_7545(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 7521, 7545);
                    return 0;
                }


                System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.DiagnosticDescriptor>>
                f_138_5603_5630_I(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.DiagnosticDescriptor>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 5603, 5630);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_138_7593_7600()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 7593, 7600);
                    return return_v;
                }


                int
                f_138_7593_7617(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 7593, 7617);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(138, 5418, 7653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(138, 5418, 7653);
            }
        }

        public override void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(138, 7665, 7969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 7720, 7744);

                f_138_7720_7743(f_138_7720_7727());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 7772, 7785);

                f_138_7772_7784(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 7801, 7826);

                f_138_7801_7825(f_138_7801_7808());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 7847, 7871);

                f_138_7847_7870(f_138_7847_7854());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 7894, 7919);

                f_138_7894_7918(f_138_7894_7901());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 7943, 7958);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(), 138, 7943, 7957);
                DynAbs.Tracing.TraceSender.TraceExitMethod(138, 7665, 7969);

                Roslyn.Utilities.JsonWriter
                f_138_7720_7727()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 7720, 7727);
                    return return_v;
                }


                int
                f_138_7720_7743(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteArrayEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 7720, 7743);
                    return 0;
                }


                int
                f_138_7772_7784(Microsoft.CodeAnalysis.SarifV1ErrorLogger
                this_param)
                {
                    this_param.WriteRules();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 7772, 7784);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_138_7801_7808()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 7801, 7808);
                    return return_v;
                }


                int
                f_138_7801_7825(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 7801, 7825);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_138_7847_7854()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 7847, 7854);
                    return return_v;
                }


                int
                f_138_7847_7870(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteArrayEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 7847, 7870);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_138_7894_7901()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 7894, 7901);
                    return return_v;
                }


                int
                f_138_7894_7918(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 7894, 7918);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(138, 7665, 7969);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(138, 7665, 7969);
            }
        }
        private sealed class DiagnosticDescriptorSet
        {
            private readonly Dictionary<string, int> _counters;

            private readonly Dictionary<DiagnosticDescriptor, string> _keys;

            public int Count
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(138, 9059, 9073);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 9062, 9073);
                        return f_138_9062_9073(_keys); DynAbs.Tracing.TraceSender.TraceExitMethod(138, 9059, 9073);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(138, 9059, 9073);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(138, 9059, 9073);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public string Add(DiagnosticDescriptor descriptor)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(138, 9336, 10672);
                    string key = default(string);
                    int counter = default(int);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 9508, 9630) || true) && (f_138_9512_9558(_keys, descriptor, out key))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(138, 9508, 9630);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 9600, 9611);

                        return key;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(138, 9508, 9630);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 9751, 10004) || true) && (!f_138_9756_9809(_counters, f_138_9778_9791(descriptor), out counter))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(138, 9751, 10004);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 9851, 9883);

                        f_138_9851_9882(_counters, f_138_9865_9878(descriptor), 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 9905, 9942);

                        f_138_9905_9941(_keys, descriptor, f_138_9927_9940(descriptor));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 9964, 9985);

                        return f_138_9971_9984(descriptor);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(138, 9751, 10004);
                    }
                    {
                        try
                        {
                            do

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(138, 10342, 10581);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 10385, 10422);

                                _counters[f_138_10395_10408(descriptor)] = ++counter;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 10444, 10526);

                                key = f_138_10450_10463(descriptor) + "-" + f_138_10472_10525(counter, "000", f_138_10496_10524());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(138, 10342, 10581);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 10342, 10581) || true) && (f_138_10553_10579(_counters, key))
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(138, 10342, 10581);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(138, 10342, 10581);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 10601, 10628);

                    f_138_10601_10627(
                                    _keys, descriptor, key);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 10646, 10657);

                    return key;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(138, 9336, 10672);

                    bool
                    f_138_9512_9558(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.DiagnosticDescriptor, string>
                    this_param, Microsoft.CodeAnalysis.DiagnosticDescriptor
                    key, out string?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 9512, 9558);
                        return return_v;
                    }


                    string
                    f_138_9778_9791(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 9778, 9791);
                        return return_v;
                    }


                    bool
                    f_138_9756_9809(System.Collections.Generic.Dictionary<string, int>
                    this_param, string
                    key, out int
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 9756, 9809);
                        return return_v;
                    }


                    string
                    f_138_9865_9878(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 9865, 9878);
                        return return_v;
                    }


                    int
                    f_138_9851_9882(System.Collections.Generic.Dictionary<string, int>
                    this_param, string
                    key, int
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 9851, 9882);
                        return 0;
                    }


                    string
                    f_138_9927_9940(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 9927, 9940);
                        return return_v;
                    }


                    int
                    f_138_9905_9941(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.DiagnosticDescriptor, string>
                    this_param, Microsoft.CodeAnalysis.DiagnosticDescriptor
                    key, string
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 9905, 9941);
                        return 0;
                    }


                    string
                    f_138_9971_9984(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 9971, 9984);
                        return return_v;
                    }


                    string
                    f_138_10395_10408(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 10395, 10408);
                        return return_v;
                    }


                    string
                    f_138_10450_10463(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 10450, 10463);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_138_10496_10524()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 10496, 10524);
                        return return_v;
                    }


                    string
                    f_138_10472_10525(int
                    this_param, string
                    format, System.Globalization.CultureInfo
                    provider)
                    {
                        var return_v = this_param.ToString(format, (System.IFormatProvider)provider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 10472, 10525);
                        return return_v;
                    }


                    bool
                    f_138_10553_10579(System.Collections.Generic.Dictionary<string, int>
                    this_param, string
                    key)
                    {
                        var return_v = this_param.ContainsKey(key);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 10553, 10579);
                        return return_v;
                    }


                    int
                    f_138_10601_10627(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.DiagnosticDescriptor, string>
                    this_param, Microsoft.CodeAnalysis.DiagnosticDescriptor
                    key, string
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 10601, 10627);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(138, 9336, 10672);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(138, 9336, 10672);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public List<KeyValuePair<string, DiagnosticDescriptor>> ToSortedList()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(138, 10829, 11478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 10932, 10956);

                    f_138_10932_10955(f_138_10945_10950() > 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 10976, 11047);

                    var
                    list = f_138_10987_11046(f_138_11040_11045())
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 11067, 11296);
                        foreach (var pair in f_138_11088_11093_I(_keys))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(138, 11067, 11296);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 11135, 11176);

                            f_138_11135_11175(f_138_11148_11161(list) > f_138_11164_11174(list));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 11198, 11277);

                            f_138_11198_11276(list, f_138_11207_11275(pair.Value, pair.Key));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(138, 11067, 11296);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(138, 1, 230);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(138, 1, 230);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 11316, 11358);

                    f_138_11316_11357(f_138_11329_11342(list) == f_138_11346_11356(list));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 11376, 11433);

                    f_138_11376_11432(list, (x, y) => string.CompareOrdinal(x.Key, y.Key));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 11451, 11463);

                    return list;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(138, 10829, 11478);

                    int
                    f_138_10945_10950()
                    {
                        var return_v = Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 10945, 10950);
                        return return_v;
                    }


                    int
                    f_138_10932_10955(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 10932, 10955);
                        return 0;
                    }


                    int
                    f_138_11040_11045()
                    {
                        var return_v = Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 11040, 11045);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.DiagnosticDescriptor>>
                    f_138_10987_11046(int
                    capacity)
                    {
                        var return_v = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.DiagnosticDescriptor>>(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 10987, 11046);
                        return return_v;
                    }


                    int
                    f_138_11148_11161(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.DiagnosticDescriptor>>
                    this_param)
                    {
                        var return_v = this_param.Capacity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 11148, 11161);
                        return return_v;
                    }


                    int
                    f_138_11164_11174(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.DiagnosticDescriptor>>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 11164, 11174);
                        return return_v;
                    }


                    int
                    f_138_11135_11175(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 11135, 11175);
                        return 0;
                    }


                    System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_138_11207_11275(string
                    key, Microsoft.CodeAnalysis.DiagnosticDescriptor
                    value)
                    {
                        var return_v = new System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.DiagnosticDescriptor>(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 11207, 11275);
                        return return_v;
                    }


                    int
                    f_138_11198_11276(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.DiagnosticDescriptor>>
                    this_param, System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 11198, 11276);
                        return 0;
                    }


                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.DiagnosticDescriptor, string>
                    f_138_11088_11093_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.DiagnosticDescriptor, string>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 11088, 11093);
                        return return_v;
                    }


                    int
                    f_138_11329_11342(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.DiagnosticDescriptor>>
                    this_param)
                    {
                        var return_v = this_param.Capacity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 11329, 11342);
                        return return_v;
                    }


                    int
                    f_138_11346_11356(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.DiagnosticDescriptor>>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 11346, 11356);
                        return return_v;
                    }


                    int
                    f_138_11316_11357(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 11316, 11357);
                        return 0;
                    }


                    int
                    f_138_11376_11432(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.DiagnosticDescriptor>>
                    this_param, System.Comparison<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.DiagnosticDescriptor>>
                    comparison)
                    {
                        this_param.Sort(comparison);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 11376, 11432);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(138, 10829, 11478);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(138, 10829, 11478);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public DiagnosticDescriptorSet()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(138, 8478, 11489);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 8656, 8697);
                this._counters = f_138_8668_8697(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(138, 8823, 8909);
                this._keys = f_138_8831_8909(SarifDiagnosticComparer.Instance); DynAbs.Tracing.TraceSender.TraceExitConstructor(138, 8478, 11489);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(138, 8478, 11489);
            }


            static DiagnosticDescriptorSet()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(138, 8478, 11489);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(138, 8478, 11489);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(138, 8478, 11489);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(138, 8478, 11489);

            System.Collections.Generic.Dictionary<string, int>
            f_138_8668_8697()
            {
                var return_v = new System.Collections.Generic.Dictionary<string, int>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 8668, 8697);
                return return_v;
            }


            System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.DiagnosticDescriptor, string>
            f_138_8831_8909(Microsoft.CodeAnalysis.SarifDiagnosticComparer
            comparer)
            {
                var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.DiagnosticDescriptor, string>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.DiagnosticDescriptor>)comparer);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 8831, 8909);
                return return_v;
            }


            int
            f_138_9062_9073(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.DiagnosticDescriptor, string>
            this_param)
            {
                var return_v = this_param.Count;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 9062, 9073);
                return return_v;
            }

        }

        static SarifV1ErrorLogger()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(138, 1111, 11496);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(138, 1111, 11496);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(138, 1111, 11496);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(138, 1111, 11496);

        static Microsoft.CodeAnalysis.SarifV1ErrorLogger.DiagnosticDescriptorSet
        f_138_1472_1501()
        {
            var return_v = new Microsoft.CodeAnalysis.SarifV1ErrorLogger.DiagnosticDescriptorSet();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 1472, 1501);
            return return_v;
        }


        Roslyn.Utilities.JsonWriter
        f_138_1518_1525()
        {
            var return_v = _writer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 1518, 1525);
            return return_v;
        }


        static int
        f_138_1518_1544(Roslyn.Utilities.JsonWriter
        this_param)
        {
            this_param.WriteObjectStart();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 1518, 1544);
            return 0;
        }


        Roslyn.Utilities.JsonWriter
        f_138_1567_1574()
        {
            var return_v = _writer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 1567, 1574);
            return return_v;
        }


        static int
        f_138_1567_1634(Roslyn.Utilities.JsonWriter
        this_param, string
        key, string
        value)
        {
            this_param.Write(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 1567, 1634);
            return 0;
        }


        Roslyn.Utilities.JsonWriter
        f_138_1649_1656()
        {
            var return_v = _writer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 1649, 1656);
            return return_v;
        }


        static int
        f_138_1649_1682(Roslyn.Utilities.JsonWriter
        this_param, string
        key, string
        value)
        {
            this_param.Write(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 1649, 1682);
            return 0;
        }


        Roslyn.Utilities.JsonWriter
        f_138_1697_1704()
        {
            var return_v = _writer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 1697, 1704);
            return return_v;
        }


        static int
        f_138_1697_1728(Roslyn.Utilities.JsonWriter
        this_param, string
        key)
        {
            this_param.WriteArrayStart(key);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 1697, 1728);
            return 0;
        }


        Roslyn.Utilities.JsonWriter
        f_138_1743_1750()
        {
            var return_v = _writer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 1743, 1750);
            return return_v;
        }


        static int
        f_138_1743_1769(Roslyn.Utilities.JsonWriter
        this_param)
        {
            this_param.WriteObjectStart();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 1743, 1769);
            return 0;
        }


        Roslyn.Utilities.JsonWriter
        f_138_1793_1800()
        {
            var return_v = _writer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 1793, 1800);
            return return_v;
        }


        static int
        f_138_1793_1825(Roslyn.Utilities.JsonWriter
        this_param, string
        key)
        {
            this_param.WriteObjectStart(key);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 1793, 1825);
            return 0;
        }


        Roslyn.Utilities.JsonWriter
        f_138_1840_1847()
        {
            var return_v = _writer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 1840, 1847);
            return return_v;
        }


        static int
        f_138_1840_1871(Roslyn.Utilities.JsonWriter
        this_param, string
        key, string
        value)
        {
            this_param.Write(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 1840, 1871);
            return 0;
        }


        Roslyn.Utilities.JsonWriter
        f_138_1886_1893()
        {
            var return_v = _writer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 1886, 1893);
            return return_v;
        }


        static string
        f_138_1911_1941(System.Version
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 1911, 1941);
            return return_v;
        }


        static int
        f_138_1886_1942(Roslyn.Utilities.JsonWriter
        this_param, string
        key, string
        value)
        {
            this_param.Write(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 1886, 1942);
            return 0;
        }


        Roslyn.Utilities.JsonWriter
        f_138_1957_1964()
        {
            var return_v = _writer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 1957, 1964);
            return return_v;
        }


        static int
        f_138_1957_2002(Roslyn.Utilities.JsonWriter
        this_param, string
        key, string
        value)
        {
            this_param.Write(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 1957, 2002);
            return 0;
        }


        Roslyn.Utilities.JsonWriter
        f_138_2017_2024()
        {
            var return_v = _writer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 2017, 2024);
            return return_v;
        }


        static string
        f_138_2050_2093(System.Version
        this_param, int
        fieldCount)
        {
            var return_v = this_param.ToString(fieldCount: fieldCount);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 2050, 2093);
            return return_v;
        }


        static int
        f_138_2017_2094(Roslyn.Utilities.JsonWriter
        this_param, string
        key, string
        value)
        {
            this_param.Write(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 2017, 2094);
            return 0;
        }


        Roslyn.Utilities.JsonWriter
        f_138_2109_2116()
        {
            var return_v = _writer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 2109, 2116);
            return return_v;
        }


        static string
        f_138_2135_2147(System.Globalization.CultureInfo
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 2135, 2147);
            return return_v;
        }


        static int
        f_138_2109_2148(Roslyn.Utilities.JsonWriter
        this_param, string
        key, string
        value)
        {
            this_param.Write(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 2109, 2148);
            return 0;
        }


        Roslyn.Utilities.JsonWriter
        f_138_2163_2170()
        {
            var return_v = _writer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 2163, 2170);
            return return_v;
        }


        static int
        f_138_2163_2187(Roslyn.Utilities.JsonWriter
        this_param)
        {
            this_param.WriteObjectEnd();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 2163, 2187);
            return 0;
        }


        Roslyn.Utilities.JsonWriter
        f_138_2212_2219()
        {
            var return_v = _writer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(138, 2212, 2219);
            return return_v;
        }


        static int
        f_138_2212_2246(Roslyn.Utilities.JsonWriter
        this_param, string
        key)
        {
            this_param.WriteArrayStart(key);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(138, 2212, 2246);
            return 0;
        }


        static System.IO.Stream
        f_138_1416_1422_C(System.IO.Stream
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(138, 1264, 2258);
            return return_v;
        }

    }
}

#pragma warning restore RS0013
