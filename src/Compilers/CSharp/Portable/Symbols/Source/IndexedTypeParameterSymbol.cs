// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class IndexedTypeParameterSymbol : TypeParameterSymbol
    {
        private static TypeParameterSymbol[] s_parameterPool;

        private readonly int _index;

        private IndexedTypeParameterSymbol(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10231, 1190, 1286);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 1171, 1177);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 1260, 1275);

                _index = index;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10231, 1190, 1286);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 1190, 1286);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 1190, 1286);
            }
        }

        public override TypeParameterKind TypeParameterKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10231, 1374, 1457);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 1410, 1442);

                    return TypeParameterKind.Method;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10231, 1374, 1457);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 1298, 1468);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 1298, 1468);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static TypeParameterSymbol GetTypeParameter(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10231, 1480, 1729);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 1568, 1672) || true) && (index >= f_10231_1581_1603(s_parameterPool))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10231, 1568, 1672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 1637, 1657);

                    f_10231_1637_1656(index + 1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10231, 1568, 1672);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 1688, 1718);

                return s_parameterPool[index];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10231, 1480, 1729);

                int
                f_10231_1581_1603(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10231, 1581, 1603);
                    return return_v;
                }


                int
                f_10231_1637_1656(int
                count)
                {
                    GrowPool(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10231, 1637, 1656);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 1480, 1729);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 1480, 1729);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void GrowPool(int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10231, 1741, 2637);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 1805, 1839);

                var
                initialPool = s_parameterPool
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 1853, 2626) || true) && (count > f_10231_1868_1886(initialPool))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10231, 1853, 2626);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 1920, 1962);

                        var
                        newPoolSize = ((count + 0x0F) & ~0xF)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 2008, 2059);

                        var
                        newPool = new TypeParameterSymbol[newPoolSize]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 2079, 2132);

                        f_10231_2079_2131(initialPool, newPool, f_10231_2112_2130(initialPool));
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 2161, 2183);

                            for (int
            i = f_10231_2165_2183(initialPool)
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 2152, 2316) || true) && (i < f_10231_2189_2203(newPool))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 2205, 2208)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10231, 2152, 2316))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10231, 2152, 2316);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 2250, 2297);

                                newPool[i] = f_10231_2263_2296(i);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10231, 1, 165);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10231, 1, 165);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 2336, 2407);

                        f_10231_2336_2406(ref s_parameterPool, newPool, initialPool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 2581, 2611);

                        initialPool = s_parameterPool;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10231, 1853, 2626);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10231, 1853, 2626);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10231, 1853, 2626);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10231, 1741, 2637);

                int
                f_10231_1868_1886(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10231, 1868, 1886);
                    return return_v;
                }


                int
                f_10231_2112_2130(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10231, 2112, 2130);
                    return return_v;
                }


                int
                f_10231_2079_2131(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol[]
                sourceArray, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol[]
                destinationArray, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, (System.Array)destinationArray, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10231, 2079, 2131);
                    return 0;
                }


                int
                f_10231_2165_2183(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10231, 2165, 2183);
                    return return_v;
                }


                int
                f_10231_2189_2203(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10231, 2189, 2203);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.IndexedTypeParameterSymbol
                f_10231_2263_2296(int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.IndexedTypeParameterSymbol(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10231, 2263, 2296);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol[]
                f_10231_2336_2406(ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol[]
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol[]
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol[]
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10231, 2336, 2406);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 1741, 2637);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 1741, 2637);
            }
        }

        internal static ImmutableArray<TypeParameterSymbol> TakeSymbols(int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10231, 2910, 3407);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 3009, 3108) || true) && (count > f_10231_3021_3043(s_parameterPool))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10231, 3009, 3108);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 3077, 3093);

                    f_10231_3077_3092(count);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10231, 3009, 3108);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 3124, 3216);

                ArrayBuilder<TypeParameterSymbol>
                builder = f_10231_3168_3215()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 3241, 3246);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 3232, 3344) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 3259, 3262)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10231, 3232, 3344))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10231, 3232, 3344);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 3296, 3329);

                        f_10231_3296_3328(builder, f_10231_3308_3327(i));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10231, 1, 113);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10231, 1, 113);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 3360, 3396);

                return f_10231_3367_3395(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10231, 2910, 3407);

                int
                f_10231_3021_3043(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10231, 3021, 3043);
                    return return_v;
                }


                int
                f_10231_3077_3092(int
                count)
                {
                    GrowPool(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10231, 3077, 3092);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10231_3168_3215()
                {
                    var return_v = ArrayBuilder<TypeParameterSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10231, 3168, 3215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                f_10231_3308_3327(int
                index)
                {
                    var return_v = GetTypeParameter(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10231, 3308, 3327);
                    return return_v;
                }


                int
                f_10231_3296_3328(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10231, 3296, 3328);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10231_3367_3395(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10231, 3367, 3395);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 2910, 3407);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 2910, 3407);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<TypeWithAnnotations> Take(int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10231, 3419, 3935);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 3511, 3610) || true) && (count > f_10231_3523_3545(s_parameterPool))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10231, 3511, 3610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 3579, 3595);

                    f_10231_3579_3594(count);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10231, 3511, 3610);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 3626, 3688);

                var
                builder = f_10231_3640_3687()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 3713, 3718);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 3704, 3872) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 3731, 3734)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10231, 3704, 3872))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10231, 3704, 3872);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 3768, 3857);

                        f_10231_3768_3856(builder, TypeWithAnnotations.Create(f_10231_3807_3826(i), NullableAnnotation.Ignored));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10231, 1, 169);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10231, 1, 169);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 3888, 3924);

                return f_10231_3895_3923(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10231, 3419, 3935);

                int
                f_10231_3523_3545(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10231, 3523, 3545);
                    return return_v;
                }


                int
                f_10231_3579_3594(int
                count)
                {
                    GrowPool(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10231, 3579, 3594);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10231_3640_3687()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10231, 3640, 3687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                f_10231_3807_3826(int
                index)
                {
                    var return_v = GetTypeParameter(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10231, 3807, 3826);
                    return return_v;
                }


                int
                f_10231_3768_3856(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10231, 3768, 3856);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10231_3895_3923(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10231, 3895, 3923);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 3419, 3935);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 3419, 3935);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Ordinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10231, 3999, 4021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 4005, 4019);

                    return _index;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10231, 3999, 4021);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 3947, 4032);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 3947, 4032);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool Equals(TypeSymbol t2, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10231, 4093, 4234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 4190, 4223);

                return f_10231_4197_4222(this, t2);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10231, 4093, 4234);

                bool
                f_10231_4197_4222(Microsoft.CodeAnalysis.CSharp.Symbols.IndexedTypeParameterSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10231, 4197, 4222);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 4093, 4234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 4093, 4234);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10231, 4246, 4329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 4304, 4318);

                return _index;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10231, 4246, 4329);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 4246, 4329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 4246, 4329);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override VarianceKind Variance
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10231, 4403, 4436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 4409, 4434);

                    return VarianceKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10231, 4403, 4436);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 4341, 4447);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 4341, 4447);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasValueTypeConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10231, 4527, 4548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 4533, 4546);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10231, 4527, 4548);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 4459, 4559);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 4459, 4559);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsValueTypeFromConstraintTypes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10231, 4647, 4668);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 4653, 4666);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10231, 4647, 4668);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 4571, 4679);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 4571, 4679);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasReferenceTypeConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10231, 4763, 4784);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 4769, 4782);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10231, 4763, 4784);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 4691, 4795);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 4691, 4795);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsReferenceTypeFromConstraintTypes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10231, 4887, 4908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 4893, 4906);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10231, 4887, 4908);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 4807, 4919);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 4807, 4919);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool? ReferenceTypeConstraintIsNullable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10231, 5013, 5034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 5019, 5032);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10231, 5013, 5034);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 4931, 5045);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 4931, 5045);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasNotNullConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10231, 5099, 5107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 5102, 5107);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10231, 5099, 5107);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 5099, 5107);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 5099, 5107);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool? IsNotNullable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10231, 5158, 5165);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 5161, 5165);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10231, 5158, 5165);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 5158, 5165);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 5158, 5165);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasUnmanagedTypeConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10231, 5250, 5271);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 5256, 5269);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10231, 5250, 5271);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 5178, 5282);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 5178, 5282);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasConstructorConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10231, 5364, 5385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 5370, 5383);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10231, 5364, 5385);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 5294, 5396);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 5294, 5396);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10231, 5472, 5535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 5508, 5520);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10231, 5472, 5535);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 5408, 5546);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 5408, 5546);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10231, 5633, 5722);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 5669, 5707);

                    return ImmutableArray<Location>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10231, 5633, 5722);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 5558, 5733);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 5558, 5733);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10231, 5843, 5939);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 5879, 5924);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10231, 5843, 5939);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 5745, 5950);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 5745, 5950);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void EnsureAllConstraintsAreResolved()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10231, 5962, 6040);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10231, 5962, 6040);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 5962, 6040);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 5962, 6040);
            }
        }

        internal override ImmutableArray<TypeWithAnnotations> GetConstraintTypes(ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10231, 6052, 6251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 6191, 6240);

                return ImmutableArray<TypeWithAnnotations>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10231, 6052, 6251);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 6052, 6251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 6052, 6251);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<NamedTypeSymbol> GetInterfaces(ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10231, 6263, 6449);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 6393, 6438);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10231, 6263, 6449);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 6263, 6449);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 6263, 6449);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol GetEffectiveBaseClass(ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10231, 6461, 6606);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 6583, 6595);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10231, 6461, 6606);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 6461, 6606);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 6461, 6606);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol GetDeducedBaseType(ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10231, 6618, 6755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 6732, 6744);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10231, 6618, 6755);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 6618, 6755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 6618, 6755);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10231, 6833, 6853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 6839, 6851);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10231, 6833, 6853);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10231, 6767, 6864);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 6767, 6864);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static IndexedTypeParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10231, 961, 6871);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10231, 1085, 1137);
            s_parameterPool = f_10231_1103_1137(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10231, 961, 6871);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10231, 961, 6871);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10231, 961, 6871);

        static Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol[]
        f_10231_1103_1137()
        {
            var return_v = Array.Empty<TypeParameterSymbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10231, 1103, 1137);
            return return_v;
        }

    }
}
