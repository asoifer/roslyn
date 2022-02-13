// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Globalization;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal abstract class Symbol : ISymbol
    {
        internal abstract CSharp.Symbol UnderlyingSymbol { get; }

        protected static ImmutableArray<TypeWithAnnotations> ConstructTypeArguments(ITypeSymbol[] typeArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10658, 576, 1236);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 705, 787);

                var
                builder = f_10658_719_786(f_10658_765_785(typeArguments))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 801, 1173);
                    foreach (var typeArg in f_10658_825_838_I(typeArguments))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10658, 801, 1173);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 872, 939);

                        var
                        type = f_10658_883_938(typeArg, nameof(typeArguments))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 984, 1158);

                        f_10658_984_1157(                // LAFHIS
                                        builder, TypeWithAnnotations.Create(type, ((DynAbs.Tracing.TraceSender.Conditional_F1(10658, 1052, 1067) || ((typeArg != null && DynAbs.Tracing.TraceSender.Conditional_F2(10658, 1070, 1119)) || DynAbs.Tracing.TraceSender.Conditional_F3(10658, 1123, 1154))) ? f_10658_1070_1119(f_10658_1070_1096(typeArg)) : NullableAnnotation.NotAnnotated)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10658, 801, 1173);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10658, 1, 373);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10658, 1, 373);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 1189, 1225);

                return f_10658_1196_1224(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10658, 576, 1236);

                int
                f_10658_765_785(Microsoft.CodeAnalysis.ITypeSymbol[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 765, 785);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10658_719_786(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 719, 786);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10658_883_938(Microsoft.CodeAnalysis.ITypeSymbol
                symbol, string
                paramName)
                {
                    var return_v = symbol.EnsureCSharpSymbolOrNull(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 883, 938);
                    return return_v;
                }


                Microsoft.CodeAnalysis.NullableAnnotation
                f_10658_1070_1096(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.NullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 1070, 1096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                f_10658_1070_1119(Microsoft.CodeAnalysis.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.ToInternalAnnotation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 1070, 1119);
                    return return_v;
                }


                int
                f_10658_984_1157(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 984, 1157);
                    return 0;
                }


                Microsoft.CodeAnalysis.ITypeSymbol[]
                f_10658_825_838_I(Microsoft.CodeAnalysis.ITypeSymbol[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 825, 838);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10658_1196_1224(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 1196, 1224);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 576, 1236);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 576, 1236);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static ImmutableArray<TypeWithAnnotations> ConstructTypeArguments(ImmutableArray<ITypeSymbol> typeArguments, ImmutableArray<CodeAnalysis.NullableAnnotation> typeArgumentNullableAnnotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10658, 1248, 2420);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 1472, 1599) || true) && (typeArguments.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10658, 1472, 1599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 1533, 1584);

                    throw f_10658_1539_1583(nameof(typeArguments));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10658, 1472, 1599);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 1615, 1644);

                int
                n = typeArguments.Length
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 1658, 1869) || true) && (f_10658_1662_1704_M(!typeArgumentNullableAnnotations.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(10658, 1662, 1751) && typeArgumentNullableAnnotations.Length != n))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10658, 1658, 1869);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 1785, 1854);

                    throw f_10658_1791_1853(nameof(typeArgumentNullableAnnotations));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10658, 1658, 1869);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 1885, 1948);

                var
                builder = f_10658_1899_1947(n)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 1971, 1976);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 1962, 2357) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 1985, 1988)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10658, 1962, 2357))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10658, 1962, 2357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 2022, 2098);

                        var
                        type = f_10658_2033_2097(typeArguments[i], nameof(typeArguments))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 2116, 2266);

                        var
                        annotation = (DynAbs.Tracing.TraceSender.Conditional_F1(10658, 2133, 2174) || ((typeArgumentNullableAnnotations.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10658, 2177, 2205)) || DynAbs.Tracing.TraceSender.Conditional_F3(10658, 2208, 2265))) ? NullableAnnotation.Oblivious : f_10658_2208_2265(typeArgumentNullableAnnotations[i])
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 2284, 2342);

                        f_10658_2284_2341(builder, TypeWithAnnotations.Create(type, annotation));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10658, 1, 396);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10658, 1, 396);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 2373, 2409);

                return f_10658_2380_2408(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10658, 1248, 2420);

                System.ArgumentException
                f_10658_1539_1583(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 1539, 1583);
                    return return_v;
                }


                bool
                f_10658_1662_1704_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 1662, 1704);
                    return return_v;
                }


                System.ArgumentException
                f_10658_1791_1853(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 1791, 1853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10658_1899_1947(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 1899, 1947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10658_2033_2097(Microsoft.CodeAnalysis.ITypeSymbol
                symbol, string
                paramName)
                {
                    var return_v = symbol.EnsureCSharpSymbolOrNull(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 2033, 2097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                f_10658_2208_2265(Microsoft.CodeAnalysis.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.ToInternalAnnotation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 2208, 2265);
                    return return_v;
                }


                int
                f_10658_2284_2341(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 2284, 2341);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10658_2380_2408(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 2380, 2408);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 1248, 2420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 1248, 2420);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ISymbol ISymbol.OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 2491, 2603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 2527, 2588);

                    return f_10658_2534_2587(f_10658_2534_2569(f_10658_2534_2550()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 2491, 2603);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10658_2534_2550()
                    {
                        var return_v = UnderlyingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 2534, 2550);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10658_2534_2569(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 2534, 2569);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ISymbol?
                    f_10658_2534_2587(Microsoft.CodeAnalysis.CSharp.Symbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 2534, 2587);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 2432, 2614);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 2432, 2614);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ISymbol ISymbol.ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 2683, 2793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 2719, 2778);

                    return f_10658_2726_2777(f_10658_2726_2759(f_10658_2726_2742()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 2683, 2793);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10658_2726_2742()
                    {
                        var return_v = UnderlyingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 2726, 2742);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10658_2726_2759(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 2726, 2759);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ISymbol?
                    f_10658_2726_2777(Microsoft.CodeAnalysis.CSharp.Symbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 2726, 2777);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 2626, 2804);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 2626, 2804);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        INamedTypeSymbol ISymbol.ContainingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 2880, 2988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 2916, 2973);

                    return f_10658_2923_2972(f_10658_2923_2954(f_10658_2923_2939()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 2880, 2988);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10658_2923_2939()
                    {
                        var return_v = UnderlyingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 2923, 2939);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10658_2923_2954(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 2923, 2954);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamedTypeSymbol?
                    f_10658_2923_2972(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 2923, 2972);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 2816, 2999);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 2816, 2999);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 3011, 3125);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 3076, 3114);

                return f_10658_3083_3113(f_10658_3083_3099());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 3011, 3125);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10658_3083_3099()
                {
                    var return_v = UnderlyingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 3083, 3099);
                    return return_v;
                }


                int
                f_10658_3083_3113(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 3083, 3113);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 3011, 3125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 3011, 3125);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 3137, 3298);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 3208, 3287);

                return f_10658_3215_3286(this, obj as Symbol, CodeAnalysis.SymbolEqualityComparer.Default);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 3137, 3298);

                bool
                f_10658_3215_3286(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.Symbol
                this_param, object
                other, Microsoft.CodeAnalysis.SymbolEqualityComparer
                equalityComparer)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.Symbol?)other, equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 3215, 3286);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 3137, 3298);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 3137, 3298);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool IEquatable<ISymbol>.Equals(ISymbol other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 3310, 3473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 3381, 3462);

                return f_10658_3388_3461(this, other as Symbol, CodeAnalysis.SymbolEqualityComparer.Default);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 3310, 3473);

                bool
                f_10658_3388_3461(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.Symbol
                this_param, Microsoft.CodeAnalysis.ISymbol
                other, Microsoft.CodeAnalysis.SymbolEqualityComparer
                equalityComparer)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.Symbol?)other, equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 3388, 3461);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 3310, 3473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 3310, 3473);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool ISymbol.Equals(ISymbol other, CodeAnalysis.SymbolEqualityComparer equalityComparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 3485, 3663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 3598, 3652);

                return f_10658_3605_3651(this, other as Symbol, equalityComparer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 3485, 3663);

                bool
                f_10658_3605_3651(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.Symbol
                this_param, Microsoft.CodeAnalysis.ISymbol
                other, Microsoft.CodeAnalysis.SymbolEqualityComparer
                equalityComparer)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.Symbol?)other, equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 3605, 3651);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 3485, 3663);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 3485, 3663);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected bool Equals(Symbol other, CodeAnalysis.SymbolEqualityComparer equalityComparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 3675, 3904);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 3789, 3893);

                return other is object && (DynAbs.Tracing.TraceSender.Expression_True(10658, 3796, 3892) && f_10658_3815_3892(f_10658_3815_3831(), f_10658_3839_3861(other), f_10658_3863_3891(equalityComparer)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 3675, 3904);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10658_3815_3831()
                {
                    var return_v = UnderlyingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 3815, 3831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10658_3839_3861(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.Symbol
                this_param)
                {
                    var return_v = this_param.UnderlyingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 3839, 3861);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeCompareKind
                f_10658_3863_3891(Microsoft.CodeAnalysis.SymbolEqualityComparer
                this_param)
                {
                    var return_v = this_param.CompareKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 3863, 3891);
                    return return_v;
                }


                bool
                f_10658_3815_3892(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 3815, 3892);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 3675, 3904);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 3675, 3904);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<Location> ISymbol.Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 3983, 4068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 4019, 4053);

                    return f_10658_4026_4052(f_10658_4026_4042());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 3983, 4068);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10658_4026_4042()
                    {
                        var return_v = UnderlyingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 4026, 4042);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10658_4026_4052(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 4026, 4052);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 3916, 4079);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 3916, 4079);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<SyntaxReference> ISymbol.DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 4181, 4282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 4217, 4267);

                    return f_10658_4224_4266(f_10658_4224_4240());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 4181, 4282);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10658_4224_4240()
                    {
                        var return_v = UnderlyingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 4224, 4240);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10658_4224_4266(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.DeclaringSyntaxReferences;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 4224, 4266);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 4091, 4293);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 4091, 4293);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<AttributeData> ISymbol.GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 4305, 4466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 4383, 4455);

                return f_10658_4390_4454(f_10658_4421_4453(f_10658_4421_4437()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 4305, 4466);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10658_4421_4437()
                {
                    var return_v = UnderlyingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 4421, 4437);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10658_4421_4453(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 4421, 4453);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AttributeData>
                f_10658_4390_4454(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                from)
                {
                    var return_v = StaticCast<AttributeData>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 4390, 4454);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 4305, 4466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 4305, 4466);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Accessibility ISymbol.DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 4546, 4643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 4582, 4628);

                    return f_10658_4589_4627(f_10658_4589_4605());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 4546, 4643);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10658_4589_4605()
                    {
                        var return_v = UnderlyingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 4589, 4605);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Accessibility
                    f_10658_4589_4627(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.DeclaredAccessibility;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 4589, 4627);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 4478, 4654);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 4478, 4654);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        void ISymbol.Accept(SymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 4666, 4760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 4733, 4749);

                f_10658_4733_4748(this, visitor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 4666, 4760);

                int
                f_10658_4733_4748(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.Symbol
                this_param, Microsoft.CodeAnalysis.SymbolVisitor
                visitor)
                {
                    this_param.Accept(visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 4733, 4748);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 4666, 4760);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 4666, 4760);
            }
        }

        protected abstract void Accept(SymbolVisitor visitor);

        TResult ISymbol.Accept<TResult>(SymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 4838, 4960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 4926, 4949);

                return f_10658_4933_4948<TResult>(this, visitor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 4838, 4960);

                TResult
                f_10658_4933_4948<TResult>(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.Symbol
                this_param, Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                visitor)
                {
                    var return_v = this_param.Accept<TResult>(visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 4933, 4948);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 4838, 4960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 4838, 4960);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract TResult Accept<TResult>(SymbolVisitor<TResult> visitor);

        string ISymbol.GetDocumentationCommentId()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 5059, 5189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 5126, 5178);

                return f_10658_5133_5177(f_10658_5133_5149());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 5059, 5189);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10658_5133_5149()
                {
                    var return_v = UnderlyingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 5133, 5149);
                    return return_v;
                }


                string
                f_10658_5133_5177(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetDocumentationCommentId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 5133, 5177);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 5059, 5189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 5059, 5189);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        string ISymbol.GetDocumentationCommentXml(CultureInfo preferredCulture, bool expandIncludes, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 5201, 5470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 5355, 5459);

                return f_10658_5362_5458(f_10658_5362_5378(), preferredCulture, expandIncludes, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 5201, 5470);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10658_5362_5378()
                {
                    var return_v = UnderlyingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 5362, 5378);
                    return return_v;
                }


                string
                f_10658_5362_5458(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, System.Globalization.CultureInfo
                preferredCulture, bool
                expandIncludes, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 5362, 5458);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 5201, 5470);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 5201, 5470);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        string ISymbol.ToDisplayString(SymbolDisplayFormat format)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 5482, 5627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 5565, 5616);

                return f_10658_5572_5615(this, format);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 5482, 5627);

                string
                f_10658_5572_5615(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.Symbol
                symbol, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = SymbolDisplay.ToDisplayString((Microsoft.CodeAnalysis.ISymbol)symbol, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 5572, 5615);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 5482, 5627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 5482, 5627);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<SymbolDisplayPart> ISymbol.ToDisplayParts(SymbolDisplayFormat format)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 5639, 5809);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 5748, 5798);

                return f_10658_5755_5797(this, format);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 5639, 5809);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_10658_5755_5797(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.Symbol
                symbol, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = SymbolDisplay.ToDisplayParts((Microsoft.CodeAnalysis.ISymbol)symbol, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 5755, 5797);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 5639, 5809);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 5639, 5809);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        string ISymbol.ToMinimalDisplayString(SemanticModel semanticModel, int position, SymbolDisplayFormat format)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 5821, 6072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 5954, 6061);

                return f_10658_5961_6060(this, f_10658_6004_6041(semanticModel), position, format);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 5821, 6072);

                Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                f_10658_6004_6041(Microsoft.CodeAnalysis.SemanticModel
                semanticModel)
                {
                    var return_v = GetCSharpSemanticModel(semanticModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 6004, 6041);
                    return return_v;
                }


                string
                f_10658_5961_6060(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                semanticModel, int
                position, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = SymbolDisplay.ToMinimalDisplayString((Microsoft.CodeAnalysis.ISymbol)symbol, (Microsoft.CodeAnalysis.SemanticModel)semanticModel, position, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 5961, 6060);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 5821, 6072);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 5821, 6072);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<SymbolDisplayPart> ISymbol.ToMinimalDisplayParts(SemanticModel semanticModel, int position, SymbolDisplayFormat format)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 6084, 6360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 6243, 6349);

                return f_10658_6250_6348(this, f_10658_6292_6329(semanticModel), position, format);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 6084, 6360);

                Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                f_10658_6292_6329(Microsoft.CodeAnalysis.SemanticModel
                semanticModel)
                {
                    var return_v = GetCSharpSemanticModel(semanticModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 6292, 6329);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_10658_6250_6348(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                semanticModel, int
                position, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = SymbolDisplay.ToMinimalDisplayParts((Microsoft.CodeAnalysis.ISymbol)symbol, (Microsoft.CodeAnalysis.SemanticModel)semanticModel, position, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 6250, 6348);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 6084, 6360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 6084, 6360);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CSharpSemanticModel GetCSharpSemanticModel(SemanticModel semanticModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10658, 6372, 6761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 6484, 6539);

                var
                csharpModel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 6553, 6715) || true) && (csharpModel == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10658, 6553, 6715);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 6610, 6700);

                    throw f_10658_6616_6699(f_10658_6638_6676(), LanguageNames.CSharp);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10658, 6553, 6715);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 6731, 6750);

                return csharpModel;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10658, 6372, 6761);

                string
                f_10658_6638_6676()
                {
                    var return_v = CSharpResources.WrongSemanticModelType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 6638, 6676);
                    return return_v;
                }


                System.ArgumentException
                f_10658_6616_6699(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 6616, 6699);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 6372, 6761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 6372, 6761);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        SymbolKind ISymbol.Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 6797, 6821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 6800, 6821);
                    return f_10658_6800_6821(f_10658_6800_6816()); DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 6797, 6821);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 6797, 6821);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 6797, 6821);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        string ISymbol.Language
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 6858, 6881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 6861, 6881);
                    return LanguageNames.CSharp; DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 6858, 6881);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 6858, 6881);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 6858, 6881);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        string ISymbol.Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 6914, 6938);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 6917, 6938);
                    return f_10658_6917_6938(f_10658_6917_6933()); DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 6914, 6938);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 6914, 6938);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 6914, 6938);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        string ISymbol.MetadataName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 6979, 7011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 6982, 7011);
                    return f_10658_6982_7011(f_10658_6982_6998()); DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 6979, 7011);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 6979, 7011);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 6979, 7011);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IAssemblySymbol ISymbol.ContainingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 7067, 7123);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 7070, 7123);
                    return f_10658_7070_7123(f_10658_7070_7105(f_10658_7070_7086())); DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 7067, 7123);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 7067, 7123);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 7067, 7123);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IModuleSymbol ISymbol.ContainingModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 7175, 7229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 7178, 7229);
                    return f_10658_7178_7229(f_10658_7178_7211(f_10658_7178_7194())); DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 7175, 7229);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 7175, 7229);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 7175, 7229);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        INamespaceSymbol ISymbol.ContainingNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 7287, 7344);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 7290, 7344);
                    return f_10658_7290_7344(f_10658_7290_7326(f_10658_7290_7306())); DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 7287, 7344);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 7287, 7344);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 7287, 7344);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISymbol.IsDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 7383, 7415);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 7386, 7415);
                    return f_10658_7386_7415(f_10658_7386_7402()); DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 7383, 7415);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 7383, 7415);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 7383, 7415);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISymbol.IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 7474, 7515);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 7480, 7513);

                    return f_10658_7487_7512(f_10658_7487_7503());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 7474, 7515);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10658_7487_7503()
                    {
                        var return_v = UnderlyingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 7487, 7503);
                        return return_v;
                    }


                    bool
                    f_10658_7487_7512(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 7487, 7512);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 7428, 7526);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 7428, 7526);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISymbol.IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 7585, 7627);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 7591, 7625);

                    return f_10658_7598_7624(f_10658_7598_7614());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 7585, 7627);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10658_7598_7614()
                    {
                        var return_v = UnderlyingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 7598, 7614);
                        return return_v;
                    }


                    bool
                    f_10658_7598_7624(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.IsVirtual;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 7598, 7624);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 7538, 7638);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 7538, 7638);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISymbol.IsOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 7698, 7741);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 7704, 7739);

                    return f_10658_7711_7738(f_10658_7711_7727());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 7698, 7741);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10658_7711_7727()
                    {
                        var return_v = UnderlyingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 7711, 7727);
                        return return_v;
                    }


                    bool
                    f_10658_7711_7738(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.IsOverride;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 7711, 7738);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 7650, 7752);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 7650, 7752);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISymbol.IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 7812, 7898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 7848, 7883);

                    return f_10658_7855_7882(f_10658_7855_7871());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 7812, 7898);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10658_7855_7871()
                    {
                        var return_v = UnderlyingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 7855, 7871);
                        return return_v;
                    }


                    bool
                    f_10658_7855_7882(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.IsAbstract;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 7855, 7882);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 7764, 7909);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 7764, 7909);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISymbol.IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 7967, 8051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 8003, 8036);

                    return f_10658_8010_8035(f_10658_8010_8026());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 7967, 8051);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10658_8010_8026()
                    {
                        var return_v = UnderlyingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 8010, 8026);
                        return return_v;
                    }


                    bool
                    f_10658_8010_8035(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.IsSealed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 8010, 8035);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 7921, 8062);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 7921, 8062);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISymbol.IsExtern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 8096, 8124);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 8099, 8124);
                    return f_10658_8099_8124(f_10658_8099_8115()); DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 8096, 8124);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 8096, 8124);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 8096, 8124);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISymbol.IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 8171, 8211);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 8174, 8211);
                    return f_10658_8174_8211(f_10658_8174_8190()); DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 8171, 8211);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 8171, 8211);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 8171, 8211);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISymbol.CanBeReferencedByName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 8259, 8300);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 8262, 8300);
                    return f_10658_8262_8300(f_10658_8262_8278()); DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 8259, 8300);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 8259, 8300);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 8259, 8300);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISymbol.HasUnsupportedMetadata
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 8349, 8391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 8352, 8391);
                    return f_10658_8352_8391(f_10658_8352_8368()); DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 8349, 8391);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 8349, 8391);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 8349, 8391);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10658, 8404, 8523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10658, 8469, 8512);

                return f_10658_8476_8511(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10658, 8404, 8523);

                string
                f_10658_8476_8511(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.Symbol
                symbol)
                {
                    var return_v = SymbolDisplay.ToDisplayString((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 8476, 8511);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10658, 8404, 8523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 8404, 8523);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Symbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10658, 450, 8530);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10658, 450, 8530);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 450, 8530);
        }


        static Symbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10658, 450, 8530);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10658, 450, 8530);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10658, 450, 8530);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10658, 450, 8530);

        Microsoft.CodeAnalysis.CSharp.Symbol
        f_10658_6800_6816()
        {
            var return_v = UnderlyingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 6800, 6816);
            return return_v;
        }


        Microsoft.CodeAnalysis.SymbolKind
        f_10658_6800_6821(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 6800, 6821);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbol
        f_10658_6917_6933()
        {
            var return_v = UnderlyingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 6917, 6933);
            return return_v;
        }


        string
        f_10658_6917_6938(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 6917, 6938);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbol
        f_10658_6982_6998()
        {
            var return_v = UnderlyingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 6982, 6998);
            return return_v;
        }


        string
        f_10658_6982_7011(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.MetadataName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 6982, 7011);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbol
        f_10658_7070_7086()
        {
            var return_v = UnderlyingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 7070, 7086);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10658_7070_7105(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 7070, 7105);
            return return_v;
        }


        Microsoft.CodeAnalysis.IAssemblySymbol?
        f_10658_7070_7123(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        symbol)
        {
            var return_v = symbol.GetPublicSymbol();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 7070, 7123);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbol
        f_10658_7178_7194()
        {
            var return_v = UnderlyingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 7178, 7194);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
        f_10658_7178_7211(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.ContainingModule;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 7178, 7211);
            return return_v;
        }


        Microsoft.CodeAnalysis.IModuleSymbol?
        f_10658_7178_7229(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
        symbol)
        {
            var return_v = symbol.GetPublicSymbol();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 7178, 7229);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbol
        f_10658_7290_7306()
        {
            var return_v = UnderlyingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 7290, 7306);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        f_10658_7290_7326(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.ContainingNamespace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 7290, 7326);
            return return_v;
        }


        Microsoft.CodeAnalysis.INamespaceSymbol?
        f_10658_7290_7344(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        symbol)
        {
            var return_v = symbol.GetPublicSymbol();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10658, 7290, 7344);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbol
        f_10658_7386_7402()
        {
            var return_v = UnderlyingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 7386, 7402);
            return return_v;
        }


        bool
        f_10658_7386_7415(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.IsDefinition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 7386, 7415);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbol
        f_10658_8099_8115()
        {
            var return_v = UnderlyingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 8099, 8115);
            return return_v;
        }


        bool
        f_10658_8099_8124(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.IsExtern;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 8099, 8124);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbol
        f_10658_8174_8190()
        {
            var return_v = UnderlyingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 8174, 8190);
            return return_v;
        }


        bool
        f_10658_8174_8211(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.IsImplicitlyDeclared;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 8174, 8211);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbol
        f_10658_8262_8278()
        {
            var return_v = UnderlyingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 8262, 8278);
            return return_v;
        }


        bool
        f_10658_8262_8300(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.CanBeReferencedByName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 8262, 8300);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbol
        f_10658_8352_8368()
        {
            var return_v = UnderlyingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 8352, 8368);
            return return_v;
        }


        bool
        f_10658_8352_8391(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.HasUnsupportedMetadata;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10658, 8352, 8391);
            return return_v;
        }

    }
}
