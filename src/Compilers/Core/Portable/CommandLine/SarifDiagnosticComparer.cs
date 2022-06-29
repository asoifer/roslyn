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
    internal sealed class SarifDiagnosticComparer : IEqualityComparer<DiagnosticDescriptor>
    {
        public static readonly SarifDiagnosticComparer Instance;

        private SarifDiagnosticComparer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(136, 1462, 1517);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(136, 1462, 1517);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(136, 1462, 1517);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(136, 1462, 1517);
            }
        }

        public bool Equals(DiagnosticDescriptor? x, DiagnosticDescriptor? y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(136, 1529, 2529);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(136, 1622, 1708) || true) && (f_136_1626_1647(x, y))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(136, 1622, 1708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(136, 1681, 1693);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(136, 1622, 1708);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(136, 1724, 1812) || true) && (x is null || (DynAbs.Tracing.TraceSender.Expression_False(136, 1728, 1750) || y is null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(136, 1724, 1812);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(136, 1784, 1797);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(136, 1724, 1812);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(136, 1925, 2004);

                f_136_1925_2003(f_136_1938_1951(x) != null && (DynAbs.Tracing.TraceSender.Expression_True(136, 1938, 1978) && f_136_1963_1970(x) != null) && (DynAbs.Tracing.TraceSender.Expression_True(136, 1938, 2002) && f_136_1982_1994(x) != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(136, 2018, 2097);

                f_136_2018_2096(f_136_2031_2044(y) != null && (DynAbs.Tracing.TraceSender.Expression_True(136, 2031, 2071) && f_136_2056_2063(y) != null) && (DynAbs.Tracing.TraceSender.Expression_True(136, 2031, 2095) && f_136_2075_2087(y) != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(136, 2113, 2518);

                return (f_136_2121_2131(x) == f_136_2135_2145(y) && (DynAbs.Tracing.TraceSender.Expression_True(136, 2121, 2204) && f_136_2166_2183(x) == f_136_2187_2204(y)) && (DynAbs.Tracing.TraceSender.Expression_True(136, 2121, 2261) && f_136_2225_2261(x.Description!, f_136_2247_2260(y))) && (DynAbs.Tracing.TraceSender.Expression_True(136, 2121, 2312) && f_136_2282_2295(x) == f_136_2299_2312(y)) && (DynAbs.Tracing.TraceSender.Expression_True(136, 2121, 2345) && f_136_2333_2337(x) == f_136_2341_2345(y)) && (DynAbs.Tracing.TraceSender.Expression_True(136, 2121, 2410) && f_136_2366_2386(x) == f_136_2390_2410(y)) && (DynAbs.Tracing.TraceSender.Expression_True(136, 2121, 2455) && f_136_2431_2455(x.Title!, f_136_2447_2454(y))) && (DynAbs.Tracing.TraceSender.Expression_True(136, 2121, 2516) && f_136_2476_2516(f_136_2476_2488(x), f_136_2503_2515(y))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(136, 1529, 2529);

                bool
                f_136_1626_1647(Microsoft.CodeAnalysis.DiagnosticDescriptor?
                objA, Microsoft.CodeAnalysis.DiagnosticDescriptor?
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(136, 1626, 1647);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_136_1938_1951(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Description;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 1938, 1951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_136_1963_1970(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Title;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 1963, 1970);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_136_1982_1994(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.CustomTags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 1982, 1994);
                    return return_v;
                }


                int
                f_136_1925_2003(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(136, 1925, 2003);
                    return 0;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_136_2031_2044(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Description;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 2031, 2044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_136_2056_2063(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Title;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 2056, 2063);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_136_2075_2087(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.CustomTags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 2075, 2087);
                    return return_v;
                }


                int
                f_136_2018_2096(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(136, 2018, 2096);
                    return 0;
                }


                string
                f_136_2121_2131(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Category;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 2121, 2131);
                    return return_v;
                }


                string
                f_136_2135_2145(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Category
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 2135, 2145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_136_2166_2183(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.DefaultSeverity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 2166, 2183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_136_2187_2204(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.DefaultSeverity
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 2187, 2204);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_136_2247_2260(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Description;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 2247, 2260);
                    return return_v;
                }


                bool
                f_136_2225_2261(Microsoft.CodeAnalysis.LocalizableString
                this_param, Microsoft.CodeAnalysis.LocalizableString
                other)
                {
                    var return_v = this_param.Equals(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(136, 2225, 2261);
                    return return_v;
                }


                string
                f_136_2282_2295(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.HelpLinkUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 2282, 2295);
                    return return_v;
                }


                string
                f_136_2299_2312(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.HelpLinkUri
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 2299, 2312);
                    return return_v;
                }


                string
                f_136_2333_2337(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 2333, 2337);
                    return return_v;
                }


                string
                f_136_2341_2345(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Id
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 2341, 2345);
                    return return_v;
                }


                bool
                f_136_2366_2386(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.IsEnabledByDefault;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 2366, 2386);
                    return return_v;
                }


                bool
                f_136_2390_2410(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.IsEnabledByDefault
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 2390, 2410);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_136_2447_2454(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Title;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 2447, 2454);
                    return return_v;
                }


                bool
                f_136_2431_2455(Microsoft.CodeAnalysis.LocalizableString
                this_param, Microsoft.CodeAnalysis.LocalizableString
                other)
                {
                    var return_v = this_param.Equals(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(136, 2431, 2455);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_136_2476_2488(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.CustomTags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 2476, 2488);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_136_2503_2515(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.CustomTags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 2503, 2515);
                    return return_v;
                }


                bool
                f_136_2476_2516(System.Collections.Generic.IEnumerable<string>
                first, System.Collections.Generic.IEnumerable<string>
                second)
                {
                    var return_v = first.SequenceEqual<string>(second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(136, 2476, 2516);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(136, 1529, 2529);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(136, 1529, 2529);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetHashCode(DiagnosticDescriptor obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(136, 2541, 3472);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(136, 2614, 2687) || true) && (obj is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(136, 2614, 2687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(136, 2663, 2672);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(136, 2614, 2687);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(136, 2800, 2971);

                f_136_2800_2970(f_136_2813_2825(obj) != null && (DynAbs.Tracing.TraceSender.Expression_True(136, 2813, 2860) && f_136_2837_2852(obj) != null) && (DynAbs.Tracing.TraceSender.Expression_True(136, 2813, 2887) && f_136_2864_2879(obj) != null
                ) && (DynAbs.Tracing.TraceSender.Expression_True(136, 2813, 2922) && f_136_2908_2914(obj) != null) && (DynAbs.Tracing.TraceSender.Expression_True(136, 2813, 2943) && f_136_2926_2935(obj) != null) && (DynAbs.Tracing.TraceSender.Expression_True(136, 2813, 2969) && f_136_2947_2961(obj) != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(136, 2987, 3461);

                return f_136_2994_3460(f_136_3007_3034(obj.Category!), f_136_3053_3459(f_136_3066_3099(f_136_3066_3085(obj)), f_136_3118_3458(f_136_3131_3161(obj.Description!), f_136_3180_3457(f_136_3193_3223(obj.HelpLinkUri!), f_136_3242_3456(f_136_3255_3276(obj.Id!), f_136_3295_3455(f_136_3308_3344(f_136_3308_3330(obj)), f_136_3363_3454(f_136_3376_3400(obj.Title!), f_136_3419_3453(f_136_3438_3452(obj)))))))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(136, 2541, 3472);

                string
                f_136_2813_2825(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Category;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 2813, 2825);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_136_2837_2852(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Description;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 2837, 2852);
                    return return_v;
                }


                string
                f_136_2864_2879(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.HelpLinkUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 2864, 2879);
                    return return_v;
                }


                string
                f_136_2908_2914(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 2908, 2914);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_136_2926_2935(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Title;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 2926, 2935);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_136_2947_2961(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.CustomTags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 2947, 2961);
                    return return_v;
                }


                int
                f_136_2800_2970(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(136, 2800, 2970);
                    return 0;
                }


                int
                f_136_3007_3034(string
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(136, 3007, 3034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_136_3066_3085(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.DefaultSeverity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 3066, 3085);
                    return return_v;
                }


                int
                f_136_3066_3099(Microsoft.CodeAnalysis.DiagnosticSeverity
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(136, 3066, 3099);
                    return return_v;
                }


                int
                f_136_3131_3161(Microsoft.CodeAnalysis.LocalizableString
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(136, 3131, 3161);
                    return return_v;
                }


                int
                f_136_3193_3223(string
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(136, 3193, 3223);
                    return return_v;
                }


                int
                f_136_3255_3276(string
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(136, 3255, 3276);
                    return return_v;
                }


                bool
                f_136_3308_3330(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.IsEnabledByDefault;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 3308, 3330);
                    return return_v;
                }


                int
                f_136_3308_3344(bool
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(136, 3308, 3344);
                    return return_v;
                }


                int
                f_136_3376_3400(Microsoft.CodeAnalysis.LocalizableString
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(136, 3376, 3400);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_136_3438_3452(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.CustomTags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(136, 3438, 3452);
                    return return_v;
                }


                int
                f_136_3419_3453(System.Collections.Generic.IEnumerable<string>
                values)
                {
                    var return_v = Hash.CombineValues(values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(136, 3419, 3453);
                    return return_v;
                }


                int
                f_136_3363_3454(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(136, 3363, 3454);
                    return return_v;
                }


                int
                f_136_3295_3455(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(136, 3295, 3455);
                    return return_v;
                }


                int
                f_136_3242_3456(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(136, 3242, 3456);
                    return return_v;
                }


                int
                f_136_3180_3457(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(136, 3180, 3457);
                    return return_v;
                }


                int
                f_136_3118_3458(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(136, 3118, 3458);
                    return return_v;
                }


                int
                f_136_3053_3459(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(136, 3053, 3459);
                    return return_v;
                }


                int
                f_136_2994_3460(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(136, 2994, 3460);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(136, 2541, 3472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(136, 2541, 3472);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SarifDiagnosticComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(136, 1258, 3479);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(136, 1409, 1449);
            Instance = f_136_1420_1449(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(136, 1258, 3479);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(136, 1258, 3479);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(136, 1258, 3479);

        static Microsoft.CodeAnalysis.SarifDiagnosticComparer
        f_136_1420_1449()
        {
            var return_v = new Microsoft.CodeAnalysis.SarifDiagnosticComparer();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(136, 1420, 1449);
            return return_v;
        }

    }
}
