// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class RootSingleNamespaceDeclaration : SingleNamespaceDeclaration
    {
        private readonly ImmutableArray<ReferenceDirective> _referenceDirectives;

        private readonly bool _hasAssemblyAttributes;

        private readonly bool _hasUsings;

        private readonly bool _hasExternAliases;

        public RootSingleNamespaceDeclaration(
                    bool hasUsings,
                    bool hasExternAliases,
                    SyntaxReference treeNode,
                    ImmutableArray<SingleNamespaceOrTypeDeclaration> children,
                    ImmutableArray<ReferenceDirective> referenceDirectives,
                    bool hasAssemblyAttributes)
        : base(f_10396_1019_1031_C(string.Empty), treeNode, nameLocation: f_10396_1097_1125(treeNode), children: children, diagnostics: ImmutableArray<Diagnostic>.Empty)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10396, 674, 1522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10396, 546, 568);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10396, 601, 611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10396, 644, 661);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10396, 1258, 1303);

                f_10396_1258_1302(f_10396_1271_1301_M(!referenceDirectives.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10396, 1319, 1362);

                _referenceDirectives = referenceDirectives;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10396, 1376, 1423);

                _hasAssemblyAttributes = hasAssemblyAttributes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10396, 1437, 1460);

                _hasUsings = hasUsings;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10396, 1474, 1511);

                _hasExternAliases = hasExternAliases;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10396, 674, 1522);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10396, 674, 1522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10396, 674, 1522);
            }
        }

        public ImmutableArray<ReferenceDirective> ReferenceDirectives
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10396, 1620, 1699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10396, 1656, 1684);

                    return _referenceDirectives;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10396, 1620, 1699);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10396, 1534, 1710);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10396, 1534, 1710);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasAssemblyAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10396, 1780, 1861);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10396, 1816, 1846);

                    return _hasAssemblyAttributes;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10396, 1780, 1861);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10396, 1722, 1872);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10396, 1722, 1872);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasUsings
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10396, 1939, 2008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10396, 1975, 1993);

                    return _hasUsings;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10396, 1939, 2008);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10396, 1884, 2019);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10396, 1884, 2019);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasExternAliases
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10396, 2093, 2169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10396, 2129, 2154);

                    return _hasExternAliases;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10396, 2093, 2169);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10396, 2031, 2180);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10396, 2031, 2180);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static RootSingleNamespaceDeclaration()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10396, 343, 2187);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10396, 343, 2187);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10396, 343, 2187);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10396, 343, 2187);

        static Microsoft.CodeAnalysis.SourceLocation
        f_10396_1097_1125(Microsoft.CodeAnalysis.SyntaxReference
        syntaxRef)
        {
            var return_v = new Microsoft.CodeAnalysis.SourceLocation(syntaxRef);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10396, 1097, 1125);
            return return_v;
        }


        bool
        f_10396_1271_1301_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10396, 1271, 1301);
            return return_v;
        }


        int
        f_10396_1258_1302(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10396, 1258, 1302);
            return 0;
        }


        static string
        f_10396_1019_1031_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10396, 674, 1522);
            return return_v;
        }

    }
}
