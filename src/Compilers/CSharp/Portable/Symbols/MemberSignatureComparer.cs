// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal class MemberSignatureComparer : IEqualityComparer<Symbol>
    {
        public static readonly MemberSignatureComparer ExplicitImplementationComparer;

        public static readonly MemberSignatureComparer CSharpImplicitImplementationComparer;

        public static readonly MemberSignatureComparer CSharpCloseImplicitImplementationComparer;

        public static readonly MemberSignatureComparer DuplicateSourceComparer;

        public static readonly MemberSignatureComparer RecordAPISignatureComparer;

        public static readonly MemberSignatureComparer PartialMethodsComparer;

        public static readonly MemberSignatureComparer CSharpOverrideComparer;

        private static readonly MemberSignatureComparer CSharpWithTupleNamesComparer;

        private static readonly MemberSignatureComparer CSharpWithoutTupleNamesComparer;

        public static readonly MemberSignatureComparer CSharpAccessorOverrideComparer;

        public static readonly MemberSignatureComparer CSharpCustomModifierOverrideComparer;

        internal static readonly MemberSignatureComparer SloppyOverrideComparer;

        public static readonly MemberSignatureComparer RuntimeSignatureComparer;

        public static readonly MemberSignatureComparer RuntimePlusRefOutSignatureComparer;

        public static readonly MemberSignatureComparer RuntimeImplicitImplementationComparer;

        public static readonly MemberSignatureComparer CSharpSignatureAndConstraintsAndReturnTypeComparer;

        public static readonly MemberSignatureComparer RetargetedExplicitImplementationComparer;

        public static readonly MemberSignatureComparer CrefComparer;

        private readonly bool _considerName;

        private readonly bool _considerExplicitlyImplementedInterfaces;

        private readonly bool _considerReturnType;

        private readonly bool _considerTypeConstraints;

        private readonly bool _considerCallingConvention;

        private readonly bool _considerRefKindDifferences;

        private readonly TypeCompareKind _typeComparison;

        private MemberSignatureComparer(
                    bool considerName,
                    bool considerExplicitlyImplementedInterfaces,
                    bool considerReturnType,
                    bool considerTypeConstraints,
                    bool considerCallingConvention,
                    bool considerRefKindDifferences,
                    TypeCompareKind typeComparison = TypeCompareKind.IgnoreDynamic | TypeCompareKind.IgnoreNativeIntegers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10116, 18124, 19569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 17272, 17285);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 17416, 17456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 17548, 17567);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 17643, 17667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 17786, 17812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 17930, 17957);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 18096, 18111);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 18560, 18698);

                f_10116_18560_18697(!considerExplicitlyImplementedInterfaces || (DynAbs.Tracing.TraceSender.Expression_False(10116, 18573, 18629) || considerName), "Doesn't make sense to consider interfaces separately from name.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 18714, 18743);

                _considerName = considerName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 18757, 18840);

                _considerExplicitlyImplementedInterfaces = considerExplicitlyImplementedInterfaces;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 18854, 18895);

                _considerReturnType = considerReturnType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 18909, 18960);

                _considerTypeConstraints = considerTypeConstraints;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 18974, 19029);

                _considerCallingConvention = considerCallingConvention;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 19043, 19100);

                _considerRefKindDifferences = considerRefKindDifferences;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 19114, 19147);

                _typeComparison = typeComparison;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 19161, 19387);

                f_10116_19161_19386((_typeComparison & TypeCompareKind.FunctionPointerRefMatchesOutInRefReadonly) == 0, $"Rely on the {nameof(considerRefKindDifferences)} flag to set this to ensure all cases are handled.");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 19401, 19558) || true) && (!considerRefKindDifferences)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 19401, 19558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 19466, 19543);

                    _typeComparison |= TypeCompareKind.FunctionPointerRefMatchesOutInRefReadonly;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 19401, 19558);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10116, 18124, 19569);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10116, 18124, 19569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10116, 18124, 19569);
            }
        }

        public bool Equals(Symbol member1, Symbol member2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10116, 19634, 24520);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 19709, 19807) || true) && (f_10116_19713_19746(member1, member2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 19709, 19807);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 19780, 19792);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 19709, 19807);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 19823, 19971) || true) && ((object)member1 == null || (DynAbs.Tracing.TraceSender.Expression_False(10116, 19827, 19877) || (object)member2 == null) || (DynAbs.Tracing.TraceSender.Expression_False(10116, 19827, 19909) || f_10116_19881_19893(member1) != f_10116_19897_19909(member2)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 19823, 19971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 19943, 19956);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 19823, 19971);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 19987, 20020);

                bool
                sawInterfaceInName1 = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 20034, 20067);

                bool
                sawInterfaceInName2 = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 20083, 20581) || true) && (_considerName)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 20083, 20581);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 20134, 20222);

                    string
                    name1 = f_10116_20149_20221(f_10116_20208_20220(member1))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 20240, 20328);

                    string
                    name2 = f_10116_20255_20327(f_10116_20314_20326(member2))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 20348, 20392);

                    sawInterfaceInName1 = name1 != f_10116_20379_20391(member1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 20410, 20454);

                    sawInterfaceInName2 = name2 != f_10116_20441_20453(member2);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 20474, 20566) || true) && (name1 != name2)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 20474, 20566);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 20534, 20547);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 20474, 20566);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 20083, 20581);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 20763, 20800);

                int
                arity = f_10116_20775_20799(member1)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 20814, 20996) || true) && ((arity != f_10116_20828_20852(member2)) || (DynAbs.Tracing.TraceSender.Expression_False(10116, 20818, 20934) || (f_10116_20875_20902(member1) != f_10116_20906_20933(member2))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 20814, 20996);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 20968, 20981);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 20814, 20996);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 21012, 21051);

                TypeMap
                typeMap1 = f_10116_21031_21050(member1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 21065, 21104);

                TypeMap
                typeMap2 = f_10116_21084_21103(member2)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 21120, 21284) || true) && (_considerReturnType && (DynAbs.Tracing.TraceSender.Expression_True(10116, 21124, 21222) && !f_10116_21148_21222(member1, typeMap1, member2, typeMap2, _typeComparison)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 21120, 21284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 21256, 21269);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 21120, 21284);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 21300, 21616) || true) && (f_10116_21304_21331(member1) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(10116, 21304, 21554) && !f_10116_21340_21554(f_10116_21363_21386(member1), typeMap1, f_10116_21398_21421(member2), typeMap2, _considerRefKindDifferences, _typeComparison)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 21300, 21616);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 21588, 21601);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 21300, 21616);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 21632, 22045) || true) && (_considerCallingConvention)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 21632, 22045);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 21696, 21836) || true) && (f_10116_21700_21729(member1) != f_10116_21733_21762(member2))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 21696, 21836);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 21804, 21817);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 21696, 21836);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 21632, 22045);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 21632, 22045);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 21902, 22030) || true) && (f_10116_21906_21929(member1) != f_10116_21933_21956(member2))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 21902, 22030);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 21998, 22011);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 21902, 22030);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 21632, 22045);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 22061, 24399) || true) && (_considerExplicitlyImplementedInterfaces)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 22061, 24399);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 22139, 22259) || true) && (sawInterfaceInName1 != sawInterfaceInName2)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 22139, 22259);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 22227, 22240);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 22139, 22259);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 22757, 24384) || true) && (sawInterfaceInName1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 22757, 24384);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 22822, 22856);

                        f_10116_22822_22855(sawInterfaceInName2);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 22943, 23123) || true) && (f_10116_22947_22990(member1) != f_10116_22994_23037(member2))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 22943, 23123);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 23087, 23100);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 22943, 23123);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 23935, 24021);

                        var
                        explicitInterfaceImplementations1 = f_10116_23975_24020(member1)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 24043, 24129);

                        var
                        explicitInterfaceImplementations2 = f_10116_24083_24128(member2)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 24153, 24365) || true) && (!explicitInterfaceImplementations1.SetEquals(explicitInterfaceImplementations2, SymbolEqualityComparer.ConsiderEverything))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 24153, 24365);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 24329, 24342);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 24153, 24365);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 22757, 24384);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 22061, 24399);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 24415, 24509);

                return !_considerTypeConstraints || (DynAbs.Tracing.TraceSender.Expression_False(10116, 24422, 24508) || f_10116_24451_24508(member1, typeMap1, member2, typeMap2));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10116, 19634, 24520);

                bool
                f_10116_19713_19746(Microsoft.CodeAnalysis.CSharp.Symbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 19713, 19746);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10116_19881_19893(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 19881, 19893);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10116_19897_19909(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 19897, 19909);
                    return return_v;
                }


                string
                f_10116_20208_20220(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 20208, 20220);
                    return return_v;
                }


                string
                f_10116_20149_20221(string
                fullName)
                {
                    var return_v = ExplicitInterfaceHelpers.GetMemberNameWithoutInterfaceName(fullName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 20149, 20221);
                    return return_v;
                }


                string
                f_10116_20314_20326(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 20314, 20326);
                    return return_v;
                }


                string
                f_10116_20255_20327(string
                fullName)
                {
                    var return_v = ExplicitInterfaceHelpers.GetMemberNameWithoutInterfaceName(fullName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 20255, 20327);
                    return return_v;
                }


                string
                f_10116_20379_20391(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 20379, 20391);
                    return return_v;
                }


                string
                f_10116_20441_20453(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 20441, 20453);
                    return return_v;
                }


                int
                f_10116_20775_20799(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetMemberArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 20775, 20799);
                    return return_v;
                }


                int
                f_10116_20828_20852(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetMemberArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 20828, 20852);
                    return return_v;
                }


                int
                f_10116_20875_20902(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.GetParameterCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 20875, 20902);
                    return return_v;
                }


                int
                f_10116_20906_20933(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.GetParameterCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 20906, 20933);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10116_21031_21050(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = GetTypeMap(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 21031, 21050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10116_21084_21103(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = GetTypeMap(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 21084, 21103);
                    return return_v;
                }


                bool
                f_10116_21148_21222(Microsoft.CodeAnalysis.CSharp.Symbol
                member1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap1, Microsoft.CodeAnalysis.CSharp.Symbol
                member2, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap2, Microsoft.CodeAnalysis.TypeCompareKind
                typeComparison)
                {
                    var return_v = HaveSameReturnTypes(member1, typeMap1, member2, typeMap2, typeComparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 21148, 21222);
                    return return_v;
                }


                int
                f_10116_21304_21331(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.GetParameterCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 21304, 21331);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10116_21363_21386(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 21363, 21386);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10116_21398_21421(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 21398, 21421);
                    return return_v;
                }


                bool
                f_10116_21340_21554(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                params1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap1, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                params2, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap2, bool
                considerRefKindDifferences, Microsoft.CodeAnalysis.TypeCompareKind
                typeComparison)
                {
                    var return_v = HaveSameParameterTypes(params1, typeMap1, params2, typeMap2, considerRefKindDifferences, typeComparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 21340, 21554);
                    return return_v;
                }


                Microsoft.Cci.CallingConvention
                f_10116_21700_21729(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = GetCallingConvention(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 21700, 21729);
                    return return_v;
                }


                Microsoft.Cci.CallingConvention
                f_10116_21733_21762(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = GetCallingConvention(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 21733, 21762);
                    return return_v;
                }


                bool
                f_10116_21906_21929(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = IsVarargMethod(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 21906, 21929);
                    return return_v;
                }


                bool
                f_10116_21933_21956(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = IsVarargMethod(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 21933, 21956);
                    return return_v;
                }


                int
                f_10116_22822_22855(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 22822, 22855);
                    return 0;
                }


                bool
                f_10116_22947_22990(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.IsExplicitInterfaceImplementation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 22947, 22990);
                    return return_v;
                }


                bool
                f_10116_22994_23037(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.IsExplicitInterfaceImplementation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 22994, 23037);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10116_23975_24020(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.GetExplicitInterfaceImplementations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 23975, 24020);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10116_24083_24128(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.GetExplicitInterfaceImplementations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 24083, 24128);
                    return return_v;
                }


                bool
                f_10116_24451_24508(Microsoft.CodeAnalysis.CSharp.Symbol
                member1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap1, Microsoft.CodeAnalysis.CSharp.Symbol
                member2, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap2)
                {
                    var return_v = HaveSameConstraints(member1, typeMap1, member2, typeMap2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 24451, 24508);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10116, 19634, 24520);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10116, 19634, 24520);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetHashCode(Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10116, 24532, 25725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 24594, 24607);

                int
                hash = 1
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 24621, 25688) || true) && ((object)member != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 24621, 25688);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 24681, 24725);

                    hash = f_10116_24688_24724(f_10116_24706_24717(member), hash);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 24745, 25016) || true) && (_considerName)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 24745, 25016);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 24804, 24903);

                        hash = f_10116_24811_24902(f_10116_24824_24895(f_10116_24883_24894(member)), hash);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 24745, 25016);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 25036, 25369) || true) && (_considerReturnType && (DynAbs.Tracing.TraceSender.Expression_True(10116, 25040, 25091) && f_10116_25063_25086(member) == 0) && (DynAbs.Tracing.TraceSender.Expression_True(10116, 25040, 25173) && (_typeComparison & TypeCompareKind.AllIgnoreOptions) == 0))
                    ) // If it is generic, then type argument might be in return type.

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 25036, 25369);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 25280, 25350);

                        hash = f_10116_25287_25349(f_10116_25300_25328(member).GetHashCode(), hash);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 25036, 25369);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 25450, 25673) || true) && (f_10116_25454_25465(member) != SymbolKind.Field)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 25450, 25673);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 25527, 25578);

                        hash = f_10116_25534_25577(f_10116_25547_25570(member), hash);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 25600, 25654);

                        hash = f_10116_25607_25653(f_10116_25620_25646(member), hash);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 25450, 25673);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 24621, 25688);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 25702, 25714);

                return hash;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10116, 24532, 25725);

                Microsoft.CodeAnalysis.SymbolKind
                f_10116_24706_24717(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 24706, 24717);
                    return return_v;
                }


                int
                f_10116_24688_24724(Microsoft.CodeAnalysis.SymbolKind
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine((int)newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 24688, 24724);
                    return return_v;
                }


                string
                f_10116_24883_24894(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 24883, 24894);
                    return return_v;
                }


                string
                f_10116_24824_24895(string
                fullName)
                {
                    var return_v = ExplicitInterfaceHelpers.GetMemberNameWithoutInterfaceName(fullName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 24824, 24895);
                    return return_v;
                }


                int
                f_10116_24811_24902(string
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 24811, 24902);
                    return return_v;
                }


                int
                f_10116_25063_25086(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetMemberArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 25063, 25086);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10116_25300_25328(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetTypeOrReturnType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 25300, 25328);
                    return return_v;
                }


                int
                f_10116_25287_25349(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 25287, 25349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10116_25454_25465(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 25454, 25465);
                    return return_v;
                }


                int
                f_10116_25547_25570(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetMemberArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 25547, 25570);
                    return return_v;
                }


                int
                f_10116_25534_25577(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 25534, 25577);
                    return return_v;
                }


                int
                f_10116_25620_25646(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.GetParameterCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 25620, 25646);
                    return return_v;
                }


                int
                f_10116_25607_25653(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 25607, 25653);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10116, 24532, 25725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10116, 24532, 25725);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HaveSameReturnTypes(Symbol member1, TypeMap typeMap1, Symbol member2, TypeMap typeMap2, TypeCompareKind typeComparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10116, 25759, 27830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 25923, 25940);

                RefKind
                refKind1
                = default(RefKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 25954, 25999);

                TypeWithAnnotations
                unsubstitutedReturnType1
                = default(TypeWithAnnotations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 26013, 26064);

                ImmutableArray<CustomModifier>
                refCustomModifiers1
                = default(ImmutableArray<CustomModifier>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 26078, 26175);

                f_10116_26078_26174(member1, out refKind1, out unsubstitutedReturnType1, out refCustomModifiers1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 26191, 26208);

                RefKind
                refKind2
                = default(RefKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 26222, 26267);

                TypeWithAnnotations
                unsubstitutedReturnType2
                = default(TypeWithAnnotations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 26281, 26332);

                ImmutableArray<CustomModifier>
                refCustomModifiers2
                = default(ImmutableArray<CustomModifier>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 26346, 26443);

                f_10116_26346_26442(member2, out refKind2, out unsubstitutedReturnType2, out refCustomModifiers2);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 26528, 26614) || true) && (refKind1 != refKind2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 26528, 26614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 26586, 26599);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 26528, 26614);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 26630, 26682);

                var
                isVoid1 = unsubstitutedReturnType1.IsVoidType()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 26696, 26748);

                var
                isVoid2 = unsubstitutedReturnType2.IsVoidType()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 26764, 26848) || true) && (isVoid1 != isVoid2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 26764, 26848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 26820, 26833);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 26764, 26848);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 26864, 27216) || true) && (isVoid1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 26864, 27216);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 26909, 27201) || true) && ((typeComparison & TypeCompareKind.IgnoreCustomModifiersAndArraySizesAndLowerBounds) != 0 || (DynAbs.Tracing.TraceSender.Expression_False(10116, 26913, 27128) || (unsubstitutedReturnType1.CustomModifiers.IsEmpty && (DynAbs.Tracing.TraceSender.Expression_True(10116, 27027, 27127) && unsubstitutedReturnType2.CustomModifiers.IsEmpty))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 26909, 27201);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 27170, 27182);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 26909, 27201);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 26864, 27216);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 27232, 27301);

                var
                returnType1 = f_10116_27250_27300(typeMap1, unsubstitutedReturnType1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 27315, 27384);

                var
                returnType2 = f_10116_27333_27383(typeMap2, unsubstitutedReturnType2)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 27398, 27512) || true) && (!returnType1.Equals(returnType2, typeComparison))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 27398, 27512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 27484, 27497);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 27398, 27512);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 27528, 27791) || true) && (((typeComparison & TypeCompareKind.IgnoreCustomModifiersAndArraySizesAndLowerBounds) == 0) && (DynAbs.Tracing.TraceSender.Expression_True(10116, 27532, 27729) && !f_10116_27644_27729(refCustomModifiers1, typeMap1, refCustomModifiers2, typeMap2)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 27528, 27791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 27763, 27776);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 27528, 27791);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 27807, 27819);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10116, 25759, 27830);

                int
                f_10116_26078_26174(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, out Microsoft.CodeAnalysis.RefKind
                refKind, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                returnType, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                refCustomModifiers)
                {
                    symbol.GetTypeOrReturnType(out refKind, out returnType, out refCustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 26078, 26174);
                    return 0;
                }


                int
                f_10116_26346_26442(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, out Microsoft.CodeAnalysis.RefKind
                refKind, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                returnType, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                refCustomModifiers)
                {
                    symbol.GetTypeOrReturnType(out refKind, out returnType, out refCustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 26346, 26442);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10116_27250_27300(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeSymbol)
                {
                    var return_v = SubstituteType(typeMap, typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 27250, 27300);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10116_27333_27383(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeSymbol)
                {
                    var return_v = SubstituteType(typeMap, typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 27333, 27383);
                    return return_v;
                }


                bool
                f_10116_27644_27729(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap1, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers2, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap2)
                {
                    var return_v = HaveSameCustomModifiers(customModifiers1, typeMap1, customModifiers2, typeMap2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 27644, 27729);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10116, 25759, 27830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10116, 25759, 27830);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TypeMap GetTypeMap(Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10116, 27842, 28223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 27915, 27969);

                var
                typeParameters = f_10116_27936_27968(member)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 27983, 28212);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10116, 27990, 28012) || ((typeParameters.IsEmpty && DynAbs.Tracing.TraceSender.Conditional_F2(10116, 28032, 28036)) || DynAbs.Tracing.TraceSender.Conditional_F3(10116, 28056, 28211))) ? null : f_10116_28056_28211(typeParameters, f_10116_28127_28183(f_10116_28159_28182(member)), true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10116, 27842, 28223);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10116_27936_27968(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetMemberTypeParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 27936, 27968);
                    return return_v;
                }


                int
                f_10116_28159_28182(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetMemberArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 28159, 28182);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10116_28127_28183(int
                count)
                {
                    var return_v = IndexedTypeParameterSymbol.Take(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 28127, 28183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10116_28056_28211(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                from, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                to, bool
                allowAlpha)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap(from, to, allowAlpha);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 28056, 28211);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10116, 27842, 28223);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10116, 27842, 28223);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HaveSameConstraints(Symbol member1, TypeMap typeMap1, Symbol member2, TypeMap typeMap2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10116, 28235, 28824);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 28367, 28434);

                f_10116_28367_28433(f_10116_28380_28404(member1) == f_10116_28408_28432(member2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 28450, 28487);

                int
                arity = f_10116_28462_28486(member1)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 28501, 28576) || true) && (arity == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 28501, 28576);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 28549, 28561);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 28501, 28576);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 28592, 28648);

                var
                typeParameters1 = f_10116_28614_28647(member1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 28662, 28718);

                var
                typeParameters2 = f_10116_28684_28717(member2)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 28732, 28813);

                return f_10116_28739_28812(typeParameters1, typeMap1, typeParameters2, typeMap2);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10116, 28235, 28824);

                int
                f_10116_28380_28404(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetMemberArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 28380, 28404);
                    return return_v;
                }


                int
                f_10116_28408_28432(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetMemberArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 28408, 28432);
                    return return_v;
                }


                int
                f_10116_28367_28433(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 28367, 28433);
                    return 0;
                }


                int
                f_10116_28462_28486(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetMemberArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 28462, 28486);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10116_28614_28647(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetMemberTypeParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 28614, 28647);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10116_28684_28717(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetMemberTypeParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 28684, 28717);
                    return return_v;
                }


                bool
                f_10116_28739_28812(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap1, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters2, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap2)
                {
                    var return_v = HaveSameConstraints(typeParameters1, typeMap1, typeParameters2, typeMap2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 28739, 28812);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10116, 28235, 28824);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10116, 28235, 28824);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool HaveSameConstraints(ImmutableArray<TypeParameterSymbol> typeParameters1, TypeMap typeMap1, ImmutableArray<TypeParameterSymbol> typeParameters2, TypeMap typeMap2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10116, 28836, 29445);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 29041, 29104);

                f_10116_29041_29103(typeParameters1.Length == typeParameters2.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 29120, 29155);

                int
                arity = typeParameters1.Length
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 29178, 29183);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 29169, 29406) || true) && (i < arity)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 29196, 29199)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 29169, 29406))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 29169, 29406);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 29233, 29391) || true) && (!f_10116_29238_29317(typeParameters1[i], typeMap1, typeParameters2[i], typeMap2))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 29233, 29391);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 29359, 29372);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 29233, 29391);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10116, 1, 238);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10116, 1, 238);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 29422, 29434);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10116, 28836, 29445);

                int
                f_10116_29041_29103(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 29041, 29103);
                    return 0;
                }


                bool
                f_10116_29238_29317(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter2, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap2)
                {
                    var return_v = HaveSameConstraints(typeParameter1, typeMap1, typeParameter2, typeMap2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 29238, 29317);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10116, 28836, 29445);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10116, 28836, 29445);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool HaveSameConstraints(TypeParameterSymbol typeParameter1, TypeMap typeMap1, TypeParameterSymbol typeParameter2, TypeMap typeMap2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10116, 29457, 30410);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 29694, 30236) || true) && ((f_10116_29699_29738(typeParameter1) != f_10116_29742_29781(typeParameter2)) || (DynAbs.Tracing.TraceSender.Expression_False(10116, 29698, 29891) || (f_10116_29804_29845(typeParameter1) != f_10116_29849_29890(typeParameter2))) || (DynAbs.Tracing.TraceSender.Expression_False(10116, 29698, 29992) || (f_10116_29913_29950(typeParameter1) != f_10116_29954_29991(typeParameter2))) || (DynAbs.Tracing.TraceSender.Expression_False(10116, 29698, 30101) || (f_10116_30014_30055(typeParameter1) != f_10116_30059_30100(typeParameter2))) || (DynAbs.Tracing.TraceSender.Expression_False(10116, 29698, 30174) || (f_10116_30123_30146(typeParameter1) != f_10116_30150_30173(typeParameter2))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 29694, 30236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 30208, 30221);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 29694, 30236);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 30252, 30399);

                return f_10116_30259_30398(typeParameter1, typeMap1, typeParameter2, typeMap2, SymbolEqualityComparer.IgnoringDynamicTupleNamesAndNullability);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10116, 29457, 30410);

                bool
                f_10116_29699_29738(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasConstructorConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 29699, 29738);
                    return return_v;
                }


                bool
                f_10116_29742_29781(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasConstructorConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 29742, 29781);
                    return return_v;
                }


                bool
                f_10116_29804_29845(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasReferenceTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 29804, 29845);
                    return return_v;
                }


                bool
                f_10116_29849_29890(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasReferenceTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 29849, 29890);
                    return return_v;
                }


                bool
                f_10116_29913_29950(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasValueTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 29913, 29950);
                    return return_v;
                }


                bool
                f_10116_29954_29991(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasValueTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 29954, 29991);
                    return return_v;
                }


                bool
                f_10116_30014_30055(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasUnmanagedTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 30014, 30055);
                    return return_v;
                }


                bool
                f_10116_30059_30100(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasUnmanagedTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 30059, 30100);
                    return return_v;
                }


                Microsoft.CodeAnalysis.VarianceKind
                f_10116_30123_30146(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Variance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 30123, 30146);
                    return return_v;
                }


                Microsoft.CodeAnalysis.VarianceKind
                f_10116_30150_30173(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Variance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 30150, 30173);
                    return return_v;
                }


                bool
                f_10116_30259_30398(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter2, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap2, System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
                comparer)
                {
                    var return_v = HaveSameTypeConstraints(typeParameter1, typeMap1, typeParameter2, typeMap2, (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 30259, 30398);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10116, 29457, 30410);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10116, 29457, 30410);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HaveSameTypeConstraints(TypeParameterSymbol typeParameter1, TypeMap typeMap1, TypeParameterSymbol typeParameter2, TypeMap typeMap2, IEqualityComparer<TypeSymbol> comparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10116, 30422, 31939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 30863, 30937);

                var
                constraintTypes1 = f_10116_30886_30936(typeParameter1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 30951, 31025);

                var
                constraintTypes2 = f_10116_30974_31024(typeParameter2)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 31276, 31405) || true) && ((constraintTypes1.Length == 0) && (DynAbs.Tracing.TraceSender.Expression_True(10116, 31280, 31344) && (constraintTypes2.Length == 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 31276, 31405);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 31378, 31390);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 31276, 31405);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 31421, 31479);

                var
                substitutedTypes1 = f_10116_31445_31478(comparer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 31493, 31551);

                var
                substitutedTypes2 = f_10116_31517_31550(comparer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 31567, 31640);

                f_10116_31567_31639(constraintTypes1, typeMap1, substitutedTypes1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 31654, 31727);

                f_10116_31654_31726(constraintTypes2, typeMap2, substitutedTypes2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 31743, 31928);

                return f_10116_31750_31828(substitutedTypes1, substitutedTypes2, typeParameter2) && (DynAbs.Tracing.TraceSender.Expression_True(10116, 31750, 31927) && f_10116_31849_31927(substitutedTypes2, substitutedTypes1, typeParameter1));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10116, 30422, 31939);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10116_30886_30936(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ConstraintTypesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 30886, 30936);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10116_30974_31024(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ConstraintTypesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 30974, 31024);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10116_31445_31478(System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>(comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 31445, 31478);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10116_31517_31550(System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>(comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 31517, 31550);
                    return return_v;
                }


                int
                f_10116_31567_31639(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                types, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                result)
                {
                    SubstituteConstraintTypes(types, typeMap, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 31567, 31639);
                    return 0;
                }


                int
                f_10116_31654_31726(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                types, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                result)
                {
                    SubstituteConstraintTypes(types, typeMap, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 31654, 31726);
                    return 0;
                }


                bool
                f_10116_31750_31828(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                constraintTypes1, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                constraintTypes2, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter2)
                {
                    var return_v = AreConstraintTypesSubset(constraintTypes1, constraintTypes2, typeParameter2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 31750, 31828);
                    return return_v;
                }


                bool
                f_10116_31849_31927(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                constraintTypes1, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                constraintTypes2, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter2)
                {
                    var return_v = AreConstraintTypesSubset(constraintTypes1, constraintTypes2, typeParameter2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 31849, 31927);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10116, 30422, 31939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10116, 30422, 31939);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool HaveSameNullabilityInConstraints(TypeParameterSymbol typeParameter1, TypeMap typeMap1, TypeParameterSymbol typeParameter2, TypeMap typeMap2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10116, 31951, 32764);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 32135, 32580) || true) && (f_10116_32139_32166_M(!typeParameter1.IsValueType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 32135, 32580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 32200, 32252);

                    bool?
                    isNotNullable1 = f_10116_32223_32251(typeParameter1)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 32270, 32322);

                    bool?
                    isNotNullable2 = f_10116_32293_32321(typeParameter2)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 32340, 32565) || true) && (f_10116_32344_32367(isNotNullable1) && (DynAbs.Tracing.TraceSender.Expression_True(10116, 32344, 32394) && f_10116_32371_32394(isNotNullable2)) && (DynAbs.Tracing.TraceSender.Expression_True(10116, 32344, 32491) && f_10116_32419_32453(isNotNullable1) != f_10116_32457_32491(isNotNullable2)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 32340, 32565);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 32533, 32546);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 32340, 32565);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 32135, 32580);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 32596, 32753);

                return f_10116_32603_32752(typeParameter1, typeMap1, typeParameter2, typeMap2, SymbolEqualityComparer.AllIgnoreOptionsPlusNullableWithUnknownMatchesAny);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10116, 31951, 32764);

                bool
                f_10116_32139_32166_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 32139, 32166);
                    return return_v;
                }


                bool?
                f_10116_32223_32251(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsNotNullable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 32223, 32251);
                    return return_v;
                }


                bool?
                f_10116_32293_32321(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsNotNullable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 32293, 32321);
                    return return_v;
                }


                bool
                f_10116_32344_32367(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 32344, 32367);
                    return return_v;
                }


                bool
                f_10116_32371_32394(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 32371, 32394);
                    return return_v;
                }


                bool
                f_10116_32419_32453(bool?
                this_param)
                {
                    var return_v = this_param.GetValueOrDefault();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 32419, 32453);
                    return return_v;
                }


                bool
                f_10116_32457_32491(bool?
                this_param)
                {
                    var return_v = this_param.GetValueOrDefault();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 32457, 32491);
                    return return_v;
                }


                bool
                f_10116_32603_32752(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter2, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap2, System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
                comparer)
                {
                    var return_v = HaveSameTypeConstraints(typeParameter1, typeMap1, typeParameter2, typeMap2, (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 32603, 32752);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10116, 31951, 32764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10116, 31951, 32764);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool AreConstraintTypesSubset(HashSet<TypeSymbol> constraintTypes1, HashSet<TypeSymbol> constraintTypes2, TypeParameterSymbol typeParameter2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10116, 32930, 34045);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 33111, 34006);
                    foreach (var constraintType in f_10116_33142_33158_I(constraintTypes1))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 33111, 34006);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 33245, 33374) || true) && (f_10116_33249_33275(constraintType) == SpecialType.System_Object)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 33245, 33374);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 33346, 33355);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 33245, 33374);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 33394, 33509) || true) && (f_10116_33398_33439(constraintTypes2, constraintType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 33394, 33509);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 33481, 33490);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 33394, 33509);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 33762, 33958) || true) && ((f_10116_33767_33793(constraintType) == SpecialType.System_ValueType) && (DynAbs.Tracing.TraceSender.Expression_True(10116, 33766, 33888) && f_10116_33851_33888(typeParameter2)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 33762, 33958);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 33930, 33939);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 33762, 33958);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 33978, 33991);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 33111, 34006);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10116, 1, 896);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10116, 1, 896);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 34022, 34034);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10116, 32930, 34045);

                Microsoft.CodeAnalysis.SpecialType
                f_10116_33249_33275(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 33249, 33275);
                    return return_v;
                }


                bool
                f_10116_33398_33439(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 33398, 33439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10116_33767_33793(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 33767, 33793);
                    return return_v;
                }


                bool
                f_10116_33851_33888(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasValueTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 33851, 33888);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10116_33142_33158_I(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 33142, 33158);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10116, 32930, 34045);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10116, 32930, 34045);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void SubstituteConstraintTypes(ImmutableArray<TypeWithAnnotations> types, TypeMap typeMap, HashSet<TypeSymbol> result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10116, 34057, 34347);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 34215, 34336);
                    foreach (var type in f_10116_34236_34241_I(types))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 34215, 34336);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 34275, 34321);

                        f_10116_34275_34320(result, f_10116_34286_34314(typeMap, type).Type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 34215, 34336);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10116, 1, 122);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10116, 1, 122);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10116, 34057, 34347);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10116_34286_34314(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                previous)
                {
                    var return_v = this_param.SubstituteType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 34286, 34314);
                    return return_v;
                }


                bool
                f_10116_34275_34320(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 34275, 34320);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10116_34236_34241_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 34236, 34241);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10116, 34057, 34347);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10116, 34057, 34347);
            }
        }

        private static bool HaveSameParameterTypes(ImmutableArray<ParameterSymbol> params1, TypeMap typeMap1, ImmutableArray<ParameterSymbol> params2, TypeMap typeMap2,
                                                           bool considerRefKindDifferences, TypeCompareKind typeComparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10116, 34359, 36246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 34661, 34708);

                f_10116_34661_34707(params1.Length == params2.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 34724, 34755);

                var
                numParams = params1.Length
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 34780, 34785);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 34771, 36207) || true) && (i < numParams)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 34802, 34805)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 34771, 36207))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 34771, 36207);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 34839, 34863);

                        var
                        param1 = params1[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 34881, 34905);

                        var
                        param2 = params2[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 34925, 34990);

                        var
                        type1 = f_10116_34937_34989(typeMap1, f_10116_34962_34988(param1))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 35008, 35073);

                        var
                        type2 = f_10116_35020_35072(typeMap2, f_10116_35045_35071(param2))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 35093, 35207) || true) && (!type1.Equals(type2, typeComparison))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 35093, 35207);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 35175, 35188);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 35093, 35207);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 35227, 35516) || true) && ((typeComparison & TypeCompareKind.IgnoreCustomModifiersAndArraySizesAndLowerBounds) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10116, 35231, 35442) && !f_10116_35345_35442(f_10116_35369_35394(param1), typeMap1, f_10116_35406_35431(param2), typeMap2)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 35227, 35516);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 35484, 35497);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 35227, 35516);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 35536, 35566);

                        var
                        refKind1 = f_10116_35551_35565(param1)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 35584, 35614);

                        var
                        refKind2 = f_10116_35599_35613(param2)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 35763, 36192) || true) && (considerRefKindDifferences)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 35763, 36192);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 35835, 35945) || true) && (refKind1 != refKind2)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 35835, 35945);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 35909, 35922);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 35835, 35945);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 35763, 36192);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 35763, 36192);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 36027, 36173) || true) && ((refKind1 == RefKind.None) != (refKind2 == RefKind.None))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 36027, 36173);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 36137, 36150);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 36027, 36173);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 35763, 36192);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10116, 1, 1437);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10116, 1, 1437);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 36223, 36235);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10116, 34359, 36246);

                int
                f_10116_34661_34707(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 34661, 34707);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10116_34962_34988(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 34962, 34988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10116_34937_34989(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeSymbol)
                {
                    var return_v = SubstituteType(typeMap, typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 34937, 34989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10116_35045_35071(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 35045, 35071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10116_35020_35072(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeSymbol)
                {
                    var return_v = SubstituteType(typeMap, typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 35020, 35072);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10116_35369_35394(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 35369, 35394);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10116_35406_35431(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 35406, 35431);
                    return return_v;
                }


                bool
                f_10116_35345_35442(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap1, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers2, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap2)
                {
                    var return_v = HaveSameCustomModifiers(customModifiers1, typeMap1, customModifiers2, typeMap2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 35345, 35442);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10116_35551_35565(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 35551, 35565);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10116_35599_35613(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 35599, 35613);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10116, 34359, 36246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10116, 34359, 36246);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TypeWithAnnotations SubstituteType(TypeMap typeMap, TypeWithAnnotations typeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10116, 36258, 36465);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 36381, 36454);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10116, 36388, 36403) || ((typeMap == null && DynAbs.Tracing.TraceSender.Conditional_F2(10116, 36406, 36416)) || DynAbs.Tracing.TraceSender.Conditional_F3(10116, 36419, 36453))) ? typeSymbol : typeSymbol.SubstituteType(typeMap);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10116, 36258, 36465);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10116, 36258, 36465);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10116, 36258, 36465);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HaveSameCustomModifiers(ImmutableArray<CustomModifier> customModifiers1, TypeMap typeMap1, ImmutableArray<CustomModifier> customModifiers2, TypeMap typeMap2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10116, 36477, 36896);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 36767, 36885);

                return f_10116_36774_36821(typeMap1, customModifiers1).SequenceEqual(f_10116_36836_36883(typeMap2, customModifiers2));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10116, 36477, 36896);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10116_36774_36821(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers)
                {
                    var return_v = SubstituteModifiers(typeMap, customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 36774, 36821);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10116_36836_36883(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers)
                {
                    var return_v = SubstituteModifiers(typeMap, customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 36836, 36883);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10116, 36477, 36896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10116, 36477, 36896);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<CustomModifier> SubstituteModifiers(TypeMap typeMap, ImmutableArray<CustomModifier> customModifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10116, 36908, 37168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 37063, 37157);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10116, 37070, 37085) || ((typeMap == null && DynAbs.Tracing.TraceSender.Conditional_F2(10116, 37088, 37103)) || DynAbs.Tracing.TraceSender.Conditional_F3(10116, 37106, 37156))) ? customModifiers : f_10116_37106_37156(typeMap, customModifiers);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10116, 36908, 37168);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10116_37106_37156(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers)
                {
                    var return_v = this_param.SubstituteCustomModifiers(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 37106, 37156);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10116, 36908, 37168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10116, 36908, 37168);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Cci.CallingConvention GetCallingConvention(Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10116, 37180, 37766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 37277, 37755);

                switch (f_10116_37285_37296(member))
                {

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 37277, 37755);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 37375, 37423);

                        return f_10116_37382_37422(((MethodSymbol)member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 37277, 37755);

                    case SymbolKind.Property: //NOTE: Not using PropertySymbol.CallingConvention
                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 37277, 37755);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 37579, 37638);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10116, 37586, 37601) || ((f_10116_37586_37601(member) && DynAbs.Tracing.TraceSender.Conditional_F2(10116, 37604, 37605)) || DynAbs.Tracing.TraceSender.Conditional_F3(10116, 37608, 37637))) ? 0 : Cci.CallingConvention.HasThis;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 37277, 37755);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10116, 37277, 37755);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 37686, 37740);

                        throw f_10116_37692_37739(f_10116_37727_37738(member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10116, 37277, 37755);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10116, 37180, 37766);

                Microsoft.CodeAnalysis.SymbolKind
                f_10116_37285_37296(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 37285, 37296);
                    return return_v;
                }


                Microsoft.Cci.CallingConvention
                f_10116_37382_37422(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.CallingConvention;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 37382, 37422);
                    return return_v;
                }


                bool
                f_10116_37586_37601(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 37586, 37601);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10116_37727_37738(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 37727, 37738);
                    return return_v;
                }


                System.Exception
                f_10116_37692_37739(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 37692, 37739);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10116, 37180, 37766);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10116, 37180, 37766);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsVarargMethod(Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10116, 37778, 37938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 37852, 37927);

                return f_10116_37859_37870(member) == SymbolKind.Method && (DynAbs.Tracing.TraceSender.Expression_True(10116, 37859, 37926) && f_10116_37895_37926(((MethodSymbol)member)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10116, 37778, 37938);

                Microsoft.CodeAnalysis.SymbolKind
                f_10116_37859_37870(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 37859, 37870);
                    return return_v;
                }


                bool
                f_10116_37895_37926(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsVararg;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10116, 37895, 37926);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10116, 37778, 37938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10116, 37778, 37938);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ConsideringTupleNamesCreatesDifference(Symbol member1, Symbol member2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10116, 38879, 39145);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 38995, 39134);

                return !f_10116_39003_39056(CSharpWithTupleNamesComparer, member1, member2) && (DynAbs.Tracing.TraceSender.Expression_True(10116, 39002, 39133) && f_10116_39077_39133(CSharpWithoutTupleNamesComparer, member1, member2));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10116, 38879, 39145);

                bool
                f_10116_39003_39056(Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                member1, Microsoft.CodeAnalysis.CSharp.Symbol
                member2)
                {
                    var return_v = this_param.Equals(member1, member2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 39003, 39056);
                    return return_v;
                }


                bool
                f_10116_39077_39133(Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                member1, Microsoft.CodeAnalysis.CSharp.Symbol
                member2)
                {
                    var return_v = this_param.Equals(member1, member2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 39077, 39133);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10116, 38879, 39145);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10116, 38879, 39145);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MemberSignatureComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10116, 1570, 39152);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 2050, 2446);
            ExplicitImplementationComparer = f_10116_2083_2446(considerName: false, considerExplicitlyImplementedInterfaces: false, considerReturnType: true, considerTypeConstraints: false, considerRefKindDifferences: true, considerCallingConvention: true, typeComparison: TypeCompareKind.AllIgnoreOptions); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 3538, 3983);
            CSharpImplicitImplementationComparer = f_10116_3577_3983(considerName: true, considerExplicitlyImplementedInterfaces: true, considerReturnType: true, considerTypeConstraints: false, considerCallingConvention: true, considerRefKindDifferences: true, typeComparison: TypeCompareKind.AllIgnoreOptions); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 4348, 4755);
            CSharpCloseImplicitImplementationComparer = f_10116_4392_4755(considerName: true, considerExplicitlyImplementedInterfaces: true, considerReturnType: false, considerTypeConstraints: false, considerCallingConvention: false, considerRefKindDifferences: true, typeComparison: TypeCompareKind.AllIgnoreOptions); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 5326, 5716);
            DuplicateSourceComparer = f_10116_5352_5716(considerName: true, considerExplicitlyImplementedInterfaces: true, considerReturnType: false, considerTypeConstraints: false, considerCallingConvention: false, considerRefKindDifferences: false, typeComparison: TypeCompareKind.AllIgnoreOptions); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 6035, 6427);
            RecordAPISignatureComparer = f_10116_6064_6427(considerName: true, considerExplicitlyImplementedInterfaces: true, considerReturnType: false, considerTypeConstraints: false, considerCallingConvention: false, considerRefKindDifferences: true, typeComparison: TypeCompareKind.AllIgnoreOptions); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 6749, 7137);
            PartialMethodsComparer = f_10116_6774_7137(considerName: true, considerExplicitlyImplementedInterfaces: true, considerReturnType: false, considerTypeConstraints: false, considerCallingConvention: false, considerRefKindDifferences: true, typeComparison: TypeCompareKind.AllIgnoreOptions); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 7358, 7768);
            CSharpOverrideComparer = f_10116_7383_7768(considerName: true, considerExplicitlyImplementedInterfaces: false, considerReturnType: false, considerTypeConstraints: false, considerCallingConvention: false, considerRefKindDifferences: true, typeComparison: TypeCompareKind.AllIgnoreOptions); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 8062, 8514);
            CSharpWithTupleNamesComparer = f_10116_8093_8514(considerName: true, considerExplicitlyImplementedInterfaces: false, considerReturnType: true, considerTypeConstraints: false, considerCallingConvention: false, considerRefKindDifferences: false, typeComparison: TypeCompareKind.AllIgnoreOptions & ~TypeCompareKind.IgnoreTupleNames); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 8808, 9227);
            CSharpWithoutTupleNamesComparer = f_10116_8842_9227(considerName: true, considerExplicitlyImplementedInterfaces: false, considerReturnType: true, considerTypeConstraints: false, considerCallingConvention: false, considerRefKindDifferences: false, typeComparison: TypeCompareKind.AllIgnoreOptions); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 9525, 9965);
            CSharpAccessorOverrideComparer = f_10116_9558_9965(considerName: false, considerExplicitlyImplementedInterfaces: false, considerReturnType: false, considerTypeConstraints: false, considerCallingConvention: false, considerRefKindDifferences: true, typeComparison: TypeCompareKind.AllIgnoreOptions); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 10406, 10937);
            CSharpCustomModifierOverrideComparer = f_10116_10445_10937(considerName: true, considerExplicitlyImplementedInterfaces: false, considerReturnType: true, considerTypeConstraints: false, considerCallingConvention: false, considerRefKindDifferences: true, typeComparison: TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes | TypeCompareKind.IgnoreNativeIntegers); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 11199, 11747);
            SloppyOverrideComparer = f_10116_11224_11747(considerName: false, considerExplicitlyImplementedInterfaces: false, considerReturnType: false, considerTypeConstraints: false, considerCallingConvention: false, considerRefKindDifferences: false, typeComparison: TypeCompareKind.IgnoreCustomModifiersAndArraySizesAndLowerBounds | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes | TypeCompareKind.IgnoreDynamicAndTupleNames); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 12321, 12819);
            RuntimeSignatureComparer = f_10116_12348_12819(considerName: true, considerExplicitlyImplementedInterfaces: false, considerReturnType: true, considerTypeConstraints: false, considerCallingConvention: true, considerRefKindDifferences: false, typeComparison: TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes | TypeCompareKind.IgnoreNativeIntegers); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 13231, 13738);
            RuntimePlusRefOutSignatureComparer = f_10116_13268_13738(considerName: true, considerExplicitlyImplementedInterfaces: false, considerReturnType: true, considerTypeConstraints: false, considerCallingConvention: true, considerRefKindDifferences: true, typeComparison: TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes | TypeCompareKind.IgnoreNativeIntegers); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 13971, 14526);
            RuntimeImplicitImplementationComparer = f_10116_14011_14526(considerName: true, considerExplicitlyImplementedInterfaces: true, considerReturnType: true, considerTypeConstraints: false, considerCallingConvention: true, considerRefKindDifferences: false, typeComparison: TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes | TypeCompareKind.IgnoreNativeIntegers); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 14908, 15429);
            CSharpSignatureAndConstraintsAndReturnTypeComparer = f_10116_14961_15429(considerName: true, considerExplicitlyImplementedInterfaces: true, considerReturnType: true, considerTypeConstraints: true, considerCallingConvention: true, considerRefKindDifferences: true, typeComparison: TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes | TypeCompareKind.IgnoreNativeIntegers); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 15641, 16200);
            RetargetedExplicitImplementationComparer = f_10116_15684_16200(considerName: true, considerExplicitlyImplementedInterfaces: false, considerReturnType: true, considerTypeConstraints: false, considerCallingConvention: true, considerRefKindDifferences: true, typeComparison: TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes | TypeCompareKind.IgnoreNativeIntegers); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10116, 16599, 17156);
            CrefComparer = f_10116_16614_17156(considerName: false, considerExplicitlyImplementedInterfaces: false, considerReturnType: false, considerTypeConstraints: false, considerCallingConvention: false, considerRefKindDifferences: true, typeComparison: TypeCompareKind.IgnoreCustomModifiersAndArraySizesAndLowerBounds | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes | TypeCompareKind.IgnoreDynamicAndTupleNames); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10116, 1570, 39152);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10116, 1570, 39152);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10116, 1570, 39152);

        static Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
        f_10116_2083_2446(bool
        considerName, bool
        considerExplicitlyImplementedInterfaces, bool
        considerReturnType, bool
        considerTypeConstraints, bool
        considerRefKindDifferences, bool
        considerCallingConvention, Microsoft.CodeAnalysis.TypeCompareKind
        typeComparison)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer(considerName: considerName, considerExplicitlyImplementedInterfaces: considerExplicitlyImplementedInterfaces, considerReturnType: considerReturnType, considerTypeConstraints: considerTypeConstraints, considerRefKindDifferences: considerRefKindDifferences, considerCallingConvention: considerCallingConvention, typeComparison: typeComparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 2083, 2446);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
        f_10116_3577_3983(bool
        considerName, bool
        considerExplicitlyImplementedInterfaces, bool
        considerReturnType, bool
        considerTypeConstraints, bool
        considerCallingConvention, bool
        considerRefKindDifferences, Microsoft.CodeAnalysis.TypeCompareKind
        typeComparison)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer(considerName: considerName, considerExplicitlyImplementedInterfaces: considerExplicitlyImplementedInterfaces, considerReturnType: considerReturnType, considerTypeConstraints: considerTypeConstraints, considerCallingConvention: considerCallingConvention, considerRefKindDifferences: considerRefKindDifferences, typeComparison: typeComparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 3577, 3983);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
        f_10116_4392_4755(bool
        considerName, bool
        considerExplicitlyImplementedInterfaces, bool
        considerReturnType, bool
        considerTypeConstraints, bool
        considerCallingConvention, bool
        considerRefKindDifferences, Microsoft.CodeAnalysis.TypeCompareKind
        typeComparison)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer(considerName: considerName, considerExplicitlyImplementedInterfaces: considerExplicitlyImplementedInterfaces, considerReturnType: considerReturnType, considerTypeConstraints: considerTypeConstraints, considerCallingConvention: considerCallingConvention, considerRefKindDifferences: considerRefKindDifferences, typeComparison: typeComparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 4392, 4755);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
        f_10116_5352_5716(bool
        considerName, bool
        considerExplicitlyImplementedInterfaces, bool
        considerReturnType, bool
        considerTypeConstraints, bool
        considerCallingConvention, bool
        considerRefKindDifferences, Microsoft.CodeAnalysis.TypeCompareKind
        typeComparison)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer(considerName: considerName, considerExplicitlyImplementedInterfaces: considerExplicitlyImplementedInterfaces, considerReturnType: considerReturnType, considerTypeConstraints: considerTypeConstraints, considerCallingConvention: considerCallingConvention, considerRefKindDifferences: considerRefKindDifferences, typeComparison: typeComparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 5352, 5716);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
        f_10116_6064_6427(bool
        considerName, bool
        considerExplicitlyImplementedInterfaces, bool
        considerReturnType, bool
        considerTypeConstraints, bool
        considerCallingConvention, bool
        considerRefKindDifferences, Microsoft.CodeAnalysis.TypeCompareKind
        typeComparison)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer(considerName: considerName, considerExplicitlyImplementedInterfaces: considerExplicitlyImplementedInterfaces, considerReturnType: considerReturnType, considerTypeConstraints: considerTypeConstraints, considerCallingConvention: considerCallingConvention, considerRefKindDifferences: considerRefKindDifferences, typeComparison: typeComparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 6064, 6427);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
        f_10116_6774_7137(bool
        considerName, bool
        considerExplicitlyImplementedInterfaces, bool
        considerReturnType, bool
        considerTypeConstraints, bool
        considerCallingConvention, bool
        considerRefKindDifferences, Microsoft.CodeAnalysis.TypeCompareKind
        typeComparison)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer(considerName: considerName, considerExplicitlyImplementedInterfaces: considerExplicitlyImplementedInterfaces, considerReturnType: considerReturnType, considerTypeConstraints: considerTypeConstraints, considerCallingConvention: considerCallingConvention, considerRefKindDifferences: considerRefKindDifferences, typeComparison: typeComparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 6774, 7137);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
        f_10116_7383_7768(bool
        considerName, bool
        considerExplicitlyImplementedInterfaces, bool
        considerReturnType, bool
        considerTypeConstraints, bool
        considerCallingConvention, bool
        considerRefKindDifferences, Microsoft.CodeAnalysis.TypeCompareKind
        typeComparison)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer(considerName: considerName, considerExplicitlyImplementedInterfaces: considerExplicitlyImplementedInterfaces, considerReturnType: considerReturnType, considerTypeConstraints: considerTypeConstraints, considerCallingConvention: considerCallingConvention, considerRefKindDifferences: considerRefKindDifferences, typeComparison: typeComparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 7383, 7768);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
        f_10116_8093_8514(bool
        considerName, bool
        considerExplicitlyImplementedInterfaces, bool
        considerReturnType, bool
        considerTypeConstraints, bool
        considerCallingConvention, bool
        considerRefKindDifferences, Microsoft.CodeAnalysis.TypeCompareKind
        typeComparison)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer(considerName: considerName, considerExplicitlyImplementedInterfaces: considerExplicitlyImplementedInterfaces, considerReturnType: considerReturnType, considerTypeConstraints: considerTypeConstraints, considerCallingConvention: considerCallingConvention, considerRefKindDifferences: considerRefKindDifferences, typeComparison: typeComparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 8093, 8514);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
        f_10116_8842_9227(bool
        considerName, bool
        considerExplicitlyImplementedInterfaces, bool
        considerReturnType, bool
        considerTypeConstraints, bool
        considerCallingConvention, bool
        considerRefKindDifferences, Microsoft.CodeAnalysis.TypeCompareKind
        typeComparison)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer(considerName: considerName, considerExplicitlyImplementedInterfaces: considerExplicitlyImplementedInterfaces, considerReturnType: considerReturnType, considerTypeConstraints: considerTypeConstraints, considerCallingConvention: considerCallingConvention, considerRefKindDifferences: considerRefKindDifferences, typeComparison: typeComparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 8842, 9227);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
        f_10116_9558_9965(bool
        considerName, bool
        considerExplicitlyImplementedInterfaces, bool
        considerReturnType, bool
        considerTypeConstraints, bool
        considerCallingConvention, bool
        considerRefKindDifferences, Microsoft.CodeAnalysis.TypeCompareKind
        typeComparison)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer(considerName: considerName, considerExplicitlyImplementedInterfaces: considerExplicitlyImplementedInterfaces, considerReturnType: considerReturnType, considerTypeConstraints: considerTypeConstraints, considerCallingConvention: considerCallingConvention, considerRefKindDifferences: considerRefKindDifferences, typeComparison: typeComparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 9558, 9965);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
        f_10116_10445_10937(bool
        considerName, bool
        considerExplicitlyImplementedInterfaces, bool
        considerReturnType, bool
        considerTypeConstraints, bool
        considerCallingConvention, bool
        considerRefKindDifferences, Microsoft.CodeAnalysis.TypeCompareKind
        typeComparison)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer(considerName: considerName, considerExplicitlyImplementedInterfaces: considerExplicitlyImplementedInterfaces, considerReturnType: considerReturnType, considerTypeConstraints: considerTypeConstraints, considerCallingConvention: considerCallingConvention, considerRefKindDifferences: considerRefKindDifferences, typeComparison: typeComparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 10445, 10937);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
        f_10116_11224_11747(bool
        considerName, bool
        considerExplicitlyImplementedInterfaces, bool
        considerReturnType, bool
        considerTypeConstraints, bool
        considerCallingConvention, bool
        considerRefKindDifferences, Microsoft.CodeAnalysis.TypeCompareKind
        typeComparison)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer(considerName: considerName, considerExplicitlyImplementedInterfaces: considerExplicitlyImplementedInterfaces, considerReturnType: considerReturnType, considerTypeConstraints: considerTypeConstraints, considerCallingConvention: considerCallingConvention, considerRefKindDifferences: considerRefKindDifferences, typeComparison: typeComparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 11224, 11747);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
        f_10116_12348_12819(bool
        considerName, bool
        considerExplicitlyImplementedInterfaces, bool
        considerReturnType, bool
        considerTypeConstraints, bool
        considerCallingConvention, bool
        considerRefKindDifferences, Microsoft.CodeAnalysis.TypeCompareKind
        typeComparison)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer(considerName: considerName, considerExplicitlyImplementedInterfaces: considerExplicitlyImplementedInterfaces, considerReturnType: considerReturnType, considerTypeConstraints: considerTypeConstraints, considerCallingConvention: considerCallingConvention, considerRefKindDifferences: considerRefKindDifferences, typeComparison: typeComparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 12348, 12819);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
        f_10116_13268_13738(bool
        considerName, bool
        considerExplicitlyImplementedInterfaces, bool
        considerReturnType, bool
        considerTypeConstraints, bool
        considerCallingConvention, bool
        considerRefKindDifferences, Microsoft.CodeAnalysis.TypeCompareKind
        typeComparison)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer(considerName: considerName, considerExplicitlyImplementedInterfaces: considerExplicitlyImplementedInterfaces, considerReturnType: considerReturnType, considerTypeConstraints: considerTypeConstraints, considerCallingConvention: considerCallingConvention, considerRefKindDifferences: considerRefKindDifferences, typeComparison: typeComparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 13268, 13738);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
        f_10116_14011_14526(bool
        considerName, bool
        considerExplicitlyImplementedInterfaces, bool
        considerReturnType, bool
        considerTypeConstraints, bool
        considerCallingConvention, bool
        considerRefKindDifferences, Microsoft.CodeAnalysis.TypeCompareKind
        typeComparison)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer(considerName: considerName, considerExplicitlyImplementedInterfaces: considerExplicitlyImplementedInterfaces, considerReturnType: considerReturnType, considerTypeConstraints: considerTypeConstraints, considerCallingConvention: considerCallingConvention, considerRefKindDifferences: considerRefKindDifferences, typeComparison: typeComparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 14011, 14526);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
        f_10116_14961_15429(bool
        considerName, bool
        considerExplicitlyImplementedInterfaces, bool
        considerReturnType, bool
        considerTypeConstraints, bool
        considerCallingConvention, bool
        considerRefKindDifferences, Microsoft.CodeAnalysis.TypeCompareKind
        typeComparison)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer(considerName: considerName, considerExplicitlyImplementedInterfaces: considerExplicitlyImplementedInterfaces, considerReturnType: considerReturnType, considerTypeConstraints: considerTypeConstraints, considerCallingConvention: considerCallingConvention, considerRefKindDifferences: considerRefKindDifferences, typeComparison: typeComparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 14961, 15429);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
        f_10116_15684_16200(bool
        considerName, bool
        considerExplicitlyImplementedInterfaces, bool
        considerReturnType, bool
        considerTypeConstraints, bool
        considerCallingConvention, bool
        considerRefKindDifferences, Microsoft.CodeAnalysis.TypeCompareKind
        typeComparison)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer(considerName: considerName, considerExplicitlyImplementedInterfaces: considerExplicitlyImplementedInterfaces, considerReturnType: considerReturnType, considerTypeConstraints: considerTypeConstraints, considerCallingConvention: considerCallingConvention, considerRefKindDifferences: considerRefKindDifferences, typeComparison: typeComparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 15684, 16200);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
        f_10116_16614_17156(bool
        considerName, bool
        considerExplicitlyImplementedInterfaces, bool
        considerReturnType, bool
        considerTypeConstraints, bool
        considerCallingConvention, bool
        considerRefKindDifferences, Microsoft.CodeAnalysis.TypeCompareKind
        typeComparison)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer(considerName: considerName, considerExplicitlyImplementedInterfaces: considerExplicitlyImplementedInterfaces, considerReturnType: considerReturnType, considerTypeConstraints: considerTypeConstraints, considerCallingConvention: considerCallingConvention, considerRefKindDifferences: considerRefKindDifferences, typeComparison: typeComparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 16614, 17156);
            return return_v;
        }


        int
        f_10116_18560_18697(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 18560, 18697);
            return 0;
        }


        int
        f_10116_19161_19386(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10116, 19161, 19386);
            return 0;
        }

    }
}
