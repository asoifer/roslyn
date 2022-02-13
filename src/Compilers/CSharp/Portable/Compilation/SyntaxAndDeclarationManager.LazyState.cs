// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class SyntaxAndDeclarationManager : CommonSyntaxAndDeclarationManager
    {
        internal sealed class State
        {
            internal readonly ImmutableArray<SyntaxTree> SyntaxTrees;

            internal readonly ImmutableDictionary<SyntaxTree, int> OrdinalMap;

            internal readonly ImmutableDictionary<SyntaxTree, ImmutableArray<LoadDirective>> LoadDirectiveMap;

            internal readonly ImmutableDictionary<string, SyntaxTree> LoadedSyntaxTreeMap;

            internal readonly ImmutableDictionary<SyntaxTree, Lazy<RootSingleNamespaceDeclaration>> RootNamespaces;

            internal readonly DeclarationTable DeclarationTable;

            internal State(
                            ImmutableArray<SyntaxTree> syntaxTrees,
                            ImmutableDictionary<SyntaxTree, int> syntaxTreeOrdinalMap,
                            ImmutableDictionary<SyntaxTree, ImmutableArray<LoadDirective>> loadDirectiveMap,
                            ImmutableDictionary<string, SyntaxTree> loadedSyntaxTreeMap,
                            ImmutableDictionary<SyntaxTree, Lazy<RootSingleNamespaceDeclaration>> rootNamespaces,
                            DeclarationTable declarationTable)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10068, 1286, 2373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10068, 814, 824);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10068, 978, 994);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10068, 1067, 1086);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10068, 1189, 1203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10068, 1253, 1269);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10068, 1798, 1885);

                    f_10068_1798_1884(syntaxTrees.All(tree => syntaxTrees[syntaxTreeOrdinalMap[tree]] == tree));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10068, 1903, 2012);

                    f_10068_1903_2011(syntaxTrees.SetEquals(f_10068_1938_1971(f_10068_1938_1957(rootNamespaces)), f_10068_1973_2009()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10068, 2032, 2063);

                    this.SyntaxTrees = syntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10068, 2081, 2120);

                    this.OrdinalMap = syntaxTreeOrdinalMap;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10068, 2138, 2179);

                    this.LoadDirectiveMap = loadDirectiveMap;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10068, 2197, 2244);

                    this.LoadedSyntaxTreeMap = loadedSyntaxTreeMap;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10068, 2262, 2299);

                    this.RootNamespaces = rootNamespaces;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10068, 2317, 2358);

                    this.DeclarationTable = declarationTable;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10068, 1286, 2373);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10068, 1286, 2373);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10068, 1286, 2373);
                }
            }

            static State()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10068, 615, 2384);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10068, 615, 2384);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10068, 615, 2384);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10068, 615, 2384);

            int
            f_10068_1798_1884(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10068, 1798, 1884);
                return 0;
            }


            System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
            f_10068_1938_1957(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>>
            this_param)
            {
                var return_v = this_param.Keys;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10068, 1938, 1957);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
            f_10068_1938_1971(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
            items)
            {
                var return_v = items.AsImmutable<Microsoft.CodeAnalysis.SyntaxTree>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10068, 1938, 1971);
                return return_v;
            }


            System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.SyntaxTree>
            f_10068_1973_2009()
            {
                var return_v = EqualityComparer<SyntaxTree>.Default;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10068, 1973, 2009);
                return return_v;
            }


            int
            f_10068_1903_2011(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10068, 1903, 2011);
                return 0;
            }

        }
    }
}
