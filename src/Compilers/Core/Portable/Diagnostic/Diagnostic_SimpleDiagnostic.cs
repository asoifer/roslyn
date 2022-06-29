// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public abstract partial class Diagnostic
    {
        internal sealed class SimpleDiagnostic : Diagnostic
        {
            private readonly DiagnosticDescriptor _descriptor;

            private readonly DiagnosticSeverity _severity;

            private readonly int _warningLevel;

            private readonly Location _location;

            private readonly IReadOnlyList<Location> _additionalLocations;

            private readonly object?[] _messageArgs;

            private readonly ImmutableDictionary<string, string?> _properties;

            private readonly bool _isSuppressed;

            private SimpleDiagnostic(
                            DiagnosticDescriptor descriptor,
                            DiagnosticSeverity severity,
                            int warningLevel,
                            Location location,
                            IEnumerable<Location>? additionalLocations,
                            object?[]? messageArgs,
                            ImmutableDictionary<string, string?>? properties,
                            bool isSuppressed)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(188, 1189, 2774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 742, 753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 804, 813);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 849, 862);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 903, 912);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 968, 988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 1030, 1042);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 1111, 1122);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 1159, 1172);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 1619, 1977) || true) && ((warningLevel == 0 && (DynAbs.Tracing.TraceSender.Expression_True(188, 1624, 1681) && severity != DiagnosticSeverity.Error)) || (DynAbs.Tracing.TraceSender.Expression_False(188, 1623, 1766) || (warningLevel != 0 && (DynAbs.Tracing.TraceSender.Expression_True(188, 1708, 1765) && severity == DiagnosticSeverity.Error))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(188, 1619, 1977);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 1808, 1958);

                        throw f_188_1814_1957($"{nameof(warningLevel)} ({warningLevel}) and {nameof(severity)} ({severity}) are not compatible.", nameof(warningLevel));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(188, 1619, 1977);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 1997, 2077);

                    _descriptor = descriptor ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.DiagnosticDescriptor>(188, 2011, 2076) ?? throw f_188_2031_2076(nameof(descriptor)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 2095, 2116);

                    _severity = severity;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 2134, 2163);

                    _warningLevel = warningLevel;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 2181, 2219);

                    _location = location ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Location>(188, 2193, 2218) ?? f_188_2205_2218());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 2403, 2552);

                    _additionalLocations = ((DynAbs.Tracing.TraceSender.Conditional_F1(188, 2427, 2454) || ((additionalLocations != null && DynAbs.Tracing.TraceSender.Conditional_F2(188, 2457, 2495)) || DynAbs.Tracing.TraceSender.Conditional_F3(188, 2498, 2550))) ? f_188_2457_2495(additionalLocations) : f_188_2498_2550());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 2570, 2623);

                    _messageArgs = messageArgs ?? (DynAbs.Tracing.TraceSender.Expression_Null<object?[]?>(188, 2585, 2622) ?? f_188_2600_2622());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 2641, 2712);

                    _properties = properties ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableDictionary<string, string?>?>(188, 2655, 2711) ?? ImmutableDictionary<string, string?>.Empty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 2730, 2759);

                    _isSuppressed = isSuppressed;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(188, 1189, 2774);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(188, 1189, 2774);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(188, 1189, 2774);
                }
            }

            internal static SimpleDiagnostic Create(
                            DiagnosticDescriptor descriptor,
                            DiagnosticSeverity severity,
                            int warningLevel,
                            Location location,
                            IEnumerable<Location>? additionalLocations,
                            object?[]? messageArgs,
                            ImmutableDictionary<string, string?>? properties,
                            bool isSuppressed = false)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(188, 2790, 3392);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 3243, 3377);

                    return f_188_3250_3376(descriptor, severity, warningLevel, location, additionalLocations, messageArgs, properties, isSuppressed);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(188, 2790, 3392);

                    Microsoft.CodeAnalysis.Diagnostic.SimpleDiagnostic
                    f_188_3250_3376(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    descriptor, Microsoft.CodeAnalysis.DiagnosticSeverity
                    severity, int
                    warningLevel, Microsoft.CodeAnalysis.Location
                    location, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Location>?
                    additionalLocations, object?[]?
                    messageArgs, System.Collections.Immutable.ImmutableDictionary<string, string?>?
                    properties, bool
                    isSuppressed)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Diagnostic.SimpleDiagnostic(descriptor, severity, warningLevel, location, additionalLocations, messageArgs, properties, isSuppressed);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 3250, 3376);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(188, 2790, 3392);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(188, 2790, 3392);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal static SimpleDiagnostic Create(string id, LocalizableString title, string category, LocalizableString message, LocalizableString description, string helpLink,
                                                  DiagnosticSeverity severity, DiagnosticSeverity defaultSeverity,
                                                  bool isEnabledByDefault, int warningLevel, Location location,
                                                  IEnumerable<Location>? additionalLocations, IEnumerable<string>? customTags,
                                                  ImmutableDictionary<string, string?>? properties, bool isSuppressed = false)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(188, 3408, 4436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 4045, 4237);

                    var
                    descriptor = f_188_4062_4236(id, title, message, category, defaultSeverity, isEnabledByDefault, description, helpLink, f_188_4199_4235(customTags))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 4255, 4421);

                    return f_188_4262_4420(descriptor, severity, warningLevel, location, additionalLocations, messageArgs: null, properties: properties, isSuppressed: isSuppressed);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(188, 3408, 4436);

                    System.Collections.Immutable.ImmutableArray<string>
                    f_188_4199_4235(System.Collections.Generic.IEnumerable<string>?
                    items)
                    {
                        var return_v = items.ToImmutableArrayOrEmpty<string>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 4199, 4235);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticDescriptor
                    f_188_4062_4236(string
                    id, Microsoft.CodeAnalysis.LocalizableString
                    title, Microsoft.CodeAnalysis.LocalizableString
                    messageFormat, string
                    category, Microsoft.CodeAnalysis.DiagnosticSeverity
                    defaultSeverity, bool
                    isEnabledByDefault, Microsoft.CodeAnalysis.LocalizableString
                    description, string
                    helpLinkUri, System.Collections.Immutable.ImmutableArray<string>
                    customTags)
                    {
                        var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault, description, helpLinkUri, customTags);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 4062, 4236);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostic.SimpleDiagnostic
                    f_188_4262_4420(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    descriptor, Microsoft.CodeAnalysis.DiagnosticSeverity
                    severity, int
                    warningLevel, Microsoft.CodeAnalysis.Location
                    location, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Location>?
                    additionalLocations, object?[]?
                    messageArgs, System.Collections.Immutable.ImmutableDictionary<string, string?>?
                    properties, bool
                    isSuppressed)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Diagnostic.SimpleDiagnostic(descriptor, severity, warningLevel, location, additionalLocations, messageArgs: messageArgs, properties: properties, isSuppressed: isSuppressed);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 4262, 4420);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(188, 3408, 4436);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(188, 3408, 4436);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override DiagnosticDescriptor Descriptor
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(188, 4532, 4559);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 4538, 4557);

                        return _descriptor;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(188, 4532, 4559);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(188, 4452, 4574);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(188, 4452, 4574);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(188, 4648, 4678);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 4654, 4676);

                        return f_188_4661_4675(_descriptor);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(188, 4648, 4678);

                        string
                        f_188_4661_4675(Microsoft.CodeAnalysis.DiagnosticDescriptor
                        this_param)
                        {
                            var return_v = this_param.Id;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(188, 4661, 4675);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(188, 4590, 4693);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(188, 4590, 4693);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override string GetMessage(IFormatProvider? formatProvider = null)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(188, 4709, 5484);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 4815, 4962) || true) && (f_188_4819_4838(_messageArgs) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(188, 4815, 4962);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 4885, 4943);

                        return f_188_4892_4942(f_188_4892_4917(_descriptor), formatProvider);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(188, 4815, 4962);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 4982, 5062);

                    var
                    localizedMessageFormat = f_188_5011_5061(f_188_5011_5036(_descriptor), formatProvider)
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 5126, 5201);

                        return f_188_5133_5200(formatProvider, localizedMessageFormat, _messageArgs);
                    }
                    catch (Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(188, 5238, 5469);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 5420, 5450);

                        return localizedMessageFormat;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(188, 5238, 5469);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(188, 4709, 5484);

                    int
                    f_188_4819_4838(object?[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(188, 4819, 4838);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.LocalizableString
                    f_188_4892_4917(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.MessageFormat;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(188, 4892, 4917);
                        return return_v;
                    }


                    string
                    f_188_4892_4942(Microsoft.CodeAnalysis.LocalizableString
                    this_param, System.IFormatProvider?
                    formatProvider)
                    {
                        var return_v = this_param.ToString(formatProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 4892, 4942);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.LocalizableString
                    f_188_5011_5036(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.MessageFormat;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(188, 5011, 5036);
                        return return_v;
                    }


                    string
                    f_188_5011_5061(Microsoft.CodeAnalysis.LocalizableString
                    this_param, System.IFormatProvider?
                    formatProvider)
                    {
                        var return_v = this_param.ToString(formatProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 5011, 5061);
                        return return_v;
                    }


                    string
                    f_188_5133_5200(System.IFormatProvider?
                    provider, string
                    format, params object?[]
                    args)
                    {
                        var return_v = string.Format(provider, format, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 5133, 5200);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(188, 4709, 5484);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(188, 4709, 5484);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override IReadOnlyList<object?> Arguments
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(188, 5583, 5611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 5589, 5609);

                        return _messageArgs;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(188, 5583, 5611);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(188, 5500, 5626);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(188, 5500, 5626);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(188, 5718, 5743);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 5724, 5741);

                        return _severity;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(188, 5718, 5743);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(188, 5642, 5758);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(188, 5642, 5758);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(188, 5840, 5869);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 5846, 5867);

                        return _isSuppressed;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(188, 5840, 5869);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(188, 5774, 5884);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(188, 5774, 5884);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(188, 5965, 5994);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 5971, 5992);

                        return _warningLevel;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(188, 5965, 5994);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(188, 5900, 6009);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(188, 5900, 6009);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(188, 6091, 6116);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 6097, 6114);

                        return _location;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(188, 6091, 6116);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(188, 6025, 6131);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(188, 6025, 6131);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(188, 6239, 6275);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 6245, 6273);

                        return _additionalLocations;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(188, 6239, 6275);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(188, 6147, 6290);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(188, 6147, 6290);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(188, 6402, 6429);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 6408, 6427);

                        return _properties;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(188, 6402, 6429);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(188, 6306, 6444);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(188, 6306, 6444);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool Equals(Diagnostic? obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(188, 6460, 7460);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 6537, 6640) || true) && (f_188_6541_6567(this, obj))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(188, 6537, 6640);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 6609, 6621);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(188, 6537, 6640);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 6660, 6696);

                    var
                    other = obj as SimpleDiagnostic
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 6714, 6805) || true) && (other == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(188, 6714, 6805);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 6773, 6786);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(188, 6714, 6805);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 6825, 7124) || true) && (f_188_6829_6881(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(188, 6825, 7124);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 7026, 7105);

                        return f_188_7033_7104(this, other);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(188, 6825, 7124);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 7144, 7445);

                    return f_188_7151_7188(_descriptor, other._descriptor) && (DynAbs.Tracing.TraceSender.Expression_True(188, 7151, 7277) && f_188_7213_7277(_messageArgs, other._messageArgs, (a, b) => a == b)) && (DynAbs.Tracing.TraceSender.Expression_True(188, 7151, 7330) && _location == other._location
                    ) && (DynAbs.Tracing.TraceSender.Expression_True(188, 7151, 7383) && _severity == other._severity
                    ) && (DynAbs.Tracing.TraceSender.Expression_True(188, 7151, 7444) && _warningLevel == other._warningLevel);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(188, 6460, 7460);

                    bool
                    f_188_6541_6567(Microsoft.CodeAnalysis.Diagnostic.SimpleDiagnostic
                    objA, Microsoft.CodeAnalysis.Diagnostic?
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object?)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 6541, 6567);
                        return return_v;
                    }


                    bool
                    f_188_6829_6881(Microsoft.CodeAnalysis.Diagnostic.SimpleDiagnostic
                    diagnostic)
                    {
                        var return_v = AnalyzerExecutor.IsAnalyzerExceptionDiagnostic((Microsoft.CodeAnalysis.Diagnostic)diagnostic);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 6829, 6881);
                        return return_v;
                    }


                    bool
                    f_188_7033_7104(Microsoft.CodeAnalysis.Diagnostic.SimpleDiagnostic
                    exceptionDiagnostic, Microsoft.CodeAnalysis.Diagnostic.SimpleDiagnostic
                    other)
                    {
                        var return_v = AnalyzerExecutor.AreEquivalentAnalyzerExceptionDiagnostics((Microsoft.CodeAnalysis.Diagnostic)exceptionDiagnostic, (Microsoft.CodeAnalysis.Diagnostic)other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 7033, 7104);
                        return return_v;
                    }


                    bool
                    f_188_7151_7188(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param, Microsoft.CodeAnalysis.DiagnosticDescriptor
                    other)
                    {
                        var return_v = this_param.Equals(other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 7151, 7188);
                        return return_v;
                    }


                    bool
                    f_188_7213_7277(object?[]
                    first, object?[]
                    second, System.Func<object, object, bool>
                    comparer)
                    {
                        var return_v = first.SequenceEqual<object?>((System.Collections.Generic.IEnumerable<object>)second, comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 7213, 7277);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(188, 6460, 7460);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(188, 6460, 7460);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(object? obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(188, 7476, 7602);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 7549, 7587);

                    return f_188_7556_7586(this, obj as Diagnostic);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(188, 7476, 7602);

                    bool
                    f_188_7556_7586(Microsoft.CodeAnalysis.Diagnostic.SimpleDiagnostic
                    this_param, object?
                    obj)
                    {
                        var return_v = this_param.Equals((Microsoft.CodeAnalysis.Diagnostic?)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 7556, 7586);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(188, 7476, 7602);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(188, 7476, 7602);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(188, 7618, 7899);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 7684, 7884);

                    return f_188_7691_7883(_descriptor, f_188_7738_7882(_messageArgs, f_188_7792_7881(_warningLevel, f_188_7841_7880(_location, _severity))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(188, 7618, 7899);

                    int
                    f_188_7841_7880(Microsoft.CodeAnalysis.Location
                    newKeyPart, Microsoft.CodeAnalysis.DiagnosticSeverity
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKeyPart, (int)currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 7841, 7880);
                        return return_v;
                    }


                    int
                    f_188_7792_7881(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 7792, 7881);
                        return return_v;
                    }


                    int
                    f_188_7738_7882(object?[]
                    values, int
                    maxItemsToHash)
                    {
                        var return_v = Hash.CombineValues(values, maxItemsToHash);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 7738, 7882);
                        return return_v;
                    }


                    int
                    f_188_7691_7883(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    newKeyPart, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKeyPart, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 7691, 7883);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(188, 7618, 7899);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(188, 7618, 7899);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override Diagnostic WithLocation(Location location)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(188, 7915, 8433);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 8008, 8139) || true) && (location is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(188, 8008, 8139);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 8070, 8120);

                        throw f_188_8076_8119(nameof(location));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(188, 8008, 8139);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 8159, 8386) || true) && (location != _location)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(188, 8159, 8386);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 8226, 8367);

                        return f_188_8233_8366(_descriptor, _severity, _warningLevel, location, _additionalLocations, _messageArgs, _properties, _isSuppressed);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(188, 8159, 8386);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 8406, 8418);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(188, 7915, 8433);

                    System.ArgumentNullException
                    f_188_8076_8119(string
                    paramName)
                    {
                        var return_v = new System.ArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 8076, 8119);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostic.SimpleDiagnostic
                    f_188_8233_8366(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    descriptor, Microsoft.CodeAnalysis.DiagnosticSeverity
                    severity, int
                    warningLevel, Microsoft.CodeAnalysis.Location
                    location, System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                    additionalLocations, object?[]
                    messageArgs, System.Collections.Immutable.ImmutableDictionary<string, string?>
                    properties, bool
                    isSuppressed)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Diagnostic.SimpleDiagnostic(descriptor, severity, warningLevel, location, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Location>)additionalLocations, messageArgs, properties, isSuppressed);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 8233, 8366);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(188, 7915, 8433);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(188, 7915, 8433);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override Diagnostic WithSeverity(DiagnosticSeverity severity)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(188, 8449, 8903);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 8552, 8856) || true) && (f_188_8556_8569(this) != severity)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(188, 8552, 8856);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 8623, 8675);

                        var
                        warningLevel = f_188_8642_8674(severity)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 8697, 8837);

                        return f_188_8704_8836(_descriptor, severity, warningLevel, _location, _additionalLocations, _messageArgs, _properties, _isSuppressed);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(188, 8552, 8856);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 8876, 8888);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(188, 8449, 8903);

                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_188_8556_8569(Microsoft.CodeAnalysis.Diagnostic.SimpleDiagnostic
                    this_param)
                    {
                        var return_v = this_param.Severity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(188, 8556, 8569);
                        return return_v;
                    }


                    int
                    f_188_8642_8674(Microsoft.CodeAnalysis.DiagnosticSeverity
                    severity)
                    {
                        var return_v = GetDefaultWarningLevel(severity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 8642, 8674);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostic.SimpleDiagnostic
                    f_188_8704_8836(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    descriptor, Microsoft.CodeAnalysis.DiagnosticSeverity
                    severity, int
                    warningLevel, Microsoft.CodeAnalysis.Location
                    location, System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                    additionalLocations, object?[]
                    messageArgs, System.Collections.Immutable.ImmutableDictionary<string, string?>
                    properties, bool
                    isSuppressed)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Diagnostic.SimpleDiagnostic(descriptor, severity, warningLevel, location, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Location>)additionalLocations, messageArgs, properties, isSuppressed);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 8704, 8836);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(188, 8449, 8903);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(188, 8449, 8903);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override Diagnostic WithIsSuppressed(bool isSuppressed)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(188, 8919, 9302);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 9016, 9255) || true) && (f_188_9020_9037(this) != isSuppressed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(188, 9016, 9255);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 9095, 9236);

                        return f_188_9102_9235(_descriptor, _severity, _warningLevel, _location, _additionalLocations, _messageArgs, _properties, isSuppressed);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(188, 9016, 9255);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(188, 9275, 9287);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(188, 8919, 9302);

                    bool
                    f_188_9020_9037(Microsoft.CodeAnalysis.Diagnostic.SimpleDiagnostic
                    this_param)
                    {
                        var return_v = this_param.IsSuppressed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(188, 9020, 9037);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostic.SimpleDiagnostic
                    f_188_9102_9235(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    descriptor, Microsoft.CodeAnalysis.DiagnosticSeverity
                    severity, int
                    warningLevel, Microsoft.CodeAnalysis.Location
                    location, System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                    additionalLocations, object?[]
                    messageArgs, System.Collections.Immutable.ImmutableDictionary<string, string?>
                    properties, bool
                    isSuppressed)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Diagnostic.SimpleDiagnostic(descriptor, severity, warningLevel, location, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Location>)additionalLocations, messageArgs, properties, isSuppressed);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 9102, 9235);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(188, 8919, 9302);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(188, 8919, 9302);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static SimpleDiagnostic()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(188, 628, 9313);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(188, 628, 9313);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(188, 628, 9313);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(188, 628, 9313);

            static System.ArgumentException
            f_188_1814_1957(string
            message, string
            paramName)
            {
                var return_v = new System.ArgumentException(message, paramName);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 1814, 1957);
                return return_v;
            }


            static System.ArgumentNullException
            f_188_2031_2076(string
            paramName)
            {
                var return_v = new System.ArgumentNullException(paramName);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 2031, 2076);
                return return_v;
            }


            static Microsoft.CodeAnalysis.Location
            f_188_2205_2218()
            {
                var return_v = Location.None;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(188, 2205, 2218);
                return return_v;
            }


            static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
            f_188_2457_2495(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Location>
            items)
            {
                var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.Location>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 2457, 2495);
                return return_v;
            }


            static System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
            f_188_2498_2550()
            {
                var return_v = SpecializedCollections.EmptyReadOnlyList<Location>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 2498, 2550);
                return return_v;
            }


            static object?[]
            f_188_2600_2622()
            {
                var return_v = Array.Empty<object?>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(188, 2600, 2622);
                return return_v;
            }

        }
    }
}
