// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal abstract class SarifErrorLogger : ErrorLogger, IDisposable
    {
        protected JsonWriter _writer { get; }

        protected CultureInfo _culture { get; }

        protected SarifErrorLogger(Stream stream, CultureInfo culture)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(137, 1159, 1436);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 1061, 1098);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 1108, 1147);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 1246, 1275);

                f_137_1246_1274(stream != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 1289, 1325);

                f_137_1289_1324(f_137_1302_1318(stream!) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 1341, 1392);

                _writer = f_137_1351_1391(f_137_1366_1390(stream));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 1406, 1425);

                _culture = culture;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(137, 1159, 1436);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(137, 1159, 1436);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(137, 1159, 1436);
            }
        }

        protected abstract string PrimaryLocationPropertyName { get; }

        protected abstract void WritePhysicalLocation(Location diagnosticLocation);

        public virtual void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(137, 1621, 1704);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 1675, 1693);

                f_137_1675_1692(f_137_1675_1682());
                DynAbs.Tracing.TraceSender.TraceExitMethod(137, 1621, 1704);

                Roslyn.Utilities.JsonWriter
                f_137_1675_1682()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 1675, 1682);
                    return return_v;
                }


                int
                f_137_1675_1692(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 1675, 1692);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(137, 1621, 1704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(137, 1621, 1704);
            }
        }

        protected void WriteRegion(FileLinePositionSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(137, 1716, 2290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 1893, 1928);

                f_137_1893_1927(f_137_1893_1900(), "region");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 1942, 2002);

                f_137_1942_2001(f_137_1942_1949(), "startLine", span.StartLinePosition.Line + 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 2016, 2083);

                f_137_2016_2082(f_137_2016_2023(), "startColumn", span.StartLinePosition.Character + 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 2097, 2153);

                f_137_2097_2152(f_137_2097_2104(), "endLine", span.EndLinePosition.Line + 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 2167, 2230);

                f_137_2167_2229(f_137_2167_2174(), "endColumn", span.EndLinePosition.Character + 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 2244, 2269);

                f_137_2244_2268(f_137_2244_2251());
                DynAbs.Tracing.TraceSender.TraceExitMethod(137, 1716, 2290);

                Roslyn.Utilities.JsonWriter
                f_137_1893_1900()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 1893, 1900);
                    return return_v;
                }


                int
                f_137_1893_1927(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteObjectStart(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 1893, 1927);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_137_1942_1949()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 1942, 1949);
                    return return_v;
                }


                int
                f_137_1942_2001(Roslyn.Utilities.JsonWriter
                this_param, string
                key, int
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 1942, 2001);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_137_2016_2023()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 2016, 2023);
                    return return_v;
                }


                int
                f_137_2016_2082(Roslyn.Utilities.JsonWriter
                this_param, string
                key, int
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 2016, 2082);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_137_2097_2104()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 2097, 2104);
                    return return_v;
                }


                int
                f_137_2097_2152(Roslyn.Utilities.JsonWriter
                this_param, string
                key, int
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 2097, 2152);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_137_2167_2174()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 2167, 2174);
                    return return_v;
                }


                int
                f_137_2167_2229(Roslyn.Utilities.JsonWriter
                this_param, string
                key, int
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 2167, 2229);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_137_2244_2251()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 2244, 2251);
                    return return_v;
                }


                int
                f_137_2244_2268(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 2244, 2268);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(137, 1716, 2290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(137, 1716, 2290);
            }
        }

        protected static string GetLevel(DiagnosticSeverity severity)
        {
            switch (severity)
            {
                case DiagnosticSeverity.Info:
                    return "note";

                case DiagnosticSeverity.Error:
                    return "error";

                case DiagnosticSeverity.Warning:
                    return "warning";

                case DiagnosticSeverity.Hidden:
                default:
                    // hidden diagnostics are not reported on the command line and therefore not currently given to
                    // the error logger. We could represent it with a custom property in the SARIF log if that changes.
                    Debug.Assert(false);
                    goto case DiagnosticSeverity.Warning;
            }
        }

        protected void WriteResultProperties(Diagnostic diagnostic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(137, 3135, 4710);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 3510, 3594);

                f_137_3510_3593(f_137_3523_3592(f_137_3523_3544(diagnostic), f_137_3559_3591(f_137_3559_3580(diagnostic))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 3608, 3676);

                f_137_3608_3675(f_137_3621_3640(diagnostic) == f_137_3644_3674(f_137_3644_3665(diagnostic)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 3690, 3772);

                f_137_3690_3771(f_137_3703_3729(diagnostic) == f_137_3733_3770(f_137_3733_3754(diagnostic)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 3786, 3874);

                f_137_3786_3873(f_137_3799_3828(diagnostic) == f_137_3832_3872(f_137_3832_3853(diagnostic)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 3890, 4699) || true) && (f_137_3894_3917(diagnostic) > 0 || (DynAbs.Tracing.TraceSender.Expression_False(137, 3894, 3956) || f_137_3925_3952(f_137_3925_3946(diagnostic)) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(137, 3890, 4699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 3990, 4029);

                    f_137_3990_4028(f_137_3990_3997(), "properties");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 4049, 4196) || true) && (f_137_4053_4076(diagnostic) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(137, 4049, 4196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 4122, 4177);

                        f_137_4122_4176(f_137_4122_4129(), "warningLevel", f_137_4152_4175(diagnostic));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(137, 4049, 4196);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 4216, 4625) || true) && (f_137_4220_4247(f_137_4220_4241(diagnostic)) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(137, 4216, 4625);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 4293, 4338);

                        f_137_4293_4337(f_137_4293_4300(), "customProperties");
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 4362, 4557);
                            foreach (var pair in f_137_4383_4448_I(f_137_4383_4448(f_137_4383_4404(diagnostic), x => x.Key, f_137_4425_4447())))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(137, 4362, 4557);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 4498, 4534);

                                f_137_4498_4533(f_137_4498_4505(), pair.Key, pair.Value);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(137, 4362, 4557);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(137, 1, 196);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(137, 1, 196);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 4581, 4606);

                        f_137_4581_4605(f_137_4581_4588());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(137, 4216, 4625);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 4645, 4670);

                    f_137_4645_4669(f_137_4645_4652());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(137, 3890, 4699);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(137, 3135, 4710);

                System.Collections.Generic.IReadOnlyList<string>
                f_137_3523_3544(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.CustomTags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 3523, 3544);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticDescriptor
                f_137_3559_3580(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Descriptor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 3559, 3580);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_137_3559_3591(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.CustomTags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 3559, 3591);
                    return return_v;
                }


                bool
                f_137_3523_3592(System.Collections.Generic.IReadOnlyList<string>
                first, System.Collections.Generic.IEnumerable<string>
                second)
                {
                    var return_v = first.SequenceEqual<string>(second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 3523, 3592);
                    return return_v;
                }


                int
                f_137_3510_3593(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 3510, 3593);
                    return 0;
                }


                string
                f_137_3621_3640(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Category;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 3621, 3640);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticDescriptor
                f_137_3644_3665(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Descriptor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 3644, 3665);
                    return return_v;
                }


                string
                f_137_3644_3674(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Category;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 3644, 3674);
                    return return_v;
                }


                int
                f_137_3608_3675(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 3608, 3675);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_137_3703_3729(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.DefaultSeverity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 3703, 3729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticDescriptor
                f_137_3733_3754(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Descriptor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 3733, 3754);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_137_3733_3770(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.DefaultSeverity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 3733, 3770);
                    return return_v;
                }


                int
                f_137_3690_3771(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 3690, 3771);
                    return 0;
                }


                bool
                f_137_3799_3828(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.IsEnabledByDefault;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 3799, 3828);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticDescriptor
                f_137_3832_3853(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Descriptor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 3832, 3853);
                    return return_v;
                }


                bool
                f_137_3832_3872(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.IsEnabledByDefault;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 3832, 3872);
                    return return_v;
                }


                int
                f_137_3786_3873(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 3786, 3873);
                    return 0;
                }


                int
                f_137_3894_3917(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.WarningLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 3894, 3917);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, string?>
                f_137_3925_3946(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 3925, 3946);
                    return return_v;
                }


                int
                f_137_3925_3952(System.Collections.Immutable.ImmutableDictionary<string, string?>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 3925, 3952);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_137_3990_3997()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 3990, 3997);
                    return return_v;
                }


                int
                f_137_3990_4028(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteObjectStart(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 3990, 4028);
                    return 0;
                }


                int
                f_137_4053_4076(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.WarningLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 4053, 4076);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_137_4122_4129()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 4122, 4129);
                    return return_v;
                }


                int
                f_137_4152_4175(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.WarningLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 4152, 4175);
                    return return_v;
                }


                int
                f_137_4122_4176(Roslyn.Utilities.JsonWriter
                this_param, string
                key, int
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 4122, 4176);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<string, string?>
                f_137_4220_4241(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 4220, 4241);
                    return return_v;
                }


                int
                f_137_4220_4247(System.Collections.Immutable.ImmutableDictionary<string, string?>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 4220, 4247);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_137_4293_4300()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 4293, 4300);
                    return return_v;
                }


                int
                f_137_4293_4337(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteObjectStart(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 4293, 4337);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<string, string?>
                f_137_4383_4404(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 4383, 4404);
                    return return_v;
                }


                System.StringComparer
                f_137_4425_4447()
                {
                    var return_v = StringComparer.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 4425, 4447);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<string, string?>>
                f_137_4383_4448(System.Collections.Immutable.ImmutableDictionary<string, string?>
                source, System.Func<System.Collections.Generic.KeyValuePair<string, string>, string>
                keySelector, System.StringComparer
                comparer)
                {
                    var return_v = source.OrderBy<System.Collections.Generic.KeyValuePair<string, string?>, string>(keySelector, (System.Collections.Generic.IComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 4383, 4448);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_137_4498_4505()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 4498, 4505);
                    return return_v;
                }


                int
                f_137_4498_4533(Roslyn.Utilities.JsonWriter
                this_param, string
                key, string?
                value)
                {
                    this_param.Write(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 4498, 4533);
                    return 0;
                }


                System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<string, string?>>
                f_137_4383_4448_I(System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<string, string?>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 4383, 4448);
                    return return_v;
                }


                Roslyn.Utilities.JsonWriter
                f_137_4581_4588()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 4581, 4588);
                    return return_v;
                }


                int
                f_137_4581_4605(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 4581, 4605);
                    return 0;
                }


                Roslyn.Utilities.JsonWriter
                f_137_4645_4652()
                {
                    var return_v = _writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 4645, 4652);
                    return return_v;
                }


                int
                f_137_4645_4669(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 4645, 4669);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(137, 3135, 4710);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(137, 3135, 4710);
            }
        }

        protected static bool HasPath(Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(137, 4722, 4864);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 4795, 4853);

                return !f_137_4803_4852(f_137_4824_4846(location).Path);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(137, 4722, 4864);

                Microsoft.CodeAnalysis.FileLinePositionSpan
                f_137_4824_4846(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.GetLineSpan();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 4824, 4846);
                    return return_v;
                }


                bool
                f_137_4803_4852(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 4803, 4852);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(137, 4722, 4864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(137, 4722, 4864);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly Uri s_fileRoot;

        protected static string GetUri(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(137, 4949, 6972);
                System.Uri? uri = default(System.Uri?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 5017, 5059);

                f_137_5017_5058(!f_137_5031_5057(path));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 5295, 6836) || true) && (f_137_5299_5322(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(137, 5295, 6836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 5509, 5547);

                    var
                    fullPath = f_137_5524_5546(path)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 5565, 5931) || true) && (f_137_5569_5623(fullPath, UriKind.Absolute, out uri))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(137, 5565, 5931);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 5889, 5912);

                        return f_137_5896_5911(uri);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(137, 5565, 5931);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(137, 5295, 6836);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(137, 5295, 6836);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 6063, 6269) || true) && (f_137_6067_6100_M(!PathUtilities.IsUnixLikePlatform))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(137, 6063, 6269);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 6142, 6175);

                        path = f_137_6149_6174(path, @"\\", @"\");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 6197, 6250);

                        path = f_137_6204_6249(path);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(137, 6063, 6269);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 6289, 6821) || true) && (f_137_6293_6343(path, UriKind.Relative, out uri))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(137, 6289, 6821);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 6731, 6802);

                        return f_137_6738_6801(f_137_6738_6790(s_fileRoot, f_137_6765_6789(s_fileRoot, uri)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(137, 6289, 6821);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(137, 5295, 6836);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 6916, 6961);

                return f_137_6923_6960(path);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(137, 4949, 6972);

                bool
                f_137_5031_5057(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 5031, 5057);
                    return return_v;
                }


                int
                f_137_5017_5058(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 5017, 5058);
                    return 0;
                }


                bool
                f_137_5299_5322(string
                path)
                {
                    var return_v = Path.IsPathRooted(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 5299, 5322);
                    return return_v;
                }


                string
                f_137_5524_5546(string
                path)
                {
                    var return_v = Path.GetFullPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 5524, 5546);
                    return return_v;
                }


                bool
                f_137_5569_5623(string
                uriString, System.UriKind
                uriKind, out System.Uri?
                result)
                {
                    var return_v = Uri.TryCreate(uriString, uriKind, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 5569, 5623);
                    return return_v;
                }


                string
                f_137_5896_5911(System.Uri
                this_param)
                {
                    var return_v = this_param.AbsoluteUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 5896, 5911);
                    return return_v;
                }


                bool
                f_137_6067_6100_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 6067, 6100);
                    return return_v;
                }


                string
                f_137_6149_6174(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 6149, 6174);
                    return return_v;
                }


                string
                f_137_6204_6249(string
                p)
                {
                    var return_v = PathUtilities.NormalizeWithForwardSlash(p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 6204, 6249);
                    return return_v;
                }


                bool
                f_137_6293_6343(string
                uriString, System.UriKind
                uriKind, out System.Uri?
                result)
                {
                    var return_v = Uri.TryCreate(uriString, uriKind, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 6293, 6343);
                    return return_v;
                }


                System.Uri
                f_137_6765_6789(System.Uri
                baseUri, System.Uri
                relativeUri)
                {
                    var return_v = new System.Uri(baseUri, relativeUri);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 6765, 6789);
                    return return_v;
                }


                System.Uri
                f_137_6738_6790(System.Uri
                this_param, System.Uri
                uri)
                {
                    var return_v = this_param.MakeRelativeUri(uri);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 6738, 6790);
                    return return_v;
                }


                string
                f_137_6738_6801(System.Uri
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 6738, 6801);
                    return return_v;
                }


                string?
                f_137_6923_6960(string
                value)
                {
                    var return_v = System.Net.WebUtility.UrlEncode(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 6923, 6960);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(137, 4949, 6972);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(137, 4949, 6972);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SarifErrorLogger()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(137, 977, 6979);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(137, 4904, 4936);
            s_fileRoot = f_137_4917_4936("file:///"); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(137, 977, 6979);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(137, 977, 6979);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(137, 977, 6979);

        static int
        f_137_1246_1274(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 1246, 1274);
            return 0;
        }


        static long
        f_137_1302_1318(System.IO.Stream
        this_param)
        {
            var return_v = this_param.Position;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(137, 1302, 1318);
            return return_v;
        }


        static int
        f_137_1289_1324(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 1289, 1324);
            return 0;
        }


        static System.IO.StreamWriter
        f_137_1366_1390(System.IO.Stream
        stream)
        {
            var return_v = new System.IO.StreamWriter(stream);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 1366, 1390);
            return return_v;
        }


        static Roslyn.Utilities.JsonWriter
        f_137_1351_1391(System.IO.StreamWriter
        output)
        {
            var return_v = new Roslyn.Utilities.JsonWriter((System.IO.TextWriter)output);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 1351, 1391);
            return return_v;
        }


        static System.Uri
        f_137_4917_4936(string
        uriString)
        {
            var return_v = new System.Uri(uriString);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(137, 4917, 4936);
            return return_v;
        }

    }
}
