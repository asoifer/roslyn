// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    [DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
    internal sealed class Imports
    {
        internal static readonly Imports Empty;

        private readonly CSharpCompilation _compilation;

        private readonly DiagnosticBag _diagnostics;

        private SymbolCompletionState _state;

        public readonly ImmutableDictionary<string, AliasAndUsingDirective> UsingAliases;

        public readonly ImmutableArray<NamespaceOrTypeAndUsingDirective> Usings;

        public readonly ImmutableArray<AliasAndExternAliasDirective> ExternAliases;

        private Imports(
                    CSharpCompilation compilation,
                    ImmutableDictionary<string, AliasAndUsingDirective> usingAliases,
                    ImmutableArray<NamespaceOrTypeAndUsingDirective> usings,
                    ImmutableArray<AliasAndExternAliasDirective> externs,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10345, 1723, 2412);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 1234, 1246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 1288, 1300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 1531, 1543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 2064, 2099);

                f_10345_2064_2098(usingAliases != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 2113, 2145);

                f_10345_2113_2144(f_10345_2126_2143_M(!usings.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 2159, 2192);

                f_10345_2159_2191(f_10345_2172_2190_M(!externs.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 2208, 2235);

                _compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 2249, 2282);

                this.UsingAliases = usingAliases;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 2296, 2317);

                this.Usings = usings;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 2331, 2358);

                _diagnostics = diagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 2372, 2401);

                this.ExternAliases = externs;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10345, 1723, 2412);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 1723, 2412);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 1723, 2412);
            }
        }

        internal string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10345, 2424, 2830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 2485, 2817);

                return f_10345_2492_2816("; ", f_10345_2527_2815(f_10345_2527_2729(f_10345_2527_2654(f_10345_2527_2602(UsingAliases, x => x.Value.UsingDirective.Location.SourceSpan.Start), ua => $"{ua.Key} = {ua.Value.Alias.Target}"), Usings.Select(u => u.NamespaceOrType.ToString())), ExternAliases.Select(ea => $"extern alias {ea.Alias.Name}")));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10345, 2424, 2830);

                System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>>
                f_10345_2527_2602(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                source, System.Func<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>, int>
                keySelector)
                {
                    var return_v = source.OrderBy<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>, int>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 2527, 2602);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10345_2527_2654(System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>>
                source, System.Func<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>, string>
                selector)
                {
                    var return_v = source.Select<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 2527, 2654);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10345_2527_2729(System.Collections.Generic.IEnumerable<string>
                first, System.Collections.Generic.IEnumerable<string>
                second)
                {
                    var return_v = first.Concat<string>(second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 2527, 2729);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10345_2527_2815(System.Collections.Generic.IEnumerable<string>
                first, System.Collections.Generic.IEnumerable<string>
                second)
                {
                    var return_v = first.Concat<string>(second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 2527, 2815);
                    return return_v;
                }


                string
                f_10345_2492_2816(string
                separator, System.Collections.Generic.IEnumerable<string>
                values)
                {
                    var return_v = string.Join(separator, values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 2492, 2816);
                    return return_v;
                }


            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 2424, 2830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 2424, 2830);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Imports FromSyntax(
                    CSharpSyntaxNode declarationSyntax,
                    InContainerBinder binder,
                    ConsList<TypeSymbol> basesBeingResolved,
                    bool inUsing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10345, 2842, 13038);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 3069, 3118);

                SyntaxList<UsingDirectiveSyntax>
                usingDirectives
                = default(SyntaxList<UsingDirectiveSyntax>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 3132, 3193);

                SyntaxList<ExternAliasDirectiveSyntax>
                externAliasDirectives
                = default(SyntaxList<ExternAliasDirectiveSyntax>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 3207, 4163) || true) && (f_10345_3211_3235(declarationSyntax) == SyntaxKind.CompilationUnit)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 3207, 4163);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 3299, 3362);

                    var
                    compilationUnit = (CompilationUnitSyntax)declarationSyntax
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 3458, 3553);

                    usingDirectives = (DynAbs.Tracing.TraceSender.Conditional_F1(10345, 3476, 3483) || ((inUsing && DynAbs.Tracing.TraceSender.Conditional_F2(10345, 3486, 3527)) || DynAbs.Tracing.TraceSender.Conditional_F3(10345, 3530, 3552))) ? default(SyntaxList<UsingDirectiveSyntax>) : f_10345_3530_3552(compilationUnit);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 3571, 3619);

                    externAliasDirectives = f_10345_3595_3618(compilationUnit);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 3207, 4163);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 3207, 4163);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 3653, 4163) || true) && (f_10345_3657_3681(declarationSyntax) == SyntaxKind.NamespaceDeclaration)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 3653, 4163);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 3750, 3816);

                        var
                        namespaceDecl = (NamespaceDeclarationSyntax)declarationSyntax
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 3912, 4005);

                        usingDirectives = (DynAbs.Tracing.TraceSender.Conditional_F1(10345, 3930, 3937) || ((inUsing && DynAbs.Tracing.TraceSender.Conditional_F2(10345, 3940, 3981)) || DynAbs.Tracing.TraceSender.Conditional_F3(10345, 3984, 4004))) ? default(SyntaxList<UsingDirectiveSyntax>) : f_10345_3984_4004(namespaceDecl);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 4023, 4069);

                        externAliasDirectives = f_10345_4047_4068(namespaceDecl);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 3653, 4163);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 3653, 4163);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 4135, 4148);

                        return Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 3653, 4163);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 3207, 4163);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 4179, 4307) || true) && (usingDirectives.Count == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10345, 4183, 4245) && externAliasDirectives.Count == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 4179, 4307);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 4279, 4292);

                    return Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 4179, 4307);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 4524, 4562);

                var
                diagnostics = f_10345_4542_4561()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 4578, 4615);

                var
                compilation = f_10345_4596_4614(binder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 4631, 4714);

                var
                externAliases = f_10345_4651_4713(externAliasDirectives, binder, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 4728, 4802);

                var
                usings = f_10345_4741_4801()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 4816, 4896);

                ImmutableDictionary<string, AliasAndUsingDirective>.Builder
                usingAliases = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 4910, 12753) || true) && (usingDirectives.Count > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 4910, 12753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 5177, 5197);

                    Binder
                    usingsBinder
                    = default(Binder);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 5215, 6073) || true) && (f_10345_5219_5260(f_10345_5219_5255(f_10345_5219_5247(declarationSyntax))) != SourceCodeKind.Regular)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 5215, 6073);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 5328, 5453);

                        usingsBinder = f_10345_5343_5452(f_10345_5343_5401(compilation, f_10345_5372_5400(declarationSyntax)), declarationSyntax, inUsing: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 5215, 6073);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 5215, 6073);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 5535, 5955);

                        var
                        imports = (DynAbs.Tracing.TraceSender.Conditional_F1(10345, 5549, 5574) || ((externAliases.Length == 0
                        && DynAbs.Tracing.TraceSender.Conditional_F2(10345, 5602, 5607)) || DynAbs.Tracing.TraceSender.Conditional_F3(10345, 5635, 5954))) ? Empty
                        : f_10345_5635_5954(compilation, ImmutableDictionary<string, AliasAndUsingDirective>.Empty, ImmutableArray<NamespaceOrTypeAndUsingDirective>.Empty, externAliases, diagnostics: null)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 5977, 6054);

                        usingsBinder = f_10345_5992_6053(f_10345_6014_6030(binder), f_10345_6032_6043(binder), imports);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 5215, 6073);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 6093, 6197);

                    var
                    uniqueUsings = f_10345_6112_6196()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 6217, 12698);
                        foreach (var usingDirective in f_10345_6248_6263_I(usingDirectives))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 6217, 12698);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 6305, 6346);

                            f_10345_6305_6345(compilation, usingDirective);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 6370, 12679) || true) && (f_10345_6374_6394(usingDirective) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 6370, 12679);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 6452, 6514);

                                SyntaxToken
                                identifier = f_10345_6477_6513(f_10345_6477_6502(f_10345_6477_6497(usingDirective)))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 6540, 6595);

                                Location
                                location = f_10345_6560_6594(f_10345_6560_6585(f_10345_6560_6580(usingDirective)))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 6623, 6824) || true) && (identifier.ContextualKind() == SyntaxKind.GlobalKeyword)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 6623, 6824);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 6740, 6797);

                                    f_10345_6740_6796(diagnostics, ErrorCode.WRN_GlobalAliasDefn, location);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 6623, 6824);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 6852, 7046) || true) && (f_10345_6856_6884(usingDirective) != default(SyntaxToken))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 6852, 7046);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 6966, 7019);

                                    f_10345_6966_7018(diagnostics, ErrorCode.ERR_NoAliasHere, location);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 6852, 7046);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 7074, 7181);

                                f_10345_7074_7180(identifier.Text, compilation, diagnostics, location);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 7209, 7259);

                                string
                                identifierValueText = identifier.ValueText
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 7285, 9219) || true) && (usingAliases != null && (DynAbs.Tracing.TraceSender.Expression_True(10345, 7289, 7358) && f_10345_7313_7358(usingAliases, identifierValueText)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 7285, 9219);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 7494, 7798) || true) && (f_10345_7498_7528_M(!f_10345_7499_7518(usingDirective).IsMissing))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 7494, 7798);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 7690, 7767);

                                        f_10345_7690_7766(                                // The using alias '{0}' appeared previously in this namespace
                                                                        diagnostics, ErrorCode.ERR_DuplicateAlias, location, identifierValueText);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 7494, 7798);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 7285, 9219);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 7285, 9219);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 8029, 8561);
                                        foreach (var externAlias in f_10345_8057_8070_I(externAliases))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 8029, 8561);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 8136, 8530) || true) && (f_10345_8140_8162(externAlias.Alias) == identifierValueText)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 8136, 8530);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 8359, 8451);

                                                f_10345_8359_8450(                                    // The using alias '{0}' appeared previously in this namespace
                                                                                    diagnostics, ErrorCode.ERR_DuplicateAlias, f_10345_8405_8428(usingDirective), identifierValueText);
                                                DynAbs.Tracing.TraceSender.TraceBreak(10345, 8489, 8495);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 8136, 8530);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 8029, 8561);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10345, 1, 533);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10345, 1, 533);
                                    }
                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 8593, 8797) || true) && (usingAliases == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 8593, 8797);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 8683, 8766);

                                        usingAliases = f_10345_8698_8765();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 8593, 8797);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 9036, 9192);

                                    f_10345_9036_9191(
                                                                // construct the alias sym with the binder for which we are building imports. That
                                                                // way the alias target can make use of extern alias definitions.
                                                                usingAliases, identifierValueText, f_10345_9074_9190(f_10345_9101_9173(usingsBinder, f_10345_9131_9150(usingDirective), f_10345_9152_9172(usingDirective)), usingDirective));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 7285, 9219);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 6370, 12679);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 6370, 12679);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 9317, 9540) || true) && (f_10345_9321_9350(f_10345_9321_9340(usingDirective)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 9317, 9540);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 9504, 9513);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 9317, 9540);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 9568, 9663);

                                var
                                declarationBinder = f_10345_9592_9662(usingsBinder, BinderFlags.SuppressConstraintChecks)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 9689, 9824);

                                var
                                imported = f_10345_9704_9801(declarationBinder, f_10345_9748_9767(usingDirective), diagnostics, basesBeingResolved).NamespaceOrTypeSymbol
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 9850, 12656) || true) && (f_10345_9854_9867(imported) == SymbolKind.Namespace)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 9850, 12656);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 9949, 10705) || true) && (f_10345_9953_9981(usingDirective) != default(SyntaxToken))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 9949, 10705);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 10071, 10155);

                                        f_10345_10071_10154(diagnostics, ErrorCode.ERR_BadUsingType, f_10345_10115_10143(f_10345_10115_10134(usingDirective)), imported);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 9949, 10705);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 9949, 10705);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 10221, 10705) || true) && (f_10345_10225_10256(uniqueUsings, imported))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 10221, 10705);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 10322, 10408);

                                            f_10345_10322_10407(diagnostics, ErrorCode.WRN_DuplicateUsing, f_10345_10368_10396(f_10345_10368_10387(usingDirective)), imported);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 10221, 10705);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 10221, 10705);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 10538, 10565);

                                            f_10345_10538_10564(uniqueUsings, imported);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 10599, 10674);

                                            f_10345_10599_10673(usings, f_10345_10610_10672(imported, usingDirective));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 10221, 10705);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 9949, 10705);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 9850, 12656);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 9850, 12656);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 10763, 12656) || true) && (f_10345_10767_10780(imported) == SymbolKind.NamedType)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 10763, 12656);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 10862, 12003) || true) && (f_10345_10866_10894(usingDirective) == default(SyntaxToken))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 10862, 12003);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 10984, 11073);

                                            f_10345_10984_11072(diagnostics, ErrorCode.ERR_BadUsingNamespace, f_10345_11033_11061(f_10345_11033_11052(usingDirective)), imported);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 10862, 12003);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 10862, 12003);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 11203, 11248);

                                            var
                                            importedType = (NamedTypeSymbol)imported
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 11282, 11972) || true) && (f_10345_11286_11321(uniqueUsings, importedType))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 11282, 11972);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 11395, 11485);

                                                f_10345_11395_11484(diagnostics, ErrorCode.WRN_DuplicateUsing, f_10345_11441_11469(f_10345_11441_11460(usingDirective)), importedType);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 11282, 11972);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 11282, 11972);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 11631, 11749);

                                                f_10345_11631_11748(declarationBinder, diagnostics, importedType, f_10345_11704_11723(usingDirective), hasBaseReceiver: false);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 11789, 11820);

                                                f_10345_11789_11819(
                                                                                    uniqueUsings, importedType);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 11858, 11937);

                                                f_10345_11858_11936(usings, f_10345_11869_11935(importedType, usingDirective));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 11282, 11972);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 10862, 12003);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 10763, 12656);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 10763, 12656);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 12061, 12656) || true) && (f_10345_12065_12078(imported) != SymbolKind.ErrorType)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 12061, 12656);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 12366, 12629);

                                            f_10345_12366_12628(                            // Do not report additional error if the symbol itself is erroneous.

                                                                        // error: '<symbol>' is a '<symbol kind>' but is used as 'type or namespace'
                                                                        diagnostics, ErrorCode.ERR_BadSKknown, f_10345_12408_12436(f_10345_12408_12427(usingDirective)), f_10345_12471_12490(usingDirective), f_10345_12525_12547(imported), f_10345_12582_12627(MessageID.IDS_SK_TYPE_OR_NAMESPACE));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 12061, 12656);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 10763, 12656);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 9850, 12656);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 6370, 12679);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 6217, 12698);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10345, 1, 6482);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10345, 1, 6482);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 12718, 12738);

                    f_10345_12718_12737(
                                    uniqueUsings);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 4910, 12753);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 12769, 12877) || true) && (f_10345_12773_12809(diagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 12769, 12877);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 12843, 12862);

                    diagnostics = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 12769, 12877);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 12893, 13027);

                return f_10345_12900_13026(compilation, f_10345_12925_12968(usingAliases), f_10345_12970_12997(usings), externAliases, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10345, 2842, 13038);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10345_3211_3235(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 3211, 3235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>
                f_10345_3530_3552(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.Usings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 3530, 3552);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax>
                f_10345_3595_3618(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.Externs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 3595, 3618);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10345_3657_3681(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 3657, 3681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>
                f_10345_3984_4004(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Usings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 3984, 4004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax>
                f_10345_4047_4068(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Externs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 4047, 4068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10345_4542_4561()
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 4542, 4561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10345_4596_4614(Microsoft.CodeAnalysis.CSharp.InContainerBinder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 4596, 4614);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                f_10345_4651_4713(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax>
                syntaxList, Microsoft.CodeAnalysis.CSharp.InContainerBinder
                binder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = BuildExternAliases(syntaxList, binder, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 4651, 4713);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                f_10345_4741_4801()
                {
                    var return_v = ArrayBuilder<NamespaceOrTypeAndUsingDirective>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 4741, 4801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10345_5219_5247(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 5219, 5247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParseOptions
                f_10345_5219_5255(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 5219, 5255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceCodeKind
                f_10345_5219_5260(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 5219, 5260);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10345_5372_5400(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 5372, 5400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory
                f_10345_5343_5401(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetBinderFactory(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 5343, 5401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10345_5343_5452(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                unit, bool
                inUsing)
                {
                    var return_v = this_param.GetImportsBinder(unit, inUsing: inUsing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 5343, 5452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Imports
                f_10345_5635_5954(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                usingAliases, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                usings, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                externs, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Imports(compilation, usingAliases, usings, externs, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 5635, 5954);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10345_6014_6030(Microsoft.CodeAnalysis.CSharp.InContainerBinder
                this_param)
                {
                    var return_v = this_param.Container;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 6014, 6030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10345_6032_6043(Microsoft.CodeAnalysis.CSharp.InContainerBinder
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 6032, 6043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.InContainerBinder
                f_10345_5992_6053(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                container, Microsoft.CodeAnalysis.CSharp.Binder?
                next, Microsoft.CodeAnalysis.CSharp.Imports
                imports)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.InContainerBinder(container, next, imports);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 5992, 6053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                f_10345_6112_6196()
                {
                    var return_v = SpecializedSymbolCollections.GetPooledSymbolHashSetInstance<NamespaceOrTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 6112, 6196);
                    return return_v;
                }


                int
                f_10345_6305_6345(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                syntax)
                {
                    this_param.RecordImport(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 6305, 6345);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax?
                f_10345_6374_6394(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Alias;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 6374, 6394);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                f_10345_6477_6497(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Alias;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 6477, 6497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10345_6477_6502(Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 6477, 6502);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10345_6477_6513(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 6477, 6513);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                f_10345_6560_6580(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Alias;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 6560, 6580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10345_6560_6585(Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 6560, 6585);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10345_6560_6594(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 6560, 6594);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10345_6740_6796(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 6740, 6796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10345_6856_6884(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.StaticKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 6856, 6884);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10345_6966_7018(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 6966, 7018);
                    return return_v;
                }


                int
                f_10345_7074_7180(string
                name, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    SourceMemberContainerTypeSymbol.ReportTypeNamedRecord(name, compilation, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 7074, 7180);
                    return 0;
                }


                bool
                f_10345_7313_7358(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>.Builder
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 7313, 7358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10345_7499_7518(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 7499, 7518);
                    return return_v;
                }


                bool
                f_10345_7498_7528_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 7498, 7528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10345_7690_7766(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 7690, 7766);
                    return return_v;
                }


                string
                f_10345_8140_8162(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 8140, 8162);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10345_8405_8428(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 8405, 8428);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10345_8359_8450(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 8359, 8450);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                f_10345_8057_8070_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 8057, 8070);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>.Builder
                f_10345_8698_8765()
                {
                    var return_v = ImmutableDictionary.CreateBuilder<string, AliasAndUsingDirective>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 8698, 8765);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10345_9131_9150(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 9131, 9150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                f_10345_9152_9172(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Alias;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 9152, 9172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                f_10345_9101_9173(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                name, Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                alias)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol(binder, name, alias);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 9101, 9173);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective
                f_10345_9074_9190(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                alias, Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                usingDirective)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective(alias, usingDirective);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 9074, 9190);
                    return return_v;
                }


                int
                f_10345_9036_9191(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>.Builder
                this_param, string
                key, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 9036, 9191);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10345_9321_9340(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 9321, 9340);
                    return return_v;
                }


                bool
                f_10345_9321_9350(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.IsMissing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 9321, 9350);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10345_9592_9662(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 9592, 9662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10345_9748_9767(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 9748, 9767);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10345_9704_9801(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.BindNamespaceOrTypeSymbol((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 9704, 9801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10345_9854_9867(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 9854, 9867);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10345_9953_9981(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.StaticKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 9953, 9981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10345_10115_10134(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 10115, 10134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10345_10115_10143(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 10115, 10143);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10345_10071_10154(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 10071, 10154);
                    return return_v;
                }


                bool
                f_10345_10225_10256(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 10225, 10256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10345_10368_10387(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 10368, 10387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10345_10368_10396(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 10368, 10396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10345_10322_10407(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 10322, 10407);
                    return return_v;
                }


                bool
                f_10345_10538_10564(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 10538, 10564);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective
                f_10345_10610_10672(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                namespaceOrType, Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                usingDirective)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective(namespaceOrType, usingDirective);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 10610, 10672);
                    return return_v;
                }


                int
                f_10345_10599_10673(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                this_param, Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 10599, 10673);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10345_10767_10780(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 10767, 10780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10345_10866_10894(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.StaticKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 10866, 10894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10345_11033_11052(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 11033, 11052);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10345_11033_11061(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 11033, 11061);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10345_10984_11072(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 10984, 11072);
                    return return_v;
                }


                bool
                f_10345_11286_11321(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = this_param.Contains((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 11286, 11321);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10345_11441_11460(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 11441, 11460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10345_11441_11469(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 11441, 11469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10345_11395_11484(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 11395, 11484);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10345_11704_11723(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 11704, 11723);
                    return return_v;
                }


                int
                f_10345_11631_11748(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                node, bool
                hasBaseReceiver)
                {
                    this_param.ReportDiagnosticsIfObsolete(diagnostics, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, (Microsoft.CodeAnalysis.SyntaxNode)node, hasBaseReceiver: hasBaseReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 11631, 11748);
                    return 0;
                }


                bool
                f_10345_11789_11819(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 11789, 11819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective
                f_10345_11869_11935(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namespaceOrType, Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                usingDirective)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)namespaceOrType, usingDirective);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 11869, 11935);
                    return return_v;
                }


                int
                f_10345_11858_11936(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                this_param, Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 11858, 11936);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10345_12065_12078(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 12065, 12078);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10345_12408_12427(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 12408, 12427);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10345_12408_12436(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 12408, 12436);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10345_12471_12490(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 12471, 12490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10345_12525_12547(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                symbol)
                {
                    var return_v = symbol.GetKindText();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 12525, 12547);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10345_12582_12627(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 12582, 12627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10345_12366_12628(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 12366, 12628);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>
                f_10345_6248_6263_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 6248, 6263);
                    return return_v;
                }


                int
                f_10345_12718_12737(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 12718, 12737);
                    return 0;
                }


                bool
                f_10345_12773_12809(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.IsEmptyWithoutResolution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 12773, 12809);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                f_10345_12925_12968(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>.Builder?
                items)
                {
                    var return_v = items.ToImmutableDictionaryOrEmpty<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 12925, 12968);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                f_10345_12970_12997(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 12970, 12997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Imports
                f_10345_12900_13026(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                usingAliases, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                usings, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                externs, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Imports(compilation, usingAliases, usings, externs, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 12900, 13026);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 2842, 13038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 2842, 13038);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Imports FromGlobalUsings(CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10345, 13050, 15892);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 13144, 13184);

                var
                usings = f_10345_13157_13183(f_10345_13157_13176(compilation))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 13200, 13326) || true) && (usings.Length == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10345, 13204, 13264) && f_10345_13226_13256(compilation) == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 13200, 13326);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 13298, 13311);

                    return Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 13200, 13326);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 13342, 13380);

                var
                diagnostics = f_10345_13360_13379()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 13394, 13502);

                var
                usingsBinder = f_10345_13413_13501(f_10345_13435_13462(compilation), f_10345_13464_13500(compilation))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 13516, 13595);

                var
                boundUsings = f_10345_13534_13594()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 13609, 13679);

                var
                uniqueUsings = f_10345_13628_13678()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 13695, 14579);
                    foreach (string @using in f_10345_13721_13727_I(usings))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 13695, 14579);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 13761, 13868) || true) && (!f_10345_13766_13798(@using))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 13761, 13868);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 13840, 13849);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 13761, 13868);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 13888, 13929);

                        string[]
                        identifiers = f_10345_13911_13928(@using, '.')
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 13947, 14019);

                        NameSyntax
                        qualifiedName = f_10345_13974_14018(identifiers[0])
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 14048, 14053);

                            for (int
            j = 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 14039, 14261) || true) && (j < f_10345_14059_14077(identifiers))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 14079, 14082)
            , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 14039, 14261))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 14039, 14261);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 14124, 14242);

                                qualifiedName = f_10345_14140_14241(left: qualifiedName, right: f_10345_14196_14240(identifiers[j]));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10345, 1, 223);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10345, 1, 223);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 14281, 14385);

                        var
                        imported = f_10345_14296_14362(usingsBinder, qualifiedName, diagnostics).NamespaceOrTypeSymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 14403, 14564) || true) && (f_10345_14407_14433(uniqueUsings, imported))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 14403, 14564);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 14475, 14545);

                            f_10345_14475_14544(boundUsings, f_10345_14491_14543(imported, null));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 14403, 14564);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 13695, 14579);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10345, 1, 885);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10345, 1, 885);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 14595, 14703) || true) && (f_10345_14599_14635(diagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 14595, 14703);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 14669, 14688);

                    diagnostics = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 14595, 14703);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 14719, 14797);

                var
                previousSubmissionImports = f_10345_14751_14796_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10345_14751_14781(compilation), 10345, 14751, 14796)?.GlobalImports)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 14811, 15498) || true) && (previousSubmissionImports != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 14811, 15498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 14940, 15001);

                    f_10345_14940_15000(f_10345_14953_14999(previousSubmissionImports.UsingAliases));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 15019, 15081);

                    f_10345_15019_15080(previousSubmissionImports.ExternAliases.IsEmpty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 15101, 15195);

                    var
                    expandedImports = f_10345_15123_15194(previousSubmissionImports, compilation)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 15215, 15483);
                        foreach (var previousUsing in f_10345_15245_15267_I(expandedImports.Usings))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 15215, 15483);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 15309, 15464) || true) && (f_10345_15313_15360(uniqueUsings, previousUsing.NamespaceOrType))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 15309, 15464);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 15410, 15441);

                                f_10345_15410_15440(boundUsings, previousUsing);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 15309, 15464);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 15215, 15483);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10345, 1, 269);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10345, 1, 269);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 14811, 15498);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 15514, 15534);

                f_10345_15514_15533(
                            uniqueUsings);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 15550, 15675) || true) && (f_10345_15554_15571(boundUsings) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 15550, 15675);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 15610, 15629);

                    f_10345_15610_15628(boundUsings);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 15647, 15660);

                    return Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 15550, 15675);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 15691, 15881);

                return f_10345_15698_15880(compilation, ImmutableDictionary<string, AliasAndUsingDirective>.Empty, f_10345_15782_15814(boundUsings), ImmutableArray<AliasAndExternAliasDirective>.Empty, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10345, 13050, 15892);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10345_13157_13176(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 13157, 13176);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10345_13157_13183(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.Usings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 13157, 13183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation?
                f_10345_13226_13256(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.PreviousSubmission;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 13226, 13256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10345_13360_13379()
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 13360, 13379);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10345_13435_13462(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 13435, 13462);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BuckStopsHereBinder
                f_10345_13464_13500(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BuckStopsHereBinder(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 13464, 13500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.InContainerBinder
                f_10345_13413_13501(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                container, Microsoft.CodeAnalysis.CSharp.BuckStopsHereBinder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.InContainerBinder((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)container, (Microsoft.CodeAnalysis.CSharp.Binder)next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 13413, 13501);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                f_10345_13534_13594()
                {
                    var return_v = ArrayBuilder<NamespaceOrTypeAndUsingDirective>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 13534, 13594);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                f_10345_13628_13678()
                {
                    var return_v = PooledHashSet<NamespaceOrTypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 13628, 13678);
                    return return_v;
                }


                bool
                f_10345_13766_13798(string
                name)
                {
                    var return_v = name.IsValidClrNamespaceName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 13766, 13798);
                    return return_v;
                }


                string[]
                f_10345_13911_13928(string
                this_param, char
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 13911, 13928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10345_13974_14018(string
                name)
                {
                    var return_v = SyntaxFactory.IdentifierName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 13974, 14018);
                    return return_v;
                }


                int
                f_10345_14059_14077(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 14059, 14077);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10345_14196_14240(string
                name)
                {
                    var return_v = SyntaxFactory.IdentifierName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 14196, 14240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                f_10345_14140_14241(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                left, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                right)
                {
                    var return_v = SyntaxFactory.QualifiedName(left: left, right: (Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 14140, 14241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10345_14296_14362(Microsoft.CodeAnalysis.CSharp.InContainerBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindNamespaceOrTypeSymbol((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 14296, 14362);
                    return return_v;
                }


                bool
                f_10345_14407_14433(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 14407, 14433);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective
                f_10345_14491_14543(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                namespaceOrType, Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                usingDirective)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective(namespaceOrType, usingDirective);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 14491, 14543);
                    return return_v;
                }


                int
                f_10345_14475_14544(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                this_param, Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 14475, 14544);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10345_13721_13727_I(System.Collections.Immutable.ImmutableArray<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 13721, 13727);
                    return return_v;
                }


                bool
                f_10345_14599_14635(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.IsEmptyWithoutResolution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 14599, 14635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation?
                f_10345_14751_14781(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.PreviousSubmission;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 14751, 14781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Imports?
                f_10345_14751_14796_M(Microsoft.CodeAnalysis.CSharp.Imports?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 14751, 14796);
                    return return_v;
                }


                bool
                f_10345_14953_14999(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                this_param)
                {
                    var return_v = this_param.IsEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 14953, 14999);
                    return return_v;
                }


                int
                f_10345_14940_15000(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 14940, 15000);
                    return 0;
                }


                int
                f_10345_15019_15080(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 15019, 15080);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Imports
                f_10345_15123_15194(Microsoft.CodeAnalysis.CSharp.Imports
                previousSubmissionImports, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                newSubmission)
                {
                    var return_v = ExpandPreviousSubmissionImports(previousSubmissionImports, newSubmission);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 15123, 15194);
                    return return_v;
                }


                bool
                f_10345_15313_15360(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 15313, 15360);
                    return return_v;
                }


                int
                f_10345_15410_15440(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                this_param, Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 15410, 15440);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                f_10345_15245_15267_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 15245, 15267);
                    return return_v;
                }


                int
                f_10345_15514_15533(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 15514, 15533);
                    return 0;
                }


                int
                f_10345_15554_15571(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 15554, 15571);
                    return return_v;
                }


                int
                f_10345_15610_15628(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 15610, 15628);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                f_10345_15782_15814(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 15782, 15814);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Imports
                f_10345_15698_15880(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                usingAliases, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                usings, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                externs, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Imports(compilation, usingAliases, usings, externs, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 15698, 15880);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 13050, 15892);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 13050, 15892);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Imports ExpandPreviousSubmissionImports(Imports previousSubmissionImports, CSharpCompilation newSubmission)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10345, 16025, 18644);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 16173, 16273) || true) && (previousSubmissionImports == Empty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 16173, 16273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 16245, 16258);

                    return Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 16173, 16273);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 16289, 16337);

                f_10345_16289_16336(previousSubmissionImports != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 16351, 16417);

                f_10345_16351_16416(f_10345_16364_16415(previousSubmissionImports._compilation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 16431, 16472);

                f_10345_16431_16471(f_10345_16444_16470(newSubmission));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 16488, 16548);

                var
                expandedGlobalNamespace = f_10345_16518_16547(newSubmission)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 16564, 16644);

                var
                expandedAliases = ImmutableDictionary<string, AliasAndUsingDirective>.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 16658, 17292) || true) && (f_10345_16662_16709_M(!previousSubmissionImports.UsingAliases.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 16658, 17292);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 16743, 16840);

                    var
                    expandedAliasesBuilder = f_10345_16772_16839()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 16858, 17204);
                        foreach (var pair in f_10345_16879_16917_I(previousSubmissionImports.UsingAliases))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 16858, 17204);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 16959, 16979);

                            var
                            name = pair.Key
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 17001, 17028);

                            var
                            directive = pair.Value
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 17050, 17185);

                            f_10345_17050_17184(expandedAliasesBuilder, name, f_10345_17083_17183(f_10345_17110_17156(directive.Alias, newSubmission), directive.UsingDirective));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 16858, 17204);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10345, 1, 347);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10345, 1, 347);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 17222, 17277);

                    expandedAliases = f_10345_17240_17276(expandedAliasesBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 16658, 17292);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 17308, 17384);

                var
                expandedUsings = ImmutableArray<NamespaceOrTypeAndUsingDirective>.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 17398, 18404) || true) && (f_10345_17402_17443_M(!previousSubmissionImports.Usings.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 17398, 18404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 17477, 17605);

                    var
                    expandedUsingsBuilder = f_10345_17505_17604(previousSubmissionImports.Usings.Length)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 17623, 18311);
                        foreach (var previousUsing in f_10345_17653_17685_I(previousSubmissionImports.Usings))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 17623, 18311);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 17727, 17778);

                            var
                            previousTarget = previousUsing.NamespaceOrType
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 17800, 18292) || true) && (f_10345_17804_17825(previousTarget))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 17800, 18292);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 17875, 17916);

                                f_10345_17875_17915(expandedUsingsBuilder, previousUsing);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 17800, 18292);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 17800, 18292);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 18014, 18130);

                                var
                                expandedNamespace = f_10345_18038_18129(previousTarget, expandedGlobalNamespace)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 18156, 18269);

                                f_10345_18156_18268(expandedUsingsBuilder, f_10345_18182_18267(expandedNamespace, previousUsing.UsingDirective));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 17800, 18292);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 17623, 18311);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10345, 1, 689);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10345, 1, 689);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 18329, 18389);

                    expandedUsings = f_10345_18346_18388(expandedUsingsBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 17398, 18404);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 18420, 18633);

                return f_10345_18427_18632(newSubmission, expandedAliases, expandedUsings, previousSubmissionImports.ExternAliases, diagnostics: null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10345, 16025, 18644);

                int
                f_10345_16289_16336(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 16289, 16336);
                    return 0;
                }


                bool
                f_10345_16364_16415(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.IsSubmission;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 16364, 16415);
                    return return_v;
                }


                int
                f_10345_16351_16416(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 16351, 16416);
                    return 0;
                }


                bool
                f_10345_16444_16470(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.IsSubmission;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 16444, 16470);
                    return return_v;
                }


                int
                f_10345_16431_16471(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 16431, 16471);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10345_16518_16547(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 16518, 16547);
                    return return_v;
                }


                bool
                f_10345_16662_16709_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 16662, 16709);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>.Builder
                f_10345_16772_16839()
                {
                    var return_v = ImmutableDictionary.CreateBuilder<string, AliasAndUsingDirective>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 16772, 16839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                f_10345_17110_17156(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.ToNewSubmission(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 17110, 17156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective
                f_10345_17083_17183(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                alias, Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                usingDirective)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective(alias, usingDirective);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 17083, 17183);
                    return return_v;
                }


                int
                f_10345_17050_17184(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>.Builder
                this_param, string
                key, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 17050, 17184);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                f_10345_16879_16917_I(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 16879, 16917);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                f_10345_17240_17276(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 17240, 17276);
                    return return_v;
                }


                bool
                f_10345_17402_17443_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 17402, 17443);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                f_10345_17505_17604(int
                capacity)
                {
                    var return_v = ArrayBuilder<NamespaceOrTypeAndUsingDirective>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 17505, 17604);
                    return return_v;
                }


                bool
                f_10345_17804_17825(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 17804, 17825);
                    return return_v;
                }


                int
                f_10345_17875_17915(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                this_param, Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 17875, 17915);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10345_18038_18129(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                originalNamespace, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                expandedGlobalNamespace)
                {
                    var return_v = ExpandPreviousSubmissionNamespace((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol)originalNamespace, expandedGlobalNamespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 18038, 18129);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective
                f_10345_18182_18267(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                namespaceOrType, Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                usingDirective)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)namespaceOrType, usingDirective);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 18182, 18267);
                    return return_v;
                }


                int
                f_10345_18156_18268(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                this_param, Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 18156, 18268);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                f_10345_17653_17685_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 17653, 17685);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                f_10345_18346_18388(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 18346, 18388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Imports
                f_10345_18427_18632(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                usingAliases, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                usings, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                externs, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Imports(compilation, usingAliases, usings, externs, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 18427, 18632);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 16025, 18644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 16025, 18644);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static NamespaceSymbol ExpandPreviousSubmissionNamespace(NamespaceSymbol originalNamespace, NamespaceSymbol expandedGlobalNamespace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10345, 18656, 20010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 18895, 18982);

                f_10345_18895_18981(f_10345_18908_18944_M(!originalNamespace.IsGlobalNamespace), "Global using to global namespace");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 19046, 19131);

                f_10345_19046_19130(f_10345_19059_19100(expandedGlobalNamespace), "Global namespace required");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 19147, 19198);

                var
                nameParts = f_10345_19163_19197()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 19212, 19241);

                var
                curr = originalNamespace
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 19255, 19409) || true) && (f_10345_19262_19285_M(!curr.IsGlobalNamespace))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 19255, 19409);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 19319, 19344);

                        f_10345_19319_19343(nameParts, f_10345_19333_19342(curr));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 19362, 19394);

                        curr = f_10345_19369_19393(curr);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 19255, 19409);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10345, 19255, 19409);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10345, 19255, 19409);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 19425, 19473);

                var
                expandedNamespace = expandedGlobalNamespace
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 19496, 19519);
                    for (int
        i = f_10345_19500_19515(nameParts) - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 19487, 19927) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 19529, 19532)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 19487, 19927))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 19487, 19927);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 19814, 19912);

                        expandedNamespace = f_10345_19834_19911(f_10345_19834_19876(expandedNamespace, f_10345_19863_19875(nameParts, i)).OfType<NamespaceSymbol>());
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10345, 1, 441);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10345, 1, 441);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 19941, 19958);

                f_10345_19941_19957(nameParts);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 19974, 19999);

                return expandedNamespace;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10345, 18656, 20010);

                bool
                f_10345_18908_18944_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 18908, 18944);
                    return return_v;
                }


                int
                f_10345_18895_18981(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 18895, 18981);
                    return 0;
                }


                bool
                f_10345_19059_19100(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.IsGlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 19059, 19100);
                    return return_v;
                }


                int
                f_10345_19046_19130(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 19046, 19130);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_10345_19163_19197()
                {
                    var return_v = ArrayBuilder<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 19163, 19197);
                    return return_v;
                }


                bool
                f_10345_19262_19285_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 19262, 19285);
                    return return_v;
                }


                string
                f_10345_19333_19342(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 19333, 19342);
                    return return_v;
                }


                int
                f_10345_19319_19343(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 19319, 19343);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10345_19369_19393(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 19369, 19393);
                    return return_v;
                }


                int
                f_10345_19500_19515(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 19500, 19515);
                    return return_v;
                }


                string
                f_10345_19863_19875(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 19863, 19875);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10345_19834_19876(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 19834, 19876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10345_19834_19911(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 19834, 19911);
                    return return_v;
                }


                int
                f_10345_19941_19957(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 19941, 19957);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 18656, 20010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 18656, 20010);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Imports FromCustomDebugInfo(
                    CSharpCompilation compilation,
                    ImmutableDictionary<string, AliasAndUsingDirective> usingAliases,
                    ImmutableArray<NamespaceOrTypeAndUsingDirective> usings,
                    ImmutableArray<AliasAndExternAliasDirective> externs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10345, 20022, 20442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 20349, 20431);

                return f_10345_20356_20430(compilation, usingAliases, usings, externs, diagnostics: null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10345, 20022, 20442);

                Microsoft.CodeAnalysis.CSharp.Imports
                f_10345_20356_20430(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                usingAliases, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                usings, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                externs, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Imports(compilation, usingAliases, usings, externs, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 20356, 20430);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 20022, 20442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 20022, 20442);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Imports Concat(Imports otherImports)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10345, 20545, 21379);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 20615, 20650);

                f_10345_20615_20649(otherImports != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 20666, 20752) || true) && (this == Empty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 20666, 20752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 20717, 20737);

                    return otherImports;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 20666, 20752);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 20768, 20854) || true) && (otherImports == Empty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 20768, 20854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 20827, 20839);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 20768, 20854);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 20870, 20926);

                f_10345_20870_20925(_compilation == otherImports._compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 20942, 21015);

                var
                usingAliases = f_10345_20961_21014(this.UsingAliases, otherImports.UsingAliases)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 21067, 21161);

                var
                usings = this.Usings.AddRange(otherImports.Usings).Distinct(UsingTargetComparer.Instance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 21175, 21263);

                var
                externAliases = f_10345_21195_21262(this.ExternAliases, otherImports.ExternAliases)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 21279, 21368);

                return f_10345_21286_21367(_compilation, usingAliases, usings, externAliases, diagnostics: null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10345, 20545, 21379);

                int
                f_10345_20615_20649(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 20615, 20649);
                    return 0;
                }


                int
                f_10345_20870_20925(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 20870, 20925);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                f_10345_20961_21014(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                this_param, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                items)
                {
                    var return_v = this_param.SetItems((System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>>)items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 20961, 21014);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                f_10345_21195_21262(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                externs1, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                externs2)
                {
                    var return_v = ConcatExternAliases(externs1, externs2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 21195, 21262);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Imports
                f_10345_21286_21367(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                usingAliases, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                usings, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                externs, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Imports(compilation, usingAliases, usings, externs, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 21286, 21367);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 20545, 21379);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 20545, 21379);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<AliasAndExternAliasDirective> ConcatExternAliases(ImmutableArray<AliasAndExternAliasDirective> externs1, ImmutableArray<AliasAndExternAliasDirective> externs2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10345, 21391, 22131);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 21605, 21694) || true) && (externs1.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 21605, 21694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 21663, 21679);

                    return externs2;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 21605, 21694);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 21710, 21799) || true) && (externs2.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 21710, 21799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 21768, 21784);

                    return externs1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 21710, 21799);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 21815, 21879);

                var
                replacedExternAliases = f_10345_21843_21878()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 21893, 21958);

                f_10345_21893_21957(replacedExternAliases, externs2.Select(e => e.Alias.Name));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 21972, 22120);

                return externs1.WhereAsArray((e, replacedExternAliases) => !replacedExternAliases.Contains(e.Alias.Name), replacedExternAliases).AddRange(externs2);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10345, 21391, 22131);

                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                f_10345_21843_21878()
                {
                    var return_v = PooledHashSet<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 21843, 21878);
                    return return_v;
                }


                bool
                f_10345_21893_21957(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                set, System.Collections.Generic.IEnumerable<string>
                values)
                {
                    var return_v = set.AddAll<string>(values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 21893, 21957);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 21391, 22131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 21391, 22131);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<AliasAndExternAliasDirective> BuildExternAliases(
                    SyntaxList<ExternAliasDirectiveSyntax> syntaxList,
                    InContainerBinder binder,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10345, 22143, 23859);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 22390, 22441);

                CSharpCompilation
                compilation = f_10345_22422_22440(binder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 22457, 22528);

                var
                builder = f_10345_22471_22527()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 22544, 23796);
                    foreach (ExternAliasDirectiveSyntax aliasSyntax in f_10345_22595_22605_I(syntaxList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 22544, 23796);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 22639, 22677);

                        f_10345_22639_22676(compilation, aliasSyntax);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 22772, 22967) || true) && (f_10345_22776_22800(compilation))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 22772, 22967);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 22842, 22917);

                            f_10345_22842_22916(diagnostics, ErrorCode.ERR_ExternAliasNotAllowed, f_10345_22895_22915(aliasSyntax));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 22939, 22948);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 22772, 22967);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 23052, 23425);
                            foreach (var existingAlias in f_10345_23082_23089_I(builder))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 23052, 23425);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 23131, 23406) || true) && (f_10345_23135_23159(existingAlias.Alias) == aliasSyntax.Identifier.ValueText)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 23131, 23406);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 23245, 23351);

                                    f_10345_23245_23350(diagnostics, ErrorCode.ERR_DuplicateAlias, f_10345_23291_23320(existingAlias.Alias)[0], f_10345_23325_23349(existingAlias.Alias));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10345, 23377, 23383);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 23131, 23406);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 23052, 23425);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10345, 1, 374);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10345, 1, 374);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 23445, 23664) || true) && (aliasSyntax.Identifier.ContextualKind() == SyntaxKind.GlobalKeyword)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 23445, 23664);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 23558, 23645);

                            f_10345_23558_23644(diagnostics, ErrorCode.ERR_GlobalExternAlias, aliasSyntax.Identifier.GetLocation());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 23445, 23664);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 23684, 23781);

                        f_10345_23684_23780(
                                        builder, f_10345_23696_23779(f_10345_23729_23765(binder, aliasSyntax), aliasSyntax));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 22544, 23796);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10345, 1, 1253);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10345, 1, 1253);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 23812, 23848);

                return f_10345_23819_23847(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10345, 22143, 23859);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10345_22422_22440(Microsoft.CodeAnalysis.CSharp.InContainerBinder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 22422, 22440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                f_10345_22471_22527()
                {
                    var return_v = ArrayBuilder<AliasAndExternAliasDirective>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 22471, 22527);
                    return return_v;
                }


                int
                f_10345_22639_22676(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax
                syntax)
                {
                    this_param.RecordImport(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 22639, 22676);
                    return 0;
                }


                bool
                f_10345_22776_22800(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.IsSubmission;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 22776, 22800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10345_22895_22915(Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 22895, 22915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10345_22842_22916(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 22842, 22916);
                    return return_v;
                }


                string
                f_10345_23135_23159(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 23135, 23159);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10345_23291_23320(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 23291, 23320);
                    return return_v;
                }


                string
                f_10345_23325_23349(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 23325, 23349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10345_23245_23350(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 23245, 23350);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                f_10345_23082_23089_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 23082, 23089);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10345_23558_23644(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 23558, 23644);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                f_10345_23729_23765(Microsoft.CodeAnalysis.CSharp.InContainerBinder
                binder, Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol((Microsoft.CodeAnalysis.CSharp.Binder)binder, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 23729, 23765);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective
                f_10345_23696_23779(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                alias, Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax
                externAliasDirective)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective(alias, externAliasDirective);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 23696, 23779);
                    return return_v;
                }


                int
                f_10345_23684_23780(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                this_param, Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 23684, 23780);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax>
                f_10345_22595_22605_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 22595, 22605);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                f_10345_23819_23847(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 23819, 23847);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 22143, 23859);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 22143, 23859);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void MarkImportDirective(CSharpSyntaxNode directive, bool callerIsSemanticModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10345, 23871, 24063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 23984, 24052);

                f_10345_23984_24051(_compilation, directive, callerIsSemanticModel);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10345, 23871, 24063);

                int
                f_10345_23984_24051(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                directive, bool
                callerIsSemanticModel)
                {
                    MarkImportDirective(compilation, directive, callerIsSemanticModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 23984, 24051);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 23871, 24063);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 23871, 24063);
            }
        }

        private static void MarkImportDirective(CSharpCompilation compilation, CSharpSyntaxNode directive, bool callerIsSemanticModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10345, 24075, 24495);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 24226, 24260);

                f_10345_24226_24259(compilation != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 24339, 24484) || true) && (directive != null && (DynAbs.Tracing.TraceSender.Expression_True(10345, 24343, 24386) && !callerIsSemanticModel))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 24339, 24484);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 24420, 24469);

                    f_10345_24420_24468(compilation, directive);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 24339, 24484);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10345, 24075, 24495);

                int
                f_10345_24226_24259(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 24226, 24259);
                    return 0;
                }


                int
                f_10345_24420_24468(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    this_param.MarkImportDirectiveAsUsed((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 24420, 24468);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 24075, 24495);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 24075, 24495);
            }
        }

        internal void Complete(CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10345, 24507, 26254);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 24591, 26243) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 24591, 26243);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 24636, 24685);

                        cancellationToken.ThrowIfCancellationRequested();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 24703, 24750);

                        var
                        incompletePart = _state.NextIncompletePart
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 24768, 26149);

                        switch (incompletePart)
                        {

                            case CompletionPart.StartValidatingImports:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 24768, 26149);
                                {

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 24932, 25204) || true) && (_state.NotePartComplete(CompletionPart.StartValidatingImports))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 24932, 25204);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 25064, 25075);

                                        f_10345_25064_25074(this);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 25109, 25173);

                                        _state.NotePartComplete(CompletionPart.FinishValidatingImports);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 24932, 25204);
                                    }
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10345, 25257, 25263);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 24768, 26149);

                            case CompletionPart.FinishValidatingImports:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 24768, 26149);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 25570, 25642);

                                f_10345_25570_25641(_state.HasComplete(CompletionPart.StartValidatingImports));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 25668, 25751);

                                _state.SpinWaitComplete(CompletionPart.FinishValidatingImports, cancellationToken);
                                DynAbs.Tracing.TraceSender.TraceBreak(10345, 25777, 25783);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 24768, 26149);

                            case CompletionPart.None:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 24768, 26149);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 25858, 25865);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 24768, 26149);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 24768, 26149);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 26025, 26098);

                                _state.NotePartComplete(CompletionPart.All & ~CompletionPart.ImportsAll);
                                DynAbs.Tracing.TraceSender.TraceBreak(10345, 26124, 26130);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 24768, 26149);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 26169, 26228);

                        _state.SpinWaitComplete(incompletePart, cancellationToken);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 24591, 26243);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10345, 24591, 26243);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10345, 24591, 26243);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10345, 24507, 26254);

                int
                f_10345_25064_25074(Microsoft.CodeAnalysis.CSharp.Imports
                this_param)
                {
                    this_param.Validate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 25064, 25074);
                    return 0;
                }


                int
                f_10345_25570_25641(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 25570, 25641);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 24507, 26254);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 24507, 26254);
            }
        }

        private void Validate()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10345, 26266, 28173);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 26314, 26387) || true) && (this == Empty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 26314, 26387);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 26365, 26372);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 26314, 26387);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 26403, 26475);

                DiagnosticBag
                semanticDiagnostics = f_10345_26439_26474(_compilation)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 26600, 26824);
                    foreach (var (_, alias) in f_10345_26627_26639_I(UsingAliases))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 26600, 26824);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 26673, 26726);

                        f_10345_26673_26725(alias.Alias, basesBeingResolved: null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 26744, 26809);

                        f_10345_26744_26808(semanticDiagnostics, f_10345_26773_26807(alias.Alias));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 26600, 26824);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10345, 1, 225);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10345, 1, 225);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 26840, 26978);
                    foreach (var (_, alias) in f_10345_26867_26879_I(UsingAliases))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 26840, 26978);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 26913, 26963);

                        f_10345_26913_26962(alias.Alias, semanticDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 26840, 26978);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10345, 1, 139);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10345, 1, 139);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 26994, 27050);

                var
                corLibrary = f_10345_27011_27049(f_10345_27011_27038(_compilation))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 27064, 27114);

                var
                conversions = f_10345_27082_27113(corLibrary)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 27128, 27705);
                    foreach (var @using in f_10345_27151_27157_I(Usings))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 27128, 27705);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 27264, 27690) || true) && (f_10345_27268_27297(@using.NamespaceOrType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 27264, 27690);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 27339, 27391);

                            var
                            typeSymbol = (TypeSymbol)@using.NamespaceOrType
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 27444, 27560);

                            var
                            location = ((DynAbs.Tracing.TraceSender.Conditional_F1(10345, 27460, 27489) || ((@using.UsingDirective != null && DynAbs.Tracing.TraceSender.Conditional_F2(10345, 27492, 27527)) || DynAbs.Tracing.TraceSender.Conditional_F3(10345, 27530, 27534))) ? f_10345_27492_27527(f_10345_27492_27518(@using.UsingDirective)) : null) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Location?>(10345, 27459, 27559) ?? NoLocation.Singleton)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 27582, 27671);

                            f_10345_27582_27670(typeSymbol, _compilation, conversions, location, semanticDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 27264, 27690);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 27128, 27705);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10345, 1, 578);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10345, 1, 578);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 27773, 27973);
                    foreach (var alias in f_10345_27795_27808_I(ExternAliases))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 27773, 27973);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 27842, 27875);

                        f_10345_27842_27874(alias.Alias, null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 27893, 27958);

                        f_10345_27893_27957(semanticDiagnostics, f_10345_27922_27956(alias.Alias));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 27773, 27973);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10345, 1, 201);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10345, 1, 201);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 27989, 28162) || true) && (_diagnostics != null && (DynAbs.Tracing.TraceSender.Expression_True(10345, 27993, 28055) && f_10345_28017_28055_M(!_diagnostics.IsEmptyWithoutResolution)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 27989, 28162);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 28089, 28147);

                    f_10345_28089_28146(semanticDiagnostics, f_10345_28118_28145(_diagnostics));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 27989, 28162);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10345, 26266, 28173);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10345_26439_26474(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.DeclarationDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 26439, 26474);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10345_26673_26725(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = this_param.GetAliasTarget(basesBeingResolved: basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 26673, 26725);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10345_26773_26807(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param)
                {
                    var return_v = this_param.AliasTargetDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 26773, 26807);
                    return return_v;
                }


                int
                f_10345_26744_26808(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 26744, 26808);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                f_10345_26627_26639_I(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 26627, 26639);
                    return return_v;
                }


                int
                f_10345_26913_26962(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckConstraints(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 26913, 26962);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                f_10345_26867_26879_I(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 26867, 26879);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_10345_27011_27038(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 27011, 27038);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10345_27011_27049(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.CorLibrary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 27011, 27049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TypeConversions
                f_10345_27082_27113(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                corLibrary)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.TypeConversions(corLibrary);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 27082, 27113);
                    return return_v;
                }


                bool
                f_10345_27268_27297(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 27268, 27297);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10345_27492_27518(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 27492, 27518);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10345_27492_27527(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 27492, 27527);
                    return return_v;
                }


                int
                f_10345_27582_27670(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.TypeConversions
                conversions, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    type.CheckAllConstraints(compilation, (Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 27582, 27670);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                f_10345_27151_27157_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 27151, 27157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10345_27842_27874(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = this_param.GetAliasTarget(basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 27842, 27874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10345_27922_27956(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param)
                {
                    var return_v = this_param.AliasTargetDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 27922, 27956);
                    return return_v;
                }


                int
                f_10345_27893_27957(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 27893, 27957);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                f_10345_27795_27808_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 27795, 27808);
                    return return_v;
                }


                bool
                f_10345_28017_28055_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 28017, 28055);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_10345_28118_28145(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.AsEnumerable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 28118, 28145);
                    return return_v;
                }


                int
                f_10345_28089_28146(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 28089, 28146);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 26266, 28173);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 26266, 28173);
            }
        }

        internal bool IsUsingAlias(string name, bool callerIsSemanticModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10345, 28185, 28951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 28277, 28305);

                AliasAndUsingDirective
                node
                = default(AliasAndUsingDirective);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 28319, 28911) || true) && (f_10345_28323_28368(this.UsingAliases, name, out node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 28319, 28911);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 28802, 28866);

                    f_10345_28802_28865(this, node.UsingDirective, callerIsSemanticModel);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 28884, 28896);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 28319, 28911);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 28927, 28940);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10345, 28185, 28951);

                bool
                f_10345_28323_28368(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                this_param, string
                key, out Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 28323, 28368);
                    return return_v;
                }


                int
                f_10345_28802_28865(Microsoft.CodeAnalysis.CSharp.Imports
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                directive, bool
                callerIsSemanticModel)
                {
                    this_param.MarkImportDirective((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)directive, callerIsSemanticModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 28802, 28865);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 28185, 28951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 28185, 28951);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void LookupSymbol(
                    Binder originalBinder,
                    LookupResult result,
                    string name,
                    int arity,
                    ConsList<TypeSymbol> basesBeingResolved,
                    LookupOptions options,
                    bool diagnose,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10345, 28963, 29726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 29314, 29436);

                f_10345_29314_29435(this, originalBinder, result, name, arity, basesBeingResolved, options, diagnose, ref useSiteDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 29452, 29715) || true) && (f_10345_29456_29477_M(!result.IsMultiViable) && (DynAbs.Tracing.TraceSender.Expression_True(10345, 29456, 29532) && (options & LookupOptions.NamespaceAliasesOnly) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 29452, 29715);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 29566, 29700);

                    f_10345_29566_29699(this.Usings, originalBinder, result, name, arity, basesBeingResolved, options, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 29452, 29715);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10345, 28963, 29726);

                int
                f_10345_29314_29435(Microsoft.CodeAnalysis.CSharp.Imports
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LookupSymbolInAliases(originalBinder, result, name, arity, basesBeingResolved, options, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 29314, 29435);
                    return 0;
                }


                bool
                f_10345_29456_29477_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 29456, 29477);
                    return return_v;
                }


                int
                f_10345_29566_29699(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                usings, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    LookupSymbolInUsings(usings, originalBinder, result, name, arity, basesBeingResolved, options, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 29566, 29699);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 28963, 29726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 28963, 29726);
            }
        }

        internal void LookupSymbolInAliases(
                    Binder originalBinder,
                    LookupResult result,
                    string name,
                    int arity,
                    ConsList<TypeSymbol> basesBeingResolved,
                    LookupOptions options,
                    bool diagnose,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10345, 29738, 31666);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 30098, 30164);

                bool
                callerIsSemanticModel = f_10345_30127_30163(originalBinder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 30180, 30209);

                AliasAndUsingDirective
                alias
                = default(AliasAndUsingDirective);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 30223, 30867) || true) && (f_10345_30227_30273(this.UsingAliases, name, out alias))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 30223, 30867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 30497, 30626);

                    var
                    res = f_10345_30507_30625(originalBinder, alias.Alias, arity, options, null, diagnose, ref useSiteDiagnostics, basesBeingResolved)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 30644, 30809) || true) && (res.Kind == LookupResultKind.Viable)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 30644, 30809);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 30725, 30790);

                        f_10345_30725_30789(this, alias.UsingDirective, callerIsSemanticModel);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 30644, 30809);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 30829, 30852);

                    f_10345_30829_30851(
                                    result, res);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 30223, 30867);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 30883, 31655);
                    foreach (var a in f_10345_30901_30919_I(this.ExternAliases))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 30883, 31655);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 30953, 31640) || true) && (f_10345_30957_30969(a.Alias) == name)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 30953, 31640);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 31248, 31373);

                            var
                            res = f_10345_31258_31372(originalBinder, a.Alias, arity, options, null, diagnose, ref useSiteDiagnostics, basesBeingResolved)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 31395, 31574) || true) && (res.Kind == LookupResultKind.Viable)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 31395, 31574);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 31484, 31551);

                                f_10345_31484_31550(this, a.ExternAliasDirective, callerIsSemanticModel);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 31395, 31574);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 31598, 31621);

                            f_10345_31598_31620(
                                                result, res);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 30953, 31640);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 30883, 31655);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10345, 1, 773);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10345, 1, 773);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10345, 29738, 31666);

                bool
                f_10345_30127_30163(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.IsSemanticModelBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 30127, 30163);
                    return return_v;
                }


                bool
                f_10345_30227_30273(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                this_param, string
                key, out Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 30227, 30273);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10345_30507_30625(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                symbol, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.CheckViability((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, arity, options, accessThroughType, diagnose, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 30507, 30625);
                    return return_v;
                }


                int
                f_10345_30725_30789(Microsoft.CodeAnalysis.CSharp.Imports
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                directive, bool
                callerIsSemanticModel)
                {
                    this_param.MarkImportDirective((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)directive, callerIsSemanticModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 30725, 30789);
                    return 0;
                }


                int
                f_10345_30829_30851(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                result)
                {
                    this_param.MergeEqual(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 30829, 30851);
                    return 0;
                }


                string
                f_10345_30957_30969(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 30957, 30969);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10345_31258_31372(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                symbol, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.CheckViability((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, arity, options, accessThroughType, diagnose, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 31258, 31372);
                    return return_v;
                }


                int
                f_10345_31484_31550(Microsoft.CodeAnalysis.CSharp.Imports
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax
                directive, bool
                callerIsSemanticModel)
                {
                    this_param.MarkImportDirective((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)directive, callerIsSemanticModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 31484, 31550);
                    return 0;
                }


                int
                f_10345_31598_31620(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                result)
                {
                    this_param.MergeEqual(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 31598, 31620);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                f_10345_30901_30919_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 30901, 30919);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 29738, 31666);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 29738, 31666);
            }
        }

        internal static void LookupSymbolInUsings(
                    ImmutableArray<NamespaceOrTypeAndUsingDirective> usings,
                    Binder originalBinder,
                    LookupResult result,
                    string name,
                    int arity,
                    ConsList<TypeSymbol> basesBeingResolved,
                    LookupOptions options,
                    bool diagnose,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10345, 31678, 33476);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 32114, 32230) || true) && (f_10345_32118_32174(originalBinder.Flags, BinderFlags.InScriptUsing))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 32114, 32230);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 32208, 32215);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 32114, 32230);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 32246, 32312);

                bool
                callerIsSemanticModel = f_10345_32275_32311(originalBinder)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 32328, 33465);
                    foreach (var typeOrNamespace in f_10345_32360_32366_I(usings))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 32328, 33465);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 32400, 32543);

                        ImmutableArray<Symbol>
                        candidates = f_10345_32436_32542(typeOrNamespace.NamespaceOrType, name, options, originalBinder: originalBinder)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 32561, 33450);
                            foreach (Symbol symbol in f_10345_32587_32597_I(candidates))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 32561, 33450);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 32639, 32764) || true) && (!f_10345_32644_32682(symbol))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 32639, 32764);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 32732, 32741);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 32639, 32764);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 33023, 33147);

                                var
                                res = f_10345_33033_33146(originalBinder, symbol, arity, options, null, diagnose, ref useSiteDiagnostics, basesBeingResolved)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 33169, 33384) || true) && (res.Kind == LookupResultKind.Viable)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 33169, 33384);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 33258, 33361);

                                    f_10345_33258_33360(f_10345_33278_33304(originalBinder), typeOrNamespace.UsingDirective, callerIsSemanticModel);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 33169, 33384);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 33408, 33431);

                                f_10345_33408_33430(
                                                    result, res);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 32561, 33450);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10345, 1, 890);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10345, 1, 890);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 32328, 33465);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10345, 1, 1138);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10345, 1, 1138);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10345, 31678, 33476);

                bool
                f_10345_32118_32174(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 32118, 32174);
                    return return_v;
                }


                bool
                f_10345_32275_32311(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.IsSemanticModelBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 32275, 32311);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10345_32436_32542(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                nsOrType, string
                name, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder)
                {
                    var return_v = Binder.GetCandidateMembers(nsOrType, name, options, originalBinder: originalBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 32436, 32542);
                    return return_v;
                }


                bool
                f_10345_32644_32682(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = IsValidLookupCandidateInUsings(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 32644, 32682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10345_33033_33146(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.CheckViability(symbol, arity, options, accessThroughType, diagnose, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 33033, 33146);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10345_33278_33304(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 33278, 33304);
                    return return_v;
                }


                int
                f_10345_33258_33360(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                directive, bool
                callerIsSemanticModel)
                {
                    MarkImportDirective(compilation, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)directive, callerIsSemanticModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 33258, 33360);
                    return 0;
                }


                int
                f_10345_33408_33430(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                result)
                {
                    this_param.MergeEqual(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 33408, 33430);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10345_32587_32597_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 32587, 32597);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                f_10345_32360_32366_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 32360, 32366);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 31678, 33476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 31678, 33476);
            }
        }

        private static bool IsValidLookupCandidateInUsings(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10345, 33488, 34679);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 33578, 34640);

                switch (f_10345_33586_33597(symbol))
                {

                    case SymbolKind.Namespace:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 33578, 34640);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 33754, 33767);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 33578, 34640);

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 33578, 34640);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 33927, 34077) || true) && (f_10345_33931_33947_M(!symbol.IsStatic) || (DynAbs.Tracing.TraceSender.Expression_False(10345, 33931, 33991) || f_10345_33951_33991(((MethodSymbol)symbol))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 33927, 34077);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 34041, 34054);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 33927, 34077);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10345, 34101, 34107);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 33578, 34640);

                    case SymbolKind.NamedType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 33578, 34640);
                        DynAbs.Tracing.TraceSender.TraceBreak(10345, 34360, 34366);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 33578, 34640);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 33578, 34640);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 34489, 34595) || true) && (f_10345_34493_34509_M(!symbol.IsStatic))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 34489, 34595);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 34559, 34572);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 34489, 34595);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10345, 34619, 34625);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 33578, 34640);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 34656, 34668);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10345, 33488, 34679);

                Microsoft.CodeAnalysis.SymbolKind
                f_10345_33586_33597(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 33586, 33597);
                    return return_v;
                }


                bool
                f_10345_33931_33947_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 33931, 33947);
                    return return_v;
                }


                bool
                f_10345_33951_33991(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 33951, 33991);
                    return return_v;
                }


                bool
                f_10345_34493_34509_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 34493, 34509);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 33488, 34679);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 33488, 34679);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void LookupExtensionMethodsInUsings(
                    ArrayBuilder<MethodSymbol> methods,
                    string name,
                    int arity,
                    LookupOptions options,
                    Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10345, 34691, 37397);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 34932, 34971);

                var
                binderFlags = originalBinder.Flags
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 34985, 35092) || true) && (f_10345_34989_35036(binderFlags, BinderFlags.InScriptUsing))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 34985, 35092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 35070, 35077);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 34985, 35092);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 35108, 35141);

                f_10345_35108_35140(f_10345_35121_35134(methods) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 35157, 35234);

                bool
                callerIsSemanticModel = f_10345_35186_35233(binderFlags, BinderFlags.SemanticModel)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 35487, 35534);

                bool
                seenNamespaceWithExtensionMethods = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 35548, 35597);

                bool
                seenStaticClassWithExtensionMethods = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 35613, 37218);
                    foreach (var nsOrType in f_10345_35638_35649_I(this.Usings))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 35613, 37218);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 35683, 37203);

                        switch (f_10345_35691_35720(nsOrType.NamespaceOrType))
                        {

                            case SymbolKind.Namespace:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 35683, 37203);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 35845, 35871);

                                    var
                                    count = f_10345_35857_35870(methods)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 35901, 35996);

                                    f_10345_35901_35995(((NamespaceSymbol)nsOrType.NamespaceOrType), methods, name, arity, options);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 36129, 36395) || true) && (f_10345_36133_36146(methods) != count)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 36129, 36395);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 36221, 36289);

                                        f_10345_36221_36288(this, nsOrType.UsingDirective, callerIsSemanticModel);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 36323, 36364);

                                        seenNamespaceWithExtensionMethods = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 36129, 36395);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10345, 36427, 36433);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 35683, 37203);

                            case SymbolKind.NamedType:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 35683, 37203);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 36567, 36593);

                                    var
                                    count = f_10345_36579_36592(methods)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 36623, 36718);

                                    f_10345_36623_36717(((NamedTypeSymbol)nsOrType.NamespaceOrType), methods, name, arity, options);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 36851, 37119) || true) && (f_10345_36855_36868(methods) != count)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 36851, 37119);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 36943, 37011);

                                        f_10345_36943_37010(this, nsOrType.UsingDirective, callerIsSemanticModel);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 37045, 37088);

                                        seenStaticClassWithExtensionMethods = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 36851, 37119);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10345, 37151, 37157);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 35683, 37203);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 35613, 37218);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10345, 1, 1606);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10345, 1, 1606);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 37234, 37386) || true) && (seenNamespaceWithExtensionMethods && (DynAbs.Tracing.TraceSender.Expression_True(10345, 37238, 37310) && seenStaticClassWithExtensionMethods))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 37234, 37386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 37344, 37371);

                    f_10345_37344_37370(methods);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 37234, 37386);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10345, 34691, 37397);

                bool
                f_10345_34989_35036(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 34989, 35036);
                    return return_v;
                }


                int
                f_10345_35121_35134(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 35121, 35134);
                    return return_v;
                }


                int
                f_10345_35108_35140(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 35108, 35140);
                    return 0;
                }


                bool
                f_10345_35186_35233(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 35186, 35233);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10345_35691_35720(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 35691, 35720);
                    return return_v;
                }


                int
                f_10345_35857_35870(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 35857, 35870);
                    return return_v;
                }


                int
                f_10345_35901_35995(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                methods, string
                nameOpt, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    this_param.GetExtensionMethods(methods, nameOpt, arity, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 35901, 35995);
                    return 0;
                }


                int
                f_10345_36133_36146(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 36133, 36146);
                    return return_v;
                }


                int
                f_10345_36221_36288(Microsoft.CodeAnalysis.CSharp.Imports
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                directive, bool
                callerIsSemanticModel)
                {
                    this_param.MarkImportDirective((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)directive, callerIsSemanticModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 36221, 36288);
                    return 0;
                }


                int
                f_10345_36579_36592(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 36579, 36592);
                    return return_v;
                }


                int
                f_10345_36623_36717(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                methods, string
                nameOpt, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    this_param.GetExtensionMethods(methods, nameOpt, arity, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 36623, 36717);
                    return 0;
                }


                int
                f_10345_36855_36868(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 36855, 36868);
                    return return_v;
                }


                int
                f_10345_36943_37010(Microsoft.CodeAnalysis.CSharp.Imports
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                directive, bool
                callerIsSemanticModel)
                {
                    this_param.MarkImportDirective((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)directive, callerIsSemanticModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 36943, 37010);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                f_10345_35638_35649_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 35638, 35649);
                    return return_v;
                }


                int
                f_10345_37344_37370(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    this_param.RemoveDuplicates();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 37344, 37370);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 34691, 37397);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 34691, 37397);
            }
        }

        internal void AddLookupSymbolsInfo(LookupSymbolsInfo result, LookupOptions options, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10345, 37719, 38288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 37850, 37913);

                f_10345_37850_37912(this, result, options, originalBinder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 38031, 38183);

                LookupOptions
                usingOptions = (options & ~(LookupOptions.NamespaceAliasesOnly | LookupOptions.NamespacesOrTypesOnly)) | LookupOptions.MustNotBeNamespace
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 38197, 38277);

                f_10345_38197_38276(this.Usings, result, usingOptions, originalBinder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10345, 37719, 38288);

                int
                f_10345_37850_37912(Microsoft.CodeAnalysis.CSharp.Imports
                this_param, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                result, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder)
                {
                    this_param.AddLookupSymbolsInfoInAliases(result, options, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 37850, 37912);
                    return 0;
                }


                int
                f_10345_38197_38276(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                usings, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                result, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder)
                {
                    AddLookupSymbolsInfoInUsings(usings, result, options, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 38197, 38276);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 37719, 38288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 37719, 38288);
            }
        }

        internal void AddLookupSymbolsInfoInAliases(LookupSymbolsInfo result, LookupOptions options, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10345, 38300, 38809);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 38440, 38612);
                    foreach (var (_, usingAlias) in f_10345_38472_38489_I(this.UsingAliases))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 38440, 38612);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 38523, 38597);

                        f_10345_38523_38596(result, usingAlias.Alias, options, originalBinder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 38440, 38612);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10345, 1, 173);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10345, 1, 173);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 38628, 38798);
                    foreach (var externAlias in f_10345_38656_38674_I(this.ExternAliases))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 38628, 38798);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 38708, 38783);

                        f_10345_38708_38782(result, externAlias.Alias, options, originalBinder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 38628, 38798);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10345, 1, 171);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10345, 1, 171);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10345, 38300, 38809);

                int
                f_10345_38523_38596(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                aliasSymbol, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder)
                {
                    AddAliasSymbolToResult(result, aliasSymbol, options, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 38523, 38596);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                f_10345_38472_38489_I(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 38472, 38489);
                    return return_v;
                }


                int
                f_10345_38708_38782(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                aliasSymbol, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder)
                {
                    AddAliasSymbolToResult(result, aliasSymbol, options, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 38708, 38782);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                f_10345_38656_38674_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 38656, 38674);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 38300, 38809);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 38300, 38809);
            }
        }

        private static void AddAliasSymbolToResult(LookupSymbolsInfo result, AliasSymbol aliasSymbol, LookupOptions options, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10345, 38821, 39305);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 38985, 39057);

                var
                targetSymbol = f_10345_39004_39056(aliasSymbol, basesBeingResolved: null)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 39071, 39294) || true) && (f_10345_39075_39194(originalBinder, targetSymbol, options, result, accessThroughType: null, aliasSymbol: aliasSymbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 39071, 39294);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 39228, 39279);

                    f_10345_39228_39278(result, aliasSymbol, f_10345_39258_39274(aliasSymbol), 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 39071, 39294);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10345, 38821, 39305);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10345_39004_39056(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = this_param.GetAliasTarget(basesBeingResolved: basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 39004, 39056);
                    return return_v;
                }


                bool
                f_10345_39075_39194(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                info, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType, Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                aliasSymbol)
                {
                    var return_v = this_param.CanAddLookupSymbolInfo((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, options, info, accessThroughType: accessThroughType, aliasSymbol: aliasSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 39075, 39194);
                    return return_v;
                }


                string
                f_10345_39258_39274(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 39258, 39274);
                    return return_v;
                }


                int
                f_10345_39228_39278(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                symbol, string
                name, int
                arity)
                {
                    this_param.AddSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 39228, 39278);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 38821, 39305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 38821, 39305);
            }
        }

        private static void AddLookupSymbolsInfoInUsings(
                    ImmutableArray<NamespaceOrTypeAndUsingDirective> usings, LookupSymbolsInfo result, LookupOptions options, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10345, 39317, 40252);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 39533, 39649) || true) && (f_10345_39537_39593(originalBinder.Flags, BinderFlags.InScriptUsing))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 39533, 39649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 39627, 39634);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 39533, 39649);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 39665, 39712);

                f_10345_39665_39711(!f_10345_39679_39710(options));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 39773, 40241);
                    foreach (var namespaceSymbol in f_10345_39805_39811_I(usings))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 39773, 40241);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 39845, 40226);
                            foreach (var member in f_10345_39868_39921_I(f_10345_39868_39921(namespaceSymbol.NamespaceOrType)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 39845, 40226);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 39963, 40207) || true) && (f_10345_39967_40005(member) && (DynAbs.Tracing.TraceSender.Expression_True(10345, 39967, 40077) && f_10345_40009_40077(originalBinder, member, options, result, null)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10345, 39963, 40207);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 40127, 40184);

                                    f_10345_40127_40183(result, member, f_10345_40152_40163(member), f_10345_40165_40182(member));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 39963, 40207);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 39845, 40226);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10345, 1, 382);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10345, 1, 382);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10345, 39773, 40241);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10345, 1, 469);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10345, 1, 469);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10345, 39317, 40252);

                bool
                f_10345_39537_39593(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 39537, 39593);
                    return return_v;
                }


                bool
                f_10345_39679_39710(Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = options.CanConsiderNamespaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 39679, 39710);
                    return return_v;
                }


                int
                f_10345_39665_39711(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 39665, 39711);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10345_39868_39921(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 39868, 39921);
                    return return_v;
                }


                bool
                f_10345_39967_40005(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = IsValidLookupCandidateInUsings(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 39967, 40005);
                    return return_v;
                }


                bool
                f_10345_40009_40077(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                info, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType)
                {
                    var return_v = this_param.CanAddLookupSymbolInfo(symbol, options, info, accessThroughType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 40009, 40077);
                    return return_v;
                }


                string
                f_10345_40152_40163(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 40152, 40163);
                    return return_v;
                }


                int
                f_10345_40165_40182(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 40165, 40182);
                    return return_v;
                }


                int
                f_10345_40127_40183(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, string
                name, int
                arity)
                {
                    this_param.AddSymbol(symbol, name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 40127, 40183);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10345_39868_39921_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 39868, 39921);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                f_10345_39805_39811_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 39805, 39811);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 39317, 40252);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 39317, 40252);
            }
        }
        private class UsingTargetComparer : IEqualityComparer<NamespaceOrTypeAndUsingDirective>
        {
            public static readonly IEqualityComparer<NamespaceOrTypeAndUsingDirective> Instance;

            private UsingTargetComparer()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10345, 40504, 40537);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10345, 40504, 40537);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 40504, 40537);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 40504, 40537);
                }
            }

            bool IEqualityComparer<NamespaceOrTypeAndUsingDirective>.Equals(NamespaceOrTypeAndUsingDirective x, NamespaceOrTypeAndUsingDirective y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10345, 40553, 40787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 40721, 40772);

                    return f_10345_40728_40771(x.NamespaceOrType, y.NamespaceOrType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10345, 40553, 40787);

                    bool
                    f_10345_40728_40771(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                    obj)
                    {
                        var return_v = this_param.Equals((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 40728, 40771);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 40553, 40787);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 40553, 40787);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            int IEqualityComparer<NamespaceOrTypeAndUsingDirective>.GetHashCode(NamespaceOrTypeAndUsingDirective obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10345, 40803, 40997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 40941, 40982);

                    return f_10345_40948_40981(obj.NamespaceOrType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10345, 40803, 40997);

                    int
                    f_10345_40948_40981(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 40948, 40981);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10345, 40803, 40997);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 40803, 40997);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static UsingTargetComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10345, 40264, 41008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 40451, 40487);
                Instance = f_10345_40462_40487(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10345, 40264, 41008);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 40264, 41008);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10345, 40264, 41008);

            static Microsoft.CodeAnalysis.CSharp.Imports.UsingTargetComparer
            f_10345_40462_40487()
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Imports.UsingTargetComparer();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 40462, 40487);
                return return_v;
            }

        }

        static Imports()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10345, 791, 41015);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10345, 922, 1186);
            Empty = f_10345_930_1186(null, ImmutableDictionary<string, AliasAndUsingDirective>.Empty, ImmutableArray<NamespaceOrTypeAndUsingDirective>.Empty, ImmutableArray<AliasAndExternAliasDirective>.Empty, null); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10345, 791, 41015);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10345, 791, 41015);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10345, 791, 41015);

        static Microsoft.CodeAnalysis.CSharp.Imports
        f_10345_930_1186(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
        usingAliases, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
        usings, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
        externs, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Imports(compilation, usingAliases, usings, externs, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 930, 1186);
            return return_v;
        }


        static int
        f_10345_2064_2098(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 2064, 2098);
            return 0;
        }


        bool
        f_10345_2126_2143_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 2126, 2143);
            return return_v;
        }


        int
        f_10345_2113_2144(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 2113, 2144);
            return 0;
        }


        bool
        f_10345_2172_2190_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10345, 2172, 2190);
            return return_v;
        }


        int
        f_10345_2159_2191(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10345, 2159, 2191);
            return 0;
        }

    }
}
