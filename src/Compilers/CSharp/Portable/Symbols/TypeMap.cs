// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class TypeMap : AbstractTypeParameterMap
    {
        public static readonly Func<TypeWithAnnotations, TypeSymbol> AsTypeSymbol;

        internal static ImmutableArray<TypeWithAnnotations> TypeParametersAsTypeSymbolsWithAnnotations(ImmutableArray<TypeParameterSymbol> typeParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10064, 847, 1112);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 1018, 1101);

                return typeParameters.SelectAsArray(static (tp) => TypeWithAnnotations.Create(tp));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10064, 847, 1112);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10064, 847, 1112);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10064, 847, 1112);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<TypeWithAnnotations> TypeParametersAsTypeSymbolsWithIgnoredAnnotations(ImmutableArray<TypeParameterSymbol> typeParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10064, 1124, 1424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 1302, 1413);

                return typeParameters.SelectAsArray(static (tp) => TypeWithAnnotations.Create(tp, NullableAnnotation.Ignored));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10064, 1124, 1424);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10064, 1124, 1424);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10064, 1124, 1424);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<TypeSymbol> AsTypeSymbols(ImmutableArray<TypeWithAnnotations> typesOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10064, 1436, 1649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 1563, 1638);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10064, 1570, 1588) || ((typesOpt.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10064, 1591, 1598)) || DynAbs.Tracing.TraceSender.Conditional_F3(10064, 1601, 1637))) ? default : typesOpt.SelectAsArray(AsTypeSymbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10064, 1436, 1649);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10064, 1436, 1649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10064, 1436, 1649);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeMap(ImmutableArray<TypeParameterSymbol> from, ImmutableArray<TypeWithAnnotations> to, bool allowAlpha = false)
        : base(f_10064_1928_1954_C(f_10064_1928_1954(from, to)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10064, 1784, 2130);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 2037, 2119);

                f_10064_2037_2118(allowAlpha || (DynAbs.Tracing.TraceSender.Expression_False(10064, 2050, 2117) || !from.Any(tp => tp is SubstitutedTypeParameterSymbol)));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10064, 1784, 2130);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10064, 1784, 2130);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10064, 1784, 2130);
            }
        }

        internal TypeMap(ImmutableArray<TypeParameterSymbol> from, ImmutableArray<TypeParameterSymbol> to, bool allowAlpha = false)
        : this(f_10064_2409_2413_C(from), f_10064_2415_2461(to), allowAlpha)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10064, 2265, 2553);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10064, 2265, 2553);
                // mapping contents are read-only hereafter
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10064, 2265, 2553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10064, 2265, 2553);
            }
        }

        private TypeMap(SmallDictionary<TypeParameterSymbol, TypeWithAnnotations> mapping)
        : base(f_10064_2668_2774_C(f_10064_2668_2774(mapping, ReferenceEqualityComparer.Instance)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10064, 2565, 2854);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10064, 2565, 2854);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10064, 2565, 2854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10064, 2565, 2854);
            }
        }

        private static SmallDictionary<TypeParameterSymbol, TypeWithAnnotations> ForType(NamedTypeSymbol containingType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10064, 2866, 3398);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 3003, 3066);

                var
                substituted = containingType as SubstitutedNamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 3080, 3387);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10064, 3087, 3114) || (((object)substituted != null && DynAbs.Tracing.TraceSender.Conditional_F2(10064, 3134, 3269)) || DynAbs.Tracing.TraceSender.Conditional_F3(10064, 3289, 3386))) ? f_10064_3134_3269(f_10064_3196_3224(substituted).Mapping, ReferenceEqualityComparer.Instance) : f_10064_3289_3386(ReferenceEqualityComparer.Instance);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10064, 2866, 3398);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10064_3196_3224(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeSubstitution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10064, 3196, 3224);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10064_3134_3269(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                other, Roslyn.Utilities.ReferenceEqualityComparer
                comparer)
                {
                    var return_v = new Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>(other, (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 3134, 3269);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10064_3289_3386(Roslyn.Utilities.ReferenceEqualityComparer
                comparer)
                {
                    var return_v = new Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 3289, 3386);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10064, 2866, 3398);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10064, 2866, 3398);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeMap(NamedTypeSymbol containingType, ImmutableArray<TypeParameterSymbol> typeParameters, ImmutableArray<TypeWithAnnotations> typeArguments)
        : base(f_10064_3582_3605_C(f_10064_3582_3605(containingType)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10064, 3410, 3953);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 3640, 3645);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 3631, 3942) || true) && (i < typeParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 3674, 3677)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10064, 3631, 3942))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10064, 3631, 3942);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 3711, 3754);

                        TypeParameterSymbol
                        tp = typeParameters[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 3772, 3814);

                        TypeWithAnnotations
                        ta = typeArguments[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 3832, 3927) || true) && (!ta.Is(tp))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10064, 3832, 3927);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 3888, 3908);

                            f_10064_3888_3907(Mapping, tp, ta);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10064, 3832, 3927);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10064, 1, 312);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10064, 1, 312);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10064, 3410, 3953);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10064, 3410, 3953);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10064, 3410, 3953);
            }
        }

        private static readonly SmallDictionary<TypeParameterSymbol, TypeWithAnnotations> s_emptyDictionary;

        private TypeMap()
        : base(f_10064_4228_4245_C(s_emptyDictionary))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10064, 4190, 4324);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 4271, 4313);

                f_10064_4271_4312(f_10064_4284_4311(s_emptyDictionary));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10064, 4190, 4324);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10064, 4190, 4324);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10064, 4190, 4324);
            }
        }

        private static readonly TypeMap s_emptyTypeMap;

        public static TypeMap Empty
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10064, 4461, 4599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 4497, 4544);

                    f_10064_4497_4543(f_10064_4510_4542(s_emptyTypeMap.Mapping));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 4562, 4584);

                    return s_emptyTypeMap;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10064, 4461, 4599);

                    bool
                    f_10064_4510_4542(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    source)
                    {
                        var return_v = source.IsEmpty<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 4510, 4542);
                        return return_v;
                    }


                    int
                    f_10064_4497_4543(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 4497, 4543);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10064, 4409, 4610);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10064, 4409, 4610);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private TypeMap WithAlphaRename(ImmutableArray<TypeParameterSymbol> oldTypeParameters, Symbol newOwner, out ImmutableArray<TypeParameterSymbol> newTypeParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10064, 4622, 6648);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 4809, 4983) || true) && (oldTypeParameters.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10064, 4809, 4983);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 4876, 4938);

                    newTypeParameters = ImmutableArray<TypeParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 4956, 4968);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10064, 4809, 4983);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 5526, 5569);

                TypeMap
                result = f_10064_5543_5568(this.Mapping)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 5583, 5692);

                ArrayBuilder<TypeParameterSymbol>
                newTypeParametersBuilder = f_10064_5644_5691()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 5902, 6025);

                bool
                synthesized = !f_10064_5922_6024(f_10064_5938_5994(f_10064_5938_5975(oldTypeParameters[0])), f_10064_5996_6023(newOwner))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 6041, 6057);

                int
                ordinal = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 6071, 6527);
                    foreach (var tp in f_10064_6090_6107_I(oldTypeParameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10064, 6071, 6527);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 6141, 6354);

                        var
                        newTp = (DynAbs.Tracing.TraceSender.Conditional_F1(10064, 6153, 6164) || ((synthesized && DynAbs.Tracing.TraceSender.Conditional_F2(10064, 6188, 6264)) || DynAbs.Tracing.TraceSender.Conditional_F3(10064, 6288, 6353))) ? f_10064_6188_6264(newOwner, result, tp, ordinal) : f_10064_6288_6353(newOwner, result, tp, ordinal)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 6372, 6430);

                        f_10064_6372_6429(result.Mapping, tp, TypeWithAnnotations.Create(newTp));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 6448, 6484);

                        f_10064_6448_6483(newTypeParametersBuilder, newTp);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 6502, 6512);

                        ordinal++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10064, 6071, 6527);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10064, 1, 457);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10064, 1, 457);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 6543, 6609);

                newTypeParameters = f_10064_6563_6608(newTypeParametersBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 6623, 6637);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10064, 4622, 6648);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10064_5543_5568(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                mapping)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap(mapping);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 5543, 5568);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10064_5644_5691()
                {
                    var return_v = ArrayBuilder<TypeParameterSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 5644, 5691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10064_5938_5975(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10064, 5938, 5975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10064_5938_5994(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10064, 5938, 5994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10064_5996_6023(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10064, 5996, 6023);
                    return return_v;
                }


                bool
                f_10064_5922_6024(Microsoft.CodeAnalysis.CSharp.Symbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 5922, 6024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSubstitutedTypeParameterSymbol
                f_10064_6188_6264(Microsoft.CodeAnalysis.CSharp.Symbol
                owner, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                map, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                substitutedFrom, int
                ordinal)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSubstitutedTypeParameterSymbol(owner, map, substitutedFrom, ordinal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 6188, 6264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedTypeParameterSymbol
                f_10064_6288_6353(Microsoft.CodeAnalysis.CSharp.Symbol
                newContainer, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                map, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                substitutedFrom, int
                ordinal)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedTypeParameterSymbol(newContainer, map, substitutedFrom, ordinal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 6288, 6353);
                    return return_v;
                }


                int
                f_10064_6372_6429(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                key, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 6372, 6429);
                    return 0;
                }


                int
                f_10064_6448_6483(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedTypeParameterSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 6448, 6483);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10064_6090_6107_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 6090, 6107);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10064_6563_6608(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 6563, 6608);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10064, 4622, 6648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10064, 4622, 6648);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeMap WithAlphaRename(NamedTypeSymbol oldOwner, NamedTypeSymbol newOwner, out ImmutableArray<TypeParameterSymbol> newTypeParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10064, 6660, 7058);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 6828, 6933);

                f_10064_6828_6932(f_10064_6841_6931(f_10064_6859_6883(oldOwner), oldOwner, TypeCompareKind.ConsiderEverything2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 6947, 7047);

                return f_10064_6954_7046(this, f_10064_6970_7012(f_10064_6970_6997(oldOwner)), newOwner, out newTypeParameters);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10064, 6660, 7058);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10064_6859_6883(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10064, 6859, 6883);
                    return return_v;
                }


                bool
                f_10064_6841_6931(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 6841, 6931);
                    return return_v;
                }


                int
                f_10064_6828_6932(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 6828, 6932);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10064_6970_6997(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10064, 6970, 6997);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10064_6970_7012(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10064, 6970, 7012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10064_6954_7046(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                oldTypeParameters, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                newTypeParameters)
                {
                    var return_v = this_param.WithAlphaRename(oldTypeParameters, (Microsoft.CodeAnalysis.CSharp.Symbol)newOwner, out newTypeParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 6954, 7046);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10064, 6660, 7058);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10064, 6660, 7058);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeMap WithAlphaRename(MethodSymbol oldOwner, Symbol newOwner, out ImmutableArray<TypeParameterSymbol> newTypeParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10064, 7070, 7402);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 7226, 7277);

                f_10064_7226_7276(f_10064_7239_7263(oldOwner) == oldOwner);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 7291, 7391);

                return f_10064_7298_7390(this, f_10064_7314_7356(f_10064_7314_7341(oldOwner)), newOwner, out newTypeParameters);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10064, 7070, 7402);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10064_7239_7263(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10064, 7239, 7263);
                    return return_v;
                }


                int
                f_10064_7226_7276(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 7226, 7276);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10064_7314_7341(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10064, 7314, 7341);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10064_7314_7356(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10064, 7314, 7356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10064_7298_7390(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                oldTypeParameters, Microsoft.CodeAnalysis.CSharp.Symbol
                newOwner, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                newTypeParameters)
                {
                    var return_v = this_param.WithAlphaRename(oldTypeParameters, newOwner, out newTypeParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 7298, 7390);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10064, 7070, 7402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10064, 7070, 7402);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeMap WithConcatAlphaRename(
                    MethodSymbol oldOwner,
                    Symbol newOwner,
                    out ImmutableArray<TypeParameterSymbol> newTypeParameters,
                    out ImmutableArray<TypeParameterSymbol> oldTypeParameters,
                    MethodSymbol stopAt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10064, 7414, 9883);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 7729, 7780);

                f_10064_7729_7779(f_10064_7742_7766(oldOwner) == oldOwner);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 7794, 7859);

                f_10064_7794_7858(stopAt == null || (DynAbs.Tracing.TraceSender.Expression_False(10064, 7807, 7857) || f_10064_7825_7847(stopAt) == stopAt));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 8517, 8582);

                var
                parameters = f_10064_8534_8581()
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 8596, 9021) || true) && (oldOwner != null && (DynAbs.Tracing.TraceSender.Expression_True(10064, 8603, 8641) && oldOwner != stopAt))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10064, 8596, 9021);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 8675, 8742);

                        var
                        currentParameters = f_10064_8699_8741(f_10064_8699_8726(oldOwner))
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 8771, 8803);

                            for (int
            i = currentParameters.Length - 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 8762, 8914) || true) && (i >= 0)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 8813, 8816)
            , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10064, 8762, 8914))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10064, 8762, 8914);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 8858, 8895);

                                f_10064_8858_8894(parameters, currentParameters[i]);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10064, 1, 153);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10064, 1, 153);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 8934, 9006);

                        oldOwner = f_10064_8945_8989(f_10064_8945_8970(oldOwner)) as MethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10064, 8596, 9021);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10064, 8596, 9021);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10064, 8596, 9021);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 9035, 9064);

                f_10064_9035_9063(parameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 9528, 9715);

                f_10064_9528_9714(stopAt == oldOwner || (DynAbs.Tracing.TraceSender.Expression_False(10064, 9559, 9648) || f_10064_9598_9616_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(stopAt, 10064, 9598, 9616)?.MethodKind) == MethodKind.StaticConstructor) || (DynAbs.Tracing.TraceSender.Expression_False(10064, 9559, 9713) || f_10064_9669_9687_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(stopAt, 10064, 9669, 9687)?.MethodKind) == MethodKind.Constructor));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 9731, 9783);

                oldTypeParameters = f_10064_9751_9782(parameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 9797, 9872);

                return f_10064_9804_9871(this, oldTypeParameters, newOwner, out newTypeParameters);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10064, 7414, 9883);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10064_7742_7766(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10064, 7742, 7766);
                    return return_v;
                }


                int
                f_10064_7729_7779(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 7729, 7779);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10064_7825_7847(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10064, 7825, 7847);
                    return return_v;
                }


                int
                f_10064_7794_7858(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 7794, 7858);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10064_8534_8581()
                {
                    var return_v = ArrayBuilder<TypeParameterSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 8534, 8581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10064_8699_8726(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10064, 8699, 8726);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10064_8699_8741(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10064, 8699, 8741);
                    return return_v;
                }


                int
                f_10064_8858_8894(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 8858, 8894);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10064_8945_8970(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10064, 8945, 8970);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10064_8945_8989(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10064, 8945, 8989);
                    return return_v;
                }


                int
                f_10064_9035_9063(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param)
                {
                    this_param.ReverseContents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 9035, 9063);
                    return 0;
                }


                Microsoft.CodeAnalysis.MethodKind?
                f_10064_9598_9616_M(Microsoft.CodeAnalysis.MethodKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10064, 9598, 9616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind?
                f_10064_9669_9687_M(Microsoft.CodeAnalysis.MethodKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10064, 9669, 9687);
                    return return_v;
                }


                int
                f_10064_9528_9714(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 9528, 9714);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10064_9751_9782(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 9751, 9782);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10064_9804_9871(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                oldTypeParameters, Microsoft.CodeAnalysis.CSharp.Symbol
                newOwner, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                newTypeParameters)
                {
                    var return_v = this_param.WithAlphaRename(oldTypeParameters, newOwner, out newTypeParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 9804, 9871);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10064, 7414, 9883);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10064, 7414, 9883);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SmallDictionary<TypeParameterSymbol, TypeWithAnnotations> ConstructMapping(ImmutableArray<TypeParameterSymbol> from, ImmutableArray<TypeWithAnnotations> to)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10064, 9895, 10596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 10091, 10203);

                var
                mapping = f_10064_10105_10202(ReferenceEqualityComparer.Instance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 10219, 10258);

                f_10064_10219_10257(from.Length == to.Length);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 10283, 10288);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 10274, 10554) || true) && (i < from.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 10307, 10310)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10064, 10274, 10554))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10064, 10274, 10554);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 10344, 10377);

                        TypeParameterSymbol
                        tp = from[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 10395, 10426);

                        TypeWithAnnotations
                        ta = to[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 10444, 10539) || true) && (!ta.Is(tp))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10064, 10444, 10539);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 10500, 10520);

                            f_10064_10500_10519(mapping, tp, ta);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10064, 10444, 10539);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10064, 1, 281);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10064, 1, 281);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 10570, 10585);

                return mapping;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10064, 9895, 10596);

                Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10064_10105_10202(Roslyn.Utilities.ReferenceEqualityComparer
                comparer)
                {
                    var return_v = new Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 10105, 10202);
                    return return_v;
                }


                int
                f_10064_10219_10257(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 10219, 10257);
                    return 0;
                }


                int
                f_10064_10500_10519(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                key, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 10500, 10519);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10064, 9895, 10596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10064, 9895, 10596);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TypeMap()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10064, 674, 10603);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 808, 834);
            AsTypeSymbol = t => t.Type; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 4047, 4177);
            s_emptyDictionary = f_10064_4080_4177(ReferenceEqualityComparer.Instance); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10064, 4368, 4398);
            s_emptyTypeMap = f_10064_4385_4398(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10064, 674, 10603);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10064, 674, 10603);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10064, 674, 10603);

        static Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        f_10064_1928_1954(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        from, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        to)
        {
            var return_v = ConstructMapping(from, to);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 1928, 1954);
            return return_v;
        }


        int
        f_10064_2037_2118(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 2037, 2118);
            return 0;
        }


        static Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        f_10064_1928_1954_C(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10064, 1784, 2130);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        f_10064_2415_2461(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        typeParameters)
        {
            var return_v = TypeParametersAsTypeSymbolsWithAnnotations(typeParameters);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 2415, 2461);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        f_10064_2409_2413_C(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10064, 2265, 2553);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        f_10064_2668_2774(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        other, Roslyn.Utilities.ReferenceEqualityComparer
        comparer)
        {
            var return_v = new Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>(other, (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 2668, 2774);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        f_10064_2668_2774_C(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10064, 2565, 2854);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        f_10064_3582_3605(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        containingType)
        {
            var return_v = ForType(containingType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 3582, 3605);
            return return_v;
        }


        int
        f_10064_3888_3907(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
        key, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 3888, 3907);
            return 0;
        }


        static Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        f_10064_3582_3605_C(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10064, 3410, 3953);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        f_10064_4080_4177(Roslyn.Utilities.ReferenceEqualityComparer
        comparer)
        {
            var return_v = new Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 4080, 4177);
            return return_v;
        }


        bool
        f_10064_4284_4311(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        source)
        {
            var return_v = source.IsEmpty<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 4284, 4311);
            return return_v;
        }


        int
        f_10064_4271_4312(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 4271, 4312);
            return 0;
        }


        static Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        f_10064_4228_4245_C(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10064, 4190, 4324);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10064_4385_4398()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10064, 4385, 4398);
            return return_v;
        }

    }
}
