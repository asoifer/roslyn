// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class SingleNamespaceDeclaration : SingleNamespaceOrTypeDeclaration
    {
        private readonly ImmutableArray<SingleNamespaceOrTypeDeclaration> _children;

        protected SingleNamespaceDeclaration(
                    string name,
                    SyntaxReference syntaxReference,
                    SourceLocation nameLocation,
                    ImmutableArray<SingleNamespaceOrTypeDeclaration> children,
                    ImmutableArray<Diagnostic> diagnostics)
        : base(f_10397_794_798_C(name), syntaxReference, nameLocation, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10397, 497, 900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10397, 868, 889);

                _children = children;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10397, 497, 900);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10397, 497, 900);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10397, 497, 900);
            }
        }

        public override DeclarationKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10397, 973, 1057);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10397, 1009, 1042);

                    return DeclarationKind.Namespace;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10397, 973, 1057);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10397, 912, 1068);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10397, 912, 1068);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ImmutableArray<SingleNamespaceOrTypeDeclaration> GetNamespaceOrTypeDeclarationChildren()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10397, 1080, 1240);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10397, 1212, 1229);

                return _children;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10397, 1080, 1240);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10397, 1080, 1240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10397, 1080, 1240);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual bool HasUsings
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10397, 1306, 1370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10397, 1342, 1355);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10397, 1306, 1370);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10397, 1252, 1381);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10397, 1252, 1381);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual bool HasExternAliases
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10397, 1454, 1518);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10397, 1490, 1503);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10397, 1454, 1518);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10397, 1393, 1529);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10397, 1393, 1529);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static SingleNamespaceDeclaration Create(
                    string name,
                    bool hasUsings,
                    bool hasExternAliases,
                    SyntaxReference syntaxReference,
                    SourceLocation nameLocation,
                    ImmutableArray<SingleNamespaceOrTypeDeclaration> children,
                    ImmutableArray<Diagnostic> diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10397, 1541, 2579);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10397, 2147, 2568) || true) && (!hasUsings && (DynAbs.Tracing.TraceSender.Expression_True(10397, 2151, 2182) && !hasExternAliases))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10397, 2147, 2568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10397, 2216, 2336);

                    return f_10397_2223_2335(name, syntaxReference, nameLocation, children, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10397, 2147, 2568);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10397, 2147, 2568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10397, 2402, 2553);

                    return f_10397_2409_2552(name, hasUsings, hasExternAliases, syntaxReference, nameLocation, children, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10397, 2147, 2568);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10397, 1541, 2579);

                Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration
                f_10397_2223_2335(string
                name, Microsoft.CodeAnalysis.SyntaxReference
                syntaxReference, Microsoft.CodeAnalysis.SourceLocation
                nameLocation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                children, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration(name, syntaxReference, nameLocation, children, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10397, 2223, 2335);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclarationEx
                f_10397_2409_2552(string
                name, bool
                hasUsings, bool
                hasExternAliases, Microsoft.CodeAnalysis.SyntaxReference
                syntaxReference, Microsoft.CodeAnalysis.SourceLocation
                nameLocation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                children, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclarationEx(name, hasUsings, hasExternAliases, syntaxReference, nameLocation, children, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10397, 2409, 2552);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10397, 1541, 2579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10397, 1541, 2579);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SingleNamespaceDeclaration()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10397, 316, 2586);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10397, 316, 2586);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10397, 316, 2586);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10397, 316, 2586);

        static string
        f_10397_794_798_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10397, 497, 900);
            return return_v;
        }

    }
}
