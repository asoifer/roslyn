// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.RuntimeMembers;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract partial class NamedTypeSymbol
    {
        internal const int
        ValueTupleRestPosition = 8
        ;

        internal const int
        ValueTupleRestIndex = ValueTupleRestPosition - 1
        ;

        internal const string
        ValueTupleTypeName = "ValueTuple"
        ;

        internal const string
        ValueTupleRestFieldName = "Rest"
        ;

        private TupleExtraData? _lazyTupleData;

        internal static NamedTypeSymbol CreateTuple(
                    Location? locationOpt,
                    ImmutableArray<TypeWithAnnotations> elementTypesWithAnnotations,
                    ImmutableArray<Location?> elementLocations,
                    ImmutableArray<string?> elementNames,
                    CSharpCompilation compilation,
                    bool shouldCheckConstraints,
                    bool includeNullability,
                    ImmutableArray<bool> errorPositions,
                    CSharpSyntaxNode? syntax = null,
                    DiagnosticBag? diagnostics = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10697, 1024, 4941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 1583, 1641);

                f_10697_1583_1640(!shouldCheckConstraints || (DynAbs.Tracing.TraceSender.Expression_False(10697, 1596, 1639) || syntax is object));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 1655, 1753);

                f_10697_1655_1752(elementNames.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(10697, 1668, 1751) || elementTypesWithAnnotations.Length == elementNames.Length));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 1767, 1827);

                f_10697_1767_1826(!includeNullability || (DynAbs.Tracing.TraceSender.Expression_False(10697, 1780, 1825) || shouldCheckConstraints));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 1843, 1896);

                int
                numElements = elementTypesWithAnnotations.Length
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 1912, 2018) || true) && (numElements <= 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 1912, 2018);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 1966, 2003);

                    throw f_10697_1972_2002();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 1912, 2018);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 2034, 2153);

                NamedTypeSymbol
                underlyingType = f_10697_2067_2152(elementTypesWithAnnotations, syntax, compilation, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 2169, 2542) || true) && (numElements >= ValueTupleRestPosition && (DynAbs.Tracing.TraceSender.Expression_True(10697, 2173, 2233) && diagnostics != null) && (DynAbs.Tracing.TraceSender.Expression_True(10697, 2173, 2266) && !f_10697_2238_2266(underlyingType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 2169, 2542);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 2300, 2404);

                    WellKnownMember
                    wellKnownTupleRest = f_10697_2337_2403(ValueTupleRestPosition, ValueTupleRestPosition)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 2422, 2527);

                    _ = f_10697_2426_2526(f_10697_2451_2484(underlyingType), wellKnownTupleRest, diagnostics, syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 2169, 2542);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 2558, 2882) || true) && (diagnostics != null && (DynAbs.Tracing.TraceSender.Expression_True(10697, 2562, 2664) && f_10697_2585_2664(((SourceModuleSymbol)f_10697_2606_2630(compilation)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 2558, 2882);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 2776, 2867);

                    f_10697_2776_2866(underlyingType, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 2558, 2882);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 2898, 3004);

                var
                locations = (DynAbs.Tracing.TraceSender.Conditional_F1(10697, 2914, 2933) || ((locationOpt is null && DynAbs.Tracing.TraceSender.Conditional_F2(10697, 2936, 2966)) || DynAbs.Tracing.TraceSender.Conditional_F3(10697, 2969, 3003))) ? ImmutableArray<Location>.Empty : f_10697_2969_3003(locationOpt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 3018, 3127);

                var
                constructedType = f_10697_3040_3126(underlyingType, elementNames, errorPositions, elementLocations, locations)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 3141, 3433) || true) && (shouldCheckConstraints && (DynAbs.Tracing.TraceSender.Expression_True(10697, 3145, 3190) && diagnostics != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 3141, 3433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 3224, 3418);

                    f_10697_3224_3417(constructedType, f_10697_3257_3280(compilation), syntax, elementLocations, compilation, diagnosticsOpt: diagnostics, nullabilityDiagnosticsOpt: (DynAbs.Tracing.TraceSender.Conditional_F1(10697, 3377, 3395) || ((includeNullability && DynAbs.Tracing.TraceSender.Conditional_F2(10697, 3398, 3409)) || DynAbs.Tracing.TraceSender.Conditional_F3(10697, 3412, 3416))) ? diagnostics : null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 3141, 3433);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 3449, 3472);

                return constructedType;

                static NamedTypeSymbol getTupleUnderlyingType(ImmutableArray<TypeWithAnnotations> elementTypes, CSharpSyntaxNode? syntax, CSharpCompilation compilation, DiagnosticBag? diagnostics)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10697, 3680, 4930);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 3893, 3931);

                        int
                        numElements = elementTypes.Length
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 3949, 3963);

                        int
                        remainder
                        = default(int);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 3981, 4047);

                        int
                        chainLength = f_10697_3999_4046(numElements, out remainder)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 4067, 4154);

                        NamedTypeSymbol
                        firstTupleType = f_10697_4100_4153(compilation, f_10697_4129_4152(remainder))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 4172, 4351) || true) && (diagnostics is object && (DynAbs.Tracing.TraceSender.Expression_True(10697, 4176, 4217) && syntax is object))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 4172, 4351);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 4259, 4332);

                            f_10697_4259_4331(syntax, diagnostics, firstTupleType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 4172, 4351);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 4371, 4412);

                        NamedTypeSymbol?
                        chainedTupleType = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 4430, 4811) || true) && (chainLength > 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 4430, 4811);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 4491, 4577);

                            chainedTupleType = f_10697_4510_4576(compilation, f_10697_4539_4575(ValueTupleRestPosition));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 4599, 4792) || true) && (diagnostics is object && (DynAbs.Tracing.TraceSender.Expression_True(10697, 4603, 4644) && syntax is object))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 4599, 4792);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 4694, 4769);

                                f_10697_4694_4768(syntax, diagnostics, chainedTupleType);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 4599, 4792);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 4430, 4811);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 4831, 4915);

                        return f_10697_4838_4914(firstTupleType, chainedTupleType, elementTypes);
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10697, 3680, 4930);

                        int
                        f_10697_3999_4046(int
                        numElements, out int
                        remainder)
                        {
                            var return_v = NumberOfValueTuples(numElements, out remainder);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 3999, 4046);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.WellKnownType
                        f_10697_4129_4152(int
                        arity)
                        {
                            var return_v = GetTupleType(arity);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 4129, 4152);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10697_4100_4153(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param, Microsoft.CodeAnalysis.WellKnownType
                        type)
                        {
                            var return_v = this_param.GetWellKnownType(type);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 4100, 4153);
                            return return_v;
                        }


                        int
                        f_10697_4259_4331(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        syntax, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        firstTupleType)
                        {
                            ReportUseSiteAndObsoleteDiagnostics(syntax, diagnostics, firstTupleType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 4259, 4331);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.WellKnownType
                        f_10697_4539_4575(int
                        arity)
                        {
                            var return_v = GetTupleType(arity);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 4539, 4575);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10697_4510_4576(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param, Microsoft.CodeAnalysis.WellKnownType
                        type)
                        {
                            var return_v = this_param.GetWellKnownType(type);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 4510, 4576);
                            return return_v;
                        }


                        int
                        f_10697_4694_4768(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        syntax, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        firstTupleType)
                        {
                            ReportUseSiteAndObsoleteDiagnostics(syntax, diagnostics, firstTupleType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 4694, 4768);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10697_4838_4914(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        firstTupleType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                        chainedTupleTypeOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        elementTypes)
                        {
                            var return_v = ConstructTupleUnderlyingType(firstTupleType, chainedTupleTypeOpt, elementTypes);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 4838, 4914);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 3680, 4930);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 3680, 4930);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10697, 1024, 4941);

                int
                f_10697_1583_1640(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 1583, 1640);
                    return 0;
                }


                int
                f_10697_1655_1752(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 1655, 1752);
                    return 0;
                }


                int
                f_10697_1767_1826(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 1767, 1826);
                    return 0;
                }


                System.Exception
                f_10697_1972_2002()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 1972, 2002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10697_2067_2152(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                elementTypes, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                syntax, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnostics)
                {
                    var return_v = getTupleUnderlyingType(elementTypes, syntax, compilation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 2067, 2152);
                    return return_v;
                }


                bool
                f_10697_2238_2266(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 2238, 2266);
                    return return_v;
                }


                Microsoft.CodeAnalysis.WellKnownMember
                f_10697_2337_2403(int
                arity, int
                position)
                {
                    var return_v = GetTupleTypeMember(arity, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 2337, 2403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10697_2451_2484(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 2451, 2484);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10697_2426_2526(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.WellKnownMember
                relativeMember, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                syntax)
                {
                    var return_v = GetWellKnownMemberInType(type, relativeMember, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode?)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 2426, 2526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10697_2606_2630(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 2606, 2630);
                    return return_v;
                }


                bool
                f_10697_2585_2664(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.AnyReferencedAssembliesAreLinked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 2585, 2664);
                    return return_v;
                }


                bool
                f_10697_2776_2866(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedType, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = Emit.NoPia.EmbeddedTypesManager.IsValidEmbeddableType(namedType, (Microsoft.CodeAnalysis.SyntaxNode?)syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 2776, 2866);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10697_2969_3003(Microsoft.CodeAnalysis.Location
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 2969, 3003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10697_3040_3126(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                tupleCompatibleType, System.Collections.Immutable.ImmutableArray<string?>
                elementNames, System.Collections.Immutable.ImmutableArray<bool>
                errorPositions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
                elementLocations, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations)
                {
                    var return_v = CreateTuple(tupleCompatibleType, elementNames, errorPositions, elementLocations, locations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 3040, 3126);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10697_3257_3280(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 3257, 3280);
                    return return_v;
                }


                int
                f_10697_3224_3417(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                tuple, Microsoft.CodeAnalysis.CSharp.Conversions
                conversions, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                typeSyntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
                elementLocations, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnosticsOpt, Microsoft.CodeAnalysis.DiagnosticBag?
                nullabilityDiagnosticsOpt)
                {
                    tuple.CheckConstraints((Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions, (Microsoft.CodeAnalysis.SyntaxNode?)typeSyntax, elementLocations, currentCompilation, diagnosticsOpt: diagnosticsOpt, nullabilityDiagnosticsOpt: nullabilityDiagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 3224, 3417);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 1024, 4941);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 1024, 4941);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static NamedTypeSymbol CreateTuple(
                    NamedTypeSymbol tupleCompatibleType,
                    ImmutableArray<string?> elementNames = default,
                    ImmutableArray<bool> errorPositions = default,
                    ImmutableArray<Location?> elementLocations = default,
                    ImmutableArray<Location> locations = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10697, 4953, 5491);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 5317, 5363);

                f_10697_5317_5362(f_10697_5330_5361(tupleCompatibleType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 5377, 5480);

                return f_10697_5384_5479(tupleCompatibleType, elementNames, elementLocations, errorPositions, locations);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10697, 4953, 5491);

                bool
                f_10697_5330_5361(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 5330, 5361);
                    return return_v;
                }


                int
                f_10697_5317_5362(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 5317, 5362);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10697_5384_5479(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<string?>
                newElementNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
                newElementLocations, System.Collections.Immutable.ImmutableArray<bool>
                errorPositions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations)
                {
                    var return_v = this_param.WithElementNames(newElementNames, newElementLocations, errorPositions, locations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 5384, 5479);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 4953, 5491);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 4953, 5491);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamedTypeSymbol WithTupleDataFrom(NamedTypeSymbol original)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10697, 5503, 5970);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 5596, 5809) || true) && (f_10697_5600_5612_M(!IsTupleType) || (DynAbs.Tracing.TraceSender.Expression_False(10697, 5600, 5680) || (original._lazyTupleData == null && (DynAbs.Tracing.TraceSender.Expression_True(10697, 5617, 5679) && this._lazyTupleData == null))) || (DynAbs.Tracing.TraceSender.Expression_False(10697, 5600, 5748) || f_10697_5684_5748(TupleData!, f_10697_5729_5747(original))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 5596, 5809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 5782, 5794);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 5596, 5809);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 5825, 5959);

                return f_10697_5832_5958(this, f_10697_5849_5875(original), f_10697_5877_5907(original), f_10697_5909_5937(original), f_10697_5939_5957(original));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10697, 5503, 5970);

                bool
                f_10697_5600_5612_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 5600, 5612);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData?
                f_10697_5729_5747(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 5729, 5747);
                    return return_v;
                }


                bool
                f_10697_5684_5748(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData?
                other)
                {
                    var return_v = this_param.EqualsIgnoringTupleUnderlyingType(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 5684, 5748);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string?>
                f_10697_5849_5875(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElementNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 5849, 5875);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
                f_10697_5877_5907(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElementLocations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 5877, 5907);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<bool>
                f_10697_5909_5937(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleErrorPositions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 5909, 5937);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10697_5939_5957(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 5939, 5957);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10697_5832_5958(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<string?>
                newElementNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
                newElementLocations, System.Collections.Immutable.ImmutableArray<bool>
                errorPositions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations)
                {
                    var return_v = this_param.WithElementNames(newElementNames, newElementLocations, errorPositions, locations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 5832, 5958);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 5503, 5970);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 5503, 5970);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamedTypeSymbol? TupleUnderlyingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10697, 6041, 6144);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 6044, 6144);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10697, 6044, 6071) || ((this._lazyTupleData != null && DynAbs.Tracing.TraceSender.Conditional_F2(10697, 6074, 6109)) || DynAbs.Tracing.TraceSender.Conditional_F3(10697, 6112, 6144))) ? f_10697_6074_6109(this.TupleData!) : ((DynAbs.Tracing.TraceSender.Conditional_F1(10697, 6113, 6129) || ((f_10697_6113_6129(this) && DynAbs.Tracing.TraceSender.Conditional_F2(10697, 6132, 6136)) || DynAbs.Tracing.TraceSender.Conditional_F3(10697, 6139, 6143))) ? this : null); DynAbs.Tracing.TraceSender.TraceExitMethod(10697, 6041, 6144);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 6041, 6144);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 6041, 6144);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal NamedTypeSymbol WithElementTypes(ImmutableArray<TypeWithAnnotations> newElementTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10697, 6278, 7650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 6397, 6477);

                f_10697_6397_6476(f_10697_6410_6442().Length == newElementTypes.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 6491, 6541);

                f_10697_6491_6540(newElementTypes.All(t => t.HasType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 6557, 6588);

                NamedTypeSymbol
                firstTupleType
                = default(NamedTypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 6602, 6636);

                NamedTypeSymbol?
                chainedTupleType
                = default(NamedTypeSymbol?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 6650, 7357) || true) && (f_10697_6654_6659() < NamedTypeSymbol.ValueTupleRestPosition)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 6650, 7357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 6734, 6770);

                    firstTupleType = f_10697_6751_6769();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 6788, 6812);

                    chainedTupleType = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 6650, 7357);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 6650, 7357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 6878, 6916);

                    chainedTupleType = f_10697_6897_6915();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 6934, 6960);

                    var
                    underlyingType = this
                    ;
                    {
                        try
                        {
                            do

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 6978, 7271);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 7021, 7163);

                                underlyingType = ((NamedTypeSymbol)f_10697_7056_7119(underlyingType)[NamedTypeSymbol.ValueTupleRestIndex].Type);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 6978, 7271);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 6978, 7271) || true) && (f_10697_7207_7227(underlyingType) >= NamedTypeSymbol.ValueTupleRestPosition)
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10697, 6978, 7271);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10697, 6978, 7271);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 7291, 7342);

                    firstTupleType = f_10697_7308_7341(underlyingType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 6650, 7357);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 7371, 7639);

                return f_10697_7378_7638(f_10697_7408_7487(firstTupleType, chainedTupleType, newElementTypes), elementNames: f_10697_7520_7537(), elementLocations: f_10697_7557_7578(), errorPositions: f_10697_7596_7615(), locations: f_10697_7628_7637());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10697, 6278, 7650);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10697_6410_6442()
                {
                    var return_v = TupleElementTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 6410, 6442);
                    return return_v;
                }


                int
                f_10697_6397_6476(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 6397, 6476);
                    return 0;
                }


                int
                f_10697_6491_6540(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 6491, 6540);
                    return 0;
                }


                int
                f_10697_6654_6659()
                {
                    var return_v = Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 6654, 6659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10697_6751_6769()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 6751, 6769);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10697_6897_6915()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 6897, 6915);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10697_7056_7119(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 7056, 7119);
                    return return_v;
                }


                int
                f_10697_7207_7227(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 7207, 7227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10697_7308_7341(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 7308, 7341);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10697_7408_7487(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                firstTupleType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                chainedTupleTypeOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                elementTypes)
                {
                    var return_v = ConstructTupleUnderlyingType(firstTupleType, chainedTupleTypeOpt, elementTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 7408, 7487);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string?>
                f_10697_7520_7537()
                {
                    var return_v = TupleElementNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 7520, 7537);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
                f_10697_7557_7578()
                {
                    var return_v = TupleElementLocations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 7557, 7578);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<bool>
                f_10697_7596_7615()
                {
                    var return_v = TupleErrorPositions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 7596, 7615);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10697_7628_7637()
                {
                    var return_v = Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 7628, 7637);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10697_7378_7638(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                tupleCompatibleType, System.Collections.Immutable.ImmutableArray<string?>
                elementNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
                elementLocations, System.Collections.Immutable.ImmutableArray<bool>
                errorPositions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations)
                {
                    var return_v = CreateTuple(tupleCompatibleType, elementNames: elementNames, elementLocations: elementLocations, errorPositions: errorPositions, locations: locations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 7378, 7638);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 6278, 7650);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 6278, 7650);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamedTypeSymbol WithElementNames(ImmutableArray<string?> newElementNames,
                                                          ImmutableArray<Location?> newElementLocations,
                                                          ImmutableArray<bool> errorPositions,
                                                          ImmutableArray<Location> locations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10697, 7909, 8601);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 8289, 8315);

                f_10697_8289_8314(f_10697_8302_8313());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 8329, 8443);

                f_10697_8329_8442(newElementNames.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(10697, 8342, 8441) || this.TupleElementTypesWithAnnotations.Length == newElementNames.Length));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 8457, 8590);

                return f_10697_8464_8589(this, f_10697_8478_8588(this.TupleUnderlyingType!, newElementNames, newElementLocations, errorPositions, locations));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10697, 7909, 8601);

                bool
                f_10697_8302_8313()
                {
                    var return_v = IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 8302, 8313);
                    return return_v;
                }


                int
                f_10697_8289_8314(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 8289, 8314);
                    return 0;
                }


                int
                f_10697_8329_8442(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 8329, 8442);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
                f_10697_8478_8588(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                underlyingType, System.Collections.Immutable.ImmutableArray<string?>
                elementNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
                elementLocations, System.Collections.Immutable.ImmutableArray<bool>
                errorPositions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData(underlyingType, elementNames, elementLocations, errorPositions, locations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 8478, 8588);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10697_8464_8589(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
                newData)
                {
                    var return_v = this_param.WithTupleData(newData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 8464, 8589);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 7909, 8601);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 7909, 8601);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamedTypeSymbol WithTupleData(TupleExtraData newData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10697, 8613, 9570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 8699, 8725);

                f_10697_8699_8724(f_10697_8712_8723());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 8741, 8858) || true) && (f_10697_8745_8797(newData, f_10697_8787_8796()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 8741, 8858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 8831, 8843);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 8741, 8858);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 8874, 9509) || true) && (f_10697_8878_8895(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 8874, 9509);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 8929, 9125) || true) && (newData.ElementNames.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 8929, 9125);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 9094, 9106);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 8929, 9125);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 9388, 9494);

                    return f_10697_9395_9493(f_10697_9395_9470(this, f_10697_9414_9453(this), unbound: false), newData);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 8874, 9509);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 9525, 9559);

                return f_10697_9532_9558(this, newData);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10697, 8613, 9570);

                bool
                f_10697_8712_8723()
                {
                    var return_v = IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 8712, 8723);
                    return return_v;
                }


                int
                f_10697_8699_8724(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 8699, 8724);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData?
                f_10697_8787_8796()
                {
                    var return_v = TupleData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 8787, 8796);
                    return return_v;
                }


                bool
                f_10697_8745_8797(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData?
                other)
                {
                    var return_v = this_param.EqualsIgnoringTupleUnderlyingType(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 8745, 8797);
                    return return_v;
                }


                bool
                f_10697_8878_8895(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 8878, 8895);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10697_9414_9453(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeParametersAsTypeArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 9414, 9453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10697_9395_9470(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, bool
                unbound)
                {
                    var return_v = this_param.ConstructCore(typeArguments, unbound: unbound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 9395, 9470);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10697_9395_9493(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
                newData)
                {
                    var return_v = this_param.WithTupleData(newData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 9395, 9493);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10697_9532_9558(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
                newData)
                {
                    var return_v = this_param.WithTupleDataCore(newData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 9532, 9558);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 8613, 9570);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 8613, 9570);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract NamedTypeSymbol WithTupleDataCore(TupleExtraData newData);

        internal static void GetUnderlyingTypeChain(NamedTypeSymbol underlyingTupleType, ArrayBuilder<NamedTypeSymbol> underlyingTupleTypeChain)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10697, 10080, 10791);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 10241, 10291);

                NamedTypeSymbol
                currentType = underlyingTupleType
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 10307, 10780) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 10307, 10780);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 10352, 10394);

                        f_10697_10352_10393(underlyingTupleTypeChain, currentType);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 10412, 10765) || true) && (f_10697_10416_10433(currentType) == NamedTypeSymbol.ValueTupleRestPosition)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 10412, 10765);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 10517, 10658);

                            currentType = (NamedTypeSymbol)f_10697_10548_10608(currentType)[NamedTypeSymbol.ValueTupleRestPosition - 1].Type;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 10412, 10765);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 10412, 10765);
                            DynAbs.Tracing.TraceSender.TraceBreak(10697, 10740, 10746);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 10412, 10765);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 10307, 10780);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10697, 10307, 10780);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10697, 10307, 10780);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10697, 10080, 10791);

                int
                f_10697_10352_10393(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 10352, 10393);
                    return 0;
                }


                int
                f_10697_10416_10433(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 10416, 10433);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10697_10548_10608(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 10548, 10608);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 10080, 10791);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 10080, 10791);
            }
        }

        private static int NumberOfValueTuples(int numElements, out int remainder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10697, 11084, 11333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 11183, 11248);

                remainder = (numElements - 1) % (ValueTupleRestPosition - 1) + 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 11262, 11322);

                return (numElements - 1) / (ValueTupleRestPosition - 1) + 1;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10697, 11084, 11333);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 11084, 11333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 11084, 11333);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static NamedTypeSymbol ConstructTupleUnderlyingType(NamedTypeSymbol firstTupleType, NamedTypeSymbol? chainedTupleTypeOpt, ImmutableArray<TypeWithAnnotations> elementTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10697, 11345, 12416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 11549, 11639);

                f_10697_11549_11638(chainedTupleTypeOpt is null == elementTypes.Length < ValueTupleRestPosition);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 11655, 11693);

                int
                numElements = elementTypes.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 11707, 11721);

                int
                remainder
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 11735, 11801);

                int
                chainLength = f_10697_11753_11800(numElements, out remainder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 11817, 11972);

                NamedTypeSymbol
                currentSymbol = f_10697_11849_11971(firstTupleType, f_10697_11874_11970(elementTypes, (chainLength - 1) * (ValueTupleRestPosition - 1), remainder))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 11986, 12013);

                int
                loop = chainLength - 1
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 12027, 12368) || true) && (loop > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 12027, 12368);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 12076, 12249);

                        var
                        chainedTypes = f_10697_12095_12201(elementTypes, (loop - 1) * (ValueTupleRestPosition - 1), ValueTupleRestPosition - 1).Add(TypeWithAnnotations.Create(currentSymbol))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 12267, 12328);

                        currentSymbol = f_10697_12283_12327(chainedTupleTypeOpt!, chainedTypes);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 12346, 12353);

                        loop--;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 12027, 12368);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10697, 12027, 12368);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10697, 12027, 12368);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 12384, 12405);

                return currentSymbol;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10697, 11345, 12416);

                int
                f_10697_11549_11638(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 11549, 11638);
                    return 0;
                }


                int
                f_10697_11753_11800(int
                numElements, out int
                remainder)
                {
                    var return_v = NumberOfValueTuples(numElements, out remainder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 11753, 11800);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10697_11874_11970(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                items, int
                start, int
                length)
                {
                    var return_v = ImmutableArray.Create(items, start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 11874, 11970);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10697_11849_11971(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 11849, 11971);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10697_12095_12201(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                items, int
                start, int
                length)
                {
                    var return_v = ImmutableArray.Create(items, start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 12095, 12201);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10697_12283_12327(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 12283, 12327);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 11345, 12416);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 11345, 12416);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ReportUseSiteAndObsoleteDiagnostics(CSharpSyntaxNode? syntax, DiagnosticBag diagnostics, NamedTypeSymbol firstTupleType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10697, 12428, 12816);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 12593, 12662);

                f_10697_12593_12661(firstTupleType, diagnostics, syntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 12676, 12805);

                f_10697_12676_12804(diagnostics, firstTupleType, syntax, f_10697_12756_12785(firstTupleType), BinderFlags.None);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10697, 12428, 12816);

                bool
                f_10697_12593_12661(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node)
                {
                    var return_v = Binder.ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 12593, 12661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10697_12756_12785(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 12756, 12785);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ObsoleteDiagnosticKind
                f_10697_12676_12804(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingMember, Microsoft.CodeAnalysis.CSharp.BinderFlags
                location)
                {
                    var return_v = Binder.ReportDiagnosticsIfObsoleteInternal(diagnostics, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)node, (Microsoft.CodeAnalysis.CSharp.Symbol)containingMember, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 12676, 12804);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 12428, 12816);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 12428, 12816);
            }
        }

        internal static void VerifyTupleTypePresent(int cardinality, CSharpSyntaxNode? syntax, CSharpCompilation compilation, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10697, 13018, 13839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 13187, 13249);

                f_10697_13187_13248(diagnostics is object && (DynAbs.Tracing.TraceSender.Expression_True(10697, 13206, 13247) && syntax is object));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 13265, 13279);

                int
                remainder
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 13293, 13359);

                int
                chainLength = f_10697_13311_13358(cardinality, out remainder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 13375, 13462);

                NamedTypeSymbol
                firstTupleType = f_10697_13408_13461(compilation, f_10697_13437_13460(remainder))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 13476, 13549);

                f_10697_13476_13548(syntax, diagnostics, firstTupleType);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 13565, 13828) || true) && (chainLength > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 13565, 13828);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 13618, 13720);

                    NamedTypeSymbol
                    chainedTupleType = f_10697_13653_13719(compilation, f_10697_13682_13718(ValueTupleRestPosition))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 13738, 13813);

                    f_10697_13738_13812(syntax, diagnostics, chainedTupleType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 13565, 13828);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10697, 13018, 13839);

                int
                f_10697_13187_13248(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 13187, 13248);
                    return 0;
                }


                int
                f_10697_13311_13358(int
                numElements, out int
                remainder)
                {
                    var return_v = NumberOfValueTuples(numElements, out remainder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 13311, 13358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.WellKnownType
                f_10697_13437_13460(int
                arity)
                {
                    var return_v = GetTupleType(arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 13437, 13460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10697_13408_13461(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 13408, 13461);
                    return return_v;
                }


                int
                f_10697_13476_13548(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                firstTupleType)
                {
                    ReportUseSiteAndObsoleteDiagnostics(syntax, diagnostics, firstTupleType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 13476, 13548);
                    return 0;
                }


                Microsoft.CodeAnalysis.WellKnownType
                f_10697_13682_13718(int
                arity)
                {
                    var return_v = GetTupleType(arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 13682, 13718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10697_13653_13719(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 13653, 13719);
                    return return_v;
                }


                int
                f_10697_13738_13812(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                firstTupleType)
                {
                    ReportUseSiteAndObsoleteDiagnostics(syntax, diagnostics, firstTupleType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 13738, 13812);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 13018, 13839);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 13018, 13839);
            }
        }

        internal static void ReportTupleNamesMismatchesIfAny(TypeSymbol destination, BoundTupleLiteral literal, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10697, 13851, 15111);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 14006, 14049);

                var
                sourceNames = f_10697_14024_14048(literal)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 14063, 14144) || true) && (sourceNames.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 14063, 14144);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 14122, 14129);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 14063, 14144);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 14160, 14222);

                ImmutableArray<bool>
                inferredNames = f_10697_14197_14221(literal)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 14236, 14283);

                bool
                noInferredNames = inferredNames.IsDefault
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 14297, 14369);

                ImmutableArray<string>
                destinationNames = f_10697_14339_14368(destination)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 14383, 14421);

                int
                sourceLength = sourceNames.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 14435, 14480);

                bool
                allMissing = destinationNames.IsDefault
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 14494, 14562);

                f_10697_14494_14561(allMissing || (DynAbs.Tracing.TraceSender.Expression_False(10697, 14507, 14560) || destinationNames.Length == sourceLength));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 14587, 14592);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 14578, 15100) || true) && (i < sourceLength)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 14612, 14615)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 14578, 15100))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 14578, 15100);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 14649, 14681);

                        var
                        sourceName = sourceNames[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 14699, 14760);

                        var
                        wasInferred = (DynAbs.Tracing.TraceSender.Conditional_F1(10697, 14717, 14732) || ((noInferredNames && DynAbs.Tracing.TraceSender.Conditional_F2(10697, 14735, 14740)) || DynAbs.Tracing.TraceSender.Conditional_F3(10697, 14743, 14759))) ? false : inferredNames[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 14780, 15085) || true) && (sourceName != null && (DynAbs.Tracing.TraceSender.Expression_True(10697, 14784, 14818) && !wasInferred) && (DynAbs.Tracing.TraceSender.Expression_True(10697, 14784, 14897) && (allMissing || (DynAbs.Tracing.TraceSender.Expression_False(10697, 14823, 14896) || f_10697_14837_14891(destinationNames[i], sourceName) != 0))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 14780, 15085);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 14939, 15066);

                            f_10697_14939_15065(diagnostics, ErrorCode.WRN_TupleLiteralNameMismatch, f_10697_14995_15039(f_10697_14995_15012(literal)[i].Syntax.Parent!), sourceName, destination);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 14780, 15085);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10697, 1, 523);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10697, 1, 523);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10697, 13851, 15111);

                System.Collections.Immutable.ImmutableArray<string?>
                f_10697_14024_14048(Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                this_param)
                {
                    var return_v = this_param.ArgumentNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 14024, 14048);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<bool>
                f_10697_14197_14221(Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                this_param)
                {
                    var return_v = this_param.InferredNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 14197, 14221);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10697_14339_14368(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElementNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 14339, 14368);
                    return return_v;
                }


                int
                f_10697_14494_14561(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 14494, 14561);
                    return 0;
                }


                int
                f_10697_14837_14891(string
                strA, string
                strB)
                {
                    var return_v = string.CompareOrdinal(strA, strB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 14837, 14891);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10697_14995_15012(Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 14995, 15012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10697_14995_15039(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 14995, 15039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10697_14939_15065(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 14939, 15065);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 13851, 15111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 13851, 15111);
            }
        }

        private static WellKnownType GetTupleType(int arity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10697, 15332, 15583);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 15409, 15529) || true) && (arity > ValueTupleRestPosition)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 15409, 15529);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 15477, 15514);

                    throw f_10697_15483_15513();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 15409, 15529);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 15543, 15572);

                return tupleTypes[arity - 1];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10697, 15332, 15583);

                System.Exception
                f_10697_15483_15513()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 15483, 15513);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 15332, 15583);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 15332, 15583);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly WellKnownType[] tupleTypes;

        internal static WellKnownMember GetTupleCtor(int arity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10697, 16780, 17013);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 16860, 16959) || true) && (arity > 8)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 16860, 16959);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 16907, 16944);

                    throw f_10697_16913_16943();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 16860, 16959);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 16973, 17002);

                return tupleCtors[arity - 1];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10697, 16780, 17013);

                System.Exception
                f_10697_16913_16943()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 16913, 16943);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 16780, 17013);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 16780, 17013);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly WellKnownMember[] tupleCtors;

        /// <summary>
        /// Find the well-known members to the ValueTuple type of a given arity and position.
        /// For example, for arity=3 and position=1:
        /// returns WellKnownMember.System_ValueTuple_T3__Item1
        /// </summary>
        internal static WellKnownMember GetTupleTypeMember(int arity, int position)
        {
            return tupleMembers[arity - 1][position - 1];
        }

        private static readonly WellKnownMember[][] tupleMembers;

        internal static string TupleMemberName(int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10697, 22973, 23086);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 23050, 23075);

                return "Item" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (position).ToString(), 10697, 23066, 23074);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10697, 22973, 23086);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 22973, 23086);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 22973, 23086);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int IsTupleElementNameReserved(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10697, 23464, 24952);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 23548, 23638) || true) && (f_10697_23552_23580(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 23548, 23638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 23614, 23623);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 23548, 23638);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 23654, 23695);

                return f_10697_23661_23694(name);

                static bool isElementNameForbidden(string name)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10697, 23711, 24224);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 23791, 24209);

                        switch (name)
                        {

                            case "CompareTo":
                            case WellKnownMemberNames.DeconstructMethodName:
                            case "Equals":
                            case "GetHashCode":
                            case "Rest":
                            case "ToString":
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 23791, 24209);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 24107, 24119);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 23791, 24209);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 23791, 24209);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 24177, 24190);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 23791, 24209);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10697, 23711, 24224);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 23711, 24224);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 23711, 24224);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static int matchesCanonicalElementName(string name)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10697, 24317, 24941);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 24401, 24896) || true) && (f_10697_24405_24454(name, "Item", StringComparison.Ordinal))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 24401, 24896);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 24496, 24528);

                            string
                            tail = f_10697_24510_24527(name, 4)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 24550, 24561);

                            int
                            number
                            = default(int);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 24583, 24877) || true) && (f_10697_24587_24617(tail, out number))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 24583, 24877);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 24667, 24854) || true) && (number > 0 && (DynAbs.Tracing.TraceSender.Expression_True(10697, 24671, 24755) && f_10697_24685_24755(name, f_10697_24705_24728(number), StringComparison.Ordinal)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 24667, 24854);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 24813, 24827);

                                    return number;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 24667, 24854);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 24583, 24877);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 24401, 24896);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 24916, 24926);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10697, 24317, 24941);

                        bool
                        f_10697_24405_24454(string
                        this_param, string
                        value, System.StringComparison
                        comparisonType)
                        {
                            var return_v = this_param.StartsWith(value, comparisonType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 24405, 24454);
                            return return_v;
                        }


                        string
                        f_10697_24510_24527(string
                        this_param, int
                        startIndex)
                        {
                            var return_v = this_param.Substring(startIndex);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 24510, 24527);
                            return return_v;
                        }


                        bool
                        f_10697_24587_24617(string
                        s, out int
                        result)
                        {
                            var return_v = int.TryParse(s, out result);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 24587, 24617);
                            return return_v;
                        }


                        string
                        f_10697_24705_24728(int
                        position)
                        {
                            var return_v = TupleMemberName(position);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 24705, 24728);
                            return return_v;
                        }


                        bool
                        f_10697_24685_24755(string
                        a, string
                        b, System.StringComparison
                        comparisonType)
                        {
                            var return_v = String.Equals(a, b, comparisonType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 24685, 24755);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 24317, 24941);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 24317, 24941);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10697, 23464, 24952);

                bool
                f_10697_23552_23580(string
                name)
                {
                    var return_v = isElementNameForbidden(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 23552, 23580);
                    return return_v;
                }


                int
                f_10697_23661_23694(string
                name)
                {
                    var return_v = matchesCanonicalElementName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 23661, 23694);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 23464, 24952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 23464, 24952);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Symbol? GetWellKnownMemberInType(NamedTypeSymbol type, WellKnownMember relativeMember, DiagnosticBag diagnostics, SyntaxNode? syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10697, 25103, 27443);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 25277, 25341);

                Symbol?
                member = f_10697_25294_25340(type, relativeMember)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 25357, 26021) || true) && (member is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 25357, 26021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 25409, 25494);

                    MemberDescriptor
                    relativeDescriptor = f_10697_25447_25493(relativeMember)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 25512, 25656);

                    f_10697_25512_25655(diagnostics, ErrorCode.ERR_PredefinedTypeMemberNotFoundInAssembly, syntax, relativeDescriptor.Name, type, f_10697_25631_25654(type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 25357, 26021);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 25357, 26021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 25722, 25781);

                    DiagnosticInfo
                    useSiteDiag = f_10697_25751_25780(member)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 25799, 26006) || true) && (useSiteDiag is object && (DynAbs.Tracing.TraceSender.Expression_True(10697, 25803, 25876) && f_10697_25828_25848(useSiteDiag) == DiagnosticSeverity.Error))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 25799, 26006);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 25918, 25987);

                        f_10697_25918_25986(diagnostics, useSiteDiag, f_10697_25947_25968_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(syntax, 10697, 25947, 25968)?.GetLocation()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Location?>(10697, 25947, 25985) ?? f_10697_25972_25985()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 25799, 26006);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 25357, 26021);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 26037, 26051);

                return member;

                static Symbol? GetWellKnownMemberInType(NamedTypeSymbol type, WellKnownMember relativeMember)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10697, 26648, 27432);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 26774, 26917);

                        f_10697_26774_26916(relativeMember >= WellKnownMember.System_ValueTuple_T1__Item1 && (DynAbs.Tracing.TraceSender.Expression_True(10697, 26787, 26915) && relativeMember <= WellKnownMember.System_ValueTuple_TRest__ctor));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 26935, 26967);

                        f_10697_26935_26966(f_10697_26948_26965(type));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 26987, 27072);

                        MemberDescriptor
                        relativeDescriptor = f_10697_27025_27071(relativeMember)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 27090, 27145);

                        var
                        members = f_10697_27104_27144(type, relativeDescriptor.Name)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 27165, 27378);

                        return f_10697_27172_27377(members, relativeDescriptor, CSharpCompilation.SpecialMembersSignatureComparer.Instance, accessWithinOpt: null);
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10697, 26648, 27432);

                        int
                        f_10697_26774_26916(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 26774, 26916);
                            return 0;
                        }


                        bool
                        f_10697_26948_26965(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.IsDefinition;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 26948, 26965);
                            return return_v;
                        }


                        int
                        f_10697_26935_26966(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 26935, 26966);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor
                        f_10697_27025_27071(Microsoft.CodeAnalysis.WellKnownMember
                        member)
                        {
                            var return_v = WellKnownMembers.GetDescriptor(member);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 27025, 27071);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        f_10697_27104_27144(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param, string
                        name)
                        {
                            var return_v = this_param.GetMembers(name);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 27104, 27144);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol?
                        f_10697_27172_27377(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        members, Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor
                        descriptor, Microsoft.CodeAnalysis.CSharp.CSharpCompilation.SpecialMembersSignatureComparer
                        comparer, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol?
                        accessWithinOpt)
                        {
                            var return_v = CSharpCompilation.GetRuntimeMember(members, descriptor, (Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>)comparer, accessWithinOpt: accessWithinOpt);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 27172, 27377);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 26648, 27432);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 26648, 27432);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10697, 25103, 27443);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10697_25294_25340(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.WellKnownMember
                relativeMember)
                {
                    var return_v = GetWellKnownMemberInType(type, relativeMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 25294, 25340);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor
                f_10697_25447_25493(Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = WellKnownMembers.GetDescriptor(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 25447, 25493);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10697_25631_25654(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 25631, 25654);
                    return return_v;
                }


                int
                f_10697_25512_25655(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode?
                syntax, params object[]
                args)
                {
                    Binder.Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 25512, 25655);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10697_25751_25780(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 25751, 25780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10697_25828_25848(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 25828, 25848);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location?
                f_10697_25947_25968_I(Microsoft.CodeAnalysis.Location?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 25947, 25968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10697_25972_25985()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 25972, 25985);
                    return return_v;
                }


                int
                f_10697_25918_25986(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 25918, 25986);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 25103, 27443);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 25103, 27443);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool IsTupleType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10697, 27508, 27560);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 27511, 27560);
                    return f_10697_27511_27560(this, tupleCardinality: out _); DynAbs.Tracing.TraceSender.TraceExitMethod(10697, 27508, 27560);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 27508, 27560);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 27508, 27560);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal TupleExtraData? TupleData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10697, 27632, 28001);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 27668, 27757) || true) && (f_10697_27672_27684_M(!IsTupleType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 27668, 27757);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 27726, 27738);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 27668, 27757);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 27777, 27944) || true) && (_lazyTupleData is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 27777, 27944);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 27845, 27925);

                        f_10697_27845_27924(ref _lazyTupleData, f_10697_27893_27917(this), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 27777, 27944);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 27964, 27986);

                    return _lazyTupleData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10697, 27632, 28001);

                    bool
                    f_10697_27672_27684_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 27672, 27684);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
                    f_10697_27893_27917(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    underlyingType)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData(underlyingType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 27893, 27917);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData?
                    f_10697_27845_27924(ref Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData?
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 27845, 27924);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 27573, 28012);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 27573, 28012);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<string?> TupleElementNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10697, 28102, 28167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 28105, 28167);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10697, 28105, 28127) || ((_lazyTupleData is null && DynAbs.Tracing.TraceSender.Conditional_F2(10697, 28130, 28137)) || DynAbs.Tracing.TraceSender.Conditional_F3(10697, 28140, 28167))) ? default : f_10697_28140_28167(_lazyTupleData); DynAbs.Tracing.TraceSender.TraceExitMethod(10697, 28102, 28167);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 28102, 28167);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 28102, 28167);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ImmutableArray<bool> TupleErrorPositions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10697, 28242, 28309);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 28245, 28309);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10697, 28245, 28267) || ((_lazyTupleData is null && DynAbs.Tracing.TraceSender.Conditional_F2(10697, 28270, 28277)) || DynAbs.Tracing.TraceSender.Conditional_F3(10697, 28280, 28309))) ? default : f_10697_28280_28309(_lazyTupleData); DynAbs.Tracing.TraceSender.TraceExitMethod(10697, 28242, 28309);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 28242, 28309);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 28242, 28309);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ImmutableArray<Location?> TupleElementLocations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10697, 28391, 28460);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 28394, 28460);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10697, 28394, 28416) || ((_lazyTupleData is null && DynAbs.Tracing.TraceSender.Conditional_F2(10697, 28419, 28426)) || DynAbs.Tracing.TraceSender.Conditional_F3(10697, 28429, 28460))) ? default : f_10697_28429_28460(_lazyTupleData); DynAbs.Tracing.TraceSender.TraceExitMethod(10697, 28391, 28460);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 28391, 28460);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 28391, 28460);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<TypeWithAnnotations> TupleElementTypesWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10697, 28578, 28654);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 28581, 28654);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10697, 28581, 28592) || ((f_10697_28581_28592() && DynAbs.Tracing.TraceSender.Conditional_F2(10697, 28595, 28644)) || DynAbs.Tracing.TraceSender.Conditional_F3(10697, 28647, 28654))) ? f_10697_28595_28644(TupleData!, this) : default; DynAbs.Tracing.TraceSender.TraceExitMethod(10697, 28578, 28654);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 28578, 28654);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 28578, 28654);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<FieldSymbol> TupleElements
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10697, 28745, 28802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 28748, 28802);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10697, 28748, 28759) || ((f_10697_28748_28759() && DynAbs.Tracing.TraceSender.Conditional_F2(10697, 28762, 28792)) || DynAbs.Tracing.TraceSender.Conditional_F3(10697, 28795, 28802))) ? f_10697_28762_28792(TupleData!, this) : default; DynAbs.Tracing.TraceSender.TraceExitMethod(10697, 28745, 28802);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 28745, 28802);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 28745, 28802);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TMember? GetTupleMemberSymbolForUnderlyingMember<TMember>(TMember underlyingMemberOpt) where TMember : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10697, 28815, 29067);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 28956, 29056);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10697, 28963, 28974) || ((f_10697_28963_28974<TMember>() && DynAbs.Tracing.TraceSender.Conditional_F2(10697, 28977, 29048)) || DynAbs.Tracing.TraceSender.Conditional_F3(10697, 29051, 29055))) ? f_10697_28977_29048<TMember>(TupleData!, underlyingMemberOpt) : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10697, 28815, 29067);

                bool
                f_10697_28963_28974<TMember>() where TMember : Symbol

                {
                    var return_v = IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 28963, 28974);
                    return return_v;
                }


                TMember?
                f_10697_28977_29048<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
                this_param, TMember
                underlyingMemberOpt) where TMember : Symbol

                {
                    var return_v = this_param.GetTupleMemberSymbolForUnderlyingMember<TMember>(underlyingMemberOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 28977, 29048);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 28815, 29067);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 28815, 29067);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected ArrayBuilder<Symbol> AddOrWrapTupleMembers(ImmutableArray<Symbol> currentMembers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10697, 29079, 45556);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 29195, 29221);

                f_10697_29195_29220(f_10697_29208_29219());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 29235, 29313);

                f_10697_29235_29312(currentMembers.All(m => !(m is TupleVirtualElementFieldSymbol)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 29329, 29381);

                var
                elementTypes = f_10697_29348_29380()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 29395, 29499);

                var
                elementsMatchedByFields = f_10697_29425_29498(elementTypes.Length, fillWithValue: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 29513, 29583);

                var
                members = f_10697_29527_29582(currentMembers.Length)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 29599, 29640);

                NamedTypeSymbol
                currentValueTuple = this
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 29654, 29682);

                int
                currentNestingLevel = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 29698, 29793);

                var
                currentFieldsForElements = f_10697_29729_29792(f_10697_29768_29791(currentValueTuple))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 29876, 29987);

                f_10697_29876_29986(f_10697_29901_29924(currentValueTuple), f_10697_29926_29959(currentMembers), currentFieldsForElements);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 30003, 30040);

                var
                elementNames = f_10697_30022_30039()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 30054, 30105);

                var
                elementLocations = f_10697_30077_30104(TupleData!)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 30119, 39017) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 30119, 39017);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 30164, 38015);
                            foreach (Symbol member in f_10697_30190_30204_I(currentMembers))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 30164, 38015);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 30246, 37996);

                                switch (f_10697_30254_30265(member))
                                {

                                    case SymbolKind.Field:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 30246, 37996);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 30367, 30399);

                                        var
                                        field = (FieldSymbol)member
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 30429, 30578) || true) && (field is TupleVirtualElementFieldSymbol)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 30429, 30578);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 30538, 30547);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 30429, 30578);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 30610, 30755);

                                        var
                                        underlyingField = (DynAbs.Tracing.TraceSender.Conditional_F1(10697, 30632, 30677) || ((field is TupleElementFieldSymbol tupleElement && DynAbs.Tracing.TraceSender.Conditional_F2(10697, 30680, 30727)) || DynAbs.Tracing.TraceSender.Conditional_F3(10697, 30730, 30754))) ? f_10697_30680_30727(f_10697_30680_30708((TupleElementFieldSymbol)field)) : f_10697_30730_30754(field)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 30785, 30893);

                                        int
                                        tupleFieldIndex = f_10697_30807_30892(currentFieldsForElements, underlyingField, ReferenceEqualityComparer.Instance)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 30923, 37116) || true) && (underlyingField is TupleErrorFieldSymbol)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 30923, 37116);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 31125, 31134);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 30923, 37116);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 30923, 37116);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 31200, 37116) || true) && (tupleFieldIndex >= 0)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 31200, 37116);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 31436, 31643) || true) && (currentNestingLevel != 0)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 31436, 31643);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 31538, 31608);

                                                    tupleFieldIndex += (ValueTupleRestPosition - 1) * currentNestingLevel;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 31436, 31643);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 31679, 31760);

                                                var
                                                providedName = (DynAbs.Tracing.TraceSender.Conditional_F1(10697, 31698, 31720) || ((elementNames.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10697, 31723, 31727)) || DynAbs.Tracing.TraceSender.Conditional_F3(10697, 31730, 31759))) ? null : elementNames[tupleFieldIndex]
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 31796, 31831);

                                                ImmutableArray<Location>
                                                locations
                                                = default(ImmutableArray<Location>);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 31865, 32595) || true) && (f_10697_31869_31886(this))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 31865, 32595);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 31960, 31989);

                                                    locations = f_10697_31972_31988(member);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 31865, 32595);
                                                }

                                                else
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 31865, 32595);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 32063, 32595) || true) && (elementLocations.IsDefault)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 32063, 32595);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 32167, 32210);

                                                        locations = ImmutableArray<Location>.Empty;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 32063, 32595);
                                                    }

                                                    else

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 32063, 32595);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 32356, 32412);

                                                        var
                                                        elementLocation = elementLocations[tupleFieldIndex]
                                                        ;
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 32450, 32560);

                                                        locations = (DynAbs.Tracing.TraceSender.Conditional_F1(10697, 32462, 32485) || ((elementLocation == null && DynAbs.Tracing.TraceSender.Conditional_F2(10697, 32488, 32518)) || DynAbs.Tracing.TraceSender.Conditional_F3(10697, 32521, 32559))) ? ImmutableArray<Location>.Empty : f_10697_32521_32559(elementLocation);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 32063, 32595);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 31865, 32595);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 32631, 32686);

                                                var
                                                defaultName = f_10697_32649_32685(tupleFieldIndex + 1)
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 32885, 32945);

                                                var
                                                defaultImplicitlyDeclared = providedName != defaultName
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 33081, 33123);

                                                TupleElementFieldSymbol
                                                defaultTupleField
                                                = default(TupleElementFieldSymbol);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 33157, 33219);

                                                var
                                                fieldSymbol = f_10697_33175_33218(underlyingField, currentValueTuple)
                                                ;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 33253, 35495) || true) && (currentNestingLevel != 0)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 33253, 35495);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 33544, 34413);

                                                    defaultTupleField = f_10697_33564_34412(this, fieldSymbol, defaultName, tupleFieldIndex, locations, cannotUse: false, isImplicitlyDeclared: defaultImplicitlyDeclared, correspondingDefaultFieldOpt: null);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 33253, 35495);
                                                }

                                                else

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 33253, 35495);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 34559, 34659);

                                                    f_10697_34559_34658(f_10697_34572_34588(fieldSymbol) == defaultName, "top level underlying field must match default name");
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 34855, 35460);

                                                    defaultTupleField = f_10697_34875_35459(this, fieldSymbol, tupleFieldIndex, locations, isImplicitlyDeclared: defaultImplicitlyDeclared, correspondingDefaultFieldOpt: null);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 33253, 35495);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 35531, 35562);

                                                f_10697_35531_35561(
                                                                                members, defaultTupleField);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 35598, 36648) || true) && (defaultImplicitlyDeclared && (DynAbs.Tracing.TraceSender.Expression_True(10697, 35602, 35666) && !f_10697_35632_35666(providedName)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 35598, 36648);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 35740, 35781);

                                                    var
                                                    errorPositions = f_10697_35761_35780()
                                                    ;
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 35819, 35900);

                                                    var
                                                    isError = (DynAbs.Tracing.TraceSender.Conditional_F1(10697, 35833, 35857) || ((errorPositions.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10697, 35860, 35865)) || DynAbs.Tracing.TraceSender.Conditional_F3(10697, 35868, 35899))) ? false : errorPositions[tupleFieldIndex]
                                                    ;
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 36118, 36613);

                                                    f_10697_36118_36612(
                                                                                        // The name given doesn't match the default name Item8, etc.
                                                                                        // Add a virtual field with the given name
                                                                                        members, f_10697_36130_36611(this, fieldSymbol, providedName!, tupleFieldIndex, locations, cannotUse: isError, isImplicitlyDeclared: false, correspondingDefaultFieldOpt: defaultTupleField));
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 35598, 36648);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 36684, 36732);

                                                elementsMatchedByFields[tupleFieldIndex] = true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 31200, 37116);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 31200, 37116);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 36817, 37116) || true) && (currentNestingLevel == 0)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 36817, 37116);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 37018, 37085);

                                                    f_10697_37018_37084(                                // field at the top level didn't match a tuple backing field, simply add.
                                                                                    members, f_10697_37030_37083(this, field, f_10697_37064_37078_M(-members.Count) - 1));
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 36817, 37116);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 31200, 37116);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 30923, 37116);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(10697, 37146, 37152);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 30246, 37996);

                                    case SymbolKind.NamedType:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 30246, 37996);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10697, 37325, 37331);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 30246, 37996);

                                    case SymbolKind.Method:
                                    case SymbolKind.Property:
                                    case SymbolKind.Event:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 30246, 37996);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 37511, 37656) || true) && (currentNestingLevel == 0)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 37511, 37656);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 37605, 37625);

                                            f_10697_37605_37624(members, member);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 37511, 37656);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(10697, 37686, 37692);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 30246, 37996);

                                    default:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 30246, 37996);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 37758, 37937) || true) && (currentNestingLevel == 0)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 37758, 37937);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 37852, 37906);

                                            throw f_10697_37858_37905(f_10697_37893_37904(member));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 37758, 37937);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(10697, 37967, 37973);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 30246, 37996);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 30164, 38015);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10697, 1, 7852);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10697, 1, 7852);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 38035, 38155) || true) && (f_10697_38039_38062(currentValueTuple) != ValueTupleRestPosition)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 38035, 38155);
                            DynAbs.Tracing.TraceSender.TraceBreak(10697, 38130, 38136);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 38035, 38155);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 38175, 38213);

                        var
                        oldUnderlying = currentValueTuple
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 38231, 38357);

                        currentValueTuple = (NamedTypeSymbol)f_10697_38268_38330(oldUnderlying)[ValueTupleRestIndex].Type;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 38375, 38397);

                        currentNestingLevel++;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 38417, 39002) || true) && (f_10697_38421_38444(currentValueTuple) != ValueTupleRestPosition)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 38417, 39002);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 38570, 38618);

                            currentMembers = f_10697_38587_38617(currentValueTuple);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 38640, 38673);

                            f_10697_38640_38672(currentFieldsForElements);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 38695, 38806);

                            f_10697_38695_38805(f_10697_38720_38743(currentValueTuple), f_10697_38745_38778(currentMembers), currentFieldsForElements);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 38417, 39002);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 38417, 39002);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 38888, 38983);

                            f_10697_38888_38982((object)f_10697_38909_38941(oldUnderlying) == f_10697_38945_38981(currentValueTuple));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 38417, 39002);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 30119, 39017);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10697, 30119, 39017);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10697, 30119, 39017);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 39033, 39065);

                f_10697_39033_39064(
                            currentFieldsForElements);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 39156, 39161);

                    // At the end, add unmatched fields as error symbols
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 39147, 42628) || true) && (i < f_10697_39167_39196(elementsMatchedByFields))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 39198, 39201)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 39147, 42628))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 39147, 42628);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 39235, 42613) || true) && (f_10697_39239_39266_M(!elementsMatchedByFields[i]))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 39235, 42613);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 39417, 39436);

                            int
                            fieldRemainder
                            = default(int);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 39471, 39541);

                            int
                            fieldChainLength = f_10697_39494_39540(i + 1, out fieldRemainder)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 39563, 39667);

                            NamedTypeSymbol
                            container = f_10697_39591_39666(f_10697_39591_39647(this, fieldChainLength - 1))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 39691, 40252);

                            var
                            diagnosticInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10697, 39712, 39735) || ((f_10697_39712_39735(container) && DynAbs.Tracing.TraceSender.Conditional_F2(10697, 39797, 39801)) || DynAbs.Tracing.TraceSender.Conditional_F3(10697, 39863, 40251))) ? null : f_10697_39863_40251(ErrorCode.ERR_PredefinedTypeMemberNotFoundInAssembly, f_10697_40018_40049(fieldRemainder), container, f_10697_40222_40250(container))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 40276, 40343);

                            var
                            providedName = (DynAbs.Tracing.TraceSender.Conditional_F1(10697, 40295, 40317) || ((elementNames.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10697, 40320, 40324)) || DynAbs.Tracing.TraceSender.Conditional_F3(10697, 40327, 40342))) ? null : elementNames[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 40365, 40436);

                            var
                            location = (DynAbs.Tracing.TraceSender.Conditional_F1(10697, 40380, 40406) || ((elementLocations.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10697, 40409, 40413)) || DynAbs.Tracing.TraceSender.Conditional_F3(10697, 40416, 40435))) ? null : elementLocations[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 40458, 40499);

                            var
                            defaultName = f_10697_40476_40498(i + 1)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 40662, 40722);

                            var
                            defaultImplicitlyDeclared = providedName != defaultName
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 40834, 41688);

                            TupleErrorFieldSymbol
                            defaultTupleField = f_10697_40876_41687(this, defaultName, i, (DynAbs.Tracing.TraceSender.Conditional_F1(10697, 41191, 41216) || ((defaultImplicitlyDeclared && DynAbs.Tracing.TraceSender.Conditional_F2(10697, 41219, 41223)) || DynAbs.Tracing.TraceSender.Conditional_F3(10697, 41226, 41234))) ? null : location, elementTypes[i], diagnosticInfo, defaultImplicitlyDeclared, correspondingDefaultFieldOpt: null)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 41712, 41743);

                            f_10697_41712_41742(
                                                members, defaultTupleField);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 41767, 42594) || true) && (defaultImplicitlyDeclared && (DynAbs.Tracing.TraceSender.Expression_True(10697, 41771, 41835) && !f_10697_41801_41835(providedName)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 41767, 42594);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 41947, 42571);

                                f_10697_41947_42570(                        // Add friendly named element field.
                                                        members, f_10697_41959_42569(this, providedName, i, location, elementTypes[i], diagnosticInfo, isImplicitlyDeclared: false, correspondingDefaultFieldOpt: defaultTupleField));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 41767, 42594);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 39235, 42613);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10697, 1, 3482);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10697, 1, 3482);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 42644, 42675);

                f_10697_42644_42674(
                            elementsMatchedByFields);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 42689, 42704);

                return members;

                static NamedTypeSymbol getNestedTupleUnderlyingType(NamedTypeSymbol topLevelUnderlyingType, int depth)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10697, 42935, 43387);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 43070, 43117);

                        NamedTypeSymbol
                        found = topLevelUnderlyingType
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 43144, 43149);
                            for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 43135, 43339) || true) && (i < depth)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 43162, 43165)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 43135, 43339))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 43135, 43339);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 43207, 43320);

                                found = (NamedTypeSymbol)f_10697_43232_43286(found)[ValueTupleRestPosition - 1].Type;
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10697, 1, 205);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10697, 1, 205);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 43359, 43372);

                        return found;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10697, 42935, 43387);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        f_10697_43232_43286(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 43232, 43286);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 42935, 43387);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 42935, 43387);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static void collectTargetTupleFields(int arity, ImmutableArray<Symbol> members, ArrayBuilder<FieldSymbol?> fieldsForElements)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10697, 43403, 43944);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 43561, 43625);

                        int
                        fieldsPerType = f_10697_43581_43624(arity, ValueTupleRestPosition - 1)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 43654, 43659);

                            for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 43645, 43929) || true) && (i < fieldsPerType)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 43680, 43683)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 43645, 43929))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 43645, 43929);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 43725, 43796);

                                WellKnownMember
                                wellKnownTupleField = f_10697_43763_43795(arity, i + 1)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 43818, 43910);

                                f_10697_43818_43909(fieldsForElements, f_10697_43854_43908(members, wellKnownTupleField));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10697, 1, 285);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10697, 1, 285);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10697, 43403, 43944);

                        int
                        f_10697_43581_43624(int
                        val1, int
                        val2)
                        {
                            var return_v = Math.Min(val1, val2);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 43581, 43624);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.WellKnownMember
                        f_10697_43763_43795(int
                        arity, int
                        position)
                        {
                            var return_v = GetTupleTypeMember(arity, position);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 43763, 43795);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol?
                        f_10697_43854_43908(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        members, Microsoft.CodeAnalysis.WellKnownMember
                        relativeMember)
                        {
                            var return_v = GetWellKnownMemberInType(members, relativeMember);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 43854, 43908);
                            return return_v;
                        }


                        int
                        f_10697_43818_43909(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbol?
                        item)
                        {
                            this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?)item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 43818, 43909);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 43403, 43944);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 43403, 43944);
                    }
                }

                static Symbol? GetWellKnownMemberInType(ImmutableArray<Symbol> members, WellKnownMember relativeMember)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10697, 43960, 44629);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 44096, 44239);

                        f_10697_44096_44238(relativeMember >= WellKnownMember.System_ValueTuple_T1__Item1 && (DynAbs.Tracing.TraceSender.Expression_True(10697, 44109, 44237) && relativeMember <= WellKnownMember.System_ValueTuple_TRest__ctor));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 44259, 44344);

                        MemberDescriptor
                        relativeDescriptor = f_10697_44297_44343(relativeMember)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 44362, 44575);

                        return f_10697_44369_44574(members, relativeDescriptor, CSharpCompilation.SpecialMembersSignatureComparer.Instance, accessWithinOpt: null);
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10697, 43960, 44629);

                        int
                        f_10697_44096_44238(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 44096, 44238);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor
                        f_10697_44297_44343(Microsoft.CodeAnalysis.WellKnownMember
                        member)
                        {
                            var return_v = WellKnownMembers.GetDescriptor(member);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 44297, 44343);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol?
                        f_10697_44369_44574(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        members, Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor
                        descriptor, Microsoft.CodeAnalysis.CSharp.CSharpCompilation.SpecialMembersSignatureComparer
                        comparer, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol?
                        accessWithinOpt)
                        {
                            var return_v = CSharpCompilation.GetRuntimeMember(members, descriptor, (Microsoft.CodeAnalysis.RuntimeMembers.SignatureComparer<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>)comparer, accessWithinOpt: accessWithinOpt);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 44369, 44574);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 43960, 44629);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 43960, 44629);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static ImmutableArray<Symbol> getOriginalFields(ImmutableArray<Symbol> members)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10697, 44645, 45545);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 44757, 44805);

                        var
                        fields = f_10697_44770_44804()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 44823, 45414);
                            foreach (var member in f_10697_44846_44853_I(members))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 44823, 45414);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 44895, 45395) || true) && (member is TupleVirtualElementFieldSymbol)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 44895, 45395);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 44989, 44998);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 44895, 45395);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 44895, 45395);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 45048, 45395) || true) && (member is TupleElementFieldSymbol tupleField)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 45048, 45395);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 45146, 45204);

                                        f_10697_45146_45203(fields, f_10697_45157_45202(f_10697_45157_45183(tupleField)));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 45048, 45395);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 45048, 45395);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 45254, 45395) || true) && (member is FieldSymbol field)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 45254, 45395);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 45335, 45372);

                                            f_10697_45335_45371(fields, f_10697_45346_45370(field));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 45254, 45395);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 45048, 45395);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 44895, 45395);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 44823, 45414);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10697, 1, 592);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10697, 1, 592);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 45434, 45477);

                        f_10697_45434_45476(f_10697_45447_45475(fields, f => f is object));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 45495, 45530);

                        return f_10697_45502_45529(fields);
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10697, 44645, 45545);

                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        f_10697_44770_44804()
                        {
                            var return_v = ArrayBuilder<Symbol>.GetInstance();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 44770, 44804);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                        f_10697_45157_45183(Microsoft.CodeAnalysis.CSharp.Symbols.TupleElementFieldSymbol
                        this_param)
                        {
                            var return_v = this_param.UnderlyingField;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 45157, 45183);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                        f_10697_45157_45202(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                        this_param)
                        {
                            var return_v = this_param.OriginalDefinition;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 45157, 45202);
                            return return_v;
                        }


                        int
                        f_10697_45146_45203(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                        item)
                        {
                            this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 45146, 45203);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                        f_10697_45346_45370(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                        this_param)
                        {
                            var return_v = this_param.OriginalDefinition;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 45346, 45370);
                            return return_v;
                        }


                        int
                        f_10697_45335_45371(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                        item)
                        {
                            this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 45335, 45371);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        f_10697_44846_44853_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 44846, 44853);
                            return return_v;
                        }


                        bool
                        f_10697_45447_45475(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        builder, System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, bool>
                        predicate)
                        {
                            var return_v = builder.All<Microsoft.CodeAnalysis.CSharp.Symbol>(predicate);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 45447, 45475);
                            return return_v;
                        }


                        int
                        f_10697_45434_45476(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 45434, 45476);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        f_10697_45502_45529(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param)
                        {
                            var return_v = this_param.ToImmutableAndFree();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 45502, 45529);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 44645, 45545);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 44645, 45545);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10697, 29079, 45556);

                bool
                f_10697_29208_29219()
                {
                    var return_v = IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 29208, 29219);
                    return return_v;
                }


                int
                f_10697_29195_29220(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 29195, 29220);
                    return 0;
                }


                int
                f_10697_29235_29312(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 29235, 29312);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10697_29348_29380()
                {
                    var return_v = TupleElementTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 29348, 29380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                f_10697_29425_29498(int
                capacity, bool
                fillWithValue)
                {
                    var return_v = ArrayBuilder<bool>.GetInstance(capacity, fillWithValue: fillWithValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 29425, 29498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10697_29527_29582(int
                capacity)
                {
                    var return_v = ArrayBuilder<Symbol>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 29527, 29582);
                    return return_v;
                }


                int
                f_10697_29768_29791(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 29768, 29791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?>
                f_10697_29729_29792(int
                capacity)
                {
                    var return_v = ArrayBuilder<FieldSymbol?>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 29729, 29792);
                    return return_v;
                }


                int
                f_10697_29901_29924(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 29901, 29924);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10697_29926_29959(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                members)
                {
                    var return_v = getOriginalFields(members);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 29926, 29959);
                    return return_v;
                }


                int
                f_10697_29876_29986(int
                arity, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                members, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?>
                fieldsForElements)
                {
                    collectTargetTupleFields(arity, members, fieldsForElements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 29876, 29986);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string?>
                f_10697_30022_30039()
                {
                    var return_v = TupleElementNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 30022, 30039);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
                f_10697_30077_30104(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
                this_param)
                {
                    var return_v = this_param.ElementLocations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 30077, 30104);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10697_30254_30265(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 30254, 30265);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10697_30680_30708(Microsoft.CodeAnalysis.CSharp.Symbols.TupleElementFieldSymbol
                this_param)
                {
                    var return_v = this_param.UnderlyingField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 30680, 30708);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10697_30680_30727(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 30680, 30727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10697_30730_30754(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 30730, 30754);
                    return return_v;
                }


                int
                f_10697_30807_30892(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                item, Roslyn.Utilities.ReferenceEqualityComparer
                equalityComparer)
                {
                    var return_v = this_param.IndexOf(item, (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?>)equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 30807, 30892);
                    return return_v;
                }


                bool
                f_10697_31869_31886(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 31869, 31886);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10697_31972_31988(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 31972, 31988);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10697_32521_32559(Microsoft.CodeAnalysis.Location
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 32521, 32559);
                    return return_v;
                }


                string
                f_10697_32649_32685(int
                position)
                {
                    var return_v = TupleMemberName(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 32649, 32685);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10697_33175_33218(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 33175, 33218);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TupleVirtualElementFieldSymbol
                f_10697_33564_34412(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                underlyingField, string
                name, int
                tupleElementIndex, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations, bool
                cannotUse, bool
                isImplicitlyDeclared, Microsoft.CodeAnalysis.CSharp.Symbols.TupleElementFieldSymbol?
                correspondingDefaultFieldOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TupleVirtualElementFieldSymbol(container, underlyingField, name, tupleElementIndex, locations, cannotUse: cannotUse, isImplicitlyDeclared: isImplicitlyDeclared, correspondingDefaultFieldOpt: correspondingDefaultFieldOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 33564, 34412);
                    return return_v;
                }


                string
                f_10697_34572_34588(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 34572, 34588);
                    return return_v;
                }


                int
                f_10697_34559_34658(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 34559, 34658);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TupleElementFieldSymbol
                f_10697_34875_35459(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                underlyingField, int
                tupleElementIndex, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations, bool
                isImplicitlyDeclared, Microsoft.CodeAnalysis.CSharp.Symbols.TupleElementFieldSymbol?
                correspondingDefaultFieldOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TupleElementFieldSymbol(container, underlyingField, tupleElementIndex, locations, isImplicitlyDeclared: isImplicitlyDeclared, correspondingDefaultFieldOpt: correspondingDefaultFieldOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 34875, 35459);
                    return return_v;
                }


                int
                f_10697_35531_35561(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TupleElementFieldSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 35531, 35561);
                    return 0;
                }


                bool
                f_10697_35632_35666(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 35632, 35666);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<bool>
                f_10697_35761_35780()
                {
                    var return_v = TupleErrorPositions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 35761, 35780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TupleVirtualElementFieldSymbol
                f_10697_36130_36611(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                underlyingField, string
                name, int
                tupleElementIndex, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations, bool
                cannotUse, bool
                isImplicitlyDeclared, Microsoft.CodeAnalysis.CSharp.Symbols.TupleElementFieldSymbol
                correspondingDefaultFieldOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TupleVirtualElementFieldSymbol(container, underlyingField, name, tupleElementIndex, locations, cannotUse: cannotUse, isImplicitlyDeclared: isImplicitlyDeclared, correspondingDefaultFieldOpt: correspondingDefaultFieldOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 36130, 36611);
                    return return_v;
                }


                int
                f_10697_36118_36612(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TupleVirtualElementFieldSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 36118, 36612);
                    return 0;
                }


                int
                f_10697_37064_37078_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 37064, 37078);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TupleFieldSymbol
                f_10697_37030_37083(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                underlyingField, int
                tupleElementIndex)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TupleFieldSymbol(container, underlyingField, tupleElementIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 37030, 37083);
                    return return_v;
                }


                int
                f_10697_37018_37084(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TupleFieldSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 37018, 37084);
                    return 0;
                }


                int
                f_10697_37605_37624(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 37605, 37624);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10697_37893_37904(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 37893, 37904);
                    return return_v;
                }


                System.Exception
                f_10697_37858_37905(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 37858, 37905);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10697_30190_30204_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 30190, 30204);
                    return return_v;
                }


                int
                f_10697_38039_38062(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 38039, 38062);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10697_38268_38330(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 38268, 38330);
                    return return_v;
                }


                int
                f_10697_38421_38444(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 38421, 38444);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10697_38587_38617(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 38587, 38617);
                    return return_v;
                }


                int
                f_10697_38640_38672(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 38640, 38672);
                    return 0;
                }


                int
                f_10697_38720_38743(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 38720, 38743);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10697_38745_38778(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                members)
                {
                    var return_v = getOriginalFields(members);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 38745, 38778);
                    return return_v;
                }


                int
                f_10697_38695_38805(int
                arity, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                members, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?>
                fieldsForElements)
                {
                    collectTargetTupleFields(arity, members, fieldsForElements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 38695, 38805);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10697_38909_38941(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 38909, 38941);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10697_38945_38981(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 38945, 38981);
                    return return_v;
                }


                int
                f_10697_38888_38982(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 38888, 38982);
                    return 0;
                }


                int
                f_10697_39033_39064(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 39033, 39064);
                    return 0;
                }


                int
                f_10697_39167_39196(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 39167, 39196);
                    return return_v;
                }


                bool
                f_10697_39239_39266_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 39239, 39266);
                    return return_v;
                }


                int
                f_10697_39494_39540(int
                numElements, out int
                remainder)
                {
                    var return_v = NumberOfValueTuples(numElements, out remainder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 39494, 39540);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10697_39591_39647(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                topLevelUnderlyingType, int
                depth)
                {
                    var return_v = getNestedTupleUnderlyingType(topLevelUnderlyingType, depth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 39591, 39647);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10697_39591_39666(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 39591, 39666);
                    return return_v;
                }


                bool
                f_10697_39712_39735(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 39712, 39735);
                    return return_v;
                }


                string
                f_10697_40018_40049(int
                position)
                {
                    var return_v = TupleMemberName(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 40018, 40049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10697_40222_40250(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 40222, 40250);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10697_39863_40251(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 39863, 40251);
                    return return_v;
                }


                string
                f_10697_40476_40498(int
                position)
                {
                    var return_v = TupleMemberName(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 40476, 40498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TupleErrorFieldSymbol
                f_10697_40876_41687(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container, string
                name, int
                tupleElementIndex, Microsoft.CodeAnalysis.Location?
                location, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo?
                useSiteDiagnosticInfo, bool
                isImplicitlyDeclared, Microsoft.CodeAnalysis.CSharp.Symbols.TupleErrorFieldSymbol
                correspondingDefaultFieldOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TupleErrorFieldSymbol(container, name, tupleElementIndex, location, type, (Microsoft.CodeAnalysis.DiagnosticInfo?)useSiteDiagnosticInfo, isImplicitlyDeclared, correspondingDefaultFieldOpt: correspondingDefaultFieldOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 40876, 41687);
                    return return_v;
                }


                int
                f_10697_41712_41742(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TupleErrorFieldSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 41712, 41742);
                    return 0;
                }


                bool
                f_10697_41801_41835(string?
                value)
                {
                    var return_v = String.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 41801, 41835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TupleErrorFieldSymbol
                f_10697_41959_42569(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container, string
                name, int
                tupleElementIndex, Microsoft.CodeAnalysis.Location?
                location, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo?
                useSiteDiagnosticInfo, bool
                isImplicitlyDeclared, Microsoft.CodeAnalysis.CSharp.Symbols.TupleErrorFieldSymbol
                correspondingDefaultFieldOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TupleErrorFieldSymbol(container, name, tupleElementIndex, location, type, (Microsoft.CodeAnalysis.DiagnosticInfo?)useSiteDiagnosticInfo, isImplicitlyDeclared: isImplicitlyDeclared, correspondingDefaultFieldOpt: correspondingDefaultFieldOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 41959, 42569);
                    return return_v;
                }


                int
                f_10697_41947_42570(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TupleErrorFieldSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 41947, 42570);
                    return 0;
                }


                int
                f_10697_42644_42674(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 42644, 42674);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 29079, 45556);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 29079, 45556);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSymbol MergeTupleNames(NamedTypeSymbol other, NamedTypeSymbol mergedType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10697, 45568, 46792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 45728, 45779);

                ImmutableArray<string?>
                names1 = f_10697_45761_45778()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 45793, 45850);

                ImmutableArray<string?>
                names2 = f_10697_45826_45849(other)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 45864, 45900);

                ImmutableArray<string?>
                mergedNames
                = default(ImmutableArray<string?>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 45914, 46393) || true) && (names1.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(10697, 45918, 45954) || names2.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 45914, 46393);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 45988, 46010);

                    mergedNames = default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 45914, 46393);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 45914, 46393);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 46076, 46121);

                    f_10697_46076_46120(names1.Length == names2.Length);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 46139, 46240);

                    mergedNames = names1.ZipAsArray(names2, (n1, n2) => string.CompareOrdinal(n1, n2) == 0 ? n1 : null)!;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 46260, 46378) || true) && (mergedNames.All(n => n is null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 46260, 46378);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 46337, 46359);

                        mergedNames = default;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 46260, 46378);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 45914, 46393);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 46409, 46530);

                bool
                namesUnchanged = (DynAbs.Tracing.TraceSender.Conditional_F1(10697, 46431, 46452) || ((mergedNames.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10697, 46455, 46482)) || DynAbs.Tracing.TraceSender.Conditional_F3(10697, 46485, 46529))) ? f_10697_46455_46472().IsDefault : mergedNames.SequenceEqual(f_10697_46511_46528())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 46544, 46781);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10697, 46551, 46630) || (((namesUnchanged && (DynAbs.Tracing.TraceSender.Expression_True(10697, 46552, 46629) && f_10697_46570_46629(this, mergedType, TypeCompareKind.ConsiderEverything)))
                && DynAbs.Tracing.TraceSender.Conditional_F2(10697, 46650, 46654)) || DynAbs.Tracing.TraceSender.Conditional_F3(10697, 46674, 46780))) ? this
                : f_10697_46674_46780(mergedType, mergedNames, f_10697_46711_46735(this), f_10697_46737_46763(this), f_10697_46765_46779(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10697, 45568, 46792);

                System.Collections.Immutable.ImmutableArray<string?>
                f_10697_45761_45778()
                {
                    var return_v = TupleElementNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 45761, 45778);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string?>
                f_10697_45826_45849(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElementNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 45826, 45849);
                    return return_v;
                }


                int
                f_10697_46076_46120(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 46076, 46120);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string?>
                f_10697_46455_46472()
                {
                    var return_v = TupleElementNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 46455, 46472);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string?>
                f_10697_46511_46528()
                {
                    var return_v = TupleElementNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 46511, 46528);
                    return return_v;
                }


                bool
                f_10697_46570_46629(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 46570, 46629);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<bool>
                f_10697_46711_46735(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleErrorPositions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 46711, 46735);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
                f_10697_46737_46763(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElementLocations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 46737, 46763);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10697_46765_46779(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 46765, 46779);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10697_46674_46780(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                tupleCompatibleType, System.Collections.Immutable.ImmutableArray<string?>
                elementNames, System.Collections.Immutable.ImmutableArray<bool>
                errorPositions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
                elementLocations, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations)
                {
                    var return_v = CreateTuple(tupleCompatibleType, elementNames, errorPositions, elementLocations, locations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 46674, 46780);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 45568, 46792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 45568, 46792);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        internal sealed class TupleExtraData
        {
            internal ImmutableArray<string?> ElementNames { get; }

            internal ImmutableArray<Location?> ElementLocations { get; }

            internal ImmutableArray<bool> ErrorPositions { get; }

            internal ImmutableArray<Location> Locations { get; }

            private ImmutableArray<TypeWithAnnotations> _lazyElementTypes;

            private ImmutableArray<FieldSymbol> _lazyDefaultElementFields;

            private SmallDictionary<Symbol, Symbol>? _lazyUnderlyingDefinitionToMemberMap;

            internal NamedTypeSymbol TupleUnderlyingType { get; }

            internal TupleExtraData(NamedTypeSymbol underlyingType)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10697, 48484, 48884);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 48242, 48278);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 48415, 48468);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 48572, 48617);

                    f_10697_48572_48616(underlyingType is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 48635, 48676);

                    f_10697_48635_48675(f_10697_48648_48674(underlyingType));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 48694, 48751);

                    f_10697_48694_48750(underlyingType.TupleElementNames.IsDefault);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 48771, 48808);

                    TupleUnderlyingType = underlyingType;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 48826, 48869);

                    Locations = ImmutableArray<Location>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10697, 48484, 48884);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 48484, 48884);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 48484, 48884);
                }
            }

            internal TupleExtraData(NamedTypeSymbol underlyingType, ImmutableArray<string?> elementNames,
                            ImmutableArray<Location?> elementLocations, ImmutableArray<bool> errorPositions, ImmutableArray<Location> locations)
            : this(f_10697_49152_49166_C(underlyingType))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10697, 48900, 49401);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 49200, 49228);

                    ElementNames = elementNames;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 49246, 49282);

                    ElementLocations = elementLocations;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 49300, 49332);

                    ErrorPositions = errorPositions;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 49350, 49386);

                    Locations = locations.NullToEmpty();
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10697, 48900, 49401);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 48900, 49401);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 48900, 49401);
                }
            }

            internal bool EqualsIgnoringTupleUnderlyingType(TupleExtraData? other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10697, 49417, 50469);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 49520, 49709) || true) && (other is null && (DynAbs.Tracing.TraceSender.Expression_True(10697, 49524, 49568) && this.ElementNames.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(10697, 49524, 49603) && this.ElementLocations.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(10697, 49524, 49636) && this.ErrorPositions.IsDefault))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 49520, 49709);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 49678, 49690);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 49520, 49709);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 49729, 49980);

                    return other is object
                    && (DynAbs.Tracing.TraceSender.Expression_True(10697, 49736, 49823) && f_10697_49776_49823(f_10697_49785_49802(this), f_10697_49804_49822(other))) && (DynAbs.Tracing.TraceSender.Expression_True(10697, 49736, 49903) && f_10697_49848_49903(f_10697_49857_49878(this), f_10697_49880_49902(other))) && (DynAbs.Tracing.TraceSender.Expression_True(10697, 49736, 49979) && f_10697_49928_49979(f_10697_49937_49956(this), f_10697_49958_49978(other)));

                    static bool areEqual<T>(ImmutableArray<T> one, ImmutableArray<T> other)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10697, 50000, 50454);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 50112, 50233) || true) && (one.IsDefault && (DynAbs.Tracing.TraceSender.Expression_True(10697, 50116, 50148) && other.IsDefault))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 50112, 50233);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 50198, 50210);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 50112, 50233);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 50257, 50379) || true) && (one.IsDefault != other.IsDefault)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 50257, 50379);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 50343, 50356);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 50257, 50379);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 50403, 50435);

                            return one.SequenceEqual(other);
                            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10697, 50000, 50454);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 50000, 50454);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 50000, 50454);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10697, 49417, 50469);

                    System.Collections.Immutable.ImmutableArray<string?>
                    f_10697_49785_49802(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
                    this_param)
                    {
                        var return_v = this_param.ElementNames;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 49785, 49802);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<string?>
                    f_10697_49804_49822(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
                    this_param)
                    {
                        var return_v = this_param.ElementNames;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 49804, 49822);
                        return return_v;
                    }


                    bool
                    f_10697_49776_49823(System.Collections.Immutable.ImmutableArray<string?>
                    one, System.Collections.Immutable.ImmutableArray<string?>
                    other)
                    {
                        var return_v = areEqual(one, other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 49776, 49823);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
                    f_10697_49857_49878(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
                    this_param)
                    {
                        var return_v = this_param.ElementLocations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 49857, 49878);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
                    f_10697_49880_49902(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
                    this_param)
                    {
                        var return_v = this_param.ElementLocations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 49880, 49902);
                        return return_v;
                    }


                    bool
                    f_10697_49848_49903(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
                    one, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
                    other)
                    {
                        var return_v = areEqual(one, other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 49848, 49903);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<bool>
                    f_10697_49937_49956(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
                    this_param)
                    {
                        var return_v = this_param.ErrorPositions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 49937, 49956);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<bool>
                    f_10697_49958_49978(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
                    this_param)
                    {
                        var return_v = this_param.ErrorPositions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 49958, 49978);
                        return return_v;
                    }


                    bool
                    f_10697_49928_49979(System.Collections.Immutable.ImmutableArray<bool>
                    one, System.Collections.Immutable.ImmutableArray<bool>
                    other)
                    {
                        var return_v = areEqual(one, other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 49928, 49979);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 49417, 50469);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 49417, 50469);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public ImmutableArray<TypeWithAnnotations> TupleElementTypesWithAnnotations(NamedTypeSymbol tuple)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10697, 50485, 52224);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 50616, 50698);

                    f_10697_50616_50697(f_10697_50629_50696(tuple, f_10697_50642_50661(), TypeCompareKind.IgnoreTupleNames));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 50716, 50922) || true) && (_lazyElementTypes.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 50716, 50922);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 50789, 50903);

                        f_10697_50789_50902(ref _lazyElementTypes, f_10697_50855_50901(tuple));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 50716, 50922);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 50942, 50967);

                    return _lazyElementTypes;

                    static ImmutableArray<TypeWithAnnotations> collectTupleElementTypesWithAnnotations(NamedTypeSymbol tuple)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10697, 50987, 52209);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 51133, 51182);

                            ImmutableArray<TypeWithAnnotations>
                            elementTypes
                            = default(ImmutableArray<TypeWithAnnotations>);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 51206, 52146) || true) && (f_10697_51210_51221(tuple) == ValueTupleRestPosition)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 51206, 52146);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 51363, 51517);

                                var
                                extensionTupleElementTypes = f_10697_51396_51516(f_10697_51396_51450(tuple)[ValueTupleRestPosition - 1].Type)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 51543, 51672);

                                var
                                typesBuilder = f_10697_51562_51671(ValueTupleRestPosition - 1 + extensionTupleElementTypes.Length)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 51698, 51804);

                                f_10697_51698_51803(typesBuilder, f_10697_51720_51774(tuple), ValueTupleRestPosition - 1);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 51830, 51880);

                                f_10697_51830_51879(typesBuilder, extensionTupleElementTypes);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 51906, 51955);

                                elementTypes = f_10697_51921_51954(typesBuilder);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 51206, 52146);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 51206, 52146);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 52053, 52123);

                                elementTypes = f_10697_52068_52122(tuple);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 51206, 52146);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 52170, 52190);

                            return elementTypes;
                            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10697, 50987, 52209);

                            int
                            f_10697_51210_51221(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                            this_param)
                            {
                                var return_v = this_param.Arity;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 51210, 51221);
                                return return_v;
                            }


                            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                            f_10697_51396_51450(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                            this_param)
                            {
                                var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 51396, 51450);
                                return return_v;
                            }


                            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                            f_10697_51396_51516(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                            this_param)
                            {
                                var return_v = this_param.TupleElementTypesWithAnnotations;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 51396, 51516);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                            f_10697_51562_51671(int
                            capacity)
                            {
                                var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 51562, 51671);
                                return return_v;
                            }


                            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                            f_10697_51720_51774(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                            this_param)
                            {
                                var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 51720, 51774);
                                return return_v;
                            }


                            int
                            f_10697_51698_51803(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                            this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                            items, int
                            length)
                            {
                                this_param.AddRange(items, length);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 51698, 51803);
                                return 0;
                            }


                            int
                            f_10697_51830_51879(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                            this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                            items)
                            {
                                this_param.AddRange(items);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 51830, 51879);
                                return 0;
                            }


                            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                            f_10697_51921_51954(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                            this_param)
                            {
                                var return_v = this_param.ToImmutableAndFree();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 51921, 51954);
                                return return_v;
                            }


                            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                            f_10697_52068_52122(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                            this_param)
                            {
                                var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 52068, 52122);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 50987, 52209);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 50987, 52209);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10697, 50485, 52224);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10697_50642_50661()
                    {
                        var return_v = TupleUnderlyingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 50642, 50661);
                        return return_v;
                    }


                    bool
                    f_10697_50629_50696(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    t2, Microsoft.CodeAnalysis.TypeCompareKind
                    comparison)
                    {
                        var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 50629, 50696);
                        return return_v;
                    }


                    int
                    f_10697_50616_50697(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 50616, 50697);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10697_50855_50901(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    tuple)
                    {
                        var return_v = collectTupleElementTypesWithAnnotations(tuple);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 50855, 50901);
                        return return_v;
                    }


                    bool
                    f_10697_50789_50902(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 50789, 50902);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 50485, 52224);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 50485, 52224);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public ImmutableArray<FieldSymbol> TupleElements(NamedTypeSymbol tuple)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10697, 52240, 54158);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 52344, 52426);

                    f_10697_52344_52425(f_10697_52357_52424(tuple, f_10697_52370_52389(), TypeCompareKind.IgnoreTupleNames));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 52444, 52652) || true) && (_lazyDefaultElementFields.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 52444, 52652);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 52525, 52633);

                        f_10697_52525_52632(ref _lazyDefaultElementFields, f_10697_52599_52631(tuple));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 52444, 52652);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 52672, 52705);

                    return _lazyDefaultElementFields;

                    ImmutableArray<FieldSymbol> collectTupleElementFields(NamedTypeSymbol tuple)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10697, 52725, 54143);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 52842, 52964);

                            var
                            builder = f_10697_52856_52963(f_10697_52894_52933(this, tuple).Length, fillWithValue: null!)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 52988, 53996);
                                foreach (var member in f_10697_53011_53029_I(f_10697_53011_53029(tuple)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 52988, 53996);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 53079, 53208) || true) && (f_10697_53083_53094(member) != SymbolKind.Field)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 53079, 53208);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 53172, 53181);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 53079, 53208);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 53236, 53272);

                                    var
                                    candidate = (FieldSymbol)member
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 53298, 53338);

                                    var
                                    index = f_10697_53310_53337(candidate)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 53366, 53973) || true) && (index >= 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 53366, 53973);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 53438, 53946) || true) && (f_10697_53442_53479_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10697_53442_53456(builder, index), 10697, 53442, 53479)?.IsDefaultTupleElement) != false)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 53438, 53946);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 53554, 53581);

                                            builder[index] = candidate;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 53438, 53946);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 53438, 53946);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 53869, 53915);

                                            f_10697_53869_53914(f_10697_53882_53913(candidate));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 53438, 53946);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 53366, 53973);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 52988, 53996);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10697, 1, 1009);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10697, 1, 1009);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 54020, 54064);

                            f_10697_54020_54063(f_10697_54033_54062(builder, f => f is object));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 54088, 54124);

                            return f_10697_54095_54123(builder);
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10697, 52725, 54143);

                            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                            f_10697_52894_52933(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
                            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                            tuple)
                            {
                                var return_v = this_param.TupleElementTypesWithAnnotations(tuple);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 52894, 52933);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                            f_10697_52856_52963(int
                            capacity, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                            fillWithValue)
                            {
                                var return_v = ArrayBuilder<FieldSymbol>.GetInstance(capacity, fillWithValue);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 52856, 52963);
                                return return_v;
                            }


                            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                            f_10697_53011_53029(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                            this_param)
                            {
                                var return_v = this_param.GetMembers();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 53011, 53029);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.SymbolKind
                            f_10697_53083_53094(Microsoft.CodeAnalysis.CSharp.Symbol
                            this_param)
                            {
                                var return_v = this_param.Kind;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 53083, 53094);
                                return return_v;
                            }


                            int
                            f_10697_53310_53337(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                            this_param)
                            {
                                var return_v = this_param.TupleElementIndex;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 53310, 53337);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                            f_10697_53442_53456(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                            this_param, int
                            i0)
                            {
                                var return_v = this_param[i0];
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 53442, 53456);
                                return return_v;
                            }


                            bool?
                            f_10697_53442_53479_M(bool?
                            i)
                            {
                                var return_v = i;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 53442, 53479);
                                return return_v;
                            }


                            bool
                            f_10697_53882_53913(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                            this_param)
                            {
                                var return_v = this_param.IsDefaultTupleElement;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 53882, 53913);
                                return return_v;
                            }


                            int
                            f_10697_53869_53914(bool
                            condition)
                            {
                                Debug.Assert(condition);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 53869, 53914);
                                return 0;
                            }


                            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                            f_10697_53011_53029_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                            i)
                            {
                                var return_v = i;
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 53011, 53029);
                                return return_v;
                            }


                            bool
                            f_10697_54033_54062(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                            builder, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, bool>
                            predicate)
                            {
                                var return_v = builder.All<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>(predicate);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 54033, 54062);
                                return return_v;
                            }


                            int
                            f_10697_54020_54063(bool
                            condition)
                            {
                                Debug.Assert(condition);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 54020, 54063);
                                return 0;
                            }


                            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                            f_10697_54095_54123(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                            this_param)
                            {
                                var return_v = this_param.ToImmutableAndFree();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 54095, 54123);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 52725, 54143);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 52725, 54143);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10697, 52240, 54158);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10697_52370_52389()
                    {
                        var return_v = TupleUnderlyingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 52370, 52389);
                        return return_v;
                    }


                    bool
                    f_10697_52357_52424(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    t2, Microsoft.CodeAnalysis.TypeCompareKind
                    comparison)
                    {
                        var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 52357, 52424);
                        return return_v;
                    }


                    int
                    f_10697_52344_52425(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 52344, 52425);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                    f_10697_52599_52631(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    tuple)
                    {
                        var return_v = collectTupleElementFields(tuple);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 52599, 52631);
                        return return_v;
                    }


                    bool
                    f_10697_52525_52632(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 52525, 52632);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 52240, 54158);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 52240, 54158);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal SmallDictionary<Symbol, Symbol> UnderlyingDefinitionToMemberMap
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10697, 54279, 54486);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 54323, 54467);

                        return _lazyUnderlyingDefinitionToMemberMap ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>?>(10697, 54330, 54466) ?? (_lazyUnderlyingDefinitionToMemberMap = f_10697_54435_54465(this)));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10697, 54279, 54486);

                        Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                        f_10697_54435_54465(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
                        this_param)
                        {
                            var return_v = this_param.ComputeDefinitionToMemberMap();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 54435, 54465);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 54174, 54501);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 54174, 54501);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private SmallDictionary<Symbol, Symbol> ComputeDefinitionToMemberMap()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10697, 54517, 56971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 54620, 54702);

                    var
                    map = f_10697_54630_54701(ReferenceEqualityComparer.Instance)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 54720, 54767);

                    var
                    members = f_10697_54734_54766(f_10697_54734_54753())
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 54955, 54977);

                        // Go in reverse because we want members with default name, which precede the ones with
                        // friendly names, to be in the map.
                        for (int
        i = members.Length - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 54946, 56925) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 54987, 54990)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 54946, 56925))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 54946, 56925);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 55032, 55056);

                            var
                            member = members[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 55078, 56906);

                            switch (f_10697_55086_55097(member))
                            {

                                case SymbolKind.Method:
                                case SymbolKind.Property:
                                case SymbolKind.NamedType:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 55078, 56906);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 55303, 55346);

                                    f_10697_55303_55345(map, f_10697_55311_55336(member), member);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10697, 55376, 55382);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 55078, 56906);

                                case SymbolKind.Field:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 55078, 56906);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 55462, 55532);

                                    var
                                    tupleUnderlyingField = f_10697_55489_55531(((FieldSymbol)member))
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 55562, 55747) || true) && (tupleUnderlyingField is object)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 55562, 55747);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 55662, 55716);

                                        map[f_10697_55666_55705(tupleUnderlyingField)] = member;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 55562, 55747);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10697, 55777, 55783);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 55078, 56906);

                                case SymbolKind.Event:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 55078, 56906);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 55863, 55905);

                                    var
                                    underlyingEvent = (EventSymbol)member
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 55935, 55999);

                                    var
                                    underlyingAssociatedField = f_10697_55967_55998(underlyingEvent)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 56103, 56643) || true) && (underlyingAssociatedField is object)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 56103, 56643);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 56208, 56296);

                                        f_10697_56208_56295((object)f_10697_56229_56271(underlyingAssociatedField) == f_10697_56275_56294());
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 56330, 56446);

                                        f_10697_56330_56445(f_10697_56343_56405(f_10697_56343_56362(), f_10697_56374_56404(underlyingAssociatedField)).IndexOf(underlyingAssociatedField) < 0);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 56480, 56612);

                                        f_10697_56480_56611(map, f_10697_56488_56532(underlyingAssociatedField), f_10697_56534_56610(f_10697_56555_56574(), underlyingAssociatedField, -i - 1));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 56103, 56643);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 56675, 56727);

                                    f_10697_56675_56726(
                                                                map, f_10697_56683_56717(underlyingEvent), member);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10697, 56757, 56763);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 55078, 56906);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 55078, 56906);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 56829, 56883);

                                    throw f_10697_56835_56882(f_10697_56870_56881(member));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 55078, 56906);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10697, 1, 1980);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10697, 1, 1980);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 56945, 56956);

                    return map;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10697, 54517, 56971);

                    Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10697_54630_54701(Roslyn.Utilities.ReferenceEqualityComparer
                    comparer)
                    {
                        var return_v = new Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>)comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 54630, 54701);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10697_54734_54753()
                    {
                        var return_v = TupleUnderlyingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 54734, 54753);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10697_54734_54766(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetMembers();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 54734, 54766);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10697_55086_55097(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 55086, 55097);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10697_55311_55336(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 55311, 55336);
                        return return_v;
                    }


                    int
                    f_10697_55303_55345(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    key, Microsoft.CodeAnalysis.CSharp.Symbol
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 55303, 55345);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10697_55489_55531(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.TupleUnderlyingField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 55489, 55531);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10697_55666_55705(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 55666, 55705);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                    f_10697_55967_55998(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.AssociatedField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 55967, 55998);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10697_56229_56271(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 56229, 56271);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10697_56275_56294()
                    {
                        var return_v = TupleUnderlyingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 56275, 56294);
                        return return_v;
                    }


                    int
                    f_10697_56208_56295(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 56208, 56295);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10697_56343_56362()
                    {
                        var return_v = TupleUnderlyingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 56343, 56362);
                        return return_v;
                    }


                    string
                    f_10697_56374_56404(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 56374, 56404);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10697_56343_56405(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetMembers(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 56343, 56405);
                        return return_v;
                    }


                    int
                    f_10697_56330_56445(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 56330, 56445);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10697_56488_56532(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 56488, 56532);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10697_56555_56574()
                    {
                        var return_v = TupleUnderlyingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 56555, 56574);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TupleFieldSymbol
                    f_10697_56534_56610(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    container, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    underlyingField, int
                    tupleElementIndex)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TupleFieldSymbol(container, underlyingField, tupleElementIndex);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 56534, 56610);
                        return return_v;
                    }


                    int
                    f_10697_56480_56611(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    key, Microsoft.CodeAnalysis.CSharp.Symbols.TupleFieldSymbol
                    value)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)key, (Microsoft.CodeAnalysis.CSharp.Symbol)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 56480, 56611);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10697_56683_56717(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 56683, 56717);
                        return return_v;
                    }


                    int
                    f_10697_56675_56726(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    key, Microsoft.CodeAnalysis.CSharp.Symbol
                    value)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 56675, 56726);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10697_56870_56881(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 56870, 56881);
                        return return_v;
                    }


                    System.Exception
                    f_10697_56835_56882(Microsoft.CodeAnalysis.SymbolKind
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 56835, 56882);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 54517, 56971);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 54517, 56971);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public TMember? GetTupleMemberSymbolForUnderlyingMember<TMember>(TMember underlyingMemberOpt) where TMember : Symbol
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10697, 56987, 57998);
                    Microsoft.CodeAnalysis.CSharp.Symbol result = default(Microsoft.CodeAnalysis.CSharp.Symbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 57136, 57248) || true) && ((object)underlyingMemberOpt == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 57136, 57248);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 57217, 57229);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 57136, 57248);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 57268, 57343);

                    Symbol
                    underlyingMemberDefinition = f_10697_57304_57342<TMember>(underlyingMemberOpt)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 57361, 57539) || true) && (underlyingMemberDefinition is TupleFieldSymbol tupleField)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 57361, 57539);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 57464, 57520);

                        underlyingMemberDefinition = f_10697_57493_57519<TMember>(tupleField);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 57361, 57539);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 57559, 57951) || true) && (f_10697_57563_57699<TMember>(f_10697_57581_57622<TMember>(underlyingMemberDefinition), f_10697_57624_57662<TMember>(f_10697_57624_57643<TMember>()), TypeCompareKind.ConsiderEverything))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 57559, 57951);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 57741, 57932) || true) && (f_10697_57745_57836<TMember>(f_10697_57745_57776<TMember>(), underlyingMemberDefinition, out result))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10697, 57741, 57932);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 57886, 57909);

                            return (TMember)result;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 57741, 57932);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10697, 57559, 57951);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 57971, 57983);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10697, 56987, 57998);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10697_57304_57342<TMember>(TMember
                    this_param) where TMember : Symbol

                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 57304, 57342);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10697_57493_57519<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.TupleFieldSymbol
                    this_param) where TMember : Symbol

                    {
                        var return_v = this_param.UnderlyingField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 57493, 57519);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10697_57581_57622<TMember>(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param) where TMember : Symbol

                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 57581, 57622);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10697_57624_57643<TMember>() where TMember : Symbol

                    {
                        var return_v = TupleUnderlyingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 57624, 57643);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10697_57624_57662<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param) where TMember : Symbol

                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 57624, 57662);
                        return return_v;
                    }


                    bool
                    f_10697_57563_57699<TMember>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    right, Microsoft.CodeAnalysis.TypeCompareKind
                    comparison) where TMember : Symbol

                    {
                        var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 57563, 57699);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10697_57745_57776<TMember>() where TMember : Symbol

                    {
                        var return_v = UnderlyingDefinitionToMemberMap;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 57745, 57776);
                        return return_v;
                    }


                    bool
                    f_10697_57745_57836<TMember>(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    key, out Microsoft.CodeAnalysis.CSharp.Symbol?
                    value) where TMember : Symbol

                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 57745, 57836);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10697, 56987, 57998);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 56987, 57998);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static TupleExtraData()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10697, 46971, 58009);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10697, 46971, 58009);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10697, 46971, 58009);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10697, 46971, 58009);

            int
            f_10697_48572_48616(bool
            b)
            {
                RoslynDebug.Assert(b);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 48572, 48616);
                return 0;
            }


            bool
            f_10697_48648_48674(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            this_param)
            {
                var return_v = this_param.IsTupleType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 48648, 48674);
                return return_v;
            }


            int
            f_10697_48635_48675(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 48635, 48675);
                return 0;
            }


            int
            f_10697_48694_48750(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 48694, 48750);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10697_49152_49166_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10697, 48900, 49401);
                return return_v;
            }

        }

        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10697_6074_6109(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
        this_param)
        {
            var return_v = this_param.TupleUnderlyingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 6074, 6109);
            return return_v;
        }


        bool
        f_10697_6113_6129(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsTupleType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 6113, 6129);
            return return_v;
        }


        bool
        f_10697_27511_27560(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param, out int
        tupleCardinality)
        {
            var return_v = this_param.IsTupleTypeOfCardinality(out tupleCardinality);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 27511, 27560);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<string?>
        f_10697_28140_28167(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
        this_param)
        {
            var return_v = this_param.ElementNames;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 28140, 28167);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<bool>
        f_10697_28280_28309(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
        this_param)
        {
            var return_v = this_param.ErrorPositions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 28280, 28309);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
        f_10697_28429_28460(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
        this_param)
        {
            var return_v = this_param.ElementLocations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 28429, 28460);
            return return_v;
        }


        bool
        f_10697_28581_28592()
        {
            var return_v = IsTupleType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 28581, 28592);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        f_10697_28595_28644(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        tuple)
        {
            var return_v = this_param.TupleElementTypesWithAnnotations(tuple);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 28595, 28644);
            return return_v;
        }


        bool
        f_10697_28748_28759()
        {
            var return_v = IsTupleType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10697, 28748, 28759);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
        f_10697_28762_28792(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        tuple)
        {
            var return_v = this_param.TupleElements(tuple);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10697, 28762, 28792);
            return return_v;
        }

    }
}
