// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedRecordBaseEquals : SynthesizedRecordOrdinaryMethod
    {
        public SynthesizedRecordBaseEquals(SourceMemberContainerTypeSymbol containingType, int memberOffset, DiagnosticBag diagnostics)
        : base(f_10717_971_985_C(containingType), WellKnownMemberNames.ObjectEquals, hasBody: true, memberOffset, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10717, 823, 1085);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10717, 823, 1085);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10717, 823, 1085);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10717, 823, 1085);
            }
        }

        protected override DeclarationModifiers MakeDeclarationModifiers(DeclarationModifiers allowedModifiers, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10717, 1097, 1479);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10717, 1252, 1378);

                const DeclarationModifiers
                result = DeclarationModifiers.Public | DeclarationModifiers.Override | DeclarationModifiers.Sealed
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10717, 1392, 1440);

                f_10717_1392_1439((result & ~allowedModifiers) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10717, 1454, 1468);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10717, 1097, 1479);

                int
                f_10717_1392_1439(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10717, 1392, 1439);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10717, 1097, 1479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10717, 1097, 1479);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override (TypeWithAnnotations ReturnType, ImmutableArray<ParameterSymbol> Parameters, bool IsVararg, ImmutableArray<TypeParameterConstraintClause> DeclaredConstraintsForOverrideOrImplementation) MakeParametersAndBindReturnType(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10717, 1491, 2648);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10717, 1779, 1818);

                var
                compilation = f_10717_1797_1817()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10717, 1832, 1866);

                var
                location = f_10717_1847_1865()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10717, 1880, 2637);

                return (ReturnType: TypeWithAnnotations.Create(f_10717_1927_2012(compilation, SpecialType.System_Boolean, location, diagnostics)),
                                    Parameters: f_10717_2048_2475(f_10717_2125_2474(owner: this, TypeWithAnnotations.Create(f_10717_2266_2309(f_10717_2266_2280()), NullableAnnotation.Annotated), ordinal: 0, RefKind.None, "other", isDiscard: false, f_10717_2464_2473())),
                                    IsVararg: false,
                                    DeclaredConstraintsForOverrideOrImplementation: ImmutableArray<TypeParameterConstraintClause>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10717, 1491, 2648);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10717_1797_1817()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10717, 1797, 1817);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10717_1847_1865()
                {
                    var return_v = ReturnTypeLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10717, 1847, 1865);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10717_1927_2012(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = Binder.GetSpecialType(compilation, typeId, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10717, 1927, 2012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10717_2266_2280()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10717, 2266, 2280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10717_2266_2309(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10717, 2266, 2309);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10717_2464_2473()
                {
                    var return_v = Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10717, 2464, 2473);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceSimpleParameterSymbol
                f_10717_2125_2474(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordBaseEquals
                owner, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                parameterType, int
                ordinal, Microsoft.CodeAnalysis.RefKind
                refKind, string
                name, bool
                isDiscard, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceSimpleParameterSymbol(owner: (Microsoft.CodeAnalysis.CSharp.Symbol)owner, parameterType, ordinal: ordinal, refKind, name, isDiscard: isDiscard, locations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10717, 2125, 2474);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10717_2048_2475(Microsoft.CodeAnalysis.CSharp.Symbols.SourceSimpleParameterSymbol
                item)
                {
                    var return_v = ImmutableArray.Create<ParameterSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10717, 2048, 2475);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10717, 1491, 2648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10717, 1491, 2648);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override int GetParameterCountFromSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10717, 2713, 2717);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10717, 2716, 2717);
                return 1; DynAbs.Tracing.TraceSender.TraceExitMethod(10717, 2713, 2717);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10717, 2713, 2717);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10717, 2713, 2717);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void MethodChecks(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10717, 2730, 3254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10717, 2818, 2849);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.MethodChecks(diagnostics), 10717, 2818, 2848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10717, 2865, 2899);

                var
                overridden = f_10717_2882_2898()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10717, 2915, 3243) || true) && (overridden is object && (DynAbs.Tracing.TraceSender.Expression_True(10717, 2919, 3072) && !f_10717_2961_3072(f_10717_2961_2986(overridden), f_10717_2994_3037(f_10717_2994_3008()), TypeCompareKind.AllIgnoreOptions)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10717, 2915, 3243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10717, 3106, 3228);

                    f_10717_3106_3227(diagnostics, ErrorCode.ERR_DoesNotOverrideBaseMethod, f_10717_3163_3172()[0], this, f_10717_3183_3226(f_10717_3183_3197()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10717, 2915, 3243);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10717, 2730, 3254);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10717_2882_2898()
                {
                    var return_v = OverriddenMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10717, 2882, 2898);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10717_2961_2986(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10717, 2961, 2986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10717_2994_3008()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10717, 2994, 3008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10717_2994_3037(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10717, 2994, 3037);
                    return return_v;
                }


                bool
                f_10717_2961_3072(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10717, 2961, 3072);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10717_3163_3172()
                {
                    var return_v = Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10717, 3163, 3172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10717_3183_3197()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10717, 3183, 3197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10717_3183_3226(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10717, 3183, 3226);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10717_3106_3227(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10717, 3106, 3227);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10717, 2730, 3254);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10717, 2730, 3254);
            }
        }

        internal override void GenerateMethodBody(TypeCompilationState compilationState, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10717, 3266, 4319);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10717, 3398, 3490);

                var
                F = f_10717_3406_3489(this, f_10717_3442_3457(this), compilationState, diagnostics)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10717, 3542, 3584);

                    ParameterSymbol
                    parameter = f_10717_3570_3580()[0]
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10717, 3604, 3755) || true) && (f_10717_3608_3636(f_10717_3608_3622(parameter)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10717, 3604, 3755);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10717, 3678, 3707);

                        f_10717_3678_3706(F, f_10717_3692_3705(F));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10717, 3729, 3736);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10717, 3604, 3755);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10717, 3775, 4031);

                    var
                    retExpr = f_10717_3789_4030(F, f_10717_3818_3826(F), f_10717_3849_3931(f_10717_3849_3885(f_10717_3849_3863()).OfType<SynthesizedRecordObjEquals>()), f_10717_3954_4029(F, f_10717_3964_4004(F, SpecialType.System_Object), f_10717_4006_4028(F, parameter)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10717, 4051, 4093);

                    f_10717_4051_4092(
                                    F, f_10717_4065_4091(F, f_10717_4073_4090(F, retExpr)));
                }
                catch (SyntheticBoundNodeFactory.MissingPredefinedMember ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10717, 4122, 4308);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10717, 4215, 4246);

                    f_10717_4215_4245(diagnostics, f_10717_4231_4244(ex));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10717, 4264, 4293);

                    f_10717_4264_4292(F, f_10717_4278_4291(F));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10717, 4122, 4308);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10717, 3266, 4319);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10717_3442_3457(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordBaseEquals
                this_param)
                {
                    var return_v = this_param.SyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10717, 3442, 3457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                f_10717_3406_3489(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordBaseEquals
                topLevelMethod, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)topLevelMethod, (Microsoft.CodeAnalysis.SyntaxNode)node, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10717, 3406, 3489);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10717_3570_3580()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10717, 3570, 3580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10717_3608_3622(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10717, 3608, 3622);
                    return return_v;
                }


                bool
                f_10717_3608_3636(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10717, 3608, 3636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10717_3692_3705(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ThrowNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10717, 3692, 3705);
                    return return_v;
                }


                int
                f_10717_3678_3706(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10717, 3678, 3706);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10717_3818_3826(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10717, 3818, 3826);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10717_3849_3863()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10717, 3849, 3863);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10717_3849_3885(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10717, 3849, 3885);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordObjEquals
                f_10717_3849_3931(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordObjEquals>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordObjEquals>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10717, 3849, 3931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10717_3964_4004(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10717, 3964, 4004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10717_4006_4028(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                p)
                {
                    var return_v = this_param.Parameter(p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10717, 4006, 4028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10717_3954_4029(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundParameter
                arg)
                {
                    var return_v = this_param.Convert((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10717, 3954, 4029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10717_3789_4030(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordObjEquals
                method, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg0)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)method, arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10717, 3789, 4030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10717_4073_4090(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                expression)
                {
                    var return_v = this_param.Return((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10717, 4073, 4090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10717_4065_4091(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10717, 4065, 4091);
                    return return_v;
                }


                int
                f_10717_4051_4092(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10717, 4051, 4092);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10717_4231_4244(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.MissingPredefinedMember
                this_param)
                {
                    var return_v = this_param.Diagnostic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10717, 4231, 4244);
                    return return_v;
                }


                int
                f_10717_4215_4245(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10717, 4215, 4245);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10717_4278_4291(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ThrowNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10717, 4278, 4291);
                    return return_v;
                }


                int
                f_10717_4264_4292(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10717, 4264, 4292);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10717, 3266, 4319);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10717, 3266, 4319);
            }
        }

        static SynthesizedRecordBaseEquals()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10717, 723, 4326);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10717, 723, 4326);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10717, 723, 4326);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10717, 723, 4326);

        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        f_10717_971_985_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10717, 823, 1085);
            return return_v;
        }

    }
}
