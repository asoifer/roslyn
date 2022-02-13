// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class DeclarationTable
    {
        private class Cache
        {
            internal readonly Lazy<MergedNamespaceDeclaration> MergedRoot;

            internal readonly Lazy<ISet<string>> TypeNames;

            internal readonly Lazy<ISet<string>> NamespaceNames;

            internal readonly Lazy<ImmutableArray<ReferenceDirective>> ReferenceDirectives;

            public Cache(DeclarationTable table)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10070, 1599, 2398);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10070, 1263, 1273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10070, 1414, 1423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10070, 1475, 1489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10070, 1563, 1582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10070, 1668, 1878);

                    this.MergedRoot = f_10070_1686_1877(() => MergedNamespaceDeclaration.Create(table._allOlderRootDeclarations.InInsertionOrder.AsImmutable<SingleNamespaceDeclaration>()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10070, 1898, 2003);

                    this.TypeNames = f_10070_1915_2002(() => GetTypeNames(this.MergedRoot.Value));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10070, 2023, 2138);

                    this.NamespaceNames = f_10070_2045_2137(() => GetNamespaceNames(this.MergedRoot.Value));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10070, 2158, 2383);

                    this.ReferenceDirectives = f_10070_2185_2382(() => MergedRoot.Value.Declarations.OfType<RootSingleNamespaceDeclaration>().SelectMany(r => r.ReferenceDirectives).AsImmutable());
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10070, 1599, 2398);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10070, 1599, 2398);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10070, 1599, 2398);
                }
            }

            static Cache()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10070, 1092, 2409);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10070, 1092, 2409);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10070, 1092, 2409);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10070, 1092, 2409);

            System.Lazy<Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration>
            f_10070_1686_1877(System.Func<Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration>
            valueFactory)
            {
                var return_v = new System.Lazy<Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration>(valueFactory);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10070, 1686, 1877);
                return return_v;
            }


            System.Lazy<System.Collections.Generic.ISet<string>>
            f_10070_1915_2002(System.Func<System.Collections.Generic.ISet<string>>
            valueFactory)
            {
                var return_v = new System.Lazy<System.Collections.Generic.ISet<string>>(valueFactory);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10070, 1915, 2002);
                return return_v;
            }


            System.Lazy<System.Collections.Generic.ISet<string>>
            f_10070_2045_2137(System.Func<System.Collections.Generic.ISet<string>>
            valueFactory)
            {
                var return_v = new System.Lazy<System.Collections.Generic.ISet<string>>(valueFactory);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10070, 2045, 2137);
                return return_v;
            }


            System.Lazy<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ReferenceDirective>>
            f_10070_2185_2382(System.Func<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ReferenceDirective>>
            valueFactory)
            {
                var return_v = new System.Lazy<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ReferenceDirective>>(valueFactory);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10070, 2185, 2382);
                return return_v;
            }

        }

        static DeclarationTable()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10070, 386, 2416);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 1172, 1382);

            // Lafhis
            //Empty = f_10045_1180_1382(allOlderRootDeclarations: ImmutableSetWithInsertionOrder<RootSingleNamespaceDeclaration>.Empty, latestLazyRootDeclaration: null, cache: null);
            Empty = new DeclarationTable(allOlderRootDeclarations: Roslyn.Utilities.ImmutableSetWithInsertionOrder<RootSingleNamespaceDeclaration>.Empty, latestLazyRootDeclaration: null, cache: null);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 1180, 1382);

            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 9695, 9760);
            s_isNamespacePredicate = d => d.Kind == DeclarationKind.Namespace; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 9818, 9878);
            s_isTypePredicate = d => d.Kind != DeclarationKind.Namespace; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10070, 386, 2416);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10070, 386, 2416);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10070, 386, 2416);
    }
}
