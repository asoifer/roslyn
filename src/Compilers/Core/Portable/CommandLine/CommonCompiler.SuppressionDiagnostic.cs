// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal abstract partial class CommonCompiler
    {
        private sealed class SuppressionDiagnostic : Diagnostic
        {
            private static readonly DiagnosticDescriptor s_suppressionDiagnosticDescriptor;

            private readonly Diagnostic _originalDiagnostic;

            private readonly string _suppressionId;

            private readonly LocalizableString _suppressionJustification;

            public SuppressionDiagnostic(
                            Diagnostic originalDiagnostic,
                            string suppressionId,
                            LocalizableString suppressionJustification)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(133, 1375, 2043);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 1211, 1230);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 1269, 1283);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 1333, 1358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 1585, 1626);

                    f_133_1585_1625(originalDiagnostic != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 1644, 1713);

                    f_133_1644_1712(f_133_1657_1703(originalDiagnostic) != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 1731, 1782);

                    f_133_1731_1781(!f_133_1745_1780(suppressionId));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 1800, 1847);

                    f_133_1800_1846(suppressionJustification != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 1867, 1908);

                    _originalDiagnostic = originalDiagnostic;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 1926, 1957);

                    _suppressionId = suppressionId;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 1975, 2028);

                    _suppressionJustification = suppressionJustification;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(133, 1375, 2043);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(133, 1375, 2043);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(133, 1375, 2043);
                }
            }

            public override DiagnosticDescriptor Descriptor
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(133, 2107, 2143);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 2110, 2143);
                        return s_suppressionDiagnosticDescriptor; DynAbs.Tracing.TraceSender.TraceExitMethod(133, 2107, 2143);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(133, 2107, 2143);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(133, 2107, 2143);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(133, 2186, 2202);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 2189, 2202);
                        return f_133_2189_2202(f_133_2189_2199()); DynAbs.Tracing.TraceSender.TraceExitMethod(133, 2186, 2202);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(133, 2186, 2202);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(133, 2186, 2202);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override string GetMessage(IFormatProvider? formatProvider = null)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(133, 2219, 2920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 2475, 2579);

                    var
                    localizableMessageFormat = f_133_2506_2578(f_133_2506_2553(s_suppressionDiagnosticDescriptor), formatProvider)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 2597, 2905);

                    return f_133_2604_2904(formatProvider, localizableMessageFormat, f_133_2702_2724(_originalDiagnostic), f_133_2747_2793(_originalDiagnostic, formatProvider), _suppressionId, f_133_2853_2903(_suppressionJustification, formatProvider));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(133, 2219, 2920);

                    Microsoft.CodeAnalysis.LocalizableString
                    f_133_2506_2553(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.MessageFormat;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(133, 2506, 2553);
                        return return_v;
                    }


                    string
                    f_133_2506_2578(Microsoft.CodeAnalysis.LocalizableString
                    this_param, System.IFormatProvider?
                    formatProvider)
                    {
                        var return_v = this_param.ToString(formatProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 2506, 2578);
                        return return_v;
                    }


                    string
                    f_133_2702_2724(Microsoft.CodeAnalysis.Diagnostic
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(133, 2702, 2724);
                        return return_v;
                    }


                    string
                    f_133_2747_2793(Microsoft.CodeAnalysis.Diagnostic
                    this_param, System.IFormatProvider?
                    formatProvider)
                    {
                        var return_v = this_param.GetMessage(formatProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 2747, 2793);
                        return return_v;
                    }


                    string
                    f_133_2853_2903(Microsoft.CodeAnalysis.LocalizableString
                    this_param, System.IFormatProvider?
                    formatProvider)
                    {
                        var return_v = this_param.ToString(formatProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 2853, 2903);
                        return return_v;
                    }


                    string
                    f_133_2604_2904(System.IFormatProvider?
                    provider, string
                    format, params object?[]
                    args)
                    {
                        var return_v = string.Format(provider, format, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 2604, 2904);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(133, 2219, 2920);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(133, 2219, 2920);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override DiagnosticSeverity Severity
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(133, 2980, 3006);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 2983, 3006);
                        return DiagnosticSeverity.Info; DynAbs.Tracing.TraceSender.TraceExitMethod(133, 2980, 3006);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(133, 2980, 3006);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(133, 2980, 3006);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(133, 3055, 3063);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 3058, 3063);
                        return false; DynAbs.Tracing.TraceSender.TraceExitMethod(133, 3055, 3063);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(133, 3055, 3063);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(133, 3055, 3063);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(133, 3111, 3161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 3114, 3161);
                        return f_133_3114_3161(DiagnosticSeverity.Info); DynAbs.Tracing.TraceSender.TraceExitMethod(133, 3111, 3161);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(133, 3111, 3161);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(133, 3111, 3161);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(133, 3210, 3241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 3213, 3241);
                        return f_133_3213_3241(_originalDiagnostic); DynAbs.Tracing.TraceSender.TraceExitMethod(133, 3210, 3241);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(133, 3210, 3241);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(133, 3210, 3241);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(133, 3316, 3358);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 3319, 3358);
                        return f_133_3319_3358(_originalDiagnostic); DynAbs.Tracing.TraceSender.TraceExitMethod(133, 3316, 3358);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(133, 3316, 3358);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(133, 3316, 3358);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(133, 3437, 3482);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 3440, 3482);
                        return ImmutableDictionary<string, string?>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(133, 3437, 3482);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(133, 3437, 3482);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(133, 3437, 3482);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool Equals(Diagnostic? obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(133, 3499, 4106);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 3576, 3679) || true) && (f_133_3580_3606(this, obj))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(133, 3576, 3679);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 3648, 3660);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(133, 3576, 3679);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 3699, 3740);

                    var
                    other = obj as SuppressionDiagnostic
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 3758, 3849) || true) && (other == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(133, 3758, 3849);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 3817, 3830);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(133, 3758, 3849);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 3869, 4091);

                    return f_133_3876_3930(_originalDiagnostic, other._originalDiagnostic) && (DynAbs.Tracing.TraceSender.Expression_True(133, 3876, 3999) && f_133_3955_3999(_suppressionId, other._suppressionId)) && (DynAbs.Tracing.TraceSender.Expression_True(133, 3876, 4090) && f_133_4024_4090(_suppressionJustification, other._suppressionJustification));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(133, 3499, 4106);

                    bool
                    f_133_3580_3606(Microsoft.CodeAnalysis.CommonCompiler.SuppressionDiagnostic
                    objA, Microsoft.CodeAnalysis.Diagnostic?
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object?)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 3580, 3606);
                        return return_v;
                    }


                    bool
                    f_133_3876_3930(Microsoft.CodeAnalysis.Diagnostic
                    objA, Microsoft.CodeAnalysis.Diagnostic
                    objB)
                    {
                        var return_v = Equals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 3876, 3930);
                        return return_v;
                    }


                    bool
                    f_133_3955_3999(string
                    objA, string
                    objB)
                    {
                        var return_v = Equals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 3955, 3999);
                        return return_v;
                    }


                    bool
                    f_133_4024_4090(Microsoft.CodeAnalysis.LocalizableString
                    objA, Microsoft.CodeAnalysis.LocalizableString
                    objB)
                    {
                        var return_v = Equals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 4024, 4090);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(133, 3499, 4106);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(133, 3499, 4106);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(object? obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(133, 4163, 4216);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 4166, 4216);
                    return obj is Diagnostic diagnostic && (DynAbs.Tracing.TraceSender.Expression_True(133, 4166, 4216) && f_133_4198_4216(this, diagnostic)); DynAbs.Tracing.TraceSender.TraceExitMethod(133, 4163, 4216);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(133, 4163, 4216);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(133, 4163, 4216);
                }
                throw new System.Exception("Slicer error: unreachable code");

                bool
                f_133_4198_4216(Microsoft.CodeAnalysis.CommonCompiler.SuppressionDiagnostic
                this_param, Microsoft.CodeAnalysis.Diagnostic
                obj)
                {
                    var return_v = this_param.Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 4198, 4216);
                    return return_v;
                }

            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(133, 4233, 4475);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 4299, 4460);

                    return f_133_4306_4459(f_133_4319_4352(_originalDiagnostic), f_133_4375_4458(f_133_4388_4416(_suppressionId), f_133_4418_4457(_suppressionJustification)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(133, 4233, 4475);

                    int
                    f_133_4319_4352(Microsoft.CodeAnalysis.Diagnostic
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 4319, 4352);
                        return return_v;
                    }


                    int
                    f_133_4388_4416(string
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 4388, 4416);
                        return return_v;
                    }


                    int
                    f_133_4418_4457(Microsoft.CodeAnalysis.LocalizableString
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 4418, 4457);
                        return return_v;
                    }


                    int
                    f_133_4375_4458(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 4375, 4458);
                        return return_v;
                    }


                    int
                    f_133_4306_4459(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 4306, 4459);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(133, 4233, 4475);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(133, 4233, 4475);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override Diagnostic WithLocation(Location location)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(133, 4491, 4633);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 4584, 4618);

                    throw f_133_4590_4617();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(133, 4491, 4633);

                    System.NotSupportedException
                    f_133_4590_4617()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 4590, 4617);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(133, 4491, 4633);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(133, 4491, 4633);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override Diagnostic WithSeverity(DiagnosticSeverity severity)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(133, 4649, 4801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 4752, 4786);

                    throw f_133_4758_4785();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(133, 4649, 4801);

                    System.NotSupportedException
                    f_133_4758_4785()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 4758, 4785);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(133, 4649, 4801);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(133, 4649, 4801);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override Diagnostic WithIsSuppressed(bool isSuppressed)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(133, 4817, 4963);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 4914, 4948);

                    throw f_133_4920_4947();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(133, 4817, 4963);

                    System.NotSupportedException
                    f_133_4920_4947()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 4920, 4947);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(133, 4817, 4963);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(133, 4817, 4963);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static SuppressionDiagnostic()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(133, 668, 4974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 793, 1166);
                s_suppressionDiagnosticDescriptor = f_133_829_1166("SP0001", f_133_899_957(), f_133_976_1036(), "ProgrammaticSuppression", DiagnosticSeverity.Info, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(133, 668, 4974);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(133, 668, 4974);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(133, 668, 4974);

            static string
            f_133_899_957()
            {
                var return_v = CodeAnalysisResources.SuppressionDiagnosticDescriptorTitle;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(133, 899, 957);
                return return_v;
            }


            static string
            f_133_976_1036()
            {
                var return_v = CodeAnalysisResources.SuppressionDiagnosticDescriptorMessage;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(133, 976, 1036);
                return return_v;
            }


            static Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_133_829_1166(string
            id, string
            title, string
            messageFormat, string
            category, Microsoft.CodeAnalysis.DiagnosticSeverity
            defaultSeverity, bool
            isEnabledByDefault, params string[]
            customTags)
            {
                var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 829, 1166);
                return return_v;
            }


            static int
            f_133_1585_1625(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 1585, 1625);
                return 0;
            }


            static Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo?
            f_133_1657_1703(Microsoft.CodeAnalysis.Diagnostic
            this_param)
            {
                var return_v = this_param.ProgrammaticSuppressionInfo;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(133, 1657, 1703);
                return return_v;
            }


            static int
            f_133_1644_1712(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 1644, 1712);
                return 0;
            }


            static bool
            f_133_1745_1780(string
            value)
            {
                var return_v = string.IsNullOrEmpty(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 1745, 1780);
                return return_v;
            }


            static int
            f_133_1731_1781(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 1731, 1781);
                return 0;
            }


            static int
            f_133_1800_1846(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 1800, 1846);
                return 0;
            }


            Microsoft.CodeAnalysis.DiagnosticDescriptor
            f_133_2189_2199()
            {
                var return_v = Descriptor;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(133, 2189, 2199);
                return return_v;
            }


            string
            f_133_2189_2202(Microsoft.CodeAnalysis.DiagnosticDescriptor
            this_param)
            {
                var return_v = this_param.Id;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(133, 2189, 2202);
                return return_v;
            }


            int
            f_133_3114_3161(Microsoft.CodeAnalysis.DiagnosticSeverity
            severity)
            {
                var return_v = GetDefaultWarningLevel(severity);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 3114, 3161);
                return return_v;
            }


            Microsoft.CodeAnalysis.Location
            f_133_3213_3241(Microsoft.CodeAnalysis.Diagnostic
            this_param)
            {
                var return_v = this_param.Location;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(133, 3213, 3241);
                return return_v;
            }


            System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
            f_133_3319_3358(Microsoft.CodeAnalysis.Diagnostic
            this_param)
            {
                var return_v = this_param.AdditionalLocations;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(133, 3319, 3358);
                return return_v;
            }

        }
    }
}
