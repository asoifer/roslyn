// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.SymbolDisplay
{
    internal abstract partial class AbstractSymbolDisplayVisitor : SymbolVisitor
    {
        protected readonly ArrayBuilder<SymbolDisplayPart> builder;

        protected readonly SymbolDisplayFormat format;

        protected readonly bool isFirstSymbolVisited;

        protected readonly bool inNamespaceOrType;

        protected readonly SemanticModel semanticModelOpt;

        protected readonly int positionOpt;

        private AbstractSymbolDisplayVisitor _lazyNotFirstVisitor;

        private AbstractSymbolDisplayVisitor _lazyNotFirstVisitorNamespaceOrType;

        protected AbstractSymbolDisplayVisitor(
                    ArrayBuilder<SymbolDisplayPart> builder,
                    SymbolDisplayFormat format,
                    bool isFirstSymbolVisited,
                    SemanticModel semanticModelOpt,
                    int positionOpt,
                    bool inNamespaceOrType = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(565, 990, 1860);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 547, 554);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 604, 610);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 645, 665);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 700, 717);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 763, 779);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 813, 824);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 874, 894);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 942, 977);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 1309, 1338);

                f_565_1309_1337(format != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 1354, 1377);

                this.builder = builder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 1391, 1412);

                this.format = format;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 1426, 1475);

                this.isFirstSymbolVisited = isFirstSymbolVisited;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 1491, 1532);

                this.semanticModelOpt = semanticModelOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 1546, 1577);

                this.positionOpt = positionOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 1591, 1634);

                this.inNamespaceOrType = inNamespaceOrType;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 1747, 1849) || true) && (!isFirstSymbolVisited)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 1747, 1849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 1806, 1834);

                    _lazyNotFirstVisitor = this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(565, 1747, 1849);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(565, 990, 1860);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(565, 990, 1860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(565, 990, 1860);
            }
        }

        protected AbstractSymbolDisplayVisitor NotFirstVisitor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(565, 1951, 2188);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 1987, 2125) || true) && (_lazyNotFirstVisitor == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 1987, 2125);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 2061, 2106);

                        _lazyNotFirstVisitor = f_565_2084_2105(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(565, 1987, 2125);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 2145, 2173);

                    return _lazyNotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(565, 1951, 2188);

                    Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                    f_565_2084_2105(Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                    this_param)
                    {
                        var return_v = this_param.MakeNotFirstVisitor();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 2084, 2105);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(565, 1872, 2199);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(565, 1872, 2199);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected AbstractSymbolDisplayVisitor NotFirstVisitorNamespaceOrType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(565, 2305, 2610);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 2341, 2532) || true) && (_lazyNotFirstVisitorNamespaceOrType == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 2341, 2532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 2430, 2513);

                        _lazyNotFirstVisitorNamespaceOrType = f_565_2468_2512(this, inNamespaceOrType: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(565, 2341, 2532);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 2552, 2595);

                    return _lazyNotFirstVisitorNamespaceOrType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(565, 2305, 2610);

                    Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                    f_565_2468_2512(Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                    this_param, bool
                    inNamespaceOrType)
                    {
                        var return_v = this_param.MakeNotFirstVisitor(inNamespaceOrType: inNamespaceOrType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 2468, 2512);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(565, 2211, 2621);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(565, 2211, 2621);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract AbstractSymbolDisplayVisitor MakeNotFirstVisitor(bool inNamespaceOrType = false);

        protected abstract void AddLiteralValue(SpecialType type, object value);

        protected abstract void AddExplicitlyCastedLiteralValue(INamedTypeSymbol namedType, SpecialType type, object value);

        protected abstract void AddSpace();

        protected abstract void AddBitwiseOr();

        protected void AddNonNullConstantValue(ITypeSymbol type, object constantValue, bool preferNumericValueOrExpandedFlagsForEnum = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(565, 3226, 3745);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 3384, 3420);

                f_565_3384_3419(constantValue != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 3434, 3734) || true) && (f_565_3438_3451(type) == TypeKind.Enum)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 3434, 3734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 3502, 3604);

                    f_565_3502_3603(this, type, constantValue, preferNumericValueOrExpandedFlagsForEnum);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(565, 3434, 3734);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 3434, 3734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 3670, 3719);

                    f_565_3670_3718(this, f_565_3686_3702(type), constantValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(565, 3434, 3734);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(565, 3226, 3745);

                int
                f_565_3384_3419(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 3384, 3419);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_565_3438_3451(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 3438, 3451);
                    return return_v;
                }


                int
                f_565_3502_3603(Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.ITypeSymbol
                enumType, object
                constantValue, bool
                preferNumericValueOrExpandedFlags)
                {
                    this_param.AddEnumConstantValue((Microsoft.CodeAnalysis.INamedTypeSymbol)enumType, constantValue, preferNumericValueOrExpandedFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 3502, 3603);
                    return 0;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_565_3686_3702(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 3686, 3702);
                    return return_v;
                }


                int
                f_565_3670_3718(Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SpecialType
                type, object
                value)
                {
                    this_param.AddLiteralValue(type, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 3670, 3718);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(565, 3226, 3745);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(565, 3226, 3745);
            }
        }

        private void AddEnumConstantValue(INamedTypeSymbol enumType, object constantValue, bool preferNumericValueOrExpandedFlags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(565, 3757, 4701);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 3961, 4001);

                var
                isFlagsEnum = f_565_3979_4000(enumType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 4015, 4690) || true) && (isFlagsEnum)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 4015, 4690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 4064, 4150);

                    f_565_4064_4149(this, enumType, constantValue, preferNumericValueOrExpandedFlags);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(565, 4015, 4690);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 4015, 4690);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 4184, 4690) || true) && (preferNumericValueOrExpandedFlags)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 4184, 4690);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 4331, 4403);

                        f_565_4331_4402(this, f_565_4347_4386(f_565_4347_4374(enumType)), constantValue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(565, 4184, 4690);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 4184, 4690);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 4621, 4675);

                        f_565_4621_4674(this, enumType, constantValue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(565, 4184, 4690);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(565, 4015, 4690);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(565, 3757, 4701);

                bool
                f_565_3979_4000(Microsoft.CodeAnalysis.INamedTypeSymbol
                typeSymbol)
                {
                    var return_v = IsFlagsEnum((Microsoft.CodeAnalysis.ITypeSymbol)typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 3979, 4000);
                    return return_v;
                }


                int
                f_565_4064_4149(Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                enumType, object
                constantValue, bool
                preferNumericValueOrExpandedFlags)
                {
                    this_param.AddFlagsEnumConstantValue(enumType, constantValue, preferNumericValueOrExpandedFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 4064, 4149);
                    return 0;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_565_4347_4374(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.EnumUnderlyingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 4347, 4374);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_565_4347_4386(Microsoft.CodeAnalysis.INamedTypeSymbol?
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 4347, 4386);
                    return return_v;
                }


                int
                f_565_4331_4402(Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SpecialType
                type, object
                value)
                {
                    this_param.AddLiteralValue(type, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 4331, 4402);
                    return 0;
                }


                int
                f_565_4621_4674(Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                enumType, object
                constantValue)
                {
                    this_param.AddNonFlagsEnumConstantValue(enumType, constantValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 4621, 4674);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(565, 3757, 4701);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(565, 3757, 4701);
            }
        }

        private static bool IsFlagsEnum(ITypeSymbol typeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(565, 4953, 6050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 5033, 5066);

                f_565_5033_5065(typeSymbol != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 5082, 5184) || true) && (f_565_5086_5105(typeSymbol) != TypeKind.Enum)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 5082, 5184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 5156, 5169);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(565, 5082, 5184);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 5200, 6010);
                    foreach (var attribute in f_565_5226_5252_I(f_565_5226_5252(typeSymbol)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 5200, 6010);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 5286, 5328);

                        var
                        ctor = f_565_5297_5327(attribute)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 5346, 5995) || true) && (ctor != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 5346, 5995);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 5404, 5435);

                            var
                            type = f_565_5415_5434(ctor)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 5457, 5976) || true) && (!ctor.Parameters.Any() && (DynAbs.Tracing.TraceSender.Expression_True(565, 5461, 5516) && f_565_5487_5496(type) == "FlagsAttribute"))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 5457, 5976);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 5566, 5611);

                                var
                                containingSymbol = f_565_5589_5610(type)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 5637, 5953) || true) && (f_565_5641_5662(containingSymbol) == SymbolKind.Namespace && (DynAbs.Tracing.TraceSender.Expression_True(565, 5641, 5752) && f_565_5719_5740(containingSymbol) == "System") && (DynAbs.Tracing.TraceSender.Expression_True(565, 5641, 5856) && f_565_5785_5856(((INamespaceSymbol)f_565_5804_5837(containingSymbol)))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 5637, 5953);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 5914, 5926);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(565, 5637, 5953);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(565, 5457, 5976);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(565, 5346, 5995);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(565, 5200, 6010);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(565, 1, 811);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(565, 1, 811);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 6026, 6039);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(565, 4953, 6050);

                int
                f_565_5033_5065(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 5033, 5065);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_565_5086_5105(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 5086, 5105);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AttributeData>
                f_565_5226_5252(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 5226, 5252);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_565_5297_5327(Microsoft.CodeAnalysis.AttributeData
                this_param)
                {
                    var return_v = this_param.AttributeConstructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 5297, 5327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_565_5415_5434(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 5415, 5434);
                    return return_v;
                }


                string
                f_565_5487_5496(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 5487, 5496);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_565_5589_5610(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 5589, 5610);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_565_5641_5662(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 5641, 5662);
                    return return_v;
                }


                string
                f_565_5719_5740(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 5719, 5740);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_565_5804_5837(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 5804, 5837);
                    return return_v;
                }


                bool
                f_565_5785_5856(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param)
                {
                    var return_v = this_param.IsGlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 5785, 5856);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AttributeData>
                f_565_5226_5252_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AttributeData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 5226, 5252);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(565, 4953, 6050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(565, 4953, 6050);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddFlagsEnumConstantValue(INamedTypeSymbol enumType, object constantValue, bool preferNumericValueOrExpandedFlags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(565, 6062, 6833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 6283, 6346);

                var
                allFieldsAndValues = f_565_6308_6345()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 6360, 6410);

                f_565_6360_6409(enumType, allFieldsAndValues);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 6426, 6490);

                var
                usedFieldsAndValues = f_565_6452_6489()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 6540, 6667);

                    f_565_6540_6666(this, enumType, constantValue, allFieldsAndValues, usedFieldsAndValues, preferNumericValueOrExpandedFlags);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(565, 6696, 6822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 6736, 6762);

                    f_565_6736_6761(allFieldsAndValues);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 6780, 6807);

                    f_565_6780_6806(usedFieldsAndValues);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(565, 6696, 6822);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(565, 6062, 6833);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Roslyn.Utilities.EnumField>
                f_565_6308_6345()
                {
                    var return_v = ArrayBuilder<EnumField>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 6308, 6345);
                    return return_v;
                }


                int
                f_565_6360_6409(Microsoft.CodeAnalysis.INamedTypeSymbol
                enumType, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Roslyn.Utilities.EnumField>
                enumFields)
                {
                    GetSortedEnumFields(enumType, enumFields);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 6360, 6409);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Roslyn.Utilities.EnumField>
                f_565_6452_6489()
                {
                    var return_v = ArrayBuilder<EnumField>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 6452, 6489);
                    return return_v;
                }


                int
                f_565_6540_6666(Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                enumType, object
                constantValue, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Roslyn.Utilities.EnumField>
                allFieldsAndValues, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Roslyn.Utilities.EnumField>
                usedFieldsAndValues, bool
                preferNumericValueOrExpandedFlags)
                {
                    this_param.AddFlagsEnumConstantValue(enumType, constantValue, allFieldsAndValues, usedFieldsAndValues, preferNumericValueOrExpandedFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 6540, 6666);
                    return 0;
                }


                int
                f_565_6736_6761(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Roslyn.Utilities.EnumField>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 6736, 6761);
                    return 0;
                }


                int
                f_565_6780_6806(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Roslyn.Utilities.EnumField>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 6780, 6806);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(565, 6062, 6833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(565, 6062, 6833);
            }
        }

        private void AddFlagsEnumConstantValue(
                    INamedTypeSymbol enumType, object constantValue,
                    ArrayBuilder<EnumField> allFieldsAndValues,
                    ArrayBuilder<EnumField> usedFieldsAndValues,
                    bool preferNumericValueOrExpandedFlags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(565, 6845, 10391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 7139, 7207);

                var
                underlyingSpecialType = f_565_7167_7206(f_565_7167_7194(enumType))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 7221, 7332);

                var
                constantValueULong = f_565_7246_7331(constantValue, underlyingSpecialType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 7348, 7380);

                var
                result = constantValueULong
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 7760, 8673) || true) && (result != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 7760, 8673);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 7809, 8658);
                        foreach (EnumField fieldAndValue in f_565_7845_7863_I(allFieldsAndValues))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 7809, 8658);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 7905, 7944);

                            var
                            valueAtIndex = fieldAndValue.Value
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 8184, 8341) || true) && (preferNumericValueOrExpandedFlags && (DynAbs.Tracing.TraceSender.Expression_True(565, 8188, 8259) && valueAtIndex == constantValueULong))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 8184, 8341);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 8309, 8318);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(565, 8184, 8341);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 8365, 8639) || true) && (valueAtIndex != 0 && (DynAbs.Tracing.TraceSender.Expression_True(565, 8369, 8429) && (result & valueAtIndex) == valueAtIndex))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 8365, 8639);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 8479, 8518);

                                f_565_8479_8517(usedFieldsAndValues, fieldAndValue);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 8544, 8567);

                                result -= valueAtIndex;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 8593, 8616) || true) && (result == 0)
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 8593, 8616);
                                    DynAbs.Tracing.TraceSender.TraceBreak(565, 8610, 8616);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(565, 8593, 8616);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(565, 8365, 8639);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(565, 7809, 8658);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(565, 1, 850);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(565, 1, 850);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(565, 7760, 8673);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 8775, 10380) || true) && (result == 0 && (DynAbs.Tracing.TraceSender.Expression_True(565, 8779, 8823) && f_565_8794_8819(usedFieldsAndValues) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 8775, 10380);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 8961, 8994);
                        // We want to emit the fields in lower to higher value.  So we walk backward.
                        for (int
        i = f_565_8965_8990(usedFieldsAndValues) - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 8952, 9374) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 9004, 9007)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(565, 8952, 9374))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 8952, 9374);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 9049, 9251) || true) && (i != (f_565_9059_9084(usedFieldsAndValues) - 1))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 9049, 9251);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 9139, 9150);

                                f_565_9139_9149(this);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 9176, 9191);

                                f_565_9176_9190(this);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 9217, 9228);

                                f_565_9217_9227(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(565, 9049, 9251);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 9275, 9355);

                            f_565_9275_9354(
                                                ((IFieldSymbol)usedFieldsAndValues[i].IdentityOpt), f_565_9333_9353(this));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(565, 1, 423);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(565, 1, 423);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(565, 8775, 10380);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 8775, 10380);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 9520, 9701) || true) && (preferNumericValueOrExpandedFlags)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 9520, 9701);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 9599, 9653);

                        f_565_9599_9652(this, underlyingSpecialType, constantValue);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 9675, 9682);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(565, 9520, 9701);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 9820, 9968);

                    var
                    zeroField = (DynAbs.Tracing.TraceSender.Conditional_F1(565, 9836, 9859) || ((constantValueULong == 0
                    && DynAbs.Tracing.TraceSender.Conditional_F2(565, 9883, 9925)) || DynAbs.Tracing.TraceSender.Conditional_F3(565, 9949, 9967))) ? EnumField.FindValue(allFieldsAndValues, 0) : default(EnumField)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 9986, 10365) || true) && (f_565_9990_10010_M(!zeroField.IsDefault))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 9986, 10365);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 10052, 10119);

                        f_565_10052_10118(((IFieldSymbol)zeroField.IdentityOpt), f_565_10097_10117(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(565, 9986, 10365);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 9986, 10365);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 10266, 10346);

                        f_565_10266_10345(this, enumType, underlyingSpecialType, constantValue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(565, 9986, 10365);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(565, 8775, 10380);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(565, 6845, 10391);

                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_565_7167_7194(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.EnumUnderlyingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 7167, 7194);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_565_7167_7206(Microsoft.CodeAnalysis.INamedTypeSymbol?
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 7167, 7206);
                    return return_v;
                }


                ulong
                f_565_7246_7331(object
                value, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = EnumUtilities.ConvertEnumUnderlyingTypeToUInt64(value, specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 7246, 7331);
                    return return_v;
                }


                int
                f_565_8479_8517(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Roslyn.Utilities.EnumField>
                this_param, Roslyn.Utilities.EnumField
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 8479, 8517);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Roslyn.Utilities.EnumField>
                f_565_7845_7863_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Roslyn.Utilities.EnumField>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 7845, 7863);
                    return return_v;
                }


                int
                f_565_8794_8819(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Roslyn.Utilities.EnumField>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 8794, 8819);
                    return return_v;
                }


                int
                f_565_8965_8990(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Roslyn.Utilities.EnumField>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 8965, 8990);
                    return return_v;
                }


                int
                f_565_9059_9084(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Roslyn.Utilities.EnumField>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 9059, 9084);
                    return return_v;
                }


                int
                f_565_9139_9149(Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 9139, 9149);
                    return 0;
                }


                int
                f_565_9176_9190(Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                this_param)
                {
                    this_param.AddBitwiseOr();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 9176, 9190);
                    return 0;
                }


                int
                f_565_9217_9227(Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                this_param)
                {
                    this_param.AddSpace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 9217, 9227);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_565_9333_9353(Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 9333, 9353);
                    return return_v;
                }


                int
                f_565_9275_9354(Microsoft.CodeAnalysis.IFieldSymbol?
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 9275, 9354);
                    return 0;
                }


                int
                f_565_9599_9652(Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SpecialType
                type, object
                value)
                {
                    this_param.AddLiteralValue(type, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 9599, 9652);
                    return 0;
                }


                bool
                f_565_9990_10010_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 9990, 10010);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_565_10097_10117(Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 10097, 10117);
                    return return_v;
                }


                int
                f_565_10052_10118(Microsoft.CodeAnalysis.IFieldSymbol?
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 10052, 10118);
                    return 0;
                }


                int
                f_565_10266_10345(Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                namedType, Microsoft.CodeAnalysis.SpecialType
                type, object
                value)
                {
                    this_param.AddExplicitlyCastedLiteralValue(namedType, type, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 10266, 10345);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(565, 6845, 10391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(565, 6845, 10391);
            }
        }

        private static void GetSortedEnumFields(
                    INamedTypeSymbol enumType,
                    ArrayBuilder<EnumField> enumFields)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(565, 10403, 11239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 10557, 10625);

                var
                underlyingSpecialType = f_565_10585_10624(f_565_10585_10612(enumType))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 10639, 11176);
                    foreach (var member in f_565_10662_10683_I(f_565_10662_10683(enumType)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 10639, 11176);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 10717, 11161) || true) && (f_565_10721_10732(member) == SymbolKind.Field)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 10717, 11161);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 10794, 10827);

                            var
                            field = (IFieldSymbol)member
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 10849, 11142) || true) && (f_565_10853_10875(field))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 10849, 11142);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 10925, 11067);

                                var
                                enumField = f_565_10941_11066(f_565_10955_10965(field), f_565_10967_11058(f_565_11015_11034(field), underlyingSpecialType), field)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 11093, 11119);

                                f_565_11093_11118(enumFields, enumField);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(565, 10849, 11142);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(565, 10717, 11161);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(565, 10639, 11176);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(565, 1, 538);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(565, 1, 538);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 11192, 11228);

                f_565_11192_11227(
                            enumFields, EnumField.Comparer);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(565, 10403, 11239);

                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_565_10585_10612(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.EnumUnderlyingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 10585, 10612);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_565_10585_10624(Microsoft.CodeAnalysis.INamedTypeSymbol?
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 10585, 10624);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_565_10662_10683(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 10662, 10683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_565_10721_10732(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 10721, 10732);
                    return return_v;
                }


                bool
                f_565_10853_10875(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.HasConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 10853, 10875);
                    return return_v;
                }


                string
                f_565_10955_10965(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 10955, 10965);
                    return return_v;
                }


                object
                f_565_11015_11034(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 11015, 11034);
                    return return_v;
                }


                ulong
                f_565_10967_11058(object
                value, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = EnumUtilities.ConvertEnumUnderlyingTypeToUInt64(value, specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 10967, 11058);
                    return return_v;
                }


                Roslyn.Utilities.EnumField
                f_565_10941_11066(string
                name, ulong
                value, Microsoft.CodeAnalysis.IFieldSymbol
                identityOpt)
                {
                    var return_v = new Roslyn.Utilities.EnumField(name, value, (object)identityOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 10941, 11066);
                    return return_v;
                }


                int
                f_565_11093_11118(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Roslyn.Utilities.EnumField>
                this_param, Roslyn.Utilities.EnumField
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 11093, 11118);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_565_10662_10683_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 10662, 10683);
                    return return_v;
                }


                int
                f_565_11192_11227(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Roslyn.Utilities.EnumField>
                this_param, System.Collections.Generic.IComparer<Roslyn.Utilities.EnumField>
                comparer)
                {
                    this_param.Sort(comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 11192, 11227);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(565, 10403, 11239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(565, 10403, 11239);
            }
        }

        private void AddNonFlagsEnumConstantValue(INamedTypeSymbol enumType, object constantValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(565, 11251, 12244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 11366, 11434);

                var
                underlyingSpecialType = f_565_11394_11433(f_565_11394_11421(enumType))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 11448, 11559);

                var
                constantValueULong = f_565_11473_11558(constantValue, underlyingSpecialType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 11575, 11630);

                var
                enumFields = f_565_11592_11629()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 11644, 11686);

                f_565_11644_11685(enumType, enumFields);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 11782, 11846);

                var
                match = EnumField.FindValue(enumFields, constantValueULong)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 11860, 12201) || true) && (f_565_11864_11880_M(!match.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 11860, 12201);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 11914, 11977);

                    f_565_11914_11976(((IFieldSymbol)match.IdentityOpt), f_565_11955_11975(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(565, 11860, 12201);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(565, 11860, 12201);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 12106, 12186);

                    f_565_12106_12185(this, enumType, underlyingSpecialType, constantValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(565, 11860, 12201);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(565, 12215, 12233);

                f_565_12215_12232(enumFields);
                DynAbs.Tracing.TraceSender.TraceExitMethod(565, 11251, 12244);

                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_565_11394_11421(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.EnumUnderlyingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 11394, 11421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_565_11394_11433(Microsoft.CodeAnalysis.INamedTypeSymbol?
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 11394, 11433);
                    return return_v;
                }


                ulong
                f_565_11473_11558(object
                value, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = EnumUtilities.ConvertEnumUnderlyingTypeToUInt64(value, specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 11473, 11558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Roslyn.Utilities.EnumField>
                f_565_11592_11629()
                {
                    var return_v = ArrayBuilder<EnumField>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 11592, 11629);
                    return return_v;
                }


                int
                f_565_11644_11685(Microsoft.CodeAnalysis.INamedTypeSymbol
                enumType, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Roslyn.Utilities.EnumField>
                enumFields)
                {
                    GetSortedEnumFields(enumType, enumFields);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 11644, 11685);
                    return 0;
                }


                bool
                f_565_11864_11880_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 11864, 11880);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_565_11955_11975(Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(565, 11955, 11975);
                    return return_v;
                }


                int
                f_565_11914_11976(Microsoft.CodeAnalysis.IFieldSymbol?
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 11914, 11976);
                    return 0;
                }


                int
                f_565_12106_12185(Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                namedType, Microsoft.CodeAnalysis.SpecialType
                type, object
                value)
                {
                    this_param.AddExplicitlyCastedLiteralValue(namedType, type, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 12106, 12185);
                    return 0;
                }


                int
                f_565_12215_12232(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Roslyn.Utilities.EnumField>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 12215, 12232);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(565, 11251, 12244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(565, 11251, 12244);
            }
        }

        static AbstractSymbolDisplayVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(565, 403, 12251);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(565, 403, 12251);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(565, 403, 12251);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(565, 403, 12251);

        static int
        f_565_1309_1337(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(565, 1309, 1337);
            return 0;
        }

    }
}
