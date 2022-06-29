// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal sealed class CachingSemanticModelProvider : SemanticModelProvider
    {
        private static readonly ConditionalWeakTable<Compilation, PerCompilationProvider>.CreateValueCallback s_createProviderCallback
        ;

        private readonly ConditionalWeakTable<Compilation, PerCompilationProvider> _providerCache;

        public CachingSemanticModelProvider()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(242, 1980, 2134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(242, 1953, 1967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(242, 2042, 2123);

                _providerCache = f_242_2059_2122();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(242, 1980, 2134);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(242, 1980, 2134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(242, 1980, 2134);
            }
        }

        public override SemanticModel GetSemanticModel(SyntaxTree tree, Compilation compilation, bool ignoreAccessibility = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(242, 2282, 2391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(242, 2285, 2391);
                return f_242_2285_2391(f_242_2285_2347(_providerCache, compilation, s_createProviderCallback), tree, ignoreAccessibility); DynAbs.Tracing.TraceSender.TraceExitMethod(242, 2282, 2391);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(242, 2282, 2391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(242, 2282, 2391);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider.PerCompilationProvider
            f_242_2285_2347(System.Runtime.CompilerServices.ConditionalWeakTable<Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider.PerCompilationProvider>
            this_param, Microsoft.CodeAnalysis.Compilation
            key, System.Runtime.CompilerServices.ConditionalWeakTable<Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider.PerCompilationProvider>.CreateValueCallback
            createValueCallback)
            {
                var return_v = this_param.GetValue(key, createValueCallback);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(242, 2285, 2347);
                return return_v;
            }


            Microsoft.CodeAnalysis.SemanticModel
            f_242_2285_2391(Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider.PerCompilationProvider
            this_param, Microsoft.CodeAnalysis.SyntaxTree
            tree, bool
            ignoreAccessibility)
            {
                var return_v = this_param.GetSemanticModel(tree, ignoreAccessibility);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(242, 2285, 2391);
                return return_v;
            }

        }

        internal void ClearCache(SyntaxTree tree, Compilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(242, 2404, 2656);
                Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider.PerCompilationProvider provider = default(Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider.PerCompilationProvider);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(242, 2495, 2645) || true) && (f_242_2499_2556(_providerCache, compilation, out provider))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(242, 2495, 2645);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(242, 2590, 2630);

                    f_242_2590_2629(provider, tree);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(242, 2495, 2645);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(242, 2404, 2656);

                bool
                f_242_2499_2556(System.Runtime.CompilerServices.ConditionalWeakTable<Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider.PerCompilationProvider>
                this_param, Microsoft.CodeAnalysis.Compilation
                key, out Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider.PerCompilationProvider
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(242, 2499, 2556);
                    return return_v;
                }


                int
                f_242_2590_2629(Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider.PerCompilationProvider
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    this_param.ClearCachedSemanticModel(tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(242, 2590, 2629);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(242, 2404, 2656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(242, 2404, 2656);
            }
        }

        internal void ClearCache(Compilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(242, 2668, 2788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(242, 2742, 2777);

                f_242_2742_2776(_providerCache, compilation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(242, 2668, 2788);

                bool
                f_242_2742_2776(System.Runtime.CompilerServices.ConditionalWeakTable<Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider.PerCompilationProvider>
                this_param, Microsoft.CodeAnalysis.Compilation
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(242, 2742, 2776);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(242, 2668, 2788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(242, 2668, 2788);
            }
        }
        private sealed class PerCompilationProvider
        {
            private readonly Compilation _compilation;

            private readonly ConcurrentDictionary<SyntaxTree, SemanticModel> _semanticModelsMap;

            private readonly Func<SyntaxTree, SemanticModel> _createSemanticModel;

            public PerCompilationProvider(Compilation compilation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(242, 3343, 3680);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(242, 2897, 2909);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(242, 2989, 3007);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(242, 3306, 3326);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(242, 3430, 3457);

                    _compilation = compilation;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(242, 3475, 3550);

                    _semanticModelsMap = f_242_3496_3549();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(242, 3568, 3665);

                    _createSemanticModel = tree => compilation.CreateSemanticModel(tree, ignoreAccessibility: false);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(242, 3343, 3680);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(242, 3343, 3680);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(242, 3343, 3680);
                }
            }

            public SemanticModel GetSemanticModel(SyntaxTree tree, bool ignoreAccessibility)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(242, 3696, 4158);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(242, 3947, 4143);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(242, 3954, 3974) || ((!ignoreAccessibility
                    && DynAbs.Tracing.TraceSender.Conditional_F2(242, 3998, 4053)) || DynAbs.Tracing.TraceSender.Conditional_F3(242, 4077, 4142))) ? f_242_3998_4053(_semanticModelsMap, tree, _createSemanticModel) : f_242_4077_4142(_compilation, tree, ignoreAccessibility: true);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(242, 3696, 4158);

                    Microsoft.CodeAnalysis.SemanticModel
                    f_242_3998_4053(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.SemanticModel>
                    this_param, Microsoft.CodeAnalysis.SyntaxTree
                    key, System.Func<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.SemanticModel>
                    valueFactory)
                    {
                        var return_v = this_param.GetOrAdd(key, valueFactory);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(242, 3998, 4053);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SemanticModel
                    f_242_4077_4142(Microsoft.CodeAnalysis.Compilation
                    this_param, Microsoft.CodeAnalysis.SyntaxTree
                    syntaxTree, bool
                    ignoreAccessibility)
                    {
                        var return_v = this_param.CreateSemanticModel(syntaxTree, ignoreAccessibility: ignoreAccessibility);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(242, 4077, 4142);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(242, 3696, 4158);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(242, 3696, 4158);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void ClearCachedSemanticModel(SyntaxTree tree)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(242, 4174, 4317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(242, 4260, 4302);

                    f_242_4260_4301(_semanticModelsMap, tree, out _);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(242, 4174, 4317);

                    bool
                    f_242_4260_4301(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.SemanticModel>
                    this_param, Microsoft.CodeAnalysis.SyntaxTree
                    key, out Microsoft.CodeAnalysis.SemanticModel
                    value)
                    {
                        var return_v = this_param.TryRemove(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(242, 4260, 4301);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(242, 4174, 4317);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(242, 4174, 4317);
                }
            }

            static PerCompilationProvider()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(242, 2800, 4328);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(242, 2800, 4328);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(242, 2800, 4328);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(242, 2800, 4328);

            static System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.SemanticModel>
            f_242_3496_3549()
            {
                var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.SemanticModel>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(242, 3496, 3549);
                return return_v;
            }

        }

        static CachingSemanticModelProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(242, 1495, 4335);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(242, 1688, 1865);
            s_createProviderCallback = new ConditionalWeakTable<Compilation, PerCompilationProvider>.CreateValueCallback(compilation => new PerCompilationProvider(compilation)); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(242, 1495, 4335);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(242, 1495, 4335);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(242, 1495, 4335);

        static System.Runtime.CompilerServices.ConditionalWeakTable<Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider.PerCompilationProvider>
        f_242_2059_2122()
        {
            var return_v = new System.Runtime.CompilerServices.ConditionalWeakTable<Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider.PerCompilationProvider>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(242, 2059, 2122);
            return return_v;
        }

    }
}
