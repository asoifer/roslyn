// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
    public abstract class SemanticModel
    {
        public abstract string Language { get; }

        public Compilation Compilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 2317, 2348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 2323, 2346);

                    return f_162_2330_2345();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(162, 2317, 2348);

                    Microsoft.CodeAnalysis.Compilation
                    f_162_2330_2345()
                    {
                        var return_v = CompilationCore;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(162, 2330, 2345);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 2262, 2359);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 2262, 2359);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract Compilation CompilationCore { get; }

        public SyntaxTree SyntaxTree
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 2703, 2733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 2709, 2731);

                    return f_162_2716_2730();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(162, 2703, 2733);

                    Microsoft.CodeAnalysis.SyntaxTree
                    f_162_2716_2730()
                    {
                        var return_v = SyntaxTreeCore;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(162, 2716, 2730);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 2650, 2744);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 2650, 2744);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract SyntaxTree SyntaxTreeCore { get; }

        public IOperation? GetOperation(SyntaxNode node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 3263, 3818);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 3438, 3487);

                    return f_162_3445_3486(this, node, cancellationToken);
                }
                catch (Exception e) when (f_162_3542_3584(e))
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(162, 3516, 3779);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 3723, 3764);

                    f_162_3723_3763(false, "\n" + f_162_3750_3762(e));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(162, 3516, 3779);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 3795, 3807);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(162, 3263, 3818);

                Microsoft.CodeAnalysis.IOperation?
                f_162_3445_3486(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetOperationCore(node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 3445, 3486);
                    return return_v;
                }


                bool
                f_162_3542_3584(System.Exception
                exception)
                {
                    var return_v = FatalError.ReportAndCatchUnlessCanceled(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 3542, 3584);
                    return return_v;
                }


                string
                f_162_3750_3762(System.Exception
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 3750, 3762);
                    return return_v;
                }


                int
                f_162_3723_3763(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 3723, 3763);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 3263, 3818);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 3263, 3818);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract IOperation? GetOperationCore(SyntaxNode node, CancellationToken cancellationToken);

        public virtual bool IgnoresAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 4177, 4198);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 4183, 4196);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(162, 4177, 4198);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 4112, 4209);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 4112, 4209);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SymbolInfo GetSymbolInfo(SyntaxNode node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 4573, 4775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 4714, 4764);

                return f_162_4721_4763(this, node, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(162, 4573, 4775);

                Microsoft.CodeAnalysis.SymbolInfo
                f_162_4721_4763(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetSymbolInfoCore(node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 4721, 4763);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 4573, 4775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 4573, 4775);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract SymbolInfo GetSymbolInfoCore(SyntaxNode node, CancellationToken cancellationToken = default(CancellationToken));

        internal SymbolInfo GetSpeculativeSymbolInfo(int position, SyntaxNode expression, SpeculativeBindingOption bindingOption)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 6675, 6905);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 6821, 6894);

                return f_162_6828_6893(this, position, expression, bindingOption);
                DynAbs.Tracing.TraceSender.TraceExitMethod(162, 6675, 6905);

                Microsoft.CodeAnalysis.SymbolInfo
                f_162_6828_6893(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.SyntaxNode
                expression, Microsoft.CodeAnalysis.SpeculativeBindingOption
                bindingOption)
                {
                    var return_v = this_param.GetSpeculativeSymbolInfoCore(position, expression, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 6828, 6893);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 6675, 6905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 6675, 6905);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract SymbolInfo GetSpeculativeSymbolInfoCore(int position, SyntaxNode expression, SpeculativeBindingOption bindingOption);

        internal TypeInfo GetSpeculativeTypeInfo(int position, SyntaxNode expression, SpeculativeBindingOption bindingOption)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 9851, 10075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 9993, 10064);

                return f_162_10000_10063(this, position, expression, bindingOption);
                DynAbs.Tracing.TraceSender.TraceExitMethod(162, 9851, 10075);

                Microsoft.CodeAnalysis.TypeInfo
                f_162_10000_10063(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.SyntaxNode
                expression, Microsoft.CodeAnalysis.SpeculativeBindingOption
                bindingOption)
                {
                    var return_v = this_param.GetSpeculativeTypeInfoCore(position, expression, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 10000, 10063);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 9851, 10075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 9851, 10075);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract TypeInfo GetSpeculativeTypeInfoCore(int position, SyntaxNode expression, SpeculativeBindingOption bindingOption);

        internal TypeInfo GetTypeInfo(SyntaxNode node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 11974, 12170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 12111, 12159);

                return f_162_12118_12158(this, node, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(162, 11974, 12170);

                Microsoft.CodeAnalysis.TypeInfo
                f_162_12118_12158(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetTypeInfoCore(node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 12118, 12158);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 11974, 12170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 11974, 12170);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract TypeInfo GetTypeInfoCore(SyntaxNode node, CancellationToken cancellationToken = default(CancellationToken));

        internal IAliasSymbol? GetAliasInfo(SyntaxNode nameSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 13090, 13305);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 13239, 13294);

                return f_162_13246_13293(this, nameSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(162, 13090, 13305);

                Microsoft.CodeAnalysis.IAliasSymbol?
                f_162_13246_13293(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                nameSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAliasInfoCore(nameSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 13246, 13293);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 13090, 13305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 13090, 13305);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract IAliasSymbol? GetAliasInfoCore(SyntaxNode nameSyntax, CancellationToken cancellationToken = default(CancellationToken));

        [MemberNotNullWhen(true, nameof(ParentModel))]
        public abstract bool IsSpeculativeSemanticModel
        {
            get;
        }

        public abstract int OriginalPositionForSpeculation
        {
            get;
        }

        public SemanticModel? ParentModel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 14768, 14804);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 14774, 14802);

                    return f_162_14781_14801(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(162, 14768, 14804);

                    Microsoft.CodeAnalysis.SemanticModel?
                    f_162_14781_14801(Microsoft.CodeAnalysis.SemanticModel
                    this_param)
                    {
                        var return_v = this_param.ParentModelCore;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(162, 14781, 14801);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 14710, 14815);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 14710, 14815);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract SemanticModel? ParentModelCore
        {
            get;
        }

        internal abstract SemanticModel ContainingModelOrSelf
        {
            get;
        }

        internal IAliasSymbol? GetSpeculativeAliasInfo(int position, SyntaxNode nameSyntax, SpeculativeBindingOption bindingOption)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 16651, 16882);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 16799, 16871);

                return f_162_16806_16870(this, position, nameSyntax, bindingOption);
                DynAbs.Tracing.TraceSender.TraceExitMethod(162, 16651, 16882);

                Microsoft.CodeAnalysis.IAliasSymbol?
                f_162_16806_16870(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.SyntaxNode
                nameSyntax, Microsoft.CodeAnalysis.SpeculativeBindingOption
                bindingOption)
                {
                    var return_v = this_param.GetSpeculativeAliasInfoCore(position, nameSyntax, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 16806, 16870);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 16651, 16882);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 16651, 16882);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract IAliasSymbol? GetSpeculativeAliasInfoCore(int position, SyntaxNode nameSyntax, SpeculativeBindingOption bindingOption);

        public abstract ImmutableArray<Diagnostic> GetSyntaxDiagnostics(TextSpan? span = null, CancellationToken cancellationToken = default(CancellationToken));

        public abstract ImmutableArray<Diagnostic> GetDeclarationDiagnostics(TextSpan? span = null, CancellationToken cancellationToken = default(CancellationToken));

        public abstract ImmutableArray<Diagnostic> GetMethodBodyDiagnostics(TextSpan? span = null, CancellationToken cancellationToken = default(CancellationToken));

        public abstract ImmutableArray<Diagnostic> GetDiagnostics(TextSpan? span = null, CancellationToken cancellationToken = default(CancellationToken));

        internal ISymbol? GetDeclaredSymbolForNode(SyntaxNode declaration, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 22932, 23161);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 23089, 23150);

                return f_162_23096_23149(this, declaration, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(162, 22932, 23161);

                Microsoft.CodeAnalysis.ISymbol?
                f_162_23096_23149(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                declaration, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDeclaredSymbolCore(declaration, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 23096, 23149);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 22932, 23161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 22932, 23161);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract ISymbol? GetDeclaredSymbolCore(SyntaxNode declaration, CancellationToken cancellationToken = default(CancellationToken));

        internal ImmutableArray<ISymbol> GetDeclaredSymbolsForNode(SyntaxNode declaration, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 24885, 25131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 25058, 25120);

                return f_162_25065_25119(this, declaration, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(162, 24885, 25131);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_162_25065_25119(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                declaration, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDeclaredSymbolsCore(declaration, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 25065, 25119);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 24885, 25131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 24885, 25131);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract ImmutableArray<ISymbol> GetDeclaredSymbolsCore(SyntaxNode declaration, CancellationToken cancellationToken = default(CancellationToken));

        public ImmutableArray<ISymbol> LookupSymbols(
                    int position,
                    INamespaceOrTypeSymbol? container = null,
                    string? name = null,
                    bool includeReducedExtensionMethods = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 27711, 28050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 27955, 28039);

                return f_162_27962_28038(this, position, container, name, includeReducedExtensionMethods);
                DynAbs.Tracing.TraceSender.TraceExitMethod(162, 27711, 28050);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_162_27962_28038(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.INamespaceOrTypeSymbol?
                container, string?
                name, bool
                includeReducedExtensionMethods)
                {
                    var return_v = this_param.LookupSymbolsCore(position, container, name, includeReducedExtensionMethods);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 27962, 28038);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 27711, 28050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 27711, 28050);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract ImmutableArray<ISymbol> LookupSymbolsCore(
                    int position,
                    INamespaceOrTypeSymbol? container,
                    string? name,
                    bool includeReducedExtensionMethods);

        public ImmutableArray<ISymbol> LookupBaseMembers(
                    int position,
                    string? name = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 30147, 30338);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 30282, 30327);

                return f_162_30289_30326(this, position, name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(162, 30147, 30338);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_162_30289_30326(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, string?
                name)
                {
                    var return_v = this_param.LookupBaseMembersCore(position, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 30289, 30326);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 30147, 30338);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 30147, 30338);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract ImmutableArray<ISymbol> LookupBaseMembersCore(
                    int position,
                    string? name);

        public ImmutableArray<ISymbol> LookupStaticMembers(
                    int position,
                    INamespaceOrTypeSymbol? container = null,
                    string? name = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 32005, 32266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 32197, 32255);

                return f_162_32204_32254(this, position, container, name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(162, 32005, 32266);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_162_32204_32254(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.INamespaceOrTypeSymbol?
                container, string?
                name)
                {
                    var return_v = this_param.LookupStaticMembersCore(position, container, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 32204, 32254);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 32005, 32266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 32005, 32266);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract ImmutableArray<ISymbol> LookupStaticMembersCore(
                    int position,
                    INamespaceOrTypeSymbol? container,
                    string? name);

        public ImmutableArray<ISymbol> LookupNamespacesAndTypes(
                    int position,
                    INamespaceOrTypeSymbol? container = null,
                    string? name = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 33839, 34110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 34036, 34099);

                return f_162_34043_34098(this, position, container, name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(162, 33839, 34110);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_162_34043_34098(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.INamespaceOrTypeSymbol?
                container, string?
                name)
                {
                    var return_v = this_param.LookupNamespacesAndTypesCore(position, container, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 34043, 34098);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 33839, 34110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 33839, 34110);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract ImmutableArray<ISymbol> LookupNamespacesAndTypesCore(
                    int position,
                    INamespaceOrTypeSymbol? container,
                    string? name);

        public ImmutableArray<ISymbol> LookupLabels(
                    int position,
                    string? name = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 35410, 35591);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 35540, 35580);

                return f_162_35547_35579(this, position, name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(162, 35410, 35591);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_162_35547_35579(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, string?
                name)
                {
                    var return_v = this_param.LookupLabelsCore(position, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 35547, 35579);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 35410, 35591);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 35410, 35591);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract ImmutableArray<ISymbol> LookupLabelsCore(
                    int position,
                    string? name);

        internal ControlFlowAnalysis AnalyzeControlFlow(SyntaxNode firstStatement, SyntaxNode lastStatement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 36512, 36709);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 36637, 36698);

                return f_162_36644_36697(this, firstStatement, lastStatement);
                DynAbs.Tracing.TraceSender.TraceExitMethod(162, 36512, 36709);

                Microsoft.CodeAnalysis.ControlFlowAnalysis
                f_162_36644_36697(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                firstStatement, Microsoft.CodeAnalysis.SyntaxNode
                lastStatement)
                {
                    var return_v = this_param.AnalyzeControlFlowCore(firstStatement, lastStatement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 36644, 36697);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 36512, 36709);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 36512, 36709);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract ControlFlowAnalysis AnalyzeControlFlowCore(SyntaxNode firstStatement, SyntaxNode lastStatement);

        internal ControlFlowAnalysis AnalyzeControlFlow(SyntaxNode statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 38048, 38194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 38142, 38183);

                return f_162_38149_38182(this, statement);
                DynAbs.Tracing.TraceSender.TraceExitMethod(162, 38048, 38194);

                Microsoft.CodeAnalysis.ControlFlowAnalysis
                f_162_38149_38182(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                statement)
                {
                    var return_v = this_param.AnalyzeControlFlowCore(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 38149, 38182);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 38048, 38194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 38048, 38194);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract ControlFlowAnalysis AnalyzeControlFlowCore(SyntaxNode statement);

        internal DataFlowAnalysis AnalyzeDataFlow(SyntaxNode firstStatement, SyntaxNode lastStatement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 39496, 39684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 39615, 39673);

                return f_162_39622_39672(this, firstStatement, lastStatement);
                DynAbs.Tracing.TraceSender.TraceExitMethod(162, 39496, 39684);

                Microsoft.CodeAnalysis.DataFlowAnalysis
                f_162_39622_39672(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                firstStatement, Microsoft.CodeAnalysis.SyntaxNode
                lastStatement)
                {
                    var return_v = this_param.AnalyzeDataFlowCore(firstStatement, lastStatement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 39622, 39672);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 39496, 39684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 39496, 39684);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract DataFlowAnalysis AnalyzeDataFlowCore(SyntaxNode firstStatement, SyntaxNode lastStatement);

        internal DataFlowAnalysis AnalyzeDataFlow(SyntaxNode statementOrExpression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 41090, 41251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 41190, 41240);

                return f_162_41197_41239(this, statementOrExpression);
                DynAbs.Tracing.TraceSender.TraceExitMethod(162, 41090, 41251);

                Microsoft.CodeAnalysis.DataFlowAnalysis
                f_162_41197_41239(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                statementOrExpression)
                {
                    var return_v = this_param.AnalyzeDataFlowCore(statementOrExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 41197, 41239);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 41090, 41251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 41090, 41251);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract DataFlowAnalysis AnalyzeDataFlowCore(SyntaxNode statementOrExpression);

        public Optional<object?> GetConstantValue(SyntaxNode node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 42304, 42517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 42453, 42506);

                return f_162_42460_42505(this, node, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(162, 42304, 42517);

                Microsoft.CodeAnalysis.Optional<object?>
                f_162_42460_42505(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetConstantValueCore(node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 42460, 42505);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 42304, 42517);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 42304, 42517);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract Optional<object?> GetConstantValueCore(SyntaxNode node, CancellationToken cancellationToken = default(CancellationToken));

        internal ImmutableArray<ISymbol> GetMemberGroup(SyntaxNode node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 43346, 43563);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 43501, 43552);

                return f_162_43508_43551(this, node, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(162, 43346, 43563);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_162_43508_43551(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetMemberGroupCore(node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 43508, 43551);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 43346, 43563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 43346, 43563);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract ImmutableArray<ISymbol> GetMemberGroupCore(SyntaxNode node, CancellationToken cancellationToken = default(CancellationToken));

        public ISymbol? GetEnclosingSymbol(int position, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 44271, 44480);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 44410, 44469);

                return f_162_44417_44468(this, position, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(162, 44271, 44480);

                Microsoft.CodeAnalysis.ISymbol?
                f_162_44417_44468(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetEnclosingSymbolCore(position, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 44417, 44468);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 44271, 44480);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 44271, 44480);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract ISymbol? GetEnclosingSymbolCore(int position, CancellationToken cancellationToken = default(CancellationToken));

        public bool IsAccessible(int position, ISymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 45749, 45881);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 45828, 45870);

                return f_162_45835_45869(this, position, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(162, 45749, 45881);

                bool
                f_162_45835_45869(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = this_param.IsAccessibleCore(position, symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 45835, 45869);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 45749, 45881);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 45749, 45881);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract bool IsAccessibleCore(int position, ISymbol symbol);

        public bool IsEventUsableAsField(int position, IEventSymbol eventSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 47165, 47328);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 47262, 47317);

                return f_162_47269_47316(this, position, eventSymbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(162, 47165, 47328);

                bool
                f_162_47269_47316(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.IEventSymbol
                eventSymbol)
                {
                    var return_v = this_param.IsEventUsableAsFieldCore(position, eventSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 47269, 47316);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 47165, 47328);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 47165, 47328);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract bool IsEventUsableAsFieldCore(int position, IEventSymbol eventSymbol);

        public PreprocessingSymbolInfo GetPreprocessingSymbolInfo(SyntaxNode nameSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 48029, 48195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 48134, 48184);

                return f_162_48141_48183(this, nameSyntax);
                DynAbs.Tracing.TraceSender.TraceExitMethod(162, 48029, 48195);

                Microsoft.CodeAnalysis.PreprocessingSymbolInfo
                f_162_48141_48183(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                nameSyntax)
                {
                    var return_v = this_param.GetPreprocessingSymbolInfoCore(nameSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(162, 48141, 48183);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 48029, 48195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 48029, 48195);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract PreprocessingSymbolInfo GetPreprocessingSymbolInfoCore(SyntaxNode nameSyntax);

        internal abstract void ComputeDeclarationsInSpan(TextSpan span, bool getSymbol, ArrayBuilder<DeclarationInfo> builder, CancellationToken cancellationToken);

        internal abstract void ComputeDeclarationsInNode(SyntaxNode node, ISymbol associatedSymbol, bool getSymbol, ArrayBuilder<DeclarationInfo> builder, CancellationToken cancellationToken, int? levelsToCompute = null);

        internal virtual Func<SyntaxNode, bool>? GetSyntaxNodesToAnalyzeFilter(SyntaxNode declaredNode, ISymbol declaredSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 49929, 49936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 49932, 49936);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(162, 49929, 49936);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 49929, 49936);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 49929, 49936);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal virtual SyntaxNode GetTopmostNodeForDiagnosticAnalysis(ISymbol symbol, SyntaxNode declaringSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 50144, 50320);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 50286, 50309);

                return declaringSyntax;
                DynAbs.Tracing.TraceSender.TraceExitMethod(162, 50144, 50320);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 50144, 50320);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 50144, 50320);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxNode Root
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(162, 50445, 50456);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(162, 50448, 50456);
                    return f_162_50448_50456(); DynAbs.Tracing.TraceSender.TraceExitMethod(162, 50445, 50456);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(162, 50445, 50456);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 50445, 50456);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract SyntaxNode RootCore { get; }

        public abstract NullableContext GetNullableContext(int position);

        public SemanticModel()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(162, 1941, 50895);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(162, 1941, 50895);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 1941, 50895);
        }


        static SemanticModel()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(162, 1941, 50895);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(162, 1941, 50895);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(162, 1941, 50895);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(162, 1941, 50895);

        Microsoft.CodeAnalysis.SyntaxNode
        f_162_50448_50456()
        {
            var return_v = RootCore;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(162, 50448, 50456);
            return return_v;
        }

    }
}
