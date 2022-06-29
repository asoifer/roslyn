// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    public abstract partial class Diagnostic : IEquatable<Diagnostic?>, IFormattable
    {
        internal const string
        CompilerDiagnosticCategory = "Compiler"
        ;

        internal const int
        DefaultWarningLevel = 4
        ;

        internal const int
        InfoAndHiddenWarningLevel = 1
        ;

        internal const int
        MaxWarningLevel = 9999
        ;

        public static Diagnostic Create(
                    DiagnosticDescriptor descriptor,
                    Location? location,
                    params object?[]? messageArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(180, 2081, 2333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 2261, 2322);

                return f_180_2268_2321(descriptor, location, null, null, messageArgs);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(180, 2081, 2333);

                Microsoft.CodeAnalysis.Diagnostic
                f_180_2268_2321(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.Location?
                location, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Location>?
                additionalLocations, System.Collections.Immutable.ImmutableDictionary<string, string?>?
                properties, params object?[]?
                messageArgs)
                {
                    var return_v = Create(descriptor, location, additionalLocations, properties, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 2268, 2321);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 2081, 2333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 2081, 2333);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Diagnostic Create(
                    DiagnosticDescriptor descriptor,
                    Location? location,
                    ImmutableDictionary<string, string?>? properties,
                    params object?[]? messageArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(180, 3234, 3555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 3477, 3544);

                return f_180_3484_3543(descriptor, location, null, properties, messageArgs);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(180, 3234, 3555);

                Microsoft.CodeAnalysis.Diagnostic
                f_180_3484_3543(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.Location?
                location, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Location>?
                additionalLocations, System.Collections.Immutable.ImmutableDictionary<string, string?>?
                properties, params object?[]?
                messageArgs)
                {
                    var return_v = Create(descriptor, location, additionalLocations, properties, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 3484, 3543);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 3234, 3555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 3234, 3555);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Diagnostic Create(
                    DiagnosticDescriptor descriptor,
                    Location? location,
                    IEnumerable<Location>? additionalLocations,
                    params object?[]? messageArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(180, 4428, 4777);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 4665, 4766);

                return f_180_4672_4765(descriptor, location, additionalLocations, properties: null, messageArgs: messageArgs);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(180, 4428, 4777);

                Microsoft.CodeAnalysis.Diagnostic
                f_180_4672_4765(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.Location?
                location, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Location>?
                additionalLocations, System.Collections.Immutable.ImmutableDictionary<string, string?>?
                properties, params object?[]?
                messageArgs)
                {
                    var return_v = Create(descriptor, location, additionalLocations, properties: properties, messageArgs: messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 4672, 4765);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 4428, 4777);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 4428, 4777);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Diagnostic Create(
                    DiagnosticDescriptor descriptor,
                    Location? location,
                    IEnumerable<Location>? additionalLocations,
                    ImmutableDictionary<string, string?>? properties,
                    params object?[]? messageArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(180, 5997, 6437);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 6297, 6426);

                return f_180_6304_6425(descriptor, location, effectiveSeverity: f_180_6352_6378(descriptor), additionalLocations, properties, messageArgs);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(180, 5997, 6437);

                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_180_6352_6378(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.DefaultSeverity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 6352, 6378);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_180_6304_6425(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.Location?
                location, Microsoft.CodeAnalysis.DiagnosticSeverity
                effectiveSeverity, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Location>?
                additionalLocations, System.Collections.Immutable.ImmutableDictionary<string, string?>?
                properties, params object?[]?
                messageArgs)
                {
                    var return_v = Create(descriptor, location, effectiveSeverity: effectiveSeverity, additionalLocations, properties, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 6304, 6425);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 5997, 6437);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 5997, 6437);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Diagnostic Create(
                    DiagnosticDescriptor descriptor,
                    Location? location,
                    DiagnosticSeverity effectiveSeverity,
                    IEnumerable<Location>? additionalLocations,
                    ImmutableDictionary<string, string?>? properties,
                    params object?[]? messageArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(180, 7748, 8673);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 8099, 8222) || true) && (descriptor == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(180, 8099, 8222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 8155, 8207);

                    throw f_180_8161_8206(nameof(descriptor));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(180, 8099, 8222);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 8238, 8299);

                var
                warningLevel = f_180_8257_8298(effectiveSeverity)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 8313, 8662);

                return f_180_8320_8661(descriptor, severity: effectiveSeverity, warningLevel: warningLevel, location: location ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Location?>(180, 8492, 8517) ?? f_180_8504_8517()), additionalLocations: additionalLocations, messageArgs: messageArgs, properties: properties);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(180, 7748, 8673);

                System.ArgumentNullException
                f_180_8161_8206(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 8161, 8206);
                    return return_v;
                }


                int
                f_180_8257_8298(Microsoft.CodeAnalysis.DiagnosticSeverity
                severity)
                {
                    var return_v = GetDefaultWarningLevel(severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 8257, 8298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_180_8504_8517()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 8504, 8517);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic.SimpleDiagnostic
                f_180_8320_8661(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.DiagnosticSeverity
                severity, int
                warningLevel, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Location>?
                additionalLocations, object?[]?
                messageArgs, System.Collections.Immutable.ImmutableDictionary<string, string?>?
                properties)
                {
                    var return_v = SimpleDiagnostic.Create(descriptor, severity: severity, warningLevel: warningLevel, location: location, additionalLocations: additionalLocations, messageArgs: messageArgs, properties: properties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 8320, 8661);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 7748, 8673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 7748, 8673);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Diagnostic Create(
                    string id,
                    string category,
                    LocalizableString message,
                    DiagnosticSeverity severity,
                    DiagnosticSeverity defaultSeverity,
                    bool isEnabledByDefault,
                    int warningLevel,
                    LocalizableString? title = null,
                    LocalizableString? description = null,
                    string? helpLink = null,
                    Location? location = null,
                    IEnumerable<Location>? additionalLocations = null,
                    IEnumerable<string>? customTags = null,
                    ImmutableDictionary<string, string?>? properties = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(180, 11144, 12036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 11818, 12025);

                return f_180_11825_12024(id, category, message, severity, defaultSeverity, isEnabledByDefault, warningLevel, false, title, description, helpLink, location, additionalLocations, customTags, properties);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(180, 11144, 12036);

                Microsoft.CodeAnalysis.Diagnostic
                f_180_11825_12024(string
                id, string
                category, Microsoft.CodeAnalysis.LocalizableString
                message, Microsoft.CodeAnalysis.DiagnosticSeverity
                severity, Microsoft.CodeAnalysis.DiagnosticSeverity
                defaultSeverity, bool
                isEnabledByDefault, int
                warningLevel, bool
                isSuppressed, Microsoft.CodeAnalysis.LocalizableString?
                title, Microsoft.CodeAnalysis.LocalizableString?
                description, string?
                helpLink, Microsoft.CodeAnalysis.Location?
                location, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Location>?
                additionalLocations, System.Collections.Generic.IEnumerable<string>?
                customTags, System.Collections.Immutable.ImmutableDictionary<string, string?>?
                properties)
                {
                    var return_v = Create(id, category, message, severity, defaultSeverity, isEnabledByDefault, warningLevel, isSuppressed, title, description, helpLink, location, additionalLocations, customTags, properties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 11825, 12024);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 11144, 12036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 11144, 12036);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Diagnostic Create(
                    string id,
                    string category,
                    LocalizableString message,
                    DiagnosticSeverity severity,
                    DiagnosticSeverity defaultSeverity,
                    bool isEnabledByDefault,
                    int warningLevel,
                    bool isSuppressed,
                    LocalizableString? title = null,
                    LocalizableString? description = null,
                    string? helpLink = null,
                    Location? location = null,
                    IEnumerable<Location>? additionalLocations = null,
                    IEnumerable<string>? customTags = null,
                    ImmutableDictionary<string, string?>? properties = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(180, 14633, 16037);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 15339, 15446) || true) && (id == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(180, 15339, 15446);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 15387, 15431);

                    throw f_180_15393_15430(nameof(id));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(180, 15339, 15446);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 15462, 15581) || true) && (category == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(180, 15462, 15581);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 15516, 15566);

                    throw f_180_15522_15565(nameof(category));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(180, 15462, 15581);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 15597, 15714) || true) && (message == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(180, 15597, 15714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 15650, 15699);

                    throw f_180_15656_15698(nameof(message));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(180, 15597, 15714);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 15730, 16026);

                return f_180_15737_16025(id, title ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.LocalizableString?>(180, 15765, 15786) ?? string.Empty), category, message, description ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.LocalizableString?>(180, 15807, 15834) ?? string.Empty), helpLink ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(180, 15836, 15860) ?? string.Empty), severity, defaultSeverity, isEnabledByDefault, warningLevel, location ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Location?>(180, 15940, 15965) ?? f_180_15952_15965()), additionalLocations, customTags, properties, isSuppressed);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(180, 14633, 16037);

                System.ArgumentNullException
                f_180_15393_15430(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 15393, 15430);
                    return return_v;
                }


                System.ArgumentNullException
                f_180_15522_15565(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 15522, 15565);
                    return return_v;
                }


                System.ArgumentNullException
                f_180_15656_15698(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 15656, 15698);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_180_15952_15965()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 15952, 15965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic.SimpleDiagnostic
                f_180_15737_16025(string
                id, Microsoft.CodeAnalysis.LocalizableString
                title, string
                category, Microsoft.CodeAnalysis.LocalizableString
                message, Microsoft.CodeAnalysis.LocalizableString
                description, string
                helpLink, Microsoft.CodeAnalysis.DiagnosticSeverity
                severity, Microsoft.CodeAnalysis.DiagnosticSeverity
                defaultSeverity, bool
                isEnabledByDefault, int
                warningLevel, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Location>?
                additionalLocations, System.Collections.Generic.IEnumerable<string>?
                customTags, System.Collections.Immutable.ImmutableDictionary<string, string?>?
                properties, bool
                isSuppressed)
                {
                    var return_v = SimpleDiagnostic.Create(id, title, category, message, description, helpLink, severity, defaultSeverity, isEnabledByDefault, warningLevel, location, additionalLocations, customTags, properties, isSuppressed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 15737, 16025);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 14633, 16037);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 14633, 16037);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Diagnostic Create(CommonMessageProvider messageProvider, int errorCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(180, 16049, 16234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 16161, 16223);

                return f_180_16168_16222(f_180_16175_16221(messageProvider, errorCode));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(180, 16049, 16234);

                Microsoft.CodeAnalysis.DiagnosticInfo
                f_180_16175_16221(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode)
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticInfo(messageProvider, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 16175, 16221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_180_16168_16222(Microsoft.CodeAnalysis.DiagnosticInfo
                info)
                {
                    var return_v = Create(info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 16168, 16222);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 16049, 16234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 16049, 16234);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Diagnostic Create(CommonMessageProvider messageProvider, int errorCode, params object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(180, 16246, 16469);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 16385, 16458);

                return f_180_16392_16457(f_180_16399_16456(messageProvider, errorCode, arguments));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(180, 16246, 16469);

                Microsoft.CodeAnalysis.DiagnosticInfo
                f_180_16399_16456(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode, params object[]
                arguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticInfo(messageProvider, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 16399, 16456);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_180_16392_16457(Microsoft.CodeAnalysis.DiagnosticInfo
                info)
                {
                    var return_v = Create(info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 16392, 16457);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 16246, 16469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 16246, 16469);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Diagnostic Create(DiagnosticInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(180, 16481, 16622);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 16560, 16611);

                return f_180_16567_16610(info, f_180_16596_16609());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(180, 16481, 16622);

                Microsoft.CodeAnalysis.Location
                f_180_16596_16609()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 16596, 16609);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticWithInfo
                f_180_16567_16610(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticWithInfo(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 16567, 16610);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 16481, 16622);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 16481, 16622);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract DiagnosticDescriptor Descriptor { get; }

        public abstract string Id { get; }

        internal virtual string Category
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(180, 17302, 17342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 17308, 17340);

                    return f_180_17315_17339(f_180_17315_17330(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(180, 17302, 17342);

                    Microsoft.CodeAnalysis.DiagnosticDescriptor
                    f_180_17315_17330(Microsoft.CodeAnalysis.Diagnostic
                    this_param)
                    {
                        var return_v = this_param.Descriptor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 17315, 17330);
                        return return_v;
                    }


                    string
                    f_180_17315_17339(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Category;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 17315, 17339);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 17267, 17344);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 17267, 17344);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract string GetMessage(IFormatProvider? formatProvider = null);

        public virtual DiagnosticSeverity DefaultSeverity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(180, 17903, 17950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 17909, 17948);

                    return f_180_17916_17947(f_180_17916_17931(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(180, 17903, 17950);

                    Microsoft.CodeAnalysis.DiagnosticDescriptor
                    f_180_17916_17931(Microsoft.CodeAnalysis.Diagnostic
                    this_param)
                    {
                        var return_v = this_param.Descriptor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 17916, 17931);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_180_17916_17947(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.DefaultSeverity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 17916, 17947);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 17851, 17952);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 17851, 17952);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract DiagnosticSeverity Severity { get; }

        public abstract int WarningLevel { get; }

        public abstract bool IsSuppressed { get; }

        public SuppressionInfo? GetSuppressionInfo(Compilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(180, 19127, 19692);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 19219, 19297) || true) && (f_180_19223_19236_M(!IsSuppressed))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(180, 19219, 19297);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 19270, 19282);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(180, 19219, 19297);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 19313, 19338);

                AttributeData?
                attribute
                = default(AttributeData?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 19352, 19426);

                var
                suppressMessageState = f_180_19379_19425(compilation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 19440, 19618) || true) && (!f_180_19445_19552(suppressMessageState, this, out attribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(180, 19440, 19618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 19586, 19603);

                    attribute = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(180, 19440, 19618);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 19634, 19681);

                return f_180_19641_19680(f_180_19661_19668(this), attribute);
                DynAbs.Tracing.TraceSender.TraceExitMethod(180, 19127, 19692);

                bool
                f_180_19223_19236_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 19223, 19236);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState
                f_180_19379_19425(Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 19379, 19425);
                    return return_v;
                }


                bool
                f_180_19445_19552(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diagnostic, out Microsoft.CodeAnalysis.AttributeData?
                suppressingAttribute)
                {
                    var return_v = this_param.IsDiagnosticSuppressed(diagnostic, out suppressingAttribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 19445, 19552);
                    return return_v;
                }


                string
                f_180_19661_19668(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 19661, 19668);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SuppressionInfo
                f_180_19641_19680(string
                id, Microsoft.CodeAnalysis.AttributeData?
                attribute)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SuppressionInfo(id, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 19641, 19680);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 19127, 19692);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 19127, 19692);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool IsEnabledByDefault
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(180, 19894, 19944);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 19900, 19942);

                    return f_180_19907_19941(f_180_19907_19922(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(180, 19894, 19944);

                    Microsoft.CodeAnalysis.DiagnosticDescriptor
                    f_180_19907_19922(Microsoft.CodeAnalysis.Diagnostic
                    this_param)
                    {
                        var return_v = this_param.Descriptor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 19907, 19922);
                        return return_v;
                    }


                    bool
                    f_180_19907_19941(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.IsEnabledByDefault;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 19907, 19941);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 19851, 19946);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 19851, 19946);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsWarningAsError
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(180, 20371, 20546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 20407, 20531);

                    return f_180_20414_20434(this) == DiagnosticSeverity.Warning && (DynAbs.Tracing.TraceSender.Expression_True(180, 20414, 20530) && f_180_20489_20502(this) == DiagnosticSeverity.Error);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(180, 20371, 20546);

                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_180_20414_20434(Microsoft.CodeAnalysis.Diagnostic
                    this_param)
                    {
                        var return_v = this_param.DefaultSeverity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 20414, 20434);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_180_20489_20502(Microsoft.CodeAnalysis.Diagnostic
                    this_param)
                    {
                        var return_v = this_param.Severity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 20489, 20502);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 20318, 20557);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 20318, 20557);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract Location Location { get; }

        public abstract IReadOnlyList<Location> AdditionalLocations { get; }

        internal virtual IReadOnlyList<string> CustomTags
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(180, 21226, 21291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 21232, 21289);

                    return (IReadOnlyList<string>)f_180_21262_21288(f_180_21262_21277(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(180, 21226, 21291);

                    Microsoft.CodeAnalysis.DiagnosticDescriptor
                    f_180_21262_21277(Microsoft.CodeAnalysis.Diagnostic
                    this_param)
                    {
                        var return_v = this_param.Descriptor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 21262, 21277);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<string>
                    f_180_21262_21288(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.CustomTags;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 21262, 21288);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 21174, 21293);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 21174, 21293);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual ImmutableDictionary<string, string?> Properties
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(180, 21716, 21761);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 21719, 21761);
                    return ImmutableDictionary<string, string?>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(180, 21716, 21761);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 21716, 21761);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 21716, 21761);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        string IFormattable.ToString(string? ignored, IFormatProvider? formatProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(180, 21774, 21953);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 21877, 21942);

                return f_180_21884_21941(DiagnosticFormatter.Instance, this, formatProvider);
                DynAbs.Tracing.TraceSender.TraceExitMethod(180, 21774, 21953);

                string
                f_180_21884_21941(Microsoft.CodeAnalysis.DiagnosticFormatter
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diagnostic, System.IFormatProvider?
                formatter)
                {
                    var return_v = this_param.Format(diagnostic, formatter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 21884, 21941);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 21774, 21953);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 21774, 21953);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(180, 21965, 22113);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 22023, 22102);

                return f_180_22030_22101(DiagnosticFormatter.Instance, this, f_180_22072_22100());
                DynAbs.Tracing.TraceSender.TraceExitMethod(180, 21965, 22113);

                System.Globalization.CultureInfo
                f_180_22072_22100()
                {
                    var return_v = CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 22072, 22100);
                    return return_v;
                }


                string
                f_180_22030_22101(Microsoft.CodeAnalysis.DiagnosticFormatter
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diagnostic, System.Globalization.CultureInfo
                formatter)
                {
                    var return_v = this_param.Format(diagnostic, (System.IFormatProvider)formatter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 22030, 22101);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 21965, 22113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 21965, 22113);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract override bool Equals(object? obj);

        public abstract override int GetHashCode();

        public abstract bool Equals(Diagnostic? obj);

        private string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(180, 22299, 23099);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 22359, 23088);

                switch (f_180_22367_22380(this))
                {

                    case InternalDiagnosticSeverity.Unknown:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(180, 22359, 23088);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 22687, 22738);

                        return "Unresolved diagnostic at " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_180_22724_22737(this)).ToString(), 180, 22724, 22737);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(180, 22359, 23088);

                    case InternalDiagnosticSeverity.Void:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(180, 22359, 23088);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 22960, 23005);

                        return "Void diagnostic at " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_180_22991_23004(this)).ToString(), 180, 22991, 23004);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(180, 22359, 23088);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(180, 22359, 23088);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 23055, 23073);

                        return f_180_23062_23072(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(180, 22359, 23088);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(180, 22299, 23099);

                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_180_22367_22380(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 22367, 22380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_180_22724_22737(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 22724, 22737);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_180_22991_23004(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 22991, 23004);
                    return return_v;
                }


                string
                f_180_23062_23072(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 23062, 23072);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 22299, 23099);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 22299, 23099);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract Diagnostic WithLocation(Location location);

        internal abstract Diagnostic WithSeverity(DiagnosticSeverity severity);

        internal abstract Diagnostic WithIsSuppressed(bool isSuppressed);

        internal Diagnostic WithProgrammaticSuppression(ProgrammaticSuppressionInfo programmaticSuppressionInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(180, 23901, 24272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 24030, 24091);

                f_180_24030_24090(f_180_24049_24081(this) == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 24105, 24161);

                f_180_24105_24160(programmaticSuppressionInfo != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 24177, 24261);

                return f_180_24184_24260(this, programmaticSuppressionInfo);
                DynAbs.Tracing.TraceSender.TraceExitMethod(180, 23901, 24272);

                Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo?
                f_180_24049_24081(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.ProgrammaticSuppressionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 24049, 24081);
                    return return_v;
                }


                int
                f_180_24030_24090(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 24030, 24090);
                    return 0;
                }


                int
                f_180_24105_24160(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 24105, 24160);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostic.DiagnosticWithProgrammaticSuppression
                f_180_24184_24260(Microsoft.CodeAnalysis.Diagnostic
                originalUnsuppressedDiagnostic, Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo
                programmaticSuppressionInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostic.DiagnosticWithProgrammaticSuppression(originalUnsuppressedDiagnostic, programmaticSuppressionInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 24184, 24260);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 23901, 24272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 23901, 24272);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual ProgrammaticSuppressionInfo? ProgrammaticSuppressionInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(180, 24360, 24380);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 24366, 24378);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(180, 24360, 24380);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 24284, 24382);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 24284, 24382);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual int Code
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(180, 24448, 24465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 24454, 24463);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(180, 24448, 24465);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 24420, 24467);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 24420, 24467);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual IReadOnlyList<object?> Arguments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(180, 24553, 24620);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 24559, 24618);

                    return f_180_24566_24617();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(180, 24553, 24620);

                    System.Collections.Generic.IReadOnlyList<object?>
                    f_180_24566_24617()
                    {
                        var return_v = SpecializedCollections.EmptyReadOnlyList<object?>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 24566, 24617);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 24479, 24631);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 24479, 24631);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [PerformanceSensitive(
                    "https://github.com/dotnet/roslyn/issues/26778",
                    Constraint = "In most cases, AdditionalLocations is empty.",
                    AllowCaptures = false)]
        internal bool HasIntersectingLocation(SyntaxTree tree, TextSpan? filterSpanWithinTree = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(180, 24856, 26202);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 25179, 25302) || true) && (f_180_25183_25241(f_180_25204_25212(), tree, filterSpanWithinTree))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(180, 25179, 25302);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 25275, 25287);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(180, 25179, 25302);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 25318, 25541) || true) && (f_180_25322_25341() is null || (DynAbs.Tracing.TraceSender.Expression_False(180, 25322, 25383) || f_180_25353_25378(f_180_25353_25372()) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(180, 25318, 25541);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 25513, 25526);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(180, 25318, 25541);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 25557, 25785);
                    foreach (var location in f_180_25582_25601_I(f_180_25582_25601()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(180, 25557, 25785);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 25635, 25770) || true) && (f_180_25639_25697(location, tree, filterSpanWithinTree))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(180, 25635, 25770);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 25739, 25751);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(180, 25635, 25770);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(180, 25557, 25785);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(180, 1, 229);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(180, 1, 229);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 25801, 25814);

                return false;

                static bool isLocationWithinSpan(Location location, SyntaxTree tree, TextSpan? filterSpan)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(180, 25830, 26191);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 25953, 26058) || true) && (f_180_25957_25976(location) != tree)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(180, 25953, 26058);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 26026, 26039);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(180, 25953, 26058);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 26078, 26176);

                        return f_180_26085_26105_M(!filterSpan.HasValue) || (DynAbs.Tracing.TraceSender.Expression_False(180, 26085, 26175) || filterSpan.GetValueOrDefault().IntersectsWith(f_180_26155_26174(location)));
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(180, 25830, 26191);

                        Microsoft.CodeAnalysis.SyntaxTree?
                        f_180_25957_25976(Microsoft.CodeAnalysis.Location
                        this_param)
                        {
                            var return_v = this_param.SourceTree;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 25957, 25976);
                            return return_v;
                        }


                        bool
                        f_180_26085_26105_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 26085, 26105);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Text.TextSpan
                        f_180_26155_26174(Microsoft.CodeAnalysis.Location
                        this_param)
                        {
                            var return_v = this_param.SourceSpan;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 26155, 26174);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 25830, 26191);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 25830, 26191);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(180, 24856, 26202);

                Microsoft.CodeAnalysis.Location
                f_180_25204_25212()
                {
                    var return_v = Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 25204, 25212);
                    return return_v;
                }


                bool
                f_180_25183_25241(Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.Text.TextSpan?
                filterSpan)
                {
                    var return_v = isLocationWithinSpan(location, tree, filterSpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 25183, 25241);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>?
                f_180_25322_25341()
                {
                    var return_v = AdditionalLocations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 25322, 25341);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                f_180_25353_25372()
                {
                    var return_v = AdditionalLocations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 25353, 25372);
                    return return_v;
                }


                int
                f_180_25353_25378(System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 25353, 25378);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                f_180_25582_25601()
                {
                    var return_v = AdditionalLocations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 25582, 25601);
                    return return_v;
                }


                bool
                f_180_25639_25697(Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.Text.TextSpan?
                filterSpan)
                {
                    var return_v = isLocationWithinSpan(location, tree, filterSpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 25639, 25697);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                f_180_25582_25601_I(System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 25582, 25601);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 24856, 26202);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 24856, 26202);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Diagnostic? WithReportDiagnostic(ReportDiagnostic reportAction)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(180, 26214, 27165);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 26311, 27154);

                switch (reportAction)
                {

                    case ReportDiagnostic.Suppress:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(180, 26311, 27154);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 26465, 26477);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(180, 26311, 27154);

                    case ReportDiagnostic.Error:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(180, 26311, 27154);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 26545, 26596);

                        return f_180_26552_26595(this, DiagnosticSeverity.Error);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(180, 26311, 27154);

                    case ReportDiagnostic.Default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(180, 26311, 27154);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 26666, 26678);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(180, 26311, 27154);

                    case ReportDiagnostic.Warn:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(180, 26311, 27154);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 26745, 26798);

                        return f_180_26752_26797(this, DiagnosticSeverity.Warning);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(180, 26311, 27154);

                    case ReportDiagnostic.Info:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(180, 26311, 27154);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 26865, 26915);

                        return f_180_26872_26914(this, DiagnosticSeverity.Info);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(180, 26311, 27154);

                    case ReportDiagnostic.Hidden:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(180, 26311, 27154);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 26984, 27036);

                        return f_180_26991_27035(this, DiagnosticSeverity.Hidden);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(180, 26311, 27154);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(180, 26311, 27154);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 27084, 27139);

                        throw f_180_27090_27138(reportAction);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(180, 26311, 27154);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(180, 26214, 27165);

                Microsoft.CodeAnalysis.Diagnostic
                f_180_26552_26595(Microsoft.CodeAnalysis.Diagnostic
                this_param, Microsoft.CodeAnalysis.DiagnosticSeverity
                severity)
                {
                    var return_v = this_param.WithSeverity(severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 26552, 26595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_180_26752_26797(Microsoft.CodeAnalysis.Diagnostic
                this_param, Microsoft.CodeAnalysis.DiagnosticSeverity
                severity)
                {
                    var return_v = this_param.WithSeverity(severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 26752, 26797);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_180_26872_26914(Microsoft.CodeAnalysis.Diagnostic
                this_param, Microsoft.CodeAnalysis.DiagnosticSeverity
                severity)
                {
                    var return_v = this_param.WithSeverity(severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 26872, 26914);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_180_26991_27035(Microsoft.CodeAnalysis.Diagnostic
                this_param, Microsoft.CodeAnalysis.DiagnosticSeverity
                severity)
                {
                    var return_v = this_param.WithSeverity(severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 26991, 27035);
                    return return_v;
                }


                System.Exception
                f_180_27090_27138(Microsoft.CodeAnalysis.ReportDiagnostic
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 27090, 27138);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 26214, 27165);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 26214, 27165);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int GetDefaultWarningLevel(DiagnosticSeverity severity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(180, 28153, 28495);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 28249, 28484);

                switch (severity)
                {

                    case DiagnosticSeverity.Error:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(180, 28249, 28484);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 28351, 28360);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(180, 28249, 28484);

                    case DiagnosticSeverity.Warning:
                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(180, 28249, 28484);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 28460, 28469);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(180, 28249, 28484);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(180, 28153, 28495);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 28153, 28495);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 28153, 28495);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool IsNotConfigurable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(180, 28756, 28895);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 28822, 28884);

                return f_180_28829_28883(f_180_28867_28882(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(180, 28756, 28895);

                System.Collections.Generic.IReadOnlyList<string>
                f_180_28867_28882(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.CustomTags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 28867, 28882);
                    return return_v;
                }


                bool
                f_180_28829_28883(System.Collections.Generic.IReadOnlyList<string>
                customTags)
                {
                    var return_v = AnalyzerManager.HasNotConfigurableTag((System.Collections.Generic.IEnumerable<string>)customTags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 28829, 28883);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 28756, 28895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 28756, 28895);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsUnsuppressableError()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(180, 29404, 29473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 29407, 29473);
                return f_180_29407_29422() == DiagnosticSeverity.Error && (DynAbs.Tracing.TraceSender.Expression_True(180, 29407, 29473) && f_180_29454_29473(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(180, 29404, 29473);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 29404, 29473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 29404, 29473);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.DiagnosticSeverity
            f_180_29407_29422()
            {
                var return_v = DefaultSeverity;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 29407, 29422);
                return return_v;
            }


            bool
            f_180_29454_29473(Microsoft.CodeAnalysis.Diagnostic
            this_param)
            {
                var return_v = this_param.IsNotConfigurable();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 29454, 29473);
                return return_v;
            }

        }

        internal bool IsUnsuppressedError
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(180, 29677, 29733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 29680, 29733);
                    return f_180_29680_29688() == DiagnosticSeverity.Error && (DynAbs.Tracing.TraceSender.Expression_True(180, 29680, 29733) && f_180_29720_29733_M(!IsSuppressed)); DynAbs.Tracing.TraceSender.TraceExitMethod(180, 29677, 29733);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 29677, 29733);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 29677, 29733);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Diagnostic()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(180, 653, 29741);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(180, 653, 29741);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 653, 29741);
        }


        static Diagnostic()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(180, 653, 29741);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 825, 864);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 1029, 1052);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 1321, 1350);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 1506, 1528);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(180, 653, 29741);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 653, 29741);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(180, 653, 29741);

        Microsoft.CodeAnalysis.DiagnosticSeverity
        f_180_29680_29688()
        {
            var return_v = Severity;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 29680, 29688);
            return return_v;
        }


        bool
        f_180_29720_29733_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(180, 29720, 29733);
            return return_v;
        }

    }
    internal abstract class RequiredLanguageVersion : IFormattable
    {
        public abstract override string ToString();

        string IFormattable.ToString(string? format, IFormatProvider? formatProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(180, 30132, 30263);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(180, 30234, 30252);

                return f_180_30241_30251(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(180, 30132, 30263);

                string
                f_180_30241_30251(Microsoft.CodeAnalysis.RequiredLanguageVersion
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(180, 30241, 30251);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(180, 30132, 30263);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 30132, 30263);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public RequiredLanguageVersion()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(180, 29998, 30270);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(180, 29998, 30270);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 29998, 30270);
        }


        static RequiredLanguageVersion()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(180, 29998, 30270);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(180, 29998, 30270);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(180, 29998, 30270);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(180, 29998, 30270);
    }
}
