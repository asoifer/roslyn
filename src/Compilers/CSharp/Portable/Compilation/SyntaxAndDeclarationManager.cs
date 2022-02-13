// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class SyntaxAndDeclarationManager : CommonSyntaxAndDeclarationManager
    {
        private State _lazyState;

        internal SyntaxAndDeclarationManager(
                    ImmutableArray<SyntaxTree> externalSyntaxTrees,
                    string scriptClassName,
                    SourceReferenceResolver resolver,
                    CommonMessageProvider messageProvider,
                    bool isSubmission,
                    State state)
        : base(f_10043_986_1005_C(externalSyntaxTrees), scriptClassName, resolver, messageProvider, isSubmission)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10043, 673, 1119);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 650, 660);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 1089, 1108);

                _lazyState = state;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10043, 673, 1119);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10043, 673, 1119);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10043, 673, 1119);
            }
        }

        internal State GetLazyState()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10043, 1131, 1468);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 1185, 1423) || true) && (_lazyState == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 1185, 1423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 1241, 1408);

                    f_10043_1241_1407(ref _lazyState, f_10043_1285_1400(this.ExternalSyntaxTrees, this.ScriptClassName, this.Resolver, this.MessageProvider, this.IsSubmission), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 1185, 1423);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 1439, 1457);

                return _lazyState;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10043, 1131, 1468);

                Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager.State
                f_10043_1285_1400(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                externalSyntaxTrees, string
                scriptClassName, Microsoft.CodeAnalysis.SourceReferenceResolver
                resolver, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, bool
                isSubmission)
                {
                    var return_v = CreateState(externalSyntaxTrees, scriptClassName, resolver, messageProvider, isSubmission);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 1285, 1400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager.State?
                f_10043_1241_1407(ref Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager.State?
                location1, Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager.State
                value, Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager.State?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 1241, 1407);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10043, 1131, 1468);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10043, 1131, 1468);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static State CreateState(
                    ImmutableArray<SyntaxTree> externalSyntaxTrees,
                    string scriptClassName,
                    SourceReferenceResolver resolver,
                    CommonMessageProvider messageProvider,
                    bool isSubmission)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10043, 1480, 3240);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 1767, 1825);

                var
                treesBuilder = f_10043_1786_1824()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 1839, 1911);

                var
                ordinalMapBuilder = f_10043_1863_1910()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 1925, 2029);

                var
                loadDirectiveMapBuilder = f_10043_1955_2028()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 2043, 2127);

                var
                loadedSyntaxTreeMapBuilder = f_10043_2076_2126()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 2141, 2243);

                var
                declMapBuilder = f_10043_2162_2242()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 2257, 2296);

                var
                declTable = DeclarationTable.Empty
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 2312, 2835);
                    foreach (var tree in f_10043_2333_2352_I(externalSyntaxTrees))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 2312, 2835);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 2386, 2820);

                        f_10043_2386_2819(treesBuilder, tree, scriptClassName, resolver, messageProvider, isSubmission, ordinalMapBuilder, loadDirectiveMapBuilder, loadedSyntaxTreeMapBuilder, declMapBuilder, ref declTable);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 2312, 2835);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10043, 1, 524);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10043, 1, 524);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 2851, 3229);

                return f_10043_2858_3228(f_10043_2886_2919(treesBuilder), f_10043_2938_2986(ordinalMapBuilder), f_10043_3005_3059(loadDirectiveMapBuilder), f_10043_3078_3135(loadedSyntaxTreeMapBuilder), f_10043_3154_3199(declMapBuilder), declTable);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10043, 1480, 3240);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                f_10043_1786_1824()
                {
                    var return_v = ArrayBuilder<SyntaxTree>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 1786, 1824);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                f_10043_1863_1910()
                {
                    var return_v = PooledDictionary<SyntaxTree, int>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 1863, 1910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                f_10043_1955_2028()
                {
                    var return_v = PooledDictionary<SyntaxTree, ImmutableArray<LoadDirective>>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 1955, 2028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                f_10043_2076_2126()
                {
                    var return_v = PooledDictionary<string, SyntaxTree>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 2076, 2126);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>
                f_10043_2162_2242()
                {
                    var return_v = PooledDictionary<SyntaxTree, Lazy<RootSingleNamespaceDeclaration>>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 2162, 2242);
                    return return_v;
                }


                int
                f_10043_2386_2819(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                treesBuilder, Microsoft.CodeAnalysis.SyntaxTree
                tree, string
                scriptClassName, Microsoft.CodeAnalysis.SourceReferenceResolver
                resolver, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, bool
                isSubmission, Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                ordinalMapBuilder, Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                loadDirectiveMapBuilder, Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                loadedSyntaxTreeMapBuilder, Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>
                declMapBuilder, ref Microsoft.CodeAnalysis.CSharp.DeclarationTable
                declTable)
                {
                    AppendAllSyntaxTrees(treesBuilder, tree, scriptClassName, resolver, messageProvider, isSubmission, (System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>)ordinalMapBuilder, (System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>)loadDirectiveMapBuilder, (System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>)loadedSyntaxTreeMapBuilder, (System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>)declMapBuilder, ref declTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 2386, 2819);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_10043_2333_2352_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 2333, 2352);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_10043_2886_2919(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 2886, 2919);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                f_10043_2938_2986(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                this_param)
                {
                    var return_v = this_param.ToImmutableDictionaryAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 2938, 2986);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                f_10043_3005_3059(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                this_param)
                {
                    var return_v = this_param.ToImmutableDictionaryAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 3005, 3059);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                f_10043_3078_3135(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                this_param)
                {
                    var return_v = this_param.ToImmutableDictionaryAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 3078, 3135);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>
                f_10043_3154_3199(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>
                this_param)
                {
                    var return_v = this_param.ToImmutableDictionaryAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 3154, 3199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager.State
                f_10043_2858_3228(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                syntaxTrees, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                syntaxTreeOrdinalMap, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                loadDirectiveMap, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                loadedSyntaxTreeMap, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>
                rootNamespaces, Microsoft.CodeAnalysis.CSharp.DeclarationTable
                declarationTable)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager.State(syntaxTrees, syntaxTreeOrdinalMap, loadDirectiveMap, loadedSyntaxTreeMap, rootNamespaces, declarationTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 2858, 3228);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10043, 1480, 3240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10043, 1480, 3240);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxAndDeclarationManager AddSyntaxTrees(IEnumerable<SyntaxTree> trees)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10043, 3252, 5491);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 3357, 3400);

                var
                scriptClassName = this.ScriptClassName
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 3414, 3443);

                var
                resolver = this.Resolver
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 3457, 3500);

                var
                messageProvider = this.MessageProvider
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 3514, 3551);

                var
                isSubmission = this.IsSubmission
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 3567, 3590);

                var
                state = _lazyState
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 3604, 3674);

                var
                newExternalSyntaxTrees = this.ExternalSyntaxTrees.AddRange(trees)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 3688, 3814) || true) && (state == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 3688, 3814);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 3739, 3799);

                    return f_10043_3746_3798(this, newExternalSyntaxTrees);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 3688, 3814);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 3830, 3883);

                var
                ordinalMapBuilder = f_10043_3854_3882(state.OrdinalMap)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 3897, 3962);

                var
                loadDirectiveMapBuilder = f_10043_3927_3961(state.LoadDirectiveMap)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 3976, 4047);

                var
                loadedSyntaxTreeMapBuilder = f_10043_4009_4046(state.LoadedSyntaxTreeMap)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 4061, 4115);

                var
                declMapBuilder = f_10043_4082_4114(state.RootNamespaces)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 4129, 4168);

                var
                declTable = state.DeclarationTable
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 4184, 4242);

                var
                treesBuilder = f_10043_4203_4241()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 4256, 4297);

                f_10043_4256_4296(treesBuilder, state.SyntaxTrees);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 4313, 4866);
                    foreach (var tree in f_10043_4334_4339_I(trees))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 4313, 4866);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 4373, 4851);

                        f_10043_4373_4850(treesBuilder, tree, scriptClassName, resolver, messageProvider, isSubmission, ordinalMapBuilder, loadDirectiveMapBuilder, loadedSyntaxTreeMapBuilder, declMapBuilder, ref declTable);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 4313, 4866);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10043, 1, 554);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10043, 1, 554);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 4882, 5233);

                state = f_10043_4890_5232(f_10043_4918_4951(treesBuilder), f_10043_4970_5011(ordinalMapBuilder), f_10043_5030_5077(loadDirectiveMapBuilder), f_10043_5096_5146(loadedSyntaxTreeMapBuilder), f_10043_5165_5203(declMapBuilder), declTable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 5249, 5480);

                return f_10043_5256_5479(newExternalSyntaxTrees, scriptClassName, resolver, messageProvider, isSubmission, state);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10043, 3252, 5491);

                Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager
                f_10043_3746_3798(Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                trees)
                {
                    var return_v = this_param.WithExternalSyntaxTrees(trees);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 3746, 3798);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>.Builder
                f_10043_3854_3882(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                this_param)
                {
                    var return_v = this_param.ToBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 3854, 3882);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>.Builder
                f_10043_3927_3961(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                this_param)
                {
                    var return_v = this_param.ToBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 3927, 3961);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>.Builder
                f_10043_4009_4046(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                this_param)
                {
                    var return_v = this_param.ToBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 4009, 4046);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>.Builder
                f_10043_4082_4114(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>
                this_param)
                {
                    var return_v = this_param.ToBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 4082, 4114);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                f_10043_4203_4241()
                {
                    var return_v = ArrayBuilder<SyntaxTree>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 4203, 4241);
                    return return_v;
                }


                int
                f_10043_4256_4296(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 4256, 4296);
                    return 0;
                }


                int
                f_10043_4373_4850(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                treesBuilder, Microsoft.CodeAnalysis.SyntaxTree
                tree, string
                scriptClassName, Microsoft.CodeAnalysis.SourceReferenceResolver
                resolver, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, bool
                isSubmission, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>.Builder
                ordinalMapBuilder, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>.Builder
                loadDirectiveMapBuilder, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>.Builder
                loadedSyntaxTreeMapBuilder, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>.Builder
                declMapBuilder, ref Microsoft.CodeAnalysis.CSharp.DeclarationTable
                declTable)
                {
                    AppendAllSyntaxTrees(treesBuilder, tree, scriptClassName, resolver, messageProvider, isSubmission, (System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>)ordinalMapBuilder, (System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>)loadDirectiveMapBuilder, (System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>)loadedSyntaxTreeMapBuilder, (System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>)declMapBuilder, ref declTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 4373, 4850);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_10043_4334_4339_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 4334, 4339);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_10043_4918_4951(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 4918, 4951);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                f_10043_4970_5011(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>.Builder
                builder)
                {
                    var return_v = builder.ToImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 4970, 5011);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                f_10043_5030_5077(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>.Builder
                builder)
                {
                    var return_v = builder.ToImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 5030, 5077);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                f_10043_5096_5146(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>.Builder
                builder)
                {
                    var return_v = builder.ToImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 5096, 5146);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>
                f_10043_5165_5203(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>.Builder
                builder)
                {
                    var return_v = builder.ToImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 5165, 5203);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager.State
                f_10043_4890_5232(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                syntaxTrees, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                syntaxTreeOrdinalMap, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                loadDirectiveMap, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                loadedSyntaxTreeMap, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>
                rootNamespaces, Microsoft.CodeAnalysis.CSharp.DeclarationTable
                declarationTable)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager.State(syntaxTrees, syntaxTreeOrdinalMap, loadDirectiveMap, loadedSyntaxTreeMap, rootNamespaces, declarationTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 4890, 5232);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager
                f_10043_5256_5479(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                externalSyntaxTrees, string
                scriptClassName, Microsoft.CodeAnalysis.SourceReferenceResolver
                resolver, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, bool
                isSubmission, Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager.State
                state)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager(externalSyntaxTrees, scriptClassName, resolver, messageProvider, isSubmission, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 5256, 5479);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10043, 3252, 5491);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10043, 3252, 5491);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void AppendAllSyntaxTrees(
                    ArrayBuilder<SyntaxTree> treesBuilder,
                    SyntaxTree tree,
                    string scriptClassName,
                    SourceReferenceResolver resolver,
                    CommonMessageProvider messageProvider,
                    bool isSubmission,
                    IDictionary<SyntaxTree, int> ordinalMapBuilder,
                    IDictionary<SyntaxTree, ImmutableArray<LoadDirective>> loadDirectiveMapBuilder,
                    IDictionary<string, SyntaxTree> loadedSyntaxTreeMapBuilder,
                    IDictionary<SyntaxTree, Lazy<RootSingleNamespaceDeclaration>> declMapBuilder,
                    ref DeclarationTable declTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10043, 5624, 6897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 6303, 6342);

                var
                sourceCodeKind = f_10043_6324_6341(f_10043_6324_6336(tree))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 6356, 6656) || true) && (sourceCodeKind == SourceCodeKind.Script)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 6356, 6656);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 6433, 6641);

                    f_10043_6433_6640(treesBuilder, tree, scriptClassName, resolver, messageProvider, isSubmission, ordinalMapBuilder, loadDirectiveMapBuilder, loadedSyntaxTreeMapBuilder, declMapBuilder, ref declTable);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 6356, 6656);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 6672, 6778);

                f_10043_6672_6777(tree, scriptClassName, isSubmission, declMapBuilder, ref declTable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 6794, 6817);

                f_10043_6794_6816(
                            treesBuilder, tree);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 6833, 6886);

                f_10043_6833_6885(
                            ordinalMapBuilder, tree, f_10043_6861_6884(ordinalMapBuilder));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10043, 5624, 6897);

                Microsoft.CodeAnalysis.ParseOptions
                f_10043_6324_6336(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 6324, 6336);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceCodeKind
                f_10043_6324_6341(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 6324, 6341);
                    return return_v;
                }


                int
                f_10043_6433_6640(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                treesBuilder, Microsoft.CodeAnalysis.SyntaxTree
                tree, string
                scriptClassName, Microsoft.CodeAnalysis.SourceReferenceResolver
                resolver, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, bool
                isSubmission, System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                ordinalMapBuilder, System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                loadDirectiveMapBuilder, System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                loadedSyntaxTreeMapBuilder, System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>
                declMapBuilder, ref Microsoft.CodeAnalysis.CSharp.DeclarationTable
                declTable)
                {
                    AppendAllLoadedSyntaxTrees(treesBuilder, tree, scriptClassName, resolver, messageProvider, isSubmission, ordinalMapBuilder, loadDirectiveMapBuilder, loadedSyntaxTreeMapBuilder, declMapBuilder, ref declTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 6433, 6640);
                    return 0;
                }


                int
                f_10043_6672_6777(Microsoft.CodeAnalysis.SyntaxTree
                tree, string
                scriptClassName, bool
                isSubmission, System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>
                declMapBuilder, ref Microsoft.CodeAnalysis.CSharp.DeclarationTable
                declTable)
                {
                    AddSyntaxTreeToDeclarationMapAndTable(tree, scriptClassName, isSubmission, declMapBuilder, ref declTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 6672, 6777);
                    return 0;
                }


                int
                f_10043_6794_6816(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 6794, 6816);
                    return 0;
                }


                int
                f_10043_6861_6884(System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 6861, 6884);
                    return return_v;
                }


                int
                f_10043_6833_6885(System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, int
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 6833, 6885);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10043, 5624, 6897);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10043, 5624, 6897);
            }
        }

        private static void AppendAllLoadedSyntaxTrees(
                    ArrayBuilder<SyntaxTree> treesBuilder,
                    SyntaxTree tree,
                    string scriptClassName,
                    SourceReferenceResolver resolver,
                    CommonMessageProvider messageProvider,
                    bool isSubmission,
                    IDictionary<SyntaxTree, int> ordinalMapBuilder,
                    IDictionary<SyntaxTree, ImmutableArray<LoadDirective>> loadDirectiveMapBuilder,
                    IDictionary<string, SyntaxTree> loadedSyntaxTreeMapBuilder,
                    IDictionary<SyntaxTree, Lazy<RootSingleNamespaceDeclaration>> declMapBuilder,
                    ref DeclarationTable declTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10043, 6909, 11649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 7594, 7644);

                ArrayBuilder<LoadDirective>
                loadDirectives = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 7660, 11476);
                    foreach (var directive in f_10043_7686_7735_I(f_10043_7686_7735(tree.GetCompilationUnitRoot())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 7660, 11476);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 7769, 7800);

                        var
                        fileToken = f_10043_7785_7799(directive)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 7818, 7853);

                        var
                        path = (string)fileToken.Value
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 7871, 8214) || true) && (path == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 7871, 8214);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 8056, 8164);

                            f_10043_8056_8163(f_10043_8069_8088_M(!directive.IsActive) || (DynAbs.Tracing.TraceSender.Expression_False(10043, 8069, 8162) || f_10043_8092_8162(f_10043_8092_8113(tree), d => d.Severity == DiagnosticSeverity.Error)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 8186, 8195);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 7871, 8214);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 8234, 8280);

                        var
                        diagnostics = f_10043_8252_8279()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 8298, 8329);

                        string
                        resolvedFilePath = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 8347, 11188) || true) && (resolver == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 8347, 11188);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 8409, 8617);

                            f_10043_8409_8616(diagnostics, f_10043_8451_8615(messageProvider, ErrorCode.ERR_SourceFileReferencesNotSupported, f_10043_8596_8614(directive)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 8347, 11188);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 8347, 11188);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 8699, 8779);

                            resolvedFilePath = f_10043_8718_8778(resolver, path, baseFilePath: f_10043_8764_8777(tree));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 8801, 11169) || true) && (resolvedFilePath == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 8801, 11169);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 8879, 9190);

                                f_10043_8879_9189(diagnostics, f_10043_8925_9188(messageProvider, ErrorCode.ERR_NoSourceFile, fileToken.GetLocation(), path, f_10043_9155_9187()));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 8801, 11169);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 8801, 11169);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 9240, 11169) || true) && (!f_10043_9245_9301(loadedSyntaxTreeMapBuilder, resolvedFilePath))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 9240, 11169);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 9411, 9458);

                                        var
                                        code = f_10043_9422_9457(resolver, resolvedFilePath)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 9488, 9726);

                                        var
                                        loadedTree = f_10043_9505_9725(code, f_10043_9608_9620(tree), resolvedFilePath)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 9846, 9910);

                                        f_10043_9846_9909(
                                                                    // All #load'ed trees should have unique path information.
                                                                    loadedSyntaxTreeMapBuilder, f_10043_9877_9896(loadedTree), loadedTree);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 9942, 10514);

                                        f_10043_9942_10513(treesBuilder, loadedTree, scriptClassName, resolver, messageProvider, isSubmission, ordinalMapBuilder, loadDirectiveMapBuilder, loadedSyntaxTreeMapBuilder, declMapBuilder, ref declTable);
                                    }
                                    catch (Exception e)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCatch(10043, 10567, 10854);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 10643, 10827);

                                        f_10043_10643_10826(diagnostics, f_10043_10693_10767(messageProvider, e, resolvedFilePath), fileToken.GetLocation());
                                        DynAbs.Tracing.TraceSender.TraceExitCatch(10043, 10567, 10854);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 9240, 11169);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 9240, 11169);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 11095, 11146);

                                    f_10043_11095_11145(f_10043_11108_11144(diagnostics));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 9240, 11169);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 8801, 11169);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 8347, 11188);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 11208, 11354) || true) && (loadDirectives == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 11208, 11354);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 11276, 11335);

                            loadDirectives = f_10043_11293_11334();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 11208, 11354);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 11372, 11461);

                        f_10043_11372_11460(loadDirectives, f_10043_11391_11459(resolvedFilePath, f_10043_11427_11458(diagnostics)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 7660, 11476);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10043, 1, 3817);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10043, 1, 3817);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 11492, 11638) || true) && (loadDirectives != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 11492, 11638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 11552, 11623);

                    f_10043_11552_11622(loadDirectiveMapBuilder, tree, f_10043_11586_11621(loadDirectives));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 11492, 11638);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10043, 6909, 11649);

                System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax>
                f_10043_7686_7735(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.GetLoadDirectives();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 7686, 7735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10043_7785_7799(Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.File;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 7785, 7799);
                    return return_v;
                }


                bool
                f_10043_8069_8088_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 8069, 8088);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_10043_8092_8113(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 8092, 8113);
                    return return_v;
                }


                bool
                f_10043_8092_8162(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                source, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                predicate)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.Diagnostic>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 8092, 8162);
                    return return_v;
                }


                int
                f_10043_8056_8163(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 8056, 8163);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10043_8252_8279()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 8252, 8279);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10043_8596_8614(Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 8596, 8614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10043_8451_8615(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = this_param.CreateDiagnostic((int)code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 8451, 8615);
                    return return_v;
                }


                int
                f_10043_8409_8616(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 8409, 8616);
                    return 0;
                }


                string
                f_10043_8764_8777(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 8764, 8777);
                    return return_v;
                }


                string?
                f_10043_8718_8778(Microsoft.CodeAnalysis.SourceReferenceResolver
                this_param, string
                path, string
                baseFilePath)
                {
                    var return_v = this_param.ResolveReference(path, baseFilePath: baseFilePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 8718, 8778);
                    return return_v;
                }


                string
                f_10043_9155_9187()
                {
                    var return_v = CSharpResources.CouldNotFindFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 9155, 9187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10043_8925_9188(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic((int)code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 8925, 9188);
                    return return_v;
                }


                int
                f_10043_8879_9189(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 8879, 9189);
                    return 0;
                }


                bool
                f_10043_9245_9301(System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 9245, 9301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_10043_9422_9457(Microsoft.CodeAnalysis.SourceReferenceResolver
                this_param, string
                resolvedPath)
                {
                    var return_v = this_param.ReadText(resolvedPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 9422, 9457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParseOptions
                f_10043_9608_9620(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 9608, 9620);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10043_9505_9725(Microsoft.CodeAnalysis.Text.SourceText
                text, Microsoft.CodeAnalysis.ParseOptions
                options, string
                path)
                {
                    var return_v = SyntaxFactory.ParseSyntaxTree(text, options, path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 9505, 9725);
                    return return_v;
                }


                string
                f_10043_9877_9896(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 9877, 9896);
                    return return_v;
                }


                int
                f_10043_9846_9909(System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                this_param, string
                key, Microsoft.CodeAnalysis.SyntaxTree
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 9846, 9909);
                    return 0;
                }


                int
                f_10043_9942_10513(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                treesBuilder, Microsoft.CodeAnalysis.SyntaxTree
                tree, string
                scriptClassName, Microsoft.CodeAnalysis.SourceReferenceResolver
                resolver, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, bool
                isSubmission, System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                ordinalMapBuilder, System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                loadDirectiveMapBuilder, System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                loadedSyntaxTreeMapBuilder, System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>
                declMapBuilder, ref Microsoft.CodeAnalysis.CSharp.DeclarationTable
                declTable)
                {
                    AppendAllSyntaxTrees(treesBuilder, tree, scriptClassName, resolver, messageProvider, isSubmission, ordinalMapBuilder, loadDirectiveMapBuilder, loadedSyntaxTreeMapBuilder, declMapBuilder, ref declTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 9942, 10513);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10043_10693_10767(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, System.Exception
                e, string
                filePath)
                {
                    var return_v = CommonCompiler.ToFileReadDiagnostics(messageProvider, e, filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 10693, 10767);
                    return return_v;
                }


                int
                f_10043_10643_10826(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 10643, 10826);
                    return 0;
                }


                bool
                f_10043_11108_11144(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.IsEmptyWithoutResolution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 11108, 11144);
                    return return_v;
                }


                int
                f_10043_11095_11145(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 11095, 11145);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.LoadDirective>
                f_10043_11293_11334()
                {
                    var return_v = ArrayBuilder<LoadDirective>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 11293, 11334);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10043_11427_11458(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnlyAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 11427, 11458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LoadDirective
                f_10043_11391_11459(string?
                resolvedPath, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.LoadDirective(resolvedPath, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 11391, 11459);
                    return return_v;
                }


                int
                f_10043_11372_11460(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.LoadDirective>
                this_param, Microsoft.CodeAnalysis.LoadDirective
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 11372, 11460);
                    return 0;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax>
                f_10043_7686_7735_I(System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 7686, 7735);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>
                f_10043_11586_11621(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.LoadDirective>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 11586, 11621);
                    return return_v;
                }


                int
                f_10043_11552_11622(System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 11552, 11622);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10043, 6909, 11649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10043, 6909, 11649);
            }
        }

        private static void AddSyntaxTreeToDeclarationMapAndTable(
                    SyntaxTree tree,
                    string scriptClassName,
                    bool isSubmission,
                    IDictionary<SyntaxTree, Lazy<RootSingleNamespaceDeclaration>> declMapBuilder,
                    ref DeclarationTable declTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10043, 11661, 12297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 11979, 12110);

                var
                lazyRoot = f_10043_11994_12109(() => DeclarationTreeBuilder.ForTree(tree, scriptClassName, isSubmission))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 12124, 12159);

                f_10043_12124_12158(declMapBuilder, tree, lazyRoot);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 12235, 12286);

                declTable = f_10043_12247_12285(declTable, lazyRoot);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10043, 11661, 12297);

                System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>
                f_10043_11994_12109(System.Func<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>
                valueFactory)
                {
                    var return_v = new System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>(valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 11994, 12109);
                    return return_v;
                }


                int
                f_10043_12124_12158(System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 12124, 12158);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.DeclarationTable
                f_10043_12247_12285(Microsoft.CodeAnalysis.CSharp.DeclarationTable
                this_param, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>
                lazyRootDeclaration)
                {
                    var return_v = this_param.AddRootDeclaration(lazyRootDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 12247, 12285);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10043, 11661, 12297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10043, 11661, 12297);
            }
        }

        public SyntaxAndDeclarationManager RemoveSyntaxTrees(HashSet<SyntaxTree> trees)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10043, 12309, 15269);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 12413, 12436);

                var
                state = _lazyState
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 12450, 12538);

                var
                newExternalSyntaxTrees = this.ExternalSyntaxTrees.RemoveAll(t => trees.Contains(t))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 12552, 12678) || true) && (state == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 12552, 12678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 12603, 12663);

                    return f_10043_12610_12662(this, newExternalSyntaxTrees);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 12552, 12678);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 12694, 12730);

                var
                syntaxTrees = state.SyntaxTrees
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 12744, 12790);

                var
                loadDirectiveMap = state.LoadDirectiveMap
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 12804, 12856);

                var
                loadedSyntaxTreeMap = state.LoadedSyntaxTreeMap
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 12870, 12926);

                var
                removeSet = f_10043_12886_12925()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 12940, 13573);
                    foreach (var tree in f_10043_12961_12966_I(trees))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 12940, 13573);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 13000, 13012);

                        int
                        unused1
                        = default(int);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 13030, 13068);

                        ImmutableArray<LoadDirective>
                        unused2
                        = default(ImmutableArray<LoadDirective>);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 13086, 13558);

                        f_10043_13086_13557(tree, includeLoadedTrees: true, syntaxTrees: syntaxTrees, syntaxTreeOrdinalMap: state.OrdinalMap, loadDirectiveMap: loadDirectiveMap, loadedSyntaxTreeMap: loadedSyntaxTreeMap, removeSet: removeSet, totalReferencedTreeCount: out unused1, oldLoadDirectives: out unused2);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 12940, 13573);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10043, 1, 634);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10043, 1, 634);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 13589, 13647);

                var
                treesBuilder = f_10043_13608_13646()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 13661, 13733);

                var
                ordinalMapBuilder = f_10043_13685_13732()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 13747, 13801);

                var
                declMapBuilder = f_10043_13768_13800(state.RootNamespaces)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 13815, 13854);

                var
                declTable = state.DeclarationTable
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 13868, 14648);
                    foreach (var tree in f_10043_13889_13900_I(syntaxTrees))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 13868, 14648);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 13934, 14633) || true) && (f_10043_13938_13962(removeSet, tree))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 13934, 14633);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 14004, 14053);

                            loadDirectiveMap = f_10043_14023_14052(loadDirectiveMap, tree);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 14075, 14139);

                            loadedSyntaxTreeMap = f_10043_14097_14138(loadedSyntaxTreeMap, f_10043_14124_14137(tree));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 14161, 14241);

                            f_10043_14161_14240(tree, declMapBuilder, ref declTable);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 13934, 14633);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 13934, 14633);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 14283, 14633) || true) && (!f_10043_14288_14333(tree, loadedSyntaxTreeMap))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 14283, 14633);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 14375, 14614);

                                f_10043_14375_14613(treesBuilder, tree, ordinalMapBuilder, loadDirectiveMap, loadedSyntaxTreeMap);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 14283, 14633);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 13934, 14633);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 13868, 14648);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10043, 1, 781);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10043, 1, 781);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 14662, 14679);

                f_10043_14662_14678(removeSet);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 14695, 14991);

                state = f_10043_14703_14990(f_10043_14731_14764(treesBuilder), f_10043_14783_14831(ordinalMapBuilder), loadDirectiveMap, loadedSyntaxTreeMap, f_10043_14923_14961(declMapBuilder), declTable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 15007, 15258);

                return f_10043_15014_15257(newExternalSyntaxTrees, this.ScriptClassName, this.Resolver, this.MessageProvider, this.IsSubmission, state);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10043, 12309, 15269);

                Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager
                f_10043_12610_12662(Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                trees)
                {
                    var return_v = this_param.WithExternalSyntaxTrees(trees);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 12610, 12662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.SyntaxTree>
                f_10043_12886_12925()
                {
                    var return_v = PooledHashSet<SyntaxTree>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 12886, 12925);
                    return return_v;
                }


                int
                f_10043_13086_13557(Microsoft.CodeAnalysis.SyntaxTree
                oldTree, bool
                includeLoadedTrees, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                syntaxTrees, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                syntaxTreeOrdinalMap, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                loadDirectiveMap, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                loadedSyntaxTreeMap, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.SyntaxTree>
                removeSet, out int
                totalReferencedTreeCount, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>
                oldLoadDirectives)
                {
                    GetRemoveSet(oldTree, includeLoadedTrees: includeLoadedTrees, syntaxTrees: syntaxTrees, syntaxTreeOrdinalMap: syntaxTreeOrdinalMap, loadDirectiveMap: loadDirectiveMap, loadedSyntaxTreeMap: loadedSyntaxTreeMap, removeSet: (System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTree>)removeSet, out totalReferencedTreeCount, out oldLoadDirectives);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 13086, 13557);
                    return 0;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTree>
                f_10043_12961_12966_I(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTree>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 12961, 12966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                f_10043_13608_13646()
                {
                    var return_v = ArrayBuilder<SyntaxTree>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 13608, 13646);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                f_10043_13685_13732()
                {
                    var return_v = PooledDictionary<SyntaxTree, int>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 13685, 13732);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>.Builder
                f_10043_13768_13800(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>
                this_param)
                {
                    var return_v = this_param.ToBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 13768, 13800);
                    return return_v;
                }


                bool
                f_10043_13938_13962(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.SyntaxTree>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 13938, 13962);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                f_10043_14023_14052(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 14023, 14052);
                    return return_v;
                }


                string
                f_10043_14124_14137(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 14124, 14137);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                f_10043_14097_14138(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                this_param, string
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 14097, 14138);
                    return return_v;
                }


                int
                f_10043_14161_14240(Microsoft.CodeAnalysis.SyntaxTree
                tree, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>.Builder
                declMap, ref Microsoft.CodeAnalysis.CSharp.DeclarationTable
                declTable)
                {
                    RemoveSyntaxTreeFromDeclarationMapAndTable(tree, (System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>)declMap, ref declTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 14161, 14240);
                    return 0;
                }


                bool
                f_10043_14288_14333(Microsoft.CodeAnalysis.SyntaxTree
                tree, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                loadedSyntaxTreeMap)
                {
                    var return_v = IsLoadedSyntaxTree(tree, loadedSyntaxTreeMap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 14288, 14333);
                    return return_v;
                }


                int
                f_10043_14375_14613(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                treesBuilder, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                ordinalMapBuilder, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                loadDirectiveMap, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                loadedSyntaxTreeMap)
                {
                    UpdateSyntaxTreesAndOrdinalMapOnly(treesBuilder, tree, (System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>)ordinalMapBuilder, loadDirectiveMap, loadedSyntaxTreeMap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 14375, 14613);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_10043_13889_13900_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 13889, 13900);
                    return return_v;
                }


                int
                f_10043_14662_14678(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.SyntaxTree>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 14662, 14678);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_10043_14731_14764(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 14731, 14764);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                f_10043_14783_14831(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                this_param)
                {
                    var return_v = this_param.ToImmutableDictionaryAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 14783, 14831);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>
                f_10043_14923_14961(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>.Builder
                builder)
                {
                    var return_v = builder.ToImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 14923, 14961);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager.State
                f_10043_14703_14990(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                syntaxTrees, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                syntaxTreeOrdinalMap, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                loadDirectiveMap, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                loadedSyntaxTreeMap, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>
                rootNamespaces, Microsoft.CodeAnalysis.CSharp.DeclarationTable
                declarationTable)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager.State(syntaxTrees, syntaxTreeOrdinalMap, loadDirectiveMap, loadedSyntaxTreeMap, rootNamespaces, declarationTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 14703, 14990);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager
                f_10043_15014_15257(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                externalSyntaxTrees, string
                scriptClassName, Microsoft.CodeAnalysis.SourceReferenceResolver
                resolver, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, bool
                isSubmission, Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager.State
                state)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager(externalSyntaxTrees, scriptClassName, resolver, messageProvider, isSubmission, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 15014, 15257);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10043, 12309, 15269);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10043, 12309, 15269);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void GetRemoveSet(
                    SyntaxTree oldTree,
                    bool includeLoadedTrees,
                    ImmutableArray<SyntaxTree> syntaxTrees,
                    ImmutableDictionary<SyntaxTree, int> syntaxTreeOrdinalMap,
                    ImmutableDictionary<SyntaxTree, ImmutableArray<LoadDirective>> loadDirectiveMap,
                    ImmutableDictionary<string, SyntaxTree> loadedSyntaxTreeMap,
                    HashSet<SyntaxTree> removeSet,
                    out int totalReferencedTreeCount,
                    out ImmutableArray<LoadDirective> oldLoadDirectives)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10043, 15596, 17869);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 16175, 16587) || true) && (includeLoadedTrees && (DynAbs.Tracing.TraceSender.Expression_True(10043, 16179, 16261) && f_10043_16201_16261(loadDirectiveMap, oldTree, out oldLoadDirectives)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 16175, 16587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 16295, 16336);

                    f_10043_16295_16335(f_10043_16308_16334_M(!oldLoadDirectives.IsEmpty));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 16354, 16450);

                    f_10043_16354_16449(oldLoadDirectives, loadDirectiveMap, loadedSyntaxTreeMap, removeSet);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 16175, 16587);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 16175, 16587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 16516, 16572);

                    oldLoadDirectives = ImmutableArray<LoadDirective>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 16175, 16587);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 16603, 16626);

                f_10043_16603_16625(
                            removeSet, oldTree);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 16640, 16683);

                totalReferencedTreeCount = f_10043_16667_16682(removeSet);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 16923, 17858) || true) && (f_10043_16927_16942(removeSet) > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 16923, 17858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 16980, 17024);

                    var
                    ordinal = f_10043_16994_17023(syntaxTreeOrdinalMap, oldTree)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 17051, 17066);
                        for (int
        i = ordinal + 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 17042, 17843) || true) && (i < syntaxTrees.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 17092, 17095)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 17042, 17843))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 17042, 17843);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 17137, 17163);

                            var
                            tree = syntaxTrees[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 17185, 17230);

                            ImmutableArray<LoadDirective>
                            loadDirectives
                            = default(ImmutableArray<LoadDirective>);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 17252, 17824) || true) && (f_10043_17256_17310(loadDirectiveMap, tree, out loadDirectives))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 17252, 17824);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 17360, 17398);

                                f_10043_17360_17397(f_10043_17373_17396_M(!loadDirectives.IsEmpty));
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 17424, 17801);
                                    foreach (var directive in f_10043_17450_17464_I(loadDirectives))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 17424, 17801);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 17522, 17544);

                                        SyntaxTree
                                        loadedTree
                                        = default(SyntaxTree);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 17574, 17774) || true) && (f_10043_17578_17648(loadedSyntaxTreeMap, directive, out loadedTree))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 17574, 17774);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 17714, 17743);

                                            f_10043_17714_17742(removeSet, loadedTree);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 17574, 17774);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 17424, 17801);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10043, 1, 378);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10043, 1, 378);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 17252, 17824);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10043, 1, 802);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10043, 1, 802);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 16923, 17858);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10043, 15596, 17869);

                bool
                f_10043_16201_16261(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 16201, 16261);
                    return return_v;
                }


                bool
                f_10043_16308_16334_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 16308, 16334);
                    return return_v;
                }


                int
                f_10043_16295_16335(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 16295, 16335);
                    return 0;
                }


                int
                f_10043_16354_16449(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>
                loadDirectives, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                loadDirectiveMap, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                loadedSyntaxTreeMap, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTree>
                removeSet)
                {
                    GetRemoveSetForLoadedTrees(loadDirectives, loadDirectiveMap, loadedSyntaxTreeMap, removeSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 16354, 16449);
                    return 0;
                }


                bool
                f_10043_16603_16625(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTree>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 16603, 16625);
                    return return_v;
                }


                int
                f_10043_16667_16682(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTree>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 16667, 16682);
                    return return_v;
                }


                int
                f_10043_16927_16942(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTree>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 16927, 16942);
                    return return_v;
                }


                int
                f_10043_16994_17023(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 16994, 17023);
                    return return_v;
                }


                bool
                f_10043_17256_17310(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 17256, 17310);
                    return return_v;
                }


                bool
                f_10043_17373_17396_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 17373, 17396);
                    return return_v;
                }


                int
                f_10043_17360_17397(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 17360, 17397);
                    return 0;
                }


                bool
                f_10043_17578_17648(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                loadedSyntaxTreeMap, Microsoft.CodeAnalysis.LoadDirective
                directive, out Microsoft.CodeAnalysis.SyntaxTree
                loadedTree)
                {
                    var return_v = TryGetLoadedSyntaxTree(loadedSyntaxTreeMap, directive, out loadedTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 17578, 17648);
                    return return_v;
                }


                bool
                f_10043_17714_17742(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTree>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 17714, 17742);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>
                f_10043_17450_17464_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 17450, 17464);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10043, 15596, 17869);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10043, 15596, 17869);
            }
        }

        private static void GetRemoveSetForLoadedTrees(
                    ImmutableArray<LoadDirective> loadDirectives,
                    ImmutableDictionary<SyntaxTree, ImmutableArray<LoadDirective>> loadDirectiveMap,
                    ImmutableDictionary<string, SyntaxTree> loadedSyntaxTreeMap,
                    HashSet<SyntaxTree> removeSet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10043, 17881, 19044);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 18224, 19033);
                    foreach (var directive in f_10043_18250_18264_I(loadDirectives))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 18224, 19033);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 18298, 19018) || true) && (directive.ResolvedPath != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 18298, 19018);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 18374, 18396);

                            SyntaxTree
                            loadedTree
                            = default(SyntaxTree);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 18418, 18999) || true) && (f_10043_18422_18492(loadedSyntaxTreeMap, directive, out loadedTree) && (DynAbs.Tracing.TraceSender.Expression_True(10043, 18422, 18521) && f_10043_18496_18521(removeSet, loadedTree)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 18418, 18999);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 18571, 18622);

                                ImmutableArray<LoadDirective>
                                nestedLoadDirectives
                                = default(ImmutableArray<LoadDirective>);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 18648, 18976) || true) && (f_10043_18652_18718(loadDirectiveMap, loadedTree, out nestedLoadDirectives))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 18648, 18976);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 18776, 18820);

                                    f_10043_18776_18819(f_10043_18789_18818_M(!nestedLoadDirectives.IsEmpty));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 18850, 18949);

                                    f_10043_18850_18948(nestedLoadDirectives, loadDirectiveMap, loadedSyntaxTreeMap, removeSet);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 18648, 18976);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 18418, 18999);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 18298, 19018);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 18224, 19033);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10043, 1, 810);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10043, 1, 810);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10043, 17881, 19044);

                bool
                f_10043_18422_18492(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                loadedSyntaxTreeMap, Microsoft.CodeAnalysis.LoadDirective
                directive, out Microsoft.CodeAnalysis.SyntaxTree
                loadedTree)
                {
                    var return_v = TryGetLoadedSyntaxTree(loadedSyntaxTreeMap, directive, out loadedTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 18422, 18492);
                    return return_v;
                }


                bool
                f_10043_18496_18521(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTree>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 18496, 18521);
                    return return_v;
                }


                bool
                f_10043_18652_18718(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 18652, 18718);
                    return return_v;
                }


                bool
                f_10043_18789_18818_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 18789, 18818);
                    return return_v;
                }


                int
                f_10043_18776_18819(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 18776, 18819);
                    return 0;
                }


                int
                f_10043_18850_18948(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>
                loadDirectives, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                loadDirectiveMap, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                loadedSyntaxTreeMap, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTree>
                removeSet)
                {
                    GetRemoveSetForLoadedTrees(loadDirectives, loadDirectiveMap, loadedSyntaxTreeMap, removeSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 18850, 18948);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>
                f_10043_18250_18264_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 18250, 18264);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10043, 17881, 19044);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10043, 17881, 19044);
            }
        }

        private static void RemoveSyntaxTreeFromDeclarationMapAndTable(
                    SyntaxTree tree,
                    IDictionary<SyntaxTree, Lazy<RootSingleNamespaceDeclaration>> declMap,
                    ref DeclarationTable declTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10043, 19056, 19446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 19303, 19332);

                var
                lazyRoot = f_10043_19318_19331(declMap, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 19346, 19400);

                declTable = f_10043_19358_19399(declTable, lazyRoot);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 19414, 19435);

                f_10043_19414_19434(declMap, tree);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10043, 19056, 19446);

                System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>
                f_10043_19318_19331(System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 19318, 19331);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DeclarationTable
                f_10043_19358_19399(Microsoft.CodeAnalysis.CSharp.DeclarationTable
                this_param, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>
                lazyRootDeclaration)
                {
                    var return_v = this_param.RemoveRootDeclaration(lazyRootDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 19358, 19399);
                    return return_v;
                }


                bool
                f_10043_19414_19434(System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 19414, 19434);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10043, 19056, 19446);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10043, 19056, 19446);
            }
        }

        public SyntaxAndDeclarationManager ReplaceSyntaxTree(SyntaxTree oldTree, SyntaxTree newTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10043, 19458, 25271);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 19575, 19598);

                var
                state = _lazyState
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 19612, 19692);

                var
                newExternalSyntaxTrees = this.ExternalSyntaxTrees.Replace(oldTree, newTree)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 19706, 19832) || true) && (state == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 19706, 19832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 19757, 19817);

                    return f_10043_19764_19816(this, newExternalSyntaxTrees);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 19706, 19832);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 19848, 19931);

                var
                newLoadDirectivesSyntax = f_10043_19878_19930(newTree.GetCompilationUnitRoot())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 19945, 20070);

                var
                loadDirectivesHaveChanged = !f_10043_19978_20069(f_10043_19978_20030(oldTree.GetCompilationUnitRoot()), newLoadDirectivesSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 20084, 20120);

                var
                syntaxTrees = state.SyntaxTrees
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 20134, 20168);

                var
                ordinalMap = state.OrdinalMap
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 20182, 20228);

                var
                loadDirectiveMap = state.LoadDirectiveMap
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 20242, 20294);

                var
                loadedSyntaxTreeMap = state.LoadedSyntaxTreeMap
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 20308, 20364);

                var
                removeSet = f_10043_20324_20363()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 20378, 20407);

                int
                totalReferencedTreeCount
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 20421, 20469);

                ImmutableArray<LoadDirective>
                oldLoadDirectives
                = default(ImmutableArray<LoadDirective>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 20483, 20814);

                f_10043_20483_20813(oldTree, loadDirectivesHaveChanged, syntaxTrees, ordinalMap, loadDirectiveMap, loadedSyntaxTreeMap, removeSet, out totalReferencedTreeCount, out oldLoadDirectives);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 20830, 20889);

                var
                loadDirectiveMapBuilder = f_10043_20860_20888(loadDirectiveMap)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 20903, 20968);

                var
                loadedSyntaxTreeMapBuilder = f_10043_20936_20967(loadedSyntaxTreeMap)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 20982, 21036);

                var
                declMapBuilder = f_10043_21003_21035(state.RootNamespaces)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 21050, 21089);

                var
                declTable = state.DeclarationTable
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 21103, 21384);
                    foreach (var tree in f_10043_21124_21133_I(removeSet))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 21103, 21384);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 21167, 21204);

                        f_10043_21167_21203(loadDirectiveMapBuilder, tree);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 21222, 21271);

                        f_10043_21222_21270(loadedSyntaxTreeMapBuilder, f_10043_21256_21269(tree));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 21289, 21369);

                        f_10043_21289_21368(tree, declMapBuilder, ref declTable);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 21103, 21384);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10043, 1, 282);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10043, 1, 282);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 21398, 21415);

                f_10043_21398_21414(removeSet);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 21431, 21468);

                var
                oldOrdinal = f_10043_21448_21467(ordinalMap, oldTree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 21482, 21518);

                ImmutableArray<SyntaxTree>
                newTrees
                = default(ImmutableArray<SyntaxTree>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 21532, 24712) || true) && (loadDirectivesHaveChanged)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 21532, 24712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 21649, 21709);

                    f_10043_21649_21708(!f_10043_21663_21707(loadDirectiveMapBuilder, oldTree));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 21727, 21787);

                    f_10043_21727_21786(!f_10043_21741_21785(loadDirectiveMapBuilder, newTree));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 21947, 22005);

                    var
                    treesBuilder = f_10043_21966_22004()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 22023, 22095);

                    var
                    ordinalMapBuilder = f_10043_22047_22094()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 22122, 22127);
                        for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 22113, 22363) || true) && (i <= (oldOrdinal - totalReferencedTreeCount))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 22175, 22178)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 22113, 22363))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 22113, 22363);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 22220, 22246);

                            var
                            tree = syntaxTrees[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 22268, 22291);

                            f_10043_22268_22290(treesBuilder, tree);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 22313, 22344);

                            f_10043_22313_22343(ordinalMapBuilder, tree, i);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10043, 1, 251);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10043, 1, 251);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 22383, 22840);

                    f_10043_22383_22839(treesBuilder, newTree, this.ScriptClassName, this.Resolver, this.MessageProvider, this.IsSubmission, ordinalMapBuilder, loadDirectiveMapBuilder, loadedSyntaxTreeMapBuilder, declMapBuilder, ref declTable);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 22869, 22887);

                        for (var
        i = oldOrdinal + 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 22860, 23407) || true) && (i < syntaxTrees.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 22913, 22916)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 22860, 23407))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 22860, 23407);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 22958, 22984);

                            var
                            tree = syntaxTrees[i]
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 23006, 23388) || true) && (!f_10043_23011_23056(tree, loadedSyntaxTreeMap))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 23006, 23388);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 23106, 23365);

                                f_10043_23106_23364(treesBuilder, tree, ordinalMapBuilder, loadDirectiveMap, loadedSyntaxTreeMap);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 23006, 23388);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10043, 1, 548);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10043, 1, 548);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 23427, 23472);

                    newTrees = f_10043_23438_23471(treesBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 23490, 23552);

                    ordinalMap = f_10043_23503_23551(ordinalMapBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 23570, 23620);

                    f_10043_23570_23619(newTrees.Length == f_10043_23602_23618(ordinalMap));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 21532, 24712);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 21532, 24712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 23686, 23805);

                    f_10043_23686_23804(newTree, this.ScriptClassName, this.IsSubmission, declMapBuilder, ref declTable);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 23825, 24371) || true) && (f_10043_23829_23858(newLoadDirectivesSyntax))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 23825, 24371);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 24077, 24120);

                        f_10043_24077_24119(f_10043_24090_24118_M(!oldLoadDirectives.IsDefault));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 24142, 24183);

                        f_10043_24142_24182(f_10043_24155_24181_M(!oldLoadDirectives.IsEmpty));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 24205, 24277);

                        f_10043_24205_24276(oldLoadDirectives.Length == f_10043_24246_24275(newLoadDirectivesSyntax));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 24299, 24352);

                        loadDirectiveMapBuilder[newTree] = oldLoadDirectives;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 23825, 24371);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 24391, 24437);

                    f_10043_24391_24436(f_10043_24404_24435(ordinalMap, oldTree));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 24514, 24566);

                    newTrees = syntaxTrees.SetItem(oldOrdinal, newTree);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 24586, 24626);

                    ordinalMap = f_10043_24599_24625(ordinalMap, oldTree);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 24644, 24697);

                    ordinalMap = f_10043_24657_24696(ordinalMap, newTree, oldOrdinal);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 21532, 24712);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 24728, 24993);

                state = f_10043_24736_24992(newTrees, ordinalMap, f_10043_24820_24857(loadDirectiveMapBuilder), f_10043_24876_24916(loadedSyntaxTreeMapBuilder), f_10043_24935_24963(declMapBuilder), declTable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 25009, 25260);

                return f_10043_25016_25259(newExternalSyntaxTrees, this.ScriptClassName, this.Resolver, this.MessageProvider, this.IsSubmission, state);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10043, 19458, 25271);

                Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager
                f_10043_19764_19816(Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                trees)
                {
                    var return_v = this_param.WithExternalSyntaxTrees(trees);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 19764, 19816);
                    return return_v;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax>
                f_10043_19878_19930(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.GetLoadDirectives();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 19878, 19930);
                    return return_v;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax>
                f_10043_19978_20030(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.GetLoadDirectives();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 19978, 20030);
                    return return_v;
                }


                bool
                f_10043_19978_20069(System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax>
                first, System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax>
                second)
                {
                    var return_v = first.SequenceEqual<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 19978, 20069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.SyntaxTree>
                f_10043_20324_20363()
                {
                    var return_v = PooledHashSet<SyntaxTree>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 20324, 20363);
                    return return_v;
                }


                int
                f_10043_20483_20813(Microsoft.CodeAnalysis.SyntaxTree
                oldTree, bool
                includeLoadedTrees, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                syntaxTrees, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                syntaxTreeOrdinalMap, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                loadDirectiveMap, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                loadedSyntaxTreeMap, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.SyntaxTree>
                removeSet, out int
                totalReferencedTreeCount, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>
                oldLoadDirectives)
                {
                    GetRemoveSet(oldTree, includeLoadedTrees, syntaxTrees, syntaxTreeOrdinalMap, loadDirectiveMap, loadedSyntaxTreeMap, (System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTree>)removeSet, out totalReferencedTreeCount, out oldLoadDirectives);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 20483, 20813);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>.Builder
                f_10043_20860_20888(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                this_param)
                {
                    var return_v = this_param.ToBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 20860, 20888);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>.Builder
                f_10043_20936_20967(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                this_param)
                {
                    var return_v = this_param.ToBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 20936, 20967);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>.Builder
                f_10043_21003_21035(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>
                this_param)
                {
                    var return_v = this_param.ToBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 21003, 21035);
                    return return_v;
                }


                bool
                f_10043_21167_21203(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>.Builder
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 21167, 21203);
                    return return_v;
                }


                string
                f_10043_21256_21269(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 21256, 21269);
                    return return_v;
                }


                bool
                f_10043_21222_21270(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>.Builder
                this_param, string
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 21222, 21270);
                    return return_v;
                }


                int
                f_10043_21289_21368(Microsoft.CodeAnalysis.SyntaxTree
                tree, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>.Builder
                declMap, ref Microsoft.CodeAnalysis.CSharp.DeclarationTable
                declTable)
                {
                    RemoveSyntaxTreeFromDeclarationMapAndTable(tree, (System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>)declMap, ref declTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 21289, 21368);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.SyntaxTree>
                f_10043_21124_21133_I(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.SyntaxTree>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 21124, 21133);
                    return return_v;
                }


                int
                f_10043_21398_21414(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.SyntaxTree>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 21398, 21414);
                    return 0;
                }


                int
                f_10043_21448_21467(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 21448, 21467);
                    return return_v;
                }


                bool
                f_10043_21663_21707(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>.Builder
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 21663, 21707);
                    return return_v;
                }


                int
                f_10043_21649_21708(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 21649, 21708);
                    return 0;
                }


                bool
                f_10043_21741_21785(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>.Builder
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 21741, 21785);
                    return return_v;
                }


                int
                f_10043_21727_21786(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 21727, 21786);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                f_10043_21966_22004()
                {
                    var return_v = ArrayBuilder<SyntaxTree>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 21966, 22004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                f_10043_22047_22094()
                {
                    var return_v = PooledDictionary<SyntaxTree, int>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 22047, 22094);
                    return return_v;
                }


                int
                f_10043_22268_22290(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 22268, 22290);
                    return 0;
                }


                int
                f_10043_22313_22343(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, int
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 22313, 22343);
                    return 0;
                }


                int
                f_10043_22383_22839(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                treesBuilder, Microsoft.CodeAnalysis.SyntaxTree
                tree, string
                scriptClassName, Microsoft.CodeAnalysis.SourceReferenceResolver
                resolver, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, bool
                isSubmission, Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                ordinalMapBuilder, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>.Builder
                loadDirectiveMapBuilder, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>.Builder
                loadedSyntaxTreeMapBuilder, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>.Builder
                declMapBuilder, ref Microsoft.CodeAnalysis.CSharp.DeclarationTable
                declTable)
                {
                    AppendAllSyntaxTrees(treesBuilder, tree, scriptClassName, resolver, messageProvider, isSubmission, (System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>)ordinalMapBuilder, (System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>)loadDirectiveMapBuilder, (System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>)loadedSyntaxTreeMapBuilder, (System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>)declMapBuilder, ref declTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 22383, 22839);
                    return 0;
                }


                bool
                f_10043_23011_23056(Microsoft.CodeAnalysis.SyntaxTree
                tree, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                loadedSyntaxTreeMap)
                {
                    var return_v = IsLoadedSyntaxTree(tree, loadedSyntaxTreeMap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 23011, 23056);
                    return return_v;
                }


                int
                f_10043_23106_23364(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                treesBuilder, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                ordinalMapBuilder, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                loadDirectiveMap, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                loadedSyntaxTreeMap)
                {
                    UpdateSyntaxTreesAndOrdinalMapOnly(treesBuilder, tree, (System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>)ordinalMapBuilder, loadDirectiveMap, loadedSyntaxTreeMap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 23106, 23364);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_10043_23438_23471(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 23438, 23471);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                f_10043_23503_23551(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                this_param)
                {
                    var return_v = this_param.ToImmutableDictionaryAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 23503, 23551);
                    return return_v;
                }


                int
                f_10043_23602_23618(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 23602, 23618);
                    return return_v;
                }


                int
                f_10043_23570_23619(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 23570, 23619);
                    return 0;
                }


                int
                f_10043_23686_23804(Microsoft.CodeAnalysis.SyntaxTree
                tree, string
                scriptClassName, bool
                isSubmission, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>.Builder
                declMapBuilder, ref Microsoft.CodeAnalysis.CSharp.DeclarationTable
                declTable)
                {
                    AddSyntaxTreeToDeclarationMapAndTable(tree, scriptClassName, isSubmission, (System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>)declMapBuilder, ref declTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 23686, 23804);
                    return 0;
                }


                bool
                f_10043_23829_23858(System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax>
                source)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 23829, 23858);
                    return return_v;
                }


                bool
                f_10043_24090_24118_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 24090, 24118);
                    return return_v;
                }


                int
                f_10043_24077_24119(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 24077, 24119);
                    return 0;
                }


                bool
                f_10043_24155_24181_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 24155, 24181);
                    return return_v;
                }


                int
                f_10043_24142_24182(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 24142, 24182);
                    return 0;
                }


                int
                f_10043_24246_24275(System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 24246, 24275);
                    return return_v;
                }


                int
                f_10043_24205_24276(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 24205, 24276);
                    return 0;
                }


                bool
                f_10043_24404_24435(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 24404, 24435);
                    return return_v;
                }


                int
                f_10043_24391_24436(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 24391, 24436);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                f_10043_24599_24625(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 24599, 24625);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                f_10043_24657_24696(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, int
                value)
                {
                    var return_v = this_param.SetItem(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 24657, 24696);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                f_10043_24820_24857(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 24820, 24857);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                f_10043_24876_24916(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 24876, 24916);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>
                f_10043_24935_24963(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 24935, 24963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager.State
                f_10043_24736_24992(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                syntaxTrees, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                syntaxTreeOrdinalMap, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                loadDirectiveMap, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                loadedSyntaxTreeMap, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>
                rootNamespaces, Microsoft.CodeAnalysis.CSharp.DeclarationTable
                declarationTable)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager.State(syntaxTrees, syntaxTreeOrdinalMap, loadDirectiveMap, loadedSyntaxTreeMap, rootNamespaces, declarationTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 24736, 24992);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager
                f_10043_25016_25259(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                externalSyntaxTrees, string
                scriptClassName, Microsoft.CodeAnalysis.SourceReferenceResolver
                resolver, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, bool
                isSubmission, Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager.State
                state)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager(externalSyntaxTrees, scriptClassName, resolver, messageProvider, isSubmission, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 25016, 25259);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10043, 19458, 25271);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10043, 19458, 25271);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxAndDeclarationManager WithExternalSyntaxTrees(ImmutableArray<SyntaxTree> trees)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10043, 25283, 25550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 25402, 25539);

                return f_10043_25409_25538(trees, this.ScriptClassName, this.Resolver, this.MessageProvider, this.IsSubmission, state: null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10043, 25283, 25550);

                Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager
                f_10043_25409_25538(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                externalSyntaxTrees, string
                scriptClassName, Microsoft.CodeAnalysis.SourceReferenceResolver
                resolver, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, bool
                isSubmission, Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager.State
                state)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxAndDeclarationManager(externalSyntaxTrees, scriptClassName, resolver, messageProvider, isSubmission, state: state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 25409, 25538);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10043, 25283, 25550);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10043, 25283, 25550);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsLoadedSyntaxTree(SyntaxTree tree, ImmutableDictionary<string, SyntaxTree> loadedSyntaxTreeMap)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10043, 25562, 25845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 25704, 25726);

                SyntaxTree
                loadedTree
                = default(SyntaxTree);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 25740, 25834);

                return f_10043_25747_25809(loadedSyntaxTreeMap, f_10043_25779_25792(tree), out loadedTree) && (DynAbs.Tracing.TraceSender.Expression_True(10043, 25747, 25833) && (tree == loadedTree));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10043, 25562, 25845);

                string
                f_10043_25779_25792(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 25779, 25792);
                    return return_v;
                }


                bool
                f_10043_25747_25809(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                this_param, string
                key, out Microsoft.CodeAnalysis.SyntaxTree
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 25747, 25809);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10043, 25562, 25845);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10043, 25562, 25845);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void UpdateSyntaxTreesAndOrdinalMapOnly(
                    ArrayBuilder<SyntaxTree> treesBuilder,
                    SyntaxTree tree,
                    IDictionary<SyntaxTree, int> ordinalMapBuilder,
                    ImmutableDictionary<SyntaxTree, ImmutableArray<LoadDirective>> loadDirectiveMap,
                    ImmutableDictionary<string, SyntaxTree> loadedSyntaxTreeMap)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10043, 25857, 27670);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 26248, 26287);

                var
                sourceCodeKind = f_10043_26269_26286(f_10043_26269_26281(tree))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 26301, 27551) || true) && (sourceCodeKind == SourceCodeKind.Script)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 26301, 27551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 26378, 26423);

                    ImmutableArray<LoadDirective>
                    loadDirectives
                    = default(ImmutableArray<LoadDirective>);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 26441, 27536) || true) && (f_10043_26445_26499(loadDirectiveMap, tree, out loadDirectives))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 26441, 27536);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 26541, 26579);

                        f_10043_26541_26578(f_10043_26554_26577_M(!loadDirectives.IsEmpty));
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 26601, 27517);
                            foreach (var directive in f_10043_26627_26641_I(loadDirectives))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 26601, 27517);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 26691, 26733);

                                var
                                resolvedPath = directive.ResolvedPath
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 26759, 26830);

                                f_10043_26759_26829((resolvedPath != null) || (DynAbs.Tracing.TraceSender.Expression_False(10043, 26772, 26828) || f_10043_26798_26828_M(!directive.Diagnostics.IsEmpty)));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 26856, 26974) || true) && (resolvedPath == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 26856, 26974);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 26938, 26947);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 26856, 26974);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 27002, 27024);

                                SyntaxTree
                                loadedTree
                                = default(SyntaxTree);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 27050, 27494) || true) && (f_10043_27054_27124(loadedSyntaxTreeMap, directive, out loadedTree))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 27050, 27494);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 27182, 27467);

                                    f_10043_27182_27466(treesBuilder, loadedTree, ordinalMapBuilder, loadDirectiveMap, loadedSyntaxTreeMap);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 27050, 27494);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 26601, 27517);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10043, 1, 917);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10043, 1, 917);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 26441, 27536);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 26301, 27551);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 27567, 27590);

                f_10043_27567_27589(
                            treesBuilder, tree);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 27606, 27659);

                f_10043_27606_27658(
                            ordinalMapBuilder, tree, f_10043_27634_27657(ordinalMapBuilder));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10043, 25857, 27670);

                Microsoft.CodeAnalysis.ParseOptions
                f_10043_26269_26281(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 26269, 26281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceCodeKind
                f_10043_26269_26286(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 26269, 26286);
                    return return_v;
                }


                bool
                f_10043_26445_26499(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 26445, 26499);
                    return return_v;
                }


                bool
                f_10043_26554_26577_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 26554, 26577);
                    return return_v;
                }


                int
                f_10043_26541_26578(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 26541, 26578);
                    return 0;
                }


                bool
                f_10043_26798_26828_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 26798, 26828);
                    return return_v;
                }


                int
                f_10043_26759_26829(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 26759, 26829);
                    return 0;
                }


                bool
                f_10043_27054_27124(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                loadedSyntaxTreeMap, Microsoft.CodeAnalysis.LoadDirective
                directive, out Microsoft.CodeAnalysis.SyntaxTree
                loadedTree)
                {
                    var return_v = TryGetLoadedSyntaxTree(loadedSyntaxTreeMap, directive, out loadedTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 27054, 27124);
                    return return_v;
                }


                int
                f_10043_27182_27466(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                treesBuilder, Microsoft.CodeAnalysis.SyntaxTree
                tree, System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                ordinalMapBuilder, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>>
                loadDirectiveMap, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                loadedSyntaxTreeMap)
                {
                    UpdateSyntaxTreesAndOrdinalMapOnly(treesBuilder, tree, ordinalMapBuilder, loadDirectiveMap, loadedSyntaxTreeMap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 27182, 27466);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>
                f_10043_26627_26641_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LoadDirective>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 26627, 26641);
                    return return_v;
                }


                int
                f_10043_27567_27589(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 27567, 27589);
                    return 0;
                }


                int
                f_10043_27634_27657(System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 27634, 27657);
                    return return_v;
                }


                int
                f_10043_27606_27658(System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.SyntaxTree, int>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, int
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 27606, 27658);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10043, 25857, 27670);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10043, 25857, 27670);
            }
        }

        internal bool MayHaveReferenceDirectives()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10043, 27682, 28074);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 27749, 27772);

                var
                state = _lazyState
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 27786, 27991) || true) && (state == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 27786, 27991);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 27837, 27888);

                    var
                    externalSyntaxTrees = this.ExternalSyntaxTrees
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 27906, 27976);

                    return externalSyntaxTrees.Any(t => t.HasReferenceOrLoadDirectives());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 27786, 27991);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 28007, 28063);

                return f_10043_28014_28062(f_10043_28014_28056(state.DeclarationTable));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10043, 27682, 28074);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ReferenceDirective>
                f_10043_28014_28056(Microsoft.CodeAnalysis.CSharp.DeclarationTable
                this_param)
                {
                    var return_v = this_param.ReferenceDirectives;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10043, 28014, 28056);
                    return return_v;
                }


                bool
                f_10043_28014_28062(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ReferenceDirective>
                source)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.ReferenceDirective>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 28014, 28062);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10043, 27682, 28074);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10043, 27682, 28074);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryGetLoadedSyntaxTree(ImmutableDictionary<string, SyntaxTree> loadedSyntaxTreeMap, LoadDirective directive, out SyntaxTree loadedTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10043, 28086, 28593);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 28266, 28402) || true) && (f_10043_28270_28341(loadedSyntaxTreeMap, directive.ResolvedPath, out loadedTree))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10043, 28266, 28402);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 28375, 28387);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10043, 28266, 28402);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 28502, 28553);

                f_10043_28502_28552(directive.Diagnostics.HasAnyErrors());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10043, 28569, 28582);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10043, 28086, 28593);

                bool
                f_10043_28270_28341(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                this_param, string?
                key, out Microsoft.CodeAnalysis.SyntaxTree
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 28270, 28341);
                    return return_v;
                }


                int
                f_10043_28502_28552(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10043, 28502, 28552);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10043, 28086, 28593);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10043, 28086, 28593);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SyntaxAndDeclarationManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10043, 526, 28600);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10043, 526, 28600);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10043, 526, 28600);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10043, 526, 28600);

        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
        f_10043_986_1005_C(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10043, 673, 1119);
            return return_v;
        }

    }
}
