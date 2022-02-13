// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal static partial class SpecializedSymbolCollections
    {
        public static PooledHashSet<TSymbol> GetPooledSymbolHashSetInstance<TSymbol>() where TSymbol : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10155, 444, 729);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10155, 570, 640);

                var
                instance = f_10155_585_639<TSymbol>(PooledSymbolHashSet<TSymbol>.s_poolInstance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10155, 654, 688);

                f_10155_654_687<TSymbol>(f_10155_667_681<TSymbol>(instance) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10155, 702, 718);

                return instance;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10155, 444, 729);

                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<TSymbol>
                f_10155_585_639<TSymbol>(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<TSymbol>>
                this_param) where TSymbol : Symbol

                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10155, 585, 639);
                    return return_v;
                }


                int
                f_10155_667_681<TSymbol>(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<TSymbol>
                this_param) where TSymbol : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10155, 667, 681);
                    return return_v;
                }


                int
                f_10155_654_687<TSymbol>(bool
                condition) where TSymbol : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10155, 654, 687);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10155, 444, 729);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10155, 444, 729);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private static class PooledSymbolHashSet<TSymbol> where TSymbol : Symbol
        {
            internal static readonly ObjectPool<PooledHashSet<TSymbol>> s_poolInstance;

            static PooledSymbolHashSet()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10155, 741, 1003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10155, 898, 991);
                s_poolInstance = f_10155_915_991(SymbolEqualityComparer.ConsiderEverything); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10155, 741, 1003);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10155, 741, 1003);
            }


            static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<TSymbol>>
            f_10155_915_991(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
            equalityComparer)
            {
                var return_v = PooledHashSet<TSymbol>.CreatePool((System.Collections.Generic.IEqualityComparer<TSymbol>)equalityComparer);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10155, 915, 991);
                return return_v;
            }

        }

        public static PooledDictionary<KSymbol, V> GetPooledSymbolDictionaryInstance<KSymbol, V>() where KSymbol : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10155, 1015, 1318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10155, 1153, 1229);

                var
                instance = f_10155_1168_1228<KSymbol, V>(PooledSymbolDictionary<KSymbol, V>.s_poolInstance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10155, 1243, 1277);

                f_10155_1243_1276<KSymbol, V>(f_10155_1256_1270<KSymbol, V>(instance) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10155, 1291, 1307);

                return instance;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10155, 1015, 1318);

                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<KSymbol, V>
                f_10155_1168_1228<KSymbol, V>(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<KSymbol, V>>
                this_param) where KSymbol : Symbol

                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10155, 1168, 1228);
                    return return_v;
                }


                int
                f_10155_1256_1270<KSymbol, V>(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<KSymbol, V>
                this_param) where KSymbol : Symbol

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10155, 1256, 1270);
                    return return_v;
                }


                int
                f_10155_1243_1276<KSymbol, V>(bool
                condition) where KSymbol : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10155, 1243, 1276);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10155, 1015, 1318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10155, 1015, 1318);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private static class PooledSymbolDictionary<TSymbol, V> where TSymbol : Symbol
        {
            internal static readonly ObjectPool<PooledDictionary<TSymbol, V>> s_poolInstance;

            static PooledSymbolDictionary()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10155, 1330, 1610);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10155, 1499, 1598);
                s_poolInstance = f_10155_1516_1598(SymbolEqualityComparer.ConsiderEverything); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10155, 1330, 1610);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10155, 1330, 1610);
            }


            static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<TSymbol, V>>
            f_10155_1516_1598(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
            keyComparer)
            {
                var return_v = PooledDictionary<TSymbol, V>.CreatePool((System.Collections.Generic.IEqualityComparer<TSymbol>)keyComparer);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10155, 1516, 1598);
                return return_v;
            }

        }

        static SpecializedSymbolCollections()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10155, 369, 1617);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10155, 369, 1617);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10155, 369, 1617);
        }

    }
}
