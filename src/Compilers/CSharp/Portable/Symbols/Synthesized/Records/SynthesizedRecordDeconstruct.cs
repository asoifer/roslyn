// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Microsoft.Cci;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedRecordDeconstruct : SynthesizedRecordOrdinaryMethod
    {
        private readonly SynthesizedRecordConstructor _ctor;

        private readonly ImmutableArray<PropertySymbol> _properties;

        public SynthesizedRecordDeconstruct(
                    SourceMemberContainerTypeSymbol containingType,
                    SynthesizedRecordConstructor ctor,
                    ImmutableArray<PropertySymbol> properties,
                    int memberOffset,
                    DiagnosticBag diagnostics)
        : base(f_10721_1031_1045_C(containingType), WellKnownMemberNames.DeconstructMethodName, hasBody: true, memberOffset, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10721, 738, 1297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 650, 655);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 1157, 1220);

                f_10721_1157_1219(properties.All(prop => prop.GetMethod is object));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 1234, 1247);

                _ctor = ctor;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 1261, 1286);

                _properties = properties;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10721, 738, 1297);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10721, 738, 1297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10721, 738, 1297);
            }
        }

        protected override DeclarationModifiers MakeDeclarationModifiers(DeclarationModifiers allowedModifiers, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10721, 1309, 1629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 1464, 1528);

                const DeclarationModifiers
                result = DeclarationModifiers.Public
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 1542, 1590);

                f_10721_1542_1589((result & ~allowedModifiers) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 1604, 1618);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10721, 1309, 1629);

                int
                f_10721_1542_1589(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10721, 1542, 1589);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10721, 1309, 1629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10721, 1309, 1629);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override (TypeWithAnnotations ReturnType, ImmutableArray<ParameterSymbol> Parameters, bool IsVararg, ImmutableArray<TypeParameterConstraintClause> DeclaredConstraintsForOverrideOrImplementation) MakeParametersAndBindReturnType(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10721, 1641, 3060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 1929, 1968);

                var
                compilation = f_10721_1947_1967()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 1982, 2016);

                var
                location = f_10721_1997_2015()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 2030, 3049);

                return (ReturnType: TypeWithAnnotations.Create(f_10721_2077_2159(compilation, SpecialType.System_Void, location, diagnostics)),
                                    Parameters: _ctor.Parameters.SelectAsArray<ParameterSymbol, ImmutableArray<Location>, ParameterSymbol>((param, locations) =>
                    new SourceSimpleParameterSymbol(owner: this,
                        param.TypeWithAnnotations,
                        param.Ordinal,
                        RefKind.Out,
                        param.Name,
                        isDiscard: false,
                        locations), arg: f_10721_2877_2886()),
                                    IsVararg: false,
                                    DeclaredConstraintsForOverrideOrImplementation: ImmutableArray<TypeParameterConstraintClause>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10721, 1641, 3060);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10721_1947_1967()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10721, 1947, 1967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10721_1997_2015()
                {
                    var return_v = ReturnTypeLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10721, 1997, 2015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10721_2077_2159(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = Binder.GetSpecialType(compilation, typeId, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10721, 2077, 2159);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10721_2877_2886()
                {
                    var return_v = Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10721, 2877, 2886);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10721, 1641, 3060);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10721, 1641, 3060);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override int GetParameterCountFromSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10721, 3125, 3148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 3128, 3148);
                return f_10721_3128_3148(_ctor); DynAbs.Tracing.TraceSender.TraceExitMethod(10721, 3125, 3148);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10721, 3125, 3148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10721, 3125, 3148);
            }
            throw new System.Exception("Slicer error: unreachable code");

            int
            f_10721_3128_3148(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
            this_param)
            {
                var return_v = this_param.ParameterCount;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10721, 3128, 3148);
                return return_v;
            }

        }

        internal override void GenerateMethodBody(TypeCompilationState compilationState, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10721, 3161, 4562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 3293, 3407);

                var
                F = f_10721_3301_3406(this, f_10721_3337_3374(f_10721_3337_3351()), compilationState, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 3423, 3639) || true) && (f_10721_3427_3441() != _properties.Length)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10721, 3423, 3639);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 3570, 3599);

                    f_10721_3570_3598(                // There is a mismatch, an error was reported elsewhere
                                    F, f_10721_3584_3597(F));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 3617, 3624);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10721, 3423, 3639);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 3655, 3744);

                var
                statementsBuilder = f_10721_3679_3743(_properties.Length + 1)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 3767, 3772);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 3758, 4424) || true) && (i < _properties.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 3798, 3801)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10721, 3758, 4424))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10721, 3758, 4424);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 3835, 3865);

                        var
                        parameter = f_10721_3851_3861()[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 3883, 3913);

                        var
                        property = _properties[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 3933, 4251) || true) && (!f_10721_3938_4008(f_10721_3938_3952(parameter), f_10721_3960_3973(property), TypeCompareKind.AllIgnoreOptions))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10721, 3933, 4251);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 4127, 4152);

                            f_10721_4127_4151(                    // There is a mismatch, an error was reported elsewhere
                                                statementsBuilder);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 4174, 4203);

                            f_10721_4174_4202(F, f_10721_4188_4201(F));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 4225, 4232);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10721, 3933, 4251);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 4317, 4409);

                        f_10721_4317_4408(
                                        // parameter_i = property_i;
                                        statementsBuilder, f_10721_4339_4407(F, f_10721_4352_4374(F, parameter), f_10721_4376_4406(F, f_10721_4387_4395(F), property)));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10721, 1, 667);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10721, 1, 667);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 4440, 4474);

                f_10721_4440_4473(
                            statementsBuilder, f_10721_4462_4472(F));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10721, 4488, 4551);

                f_10721_4488_4550(F, f_10721_4502_4549(F, f_10721_4510_4548(statementsBuilder)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10721, 3161, 4562);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10721_3337_3351()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10721, 3337, 3351);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10721_3337_3374(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.GetNonNullSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10721, 3337, 3374);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                f_10721_3301_3406(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordDeconstruct
                topLevelMethod, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)topLevelMethod, (Microsoft.CodeAnalysis.SyntaxNode)node, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10721, 3301, 3406);
                    return return_v;
                }


                int
                f_10721_3427_3441()
                {
                    var return_v = ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10721, 3427, 3441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10721_3584_3597(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ThrowNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10721, 3584, 3597);
                    return return_v;
                }


                int
                f_10721_3570_3598(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10721, 3570, 3598);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10721_3679_3743(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10721, 3679, 3743);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10721_3851_3861()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10721, 3851, 3861);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10721_3938_3952(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10721, 3938, 3952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10721_3960_3973(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10721, 3960, 3973);
                    return return_v;
                }


                bool
                f_10721_3938_4008(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10721, 3938, 4008);
                    return return_v;
                }


                int
                f_10721_4127_4151(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10721, 4127, 4151);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10721_4188_4201(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ThrowNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10721, 4188, 4201);
                    return return_v;
                }


                int
                f_10721_4174_4202(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10721, 4174, 4202);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10721_4352_4374(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                p)
                {
                    var return_v = this_param.Parameter(p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10721, 4352, 4374);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10721_4387_4395(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10721, 4387, 4395);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10721_4376_4406(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = this_param.Property((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10721, 4376, 4406);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10721_4339_4407(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundParameter
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10721, 4339, 4407);
                    return return_v;
                }


                int
                f_10721_4317_4408(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10721, 4317, 4408);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10721_4462_4472(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Return();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10721, 4462, 4472);
                    return return_v;
                }


                int
                f_10721_4440_4473(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10721, 4440, 4473);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10721_4510_4548(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10721, 4510, 4548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10721_4502_4549(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10721, 4502, 4549);
                    return return_v;
                }


                int
                f_10721_4488_4550(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10721, 4488, 4550);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10721, 3161, 4562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10721, 3161, 4562);
            }
        }

        static SynthesizedRecordDeconstruct()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10721, 503, 4569);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10721, 503, 4569);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10721, 503, 4569);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10721, 503, 4569);

        int
        f_10721_1157_1219(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10721, 1157, 1219);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        f_10721_1031_1045_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10721, 738, 1297);
            return return_v;
        }

    }
}
