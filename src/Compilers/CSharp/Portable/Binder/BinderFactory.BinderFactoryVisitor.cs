// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class BinderFactory
    {
        private sealed class BinderFactoryVisitor : CSharpSyntaxVisitor<Binder>
        {
            private int _position;

            private CSharpSyntaxNode _memberDeclarationOpt;

            private Symbol _memberOpt;

            private readonly BinderFactory _factory;

            internal BinderFactoryVisitor(BinderFactory factory)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10077, 879, 998);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 698, 707);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 747, 768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 798, 808);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 854, 862);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 964, 983);

                    _factory = factory;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10077, 879, 998);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 879, 998);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 879, 998);
                }
            }

            internal void Initialize(int position, CSharpSyntaxNode memberDeclarationOpt, Symbol memberOpt)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 1014, 1370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 1142, 1210);

                    f_10077_1142_1209((memberDeclarationOpt == null) == (memberOpt == null));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 1230, 1251);

                    _position = position;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 1269, 1314);

                    _memberDeclarationOpt = memberDeclarationOpt;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 1332, 1355);

                    _memberOpt = memberOpt;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 1014, 1370);

                    int
                    f_10077_1142_1209(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 1142, 1209);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 1014, 1370);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 1014, 1370);
                }
            }

            private CSharpCompilation compilation
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 1456, 1548);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 1500, 1529);

                        return _factory._compilation;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 1456, 1548);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 1386, 1563);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 1386, 1563);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private SyntaxTree syntaxTree
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 1641, 1732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 1685, 1713);

                        return _factory._syntaxTree;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 1641, 1732);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 1579, 1747);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 1579, 1747);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private BuckStopsHereBinder buckStopsHereBinder
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 1843, 1943);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 1887, 1924);

                        return _factory._buckStopsHereBinder;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 1843, 1943);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 1763, 1958);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 1763, 1958);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private ConcurrentCache<BinderCacheKey, Binder> binderCache
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 2066, 2158);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 2110, 2139);

                        return _factory._binderCache;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 2066, 2158);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 1974, 2173);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 1974, 2173);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 2243, 2331);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 2287, 2312);

                        return f_10077_2294_2311(_factory);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 2243, 2331);

                        bool
                        f_10077_2294_2311(Microsoft.CodeAnalysis.CSharp.BinderFactory
                        this_param)
                        {
                            var return_v = this_param.InScript;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 2294, 2311);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 2189, 2346);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 2189, 2346);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override Binder DefaultVisit(SyntaxNode parent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 2362, 2496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 2449, 2481);

                    return f_10077_2456_2480(this, f_10077_2466_2479(parent));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 2362, 2496);

                    Microsoft.CodeAnalysis.SyntaxNode?
                    f_10077_2466_2479(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 2466, 2479);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_2456_2480(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.SyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 2456, 2480);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 2362, 2496);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 2362, 2496);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Binder Visit(SyntaxNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 2664, 2780);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 2742, 2765);

                    return f_10077_2749_2764(this, node);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 2664, 2780);

                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_2749_2764(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    node)
                    {
                        var return_v = this_param.VisitCore(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 2749, 2764);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 2664, 2780);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 2664, 2780);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private Binder VisitCore(SyntaxNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 2852, 2986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 2926, 2971);

                    return f_10077_2933_2970(((CSharpSyntaxNode)node), this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 2852, 2986);

                    Microsoft.CodeAnalysis.CSharp.Binder?
                    f_10077_2933_2970(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    visitor)
                    {
                        var return_v = this_param.Accept<Microsoft.CodeAnalysis.CSharp.Binder>((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor<Microsoft.CodeAnalysis.CSharp.Binder>)visitor);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 2933, 2970);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 2852, 2986);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 2852, 2986);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Binder VisitGlobalStatement(GlobalStatementSyntax node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 3002, 4326);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 3106, 4252) || true) && (f_10077_3110_3160(node))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 3106, 4252);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 3202, 3259);

                        var
                        compilationUnit = (CompilationUnitSyntax)f_10077_3247_3258(node)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 3283, 3476) || true) && (compilationUnit != f_10077_3306_3326(f_10077_3306_3316()))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 3283, 3476);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 3376, 3453);

                            throw f_10077_3382_3452(nameof(node), "node not part of tree");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 3283, 3476);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 3500, 3570);

                        var
                        key = f_10077_3510_3569(compilationUnit, NodeUsage.MethodBody)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 3594, 3608);

                        Binder
                        result
                        = default(Binder);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 3630, 4195) || true) && (!f_10077_3635_3675(f_10077_3635_3646(), key, out result))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 3630, 4195);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 3725, 3920);

                            SynthesizedSimpleProgramEntryPointSymbol
                            simpleProgram = f_10077_3782_3919(f_10077_3838_3849(), f_10077_3874_3885(node), fallbackToMainEntryPoint: false)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 3946, 4039);

                            ExecutableCodeBinder
                            bodyBinder = f_10077_3980_4038(simpleProgram, _factory._ignoreAccessibility)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 4065, 4112);

                            result = f_10077_4074_4111(bodyBinder, compilationUnit);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 4140, 4172);

                            f_10077_4140_4171(f_10077_4140_4151(), key, result);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 3630, 4195);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 4219, 4233);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 3106, 4252);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 4272, 4311);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitGlobalStatement(node), 10077, 4279, 4310);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 3002, 4326);

                    bool
                    f_10077_3110_3160(Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax
                    syntax)
                    {
                        var return_v = SyntaxFacts.IsSimpleProgramTopLevelStatement(syntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 3110, 3160);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_3247_3258(Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 3247, 3258);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10077_3306_3316()
                    {
                        var return_v = syntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 3306, 3316);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode
                    f_10077_3306_3326(Microsoft.CodeAnalysis.SyntaxTree
                    this_param)
                    {
                        var return_v = this_param.GetRoot();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 3306, 3326);
                        return return_v;
                    }


                    System.ArgumentOutOfRangeException
                    f_10077_3382_3452(string
                    paramName, string
                    message)
                    {
                        var return_v = new System.ArgumentOutOfRangeException(paramName, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 3382, 3452);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    f_10077_3510_3569(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                    node, Microsoft.CodeAnalysis.CSharp.BinderFactory.NodeUsage
                    usage)
                    {
                        var return_v = CreateBinderCacheKey((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, usage);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 3510, 3569);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_3635_3646()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 3635, 3646);
                        return return_v;
                    }


                    bool
                    f_10077_3635_3675(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, out Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 3635, 3675);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10077_3838_3849()
                    {
                        var return_v = compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 3838, 3849);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_3874_3885(Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 3874, 3885);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol?
                    f_10077_3782_3919(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    compilationUnit, bool
                    fallbackToMainEntryPoint)
                    {
                        var return_v = SimpleProgramNamedTypeSymbol.GetSimpleProgramEntryPoint(compilation, (Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax?)compilationUnit, fallbackToMainEntryPoint: fallbackToMainEntryPoint);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 3782, 3919);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                    f_10077_3980_4038(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol?
                    this_param, bool
                    ignoreAccessibility)
                    {
                        var return_v = this_param.GetBodyBinder(ignoreAccessibility);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 3980, 4038);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_4074_4111(Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                    node)
                    {
                        var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 4074, 4111);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_4140_4151()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 4140, 4151);
                        return return_v;
                    }


                    bool
                    f_10077_4140_4171(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryAdd(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 4140, 4171);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 3002, 4326);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 3002, 4326);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Binder VisitMethodDeclaration(MethodDeclarationSyntax methodDecl)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 4591, 7075);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 4705, 4866) || true) && (!f_10077_4710_4769(_position, methodDecl))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 4705, 4866);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 4811, 4847);

                        return f_10077_4818_4846(this, f_10077_4828_4845(methodDecl));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 4705, 4866);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 4886, 4902);

                    NodeUsage
                    usage
                    = default(NodeUsage);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 4920, 5555) || true) && (f_10077_4924_4970(_position, methodDecl))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 4920, 5555);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 5012, 5041);

                        usage = NodeUsage.MethodBody;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 4920, 5555);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 4920, 5555);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 5083, 5555) || true) && (f_10077_5087_5153(_position, methodDecl))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 5083, 5555);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 5195, 5234);

                            usage = NodeUsage.MethodTypeParameters;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 5083, 5555);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 5083, 5555);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 5511, 5536);

                            usage = NodeUsage.Normal;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 5083, 5555);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 4920, 5555);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 5575, 5625);

                    var
                    key = f_10077_5585_5624(methodDecl, usage)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 5645, 5665);

                    Binder
                    resultBinder
                    = default(Binder);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 5683, 7020) || true) && (!f_10077_5688_5734(f_10077_5688_5699(), key, out resultBinder))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 5683, 7020);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 5776, 5836);

                        var
                        parentType = f_10077_5793_5810(methodDecl) as TypeDeclarationSyntax
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 5858, 6188) || true) && (parentType != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 5858, 6188);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 5930, 6023);

                            resultBinder = f_10077_5945_6022(this, parentType, NodeUsage.NamedTypeBodyOrTypeParameters);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 5858, 6188);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 5858, 6188);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 6121, 6165);

                            resultBinder = f_10077_6136_6164(this, f_10077_6146_6163(methodDecl));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 5858, 6188);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 6212, 6251);

                        SourceMemberMethodSymbol
                        method = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 6275, 6566) || true) && (usage != NodeUsage.Normal && (DynAbs.Tracing.TraceSender.Expression_True(10077, 6279, 6344) && f_10077_6308_6336(methodDecl) != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 6275, 6566);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 6394, 6445);

                            method = f_10077_6403_6444(this, methodDecl, resultBinder);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 6471, 6543);

                            resultBinder = f_10077_6486_6542(method, resultBinder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 6275, 6566);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 6590, 6839) || true) && (usage == NodeUsage.MethodBody)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 6590, 6839);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 6673, 6734);

                            method = method ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol?>(10077, 6682, 6733) ?? f_10077_6692_6733(this, methodDecl, resultBinder));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 6760, 6816);

                            resultBinder = f_10077_6775_6815(method, resultBinder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 6590, 6839);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 6863, 6941);

                        resultBinder = f_10077_6878_6940(resultBinder, f_10077_6919_6939(methodDecl));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 6963, 7001);

                        f_10077_6963_7000(f_10077_6963_6974(), key, resultBinder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 5683, 7020);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 7040, 7060);

                    return resultBinder;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 4591, 7075);

                    bool
                    f_10077_4710_4769(int
                    position, Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                    methodDecl)
                    {
                        var return_v = LookupPosition.IsInMethodDeclaration(position, (Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)methodDecl);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 4710, 4769);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_4828_4845(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 4828, 4845);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_4818_4846(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 4818, 4846);
                        return return_v;
                    }


                    bool
                    f_10077_4924_4970(int
                    position, Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                    method)
                    {
                        var return_v = LookupPosition.IsInBody(position, (Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 4924, 4970);
                        return return_v;
                    }


                    bool
                    f_10077_5087_5153(int
                    position, Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                    methodDecl)
                    {
                        var return_v = LookupPosition.IsInMethodTypeParameterScope(position, methodDecl);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 5087, 5153);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    f_10077_5585_5624(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                    node, Microsoft.CodeAnalysis.CSharp.BinderFactory.NodeUsage
                    usage)
                    {
                        var return_v = CreateBinderCacheKey((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, usage);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 5585, 5624);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_5688_5699()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 5688, 5699);
                        return return_v;
                    }


                    bool
                    f_10077_5688_5734(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, out Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 5688, 5734);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_5793_5810(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 5793, 5810);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_5945_6022(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                    parent, Microsoft.CodeAnalysis.CSharp.BinderFactory.NodeUsage
                    extraInfo)
                    {
                        var return_v = this_param.VisitTypeDeclarationCore(parent, extraInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 5945, 6022);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_6146_6163(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 6146, 6163);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_6136_6164(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 6136, 6164);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
                    f_10077_6308_6336(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.TypeParameterList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 6308, 6336);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                    f_10077_6403_6444(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                    baseMethodDeclarationSyntax, Microsoft.CodeAnalysis.CSharp.Binder
                    outerBinder)
                    {
                        var return_v = this_param.GetMethodSymbol((Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)baseMethodDeclarationSyntax, outerBinder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 6403, 6444);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.WithMethodTypeParametersBinder
                    f_10077_6486_6542(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                    methodSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                    next)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.WithMethodTypeParametersBinder((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)methodSymbol, next);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 6486, 6542);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                    f_10077_6692_6733(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                    baseMethodDeclarationSyntax, Microsoft.CodeAnalysis.CSharp.Binder
                    outerBinder)
                    {
                        var return_v = this_param.GetMethodSymbol((Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)baseMethodDeclarationSyntax, outerBinder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 6692, 6733);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.InMethodBinder
                    f_10077_6775_6815(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                    owner, Microsoft.CodeAnalysis.CSharp.Binder
                    enclosing)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.InMethodBinder((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)owner, enclosing);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 6775, 6815);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTokenList
                    f_10077_6919_6939(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Modifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 6919, 6939);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_6878_6940(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.SyntaxTokenList
                    modifiers)
                    {
                        var return_v = this_param.WithUnsafeRegionIfNecessary(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 6878, 6940);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_6963_6974()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 6963, 6974);
                        return return_v;
                    }


                    bool
                    f_10077_6963_7000(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryAdd(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 6963, 7000);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 4591, 7075);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 4591, 7075);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Binder VisitConstructorDeclaration(ConstructorDeclarationSyntax parent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 7091, 8956);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 7321, 7474) || true) && (!f_10077_7326_7381(_position, parent))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 7321, 7474);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 7423, 7455);

                        return f_10077_7430_7454(this, f_10077_7440_7453(parent));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 7321, 7474);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 7494, 7585);

                    bool
                    inBodyOrInitializer = f_10077_7521_7584(_position, parent)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 7603, 7699);

                    var
                    extraInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10077, 7619, 7638) || ((inBodyOrInitializer && DynAbs.Tracing.TraceSender.Conditional_F2(10077, 7641, 7679)) || DynAbs.Tracing.TraceSender.Conditional_F3(10077, 7682, 7698))) ? NodeUsage.ConstructorBodyOrInitializer : NodeUsage.Normal
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 7747, 7797);

                    var
                    key = f_10077_7757_7796(parent, extraInfo)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 7817, 7837);

                    Binder
                    resultBinder
                    = default(Binder);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 7855, 8901) || true) && (!f_10077_7860_7906(f_10077_7860_7871(), key, out resultBinder))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 7855, 8901);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 7948, 7988);

                        resultBinder = f_10077_7963_7987(this, f_10077_7973_7986(parent));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 8100, 8722) || true) && (inBodyOrInitializer)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 8100, 8722);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 8173, 8224);

                            var
                            method = f_10077_8186_8223(this, parent, resultBinder)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 8250, 8699) || true) && ((object)method != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 8250, 8699);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 8523, 8584);

                                f_10077_8523_8583(f_10077_8536_8548(method) == 0, "Generic Ctor, What to do?");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 8616, 8672);

                                resultBinder = f_10077_8631_8671(method, resultBinder);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 8250, 8699);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 8100, 8722);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 8746, 8820);

                        resultBinder = f_10077_8761_8819(resultBinder, f_10077_8802_8818(parent));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 8844, 8882);

                        f_10077_8844_8881(f_10077_8844_8855(), key, resultBinder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 7855, 8901);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 8921, 8941);

                    return resultBinder;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 7091, 8956);

                    bool
                    f_10077_7326_7381(int
                    position, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                    methodDecl)
                    {
                        var return_v = LookupPosition.IsInMethodDeclaration(position, (Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)methodDecl);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 7326, 7381);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_7440_7453(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 7440, 7453);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_7430_7454(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 7430, 7454);
                        return return_v;
                    }


                    bool
                    f_10077_7521_7584(int
                    position, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                    constructorDecl)
                    {
                        var return_v = LookupPosition.IsInConstructorParameterScope(position, constructorDecl);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 7521, 7584);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    f_10077_7757_7796(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                    node, Microsoft.CodeAnalysis.CSharp.BinderFactory.NodeUsage
                    usage)
                    {
                        var return_v = CreateBinderCacheKey((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, usage);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 7757, 7796);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_7860_7871()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 7860, 7871);
                        return return_v;
                    }


                    bool
                    f_10077_7860_7906(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, out Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 7860, 7906);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_7973_7986(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 7973, 7986);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_7963_7987(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 7963, 7987);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                    f_10077_8186_8223(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                    baseMethodDeclarationSyntax, Microsoft.CodeAnalysis.CSharp.Binder
                    outerBinder)
                    {
                        var return_v = this_param.GetMethodSymbol((Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)baseMethodDeclarationSyntax, outerBinder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 8186, 8223);
                        return return_v;
                    }


                    int
                    f_10077_8536_8548(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 8536, 8548);
                        return return_v;
                    }


                    int
                    f_10077_8523_8583(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 8523, 8583);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.InMethodBinder
                    f_10077_8631_8671(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                    owner, Microsoft.CodeAnalysis.CSharp.Binder
                    enclosing)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.InMethodBinder((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)owner, enclosing);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 8631, 8671);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTokenList
                    f_10077_8802_8818(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Modifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 8802, 8818);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_8761_8819(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.SyntaxTokenList
                    modifiers)
                    {
                        var return_v = this_param.WithUnsafeRegionIfNecessary(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 8761, 8819);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_8844_8855()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 8844, 8855);
                        return return_v;
                    }


                    bool
                    f_10077_8844_8881(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryAdd(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 8844, 8881);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 7091, 8956);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 7091, 8956);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Binder VisitDestructorDeclaration(DestructorDeclarationSyntax parent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 8972, 10156);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 9200, 9353) || true) && (!f_10077_9205_9260(_position, parent))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 9200, 9353);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 9302, 9334);

                        return f_10077_9309_9333(this, f_10077_9319_9332(parent));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 9200, 9353);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 9373, 9437);

                    var
                    key = f_10077_9383_9436(parent, usage: NodeUsage.Normal)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 9457, 9477);

                    Binder
                    resultBinder
                    = default(Binder);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 9495, 10101) || true) && (!f_10077_9500_9546(f_10077_9500_9511(), key, out resultBinder))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 9495, 10101);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 9708, 9748);

                        resultBinder = f_10077_9723_9747(this, f_10077_9733_9746(parent));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 9772, 9844);

                        SourceMemberMethodSymbol
                        method = f_10077_9806_9843(this, parent, resultBinder)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 9866, 9922);

                        resultBinder = f_10077_9881_9921(method, resultBinder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 9946, 10020);

                        resultBinder = f_10077_9961_10019(resultBinder, f_10077_10002_10018(parent));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 10044, 10082);

                        f_10077_10044_10081(f_10077_10044_10055(), key, resultBinder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 9495, 10101);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 10121, 10141);

                    return resultBinder;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 8972, 10156);

                    bool
                    f_10077_9205_9260(int
                    position, Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
                    methodDecl)
                    {
                        var return_v = LookupPosition.IsInMethodDeclaration(position, (Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)methodDecl);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 9205, 9260);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_9319_9332(Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 9319, 9332);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_9309_9333(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 9309, 9333);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    f_10077_9383_9436(Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
                    node, Microsoft.CodeAnalysis.CSharp.BinderFactory.NodeUsage
                    usage)
                    {
                        var return_v = CreateBinderCacheKey((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, usage: usage);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 9383, 9436);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_9500_9511()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 9500, 9511);
                        return return_v;
                    }


                    bool
                    f_10077_9500_9546(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, out Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 9500, 9546);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_9733_9746(Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 9733, 9746);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_9723_9747(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 9723, 9747);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                    f_10077_9806_9843(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
                    baseMethodDeclarationSyntax, Microsoft.CodeAnalysis.CSharp.Binder
                    outerBinder)
                    {
                        var return_v = this_param.GetMethodSymbol((Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)baseMethodDeclarationSyntax, outerBinder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 9806, 9843);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.InMethodBinder
                    f_10077_9881_9921(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                    owner, Microsoft.CodeAnalysis.CSharp.Binder
                    enclosing)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.InMethodBinder((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)owner, enclosing);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 9881, 9921);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTokenList
                    f_10077_10002_10018(Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Modifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 10002, 10018);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_9961_10019(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.SyntaxTokenList
                    modifiers)
                    {
                        var return_v = this_param.WithUnsafeRegionIfNecessary(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 9961, 10019);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_10044_10055()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 10044, 10055);
                        return return_v;
                    }


                    bool
                    f_10077_10044_10081(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryAdd(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 10044, 10081);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 8972, 10156);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 8972, 10156);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Binder VisitAccessorDeclaration(AccessorDeclarationSyntax parent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 10172, 13386);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 10396, 10549) || true) && (!f_10077_10401_10456(_position, parent))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 10396, 10549);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 10498, 10530);

                        return f_10077_10505_10529(this, f_10077_10515_10528(parent));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 10396, 10549);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 10569, 10626);

                    bool
                    inBody = f_10077_10583_10625(_position, parent)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 10644, 10711);

                    var
                    extraInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10077, 10660, 10666) || ((inBody && DynAbs.Tracing.TraceSender.Conditional_F2(10077, 10669, 10691)) || DynAbs.Tracing.TraceSender.Conditional_F3(10077, 10694, 10710))) ? NodeUsage.AccessorBody : NodeUsage.Normal
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 10759, 10809);

                    var
                    key = f_10077_10769_10808(parent, extraInfo)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 10829, 10849);

                    Binder
                    resultBinder
                    = default(Binder);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 10867, 13331) || true) && (!f_10077_10872_10918(f_10077_10872_10883(), key, out resultBinder))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 10867, 13331);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 10960, 11000);

                        resultBinder = f_10077_10975_10999(this, f_10077_10985_10998(parent));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 11024, 13250) || true) && (inBody)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 11024, 13250);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 11084, 11131);

                            var
                            propertyOrEventDecl = f_10077_11110_11130(f_10077_11110_11123(parent))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 11157, 11186);

                            MethodSymbol
                            accessor = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 11214, 13028);

                            switch (f_10077_11222_11248(propertyOrEventDecl))
                            {

                                case SyntaxKind.PropertyDeclaration:
                                case SyntaxKind.IndexerDeclaration:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 11214, 13028);
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 11480, 11585);

                                        var
                                        propertySymbol = f_10077_11501_11584(this, propertyOrEventDecl, resultBinder)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 11623, 11896) || true) && ((object)propertySymbol != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 11623, 11896);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 11739, 11857);

                                            accessor = (DynAbs.Tracing.TraceSender.Conditional_F1(10077, 11750, 11802) || (((f_10077_11751_11764(parent) == SyntaxKind.GetAccessorDeclaration) && DynAbs.Tracing.TraceSender.Conditional_F2(10077, 11805, 11829)) || DynAbs.Tracing.TraceSender.Conditional_F3(10077, 11832, 11856))) ? f_10077_11805_11829(propertySymbol) : f_10077_11832_11856(propertySymbol);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 11623, 11896);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(10077, 11934, 11940);

                                        break;
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 11214, 13028);

                                case SyntaxKind.EventDeclaration:
                                case SyntaxKind.EventFieldDeclaration:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 11214, 13028);
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 12384, 12476);

                                        var
                                        eventSymbol = f_10077_12402_12475(this, propertyOrEventDecl, resultBinder)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 12514, 12781) || true) && ((object)eventSymbol != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 12514, 12781);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 12627, 12742);

                                            accessor = (DynAbs.Tracing.TraceSender.Conditional_F1(10077, 12638, 12690) || (((f_10077_12639_12652(parent) == SyntaxKind.AddAccessorDeclaration) && DynAbs.Tracing.TraceSender.Conditional_F2(10077, 12693, 12714)) || DynAbs.Tracing.TraceSender.Conditional_F3(10077, 12717, 12741))) ? f_10077_12693_12714(eventSymbol) : f_10077_12717_12741(eventSymbol);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 12514, 12781);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(10077, 12819, 12825);

                                        break;
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 11214, 13028);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 11214, 13028);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 12932, 13001);

                                    throw f_10077_12938_13000(f_10077_12973_12999(propertyOrEventDecl));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 11214, 13028);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 13056, 13227) || true) && ((object)accessor != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 13056, 13227);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 13142, 13200);

                                resultBinder = f_10077_13157_13199(accessor, resultBinder);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 13056, 13227);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 11024, 13250);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 13274, 13312);

                        f_10077_13274_13311(f_10077_13274_13285(), key, resultBinder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 10867, 13331);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 13351, 13371);

                    return resultBinder;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 10172, 13386);

                    bool
                    f_10077_10401_10456(int
                    position, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                    accessorDecl)
                    {
                        var return_v = LookupPosition.IsInMethodDeclaration(position, accessorDecl);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 10401, 10456);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_10515_10528(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 10515, 10528);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_10505_10529(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 10505, 10529);
                        return return_v;
                    }


                    bool
                    f_10077_10583_10625(int
                    position, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                    method)
                    {
                        var return_v = LookupPosition.IsInBody(position, method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 10583, 10625);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    f_10077_10769_10808(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                    node, Microsoft.CodeAnalysis.CSharp.BinderFactory.NodeUsage
                    usage)
                    {
                        var return_v = CreateBinderCacheKey((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, usage);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 10769, 10808);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_10872_10883()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 10872, 10883);
                        return return_v;
                    }


                    bool
                    f_10077_10872_10918(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, out Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 10872, 10918);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_10985_10998(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 10985, 10998);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_10975_10999(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 10975, 10999);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_11110_11123(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 11110, 11123);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_11110_11130(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 11110, 11130);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10077_11222_11248(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 11222, 11248);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                    f_10077_11501_11584(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    basePropertyDeclarationSyntax, Microsoft.CodeAnalysis.CSharp.Binder
                    outerBinder)
                    {
                        var return_v = this_param.GetPropertySymbol((Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax)basePropertyDeclarationSyntax, outerBinder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 11501, 11584);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10077_11751_11764(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 11751, 11764);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10077_11805_11829(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                    this_param)
                    {
                        var return_v = this_param.GetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 11805, 11829);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10077_11832_11856(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                    this_param)
                    {
                        var return_v = this_param.SetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 11832, 11856);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                    f_10077_12402_12475(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    eventDeclarationSyntax, Microsoft.CodeAnalysis.CSharp.Binder
                    outerBinder)
                    {
                        var return_v = this_param.GetEventSymbol((Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax)eventDeclarationSyntax, outerBinder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 12402, 12475);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10077_12639_12652(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 12639, 12652);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10077_12693_12714(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                    this_param)
                    {
                        var return_v = this_param.AddMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 12693, 12714);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10077_12717_12741(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                    this_param)
                    {
                        var return_v = this_param.RemoveMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 12717, 12741);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10077_12973_12999(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 12973, 12999);
                        return return_v;
                    }


                    System.Exception
                    f_10077_12938_13000(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 12938, 13000);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.InMethodBinder
                    f_10077_13157_13199(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    owner, Microsoft.CodeAnalysis.CSharp.Binder
                    enclosing)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.InMethodBinder(owner, enclosing);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 13157, 13199);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_13274_13285()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 13274, 13285);
                        return return_v;
                    }


                    bool
                    f_10077_13274_13311(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryAdd(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 13274, 13311);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 10172, 13386);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 10172, 13386);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private Binder VisitOperatorOrConversionDeclaration(BaseMethodDeclarationSyntax parent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 13402, 14741);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 13632, 13785) || true) && (!f_10077_13637_13692(_position, parent))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 13632, 13785);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 13734, 13766);

                        return f_10077_13741_13765(this, f_10077_13751_13764(parent));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 13632, 13785);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 13805, 13862);

                    bool
                    inBody = f_10077_13819_13861(_position, parent)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 13880, 13947);

                    var
                    extraInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10077, 13896, 13902) || ((inBody && DynAbs.Tracing.TraceSender.Conditional_F2(10077, 13905, 13927)) || DynAbs.Tracing.TraceSender.Conditional_F3(10077, 13930, 13946))) ? NodeUsage.OperatorBody : NodeUsage.Normal
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 13995, 14045);

                    var
                    key = f_10077_14005_14044(parent, extraInfo)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 14065, 14085);

                    Binder
                    resultBinder
                    = default(Binder);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 14103, 14686) || true) && (!f_10077_14108_14154(f_10077_14108_14119(), key, out resultBinder))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 14103, 14686);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 14196, 14236);

                        resultBinder = f_10077_14211_14235(this, f_10077_14221_14234(parent));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 14260, 14320);

                        MethodSymbol
                        method = f_10077_14282_14319(this, parent, resultBinder)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 14342, 14507) || true) && ((object)method != null && (DynAbs.Tracing.TraceSender.Expression_True(10077, 14346, 14378) && inBody))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 14342, 14507);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 14428, 14484);

                            resultBinder = f_10077_14443_14483(method, resultBinder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 14342, 14507);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 14531, 14605);

                        resultBinder = f_10077_14546_14604(resultBinder, f_10077_14587_14603(parent));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 14629, 14667);

                        f_10077_14629_14666(f_10077_14629_14640(), key, resultBinder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 14103, 14686);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 14706, 14726);

                    return resultBinder;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 13402, 14741);

                    bool
                    f_10077_13637_13692(int
                    position, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                    methodDecl)
                    {
                        var return_v = LookupPosition.IsInMethodDeclaration(position, methodDecl);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 13637, 13692);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_13751_13764(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 13751, 13764);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_13741_13765(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 13741, 13765);
                        return return_v;
                    }


                    bool
                    f_10077_13819_13861(int
                    position, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                    method)
                    {
                        var return_v = LookupPosition.IsInBody(position, method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 13819, 13861);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    f_10077_14005_14044(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                    node, Microsoft.CodeAnalysis.CSharp.BinderFactory.NodeUsage
                    usage)
                    {
                        var return_v = CreateBinderCacheKey((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, usage);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 14005, 14044);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_14108_14119()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 14108, 14119);
                        return return_v;
                    }


                    bool
                    f_10077_14108_14154(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, out Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 14108, 14154);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_14221_14234(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 14221, 14234);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_14211_14235(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 14211, 14235);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                    f_10077_14282_14319(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                    baseMethodDeclarationSyntax, Microsoft.CodeAnalysis.CSharp.Binder
                    outerBinder)
                    {
                        var return_v = this_param.GetMethodSymbol(baseMethodDeclarationSyntax, outerBinder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 14282, 14319);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.InMethodBinder
                    f_10077_14443_14483(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    owner, Microsoft.CodeAnalysis.CSharp.Binder
                    enclosing)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.InMethodBinder(owner, enclosing);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 14443, 14483);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTokenList
                    f_10077_14587_14603(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Modifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 14587, 14603);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_14546_14604(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.SyntaxTokenList
                    modifiers)
                    {
                        var return_v = this_param.WithUnsafeRegionIfNecessary(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 14546, 14604);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_14629_14640()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 14629, 14640);
                        return return_v;
                    }


                    bool
                    f_10077_14629_14666(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryAdd(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 14629, 14666);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 13402, 14741);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 13402, 14741);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Binder VisitOperatorDeclaration(OperatorDeclarationSyntax parent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 14757, 14938);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 14871, 14923);

                    return f_10077_14878_14922(this, parent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 14757, 14938);

                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_14878_14922(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
                    parent)
                    {
                        var return_v = this_param.VisitOperatorOrConversionDeclaration((Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)parent);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 14878, 14922);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 14757, 14938);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 14757, 14938);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Binder VisitConversionOperatorDeclaration(ConversionOperatorDeclarationSyntax parent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 14954, 15155);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 15088, 15140);

                    return f_10077_15095_15139(this, parent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 14954, 15155);

                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_15095_15139(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax
                    parent)
                    {
                        var return_v = this_param.VisitOperatorOrConversionDeclaration((Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)parent);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 15095, 15139);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 14954, 15155);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 14954, 15155);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Binder VisitFieldDeclaration(FieldDeclarationSyntax parent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 15171, 15372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 15279, 15357);

                    return f_10077_15286_15356(f_10077_15286_15310(this, f_10077_15296_15309(parent)), f_10077_15339_15355(parent));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 15171, 15372);

                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_15296_15309(Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 15296, 15309);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_15286_15310(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 15286, 15310);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTokenList
                    f_10077_15339_15355(Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Modifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 15339, 15355);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_15286_15356(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.SyntaxTokenList
                    modifiers)
                    {
                        var return_v = this_param.WithUnsafeRegionIfNecessary(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 15286, 15356);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 15171, 15372);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 15171, 15372);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Binder VisitEventDeclaration(EventDeclarationSyntax parent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 15388, 15589);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 15496, 15574);

                    return f_10077_15503_15573(f_10077_15503_15527(this, f_10077_15513_15526(parent)), f_10077_15556_15572(parent));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 15388, 15589);

                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_15513_15526(Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 15513, 15526);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_15503_15527(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 15503, 15527);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTokenList
                    f_10077_15556_15572(Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Modifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 15556, 15572);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_15503_15573(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.SyntaxTokenList
                    modifiers)
                    {
                        var return_v = this_param.WithUnsafeRegionIfNecessary(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 15503, 15573);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 15388, 15589);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 15388, 15589);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Binder VisitEventFieldDeclaration(EventFieldDeclarationSyntax parent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 15605, 15816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 15723, 15801);

                    return f_10077_15730_15800(f_10077_15730_15754(this, f_10077_15740_15753(parent)), f_10077_15783_15799(parent));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 15605, 15816);

                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_15740_15753(Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 15740, 15753);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_15730_15754(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 15730, 15754);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTokenList
                    f_10077_15783_15799(Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Modifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 15783, 15799);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_15730_15800(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.SyntaxTokenList
                    modifiers)
                    {
                        var return_v = this_param.WithUnsafeRegionIfNecessary(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 15730, 15800);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 15605, 15816);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 15605, 15816);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Binder VisitPropertyDeclaration(PropertyDeclarationSyntax parent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 15832, 16219);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 15946, 16132) || true) && (!f_10077_15951_15993(_position, parent))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 15946, 16132);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 16035, 16113);

                        return f_10077_16042_16112(f_10077_16042_16066(this, f_10077_16052_16065(parent)), f_10077_16095_16111(parent));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 15946, 16132);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 16152, 16204);

                    return f_10077_16159_16203(this, parent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 15832, 16219);

                    bool
                    f_10077_15951_15993(int
                    position, Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                    property)
                    {
                        var return_v = LookupPosition.IsInBody(position, property);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 15951, 15993);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_16052_16065(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 16052, 16065);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_16042_16066(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 16042, 16066);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTokenList
                    f_10077_16095_16111(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Modifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 16095, 16111);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_16042_16112(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.SyntaxTokenList
                    modifiers)
                    {
                        var return_v = this_param.WithUnsafeRegionIfNecessary(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 16042, 16112);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_16159_16203(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                    parent)
                    {
                        var return_v = this_param.VisitPropertyOrIndexerExpressionBody((Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax)parent);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 16159, 16203);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 15832, 16219);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 15832, 16219);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Binder VisitIndexerDeclaration(IndexerDeclarationSyntax parent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 16235, 16620);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 16347, 16533) || true) && (!f_10077_16352_16394(_position, parent))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 16347, 16533);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 16436, 16514);

                        return f_10077_16443_16513(f_10077_16443_16467(this, f_10077_16453_16466(parent)), f_10077_16496_16512(parent));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 16347, 16533);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 16553, 16605);

                    return f_10077_16560_16604(this, parent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 16235, 16620);

                    bool
                    f_10077_16352_16394(int
                    position, Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax
                    indexer)
                    {
                        var return_v = LookupPosition.IsInBody(position, indexer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 16352, 16394);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_16453_16466(Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 16453, 16466);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_16443_16467(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 16443, 16467);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTokenList
                    f_10077_16496_16512(Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Modifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 16496, 16512);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_16443_16513(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.SyntaxTokenList
                    modifiers)
                    {
                        var return_v = this_param.WithUnsafeRegionIfNecessary(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 16443, 16513);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_16560_16604(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax
                    parent)
                    {
                        var return_v = this_param.VisitPropertyOrIndexerExpressionBody((Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax)parent);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 16560, 16604);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 16235, 16620);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 16235, 16620);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private Binder VisitPropertyOrIndexerExpressionBody(BasePropertyDeclarationSyntax parent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 16636, 17522);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 16758, 16821);

                    var
                    key = f_10077_16768_16820(parent, NodeUsage.AccessorBody)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 16841, 16861);

                    Binder
                    resultBinder
                    = default(Binder);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 16879, 17467) || true) && (!f_10077_16884_16930(f_10077_16884_16895(), key, out resultBinder))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 16879, 17467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 16972, 17058);

                        resultBinder = f_10077_16987_17057(f_10077_16987_17011(this, f_10077_16997_17010(parent)), f_10077_17040_17056(parent));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 17082, 17143);

                        var
                        propertySymbol = f_10077_17103_17142(this, parent, resultBinder)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 17165, 17205);

                        var
                        accessor = f_10077_17180_17204(propertySymbol)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 17227, 17386) || true) && ((object)accessor != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 17227, 17386);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 17305, 17363);

                            resultBinder = f_10077_17320_17362(accessor, resultBinder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 17227, 17386);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 17410, 17448);

                        f_10077_17410_17447(f_10077_17410_17421(), key, resultBinder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 16879, 17467);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 17487, 17507);

                    return resultBinder;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 16636, 17522);

                    Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    f_10077_16768_16820(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                    node, Microsoft.CodeAnalysis.CSharp.BinderFactory.NodeUsage
                    usage)
                    {
                        var return_v = CreateBinderCacheKey((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, usage);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 16768, 16820);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_16884_16895()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 16884, 16895);
                        return return_v;
                    }


                    bool
                    f_10077_16884_16930(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, out Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 16884, 16930);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_16997_17010(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 16997, 17010);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_16987_17011(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 16987, 17011);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTokenList
                    f_10077_17040_17056(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Modifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 17040, 17056);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_16987_17057(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.SyntaxTokenList
                    modifiers)
                    {
                        var return_v = this_param.WithUnsafeRegionIfNecessary(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 16987, 17057);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                    f_10077_17103_17142(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                    basePropertyDeclarationSyntax, Microsoft.CodeAnalysis.CSharp.Binder
                    outerBinder)
                    {
                        var return_v = this_param.GetPropertySymbol(basePropertyDeclarationSyntax, outerBinder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 17103, 17142);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10077_17180_17204(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                    this_param)
                    {
                        var return_v = this_param.GetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 17180, 17204);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.InMethodBinder
                    f_10077_17320_17362(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    owner, Microsoft.CodeAnalysis.CSharp.Binder
                    enclosing)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.InMethodBinder(owner, enclosing);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 17320, 17362);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_17410_17421()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 17410, 17421);
                        return return_v;
                    }


                    bool
                    f_10077_17410_17447(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryAdd(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 17410, 17447);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 16636, 17522);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 16636, 17522);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private NamedTypeSymbol GetContainerType(Binder binder, CSharpSyntaxNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 17538, 18382);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 17649, 17707);

                    Symbol
                    containingSymbol = f_10077_17675_17706(binder)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 17725, 17777);

                    var
                    container = containingSymbol as NamedTypeSymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 17795, 18330) || true) && ((object)container == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 17795, 18330);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 17866, 17916);

                        f_10077_17866_17915(containingSymbol is NamespaceSymbol);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 17938, 18311) || true) && (f_10077_17942_17960(f_10077_17942_17953(node)) == SyntaxKind.CompilationUnit && (DynAbs.Tracing.TraceSender.Expression_True(10077, 17942, 18043) && f_10077_17994_18017(f_10077_17994_18012(f_10077_17994_18004())) != SourceCodeKind.Regular))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 17938, 18311);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 18093, 18129);

                            container = f_10077_18105_18128(f_10077_18105_18116());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 17938, 18311);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 17938, 18311);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 18227, 18288);

                            container = f_10077_18239_18287(((NamespaceSymbol)containingSymbol));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 17938, 18311);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 17795, 18330);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 18350, 18367);

                    return container;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 17538, 18382);

                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10077_17675_17706(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.ContainingMemberOrLambda;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 17675, 17706);
                        return return_v;
                    }


                    int
                    f_10077_17866_17915(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 17866, 17915);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_17942_17953(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 17942, 17953);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10077_17942_17960(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 17942, 17960);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10077_17994_18004()
                    {
                        var return_v = syntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 17994, 18004);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ParseOptions
                    f_10077_17994_18012(Microsoft.CodeAnalysis.SyntaxTree
                    this_param)
                    {
                        var return_v = this_param.Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 17994, 18012);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SourceCodeKind
                    f_10077_17994_18017(Microsoft.CodeAnalysis.ParseOptions
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 17994, 18017);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10077_18105_18116()
                    {
                        var return_v = compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 18105, 18116);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    f_10077_18105_18128(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.ScriptClass;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 18105, 18128);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10077_18239_18287(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.ImplicitType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 18239, 18287);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 17538, 18382);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 17538, 18382);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static string GetMethodName(BaseMethodDeclarationSyntax baseMethodDeclarationSyntax, Binder outerBinder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10077, 18795, 20471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 18940, 20456);

                    switch (f_10077_18948_18982(baseMethodDeclarationSyntax))
                    {

                        case SyntaxKind.ConstructorDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 18940, 20456);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 19089, 19258);

                            return ((DynAbs.Tracing.TraceSender.Conditional_F1(10077, 19097, 19164) || ((baseMethodDeclarationSyntax.Modifiers.Any(SyntaxKind.StaticKeyword) && DynAbs.Tracing.TraceSender.Conditional_F2(10077, 19167, 19209)) || DynAbs.Tracing.TraceSender.Conditional_F3(10077, 19212, 19256))) ? WellKnownMemberNames.StaticConstructorName : WellKnownMemberNames.InstanceConstructorName);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 18940, 20456);

                        case SyntaxKind.DestructorDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 18940, 20456);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 19344, 19387);

                            return WellKnownMemberNames.DestructorName;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 18940, 20456);

                        case SyntaxKind.OperatorDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 18940, 20456);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 19471, 19576);

                            return f_10077_19478_19575(baseMethodDeclarationSyntax);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 18940, 20456);

                        case SyntaxKind.ConversionOperatorDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 18940, 20456);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 19670, 19957);

                            return (DynAbs.Tracing.TraceSender.Conditional_F1(10077, 19677, 19806) || ((((ConversionOperatorDeclarationSyntax)baseMethodDeclarationSyntax).ImplicitOrExplicitKeyword.Kind() == SyntaxKind.ImplicitKeyword
                            && DynAbs.Tracing.TraceSender.Conditional_F2(10077, 19838, 19881)) || DynAbs.Tracing.TraceSender.Conditional_F3(10077, 19913, 19956))) ? WellKnownMemberNames.ImplicitConversionName
                            : WellKnownMemberNames.ExplicitConversionName;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 18940, 20456);

                        case SyntaxKind.MethodDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 18940, 20456);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 20039, 20135);

                            MethodDeclarationSyntax
                            methodDeclSyntax = (MethodDeclarationSyntax)baseMethodDeclarationSyntax
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 20161, 20304);

                            return f_10077_20168_20303(outerBinder, f_10077_20220_20263(methodDeclSyntax), methodDeclSyntax.Identifier.ValueText);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 18940, 20456);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 18940, 20456);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 20360, 20437);

                            throw f_10077_20366_20436(f_10077_20401_20435(baseMethodDeclarationSyntax));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 18940, 20456);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10077, 18795, 20471);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10077_18948_18982(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 18948, 18982);
                        return return_v;
                    }


                    string
                    f_10077_19478_19575(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                    declaration)
                    {
                        var return_v = OperatorFacts.OperatorNameFromDeclaration((Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax)declaration);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 19478, 19575);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                    f_10077_20220_20263(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.ExplicitInterfaceSpecifier;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 20220, 20263);
                        return return_v;
                    }


                    string
                    f_10077_20168_20303(Microsoft.CodeAnalysis.CSharp.Binder
                    binder, Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                    explicitInterfaceSpecifierOpt, string
                    name)
                    {
                        var return_v = ExplicitInterfaceHelpers.GetMemberName(binder, explicitInterfaceSpecifierOpt, name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 20168, 20303);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10077_20401_20435(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 20401, 20435);
                        return return_v;
                    }


                    System.Exception
                    f_10077_20366_20436(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 20366, 20436);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 18795, 20471);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 18795, 20471);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static string GetPropertyOrEventName(BasePropertyDeclarationSyntax basePropertyDeclarationSyntax, Binder outerBinder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10077, 20857, 22275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 21015, 21140);

                    ExplicitInterfaceSpecifierSyntax
                    explicitInterfaceSpecifierSyntax = f_10077_21083_21139(basePropertyDeclarationSyntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 21160, 22260);

                    switch (f_10077_21168_21204(basePropertyDeclarationSyntax))
                    {

                        case SyntaxKind.PropertyDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 21160, 22260);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 21308, 21384);

                            var
                            propertyDecl = (PropertyDeclarationSyntax)basePropertyDeclarationSyntax
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 21410, 21538);

                            return f_10077_21417_21537(outerBinder, explicitInterfaceSpecifierSyntax, propertyDecl.Identifier.ValueText);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 21160, 22260);

                        case SyntaxKind.IndexerDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 21160, 22260);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 21621, 21744);

                            return f_10077_21628_21743(outerBinder, explicitInterfaceSpecifierSyntax, WellKnownMemberNames.Indexer);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 21160, 22260);

                        case SyntaxKind.EventDeclaration:
                        case SyntaxKind.EventFieldDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 21160, 22260);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 21885, 21955);

                            var
                            eventDecl = (EventDeclarationSyntax)basePropertyDeclarationSyntax
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 21981, 22106);

                            return f_10077_21988_22105(outerBinder, explicitInterfaceSpecifierSyntax, eventDecl.Identifier.ValueText);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 21160, 22260);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 21160, 22260);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 22162, 22241);

                            throw f_10077_22168_22240(f_10077_22203_22239(basePropertyDeclarationSyntax));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 21160, 22260);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10077, 20857, 22275);

                    Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                    f_10077_21083_21139(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.ExplicitInterfaceSpecifier;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 21083, 21139);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10077_21168_21204(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 21168, 21204);
                        return return_v;
                    }


                    string
                    f_10077_21417_21537(Microsoft.CodeAnalysis.CSharp.Binder
                    binder, Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                    explicitInterfaceSpecifierOpt, string
                    name)
                    {
                        var return_v = ExplicitInterfaceHelpers.GetMemberName(binder, explicitInterfaceSpecifierOpt, name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 21417, 21537);
                        return return_v;
                    }


                    string
                    f_10077_21628_21743(Microsoft.CodeAnalysis.CSharp.Binder
                    binder, Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                    explicitInterfaceSpecifierOpt, string
                    name)
                    {
                        var return_v = ExplicitInterfaceHelpers.GetMemberName(binder, explicitInterfaceSpecifierOpt, name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 21628, 21743);
                        return return_v;
                    }


                    string
                    f_10077_21988_22105(Microsoft.CodeAnalysis.CSharp.Binder
                    binder, Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                    explicitInterfaceSpecifierOpt, string
                    name)
                    {
                        var return_v = ExplicitInterfaceHelpers.GetMemberName(binder, explicitInterfaceSpecifierOpt, name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 21988, 22105);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10077_22203_22239(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 22203, 22239);
                        return return_v;
                    }


                    System.Exception
                    f_10077_22168_22240(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 22168, 22240);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 20857, 22275);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 20857, 22275);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private SourceMemberMethodSymbol GetMethodSymbol(BaseMethodDeclarationSyntax baseMethodDeclarationSyntax, Binder outerBinder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 22400, 23204);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 22558, 22719) || true) && (baseMethodDeclarationSyntax == _memberDeclarationOpt)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 22558, 22719);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 22656, 22700);

                        return (SourceMemberMethodSymbol)_memberOpt;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 22558, 22719);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 22739, 22826);

                    NamedTypeSymbol
                    container = f_10077_22767_22825(this, outerBinder, baseMethodDeclarationSyntax)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 22844, 22946) || true) && ((object)container == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 22844, 22946);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 22915, 22927);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 22844, 22946);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 22966, 23042);

                    string
                    methodName = f_10077_22986_23041(baseMethodDeclarationSyntax, outerBinder)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 23060, 23189);

                    return (SourceMemberMethodSymbol)f_10077_23093_23188(this, methodName, f_10077_23121_23157(baseMethodDeclarationSyntax), container, SymbolKind.Method);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 22400, 23204);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10077_22767_22825(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Binder
                    binder, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                    node)
                    {
                        var return_v = this_param.GetContainerType(binder, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 22767, 22825);
                        return return_v;
                    }


                    string
                    f_10077_22986_23041(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                    baseMethodDeclarationSyntax, Microsoft.CodeAnalysis.CSharp.Binder
                    outerBinder)
                    {
                        var return_v = GetMethodName(baseMethodDeclarationSyntax, outerBinder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 22986, 23041);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_10077_23121_23157(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.FullSpan;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 23121, 23157);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10077_23093_23188(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, string
                    memberName, Microsoft.CodeAnalysis.Text.TextSpan
                    memberSpan, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    container, Microsoft.CodeAnalysis.SymbolKind
                    kind)
                    {
                        var return_v = this_param.GetMemberSymbol(memberName, memberSpan, container, kind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 23093, 23188);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 22400, 23204);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 22400, 23204);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private SourcePropertySymbol GetPropertySymbol(BasePropertyDeclarationSyntax basePropertyDeclarationSyntax, Binder outerBinder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 23220, 24215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 23380, 23538);

                    f_10077_23380_23537(f_10077_23393_23429(basePropertyDeclarationSyntax) == SyntaxKind.PropertyDeclaration || (DynAbs.Tracing.TraceSender.Expression_False(10077, 23393, 23536) || f_10077_23467_23503(basePropertyDeclarationSyntax) == SyntaxKind.IndexerDeclaration));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 23558, 23717) || true) && (basePropertyDeclarationSyntax == _memberDeclarationOpt)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 23558, 23717);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 23658, 23698);

                        return (SourcePropertySymbol)_memberOpt;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 23558, 23717);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 23737, 23826);

                    NamedTypeSymbol
                    container = f_10077_23765_23825(this, outerBinder, basePropertyDeclarationSyntax)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 23844, 23946) || true) && ((object)container == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 23844, 23946);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 23915, 23927);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 23844, 23946);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 23966, 24055);

                    string
                    propertyName = f_10077_23988_24054(basePropertyDeclarationSyntax, outerBinder)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 24073, 24200);

                    return (SourcePropertySymbol)f_10077_24102_24199(this, propertyName, f_10077_24132_24166(basePropertyDeclarationSyntax), container, SymbolKind.Property);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 23220, 24215);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10077_23393_23429(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 23393, 23429);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10077_23467_23503(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 23467, 23503);
                        return return_v;
                    }


                    int
                    f_10077_23380_23537(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 23380, 23537);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10077_23765_23825(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Binder
                    binder, Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                    node)
                    {
                        var return_v = this_param.GetContainerType(binder, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 23765, 23825);
                        return return_v;
                    }


                    string
                    f_10077_23988_24054(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                    basePropertyDeclarationSyntax, Microsoft.CodeAnalysis.CSharp.Binder
                    outerBinder)
                    {
                        var return_v = GetPropertyOrEventName(basePropertyDeclarationSyntax, outerBinder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 23988, 24054);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_10077_24132_24166(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Span;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 24132, 24166);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10077_24102_24199(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, string
                    memberName, Microsoft.CodeAnalysis.Text.TextSpan
                    memberSpan, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    container, Microsoft.CodeAnalysis.SymbolKind
                    kind)
                    {
                        var return_v = this_param.GetMemberSymbol(memberName, memberSpan, container, kind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 24102, 24199);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 23220, 24215);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 23220, 24215);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private SourceEventSymbol GetEventSymbol(EventDeclarationSyntax eventDeclarationSyntax, Binder outerBinder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 24231, 24985);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 24371, 24520) || true) && (eventDeclarationSyntax == _memberDeclarationOpt)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 24371, 24520);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 24464, 24501);

                        return (SourceEventSymbol)_memberOpt;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 24371, 24520);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 24540, 24622);

                    NamedTypeSymbol
                    container = f_10077_24568_24621(this, outerBinder, eventDeclarationSyntax)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 24640, 24742) || true) && ((object)container == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 24640, 24742);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 24711, 24723);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 24640, 24742);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 24762, 24841);

                    string
                    eventName = f_10077_24781_24840(eventDeclarationSyntax, outerBinder)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 24859, 24970);

                    return (SourceEventSymbol)f_10077_24885_24969(this, eventName, f_10077_24912_24939(eventDeclarationSyntax), container, SymbolKind.Event);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 24231, 24985);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10077_24568_24621(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Binder
                    binder, Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
                    node)
                    {
                        var return_v = this_param.GetContainerType(binder, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 24568, 24621);
                        return return_v;
                    }


                    string
                    f_10077_24781_24840(Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
                    basePropertyDeclarationSyntax, Microsoft.CodeAnalysis.CSharp.Binder
                    outerBinder)
                    {
                        var return_v = GetPropertyOrEventName((Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax)basePropertyDeclarationSyntax, outerBinder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 24781, 24840);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_10077_24912_24939(Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Span;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 24912, 24939);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10077_24885_24969(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, string
                    memberName, Microsoft.CodeAnalysis.Text.TextSpan
                    memberSpan, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    container, Microsoft.CodeAnalysis.SymbolKind
                    kind)
                    {
                        var return_v = this_param.GetMemberSymbol(memberName, memberSpan, container, kind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 24885, 24969);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 24231, 24985);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 24231, 24985);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private Symbol GetMemberSymbol(string memberName, TextSpan memberSpan, NamedTypeSymbol container, SymbolKind kind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 25001, 26792);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 25361, 26745);
                        foreach (Symbol sym in f_10077_25384_25416_I(f_10077_25384_25416(container, memberName)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 25361, 26745);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 25458, 25560) || true) && (f_10077_25462_25470(sym) != kind)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 25458, 25560);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 25528, 25537);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 25458, 25560);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 25584, 26726) || true) && (f_10077_25588_25596(sym) == SymbolKind.Method)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 25584, 26726);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 25667, 25820) || true) && (f_10077_25671_25724(f_10077_25678_25691(sym)[0], f_10077_25696_25711(this), memberSpan))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 25667, 25820);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 25782, 25793);

                                    return sym;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 25667, 25820);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 26139, 26206);

                                var
                                implementation = f_10077_26160_26205(((MethodSymbol)sym))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 26232, 26538) || true) && ((object)implementation != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 26232, 26538);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 26324, 26511) || true) && (f_10077_26328_26392(f_10077_26335_26359(implementation)[0], f_10077_26364_26379(this), memberSpan))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 26324, 26511);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 26458, 26480);

                                        return implementation;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 26324, 26511);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 26232, 26538);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 25584, 26726);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 25584, 26726);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 26588, 26726) || true) && (f_10077_26592_26642(f_10077_26599_26612(sym), f_10077_26614_26629(this), memberSpan))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 26588, 26726);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 26692, 26703);

                                    return sym;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 26588, 26726);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 25584, 26726);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 25361, 26745);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10077, 1, 1385);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10077, 1, 1385);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 26765, 26777);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 25001, 26792);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10077_25384_25416(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetMembers(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 25384, 25416);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10077_25462_25470(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 25462, 25470);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10077_25588_25596(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 25588, 25596);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10077_25678_25691(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 25678, 25691);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10077_25696_25711(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param)
                    {
                        var return_v = this_param.syntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 25696, 25711);
                        return return_v;
                    }


                    bool
                    f_10077_25671_25724(Microsoft.CodeAnalysis.Location
                    location, Microsoft.CodeAnalysis.SyntaxTree
                    syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan
                    span)
                    {
                        var return_v = InSpan(location, syntaxTree, span);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 25671, 25724);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10077_26160_26205(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.PartialImplementationPart;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 26160, 26205);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10077_26335_26359(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 26335, 26359);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10077_26364_26379(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param)
                    {
                        var return_v = this_param.syntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 26364, 26379);
                        return return_v;
                    }


                    bool
                    f_10077_26328_26392(Microsoft.CodeAnalysis.Location
                    location, Microsoft.CodeAnalysis.SyntaxTree
                    syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan
                    span)
                    {
                        var return_v = InSpan(location, syntaxTree, span);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 26328, 26392);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10077_26599_26612(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 26599, 26612);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10077_26614_26629(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param)
                    {
                        var return_v = this_param.syntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 26614, 26629);
                        return return_v;
                    }


                    bool
                    f_10077_26592_26642(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    locations, Microsoft.CodeAnalysis.SyntaxTree
                    syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan
                    span)
                    {
                        var return_v = InSpan(locations, syntaxTree, span);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 26592, 26642);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10077_25384_25416_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 25384, 25416);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 25001, 26792);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 25001, 26792);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static bool InSpan(Location location, SyntaxTree syntaxTree, TextSpan span)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10077, 26945, 27208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 27061, 27094);

                    f_10077_27061_27093(syntaxTree != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 27112, 27193);

                    return (f_10077_27120_27139(location) == syntaxTree) && (DynAbs.Tracing.TraceSender.Expression_True(10077, 27119, 27192) && span.Contains(f_10077_27172_27191(location)));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10077, 26945, 27208);

                    int
                    f_10077_27061_27093(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 27061, 27093);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree?
                    f_10077_27120_27139(Microsoft.CodeAnalysis.Location
                    this_param)
                    {
                        var return_v = this_param.SourceTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 27120, 27139);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_10077_27172_27191(Microsoft.CodeAnalysis.Location
                    this_param)
                    {
                        var return_v = this_param.SourceSpan;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 27172, 27191);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 26945, 27208);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 26945, 27208);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static bool InSpan(ImmutableArray<Location> locations, SyntaxTree syntaxTree, TextSpan span)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10077, 27369, 27807);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 27502, 27535);

                    f_10077_27502_27534(syntaxTree != null);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 27553, 27761);
                        foreach (var loc in f_10077_27573_27582_I(locations))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 27553, 27761);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 27624, 27742) || true) && (f_10077_27628_27657(loc, syntaxTree, span))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 27624, 27742);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 27707, 27719);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 27624, 27742);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 27553, 27761);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10077, 1, 209);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10077, 1, 209);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 27779, 27792);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10077, 27369, 27807);

                    int
                    f_10077_27502_27534(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 27502, 27534);
                        return 0;
                    }


                    bool
                    f_10077_27628_27657(Microsoft.CodeAnalysis.Location
                    location, Microsoft.CodeAnalysis.SyntaxTree
                    syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan
                    span)
                    {
                        var return_v = InSpan(location, syntaxTree, span);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 27628, 27657);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10077_27573_27582_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 27573, 27582);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 27369, 27807);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 27369, 27807);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Binder VisitDelegateDeclaration(DelegateDeclarationSyntax parent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 27823, 29340);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 27937, 28092) || true) && (!f_10077_27942_27999(_position, parent))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 27937, 28092);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 28041, 28073);

                        return f_10077_28048_28072(this, f_10077_28058_28071(parent));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 27937, 28092);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 28112, 28176);

                    var
                    key = f_10077_28122_28175(parent, usage: NodeUsage.Normal)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 28196, 28216);

                    Binder
                    resultBinder
                    = default(Binder);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 28234, 29285) || true) && (!f_10077_28239_28285(f_10077_28239_28250(), key, out resultBinder))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 28234, 29285);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 28327, 28367);

                        Binder
                        outer = f_10077_28342_28366(this, f_10077_28352_28365(parent))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 28449, 28549);

                        var
                        container = f_10077_28465_28548(((NamespaceOrTypeSymbol)f_10077_28489_28519(outer)), parent)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 28844, 28899);

                        resultBinder = f_10077_28859_28898(container, outer);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 28923, 29106) || true) && (f_10077_28927_28951(parent) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 28923, 29106);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 29009, 29083);

                            resultBinder = f_10077_29024_29082(container, resultBinder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 28923, 29106);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 29130, 29204);

                        resultBinder = f_10077_29145_29203(resultBinder, f_10077_29186_29202(parent));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 29228, 29266);

                        f_10077_29228_29265(f_10077_29228_29239(), key, resultBinder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 28234, 29285);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 29305, 29325);

                    return resultBinder;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 27823, 29340);

                    bool
                    f_10077_27942_27999(int
                    position, Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                    delegateDecl)
                    {
                        var return_v = LookupPosition.IsInDelegateDeclaration(position, delegateDecl);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 27942, 27999);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_28058_28071(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 28058, 28071);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_28048_28072(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 28048, 28072);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    f_10077_28122_28175(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                    node, Microsoft.CodeAnalysis.CSharp.BinderFactory.NodeUsage
                    usage)
                    {
                        var return_v = CreateBinderCacheKey((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, usage: usage);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 28122, 28175);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_28239_28250()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 28239, 28250);
                        return return_v;
                    }


                    bool
                    f_10077_28239_28285(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, out Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 28239, 28285);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_28352_28365(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 28352, 28365);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_28342_28366(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 28342, 28366);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10077_28489_28519(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.ContainingMemberOrLambda;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 28489, 28519);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol?
                    f_10077_28465_28548(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                    syntax)
                    {
                        var return_v = this_param.GetSourceTypeMember(syntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 28465, 28548);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.InContainerBinder
                    f_10077_28859_28898(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol?
                    container, Microsoft.CodeAnalysis.CSharp.Binder
                    next)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.InContainerBinder((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?)container, next);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 28859, 28898);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
                    f_10077_28927_28951(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.TypeParameterList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 28927, 28951);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.WithClassTypeParametersBinder
                    f_10077_29024_29082(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol?
                    container, Microsoft.CodeAnalysis.CSharp.Binder
                    next)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.WithClassTypeParametersBinder((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?)container, next);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 29024, 29082);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTokenList
                    f_10077_29186_29202(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Modifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 29186, 29202);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_29145_29203(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.SyntaxTokenList
                    modifiers)
                    {
                        var return_v = this_param.WithUnsafeRegionIfNecessary(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 29145, 29203);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_29228_29239()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 29228, 29239);
                        return return_v;
                    }


                    bool
                    f_10077_29228_29265(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryAdd(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 29228, 29265);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 27823, 29340);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 27823, 29340);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Binder VisitEnumDeclaration(EnumDeclarationSyntax parent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 29356, 30755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 29603, 29806);

                    bool
                    inBody = f_10077_29617_29705(_position, f_10077_29659_29680(parent), f_10077_29682_29704(parent)) || (DynAbs.Tracing.TraceSender.Expression_False(10077, 29617, 29805) || f_10077_29730_29805(_position, f_10077_29783_29804(parent)))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 29824, 29928) || true) && (!inBody)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 29824, 29928);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 29877, 29909);

                        return f_10077_29884_29908(this, f_10077_29894_29907(parent));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 29824, 29928);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 29948, 30012);

                    var
                    key = f_10077_29958_30011(parent, usage: NodeUsage.Normal)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 30032, 30052);

                    Binder
                    resultBinder
                    = default(Binder);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 30070, 30700) || true) && (!f_10077_30075_30121(f_10077_30075_30086(), key, out resultBinder))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 30070, 30700);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 30163, 30203);

                        Binder
                        outer = f_10077_30178_30202(this, f_10077_30188_30201(parent))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 30282, 30442);

                        var
                        container = f_10077_30298_30441(((NamespaceOrTypeSymbol)f_10077_30322_30352(outer)), parent.Identifier.ValueText, 0, SyntaxKind.EnumDeclaration, parent)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 30466, 30521);

                        resultBinder = f_10077_30481_30520(container, outer);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 30545, 30619);

                        resultBinder = f_10077_30560_30618(resultBinder, f_10077_30601_30617(parent));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 30643, 30681);

                        f_10077_30643_30680(f_10077_30643_30654(), key, resultBinder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 30070, 30700);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 30720, 30740);

                    return resultBinder;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 29356, 30755);

                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10077_29659_29680(Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.OpenBraceToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 29659, 29680);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10077_29682_29704(Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.CloseBraceToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 29682, 29704);
                        return return_v;
                    }


                    bool
                    f_10077_29617_29705(int
                    position, Microsoft.CodeAnalysis.SyntaxToken
                    firstIncluded, Microsoft.CodeAnalysis.SyntaxToken
                    firstExcluded)
                    {
                        var return_v = LookupPosition.IsBetweenTokens(position, firstIncluded, firstExcluded);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 29617, 29705);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                    f_10077_29783_29804(Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.AttributeLists;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 29783, 29804);
                        return return_v;
                    }


                    bool
                    f_10077_29730_29805(int
                    position, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                    attributesSyntaxList)
                    {
                        var return_v = LookupPosition.IsInAttributeSpecification(position, attributesSyntaxList);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 29730, 29805);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_29894_29907(Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 29894, 29907);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_29884_29908(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 29884, 29908);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    f_10077_29958_30011(Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax
                    node, Microsoft.CodeAnalysis.CSharp.BinderFactory.NodeUsage
                    usage)
                    {
                        var return_v = CreateBinderCacheKey((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, usage: usage);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 29958, 30011);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_30075_30086()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 30075, 30086);
                        return return_v;
                    }


                    bool
                    f_10077_30075_30121(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, out Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 30075, 30121);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_30188_30201(Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 30188, 30201);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_30178_30202(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 30178, 30202);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10077_30322_30352(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.ContainingMemberOrLambda;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 30322, 30352);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol?
                    f_10077_30298_30441(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                    this_param, string
                    name, int
                    arity, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    kind, Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax
                    syntax)
                    {
                        var return_v = this_param.GetSourceTypeMember(name, arity, kind, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 30298, 30441);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.InContainerBinder
                    f_10077_30481_30520(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol?
                    container, Microsoft.CodeAnalysis.CSharp.Binder
                    next)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.InContainerBinder((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?)container, next);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 30481, 30520);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTokenList
                    f_10077_30601_30617(Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Modifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 30601, 30617);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_30560_30618(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.SyntaxTokenList
                    modifiers)
                    {
                        var return_v = this_param.WithUnsafeRegionIfNecessary(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 30560, 30618);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_30643_30654()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 30643, 30654);
                        return return_v;
                    }


                    bool
                    f_10077_30643_30680(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryAdd(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 30643, 30680);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 29356, 30755);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 29356, 30755);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private Binder VisitTypeDeclarationCore(TypeDeclarationSyntax parent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 30985, 32417);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 31087, 31238) || true) && (!f_10077_31092_31145(_position, parent))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 31087, 31238);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 31187, 31219);

                        return f_10077_31194_31218(this, f_10077_31204_31217(parent));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 31087, 31238);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 31258, 31297);

                    NodeUsage
                    extraInfo = NodeUsage.Normal
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 31490, 32331) || true) && (f_10077_31494_31515(parent) != default && (DynAbs.Tracing.TraceSender.Expression_True(10077, 31494, 31584) && f_10077_31551_31573(parent) != default) && (DynAbs.Tracing.TraceSender.Expression_True(10077, 31494, 31800) && (f_10077_31610_31698(_position, f_10077_31652_31673(parent), f_10077_31675_31697(parent)) || (DynAbs.Tracing.TraceSender.Expression_False(10077, 31610, 31799) || f_10077_31724_31799(_position, f_10077_31777_31798(parent))))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 31490, 32331);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 31842, 31894);

                        extraInfo = NodeUsage.NamedTypeBodyOrTypeParameters;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 31490, 32331);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 31490, 32331);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 31936, 32331) || true) && (f_10077_31940_31995(_position, parent))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 31936, 32331);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 32037, 32089);

                            extraInfo = NodeUsage.NamedTypeBodyOrTypeParameters;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 31936, 32331);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 31936, 32331);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 32131, 32331) || true) && (f_10077_32135_32215(_position, f_10077_32177_32191(parent), f_10077_32193_32214(parent)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 32131, 32331);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 32257, 32312);

                                extraInfo = NodeUsage.NamedTypeBaseListOrParameterList;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 32131, 32331);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 31936, 32331);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 31490, 32331);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 32351, 32402);

                    return f_10077_32358_32401(this, parent, extraInfo);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 30985, 32417);

                    bool
                    f_10077_31092_31145(int
                    position, Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                    typeDecl)
                    {
                        var return_v = LookupPosition.IsInTypeDeclaration(position, (Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax)typeDecl);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 31092, 31145);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_31204_31217(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 31204, 31217);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_31194_31218(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 31194, 31218);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10077_31494_31515(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.OpenBraceToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 31494, 31515);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10077_31551_31573(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.CloseBraceToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 31551, 31573);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10077_31652_31673(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.OpenBraceToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 31652, 31673);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10077_31675_31697(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.CloseBraceToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 31675, 31697);
                        return return_v;
                    }


                    bool
                    f_10077_31610_31698(int
                    position, Microsoft.CodeAnalysis.SyntaxToken
                    firstIncluded, Microsoft.CodeAnalysis.SyntaxToken
                    firstExcluded)
                    {
                        var return_v = LookupPosition.IsBetweenTokens(position, firstIncluded, firstExcluded);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 31610, 31698);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                    f_10077_31777_31798(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.AttributeLists;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 31777, 31798);
                        return return_v;
                    }


                    bool
                    f_10077_31724_31799(int
                    position, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                    attributesSyntaxList)
                    {
                        var return_v = LookupPosition.IsInAttributeSpecification(position, attributesSyntaxList);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 31724, 31799);
                        return return_v;
                    }


                    bool
                    f_10077_31940_31995(int
                    position, Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                    typeDecl)
                    {
                        var return_v = LookupPosition.IsInTypeParameterList(position, typeDecl);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 31940, 31995);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10077_32177_32191(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Keyword;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 32177, 32191);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10077_32193_32214(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.OpenBraceToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 32193, 32214);
                        return return_v;
                    }


                    bool
                    f_10077_32135_32215(int
                    position, Microsoft.CodeAnalysis.SyntaxToken
                    firstIncluded, Microsoft.CodeAnalysis.SyntaxToken
                    firstExcluded)
                    {
                        var return_v = LookupPosition.IsBetweenTokens(position, firstIncluded, firstExcluded);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 32135, 32215);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_32358_32401(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                    parent, Microsoft.CodeAnalysis.CSharp.BinderFactory.NodeUsage
                    extraInfo)
                    {
                        var return_v = this_param.VisitTypeDeclarationCore(parent, extraInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 32358, 32401);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 30985, 32417);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 30985, 32417);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal Binder VisitTypeDeclarationCore(TypeDeclarationSyntax parent, NodeUsage extraInfo)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 32433, 34556);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 32557, 32607);

                    var
                    key = f_10077_32567_32606(parent, extraInfo)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 32627, 32647);

                    Binder
                    resultBinder
                    = default(Binder);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 32665, 34501) || true) && (!f_10077_32670_32716(f_10077_32670_32681(), key, out resultBinder))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 32665, 34501);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 33226, 33266);

                        resultBinder = f_10077_33241_33265(this, f_10077_33251_33264(parent));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 33290, 34322) || true) && (extraInfo != NodeUsage.Normal)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 33290, 34322);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 33373, 33481);

                            var
                            typeSymbol = f_10077_33390_33480(((NamespaceOrTypeSymbol)f_10077_33414_33451(resultBinder)), parent)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 33509, 34299) || true) && (extraInfo == NodeUsage.NamedTypeBaseListOrParameterList)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 33509, 34299);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 33780, 33855);

                                resultBinder = f_10077_33795_33854(typeSymbol, resultBinder);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 33509, 34299);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 33509, 34299);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 33969, 34032);

                                resultBinder = f_10077_33984_34031(typeSymbol, resultBinder);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 34064, 34272) || true) && (f_10077_34068_34092(parent) != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 34064, 34272);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 34166, 34241);

                                    resultBinder = f_10077_34181_34240(typeSymbol, resultBinder);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 34064, 34272);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 33509, 34299);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 33290, 34322);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 34346, 34420);

                        resultBinder = f_10077_34361_34419(resultBinder, f_10077_34402_34418(parent));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 34444, 34482);

                        f_10077_34444_34481(f_10077_34444_34455(), key, resultBinder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 32665, 34501);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 34521, 34541);

                    return resultBinder;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 32433, 34556);

                    Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    f_10077_32567_32606(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                    node, Microsoft.CodeAnalysis.CSharp.BinderFactory.NodeUsage
                    usage)
                    {
                        var return_v = CreateBinderCacheKey((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, usage);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 32567, 32606);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_32670_32681()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 32670, 32681);
                        return return_v;
                    }


                    bool
                    f_10077_32670_32716(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, out Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 32670, 32716);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_33251_33264(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 33251, 33264);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_33241_33265(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 33241, 33265);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10077_33414_33451(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.ContainingMemberOrLambda;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 33414, 33451);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol?
                    f_10077_33390_33480(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                    syntax)
                    {
                        var return_v = this_param.GetSourceTypeMember(syntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 33390, 33480);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.WithClassTypeParametersBinder
                    f_10077_33795_33854(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol?
                    container, Microsoft.CodeAnalysis.CSharp.Binder
                    next)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.WithClassTypeParametersBinder((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?)container, next);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 33795, 33854);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.InContainerBinder
                    f_10077_33984_34031(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol?
                    container, Microsoft.CodeAnalysis.CSharp.Binder
                    next)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.InContainerBinder((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?)container, next);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 33984, 34031);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
                    f_10077_34068_34092(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.TypeParameterList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 34068, 34092);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.WithClassTypeParametersBinder
                    f_10077_34181_34240(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol?
                    container, Microsoft.CodeAnalysis.CSharp.Binder
                    next)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.WithClassTypeParametersBinder((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?)container, next);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 34181, 34240);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTokenList
                    f_10077_34402_34418(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Modifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 34402, 34418);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_34361_34419(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.SyntaxTokenList
                    modifiers)
                    {
                        var return_v = this_param.WithUnsafeRegionIfNecessary(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 34361, 34419);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_34444_34455()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 34444, 34455);
                        return return_v;
                    }


                    bool
                    f_10077_34444_34481(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryAdd(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 34444, 34481);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 32433, 34556);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 32433, 34556);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Binder VisitClassDeclaration(ClassDeclarationSyntax node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 34572, 34731);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 34678, 34716);

                    return f_10077_34685_34715(this, node);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 34572, 34731);

                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_34685_34715(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax
                    parent)
                    {
                        var return_v = this_param.VisitTypeDeclarationCore((Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax)parent);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 34685, 34715);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 34572, 34731);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 34572, 34731);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Binder VisitStructDeclaration(StructDeclarationSyntax node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 34747, 34908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 34855, 34893);

                    return f_10077_34862_34892(this, node);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 34747, 34908);

                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_34862_34892(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax
                    parent)
                    {
                        var return_v = this_param.VisitTypeDeclarationCore((Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax)parent);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 34862, 34892);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 34747, 34908);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 34747, 34908);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Binder VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 34924, 35091);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 35038, 35076);

                    return f_10077_35045_35075(this, node);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 34924, 35091);

                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_35045_35075(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax
                    parent)
                    {
                        var return_v = this_param.VisitTypeDeclarationCore((Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax)parent);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 35045, 35075);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 34924, 35091);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 34924, 35091);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Binder VisitRecordDeclaration(RecordDeclarationSyntax node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 35200, 35233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 35203, 35233);
                    return f_10077_35203_35233(this, node); DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 35200, 35233);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 35200, 35233);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 35200, 35233);
                }
                throw new System.Exception("Slicer error: unreachable code");

                Microsoft.CodeAnalysis.CSharp.Binder
                f_10077_35203_35233(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                parent)
                {
                    var return_v = this_param.VisitTypeDeclarationCore((Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax)parent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 35203, 35233);
                    return return_v;
                }

            }

            public override Binder VisitNamespaceDeclaration(NamespaceDeclarationSyntax parent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 35250, 35934);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 35366, 35522) || true) && (!f_10077_35371_35429(_position, parent))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 35366, 35522);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 35471, 35503);

                        return f_10077_35478_35502(this, f_10077_35488_35501(parent));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 35366, 35522);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 35674, 35777);

                    bool
                    inBody = f_10077_35688_35776(_position, f_10077_35730_35751(parent), f_10077_35753_35775(parent))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 35797, 35830);

                    bool
                    inUsing = f_10077_35812_35829(this, parent)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 35850, 35919);

                    return f_10077_35857_35918(this, parent, _position, inBody, inUsing);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 35250, 35934);

                    bool
                    f_10077_35371_35429(int
                    position, Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                    namespaceDecl)
                    {
                        var return_v = LookupPosition.IsInNamespaceDeclaration(position, namespaceDecl);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 35371, 35429);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_35488_35501(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 35488, 35501);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_35478_35502(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 35478, 35502);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10077_35730_35751(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.OpenBraceToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 35730, 35751);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10077_35753_35775(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.CloseBraceToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 35753, 35775);
                        return return_v;
                    }


                    bool
                    f_10077_35688_35776(int
                    position, Microsoft.CodeAnalysis.SyntaxToken
                    firstIncluded, Microsoft.CodeAnalysis.SyntaxToken
                    firstExcluded)
                    {
                        var return_v = LookupPosition.IsBetweenTokens(position, firstIncluded, firstExcluded);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 35688, 35776);
                        return return_v;
                    }


                    bool
                    f_10077_35812_35829(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                    containingNode)
                    {
                        var return_v = this_param.IsInUsing((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)containingNode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 35812, 35829);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_35857_35918(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                    parent, int
                    position, bool
                    inBody, bool
                    inUsing)
                    {
                        var return_v = this_param.VisitNamespaceDeclaration(parent, position, inBody, inUsing);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 35857, 35918);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 35250, 35934);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 35250, 35934);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal Binder VisitNamespaceDeclaration(NamespaceDeclarationSyntax parent, int position, bool inBody, bool inUsing)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 35950, 37866);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 36100, 36154);

                    f_10077_36100_36153(!inUsing || (DynAbs.Tracing.TraceSender.Expression_False(10077, 36113, 36131) || inBody), "inUsing => inBody");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 36174, 36282);

                    var
                    extraInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10077, 36190, 36197) || ((inUsing && DynAbs.Tracing.TraceSender.Conditional_F2(10077, 36200, 36225)) || DynAbs.Tracing.TraceSender.Conditional_F3(10077, 36228, 36281))) ? NodeUsage.NamespaceUsings : ((DynAbs.Tracing.TraceSender.Conditional_F1(10077, 36229, 36235) || ((inBody && DynAbs.Tracing.TraceSender.Conditional_F2(10077, 36238, 36261)) || DynAbs.Tracing.TraceSender.Conditional_F3(10077, 36264, 36280))) ? NodeUsage.NamespaceBody : NodeUsage.Normal)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 36330, 36380);

                    var
                    key = f_10077_36340_36379(parent, extraInfo)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 36400, 36414);

                    Binder
                    result
                    = default(Binder);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 36432, 37817) || true) && (!f_10077_36437_36477(f_10077_36437_36448(), key, out result))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 36432, 37817);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 36519, 36532);

                        Binder
                        outer
                        = default(Binder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 36554, 36584);

                        var
                        container = f_10077_36570_36583(parent)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 36608, 37330) || true) && (f_10077_36612_36620() && (DynAbs.Tracing.TraceSender.Expression_True(10077, 36612, 36670) && f_10077_36624_36640(container) == SyntaxKind.CompilationUnit))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 36608, 37330);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 37061, 37157);

                            outer = f_10077_37069_37156(this, container, inUsing: false, inScript: false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 36608, 37330);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 36608, 37330);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 37255, 37307);

                            outer = f_10077_37263_37306(_factory, f_10077_37282_37295(parent), position);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 36608, 37330);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 37354, 37742) || true) && (!inBody)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 37354, 37742);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 37467, 37482);

                            result = outer;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 37354, 37742);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 37354, 37742);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 37653, 37719);

                            result = f_10077_37662_37718(this, parent, f_10077_37690_37701(parent), outer, inUsing);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 37354, 37742);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 37766, 37798);

                        f_10077_37766_37797(f_10077_37766_37777(), key, result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 36432, 37817);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 37837, 37851);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 35950, 37866);

                    int
                    f_10077_36100_36153(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 36100, 36153);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    f_10077_36340_36379(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                    node, Microsoft.CodeAnalysis.CSharp.BinderFactory.NodeUsage
                    usage)
                    {
                        var return_v = CreateBinderCacheKey((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, usage);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 36340, 36379);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_36437_36448()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 36437, 36448);
                        return return_v;
                    }


                    bool
                    f_10077_36437_36477(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, out Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 36437, 36477);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_36570_36583(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 36570, 36583);
                        return return_v;
                    }


                    bool
                    f_10077_36612_36620()
                    {
                        var return_v = InScript;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 36612, 36620);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10077_36624_36640(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 36624, 36640);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_37069_37156(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    compilationUnit, bool
                    inUsing, bool
                    inScript)
                    {
                        var return_v = this_param.VisitCompilationUnit((Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax)compilationUnit, inUsing: inUsing, inScript: inScript);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 37069, 37156);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_37282_37295(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 37282, 37295);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_37263_37306(Microsoft.CodeAnalysis.CSharp.BinderFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node, int
                    position)
                    {
                        var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode?)node, position);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 37263, 37306);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                    f_10077_37690_37701(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 37690, 37701);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_37662_37718(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                    node, Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                    name, Microsoft.CodeAnalysis.CSharp.Binder
                    outer, bool
                    inUsing)
                    {
                        var return_v = this_param.MakeNamespaceBinder((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, name, outer, inUsing);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 37662, 37718);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_37766_37777()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 37766, 37777);
                        return return_v;
                    }


                    bool
                    f_10077_37766_37797(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryAdd(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 37766, 37797);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 35950, 37866);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 35950, 37866);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private Binder MakeNamespaceBinder(CSharpSyntaxNode node, NameSyntax name, Binder outer, bool inUsing)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 37882, 38960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 38017, 38044);

                    QualifiedNameSyntax
                    dotted
                    = default(QualifiedNameSyntax);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 38062, 38295) || true) && ((dotted = name as QualifiedNameSyntax) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 38062, 38295);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 38157, 38234);

                            outer = f_10077_38165_38233(this, f_10077_38185_38196(dotted), f_10077_38198_38209(dotted), outer, inUsing: false);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 38256, 38276);

                            name = f_10077_38263_38275(dotted);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 38062, 38295);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10077, 38062, 38295);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10077, 38062, 38295);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 38315, 38347);

                    NamespaceOrTypeSymbol
                    container
                    = default(NamespaceOrTypeSymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 38367, 38713) || true) && (outer is InContainerBinder inContainerBinder)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 38367, 38713);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 38457, 38497);

                        container = f_10077_38469_38496(inContainerBinder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 38367, 38713);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 38367, 38713);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 38579, 38626);

                        f_10077_38579_38625(outer is SimpleProgramUnitBinder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 38648, 38694);

                        container = f_10077_38660_38693(f_10077_38660_38677(outer));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 38367, 38713);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 38733, 38808);

                    NamespaceSymbol
                    ns = f_10077_38754_38807(((NamespaceSymbol)container), name)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 38826, 38863) || true) && ((object)ns == null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 38826, 38863);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 38850, 38863);

                        return outer;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 38826, 38863);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 38881, 38945);

                    return f_10077_38888_38944(ns, outer, node, inUsing: inUsing);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 37882, 38960);

                    Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                    f_10077_38185_38196(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                    this_param)
                    {
                        var return_v = this_param.Left;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 38185, 38196);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                    f_10077_38198_38209(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                    this_param)
                    {
                        var return_v = this_param.Left;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 38198, 38209);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_38165_38233(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                    node, Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                    name, Microsoft.CodeAnalysis.CSharp.Binder
                    outer, bool
                    inUsing)
                    {
                        var return_v = this_param.MakeNamespaceBinder((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, name, outer, inUsing: inUsing);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 38165, 38233);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                    f_10077_38263_38275(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                    this_param)
                    {
                        var return_v = this_param.Right;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 38263, 38275);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                    f_10077_38469_38496(Microsoft.CodeAnalysis.CSharp.InContainerBinder
                    this_param)
                    {
                        var return_v = this_param.Container;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 38469, 38496);
                        return return_v;
                    }


                    int
                    f_10077_38579_38625(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 38579, 38625);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10077_38660_38677(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 38660, 38677);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10077_38660_38693(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.GlobalNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 38660, 38693);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10077_38754_38807(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                    name)
                    {
                        var return_v = this_param.GetNestedNamespace(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 38754, 38807);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.InContainerBinder
                    f_10077_38888_38944(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    container, Microsoft.CodeAnalysis.CSharp.Binder
                    next, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    declarationSyntax, bool
                    inUsing)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.InContainerBinder((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)container, next, declarationSyntax, inUsing: inUsing);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 38888, 38944);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 37882, 38960);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 37882, 38960);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Binder VisitCompilationUnit(CompilationUnitSyntax parent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 38976, 39245);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 39082, 39230);

                    return f_10077_39089_39229(this, parent, inUsing: f_10077_39170_39187(this, parent), inScript: f_10077_39220_39228());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 38976, 39245);

                    bool
                    f_10077_39170_39187(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                    containingNode)
                    {
                        var return_v = this_param.IsInUsing((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)containingNode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 39170, 39187);
                        return return_v;
                    }


                    bool
                    f_10077_39220_39228()
                    {
                        var return_v = InScript;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 39220, 39228);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_39089_39229(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                    compilationUnit, bool
                    inUsing, bool
                    inScript)
                    {
                        var return_v = this_param.VisitCompilationUnit(compilationUnit, inUsing: inUsing, inScript: inScript);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 39089, 39229);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 38976, 39245);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 38976, 39245);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal Binder VisitCompilationUnit(CompilationUnitSyntax compilationUnit, bool inUsing, bool inScript)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 39261, 44091);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 39398, 39590) || true) && (compilationUnit != f_10077_39421_39441(f_10077_39421_39431()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 39398, 39590);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 39483, 39571);

                        throw f_10077_39489_39570(nameof(compilationUnit), "node not part of tree");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 39398, 39590);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 39610, 39829);

                    var
                    extraInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10077, 39626, 39633) || ((inUsing
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10077, 39657, 39741)) || DynAbs.Tracing.TraceSender.Conditional_F3(10077, 39765, 39828))) ? ((DynAbs.Tracing.TraceSender.Conditional_F1(10077, 39658, 39666) || ((inScript && DynAbs.Tracing.TraceSender.Conditional_F2(10077, 39669, 39706)) || DynAbs.Tracing.TraceSender.Conditional_F3(10077, 39709, 39740))) ? NodeUsage.CompilationUnitScriptUsings : NodeUsage.CompilationUnitUsings)
                    : ((DynAbs.Tracing.TraceSender.Conditional_F1(10077, 39766, 39774) || ((inScript && DynAbs.Tracing.TraceSender.Conditional_F2(10077, 39777, 39808)) || DynAbs.Tracing.TraceSender.Conditional_F3(10077, 39811, 39827))) ? NodeUsage.CompilationUnitScript : NodeUsage.Normal)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 39877, 39936);

                    var
                    key = f_10077_39887_39935(compilationUnit, extraInfo)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 39956, 39970);

                    Binder
                    result
                    = default(Binder);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 39988, 44042) || true) && (!f_10077_39993_40033(f_10077_39993_40004(), key, out result))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 39988, 44042);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 40075, 40109);

                        result = f_10077_40084_40108(this);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 40133, 43967) || true) && (inScript)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 40133, 43967);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 40195, 40249);

                            f_10077_40195_40248((object)f_10077_40216_40239(f_10077_40216_40227()) != null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 40849, 40936);

                            bool
                            isSubmissionTree = f_10077_40873_40935(f_10077_40873_40884(), f_10077_40908_40934(compilationUnit))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 40962, 41136) || true) && (!isSubmissionTree)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 40962, 41136);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 41041, 41109);

                                result = f_10077_41050_41108(result, BinderFlags.InLoadedSyntaxTree);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 40962, 41136);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 41262, 41305);

                            InContainerBinder
                            scriptClassBinder = null
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 41333, 42479) || true) && (inUsing)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 41333, 42479);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 41402, 41465);

                                result = f_10077_41411_41464(result, BinderFlags.InScriptUsing);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 41333, 42479);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 41333, 42479);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 41579, 41677);

                                result = f_10077_41588_41676(container: null, next: result, imports: f_10077_41650_41675(f_10077_41650_41661()));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 42021, 42452);

                                result = (DynAbs.Tracing.TraceSender.Conditional_F1(10077, 42030, 42089) || ((f_10077_42030_42060(f_10077_42030_42041()) == null || (DynAbs.Tracing.TraceSender.Expression_False(10077, 42030, 42089) || !isSubmissionTree
                                ) && DynAbs.Tracing.TraceSender.Conditional_F2(10077, 42125, 42226)) || DynAbs.Tracing.TraceSender.Conditional_F3(10077, 42262, 42451))) ? f_10077_42125_42226(result, basesBeingResolved => scriptClassBinder.GetImports(basesBeingResolved)) : f_10077_42262_42451(result, basesBeingResolved =>
                                                                            compilation.GetPreviousSubmissionImports().Concat(scriptClassBinder.GetImports(basesBeingResolved)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 41333, 42479);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 42507, 42575);

                            result = f_10077_42516_42574(f_10077_42538_42565(f_10077_42538_42549()), result);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 42603, 42769) || true) && (f_10077_42607_42633(f_10077_42607_42618()) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 42603, 42769);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 42699, 42742);

                                result = f_10077_42708_42741(result);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 42603, 42769);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 42797, 42907);

                            scriptClassBinder = f_10077_42817_42906(f_10077_42839_42862(f_10077_42839_42850()), result, compilationUnit, inUsing: inUsing);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 42933, 42960);

                            result = scriptClassBinder;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 40133, 43967);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 40133, 43967);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 43271, 43374);

                            result = f_10077_43280_43373(f_10077_43302_43329(f_10077_43302_43313()), result, compilationUnit, inUsing: inUsing);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 43402, 43944) || true) && (!inUsing && (DynAbs.Tracing.TraceSender.Expression_True(10077, 43406, 43622) && f_10077_43447_43564(f_10077_43503_43514(), compilationUnit, fallbackToMainEntryPoint: true) is SynthesizedSimpleProgramEntryPointSymbol simpleProgram))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 43402, 43944);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 43680, 43773);

                                ExecutableCodeBinder
                                bodyBinder = f_10077_43714_43772(simpleProgram, _factory._ignoreAccessibility)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 43803, 43917);

                                result = f_10077_43812_43916(result, (SimpleProgramBinder)f_10077_43869_43915(bodyBinder, f_10077_43890_43914(simpleProgram)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 43402, 43944);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 40133, 43967);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 43991, 44023);

                        f_10077_43991_44022(f_10077_43991_44002(), key, result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 39988, 44042);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 44062, 44076);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 39261, 44091);

                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10077_39421_39431()
                    {
                        var return_v = syntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 39421, 39431);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode
                    f_10077_39421_39441(Microsoft.CodeAnalysis.SyntaxTree
                    this_param)
                    {
                        var return_v = this_param.GetRoot();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 39421, 39441);
                        return return_v;
                    }


                    System.ArgumentOutOfRangeException
                    f_10077_39489_39570(string
                    paramName, string
                    message)
                    {
                        var return_v = new System.ArgumentOutOfRangeException(paramName, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 39489, 39570);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    f_10077_39887_39935(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                    node, Microsoft.CodeAnalysis.CSharp.BinderFactory.NodeUsage
                    usage)
                    {
                        var return_v = CreateBinderCacheKey((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, usage);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 39887, 39935);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_39993_40004()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 39993, 40004);
                        return return_v;
                    }


                    bool
                    f_10077_39993_40033(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, out Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 39993, 40033);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BuckStopsHereBinder
                    f_10077_40084_40108(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param)
                    {
                        var return_v = this_param.buckStopsHereBinder;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 40084, 40108);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10077_40216_40227()
                    {
                        var return_v = compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 40216, 40227);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    f_10077_40216_40239(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.ScriptClass;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 40216, 40239);
                        return return_v;
                    }


                    int
                    f_10077_40195_40248(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 40195, 40248);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10077_40873_40884()
                    {
                        var return_v = compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 40873, 40884);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10077_40908_40934(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                    this_param)
                    {
                        var return_v = this_param.SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 40908, 40934);
                        return return_v;
                    }


                    bool
                    f_10077_40873_40935(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.SyntaxTree
                    tree)
                    {
                        var return_v = this_param.IsSubmissionSyntaxTree(tree);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 40873, 40935);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_41050_41108(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                    flags)
                    {
                        var return_v = this_param.WithAdditionalFlags(flags);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 41050, 41108);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_41411_41464(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                    flags)
                    {
                        var return_v = this_param.WithAdditionalFlags(flags);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 41411, 41464);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10077_41650_41661()
                    {
                        var return_v = compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 41650, 41661);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Imports
                    f_10077_41650_41675(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.GlobalImports;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 41650, 41675);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.InContainerBinder
                    f_10077_41588_41676(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                    container, Microsoft.CodeAnalysis.CSharp.Binder
                    next, Microsoft.CodeAnalysis.CSharp.Imports
                    imports)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.InContainerBinder(container: container, next: next, imports: imports);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 41588, 41676);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10077_42030_42041()
                    {
                        var return_v = compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 42030, 42041);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation?
                    f_10077_42030_42060(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.PreviousSubmission;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 42030, 42060);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.InContainerBinder
                    f_10077_42125_42226(Microsoft.CodeAnalysis.CSharp.Binder
                    next, System.Func<Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>, Microsoft.CodeAnalysis.CSharp.Imports>
                    computeImports)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.InContainerBinder(next, computeImports);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 42125, 42226);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.InContainerBinder
                    f_10077_42262_42451(Microsoft.CodeAnalysis.CSharp.Binder
                    next, System.Func<Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>, Microsoft.CodeAnalysis.CSharp.Imports>
                    computeImports)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.InContainerBinder(next, computeImports);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 42262, 42451);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10077_42538_42549()
                    {
                        var return_v = compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 42538, 42549);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10077_42538_42565(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.GlobalNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 42538, 42565);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.InContainerBinder
                    f_10077_42516_42574(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    container, Microsoft.CodeAnalysis.CSharp.Binder
                    next)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.InContainerBinder((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)container, next);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 42516, 42574);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10077_42607_42618()
                    {
                        var return_v = compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 42607, 42618);
                        return return_v;
                    }


                    System.Type?
                    f_10077_42607_42633(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.HostObjectType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 42607, 42633);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.HostObjectModelBinder
                    f_10077_42708_42741(Microsoft.CodeAnalysis.CSharp.Binder
                    next)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.HostObjectModelBinder(next);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 42708, 42741);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10077_42839_42850()
                    {
                        var return_v = compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 42839, 42850);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10077_42839_42862(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.ScriptClass;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 42839, 42862);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.InContainerBinder
                    f_10077_42817_42906(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    container, Microsoft.CodeAnalysis.CSharp.Binder
                    next, Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                    declarationSyntax, bool
                    inUsing)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.InContainerBinder((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)container, next, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)declarationSyntax, inUsing: inUsing);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 42817, 42906);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10077_43302_43313()
                    {
                        var return_v = compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 43302, 43313);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10077_43302_43329(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.GlobalNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 43302, 43329);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.InContainerBinder
                    f_10077_43280_43373(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    container, Microsoft.CodeAnalysis.CSharp.Binder
                    next, Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                    declarationSyntax, bool
                    inUsing)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.InContainerBinder((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)container, next, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)declarationSyntax, inUsing: inUsing);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 43280, 43373);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10077_43503_43514()
                    {
                        var return_v = compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 43503, 43514);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol?
                    f_10077_43447_43564(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation, Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                    compilationUnit, bool
                    fallbackToMainEntryPoint)
                    {
                        var return_v = SimpleProgramNamedTypeSymbol.GetSimpleProgramEntryPoint(compilation, compilationUnit, fallbackToMainEntryPoint: fallbackToMainEntryPoint);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 43447, 43564);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                    f_10077_43714_43772(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol
                    this_param, bool
                    ignoreAccessibility)
                    {
                        var return_v = this_param.GetBodyBinder(ignoreAccessibility);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 43714, 43772);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    f_10077_43890_43914(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol
                    this_param)
                    {
                        var return_v = this_param.SyntaxNode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 43890, 43914);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_43869_43915(Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    node)
                    {
                        var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 43869, 43915);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SimpleProgramUnitBinder
                    f_10077_43812_43916(Microsoft.CodeAnalysis.CSharp.Binder
                    enclosing, Microsoft.CodeAnalysis.CSharp.Binder
                    scope)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.SimpleProgramUnitBinder(enclosing, (Microsoft.CodeAnalysis.CSharp.SimpleProgramBinder)scope);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 43812, 43916);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_43991_44002()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 43991, 44002);
                        return return_v;
                    }


                    bool
                    f_10077_43991_44022(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryAdd(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 43991, 44022);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 39261, 44091);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 39261, 44091);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal static BinderCacheKey CreateBinderCacheKey(CSharpSyntaxNode node, NodeUsage usage)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10077, 44107, 44389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 44231, 44317);

                    f_10077_44231_44316(f_10077_44244_44289(usage) <= 1, "Not a flags enum.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 44335, 44374);

                    return f_10077_44342_44373(node, usage);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10077, 44107, 44389);

                    int
                    f_10077_44244_44289(Microsoft.CodeAnalysis.CSharp.BinderFactory.NodeUsage
                    v)
                    {
                        var return_v = BitArithmeticUtilities.CountBits((uint)v);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 44244, 44289);
                        return return_v;
                    }


                    int
                    f_10077_44231_44316(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 44231, 44316);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    f_10077_44342_44373(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    syntaxNode, Microsoft.CodeAnalysis.CSharp.BinderFactory.NodeUsage
                    usage)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey(syntaxNode, usage);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 44342, 44373);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 44107, 44389);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 44107, 44389);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool IsInUsing(CSharpSyntaxNode containingNode)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 44800, 46356);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 44888, 44934);

                    TextSpan
                    containingSpan = f_10077_44914_44933(containingNode)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 44954, 44972);

                    SyntaxToken
                    token
                    = default(SyntaxToken);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 44990, 45616) || true) && (f_10077_44994_45015(containingNode) != SyntaxKind.CompilationUnit && (DynAbs.Tracing.TraceSender.Expression_True(10077, 44994, 45080) && _position == containingSpan.End))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 44990, 45616);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 45165, 45203);

                        token = f_10077_45173_45202(containingNode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 45225, 45289);

                        f_10077_45225_45288(token == f_10077_45247_45287(f_10077_45247_45272(f_10077_45247_45262(this))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 44990, 45616);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 44990, 45616);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 45331, 45616) || true) && (_position < containingSpan.Start || (DynAbs.Tracing.TraceSender.Expression_False(10077, 45335, 45401) || _position > containingSpan.End))
                        ) //NB: > not >=

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 45331, 45616);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 45458, 45471);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 45331, 45616);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 45331, 45616);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 45553, 45597);

                            token = f_10077_45561_45596(containingNode, _position);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 45331, 45616);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 44990, 45616);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 45636, 45660);

                    var
                    node = token.Parent
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 45678, 46310) || true) && (node != null && (DynAbs.Tracing.TraceSender.Expression_True(10077, 45685, 45723) && node != containingNode))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 45678, 46310);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 46088, 46248) || true) && (f_10077_46092_46130(node, SyntaxKind.UsingDirective) && (DynAbs.Tracing.TraceSender.Expression_True(10077, 46092, 46163) && f_10077_46134_46145(node) == containingNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 46088, 46248);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 46213, 46225);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 46088, 46248);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 46272, 46291);

                            node = f_10077_46279_46290(node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 45678, 46310);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10077, 45678, 46310);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10077, 45678, 46310);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 46328, 46341);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 44800, 46356);

                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_10077_44914_44933(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Span;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 44914, 44933);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10077_44994_45015(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 44994, 45015);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10077_45173_45202(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetLastToken();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 45173, 45202);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10077_45247_45262(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param)
                    {
                        var return_v = this_param.syntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 45247, 45262);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode
                    f_10077_45247_45272(Microsoft.CodeAnalysis.SyntaxTree
                    this_param)
                    {
                        var return_v = this_param.GetRoot();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 45247, 45272);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10077_45247_45287(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetLastToken();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 45247, 45287);
                        return return_v;
                    }


                    int
                    f_10077_45225_45288(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 45225, 45288);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10077_45561_45596(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param, int
                    position)
                    {
                        var return_v = this_param.FindToken(position);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 45561, 45596);
                        return return_v;
                    }


                    bool
                    f_10077_46092_46130(Microsoft.CodeAnalysis.SyntaxNode
                    node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    kind)
                    {
                        var return_v = node.IsKind(kind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 46092, 46130);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode?
                    f_10077_46134_46145(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 46134, 46145);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode?
                    f_10077_46279_46290(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 46279, 46290);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 44800, 46356);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 44800, 46356);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Binder VisitDocumentationCommentTrivia(DocumentationCommentTriviaSyntax parent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 46372, 46687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 46621, 46672);

                    return f_10077_46628_46671(this, parent.ParentTrivia.Token.Parent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 46372, 46687);

                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_46628_46671(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.SyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 46628, 46671);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 46372, 46687);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 46372, 46687);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Binder VisitCrefParameter(CrefParameterSyntax parent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 46831, 47183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 46933, 47055);

                    XmlCrefAttributeSyntax
                    containingAttribute = f_10077_46978_47054(parent, ascendOutOfTrivia: false)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 47073, 47168);

                    return f_10077_47080_47167(this, containingAttribute, NodeUsage.CrefParameterOrReturnType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 46831, 47183);

                    Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax?
                    f_10077_46978_47054(Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax
                    this_param, bool
                    ascendOutOfTrivia)
                    {
                        var return_v = this_param.FirstAncestorOrSelf<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax>(ascendOutOfTrivia: ascendOutOfTrivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 46978, 47054);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_47080_47167(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax?
                    parent, Microsoft.CodeAnalysis.CSharp.BinderFactory.NodeUsage
                    extraInfo)
                    {
                        var return_v = this_param.VisitXmlCrefAttributeInternal(parent, extraInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 47080, 47167);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 46831, 47183);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 46831, 47183);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Binder VisitConversionOperatorMemberCref(ConversionOperatorMemberCrefSyntax parent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 47324, 47885);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 47456, 47796) || true) && (f_10077_47460_47471(parent).Span.Contains(_position))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 47456, 47796);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 47538, 47660);

                        XmlCrefAttributeSyntax
                        containingAttribute = f_10077_47583_47659(parent, ascendOutOfTrivia: false)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 47682, 47777);

                        return f_10077_47689_47776(this, containingAttribute, NodeUsage.CrefParameterOrReturnType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 47456, 47796);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 47816, 47870);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitConversionOperatorMemberCref(parent), 10077, 47823, 47869);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 47324, 47885);

                    Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                    f_10077_47460_47471(Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 47460, 47471);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax?
                    f_10077_47583_47659(Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax
                    this_param, bool
                    ascendOutOfTrivia)
                    {
                        var return_v = this_param.FirstAncestorOrSelf<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax>(ascendOutOfTrivia: ascendOutOfTrivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 47583, 47659);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_47689_47776(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax?
                    parent, Microsoft.CodeAnalysis.CSharp.BinderFactory.NodeUsage
                    extraInfo)
                    {
                        var return_v = this_param.VisitXmlCrefAttributeInternal(parent, extraInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 47689, 47776);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 47324, 47885);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 47324, 47885);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Binder VisitXmlCrefAttribute(XmlCrefAttributeSyntax parent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 47901, 48334);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 48009, 48162) || true) && (!f_10077_48014_48069(_position, parent))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 48009, 48162);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 48111, 48143);

                        return f_10077_48118_48142(this, f_10077_48128_48141(parent));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 48009, 48162);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 48182, 48215);

                    var
                    extraInfo = NodeUsage.Normal
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 48263, 48319);

                    return f_10077_48270_48318(this, parent, extraInfo);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 47901, 48334);

                    bool
                    f_10077_48014_48069(int
                    position, Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax
                    attribute)
                    {
                        var return_v = LookupPosition.IsInXmlAttributeValue(position, (Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax)attribute);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 48014, 48069);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_48128_48141(Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 48128, 48141);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_48118_48142(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 48118, 48142);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_48270_48318(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax
                    parent, Microsoft.CodeAnalysis.CSharp.BinderFactory.NodeUsage
                    extraInfo)
                    {
                        var return_v = this_param.VisitXmlCrefAttributeInternal(parent, extraInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 48270, 48318);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 47901, 48334);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 47901, 48334);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private Binder VisitXmlCrefAttributeInternal(XmlCrefAttributeSyntax parent, NodeUsage extraInfo)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 48350, 49485);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 48479, 48633);

                    f_10077_48479_48632(extraInfo == NodeUsage.Normal || (DynAbs.Tracing.TraceSender.Expression_False(10077, 48492, 48573) || extraInfo == NodeUsage.CrefParameterOrReturnType), "Unexpected extraInfo " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (extraInfo).ToString(), 10077, 48622, 48631));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 48653, 48703);

                    var
                    key = f_10077_48663_48702(parent, extraInfo)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 48723, 48737);

                    Binder
                    result
                    = default(Binder);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 48755, 49436) || true) && (!f_10077_48760_48800(f_10077_48760_48771(), key, out result))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 48755, 49436);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 48842, 48878);

                        CrefSyntax
                        crefSyntax = f_10077_48866_48877(parent)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 48900, 48979);

                        MemberDeclarationSyntax
                        memberSyntax = f_10077_48939_48978(parent)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 49003, 49083);

                        bool
                        inParameterOrReturnType = extraInfo == NodeUsage.CrefParameterOrReturnType
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 49107, 49361);

                        result = (DynAbs.Tracing.TraceSender.Conditional_F1(10077, 49116, 49144) || (((object)memberSyntax == null
                        && DynAbs.Tracing.TraceSender.Conditional_F2(10077, 49172, 49257)) || DynAbs.Tracing.TraceSender.Conditional_F3(10077, 49285, 49360))) ? f_10077_49172_49257(crefSyntax, f_10077_49207_49231(this, f_10077_49217_49230(parent)), inParameterOrReturnType) : f_10077_49285_49360(crefSyntax, memberSyntax, _factory, inParameterOrReturnType);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 49385, 49417);

                        f_10077_49385_49416(f_10077_49385_49396(), key, result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 48755, 49436);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 49456, 49470);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 48350, 49485);

                    int
                    f_10077_48479_48632(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 48479, 48632);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    f_10077_48663_48702(Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax
                    node, Microsoft.CodeAnalysis.CSharp.BinderFactory.NodeUsage
                    usage)
                    {
                        var return_v = CreateBinderCacheKey((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, usage);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 48663, 48702);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_48760_48771()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 48760, 48771);
                        return return_v;
                    }


                    bool
                    f_10077_48760_48800(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, out Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 48760, 48800);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                    f_10077_48866_48877(Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax
                    this_param)
                    {
                        var return_v = this_param.Cref;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 48866, 48877);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                    f_10077_48939_48978(Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax
                    xmlSyntax)
                    {
                        var return_v = GetAssociatedMemberForXmlSyntax((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)xmlSyntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 48939, 48978);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_49217_49230(Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 49217, 49230);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_49207_49231(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 49207, 49231);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_49172_49257(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                    crefSyntax, Microsoft.CodeAnalysis.CSharp.Binder
                    binder, bool
                    inParameterOrReturnType)
                    {
                        var return_v = MakeCrefBinderInternal(crefSyntax, binder, inParameterOrReturnType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 49172, 49257);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_49285_49360(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                    crefSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                    memberSyntax, Microsoft.CodeAnalysis.CSharp.BinderFactory
                    factory, bool
                    inParameterOrReturnType)
                    {
                        var return_v = MakeCrefBinder(crefSyntax, memberSyntax, factory, inParameterOrReturnType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 49285, 49360);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_49385_49396()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 49385, 49396);
                        return return_v;
                    }


                    bool
                    f_10077_49385_49416(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryAdd(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 49385, 49416);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 48350, 49485);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 48350, 49485);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Binder VisitXmlNameAttribute(XmlNameAttributeSyntax parent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 49501, 53025);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 49609, 49762) || true) && (!f_10077_49614_49669(_position, parent))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 49609, 49762);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 49711, 49743);

                        return f_10077_49718_49742(this, f_10077_49728_49741(parent));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 49609, 49762);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 49782, 49848);

                    XmlNameAttributeElementKind
                    elementKind = f_10077_49824_49847(parent)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 49870, 49890);

                    NodeUsage
                    extraInfo
                    = default(NodeUsage);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 49908, 50709);

                    switch (elementKind)
                    {

                        case XmlNameAttributeElementKind.Parameter:
                        case XmlNameAttributeElementKind.ParameterReference:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 49908, 50709);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 50112, 50164);

                            extraInfo = NodeUsage.DocumentationCommentParameter;
                            DynAbs.Tracing.TraceSender.TraceBreak(10077, 50190, 50196);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 49908, 50709);

                        case XmlNameAttributeElementKind.TypeParameter:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 49908, 50709);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 50291, 50347);

                            extraInfo = NodeUsage.DocumentationCommentTypeParameter;
                            DynAbs.Tracing.TraceSender.TraceBreak(10077, 50373, 50379);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 49908, 50709);

                        case XmlNameAttributeElementKind.TypeParameterReference:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 49908, 50709);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 50483, 50548);

                            extraInfo = NodeUsage.DocumentationCommentTypeParameterReference;
                            DynAbs.Tracing.TraceSender.TraceBreak(10077, 50574, 50580);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 49908, 50709);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 49908, 50709);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 50636, 50690);

                            throw f_10077_50642_50689(elementKind);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 49908, 50709);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 50994, 51078);

                    var
                    key = f_10077_51004_51077(f_10077_51025_51065(parent), extraInfo)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 51098, 51112);

                    Binder
                    result
                    = default(Binder);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 51130, 52976) || true) && (!f_10077_51135_51175(f_10077_51135_51146(), key, out result))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 51130, 52976);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 51217, 51251);

                        result = f_10077_51226_51250(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 51275, 51348);

                        Binder
                        outerBinder = f_10077_51296_51347(this, f_10077_51306_51346(parent))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 51370, 51756) || true) && ((object)outerBinder != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 51370, 51756);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 51650, 51733);

                            result = f_10077_51659_51732(result, f_10077_51695_51731(outerBinder));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 51370, 51756);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 51780, 51859);

                        MemberDeclarationSyntax
                        memberSyntax = f_10077_51819_51858(parent)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 51881, 52901) || true) && ((object)memberSyntax != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 51881, 52901);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 51963, 52878);

                            switch (elementKind)
                            {

                                case XmlNameAttributeElementKind.Parameter:
                                case XmlNameAttributeElementKind.ParameterReference:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 51963, 52878);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 52199, 52267);

                                    result = f_10077_52208_52266(this, memberSyntax, result);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10077, 52301, 52307);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 51963, 52878);

                                case XmlNameAttributeElementKind.TypeParameter:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 51963, 52878);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 52418, 52535);

                                    result = f_10077_52427_52534(this, memberSyntax, includeContainingSymbols: false, nextBinder: result);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10077, 52569, 52575);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 51963, 52878);

                                case XmlNameAttributeElementKind.TypeParameterReference:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 51963, 52878);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 52695, 52811);

                                    result = f_10077_52704_52810(this, memberSyntax, includeContainingSymbols: true, nextBinder: result);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10077, 52845, 52851);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 51963, 52878);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 51881, 52901);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 52925, 52957);

                        f_10077_52925_52956(f_10077_52925_52936(), key, result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 51130, 52976);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 52996, 53010);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 49501, 53025);

                    bool
                    f_10077_49614_49669(int
                    position, Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                    attribute)
                    {
                        var return_v = LookupPosition.IsInXmlAttributeValue(position, (Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax)attribute);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 49614, 49669);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_49728_49741(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 49728, 49741);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_49718_49742(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 49718, 49742);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeElementKind
                    f_10077_49824_49847(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                    attributeSyntax)
                    {
                        var return_v = attributeSyntax.GetElementKind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 49824, 49847);
                        return return_v;
                    }


                    System.Exception
                    f_10077_50642_50689(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeElementKind
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 50642, 50689);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax
                    f_10077_51025_51065(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                    xmlSyntax)
                    {
                        var return_v = GetEnclosingDocumentationComment((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)xmlSyntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 51025, 51065);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    f_10077_51004_51077(Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax
                    node, Microsoft.CodeAnalysis.CSharp.BinderFactory.NodeUsage
                    usage)
                    {
                        var return_v = CreateBinderCacheKey((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, usage);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 51004, 51077);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_51135_51146()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 51135, 51146);
                        return return_v;
                    }


                    bool
                    f_10077_51135_51175(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, out Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 51135, 51175);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BuckStopsHereBinder
                    f_10077_51226_51250(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param)
                    {
                        var return_v = this_param.buckStopsHereBinder;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 51226, 51250);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax
                    f_10077_51306_51346(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                    xmlSyntax)
                    {
                        var return_v = GetEnclosingDocumentationComment((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)xmlSyntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 51306, 51346);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_51296_51347(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 51296, 51347);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10077_51695_51731(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.ContainingMemberOrLambda;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 51695, 51731);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_51659_51732(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol?
                    containing)
                    {
                        var return_v = this_param.WithContainingMemberOrLambda(containing);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 51659, 51732);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                    f_10077_51819_51858(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                    xmlSyntax)
                    {
                        var return_v = GetAssociatedMemberForXmlSyntax((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)xmlSyntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 51819, 51858);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_52208_52266(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                    memberSyntax, Microsoft.CodeAnalysis.CSharp.Binder
                    nextBinder)
                    {
                        var return_v = this_param.GetParameterNameAttributeValueBinder(memberSyntax, nextBinder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 52208, 52266);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_52427_52534(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                    memberSyntax, bool
                    includeContainingSymbols, Microsoft.CodeAnalysis.CSharp.Binder
                    nextBinder)
                    {
                        var return_v = this_param.GetTypeParameterNameAttributeValueBinder(memberSyntax, includeContainingSymbols: includeContainingSymbols, nextBinder: nextBinder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 52427, 52534);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_52704_52810(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                    memberSyntax, bool
                    includeContainingSymbols, Microsoft.CodeAnalysis.CSharp.Binder
                    nextBinder)
                    {
                        var return_v = this_param.GetTypeParameterNameAttributeValueBinder(memberSyntax, includeContainingSymbols: includeContainingSymbols, nextBinder: nextBinder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 52704, 52810);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    f_10077_52925_52936()
                    {
                        var return_v = binderCache;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 52925, 52936);
                        return return_v;
                    }


                    bool
                    f_10077_52925_52956(Microsoft.CodeAnalysis.ConcurrentCache<Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey, Microsoft.CodeAnalysis.CSharp.Binder>
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderCacheKey
                    key, Microsoft.CodeAnalysis.CSharp.Binder
                    value)
                    {
                        var return_v = this_param.TryAdd(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 52925, 52956);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 49501, 53025);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 49501, 53025);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private Binder GetParameterNameAttributeValueBinder(MemberDeclarationSyntax memberSyntax, Binder nextBinder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 53275, 56855);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 53416, 53820) || true) && (memberSyntax is BaseMethodDeclarationSyntax { ParameterList: { ParameterCount: > 0 } } baseMethodDeclSyntax)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 53416, 53820);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 53569, 53621);

                        Binder
                        outerBinder = f_10077_53590_53620(this, f_10077_53600_53619(memberSyntax))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 53643, 53716);

                        MethodSymbol
                        method = f_10077_53665_53715(this, baseMethodDeclSyntax, outerBinder)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 53738, 53801);

                        return f_10077_53745_53800(f_10077_53770_53787(method), nextBinder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 53416, 53820);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 53840, 54668) || true) && (memberSyntax is RecordDeclarationSyntax { ParameterList: { ParameterCount: > 0 } } recordDeclSyntax)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 53840, 54668);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 53985, 54030);

                        Binder
                        outerBinder = f_10077_54006_54029(this, memberSyntax)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 54052, 54187);

                        SourceNamedTypeSymbol
                        recordType = f_10077_54087_54186(((NamespaceOrTypeSymbol)f_10077_54111_54147(outerBinder)), recordDeclSyntax)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 54209, 54324);

                        var
                        primaryConstructor = f_10077_54234_54323(f_10077_54234_54266(recordType).OfType<SynthesizedRecordConstructor>())
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 54348, 54649) || true) && (f_10077_54352_54391(f_10077_54352_54380(primaryConstructor)) == f_10077_54395_54422(recordDeclSyntax) && (DynAbs.Tracing.TraceSender.Expression_True(10077, 54352, 54501) && f_10077_54451_54481(primaryConstructor) == recordDeclSyntax))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 54348, 54649);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 54551, 54626);

                            return f_10077_54558_54625(f_10077_54583_54612(primaryConstructor), nextBinder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 54348, 54649);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 53840, 54668);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 54769, 54813);

                    SyntaxKind
                    memberKind = f_10077_54793_54812(memberSyntax)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 54831, 56802) || true) && (memberKind == SyntaxKind.PropertyDeclaration || (DynAbs.Tracing.TraceSender.Expression_False(10077, 54835, 54926) || memberKind == SyntaxKind.IndexerDeclaration))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 54831, 56802);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 54968, 55020);

                        Binder
                        outerBinder = f_10077_54989_55019(this, f_10077_54999_55018(memberSyntax))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 55044, 55139);

                        BasePropertyDeclarationSyntax
                        propertyDeclSyntax = (BasePropertyDeclarationSyntax)memberSyntax
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 55161, 55238);

                        PropertySymbol
                        property = f_10077_55187_55237(this, propertyDeclSyntax, outerBinder)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 55262, 55327);

                        ImmutableArray<ParameterSymbol>
                        parameters = f_10077_55307_55326(property)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 55513, 55768) || true) && ((object)f_10077_55525_55543(property) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 55513, 55768);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 55601, 55653);

                            f_10077_55601_55652(f_10077_55614_55647(f_10077_55614_55632(property)) > 0);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 55679, 55745);

                            parameters = parameters.Add(f_10077_55707_55725(property).Parameters.Last());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 55513, 55768);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 55792, 55941) || true) && (parameters.Any())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 55792, 55941);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 55862, 55918);

                            return f_10077_55869_55917(parameters, nextBinder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 55792, 55941);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 54831, 56802);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 54831, 56802);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 55983, 56802) || true) && (memberKind == SyntaxKind.DelegateDeclaration)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 55983, 56802);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 56073, 56125);

                            Binder
                            outerBinder = f_10077_56094_56124(this, f_10077_56104_56123(memberSyntax))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 56147, 56307);

                            SourceNamedTypeSymbol
                            delegateType = f_10077_56184_56306(((NamespaceOrTypeSymbol)f_10077_56208_56244(outerBinder)), memberSyntax)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 56329, 56372);

                            f_10077_56329_56371((object)delegateType != null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 56394, 56456);

                            MethodSymbol
                            invokeMethod = f_10077_56422_56455(delegateType)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 56478, 56521);

                            f_10077_56478_56520((object)invokeMethod != null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 56543, 56612);

                            ImmutableArray<ParameterSymbol>
                            parameters = f_10077_56588_56611(invokeMethod)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 56634, 56783) || true) && (parameters.Any())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 56634, 56783);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 56704, 56760);

                                return f_10077_56711_56759(parameters, nextBinder);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 56634, 56783);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 55983, 56802);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 54831, 56802);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 56822, 56840);

                    return nextBinder;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 53275, 56855);

                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_53600_53619(Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 53600, 53619);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_53590_53620(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 53590, 53620);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                    f_10077_53665_53715(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                    baseMethodDeclarationSyntax, Microsoft.CodeAnalysis.CSharp.Binder
                    outerBinder)
                    {
                        var return_v = this_param.GetMethodSymbol(baseMethodDeclarationSyntax, outerBinder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 53665, 53715);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10077_53770_53787(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 53770, 53787);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.WithParametersBinder
                    f_10077_53745_53800(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    parameters, Microsoft.CodeAnalysis.CSharp.Binder
                    next)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.WithParametersBinder(parameters, next);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 53745, 53800);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_54006_54029(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 54006, 54029);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10077_54111_54147(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.ContainingMemberOrLambda;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 54111, 54147);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol?
                    f_10077_54087_54186(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                    syntax)
                    {
                        var return_v = this_param.GetSourceTypeMember((Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax)syntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 54087, 54186);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10077_54234_54266(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol?
                    this_param)
                    {
                        var return_v = this_param.GetMembersUnordered();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 54234, 54266);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
                    f_10077_54234_54323(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor>
                    source)
                    {
                        var return_v = source.SingleOrDefault<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 54234, 54323);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxReference
                    f_10077_54352_54380(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
                    this_param)
                    {
                        var return_v = this_param.SyntaxRef;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 54352, 54380);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10077_54352_54391(Microsoft.CodeAnalysis.SyntaxReference
                    this_param)
                    {
                        var return_v = this_param.SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 54352, 54391);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10077_54395_54422(Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 54395, 54422);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                    f_10077_54451_54481(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
                    this_param)
                    {
                        var return_v = this_param.GetSyntax();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 54451, 54481);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10077_54583_54612(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 54583, 54612);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.WithParametersBinder
                    f_10077_54558_54625(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    parameters, Microsoft.CodeAnalysis.CSharp.Binder
                    next)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.WithParametersBinder(parameters, next);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 54558, 54625);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10077_54793_54812(Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 54793, 54812);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_54999_55018(Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 54999, 55018);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_54989_55019(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 54989, 55019);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                    f_10077_55187_55237(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                    basePropertyDeclarationSyntax, Microsoft.CodeAnalysis.CSharp.Binder
                    outerBinder)
                    {
                        var return_v = this_param.GetPropertySymbol(basePropertyDeclarationSyntax, outerBinder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 55187, 55237);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10077_55307_55326(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 55307, 55326);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10077_55525_55543(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.SetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 55525, 55543);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10077_55614_55632(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.SetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 55614, 55632);
                        return return_v;
                    }


                    int
                    f_10077_55614_55647(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 55614, 55647);
                        return return_v;
                    }


                    int
                    f_10077_55601_55652(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 55601, 55652);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10077_55707_55725(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.SetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 55707, 55725);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.WithParametersBinder
                    f_10077_55869_55917(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    parameters, Microsoft.CodeAnalysis.CSharp.Binder
                    next)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.WithParametersBinder(parameters, next);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 55869, 55917);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_56104_56123(Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 56104, 56123);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_56094_56124(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 56094, 56124);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10077_56208_56244(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.ContainingMemberOrLambda;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 56208, 56244);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol?
                    f_10077_56184_56306(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                    syntax)
                    {
                        var return_v = this_param.GetSourceTypeMember((Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax)syntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 56184, 56306);
                        return return_v;
                    }


                    int
                    f_10077_56329_56371(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 56329, 56371);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10077_56422_56455(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.DelegateInvokeMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 56422, 56455);
                        return return_v;
                    }


                    int
                    f_10077_56478_56520(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 56478, 56520);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10077_56588_56611(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 56588, 56611);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.WithParametersBinder
                    f_10077_56711_56759(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    parameters, Microsoft.CodeAnalysis.CSharp.Binder
                    next)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.WithParametersBinder(parameters, next);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 56711, 56759);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 53275, 56855);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 53275, 56855);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private Binder GetTypeParameterNameAttributeValueBinder(MemberDeclarationSyntax memberSyntax, bool includeContainingSymbols, Binder nextBinder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10077, 57118, 59798);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 57294, 57802) || true) && (includeContainingSymbols)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 57294, 57802);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 57364, 57416);

                        Binder
                        outerBinder = f_10077_57385_57415(this, f_10077_57395_57414(memberSyntax))
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 57459, 57492);
                            for (NamedTypeSymbol
        curr = f_10077_57466_57492(outerBinder)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 57438, 57783) || true) && ((object)curr != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 57516, 57542)
        , curr = f_10077_57523_57542(curr), DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 57438, 57783))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 57438, 57783);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 57592, 57760) || true) && (f_10077_57596_57606(curr) > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 57592, 57760);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 57668, 57733);

                                    nextBinder = f_10077_57681_57732(curr, nextBinder);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 57592, 57760);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10077, 1, 346);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10077, 1, 346);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 57294, 57802);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 57911, 57988);

                    TypeDeclarationSyntax
                    typeDeclSyntax = memberSyntax as TypeDeclarationSyntax
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 58006, 58504) || true) && ((object)typeDeclSyntax != null && (DynAbs.Tracing.TraceSender.Expression_True(10077, 58010, 58068) && f_10077_58044_58064(typeDeclSyntax) > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 58006, 58504);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 58110, 58162);

                        Binder
                        outerBinder = f_10077_58131_58161(this, f_10077_58141_58160(memberSyntax))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 58184, 58317);

                        SourceNamedTypeSymbol
                        typeSymbol = f_10077_58219_58316(((NamespaceOrTypeSymbol)f_10077_58243_58279(outerBinder)), typeDeclSyntax)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 58420, 58485);

                        return f_10077_58427_58484(typeSymbol, nextBinder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 58006, 58504);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 58524, 59745) || true) && (f_10077_58528_58547(memberSyntax) == SyntaxKind.MethodDeclaration)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 58524, 59745);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 58621, 58702);

                        MethodDeclarationSyntax
                        methodDeclSyntax = (MethodDeclarationSyntax)memberSyntax
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 58724, 59062) || true) && (f_10077_58728_58750(methodDeclSyntax) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 58724, 59062);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 58804, 58856);

                            Binder
                            outerBinder = f_10077_58825_58855(this, f_10077_58835_58854(memberSyntax))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 58882, 58951);

                            MethodSymbol
                            method = f_10077_58904_58950(this, methodDeclSyntax, outerBinder)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 58977, 59039);

                            return f_10077_58984_59038(method, nextBinder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 58724, 59062);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 58524, 59745);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 58524, 59745);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 59104, 59745) || true) && (f_10077_59108_59127(memberSyntax) == SyntaxKind.DelegateDeclaration)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 59104, 59745);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 59203, 59255);

                            Binder
                            outerBinder = f_10077_59224_59254(this, f_10077_59234_59253(memberSyntax))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 59277, 59437);

                            SourceNamedTypeSymbol
                            delegateType = f_10077_59314_59436(((NamespaceOrTypeSymbol)f_10077_59338_59374(outerBinder)), memberSyntax)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 59459, 59540);

                            ImmutableArray<TypeParameterSymbol>
                            typeParameters = f_10077_59512_59539(delegateType)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 59562, 59726) || true) && (typeParameters.Any())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 59562, 59726);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 59636, 59703);

                                return f_10077_59643_59702(delegateType, nextBinder);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 59562, 59726);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 59104, 59745);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 58524, 59745);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 59765, 59783);

                    return nextBinder;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10077, 57118, 59798);

                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_57395_57414(Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 57395, 57414);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_57385_57415(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 57385, 57415);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    f_10077_57466_57492(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 57466, 57492);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10077_57523_57542(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 57523, 57542);
                        return return_v;
                    }


                    int
                    f_10077_57596_57606(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 57596, 57606);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.WithClassTypeParametersBinder
                    f_10077_57681_57732(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    container, Microsoft.CodeAnalysis.CSharp.Binder
                    next)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.WithClassTypeParametersBinder(container, next);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 57681, 57732);
                        return return_v;
                    }


                    int
                    f_10077_58044_58064(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 58044, 58064);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_58141_58160(Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 58141, 58160);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_58131_58161(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 58131, 58161);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10077_58243_58279(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.ContainingMemberOrLambda;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 58243, 58279);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol?
                    f_10077_58219_58316(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                    syntax)
                    {
                        var return_v = this_param.GetSourceTypeMember(syntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 58219, 58316);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.WithClassTypeParametersBinder
                    f_10077_58427_58484(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol?
                    container, Microsoft.CodeAnalysis.CSharp.Binder
                    next)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.WithClassTypeParametersBinder((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?)container, next);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 58427, 58484);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10077_58528_58547(Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 58528, 58547);
                        return return_v;
                    }


                    int
                    f_10077_58728_58750(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 58728, 58750);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_58835_58854(Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 58835, 58854);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_58825_58855(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 58825, 58855);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                    f_10077_58904_58950(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                    baseMethodDeclarationSyntax, Microsoft.CodeAnalysis.CSharp.Binder
                    outerBinder)
                    {
                        var return_v = this_param.GetMethodSymbol((Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)baseMethodDeclarationSyntax, outerBinder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 58904, 58950);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.WithMethodTypeParametersBinder
                    f_10077_58984_59038(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    methodSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                    next)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.WithMethodTypeParametersBinder(methodSymbol, next);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 58984, 59038);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10077_59108_59127(Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 59108, 59127);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    f_10077_59234_59253(Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 59234, 59253);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10077_59224_59254(Microsoft.CodeAnalysis.CSharp.BinderFactory.BinderFactoryVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                    node)
                    {
                        var return_v = this_param.VisitCore((Microsoft.CodeAnalysis.SyntaxNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 59224, 59254);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10077_59338_59374(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.ContainingMemberOrLambda;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 59338, 59374);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol?
                    f_10077_59314_59436(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                    syntax)
                    {
                        var return_v = this_param.GetSourceTypeMember((Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax)syntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 59314, 59436);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10077_59512_59539(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol?
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 59512, 59539);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.WithClassTypeParametersBinder
                    f_10077_59643_59702(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    container, Microsoft.CodeAnalysis.CSharp.Binder
                    next)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.WithClassTypeParametersBinder((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)container, next);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 59643, 59702);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 57118, 59798);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 57118, 59798);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static BinderFactoryVisitor()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10077, 590, 59809);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10077, 590, 59809);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 590, 59809);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10077, 590, 59809);
        }

        internal static Binder MakeCrefBinder(CrefSyntax crefSyntax, MemberDeclarationSyntax memberSyntax, BinderFactory factory, bool inParameterOrReturnType = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10077, 60696, 61371);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 60880, 60913);

                f_10077_60880_60912(crefSyntax != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 60927, 60962);

                f_10077_60927_60961(memberSyntax != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 60978, 61063);

                BaseTypeDeclarationSyntax
                typeDeclSyntax = memberSyntax as BaseTypeDeclarationSyntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 61079, 61269);

                Binder
                binder = (DynAbs.Tracing.TraceSender.Conditional_F1(10077, 61095, 61125) || (((object)typeDeclSyntax == null
                && DynAbs.Tracing.TraceSender.Conditional_F2(10077, 61145, 61176)) || DynAbs.Tracing.TraceSender.Conditional_F3(10077, 61196, 61268))) ? f_10077_61145_61176(factory, memberSyntax) : f_10077_61196_61268(factory, memberSyntax, typeDeclSyntax.OpenBraceToken.SpanStart)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 61285, 61360);

                return f_10077_61292_61359(crefSyntax, binder, inParameterOrReturnType);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10077, 60696, 61371);

                int
                f_10077_60880_60912(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 60880, 60912);
                    return 0;
                }


                int
                f_10077_60927_60961(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 60927, 60961);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10077_61145_61176(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 61145, 61176);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10077_61196_61268(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                node, int
                position)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 61196, 61268);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10077_61292_61359(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                crefSyntax, Microsoft.CodeAnalysis.CSharp.Binder
                binder, bool
                inParameterOrReturnType)
                {
                    var return_v = MakeCrefBinderInternal(crefSyntax, binder, inParameterOrReturnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 61292, 61359);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 60696, 61371);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 60696, 61371);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Binder MakeCrefBinderInternal(CrefSyntax crefSyntax, Binder binder, bool inParameterOrReturnType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10077, 61542, 62534);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 62120, 62223);

                BinderFlags
                flags = BinderFlags.Cref | BinderFlags.SuppressConstraintChecks | BinderFlags.UnsafeRegion
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 62237, 62360) || true) && (inParameterOrReturnType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 62237, 62360);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 62298, 62345);

                    flags |= BinderFlags.CrefParameterOrReturnType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 62237, 62360);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 62376, 62419);

                binder = f_10077_62385_62418(binder, flags);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 62433, 62495);

                binder = f_10077_62442_62494(crefSyntax, binder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 62509, 62523);

                return binder;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10077, 61542, 62534);

                Microsoft.CodeAnalysis.CSharp.Binder
                f_10077_62385_62418(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 62385, 62418);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.WithCrefTypeParametersBinder
                f_10077_62442_62494(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                crefSyntax, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.WithCrefTypeParametersBinder(crefSyntax, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 62442, 62494);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 61542, 62534);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 61542, 62534);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static MemberDeclarationSyntax GetAssociatedMemberForXmlSyntax(CSharpSyntaxNode xmlSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10077, 62546, 63610);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 62670, 62819);

                f_10077_62670_62818(xmlSyntax is XmlAttributeSyntax || (DynAbs.Tracing.TraceSender.Expression_False(10077, 62683, 62764) || f_10077_62718_62734(xmlSyntax) == SyntaxKind.XmlEmptyElement) || (DynAbs.Tracing.TraceSender.Expression_False(10077, 62683, 62817) || f_10077_62768_62784(xmlSyntax) == SyntaxKind.XmlElementStartTag));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 62835, 62921);

                StructuredTriviaSyntax
                structuredTrivia = f_10077_62877_62920(xmlSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 62935, 62997);

                SyntaxTrivia
                containingTrivia = f_10077_62967_62996(structuredTrivia)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 63011, 63077);

                SyntaxToken
                associatedToken = (SyntaxToken)containingTrivia.Token
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 63093, 63158);

                CSharpSyntaxNode
                curr = (CSharpSyntaxNode)associatedToken.Parent
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 63172, 63571) || true) && (curr != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 63172, 63571);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 63225, 63296);

                        MemberDeclarationSyntax
                        memberSyntax = curr as MemberDeclarationSyntax
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 63314, 63519) || true) && (memberSyntax != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 63314, 63519);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 63480, 63500);

                            return memberSyntax;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 63314, 63519);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 63537, 63556);

                        curr = f_10077_63544_63555(curr);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 63172, 63571);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10077, 63172, 63571);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10077, 63172, 63571);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 63587, 63599);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10077, 62546, 63610);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10077_62718_62734(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 62718, 62734);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10077_62768_62784(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 62768, 62784);
                    return return_v;
                }


                int
                f_10077_62670_62818(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 62670, 62818);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax
                f_10077_62877_62920(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                xmlSyntax)
                {
                    var return_v = GetEnclosingDocumentationComment(xmlSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 62877, 62920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10077_62967_62996(Microsoft.CodeAnalysis.CSharp.Syntax.StructuredTriviaSyntax
                this_param)
                {
                    var return_v = this_param.ParentTrivia;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 62967, 62996);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10077_63544_63555(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 63544, 63555);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 62546, 63610);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 62546, 63610);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static DocumentationCommentTriviaSyntax GetEnclosingDocumentationComment(CSharpSyntaxNode xmlSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10077, 63780, 64187);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 63913, 63947);

                CSharpSyntaxNode
                curr = xmlSyntax
                ;
                try
                {
                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 63961, 64073) || true) && (!f_10077_63969_64022(f_10077_64010_64021(curr)))
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 64024, 64042)
   , curr = f_10077_64031_64042(curr), DynAbs.Tracing.TraceSender.TraceExitCondition(10077, 63961, 64073))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10077, 63961, 64073);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10077, 1, 113);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10077, 1, 113);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 64087, 64114);

                f_10077_64087_64113(curr != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10077, 64130, 64176);

                return (DocumentationCommentTriviaSyntax)curr;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10077, 63780, 64187);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10077_64010_64021(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 64010, 64021);
                    return return_v;
                }


                bool
                f_10077_63969_64022(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsDocumentationCommentTrivia(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 63969, 64022);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10077_64031_64042(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10077, 64031, 64042);
                    return return_v;
                }


                int
                f_10077_64087_64113(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10077, 64087, 64113);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10077, 63780, 64187);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 63780, 64187);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BinderFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10077, 530, 64216);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10077, 530, 64216);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10077, 530, 64216);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10077, 530, 64216);
    }
}
