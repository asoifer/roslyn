// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using InternalSyntax = Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax;

namespace Microsoft.CodeAnalysis.CSharp
{
    public abstract partial class CSharpSyntaxTree : SyntaxTree
    {
        internal static readonly SyntaxTree Dummy;

        public new abstract CSharpParseOptions Options { get; }

        protected T CloneNodeAsRoot<T>(T node) where T : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 2468, 2621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 2558, 2610);

                return f_10039_2565_2609<T>(node, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 2468, 2621);

                T
                f_10039_2565_2609<T>(T
                node, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                syntaxTree) where T : CSharpSyntaxNode

                {
                    var return_v = CSharpSyntaxNode.CloneNodeAsRoot(node, (Microsoft.CodeAnalysis.SyntaxTree)syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 2565, 2609);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 2468, 2621);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 2468, 2621);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new abstract CSharpSyntaxNode GetRoot(CancellationToken cancellationToken = default);

        public abstract bool TryGetRoot([NotNullWhen(true)] out CSharpSyntaxNode? root);

        public new virtual Task<CSharpSyntaxNode> GetRootAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 3465, 3711);
                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode? node = default(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 3591, 3700);

                return f_10039_3598_3699((DynAbs.Tracing.TraceSender.Conditional_F1(10039, 3614, 3657) || ((f_10039_3614_3657(this, out node) && DynAbs.Tracing.TraceSender.Conditional_F2(10039, 3660, 3664)) || DynAbs.Tracing.TraceSender.Conditional_F3(10039, 3667, 3698))) ? node : f_10039_3667_3698(this, cancellationToken));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 3465, 3711);

                bool
                f_10039_3614_3657(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, out Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                root)
                {
                    var return_v = this_param.TryGetRoot(out root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 3614, 3657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10039_3667_3698(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetRoot(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 3667, 3698);
                    return return_v;
                }


                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>
                f_10039_3598_3699(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                result)
                {
                    var return_v = Task.FromResult(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 3598, 3699);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 3465, 3711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 3465, 3711);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationUnitSyntax GetCompilationUnitRoot(CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 4193, 4389);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 4316, 4378);

                return (CompilationUnitSyntax)f_10039_4346_4377(this, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 4193, 4389);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10039_4346_4377(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetRoot(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 4346, 4377);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 4193, 4389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 4193, 4389);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool IsEquivalentTo(SyntaxTree tree, bool topLevel = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 4956, 5124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 5056, 5113);

                return f_10039_5063_5112(this, tree, topLevel);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 4956, 5124);

                bool
                f_10039_5063_5112(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                oldTree, Microsoft.CodeAnalysis.SyntaxTree
                newTree, bool
                topLevel)
                {
                    var return_v = SyntaxFactory.AreEquivalent((Microsoft.CodeAnalysis.SyntaxTree)oldTree, newTree, topLevel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 5063, 5112);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 4956, 5124);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 4956, 5124);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasReferenceDirectives
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 5197, 5413);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 5233, 5270);

                    f_10039_5233_5269(f_10039_5246_5268());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 5290, 5398);

                    return f_10039_5297_5309(f_10039_5297_5304()) == SourceCodeKind.Script && (DynAbs.Tracing.TraceSender.Expression_True(10039, 5297, 5397) && f_10039_5338_5393(f_10039_5338_5387(f_10039_5338_5362(this))) > 0);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 5197, 5413);

                    bool
                    f_10039_5246_5268()
                    {
                        var return_v = HasCompilationUnitRoot;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 5246, 5268);
                        return return_v;
                    }


                    int
                    f_10039_5233_5269(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 5233, 5269);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                    f_10039_5297_5304()
                    {
                        var return_v = Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 5297, 5304);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SourceCodeKind
                    f_10039_5297_5309(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 5297, 5309);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                    f_10039_5338_5362(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                    this_param)
                    {
                        var return_v = this_param.GetCompilationUnitRoot();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 5338, 5362);
                        return return_v;
                    }


                    System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax>
                    f_10039_5338_5387(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                    this_param)
                    {
                        var return_v = this_param.GetReferenceDirectives();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 5338, 5387);
                        return return_v;
                    }


                    int
                    f_10039_5338_5393(System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 5338, 5393);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 5136, 5424);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 5136, 5424);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasReferenceOrLoadDirectives
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 5503, 5934);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 5539, 5576);

                    f_10039_5539_5575(f_10039_5552_5574());

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 5596, 5886) || true) && (f_10039_5600_5612(f_10039_5600_5607()) == SourceCodeKind.Script)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 5596, 5886);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 5679, 5730);

                        var
                        compilationUnitRoot = f_10039_5705_5729(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 5752, 5867);

                        return f_10039_5759_5809(f_10039_5759_5803(compilationUnitRoot)) > 0 || (DynAbs.Tracing.TraceSender.Expression_False(10039, 5759, 5866) || f_10039_5817_5862(f_10039_5817_5856(compilationUnitRoot)) > 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 5596, 5886);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 5906, 5919);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 5503, 5934);

                    bool
                    f_10039_5552_5574()
                    {
                        var return_v = HasCompilationUnitRoot;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 5552, 5574);
                        return return_v;
                    }


                    int
                    f_10039_5539_5575(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 5539, 5575);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                    f_10039_5600_5607()
                    {
                        var return_v = Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 5600, 5607);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SourceCodeKind
                    f_10039_5600_5612(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 5600, 5612);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                    f_10039_5705_5729(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                    this_param)
                    {
                        var return_v = this_param.GetCompilationUnitRoot();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 5705, 5729);
                        return return_v;
                    }


                    System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax>
                    f_10039_5759_5803(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                    this_param)
                    {
                        var return_v = this_param.GetReferenceDirectives();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 5759, 5803);
                        return return_v;
                    }


                    int
                    f_10039_5759_5809(System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 5759, 5809);
                        return return_v;
                    }


                    System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax>
                    f_10039_5817_5856(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                    this_param)
                    {
                        var return_v = this_param.GetLoadDirectives();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 5817, 5856);
                        return return_v;
                    }


                    int
                    f_10039_5817_5862(System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 5817, 5862);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 5436, 5945);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 5436, 5945);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool _hasDirectives;

        private InternalSyntax.DirectiveStack _directives;

        internal void SetDirectiveStack(InternalSyntax.DirectiveStack directives)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 6095, 6265);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 6193, 6218);

                _directives = directives;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 6232, 6254);

                _hasDirectives = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 6095, 6265);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 6095, 6265);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 6095, 6265);
            }
        }

        private InternalSyntax.DirectiveStack GetDirectives()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 6277, 6572);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 6355, 6526) || true) && (!_hasDirectives)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 6355, 6526);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 6408, 6468);

                    var
                    stack = f_10039_6420_6467(f_10039_6420_6442(f_10039_6420_6434(this)), default)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 6486, 6511);

                    f_10039_6486_6510(this, stack);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 6355, 6526);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 6542, 6561);

                return _directives;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 6277, 6572);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10039_6420_6434(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 6420, 6434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                f_10039_6420_6442(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.CsGreen;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 6420, 6442);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                f_10039_6420_6467(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                stack)
                {
                    var return_v = this_param.ApplyDirectives(stack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 6420, 6467);
                    return return_v;
                }


                int
                f_10039_6486_6510(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                directives)
                {
                    this_param.SetDirectiveStack(directives);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 6486, 6510);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 6277, 6572);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 6277, 6572);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsAnyPreprocessorSymbolDefined(ImmutableArray<string> conditionalSymbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 6584, 7020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 6696, 6737);

                f_10039_6696_6736(conditionalSymbols != null);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 6753, 6980);
                    foreach (string conditionalSymbol in f_10039_6790_6808_I(conditionalSymbols))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 6753, 6980);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 6842, 6965) || true) && (f_10039_6846_6892(this, conditionalSymbol))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 6842, 6965);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 6934, 6946);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 6842, 6965);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 6753, 6980);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10039, 1, 228);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10039, 1, 228);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 6996, 7009);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 6584, 7020);

                int
                f_10039_6696_6736(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 6696, 6736);
                    return 0;
                }


                bool
                f_10039_6846_6892(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, string
                symbolName)
                {
                    var return_v = this_param.IsPreprocessorSymbolDefined(symbolName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 6846, 6892);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10039_6790_6808_I(System.Collections.Immutable.ImmutableArray<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 6790, 6808);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 6584, 7020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 6584, 7020);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsPreprocessorSymbolDefined(string symbolName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 7032, 7192);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 7117, 7181);

                return f_10039_7124_7180(this, f_10039_7152_7167(this), symbolName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 7032, 7192);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                f_10039_7152_7167(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param)
                {
                    var return_v = this_param.GetDirectives();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 7152, 7167);
                    return return_v;
                }


                bool
                f_10039_7124_7180(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                directives, string
                symbolName)
                {
                    var return_v = this_param.IsPreprocessorSymbolDefined(directives, symbolName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 7124, 7180);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 7032, 7192);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 7032, 7192);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsPreprocessorSymbolDefined(InternalSyntax.DirectiveStack directives, string symbolName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 7204, 7708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 7330, 7697);

                switch (directives.IsDefined(symbolName))
                {

                    case InternalSyntax.DefineState.Defined:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 7330, 7697);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 7466, 7478);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 7330, 7697);

                    case InternalSyntax.DefineState.Undefined:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 7330, 7697);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 7560, 7573);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 7330, 7697);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 7330, 7697);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 7621, 7682);

                        return f_10039_7628_7640(this).PreprocessorSymbols.Contains(symbolName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 7330, 7697);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 7204, 7708);

                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10039_7628_7640(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 7628, 7640);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 7204, 7708);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 7204, 7708);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<int> _preprocessorStateChangePositions;

        private ImmutableArray<InternalSyntax.DirectiveStack> _preprocessorStates;

        internal bool IsPreprocessorSymbolDefined(string symbolName, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 8276, 9251);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 8375, 8505) || true) && (_preprocessorStateChangePositions.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 8375, 8505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 8456, 8490);

                    f_10039_8456_8489(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 8375, 8505);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 8521, 8597);

                int
                searchResult = _preprocessorStateChangePositions.BinarySearch(position)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 8611, 8652);

                InternalSyntax.DirectiveStack
                directives
                = default(InternalSyntax.DirectiveStack);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 8668, 9165) || true) && (searchResult < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 8668, 9165);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 8722, 8757);

                    searchResult = (~searchResult) - 1;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 8777, 9037) || true) && (searchResult >= 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 8777, 9037);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 8840, 8887);

                        directives = _preprocessorStates[searchResult];
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 8777, 9037);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 8777, 9037);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 8969, 9018);

                        directives = InternalSyntax.DirectiveStack.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 8777, 9037);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 8668, 9165);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 8668, 9165);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 9103, 9150);

                    directives = _preprocessorStates[searchResult];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 8668, 9165);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 9181, 9240);

                return f_10039_9188_9239(this, directives, symbolName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 8276, 9251);

                int
                f_10039_8456_8489(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param)
                {
                    this_param.BuildPreprocessorStateChangeMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 8456, 8489);
                    return 0;
                }


                bool
                f_10039_9188_9239(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                directives, string
                symbolName)
                {
                    var return_v = this_param.IsPreprocessorSymbolDefined(directives, symbolName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 9188, 9239);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 8276, 9251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 8276, 9251);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void BuildPreprocessorStateChangeMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 9263, 13227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 9334, 9415);

                InternalSyntax.DirectiveStack
                currentState = InternalSyntax.DirectiveStack.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 9429, 9477);

                var
                positions = f_10039_9445_9476()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 9491, 9562);

                var
                states = f_10039_9504_9561()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 9578, 12762);
                    foreach (DirectiveTriviaSyntax directive in f_10039_9622_11056_I(f_10039_9622_11056(f_10039_9622_9636(this), d =>
                                                                                             {
                                                                                                 switch (d.Kind())
                                                                                                 {
                                                                                                     case SyntaxKind.IfDirectiveTrivia:
                                                                                                     case SyntaxKind.ElifDirectiveTrivia:
                                                                                                     case SyntaxKind.ElseDirectiveTrivia:
                                                                                                     case SyntaxKind.EndIfDirectiveTrivia:
                                                                                                     case SyntaxKind.DefineDirectiveTrivia:
                                                                                                     case SyntaxKind.UndefDirectiveTrivia:
                                                                                                         return true;
                                                                                                     default:
                                                                                                         return false;
                                                                                                 }
                                                                                             })))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 9578, 12762);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 11090, 11145);

                        currentState = directive.ApplyDirectives(currentState);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 11165, 12747);

                        switch (f_10039_11173_11189(directive))
                        {

                            case SyntaxKind.IfDirectiveTrivia:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 11165, 12747);
                                DynAbs.Tracing.TraceSender.TraceBreak(10039, 11385, 11391);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 11165, 12747);

                            case SyntaxKind.ElifDirectiveTrivia:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 11165, 12747);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 11477, 11502);

                                f_10039_11477_11501(states, currentState);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 11528, 11604);

                                f_10039_11528_11603(positions, ((ElifDirectiveTriviaSyntax)directive).ElifKeyword.SpanStart);
                                DynAbs.Tracing.TraceSender.TraceBreak(10039, 11630, 11636);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 11165, 12747);

                            case SyntaxKind.ElseDirectiveTrivia:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 11165, 12747);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 11722, 11747);

                                f_10039_11722_11746(states, currentState);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 11773, 11849);

                                f_10039_11773_11848(positions, ((ElseDirectiveTriviaSyntax)directive).ElseKeyword.SpanStart);
                                DynAbs.Tracing.TraceSender.TraceBreak(10039, 11875, 11881);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 11165, 12747);

                            case SyntaxKind.EndIfDirectiveTrivia:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 11165, 12747);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 11968, 11993);

                                f_10039_11968_11992(states, currentState);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 12019, 12097);

                                f_10039_12019_12096(positions, ((EndIfDirectiveTriviaSyntax)directive).EndIfKeyword.SpanStart);
                                DynAbs.Tracing.TraceSender.TraceBreak(10039, 12123, 12129);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 11165, 12747);

                            case SyntaxKind.DefineDirectiveTrivia:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 11165, 12747);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 12217, 12242);

                                f_10039_12217_12241(states, currentState);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 12268, 12339);

                                f_10039_12268_12338(positions, ((DefineDirectiveTriviaSyntax)directive).Name.SpanStart);
                                DynAbs.Tracing.TraceSender.TraceBreak(10039, 12365, 12371);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 11165, 12747);

                            case SyntaxKind.UndefDirectiveTrivia:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 11165, 12747);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 12458, 12483);

                                f_10039_12458_12482(states, currentState);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 12509, 12579);

                                f_10039_12509_12578(positions, ((UndefDirectiveTriviaSyntax)directive).Name.SpanStart);
                                DynAbs.Tracing.TraceSender.TraceBreak(10039, 12605, 12611);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 11165, 12747);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 11165, 12747);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 12669, 12728);

                                throw f_10039_12675_12727(f_10039_12710_12726(directive));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 11165, 12747);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 9578, 12762);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10039, 1, 3185);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10039, 1, 3185);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 12789, 12809);

                int
                currentPos = -1
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 12823, 12967);
                    foreach (int pos in f_10039_12843_12852_I(positions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 12823, 12967);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 12886, 12917);

                        f_10039_12886_12916(currentPos < pos);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 12935, 12952);

                        currentPos = pos;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 12823, 12967);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10039, 1, 145);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10039, 1, 145);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 12991, 13088);

                f_10039_12991_13087(ref _preprocessorStates, f_10039_13059_13086(states));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 13102, 13216);

                f_10039_13102_13215(ref _preprocessorStateChangePositions, f_10039_13184_13214(positions));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 9263, 13227);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                f_10039_9445_9476()
                {
                    var return_v = ArrayBuilder<int>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 9445, 9476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack>
                f_10039_9504_9561()
                {
                    var return_v = ArrayBuilder<InternalSyntax.DirectiveStack>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 9504, 9561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10039_9622_9636(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 9622, 9636);
                    return return_v;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                f_10039_9622_11056(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax, bool>?
                filter)
                {
                    var return_v = this_param.GetDirectives(filter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 9622, 11056);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10039_11173_11189(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 11173, 11189);
                    return return_v;
                }


                int
                f_10039_11477_11501(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 11477, 11501);
                    return 0;
                }


                int
                f_10039_11528_11603(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 11528, 11603);
                    return 0;
                }


                int
                f_10039_11722_11746(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 11722, 11746);
                    return 0;
                }


                int
                f_10039_11773_11848(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 11773, 11848);
                    return 0;
                }


                int
                f_10039_11968_11992(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 11968, 11992);
                    return 0;
                }


                int
                f_10039_12019_12096(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 12019, 12096);
                    return 0;
                }


                int
                f_10039_12217_12241(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 12217, 12241);
                    return 0;
                }


                int
                f_10039_12268_12338(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 12268, 12338);
                    return 0;
                }


                int
                f_10039_12458_12482(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 12458, 12482);
                    return 0;
                }


                int
                f_10039_12509_12578(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 12509, 12578);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10039_12710_12726(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 12710, 12726);
                    return return_v;
                }


                System.Exception
                f_10039_12675_12727(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 12675, 12727);
                    return return_v;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                f_10039_9622_11056_I(System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 9622, 11056);
                    return return_v;
                }


                int
                f_10039_12886_12916(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 12886, 12916);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                f_10039_12843_12852_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 12843, 12852);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack>
                f_10039_13059_13086(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 13059, 13086);
                    return return_v;
                }


                bool
                f_10039_12991_13087(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 12991, 13087);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10039_13184_13214(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 13184, 13214);
                    return return_v;
                }


                bool
                f_10039_13102_13215(ref System.Collections.Immutable.ImmutableArray<int>
                location, System.Collections.Immutable.ImmutableArray<int>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 13102, 13215);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 9263, 13227);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 9263, 13227);
            }
        }

        public static SyntaxTree Create(CSharpSyntaxNode root, CSharpParseOptions? options = null, string path = "", Encoding? encoding = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10039, 13665, 14061);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 13948, 14018);

                return f_10039_13955_14017(root, options, path, encoding, diagnosticOptions: null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10039, 13665, 14061);

                Microsoft.CodeAnalysis.SyntaxTree
                f_10039_13955_14017(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                root, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                options, string
                path, System.Text.Encoding?
                encoding, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>?
                diagnosticOptions)
                {
                    var return_v = Create(root, options, path, encoding, diagnosticOptions: diagnosticOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 13955, 14017);
                    return return_v;
                }

