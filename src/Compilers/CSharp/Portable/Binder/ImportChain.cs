// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp
{
    [DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
    internal sealed class ImportChain : Cci.IImportScope
    {
        public readonly Imports Imports;

        public readonly ImportChain ParentOpt;

        private ImmutableArray<Cci.UsedNamespaceOrType> _lazyTranslatedImports;

        public ImportChain(Imports imports, ImportChain parentOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10344, 745, 939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 594, 601);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 640, 649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 828, 858);

                f_10344_828_857(imports != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 874, 892);

                Imports = imports;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 906, 928);

                ParentOpt = parentOpt;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10344, 745, 939);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10344, 745, 939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10344, 745, 939);
            }
        }

        private string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10344, 951, 1097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 1011, 1086);

                return $"{f_10344_1021_1049(Imports)} ^ {f_10344_1054_1078_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(ParentOpt, 10344, 1054, 1078)?.GetHashCode()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(10344, 1054, 1083) ?? 0)}";
                DynAbs.Tracing.TraceSender.TraceExitMethod(10344, 951, 1097);

                string
                f_10344_1021_1049(Microsoft.CodeAnalysis.CSharp.Imports
                this_param)
                {
                    var return_v = this_param.GetDebuggerDisplay();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 1021, 1049);
                    return return_v;
                }


                int?
                f_10344_1054_1078_I(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 1054, 1078);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10344, 951, 1097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10344, 951, 1097);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<Cci.UsedNamespaceOrType> Cci.IImportScope.GetUsedNamespaces()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10344, 1109, 1386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 1283, 1331);

                f_10344_1283_1330(f_10344_1296_1329_M(!_lazyTranslatedImports.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 1345, 1375);

                return _lazyTranslatedImports;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10344, 1109, 1386);

                bool
                f_10344_1296_1329_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10344, 1296, 1329);
                    return return_v;
                }


                int
                f_10344_1283_1330(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 1283, 1330);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10344, 1109, 1386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10344, 1109, 1386);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Cci.IImportScope Translate(Emit.PEModuleBuilder moduleBuilder, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10344, 1398, 1927);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 1528, 1540);
                    for (var
        scope = this
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 1519, 1888) || true) && (scope != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 1557, 1580)
        , scope = scope.ParentOpt, DynAbs.Tracing.TraceSender.TraceExitCondition(10344, 1519, 1888))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10344, 1519, 1888);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 1614, 1724) || true) && (f_10344_1618_1657_M(!scope._lazyTranslatedImports.IsDefault))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10344, 1614, 1724);
                            DynAbs.Tracing.TraceSender.TraceBreak(10344, 1699, 1705);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10344, 1614, 1724);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 1744, 1873);

                        f_10344_1744_1872(ref scope._lazyTranslatedImports, f_10344_1821_1871(scope, moduleBuilder, diagnostics));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10344, 1, 370);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10344, 1, 370);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 1904, 1916);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10344, 1398, 1927);

                bool
                f_10344_1618_1657_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10344, 1618, 1657);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                f_10344_1821_1871(Microsoft.CodeAnalysis.CSharp.ImportChain
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.TranslateImports(moduleBuilder, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 1821, 1871);
                    return return_v;
                }


                bool
                f_10344_1744_1872(ref System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 1744, 1872);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10344, 1398, 1927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10344, 1398, 1927);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<Cci.UsedNamespaceOrType> TranslateImports(Emit.PEModuleBuilder moduleBuilder, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10344, 1939, 5725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 2091, 2164);

                var
                usedNamespaces = f_10344_2112_2163()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 2289, 2372);

                ImmutableArray<AliasAndExternAliasDirective>
                externAliases = Imports.ExternAliases
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 2386, 2639) || true) && (f_10344_2390_2414_M(!externAliases.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10344, 2386, 2639);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 2448, 2624);
                        foreach (var alias in f_10344_2470_2483_I(externAliases))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10344, 2448, 2624);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 2525, 2605);

                            f_10344_2525_2604(usedNamespaces, Cci.UsedNamespaceOrType.CreateExternAlias(f_10344_2586_2602(alias.Alias)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10344, 2448, 2624);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10344, 1, 177);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10344, 1, 177);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10344, 2386, 2639);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 2655, 2728);

                ImmutableArray<NamespaceOrTypeAndUsingDirective>
                usings = Imports.Usings
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 2742, 3840) || true) && (f_10344_2746_2763_M(!usings.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10344, 2742, 3840);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 2797, 3825);
                        foreach (var nsOrType in f_10344_2822_2828_I(usings))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10344, 2797, 3825);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 2870, 2935);

                            NamespaceOrTypeSymbol
                            namespaceOrType = nsOrType.NamespaceOrType
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 2957, 3806) || true) && (f_10344_2961_2988(namespaceOrType))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10344, 2957, 3806);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 3038, 3080);

                                var
                                ns = (NamespaceSymbol)namespaceOrType
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 3106, 3176);

                                var
                                assemblyRef = f_10344_3124_3175(ns, moduleBuilder, diagnostics)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 3202, 3295);

                                f_10344_3202_3294(usedNamespaces, Cci.UsedNamespaceOrType.CreateNamespace(f_10344_3261_3279(ns), assemblyRef));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10344, 2957, 3806);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10344, 2957, 3806);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 3345, 3806) || true) && (f_10344_3349_3393_M(!f_10344_3350_3384(namespaceOrType).IsLinked))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10344, 3345, 3806);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 3580, 3693);

                                    var
                                    typeRef = f_10344_3594_3692(namespaceOrType, nsOrType.UsingDirective, moduleBuilder, diagnostics)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 3719, 3783);

                                    f_10344_3719_3782(usedNamespaces, Cci.UsedNamespaceOrType.CreateType(typeRef));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10344, 3345, 3806);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10344, 2957, 3806);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10344, 2797, 3825);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10344, 1, 1029);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10344, 1, 1029);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10344, 2742, 3840);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 3856, 3944);

                ImmutableDictionary<string, AliasAndUsingDirective>
                aliasSymbols = Imports.UsingAliases
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 3958, 5655) || true) && (f_10344_3962_3983_M(!aliasSymbols.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10344, 3958, 5655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 4017, 4084);

                    var
                    aliases = f_10344_4031_4083(f_10344_4064_4082(aliasSymbols))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 4102, 4138);

                    f_10344_4102_4137(aliases, f_10344_4119_4136(aliasSymbols));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 4156, 4193);

                    f_10344_4156_4192(aliases, f_10344_4169_4191());
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 4277, 5605);
                        foreach (var alias in f_10344_4299_4306_I(aliases))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10344, 4277, 5605);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 4348, 4397);

                            var
                            aliasAndUsingDirective = f_10344_4377_4396(aliasSymbols, alias)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 4419, 4461);

                            var
                            symbol = aliasAndUsingDirective.Alias
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 4483, 4534);

                            var
                            syntax = aliasAndUsingDirective.UsingDirective
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 4556, 4587);

                            f_10344_4556_4586(f_10344_4569_4585_M(!symbol.IsExtern));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 4611, 4656);

                            NamespaceOrTypeSymbol
                            target = f_10344_4642_4655(symbol)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 4678, 5586) || true) && (f_10344_4682_4693(target) == SymbolKind.Namespace)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10344, 4678, 5586);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 4767, 4800);

                                var
                                ns = (NamespaceSymbol)target
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 4826, 4896);

                                var
                                assemblyRef = f_10344_4844_4895(ns, moduleBuilder, diagnostics)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 4922, 5022);

                                f_10344_4922_5021(usedNamespaces, Cci.UsedNamespaceOrType.CreateNamespace(f_10344_4981_4999(ns), assemblyRef, alias));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10344, 4678, 5586);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10344, 4678, 5586);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 5072, 5586) || true) && (f_10344_5076_5111_M(!f_10344_5077_5102(target).IsLinked))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10344, 5072, 5586);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 5379, 5466);

                                    var
                                    typeRef = f_10344_5393_5465(target, syntax, moduleBuilder, diagnostics)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 5492, 5563);

                                    f_10344_5492_5562(usedNamespaces, Cci.UsedNamespaceOrType.CreateType(typeRef, alias));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10344, 5072, 5586);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10344, 4678, 5586);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10344, 4277, 5605);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10344, 1, 1329);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10344, 1, 1329);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 5625, 5640);

                    f_10344_5625_5639(
                                    aliases);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10344, 3958, 5655);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 5671, 5714);

                return f_10344_5678_5713(usedNamespaces);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10344, 1939, 5725);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.UsedNamespaceOrType>
                f_10344_2112_2163()
                {
                    var return_v = ArrayBuilder<Cci.UsedNamespaceOrType>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 2112, 2163);
                    return return_v;
                }


                bool
                f_10344_2390_2414_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10344, 2390, 2414);
                    return return_v;
                }


                string
                f_10344_2586_2602(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10344, 2586, 2602);
                    return return_v;
                }


                int
                f_10344_2525_2604(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.UsedNamespaceOrType>
                this_param, Microsoft.Cci.UsedNamespaceOrType
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 2525, 2604);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                f_10344_2470_2483_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 2470, 2483);
                    return return_v;
                }


                bool
                f_10344_2746_2763_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10344, 2746, 2763);
                    return return_v;
                }


                bool
                f_10344_2961_2988(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10344, 2961, 2988);
                    return return_v;
                }


                Microsoft.Cci.IAssemblyReference
                f_10344_3124_3175(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                @namespace, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = TryGetAssemblyScope(@namespace, moduleBuilder, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 3124, 3175);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbolAdapter
                f_10344_3261_3279(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 3261, 3279);
                    return return_v;
                }


                int
                f_10344_3202_3294(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.UsedNamespaceOrType>
                this_param, Microsoft.Cci.UsedNamespaceOrType
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 3202, 3294);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10344_3350_3384(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10344, 3350, 3384);
                    return return_v;
                }


                bool
                f_10344_3349_3393_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10344, 3349, 3393);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10344_3594_3692(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                syntaxNode, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = GetTypeReference((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, moduleBuilder, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 3594, 3692);
                    return return_v;
                }


                int
                f_10344_3719_3782(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.UsedNamespaceOrType>
                this_param, Microsoft.Cci.UsedNamespaceOrType
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 3719, 3782);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                f_10344_2822_2828_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NamespaceOrTypeAndUsingDirective>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 2822, 2828);
                    return return_v;
                }


                bool
                f_10344_3962_3983_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10344, 3962, 3983);
                    return return_v;
                }


                int
                f_10344_4064_4082(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10344, 4064, 4082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_10344_4031_4083(int
                capacity)
                {
                    var return_v = ArrayBuilder<string>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 4031, 4083);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10344_4119_4136(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10344, 4119, 4136);
                    return return_v;
                }


                int
                f_10344_4102_4137(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, System.Collections.Generic.IEnumerable<string>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 4102, 4137);
                    return 0;
                }


                System.StringComparer
                f_10344_4169_4191()
                {
                    var return_v = StringComparer.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10344, 4169, 4191);
                    return return_v;
                }


                int
                f_10344_4156_4192(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, System.StringComparer
                comparer)
                {
                    this_param.Sort((System.Collections.Generic.IComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 4156, 4192);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective
                f_10344_4377_4396(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10344, 4377, 4396);
                    return return_v;
                }


                bool
                f_10344_4569_4585_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10344, 4569, 4585);
                    return return_v;
                }


                int
                f_10344_4556_4586(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 4556, 4586);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10344_4642_4655(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10344, 4642, 4655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10344_4682_4693(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10344, 4682, 4693);
                    return return_v;
                }


                Microsoft.Cci.IAssemblyReference
                f_10344_4844_4895(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                @namespace, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = TryGetAssemblyScope(@namespace, moduleBuilder, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 4844, 4895);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbolAdapter
                f_10344_4981_4999(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 4981, 4999);
                    return return_v;
                }


                int
                f_10344_4922_5021(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.UsedNamespaceOrType>
                this_param, Microsoft.Cci.UsedNamespaceOrType
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 4922, 5021);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10344_5077_5102(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10344, 5077, 5102);
                    return return_v;
                }


                bool
                f_10344_5076_5111_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10344, 5076, 5111);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10344_5393_5465(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                syntaxNode, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = GetTypeReference((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, moduleBuilder, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 5393, 5465);
                    return return_v;
                }


                int
                f_10344_5492_5562(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.UsedNamespaceOrType>
                this_param, Microsoft.Cci.UsedNamespaceOrType
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 5492, 5562);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_10344_4299_4306_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 4299, 4306);
                    return return_v;
                }


                int
                f_10344_5625_5639(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 5625, 5639);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                f_10344_5678_5713(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.UsedNamespaceOrType>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 5678, 5713);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10344, 1939, 5725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10344, 1939, 5725);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Cci.ITypeReference GetTypeReference(TypeSymbol type, SyntaxNode syntaxNode, Emit.PEModuleBuilder moduleBuilder, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10344, 5737, 5988);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 5915, 5977);

                return f_10344_5922_5976(moduleBuilder, type, syntaxNode, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10344, 5737, 5988);

                Microsoft.Cci.ITypeReference
                f_10344_5922_5976(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 5922, 5976);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10344, 5737, 5988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10344, 5737, 5988);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Cci.IAssemblyReference TryGetAssemblyScope(NamespaceSymbol @namespace, Emit.PEModuleBuilder moduleBuilder, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10344, 6000, 7061);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 6173, 6239);

                AssemblySymbol
                containingAssembly = f_10344_6209_6238(@namespace)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 6253, 7022) || true) && ((object)containingAssembly != null && (DynAbs.Tracing.TraceSender.Expression_True(10344, 6257, 6365) && (object)containingAssembly != f_10344_6325_6365(f_10344_6325_6356(moduleBuilder))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10344, 6253, 7022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 6399, 6502);

                    var
                    referenceManager = f_10344_6422_6501(((CSharpCompilation)f_10344_6442_6473(moduleBuilder)))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 6531, 6536);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 6522, 7007) || true) && (i < referenceManager.ReferencedAssemblies.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 6588, 6591)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10344, 6522, 7007))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10344, 6522, 7007);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 6633, 6988) || true) && ((object)f_10344_6645_6682(referenceManager)[i] == containingAssembly)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10344, 6633, 6988);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 6757, 6965) || true) && (!f_10344_6762_6816(referenceManager, i))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10344, 6757, 6965);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 6874, 6938);

                                    return f_10344_6881_6937(moduleBuilder, containingAssembly, diagnostics);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10344, 6757, 6965);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10344, 6633, 6988);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10344, 1, 486);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10344, 1, 486);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10344, 6253, 7022);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 7038, 7050);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10344, 6000, 7061);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10344_6209_6238(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10344, 6209, 6238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_10344_6325_6356(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param)
                {
                    var return_v = this_param.CommonCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10344, 6325, 6356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IAssemblySymbol
                f_10344_6325_6365(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10344, 6325, 6365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_10344_6442_6473(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param)
                {
                    var return_v = this_param.CommonCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10344, 6442, 6473);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                f_10344_6422_6501(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetBoundReferenceManager();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 6422, 6501);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10344_6645_6682(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                this_param)
                {
                    var return_v = this_param.ReferencedAssemblies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10344, 6645, 6682);
                    return return_v;
                }


                bool
                f_10344_6762_6816(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                this_param, int
                referencedAssemblyIndex)
                {
                    var return_v = this_param.DeclarationsAccessibleWithoutAlias(referencedAssemblyIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 6762, 6816);
                    return return_v;
                }


                Microsoft.Cci.IAssemblyReference
                f_10344_6881_6937(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                assembly, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(assembly, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 6881, 6937);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10344, 6000, 7061);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10344, 6000, 7061);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.IImportScope Cci.IImportScope.Parent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10344, 7114, 7126);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10344, 7117, 7126);
                    return ParentOpt; DynAbs.Tracing.TraceSender.TraceExitMethod(10344, 7114, 7126);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10344, 7114, 7126);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10344, 7114, 7126);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ImportChain()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10344, 449, 7134);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10344, 449, 7134);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10344, 449, 7134);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10344, 449, 7134);

        int
        f_10344_828_857(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10344, 828, 857);
            return 0;
        }

    }
}
