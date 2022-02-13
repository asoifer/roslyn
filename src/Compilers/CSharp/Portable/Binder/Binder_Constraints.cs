// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        internal ImmutableArray<TypeParameterConstraintClause> BindTypeParameterConstraintClauses(
                    Symbol containingSymbol,
                    ImmutableArray<TypeParameterSymbol> typeParameters,
                    TypeParameterListSyntax typeParameterList,
                    SyntaxList<TypeParameterConstraintClauseSyntax> clauses,
                    DiagnosticBag diagnostics,
                    bool performOnlyCycleSafeValidation,
                    bool isForOverride = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10302, 968, 5370);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 1443, 1515);

                f_10302_1443_1514(f_10302_1456_1513(this.Flags, BinderFlags.GenericConstraintsClause));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 1529, 1582);

                f_10302_1529_1581((object)containingSymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 1596, 1706);

                f_10302_1596_1705((f_10302_1610_1631(containingSymbol) == SymbolKind.NamedType) || (DynAbs.Tracing.TraceSender.Expression_False(10302, 1609, 1704) || (f_10302_1661_1682(containingSymbol) == SymbolKind.Method)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 1720, 1760);

                f_10302_1720_1759(typeParameters.Length > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 1774, 1806);

                f_10302_1774_1805(clauses.Count > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 1822, 1852);

                int
                n = typeParameters.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 2066, 2141);

                var
                names = f_10302_2078_2140(n, StringOrdinalComparer.Instance)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 2155, 2414);
                    foreach (var typeParameter in f_10302_2185_2199_I(typeParameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 2155, 2414);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 2233, 2263);

                        var
                        name = f_10302_2244_2262(typeParameter)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 2281, 2399) || true) && (!f_10302_2286_2309(names, name))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 2281, 2399);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 2351, 2380);

                            f_10302_2351_2379(names, name, f_10302_2367_2378(names));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 2281, 2399);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 2155, 2414);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10302, 1, 260);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10302, 1, 260);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 2527, 2622);

                var
                results = f_10302_2541_2621(n, fillWithValue: null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 2636, 2740);

                var
                syntaxNodes = f_10302_2654_2739(n, fillWithValue: null)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 2813, 4640);
                    foreach (var clause in f_10302_2836_2843_I(clauses))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 2813, 4640);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 2877, 2921);

                        var
                        name = f_10302_2888_2899(clause).Identifier.ValueText
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 2939, 2974);

                        f_10302_2939_2973(name is object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 2992, 3004);

                        int
                        ordinal
                        = default(int);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 3022, 4625) || true) && (f_10302_3026_3062(names, name, out ordinal))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 3022, 4625);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 3104, 3131);

                            f_10302_3104_3130(ordinal >= 0);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 3153, 3179);

                            f_10302_3153_3178(ordinal < n);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 3203, 3420);

                            (TypeParameterConstraintClause constraintClause, ArrayBuilder<TypeConstraintSyntax>? typeConstraintNodes) = f_10302_3311_3419(this, f_10302_3345_3373(typeParameterList)[ordinal], clause, isForOverride, diagnostics);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 3442, 3992) || true) && (f_10302_3446_3462(results, ordinal) == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 3442, 3992);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 3520, 3556);

                                results[ordinal] = constraintClause;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 3582, 3625);

                                syntaxNodes[ordinal] = typeConstraintNodes;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 3442, 3992);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 3442, 3992);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 3830, 3915);

                                f_10302_3830_3914(                        // "A constraint clause has already been specified for type parameter '{0}'. ..."
                                                        diagnostics, ErrorCode.ERR_DuplicateConstraintClause, f_10302_3887_3907(f_10302_3887_3898(clause)), name);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 3941, 3969);

                                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(typeConstraintNodes, 10302, 3941, 3968)?.Free(), 10302, 3961, 3968);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 3442, 3992);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 3022, 4625);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 3022, 4625);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 4485, 4606);

                            f_10302_4485_4605(                    // Unrecognized type parameter. Don't bother binding the constraints
                                                                  // (the ": I<U>" in "where U : I<U>") since that will lead to additional
                                                                  // errors ("type or namespace 'U' could not be found") if the type
                                                                  // parameter is referenced in the constraints.

                                                // "'{1}' does not define type parameter '{0}'"
                                                diagnostics, ErrorCode.ERR_TyVarNotFoundInConstraint, f_10302_4542_4562(f_10302_4542_4553(clause)), name, f_10302_4570_4604(containingSymbol));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 3022, 4625);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 2813, 4640);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10302, 1, 1828);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10302, 1, 1828);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 4748, 4753);

                    // Add default values for type parameters without constraint clauses.
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 4739, 4998) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 4762, 4765)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 4739, 4998))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 4739, 4998);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 4799, 4983) || true) && (f_10302_4803_4813(results, i) == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 4799, 4983);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 4863, 4964);

                            results[i] = f_10302_4876_4963(this, f_10302_4916_4944(typeParameterList)[i], isForOverride);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 4799, 4983);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10302, 1, 260);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10302, 1, 260);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 5014, 5123);

                f_10302_5014_5122(typeParameters, results!, syntaxNodes, performOnlyCycleSafeValidation, diagnostics);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 5139, 5271);
                    foreach (var typeConstraintsSyntaxes in f_10302_5179_5190_I(syntaxNodes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 5139, 5271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 5224, 5256);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(typeConstraintsSyntaxes, 10302, 5224, 5255)?.Free(), 10302, 5248, 5255);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 5139, 5271);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10302, 1, 133);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10302, 1, 133);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 5287, 5306);

                f_10302_5287_5305(
                            syntaxNodes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 5322, 5359);

                return f_10302_5329_5357(results)!;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10302, 968, 5370);

                bool
                f_10302_1456_1513(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 1456, 1513);
                    return return_v;
                }


                int
                f_10302_1443_1514(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 1443, 1514);
                    return 0;
                }


                int
                f_10302_1529_1581(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 1529, 1581);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10302_1610_1631(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 1610, 1631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10302_1661_1682(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 1661, 1682);
                    return return_v;
                }


                int
                f_10302_1596_1705(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 1596, 1705);
                    return 0;
                }


                int
                f_10302_1720_1759(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 1720, 1759);
                    return 0;
                }


                int
                f_10302_1774_1805(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 1774, 1805);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, int>
                f_10302_2078_2140(int
                capacity, Roslyn.Utilities.StringOrdinalComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, int>(capacity, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 2078, 2140);
                    return return_v;
                }


                string
                f_10302_2244_2262(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 2244, 2262);
                    return return_v;
                }


                bool
                f_10302_2286_2309(System.Collections.Generic.Dictionary<string, int>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 2286, 2309);
                    return return_v;
                }


                int
                f_10302_2367_2378(System.Collections.Generic.Dictionary<string, int>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 2367, 2378);
                    return return_v;
                }


                int
                f_10302_2351_2379(System.Collections.Generic.Dictionary<string, int>
                this_param, string
                key, int
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 2351, 2379);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10302_2185_2199_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 2185, 2199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause?>
                f_10302_2541_2621(int
                capacity, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause?
                fillWithValue)
                {
                    var return_v = ArrayBuilder<TypeParameterConstraintClause?>.GetInstance(capacity, fillWithValue: fillWithValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 2541, 2621);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax>?>
                f_10302_2654_2739(int
                capacity, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax>?
                fillWithValue)
                {
                    var return_v = ArrayBuilder<ArrayBuilder<TypeConstraintSyntax>?>.GetInstance(capacity, fillWithValue: fillWithValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 2654, 2739);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10302_2888_2899(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 2888, 2899);
                    return return_v;
                }


                int
                f_10302_2939_2973(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 2939, 2973);
                    return 0;
                }


                bool
                f_10302_3026_3062(System.Collections.Generic.Dictionary<string, int>
                this_param, string
                key, out int
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 3026, 3062);
                    return return_v;
                }


                int
                f_10302_3104_3130(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 3104, 3130);
                    return 0;
                }


                int
                f_10302_3153_3178(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 3153, 3178);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax>
                f_10302_3345_3373(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 3345, 3373);
                    return return_v;
                }


                (Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax>?)
                f_10302_3311_3419(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax
                typeParameterSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax
                constraintClauseSyntax, bool
                isForOverride, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindTypeParameterConstraints(typeParameterSyntax, constraintClauseSyntax, isForOverride, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 3311, 3419);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause?
                f_10302_3446_3462(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause?>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 3446, 3462);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10302_3887_3898(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 3887, 3898);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10302_3887_3907(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 3887, 3907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10302_3830_3914(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 3830, 3914);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10302_4542_4553(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 4542, 4553);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10302_4542_4562(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 4542, 4562);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10302_4570_4604(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.ConstructedFrom();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 4570, 4604);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10302_4485_4605(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 4485, 4605);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                f_10302_2836_2843_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 2836, 2843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause?
                f_10302_4803_4813(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause?>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 4803, 4813);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax>
                f_10302_4916_4944(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 4916, 4944);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause
                f_10302_4876_4963(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax
                typeParameterSyntax, bool
                isForOverride)
                {
                    var return_v = this_param.GetDefaultTypeParameterConstraintClause(typeParameterSyntax, isForOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 4876, 4963);
                    return return_v;
                }


                int
                f_10302_5014_5122(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause?>
                constraintClauses, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax>?>
                syntaxNodes, bool
                performOnlyCycleSafeValidation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    RemoveInvalidConstraints(typeParameters, constraintClauses, syntaxNodes, performOnlyCycleSafeValidation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 5014, 5122);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax>?>
                f_10302_5179_5190_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax>?>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 5179, 5190);
                    return return_v;
                }


                int
                f_10302_5287_5305(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax>?>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 5287, 5305);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause?>
                f_10302_5329_5357(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause?>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 5329, 5357);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10302, 968, 5370);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10302, 968, 5370);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private (TypeParameterConstraintClause, ArrayBuilder<TypeConstraintSyntax>?) BindTypeParameterConstraints(TypeParameterSyntax typeParameterSyntax, TypeParameterConstraintClauseSyntax constraintClauseSyntax, bool isForOverride, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10302, 5559, 16236);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 5837, 5888);

                var
                constraints = TypeParameterConstraintKind.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 5902, 5960);

                ArrayBuilder<TypeWithAnnotations>?
                constraintTypes = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 5974, 6031);

                ArrayBuilder<TypeConstraintSyntax>?
                syntaxBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 6045, 6151);

                SeparatedSyntaxList<TypeParameterConstraintSyntax>
                constraintsSyntax = f_10302_6116_6150(constraintClauseSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 6165, 6199);

                f_10302_6165_6198(f_10302_6178_6197_M(!InExecutableBinder));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 6307, 6342);

                bool
                hasTypeLikeConstraint = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 6356, 6401);

                bool
                reportedOverrideWithConstraints = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 6426, 6431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 6433, 6460);

                    for (int
        i = 0
        ,
        n = constraintsSyntax.Count
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 6417, 14831) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 6469, 6472)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 6417, 14831))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 6417, 14831);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 6506, 6540);

                        var
                        syntax = constraintsSyntax[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 6558, 14816);

                        switch (f_10302_6566_6579(syntax))
                        {

                            case SyntaxKind.ClassConstraint:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 6558, 14816);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 6679, 6708);

                                hasTypeLikeConstraint = true;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 6736, 7290) || true) && (i != 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 6736, 7290);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 6804, 7000) || true) && (!reportedOverrideWithConstraints)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 6804, 7000);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 6906, 6969);

                                        f_10302_6906_6968(syntax, diagnostics);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 6804, 7000);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 7032, 7263) || true) && (isForOverride && (DynAbs.Tracing.TraceSender.Expression_True(10302, 7036, 7157) && (constraints & (TypeParameterConstraintKind.ValueType | TypeParameterConstraintKind.ReferenceType)) != 0))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 7032, 7263);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 7223, 7232);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 7032, 7263);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 6736, 7290);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 7318, 7379);

                                var
                                constraintSyntax = (ClassOrStructConstraintSyntax)syntax
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 7405, 7464);

                                SyntaxToken
                                questionToken = f_10302_7433_7463(constraintSyntax)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 7490, 8849) || true) && (questionToken.IsKind(SyntaxKind.QuestionToken))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 7490, 8849);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 7598, 7663);

                                    constraints |= TypeParameterConstraintKind.NullableReferenceType;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 7695, 8378) || true) && (isForOverride)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 7695, 8378);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 7778, 7866);

                                        f_10302_7778_7865(ref reportedOverrideWithConstraints, syntax, diagnostics);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 7695, 8378);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 7695, 8378);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 7996, 8347);

                                        f_10302_7996_8346(f_10302_8116_8160(this, questionToken), f_10302_8199_8229(this, questionToken), questionToken.GetLocation(), diagnostics);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 7695, 8378);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 7490, 8849);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 7490, 8849);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 8436, 8849) || true) && (isForOverride || (DynAbs.Tracing.TraceSender.Expression_False(10302, 8440, 8525) || f_10302_8457_8525(this, f_10302_8487_8524(constraintSyntax))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 8436, 8849);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 8583, 8651);

                                        constraints |= TypeParameterConstraintKind.NotNullableReferenceType;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 8436, 8849);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 8436, 8849);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 8765, 8822);

                                        constraints |= TypeParameterConstraintKind.ReferenceType;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 8436, 8849);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 7490, 8849);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 8877, 8886);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 6558, 14816);

                            case SyntaxKind.StructConstraint:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 6558, 14816);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 8967, 8996);

                                hasTypeLikeConstraint = true;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 9024, 9578) || true) && (i != 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 9024, 9578);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 9092, 9288) || true) && (!reportedOverrideWithConstraints)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 9092, 9288);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 9194, 9257);

                                        f_10302_9194_9256(syntax, diagnostics);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 9092, 9288);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 9320, 9551) || true) && (isForOverride && (DynAbs.Tracing.TraceSender.Expression_True(10302, 9324, 9445) && (constraints & (TypeParameterConstraintKind.ValueType | TypeParameterConstraintKind.ReferenceType)) != 0))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 9320, 9551);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 9511, 9520);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 9320, 9551);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 9024, 9578);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 9606, 9659);

                                constraints |= TypeParameterConstraintKind.ValueType;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 9685, 9694);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 6558, 14816);

                            case SyntaxKind.ConstructorConstraint:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 6558, 14816);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 9780, 10009) || true) && (isForOverride)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 9780, 10009);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 9855, 9943);

                                    f_10302_9855_9942(ref reportedOverrideWithConstraints, syntax, diagnostics);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 9973, 9982);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 9780, 10009);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 10037, 10269) || true) && ((constraints & TypeParameterConstraintKind.ValueType) != 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 10037, 10269);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 10157, 10242);

                                    f_10302_10157_10241(diagnostics, ErrorCode.ERR_NewBoundWithVal, f_10302_10204_10226(syntax).GetLocation());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 10037, 10269);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 10295, 10533) || true) && ((constraints & TypeParameterConstraintKind.Unmanaged) != 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 10295, 10533);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 10415, 10506);

                                    f_10302_10415_10505(diagnostics, ErrorCode.ERR_NewBoundWithUnmanaged, f_10302_10468_10490(syntax).GetLocation());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 10295, 10533);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 10561, 10748) || true) && (i != n - 1)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 10561, 10748);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 10633, 10721);

                                    f_10302_10633_10720(diagnostics, ErrorCode.ERR_NewBoundMustBeLast, f_10302_10683_10705(syntax).GetLocation());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 10561, 10748);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 10776, 10831);

                                constraints |= TypeParameterConstraintKind.Constructor;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 10857, 10866);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 6558, 14816);

                            case SyntaxKind.DefaultConstraint:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 6558, 14816);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 10948, 11134) || true) && (!isForOverride)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 10948, 11134);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 11024, 11107);

                                    f_10302_11024_11106(diagnostics, ErrorCode.ERR_DefaultConstraintOverrideOnly, f_10302_11085_11105(syntax));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 10948, 11134);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 11162, 11716) || true) && (i != 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 11162, 11716);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 11230, 11426) || true) && (!reportedOverrideWithConstraints)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 11230, 11426);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 11332, 11395);

                                        f_10302_11332_11394(syntax, diagnostics);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 11230, 11426);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 11458, 11689) || true) && (isForOverride && (DynAbs.Tracing.TraceSender.Expression_True(10302, 11462, 11583) && (constraints & (TypeParameterConstraintKind.ValueType | TypeParameterConstraintKind.ReferenceType)) != 0))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 11458, 11689);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 11649, 11658);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 11458, 11689);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 11162, 11716);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 11744, 11795);

                                constraints |= TypeParameterConstraintKind.Default;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 11821, 11830);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 6558, 14816);

                            case SyntaxKind.TypeConstraint:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 6558, 14816);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 11909, 14650) || true) && (isForOverride)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 11909, 14650);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 11984, 12072);

                                    f_10302_11984_12071(ref reportedOverrideWithConstraints, syntax, diagnostics);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 11909, 14650);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 11909, 14650);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 12186, 12215);

                                    hasTypeLikeConstraint = true;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 12247, 12536) || true) && (constraintTypes == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 12247, 12536);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 12340, 12406);

                                        constraintTypes = f_10302_12358_12405();
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 12440, 12505);

                                        syntaxBuilder = f_10302_12456_12504();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 12247, 12536);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 12568, 12624);

                                    var
                                    typeConstraintSyntax = (TypeConstraintSyntax)syntax
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 12654, 12697);

                                    var
                                    typeSyntax = f_10302_12671_12696(typeConstraintSyntax)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 12729, 12834);

                                    var
                                    type = f_10302_12740_12833(this, typeSyntax, diagnostics, out var keyword)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 12866, 14494);

                                    switch (keyword)
                                    {

                                        case ConstraintContextualKeyword.Unmanaged:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 12866, 14494);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 13028, 13277) || true) && (i != 0)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 13028, 13277);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 13120, 13187);

                                                f_10302_13120_13186(typeSyntax, diagnostics);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 13229, 13238);

                                                continue;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 13028, 13277);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 13414, 13516);

                                            f_10302_13414_13515(this, WellKnownType.System_Runtime_InteropServices_UnmanagedType, diagnostics, typeSyntax);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 13554, 13624);

                                            f_10302_13554_13623(this, SpecialType.System_ValueType, diagnostics, typeSyntax);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 13664, 13717);

                                            constraints |= TypeParameterConstraintKind.Unmanaged;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 13755, 13764);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 12866, 14494);

                                        case ConstraintContextualKeyword.NotNull:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 12866, 14494);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 13879, 14077) || true) && (i != 0)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 13879, 14077);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 13971, 14038);

                                                f_10302_13971_14037(typeSyntax, diagnostics);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 13879, 14077);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 14117, 14168);

                                            constraints |= TypeParameterConstraintKind.NotNull;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 14206, 14215);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 12866, 14494);

                                        case ConstraintContextualKeyword.None:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 12866, 14494);
                                            DynAbs.Tracing.TraceSender.TraceBreak(10302, 14327, 14333);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 12866, 14494);

                                        default:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 12866, 14494);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 14413, 14463);

                                            throw f_10302_14419_14462(keyword);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 12866, 14494);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 14526, 14552);

                                    f_10302_14526_14551(
                                                                constraintTypes, type);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 14582, 14623);

                                    f_10302_14582_14622(syntaxBuilder!, typeConstraintSyntax);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 11909, 14650);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 14676, 14685);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 6558, 14816);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 6558, 14816);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 14741, 14797);

                                throw f_10302_14747_14796(f_10302_14782_14795(syntax));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 6558, 14816);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10302, 1, 8415);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10302, 1, 8415);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 14847, 15085) || true) && (!isForOverride && (DynAbs.Tracing.TraceSender.Expression_True(10302, 14851, 14891) && !hasTypeLikeConstraint) && (DynAbs.Tracing.TraceSender.Expression_True(10302, 14851, 14957) && !f_10302_14896_14957(this, f_10302_14926_14956(typeParameterSyntax))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 14847, 15085);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 14991, 15070);

                    constraints |= TypeParameterConstraintKind.ObliviousNullabilityIfReferenceType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 14847, 15085);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 15101, 15346);

                f_10302_15101_15345(!isForOverride || (DynAbs.Tracing.TraceSender.Expression_False(10302, 15114, 15344) || (constraints & (TypeParameterConstraintKind.ReferenceType | TypeParameterConstraintKind.ValueType)) != (TypeParameterConstraintKind.ReferenceType | TypeParameterConstraintKind.ValueType)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 15362, 15520);

                return (f_10302_15370_15503(constraints, f_10302_15420_15457_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(constraintTypes, 10302, 15420, 15457)?.ToImmutableAndFree()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>?>(10302, 15420, 15502) ?? ImmutableArray<TypeWithAnnotations>.Empty)), syntaxBuilder);

                static void reportOverrideWithConstraints(ref bool reportedOverrideWithConstraints, TypeParameterConstraintSyntax syntax, DiagnosticBag diagnostics)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10302, 15536, 15967);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 15717, 15952) || true) && (!reportedOverrideWithConstraints)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 15717, 15952);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 15795, 15872);

                            f_10302_15795_15871(diagnostics, ErrorCode.ERR_OverrideWithConstraints, f_10302_15850_15870(syntax));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 15894, 15933);

                            reportedOverrideWithConstraints = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 15717, 15952);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10302, 15536, 15967);

                        Microsoft.CodeAnalysis.Location
                        f_10302_15850_15870(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintSyntax
                        this_param)
                        {
                            var return_v = this_param.GetLocation();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 15850, 15870);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10302_15795_15871(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.Location
                        location)
                        {
                            var return_v = diagnostics.Add(code, location);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 15795, 15871);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10302, 15536, 15967);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10302, 15536, 15967);
                    }
                }

                static void reportTypeConstraintsMustBeUniqueAndFirst(CSharpSyntaxNode syntax, DiagnosticBag diagnostics)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10302, 15983, 16225);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 16121, 16210);

                        f_10302_16121_16209(diagnostics, ErrorCode.ERR_TypeConstraintsMustBeUniqueAndFirst, f_10302_16188_16208(syntax));
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10302, 15983, 16225);

                        Microsoft.CodeAnalysis.Location
                        f_10302_16188_16208(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        this_param)
                        {
                            var return_v = this_param.GetLocation();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 16188, 16208);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10302_16121_16209(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.Location
                        location)
                        {
                            var return_v = diagnostics.Add(code, location);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 16121, 16209);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10302, 15983, 16225);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10302, 15983, 16225);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10302, 5559, 16236);

                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintSyntax>
                f_10302_6116_6150(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax
                this_param)
                {
                    var return_v = this_param.Constraints;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 6116, 6150);
                    return return_v;
                }


                bool
                f_10302_6178_6197_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 6178, 6197);
                    return return_v;
                }


                int
                f_10302_6165_6198(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 6165, 6198);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10302_6566_6579(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 6566, 6579);
                    return return_v;
                }


                int
                f_10302_6906_6968(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    reportTypeConstraintsMustBeUniqueAndFirst((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 6906, 6968);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10302_7433_7463(Microsoft.CodeAnalysis.CSharp.Syntax.ClassOrStructConstraintSyntax
                this_param)
                {
                    var return_v = this_param.QuestionToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 7433, 7463);
                    return return_v;
                }


                int
                f_10302_7778_7865(ref bool
                reportedOverrideWithConstraints, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    reportOverrideWithConstraints(ref reportedOverrideWithConstraints, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 7778, 7865);
                    return 0;
                }


                bool
                f_10302_8116_8160(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = this_param.AreNullableAnnotationsEnabled(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 8116, 8160);
                    return return_v;
                }


                bool
                f_10302_8199_8229(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = this_param.IsGeneratedCode(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 8199, 8229);
                    return return_v;
                }


                int
                f_10302_7996_8346(bool
                isNullableEnabled, bool
                isGeneratedCode, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    LazyMissingNonNullTypesContextDiagnosticInfo.ReportNullableReferenceTypesIfNeeded(isNullableEnabled, isGeneratedCode, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 7996, 8346);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10302_8487_8524(Microsoft.CodeAnalysis.CSharp.Syntax.ClassOrStructConstraintSyntax
                this_param)
                {
                    var return_v = this_param.ClassOrStructKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 8487, 8524);
                    return return_v;
                }


                bool
                f_10302_8457_8525(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = this_param.AreNullableAnnotationsEnabled(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 8457, 8525);
                    return return_v;
                }


                int
                f_10302_9194_9256(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    reportTypeConstraintsMustBeUniqueAndFirst((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 9194, 9256);
                    return 0;
                }


                int
                f_10302_9855_9942(ref bool
                reportedOverrideWithConstraints, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    reportOverrideWithConstraints(ref reportedOverrideWithConstraints, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 9855, 9942);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10302_10204_10226(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintSyntax
                this_param)
                {
                    var return_v = this_param.GetFirstToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 10204, 10226);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10302_10157_10241(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 10157, 10241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10302_10468_10490(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintSyntax
                this_param)
                {
                    var return_v = this_param.GetFirstToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 10468, 10490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10302_10415_10505(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 10415, 10505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10302_10683_10705(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintSyntax
                this_param)
                {
                    var return_v = this_param.GetFirstToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 10683, 10705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10302_10633_10720(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 10633, 10720);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10302_11085_11105(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintSyntax
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 11085, 11105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10302_11024_11106(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 11024, 11106);
                    return return_v;
                }


                int
                f_10302_11332_11394(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    reportTypeConstraintsMustBeUniqueAndFirst((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 11332, 11394);
                    return 0;
                }


                int
                f_10302_11984_12071(ref bool
                reportedOverrideWithConstraints, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    reportOverrideWithConstraints(ref reportedOverrideWithConstraints, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 11984, 12071);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10302_12358_12405()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 12358, 12405);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax>
                f_10302_12456_12504()
                {
                    var return_v = ArrayBuilder<TypeConstraintSyntax>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 12456, 12504);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10302_12671_12696(Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 12671, 12696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10302_12740_12833(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.Binder.ConstraintContextualKeyword
                keyword)
                {
                    var return_v = this_param.BindTypeOrConstraintKeyword(syntax, diagnostics, out keyword);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 12740, 12833);
                    return return_v;
                }


                int
                f_10302_13120_13186(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    reportTypeConstraintsMustBeUniqueAndFirst((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 13120, 13186);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10302_13414_13515(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                node)
                {
                    var return_v = this_param.GetWellKnownType(type, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 13414, 13515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10302_13554_13623(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 13554, 13623);
                    return return_v;
                }


                int
                f_10302_13971_14037(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    reportTypeConstraintsMustBeUniqueAndFirst((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 13971, 14037);
                    return 0;
                }


                System.Exception
                f_10302_14419_14462(Microsoft.CodeAnalysis.CSharp.Binder.ConstraintContextualKeyword
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 14419, 14462);
                    return return_v;
                }


                int
                f_10302_14526_14551(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 14526, 14551);
                    return 0;
                }


                int
                f_10302_14582_14622(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 14582, 14622);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10302_14782_14795(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 14782, 14795);
                    return return_v;
                }


                System.Exception
                f_10302_14747_14796(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 14747, 14796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10302_14926_14956(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 14926, 14956);
                    return return_v;
                }


                bool
                f_10302_14896_14957(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = this_param.AreNullableAnnotationsEnabled(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 14896, 14957);
                    return return_v;
                }


                int
                f_10302_15101_15345(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 15101, 15345);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>?
                f_10302_15420_15457_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 15420, 15457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause
                f_10302_15370_15503(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                constraints, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                constraintTypes)
                {
                    var return_v = TypeParameterConstraintClause.Create(constraints, constraintTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 15370, 15503);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10302, 5559, 16236);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10302, 5559, 16236);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<TypeParameterConstraintClause> GetDefaultTypeParameterConstraintClauses(TypeParameterListSyntax typeParameterList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10302, 16248, 16799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 16411, 16517);

                var
                builder = f_10302_16425_16516(typeParameterList.Parameters.Count)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 16533, 16736);
                    foreach (TypeParameterSyntax typeParameterSyntax in f_10302_16585_16613_I(f_10302_16585_16613(typeParameterList)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 16533, 16736);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 16647, 16721);

                        f_10302_16647_16720(builder, f_10302_16659_16719(this, typeParameterSyntax));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 16533, 16736);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10302, 1, 204);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10302, 1, 204);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 16752, 16788);

                return f_10302_16759_16787(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10302, 16248, 16799);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                f_10302_16425_16516(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeParameterConstraintClause>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 16425, 16516);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax>
                f_10302_16585_16613(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 16585, 16613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause
                f_10302_16659_16719(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax
                typeParameterSyntax)
                {
                    var return_v = this_param.GetDefaultTypeParameterConstraintClause(typeParameterSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 16659, 16719);
                    return return_v;
                }


                int
                f_10302_16647_16720(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 16647, 16720);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax>
                f_10302_16585_16613_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 16585, 16613);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                f_10302_16759_16787(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 16759, 16787);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10302, 16248, 16799);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10302, 16248, 16799);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeParameterConstraintClause GetDefaultTypeParameterConstraintClause(TypeParameterSyntax typeParameterSyntax, bool isForOverride = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10302, 16811, 17185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 16982, 17174);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10302, 16989, 17067) || ((isForOverride || (DynAbs.Tracing.TraceSender.Expression_False(10302, 16989, 17067) || f_10302_17006_17067(this, f_10302_17036_17066(typeParameterSyntax))) && DynAbs.Tracing.TraceSender.Conditional_F2(10302, 17070, 17105)) || DynAbs.Tracing.TraceSender.Conditional_F3(10302, 17108, 17173))) ? TypeParameterConstraintClause.Empty : TypeParameterConstraintClause.ObliviousNullabilityIfReferenceType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10302, 16811, 17185);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10302_17036_17066(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 17036, 17066);
                    return return_v;
                }


                bool
                f_10302_17006_17067(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = this_param.AreNullableAnnotationsEnabled(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 17006, 17067);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10302, 16811, 17185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10302, 16811, 17185);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void RemoveInvalidConstraints(
                    ImmutableArray<TypeParameterSymbol> typeParameters,
                    ArrayBuilder<TypeParameterConstraintClause> constraintClauses,
                    ArrayBuilder<ArrayBuilder<TypeConstraintSyntax>?> syntaxNodes,
                    bool performOnlyCycleSafeValidation,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10302, 17337, 18125);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 17714, 17754);

                f_10302_17714_17753(typeParameters.Length > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 17768, 17831);

                f_10302_17768_17830(typeParameters.Length == f_10302_17806_17829(constraintClauses));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 17845, 17875);

                int
                n = typeParameters.Length
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 17898, 17903);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 17889, 18114) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 17912, 17915)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 17889, 18114))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 17889, 18114);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 17949, 18099);

                        constraintClauses[i] = f_10302_17972_18098(typeParameters[i], f_10302_18016_18036(constraintClauses, i), f_10302_18038_18052(syntaxNodes, i), performOnlyCycleSafeValidation, diagnostics);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10302, 1, 226);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10302, 1, 226);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10302, 17337, 18125);

                int
                f_10302_17714_17753(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 17714, 17753);
                    return 0;
                }


                int
                f_10302_17806_17829(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 17806, 17829);
                    return return_v;
                }


                int
                f_10302_17768_17830(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 17768, 17830);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause
                f_10302_18016_18036(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 18016, 18036);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax>?
                f_10302_18038_18052(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax>?>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 18038, 18052);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause
                f_10302_17972_18098(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause
                constraintClause, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax>?
                syntaxNodesOpt, bool
                performOnlyCycleSafeValidation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = RemoveInvalidConstraints(typeParameter, constraintClause, syntaxNodesOpt, performOnlyCycleSafeValidation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 17972, 18098);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10302, 17337, 18125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10302, 17337, 18125);
            }
        }

        private static TypeParameterConstraintClause RemoveInvalidConstraints(
                    TypeParameterSymbol typeParameter,
                    TypeParameterConstraintClause constraintClause,
                    ArrayBuilder<TypeConstraintSyntax>? syntaxNodesOpt,
                    bool performOnlyCycleSafeValidation,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10302, 18137, 20258);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 18496, 20207) || true) && (syntaxNodesOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 18496, 20207);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 18556, 18611);

                    var
                    constraintTypes = constraintClause.ConstraintTypes
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 18629, 18686);

                    Symbol
                    containingSymbol = f_10302_18655_18685(typeParameter)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 18706, 18782);

                    var
                    constraintTypeBuilder = f_10302_18734_18781()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 18800, 18831);

                    int
                    n = constraintTypes.Length
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 18860, 18865);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 18851, 19909) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 18874, 18877)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 18851, 19909))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 18851, 19909);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 18919, 18959);

                            var
                            constraintType = constraintTypes[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 18981, 19012);

                            var
                            syntax = f_10302_18994_19011(syntaxNodesOpt, i)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 19375, 19890) || true) && (f_10302_19379_19533(typeParameter, syntax, constraintType, constraintClause.Constraints, constraintTypeBuilder, performOnlyCycleSafeValidation, diagnostics))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 19375, 19890);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 19583, 19797) || true) && (!performOnlyCycleSafeValidation)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 19583, 19797);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 19676, 19770);

                                    f_10302_19676_19769(containingSymbol, f_10302_19724_19739(syntax), constraintType, diagnostics);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 19583, 19797);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 19825, 19867);

                                f_10302_19825_19866(
                                                        constraintTypeBuilder, constraintType);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 19375, 19890);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10302, 1, 1059);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10302, 1, 1059);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 19929, 20143) || true) && (f_10302_19933_19960(constraintTypeBuilder) < n)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 19929, 20143);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 20006, 20124);

                        return f_10302_20013_20123(constraintClause.Constraints, f_10302_20080_20122(constraintTypeBuilder));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 19929, 20143);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 20163, 20192);

                    f_10302_20163_20191(
                                    constraintTypeBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 18496, 20207);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 20223, 20247);

                return constraintClause;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10302, 18137, 20258);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10302_18655_18685(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 18655, 18685);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10302_18734_18781()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 18734, 18781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax
                f_10302_18994_19011(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 18994, 19011);
                    return return_v;
                }


                bool
                f_10302_19379_19533(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                constraints, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                constraintTypes, bool
                performOnlyCycleSafeValidation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = IsValidConstraint(typeParameter, syntax, type, constraints, constraintTypes, performOnlyCycleSafeValidation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 19379, 19533);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10302_19724_19739(Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 19724, 19739);
                    return return_v;
                }


                int
                f_10302_19676_19769(Microsoft.CodeAnalysis.CSharp.Symbol
                containingSymbol, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                constraintType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    CheckConstraintTypeVisibility(containingSymbol, location, constraintType, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 19676, 19769);
                    return 0;
                }


                int
                f_10302_19825_19866(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 19825, 19866);
                    return 0;
                }


                int
                f_10302_19933_19960(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 19933, 19960);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10302_20080_20122(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 20080, 20122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause
                f_10302_20013_20123(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                constraints, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                constraintTypes)
                {
                    var return_v = TypeParameterConstraintClause.Create(constraints, constraintTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 20013, 20123);
                    return return_v;
                }


                int
                f_10302_20163_20191(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 20163, 20191);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10302, 18137, 20258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10302, 18137, 20258);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void CheckConstraintTypeVisibility(
                    Symbol containingSymbol,
                    Location location,
                    TypeWithAnnotations constraintType,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10302, 20270, 20964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 20504, 20555);

                HashSet<DiagnosticInfo>?
                useSiteDiagnostics = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 20569, 20893) || true) && (!containingSymbol.IsNoMoreVisibleThan(constraintType, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 20569, 20893);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 20786, 20878);

                    f_10302_20786_20877(                // "Inconsistent accessibility: constraint type '{1}' is less accessible than '{0}'"
                                    diagnostics, ErrorCode.ERR_BadVisBound, location, containingSymbol, constraintType.Type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 20569, 20893);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 20907, 20953);

                f_10302_20907_20952(diagnostics, location, useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10302, 20270, 20964);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10302_20786_20877(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 20786, 20877);
                    return return_v;
                }


                bool
                f_10302_20907_20952(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 20907, 20952);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10302, 20270, 20964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10302, 20270, 20964);
            }
        }

        private static bool IsValidConstraint(
                    TypeParameterSymbol typeParameter,
                    TypeConstraintSyntax syntax,
                    TypeWithAnnotations type,
                    TypeParameterConstraintKind constraints,
                    ArrayBuilder<TypeWithAnnotations> constraintTypes,
                    bool performOnlyCycleSafeValidation,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10302, 21142, 28949);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 21542, 21704) || true) && (!f_10302_21547_21642(typeParameter, syntax, type, performOnlyCycleSafeValidation, diagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 21542, 21704);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 21676, 21689);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 21542, 21704);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 21720, 22121) || true) && (!performOnlyCycleSafeValidation && (DynAbs.Tracing.TraceSender.Expression_True(10302, 21724, 21838) && f_10302_21759_21838(constraintTypes, c => type.Equals(c, TypeCompareKind.AllIgnoreOptions))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 21720, 22121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 21946, 22075);

                    f_10302_21946_22074(diagnostics, ErrorCode.ERR_DuplicateBound, syntax, f_10302_22003_22053(type.Type), f_10302_22055_22073(typeParameter));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 22093, 22106);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 21720, 22121);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 22137, 24650) || true) && (!f_10302_22142_22176(type.DefaultType) && (DynAbs.Tracing.TraceSender.Expression_True(10302, 22141, 22396) && type.TypeKind == TypeKind.Class))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 22137, 24650);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 22722, 23016) || true) && (f_10302_22726_22747(constraintTypes) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 22722, 23016);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 22890, 22962);

                        f_10302_22890_22961(diagnostics, ErrorCode.ERR_ClassBoundNotFirst, syntax, type.Type);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 22984, 22997);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 22722, 23016);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 23036, 24635) || true) && ((constraints & (TypeParameterConstraintKind.ReferenceType)) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 23036, 24635);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 23146, 23737);

                        switch (type.SpecialType)
                        {

                            case SpecialType.System_Enum:
                            case SpecialType.System_Delegate:
                            case SpecialType.System_MulticastDelegate:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 23146, 23737);
                                DynAbs.Tracing.TraceSender.TraceBreak(10302, 23406, 23412);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 23146, 23737);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 23146, 23737);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 23597, 23671);

                                f_10302_23597_23670(diagnostics, ErrorCode.ERR_RefValBoundWithClass, syntax, type.Type);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 23701, 23714);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 23146, 23737);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 23036, 24635);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 23036, 24635);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 23779, 24635) || true) && (type.SpecialType != SpecialType.System_Enum)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 23779, 24635);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 23868, 24616) || true) && ((constraints & TypeParameterConstraintKind.ValueType) != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 23868, 24616);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 24095, 24169);

                                f_10302_24095_24168(diagnostics, ErrorCode.ERR_RefValBoundWithClass, syntax, type.Type);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 24195, 24208);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 23868, 24616);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 23868, 24616);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 24258, 24616) || true) && ((constraints & TypeParameterConstraintKind.Unmanaged) != 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 24258, 24616);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 24477, 24554);

                                    f_10302_24477_24553(diagnostics, ErrorCode.ERR_UnmanagedBoundWithClass, syntax, type.Type);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 24580, 24593);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 24258, 24616);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 23868, 24616);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 23779, 24635);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 23036, 24635);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 22137, 24650);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 24666, 24678);

                return true;

                static bool isValidConstraintType(TypeParameterSymbol typeParameter, TypeConstraintSyntax syntax, TypeWithAnnotations typeWithAnnotations, bool performOnlyCycleSafeValidation, DiagnosticBag diagnostics)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10302, 24831, 28938);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 25066, 25440) || true) && (typeWithAnnotations.NullableAnnotation == NullableAnnotation.Annotated && (DynAbs.Tracing.TraceSender.Expression_True(10302, 25070, 25174) && performOnlyCycleSafeValidation) && (DynAbs.Tracing.TraceSender.Expression_True(10302, 25070, 25279) && typeWithAnnotations.DefaultType is TypeParameterSymbol typeParameterInConstraint) && (DynAbs.Tracing.TraceSender.Expression_True(10302, 25070, 25367) && f_10302_25283_25325(typeParameterInConstraint) == (object)f_10302_25337_25367(typeParameter)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 25066, 25440);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 25409, 25421);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 25066, 25440);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 25460, 25503);

                        TypeSymbol
                        type = typeWithAnnotations.Type
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 25523, 26432);

                        switch (f_10302_25531_25547(type))
                        {

                            case SpecialType.System_Enum:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 25523, 26432);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 25644, 25738);

                                f_10302_25644_25737(syntax, MessageID.IDS_FeatureEnumGenericTypeConstraint, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceBreak(10302, 25764, 25770);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 25523, 26432);

                            case SpecialType.System_Delegate:
                            case SpecialType.System_MulticastDelegate:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 25523, 26432);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 25917, 26015);

                                f_10302_25917_26014(syntax, MessageID.IDS_FeatureDelegateGenericTypeConstraint, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceBreak(10302, 26041, 26047);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 25523, 26432);

                            case SpecialType.System_Object:
                            case SpecialType.System_ValueType:
                            case SpecialType.System_Array:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 25523, 26432);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 26307, 26374);

                                f_10302_26307_26373(diagnostics, ErrorCode.ERR_SpecialTypeAsBound, syntax, type);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 26400, 26413);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 25523, 26432);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 26452, 28603);

                        switch (f_10302_26460_26473(type))
                        {

                            case TypeKind.Error:
                            case TypeKind.TypeParameter:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 26452, 28603);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 26611, 26623);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 26452, 28603);

                            case TypeKind.Interface:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 26452, 28603);
                                DynAbs.Tracing.TraceSender.TraceBreak(10302, 26697, 26703);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 26452, 28603);

                            case TypeKind.Dynamic:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 26452, 28603);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 26843, 26904);

                                f_10302_26843_26903(diagnostics, ErrorCode.ERR_DynamicTypeAsBound, syntax);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 26930, 26943);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 26452, 28603);

                            case TypeKind.Class:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 26452, 28603);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 27013, 27475) || true) && (f_10302_27017_27030(type))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 27013, 27475);

                                    goto case TypeKind.Struct;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 27013, 27475);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 27013, 27475);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 27172, 27475) || true) && (f_10302_27176_27189(type))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 27172, 27475);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 27333, 27405);

                                        f_10302_27333_27404(diagnostics, ErrorCode.ERR_ConstraintIsStaticClass, syntax, type);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 27435, 27448);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 27172, 27475);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 27013, 27475);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10302, 27501, 27507);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 26452, 28603);

                            case TypeKind.Delegate:
                            case TypeKind.Enum:
                            case TypeKind.Struct:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 26452, 28603);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 27817, 27878);

                                f_10302_27817_27877(diagnostics, ErrorCode.ERR_BadBoundType, syntax, type);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 27904, 27917);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 26452, 28603);

                            case TypeKind.Array:
                            case TypeKind.Pointer:
                            case TypeKind.FunctionPointer:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 26452, 28603);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 28228, 28302);

                                f_10302_28228_28301(diagnostics, ErrorCode.ERR_BadConstraintType, f_10302_28280_28300(syntax));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 28328, 28341);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 26452, 28603);

                            case TypeKind.Submission:
                            // script class is synthesized, never used as a constraint

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 26452, 28603);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 28528, 28584);

                                throw f_10302_28534_28583(f_10302_28569_28582(type));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 26452, 28603);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 28623, 28891) || true) && (f_10302_28627_28649(type))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10302, 28623, 28891);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 28759, 28837);

                            f_10302_28759_28836(diagnostics, ErrorCode.ERR_ConstructedDynamicTypeAsBound, syntax, type);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 28859, 28872);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10302, 28623, 28891);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10302, 28911, 28923);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10302, 24831, 28938);

                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10302_25283_25325(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 25283, 25325);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10302_25337_25367(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 25337, 25367);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SpecialType
                        f_10302_25531_25547(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.SpecialType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 25531, 25547);
                            return return_v;
                        }


                        bool
                        f_10302_25644_25737(Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax
                        syntax, Microsoft.CodeAnalysis.CSharp.MessageID
                        feature, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            var return_v = CheckFeatureAvailability((Microsoft.CodeAnalysis.SyntaxNode)syntax, feature, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 25644, 25737);
                            return return_v;
                        }


                        bool
                        f_10302_25917_26014(Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax
                        syntax, Microsoft.CodeAnalysis.CSharp.MessageID
                        feature, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            var return_v = CheckFeatureAvailability((Microsoft.CodeAnalysis.SyntaxNode)syntax, feature, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 25917, 26014);
                            return return_v;
                        }


                        int
                        f_10302_26307_26373(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax
                        syntax, params object[]
                        args)
                        {
                            Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 26307, 26373);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.TypeKind
                        f_10302_26460_26473(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.TypeKind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 26460, 26473);
                            return return_v;
                        }


                        int
                        f_10302_26843_26903(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax
                        syntax)
                        {
                            Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 26843, 26903);
                            return 0;
                        }


                        bool
                        f_10302_27017_27030(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.IsSealed;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 27017, 27030);
                            return return_v;
                        }


                        bool
                        f_10302_27176_27189(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.IsStatic;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 27176, 27189);
                            return return_v;
                        }


                        int
                        f_10302_27333_27404(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax
                        syntax, params object[]
                        args)
                        {
                            Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 27333, 27404);
                            return 0;
                        }


                        int
                        f_10302_27817_27877(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax
                        syntax, params object[]
                        args)
                        {
                            Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 27817, 27877);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.Location
                        f_10302_28280_28300(Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax
                        this_param)
                        {
                            var return_v = this_param.GetLocation();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 28280, 28300);
                            return return_v;
                        }


                        int
                        f_10302_28228_28301(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.Location
                        location)
                        {
                            Error(diagnostics, code, location);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 28228, 28301);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.TypeKind
                        f_10302_28569_28582(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.TypeKind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 28569, 28582);
                            return return_v;
                        }


                        System.Exception
                        f_10302_28534_28583(Microsoft.CodeAnalysis.TypeKind
                        o)
                        {
                            var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 28534, 28583);
                            return return_v;
                        }


                        bool
                        f_10302_28627_28649(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.ContainsDynamic();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 28627, 28649);
                            return return_v;
                        }


                        int
                        f_10302_28759_28836(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax
                        syntax, params object[]
                        args)
                        {
                            Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 28759, 28836);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10302, 24831, 28938);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10302, 24831, 28938);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10302, 21142, 28949);

                bool
                f_10302_21547_21642(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations, bool
                performOnlyCycleSafeValidation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = isValidConstraintType(typeParameter, syntax, typeWithAnnotations, performOnlyCycleSafeValidation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 21547, 21642);
                    return return_v;
                }


                bool
                f_10302_21759_21838(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                sequence, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, bool>
                predicate)
                {
                    var return_v = sequence.Contains<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 21759, 21838);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10302_22003_22053(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SetUnknownNullabilityForReferenceTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 22003, 22053);
                    return return_v;
                }


                string
                f_10302_22055_22073(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 22055, 22073);
                    return return_v;
                }


                int
                f_10302_21946_22074(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 21946, 22074);
                    return 0;
                }


                bool
                f_10302_22142_22176(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 22142, 22176);
                    return return_v;
                }


                int
                f_10302_22726_22747(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10302, 22726, 22747);
                    return return_v;
                }


                int
                f_10302_22890_22961(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 22890, 22961);
                    return 0;
                }


                int
                f_10302_23597_23670(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 23597, 23670);
                    return 0;
                }


                int
                f_10302_24095_24168(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 24095, 24168);
                    return 0;
                }


                int
                f_10302_24477_24553(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10302, 24477, 24553);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10302, 21142, 28949);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10302, 21142, 28949);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