#pragma warning restore CS0618
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 13665, 14061);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 13665, 14061);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The diagnosticOptions and isGeneratedCode parameters are obsolete due to performance problems, if you are using them use CompilationOptions.SyntaxTreeOptionsProvider instead", error: false)]
        public static SyntaxTree Create(
                    CSharpSyntaxNode root,
                    CSharpParseOptions? options,
                    string path,
                    Encoding? encoding,
                    // obsolete parameter -- unused
                    ImmutableDictionary<string, ReportDiagnostic>? diagnosticOptions,
                    // obsolete parameter -- unused
                    bool? isGeneratedCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10039, 14584, 15995);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 15249, 15360) || true) && (root == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 15249, 15360);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 15299, 15345);

                    throw f_10039_15305_15344(nameof(root));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 15249, 15360);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 15376, 15571);

                var
                directives = (DynAbs.Tracing.TraceSender.Conditional_F1(10039, 15393, 15434) || ((f_10039_15393_15404(root) == SyntaxKind.CompilationUnit && DynAbs.Tracing.TraceSender.Conditional_F2(10039, 15454, 15515)) || DynAbs.Tracing.TraceSender.Conditional_F3(10039, 15535, 15570))) ? f_10039_15454_15515(((CompilationUnitSyntax)root)) : InternalSyntax.DirectiveStack.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 15587, 15984);

                return f_10039_15594_15983(textOpt: null, encodingOpt: encoding, checksumAlgorithm: SourceHashAlgorithm.Sha1, path: path, options: options ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?>(10039, 15805, 15842) ?? f_10039_15816_15842()), root: root, directives: directives, diagnosticOptions, cloneRoot: true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10039, 14584, 15995);

                System.ArgumentNullException
                f_10039_15305_15344(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 15305, 15344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10039_15393_15404(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 15393, 15404);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                f_10039_15454_15515(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.GetConditionalDirectivesStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 15454, 15515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10039_15816_15842()
                {
                    var return_v = CSharpParseOptions.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 15816, 15842);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParsedSyntaxTree
                f_10039_15594_15983(Microsoft.CodeAnalysis.Text.SourceText?
                textOpt, System.Text.Encoding?
                encodingOpt, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, string
                path, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                root, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                directives, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>?
                diagnosticOptions, bool
                cloneRoot)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParsedSyntaxTree(textOpt: textOpt, encodingOpt: encodingOpt, checksumAlgorithm: checksumAlgorithm, path: path, options: options, root: root, directives: directives, diagnosticOptions, cloneRoot: cloneRoot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 15594, 15983);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 14584, 15995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 14584, 15995);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxTree CreateForDebugger(CSharpSyntaxNode root, SourceText text, CSharpParseOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10039, 16238, 16480);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 16375, 16402);

                f_10039_16375_16401(root != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 16418, 16469);

                return f_10039_16425_16468(root, text, options);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10039, 16238, 16480);

                int
                f_10039_16375_16401(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 16375, 16401);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.DebuggerSyntaxTree
                f_10039_16425_16468(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                root, Microsoft.CodeAnalysis.Text.SourceText
                text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.DebuggerSyntaxTree(root, text, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 16425, 16468);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 16238, 16480);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 16238, 16480);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxTree CreateWithoutClone(CSharpSyntaxNode root)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10039, 17143, 17702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 17236, 17263);

                f_10039_17236_17262(root != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 17279, 17691);

                return f_10039_17286_17690(textOpt: null, encodingOpt: null, checksumAlgorithm: SourceHashAlgorithm.Sha1, path: "", options: f_10039_17491_17517(), root: root, directives: InternalSyntax.DirectiveStack.Empty, diagnosticOptions: null, cloneRoot: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10039, 17143, 17702);

                int
                f_10039_17236_17262(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 17236, 17262);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10039_17491_17517()
                {
                    var return_v = CSharpParseOptions.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 17491, 17517);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParsedSyntaxTree
                f_10039_17286_17690(Microsoft.CodeAnalysis.Text.SourceText?
                textOpt, System.Text.Encoding?
                encodingOpt, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, string
                path, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                root, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                directives, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>?
                diagnosticOptions, bool
                cloneRoot)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParsedSyntaxTree(textOpt: textOpt, encodingOpt: encodingOpt, checksumAlgorithm: checksumAlgorithm, path: path, options: options, root: root, directives: directives, diagnosticOptions: diagnosticOptions, cloneRoot: cloneRoot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 17286, 17690);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 17143, 17702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 17143, 17702);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTree ParseText(
                    string text,
                    CSharpParseOptions? options = null,
                    string path = "",
                    Encoding? encoding = null,
                    CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10039, 18094, 18618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 18483, 18575);

                return f_10039_18490_18574(text, options, path, encoding, diagnosticOptions: null, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10039, 18094, 18618);

                Microsoft.CodeAnalysis.SyntaxTree
                f_10039_18490_18574(string
                text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                options, string
                path, System.Text.Encoding?
                encoding, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>?
                diagnosticOptions, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = ParseText(text, options, path, encoding, diagnosticOptions: diagnosticOptions, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 18490, 18574);
                    return return_v;
                }

