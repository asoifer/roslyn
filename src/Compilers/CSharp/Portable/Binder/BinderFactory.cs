// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class BinderFactory
    {
        private struct BinderCacheKey : IEquatable<BinderCacheKey>
        {

            public readonly CSharpSyntaxNode syntaxNode;

            public readonly NodeUsage usage;

            public BinderCacheKey(CSharpSyntaxNode syntaxNode, NodeUsage usage)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10076, 853, 1034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 953, 982);

                    this.syntaxNode = syntaxNode;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 1000, 1019);

                    this.usage = usage;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10076, 853, 1034);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10076, 853, 1034);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10076, 853, 1034);
                }
            }

            bool IEquatable<BinderCacheKey>.Equals(BinderCacheKey other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10076, 1050, 1225);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 1143, 1210);

                    return syntaxNode == other.syntaxNode && (DynAbs.Tracing.TraceSender.Expression_True(10076, 1150, 1209) && this.usage == other.usage);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10076, 1050, 1225);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10076, 1050, 1225);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10076, 1050, 1225);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10076, 1241, 1380);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 1307, 1365);

                    return f_10076_1314_1364(f_10076_1327_1351(syntaxNode), usage);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10076, 1241, 1380);

                    int
                    f_10076_1327_1351(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 1327, 1351);
                        return return_v;
                    }


                    int
                    f_10076_1314_1364(int
                    newKey, Microsoft.CodeAnalysis.CSharp.BinderFactory.NodeUsage
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, (int)currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 1314, 1364);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10076, 1241, 1380);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10076, 1241, 1380);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(object obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10076, 1396, 1517);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 1468, 1502);

                    throw f_10076_1474_1501();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10076, 1396, 1517);

                    System.NotSupportedException
                    f_10076_1474_1501()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 1474, 1501);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10076, 1396, 1517);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10076, 1396, 1517);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static BinderCacheKey()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10076, 664, 1528);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10076, 664, 1528);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10076, 664, 1528);
            }
        }

        private readonly ConcurrentCache<BinderCacheKey, Binder> _binderCache;

        private readonly CSharpCompilation _compilation;

        private readonly SyntaxTree _syntaxTree;

        private readonly BuckStopsHereBinder _buckStopsHereBinder;

        private readonly bool _ignoreAccessibility;

        private readonly ObjectPool<BinderFactoryVisitor> _binderFactoryVisitorPool;

        internal BinderFactory(CSharpCompilation compilation, SyntaxTree syntaxTree, bool ignoreAccessibility)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10076, 2285, 3386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 1715, 1727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 1773, 1785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 1824, 1835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 1883, 1903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 1936, 1956);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 2247, 2272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 2412, 2439);

                _compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 2453, 2478);

                _syntaxTree = syntaxTree;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 2492, 2535);

                _ignoreAccessibility = ignoreAccessibility;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 2551, 2658);

                _binderFactoryVisitorPool = f_10076_2579_2657(() => new BinderFactoryVisitor(this), 64);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 3236, 3299);

                _binderCache = f_10076_3251_3298(50);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 3315, 3375);

                _buckStopsHereBinder = f_10076_3338_3374(compilation);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10076, 2285, 3386);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10076, 2285, 3386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10076, 2285, 3386);
            }
        }

        internal SyntaxTree SyntaxTree
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10076, 3453, 3523);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 3489, 3508);

                    return _syntaxTree;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10076, 3453, 3523);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10076, 3398, 3534);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10076, 3398, 3534);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool InScript
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10076, 3592, 3700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 3628, 3685);

                    return f_10076_3635_3659(f_10076_3635_3654(_syntaxTree)) == SourceCodeKind.Script;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10076, 3592, 3700);

                    Microsoft.CodeAnalysis.ParseOptions
                    f_10076_3635_3654(Microsoft.CodeAnalysis.SyntaxTree
                    this_param)
                    {
                        var return_v = this_param.Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10076, 3635, 3654);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SourceCodeKind
                    f_10076_3635_3659(Microsoft.CodeAnalysis.ParseOptions
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10076, 3635, 3659);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10076, 3546, 3711);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10076, 3546, 3711);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Binder GetBinder(SyntaxNode node, CSharpSyntaxNode memberDeclarationOpt = null, Symbol memberOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10076, 4411, 5059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 4549, 4579);

                int
                position = f_10076_4564_4578(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 4815, 4966) || true) && ((f_10076_4820_4829_M(!InScript) || (DynAbs.Tracing.TraceSender.Expression_False(10076, 4820, 4874) || f_10076_4833_4844(node) != SyntaxKind.CompilationUnit)) && (DynAbs.Tracing.TraceSender.Expression_True(10076, 4819, 4898) && f_10076_4879_4890(node) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10076, 4815, 4966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 4932, 4951);

                    node = f_10076_4939_4950(node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10076, 4815, 4966);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 4982, 5048);

                return f_10076_4989_5047(this, node, position, memberDeclarationOpt, memberOpt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10076, 4411, 5059);

                int
                f_10076_4564_4578(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10076, 4564, 4578);
                    return return_v;
                }


                bool
                f_10076_4820_4829_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10076, 4820, 4829);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10076_4833_4844(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 4833, 4844);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10076_4879_4890(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10076, 4879, 4890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10076_4939_4950(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10076, 4939, 4950);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10076_4989_5047(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, int
                position, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                memberDeclarationOpt, Microsoft.CodeAnalysis.CSharp.Symbol?
                memberOpt)
                {
                    var return_v = this_param.GetBinder(node, position, memberDeclarationOpt, memberOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 4989, 5047);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10076, 4411, 5059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10076, 4411, 5059);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Binder GetBinder(SyntaxNode node, int position, CSharpSyntaxNode memberDeclarationOpt = null, Symbol memberOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10076, 5071, 5759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 5223, 5250);

                f_10076_5223_5249(node != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 5277, 5448) || true) && (memberOpt is { ContainingSymbol: SourceMemberContainerTypeSymbol container })
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10076, 5277, 5448);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 5391, 5433);

                    f_10076_5391_5432(container, memberOpt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10076, 5277, 5448);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 5470, 5538);

                BinderFactoryVisitor
                visitor = f_10076_5501_5537(_binderFactoryVisitorPool)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 5552, 5614);

                f_10076_5552_5613(visitor, position, memberDeclarationOpt, memberOpt);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 5628, 5664);

                Binder
                result = f_10076_5644_5663(visitor, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 5678, 5718);

                f_10076_5678_5717(_binderFactoryVisitorPool, visitor);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 5734, 5748);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10076, 5071, 5759);

                int
                f_10076_5223_5249(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 5223, 5249);
                    return 0;
                }


                int
                f_10076_5391_5432(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    this_param.AssertMemberExposure(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 5391, 5432);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                f_10076_5501_5537(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 5501, 5537);
                    return return_v;
                }


                int
                f_10076_5552_5613(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                memberDeclarationOpt, Microsoft.CodeAnalysis.CSharp.Symbol?
                memberOpt)
                {
                    this_param.Initialize(position, memberDeclarationOpt, memberOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 5552, 5613);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10076_5644_5663(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 5644, 5663);
                    return return_v;
                }


                int
                f_10076_5678_5717(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor>
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 5678, 5717);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10076, 5071, 5759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10076, 5071, 5759);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal InMethodBinder GetRecordConstructorInMethodBinder(SynthesizedRecordConstructor constructor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10076, 5771, 6567);
                Microsoft.CodeAnalysis.CSharp.Binder resultBinder = default(Microsoft.CodeAnalysis.CSharp.Binder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 5896, 5955);

                RecordDeclarationSyntax
                typeDecl = f_10076_5931_5954(constructor)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 5971, 6026);

                var
                extraInfo = NodeUsage.ConstructorBodyOrInitializer
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 6040, 6113);

                var
                key = f_10076_6050_6112(typeDecl, extraInfo)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 6129, 6504) || true) && (!f_10076_6134_6188(_binderCache, key, out resultBinder))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10076, 6129, 6504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 6266, 6332);

                    f_10076_6266_6331(f_10076_6279_6296(constructor) == 0, "Generic Ctor, What to do?");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 6350, 6430);

                    resultBinder = f_10076_6365_6429(constructor, f_10076_6397_6428(this, typeDecl));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 6450, 6489);

                    f_10076_6450_6488(
                                    _binderCache, key, resultBinder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10076, 6129, 6504);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 6520, 6556);

                return (InMethodBinder)resultBinder;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10076, 5771, 6567);

                Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                f_10076_5931_5954(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 5931, 5954);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                f_10076_6050_6112(Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                node, Microsoft.CodeAnalysis.CSharp.BinderFactory.NodeUsage
                usage)
                {
                    var return_v = BinderFactoryVisitor.CreateBinderCacheKey((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, usage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 6050, 6112);
                    return return_v;
                }


                bool
                f_10076_6134_6188(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                key, out Microsoft.CodeAnalysis.CSharp.Binder
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 6134, 6188);
                    return return_v;
                }


                int
                f_10076_6279_6296(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10076, 6279, 6296);
                    return return_v;
                }


                int
                f_10076_6266_6331(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 6266, 6331);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10076_6397_6428(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                typeDecl)
                {
                    var return_v = this_param.GetInRecordBodyBinder(typeDecl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 6397, 6428);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.InMethodBinder
                f_10076_6365_6429(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
                owner, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.InMethodBinder((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)owner, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 6365, 6429);
                    return return_v;
                }


                bool
                f_10076_6450_6488(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                key, Microsoft.CodeAnalysis.CSharp.Binder
                value)
                {
                    var return_v = this_param.TryAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 6450, 6488);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10076, 5771, 6567);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10076, 5771, 6567);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Binder GetInRecordBodyBinder(RecordDeclarationSyntax typeDecl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10076, 6579, 7072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 6675, 6743);

                BinderFactoryVisitor
                visitor = f_10076_6706_6742(_binderFactoryVisitorPool)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 6757, 6851);

                f_10076_6757_6850(visitor, position: f_10076_6786_6804(typeDecl), memberDeclarationOpt: null, memberOpt: null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 6865, 6971);

                Binder
                resultBinder = f_10076_6887_6970(visitor, typeDecl, NodeUsage.NamedTypeBodyOrTypeParameters)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 6985, 7025);

                f_10076_6985_7024(_binderFactoryVisitorPool, visitor);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 7041, 7061);

                return resultBinder;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10076, 6579, 7072);

                Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                f_10076_6706_6742(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 6706, 6742);
                    return return_v;
                }


                int
                f_10076_6786_6804(Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10076, 6786, 6804);
                    return return_v;
                }


                int
                f_10076_6757_6850(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                memberDeclarationOpt, Microsoft.CodeAnalysis.CSharp.Symbol
                memberOpt)
                {
                    this_param.Initialize(position: position, memberDeclarationOpt: memberDeclarationOpt, memberOpt: memberOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 6757, 6850);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10076_6887_6970(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                parent, Microsoft.CodeAnalysis.CSharp.BinderFactory.NodeUsage
                extraInfo)
                {
                    var return_v = this_param.VisitTypeDeclarationCore((Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax)parent, extraInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 6887, 6970);
                    return return_v;
                }


                int
                f_10076_6985_7024(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor>
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 6985, 7024);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10076, 6579, 7072);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10076, 6579, 7072);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Binder GetImportsBinder(CSharpSyntaxNode unit, bool inUsing = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10076, 7524, 8834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 7626, 8823);

                switch (f_10076_7634_7645(unit))
                {

                    case SyntaxKind.NamespaceDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10076, 7626, 8823);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 7765, 7833);

                            BinderFactoryVisitor
                            visitor = f_10076_7796_7832(_binderFactoryVisitorPool)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 7859, 7893);

                            f_10076_7859_7892(visitor, 0, null, null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 7919, 8051);

                            Binder
                            result = f_10076_7935_8050(visitor, unit, f_10076_8003_8017(unit), inBody: true, inUsing: inUsing)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 8077, 8117);

                            f_10076_8077_8116(_binderFactoryVisitorPool, visitor);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 8143, 8157);

                            return result;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10076, 7626, 8823);

                    case SyntaxKind.CompilationUnit:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10076, 7626, 8823);
                        // imports are bound by the Script class binder:
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 8351, 8419);

                            BinderFactoryVisitor
                            visitor = f_10076_8382_8418(_binderFactoryVisitorPool)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 8445, 8479);

                            f_10076_8445_8478(visitor, 0, null, null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 8505, 8617);

                            Binder
                            result = f_10076_8521_8616(visitor, unit, inUsing: inUsing, inScript: f_10076_8607_8615())
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 8643, 8683);

                            f_10076_8643_8682(_binderFactoryVisitorPool, visitor);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 8709, 8723);

                            return result;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10076, 7626, 8823);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10076, 7626, 8823);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10076, 8796, 8808);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10076, 7626, 8823);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10076, 7524, 8834);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10076_7634_7645(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 7634, 7645);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                f_10076_7796_7832(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 7796, 7832);
                    return return_v;
                }


                int
                f_10076_7859_7892(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                memberDeclarationOpt, Microsoft.CodeAnalysis.CSharp.Symbol
                memberOpt)
                {
                    this_param.Initialize(position, memberDeclarationOpt, memberOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 7859, 7892);
                    return 0;
                }


                int
                f_10076_8003_8017(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10076, 8003, 8017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10076_7935_8050(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                parent, int
                position, bool
                inBody, bool
                inUsing)
                {
                    var return_v = this_param.VisitNamespaceDeclaration((Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax)parent, position, inBody: inBody, inUsing: inUsing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 7935, 8050);
                    return return_v;
                }


                int
                f_10076_8077_8116(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor>
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 8077, 8116);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                f_10076_8382_8418(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 8382, 8418);
                    return return_v;
                }


                int
                f_10076_8445_8478(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                memberDeclarationOpt, Microsoft.CodeAnalysis.CSharp.Symbol
                memberOpt)
                {
                    this_param.Initialize(position, memberDeclarationOpt, memberOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 8445, 8478);
                    return 0;
                }


                bool
                f_10076_8607_8615()
                {
                    var return_v = InScript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10076, 8607, 8615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10076_8521_8616(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                compilationUnit, bool
                inUsing, bool
                inScript)
                {
                    var return_v = this_param.VisitCompilationUnit((Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax)compilationUnit, inUsing: inUsing, inScript: inScript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 8521, 8616);
                    return return_v;
                }


                int
                f_10076_8643_8682(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor>
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 8643, 8682);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10076, 7524, 8834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10076, 7524, 8834);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor>
        f_10076_2579_2657(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor>.Factory
        factory, int
        size)
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor>(factory, size);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 2579, 2657);
            return return_v;
        }


        Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
        f_10076_3251_3298(int
        size)
        {
            var return_v = new Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>(size);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 3251, 3298);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.BuckStopsHereBinder
        f_10076_3338_3374(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.BuckStopsHereBinder(compilation);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10076, 3338, 3374);
            return return_v;
        }

    }
}
