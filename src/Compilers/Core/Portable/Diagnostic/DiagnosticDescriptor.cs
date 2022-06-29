// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading;
using Microsoft.CodeAnalysis.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public sealed class DiagnosticDescriptor : IEquatable<DiagnosticDescriptor?>
    {
        public string Id { get; }

        public LocalizableString Title { get; }

        public LocalizableString Description { get; }

        public string HelpLinkUri { get; }

        public LocalizableString MessageFormat { get; }

        public string Category { get; }

        public DiagnosticSeverity DefaultSeverity { get; }

        public bool IsEnabledByDefault { get; }

        public IEnumerable<string> CustomTags { get; }

        public DiagnosticDescriptor(
                    string id,
                    string title,
                    string messageFormat,
                    string category,
                    DiagnosticSeverity defaultSeverity,
                    bool isEnabledByDefault,
                    string? description = null,
                    string? helpLinkUri = null,
                    params string[] customTags)
        : this(f_183_4514_4516_C(id), title, messageFormat, category, defaultSeverity, isEnabledByDefault, description, helpLinkUri, f_183_4613_4644(customTags))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(183, 4139, 4667);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(183, 4139, 4667);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(183, 4139, 4667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(183, 4139, 4667);
            }
        }

        public DiagnosticDescriptor(
                    string id,
                    LocalizableString title,
                    LocalizableString messageFormat,
                    string category,
                    DiagnosticSeverity defaultSeverity,
                    bool isEnabledByDefault,
                    LocalizableString? description = null,
                    string? helpLinkUri = null,
                    params string[] customTags)
        : this(f_183_7516_7518_C(id), title, messageFormat, category, defaultSeverity, isEnabledByDefault, description, helpLinkUri, f_183_7615_7646(customTags))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(183, 7108, 7669);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(183, 7108, 7669);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(183, 7108, 7669);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(183, 7108, 7669);
            }
        }

        internal DiagnosticDescriptor(
                    string id,
                    LocalizableString title,
                    LocalizableString messageFormat,
                    string category,
                    DiagnosticSeverity defaultSeverity,
                    bool isEnabledByDefault,
                    LocalizableString? description,
                    string? helpLinkUri,
                    ImmutableArray<string> customTags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(183, 7681, 9115);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 729, 754);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 879, 918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 1053, 1098);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 1258, 1292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 1584, 1631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 1761, 1792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 1904, 1954);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 2080, 2119);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 2223, 2269);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 8088, 8268) || true) && (f_183_8092_8121(id))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(183, 8088, 8268);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 8155, 8253);

                    throw f_183_8161_8252(f_183_8183_8239(), nameof(id));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(183, 8088, 8268);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 8284, 8413) || true) && (messageFormat == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(183, 8284, 8413);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 8343, 8398);

                    throw f_183_8349_8397(nameof(messageFormat));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(183, 8284, 8413);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 8429, 8548) || true) && (category == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(183, 8429, 8548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 8483, 8533);

                    throw f_183_8489_8532(nameof(category));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(183, 8429, 8548);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 8564, 8677) || true) && (title == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(183, 8564, 8677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 8615, 8662);

                    throw f_183_8621_8661(nameof(title));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(183, 8564, 8677);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 8693, 8706);

                this.Id = id;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 8720, 8739);

                this.Title = title;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 8753, 8778);

                this.Category = category;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 8792, 8827);

                this.MessageFormat = messageFormat;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 8841, 8880);

                this.DefaultSeverity = defaultSeverity;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 8894, 8939);

                this.IsEnabledByDefault = isEnabledByDefault;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 8953, 9000);

                this.Description = description ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.LocalizableString?>(183, 8972, 8999) ?? string.Empty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 9014, 9061);

                this.HelpLinkUri = helpLinkUri ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(183, 9033, 9060) ?? string.Empty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 9075, 9104);

                this.CustomTags = customTags;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(183, 7681, 9115);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(183, 7681, 9115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(183, 7681, 9115);
            }
        }

        public bool Equals(DiagnosticDescriptor? other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(183, 9127, 9826);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 9199, 9292) || true) && (f_183_9203_9231(this, other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(183, 9199, 9292);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 9265, 9277);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(183, 9199, 9292);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 9308, 9815);

                return
                                other != null && (DynAbs.Tracing.TraceSender.Expression_True(183, 9332, 9397) && f_183_9366_9379(this) == f_183_9383_9397(other)) && (DynAbs.Tracing.TraceSender.Expression_True(183, 9332, 9463) && f_183_9418_9438(this) == f_183_9442_9463(other)) && (DynAbs.Tracing.TraceSender.Expression_True(183, 9332, 9526) && f_183_9484_9526(f_183_9484_9500(this), f_183_9508_9525(other))) && (DynAbs.Tracing.TraceSender.Expression_True(183, 9332, 9584) && f_183_9547_9563(this) == f_183_9567_9584(other)) && (DynAbs.Tracing.TraceSender.Expression_True(183, 9332, 9624) && f_183_9605_9612(this) == f_183_9616_9624(other)) && (DynAbs.Tracing.TraceSender.Expression_True(183, 9332, 9696) && f_183_9645_9668(this) == f_183_9672_9696(other)) && (DynAbs.Tracing.TraceSender.Expression_True(183, 9332, 9763) && f_183_9717_9763(f_183_9717_9735(this), f_183_9743_9762(other))) && (DynAbs.Tracing.TraceSender.Expression_True(183, 9332, 9814) && f_183_9784_9814(f_183_9784_9794(this), f_183_9802_9813(other)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(183, 9127, 9826);

                bool
                f_183_9203_9231(Microsoft.CodeAnalysis.DiagnosticDescriptor
                objA, Microsoft.CodeAnalysis.DiagnosticDescriptor?
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 9203, 9231);
                    return return_v;
                }


                string
                f_183_9366_9379(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Category;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 9366, 9379);
                    return return_v;
                }


                string
                f_183_9383_9397(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Category;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 9383, 9397);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_183_9418_9438(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.DefaultSeverity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 9418, 9438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_183_9442_9463(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.DefaultSeverity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 9442, 9463);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_183_9484_9500(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Description;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 9484, 9500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_183_9508_9525(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Description;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 9508, 9525);
                    return return_v;
                }


                bool
                f_183_9484_9526(Microsoft.CodeAnalysis.LocalizableString
                this_param, Microsoft.CodeAnalysis.LocalizableString
                other)
                {
                    var return_v = this_param.Equals(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 9484, 9526);
                    return return_v;
                }


                string
                f_183_9547_9563(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.HelpLinkUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 9547, 9563);
                    return return_v;
                }


                string
                f_183_9567_9584(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.HelpLinkUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 9567, 9584);
                    return return_v;
                }


                string
                f_183_9605_9612(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 9605, 9612);
                    return return_v;
                }


                string
                f_183_9616_9624(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 9616, 9624);
                    return return_v;
                }


                bool
                f_183_9645_9668(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.IsEnabledByDefault;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 9645, 9668);
                    return return_v;
                }


                bool
                f_183_9672_9696(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.IsEnabledByDefault;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 9672, 9696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_183_9717_9735(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.MessageFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 9717, 9735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_183_9743_9762(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.MessageFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 9743, 9762);
                    return return_v;
                }


                bool
                f_183_9717_9763(Microsoft.CodeAnalysis.LocalizableString
                this_param, Microsoft.CodeAnalysis.LocalizableString
                other)
                {
                    var return_v = this_param.Equals(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 9717, 9763);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_183_9784_9794(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Title;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 9784, 9794);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_183_9802_9813(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Title;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 9802, 9813);
                    return return_v;
                }


                bool
                f_183_9784_9814(Microsoft.CodeAnalysis.LocalizableString
                this_param, Microsoft.CodeAnalysis.LocalizableString
                other)
                {
                    var return_v = this_param.Equals(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 9784, 9814);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(183, 9127, 9826);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(183, 9127, 9826);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(183, 9838, 9957);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 9903, 9946);

                return f_183_9910_9945(this, obj as DiagnosticDescriptor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(183, 9838, 9957);

                bool
                f_183_9910_9945(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param, object?
                other)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.DiagnosticDescriptor?)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 9910, 9945);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(183, 9838, 9957);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(183, 9838, 9957);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(183, 9969, 10516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 10027, 10505);

                return f_183_10034_10504(f_183_10047_10074(f_183_10047_10060(this)), f_183_10093_10503(f_183_10106_10140(f_183_10106_10126(this)), f_183_10159_10502(f_183_10172_10202(f_183_10172_10188(this)), f_183_10221_10501(f_183_10234_10264(f_183_10234_10250(this)), f_183_10283_10500(f_183_10296_10317(f_183_10296_10303(this)), f_183_10336_10499(f_183_10349_10386(f_183_10349_10372(this)), f_183_10405_10498(f_183_10418_10450(f_183_10418_10436(this)), f_183_10473_10497(f_183_10473_10483(this)))))))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(183, 9969, 10516);

                string
                f_183_10047_10060(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Category;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 10047, 10060);
                    return return_v;
                }


                int
                f_183_10047_10074(string
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 10047, 10074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_183_10106_10126(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.DefaultSeverity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 10106, 10126);
                    return return_v;
                }


                int
                f_183_10106_10140(Microsoft.CodeAnalysis.DiagnosticSeverity
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 10106, 10140);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_183_10172_10188(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Description;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 10172, 10188);
                    return return_v;
                }


                int
                f_183_10172_10202(Microsoft.CodeAnalysis.LocalizableString
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 10172, 10202);
                    return return_v;
                }


                string
                f_183_10234_10250(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.HelpLinkUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 10234, 10250);
                    return return_v;
                }


                int
                f_183_10234_10264(string
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 10234, 10264);
                    return return_v;
                }


                string
                f_183_10296_10303(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 10296, 10303);
                    return return_v;
                }


                int
                f_183_10296_10317(string
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 10296, 10317);
                    return return_v;
                }


                bool
                f_183_10349_10372(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.IsEnabledByDefault;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 10349, 10372);
                    return return_v;
                }


                int
                f_183_10349_10386(bool
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 10349, 10386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_183_10418_10436(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.MessageFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 10418, 10436);
                    return return_v;
                }


                int
                f_183_10418_10450(Microsoft.CodeAnalysis.LocalizableString
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 10418, 10450);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_183_10473_10483(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Title;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 10473, 10483);
                    return return_v;
                }


                int
                f_183_10473_10497(Microsoft.CodeAnalysis.LocalizableString
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 10473, 10497);
                    return return_v;
                }


                int
                f_183_10405_10498(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 10405, 10498);
                    return return_v;
                }


                int
                f_183_10336_10499(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 10336, 10499);
                    return return_v;
                }


                int
                f_183_10283_10500(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 10283, 10500);
                    return return_v;
                }


                int
                f_183_10221_10501(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 10221, 10501);
                    return return_v;
                }


                int
                f_183_10159_10502(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 10159, 10502);
                    return return_v;
                }


                int
                f_183_10093_10503(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 10093, 10503);
                    return return_v;
                }


                int
                f_183_10034_10504(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 10034, 10504);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(183, 9969, 10516);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(183, 9969, 10516);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ReportDiagnostic GetEffectiveSeverity(CompilationOptions compilationOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(183, 10786, 11567);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 10894, 11033) || true) && (compilationOptions == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(183, 10894, 11033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 10958, 11018);

                    throw f_183_10964_11017(nameof(compilationOptions));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(183, 10894, 11033);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 11301, 11427);

                var
                effectiveDiagnostic = f_183_11327_11426(compilationOptions, f_183_11363_11401(this, f_183_11387_11400()), CancellationToken.None)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 11441, 11556);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(183, 11448, 11475) || ((effectiveDiagnostic != null && DynAbs.Tracing.TraceSender.Conditional_F2(183, 11478, 11527)) || DynAbs.Tracing.TraceSender.Conditional_F3(183, 11530, 11555))) ? f_183_11478_11527(f_183_11498_11526(effectiveDiagnostic)) : ReportDiagnostic.Suppress;
                DynAbs.Tracing.TraceSender.TraceExitMethod(183, 10786, 11567);

                System.ArgumentNullException
                f_183_10964_11017(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 10964, 11017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_183_11387_11400()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 11387, 11400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_183_11363_11401(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.Location
                location, params object?[]
                messageArgs)
                {
                    var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 11363, 11401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic?
                f_183_11327_11426(Microsoft.CodeAnalysis.CompilationOptions
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diagnostic, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.FilterDiagnostic(diagnostic, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 11327, 11426);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_183_11498_11526(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 11498, 11526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ReportDiagnostic
                f_183_11478_11527(Microsoft.CodeAnalysis.DiagnosticSeverity
                severity)
                {
                    var return_v = MapSeverityToReport(severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 11478, 11527);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(183, 10786, 11567);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(183, 10786, 11567);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ReportDiagnostic MapSeverityToReport(DiagnosticSeverity severity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(183, 11622, 12286);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 11728, 12275);

                switch (severity)
                {

                    case DiagnosticSeverity.Hidden:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(183, 11728, 12275);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 11831, 11862);

                        return ReportDiagnostic.Hidden;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(183, 11728, 12275);

                    case DiagnosticSeverity.Info:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(183, 11728, 12275);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 11931, 11960);

                        return ReportDiagnostic.Info;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(183, 11728, 12275);

                    case DiagnosticSeverity.Warning:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(183, 11728, 12275);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 12032, 12061);

                        return ReportDiagnostic.Warn;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(183, 11728, 12275);

                    case DiagnosticSeverity.Error:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(183, 11728, 12275);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 12131, 12161);

                        return ReportDiagnostic.Error;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(183, 11728, 12275);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(183, 11728, 12275);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 12209, 12260);

                        throw f_183_12215_12259(severity);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(183, 11728, 12275);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(183, 11622, 12286);

                System.Exception
                f_183_12215_12259(Microsoft.CodeAnalysis.DiagnosticSeverity
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 12215, 12259);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(183, 11622, 12286);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(183, 11622, 12286);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsNotConfigurable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(183, 12556, 12687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(183, 12614, 12676);

                return f_183_12621_12675(f_183_12659_12674(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(183, 12556, 12687);

                System.Collections.Generic.IEnumerable<string>
                f_183_12659_12674(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.CustomTags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 12659, 12674);
                    return return_v;
                }


                bool
                f_183_12621_12675(System.Collections.Generic.IEnumerable<string>
                customTags)
                {
                    var return_v = AnalyzerManager.HasNotConfigurableTag(customTags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 12621, 12675);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(183, 12556, 12687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(183, 12556, 12687);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DiagnosticDescriptor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(183, 535, 12694);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(183, 535, 12694);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(183, 535, 12694);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(183, 535, 12694);

        static System.Collections.Immutable.ImmutableArray<string>
        f_183_4613_4644(string[]
        items)
        {
            var return_v = items.AsImmutableOrEmpty<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 4613, 4644);
            return return_v;
        }


        static string
        f_183_4514_4516_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(183, 4139, 4667);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<string>
        f_183_7615_7646(string[]
        items)
        {
            var return_v = items.AsImmutableOrEmpty<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 7615, 7646);
            return return_v;
        }


        static string
        f_183_7516_7518_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(183, 7108, 7669);
            return return_v;
        }


        static bool
        f_183_8092_8121(string
        value)
        {
            var return_v = string.IsNullOrWhiteSpace(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 8092, 8121);
            return return_v;
        }


        static string
        f_183_8183_8239()
        {
            var return_v = CodeAnalysisResources.DiagnosticIdCantBeNullOrWhitespace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(183, 8183, 8239);
            return return_v;
        }


        static System.ArgumentException
        f_183_8161_8252(string
        message, string
        paramName)
        {
            var return_v = new System.ArgumentException(message, paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 8161, 8252);
            return return_v;
        }


        static System.ArgumentNullException
        f_183_8349_8397(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 8349, 8397);
            return return_v;
        }


        static System.ArgumentNullException
        f_183_8489_8532(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 8489, 8532);
            return return_v;
        }


        static System.ArgumentNullException
        f_183_8621_8661(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(183, 8621, 8661);
            return return_v;
        }

    }
}
