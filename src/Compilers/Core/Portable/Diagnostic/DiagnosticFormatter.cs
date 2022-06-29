// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Globalization;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public class DiagnosticFormatter
    {        /// <summary>
             /// Formats the <see cref="Diagnostic"/> message using the optional <see cref="IFormatProvider"/>.
             /// </summary>
             /// <param name="diagnostic">The diagnostic.</param>
             /// <param name="formatter">The formatter; or null to use the default formatter.</param>
             /// <returns>The formatted message.</returns>
        public virtual string Format(Diagnostic diagnostic, IFormatProvider? formatter = null)
        {
            if (diagnostic == null)
            {
                throw new ArgumentNullException(nameof(diagnostic));
            }

            var culture = formatter as CultureInfo;

            switch (diagnostic.Location.Kind)
            {
                case LocationKind.SourceFile:
                case LocationKind.XmlFile:
                case LocationKind.ExternalFile:
                    var span = diagnostic.Location.GetLineSpan();
                    var mappedSpan = diagnostic.Location.GetMappedLineSpan();
                    if (!span.IsValid || !mappedSpan.IsValid)
                    {
                        goto default;
                    }

                    string? path, basePath;
                    if (mappedSpan.HasMappedPath)
                    {
                        path = mappedSpan.Path;
                        basePath = span.Path;
                    }
                    else
                    {
                        path = span.Path;
                        basePath = null;
                    }

                    return string.Format(formatter, "{0}{1}: {2}: {3}",
                                         FormatSourcePath(path, basePath, formatter),
                                         FormatSourceSpan(mappedSpan.Span, formatter),
                                         GetMessagePrefix(diagnostic),
                                         diagnostic.GetMessage(culture));

                default:
                    return string.Format(formatter, "{0}: {1}",
                                         GetMessagePrefix(diagnostic),
                                         diagnostic.GetMessage(culture));
            }
        }

        internal virtual string FormatSourcePath(string path, string? basePath, IFormatProvider? formatter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(184, 2725, 2905);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(184, 2882, 2894);

                return path;
                DynAbs.Tracing.TraceSender.TraceExitMethod(184, 2725, 2905);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(184, 2725, 2905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(184, 2725, 2905);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual string FormatSourceSpan(LinePositionSpan span, IFormatProvider? formatter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(184, 2917, 3125);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(184, 3033, 3114);

                return f_184_3040_3113("({0},{1})", span.Start.Line + 1, span.Start.Character + 1);
                DynAbs.Tracing.TraceSender.TraceExitMethod(184, 2917, 3125);

                string
                f_184_3040_3113(string
                format, int
                arg0, int
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(184, 3040, 3113);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(184, 2917, 3125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(184, 2917, 3125);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetMessagePrefix(Diagnostic diagnostic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(184, 3137, 3959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(184, 3217, 3231);

                string
                prefix
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(184, 3245, 3877);

                switch (f_184_3253_3272(diagnostic))
                {

                    case DiagnosticSeverity.Hidden:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(184, 3245, 3877);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(184, 3359, 3377);

                        prefix = "hidden";
                        DynAbs.Tracing.TraceSender.TraceBreak(184, 3399, 3405);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(184, 3245, 3877);

                    case DiagnosticSeverity.Info:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(184, 3245, 3877);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(184, 3474, 3490);

                        prefix = "info";
                        DynAbs.Tracing.TraceSender.TraceBreak(184, 3512, 3518);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(184, 3245, 3877);

                    case DiagnosticSeverity.Warning:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(184, 3245, 3877);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(184, 3590, 3609);

                        prefix = "warning";
                        DynAbs.Tracing.TraceSender.TraceBreak(184, 3631, 3637);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(184, 3245, 3877);

                    case DiagnosticSeverity.Error:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(184, 3245, 3877);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(184, 3707, 3724);

                        prefix = "error";
                        DynAbs.Tracing.TraceSender.TraceBreak(184, 3746, 3752);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(184, 3245, 3877);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(184, 3245, 3877);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(184, 3800, 3862);

                        throw f_184_3806_3861(f_184_3841_3860(diagnostic));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(184, 3245, 3877);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(184, 3893, 3948);

                return f_184_3900_3947("{0} {1}", prefix, f_184_3933_3946(diagnostic));
                DynAbs.Tracing.TraceSender.TraceExitMethod(184, 3137, 3959);

                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_184_3253_3272(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(184, 3253, 3272);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_184_3841_3860(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(184, 3841, 3860);
                    return return_v;
                }


                System.Exception
                f_184_3806_3861(Microsoft.CodeAnalysis.DiagnosticSeverity
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(184, 3806, 3861);
                    return return_v;
                }


                string
                f_184_3933_3946(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(184, 3933, 3946);
                    return return_v;
                }


                string
                f_184_3900_3947(string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(184, 3900, 3947);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(184, 3137, 3959);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(184, 3137, 3959);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static readonly DiagnosticFormatter Instance;

        public DiagnosticFormatter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(184, 447, 4060);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(184, 447, 4060);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(184, 447, 4060);
        }


        static DiagnosticFormatter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(184, 447, 4060);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(184, 4016, 4052);
            Instance = f_184_4027_4052(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(184, 447, 4060);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(184, 447, 4060);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(184, 447, 4060);

        static Microsoft.CodeAnalysis.DiagnosticFormatter
        f_184_4027_4052()
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticFormatter();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(184, 4027, 4052);
            return return_v;
        }

    }
}
