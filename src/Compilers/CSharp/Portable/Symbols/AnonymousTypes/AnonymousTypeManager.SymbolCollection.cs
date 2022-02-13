// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Microsoft.CodeAnalysis.RuntimeMembers;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed partial class AnonymousTypeManager
    {
        public bool ReportMissingOrErroneousSymbols(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10419, 646, 3122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 741, 764);

                bool
                hasErrors = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 780, 843);

                f_10419_780_842(f_10419_800_813(), diagnostics, ref hasErrors);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 857, 918);

                f_10419_857_917(f_10419_877_888(), diagnostics, ref hasErrors);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 932, 996);

                f_10419_932_995(f_10419_952_966(), diagnostics, ref hasErrors);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 1010, 1073);

                f_10419_1010_1072(f_10419_1030_1043(), diagnostics, ref hasErrors);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 1087, 1149);

                f_10419_1087_1148(f_10419_1107_1119(), diagnostics, ref hasErrors);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 1165, 1280);

                f_10419_1165_1279(f_10419_1192_1213(), SpecialMember.System_Object__Equals, diagnostics, ref hasErrors);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 1294, 1413);

                f_10419_1294_1412(f_10419_1321_1344(), SpecialMember.System_Object__ToString, diagnostics, ref hasErrors);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 1427, 1552);

                f_10419_1427_1551(f_10419_1454_1480(), SpecialMember.System_Object__GetHashCode, diagnostics, ref hasErrors);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 1566, 1717);

                f_10419_1566_1716(f_10419_1595_1632(), WellKnownMember.System_String__Format_IFormatProvider, diagnostics, ref hasErrors);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 1782, 1926);

                f_10419_1782_1925(f_10419_1795_1924(WellKnownMember.System_Runtime_CompilerServices_CompilerGeneratedAttribute__ctor));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 1940, 2068);

                f_10419_1940_2067(f_10419_1953_2066(WellKnownMember.System_Diagnostics_DebuggerHiddenAttribute__ctor));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 2082, 2213);

                f_10419_2082_2212(f_10419_2095_2211(WellKnownMember.System_Diagnostics_DebuggerBrowsableAttribute__ctor));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 2229, 2496);

                f_10419_2229_2495(f_10419_2258_2311(), WellKnownMember.System_Collections_Generic_EqualityComparer_T__Equals, diagnostics, ref hasErrors);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 2510, 2787);

                f_10419_2510_2786(f_10419_2539_2597(), WellKnownMember.System_Collections_Generic_EqualityComparer_T__GetHashCode, diagnostics, ref hasErrors);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 2801, 3078);

                f_10419_2801_3077(f_10419_2830_2888(), WellKnownMember.System_Collections_Generic_EqualityComparer_T__get_Default, diagnostics, ref hasErrors);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 3094, 3111);

                return hasErrors;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10419, 646, 3122);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10419_800_813()
                {
                    var return_v = System_Object;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10419, 800, 813);
                    return return_v;
                }


                int
                f_10419_780_842(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasError)
                {
                    ReportErrorOnSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, ref hasError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 780, 842);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10419_877_888()
                {
                    var return_v = System_Void;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10419, 877, 888);
                    return return_v;
                }


                int
                f_10419_857_917(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasError)
                {
                    ReportErrorOnSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, ref hasError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 857, 917);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10419_952_966()
                {
                    var return_v = System_Boolean;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10419, 952, 966);
                    return return_v;
                }


                int
                f_10419_932_995(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasError)
                {
                    ReportErrorOnSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, ref hasError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 932, 995);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10419_1030_1043()
                {
                    var return_v = System_String;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10419, 1030, 1043);
                    return return_v;
                }


                int
                f_10419_1010_1072(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasError)
                {
                    ReportErrorOnSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, ref hasError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 1010, 1072);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10419_1107_1119()
                {
                    var return_v = System_Int32;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10419, 1107, 1119);
                    return return_v;
                }


                int
                f_10419_1087_1148(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasError)
                {
                    ReportErrorOnSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, ref hasError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 1087, 1148);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10419_1192_1213()
                {
                    var return_v = System_Object__Equals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10419, 1192, 1213);
                    return return_v;
                }


                int
                f_10419_1165_1279(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.SpecialMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasError)
                {
                    ReportErrorOnSpecialMember((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, member, diagnostics, ref hasError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 1165, 1279);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10419_1321_1344()
                {
                    var return_v = System_Object__ToString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10419, 1321, 1344);
                    return return_v;
                }


                int
                f_10419_1294_1412(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.SpecialMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasError)
                {
                    ReportErrorOnSpecialMember((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, member, diagnostics, ref hasError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 1294, 1412);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10419_1454_1480()
                {
                    var return_v = System_Object__GetHashCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10419, 1454, 1480);
                    return return_v;
                }


                int
                f_10419_1427_1551(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.SpecialMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasError)
                {
                    ReportErrorOnSpecialMember((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, member, diagnostics, ref hasError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 1427, 1551);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10419_1595_1632()
                {
                    var return_v = System_String__Format_IFormatProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10419, 1595, 1632);
                    return return_v;
                }


                int
                f_10419_1566_1716(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.WellKnownMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasError)
                {
                    ReportErrorOnWellKnownMember((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, member, diagnostics, ref hasError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 1566, 1716);
                    return 0;
                }


                bool
                f_10419_1795_1924(Microsoft.CodeAnalysis.WellKnownMember
                attributeMember)
                {
                    var return_v = WellKnownMembers.IsSynthesizedAttributeOptional(attributeMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 1795, 1924);
                    return return_v;
                }


                int
                f_10419_1782_1925(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 1782, 1925);
                    return 0;
                }


                bool
                f_10419_1953_2066(Microsoft.CodeAnalysis.WellKnownMember
                attributeMember)
                {
                    var return_v = WellKnownMembers.IsSynthesizedAttributeOptional(attributeMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 1953, 2066);
                    return return_v;
                }


                int
                f_10419_1940_2067(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 1940, 2067);
                    return 0;
                }


                bool
                f_10419_2095_2211(Microsoft.CodeAnalysis.WellKnownMember
                attributeMember)
                {
                    var return_v = WellKnownMembers.IsSynthesizedAttributeOptional(attributeMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 2095, 2211);
                    return return_v;
                }


                int
                f_10419_2082_2212(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 2082, 2212);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10419_2258_2311()
                {
                    var return_v = System_Collections_Generic_EqualityComparer_T__Equals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10419, 2258, 2311);
                    return return_v;
                }


                int
                f_10419_2229_2495(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.WellKnownMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasError)
                {
                    ReportErrorOnWellKnownMember((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, member, diagnostics, ref hasError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 2229, 2495);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10419_2539_2597()
                {
                    var return_v = System_Collections_Generic_EqualityComparer_T__GetHashCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10419, 2539, 2597);
                    return return_v;
                }


                int
                f_10419_2510_2786(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.WellKnownMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasError)
                {
                    ReportErrorOnWellKnownMember((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, member, diagnostics, ref hasError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 2510, 2786);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10419_2830_2888()
                {
                    var return_v = System_Collections_Generic_EqualityComparer_T__get_Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10419, 2830, 2888);
                    return return_v;
                }


                int
                f_10419_2801_3077(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.WellKnownMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasError)
                {
                    ReportErrorOnWellKnownMember((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, member, diagnostics, ref hasError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 2801, 3077);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10419, 646, 3122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10419, 646, 3122);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ReportErrorOnSymbol(Symbol symbol, DiagnosticBag diagnostics, ref bool hasError)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10419, 3184, 3632);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 3309, 3391) || true) && ((object)symbol == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10419, 3309, 3391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 3369, 3376);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10419, 3309, 3391);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 3407, 3459);

                DiagnosticInfo
                info = f_10419_3429_3458(symbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 3473, 3621) || true) && (info != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10419, 3473, 3621);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 3523, 3606);

                    hasError = f_10419_3534_3605(info, diagnostics, NoLocation.Singleton);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10419, 3473, 3621);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10419, 3184, 3632);

                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10419_3429_3458(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 3429, 3458);
                    return return_v;
                }


                bool
                f_10419_3534_3605(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Symbol.ReportUseSiteDiagnostic(info, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 3534, 3605);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10419, 3184, 3632);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10419, 3184, 3632);
            }
        }

        private static void ReportErrorOnSpecialMember(Symbol symbol, SpecialMember member, DiagnosticBag diagnostics, ref bool hasError)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10419, 3644, 4295);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 3798, 4284) || true) && ((object)symbol == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10419, 3798, 4284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 3858, 3931);

                    MemberDescriptor
                    memberDescriptor = f_10419_3894_3930(member)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 3949, 4114);

                    f_10419_3949_4113(diagnostics, ErrorCode.ERR_MissingPredefinedMember, NoLocation.Singleton, memberDescriptor.DeclaringTypeMetadataName, memberDescriptor.Name);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 4132, 4148);

                    hasError = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10419, 3798, 4284);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10419, 3798, 4284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 4214, 4269);

                    f_10419_4214_4268(symbol, diagnostics, ref hasError);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10419, 3798, 4284);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10419, 3644, 4295);

                Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor
                f_10419_3894_3930(Microsoft.CodeAnalysis.SpecialMember
                member)
                {
                    var return_v = SpecialMembers.GetDescriptor(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 3894, 3930);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10419_3949_4113(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 3949, 4113);
                    return return_v;
                }


                int
                f_10419_4214_4268(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasError)
                {
                    ReportErrorOnSymbol(symbol, diagnostics, ref hasError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 4214, 4268);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10419, 3644, 4295);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10419, 3644, 4295);
            }
        }

        private static void ReportErrorOnWellKnownMember(Symbol symbol, WellKnownMember member, DiagnosticBag diagnostics, ref bool hasError)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10419, 4307, 5052);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 4465, 5041) || true) && ((object)symbol == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10419, 4465, 5041);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 4525, 4600);

                    MemberDescriptor
                    memberDescriptor = f_10419_4561_4599(member)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 4618, 4783);

                    f_10419_4618_4782(diagnostics, ErrorCode.ERR_MissingPredefinedMember, NoLocation.Singleton, memberDescriptor.DeclaringTypeMetadataName, memberDescriptor.Name);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 4801, 4817);

                    hasError = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10419, 4465, 5041);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10419, 4465, 5041);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 4883, 4938);

                    f_10419_4883_4937(symbol, diagnostics, ref hasError);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 4956, 5026);

                    f_10419_4956_5025(f_10419_4976_4997(symbol), diagnostics, ref hasError);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10419, 4465, 5041);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10419, 4307, 5052);

                Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor
                f_10419_4561_4599(Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = WellKnownMembers.GetDescriptor(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 4561, 4599);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10419_4618_4782(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 4618, 4782);
                    return return_v;
                }


                int
                f_10419_4883_4937(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasError)
                {
                    ReportErrorOnSymbol(symbol, diagnostics, ref hasError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 4883, 4937);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10419_4976_4997(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10419, 4976, 4997);
                    return return_v;
                }


                int
                f_10419_4956_5025(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasError)
                {
                    ReportErrorOnSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, ref hasError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 4956, 5025);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10419, 4307, 5052);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10419, 4307, 5052);
            }
        }

        public NamedTypeSymbol System_Object
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10419, 5174, 5243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 5180, 5241);

                    return f_10419_5187_5240(f_10419_5187_5198(), SpecialType.System_Object);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10419, 5174, 5243);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10419_5187_5198()
                    {
                        var return_v = Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10419, 5187, 5198);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10419_5187_5240(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    specialType)
                    {
                        var return_v = this_param.GetSpecialType(specialType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 5187, 5240);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10419, 5113, 5254);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10419, 5113, 5254);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public NamedTypeSymbol System_Void
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10419, 5325, 5392);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 5331, 5390);

                    return f_10419_5338_5389(f_10419_5338_5349(), SpecialType.System_Void);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10419, 5325, 5392);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10419_5338_5349()
                    {
                        var return_v = Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10419, 5338, 5349);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10419_5338_5389(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    specialType)
                    {
                        var return_v = this_param.GetSpecialType(specialType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 5338, 5389);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10419, 5266, 5403);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10419, 5266, 5403);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public NamedTypeSymbol System_Boolean
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10419, 5477, 5547);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 5483, 5545);

                    return f_10419_5490_5544(f_10419_5490_5501(), SpecialType.System_Boolean);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10419, 5477, 5547);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10419_5490_5501()
                    {
                        var return_v = Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10419, 5490, 5501);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10419_5490_5544(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    specialType)
                    {
                        var return_v = this_param.GetSpecialType(specialType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 5490, 5544);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10419, 5415, 5558);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10419, 5415, 5558);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public NamedTypeSymbol System_String
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10419, 5631, 5700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 5637, 5698);

                    return f_10419_5644_5697(f_10419_5644_5655(), SpecialType.System_String);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10419, 5631, 5700);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10419_5644_5655()
                    {
                        var return_v = Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10419, 5644, 5655);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10419_5644_5697(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    specialType)
                    {
                        var return_v = this_param.GetSpecialType(specialType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 5644, 5697);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10419, 5570, 5711);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10419, 5570, 5711);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public NamedTypeSymbol System_Int32
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10419, 5783, 5851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 5789, 5849);

                    return f_10419_5796_5848(f_10419_5796_5807(), SpecialType.System_Int32);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10419, 5783, 5851);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10419_5796_5807()
                    {
                        var return_v = Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10419, 5796, 5807);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10419_5796_5848(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    specialType)
                    {
                        var return_v = this_param.GetSpecialType(specialType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 5796, 5848);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10419, 5723, 5862);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10419, 5723, 5862);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public NamedTypeSymbol System_Diagnostics_DebuggerBrowsableState
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10419, 5963, 6064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 5969, 6062);

                    return f_10419_5976_6061(f_10419_5976_5987(), WellKnownType.System_Diagnostics_DebuggerBrowsableState);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10419, 5963, 6064);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10419_5976_5987()
                    {
                        var return_v = Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10419, 5976, 5987);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10419_5976_6061(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.WellKnownType
                    type)
                    {
                        var return_v = this_param.GetWellKnownType(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 5976, 6061);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10419, 5874, 6075);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10419, 5874, 6075);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public MethodSymbol System_Object__Equals
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10419, 6153, 6259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 6159, 6257);

                    return f_10419_6166_6240(f_10419_6166_6182(this), SpecialMember.System_Object__Equals) as MethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10419, 6153, 6259);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10419_6166_6182(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10419, 6166, 6182);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10419_6166_6240(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.SpecialMember
                    specialMember)
                    {
                        var return_v = this_param.GetSpecialTypeMember(specialMember);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 6166, 6240);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10419, 6087, 6270);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10419, 6087, 6270);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public MethodSymbol System_Object__ToString
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10419, 6350, 6458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 6356, 6456);

                    return f_10419_6363_6439(f_10419_6363_6379(this), SpecialMember.System_Object__ToString) as MethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10419, 6350, 6458);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10419_6363_6379(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10419, 6363, 6379);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10419_6363_6439(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.SpecialMember
                    specialMember)
                    {
                        var return_v = this_param.GetSpecialTypeMember(specialMember);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 6363, 6439);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10419, 6282, 6469);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10419, 6282, 6469);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public MethodSymbol System_Object__GetHashCode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10419, 6552, 6663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 6558, 6661);

                    return f_10419_6565_6644(f_10419_6565_6581(this), SpecialMember.System_Object__GetHashCode) as MethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10419, 6552, 6663);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10419_6565_6581(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10419, 6565, 6581);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10419_6565_6644(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.SpecialMember
                    specialMember)
                    {
                        var return_v = this_param.GetSpecialTypeMember(specialMember);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 6565, 6644);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10419, 6481, 6674);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10419, 6481, 6674);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public MethodSymbol System_Collections_Generic_EqualityComparer_T__Equals
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10419, 6784, 6926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 6790, 6924);

                    return f_10419_6797_6907(f_10419_6797_6813(this), WellKnownMember.System_Collections_Generic_EqualityComparer_T__Equals) as MethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10419, 6784, 6926);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10419_6797_6813(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10419, 6797, 6813);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10419_6797_6907(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member)
                    {
                        var return_v = this_param.GetWellKnownTypeMember(member);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 6797, 6907);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10419, 6686, 6937);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10419, 6686, 6937);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public MethodSymbol System_Collections_Generic_EqualityComparer_T__GetHashCode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10419, 7052, 7199);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 7058, 7197);

                    return f_10419_7065_7180(f_10419_7065_7081(this), WellKnownMember.System_Collections_Generic_EqualityComparer_T__GetHashCode) as MethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10419, 7052, 7199);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10419_7065_7081(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10419, 7065, 7081);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10419_7065_7180(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member)
                    {
                        var return_v = this_param.GetWellKnownTypeMember(member);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 7065, 7180);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10419, 6949, 7210);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10419, 6949, 7210);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public MethodSymbol System_Collections_Generic_EqualityComparer_T__get_Default
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10419, 7325, 7472);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 7331, 7470);

                    return f_10419_7338_7453(f_10419_7338_7354(this), WellKnownMember.System_Collections_Generic_EqualityComparer_T__get_Default) as MethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10419, 7325, 7472);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10419_7338_7354(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10419, 7338, 7354);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10419_7338_7453(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member)
                    {
                        var return_v = this_param.GetWellKnownTypeMember(member);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 7338, 7453);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10419, 7222, 7483);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10419, 7222, 7483);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public MethodSymbol System_String__Format_IFormatProvider
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10419, 7577, 7703);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10419, 7583, 7701);

                    return f_10419_7590_7684(f_10419_7590_7606(this), WellKnownMember.System_String__Format_IFormatProvider) as MethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10419, 7577, 7703);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10419_7590_7606(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10419, 7590, 7606);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10419_7590_7684(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    member)
                    {
                        var return_v = this_param.GetWellKnownTypeMember(member);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10419, 7590, 7684);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10419, 7495, 7714);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10419, 7495, 7714);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
}
