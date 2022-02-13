// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedRecordObjEquals : SynthesizedRecordObjectMethod
    {
        private readonly MethodSymbol _typedRecordEquals;

        public SynthesizedRecordObjEquals(SourceMemberContainerTypeSymbol containingType, MethodSymbol typedRecordEquals, int memberOffset, DiagnosticBag diagnostics)
        : base(f_10729_945_959_C(containingType), WellKnownMemberNames.ObjectEquals, memberOffset, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10729, 766, 1097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10729, 735, 753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10729, 1047, 1086);

                _typedRecordEquals = typedRecordEquals;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10729, 766, 1097);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10729, 766, 1097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10729, 766, 1097);
            }
        }

        protected override (TypeWithAnnotations ReturnType, ImmutableArray<ParameterSymbol> Parameters, bool IsVararg, ImmutableArray<TypeParameterConstraintClause> DeclaredConstraintsForOverrideOrImplementation) MakeParametersAndBindReturnType(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10729, 1109, 2305);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10729, 1397, 1436);

                var
                compilation = f_10729_1415_1435()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10729, 1450, 1484);

                var
                location = f_10729_1465_1483()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10729, 1498, 2294);

                return (ReturnType: TypeWithAnnotations.Create(f_10729_1545_1630(compilation, SpecialType.System_Boolean, location, diagnostics)),
                                    Parameters: f_10729_1666_2132(f_10729_1743_2131(owner: this, TypeWithAnnotations.Create(f_10729_1884_1968(compilation, SpecialType.System_Object, location, diagnostics), NullableAnnotation.Annotated), ordinal: 0, RefKind.None, "obj", isDiscard: false, f_10729_2121_2130())),
                                    IsVararg: false,
                                    DeclaredConstraintsForOverrideOrImplementation: ImmutableArray<TypeParameterConstraintClause>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10729, 1109, 2305);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10729_1415_1435()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10729, 1415, 1435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10729_1465_1483()
                {
                    var return_v = ReturnTypeLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10729, 1465, 1483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10729_1545_1630(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = Binder.GetSpecialType(compilation, typeId, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10729, 1545, 1630);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10729_1884_1968(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = Binder.GetSpecialType(compilation, typeId, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10729, 1884, 1968);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10729_2121_2130()
                {
                    var return_v = Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10729, 2121, 2130);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceSimpleParameterSymbol
                f_10729_1743_2131(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordObjEquals
                owner, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                parameterType, int
                ordinal, Microsoft.CodeAnalysis.RefKind
                refKind, string
                name, bool
                isDiscard, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceSimpleParameterSymbol(owner: (Microsoft.CodeAnalysis.CSharp.Symbol)owner, parameterType, ordinal: ordinal, refKind, name, isDiscard: isDiscard, locations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10729, 1743, 2131);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10729_1666_2132(Microsoft.CodeAnalysis.CSharp.Symbols.SourceSimpleParameterSymbol
                item)
                {
                    var return_v = ImmutableArray.Create<ParameterSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10729, 1666, 2132);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10729, 1109, 2305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10729, 1109, 2305);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override int GetParameterCountFromSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10729, 2370, 2374);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10729, 2373, 2374);
                return 1; DynAbs.Tracing.TraceSender.TraceExitMethod(10729, 2370, 2374);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10729, 2370, 2374);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10729, 2370, 2374);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void GenerateMethodBody(TypeCompilationState compilationState, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10729, 2387, 3837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10729, 2519, 2611);

                var
                F = f_10729_2527_2610(this, f_10729_2563_2578(this), compilationState, diagnostics)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10729, 2663, 2708);

                    var
                    paramAccess = f_10729_2681_2707(F, f_10729_2693_2703()[0])
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10729, 2728, 2755);

                    BoundExpression
                    expression
                    = default(BoundExpression);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10729, 2773, 3507) || true) && (f_10729_2777_2806(f_10729_2777_2791()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10729, 2773, 3507);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10729, 2848, 2885);

                        throw f_10729_2854_2884();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10729, 2773, 3507);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10729, 2773, 3507);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10729, 2967, 3268) || true) && (f_10729_2971_3012(f_10729_2971_3000(_typedRecordEquals)) != SpecialType.System_Boolean)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10729, 2967, 3268);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10729, 3183, 3212);

                            f_10729_3183_3211(                        // There is a signature mismatch, an error was reported elsewhere
                                                    F, f_10729_3197_3210(F));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10729, 3238, 3245);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10729, 2967, 3268);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10729, 3403, 3488);

                        expression = f_10729_3416_3487(F, f_10729_3423_3431(F), _typedRecordEquals, f_10729_3453_3486(F, paramAccess, f_10729_3471_3485()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10729, 2773, 3507);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10729, 3527, 3611);

                    f_10729_3527_3610(
                                    F, f_10729_3541_3609(F, f_10729_3549_3608(f_10729_3587_3607(F, expression))));
                }
                catch (SyntheticBoundNodeFactory.MissingPredefinedMember ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10729, 3640, 3826);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10729, 3733, 3764);

                    f_10729_3733_3763(diagnostics, f_10729_3749_3762(ex));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10729, 3782, 3811);

                    f_10729_3782_3810(F, f_10729_3796_3809(F));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10729, 3640, 3826);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10729, 2387, 3837);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10729_2563_2578(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordObjEquals
                this_param)
                {
                    var return_v = this_param.SyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10729, 2563, 2578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                f_10729_2527_2610(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordObjEquals
                topLevelMethod, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)topLevelMethod, (Microsoft.CodeAnalysis.SyntaxNode)node, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10729, 2527, 2610);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10729_2693_2703()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10729, 2693, 2703);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10729_2681_2707(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                p)
                {
                    var return_v = this_param.Parameter(p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10729, 2681, 2707);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10729_2777_2791()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10729, 2777, 2791);
                    return return_v;
                }


                bool
                f_10729_2777_2806(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsStructType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10729, 2777, 2806);
                    return return_v;
                }


                System.Exception
                f_10729_2854_2884()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10729, 2854, 2884);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10729_2971_3000(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10729, 2971, 3000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10729_2971_3012(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10729, 2971, 3012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10729_3197_3210(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ThrowNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10729, 3197, 3210);
                    return return_v;
                }


                int
                f_10729_3183_3211(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10729, 3183, 3211);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10729_3423_3431(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10729, 3423, 3431);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10729_3471_3485()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10729, 3471, 3485);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                f_10729_3453_3486(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundParameter
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.As((Microsoft.CodeAnalysis.CSharp.BoundExpression)operand, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10729, 3453, 3486);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10729_3416_3487(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                arg0)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10729, 3416, 3487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10729_3587_3607(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.Return(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10729, 3587, 3607);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10729_3549_3608(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                item)
                {
                    var return_v = ImmutableArray.Create<BoundStatement>((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10729, 3549, 3608);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10729_3541_3609(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10729, 3541, 3609);
                    return return_v;
                }


                int
                f_10729_3527_3610(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10729, 3527, 3610);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10729_3749_3762(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.MissingPredefinedMember
                this_param)
                {
                    var return_v = this_param.Diagnostic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10729, 3749, 3762);
                    return return_v;
                }


                int
                f_10729_3733_3763(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10729, 3733, 3763);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10729_3796_3809(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ThrowNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10729, 3796, 3809);
                    return return_v;
                }


                int
                f_10729_3782_3810(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10729, 3782, 3810);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10729, 2387, 3837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10729, 2387, 3837);
            }
        }

        static SynthesizedRecordObjEquals()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10729, 608, 3844);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10729, 608, 3844);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10729, 608, 3844);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10729, 608, 3844);

        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        f_10729_945_959_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10729, 766, 1097);
            return return_v;
        }

    }
}
