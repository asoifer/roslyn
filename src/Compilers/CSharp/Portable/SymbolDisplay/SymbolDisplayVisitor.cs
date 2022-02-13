// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.SymbolDisplay;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class SymbolDisplayVisitor : AbstractSymbolDisplayVisitor
    {
        private readonly bool _escapeKeywordIdentifiers;

        private IDictionary<INamespaceOrTypeSymbol, IAliasSymbol> _lazyAliasMap;

        internal SymbolDisplayVisitor(
                    ArrayBuilder<SymbolDisplayPart> builder,
                    SymbolDisplayFormat format,
                    SemanticModel semanticModelOpt,
                    int positionOpt)
        : base(f_10955_971_978_C(builder), format, true, semanticModelOpt, positionOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10955, 750, 1191);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 630, 655);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 724, 737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 1049, 1180);

                _escapeKeywordIdentifiers = f_10955_1077_1179(f_10955_1077_1104(format), SymbolDisplayMiscellaneousOptions.EscapeKeywordIdentifiers);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10955, 750, 1191);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10955, 750, 1191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10955, 750, 1191);
            }
        }

        private SymbolDisplayVisitor(
                    ArrayBuilder<SymbolDisplayPart> builder,
                    SymbolDisplayFormat format,
                    SemanticModel semanticModelOpt,
                    int positionOpt,
                    bool escapeKeywordIdentifiers,
                    IDictionary<INamespaceOrTypeSymbol, IAliasSymbol> aliasMap,
                    bool isFirstSymbolVisited,
                    bool inNamespaceOrType = false)
        : base(f_10955_1625_1632_C(builder), format, isFirstSymbolVisited, semanticModelOpt, positionOpt, inNamespaceOrType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10955, 1203, 1841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 630, 655);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 724, 737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 1738, 1791);

                _escapeKeywordIdentifiers = escapeKeywordIdentifiers;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 1805, 1830);

                _lazyAliasMap = aliasMap;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10955, 1203, 1841);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10955, 1203, 1841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10955, 1203, 1841);
            }
        }

        protected override AbstractSymbolDisplayVisitor MakeNotFirstVisitor(bool inNamespaceOrType = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10955, 1853, 2334);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 1977, 2323);

                return f_10955_1984_2322(this.builder, this.format, this.semanticModelOpt, this.positionOpt, _escapeKeywordIdentifiers, _lazyAliasMap, isFirstSymbolVisited: false, inNamespaceOrType: inNamespaceOrType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10955, 1853, 2334);

                Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                f_10955_1984_2322(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                builder, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format, Microsoft.CodeAnalysis.SemanticModel
                semanticModelOpt, int
                positionOpt, bool
                escapeKeywordIdentifiers, System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol, Microsoft.CodeAnalysis.IAliasSymbol>
                aliasMap, bool
                isFirstSymbolVisited, bool
                inNamespaceOrType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor(builder, format, semanticModelOpt, positionOpt, escapeKeywordIdentifiers, aliasMap, isFirstSymbolVisited: isFirstSymbolVisited, inNamespaceOrType: inNamespaceOrType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 1984, 2322);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10955, 1853, 2334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10955, 1853, 2334);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SymbolDisplayPart CreatePart(SymbolDisplayPartKind kind, ISymbol symbol, string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10955, 2346, 2672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 2465, 2596);

                text = (DynAbs.Tracing.TraceSender.Conditional_F1(10955, 2472, 2486) || (((text == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10955, 2489, 2492)) || DynAbs.Tracing.TraceSender.Conditional_F3(10955, 2515, 2595))) ? "?" : (DynAbs.Tracing.TraceSender.Conditional_F1(10955, 2515, 2563) || (((_escapeKeywordIdentifiers && (DynAbs.Tracing.TraceSender.Expression_True(10955, 2516, 2562) && f_10955_2545_2562(kind))) && DynAbs.Tracing.TraceSender.Conditional_F2(10955, 2566, 2588)) || DynAbs.Tracing.TraceSender.Conditional_F3(10955, 2591, 2595))) ? f_10955_2566_2588(text) : text;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 2612, 2661);

                return f_10955_2619_2660(kind, symbol, text);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10955, 2346, 2672);

                bool
                f_10955_2545_2562(Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind)
                {
                    var return_v = IsEscapable(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 2545, 2562);
                    return return_v;
                }


                string
                f_10955_2566_2588(string
                identifier)
                {
                    var return_v = EscapeIdentifier(identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 2566, 2588);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10955_2619_2660(Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.ISymbol
                symbol, string
                text)
                {
                    var return_v = new Microsoft.CodeAnalysis.SymbolDisplayPart(kind, symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 2619, 2660);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10955, 2346, 2672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10955, 2346, 2672);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsEscapable(SymbolDisplayPartKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10955, 2684, 3720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 2768, 3709);

                switch (kind)
                {

                    case SymbolDisplayPartKind.AliasName:
                    case SymbolDisplayPartKind.ClassName:
                    case SymbolDisplayPartKind.RecordClassName:
                    case SymbolDisplayPartKind.StructName:
                    case SymbolDisplayPartKind.InterfaceName:
                    case SymbolDisplayPartKind.EnumName:
                    case SymbolDisplayPartKind.DelegateName:
                    case SymbolDisplayPartKind.TypeParameterName:
                    case SymbolDisplayPartKind.MethodName:
                    case SymbolDisplayPartKind.PropertyName:
                    case SymbolDisplayPartKind.FieldName:
                    case SymbolDisplayPartKind.LocalName:
                    case SymbolDisplayPartKind.NamespaceName:
                    case SymbolDisplayPartKind.ParameterName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 2768, 3709);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 3621, 3633);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 2768, 3709);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 2768, 3709);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 3681, 3694);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 2768, 3709);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10955, 2684, 3720);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10955, 2684, 3720);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10955, 2684, 3720);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string EscapeIdentifier(string identifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10955, 3732, 3986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 3814, 3864);

                var
                kind = f_10955_3825_3863(identifier)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 3878, 3975);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10955, 3885, 3908) || ((kind == SyntaxKind.None
                && DynAbs.Tracing.TraceSender.Conditional_F2(10955, 3928, 3938)) || DynAbs.Tracing.TraceSender.Conditional_F3(10955, 3958, 3974))) ? identifier
                : $"@{identifier}";
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10955, 3732, 3986);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10955_3825_3863(string
                text)
                {
                    var return_v = SyntaxFacts.GetKeywordKind(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 3825, 3863);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10955, 3732, 3986);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10955, 3732, 3986);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void VisitAssembly(IAssemblySymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10955, 3998, 4363);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 4081, 4262);

                var
                text = (DynAbs.Tracing.TraceSender.Conditional_F1(10955, 4092, 4169) || ((f_10955_4092_4121(format) == SymbolDisplayTypeQualificationStyle.NameOnly
                && DynAbs.Tracing.TraceSender.Conditional_F2(10955, 4189, 4209)) || DynAbs.Tracing.TraceSender.Conditional_F3(10955, 4229, 4261))) ? f_10955_4189_4209(f_10955_4189_4204(symbol)) : f_10955_4229_4261(f_10955_4229_4244(symbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 4278, 4352);

                f_10955_4278_4351(
                            builder, f_10955_4290_4350(this, SymbolDisplayPartKind.AssemblyName, symbol, text));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10955, 3998, 4363);

                Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
                f_10955_4092_4121(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.TypeQualificationStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 4092, 4121);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10955_4189_4204(Microsoft.CodeAnalysis.IAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 4189, 4204);
                    return return_v;
                }


                string
                f_10955_4189_4209(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 4189, 4209);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10955_4229_4244(Microsoft.CodeAnalysis.IAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 4229, 4244);
                    return return_v;
                }


                string
                f_10955_4229_4261(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.GetDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 4229, 4261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10955_4290_4350(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.IAssemblySymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 4290, 4350);
                    return return_v;
                }


                int
                f_10955_4278_4351(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 4278, 4351);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10955, 3998, 4363);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10955, 3998, 4363);
            }
        }

        public override void VisitModule(IModuleSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10955, 4375, 4544);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 4454, 4533);

                f_10955_4454_4532(builder, f_10955_4466_4531(this, SymbolDisplayPartKind.ModuleName, symbol, f_10955_4519_4530(symbol)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10955, 4375, 4544);

                string
                f_10955_4519_4530(Microsoft.CodeAnalysis.IModuleSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 4519, 4530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10955_4466_4531(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.IModuleSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 4466, 4531);
                    return return_v;
                }


                int
                f_10955_4454_4532(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 4454, 4532);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10955, 4375, 4544);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10955, 4375, 4544);
            }
        }

        public override void VisitNamespace(INamespaceSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10955, 4556, 5931);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 4641, 4881) || true) && (f_10955_4645_4662(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 4641, 4881);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 4696, 4796) || true) && (f_10955_4700_4728(this, symbol, builder))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 4696, 4796);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 4770, 4777);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 4696, 4796);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 4816, 4841);

                    f_10955_4816_4840(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 4859, 4866);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 4641, 4881);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 4897, 5126) || true) && (isFirstSymbolVisited && (DynAbs.Tracing.TraceSender.Expression_True(10955, 4901, 5008) && f_10955_4925_5008(f_10955_4925_4943(format), SymbolDisplayKindOptions.IncludeNamespaceKeyword)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 4897, 5126);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 5042, 5082);

                    f_10955_5042_5081(this, SyntaxKind.NamespaceKeyword);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 5100, 5111);

                    f_10955_5100_5110(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 4897, 5126);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 5142, 5652) || true) && (f_10955_5146_5175(format) == SymbolDisplayTypeQualificationStyle.NameAndContainingTypesAndNamespaces)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 5142, 5652);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 5284, 5337);

                    var
                    containingNamespace = f_10955_5310_5336(symbol)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 5355, 5637) || true) && (f_10955_5359_5400(this, containingNamespace))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 5355, 5637);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 5442, 5491);

                        f_10955_5442_5490(containingNamespace, f_10955_5469_5489(this));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 5513, 5618);

                        f_10955_5513_5617(this, (DynAbs.Tracing.TraceSender.Conditional_F1(10955, 5528, 5565) || ((f_10955_5528_5565(containingNamespace) && DynAbs.Tracing.TraceSender.Conditional_F2(10955, 5568, 5594)) || DynAbs.Tracing.TraceSender.Conditional_F3(10955, 5597, 5616))) ? SyntaxKind.ColonColonToken : SyntaxKind.DotToken);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 5355, 5637);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 5142, 5652);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 5668, 5920) || true) && (f_10955_5672_5696(symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 5668, 5920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 5730, 5757);

                    f_10955_5730_5756(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 5668, 5920);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 5668, 5920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 5823, 5905);

                    f_10955_5823_5904(builder, f_10955_5835_5903(this, SymbolDisplayPartKind.NamespaceName, symbol, f_10955_5891_5902(symbol)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 5668, 5920);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10955, 4556, 5931);

                bool
                f_10955_4645_4662(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.IsMinimizing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 4645, 4662);
                    return return_v;
                }


                bool
                f_10955_4700_4728(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamespaceSymbol
                symbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                builder)
                {
                    var return_v = this_param.TryAddAlias((Microsoft.CodeAnalysis.INamespaceOrTypeSymbol)symbol, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 4700, 4728);
                    return return_v;
                }


                int
                f_10955_4816_4840(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamespaceSymbol
                symbol)
                {
                    this_param.MinimallyQualify(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 4816, 4840);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                f_10955_4925_4943(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.KindOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 4925, 4943);
                    return return_v;
                }


                bool
                f_10955_4925_5008(Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayKindOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 4925, 5008);
                    return return_v;
                }


                int
                f_10955_5042_5081(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 5042, 5081);
                    return 0;
                }


                int
                f_10955_5100_5110(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 5100, 5110);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
                f_10955_5146_5175(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.TypeQualificationStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 5146, 5175);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamespaceSymbol
                f_10955_5310_5336(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 5310, 5336);
                    return return_v;
                }


                bool
                f_10955_5359_5400(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamespaceSymbol
                containingSymbol)
                {
                    var return_v = this_param.ShouldVisitNamespace((Microsoft.CodeAnalysis.ISymbol)containingSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 5359, 5400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10955_5469_5489(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 5469, 5489);
                    return return_v;
                }


                int
                f_10955_5442_5490(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 5442, 5490);
                    return 0;
                }


                bool
                f_10955_5528_5565(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param)
                {
                    var return_v = this_param.IsGlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 5528, 5565);
                    return return_v;
                }


                int
                f_10955_5513_5617(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 5513, 5617);
                    return 0;
                }


                bool
                f_10955_5672_5696(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param)
                {
                    var return_v = this_param.IsGlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 5672, 5696);
                    return return_v;
                }


                int
                f_10955_5730_5756(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamespaceSymbol
                globalNamespace)
                {
                    this_param.AddGlobalNamespace(globalNamespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 5730, 5756);
                    return 0;
                }


                string
                f_10955_5891_5902(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 5891, 5902);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10955_5835_5903(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.INamespaceSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 5835, 5903);
                    return return_v;
                }


                int
                f_10955_5823_5904(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 5823, 5904);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10955, 4556, 5931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10955, 4556, 5931);
            }
        }

        private void AddGlobalNamespace(INamespaceSymbol globalNamespace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10955, 5943, 7568);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 6104, 6172);

                const string
                standaloneGlobalNamespaceString = "<global namespace>"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 6188, 7557);

                switch (f_10955_6196_6223(format))
                {

                    case SymbolDisplayGlobalNamespaceStyle.Omitted:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 6188, 7557);
                        DynAbs.Tracing.TraceSender.TraceBreak(10955, 6326, 6332);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 6188, 7557);

                    case SymbolDisplayGlobalNamespaceStyle.Included:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 6188, 7557);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 6420, 6958) || true) && (this.isFirstSymbolVisited)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 6420, 6958);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 6499, 6689);

                            f_10955_6499_6688(builder, f_10955_6511_6687(this, SymbolDisplayPartKind.Text, globalNamespace, standaloneGlobalNamespaceString));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 6420, 6958);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 6420, 6958);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 6787, 6935);

                            f_10955_6787_6934(builder, f_10955_6799_6933(this, SymbolDisplayPartKind.Keyword, globalNamespace, f_10955_6887_6932(SyntaxKind.GlobalKeyword)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 6420, 6958);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10955, 6980, 6986);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 6188, 7557);

                    case SymbolDisplayGlobalNamespaceStyle.OmittedAsContaining:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 6188, 7557);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 7085, 7196);

                        f_10955_7085_7195(this.isFirstSymbolVisited, "Don't call with IsFirstSymbolVisited = false if OmittedAsContaining");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 7218, 7396);

                        f_10955_7218_7395(builder, f_10955_7230_7394(this, SymbolDisplayPartKind.Text, globalNamespace, standaloneGlobalNamespaceString));
                        DynAbs.Tracing.TraceSender.TraceBreak(10955, 7418, 7424);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 6188, 7557);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 6188, 7557);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 7472, 7542);

                        throw f_10955_7478_7541(f_10955_7513_7540(format));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 6188, 7557);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10955, 5943, 7568);

                Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
                f_10955_6196_6223(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GlobalNamespaceStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 6196, 6223);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10955_6511_6687(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.INamespaceSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 6511, 6687);
                    return return_v;
                }


                int
                f_10955_6499_6688(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 6499, 6688);
                    return 0;
                }


                string
                f_10955_6887_6932(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 6887, 6932);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10955_6799_6933(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.INamespaceSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 6799, 6933);
                    return return_v;
                }


                int
                f_10955_6787_6934(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 6787, 6934);
                    return 0;
                }


                int
                f_10955_7085_7195(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 7085, 7195);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10955_7230_7394(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.INamespaceSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 7230, 7394);
                    return return_v;
                }


                int
                f_10955_7218_7395(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 7218, 7395);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
                f_10955_7513_7540(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GlobalNamespaceStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 7513, 7540);
                    return return_v;
                }


                System.Exception
                f_10955_7478_7541(Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 7478, 7541);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10955, 5943, 7568);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10955, 5943, 7568);
            }
        }

        public override void VisitLocal(ILocalSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10955, 7580, 9072);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 7657, 8072) || true) && (f_10955_7661_7673(symbol) && (DynAbs.Tracing.TraceSender.Expression_True(10955, 7661, 7766) && f_10955_7694_7766(f_10955_7694_7713(format), SymbolDisplayLocalOptions.IncludeRef)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 7657, 8072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 7800, 7834);

                    f_10955_7800_7833(this, SyntaxKind.RefKeyword);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 7852, 7863);

                    f_10955_7852_7862(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 7883, 8057) || true) && (f_10955_7887_7901(symbol) == RefKind.RefReadOnly)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 7883, 8057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 7966, 8005);

                        f_10955_7966_8004(this, SyntaxKind.ReadOnlyKeyword);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 8027, 8038);

                        f_10955_8027_8037(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 7883, 8057);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 7657, 8072);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 8088, 8284) || true) && (f_10955_8092_8165(f_10955_8092_8111(format), SymbolDisplayLocalOptions.IncludeType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 8088, 8284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 8199, 8240);

                    f_10955_8199_8239(f_10955_8199_8210(symbol), f_10955_8218_8238(this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 8258, 8269);

                    f_10955_8258_8268(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 8088, 8284);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 8300, 8592) || true) && (f_10955_8304_8318(symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 8300, 8592);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 8352, 8433);

                    f_10955_8352_8432(builder, f_10955_8364_8431(this, SymbolDisplayPartKind.ConstantName, symbol, f_10955_8419_8430(symbol)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 8300, 8592);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 8300, 8592);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 8499, 8577);

                    f_10955_8499_8576(builder, f_10955_8511_8575(this, SymbolDisplayPartKind.LocalName, symbol, f_10955_8563_8574(symbol)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 8300, 8592);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 8608, 9061) || true) && (f_10955_8612_8694(f_10955_8612_8631(format), SymbolDisplayLocalOptions.IncludeConstantValue) && (DynAbs.Tracing.TraceSender.Expression_True(10955, 8612, 8729) && f_10955_8715_8729(symbol)) && (DynAbs.Tracing.TraceSender.Expression_True(10955, 8612, 8773) && f_10955_8750_8773(symbol)) && (DynAbs.Tracing.TraceSender.Expression_True(10955, 8612, 8843) && f_10955_8794_8843(f_10955_8809_8820(symbol), f_10955_8822_8842(symbol))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 8608, 9061);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 8877, 8888);

                    f_10955_8877_8887(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 8906, 8945);

                    f_10955_8906_8944(this, SyntaxKind.EqualsToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 8963, 8974);

                    f_10955_8963_8973(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 8994, 9046);

                    f_10955_8994_9045(this, f_10955_9011_9022(symbol), f_10955_9024_9044(symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 8608, 9061);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10955, 7580, 9072);

                bool
                f_10955_7661_7673(Microsoft.CodeAnalysis.ILocalSymbol
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 7661, 7673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                f_10955_7694_7713(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.LocalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 7694, 7713);
                    return return_v;
                }


                bool
                f_10955_7694_7766(Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 7694, 7766);
                    return return_v;
                }


                int
                f_10955_7800_7833(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 7800, 7833);
                    return 0;
                }


                int
                f_10955_7852_7862(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 7852, 7862);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10955_7887_7901(Microsoft.CodeAnalysis.ILocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 7887, 7901);
                    return return_v;
                }


                int
                f_10955_7966_8004(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 7966, 8004);
                    return 0;
                }


                int
                f_10955_8027_8037(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 8027, 8037);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                f_10955_8092_8111(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.LocalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 8092, 8111);
                    return return_v;
                }


                bool
                f_10955_8092_8165(Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 8092, 8165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_10955_8199_8210(Microsoft.CodeAnalysis.ILocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 8199, 8210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10955_8218_8238(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 8218, 8238);
                    return return_v;
                }


                int
                f_10955_8199_8239(Microsoft.CodeAnalysis.ITypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 8199, 8239);
                    return 0;
                }


                int
                f_10955_8258_8268(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 8258, 8268);
                    return 0;
                }


                bool
                f_10955_8304_8318(Microsoft.CodeAnalysis.ILocalSymbol
                this_param)
                {
                    var return_v = this_param.IsConst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 8304, 8318);
                    return return_v;
                }


                string
                f_10955_8419_8430(Microsoft.CodeAnalysis.ILocalSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 8419, 8430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10955_8364_8431(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.ILocalSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 8364, 8431);
                    return return_v;
                }


                int
                f_10955_8352_8432(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 8352, 8432);
                    return 0;
                }


                string
                f_10955_8563_8574(Microsoft.CodeAnalysis.ILocalSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 8563, 8574);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10955_8511_8575(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.ILocalSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 8511, 8575);
                    return return_v;
                }


                int
                f_10955_8499_8576(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 8499, 8576);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                f_10955_8612_8631(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.LocalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 8612, 8631);
                    return return_v;
                }


                bool
                f_10955_8612_8694(Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 8612, 8694);
                    return return_v;
                }


                bool
                f_10955_8715_8729(Microsoft.CodeAnalysis.ILocalSymbol
                this_param)
                {
                    var return_v = this_param.IsConst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 8715, 8729);
                    return return_v;
                }


                bool
                f_10955_8750_8773(Microsoft.CodeAnalysis.ILocalSymbol
                this_param)
                {
                    var return_v = this_param.HasConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 8750, 8773);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_10955_8809_8820(Microsoft.CodeAnalysis.ILocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 8809, 8820);
                    return return_v;
                }


                object?
                f_10955_8822_8842(Microsoft.CodeAnalysis.ILocalSymbol
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 8822, 8842);
                    return return_v;
                }


                bool
                f_10955_8794_8843(Microsoft.CodeAnalysis.ITypeSymbol
                type, object?
                value)
                {
                    var return_v = CanAddConstant(type, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 8794, 8843);
                    return return_v;
                }


                int
                f_10955_8877_8887(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 8877, 8887);
                    return 0;
                }


                int
                f_10955_8906_8944(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 8906, 8944);
                    return 0;
                }


                int
                f_10955_8963_8973(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 8963, 8973);
                    return 0;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_10955_9011_9022(Microsoft.CodeAnalysis.ILocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 9011, 9022);
                    return return_v;
                }


                object?
                f_10955_9024_9044(Microsoft.CodeAnalysis.ILocalSymbol
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 9024, 9044);
                    return return_v;
                }


                int
                f_10955_8994_9045(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.ITypeSymbol
                type, object?
                constantValue)
                {
                    this_param.AddConstantValue(type, constantValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 8994, 9045);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10955, 7580, 9072);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10955, 7580, 9072);
            }
        }

        public override void VisitDiscard(IDiscardSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10955, 9084, 9460);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 9165, 9361) || true) && (f_10955_9169_9242(f_10955_9169_9188(format), SymbolDisplayLocalOptions.IncludeType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 9165, 9361);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 9276, 9317);

                    f_10955_9276_9316(f_10955_9276_9287(symbol), f_10955_9295_9315(this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 9335, 9346);

                    f_10955_9335_9345(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 9165, 9361);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 9377, 9449);

                f_10955_9377_9448(
                            builder, f_10955_9389_9447(this, SymbolDisplayPartKind.Punctuation, symbol, "_"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10955, 9084, 9460);

                Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                f_10955_9169_9188(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.LocalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 9169, 9188);
                    return return_v;
                }


                bool
                f_10955_9169_9242(Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 9169, 9242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_10955_9276_9287(Microsoft.CodeAnalysis.IDiscardSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 9276, 9287);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10955_9295_9315(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 9295, 9315);
                    return return_v;
                }


                int
                f_10955_9276_9316(Microsoft.CodeAnalysis.ITypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 9276, 9316);
                    return 0;
                }


                int
                f_10955_9335_9345(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 9335, 9345);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10955_9389_9447(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.IDiscardSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 9389, 9447);
                    return return_v;
                }


                int
                f_10955_9377_9448(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 9377, 9448);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10955, 9084, 9460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10955, 9084, 9460);
            }
        }

        public override void VisitRangeVariable(IRangeVariableSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10955, 9472, 10187);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 9565, 10074) || true) && (f_10955_9569_9642(f_10955_9569_9588(format), SymbolDisplayLocalOptions.IncludeType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 9565, 10074);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 9676, 9724);

                    ITypeSymbol
                    type = f_10955_9695_9723(this, symbol)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 9744, 10028) || true) && (type != null && (DynAbs.Tracing.TraceSender.Expression_True(10955, 9748, 9795) && f_10955_9764_9777(type) != TypeKind.Error))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 9744, 10028);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 9837, 9855);

                        f_10955_9837_9854(type, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 9744, 10028);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 9744, 10028);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 9937, 10009);

                        f_10955_9937_10008(builder, f_10955_9949_10007(this, SymbolDisplayPartKind.ErrorTypeName, type, "?"));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 9744, 10028);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 10048, 10059);

                    f_10955_10048_10058(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 9565, 10074);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 10090, 10176);

                f_10955_10090_10175(
                            builder, f_10955_10102_10174(this, SymbolDisplayPartKind.RangeVariableName, symbol, f_10955_10162_10173(symbol)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10955, 9472, 10187);

                Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                f_10955_9569_9588(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.LocalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 9569, 9588);
                    return return_v;
                }


                bool
                f_10955_9569_9642(Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 9569, 9642);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_10955_9695_9723(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.IRangeVariableSymbol
                symbol)
                {
                    var return_v = this_param.GetRangeVariableType(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 9695, 9723);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10955_9764_9777(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 9764, 9777);
                    return return_v;
                }


                int
                f_10955_9837_9854(Microsoft.CodeAnalysis.ITypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 9837, 9854);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10955_9949_10007(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.ITypeSymbol?
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol?)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 9949, 10007);
                    return return_v;
                }


                int
                f_10955_9937_10008(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 9937, 10008);
                    return 0;
                }


                int
                f_10955_10048_10058(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 10048, 10058);
                    return 0;
                }


                string
                f_10955_10162_10173(Microsoft.CodeAnalysis.IRangeVariableSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 10162, 10173);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10955_10102_10174(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.IRangeVariableSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 10102, 10174);
                    return return_v;
                }


                int
                f_10955_10090_10175(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 10090, 10175);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10955, 9472, 10187);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10955, 9472, 10187);
            }
        }

        public override void VisitLabel(ILabelSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10955, 10199, 10365);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 10276, 10354);

                f_10955_10276_10353(builder, f_10955_10288_10352(this, SymbolDisplayPartKind.LabelName, symbol, f_10955_10340_10351(symbol)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10955, 10199, 10365);

                string
                f_10955_10340_10351(Microsoft.CodeAnalysis.ILabelSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 10340, 10351);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10955_10288_10352(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.ILabelSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 10288, 10352);
                    return return_v;
                }


                int
                f_10955_10276_10353(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 10276, 10353);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10955, 10199, 10365);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10955, 10199, 10365);
            }
        }

        public override void VisitAlias(IAliasSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10955, 10377, 10793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 10454, 10532);

                f_10955_10454_10531(builder, f_10955_10466_10530(this, SymbolDisplayPartKind.AliasName, symbol, f_10955_10518_10529(symbol)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 10548, 10782) || true) && (f_10955_10552_10625(f_10955_10552_10571(format), SymbolDisplayLocalOptions.IncludeType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 10548, 10782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 10683, 10722);

                    f_10955_10683_10721(this, SyntaxKind.EqualsToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 10740, 10767);

                    f_10955_10740_10766(f_10955_10740_10753(symbol), this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 10548, 10782);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10955, 10377, 10793);

                string
                f_10955_10518_10529(Microsoft.CodeAnalysis.IAliasSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 10518, 10529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10955_10466_10530(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.IAliasSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 10466, 10530);
                    return return_v;
                }


                int
                f_10955_10454_10531(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 10454, 10531);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                f_10955_10552_10571(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.LocalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 10552, 10571);
                    return return_v;
                }


                bool
                f_10955_10552_10625(Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 10552, 10625);
                    return return_v;
                }


                int
                f_10955_10683_10721(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 10683, 10721);
                    return 0;
                }


                Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                f_10955_10740_10753(Microsoft.CodeAnalysis.IAliasSymbol
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 10740, 10753);
                    return return_v;
                }


                int
                f_10955_10740_10766(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 10740, 10766);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10955, 10377, 10793);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10955, 10377, 10793);
            }
        }

        protected override void AddSpace()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10955, 10805, 10939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 10864, 10928);

                f_10955_10864_10927(builder, f_10955_10876_10926(this, SymbolDisplayPartKind.Space, null, " "));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10955, 10805, 10939);

                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10955_10876_10926(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.ISymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 10876, 10926);
                    return return_v;
                }


                int
                f_10955_10864_10927(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 10864, 10927);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10955, 10805, 10939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10955, 10805, 10939);
            }
        }

        private void AddPunctuation(SyntaxKind punctuationKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10955, 10951, 11145);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 11031, 11134);

                f_10955_11031_11133(builder, f_10955_11043_11132(this, SymbolDisplayPartKind.Punctuation, null, f_10955_11095_11131(punctuationKind)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10955, 10951, 11145);

                string
                f_10955_11095_11131(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 11095, 11131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10955_11043_11132(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.ISymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 11043, 11132);
                    return return_v;
                }


                int
                f_10955_11031_11133(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 11031, 11133);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10955, 10951, 11145);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10955, 10951, 11145);
            }
        }

        private void AddKeyword(SyntaxKind keywordKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10955, 11157, 11335);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 11229, 11324);

                f_10955_11229_11323(builder, f_10955_11241_11322(this, SymbolDisplayPartKind.Keyword, null, f_10955_11289_11321(keywordKind)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10955, 11157, 11335);

                string
                f_10955_11289_11321(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 11289, 11321);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10955_11241_11322(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.ISymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 11241, 11322);
                    return return_v;
                }


                int
                f_10955_11229_11323(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 11229, 11323);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10955, 11157, 11335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10955, 11157, 11335);
            }
        }

        private void AddAccessibilityIfRequired(ISymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10955, 11347, 12083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 11427, 11483);

                INamedTypeSymbol
                containingType = f_10955_11461_11482(symbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 11639, 11728);

                f_10955_11639_11727((object)containingType != null || (DynAbs.Tracing.TraceSender.Expression_False(10955, 11652, 11726) || (f_10955_11687_11710(symbol) is ITypeSymbol)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 11744, 12072) || true) && (f_10955_11748_11832(f_10955_11748_11768(format), SymbolDisplayMemberOptions.IncludeAccessibility) && (DynAbs.Tracing.TraceSender.Expression_True(10955, 11748, 11998) && (containingType == null || (DynAbs.Tracing.TraceSender.Expression_False(10955, 11854, 11997) || (f_10955_11899_11922(containingType) != TypeKind.Interface && (DynAbs.Tracing.TraceSender.Expression_True(10955, 11899, 11996) && !f_10955_11949_11969(symbol) & !f_10955_11973_11996(symbol)))))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 11744, 12072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 12032, 12057);

                    f_10955_12032_12056(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 11744, 12072);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10955, 11347, 12083);

                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10955_11461_11482(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 11461, 11482);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_10955_11687_11710(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 11687, 11710);
                    return return_v;
                }


                int
                f_10955_11639_11727(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 11639, 11727);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                f_10955_11748_11768(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MemberOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 11748, 11768);
                    return return_v;
                }


                bool
                f_10955_11748_11832(Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 11748, 11832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10955_11899_11922(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 11899, 11922);
                    return return_v;
                }


                bool
                f_10955_11949_11969(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = IsEnumMember(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 11949, 11969);
                    return return_v;
                }


                bool
                f_10955_11973_11996(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = IsLocalFunction(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 11973, 11996);
                    return return_v;
                }


                int
                f_10955_12032_12056(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    this_param.AddAccessibility(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 12032, 12056);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10955, 11347, 12083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10955, 11347, 12083);
            }
        }

        private static bool IsLocalFunction(ISymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10955, 12095, 12366);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 12171, 12269) || true) && (f_10955_12175_12186(symbol) != SymbolKind.Method)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 12171, 12269);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 12241, 12254);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 12171, 12269);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 12285, 12355);

                return f_10955_12292_12326(((IMethodSymbol)symbol)) == MethodKind.LocalFunction;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10955, 12095, 12366);

                Microsoft.CodeAnalysis.SymbolKind
                f_10955_12175_12186(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 12175, 12186);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10955_12292_12326(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 12292, 12326);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10955, 12095, 12366);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10955, 12095, 12366);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddAccessibility(ISymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10955, 12378, 13690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 12448, 13652);

                switch (f_10955_12456_12484(symbol))
                {

                    case Accessibility.Private:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 12448, 13652);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 12567, 12605);

                        f_10955_12567_12604(this, SyntaxKind.PrivateKeyword);
                        DynAbs.Tracing.TraceSender.TraceBreak(10955, 12627, 12633);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 12448, 13652);

                    case Accessibility.Internal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 12448, 13652);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 12701, 12740);

                        f_10955_12701_12739(this, SyntaxKind.InternalKeyword);
                        DynAbs.Tracing.TraceSender.TraceBreak(10955, 12762, 12768);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 12448, 13652);

                    case Accessibility.ProtectedAndInternal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 12448, 13652);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 12848, 12886);

                        f_10955_12848_12885(this, SyntaxKind.PrivateKeyword);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 12908, 12919);

                        f_10955_12908_12918(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 12941, 12981);

                        f_10955_12941_12980(this, SyntaxKind.ProtectedKeyword);
                        DynAbs.Tracing.TraceSender.TraceBreak(10955, 13003, 13009);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 12448, 13652);

                    case Accessibility.Protected:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 12448, 13652);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 13078, 13118);

                        f_10955_13078_13117(this, SyntaxKind.ProtectedKeyword);
                        DynAbs.Tracing.TraceSender.TraceBreak(10955, 13140, 13146);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 12448, 13652);

                    case Accessibility.ProtectedOrInternal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 12448, 13652);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 13225, 13265);

                        f_10955_13225_13264(this, SyntaxKind.ProtectedKeyword);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 13287, 13298);

                        f_10955_13287_13297(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 13320, 13359);

                        f_10955_13320_13358(this, SyntaxKind.InternalKeyword);
                        DynAbs.Tracing.TraceSender.TraceBreak(10955, 13381, 13387);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 12448, 13652);

                    case Accessibility.Public:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 12448, 13652);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 13453, 13490);

                        f_10955_13453_13489(this, SyntaxKind.PublicKeyword);
                        DynAbs.Tracing.TraceSender.TraceBreak(10955, 13512, 13518);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 12448, 13652);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 12448, 13652);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 13566, 13637);

                        throw f_10955_13572_13636(f_10955_13607_13635(symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 12448, 13652);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 13668, 13679);

                f_10955_13668_13678(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10955, 12378, 13690);

                Microsoft.CodeAnalysis.Accessibility
                f_10955_12456_12484(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 12456, 12484);
                    return return_v;
                }


                int
                f_10955_12567_12604(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 12567, 12604);
                    return 0;
                }


                int
                f_10955_12701_12739(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 12701, 12739);
                    return 0;
                }


                int
                f_10955_12848_12885(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 12848, 12885);
                    return 0;
                }


                int
                f_10955_12908_12918(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 12908, 12918);
                    return 0;
                }


                int
                f_10955_12941_12980(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 12941, 12980);
                    return 0;
                }


                int
                f_10955_13078_13117(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 13078, 13117);
                    return 0;
                }


                int
                f_10955_13225_13264(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 13225, 13264);
                    return 0;
                }


                int
                f_10955_13287_13297(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 13287, 13297);
                    return 0;
                }


                int
                f_10955_13320_13358(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 13320, 13358);
                    return 0;
                }


                int
                f_10955_13453_13489(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 13453, 13489);
                    return 0;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10955_13607_13635(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 13607, 13635);
                    return return_v;
                }


                System.Exception
                f_10955_13572_13636(Microsoft.CodeAnalysis.Accessibility
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 13572, 13636);
                    return return_v;
                }


                int
                f_10955_13668_13678(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 13668, 13678);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10955, 12378, 13690);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10955, 12378, 13690);
            }
        }

        private bool ShouldVisitNamespace(ISymbol containingSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10955, 13702, 14314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 13786, 13845);

                var
                namespaceSymbol = containingSymbol as INamespaceSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 13859, 13948) || true) && (namespaceSymbol == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 13859, 13948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 13920, 13933);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 13859, 13948);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 13964, 14134) || true) && (f_10955_13968_13997(format) != SymbolDisplayTypeQualificationStyle.NameAndContainingTypesAndNamespaces)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 13964, 14134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 14106, 14119);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 13964, 14134);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 14150, 14303);

                return
                f_10955_14174_14208_M(!namespaceSymbol.IsGlobalNamespace) || (DynAbs.Tracing.TraceSender.Expression_False(10955, 14174, 14302) || f_10955_14229_14256(format) == SymbolDisplayGlobalNamespaceStyle.Included);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10955, 13702, 14314);

                Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
                f_10955_13968_13997(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.TypeQualificationStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 13968, 13997);
                    return return_v;
                }


                bool
                f_10955_14174_14208_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 14174, 14208);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
                f_10955_14229_14256(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GlobalNamespaceStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 14229, 14256);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10955, 13702, 14314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10955, 13702, 14314);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IncludeNamedType(INamedTypeSymbol namedType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10955, 14326, 14937);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 14408, 14491) || true) && (namedType is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 14408, 14491);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 14463, 14476);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 14408, 14491);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 14507, 14702) || true) && (f_10955_14511_14534(namedType) && (DynAbs.Tracing.TraceSender.Expression_True(10955, 14511, 14640) && !f_10955_14539_14640(f_10955_14539_14569(format), SymbolDisplayCompilerInternalOptions.IncludeScriptType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 14507, 14702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 14674, 14687);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 14507, 14702);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 14741, 14898) || true) && (semanticModelOpt is not null && (DynAbs.Tracing.TraceSender.Expression_True(10955, 14745, 14836) && namedType == f_10955_14790_14836(f_10955_14790_14818(semanticModelOpt))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10955, 14741, 14898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 14870, 14883);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10955, 14741, 14898);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 14914, 14926);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10955, 14326, 14937);

                bool
                f_10955_14511_14534(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 14511, 14534);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                f_10955_14539_14569(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.CompilerInternalOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 14539, 14569);
                    return return_v;
                }


                bool
                f_10955_14539_14640(Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 14539, 14640);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_10955_14790_14818(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 14790, 14818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_10955_14790_14836(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.ScriptGlobalsType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 14790, 14836);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10955, 14326, 14937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10955, 14326, 14937);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsEnumMember(ISymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10955, 14949, 15302);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10955, 15022, 15291);

                return symbol != null
                && (DynAbs.Tracing.TraceSender.Expression_True(10955, 15029, 15095) && f_10955_15064_15075(symbol) == SymbolKind.Field
                ) && (DynAbs.Tracing.TraceSender.Expression_True(10955, 15029, 15145) && f_10955_15116_15137(symbol) != null
                ) && (DynAbs.Tracing.TraceSender.Expression_True(10955, 15029, 15213) && f_10955_15166_15196(f_10955_15166_15187(symbol)) == TypeKind.Enum
                ) && (DynAbs.Tracing.TraceSender.Expression_True(10955, 15029, 15290) && f_10955_15234_15245(symbol) != WellKnownMemberNames.EnumBackingFieldName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10955, 14949, 15302);

                Microsoft.CodeAnalysis.SymbolKind
                f_10955_15064_15075(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 15064, 15075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10955_15116_15137(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 15116, 15137);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10955_15166_15187(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 15166, 15187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10955_15166_15196(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 15166, 15196);
                    return return_v;
                }


                string
                f_10955_15234_15245(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 15234, 15245);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10955, 14949, 15302);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10955, 14949, 15302);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SymbolDisplayVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10955, 517, 15309);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 607, 635);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10956, 667, 695);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10955, 517, 15309);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10955, 517, 15309);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10955, 517, 15309);

        Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
        f_10955_1077_1104(Microsoft.CodeAnalysis.SymbolDisplayFormat
        this_param)
        {
            var return_v = this_param.MiscellaneousOptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10955, 1077, 1104);
            return return_v;
        }


        bool
        f_10955_1077_1179(Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
        options, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
        flag)
        {
            var return_v = options.IncludesOption(flag);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10955, 1077, 1179);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
        f_10955_971_978_C(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10955, 750, 1191);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
        f_10955_1625_1632_C(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10955, 1203, 1841);
            return return_v;
        }

    }
}
