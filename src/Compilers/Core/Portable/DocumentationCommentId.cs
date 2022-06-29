// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public static class DocumentationCommentId
    {
        private class ListPool<T> : ObjectPool<List<T>>
        {
            public ListPool()
            : base(f_12_794_815_C(() => new List<T>(10)), 10)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(12, 752, 837);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(12, 752, 837);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 752, 837);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 752, 837);
                }
            }

            public void ClearAndFree(List<T> list)
            {
                list.Clear();
                base.Free(list);
            }

            [Obsolete("Do not use Free, Use ClearAndFree instead.", error: true)]
            public new void Free(List<T> list)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 1002, 1201);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 1152, 1186);

                    throw f_12_1158_1185();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(12, 1002, 1201);

                    System.NotSupportedException
                    f_12_1158_1185()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 1158, 1185);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 1002, 1201);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 1002, 1201);
                }
            }

            static ListPool()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(12, 680, 1212);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(12, 680, 1212);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 680, 1212);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(12, 680, 1212);

            static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.List<T>>.Factory
            f_12_794_815_C(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.List<T>>.Factory
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(12, 752, 837);
                return return_v;
            }

        }

        private static readonly ListPool<ISymbol> s_symbolListPool;

        private static readonly ListPool<INamespaceOrTypeSymbol> s_namespaceOrTypeListPool;

        public static string CreateDeclarationId(ISymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 1667, 2066);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 1748, 1863) || true) && (symbol == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 1748, 1863);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 1800, 1848);

                    throw f_12_1806_1847(nameof(symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 1748, 1863);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 1879, 1913);

                var
                builder = f_12_1893_1912()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 1927, 1977);

                var
                generator = f_12_1943_1976(builder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 1991, 2015);

                f_12_1991_2014(generator, symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 2029, 2055);

                return f_12_2036_2054(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 1667, 2066);

                System.ArgumentNullException
                f_12_1806_1847(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 1806, 1847);
                    return return_v;
                }


                System.Text.StringBuilder
                f_12_1893_1912()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 1893, 1912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DocumentationCommentId.DeclarationGenerator
                f_12_1943_1976(System.Text.StringBuilder
                builder)
                {
                    var return_v = new Microsoft.CodeAnalysis.DocumentationCommentId.DeclarationGenerator(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 1943, 1976);
                    return return_v;
                }


                int
                f_12_1991_2014(Microsoft.CodeAnalysis.DocumentationCommentId.DeclarationGenerator
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    this_param.Visit(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 1991, 2014);
                    return 0;
                }


                string
                f_12_2036_2054(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 2036, 2054);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 1667, 2066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 1667, 2066);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string CreateReferenceId(ISymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 2281, 2834);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 2360, 2475) || true) && (symbol == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 2360, 2475);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 2412, 2460);

                    throw f_12_2418_2459(nameof(symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 2360, 2475);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 2491, 2605) || true) && (symbol is INamespaceSymbol)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 2491, 2605);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 2555, 2590);

                    return f_12_2562_2589(symbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 2491, 2605);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 2621, 2655);

                var
                builder = f_12_2635_2654()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 2669, 2745);

                var
                generator = f_12_2685_2744(builder, typeParameterContext: null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 2759, 2783);

                f_12_2759_2782(generator, symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 2797, 2823);

                return f_12_2804_2822(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 2281, 2834);

                System.ArgumentNullException
                f_12_2418_2459(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 2418, 2459);
                    return return_v;
                }


                string
                f_12_2562_2589(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = CreateDeclarationId(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 2562, 2589);
                    return return_v;
                }


                System.Text.StringBuilder
                f_12_2635_2654()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 2635, 2654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DocumentationCommentId.ReferenceGenerator
                f_12_2685_2744(System.Text.StringBuilder
                builder, Microsoft.CodeAnalysis.ISymbol?
                typeParameterContext)
                {
                    var return_v = new Microsoft.CodeAnalysis.DocumentationCommentId.ReferenceGenerator(builder, typeParameterContext: typeParameterContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 2685, 2744);
                    return return_v;
                }


                bool
                f_12_2759_2782(Microsoft.CodeAnalysis.DocumentationCommentId.ReferenceGenerator
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = this_param.Visit(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 2759, 2782);
                    return return_v;
                }


                string
                f_12_2804_2822(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 2804, 2822);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 2281, 2834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 2281, 2834);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<ISymbol> GetSymbolsForDeclarationId(string id, Compilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 2972, 3694);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 3097, 3204) || true) && (id == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 3097, 3204);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 3145, 3189);

                    throw f_12_3151_3188(nameof(id));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 3097, 3204);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 3220, 3345) || true) && (compilation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 3220, 3345);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 3277, 3330);

                    throw f_12_3283_3329(nameof(compilation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 3220, 3345);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 3361, 3403);

                var
                results = f_12_3375_3402(s_symbolListPool)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 3453, 3508);

                    f_12_3453_3507(id, compilation, results);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 3526, 3560);

                    return f_12_3533_3559(results);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(12, 3589, 3683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 3629, 3668);

                    f_12_3629_3667(s_symbolListPool, results);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(12, 3589, 3683);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 2972, 3694);

                System.ArgumentNullException
                f_12_3151_3188(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 3151, 3188);
                    return return_v;
                }


                System.ArgumentNullException
                f_12_3283_3329(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 3283, 3329);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                f_12_3375_3402(Microsoft.CodeAnalysis.DocumentationCommentId.ListPool<Microsoft.CodeAnalysis.ISymbol>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 3375, 3402);
                    return return_v;
                }


                bool
                f_12_3453_3507(string
                id, Microsoft.CodeAnalysis.Compilation
                compilation, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                results)
                {
                    var return_v = Parser.ParseDeclaredSymbolId(id, compilation, results);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 3453, 3507);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_12_3533_3559(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                items)
                {
                    var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.ISymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 3533, 3559);
                    return return_v;
                }


                int
                f_12_3629_3667(Microsoft.CodeAnalysis.DocumentationCommentId.ListPool<Microsoft.CodeAnalysis.ISymbol>
                this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                list)
                {
                    this_param.ClearAndFree(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 3629, 3667);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 2972, 3694);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 2972, 3694);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryGetSymbolsForDeclarationId(string id, Compilation compilation, List<ISymbol> results)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 3901, 4504);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 4034, 4141) || true) && (id == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 4034, 4141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 4082, 4126);

                    throw f_12_4088_4125(nameof(id));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 4034, 4141);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 4157, 4282) || true) && (compilation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 4157, 4282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 4214, 4267);

                    throw f_12_4220_4266(nameof(compilation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 4157, 4282);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 4298, 4415) || true) && (results == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 4298, 4415);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 4351, 4400);

                    throw f_12_4357_4399(nameof(results));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 4298, 4415);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 4431, 4493);

                return f_12_4438_4492(id, compilation, results);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 3901, 4504);

                System.ArgumentNullException
                f_12_4088_4125(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 4088, 4125);
                    return return_v;
                }


                System.ArgumentNullException
                f_12_4220_4266(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 4220, 4266);
                    return return_v;
                }


                System.ArgumentNullException
                f_12_4357_4399(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 4357, 4399);
                    return return_v;
                }


                bool
                f_12_4438_4492(string
                id, Microsoft.CodeAnalysis.Compilation
                compilation, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                results)
                {
                    var return_v = Parser.ParseDeclaredSymbolId(id, compilation, results);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 4438, 4492);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 3901, 4504);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 3901, 4504);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ISymbol? GetFirstSymbolForDeclarationId(string id, Compilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 4667, 5390);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 4781, 4888) || true) && (id == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 4781, 4888);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 4829, 4873);

                    throw f_12_4835_4872(nameof(id));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 4781, 4888);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 4904, 5029) || true) && (compilation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 4904, 5029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 4961, 5014);

                    throw f_12_4967_5013(nameof(compilation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 4904, 5029);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 5045, 5087);

                var
                results = f_12_5059_5086(s_symbolListPool)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 5137, 5192);

                    f_12_5137_5191(id, compilation, results);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 5210, 5256);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(12, 5217, 5235) || ((f_12_5217_5230(results) == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(12, 5238, 5242)) || DynAbs.Tracing.TraceSender.Conditional_F3(12, 5245, 5255))) ? null : f_12_5245_5255(results, 0);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(12, 5285, 5379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 5325, 5364);

                    f_12_5325_5363(s_symbolListPool, results);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(12, 5285, 5379);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 4667, 5390);

                System.ArgumentNullException
                f_12_4835_4872(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 4835, 4872);
                    return return_v;
                }


                System.ArgumentNullException
                f_12_4967_5013(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 4967, 5013);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                f_12_5059_5086(Microsoft.CodeAnalysis.DocumentationCommentId.ListPool<Microsoft.CodeAnalysis.ISymbol>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 5059, 5086);
                    return return_v;
                }


                bool
                f_12_5137_5191(string
                id, Microsoft.CodeAnalysis.Compilation
                compilation, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                results)
                {
                    var return_v = Parser.ParseDeclaredSymbolId(id, compilation, results);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 5137, 5191);
                    return return_v;
                }


                int
                f_12_5217_5230(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 5217, 5230);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_12_5245_5255(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 5245, 5255);
                    return return_v;
                }


                int
                f_12_5325_5363(Microsoft.CodeAnalysis.DocumentationCommentId.ListPool<Microsoft.CodeAnalysis.ISymbol>
                this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                list)
                {
                    this_param.ClearAndFree(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 5325, 5363);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 4667, 5390);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 4667, 5390);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<ISymbol> GetSymbolsForReferenceId(string id, Compilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 5515, 6234);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 5638, 5745) || true) && (id == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 5638, 5745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 5686, 5730);

                    throw f_12_5692_5729(nameof(id));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 5638, 5745);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 5761, 5886) || true) && (compilation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 5761, 5886);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 5818, 5871);

                    throw f_12_5824_5870(nameof(compilation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 5761, 5886);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 5902, 5944);

                var
                results = f_12_5916_5943(s_symbolListPool)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 5994, 6048);

                    f_12_5994_6047(id, compilation, results);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 6066, 6100);

                    return f_12_6073_6099(results);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(12, 6129, 6223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 6169, 6208);

                    f_12_6169_6207(s_symbolListPool, results);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(12, 6129, 6223);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 5515, 6234);

                System.ArgumentNullException
                f_12_5692_5729(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 5692, 5729);
                    return return_v;
                }


                System.ArgumentNullException
                f_12_5824_5870(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 5824, 5870);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                f_12_5916_5943(Microsoft.CodeAnalysis.DocumentationCommentId.ListPool<Microsoft.CodeAnalysis.ISymbol>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 5916, 5943);
                    return return_v;
                }


                bool
                f_12_5994_6047(string
                id, Microsoft.CodeAnalysis.Compilation
                compilation, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                results)
                {
                    var return_v = TryGetSymbolsForReferenceId(id, compilation, results);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 5994, 6047);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_12_6073_6099(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                items)
                {
                    var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.ISymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 6073, 6099);
                    return return_v;
                }


                int
                f_12_6169_6207(Microsoft.CodeAnalysis.DocumentationCommentId.ListPool<Microsoft.CodeAnalysis.ISymbol>
                this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                list)
                {
                    this_param.ClearAndFree(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 6169, 6207);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 5515, 6234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 5515, 6234);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryGetSymbolsForReferenceId(string id, Compilation compilation, List<ISymbol> results)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 6423, 7203);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 6554, 6661) || true) && (id == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 6554, 6661);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 6602, 6646);

                    throw f_12_6608_6645(nameof(id));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 6554, 6661);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 6677, 6802) || true) && (compilation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 6677, 6802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 6734, 6787);

                    throw f_12_6740_6786(nameof(compilation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 6677, 6802);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 6818, 6935) || true) && (results == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 6818, 6935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 6871, 6920);

                    throw f_12_6877_6919(nameof(results));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 6818, 6935);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 6951, 7112) || true) && (f_12_6955_6964(id) > 1 && (DynAbs.Tracing.TraceSender.Expression_True(12, 6955, 6984) && f_12_6972_6977(id, 0) == 'N') && (DynAbs.Tracing.TraceSender.Expression_True(12, 6955, 7000) && f_12_6988_6993(id, 1) == ':'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 6951, 7112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 7034, 7097);

                    return f_12_7041_7096(id, compilation, results);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 6951, 7112);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 7128, 7192);

                return f_12_7135_7191(id, compilation, results);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 6423, 7203);

                System.ArgumentNullException
                f_12_6608_6645(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 6608, 6645);
                    return return_v;
                }


                System.ArgumentNullException
                f_12_6740_6786(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 6740, 6786);
                    return return_v;
                }


                System.ArgumentNullException
                f_12_6877_6919(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 6877, 6919);
                    return return_v;
                }


                int
                f_12_6955_6964(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 6955, 6964);
                    return return_v;
                }


                char
                f_12_6972_6977(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 6972, 6977);
                    return return_v;
                }


                char
                f_12_6988_6993(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 6988, 6993);
                    return return_v;
                }


                bool
                f_12_7041_7096(string
                id, Microsoft.CodeAnalysis.Compilation
                compilation, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                results)
                {
                    var return_v = TryGetSymbolsForDeclarationId(id, compilation, results);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 7041, 7096);
                    return return_v;
                }


                bool
                f_12_7135_7191(string
                id, Microsoft.CodeAnalysis.Compilation
                compilation, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                results)
                {
                    var return_v = Parser.ParseReferencedSymbolId(id, compilation, results);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 7135, 7191);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 6423, 7203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 6423, 7203);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ISymbol? GetFirstSymbolForReferenceId(string id, Compilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 7352, 8244);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 7464, 7571) || true) && (id == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 7464, 7571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 7512, 7556);

                    throw f_12_7518_7555(nameof(id));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 7464, 7571);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 7587, 7712) || true) && (compilation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 7587, 7712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 7644, 7697);

                    throw f_12_7650_7696(nameof(compilation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 7587, 7712);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 7728, 7881) || true) && (f_12_7732_7741(id) > 1 && (DynAbs.Tracing.TraceSender.Expression_True(12, 7732, 7761) && f_12_7749_7754(id, 0) == 'N') && (DynAbs.Tracing.TraceSender.Expression_True(12, 7732, 7777) && f_12_7765_7770(id, 1) == ':'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 7728, 7881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 7811, 7866);

                    return f_12_7818_7865(id, compilation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 7728, 7881);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 7897, 7939);

                var
                results = f_12_7911_7938(s_symbolListPool)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 7989, 8046);

                    f_12_7989_8045(id, compilation, results);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 8064, 8110);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(12, 8071, 8089) || ((f_12_8071_8084(results) == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(12, 8092, 8096)) || DynAbs.Tracing.TraceSender.Conditional_F3(12, 8099, 8109))) ? null : f_12_8099_8109(results, 0);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(12, 8139, 8233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 8179, 8218);

                    f_12_8179_8217(s_symbolListPool, results);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(12, 8139, 8233);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 7352, 8244);

                System.ArgumentNullException
                f_12_7518_7555(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 7518, 7555);
                    return return_v;
                }


                System.ArgumentNullException
                f_12_7650_7696(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 7650, 7696);
                    return return_v;
                }


                int
                f_12_7732_7741(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 7732, 7741);
                    return return_v;
                }


                char
                f_12_7749_7754(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 7749, 7754);
                    return return_v;
                }


                char
                f_12_7765_7770(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 7765, 7770);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol?
                f_12_7818_7865(string
                id, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = GetFirstSymbolForDeclarationId(id, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 7818, 7865);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                f_12_7911_7938(Microsoft.CodeAnalysis.DocumentationCommentId.ListPool<Microsoft.CodeAnalysis.ISymbol>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 7911, 7938);
                    return return_v;
                }


                bool
                f_12_7989_8045(string
                id, Microsoft.CodeAnalysis.Compilation
                compilation, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                results)
                {
                    var return_v = Parser.ParseReferencedSymbolId(id, compilation, results);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 7989, 8045);
                    return return_v;
                }


                int
                f_12_8071_8084(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 8071, 8084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_12_8099_8109(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 8099, 8109);
                    return return_v;
                }


                int
                f_12_8179_8217(Microsoft.CodeAnalysis.DocumentationCommentId.ListPool<Microsoft.CodeAnalysis.ISymbol>
                this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                list)
                {
                    this_param.ClearAndFree(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 8179, 8217);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 7352, 8244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 7352, 8244);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int GetTotalTypeParameterCount(INamedTypeSymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 8256, 8587);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 8352, 8362);

                int
                n = 0
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 8376, 8551) || true) && (symbol != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 8376, 8551);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 8431, 8465);

                        n += symbol.TypeParameters.Length;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 8483, 8536);

                        symbol = f_12_8492_8515(symbol) as INamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 8376, 8551);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 8376, 8551);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(12, 8376, 8551);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 8567, 8576);

                return n;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 8256, 8587);

                Microsoft.CodeAnalysis.ISymbol
                f_12_8492_8515(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 8492, 8515);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 8256, 8587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 8256, 8587);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string EncodeName(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 8651, 8865);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 8721, 8826) || true) && (f_12_8725_8742(name, '.') >= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 8721, 8826);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 8781, 8811);

                    return f_12_8788_8810(name, '.', '#');
                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 8721, 8826);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 8842, 8854);

                return name;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 8651, 8865);

                int
                f_12_8725_8742(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 8725, 8742);
                    return return_v;
                }


                string
                f_12_8788_8810(string
                this_param, char
                oldChar, char
                newChar)
                {
                    var return_v = this_param.Replace(oldChar, newChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 8788, 8810);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 8651, 8865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 8651, 8865);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string EncodePropertyName(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 8877, 9275);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 9006, 9236) || true) && (name == "this[]")
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 9006, 9236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 9060, 9074);

                    name = "Item";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 9006, 9236);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 9006, 9236);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 9108, 9236) || true) && (f_12_9112_9136(name, ".this[]"))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 9108, 9236);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 9170, 9221);

                        name = f_12_9177_9211(name, 0, f_12_9195_9206(name) - 6) + "Item";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 9108, 9236);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 9006, 9236);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 9252, 9264);

                return name;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 8877, 9275);

                bool
                f_12_9112_9136(string
                this_param, string
                value)
                {
                    var return_v = this_param.EndsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 9112, 9136);
                    return return_v;
                }


                int
                f_12_9195_9206(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 9195, 9206);
                    return return_v;
                }


                string
                f_12_9177_9211(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 9177, 9211);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 8877, 9275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 8877, 9275);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string DecodePropertyName(string name, string language)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 9287, 9837);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 9455, 9798) || true) && (language == LanguageNames.CSharp)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 9455, 9798);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 9525, 9783) || true) && (name == "Item")
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 9525, 9783);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 9585, 9601);

                        name = "this[]";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 9525, 9783);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 9525, 9783);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 9643, 9783) || true) && (f_12_9647_9669(name, ".Item"))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 9643, 9783);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 9711, 9764);

                            name = f_12_9718_9752(name, 0, f_12_9736_9747(name) - 4) + "this[]";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 9643, 9783);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 9525, 9783);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 9455, 9798);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 9814, 9826);

                return name;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 9287, 9837);

                bool
                f_12_9647_9669(string
                this_param, string
                value)
                {
                    var return_v = this_param.EndsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 9647, 9669);
                    return return_v;
                }


                int
                f_12_9736_9747(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 9736, 9747);
                    return return_v;
                }


                string
                f_12_9718_9752(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 9718, 9752);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 9287, 9837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 9287, 9837);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private class DeclarationGenerator : SymbolVisitor
        {
            private readonly StringBuilder _builder;

            private readonly Generator _generator;

            public DeclarationGenerator(StringBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(12, 10032, 10203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 9955, 9963);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 10005, 10015);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 10115, 10134);

                    _builder = builder;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 10152, 10188);

                    _generator = f_12_10165_10187(builder);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(12, 10032, 10203);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 10032, 10203);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 10032, 10203);
                }
            }

            public override void DefaultVisit(ISymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 10219, 10411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 10301, 10396);

                    throw f_12_10307_10395("Cannot generated a documentation comment id for symbol.");
                    DynAbs.Tracing.TraceSender.TraceExitMethod(12, 10219, 10411);

                    System.InvalidOperationException
                    f_12_10307_10395(string
                    message)
                    {
                        var return_v = new System.InvalidOperationException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 10307, 10395);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 10219, 10411);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 10219, 10411);
                }
            }

            public override void VisitEvent(IEventSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 10427, 10592);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 10512, 10534);

                    f_12_10512_10533(_builder, "E:");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 10552, 10577);

                    f_12_10552_10576(_generator, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(12, 10427, 10592);

                    System.Text.StringBuilder
                    f_12_10512_10533(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 10512, 10533);
                        return return_v;
                    }


                    bool
                    f_12_10552_10576(Microsoft.CodeAnalysis.DocumentationCommentId.DeclarationGenerator.Generator
                    this_param, Microsoft.CodeAnalysis.IEventSymbol
                    symbol)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.ISymbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 10552, 10576);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 10427, 10592);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 10427, 10592);
                }
            }

            public override void VisitField(IFieldSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 10608, 10773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 10693, 10715);

                    f_12_10693_10714(_builder, "F:");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 10733, 10758);

                    f_12_10733_10757(_generator, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(12, 10608, 10773);

                    System.Text.StringBuilder
                    f_12_10693_10714(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 10693, 10714);
                        return return_v;
                    }


                    bool
                    f_12_10733_10757(Microsoft.CodeAnalysis.DocumentationCommentId.DeclarationGenerator.Generator
                    this_param, Microsoft.CodeAnalysis.IFieldSymbol
                    symbol)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.ISymbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 10733, 10757);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 10608, 10773);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 10608, 10773);
                }
            }

            public override void VisitProperty(IPropertySymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 10789, 10960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 10880, 10902);

                    f_12_10880_10901(_builder, "P:");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 10920, 10945);

                    f_12_10920_10944(_generator, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(12, 10789, 10960);

                    System.Text.StringBuilder
                    f_12_10880_10901(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 10880, 10901);
                        return return_v;
                    }


                    bool
                    f_12_10920_10944(Microsoft.CodeAnalysis.DocumentationCommentId.DeclarationGenerator.Generator
                    this_param, Microsoft.CodeAnalysis.IPropertySymbol
                    symbol)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.ISymbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 10920, 10944);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 10789, 10960);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 10789, 10960);
                }
            }

            public override void VisitMethod(IMethodSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 10976, 11143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 11063, 11085);

                    f_12_11063_11084(_builder, "M:");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 11103, 11128);

                    f_12_11103_11127(_generator, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(12, 10976, 11143);

                    System.Text.StringBuilder
                    f_12_11063_11084(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 11063, 11084);
                        return return_v;
                    }


                    bool
                    f_12_11103_11127(Microsoft.CodeAnalysis.DocumentationCommentId.DeclarationGenerator.Generator
                    this_param, Microsoft.CodeAnalysis.IMethodSymbol
                    symbol)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.ISymbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 11103, 11127);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 10976, 11143);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 10976, 11143);
                }
            }

            public override void VisitNamespace(INamespaceSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 11159, 11332);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 11252, 11274);

                    f_12_11252_11273(_builder, "N:");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 11292, 11317);

                    f_12_11292_11316(_generator, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(12, 11159, 11332);

                    System.Text.StringBuilder
                    f_12_11252_11273(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 11252, 11273);
                        return return_v;
                    }


                    bool
                    f_12_11292_11316(Microsoft.CodeAnalysis.DocumentationCommentId.DeclarationGenerator.Generator
                    this_param, Microsoft.CodeAnalysis.INamespaceSymbol
                    symbol)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.ISymbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 11292, 11316);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 11159, 11332);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 11159, 11332);
                }
            }

            public override void VisitNamedType(INamedTypeSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 11348, 11521);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 11441, 11463);

                    f_12_11441_11462(_builder, "T:");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 11481, 11506);

                    f_12_11481_11505(_generator, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(12, 11348, 11521);

                    System.Text.StringBuilder
                    f_12_11441_11462(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 11441, 11462);
                        return return_v;
                    }


                    bool
                    f_12_11481_11505(Microsoft.CodeAnalysis.DocumentationCommentId.DeclarationGenerator.Generator
                    this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                    symbol)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.ISymbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 11481, 11505);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 11348, 11521);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 11348, 11521);
                }
            }
            private class Generator : SymbolVisitor<bool>
            {
                private readonly StringBuilder _builder;

                private ReferenceGenerator? _referenceGenerator;

                public Generator(StringBuilder builder)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(12, 11741, 11859);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 11646, 11654);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 11701, 11720);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 11821, 11840);

                        _builder = builder;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(12, 11741, 11859);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 11741, 11859);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 11741, 11859);
                    }
                }

                private ReferenceGenerator GetReferenceGenerator(ISymbol typeParameterContext)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 11879, 12317);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 11998, 12247) || true) && (_referenceGenerator == null || (DynAbs.Tracing.TraceSender.Expression_False(12, 12002, 12097) || f_12_12033_12073(_referenceGenerator) != typeParameterContext))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 11998, 12247);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 12147, 12224);

                            _referenceGenerator = f_12_12169_12223(_builder, typeParameterContext);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 11998, 12247);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 12271, 12298);

                        return _referenceGenerator;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(12, 11879, 12317);

                        Microsoft.CodeAnalysis.ISymbol?
                        f_12_12033_12073(Microsoft.CodeAnalysis.DocumentationCommentId.ReferenceGenerator
                        this_param)
                        {
                            var return_v = this_param.TypeParameterContext;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 12033, 12073);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.DocumentationCommentId.ReferenceGenerator
                        f_12_12169_12223(System.Text.StringBuilder
                        builder, Microsoft.CodeAnalysis.ISymbol
                        typeParameterContext)
                        {
                            var return_v = new Microsoft.CodeAnalysis.DocumentationCommentId.ReferenceGenerator(builder, typeParameterContext);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 12169, 12223);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 11879, 12317);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 11879, 12317);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override bool DefaultVisit(ISymbol symbol)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 12337, 12541);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 12427, 12522);

                        throw f_12_12433_12521("Cannot generated a documentation comment id for symbol.");
                        DynAbs.Tracing.TraceSender.TraceExitMethod(12, 12337, 12541);

                        System.InvalidOperationException
                        f_12_12433_12521(string
                        message)
                        {
                            var return_v = new System.InvalidOperationException(message);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 12433, 12521);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 12337, 12541);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 12337, 12541);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override bool VisitEvent(IEventSymbol symbol)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 12561, 12905);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 12654, 12787) || true) && (f_12_12658_12693(this, f_12_12669_12692(symbol)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 12654, 12787);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 12743, 12764);

                            f_12_12743_12763(_builder, ".");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 12654, 12787);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 12811, 12852);

                        f_12_12811_12851(
                                            _builder, f_12_12827_12850(f_12_12838_12849(symbol)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 12874, 12886);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(12, 12561, 12905);

                        Microsoft.CodeAnalysis.ISymbol
                        f_12_12669_12692(Microsoft.CodeAnalysis.IEventSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 12669, 12692);
                            return return_v;
                        }


                        bool
                        f_12_12658_12693(Microsoft.CodeAnalysis.DocumentationCommentId.DeclarationGenerator.Generator
                        this_param, Microsoft.CodeAnalysis.ISymbol
                        symbol)
                        {
                            var return_v = this_param.Visit(symbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 12658, 12693);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_12_12743_12763(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 12743, 12763);
                            return return_v;
                        }


                        string
                        f_12_12838_12849(Microsoft.CodeAnalysis.IEventSymbol
                        this_param)
                        {
                            var return_v = this_param.Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 12838, 12849);
                            return return_v;
                        }


                        string
                        f_12_12827_12850(string
                        name)
                        {
                            var return_v = EncodeName(name);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 12827, 12850);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_12_12811_12851(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 12811, 12851);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 12561, 12905);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 12561, 12905);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override bool VisitField(IFieldSymbol symbol)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 12925, 13269);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 13018, 13151) || true) && (f_12_13022_13057(this, f_12_13033_13056(symbol)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 13018, 13151);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 13107, 13128);

                            f_12_13107_13127(_builder, ".");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 13018, 13151);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 13175, 13216);

                        f_12_13175_13215(
                                            _builder, f_12_13191_13214(f_12_13202_13213(symbol)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 13238, 13250);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(12, 12925, 13269);

                        Microsoft.CodeAnalysis.ISymbol
                        f_12_13033_13056(Microsoft.CodeAnalysis.IFieldSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 13033, 13056);
                            return return_v;
                        }


                        bool
                        f_12_13022_13057(Microsoft.CodeAnalysis.DocumentationCommentId.DeclarationGenerator.Generator
                        this_param, Microsoft.CodeAnalysis.ISymbol
                        symbol)
                        {
                            var return_v = this_param.Visit(symbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 13022, 13057);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_12_13107_13127(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 13107, 13127);
                            return return_v;
                        }


                        string
                        f_12_13202_13213(Microsoft.CodeAnalysis.IFieldSymbol
                        this_param)
                        {
                            var return_v = this_param.Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 13202, 13213);
                            return return_v;
                        }


                        string
                        f_12_13191_13214(string
                        name)
                        {
                            var return_v = EncodeName(name);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 13191, 13214);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_12_13175_13215(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 13175, 13215);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 12925, 13269);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 12925, 13269);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override bool VisitProperty(IPropertySymbol symbol)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 13289, 13759);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 13388, 13521) || true) && (f_12_13392_13427(this, f_12_13403_13426(symbol)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 13388, 13521);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 13477, 13498);

                            f_12_13477_13497(_builder, ".");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 13388, 13521);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 13545, 13588);

                        var
                        name = f_12_13556_13587(f_12_13575_13586(symbol))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 13610, 13644);

                        f_12_13610_13643(_builder, f_12_13626_13642(name));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 13668, 13704);

                        f_12_13668_13703(this, f_12_13685_13702(symbol));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 13728, 13740);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(12, 13289, 13759);

                        Microsoft.CodeAnalysis.ISymbol
                        f_12_13403_13426(Microsoft.CodeAnalysis.IPropertySymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 13403, 13426);
                            return return_v;
                        }


                        bool
                        f_12_13392_13427(Microsoft.CodeAnalysis.DocumentationCommentId.DeclarationGenerator.Generator
                        this_param, Microsoft.CodeAnalysis.ISymbol
                        symbol)
                        {
                            var return_v = this_param.Visit(symbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 13392, 13427);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_12_13477_13497(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 13477, 13497);
                            return return_v;
                        }


                        string
                        f_12_13575_13586(Microsoft.CodeAnalysis.IPropertySymbol
                        this_param)
                        {
                            var return_v = this_param.Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 13575, 13586);
                            return return_v;
                        }


                        string
                        f_12_13556_13587(string
                        name)
                        {
                            var return_v = EncodePropertyName(name);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 13556, 13587);
                            return return_v;
                        }


                        string
                        f_12_13626_13642(string
                        name)
                        {
                            var return_v = EncodeName(name);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 13626, 13642);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_12_13610_13643(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 13610, 13643);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
                        f_12_13685_13702(Microsoft.CodeAnalysis.IPropertySymbol
                        this_param)
                        {
                            var return_v = this_param.Parameters;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 13685, 13702);
                            return return_v;
                        }


                        int
                        f_12_13668_13703(Microsoft.CodeAnalysis.DocumentationCommentId.DeclarationGenerator.Generator
                        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
                        parameters)
                        {
                            this_param.AppendParameters(parameters);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 13668, 13703);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 13289, 13759);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 13289, 13759);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override bool VisitMethod(IMethodSymbol symbol)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 13779, 14643);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 13874, 14074) || true) && (f_12_13878_13913(this, f_12_13889_13912(symbol)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 13874, 14074);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 13963, 13984);

                            f_12_13963_13983(_builder, ".");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 14010, 14051);

                            f_12_14010_14050(_builder, f_12_14026_14049(f_12_14037_14048(symbol)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 13874, 14074);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 14098, 14301) || true) && (symbol.TypeParameters.Length > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 14098, 14301);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 14184, 14206);

                            f_12_14184_14205(_builder, "``");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 14232, 14278);

                            f_12_14232_14277(_builder, symbol.TypeParameters.Length);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 14098, 14301);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 14325, 14361);

                        f_12_14325_14360(this, f_12_14342_14359(symbol));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 14385, 14588) || true) && (f_12_14389_14408_M(!symbol.ReturnsVoid))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 14385, 14588);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 14458, 14479);

                            f_12_14458_14478(_builder, "~");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 14505, 14565);

                            f_12_14505_14564(f_12_14505_14539(this, symbol), f_12_14546_14563(symbol));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 14385, 14588);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 14612, 14624);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(12, 13779, 14643);

                        Microsoft.CodeAnalysis.ISymbol
                        f_12_13889_13912(Microsoft.CodeAnalysis.IMethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 13889, 13912);
                            return return_v;
                        }


                        bool
                        f_12_13878_13913(Microsoft.CodeAnalysis.DocumentationCommentId.DeclarationGenerator.Generator
                        this_param, Microsoft.CodeAnalysis.ISymbol
                        symbol)
                        {
                            var return_v = this_param.Visit(symbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 13878, 13913);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_12_13963_13983(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 13963, 13983);
                            return return_v;
                        }


                        string
                        f_12_14037_14048(Microsoft.CodeAnalysis.IMethodSymbol
                        this_param)
                        {
                            var return_v = this_param.Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 14037, 14048);
                            return return_v;
                        }


                        string
                        f_12_14026_14049(string
                        name)
                        {
                            var return_v = EncodeName(name);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 14026, 14049);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_12_14010_14050(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 14010, 14050);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_12_14184_14205(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 14184, 14205);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_12_14232_14277(System.Text.StringBuilder
                        this_param, int
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 14232, 14277);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
                        f_12_14342_14359(Microsoft.CodeAnalysis.IMethodSymbol
                        this_param)
                        {
                            var return_v = this_param.Parameters;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 14342, 14359);
                            return return_v;
                        }


                        int
                        f_12_14325_14360(Microsoft.CodeAnalysis.DocumentationCommentId.DeclarationGenerator.Generator
                        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
                        parameters)
                        {
                            this_param.AppendParameters(parameters);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 14325, 14360);
                            return 0;
                        }


                        bool
                        f_12_14389_14408_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 14389, 14408);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_12_14458_14478(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 14458, 14478);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.DocumentationCommentId.ReferenceGenerator
                        f_12_14505_14539(Microsoft.CodeAnalysis.DocumentationCommentId.DeclarationGenerator.Generator
                        this_param, Microsoft.CodeAnalysis.IMethodSymbol
                        typeParameterContext)
                        {
                            var return_v = this_param.GetReferenceGenerator((Microsoft.CodeAnalysis.ISymbol)typeParameterContext);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 14505, 14539);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ITypeSymbol
                        f_12_14546_14563(Microsoft.CodeAnalysis.IMethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ReturnType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 14546, 14563);
                            return return_v;
                        }


                        bool
                        f_12_14505_14564(Microsoft.CodeAnalysis.DocumentationCommentId.ReferenceGenerator
                        this_param, Microsoft.CodeAnalysis.ITypeSymbol
                        symbol)
                        {
                            var return_v = this_param.Visit((Microsoft.CodeAnalysis.ISymbol)symbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 14505, 14564);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 13779, 14643);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 13779, 14643);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                private void AppendParameters(ImmutableArray<IParameterSymbol> parameters)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 14663, 15576);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 14778, 15557) || true) && (parameters.Length > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 14778, 15557);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 14853, 14874);

                            f_12_14853_14873(_builder, "(");
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 14911, 14916);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 14918, 14939);

                                for (int
        i = 0
        ,
        n = parameters.Length
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 14902, 15485) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 14948, 14951)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(12, 14902, 15485))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 14902, 15485);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 15009, 15136) || true) && (i > 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 15009, 15136);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 15084, 15105);

                                        f_12_15084_15104(_builder, ",");
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 15009, 15136);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 15168, 15190);

                                    var
                                    p = parameters[i]
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 15220, 15281);

                                    f_12_15220_15280(f_12_15220_15266(this, f_12_15247_15265(p)), f_12_15273_15279(p));

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 15311, 15458) || true) && (f_12_15315_15324(p) != RefKind.None)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 15311, 15458);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 15406, 15427);

                                        f_12_15406_15426(_builder, "@");
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 15311, 15458);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 1, 584);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(12, 1, 584);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 15513, 15534);

                            f_12_15513_15533(
                                                    _builder, ")");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 14778, 15557);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(12, 14663, 15576);

                        System.Text.StringBuilder
                        f_12_14853_14873(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 14853, 14873);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_12_15084_15104(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 15084, 15104);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ISymbol
                        f_12_15247_15265(Microsoft.CodeAnalysis.IParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 15247, 15265);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.DocumentationCommentId.ReferenceGenerator
                        f_12_15220_15266(Microsoft.CodeAnalysis.DocumentationCommentId.DeclarationGenerator.Generator
                        this_param, Microsoft.CodeAnalysis.ISymbol
                        typeParameterContext)
                        {
                            var return_v = this_param.GetReferenceGenerator(typeParameterContext);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 15220, 15266);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ITypeSymbol
                        f_12_15273_15279(Microsoft.CodeAnalysis.IParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 15273, 15279);
                            return return_v;
                        }


                        bool
                        f_12_15220_15280(Microsoft.CodeAnalysis.DocumentationCommentId.ReferenceGenerator
                        this_param, Microsoft.CodeAnalysis.ITypeSymbol
                        symbol)
                        {
                            var return_v = this_param.Visit((Microsoft.CodeAnalysis.ISymbol)symbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 15220, 15280);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.RefKind
                        f_12_15315_15324(Microsoft.CodeAnalysis.IParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.RefKind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 15315, 15324);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_12_15406_15426(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 15406, 15426);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_12_15513_15533(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 15513, 15533);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 14663, 15576);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 14663, 15576);
                    }
                }

                public override bool VisitNamespace(INamespaceSymbol symbol)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 15596, 16086);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 15697, 15811) || true) && (f_12_15701_15725(symbol))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 15697, 15811);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 15775, 15788);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 15697, 15811);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 15835, 15968) || true) && (f_12_15839_15874(this, f_12_15850_15873(symbol)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 15835, 15968);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 15924, 15945);

                            f_12_15924_15944(_builder, ".");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 15835, 15968);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 15992, 16033);

                        f_12_15992_16032(
                                            _builder, f_12_16008_16031(f_12_16019_16030(symbol)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 16055, 16067);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(12, 15596, 16086);

                        bool
                        f_12_15701_15725(Microsoft.CodeAnalysis.INamespaceSymbol
                        this_param)
                        {
                            var return_v = this_param.IsGlobalNamespace;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 15701, 15725);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ISymbol
                        f_12_15850_15873(Microsoft.CodeAnalysis.INamespaceSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 15850, 15873);
                            return return_v;
                        }


                        bool
                        f_12_15839_15874(Microsoft.CodeAnalysis.DocumentationCommentId.DeclarationGenerator.Generator
                        this_param, Microsoft.CodeAnalysis.ISymbol
                        symbol)
                        {
                            var return_v = this_param.Visit(symbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 15839, 15874);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_12_15924_15944(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 15924, 15944);
                            return return_v;
                        }


                        string
                        f_12_16019_16030(Microsoft.CodeAnalysis.INamespaceSymbol
                        this_param)
                        {
                            var return_v = this_param.Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 16019, 16030);
                            return return_v;
                        }


                        string
                        f_12_16008_16031(string
                        name)
                        {
                            var return_v = EncodeName(name);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 16008, 16031);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_12_15992_16032(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 15992, 16032);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 15596, 16086);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 15596, 16086);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override bool VisitNamedType(INamedTypeSymbol symbol)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 16106, 16686);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 16207, 16340) || true) && (f_12_16211_16246(this, f_12_16222_16245(symbol)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 16207, 16340);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 16296, 16317);

                            f_12_16296_16316(_builder, ".");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 16207, 16340);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 16364, 16405);

                        f_12_16364_16404(
                                            _builder, f_12_16380_16403(f_12_16391_16402(symbol)));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 16429, 16631) || true) && (symbol.TypeParameters.Length > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 16429, 16631);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 16515, 16536);

                            f_12_16515_16535(_builder, "`");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 16562, 16608);

                            f_12_16562_16607(_builder, symbol.TypeParameters.Length);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 16429, 16631);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 16655, 16667);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(12, 16106, 16686);

                        Microsoft.CodeAnalysis.ISymbol
                        f_12_16222_16245(Microsoft.CodeAnalysis.INamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 16222, 16245);
                            return return_v;
                        }


                        bool
                        f_12_16211_16246(Microsoft.CodeAnalysis.DocumentationCommentId.DeclarationGenerator.Generator
                        this_param, Microsoft.CodeAnalysis.ISymbol
                        symbol)
                        {
                            var return_v = this_param.Visit(symbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 16211, 16246);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_12_16296_16316(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 16296, 16316);
                            return return_v;
                        }


                        string
                        f_12_16391_16402(Microsoft.CodeAnalysis.INamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 16391, 16402);
                            return return_v;
                        }


                        string
                        f_12_16380_16403(string
                        name)
                        {
                            var return_v = EncodeName(name);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 16380, 16403);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_12_16364_16404(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 16364, 16404);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_12_16515_16535(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 16515, 16535);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_12_16562_16607(System.Text.StringBuilder
                        this_param, int
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 16562, 16607);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 16106, 16686);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 16106, 16686);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static Generator()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(12, 11537, 16701);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(12, 11537, 16701);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 11537, 16701);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(12, 11537, 16701);
            }

            static DeclarationGenerator()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(12, 9849, 16712);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(12, 9849, 16712);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 9849, 16712);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(12, 9849, 16712);

            static Microsoft.CodeAnalysis.DocumentationCommentId.DeclarationGenerator.Generator
            f_12_10165_10187(System.Text.StringBuilder
            builder)
            {
                var return_v = new Microsoft.CodeAnalysis.DocumentationCommentId.DeclarationGenerator.Generator(builder);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 10165, 10187);
                return return_v;
            }

        }
        private class ReferenceGenerator : SymbolVisitor<bool>
        {
            private readonly StringBuilder _builder;

            private readonly ISymbol? _typeParameterContext;

            public ReferenceGenerator(StringBuilder builder, ISymbol? typeParameterContext)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(12, 16921, 17130);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 16834, 16842);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 16883, 16904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 17033, 17052);

                    _builder = builder;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 17070, 17115);

                    _typeParameterContext = typeParameterContext;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(12, 16921, 17130);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 16921, 17130);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 16921, 17130);
                }
            }

            public ISymbol? TypeParameterContext
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 17215, 17252);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 17221, 17250);

                        return _typeParameterContext;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(12, 17215, 17252);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 17146, 17267);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 17146, 17267);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private void BuildDottedName(ISymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 17283, 17557);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 17360, 17481) || true) && (f_12_17364_17399(this, f_12_17375_17398(symbol)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 17360, 17481);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 17441, 17462);

                        f_12_17441_17461(_builder, ".");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 17360, 17481);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 17501, 17542);

                    f_12_17501_17541(
                                    _builder, f_12_17517_17540(f_12_17528_17539(symbol)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(12, 17283, 17557);

                    Microsoft.CodeAnalysis.ISymbol
                    f_12_17375_17398(Microsoft.CodeAnalysis.ISymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 17375, 17398);
                        return return_v;
                    }


                    bool
                    f_12_17364_17399(Microsoft.CodeAnalysis.DocumentationCommentId.ReferenceGenerator
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    symbol)
                    {
                        var return_v = this_param.Visit(symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 17364, 17399);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_12_17441_17461(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 17441, 17461);
                        return return_v;
                    }


                    string
                    f_12_17528_17539(Microsoft.CodeAnalysis.ISymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 17528, 17539);
                        return return_v;
                    }


                    string
                    f_12_17517_17540(string
                    name)
                    {
                        var return_v = EncodeName(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 17517, 17540);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_12_17501_17541(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 17501, 17541);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 17283, 17557);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 17283, 17557);
                }
            }

            public override bool VisitAlias(IAliasSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 17573, 17707);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 17658, 17692);

                    return f_12_17665_17691(f_12_17665_17678(symbol), this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(12, 17573, 17707);

                    Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                    f_12_17665_17678(Microsoft.CodeAnalysis.IAliasSymbol
                    this_param)
                    {
                        var return_v = this_param.Target;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 17665, 17678);
                        return return_v;
                    }


                    bool
                    f_12_17665_17691(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                    this_param, Microsoft.CodeAnalysis.DocumentationCommentId.ReferenceGenerator
                    visitor)
                    {
                        var return_v = this_param.Accept<bool>((Microsoft.CodeAnalysis.SymbolVisitor<bool>)visitor);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 17665, 17691);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 17573, 17707);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 17573, 17707);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool VisitNamespace(INamespaceSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 17723, 18012);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 17816, 17918) || true) && (f_12_17820_17844(symbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 17816, 17918);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 17886, 17899);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 17816, 17918);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 17938, 17967);

                    f_12_17938_17966(
                                    this, symbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 17985, 17997);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(12, 17723, 18012);

                    bool
                    f_12_17820_17844(Microsoft.CodeAnalysis.INamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.IsGlobalNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 17820, 17844);
                        return return_v;
                    }


                    int
                    f_12_17938_17966(Microsoft.CodeAnalysis.DocumentationCommentId.ReferenceGenerator
                    this_param, Microsoft.CodeAnalysis.INamespaceSymbol
                    symbol)
                    {
                        this_param.BuildDottedName((Microsoft.CodeAnalysis.ISymbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 17938, 17966);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 17723, 18012);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 17723, 18012);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool VisitNamedType(INamedTypeSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 18028, 19079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 18121, 18150);

                    f_12_18121_18149(this, symbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 18170, 19032) || true) && (f_12_18174_18194(symbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 18170, 19032);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 18236, 19013) || true) && (f_12_18240_18265(symbol) == symbol)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 18236, 19013);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 18325, 18346);

                            f_12_18325_18345(_builder, "`");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 18372, 18418);

                            f_12_18372_18417(_builder, symbol.TypeParameters.Length);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 18236, 19013);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 18236, 19013);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 18468, 19013) || true) && (symbol.TypeArguments.Length > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 18468, 19013);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 18553, 18574);

                                f_12_18553_18573(_builder, "{");
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 18611, 18616);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 18618, 18649);

                                    for (int
            i = 0
            ,
            n = symbol.TypeArguments.Length
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 18602, 18941) || true) && (i < n)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 18658, 18661)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(12, 18602, 18941))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 18602, 18941);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 18719, 18846) || true) && (i > 0)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 18719, 18846);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 18794, 18815);

                                            f_12_18794_18814(_builder, ",");
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 18719, 18846);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 18878, 18914);

                                        f_12_18878_18913(
                                                                    this, f_12_18889_18909(symbol)[i]);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 1, 340);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(12, 1, 340);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 18969, 18990);

                                f_12_18969_18989(
                                                        _builder, "}");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 18468, 19013);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 18236, 19013);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 18170, 19032);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 19052, 19064);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(12, 18028, 19079);

                    int
                    f_12_18121_18149(Microsoft.CodeAnalysis.DocumentationCommentId.ReferenceGenerator
                    this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                    symbol)
                    {
                        this_param.BuildDottedName((Microsoft.CodeAnalysis.ISymbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 18121, 18149);
                        return 0;
                    }


                    bool
                    f_12_18174_18194(Microsoft.CodeAnalysis.INamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsGenericType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 18174, 18194);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamedTypeSymbol
                    f_12_18240_18265(Microsoft.CodeAnalysis.INamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 18240, 18265);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_12_18325_18345(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 18325, 18345);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_12_18372_18417(System.Text.StringBuilder
                    this_param, int
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 18372, 18417);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_12_18553_18573(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 18553, 18573);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_12_18794_18814(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 18794, 18814);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                    f_12_18889_18909(Microsoft.CodeAnalysis.INamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeArguments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 18889, 18909);
                        return return_v;
                    }


                    bool
                    f_12_18878_18913(Microsoft.CodeAnalysis.DocumentationCommentId.ReferenceGenerator
                    this_param, Microsoft.CodeAnalysis.ITypeSymbol
                    symbol)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.ISymbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 18878, 18913);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_12_18969_18989(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 18969, 18989);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 18028, 19079);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 18028, 19079);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool VisitDynamicType(IDynamicTypeSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 19095, 19272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 19192, 19225);

                    f_12_19192_19224(_builder, "System.Object");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 19245, 19257);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(12, 19095, 19272);

                    System.Text.StringBuilder
                    f_12_19192_19224(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 19192, 19224);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 19095, 19272);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 19095, 19272);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool VisitArrayType(IArrayTypeSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 19288, 19822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 19381, 19412);

                    f_12_19381_19411(this, f_12_19392_19410(symbol));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 19432, 19453);

                    f_12_19432_19452(
                                    _builder, "[");
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 19482, 19487);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 19489, 19504);

                        for (int
        i = 0
        ,
        n = f_12_19493_19504(symbol)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 19473, 19734) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 19513, 19516)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(12, 19473, 19734))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 19473, 19734);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 19612, 19715) || true) && (i > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 19612, 19715);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 19671, 19692);

                                f_12_19671_19691(_builder, ",");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 19612, 19715);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 1, 262);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(12, 1, 262);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 19754, 19775);

                    f_12_19754_19774(
                                    _builder, "]");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 19795, 19807);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(12, 19288, 19822);

                    Microsoft.CodeAnalysis.ITypeSymbol
                    f_12_19392_19410(Microsoft.CodeAnalysis.IArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ElementType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 19392, 19410);
                        return return_v;
                    }


                    bool
                    f_12_19381_19411(Microsoft.CodeAnalysis.DocumentationCommentId.ReferenceGenerator
                    this_param, Microsoft.CodeAnalysis.ITypeSymbol
                    symbol)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.ISymbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 19381, 19411);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_12_19432_19452(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 19432, 19452);
                        return return_v;
                    }


                    int
                    f_12_19493_19504(Microsoft.CodeAnalysis.IArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Rank;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 19493, 19504);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_12_19671_19691(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 19671, 19691);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_12_19754_19774(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 19754, 19774);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 19288, 19822);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 19288, 19822);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool VisitPointerType(IPointerTypeSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 19838, 20052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 19935, 19968);

                    f_12_19935_19967(this, f_12_19946_19966(symbol));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 19986, 20007);

                    f_12_19986_20006(_builder, "*");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 20025, 20037);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(12, 19838, 20052);

                    Microsoft.CodeAnalysis.ITypeSymbol
                    f_12_19946_19966(Microsoft.CodeAnalysis.IPointerTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.PointedAtType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 19946, 19966);
                        return return_v;
                    }


                    bool
                    f_12_19935_19967(Microsoft.CodeAnalysis.DocumentationCommentId.ReferenceGenerator
                    this_param, Microsoft.CodeAnalysis.ITypeSymbol
                    symbol)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.ISymbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 19935, 19967);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_12_19986_20006(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 19986, 20006);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 19838, 20052);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 19838, 20052);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool VisitTypeParameter(ITypeParameterSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 20068, 21194);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 20169, 20503) || true) && (!f_12_20174_20191(this, symbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 20169, 20503);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 20329, 20379);

                        var
                        declarer = f_12_20344_20378(_builder)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 20401, 20441);

                        f_12_20401_20440(declarer, f_12_20416_20439(symbol));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 20463, 20484);

                        f_12_20463_20483(_builder, ":");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 20169, 20503);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 20523, 21147) || true) && (f_12_20527_20549(symbol) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 20523, 21147);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 20599, 20621);

                        f_12_20599_20620(_builder, "``");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 20643, 20675);

                        f_12_20643_20674(_builder, f_12_20659_20673(symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 20523, 21147);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 20523, 21147);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 20881, 20939);

                        var
                        container = f_12_20897_20938_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_12_20897_20920(symbol), 12, 20897, 20938)?.ContainingSymbol)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 20961, 21027);

                        var
                        b = f_12_20969_21026(container as INamedTypeSymbol)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 21049, 21070);

                        f_12_21049_21069(_builder, "`");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 21092, 21128);

                        f_12_21092_21127(_builder, b + f_12_21112_21126(symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 20523, 21147);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 21167, 21179);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(12, 20068, 21194);

                    bool
                    f_12_20174_20191(Microsoft.CodeAnalysis.DocumentationCommentId.ReferenceGenerator
                    this_param, Microsoft.CodeAnalysis.ITypeParameterSymbol
                    typeParameterSymbol)
                    {
                        var return_v = this_param.IsInScope(typeParameterSymbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 20174, 20191);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DocumentationCommentId.DeclarationGenerator
                    f_12_20344_20378(System.Text.StringBuilder
                    builder)
                    {
                        var return_v = new Microsoft.CodeAnalysis.DocumentationCommentId.DeclarationGenerator(builder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 20344, 20378);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ISymbol
                    f_12_20416_20439(Microsoft.CodeAnalysis.ITypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 20416, 20439);
                        return return_v;
                    }


                    int
                    f_12_20401_20440(Microsoft.CodeAnalysis.DocumentationCommentId.DeclarationGenerator
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    symbol)
                    {
                        this_param.Visit(symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 20401, 20440);
                        return 0;
                    }


                    System.Text.StringBuilder
                    f_12_20463_20483(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 20463, 20483);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IMethodSymbol?
                    f_12_20527_20549(Microsoft.CodeAnalysis.ITypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaringMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 20527, 20549);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_12_20599_20620(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 20599, 20620);
                        return return_v;
                    }


                    int
                    f_12_20659_20673(Microsoft.CodeAnalysis.ITypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 20659, 20673);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_12_20643_20674(System.Text.StringBuilder
                    this_param, int
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 20643, 20674);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ISymbol
                    f_12_20897_20920(Microsoft.CodeAnalysis.ITypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 20897, 20920);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ISymbol?
                    f_12_20897_20938_M(Microsoft.CodeAnalysis.ISymbol?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 20897, 20938);
                        return return_v;
                    }


                    int
                    f_12_20969_21026(Microsoft.CodeAnalysis.ISymbol?
                    symbol)
                    {
                        var return_v = GetTotalTypeParameterCount((Microsoft.CodeAnalysis.INamedTypeSymbol?)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 20969, 21026);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_12_21049_21069(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 21049, 21069);
                        return return_v;
                    }


                    int
                    f_12_21112_21126(Microsoft.CodeAnalysis.ITypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 21112, 21126);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_12_21092_21127(System.Text.StringBuilder
                    this_param, int
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 21092, 21127);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 20068, 21194);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 20068, 21194);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool IsInScope(ITypeParameterSymbol typeParameterSymbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(12, 21210, 21821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 21423, 21488);

                    var
                    typeParameterDeclarer = f_12_21451_21487(typeParameterSymbol)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 21517, 21546);

                        for (var
        scope = _typeParameterContext
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 21508, 21773) || true) && (scope != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 21563, 21593)
        , scope = f_12_21571_21593(scope), DynAbs.Tracing.TraceSender.TraceExitCondition(12, 21508, 21773))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 21508, 21773);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 21635, 21754) || true) && (scope == typeParameterDeclarer)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 21635, 21754);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 21719, 21731);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 21635, 21754);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 1, 266);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(12, 1, 266);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 21793, 21806);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(12, 21210, 21821);

                    Microsoft.CodeAnalysis.ISymbol
                    f_12_21451_21487(Microsoft.CodeAnalysis.ITypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 21451, 21487);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ISymbol
                    f_12_21571_21593(Microsoft.CodeAnalysis.ISymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 21571, 21593);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 21210, 21821);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 21210, 21821);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ReferenceGenerator()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(12, 16724, 21832);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(12, 16724, 21832);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 16724, 21832);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(12, 16724, 21832);
        }
        private static class Parser
        {
            public static bool ParseDeclaredSymbolId(string id, Compilation compilation, List<ISymbol> results)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 21896, 22424);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 22028, 22116) || true) && (id == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 22028, 22116);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 22084, 22097);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 22028, 22116);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 22136, 22227) || true) && (f_12_22140_22149(id) < 2)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 22136, 22227);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 22195, 22208);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 22136, 22227);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 22247, 22261);

                    int
                    index = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 22279, 22295);

                    f_12_22279_22294(results);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 22313, 22366);

                    f_12_22313_22365(id, ref index, compilation, results);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 22384, 22409);

                    return f_12_22391_22404(results) > 0;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 21896, 22424);

                    int
                    f_12_22140_22149(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 22140, 22149);
                        return return_v;
                    }


                    int
                    f_12_22279_22294(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 22279, 22294);
                        return 0;
                    }


                    int
                    f_12_22313_22365(string
                    id, ref int
                    index, Microsoft.CodeAnalysis.Compilation
                    compilation, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    results)
                    {
                        ParseDeclaredId(id, ref index, compilation, results);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 22313, 22365);
                        return 0;
                    }


                    int
                    f_12_22391_22404(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 22391, 22404);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 21896, 22424);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 21896, 22424);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static bool ParseReferencedSymbolId(string id, Compilation compilation, List<ISymbol> results)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 22483, 22908);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 22617, 22705) || true) && (id == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 22617, 22705);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 22673, 22686);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 22617, 22705);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 22725, 22739);

                    int
                    index = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 22757, 22773);

                    f_12_22757_22772(results);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 22791, 22850);

                    f_12_22791_22849(id, ref index, compilation, null, results);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 22868, 22893);

                    return f_12_22875_22888(results) > 0;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 22483, 22908);

                    int
                    f_12_22757_22772(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 22757, 22772);
                        return 0;
                    }


                    int
                    f_12_22791_22849(string
                    id, ref int
                    index, Microsoft.CodeAnalysis.Compilation
                    compilation, Microsoft.CodeAnalysis.ISymbol?
                    typeParameterContext, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    results)
                    {
                        ParseTypeSymbol(id, ref index, compilation, typeParameterContext, results);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 22791, 22849);
                        return 0;
                    }


                    int
                    f_12_22875_22888(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 22875, 22888);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 22483, 22908);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 22483, 22908);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static void ParseDeclaredId(string id, ref int index, Compilation compilation, List<ISymbol> results)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 22924, 28214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 23066, 23105);

                    var
                    kindChar = f_12_23081_23104(id, index)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 23123, 23139);

                    SymbolKind
                    kind
                    = default(SymbolKind);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 23159, 24055);

                    switch (kindChar)
                    {

                        case 'E':
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 23159, 24055);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 23252, 23276);

                            kind = SymbolKind.Event;
                            DynAbs.Tracing.TraceSender.TraceBreak(12, 23302, 23308);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 23159, 24055);

                        case 'F':
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 23159, 24055);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 23365, 23389);

                            kind = SymbolKind.Field;
                            DynAbs.Tracing.TraceSender.TraceBreak(12, 23415, 23421);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 23159, 24055);

                        case 'M':
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 23159, 24055);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 23478, 23503);

                            kind = SymbolKind.Method;
                            DynAbs.Tracing.TraceSender.TraceBreak(12, 23529, 23535);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 23159, 24055);

                        case 'N':
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 23159, 24055);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 23592, 23620);

                            kind = SymbolKind.Namespace;
                            DynAbs.Tracing.TraceSender.TraceBreak(12, 23646, 23652);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 23159, 24055);

                        case 'P':
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 23159, 24055);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 23709, 23736);

                            kind = SymbolKind.Property;
                            DynAbs.Tracing.TraceSender.TraceBreak(12, 23762, 23768);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 23159, 24055);

                        case 'T':
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 23159, 24055);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 23825, 23853);

                            kind = SymbolKind.NamedType;
                            DynAbs.Tracing.TraceSender.TraceBreak(12, 23879, 23885);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 23159, 24055);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 23159, 24055);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 24029, 24036);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 23159, 24055);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 24075, 24083);

                    index++;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 24101, 24204) || true) && (f_12_24105_24128(id, index) == ':')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 24101, 24204);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 24177, 24185);

                        index++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 24101, 24204);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 24224, 24278);

                    var
                    containers = f_12_24241_24277(s_namespaceOrTypeListPool)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 24340, 24384);

                        f_12_24340_24383(containers, f_12_24355_24382(compilation));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 24408, 24420);

                        string
                        name
                        = default(string);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 24442, 24452);

                        int
                        arity
                        = default(int);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 24521, 26917) || true) && (true)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 24521, 26917);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 24582, 24614);

                                name = f_12_24589_24613(id, ref index);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 24640, 24650);

                                arity = 0;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 24727, 25152) || true) && (f_12_24731_24754(id, index) == '`')
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 24727, 25152);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 24819, 24827);

                                    index++;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 24915, 25054) || true) && (f_12_24919_24942(id, index) == '`')
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 24915, 25054);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 25015, 25023);

                                        index++;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 24915, 25054);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 25086, 25125);

                                    arity = f_12_25094_25124(id, ref index);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 24727, 25152);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 25180, 26894) || true) && (f_12_25184_25207(id, index) == '.')
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 25180, 26894);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 25363, 25371);

                                    index++;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 25403, 26183) || true) && (arity > 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 25403, 26183);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 25540, 25591);

                                        f_12_25540_25590(containers, name, arity, results);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 25403, 26183);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 25403, 26183);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 25657, 26183) || true) && (kind == SymbolKind.Namespace)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 25657, 26183);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 25866, 25915);

                                            f_12_25866_25914(containers, name, results);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 25657, 26183);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 25657, 26183);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 26097, 26152);

                                            f_12_26097_26151(containers, name, results);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 25657, 26183);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 25403, 26183);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 26215, 26423) || true) && (f_12_26219_26232(results) == 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 26215, 26423);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 26385, 26392);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 26215, 26423);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 26521, 26540);

                                    f_12_26521_26539(
                                                                // results become the new containers
                                                                containers);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 26570, 26632);

                                    f_12_26570_26631(containers, f_12_26590_26630(results));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 26662, 26678);

                                    f_12_26662_26677(results);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 25180, 26894);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 25180, 26894);
                                    DynAbs.Tracing.TraceSender.TraceBreak(12, 26861, 26867);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 25180, 26894);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 24521, 26917);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 24521, 26917);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(12, 24521, 26917);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 26941, 28044);

                        switch (kind)
                        {

                            case SymbolKind.Method:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 26941, 28044);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 27056, 27137);

                                f_12_27056_27136(id, ref index, containers, name, arity, compilation, results);
                                DynAbs.Tracing.TraceSender.TraceBreak(12, 27167, 27173);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 26941, 28044);

                            case SymbolKind.NamedType:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 26941, 28044);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 27255, 27306);

                                f_12_27255_27305(containers, name, arity, results);
                                DynAbs.Tracing.TraceSender.TraceBreak(12, 27336, 27342);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 26941, 28044);

                            case SymbolKind.Property:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 26941, 28044);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 27423, 27500);

                                f_12_27423_27499(id, ref index, containers, name, compilation, results);
                                DynAbs.Tracing.TraceSender.TraceBreak(12, 27530, 27536);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 26941, 28044);

                            case SymbolKind.Event:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 26941, 28044);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 27614, 27659);

                                f_12_27614_27658(containers, name, results);
                                DynAbs.Tracing.TraceSender.TraceBreak(12, 27689, 27695);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 26941, 28044);

                            case SymbolKind.Field:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 26941, 28044);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 27773, 27818);

                                f_12_27773_27817(containers, name, results);
                                DynAbs.Tracing.TraceSender.TraceBreak(12, 27848, 27854);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 26941, 28044);

                            case SymbolKind.Namespace:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 26941, 28044);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 27936, 27985);

                                f_12_27936_27984(containers, name, results);
                                DynAbs.Tracing.TraceSender.TraceBreak(12, 28015, 28021);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 26941, 28044);
                        }
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(12, 28081, 28199);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 28129, 28180);

                        f_12_28129_28179(s_namespaceOrTypeListPool, containers);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(12, 28081, 28199);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 22924, 28214);

                    char
                    f_12_23081_23104(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 23081, 23104);
                        return return_v;
                    }


                    char
                    f_12_24105_24128(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 24105, 24128);
                        return return_v;
                    }


                    System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    f_12_24241_24277(Microsoft.CodeAnalysis.DocumentationCommentId.ListPool<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.Allocate();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 24241, 24277);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamespaceSymbol
                    f_12_24355_24382(Microsoft.CodeAnalysis.Compilation
                    this_param)
                    {
                        var return_v = this_param.GlobalNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 24355, 24382);
                        return return_v;
                    }


                    int
                    f_12_24340_24383(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    this_param, Microsoft.CodeAnalysis.INamespaceSymbol
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.INamespaceOrTypeSymbol)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 24340, 24383);
                        return 0;
                    }


                    string
                    f_12_24589_24613(string
                    id, ref int
                    index)
                    {
                        var return_v = ParseName(id, ref index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 24589, 24613);
                        return return_v;
                    }


                    char
                    f_12_24731_24754(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 24731, 24754);
                        return return_v;
                    }


                    char
                    f_12_24919_24942(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 24919, 24942);
                        return return_v;
                    }


                    int
                    f_12_25094_25124(string
                    id, ref int
                    index)
                    {
                        var return_v = ReadNextInteger(id, ref index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 25094, 25124);
                        return return_v;
                    }


                    char
                    f_12_25184_25207(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 25184, 25207);
                        return return_v;
                    }


                    int
                    f_12_25540_25590(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    containers, string
                    memberName, int
                    arity, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    results)
                    {
                        GetMatchingTypes(containers, memberName, arity, results);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 25540, 25590);
                        return 0;
                    }


                    int
                    f_12_25866_25914(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    containers, string
                    memberName, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    results)
                    {
                        GetMatchingNamespaces(containers, memberName, results);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 25866, 25914);
                        return 0;
                    }


                    int
                    f_12_26097_26151(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    containers, string
                    memberName, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    results)
                    {
                        GetMatchingNamespaceOrTypes(containers, memberName, results);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 26097, 26151);
                        return 0;
                    }


                    int
                    f_12_26219_26232(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 26219, 26232);
                        return return_v;
                    }


                    int
                    f_12_26521_26539(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 26521, 26539);
                        return 0;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    f_12_26590_26630(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    source)
                    {
                        var return_v = source.OfType<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 26590, 26630);
                        return return_v;
                    }


                    int
                    f_12_26570_26631(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    collection)
                    {
                        this_param.AddRange(collection);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 26570, 26631);
                        return 0;
                    }


                    int
                    f_12_26662_26677(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 26662, 26677);
                        return 0;
                    }


                    int
                    f_12_27056_27136(string
                    id, ref int
                    index, System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    containers, string
                    memberName, int
                    arity, Microsoft.CodeAnalysis.Compilation
                    compilation, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    results)
                    {
                        GetMatchingMethods(id, ref index, containers, memberName, arity, compilation, results);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 27056, 27136);
                        return 0;
                    }


                    int
                    f_12_27255_27305(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    containers, string
                    memberName, int
                    arity, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    results)
                    {
                        GetMatchingTypes(containers, memberName, arity, results);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 27255, 27305);
                        return 0;
                    }


                    int
                    f_12_27423_27499(string
                    id, ref int
                    index, System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    containers, string
                    memberName, Microsoft.CodeAnalysis.Compilation
                    compilation, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    results)
                    {
                        GetMatchingProperties(id, ref index, containers, memberName, compilation, results);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 27423, 27499);
                        return 0;
                    }


                    int
                    f_12_27614_27658(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    containers, string
                    memberName, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    results)
                    {
                        GetMatchingEvents(containers, memberName, results);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 27614, 27658);
                        return 0;
                    }


                    int
                    f_12_27773_27817(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    containers, string
                    memberName, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    results)
                    {
                        GetMatchingFields(containers, memberName, results);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 27773, 27817);
                        return 0;
                    }


                    int
                    f_12_27936_27984(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    containers, string
                    memberName, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    results)
                    {
                        GetMatchingNamespaces(containers, memberName, results);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 27936, 27984);
                        return 0;
                    }


                    int
                    f_12_28129_28179(Microsoft.CodeAnalysis.DocumentationCommentId.ListPool<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    list)
                    {
                        this_param.ClearAndFree(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 28129, 28179);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 22924, 28214);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 22924, 28214);
                }
            }

            private static ITypeSymbol? ParseTypeSymbol(string id, ref int index, Compilation compilation, ISymbol? typeParameterContext)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 28230, 28983);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 28388, 28430);

                    var
                    results = f_12_28402_28429(s_symbolListPool)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 28492, 28567);

                        f_12_28492_28566(id, ref index, compilation, typeParameterContext, results);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 28589, 28825) || true) && (f_12_28593_28606(results) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 28589, 28825);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 28661, 28673);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 28589, 28825);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 28589, 28825);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 28771, 28802);

                            return (ITypeSymbol)f_12_28791_28801(results, 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 28589, 28825);
                        }
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(12, 28862, 28968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 28910, 28949);

                        f_12_28910_28948(s_symbolListPool, results);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(12, 28862, 28968);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 28230, 28983);

                    System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    f_12_28402_28429(Microsoft.CodeAnalysis.DocumentationCommentId.ListPool<Microsoft.CodeAnalysis.ISymbol>
                    this_param)
                    {
                        var return_v = this_param.Allocate();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 28402, 28429);
                        return return_v;
                    }


                    int
                    f_12_28492_28566(string
                    id, ref int
                    index, Microsoft.CodeAnalysis.Compilation
                    compilation, Microsoft.CodeAnalysis.ISymbol?
                    typeParameterContext, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    results)
                    {
                        ParseTypeSymbol(id, ref index, compilation, typeParameterContext, results);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 28492, 28566);
                        return 0;
                    }


                    int
                    f_12_28593_28606(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 28593, 28606);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ISymbol
                    f_12_28791_28801(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 28791, 28801);
                        return return_v;
                    }


                    int
                    f_12_28910_28948(Microsoft.CodeAnalysis.DocumentationCommentId.ListPool<Microsoft.CodeAnalysis.ISymbol>
                    this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    list)
                    {
                        this_param.ClearAndFree(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 28910, 28948);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 28230, 28983);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 28230, 28983);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static void ParseTypeSymbol(string id, ref int index, Compilation compilation, ISymbol? typeParameterContext, List<ISymbol> results)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 28999, 32613);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 29172, 29205);

                    var
                    ch = f_12_29181_29204(id, index)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 29396, 32598) || true) && ((ch == 'M' || (DynAbs.Tracing.TraceSender.Expression_False(12, 29401, 29423) || ch == 'T')) && (DynAbs.Tracing.TraceSender.Expression_True(12, 29400, 29462) && f_12_29428_29455(id, index + 1) == ':'))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 29396, 32598);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 29504, 29547);

                        var
                        contexts = f_12_29519_29546(s_symbolListPool)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 29621, 29675);

                            f_12_29621_29674(id, ref index, compilation, contexts);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 29701, 29882) || true) && (f_12_29705_29719(contexts) == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 29701, 29882);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 29848, 29855);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 29701, 29882);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 29910, 30684) || true) && (f_12_29914_29937(id, index) == ':')
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 29910, 30684);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 30002, 30010);

                                index++;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 30112, 30135);

                                var
                                startIndex = index
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 30165, 30409);
                                    foreach (var context in f_12_30189_30197_I(contexts))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 30165, 30409);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 30263, 30282);

                                        index = startIndex;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 30316, 30378);

                                        f_12_30316_30377(id, ref index, compilation, context, results);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 30165, 30409);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 1, 245);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(12, 1, 245);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 29910, 30684);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 29910, 30684);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 30608, 30657);

                                f_12_30608_30656(                            // this was a definition where we expected a reference?
                                                            results, f_12_30625_30655(contexts));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 29910, 30684);
                            }
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(12, 30729, 30848);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 30785, 30825);

                            f_12_30785_30824(s_symbolListPool, contexts);
                            DynAbs.Tracing.TraceSender.TraceExitFinally(12, 30729, 30848);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 29396, 32598);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 29396, 32598);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 30930, 31265) || true) && (ch == '`')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 30930, 31265);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 30993, 31064);

                            f_12_30993_31063(id, ref index, typeParameterContext, results);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 30930, 31265);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 30930, 31265);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 31162, 31242);

                            f_12_31162_31241(id, ref index, compilation, typeParameterContext, results);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 30930, 31265);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 31365, 31388);

                        var
                        startIndex = index
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 31410, 31431);

                        var
                        endIndex = index
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 31464, 31469);

                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 31455, 32538) || true) && (i < f_12_31475_31488(results))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 31490, 31493)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(12, 31455, 32538))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 31455, 32538);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 31543, 31562);

                                index = startIndex;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 31588, 31629);

                                var
                                typeSymbol = (ITypeSymbol)f_12_31618_31628(results, i)
                                ;
                                try
                                {
                                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 31657, 32420) || true) && (true)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 31657, 32420);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 31726, 32046) || true) && (f_12_31730_31753(id, index) == '[')
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 31726, 32046);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 31826, 31871);

                                            var
                                            bounds = f_12_31839_31870(id, ref index)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 31905, 31972);

                                            typeSymbol = f_12_31918_31971(compilation, typeSymbol, bounds);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 32006, 32015);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 31726, 32046);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 32078, 32355) || true) && (f_12_32082_32105(id, index) == '*')
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 32078, 32355);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 32178, 32186);

                                            index++;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 32220, 32281);

                                            typeSymbol = f_12_32233_32280(compilation, typeSymbol);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 32315, 32324);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 32078, 32355);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(12, 32387, 32393);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 31657, 32420);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 31657, 32420);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(12, 31657, 32420);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 32448, 32472);

                                results[i] = typeSymbol;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 32498, 32515);

                                endIndex = index;
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 1, 1084);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(12, 1, 1084);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 32562, 32579);

                        index = endIndex;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 29396, 32598);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 28999, 32613);

                    char
                    f_12_29181_29204(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 29181, 29204);
                        return return_v;
                    }


                    char
                    f_12_29428_29455(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 29428, 29455);
                        return return_v;
                    }


                    System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    f_12_29519_29546(Microsoft.CodeAnalysis.DocumentationCommentId.ListPool<Microsoft.CodeAnalysis.ISymbol>
                    this_param)
                    {
                        var return_v = this_param.Allocate();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 29519, 29546);
                        return return_v;
                    }


                    int
                    f_12_29621_29674(string
                    id, ref int
                    index, Microsoft.CodeAnalysis.Compilation
                    compilation, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    results)
                    {
                        ParseDeclaredId(id, ref index, compilation, results);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 29621, 29674);
                        return 0;
                    }


                    int
                    f_12_29705_29719(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 29705, 29719);
                        return return_v;
                    }


                    char
                    f_12_29914_29937(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 29914, 29937);
                        return return_v;
                    }


                    int
                    f_12_30316_30377(string
                    id, ref int
                    index, Microsoft.CodeAnalysis.Compilation
                    compilation, Microsoft.CodeAnalysis.ISymbol
                    typeParameterContext, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    results)
                    {
                        ParseTypeSymbol(id, ref index, compilation, typeParameterContext, results);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 30316, 30377);
                        return 0;
                    }


                    System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    f_12_30189_30197_I(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 30189, 30197);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ITypeSymbol>
                    f_12_30625_30655(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    source)
                    {
                        var return_v = source.OfType<Microsoft.CodeAnalysis.ITypeSymbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 30625, 30655);
                        return return_v;
                    }


                    int
                    f_12_30608_30656(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ITypeSymbol>
                    collection)
                    {
                        this_param.AddRange((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>)collection);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 30608, 30656);
                        return 0;
                    }


                    int
                    f_12_30785_30824(Microsoft.CodeAnalysis.DocumentationCommentId.ListPool<Microsoft.CodeAnalysis.ISymbol>
                    this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    list)
                    {
                        this_param.ClearAndFree(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 30785, 30824);
                        return 0;
                    }


                    int
                    f_12_30993_31063(string
                    id, ref int
                    index, Microsoft.CodeAnalysis.ISymbol?
                    typeParameterContext, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    results)
                    {
                        ParseTypeParameterSymbol(id, ref index, typeParameterContext, results);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 30993, 31063);
                        return 0;
                    }


                    int
                    f_12_31162_31241(string
                    id, ref int
                    index, Microsoft.CodeAnalysis.Compilation
                    compilation, Microsoft.CodeAnalysis.ISymbol?
                    typeParameterContext, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    results)
                    {
                        ParseNamedTypeSymbol(id, ref index, compilation, typeParameterContext, results);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 31162, 31241);
                        return 0;
                    }


                    int
                    f_12_31475_31488(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 31475, 31488);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ISymbol
                    f_12_31618_31628(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 31618, 31628);
                        return return_v;
                    }


                    char
                    f_12_31730_31753(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 31730, 31753);
                        return return_v;
                    }


                    int
                    f_12_31839_31870(string
                    id, ref int
                    index)
                    {
                        var return_v = ParseArrayBounds(id, ref index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 31839, 31870);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IArrayTypeSymbol
                    f_12_31918_31971(Microsoft.CodeAnalysis.Compilation
                    this_param, Microsoft.CodeAnalysis.ITypeSymbol
                    elementType, int
                    rank)
                    {
                        var return_v = this_param.CreateArrayTypeSymbol(elementType, rank);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 31918, 31971);
                        return return_v;
                    }


                    char
                    f_12_32082_32105(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 32082, 32105);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IPointerTypeSymbol
                    f_12_32233_32280(Microsoft.CodeAnalysis.Compilation
                    this_param, Microsoft.CodeAnalysis.ITypeSymbol
                    pointedAtType)
                    {
                        var return_v = this_param.CreatePointerTypeSymbol(pointedAtType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 32233, 32280);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 28999, 32613);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 28999, 32613);
                }
            }

            private static void ParseTypeParameterSymbol(string id, ref int index, ISymbol? typeParameterContext, List<ISymbol> results)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 32629, 34267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 32823, 32887);

                    f_12_32823_32886(f_12_32855_32878(id, index) == '`');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 32905, 32913);

                    index++;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 32933, 34252) || true) && (f_12_32937_32960(id, index) == '`')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 32933, 34252);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 33074, 33082);

                        index++;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 33104, 33166);

                        var
                        methodTypeParameterIndex = f_12_33135_33165(id, ref index)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 33190, 33248);

                        var
                        methodContext = typeParameterContext as IMethodSymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 33270, 33644) || true) && (methodContext != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 33270, 33644);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 33345, 33393);

                            var
                            count = methodContext.TypeParameters.Length
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 33419, 33621) || true) && (count > 0 && (DynAbs.Tracing.TraceSender.Expression_True(12, 33423, 33468) && methodTypeParameterIndex < count))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 33419, 33621);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 33526, 33594);

                                f_12_33526_33593(results, f_12_33538_33566(methodContext)[methodTypeParameterIndex]);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 33419, 33621);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 33270, 33644);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 32933, 34252);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 32933, 34252);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 33773, 33829);

                        var
                        typeParameterIndex = f_12_33798_33828(id, ref index)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 33853, 33911);

                        var
                        methodContext = typeParameterContext as IMethodSymbol
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 33933, 34047);

                        var
                        typeContext = (DynAbs.Tracing.TraceSender.Conditional_F1(12, 33951, 33972) || ((methodContext != null && DynAbs.Tracing.TraceSender.Conditional_F2(12, 33975, 34003)) || DynAbs.Tracing.TraceSender.Conditional_F3(12, 34006, 34046))) ? f_12_33975_34003(methodContext) : typeParameterContext as INamedTypeSymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 34071, 34233) || true) && (typeContext != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 34071, 34233);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 34144, 34210);

                            f_12_34144_34209(results, f_12_34156_34208(typeContext, typeParameterIndex));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 34071, 34233);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 32933, 34252);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 32629, 34267);

                    char
                    f_12_32855_32878(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 32855, 32878);
                        return return_v;
                    }


                    int
                    f_12_32823_32886(bool
                    condition)
                    {
                        System.Diagnostics.Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 32823, 32886);
                        return 0;
                    }


                    char
                    f_12_32937_32960(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 32937, 32960);
                        return return_v;
                    }


                    int
                    f_12_33135_33165(string
                    id, ref int
                    index)
                    {
                        var return_v = ReadNextInteger(id, ref index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 33135, 33165);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeParameterSymbol>
                    f_12_33538_33566(Microsoft.CodeAnalysis.IMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 33538, 33566);
                        return return_v;
                    }


                    int
                    f_12_33526_33593(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    this_param, Microsoft.CodeAnalysis.ITypeParameterSymbol
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.ISymbol)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 33526, 33593);
                        return 0;
                    }


                    int
                    f_12_33798_33828(string
                    id, ref int
                    index)
                    {
                        var return_v = ReadNextInteger(id, ref index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 33798, 33828);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamedTypeSymbol
                    f_12_33975_34003(Microsoft.CodeAnalysis.IMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 33975, 34003);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ITypeParameterSymbol
                    f_12_34156_34208(Microsoft.CodeAnalysis.INamedTypeSymbol
                    typeSymbol, int
                    n)
                    {
                        var return_v = GetNthTypeParameter(typeSymbol, n);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 34156, 34208);
                        return return_v;
                    }


                    int
                    f_12_34144_34209(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    this_param, Microsoft.CodeAnalysis.ITypeParameterSymbol
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.ISymbol)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 34144, 34209);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 32629, 34267);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 32629, 34267);
                }
            }

            private static void ParseNamedTypeSymbol(string id, ref int index, Compilation compilation, ISymbol? typeParameterContext, List<ISymbol> results)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 34283, 37174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 34461, 34515);

                    var
                    containers = f_12_34478_34514(s_namespaceOrTypeListPool)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 34577, 34621);

                        f_12_34577_34620(containers, f_12_34592_34619(compilation));
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 34691, 37004) || true) && (true)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 34691, 37004);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 34752, 34788);

                                var
                                name = f_12_34763_34787(id, ref index)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 34816, 34856);

                                List<ITypeSymbol>?
                                typeArguments = null
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 34882, 34896);

                                int
                                arity = 0
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 34967, 35739) || true) && (f_12_34971_34994(id, index) == '{')
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 34967, 35739);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 35059, 35099);

                                    typeArguments = f_12_35075_35098();

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 35129, 35425) || true) && (!f_12_35134_35217(id, ref index, compilation, typeParameterContext, typeArguments))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 35129, 35425);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 35385, 35394);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 35129, 35425);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 35457, 35485);

                                    arity = f_12_35465_35484(typeArguments);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 34967, 35739);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 34967, 35739);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 35543, 35739) || true) && (f_12_35547_35570(id, index) == '`')
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 35543, 35739);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 35635, 35643);

                                        index++;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 35673, 35712);

                                        arity = f_12_35681_35711(id, ref index);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 35543, 35739);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 34967, 35739);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 35767, 36600) || true) && (arity != 0 || (DynAbs.Tracing.TraceSender.Expression_False(12, 35771, 35815) || f_12_35785_35808(id, index) != '.'))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 35767, 36600);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 35873, 35924);

                                    f_12_35873_35923(containers, name, arity, results);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 35956, 36404) || true) && (arity != 0 && (DynAbs.Tracing.TraceSender.Expression_True(12, 35960, 35995) && typeArguments != null) && (DynAbs.Tracing.TraceSender.Expression_True(12, 35960, 36023) && f_12_35999_36018(typeArguments) != 0))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 35956, 36404);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 36089, 36128);

                                        var
                                        typeArgs = f_12_36104_36127(typeArguments)
                                        ;
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 36171, 36176);
                                            for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 36162, 36373) || true) && (i < f_12_36182_36195(results))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 36197, 36200)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(12, 36162, 36373))

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 36162, 36373);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 36274, 36338);

                                                results[i] = f_12_36287_36337(((INamedTypeSymbol)f_12_36306_36316(results, i)), typeArgs);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 1, 212);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(12, 1, 212);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 35956, 36404);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 35767, 36600);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 35767, 36600);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 36518, 36573);

                                    f_12_36518_36572(containers, name, results);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 35767, 36600);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 36628, 36947) || true) && (f_12_36632_36655(id, index) == '.')
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 36628, 36947);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 36720, 36728);

                                    index++;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 36758, 36777);

                                    f_12_36758_36776(containers);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 36807, 36835);

                                    f_12_36807_36834(results, containers);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 36865, 36881);

                                    f_12_36865_36880(results);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 36911, 36920);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 36628, 36947);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(12, 36975, 36981);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 34691, 37004);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 34691, 37004);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(12, 34691, 37004);
                        }
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(12, 37041, 37159);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 37089, 37140);

                        f_12_37089_37139(s_namespaceOrTypeListPool, containers);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(12, 37041, 37159);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 34283, 37174);

                    System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    f_12_34478_34514(Microsoft.CodeAnalysis.DocumentationCommentId.ListPool<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.Allocate();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 34478, 34514);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamespaceSymbol
                    f_12_34592_34619(Microsoft.CodeAnalysis.Compilation
                    this_param)
                    {
                        var return_v = this_param.GlobalNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 34592, 34619);
                        return return_v;
                    }


                    int
                    f_12_34577_34620(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    this_param, Microsoft.CodeAnalysis.INamespaceSymbol
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.INamespaceOrTypeSymbol)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 34577, 34620);
                        return 0;
                    }


                    string
                    f_12_34763_34787(string
                    id, ref int
                    index)
                    {
                        var return_v = ParseName(id, ref index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 34763, 34787);
                        return return_v;
                    }


                    char
                    f_12_34971_34994(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 34971, 34994);
                        return return_v;
                    }


                    System.Collections.Generic.List<Microsoft.CodeAnalysis.ITypeSymbol>
                    f_12_35075_35098()
                    {
                        var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.ITypeSymbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 35075, 35098);
                        return return_v;
                    }


                    bool
                    f_12_35134_35217(string
                    id, ref int
                    index, Microsoft.CodeAnalysis.Compilation
                    compilation, Microsoft.CodeAnalysis.ISymbol?
                    typeParameterContext, System.Collections.Generic.List<Microsoft.CodeAnalysis.ITypeSymbol>
                    typeArguments)
                    {
                        var return_v = ParseTypeArguments(id, ref index, compilation, typeParameterContext, typeArguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 35134, 35217);
                        return return_v;
                    }


                    int
                    f_12_35465_35484(System.Collections.Generic.List<Microsoft.CodeAnalysis.ITypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 35465, 35484);
                        return return_v;
                    }


                    char
                    f_12_35547_35570(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 35547, 35570);
                        return return_v;
                    }


                    int
                    f_12_35681_35711(string
                    id, ref int
                    index)
                    {
                        var return_v = ReadNextInteger(id, ref index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 35681, 35711);
                        return return_v;
                    }


                    char
                    f_12_35785_35808(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 35785, 35808);
                        return return_v;
                    }


                    int
                    f_12_35873_35923(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    containers, string
                    memberName, int
                    arity, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    results)
                    {
                        GetMatchingTypes(containers, memberName, arity, results);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 35873, 35923);
                        return 0;
                    }


                    int
                    f_12_35999_36018(System.Collections.Generic.List<Microsoft.CodeAnalysis.ITypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 35999, 36018);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ITypeSymbol[]
                    f_12_36104_36127(System.Collections.Generic.List<Microsoft.CodeAnalysis.ITypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.ToArray();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 36104, 36127);
                        return return_v;
                    }


                    int
                    f_12_36182_36195(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 36182, 36195);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ISymbol
                    f_12_36306_36316(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 36306, 36316);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamedTypeSymbol
                    f_12_36287_36337(Microsoft.CodeAnalysis.INamedTypeSymbol
                    this_param, params Microsoft.CodeAnalysis.ITypeSymbol[]
                    typeArguments)
                    {
                        var return_v = this_param.Construct(typeArguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 36287, 36337);
                        return return_v;
                    }


                    int
                    f_12_36518_36572(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    containers, string
                    memberName, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    results)
                    {
                        GetMatchingNamespaceOrTypes(containers, memberName, results);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 36518, 36572);
                        return 0;
                    }


                    char
                    f_12_36632_36655(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 36632, 36655);
                        return return_v;
                    }


                    int
                    f_12_36758_36776(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 36758, 36776);
                        return 0;
                    }


                    int
                    f_12_36807_36834(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    source, System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    destination)
                    {
                        CopyTo(source, destination);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 36807, 36834);
                        return 0;
                    }


                    int
                    f_12_36865_36880(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 36865, 36880);
                        return 0;
                    }


                    int
                    f_12_37089_37139(Microsoft.CodeAnalysis.DocumentationCommentId.ListPool<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    list)
                    {
                        this_param.ClearAndFree(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 37089, 37139);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 34283, 37174);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 34283, 37174);
                }
            }

            private static int ParseArrayBounds(string id, ref int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 37190, 38310);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 37284, 37292);

                    index++;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 37325, 37340);

                    int
                    bounds = 0
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 37360, 38138) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 37360, 38138);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 37413, 37558) || true) && (f_12_37417_37454(f_12_37430_37453(id, index)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 37413, 37558);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 37504, 37535);

                                f_12_37504_37534(id, ref index);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 37413, 37558);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 37582, 37882) || true) && (f_12_37586_37609(id, index) == ':')
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 37582, 37882);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 37666, 37674);

                                index++;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 37702, 37859) || true) && (f_12_37706_37743(f_12_37719_37742(id, index)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 37702, 37859);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 37801, 37832);

                                    f_12_37801_37831(id, ref index);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 37702, 37859);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 37582, 37882);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 37906, 37915);

                            bounds++;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 37939, 38089) || true) && (f_12_37943_37966(id, index) == ',')
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 37939, 38089);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 38023, 38031);

                                index++;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 38057, 38066);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 37939, 38089);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(12, 38113, 38119);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 37360, 38138);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 37360, 38138);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(12, 37360, 38138);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 38158, 38261) || true) && (f_12_38162_38185(id, index) == ']')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 38158, 38261);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 38234, 38242);

                        index++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 38158, 38261);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 38281, 38295);

                    return bounds;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 37190, 38310);

                    char
                    f_12_37430_37453(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 37430, 37453);
                        return return_v;
                    }


                    bool
                    f_12_37417_37454(char
                    c)
                    {
                        var return_v = char.IsDigit(c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 37417, 37454);
                        return return_v;
                    }


                    int
                    f_12_37504_37534(string
                    id, ref int
                    index)
                    {
                        var return_v = ReadNextInteger(id, ref index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 37504, 37534);
                        return return_v;
                    }


                    char
                    f_12_37586_37609(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 37586, 37609);
                        return return_v;
                    }


                    char
                    f_12_37719_37742(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 37719, 37742);
                        return return_v;
                    }


                    bool
                    f_12_37706_37743(char
                    c)
                    {
                        var return_v = char.IsDigit(c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 37706, 37743);
                        return return_v;
                    }


                    int
                    f_12_37801_37831(string
                    id, ref int
                    index)
                    {
                        var return_v = ReadNextInteger(id, ref index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 37801, 37831);
                        return return_v;
                    }


                    char
                    f_12_37943_37966(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 37943, 37966);
                        return return_v;
                    }


                    char
                    f_12_38162_38185(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 38162, 38185);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 37190, 38310);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 37190, 38310);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static bool ParseTypeArguments(string id, ref int index, Compilation compilation, ISymbol? typeParameterContext, List<ITypeSymbol> typeArguments)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 38326, 39384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 38512, 38520);

                    index++;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 38555, 39214) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 38555, 39214);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 38608, 38685);

                            var
                            type = f_12_38619_38684(id, ref index, compilation, typeParameterContext)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 38709, 38905) || true) && (type == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 38709, 38905);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 38869, 38882);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 38709, 38905);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 38967, 38991);

                            f_12_38967_38990(
                                                // add first one
                                                typeArguments, type);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 39015, 39165) || true) && (f_12_39019_39042(id, index) == ',')
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 39015, 39165);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 39099, 39107);

                                index++;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 39133, 39142);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 39015, 39165);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(12, 39189, 39195);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 38555, 39214);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 38555, 39214);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(12, 38555, 39214);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 39234, 39337) || true) && (f_12_39238_39261(id, index) == '}')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 39234, 39337);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 39310, 39318);

                        index++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 39234, 39337);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 39357, 39369);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 38326, 39384);

                    Microsoft.CodeAnalysis.ITypeSymbol?
                    f_12_38619_38684(string
                    id, ref int
                    index, Microsoft.CodeAnalysis.Compilation
                    compilation, Microsoft.CodeAnalysis.ISymbol?
                    typeParameterContext)
                    {
                        var return_v = ParseTypeSymbol(id, ref index, compilation, typeParameterContext);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 38619, 38684);
                        return return_v;
                    }


                    int
                    f_12_38967_38990(System.Collections.Generic.List<Microsoft.CodeAnalysis.ITypeSymbol>
                    this_param, Microsoft.CodeAnalysis.ITypeSymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 38967, 38990);
                        return 0;
                    }


                    char
                    f_12_39019_39042(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 39019, 39042);
                        return return_v;
                    }


                    char
                    f_12_39238_39261(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 39238, 39261);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 38326, 39384);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 38326, 39384);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static void GetMatchingTypes(List<INamespaceOrTypeSymbol> containers, string memberName, int arity, List<ISymbol> results)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 39400, 39747);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 39572, 39577);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 39579, 39599);
                        for (int
        i = 0
        ,
        n = f_12_39583_39599(containers)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 39563, 39732) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 39608, 39611)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(12, 39563, 39732))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 39563, 39732);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 39653, 39713);

                            f_12_39653_39712(f_12_39670_39683(containers, i), memberName, arity, results);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 1, 170);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(12, 1, 170);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 39400, 39747);

                    int
                    f_12_39583_39599(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 39583, 39599);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                    f_12_39670_39683(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 39670, 39683);
                        return return_v;
                    }


                    int
                    f_12_39653_39712(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                    container, string
                    memberName, int
                    arity, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    results)
                    {
                        GetMatchingTypes(container, memberName, arity, results);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 39653, 39712);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 39400, 39747);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 39400, 39747);
                }
            }

            private static void GetMatchingTypes(INamespaceOrTypeSymbol container, string memberName, int arity, List<ISymbol> results)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 39763, 40407);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 39919, 39966);

                    var
                    members = f_12_39933_39965(container, memberName)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 39986, 40392);
                        foreach (var symbol in f_12_40009_40016_I(members))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 39986, 40392);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 40058, 40373) || true) && (f_12_40062_40073(symbol) == SymbolKind.NamedType)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 40058, 40373);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 40147, 40188);

                                var
                                namedType = (INamedTypeSymbol)symbol
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 40214, 40350) || true) && (f_12_40218_40233(namedType) == arity)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 40214, 40350);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 40300, 40323);

                                    f_12_40300_40322(results, namedType);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 40214, 40350);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 40058, 40373);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 39986, 40392);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 1, 407);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(12, 1, 407);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 39763, 40407);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_12_39933_39965(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetMembers(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 39933, 39965);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_12_40062_40073(Microsoft.CodeAnalysis.ISymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 40062, 40073);
                        return return_v;
                    }


                    int
                    f_12_40218_40233(Microsoft.CodeAnalysis.INamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 40218, 40233);
                        return return_v;
                    }


                    int
                    f_12_40300_40322(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.ISymbol)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 40300, 40322);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_12_40009_40016_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 40009, 40016);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 39763, 40407);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 39763, 40407);
                }
            }

            private static void GetMatchingNamespaceOrTypes(List<INamespaceOrTypeSymbol> containers, string memberName, List<ISymbol> results)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 40423, 40774);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 40595, 40600);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 40602, 40622);
                        for (int
        i = 0
        ,
        n = f_12_40606_40622(containers)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 40586, 40759) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 40631, 40634)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(12, 40586, 40759))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 40586, 40759);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 40676, 40740);

                            f_12_40676_40739(f_12_40704_40717(containers, i), memberName, results);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 1, 174);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(12, 1, 174);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 40423, 40774);

                    int
                    f_12_40606_40622(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 40606, 40622);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                    f_12_40704_40717(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 40704, 40717);
                        return return_v;
                    }


                    int
                    f_12_40676_40739(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                    container, string
                    memberName, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    results)
                    {
                        GetMatchingNamespaceOrTypes(container, memberName, results);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 40676, 40739);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 40423, 40774);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 40423, 40774);
                }
            }

            private static void GetMatchingNamespaceOrTypes(INamespaceOrTypeSymbol container, string memberName, List<ISymbol> results)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 40790, 41333);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 40946, 40993);

                    var
                    members = f_12_40960_40992(container, memberName)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 41013, 41318);
                        foreach (var symbol in f_12_41036_41043_I(members))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 41013, 41318);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 41085, 41299) || true) && (f_12_41089_41100(symbol) == SymbolKind.Namespace || (DynAbs.Tracing.TraceSender.Expression_False(12, 41089, 41206) || (f_12_41129_41140(symbol) == SymbolKind.NamedType && (DynAbs.Tracing.TraceSender.Expression_True(12, 41129, 41205) && f_12_41168_41200(((INamedTypeSymbol)symbol)) == 0))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 41085, 41299);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 41256, 41276);

                                f_12_41256_41275(results, symbol);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 41085, 41299);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 41013, 41318);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 1, 306);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(12, 1, 306);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 40790, 41333);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_12_40960_40992(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetMembers(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 40960, 40992);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_12_41089_41100(Microsoft.CodeAnalysis.ISymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 41089, 41100);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_12_41129_41140(Microsoft.CodeAnalysis.ISymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 41129, 41140);
                        return return_v;
                    }


                    int
                    f_12_41168_41200(Microsoft.CodeAnalysis.INamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 41168, 41200);
                        return return_v;
                    }


                    int
                    f_12_41256_41275(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 41256, 41275);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_12_41036_41043_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 41036, 41043);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 40790, 41333);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 40790, 41333);
                }
            }

            private static void GetMatchingNamespaces(List<INamespaceOrTypeSymbol> containers, string memberName, List<ISymbol> results)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 41349, 41688);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 41515, 41520);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 41522, 41542);
                        for (int
        i = 0
        ,
        n = f_12_41526_41542(containers)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 41506, 41673) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 41551, 41554)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(12, 41506, 41673))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 41506, 41673);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 41596, 41654);

                            f_12_41596_41653(f_12_41618_41631(containers, i), memberName, results);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 1, 168);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(12, 1, 168);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 41349, 41688);

                    int
                    f_12_41526_41542(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 41526, 41542);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                    f_12_41618_41631(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 41618, 41631);
                        return return_v;
                    }


                    int
                    f_12_41596_41653(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                    container, string
                    memberName, System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    results)
                    {
                        GetMatchingNamespaces(container, memberName, results);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 41596, 41653);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 41349, 41688);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 41349, 41688);
                }
            }

            private static void GetMatchingNamespaces(INamespaceOrTypeSymbol container, string memberName, List<ISymbol> results)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 41704, 42159);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 41854, 41901);

                    var
                    members = f_12_41868_41900(container, memberName)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 41921, 42144);
                        foreach (var symbol in f_12_41944_41951_I(members))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 41921, 42144);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 41993, 42125) || true) && (f_12_41997_42008(symbol) == SymbolKind.Namespace)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 41993, 42125);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 42082, 42102);

                                f_12_42082_42101(results, symbol);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 41993, 42125);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 41921, 42144);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 1, 224);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(12, 1, 224);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 41704, 42159);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_12_41868_41900(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetMembers(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 41868, 41900);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_12_41997_42008(Microsoft.CodeAnalysis.ISymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 41997, 42008);
                        return return_v;
                    }


                    int
                    f_12_42082_42101(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 42082, 42101);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_12_41944_41951_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 41944, 41951);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 41704, 42159);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 41704, 42159);
                }
            }

            private static void GetMatchingMethods(string id, ref int index, List<INamespaceOrTypeSymbol> containers, string memberName, int arity, Compilation compilation, List<ISymbol> results)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 42175, 45365);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 42391, 42439);

                    var
                    parameters = f_12_42408_42438(s_parameterListPool)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 42501, 42524);

                        var
                        startIndex = index
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 42546, 42567);

                        var
                        endIndex = index
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 42600, 42605);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 42607, 42627);

                            for (int
        i = 0
        ,
        n = f_12_42611_42627(containers)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 42591, 45160) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 42636, 42639)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(12, 42591, 45160))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 42591, 45160);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 42689, 42740);

                                var
                                members = f_12_42703_42739(f_12_42703_42716(containers, i), memberName)
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 42768, 45137);
                                    foreach (var symbol in f_12_42791_42798_I(members))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 42768, 45137);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 42856, 42875);

                                        index = startIndex;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 42907, 42950);

                                        var
                                        methodSymbol = symbol as IMethodSymbol
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 42980, 45110) || true) && (methodSymbol != null && (DynAbs.Tracing.TraceSender.Expression_True(12, 42984, 43035) && f_12_43008_43026(methodSymbol) == arity))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 42980, 45110);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 43101, 43120);

                                            f_12_43101_43119(parameters);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 43156, 43656) || true) && (f_12_43160_43183(id, index) == '(')
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 43156, 43656);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 43264, 43621) || true) && (!f_12_43269_43341(id, ref index, compilation, methodSymbol, parameters))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 43264, 43621);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 43573, 43582);

                                                    continue;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 43264, 43621);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 43156, 43656);
                                            }

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 43692, 43957) || true) && (!f_12_43697_43752(f_12_43716_43739(methodSymbol), parameters))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 43692, 43957);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 43913, 43922);

                                                continue;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 43692, 43957);
                                            }

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 43993, 45079) || true) && (f_12_43997_44020(id, index) == '~')
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 43993, 45079);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 44101, 44109);

                                                index++;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 44147, 44231);

                                                ITypeSymbol?
                                                returnType = f_12_44173_44230(id, ref index, compilation, methodSymbol)
                                                ;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 44359, 44734) || true) && (returnType != null && (DynAbs.Tracing.TraceSender.Expression_True(12, 44363, 44464) && f_12_44385_44464(f_12_44385_44408(methodSymbol), returnType, SymbolEqualityComparer.CLRSignature)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 44359, 44734);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 44610, 44636);

                                                    f_12_44610_44635(                                        // return type matches
                                                                                            results, methodSymbol);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 44678, 44695);

                                                    endIndex = index;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 44359, 44734);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 43993, 45079);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 43993, 45079);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 44963, 44989);

                                                f_12_44963_44988(                                    // no return type specified, then any matches
                                                                                    results, methodSymbol);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 45027, 45044);

                                                endIndex = index;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 43993, 45079);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 42980, 45110);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 42768, 45137);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 1, 2370);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(12, 1, 2370);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 1, 2570);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(12, 1, 2570);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 45184, 45201);

                        index = endIndex;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(12, 45238, 45350);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 45286, 45331);

                        f_12_45286_45330(s_parameterListPool, parameters);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(12, 45238, 45350);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 42175, 45365);

                    System.Collections.Generic.List<Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo>
                    f_12_42408_42438(Microsoft.CodeAnalysis.DocumentationCommentId.ListPool<Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo>
                    this_param)
                    {
                        var return_v = this_param.Allocate();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 42408, 42438);
                        return return_v;
                    }


                    int
                    f_12_42611_42627(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 42611, 42627);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                    f_12_42703_42716(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 42703, 42716);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_12_42703_42739(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetMembers(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 42703, 42739);
                        return return_v;
                    }


                    int
                    f_12_43008_43026(Microsoft.CodeAnalysis.IMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 43008, 43026);
                        return return_v;
                    }


                    int
                    f_12_43101_43119(System.Collections.Generic.List<Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo>
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 43101, 43119);
                        return 0;
                    }


                    char
                    f_12_43160_43183(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 43160, 43183);
                        return return_v;
                    }


                    bool
                    f_12_43269_43341(string
                    id, ref int
                    index, Microsoft.CodeAnalysis.Compilation
                    compilation, Microsoft.CodeAnalysis.IMethodSymbol
                    typeParameterContext, System.Collections.Generic.List<Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo>
                    parameters)
                    {
                        var return_v = ParseParameterList(id, ref index, compilation, (Microsoft.CodeAnalysis.ISymbol)typeParameterContext, parameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 43269, 43341);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
                    f_12_43716_43739(Microsoft.CodeAnalysis.IMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 43716, 43739);
                        return return_v;
                    }


                    bool
                    f_12_43697_43752(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
                    symbolParameters, System.Collections.Generic.List<Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo>
                    expectedParameters)
                    {
                        var return_v = AllParametersMatch(symbolParameters, expectedParameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 43697, 43752);
                        return return_v;
                    }


                    char
                    f_12_43997_44020(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 43997, 44020);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ITypeSymbol?
                    f_12_44173_44230(string
                    id, ref int
                    index, Microsoft.CodeAnalysis.Compilation
                    compilation, Microsoft.CodeAnalysis.IMethodSymbol
                    typeParameterContext)
                    {
                        var return_v = ParseTypeSymbol(id, ref index, compilation, (Microsoft.CodeAnalysis.ISymbol)typeParameterContext);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 44173, 44230);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ITypeSymbol
                    f_12_44385_44408(Microsoft.CodeAnalysis.IMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 44385, 44408);
                        return return_v;
                    }


                    bool
                    f_12_44385_44464(Microsoft.CodeAnalysis.ITypeSymbol
                    this_param, Microsoft.CodeAnalysis.ITypeSymbol
                    other, Microsoft.CodeAnalysis.SymbolEqualityComparer
                    equalityComparer)
                    {
                        var return_v = this_param.Equals((Microsoft.CodeAnalysis.ISymbol)other, equalityComparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 44385, 44464);
                        return return_v;
                    }


                    int
                    f_12_44610_44635(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    this_param, Microsoft.CodeAnalysis.IMethodSymbol
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.ISymbol)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 44610, 44635);
                        return 0;
                    }


                    int
                    f_12_44963_44988(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    this_param, Microsoft.CodeAnalysis.IMethodSymbol
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.ISymbol)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 44963, 44988);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_12_42791_42798_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 42791, 42798);
                        return return_v;
                    }


                    int
                    f_12_45286_45330(Microsoft.CodeAnalysis.DocumentationCommentId.ListPool<Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo>
                    this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo>
                    list)
                    {
                        this_param.ClearAndFree(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 45286, 45330);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 42175, 45365);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 42175, 45365);
                }
            }

            private static void GetMatchingProperties(string id, ref int index, List<INamespaceOrTypeSymbol> containers, string memberName, Compilation compilation, List<ISymbol> results)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 45381, 47958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 45589, 45612);

                    int
                    startIndex = index
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 45630, 45651);

                    int
                    endIndex = index
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 45671, 45710);

                    List<ParameterInfo>?
                    parameters = null
                    ;
                    try
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 45781, 45786);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 45788, 45808);
                            for (int
        i = 0
        ,
        n = f_12_45792_45808(containers)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 45772, 47658) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 45817, 45820)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(12, 45772, 47658))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 45772, 47658);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 45870, 45936);

                                memberName = f_12_45883_45935(memberName, f_12_45914_45934(compilation));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 45962, 46013);

                                var
                                members = f_12_45976_46012(f_12_45976_45989(containers, i), memberName)
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 46041, 47635);
                                    foreach (var symbol in f_12_46064_46071_I(members))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 46041, 47635);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 46129, 46148);

                                        index = startIndex;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 46180, 46227);

                                        var
                                        propertySymbol = symbol as IPropertySymbol
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 46257, 47608) || true) && (propertySymbol != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 46257, 47608);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 46349, 47577) || true) && (f_12_46353_46376(id, index) == '(')
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 46349, 47577);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 46457, 46825) || true) && (parameters == null)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 46457, 46825);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 46561, 46605);

                                                    parameters = f_12_46574_46604(s_parameterListPool);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 46457, 46825);
                                                }

                                                else

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 46457, 46825);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 46767, 46786);

                                                    f_12_46767_46785(parameters);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 46457, 46825);
                                                }

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 46865, 47270) || true) && (f_12_46869_46960(id, ref index, compilation, f_12_46916_46947(propertySymbol), parameters) && (DynAbs.Tracing.TraceSender.Expression_True(12, 46869, 47062) && f_12_47005_47062(f_12_47024_47049(propertySymbol), parameters)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 46865, 47270);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 47144, 47172);

                                                    f_12_47144_47171(results, propertySymbol);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 47214, 47231);

                                                    endIndex = index;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 46865, 47270);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 46349, 47577);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 46349, 47577);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 47344, 47577) || true) && (propertySymbol.Parameters.Length == 0)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 47344, 47577);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 47459, 47487);

                                                    f_12_47459_47486(results, propertySymbol);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 47525, 47542);

                                                    endIndex = index;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 47344, 47577);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 46349, 47577);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 46257, 47608);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 46041, 47635);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 1, 1595);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(12, 1, 1595);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 1, 1887);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(12, 1, 1887);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 47682, 47699);

                        index = endIndex;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(12, 47736, 47943);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 47784, 47924) || true) && (parameters != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 47784, 47924);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 47856, 47901);

                            f_12_47856_47900(s_parameterListPool, parameters);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 47784, 47924);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitFinally(12, 47736, 47943);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 45381, 47958);

                    int
                    f_12_45792_45808(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 45792, 45808);
                        return return_v;
                    }


                    string
                    f_12_45914_45934(Microsoft.CodeAnalysis.Compilation
                    this_param)
                    {
                        var return_v = this_param.Language;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 45914, 45934);
                        return return_v;
                    }


                    string
                    f_12_45883_45935(string
                    name, string
                    language)
                    {
                        var return_v = DecodePropertyName(name, language);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 45883, 45935);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                    f_12_45976_45989(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 45976, 45989);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_12_45976_46012(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetMembers(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 45976, 46012);
                        return return_v;
                    }


                    char
                    f_12_46353_46376(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 46353, 46376);
                        return return_v;
                    }


                    System.Collections.Generic.List<Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo>
                    f_12_46574_46604(Microsoft.CodeAnalysis.DocumentationCommentId.ListPool<Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo>
                    this_param)
                    {
                        var return_v = this_param.Allocate();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 46574, 46604);
                        return return_v;
                    }


                    int
                    f_12_46767_46785(System.Collections.Generic.List<Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo>
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 46767, 46785);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.ISymbol
                    f_12_46916_46947(Microsoft.CodeAnalysis.IPropertySymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 46916, 46947);
                        return return_v;
                    }


                    bool
                    f_12_46869_46960(string
                    id, ref int
                    index, Microsoft.CodeAnalysis.Compilation
                    compilation, Microsoft.CodeAnalysis.ISymbol
                    typeParameterContext, System.Collections.Generic.List<Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo>
                    parameters)
                    {
                        var return_v = ParseParameterList(id, ref index, compilation, typeParameterContext, parameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 46869, 46960);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
                    f_12_47024_47049(Microsoft.CodeAnalysis.IPropertySymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 47024, 47049);
                        return return_v;
                    }


                    bool
                    f_12_47005_47062(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
                    symbolParameters, System.Collections.Generic.List<Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo>
                    expectedParameters)
                    {
                        var return_v = AllParametersMatch(symbolParameters, expectedParameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 47005, 47062);
                        return return_v;
                    }


                    int
                    f_12_47144_47171(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    this_param, Microsoft.CodeAnalysis.IPropertySymbol
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.ISymbol)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 47144, 47171);
                        return 0;
                    }


                    int
                    f_12_47459_47486(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    this_param, Microsoft.CodeAnalysis.IPropertySymbol
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.ISymbol)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 47459, 47486);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_12_46064_46071_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 46064, 46071);
                        return return_v;
                    }


                    int
                    f_12_47856_47900(Microsoft.CodeAnalysis.DocumentationCommentId.ListPool<Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo>
                    this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo>
                    list)
                    {
                        this_param.ClearAndFree(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 47856, 47900);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 45381, 47958);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 45381, 47958);
                }
            }

            private static void GetMatchingFields(List<INamespaceOrTypeSymbol> containers, string memberName, List<ISymbol> results)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 47974, 48569);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 48136, 48141);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 48143, 48163);
                        for (int
        i = 0
        ,
        n = f_12_48147_48163(containers)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 48127, 48554) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 48172, 48175)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(12, 48127, 48554))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 48127, 48554);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 48217, 48268);

                            var
                            members = f_12_48231_48267(f_12_48231_48244(containers, i), memberName)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 48292, 48535);
                                foreach (var symbol in f_12_48315_48322_I(members))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 48292, 48535);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 48372, 48512) || true) && (f_12_48376_48387(symbol) == SymbolKind.Field)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 48372, 48512);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 48465, 48485);

                                        f_12_48465_48484(results, symbol);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 48372, 48512);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 48292, 48535);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 1, 244);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(12, 1, 244);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 1, 428);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(12, 1, 428);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 47974, 48569);

                    int
                    f_12_48147_48163(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 48147, 48163);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                    f_12_48231_48244(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 48231, 48244);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_12_48231_48267(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetMembers(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 48231, 48267);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_12_48376_48387(Microsoft.CodeAnalysis.ISymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 48376, 48387);
                        return return_v;
                    }


                    int
                    f_12_48465_48484(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 48465, 48484);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_12_48315_48322_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 48315, 48322);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 47974, 48569);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 47974, 48569);
                }
            }

            private static void GetMatchingEvents(List<INamespaceOrTypeSymbol> containers, string memberName, List<ISymbol> results)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 48585, 49180);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 48747, 48752);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 48754, 48774);
                        for (int
        i = 0
        ,
        n = f_12_48758_48774(containers)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 48738, 49165) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 48783, 48786)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(12, 48738, 49165))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 48738, 49165);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 48828, 48879);

                            var
                            members = f_12_48842_48878(f_12_48842_48855(containers, i), memberName)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 48903, 49146);
                                foreach (var symbol in f_12_48926_48933_I(members))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 48903, 49146);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 48983, 49123) || true) && (f_12_48987_48998(symbol) == SymbolKind.Event)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 48983, 49123);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 49076, 49096);

                                        f_12_49076_49095(results, symbol);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 48983, 49123);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(12, 48903, 49146);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 1, 244);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(12, 1, 244);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 1, 428);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(12, 1, 428);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 48585, 49180);

                    int
                    f_12_48758_48774(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 48758, 48774);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                    f_12_48842_48855(System.Collections.Generic.List<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 48842, 48855);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_12_48842_48878(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetMembers(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 48842, 48878);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_12_48987_48998(Microsoft.CodeAnalysis.ISymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 48987, 48998);
                        return return_v;
                    }


                    int
                    f_12_49076_49095(System.Collections.Generic.List<Microsoft.CodeAnalysis.ISymbol>
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 49076, 49095);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_12_48926_48933_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 48926, 48933);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 48585, 49180);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 48585, 49180);
                }
            }

            private static bool AllParametersMatch(ImmutableArray<IParameterSymbol> symbolParameters, List<ParameterInfo> expectedParameters)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 49196, 49815);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 49358, 49487) || true) && (symbolParameters.Length != f_12_49389_49413(expectedParameters))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 49358, 49487);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 49455, 49468);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 49358, 49487);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 49516, 49521);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 49507, 49768) || true) && (i < f_12_49527_49551(expectedParameters))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 49553, 49556)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(12, 49507, 49768))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 49507, 49768);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 49598, 49749) || true) && (!f_12_49603_49663(symbolParameters[i], f_12_49641_49662(expectedParameters, i)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 49598, 49749);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 49713, 49726);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 49598, 49749);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 1, 262);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(12, 1, 262);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 49788, 49800);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 49196, 49815);

                    int
                    f_12_49389_49413(System.Collections.Generic.List<Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 49389, 49413);
                        return return_v;
                    }


                    int
                    f_12_49527_49551(System.Collections.Generic.List<Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 49527, 49551);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo
                    f_12_49641_49662(System.Collections.Generic.List<Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 49641, 49662);
                        return return_v;
                    }


                    bool
                    f_12_49603_49663(Microsoft.CodeAnalysis.IParameterSymbol
                    symbol, Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo
                    parameterInfo)
                    {
                        var return_v = ParameterMatches(symbol, parameterInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 49603, 49663);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 49196, 49815);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 49196, 49815);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static bool ParameterMatches(IParameterSymbol symbol, ParameterInfo parameterInfo)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 49831, 50324);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 49989, 50127) || true) && ((f_12_49994_50008(symbol) == RefKind.None) == parameterInfo.IsRefOrOut)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 49989, 50127);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 50095, 50108);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 49989, 50127);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 50147, 50186);

                    var
                    parameterType = parameterInfo.Type
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 50206, 50309);

                    return parameterType != null && (DynAbs.Tracing.TraceSender.Expression_True(12, 50213, 50308) && f_12_50238_50308(f_12_50238_50249(symbol), parameterType, SymbolEqualityComparer.CLRSignature));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 49831, 50324);

                    Microsoft.CodeAnalysis.RefKind
                    f_12_49994_50008(Microsoft.CodeAnalysis.IParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 49994, 50008);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ITypeSymbol
                    f_12_50238_50249(Microsoft.CodeAnalysis.IParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 50238, 50249);
                        return return_v;
                    }


                    bool
                    f_12_50238_50308(Microsoft.CodeAnalysis.ITypeSymbol
                    this_param, Microsoft.CodeAnalysis.ITypeSymbol
                    other, Microsoft.CodeAnalysis.SymbolEqualityComparer
                    equalityComparer)
                    {
                        var return_v = this_param.Equals((Microsoft.CodeAnalysis.ISymbol)other, equalityComparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 50238, 50308);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 49831, 50324);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 49831, 50324);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static ITypeParameterSymbol GetNthTypeParameter(INamedTypeSymbol typeSymbol, int n)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 50340, 50858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 50464, 50548);

                    var
                    containingTypeParameterCount = f_12_50499_50547(f_12_50521_50546(typeSymbol))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 50566, 50720) || true) && (n < containingTypeParameterCount)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 50566, 50720);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 50644, 50701);

                        return f_12_50651_50700(f_12_50671_50696(typeSymbol), n);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 50566, 50720);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 50740, 50785);

                    var
                    index = n - containingTypeParameterCount
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 50803, 50843);

                    return f_12_50810_50835(typeSymbol)[index];
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 50340, 50858);

                    Microsoft.CodeAnalysis.INamedTypeSymbol
                    f_12_50521_50546(Microsoft.CodeAnalysis.INamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 50521, 50546);
                        return return_v;
                    }


                    int
                    f_12_50499_50547(Microsoft.CodeAnalysis.INamedTypeSymbol
                    typeSymbol)
                    {
                        var return_v = GetTypeParameterCount(typeSymbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 50499, 50547);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamedTypeSymbol
                    f_12_50671_50696(Microsoft.CodeAnalysis.INamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 50671, 50696);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ITypeParameterSymbol
                    f_12_50651_50700(Microsoft.CodeAnalysis.INamedTypeSymbol
                    typeSymbol, int
                    n)
                    {
                        var return_v = GetNthTypeParameter(typeSymbol, n);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 50651, 50700);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeParameterSymbol>
                    f_12_50810_50835(Microsoft.CodeAnalysis.INamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 50810, 50835);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 50340, 50858);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 50340, 50858);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static int GetTypeParameterCount(INamedTypeSymbol typeSymbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 50874, 51194);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 50976, 51068) || true) && (typeSymbol == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 50976, 51068);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 51040, 51049);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 50976, 51068);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 51088, 51179);

                    return typeSymbol.TypeParameters.Length + f_12_51130_51178(f_12_51152_51177(typeSymbol));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 50874, 51194);

                    Microsoft.CodeAnalysis.INamedTypeSymbol
                    f_12_51152_51177(Microsoft.CodeAnalysis.INamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 51152, 51177);
                        return return_v;
                    }


                    int
                    f_12_51130_51178(Microsoft.CodeAnalysis.INamedTypeSymbol
                    typeSymbol)
                    {
                        var return_v = GetTypeParameterCount(typeSymbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 51130, 51178);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 50874, 51194);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 50874, 51194);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            [StructLayout(LayoutKind.Auto)]
            private struct ParameterInfo
            {

                internal readonly ITypeSymbol Type;

                internal readonly bool IsRefOrOut;

                public ParameterInfo(ITypeSymbol type, bool isRefOrOut)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(12, 51423, 51606);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 51519, 51536);

                        this.Type = type;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 51558, 51587);

                        this.IsRefOrOut = isRefOrOut;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(12, 51423, 51606);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 51423, 51606);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 51423, 51606);
                    }
                }
                static ParameterInfo()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(12, 51210, 51621);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(12, 51210, 51621);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 51210, 51621);
                }
            }

            private static readonly ListPool<ParameterInfo> s_parameterListPool;

            private static bool ParseParameterList(string id, ref int index, Compilation compilation, ISymbol typeParameterContext, List<ParameterInfo> parameters)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 51753, 53049);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 51937, 51999);

                    f_12_51937_51998(typeParameterContext != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 52019, 52027);

                    index++;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 52064, 52201) || true) && (f_12_52068_52091(id, index) == ')')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 52064, 52201);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 52140, 52148);

                        index++;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 52170, 52182);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 52064, 52201);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 52221, 52302);

                    var
                    parameter = f_12_52237_52301(id, ref index, compilation, typeParameterContext)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 52320, 52415) || true) && (parameter == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 52320, 52415);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 52383, 52396);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 52320, 52415);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 52435, 52467);

                    f_12_52435_52466(
                                    parameters, parameter.Value);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 52487, 52879) || true) && (f_12_52494_52517(id, index) == ',')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 52487, 52879);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 52566, 52574);

                            index++;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 52598, 52675);

                            parameter = f_12_52610_52674(id, ref index, compilation, typeParameterContext);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 52697, 52804) || true) && (parameter == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 52697, 52804);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 52768, 52781);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(12, 52697, 52804);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 52828, 52860);

                            f_12_52828_52859(
                                                parameters, parameter.Value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 52487, 52879);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 52487, 52879);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(12, 52487, 52879);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 52899, 53002) || true) && (f_12_52903_52926(id, index) == ')')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 52899, 53002);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 52975, 52983);

                        index++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 52899, 53002);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 53022, 53034);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 51753, 53049);

                    int
                    f_12_51937_51998(bool
                    condition)
                    {
                        System.Diagnostics.Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 51937, 51998);
                        return 0;
                    }


                    char
                    f_12_52068_52091(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 52068, 52091);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo?
                    f_12_52237_52301(string
                    id, ref int
                    index, Microsoft.CodeAnalysis.Compilation
                    compilation, Microsoft.CodeAnalysis.ISymbol
                    typeParameterContext)
                    {
                        var return_v = ParseParameter(id, ref index, compilation, typeParameterContext);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 52237, 52301);
                        return return_v;
                    }


                    int
                    f_12_52435_52466(System.Collections.Generic.List<Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo>
                    this_param, Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 52435, 52466);
                        return 0;
                    }


                    char
                    f_12_52494_52517(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 52494, 52517);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo?
                    f_12_52610_52674(string
                    id, ref int
                    index, Microsoft.CodeAnalysis.Compilation
                    compilation, Microsoft.CodeAnalysis.ISymbol
                    typeParameterContext)
                    {
                        var return_v = ParseParameter(id, ref index, compilation, typeParameterContext);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 52610, 52674);
                        return return_v;
                    }


                    int
                    f_12_52828_52859(System.Collections.Generic.List<Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo>
                    this_param, Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 52828, 52859);
                        return 0;
                    }


                    char
                    f_12_52903_52926(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 52903, 52926);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 51753, 53049);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 51753, 53049);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static ParameterInfo? ParseParameter(string id, ref int index, Compilation compilation, ISymbol? typeParameterContext)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 53065, 53776);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 53224, 53248);

                    bool
                    isRefOrOut = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 53268, 53345);

                    var
                    type = f_12_53279_53344(id, ref index, compilation, typeParameterContext)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 53365, 53535) || true) && (type == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 53365, 53535);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 53504, 53516);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 53365, 53535);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 53555, 53698) || true) && (f_12_53559_53582(id, index) == '@')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 53555, 53698);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 53631, 53639);

                        index++;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 53661, 53679);

                        isRefOrOut = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 53555, 53698);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 53718, 53761);

                    return f_12_53725_53760(type, isRefOrOut);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 53065, 53776);

                    Microsoft.CodeAnalysis.ITypeSymbol?
                    f_12_53279_53344(string
                    id, ref int
                    index, Microsoft.CodeAnalysis.Compilation
                    compilation, Microsoft.CodeAnalysis.ISymbol?
                    typeParameterContext)
                    {
                        var return_v = ParseTypeSymbol(id, ref index, compilation, typeParameterContext);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 53279, 53344);
                        return return_v;
                    }


                    char
                    f_12_53559_53582(string
                    id, int
                    index)
                    {
                        var return_v = PeekNextChar(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 53559, 53582);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo
                    f_12_53725_53760(Microsoft.CodeAnalysis.ITypeSymbol
                    type, bool
                    isRefOrOut)
                    {
                        var return_v = new Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo(type, isRefOrOut);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 53725, 53760);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 53065, 53776);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 53065, 53776);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static char PeekNextChar(string id, int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 53792, 53939);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 53879, 53924);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(12, 53886, 53904) || ((index >= f_12_53895_53904(id) && DynAbs.Tracing.TraceSender.Conditional_F2(12, 53907, 53911)) || DynAbs.Tracing.TraceSender.Conditional_F3(12, 53914, 53923))) ? '\0' : f_12_53914_53923(id, index);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 53792, 53939);

                    int
                    f_12_53895_53904(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 53895, 53904);
                        return return_v;
                    }


                    char
                    f_12_53914_53923(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 53914, 53923);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 53792, 53939);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 53792, 53939);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static readonly char[] s_nameDelimiters;

            private static string ParseName(string id, ref int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 54095, 54687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 54185, 54197);

                    string
                    name
                    = default(string);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 54217, 54278);

                    int
                    delimiterOffset = f_12_54239_54277(id, s_nameDelimiters, index)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 54296, 54628) || true) && (delimiterOffset >= 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 54296, 54628);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 54362, 54414);

                        name = f_12_54369_54413(id, index, delimiterOffset - index);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 54436, 54460);

                        index = delimiterOffset;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 54296, 54628);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 54296, 54628);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 54542, 54569);

                        name = f_12_54549_54568(id, index);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 54591, 54609);

                        index = f_12_54599_54608(id);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 54296, 54628);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 54648, 54672);

                    return f_12_54655_54671(name);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 54095, 54687);

                    int
                    f_12_54239_54277(string
                    this_param, char[]
                    anyOf, int
                    startIndex)
                    {
                        var return_v = this_param.IndexOfAny(anyOf, startIndex);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 54239, 54277);
                        return return_v;
                    }


                    string
                    f_12_54369_54413(string
                    this_param, int
                    startIndex, int
                    length)
                    {
                        var return_v = this_param.Substring(startIndex, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 54369, 54413);
                        return return_v;
                    }


                    string
                    f_12_54549_54568(string
                    this_param, int
                    startIndex)
                    {
                        var return_v = this_param.Substring(startIndex);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 54549, 54568);
                        return return_v;
                    }


                    int
                    f_12_54599_54608(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 54599, 54608);
                        return return_v;
                    }


                    string
                    f_12_54655_54671(string
                    name)
                    {
                        var return_v = DecodeName(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 54655, 54671);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 54095, 54687);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 54095, 54687);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static string DecodeName(string name)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 54756, 54998);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 54834, 54951) || true) && (f_12_54838_54855(name, '#') >= 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 54834, 54951);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 54902, 54932);

                        return f_12_54909_54931(name, '#', '.');
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 54834, 54951);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 54971, 54983);

                    return name;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 54756, 54998);

                    int
                    f_12_54838_54855(string
                    this_param, char
                    value)
                    {
                        var return_v = this_param.IndexOf(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 54838, 54855);
                        return return_v;
                    }


                    string
                    f_12_54909_54931(string
                    this_param, char
                    oldChar, char
                    newChar)
                    {
                        var return_v = this_param.Replace(oldChar, newChar);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 54909, 54931);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 54756, 54998);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 54756, 54998);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static int ReadNextInteger(string id, ref int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 55014, 55354);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 55107, 55117);

                    int
                    n = 0
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 55137, 55310) || true) && (index < f_12_55152_55161(id) && (DynAbs.Tracing.TraceSender.Expression_True(12, 55144, 55188) && f_12_55165_55188(f_12_55178_55187(id, index))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 55137, 55310);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 55230, 55261);

                            n = n * 10 + (f_12_55244_55253(id, index) - '0');
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 55283, 55291);

                            index++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(12, 55137, 55310);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 55137, 55310);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(12, 55137, 55310);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 55330, 55339);

                    return n;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 55014, 55354);

                    int
                    f_12_55152_55161(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 55152, 55161);
                        return return_v;
                    }


                    char
                    f_12_55178_55187(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 55178, 55187);
                        return return_v;
                    }


                    bool
                    f_12_55165_55188(char
                    c)
                    {
                        var return_v = char.IsDigit(c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 55165, 55188);
                        return return_v;
                    }


                    char
                    f_12_55244_55253(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 55244, 55253);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 55014, 55354);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 55014, 55354);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static void CopyTo<TSource, TDestination>(List<TSource> source, List<TDestination> destination)
                            where TSource : class
                            where TDestination : class
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(12, 55370, 55954);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 55589, 55765) || true) && (f_12_55593_55610(destination) + f_12_55613_55625(source) > f_12_55628_55648(destination))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 55589, 55765);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 55690, 55746);

                        destination.Capacity = f_12_55713_55730(destination) + f_12_55733_55745(source);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(12, 55589, 55765);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 55794, 55799);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 55801, 55817);

                        for (int
        i = 0
        ,
        n = f_12_55805_55817(source)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 55785, 55939) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 55826, 55829)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(12, 55785, 55939))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(12, 55785, 55939);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 55871, 55920);

                            f_12_55871_55919(destination, (object)f_12_55909_55918(source, i));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(12, 1, 155);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(12, 1, 155);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(12, 55370, 55954);

                    int
                    f_12_55593_55610(System.Collections.Generic.List<TDestination>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 55593, 55610);
                        return return_v;
                    }


                    int
                    f_12_55613_55625(System.Collections.Generic.List<TSource>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 55613, 55625);
                        return return_v;
                    }


                    int
                    f_12_55628_55648(System.Collections.Generic.List<TDestination>
                    this_param)
                    {
                        var return_v = this_param.Capacity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 55628, 55648);
                        return return_v;
                    }


                    int
                    f_12_55713_55730(System.Collections.Generic.List<TDestination>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 55713, 55730);
                        return return_v;
                    }


                    int
                    f_12_55733_55745(System.Collections.Generic.List<TSource>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 55733, 55745);
                        return return_v;
                    }


                    int
                    f_12_55805_55817(System.Collections.Generic.List<TSource>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 55805, 55817);
                        return return_v;
                    }


                    TSource
                    f_12_55909_55918(System.Collections.Generic.List<TSource>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(12, 55909, 55918);
                        return return_v;
                    }


                    int
                    f_12_55871_55919(System.Collections.Generic.List<TDestination>
                    this_param, object
                    item)
                    {
                        this_param.Add((TDestination)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 55871, 55919);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(12, 55370, 55954);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 55370, 55954);
                }
            }

            static Parser()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(12, 21844, 55965);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 51685, 51736);
                s_parameterListPool = f_12_51707_51736(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 53986, 54078);
                s_nameDelimiters = new char[] { ':', '.', '(', ')', '{', '}', '[', ']', ',', '\'', '@', '*', '`', '~' }; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(12, 21844, 55965);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 21844, 55965);
            }


            static Microsoft.CodeAnalysis.DocumentationCommentId.ListPool<Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo>
            f_12_51707_51736()
            {
                var return_v = new Microsoft.CodeAnalysis.DocumentationCommentId.ListPool<Microsoft.CodeAnalysis.DocumentationCommentId.Parser.ParameterInfo>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 51707, 51736);
                return return_v;
            }

        }

        static DocumentationCommentId()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(12, 621, 55972);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 1266, 1308);
            s_symbolListPool = f_12_1285_1308(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(12, 1376, 1442);
            s_namespaceOrTypeListPool = f_12_1404_1442(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(12, 621, 55972);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(12, 621, 55972);
        }


        static Microsoft.CodeAnalysis.DocumentationCommentId.ListPool<Microsoft.CodeAnalysis.ISymbol>
        f_12_1285_1308()
        {
            var return_v = new Microsoft.CodeAnalysis.DocumentationCommentId.ListPool<Microsoft.CodeAnalysis.ISymbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 1285, 1308);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DocumentationCommentId.ListPool<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
        f_12_1404_1442()
        {
            var return_v = new Microsoft.CodeAnalysis.DocumentationCommentId.ListPool<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(12, 1404, 1442);
            return return_v;
        }

    }
}