#pragma warning restore CS0618
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 18094, 18618);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 18094, 18618);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The diagnosticOptions and isGeneratedCode parameters are obsolete due to performance problems, if you are using them use CompilationOptions.SyntaxTreeOptionsProvider instead", error: false)]
        public static SyntaxTree ParseText(
                    string text,
                    CSharpParseOptions? options,
                    string path,
                    Encoding? encoding,
                    ImmutableDictionary<string, ReportDiagnostic>? diagnosticOptions,
                    bool? isGeneratedCode,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10039, 19043, 19792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 19661, 19781);

                return f_10039_19668_19780(f_10039_19678_19709(text, encoding), options, path, diagnosticOptions, isGeneratedCode, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10039, 19043, 19792);

                Microsoft.CodeAnalysis.Text.SourceText
                f_10039_19678_19709(string
                text, System.Text.Encoding?
                encoding)
                {
                    var return_v = SourceText.From(text, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 19678, 19709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10039_19668_19780(Microsoft.CodeAnalysis.Text.SourceText
                text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                options, string
                path, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>?
                diagnosticOptions, bool?
                isGeneratedCode, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = ParseText(text, options, path, diagnosticOptions, isGeneratedCode, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 19668, 19780);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 19043, 19792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 19043, 19792);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTree ParseText(
                    SourceText text,
                    CSharpParseOptions? options = null,
                    string path = "",
                    CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10039, 20184, 20662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 20537, 20619);

                return f_10039_20544_20618(text, options, path, diagnosticOptions: null, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10039, 20184, 20662);

                Microsoft.CodeAnalysis.SyntaxTree
                f_10039_20544_20618(Microsoft.CodeAnalysis.Text.SourceText
                text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                options, string
                path, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>?
                diagnosticOptions, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = ParseText(text, options, path, diagnosticOptions: diagnosticOptions, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 20544, 20618);
                    return return_v;
                }

#pragma warning restore CS0618
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 20184, 20662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 20184, 20662);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The diagnosticOptions and isGeneratedCode parameters are obsolete due to performance problems, if you are using them use CompilationOptions.SyntaxTreeOptionsProvider instead", error: false)]
        public static SyntaxTree ParseText(
                    SourceText text,
                    CSharpParseOptions? options,
                    string path,
                    ImmutableDictionary<string, ReportDiagnostic>? diagnosticOptions,
                    bool? isGeneratedCode,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10039, 21190, 22693);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 21779, 21890) || true) && (text == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 21779, 21890);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 21829, 21875);

                    throw f_10039_21835_21874(nameof(text));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 21779, 21890);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 21906, 21954);

                options = options ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?>(10039, 21916, 21953) ?? f_10039_21927_21953());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 21970, 22028);

                using var
                lexer = f_10039_21988_22027(text, options)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 22042, 22170);

                using var
                parser = f_10039_22061_22169(lexer, oldTree: null, changes: null, cancellationToken: cancellationToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 22184, 22271);

                var
                compilationUnit = (CompilationUnitSyntax)f_10039_22229_22270(f_10039_22229_22258(parser))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 22285, 22622);

                var
                tree = f_10039_22296_22621(text, f_10039_22358_22371(text), f_10039_22390_22412(text), path, options, compilationUnit, f_10039_22514_22531(parser), diagnosticOptions: diagnosticOptions, cloneRoot: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 22636, 22656);

                f_10039_22636_22655(tree);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 22670, 22682);

                return tree;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10039, 21190, 22693);

                System.ArgumentNullException
                f_10039_21835_21874(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 21835, 21874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10039_21927_21953()
                {
                    var return_v = CSharpParseOptions.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 21927, 21953);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                f_10039_21988_22027(Microsoft.CodeAnalysis.Text.SourceText
                text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer(text, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 21988, 22027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                f_10039_22061_22169(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                lexer, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                oldTree, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextChangeRange>
                changes, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser(lexer, oldTree: oldTree, changes: changes, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 22061, 22169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CompilationUnitSyntax
                f_10039_22229_22258(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.ParseCompilationUnit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 22229, 22258);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10039_22229_22270(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 22229, 22270);
                    return return_v;
                }


                System.Text.Encoding?
                f_10039_22358_22371(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 22358, 22371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                f_10039_22390_22412(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.ChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 22390, 22412);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                f_10039_22514_22531(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.Directives;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 22514, 22531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParsedSyntaxTree
                f_10039_22296_22621(Microsoft.CodeAnalysis.Text.SourceText
                textOpt, System.Text.Encoding?
                encodingOpt, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, string
                path, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options, Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                root, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                directives, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>?
                diagnosticOptions, bool
                cloneRoot)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParsedSyntaxTree(textOpt, encodingOpt, checksumAlgorithm, path, options, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)root, directives, diagnosticOptions: diagnosticOptions, cloneRoot: cloneRoot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 22296, 22621);
                    return return_v;
                }


                int
                f_10039_22636_22655(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParsedSyntaxTree
                tree)
                {
                    tree.VerifySource();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 22636, 22655);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 21190, 22693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 21190, 22693);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override SyntaxTree WithChangedText(SourceText newText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 23186, 23944);
                Microsoft.CodeAnalysis.Text.SourceText? oldText = default(Microsoft.CodeAnalysis.Text.SourceText?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 23352, 23691) || true) && (f_10039_23356_23396(this, out oldText))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 23352, 23691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 23430, 23477);

                    var
                    changes = f_10039_23444_23476(newText, oldText)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 23497, 23614) || true) && (f_10039_23501_23514(changes) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10039, 23501, 23541) && newText == oldText))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 23497, 23614);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 23583, 23595);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 23497, 23614);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 23634, 23676);

                    return f_10039_23641_23675(this, newText, changes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 23352, 23691);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 23823, 23933);

                return f_10039_23830_23932(this, newText, new[] { f_10039_23864_23929(f_10039_23884_23912(0, f_10039_23900_23911(this)), f_10039_23914_23928(newText)) });
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 23186, 23944);

                bool
                f_10039_23356_23396(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, out Microsoft.CodeAnalysis.Text.SourceText?
                text)
                {
                    var return_v = this_param.TryGetText(out text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 23356, 23396);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Text.TextChangeRange>
                f_10039_23444_23476(Microsoft.CodeAnalysis.Text.SourceText
                this_param, Microsoft.CodeAnalysis.Text.SourceText
                oldText)
                {
                    var return_v = this_param.GetChangeRanges(oldText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 23444, 23476);
                    return return_v;
                }


                int
                f_10039_23501_23514(System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Text.TextChangeRange>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 23501, 23514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10039_23641_23675(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, Microsoft.CodeAnalysis.Text.SourceText
                newText, System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Text.TextChangeRange>
                changes)
                {
                    var return_v = this_param.WithChanges(newText, changes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 23641, 23675);
                    return return_v;
                }


                int
                f_10039_23900_23911(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 23900, 23911);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10039_23884_23912(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 23884, 23912);
                    return return_v;
                }


                int
                f_10039_23914_23928(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 23914, 23928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextChangeRange
                f_10039_23864_23929(Microsoft.CodeAnalysis.Text.TextSpan
                span, int
                newLength)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextChangeRange(span, newLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 23864, 23929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10039_23830_23932(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, Microsoft.CodeAnalysis.Text.SourceText
                newText, Microsoft.CodeAnalysis.Text.TextChangeRange[]
                changes)
                {
                    var return_v = this_param.WithChanges(newText, (System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Text.TextChangeRange>)changes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 23830, 23932);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 23186, 23944);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 23186, 23944);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxTree WithChanges(SourceText newText, IReadOnlyList<TextChangeRange> changes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 23956, 25479);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 24071, 24188) || true) && (changes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 24071, 24188);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 24124, 24173);

                    throw f_10039_24130_24172(nameof(changes));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 24071, 24188);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 24204, 24261);

                IReadOnlyList<TextChangeRange>?
                workingChanges = changes
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 24275, 24308);

                CSharpSyntaxTree?
                oldTree = this
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 24384, 24697) || true) && (f_10039_24388_24408(workingChanges) == 1 && (DynAbs.Tracing.TraceSender.Expression_True(10039, 24388, 24471) && workingChanges[0].Span == f_10039_24443_24471(0, f_10039_24459_24470(this))) && (DynAbs.Tracing.TraceSender.Expression_True(10039, 24388, 24520) && workingChanges[0].NewLength == f_10039_24506_24520(newText)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 24384, 24697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 24627, 24649);

                    workingChanges = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 24667, 24682);

                    oldTree = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 24384, 24697);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 24713, 24779);

                using var
                lexer = f_10039_24731_24778(newText, f_10039_24765_24777(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 24793, 24889);

                using var
                parser = f_10039_24812_24888(lexer, f_10039_24861_24871(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(oldTree, 10039, 24853, 24871)), workingChanges)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 24905, 24992);

                var
                compilationUnit = (CompilationUnitSyntax)f_10039_24950_24991(f_10039_24950_24979(parser))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 25006, 25401);

                var
                tree = f_10039_25017_25400(newText, f_10039_25082_25098(newText), f_10039_25117_25142(newText), f_10039_25161_25169(), f_10039_25188_25195(), compilationUnit, f_10039_25248_25265(parser), f_10039_25316_25333(), cloneRoot: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 25415, 25442);

                f_10039_25415_25441(tree, changes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 25456, 25468);

                return tree;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 23956, 25479);

                System.ArgumentNullException
                f_10039_24130_24172(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 24130, 24172);
                    return return_v;
                }


                int
                f_10039_24388_24408(System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Text.TextChangeRange>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 24388, 24408);
                    return return_v;
                }


                int
                f_10039_24459_24470(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 24459, 24470);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10039_24443_24471(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 24443, 24471);
                    return return_v;
                }


                int
                f_10039_24506_24520(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 24506, 24520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10039_24765_24777(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 24765, 24777);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                f_10039_24731_24778(Microsoft.CodeAnalysis.Text.SourceText
                text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer(text, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 24731, 24778);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10039_24861_24871(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param)
                {
                    var return_v = this_param?.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 24861, 24871);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                f_10039_24812_24888(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                lexer, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                oldTree, System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Text.TextChangeRange>?
                changes)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser(lexer, oldTree, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextChangeRange>?)changes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 24812, 24888);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CompilationUnitSyntax
                f_10039_24950_24979(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.ParseCompilationUnit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 24950, 24979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10039_24950_24991(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 24950, 24991);
                    return return_v;
                }


                System.Text.Encoding?
                f_10039_25082_25098(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 25082, 25098);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                f_10039_25117_25142(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.ChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 25117, 25142);
                    return return_v;
                }


                string
                f_10039_25161_25169()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 25161, 25169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10039_25188_25195()
                {
                    var return_v = Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 25188, 25195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                f_10039_25248_25265(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.Directives;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 25248, 25265);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_10039_25316_25333()
                {
                    var return_v = DiagnosticOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 25316, 25333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParsedSyntaxTree
                f_10039_25017_25400(Microsoft.CodeAnalysis.Text.SourceText
                textOpt, System.Text.Encoding?
                encodingOpt, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, string
                path, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options, Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                root, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                directives, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                diagnosticOptions, bool
                cloneRoot)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParsedSyntaxTree(textOpt, encodingOpt, checksumAlgorithm, path, options, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)root, directives, diagnosticOptions, cloneRoot: cloneRoot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 25017, 25400);
                    return return_v;
                }


                int
                f_10039_25415_25441(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParsedSyntaxTree
                tree, System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Text.TextChangeRange>
                changes)
                {
                    tree.VerifySource((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextChangeRange>)changes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 25415, 25441);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 23956, 25479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 23956, 25479);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IList<TextSpan> GetChangedSpans(SyntaxTree oldTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 25897, 26198);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 25989, 26106) || true) && (oldTree == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 25989, 26106);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 26042, 26091);

                    throw f_10039_26048_26090(nameof(oldTree));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 25989, 26106);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 26122, 26187);

                return f_10039_26129_26186(oldTree, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 25897, 26198);

                System.ArgumentNullException
                f_10039_26048_26090(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 26048, 26090);
                    return return_v;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.Text.TextSpan>
                f_10039_26129_26186(Microsoft.CodeAnalysis.SyntaxTree
                before, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                after)
                {
                    var return_v = SyntaxDiffer.GetPossiblyDifferentTextSpans(before, (Microsoft.CodeAnalysis.SyntaxTree)after);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 26129, 26186);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 25897, 26198);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 25897, 26198);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IList<TextChange> GetChanges(SyntaxTree oldTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 26551, 26834);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 26640, 26757) || true) && (oldTree == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 26640, 26757);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 26693, 26742);

                    throw f_10039_26699_26741(nameof(oldTree));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 26640, 26757);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 26773, 26823);

                return f_10039_26780_26822(oldTree, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 26551, 26834);

                System.ArgumentNullException
                f_10039_26699_26741(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 26699, 26741);
                    return return_v;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.Text.TextChange>
                f_10039_26780_26822(Microsoft.CodeAnalysis.SyntaxTree
                before, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                after)
                {
                    var return_v = SyntaxDiffer.GetTextChanges(before, (Microsoft.CodeAnalysis.SyntaxTree)after);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 26780, 26822);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 26551, 26834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 26551, 26834);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override FileLinePositionSpan GetLineSpan(TextSpan span, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 27427, 27676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 27562, 27665);

                return f_10039_27569_27664(f_10039_27594_27607(this), f_10039_27609_27636(this, span.Start), f_10039_27638_27663(this, span.End));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 27427, 27676);

                string
                f_10039_27594_27607(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 27594, 27607);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.LinePosition
                f_10039_27609_27636(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, int
                position)
                {
                    var return_v = this_param.GetLinePosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 27609, 27636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.LinePosition
                f_10039_27638_27663(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, int
                position)
                {
                    var return_v = this_param.GetLinePosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 27638, 27663);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FileLinePositionSpan
                f_10039_27569_27664(string
                path, Microsoft.CodeAnalysis.Text.LinePosition
                start, Microsoft.CodeAnalysis.Text.LinePosition
                end)
                {
                    var return_v = new Microsoft.CodeAnalysis.FileLinePositionSpan(path, start, end);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 27569, 27664);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 27427, 27676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 27427, 27676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override FileLinePositionSpan GetMappedLineSpan(TextSpan span, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 28657, 29160);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 28798, 29036) || true) && (_lazyLineDirectiveMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 28798, 29036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 28926, 29021);

                    f_10039_28926_29020(ref _lazyLineDirectiveMap, f_10039_28981_29013(this), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 28798, 29036);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 29052, 29149);

                return f_10039_29059_29148(_lazyLineDirectiveMap, f_10039_29095_29126(this, cancellationToken), f_10039_29128_29141(this), span);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 28657, 29160);

                Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap
                f_10039_28981_29013(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                syntaxTree)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap((Microsoft.CodeAnalysis.SyntaxTree)syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 28981, 29013);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap?
                f_10039_28926_29020(ref Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap?
                location1, Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap
                value, Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 28926, 29020);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_10039_29095_29126(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetText(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 29095, 29126);
                    return return_v;
                }


                string
                f_10039_29128_29141(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 29128, 29141);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FileLinePositionSpan
                f_10039_29059_29148(Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap
                this_param, Microsoft.CodeAnalysis.Text.SourceText
                sourceText, string
                treeFilePath, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.TranslateSpan(sourceText, treeFilePath, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 29059, 29148);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 28657, 29160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 28657, 29160);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override LineVisibility GetLineVisibility(int position, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 29172, 29661);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 29306, 29544) || true) && (_lazyLineDirectiveMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 29306, 29544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 29434, 29529);

                    f_10039_29434_29528(ref _lazyLineDirectiveMap, f_10039_29489_29521(this), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 29306, 29544);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 29560, 29650);

                return f_10039_29567_29649(_lazyLineDirectiveMap, f_10039_29607_29638(this, cancellationToken), position);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 29172, 29661);

                Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap
                f_10039_29489_29521(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                syntaxTree)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap((Microsoft.CodeAnalysis.SyntaxTree)syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 29489, 29521);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap?
                f_10039_29434_29528(ref Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap?
                location1, Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap
                value, Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 29434, 29528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_10039_29607_29638(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetText(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 29607, 29638);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LineVisibility
                f_10039_29567_29649(Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap
                this_param, Microsoft.CodeAnalysis.Text.SourceText
                sourceText, int
                position)
                {
                    var return_v = this_param.GetLineVisibility(sourceText, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 29567, 29649);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 29172, 29661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 29172, 29661);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override FileLinePositionSpan GetMappedLineSpanAndVisibility(TextSpan span, out bool isHiddenPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 30224, 30740);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 30360, 30598) || true) && (_lazyLineDirectiveMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 30360, 30598);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 30488, 30583);

                    f_10039_30488_30582(ref _lazyLineDirectiveMap, f_10039_30543_30575(this), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 30360, 30598);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 30614, 30729);

                return f_10039_30621_30728(_lazyLineDirectiveMap, f_10039_30670_30684(this), f_10039_30686_30699(this), span, out isHiddenPosition);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 30224, 30740);

                Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap
                f_10039_30543_30575(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                syntaxTree)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap((Microsoft.CodeAnalysis.SyntaxTree)syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 30543, 30575);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap?
                f_10039_30488_30582(ref Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap?
                location1, Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap
                value, Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 30488, 30582);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_10039_30670_30684(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param)
                {
                    var return_v = this_param.GetText();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 30670, 30684);
                    return return_v;
                }


                string
                f_10039_30686_30699(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 30686, 30699);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FileLinePositionSpan
                f_10039_30621_30728(Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap
                this_param, Microsoft.CodeAnalysis.Text.SourceText
                sourceText, string
                treeFilePath, Microsoft.CodeAnalysis.Text.TextSpan
                span, out bool
                isHiddenPosition)
                {
                    var return_v = this_param.TranslateSpanAndVisibility(sourceText, treeFilePath, span, out isHiddenPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 30621, 30728);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 30224, 30740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 30224, 30740);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool HasHiddenRegions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 30971, 31351);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 31035, 31273) || true) && (_lazyLineDirectiveMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 31035, 31273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 31163, 31258);

                    f_10039_31163_31257(ref _lazyLineDirectiveMap, f_10039_31218_31250(this), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 31035, 31273);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 31289, 31340);

                return f_10039_31296_31339(_lazyLineDirectiveMap);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 30971, 31351);

                Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap
                f_10039_31218_31250(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                syntaxTree)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap((Microsoft.CodeAnalysis.SyntaxTree)syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 31218, 31250);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap?
                f_10039_31163_31257(ref Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap?
                location1, Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap
                value, Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 31163, 31257);
                    return return_v;
                }


                bool
                f_10039_31296_31339(Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap
                this_param)
                {
                    var return_v = this_param.HasAnyHiddenRegions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 31296, 31339);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 30971, 31351);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 30971, 31351);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PragmaWarningState GetPragmaDirectiveWarningState(string id, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 31646, 32097);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 31754, 32006) || true) && (_lazyPragmaWarningStateMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 31754, 32006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 31886, 31991);

                    f_10039_31886_31990(ref _lazyPragmaWarningStateMap, f_10039_31946_31983(this), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 31754, 32006);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 32022, 32086);

                return f_10039_32029_32085(_lazyPragmaWarningStateMap, id, position);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 31646, 32097);

                Microsoft.CodeAnalysis.CSharp.Syntax.CSharpPragmaWarningStateMap
                f_10039_31946_31983(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                syntaxTree)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.CSharpPragmaWarningStateMap((Microsoft.CodeAnalysis.SyntaxTree)syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 31946, 31983);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CSharpPragmaWarningStateMap?
                f_10039_31886_31990(ref Microsoft.CodeAnalysis.CSharp.Syntax.CSharpPragmaWarningStateMap?
                location1, Microsoft.CodeAnalysis.CSharp.Syntax.CSharpPragmaWarningStateMap
                value, Microsoft.CodeAnalysis.CSharp.Syntax.CSharpPragmaWarningStateMap?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 31886, 31990);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningState
                f_10039_32029_32085(Microsoft.CodeAnalysis.CSharp.Syntax.CSharpPragmaWarningStateMap
                this_param, string
                id, int
                position)
                {
                    var return_v = this_param.GetWarningState(id, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 32029, 32085);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 31646, 32097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 31646, 32097);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NullableContextStateMap GetNullableContextStateMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 32109, 32626);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 32194, 32559) || true) && (_lazyNullableContextStateMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 32194, 32559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 32334, 32544);

                    f_10039_32334_32543(ref _lazyNullableContextStateMap, f_10039_32439_32515(NullableContextStateMap.Create(this)), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 32194, 32559);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 32573, 32615);

                return _lazyNullableContextStateMap.Value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 32109, 32626);

                System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap>
                f_10039_32439_32515(Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap
                value)
                {
                    var return_v = new System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap>(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 32439, 32515);
                    return return_v;
                }


                System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap>?
                f_10039_32334_32543(ref System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap>?
                location1, System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap>
                value, System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 32334, 32543);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 32109, 32626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 32109, 32626);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NullableContextState GetNullableContextState(int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 32719, 32776);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 32722, 32776);
                return f_10039_32722_32750(this).GetContextState(position); DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 32719, 32776);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 32719, 32776);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 32719, 32776);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool? IsNullableAnalysisEnabled(TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 32845, 32908);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 32848, 32908);
                return f_10039_32848_32876(this).IsNullableAnalysisEnabled(span); DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 32845, 32908);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 32845, 32908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 32845, 32908);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsGeneratedCode(SyntaxTreeOptionsProvider? provider, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 32921, 34074);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 33049, 33288);

                return f_10039_33065_33102(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(provider, 10039, 33056, 33102), this, cancellationToken) switch
                {
                    null or GeneratedKind.Unknown when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 33142, 33197) && DynAbs.Tracing.TraceSender.Expression_True(10039, 33142, 33197))
    => f_10039_33175_33197(),
                    GeneratedKind kind when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 33216, 33272) && DynAbs.Tracing.TraceSender.Expression_True(10039, 33216, 33272))
    => kind != GeneratedKind.NotGenerated
                };

                bool isGeneratedHeuristic()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 33304, 34063);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 33364, 33967) || true) && (_lazyIsGeneratedCode == GeneratedKind.Unknown)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 33364, 33967);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 33522, 33830);

                            bool
                            isGenerated = f_10039_33541_33829(this, isComment: trivia => trivia.Kind() == SyntaxKind.SingleLineCommentTrivia || trivia.Kind() == SyntaxKind.MultiLineCommentTrivia, cancellationToken: default)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 33852, 33948);

                            _lazyIsGeneratedCode = (DynAbs.Tracing.TraceSender.Conditional_F1(10039, 33875, 33886) || ((isGenerated && DynAbs.Tracing.TraceSender.Conditional_F2(10039, 33889, 33918)) || DynAbs.Tracing.TraceSender.Conditional_F3(10039, 33921, 33947))) ? GeneratedKind.MarkedGenerated : GeneratedKind.NotGenerated;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 33364, 33967);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 33987, 34048);

                        return _lazyIsGeneratedCode == GeneratedKind.MarkedGenerated;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 33304, 34063);

                        bool
                        f_10039_33541_33829(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                        tree, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>
                        isComment, System.Threading.CancellationToken
                        cancellationToken)
                        {
                            var return_v = GeneratedCodeUtilities.IsGeneratedCode((Microsoft.CodeAnalysis.SyntaxTree)tree, isComment: isComment, cancellationToken: cancellationToken);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 33541, 33829);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 33304, 34063);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 33304, 34063);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 32921, 34074);

                Microsoft.CodeAnalysis.GeneratedKind?
                f_10039_33065_33102(Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                tree, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.IsGenerated((Microsoft.CodeAnalysis.SyntaxTree)tree, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 33065, 33102);
                    return return_v;
                }


                bool
                f_10039_33175_33197()
                {
                    var return_v = isGeneratedHeuristic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 33175, 33197);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 32921, 34074);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 32921, 34074);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CSharpLineDirectiveMap? _lazyLineDirectiveMap;

        private CSharpPragmaWarningStateMap? _lazyPragmaWarningStateMap;

        private StrongBox<NullableContextStateMap>? _lazyNullableContextStateMap;

        private GeneratedKind _lazyIsGeneratedCode;

        private LinePosition GetLinePosition(int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 34388, 34528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 34463, 34517);

                return f_10039_34470_34516(f_10039_34470_34490(f_10039_34470_34484(this)), position);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 34388, 34528);

                Microsoft.CodeAnalysis.Text.SourceText
                f_10039_34470_34484(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param)
                {
                    var return_v = this_param.GetText();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 34470, 34484);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextLineCollection
                f_10039_34470_34490(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Lines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 34470, 34490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.LinePosition
                f_10039_34470_34516(Microsoft.CodeAnalysis.Text.TextLineCollection
                this_param, int
                position)
                {
                    var return_v = this_param.GetLinePosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 34470, 34516);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 34388, 34528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 34388, 34528);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Location GetLocation(TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 34678, 34803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 34754, 34792);

                return f_10039_34761_34791(this, span);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 34678, 34803);

                Microsoft.CodeAnalysis.SourceLocation
                f_10039_34761_34791(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation((Microsoft.CodeAnalysis.SyntaxTree)syntaxTree, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 34761, 34791);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 34678, 34803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 34678, 34803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IEnumerable<Diagnostic> GetDiagnostics(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 35211, 35494);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 35307, 35418) || true) && (node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 35307, 35418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 35357, 35403);

                    throw f_10039_35363_35402(nameof(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 35307, 35418);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 35434, 35483);

                return f_10039_35441_35482(this, f_10039_35456_35466(node), f_10039_35468_35481(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 35211, 35494);

                System.ArgumentNullException
                f_10039_35363_35402(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 35363, 35402);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10039_35456_35466(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 35456, 35466);
                    return return_v;
                }


                int
                f_10039_35468_35481(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 35468, 35481);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_10039_35441_35482(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, Microsoft.CodeAnalysis.GreenNode
                greenNode, int
                position)
                {
                    var return_v = this_param.GetDiagnostics(greenNode, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 35441, 35482);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 35211, 35494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 35211, 35494);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerable<Diagnostic> GetDiagnostics(GreenNode greenNode, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 35506, 35954);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 35612, 35720) || true) && (greenNode == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 35612, 35720);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 35667, 35705);

                    throw f_10039_35673_35704();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 35612, 35720);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 35736, 35867) || true) && (f_10039_35740_35769(greenNode))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 35736, 35867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 35803, 35852);

                    return f_10039_35810_35851(this, greenNode, position);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 35736, 35867);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 35883, 35943);

                return f_10039_35890_35942();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 35506, 35954);

                System.InvalidOperationException
                f_10039_35673_35704()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 35673, 35704);
                    return return_v;
                }


                bool
                f_10039_35740_35769(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.ContainsDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 35740, 35769);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_10039_35810_35851(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, Microsoft.CodeAnalysis.GreenNode
                node, int
                position)
                {
                    var return_v = this_param.EnumerateDiagnostics(node, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 35810, 35851);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_10039_35890_35942()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 35890, 35942);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 35506, 35954);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 35506, 35954);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerable<Diagnostic> EnumerateDiagnostics(GreenNode node, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 35966, 36281);

                var listYield = new List<Diagnostic>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 36073, 36147);

                var
                enumerator = f_10039_36090_36146(this, node, position)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 36161, 36270) || true) && (enumerator.MoveNext())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 36161, 36270);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 36223, 36255);

                        listYield.Add(enumerator.Current);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 36161, 36270);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10039, 36161, 36270);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10039, 36161, 36270);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 35966, 36281);

                return listYield;

                Microsoft.CodeAnalysis.CSharp.SyntaxTreeDiagnosticEnumerator
                f_10039_36090_36146(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                syntaxTree, Microsoft.CodeAnalysis.GreenNode
                node, int
                position)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxTreeDiagnosticEnumerator((Microsoft.CodeAnalysis.SyntaxTree)syntaxTree, node, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 36090, 36146);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 35966, 36281);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 35966, 36281);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IEnumerable<Diagnostic> GetDiagnostics(SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 36629, 36911);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 36727, 36836) || true) && (token.Node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 36727, 36836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 36783, 36821);

                    throw f_10039_36789_36820();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 36727, 36836);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 36850, 36900);

                return f_10039_36857_36899(this, token.Node, token.Position);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 36629, 36911);

                System.InvalidOperationException
                f_10039_36789_36820()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 36789, 36820);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_10039_36857_36899(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, Microsoft.CodeAnalysis.GreenNode
                greenNode, int
                position)
                {
                    var return_v = this_param.GetDiagnostics(greenNode, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 36857, 36899);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 36629, 36911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 36629, 36911);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IEnumerable<Diagnostic> GetDiagnostics(SyntaxTrivia trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 37237, 37544);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 37337, 37457) || true) && (trivia.UnderlyingNode == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 37337, 37457);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 37404, 37442);

                    throw f_10039_37410_37441();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 37337, 37457);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 37471, 37533);

                return f_10039_37478_37532(this, trivia.UnderlyingNode, trivia.Position);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 37237, 37544);

                System.InvalidOperationException
                f_10039_37410_37441()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 37410, 37441);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_10039_37478_37532(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, Microsoft.CodeAnalysis.GreenNode
                greenNode, int
                position)
                {
                    var return_v = this_param.GetDiagnostics(greenNode, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 37478, 37532);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 37237, 37544);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 37237, 37544);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IEnumerable<Diagnostic> GetDiagnostics(SyntaxNodeOrToken nodeOrToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 37971, 38303);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 38081, 38206) || true) && (nodeOrToken.UnderlyingNode == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 38081, 38206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 38153, 38191);

                    throw f_10039_38159_38190();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 38081, 38206);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 38220, 38292);

                return f_10039_38227_38291(this, nodeOrToken.UnderlyingNode, nodeOrToken.Position);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 37971, 38303);

                System.InvalidOperationException
                f_10039_38159_38190()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 38159, 38190);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_10039_38227_38291(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, Microsoft.CodeAnalysis.GreenNode
                greenNode, int
                position)
                {
                    var return_v = this_param.GetDiagnostics(greenNode, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 38227, 38291);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 37971, 38303);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 37971, 38303);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IEnumerable<Diagnostic> GetDiagnostics(CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 38621, 38818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 38747, 38807);

                return f_10039_38754_38806(this, f_10039_38774_38805(this, cancellationToken));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 38621, 38818);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10039_38774_38805(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetRoot(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 38774, 38805);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_10039_38754_38806(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetDiagnostics((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 38754, 38806);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 38621, 38818);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 38621, 38818);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override SyntaxNode GetRootCore(CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 38882, 39035);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 38985, 39024);

                return f_10039_38992_39023(this, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 38882, 39035);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10039_38992_39023(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetRoot(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 38992, 39023);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 38882, 39035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 38882, 39035);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override async Task<SyntaxNode> GetRootAsyncCore(CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 39047, 39250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 39167, 39239);

                return await f_10039_39180_39238(f_10039_39180_39216(this, cancellationToken), false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 39047, 39250);

                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>
                f_10039_39180_39216(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetRootAsync(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 39180, 39216);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>
                f_10039_39180_39238(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 39180, 39238);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 39047, 39250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 39047, 39250);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool TryGetRootCore([NotNullWhen(true)] out SyntaxNode? root)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 39262, 39625);
                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode? node = default(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 39367, 39614) || true) && (f_10039_39371_39414(this, out node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 39367, 39614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 39448, 39460);

                    root = node;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 39478, 39490);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 39367, 39614);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10039, 39367, 39614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 39556, 39568);

                    root = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 39586, 39599);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10039, 39367, 39614);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 39262, 39625);

                bool
                f_10039_39371_39414(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, out Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                root)
                {
                    var return_v = this_param.TryGetRoot(out root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 39371, 39414);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 39262, 39625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 39262, 39625);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ParseOptions OptionsCore
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 39705, 39776);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 39741, 39761);

                    return f_10039_39748_39760(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 39705, 39776);

                    Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                    f_10039_39748_39760(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                    this_param)
                    {
                        var return_v = this_param.Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10039, 39748, 39760);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 39637, 39787);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 39637, 39787);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The diagnosticOptions parameter is obsolete due to performance problems, if you are passing non-null use CompilationOptions.SyntaxTreeOptionsProvider instead", error: false)]
        public static SyntaxTree ParseText(
                    SourceText text,
                    CSharpParseOptions? options,
                    string path,
                    ImmutableDictionary<string, ReportDiagnostic>? diagnosticOptions,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 40401, 40495);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 40404, 40495);
                return f_10039_40404_40495(text, options, path, diagnosticOptions, isGeneratedCode: null, cancellationToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 40401, 40495);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 40401, 40495);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 40401, 40495);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The diagnosticOptions parameter is obsolete due to performance problems, if you are passing non-null use CompilationOptions.SyntaxTreeOptionsProvider instead", error: false)]
        public static SyntaxTree ParseText(
                    string text,
                    CSharpParseOptions? options,
                    string path,
                    Encoding? encoding,
                    ImmutableDictionary<string, ReportDiagnostic>? diagnosticOptions,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 41117, 41221);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 41120, 41221);
                return f_10039_41120_41221(text, options, path, encoding, diagnosticOptions, isGeneratedCode: null, cancellationToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 41117, 41221);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 41117, 41221);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 41117, 41221);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The diagnosticOptions parameter is obsolete due to performance problems, if you are passing non-null use CompilationOptions.SyntaxTreeOptionsProvider instead", error: false)]
        public static SyntaxTree Create(
                    CSharpSyntaxNode root,
                    CSharpParseOptions? options,
                    string path,
                    Encoding? encoding,
                    ImmutableDictionary<string, ReportDiagnostic>? diagnosticOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10039, 41800, 41882);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 41803, 41882);
                return f_10039_41803_41882(root, options, path, encoding, diagnosticOptions, isGeneratedCode: null); DynAbs.Tracing.TraceSender.TraceExitMethod(10039, 41800, 41882);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10039, 41800, 41882);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 41800, 41882);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CSharpSyntaxTree()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10039, 885, 41892);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 6008, 6022);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 34118, 34139);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 34187, 34213);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 34268, 34296);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 34331, 34375);
            this._lazyIsGeneratedCode = GeneratedKind.Unknown; DynAbs.Tracing.TraceSender.TraceExitConstructor(10039, 885, 41892);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 885, 41892);
        }


        static CSharpSyntaxTree()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10039, 885, 41892);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10039, 997, 1026);
            Dummy = f_10039_1005_1026(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10039, 885, 41892);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10039, 885, 41892);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10039, 885, 41892);

        static Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.DummySyntaxTree
        f_10039_1005_1026()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.DummySyntaxTree();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 1005, 1026);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap
        f_10039_32722_32750(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
        this_param)
        {
            var return_v = this_param.GetNullableContextStateMap();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 32722, 32750);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextStateMap
        f_10039_32848_32876(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
        this_param)
        {
            var return_v = this_param.GetNullableContextStateMap();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 32848, 32876);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree
        f_10039_40404_40495(Microsoft.CodeAnalysis.Text.SourceText
        text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
        options, string
        path, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>?
        diagnosticOptions, bool?
        isGeneratedCode, System.Threading.CancellationToken
        cancellationToken)
        {
            var return_v = ParseText(text, options, path, diagnosticOptions, isGeneratedCode: isGeneratedCode, cancellationToken);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 40404, 40495);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree
        f_10039_41120_41221(string
        text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
        options, string
        path, System.Text.Encoding?
        encoding, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>?
        diagnosticOptions, bool?
        isGeneratedCode, System.Threading.CancellationToken
        cancellationToken)
        {
            var return_v = ParseText(text, options, path, encoding, diagnosticOptions, isGeneratedCode: isGeneratedCode, cancellationToken);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 41120, 41221);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree
        f_10039_41803_41882(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        root, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
        options, string
        path, System.Text.Encoding?
        encoding, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>?
        diagnosticOptions, bool?
        isGeneratedCode)
        {
            var return_v = Create(root, options, path, encoding, diagnosticOptions, isGeneratedCode: isGeneratedCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10039, 41803, 41882);
            return return_v;
        }

    }
}
